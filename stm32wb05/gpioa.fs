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
$00030000 constant GPIOA_MODER_MODE8                                \ MODE8[1:0]Port A configuration bits. These bits are written by software to configure the I/O mode. -00: Input mode -01: output mode -10: Alternate function mode -11: Analog mode
$000c0000 constant GPIOA_MODER_MODE9                                \ MODE9[1:0]Port A configuration bits. These bits are written by software to configure the I/O mode. -00: Input mode -01: output mode -10: Alternate function mode -11: Analog mode
$00300000 constant GPIOA_MODER_MODE10                               \ MODE10[1:0]Port A configuration bits. These bits are written by software to configure the I/O mode. -00: Input mode -01: output mode -10: Alternate function mode -11: Analog mode
$00c00000 constant GPIOA_MODER_MODE11                               \ MODE11[1:0]Port A configuration bits. These bits are written by software to configure the I/O mode. -00: Input mode -01: output mode -10: Alternate function mode -11: Analog mode


\
\ @brief OTYPER register
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$00000001 constant GPIOA_OTYPER_OT0                                 \ OT0: Port A configuration bits These bits are written by software to configure the I/O output type. -0: Output push-pull (reset state) -1: Output open-drain
$00000002 constant GPIOA_OTYPER_OT1                                 \ OT1: Port A configuration bits These bits are written by software to configure the I/O output type. -0: Output push-pull (reset state) -1: Output open-drain
$00000004 constant GPIOA_OTYPER_OT2                                 \ OT2: Port A configuration bits These bits are written by software to configure the I/O output type. -0: Output push-pull (reset state) -1: Output open-drain
$00000008 constant GPIOA_OTYPER_OT3                                 \ OT3: Port A configuration bits These bits are written by software to configure the I/O output type. -0: Output push-pull (reset state) -1: Output open-drain
$00000100 constant GPIOA_OTYPER_OT8                                 \ OT8: Port A configuration bits These bits are written by software to configure the I/O output type. -0: Output push-pull (reset state) -1: Output open-drain
$00000200 constant GPIOA_OTYPER_OT9                                 \ OT9: Port A configuration bits These bits are written by software to configure the I/O output type. -0: Output push-pull (reset state) -1: Output open-drain
$00000400 constant GPIOA_OTYPER_OT10                                \ OT10: Port A configuration bits These bits are written by software to configure the I/O output type. -0: Output push-pull (reset state) -1: Output open-drain
$00000800 constant GPIOA_OTYPER_OT11                                \ OT11: Port A configuration bits These bits are written by software to configure the I/O output type. -0: Output push-pull (reset state) -1: Output open-drain


\
\ @brief OSPEEDR register
\ Address offset: 0x08
\ Reset value: 0x00000030
\

$00000003 constant GPIOA_OSPEEDR_OSPEED0                            \ OSPEED0[1:0]: Port A configuration bits These bits are written by software to configure the I/O output speed.
$0000000c constant GPIOA_OSPEEDR_OSPEED1                            \ OSPEED1[1:0]: Port A configuration bits These bits are written by software to configure the I/O output speed.
$00000030 constant GPIOA_OSPEEDR_OSPEED2                            \ OSPEED2[1:0]: Port A configuration bits These bits are written by software to configure the I/O output speed.
$000000c0 constant GPIOA_OSPEEDR_OSPEED3                            \ OSPEED3[1:0]: Port A configuration bits These bits are written by software to configure the I/O output speed.
$00030000 constant GPIOA_OSPEEDR_OSPEED8                            \ OSPEED8[1:0]: Port A configuration bits These bits are written by software to configure the I/O output speed.
$000c0000 constant GPIOA_OSPEEDR_OSPEED9                            \ OSPEED9[1:0]: Port A configuration bits These bits are written by software to configure the I/O output speed.
$00300000 constant GPIOA_OSPEEDR_OSPEED10                           \ OSPEED10[1:0]: Port A configuration bits These bits are written by software to configure the I/O output speed.
$00c00000 constant GPIOA_OSPEEDR_OSPEED11                           \ OSPEED11[1:0]: Port A configuration bits These bits are written by software to configure the I/O output speed.


\
\ @brief PUPDR register
\ Address offset: 0x0C
\ Reset value: 0x00550095
\

$00000003 constant GPIOA_PUPDR_PUPD0                                \ PUPD0: Port A configuration bits These bits are written by software to configure the I/O pull-up or pull-down -00: No pull-up, pull-down -01: Pull-up -10: Pull-down -11: Reserved
$0000000c constant GPIOA_PUPDR_PUPD1                                \ PUPD1: Port A configuration bits These bits are written by software to configure the I/O pull-up or pull-down -00: No pull-up, pull-down -01: Pull-up -10: Pull-down -11: Reserved
$00000030 constant GPIOA_PUPDR_PUPD2                                \ PUPD2: Port A configuration bits These bits are written by software to configure the I/O pull-up or pull-down -00: No pull-up, pull-down -01: Pull-up -10: Pull-down -11: Reserved
$000000c0 constant GPIOA_PUPDR_PUPD3                                \ PUPD3: Port A configuration bits These bits are written by software to configure the I/O pull-up or pull-down -00: No pull-up, pull-down -01: Pull-up -10: Pull-down -11: Reserved
$00030000 constant GPIOA_PUPDR_PUPD8                                \ PUPD8: Port A configuration bits These bits are written by software to configure the I/O pull-up or pull-down -00: No pull-up, pull-down -01: Pull-up -10: Pull-down -11: Reserved
$000c0000 constant GPIOA_PUPDR_PUPD9                                \ PUPD9: Port A configuration bits These bits are written by software to configure the I/O pull-up or pull-down -00: No pull-up, pull-down -01: Pull-up -10: Pull-down -11: Reserved
$00300000 constant GPIOA_PUPDR_PUPD10                               \ PUPD10: Port A configuration bits These bits are written by software to configure the I/O pull-up or pull-down -00: No pull-up, pull-down -01: Pull-up -10: Pull-down -11: Reserved
$00c00000 constant GPIOA_PUPDR_PUPD11                               \ PUPD11: Port A configuration bits These bits are written by software to configure the I/O pull-up or pull-down -00: No pull-up, pull-down -01: Pull-up -10: Pull-down -11: Reserved


\
\ @brief IDR register
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$00000001 constant GPIOA_IDR_ID0                                    \ ID0: Port A input data bit.These bits are read-only. They contain the input value of the corresponding I/O port
$00000002 constant GPIOA_IDR_ID1                                    \ ID1: Port A input data bit.These bits are read-only. They contain the input value of the corresponding I/O port
$00000004 constant GPIOA_IDR_ID2                                    \ ID2: Port A input data bit.These bits are read-only. They contain the input value of the corresponding I/O port
$00000008 constant GPIOA_IDR_ID3                                    \ ID3: Port A input data bit.These bits are read-only. They contain the input value of the corresponding I/O port
$00000100 constant GPIOA_IDR_ID8                                    \ ID8: Port A input data bit.These bits are read-only. They contain the input value of the corresponding I/O port
$00000200 constant GPIOA_IDR_ID9                                    \ ID9: Port A input data bit.These bits are read-only. They contain the input value of the corresponding I/O port
$00000400 constant GPIOA_IDR_ID10                                   \ ID10: Port A input data bit.These bits are read-only. They contain the input value of the corresponding I/O port
$00000800 constant GPIOA_IDR_ID11                                   \ ID11: Port A input data bit.These bits are read-only. They contain the input value of the corresponding I/O port


\
\ @brief ODR register
\ Address offset: 0x14
\ Reset value: 0x00000000
\

$00000001 constant GPIOA_ODR_OD0                                    \ OD0: Port A output data bit These bits can be read and written by software
$00000002 constant GPIOA_ODR_OD1                                    \ OD1: Port A output data bit These bits can be read and written by software
$00000004 constant GPIOA_ODR_OD2                                    \ OD2: Port A output data bit These bits can be read and written by software
$00000008 constant GPIOA_ODR_OD3                                    \ OD3: Port A output data bit These bits can be read and written by software
$00000100 constant GPIOA_ODR_OD8                                    \ OD8: Port A output data bit These bits can be read and written by software
$00000200 constant GPIOA_ODR_OD9                                    \ OD9: Port A output data bit These bits can be read and written by software
$00000400 constant GPIOA_ODR_OD10                                   \ OD10: Port A output data bit These bits can be read and written by software
$00000800 constant GPIOA_ODR_OD11                                   \ OD11: Port A output data bit These bits can be read and written by software


\
\ @brief BSRR register
\ Address offset: 0x18
\ Reset value: 0x00000000
\

$00000001 constant GPIOA_BSRR_BS0                                   \ BS0: Port A set bit y These bits are write-only. A read to these bits returns the value 0x0000. -0: No action on the corresponding ODx bit -1: Sets the corresponding ODx bit
$00000002 constant GPIOA_BSRR_BS1                                   \ BS1: Port A set bit y These bits are write-only. A read to these bits returns the value 0x0000. -0: No action on the corresponding ODx bit -1: Sets the corresponding ODx bit
$00000004 constant GPIOA_BSRR_BS2                                   \ BS2: Port A set bit y These bits are write-only. A read to these bits returns the value 0x0000. -0: No action on the corresponding ODx bit -1: Sets the corresponding ODx bit
$00000008 constant GPIOA_BSRR_BS3                                   \ BS3: Port A set bit y These bits are write-only. A read to these bits returns the value 0x0000. -0: No action on the corresponding ODx bit -1: Sets the corresponding ODx bit
$00000100 constant GPIOA_BSRR_BS8                                   \ BS8: Port A set bit y These bits are write-only. A read to these bits returns the value 0x0000. -0: No action on the corresponding ODx bit -1: Sets the corresponding ODx bit
$00000200 constant GPIOA_BSRR_BS9                                   \ BS9: Port A set bit y These bits are write-only. A read to these bits returns the value 0x0000. -0: No action on the corresponding ODx bit -1: Sets the corresponding ODx bit
$00000400 constant GPIOA_BSRR_BS10                                  \ BS10: Port A set bit y These bits are write-only. A read to these bits returns the value 0x0000. -0: No action on the corresponding ODx bit -1: Sets the corresponding ODx bit
$00000800 constant GPIOA_BSRR_BS11                                  \ BS11: Port A set bit y These bits are write-only. A read to these bits returns the value 0x0000. -0: No action on the corresponding ODx bit -1: Sets the corresponding ODx bit
$00010000 constant GPIOA_BSRR_BR0                                   \ BR0: Port A reset bit y These bits are write-only. A read to these bits returns the value 0x0000. -0: No action on the corresponding ODx bit -1: Resets the corresponding ODx bit Note: If both BSx and BRx are set, BSx has priority.
$00020000 constant GPIOA_BSRR_BR1                                   \ BR1: Port A reset bit y These bits are write-only. A read to these bits returns the value 0x0000. -0: No action on the corresponding ODx bit -1: Resets the corresponding ODx bit Note: If both BSx and BRx are set, BSx has priority.
$00040000 constant GPIOA_BSRR_BR2                                   \ BR2: Port A reset bit y These bits are write-only. A read to these bits returns the value 0x0000. -0: No action on the corresponding ODx bit -1: Resets the corresponding ODx bit Note: If both BSx and BRx are set, BSx has priority.
$00080000 constant GPIOA_BSRR_BR3                                   \ BR3: Port A reset bit y These bits are write-only. A read to these bits returns the value 0x0000. -0: No action on the corresponding ODx bit -1: Resets the corresponding ODx bit Note: If both BSx and BRx are set, BSx has priority.
$01000000 constant GPIOA_BSRR_BR8                                   \ BR8: Port A reset bit y These bits are write-only. A read to these bits returns the value 0x0000. -0: No action on the corresponding ODx bit -1: Resets the corresponding ODx bit Note: If both BSx and BRx are set, BSx has priority.
$02000000 constant GPIOA_BSRR_BR9                                   \ BR9: Port A reset bit y These bits are write-only. A read to these bits returns the value 0x0000. -0: No action on the corresponding ODx bit -1: Resets the corresponding ODx bit Note: If both BSx and BRx are set, BSx has priority.
$04000000 constant GPIOA_BSRR_BR10                                  \ BR10: Port A reset bit y These bits are write-only. A read to these bits returns the value 0x0000. -0: No action on the corresponding ODx bit -1: Resets the corresponding ODx bit Note: If both BSx and BRx are set, BSx has priority.
$08000000 constant GPIOA_BSRR_BR11                                  \ BR11: Port A reset bit y These bits are write-only. A read to these bits returns the value 0x0000. -0: No action on the corresponding ODx bit -1: Resets the corresponding ODx bit Note: If both BSx and BRx are set, BSx has priority.


\
\ @brief LCKR register
\ Address offset: 0x1C
\ Reset value: 0x00000000
\

$00000001 constant GPIOA_LCKR_LCK0                                  \ LCK0: Port A lock bit 0 These bits are read/write but can only be written when the LCKK bit is 0, using the specific sequence described in LCKK bit description. -0: Port configuration not locked -1: Port configuration locked
$00000002 constant GPIOA_LCKR_LCK1                                  \ LCK1: Port A lock bit 1 These bits are read/write but can only be written when the LCKK bit is 0, using the specific sequence described in LCKK bit description. -0: Port configuration not locked -1: Port configuration locked
$00000004 constant GPIOA_LCKR_LCK2                                  \ LCK2: Port A lock bit 2 These bits are read/write but can only be written when the LCKK bit is 0, using the specific sequence described in LCKK bit description. -0: Port configuration not locked -1: Port configuration locked
$00000008 constant GPIOA_LCKR_LCK3                                  \ LCK3: Port A lock bit 3 These bits are read/write but can only be written when the LCKK bit is 0, using the specific sequence described in LCKK bit description. -0: Port configuration not locked -1: Port configuration locked
$00000100 constant GPIOA_LCKR_LCK8                                  \ LCK8: Port A lock bit 8 These bits are read/write but can only be written when the LCKK bit is 0, using the specific sequence described in LCKK bit description. -0: Port configuration not locked -1: Port configuration locked
$00000200 constant GPIOA_LCKR_LCK9                                  \ LCK9: Port A lock bit 9 These bits are read/write but can only be written when the LCKK bit is 0, using the specific sequence described in LCKK bit description. -0: Port configuration not locked -1: Port configuration locked
$00000400 constant GPIOA_LCKR_LCK10                                 \ LCK10: Port A lock bit 10 These bits are read/write but can only be written when the LCKK bit is 0, using the specific sequence described in LCKK bit description. -0: Port configuration not locked -1: Port configuration locked
$00000800 constant GPIOA_LCKR_LCK11                                 \ LCK11: Port A lock bit 11 These bits are read/write but can only be written when the LCKK bit is 0, using the specific sequence described in LCKK bit description. -0: Port configuration not locked -1: Port configuration locked
$00010000 constant GPIOA_LCKR_LCKK                                  \ LCKK: Lock key This bit can be read any time. It can only be modified using the lock key write sequence. -0: Port configuration lock key not active -1: Port configuration lock key active. The GPIOx_LCKR register is locked until the next MCU reset or peripheral reset. LOCK key write sequence: WR LCKR[16] = 1' + LCKR[15:0] WR LCKR[16] = 0' + LCKR[15:0] WR LCKR[16] = 1' + LCKR[15:0] RD LCKR RD LCKR[16] = 1' (this read operation is optional but it confirms that the lock is active) Note: During the LOCK key write sequence, the value of LCK[15:0] must not change. Any error in the lock sequence aborts the lock. After the first lock sequence on any bit of the port, any read access on the LCKK bit will return 1' until the next MCU reset or peripheral reset


\
\ @brief AFRL register
\ Address offset: 0x20
\ Reset value: 0x00000000
\

$0000000f constant GPIOA_AFRL_AFSEL0                                \ y[3:0]: Alternate function selection for port A pin y (y = 0..7) These bits are written by software to configure alternate function I/Os AFSELy selection: -0000: AF0 -0001: AF1 -0010: AF2 -0011: AF3 -0100: AF4 -0101: AF5 -0110: AF6 -0111: AF7 1xxx: Reserved
$000000f0 constant GPIOA_AFRL_AFSEL1                                \ y[3:0]: Alternate function selection for port A pin y (y = 0..7) These bits are written by software to configure alternate function I/Os AFSELy selection: -0000: AF0 -0001: AF1 -0010: AF2 -0011: AF3 -0100: AF4 -0101: AF5 -0110: AF6 -0111: AF7 1xxx: Reserved
$00000f00 constant GPIOA_AFRL_AFSEL2                                \ y[3:0]: Alternate function selection for port A pin y (y = 0..7) These bits are written by software to configure alternate function I/Os AFSELy selection: -0000: AF0 -0001: AF1 -0010: AF2 -0011: AF3 -0100: AF4 -0101: AF5 -0110: AF6 -0111: AF7 1xxx: Reserved
$0000f000 constant GPIOA_AFRL_AFSEL3                                \ y[3:0]: Alternate function selection for port A pin y (y = 0..7) These bits are written by software to configure alternate function I/Os AFSELy selection: -0000: AF0 -0001: AF1 -0010: AF2 -0011: AF3 -0100: AF4 -0101: AF5 -0110: AF6 -0111: AF7 1xxx: Reserved


\
\ @brief AFRH register
\ Address offset: 0x24
\ Reset value: 0x00000000
\

$0000000f constant GPIOA_AFRH_AFSEL8                                \ y[3:0]: Alternate function selection for port A pin y (y = 8..15) These bits are written by software to configure alternate function I/Os AFSELy selection: -0000: AF0 -0001: AF1 -0010: AF2 -0011: AF3 -0100: AF4 -0101: AF5 -0110: AF6 -0111: AF7 1xxx: Reserved
$000000f0 constant GPIOA_AFRH_AFSEL9                                \ y[3:0]: Alternate function selection for port A pin y (y = 8..15) These bits are written by software to configure alternate function I/Os AFSELy selection: -0000: AF0 -0001: AF1 -0010: AF2 -0011: AF3 -0100: AF4 -0101: AF5 -0110: AF6 -0111: AF7 1xxx: Reserved
$00000f00 constant GPIOA_AFRH_AFSEL10                               \ y[3:0]: Alternate function selection for port A pin y (y = 8..15) These bits are written by software to configure alternate function I/Os AFSELy selection: -0000: AF0 -0001: AF1 -0010: AF2 -0011: AF3 -0100: AF4 -0101: AF5 -0110: AF6 -0111: AF7 1xxx: Reserved
$0000f000 constant GPIOA_AFRH_AFSEL11                               \ y[3:0]: Alternate function selection for port A pin y (y = 8..15) These bits are written by software to configure alternate function I/Os AFSELy selection: -0000: AF0 -0001: AF1 -0010: AF2 -0011: AF3 -0100: AF4 -0101: AF5 -0110: AF6 -0111: AF7 1xxx: Reserved


\
\ @brief BRR register
\ Address offset: 0x28
\ Reset value: 0x00000000
\

$00000001 constant GPIOA_BRR_BR0                                    \ BR0: Port A reset bit y (y = 0..15) These bits are write-only. A read to these bits returns the value 0x0000. -0: No action on the corresponding ODx bit -1: Resets the corresponding ODx bit
$00000002 constant GPIOA_BRR_BR1                                    \ BR1: Port A reset bit y (y = 0..15) These bits are write-only. A read to these bits returns the value 0x0000. -0: No action on the corresponding ODx bit -1: Resets the corresponding ODx bit
$00000004 constant GPIOA_BRR_BR2                                    \ BR2: Port A reset bit y (y = 0..15) These bits are write-only. A read to these bits returns the value 0x0000. -0: No action on the corresponding ODx bit -1: Resets the corresponding ODx bit
$00000008 constant GPIOA_BRR_BR3                                    \ BR3: Port A reset bit y (y = 0..15) These bits are write-only. A read to these bits returns the value 0x0000. -0: No action on the corresponding ODx bit -1: Resets the corresponding ODx bit
$00000100 constant GPIOA_BRR_BR8                                    \ BR8: Port A reset bit y (y = 0..15) These bits are write-only. A read to these bits returns the value 0x0000. -0: No action on the corresponding ODx bit -1: Resets the corresponding ODx bit
$00000200 constant GPIOA_BRR_BR9                                    \ BR9: Port A reset bit y (y = 0..15) These bits are write-only. A read to these bits returns the value 0x0000. -0: No action on the corresponding ODx bit -1: Resets the corresponding ODx bit
$00000400 constant GPIOA_BRR_BR10                                   \ BR10: Port A reset bit y (y = 0..15) These bits are write-only. A read to these bits returns the value 0x0000. -0: No action on the corresponding ODx bit -1: Resets the corresponding ODx bit
$00000800 constant GPIOA_BRR_BR11                                   \ BR11: Port A reset bit y (y = 0..15) These bits are write-only. A read to these bits returns the value 0x0000. -0: No action on the corresponding ODx bit -1: Resets the corresponding ODx bit


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

