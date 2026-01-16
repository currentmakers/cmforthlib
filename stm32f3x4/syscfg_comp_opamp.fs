\
\ @file syscfg_comp_opamp.fs
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

$00000003 constant SYSCFG_COMP_OPAMP_SYSCFG_CFGR1_MEM_MODE          \ Memory mapping selection bits
$00000020 constant SYSCFG_COMP_OPAMP_SYSCFG_CFGR1_USB_IT_RMP        \ USB interrupt remap
$00000040 constant SYSCFG_COMP_OPAMP_SYSCFG_CFGR1_TIM1_ITR_RMP      \ Timer 1 ITR3 selection
$00000080 constant SYSCFG_COMP_OPAMP_SYSCFG_CFGR1_DAC_TRIG_RMP      \ DAC trigger remap (when TSEL = 001)
$00000100 constant SYSCFG_COMP_OPAMP_SYSCFG_CFGR1_ADC24_DMA_RMP     \ ADC24 DMA remapping bit
$00000800 constant SYSCFG_COMP_OPAMP_SYSCFG_CFGR1_TIM16_DMA_RMP     \ TIM16 DMA request remapping bit
$00001000 constant SYSCFG_COMP_OPAMP_SYSCFG_CFGR1_TIM17_DMA_RMP     \ TIM17 DMA request remapping bit
$00002000 constant SYSCFG_COMP_OPAMP_SYSCFG_CFGR1_TIM6_DAC1_DMA_RMP    \ TIM6 and DAC1 DMA request remapping bit
$00004000 constant SYSCFG_COMP_OPAMP_SYSCFG_CFGR1_TIM7_DAC2_DMA_RMP    \ TIM7 and DAC2 DMA request remapping bit
$00010000 constant SYSCFG_COMP_OPAMP_SYSCFG_CFGR1_I2C_PB6_FM        \ Fast Mode Plus (FM+) driving capability activation bits.
$00020000 constant SYSCFG_COMP_OPAMP_SYSCFG_CFGR1_I2C_PB7_FM        \ Fast Mode Plus (FM+) driving capability activation bits.
$00040000 constant SYSCFG_COMP_OPAMP_SYSCFG_CFGR1_I2C_PB8_FM        \ Fast Mode Plus (FM+) driving capability activation bits.
$00080000 constant SYSCFG_COMP_OPAMP_SYSCFG_CFGR1_I2C_PB9_FM        \ Fast Mode Plus (FM+) driving capability activation bits.
$00100000 constant SYSCFG_COMP_OPAMP_SYSCFG_CFGR1_I2C1_FM           \ I2C1 Fast Mode Plus
$00200000 constant SYSCFG_COMP_OPAMP_SYSCFG_CFGR1_I2C2_FM           \ I2C2 Fast Mode Plus
$00c00000 constant SYSCFG_COMP_OPAMP_SYSCFG_CFGR1_ENCODER_MODE      \ Encoder mode
$fc000000 constant SYSCFG_COMP_OPAMP_SYSCFG_CFGR1_FPU_IT            \ Interrupt enable bits from FPU


\
\ @brief CCM SRAM protection register
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$00000001 constant SYSCFG_COMP_OPAMP_SYSCFG_RCR_PAGE0_WP            \ CCM SRAM page write protection bit
$00000002 constant SYSCFG_COMP_OPAMP_SYSCFG_RCR_PAGE1_WP            \ CCM SRAM page write protection bit
$00000004 constant SYSCFG_COMP_OPAMP_SYSCFG_RCR_PAGE2_WP            \ CCM SRAM page write protection bit
$00000008 constant SYSCFG_COMP_OPAMP_SYSCFG_RCR_PAGE3_WP            \ CCM SRAM page write protection bit
$00000010 constant SYSCFG_COMP_OPAMP_SYSCFG_RCR_PAGE4_WP            \ CCM SRAM page write protection bit
$00000020 constant SYSCFG_COMP_OPAMP_SYSCFG_RCR_PAGE5_WP            \ CCM SRAM page write protection bit
$00000040 constant SYSCFG_COMP_OPAMP_SYSCFG_RCR_PAGE6_WP            \ CCM SRAM page write protection bit
$00000080 constant SYSCFG_COMP_OPAMP_SYSCFG_RCR_PAGE7_WP            \ CCM SRAM page write protection bit


\
\ @brief external interrupt configuration register 1
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$0000000f constant SYSCFG_COMP_OPAMP_SYSCFG_EXTICR1_EXTI0           \ EXTI 0 configuration bits
$000000f0 constant SYSCFG_COMP_OPAMP_SYSCFG_EXTICR1_EXTI1           \ EXTI 1 configuration bits
$00000f00 constant SYSCFG_COMP_OPAMP_SYSCFG_EXTICR1_EXTI2           \ EXTI 2 configuration bits
$0000f000 constant SYSCFG_COMP_OPAMP_SYSCFG_EXTICR1_EXTI3           \ EXTI 3 configuration bits


\
\ @brief external interrupt configuration register 2
\ Address offset: 0x0C
\ Reset value: 0x00000000
\

$0000000f constant SYSCFG_COMP_OPAMP_SYSCFG_EXTICR2_EXTI4           \ EXTI 4 configuration bits
$000000f0 constant SYSCFG_COMP_OPAMP_SYSCFG_EXTICR2_EXTI5           \ EXTI 5 configuration bits
$00000f00 constant SYSCFG_COMP_OPAMP_SYSCFG_EXTICR2_EXTI6           \ EXTI 6 configuration bits
$0000f000 constant SYSCFG_COMP_OPAMP_SYSCFG_EXTICR2_EXTI7           \ EXTI 7 configuration bits


\
\ @brief external interrupt configuration register 3
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$0000000f constant SYSCFG_COMP_OPAMP_SYSCFG_EXTICR3_EXTI8           \ EXTI 8 configuration bits
$000000f0 constant SYSCFG_COMP_OPAMP_SYSCFG_EXTICR3_EXTI9           \ EXTI 9 configuration bits
$00000f00 constant SYSCFG_COMP_OPAMP_SYSCFG_EXTICR3_EXTI10          \ EXTI 10 configuration bits
$0000f000 constant SYSCFG_COMP_OPAMP_SYSCFG_EXTICR3_EXTI11          \ EXTI 11 configuration bits


\
\ @brief external interrupt configuration register 4
\ Address offset: 0x14
\ Reset value: 0x00000000
\

$0000000f constant SYSCFG_COMP_OPAMP_SYSCFG_EXTICR4_EXTI12          \ EXTI 12 configuration bits
$000000f0 constant SYSCFG_COMP_OPAMP_SYSCFG_EXTICR4_EXTI13          \ EXTI 13 configuration bits
$00000f00 constant SYSCFG_COMP_OPAMP_SYSCFG_EXTICR4_EXTI14          \ EXTI 14 configuration bits
$0000f000 constant SYSCFG_COMP_OPAMP_SYSCFG_EXTICR4_EXTI15          \ EXTI 15 configuration bits


\
\ @brief configuration register 2
\ Address offset: 0x18
\ Reset value: 0x00000000
\

$00000001 constant SYSCFG_COMP_OPAMP_SYSCFG_CFGR2_LOCUP_LOCK        \ Cortex-M0 LOCKUP bit enable bit
$00000002 constant SYSCFG_COMP_OPAMP_SYSCFG_CFGR2_SRAM_PARITY_LOCK    \ SRAM parity lock bit
$00000004 constant SYSCFG_COMP_OPAMP_SYSCFG_CFGR2_PVD_LOCK          \ PVD lock enable bit
$00000010 constant SYSCFG_COMP_OPAMP_SYSCFG_CFGR2_BYP_ADD_PAR       \ Bypass address bit 29 in parity calculation
$00000100 constant SYSCFG_COMP_OPAMP_SYSCFG_CFGR2_SRAM_PEF          \ SRAM parity flag


\
\ @brief control and status register
\ Address offset: 0x20
\ Reset value: 0x00000000
\

$00000001 constant SYSCFG_COMP_OPAMP_COMP2_CSR_COMP2EN              \ Comparator 2 enable
$00000070 constant SYSCFG_COMP_OPAMP_COMP2_CSR_COMP2INMSEL          \ Comparator 2 inverting input selection
$00003c00 constant SYSCFG_COMP_OPAMP_COMP2_CSR_COMP2OUTSEL          \ Comparator 2 output selection
$00008000 constant SYSCFG_COMP_OPAMP_COMP2_CSR_COMP2POL             \ Comparator 2 output polarity
$001c0000 constant SYSCFG_COMP_OPAMP_COMP2_CSR_COMP2_BLANKING       \ Comparator 2 blanking source
$00400000 constant SYSCFG_COMP_OPAMP_COMP2_CSR_COMP2INMSEL_22       \ Comparator 2 inverting input selection. It is used with Bits [6..4] to configure the Comp inverting input
$40000000 constant SYSCFG_COMP_OPAMP_COMP2_CSR_COMP2OUT             \ Comparator 2 output
$80000000 constant SYSCFG_COMP_OPAMP_COMP2_CSR_COMP2LOCK            \ Comparator 2 lock


\
\ @brief control and status register
\ Address offset: 0x28
\ Reset value: 0x00000000
\

$00000001 constant SYSCFG_COMP_OPAMP_COMP4_CSR_COMP4EN              \ Comparator 4 enable
$00000070 constant SYSCFG_COMP_OPAMP_COMP4_CSR_COMP4INMSEL          \ Comparator 4 inverting input selection
$00003c00 constant SYSCFG_COMP_OPAMP_COMP4_CSR_COMP4OUTSEL          \ Comparator 4 output selection
$00008000 constant SYSCFG_COMP_OPAMP_COMP4_CSR_COMP4POL             \ Comparator 4 output polarity
$001c0000 constant SYSCFG_COMP_OPAMP_COMP4_CSR_COMP4_BLANKING       \ Comparator 4 blanking source
$00400000 constant SYSCFG_COMP_OPAMP_COMP4_CSR_COMP4INMSEL_22       \ Comparator 4 inverting input selection. It is used with Bits [6..4] to configure the Comp inverting input
$40000000 constant SYSCFG_COMP_OPAMP_COMP4_CSR_COMP4OUT             \ Comparator 4 output
$80000000 constant SYSCFG_COMP_OPAMP_COMP4_CSR_COMP4LOCK            \ Comparator 4 lock


\
\ @brief control and status register
\ Address offset: 0x30
\ Reset value: 0x00000000
\

$00000001 constant SYSCFG_COMP_OPAMP_COMP6_CSR_COMP6EN              \ Comparator 6 enable
$00000070 constant SYSCFG_COMP_OPAMP_COMP6_CSR_COMP6INMSEL          \ Comparator 6 inverting input selection
$00003c00 constant SYSCFG_COMP_OPAMP_COMP6_CSR_COMP6OUTSEL          \ Comparator 6 output selection
$00008000 constant SYSCFG_COMP_OPAMP_COMP6_CSR_COMP6POL             \ Comparator 6 output polarity
$001c0000 constant SYSCFG_COMP_OPAMP_COMP6_CSR_COMP6_BLANKING       \ Comparator 6 blanking source
$00400000 constant SYSCFG_COMP_OPAMP_COMP6_CSR_COMP6INMSEL_22       \ Comparator 6 inverting input selection. It is used with Bits [6..4] to configure the Comp inverting input
$40000000 constant SYSCFG_COMP_OPAMP_COMP6_CSR_COMP6OUT             \ Comparator 6 output
$80000000 constant SYSCFG_COMP_OPAMP_COMP6_CSR_COMP6LOCK            \ Comparator 6 lock


\
\ @brief OPAMP2 control register
\ Address offset: 0x3C
\ Reset value: 0x00000000
\

$00000001 constant SYSCFG_COMP_OPAMP_OPAMP2_CSR_OPAMP2EN            \ OPAMP2 enable
$00000002 constant SYSCFG_COMP_OPAMP_OPAMP2_CSR_FORCE_VP            \ FORCE_VP
$0000000c constant SYSCFG_COMP_OPAMP_OPAMP2_CSR_VP_SEL              \ OPAMP2 Non inverting input selection
$00000060 constant SYSCFG_COMP_OPAMP_OPAMP2_CSR_VM_SEL              \ OPAMP2 inverting input selection
$00000080 constant SYSCFG_COMP_OPAMP_OPAMP2_CSR_TCM_EN              \ Timer controlled Mux mode enable
$00000100 constant SYSCFG_COMP_OPAMP_OPAMP2_CSR_VMS_SEL             \ OPAMP2 inverting input secondary selection
$00000600 constant SYSCFG_COMP_OPAMP_OPAMP2_CSR_VPS_SEL             \ OPAMP2 Non inverting input secondary selection
$00000800 constant SYSCFG_COMP_OPAMP_OPAMP2_CSR_CALON               \ Calibration mode enable
$00003000 constant SYSCFG_COMP_OPAMP_OPAMP2_CSR_CAL_SEL             \ Calibration selection
$0003c000 constant SYSCFG_COMP_OPAMP_OPAMP2_CSR_PGA_GAIN            \ Gain in PGA mode
$00040000 constant SYSCFG_COMP_OPAMP_OPAMP2_CSR_USER_TRIM           \ User trimming enable
$00f80000 constant SYSCFG_COMP_OPAMP_OPAMP2_CSR_TRIMOFFSETP         \ Offset trimming value (PMOS)
$1f000000 constant SYSCFG_COMP_OPAMP_OPAMP2_CSR_TRIMOFFSETN         \ Offset trimming value (NMOS)
$20000000 constant SYSCFG_COMP_OPAMP_OPAMP2_CSR_TSTREF              \ TSTREF
$40000000 constant SYSCFG_COMP_OPAMP_OPAMP2_CSR_OUTCAL              \ OPAMP 2 ouput status flag
$80000000 constant SYSCFG_COMP_OPAMP_OPAMP2_CSR_LOCK                \ OPAMP 2 lock


\
\ @brief configuration register 3
\ Address offset: 0x50
\ Reset value: 0x00000000
\

$00000003 constant SYSCFG_COMP_OPAMP_SYSCFG_CFGR3_SPI1_RX_DMA_RMP    \ SPI1_RX DMA remapping bit
$0000000c constant SYSCFG_COMP_OPAMP_SYSCFG_CFGR3_SPI1_TX_DMA_RMP    \ SPI1_TX DMA remapping bit
$00000030 constant SYSCFG_COMP_OPAMP_SYSCFG_CFGR3_I2C1_RX_DMA_RMP    \ I2C1_RX DMA remapping bit
$000000c0 constant SYSCFG_COMP_OPAMP_SYSCFG_CFGR3_ADC2_DMA_RMP_0    \ ADC2 DMA channel remapping bit
$00000200 constant SYSCFG_COMP_OPAMP_SYSCFG_CFGR3_ADC2_DMA_RMP_1    \ ADC2 DMA controller remapping bit
$00010000 constant SYSCFG_COMP_OPAMP_SYSCFG_CFGR3_DAC1_TRIG3_RMP    \ DAC1_CH1 / DAC1_CH2 Trigger remap
$00020000 constant SYSCFG_COMP_OPAMP_SYSCFG_CFGR3_DAC1_TRIG5_RMP    \ DAC1_CH1 / DAC1_CH2 Trigger remap


\
\ @brief System configuration controller
\
$40010000 constant SYSCFG_COMP_OPAMP_SYSCFG_CFGR1  \ offset: 0x00 : configuration register 1
$40010004 constant SYSCFG_COMP_OPAMP_SYSCFG_RCR  \ offset: 0x04 : CCM SRAM protection register
$40010008 constant SYSCFG_COMP_OPAMP_SYSCFG_EXTICR1  \ offset: 0x08 : external interrupt configuration register 1
$4001000c constant SYSCFG_COMP_OPAMP_SYSCFG_EXTICR2  \ offset: 0x0C : external interrupt configuration register 2
$40010010 constant SYSCFG_COMP_OPAMP_SYSCFG_EXTICR3  \ offset: 0x10 : external interrupt configuration register 3
$40010014 constant SYSCFG_COMP_OPAMP_SYSCFG_EXTICR4  \ offset: 0x14 : external interrupt configuration register 4
$40010018 constant SYSCFG_COMP_OPAMP_SYSCFG_CFGR2  \ offset: 0x18 : configuration register 2
$40010020 constant SYSCFG_COMP_OPAMP_COMP2_CSR  \ offset: 0x20 : control and status register
$40010028 constant SYSCFG_COMP_OPAMP_COMP4_CSR  \ offset: 0x28 : control and status register
$40010030 constant SYSCFG_COMP_OPAMP_COMP6_CSR  \ offset: 0x30 : control and status register
$4001003c constant SYSCFG_COMP_OPAMP_OPAMP2_CSR  \ offset: 0x3C : OPAMP2 control register
$40010050 constant SYSCFG_COMP_OPAMP_SYSCFG_CFGR3  \ offset: 0x50 : configuration register 3

