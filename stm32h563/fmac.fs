\
\ @file fmac.fs
\ @brief Filter Math Accelerator
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] FMAC_DEF

  [ifdef] FMAC_FMAC_X1BUFCFG_DEF
    \
    \ @brief FMAC X1 buffer configuration register
    \ Address offset: 0x00
    \ Reset value: 0x00000000
    \
    $00 constant FMAC_X1_BASE                   \ [0x00 : 8] Base address of X1 buffer
    $08 constant FMAC_X1_BUF_SIZE               \ [0x08 : 8] Allocated size of X1 buffer in 16-bit words The minimum buffer size is the number of feed-forward taps in the filter (+ the watermark threshold1).
    $18 constant FMAC_FULL_WM                   \ [0x18 : 2] Watermark for buffer full flag Defines the threshold for setting the X1 buffer full flag when operating in circular mode. The flag is set if the number of free spaces in the buffer is less than 2FULL_WM. 2: Threshold = 4 3: Threshold = 8 Setting a threshold greater than 1 allows several data to be transferred into the buffer under one interrupt. Threshold should be set to 1 if DMA write requests are enabled (DMAWEN = 1 in FMAC_CR register).
  [then]


  [ifdef] FMAC_FMAC_X2BUFCFG_DEF
    \
    \ @brief FMAC X2 buffer configuration register
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $00 constant FMAC_X2_BASE                   \ [0x00 : 8] Base address of X2 buffer The X2 buffer base address can be modified while START=1, for example to change coefficient values. The filter should be stalled when doing this, since changing the coefficients while a calculation is ongoing affects the result.
    $08 constant FMAC_X2_BUF_SIZE               \ [0x08 : 8] Size of X2 buffer in 16-bit words This bitfield can not be modified when a function is ongoing (START = 1).
  [then]


  [ifdef] FMAC_FMAC_YBUFCFG_DEF
    \
    \ @brief FMAC Y buffer configuration register
    \ Address offset: 0x08
    \ Reset value: 0x00000000
    \
    $00 constant FMAC_Y_BASE                    \ [0x00 : 8] Base address of Y buffer
    $08 constant FMAC_Y_BUF_SIZE                \ [0x08 : 8] Size of Y buffer in 16-bit words For FIR filters, the minimum buffer size is 1 (+ the watermark threshold). For IIR filters the minimum buffer size is the number of feedback taps (+ the watermark threshold).
    $18 constant FMAC_EMPTY_WM                  \ [0x18 : 2] Watermark for buffer empty flag Defines the threshold for setting the Y buffer empty flag when operating in circular mode. The flag is set if the number of unread values in the buffer is less than 2EMPTY_WM. 2: Threshold = 4 3: Threshold = 8 Setting a threshold greater than 1 allows several data to be transferred from the buffer under one interrupt. Threshold should be set to 1 if DMA read requests are enabled (DMAREN = 1 in FMAC_CR register).
  [then]


  [ifdef] FMAC_FMAC_PARAM_DEF
    \
    \ @brief FMAC parameter register
    \ Address offset: 0x0C
    \ Reset value: 0x00000000
    \
    $00 constant FMAC_P                         \ [0x00 : 8] Input parameter P. The value of this parameter is dependent on the function This bitfield can not be modified when a function is ongoing (START = 1)
    $08 constant FMAC_Q                         \ [0x08 : 8] Input parameter Q. The value of this parameter is dependent on the function. This bitfield can not be modified when a function is ongoing (START = 1)
    $10 constant FMAC_R                         \ [0x10 : 8] Input parameter R. The value of this parameter is dependent on the function. This bitfield can not be modified when a function is ongoing (START = 1)
    $18 constant FMAC_FUNC                      \ [0x18 : 7] Function 2: Load X2 buffer 3: Load Y buffer 4 to 7: Reserved 8: Convolution (FIR filter) 9: IIR filter (direct form 1) This bitfield can not be modified when a function is ongoing (START = 1)
    $1f constant FMAC_START                     \ [0x1f] Enable execution Setting this bit triggers the execution of the function selected in the FUNC bitfield. Resetting it by software stops any ongoing function. For initialization functions, this bit is reset by hardware.
  [then]


  [ifdef] FMAC_FMAC_CR_DEF
    \
    \ @brief FMAC control register
    \ Address offset: 0x10
    \ Reset value: 0x00000000
    \
    $00 constant FMAC_RIEN                      \ [0x00] Enable read interrupt This bit is set and cleared by software. A read returns the current state of the bit.
    $01 constant FMAC_WIEN                      \ [0x01] Enable write interrupt This bit is set and cleared by software. A read returns the current state of the bit.
    $02 constant FMAC_OVFLIEN                   \ [0x02] Enable overflow error interrupts This bit is set and cleared by software. A read returns the current state of the bit.
    $03 constant FMAC_UNFLIEN                   \ [0x03] Enable underflow error interrupts This bit is set and cleared by software. A read returns the current state of the bit.
    $04 constant FMAC_SATIEN                    \ [0x04] Enable saturation error interrupts This bit is set and cleared by software. A read returns the current state of the bit.
    $08 constant FMAC_DMAREN                    \ [0x08] Enable DMA read channel requests This bit can only be modified when START= 0 in the FMAC_PARAM register. A read returns the current state of the bit.
    $09 constant FMAC_DMAWEN                    \ [0x09] Enable DMA write channel requests This bit can only be modified when START= 0 in the FMAC_PARAM register. A read returns the current state of the bit.
    $0f constant FMAC_CLIPEN                    \ [0x0f] Enable clipping
    $10 constant FMAC_RESET                     \ [0x10] Reset FMAC unit This resets the write and read pointers, the internal control logic, the FMAC_SR register and the FMAC_PARAM register, including the START bit if active. Other register settings are not affected. This bit is reset by hardware.
  [then]


  [ifdef] FMAC_FMAC_SR_DEF
    \
    \ @brief FMAC status register
    \ Address offset: 0x14
    \ Reset value: 0x00000001
    \
    $00 constant FMAC_YEMPTY                    \ [0x00] Y buffer empty flag The buffer is flagged as empty if the number of unread data is less than the EMPTY_WM threshold. The number of unread data is the difference between the read pointer and the current output destination address. This flag is set and cleared by hardware, or by a reset. Note: after the last sample is read from the Y buffer there is a delay of 3 clock cycles before the YEMPTY flag goes high. To avoid any risk of underflow it is recommended to insert a software delay after reading from the Y buffer before reading the FMAC_SR. Alternatively, an EMPTY_WM threshold of 2 can be used.
    $01 constant FMAC_X1FULL                    \ [0x01] X1 buffer full flag The buffer is flagged as full if the number of available spaces is less than the FULL_WM threshold. The number of available spaces is the difference between the write pointer and the least recent sample currently in use. This flag is set and cleared by hardware, or by a reset. Note: after the last available space in the X1 buffer is filled there is a delay of 3 clock cycles before the X1FULL flag goes high. To avoid any risk of overflow it is recommended to insert a software delay after writing to the X1 buffer before reading the FMAC_SR. Alternatively, a FULL_WM threshold of 2 can be used.
    $08 constant FMAC_OVFL                      \ [0x08] Overflow error flag An overflow occurs when a write is made to FMAC_WDATA when no free space is available in the X1 buffer. This flag is cleared by a reset of the unit.
    $09 constant FMAC_UNFL                      \ [0x09] Underflow error flag An underflow occurs when a read is made from FMAC_RDATA when no valid data is available in the Y buffer. This flag is cleared by a reset of the unit.
    $0a constant FMAC_SAT                       \ [0x0a] Saturation error flag Saturation occurs when the result of an accumulation exceeds the numeric range of the accumulator. This flag is cleared by a reset of the unit.
  [then]


  [ifdef] FMAC_FMAC_WDATA_DEF
    \
    \ @brief FMAC write data register
    \ Address offset: 0x18
    \ Reset value: 0x00000000
    \
    $00 constant FMAC_WDATA                     \ [0x00 : 16] Write data When a write access to this register occurs, the write data are transferred to the address offset indicated by the write pointer. The pointer address is automatically incremented after each write access.
  [then]


  [ifdef] FMAC_FMAC_RDATA_DEF
    \
    \ @brief FMAC read data register
    \ Address offset: 0x1C
    \ Reset value: 0x00000000
    \
    $00 constant FMAC_RDATA                     \ [0x00 : 16] Read data When a read access to this register occurs, the read data are the contents of the Y output buffer at the address offset indicated by the READ pointer. The pointer address is automatically incremented after each read access.
  [then]

  \
  \ @brief Filter Math Accelerator
  \
  $00 constant FMAC_FMAC_X1BUFCFG       \ FMAC X1 buffer configuration register
  $04 constant FMAC_FMAC_X2BUFCFG       \ FMAC X2 buffer configuration register
  $08 constant FMAC_FMAC_YBUFCFG        \ FMAC Y buffer configuration register
  $0C constant FMAC_FMAC_PARAM          \ FMAC parameter register
  $10 constant FMAC_FMAC_CR             \ FMAC control register
  $14 constant FMAC_FMAC_SR             \ FMAC status register
  $18 constant FMAC_FMAC_WDATA          \ FMAC write data register
  $1C constant FMAC_FMAC_RDATA          \ FMAC read data register

: FMAC_DEF ; [then]
