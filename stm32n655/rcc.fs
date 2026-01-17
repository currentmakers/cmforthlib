\
\ @file rcc.fs
\ @brief Reset and clock control
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] RCC_DEF

  [ifdef] RCC_RCC_CR_DEF
    \
    \ @brief RCC control register
    \ Address offset: 0x00
    \ Reset value: 0x00000008
    \
    $00 constant RCC_LSION                      \ [0x00] LSI oscillator enable in Run/Sleep mode.
    $01 constant RCC_LSEON                      \ [0x01] LSE oscillator enable in Run/Sleep mode.
    $02 constant RCC_MSION                      \ [0x02] MSI oscillator enable in Run/Sleep mode.
    $03 constant RCC_HSION                      \ [0x03] HSI oscillator enable in Run/Sleep mode.
    $04 constant RCC_HSEON                      \ [0x04] HSE oscillator enable in Run/Sleep mode.
    $08 constant RCC_PLL1ON                     \ [0x08] PLL1 enable in Run/Sleep mode.
    $09 constant RCC_PLL2ON                     \ [0x09] PLL2 enable in Run/Sleep mode.
    $0a constant RCC_PLL3ON                     \ [0x0a] PLL3 enable in Run/Sleep mode.
    $0b constant RCC_PLL4ON                     \ [0x0b] PLL4 enable in Run/Sleep mode.
  [then]


  [ifdef] RCC_RCC_SR_DEF
    \
    \ @brief RCC status register
    \ Address offset: 0x04
    \ Reset value: 0x00000008
    \
    $00 constant RCC_LSIRDY                     \ [0x00] LSI clock ready flag
    $01 constant RCC_LSERDY                     \ [0x01] LSE clock ready flag
    $02 constant RCC_MSIRDY                     \ [0x02] MSI clock ready flag
    $03 constant RCC_HSIRDY                     \ [0x03] HSI clock ready flag
    $04 constant RCC_HSERDY                     \ [0x04] HSE clock ready flag
    $08 constant RCC_PLL1RDY                    \ [0x08] PLL1 clock ready flag
    $09 constant RCC_PLL2RDY                    \ [0x09] PLL2 clock ready flag
    $0a constant RCC_PLL3RDY                    \ [0x0a] PLL3 clock ready flag
    $0b constant RCC_PLL4RDY                    \ [0x0b] PLL4 clock ready flag
  [then]


  [ifdef] RCC_RCC_STOPCR_DEF
    \
    \ @brief RCC Stop mode control register
    \ Address offset: 0x08
    \ Reset value: 0x00000008
    \
    $00 constant RCC_LSISTOPEN                  \ [0x00] LSI oscillator enable in Stop mode.
    $01 constant RCC_LSESTOPEN                  \ [0x01] LSE oscillator enable in Stop mode.
    $02 constant RCC_MSISTOPEN                  \ [0x02] MSI oscillator enable in Stop mode.
    $03 constant RCC_HSISTOPEN                  \ [0x03] HSI oscillator enable in Stop mode.
  [then]


  [ifdef] RCC_RCC_CFGR1_DEF
    \
    \ @brief RCC configuration register 1
    \ Address offset: 0x20
    \ Reset value: 0x00000000
    \
    $00 constant RCC_STOPWUCK                   \ [0x00] System clock selection after a wake up from system Stop.
    $10 constant RCC_CPUSW                      \ [0x10 : 2] CPU clock switch selection
    $14 constant RCC_CPUSWS                     \ [0x14 : 2] CPU clock switch status
    $18 constant RCC_SYSSW                      \ [0x18 : 2] System clock switch selection
    $1c constant RCC_SYSSWS                     \ [0x1c : 2] System clock switch status
  [then]


  [ifdef] RCC_RCC_CFGR2_DEF
    \
    \ @brief RCC configuration register 2
    \ Address offset: 0x24
    \ Reset value: 0x00000000
    \
    $00 constant RCC_PPRE1                      \ [0x00 : 3] CPU domain APB1 prescaler
    $04 constant RCC_PPRE2                      \ [0x04 : 3] CPU domain APB2 prescaler
    $0c constant RCC_PPRE4                      \ [0x0c : 3] CPU domain APB4 prescaler
    $10 constant RCC_PPRE5                      \ [0x10 : 3] CPU domain APB5 prescaler
    $14 constant RCC_HPRE                       \ [0x14 : 3] AHB clock prescaler
    $18 constant RCC_TIMPRE                     \ [0x18 : 2] Timers clocks prescaler selection
  [then]


  [ifdef] RCC_RCC_CKPROTR_DEF
    \
    \ @brief RCC clock protection register
    \ Address offset: 0x28
    \ Reset value: 0x00000000
    \
    $10 constant RCC_XSPI3SELS                  \ [0x10 : 2] XSPI3 clock selection current status
    $14 constant RCC_XSPI2SELS                  \ [0x14 : 2] XSPI2 clock selection current status
    $18 constant RCC_XSPI1SELS                  \ [0x18 : 2] XSPI1 clock selection current status
    $1c constant RCC_FMCSELS                    \ [0x1c : 2] FMC clock selection current status
  [then]


  [ifdef] RCC_RCC_BDCR_DEF
    \
    \ @brief RCC backup domain protection register
    \ Address offset: 0x2C
    \ Reset value: 0x00000000
    \
    $1f constant RCC_VSWRST                     \ [0x1f] VSW domain software reset.
  [then]


  [ifdef] RCC_RCC_HWRSR_DEF
    \
    \ @brief RCC reset status register for hardware
    \ Address offset: 0x30
    \ Reset value: 0x00E00000
    \
    $10 constant RCC_RMVF                       \ [0x10] Remove reset flag
    $11 constant RCC_LCKRSTF                    \ [0x11] CPU lockup reset flag.
    $15 constant RCC_BORRSTF                    \ [0x15] BOR flag
    $16 constant RCC_PINRSTF                    \ [0x16] Pin reset flag (NRST)
    $17 constant RCC_PORRSTF                    \ [0x17] POR/PDR flag.
    $18 constant RCC_SFTRSTF                    \ [0x18] Software system reset flag (1)
    $1a constant RCC_IWDGRSTF                   \ [0x1a] Independent Watchdog reset flag.
    $1c constant RCC_WWDGRSTF                   \ [0x1c] Window watchdog reset flag
    $1e constant RCC_LPWRRSTF                   \ [0x1e] Illegal Stop or Standby flag.
  [then]


  [ifdef] RCC_RCC_RSR_DEF
    \
    \ @brief RCC reset register
    \ Address offset: 0x34
    \ Reset value: 0x00E00000
    \
    $10 constant RCC_RMVF                       \ [0x10] Remove reset flag
    $11 constant RCC_LCKRSTF                    \ [0x11] CPU lockup reset flag.
    $15 constant RCC_BORRSTF                    \ [0x15] BOR flag
    $16 constant RCC_PINRSTF                    \ [0x16] Pin reset flag (NRST)
    $17 constant RCC_PORRSTF                    \ [0x17] POR/PDR flag.
    $18 constant RCC_SFTRSTF                    \ [0x18] Software System reset flag (1)
    $1a constant RCC_IWDGRSTF                   \ [0x1a] Independent Watchdog reset flag.
    $1c constant RCC_WWDGRSTF                   \ [0x1c] Window Watchdog reset flag
    $1e constant RCC_LPWRRSTF                   \ [0x1e] Illegal Stop or Standby flag.
  [then]


  [ifdef] RCC_RCC_LSECFGR_DEF
    \
    \ @brief RCC LSE configuration register
    \ Address offset: 0x40
    \ Reset value: 0x00000000
    \
    $07 constant RCC_LSECSSON                   \ [0x07] LSE clock security system (CSS) enable
    $08 constant RCC_LSECSSRA                   \ [0x08] LSE clock security system (CSS) re-arm function
    $09 constant RCC_LSECSSD                    \ [0x09] LSE clock security system (CSS) failure detection
    $0f constant RCC_LSEBYP                     \ [0x0f] LSE clock bypass
    $10 constant RCC_LSEEXT                     \ [0x10] LSE clock type in Bypass mode
    $11 constant RCC_LSEGFON                    \ [0x11] LSE clock glitch filter enable
    $12 constant RCC_LSEDRV                     \ [0x12 : 2] LSE oscillator driving capability
  [then]


  [ifdef] RCC_RCC_MSICFGR_DEF
    \
    \ @brief RCC MSI configuration register
    \ Address offset: 0x44
    \ Reset value: 0x00000000
    \
    $09 constant RCC_MSIFREQSEL                 \ [0x09] MSI oscillator frequency select
    $10 constant RCC_MSITRIM                    \ [0x10 : 5] MSI clock trimming
    $17 constant RCC_MSICAL                     \ [0x17 : 8] MSI clock calibration
  [then]


  [ifdef] RCC_RCC_HSICFGR_DEF
    \
    \ @brief RCC HSI configuration register
    \ Address offset: 0x48
    \ Reset value: 0x00000000
    \
    $07 constant RCC_HSIDIV                     \ [0x07 : 2] HSI clock divider
    $10 constant RCC_HSITRIM                    \ [0x10 : 7] HSI clock trimming
    $17 constant RCC_HSICAL                     \ [0x17 : 9] HSI clock calibration
  [then]


  [ifdef] RCC_RCC_HSIMCR_DEF
    \
    \ @brief RCC HSI monitor control register
    \ Address offset: 0x4C
    \ Reset value: 0x001F07A1
    \
    $00 constant RCC_HSIREF                     \ [0x00 : 11] HSI clock cycle counter reference value.
    $10 constant RCC_HSIDEV                     \ [0x10 : 6] HSI clock count deviation value
    $1f constant RCC_HSIMONEN                   \ [0x1f] HSI clock period monitor enable
  [then]


  [ifdef] RCC_RCC_HSIMSR_DEF
    \
    \ @brief RCC HSI monitor status register
    \ Address offset: 0x50
    \ Reset value: 0x00000000
    \
    $00 constant RCC_HSIVAL                     \ [0x00 : 11] HSI clock cycle counter measured value.
  [then]


  [ifdef] RCC_RCC_HSECFGR_DEF
    \
    \ @brief RCC HSE configuration register
    \ Address offset: 0x54
    \ Reset value: 0x00000800
    \
    $06 constant RCC_HSEDIV2BYP                 \ [0x06] HSE div2 oscillator clock in Bypass mode
    $07 constant RCC_HSECSSON                   \ [0x07] HSE clock security system (CSS) enable
    $08 constant RCC_HSECSSRA                   \ [0x08] HSE clock security system (CSS) re-arm function
    $09 constant RCC_HSECSSD                    \ [0x09] HSE clock security system (CSS) failure detection
    $0a constant RCC_HSECSSBYP                  \ [0x0a] HSE clock security system (CSS) bypass enable
    $0b constant RCC_HSECSSBPRE                 \ [0x0b : 4] HSE clock security system (CSS) bypass divider
    $0f constant RCC_HSEBYP                     \ [0x0f] HSE clock bypass
    $10 constant RCC_HSEEXT                     \ [0x10] HSE clock type in Bypass mode
    $11 constant RCC_HSEGFON                    \ [0x11] HSE clock glitch filter enable
    $12 constant RCC_HSEDRV                     \ [0x12 : 2] HSE oscillator driving capability
  [then]


  [ifdef] RCC_RCC_PLL1CFGR1_DEF
    \
    \ @brief RCC PLL1 configuration register 1
    \ Address offset: 0x80
    \ Reset value: 0x08202500
    \
    $08 constant RCC_PLL1DIVN                   \ [0x08 : 12] PLL1 Integer part for the VCO multiplication factor
    $14 constant RCC_PLL1DIVM                   \ [0x14 : 6] PLL1 reference input clock divide frequency ratio
    $1b constant RCC_PLL1BYP                    \ [0x1b] PLL1 bypass
    $1c constant RCC_PLL1SEL                    \ [0x1c : 3] PLL1 source selection of the reference clock
  [then]


  [ifdef] RCC_RCC_PLL1CFGR2_DEF
    \
    \ @brief RCC PLL1 configuration register 2
    \ Address offset: 0x84
    \ Reset value: 0x00800000
    \
    $00 constant RCC_PLL1DIVNFRAC               \ [0x00 : 24] PLL1 Fractional part of the VCO multiplication factor
  [then]


  [ifdef] RCC_RCC_PLL1CFGR3_DEF
    \
    \ @brief RCC PLL1 configuration register 3
    \ Address offset: 0x88
    \ Reset value: 0x4900000D
    \
    $00 constant RCC_PLL1MODSSRST               \ [0x00] PLL1 Modulation Spread Spectrum reset
    $01 constant RCC_PLL1DACEN                  \ [0x01] PLL1 noise canceling DAC enable in fractional mode.
    $02 constant RCC_PLL1MODSSDIS               \ [0x02] PLL1 Modulation Spread-Spectrum Disable
    $03 constant RCC_PLL1MODDSEN                \ [0x03] PLL1 Modulation Spread-Spectrum (and Fractional Divide) enable
    $04 constant RCC_PLL1MODSPRDW               \ [0x04] PLL1 Modulation Spread-Spectrum Down
    $08 constant RCC_PLL1MODDIV                 \ [0x08 : 4] PLL1 Modulation Division frequency adjustment
    $10 constant RCC_PLL1MODSPR                 \ [0x10 : 5] PLL1 Modulation Spread depth adjustment
    $18 constant RCC_PLL1PDIV2                  \ [0x18 : 3] PLL1 VCO frequency divider level 2
    $1b constant RCC_PLL1PDIV1                  \ [0x1b : 3] PLL1 VCO frequency divider level 1
    $1e constant RCC_PLL1PDIVEN                 \ [0x1e] PLL1 post divider POSTDIV1, POSTDIV2, and PLL clock output enable
  [then]


  [ifdef] RCC_RCC_PLL2CFGR1_DEF
    \
    \ @brief RCC PLL2 configuration register 1
    \ Address offset: 0x90
    \ Reset value: 0x08000000
    \
    $08 constant RCC_PLL2DIVN                   \ [0x08 : 12] PLL2 Integer part for the VCO multiplication factor
    $14 constant RCC_PLL2DIVM                   \ [0x14 : 6] PLL2 reference input clock divide frequency ratio
    $1b constant RCC_PLL2BYP                    \ [0x1b] PLL2 bypass
    $1c constant RCC_PLL2SEL                    \ [0x1c : 3] PLL2 source selection of the reference clock
  [then]


  [ifdef] RCC_RCC_PLL2CFGR2_DEF
    \
    \ @brief RCC PLL2 configuration register 2
    \ Address offset: 0x94
    \ Reset value: 0x00000000
    \
    $00 constant RCC_PLL2DIVNFRAC               \ [0x00 : 24] PLL2 Fractional part of the VCO multiplication factor
  [then]


  [ifdef] RCC_RCC_PLL2CFGR3_DEF
    \
    \ @brief RCC PLL2 configuration register 3
    \ Address offset: 0x98
    \ Reset value: 0x49000005
    \
    $00 constant RCC_PLL2MODSSRST               \ [0x00] PLL2 Modulation Spread Spectrum reset
    $01 constant RCC_PLL2DACEN                  \ [0x01] PLL2 noise canceling DAC enable in fractional mode.
    $02 constant RCC_PLL2MODSSDIS               \ [0x02] PLL2 Modulation Spread-Spectrum Disable
    $03 constant RCC_PLL2MODDSEN                \ [0x03] PLL2 Modulation Spread-Spectrum (and Fractional Divide) enable
    $04 constant RCC_PLL2MODSPRDW               \ [0x04] PLL2 Modulation Down Spread
    $08 constant RCC_PLL2MODDIV                 \ [0x08 : 4] PLL2 Modulation Division frequency adjustment
    $10 constant RCC_PLL2MODSPR                 \ [0x10 : 5] PLL2 Modulation Spread depth adjustment
    $18 constant RCC_PLL2PDIV2                  \ [0x18 : 3] PLL2 VCO frequency divider level 2
    $1b constant RCC_PLL2PDIV1                  \ [0x1b : 3] PLL2 VCO frequency divider level 1
    $1e constant RCC_PLL2PDIVEN                 \ [0x1e] PLL2 post divider POSTDIV1, POSTDIV2, and PLL clock output enable
  [then]


  [ifdef] RCC_RCC_PLL3CFGR1_DEF
    \
    \ @brief RCC PLL3 configuration register 1
    \ Address offset: 0xA0
    \ Reset value: 0x08000000
    \
    $08 constant RCC_PLL3DIVN                   \ [0x08 : 12] PLL3 Integer part for the VCO multiplication factor
    $14 constant RCC_PLL3DIVM                   \ [0x14 : 6] PLL3 reference input clock divide frequency ratio
    $1b constant RCC_PLL3BYP                    \ [0x1b] PLL3 bypass
    $1c constant RCC_PLL3SEL                    \ [0x1c : 3] PLL3 source selection of the reference clock
  [then]


  [ifdef] RCC_RCC_PLL3CFGR2_DEF
    \
    \ @brief RCC PLL3 configuration register 2
    \ Address offset: 0xA4
    \ Reset value: 0x00000000
    \
    $00 constant RCC_PLL3DIVNFRAC               \ [0x00 : 24] PLL3 Fractional part of the VCO multiplication factor
  [then]


  [ifdef] RCC_RCC_PLL3CFGR3_DEF
    \
    \ @brief RCC PLL3 configuration register 3
    \ Address offset: 0xA8
    \ Reset value: 0x49000005
    \
    $00 constant RCC_PLL3MODSSRST               \ [0x00] PLL3 Modulation Spread Spectrum reset
    $01 constant RCC_PLL3DACEN                  \ [0x01] PLL3 noise canceling DAC enable in fractional mode.
    $02 constant RCC_PLL3MODSSDIS               \ [0x02] PLL3 Modulation Spread-Spectrum Disable
    $03 constant RCC_PLL3MODDSEN                \ [0x03] PLL3 Modulation Spread-Spectrum (and Fractional Divide) enable
    $04 constant RCC_PLL3MODSPRDW               \ [0x04] PLL3 Modulation Down Spread
    $08 constant RCC_PLL3MODDIV                 \ [0x08 : 4] PLL3 Modulation Division frequency adjustment
    $10 constant RCC_PLL3MODSPR                 \ [0x10 : 5] PLL3 Modulation Spread depth adjustment
    $18 constant RCC_PLL3PDIV2                  \ [0x18 : 3] PLL3 VCO frequency divider level 2
    $1b constant RCC_PLL3PDIV1                  \ [0x1b : 3] PLL3 VCO frequency divider level 1
    $1e constant RCC_PLL3PDIVEN                 \ [0x1e] PLL3 post divider POSTDIV1, POSTDIV2, and PLL clock output enable
  [then]


  [ifdef] RCC_RCC_PLL4CFGR1_DEF
    \
    \ @brief RCC PLL4 configuration register 1
    \ Address offset: 0xB0
    \ Reset value: 0x08000000
    \
    $08 constant RCC_PLL4DIVN                   \ [0x08 : 12] PLL4 Integer part for the VCO multiplication factor
    $14 constant RCC_PLL4DIVM                   \ [0x14 : 6] PLL4 reference input clock divide frequency ratio
    $1b constant RCC_PLL4BYP                    \ [0x1b] PLL4 bypass
    $1c constant RCC_PLL4SEL                    \ [0x1c : 3] PLL4 source selection of the reference clock
  [then]


  [ifdef] RCC_RCC_PLL4CFGR2_DEF
    \
    \ @brief RCC PLL4 configuration register 2
    \ Address offset: 0xB4
    \ Reset value: 0x00000000
    \
    $00 constant RCC_PLL4DIVNFRAC               \ [0x00 : 24] PLL4 Fractional part of the VCO multiplication factor
  [then]


  [ifdef] RCC_RCC_PLL4CFGR3_DEF
    \
    \ @brief RCC PLL4 configuration register 3
    \ Address offset: 0xB8
    \ Reset value: 0x49000005
    \
    $00 constant RCC_PLL4MODSSRST               \ [0x00] PLL4 Modulation Spread Spectrum reset
    $01 constant RCC_PLL4DACEN                  \ [0x01] PLL4 noise canceling DAC enable in fractional mode.
    $02 constant RCC_PLL4MODSSDIS               \ [0x02] PLL4 Modulation Spread-Spectrum Disable
    $03 constant RCC_PLL4MODDSEN                \ [0x03] PLL4 Modulation Spread-Spectrum (and Fractional Divide) enable
    $04 constant RCC_PLL4MODSPRDW               \ [0x04] PLL4 Modulation Down Spread
    $08 constant RCC_PLL4MODDIV                 \ [0x08 : 4] PLL4 Modulation Division frequency adjustment
    $10 constant RCC_PLL4MODSPR                 \ [0x10 : 5] PLL4 Modulation Spread depth adjustment
    $18 constant RCC_PLL4PDIV2                  \ [0x18 : 3] PLL4 VCO frequency divider level 2
    $1b constant RCC_PLL4PDIV1                  \ [0x1b : 3] PLL4 VCO frequency divider level 1
    $1e constant RCC_PLL4PDIVEN                 \ [0x1e] PLL4 post divider POSTDIV1, POSTDIV2, and PLL clock output enable
  [then]


  [ifdef] RCC_RCC_IC1CFGR_DEF
    \
    \ @brief RCC IC1 configuration register
    \ Address offset: 0xC4
    \ Reset value: 0x00020000
    \
    $10 constant RCC_IC1INT                     \ [0x10 : 8] Divider IC1 integer division factor
    $1c constant RCC_IC1SEL                     \ [0x1c : 2] Divider IC1 Source Selection
  [then]


  [ifdef] RCC_RCC_IC2CFGR_DEF
    \
    \ @brief RCC IC2 configuration register
    \ Address offset: 0xC8
    \ Reset value: 0x00030000
    \
    $10 constant RCC_IC2INT                     \ [0x10 : 8] Divider IC2 integer division factor
    $1c constant RCC_IC2SEL                     \ [0x1c : 2] Divider IC2 Source Selection
  [then]


  [ifdef] RCC_RCC_IC3CFGR_DEF
    \
    \ @brief RCC IC3 configuration register
    \ Address offset: 0xCC
    \ Reset value: 0x00000000
    \
    $10 constant RCC_IC3INT                     \ [0x10 : 8] Divider IC3 integer division factor
    $1c constant RCC_IC3SEL                     \ [0x1c : 2] Divider IC3 Source Selection
  [then]


  [ifdef] RCC_RCC_IC4CFGR_DEF
    \
    \ @brief RCC IC4 configuration register
    \ Address offset: 0xD0
    \ Reset value: 0x00000000
    \
    $10 constant RCC_IC4INT                     \ [0x10 : 8] Divider IC4 integer division factor
    $1c constant RCC_IC4SEL                     \ [0x1c : 2] Divider IC4 Source Selection
  [then]


  [ifdef] RCC_RCC_IC5CFGR_DEF
    \
    \ @brief RCC IC5 configuration register
    \ Address offset: 0xD4
    \ Reset value: 0x00000000
    \
    $10 constant RCC_IC5INT                     \ [0x10 : 8] Divider IC5 integer division factor
    $1c constant RCC_IC5SEL                     \ [0x1c : 2] Divider IC5 Source Selection
  [then]


  [ifdef] RCC_RCC_IC6CFGR_DEF
    \
    \ @brief RCC IC6 configuration register
    \ Address offset: 0xD8
    \ Reset value: 0x00030000
    \
    $10 constant RCC_IC6INT                     \ [0x10 : 8] Divider IC6 integer division factor
    $1c constant RCC_IC6SEL                     \ [0x1c : 2] Divider IC6 Source Selection
  [then]


  [ifdef] RCC_RCC_IC7CFGR_DEF
    \
    \ @brief RCC IC7 configuration register
    \ Address offset: 0xDC
    \ Reset value: 0x10000000
    \
    $10 constant RCC_IC7INT                     \ [0x10 : 8] Divider IC7 integer division factor
    $1c constant RCC_IC7SEL                     \ [0x1c : 2] Divider IC7 Source Selection
  [then]


  [ifdef] RCC_RCC_IC8CFGR_DEF
    \
    \ @brief RCC IC8 configuration register
    \ Address offset: 0xE0
    \ Reset value: 0x10000000
    \
    $10 constant RCC_IC8INT                     \ [0x10 : 8] Divider IC8 integer division factor
    $1c constant RCC_IC8SEL                     \ [0x1c : 2] Divider IC8 Source Selection
  [then]


  [ifdef] RCC_RCC_IC9CFGR_DEF
    \
    \ @brief RCC IC9 configuration register
    \ Address offset: 0xE4
    \ Reset value: 0x10000000
    \
    $10 constant RCC_IC9INT                     \ [0x10 : 8] Divider IC9 integer division factor
    $1c constant RCC_IC9SEL                     \ [0x1c : 2] Divider IC9 Source Selection
  [then]


  [ifdef] RCC_RCC_IC10CFGR_DEF
    \
    \ @brief RCC IC10 configuration register
    \ Address offset: 0xE8
    \ Reset value: 0x10000000
    \
    $10 constant RCC_IC10INT                    \ [0x10 : 8] Divider IC10 integer division factor
    $1c constant RCC_IC10SEL                    \ [0x1c : 2] Divider IC10 Source Selection
  [then]


  [ifdef] RCC_RCC_IC11CFGR_DEF
    \
    \ @brief RCC IC11 configuration register
    \ Address offset: 0xEC
    \ Reset value: 0x00030000
    \
    $10 constant RCC_IC11INT                    \ [0x10 : 8] Divider IC11 integer division factor
    $1c constant RCC_IC11SEL                    \ [0x1c : 2] Divider IC11 Source Selection
  [then]


  [ifdef] RCC_RCC_IC12CFGR_DEF
    \
    \ @brief RCC IC12 configuration register
    \ Address offset: 0xF0
    \ Reset value: 0x20000000
    \
    $10 constant RCC_IC12INT                    \ [0x10 : 8] Divider IC12 integer division factor
    $1c constant RCC_IC12SEL                    \ [0x1c : 2] Divider IC12 Source Selection
  [then]


  [ifdef] RCC_RCC_IC13CFGR_DEF
    \
    \ @brief RCC IC13 configuration register
    \ Address offset: 0xF4
    \ Reset value: 0x20000000
    \
    $10 constant RCC_IC13INT                    \ [0x10 : 8] Divider IC13 integer division factor
    $1c constant RCC_IC13SEL                    \ [0x1c : 2] Divider IC13 Source Selection
  [then]


  [ifdef] RCC_RCC_IC14CFGR_DEF
    \
    \ @brief RCC IC14 configuration register
    \ Address offset: 0xF8
    \ Reset value: 0x20000000
    \
    $10 constant RCC_IC14INT                    \ [0x10 : 8] Divider IC14 integer division factor
    $1c constant RCC_IC14SEL                    \ [0x1c : 2] Divider IC14 Source Selection
  [then]


  [ifdef] RCC_RCC_IC15CFGR_DEF
    \
    \ @brief RCC IC15 configuration register
    \ Address offset: 0xFC
    \ Reset value: 0x20000000
    \
    $10 constant RCC_IC15INT                    \ [0x10 : 8] Divider IC15 integer division factor
    $1c constant RCC_IC15SEL                    \ [0x1c : 2] Divider IC15 Source Selection
  [then]


  [ifdef] RCC_RCC_IC16CFGR_DEF
    \
    \ @brief RCC IC16 configuration register
    \ Address offset: 0x100
    \ Reset value: 0x30000000
    \
    $10 constant RCC_IC16INT                    \ [0x10 : 8] Divider IC16 integer division factor
    $1c constant RCC_IC16SEL                    \ [0x1c : 2] Divider IC16 Source Selection
  [then]


  [ifdef] RCC_RCC_IC17CFGR_DEF
    \
    \ @brief RCC IC17 configuration register
    \ Address offset: 0x104
    \ Reset value: 0x30000000
    \
    $10 constant RCC_IC17INT                    \ [0x10 : 8] Divider IC17 integer division factor
    $1c constant RCC_IC17SEL                    \ [0x1c : 2] Divider IC17 Source Selection
  [then]


  [ifdef] RCC_RCC_IC18CFGR_DEF
    \
    \ @brief RCC IC18 configuration register
    \ Address offset: 0x108
    \ Reset value: 0x30000000
    \
    $10 constant RCC_IC18INT                    \ [0x10 : 8] Divider IC18 integer division factor
    $1c constant RCC_IC18SEL                    \ [0x1c : 2] Divider IC18 Source Selection
  [then]


  [ifdef] RCC_RCC_IC19CFGR_DEF
    \
    \ @brief RCC IC19 configuration register
    \ Address offset: 0x10C
    \ Reset value: 0x30000000
    \
    $10 constant RCC_IC19INT                    \ [0x10 : 8] Divider IC19 integer division factor
    $1c constant RCC_IC19SEL                    \ [0x1c : 2] Divider IC19 Source Selection
  [then]


  [ifdef] RCC_RCC_IC20CFGR_DEF
    \
    \ @brief RCC IC20 configuration register
    \ Address offset: 0x110
    \ Reset value: 0x30000000
    \
    $10 constant RCC_IC20INT                    \ [0x10 : 8] Divider IC20 integer division factor
    $1c constant RCC_IC20SEL                    \ [0x1c : 2] Divider IC20 Source Selection
  [then]


  [ifdef] RCC_RCC_CIER_DEF
    \
    \ @brief RCC clock-source interrupt enable register
    \ Address offset: 0x124
    \ Reset value: 0x00020000
    \
    $00 constant RCC_LSIRDYIE                   \ [0x00] LSI ready interrupt enable
    $01 constant RCC_LSERDYIE                   \ [0x01] LSE ready interrupt enable
    $02 constant RCC_MSIRDYIE                   \ [0x02] MSI ready interrupt enable
    $03 constant RCC_HSIRDYIE                   \ [0x03] HSI ready interrupt enable
    $04 constant RCC_HSERDYIE                   \ [0x04] HSE ready interrupt enable
    $08 constant RCC_PLL1RDYIE                  \ [0x08] PLL1 ready interrupt enable
    $09 constant RCC_PLL2RDYIE                  \ [0x09] PLL2 ready interrupt enable
    $0a constant RCC_PLL3RDYIE                  \ [0x0a] PLL3 ready interrupt enable
    $0b constant RCC_PLL4RDYIE                  \ [0x0b] PLL4 ready interrupt enable
    $10 constant RCC_LSECSSIE                   \ [0x10] LSE clock security system (CSS) interrupt enable
    $11 constant RCC_HSECSSIE                   \ [0x11] HSE clock security system (CSS) interrupt enable
    $18 constant RCC_WKUPIE                     \ [0x18] CPU wakeup from Stop interrupt enable
  [then]


  [ifdef] RCC_RCC_CIFR_DEF
    \
    \ @brief RCC clock-source interrupt flag register
    \ Address offset: 0x128
    \ Reset value: 0x00000000
    \
    $00 constant RCC_LSIRDYF                    \ [0x00] LSI ready interrupt flag
    $01 constant RCC_LSERDYF                    \ [0x01] LSE ready interrupt flag
    $02 constant RCC_MSIRDYF                    \ [0x02] MSI ready interrupt flag
    $03 constant RCC_HSIRDYF                    \ [0x03] HSI ready interrupt flag
    $04 constant RCC_HSERDYF                    \ [0x04] HSE ready interrupt flag
    $08 constant RCC_PLL1RDYF                   \ [0x08] PLL1 ready interrupt flag
    $09 constant RCC_PLL2RDYF                   \ [0x09] PLL2 ready interrupt flag
    $0a constant RCC_PLL3RDYF                   \ [0x0a] PLL3 ready interrupt flag
    $0b constant RCC_PLL4RDYF                   \ [0x0b] PLL4 ready interrupt flag
    $10 constant RCC_LSECSSF                    \ [0x10] LSE ready interrupt flag
    $11 constant RCC_HSECSSF                    \ [0x11] HSE ready interrupt flag
    $18 constant RCC_WKUPF                      \ [0x18] CPU wakeup from Stop interrupt flag
  [then]


  [ifdef] RCC_RCC_CICR_DEF
    \
    \ @brief RCC clock-source interrupt Clear register
    \ Address offset: 0x12C
    \ Reset value: 0x00000000
    \
    $00 constant RCC_LSIRDYC                    \ [0x00] LSI ready interrupt clear
    $01 constant RCC_LSERDYC                    \ [0x01] LSE ready interrupt clear
    $02 constant RCC_MSIRDYC                    \ [0x02] MSI ready interrupt clear
    $03 constant RCC_HSIRDYC                    \ [0x03] HSI ready interrupt clear
    $04 constant RCC_HSERDYC                    \ [0x04] HSE ready interrupt clear
    $08 constant RCC_PLL1RDYC                   \ [0x08] PLL1 ready interrupt clear
    $09 constant RCC_PLL2RDYC                   \ [0x09] PLL2 ready interrupt clear
    $0a constant RCC_PLL3RDYC                   \ [0x0a] PLL3 ready interrupt clear
    $0b constant RCC_PLL4RDYC                   \ [0x0b] PLL4 ready interrupt clear
    $10 constant RCC_LSECSSC                    \ [0x10] LSE ready interrupt clear
    $11 constant RCC_HSECSSC                    \ [0x11] HSE ready interrupt clear
    $18 constant RCC_WKUPFC                     \ [0x18] CPU Wakeup ready interrupt clear
  [then]


  [ifdef] RCC_RCC_CCIPR1_DEF
    \
    \ @brief RCC clock configuration for independent peripheral register1
    \ Address offset: 0x144
    \ Reset value: 0x00000000
    \
    $00 constant RCC_ADF1SEL                    \ [0x00 : 3] Source selection for the ADF1 kernel clock
    $04 constant RCC_ADC12SEL                   \ [0x04 : 3] Source selection for the ADC12 kernel clock
    $08 constant RCC_ADCPRE                     \ [0x08 : 8] ADC12 Prog clock divider selection (for clock ck_icn_p_adf1)
    $14 constant RCC_DCMIPPSEL                  \ [0x14 : 2] Source selection for the DCMIPP kernel clock
  [then]


  [ifdef] RCC_RCC_CCIPR2_DEF
    \
    \ @brief RCC clock configuration for independent peripheral register 2
    \ Address offset: 0x148
    \ Reset value: 0x00000000
    \
    $00 constant RCC_ETH1PTPSEL                 \ [0x00 : 2] Source selection for the ETH1 kernel clock
    $04 constant RCC_ETH1PTPDIV                 \ [0x04 : 4] ETH1 Kernel clock divider selection (for clock ck_ker_eth1ptp)
    $08 constant RCC_ETH1PWRDOWNACK             \ [0x08] Set and reset by software.
    $0c constant RCC_ETH1CLKSEL                 \ [0x0c : 2] Source selection for the ETH1 kernel clock
    $10 constant RCC_ETH1SEL                    \ [0x10 : 3] Set and reset by software
    $14 constant RCC_ETH1REFCLKSEL              \ [0x14] Set and reset by software
    $18 constant RCC_ETH1GTXCLKSEL              \ [0x18] Set and reset by software.
  [then]


  [ifdef] RCC_RCC_CCIPR3_DEF
    \
    \ @brief RCC clock configuration for independent peripheral register3
    \ Address offset: 0x14C
    \ Reset value: 0x00000001
    \
    $00 constant RCC_FDCANSEL                   \ [0x00 : 2] Source selection for the FDCAN kernel clock
    $04 constant RCC_FMCSEL                     \ [0x04 : 2] Source selection for the FMC kernel clock
    $08 constant RCC_DFTSEL                     \ [0x08] Source selection for the DFT kernel clock
  [then]


  [ifdef] RCC_RCC_CCIPR4_DEF
    \
    \ @brief RCC clock configuration for independent peripheral register4
    \ Address offset: 0x150
    \ Reset value: 0x00000000
    \
    $00 constant RCC_I2C1SEL                    \ [0x00 : 3] Source selection for the I2C1 kernel clock
    $04 constant RCC_I2C2SEL                    \ [0x04 : 3] Source selection for the I2C2 kernel clock
    $08 constant RCC_I2C3SEL                    \ [0x08 : 3] Source selection for the I2C3 kernel clock
    $0c constant RCC_I2C4SEL                    \ [0x0c : 3] Source selection for the I2C4 kernel clock
    $10 constant RCC_I3C1SEL                    \ [0x10 : 3] Source selection for the I3C1 kernel clock
    $14 constant RCC_I3C2SEL                    \ [0x14 : 3] Source selection for the I3C2 kernel clock
    $18 constant RCC_LTDCSEL                    \ [0x18 : 2] Source selection for the LTDC kernel clock
  [then]


  [ifdef] RCC_RCC_CCIPR5_DEF
    \
    \ @brief RCC lock configuration for independent peripheral register5
    \ Address offset: 0x154
    \ Reset value: 0x0000F0F0
    \
    $00 constant RCC_MCO1SEL                    \ [0x00 : 3] Source selection for the MCO1 kernel clock
    $04 constant RCC_MCO1PRE                    \ [0x04 : 4] MCO1 Prog clock divider selection (for clock ck_icn_p_mce3)
    $08 constant RCC_MCO2SEL                    \ [0x08 : 3] Source selection for the MCO2 kernel clock
    $0c constant RCC_MCO2PRE                    \ [0x0c : 4] MCO2 Prog clock divider selection (for clock ck_icn_p_mce4)
    $10 constant RCC_MDF1SEL                    \ [0x10 : 3] Source selection for the MDF1 kernel clock
  [then]


  [ifdef] RCC_RCC_CCIPR6_DEF
    \
    \ @brief RCC clock configuration for independent peripheral register6
    \ Address offset: 0x158
    \ Reset value: 0x00000000
    \
    $00 constant RCC_XSPI1SEL                   \ [0x00 : 2] Source selection for the XSPI1 kernel clock
    $04 constant RCC_XSPI2SEL                   \ [0x04 : 2] Source selection for the XSPI2 kernel clock
    $08 constant RCC_XSPI3SEL                   \ [0x08 : 2] Source selection for the XSPI3 kernel clock
    $0c constant RCC_OTGPHY1SEL                 \ [0x0c : 2] Source selection for the OTGPHY1 kernel clock
    $10 constant RCC_OTGPHY1CKREFSEL            \ [0x10] Set and reset by software
    $14 constant RCC_OTGPHY2SEL                 \ [0x14 : 2] Source selection for the OTGPHY2 kernel clock
    $18 constant RCC_OTGPHY2CKREFSEL            \ [0x18] Set and reset by software
  [then]


  [ifdef] RCC_RCC_CCIPR7_DEF
    \
    \ @brief RCC clock configuration for independent peripheral register7
    \ Address offset: 0x15C
    \ Reset value: 0x00000000
    \
    $00 constant RCC_PERSEL                     \ [0x00 : 3] Source selection for the PER kernel clock
    $04 constant RCC_PSSISEL                    \ [0x04 : 2] Source selection for the PSSI kernel clock
    $08 constant RCC_RTCSEL                     \ [0x08 : 2] Source selection for the RTC kernel clock
    $0c constant RCC_RTCPRE                     \ [0x0c : 6] RTC Prog clock divider selection (for clock ck_icn_p_risaf)
    $14 constant RCC_SAI1SEL                    \ [0x14 : 3] Source selection for the SAI1 kernel clock
    $18 constant RCC_SAI2SEL                    \ [0x18 : 3] Source selection for the SAI2 kernel clock
  [then]


  [ifdef] RCC_RCC_CCIPR8_DEF
    \
    \ @brief RCC clock configuration for independent peripheral register8
    \ Address offset: 0x160
    \ Reset value: 0x00000000
    \
    $00 constant RCC_SDMMC1SEL                  \ [0x00 : 2] Source selection for the SDMMC1 kernel clock
    $04 constant RCC_SDMMC2SEL                  \ [0x04 : 2] Source selection for the SDMMC2 kernel clock
  [then]


  [ifdef] RCC_RCC_CCIPR9_DEF
    \
    \ @brief RCC clock configuration for independent peripheral register9
    \ Address offset: 0x164
    \ Reset value: 0x00000000
    \
    $00 constant RCC_SPDIFRX1SEL                \ [0x00 : 3] Source selection for the SPDIFRX1 kernel clock
    $04 constant RCC_SPI1SEL                    \ [0x04 : 3] Source selection for the SPI1 kernel clock
    $08 constant RCC_SPI2SEL                    \ [0x08 : 3] Source selection for the SPI2 kernel clock
    $0c constant RCC_SPI3SEL                    \ [0x0c : 3] Source selection for the SPI3 kernel clock
    $10 constant RCC_SPI4SEL                    \ [0x10 : 3] Source selection for the SPI4 kernel clock
    $14 constant RCC_SPI5SEL                    \ [0x14 : 3] Source selection for the SPI5 kernel clock
    $18 constant RCC_SPI6SEL                    \ [0x18 : 3] Source selection for the SPI6 kernel clock
  [then]


  [ifdef] RCC_RCC_CCIPR12_DEF
    \
    \ @brief RCC clock configuration for independent peripheral register12
    \ Address offset: 0x170
    \ Reset value: 0x00000000
    \
    $08 constant RCC_LPTIM1SEL                  \ [0x08 : 3] Source selection for the LPTIM1 kernel clock
    $0c constant RCC_LPTIM2SEL                  \ [0x0c : 3] Source selection for the LPTIM2 kernel clock
    $10 constant RCC_LPTIM3SEL                  \ [0x10 : 3] Source selection for the LPTIM3 kernel clock
    $14 constant RCC_LPTIM4SEL                  \ [0x14 : 3] Source selection for the LPTIM4 kernel clock
    $18 constant RCC_LPTIM5SEL                  \ [0x18 : 3] Source selection for the LPTIM5 kernel clock
  [then]


  [ifdef] RCC_RCC_CCIPR13_DEF
    \
    \ @brief RCC clock configuration for independent peripheral register13
    \ Address offset: 0x174
    \ Reset value: 0x00000000
    \
    $00 constant RCC_USART1SEL                  \ [0x00 : 3] Source selection for the USART1 kernel clock
    $04 constant RCC_USART2SEL                  \ [0x04 : 3] Source selection for the USART2 kernel clock
    $08 constant RCC_USART3SEL                  \ [0x08 : 3] Source selection for the USART3 kernel clock
    $0c constant RCC_UART4SEL                   \ [0x0c : 3] Source selection for the UART4 kernel clock
    $10 constant RCC_UART5SEL                   \ [0x10 : 3] Source selection for the UART5 kernel clock
    $14 constant RCC_USART6SEL                  \ [0x14 : 3] Source selection for the USART6 kernel clock
    $18 constant RCC_UART7SEL                   \ [0x18 : 3] Source selection for the UART7 kernel clock
    $1c constant RCC_UART8SEL                   \ [0x1c : 3] Source selection for the UART8 kernel clock
  [then]


  [ifdef] RCC_RCC_CCIPR14_DEF
    \
    \ @brief RCC clock configuration for independent peripheral register14
    \ Address offset: 0x178
    \ Reset value: 0x00000000
    \
    $00 constant RCC_UART9SEL                   \ [0x00 : 3] Source selection for the UART9 kernel clock
    $04 constant RCC_USART10SEL                 \ [0x04 : 3] Source selection for the USART10 kernel clock
    $08 constant RCC_LPUART1SEL                 \ [0x08 : 3] Source selection for the LPUART1 kernel clock
  [then]


  [ifdef] RCC_RCC_BUSRSTR_DEF
    \
    \ @brief RCC SoC buses reset register
    \ Address offset: 0x204
    \ Reset value: 0x00000000
    \
    $00 constant RCC_ACLKNRST                   \ [0x00] ACLKN reset
    $02 constant RCC_AHBMRST                    \ [0x02] AHBM reset
    $03 constant RCC_AHB1RST                    \ [0x03] AHB1 reset
    $04 constant RCC_AHB2RST                    \ [0x04] AHB2 reset
    $05 constant RCC_AHB3RST                    \ [0x05] AHB3 reset
    $06 constant RCC_AHB4RST                    \ [0x06] AHB4 reset
    $07 constant RCC_AHB5RST                    \ [0x07] AHB5 reset
    $08 constant RCC_APB1RST                    \ [0x08] APB1 reset
    $09 constant RCC_APB2RST                    \ [0x09] APB2 reset
    $0a constant RCC_APB3RST                    \ [0x0a] APB3 reset
    $0b constant RCC_APB4RST                    \ [0x0b] APB4 reset
    $0c constant RCC_APB5RST                    \ [0x0c] APB5 reset
    $0d constant RCC_NOCRST                     \ [0x0d] NOC reset
  [then]


  [ifdef] RCC_RCC_MISCRSTR_DEF
    \
    \ @brief RCC miscellaneous configurations reset register
    \ Address offset: 0x208
    \ Reset value: 0x00000000
    \
    $00 constant RCC_DBGRST                     \ [0x00] DBG reset
    $04 constant RCC_XSPIPHY1RST                \ [0x04] XSPIPHY1 reset
    $05 constant RCC_XSPIPHY2RST                \ [0x05] XSPIPHY2 reset
    $07 constant RCC_SDMMC1DLLRST               \ [0x07] SDMMC1DLL reset
    $08 constant RCC_SDMMC2DLLRST               \ [0x08] SDMMC2DLL reset
  [then]


  [ifdef] RCC_RCC_MEMRSTR_DEF
    \
    \ @brief RCC memories reset register
    \ Address offset: 0x20C
    \ Reset value: 0x00000000
    \
    $00 constant RCC_AXISRAM3RST                \ [0x00] AXISRAM3 reset
    $01 constant RCC_AXISRAM4RST                \ [0x01] AXISRAM4reset
    $02 constant RCC_AXISRAM5RST                \ [0x02] AXISRAM5 reset
    $03 constant RCC_AXISRAM6RST                \ [0x03] AXISRAM6 reset
    $04 constant RCC_AHBSRAM1RST                \ [0x04] AHBSRAM1 reset
    $05 constant RCC_AHBSRAM2RST                \ [0x05] AHBSRAM2 reset
    $07 constant RCC_AXISRAM1RST                \ [0x07] AXISRAM1 reset
    $08 constant RCC_AXISRAM2RST                \ [0x08] AXISRAM2 reset
    $09 constant RCC_FLEXRAMRST                 \ [0x09] FLEXRAM reset
    $0a constant RCC_NPUCACHERAMRST             \ [0x0a] NPUCACHERAM reset
    $0b constant RCC_VENCRAMRST                 \ [0x0b] VENCRAM reset
    $0c constant RCC_BOOTROMRST                 \ [0x0c] BOOTROM reset
  [then]


  [ifdef] RCC_RCC_AHB1RSTR_DEF
    \
    \ @brief RCC AHB1 Reset register
    \ Address offset: 0x210
    \ Reset value: 0x00000000
    \
    $04 constant RCC_GPDMA1RST                  \ [0x04] GPDMA1 reset
    $05 constant RCC_ADC12RST                   \ [0x05] ADC12 reset
  [then]


  [ifdef] RCC_RCC_AHB2RSTR_DEF
    \
    \ @brief RCC AHB2 reset register
    \ Address offset: 0x214
    \ Reset value: 0x00000000
    \
    $0c constant RCC_RAMCFGRST                  \ [0x0c] RAMCFG reset
    $10 constant RCC_MDF1RST                    \ [0x10] MDF1 reset
    $11 constant RCC_ADF1RST                    \ [0x11] ADF1 reset
  [then]


  [ifdef] RCC_RCC_AHB3RSTR_DEF
    \
    \ @brief RCC AHB3 reset register
    \ Address offset: 0x218
    \ Reset value: 0x00000000
    \
    $00 constant RCC_RNGRST                     \ [0x00] RNG reset
    $01 constant RCC_HASHRST                    \ [0x01] HASH reset
    $02 constant RCC_CRYPRST                    \ [0x02] CRYP reset
    $04 constant RCC_SAESRST                    \ [0x04] SAES reset
    $08 constant RCC_PKARST                     \ [0x08] PKA reset
    $0a constant RCC_IACRST                     \ [0x0a] IAC reset
  [then]


  [ifdef] RCC_RCC_AHB4RSTR_DEF
    \
    \ @brief RCC AHB4 reset register
    \ Address offset: 0x21C
    \ Reset value: 0x00000000
    \
    $00 constant RCC_GPIOARST                   \ [0x00] GPIOA reset
    $01 constant RCC_GPIOBRST                   \ [0x01] GPIOB reset
    $02 constant RCC_GPIOCRST                   \ [0x02] GPIOC reset
    $03 constant RCC_GPIODRST                   \ [0x03] GPIOD reset
    $04 constant RCC_GPIOERST                   \ [0x04] GPIOE reset
    $05 constant RCC_GPIOFRST                   \ [0x05] GPIOF reset
    $06 constant RCC_GPIOGRST                   \ [0x06] GPIOG reset
    $07 constant RCC_GPIOHRST                   \ [0x07] GPIOH reset
    $0d constant RCC_GPIONRST                   \ [0x0d] GPION reset
    $0e constant RCC_GPIOORST                   \ [0x0e] GPIOO reset
    $0f constant RCC_GPIOPRST                   \ [0x0f] GPIOP reset
    $10 constant RCC_GPIOQRST                   \ [0x10] GPIOQ reset
    $12 constant RCC_PWRRST                     \ [0x12] PWR reset
    $13 constant RCC_CRCRST                     \ [0x13] CRC reset
  [then]


  [ifdef] RCC_RCC_AHB5RSTR_DEF
    \
    \ @brief RCC AHB5 reset register
    \ Address offset: 0x220
    \ Reset value: 0x00000000
    \
    $00 constant RCC_HPDMA1RST                  \ [0x00] HPDMA1 reset
    $01 constant RCC_DMA2DRST                   \ [0x01] DMA2D reset
    $03 constant RCC_JPEGRST                    \ [0x03] JPEG reset
    $04 constant RCC_FMCRST                     \ [0x04] FMC reset
    $05 constant RCC_XSPI1RST                   \ [0x05] XSPI1 reset
    $06 constant RCC_PSSIRST                    \ [0x06] PSSI reset
    $07 constant RCC_SDMMC2RST                  \ [0x07] SDMMC2 reset
    $08 constant RCC_SDMMC1RST                  \ [0x08] SDMMC1 reset
    $0c constant RCC_XSPI2RST                   \ [0x0c] XSPI2 reset
    $0d constant RCC_XSPIMRST                   \ [0x0d] XSPIM reset
    $11 constant RCC_XSPI3RST                   \ [0x11] XSPI3 reset
    $12 constant RCC_MCE4RST                    \ [0x12] MCE4 reset
    $13 constant RCC_GFXMMURST                  \ [0x13] GFXMMU reset
    $14 constant RCC_GPURST                     \ [0x14] GPU reset
    $17 constant RCC_SYSCFGOTGHSPHY1RST         \ [0x17] SYSCFGOTGHSPHY1 reset
    $18 constant RCC_SYSCFGOTGHSPHY2RST         \ [0x18] SYSCFGOTGHSPHY2 reset
    $19 constant RCC_ETH1RST                    \ [0x19] ETH1 reset
    $1a constant RCC_OTG1RST                    \ [0x1a] OTG1 reset
    $1b constant RCC_OTGPHY1RST                 \ [0x1b] OTGPHY1 reset
    $1c constant RCC_OTGPHY2RST                 \ [0x1c] OTGPHY2 reset
    $1d constant RCC_OTG2RST                    \ [0x1d] OTG2 reset
    $1e constant RCC_NPUCACHERST                \ [0x1e] NPUCACHE reset
    $1f constant RCC_NPURST                     \ [0x1f] NPU reset
  [then]


  [ifdef] RCC_RCC_APB1LRSTR_DEF
    \
    \ @brief RCC APB1L reset register
    \ Address offset: 0x224
    \ Reset value: 0x00000000
    \
    $00 constant RCC_TIM2RST                    \ [0x00] TIM2 reset
    $01 constant RCC_TIM3RST                    \ [0x01] TIM3 reset
    $02 constant RCC_TIM4RST                    \ [0x02] TIM4 reset
    $03 constant RCC_TIM5RST                    \ [0x03] TIM5 reset
    $04 constant RCC_TIM6RST                    \ [0x04] TIM6 reset
    $05 constant RCC_TIM7RST                    \ [0x05] TIM7 reset
    $06 constant RCC_TIM12RST                   \ [0x06] TIM12 reset
    $07 constant RCC_TIM13RST                   \ [0x07] TIM13 reset
    $08 constant RCC_TIM14RST                   \ [0x08] TIM14 reset
    $09 constant RCC_LPTIM1RST                  \ [0x09] LPTIM1 reset
    $0b constant RCC_WWDGRST                    \ [0x0b] WWDG reset
    $0c constant RCC_TIM10RST                   \ [0x0c] TIM10 reset
    $0d constant RCC_TIM11RST                   \ [0x0d] TIM11 reset
    $0e constant RCC_SPI2RST                    \ [0x0e] SPI2 reset
    $0f constant RCC_SPI3RST                    \ [0x0f] SPI3 reset
    $10 constant RCC_SPDIFRX1RST                \ [0x10] SPDIFRX1 reset
    $11 constant RCC_USART2RST                  \ [0x11] USART2 reset
    $12 constant RCC_USART3RST                  \ [0x12] USART3 reset
    $13 constant RCC_UART4RST                   \ [0x13] UART4 reset
    $14 constant RCC_UART5RST                   \ [0x14] UART5 reset
    $15 constant RCC_I2C1RST                    \ [0x15] I2C1 reset
    $16 constant RCC_I2C2RST                    \ [0x16] I2C2 reset
    $17 constant RCC_I2C3RST                    \ [0x17] I2C3 reset
    $18 constant RCC_I3C1RST                    \ [0x18] I3C1 reset
    $19 constant RCC_I3C2RST                    \ [0x19] I3C2 reset
    $1e constant RCC_UART7RST                   \ [0x1e] UART7 reset
    $1f constant RCC_UART8RST                   \ [0x1f] UART8 reset
  [then]


  [ifdef] RCC_RCC_APB1HRSTR_DEF
    \
    \ @brief RCC APB1H reset register
    \ Address offset: 0x228
    \ Reset value: 0x00000000
    \
    $05 constant RCC_MDIOSRST                   \ [0x05] MDIOS reset
    $08 constant RCC_FDCANRST                   \ [0x08] FDCAN reset
    $12 constant RCC_UCPD1RST                   \ [0x12] UCPD1 reset
  [then]


  [ifdef] RCC_RCC_APB2RSTR_DEF
    \
    \ @brief RCC APB2 reset register
    \ Address offset: 0x22C
    \ Reset value: 0x00000000
    \
    $00 constant RCC_TIM1RST                    \ [0x00] TIM1 reset
    $01 constant RCC_TIM8RST                    \ [0x01] TIM8 reset
    $04 constant RCC_USART1RST                  \ [0x04] USART1 reset
    $05 constant RCC_USART6RST                  \ [0x05] USART6 reset
    $06 constant RCC_UART9RST                   \ [0x06] UART9 reset
    $07 constant RCC_USART10RST                 \ [0x07] USART10 reset
    $0c constant RCC_SPI1RST                    \ [0x0c] SPI1 reset
    $0d constant RCC_SPI4RST                    \ [0x0d] SPI4 reset
    $0f constant RCC_TIM18RST                   \ [0x0f] TIM18 reset
    $10 constant RCC_TIM15RST                   \ [0x10] TIM15 reset
    $11 constant RCC_TIM16RST                   \ [0x11] TIM16 reset
    $12 constant RCC_TIM17RST                   \ [0x12] TIM17 reset
    $13 constant RCC_TIM9RST                    \ [0x13] TIM9 reset
    $14 constant RCC_SPI5RST                    \ [0x14] SPI5 reset
    $15 constant RCC_SAI1RST                    \ [0x15] SAI1 reset
    $16 constant RCC_SAI2RST                    \ [0x16] SAI2 reset
  [then]


  [ifdef] RCC_RCC_APB4LRSTR_DEF
    \
    \ @brief RCC APB4L reset register
    \ Address offset: 0x234
    \ Reset value: 0x00000000
    \
    $02 constant RCC_HDPRST                     \ [0x02] HDP reset
    $03 constant RCC_LPUART1RST                 \ [0x03] LPUART1 reset
    $05 constant RCC_SPI6RST                    \ [0x05] SPI6 reset
    $07 constant RCC_I2C4RST                    \ [0x07] I2C4 reset
    $09 constant RCC_LPTIM2RST                  \ [0x09] LPTIM2 reset
    $0a constant RCC_LPTIM3RST                  \ [0x0a] LPTIM3 reset
    $0b constant RCC_LPTIM4RST                  \ [0x0b] LPTIM4 reset
    $0c constant RCC_LPTIM5RST                  \ [0x0c] LPTIM5 reset
    $0f constant RCC_VREFBUFRST                 \ [0x0f] VREFBUF reset
    $10 constant RCC_RTCRST                     \ [0x10] RTC reset
    $16 constant RCC_R2GRETRST                  \ [0x16] R2GRET reset
    $17 constant RCC_R2GNPURST                  \ [0x17] R2GNPU reset
    $1f constant RCC_SERFRST                    \ [0x1f] SERF reset
  [then]


  [ifdef] RCC_RCC_APB4HRSTR_DEF
    \
    \ @brief RCC APB4H reset register
    \ Address offset: 0x238
    \ Reset value: 0x00000000
    \
    $00 constant RCC_SYSCFGRST                  \ [0x00] SYSCFG reset
    $02 constant RCC_DTSRST                     \ [0x02] DTS reset
    $04 constant RCC_BUSPERFMRST                \ [0x04] BUSPERFM reset
  [then]


  [ifdef] RCC_RCC_APB5RSTR_DEF
    \
    \ @brief RCC APB5 reset register
    \ Address offset: 0x23C
    \ Reset value: 0x00000000
    \
    $01 constant RCC_LTDCRST                    \ [0x01] LTDC reset
    $02 constant RCC_DCMIPPRST                  \ [0x02] DCMIPP reset
    $04 constant RCC_GFXTIMRST                  \ [0x04] GFXTIM reset
    $05 constant RCC_VENCRST                    \ [0x05] VENC reset
    $06 constant RCC_CSIRST                     \ [0x06] CSI reset
  [then]


  [ifdef] RCC_RCC_DIVENR_DEF
    \
    \ @brief RCC IC dividers enable register
    \ Address offset: 0x240
    \ Reset value: 0x00000000
    \
    $00 constant RCC_IC1EN                      \ [0x00] IC1 enable
    $01 constant RCC_IC2EN                      \ [0x01] IC2 enable
    $02 constant RCC_IC3EN                      \ [0x02] IC3 enable
    $03 constant RCC_IC4EN                      \ [0x03] IC4 enable
    $04 constant RCC_IC5EN                      \ [0x04] IC5 enable
    $05 constant RCC_IC6EN                      \ [0x05] IC6 enable
    $06 constant RCC_IC7EN                      \ [0x06] IC7 enable
    $07 constant RCC_IC8EN                      \ [0x07] IC8 enable
    $08 constant RCC_IC9EN                      \ [0x08] IC9 enable
    $09 constant RCC_IC10EN                     \ [0x09] IC10 enable
    $0a constant RCC_IC11EN                     \ [0x0a] IC11 enable
    $0b constant RCC_IC12EN                     \ [0x0b] IC12 enable
    $0c constant RCC_IC13EN                     \ [0x0c] IC13 enable
    $0d constant RCC_IC14EN                     \ [0x0d] IC14 enable
    $0e constant RCC_IC15EN                     \ [0x0e] IC15 enable
    $0f constant RCC_IC16EN                     \ [0x0f] IC16 enable
    $10 constant RCC_IC17EN                     \ [0x10] IC17 enable
    $11 constant RCC_IC18EN                     \ [0x11] IC18 enable
    $12 constant RCC_IC19EN                     \ [0x12] IC19 enable
    $13 constant RCC_IC20EN                     \ [0x13] IC20 enable
  [then]


  [ifdef] RCC_RCC_BUSENR_DEF
    \
    \ @brief RCC SoC buses enable register
    \ Address offset: 0x244
    \ Reset value: 0x00000003
    \
    $00 constant RCC_ACLKNEN                    \ [0x00] ACLKN enable
    $01 constant RCC_ACLKNCEN                   \ [0x01] ACLKNC enable
    $02 constant RCC_AHBMEN                     \ [0x02] AHBM enable
    $03 constant RCC_AHB1EN                     \ [0x03] AHB1 enable
    $04 constant RCC_AHB2EN                     \ [0x04] AHB2 enable
    $05 constant RCC_AHB3EN                     \ [0x05] AHB3 enable
    $06 constant RCC_AHB4EN                     \ [0x06] AHB4 enable
    $07 constant RCC_AHB5EN                     \ [0x07] AHB5 enable
    $08 constant RCC_APB1EN                     \ [0x08] APB1 enable
    $09 constant RCC_APB2EN                     \ [0x09] APB2 enable
    $0a constant RCC_APB3EN                     \ [0x0a] APB3 enable
    $0b constant RCC_APB4EN                     \ [0x0b] APB4 enable
    $0c constant RCC_APB5EN                     \ [0x0c] APB5 enable
  [then]


  [ifdef] RCC_RCC_MISCENR_DEF
    \
    \ @brief RCC miscellaneous configuration enable register
    \ Address offset: 0x248
    \ Reset value: 0x00000000
    \
    $00 constant RCC_DBGEN                      \ [0x00] DBG enable
    $01 constant RCC_MCO1EN                     \ [0x01] MCO1 enable
    $02 constant RCC_MCO2EN                     \ [0x02] MCO2 enable
    $03 constant RCC_XSPIPHYCOMPEN              \ [0x03] XSPIPHYCOMP enable
    $06 constant RCC_PEREN                      \ [0x06] PER enable
  [then]


  [ifdef] RCC_RCC_MEMENR_DEF
    \
    \ @brief RCC memory enable register
    \ Address offset: 0x24C
    \ Reset value: 0x000013FF
    \
    $00 constant RCC_AXISRAM3EN                 \ [0x00] AXISRAM3 enable
    $01 constant RCC_AXISRAM4EN                 \ [0x01] AXISRAM4 enable
    $02 constant RCC_AXISRAM5EN                 \ [0x02] AXISRAM5 enable
    $03 constant RCC_AXISRAM6EN                 \ [0x03] AXISRAM6 enable
    $04 constant RCC_AHBSRAM1EN                 \ [0x04] AHBSRAM1 enable
    $05 constant RCC_AHBSRAM2EN                 \ [0x05] AHBSRAM2 enable
    $06 constant RCC_BKPSRAMEN                  \ [0x06] BKPSRAM enable
    $07 constant RCC_AXISRAM1EN                 \ [0x07] AXISRAM1 enable
    $08 constant RCC_AXISRAM2EN                 \ [0x08] AXISRAM2 enable
    $09 constant RCC_FLEXRAMEN                  \ [0x09] FLEXRAM enable
    $0a constant RCC_NPUCACHERAMEN              \ [0x0a] NPUCACHERAM enable
    $0b constant RCC_VENCRAMEN                  \ [0x0b] VENCRAM enable
    $0c constant RCC_BOOTROMEN                  \ [0x0c] BOOTROM enable
  [then]


  [ifdef] RCC_RCC_AHB1ENR_DEF
    \
    \ @brief RCC AHB1 enable register
    \ Address offset: 0x250
    \ Reset value: 0x00000000
    \
    $04 constant RCC_GPDMA1EN                   \ [0x04] GPDMA1 enable
    $05 constant RCC_ADC12EN                    \ [0x05] ADC12 enable
  [then]


  [ifdef] RCC_RCC_AHB2ENR_DEF
    \
    \ @brief RCC AHB2 enable register
    \ Address offset: 0x254
    \ Reset value: 0x00001000
    \
    $0c constant RCC_RAMCFGEN                   \ [0x0c] RAMCFG enable
    $10 constant RCC_MDF1EN                     \ [0x10] MDF1 enable
    $11 constant RCC_ADF1EN                     \ [0x11] ADF enable
  [then]


  [ifdef] RCC_RCC_AHB3ENR_DEF
    \
    \ @brief RCC AHB3 enable register
    \ Address offset: 0x258
    \ Reset value: 0x00004600
    \
    $00 constant RCC_RNGEN                      \ [0x00] RNG enable
    $01 constant RCC_HASHEN                     \ [0x01] HASH enable
    $02 constant RCC_CRYPEN                     \ [0x02] CRYP enable
    $04 constant RCC_SAESEN                     \ [0x04] SAES enable
    $08 constant RCC_PKAEN                      \ [0x08] PKA enable
    $09 constant RCC_RIFSCEN                    \ [0x09] RIFSC enable
    $0a constant RCC_IACEN                      \ [0x0a] IAC enable
    $0e constant RCC_RISAFEN                    \ [0x0e] RISAF enable
  [then]


  [ifdef] RCC_RCC_AHB4ENR_DEF
    \
    \ @brief RCC AHB4 enable register
    \ Address offset: 0x25C
    \ Reset value: 0x00040000
    \
    $00 constant RCC_GPIOAEN                    \ [0x00] GPIOA enable
    $01 constant RCC_GPIOBEN                    \ [0x01] GPIOB enable
    $02 constant RCC_GPIOCEN                    \ [0x02] GPIOC enable
    $03 constant RCC_GPIODEN                    \ [0x03] GPIOD enable
    $04 constant RCC_GPIOEEN                    \ [0x04] GPIOE enable
    $05 constant RCC_GPIOFEN                    \ [0x05] GPIOF enable
    $06 constant RCC_GPIOGEN                    \ [0x06] GPIOG enable
    $07 constant RCC_GPIOHEN                    \ [0x07] GPIOH enable
    $0d constant RCC_GPIONEN                    \ [0x0d] GPION enable
    $0e constant RCC_GPIOOEN                    \ [0x0e] GPIOO enable
    $0f constant RCC_GPIOPEN                    \ [0x0f] GPIOP enable
    $10 constant RCC_GPIOQEN                    \ [0x10] GPIOQ enable
    $12 constant RCC_PWREN                      \ [0x12] PWR enable
    $13 constant RCC_CRCEN                      \ [0x13] CRC enable
  [then]


  [ifdef] RCC_RCC_AHB5ENR_DEF
    \
    \ @brief RCC AHB5 enable register
    \ Address offset: 0x260
    \ Reset value: 0x00000000
    \
    $00 constant RCC_HPDMA1EN                   \ [0x00] HPDMA1 enable
    $01 constant RCC_DMA2DEN                    \ [0x01] DMA2D enable
    $03 constant RCC_JPEGEN                     \ [0x03] JPEG enable
    $04 constant RCC_FMCEN                      \ [0x04] FMC enable
    $05 constant RCC_XSPI1EN                    \ [0x05] XSPI1 enable
    $06 constant RCC_PSSIEN                     \ [0x06] PSSI enable
    $07 constant RCC_SDMMC2EN                   \ [0x07] SDMMC2 enable
    $08 constant RCC_SDMMC1EN                   \ [0x08] SDMMC1 enable
    $0c constant RCC_XSPI2EN                    \ [0x0c] XSPI2 enable
    $0d constant RCC_XSPIMEN                    \ [0x0d] XSPIM enable
    $0e constant RCC_MCE1EN                     \ [0x0e] MCE1 enable
    $0f constant RCC_MCE2EN                     \ [0x0f] MCE2 enable
    $10 constant RCC_MCE3EN                     \ [0x10] MCE3 enable
    $11 constant RCC_XSPI3EN                    \ [0x11] XSPI3 enable
    $12 constant RCC_MCE4EN                     \ [0x12] MCE4 enable
    $13 constant RCC_GFXMMUEN                   \ [0x13] GFXMMU enable
    $14 constant RCC_GPUEN                      \ [0x14] GPU enable
    $16 constant RCC_ETH1MACEN                  \ [0x16] ETH1MAC enable
    $17 constant RCC_ETH1TXEN                   \ [0x17] ETH1TX enable
    $18 constant RCC_ETH1RXEN                   \ [0x18] ETH1RX enable
    $19 constant RCC_ETH1EN                     \ [0x19] ETH1 enable
    $1a constant RCC_OTG1EN                     \ [0x1a] OTG1 enable
    $1b constant RCC_OTGPHY1EN                  \ [0x1b] OTGPHY1 enable
    $1c constant RCC_OTGPHY2EN                  \ [0x1c] OTGPHY2 enable
    $1d constant RCC_OTG2EN                     \ [0x1d] OTG2 enable
    $1e constant RCC_NPUCACHEEN                 \ [0x1e] NPUCACHE enable
    $1f constant RCC_NPUEN                      \ [0x1f] NPU enable
  [then]


  [ifdef] RCC_RCC_APB1LENR_DEF
    \
    \ @brief RCC APB1L enable register
    \ Address offset: 0x264
    \ Reset value: 0x00000000
    \
    $00 constant RCC_TIM2EN                     \ [0x00] TIM2 enable
    $01 constant RCC_TIM3EN                     \ [0x01] TIM3 enable
    $02 constant RCC_TIM4EN                     \ [0x02] TIM4 enable
    $03 constant RCC_TIM5EN                     \ [0x03] TIM5 enable
    $04 constant RCC_TIM6EN                     \ [0x04] TIM6 enable
    $05 constant RCC_TIM7EN                     \ [0x05] TIM7 enable
    $06 constant RCC_TIM12EN                    \ [0x06] TIM12 enable
    $07 constant RCC_TIM13EN                    \ [0x07] TIM13 enable
    $08 constant RCC_TIM14EN                    \ [0x08] TIM14 enable
    $09 constant RCC_LPTIM1EN                   \ [0x09] LPTIM1 enable
    $0b constant RCC_WWDGEN                     \ [0x0b] WWDG enable
    $0c constant RCC_TIM10EN                    \ [0x0c] TIM10 enable
    $0d constant RCC_TIM11EN                    \ [0x0d] TIM11 enable
    $0e constant RCC_SPI2EN                     \ [0x0e] SPI2 enable
    $0f constant RCC_SPI3EN                     \ [0x0f] SPI3 enable
    $10 constant RCC_SPDIFRX1EN                 \ [0x10] SPDIFRX1 enable
    $11 constant RCC_USART2EN                   \ [0x11] USART2 enable
    $12 constant RCC_USART3EN                   \ [0x12] USART3 enable
    $13 constant RCC_UART4EN                    \ [0x13] UART4 enable
    $14 constant RCC_UART5EN                    \ [0x14] UART5 enable
    $15 constant RCC_I2C1EN                     \ [0x15] I2C1 enable
    $16 constant RCC_I2C2EN                     \ [0x16] I2C2 enable
    $17 constant RCC_I2C3EN                     \ [0x17] I2C3 enable
    $18 constant RCC_I3C1EN                     \ [0x18] I3C1 enable
    $19 constant RCC_I3C2EN                     \ [0x19] I3C2 enable
    $1e constant RCC_UART7EN                    \ [0x1e] UART7 enable
    $1f constant RCC_UART8EN                    \ [0x1f] UART8 enable
  [then]


  [ifdef] RCC_RCC_APB1HENR_DEF
    \
    \ @brief RCC APB1H enable register
    \ Address offset: 0x268
    \ Reset value: 0x00000000
    \
    $05 constant RCC_MDIOSEN                    \ [0x05] MDIOS enable
    $08 constant RCC_FDCANEN                    \ [0x08] FDCAN enable
    $12 constant RCC_UCPD1EN                    \ [0x12] UCPD1 enable
  [then]


  [ifdef] RCC_RCC_APB2ENR_DEF
    \
    \ @brief RCC APB2 enable register
    \ Address offset: 0x26C
    \ Reset value: 0x00000000
    \
    $00 constant RCC_TIM1EN                     \ [0x00] TIM1 enable
    $01 constant RCC_TIM8EN                     \ [0x01] TIM8 enable
    $04 constant RCC_USART1EN                   \ [0x04] USART1 enable
    $05 constant RCC_USART6EN                   \ [0x05] USART6 enable
    $06 constant RCC_UART9EN                    \ [0x06] UART9 enable
    $07 constant RCC_USART10EN                  \ [0x07] USART10 enable
    $0c constant RCC_SPI1EN                     \ [0x0c] SPI1 enable
    $0d constant RCC_SPI4EN                     \ [0x0d] SPI4 enable
    $0f constant RCC_TIM18EN                    \ [0x0f] TIM18 enable
    $10 constant RCC_TIM15EN                    \ [0x10] TIM15 enable
    $11 constant RCC_TIM16EN                    \ [0x11] TIM16 enable
    $12 constant RCC_TIM17EN                    \ [0x12] TIM17 enable
    $13 constant RCC_TIM9EN                     \ [0x13] TIM9 enable
    $14 constant RCC_SPI5EN                     \ [0x14] SPI5 enable
    $15 constant RCC_SAI1EN                     \ [0x15] SAI1 enable
    $16 constant RCC_SAI2EN                     \ [0x16] SAI2 enable
  [then]


  [ifdef] RCC_RCC_APB3ENR_DEF
    \
    \ @brief RCC APB3 enable register
    \ Address offset: 0x270
    \ Reset value: 0x00000000
    \
    $02 constant RCC_DFTEN                      \ [0x02] DFT enable
  [then]


  [ifdef] RCC_RCC_APB4LENR_DEF
    \
    \ @brief RCC APB4L enable register
    \ Address offset: 0x274
    \ Reset value: 0x00000000
    \
    $02 constant RCC_HDPEN                      \ [0x02] HDP enable
    $03 constant RCC_LPUART1EN                  \ [0x03] LPUART1 enable
    $05 constant RCC_SPI6EN                     \ [0x05] SPI6 enable
    $07 constant RCC_I2C4EN                     \ [0x07] I2C4 enable
    $09 constant RCC_LPTIM2EN                   \ [0x09] LPTIM2 enable
    $0a constant RCC_LPTIM3EN                   \ [0x0a] LPTIM3 enable
    $0b constant RCC_LPTIM4EN                   \ [0x0b] LPTIM4 enable
    $0c constant RCC_LPTIM5EN                   \ [0x0c] LPTIM5 enable
    $0f constant RCC_VREFBUFEN                  \ [0x0f] VREFBUF enable
    $10 constant RCC_RTCEN                      \ [0x10] RTC enable
    $11 constant RCC_RTCAPBEN                   \ [0x11] RTCAPB enable
    $16 constant RCC_R2GRETEN                   \ [0x16] R2GRET enable
    $17 constant RCC_R2GNPUEN                   \ [0x17] R2GNPU enable
    $1f constant RCC_SERFEN                     \ [0x1f] SERF enable
  [then]


  [ifdef] RCC_RCC_APB4HENR_DEF
    \
    \ @brief RCC APB4H enable register
    \ Address offset: 0x278
    \ Reset value: 0x00000002
    \
    $00 constant RCC_SYSCFGEN                   \ [0x00] SYSCFG enable
    $01 constant RCC_BSECEN                     \ [0x01] BSEC enable
    $02 constant RCC_DTSEN                      \ [0x02] DTS enable
    $04 constant RCC_BUSPERFMEN                 \ [0x04] BUSPERFM enable
  [then]


  [ifdef] RCC_RCC_APB5ENR_DEF
    \
    \ @brief RCC APB5 enable register
    \ Address offset: 0x27C
    \ Reset value: 0x00000000
    \
    $01 constant RCC_LTDCEN                     \ [0x01] LTDC enable
    $02 constant RCC_DCMIPPEN                   \ [0x02] DCMIPP enable
    $04 constant RCC_GFXTIMEN                   \ [0x04] GFXTIM enable
    $05 constant RCC_VENCEN                     \ [0x05] VENC enable
    $06 constant RCC_CSIEN                      \ [0x06] CSI enable
  [then]


  [ifdef] RCC_RCC_DIVLPENR_DEF
    \
    \ @brief RCC dividers Sleep enable register
    \ Address offset: 0x280
    \ Reset value: 0x00000000
    \
    $00 constant RCC_IC1LPEN                    \ [0x00] IC1 sleep enable
    $01 constant RCC_IC2LPEN                    \ [0x01] IC2 sleep enable
    $02 constant RCC_IC3LPEN                    \ [0x02] IC3 sleep enable
    $03 constant RCC_IC4LPEN                    \ [0x03] IC4 sleep enable
    $04 constant RCC_IC5LPEN                    \ [0x04] IC5 sleep enable
    $05 constant RCC_IC6LPEN                    \ [0x05] IC6 sleep enable
    $06 constant RCC_IC7LPEN                    \ [0x06] IC7 sleep enable
    $07 constant RCC_IC8LPEN                    \ [0x07] IC8 sleep enable
    $08 constant RCC_IC9LPEN                    \ [0x08] IC9 sleep enable
    $09 constant RCC_IC10LPEN                   \ [0x09] IC10 sleep enable
    $0a constant RCC_IC11LPEN                   \ [0x0a] IC11 sleep enable
    $0b constant RCC_IC12LPEN                   \ [0x0b] IC12 sleep enable
    $0c constant RCC_IC13LPEN                   \ [0x0c] IC13 sleep enable
    $0d constant RCC_IC14LPEN                   \ [0x0d] IC14 sleep enable
    $0e constant RCC_IC15LPEN                   \ [0x0e] IC15 sleep enable
    $0f constant RCC_IC16LPEN                   \ [0x0f] IC16 sleep enable
    $10 constant RCC_IC17LPEN                   \ [0x10] IC17 sleep enable
    $11 constant RCC_IC18LPEN                   \ [0x11] IC18 sleep enable
    $12 constant RCC_IC19LPEN                   \ [0x12] IC19 sleep enable
    $13 constant RCC_IC20LPEN                   \ [0x13] IC20 sleep enable
  [then]


  [ifdef] RCC_RCC_BUSLPENR_DEF
    \
    \ @brief RCC SoC buses Sleep enable register
    \ Address offset: 0x284
    \ Reset value: 0x00000003
    \
    $00 constant RCC_ACLKNLPEN                  \ [0x00] ACLKN sleep enable
    $01 constant RCC_ACLKNCLPEN                 \ [0x01] ACLKNC sleep enable
    $02 constant RCC_AHBMLPEN                   \ [0x02] AHBM sleep enable
    $03 constant RCC_AHB1LPEN                   \ [0x03] AHB1 sleep enable
    $04 constant RCC_AHB2LPEN                   \ [0x04] AHB2 sleep enable
    $05 constant RCC_AHB3LPEN                   \ [0x05] AHB3 sleep enable
    $06 constant RCC_AHB4LPEN                   \ [0x06] AHB4 sleep enable
    $07 constant RCC_AHB5LPEN                   \ [0x07] AHB5 sleep enable
    $08 constant RCC_APB1LPEN                   \ [0x08] APB1 sleep enable
    $09 constant RCC_APB2LPEN                   \ [0x09] APB2 sleep enable
    $0a constant RCC_APB3LPEN                   \ [0x0a] APB3 sleep enable
    $0b constant RCC_APB4LPEN                   \ [0x0b] APB4 sleep enable
    $0c constant RCC_APB5LPEN                   \ [0x0c] APB5 sleep enable
  [then]


  [ifdef] RCC_RCC_MISCLPENR_DEF
    \
    \ @brief RCC miscellaneous configurations Sleep enable register
    \ Address offset: 0x288
    \ Reset value: 0x00000000
    \
    $00 constant RCC_DBGLPEN                    \ [0x00] DBG sleep enable
    $03 constant RCC_XSPIPHYCOMPLPEN            \ [0x03] XSPIPHYCOMP sleep enable
    $06 constant RCC_PERLPEN                    \ [0x06] PER sleep enable
  [then]


  [ifdef] RCC_RCC_MEMLPENR_DEF
    \
    \ @brief RCC memory Sleep enable register
    \ Address offset: 0x28C
    \ Reset value: 0x00000000
    \
    $00 constant RCC_AXISRAM3LPEN               \ [0x00] AXISRAM3 sleep enable
    $01 constant RCC_AXISRAM4LPEN               \ [0x01] AXISRAM4 sleep enable
    $02 constant RCC_AXISRAM5LPEN               \ [0x02] AXISRAM5 sleep enable
    $03 constant RCC_AXISRAM6LPEN               \ [0x03] AXISRAM6 sleep enable
    $04 constant RCC_AHBSRAM1LPEN               \ [0x04] AHBSRAM1 sleep enable
    $05 constant RCC_AHBSRAM2LPEN               \ [0x05] AHBSRAM2 sleep enable
    $06 constant RCC_BKPSRAMLPEN                \ [0x06] BKPSRAM sleep enable
    $07 constant RCC_AXISRAM1LPEN               \ [0x07] AXISRAM1 sleep enable
    $08 constant RCC_AXISRAM2LPEN               \ [0x08] AXISRAM2 sleep enable
    $09 constant RCC_FLEXRAMLPEN                \ [0x09] FLEXRAM sleep enable
    $0a constant RCC_NPUCACHERAMLPEN            \ [0x0a] NPUCACHERAM sleep enable
    $0b constant RCC_VENCRAMLPEN                \ [0x0b] VENCRAM sleep enable
    $0c constant RCC_BOOTROMLPEN                \ [0x0c] BOOTROM sleep enable
  [then]


  [ifdef] RCC_RCC_AHB1LPENR_DEF
    \
    \ @brief RCC AHB1 Sleep enable register
    \ Address offset: 0x290
    \ Reset value: 0x00000000
    \
    $04 constant RCC_GPDMA1LPEN                 \ [0x04] GPDMA1 sleep enable
    $05 constant RCC_ADC12LPEN                  \ [0x05] ADC12 sleep enable
  [then]


  [ifdef] RCC_RCC_AHB2LPENR_DEF
    \
    \ @brief RCC AHB2 Sleep enable register
    \ Address offset: 0x294
    \ Reset value: 0x00000000
    \
    $0c constant RCC_RAMCFGLPEN                 \ [0x0c] RAMCFG sleep enable
    $10 constant RCC_MDF1LPEN                   \ [0x10] MDF1 sleep enable
    $11 constant RCC_ADF1LPEN                   \ [0x11] ADF1 sleep enable
  [then]


  [ifdef] RCC_RCC_AHB3LPENR_DEF
    \
    \ @brief RCC AHB3 Sleep enable register
    \ Address offset: 0x298
    \ Reset value: 0x00000400
    \
    $00 constant RCC_RNGLPEN                    \ [0x00] RNG sleep enable
    $01 constant RCC_HASHLPEN                   \ [0x01] HASH sleep enable
    $02 constant RCC_CRYPLPEN                   \ [0x02] CRYP sleep enable
    $04 constant RCC_SAESLPEN                   \ [0x04] SAES sleep enable
    $08 constant RCC_PKALPEN                    \ [0x08] PKA sleep enable
    $09 constant RCC_RIFSCLPEN                  \ [0x09] RIFSC sleep enable
    $0a constant RCC_IACLPEN                    \ [0x0a] IAC sleep enable
    $0e constant RCC_RISAFLPEN                  \ [0x0e] RISAF sleep enable
  [then]


  [ifdef] RCC_RCC_AHB4LPENR_DEF
    \
    \ @brief RCC AHB4 Sleep enable register
    \ Address offset: 0x29C
    \ Reset value: 0x00040000
    \
    $00 constant RCC_GPIOALPEN                  \ [0x00] GPIOA sleep enable
    $01 constant RCC_GPIOBLPEN                  \ [0x01] GPIOB sleep enable
    $02 constant RCC_GPIOCLPEN                  \ [0x02] GPIOC sleep enable
    $03 constant RCC_GPIODLPEN                  \ [0x03] GPIOD sleep enable
    $04 constant RCC_GPIOELPEN                  \ [0x04] GPIOE sleep enable
    $05 constant RCC_GPIOFLPEN                  \ [0x05] GPIOF sleep enable
    $06 constant RCC_GPIOGLPEN                  \ [0x06] GPIOG sleep enable
    $07 constant RCC_GPIOHLPEN                  \ [0x07] GPIOH sleep enable
    $0d constant RCC_GPIONLPEN                  \ [0x0d] GPION sleep enable
    $0e constant RCC_GPIOOLPEN                  \ [0x0e] GPIOO sleep enable
    $0f constant RCC_GPIOPLPEN                  \ [0x0f] GPIOP sleep enable
    $10 constant RCC_GPIOQLPEN                  \ [0x10] GPIOQ sleep enable
    $12 constant RCC_PWRLPEN                    \ [0x12] PWR sleep enable
    $13 constant RCC_CRCLPEN                    \ [0x13] CRC sleep enable
  [then]


  [ifdef] RCC_RCC_AHB5LPENR_DEF
    \
    \ @brief RCC AHB5 Sleep enable register
    \ Address offset: 0x2A0
    \ Reset value: 0x00000000
    \
    $00 constant RCC_HPDMA1LPEN                 \ [0x00] HPDMA1 sleep enable
    $01 constant RCC_DMA2DLPEN                  \ [0x01] DMA2D sleep enable
    $03 constant RCC_JPEGLPEN                   \ [0x03] JPEG sleep enable
    $04 constant RCC_FMCLPEN                    \ [0x04] FMC sleep enable
    $05 constant RCC_XSPI1LPEN                  \ [0x05] XSPI1 sleep enable
    $06 constant RCC_PSSILPEN                   \ [0x06] PSSI sleep enable
    $07 constant RCC_SDMMC2LPEN                 \ [0x07] SDMMC2 sleep enable
    $08 constant RCC_SDMMC1LPEN                 \ [0x08] SDMMC1 sleep enable
    $0c constant RCC_XSPI2LPEN                  \ [0x0c] XSPI2 sleep enable
    $0d constant RCC_XSPIMLPEN                  \ [0x0d] XSPIM sleep enable
    $0e constant RCC_MCE1LPEN                   \ [0x0e] MCE1 sleep enable
    $0f constant RCC_MCE2LPEN                   \ [0x0f] MCE2 sleep enable
    $10 constant RCC_MCE3LPEN                   \ [0x10] MCE3 sleep enable
    $11 constant RCC_XSPI3LPEN                  \ [0x11] XSPI3 sleep enable
    $12 constant RCC_MCE4LPEN                   \ [0x12] MCE4 sleep enable
    $13 constant RCC_GFXMMULPEN                 \ [0x13] GFXMMU sleep enable
    $14 constant RCC_GPULPEN                    \ [0x14] GPU sleep enable
    $16 constant RCC_ETH1MACLPEN                \ [0x16] ETH1MAC sleep enable
    $17 constant RCC_ETH1TXLPEN                 \ [0x17] ETH1TX sleep enable
    $18 constant RCC_ETH1RXLPEN                 \ [0x18] ETH1RX sleep enable
    $19 constant RCC_ETH1LPEN                   \ [0x19] ETH1 sleep enable
    $1a constant RCC_OTG1LPEN                   \ [0x1a] OTG1 sleep enable
    $1b constant RCC_OTGPHY1LPEN                \ [0x1b] OTGPHY1 sleep enable
    $1c constant RCC_OTGPHY2LPEN                \ [0x1c] OTGPHY2 sleep enable
    $1d constant RCC_OTG2LPEN                   \ [0x1d] OTG2 sleep enable
    $1e constant RCC_NPUCACHELPEN               \ [0x1e] NPUCACHE sleep enable
    $1f constant RCC_NPULPEN                    \ [0x1f] NPU sleep enable
  [then]


  [ifdef] RCC_RCC_APB1LLPENR_DEF
    \
    \ @brief RCC APB1L Sleep enable register
    \ Address offset: 0x2A4
    \ Reset value: 0x00000000
    \
    $00 constant RCC_TIM2LPEN                   \ [0x00] TIM2 sleep enable
    $01 constant RCC_TIM3LPEN                   \ [0x01] TIM3 sleep enable
    $02 constant RCC_TIM4LPEN                   \ [0x02] TIM4 sleep enable
    $03 constant RCC_TIM5LPEN                   \ [0x03] TIM5 sleep enable
    $04 constant RCC_TIM6LPEN                   \ [0x04] TIM6 sleep enable
    $05 constant RCC_TIM7LPEN                   \ [0x05] TIM7 sleep enable
    $06 constant RCC_TIM12LPEN                  \ [0x06] TIM12 sleep enable
    $07 constant RCC_TIM13LPEN                  \ [0x07] TIM13 sleep enable
    $08 constant RCC_TIM14LPEN                  \ [0x08] TIM14 sleep enable
    $09 constant RCC_LPTIM1LPEN                 \ [0x09] LPTIM1 sleep enable
    $0b constant RCC_WWDGLPEN                   \ [0x0b] WWDG sleep enable
    $0c constant RCC_TIM10LPEN                  \ [0x0c] TIM10 sleep enable
    $0d constant RCC_TIM11LPEN                  \ [0x0d] TIM11 sleep enable
    $0e constant RCC_SPI2LPEN                   \ [0x0e] SPI2 sleep enable
    $0f constant RCC_SPI3LPEN                   \ [0x0f] SPI3 sleep enable
    $10 constant RCC_SPDIFRX1LPEN               \ [0x10] SPDIFRX1 sleep enable
    $11 constant RCC_USART2LPEN                 \ [0x11] USART2 sleep enable
    $12 constant RCC_USART3LPEN                 \ [0x12] USART3 sleep enable
    $13 constant RCC_UART4LPEN                  \ [0x13] UART4 sleep enable
    $14 constant RCC_UART5LPEN                  \ [0x14] UART5 sleep enable
    $15 constant RCC_I2C1LPEN                   \ [0x15] I2C1 sleep enable
    $16 constant RCC_I2C2LPEN                   \ [0x16] I2C2 sleep enable
    $17 constant RCC_I2C3LPEN                   \ [0x17] I2C3 sleep enable
    $18 constant RCC_I3C1LPEN                   \ [0x18] I3C1 sleep enable
    $19 constant RCC_I3C2LPEN                   \ [0x19] I3C2 sleep enable
    $1e constant RCC_UART7LPEN                  \ [0x1e] UART7 sleep enable
    $1f constant RCC_UART8LPEN                  \ [0x1f] UART8 sleep enable
  [then]


  [ifdef] RCC_RCC_APB1HLPENR_DEF
    \
    \ @brief RCC APB1H Sleep enable register
    \ Address offset: 0x2A8
    \ Reset value: 0x00000000
    \
    $05 constant RCC_MDIOSLPEN                  \ [0x05] MDIOS sleep enable
    $08 constant RCC_FDCANLPEN                  \ [0x08] FDCAN sleep enable
    $12 constant RCC_UCPD1LPEN                  \ [0x12] UCPD1 sleep enable
  [then]


  [ifdef] RCC_RCC_APB2LPENR_DEF
    \
    \ @brief RCC APB2 Sleep enable register
    \ Address offset: 0x2AC
    \ Reset value: 0x00000000
    \
    $00 constant RCC_TIM1LPEN                   \ [0x00] TIM1 sleep enable
    $01 constant RCC_TIM8LPEN                   \ [0x01] TIM8 sleep enable
    $04 constant RCC_USART1LPEN                 \ [0x04] USART1 sleep enable
    $05 constant RCC_USART6LPEN                 \ [0x05] USART6 sleep enable
    $06 constant RCC_UART9LPEN                  \ [0x06] UART9 sleep enable
    $07 constant RCC_USART10LPEN                \ [0x07] USART10 sleep enable
    $0c constant RCC_SPI1LPEN                   \ [0x0c] SPI1 sleep enable
    $0d constant RCC_SPI4LPEN                   \ [0x0d] SPI4 sleep enable
    $0f constant RCC_TIM18LPEN                  \ [0x0f] TIM18 sleep enable
    $10 constant RCC_TIM15LPEN                  \ [0x10] TIM15 sleep enable
    $11 constant RCC_TIM16LPEN                  \ [0x11] TIM16 sleep enable
    $12 constant RCC_TIM17LPEN                  \ [0x12] TIM17 sleep enable
    $13 constant RCC_TIM9LPEN                   \ [0x13] TIM9 sleep enable
    $14 constant RCC_SPI5LPEN                   \ [0x14] SPI5 sleep enable
    $15 constant RCC_SAI1LPEN                   \ [0x15] SAI1 sleep enable
    $16 constant RCC_SAI2LPEN                   \ [0x16] SAI2 sleep enable
  [then]


  [ifdef] RCC_RCC_APB3LPENR_DEF
    \
    \ @brief RCC APB3 Sleep enable register
    \ Address offset: 0x2B0
    \ Reset value: 0x00000000
    \
    $02 constant RCC_DFTLPEN                    \ [0x02] DFT sleep enable
  [then]


  [ifdef] RCC_RCC_APB4LLPENR_DEF
    \
    \ @brief RCC APB4L Sleep enable register
    \ Address offset: 0x2B4
    \ Reset value: 0x00000000
    \
    $02 constant RCC_HDPLPEN                    \ [0x02] HDP sleep enable
    $03 constant RCC_LPUART1LPEN                \ [0x03] LPUART1 sleep enable
    $05 constant RCC_SPI6LPEN                   \ [0x05] SPI6 sleep enable
    $07 constant RCC_I2C4LPEN                   \ [0x07] I2C4 sleep enable
    $09 constant RCC_LPTIM2LPEN                 \ [0x09] LPTIM2 sleep enable
    $0a constant RCC_LPTIM3LPEN                 \ [0x0a] LPTIM3 sleep enable
    $0b constant RCC_LPTIM4LPEN                 \ [0x0b] LPTIM4 sleep enable
    $0c constant RCC_LPTIM5LPEN                 \ [0x0c] LPTIM5 sleep enable
    $0f constant RCC_VREFBUFLPEN                \ [0x0f] VREFBUF sleep enable
    $10 constant RCC_RTCLPEN                    \ [0x10] RTC sleep enable
    $11 constant RCC_RTCAPBLPEN                 \ [0x11] RTCAPB sleep enable
    $16 constant RCC_R2GRETLPEN                 \ [0x16] R2GRET sleep enable
    $17 constant RCC_R2GNPULPEN                 \ [0x17] R2GNPU sleep enable
    $1f constant RCC_SERFLPEN                   \ [0x1f] SERF sleep enable
  [then]


  [ifdef] RCC_RCC_APB4HLPENR_DEF
    \
    \ @brief RCC APB4H Sleep enable register
    \ Address offset: 0x2B8
    \ Reset value: 0x00000002
    \
    $00 constant RCC_SYSCFGLPEN                 \ [0x00] SYSCFG sleep enable
    $01 constant RCC_BSECLPEN                   \ [0x01] BSEC sleep enable
    $02 constant RCC_DTSLPEN                    \ [0x02] DTS sleep enable
    $04 constant RCC_BUSPERFMLPEN               \ [0x04] BUSPERFM sleep enable
  [then]


  [ifdef] RCC_RCC_APB5LPENR_DEF
    \
    \ @brief RCC APB5 Sleep enable register
    \ Address offset: 0x2BC
    \ Reset value: 0x00000000
    \
    $01 constant RCC_LTDCLPEN                   \ [0x01] LTDC sleep enable
    $02 constant RCC_DCMIPPLPEN                 \ [0x02] DCMIPP sleep enable
    $04 constant RCC_GFXTIMLPEN                 \ [0x04] GFXTIM sleep enable
    $05 constant RCC_VENCLPEN                   \ [0x05] VENC sleep enable
    $06 constant RCC_CSILPEN                    \ [0x06] CSI sleep enable
  [then]


  [ifdef] RCC_RCC_RDCR_DEF
    \
    \ @brief RCC APB5 Sleep enable register
    \ Address offset: 0x44C
    \ Reset value: 0x00060000
    \
    $10 constant RCC_MRD                        \ [0x10 : 5] BOOTROM sleep enable
    $18 constant RCC_EADLY                      \ [0x18 : 4] BOOTROM sleep enable
  [then]


  [ifdef] RCC_RCC_SECCFGR0_DEF
    \
    \ @brief RCC oscillator secure configuration register0
    \ Address offset: 0x780
    \ Reset value: 0x00000000
    \
    $00 constant RCC_LSISEC                     \ [0x00] Defines the secure protection of the LSI oscillator configuration bits.
    $01 constant RCC_LSESEC                     \ [0x01] Defines the secure protection of the LSE oscillator configuration bits.
    $02 constant RCC_MSISEC                     \ [0x02] Defines the secure protection of the MSI oscillator configuration bits.
    $03 constant RCC_HSISEC                     \ [0x03] Defines the secure protection of the HSI oscillator configuration bits.
    $04 constant RCC_HSESEC                     \ [0x04] Defines the secure protection of the HSE oscillator configuration bits.
  [then]


  [ifdef] RCC_RCC_PRIVCFGR0_DEF
    \
    \ @brief RCC oscillator privilege configuration register0
    \ Address offset: 0x784
    \ Reset value: 0x00000000
    \
    $00 constant RCC_LSIPV                      \ [0x00] Defines the privilege protection of the LSI oscillator configuration bits.
    $01 constant RCC_LSEPV                      \ [0x01] Defines the privilege protection of the LSE oscillator configuration bits.
    $02 constant RCC_MSIPV                      \ [0x02] Defines the privilege protection of the MSI oscillator configuration bits.
    $03 constant RCC_HSIPV                      \ [0x03] Defines the privilege protection of the HSI oscillator configuration bits.
    $04 constant RCC_HSEPV                      \ [0x04] Defines the privilege protection of the HSE oscillator configuration bits.
  [then]


  [ifdef] RCC_RCC_LOCKCFGR0_DEF
    \
    \ @brief RCC oscillator lock configuration register0
    \ Address offset: 0x788
    \ Reset value: 0x00000000
    \
    $00 constant RCC_LSILOCK                    \ [0x00] Defines the lock protection of the LSI oscillator configuration bits.
    $01 constant RCC_LSELOCK                    \ [0x01] Defines the lock protection of the LSE oscillator configuration bits.
    $02 constant RCC_MSILOCK                    \ [0x02] Defines the lock protection of the MSI oscillator configuration bits.
    $03 constant RCC_HSILOCK                    \ [0x03] Defines the lock protection of the HSI oscillator configuration bits.
    $04 constant RCC_HSELOCK                    \ [0x04] Defines the lock protection of the HSE oscillator configuration bits.
  [then]


  [ifdef] RCC_RCC_PUBCFGR0_DEF
    \
    \ @brief RCC oscillator public configuration register0
    \ Address offset: 0x78C
    \ Reset value: 0x00000000
    \
    $00 constant RCC_LSIPUB                     \ [0x00] Defines the public protection of the LSI oscillator configuration bits.
    $01 constant RCC_LSEPUB                     \ [0x01] Defines the public protection of the LSE oscillator configuration bits.
    $02 constant RCC_MSIPUB                     \ [0x02] Defines the public protection of the MSI oscillator configuration bits.
    $03 constant RCC_HSIPUB                     \ [0x03] Defines the public protection of the HSI oscillator configuration bits.
    $04 constant RCC_HSEPUB                     \ [0x04] Defines the public protection of the HSE oscillator configuration bits.
  [then]


  [ifdef] RCC_RCC_SECCFGR1_DEF
    \
    \ @brief RCC PLL secure configuration register1
    \ Address offset: 0x790
    \ Reset value: 0x00000000
    \
    $00 constant RCC_PLL1SEC                    \ [0x00] Defines the secure protection of the PLL1 PLL configuration bits.
    $01 constant RCC_PLL2SEC                    \ [0x01] Defines the secure protection of the PLL2 PLL configuration bits.
    $02 constant RCC_PLL3SEC                    \ [0x02] Defines the secure protection of the PLL3 PLL configuration bits.
    $03 constant RCC_PLL4SEC                    \ [0x03] Defines the secure protection of the PLL4 PLL configuration bits.
  [then]


  [ifdef] RCC_RCC_PRIVCFGR1_DEF
    \
    \ @brief RCC PLL privilege configuration register1
    \ Address offset: 0x794
    \ Reset value: 0x00000000
    \
    $00 constant RCC_PLL1PV                     \ [0x00] Defines the privilege protection of the PLL1 PLL configuration bits.
    $01 constant RCC_PLL2PV                     \ [0x01] Defines the privilege protection of the PLL2 PLL configuration bits.
    $02 constant RCC_PLL3PV                     \ [0x02] Defines the privilege protection of the PLL3 PLL configuration bits.
    $03 constant RCC_PLL4PV                     \ [0x03] Defines the privilege protection of the PLL4 PLL configuration bits.
  [then]


  [ifdef] RCC_RCC_LOCKCFGR1_DEF
    \
    \ @brief RCC PLL lock configuration register1
    \ Address offset: 0x798
    \ Reset value: 0x00000000
    \
    $00 constant RCC_PLL1LOCK                   \ [0x00] Defines the lock protection of the PLL1 PLL configuration bits.
    $01 constant RCC_PLL2LOCK                   \ [0x01] Defines the lock protection of the PLL2 PLL configuration bits.
    $02 constant RCC_PLL3LOCK                   \ [0x02] Defines the lock protection of the PLL3 PLL configuration bits.
    $03 constant RCC_PLL4LOCK                   \ [0x03] Defines the lock protection of the PLL4 PLL configuration bits.
  [then]


  [ifdef] RCC_RCC_PUBCFGR1_DEF
    \
    \ @brief RCC PLL public configuration register1
    \ Address offset: 0x79C
    \ Reset value: 0x00000000
    \
    $00 constant RCC_PLL1PUB                    \ [0x00] Defines the public protection of the PLL1 PLL configuration bits.
    $01 constant RCC_PLL2PUB                    \ [0x01] Defines the public protection of the PLL2 PLL configuration bits.
    $02 constant RCC_PLL3PUB                    \ [0x02] Defines the public protection of the PLL3 PLL configuration bits.
    $03 constant RCC_PLL4PUB                    \ [0x03] Defines the public protection of the PLL4 PLL configuration bits.
  [then]


  [ifdef] RCC_RCC_SECCFGR2_DEF
    \
    \ @brief RCC divider secure configuration register2
    \ Address offset: 0x7A0
    \ Reset value: 0x00000000
    \
    $00 constant RCC_IC1SEC                     \ [0x00] Defines the secure protection of the IC1 divider configuration bits.
    $01 constant RCC_IC2SEC                     \ [0x01] Defines the secure protection of the IC2 divider configuration bits.
    $02 constant RCC_IC3SEC                     \ [0x02] Defines the secure protection of the IC3 divider configuration bits.
    $03 constant RCC_IC4SEC                     \ [0x03] Defines the secure protection of the IC4 divider configuration bits.
    $04 constant RCC_IC5SEC                     \ [0x04] Defines the secure protection of the IC5 divider configuration bits.
    $05 constant RCC_IC6SEC                     \ [0x05] Defines the secure protection of the IC6 divider configuration bits.
    $06 constant RCC_IC7SEC                     \ [0x06] Defines the secure protection of the IC7 divider configuration bits.
    $07 constant RCC_IC8SEC                     \ [0x07] Defines the secure protection of the IC8 divider configuration bits.
    $08 constant RCC_IC9SEC                     \ [0x08] Defines the secure protection of the IC9 divider configuration bits.
    $09 constant RCC_IC10SEC                    \ [0x09] Defines the secure protection of the IC10 divider configuration bits.
    $0a constant RCC_IC11SEC                    \ [0x0a] Defines the secure protection of the IC11 divider configuration bits.
    $0b constant RCC_IC12SEC                    \ [0x0b] Defines the secure protection of the IC12 divider configuration bits.
    $0c constant RCC_IC13SEC                    \ [0x0c] Defines the secure protection of the IC13 divider configuration bits.
    $0d constant RCC_IC14SEC                    \ [0x0d] Defines the secure protection of the IC14 divider configuration bits.
    $0e constant RCC_IC15SEC                    \ [0x0e] Defines the secure protection of the IC15 divider configuration bits.
    $0f constant RCC_IC16SEC                    \ [0x0f] Defines the secure protection of the IC16 divider configuration bits.
    $10 constant RCC_IC17SEC                    \ [0x10] Defines the secure protection of the IC17 divider configuration bits.
    $11 constant RCC_IC18SEC                    \ [0x11] Defines the secure protection of the IC18 divider configuration bits.
    $12 constant RCC_IC19SEC                    \ [0x12] Defines the secure protection of the IC19 divider configuration bits.
    $13 constant RCC_IC20SEC                    \ [0x13] Defines the secure protection of the IC20 divider configuration bits.
  [then]


  [ifdef] RCC_RCC_PRIVCFGR2_DEF
    \
    \ @brief RCC divider privilege configuration register2
    \ Address offset: 0x7A4
    \ Reset value: 0x00000000
    \
    $00 constant RCC_IC1PV                      \ [0x00] Defines the privilege protection of the IC1 divider configuration bits.
    $01 constant RCC_IC2PV                      \ [0x01] Defines the privilege protection of the IC2 divider configuration bits.
    $02 constant RCC_IC3PV                      \ [0x02] Defines the privilege protection of the IC3 divider configuration bits.
    $03 constant RCC_IC4PV                      \ [0x03] Defines the privilege protection of the IC4 divider configuration bits.
    $04 constant RCC_IC5PV                      \ [0x04] Defines the privilege protection of the IC5 divider configuration bits.
    $05 constant RCC_IC6PV                      \ [0x05] Defines the privilege protection of the IC6 divider configuration bits.
    $06 constant RCC_IC7PV                      \ [0x06] Defines the privilege protection of the IC7 divider configuration bits.
    $07 constant RCC_IC8PV                      \ [0x07] Defines the privilege protection of the IC8 divider configuration bits.
    $08 constant RCC_IC9PV                      \ [0x08] Defines the privilege protection of the IC9 divider configuration bits.
    $09 constant RCC_IC10PV                     \ [0x09] Defines the privilege protection of the IC10 divider configuration bits.
    $0a constant RCC_IC11PV                     \ [0x0a] Defines the privilege protection of the IC11 divider configuration bits.
    $0b constant RCC_IC12PV                     \ [0x0b] Defines the privilege protection of the IC12 divider configuration bits.
    $0c constant RCC_IC13PV                     \ [0x0c] Defines the privilege protection of the IC13 divider configuration bits.
    $0d constant RCC_IC14PV                     \ [0x0d] Defines the privilege protection of the IC14 divider configuration bits.
    $0e constant RCC_IC15PV                     \ [0x0e] Defines the privilege protection of the IC15 divider configuration bits.
    $0f constant RCC_IC16PV                     \ [0x0f] Defines the privilege protection of the IC16 divider configuration bits.
    $10 constant RCC_IC17PV                     \ [0x10] Defines the privilege protection of the IC17 divider configuration bits.
    $11 constant RCC_IC18PV                     \ [0x11] Defines the privilege protection of the IC18 divider configuration bits.
    $12 constant RCC_IC19PV                     \ [0x12] Defines the privilege protection of the IC19 divider configuration bits.
    $13 constant RCC_IC20PV                     \ [0x13] Defines the privilege protection of the IC20 divider configuration bits.
  [then]


  [ifdef] RCC_RCC_LOCKCFGR2_DEF
    \
    \ @brief RCC divider lock configuration register2
    \ Address offset: 0x7A8
    \ Reset value: 0x00000000
    \
    $00 constant RCC_IC1LOCK                    \ [0x00] Defines the lock protection of the IC1 divider configuration bits.
    $01 constant RCC_IC2LOCK                    \ [0x01] Defines the lock protection of the IC2 divider configuration bits.
    $02 constant RCC_IC3LOCK                    \ [0x02] Defines the lock protection of the IC3 divider configuration bits.
    $03 constant RCC_IC4LOCK                    \ [0x03] Defines the lock protection of the IC4 divider configuration bits.
    $04 constant RCC_IC5LOCK                    \ [0x04] Defines the lock protection of the IC5 divider configuration bits.
    $05 constant RCC_IC6LOCK                    \ [0x05] Defines the lock protection of the IC6 divider configuration bits.
    $06 constant RCC_IC7LOCK                    \ [0x06] Defines the lock protection of the IC7 divider configuration bits.
    $07 constant RCC_IC8LOCK                    \ [0x07] Defines the lock protection of the IC8 divider configuration bits.
    $08 constant RCC_IC9LOCK                    \ [0x08] Defines the lock protection of the IC9 divider configuration bits.
    $09 constant RCC_IC10LOCK                   \ [0x09] Defines the lock protection of the IC10 divider configuration bits.
    $0a constant RCC_IC11LOCK                   \ [0x0a] Defines the lock protection of the IC11 divider configuration bits.
    $0b constant RCC_IC12LOCK                   \ [0x0b] Defines the lock protection of the IC12 divider configuration bits.
    $0c constant RCC_IC13LOCK                   \ [0x0c] Defines the lock protection of the IC13 divider configuration bits.
    $0d constant RCC_IC14LOCK                   \ [0x0d] Defines the lock protection of the IC14 divider configuration bits.
    $0e constant RCC_IC15LOCK                   \ [0x0e] Defines the lock protection of the IC15 divider configuration bits.
    $0f constant RCC_IC16LOCK                   \ [0x0f] Defines the lock protection of the IC16 divider configuration bits.
    $10 constant RCC_IC17LOCK                   \ [0x10] Defines the lock protection of the IC17 divider configuration bits.
    $11 constant RCC_IC18LOCK                   \ [0x11] Defines the lock protection of the IC18 divider configuration bits.
    $12 constant RCC_IC19LOCK                   \ [0x12] Defines the lock protection of the IC19 divider configuration bits.
    $13 constant RCC_IC20LOCK                   \ [0x13] Defines the lock protection of the IC20 divider configuration bits.
  [then]


  [ifdef] RCC_RCC_PUBCFGR2_DEF
    \
    \ @brief RCC divider public configuration register2
    \ Address offset: 0x7AC
    \ Reset value: 0x00000000
    \
    $00 constant RCC_IC1PUB                     \ [0x00] Defines the public protection of the IC1 divider configuration bits.
    $01 constant RCC_IC2PUB                     \ [0x01] Defines the public protection of the IC2 divider configuration bits.
    $02 constant RCC_IC3PUB                     \ [0x02] Defines the public protection of the IC3 divider configuration bits.
    $03 constant RCC_IC4PUB                     \ [0x03] Defines the public protection of the IC4 divider configuration bits.
    $04 constant RCC_IC5PUB                     \ [0x04] Defines the public protection of the IC5 divider configuration bits.
    $05 constant RCC_IC6PUB                     \ [0x05] Defines the public protection of the IC6 divider configuration bits.
    $06 constant RCC_IC7PUB                     \ [0x06] Defines the public protection of the IC7 divider configuration bits.
    $07 constant RCC_IC8PUB                     \ [0x07] Defines the public protection of the IC8 divider configuration bits.
    $08 constant RCC_IC9PUB                     \ [0x08] Defines the public protection of the IC9 divider configuration bits.
    $09 constant RCC_IC10PUB                    \ [0x09] Defines the public protection of the IC10 divider configuration bits.
    $0a constant RCC_IC11PUB                    \ [0x0a] Defines the public protection of the IC11 divider configuration bits.
    $0b constant RCC_IC12PUB                    \ [0x0b] Defines the public protection of the IC12 divider configuration bits.
    $0c constant RCC_IC13PUB                    \ [0x0c] Defines the public protection of the IC13 divider configuration bits.
    $0d constant RCC_IC14PUB                    \ [0x0d] Defines the public protection of the IC14 divider configuration bits.
    $0e constant RCC_IC15PUB                    \ [0x0e] Defines the public protection of the IC15 divider configuration bits.
    $0f constant RCC_IC16PUB                    \ [0x0f] Defines the public protection of the IC16 divider configuration bits.
    $10 constant RCC_IC17PUB                    \ [0x10] Defines the public protection of the IC17 divider configuration bits.
    $11 constant RCC_IC18PUB                    \ [0x11] Defines the public protection of the IC18 divider configuration bits.
    $12 constant RCC_IC19PUB                    \ [0x12] Defines the public protection of the IC19 divider configuration bits.
    $13 constant RCC_IC20PUB                    \ [0x13] Defines the public protection of the IC20 divider configuration bits.
  [then]


  [ifdef] RCC_RCC_SECCFGR3_DEF
    \
    \ @brief RCC system secure configuration register3
    \ Address offset: 0x7B0
    \ Reset value: 0x00000000
    \
    $00 constant RCC_MODSEC                     \ [0x00] Defines the secure protection of the MOD system configuration bits.
    $01 constant RCC_SYSSEC                     \ [0x01] Defines the secure protection of the SYS system configuration bits.
    $02 constant RCC_BUSSEC                     \ [0x02] Defines the secure protection of the BUS system configuration bits.
    $03 constant RCC_PERSEC                     \ [0x03] Defines the secure protection of the PER system configuration bits.
    $04 constant RCC_INTSEC                     \ [0x04] Defines the secure protection of the INT system configuration bits.
    $05 constant RCC_RSTSEC                     \ [0x05] Defines the secure protection of the RST system configuration bits.
    $06 constant RCC_DFTSEC                     \ [0x06] Defines the secure protection of the DFT system configuration bits.
  [then]


  [ifdef] RCC_RCC_PRIVCFGR3_DEF
    \
    \ @brief RCC system privilege configuration register3
    \ Address offset: 0x7B4
    \ Reset value: 0x00000000
    \
    $00 constant RCC_MODPV                      \ [0x00] Defines the privilege protection of the MOD system configuration bits.
    $01 constant RCC_SYSPV                      \ [0x01] Defines the privilege protection of the SYS system configuration bits.
    $02 constant RCC_BUSPV                      \ [0x02] Defines the privilege protection of the BUS system configuration bits.
    $03 constant RCC_PERPV                      \ [0x03] Defines the privilege protection of the PER system configuration bits.
    $04 constant RCC_INTPV                      \ [0x04] Defines the privilege protection of the INT system configuration bits.
    $05 constant RCC_RSTPV                      \ [0x05] Defines the privilege protection of the RST system configuration bits.
    $06 constant RCC_DFTPV                      \ [0x06] Defines the privilege protection of the DFT system configuration bits.
  [then]


  [ifdef] RCC_RCC_LOCKCFGR3_DEF
    \
    \ @brief RCC system lock configuration register3
    \ Address offset: 0x7B8
    \ Reset value: 0x00000000
    \
    $00 constant RCC_MODLOCK                    \ [0x00] Defines the lock protection of the MOD system configuration bits.
    $01 constant RCC_SYSLOCK                    \ [0x01] Defines the lock protection of the SYS system configuration bits.
    $02 constant RCC_BUSLOCK                    \ [0x02] Defines the lock protection of the BUS system configuration bits.
    $03 constant RCC_PERLOCK                    \ [0x03] Defines the lock protection of the PER system configuration bits.
    $04 constant RCC_INTLOCK                    \ [0x04] Defines the lock protection of the INT system configuration bits.
    $05 constant RCC_RSTLOCK                    \ [0x05] Defines the lock protection of the RST system configuration bits.
    $06 constant RCC_DFTLOCK                    \ [0x06] Defines the lock protection of the DFT system configuration bits.
  [then]


  [ifdef] RCC_RCC_PUBCFGR3_DEF
    \
    \ @brief RCC system public configuration register3
    \ Address offset: 0x7BC
    \ Reset value: 0x00000000
    \
    $00 constant RCC_MODPUB                     \ [0x00] Defines the public protection of the MOD system configuration bits.
    $01 constant RCC_SYSPUB                     \ [0x01] Defines the public protection of the SYS system configuration bits.
    $02 constant RCC_BUSPUB                     \ [0x02] Defines the public protection of the BUS system configuration bits.
    $03 constant RCC_PERPUB                     \ [0x03] Defines the public protection of the PER system configuration bits.
    $04 constant RCC_INTPUB                     \ [0x04] Defines the public protection of the INT system configuration bits.
    $05 constant RCC_RSTPUB                     \ [0x05] Defines the public protection of the RST system configuration bits.
    $06 constant RCC_DFTPUB                     \ [0x06] Defines the public protection of the DFT system configuration bits.
  [then]


  [ifdef] RCC_RCC_SECCFGR4_DEF
    \
    \ @brief RCC bus secure configuration register4
    \ Address offset: 0x7C0
    \ Reset value: 0x00000000
    \
    $00 constant RCC_ACLKNSEC                   \ [0x00] Defines the secure protection of the ACLKN bus configuration bits.
    $01 constant RCC_ACLKNCSEC                  \ [0x01] Defines the secure protection of the ACLKNC bus configuration bits.
    $02 constant RCC_AHBMSEC                    \ [0x02] Defines the secure protection of the AHBM bus configuration bits.
    $03 constant RCC_AHB1SEC                    \ [0x03] Defines the secure protection of the AHB1 bus configuration bits.
    $04 constant RCC_AHB2SEC                    \ [0x04] Defines the secure protection of the AHB2 bus configuration bits.
    $05 constant RCC_AHB3SEC                    \ [0x05] Defines the secure protection of the AHB3 bus configuration bits.
    $06 constant RCC_AHB4SEC                    \ [0x06] Defines the secure protection of the AHB4 bus configuration bits.
    $07 constant RCC_AHB5SEC                    \ [0x07] Defines the secure protection of the AHB5 bus configuration bits.
    $08 constant RCC_APB1SEC                    \ [0x08] Defines the secure protection of the APB1 bus configuration bits.
    $09 constant RCC_APB2SEC                    \ [0x09] Defines the secure protection of the APB2 bus configuration bits.
    $0a constant RCC_APB3SEC                    \ [0x0a] Defines the secure protection of the APB3 bus configuration bits.
    $0b constant RCC_APB4SEC                    \ [0x0b] Defines the secure protection of the APB4 bus configuration bits.
    $0c constant RCC_APB5SEC                    \ [0x0c] Defines the secure protection of the APB5 bus configuration bits.
    $0d constant RCC_NOCSEC                     \ [0x0d] Defines the secure protection of the NOC bus configuration bits.
  [then]


  [ifdef] RCC_RCC_PRIVCFGR4_DEF
    \
    \ @brief RCC bus privilege configuration register4
    \ Address offset: 0x7C4
    \ Reset value: 0x00000000
    \
    $00 constant RCC_ACLKNPV                    \ [0x00] Defines the privilege protection of the ACLKN bus configuration bits.
    $01 constant RCC_ACLKNCPV                   \ [0x01] Defines the privilege protection of the ACLKNC bus configuration bits.
    $02 constant RCC_AHBMPV                     \ [0x02] Defines the privilege protection of the AHBM bus configuration bits.
    $03 constant RCC_AHB1PV                     \ [0x03] Defines the privilege protection of the AHB1 bus configuration bits.
    $04 constant RCC_AHB2PV                     \ [0x04] Defines the privilege protection of the AHB2 bus configuration bits.
    $05 constant RCC_AHB3PV                     \ [0x05] Defines the privilege protection of the AHB3 bus configuration bits.
    $06 constant RCC_AHB4PV                     \ [0x06] Defines the privilege protection of the AHB4 bus configuration bits.
    $07 constant RCC_AHB5PV                     \ [0x07] Defines the privilege protection of the AHB5 bus configuration bits.
    $08 constant RCC_APB1PV                     \ [0x08] Defines the privilege protection of the APB1 bus configuration bits.
    $09 constant RCC_APB2PV                     \ [0x09] Defines the privilege protection of the APB2 bus configuration bits.
    $0a constant RCC_APB3PV                     \ [0x0a] Defines the privilege protection of the APB3 bus configuration bits.
    $0b constant RCC_APB4PV                     \ [0x0b] Defines the privilege protection of the APB4 bus configuration bits.
    $0c constant RCC_APB5PV                     \ [0x0c] Defines the privilege protection of the APB5 bus configuration bits.
    $0d constant RCC_NOCPV                      \ [0x0d] Defines the privilege protection of the NOC bus configuration bits.
  [then]


  [ifdef] RCC_RCC_LOCKCFGR4_DEF
    \
    \ @brief RCC bus lock configuration register4
    \ Address offset: 0x7C8
    \ Reset value: 0x00000000
    \
    $00 constant RCC_ACLKNLOCK                  \ [0x00] Defines the lock protection of the ACLKN bus configuration bits.
    $01 constant RCC_ACLKNCLOCK                 \ [0x01] Defines the lock protection of the ACLKNC bus configuration bits.
    $02 constant RCC_AHBMLOCK                   \ [0x02] Defines the lock protection of the AHBM bus configuration bits.
    $03 constant RCC_AHB1LOCK                   \ [0x03] Defines the lock protection of the AHB1 bus configuration bits.
    $04 constant RCC_AHB2LOCK                   \ [0x04] Defines the lock protection of the AHB2 bus configuration bits.
    $05 constant RCC_AHB3LOCK                   \ [0x05] Defines the lock protection of the AHB3 bus configuration bits.
    $06 constant RCC_AHB4LOCK                   \ [0x06] Defines the lock protection of the AHB4 bus configuration bits.
    $07 constant RCC_AHB5LOCK                   \ [0x07] Defines the lock protection of the AHB5 bus configuration bits.
    $08 constant RCC_APB1LOCK                   \ [0x08] Defines the lock protection of the APB1 bus configuration bits.
    $09 constant RCC_APB2LOCK                   \ [0x09] Defines the lock protection of the APB2 bus configuration bits.
    $0a constant RCC_APB3LOCK                   \ [0x0a] Defines the lock protection of the APB3 bus configuration bits.
    $0b constant RCC_APB4LOCK                   \ [0x0b] Defines the lock protection of the APB4 bus configuration bits.
    $0c constant RCC_APB5LOCK                   \ [0x0c] Defines the lock protection of the APB5 bus configuration bits.
    $0d constant RCC_NOCLOCK                    \ [0x0d] Defines the lock protection of the NOC bus configuration bits.
  [then]


  [ifdef] RCC_RCC_PUBCFGR4_DEF
    \
    \ @brief RCC bus public configuration register4
    \ Address offset: 0x7CC
    \ Reset value: 0x00000000
    \
    $00 constant RCC_ACLKNPUB                   \ [0x00] Defines the public protection of the ACLKN bus configuration bits.
    $01 constant RCC_ACLKNCPUB                  \ [0x01] Defines the public protection of the ACLKNC bus configuration bits.
    $02 constant RCC_AHBMPUB                    \ [0x02] Defines the public protection of the AHBM bus configuration bits.
    $03 constant RCC_AHB1PUB                    \ [0x03] Defines the public protection of the AHB1 bus configuration bits.
    $04 constant RCC_AHB2PUB                    \ [0x04] Defines the public protection of the AHB2 bus configuration bits.
    $05 constant RCC_AHB3PUB                    \ [0x05] Defines the public protection of the AHB3 bus configuration bits.
    $06 constant RCC_AHB4PUB                    \ [0x06] Defines the public protection of the AHB4 bus configuration bits.
    $07 constant RCC_AHB5PUB                    \ [0x07] Defines the public protection of the AHB5 bus configuration bits.
    $08 constant RCC_APB1PUB                    \ [0x08] Defines the public protection of the APB1 bus configuration bits.
    $09 constant RCC_APB2PUB                    \ [0x09] Defines the public protection of the APB2 bus configuration bits.
    $0a constant RCC_APB3PUB                    \ [0x0a] Defines the public protection of the APB3 bus configuration bits.
    $0b constant RCC_APB4PUB                    \ [0x0b] Defines the public protection of the APB4 bus configuration bits.
    $0c constant RCC_APB5PUB                    \ [0x0c] Defines the public protection of the APB5 bus configuration bits.
    $0d constant RCC_NOCPUB                     \ [0x0d] Defines the public protection of the NOC bus configuration bits.
  [then]


  [ifdef] RCC_RCC_PUBCFGR5_DEF
    \
    \ @brief RCC bus public configuration register4
    \ Address offset: 0x7D0
    \ Reset value: 0x00000000
    \
    $00 constant RCC_AXISRAM3PUB                \ [0x00] Defines the public protection of the AXISRAM3 bus configuration bits.
    $01 constant RCC_AXISRAM4PUB                \ [0x01] Defines the public protection of the AXISRAM4 bus configuration bits.
    $02 constant RCC_AXISRAM5PUB                \ [0x02] Defines the public protection of the AXISRAM5 bus configuration bits.
    $03 constant RCC_AXISRAM6PUB                \ [0x03] Defines the public protection of the AXISRAM6 bus configuration bits.
    $04 constant RCC_AHBSRAM1PUB                \ [0x04] Defines the public protection of the AHBSRAM1 bus configuration bits.
    $05 constant RCC_AHBSRAM2PUB                \ [0x05] Defines the public protection of the AHBSRAM2 bus configuration bits.
    $06 constant RCC_BKPSRAMPUB                 \ [0x06] Defines the public protection of the BKPSRAM bus configuration bits.
    $07 constant RCC_AXISRAM1PUB                \ [0x07] Defines the public protection of the AXISRAM1 bus configuration bits.
    $08 constant RCC_AXISRAM2PUB                \ [0x08] Defines the public protection of the AXISRAM2 bus configuration bits.
    $09 constant RCC_FLEXRAMPUB                 \ [0x09] Defines the public protection of the FLEXRAM bus configuration bits.
    $0a constant RCC_NPUCACHERAMPUB             \ [0x0a] Defines the public protection of the NPUCACHERAM bus configuration bits.
    $0b constant RCC_VENCRAMPUB                 \ [0x0b] Defines the public protection of the VENCRAM bus configuration bits.
  [then]


  [ifdef] RCC_RCC_CSR_DEF
    \
    \ @brief RCC control set register
    \ Address offset: 0x800
    \ Reset value: 0x00000000
    \
    $00 constant RCC_LSIONS                     \ [0x00] LSI oscillator enable in Run/Sleep mode.
    $01 constant RCC_LSEONS                     \ [0x01] LSE oscillator enable in Run/Sleep mode.
    $02 constant RCC_MSIONS                     \ [0x02] MSI oscillator enable in Run/Sleep mode.
    $03 constant RCC_HSIONS                     \ [0x03] HSI oscillator enable in Run/Sleep mode.
    $04 constant RCC_HSEONS                     \ [0x04] HSE oscillator enable in Run/Sleep mode.
    $08 constant RCC_PLL1ONS                    \ [0x08] PLL1 oscillator enable in Run/Sleep mode.
    $09 constant RCC_PLL2ONS                    \ [0x09] PLL2 oscillator enable in Run/Sleep mode.
    $0a constant RCC_PLL3ONS                    \ [0x0a] PLL3 oscillator enable in Run/Sleep mode.
    $0b constant RCC_PLL4ONS                    \ [0x0b] PLL4 oscillator enable in Run/Sleep mode.
  [then]


  [ifdef] RCC_RCC_STOPCSR_DEF
    \
    \ @brief RCC Stop configuration register
    \ Address offset: 0x808
    \ Reset value: 0x00000000
    \
    $00 constant RCC_MSISTOPENS                 \ [0x00] MSISTOPENS
    $01 constant RCC_HSISTOPENS                 \ [0x01] HSISTOPENS
  [then]


  [ifdef] RCC_RCC_BUSRSTSR_DEF
    \
    \ @brief RCC bus reset set register
    \ Address offset: 0xA04
    \ Reset value: 0x00000000
    \
    $00 constant RCC_ACLKNRSTS                  \ [0x00] ACLKN reset
    $02 constant RCC_AHBMRSTS                   \ [0x02] AHBM reset
    $03 constant RCC_AHB1RSTS                   \ [0x03] AHB1 reset
    $04 constant RCC_AHB2RSTS                   \ [0x04] AHB2 reset
    $05 constant RCC_AHB3RSTS                   \ [0x05] AHB3 reset
    $06 constant RCC_AHB4RSTS                   \ [0x06] AHB4 reset
    $07 constant RCC_AHB5RSTS                   \ [0x07] AHB5 reset
    $08 constant RCC_APB1RSTS                   \ [0x08] APB1 reset
    $09 constant RCC_APB2RSTS                   \ [0x09] APB2 reset
    $0a constant RCC_APB3RSTS                   \ [0x0a] APB3 reset
    $0b constant RCC_APB4RSTS                   \ [0x0b] APB4 reset
    $0c constant RCC_APB5RSTS                   \ [0x0c] APB5 reset
    $0d constant RCC_NOCRSTS                    \ [0x0d] NOC reset
  [then]


  [ifdef] RCC_RCC_MISCRSTSR_DEF
    \
    \ @brief RCC miscellaneous reset register
    \ Address offset: 0xA08
    \ Reset value: 0x00000000
    \
    $00 constant RCC_DBGRSTS                    \ [0x00] DBG reset
    $04 constant RCC_XSPIPHY1RSTS               \ [0x04] XSPIPHY1 reset
    $05 constant RCC_XSPIPHY2RSTS               \ [0x05] XSPIPHY2 reset
    $07 constant RCC_SDMMC1DLLRSTS              \ [0x07] SDMMC1DLL reset
    $08 constant RCC_SDMMC2DLLRSTS              \ [0x08] SDMMC2DLL reset
  [then]


  [ifdef] RCC_RCC_MEMRSTSR_DEF
    \
    \ @brief RCC memory reset register
    \ Address offset: 0xA0C
    \ Reset value: 0x00000000
    \
    $00 constant RCC_AXISRAM3RSTS               \ [0x00] AXISRAM3 reset
    $01 constant RCC_AXISRAM4RSTS               \ [0x01] AXISRAM4 reset
    $02 constant RCC_AXISRAM5RSTS               \ [0x02] AXISRAM5 reset
    $03 constant RCC_AXISRAM6RSTS               \ [0x03] AXISRAM6 reset
    $04 constant RCC_AHBSRAM1RSTS               \ [0x04] AHBSRAM1 reset
    $05 constant RCC_AHBSRAM2RSTS               \ [0x05] AHBSRAM2 reset
    $07 constant RCC_AXISRAM1RSTS               \ [0x07] AXISRAM1 reset
    $08 constant RCC_AXISRAM2RSTS               \ [0x08] AXISRAM2 reset
    $09 constant RCC_FLEXRAMRSTS                \ [0x09] FLEXRAM reset
    $0a constant RCC_NPUCACHERAMRSTS            \ [0x0a] NPUCACHERAM reset
    $0b constant RCC_VENCRAMRSTS                \ [0x0b] VENCRAM reset
    $0c constant RCC_BOOTROMRSTS                \ [0x0c] BOOTROM reset
  [then]


  [ifdef] RCC_RCC_AHB1RSTSR_DEF
    \
    \ @brief RCC AHB1 reset register
    \ Address offset: 0xA10
    \ Reset value: 0x00000000
    \
    $04 constant RCC_GPDMA1RSTS                 \ [0x04] GPDMA1 reset
    $05 constant RCC_ADC12RSTS                  \ [0x05] ADC12 reset
  [then]


  [ifdef] RCC_RCC_AHB2RSTSR_DEF
    \
    \ @brief RCC AHB2 reset register
    \ Address offset: 0xA14
    \ Reset value: 0x00000000
    \
    $0c constant RCC_RAMCFGRSTS                 \ [0x0c] RAMCFG reset
    $10 constant RCC_MDF1RSTS                   \ [0x10] MDF1 reset
    $11 constant RCC_ADF1RSTS                   \ [0x11] ADF1 reset
  [then]


  [ifdef] RCC_RCC_AHB3RSTSR_DEF
    \
    \ @brief RCC AHB3 reset register
    \ Address offset: 0xA18
    \ Reset value: 0x00000000
    \
    $00 constant RCC_RNGRSTS                    \ [0x00] RNG reset
    $01 constant RCC_HASHRSTS                   \ [0x01] HASH reset
    $02 constant RCC_CRYPRSTS                   \ [0x02] CRYP reset
    $04 constant RCC_SAESRSTS                   \ [0x04] SAES reset
    $08 constant RCC_PKARSTS                    \ [0x08] PKA reset
    $0a constant RCC_IACRSTS                    \ [0x0a] IAC reset
  [then]


  [ifdef] RCC_RCC_AHB4RSTSR_DEF
    \
    \ @brief RCC AHB4 reset register
    \ Address offset: 0xA1C
    \ Reset value: 0x00000000
    \
    $00 constant RCC_GPIOARSTS                  \ [0x00] GPIOA reset
    $01 constant RCC_GPIOBRSTS                  \ [0x01] GPIOB reset
    $02 constant RCC_GPIOCRSTS                  \ [0x02] GPIOC reset
    $03 constant RCC_GPIODRSTS                  \ [0x03] GPIOD reset
    $04 constant RCC_GPIOERSTS                  \ [0x04] GPIOE reset
    $05 constant RCC_GPIOFRSTS                  \ [0x05] GPIOF reset
    $06 constant RCC_GPIOGRSTS                  \ [0x06] GPIOG reset
    $07 constant RCC_GPIOHRSTS                  \ [0x07] GPIOH reset
    $0d constant RCC_GPIONRSTS                  \ [0x0d] GPION reset
    $0e constant RCC_GPIOORSTS                  \ [0x0e] GPIOO reset
    $0f constant RCC_GPIOPRSTS                  \ [0x0f] GPIOP reset
    $10 constant RCC_GPIOQRSTS                  \ [0x10] GPIOQ reset
    $12 constant RCC_PWRRSTS                    \ [0x12] PWR reset
    $13 constant RCC_CRCRSTS                    \ [0x13] CRC reset
  [then]


  [ifdef] RCC_RCC_AHB5RSTSR_DEF
    \
    \ @brief RCC AHB5 reset register
    \ Address offset: 0xA20
    \ Reset value: 0x00000000
    \
    $00 constant RCC_HPDMA1RSTS                 \ [0x00] HPDMA1 reset
    $01 constant RCC_DMA2DRSTS                  \ [0x01] DMA2D reset
    $03 constant RCC_JPEGRSTS                   \ [0x03] JPEG reset
    $04 constant RCC_FMCRSTS                    \ [0x04] FMC reset
    $05 constant RCC_XSPI1RSTS                  \ [0x05] XSPI1 reset
    $06 constant RCC_PSSIRSTS                   \ [0x06] PSSI reset
    $07 constant RCC_SDMMC2RSTS                 \ [0x07] SDMMC2 reset
    $08 constant RCC_SDMMC1RSTS                 \ [0x08] SDMMC1 reset
    $0c constant RCC_XSPI2RSTS                  \ [0x0c] XSPI2 reset
    $0d constant RCC_XSPIMRSTS                  \ [0x0d] XSPIM reset
    $11 constant RCC_XSPI3RSTS                  \ [0x11] XSPI3 reset
    $12 constant RCC_MCE4RSTS                   \ [0x12] MCE4 reset
    $13 constant RCC_GFXMMURSTS                 \ [0x13] GFXMMU reset
    $14 constant RCC_GPURSTS                    \ [0x14] GPU reset
    $17 constant RCC_SYSCFGOTGHSPHY1RSTS        \ [0x17] SYSCFGOTGHSPHY1 reset
    $18 constant RCC_SYSCFGOTGHSPHY2RSTS        \ [0x18] SYSCFGOTGHSPHY2 reset
    $19 constant RCC_ETH1RSTS                   \ [0x19] ETH1 reset
    $1a constant RCC_OTG1RSTS                   \ [0x1a] OTG1 reset
    $1b constant RCC_OTGPHY1RSTS                \ [0x1b] OTGPHY1 reset
    $1c constant RCC_OTGPHY2RSTS                \ [0x1c] OTGPHY2 reset
    $1d constant RCC_OTG2RSTS                   \ [0x1d] OTG2 reset
    $1e constant RCC_NPUCACHERSTS               \ [0x1e] NPUCACHE reset
    $1f constant RCC_NPURSTS                    \ [0x1f] NPU reset
  [then]


  [ifdef] RCC_RCC_APB1LRSTSR_DEF
    \
    \ @brief RCC APB1L reset register
    \ Address offset: 0xA24
    \ Reset value: 0x00000000
    \
    $00 constant RCC_TIM2RSTS                   \ [0x00] TIM2 reset
    $01 constant RCC_TIM3RSTS                   \ [0x01] TIM3 reset
    $02 constant RCC_TIM4RSTS                   \ [0x02] TIM4 reset
    $03 constant RCC_TIM5RSTS                   \ [0x03] TIM5 reset
    $04 constant RCC_TIM6RSTS                   \ [0x04] TIM6 reset
    $05 constant RCC_TIM7RSTS                   \ [0x05] TIM7 reset
    $06 constant RCC_TIM12RSTS                  \ [0x06] TIM12 reset
    $07 constant RCC_TIM13RSTS                  \ [0x07] TIM13 reset
    $08 constant RCC_TIM14RSTS                  \ [0x08] TIM14 reset
    $09 constant RCC_LPTIM1RSTS                 \ [0x09] LPTIM1 reset
    $0b constant RCC_WWDGRSTS                   \ [0x0b] WWDG reset
    $0c constant RCC_TIM10RSTS                  \ [0x0c] TIM10 reset
    $0d constant RCC_TIM11RSTS                  \ [0x0d] TIM11 reset
    $0e constant RCC_SPI2RSTS                   \ [0x0e] SPI2 reset
    $0f constant RCC_SPI3RSTS                   \ [0x0f] SPI3 reset
    $10 constant RCC_SPDIFRX1RSTS               \ [0x10] SPDIFRX1 reset
    $11 constant RCC_USART2RSTS                 \ [0x11] USART2 reset
    $12 constant RCC_USART3RSTS                 \ [0x12] USART3 reset
    $13 constant RCC_UART4RSTS                  \ [0x13] UART4 reset
    $14 constant RCC_UART5RSTS                  \ [0x14] UART5 reset
    $15 constant RCC_I2C1RSTS                   \ [0x15] I2C1 reset
    $16 constant RCC_I2C2RSTS                   \ [0x16] I2C2 reset
    $17 constant RCC_I2C3RSTS                   \ [0x17] I2C3 reset
    $18 constant RCC_I3C1RSTS                   \ [0x18] I3C1 reset
    $19 constant RCC_I3C2RSTS                   \ [0x19] I3C2 reset
    $1e constant RCC_UART7RSTS                  \ [0x1e] UART7 reset
    $1f constant RCC_UART8RSTS                  \ [0x1f] UART8 reset
  [then]


  [ifdef] RCC_RCC_APB1HRSTSR_DEF
    \
    \ @brief RCC APB1H reset register
    \ Address offset: 0xA28
    \ Reset value: 0x00000000
    \
    $05 constant RCC_MDIOSRSTS                  \ [0x05] MDIOS reset
    $08 constant RCC_FDCANRSTS                  \ [0x08] FDCAN reset
    $12 constant RCC_UCPD1RSTS                  \ [0x12] UCPD1 reset
  [then]


  [ifdef] RCC_RCC_APB2RSTSR_DEF
    \
    \ @brief RCC APB2 reset register
    \ Address offset: 0xA2C
    \ Reset value: 0x00000000
    \
    $00 constant RCC_TIM1RSTS                   \ [0x00] TIM1 reset
    $01 constant RCC_TIM8RSTS                   \ [0x01] TIM8 reset
    $04 constant RCC_USART1RSTS                 \ [0x04] USART1 reset
    $05 constant RCC_USART6RSTS                 \ [0x05] USART6 reset
    $06 constant RCC_UART9RSTS                  \ [0x06] UART9 reset
    $07 constant RCC_USART10RSTS                \ [0x07] USART10 reset
    $0c constant RCC_SPI1RSTS                   \ [0x0c] SPI1 reset
    $0d constant RCC_SPI4RSTS                   \ [0x0d] SPI4 reset
    $0f constant RCC_TIM18RSTS                  \ [0x0f] TIM18 reset
    $10 constant RCC_TIM15RSTS                  \ [0x10] TIM15 reset
    $11 constant RCC_TIM16RSTS                  \ [0x11] TIM16 reset
    $12 constant RCC_TIM17RSTS                  \ [0x12] TIM17 reset
    $13 constant RCC_TIM9RSTS                   \ [0x13] TIM9 reset
    $14 constant RCC_SPI5RSTS                   \ [0x14] SPI5 reset
    $15 constant RCC_SAI1RSTS                   \ [0x15] SAI1 reset
    $16 constant RCC_SAI2RSTS                   \ [0x16] SAI2 reset
  [then]


  [ifdef] RCC_RCC_APB4LRSTSR_DEF
    \
    \ @brief RCC APB4L reset register
    \ Address offset: 0xA34
    \ Reset value: 0x00000000
    \
    $02 constant RCC_HDPRSTS                    \ [0x02] HDP reset
    $03 constant RCC_LPUART1RSTS                \ [0x03] LPUART1 reset
    $05 constant RCC_SPI6RSTS                   \ [0x05] SPI6 reset
    $07 constant RCC_I2C4RSTS                   \ [0x07] I2C4 reset
    $09 constant RCC_LPTIM2RSTS                 \ [0x09] LPTIM2 reset
    $0a constant RCC_LPTIM3RSTS                 \ [0x0a] LPTIM3 reset
    $0b constant RCC_LPTIM4RSTS                 \ [0x0b] LPTIM4 reset
    $0c constant RCC_LPTIM5RSTS                 \ [0x0c] LPTIM5 reset
    $0f constant RCC_VREFBUFRSTS                \ [0x0f] VREFBUF reset
    $10 constant RCC_RTCRSTS                    \ [0x10] RTC reset
    $16 constant RCC_R2GRETRSTS                 \ [0x16] R2GRET reset
    $17 constant RCC_R2GNPURSTS                 \ [0x17] R2GNPU reset
    $1f constant RCC_SERFRSTS                   \ [0x1f] SERF reset
  [then]


  [ifdef] RCC_RCC_APB4HRSTSR_DEF
    \
    \ @brief RCC APB4H reset register
    \ Address offset: 0xA38
    \ Reset value: 0x00000000
    \
    $00 constant RCC_SYSCFGRSTS                 \ [0x00] SYSCFG reset
    $02 constant RCC_DTSRSTS                    \ [0x02] DTS reset
    $04 constant RCC_BUSPERFMRSTS               \ [0x04] BUSPERFM reset
  [then]


  [ifdef] RCC_RCC_APB5RSTSR_DEF
    \
    \ @brief RCC APB5 reset register
    \ Address offset: 0xA3C
    \ Reset value: 0x00000000
    \
    $01 constant RCC_LTDCRSTS                   \ [0x01] LTDC reset
    $02 constant RCC_DCMIPPRSTS                 \ [0x02] DCMIPP reset
    $04 constant RCC_GFXTIMRSTS                 \ [0x04] GFXTIM reset
    $05 constant RCC_VENCRSTS                   \ [0x05] VENC reset
    $06 constant RCC_CSIRSTS                    \ [0x06] CSI reset
  [then]


  [ifdef] RCC_RCC_DIVENSR_DEF
    \
    \ @brief RCC Divider enable register
    \ Address offset: 0xA40
    \ Reset value: 0x00000000
    \
    $00 constant RCC_IC1ENS                     \ [0x00] IC1 enable
    $01 constant RCC_IC2ENS                     \ [0x01] IC2 enable
    $02 constant RCC_IC3ENS                     \ [0x02] IC3 enable
    $03 constant RCC_IC4ENS                     \ [0x03] IC4 enable
    $04 constant RCC_IC5ENS                     \ [0x04] IC5 enable
    $05 constant RCC_IC6ENS                     \ [0x05] IC6 enable
    $06 constant RCC_IC7ENS                     \ [0x06] IC7 enable
    $07 constant RCC_IC8ENS                     \ [0x07] IC8 enable
    $08 constant RCC_IC9ENS                     \ [0x08] IC9 enable
    $09 constant RCC_IC10ENS                    \ [0x09] IC10 enable
    $0a constant RCC_IC11ENS                    \ [0x0a] IC11 enable
    $0b constant RCC_IC12ENS                    \ [0x0b] IC12 enable
    $0c constant RCC_IC13ENS                    \ [0x0c] IC13 enable
    $0d constant RCC_IC14ENS                    \ [0x0d] IC14 enable
    $0e constant RCC_IC15ENS                    \ [0x0e] IC15 enable
    $0f constant RCC_IC16ENS                    \ [0x0f] IC16 enable
    $10 constant RCC_IC17ENS                    \ [0x10] IC17 enable
    $11 constant RCC_IC18ENS                    \ [0x11] IC18 enable
    $12 constant RCC_IC19ENS                    \ [0x12] IC19 enable
    $13 constant RCC_IC20ENS                    \ [0x13] IC20 enable
  [then]


  [ifdef] RCC_RCC_BUSENSR_DEF
    \
    \ @brief RCC bus enable register
    \ Address offset: 0xA44
    \ Reset value: 0x00000000
    \
    $00 constant RCC_ACLKNENS                   \ [0x00] ACLKN enable
    $01 constant RCC_ACLKNCENS                  \ [0x01] ACLKNC enable
    $02 constant RCC_AHBMENS                    \ [0x02] AHBM enable
    $03 constant RCC_AHB1ENS                    \ [0x03] AHB1 enable
    $04 constant RCC_AHB2ENS                    \ [0x04] AHB2 enable
    $05 constant RCC_AHB3ENS                    \ [0x05] AHB3 enable
    $06 constant RCC_AHB4ENS                    \ [0x06] AHB4 enable
    $07 constant RCC_AHB5ENS                    \ [0x07] AHB5 enable
    $08 constant RCC_APB1ENS                    \ [0x08] APB1 enable
    $09 constant RCC_APB2ENS                    \ [0x09] APB2 enable
    $0a constant RCC_APB3ENS                    \ [0x0a] APB3 enable
    $0b constant RCC_APB4ENS                    \ [0x0b] APB4 enable
    $0c constant RCC_APB5ENS                    \ [0x0c] APB5 enable
  [then]


  [ifdef] RCC_RCC_MISCENSR_DEF
    \
    \ @brief RCC miscellaneous enable register
    \ Address offset: 0xA48
    \ Reset value: 0x00000000
    \
    $00 constant RCC_DBGENS                     \ [0x00] DBG enable
    $01 constant RCC_MCO1ENS                    \ [0x01] MCO1 enable
    $02 constant RCC_MCO2ENS                    \ [0x02] MCO2 enable
    $03 constant RCC_XSPIPHYCOMPENS             \ [0x03] XSPIPHYCOMP enable
    $06 constant RCC_PERENS                     \ [0x06] PER enable
  [then]


  [ifdef] RCC_RCC_MEMENSR_DEF
    \
    \ @brief RCC memory enable register
    \ Address offset: 0xA4C
    \ Reset value: 0x00000000
    \
    $00 constant RCC_AXISRAM3ENS                \ [0x00] AXISRAM3 enable
    $01 constant RCC_AXISRAM4ENS                \ [0x01] AXISRAM4 enable
    $02 constant RCC_AXISRAM5ENS                \ [0x02] AXISRAM5 enable
    $03 constant RCC_AXISRAM6ENS                \ [0x03] AXISRAM6 enable
    $04 constant RCC_AHBSRAM1ENS                \ [0x04] AHBSRAM1 enable
    $05 constant RCC_AHBSRAM2ENS                \ [0x05] AHBSRAM2 enable
    $06 constant RCC_BKPSRAMENS                 \ [0x06] BKPSRAM enable
    $07 constant RCC_AXISRAM1ENS                \ [0x07] AXISRAM1 enable
    $08 constant RCC_AXISRAM2ENS                \ [0x08] AXISRAM2 enable
    $09 constant RCC_FLEXRAMENS                 \ [0x09] FLEXRAM enable
    $0a constant RCC_NPUCACHERAMENS             \ [0x0a] NPUCACHERAM enable
    $0b constant RCC_VENCRAMENS                 \ [0x0b] VENCRAM enable
    $0c constant RCC_BOOTROMENS                 \ [0x0c] BOOTROM enable
  [then]


  [ifdef] RCC_RCC_AHB1ENSR_DEF
    \
    \ @brief RCC AHB1 enable register
    \ Address offset: 0xA50
    \ Reset value: 0x00000000
    \
    $04 constant RCC_GPDMA1ENS                  \ [0x04] GPDMA1 enable
    $05 constant RCC_ADC12ENS                   \ [0x05] ADC12 enable
  [then]


  [ifdef] RCC_RCC_AHB2ENSR_DEF
    \
    \ @brief RCC AHB2 enable register
    \ Address offset: 0xA54
    \ Reset value: 0x00000000
    \
    $0c constant RCC_RAMCFGENS                  \ [0x0c] RAMCFG enable
    $10 constant RCC_MDF1ENS                    \ [0x10] MDF1 enable
    $11 constant RCC_ADF1ENS                    \ [0x11] ADF1 enable
  [then]


  [ifdef] RCC_RCC_AHB3ENSR_DEF
    \
    \ @brief RCC AHB3 enable register
    \ Address offset: 0xA58
    \ Reset value: 0x00000000
    \
    $00 constant RCC_RNGENS                     \ [0x00] RNG enable
    $01 constant RCC_HASHENS                    \ [0x01] HASH enable
    $02 constant RCC_CRYPENS                    \ [0x02] CRYP enable
    $04 constant RCC_SAESENS                    \ [0x04] SAES enable
    $08 constant RCC_PKAENS                     \ [0x08] PKA enable
    $09 constant RCC_RIFSCENS                   \ [0x09] RIFSC enable
    $0a constant RCC_IACENS                     \ [0x0a] IAC enable
    $0e constant RCC_RISAFENS                   \ [0x0e] RISAF enable
  [then]


  [ifdef] RCC_RCC_AHB4ENSR_DEF
    \
    \ @brief RCC AHB4 enable register
    \ Address offset: 0xA5C
    \ Reset value: 0x00000000
    \
    $00 constant RCC_GPIOAENS                   \ [0x00] GPIOA enable
    $01 constant RCC_GPIOBENS                   \ [0x01] GPIOB enable
    $02 constant RCC_GPIOCENS                   \ [0x02] GPIOC enable
    $03 constant RCC_GPIODENS                   \ [0x03] GPIOD enable
    $04 constant RCC_GPIOEENS                   \ [0x04] GPIOE enable
    $05 constant RCC_GPIOFENS                   \ [0x05] GPIOF enable
    $06 constant RCC_GPIOGENS                   \ [0x06] GPIOG enable
    $07 constant RCC_GPIOHENS                   \ [0x07] GPIOH enable
    $0d constant RCC_GPIONENS                   \ [0x0d] GPION enable
    $0e constant RCC_GPIOOENS                   \ [0x0e] GPIOO enable
    $0f constant RCC_GPIOPENS                   \ [0x0f] GPIOP enable
    $10 constant RCC_GPIOQENS                   \ [0x10] GPIOQ enable
    $12 constant RCC_PWRENS                     \ [0x12] PWR enable
    $13 constant RCC_CRCENS                     \ [0x13] CRC enable
  [then]


  [ifdef] RCC_RCC_AHB5ENSR_DEF
    \
    \ @brief RCC AHB5 enable register
    \ Address offset: 0xA60
    \ Reset value: 0x00000000
    \
    $00 constant RCC_HPDMA1ENS                  \ [0x00] HPDMA1 enable
    $01 constant RCC_DMA2DENS                   \ [0x01] DMA2D enable
    $03 constant RCC_JPEGENS                    \ [0x03] JPEG enable
    $04 constant RCC_FMCENS                     \ [0x04] FMC enable
    $05 constant RCC_XSPI1ENS                   \ [0x05] XSPI1 enable
    $06 constant RCC_PSSIENS                    \ [0x06] PSSI enable
    $07 constant RCC_SDMMC2ENS                  \ [0x07] SDMMC2 enable
    $08 constant RCC_SDMMC1ENS                  \ [0x08] SDMMC1 enable
    $0c constant RCC_XSPI2ENS                   \ [0x0c] XSPI2 enable
    $0d constant RCC_XSPIMENS                   \ [0x0d] XSPIM enable
    $0e constant RCC_MCE1ENS                    \ [0x0e] MCE1 enable
    $0f constant RCC_MCE2ENS                    \ [0x0f] MCE2 enable
    $10 constant RCC_MCE3ENS                    \ [0x10] MCE3 enable
    $11 constant RCC_XSPI3ENS                   \ [0x11] XSPI3 enable
    $12 constant RCC_MCE4ENS                    \ [0x12] MCE4 enable
    $13 constant RCC_GFXMMUENS                  \ [0x13] GFXMMU enable
    $14 constant RCC_GPUENS                     \ [0x14] GPU enable
    $16 constant RCC_ETH1MACENS                 \ [0x16] ETH1MAC enable
    $17 constant RCC_ETH1TXENS                  \ [0x17] ETH1TX enable
    $18 constant RCC_ETH1RXENS                  \ [0x18] ETH1RX enable
    $19 constant RCC_ETH1ENS                    \ [0x19] ETH1 enable
    $1a constant RCC_OTG1ENS                    \ [0x1a] OTG1 enable
    $1b constant RCC_OTGPHY1ENS                 \ [0x1b] OTGPHY1 enable
    $1c constant RCC_OTGPHY2ENS                 \ [0x1c] OTGPHY2 enable
    $1d constant RCC_OTG2ENS                    \ [0x1d] OTG2 enable
    $1e constant RCC_NPUCACHEENS                \ [0x1e] NPUCACHE enable
    $1f constant RCC_NPUENS                     \ [0x1f] NPU enable
  [then]


  [ifdef] RCC_RCC_APB1LENSR_DEF
    \
    \ @brief RCC APB1L enable register
    \ Address offset: 0xA64
    \ Reset value: 0x00000000
    \
    $00 constant RCC_TIM2ENS                    \ [0x00] TIM2 enable
    $01 constant RCC_TIM3ENS                    \ [0x01] TIM3 enable
    $02 constant RCC_TIM4ENS                    \ [0x02] TIM4 enable
    $03 constant RCC_TIM5ENS                    \ [0x03] TIM5 enable
    $04 constant RCC_TIM6ENS                    \ [0x04] TIM6 enable
    $05 constant RCC_TIM7ENS                    \ [0x05] TIM7 enable
    $06 constant RCC_TIM12ENS                   \ [0x06] TIM12 enable
    $07 constant RCC_TIM13ENS                   \ [0x07] TIM13 enable
    $08 constant RCC_TIM14ENS                   \ [0x08] TIM14 enable
    $09 constant RCC_LPTIM1ENS                  \ [0x09] LPTIM1 enable
    $0b constant RCC_WWDGENS                    \ [0x0b] WWDG enable
    $0c constant RCC_TIM10ENS                   \ [0x0c] TIM10 enable
    $0d constant RCC_TIM11ENS                   \ [0x0d] TIM11 enable
    $0e constant RCC_SPI2ENS                    \ [0x0e] SPI2 enable
    $0f constant RCC_SPI3ENS                    \ [0x0f] SPI3 enable
    $10 constant RCC_SPDIFRX1ENS                \ [0x10] SPDIFRX1 enable
    $11 constant RCC_USART2ENS                  \ [0x11] USART2 enable
    $12 constant RCC_USART3ENS                  \ [0x12] USART3 enable
    $13 constant RCC_UART4ENS                   \ [0x13] UART4 enable
    $14 constant RCC_UART5ENS                   \ [0x14] UART5 enable
    $15 constant RCC_I2C1ENS                    \ [0x15] I2C1 enable
    $16 constant RCC_I2C2ENS                    \ [0x16] I2C2 enable
    $17 constant RCC_I2C3ENS                    \ [0x17] I2C3 enable
    $18 constant RCC_I3C1ENS                    \ [0x18] I3C1 enable
    $19 constant RCC_I3C2ENS                    \ [0x19] I3C2 enable
    $1e constant RCC_UART7ENS                   \ [0x1e] UART7 enable
    $1f constant RCC_UART8ENS                   \ [0x1f] UART8 enable
  [then]


  [ifdef] RCC_RCC_APB1HENSR_DEF
    \
    \ @brief RCC APB1H enable register
    \ Address offset: 0xA68
    \ Reset value: 0x00000000
    \
    $05 constant RCC_MDIOSENS                   \ [0x05] MDIOS enable
    $08 constant RCC_FDCANENS                   \ [0x08] FDCAN enable
    $12 constant RCC_UCPD1ENS                   \ [0x12] UCPD1 enable
  [then]


  [ifdef] RCC_RCC_APB2ENSR_DEF
    \
    \ @brief RCC APB2 enable register
    \ Address offset: 0xA6C
    \ Reset value: 0x00000000
    \
    $00 constant RCC_TIM1ENS                    \ [0x00] TIM1 enable
    $01 constant RCC_TIM8ENS                    \ [0x01] TIM8 enable
    $04 constant RCC_USART1ENS                  \ [0x04] USART1 enable
    $05 constant RCC_USART6ENS                  \ [0x05] USART6 enable
    $06 constant RCC_UART9ENS                   \ [0x06] UART9 enable
    $07 constant RCC_USART10ENS                 \ [0x07] USART10 enable
    $0c constant RCC_SPI1ENS                    \ [0x0c] SPI1 enable
    $0d constant RCC_SPI4ENS                    \ [0x0d] SPI4 enable
    $0f constant RCC_TIM18ENS                   \ [0x0f] TIM18 enable
    $10 constant RCC_TIM15ENS                   \ [0x10] TIM15 enable
    $11 constant RCC_TIM16ENS                   \ [0x11] TIM16 enable
    $12 constant RCC_TIM17ENS                   \ [0x12] TIM17 enable
    $13 constant RCC_TIM9ENS                    \ [0x13] TIM9 enable
    $14 constant RCC_SPI5ENS                    \ [0x14] SPI5 enable
    $15 constant RCC_SAI1ENS                    \ [0x15] SAI1 enable
    $16 constant RCC_SAI2ENS                    \ [0x16] SAI2 enable
  [then]


  [ifdef] RCC_RCC_APB3ENSR_DEF
    \
    \ @brief RCC APB3 enable register
    \ Address offset: 0xA70
    \ Reset value: 0x00000000
    \
    $02 constant RCC_DFTENS                     \ [0x02] DFT enable
  [then]


  [ifdef] RCC_RCC_APB4LENSR_DEF
    \
    \ @brief RCC APB4L enable register
    \ Address offset: 0xA74
    \ Reset value: 0x00000000
    \
    $02 constant RCC_HDPENS                     \ [0x02] HDP enable
    $03 constant RCC_LPUART1ENS                 \ [0x03] LPUART1 enable
    $05 constant RCC_SPI6ENS                    \ [0x05] SPI6 enable
    $07 constant RCC_I2C4ENS                    \ [0x07] I2C4 enable
    $09 constant RCC_LPTIM2ENS                  \ [0x09] LPTIM2 enable
    $0a constant RCC_LPTIM3ENS                  \ [0x0a] LPTIM3 enable
    $0b constant RCC_LPTIM4ENS                  \ [0x0b] LPTIM4 enable
    $0c constant RCC_LPTIM5ENS                  \ [0x0c] LPTIM5 enable
    $0f constant RCC_VREFBUFENS                 \ [0x0f] VREFBUF enable
    $10 constant RCC_RTCENS                     \ [0x10] RTC enable
    $11 constant RCC_RTCAPBENS                  \ [0x11] RTCAPB enable
    $16 constant RCC_R2GRETENS                  \ [0x16] R2GRET enable
    $17 constant RCC_R2GNPUENS                  \ [0x17] R2GNPU enable
    $1f constant RCC_SERFENS                    \ [0x1f] SERF enable
  [then]


  [ifdef] RCC_RCC_APB4HENSR_DEF
    \
    \ @brief RCC APB4H enable register
    \ Address offset: 0xA78
    \ Reset value: 0x00000000
    \
    $00 constant RCC_SYSCFGENS                  \ [0x00] SYSCFG enable
    $01 constant RCC_BSECENS                    \ [0x01] BSEC enable
    $02 constant RCC_DTSENS                     \ [0x02] DTS enable
    $04 constant RCC_BUSPERFMENS                \ [0x04] BUSPERFM enable
  [then]


  [ifdef] RCC_RCC_APB5ENSR_DEF
    \
    \ @brief RCC APB5 enable register
    \ Address offset: 0xA7C
    \ Reset value: 0x00000000
    \
    $01 constant RCC_LTDCENS                    \ [0x01] LTDC enable
    $02 constant RCC_DCMIPPENS                  \ [0x02] DCMIPP enable
    $04 constant RCC_GFXTIMENS                  \ [0x04] GFXTIM enable
    $05 constant RCC_VENCENS                    \ [0x05] VENC enable
    $06 constant RCC_CSIENS                     \ [0x06] CSI enable
  [then]


  [ifdef] RCC_RCC_DIVLPENSR_DEF
    \
    \ @brief RCC divider Sleep enable register
    \ Address offset: 0xA80
    \ Reset value: 0x00000000
    \
    $00 constant RCC_IC1LPENS                   \ [0x00] IC1 sleep enable
    $01 constant RCC_IC2LPENS                   \ [0x01] IC2 sleep enable
    $02 constant RCC_IC3LPENS                   \ [0x02] IC3 sleep enable
    $03 constant RCC_IC4LPENS                   \ [0x03] IC4 sleep enable
    $04 constant RCC_IC5LPENS                   \ [0x04] IC5 sleep enable
    $05 constant RCC_IC6LPENS                   \ [0x05] IC6 sleep enable
    $06 constant RCC_IC7LPENS                   \ [0x06] IC7 sleep enable
    $07 constant RCC_IC8LPENS                   \ [0x07] IC8 sleep enable
    $08 constant RCC_IC9LPENS                   \ [0x08] IC9 sleep enable
    $09 constant RCC_IC10LPENS                  \ [0x09] IC10 sleep enable
    $0a constant RCC_IC11LPENS                  \ [0x0a] IC11 sleep enable
    $0b constant RCC_IC12LPENS                  \ [0x0b] IC12 sleep enable
    $0c constant RCC_IC13LPENS                  \ [0x0c] IC13 sleep enable
    $0d constant RCC_IC14LPENS                  \ [0x0d] IC14 sleep enable
    $0e constant RCC_IC15LPENS                  \ [0x0e] IC15 sleep enable
    $0f constant RCC_IC16LPENS                  \ [0x0f] IC16 sleep enable
    $10 constant RCC_IC17LPENS                  \ [0x10] IC17 sleep enable
    $11 constant RCC_IC18LPENS                  \ [0x11] IC18 sleep enable
    $12 constant RCC_IC19LPENS                  \ [0x12] IC19 sleep enable
    $13 constant RCC_IC20LPENS                  \ [0x13] IC20 sleep enable
  [then]


  [ifdef] RCC_RCC_BUSLPENSR_DEF
    \
    \ @brief RCC bus Sleep enable register
    \ Address offset: 0xA84
    \ Reset value: 0x00000000
    \
    $00 constant RCC_ACLKNLPENS                 \ [0x00] ACLKN sleep enable
    $01 constant RCC_ACLKNCLPENS                \ [0x01] ACLKNC sleep enable
    $02 constant RCC_AHBMLPENS                  \ [0x02] AHBM sleep enable
    $03 constant RCC_AHB1LPENS                  \ [0x03] AHB1 sleep enable
    $04 constant RCC_AHB2LPENS                  \ [0x04] AHB2 sleep enable
    $05 constant RCC_AHB3LPENS                  \ [0x05] AHB3 sleep enable
    $06 constant RCC_AHB4LPENS                  \ [0x06] AHB4 sleep enable
    $07 constant RCC_AHB5LPENS                  \ [0x07] AHB5 sleep enable
    $08 constant RCC_APB1LPENS                  \ [0x08] APB1 sleep enable
    $09 constant RCC_APB2LPENS                  \ [0x09] APB2 sleep enable
    $0a constant RCC_APB3LPENS                  \ [0x0a] APB3 sleep enable
    $0b constant RCC_APB4LPENS                  \ [0x0b] APB4 sleep enable
    $0c constant RCC_APB5LPENS                  \ [0x0c] APB5 sleep enable
  [then]


  [ifdef] RCC_RCC_MISCLPENSR_DEF
    \
    \ @brief RCC miscellaneous Sleep enable register
    \ Address offset: 0xA88
    \ Reset value: 0x00000000
    \
    $00 constant RCC_DBGLPENS                   \ [0x00] DBG sleep enable
    $03 constant RCC_XSPIPHYCOMPLPENS           \ [0x03] XSPIPHYCOMP sleep enable
    $06 constant RCC_PERLPENS                   \ [0x06] PER sleep enable
  [then]


  [ifdef] RCC_RCC_MEMLPENSR_DEF
    \
    \ @brief RCC memory sleep enable register
    \ Address offset: 0xA8C
    \ Reset value: 0x00000000
    \
    $00 constant RCC_AXISRAM3LPENS              \ [0x00] AXISRAM3 sleep enable
    $01 constant RCC_AXISRAM4LPENS              \ [0x01] AXISRAM4 sleep enable
    $02 constant RCC_AXISRAM5LPENS              \ [0x02] AXISRAM5 sleep enable
    $03 constant RCC_AXISRAM6LPENS              \ [0x03] AXISRAM6 sleep enable
    $04 constant RCC_AHBSRAM1LPENS              \ [0x04] AHBSRAM1 sleep enable
    $05 constant RCC_AHBSRAM2LPENS              \ [0x05] AHBSRAM2 sleep enable
    $06 constant RCC_BKPSRAMLPENS               \ [0x06] BKPSRAM sleep enable
    $07 constant RCC_AXISRAM1LPENS              \ [0x07] AXISRAM1 sleep enable
    $08 constant RCC_AXISRAM2LPENS              \ [0x08] AXISRAM2 sleep enable
    $09 constant RCC_FLEXRAMLPENS               \ [0x09] FLEXRAM sleep enable
    $0a constant RCC_NPUCACHERAMLPENS           \ [0x0a] NPUCACHERAM sleep enable
    $0b constant RCC_VENCRAMLPENS               \ [0x0b] VENCRAM sleep enable
    $0c constant RCC_BOOTROMLPENS               \ [0x0c] BOOTROM sleep enable
  [then]


  [ifdef] RCC_RCC_AHB1LPENSR_DEF
    \
    \ @brief RCC AHB1 Sleep enable register
    \ Address offset: 0xA90
    \ Reset value: 0x00000000
    \
    $04 constant RCC_GPDMA1LPENS                \ [0x04] GPDMA1 sleep enable
    $05 constant RCC_ADC12LPENS                 \ [0x05] ADC12 sleep enable
  [then]


  [ifdef] RCC_RCC_AHB2LPENSR_DEF
    \
    \ @brief RCC AHB2 Sleep enable register
    \ Address offset: 0xA94
    \ Reset value: 0x00000000
    \
    $0c constant RCC_RAMCFGLPENS                \ [0x0c] RAMCFG sleep enable
    $10 constant RCC_MDF1LPENS                  \ [0x10] MDF1 sleep enable
    $11 constant RCC_ADF1LPENS                  \ [0x11] ADF1 sleep enable
  [then]


  [ifdef] RCC_RCC_AHB3LPENSR_DEF
    \
    \ @brief RCC AHB3 Sleep enable register
    \ Address offset: 0xA98
    \ Reset value: 0x00000000
    \
    $00 constant RCC_RNGLPENS                   \ [0x00] RNG sleep enable
    $01 constant RCC_HASHLPENS                  \ [0x01] HASH sleep enable
    $02 constant RCC_CRYPLPENS                  \ [0x02] CRYP sleep enable
    $04 constant RCC_SAESLPENS                  \ [0x04] SAES sleep enable
    $08 constant RCC_PKALPENS                   \ [0x08] PKA sleep enable
    $09 constant RCC_RIFSCLPENS                 \ [0x09] RIFSC sleep enable
    $0a constant RCC_IACLPENS                   \ [0x0a] IAC sleep enable
    $0e constant RCC_RISAFLPENS                 \ [0x0e] RISAF sleep enable
  [then]


  [ifdef] RCC_RCC_AHB4LPENSR_DEF
    \
    \ @brief RCC AHB4 Sleep enable register
    \ Address offset: 0xA9C
    \ Reset value: 0x00000000
    \
    $00 constant RCC_GPIOALPENS                 \ [0x00] GPIOA sleep enable
    $01 constant RCC_GPIOBLPENS                 \ [0x01] GPIOB sleep enable
    $02 constant RCC_GPIOCLPENS                 \ [0x02] GPIOC sleep enable
    $03 constant RCC_GPIODLPENS                 \ [0x03] GPIOD sleep enable
    $04 constant RCC_GPIOELPENS                 \ [0x04] GPIOE sleep enable
    $05 constant RCC_GPIOFLPENS                 \ [0x05] GPIOF sleep enable
    $06 constant RCC_GPIOGLPENS                 \ [0x06] GPIOG sleep enable
    $07 constant RCC_GPIOHLPENS                 \ [0x07] GPIOH sleep enable
    $0d constant RCC_GPIONLPENS                 \ [0x0d] GPION sleep enable
    $0e constant RCC_GPIOOLPENS                 \ [0x0e] GPIOO sleep enable
    $0f constant RCC_GPIOPLPENS                 \ [0x0f] GPIOP sleep enable
    $10 constant RCC_GPIOQLPENS                 \ [0x10] GPIOQ sleep enable
    $12 constant RCC_PWRLPENS                   \ [0x12] PWR sleep enable
    $13 constant RCC_CRCLPENS                   \ [0x13] CRC sleep enable
  [then]


  [ifdef] RCC_RCC_AHB5LPENSR_DEF
    \
    \ @brief RCC AHB5 Sleep enable register
    \ Address offset: 0xAA0
    \ Reset value: 0x00000000
    \
    $00 constant RCC_HPDMA1LPENS                \ [0x00] HPDMA1 sleep enable
    $01 constant RCC_DMA2DLPENS                 \ [0x01] DMA2D sleep enable
    $03 constant RCC_JPEGLPENS                  \ [0x03] JPEG sleep enable
    $04 constant RCC_FMCLPENS                   \ [0x04] FMC sleep enable
    $05 constant RCC_XSPI1LPENS                 \ [0x05] XSPI1 sleep enable
    $06 constant RCC_PSSILPENS                  \ [0x06] PSSI sleep enable
    $07 constant RCC_SDMMC2LPENS                \ [0x07] SDMMC2 sleep enable
    $08 constant RCC_SDMMC1LPENS                \ [0x08] SDMMC1 sleep enable
    $0c constant RCC_XSPI2LPENS                 \ [0x0c] XSPI2 sleep enable
    $0d constant RCC_XSPIMLPENS                 \ [0x0d] XSPIM sleep enable
    $0e constant RCC_MCE1LPENS                  \ [0x0e] MCE1 sleep enable
    $0f constant RCC_MCE2LPENS                  \ [0x0f] MCE2 sleep enable
    $10 constant RCC_MCE3LPENS                  \ [0x10] MCE3 sleep enable
    $11 constant RCC_XSPI3LPENS                 \ [0x11] XSPI3 sleep enable
    $12 constant RCC_MCE4LPENS                  \ [0x12] MCE4 sleep enable
    $13 constant RCC_GFXMMULPENS                \ [0x13] GFXMMU sleep enable
    $14 constant RCC_GPULPENS                   \ [0x14] GPU sleep enable
    $16 constant RCC_ETH1MACLPENS               \ [0x16] ETH1MAC sleep enable
    $17 constant RCC_ETH1TXLPENS                \ [0x17] ETH1TX sleep enable
    $18 constant RCC_ETH1RXLPENS                \ [0x18] ETH1RX sleep enable
    $19 constant RCC_ETH1LPENS                  \ [0x19] ETH1 sleep enable
    $1a constant RCC_OTG1LPENS                  \ [0x1a] OTG1 sleep enable
    $1b constant RCC_OTGPHY1LPENS               \ [0x1b] OTGPHY1 sleep enable
    $1c constant RCC_OTGPHY2LPENS               \ [0x1c] OTGPHY2 sleep enable
    $1d constant RCC_OTG2LPENS                  \ [0x1d] OTG2 sleep enable
    $1e constant RCC_NPUCACHELPENS              \ [0x1e] NPUCACHE sleep enable
    $1f constant RCC_NPULPENS                   \ [0x1f] NPU sleep enable
  [then]


  [ifdef] RCC_RCC_APB1LLPENSR_DEF
    \
    \ @brief RCC APB1L Sleep enable register
    \ Address offset: 0xAA4
    \ Reset value: 0x00000000
    \
    $00 constant RCC_TIM2LPENS                  \ [0x00] TIM2 sleep enable
    $01 constant RCC_TIM3LPENS                  \ [0x01] TIM3 sleep enable
    $02 constant RCC_TIM4LPENS                  \ [0x02] TIM4 sleep enable
    $03 constant RCC_TIM5LPENS                  \ [0x03] TIM5 sleep enable
    $04 constant RCC_TIM6LPENS                  \ [0x04] TIM6 sleep enable
    $05 constant RCC_TIM7LPENS                  \ [0x05] TIM7 sleep enable
    $06 constant RCC_TIM12LPENS                 \ [0x06] TIM12 sleep enable
    $07 constant RCC_TIM13LPENS                 \ [0x07] TIM13 sleep enable
    $08 constant RCC_TIM14LPENS                 \ [0x08] TIM14 sleep enable
    $09 constant RCC_LPTIM1LPENS                \ [0x09] LPTIM1 sleep enable
    $0b constant RCC_WWDGLPENS                  \ [0x0b] WWDG sleep enable
    $0c constant RCC_TIM10LPENS                 \ [0x0c] TIM10 sleep enable
    $0d constant RCC_TIM11LPENS                 \ [0x0d] TIM11 sleep enable
    $0e constant RCC_SPI2LPENS                  \ [0x0e] SPI2 sleep enable
    $0f constant RCC_SPI3LPENS                  \ [0x0f] SPI3 sleep enable
    $10 constant RCC_SPDIFRX1LPENS              \ [0x10] SPDIFRX1 sleep enable
    $11 constant RCC_USART2LPENS                \ [0x11] USART2 sleep enable
    $12 constant RCC_USART3LPENS                \ [0x12] USART3 sleep enable
    $13 constant RCC_UART4LPENS                 \ [0x13] UART4 sleep enable
    $14 constant RCC_UART5LPENS                 \ [0x14] UART5 sleep enable
    $15 constant RCC_I2C1LPENS                  \ [0x15] I2C1 sleep enable
    $16 constant RCC_I2C2LPENS                  \ [0x16] I2C2 sleep enable
    $17 constant RCC_I2C3LPENS                  \ [0x17] I2C3 sleep enable
    $18 constant RCC_I3C1LPENS                  \ [0x18] I3C1 sleep enable
    $19 constant RCC_I3C2LPENS                  \ [0x19] I3C2 sleep enable
    $1e constant RCC_UART7LPENS                 \ [0x1e] UART7 sleep enable
    $1f constant RCC_UART8LPENS                 \ [0x1f] UART8 sleep enable
  [then]


  [ifdef] RCC_RCC_APB1HLPENSR_DEF
    \
    \ @brief RCC APB1H Sleep enable register
    \ Address offset: 0xAA8
    \ Reset value: 0x00000000
    \
    $05 constant RCC_MDIOSLPENS                 \ [0x05] MDIOS sleep enable
    $08 constant RCC_FDCANLPENS                 \ [0x08] FDCAN sleep enable
    $12 constant RCC_UCPD1LPENS                 \ [0x12] UCPD1 sleep enable
  [then]


  [ifdef] RCC_RCC_APB2LPENSR_DEF
    \
    \ @brief RCC APB2 Sleep enable register
    \ Address offset: 0xAAC
    \ Reset value: 0x00000000
    \
    $00 constant RCC_TIM1LPENS                  \ [0x00] TIM1 sleep enable
    $01 constant RCC_TIM8LPENS                  \ [0x01] TIM8 sleep enable
    $04 constant RCC_USART1LPENS                \ [0x04] USART1 sleep enable
    $05 constant RCC_USART6LPENS                \ [0x05] USART6 sleep enable
    $06 constant RCC_UART9LPENS                 \ [0x06] UART9 sleep enable
    $07 constant RCC_USART10LPENS               \ [0x07] USART10 sleep enable
    $0c constant RCC_SPI1LPENS                  \ [0x0c] SPI1 sleep enable
    $0d constant RCC_SPI4LPENS                  \ [0x0d] SPI4 sleep enable
    $0f constant RCC_TIM18LPENS                 \ [0x0f] TIM18 sleep enable
    $10 constant RCC_TIM15LPENS                 \ [0x10] TIM15 sleep enable
    $11 constant RCC_TIM16LPENS                 \ [0x11] TIM16 sleep enable
    $12 constant RCC_TIM17LPENS                 \ [0x12] TIM17 sleep enable
    $13 constant RCC_TIM9LPENS                  \ [0x13] TIM9 sleep enable
    $14 constant RCC_SPI5LPENS                  \ [0x14] SPI5 sleep enable
    $15 constant RCC_SAI1LPENS                  \ [0x15] SAI1 sleep enable
    $16 constant RCC_SAI2LPENS                  \ [0x16] SAI2 sleep enable
  [then]


  [ifdef] RCC_RCC_APB3LPENSR_DEF
    \
    \ @brief RCC APB3 Sleep enable register
    \ Address offset: 0xAB0
    \ Reset value: 0x00000000
    \
    $02 constant RCC_DFTLPENS                   \ [0x02] DFT sleep enable
  [then]


  [ifdef] RCC_RCC_APB4LLPENSR_DEF
    \
    \ @brief RCC APB4L Sleep enable register
    \ Address offset: 0xAB4
    \ Reset value: 0x00000000
    \
    $02 constant RCC_HDPLPENS                   \ [0x02] HDP sleep enable
    $03 constant RCC_LPUART1LPENS               \ [0x03] LPUART1 sleep enable
    $05 constant RCC_SPI6LPENS                  \ [0x05] SPI6 sleep enable
    $07 constant RCC_I2C4LPENS                  \ [0x07] I2C4 sleep enable
    $09 constant RCC_LPTIM2LPENS                \ [0x09] LPTIM2 sleep enable
    $0a constant RCC_LPTIM3LPENS                \ [0x0a] LPTIM3 sleep enable
    $0b constant RCC_LPTIM4LPENS                \ [0x0b] LPTIM4 sleep enable
    $0c constant RCC_LPTIM5LPENS                \ [0x0c] LPTIM5 sleep enable
    $0f constant RCC_VREFBUFLPENS               \ [0x0f] VREFBUF sleep enable
    $10 constant RCC_RTCLPENS                   \ [0x10] RTC sleep enable
    $11 constant RCC_RTCAPBLPENS                \ [0x11] RTCAPB sleep enable
    $16 constant RCC_R2GRETLPENS                \ [0x16] R2GRET sleep enable
    $17 constant RCC_R2GNPULPENS                \ [0x17] R2GNPU sleep enable
    $1f constant RCC_SERFLPENS                  \ [0x1f] SERF sleep enable
  [then]


  [ifdef] RCC_RCC_APB4HLPENSR_DEF
    \
    \ @brief RCC APB4H Sleep enable register
    \ Address offset: 0xAB8
    \ Reset value: 0x00000000
    \
    $00 constant RCC_SYSCFGLPENS                \ [0x00] SYSCFG sleep enable
    $01 constant RCC_BSECLPENS                  \ [0x01] BSEC sleep enable
    $02 constant RCC_DTSLPENS                   \ [0x02] DTS sleep enable
    $04 constant RCC_BUSPERFMLPENS              \ [0x04] BUSPERFM sleep enable
  [then]


  [ifdef] RCC_RCC_APB5LPENSR_DEF
    \
    \ @brief RCC APB5 Sleep enable register
    \ Address offset: 0xABC
    \ Reset value: 0x00000000
    \
    $01 constant RCC_LTDCLPENS                  \ [0x01] LTDC sleep enable
    $02 constant RCC_DCMIPPLPENS                \ [0x02] DCMIPP sleep enable
    $04 constant RCC_GFXTIMLPENS                \ [0x04] GFXTIM sleep enable
    $05 constant RCC_VENCLPENS                  \ [0x05] VENC sleep enable
    $06 constant RCC_CSILPENS                   \ [0x06] CSI sleep enable
  [then]


  [ifdef] RCC_RCC_PRIVCFGSR0_DEF
    \
    \ @brief RCC oscillator privilege configuration register0
    \ Address offset: 0xF84
    \ Reset value: 0x00000000
    \
    $00 constant RCC_LSIPVS                     \ [0x00] Defines the privilege protection of the LSI configuration bits (enable, ready, divider).
    $01 constant RCC_LSEPVS                     \ [0x01] Defines the privilege protection of the LSE configuration bits (enable, ready, divider).
    $02 constant RCC_MSIPVS                     \ [0x02] Defines the privilege protection of the MSI configuration bits (enable, ready, divider).
    $03 constant RCC_HSIPVS                     \ [0x03] Defines the privilege protection of the HSI configuration bits (enable, ready, divider).
    $04 constant RCC_HSEPVS                     \ [0x04] Defines the privilege protection of the HSE configuration bits (enable, ready, divider).
  [then]


  [ifdef] RCC_RCC_PUBCFGSR0_DEF
    \
    \ @brief RCC oscillator public configuration register0
    \ Address offset: 0xF8C
    \ Reset value: 0x00000000
    \
    $00 constant RCC_LSIPUBS                    \ [0x00] Defines the public protection of the LSI configuration bits (enable, ready, divider).
    $01 constant RCC_LSEPUBS                    \ [0x01] Defines the public protection of the LSE configuration bits (enable, ready, divider).
    $02 constant RCC_MSIPUBS                    \ [0x02] Defines the public protection of the MSI configuration bits (enable, ready, divider).
    $03 constant RCC_HSIPUBS                    \ [0x03] Defines the public protection of the HSI configuration bits (enable, ready, divider).
    $04 constant RCC_HSEPUBS                    \ [0x04] Defines the public protection of the HSE configuration bits (enable, ready, divider).
  [then]


  [ifdef] RCC_RCC_PRIVCFGSR1_DEF
    \
    \ @brief RCC PLL privilege configuration register1
    \ Address offset: 0xF94
    \ Reset value: 0x00000000
    \
    $00 constant RCC_PLL1PVS                    \ [0x00] Defines the privilege protection of the PLL1 configuration bits (enable, ready, divider).
    $01 constant RCC_PLL2PVS                    \ [0x01] Defines the privilege protection of the PLL2 configuration bits (enable, ready, divider).
    $02 constant RCC_PLL3PVS                    \ [0x02] Defines the privilege protection of the PLL3 configuration bits (enable, ready, divider).
    $03 constant RCC_PLL4PVS                    \ [0x03] Defines the privilege protection of the PLL4 configuration bits (enable, ready, divider).
  [then]


  [ifdef] RCC_RCC_PUBCFGSR1_DEF
    \
    \ @brief RCC PLL public configuration register1
    \ Address offset: 0xF9C
    \ Reset value: 0x00000000
    \
    $00 constant RCC_PLL1PUBS                   \ [0x00] Defines the public protection of the PLL1 configuration bits (enable, ready, divider).
    $01 constant RCC_PLL2PUBS                   \ [0x01] Defines the public protection of the PLL2 configuration bits (enable, ready, divider).
    $02 constant RCC_PLL3PUBS                   \ [0x02] Defines the public protection of the PLL3 configuration bits (enable, ready, divider).
    $03 constant RCC_PLL4PUBS                   \ [0x03] Defines the public protection of the PLL4 configuration bits (enable, ready, divider).
  [then]


  [ifdef] RCC_RCC_PRIVCFGSR2_DEF
    \
    \ @brief RCC divider privilege configuration register2
    \ Address offset: 0xFA4
    \ Reset value: 0x00000000
    \
    $00 constant RCC_IC1PVS                     \ [0x00] Defines the privilege protection of the IC1 configuration bits (enable, ready, divider).
    $01 constant RCC_IC2PVS                     \ [0x01] Defines the privilege protection of the IC2 configuration bits (enable, ready, divider).
    $02 constant RCC_IC3PVS                     \ [0x02] Defines the privilege protection of the IC3 configuration bits (enable, ready, divider).
    $03 constant RCC_IC4PVS                     \ [0x03] Defines the privilege protection of the IC4 configuration bits (enable, ready, divider).
    $04 constant RCC_IC5PVS                     \ [0x04] Defines the privilege protection of the IC5 configuration bits (enable, ready, divider).
    $05 constant RCC_IC6PVS                     \ [0x05] Defines the privilege protection of the IC6 configuration bits (enable, ready, divider).
    $06 constant RCC_IC7PVS                     \ [0x06] Defines the privilege protection of the IC7 configuration bits (enable, ready, divider).
    $07 constant RCC_IC8PVS                     \ [0x07] Defines the privilege protection of the IC8 configuration bits (enable, ready, divider).
    $08 constant RCC_IC9PVS                     \ [0x08] Defines the privilege protection of the IC9 configuration bits (enable, ready, divider).
    $09 constant RCC_IC10PVS                    \ [0x09] Defines the privilege protection of the IC10 configuration bits (enable, ready, divider).
    $0a constant RCC_IC11PVS                    \ [0x0a] Defines the privilege protection of the IC11 configuration bits (enable, ready, divider).
    $0b constant RCC_IC12PVS                    \ [0x0b] Defines the privilege protection of the IC12 configuration bits (enable, ready, divider).
    $0c constant RCC_IC13PVS                    \ [0x0c] Defines the privilege protection of the IC13 configuration bits (enable, ready, divider).
    $0d constant RCC_IC14PVS                    \ [0x0d] Defines the privilege protection of the IC14 configuration bits (enable, ready, divider).
    $0e constant RCC_IC15PVS                    \ [0x0e] Defines the privilege protection of the IC15 configuration bits (enable, ready, divider).
    $0f constant RCC_IC16PVS                    \ [0x0f] Defines the privilege protection of the IC16 configuration bits (enable, ready, divider).
    $10 constant RCC_IC17PVS                    \ [0x10] Defines the privilege protection of the IC17 configuration bits (enable, ready, divider).
    $11 constant RCC_IC18PVS                    \ [0x11] Defines the privilege protection of the IC18 configuration bits (enable, ready, divider).
    $12 constant RCC_IC19PVS                    \ [0x12] Defines the privilege protection of the IC19 configuration bits (enable, ready, divider).
    $13 constant RCC_IC20PVS                    \ [0x13] Defines the privilege protection of the IC20 configuration bits (enable, ready, divider).
  [then]


  [ifdef] RCC_RCC_PUBCFGSR2_DEF
    \
    \ @brief RCC divider public configuration register2
    \ Address offset: 0xFAC
    \ Reset value: 0x00000000
    \
    $00 constant RCC_IC1PUBS                    \ [0x00] Defines the public protection of the IC1 configuration bits (enable, ready, divider).
    $01 constant RCC_IC2PUBS                    \ [0x01] Defines the public protection of the IC2 configuration bits (enable, ready, divider).
    $02 constant RCC_IC3PUBS                    \ [0x02] Defines the public protection of the IC3 configuration bits (enable, ready, divider).
    $03 constant RCC_IC4PUBS                    \ [0x03] Defines the public protection of the IC4 configuration bits (enable, ready, divider).
    $04 constant RCC_IC5PUBS                    \ [0x04] Defines the public protection of the IC5 configuration bits (enable, ready, divider).
    $05 constant RCC_IC6PUBS                    \ [0x05] Defines the public protection of the IC6 configuration bits (enable, ready, divider).
    $06 constant RCC_IC7PUBS                    \ [0x06] Defines the public protection of the IC7 configuration bits (enable, ready, divider).
    $07 constant RCC_IC8PUBS                    \ [0x07] Defines the public protection of the IC8 configuration bits (enable, ready, divider).
    $08 constant RCC_IC9PUBS                    \ [0x08] Defines the public protection of the IC9 configuration bits (enable, ready, divider).
    $09 constant RCC_IC10PUBS                   \ [0x09] Defines the public protection of the IC10 configuration bits (enable, ready, divider).
    $0a constant RCC_IC11PUBS                   \ [0x0a] Defines the public protection of the IC11 configuration bits (enable, ready, divider).
    $0b constant RCC_IC12PUBS                   \ [0x0b] Defines the public protection of the IC12 configuration bits (enable, ready, divider).
    $0c constant RCC_IC13PUBS                   \ [0x0c] Defines the public protection of the IC13 configuration bits (enable, ready, divider).
    $0d constant RCC_IC14PUBS                   \ [0x0d] Defines the public protection of the IC14 configuration bits (enable, ready, divider).
    $0e constant RCC_IC15PUBS                   \ [0x0e] Defines the public protection of the IC15 configuration bits (enable, ready, divider).
    $0f constant RCC_IC16PUBS                   \ [0x0f] Defines the public protection of the IC16 configuration bits (enable, ready, divider).
    $10 constant RCC_IC17PUBS                   \ [0x10] Defines the public protection of the IC17 configuration bits (enable, ready, divider).
    $11 constant RCC_IC18PUBS                   \ [0x11] Defines the public protection of the IC18 configuration bits (enable, ready, divider).
    $12 constant RCC_IC19PUBS                   \ [0x12] Defines the public protection of the IC19 configuration bits (enable, ready, divider).
    $13 constant RCC_IC20PUBS                   \ [0x13] Defines the public protection of the IC20 configuration bits (enable, ready, divider).
  [then]


  [ifdef] RCC_RCC_SECCFGSR3_DEF
    \
    \ @brief RCC system secure configuration register3
    \ Address offset: 0xFB0
    \ Reset value: 0x00000000
    \
    $00 constant RCC_MODSECS                    \ [0x00] Defines the secure protection of the MOD configuration bits (enable, ready, divider).
    $01 constant RCC_SYSSECS                    \ [0x01] Defines the secure protection of the SYS configuration bits (enable, ready, divider).
    $02 constant RCC_BUSSECS                    \ [0x02] Defines the secure protection of the BUS configuration bits (enable, ready, divider).
    $03 constant RCC_PERSECS                    \ [0x03] Defines the secure protection of the PER configuration bits (enable, ready, divider).
    $04 constant RCC_INTSECS                    \ [0x04] Defines the secure protection of the INT configuration bits (enable, ready, divider).
    $05 constant RCC_RSTSECS                    \ [0x05] Defines the secure protection of the RST configuration bits (enable, ready, divider).
    $06 constant RCC_DFTSECS                    \ [0x06] Defines the secure protection of the DFT configuration bits (enable, ready, divider).
  [then]


  [ifdef] RCC_RCC_PRIVCFGSR3_DEF
    \
    \ @brief RCC system privilege configuration register3
    \ Address offset: 0xFB4
    \ Reset value: 0x00000000
    \
    $00 constant RCC_MODPVS                     \ [0x00] Defines the privilege protection of the MOD configuration bits (enable, ready, divider).
    $01 constant RCC_SYSPVS                     \ [0x01] Defines the privilege protection of the SYS configuration bits (enable, ready, divider).
    $02 constant RCC_BUSPVS                     \ [0x02] Defines the privilege protection of the BUS configuration bits (enable, ready, divider).
    $03 constant RCC_PERPVS                     \ [0x03] Defines the privilege protection of the PER configuration bits (enable, ready, divider).
    $04 constant RCC_INTPVS                     \ [0x04] Defines the privilege protection of the INT configuration bits (enable, ready, divider).
    $05 constant RCC_RSTPVS                     \ [0x05] Defines the privilege protection of the RST configuration bits (enable, ready, divider).
    $06 constant RCC_DFTPVS                     \ [0x06] Defines the privilege protection of the DFT configuration bits (enable, ready, divider).
  [then]


  [ifdef] RCC_RCC_LOCKCFGSR3_DEF
    \
    \ @brief RCC system lock configuration register3
    \ Address offset: 0xFB8
    \ Reset value: 0x00000000
    \
    $00 constant RCC_MODLOCKS                   \ [0x00] Defines the lock protection of the MOD configuration bits (enable, ready, divider).
    $01 constant RCC_SYSLOCKS                   \ [0x01] Defines the lock protection of the SYS configuration bits (enable, ready, divider).
    $02 constant RCC_BUSLOCKS                   \ [0x02] Defines the lock protection of the BUS configuration bits (enable, ready, divider).
    $03 constant RCC_PERLOCKS                   \ [0x03] Defines the lock protection of the PER configuration bits (enable, ready, divider).
    $04 constant RCC_INTLOCKS                   \ [0x04] Defines the lock protection of the INT configuration bits (enable, ready, divider).
    $05 constant RCC_RSTLOCKS                   \ [0x05] Defines the lock protection of the RST configuration bits (enable, ready, divider).
    $06 constant RCC_DFTLOCKS                   \ [0x06] Defines the lock protection of the DFT configuration bits (enable, ready, divider).
  [then]


  [ifdef] RCC_RCC_PUBCFGSR3_DEF
    \
    \ @brief RCC system public configuration register3
    \ Address offset: 0xFBC
    \ Reset value: 0x00000000
    \
    $00 constant RCC_MODPUBS                    \ [0x00] Defines the public protection of the MOD configuration bits (enable, ready, divider).
    $01 constant RCC_SYSPUBS                    \ [0x01] Defines the public protection of the SYS configuration bits (enable, ready, divider).
    $02 constant RCC_BUSPUBS                    \ [0x02] Defines the public protection of the BUS configuration bits (enable, ready, divider).
    $03 constant RCC_PERPUBS                    \ [0x03] Defines the public protection of the PER configuration bits (enable, ready, divider).
    $04 constant RCC_INTPUBS                    \ [0x04] Defines the public protection of the INT configuration bits (enable, ready, divider).
    $05 constant RCC_RSTPUBS                    \ [0x05] Defines the public protection of the RST configuration bits (enable, ready, divider).
    $06 constant RCC_DFTPUBS                    \ [0x06] Defines the public protection of the DFT configuration bits (enable, ready, divider).
  [then]


  [ifdef] RCC_RCC_PRIVCFGSR4_DEF
    \
    \ @brief RCC privilege configuration register4
    \ Address offset: 0xFC4
    \ Reset value: 0x00000000
    \
    $00 constant RCC_ACLKNPVS                   \ [0x00] Defines the privilege protection of the ACLKN configuration bits (enable, ready, divider).
    $01 constant RCC_ACLKNCPVS                  \ [0x01] Defines the privilege protection of the ACLKNC configuration bits (enable, ready, divider).
    $02 constant RCC_AHBMPVS                    \ [0x02] Defines the privilege protection of the AHBM configuration bits (enable, ready, divider).
    $03 constant RCC_AHB1PVS                    \ [0x03] Defines the privilege protection of the AHB1 configuration bits (enable, ready, divider).
    $04 constant RCC_AHB2PVS                    \ [0x04] Defines the privilege protection of the AHB2 configuration bits (enable, ready, divider).
    $05 constant RCC_AHB3PVS                    \ [0x05] Defines the privilege protection of the AHB3 configuration bits (enable, ready, divider).
    $06 constant RCC_AHB4PVS                    \ [0x06] Defines the privilege protection of the AHB4 configuration bits (enable, ready, divider).
    $07 constant RCC_AHB5PVS                    \ [0x07] Defines the privilege protection of the AHB5 configuration bits (enable, ready, divider).
    $08 constant RCC_APB1PVS                    \ [0x08] Defines the privilege protection of the APB1 configuration bits (enable, ready, divider).
    $09 constant RCC_APB2PVS                    \ [0x09] Defines the privilege protection of the APB2 configuration bits (enable, ready, divider).
    $0a constant RCC_APB3PVS                    \ [0x0a] Defines the privilege protection of the APB3 configuration bits (enable, ready, divider).
    $0b constant RCC_APB4PVS                    \ [0x0b] Defines the privilege protection of the APB4 configuration bits (enable, ready, divider).
    $0c constant RCC_APB5PVS                    \ [0x0c] Defines the privilege protection of the APB5 configuration bits (enable, ready, divider).
    $0d constant RCC_NOCPVS                     \ [0x0d] Defines the privilege protection of the NOC configuration bits (enable, ready, divider).
  [then]


  [ifdef] RCC_RCC_PUBCFGSR4_DEF
    \
    \ @brief RCC public configuration register4
    \ Address offset: 0xFCC
    \ Reset value: 0x00000000
    \
    $00 constant RCC_ACLKNPUBS                  \ [0x00] Defines the public protection of the ACLKN configuration bits (enable, ready, divider).
    $01 constant RCC_ACLKNCPUBS                 \ [0x01] Defines the public protection of the ACLKNC configuration bits (enable, ready, divider).
    $02 constant RCC_AHBMPUBS                   \ [0x02] Defines the public protection of the AHBM configuration bits (enable, ready, divider).
    $03 constant RCC_AHB1PUBS                   \ [0x03] Defines the public protection of the AHB1 configuration bits (enable, ready, divider).
    $04 constant RCC_AHB2PUBS                   \ [0x04] Defines the public protection of the AHB2 configuration bits (enable, ready, divider).
    $05 constant RCC_AHB3PUBS                   \ [0x05] Defines the public protection of the AHB3 configuration bits (enable, ready, divider).
    $06 constant RCC_AHB4PUBS                   \ [0x06] Defines the public protection of the AHB4 configuration bits (enable, ready, divider).
    $07 constant RCC_AHB5PUBS                   \ [0x07] Defines the public protection of the AHB5 configuration bits (enable, ready, divider).
    $08 constant RCC_APB1PUBS                   \ [0x08] Defines the public protection of the APB1 configuration bits (enable, ready, divider).
    $09 constant RCC_APB2PUBS                   \ [0x09] Defines the public protection of the APB2 configuration bits (enable, ready, divider).
    $0a constant RCC_APB3PUBS                   \ [0x0a] Defines the public protection of the APB3 configuration bits (enable, ready, divider).
    $0b constant RCC_APB4PUBS                   \ [0x0b] Defines the public protection of the APB4 configuration bits (enable, ready, divider).
    $0c constant RCC_APB5PUBS                   \ [0x0c] Defines the public protection of the APB5 configuration bits (enable, ready, divider).
    $0d constant RCC_NOCPUBS                    \ [0x0d] Defines the public protection of the NOC configuration bits (enable, ready, divider).
  [then]


  [ifdef] RCC_RCC_PUBCFGSR5_DEF
    \
    \ @brief RCC public configuration register4
    \ Address offset: 0xFD0
    \ Reset value: 0x00000000
    \
    $00 constant RCC_AXISRAM3PUBS               \ [0x00] Defines the public protection of the AXISRAM3 configuration bits (enable, ready, divider).
    $01 constant RCC_AXISRAM4PUBS               \ [0x01] Defines the public protection of the AXISRAM4 configuration bits (enable, ready, divider).
    $02 constant RCC_AXISRAM5PUBS               \ [0x02] Defines the public protection of the AXISRAM5 configuration bits (enable, ready, divider).
    $03 constant RCC_AXISRAM6PUBS               \ [0x03] Defines the public protection of the AXISRAM6 configuration bits (enable, ready, divider).
    $04 constant RCC_AHBSRAM1PUBS               \ [0x04] Defines the public protection of the AHBSRAM1 configuration bits (enable, ready, divider).
    $05 constant RCC_AHBSRAM2PUBS               \ [0x05] Defines the public protection of the AHBSRAM2 configuration bits (enable, ready, divider).
    $06 constant RCC_BKPSRAMPUBS                \ [0x06] Defines the public protection of the BKPSRAM configuration bits (enable, ready, divider).
    $07 constant RCC_AXISRAM1PUBS               \ [0x07] Defines the public protection of the AXISRAM1 configuration bits (enable, ready, divider).
    $08 constant RCC_AXISRAM2PUBS               \ [0x08] Defines the public protection of the AXISRAM2 configuration bits (enable, ready, divider).
    $09 constant RCC_FLEXRAMPUBS                \ [0x09] Defines the public protection of the FLEXRAM configuration bits (enable, ready, divider).
    $0a constant RCC_NPUCACHERAMPUBS            \ [0x0a] Defines the public protection of the NPUCACHERAM configuration bits (enable, ready, divider).
    $0b constant RCC_VENCRAMPUBS                \ [0x0b] Defines the public protection of the VENCRAM configuration bits (enable, ready, divider).
  [then]


  [ifdef] RCC_RCC_CCR_DEF
    \
    \ @brief RCC control Clear register
    \ Address offset: 0x1000
    \ Reset value: 0x00000000
    \
    $00 constant RCC_LSIONC                     \ [0x00] LSI oscillator enable in Run/Sleep mode.
    $01 constant RCC_LSEONC                     \ [0x01] LSE oscillator enable in Run/Sleep mode.
    $02 constant RCC_MSIONC                     \ [0x02] MSI oscillator enable in Run/Sleep mode.
    $03 constant RCC_HSIONC                     \ [0x03] HSI oscillator enable in Run/Sleep mode.
    $04 constant RCC_HSEONC                     \ [0x04] HSE oscillator enable in Run/Sleep mode.
    $08 constant RCC_PLL1ONC                    \ [0x08] PLL1 oscillator enable in Run/Sleep mode.
    $09 constant RCC_PLL2ONC                    \ [0x09] PLL2 oscillator enable in Run/Sleep mode.
    $0a constant RCC_PLL3ONC                    \ [0x0a] PLL3 oscillator enable in Run/Sleep mode.
    $0b constant RCC_PLL4ONC                    \ [0x0b] PLL4 oscillator enable in Run/Sleep mode.
  [then]


  [ifdef] RCC_RCC_STOPCCR_DEF
    \
    \ @brief RCC StopCCR configuration register
    \ Address offset: 0x1008
    \ Reset value: 0x00000000
    \
    $00 constant RCC_LSISTOPENC                 \ [0x00] LSI oscillator enable in Run/Sleep mode.
    $01 constant RCC_LSESTOPENC                 \ [0x01] LSE oscillator enable in Run/Sleep mode.
    $02 constant RCC_MSISTOPENC                 \ [0x02] MSI oscillator enable in Run/Sleep mode.
    $03 constant RCC_HSISTOPENC                 \ [0x03] HSI oscillator enable in Run/Sleep mode.
  [then]


  [ifdef] RCC_RCC_BUSRSTCR_DEF
    \
    \ @brief RCC bus reset register
    \ Address offset: 0x1204
    \ Reset value: 0x00000000
    \
    $00 constant RCC_ACLKNRSTC                  \ [0x00] ACLKN reset
    $02 constant RCC_AHBMRSTC                   \ [0x02] AHBM reset
    $03 constant RCC_AHB1RSTC                   \ [0x03] AHB1 reset
    $04 constant RCC_AHB2RSTC                   \ [0x04] AHB2 reset
    $05 constant RCC_AHB3RSTC                   \ [0x05] AHB3 reset
    $06 constant RCC_AHB4RSTC                   \ [0x06] AHB4 reset
    $07 constant RCC_AHB5RSTC                   \ [0x07] AHB5 reset
    $08 constant RCC_APB1RSTC                   \ [0x08] APB1 reset
    $09 constant RCC_APB2RSTC                   \ [0x09] APB2 reset
    $0a constant RCC_APB3RSTC                   \ [0x0a] APB3 reset
    $0b constant RCC_APB4RSTC                   \ [0x0b] APB4 reset
    $0c constant RCC_APB5RSTC                   \ [0x0c] APB5 reset
    $0d constant RCC_NOCRSTC                    \ [0x0d] NOC reset
  [then]


  [ifdef] RCC_RCC_MISCRSTCR_DEF
    \
    \ @brief RCC miscellaneous reset register
    \ Address offset: 0x1208
    \ Reset value: 0x00000000
    \
    $00 constant RCC_DBGRSTC                    \ [0x00] DBG reset
    $04 constant RCC_XSPIPHY1RSTC               \ [0x04] XSPIPHY1 reset
    $05 constant RCC_XSPIPHY2RSTC               \ [0x05] XSPIPHY2 reset
    $07 constant RCC_SDMMC1DLLRSTC              \ [0x07] SDMMC1DLL reset
    $08 constant RCC_SDMMC2DLLRSTC              \ [0x08] SDMMC2DLL reset
  [then]


  [ifdef] RCC_RCC_MEMRSTCR_DEF
    \
    \ @brief RCC memory reset register
    \ Address offset: 0x120C
    \ Reset value: 0x00000000
    \
    $00 constant RCC_AXISRAM3RSTC               \ [0x00] AXISRAM3 reset
    $01 constant RCC_AXISRAM4RSTC               \ [0x01] AXISRAM4 reset
    $02 constant RCC_AXISRAM5RSTC               \ [0x02] AXISRAM5 reset
    $03 constant RCC_AXISRAM6RSTC               \ [0x03] AXISRAM6 reset
    $04 constant RCC_AHBSRAM1RSTC               \ [0x04] AHBSRAM1 reset
    $05 constant RCC_AHBSRAM2RSTC               \ [0x05] AHBSRAM2 reset
    $07 constant RCC_AXISRAM1RSTC               \ [0x07] AXISRAM1 reset
    $08 constant RCC_AXISRAM2RSTC               \ [0x08] AXISRAM2 reset
    $09 constant RCC_FLEXRAMRSTC                \ [0x09] FLEXRAM reset
    $0a constant RCC_NPUCACHERAMRSTC            \ [0x0a] NPUCACHERAM reset
    $0b constant RCC_VENCRAMRSTC                \ [0x0b] VENCRAM reset
    $0c constant RCC_BOOTROMRSTC                \ [0x0c] BOOTROM reset
  [then]


  [ifdef] RCC_RCC_AHB1RSTCR_DEF
    \
    \ @brief RCC AHB1 reset register
    \ Address offset: 0x1210
    \ Reset value: 0x00000000
    \
    $04 constant RCC_GPDMA1RSTC                 \ [0x04] GPDMA1 reset
    $05 constant RCC_ADC12RSTC                  \ [0x05] ADC12 reset
  [then]


  [ifdef] RCC_RCC_AHB2RSTCR_DEF
    \
    \ @brief RCC AHB2 Reset register
    \ Address offset: 0x1214
    \ Reset value: 0x00000000
    \
    $0c constant RCC_RAMCFGRSTC                 \ [0x0c] RAMCFG reset
    $10 constant RCC_MDF1RSTC                   \ [0x10] MDF1 reset
    $11 constant RCC_ADF1RSTC                   \ [0x11] ADF1 reset
  [then]


  [ifdef] RCC_RCC_AHB3RSTCR_DEF
    \
    \ @brief RCC AHB3 reset register
    \ Address offset: 0x1218
    \ Reset value: 0x00000000
    \
    $00 constant RCC_RNGRSTC                    \ [0x00] RNG reset
    $01 constant RCC_HASHRSTC                   \ [0x01] HASH reset
    $02 constant RCC_CRYPRSTC                   \ [0x02] CRYP reset
    $04 constant RCC_SAESRSTC                   \ [0x04] SAES reset
    $08 constant RCC_PKARSTC                    \ [0x08] PKA reset
    $0a constant RCC_IACRSTC                    \ [0x0a] IAC reset
  [then]


  [ifdef] RCC_RCC_AHB4RSTCR_DEF
    \
    \ @brief RCC AHB4 reset register
    \ Address offset: 0x121C
    \ Reset value: 0x00000000
    \
    $00 constant RCC_GPIOARSTC                  \ [0x00] GPIOA reset
    $01 constant RCC_GPIOBRSTC                  \ [0x01] GPIOB reset
    $02 constant RCC_GPIOCRSTC                  \ [0x02] GPIOC reset
    $03 constant RCC_GPIODRSTC                  \ [0x03] GPIOD reset
    $04 constant RCC_GPIOERSTC                  \ [0x04] GPIOE reset
    $05 constant RCC_GPIOFRSTC                  \ [0x05] GPIOF reset
    $06 constant RCC_GPIOGRSTC                  \ [0x06] GPIOG reset
    $07 constant RCC_GPIOHRSTC                  \ [0x07] GPIOH reset
    $0d constant RCC_GPIONRSTC                  \ [0x0d] GPION reset
    $0e constant RCC_GPIOORSTC                  \ [0x0e] GPIOO reset
    $0f constant RCC_GPIOPRSTC                  \ [0x0f] GPIOP reset
    $10 constant RCC_GPIOQRSTC                  \ [0x10] GPIOQ reset
    $12 constant RCC_PWRRSTC                    \ [0x12] PWR reset
    $13 constant RCC_CRCRSTC                    \ [0x13] CRC reset
  [then]


  [ifdef] RCC_RCC_AHB5RSTCR_DEF
    \
    \ @brief RCC AHB5 reset register
    \ Address offset: 0x1220
    \ Reset value: 0x00000000
    \
    $00 constant RCC_HPDMA1RSTC                 \ [0x00] HPDMA1 reset
    $01 constant RCC_DMA2DRSTC                  \ [0x01] DMA2D reset
    $03 constant RCC_JPEGRSTC                   \ [0x03] JPEG reset
    $04 constant RCC_FMCRSTC                    \ [0x04] FMC reset
    $05 constant RCC_XSPI1RSTC                  \ [0x05] XSPI1 reset
    $06 constant RCC_PSSIRSTC                   \ [0x06] PSSI reset
    $07 constant RCC_SDMMC2RSTC                 \ [0x07] SDMMC2 reset
    $08 constant RCC_SDMMC1RSTC                 \ [0x08] SDMMC1 reset
    $0c constant RCC_XSPI2RSTC                  \ [0x0c] XSPI2 reset
    $0d constant RCC_XSPIMRSTC                  \ [0x0d] XSPIM reset
    $11 constant RCC_XSPI3RSTC                  \ [0x11] XSPI3 reset
    $12 constant RCC_MCE4RSTC                   \ [0x12] MCE4 reset
    $13 constant RCC_GFXMMURSTC                 \ [0x13] GFXMMU reset
    $14 constant RCC_GPURSTC                    \ [0x14] GPU reset
    $17 constant RCC_SYSCFGOTGHSPHY1RSTC        \ [0x17] SYSCFGOTGHSPHY1 reset
    $18 constant RCC_SYSCFGOTGHSPHY2RSTC        \ [0x18] SYSCFGOTGHSPHY2 reset
    $19 constant RCC_ETH1RSTC                   \ [0x19] ETH1 reset
    $1a constant RCC_OTG1RSTC                   \ [0x1a] OTG1 reset
    $1b constant RCC_OTGPHY1RSTC                \ [0x1b] OTGPHY1 reset
    $1c constant RCC_OTGPHY2RSTC                \ [0x1c] OTGPHY2 reset
    $1d constant RCC_OTG2RSTC                   \ [0x1d] OTG2 reset
    $1e constant RCC_NPUCACHERSTC               \ [0x1e] NPUCACHE reset
    $1f constant RCC_NPURSTC                    \ [0x1f] NPU reset
  [then]


  [ifdef] RCC_RCC_APB1LRSTCR_DEF
    \
    \ @brief RCC APB1L reset register
    \ Address offset: 0x1224
    \ Reset value: 0x00000000
    \
    $00 constant RCC_TIM2RSTC                   \ [0x00] TIM2 reset
    $01 constant RCC_TIM3RSTC                   \ [0x01] TIM3 reset
    $02 constant RCC_TIM4RSTC                   \ [0x02] TIM4 reset
    $03 constant RCC_TIM5RSTC                   \ [0x03] TIM5 reset
    $04 constant RCC_TIM6RSTC                   \ [0x04] TIM6 reset
    $05 constant RCC_TIM7RSTC                   \ [0x05] TIM7 reset
    $06 constant RCC_TIM12RSTC                  \ [0x06] TIM12 reset
    $07 constant RCC_TIM13RSTC                  \ [0x07] TIM13 reset
    $08 constant RCC_TIM14RSTC                  \ [0x08] TIM14 reset
    $09 constant RCC_LPTIM1RSTC                 \ [0x09] LPTIM1 reset
    $0b constant RCC_WWDGRSTC                   \ [0x0b] WWDG reset
    $0c constant RCC_TIM10RSTC                  \ [0x0c] TIM10 reset
    $0d constant RCC_TIM11RSTC                  \ [0x0d] TIM11 reset
    $0e constant RCC_SPI2RSTC                   \ [0x0e] SPI2 reset
    $0f constant RCC_SPI3RSTC                   \ [0x0f] SPI3 reset
    $10 constant RCC_SPDIFRX1RSTC               \ [0x10] SPDIFRX1 reset
    $11 constant RCC_USART2RSTC                 \ [0x11] USART2 reset
    $12 constant RCC_USART3RSTC                 \ [0x12] USART3 reset
    $13 constant RCC_UART4RSTC                  \ [0x13] UART4 reset
    $14 constant RCC_UART5RSTC                  \ [0x14] UART5 reset
    $15 constant RCC_I2C1RSTC                   \ [0x15] I2C1 reset
    $16 constant RCC_I2C2RSTC                   \ [0x16] I2C2 reset
    $17 constant RCC_I2C3RSTC                   \ [0x17] I2C3 reset
    $18 constant RCC_I3C1RSTC                   \ [0x18] I3C1 reset
    $19 constant RCC_I3C2RSTC                   \ [0x19] I3C2 reset
    $1e constant RCC_UART7RSTC                  \ [0x1e] UART7 reset
    $1f constant RCC_UART8RSTC                  \ [0x1f] UART8 reset
  [then]


  [ifdef] RCC_RCC_APB1HRSTCR_DEF
    \
    \ @brief RCC APB1H reset register
    \ Address offset: 0x1228
    \ Reset value: 0x00000000
    \
    $05 constant RCC_MDIOSRSTC                  \ [0x05] MDIOS reset
    $08 constant RCC_FDCANRSTC                  \ [0x08] FDCAN reset
    $12 constant RCC_UCPD1RSTC                  \ [0x12] UCPD1 reset
  [then]


  [ifdef] RCC_RCC_APB2RSTCR_DEF
    \
    \ @brief RCC APB2 reset register
    \ Address offset: 0x122C
    \ Reset value: 0x00000000
    \
    $00 constant RCC_TIM1RSTC                   \ [0x00] TIM1 reset
    $01 constant RCC_TIM8RSTC                   \ [0x01] TIM8 reset
    $04 constant RCC_USART1RSTC                 \ [0x04] USART1 reset
    $05 constant RCC_USART6RSTC                 \ [0x05] USART6 reset
    $06 constant RCC_UART9RSTC                  \ [0x06] UART9 reset
    $07 constant RCC_USART10RSTC                \ [0x07] USART10 reset
    $0c constant RCC_SPI1RSTC                   \ [0x0c] SPI1 reset
    $0d constant RCC_SPI4RSTC                   \ [0x0d] SPI4 reset
    $0f constant RCC_TIM18RSTC                  \ [0x0f] TIM18 reset
    $10 constant RCC_TIM15RSTC                  \ [0x10] TIM15 reset
    $11 constant RCC_TIM16RSTC                  \ [0x11] TIM16 reset
    $12 constant RCC_TIM17RSTC                  \ [0x12] TIM17 reset
    $13 constant RCC_TIM9RSTC                   \ [0x13] TIM9 reset
    $14 constant RCC_SPI5RSTC                   \ [0x14] SPI5 reset
    $15 constant RCC_SAI1RSTC                   \ [0x15] SAI1 reset
    $16 constant RCC_SAI2RSTC                   \ [0x16] SAI2 reset
  [then]


  [ifdef] RCC_RCC_APB4LRSTCR_DEF
    \
    \ @brief RCC APB4L reset register
    \ Address offset: 0x1234
    \ Reset value: 0x00000000
    \
    $02 constant RCC_HDPRSTC                    \ [0x02] HDP reset
    $03 constant RCC_LPUART1RSTC                \ [0x03] LPUART1 reset
    $05 constant RCC_SPI6RSTC                   \ [0x05] SPI6 reset
    $07 constant RCC_I2C4RSTC                   \ [0x07] I2C4 reset
    $09 constant RCC_LPTIM2RSTC                 \ [0x09] LPTIM2 reset
    $0a constant RCC_LPTIM3RSTC                 \ [0x0a] LPTIM3 reset
    $0b constant RCC_LPTIM4RSTC                 \ [0x0b] LPTIM4 reset
    $0c constant RCC_LPTIM5RSTC                 \ [0x0c] LPTIM5 reset
    $0f constant RCC_VREFBUFRSTC                \ [0x0f] VREFBUF reset
    $10 constant RCC_RTCRSTC                    \ [0x10] RTC reset
    $16 constant RCC_R2GRETRSTC                 \ [0x16] R2GRET reset
    $17 constant RCC_R2GNPURSTC                 \ [0x17] R2GNPU reset
    $1f constant RCC_SERFRSTC                   \ [0x1f] SERF reset
  [then]


  [ifdef] RCC_RCC_APB4HRSTCR_DEF
    \
    \ @brief RCC APB4H reset register
    \ Address offset: 0x1238
    \ Reset value: 0x00000000
    \
    $00 constant RCC_SYSCFGRSTC                 \ [0x00] SYSCFG reset
    $02 constant RCC_DTSRSTC                    \ [0x02] DTS reset
    $04 constant RCC_BUSPERFMRSTC               \ [0x04] BUSPERFM reset
  [then]


  [ifdef] RCC_RCC_APB5RSTCR_DEF
    \
    \ @brief RCC APB5 reset register
    \ Address offset: 0x123C
    \ Reset value: 0x00000000
    \
    $01 constant RCC_LTDCRSTC                   \ [0x01] LTDC reset
    $02 constant RCC_DCMIPPRSTC                 \ [0x02] DCMIPP reset
    $04 constant RCC_GFXTIMRSTC                 \ [0x04] GFXTIM reset
    $05 constant RCC_VENCRSTC                   \ [0x05] VENC reset
    $06 constant RCC_CSIRSTC                    \ [0x06] CSI reset
  [then]


  [ifdef] RCC_RCC_DIVENCR_DEF
    \
    \ @brief RCC divider enable register
    \ Address offset: 0x1240
    \ Reset value: 0x00000000
    \
    $00 constant RCC_IC1ENC                     \ [0x00] IC1 enable
    $01 constant RCC_IC2ENC                     \ [0x01] IC2 enable
    $02 constant RCC_IC3ENC                     \ [0x02] IC3 enable
    $03 constant RCC_IC4ENC                     \ [0x03] IC4 enable
    $04 constant RCC_IC5ENC                     \ [0x04] IC5 enable
    $05 constant RCC_IC6ENC                     \ [0x05] IC6 enable
    $06 constant RCC_IC7ENC                     \ [0x06] IC7 enable
    $07 constant RCC_IC8ENC                     \ [0x07] IC8 enable
    $08 constant RCC_IC9ENC                     \ [0x08] IC9 enable
    $09 constant RCC_IC10ENC                    \ [0x09] IC10 enable
    $0a constant RCC_IC11ENC                    \ [0x0a] IC11 enable
    $0b constant RCC_IC12ENC                    \ [0x0b] IC12 enable
    $0c constant RCC_IC13ENC                    \ [0x0c] IC13 enable
    $0d constant RCC_IC14ENC                    \ [0x0d] IC14 enable
    $0e constant RCC_IC15ENC                    \ [0x0e] IC15 enable
    $0f constant RCC_IC16ENC                    \ [0x0f] IC16 enable
    $10 constant RCC_IC17ENC                    \ [0x10] IC17 enable
    $11 constant RCC_IC18ENC                    \ [0x11] IC18 enable
    $12 constant RCC_IC19ENC                    \ [0x12] IC19 enable
    $13 constant RCC_IC20ENC                    \ [0x13] IC20 enable
  [then]


  [ifdef] RCC_RCC_BUSENCR_DEF
    \
    \ @brief RCC bus enable register
    \ Address offset: 0x1244
    \ Reset value: 0x00000000
    \
    $00 constant RCC_ACLKNENC                   \ [0x00] ACLKN enable
    $01 constant RCC_ACLKNCENC                  \ [0x01] ACLKNC enable
    $02 constant RCC_AHBMENC                    \ [0x02] AHBM enable
    $03 constant RCC_AHB1ENC                    \ [0x03] AHB1 enable
    $04 constant RCC_AHB2ENC                    \ [0x04] AHB2 enable
    $05 constant RCC_AHB3ENC                    \ [0x05] AHB3 enable
    $06 constant RCC_AHB4ENC                    \ [0x06] AHB4 enable
    $07 constant RCC_AHB5ENC                    \ [0x07] AHB5 enable
    $08 constant RCC_APB1ENC                    \ [0x08] APB1 enable
    $09 constant RCC_APB2ENC                    \ [0x09] APB2 enable
    $0a constant RCC_APB3ENC                    \ [0x0a] APB3 enable
    $0b constant RCC_APB4ENC                    \ [0x0b] APB4 enable
    $0c constant RCC_APB5ENC                    \ [0x0c] APB5 enable
  [then]


  [ifdef] RCC_RCC_MISCENCR_DEF
    \
    \ @brief RCC miscellaneous enable register
    \ Address offset: 0x1248
    \ Reset value: 0x00000000
    \
    $00 constant RCC_DBGENC                     \ [0x00] DBG enable
    $01 constant RCC_MCO1ENC                    \ [0x01] MCO1 enable
    $02 constant RCC_MCO2ENC                    \ [0x02] MCO2 enable
    $03 constant RCC_XSPIPHYCOMPENC             \ [0x03] XSPIPHYCOMP enable
    $06 constant RCC_PERENC                     \ [0x06] PER enable
  [then]


  [ifdef] RCC_RCC_MEMENCR_DEF
    \
    \ @brief RCC memory enable register
    \ Address offset: 0x124C
    \ Reset value: 0x00000000
    \
    $00 constant RCC_AXISRAM3ENC                \ [0x00] AXISRAM3 enable
    $01 constant RCC_AXISRAM4ENC                \ [0x01] AXISRAM4 enable
    $02 constant RCC_AXISRAM5ENC                \ [0x02] AXISRAM5 enable
    $03 constant RCC_AXISRAM6ENC                \ [0x03] AXISRAM6 enable
    $04 constant RCC_AHBSRAM1ENC                \ [0x04] AHBSRAM1 enable
    $05 constant RCC_AHBSRAM2ENC                \ [0x05] AHBSRAM2 enable
    $06 constant RCC_BKPSRAMENC                 \ [0x06] BKPSRAM enable
    $07 constant RCC_AXISRAM1ENC                \ [0x07] AXISRAM1 enable
    $08 constant RCC_AXISRAM2ENC                \ [0x08] AXISRAM2 enable
    $09 constant RCC_FLEXRAMENC                 \ [0x09] FLEXRAM enable
    $0a constant RCC_NPUCACHERAMENC             \ [0x0a] NPUCACHERAM enable
    $0b constant RCC_VENCRAMENC                 \ [0x0b] VENCRAM enable
    $0c constant RCC_BOOTROMENC                 \ [0x0c] BOOTROM enable
  [then]


  [ifdef] RCC_RCC_AHB1ENCR_DEF
    \
    \ @brief RCC AHB1 enable register
    \ Address offset: 0x1250
    \ Reset value: 0x00000000
    \
    $04 constant RCC_GPDMA1ENC                  \ [0x04] GPDMA1 enable
    $05 constant RCC_ADC12ENC                   \ [0x05] ADC12 enable
  [then]


  [ifdef] RCC_RCC_AHB2ENCR_DEF
    \
    \ @brief RCC AHB2 enable register
    \ Address offset: 0x1254
    \ Reset value: 0x00000000
    \
    $0c constant RCC_RAMCFGENC                  \ [0x0c] RAMCFG enable
    $10 constant RCC_MDF1ENC                    \ [0x10] MDF1 enable
    $11 constant RCC_ADF1ENC                    \ [0x11] ADF1 enable
  [then]


  [ifdef] RCC_RCC_AHB3ENCR_DEF
    \
    \ @brief RCC AHB3 enable register
    \ Address offset: 0x1258
    \ Reset value: 0x00000000
    \
    $00 constant RCC_RNGENC                     \ [0x00] RNG enable
    $01 constant RCC_HASHENC                    \ [0x01] HASH enable
    $02 constant RCC_CRYPENC                    \ [0x02] CRYP enable
    $04 constant RCC_SAESENC                    \ [0x04] SAES enable
    $08 constant RCC_PKAENC                     \ [0x08] PKA enable
    $09 constant RCC_RIFSCENC                   \ [0x09] RIFSC enable
    $0a constant RCC_IACENC                     \ [0x0a] IAC enable
    $0e constant RCC_RISAFENC                   \ [0x0e] RISAF enable
  [then]


  [ifdef] RCC_RCC_AHB4ENCR_DEF
    \
    \ @brief RCC AHB4 enable register
    \ Address offset: 0x125C
    \ Reset value: 0x00000000
    \
    $00 constant RCC_GPIOAENC                   \ [0x00] GPIOA enable
    $01 constant RCC_GPIOBENC                   \ [0x01] GPIOB enable
    $02 constant RCC_GPIOCENC                   \ [0x02] GPIOC enable
    $03 constant RCC_GPIODENC                   \ [0x03] GPIOD enable
    $04 constant RCC_GPIOEENC                   \ [0x04] GPIOE enable
    $05 constant RCC_GPIOFENC                   \ [0x05] GPIOF enable
    $06 constant RCC_GPIOGENC                   \ [0x06] GPIOG enable
    $07 constant RCC_GPIOHENC                   \ [0x07] GPIOH enable
    $0d constant RCC_GPIONENC                   \ [0x0d] GPION enable
    $0e constant RCC_GPIOOENC                   \ [0x0e] GPIOO enable
    $0f constant RCC_GPIOPENC                   \ [0x0f] GPIOP enable
    $10 constant RCC_GPIOQENC                   \ [0x10] GPIOQ enable
    $12 constant RCC_PWRENC                     \ [0x12] PWR enable
    $13 constant RCC_CRCENC                     \ [0x13] CRC enable
  [then]


  [ifdef] RCC_RCC_AHB5ENCR_DEF
    \
    \ @brief RCC AHB5 enable register
    \ Address offset: 0x1260
    \ Reset value: 0x00000000
    \
    $00 constant RCC_HPDMA1ENC                  \ [0x00] HPDMA1 enable
    $01 constant RCC_DMA2DENC                   \ [0x01] DMA2D enable
    $03 constant RCC_JPEGENC                    \ [0x03] JPEG enable
    $04 constant RCC_FMCENC                     \ [0x04] FMC enable
    $05 constant RCC_XSPI1ENC                   \ [0x05] XSPI1 enable
    $06 constant RCC_PSSIENC                    \ [0x06] PSSI enable
    $07 constant RCC_SDMMC2ENC                  \ [0x07] SDMMC2 enable
    $08 constant RCC_SDMMC1ENC                  \ [0x08] SDMMC1 enable
    $0c constant RCC_XSPI2ENC                   \ [0x0c] XSPI2 enable
    $0d constant RCC_XSPIMENC                   \ [0x0d] XSPIM enable
    $0e constant RCC_MCE1ENC                    \ [0x0e] MCE1 enable
    $0f constant RCC_MCE2ENC                    \ [0x0f] MCE2 enable
    $10 constant RCC_MCE3ENC                    \ [0x10] MCE3 enable
    $11 constant RCC_XSPI3ENC                   \ [0x11] XSPI3 enable
    $12 constant RCC_MCE4ENC                    \ [0x12] MCE4 enable
    $13 constant RCC_GFXMMUENC                  \ [0x13] GFXMMU enable
    $14 constant RCC_GPUENC                     \ [0x14] GPU enable
    $16 constant RCC_ETH1MACENC                 \ [0x16] ETH1MAC enable
    $17 constant RCC_ETH1TXENC                  \ [0x17] ETH1TX enable
    $18 constant RCC_ETH1RXENC                  \ [0x18] ETH1RX enable
    $19 constant RCC_ETH1ENC                    \ [0x19] ETH1 enable
    $1a constant RCC_OTG1ENC                    \ [0x1a] OTG1 enable
    $1b constant RCC_OTGPHY1ENC                 \ [0x1b] OTGPHY1 enable
    $1c constant RCC_OTGPHY2ENC                 \ [0x1c] OTGPHY2 enable
    $1d constant RCC_OTG2ENC                    \ [0x1d] OTG2 enable
    $1e constant RCC_NPUCACHEENC                \ [0x1e] NPUCACHE enable
    $1f constant RCC_NPUENC                     \ [0x1f] NPU enable
  [then]


  [ifdef] RCC_RCC_APB1LENCR_DEF
    \
    \ @brief RCC APB1L enable register
    \ Address offset: 0x1264
    \ Reset value: 0x00000000
    \
    $00 constant RCC_TIM2ENC                    \ [0x00] TIM2 enable
    $01 constant RCC_TIM3ENC                    \ [0x01] TIM3 enable
    $02 constant RCC_TIM4ENC                    \ [0x02] TIM4 enable
    $03 constant RCC_TIM5ENC                    \ [0x03] TIM5 enable
    $04 constant RCC_TIM6ENC                    \ [0x04] TIM6 enable
    $05 constant RCC_TIM7ENC                    \ [0x05] TIM7 enable
    $06 constant RCC_TIM12ENC                   \ [0x06] TIM12 enable
    $07 constant RCC_TIM13ENC                   \ [0x07] TIM13 enable
    $08 constant RCC_TIM14ENC                   \ [0x08] TIM14 enable
    $09 constant RCC_LPTIM1ENC                  \ [0x09] LPTIM1 enable
    $0c constant RCC_TIM10ENC                   \ [0x0c] TIM10 enable
    $0d constant RCC_TIM11ENC                   \ [0x0d] TIM11 enable
    $0e constant RCC_SPI2ENC                    \ [0x0e] SPI2 enable
    $0f constant RCC_SPI3ENC                    \ [0x0f] SPI3 enable
    $10 constant RCC_SPDIFRX1ENC                \ [0x10] SPDIFRX1 enable
    $11 constant RCC_USART2ENC                  \ [0x11] USART2 enable
    $12 constant RCC_USART3ENC                  \ [0x12] USART3 enable
    $13 constant RCC_UART4ENC                   \ [0x13] UART4 enable
    $14 constant RCC_UART5ENC                   \ [0x14] UART5 enable
    $15 constant RCC_I2C1ENC                    \ [0x15] I2C1 enable
    $16 constant RCC_I2C2ENC                    \ [0x16] I2C2 enable
    $17 constant RCC_I2C3ENC                    \ [0x17] I2C3 enable
    $18 constant RCC_I3C1ENC                    \ [0x18] I3C1 enable
    $19 constant RCC_I3C2ENC                    \ [0x19] I3C2 enable
    $1e constant RCC_UART7ENC                   \ [0x1e] UART7 enable
    $1f constant RCC_UART8ENC                   \ [0x1f] UART8 enable
  [then]


  [ifdef] RCC_RCC_APB1HENCR_DEF
    \
    \ @brief RCC APB1H enable register
    \ Address offset: 0x1268
    \ Reset value: 0x00000000
    \
    $05 constant RCC_MDIOSENC                   \ [0x05] MDIOS enable
    $08 constant RCC_FDCANENC                   \ [0x08] FDCAN enable
    $12 constant RCC_UCPD1ENC                   \ [0x12] UCPD1 enable
  [then]


  [ifdef] RCC_RCC_APB2ENCR_DEF
    \
    \ @brief RCC APB2 enable register
    \ Address offset: 0x126C
    \ Reset value: 0x00000000
    \
    $00 constant RCC_TIM1ENC                    \ [0x00] TIM1 enable
    $01 constant RCC_TIM8ENC                    \ [0x01] TIM8 enable
    $04 constant RCC_USART1ENC                  \ [0x04] USART1 enable
    $05 constant RCC_USART6ENC                  \ [0x05] USART6 enable
    $06 constant RCC_UART9ENC                   \ [0x06] UART9 enable
    $07 constant RCC_USART10ENC                 \ [0x07] USART10 enable
    $0c constant RCC_SPI1ENC                    \ [0x0c] SPI1 enable
    $0d constant RCC_SPI4ENC                    \ [0x0d] SPI4 enable
    $0f constant RCC_TIM18ENC                   \ [0x0f] TIM18 enable
    $10 constant RCC_TIM15ENC                   \ [0x10] TIM15 enable
    $11 constant RCC_TIM16ENC                   \ [0x11] TIM16 enable
    $12 constant RCC_TIM17ENC                   \ [0x12] TIM17 enable
    $13 constant RCC_TIM9ENC                    \ [0x13] TIM9 enable
    $14 constant RCC_SPI5ENC                    \ [0x14] SPI5 enable
    $15 constant RCC_SAI1ENC                    \ [0x15] SAI1 enable
    $16 constant RCC_SAI2ENC                    \ [0x16] SAI2 enable
  [then]


  [ifdef] RCC_RCC_APB3ENCR_DEF
    \
    \ @brief RCC APB3 enable register
    \ Address offset: 0x1270
    \ Reset value: 0x00000000
    \
    $02 constant RCC_DFTENC                     \ [0x02] DFT enable
  [then]


  [ifdef] RCC_RCC_APB4LENCR_DEF
    \
    \ @brief RCC APB4L enable register
    \ Address offset: 0x1274
    \ Reset value: 0x00000000
    \
    $02 constant RCC_HDPENC                     \ [0x02] HDP enable
    $03 constant RCC_LPUART1ENC                 \ [0x03] LPUART1 enable
    $05 constant RCC_SPI6ENC                    \ [0x05] SPI6 enable
    $07 constant RCC_I2C4ENC                    \ [0x07] I2C4 enable
    $09 constant RCC_LPTIM2ENC                  \ [0x09] LPTIM2 enable
    $0a constant RCC_LPTIM3ENC                  \ [0x0a] LPTIM3 enable
    $0b constant RCC_LPTIM4ENC                  \ [0x0b] LPTIM4 enable
    $0c constant RCC_LPTIM5ENC                  \ [0x0c] LPTIM5 enable
    $0f constant RCC_VREFBUFENC                 \ [0x0f] VREFBUF enable
    $10 constant RCC_RTCENC                     \ [0x10] RTC enable
    $11 constant RCC_RTCAPBENC                  \ [0x11] RTCAPB enable
    $16 constant RCC_R2GRETENC                  \ [0x16] R2GRET enable
    $17 constant RCC_R2GNPUENC                  \ [0x17] R2GNPU enable
    $1f constant RCC_SERFENC                    \ [0x1f] SERF enable
  [then]


  [ifdef] RCC_RCC_APB4HENCR_DEF
    \
    \ @brief RCC APB4H enable register
    \ Address offset: 0x1278
    \ Reset value: 0x00000000
    \
    $00 constant RCC_SYSCFGENC                  \ [0x00] SYSCFG enable
    $01 constant RCC_BSECENC                    \ [0x01] BSEC enable
    $02 constant RCC_DTSENC                     \ [0x02] DTS enable
    $04 constant RCC_BUSPERFMENC                \ [0x04] BUSPERFM enable
  [then]


  [ifdef] RCC_RCC_APB5ENCR_DEF
    \
    \ @brief RCC APB5 enable register
    \ Address offset: 0x127C
    \ Reset value: 0x00000000
    \
    $01 constant RCC_LTDCENC                    \ [0x01] LTDC enable
    $02 constant RCC_DCMIPPENC                  \ [0x02] DCMIPP enable
    $04 constant RCC_GFXTIMENC                  \ [0x04] GFXTIM enable
    $05 constant RCC_VENCENC                    \ [0x05] VENC enable
    $06 constant RCC_CSIENC                     \ [0x06] CSI enable
  [then]


  [ifdef] RCC_RCC_DIVLPENCR_DEF
    \
    \ @brief RCC divider Sleep enable register
    \ Address offset: 0x1280
    \ Reset value: 0x00000000
    \
    $00 constant RCC_IC1LPENC                   \ [0x00] IC1 sleep enable
    $01 constant RCC_IC2LPENC                   \ [0x01] IC2 sleep enable
    $02 constant RCC_IC3LPENC                   \ [0x02] IC3 sleep enable
    $03 constant RCC_IC4LPENC                   \ [0x03] IC4 sleep enable
    $04 constant RCC_IC5LPENC                   \ [0x04] IC5 sleep enable
    $05 constant RCC_IC6LPENC                   \ [0x05] IC6 sleep enable
    $06 constant RCC_IC7LPENC                   \ [0x06] IC7 sleep enable
    $07 constant RCC_IC8LPENC                   \ [0x07] IC8 sleep enable
    $08 constant RCC_IC9LPENC                   \ [0x08] IC9 sleep enable
    $09 constant RCC_IC10LPENC                  \ [0x09] IC10 sleep enable
    $0a constant RCC_IC11LPENC                  \ [0x0a] IC11 sleep enable
    $0b constant RCC_IC12LPENC                  \ [0x0b] IC12 sleep enable
    $0c constant RCC_IC13LPENC                  \ [0x0c] IC13 sleep enable
    $0d constant RCC_IC14LPENC                  \ [0x0d] IC14 sleep enable
    $0e constant RCC_IC15LPENC                  \ [0x0e] IC15 sleep enable
    $0f constant RCC_IC16LPENC                  \ [0x0f] IC16 sleep enable
    $10 constant RCC_IC17LPENC                  \ [0x10] IC17 sleep enable
    $11 constant RCC_IC18LPENC                  \ [0x11] IC18 sleep enable
    $12 constant RCC_IC19LPENC                  \ [0x12] IC19 sleep enable
    $13 constant RCC_IC20LPENC                  \ [0x13] IC20 sleep enable
  [then]


  [ifdef] RCC_RCC_BUSLPENCR_DEF
    \
    \ @brief RCC bus Sleep enable register
    \ Address offset: 0x1284
    \ Reset value: 0x00000000
    \
    $00 constant RCC_ACLKNLPENC                 \ [0x00] ACLKN sleep enable
    $01 constant RCC_ACLKNCLPENC                \ [0x01] ACLKNC sleep enable
    $02 constant RCC_AHBMLPENC                  \ [0x02] AHBM sleep enable
    $03 constant RCC_AHB1LPENC                  \ [0x03] AHB1 sleep enable
    $04 constant RCC_AHB2LPENC                  \ [0x04] AHB2 sleep enable
    $05 constant RCC_AHB3LPENC                  \ [0x05] AHB3 sleep enable
    $06 constant RCC_AHB4LPENC                  \ [0x06] AHB4 sleep enable
    $07 constant RCC_AHB5LPENC                  \ [0x07] AHB5 sleep enable
    $08 constant RCC_APB1LPENC                  \ [0x08] APB1 sleep enable
    $09 constant RCC_APB2LPENC                  \ [0x09] APB2 sleep enable
    $0a constant RCC_APB3LPENC                  \ [0x0a] APB3 sleep enable
    $0b constant RCC_APB4LPENC                  \ [0x0b] APB4 sleep enable
    $0c constant RCC_APB5LPENC                  \ [0x0c] APB5 sleep enable
  [then]


  [ifdef] RCC_RCC_MISCLPENCR_DEF
    \
    \ @brief RCC miscellaneous Sleep enable register
    \ Address offset: 0x1288
    \ Reset value: 0x00000000
    \
    $00 constant RCC_DBGLPENC                   \ [0x00] DBG sleep enable
    $03 constant RCC_XSPIPHYCOMPLPENC           \ [0x03] XSPIPHYCOMP sleep enable
    $06 constant RCC_PERLPENC                   \ [0x06] PER sleep enable
  [then]


  [ifdef] RCC_RCC_MEMLPENCR_DEF
    \
    \ @brief RCC memory Sleep enable register
    \ Address offset: 0x128C
    \ Reset value: 0x00000000
    \
    $00 constant RCC_AXISRAM3LPENC              \ [0x00] AXISRAM3 sleep enable
    $01 constant RCC_AXISRAM4LPENC              \ [0x01] AXISRAM4 sleep enable
    $02 constant RCC_AXISRAM5LPENC              \ [0x02] AXISRAM5 sleep enable
    $03 constant RCC_AXISRAM6LPENC              \ [0x03] AXISRAM6 sleep enable
    $04 constant RCC_AHBSRAM1LPENC              \ [0x04] AHBSRAM1 sleep enable
    $05 constant RCC_AHBSRAM2LPENC              \ [0x05] AHBSRAM2 sleep enable
    $06 constant RCC_BKPSRAMLPENC               \ [0x06] BKPSRAM sleep enable
    $07 constant RCC_AXISRAM1LPENC              \ [0x07] AXISRAM1 sleep enable
    $08 constant RCC_AXISRAM2LPENC              \ [0x08] AXISRAM2 sleep enable
    $09 constant RCC_FLEXRAMLPENC               \ [0x09] FLEXRAM sleep enable
    $0a constant RCC_NPUCACHERAMLPENC           \ [0x0a] NPUCACHERAM sleep enable
    $0b constant RCC_VENCRAMLPENC               \ [0x0b] VENCRAM sleep enable
    $0c constant RCC_BOOTROMLPENC               \ [0x0c] BOOTROM sleep enable
  [then]


  [ifdef] RCC_RCC_AHB1LPENCR_DEF
    \
    \ @brief RCC AHB1 Sleep enable register
    \ Address offset: 0x1290
    \ Reset value: 0x00000000
    \
    $04 constant RCC_GPDMA1LPENC                \ [0x04] GPDMA1 sleep enable
    $05 constant RCC_ADC12LPENC                 \ [0x05] ADC12 sleep enable
  [then]


  [ifdef] RCC_RCC_AHB2LPENCR_DEF
    \
    \ @brief RCC AHB2 Sleep enable register
    \ Address offset: 0x1294
    \ Reset value: 0x00000000
    \
    $0c constant RCC_RAMCFGLPENC                \ [0x0c] RAMCFG sleep enable
    $10 constant RCC_MDF1LPENC                  \ [0x10] MDF1 sleep enable
    $11 constant RCC_ADF1LPENC                  \ [0x11] ADF1 sleep enable
  [then]


  [ifdef] RCC_RCC_AHB3LPENCR_DEF
    \
    \ @brief RCC AHB3 Sleep enable register
    \ Address offset: 0x1298
    \ Reset value: 0x00000000
    \
    $00 constant RCC_RNGLPENC                   \ [0x00] RNG sleep enable
    $01 constant RCC_HASHLPENC                  \ [0x01] HASH sleep enable
    $02 constant RCC_CRYPLPENC                  \ [0x02] CRYP sleep enable
    $04 constant RCC_SAESLPENC                  \ [0x04] SAES sleep enable
    $08 constant RCC_PKALPENC                   \ [0x08] PKA sleep enable
    $09 constant RCC_RIFSCLPENC                 \ [0x09] RIFSC sleep enable
    $0a constant RCC_IACLPENC                   \ [0x0a] IAC sleep enable
    $0e constant RCC_RISAFLPENC                 \ [0x0e] RISAF sleep enable
  [then]


  [ifdef] RCC_RCC_AHB4LPENCR_DEF
    \
    \ @brief RCC AHB4 Sleep enable register
    \ Address offset: 0x129C
    \ Reset value: 0x00000000
    \
    $00 constant RCC_GPIOALPENC                 \ [0x00] GPIOA sleep enable
    $01 constant RCC_GPIOBLPENC                 \ [0x01] GPIOB sleep enable
    $02 constant RCC_GPIOCLPENC                 \ [0x02] GPIOC sleep enable
    $03 constant RCC_GPIODLPENC                 \ [0x03] GPIOD sleep enable
    $04 constant RCC_GPIOELPENC                 \ [0x04] GPIOE sleep enable
    $05 constant RCC_GPIOFLPENC                 \ [0x05] GPIOF sleep enable
    $06 constant RCC_GPIOGLPENC                 \ [0x06] GPIOG sleep enable
    $07 constant RCC_GPIOHLPENC                 \ [0x07] GPIOH sleep enable
    $0d constant RCC_GPIONLPENC                 \ [0x0d] GPION sleep enable
    $0e constant RCC_GPIOOLPENC                 \ [0x0e] GPIOO sleep enable
    $0f constant RCC_GPIOPLPENC                 \ [0x0f] GPIOP sleep enable
    $10 constant RCC_GPIOQLPENC                 \ [0x10] GPIOQ sleep enable
    $12 constant RCC_PWRLPENC                   \ [0x12] PWR sleep enable
    $13 constant RCC_CRCLPENC                   \ [0x13] CRC sleep enable
  [then]


  [ifdef] RCC_RCC_AHB5LPENCR_DEF
    \
    \ @brief RCC AHB5 Sleep enable register
    \ Address offset: 0x12A0
    \ Reset value: 0x00000000
    \
    $00 constant RCC_HPDMA1LPENC                \ [0x00] HPDMA1 sleep enable
    $01 constant RCC_DMA2DLPENC                 \ [0x01] DMA2D sleep enable
    $03 constant RCC_JPEGLPENC                  \ [0x03] JPEG sleep enable
    $04 constant RCC_FMCLPENC                   \ [0x04] FMC sleep enable
    $05 constant RCC_XSPI1LPENC                 \ [0x05] XSPI1 sleep enable
    $06 constant RCC_PSSILPENC                  \ [0x06] PSSI sleep enable
    $07 constant RCC_SDMMC2LPENC                \ [0x07] SDMMC2 sleep enable
    $08 constant RCC_SDMMC1LPENC                \ [0x08] SDMMC1 sleep enable
    $0c constant RCC_XSPI2LPENC                 \ [0x0c] XSPI2 sleep enable
    $0d constant RCC_XSPIMLPENC                 \ [0x0d] XSPIM sleep enable
    $0e constant RCC_MCE1LPENC                  \ [0x0e] MCE1 sleep enable
    $0f constant RCC_MCE2LPENC                  \ [0x0f] MCE2 sleep enable
    $10 constant RCC_MCE3LPENC                  \ [0x10] MCE3 sleep enable
    $11 constant RCC_XSPI3LPENC                 \ [0x11] XSPI3 sleep enable
    $12 constant RCC_MCE4LPENC                  \ [0x12] MCE4 sleep enable
    $13 constant RCC_GFXMMULPENC                \ [0x13] GFXMMU sleep enable
    $14 constant RCC_GPULPENC                   \ [0x14] GPU sleep enable
    $16 constant RCC_ETH1MACLPENC               \ [0x16] ETH1MAC sleep enable
    $17 constant RCC_ETH1TXLPENC                \ [0x17] ETH1TX sleep enable
    $18 constant RCC_ETH1RXLPENC                \ [0x18] ETH1RX sleep enable
    $19 constant RCC_ETH1LPENC                  \ [0x19] ETH1 sleep enable
    $1a constant RCC_OTG1LPENC                  \ [0x1a] OTG1 sleep enable
    $1b constant RCC_OTGPHY1LPENC               \ [0x1b] OTGPHY1 sleep enable
    $1c constant RCC_OTGPHY2LPENC               \ [0x1c] OTGPHY2 sleep enable
    $1d constant RCC_OTG2LPENC                  \ [0x1d] OTG2 sleep enable
    $1e constant RCC_NPUCACHELPENC              \ [0x1e] NPUCACHE sleep enable
    $1f constant RCC_NPULPENC                   \ [0x1f] NPU sleep enable
  [then]


  [ifdef] RCC_RCC_APB1LLPENCR_DEF
    \
    \ @brief RCC APB1L Sleep enable register
    \ Address offset: 0x12A4
    \ Reset value: 0x00000000
    \
    $00 constant RCC_TIM2LPENC                  \ [0x00] TIM2 sleep enable
    $01 constant RCC_TIM3LPENC                  \ [0x01] TIM3 sleep enable
    $02 constant RCC_TIM4LPENC                  \ [0x02] TIM4 sleep enable
    $03 constant RCC_TIM5LPENC                  \ [0x03] TIM5 sleep enable
    $04 constant RCC_TIM6LPENC                  \ [0x04] TIM6 sleep enable
    $05 constant RCC_TIM7LPENC                  \ [0x05] TIM7 sleep enable
    $06 constant RCC_TIM12LPENC                 \ [0x06] TIM12 sleep enable
    $07 constant RCC_TIM13LPENC                 \ [0x07] TIM13 sleep enable
    $08 constant RCC_TIM14LPENC                 \ [0x08] TIM14 sleep enable
    $09 constant RCC_LPTIM1LPENC                \ [0x09] LPTIM1 sleep enable
    $0b constant RCC_WWDGLPENC                  \ [0x0b] WWDG sleep enable
    $0c constant RCC_TIM10LPENC                 \ [0x0c] TIM10 sleep enable
    $0d constant RCC_TIM11LPENC                 \ [0x0d] TIM11 sleep enable
    $0e constant RCC_SPI2LPENC                  \ [0x0e] SPI2 sleep enable
    $0f constant RCC_SPI3LPENC                  \ [0x0f] SPI3 sleep enable
    $10 constant RCC_SPDIFRX1LPENC              \ [0x10] SPDIFRX1 sleep enable
    $11 constant RCC_USART2LPENC                \ [0x11] USART2 sleep enable
    $12 constant RCC_USART3LPENC                \ [0x12] USART3 sleep enable
    $13 constant RCC_UART4LPENC                 \ [0x13] UART4 sleep enable
    $14 constant RCC_UART5LPENC                 \ [0x14] UART5 sleep enable
    $15 constant RCC_I2C1LPENC                  \ [0x15] I2C1 sleep enable
    $16 constant RCC_I2C2LPENC                  \ [0x16] I2C2 sleep enable
    $17 constant RCC_I2C3LPENC                  \ [0x17] I2C3 sleep enable
    $18 constant RCC_I3C1LPENC                  \ [0x18] I3C1 sleep enable
    $19 constant RCC_I3C2LPENC                  \ [0x19] I3C2 sleep enable
    $1e constant RCC_UART7LPENC                 \ [0x1e] UART7 sleep enable
    $1f constant RCC_UART8LPENC                 \ [0x1f] UART8 sleep enable
  [then]


  [ifdef] RCC_RCC_APB1HLPENCR_DEF
    \
    \ @brief RCC APB1H Sleep enable register
    \ Address offset: 0x12A8
    \ Reset value: 0x00000000
    \
    $05 constant RCC_MDIOSLPENC                 \ [0x05] MDIOS sleep enable
    $08 constant RCC_FDCANLPENC                 \ [0x08] FDCAN sleep enable
    $12 constant RCC_UCPD1LPENC                 \ [0x12] UCPD1 sleep enable
  [then]


  [ifdef] RCC_RCC_APB2LPENCR_DEF
    \
    \ @brief RCC APB2 Sleep enable register
    \ Address offset: 0x12AC
    \ Reset value: 0x00000000
    \
    $00 constant RCC_TIM1LPENC                  \ [0x00] TIM1 sleep enable
    $01 constant RCC_TIM8LPENC                  \ [0x01] TIM8 sleep enable
    $04 constant RCC_USART1LPENC                \ [0x04] USART1 sleep enable
    $05 constant RCC_USART6LPENC                \ [0x05] USART6 sleep enable
    $06 constant RCC_UART9LPENC                 \ [0x06] UART9 sleep enable
    $07 constant RCC_USART10LPENC               \ [0x07] USART10 sleep enable
    $0c constant RCC_SPI1LPENC                  \ [0x0c] SPI1 sleep enable
    $0d constant RCC_SPI4LPENC                  \ [0x0d] SPI4 sleep enable
    $0f constant RCC_TIM18LPENC                 \ [0x0f] TIM18 sleep enable
    $10 constant RCC_TIM15LPENC                 \ [0x10] TIM15 sleep enable
    $11 constant RCC_TIM16LPENC                 \ [0x11] TIM16 sleep enable
    $12 constant RCC_TIM17LPENC                 \ [0x12] TIM17 sleep enable
    $13 constant RCC_TIM9LPENC                  \ [0x13] TIM9 sleep enable
    $14 constant RCC_SPI5LPENC                  \ [0x14] SPI5 sleep enable
    $15 constant RCC_SAI1LPENC                  \ [0x15] SAI1 sleep enable
    $16 constant RCC_SAI2LPENC                  \ [0x16] SAI2 sleep enable
  [then]


  [ifdef] RCC_RCC_APB3LPENCR_DEF
    \
    \ @brief RCC APB3 Sleep enable register
    \ Address offset: 0x12B0
    \ Reset value: 0x00000000
    \
    $02 constant RCC_DFTLPENC                   \ [0x02] DFT sleep enable
  [then]


  [ifdef] RCC_RCC_APB4LLPENCR_DEF
    \
    \ @brief RCC APB4L Sleep enable register
    \ Address offset: 0x12B4
    \ Reset value: 0x00000000
    \
    $02 constant RCC_HDPLPENC                   \ [0x02] HDP sleep enable
    $03 constant RCC_LPUART1LPENC               \ [0x03] LPUART1 sleep enable
    $05 constant RCC_SPI6LPENC                  \ [0x05] SPI6 sleep enable
    $07 constant RCC_I2C4LPENC                  \ [0x07] I2C4 sleep enable
    $09 constant RCC_LPTIM2LPENC                \ [0x09] LPTIM2 sleep enable
    $0a constant RCC_LPTIM3LPENC                \ [0x0a] LPTIM3 sleep enable
    $0b constant RCC_LPTIM4LPENC                \ [0x0b] LPTIM4 sleep enable
    $0c constant RCC_LPTIM5LPENC                \ [0x0c] LPTIM5 sleep enable
    $0f constant RCC_VREFBUFLPENC               \ [0x0f] VREFBUF sleep enable
    $10 constant RCC_RTCLPENC                   \ [0x10] RTC sleep enable
    $11 constant RCC_RTCAPBLPENC                \ [0x11] RTCAPB sleep enable
    $16 constant RCC_R2GRETLPENC                \ [0x16] R2GRET sleep enable
    $17 constant RCC_R2GNPULPENC                \ [0x17] R2GNPU sleep enable
    $1f constant RCC_SERFLPENC                  \ [0x1f] SERF sleep enable
  [then]


  [ifdef] RCC_RCC_APB4HLPENCR_DEF
    \
    \ @brief RCC APB4H Sleep enable register
    \ Address offset: 0x12B8
    \ Reset value: 0x00000000
    \
    $00 constant RCC_SYSCFGLPENC                \ [0x00] SYSCFG sleep enable
    $01 constant RCC_BSECLPENC                  \ [0x01] BSEC sleep enable
    $02 constant RCC_DTSLPENC                   \ [0x02] DTS sleep enable
    $04 constant RCC_BUSPERFMLPENC              \ [0x04] BUSPERFM sleep enable
  [then]


  [ifdef] RCC_RCC_APB5LPENCR_DEF
    \
    \ @brief RCC APB5 Sleep enable register
    \ Address offset: 0x12BC
    \ Reset value: 0x00000000
    \
    $01 constant RCC_LTDCLPENC                  \ [0x01] LTDC sleep enable
    $02 constant RCC_DCMIPPLPENC                \ [0x02] DCMIPP sleep enable
    $04 constant RCC_GFXTIMLPENC                \ [0x04] GFXTIM sleep enable
    $05 constant RCC_VENCLPENC                  \ [0x05] VENC sleep enable
    $06 constant RCC_CSILPENC                   \ [0x06] CSI sleep enable
  [then]


  [ifdef] RCC_RCC_PRIVCFGCR0_DEF
    \
    \ @brief RCC oscillator privilege configuration register0
    \ Address offset: 0x1784
    \ Reset value: 0x00000000
    \
    $00 constant RCC_LSIPVC                     \ [0x00] Defines the privilege protection of the LSI configuration bits (enable, ready, divider).
    $01 constant RCC_LSEPVC                     \ [0x01] Defines the privilege protection of the LSE configuration bits (enable, ready, divider).
    $02 constant RCC_MSIPVC                     \ [0x02] Defines the privilege protection of the MSI configuration bits (enable, ready, divider).
    $03 constant RCC_HSIPVC                     \ [0x03] Defines the privilege protection of the HSI configuration bits (enable, ready, divider).
    $04 constant RCC_HSEPVC                     \ [0x04] Defines the privilege protection of the HSE configuration bits (enable, ready, divider).
  [then]


  [ifdef] RCC_RCC_PUBCFGCR0_DEF
    \
    \ @brief RCC oscillator public configuration register0
    \ Address offset: 0x178C
    \ Reset value: 0x00000000
    \
    $00 constant RCC_LSIPUBC                    \ [0x00] Defines the public protection of the LSI configuration bits (enable, ready, divider).
    $01 constant RCC_LSEPUBC                    \ [0x01] Defines the public protection of the LSE configuration bits (enable, ready, divider).
    $02 constant RCC_MSIPUBC                    \ [0x02] Defines the public protection of the MSI configuration bits (enable, ready, divider).
    $03 constant RCC_HSIPUBC                    \ [0x03] Defines the public protection of the HSI configuration bits (enable, ready, divider).
    $04 constant RCC_HSEPUBC                    \ [0x04] Defines the public protection of the HSE configuration bits (enable, ready, divider).
  [then]


  [ifdef] RCC_RCC_PRIVCFGCR1_DEF
    \
    \ @brief RCC PLL privilege configuration register1
    \ Address offset: 0x1794
    \ Reset value: 0x00000000
    \
    $00 constant RCC_PLL1PVC                    \ [0x00] Defines the privilege protection of the PLL1 configuration bits (enable, ready, divider).
    $01 constant RCC_PLL2PVC                    \ [0x01] Defines the privilege protection of the PLL2 configuration bits (enable, ready, divider).
    $02 constant RCC_PLL3PVC                    \ [0x02] Defines the privilege protection of the PLL3 configuration bits (enable, ready, divider).
    $03 constant RCC_PLL4PVC                    \ [0x03] Defines the privilege protection of the PLL4 configuration bits (enable, ready, divider).
  [then]


  [ifdef] RCC_RCC_PUBCFGCR1_DEF
    \
    \ @brief RCC PLL public configuration register1
    \ Address offset: 0x179C
    \ Reset value: 0x00000000
    \
    $00 constant RCC_PLL1PUBC                   \ [0x00] Defines the public protection of the PLL1 configuration bits (enable, ready, divider).
    $01 constant RCC_PLL2PUBC                   \ [0x01] Defines the public protection of the PLL2 configuration bits (enable, ready, divider).
    $02 constant RCC_PLL3PUBC                   \ [0x02] Defines the public protection of the PLL3 configuration bits (enable, ready, divider).
    $03 constant RCC_PLL4PUBC                   \ [0x03] Defines the public protection of the PLL4 configuration bits (enable, ready, divider).
  [then]


  [ifdef] RCC_RCC_PRIVCFGCR2_DEF
    \
    \ @brief RCC divider privilege configuration register2
    \ Address offset: 0x17A4
    \ Reset value: 0x00000000
    \
    $00 constant RCC_IC1PVC                     \ [0x00] Defines the privilege protection of the IC1 configuration bits (enable, ready, divider).
    $01 constant RCC_IC2PVC                     \ [0x01] Defines the privilege protection of the IC2 configuration bits (enable, ready, divider).
    $02 constant RCC_IC3PVC                     \ [0x02] Defines the privilege protection of the IC3 configuration bits (enable, ready, divider).
    $03 constant RCC_IC4PVC                     \ [0x03] Defines the privilege protection of the IC4 configuration bits (enable, ready, divider).
    $04 constant RCC_IC5PVC                     \ [0x04] Defines the privilege protection of the IC5 configuration bits (enable, ready, divider).
    $05 constant RCC_IC6PVC                     \ [0x05] Defines the privilege protection of the IC6 configuration bits (enable, ready, divider).
    $06 constant RCC_IC7PVC                     \ [0x06] Defines the privilege protection of the IC7 configuration bits (enable, ready, divider).
    $07 constant RCC_IC8PVC                     \ [0x07] Defines the privilege protection of the IC8 configuration bits (enable, ready, divider).
    $08 constant RCC_IC9PVC                     \ [0x08] Defines the privilege protection of the IC9 configuration bits (enable, ready, divider).
    $09 constant RCC_IC10PVC                    \ [0x09] Defines the privilege protection of the IC10 configuration bits (enable, ready, divider).
    $0a constant RCC_IC11PVC                    \ [0x0a] Defines the privilege protection of the IC11 configuration bits (enable, ready, divider).
    $0b constant RCC_IC12PVC                    \ [0x0b] Defines the privilege protection of the IC12 configuration bits (enable, ready, divider).
    $0c constant RCC_IC13PVC                    \ [0x0c] Defines the privilege protection of the IC13 configuration bits (enable, ready, divider).
    $0d constant RCC_IC14PVC                    \ [0x0d] Defines the privilege protection of the IC14 configuration bits (enable, ready, divider).
    $0e constant RCC_IC15PVC                    \ [0x0e] Defines the privilege protection of the IC15 configuration bits (enable, ready, divider).
    $0f constant RCC_IC16PVC                    \ [0x0f] Defines the privilege protection of the IC16 configuration bits (enable, ready, divider).
    $10 constant RCC_IC17PVC                    \ [0x10] Defines the privilege protection of the IC17 configuration bits (enable, ready, divider).
    $11 constant RCC_IC18PVC                    \ [0x11] Defines the privilege protection of the IC18 configuration bits (enable, ready, divider).
    $12 constant RCC_IC19PVC                    \ [0x12] Defines the privilege protection of the IC19 configuration bits (enable, ready, divider).
    $13 constant RCC_IC20PVC                    \ [0x13] Defines the privilege protection of the IC20 configuration bits (enable, ready, divider).
  [then]


  [ifdef] RCC_RCC_PUBCFGCR2_DEF
    \
    \ @brief RCC divider public configuration register2
    \ Address offset: 0x17AC
    \ Reset value: 0x00000000
    \
    $00 constant RCC_IC1PUBC                    \ [0x00] Defines the public protection of the IC1 configuration bits (enable, ready, divider).
    $01 constant RCC_IC2PUBC                    \ [0x01] Defines the public protection of the IC2 configuration bits (enable, ready, divider).
    $02 constant RCC_IC3PUBC                    \ [0x02] Defines the public protection of the IC3 configuration bits (enable, ready, divider).
    $03 constant RCC_IC4PUBC                    \ [0x03] Defines the public protection of the IC4 configuration bits (enable, ready, divider).
    $04 constant RCC_IC5PUBC                    \ [0x04] Defines the public protection of the IC5 configuration bits (enable, ready, divider).
    $05 constant RCC_IC6PUBC                    \ [0x05] Defines the public protection of the IC6 configuration bits (enable, ready, divider).
    $06 constant RCC_IC7PUBC                    \ [0x06] Defines the public protection of the IC7 configuration bits (enable, ready, divider).
    $07 constant RCC_IC8PUBC                    \ [0x07] Defines the public protection of the IC8 configuration bits (enable, ready, divider).
    $08 constant RCC_IC9PUBC                    \ [0x08] Defines the public protection of the IC9 configuration bits (enable, ready, divider).
    $09 constant RCC_IC10PUBC                   \ [0x09] Defines the public protection of the IC10 configuration bits (enable, ready, divider).
    $0a constant RCC_IC11PUBC                   \ [0x0a] Defines the public protection of the IC11 configuration bits (enable, ready, divider).
    $0b constant RCC_IC12PUBC                   \ [0x0b] Defines the public protection of the IC12 configuration bits (enable, ready, divider).
    $0c constant RCC_IC13PUBC                   \ [0x0c] Defines the public protection of the IC13 configuration bits (enable, ready, divider).
    $0d constant RCC_IC14PUBC                   \ [0x0d] Defines the public protection of the IC14 configuration bits (enable, ready, divider).
    $0e constant RCC_IC15PUBC                   \ [0x0e] Defines the public protection of the IC15 configuration bits (enable, ready, divider).
    $0f constant RCC_IC16PUBC                   \ [0x0f] Defines the public protection of the IC16 configuration bits (enable, ready, divider).
    $10 constant RCC_IC17PUBC                   \ [0x10] Defines the public protection of the IC17 configuration bits (enable, ready, divider).
    $11 constant RCC_IC18PUBC                   \ [0x11] Defines the public protection of the IC18 configuration bits (enable, ready, divider).
    $12 constant RCC_IC19PUBC                   \ [0x12] Defines the public protection of the IC19 configuration bits (enable, ready, divider).
    $13 constant RCC_IC20PUBC                   \ [0x13] Defines the public protection of the IC20 configuration bits (enable, ready, divider).
  [then]


  [ifdef] RCC_RCC_PRIVCFGCR3_DEF
    \
    \ @brief RCC system privilege configuration register3
    \ Address offset: 0x17B4
    \ Reset value: 0x00000000
    \
    $00 constant RCC_MODPVC                     \ [0x00] Defines the privilege protection of the MOD configuration bits (enable, ready, divider).
    $01 constant RCC_SYSPVC                     \ [0x01] Defines the privilege protection of the SYS configuration bits (enable, ready, divider).
    $02 constant RCC_BUSPVC                     \ [0x02] Defines the privilege protection of the BUS configuration bits (enable, ready, divider).
    $03 constant RCC_PERPVC                     \ [0x03] Defines the privilege protection of the PER configuration bits (enable, ready, divider).
    $04 constant RCC_INTPVC                     \ [0x04] Defines the privilege protection of the INT configuration bits (enable, ready, divider).
    $05 constant RCC_RSTPVC                     \ [0x05] Defines the privilege protection of the RST configuration bits (enable, ready, divider).
    $06 constant RCC_DFTPVC                     \ [0x06] Defines the privilege protection of the DFT configuration bits (enable, ready, divider).
  [then]


  [ifdef] RCC_RCC_PUBCFGCR3_DEF
    \
    \ @brief RCC system public configuration register3
    \ Address offset: 0x17BC
    \ Reset value: 0x00000000
    \
    $00 constant RCC_MODPUBC                    \ [0x00] Defines the public protection of the MOD configuration bits (enable, ready, divider).
    $01 constant RCC_SYSPUBC                    \ [0x01] Defines the public protection of the SYS configuration bits (enable, ready, divider).
    $02 constant RCC_BUSPUBC                    \ [0x02] Defines the public protection of the BUS configuration bits (enable, ready, divider).
    $03 constant RCC_PERPUBC                    \ [0x03] Defines the public protection of the PER configuration bits (enable, ready, divider).
    $04 constant RCC_INTPUBC                    \ [0x04] Defines the public protection of the INT configuration bits (enable, ready, divider).
    $05 constant RCC_RSTPUBC                    \ [0x05] Defines the public protection of the RST configuration bits (enable, ready, divider).
    $06 constant RCC_DFTPUBC                    \ [0x06] Defines the public protection of the DFT configuration bits (enable, ready, divider).
  [then]


  [ifdef] RCC_RCC_PRIVCFGCR4_DEF
    \
    \ @brief RCC privilege configuration register4
    \ Address offset: 0x17C4
    \ Reset value: 0x00000000
    \
    $00 constant RCC_ACLKNPVC                   \ [0x00] Defines the privilege protection of the ACLKN configuration bits (enable, ready, divider).
    $01 constant RCC_ACLKNCPVC                  \ [0x01] Defines the privilege protection of the ACLKNC configuration bits (enable, ready, divider).
    $02 constant RCC_AHBMPVC                    \ [0x02] Defines the privilege protection of the AHBM configuration bits (enable, ready, divider).
    $03 constant RCC_AHB1PVC                    \ [0x03] Defines the privilege protection of the AHB1 configuration bits (enable, ready, divider).
    $04 constant RCC_AHB2PVC                    \ [0x04] Defines the privilege protection of the AHB2 configuration bits (enable, ready, divider).
    $05 constant RCC_AHB3PVC                    \ [0x05] Defines the privilege protection of the AHB3 configuration bits (enable, ready, divider).
    $06 constant RCC_AHB4PVC                    \ [0x06] Defines the privilege protection of the AHB4 configuration bits (enable, ready, divider).
    $07 constant RCC_AHB5PVC                    \ [0x07] Defines the privilege protection of the AHB5 configuration bits (enable, ready, divider).
    $08 constant RCC_APB1PVC                    \ [0x08] Defines the privilege protection of the APB1 configuration bits (enable, ready, divider).
    $09 constant RCC_APB2PVC                    \ [0x09] Defines the privilege protection of the APB2 configuration bits (enable, ready, divider).
    $0a constant RCC_APB3PVC                    \ [0x0a] Defines the privilege protection of the APB3 configuration bits (enable, ready, divider).
    $0b constant RCC_APB4PVC                    \ [0x0b] Defines the privilege protection of the APB4 configuration bits (enable, ready, divider).
    $0c constant RCC_APB5PVC                    \ [0x0c] Defines the privilege protection of the APB5 configuration bits (enable, ready, divider).
    $0d constant RCC_NOCPVC                     \ [0x0d] Defines the privilege protection of the NOC configuration bits (enable, ready, divider).
  [then]


  [ifdef] RCC_RCC_PUBCFGCR4_DEF
    \
    \ @brief RCC public configuration register4
    \ Address offset: 0x17CC
    \ Reset value: 0x00000000
    \
    $00 constant RCC_ACLKNPUBC                  \ [0x00] Defines the public protection of the ACLKN configuration bits (enable, ready, divider).
    $01 constant RCC_ACLKNCPUBC                 \ [0x01] Defines the public protection of the ACLKNC configuration bits (enable, ready, divider).
    $02 constant RCC_AHBMPUBC                   \ [0x02] Defines the public protection of the AHBM configuration bits (enable, ready, divider).
    $03 constant RCC_AHB1PUBC                   \ [0x03] Defines the public protection of the AHB1 configuration bits (enable, ready, divider).
    $04 constant RCC_AHB2PUBC                   \ [0x04] Defines the public protection of the AHB2 configuration bits (enable, ready, divider).
    $05 constant RCC_AHB3PUBC                   \ [0x05] Defines the public protection of the AHB3 configuration bits (enable, ready, divider).
    $06 constant RCC_AHB4PUBC                   \ [0x06] Defines the public protection of the AHB4 configuration bits (enable, ready, divider).
    $07 constant RCC_AHB5PUBC                   \ [0x07] Defines the public protection of the AHB5 configuration bits (enable, ready, divider).
    $08 constant RCC_APB1PUBC                   \ [0x08] Defines the public protection of the APB1 configuration bits (enable, ready, divider).
    $09 constant RCC_APB2PUBC                   \ [0x09] Defines the public protection of the APB2 configuration bits (enable, ready, divider).
    $0a constant RCC_APB3PUBC                   \ [0x0a] Defines the public protection of the APB3 configuration bits (enable, ready, divider).
    $0b constant RCC_APB4PUBC                   \ [0x0b] Defines the public protection of the APB4 configuration bits (enable, ready, divider).
    $0c constant RCC_APB5PUBC                   \ [0x0c] Defines the public protection of the APB5 configuration bits (enable, ready, divider).
    $0d constant RCC_NOCPUBC                    \ [0x0d] Defines the public protection of the NOC configuration bits (enable, ready, divider).
  [then]


  [ifdef] RCC_RCC_PUBCFGCR5_DEF
    \
    \ @brief RCC public configuration register4
    \ Address offset: 0x17D0
    \ Reset value: 0x00000000
    \
    $00 constant RCC_AXISRAM3PUBC               \ [0x00] Defines the public protection of the AXISRAM3 configuration bits (enable, ready, divider).
    $01 constant RCC_AXISRAM4PUBC               \ [0x01] Defines the public protection of the AXISRAM4 configuration bits (enable, ready, divider).
    $02 constant RCC_AXISRAM5PUBC               \ [0x02] Defines the public protection of the AXISRAM5 configuration bits (enable, ready, divider).
    $03 constant RCC_AXISRAM6PUBC               \ [0x03] Defines the public protection of the AXISRAM6 configuration bits (enable, ready, divider).
    $04 constant RCC_AHBSRAM1PUBC               \ [0x04] Defines the public protection of the AHBSRAM1 configuration bits (enable, ready, divider).
    $05 constant RCC_AHBSRAM2PUBC               \ [0x05] Defines the public protection of the AHBSRAM2 configuration bits (enable, ready, divider).
    $06 constant RCC_BKPSRAMPUBC                \ [0x06] Defines the public protection of the BKPSRAM configuration bits (enable, ready, divider).
    $07 constant RCC_AXISRAM1PUBC               \ [0x07] Defines the public protection of the AXISRAM1 configuration bits (enable, ready, divider).
    $08 constant RCC_AXISRAM2PUBC               \ [0x08] Defines the public protection of the AXISRAM2 configuration bits (enable, ready, divider).
    $09 constant RCC_FLEXRAMPUBC                \ [0x09] Defines the public protection of the FLEXRAM configuration bits (enable, ready, divider).
    $0a constant RCC_CACHEAXIRAMPUBC            \ [0x0a] Defines the public protection of the NPUCACHERAM configuration bits (enable, ready, divider).
    $0b constant RCC_VENCRAMPUBC                \ [0x0b] Defines the public protection of the VENCRAM configuration bits (enable, ready, divider).
  [then]

  \
  \ @brief Reset and clock control
  \
  $00 constant RCC_RCC_CR               \ RCC control register
  $04 constant RCC_RCC_SR               \ RCC status register
  $08 constant RCC_RCC_STOPCR           \ RCC Stop mode control register
  $20 constant RCC_RCC_CFGR1            \ RCC configuration register 1
  $24 constant RCC_RCC_CFGR2            \ RCC configuration register 2
  $28 constant RCC_RCC_CKPROTR          \ RCC clock protection register
  $2C constant RCC_RCC_BDCR             \ RCC backup domain protection register
  $30 constant RCC_RCC_HWRSR            \ RCC reset status register for hardware
  $34 constant RCC_RCC_RSR              \ RCC reset register
  $40 constant RCC_RCC_LSECFGR          \ RCC LSE configuration register
  $44 constant RCC_RCC_MSICFGR          \ RCC MSI configuration register
  $48 constant RCC_RCC_HSICFGR          \ RCC HSI configuration register
  $4C constant RCC_RCC_HSIMCR           \ RCC HSI monitor control register
  $50 constant RCC_RCC_HSIMSR           \ RCC HSI monitor status register
  $54 constant RCC_RCC_HSECFGR          \ RCC HSE configuration register
  $80 constant RCC_RCC_PLL1CFGR1        \ RCC PLL1 configuration register 1
  $84 constant RCC_RCC_PLL1CFGR2        \ RCC PLL1 configuration register 2
  $88 constant RCC_RCC_PLL1CFGR3        \ RCC PLL1 configuration register 3
  $90 constant RCC_RCC_PLL2CFGR1        \ RCC PLL2 configuration register 1
  $94 constant RCC_RCC_PLL2CFGR2        \ RCC PLL2 configuration register 2
  $98 constant RCC_RCC_PLL2CFGR3        \ RCC PLL2 configuration register 3
  $A0 constant RCC_RCC_PLL3CFGR1        \ RCC PLL3 configuration register 1
  $A4 constant RCC_RCC_PLL3CFGR2        \ RCC PLL3 configuration register 2
  $A8 constant RCC_RCC_PLL3CFGR3        \ RCC PLL3 configuration register 3
  $B0 constant RCC_RCC_PLL4CFGR1        \ RCC PLL4 configuration register 1
  $B4 constant RCC_RCC_PLL4CFGR2        \ RCC PLL4 configuration register 2
  $B8 constant RCC_RCC_PLL4CFGR3        \ RCC PLL4 configuration register 3
  $C4 constant RCC_RCC_IC1CFGR          \ RCC IC1 configuration register
  $C8 constant RCC_RCC_IC2CFGR          \ RCC IC2 configuration register
  $CC constant RCC_RCC_IC3CFGR          \ RCC IC3 configuration register
  $D0 constant RCC_RCC_IC4CFGR          \ RCC IC4 configuration register
  $D4 constant RCC_RCC_IC5CFGR          \ RCC IC5 configuration register
  $D8 constant RCC_RCC_IC6CFGR          \ RCC IC6 configuration register
  $DC constant RCC_RCC_IC7CFGR          \ RCC IC7 configuration register
  $E0 constant RCC_RCC_IC8CFGR          \ RCC IC8 configuration register
  $E4 constant RCC_RCC_IC9CFGR          \ RCC IC9 configuration register
  $E8 constant RCC_RCC_IC10CFGR         \ RCC IC10 configuration register
  $EC constant RCC_RCC_IC11CFGR         \ RCC IC11 configuration register
  $F0 constant RCC_RCC_IC12CFGR         \ RCC IC12 configuration register
  $F4 constant RCC_RCC_IC13CFGR         \ RCC IC13 configuration register
  $F8 constant RCC_RCC_IC14CFGR         \ RCC IC14 configuration register
  $FC constant RCC_RCC_IC15CFGR         \ RCC IC15 configuration register
  $100 constant RCC_RCC_IC16CFGR        \ RCC IC16 configuration register
  $104 constant RCC_RCC_IC17CFGR        \ RCC IC17 configuration register
  $108 constant RCC_RCC_IC18CFGR        \ RCC IC18 configuration register
  $10C constant RCC_RCC_IC19CFGR        \ RCC IC19 configuration register
  $110 constant RCC_RCC_IC20CFGR        \ RCC IC20 configuration register
  $124 constant RCC_RCC_CIER            \ RCC clock-source interrupt enable register
  $128 constant RCC_RCC_CIFR            \ RCC clock-source interrupt flag register
  $12C constant RCC_RCC_CICR            \ RCC clock-source interrupt Clear register
  $144 constant RCC_RCC_CCIPR1          \ RCC clock configuration for independent peripheral register1
  $148 constant RCC_RCC_CCIPR2          \ RCC clock configuration for independent peripheral register 2
  $14C constant RCC_RCC_CCIPR3          \ RCC clock configuration for independent peripheral register3
  $150 constant RCC_RCC_CCIPR4          \ RCC clock configuration for independent peripheral register4
  $154 constant RCC_RCC_CCIPR5          \ RCC lock configuration for independent peripheral register5
  $158 constant RCC_RCC_CCIPR6          \ RCC clock configuration for independent peripheral register6
  $15C constant RCC_RCC_CCIPR7          \ RCC clock configuration for independent peripheral register7
  $160 constant RCC_RCC_CCIPR8          \ RCC clock configuration for independent peripheral register8
  $164 constant RCC_RCC_CCIPR9          \ RCC clock configuration for independent peripheral register9
  $170 constant RCC_RCC_CCIPR12         \ RCC clock configuration for independent peripheral register12
  $174 constant RCC_RCC_CCIPR13         \ RCC clock configuration for independent peripheral register13
  $178 constant RCC_RCC_CCIPR14         \ RCC clock configuration for independent peripheral register14
  $204 constant RCC_RCC_BUSRSTR         \ RCC SoC buses reset register
  $208 constant RCC_RCC_MISCRSTR        \ RCC miscellaneous configurations reset register
  $20C constant RCC_RCC_MEMRSTR         \ RCC memories reset register
  $210 constant RCC_RCC_AHB1RSTR        \ RCC AHB1 Reset register
  $214 constant RCC_RCC_AHB2RSTR        \ RCC AHB2 reset register
  $218 constant RCC_RCC_AHB3RSTR        \ RCC AHB3 reset register
  $21C constant RCC_RCC_AHB4RSTR        \ RCC AHB4 reset register
  $220 constant RCC_RCC_AHB5RSTR        \ RCC AHB5 reset register
  $224 constant RCC_RCC_APB1LRSTR       \ RCC APB1L reset register
  $228 constant RCC_RCC_APB1HRSTR       \ RCC APB1H reset register
  $22C constant RCC_RCC_APB2RSTR        \ RCC APB2 reset register
  $234 constant RCC_RCC_APB4LRSTR       \ RCC APB4L reset register
  $238 constant RCC_RCC_APB4HRSTR       \ RCC APB4H reset register
  $23C constant RCC_RCC_APB5RSTR        \ RCC APB5 reset register
  $240 constant RCC_RCC_DIVENR          \ RCC IC dividers enable register
  $244 constant RCC_RCC_BUSENR          \ RCC SoC buses enable register
  $248 constant RCC_RCC_MISCENR         \ RCC miscellaneous configuration enable register
  $24C constant RCC_RCC_MEMENR          \ RCC memory enable register
  $250 constant RCC_RCC_AHB1ENR         \ RCC AHB1 enable register
  $254 constant RCC_RCC_AHB2ENR         \ RCC AHB2 enable register
  $258 constant RCC_RCC_AHB3ENR         \ RCC AHB3 enable register
  $25C constant RCC_RCC_AHB4ENR         \ RCC AHB4 enable register
  $260 constant RCC_RCC_AHB5ENR         \ RCC AHB5 enable register
  $264 constant RCC_RCC_APB1LENR        \ RCC APB1L enable register
  $268 constant RCC_RCC_APB1HENR        \ RCC APB1H enable register
  $26C constant RCC_RCC_APB2ENR         \ RCC APB2 enable register
  $270 constant RCC_RCC_APB3ENR         \ RCC APB3 enable register
  $274 constant RCC_RCC_APB4LENR        \ RCC APB4L enable register
  $278 constant RCC_RCC_APB4HENR        \ RCC APB4H enable register
  $27C constant RCC_RCC_APB5ENR         \ RCC APB5 enable register
  $280 constant RCC_RCC_DIVLPENR        \ RCC dividers Sleep enable register
  $284 constant RCC_RCC_BUSLPENR        \ RCC SoC buses Sleep enable register
  $288 constant RCC_RCC_MISCLPENR       \ RCC miscellaneous configurations Sleep enable register
  $28C constant RCC_RCC_MEMLPENR        \ RCC memory Sleep enable register
  $290 constant RCC_RCC_AHB1LPENR       \ RCC AHB1 Sleep enable register
  $294 constant RCC_RCC_AHB2LPENR       \ RCC AHB2 Sleep enable register
  $298 constant RCC_RCC_AHB3LPENR       \ RCC AHB3 Sleep enable register
  $29C constant RCC_RCC_AHB4LPENR       \ RCC AHB4 Sleep enable register
  $2A0 constant RCC_RCC_AHB5LPENR       \ RCC AHB5 Sleep enable register
  $2A4 constant RCC_RCC_APB1LLPENR      \ RCC APB1L Sleep enable register
  $2A8 constant RCC_RCC_APB1HLPENR      \ RCC APB1H Sleep enable register
  $2AC constant RCC_RCC_APB2LPENR       \ RCC APB2 Sleep enable register
  $2B0 constant RCC_RCC_APB3LPENR       \ RCC APB3 Sleep enable register
  $2B4 constant RCC_RCC_APB4LLPENR      \ RCC APB4L Sleep enable register
  $2B8 constant RCC_RCC_APB4HLPENR      \ RCC APB4H Sleep enable register
  $2BC constant RCC_RCC_APB5LPENR       \ RCC APB5 Sleep enable register
  $44C constant RCC_RCC_RDCR            \ RCC APB5 Sleep enable register
  $780 constant RCC_RCC_SECCFGR0        \ RCC oscillator secure configuration register0
  $784 constant RCC_RCC_PRIVCFGR0       \ RCC oscillator privilege configuration register0
  $788 constant RCC_RCC_LOCKCFGR0       \ RCC oscillator lock configuration register0
  $78C constant RCC_RCC_PUBCFGR0        \ RCC oscillator public configuration register0
  $790 constant RCC_RCC_SECCFGR1        \ RCC PLL secure configuration register1
  $794 constant RCC_RCC_PRIVCFGR1       \ RCC PLL privilege configuration register1
  $798 constant RCC_RCC_LOCKCFGR1       \ RCC PLL lock configuration register1
  $79C constant RCC_RCC_PUBCFGR1        \ RCC PLL public configuration register1
  $7A0 constant RCC_RCC_SECCFGR2        \ RCC divider secure configuration register2
  $7A4 constant RCC_RCC_PRIVCFGR2       \ RCC divider privilege configuration register2
  $7A8 constant RCC_RCC_LOCKCFGR2       \ RCC divider lock configuration register2
  $7AC constant RCC_RCC_PUBCFGR2        \ RCC divider public configuration register2
  $7B0 constant RCC_RCC_SECCFGR3        \ RCC system secure configuration register3
  $7B4 constant RCC_RCC_PRIVCFGR3       \ RCC system privilege configuration register3
  $7B8 constant RCC_RCC_LOCKCFGR3       \ RCC system lock configuration register3
  $7BC constant RCC_RCC_PUBCFGR3        \ RCC system public configuration register3
  $7C0 constant RCC_RCC_SECCFGR4        \ RCC bus secure configuration register4
  $7C4 constant RCC_RCC_PRIVCFGR4       \ RCC bus privilege configuration register4
  $7C8 constant RCC_RCC_LOCKCFGR4       \ RCC bus lock configuration register4
  $7CC constant RCC_RCC_PUBCFGR4        \ RCC bus public configuration register4
  $7D0 constant RCC_RCC_PUBCFGR5        \ RCC bus public configuration register4
  $800 constant RCC_RCC_CSR             \ RCC control set register
  $808 constant RCC_RCC_STOPCSR         \ RCC Stop configuration register
  $A04 constant RCC_RCC_BUSRSTSR        \ RCC bus reset set register
  $A08 constant RCC_RCC_MISCRSTSR       \ RCC miscellaneous reset register
  $A0C constant RCC_RCC_MEMRSTSR        \ RCC memory reset register
  $A10 constant RCC_RCC_AHB1RSTSR       \ RCC AHB1 reset register
  $A14 constant RCC_RCC_AHB2RSTSR       \ RCC AHB2 reset register
  $A18 constant RCC_RCC_AHB3RSTSR       \ RCC AHB3 reset register
  $A1C constant RCC_RCC_AHB4RSTSR       \ RCC AHB4 reset register
  $A20 constant RCC_RCC_AHB5RSTSR       \ RCC AHB5 reset register
  $A24 constant RCC_RCC_APB1LRSTSR      \ RCC APB1L reset register
  $A28 constant RCC_RCC_APB1HRSTSR      \ RCC APB1H reset register
  $A2C constant RCC_RCC_APB2RSTSR       \ RCC APB2 reset register
  $A34 constant RCC_RCC_APB4LRSTSR      \ RCC APB4L reset register
  $A38 constant RCC_RCC_APB4HRSTSR      \ RCC APB4H reset register
  $A3C constant RCC_RCC_APB5RSTSR       \ RCC APB5 reset register
  $A40 constant RCC_RCC_DIVENSR         \ RCC Divider enable register
  $A44 constant RCC_RCC_BUSENSR         \ RCC bus enable register
  $A48 constant RCC_RCC_MISCENSR        \ RCC miscellaneous enable register
  $A4C constant RCC_RCC_MEMENSR         \ RCC memory enable register
  $A50 constant RCC_RCC_AHB1ENSR        \ RCC AHB1 enable register
  $A54 constant RCC_RCC_AHB2ENSR        \ RCC AHB2 enable register
  $A58 constant RCC_RCC_AHB3ENSR        \ RCC AHB3 enable register
  $A5C constant RCC_RCC_AHB4ENSR        \ RCC AHB4 enable register
  $A60 constant RCC_RCC_AHB5ENSR        \ RCC AHB5 enable register
  $A64 constant RCC_RCC_APB1LENSR       \ RCC APB1L enable register
  $A68 constant RCC_RCC_APB1HENSR       \ RCC APB1H enable register
  $A6C constant RCC_RCC_APB2ENSR        \ RCC APB2 enable register
  $A70 constant RCC_RCC_APB3ENSR        \ RCC APB3 enable register
  $A74 constant RCC_RCC_APB4LENSR       \ RCC APB4L enable register
  $A78 constant RCC_RCC_APB4HENSR       \ RCC APB4H enable register
  $A7C constant RCC_RCC_APB5ENSR        \ RCC APB5 enable register
  $A80 constant RCC_RCC_DIVLPENSR       \ RCC divider Sleep enable register
  $A84 constant RCC_RCC_BUSLPENSR       \ RCC bus Sleep enable register
  $A88 constant RCC_RCC_MISCLPENSR      \ RCC miscellaneous Sleep enable register
  $A8C constant RCC_RCC_MEMLPENSR       \ RCC memory sleep enable register
  $A90 constant RCC_RCC_AHB1LPENSR      \ RCC AHB1 Sleep enable register
  $A94 constant RCC_RCC_AHB2LPENSR      \ RCC AHB2 Sleep enable register
  $A98 constant RCC_RCC_AHB3LPENSR      \ RCC AHB3 Sleep enable register
  $A9C constant RCC_RCC_AHB4LPENSR      \ RCC AHB4 Sleep enable register
  $AA0 constant RCC_RCC_AHB5LPENSR      \ RCC AHB5 Sleep enable register
  $AA4 constant RCC_RCC_APB1LLPENSR     \ RCC APB1L Sleep enable register
  $AA8 constant RCC_RCC_APB1HLPENSR     \ RCC APB1H Sleep enable register
  $AAC constant RCC_RCC_APB2LPENSR      \ RCC APB2 Sleep enable register
  $AB0 constant RCC_RCC_APB3LPENSR      \ RCC APB3 Sleep enable register
  $AB4 constant RCC_RCC_APB4LLPENSR     \ RCC APB4L Sleep enable register
  $AB8 constant RCC_RCC_APB4HLPENSR     \ RCC APB4H Sleep enable register
  $ABC constant RCC_RCC_APB5LPENSR      \ RCC APB5 Sleep enable register
  $F84 constant RCC_RCC_PRIVCFGSR0      \ RCC oscillator privilege configuration register0
  $F8C constant RCC_RCC_PUBCFGSR0       \ RCC oscillator public configuration register0
  $F94 constant RCC_RCC_PRIVCFGSR1      \ RCC PLL privilege configuration register1
  $F9C constant RCC_RCC_PUBCFGSR1       \ RCC PLL public configuration register1
  $FA4 constant RCC_RCC_PRIVCFGSR2      \ RCC divider privilege configuration register2
  $FAC constant RCC_RCC_PUBCFGSR2       \ RCC divider public configuration register2
  $FB0 constant RCC_RCC_SECCFGSR3       \ RCC system secure configuration register3
  $FB4 constant RCC_RCC_PRIVCFGSR3      \ RCC system privilege configuration register3
  $FB8 constant RCC_RCC_LOCKCFGSR3      \ RCC system lock configuration register3
  $FBC constant RCC_RCC_PUBCFGSR3       \ RCC system public configuration register3
  $FC4 constant RCC_RCC_PRIVCFGSR4      \ RCC privilege configuration register4
  $FCC constant RCC_RCC_PUBCFGSR4       \ RCC public configuration register4
  $FD0 constant RCC_RCC_PUBCFGSR5       \ RCC public configuration register4
  $1000 constant RCC_RCC_CCR            \ RCC control Clear register
  $1008 constant RCC_RCC_STOPCCR        \ RCC StopCCR configuration register
  $1204 constant RCC_RCC_BUSRSTCR       \ RCC bus reset register
  $1208 constant RCC_RCC_MISCRSTCR      \ RCC miscellaneous reset register
  $120C constant RCC_RCC_MEMRSTCR       \ RCC memory reset register
  $1210 constant RCC_RCC_AHB1RSTCR      \ RCC AHB1 reset register
  $1214 constant RCC_RCC_AHB2RSTCR      \ RCC AHB2 Reset register
  $1218 constant RCC_RCC_AHB3RSTCR      \ RCC AHB3 reset register
  $121C constant RCC_RCC_AHB4RSTCR      \ RCC AHB4 reset register
  $1220 constant RCC_RCC_AHB5RSTCR      \ RCC AHB5 reset register
  $1224 constant RCC_RCC_APB1LRSTCR     \ RCC APB1L reset register
  $1228 constant RCC_RCC_APB1HRSTCR     \ RCC APB1H reset register
  $122C constant RCC_RCC_APB2RSTCR      \ RCC APB2 reset register
  $1234 constant RCC_RCC_APB4LRSTCR     \ RCC APB4L reset register
  $1238 constant RCC_RCC_APB4HRSTCR     \ RCC APB4H reset register
  $123C constant RCC_RCC_APB5RSTCR      \ RCC APB5 reset register
  $1240 constant RCC_RCC_DIVENCR        \ RCC divider enable register
  $1244 constant RCC_RCC_BUSENCR        \ RCC bus enable register
  $1248 constant RCC_RCC_MISCENCR       \ RCC miscellaneous enable register
  $124C constant RCC_RCC_MEMENCR        \ RCC memory enable register
  $1250 constant RCC_RCC_AHB1ENCR       \ RCC AHB1 enable register
  $1254 constant RCC_RCC_AHB2ENCR       \ RCC AHB2 enable register
  $1258 constant RCC_RCC_AHB3ENCR       \ RCC AHB3 enable register
  $125C constant RCC_RCC_AHB4ENCR       \ RCC AHB4 enable register
  $1260 constant RCC_RCC_AHB5ENCR       \ RCC AHB5 enable register
  $1264 constant RCC_RCC_APB1LENCR      \ RCC APB1L enable register
  $1268 constant RCC_RCC_APB1HENCR      \ RCC APB1H enable register
  $126C constant RCC_RCC_APB2ENCR       \ RCC APB2 enable register
  $1270 constant RCC_RCC_APB3ENCR       \ RCC APB3 enable register
  $1274 constant RCC_RCC_APB4LENCR      \ RCC APB4L enable register
  $1278 constant RCC_RCC_APB4HENCR      \ RCC APB4H enable register
  $127C constant RCC_RCC_APB5ENCR       \ RCC APB5 enable register
  $1280 constant RCC_RCC_DIVLPENCR      \ RCC divider Sleep enable register
  $1284 constant RCC_RCC_BUSLPENCR      \ RCC bus Sleep enable register
  $1288 constant RCC_RCC_MISCLPENCR     \ RCC miscellaneous Sleep enable register
  $128C constant RCC_RCC_MEMLPENCR      \ RCC memory Sleep enable register
  $1290 constant RCC_RCC_AHB1LPENCR     \ RCC AHB1 Sleep enable register
  $1294 constant RCC_RCC_AHB2LPENCR     \ RCC AHB2 Sleep enable register
  $1298 constant RCC_RCC_AHB3LPENCR     \ RCC AHB3 Sleep enable register
  $129C constant RCC_RCC_AHB4LPENCR     \ RCC AHB4 Sleep enable register
  $12A0 constant RCC_RCC_AHB5LPENCR     \ RCC AHB5 Sleep enable register
  $12A4 constant RCC_RCC_APB1LLPENCR    \ RCC APB1L Sleep enable register
  $12A8 constant RCC_RCC_APB1HLPENCR    \ RCC APB1H Sleep enable register
  $12AC constant RCC_RCC_APB2LPENCR     \ RCC APB2 Sleep enable register
  $12B0 constant RCC_RCC_APB3LPENCR     \ RCC APB3 Sleep enable register
  $12B4 constant RCC_RCC_APB4LLPENCR    \ RCC APB4L Sleep enable register
  $12B8 constant RCC_RCC_APB4HLPENCR    \ RCC APB4H Sleep enable register
  $12BC constant RCC_RCC_APB5LPENCR     \ RCC APB5 Sleep enable register
  $1784 constant RCC_RCC_PRIVCFGCR0     \ RCC oscillator privilege configuration register0
  $178C constant RCC_RCC_PUBCFGCR0      \ RCC oscillator public configuration register0
  $1794 constant RCC_RCC_PRIVCFGCR1     \ RCC PLL privilege configuration register1
  $179C constant RCC_RCC_PUBCFGCR1      \ RCC PLL public configuration register1
  $17A4 constant RCC_RCC_PRIVCFGCR2     \ RCC divider privilege configuration register2
  $17AC constant RCC_RCC_PUBCFGCR2      \ RCC divider public configuration register2
  $17B4 constant RCC_RCC_PRIVCFGCR3     \ RCC system privilege configuration register3
  $17BC constant RCC_RCC_PUBCFGCR3      \ RCC system public configuration register3
  $17C4 constant RCC_RCC_PRIVCFGCR4     \ RCC privilege configuration register4
  $17CC constant RCC_RCC_PUBCFGCR4      \ RCC public configuration register4
  $17D0 constant RCC_RCC_PUBCFGCR5      \ RCC public configuration register4

: RCC_DEF ; [then]
