\
\ @file gpioe.fs
\ @brief General-purpose I/Os
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief GPIO port mode register
\ Address offset: 0x00
\ Reset value: 0x000003FF
\

$00000003 constant GPIOE_MODER_MODER0                               \ Port x configuration bits (y = 0..15)
$0000000c constant GPIOE_MODER_MODER1                               \ Port x configuration bits (y = 0..15)
$00000030 constant GPIOE_MODER_MODER2                               \ Port x configuration bits (y = 0..15)
$000000c0 constant GPIOE_MODER_MODER3                               \ Port x configuration bits (y = 0..15)
$00000300 constant GPIOE_MODER_MODER4                               \ Port x configuration bits (y = 0..15)


\
\ @brief GPIO port output type register
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$00000001 constant GPIOE_OTYPER_OT0                                 \ Port x configuration bits (y = 0..15)
$00000002 constant GPIOE_OTYPER_OT1                                 \ Port x configuration bits (y = 0..15)
$00000004 constant GPIOE_OTYPER_OT2                                 \ Port x configuration bits (y = 0..15)
$00000008 constant GPIOE_OTYPER_OT3                                 \ Port x configuration bits (y = 0..15)
$00000010 constant GPIOE_OTYPER_OT4                                 \ Port x configuration bits (y = 0..15)


\
\ @brief GPIO port output speed register
\ Address offset: 0x08
\ Reset value: 0x000000C0
\

$00000003 constant GPIOE_OSPEEDR_OSPEEDR0                           \ Port x configuration bits (y = 0..15)
$0000000c constant GPIOE_OSPEEDR_OSPEEDR1                           \ Port x configuration bits (y = 0..15)
$00000030 constant GPIOE_OSPEEDR_OSPEEDR2                           \ Port x configuration bits (y = 0..15)
$000000c0 constant GPIOE_OSPEEDR_OSPEEDR3                           \ Port x configuration bits (y = 0..15)
$00000300 constant GPIOE_OSPEEDR_OSPEEDR4                           \ Port x configuration bits (y = 0..15)


\
\ @brief GPIO port pull-up/pull-down register
\ Address offset: 0x0C
\ Reset value: 0x00000000
\

$00000003 constant GPIOE_PUPDR_PUPDR0                               \ Port x configuration bits (y = 0..15)
$0000000c constant GPIOE_PUPDR_PUPDR1                               \ Port x configuration bits (y = 0..15)
$00000030 constant GPIOE_PUPDR_PUPDR2                               \ Port x configuration bits (y = 0..15)
$000000c0 constant GPIOE_PUPDR_PUPDR3                               \ Port x configuration bits (y = 0..15)
$00000300 constant GPIOE_PUPDR_PUPDR4                               \ Port x configuration bits (y = 0..15)


\
\ @brief GPIO port input data register
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$00000001 constant GPIOE_IDR_IDR0                                   \ Port input data (y = 0..15)
$00000002 constant GPIOE_IDR_IDR1                                   \ Port input data (y = 0..15)
$00000004 constant GPIOE_IDR_IDR2                                   \ Port input data (y = 0..15)
$00000008 constant GPIOE_IDR_IDR3                                   \ Port input data (y = 0..15)
$00000010 constant GPIOE_IDR_IDR4                                   \ Port input data (y = 0..15)


\
\ @brief GPIO port output data register
\ Address offset: 0x14
\ Reset value: 0x00000000
\

$00000001 constant GPIOE_ODR_ODR0                                   \ Port output data (y = 0..15)
$00000002 constant GPIOE_ODR_ODR1                                   \ Port output data (y = 0..15)
$00000004 constant GPIOE_ODR_ODR2                                   \ Port output data (y = 0..15)
$00000008 constant GPIOE_ODR_ODR3                                   \ Port output data (y = 0..15)
$00000010 constant GPIOE_ODR_ODR4                                   \ Port output data (y = 0..15)


\
\ @brief GPIO port bit set/reset register
\ Address offset: 0x18
\ Reset value: 0x00000000
\

$00000001 constant GPIOE_BSRR_BS0                                   \ Port x set bit y (y= 0..15)
$00000002 constant GPIOE_BSRR_BS1                                   \ Port x set bit y (y= 0..15)
$00000004 constant GPIOE_BSRR_BS2                                   \ Port x set bit y (y= 0..15)
$00000008 constant GPIOE_BSRR_BS3                                   \ Port x set bit y (y= 0..15)
$00000010 constant GPIOE_BSRR_BS4                                   \ Port x set bit y (y= 0..15)
$00010000 constant GPIOE_BSRR_BR0                                   \ Port x set bit y (y= 0..15)
$00020000 constant GPIOE_BSRR_BR1                                   \ Port x reset bit y (y = 0..15)
$00040000 constant GPIOE_BSRR_BR2                                   \ Port x reset bit y (y = 0..15)
$00080000 constant GPIOE_BSRR_BR3                                   \ Port x reset bit y (y = 0..15)
$00100000 constant GPIOE_BSRR_BR4                                   \ Port x reset bit y (y = 0..15)


\
\ @brief GPIO port configuration lock register
\ Address offset: 0x1C
\ Reset value: 0x00000000
\

$00000001 constant GPIOE_LCKR_LCK0                                  \ Port x lock bit y (y= 0..15)
$00000002 constant GPIOE_LCKR_LCK1                                  \ Port x lock bit y (y= 0..15)
$00000004 constant GPIOE_LCKR_LCK2                                  \ Port x lock bit y (y= 0..15)
$00000008 constant GPIOE_LCKR_LCK3                                  \ Port x lock bit y (y= 0..15)
$00000010 constant GPIOE_LCKR_LCK4                                  \ Port x lock bit y (y= 0..15)
$00010000 constant GPIOE_LCKR_LCKK                                  \ Port x lock bit y (y= 0..15)


\
\ @brief GPIO alternate function low register
\ Address offset: 0x20
\ Reset value: 0x00000000
\

$0000000f constant GPIOE_AFRL_AFSEL0                                \ Alternate function selection for port x bit y (y = 0..7)
$000000f0 constant GPIOE_AFRL_AFSEL1                                \ Alternate function selection for port x bit y (y = 0..7)
$00000f00 constant GPIOE_AFRL_AFSEL2                                \ Alternate function selection for port x bit y (y = 0..7)
$0000f000 constant GPIOE_AFRL_AFSEL3                                \ Alternate function selection for port x bit y (y = 0..7)
$000f0000 constant GPIOE_AFRL_AFSEL4                                \ Alternate function selection for port x bit y (y = 0..7)


\
\ @brief GPIO alternate function high register
\ Address offset: 0x24
\ Reset value: 0x00000000
\

$0000000f constant GPIOE_AFRH_AFSEL8                                \ Alternate function selection for port x bit y (y = 8..15)
$000000f0 constant GPIOE_AFRH_AFSEL9                                \ Alternate function selection for port x bit y (y = 8..15)
$00000f00 constant GPIOE_AFRH_AFSEL10                               \ Alternate function selection for port x bit y (y = 8..15)
$0000f000 constant GPIOE_AFRH_AFSEL11                               \ Alternate function selection for port x bit y (y = 8..15)
$000f0000 constant GPIOE_AFRH_AFSEL12                               \ Alternate function selection for port x bit y (y = 8..15)
$00f00000 constant GPIOE_AFRH_AFSEL13                               \ Alternate function selection for port x bit y (y = 8..15)
$0f000000 constant GPIOE_AFRH_AFSEL14                               \ Alternate function selection for port x bit y (y = 8..15)
$f0000000 constant GPIOE_AFRH_AFSEL15                               \ Alternate function selection for port x bit y (y = 8..15)


\
\ @brief port bit reset register
\ Address offset: 0x28
\ Reset value: 0x00000000
\

$00000001 constant GPIOE_BRR_BR0                                    \ Port Reset bit
$00000002 constant GPIOE_BRR_BR1                                    \ Port Reset bit
$00000004 constant GPIOE_BRR_BR2                                    \ Port Reset bit
$00000008 constant GPIOE_BRR_BR3                                    \ Port Reset bit
$00000010 constant GPIOE_BRR_BR4                                    \ Port Reset bit


\
\ @brief General-purpose I/Os
\
$48001000 constant GPIOE_MODER    \ offset: 0x00 : GPIO port mode register
$48001004 constant GPIOE_OTYPER   \ offset: 0x04 : GPIO port output type register
$48001008 constant GPIOE_OSPEEDR  \ offset: 0x08 : GPIO port output speed register
$4800100c constant GPIOE_PUPDR    \ offset: 0x0C : GPIO port pull-up/pull-down register
$48001010 constant GPIOE_IDR      \ offset: 0x10 : GPIO port input data register
$48001014 constant GPIOE_ODR      \ offset: 0x14 : GPIO port output data register
$48001018 constant GPIOE_BSRR     \ offset: 0x18 : GPIO port bit set/reset register
$4800101c constant GPIOE_LCKR     \ offset: 0x1C : GPIO port configuration lock register
$48001020 constant GPIOE_AFRL     \ offset: 0x20 : GPIO alternate function low register
$48001024 constant GPIOE_AFRH     \ offset: 0x24 : GPIO alternate function high register
$48001028 constant GPIOE_BRR      \ offset: 0x28 : port bit reset register

