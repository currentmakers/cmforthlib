\
\ @file syscfg_itline.fs
\ @brief System configuration controller
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] SYSCFG_ITLINE_DEF

  [ifdef] SYSCFG_ITLINE_ITLINE0_DEF
    \
    \ @brief interrupt line 0 status register
    \ Address offset: 0x80
    \ Reset value: 0x00000000
    \
    $00 constant SYSCFG_ITLINE_WWDG             \ [0x00] Window watchdog interrupt pending flag
  [then]


  [ifdef] SYSCFG_ITLINE_ITLINE1_DEF
    \
    \ @brief interrupt line 1 status register
    \ Address offset: 0x84
    \ Reset value: 0x00000000
    \
    $00 constant SYSCFG_ITLINE_PVDOUT           \ [0x00] PVD supply monitoring interrupt request pending (EXTI line 16).
  [then]


  [ifdef] SYSCFG_ITLINE_ITLINE2_DEF
    \
    \ @brief interrupt line 2 status register
    \ Address offset: 0x88
    \ Reset value: 0x00000000
    \
    $00 constant SYSCFG_ITLINE_TAMP             \ [0x00] TAMP
    $01 constant SYSCFG_ITLINE_RTC              \ [0x01] RTC
  [then]


  [ifdef] SYSCFG_ITLINE_ITLINE3_DEF
    \
    \ @brief interrupt line 3 status register
    \ Address offset: 0x8C
    \ Reset value: 0x00000000
    \
    $00 constant SYSCFG_ITLINE_FLASH_ITF        \ [0x00] FLASH_ITF
    $01 constant SYSCFG_ITLINE_FLASH_ECC        \ [0x01] FLASH_ECC
  [then]


  [ifdef] SYSCFG_ITLINE_ITLINE4_DEF
    \
    \ @brief interrupt line 4 status register
    \ Address offset: 0x90
    \ Reset value: 0x00000000
    \
    $00 constant SYSCFG_ITLINE_RCC              \ [0x00] RCC
  [then]


  [ifdef] SYSCFG_ITLINE_ITLINE5_DEF
    \
    \ @brief interrupt line 5 status register
    \ Address offset: 0x94
    \ Reset value: 0x00000000
    \
    $00 constant SYSCFG_ITLINE_EXTI0            \ [0x00] EXTI0
    $01 constant SYSCFG_ITLINE_EXTI1            \ [0x01] EXTI1
  [then]


  [ifdef] SYSCFG_ITLINE_ITLINE6_DEF
    \
    \ @brief interrupt line 6 status register
    \ Address offset: 0x98
    \ Reset value: 0x00000000
    \
    $00 constant SYSCFG_ITLINE_EXTI2            \ [0x00] EXTI2
    $01 constant SYSCFG_ITLINE_EXTI3            \ [0x01] EXTI3
  [then]


  [ifdef] SYSCFG_ITLINE_ITLINE7_DEF
    \
    \ @brief interrupt line 7 status register
    \ Address offset: 0x9C
    \ Reset value: 0x00000000
    \
    $00 constant SYSCFG_ITLINE_EXTI4            \ [0x00] EXTI4
    $01 constant SYSCFG_ITLINE_EXTI5            \ [0x01] EXTI5
    $02 constant SYSCFG_ITLINE_EXTI6            \ [0x02] EXTI6
    $03 constant SYSCFG_ITLINE_EXTI7            \ [0x03] EXTI7
    $04 constant SYSCFG_ITLINE_EXTI8            \ [0x04] EXTI8
    $05 constant SYSCFG_ITLINE_EXTI9            \ [0x05] EXTI9
    $06 constant SYSCFG_ITLINE_EXTI10           \ [0x06] EXTI10
    $07 constant SYSCFG_ITLINE_EXTI11           \ [0x07] EXTI11
    $08 constant SYSCFG_ITLINE_EXTI12           \ [0x08] EXTI12
    $09 constant SYSCFG_ITLINE_EXTI13           \ [0x09] EXTI13
    $0a constant SYSCFG_ITLINE_EXTI14           \ [0x0a] EXTI14
    $0b constant SYSCFG_ITLINE_EXTI15           \ [0x0b] EXTI15
  [then]


  [ifdef] SYSCFG_ITLINE_ITLINE9_DEF
    \
    \ @brief interrupt line 9 status register
    \ Address offset: 0xA4
    \ Reset value: 0x00000000
    \
    $00 constant SYSCFG_ITLINE_DMA1_CH1         \ [0x00] DMA1_CH1
  [then]


  [ifdef] SYSCFG_ITLINE_ITLINE10_DEF
    \
    \ @brief interrupt line 10 status register
    \ Address offset: 0xA8
    \ Reset value: 0x00000000
    \
    $00 constant SYSCFG_ITLINE_DMA1_CH2         \ [0x00] DMA1_CH1
    $01 constant SYSCFG_ITLINE_DMA1_CH3         \ [0x01] DMA1_CH3
  [then]


  [ifdef] SYSCFG_ITLINE_ITLINE11_DEF
    \
    \ @brief interrupt line 11 status register
    \ Address offset: 0xAC
    \ Reset value: 0x00000000
    \
    $00 constant SYSCFG_ITLINE_DMAMUX           \ [0x00] DMAMUX
    $01 constant SYSCFG_ITLINE_DMA1_CH4         \ [0x01] DMA1_CH4
    $02 constant SYSCFG_ITLINE_DMA1_CH5         \ [0x02] DMA1_CH5
  [then]


  [ifdef] SYSCFG_ITLINE_ITLINE12_DEF
    \
    \ @brief interrupt line 12 status register
    \ Address offset: 0xB0
    \ Reset value: 0x00000000
    \
    $00 constant SYSCFG_ITLINE_ADC              \ [0x00] ADC
  [then]


  [ifdef] SYSCFG_ITLINE_ITLINE13_DEF
    \
    \ @brief interrupt line 13 status register
    \ Address offset: 0xB4
    \ Reset value: 0x00000000
    \
    $00 constant SYSCFG_ITLINE_TIM1_CCU         \ [0x00] TIM1_CCU
    $01 constant SYSCFG_ITLINE_TIM1_TRG         \ [0x01] TIM1_TRG
    $02 constant SYSCFG_ITLINE_TIM1_UPD         \ [0x02] TIM1_UPD
    $03 constant SYSCFG_ITLINE_TIM1_BRK         \ [0x03] TIM1_BRK
  [then]


  [ifdef] SYSCFG_ITLINE_ITLINE14_DEF
    \
    \ @brief interrupt line 14 status register
    \ Address offset: 0xB8
    \ Reset value: 0x00000000
    \
    $00 constant SYSCFG_ITLINE_TIM1_CC          \ [0x00] TIM1_CC
  [then]


  [ifdef] SYSCFG_ITLINE_ITLINE15_DEF
    \
    \ @brief interrupt line 15 status register
    \ Address offset: 0xBC
    \ Reset value: 0x00000000
    \
    $00 constant SYSCFG_ITLINE_TIM2             \ [0x00] TIM2
  [then]


  [ifdef] SYSCFG_ITLINE_ITLINE16_DEF
    \
    \ @brief interrupt line 16 status register
    \ Address offset: 0xC0
    \ Reset value: 0x00000000
    \
    $00 constant SYSCFG_ITLINE_TIM3             \ [0x00] TIM3
  [then]


  [ifdef] SYSCFG_ITLINE_ITLINE17_DEF
    \
    \ @brief interrupt line 17 status register
    \ Address offset: 0xC4
    \ Reset value: 0x00000000
    \
    $02 constant SYSCFG_ITLINE_LPTIM1           \ [0x02] LPTIM1
  [then]


  [ifdef] SYSCFG_ITLINE_ITLINE18_DEF
    \
    \ @brief interrupt line 18 status register
    \ Address offset: 0xC8
    \ Reset value: 0x00000000
    \
    $01 constant SYSCFG_ITLINE_LPTIM2           \ [0x01] LPTIM2
  [then]


  [ifdef] SYSCFG_ITLINE_ITLINE19_DEF
    \
    \ @brief interrupt line 19 status register
    \ Address offset: 0xCC
    \ Reset value: 0x00000000
    \
    $00 constant SYSCFG_ITLINE_TIM14            \ [0x00] TIM14
  [then]


  [ifdef] SYSCFG_ITLINE_ITLINE21_DEF
    \
    \ @brief interrupt line 21 status register
    \ Address offset: 0xD4
    \ Reset value: 0x00000000
    \
    $00 constant SYSCFG_ITLINE_TIM16            \ [0x00] TIM16
  [then]


  [ifdef] SYSCFG_ITLINE_ITLINE22_DEF
    \
    \ @brief interrupt line 22 status register
    \ Address offset: 0xD8
    \ Reset value: 0x00000000
    \
    $00 constant SYSCFG_ITLINE_TIM17            \ [0x00] TIM17
  [then]


  [ifdef] SYSCFG_ITLINE_ITLINE23_DEF
    \
    \ @brief interrupt line 23 status register
    \ Address offset: 0xDC
    \ Reset value: 0x00000000
    \
    $00 constant SYSCFG_ITLINE_I2C1             \ [0x00] I2C1
  [then]


  [ifdef] SYSCFG_ITLINE_ITLINE24_DEF
    \
    \ @brief interrupt line 24 status register
    \ Address offset: 0xE0
    \ Reset value: 0x00000000
    \
    $00 constant SYSCFG_ITLINE_I2C2             \ [0x00] I2C2
  [then]


  [ifdef] SYSCFG_ITLINE_ITLINE25_DEF
    \
    \ @brief interrupt line 25 status register
    \ Address offset: 0xE4
    \ Reset value: 0x00000000
    \
    $00 constant SYSCFG_ITLINE_SPI1             \ [0x00] SPI1
  [then]


  [ifdef] SYSCFG_ITLINE_ITLINE26_DEF
    \
    \ @brief interrupt line 26 status register
    \ Address offset: 0xE8
    \ Reset value: 0x00000000
    \
    $00 constant SYSCFG_ITLINE_SPI2             \ [0x00] SPI2
  [then]


  [ifdef] SYSCFG_ITLINE_ITLINE27_DEF
    \
    \ @brief interrupt line 27 status register
    \ Address offset: 0xEC
    \ Reset value: 0x00000000
    \
    $00 constant SYSCFG_ITLINE_USART1           \ [0x00] USART1
  [then]


  [ifdef] SYSCFG_ITLINE_ITLINE28_DEF
    \
    \ @brief interrupt line 28 status register
    \ Address offset: 0xF0
    \ Reset value: 0x00000000
    \
    $00 constant SYSCFG_ITLINE_USART2           \ [0x00] USART2
  [then]


  [ifdef] SYSCFG_ITLINE_ITLINE29_DEF
    \
    \ @brief interrupt line 29 status register
    \ Address offset: 0xF4
    \ Reset value: 0x00000000
    \
    $02 constant SYSCFG_ITLINE_USART5           \ [0x02] USART5
  [then]

  \
  \ @brief System configuration controller
  \
  $80 constant SYSCFG_ITLINE_ITLINE0    \ interrupt line 0 status register
  $84 constant SYSCFG_ITLINE_ITLINE1    \ interrupt line 1 status register
  $88 constant SYSCFG_ITLINE_ITLINE2    \ interrupt line 2 status register
  $8C constant SYSCFG_ITLINE_ITLINE3    \ interrupt line 3 status register
  $90 constant SYSCFG_ITLINE_ITLINE4    \ interrupt line 4 status register
  $94 constant SYSCFG_ITLINE_ITLINE5    \ interrupt line 5 status register
  $98 constant SYSCFG_ITLINE_ITLINE6    \ interrupt line 6 status register
  $9C constant SYSCFG_ITLINE_ITLINE7    \ interrupt line 7 status register
  $A4 constant SYSCFG_ITLINE_ITLINE9    \ interrupt line 9 status register
  $A8 constant SYSCFG_ITLINE_ITLINE10   \ interrupt line 10 status register
  $AC constant SYSCFG_ITLINE_ITLINE11   \ interrupt line 11 status register
  $B0 constant SYSCFG_ITLINE_ITLINE12   \ interrupt line 12 status register
  $B4 constant SYSCFG_ITLINE_ITLINE13   \ interrupt line 13 status register
  $B8 constant SYSCFG_ITLINE_ITLINE14   \ interrupt line 14 status register
  $BC constant SYSCFG_ITLINE_ITLINE15   \ interrupt line 15 status register
  $C0 constant SYSCFG_ITLINE_ITLINE16   \ interrupt line 16 status register
  $C4 constant SYSCFG_ITLINE_ITLINE17   \ interrupt line 17 status register
  $C8 constant SYSCFG_ITLINE_ITLINE18   \ interrupt line 18 status register
  $CC constant SYSCFG_ITLINE_ITLINE19   \ interrupt line 19 status register
  $D4 constant SYSCFG_ITLINE_ITLINE21   \ interrupt line 21 status register
  $D8 constant SYSCFG_ITLINE_ITLINE22   \ interrupt line 22 status register
  $DC constant SYSCFG_ITLINE_ITLINE23   \ interrupt line 23 status register
  $E0 constant SYSCFG_ITLINE_ITLINE24   \ interrupt line 24 status register
  $E4 constant SYSCFG_ITLINE_ITLINE25   \ interrupt line 25 status register
  $E8 constant SYSCFG_ITLINE_ITLINE26   \ interrupt line 26 status register
  $EC constant SYSCFG_ITLINE_ITLINE27   \ interrupt line 27 status register
  $F0 constant SYSCFG_ITLINE_ITLINE28   \ interrupt line 28 status register
  $F4 constant SYSCFG_ITLINE_ITLINE29   \ interrupt line 29 status register

: SYSCFG_ITLINE_DEF ; [then]
