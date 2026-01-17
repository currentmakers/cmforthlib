\
\ @file syscfg_comp_opamp.fs
\ @brief System configuration controller _Comparator and Operational amplifier
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


  [ifdef] SYSCFG_COMP_OPAMP_COMP1_CSR_DEF
    \
    \ @brief control and status register
    \ Address offset: 0x1C
    \ Reset value: 0x00000000
    \
    $00 constant SYSCFG_COMP_OPAMP_COMP1EN      \ [0x00] Comparator 1 enable
    $01 constant SYSCFG_COMP_OPAMP_COMP1_INP_DAC     \ [0x01] COMP1_INP_DAC
    $02 constant SYSCFG_COMP_OPAMP_COMP1MODE    \ [0x02 : 2] Comparator 1 mode
    $04 constant SYSCFG_COMP_OPAMP_COMP1INSEL   \ [0x04 : 3] Comparator 1 inverting input selection
    $0a constant SYSCFG_COMP_OPAMP_COMP1_OUT_SEL     \ [0x0a : 4] Comparator 1 output selection
    $0f constant SYSCFG_COMP_OPAMP_COMP1POL     \ [0x0f] Comparator 1 output polarity
    $10 constant SYSCFG_COMP_OPAMP_COMP1HYST    \ [0x10 : 2] Comparator 1 hysteresis
    $12 constant SYSCFG_COMP_OPAMP_COMP1_BLANKING     \ [0x12 : 3] Comparator 1 blanking source
    $1e constant SYSCFG_COMP_OPAMP_COMP1OUT     \ [0x1e] Comparator 1 output
    $1f constant SYSCFG_COMP_OPAMP_COMP1LOCK    \ [0x1f] Comparator 1 lock
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


  [ifdef] SYSCFG_COMP_OPAMP_COMP3_CSR_DEF
    \
    \ @brief control and status register
    \ Address offset: 0x24
    \ Reset value: 0x00000000
    \
    $00 constant SYSCFG_COMP_OPAMP_COMP3EN      \ [0x00] Comparator 3 enable
    $02 constant SYSCFG_COMP_OPAMP_COMP3MODE    \ [0x02 : 2] Comparator 3 mode
    $04 constant SYSCFG_COMP_OPAMP_COMP3INSEL   \ [0x04 : 3] Comparator 3 inverting input selection
    $07 constant SYSCFG_COMP_OPAMP_COMP3INPSEL  \ [0x07] Comparator 3 non inverted input selection
    $0a constant SYSCFG_COMP_OPAMP_COMP3_OUT_SEL     \ [0x0a : 4] Comparator 3 output selection
    $0f constant SYSCFG_COMP_OPAMP_COMP3POL     \ [0x0f] Comparator 3 output polarity
    $10 constant SYSCFG_COMP_OPAMP_COMP3HYST    \ [0x10 : 2] Comparator 3 hysteresis
    $12 constant SYSCFG_COMP_OPAMP_COMP3_BLANKING     \ [0x12 : 3] Comparator 3 blanking source
    $1e constant SYSCFG_COMP_OPAMP_COMP3OUT     \ [0x1e] Comparator 3 output
    $1f constant SYSCFG_COMP_OPAMP_COMP3LOCK    \ [0x1f] Comparator 3 lock
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


  [ifdef] SYSCFG_COMP_OPAMP_COMP5_CSR_DEF
    \
    \ @brief control and status register
    \ Address offset: 0x2C
    \ Reset value: 0x00000000
    \
    $00 constant SYSCFG_COMP_OPAMP_COMP5EN      \ [0x00] Comparator 5 enable
    $02 constant SYSCFG_COMP_OPAMP_COMP5MODE    \ [0x02 : 2] Comparator 5 mode
    $04 constant SYSCFG_COMP_OPAMP_COMP5INSEL   \ [0x04 : 3] Comparator 5 inverting input selection
    $07 constant SYSCFG_COMP_OPAMP_COMP5INPSEL  \ [0x07] Comparator 5 non inverted input selection
    $0a constant SYSCFG_COMP_OPAMP_COMP5_OUT_SEL     \ [0x0a : 4] Comparator 5 output selection
    $0f constant SYSCFG_COMP_OPAMP_COMP5POL     \ [0x0f] Comparator 5 output polarity
    $10 constant SYSCFG_COMP_OPAMP_COMP5HYST    \ [0x10 : 2] Comparator 5 hysteresis
    $12 constant SYSCFG_COMP_OPAMP_COMP5_BLANKING     \ [0x12 : 3] Comparator 5 blanking source
    $1e constant SYSCFG_COMP_OPAMP_COMP5OUT     \ [0x1e] Comparator51 output
    $1f constant SYSCFG_COMP_OPAMP_COMP5LOCK    \ [0x1f] Comparator 5 lock
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


  [ifdef] SYSCFG_COMP_OPAMP_COMP7_CSR_DEF
    \
    \ @brief control and status register
    \ Address offset: 0x34
    \ Reset value: 0x00000000
    \
    $00 constant SYSCFG_COMP_OPAMP_COMP7EN      \ [0x00] Comparator 7 enable
    $02 constant SYSCFG_COMP_OPAMP_COMP7MODE    \ [0x02 : 2] Comparator 7 mode
    $04 constant SYSCFG_COMP_OPAMP_COMP7INSEL   \ [0x04 : 3] Comparator 7 inverting input selection
    $07 constant SYSCFG_COMP_OPAMP_COMP7INPSEL  \ [0x07] Comparator 7 non inverted input selection
    $0a constant SYSCFG_COMP_OPAMP_COMP7_OUT_SEL     \ [0x0a : 4] Comparator 7 output selection
    $0f constant SYSCFG_COMP_OPAMP_COMP7POL     \ [0x0f] Comparator 7 output polarity
    $10 constant SYSCFG_COMP_OPAMP_COMP7HYST    \ [0x10 : 2] Comparator 7 hysteresis
    $12 constant SYSCFG_COMP_OPAMP_COMP7_BLANKING     \ [0x12 : 3] Comparator 7 blanking source
    $1e constant SYSCFG_COMP_OPAMP_COMP7OUT     \ [0x1e] Comparator 7 output
    $1f constant SYSCFG_COMP_OPAMP_COMP7LOCK    \ [0x1f] Comparator 7 lock
  [then]


  [ifdef] SYSCFG_COMP_OPAMP_OPAMP1_CSR_DEF
    \
    \ @brief control register
    \ Address offset: 0x38
    \ Reset value: 0x00000000
    \
    $00 constant SYSCFG_COMP_OPAMP_OPAMP1_EN    \ [0x00] OPAMP1 enable
    $01 constant SYSCFG_COMP_OPAMP_FORCE_VP     \ [0x01] FORCE_VP
    $02 constant SYSCFG_COMP_OPAMP_VP_SEL       \ [0x02 : 2] OPAMP1 Non inverting input selection
    $05 constant SYSCFG_COMP_OPAMP_VM_SEL       \ [0x05 : 2] OPAMP1 inverting input selection
    $07 constant SYSCFG_COMP_OPAMP_TCM_EN       \ [0x07] Timer controlled Mux mode enable
    $08 constant SYSCFG_COMP_OPAMP_VMS_SEL      \ [0x08] OPAMP1 inverting input secondary selection
    $09 constant SYSCFG_COMP_OPAMP_VPS_SEL      \ [0x09 : 2] OPAMP1 Non inverting input secondary selection
    $0b constant SYSCFG_COMP_OPAMP_CALON        \ [0x0b] Calibration mode enable
    $0c constant SYSCFG_COMP_OPAMP_CALSEL       \ [0x0c : 2] Calibration selection
    $0e constant SYSCFG_COMP_OPAMP_PGA_GAIN     \ [0x0e : 4] Gain in PGA mode
    $12 constant SYSCFG_COMP_OPAMP_USER_TRIM    \ [0x12] User trimming enable
    $13 constant SYSCFG_COMP_OPAMP_TRIMOFFSETP  \ [0x13 : 5] Offset trimming value (PMOS)
    $18 constant SYSCFG_COMP_OPAMP_TRIMOFFSETN  \ [0x18 : 5] Offset trimming value (NMOS)
    $1d constant SYSCFG_COMP_OPAMP_TSTREF       \ [0x1d] TSTREF
    $1e constant SYSCFG_COMP_OPAMP_OUTCAL       \ [0x1e] OPAMP 1 ouput status flag
    $1f constant SYSCFG_COMP_OPAMP_LOCK         \ [0x1f] OPAMP 1 lock
  [then]


  [ifdef] SYSCFG_COMP_OPAMP_OPAMP2_CSR_DEF
    \
    \ @brief control register
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
    $0c constant SYSCFG_COMP_OPAMP_CALSEL       \ [0x0c : 2] Calibration selection
    $0e constant SYSCFG_COMP_OPAMP_PGA_GAIN     \ [0x0e : 4] Gain in PGA mode
    $12 constant SYSCFG_COMP_OPAMP_USER_TRIM    \ [0x12] User trimming enable
    $13 constant SYSCFG_COMP_OPAMP_TRIMOFFSETP  \ [0x13 : 5] Offset trimming value (PMOS)
    $18 constant SYSCFG_COMP_OPAMP_TRIMOFFSETN  \ [0x18 : 5] Offset trimming value (NMOS)
    $1d constant SYSCFG_COMP_OPAMP_TSTREF       \ [0x1d] TSTREF
    $1e constant SYSCFG_COMP_OPAMP_OUTCAL       \ [0x1e] OPAMP 2 ouput status flag
    $1f constant SYSCFG_COMP_OPAMP_LOCK         \ [0x1f] OPAMP 2 lock
  [then]


  [ifdef] SYSCFG_COMP_OPAMP_OPAMP3_CSR_DEF
    \
    \ @brief control register
    \ Address offset: 0x40
    \ Reset value: 0x00000000
    \
    $00 constant SYSCFG_COMP_OPAMP_OPAMP3EN     \ [0x00] OPAMP3 enable
    $01 constant SYSCFG_COMP_OPAMP_FORCE_VP     \ [0x01] FORCE_VP
    $02 constant SYSCFG_COMP_OPAMP_VP_SEL       \ [0x02 : 2] OPAMP3 Non inverting input selection
    $05 constant SYSCFG_COMP_OPAMP_VM_SEL       \ [0x05 : 2] OPAMP3 inverting input selection
    $07 constant SYSCFG_COMP_OPAMP_TCM_EN       \ [0x07] Timer controlled Mux mode enable
    $08 constant SYSCFG_COMP_OPAMP_VMS_SEL      \ [0x08] OPAMP3 inverting input secondary selection
    $09 constant SYSCFG_COMP_OPAMP_VPS_SEL      \ [0x09 : 2] OPAMP3 Non inverting input secondary selection
    $0b constant SYSCFG_COMP_OPAMP_CALON        \ [0x0b] Calibration mode enable
    $0c constant SYSCFG_COMP_OPAMP_CALSEL       \ [0x0c : 2] Calibration selection
    $0e constant SYSCFG_COMP_OPAMP_PGA_GAIN     \ [0x0e : 4] Gain in PGA mode
    $12 constant SYSCFG_COMP_OPAMP_USER_TRIM    \ [0x12] User trimming enable
    $13 constant SYSCFG_COMP_OPAMP_TRIMOFFSETP  \ [0x13 : 5] Offset trimming value (PMOS)
    $18 constant SYSCFG_COMP_OPAMP_TRIMOFFSETN  \ [0x18 : 5] Offset trimming value (NMOS)
    $1d constant SYSCFG_COMP_OPAMP_TSTREF       \ [0x1d] TSTREF
    $1e constant SYSCFG_COMP_OPAMP_OUTCAL       \ [0x1e] OPAMP 3 ouput status flag
    $1f constant SYSCFG_COMP_OPAMP_LOCK         \ [0x1f] OPAMP 3 lock
  [then]


  [ifdef] SYSCFG_COMP_OPAMP_OPAMP4_CSR_DEF
    \
    \ @brief control register
    \ Address offset: 0x44
    \ Reset value: 0x00000000
    \
    $00 constant SYSCFG_COMP_OPAMP_OPAMP4EN     \ [0x00] OPAMP4 enable
    $01 constant SYSCFG_COMP_OPAMP_FORCE_VP     \ [0x01] FORCE_VP
    $02 constant SYSCFG_COMP_OPAMP_VP_SEL       \ [0x02 : 2] OPAMP4 Non inverting input selection
    $05 constant SYSCFG_COMP_OPAMP_VM_SEL       \ [0x05 : 2] OPAMP4 inverting input selection
    $07 constant SYSCFG_COMP_OPAMP_TCM_EN       \ [0x07] Timer controlled Mux mode enable
    $08 constant SYSCFG_COMP_OPAMP_VMS_SEL      \ [0x08] OPAMP4 inverting input secondary selection
    $09 constant SYSCFG_COMP_OPAMP_VPS_SEL      \ [0x09 : 2] OPAMP4 Non inverting input secondary selection
    $0b constant SYSCFG_COMP_OPAMP_CALON        \ [0x0b] Calibration mode enable
    $0c constant SYSCFG_COMP_OPAMP_CALSEL       \ [0x0c : 2] Calibration selection
    $0e constant SYSCFG_COMP_OPAMP_PGA_GAIN     \ [0x0e : 4] Gain in PGA mode
    $12 constant SYSCFG_COMP_OPAMP_USER_TRIM    \ [0x12] User trimming enable
    $13 constant SYSCFG_COMP_OPAMP_TRIMOFFSETP  \ [0x13 : 5] Offset trimming value (PMOS)
    $18 constant SYSCFG_COMP_OPAMP_TRIMOFFSETN  \ [0x18 : 5] Offset trimming value (NMOS)
    $1d constant SYSCFG_COMP_OPAMP_TSTREF       \ [0x1d] TSTREF
    $1e constant SYSCFG_COMP_OPAMP_OUTCAL       \ [0x1e] OPAMP 4 ouput status flag
    $1f constant SYSCFG_COMP_OPAMP_LOCK         \ [0x1f] OPAMP 4 lock
  [then]


  [ifdef] SYSCFG_COMP_OPAMP_SYSCFG_CFGR4_DEF
    \
    \ @brief SYSCFG configuration register 4
    \ Address offset: 0x48
    \ Reset value: 0x00000000
    \
    $00 constant SYSCFG_COMP_OPAMP_ADC12_EXT2_RMP     \ [0x00] Controls the Input trigger of ADC12 regular channel EXT2
    $01 constant SYSCFG_COMP_OPAMP_ADC12_EXT3_RMP     \ [0x01] Controls the Input trigger of ADC12 regular channel EXT3
    $02 constant SYSCFG_COMP_OPAMP_ADC12_EXT5_RMP     \ [0x02] Controls the Input trigger of ADC12 regular channel EXT5
    $03 constant SYSCFG_COMP_OPAMP_ADC12_EXT13_RMP     \ [0x03] Controls the Input trigger of ADC12 regular channel EXT13
    $04 constant SYSCFG_COMP_OPAMP_ADC12_EXT15_RMP     \ [0x04] Controls the Input trigger of ADC12 regular channel EXT15
    $05 constant SYSCFG_COMP_OPAMP_ADC12_JEXT3_RMP     \ [0x05] Controls the Input trigger of ADC12 injected channel EXTI3
    $06 constant SYSCFG_COMP_OPAMP_ADC12_JEXT6_RMP     \ [0x06] Controls the Input trigger of ADC12 injected channel EXTI6
    $07 constant SYSCFG_COMP_OPAMP_ADC12_JEXT13_RMP     \ [0x07] Controls the Input trigger of ADC12 injected channel EXTI13
    $08 constant SYSCFG_COMP_OPAMP_ADC34_EXT5_RMP     \ [0x08] Controls the Input trigger of ADC34 regular channel EXT5
    $09 constant SYSCFG_COMP_OPAMP_ADC34_EXT6_RMP     \ [0x09] Controls the Input trigger of ADC34 regular channel EXT6
    $0a constant SYSCFG_COMP_OPAMP_ADC34_EXT15_RMP     \ [0x0a] Controls the Input trigger of ADC34 regular channel EXT15
    $0b constant SYSCFG_COMP_OPAMP_ADC34_JEXT5_RMP     \ [0x0b] Controls the Input trigger of ADC34 injected channel JEXT5
    $0c constant SYSCFG_COMP_OPAMP_ADC34_JEXT11_RMP     \ [0x0c] Controls the Input trigger of ADC34 injected channel JEXT11
    $0d constant SYSCFG_COMP_OPAMP_ADC34_JEXT14_RMP     \ [0x0d] Controls the Input trigger of ADC34 injected channel JEXT14
  [then]


  [ifdef] SYSCFG_COMP_OPAMP_SYSCFG_CFGR3_DEF
    \
    \ @brief SYSCFG configuration register 3
    \ Address offset: 0x50
    \ Reset value: 0x00000000
    \
    $00 constant SYSCFG_COMP_OPAMP_SPI1_RX_DMA_RMP     \ [0x00 : 2] SPI1_RX DMA remapping bit
    $02 constant SYSCFG_COMP_OPAMP_SPI1_TX_DMA_RMP     \ [0x02 : 2] SPI1_TX DMA remapping bit
    $04 constant SYSCFG_COMP_OPAMP_I2C1_RX_DMA_RMP     \ [0x04 : 2] I2C1_RX DMA remapping bit
    $06 constant SYSCFG_COMP_OPAMP_I2C1_TX_DMA_RMP     \ [0x06 : 2] I2C1_TX DMA remapping bit
    $08 constant SYSCFG_COMP_OPAMP_ADC2_DMA_RMP     \ [0x08 : 2] ADC2 DMA channel remapping bit
  [then]

  \
  \ @brief System configuration controller _Comparator and Operational amplifier
  \
  $00 constant SYSCFG_COMP_OPAMP_SYSCFG_CFGR1    \ configuration register 1
  $04 constant SYSCFG_COMP_OPAMP_SYSCFG_RCR    \ CCM SRAM protection register
  $08 constant SYSCFG_COMP_OPAMP_SYSCFG_EXTICR1    \ external interrupt configuration register 1
  $0C constant SYSCFG_COMP_OPAMP_SYSCFG_EXTICR2    \ external interrupt configuration register 2
  $10 constant SYSCFG_COMP_OPAMP_SYSCFG_EXTICR3    \ external interrupt configuration register 3
  $14 constant SYSCFG_COMP_OPAMP_SYSCFG_EXTICR4    \ external interrupt configuration register 4
  $18 constant SYSCFG_COMP_OPAMP_SYSCFG_CFGR2    \ configuration register 2
  $1C constant SYSCFG_COMP_OPAMP_COMP1_CSR    \ control and status register
  $20 constant SYSCFG_COMP_OPAMP_COMP2_CSR    \ control and status register
  $24 constant SYSCFG_COMP_OPAMP_COMP3_CSR    \ control and status register
  $28 constant SYSCFG_COMP_OPAMP_COMP4_CSR    \ control and status register
  $2C constant SYSCFG_COMP_OPAMP_COMP5_CSR    \ control and status register
  $30 constant SYSCFG_COMP_OPAMP_COMP6_CSR    \ control and status register
  $34 constant SYSCFG_COMP_OPAMP_COMP7_CSR    \ control and status register
  $38 constant SYSCFG_COMP_OPAMP_OPAMP1_CSR    \ control register
  $3C constant SYSCFG_COMP_OPAMP_OPAMP2_CSR    \ control register
  $40 constant SYSCFG_COMP_OPAMP_OPAMP3_CSR    \ control register
  $44 constant SYSCFG_COMP_OPAMP_OPAMP4_CSR    \ control register
  $48 constant SYSCFG_COMP_OPAMP_SYSCFG_CFGR4    \ SYSCFG configuration register 4
  $50 constant SYSCFG_COMP_OPAMP_SYSCFG_CFGR3    \ SYSCFG configuration register 3

: SYSCFG_COMP_OPAMP_DEF ; [then]
