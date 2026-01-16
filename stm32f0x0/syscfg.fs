\
\ @file syscfg.fs
\ @brief System configuration controller
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief configuration register 1
\ Address offset: 0x00
\ Reset value: 0x00000000
\

$00000003 constant SYSCFG_CFGR1_MEM_MODE                            \ Memory mapping selection bits
$00000100 constant SYSCFG_CFGR1_ADC_DMA_RMP                         \ ADC DMA remapping bit
$00000200 constant SYSCFG_CFGR1_USART1_TX_DMA_RMP                   \ USART1_TX DMA remapping bit
$00000400 constant SYSCFG_CFGR1_USART1_RX_DMA_RMP                   \ USART1_RX DMA request remapping bit
$00000800 constant SYSCFG_CFGR1_TIM16_DMA_RMP                       \ TIM16 DMA request remapping bit
$00001000 constant SYSCFG_CFGR1_TIM17_DMA_RMP                       \ TIM17 DMA request remapping bit
$00010000 constant SYSCFG_CFGR1_I2C_PB6_FM                          \ Fast Mode Plus (FM plus) driving capability activation bits.
$00020000 constant SYSCFG_CFGR1_I2C_PB7_FM                          \ Fast Mode Plus (FM+) driving capability activation bits.
$00040000 constant SYSCFG_CFGR1_I2C_PB8_FM                          \ Fast Mode Plus (FM+) driving capability activation bits.
$00080000 constant SYSCFG_CFGR1_I2C_PB9_FM                          \ Fast Mode Plus (FM+) driving capability activation bits.
$00100000 constant SYSCFG_CFGR1_I2C1_FM_PLUS                        \ FM+ driving capability activation for I2C1
$00200000 constant SYSCFG_CFGR1_I2C2_FM_PLUS                        \ FM+ driving capability activation for I2C2
$01000000 constant SYSCFG_CFGR1_SPI2_DMA_RMP                        \ SPI2 DMA request remapping bit
$02000000 constant SYSCFG_CFGR1_USART2_DMA_RMP                      \ USART2 DMA request remapping bit
$04000000 constant SYSCFG_CFGR1_USART3_DMA_RMP                      \ USART3 DMA request remapping bit
$08000000 constant SYSCFG_CFGR1_I2C1_DMA_RMP                        \ I2C1 DMA request remapping bit
$10000000 constant SYSCFG_CFGR1_TIM1_DMA_RMP                        \ TIM1 DMA request remapping bit
$20000000 constant SYSCFG_CFGR1_TIM2_DMA_RMP                        \ TIM2 DMA request remapping bit
$40000000 constant SYSCFG_CFGR1_TIM3_DMA_RMP                        \ TIM3 DMA request remapping bit


\
\ @brief external interrupt configuration register 1
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$0000000f constant SYSCFG_EXTICR1_EXTI0                             \ EXTI 0 configuration bits
$000000f0 constant SYSCFG_EXTICR1_EXTI1                             \ EXTI 1 configuration bits
$00000f00 constant SYSCFG_EXTICR1_EXTI2                             \ EXTI 2 configuration bits
$0000f000 constant SYSCFG_EXTICR1_EXTI3                             \ EXTI 3 configuration bits


\
\ @brief external interrupt configuration register 2
\ Address offset: 0x0C
\ Reset value: 0x00000000
\

$0000000f constant SYSCFG_EXTICR2_EXTI4                             \ EXTI 4 configuration bits
$000000f0 constant SYSCFG_EXTICR2_EXTI5                             \ EXTI 5 configuration bits
$00000f00 constant SYSCFG_EXTICR2_EXTI6                             \ EXTI 6 configuration bits
$0000f000 constant SYSCFG_EXTICR2_EXTI7                             \ EXTI 7 configuration bits


\
\ @brief external interrupt configuration register 3
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$0000000f constant SYSCFG_EXTICR3_EXTI8                             \ EXTI 8 configuration bits
$000000f0 constant SYSCFG_EXTICR3_EXTI9                             \ EXTI 9 configuration bits
$00000f00 constant SYSCFG_EXTICR3_EXTI10                            \ EXTI 10 configuration bits
$0000f000 constant SYSCFG_EXTICR3_EXTI11                            \ EXTI 11 configuration bits


\
\ @brief external interrupt configuration register 4
\ Address offset: 0x14
\ Reset value: 0x00000000
\

$0000000f constant SYSCFG_EXTICR4_EXTI12                            \ EXTI 12 configuration bits
$000000f0 constant SYSCFG_EXTICR4_EXTI13                            \ EXTI 13 configuration bits
$00000f00 constant SYSCFG_EXTICR4_EXTI14                            \ EXTI 14 configuration bits
$0000f000 constant SYSCFG_EXTICR4_EXTI15                            \ EXTI 15 configuration bits


\
\ @brief configuration register 2
\ Address offset: 0x18
\ Reset value: 0x00000000
\

$00000001 constant SYSCFG_CFGR2_LOCUP_LOCK                          \ Cortex-M0 LOCKUP bit enable bit
$00000002 constant SYSCFG_CFGR2_SRAM_PARITY_LOCK                    \ SRAM parity lock bit
$00000004 constant SYSCFG_CFGR2_PVD_LOCK                            \ PVD lock enable bit
$00000100 constant SYSCFG_CFGR2_SRAM_PEF                            \ SRAM parity flag


\
\ @brief System configuration controller
\
$40010000 constant SYSCFG_CFGR1   \ offset: 0x00 : configuration register 1
$40010008 constant SYSCFG_EXTICR1  \ offset: 0x08 : external interrupt configuration register 1
$4001000c constant SYSCFG_EXTICR2  \ offset: 0x0C : external interrupt configuration register 2
$40010010 constant SYSCFG_EXTICR3  \ offset: 0x10 : external interrupt configuration register 3
$40010014 constant SYSCFG_EXTICR4  \ offset: 0x14 : external interrupt configuration register 4
$40010018 constant SYSCFG_CFGR2   \ offset: 0x18 : configuration register 2

