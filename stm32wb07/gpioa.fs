\
\ @file gpioa.fs
\ @brief GPIOA address block description
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief GPIO port mode register
\ Address offset: 0x00
\ Reset value: 0xFFFFFFFF
\

$00000003 constant GPIOA_GPIOA_MODER_MODER0                         \ Port x configuration I/O pin y These bits are written by software to configure the I/O mode.
$0000000c constant GPIOA_GPIOA_MODER_MODER1                         \ Port x configuration I/O pin y These bits are written by software to configure the I/O mode.
$00000030 constant GPIOA_GPIOA_MODER_MODER2                         \ Port x configuration I/O pin y These bits are written by software to configure the I/O mode.
$000000c0 constant GPIOA_GPIOA_MODER_MODER3                         \ Port x configuration I/O pin y These bits are written by software to configure the I/O mode.
$00000300 constant GPIOA_GPIOA_MODER_MODER4                         \ Port x configuration I/O pin y These bits are written by software to configure the I/O mode.
$00000c00 constant GPIOA_GPIOA_MODER_MODER5                         \ Port x configuration I/O pin y These bits are written by software to configure the I/O mode.
$00003000 constant GPIOA_GPIOA_MODER_MODER6                         \ Port x configuration I/O pin y These bits are written by software to configure the I/O mode.
$0000c000 constant GPIOA_GPIOA_MODER_MODER7                         \ Port x configuration I/O pin y These bits are written by software to configure the I/O mode.
$00030000 constant GPIOA_GPIOA_MODER_MODER8                         \ Port x configuration I/O pin y These bits are written by software to configure the I/O mode.
$000c0000 constant GPIOA_GPIOA_MODER_MODER9                         \ Port x configuration I/O pin y These bits are written by software to configure the I/O mode.
$00300000 constant GPIOA_GPIOA_MODER_MODER10                        \ Port x configuration I/O pin y These bits are written by software to configure the I/O mode.
$00c00000 constant GPIOA_GPIOA_MODER_MODER11                        \ Port x configuration I/O pin y These bits are written by software to configure the I/O mode.
$03000000 constant GPIOA_GPIOA_MODER_MODER12                        \ Port x configuration I/O pin y These bits are written by software to configure the I/O mode.
$0c000000 constant GPIOA_GPIOA_MODER_MODER13                        \ Port x configuration I/O pin y These bits are written by software to configure the I/O mode.
$30000000 constant GPIOA_GPIOA_MODER_MODER14                        \ Port x configuration I/O pin y These bits are written by software to configure the I/O mode.
$c0000000 constant GPIOA_GPIOA_MODER_MODER15                        \ Port x configuration I/O pin y These bits are written by software to configure the I/O mode.


\
\ @brief GPIO port output type register
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$00000001 constant GPIOA_GPIOA_OTYPER_OT0                           \ Port x configuration I/O pin y These bits are written by software to configure the I/O output type.
$00000002 constant GPIOA_GPIOA_OTYPER_OT1                           \ Port x configuration I/O pin y These bits are written by software to configure the I/O output type.
$00000004 constant GPIOA_GPIOA_OTYPER_OT2                           \ Port x configuration I/O pin y These bits are written by software to configure the I/O output type.
$00000008 constant GPIOA_GPIOA_OTYPER_OT3                           \ Port x configuration I/O pin y These bits are written by software to configure the I/O output type.
$00000010 constant GPIOA_GPIOA_OTYPER_OT4                           \ Port x configuration I/O pin y These bits are written by software to configure the I/O output type.
$00000020 constant GPIOA_GPIOA_OTYPER_OT5                           \ Port x configuration I/O pin y These bits are written by software to configure the I/O output type.
$00000040 constant GPIOA_GPIOA_OTYPER_OT6                           \ Port x configuration I/O pin y These bits are written by software to configure the I/O output type.
$00000080 constant GPIOA_GPIOA_OTYPER_OT7                           \ Port x configuration I/O pin y These bits are written by software to configure the I/O output type.
$00000100 constant GPIOA_GPIOA_OTYPER_OT8                           \ Port x configuration I/O pin y These bits are written by software to configure the I/O output type.
$00000200 constant GPIOA_GPIOA_OTYPER_OT9                           \ Port x configuration I/O pin y These bits are written by software to configure the I/O output type.
$00000400 constant GPIOA_GPIOA_OTYPER_OT10                          \ Port x configuration I/O pin y These bits are written by software to configure the I/O output type.
$00000800 constant GPIOA_GPIOA_OTYPER_OT11                          \ Port x configuration I/O pin y These bits are written by software to configure the I/O output type.
$00001000 constant GPIOA_GPIOA_OTYPER_OT12                          \ Port x configuration I/O pin y These bits are written by software to configure the I/O output type.
$00002000 constant GPIOA_GPIOA_OTYPER_OT13                          \ Port x configuration I/O pin y These bits are written by software to configure the I/O output type.
$00004000 constant GPIOA_GPIOA_OTYPER_OT14                          \ Port x configuration I/O pin y These bits are written by software to configure the I/O output type.
$00008000 constant GPIOA_GPIOA_OTYPER_OT15                          \ Port x configuration I/O pin y These bits are written by software to configure the I/O output type.


\
\ @brief GPIO port output speed register
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$00000003 constant GPIOA_GPIOA_OSPEEDR_OSPEEDR0                     \ Port x configuration I/O pin y These bits are written by software to configure the I/O output speed. Note: Refer to the product datasheets for the values of OSPEEDRy bits versus V<sub>DD</sub> range and external load.
$0000000c constant GPIOA_GPIOA_OSPEEDR_OSPEEDR1                     \ Port x configuration I/O pin y These bits are written by software to configure the I/O output speed. Note: Refer to the product datasheets for the values of OSPEEDRy bits versus V<sub>DD</sub> range and external load.
$00000030 constant GPIOA_GPIOA_OSPEEDR_OSPEEDR2                     \ Port x configuration I/O pin y These bits are written by software to configure the I/O output speed. Note: Refer to the product datasheets for the values of OSPEEDRy bits versus V<sub>DD</sub> range and external load.
$000000c0 constant GPIOA_GPIOA_OSPEEDR_OSPEEDR3                     \ Port x configuration I/O pin y These bits are written by software to configure the I/O output speed. Note: Refer to the product datasheets for the values of OSPEEDRy bits versus V<sub>DD</sub> range and external load.
$00000300 constant GPIOA_GPIOA_OSPEEDR_OSPEEDR4                     \ Port x configuration I/O pin y These bits are written by software to configure the I/O output speed. Note: Refer to the product datasheets for the values of OSPEEDRy bits versus V<sub>DD</sub> range and external load.
$00000c00 constant GPIOA_GPIOA_OSPEEDR_OSPEEDR5                     \ Port x configuration I/O pin y These bits are written by software to configure the I/O output speed. Note: Refer to the product datasheets for the values of OSPEEDRy bits versus V<sub>DD</sub> range and external load.
$00003000 constant GPIOA_GPIOA_OSPEEDR_OSPEEDR6                     \ Port x configuration I/O pin y These bits are written by software to configure the I/O output speed. Note: Refer to the product datasheets for the values of OSPEEDRy bits versus V<sub>DD</sub> range and external load.
$0000c000 constant GPIOA_GPIOA_OSPEEDR_OSPEEDR7                     \ Port x configuration I/O pin y These bits are written by software to configure the I/O output speed. Note: Refer to the product datasheets for the values of OSPEEDRy bits versus V<sub>DD</sub> range and external load.
$00030000 constant GPIOA_GPIOA_OSPEEDR_OSPEEDR8                     \ Port x configuration I/O pin y These bits are written by software to configure the I/O output speed. Note: Refer to the product datasheets for the values of OSPEEDRy bits versus V<sub>DD</sub> range and external load.
$000c0000 constant GPIOA_GPIOA_OSPEEDR_OSPEEDR9                     \ Port x configuration I/O pin y These bits are written by software to configure the I/O output speed. Note: Refer to the product datasheets for the values of OSPEEDRy bits versus V<sub>DD</sub> range and external load.
$00300000 constant GPIOA_GPIOA_OSPEEDR_OSPEEDR10                    \ Port x configuration I/O pin y These bits are written by software to configure the I/O output speed. Note: Refer to the product datasheets for the values of OSPEEDRy bits versus V<sub>DD</sub> range and external load.
$00c00000 constant GPIOA_GPIOA_OSPEEDR_OSPEEDR11                    \ Port x configuration I/O pin y These bits are written by software to configure the I/O output speed. Note: Refer to the product datasheets for the values of OSPEEDRy bits versus V<sub>DD</sub> range and external load.
$03000000 constant GPIOA_GPIOA_OSPEEDR_OSPEEDR12                    \ Port x configuration I/O pin y These bits are written by software to configure the I/O output speed. Note: Refer to the product datasheets for the values of OSPEEDRy bits versus V<sub>DD</sub> range and external load.
$0c000000 constant GPIOA_GPIOA_OSPEEDR_OSPEEDR13                    \ Port x configuration I/O pin y These bits are written by software to configure the I/O output speed. Note: Refer to the product datasheets for the values of OSPEEDRy bits versus V<sub>DD</sub> range and external load.
$30000000 constant GPIOA_GPIOA_OSPEEDR_OSPEEDR14                    \ Port x configuration I/O pin y These bits are written by software to configure the I/O output speed. Note: Refer to the product datasheets for the values of OSPEEDRy bits versus V<sub>DD</sub> range and external load.
$c0000000 constant GPIOA_GPIOA_OSPEEDR_OSPEEDR15                    \ Port x configuration I/O pin y These bits are written by software to configure the I/O output speed. Note: Refer to the product datasheets for the values of OSPEEDRy bits versus V<sub>DD</sub> range and external load.


\
\ @brief GPIO port pull-up/pull-down register
\ Address offset: 0x0C
\ Reset value: 0x00000000
\

$00000003 constant GPIOA_GPIOA_PUPDR_PUPDR0                         \ Port x configuration I/O pin y These bits are written by software to configure the I/O pull-up or pull-down
$0000000c constant GPIOA_GPIOA_PUPDR_PUPDR1                         \ Port x configuration I/O pin y These bits are written by software to configure the I/O pull-up or pull-down
$00000030 constant GPIOA_GPIOA_PUPDR_PUPDR2                         \ Port x configuration I/O pin y These bits are written by software to configure the I/O pull-up or pull-down
$000000c0 constant GPIOA_GPIOA_PUPDR_PUPDR3                         \ Port x configuration I/O pin y These bits are written by software to configure the I/O pull-up or pull-down
$00000300 constant GPIOA_GPIOA_PUPDR_PUPDR4                         \ Port x configuration I/O pin y These bits are written by software to configure the I/O pull-up or pull-down
$00000c00 constant GPIOA_GPIOA_PUPDR_PUPDR5                         \ Port x configuration I/O pin y These bits are written by software to configure the I/O pull-up or pull-down
$00003000 constant GPIOA_GPIOA_PUPDR_PUPDR6                         \ Port x configuration I/O pin y These bits are written by software to configure the I/O pull-up or pull-down
$0000c000 constant GPIOA_GPIOA_PUPDR_PUPDR7                         \ Port x configuration I/O pin y These bits are written by software to configure the I/O pull-up or pull-down
$00030000 constant GPIOA_GPIOA_PUPDR_PUPDR8                         \ Port x configuration I/O pin y These bits are written by software to configure the I/O pull-up or pull-down
$000c0000 constant GPIOA_GPIOA_PUPDR_PUPDR9                         \ Port x configuration I/O pin y These bits are written by software to configure the I/O pull-up or pull-down
$00300000 constant GPIOA_GPIOA_PUPDR_PUPDR10                        \ Port x configuration I/O pin y These bits are written by software to configure the I/O pull-up or pull-down
$00c00000 constant GPIOA_GPIOA_PUPDR_PUPDR11                        \ Port x configuration I/O pin y These bits are written by software to configure the I/O pull-up or pull-down
$03000000 constant GPIOA_GPIOA_PUPDR_PUPDR12                        \ Port x configuration I/O pin y These bits are written by software to configure the I/O pull-up or pull-down
$0c000000 constant GPIOA_GPIOA_PUPDR_PUPDR13                        \ Port x configuration I/O pin y These bits are written by software to configure the I/O pull-up or pull-down
$30000000 constant GPIOA_GPIOA_PUPDR_PUPDR14                        \ Port x configuration I/O pin y These bits are written by software to configure the I/O pull-up or pull-down
$c0000000 constant GPIOA_GPIOA_PUPDR_PUPDR15                        \ Port x configuration I/O pin y These bits are written by software to configure the I/O pull-up or pull-down


\
\ @brief GPIO port input data register
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$00000001 constant GPIOA_GPIOA_IDR_IDR0                             \ Port x input data I/O pin y These bits are read-only. They contain the input value of the corresponding I/O port.
$00000002 constant GPIOA_GPIOA_IDR_IDR1                             \ Port x input data I/O pin y These bits are read-only. They contain the input value of the corresponding I/O port.
$00000004 constant GPIOA_GPIOA_IDR_IDR2                             \ Port x input data I/O pin y These bits are read-only. They contain the input value of the corresponding I/O port.
$00000008 constant GPIOA_GPIOA_IDR_IDR3                             \ Port x input data I/O pin y These bits are read-only. They contain the input value of the corresponding I/O port.
$00000010 constant GPIOA_GPIOA_IDR_IDR4                             \ Port x input data I/O pin y These bits are read-only. They contain the input value of the corresponding I/O port.
$00000020 constant GPIOA_GPIOA_IDR_IDR5                             \ Port x input data I/O pin y These bits are read-only. They contain the input value of the corresponding I/O port.
$00000040 constant GPIOA_GPIOA_IDR_IDR6                             \ Port x input data I/O pin y These bits are read-only. They contain the input value of the corresponding I/O port.
$00000080 constant GPIOA_GPIOA_IDR_IDR7                             \ Port x input data I/O pin y These bits are read-only. They contain the input value of the corresponding I/O port.
$00000100 constant GPIOA_GPIOA_IDR_IDR8                             \ Port x input data I/O pin y These bits are read-only. They contain the input value of the corresponding I/O port.
$00000200 constant GPIOA_GPIOA_IDR_IDR9                             \ Port x input data I/O pin y These bits are read-only. They contain the input value of the corresponding I/O port.
$00000400 constant GPIOA_GPIOA_IDR_IDR10                            \ Port x input data I/O pin y These bits are read-only. They contain the input value of the corresponding I/O port.
$00000800 constant GPIOA_GPIOA_IDR_IDR11                            \ Port x input data I/O pin y These bits are read-only. They contain the input value of the corresponding I/O port.
$00001000 constant GPIOA_GPIOA_IDR_IDR12                            \ Port x input data I/O pin y These bits are read-only. They contain the input value of the corresponding I/O port.
$00002000 constant GPIOA_GPIOA_IDR_IDR13                            \ Port x input data I/O pin y These bits are read-only. They contain the input value of the corresponding I/O port.
$00004000 constant GPIOA_GPIOA_IDR_IDR14                            \ Port x input data I/O pin y These bits are read-only. They contain the input value of the corresponding I/O port.
$00008000 constant GPIOA_GPIOA_IDR_IDR15                            \ Port x input data I/O pin y These bits are read-only. They contain the input value of the corresponding I/O port.


\
\ @brief GPIO port output data register
\ Address offset: 0x14
\ Reset value: 0x00000000
\

$00000001 constant GPIOA_GPIOA_ODR_ODR0                             \ Port output data I/O pin y These bits can be read and written by software. Note: For atomic bit set/reset, the ODR bits can be individually set and/or reset by writing to the GPIOx_BSRR register (x = A..F).
$00000002 constant GPIOA_GPIOA_ODR_ODR1                             \ Port output data I/O pin y These bits can be read and written by software. Note: For atomic bit set/reset, the ODR bits can be individually set and/or reset by writing to the GPIOx_BSRR register (x = A..F).
$00000004 constant GPIOA_GPIOA_ODR_ODR2                             \ Port output data I/O pin y These bits can be read and written by software. Note: For atomic bit set/reset, the ODR bits can be individually set and/or reset by writing to the GPIOx_BSRR register (x = A..F).
$00000008 constant GPIOA_GPIOA_ODR_ODR3                             \ Port output data I/O pin y These bits can be read and written by software. Note: For atomic bit set/reset, the ODR bits can be individually set and/or reset by writing to the GPIOx_BSRR register (x = A..F).
$00000010 constant GPIOA_GPIOA_ODR_ODR4                             \ Port output data I/O pin y These bits can be read and written by software. Note: For atomic bit set/reset, the ODR bits can be individually set and/or reset by writing to the GPIOx_BSRR register (x = A..F).
$00000020 constant GPIOA_GPIOA_ODR_ODR5                             \ Port output data I/O pin y These bits can be read and written by software. Note: For atomic bit set/reset, the ODR bits can be individually set and/or reset by writing to the GPIOx_BSRR register (x = A..F).
$00000040 constant GPIOA_GPIOA_ODR_ODR6                             \ Port output data I/O pin y These bits can be read and written by software. Note: For atomic bit set/reset, the ODR bits can be individually set and/or reset by writing to the GPIOx_BSRR register (x = A..F).
$00000080 constant GPIOA_GPIOA_ODR_ODR7                             \ Port output data I/O pin y These bits can be read and written by software. Note: For atomic bit set/reset, the ODR bits can be individually set and/or reset by writing to the GPIOx_BSRR register (x = A..F).
$00000100 constant GPIOA_GPIOA_ODR_ODR8                             \ Port output data I/O pin y These bits can be read and written by software. Note: For atomic bit set/reset, the ODR bits can be individually set and/or reset by writing to the GPIOx_BSRR register (x = A..F).
$00000200 constant GPIOA_GPIOA_ODR_ODR9                             \ Port output data I/O pin y These bits can be read and written by software. Note: For atomic bit set/reset, the ODR bits can be individually set and/or reset by writing to the GPIOx_BSRR register (x = A..F).
$00000400 constant GPIOA_GPIOA_ODR_ODR10                            \ Port output data I/O pin y These bits can be read and written by software. Note: For atomic bit set/reset, the ODR bits can be individually set and/or reset by writing to the GPIOx_BSRR register (x = A..F).
$00000800 constant GPIOA_GPIOA_ODR_ODR11                            \ Port output data I/O pin y These bits can be read and written by software. Note: For atomic bit set/reset, the ODR bits can be individually set and/or reset by writing to the GPIOx_BSRR register (x = A..F).
$00001000 constant GPIOA_GPIOA_ODR_ODR12                            \ Port output data I/O pin y These bits can be read and written by software. Note: For atomic bit set/reset, the ODR bits can be individually set and/or reset by writing to the GPIOx_BSRR register (x = A..F).
$00002000 constant GPIOA_GPIOA_ODR_ODR13                            \ Port output data I/O pin y These bits can be read and written by software. Note: For atomic bit set/reset, the ODR bits can be individually set and/or reset by writing to the GPIOx_BSRR register (x = A..F).
$00004000 constant GPIOA_GPIOA_ODR_ODR14                            \ Port output data I/O pin y These bits can be read and written by software. Note: For atomic bit set/reset, the ODR bits can be individually set and/or reset by writing to the GPIOx_BSRR register (x = A..F).
$00008000 constant GPIOA_GPIOA_ODR_ODR15                            \ Port output data I/O pin y These bits can be read and written by software. Note: For atomic bit set/reset, the ODR bits can be individually set and/or reset by writing to the GPIOx_BSRR register (x = A..F).


\
\ @brief GPIO port bit set/reset register
\ Address offset: 0x18
\ Reset value: 0x00000000
\

$00000001 constant GPIOA_GPIOA_BSRR_BS0                             \ Port x set I/O pin y These bits are write-only. A read to these bits returns the value 0x0000.
$00000002 constant GPIOA_GPIOA_BSRR_BS1                             \ Port x set I/O pin y These bits are write-only. A read to these bits returns the value 0x0000.
$00000004 constant GPIOA_GPIOA_BSRR_BS2                             \ Port x set I/O pin y These bits are write-only. A read to these bits returns the value 0x0000.
$00000008 constant GPIOA_GPIOA_BSRR_BS3                             \ Port x set I/O pin y These bits are write-only. A read to these bits returns the value 0x0000.
$00000010 constant GPIOA_GPIOA_BSRR_BS4                             \ Port x set I/O pin y These bits are write-only. A read to these bits returns the value 0x0000.
$00000020 constant GPIOA_GPIOA_BSRR_BS5                             \ Port x set I/O pin y These bits are write-only. A read to these bits returns the value 0x0000.
$00000040 constant GPIOA_GPIOA_BSRR_BS6                             \ Port x set I/O pin y These bits are write-only. A read to these bits returns the value 0x0000.
$00000080 constant GPIOA_GPIOA_BSRR_BS7                             \ Port x set I/O pin y These bits are write-only. A read to these bits returns the value 0x0000.
$00000100 constant GPIOA_GPIOA_BSRR_BS8                             \ Port x set I/O pin y These bits are write-only. A read to these bits returns the value 0x0000.
$00000200 constant GPIOA_GPIOA_BSRR_BS9                             \ Port x set I/O pin y These bits are write-only. A read to these bits returns the value 0x0000.
$00000400 constant GPIOA_GPIOA_BSRR_BS10                            \ Port x set I/O pin y These bits are write-only. A read to these bits returns the value 0x0000.
$00000800 constant GPIOA_GPIOA_BSRR_BS11                            \ Port x set I/O pin y These bits are write-only. A read to these bits returns the value 0x0000.
$00001000 constant GPIOA_GPIOA_BSRR_BS12                            \ Port x set I/O pin y These bits are write-only. A read to these bits returns the value 0x0000.
$00002000 constant GPIOA_GPIOA_BSRR_BS13                            \ Port x set I/O pin y These bits are write-only. A read to these bits returns the value 0x0000.
$00004000 constant GPIOA_GPIOA_BSRR_BS14                            \ Port x set I/O pin y These bits are write-only. A read to these bits returns the value 0x0000.
$00008000 constant GPIOA_GPIOA_BSRR_BS15                            \ Port x set I/O pin y These bits are write-only. A read to these bits returns the value 0x0000.
$00010000 constant GPIOA_GPIOA_BSRR_BR0                             \ Port x reset I/O pin y These bits are write-only. A read to these bits returns the value 0x0000. Note: If both BSx and BRx are set, BSx has priority.
$00020000 constant GPIOA_GPIOA_BSRR_BR1                             \ Port x reset I/O pin y These bits are write-only. A read to these bits returns the value 0x0000. Note: If both BSx and BRx are set, BSx has priority.
$00040000 constant GPIOA_GPIOA_BSRR_BR2                             \ Port x reset I/O pin y These bits are write-only. A read to these bits returns the value 0x0000. Note: If both BSx and BRx are set, BSx has priority.
$00080000 constant GPIOA_GPIOA_BSRR_BR3                             \ Port x reset I/O pin y These bits are write-only. A read to these bits returns the value 0x0000. Note: If both BSx and BRx are set, BSx has priority.
$00100000 constant GPIOA_GPIOA_BSRR_BR4                             \ Port x reset I/O pin y These bits are write-only. A read to these bits returns the value 0x0000. Note: If both BSx and BRx are set, BSx has priority.
$00200000 constant GPIOA_GPIOA_BSRR_BR5                             \ Port x reset I/O pin y These bits are write-only. A read to these bits returns the value 0x0000. Note: If both BSx and BRx are set, BSx has priority.
$00400000 constant GPIOA_GPIOA_BSRR_BR6                             \ Port x reset I/O pin y These bits are write-only. A read to these bits returns the value 0x0000. Note: If both BSx and BRx are set, BSx has priority.
$00800000 constant GPIOA_GPIOA_BSRR_BR7                             \ Port x reset I/O pin y These bits are write-only. A read to these bits returns the value 0x0000. Note: If both BSx and BRx are set, BSx has priority.
$01000000 constant GPIOA_GPIOA_BSRR_BR8                             \ Port x reset I/O pin y These bits are write-only. A read to these bits returns the value 0x0000. Note: If both BSx and BRx are set, BSx has priority.
$02000000 constant GPIOA_GPIOA_BSRR_BR9                             \ Port x reset I/O pin y These bits are write-only. A read to these bits returns the value 0x0000. Note: If both BSx and BRx are set, BSx has priority.
$04000000 constant GPIOA_GPIOA_BSRR_BR10                            \ Port x reset I/O pin y These bits are write-only. A read to these bits returns the value 0x0000. Note: If both BSx and BRx are set, BSx has priority.
$08000000 constant GPIOA_GPIOA_BSRR_BR11                            \ Port x reset I/O pin y These bits are write-only. A read to these bits returns the value 0x0000. Note: If both BSx and BRx are set, BSx has priority.
$10000000 constant GPIOA_GPIOA_BSRR_BR12                            \ Port x reset I/O pin y These bits are write-only. A read to these bits returns the value 0x0000. Note: If both BSx and BRx are set, BSx has priority.
$20000000 constant GPIOA_GPIOA_BSRR_BR13                            \ Port x reset I/O pin y These bits are write-only. A read to these bits returns the value 0x0000. Note: If both BSx and BRx are set, BSx has priority.
$40000000 constant GPIOA_GPIOA_BSRR_BR14                            \ Port x reset I/O pin y These bits are write-only. A read to these bits returns the value 0x0000. Note: If both BSx and BRx are set, BSx has priority.
$80000000 constant GPIOA_GPIOA_BSRR_BR15                            \ Port x reset I/O pin y These bits are write-only. A read to these bits returns the value 0x0000. Note: If both BSx and BRx are set, BSx has priority.


\
\ @brief GPIO port configuration lock register
\ Address offset: 0x1C
\ Reset value: 0x00000000
\

$00000001 constant GPIOA_GPIOA_LCKR_LCK0                            \ Port x lock I/O pin y These bits are read/write but can only be written when the LCKK bit is '0.
$00000002 constant GPIOA_GPIOA_LCKR_LCK1                            \ Port x lock I/O pin y These bits are read/write but can only be written when the LCKK bit is '0.
$00000004 constant GPIOA_GPIOA_LCKR_LCK2                            \ Port x lock I/O pin y These bits are read/write but can only be written when the LCKK bit is '0.
$00000008 constant GPIOA_GPIOA_LCKR_LCK3                            \ Port x lock I/O pin y These bits are read/write but can only be written when the LCKK bit is '0.
$00000010 constant GPIOA_GPIOA_LCKR_LCK4                            \ Port x lock I/O pin y These bits are read/write but can only be written when the LCKK bit is '0.
$00000020 constant GPIOA_GPIOA_LCKR_LCK5                            \ Port x lock I/O pin y These bits are read/write but can only be written when the LCKK bit is '0.
$00000040 constant GPIOA_GPIOA_LCKR_LCK6                            \ Port x lock I/O pin y These bits are read/write but can only be written when the LCKK bit is '0.
$00000080 constant GPIOA_GPIOA_LCKR_LCK7                            \ Port x lock I/O pin y These bits are read/write but can only be written when the LCKK bit is '0.
$00000100 constant GPIOA_GPIOA_LCKR_LCK8                            \ Port x lock I/O pin y These bits are read/write but can only be written when the LCKK bit is '0.
$00000200 constant GPIOA_GPIOA_LCKR_LCK9                            \ Port x lock I/O pin y These bits are read/write but can only be written when the LCKK bit is '0.
$00000400 constant GPIOA_GPIOA_LCKR_LCK10                           \ Port x lock I/O pin y These bits are read/write but can only be written when the LCKK bit is '0.
$00000800 constant GPIOA_GPIOA_LCKR_LCK11                           \ Port x lock I/O pin y These bits are read/write but can only be written when the LCKK bit is '0.
$00001000 constant GPIOA_GPIOA_LCKR_LCK12                           \ Port x lock I/O pin y These bits are read/write but can only be written when the LCKK bit is '0.
$00002000 constant GPIOA_GPIOA_LCKR_LCK13                           \ Port x lock I/O pin y These bits are read/write but can only be written when the LCKK bit is '0.
$00004000 constant GPIOA_GPIOA_LCKR_LCK14                           \ Port x lock I/O pin y These bits are read/write but can only be written when the LCKK bit is '0.
$00008000 constant GPIOA_GPIOA_LCKR_LCK15                           \ Port x lock I/O pin y These bits are read/write but can only be written when the LCKK bit is '0.
$00010000 constant GPIOA_GPIOA_LCKR_LCKK                            \ Lock key This bit can be read any time. It can only be modified using the lock key write sequence. LOCK key write sequence: WR LCKR[16] = '1' + LCKR[15:0] WR LCKR[16] = '0' + LCKR[15:0] WR LCKR[16] = '1' + LCKR[15:0] RD LCKR RD LCKR[16] = '1' (this read operation is optional but it confirms that the lock is active) Note: During the LOCK key write sequence, the value of LCK[15:0] must not change. Note: Any error in the lock sequence aborts the lock. Note: After the first lock sequence on any bit of the port, any read access on the LCKK bit returns '1' until the next MCU reset or peripheral reset.


\
\ @brief GPIO alternate function low register
\ Address offset: 0x20
\ Reset value: 0x00000000
\

$0000000f constant GPIOA_GPIOA_AFRL_AFR0                            \ Alternate function selection for port x I/O pin y These bits are written by software to configure alternate function I/Os.
$000000f0 constant GPIOA_GPIOA_AFRL_AFR1                            \ Alternate function selection for port x I/O pin y These bits are written by software to configure alternate function I/Os.
$00000f00 constant GPIOA_GPIOA_AFRL_AFR2                            \ Alternate function selection for port x I/O pin y These bits are written by software to configure alternate function I/Os.
$0000f000 constant GPIOA_GPIOA_AFRL_AFR3                            \ Alternate function selection for port x I/O pin y These bits are written by software to configure alternate function I/Os.
$000f0000 constant GPIOA_GPIOA_AFRL_AFR4                            \ Alternate function selection for port x I/O pin y These bits are written by software to configure alternate function I/Os.
$00f00000 constant GPIOA_GPIOA_AFRL_AFR5                            \ Alternate function selection for port x I/O pin y These bits are written by software to configure alternate function I/Os.
$0f000000 constant GPIOA_GPIOA_AFRL_AFR6                            \ Alternate function selection for port x I/O pin y These bits are written by software to configure alternate function I/Os.
$f0000000 constant GPIOA_GPIOA_AFRL_AFR7                            \ Alternate function selection for port x I/O pin y These bits are written by software to configure alternate function I/Os.


\
\ @brief GPIO alternate function high register
\ Address offset: 0x24
\ Reset value: 0x00000000
\

$0000000f constant GPIOA_GPIOA_AFRH_AFR8                            \ Alternate function selection for port x I/O pin y These bits are written by software to configure alternate function I/Os.
$000000f0 constant GPIOA_GPIOA_AFRH_AFR9                            \ Alternate function selection for port x I/O pin y These bits are written by software to configure alternate function I/Os.
$00000f00 constant GPIOA_GPIOA_AFRH_AFR10                           \ Alternate function selection for port x I/O pin y These bits are written by software to configure alternate function I/Os.
$0000f000 constant GPIOA_GPIOA_AFRH_AFR11                           \ Alternate function selection for port x I/O pin y These bits are written by software to configure alternate function I/Os.
$000f0000 constant GPIOA_GPIOA_AFRH_AFR12                           \ Alternate function selection for port x I/O pin y These bits are written by software to configure alternate function I/Os.
$00f00000 constant GPIOA_GPIOA_AFRH_AFR13                           \ Alternate function selection for port x I/O pin y These bits are written by software to configure alternate function I/Os.
$0f000000 constant GPIOA_GPIOA_AFRH_AFR14                           \ Alternate function selection for port x I/O pin y These bits are written by software to configure alternate function I/Os.
$f0000000 constant GPIOA_GPIOA_AFRH_AFR15                           \ Alternate function selection for port x I/O pin y These bits are written by software to configure alternate function I/Os.


\
\ @brief GPIO port bit reset register
\ Address offset: 0x28
\ Reset value: 0x00000000
\

$00000001 constant GPIOA_GPIOA_BRR_BR0                              \ Port x reset IO pin y These bits are write-only. A read to these bits returns the value 0x0000.
$00000002 constant GPIOA_GPIOA_BRR_BR1                              \ Port x reset IO pin y These bits are write-only. A read to these bits returns the value 0x0000.
$00000004 constant GPIOA_GPIOA_BRR_BR2                              \ Port x reset IO pin y These bits are write-only. A read to these bits returns the value 0x0000.
$00000008 constant GPIOA_GPIOA_BRR_BR3                              \ Port x reset IO pin y These bits are write-only. A read to these bits returns the value 0x0000.
$00000010 constant GPIOA_GPIOA_BRR_BR4                              \ Port x reset IO pin y These bits are write-only. A read to these bits returns the value 0x0000.
$00000020 constant GPIOA_GPIOA_BRR_BR5                              \ Port x reset IO pin y These bits are write-only. A read to these bits returns the value 0x0000.
$00000040 constant GPIOA_GPIOA_BRR_BR6                              \ Port x reset IO pin y These bits are write-only. A read to these bits returns the value 0x0000.
$00000080 constant GPIOA_GPIOA_BRR_BR7                              \ Port x reset IO pin y These bits are write-only. A read to these bits returns the value 0x0000.
$00000100 constant GPIOA_GPIOA_BRR_BR8                              \ Port x reset IO pin y These bits are write-only. A read to these bits returns the value 0x0000.
$00000200 constant GPIOA_GPIOA_BRR_BR9                              \ Port x reset IO pin y These bits are write-only. A read to these bits returns the value 0x0000.
$00000400 constant GPIOA_GPIOA_BRR_BR10                             \ Port x reset IO pin y These bits are write-only. A read to these bits returns the value 0x0000.
$00000800 constant GPIOA_GPIOA_BRR_BR11                             \ Port x reset IO pin y These bits are write-only. A read to these bits returns the value 0x0000.
$00001000 constant GPIOA_GPIOA_BRR_BR12                             \ Port x reset IO pin y These bits are write-only. A read to these bits returns the value 0x0000.
$00002000 constant GPIOA_GPIOA_BRR_BR13                             \ Port x reset IO pin y These bits are write-only. A read to these bits returns the value 0x0000.
$00004000 constant GPIOA_GPIOA_BRR_BR14                             \ Port x reset IO pin y These bits are write-only. A read to these bits returns the value 0x0000.
$00008000 constant GPIOA_GPIOA_BRR_BR15                             \ Port x reset IO pin y These bits are write-only. A read to these bits returns the value 0x0000.


\
\ @brief GPIOA address block description
\
$48000000 constant GPIOA_GPIOA_MODER  \ offset: 0x00 : GPIO port mode register
$48000004 constant GPIOA_GPIOA_OTYPER  \ offset: 0x04 : GPIO port output type register
$48000008 constant GPIOA_GPIOA_OSPEEDR  \ offset: 0x08 : GPIO port output speed register
$4800000c constant GPIOA_GPIOA_PUPDR  \ offset: 0x0C : GPIO port pull-up/pull-down register
$48000010 constant GPIOA_GPIOA_IDR  \ offset: 0x10 : GPIO port input data register
$48000014 constant GPIOA_GPIOA_ODR  \ offset: 0x14 : GPIO port output data register
$48000018 constant GPIOA_GPIOA_BSRR  \ offset: 0x18 : GPIO port bit set/reset register
$4800001c constant GPIOA_GPIOA_LCKR  \ offset: 0x1C : GPIO port configuration lock register
$48000020 constant GPIOA_GPIOA_AFRL  \ offset: 0x20 : GPIO alternate function low register
$48000024 constant GPIOA_GPIOA_AFRH  \ offset: 0x24 : GPIO alternate function high register
$48000028 constant GPIOA_GPIOA_BRR  \ offset: 0x28 : GPIO port bit reset register

