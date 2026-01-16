\
\ @file gpioa.fs
\ @brief GPIOA interrupt
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief MODER register
\ Address offset: 0x00
\ Reset value: 0x000000A0
\

$00000003 constant GPIOA_MODER_MODE0                                \ MODE0[1:0]Port A configuration bits. These bits are written by software to configure the I/O mode. -00: Input mode -01: output mode -10: Alternate function mode -11: Analog mode
$0000000c constant GPIOA_MODER_MODE1                                \ MODE1[1:0]Port A configuration bits. These bits are written by software to configure the I/O mode. -00: Input mode -01: output mode -10: Alternate function mode -11: Analog mode
$00000030 constant GPIOA_MODER_MODE2                                \ MODE2[1:0]Port A configuration bits. These bits are written by software to configure the I/O mode. -00: Input mode -01: output mode -10: Alternate function mode -11: Analog mode
$000000c0 constant GPIOA_MODER_MODE3                                \ MODE3[1:0]Port A configuration bits. These bits are written by software to configure the I/O mode. -00: Input mode -01: output mode -10: Alternate function mode -11: Analog mode
$00000300 constant GPIOA_MODER_MODE4                                \ MODE4[1:0]Port A configuration bits. These bits are written by software to configure the I/O mode. -00: Input mode -01: output mode -10: Alternate function mode -11: Analog mode
$00000c00 constant GPIOA_MODER_MODE5                                \ MODE5[1:0]Port A configuration bits. These bits are written by software to configure the I/O mode. -00: Input mode -01: output mode -10: Alternate function mode -11: Analog mode
$00003000 constant GPIOA_MODER_MODE6                                \ MODE6[1:0]Port A configuration bits. These bits are written by software to configure the I/O mode. -00: Input mode -01: output mode -10: Alternate function mode -11: Analog mode
$0000c000 constant GPIOA_MODER_MODE7                                \ MODE7[1:0]Port A configuration bits. These bits are written by software to configure the I/O mode. -00: Input mode -01: output mode -10: Alternate function mode -11: Analog mode
$00030000 constant GPIOA_MODER_MODE8                                \ MODE8[1:0]Port A configuration bits. These bits are written by software to configure the I/O mode. -00: Input mode -01: output mode -10: Alternate function mode -11: Analog mode
$000c0000 constant GPIOA_MODER_MODE9                                \ MODE9[1:0]Port A configuration bits. These bits are written by software to configure the I/O mode. -00: Input mode -01: output mode -10: Alternate function mode -11: Analog mode
$00300000 constant GPIOA_MODER_MODE10                               \ MODE10[1:0]Port A configuration bits. These bits are written by software to configure the I/O mode. -00: Input mode -01: output mode -10: Alternate function mode -11: Analog mode
$00c00000 constant GPIOA_MODER_MODE11                               \ MODE11[1:0]Port A configuration bits. These bits are written by software to configure the I/O mode. -00: Input mode -01: output mode -10: Alternate function mode -11: Analog mode
$03000000 constant GPIOA_MODER_MODE12                               \ MODE12[1:0]Port A configuration bits. These bits are written by software to configure the I/O mode. -00: Input mode -01: output mode -10: Alternate function mode -11: Analog mode
$0c000000 constant GPIOA_MODER_MODE13                               \ MODE13[1:0]Port A configuration bits. These bits are written by software to configure the I/O mode. -00: Input mode -01: output mode -10: Alternate function mode -11: Analog mode
$30000000 constant GPIOA_MODER_MODE14                               \ MODE14[1:0]Port A configuration bits. These bits are written by software to configure the I/O mode. -00: Input mode -01: output mode -10: Alternate function mode -11: Analog mode
$c0000000 constant GPIOA_MODER_MODE15                               \ MODE15[1:0]Port A configuration bits. These bits are written by software to configure the I/O mode. -00: Input mode -01: output mode -10: Alternate function mode -11: Analog mode


\
\ @brief OTYPER register
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$00000001 constant GPIOA_OTYPER_OT0                                 \ OT0: Port A configuration bits These bits are written by software to configure the I/O output type. -0: Output push-pull (reset state) -1: Output open-drain
$00000002 constant GPIOA_OTYPER_OT1                                 \ OT1: Port A configuration bits These bits are written by software to configure the I/O output type. -0: Output push-pull (reset state) -1: Output open-drain
$00000004 constant GPIOA_OTYPER_OT2                                 \ OT2: Port A configuration bits These bits are written by software to configure the I/O output type. -0: Output push-pull (reset state) -1: Output open-drain
$00000008 constant GPIOA_OTYPER_OT3                                 \ OT3: Port A configuration bits These bits are written by software to configure the I/O output type. -0: Output push-pull (reset state) -1: Output open-drain
$00000010 constant GPIOA_OTYPER_OT4                                 \ OT4: Port A configuration bits These bits are written by software to configure the I/O output type. -0: Output push-pull (reset state) -1: Output open-drain
$00000020 constant GPIOA_OTYPER_OT5                                 \ OT5: Port A configuration bits These bits are written by software to configure the I/O output type. -0: Output push-pull (reset state) -1: Output open-drain
$00000040 constant GPIOA_OTYPER_OT6                                 \ OT6: Port A configuration bits These bits are written by software to configure the I/O output type. -0: Output push-pull (reset state) -1: Output open-drain
$00000080 constant GPIOA_OTYPER_OT7                                 \ OT7: Port A configuration bits These bits are written by software to configure the I/O output type. -0: Output push-pull (reset state) -1: Output open-drain
$00000100 constant GPIOA_OTYPER_OT8                                 \ OT8: Port A configuration bits These bits are written by software to configure the I/O output type. -0: Output push-pull (reset state) -1: Output open-drain
$00000200 constant GPIOA_OTYPER_OT9                                 \ OT9: Port A configuration bits These bits are written by software to configure the I/O output type. -0: Output push-pull (reset state) -1: Output open-drain
$00000400 constant GPIOA_OTYPER_OT10                                \ OT10: Port A configuration bits These bits are written by software to configure the I/O output type. -0: Output push-pull (reset state) -1: Output open-drain
$00000800 constant GPIOA_OTYPER_OT11                                \ OT11: Port A configuration bits These bits are written by software to configure the I/O output type. -0: Output push-pull (reset state) -1: Output open-drain
$00001000 constant GPIOA_OTYPER_OT12                                \ OT12: Port A configuration bits These bits are written by software to configure the I/O output type. -0: Output push-pull (reset state) -1: Output open-drain
$00002000 constant GPIOA_OTYPER_OT13                                \ OT13: Port A configuration bits These bits are written by software to configure the I/O output type. -0: Output push-pull (reset state) -1: Output open-drain
$00004000 constant GPIOA_OTYPER_OT14                                \ OT14: Port A configuration bits These bits are written by software to configure the I/O output type. -0: Output push-pull (reset state) -1: Output open-drain
$00008000 constant GPIOA_OTYPER_OT15                                \ OT15: Port A configuration bits These bits are written by software to configure the I/O output type. -0: Output push-pull (reset state) -1: Output open-drain


\
\ @brief OSPEEDR register
\ Address offset: 0x08
\ Reset value: 0x00000030
\

$00000003 constant GPIOA_OSPEEDR_OSPEED0                            \ OSPEED0[1:0]: Port A configuration bits These bits are written by software to configure the I/O output speed.
$0000000c constant GPIOA_OSPEEDR_OSPEED1                            \ OSPEED1[1:0]: Port A configuration bits These bits are written by software to configure the I/O output speed.
$00000030 constant GPIOA_OSPEEDR_OSPEED2                            \ OSPEED2[1:0]: Port A configuration bits These bits are written by software to configure the I/O output speed.
$000000c0 constant GPIOA_OSPEEDR_OSPEED3                            \ OSPEED3[1:0]: Port A configuration bits These bits are written by software to configure the I/O output speed.
$00000300 constant GPIOA_OSPEEDR_OSPEED4                            \ OSPEED4[1:0]: Port A configuration bits These bits are written by software to configure the I/O output speed.
$00000c00 constant GPIOA_OSPEEDR_OSPEED5                            \ OSPEED5[1:0]: Port A configuration bits These bits are written by software to configure the I/O output speed.
$00003000 constant GPIOA_OSPEEDR_OSPEED6                            \ OSPEED6[1:0]: Port A configuration bits These bits are written by software to configure the I/O output speed.
$0000c000 constant GPIOA_OSPEEDR_OSPEED7                            \ OSPEED7[1:0]: Port A configuration bits These bits are written by software to configure the I/O output speed.
$00030000 constant GPIOA_OSPEEDR_OSPEED8                            \ OSPEED8[1:0]: Port A configuration bits These bits are written by software to configure the I/O output speed.
$000c0000 constant GPIOA_OSPEEDR_OSPEED9                            \ OSPEED9[1:0]: Port A configuration bits These bits are written by software to configure the I/O output speed.
$00300000 constant GPIOA_OSPEEDR_OSPEED10                           \ OSPEED10[1:0]: Port A configuration bits These bits are written by software to configure the I/O output speed.
$00c00000 constant GPIOA_OSPEEDR_OSPEED11                           \ OSPEED11[1:0]: Port A configuration bits These bits are written by software to configure the I/O output speed.
$03000000 constant GPIOA_OSPEEDR_OSPEED12                           \ OSPEED12[1:0]: Port A configuration bits These bits are written by software to configure the I/O output speed.
$0c000000 constant GPIOA_OSPEEDR_OSPEED13                           \ OSPEED13[1:0]: Port A configuration bits These bits are written by software to configure the I/O output speed.
$30000000 constant GPIOA_OSPEEDR_OSPEED14                           \ OSPEED14[1:0]: Port A configuration bits These bits are written by software to configure the I/O output speed.
$c0000000 constant GPIOA_OSPEEDR_OSPEED15                           \ OSPEED15[1:0]: Port A configuration bits These bits are written by software to configure the I/O output speed.


\
\ @brief PUPDR register
\ Address offset: 0x0C
\ Reset value: 0x55555595
\

$00000003 constant GPIOA_PUPDR_PUPD0                                \ PUPD0: Port A configuration bits These bits are written by software to configure the I/O pull-up or pull-down -00: No pull-up, pull-down -01: Pull-up -10: Pull-down -11: Reserved
$0000000c constant GPIOA_PUPDR_PUPD1                                \ PUPD1: Port A configuration bits These bits are written by software to configure the I/O pull-up or pull-down -00: No pull-up, pull-down -01: Pull-up -10: Pull-down -11: Reserved
$00000030 constant GPIOA_PUPDR_PUPD2                                \ PUPD2: Port A configuration bits These bits are written by software to configure the I/O pull-up or pull-down -00: No pull-up, pull-down -01: Pull-up -10: Pull-down -11: Reserved
$000000c0 constant GPIOA_PUPDR_PUPD3                                \ PUPD3: Port A configuration bits These bits are written by software to configure the I/O pull-up or pull-down -00: No pull-up, pull-down -01: Pull-up -10: Pull-down -11: Reserved
$00000300 constant GPIOA_PUPDR_PUPD4                                \ PUPD4: Port A configuration bits These bits are written by software to configure the I/O pull-up or pull-down -00: No pull-up, pull-down -01: Pull-up -10: Pull-down -11: Reserved
$00000c00 constant GPIOA_PUPDR_PUPD5                                \ PUPD5: Port A configuration bits These bits are written by software to configure the I/O pull-up or pull-down -00: No pull-up, pull-down -01: Pull-up -10: Pull-down -11: Reserved
$00003000 constant GPIOA_PUPDR_PUPD6                                \ PUPD6: Port A configuration bits These bits are written by software to configure the I/O pull-up or pull-down -00: No pull-up, pull-down -01: Pull-up -10: Pull-down -11: Reserved
$0000c000 constant GPIOA_PUPDR_PUPD7                                \ PUPD7: Port A configuration bits These bits are written by software to configure the I/O pull-up or pull-down -00: No pull-up, pull-down -01: Pull-up -10: Pull-down -11: Reserved
$00030000 constant GPIOA_PUPDR_PUPD8                                \ PUPD8: Port A configuration bits These bits are written by software to configure the I/O pull-up or pull-down -00: No pull-up, pull-down -01: Pull-up -10: Pull-down -11: Reserved
$000c0000 constant GPIOA_PUPDR_PUPD9                                \ PUPD9: Port A configuration bits These bits are written by software to configure the I/O pull-up or pull-down -00: No pull-up, pull-down -01: Pull-up -10: Pull-down -11: Reserved
$00300000 constant GPIOA_PUPDR_PUPD10                               \ PUPD10: Port A configuration bits These bits are written by software to configure the I/O pull-up or pull-down -00: No pull-up, pull-down -01: Pull-up -10: Pull-down -11: Reserved
$00c00000 constant GPIOA_PUPDR_PUPD11                               \ PUPD11: Port A configuration bits These bits are written by software to configure the I/O pull-up or pull-down -00: No pull-up, pull-down -01: Pull-up -10: Pull-down -11: Reserved
$03000000 constant GPIOA_PUPDR_PUPD12                               \ PUPD12: Port A configuration bits These bits are written by software to configure the I/O pull-up or pull-down -00: No pull-up, pull-down -01: Pull-up -10: Pull-down -11: Reserved
$0c000000 constant GPIOA_PUPDR_PUPD13                               \ PUPD13: Port A configuration bits These bits are written by software to configure the I/O pull-up or pull-down -00: No pull-up, pull-down -01: Pull-up -10: Pull-down -11: Reserved
$30000000 constant GPIOA_PUPDR_PUPD14                               \ PUPD14: Port A configuration bits These bits are written by software to configure the I/O pull-up or pull-down -00: No pull-up, pull-down -01: Pull-up -10: Pull-down -11: Reserved
$c0000000 constant GPIOA_PUPDR_PUPD15                               \ PUPD15: Port A configuration bits These bits are written by software to configure the I/O pull-up or pull-down -00: No pull-up, pull-down -01: Pull-up -10: Pull-down -11: Reserved


\
\ @brief IDR register
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$00000001 constant GPIOA_IDR_ID0                                    \ ID0: Port A input data bit.These bits are read-only. They contain the input value of the corresponding I/O port
$00000002 constant GPIOA_IDR_ID1                                    \ ID1: Port A input data bit.These bits are read-only. They contain the input value of the corresponding I/O port
$00000004 constant GPIOA_IDR_ID2                                    \ ID2: Port A input data bit.These bits are read-only. They contain the input value of the corresponding I/O port
$00000008 constant GPIOA_IDR_ID3                                    \ ID3: Port A input data bit.These bits are read-only. They contain the input value of the corresponding I/O port
$00000010 constant GPIOA_IDR_ID4                                    \ ID4: Port A input data bit.These bits are read-only. They contain the input value of the corresponding I/O port
$00000020 constant GPIOA_IDR_ID5                                    \ ID5: Port A input data bit.These bits are read-only. They contain the input value of the corresponding I/O port
$00000040 constant GPIOA_IDR_ID6                                    \ ID6: Port A input data bit.These bits are read-only. They contain the input value of the corresponding I/O port
$00000080 constant GPIOA_IDR_ID7                                    \ ID7: Port A input data bit.These bits are read-only. They contain the input value of the corresponding I/O port
$00000100 constant GPIOA_IDR_ID8                                    \ ID8: Port A input data bit.These bits are read-only. They contain the input value of the corresponding I/O port
$00000200 constant GPIOA_IDR_ID9                                    \ ID9: Port A input data bit.These bits are read-only. They contain the input value of the corresponding I/O port
$00000400 constant GPIOA_IDR_ID10                                   \ ID10: Port A input data bit.These bits are read-only. They contain the input value of the corresponding I/O port
$00000800 constant GPIOA_IDR_ID11                                   \ ID11: Port A input data bit.These bits are read-only. They contain the input value of the corresponding I/O port
$00001000 constant GPIOA_IDR_ID12                                   \ ID12: Port A input data bit.These bits are read-only. They contain the input value of the corresponding I/O port
$00002000 constant GPIOA_IDR_ID13                                   \ ID13: Port A input data bit.These bits are read-only. They contain the input value of the corresponding I/O port
$00004000 constant GPIOA_IDR_ID14                                   \ ID14: Port A input data bit.These bits are read-only. They contain the input value of the corresponding I/O port
$00008000 constant GPIOA_IDR_ID15                                   \ ID15: Port A input data bit.These bits are read-only. They contain the input value of the corresponding I/O port


\
\ @brief ODR register
\ Address offset: 0x14
\ Reset value: 0x00000000
\

$00000001 constant GPIOA_ODR_OD0                                    \ OD0: Port A output data bit These bits can be read and written by software
$00000002 constant GPIOA_ODR_OD1                                    \ OD1: Port A output data bit These bits can be read and written by software
$00000004 constant GPIOA_ODR_OD2                                    \ OD2: Port A output data bit These bits can be read and written by software
$00000008 constant GPIOA_ODR_OD3                                    \ OD3: Port A output data bit These bits can be read and written by software
$00000010 constant GPIOA_ODR_OD4                                    \ OD4: Port A output data bit These bits can be read and written by software
$00000020 constant GPIOA_ODR_OD5                                    \ OD5: Port A output data bit These bits can be read and written by software
$00000040 constant GPIOA_ODR_OD6                                    \ OD6: Port A output data bit These bits can be read and written by software
$00000080 constant GPIOA_ODR_OD7                                    \ OD7: Port A output data bit These bits can be read and written by software
$00000100 constant GPIOA_ODR_OD8                                    \ OD8: Port A output data bit These bits can be read and written by software
$00000200 constant GPIOA_ODR_OD9                                    \ OD9: Port A output data bit These bits can be read and written by software
$00000400 constant GPIOA_ODR_OD10                                   \ OD10: Port A output data bit These bits can be read and written by software
$00000800 constant GPIOA_ODR_OD11                                   \ OD11: Port A output data bit These bits can be read and written by software
$00001000 constant GPIOA_ODR_OD12                                   \ OD12: Port A output data bit These bits can be read and written by software
$00002000 constant GPIOA_ODR_OD13                                   \ OD13: Port A output data bit These bits can be read and written by software
$00004000 constant GPIOA_ODR_OD14                                   \ OD14: Port A output data bit These bits can be read and written by software
$00008000 constant GPIOA_ODR_OD15                                   \ OD15: Port A output data bit These bits can be read and written by software


\
\ @brief BSRR register
\ Address offset: 0x18
\ Reset value: 0x00000000
\

$00000001 constant GPIOA_BSRR_BS0                                   \ BS0: Port A set bit y These bits are write-only. A read to these bits returns the value 0x0000. 0: No action on the corresponding ODx bit 1: Sets the corresponding ODx bit
$00000002 constant GPIOA_BSRR_BS1                                   \ BS1: Port A set bit y These bits are write-only. A read to these bits returns the value 0x0000. 0: No action on the corresponding ODx bit 1: Sets the corresponding ODx bit
$00000004 constant GPIOA_BSRR_BS2                                   \ BS2: Port A set bit y These bits are write-only. A read to these bits returns the value 0x0000. 0: No action on the corresponding ODx bit 1: Sets the corresponding ODx bit
$00000008 constant GPIOA_BSRR_BS3                                   \ BS3: Port A set bit y These bits are write-only. A read to these bits returns the value 0x0000.
$00000010 constant GPIOA_BSRR_BS4                                   \ BS4: Port A set bit y These bits are write-only. A read to these bits returns the value 0x0000.
$00000020 constant GPIOA_BSRR_BS5                                   \ BS5: Port A set bit y These bits are write-only. A read to these bits returns the value 0x0000
$00000040 constant GPIOA_BSRR_BS6                                   \ BS6: Port A set bit y These bits are write-only. A read to these bits returns the value 0x0000.
$00000080 constant GPIOA_BSRR_BS7                                   \ BS7: Port A set bit y These bits are write-only. A read to these bits returns the value 0x0000
$00000100 constant GPIOA_BSRR_BS8                                   \ BS8: Port A set bit y These bits are write-only. A read to these bits returns the value 0x0000.
$00000200 constant GPIOA_BSRR_BS9                                   \ BS9: Port A set bit y These bits are write-only. A read to these bits returns the value 0x0000.
$00000400 constant GPIOA_BSRR_BS10                                  \ BS10: Port A set bit y These bits are write-only. A read to these bits returns the value 0x0000.
$00000800 constant GPIOA_BSRR_BS11                                  \ BS11: Port A set bit y These bits are write-only. A read to these bits returns the value 0x0000.
$00001000 constant GPIOA_BSRR_BS12                                  \ BS12: Port A set bit y These bits are write-only. A read to these bits returns the value 0x0000.
$00002000 constant GPIOA_BSRR_BS13                                  \ BS13: Port A set bit y These bits are write-only. A read to these bits returns the value 0x0000.
$00004000 constant GPIOA_BSRR_BS14                                  \ BS14: Port A set bit y These bits are write-only. A read to these bits returns the value 0x0000.
$00008000 constant GPIOA_BSRR_BS15                                  \ BS15: Port A set bit y These bits are write-only. A read to these bits returns the value 0x0000.
$00010000 constant GPIOA_BSRR_BR0                                   \ BR0: Port A reset bit y These bits are write-only. A read to these bits returns the value 0x0000. -0: No action on the corresponding ODx bit -1: Resets the corresponding ODx bit Note: If both BSx and BRx are set, BSx has priority.
$00020000 constant GPIOA_BSRR_BR1                                   \ BR1: Port A reset bit y These bits are write-only. A read to these bits returns the value 0x0000. -0: No action on the corresponding ODx bit -1: Resets the corresponding ODx bit Note: If both BSx and BRx are set, BSx has priority.
$00040000 constant GPIOA_BSRR_BR2                                   \ BR2: Port A reset bit y These bits are write-only. A read to these bits returns the value 0x0000. -0: No action on the corresponding ODx bit -1: Resets the corresponding ODx bit Note: If both BSx and BRx are set, BSx has priority.
$00080000 constant GPIOA_BSRR_BR3                                   \ BR3: Port A reset bit y These bits are write-only. A read to these bits returns the value 0x0000. -0: No action on the corresponding ODx bit -1: Resets the corresponding ODx bit Note: If both BSx and BRx are set, BSx has priority.
$00100000 constant GPIOA_BSRR_BR4                                   \ BR4: Port A reset bit y These bits are write-only. A read to these bits returns the value 0x0000. -0: No action on the corresponding ODx bit -1: Resets the corresponding ODx bit Note: If both BSx and BRx are set, BSx has priority.
$00200000 constant GPIOA_BSRR_BR5                                   \ BR5: Port A reset bit y These bits are write-only. A read to these bits returns the value 0x0000. -0: No action on the corresponding ODx bit -1: Resets the corresponding ODx bit Note: If both BSx and BRx are set, BSx has priority.
$00400000 constant GPIOA_BSRR_BR6                                   \ BR6: Port A reset bit y These bits are write-only. A read to these bits returns the value 0x0000. -0: No action on the corresponding ODx bit -1: Resets the corresponding ODx bit Note: If both BSx and BRx are set, BSx has priority.
$00800000 constant GPIOA_BSRR_BR7                                   \ BR7: Port A reset bit y These bits are write-only. A read to these bits returns the value 0x0000. -0: No action on the corresponding ODx bit -1: Resets the corresponding ODx bit Note: If both BSx and BRx are set, BSx has priority.
$01000000 constant GPIOA_BSRR_BR8                                   \ BR8: Port A reset bit y These bits are write-only. A read to these bits returns the value 0x0000. -0: No action on the corresponding ODx bit -1: Resets the corresponding ODx bit Note: If both BSx and BRx are set, BSx has priority.
$02000000 constant GPIOA_BSRR_BR9                                   \ BR9: Port A reset bit y These bits are write-only. A read to these bits returns the value 0x0000. -0: No action on the corresponding ODx bit -1: Resets the corresponding ODx bit Note: If both BSx and BRx are set, BSx has priority.
$04000000 constant GPIOA_BSRR_BR10                                  \ BR10: Port A reset bit y These bits are write-only. A read to these bits returns the value 0x0000. -0: No action on the corresponding ODx bit -1: Resets the corresponding ODx bit Note: If both BSx and BRx are set, BSx has priority.
$08000000 constant GPIOA_BSRR_BR11                                  \ BR11: Port A reset bit y These bits are write-only. A read to these bits returns the value 0x0000. -0: No action on the corresponding ODx bit -1: Resets the corresponding ODx bit Note: If both BSx and BRx are set, BSx has priority.
$10000000 constant GPIOA_BSRR_BR12                                  \ BR12: Port A reset bit y These bits are write-only. A read to these bits returns the value 0x0000. -0: No action on the corresponding ODx bit -1: Resets the corresponding ODx bit Note: If both BSx and BRx are set, BSx has priority.
$20000000 constant GPIOA_BSRR_BR13                                  \ BR13: Port A reset bit y These bits are write-only. A read to these bits returns the value 0x0000. -0: No action on the corresponding ODx bit -1: Resets the corresponding ODx bit Note: If both BSx and BRx are set, BSx has priority.
$40000000 constant GPIOA_BSRR_BR14                                  \ BR14: Port A reset bit y These bits are write-only. A read to these bits returns the value 0x0000. -0: No action on the corresponding ODx bit -1: Resets the corresponding ODx bit Note: If both BSx and BRx are set, BSx has priority.
$80000000 constant GPIOA_BSRR_BR15                                  \ BR15: Port A reset bit y These bits are write-only. A read to these bits returns the value 0x0000. -0: No action on the corresponding ODx bit -1: Resets the corresponding ODx bit Note: If both BSx and BRx are set, BSx has priority.


\
\ @brief LCKR register
\ Address offset: 0x1C
\ Reset value: 0x00000000
\

$00000001 constant GPIOA_LCKR_LCK0                                  \ LCK0: Port A lock bit 0 These bits are read/write but can only be written when the LCKK bit is 0, using the specific sequence described in LCKK bit description. -0: Port configuration not locked -1: Port configuration locked
$00000002 constant GPIOA_LCKR_LCK1                                  \ LCK1: Port A lock bit 1 These bits are read/write but can only be written when the LCKK bit is 0, using the specific sequence described in LCKK bit description. -0: Port configuration not locked -1: Port configuration locked
$00000004 constant GPIOA_LCKR_LCK2                                  \ LCK2: Port A lock bit 2 These bits are read/write but can only be written when the LCKK bit is 0, using the specific sequence described in LCKK bit description. -0: Port configuration not locked -1: Port configuration locked
$00000008 constant GPIOA_LCKR_LCK3                                  \ LCK3: Port A lock bit 3 These bits are read/write but can only be written when the LCKK bit is 0, using the specific sequence described in LCKK bit description. -0: Port configuration not locked -1: Port configuration locked
$00000010 constant GPIOA_LCKR_LCK4                                  \ LCK4: Port A lock bit 4 These bits are read/write but can only be written when the LCKK bit is 0, using the specific sequence described in LCKK bit description. -0: Port configuration not locked -1: Port configuration locked
$00000020 constant GPIOA_LCKR_LCK5                                  \ LCK5: Port A lock bit 5 These bits are read/write but can only be written when the LCKK bit is 0, using the specific sequence described in LCKK bit description. -0: Port configuration not locked -1: Port configuration locked
$00000040 constant GPIOA_LCKR_LCK6                                  \ LCK6: Port A lock bit 6 These bits are read/write but can only be written when the LCKK bit is 0, using the specific sequence described in LCKK bit description. -0: Port configuration not locked -1: Port configuration locked
$00000080 constant GPIOA_LCKR_LCK7                                  \ LCK7: Port A lock bit 7 These bits are read/write but can only be written when the LCKK bit is 0, using the specific sequence described in LCKK bit description. -0: Port configuration not locked -1: Port configuration locked
$00000100 constant GPIOA_LCKR_LCK8                                  \ LCK8: Port A lock bit 8 These bits are read/write but can only be written when the LCKK bit is 0, using the specific sequence described in LCKK bit description. -0: Port configuration not locked -1: Port configuration locked
$00000200 constant GPIOA_LCKR_LCK9                                  \ LCK9: Port A lock bit 9 These bits are read/write but can only be written when the LCKK bit is 0, using the specific sequence described in LCKK bit description. -0: Port configuration not locked -1: Port configuration locked
$00000400 constant GPIOA_LCKR_LCK10                                 \ LCK10: Port A lock bit 10 These bits are read/write but can only be written when the LCKK bit is 0, using the specific sequence described in LCKK bit description. -0: Port configuration not locked -1: Port configuration locked
$00000800 constant GPIOA_LCKR_LCK11                                 \ LCK11: Port A lock bit 11 These bits are read/write but can only be written when the LCKK bit is 0, using the specific sequence described in LCKK bit description. -0: Port configuration not locked -1: Port configuration locked
$00001000 constant GPIOA_LCKR_LCK12                                 \ LCK12: Port A lock bit 12 These bits are read/write but can only be written when the LCKK bit is 0, using the specific sequence described in LCKK bit description. -0: Port configuration not locked -1: Port configuration locked
$00002000 constant GPIOA_LCKR_LCK13                                 \ LCK13: Port A lock bit 13 These bits are read/write but can only be written when the LCKK bit is 0, using the specific sequence described in LCKK bit description. -0: Port configuration not locked -1: Port configuration locked
$00004000 constant GPIOA_LCKR_LCK14                                 \ LCK14: Port A lock bit 14 These bits are read/write but can only be written when the LCKK bit is 0, using the specific sequence described in LCKK bit description. -0: Port configuration not locked -1: Port configuration locked
$00008000 constant GPIOA_LCKR_LCK15                                 \ LCK15: Port A lock bit 15 These bits are read/write but can only be written when the LCKK bit is 0, using the specific sequence described in LCKK bit description. -0: Port configuration not locked -1: Port configuration locked
$00010000 constant GPIOA_LCKR_LCKK                                  \ LCKK: Lock key This bit can be read any time. It can only be modified using the lock key write sequence. -0: Port configuration lock key not active -1: Port configuration lock key active. The GPIOx_LCKR register is locked until the next MCU reset or peripheral reset. LOCK key write sequence: WR LCKR[16] = 1 + LCKR[15:0] WR LCKR[16] = 0 + LCKR[15:0] WR LCKR[16] = 1 + LCKR[15:0] RD LCKR RD LCKR[16] = 1 (this read operation is optional but it confirms that the lock is active) Note: During the LOCK key write sequence, the value of LCK[15:0] must not change. Any error in the lock sequence aborts the lock. After the first lock sequence on any bit of the port, any read access on the LCKK bit will return 1 until the next MCU reset or peripheral reset


\
\ @brief AFRL register
\ Address offset: 0x20
\ Reset value: 0x00000000
\

$0000000f constant GPIOA_AFRL_AFSEL0                                \ y[3:0]: Alternate function selection for port A pin y (y = 0..7) These bits are written by software to configure alternate function I/Os AFSELy selection: -0000: AF0 -0001: AF1 -0010: AF2 -0011: AF3 -0100: AF4 -0101: AF5 -0110: AF6 -0111: AF7 1xxx: Reserved
$000000f0 constant GPIOA_AFRL_AFSEL1                                \ y[3:0]: Alternate function selection for port A pin y (y = 0..7) These bits are written by software to configure alternate function I/Os AFSELy selection: -0000: AF0 -0001: AF1 -0010: AF2 -0011: AF3 -0100: AF4 -0101: AF5 -0110: AF6 -0111: AF7 1xxx: Reserved
$00000f00 constant GPIOA_AFRL_AFSEL2                                \ y[3:0]: Alternate function selection for port A pin y (y = 0..7) These bits are written by software to configure alternate function I/Os AFSELy selection: -0000: AF0 -0001: AF1 -0010: AF2 -0011: AF3 -0100: AF4 -0101: AF5 -0110: AF6 -0111: AF7 1xxx: Reserved
$0000f000 constant GPIOA_AFRL_AFSEL3                                \ y[3:0]: Alternate function selection for port A pin y (y = 0..7) These bits are written by software to configure alternate function I/Os AFSELy selection: -0000: AF0 -0001: AF1 -0010: AF2 -0011: AF3 -0100: AF4 -0101: AF5 -0110: AF6 -0111: AF7 1xxx: Reserved
$000f0000 constant GPIOA_AFRL_AFSEL4                                \ y[3:0]: Alternate function selection for port A pin y (y = 0..7) These bits are written by software to configure alternate function I/Os AFSELy selection: -0000: AF0 -0001: AF1 -0010: AF2 -0011: AF3 -0100: AF4 -0101: AF5 -0110: AF6 -0111: AF7 1xxx: Reserved
$00f00000 constant GPIOA_AFRL_AFSEL5                                \ y[3:0]: Alternate function selection for port A pin y (y = 0..7) These bits are written by software to configure alternate function I/Os AFSELy selection: -0000: AF0 -0001: AF1 -0010: AF2 -0011: AF3 -0100: AF4 -0101: AF5 -0110: AF6 -0111: AF7 1xxx: Reserved
$0f000000 constant GPIOA_AFRL_AFSEL6                                \ y[3:0]: Alternate function selection for port A pin y (y = 0..7) These bits are written by software to configure alternate function I/Os AFSELy selection: -0000: AF0 -0001: AF1 -0010: AF2 -0011: AF3 -0100: AF4 -0101: AF5 -0110: AF6 -0111: AF7 1xxx: Reserved
$f0000000 constant GPIOA_AFRL_AFSEL7                                \ y[3:0]: Alternate function selection for port A pin y (y = 0..7) These bits are written by software to configure alternate function I/Os AFSELy selection: -0000: AF0 -0001: AF1 -0010: AF2 -0011: AF3 -0100: AF4 -0101: AF5 -0110: AF6 -0111: AF7 1xxx: Reserved


\
\ @brief AFRH register
\ Address offset: 0x24
\ Reset value: 0x00000000
\

$0000000f constant GPIOA_AFRH_AFSEL8                                \ y[3:0]: Alternate function selection for port A pin y (y = 8..15) These bits are written by software to configure alternate function I/Os AFSELy selection: -0000: AF0 -0001: AF1 -0010: AF2 -0011: AF3 -0100: AF4 -0101: AF5 -0110: AF6 -0111: AF7 1xxx: Reserved
$000000f0 constant GPIOA_AFRH_AFSEL9                                \ y[3:0]: Alternate function selection for port A pin y (y = 8..15) These bits are written by software to configure alternate function I/Os AFSELy selection: -0000: AF0 -0001: AF1 -0010: AF2 -0011: AF3 -0100: AF4 -0101: AF5 -0110: AF6 -0111: AF7 1xxx: Reserved
$00000f00 constant GPIOA_AFRH_AFSEL10                               \ y[3:0]: Alternate function selection for port A pin y (y = 8..15) These bits are written by software to configure alternate function I/Os AFSELy selection: -0000: AF0 -0001: AF1 -0010: AF2 -0011: AF3 -0100: AF4 -0101: AF5 -0110: AF6 -0111: AF7 1xxx: Reserved
$0000f000 constant GPIOA_AFRH_AFSEL11                               \ y[3:0]: Alternate function selection for port A pin y (y = 8..15) These bits are written by software to configure alternate function I/Os AFSELy selection: -0000: AF0 -0001: AF1 -0010: AF2 -0011: AF3 -0100: AF4 -0101: AF5 -0110: AF6 -0111: AF7 1xxx: Reserved
$000f0000 constant GPIOA_AFRH_AFSEL12                               \ y[3:0]: Alternate function selection for port A pin y (y = 8..15) These bits are written by software to configure alternate function I/Os AFSELy selection: -0000: AF0 -0001: AF1 -0010: AF2 -0011: AF3 -0100: AF4 -0101: AF5 -0110: AF6 -0111: AF7 1xxx: Reserved
$00f00000 constant GPIOA_AFRH_AFSEL13                               \ y[3:0]: Alternate function selection for port A pin y (y = 8..15) These bits are written by software to configure alternate function I/Os AFSELy selection: -0000: AF0 -0001: AF1 -0010: AF2 -0011: AF3 -0100: AF4 -0101: AF5 -0110: AF6 -0111: AF7 1xxx: Reserved
$0f000000 constant GPIOA_AFRH_AFSEL14                               \ y[3:0]: Alternate function selection for port A pin y (y = 8..15) These bits are written by software to configure alternate function I/Os AFSELy selection: -0000: AF0 -0001: AF1 -0010: AF2 -0011: AF3 -0100: AF4 -0101: AF5 -0110: AF6 -0111: AF7 1xxx: Reserved
$f0000000 constant GPIOA_AFRH_AFSEL15                               \ y[3:0]: Alternate function selection for port A pin y (y = 8..15) These bits are written by software to configure alternate function I/Os AFSELy selection: -0000: AF0 -0001: AF1 -0010: AF2 -0011: AF3 -0100: AF4 -0101: AF5 -0110: AF6 -0111: AF7 1xxx: Reserved


\
\ @brief BRR register
\ Address offset: 0x28
\ Reset value: 0x00000000
\

$00000001 constant GPIOA_BRR_BR0                                    \ BR0: Port A reset bit y (y = 0..15) These bits are write-only. A read to these bits returns the value 0x0000. -0: No action on the corresponding ODx bit -1: Resets the corresponding ODx bit
$00000002 constant GPIOA_BRR_BR1                                    \ BR1: Port A reset bit y (y = 0..15) These bits are write-only. A read to these bits returns the value 0x0000. -0: No action on the corresponding ODx bit -1: Resets the corresponding ODx bit
$00000004 constant GPIOA_BRR_BR2                                    \ BR2: Port A reset bit y (y = 0..15) These bits are write-only. A read to these bits returns the value 0x0000. -0: No action on the corresponding ODx bit -1: Resets the corresponding ODx bit
$00000008 constant GPIOA_BRR_BR3                                    \ BR3: Port A reset bit y (y = 0..15) These bits are write-only. A read to these bits returns the value 0x0000. -0: No action on the corresponding ODx bit -1: Resets the corresponding ODx bit
$00000010 constant GPIOA_BRR_BR4                                    \ BR4: Port A reset bit y (y = 0..15) These bits are write-only. A read to these bits returns the value 0x0000. -0: No action on the corresponding ODx bit -1: Resets the corresponding ODx bit
$00000020 constant GPIOA_BRR_BR5                                    \ BR5: Port A reset bit y (y = 0..15) These bits are write-only. A read to these bits returns the value 0x0000. -0: No action on the corresponding ODx bit -1: Resets the corresponding ODx bit
$00000040 constant GPIOA_BRR_BR6                                    \ BR6: Port A reset bit y (y = 0..15) These bits are write-only. A read to these bits returns the value 0x0000. -0: No action on the corresponding ODx bit -1: Resets the corresponding ODx bit
$00000080 constant GPIOA_BRR_BR7                                    \ BR7: Port A reset bit y (y = 0..15) These bits are write-only. A read to these bits returns the value 0x0000. -0: No action on the corresponding ODx bit -1: Resets the corresponding ODx bit
$00000100 constant GPIOA_BRR_BR8                                    \ BR8: Port A reset bit y (y = 0..15) These bits are write-only. A read to these bits returns the value 0x0000. -0: No action on the corresponding ODx bit -1: Resets the corresponding ODx bit
$00000200 constant GPIOA_BRR_BR9                                    \ BR9: Port A reset bit y (y = 0..15) These bits are write-only. A read to these bits returns the value 0x0000. -0: No action on the corresponding ODx bit -1: Resets the corresponding ODx bit
$00000400 constant GPIOA_BRR_BR10                                   \ BR10: Port A reset bit y (y = 0..15) These bits are write-only. A read to these bits returns the value 0x0000. -0: No action on the corresponding ODx bit -1: Resets the corresponding ODx bit
$00000800 constant GPIOA_BRR_BR11                                   \ BR11: Port A reset bit y (y = 0..15) These bits are write-only. A read to these bits returns the value 0x0000. -0: No action on the corresponding ODx bit -1: Resets the corresponding ODx bit
$00001000 constant GPIOA_BRR_BR12                                   \ BR12: Port A reset bit y (y = 0..15) These bits are write-only. A read to these bits returns the value 0x0000. -0: No action on the corresponding ODx bit -1: Resets the corresponding ODx bit
$00002000 constant GPIOA_BRR_BR13                                   \ BR13: Port A reset bit y (y = 0..15) These bits are write-only. A read to these bits returns the value 0x0000. -0: No action on the corresponding ODx bit -1: Resets the corresponding ODx bit
$00004000 constant GPIOA_BRR_BR14                                   \ BR14: Port A reset bit y (y = 0..15) These bits are write-only. A read to these bits returns the value 0x0000. -0: No action on the corresponding ODx bit -1: Resets the corresponding ODx bit
$00008000 constant GPIOA_BRR_BR15                                   \ BR15: Port A reset bit y (y = 0..15) These bits are write-only. A read to these bits returns the value 0x0000. -0: No action on the corresponding ODx bit -1: Resets the corresponding ODx bit


\
\ @brief GPIOA interrupt
\
$48000000 constant GPIOA_MODER    \ offset: 0x00 : MODER register
$48000004 constant GPIOA_OTYPER   \ offset: 0x04 : OTYPER register
$48000008 constant GPIOA_OSPEEDR  \ offset: 0x08 : OSPEEDR register
$4800000c constant GPIOA_PUPDR    \ offset: 0x0C : PUPDR register
$48000010 constant GPIOA_IDR      \ offset: 0x10 : IDR register
$48000014 constant GPIOA_ODR      \ offset: 0x14 : ODR register
$48000018 constant GPIOA_BSRR     \ offset: 0x18 : BSRR register
$4800001c constant GPIOA_LCKR     \ offset: 0x1C : LCKR register
$48000020 constant GPIOA_AFRL     \ offset: 0x20 : AFRL register
$48000024 constant GPIOA_AFRH     \ offset: 0x24 : AFRH register
$48000028 constant GPIOA_BRR      \ offset: 0x28 : BRR register

