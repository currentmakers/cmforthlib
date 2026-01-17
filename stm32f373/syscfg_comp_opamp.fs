\
\ @file syscfg_comp_opamp.fs
\ @brief System configuration controller
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] SYSCFG_COMP_OPAMP_DEF

  [ifdef] SYSCFG_COMP_OPAMP_SYSCFG_CFGR1_DEF
    \
    \ @brief configuration register 1
    \ Address offset: 0x00
    \ Reset value: 0x00000000
    \
    $00 constant SYSCFG_COMP_OPAMP_MEM_MODE     \ [0x00 : 2] Memory mapping selection bits
    $05 constant SYSCFG_COMP_OPAMP_USB_IT_RMP   \ [0x05] USB interrupt remap
    $06 constant SYSCFG_COMP_OPAMP_TIM1_ITR_RMP     \ [0x06] Timer 1 ITR3 selection
    $07 constant SYSCFG_COMP_OPAMP_DAC_TRIG_RMP     \ [0x07] DAC trigger remap (when TSEL = 001)
    $08 constant SYSCFG_COMP_OPAMP_ADC24_DMA_RMP     \ [0x08] ADC24 DMA remapping bit
    $0b constant SYSCFG_COMP_OPAMP_TIM16_DMA_RMP     \ [0x0b] TIM16 DMA request remapping bit
    $0c constant SYSCFG_COMP_OPAMP_TIM17_DMA_RMP     \ [0x0c] TIM17 DMA request remapping bit
    $0d constant SYSCFG_COMP_OPAMP_TIM6_DAC1_DMA_RMP     \ [0x0d] TIM6 and DAC1 DMA request remapping bit
    $0e constant SYSCFG_COMP_OPAMP_TIM7_DAC2_DMA_RMP     \ [0x0e] TIM7 and DAC2 DMA request remapping bit
    $10 constant SYSCFG_COMP_OPAMP_I2C_PB6_FM   \ [0x10] Fast Mode Plus (FM+) driving capability activation bits.
    $11 constant SYSCFG_COMP_OPAMP_I2C_PB7_FM   \ [0x11] Fast Mode Plus (FM+) driving capability activation bits.
    $12 constant SYSCFG_COMP_OPAMP_I2C_PB8_FM   \ [0x12] Fast Mode Plus (FM+) driving capability activation bits.
    $13 constant SYSCFG_COMP_OPAMP_I2C_PB9_FM   \ [0x13] Fast Mode Plus (FM+) driving capability activation bits.
    $14 constant SYSCFG_COMP_OPAMP_I2C1_FM      \ [0x14] I2C1 Fast Mode Plus
    $15 constant SYSCFG_COMP_OPAMP_I2C2_FM      \ [0x15] I2C2 Fast Mode Plus
    $16 constant SYSCFG_COMP_OPAMP_ENCODER_MODE     \ [0x16 : 2] Encoder mode
    $1a constant SYSCFG_COMP_OPAMP_FPU_IT       \ [0x1a : 6] Interrupt enable bits from FPU
  [then]


  [ifdef] SYSCFG_COMP_OPAMP_SYSCFG_RCR_DEF
    \
    \ @brief CCM SRAM protection register
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $00 constant SYSCFG_COMP_OPAMP_PAGE0_WP     \ [0x00] CCM SRAM page write protection bit
    $01 constant SYSCFG_COMP_OPAMP_PAGE1_WP     \ [0x01] CCM SRAM page write protection bit
    $02 constant SYSCFG_COMP_OPAMP_PAGE2_WP     \ [0x02] CCM SRAM page write protection bit
    $03 constant SYSCFG_COMP_OPAMP_PAGE3_WP     \ [0x03] CCM SRAM page write protection bit
    $04 constant SYSCFG_COMP_OPAMP_PAGE4_WP     \ [0x04] CCM SRAM page write protection bit
    $05 constant SYSCFG_COMP_OPAMP_PAGE5_WP     \ [0x05] CCM SRAM page write protection bit
    $06 constant SYSCFG_COMP_OPAMP_PAGE6_WP     \ [0x06] CCM SRAM page write protection bit
    $07 constant SYSCFG_COMP_OPAMP_PAGE7_WP     \ [0x07] CCM SRAM page write protection bit
  [then]


  [ifdef] SYSCFG_COMP_OPAMP_SYSCFG_EXTICR1_DEF
    \
    \ @brief external interrupt configuration register 1
    \ Address offset: 0x08
    \ Reset value: 0x00000000
    \
    $00 constant SYSCFG_COMP_OPAMP_EXTI0        \ [0x00 : 4] EXTI 0 configuration bits
    $04 constant SYSCFG_COMP_OPAMP_EXTI1        \ [0x04 : 4] EXTI 1 configuration bits
    $08 constant SYSCFG_COMP_OPAMP_EXTI2        \ [0x08 : 4] EXTI 2 configuration bits
    $0c constant SYSCFG_COMP_OPAMP_EXTI3        \ [0x0c : 4] EXTI 3 configuration bits
  [then]


  [ifdef] SYSCFG_COMP_OPAMP_SYSCFG_EXTICR2_DEF
    \
    \ @brief external interrupt configuration register 2
    \ Address offset: 0x0C
    \ Reset value: 0x00000000
    \
    $00 constant SYSCFG_COMP_OPAMP_EXTI4        \ [0x00 : 4] EXTI 4 configuration bits
    $04 constant SYSCFG_COMP_OPAMP_EXTI5        \ [0x04 : 4] EXTI 5 configuration bits
    $08 constant SYSCFG_COMP_OPAMP_EXTI6        \ [0x08 : 4] EXTI 6 configuration bits
    $0c constant SYSCFG_COMP_OPAMP_EXTI7        \ [0x0c : 4] EXTI 7 configuration bits
  [then]


  [ifdef] SYSCFG_COMP_OPAMP_SYSCFG_EXTICR3_DEF
    \
    \ @brief external interrupt configuration register 3
    \ Address offset: 0x10
    \ Reset value: 0x00000000
    \
    $00 constant SYSCFG_COMP_OPAMP_EXTI8        \ [0x00 : 4] EXTI 8 configuration bits
    $04 constant SYSCFG_COMP_OPAMP_EXTI9        \ [0x04 : 4] EXTI 9 configuration bits
    $08 constant SYSCFG_COMP_OPAMP_EXTI10       \ [0x08 : 4] EXTI 10 configuration bits
    $0c constant SYSCFG_COMP_OPAMP_EXTI11       \ [0x0c : 4] EXTI 11 configuration bits
  [then]


  [ifdef] SYSCFG_COMP_OPAMP_SYSCFG_EXTICR4_DEF
    \
    \ @brief external interrupt configuration register 4
    \ Address offset: 0x14
    \ Reset value: 0x00000000
    \
    $00 constant SYSCFG_COMP_OPAMP_EXTI12       \ [0x00 : 4] EXTI 12 configuration bits
    $04 constant SYSCFG_COMP_OPAMP_EXTI13       \ [0x04 : 4] EXTI 13 configuration bits
    $08 constant SYSCFG_COMP_OPAMP_EXTI14       \ [0x08 : 4] EXTI 14 configuration bits
    $0c constant SYSCFG_COMP_OPAMP_EXTI15       \ [0x0c : 4] EXTI 15 configuration bits
  [then]


  [ifdef] SYSCFG_COMP_OPAMP_SYSCFG_CFGR2_DEF
    \
    \ @brief configuration register 2
    \ Address offset: 0x18
    \ Reset value: 0x00000000
    \
    $00 constant SYSCFG_COMP_OPAMP_LOCUP_LOCK   \ [0x00] Cortex-M0 LOCKUP bit enable bit
    $01 constant SYSCFG_COMP_OPAMP_SRAM_PARITY_LOCK     \ [0x01] SRAM parity lock bit
    $02 constant SYSCFG_COMP_OPAMP_PVD_LOCK     \ [0x02] PVD lock enable bit
    $04 constant SYSCFG_COMP_OPAMP_BYP_ADD_PAR  \ [0x04] Bypass address bit 29 in parity calculation
    $08 constant SYSCFG_COMP_OPAMP_SRAM_PEF     \ [0x08] SRAM parity flag
  [then]


  [ifdef] SYSCFG_COMP_OPAMP_COMP2_CSR_DEF
    \
    \ @brief control and status register
    \ Address offset: 0x20
    \ Reset value: 0x00000000
    \
    $00 constant SYSCFG_COMP_OPAMP_COMP2EN      \ [0x00] Comparator 2 enable
    $02 constant SYSCFG_COMP_OPAMP_COMP2MODE    \ [0x02 : 2] Comparator 2 mode
    $04 constant SYSCFG_COMP_OPAMP_COMP2INSEL   \ [0x04 : 3] Comparator 2 inverting input selection
    $07 constant SYSCFG_COMP_OPAMP_COMP2INPSEL  \ [0x07] Comparator 2 non inverted input selection
    $09 constant SYSCFG_COMP_OPAMP_COMP2INMSEL  \ [0x09] Comparator 1inverting input selection
    $0a constant SYSCFG_COMP_OPAMP_COMP2_OUT_SEL     \ [0x0a : 4] Comparator 2 output selection
    $0f constant SYSCFG_COMP_OPAMP_COMP2POL     \ [0x0f] Comparator 2 output polarity
    $10 constant SYSCFG_COMP_OPAMP_COMP2HYST    \ [0x10 : 2] Comparator 2 hysteresis
    $12 constant SYSCFG_COMP_OPAMP_COMP2_BLANKING     \ [0x12 : 3] Comparator 2 blanking source
    $1e constant SYSCFG_COMP_OPAMP_COMP2OUT     \ [0x1e] Comparator 2 output
    $1f constant SYSCFG_COMP_OPAMP_COMP2LOCK    \ [0x1f] Comparator 2 lock
  [then]


  [ifdef] SYSCFG_COMP_OPAMP_COMP4_CSR_DEF
    \
    \ @brief control and status register
    \ Address offset: 0x28
    \ Reset value: 0x00000000
    \
    $00 constant SYSCFG_COMP_OPAMP_COMP4EN      \ [0x00] Comparator 4 enable
    $02 constant SYSCFG_COMP_OPAMP_COMP4MODE    \ [0x02 : 2] Comparator 4 mode
    $04 constant SYSCFG_COMP_OPAMP_COMP4INSEL   \ [0x04 : 3] Comparator 4 inverting input selection
    $07 constant SYSCFG_COMP_OPAMP_COMP4INPSEL  \ [0x07] Comparator 4 non inverted input selection
    $09 constant SYSCFG_COMP_OPAMP_COM4WINMODE  \ [0x09] Comparator 4 window mode
    $0a constant SYSCFG_COMP_OPAMP_COMP4_OUT_SEL     \ [0x0a : 4] Comparator 4 output selection
    $0f constant SYSCFG_COMP_OPAMP_COMP4POL     \ [0x0f] Comparator 4 output polarity
    $10 constant SYSCFG_COMP_OPAMP_COMP4HYST    \ [0x10 : 2] Comparator 4 hysteresis
    $12 constant SYSCFG_COMP_OPAMP_COMP4_BLANKING     \ [0x12 : 3] Comparator 4 blanking source
    $1e constant SYSCFG_COMP_OPAMP_COMP4OUT     \ [0x1e] Comparator 4 output
    $1f constant SYSCFG_COMP_OPAMP_COMP4LOCK    \ [0x1f] Comparator 4 lock
  [then]


  [ifdef] SYSCFG_COMP_OPAMP_COMP6_CSR_DEF
    \
    \ @brief control and status register
    \ Address offset: 0x30
    \ Reset value: 0x00000000
    \
    $00 constant SYSCFG_COMP_OPAMP_COMP6EN      \ [0x00] Comparator 6 enable
    $02 constant SYSCFG_COMP_OPAMP_COMP6MODE    \ [0x02 : 2] Comparator 6 mode
    $04 constant SYSCFG_COMP_OPAMP_COMP6INSEL   \ [0x04 : 3] Comparator 6 inverting input selection
    $07 constant SYSCFG_COMP_OPAMP_COMP6INPSEL  \ [0x07] Comparator 6 non inverted input selection
    $09 constant SYSCFG_COMP_OPAMP_COM6WINMODE  \ [0x09] Comparator 6 window mode
    $0a constant SYSCFG_COMP_OPAMP_COMP6_OUT_SEL     \ [0x0a : 4] Comparator 6 output selection
    $0f constant SYSCFG_COMP_OPAMP_COMP6POL     \ [0x0f] Comparator 6 output polarity
    $10 constant SYSCFG_COMP_OPAMP_COMP6HYST    \ [0x10 : 2] Comparator 6 hysteresis
    $12 constant SYSCFG_COMP_OPAMP_COMP6_BLANKING     \ [0x12 : 3] Comparator 6 blanking source
    $1e constant SYSCFG_COMP_OPAMP_COMP6OUT     \ [0x1e] Comparator 6 output
    $1f constant SYSCFG_COMP_OPAMP_COMP6LOCK    \ [0x1f] Comparator 6 lock
  [then]


  [ifdef] SYSCFG_COMP_OPAMP_OPAMP2_CSR_DEF
    \
    \ @brief OPAMP2 control register
    \ Address offset: 0x3C
    \ Reset value: 0x00000000
    \
    $00 constant SYSCFG_COMP_OPAMP_OPAMP2EN     \ [0x00] OPAMP2 enable
    $01 constant SYSCFG_COMP_OPAMP_FORCE_VP     \ [0x01] FORCE_VP
    $02 constant SYSCFG_COMP_OPAMP_VP_SEL       \ [0x02 : 2] OPAMP2 Non inverting input selection
    $05 constant SYSCFG_COMP_OPAMP_VM_SEL       \ [0x05 : 2] OPAMP2 inverting input selection
    $07 constant SYSCFG_COMP_OPAMP_TCM_EN       \ [0x07] Timer controlled Mux mode enable
    $08 constant SYSCFG_COMP_OPAMP_VMS_SEL      \ [0x08] OPAMP2 inverting input secondary selection
    $09 constant SYSCFG_COMP_OPAMP_VPS_SEL      \ [0x09 : 2] OPAMP2 Non inverting input secondary selection
    $0b constant SYSCFG_COMP_OPAMP_CALON        \ [0x0b] Calibration mode enable
    $0c constant SYSCFG_COMP_OPAMP_CAL_SEL      \ [0x0c : 2] Calibration selection
    $0e constant SYSCFG_COMP_OPAMP_PGA_GAIN     \ [0x0e : 4] Gain in PGA mode
    $12 constant SYSCFG_COMP_OPAMP_USER_TRIM    \ [0x12] User trimming enable
    $13 constant SYSCFG_COMP_OPAMP_TRIMOFFSETP  \ [0x13 : 5] Offset trimming value (PMOS)
    $18 constant SYSCFG_COMP_OPAMP_TRIMOFFSETN  \ [0x18 : 5] Offset trimming value (NMOS)
    $1d constant SYSCFG_COMP_OPAMP_TSTREF       \ [0x1d] TSTREF
    $1e constant SYSCFG_COMP_OPAMP_OUTCAL       \ [0x1e] OPAMP 2 ouput status flag
    $1f constant SYSCFG_COMP_OPAMP_LOCK         \ [0x1f] OPAMP 2 lock
  [then]


  [ifdef] SYSCFG_COMP_OPAMP_SYSCFG_CFGR3_DEF
    \
    \ @brief configuration register 3
    \ Address offset: 0x50
    \ Reset value: 0x00000000
    \
    $00 constant SYSCFG_COMP_OPAMP_SPI1_RX_DMA_RMP     \ [0x00 : 2] SPI1_RX DMA remapping bit
    $02 constant SYSCFG_COMP_OPAMP_SPI1_TX_DMA_RMP     \ [0x02 : 2] SPI1_TX DMA remapping bit
    $04 constant SYSCFG_COMP_OPAMP_I2C1_RX_DMA_RMP     \ [0x04 : 2] I2C1_RX DMA remapping bit
    $06 constant SYSCFG_COMP_OPAMP_ADC2_DMA_RMP_0     \ [0x06 : 2] ADC2 DMA channel remapping bit
    $09 constant SYSCFG_COMP_OPAMP_ADC2_DMA_RMP_1     \ [0x09] ADC2 DMA controller remapping bit
    $10 constant SYSCFG_COMP_OPAMP_DAC1_TRIG3_RMP     \ [0x10] DAC1_CH1 / DAC1_CH2 Trigger remap
    $11 constant SYSCFG_COMP_OPAMP_DAC1_TRIG5_RMP     \ [0x11] DAC1_CH1 / DAC1_CH2 Trigger remap
  [then]

  \
  \ @brief System configuration controller
  \
  $00 constant SYSCFG_COMP_OPAMP_SYSCFG_CFGR1    \ configuration register 1
  $04 constant SYSCFG_COMP_OPAMP_SYSCFG_RCR    \ CCM SRAM protection register
  $08 constant SYSCFG_COMP_OPAMP_SYSCFG_EXTICR1    \ external interrupt configuration register 1
  $0C constant SYSCFG_COMP_OPAMP_SYSCFG_EXTICR2    \ external interrupt configuration register 2
  $10 constant SYSCFG_COMP_OPAMP_SYSCFG_EXTICR3    \ external interrupt configuration register 3
  $14 constant SYSCFG_COMP_OPAMP_SYSCFG_EXTICR4    \ external interrupt configuration register 4
  $18 constant SYSCFG_COMP_OPAMP_SYSCFG_CFGR2    \ configuration register 2
  $20 constant SYSCFG_COMP_OPAMP_COMP2_CSR    \ control and status register
  $28 constant SYSCFG_COMP_OPAMP_COMP4_CSR    \ control and status register
  $30 constant SYSCFG_COMP_OPAMP_COMP6_CSR    \ control and status register
  $3C constant SYSCFG_COMP_OPAMP_OPAMP2_CSR    \ OPAMP2 control register
  $50 constant SYSCFG_COMP_OPAMP_SYSCFG_CFGR3    \ configuration register 3

: SYSCFG_COMP_OPAMP_DEF ; [then]
