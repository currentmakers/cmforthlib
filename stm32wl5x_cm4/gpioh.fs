\
\ @file gpioh.fs
\ @brief General-purpose I/Os
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief GPIO port mode register
\ Address offset: 0x00
\ Reset value: 0x000000C0
\

$000000c0 constant GPIOH_MODER_MODER3                               \ Port x configuration bits (y = 0..15)


\
\ @brief GPIO port output type register
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$00000008 constant GPIOH_OTYPER_OT3                                 \ Port x configuration bits (y = 0..15)


\
\ @brief GPIO port output speed register
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$000000c0 constant GPIOH_OSPEEDR_OSPEEDR3                           \ Port x configuration bits (y = 0..15)


\
\ @brief GPIO port pull-up/pull-down register
\ Address offset: 0x0C
\ Reset value: 0x00000000
\

$000000c0 constant GPIOH_PUPDR_PUPDR3                               \ Port x configuration bits (y = 0..15)


\
\ @brief GPIO port input data register
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$00000008 constant GPIOH_IDR_IDR3                                   \ Port input data (y = 0..15)


\
\ @brief GPIO port output data register
\ Address offset: 0x14
\ Reset value: 0x00000000
\

$00000008 constant GPIOH_ODR_ODR3                                   \ Port output data (y = 0..15)


\
\ @brief GPIO port bit set/reset register
\ Address offset: 0x18
\ Reset value: 0x00000000
\

$00000008 constant GPIOH_BSRR_BS3                                   \ Port x set bit y (y= 0..15)
$00080000 constant GPIOH_BSRR_BR3                                   \ Port x reset bit y (y = 0..15)


\
\ @brief GPIO port configuration lock register
\ Address offset: 0x1C
\ Reset value: 0x00000000
\

$00000008 constant GPIOH_LCKR_LCK3                                  \ Port x lock bit y (y= 0..15)
$00010000 constant GPIOH_LCKR_LCKK                                  \ Port x lock bit y (y= 0..15)


\
\ @brief GPIO alternate function low register
\ Address offset: 0x20
\ Reset value: 0x00000000
\

$0000f000 constant GPIOH_AFRL_AFRL3                                 \ Alternate function selection for port x bit y (y = 0..7)


\
\ @brief GPIO alternate function high register
\ Address offset: 0x24
\ Reset value: 0x00000000
\

$0000000f constant GPIOH_AFRH_AFRH8                                 \ Alternate function selection for port x bit y (y = 8..15)
$000000f0 constant GPIOH_AFRH_AFRH9                                 \ Alternate function selection for port x bit y (y = 8..15)
$00000f00 constant GPIOH_AFRH_AFRH10                                \ Alternate function selection for port x bit y (y = 8..15)
$0000f000 constant GPIOH_AFRH_AFRH11                                \ Alternate function selection for port x bit y (y = 8..15)
$000f0000 constant GPIOH_AFRH_AFRH12                                \ Alternate function selection for port x bit y (y = 8..15)
$00f00000 constant GPIOH_AFRH_AFRH13                                \ Alternate function selection for port x bit y (y = 8..15)
$0f000000 constant GPIOH_AFRH_AFRH14                                \ Alternate function selection for port x bit y (y = 8..15)
$f0000000 constant GPIOH_AFRH_AFRH15                                \ Alternate function selection for port x bit y (y = 8..15)


\
\ @brief GPIO port bit reset register
\ Address offset: 0x28
\ Reset value: 0x00000000
\

$00000008 constant GPIOH_BRR_BR3                                    \ Port Reset bit


\
\ @brief General-purpose I/Os
\
$48001c00 constant GPIOH_MODER    \ offset: 0x00 : GPIO port mode register
$48001c04 constant GPIOH_OTYPER   \ offset: 0x04 : GPIO port output type register
$48001c08 constant GPIOH_OSPEEDR  \ offset: 0x08 : GPIO port output speed register
$48001c0c constant GPIOH_PUPDR    \ offset: 0x0C : GPIO port pull-up/pull-down register
$48001c10 constant GPIOH_IDR      \ offset: 0x10 : GPIO port input data register
$48001c14 constant GPIOH_ODR      \ offset: 0x14 : GPIO port output data register
$48001c18 constant GPIOH_BSRR     \ offset: 0x18 : GPIO port bit set/reset register
$48001c1c constant GPIOH_LCKR     \ offset: 0x1C : GPIO port configuration lock register
$48001c20 constant GPIOH_AFRL     \ offset: 0x20 : GPIO alternate function low register
$48001c24 constant GPIOH_AFRH     \ offset: 0x24 : GPIO alternate function high register
$48001c28 constant GPIOH_BRR      \ offset: 0x28 : GPIO port bit reset register

