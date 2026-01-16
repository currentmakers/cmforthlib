\
\ @file fmac.fs
\ @brief Filter Math Accelerator
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief FMAC X1 buffer configuration register
\ Address offset: 0x00
\ Reset value: 0x00000000
\

$000000ff constant FMAC_FMAC_X1BUFCFG_X1_BASE                       \ Base address of X1 buffer
$0000ff00 constant FMAC_FMAC_X1BUFCFG_X1_BUF_SIZE                   \ Allocated size of X1 buffer in 16-bit words The minimum buffer size is the number of feed-forward taps in the filter (+ the watermark threshold1).
$03000000 constant FMAC_FMAC_X1BUFCFG_FULL_WM                       \ Watermark for buffer full flag Defines the threshold for setting the X1 buffer full flag when operating in circular mode. The flag is set if the number of free spaces in the buffer is less than 2FULL_WM. 2: Threshold = 4 3: Threshold = 8 Setting a threshold greater than 1 allows several data to be transferred into the buffer under one interrupt. Threshold should be set to 1 if DMA write requests are enabled (DMAWEN = 1 in FMAC_CR register).


\
\ @brief FMAC X2 buffer configuration register
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$000000ff constant FMAC_FMAC_X2BUFCFG_X2_BASE                       \ Base address of X2 buffer The X2 buffer base address can be modified while START=1, for example to change coefficient values. The filter should be stalled when doing this, since changing the coefficients while a calculation is ongoing affects the result.
$0000ff00 constant FMAC_FMAC_X2BUFCFG_X2_BUF_SIZE                   \ Size of X2 buffer in 16-bit words This bitfield can not be modified when a function is ongoing (START = 1).


\
\ @brief FMAC Y buffer configuration register
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$000000ff constant FMAC_FMAC_YBUFCFG_Y_BASE                         \ Base address of Y buffer
$0000ff00 constant FMAC_FMAC_YBUFCFG_Y_BUF_SIZE                     \ Size of Y buffer in 16-bit words For FIR filters, the minimum buffer size is 1 (+ the watermark threshold). For IIR filters the minimum buffer size is the number of feedback taps (+ the watermark threshold).
$03000000 constant FMAC_FMAC_YBUFCFG_EMPTY_WM                       \ Watermark for buffer empty flag Defines the threshold for setting the Y buffer empty flag when operating in circular mode. The flag is set if the number of unread values in the buffer is less than 2EMPTY_WM. 2: Threshold = 4 3: Threshold = 8 Setting a threshold greater than 1 allows several data to be transferred from the buffer under one interrupt. Threshold should be set to 1 if DMA read requests are enabled (DMAREN = 1 in FMAC_CR register).


\
\ @brief FMAC parameter register
\ Address offset: 0x0C
\ Reset value: 0x00000000
\

$000000ff constant FMAC_FMAC_PARAM_P                                \ Input parameter P. The value of this parameter is dependent on the function This bitfield can not be modified when a function is ongoing (START = 1)
$0000ff00 constant FMAC_FMAC_PARAM_Q                                \ Input parameter Q. The value of this parameter is dependent on the function. This bitfield can not be modified when a function is ongoing (START = 1)
$00ff0000 constant FMAC_FMAC_PARAM_R                                \ Input parameter R. The value of this parameter is dependent on the function. This bitfield can not be modified when a function is ongoing (START = 1)
$7f000000 constant FMAC_FMAC_PARAM_FUNC                             \ Function 2: Load X2 buffer 3: Load Y buffer 4 to 7: Reserved 8: Convolution (FIR filter) 9: IIR filter (direct form 1) This bitfield can not be modified when a function is ongoing (START = 1)
$80000000 constant FMAC_FMAC_PARAM_START                            \ Enable execution Setting this bit triggers the execution of the function selected in the FUNC bitfield. Resetting it by software stops any ongoing function. For initialization functions, this bit is reset by hardware.


\
\ @brief FMAC control register
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$00000001 constant FMAC_FMAC_CR_RIEN                                \ Enable read interrupt This bit is set and cleared by software. A read returns the current state of the bit.
$00000002 constant FMAC_FMAC_CR_WIEN                                \ Enable write interrupt This bit is set and cleared by software. A read returns the current state of the bit.
$00000004 constant FMAC_FMAC_CR_OVFLIEN                             \ Enable overflow error interrupts This bit is set and cleared by software. A read returns the current state of the bit.
$00000008 constant FMAC_FMAC_CR_UNFLIEN                             \ Enable underflow error interrupts This bit is set and cleared by software. A read returns the current state of the bit.
$00000010 constant FMAC_FMAC_CR_SATIEN                              \ Enable saturation error interrupts This bit is set and cleared by software. A read returns the current state of the bit.
$00000100 constant FMAC_FMAC_CR_DMAREN                              \ Enable DMA read channel requests This bit can only be modified when START= 0 in the FMAC_PARAM register. A read returns the current state of the bit.
$00000200 constant FMAC_FMAC_CR_DMAWEN                              \ Enable DMA write channel requests This bit can only be modified when START= 0 in the FMAC_PARAM register. A read returns the current state of the bit.
$00008000 constant FMAC_FMAC_CR_CLIPEN                              \ Enable clipping
$00010000 constant FMAC_FMAC_CR_RESET                               \ Reset FMAC unit This resets the write and read pointers, the internal control logic, the FMAC_SR register and the FMAC_PARAM register, including the START bit if active. Other register settings are not affected. This bit is reset by hardware.


\
\ @brief FMAC status register
\ Address offset: 0x14
\ Reset value: 0x00000001
\

$00000001 constant FMAC_FMAC_SR_YEMPTY                              \ Y buffer empty flag The buffer is flagged as empty if the number of unread data is less than the EMPTY_WM threshold. The number of unread data is the difference between the read pointer and the current output destination address. This flag is set and cleared by hardware, or by a reset. Note: after the last sample is read from the Y buffer there is a delay of 3 clock cycles before the YEMPTY flag goes high. To avoid any risk of underflow it is recommended to insert a software delay after reading from the Y buffer before reading the FMAC_SR. Alternatively, an EMPTY_WM threshold of 2 can be used.
$00000002 constant FMAC_FMAC_SR_X1FULL                              \ X1 buffer full flag The buffer is flagged as full if the number of available spaces is less than the FULL_WM threshold. The number of available spaces is the difference between the write pointer and the least recent sample currently in use. This flag is set and cleared by hardware, or by a reset. Note: after the last available space in the X1 buffer is filled there is a delay of 3 clock cycles before the X1FULL flag goes high. To avoid any risk of overflow it is recommended to insert a software delay after writing to the X1 buffer before reading the FMAC_SR. Alternatively, a FULL_WM threshold of 2 can be used.
$00000100 constant FMAC_FMAC_SR_OVFL                                \ Overflow error flag An overflow occurs when a write is made to FMAC_WDATA when no free space is available in the X1 buffer. This flag is cleared by a reset of the unit.
$00000200 constant FMAC_FMAC_SR_UNFL                                \ Underflow error flag An underflow occurs when a read is made from FMAC_RDATA when no valid data is available in the Y buffer. This flag is cleared by a reset of the unit.
$00000400 constant FMAC_FMAC_SR_SAT                                 \ Saturation error flag Saturation occurs when the result of an accumulation exceeds the numeric range of the accumulator. This flag is cleared by a reset of the unit.


\
\ @brief FMAC write data register
\ Address offset: 0x18
\ Reset value: 0x00000000
\

$0000ffff constant FMAC_FMAC_WDATA_WDATA                            \ Write data When a write access to this register occurs, the write data are transferred to the address offset indicated by the write pointer. The pointer address is automatically incremented after each write access.


\
\ @brief FMAC read data register
\ Address offset: 0x1C
\ Reset value: 0x00000000
\

$0000ffff constant FMAC_FMAC_RDATA_RDATA                            \ Read data When a read access to this register occurs, the read data are the contents of the Y output buffer at the address offset indicated by the READ pointer. The pointer address is automatically incremented after each read access.


\
\ @brief Filter Math Accelerator
\
$40023c00 constant FMAC_FMAC_X1BUFCFG  \ offset: 0x00 : FMAC X1 buffer configuration register
$40023c04 constant FMAC_FMAC_X2BUFCFG  \ offset: 0x04 : FMAC X2 buffer configuration register
$40023c08 constant FMAC_FMAC_YBUFCFG  \ offset: 0x08 : FMAC Y buffer configuration register
$40023c0c constant FMAC_FMAC_PARAM  \ offset: 0x0C : FMAC parameter register
$40023c10 constant FMAC_FMAC_CR   \ offset: 0x10 : FMAC control register
$40023c14 constant FMAC_FMAC_SR   \ offset: 0x14 : FMAC status register
$40023c18 constant FMAC_FMAC_WDATA  \ offset: 0x18 : FMAC write data register
$40023c1c constant FMAC_FMAC_RDATA  \ offset: 0x1C : FMAC read data register

