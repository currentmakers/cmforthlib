\
\ @file gpioi.fs
\ @brief GPIO
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief GPIO port mode register
\ Address offset: 0x00
\ Reset value: 0xABFFFFFF
\

$00000003 constant GPIOI_MODER_MODE0                                \ [1:0]: Port x configuration bits (y = 0..15) These bits are written by software to configure the I/O mode.
$0000000c constant GPIOI_MODER_MODE1                                \ [1:0]: Port x configuration bits (y = 0..15) These bits are written by software to configure the I/O mode.
$00000030 constant GPIOI_MODER_MODE2                                \ [1:0]: Port x configuration bits (y = 0..15) These bits are written by software to configure the I/O mode.
$000000c0 constant GPIOI_MODER_MODE3                                \ [1:0]: Port x configuration bits (y = 0..15) These bits are written by software to configure the I/O mode.
$00000300 constant GPIOI_MODER_MODE4                                \ [1:0]: Port x configuration bits (y = 0..15) These bits are written by software to configure the I/O mode.
$00000c00 constant GPIOI_MODER_MODE5                                \ [1:0]: Port x configuration bits (y = 0..15) These bits are written by software to configure the I/O mode.
$00003000 constant GPIOI_MODER_MODE6                                \ [1:0]: Port x configuration bits (y = 0..15) These bits are written by software to configure the I/O mode.
$0000c000 constant GPIOI_MODER_MODE7                                \ [1:0]: Port x configuration bits (y = 0..15) These bits are written by software to configure the I/O mode.
$00030000 constant GPIOI_MODER_MODE8                                \ [1:0]: Port x configuration bits (y = 0..15) These bits are written by software to configure the I/O mode.
$000c0000 constant GPIOI_MODER_MODE9                                \ [1:0]: Port x configuration bits (y = 0..15) These bits are written by software to configure the I/O mode.
$00300000 constant GPIOI_MODER_MODE10                               \ [1:0]: Port x configuration bits (y = 0..15) These bits are written by software to configure the I/O mode.
$00c00000 constant GPIOI_MODER_MODE11                               \ [1:0]: Port x configuration bits (y = 0..15) These bits are written by software to configure the I/O mode.
$03000000 constant GPIOI_MODER_MODE12                               \ [1:0]: Port x configuration bits (y = 0..15) These bits are written by software to configure the I/O mode.
$0c000000 constant GPIOI_MODER_MODE13                               \ [1:0]: Port x configuration bits (y = 0..15) These bits are written by software to configure the I/O mode.
$30000000 constant GPIOI_MODER_MODE14                               \ [1:0]: Port x configuration bits (y = 0..15) These bits are written by software to configure the I/O mode.
$c0000000 constant GPIOI_MODER_MODE15                               \ [1:0]: Port x configuration bits (y = 0..15) These bits are written by software to configure the I/O mode.


\
\ @brief GPIO port output type register
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$00000001 constant GPIOI_OTYPER_OT0                                 \ Port x configuration bits (y = 0..15) These bits are written by software to configure the I/O output type.
$00000002 constant GPIOI_OTYPER_OT1                                 \ Port x configuration bits (y = 0..15) These bits are written by software to configure the I/O output type.
$00000004 constant GPIOI_OTYPER_OT2                                 \ Port x configuration bits (y = 0..15) These bits are written by software to configure the I/O output type.
$00000008 constant GPIOI_OTYPER_OT3                                 \ Port x configuration bits (y = 0..15) These bits are written by software to configure the I/O output type.
$00000010 constant GPIOI_OTYPER_OT4                                 \ Port x configuration bits (y = 0..15) These bits are written by software to configure the I/O output type.
$00000020 constant GPIOI_OTYPER_OT5                                 \ Port x configuration bits (y = 0..15) These bits are written by software to configure the I/O output type.
$00000040 constant GPIOI_OTYPER_OT6                                 \ Port x configuration bits (y = 0..15) These bits are written by software to configure the I/O output type.
$00000080 constant GPIOI_OTYPER_OT7                                 \ Port x configuration bits (y = 0..15) These bits are written by software to configure the I/O output type.
$00000100 constant GPIOI_OTYPER_OT8                                 \ Port x configuration bits (y = 0..15) These bits are written by software to configure the I/O output type.
$00000200 constant GPIOI_OTYPER_OT9                                 \ Port x configuration bits (y = 0..15) These bits are written by software to configure the I/O output type.
$00000400 constant GPIOI_OTYPER_OT10                                \ Port x configuration bits (y = 0..15) These bits are written by software to configure the I/O output type.
$00000800 constant GPIOI_OTYPER_OT11                                \ Port x configuration bits (y = 0..15) These bits are written by software to configure the I/O output type.
$00001000 constant GPIOI_OTYPER_OT12                                \ Port x configuration bits (y = 0..15) These bits are written by software to configure the I/O output type.
$00002000 constant GPIOI_OTYPER_OT13                                \ Port x configuration bits (y = 0..15) These bits are written by software to configure the I/O output type.
$00004000 constant GPIOI_OTYPER_OT14                                \ Port x configuration bits (y = 0..15) These bits are written by software to configure the I/O output type.
$00008000 constant GPIOI_OTYPER_OT15                                \ Port x configuration bits (y = 0..15) These bits are written by software to configure the I/O output type.


\
\ @brief GPIO port output speed register
\ Address offset: 0x08
\ Reset value: 0x0C000000
\

$00000003 constant GPIOI_OSPEEDR_OSPEED0                            \ [1:0]: Port x configuration bits (y = 0..15) These bits are written by software to configure the I/O output speed. Note: Refer to the device datasheet for the frequency specifications and the power supply and load conditions for each speed.
$0000000c constant GPIOI_OSPEEDR_OSPEED1                            \ [1:0]: Port x configuration bits (y = 0..15) These bits are written by software to configure the I/O output speed. Note: Refer to the device datasheet for the frequency specifications and the power supply and load conditions for each speed.
$00000030 constant GPIOI_OSPEEDR_OSPEED2                            \ [1:0]: Port x configuration bits (y = 0..15) These bits are written by software to configure the I/O output speed. Note: Refer to the device datasheet for the frequency specifications and the power supply and load conditions for each speed.
$000000c0 constant GPIOI_OSPEEDR_OSPEED3                            \ [1:0]: Port x configuration bits (y = 0..15) These bits are written by software to configure the I/O output speed. Note: Refer to the device datasheet for the frequency specifications and the power supply and load conditions for each speed.
$00000300 constant GPIOI_OSPEEDR_OSPEED4                            \ [1:0]: Port x configuration bits (y = 0..15) These bits are written by software to configure the I/O output speed. Note: Refer to the device datasheet for the frequency specifications and the power supply and load conditions for each speed.
$00000c00 constant GPIOI_OSPEEDR_OSPEED5                            \ [1:0]: Port x configuration bits (y = 0..15) These bits are written by software to configure the I/O output speed. Note: Refer to the device datasheet for the frequency specifications and the power supply and load conditions for each speed.
$00003000 constant GPIOI_OSPEEDR_OSPEED6                            \ [1:0]: Port x configuration bits (y = 0..15) These bits are written by software to configure the I/O output speed. Note: Refer to the device datasheet for the frequency specifications and the power supply and load conditions for each speed.
$0000c000 constant GPIOI_OSPEEDR_OSPEED7                            \ [1:0]: Port x configuration bits (y = 0..15) These bits are written by software to configure the I/O output speed. Note: Refer to the device datasheet for the frequency specifications and the power supply and load conditions for each speed.
$00030000 constant GPIOI_OSPEEDR_OSPEED8                            \ [1:0]: Port x configuration bits (y = 0..15) These bits are written by software to configure the I/O output speed. Note: Refer to the device datasheet for the frequency specifications and the power supply and load conditions for each speed.
$000c0000 constant GPIOI_OSPEEDR_OSPEED9                            \ [1:0]: Port x configuration bits (y = 0..15) These bits are written by software to configure the I/O output speed. Note: Refer to the device datasheet for the frequency specifications and the power supply and load conditions for each speed.
$00300000 constant GPIOI_OSPEEDR_OSPEED10                           \ [1:0]: Port x configuration bits (y = 0..15) These bits are written by software to configure the I/O output speed. Note: Refer to the device datasheet for the frequency specifications and the power supply and load conditions for each speed.
$00c00000 constant GPIOI_OSPEEDR_OSPEED11                           \ [1:0]: Port x configuration bits (y = 0..15) These bits are written by software to configure the I/O output speed. Note: Refer to the device datasheet for the frequency specifications and the power supply and load conditions for each speed.
$03000000 constant GPIOI_OSPEEDR_OSPEED12                           \ [1:0]: Port x configuration bits (y = 0..15) These bits are written by software to configure the I/O output speed. Note: Refer to the device datasheet for the frequency specifications and the power supply and load conditions for each speed.
$0c000000 constant GPIOI_OSPEEDR_OSPEED13                           \ [1:0]: Port x configuration bits (y = 0..15) These bits are written by software to configure the I/O output speed. Note: Refer to the device datasheet for the frequency specifications and the power supply and load conditions for each speed.
$30000000 constant GPIOI_OSPEEDR_OSPEED14                           \ [1:0]: Port x configuration bits (y = 0..15) These bits are written by software to configure the I/O output speed. Note: Refer to the device datasheet for the frequency specifications and the power supply and load conditions for each speed.
$c0000000 constant GPIOI_OSPEEDR_OSPEED15                           \ [1:0]: Port x configuration bits (y = 0..15) These bits are written by software to configure the I/O output speed. Note: Refer to the device datasheet for the frequency specifications and the power supply and load conditions for each speed.


\
\ @brief GPIO port pull-up/pull-down register
\ Address offset: 0x0C
\ Reset value: 0x12100000
\

$00000003 constant GPIOI_PUPDR_PUPD0                                \ [1:0]: Port x configuration bits (y = 0..15) These bits are written by software to configure the I/O pull-up or pull-down
$0000000c constant GPIOI_PUPDR_PUPD1                                \ [1:0]: Port x configuration bits (y = 0..15) These bits are written by software to configure the I/O pull-up or pull-down
$00000030 constant GPIOI_PUPDR_PUPD2                                \ [1:0]: Port x configuration bits (y = 0..15) These bits are written by software to configure the I/O pull-up or pull-down
$000000c0 constant GPIOI_PUPDR_PUPD3                                \ [1:0]: Port x configuration bits (y = 0..15) These bits are written by software to configure the I/O pull-up or pull-down
$00000300 constant GPIOI_PUPDR_PUPD4                                \ [1:0]: Port x configuration bits (y = 0..15) These bits are written by software to configure the I/O pull-up or pull-down
$00000c00 constant GPIOI_PUPDR_PUPD5                                \ [1:0]: Port x configuration bits (y = 0..15) These bits are written by software to configure the I/O pull-up or pull-down
$00003000 constant GPIOI_PUPDR_PUPD6                                \ [1:0]: Port x configuration bits (y = 0..15) These bits are written by software to configure the I/O pull-up or pull-down
$0000c000 constant GPIOI_PUPDR_PUPD7                                \ [1:0]: Port x configuration bits (y = 0..15) These bits are written by software to configure the I/O pull-up or pull-down
$00030000 constant GPIOI_PUPDR_PUPD8                                \ [1:0]: Port x configuration bits (y = 0..15) These bits are written by software to configure the I/O pull-up or pull-down
$000c0000 constant GPIOI_PUPDR_PUPD9                                \ [1:0]: Port x configuration bits (y = 0..15) These bits are written by software to configure the I/O pull-up or pull-down
$00300000 constant GPIOI_PUPDR_PUPD10                               \ [1:0]: Port x configuration bits (y = 0..15) These bits are written by software to configure the I/O pull-up or pull-down
$00c00000 constant GPIOI_PUPDR_PUPD11                               \ [1:0]: Port x configuration bits (y = 0..15) These bits are written by software to configure the I/O pull-up or pull-down
$03000000 constant GPIOI_PUPDR_PUPD12                               \ [1:0]: Port x configuration bits (y = 0..15) These bits are written by software to configure the I/O pull-up or pull-down
$0c000000 constant GPIOI_PUPDR_PUPD13                               \ [1:0]: Port x configuration bits (y = 0..15) These bits are written by software to configure the I/O pull-up or pull-down
$30000000 constant GPIOI_PUPDR_PUPD14                               \ [1:0]: Port x configuration bits (y = 0..15) These bits are written by software to configure the I/O pull-up or pull-down
$c0000000 constant GPIOI_PUPDR_PUPD15                               \ [1:0]: Port x configuration bits (y = 0..15) These bits are written by software to configure the I/O pull-up or pull-down


\
\ @brief GPIO port input data register
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$00000001 constant GPIOI_IDR_ID0                                    \ Port input data bit (y = 0..15) These bits are read-only. They contain the input value of the corresponding I/O port.
$00000002 constant GPIOI_IDR_ID1                                    \ Port input data bit (y = 0..15) These bits are read-only. They contain the input value of the corresponding I/O port.
$00000004 constant GPIOI_IDR_ID2                                    \ Port input data bit (y = 0..15) These bits are read-only. They contain the input value of the corresponding I/O port.
$00000008 constant GPIOI_IDR_ID3                                    \ Port input data bit (y = 0..15) These bits are read-only. They contain the input value of the corresponding I/O port.
$00000010 constant GPIOI_IDR_ID4                                    \ Port input data bit (y = 0..15) These bits are read-only. They contain the input value of the corresponding I/O port.
$00000020 constant GPIOI_IDR_ID5                                    \ Port input data bit (y = 0..15) These bits are read-only. They contain the input value of the corresponding I/O port.
$00000040 constant GPIOI_IDR_ID6                                    \ Port input data bit (y = 0..15) These bits are read-only. They contain the input value of the corresponding I/O port.
$00000080 constant GPIOI_IDR_ID7                                    \ Port input data bit (y = 0..15) These bits are read-only. They contain the input value of the corresponding I/O port.
$00000100 constant GPIOI_IDR_ID8                                    \ Port input data bit (y = 0..15) These bits are read-only. They contain the input value of the corresponding I/O port.
$00000200 constant GPIOI_IDR_ID9                                    \ Port input data bit (y = 0..15) These bits are read-only. They contain the input value of the corresponding I/O port.
$00000400 constant GPIOI_IDR_ID10                                   \ Port input data bit (y = 0..15) These bits are read-only. They contain the input value of the corresponding I/O port.
$00000800 constant GPIOI_IDR_ID11                                   \ Port input data bit (y = 0..15) These bits are read-only. They contain the input value of the corresponding I/O port.
$00001000 constant GPIOI_IDR_ID12                                   \ Port input data bit (y = 0..15) These bits are read-only. They contain the input value of the corresponding I/O port.
$00002000 constant GPIOI_IDR_ID13                                   \ Port input data bit (y = 0..15) These bits are read-only. They contain the input value of the corresponding I/O port.
$00004000 constant GPIOI_IDR_ID14                                   \ Port input data bit (y = 0..15) These bits are read-only. They contain the input value of the corresponding I/O port.
$00008000 constant GPIOI_IDR_ID15                                   \ Port input data bit (y = 0..15) These bits are read-only. They contain the input value of the corresponding I/O port.


\
\ @brief GPIO port output data register
\ Address offset: 0x14
\ Reset value: 0x00000000
\

$00000001 constant GPIOI_ODR_OD0                                    \ Port output data bit These bits can be read and written by software. Note: For atomic bit set/reset, the OD bits can be individually set and/or reset by writing to the GPIOx_BSRR or GPIOx_BRR registers (x = A..F).
$00000002 constant GPIOI_ODR_OD1                                    \ Port output data bit These bits can be read and written by software. Note: For atomic bit set/reset, the OD bits can be individually set and/or reset by writing to the GPIOx_BSRR or GPIOx_BRR registers (x = A..F).
$00000004 constant GPIOI_ODR_OD2                                    \ Port output data bit These bits can be read and written by software. Note: For atomic bit set/reset, the OD bits can be individually set and/or reset by writing to the GPIOx_BSRR or GPIOx_BRR registers (x = A..F).
$00000008 constant GPIOI_ODR_OD3                                    \ Port output data bit These bits can be read and written by software. Note: For atomic bit set/reset, the OD bits can be individually set and/or reset by writing to the GPIOx_BSRR or GPIOx_BRR registers (x = A..F).
$00000010 constant GPIOI_ODR_OD4                                    \ Port output data bit These bits can be read and written by software. Note: For atomic bit set/reset, the OD bits can be individually set and/or reset by writing to the GPIOx_BSRR or GPIOx_BRR registers (x = A..F).
$00000020 constant GPIOI_ODR_OD5                                    \ Port output data bit These bits can be read and written by software. Note: For atomic bit set/reset, the OD bits can be individually set and/or reset by writing to the GPIOx_BSRR or GPIOx_BRR registers (x = A..F).
$00000040 constant GPIOI_ODR_OD6                                    \ Port output data bit These bits can be read and written by software. Note: For atomic bit set/reset, the OD bits can be individually set and/or reset by writing to the GPIOx_BSRR or GPIOx_BRR registers (x = A..F).
$00000080 constant GPIOI_ODR_OD7                                    \ Port output data bit These bits can be read and written by software. Note: For atomic bit set/reset, the OD bits can be individually set and/or reset by writing to the GPIOx_BSRR or GPIOx_BRR registers (x = A..F).
$00000100 constant GPIOI_ODR_OD8                                    \ Port output data bit These bits can be read and written by software. Note: For atomic bit set/reset, the OD bits can be individually set and/or reset by writing to the GPIOx_BSRR or GPIOx_BRR registers (x = A..F).
$00000200 constant GPIOI_ODR_OD9                                    \ Port output data bit These bits can be read and written by software. Note: For atomic bit set/reset, the OD bits can be individually set and/or reset by writing to the GPIOx_BSRR or GPIOx_BRR registers (x = A..F).
$00000400 constant GPIOI_ODR_OD10                                   \ Port output data bit These bits can be read and written by software. Note: For atomic bit set/reset, the OD bits can be individually set and/or reset by writing to the GPIOx_BSRR or GPIOx_BRR registers (x = A..F).
$00000800 constant GPIOI_ODR_OD11                                   \ Port output data bit These bits can be read and written by software. Note: For atomic bit set/reset, the OD bits can be individually set and/or reset by writing to the GPIOx_BSRR or GPIOx_BRR registers (x = A..F).
$00001000 constant GPIOI_ODR_OD12                                   \ Port output data bit These bits can be read and written by software. Note: For atomic bit set/reset, the OD bits can be individually set and/or reset by writing to the GPIOx_BSRR or GPIOx_BRR registers (x = A..F).
$00002000 constant GPIOI_ODR_OD13                                   \ Port output data bit These bits can be read and written by software. Note: For atomic bit set/reset, the OD bits can be individually set and/or reset by writing to the GPIOx_BSRR or GPIOx_BRR registers (x = A..F).
$00004000 constant GPIOI_ODR_OD14                                   \ Port output data bit These bits can be read and written by software. Note: For atomic bit set/reset, the OD bits can be individually set and/or reset by writing to the GPIOx_BSRR or GPIOx_BRR registers (x = A..F).
$00008000 constant GPIOI_ODR_OD15                                   \ Port output data bit These bits can be read and written by software. Note: For atomic bit set/reset, the OD bits can be individually set and/or reset by writing to the GPIOx_BSRR or GPIOx_BRR registers (x = A..F).


\
\ @brief GPIO port bit set/reset register
\ Address offset: 0x18
\ Reset value: 0x00000000
\

$00000001 constant GPIOI_BSRR_BS0                                   \ Port x set bit y (y= 0..15) These bits are write-only. A read to these bits returns the value 0x0000.
$00000002 constant GPIOI_BSRR_BS1                                   \ Port x set bit y (y= 0..15) These bits are write-only. A read to these bits returns the value 0x0000.
$00000004 constant GPIOI_BSRR_BS2                                   \ Port x set bit y (y= 0..15) These bits are write-only. A read to these bits returns the value 0x0000.
$00000008 constant GPIOI_BSRR_BS3                                   \ Port x set bit y (y= 0..15) These bits are write-only. A read to these bits returns the value 0x0000.
$00000010 constant GPIOI_BSRR_BS4                                   \ Port x set bit y (y= 0..15) These bits are write-only. A read to these bits returns the value 0x0000.
$00000020 constant GPIOI_BSRR_BS5                                   \ Port x set bit y (y= 0..15) These bits are write-only. A read to these bits returns the value 0x0000.
$00000040 constant GPIOI_BSRR_BS6                                   \ Port x set bit y (y= 0..15) These bits are write-only. A read to these bits returns the value 0x0000.
$00000080 constant GPIOI_BSRR_BS7                                   \ Port x set bit y (y= 0..15) These bits are write-only. A read to these bits returns the value 0x0000.
$00000100 constant GPIOI_BSRR_BS8                                   \ Port x set bit y (y= 0..15) These bits are write-only. A read to these bits returns the value 0x0000.
$00000200 constant GPIOI_BSRR_BS9                                   \ Port x set bit y (y= 0..15) These bits are write-only. A read to these bits returns the value 0x0000.
$00000400 constant GPIOI_BSRR_BS10                                  \ Port x set bit y (y= 0..15) These bits are write-only. A read to these bits returns the value 0x0000.
$00000800 constant GPIOI_BSRR_BS11                                  \ Port x set bit y (y= 0..15) These bits are write-only. A read to these bits returns the value 0x0000.
$00001000 constant GPIOI_BSRR_BS12                                  \ Port x set bit y (y= 0..15) These bits are write-only. A read to these bits returns the value 0x0000.
$00002000 constant GPIOI_BSRR_BS13                                  \ Port x set bit y (y= 0..15) These bits are write-only. A read to these bits returns the value 0x0000.
$00004000 constant GPIOI_BSRR_BS14                                  \ Port x set bit y (y= 0..15) These bits are write-only. A read to these bits returns the value 0x0000.
$00008000 constant GPIOI_BSRR_BS15                                  \ Port x set bit y (y= 0..15) These bits are write-only. A read to these bits returns the value 0x0000.
$00010000 constant GPIOI_BSRR_BR0                                   \ Port x reset bit y (y = 0..15) These bits are write-only. A read to these bits returns the value 0x0000. Note: If both BSx and BRx are set, BSx has priority.
$00020000 constant GPIOI_BSRR_BR1                                   \ Port x reset bit y (y = 0..15) These bits are write-only. A read to these bits returns the value 0x0000. Note: If both BSx and BRx are set, BSx has priority.
$00040000 constant GPIOI_BSRR_BR2                                   \ Port x reset bit y (y = 0..15) These bits are write-only. A read to these bits returns the value 0x0000. Note: If both BSx and BRx are set, BSx has priority.
$00080000 constant GPIOI_BSRR_BR3                                   \ Port x reset bit y (y = 0..15) These bits are write-only. A read to these bits returns the value 0x0000. Note: If both BSx and BRx are set, BSx has priority.
$00100000 constant GPIOI_BSRR_BR4                                   \ Port x reset bit y (y = 0..15) These bits are write-only. A read to these bits returns the value 0x0000. Note: If both BSx and BRx are set, BSx has priority.
$00200000 constant GPIOI_BSRR_BR5                                   \ Port x reset bit y (y = 0..15) These bits are write-only. A read to these bits returns the value 0x0000. Note: If both BSx and BRx are set, BSx has priority.
$00400000 constant GPIOI_BSRR_BR6                                   \ Port x reset bit y (y = 0..15) These bits are write-only. A read to these bits returns the value 0x0000. Note: If both BSx and BRx are set, BSx has priority.
$00800000 constant GPIOI_BSRR_BR7                                   \ Port x reset bit y (y = 0..15) These bits are write-only. A read to these bits returns the value 0x0000. Note: If both BSx and BRx are set, BSx has priority.
$01000000 constant GPIOI_BSRR_BR8                                   \ Port x reset bit y (y = 0..15) These bits are write-only. A read to these bits returns the value 0x0000. Note: If both BSx and BRx are set, BSx has priority.
$02000000 constant GPIOI_BSRR_BR9                                   \ Port x reset bit y (y = 0..15) These bits are write-only. A read to these bits returns the value 0x0000. Note: If both BSx and BRx are set, BSx has priority.
$04000000 constant GPIOI_BSRR_BR10                                  \ Port x reset bit y (y = 0..15) These bits are write-only. A read to these bits returns the value 0x0000. Note: If both BSx and BRx are set, BSx has priority.
$08000000 constant GPIOI_BSRR_BR11                                  \ Port x reset bit y (y = 0..15) These bits are write-only. A read to these bits returns the value 0x0000. Note: If both BSx and BRx are set, BSx has priority.
$10000000 constant GPIOI_BSRR_BR12                                  \ Port x reset bit y (y = 0..15) These bits are write-only. A read to these bits returns the value 0x0000. Note: If both BSx and BRx are set, BSx has priority.
$20000000 constant GPIOI_BSRR_BR13                                  \ Port x reset bit y (y = 0..15) These bits are write-only. A read to these bits returns the value 0x0000. Note: If both BSx and BRx are set, BSx has priority.
$40000000 constant GPIOI_BSRR_BR14                                  \ Port x reset bit y (y = 0..15) These bits are write-only. A read to these bits returns the value 0x0000. Note: If both BSx and BRx are set, BSx has priority.
$80000000 constant GPIOI_BSRR_BR15                                  \ Port x reset bit y (y = 0..15) These bits are write-only. A read to these bits returns the value 0x0000. Note: If both BSx and BRx are set, BSx has priority.


\
\ @brief This register is used to lock the configuration of the port bits when a correct write sequence is applied to bit 16 (LCKK). The value of bits [15:0] is used to lock the configuration of the GPIO. During the write sequence, the value of LCKR[15:0] must not change. When the LOCK sequence has been applied on a port bit, the value of this port bit can no longer be modified until the next MCU reset or peripheral reset.A specific write sequence is used to write to the GPIOx_LCKR register. Only word access (32-bit long) is allowed during this locking sequence.Each lock bit freezes a specific configuration register (control and alternate function registers).
\ Address offset: 0x1C
\ Reset value: 0x00000000
\

$00000001 constant GPIOI_LCKR_LCK0                                  \ Port x lock bit y (y= 0..15) These bits are read/write but can only be written when the LCKK bit is 0.
$00000002 constant GPIOI_LCKR_LCK1                                  \ Port x lock bit y (y= 0..15) These bits are read/write but can only be written when the LCKK bit is 0.
$00000004 constant GPIOI_LCKR_LCK2                                  \ Port x lock bit y (y= 0..15) These bits are read/write but can only be written when the LCKK bit is 0.
$00000008 constant GPIOI_LCKR_LCK3                                  \ Port x lock bit y (y= 0..15) These bits are read/write but can only be written when the LCKK bit is 0.
$00000010 constant GPIOI_LCKR_LCK4                                  \ Port x lock bit y (y= 0..15) These bits are read/write but can only be written when the LCKK bit is 0.
$00000020 constant GPIOI_LCKR_LCK5                                  \ Port x lock bit y (y= 0..15) These bits are read/write but can only be written when the LCKK bit is 0.
$00000040 constant GPIOI_LCKR_LCK6                                  \ Port x lock bit y (y= 0..15) These bits are read/write but can only be written when the LCKK bit is 0.
$00000080 constant GPIOI_LCKR_LCK7                                  \ Port x lock bit y (y= 0..15) These bits are read/write but can only be written when the LCKK bit is 0.
$00000100 constant GPIOI_LCKR_LCK8                                  \ Port x lock bit y (y= 0..15) These bits are read/write but can only be written when the LCKK bit is 0.
$00000200 constant GPIOI_LCKR_LCK9                                  \ Port x lock bit y (y= 0..15) These bits are read/write but can only be written when the LCKK bit is 0.
$00000400 constant GPIOI_LCKR_LCK10                                 \ Port x lock bit y (y= 0..15) These bits are read/write but can only be written when the LCKK bit is 0.
$00000800 constant GPIOI_LCKR_LCK11                                 \ Port x lock bit y (y= 0..15) These bits are read/write but can only be written when the LCKK bit is 0.
$00001000 constant GPIOI_LCKR_LCK12                                 \ Port x lock bit y (y= 0..15) These bits are read/write but can only be written when the LCKK bit is 0.
$00002000 constant GPIOI_LCKR_LCK13                                 \ Port x lock bit y (y= 0..15) These bits are read/write but can only be written when the LCKK bit is 0.
$00004000 constant GPIOI_LCKR_LCK14                                 \ Port x lock bit y (y= 0..15) These bits are read/write but can only be written when the LCKK bit is 0.
$00008000 constant GPIOI_LCKR_LCK15                                 \ Port x lock bit y (y= 0..15) These bits are read/write but can only be written when the LCKK bit is 0.
$00010000 constant GPIOI_LCKR_LCKK                                  \ Lock key This bit can be read any time. It can only be modified using the lock key write sequence. LOCK key write sequence: WR LCKR[16] = 1 + LCKR[15:0] WR LCKR[16] = 0 + LCKR[15:0] WR LCKR[16] = 1 + LCKR[15:0] RD LCKR RD LCKR[16] = 1 (this read operation is optional but it confirms that the lock is active) Note: During the LOCK key write sequence, the value of LCK[15:0] must not change. Any error in the lock sequence aborts the lock. After the first lock sequence on any bit of the port, any read access on the LCKK bit will return 1 until the next MCU reset or peripheral reset.


\
\ @brief GPIO alternate function low register
\ Address offset: 0x20
\ Reset value: 0x00000000
\

$0000000f constant GPIOI_AFRL_AFSEL0                                \ [3:0]: Alternate function selection for port x pin y (y = 0..7) These bits are written by software to configure alternate function I/Os AFSELy selection:
$000000f0 constant GPIOI_AFRL_AFSEL1                                \ [3:0]: Alternate function selection for port x pin y (y = 0..7) These bits are written by software to configure alternate function I/Os AFSELy selection:
$00000f00 constant GPIOI_AFRL_AFSEL2                                \ [3:0]: Alternate function selection for port x pin y (y = 0..7) These bits are written by software to configure alternate function I/Os AFSELy selection:
$0000f000 constant GPIOI_AFRL_AFSEL3                                \ [3:0]: Alternate function selection for port x pin y (y = 0..7) These bits are written by software to configure alternate function I/Os AFSELy selection:
$000f0000 constant GPIOI_AFRL_AFSEL4                                \ [3:0]: Alternate function selection for port x pin y (y = 0..7) These bits are written by software to configure alternate function I/Os AFSELy selection:
$00f00000 constant GPIOI_AFRL_AFSEL5                                \ [3:0]: Alternate function selection for port x pin y (y = 0..7) These bits are written by software to configure alternate function I/Os AFSELy selection:
$0f000000 constant GPIOI_AFRL_AFSEL6                                \ [3:0]: Alternate function selection for port x pin y (y = 0..7) These bits are written by software to configure alternate function I/Os AFSELy selection:
$f0000000 constant GPIOI_AFRL_AFSEL7                                \ [3:0]: Alternate function selection for port x pin y (y = 0..7) These bits are written by software to configure alternate function I/Os AFSELy selection:


\
\ @brief GPIO alternate function high register
\ Address offset: 0x24
\ Reset value: 0x00000000
\

$0000000f constant GPIOI_AFRH_AFSEL8                                \ [3:0]: Alternate function selection for port x pin y (y = 8..15) These bits are written by software to configure alternate function I/Os
$000000f0 constant GPIOI_AFRH_AFSEL9                                \ [3:0]: Alternate function selection for port x pin y (y = 8..15) These bits are written by software to configure alternate function I/Os
$00000f00 constant GPIOI_AFRH_AFSEL10                               \ [3:0]: Alternate function selection for port x pin y (y = 8..15) These bits are written by software to configure alternate function I/Os
$0000f000 constant GPIOI_AFRH_AFSEL11                               \ [3:0]: Alternate function selection for port x pin y (y = 8..15) These bits are written by software to configure alternate function I/Os
$000f0000 constant GPIOI_AFRH_AFSEL12                               \ [3:0]: Alternate function selection for port x pin y (y = 8..15) These bits are written by software to configure alternate function I/Os
$00f00000 constant GPIOI_AFRH_AFSEL13                               \ [3:0]: Alternate function selection for port x pin y (y = 8..15) These bits are written by software to configure alternate function I/Os
$0f000000 constant GPIOI_AFRH_AFSEL14                               \ [3:0]: Alternate function selection for port x pin y (y = 8..15) These bits are written by software to configure alternate function I/Os
$f0000000 constant GPIOI_AFRH_AFSEL15                               \ [3:0]: Alternate function selection for port x pin y (y = 8..15) These bits are written by software to configure alternate function I/Os


\
\ @brief GPIO
\
$58022000 constant GPIOI_MODER    \ offset: 0x00 : GPIO port mode register
$58022004 constant GPIOI_OTYPER   \ offset: 0x04 : GPIO port output type register
$58022008 constant GPIOI_OSPEEDR  \ offset: 0x08 : GPIO port output speed register
$5802200c constant GPIOI_PUPDR    \ offset: 0x0C : GPIO port pull-up/pull-down register
$58022010 constant GPIOI_IDR      \ offset: 0x10 : GPIO port input data register
$58022014 constant GPIOI_ODR      \ offset: 0x14 : GPIO port output data register
$58022018 constant GPIOI_BSRR     \ offset: 0x18 : GPIO port bit set/reset register
$5802201c constant GPIOI_LCKR     \ offset: 0x1C : This register is used to lock the configuration of the port bits when a correct write sequence is applied to bit 16 (LCKK). The value of bits [15:0] is used to lock the configuration of the GPIO. During the write sequence, the value of LCKR[15:0] must not change. When the LOCK sequence has been applied on a port bit, the value of this port bit can no longer be modified until the next MCU reset or peripheral reset.A specific write sequence is used to write to the GPIOx_LCKR register. Only word access (32-bit long) is allowed during this locking sequence.Each lock bit freezes a specific configuration register (control and alternate function registers).
$58022020 constant GPIOI_AFRL     \ offset: 0x20 : GPIO alternate function low register
$58022024 constant GPIOI_AFRH     \ offset: 0x24 : GPIO alternate function high register

