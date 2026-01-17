\
\ @file syscfg_vrefbuf.fs
\ @brief SYSCFG_VREFBUF
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] SYSCFG_VREFBUF_DEF

  [ifdef] SYSCFG_VREFBUF_SYSCFG_MEMRMP_DEF
    \
    \ @brief memory remap register
    \ Address offset: 0x00
    \ Reset value: 0x00000000
    \
    $00 constant SYSCFG_VREFBUF_MEM_MODE        \ [0x00 : 3] Memory mapping selection
  [then]


  [ifdef] SYSCFG_VREFBUF_SYSCFG_CFGR1_DEF
    \
    \ @brief configuration register 1
    \ Address offset: 0x04
    \ Reset value: 0x7C000001
    \
    $08 constant SYSCFG_VREFBUF_BOOSTEN         \ [0x08] I/O analog switch voltage booster enable
    $10 constant SYSCFG_VREFBUF_I2C_PB6_FMP     \ [0x10] Fast-mode Plus (Fm+) driving capability activation on PB6
    $11 constant SYSCFG_VREFBUF_I2C_PB7_FMP     \ [0x11] Fast-mode Plus (Fm+) driving capability activation on PB7
    $12 constant SYSCFG_VREFBUF_I2C_PB8_FMP     \ [0x12] Fast-mode Plus (Fm+) driving capability activation on PB8
    $13 constant SYSCFG_VREFBUF_I2C_PB9_FMP     \ [0x13] Fast-mode Plus (Fm+) driving capability activation on PB9
    $14 constant SYSCFG_VREFBUF_I2C1_FMP        \ [0x14] I2C1 Fast-mode Plus driving capability activation
    $16 constant SYSCFG_VREFBUF_I2C3_FMP        \ [0x16] I2C3 Fast-mode Plus driving capability activation
    $1a constant SYSCFG_VREFBUF_FPU_IE          \ [0x1a : 6] Floating Point Unit interrupts enable bits
  [then]


  [ifdef] SYSCFG_VREFBUF_SYSCFG_EXTICR1_DEF
    \
    \ @brief external interrupt configuration register 1
    \ Address offset: 0x08
    \ Reset value: 0x00000000
    \
    $00 constant SYSCFG_VREFBUF_EXTI0           \ [0x00 : 3] EXTI 0 configuration bits
    $04 constant SYSCFG_VREFBUF_EXTI1           \ [0x04 : 3] EXTI 1 configuration bits
    $08 constant SYSCFG_VREFBUF_EXTI2           \ [0x08 : 3] EXTI 2 configuration bits
    $0c constant SYSCFG_VREFBUF_EXTI3           \ [0x0c : 3] EXTI 3 configuration bits
  [then]


  [ifdef] SYSCFG_VREFBUF_SYSCFG_EXTICR2_DEF
    \
    \ @brief external interrupt configuration register 2
    \ Address offset: 0x0C
    \ Reset value: 0x00000000
    \
    $00 constant SYSCFG_VREFBUF_EXTI4           \ [0x00 : 3] EXTI 4 configuration bits
    $04 constant SYSCFG_VREFBUF_EXTI5           \ [0x04 : 3] EXTI 5 configuration bits
    $08 constant SYSCFG_VREFBUF_EXTI6           \ [0x08 : 3] EXTI 6 configuration bits
    $0c constant SYSCFG_VREFBUF_EXTI7           \ [0x0c : 3] EXTI 7 configuration bits
  [then]


  [ifdef] SYSCFG_VREFBUF_SYSCFG_EXTICR3_DEF
    \
    \ @brief external interrupt configuration register 3
    \ Address offset: 0x10
    \ Reset value: 0x00000000
    \
    $00 constant SYSCFG_VREFBUF_EXTI8           \ [0x00 : 3] EXTI 8 configuration bits
    $04 constant SYSCFG_VREFBUF_EXTI9           \ [0x04 : 3] EXTI 9 configuration bits
    $08 constant SYSCFG_VREFBUF_EXTI10          \ [0x08 : 3] EXTI 10 configuration bits
    $0c constant SYSCFG_VREFBUF_EXTI11          \ [0x0c : 3] EXTI 11 configuration bits
  [then]


  [ifdef] SYSCFG_VREFBUF_SYSCFG_EXTICR4_DEF
    \
    \ @brief external interrupt configuration register 4
    \ Address offset: 0x14
    \ Reset value: 0x00000000
    \
    $00 constant SYSCFG_VREFBUF_EXTI12          \ [0x00 : 3] EXTI12 configuration bits
    $04 constant SYSCFG_VREFBUF_EXTI13          \ [0x04 : 3] EXTI13 configuration bits
    $08 constant SYSCFG_VREFBUF_EXTI14          \ [0x08 : 3] EXTI14 configuration bits
    $0c constant SYSCFG_VREFBUF_EXTI15          \ [0x0c : 3] EXTI15 configuration bits
  [then]


  [ifdef] SYSCFG_VREFBUF_SYSCFG_SCSR_DEF
    \
    \ @brief SCSR
    \ Address offset: 0x18
    \ Reset value: 0x00000000
    \
    $00 constant SYSCFG_VREFBUF_SRAM2ER         \ [0x00] SRAM2 Erase
    $01 constant SYSCFG_VREFBUF_SRAM2BSY        \ [0x01] SRAM2 busy by erase operation
    $1f constant SYSCFG_VREFBUF_C2RFD           \ [0x1f] CPU2 SRAM fetch (execution) disable.
  [then]


  [ifdef] SYSCFG_VREFBUF_SYSCFG_CFGR2_DEF
    \
    \ @brief CFGR2
    \ Address offset: 0x1C
    \ Reset value: 0x00000000
    \
    $00 constant SYSCFG_VREFBUF_CLL             \ [0x00] Cortex-M4 LOCKUP (Hardfault) output enable bit
    $01 constant SYSCFG_VREFBUF_SPL             \ [0x01] SRAM2 parity lock bit
    $02 constant SYSCFG_VREFBUF_PVDL            \ [0x02] PVD lock enable bit
    $03 constant SYSCFG_VREFBUF_ECCL            \ [0x03] ECC Lock
    $08 constant SYSCFG_VREFBUF_SPF             \ [0x08] SRAM2 parity error flag
  [then]


  [ifdef] SYSCFG_VREFBUF_SYSCFG_SWPR_DEF
    \
    \ @brief SRAM2 write protection register
    \ Address offset: 0x20
    \ Reset value: 0x00000000
    \
    $00 constant SYSCFG_VREFBUF_P0WP            \ [0x00] P0WP
    $01 constant SYSCFG_VREFBUF_P1WP            \ [0x01] P1WP
    $02 constant SYSCFG_VREFBUF_P2WP            \ [0x02] P2WP
    $03 constant SYSCFG_VREFBUF_P3WP            \ [0x03] P3WP
    $04 constant SYSCFG_VREFBUF_P4WP            \ [0x04] P4WP
    $05 constant SYSCFG_VREFBUF_P5WP            \ [0x05] P5WP
    $06 constant SYSCFG_VREFBUF_P6WP            \ [0x06] P6WP
    $07 constant SYSCFG_VREFBUF_P7WP            \ [0x07] P7WP
    $08 constant SYSCFG_VREFBUF_P8WP            \ [0x08] P8WP
    $09 constant SYSCFG_VREFBUF_P9WP            \ [0x09] P9WP
    $0a constant SYSCFG_VREFBUF_P10WP           \ [0x0a] P10WP
    $0b constant SYSCFG_VREFBUF_P11WP           \ [0x0b] P11WP
    $0c constant SYSCFG_VREFBUF_P12WP           \ [0x0c] P12WP
    $0d constant SYSCFG_VREFBUF_P13WP           \ [0x0d] P13WP
    $0e constant SYSCFG_VREFBUF_P14WP           \ [0x0e] P14WP
    $0f constant SYSCFG_VREFBUF_P15WP           \ [0x0f] P15WP
    $10 constant SYSCFG_VREFBUF_P16WP           \ [0x10] P16WP
    $11 constant SYSCFG_VREFBUF_P17WP           \ [0x11] P17WP
    $12 constant SYSCFG_VREFBUF_P18WP           \ [0x12] P18WP
    $13 constant SYSCFG_VREFBUF_P19WP           \ [0x13] P19WP
    $14 constant SYSCFG_VREFBUF_P20WP           \ [0x14] P20WP
    $15 constant SYSCFG_VREFBUF_P21WP           \ [0x15] P21WP
    $16 constant SYSCFG_VREFBUF_P22WP           \ [0x16] P22WP
    $17 constant SYSCFG_VREFBUF_P23WP           \ [0x17] P23WP
    $18 constant SYSCFG_VREFBUF_P24WP           \ [0x18] P24WP
    $19 constant SYSCFG_VREFBUF_P25WP           \ [0x19] P25WP
    $1a constant SYSCFG_VREFBUF_P26WP           \ [0x1a] P26WP
    $1b constant SYSCFG_VREFBUF_P27WP           \ [0x1b] P27WP
    $1c constant SYSCFG_VREFBUF_P28WP           \ [0x1c] P28WP
    $1d constant SYSCFG_VREFBUF_P29WP           \ [0x1d] P29WP
    $1e constant SYSCFG_VREFBUF_P30WP           \ [0x1e] P30WP
    $1f constant SYSCFG_VREFBUF_P31WP           \ [0x1f] SRAM2 page 31 write protection
  [then]


  [ifdef] SYSCFG_VREFBUF_SYSCFG_SKR_DEF
    \
    \ @brief SKR
    \ Address offset: 0x24
    \ Reset value: 0x00000000
    \
    $00 constant SYSCFG_VREFBUF_KEY             \ [0x00 : 8] SRAM2 write protection key for software erase
  [then]


  [ifdef] SYSCFG_VREFBUF_SYSCFG_SWPR2_DEF
    \
    \ @brief SRAM2 write protection register 2
    \ Address offset: 0x28
    \ Reset value: 0x00000000
    \
    $00 constant SYSCFG_VREFBUF_P32WP           \ [0x00] P32WP
    $01 constant SYSCFG_VREFBUF_P33WP           \ [0x01] P33WP
    $02 constant SYSCFG_VREFBUF_P34WP           \ [0x02] P34WP
    $03 constant SYSCFG_VREFBUF_P35WP           \ [0x03] P35WP
    $04 constant SYSCFG_VREFBUF_P36WP           \ [0x04] P36WP
    $05 constant SYSCFG_VREFBUF_P37WP           \ [0x05] P37WP
    $06 constant SYSCFG_VREFBUF_P38WP           \ [0x06] P38WP
    $07 constant SYSCFG_VREFBUF_P39WP           \ [0x07] P39WP
    $08 constant SYSCFG_VREFBUF_P40WP           \ [0x08] P40WP
    $09 constant SYSCFG_VREFBUF_P41WP           \ [0x09] P41WP
    $0a constant SYSCFG_VREFBUF_P42WP           \ [0x0a] P42WP
    $0b constant SYSCFG_VREFBUF_P43WP           \ [0x0b] P43WP
    $0c constant SYSCFG_VREFBUF_P44WP           \ [0x0c] P44WP
    $0d constant SYSCFG_VREFBUF_P45WP           \ [0x0d] P45WP
    $0e constant SYSCFG_VREFBUF_P46WP           \ [0x0e] P46WP
    $0f constant SYSCFG_VREFBUF_P47WP           \ [0x0f] P47WP
    $10 constant SYSCFG_VREFBUF_P48WP           \ [0x10] P48WP
    $11 constant SYSCFG_VREFBUF_P49WP           \ [0x11] P49WP
    $12 constant SYSCFG_VREFBUF_P50WP           \ [0x12] P50WP
    $13 constant SYSCFG_VREFBUF_P51WP           \ [0x13] P51WP
    $14 constant SYSCFG_VREFBUF_P52WP           \ [0x14] P52WP
    $15 constant SYSCFG_VREFBUF_P53WP           \ [0x15] P53WP
    $16 constant SYSCFG_VREFBUF_P54WP           \ [0x16] P54WP
    $17 constant SYSCFG_VREFBUF_P55WP           \ [0x17] P55WP
    $18 constant SYSCFG_VREFBUF_P56WP           \ [0x18] P56WP
    $19 constant SYSCFG_VREFBUF_P57WP           \ [0x19] P57WP
    $1a constant SYSCFG_VREFBUF_P58WP           \ [0x1a] P58WP
    $1b constant SYSCFG_VREFBUF_P59WP           \ [0x1b] P59WP
    $1c constant SYSCFG_VREFBUF_P60WP           \ [0x1c] P60WP
    $1d constant SYSCFG_VREFBUF_P61WP           \ [0x1d] P61WP
    $1e constant SYSCFG_VREFBUF_P62WP           \ [0x1e] P62WP
    $1f constant SYSCFG_VREFBUF_P63WP           \ [0x1f] SRAM2 page 63 write protection
  [then]


  [ifdef] SYSCFG_VREFBUF_VREFBUF_CSR_DEF
    \
    \ @brief VREF control and status register
    \ Address offset: 0x30
    \ Reset value: 0x00000002
    \
    $00 constant SYSCFG_VREFBUF_ENVR            \ [0x00] Voltage reference buffer enable
    $01 constant SYSCFG_VREFBUF_HIZ             \ [0x01] High impedance mode
    $02 constant SYSCFG_VREFBUF_VRS             \ [0x02] Voltage reference scale
    $03 constant SYSCFG_VREFBUF_VRR             \ [0x03] Voltage reference buffer ready
  [then]


  [ifdef] SYSCFG_VREFBUF_VREFBUF_CCR_DEF
    \
    \ @brief calibration control register
    \ Address offset: 0x34
    \ Reset value: 0x00000000
    \
    $00 constant SYSCFG_VREFBUF_TRIM            \ [0x00 : 6] Trimming code
  [then]


  [ifdef] SYSCFG_VREFBUF_SYSCFG_IMR1_DEF
    \
    \ @brief CPU1 interrupt mask register 1
    \ Address offset: 0x100
    \ Reset value: 0x00000000
    \
    $0d constant SYSCFG_VREFBUF_TIM1IM          \ [0x0d] Peripheral TIM1 interrupt mask to CPU1
    $0e constant SYSCFG_VREFBUF_TIM16IM         \ [0x0e] Peripheral TIM16 interrupt mask to CPU1
    $0f constant SYSCFG_VREFBUF_TIM17IM         \ [0x0f] Peripheral TIM17 interrupt mask to CPU1
    $15 constant SYSCFG_VREFBUF_EXIT5IM         \ [0x15] Peripheral EXIT5 interrupt mask to CPU1
    $16 constant SYSCFG_VREFBUF_EXIT6IM         \ [0x16] Peripheral EXIT6 interrupt mask to CPU1
    $17 constant SYSCFG_VREFBUF_EXIT7IM         \ [0x17] Peripheral EXIT7 interrupt mask to CPU1
    $18 constant SYSCFG_VREFBUF_EXIT8IM         \ [0x18] Peripheral EXIT8 interrupt mask to CPU1
    $19 constant SYSCFG_VREFBUF_EXIT9IM         \ [0x19] Peripheral EXIT9 interrupt mask to CPU1
    $1a constant SYSCFG_VREFBUF_EXIT10IM        \ [0x1a] Peripheral EXIT10 interrupt mask to CPU1
    $1b constant SYSCFG_VREFBUF_EXIT11IM        \ [0x1b] Peripheral EXIT11 interrupt mask to CPU1
    $1c constant SYSCFG_VREFBUF_EXIT12IM        \ [0x1c] Peripheral EXIT12 interrupt mask to CPU1
    $1d constant SYSCFG_VREFBUF_EXIT13IM        \ [0x1d] Peripheral EXIT13 interrupt mask to CPU1
    $1e constant SYSCFG_VREFBUF_EXIT14IM        \ [0x1e] Peripheral EXIT14 interrupt mask to CPU1
    $1f constant SYSCFG_VREFBUF_EXIT15IM        \ [0x1f] Peripheral EXIT15 interrupt mask to CPU1
  [then]


  [ifdef] SYSCFG_VREFBUF_SYSCFG_IMR2_DEF
    \
    \ @brief CPU1 interrupt mask register 2
    \ Address offset: 0x104
    \ Reset value: 0x00000000
    \
    $10 constant SYSCFG_VREFBUF_PVM1IM          \ [0x10] Peripheral PVM1 interrupt mask to CPU1
    $12 constant SYSCFG_VREFBUF_PVM3IM          \ [0x12] Peripheral PVM3 interrupt mask to CPU1
    $14 constant SYSCFG_VREFBUF_PVDIM           \ [0x14] Peripheral PVD interrupt mask to CPU1
  [then]


  [ifdef] SYSCFG_VREFBUF_SYSCFG_C2IMR1_DEF
    \
    \ @brief CPU2 interrupt mask register 1
    \ Address offset: 0x108
    \ Reset value: 0x00000000
    \
    $00 constant SYSCFG_VREFBUF_RTCSTAMP        \ [0x00] Peripheral RTCSTAMP interrupt mask to CPU2
    $03 constant SYSCFG_VREFBUF_RTCWKUP         \ [0x03] Peripheral RTCWKUP interrupt mask to CPU2
    $04 constant SYSCFG_VREFBUF_RTCALARM        \ [0x04] Peripheral RTCALARM interrupt mask to CPU2
    $05 constant SYSCFG_VREFBUF_RCC             \ [0x05] Peripheral RCC interrupt mask to CPU2
    $06 constant SYSCFG_VREFBUF_FLASH           \ [0x06] Peripheral FLASH interrupt mask to CPU2
    $08 constant SYSCFG_VREFBUF_PKA             \ [0x08] Peripheral PKA interrupt mask to CPU2
    $09 constant SYSCFG_VREFBUF_RNG             \ [0x09] Peripheral RNG interrupt mask to CPU2
    $0a constant SYSCFG_VREFBUF_AES1            \ [0x0a] Peripheral AES1 interrupt mask to CPU2
    $0b constant SYSCFG_VREFBUF_COMP            \ [0x0b] Peripheral COMP interrupt mask to CPU2
    $0c constant SYSCFG_VREFBUF_ADC             \ [0x0c] Peripheral ADC interrupt mask to CPU2
  [then]


  [ifdef] SYSCFG_VREFBUF_SYSCFG_C2IMR2_DEF
    \
    \ @brief CPU2 interrupt mask register 1
    \ Address offset: 0x10C
    \ Reset value: 0x00000000
    \
    $00 constant SYSCFG_VREFBUF_DMA1_CH1_IM     \ [0x00] Peripheral DMA1 CH1 interrupt mask to CPU2
    $01 constant SYSCFG_VREFBUF_DMA1_CH2_IM     \ [0x01] Peripheral DMA1 CH2 interrupt mask to CPU2
    $02 constant SYSCFG_VREFBUF_DMA1_CH3_IM     \ [0x02] Peripheral DMA1 CH3 interrupt mask to CPU2
    $03 constant SYSCFG_VREFBUF_DMA1_CH4_IM     \ [0x03] Peripheral DMA1 CH4 interrupt mask to CPU2
    $04 constant SYSCFG_VREFBUF_DMA1_CH5_IM     \ [0x04] Peripheral DMA1 CH5 interrupt mask to CPU2
    $05 constant SYSCFG_VREFBUF_DMA1_CH6_IM     \ [0x05] Peripheral DMA1 CH6 interrupt mask to CPU2
    $06 constant SYSCFG_VREFBUF_DMA1_CH7_IM     \ [0x06] Peripheral DMA1 CH7 interrupt mask to CPU2
    $08 constant SYSCFG_VREFBUF_DMA2_CH1_IM     \ [0x08] Peripheral DMA2 CH1 interrupt mask to CPU1
    $09 constant SYSCFG_VREFBUF_DMA2_CH2_IM     \ [0x09] Peripheral DMA2 CH2 interrupt mask to CPU1
    $0a constant SYSCFG_VREFBUF_DMA2_CH3_IM     \ [0x0a] Peripheral DMA2 CH3 interrupt mask to CPU1
    $0b constant SYSCFG_VREFBUF_DMA2_CH4_IM     \ [0x0b] Peripheral DMA2 CH4 interrupt mask to CPU1
    $0c constant SYSCFG_VREFBUF_DMA2_CH5_IM     \ [0x0c] Peripheral DMA2 CH5 interrupt mask to CPU1
    $0d constant SYSCFG_VREFBUF_DMA2_CH6_IM     \ [0x0d] Peripheral DMA2 CH6 interrupt mask to CPU1
    $0e constant SYSCFG_VREFBUF_DMA2_CH7_IM     \ [0x0e] Peripheral DMA2 CH7 interrupt mask to CPU1
    $0f constant SYSCFG_VREFBUF_DMAM_UX1_IM     \ [0x0f] Peripheral DMAM UX1 interrupt mask to CPU1
    $10 constant SYSCFG_VREFBUF_PVM1IM          \ [0x10] Peripheral PVM1IM interrupt mask to CPU1
    $12 constant SYSCFG_VREFBUF_PVM3IM          \ [0x12] Peripheral PVM3IM interrupt mask to CPU1
    $14 constant SYSCFG_VREFBUF_PVDIM           \ [0x14] Peripheral PVDIM interrupt mask to CPU1
    $15 constant SYSCFG_VREFBUF_TSCIM           \ [0x15] Peripheral TSCIM interrupt mask to CPU1
    $16 constant SYSCFG_VREFBUF_LCDIM           \ [0x16] Peripheral LCDIM interrupt mask to CPU1
  [then]


  [ifdef] SYSCFG_VREFBUF_SYSCFG_SIPCR_DEF
    \
    \ @brief secure IP control register
    \ Address offset: 0x110
    \ Reset value: 0x00000000
    \
    $00 constant SYSCFG_VREFBUF_SAES1           \ [0x00] Enable AES1 KEY[7:0] security.
    $01 constant SYSCFG_VREFBUF_SAES2           \ [0x01] Enable AES2 security.
    $02 constant SYSCFG_VREFBUF_SPKA            \ [0x02] Enable PKA security
    $03 constant SYSCFG_VREFBUF_SRNG            \ [0x03] Enable True RNG security
  [then]

  \
  \ @brief SYSCFG_VREFBUF
  \
  $00 constant SYSCFG_VREFBUF_SYSCFG_MEMRMP    \ memory remap register
  $04 constant SYSCFG_VREFBUF_SYSCFG_CFGR1    \ configuration register 1
  $08 constant SYSCFG_VREFBUF_SYSCFG_EXTICR1    \ external interrupt configuration register 1
  $0C constant SYSCFG_VREFBUF_SYSCFG_EXTICR2    \ external interrupt configuration register 2
  $10 constant SYSCFG_VREFBUF_SYSCFG_EXTICR3    \ external interrupt configuration register 3
  $14 constant SYSCFG_VREFBUF_SYSCFG_EXTICR4    \ external interrupt configuration register 4
  $18 constant SYSCFG_VREFBUF_SYSCFG_SCSR    \ SCSR
  $1C constant SYSCFG_VREFBUF_SYSCFG_CFGR2    \ CFGR2
  $20 constant SYSCFG_VREFBUF_SYSCFG_SWPR    \ SRAM2 write protection register
  $24 constant SYSCFG_VREFBUF_SYSCFG_SKR    \ SKR
  $28 constant SYSCFG_VREFBUF_SYSCFG_SWPR2    \ SRAM2 write protection register 2
  $30 constant SYSCFG_VREFBUF_VREFBUF_CSR    \ VREF control and status register
  $34 constant SYSCFG_VREFBUF_VREFBUF_CCR    \ calibration control register
  $100 constant SYSCFG_VREFBUF_SYSCFG_IMR1    \ CPU1 interrupt mask register 1
  $104 constant SYSCFG_VREFBUF_SYSCFG_IMR2    \ CPU1 interrupt mask register 2
  $108 constant SYSCFG_VREFBUF_SYSCFG_C2IMR1    \ CPU2 interrupt mask register 1
  $10C constant SYSCFG_VREFBUF_SYSCFG_C2IMR2    \ CPU2 interrupt mask register 1
  $110 constant SYSCFG_VREFBUF_SYSCFG_SIPCR    \ secure IP control register

: SYSCFG_VREFBUF_DEF ; [then]
