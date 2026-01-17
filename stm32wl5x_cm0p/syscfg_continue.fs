\
\ @file syscfg_continue.fs
\ @brief System configuration controller
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] SYSCFG_CONTINUE_DEF

  [ifdef] SYSCFG_CONTINUE_IMR1_DEF
    \
    \ @brief IMR1
    \ Address offset: 0x00
    \ Reset value: 0x00000000
    \
    $00 constant SYSCFG_CONTINUE_RTCSTAMPTAMPLSECSSIM     \ [0x00] RTCSTAMPTAMPLSECSSIM
    $02 constant SYSCFG_CONTINUE_RTCSSRUIM      \ [0x02] RTCSSRUIM
    $15 constant SYSCFG_CONTINUE_EXTI5IM        \ [0x15] Peripheral EXTI5 interrupt mask to CPU1
    $16 constant SYSCFG_CONTINUE_EXTI6IM        \ [0x16] Peripheral EXTI6 interrupt mask to CPU1
    $17 constant SYSCFG_CONTINUE_EXTI7IM        \ [0x17] Peripheral EXTI7 interrupt mask to CPU1
    $18 constant SYSCFG_CONTINUE_EXTI8IM        \ [0x18] Peripheral EXTI8 interrupt mask to CPU1
    $19 constant SYSCFG_CONTINUE_EXTI9IM        \ [0x19] Peripheral EXTI9 interrupt mask to CPU1
    $1a constant SYSCFG_CONTINUE_EXTI10IM       \ [0x1a] Peripheral EXTI10 interrupt mask to CPU1
    $1b constant SYSCFG_CONTINUE_EXTI11IM       \ [0x1b] Peripheral EXTI11 interrupt mask to CPU1
    $1c constant SYSCFG_CONTINUE_EXTI12IM       \ [0x1c] Peripheral EXTI12 interrupt mask to CPU1
    $1d constant SYSCFG_CONTINUE_EXTI13IM       \ [0x1d] Peripheral EXTI13 interrupt mask to CPU1
    $1e constant SYSCFG_CONTINUE_EXTI14IM       \ [0x1e] Peripheral EXTI14 interrupt mask to CPU1
    $1f constant SYSCFG_CONTINUE_EXTI15IM       \ [0x1f] Peripheral EXTI15 interrupt mask to CPU1
  [then]


  [ifdef] SYSCFG_CONTINUE_IMR2_DEF
    \
    \ @brief IMR2
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $12 constant SYSCFG_CONTINUE_PVM3IM         \ [0x12] Peripheral xxx interrupt mask to CPU1
    $14 constant SYSCFG_CONTINUE_PVDIM          \ [0x14] Peripheral xxx interrupt mask to CPU1
  [then]


  [ifdef] SYSCFG_CONTINUE_C2IMR1_DEF
    \
    \ @brief C2IMR1
    \ Address offset: 0x08
    \ Reset value: 0x00000000
    \
    $00 constant SYSCFG_CONTINUE_RTCSTAMPTAMPLSECSSIM     \ [0x00] Peripheral RTCSTAMPTAMPLSECSS interrupt mask to CPU2
    $01 constant SYSCFG_CONTINUE_RTCALARMIM     \ [0x01] Peripheral RTCALARM interrupt mask to CPU2
    $02 constant SYSCFG_CONTINUE_RTCSSRUIM      \ [0x02] RTCSSRUIM
    $03 constant SYSCFG_CONTINUE_RTCWKUPIM      \ [0x03] Peripheral RTCWKUP interrupt mask to CPU2
    $05 constant SYSCFG_CONTINUE_RCCIM          \ [0x05] Peripheral RCC interrupt mask to CPU2
    $06 constant SYSCFG_CONTINUE_FLASHIM        \ [0x06] Peripheral FLASH interrupt mask to CPU2
    $08 constant SYSCFG_CONTINUE_PKAIM          \ [0x08] PKAIM
    $0a constant SYSCFG_CONTINUE_AES1IM         \ [0x0a] AES1IM
    $0b constant SYSCFG_CONTINUE_COMPIM         \ [0x0b] Peripheral COMP interrupt mask to CPU2
    $0c constant SYSCFG_CONTINUE_ADCIM          \ [0x0c] Peripheral ADC interrupt mask to CPU2
    $0d constant SYSCFG_CONTINUE_DAC1IM         \ [0x0d] Peripheral DAC1 interrupt mask to CPU2
    $10 constant SYSCFG_CONTINUE_EXTI0IM        \ [0x10] Peripheral EXTI0 interrupt mask to CPU2
    $11 constant SYSCFG_CONTINUE_EXTI1IM        \ [0x11] Peripheral EXTI1 interrupt mask to CPU2
    $12 constant SYSCFG_CONTINUE_EXTI2IM        \ [0x12] Peripheral EXTI2 interrupt mask to CPU2
    $13 constant SYSCFG_CONTINUE_EXTI3IM        \ [0x13] Peripheral EXTI3 interrupt mask to CPU2
    $14 constant SYSCFG_CONTINUE_EXTI4IM        \ [0x14] Peripheral EXTI4 interrupt mask to CPU2
    $15 constant SYSCFG_CONTINUE_EXTI5IM        \ [0x15] Peripheral EXTI5 interrupt mask to CPU2
    $16 constant SYSCFG_CONTINUE_EXTI6IM        \ [0x16] Peripheral EXTI6 interrupt mask to CPU2
    $17 constant SYSCFG_CONTINUE_EXTI7IM        \ [0x17] Peripheral EXTI7 interrupt mask to CPU2
    $18 constant SYSCFG_CONTINUE_EXTI8IM        \ [0x18] Peripheral EXTI8 interrupt mask to CPU2
    $19 constant SYSCFG_CONTINUE_EXTI9IM        \ [0x19] Peripheral EXTI9 interrupt mask to CPU2
    $1a constant SYSCFG_CONTINUE_EXTI10IM       \ [0x1a] Peripheral EXTI10 interrupt mask to CPU2
    $1b constant SYSCFG_CONTINUE_EXTI11IM       \ [0x1b] Peripheral EXTI11 interrupt mask to CPU2
    $1c constant SYSCFG_CONTINUE_EXTI12IM       \ [0x1c] Peripheral EXTI12 interrupt mask to CPU2
    $1d constant SYSCFG_CONTINUE_EXTI13IM       \ [0x1d] Peripheral EXTI13 interrupt mask to CPU2
    $1e constant SYSCFG_CONTINUE_EXTI14IM       \ [0x1e] Peripheral EXTI14 interrupt mask to CPU2
    $1f constant SYSCFG_CONTINUE_EXTI15IM       \ [0x1f] Peripheral EXTI15 interrupt mask to CPU2
  [then]


  [ifdef] SYSCFG_CONTINUE_C2IMR2_DEF
    \
    \ @brief C2IMR2
    \ Address offset: 0x0C
    \ Reset value: 0x00000000
    \
    $00 constant SYSCFG_CONTINUE_DMA1CH1IM      \ [0x00] Peripheral DMA1CH1 interrupt mask to CPU2
    $01 constant SYSCFG_CONTINUE_DMA1CH2IM      \ [0x01] Peripheral DMA1CH2 interrupt mask to CPU2
    $02 constant SYSCFG_CONTINUE_DMA1CH3IM      \ [0x02] Peripheral DMA1CH3 interrupt mask to CPU2
    $03 constant SYSCFG_CONTINUE_DMA1CH4IM      \ [0x03] Peripheral DMA1CH4 interrupt mask to CPU2
    $04 constant SYSCFG_CONTINUE_DMA1CH5IM      \ [0x04] Peripheral DMA1CH5 interrupt mask to CPU2
    $05 constant SYSCFG_CONTINUE_DMA1CH6IM      \ [0x05] Peripheral DMA1CH6 interrupt mask to CPU2
    $06 constant SYSCFG_CONTINUE_DMA1CH7IM      \ [0x06] Peripheral DMA1CH7 interrupt mask to CPU2
    $08 constant SYSCFG_CONTINUE_DMA2CH1IM      \ [0x08] Peripheral DMA2CH1 interrupt mask to CPU2
    $09 constant SYSCFG_CONTINUE_DMA2CH2IM      \ [0x09] Peripheral DMA2CH2 interrupt mask to CPU2
    $0a constant SYSCFG_CONTINUE_DMA2CH3IM      \ [0x0a] Peripheral DMA2CH3 interrupt mask to CPU2
    $0b constant SYSCFG_CONTINUE_DMA2CH4IM      \ [0x0b] Peripheral DMA2CH4 interrupt mask to CPU2
    $0c constant SYSCFG_CONTINUE_DMA2CH5IM      \ [0x0c] Peripheral DMA2CH5 interrupt mask to CPU2
    $0d constant SYSCFG_CONTINUE_DMA2CH6IM      \ [0x0d] Peripheral DMA2CH6 interrupt mask to CPU2
    $0e constant SYSCFG_CONTINUE_DMA2CH7IM      \ [0x0e] Peripheral DMA2CH7 interrupt mask to CPU2
    $0f constant SYSCFG_CONTINUE_DMAMUX1IM      \ [0x0f] Peripheral DMAMUX1 interrupt mask to CPU2
    $12 constant SYSCFG_CONTINUE_PVM3IM         \ [0x12] Peripheral PVM3 interrupt mask to CPU2
    $14 constant SYSCFG_CONTINUE_PVDIM          \ [0x14] Peripheral PVD interrupt mask to CPU2
  [then]

  \
  \ @brief System configuration controller
  \
  $00 constant SYSCFG_CONTINUE_IMR1     \ IMR1
  $04 constant SYSCFG_CONTINUE_IMR2     \ IMR2
  $08 constant SYSCFG_CONTINUE_C2IMR1   \ C2IMR1
  $0C constant SYSCFG_CONTINUE_C2IMR2   \ C2IMR2

: SYSCFG_CONTINUE_DEF ; [then]
