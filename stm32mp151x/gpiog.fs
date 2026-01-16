\
\ @file gpiog.fs
\ @brief GPIOG
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

$00000003 constant GPIOG_GPIOG_MODER_MODER0                         \ MODER0
$0000000c constant GPIOG_GPIOG_MODER_MODER1                         \ MODER1
$00000030 constant GPIOG_GPIOG_MODER_MODER2                         \ MODER2
$000000c0 constant GPIOG_GPIOG_MODER_MODER3                         \ MODER3
$00000300 constant GPIOG_GPIOG_MODER_MODER4                         \ MODER4
$00000c00 constant GPIOG_GPIOG_MODER_MODER5                         \ MODER5
$00003000 constant GPIOG_GPIOG_MODER_MODER6                         \ MODER6
$0000c000 constant GPIOG_GPIOG_MODER_MODER7                         \ MODER7
$00030000 constant GPIOG_GPIOG_MODER_MODER8                         \ MODER8
$000c0000 constant GPIOG_GPIOG_MODER_MODER9                         \ MODER9
$00300000 constant GPIOG_GPIOG_MODER_MODER10                        \ MODER10
$00c00000 constant GPIOG_GPIOG_MODER_MODER11                        \ MODER11
$03000000 constant GPIOG_GPIOG_MODER_MODER12                        \ MODER12
$0c000000 constant GPIOG_GPIOG_MODER_MODER13                        \ MODER13
$30000000 constant GPIOG_GPIOG_MODER_MODER14                        \ MODER14
$c0000000 constant GPIOG_GPIOG_MODER_MODER15                        \ MODER15


\
\ @brief GPIO port output type register
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$00000001 constant GPIOG_GPIOG_OTYPER_OT0                           \ OT0
$00000002 constant GPIOG_GPIOG_OTYPER_OT1                           \ OT1
$00000004 constant GPIOG_GPIOG_OTYPER_OT2                           \ OT2
$00000008 constant GPIOG_GPIOG_OTYPER_OT3                           \ OT3
$00000010 constant GPIOG_GPIOG_OTYPER_OT4                           \ OT4
$00000020 constant GPIOG_GPIOG_OTYPER_OT5                           \ OT5
$00000040 constant GPIOG_GPIOG_OTYPER_OT6                           \ OT6
$00000080 constant GPIOG_GPIOG_OTYPER_OT7                           \ OT7
$00000100 constant GPIOG_GPIOG_OTYPER_OT8                           \ OT8
$00000200 constant GPIOG_GPIOG_OTYPER_OT9                           \ OT9
$00000400 constant GPIOG_GPIOG_OTYPER_OT10                          \ OT10
$00000800 constant GPIOG_GPIOG_OTYPER_OT11                          \ OT11
$00001000 constant GPIOG_GPIOG_OTYPER_OT12                          \ OT12
$00002000 constant GPIOG_GPIOG_OTYPER_OT13                          \ OT13
$00004000 constant GPIOG_GPIOG_OTYPER_OT14                          \ OT14
$00008000 constant GPIOG_GPIOG_OTYPER_OT15                          \ OT15


\
\ @brief GPIO port output speed register
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$00000003 constant GPIOG_GPIOG_OSPEEDR_OSPEEDR0                     \ OSPEEDR0
$0000000c constant GPIOG_GPIOG_OSPEEDR_OSPEEDR1                     \ OSPEEDR1
$00000030 constant GPIOG_GPIOG_OSPEEDR_OSPEEDR2                     \ OSPEEDR2
$000000c0 constant GPIOG_GPIOG_OSPEEDR_OSPEEDR3                     \ OSPEEDR3
$00000300 constant GPIOG_GPIOG_OSPEEDR_OSPEEDR4                     \ OSPEEDR4
$00000c00 constant GPIOG_GPIOG_OSPEEDR_OSPEEDR5                     \ OSPEEDR5
$00003000 constant GPIOG_GPIOG_OSPEEDR_OSPEEDR6                     \ OSPEEDR6
$0000c000 constant GPIOG_GPIOG_OSPEEDR_OSPEEDR7                     \ OSPEEDR7
$00030000 constant GPIOG_GPIOG_OSPEEDR_OSPEEDR8                     \ OSPEEDR8
$000c0000 constant GPIOG_GPIOG_OSPEEDR_OSPEEDR9                     \ OSPEEDR9
$00300000 constant GPIOG_GPIOG_OSPEEDR_OSPEEDR10                    \ OSPEEDR10
$00c00000 constant GPIOG_GPIOG_OSPEEDR_OSPEEDR11                    \ OSPEEDR11
$03000000 constant GPIOG_GPIOG_OSPEEDR_OSPEEDR12                    \ OSPEEDR12
$0c000000 constant GPIOG_GPIOG_OSPEEDR_OSPEEDR13                    \ OSPEEDR13
$30000000 constant GPIOG_GPIOG_OSPEEDR_OSPEEDR14                    \ OSPEEDR14
$c0000000 constant GPIOG_GPIOG_OSPEEDR_OSPEEDR15                    \ OSPEEDR15


\
\ @brief GPIO port pull-up/pull-down register
\ Address offset: 0x0C
\ Reset value: 0x00000000
\

$00000003 constant GPIOG_GPIOG_PUPDR_PUPDR0                         \ PUPDR0
$0000000c constant GPIOG_GPIOG_PUPDR_PUPDR1                         \ PUPDR1
$00000030 constant GPIOG_GPIOG_PUPDR_PUPDR2                         \ PUPDR2
$000000c0 constant GPIOG_GPIOG_PUPDR_PUPDR3                         \ PUPDR3
$00000300 constant GPIOG_GPIOG_PUPDR_PUPDR4                         \ PUPDR4
$00000c00 constant GPIOG_GPIOG_PUPDR_PUPDR5                         \ PUPDR5
$00003000 constant GPIOG_GPIOG_PUPDR_PUPDR6                         \ PUPDR6
$0000c000 constant GPIOG_GPIOG_PUPDR_PUPDR7                         \ PUPDR7
$00030000 constant GPIOG_GPIOG_PUPDR_PUPDR8                         \ PUPDR8
$000c0000 constant GPIOG_GPIOG_PUPDR_PUPDR9                         \ PUPDR9
$00300000 constant GPIOG_GPIOG_PUPDR_PUPDR10                        \ PUPDR10
$00c00000 constant GPIOG_GPIOG_PUPDR_PUPDR11                        \ PUPDR11
$03000000 constant GPIOG_GPIOG_PUPDR_PUPDR12                        \ PUPDR12
$0c000000 constant GPIOG_GPIOG_PUPDR_PUPDR13                        \ PUPDR13
$30000000 constant GPIOG_GPIOG_PUPDR_PUPDR14                        \ PUPDR14
$c0000000 constant GPIOG_GPIOG_PUPDR_PUPDR15                        \ PUPDR15


\
\ @brief GPIO port input data register
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$00000001 constant GPIOG_GPIOG_IDR_IDR0                             \ IDR0
$00000002 constant GPIOG_GPIOG_IDR_IDR1                             \ IDR1
$00000004 constant GPIOG_GPIOG_IDR_IDR2                             \ IDR2
$00000008 constant GPIOG_GPIOG_IDR_IDR3                             \ IDR3
$00000010 constant GPIOG_GPIOG_IDR_IDR4                             \ IDR4
$00000020 constant GPIOG_GPIOG_IDR_IDR5                             \ IDR5
$00000040 constant GPIOG_GPIOG_IDR_IDR6                             \ IDR6
$00000080 constant GPIOG_GPIOG_IDR_IDR7                             \ IDR7
$00000100 constant GPIOG_GPIOG_IDR_IDR8                             \ IDR8
$00000200 constant GPIOG_GPIOG_IDR_IDR9                             \ IDR9
$00000400 constant GPIOG_GPIOG_IDR_IDR10                            \ IDR10
$00000800 constant GPIOG_GPIOG_IDR_IDR11                            \ IDR11
$00001000 constant GPIOG_GPIOG_IDR_IDR12                            \ IDR12
$00002000 constant GPIOG_GPIOG_IDR_IDR13                            \ IDR13
$00004000 constant GPIOG_GPIOG_IDR_IDR14                            \ IDR14
$00008000 constant GPIOG_GPIOG_IDR_IDR15                            \ IDR15


\
\ @brief GPIO port output data register
\ Address offset: 0x14
\ Reset value: 0x00000000
\

$00000001 constant GPIOG_GPIOG_ODR_ODR0                             \ ODR0
$00000002 constant GPIOG_GPIOG_ODR_ODR1                             \ ODR1
$00000004 constant GPIOG_GPIOG_ODR_ODR2                             \ ODR2
$00000008 constant GPIOG_GPIOG_ODR_ODR3                             \ ODR3
$00000010 constant GPIOG_GPIOG_ODR_ODR4                             \ ODR4
$00000020 constant GPIOG_GPIOG_ODR_ODR5                             \ ODR5
$00000040 constant GPIOG_GPIOG_ODR_ODR6                             \ ODR6
$00000080 constant GPIOG_GPIOG_ODR_ODR7                             \ ODR7
$00000100 constant GPIOG_GPIOG_ODR_ODR8                             \ ODR8
$00000200 constant GPIOG_GPIOG_ODR_ODR9                             \ ODR9
$00000400 constant GPIOG_GPIOG_ODR_ODR10                            \ ODR10
$00000800 constant GPIOG_GPIOG_ODR_ODR11                            \ ODR11
$00001000 constant GPIOG_GPIOG_ODR_ODR12                            \ ODR12
$00002000 constant GPIOG_GPIOG_ODR_ODR13                            \ ODR13
$00004000 constant GPIOG_GPIOG_ODR_ODR14                            \ ODR14
$00008000 constant GPIOG_GPIOG_ODR_ODR15                            \ ODR15


\
\ @brief GPIO port bit set/reset register
\ Address offset: 0x18
\ Reset value: 0x00000000
\

$00000001 constant GPIOG_GPIOG_BSRR_BS0                             \ BS0
$00000002 constant GPIOG_GPIOG_BSRR_BS1                             \ BS1
$00000004 constant GPIOG_GPIOG_BSRR_BS2                             \ BS2
$00000008 constant GPIOG_GPIOG_BSRR_BS3                             \ BS3
$00000010 constant GPIOG_GPIOG_BSRR_BS4                             \ BS4
$00000020 constant GPIOG_GPIOG_BSRR_BS5                             \ BS5
$00000040 constant GPIOG_GPIOG_BSRR_BS6                             \ BS6
$00000080 constant GPIOG_GPIOG_BSRR_BS7                             \ BS7
$00000100 constant GPIOG_GPIOG_BSRR_BS8                             \ BS8
$00000200 constant GPIOG_GPIOG_BSRR_BS9                             \ BS9
$00000400 constant GPIOG_GPIOG_BSRR_BS10                            \ BS10
$00000800 constant GPIOG_GPIOG_BSRR_BS11                            \ BS11
$00001000 constant GPIOG_GPIOG_BSRR_BS12                            \ BS12
$00002000 constant GPIOG_GPIOG_BSRR_BS13                            \ BS13
$00004000 constant GPIOG_GPIOG_BSRR_BS14                            \ BS14
$00008000 constant GPIOG_GPIOG_BSRR_BS15                            \ BS15
$00010000 constant GPIOG_GPIOG_BSRR_BR0                             \ BR0
$00020000 constant GPIOG_GPIOG_BSRR_BR1                             \ BR1
$00040000 constant GPIOG_GPIOG_BSRR_BR2                             \ BR2
$00080000 constant GPIOG_GPIOG_BSRR_BR3                             \ BR3
$00100000 constant GPIOG_GPIOG_BSRR_BR4                             \ BR4
$00200000 constant GPIOG_GPIOG_BSRR_BR5                             \ BR5
$00400000 constant GPIOG_GPIOG_BSRR_BR6                             \ BR6
$00800000 constant GPIOG_GPIOG_BSRR_BR7                             \ BR7
$01000000 constant GPIOG_GPIOG_BSRR_BR8                             \ BR8
$02000000 constant GPIOG_GPIOG_BSRR_BR9                             \ BR9
$04000000 constant GPIOG_GPIOG_BSRR_BR10                            \ BR10
$08000000 constant GPIOG_GPIOG_BSRR_BR11                            \ BR11
$10000000 constant GPIOG_GPIOG_BSRR_BR12                            \ BR12
$20000000 constant GPIOG_GPIOG_BSRR_BR13                            \ BR13
$40000000 constant GPIOG_GPIOG_BSRR_BR14                            \ BR14
$80000000 constant GPIOG_GPIOG_BSRR_BR15                            \ BR15


\
\ @brief This register is used to lock the configuration of the port bits when a correct write sequence is applied to bit 16 (LCKK). The value of bits [15:0] is used to lock the configuration of the GPIO. During the write sequence, the value of LCKR[15:0] must not change. When the LOCK sequence has been applied on a port bit, the value of this port bit can no longer be modified until the next MCU reset or peripheral reset. A specific write sequence is used to write to the GPIOx_LCKR register. Only word access (32-bit long) is allowed during this locking sequence. Each lock bit freezes a specific configuration register (control and alternate function registers).
\ Address offset: 0x1C
\ Reset value: 0x00000000
\

$00000001 constant GPIOG_GPIOG_LCKR_LCK0                            \ LCK0
$00000002 constant GPIOG_GPIOG_LCKR_LCK1                            \ LCK1
$00000004 constant GPIOG_GPIOG_LCKR_LCK2                            \ LCK2
$00000008 constant GPIOG_GPIOG_LCKR_LCK3                            \ LCK3
$00000010 constant GPIOG_GPIOG_LCKR_LCK4                            \ LCK4
$00000020 constant GPIOG_GPIOG_LCKR_LCK5                            \ LCK5
$00000040 constant GPIOG_GPIOG_LCKR_LCK6                            \ LCK6
$00000080 constant GPIOG_GPIOG_LCKR_LCK7                            \ LCK7
$00000100 constant GPIOG_GPIOG_LCKR_LCK8                            \ LCK8
$00000200 constant GPIOG_GPIOG_LCKR_LCK9                            \ LCK9
$00000400 constant GPIOG_GPIOG_LCKR_LCK10                           \ LCK10
$00000800 constant GPIOG_GPIOG_LCKR_LCK11                           \ LCK11
$00001000 constant GPIOG_GPIOG_LCKR_LCK12                           \ LCK12
$00002000 constant GPIOG_GPIOG_LCKR_LCK13                           \ LCK13
$00004000 constant GPIOG_GPIOG_LCKR_LCK14                           \ LCK14
$00008000 constant GPIOG_GPIOG_LCKR_LCK15                           \ LCK15
$00010000 constant GPIOG_GPIOG_LCKR_LCKK                            \ LCKK


\
\ @brief GPIO alternate function low register
\ Address offset: 0x20
\ Reset value: 0x00000000
\

$0000000f constant GPIOG_GPIOG_AFRL_AFR0                            \ AFR0
$000000f0 constant GPIOG_GPIOG_AFRL_AFR1                            \ AFR1
$00000f00 constant GPIOG_GPIOG_AFRL_AFR2                            \ AFR2
$0000f000 constant GPIOG_GPIOG_AFRL_AFR3                            \ AFR3
$000f0000 constant GPIOG_GPIOG_AFRL_AFR4                            \ AFR4
$00f00000 constant GPIOG_GPIOG_AFRL_AFR5                            \ AFR5
$0f000000 constant GPIOG_GPIOG_AFRL_AFR6                            \ AFR6
$f0000000 constant GPIOG_GPIOG_AFRL_AFR7                            \ AFR7


\
\ @brief GPIO alternate function high register
\ Address offset: 0x24
\ Reset value: 0x00000000
\

$0000000f constant GPIOG_GPIOG_AFRH_AFR8                            \ AFR8
$000000f0 constant GPIOG_GPIOG_AFRH_AFR9                            \ AFR9
$00000f00 constant GPIOG_GPIOG_AFRH_AFR10                           \ AFR10
$0000f000 constant GPIOG_GPIOG_AFRH_AFR11                           \ AFR11
$000f0000 constant GPIOG_GPIOG_AFRH_AFR12                           \ AFR12
$00f00000 constant GPIOG_GPIOG_AFRH_AFR13                           \ AFR13
$0f000000 constant GPIOG_GPIOG_AFRH_AFR14                           \ AFR14
$f0000000 constant GPIOG_GPIOG_AFRH_AFR15                           \ AFR15


\
\ @brief GPIO port bit reset register
\ Address offset: 0x28
\ Reset value: 0x00000000
\

$00000001 constant GPIOG_GPIOG_BRR_BR0                              \ BR0
$00000002 constant GPIOG_GPIOG_BRR_BR1                              \ BR1
$00000004 constant GPIOG_GPIOG_BRR_BR2                              \ BR2
$00000008 constant GPIOG_GPIOG_BRR_BR3                              \ BR3
$00000010 constant GPIOG_GPIOG_BRR_BR4                              \ BR4
$00000020 constant GPIOG_GPIOG_BRR_BR5                              \ BR5
$00000040 constant GPIOG_GPIOG_BRR_BR6                              \ BR6
$00000080 constant GPIOG_GPIOG_BRR_BR7                              \ BR7
$00000100 constant GPIOG_GPIOG_BRR_BR8                              \ BR8
$00000200 constant GPIOG_GPIOG_BRR_BR9                              \ BR9
$00000400 constant GPIOG_GPIOG_BRR_BR10                             \ BR10
$00000800 constant GPIOG_GPIOG_BRR_BR11                             \ BR11
$00001000 constant GPIOG_GPIOG_BRR_BR12                             \ BR12
$00002000 constant GPIOG_GPIOG_BRR_BR13                             \ BR13
$00004000 constant GPIOG_GPIOG_BRR_BR14                             \ BR14
$00008000 constant GPIOG_GPIOG_BRR_BR15                             \ BR15


\
\ @brief For GPIOA, B, C, D, E, F, G, H, I, J and GPIOK: For GPIOZ:
\ Address offset: 0x3C8
\ Reset value: 0x00011240
\

$0000000f constant GPIOG_GPIOG_HWCFGR10_AHB_IOP                     \ AHB_IOP
$000000f0 constant GPIOG_GPIOG_HWCFGR10_AF_SIZE                     \ AF_SIZE
$00000f00 constant GPIOG_GPIOG_HWCFGR10_SPEED_CFG                   \ SPEED_CFG
$0000f000 constant GPIOG_GPIOG_HWCFGR10_LOCK_CFG                    \ LOCK_CFG
$000f0000 constant GPIOG_GPIOG_HWCFGR10_SEC_CFG                     \ SEC_CFG
$00f00000 constant GPIOG_GPIOG_HWCFGR10_OR_CFG                      \ OR_CFG


\
\ @brief For GPIOA, B, C, D, E, F, G, H, I, and GPIOJ: For GPIOK and GPIOZ:
\ Address offset: 0x3CC
\ Reset value: 0x000000FF
\

$0000ffff constant GPIOG_GPIOG_HWCFGR9_EN_IO                        \ EN_IO


\
\ @brief For GPIOA, B, C, D, E, F, G, H, I, and GPIOJ: For GPIOK and GPIOZ:
\ Address offset: 0x3D0
\ Reset value: 0x00000000
\

$0000000f constant GPIOG_GPIOG_HWCFGR8_AF_PRIO8                     \ AF_PRIO8
$000000f0 constant GPIOG_GPIOG_HWCFGR8_AF_PRIO9                     \ AF_PRIO9
$00000f00 constant GPIOG_GPIOG_HWCFGR8_AF_PRIO10                    \ AF_PRIO10
$0000f000 constant GPIOG_GPIOG_HWCFGR8_AF_PRIO11                    \ AF_PRIO11
$000f0000 constant GPIOG_GPIOG_HWCFGR8_AF_PRIO12                    \ AF_PRIO12
$00f00000 constant GPIOG_GPIOG_HWCFGR8_AF_PRIO13                    \ AF_PRIO13
$0f000000 constant GPIOG_GPIOG_HWCFGR8_AF_PRIO14                    \ AF_PRIO14
$f0000000 constant GPIOG_GPIOG_HWCFGR8_AF_PRIO15                    \ AF_PRIO15


\
\ @brief GPIO hardware configuration register 7
\ Address offset: 0x3D4
\ Reset value: 0xFFFFFFFF
\

$0000000f constant GPIOG_GPIOG_HWCFGR7_AF_PRIO0                     \ AF_PRIO0
$000000f0 constant GPIOG_GPIOG_HWCFGR7_AF_PRIO1                     \ AF_PRIO1
$00000f00 constant GPIOG_GPIOG_HWCFGR7_AF_PRIO2                     \ AF_PRIO2
$0000f000 constant GPIOG_GPIOG_HWCFGR7_AF_PRIO3                     \ AF_PRIO3
$000f0000 constant GPIOG_GPIOG_HWCFGR7_AF_PRIO4                     \ AF_PRIO4
$00f00000 constant GPIOG_GPIOG_HWCFGR7_AF_PRIO5                     \ AF_PRIO5
$0f000000 constant GPIOG_GPIOG_HWCFGR7_AF_PRIO6                     \ AF_PRIO6
$f0000000 constant GPIOG_GPIOG_HWCFGR7_AF_PRIO7                     \ AF_PRIO7


\
\ @brief GPIO hardware configuration register 6
\ Address offset: 0x3D8
\ Reset value: 0xFFFFFFFF
\

$00000000 constant GPIOG_GPIOG_HWCFGR6_MODER_RES                    \ MODER_RES


\
\ @brief GPIO hardware configuration register 5
\ Address offset: 0x3DC
\ Reset value: 0x00000000
\

$00000000 constant GPIOG_GPIOG_HWCFGR5_PUPDR_RES                    \ PUPDR_RES


\
\ @brief GPIO hardware configuration register 4
\ Address offset: 0x3E0
\ Reset value: 0x00000000
\

$00000000 constant GPIOG_GPIOG_HWCFGR4_OSPEED_RES                   \ OSPEED_RES


\
\ @brief GPIO hardware configuration register 3
\ Address offset: 0x3E4
\ Reset value: 0x00000000
\

$0000ffff constant GPIOG_GPIOG_HWCFGR3_ODR_RES                      \ ODR_RES
$ffff0000 constant GPIOG_GPIOG_HWCFGR3_OTYPER_RES                   \ OTYPER_RES


\
\ @brief GPIO hardware configuration register 2
\ Address offset: 0x3E8
\ Reset value: 0x00000000
\

$00000000 constant GPIOG_GPIOG_HWCFGR2_AFRL_RES                     \ AFRL_RES


\
\ @brief GPIO hardware configuration register 1
\ Address offset: 0x3EC
\ Reset value: 0x00000000
\

$00000000 constant GPIOG_GPIOG_HWCFGR1_AFRH_RES                     \ AFRH_RES


\
\ @brief GPIO hardware configuration register 0
\ Address offset: 0x3F0
\ Reset value: 0x00000000
\

$0000ffff constant GPIOG_GPIOG_HWCFGR0_OR_RES                       \ OR_RES


\
\ @brief GPIO version register
\ Address offset: 0x3F4
\ Reset value: 0x00000040
\

$0000000f constant GPIOG_GPIOG_VERR_MINREV                          \ MINREV
$000000f0 constant GPIOG_GPIOG_VERR_MAJREV                          \ MAJREV


\
\ @brief GPIO identification register
\ Address offset: 0x3F8
\ Reset value: 0x000F0002
\

$00000000 constant GPIOG_GPIOG_IPIDR_IPIDR                          \ IPIDR


\
\ @brief GPIO size identification register
\ Address offset: 0x3FC
\ Reset value: 0xA3C5DD01
\

$00000000 constant GPIOG_GPIOG_SIDR_SIDR                            \ SIDR


\
\ @brief GPIOG
\
$50008000 constant GPIOG_GPIOG_MODER  \ offset: 0x00 : GPIO port mode register
$50008004 constant GPIOG_GPIOG_OTYPER  \ offset: 0x04 : GPIO port output type register
$50008008 constant GPIOG_GPIOG_OSPEEDR  \ offset: 0x08 : GPIO port output speed register
$5000800c constant GPIOG_GPIOG_PUPDR  \ offset: 0x0C : GPIO port pull-up/pull-down register
$50008010 constant GPIOG_GPIOG_IDR  \ offset: 0x10 : GPIO port input data register
$50008014 constant GPIOG_GPIOG_ODR  \ offset: 0x14 : GPIO port output data register
$50008018 constant GPIOG_GPIOG_BSRR  \ offset: 0x18 : GPIO port bit set/reset register
$5000801c constant GPIOG_GPIOG_LCKR  \ offset: 0x1C : This register is used to lock the configuration of the port bits when a correct write sequence is applied to bit 16 (LCKK). The value of bits [15:0] is used to lock the configuration of the GPIO. During the write sequence, the value of LCKR[15:0] must not change. When the LOCK sequence has been applied on a port bit, the value of this port bit can no longer be modified until the next MCU reset or peripheral reset. A specific write sequence is used to write to the GPIOx_LCKR register. Only word access (32-bit long) is allowed during this locking sequence. Each lock bit freezes a specific configuration register (control and alternate function registers).
$50008020 constant GPIOG_GPIOG_AFRL  \ offset: 0x20 : GPIO alternate function low register
$50008024 constant GPIOG_GPIOG_AFRH  \ offset: 0x24 : GPIO alternate function high register
$50008028 constant GPIOG_GPIOG_BRR  \ offset: 0x28 : GPIO port bit reset register
$500083c8 constant GPIOG_GPIOG_HWCFGR10  \ offset: 0x3C8 : For GPIOA, B, C, D, E, F, G, H, I, J and GPIOK: For GPIOZ:
$500083cc constant GPIOG_GPIOG_HWCFGR9  \ offset: 0x3CC : For GPIOA, B, C, D, E, F, G, H, I, and GPIOJ: For GPIOK and GPIOZ:
$500083d0 constant GPIOG_GPIOG_HWCFGR8  \ offset: 0x3D0 : For GPIOA, B, C, D, E, F, G, H, I, and GPIOJ: For GPIOK and GPIOZ:
$500083d4 constant GPIOG_GPIOG_HWCFGR7  \ offset: 0x3D4 : GPIO hardware configuration register 7
$500083d8 constant GPIOG_GPIOG_HWCFGR6  \ offset: 0x3D8 : GPIO hardware configuration register 6
$500083dc constant GPIOG_GPIOG_HWCFGR5  \ offset: 0x3DC : GPIO hardware configuration register 5
$500083e0 constant GPIOG_GPIOG_HWCFGR4  \ offset: 0x3E0 : GPIO hardware configuration register 4
$500083e4 constant GPIOG_GPIOG_HWCFGR3  \ offset: 0x3E4 : GPIO hardware configuration register 3
$500083e8 constant GPIOG_GPIOG_HWCFGR2  \ offset: 0x3E8 : GPIO hardware configuration register 2
$500083ec constant GPIOG_GPIOG_HWCFGR1  \ offset: 0x3EC : GPIO hardware configuration register 1
$500083f0 constant GPIOG_GPIOG_HWCFGR0  \ offset: 0x3F0 : GPIO hardware configuration register 0
$500083f4 constant GPIOG_GPIOG_VERR  \ offset: 0x3F4 : GPIO version register
$500083f8 constant GPIOG_GPIOG_IPIDR  \ offset: 0x3F8 : GPIO identification register
$500083fc constant GPIOG_GPIOG_SIDR  \ offset: 0x3FC : GPIO size identification register

