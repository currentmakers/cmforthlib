\
\ @file sec_gpioa.fs
\ @brief General-purpose I/Os
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

$00000003 constant SEC_GPIOA_MODER_MODER0                           \ Port x configuration bits (y = 0..15)
$0000000c constant SEC_GPIOA_MODER_MODER1                           \ Port x configuration bits (y = 0..15)
$00000030 constant SEC_GPIOA_MODER_MODER2                           \ Port x configuration bits (y = 0..15)
$000000c0 constant SEC_GPIOA_MODER_MODER3                           \ Port x configuration bits (y = 0..15)
$00000300 constant SEC_GPIOA_MODER_MODER4                           \ Port x configuration bits (y = 0..15)
$00000c00 constant SEC_GPIOA_MODER_MODER5                           \ Port x configuration bits (y = 0..15)
$00003000 constant SEC_GPIOA_MODER_MODER6                           \ Port x configuration bits (y = 0..15)
$0000c000 constant SEC_GPIOA_MODER_MODER7                           \ Port x configuration bits (y = 0..15)
$00030000 constant SEC_GPIOA_MODER_MODER8                           \ Port x configuration bits (y = 0..15)
$000c0000 constant SEC_GPIOA_MODER_MODER9                           \ Port x configuration bits (y = 0..15)
$00300000 constant SEC_GPIOA_MODER_MODER10                          \ Port x configuration bits (y = 0..15)
$00c00000 constant SEC_GPIOA_MODER_MODER11                          \ Port x configuration bits (y = 0..15)
$03000000 constant SEC_GPIOA_MODER_MODER12                          \ Port x configuration bits (y = 0..15)
$0c000000 constant SEC_GPIOA_MODER_MODER13                          \ Port x configuration bits (y = 0..15)
$30000000 constant SEC_GPIOA_MODER_MODER14                          \ Port x configuration bits (y = 0..15)
$c0000000 constant SEC_GPIOA_MODER_MODER15                          \ Port x configuration bits (y = 0..15)


\
\ @brief GPIO port output type register
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$00000001 constant SEC_GPIOA_OTYPER_OT0                             \ Port x configuration bits (y = 0..15)
$00000002 constant SEC_GPIOA_OTYPER_OT1                             \ Port x configuration bits (y = 0..15)
$00000004 constant SEC_GPIOA_OTYPER_OT2                             \ Port x configuration bits (y = 0..15)
$00000008 constant SEC_GPIOA_OTYPER_OT3                             \ Port x configuration bits (y = 0..15)
$00000010 constant SEC_GPIOA_OTYPER_OT4                             \ Port x configuration bits (y = 0..15)
$00000020 constant SEC_GPIOA_OTYPER_OT5                             \ Port x configuration bits (y = 0..15)
$00000040 constant SEC_GPIOA_OTYPER_OT6                             \ Port x configuration bits (y = 0..15)
$00000080 constant SEC_GPIOA_OTYPER_OT7                             \ Port x configuration bits (y = 0..15)
$00000100 constant SEC_GPIOA_OTYPER_OT8                             \ Port x configuration bits (y = 0..15)
$00000200 constant SEC_GPIOA_OTYPER_OT9                             \ Port x configuration bits (y = 0..15)
$00000400 constant SEC_GPIOA_OTYPER_OT10                            \ Port x configuration bits (y = 0..15)
$00000800 constant SEC_GPIOA_OTYPER_OT11                            \ Port x configuration bits (y = 0..15)
$00001000 constant SEC_GPIOA_OTYPER_OT12                            \ Port x configuration bits (y = 0..15)
$00002000 constant SEC_GPIOA_OTYPER_OT13                            \ Port x configuration bits (y = 0..15)
$00004000 constant SEC_GPIOA_OTYPER_OT14                            \ Port x configuration bits (y = 0..15)
$00008000 constant SEC_GPIOA_OTYPER_OT15                            \ Port x configuration bits (y = 0..15)


\
\ @brief GPIO port output speed register
\ Address offset: 0x08
\ Reset value: 0x0C000000
\

$00000003 constant SEC_GPIOA_OSPEEDR_OSPEEDR0                       \ Port x configuration bits (y = 0..15)
$0000000c constant SEC_GPIOA_OSPEEDR_OSPEEDR1                       \ Port x configuration bits (y = 0..15)
$00000030 constant SEC_GPIOA_OSPEEDR_OSPEEDR2                       \ Port x configuration bits (y = 0..15)
$000000c0 constant SEC_GPIOA_OSPEEDR_OSPEEDR3                       \ Port x configuration bits (y = 0..15)
$00000300 constant SEC_GPIOA_OSPEEDR_OSPEEDR4                       \ Port x configuration bits (y = 0..15)
$00000c00 constant SEC_GPIOA_OSPEEDR_OSPEEDR5                       \ Port x configuration bits (y = 0..15)
$00003000 constant SEC_GPIOA_OSPEEDR_OSPEEDR6                       \ Port x configuration bits (y = 0..15)
$0000c000 constant SEC_GPIOA_OSPEEDR_OSPEEDR7                       \ Port x configuration bits (y = 0..15)
$00030000 constant SEC_GPIOA_OSPEEDR_OSPEEDR8                       \ Port x configuration bits (y = 0..15)
$000c0000 constant SEC_GPIOA_OSPEEDR_OSPEEDR9                       \ Port x configuration bits (y = 0..15)
$00300000 constant SEC_GPIOA_OSPEEDR_OSPEEDR10                      \ Port x configuration bits (y = 0..15)
$00c00000 constant SEC_GPIOA_OSPEEDR_OSPEEDR11                      \ Port x configuration bits (y = 0..15)
$03000000 constant SEC_GPIOA_OSPEEDR_OSPEEDR12                      \ Port x configuration bits (y = 0..15)
$0c000000 constant SEC_GPIOA_OSPEEDR_OSPEEDR13                      \ Port x configuration bits (y = 0..15)
$30000000 constant SEC_GPIOA_OSPEEDR_OSPEEDR14                      \ Port x configuration bits (y = 0..15)
$c0000000 constant SEC_GPIOA_OSPEEDR_OSPEEDR15                      \ Port x configuration bits (y = 0..15)


\
\ @brief GPIO port pull-up/pull-down register
\ Address offset: 0x0C
\ Reset value: 0x64000000
\

$00000003 constant SEC_GPIOA_PUPDR_PUPDR0                           \ Port x configuration bits (y = 0..15)
$0000000c constant SEC_GPIOA_PUPDR_PUPDR1                           \ Port x configuration bits (y = 0..15)
$00000030 constant SEC_GPIOA_PUPDR_PUPDR2                           \ Port x configuration bits (y = 0..15)
$000000c0 constant SEC_GPIOA_PUPDR_PUPDR3                           \ Port x configuration bits (y = 0..15)
$00000300 constant SEC_GPIOA_PUPDR_PUPDR4                           \ Port x configuration bits (y = 0..15)
$00000c00 constant SEC_GPIOA_PUPDR_PUPDR5                           \ Port x configuration bits (y = 0..15)
$00003000 constant SEC_GPIOA_PUPDR_PUPDR6                           \ Port x configuration bits (y = 0..15)
$0000c000 constant SEC_GPIOA_PUPDR_PUPDR7                           \ Port x configuration bits (y = 0..15)
$00030000 constant SEC_GPIOA_PUPDR_PUPDR8                           \ Port x configuration bits (y = 0..15)
$000c0000 constant SEC_GPIOA_PUPDR_PUPDR9                           \ Port x configuration bits (y = 0..15)
$00300000 constant SEC_GPIOA_PUPDR_PUPDR10                          \ Port x configuration bits (y = 0..15)
$00c00000 constant SEC_GPIOA_PUPDR_PUPDR11                          \ Port x configuration bits (y = 0..15)
$03000000 constant SEC_GPIOA_PUPDR_PUPDR12                          \ Port x configuration bits (y = 0..15)
$0c000000 constant SEC_GPIOA_PUPDR_PUPDR13                          \ Port x configuration bits (y = 0..15)
$30000000 constant SEC_GPIOA_PUPDR_PUPDR14                          \ Port x configuration bits (y = 0..15)
$c0000000 constant SEC_GPIOA_PUPDR_PUPDR15                          \ Port x configuration bits (y = 0..15)


\
\ @brief GPIO port input data register
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$00000001 constant SEC_GPIOA_IDR_IDR0                               \ Port input data (y = 0..15)
$00000002 constant SEC_GPIOA_IDR_IDR1                               \ Port input data (y = 0..15)
$00000004 constant SEC_GPIOA_IDR_IDR2                               \ Port input data (y = 0..15)
$00000008 constant SEC_GPIOA_IDR_IDR3                               \ Port input data (y = 0..15)
$00000010 constant SEC_GPIOA_IDR_IDR4                               \ Port input data (y = 0..15)
$00000020 constant SEC_GPIOA_IDR_IDR5                               \ Port input data (y = 0..15)
$00000040 constant SEC_GPIOA_IDR_IDR6                               \ Port input data (y = 0..15)
$00000080 constant SEC_GPIOA_IDR_IDR7                               \ Port input data (y = 0..15)
$00000100 constant SEC_GPIOA_IDR_IDR8                               \ Port input data (y = 0..15)
$00000200 constant SEC_GPIOA_IDR_IDR9                               \ Port input data (y = 0..15)
$00000400 constant SEC_GPIOA_IDR_IDR10                              \ Port input data (y = 0..15)
$00000800 constant SEC_GPIOA_IDR_IDR11                              \ Port input data (y = 0..15)
$00001000 constant SEC_GPIOA_IDR_IDR12                              \ Port input data (y = 0..15)
$00002000 constant SEC_GPIOA_IDR_IDR13                              \ Port input data (y = 0..15)
$00004000 constant SEC_GPIOA_IDR_IDR14                              \ Port input data (y = 0..15)
$00008000 constant SEC_GPIOA_IDR_IDR15                              \ Port input data (y = 0..15)


\
\ @brief GPIO port output data register
\ Address offset: 0x14
\ Reset value: 0x00000000
\

$00000001 constant SEC_GPIOA_ODR_ODR0                               \ Port output data (y = 0..15)
$00000002 constant SEC_GPIOA_ODR_ODR1                               \ Port output data (y = 0..15)
$00000004 constant SEC_GPIOA_ODR_ODR2                               \ Port output data (y = 0..15)
$00000008 constant SEC_GPIOA_ODR_ODR3                               \ Port output data (y = 0..15)
$00000010 constant SEC_GPIOA_ODR_ODR4                               \ Port output data (y = 0..15)
$00000020 constant SEC_GPIOA_ODR_ODR5                               \ Port output data (y = 0..15)
$00000040 constant SEC_GPIOA_ODR_ODR6                               \ Port output data (y = 0..15)
$00000080 constant SEC_GPIOA_ODR_ODR7                               \ Port output data (y = 0..15)
$00000100 constant SEC_GPIOA_ODR_ODR8                               \ Port output data (y = 0..15)
$00000200 constant SEC_GPIOA_ODR_ODR9                               \ Port output data (y = 0..15)
$00000400 constant SEC_GPIOA_ODR_ODR10                              \ Port output data (y = 0..15)
$00000800 constant SEC_GPIOA_ODR_ODR11                              \ Port output data (y = 0..15)
$00001000 constant SEC_GPIOA_ODR_ODR12                              \ Port output data (y = 0..15)
$00002000 constant SEC_GPIOA_ODR_ODR13                              \ Port output data (y = 0..15)
$00004000 constant SEC_GPIOA_ODR_ODR14                              \ Port output data (y = 0..15)
$00008000 constant SEC_GPIOA_ODR_ODR15                              \ Port output data (y = 0..15)


\
\ @brief GPIO port bit set/reset register
\ Address offset: 0x18
\ Reset value: 0x00000000
\

$00000001 constant SEC_GPIOA_BSRR_BS0                               \ Port x set bit y (y= 0..15)
$00000002 constant SEC_GPIOA_BSRR_BS1                               \ Port x set bit y (y= 0..15)
$00000004 constant SEC_GPIOA_BSRR_BS2                               \ Port x set bit y (y= 0..15)
$00000008 constant SEC_GPIOA_BSRR_BS3                               \ Port x set bit y (y= 0..15)
$00000010 constant SEC_GPIOA_BSRR_BS4                               \ Port x set bit y (y= 0..15)
$00000020 constant SEC_GPIOA_BSRR_BS5                               \ Port x set bit y (y= 0..15)
$00000040 constant SEC_GPIOA_BSRR_BS6                               \ Port x set bit y (y= 0..15)
$00000080 constant SEC_GPIOA_BSRR_BS7                               \ Port x set bit y (y= 0..15)
$00000100 constant SEC_GPIOA_BSRR_BS8                               \ Port x set bit y (y= 0..15)
$00000200 constant SEC_GPIOA_BSRR_BS9                               \ Port x set bit y (y= 0..15)
$00000400 constant SEC_GPIOA_BSRR_BS10                              \ Port x set bit y (y= 0..15)
$00000800 constant SEC_GPIOA_BSRR_BS11                              \ Port x set bit y (y= 0..15)
$00001000 constant SEC_GPIOA_BSRR_BS12                              \ Port x set bit y (y= 0..15)
$00002000 constant SEC_GPIOA_BSRR_BS13                              \ Port x set bit y (y= 0..15)
$00004000 constant SEC_GPIOA_BSRR_BS14                              \ Port x set bit y (y= 0..15)
$00008000 constant SEC_GPIOA_BSRR_BS15                              \ Port x set bit y (y= 0..15)
$00010000 constant SEC_GPIOA_BSRR_BR0                               \ Port x set bit y (y= 0..15)
$00020000 constant SEC_GPIOA_BSRR_BR1                               \ Port x reset bit y (y = 0..15)
$00040000 constant SEC_GPIOA_BSRR_BR2                               \ Port x reset bit y (y = 0..15)
$00080000 constant SEC_GPIOA_BSRR_BR3                               \ Port x reset bit y (y = 0..15)
$00100000 constant SEC_GPIOA_BSRR_BR4                               \ Port x reset bit y (y = 0..15)
$00200000 constant SEC_GPIOA_BSRR_BR5                               \ Port x reset bit y (y = 0..15)
$00400000 constant SEC_GPIOA_BSRR_BR6                               \ Port x reset bit y (y = 0..15)
$00800000 constant SEC_GPIOA_BSRR_BR7                               \ Port x reset bit y (y = 0..15)
$01000000 constant SEC_GPIOA_BSRR_BR8                               \ Port x reset bit y (y = 0..15)
$02000000 constant SEC_GPIOA_BSRR_BR9                               \ Port x reset bit y (y = 0..15)
$04000000 constant SEC_GPIOA_BSRR_BR10                              \ Port x reset bit y (y = 0..15)
$08000000 constant SEC_GPIOA_BSRR_BR11                              \ Port x reset bit y (y = 0..15)
$10000000 constant SEC_GPIOA_BSRR_BR12                              \ Port x reset bit y (y = 0..15)
$20000000 constant SEC_GPIOA_BSRR_BR13                              \ Port x reset bit y (y = 0..15)
$40000000 constant SEC_GPIOA_BSRR_BR14                              \ Port x reset bit y (y = 0..15)
$80000000 constant SEC_GPIOA_BSRR_BR15                              \ Port x reset bit y (y = 0..15)


\
\ @brief GPIO port configuration lock register
\ Address offset: 0x1C
\ Reset value: 0x00000000
\

$00000001 constant SEC_GPIOA_LCKR_LCK0                              \ Port x lock bit y (y= 0..15)
$00000002 constant SEC_GPIOA_LCKR_LCK1                              \ Port x lock bit y (y= 0..15)
$00000004 constant SEC_GPIOA_LCKR_LCK2                              \ Port x lock bit y (y= 0..15)
$00000008 constant SEC_GPIOA_LCKR_LCK3                              \ Port x lock bit y (y= 0..15)
$00000010 constant SEC_GPIOA_LCKR_LCK4                              \ Port x lock bit y (y= 0..15)
$00000020 constant SEC_GPIOA_LCKR_LCK5                              \ Port x lock bit y (y= 0..15)
$00000040 constant SEC_GPIOA_LCKR_LCK6                              \ Port x lock bit y (y= 0..15)
$00000080 constant SEC_GPIOA_LCKR_LCK7                              \ Port x lock bit y (y= 0..15)
$00000100 constant SEC_GPIOA_LCKR_LCK8                              \ Port x lock bit y (y= 0..15)
$00000200 constant SEC_GPIOA_LCKR_LCK9                              \ Port x lock bit y (y= 0..15)
$00000400 constant SEC_GPIOA_LCKR_LCK10                             \ Port x lock bit y (y= 0..15)
$00000800 constant SEC_GPIOA_LCKR_LCK11                             \ Port x lock bit y (y= 0..15)
$00001000 constant SEC_GPIOA_LCKR_LCK12                             \ Port x lock bit y (y= 0..15)
$00002000 constant SEC_GPIOA_LCKR_LCK13                             \ Port x lock bit y (y= 0..15)
$00004000 constant SEC_GPIOA_LCKR_LCK14                             \ Port x lock bit y (y= 0..15)
$00008000 constant SEC_GPIOA_LCKR_LCK15                             \ Port x lock bit y (y= 0..15)
$00010000 constant SEC_GPIOA_LCKR_LCKK                              \ Port x lock bit y (y= 0..15)


\
\ @brief GPIO alternate function low register
\ Address offset: 0x20
\ Reset value: 0x00000000
\

$0000000f constant SEC_GPIOA_AFRL_AFSEL0                            \ Alternate function selection for port x bit y (y = 0..7)
$000000f0 constant SEC_GPIOA_AFRL_AFSEL1                            \ Alternate function selection for port x bit y (y = 0..7)
$00000f00 constant SEC_GPIOA_AFRL_AFSEL2                            \ Alternate function selection for port x bit y (y = 0..7)
$0000f000 constant SEC_GPIOA_AFRL_AFSEL3                            \ Alternate function selection for port x bit y (y = 0..7)
$000f0000 constant SEC_GPIOA_AFRL_AFSEL4                            \ Alternate function selection for port x bit y (y = 0..7)
$00f00000 constant SEC_GPIOA_AFRL_AFSEL5                            \ Alternate function selection for port x bit y (y = 0..7)
$0f000000 constant SEC_GPIOA_AFRL_AFSEL6                            \ Alternate function selection for port x bit y (y = 0..7)
$f0000000 constant SEC_GPIOA_AFRL_AFSEL7                            \ Alternate function selection for port x bit y (y = 0..7)


\
\ @brief GPIO alternate function high register
\ Address offset: 0x24
\ Reset value: 0x00000000
\

$0000000f constant SEC_GPIOA_AFRH_AFSEL8                            \ Alternate function selection for port x bit y (y = 8..15)
$000000f0 constant SEC_GPIOA_AFRH_AFSEL9                            \ Alternate function selection for port x bit y (y = 8..15)
$00000f00 constant SEC_GPIOA_AFRH_AFSEL10                           \ Alternate function selection for port x bit y (y = 8..15)
$0000f000 constant SEC_GPIOA_AFRH_AFSEL11                           \ Alternate function selection for port x bit y (y = 8..15)
$000f0000 constant SEC_GPIOA_AFRH_AFSEL12                           \ Alternate function selection for port x bit y (y = 8..15)
$00f00000 constant SEC_GPIOA_AFRH_AFSEL13                           \ Alternate function selection for port x bit y (y = 8..15)
$0f000000 constant SEC_GPIOA_AFRH_AFSEL14                           \ Alternate function selection for port x bit y (y = 8..15)
$f0000000 constant SEC_GPIOA_AFRH_AFSEL15                           \ Alternate function selection for port x bit y (y = 8..15)


\
\ @brief GPIO port bit reset register
\ Address offset: 0x28
\ Reset value: 0x00000000
\

$00000001 constant SEC_GPIOA_BRR_BR0                                \ Port x reset IO pin y
$00000002 constant SEC_GPIOA_BRR_BR1                                \ Port x reset IO pin y
$00000004 constant SEC_GPIOA_BRR_BR2                                \ Port x reset IO pin y
$00000008 constant SEC_GPIOA_BRR_BR3                                \ Port x reset IO pin y
$00000010 constant SEC_GPIOA_BRR_BR4                                \ Port x reset IO pin y
$00000020 constant SEC_GPIOA_BRR_BR5                                \ Port x reset IO pin y
$00000040 constant SEC_GPIOA_BRR_BR6                                \ Port x reset IO pin y
$00000080 constant SEC_GPIOA_BRR_BR7                                \ Port x reset IO pin y
$00000100 constant SEC_GPIOA_BRR_BR8                                \ Port x reset IO pin y
$00000200 constant SEC_GPIOA_BRR_BR9                                \ Port x reset IO pin y
$00000400 constant SEC_GPIOA_BRR_BR10                               \ Port x reset IO pin y
$00000800 constant SEC_GPIOA_BRR_BR11                               \ Port x reset IO pin y
$00001000 constant SEC_GPIOA_BRR_BR12                               \ Port x reset IO pin y
$00002000 constant SEC_GPIOA_BRR_BR13                               \ Port x reset IO pin y
$00004000 constant SEC_GPIOA_BRR_BR14                               \ Port x reset IO pin y
$00008000 constant SEC_GPIOA_BRR_BR15                               \ Port x reset IO pin y


\
\ @brief GPIO secure configuration register
\ Address offset: 0x30
\ Reset value: 0x00000000
\

$00000001 constant SEC_GPIOA_SECCFGR_SEC0                           \ I/O pin of Port x secure bit enable
$00000002 constant SEC_GPIOA_SECCFGR_SEC1                           \ I/O pin of Port x secure bit enable
$00000004 constant SEC_GPIOA_SECCFGR_SEC2                           \ I/O pin of Port x secure bit enable
$00000008 constant SEC_GPIOA_SECCFGR_SEC3                           \ I/O pin of Port x secure bit enable
$00000010 constant SEC_GPIOA_SECCFGR_SEC4                           \ I/O pin of Port x secure bit enable
$00000020 constant SEC_GPIOA_SECCFGR_SEC5                           \ I/O pin of Port x secure bit enable
$00000040 constant SEC_GPIOA_SECCFGR_SEC6                           \ I/O pin of Port x secure bit enable
$00000080 constant SEC_GPIOA_SECCFGR_SEC7                           \ I/O pin of Port x secure bit enable
$00000100 constant SEC_GPIOA_SECCFGR_SEC8                           \ I/O pin of Port x secure bit enable
$00000200 constant SEC_GPIOA_SECCFGR_SEC9                           \ I/O pin of Port x secure bit enable
$00000400 constant SEC_GPIOA_SECCFGR_SEC10                          \ I/O pin of Port x secure bit enable
$00000800 constant SEC_GPIOA_SECCFGR_SEC11                          \ I/O pin of Port x secure bit enable
$00001000 constant SEC_GPIOA_SECCFGR_SEC12                          \ I/O pin of Port x secure bit enable
$00002000 constant SEC_GPIOA_SECCFGR_SEC13                          \ I/O pin of Port x secure bit enable
$00004000 constant SEC_GPIOA_SECCFGR_SEC14                          \ I/O pin of Port x secure bit enable
$00008000 constant SEC_GPIOA_SECCFGR_SEC15                          \ I/O pin of Port x secure bit enable


\
\ @brief General-purpose I/Os
\
$52020000 constant SEC_GPIOA_MODER  \ offset: 0x00 : GPIO port mode register
$52020004 constant SEC_GPIOA_OTYPER  \ offset: 0x04 : GPIO port output type register
$52020008 constant SEC_GPIOA_OSPEEDR  \ offset: 0x08 : GPIO port output speed register
$5202000c constant SEC_GPIOA_PUPDR  \ offset: 0x0C : GPIO port pull-up/pull-down register
$52020010 constant SEC_GPIOA_IDR  \ offset: 0x10 : GPIO port input data register
$52020014 constant SEC_GPIOA_ODR  \ offset: 0x14 : GPIO port output data register
$52020018 constant SEC_GPIOA_BSRR  \ offset: 0x18 : GPIO port bit set/reset register
$5202001c constant SEC_GPIOA_LCKR  \ offset: 0x1C : GPIO port configuration lock register
$52020020 constant SEC_GPIOA_AFRL  \ offset: 0x20 : GPIO alternate function low register
$52020024 constant SEC_GPIOA_AFRH  \ offset: 0x24 : GPIO alternate function high register
$52020028 constant SEC_GPIOA_BRR  \ offset: 0x28 : GPIO port bit reset register
$52020030 constant SEC_GPIOA_SECCFGR  \ offset: 0x30 : GPIO secure configuration register

