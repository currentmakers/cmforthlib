\
\ @file afio.fs
\ @brief Alternate function I/O
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief Event Control Register (AFIO_EVCR)
\ Address offset: 0x00
\ Reset value: 0x00000000
\

$0000000f constant AFIO_EVCR_PIN                                    \ Pin selection
$00000070 constant AFIO_EVCR_PORT                                   \ Port selection
$00000080 constant AFIO_EVCR_EVOE                                   \ Event Output Enable


\
\ @brief AF remap and debug I/O configuration register (AFIO_MAPR)
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$00000001 constant AFIO_MAPR_SPI1_REMAP                             \ SPI1 remapping
$00000002 constant AFIO_MAPR_I2C1_REMAP                             \ I2C1 remapping
$00000004 constant AFIO_MAPR_USART1_REMAP                           \ USART1 remapping
$00000008 constant AFIO_MAPR_USART2_REMAP                           \ USART2 remapping
$00000030 constant AFIO_MAPR_USART3_REMAP                           \ USART3 remapping
$000000c0 constant AFIO_MAPR_TIM1_REMAP                             \ TIM1 remapping
$00000300 constant AFIO_MAPR_TIM2_REMAP                             \ TIM2 remapping
$00000c00 constant AFIO_MAPR_TIM3_REMAP                             \ TIM3 remapping
$00001000 constant AFIO_MAPR_TIM4_REMAP                             \ TIM4 remapping
$00006000 constant AFIO_MAPR_CAN1_REMAP                             \ CAN1 remapping
$00008000 constant AFIO_MAPR_PD01_REMAP                             \ Port D0/Port D1 mapping on OSCIN/OSCOUT
$00010000 constant AFIO_MAPR_TIM5CH4_IREMAP                         \ Set and cleared by software
$00200000 constant AFIO_MAPR_ETH_REMAP                              \ Ethernet MAC I/O remapping
$00400000 constant AFIO_MAPR_CAN2_REMAP                             \ CAN2 I/O remapping
$00800000 constant AFIO_MAPR_MII_RMII_SEL                           \ MII or RMII selection
$07000000 constant AFIO_MAPR_SWJ_CFG                                \ Serial wire JTAG configuration
$10000000 constant AFIO_MAPR_SPI3_REMAP                             \ SPI3/I2S3 remapping
$20000000 constant AFIO_MAPR_TIM2ITR1_IREMAP                        \ TIM2 internal trigger 1 remapping
$40000000 constant AFIO_MAPR_PTP_PPS_REMAP                          \ Ethernet PTP PPS remapping


\
\ @brief External interrupt configuration register 1 (AFIO_EXTICR1)
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$0000000f constant AFIO_EXTICR1_EXTI0                               \ EXTI0 configuration
$000000f0 constant AFIO_EXTICR1_EXTI1                               \ EXTI1 configuration
$00000f00 constant AFIO_EXTICR1_EXTI2                               \ EXTI2 configuration
$0000f000 constant AFIO_EXTICR1_EXTI3                               \ EXTI3 configuration


\
\ @brief External interrupt configuration register 2 (AFIO_EXTICR2)
\ Address offset: 0x0C
\ Reset value: 0x00000000
\

$0000000f constant AFIO_EXTICR2_EXTI4                               \ EXTI4 configuration
$000000f0 constant AFIO_EXTICR2_EXTI5                               \ EXTI5 configuration
$00000f00 constant AFIO_EXTICR2_EXTI6                               \ EXTI6 configuration
$0000f000 constant AFIO_EXTICR2_EXTI7                               \ EXTI7 configuration


\
\ @brief External interrupt configuration register 3 (AFIO_EXTICR3)
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$0000000f constant AFIO_EXTICR3_EXTI8                               \ EXTI8 configuration
$000000f0 constant AFIO_EXTICR3_EXTI9                               \ EXTI9 configuration
$00000f00 constant AFIO_EXTICR3_EXTI10                              \ EXTI10 configuration
$0000f000 constant AFIO_EXTICR3_EXTI11                              \ EXTI11 configuration


\
\ @brief External interrupt configuration register 4 (AFIO_EXTICR4)
\ Address offset: 0x14
\ Reset value: 0x00000000
\

$0000000f constant AFIO_EXTICR4_EXTI12                              \ EXTI12 configuration
$000000f0 constant AFIO_EXTICR4_EXTI13                              \ EXTI13 configuration
$00000f00 constant AFIO_EXTICR4_EXTI14                              \ EXTI14 configuration
$0000f000 constant AFIO_EXTICR4_EXTI15                              \ EXTI15 configuration


\
\ @brief AF remap and debug I/O configuration register
\ Address offset: 0x1C
\ Reset value: 0x00000000
\

$00000020 constant AFIO_MAPR2_TIM9_REMAP                            \ TIM9 remapping
$00000040 constant AFIO_MAPR2_TIM10_REMAP                           \ TIM10 remapping
$00000080 constant AFIO_MAPR2_TIM11_REMAP                           \ TIM11 remapping
$00000100 constant AFIO_MAPR2_TIM13_REMAP                           \ TIM13 remapping
$00000200 constant AFIO_MAPR2_TIM14_REMAP                           \ TIM14 remapping
$00000400 constant AFIO_MAPR2_FSMC_NADV                             \ NADV connect/disconnect


\
\ @brief Alternate function I/O
\
$40010000 constant AFIO_EVCR      \ offset: 0x00 : Event Control Register (AFIO_EVCR)
$40010004 constant AFIO_MAPR      \ offset: 0x04 : AF remap and debug I/O configuration register (AFIO_MAPR)
$40010008 constant AFIO_EXTICR1   \ offset: 0x08 : External interrupt configuration register 1 (AFIO_EXTICR1)
$4001000c constant AFIO_EXTICR2   \ offset: 0x0C : External interrupt configuration register 2 (AFIO_EXTICR2)
$40010010 constant AFIO_EXTICR3   \ offset: 0x10 : External interrupt configuration register 3 (AFIO_EXTICR3)
$40010014 constant AFIO_EXTICR4   \ offset: 0x14 : External interrupt configuration register 4 (AFIO_EXTICR4)
$4001001c constant AFIO_MAPR2     \ offset: 0x1C : AF remap and debug I/O configuration register

