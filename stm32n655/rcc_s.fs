\
\ @file rcc_s.fs
\ @brief RCC global secure interrupt
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief RCC control register
\ Address offset: 0x00
\ Reset value: 0x00000008
\

$00000001 constant RCC_S_RCC_CR_LSION                               \ LSI oscillator enable in Run/Sleep mode.
$00000002 constant RCC_S_RCC_CR_LSEON                               \ LSE oscillator enable in Run/Sleep mode.
$00000004 constant RCC_S_RCC_CR_MSION                               \ MSI oscillator enable in Run/Sleep mode.
$00000008 constant RCC_S_RCC_CR_HSION                               \ HSI oscillator enable in Run/Sleep mode.
$00000010 constant RCC_S_RCC_CR_HSEON                               \ HSE oscillator enable in Run/Sleep mode.
$00000100 constant RCC_S_RCC_CR_PLL1ON                              \ PLL1 enable in Run/Sleep mode.
$00000200 constant RCC_S_RCC_CR_PLL2ON                              \ PLL2 enable in Run/Sleep mode.
$00000400 constant RCC_S_RCC_CR_PLL3ON                              \ PLL3 enable in Run/Sleep mode.
$00000800 constant RCC_S_RCC_CR_PLL4ON                              \ PLL4 enable in Run/Sleep mode.


\
\ @brief RCC status register
\ Address offset: 0x04
\ Reset value: 0x00000008
\

$00000001 constant RCC_S_RCC_SR_LSIRDY                              \ LSI clock ready flag
$00000002 constant RCC_S_RCC_SR_LSERDY                              \ LSE clock ready flag
$00000004 constant RCC_S_RCC_SR_MSIRDY                              \ MSI clock ready flag
$00000008 constant RCC_S_RCC_SR_HSIRDY                              \ HSI clock ready flag
$00000010 constant RCC_S_RCC_SR_HSERDY                              \ HSE clock ready flag
$00000100 constant RCC_S_RCC_SR_PLL1RDY                             \ PLL1 clock ready flag
$00000200 constant RCC_S_RCC_SR_PLL2RDY                             \ PLL2 clock ready flag
$00000400 constant RCC_S_RCC_SR_PLL3RDY                             \ PLL3 clock ready flag
$00000800 constant RCC_S_RCC_SR_PLL4RDY                             \ PLL4 clock ready flag


\
\ @brief RCC Stop mode control register
\ Address offset: 0x08
\ Reset value: 0x00000008
\

$00000001 constant RCC_S_RCC_STOPCR_LSISTOPEN                       \ LSI oscillator enable in Stop mode.
$00000002 constant RCC_S_RCC_STOPCR_LSESTOPEN                       \ LSE oscillator enable in Stop mode.
$00000004 constant RCC_S_RCC_STOPCR_MSISTOPEN                       \ MSI oscillator enable in Stop mode.
$00000008 constant RCC_S_RCC_STOPCR_HSISTOPEN                       \ HSI oscillator enable in Stop mode.


\
\ @brief RCC configuration register 1
\ Address offset: 0x20
\ Reset value: 0x00000000
\

$00000001 constant RCC_S_RCC_CFGR1_STOPWUCK                         \ System clock selection after a wake up from system Stop.
$00030000 constant RCC_S_RCC_CFGR1_CPUSW                            \ CPU clock switch selection
$00300000 constant RCC_S_RCC_CFGR1_CPUSWS                           \ CPU clock switch status
$03000000 constant RCC_S_RCC_CFGR1_SYSSW                            \ System clock switch selection
$30000000 constant RCC_S_RCC_CFGR1_SYSSWS                           \ System clock switch status


\
\ @brief RCC configuration register 2
\ Address offset: 0x24
\ Reset value: 0x00000000
\

$00000007 constant RCC_S_RCC_CFGR2_PPRE1                            \ CPU domain APB1 prescaler
$00000070 constant RCC_S_RCC_CFGR2_PPRE2                            \ CPU domain APB2 prescaler
$00007000 constant RCC_S_RCC_CFGR2_PPRE4                            \ CPU domain APB4 prescaler
$00070000 constant RCC_S_RCC_CFGR2_PPRE5                            \ CPU domain APB5 prescaler
$00700000 constant RCC_S_RCC_CFGR2_HPRE                             \ AHB clock prescaler
$03000000 constant RCC_S_RCC_CFGR2_TIMPRE                           \ Timers clocks prescaler selection


\
\ @brief RCC clock protection register
\ Address offset: 0x28
\ Reset value: 0x00000000
\

$00030000 constant RCC_S_RCC_CKPROTR_XSPI3SELS                      \ XSPI3 clock selection current status
$00300000 constant RCC_S_RCC_CKPROTR_XSPI2SELS                      \ XSPI2 clock selection current status
$03000000 constant RCC_S_RCC_CKPROTR_XSPI1SELS                      \ XSPI1 clock selection current status
$30000000 constant RCC_S_RCC_CKPROTR_FMCSELS                        \ FMC clock selection current status


\
\ @brief RCC backup domain protection register
\ Address offset: 0x2C
\ Reset value: 0x00000000
\

$80000000 constant RCC_S_RCC_BDCR_VSWRST                            \ VSW domain software reset.


\
\ @brief RCC reset status register for hardware
\ Address offset: 0x30
\ Reset value: 0x00E00000
\

$00010000 constant RCC_S_RCC_HWRSR_RMVF                             \ Remove reset flag
$00020000 constant RCC_S_RCC_HWRSR_LCKRSTF                          \ CPU lockup reset flag.
$00200000 constant RCC_S_RCC_HWRSR_BORRSTF                          \ BOR flag
$00400000 constant RCC_S_RCC_HWRSR_PINRSTF                          \ Pin reset flag (NRST)
$00800000 constant RCC_S_RCC_HWRSR_PORRSTF                          \ POR/PDR flag.
$01000000 constant RCC_S_RCC_HWRSR_SFTRSTF                          \ Software system reset flag (1)
$04000000 constant RCC_S_RCC_HWRSR_IWDGRSTF                         \ Independent Watchdog reset flag.
$10000000 constant RCC_S_RCC_HWRSR_WWDGRSTF                         \ Window watchdog reset flag
$40000000 constant RCC_S_RCC_HWRSR_LPWRRSTF                         \ Illegal Stop or Standby flag.


\
\ @brief RCC reset register
\ Address offset: 0x34
\ Reset value: 0x00E00000
\

$00010000 constant RCC_S_RCC_RSR_RMVF                               \ Remove reset flag
$00020000 constant RCC_S_RCC_RSR_LCKRSTF                            \ CPU lockup reset flag.
$00200000 constant RCC_S_RCC_RSR_BORRSTF                            \ BOR flag
$00400000 constant RCC_S_RCC_RSR_PINRSTF                            \ Pin reset flag (NRST)
$00800000 constant RCC_S_RCC_RSR_PORRSTF                            \ POR/PDR flag.
$01000000 constant RCC_S_RCC_RSR_SFTRSTF                            \ Software System reset flag (1)
$04000000 constant RCC_S_RCC_RSR_IWDGRSTF                           \ Independent Watchdog reset flag.
$10000000 constant RCC_S_RCC_RSR_WWDGRSTF                           \ Window Watchdog reset flag
$40000000 constant RCC_S_RCC_RSR_LPWRRSTF                           \ Illegal Stop or Standby flag.


\
\ @brief RCC LSE configuration register
\ Address offset: 0x40
\ Reset value: 0x00000000
\

$00000080 constant RCC_S_RCC_LSECFGR_LSECSSON                       \ LSE clock security system (CSS) enable
$00000100 constant RCC_S_RCC_LSECFGR_LSECSSRA                       \ LSE clock security system (CSS) re-arm function
$00000200 constant RCC_S_RCC_LSECFGR_LSECSSD                        \ LSE clock security system (CSS) failure detection
$00008000 constant RCC_S_RCC_LSECFGR_LSEBYP                         \ LSE clock bypass
$00010000 constant RCC_S_RCC_LSECFGR_LSEEXT                         \ LSE clock type in Bypass mode
$00020000 constant RCC_S_RCC_LSECFGR_LSEGFON                        \ LSE clock glitch filter enable
$000c0000 constant RCC_S_RCC_LSECFGR_LSEDRV                         \ LSE oscillator driving capability


\
\ @brief RCC MSI configuration register
\ Address offset: 0x44
\ Reset value: 0x00000000
\

$00000200 constant RCC_S_RCC_MSICFGR_MSIFREQSEL                     \ MSI oscillator frequency select
$001f0000 constant RCC_S_RCC_MSICFGR_MSITRIM                        \ MSI clock trimming
$7f800000 constant RCC_S_RCC_MSICFGR_MSICAL                         \ MSI clock calibration


\
\ @brief RCC HSI configuration register
\ Address offset: 0x48
\ Reset value: 0x00000000
\

$00000180 constant RCC_S_RCC_HSICFGR_HSIDIV                         \ HSI clock divider
$007f0000 constant RCC_S_RCC_HSICFGR_HSITRIM                        \ HSI clock trimming
$ff800000 constant RCC_S_RCC_HSICFGR_HSICAL                         \ HSI clock calibration


\
\ @brief RCC HSI monitor control register
\ Address offset: 0x4C
\ Reset value: 0x001F07A1
\

$000007ff constant RCC_S_RCC_HSIMCR_HSIREF                          \ HSI clock cycle counter reference value.
$003f0000 constant RCC_S_RCC_HSIMCR_HSIDEV                          \ HSI clock count deviation value
$80000000 constant RCC_S_RCC_HSIMCR_HSIMONEN                        \ HSI clock period monitor enable


\
\ @brief RCC HSI monitor status register
\ Address offset: 0x50
\ Reset value: 0x00000000
\

$000007ff constant RCC_S_RCC_HSIMSR_HSIVAL                          \ HSI clock cycle counter measured value.


\
\ @brief RCC HSE configuration register
\ Address offset: 0x54
\ Reset value: 0x00000800
\

$00000040 constant RCC_S_RCC_HSECFGR_HSEDIV2BYP                     \ HSE div2 oscillator clock in Bypass mode
$00000080 constant RCC_S_RCC_HSECFGR_HSECSSON                       \ HSE clock security system (CSS) enable
$00000100 constant RCC_S_RCC_HSECFGR_HSECSSRA                       \ HSE clock security system (CSS) re-arm function
$00000200 constant RCC_S_RCC_HSECFGR_HSECSSD                        \ HSE clock security system (CSS) failure detection
$00000400 constant RCC_S_RCC_HSECFGR_HSECSSBYP                      \ HSE clock security system (CSS) bypass enable
$00007800 constant RCC_S_RCC_HSECFGR_HSECSSBPRE                     \ HSE clock security system (CSS) bypass divider
$00008000 constant RCC_S_RCC_HSECFGR_HSEBYP                         \ HSE clock bypass
$00010000 constant RCC_S_RCC_HSECFGR_HSEEXT                         \ HSE clock type in Bypass mode
$00020000 constant RCC_S_RCC_HSECFGR_HSEGFON                        \ HSE clock glitch filter enable
$000c0000 constant RCC_S_RCC_HSECFGR_HSEDRV                         \ HSE oscillator driving capability


\
\ @brief RCC PLL1 configuration register 1
\ Address offset: 0x80
\ Reset value: 0x08202500
\

$000fff00 constant RCC_S_RCC_PLL1CFGR1_PLL1DIVN                     \ PLL1 Integer part for the VCO multiplication factor
$03f00000 constant RCC_S_RCC_PLL1CFGR1_PLL1DIVM                     \ PLL1 reference input clock divide frequency ratio
$08000000 constant RCC_S_RCC_PLL1CFGR1_PLL1BYP                      \ PLL1 bypass
$70000000 constant RCC_S_RCC_PLL1CFGR1_PLL1SEL                      \ PLL1 source selection of the reference clock


\
\ @brief RCC PLL1 configuration register 2
\ Address offset: 0x84
\ Reset value: 0x00800000
\

$00ffffff constant RCC_S_RCC_PLL1CFGR2_PLL1DIVNFRAC                 \ PLL1 Fractional part of the VCO multiplication factor


\
\ @brief RCC PLL1 configuration register 3
\ Address offset: 0x88
\ Reset value: 0x4900000D
\

$00000001 constant RCC_S_RCC_PLL1CFGR3_PLL1MODSSRST                 \ PLL1 Modulation Spread Spectrum reset
$00000002 constant RCC_S_RCC_PLL1CFGR3_PLL1DACEN                    \ PLL1 noise canceling DAC enable in fractional mode.
$00000004 constant RCC_S_RCC_PLL1CFGR3_PLL1MODSSDIS                 \ PLL1 Modulation Spread-Spectrum Disable
$00000008 constant RCC_S_RCC_PLL1CFGR3_PLL1MODDSEN                  \ PLL1 Modulation Spread-Spectrum (and Fractional Divide) enable
$00000010 constant RCC_S_RCC_PLL1CFGR3_PLL1MODSPRDW                 \ PLL1 Modulation Spread-Spectrum Down
$00000f00 constant RCC_S_RCC_PLL1CFGR3_PLL1MODDIV                   \ PLL1 Modulation Division frequency adjustment
$001f0000 constant RCC_S_RCC_PLL1CFGR3_PLL1MODSPR                   \ PLL1 Modulation Spread depth adjustment
$07000000 constant RCC_S_RCC_PLL1CFGR3_PLL1PDIV2                    \ PLL1 VCO frequency divider level 2
$38000000 constant RCC_S_RCC_PLL1CFGR3_PLL1PDIV1                    \ PLL1 VCO frequency divider level 1
$40000000 constant RCC_S_RCC_PLL1CFGR3_PLL1PDIVEN                   \ PLL1 post divider POSTDIV1, POSTDIV2, and PLL clock output enable


\
\ @brief RCC PLL2 configuration register 1
\ Address offset: 0x90
\ Reset value: 0x08000000
\

$000fff00 constant RCC_S_RCC_PLL2CFGR1_PLL2DIVN                     \ PLL2 Integer part for the VCO multiplication factor
$03f00000 constant RCC_S_RCC_PLL2CFGR1_PLL2DIVM                     \ PLL2 reference input clock divide frequency ratio
$08000000 constant RCC_S_RCC_PLL2CFGR1_PLL2BYP                      \ PLL2 bypass
$70000000 constant RCC_S_RCC_PLL2CFGR1_PLL2SEL                      \ PLL2 source selection of the reference clock


\
\ @brief RCC PLL2 configuration register 2
\ Address offset: 0x94
\ Reset value: 0x00000000
\

$00ffffff constant RCC_S_RCC_PLL2CFGR2_PLL2DIVNFRAC                 \ PLL2 Fractional part of the VCO multiplication factor


\
\ @brief RCC PLL2 configuration register 3
\ Address offset: 0x98
\ Reset value: 0x49000005
\

$00000001 constant RCC_S_RCC_PLL2CFGR3_PLL2MODSSRST                 \ PLL2 Modulation Spread Spectrum reset
$00000002 constant RCC_S_RCC_PLL2CFGR3_PLL2DACEN                    \ PLL2 noise canceling DAC enable in fractional mode.
$00000004 constant RCC_S_RCC_PLL2CFGR3_PLL2MODSSDIS                 \ PLL2 Modulation Spread-Spectrum Disable
$00000008 constant RCC_S_RCC_PLL2CFGR3_PLL2MODDSEN                  \ PLL2 Modulation Spread-Spectrum (and Fractional Divide) enable
$00000010 constant RCC_S_RCC_PLL2CFGR3_PLL2MODSPRDW                 \ PLL2 Modulation Down Spread
$00000f00 constant RCC_S_RCC_PLL2CFGR3_PLL2MODDIV                   \ PLL2 Modulation Division frequency adjustment
$001f0000 constant RCC_S_RCC_PLL2CFGR3_PLL2MODSPR                   \ PLL2 Modulation Spread depth adjustment
$07000000 constant RCC_S_RCC_PLL2CFGR3_PLL2PDIV2                    \ PLL2 VCO frequency divider level 2
$38000000 constant RCC_S_RCC_PLL2CFGR3_PLL2PDIV1                    \ PLL2 VCO frequency divider level 1
$40000000 constant RCC_S_RCC_PLL2CFGR3_PLL2PDIVEN                   \ PLL2 post divider POSTDIV1, POSTDIV2, and PLL clock output enable


\
\ @brief RCC PLL3 configuration register 1
\ Address offset: 0xA0
\ Reset value: 0x08000000
\

$000fff00 constant RCC_S_RCC_PLL3CFGR1_PLL3DIVN                     \ PLL3 Integer part for the VCO multiplication factor
$03f00000 constant RCC_S_RCC_PLL3CFGR1_PLL3DIVM                     \ PLL3 reference input clock divide frequency ratio
$08000000 constant RCC_S_RCC_PLL3CFGR1_PLL3BYP                      \ PLL3 bypass
$70000000 constant RCC_S_RCC_PLL3CFGR1_PLL3SEL                      \ PLL3 source selection of the reference clock


\
\ @brief RCC PLL3 configuration register 2
\ Address offset: 0xA4
\ Reset value: 0x00000000
\

$00ffffff constant RCC_S_RCC_PLL3CFGR2_PLL3DIVNFRAC                 \ PLL3 Fractional part of the VCO multiplication factor


\
\ @brief RCC PLL3 configuration register 3
\ Address offset: 0xA8
\ Reset value: 0x49000005
\

$00000001 constant RCC_S_RCC_PLL3CFGR3_PLL3MODSSRST                 \ PLL3 Modulation Spread Spectrum reset
$00000002 constant RCC_S_RCC_PLL3CFGR3_PLL3DACEN                    \ PLL3 noise canceling DAC enable in fractional mode.
$00000004 constant RCC_S_RCC_PLL3CFGR3_PLL3MODSSDIS                 \ PLL3 Modulation Spread-Spectrum Disable
$00000008 constant RCC_S_RCC_PLL3CFGR3_PLL3MODDSEN                  \ PLL3 Modulation Spread-Spectrum (and Fractional Divide) enable
$00000010 constant RCC_S_RCC_PLL3CFGR3_PLL3MODSPRDW                 \ PLL3 Modulation Down Spread
$00000f00 constant RCC_S_RCC_PLL3CFGR3_PLL3MODDIV                   \ PLL3 Modulation Division frequency adjustment
$001f0000 constant RCC_S_RCC_PLL3CFGR3_PLL3MODSPR                   \ PLL3 Modulation Spread depth adjustment
$07000000 constant RCC_S_RCC_PLL3CFGR3_PLL3PDIV2                    \ PLL3 VCO frequency divider level 2
$38000000 constant RCC_S_RCC_PLL3CFGR3_PLL3PDIV1                    \ PLL3 VCO frequency divider level 1
$40000000 constant RCC_S_RCC_PLL3CFGR3_PLL3PDIVEN                   \ PLL3 post divider POSTDIV1, POSTDIV2, and PLL clock output enable


\
\ @brief RCC PLL4 configuration register 1
\ Address offset: 0xB0
\ Reset value: 0x08000000
\

$000fff00 constant RCC_S_RCC_PLL4CFGR1_PLL4DIVN                     \ PLL4 Integer part for the VCO multiplication factor
$03f00000 constant RCC_S_RCC_PLL4CFGR1_PLL4DIVM                     \ PLL4 reference input clock divide frequency ratio
$08000000 constant RCC_S_RCC_PLL4CFGR1_PLL4BYP                      \ PLL4 bypass
$70000000 constant RCC_S_RCC_PLL4CFGR1_PLL4SEL                      \ PLL4 source selection of the reference clock


\
\ @brief RCC PLL4 configuration register 2
\ Address offset: 0xB4
\ Reset value: 0x00000000
\

$00ffffff constant RCC_S_RCC_PLL4CFGR2_PLL4DIVNFRAC                 \ PLL4 Fractional part of the VCO multiplication factor


\
\ @brief RCC PLL4 configuration register 3
\ Address offset: 0xB8
\ Reset value: 0x49000005
\

$00000001 constant RCC_S_RCC_PLL4CFGR3_PLL4MODSSRST                 \ PLL4 Modulation Spread Spectrum reset
$00000002 constant RCC_S_RCC_PLL4CFGR3_PLL4DACEN                    \ PLL4 noise canceling DAC enable in fractional mode.
$00000004 constant RCC_S_RCC_PLL4CFGR3_PLL4MODSSDIS                 \ PLL4 Modulation Spread-Spectrum Disable
$00000008 constant RCC_S_RCC_PLL4CFGR3_PLL4MODDSEN                  \ PLL4 Modulation Spread-Spectrum (and Fractional Divide) enable
$00000010 constant RCC_S_RCC_PLL4CFGR3_PLL4MODSPRDW                 \ PLL4 Modulation Down Spread
$00000f00 constant RCC_S_RCC_PLL4CFGR3_PLL4MODDIV                   \ PLL4 Modulation Division frequency adjustment
$001f0000 constant RCC_S_RCC_PLL4CFGR3_PLL4MODSPR                   \ PLL4 Modulation Spread depth adjustment
$07000000 constant RCC_S_RCC_PLL4CFGR3_PLL4PDIV2                    \ PLL4 VCO frequency divider level 2
$38000000 constant RCC_S_RCC_PLL4CFGR3_PLL4PDIV1                    \ PLL4 VCO frequency divider level 1
$40000000 constant RCC_S_RCC_PLL4CFGR3_PLL4PDIVEN                   \ PLL4 post divider POSTDIV1, POSTDIV2, and PLL clock output enable


\
\ @brief RCC IC1 configuration register
\ Address offset: 0xC4
\ Reset value: 0x00020000
\

$00ff0000 constant RCC_S_RCC_IC1CFGR_IC1INT                         \ Divider IC1 integer division factor
$30000000 constant RCC_S_RCC_IC1CFGR_IC1SEL                         \ Divider IC1 Source Selection


\
\ @brief RCC IC2 configuration register
\ Address offset: 0xC8
\ Reset value: 0x00030000
\

$00ff0000 constant RCC_S_RCC_IC2CFGR_IC2INT                         \ Divider IC2 integer division factor
$30000000 constant RCC_S_RCC_IC2CFGR_IC2SEL                         \ Divider IC2 Source Selection


\
\ @brief RCC IC3 configuration register
\ Address offset: 0xCC
\ Reset value: 0x00000000
\

$00ff0000 constant RCC_S_RCC_IC3CFGR_IC3INT                         \ Divider IC3 integer division factor
$30000000 constant RCC_S_RCC_IC3CFGR_IC3SEL                         \ Divider IC3 Source Selection


\
\ @brief RCC IC4 configuration register
\ Address offset: 0xD0
\ Reset value: 0x00000000
\

$00ff0000 constant RCC_S_RCC_IC4CFGR_IC4INT                         \ Divider IC4 integer division factor
$30000000 constant RCC_S_RCC_IC4CFGR_IC4SEL                         \ Divider IC4 Source Selection


\
\ @brief RCC IC5 configuration register
\ Address offset: 0xD4
\ Reset value: 0x00000000
\

$00ff0000 constant RCC_S_RCC_IC5CFGR_IC5INT                         \ Divider IC5 integer division factor
$30000000 constant RCC_S_RCC_IC5CFGR_IC5SEL                         \ Divider IC5 Source Selection


\
\ @brief RCC IC6 configuration register
\ Address offset: 0xD8
\ Reset value: 0x00030000
\

$00ff0000 constant RCC_S_RCC_IC6CFGR_IC6INT                         \ Divider IC6 integer division factor
$30000000 constant RCC_S_RCC_IC6CFGR_IC6SEL                         \ Divider IC6 Source Selection


\
\ @brief RCC IC7 configuration register
\ Address offset: 0xDC
\ Reset value: 0x10000000
\

$00ff0000 constant RCC_S_RCC_IC7CFGR_IC7INT                         \ Divider IC7 integer division factor
$30000000 constant RCC_S_RCC_IC7CFGR_IC7SEL                         \ Divider IC7 Source Selection


\
\ @brief RCC IC8 configuration register
\ Address offset: 0xE0
\ Reset value: 0x10000000
\

$00ff0000 constant RCC_S_RCC_IC8CFGR_IC8INT                         \ Divider IC8 integer division factor
$30000000 constant RCC_S_RCC_IC8CFGR_IC8SEL                         \ Divider IC8 Source Selection


\
\ @brief RCC IC9 configuration register
\ Address offset: 0xE4
\ Reset value: 0x10000000
\

$00ff0000 constant RCC_S_RCC_IC9CFGR_IC9INT                         \ Divider IC9 integer division factor
$30000000 constant RCC_S_RCC_IC9CFGR_IC9SEL                         \ Divider IC9 Source Selection


\
\ @brief RCC IC10 configuration register
\ Address offset: 0xE8
\ Reset value: 0x10000000
\

$00ff0000 constant RCC_S_RCC_IC10CFGR_IC10INT                       \ Divider IC10 integer division factor
$30000000 constant RCC_S_RCC_IC10CFGR_IC10SEL                       \ Divider IC10 Source Selection


\
\ @brief RCC IC11 configuration register
\ Address offset: 0xEC
\ Reset value: 0x00030000
\

$00ff0000 constant RCC_S_RCC_IC11CFGR_IC11INT                       \ Divider IC11 integer division factor
$30000000 constant RCC_S_RCC_IC11CFGR_IC11SEL                       \ Divider IC11 Source Selection


\
\ @brief RCC IC12 configuration register
\ Address offset: 0xF0
\ Reset value: 0x20000000
\

$00ff0000 constant RCC_S_RCC_IC12CFGR_IC12INT                       \ Divider IC12 integer division factor
$30000000 constant RCC_S_RCC_IC12CFGR_IC12SEL                       \ Divider IC12 Source Selection


\
\ @brief RCC IC13 configuration register
\ Address offset: 0xF4
\ Reset value: 0x20000000
\

$00ff0000 constant RCC_S_RCC_IC13CFGR_IC13INT                       \ Divider IC13 integer division factor
$30000000 constant RCC_S_RCC_IC13CFGR_IC13SEL                       \ Divider IC13 Source Selection


\
\ @brief RCC IC14 configuration register
\ Address offset: 0xF8
\ Reset value: 0x20000000
\

$00ff0000 constant RCC_S_RCC_IC14CFGR_IC14INT                       \ Divider IC14 integer division factor
$30000000 constant RCC_S_RCC_IC14CFGR_IC14SEL                       \ Divider IC14 Source Selection


\
\ @brief RCC IC15 configuration register
\ Address offset: 0xFC
\ Reset value: 0x20000000
\

$00ff0000 constant RCC_S_RCC_IC15CFGR_IC15INT                       \ Divider IC15 integer division factor
$30000000 constant RCC_S_RCC_IC15CFGR_IC15SEL                       \ Divider IC15 Source Selection


\
\ @brief RCC IC16 configuration register
\ Address offset: 0x100
\ Reset value: 0x30000000
\

$00ff0000 constant RCC_S_RCC_IC16CFGR_IC16INT                       \ Divider IC16 integer division factor
$30000000 constant RCC_S_RCC_IC16CFGR_IC16SEL                       \ Divider IC16 Source Selection


\
\ @brief RCC IC17 configuration register
\ Address offset: 0x104
\ Reset value: 0x30000000
\

$00ff0000 constant RCC_S_RCC_IC17CFGR_IC17INT                       \ Divider IC17 integer division factor
$30000000 constant RCC_S_RCC_IC17CFGR_IC17SEL                       \ Divider IC17 Source Selection


\
\ @brief RCC IC18 configuration register
\ Address offset: 0x108
\ Reset value: 0x30000000
\

$00ff0000 constant RCC_S_RCC_IC18CFGR_IC18INT                       \ Divider IC18 integer division factor
$30000000 constant RCC_S_RCC_IC18CFGR_IC18SEL                       \ Divider IC18 Source Selection


\
\ @brief RCC IC19 configuration register
\ Address offset: 0x10C
\ Reset value: 0x30000000
\

$00ff0000 constant RCC_S_RCC_IC19CFGR_IC19INT                       \ Divider IC19 integer division factor
$30000000 constant RCC_S_RCC_IC19CFGR_IC19SEL                       \ Divider IC19 Source Selection


\
\ @brief RCC IC20 configuration register
\ Address offset: 0x110
\ Reset value: 0x30000000
\

$00ff0000 constant RCC_S_RCC_IC20CFGR_IC20INT                       \ Divider IC20 integer division factor
$30000000 constant RCC_S_RCC_IC20CFGR_IC20SEL                       \ Divider IC20 Source Selection


\
\ @brief RCC clock-source interrupt enable register
\ Address offset: 0x124
\ Reset value: 0x00020000
\

$00000001 constant RCC_S_RCC_CIER_LSIRDYIE                          \ LSI ready interrupt enable
$00000002 constant RCC_S_RCC_CIER_LSERDYIE                          \ LSE ready interrupt enable
$00000004 constant RCC_S_RCC_CIER_MSIRDYIE                          \ MSI ready interrupt enable
$00000008 constant RCC_S_RCC_CIER_HSIRDYIE                          \ HSI ready interrupt enable
$00000010 constant RCC_S_RCC_CIER_HSERDYIE                          \ HSE ready interrupt enable
$00000100 constant RCC_S_RCC_CIER_PLL1RDYIE                         \ PLL1 ready interrupt enable
$00000200 constant RCC_S_RCC_CIER_PLL2RDYIE                         \ PLL2 ready interrupt enable
$00000400 constant RCC_S_RCC_CIER_PLL3RDYIE                         \ PLL3 ready interrupt enable
$00000800 constant RCC_S_RCC_CIER_PLL4RDYIE                         \ PLL4 ready interrupt enable
$00010000 constant RCC_S_RCC_CIER_LSECSSIE                          \ LSE clock security system (CSS) interrupt enable
$00020000 constant RCC_S_RCC_CIER_HSECSSIE                          \ HSE clock security system (CSS) interrupt enable
$01000000 constant RCC_S_RCC_CIER_WKUPIE                            \ CPU wakeup from Stop interrupt enable


\
\ @brief RCC clock-source interrupt flag register
\ Address offset: 0x128
\ Reset value: 0x00000000
\

$00000001 constant RCC_S_RCC_CIFR_LSIRDYF                           \ LSI ready interrupt flag
$00000002 constant RCC_S_RCC_CIFR_LSERDYF                           \ LSE ready interrupt flag
$00000004 constant RCC_S_RCC_CIFR_MSIRDYF                           \ MSI ready interrupt flag
$00000008 constant RCC_S_RCC_CIFR_HSIRDYF                           \ HSI ready interrupt flag
$00000010 constant RCC_S_RCC_CIFR_HSERDYF                           \ HSE ready interrupt flag
$00000100 constant RCC_S_RCC_CIFR_PLL1RDYF                          \ PLL1 ready interrupt flag
$00000200 constant RCC_S_RCC_CIFR_PLL2RDYF                          \ PLL2 ready interrupt flag
$00000400 constant RCC_S_RCC_CIFR_PLL3RDYF                          \ PLL3 ready interrupt flag
$00000800 constant RCC_S_RCC_CIFR_PLL4RDYF                          \ PLL4 ready interrupt flag
$00010000 constant RCC_S_RCC_CIFR_LSECSSF                           \ LSE ready interrupt flag
$00020000 constant RCC_S_RCC_CIFR_HSECSSF                           \ HSE ready interrupt flag
$01000000 constant RCC_S_RCC_CIFR_WKUPF                             \ CPU wakeup from Stop interrupt flag


\
\ @brief RCC clock-source interrupt Clear register
\ Address offset: 0x12C
\ Reset value: 0x00000000
\

$00000001 constant RCC_S_RCC_CICR_LSIRDYC                           \ LSI ready interrupt clear
$00000002 constant RCC_S_RCC_CICR_LSERDYC                           \ LSE ready interrupt clear
$00000004 constant RCC_S_RCC_CICR_MSIRDYC                           \ MSI ready interrupt clear
$00000008 constant RCC_S_RCC_CICR_HSIRDYC                           \ HSI ready interrupt clear
$00000010 constant RCC_S_RCC_CICR_HSERDYC                           \ HSE ready interrupt clear
$00000100 constant RCC_S_RCC_CICR_PLL1RDYC                          \ PLL1 ready interrupt clear
$00000200 constant RCC_S_RCC_CICR_PLL2RDYC                          \ PLL2 ready interrupt clear
$00000400 constant RCC_S_RCC_CICR_PLL3RDYC                          \ PLL3 ready interrupt clear
$00000800 constant RCC_S_RCC_CICR_PLL4RDYC                          \ PLL4 ready interrupt clear
$00010000 constant RCC_S_RCC_CICR_LSECSSC                           \ LSE ready interrupt clear
$00020000 constant RCC_S_RCC_CICR_HSECSSC                           \ HSE ready interrupt clear
$01000000 constant RCC_S_RCC_CICR_WKUPFC                            \ CPU Wakeup ready interrupt clear


\
\ @brief RCC clock configuration for independent peripheral register1
\ Address offset: 0x144
\ Reset value: 0x00000000
\

$00000007 constant RCC_S_RCC_CCIPR1_ADF1SEL                         \ Source selection for the ADF1 kernel clock
$00000070 constant RCC_S_RCC_CCIPR1_ADC12SEL                        \ Source selection for the ADC12 kernel clock
$0000ff00 constant RCC_S_RCC_CCIPR1_ADCPRE                          \ ADC12 Prog clock divider selection (for clock ck_icn_p_adf1)
$00300000 constant RCC_S_RCC_CCIPR1_DCMIPPSEL                       \ Source selection for the DCMIPP kernel clock


\
\ @brief RCC clock configuration for independent peripheral register 2
\ Address offset: 0x148
\ Reset value: 0x00000000
\

$00000003 constant RCC_S_RCC_CCIPR2_ETH1PTPSEL                      \ Source selection for the ETH1 kernel clock
$000000f0 constant RCC_S_RCC_CCIPR2_ETH1PTPDIV                      \ ETH1 Kernel clock divider selection (for clock ck_ker_eth1ptp)
$00000100 constant RCC_S_RCC_CCIPR2_ETH1PWRDOWNACK                  \ Set and reset by software.
$00003000 constant RCC_S_RCC_CCIPR2_ETH1CLKSEL                      \ Source selection for the ETH1 kernel clock
$00070000 constant RCC_S_RCC_CCIPR2_ETH1SEL                         \ Set and reset by software
$00100000 constant RCC_S_RCC_CCIPR2_ETH1REFCLKSEL                   \ Set and reset by software
$01000000 constant RCC_S_RCC_CCIPR2_ETH1GTXCLKSEL                   \ Set and reset by software.


\
\ @brief RCC clock configuration for independent peripheral register3
\ Address offset: 0x14C
\ Reset value: 0x00000001
\

$00000003 constant RCC_S_RCC_CCIPR3_FDCANSEL                        \ Source selection for the FDCAN kernel clock
$00000030 constant RCC_S_RCC_CCIPR3_FMCSEL                          \ Source selection for the FMC kernel clock
$00000100 constant RCC_S_RCC_CCIPR3_DFTSEL                          \ Source selection for the DFT kernel clock


\
\ @brief RCC clock configuration for independent peripheral register4
\ Address offset: 0x150
\ Reset value: 0x00000000
\

$00000007 constant RCC_S_RCC_CCIPR4_I2C1SEL                         \ Source selection for the I2C1 kernel clock
$00000070 constant RCC_S_RCC_CCIPR4_I2C2SEL                         \ Source selection for the I2C2 kernel clock
$00000700 constant RCC_S_RCC_CCIPR4_I2C3SEL                         \ Source selection for the I2C3 kernel clock
$00007000 constant RCC_S_RCC_CCIPR4_I2C4SEL                         \ Source selection for the I2C4 kernel clock
$00070000 constant RCC_S_RCC_CCIPR4_I3C1SEL                         \ Source selection for the I3C1 kernel clock
$00700000 constant RCC_S_RCC_CCIPR4_I3C2SEL                         \ Source selection for the I3C2 kernel clock
$03000000 constant RCC_S_RCC_CCIPR4_LTDCSEL                         \ Source selection for the LTDC kernel clock


\
\ @brief RCC lock configuration for independent peripheral register5
\ Address offset: 0x154
\ Reset value: 0x0000F0F0
\

$00000007 constant RCC_S_RCC_CCIPR5_MCO1SEL                         \ Source selection for the MCO1 kernel clock
$000000f0 constant RCC_S_RCC_CCIPR5_MCO1PRE                         \ MCO1 Prog clock divider selection (for clock ck_icn_p_mce3)
$00000700 constant RCC_S_RCC_CCIPR5_MCO2SEL                         \ Source selection for the MCO2 kernel clock
$0000f000 constant RCC_S_RCC_CCIPR5_MCO2PRE                         \ MCO2 Prog clock divider selection (for clock ck_icn_p_mce4)
$00070000 constant RCC_S_RCC_CCIPR5_MDF1SEL                         \ Source selection for the MDF1 kernel clock


\
\ @brief RCC clock configuration for independent peripheral register6
\ Address offset: 0x158
\ Reset value: 0x00000000
\

$00000003 constant RCC_S_RCC_CCIPR6_XSPI1SEL                        \ Source selection for the XSPI1 kernel clock
$00000030 constant RCC_S_RCC_CCIPR6_XSPI2SEL                        \ Source selection for the XSPI2 kernel clock
$00000300 constant RCC_S_RCC_CCIPR6_XSPI3SEL                        \ Source selection for the XSPI3 kernel clock
$00003000 constant RCC_S_RCC_CCIPR6_OTGPHY1SEL                      \ Source selection for the OTGPHY1 kernel clock
$00010000 constant RCC_S_RCC_CCIPR6_OTGPHY1CKREFSEL                 \ Set and reset by software
$00300000 constant RCC_S_RCC_CCIPR6_OTGPHY2SEL                      \ Source selection for the OTGPHY2 kernel clock
$01000000 constant RCC_S_RCC_CCIPR6_OTGPHY2CKREFSEL                 \ Set and reset by software


\
\ @brief RCC clock configuration for independent peripheral register7
\ Address offset: 0x15C
\ Reset value: 0x00000000
\

$00000007 constant RCC_S_RCC_CCIPR7_PERSEL                          \ Source selection for the PER kernel clock
$00000030 constant RCC_S_RCC_CCIPR7_PSSISEL                         \ Source selection for the PSSI kernel clock
$00000300 constant RCC_S_RCC_CCIPR7_RTCSEL                          \ Source selection for the RTC kernel clock
$0003f000 constant RCC_S_RCC_CCIPR7_RTCPRE                          \ RTC Prog clock divider selection (for clock ck_icn_p_risaf)
$00700000 constant RCC_S_RCC_CCIPR7_SAI1SEL                         \ Source selection for the SAI1 kernel clock
$07000000 constant RCC_S_RCC_CCIPR7_SAI2SEL                         \ Source selection for the SAI2 kernel clock


\
\ @brief RCC clock configuration for independent peripheral register8
\ Address offset: 0x160
\ Reset value: 0x00000000
\

$00000003 constant RCC_S_RCC_CCIPR8_SDMMC1SEL                       \ Source selection for the SDMMC1 kernel clock
$00000030 constant RCC_S_RCC_CCIPR8_SDMMC2SEL                       \ Source selection for the SDMMC2 kernel clock


\
\ @brief RCC clock configuration for independent peripheral register9
\ Address offset: 0x164
\ Reset value: 0x00000000
\

$00000007 constant RCC_S_RCC_CCIPR9_SPDIFRX1SEL                     \ Source selection for the SPDIFRX1 kernel clock
$00000070 constant RCC_S_RCC_CCIPR9_SPI1SEL                         \ Source selection for the SPI1 kernel clock
$00000700 constant RCC_S_RCC_CCIPR9_SPI2SEL                         \ Source selection for the SPI2 kernel clock
$00007000 constant RCC_S_RCC_CCIPR9_SPI3SEL                         \ Source selection for the SPI3 kernel clock
$00070000 constant RCC_S_RCC_CCIPR9_SPI4SEL                         \ Source selection for the SPI4 kernel clock
$00700000 constant RCC_S_RCC_CCIPR9_SPI5SEL                         \ Source selection for the SPI5 kernel clock
$07000000 constant RCC_S_RCC_CCIPR9_SPI6SEL                         \ Source selection for the SPI6 kernel clock


\
\ @brief RCC clock configuration for independent peripheral register12
\ Address offset: 0x170
\ Reset value: 0x00000000
\

$00000700 constant RCC_S_RCC_CCIPR12_LPTIM1SEL                      \ Source selection for the LPTIM1 kernel clock
$00007000 constant RCC_S_RCC_CCIPR12_LPTIM2SEL                      \ Source selection for the LPTIM2 kernel clock
$00070000 constant RCC_S_RCC_CCIPR12_LPTIM3SEL                      \ Source selection for the LPTIM3 kernel clock
$00700000 constant RCC_S_RCC_CCIPR12_LPTIM4SEL                      \ Source selection for the LPTIM4 kernel clock
$07000000 constant RCC_S_RCC_CCIPR12_LPTIM5SEL                      \ Source selection for the LPTIM5 kernel clock


\
\ @brief RCC clock configuration for independent peripheral register13
\ Address offset: 0x174
\ Reset value: 0x00000000
\

$00000007 constant RCC_S_RCC_CCIPR13_USART1SEL                      \ Source selection for the USART1 kernel clock
$00000070 constant RCC_S_RCC_CCIPR13_USART2SEL                      \ Source selection for the USART2 kernel clock
$00000700 constant RCC_S_RCC_CCIPR13_USART3SEL                      \ Source selection for the USART3 kernel clock
$00007000 constant RCC_S_RCC_CCIPR13_UART4SEL                       \ Source selection for the UART4 kernel clock
$00070000 constant RCC_S_RCC_CCIPR13_UART5SEL                       \ Source selection for the UART5 kernel clock
$00700000 constant RCC_S_RCC_CCIPR13_USART6SEL                      \ Source selection for the USART6 kernel clock
$07000000 constant RCC_S_RCC_CCIPR13_UART7SEL                       \ Source selection for the UART7 kernel clock
$70000000 constant RCC_S_RCC_CCIPR13_UART8SEL                       \ Source selection for the UART8 kernel clock


\
\ @brief RCC clock configuration for independent peripheral register14
\ Address offset: 0x178
\ Reset value: 0x00000000
\

$00000007 constant RCC_S_RCC_CCIPR14_UART9SEL                       \ Source selection for the UART9 kernel clock
$00000070 constant RCC_S_RCC_CCIPR14_USART10SEL                     \ Source selection for the USART10 kernel clock
$00000700 constant RCC_S_RCC_CCIPR14_LPUART1SEL                     \ Source selection for the LPUART1 kernel clock


\
\ @brief RCC SoC buses reset register
\ Address offset: 0x204
\ Reset value: 0x00000000
\

$00000001 constant RCC_S_RCC_BUSRSTR_ACLKNRST                       \ ACLKN reset
$00000004 constant RCC_S_RCC_BUSRSTR_AHBMRST                        \ AHBM reset
$00000008 constant RCC_S_RCC_BUSRSTR_AHB1RST                        \ AHB1 reset
$00000010 constant RCC_S_RCC_BUSRSTR_AHB2RST                        \ AHB2 reset
$00000020 constant RCC_S_RCC_BUSRSTR_AHB3RST                        \ AHB3 reset
$00000040 constant RCC_S_RCC_BUSRSTR_AHB4RST                        \ AHB4 reset
$00000080 constant RCC_S_RCC_BUSRSTR_AHB5RST                        \ AHB5 reset
$00000100 constant RCC_S_RCC_BUSRSTR_APB1RST                        \ APB1 reset
$00000200 constant RCC_S_RCC_BUSRSTR_APB2RST                        \ APB2 reset
$00000400 constant RCC_S_RCC_BUSRSTR_APB3RST                        \ APB3 reset
$00000800 constant RCC_S_RCC_BUSRSTR_APB4RST                        \ APB4 reset
$00001000 constant RCC_S_RCC_BUSRSTR_APB5RST                        \ APB5 reset
$00002000 constant RCC_S_RCC_BUSRSTR_NOCRST                         \ NOC reset


\
\ @brief RCC miscellaneous configurations reset register
\ Address offset: 0x208
\ Reset value: 0x00000000
\

$00000001 constant RCC_S_RCC_MISCRSTR_DBGRST                        \ DBG reset
$00000010 constant RCC_S_RCC_MISCRSTR_XSPIPHY1RST                   \ XSPIPHY1 reset
$00000020 constant RCC_S_RCC_MISCRSTR_XSPIPHY2RST                   \ XSPIPHY2 reset
$00000080 constant RCC_S_RCC_MISCRSTR_SDMMC1DLLRST                  \ SDMMC1DLL reset
$00000100 constant RCC_S_RCC_MISCRSTR_SDMMC2DLLRST                  \ SDMMC2DLL reset


\
\ @brief RCC memories reset register
\ Address offset: 0x20C
\ Reset value: 0x00000000
\

$00000001 constant RCC_S_RCC_MEMRSTR_AXISRAM3RST                    \ AXISRAM3 reset
$00000002 constant RCC_S_RCC_MEMRSTR_AXISRAM4RST                    \ AXISRAM4reset
$00000004 constant RCC_S_RCC_MEMRSTR_AXISRAM5RST                    \ AXISRAM5 reset
$00000008 constant RCC_S_RCC_MEMRSTR_AXISRAM6RST                    \ AXISRAM6 reset
$00000010 constant RCC_S_RCC_MEMRSTR_AHBSRAM1RST                    \ AHBSRAM1 reset
$00000020 constant RCC_S_RCC_MEMRSTR_AHBSRAM2RST                    \ AHBSRAM2 reset
$00000080 constant RCC_S_RCC_MEMRSTR_AXISRAM1RST                    \ AXISRAM1 reset
$00000100 constant RCC_S_RCC_MEMRSTR_AXISRAM2RST                    \ AXISRAM2 reset
$00000200 constant RCC_S_RCC_MEMRSTR_FLEXRAMRST                     \ FLEXRAM reset
$00000400 constant RCC_S_RCC_MEMRSTR_NPUCACHERAMRST                 \ NPUCACHERAM reset
$00000800 constant RCC_S_RCC_MEMRSTR_VENCRAMRST                     \ VENCRAM reset
$00001000 constant RCC_S_RCC_MEMRSTR_BOOTROMRST                     \ BOOTROM reset


\
\ @brief RCC AHB1 Reset register
\ Address offset: 0x210
\ Reset value: 0x00000000
\

$00000010 constant RCC_S_RCC_AHB1RSTR_GPDMA1RST                     \ GPDMA1 reset
$00000020 constant RCC_S_RCC_AHB1RSTR_ADC12RST                      \ ADC12 reset


\
\ @brief RCC AHB2 reset register
\ Address offset: 0x214
\ Reset value: 0x00000000
\

$00001000 constant RCC_S_RCC_AHB2RSTR_RAMCFGRST                     \ RAMCFG reset
$00010000 constant RCC_S_RCC_AHB2RSTR_MDF1RST                       \ MDF1 reset
$00020000 constant RCC_S_RCC_AHB2RSTR_ADF1RST                       \ ADF1 reset


\
\ @brief RCC AHB3 reset register
\ Address offset: 0x218
\ Reset value: 0x00000000
\

$00000001 constant RCC_S_RCC_AHB3RSTR_RNGRST                        \ RNG reset
$00000002 constant RCC_S_RCC_AHB3RSTR_HASHRST                       \ HASH reset
$00000004 constant RCC_S_RCC_AHB3RSTR_CRYPRST                       \ CRYP reset
$00000010 constant RCC_S_RCC_AHB3RSTR_SAESRST                       \ SAES reset
$00000100 constant RCC_S_RCC_AHB3RSTR_PKARST                        \ PKA reset
$00000400 constant RCC_S_RCC_AHB3RSTR_IACRST                        \ IAC reset


\
\ @brief RCC AHB4 reset register
\ Address offset: 0x21C
\ Reset value: 0x00000000
\

$00000001 constant RCC_S_RCC_AHB4RSTR_GPIOARST                      \ GPIOA reset
$00000002 constant RCC_S_RCC_AHB4RSTR_GPIOBRST                      \ GPIOB reset
$00000004 constant RCC_S_RCC_AHB4RSTR_GPIOCRST                      \ GPIOC reset
$00000008 constant RCC_S_RCC_AHB4RSTR_GPIODRST                      \ GPIOD reset
$00000010 constant RCC_S_RCC_AHB4RSTR_GPIOERST                      \ GPIOE reset
$00000020 constant RCC_S_RCC_AHB4RSTR_GPIOFRST                      \ GPIOF reset
$00000040 constant RCC_S_RCC_AHB4RSTR_GPIOGRST                      \ GPIOG reset
$00000080 constant RCC_S_RCC_AHB4RSTR_GPIOHRST                      \ GPIOH reset
$00002000 constant RCC_S_RCC_AHB4RSTR_GPIONRST                      \ GPION reset
$00004000 constant RCC_S_RCC_AHB4RSTR_GPIOORST                      \ GPIOO reset
$00008000 constant RCC_S_RCC_AHB4RSTR_GPIOPRST                      \ GPIOP reset
$00010000 constant RCC_S_RCC_AHB4RSTR_GPIOQRST                      \ GPIOQ reset
$00040000 constant RCC_S_RCC_AHB4RSTR_PWRRST                        \ PWR reset
$00080000 constant RCC_S_RCC_AHB4RSTR_CRCRST                        \ CRC reset


\
\ @brief RCC AHB5 reset register
\ Address offset: 0x220
\ Reset value: 0x00000000
\

$00000001 constant RCC_S_RCC_AHB5RSTR_HPDMA1RST                     \ HPDMA1 reset
$00000002 constant RCC_S_RCC_AHB5RSTR_DMA2DRST                      \ DMA2D reset
$00000008 constant RCC_S_RCC_AHB5RSTR_JPEGRST                       \ JPEG reset
$00000010 constant RCC_S_RCC_AHB5RSTR_FMCRST                        \ FMC reset
$00000020 constant RCC_S_RCC_AHB5RSTR_XSPI1RST                      \ XSPI1 reset
$00000040 constant RCC_S_RCC_AHB5RSTR_PSSIRST                       \ PSSI reset
$00000080 constant RCC_S_RCC_AHB5RSTR_SDMMC2RST                     \ SDMMC2 reset
$00000100 constant RCC_S_RCC_AHB5RSTR_SDMMC1RST                     \ SDMMC1 reset
$00001000 constant RCC_S_RCC_AHB5RSTR_XSPI2RST                      \ XSPI2 reset
$00002000 constant RCC_S_RCC_AHB5RSTR_XSPIMRST                      \ XSPIM reset
$00020000 constant RCC_S_RCC_AHB5RSTR_XSPI3RST                      \ XSPI3 reset
$00040000 constant RCC_S_RCC_AHB5RSTR_MCE4RST                       \ MCE4 reset
$00080000 constant RCC_S_RCC_AHB5RSTR_GFXMMURST                     \ GFXMMU reset
$00100000 constant RCC_S_RCC_AHB5RSTR_GPURST                        \ GPU reset
$00800000 constant RCC_S_RCC_AHB5RSTR_SYSCFGOTGHSPHY1RST            \ SYSCFGOTGHSPHY1 reset
$01000000 constant RCC_S_RCC_AHB5RSTR_SYSCFGOTGHSPHY2RST            \ SYSCFGOTGHSPHY2 reset
$02000000 constant RCC_S_RCC_AHB5RSTR_ETH1RST                       \ ETH1 reset
$04000000 constant RCC_S_RCC_AHB5RSTR_OTG1RST                       \ OTG1 reset
$08000000 constant RCC_S_RCC_AHB5RSTR_OTGPHY1RST                    \ OTGPHY1 reset
$10000000 constant RCC_S_RCC_AHB5RSTR_OTGPHY2RST                    \ OTGPHY2 reset
$20000000 constant RCC_S_RCC_AHB5RSTR_OTG2RST                       \ OTG2 reset
$40000000 constant RCC_S_RCC_AHB5RSTR_NPUCACHERST                   \ NPUCACHE reset
$80000000 constant RCC_S_RCC_AHB5RSTR_NPURST                        \ NPU reset


\
\ @brief RCC APB1L reset register
\ Address offset: 0x224
\ Reset value: 0x00000000
\

$00000001 constant RCC_S_RCC_APB1LRSTR_TIM2RST                      \ TIM2 reset
$00000002 constant RCC_S_RCC_APB1LRSTR_TIM3RST                      \ TIM3 reset
$00000004 constant RCC_S_RCC_APB1LRSTR_TIM4RST                      \ TIM4 reset
$00000008 constant RCC_S_RCC_APB1LRSTR_TIM5RST                      \ TIM5 reset
$00000010 constant RCC_S_RCC_APB1LRSTR_TIM6RST                      \ TIM6 reset
$00000020 constant RCC_S_RCC_APB1LRSTR_TIM7RST                      \ TIM7 reset
$00000040 constant RCC_S_RCC_APB1LRSTR_TIM12RST                     \ TIM12 reset
$00000080 constant RCC_S_RCC_APB1LRSTR_TIM13RST                     \ TIM13 reset
$00000100 constant RCC_S_RCC_APB1LRSTR_TIM14RST                     \ TIM14 reset
$00000200 constant RCC_S_RCC_APB1LRSTR_LPTIM1RST                    \ LPTIM1 reset
$00000800 constant RCC_S_RCC_APB1LRSTR_WWDGRST                      \ WWDG reset
$00001000 constant RCC_S_RCC_APB1LRSTR_TIM10RST                     \ TIM10 reset
$00002000 constant RCC_S_RCC_APB1LRSTR_TIM11RST                     \ TIM11 reset
$00004000 constant RCC_S_RCC_APB1LRSTR_SPI2RST                      \ SPI2 reset
$00008000 constant RCC_S_RCC_APB1LRSTR_SPI3RST                      \ SPI3 reset
$00010000 constant RCC_S_RCC_APB1LRSTR_SPDIFRX1RST                  \ SPDIFRX1 reset
$00020000 constant RCC_S_RCC_APB1LRSTR_USART2RST                    \ USART2 reset
$00040000 constant RCC_S_RCC_APB1LRSTR_USART3RST                    \ USART3 reset
$00080000 constant RCC_S_RCC_APB1LRSTR_UART4RST                     \ UART4 reset
$00100000 constant RCC_S_RCC_APB1LRSTR_UART5RST                     \ UART5 reset
$00200000 constant RCC_S_RCC_APB1LRSTR_I2C1RST                      \ I2C1 reset
$00400000 constant RCC_S_RCC_APB1LRSTR_I2C2RST                      \ I2C2 reset
$00800000 constant RCC_S_RCC_APB1LRSTR_I2C3RST                      \ I2C3 reset
$01000000 constant RCC_S_RCC_APB1LRSTR_I3C1RST                      \ I3C1 reset
$02000000 constant RCC_S_RCC_APB1LRSTR_I3C2RST                      \ I3C2 reset
$40000000 constant RCC_S_RCC_APB1LRSTR_UART7RST                     \ UART7 reset
$80000000 constant RCC_S_RCC_APB1LRSTR_UART8RST                     \ UART8 reset


\
\ @brief RCC APB1H reset register
\ Address offset: 0x228
\ Reset value: 0x00000000
\

$00000020 constant RCC_S_RCC_APB1HRSTR_MDIOSRST                     \ MDIOS reset
$00000100 constant RCC_S_RCC_APB1HRSTR_FDCANRST                     \ FDCAN reset
$00040000 constant RCC_S_RCC_APB1HRSTR_UCPD1RST                     \ UCPD1 reset


\
\ @brief RCC APB2 reset register
\ Address offset: 0x22C
\ Reset value: 0x00000000
\

$00000001 constant RCC_S_RCC_APB2RSTR_TIM1RST                       \ TIM1 reset
$00000002 constant RCC_S_RCC_APB2RSTR_TIM8RST                       \ TIM8 reset
$00000010 constant RCC_S_RCC_APB2RSTR_USART1RST                     \ USART1 reset
$00000020 constant RCC_S_RCC_APB2RSTR_USART6RST                     \ USART6 reset
$00000040 constant RCC_S_RCC_APB2RSTR_UART9RST                      \ UART9 reset
$00000080 constant RCC_S_RCC_APB2RSTR_USART10RST                    \ USART10 reset
$00001000 constant RCC_S_RCC_APB2RSTR_SPI1RST                       \ SPI1 reset
$00002000 constant RCC_S_RCC_APB2RSTR_SPI4RST                       \ SPI4 reset
$00008000 constant RCC_S_RCC_APB2RSTR_TIM18RST                      \ TIM18 reset
$00010000 constant RCC_S_RCC_APB2RSTR_TIM15RST                      \ TIM15 reset
$00020000 constant RCC_S_RCC_APB2RSTR_TIM16RST                      \ TIM16 reset
$00040000 constant RCC_S_RCC_APB2RSTR_TIM17RST                      \ TIM17 reset
$00080000 constant RCC_S_RCC_APB2RSTR_TIM9RST                       \ TIM9 reset
$00100000 constant RCC_S_RCC_APB2RSTR_SPI5RST                       \ SPI5 reset
$00200000 constant RCC_S_RCC_APB2RSTR_SAI1RST                       \ SAI1 reset
$00400000 constant RCC_S_RCC_APB2RSTR_SAI2RST                       \ SAI2 reset


\
\ @brief RCC APB4L reset register
\ Address offset: 0x234
\ Reset value: 0x00000000
\

$00000004 constant RCC_S_RCC_APB4LRSTR_HDPRST                       \ HDP reset
$00000008 constant RCC_S_RCC_APB4LRSTR_LPUART1RST                   \ LPUART1 reset
$00000020 constant RCC_S_RCC_APB4LRSTR_SPI6RST                      \ SPI6 reset
$00000080 constant RCC_S_RCC_APB4LRSTR_I2C4RST                      \ I2C4 reset
$00000200 constant RCC_S_RCC_APB4LRSTR_LPTIM2RST                    \ LPTIM2 reset
$00000400 constant RCC_S_RCC_APB4LRSTR_LPTIM3RST                    \ LPTIM3 reset
$00000800 constant RCC_S_RCC_APB4LRSTR_LPTIM4RST                    \ LPTIM4 reset
$00001000 constant RCC_S_RCC_APB4LRSTR_LPTIM5RST                    \ LPTIM5 reset
$00008000 constant RCC_S_RCC_APB4LRSTR_VREFBUFRST                   \ VREFBUF reset
$00010000 constant RCC_S_RCC_APB4LRSTR_RTCRST                       \ RTC reset
$00400000 constant RCC_S_RCC_APB4LRSTR_R2GRETRST                    \ R2GRET reset
$00800000 constant RCC_S_RCC_APB4LRSTR_R2GNPURST                    \ R2GNPU reset
$80000000 constant RCC_S_RCC_APB4LRSTR_SERFRST                      \ SERF reset


\
\ @brief RCC APB4H reset register
\ Address offset: 0x238
\ Reset value: 0x00000000
\

$00000001 constant RCC_S_RCC_APB4HRSTR_SYSCFGRST                    \ SYSCFG reset
$00000004 constant RCC_S_RCC_APB4HRSTR_DTSRST                       \ DTS reset
$00000010 constant RCC_S_RCC_APB4HRSTR_BUSPERFMRST                  \ BUSPERFM reset


\
\ @brief RCC APB5 reset register
\ Address offset: 0x23C
\ Reset value: 0x00000000
\

$00000002 constant RCC_S_RCC_APB5RSTR_LTDCRST                       \ LTDC reset
$00000004 constant RCC_S_RCC_APB5RSTR_DCMIPPRST                     \ DCMIPP reset
$00000010 constant RCC_S_RCC_APB5RSTR_GFXTIMRST                     \ GFXTIM reset
$00000020 constant RCC_S_RCC_APB5RSTR_VENCRST                       \ VENC reset
$00000040 constant RCC_S_RCC_APB5RSTR_CSIRST                        \ CSI reset


\
\ @brief RCC IC dividers enable register
\ Address offset: 0x240
\ Reset value: 0x00000000
\

$00000001 constant RCC_S_RCC_DIVENR_IC1EN                           \ IC1 enable
$00000002 constant RCC_S_RCC_DIVENR_IC2EN                           \ IC2 enable
$00000004 constant RCC_S_RCC_DIVENR_IC3EN                           \ IC3 enable
$00000008 constant RCC_S_RCC_DIVENR_IC4EN                           \ IC4 enable
$00000010 constant RCC_S_RCC_DIVENR_IC5EN                           \ IC5 enable
$00000020 constant RCC_S_RCC_DIVENR_IC6EN                           \ IC6 enable
$00000040 constant RCC_S_RCC_DIVENR_IC7EN                           \ IC7 enable
$00000080 constant RCC_S_RCC_DIVENR_IC8EN                           \ IC8 enable
$00000100 constant RCC_S_RCC_DIVENR_IC9EN                           \ IC9 enable
$00000200 constant RCC_S_RCC_DIVENR_IC10EN                          \ IC10 enable
$00000400 constant RCC_S_RCC_DIVENR_IC11EN                          \ IC11 enable
$00000800 constant RCC_S_RCC_DIVENR_IC12EN                          \ IC12 enable
$00001000 constant RCC_S_RCC_DIVENR_IC13EN                          \ IC13 enable
$00002000 constant RCC_S_RCC_DIVENR_IC14EN                          \ IC14 enable
$00004000 constant RCC_S_RCC_DIVENR_IC15EN                          \ IC15 enable
$00008000 constant RCC_S_RCC_DIVENR_IC16EN                          \ IC16 enable
$00010000 constant RCC_S_RCC_DIVENR_IC17EN                          \ IC17 enable
$00020000 constant RCC_S_RCC_DIVENR_IC18EN                          \ IC18 enable
$00040000 constant RCC_S_RCC_DIVENR_IC19EN                          \ IC19 enable
$00080000 constant RCC_S_RCC_DIVENR_IC20EN                          \ IC20 enable


\
\ @brief RCC SoC buses enable register
\ Address offset: 0x244
\ Reset value: 0x00000003
\

$00000001 constant RCC_S_RCC_BUSENR_ACLKNEN                         \ ACLKN enable
$00000002 constant RCC_S_RCC_BUSENR_ACLKNCEN                        \ ACLKNC enable
$00000004 constant RCC_S_RCC_BUSENR_AHBMEN                          \ AHBM enable
$00000008 constant RCC_S_RCC_BUSENR_AHB1EN                          \ AHB1 enable
$00000010 constant RCC_S_RCC_BUSENR_AHB2EN                          \ AHB2 enable
$00000020 constant RCC_S_RCC_BUSENR_AHB3EN                          \ AHB3 enable
$00000040 constant RCC_S_RCC_BUSENR_AHB4EN                          \ AHB4 enable
$00000080 constant RCC_S_RCC_BUSENR_AHB5EN                          \ AHB5 enable
$00000100 constant RCC_S_RCC_BUSENR_APB1EN                          \ APB1 enable
$00000200 constant RCC_S_RCC_BUSENR_APB2EN                          \ APB2 enable
$00000400 constant RCC_S_RCC_BUSENR_APB3EN                          \ APB3 enable
$00000800 constant RCC_S_RCC_BUSENR_APB4EN                          \ APB4 enable
$00001000 constant RCC_S_RCC_BUSENR_APB5EN                          \ APB5 enable


\
\ @brief RCC miscellaneous configuration enable register
\ Address offset: 0x248
\ Reset value: 0x00000000
\

$00000001 constant RCC_S_RCC_MISCENR_DBGEN                          \ DBG enable
$00000002 constant RCC_S_RCC_MISCENR_MCO1EN                         \ MCO1 enable
$00000004 constant RCC_S_RCC_MISCENR_MCO2EN                         \ MCO2 enable
$00000008 constant RCC_S_RCC_MISCENR_XSPIPHYCOMPEN                  \ XSPIPHYCOMP enable
$00000040 constant RCC_S_RCC_MISCENR_PEREN                          \ PER enable


\
\ @brief RCC memory enable register
\ Address offset: 0x24C
\ Reset value: 0x000013FF
\

$00000001 constant RCC_S_RCC_MEMENR_AXISRAM3EN                      \ AXISRAM3 enable
$00000002 constant RCC_S_RCC_MEMENR_AXISRAM4EN                      \ AXISRAM4 enable
$00000004 constant RCC_S_RCC_MEMENR_AXISRAM5EN                      \ AXISRAM5 enable
$00000008 constant RCC_S_RCC_MEMENR_AXISRAM6EN                      \ AXISRAM6 enable
$00000010 constant RCC_S_RCC_MEMENR_AHBSRAM1EN                      \ AHBSRAM1 enable
$00000020 constant RCC_S_RCC_MEMENR_AHBSRAM2EN                      \ AHBSRAM2 enable
$00000040 constant RCC_S_RCC_MEMENR_BKPSRAMEN                       \ BKPSRAM enable
$00000080 constant RCC_S_RCC_MEMENR_AXISRAM1EN                      \ AXISRAM1 enable
$00000100 constant RCC_S_RCC_MEMENR_AXISRAM2EN                      \ AXISRAM2 enable
$00000200 constant RCC_S_RCC_MEMENR_FLEXRAMEN                       \ FLEXRAM enable
$00000400 constant RCC_S_RCC_MEMENR_NPUCACHERAMEN                   \ NPUCACHERAM enable
$00000800 constant RCC_S_RCC_MEMENR_VENCRAMEN                       \ VENCRAM enable
$00001000 constant RCC_S_RCC_MEMENR_BOOTROMEN                       \ BOOTROM enable


\
\ @brief RCC AHB1 enable register
\ Address offset: 0x250
\ Reset value: 0x00000000
\

$00000010 constant RCC_S_RCC_AHB1ENR_GPDMA1EN                       \ GPDMA1 enable
$00000020 constant RCC_S_RCC_AHB1ENR_ADC12EN                        \ ADC12 enable


\
\ @brief RCC AHB2 enable register
\ Address offset: 0x254
\ Reset value: 0x00001000
\

$00001000 constant RCC_S_RCC_AHB2ENR_RAMCFGEN                       \ RAMCFG enable
$00010000 constant RCC_S_RCC_AHB2ENR_MDF1EN                         \ MDF1 enable
$00020000 constant RCC_S_RCC_AHB2ENR_ADF1EN                         \ ADF enable


\
\ @brief RCC AHB3 enable register
\ Address offset: 0x258
\ Reset value: 0x00004600
\

$00000001 constant RCC_S_RCC_AHB3ENR_RNGEN                          \ RNG enable
$00000002 constant RCC_S_RCC_AHB3ENR_HASHEN                         \ HASH enable
$00000004 constant RCC_S_RCC_AHB3ENR_CRYPEN                         \ CRYP enable
$00000010 constant RCC_S_RCC_AHB3ENR_SAESEN                         \ SAES enable
$00000100 constant RCC_S_RCC_AHB3ENR_PKAEN                          \ PKA enable
$00000200 constant RCC_S_RCC_AHB3ENR_RIFSCEN                        \ RIFSC enable
$00000400 constant RCC_S_RCC_AHB3ENR_IACEN                          \ IAC enable
$00004000 constant RCC_S_RCC_AHB3ENR_RISAFEN                        \ RISAF enable


\
\ @brief RCC AHB4 enable register
\ Address offset: 0x25C
\ Reset value: 0x00040000
\

$00000001 constant RCC_S_RCC_AHB4ENR_GPIOAEN                        \ GPIOA enable
$00000002 constant RCC_S_RCC_AHB4ENR_GPIOBEN                        \ GPIOB enable
$00000004 constant RCC_S_RCC_AHB4ENR_GPIOCEN                        \ GPIOC enable
$00000008 constant RCC_S_RCC_AHB4ENR_GPIODEN                        \ GPIOD enable
$00000010 constant RCC_S_RCC_AHB4ENR_GPIOEEN                        \ GPIOE enable
$00000020 constant RCC_S_RCC_AHB4ENR_GPIOFEN                        \ GPIOF enable
$00000040 constant RCC_S_RCC_AHB4ENR_GPIOGEN                        \ GPIOG enable
$00000080 constant RCC_S_RCC_AHB4ENR_GPIOHEN                        \ GPIOH enable
$00002000 constant RCC_S_RCC_AHB4ENR_GPIONEN                        \ GPION enable
$00004000 constant RCC_S_RCC_AHB4ENR_GPIOOEN                        \ GPIOO enable
$00008000 constant RCC_S_RCC_AHB4ENR_GPIOPEN                        \ GPIOP enable
$00010000 constant RCC_S_RCC_AHB4ENR_GPIOQEN                        \ GPIOQ enable
$00040000 constant RCC_S_RCC_AHB4ENR_PWREN                          \ PWR enable
$00080000 constant RCC_S_RCC_AHB4ENR_CRCEN                          \ CRC enable


\
\ @brief RCC AHB5 enable register
\ Address offset: 0x260
\ Reset value: 0x00000000
\

$00000001 constant RCC_S_RCC_AHB5ENR_HPDMA1EN                       \ HPDMA1 enable
$00000002 constant RCC_S_RCC_AHB5ENR_DMA2DEN                        \ DMA2D enable
$00000008 constant RCC_S_RCC_AHB5ENR_JPEGEN                         \ JPEG enable
$00000010 constant RCC_S_RCC_AHB5ENR_FMCEN                          \ FMC enable
$00000020 constant RCC_S_RCC_AHB5ENR_XSPI1EN                        \ XSPI1 enable
$00000040 constant RCC_S_RCC_AHB5ENR_PSSIEN                         \ PSSI enable
$00000080 constant RCC_S_RCC_AHB5ENR_SDMMC2EN                       \ SDMMC2 enable
$00000100 constant RCC_S_RCC_AHB5ENR_SDMMC1EN                       \ SDMMC1 enable
$00001000 constant RCC_S_RCC_AHB5ENR_XSPI2EN                        \ XSPI2 enable
$00002000 constant RCC_S_RCC_AHB5ENR_XSPIMEN                        \ XSPIM enable
$00004000 constant RCC_S_RCC_AHB5ENR_MCE1EN                         \ MCE1 enable
$00008000 constant RCC_S_RCC_AHB5ENR_MCE2EN                         \ MCE2 enable
$00010000 constant RCC_S_RCC_AHB5ENR_MCE3EN                         \ MCE3 enable
$00020000 constant RCC_S_RCC_AHB5ENR_XSPI3EN                        \ XSPI3 enable
$00040000 constant RCC_S_RCC_AHB5ENR_MCE4EN                         \ MCE4 enable
$00080000 constant RCC_S_RCC_AHB5ENR_GFXMMUEN                       \ GFXMMU enable
$00100000 constant RCC_S_RCC_AHB5ENR_GPUEN                          \ GPU enable
$00400000 constant RCC_S_RCC_AHB5ENR_ETH1MACEN                      \ ETH1MAC enable
$00800000 constant RCC_S_RCC_AHB5ENR_ETH1TXEN                       \ ETH1TX enable
$01000000 constant RCC_S_RCC_AHB5ENR_ETH1RXEN                       \ ETH1RX enable
$02000000 constant RCC_S_RCC_AHB5ENR_ETH1EN                         \ ETH1 enable
$04000000 constant RCC_S_RCC_AHB5ENR_OTG1EN                         \ OTG1 enable
$08000000 constant RCC_S_RCC_AHB5ENR_OTGPHY1EN                      \ OTGPHY1 enable
$10000000 constant RCC_S_RCC_AHB5ENR_OTGPHY2EN                      \ OTGPHY2 enable
$20000000 constant RCC_S_RCC_AHB5ENR_OTG2EN                         \ OTG2 enable
$40000000 constant RCC_S_RCC_AHB5ENR_NPUCACHEEN                     \ NPUCACHE enable
$80000000 constant RCC_S_RCC_AHB5ENR_NPUEN                          \ NPU enable


\
\ @brief RCC APB1L enable register
\ Address offset: 0x264
\ Reset value: 0x00000000
\

$00000001 constant RCC_S_RCC_APB1LENR_TIM2EN                        \ TIM2 enable
$00000002 constant RCC_S_RCC_APB1LENR_TIM3EN                        \ TIM3 enable
$00000004 constant RCC_S_RCC_APB1LENR_TIM4EN                        \ TIM4 enable
$00000008 constant RCC_S_RCC_APB1LENR_TIM5EN                        \ TIM5 enable
$00000010 constant RCC_S_RCC_APB1LENR_TIM6EN                        \ TIM6 enable
$00000020 constant RCC_S_RCC_APB1LENR_TIM7EN                        \ TIM7 enable
$00000040 constant RCC_S_RCC_APB1LENR_TIM12EN                       \ TIM12 enable
$00000080 constant RCC_S_RCC_APB1LENR_TIM13EN                       \ TIM13 enable
$00000100 constant RCC_S_RCC_APB1LENR_TIM14EN                       \ TIM14 enable
$00000200 constant RCC_S_RCC_APB1LENR_LPTIM1EN                      \ LPTIM1 enable
$00000800 constant RCC_S_RCC_APB1LENR_WWDGEN                        \ WWDG enable
$00001000 constant RCC_S_RCC_APB1LENR_TIM10EN                       \ TIM10 enable
$00002000 constant RCC_S_RCC_APB1LENR_TIM11EN                       \ TIM11 enable
$00004000 constant RCC_S_RCC_APB1LENR_SPI2EN                        \ SPI2 enable
$00008000 constant RCC_S_RCC_APB1LENR_SPI3EN                        \ SPI3 enable
$00010000 constant RCC_S_RCC_APB1LENR_SPDIFRX1EN                    \ SPDIFRX1 enable
$00020000 constant RCC_S_RCC_APB1LENR_USART2EN                      \ USART2 enable
$00040000 constant RCC_S_RCC_APB1LENR_USART3EN                      \ USART3 enable
$00080000 constant RCC_S_RCC_APB1LENR_UART4EN                       \ UART4 enable
$00100000 constant RCC_S_RCC_APB1LENR_UART5EN                       \ UART5 enable
$00200000 constant RCC_S_RCC_APB1LENR_I2C1EN                        \ I2C1 enable
$00400000 constant RCC_S_RCC_APB1LENR_I2C2EN                        \ I2C2 enable
$00800000 constant RCC_S_RCC_APB1LENR_I2C3EN                        \ I2C3 enable
$01000000 constant RCC_S_RCC_APB1LENR_I3C1EN                        \ I3C1 enable
$02000000 constant RCC_S_RCC_APB1LENR_I3C2EN                        \ I3C2 enable
$40000000 constant RCC_S_RCC_APB1LENR_UART7EN                       \ UART7 enable
$80000000 constant RCC_S_RCC_APB1LENR_UART8EN                       \ UART8 enable


\
\ @brief RCC APB1H enable register
\ Address offset: 0x268
\ Reset value: 0x00000000
\

$00000020 constant RCC_S_RCC_APB1HENR_MDIOSEN                       \ MDIOS enable
$00000100 constant RCC_S_RCC_APB1HENR_FDCANEN                       \ FDCAN enable
$00040000 constant RCC_S_RCC_APB1HENR_UCPD1EN                       \ UCPD1 enable


\
\ @brief RCC APB2 enable register
\ Address offset: 0x26C
\ Reset value: 0x00000000
\

$00000001 constant RCC_S_RCC_APB2ENR_TIM1EN                         \ TIM1 enable
$00000002 constant RCC_S_RCC_APB2ENR_TIM8EN                         \ TIM8 enable
$00000010 constant RCC_S_RCC_APB2ENR_USART1EN                       \ USART1 enable
$00000020 constant RCC_S_RCC_APB2ENR_USART6EN                       \ USART6 enable
$00000040 constant RCC_S_RCC_APB2ENR_UART9EN                        \ UART9 enable
$00000080 constant RCC_S_RCC_APB2ENR_USART10EN                      \ USART10 enable
$00001000 constant RCC_S_RCC_APB2ENR_SPI1EN                         \ SPI1 enable
$00002000 constant RCC_S_RCC_APB2ENR_SPI4EN                         \ SPI4 enable
$00008000 constant RCC_S_RCC_APB2ENR_TIM18EN                        \ TIM18 enable
$00010000 constant RCC_S_RCC_APB2ENR_TIM15EN                        \ TIM15 enable
$00020000 constant RCC_S_RCC_APB2ENR_TIM16EN                        \ TIM16 enable
$00040000 constant RCC_S_RCC_APB2ENR_TIM17EN                        \ TIM17 enable
$00080000 constant RCC_S_RCC_APB2ENR_TIM9EN                         \ TIM9 enable
$00100000 constant RCC_S_RCC_APB2ENR_SPI5EN                         \ SPI5 enable
$00200000 constant RCC_S_RCC_APB2ENR_SAI1EN                         \ SAI1 enable
$00400000 constant RCC_S_RCC_APB2ENR_SAI2EN                         \ SAI2 enable


\
\ @brief RCC APB3 enable register
\ Address offset: 0x270
\ Reset value: 0x00000000
\

$00000004 constant RCC_S_RCC_APB3ENR_DFTEN                          \ DFT enable


\
\ @brief RCC APB4L enable register
\ Address offset: 0x274
\ Reset value: 0x00000000
\

$00000004 constant RCC_S_RCC_APB4LENR_HDPEN                         \ HDP enable
$00000008 constant RCC_S_RCC_APB4LENR_LPUART1EN                     \ LPUART1 enable
$00000020 constant RCC_S_RCC_APB4LENR_SPI6EN                        \ SPI6 enable
$00000080 constant RCC_S_RCC_APB4LENR_I2C4EN                        \ I2C4 enable
$00000200 constant RCC_S_RCC_APB4LENR_LPTIM2EN                      \ LPTIM2 enable
$00000400 constant RCC_S_RCC_APB4LENR_LPTIM3EN                      \ LPTIM3 enable
$00000800 constant RCC_S_RCC_APB4LENR_LPTIM4EN                      \ LPTIM4 enable
$00001000 constant RCC_S_RCC_APB4LENR_LPTIM5EN                      \ LPTIM5 enable
$00008000 constant RCC_S_RCC_APB4LENR_VREFBUFEN                     \ VREFBUF enable
$00010000 constant RCC_S_RCC_APB4LENR_RTCEN                         \ RTC enable
$00020000 constant RCC_S_RCC_APB4LENR_RTCAPBEN                      \ RTCAPB enable
$00400000 constant RCC_S_RCC_APB4LENR_R2GRETEN                      \ R2GRET enable
$00800000 constant RCC_S_RCC_APB4LENR_R2GNPUEN                      \ R2GNPU enable
$80000000 constant RCC_S_RCC_APB4LENR_SERFEN                        \ SERF enable


\
\ @brief RCC APB4H enable register
\ Address offset: 0x278
\ Reset value: 0x00000002
\

$00000001 constant RCC_S_RCC_APB4HENR_SYSCFGEN                      \ SYSCFG enable
$00000002 constant RCC_S_RCC_APB4HENR_BSECEN                        \ BSEC enable
$00000004 constant RCC_S_RCC_APB4HENR_DTSEN                         \ DTS enable
$00000010 constant RCC_S_RCC_APB4HENR_BUSPERFMEN                    \ BUSPERFM enable


\
\ @brief RCC APB5 enable register
\ Address offset: 0x27C
\ Reset value: 0x00000000
\

$00000002 constant RCC_S_RCC_APB5ENR_LTDCEN                         \ LTDC enable
$00000004 constant RCC_S_RCC_APB5ENR_DCMIPPEN                       \ DCMIPP enable
$00000010 constant RCC_S_RCC_APB5ENR_GFXTIMEN                       \ GFXTIM enable
$00000020 constant RCC_S_RCC_APB5ENR_VENCEN                         \ VENC enable
$00000040 constant RCC_S_RCC_APB5ENR_CSIEN                          \ CSI enable


\
\ @brief RCC dividers Sleep enable register
\ Address offset: 0x280
\ Reset value: 0x00000000
\

$00000001 constant RCC_S_RCC_DIVLPENR_IC1LPEN                       \ IC1 sleep enable
$00000002 constant RCC_S_RCC_DIVLPENR_IC2LPEN                       \ IC2 sleep enable
$00000004 constant RCC_S_RCC_DIVLPENR_IC3LPEN                       \ IC3 sleep enable
$00000008 constant RCC_S_RCC_DIVLPENR_IC4LPEN                       \ IC4 sleep enable
$00000010 constant RCC_S_RCC_DIVLPENR_IC5LPEN                       \ IC5 sleep enable
$00000020 constant RCC_S_RCC_DIVLPENR_IC6LPEN                       \ IC6 sleep enable
$00000040 constant RCC_S_RCC_DIVLPENR_IC7LPEN                       \ IC7 sleep enable
$00000080 constant RCC_S_RCC_DIVLPENR_IC8LPEN                       \ IC8 sleep enable
$00000100 constant RCC_S_RCC_DIVLPENR_IC9LPEN                       \ IC9 sleep enable
$00000200 constant RCC_S_RCC_DIVLPENR_IC10LPEN                      \ IC10 sleep enable
$00000400 constant RCC_S_RCC_DIVLPENR_IC11LPEN                      \ IC11 sleep enable
$00000800 constant RCC_S_RCC_DIVLPENR_IC12LPEN                      \ IC12 sleep enable
$00001000 constant RCC_S_RCC_DIVLPENR_IC13LPEN                      \ IC13 sleep enable
$00002000 constant RCC_S_RCC_DIVLPENR_IC14LPEN                      \ IC14 sleep enable
$00004000 constant RCC_S_RCC_DIVLPENR_IC15LPEN                      \ IC15 sleep enable
$00008000 constant RCC_S_RCC_DIVLPENR_IC16LPEN                      \ IC16 sleep enable
$00010000 constant RCC_S_RCC_DIVLPENR_IC17LPEN                      \ IC17 sleep enable
$00020000 constant RCC_S_RCC_DIVLPENR_IC18LPEN                      \ IC18 sleep enable
$00040000 constant RCC_S_RCC_DIVLPENR_IC19LPEN                      \ IC19 sleep enable
$00080000 constant RCC_S_RCC_DIVLPENR_IC20LPEN                      \ IC20 sleep enable


\
\ @brief RCC SoC buses Sleep enable register
\ Address offset: 0x284
\ Reset value: 0x00000003
\

$00000001 constant RCC_S_RCC_BUSLPENR_ACLKNLPEN                     \ ACLKN sleep enable
$00000002 constant RCC_S_RCC_BUSLPENR_ACLKNCLPEN                    \ ACLKNC sleep enable
$00000004 constant RCC_S_RCC_BUSLPENR_AHBMLPEN                      \ AHBM sleep enable
$00000008 constant RCC_S_RCC_BUSLPENR_AHB1LPEN                      \ AHB1 sleep enable
$00000010 constant RCC_S_RCC_BUSLPENR_AHB2LPEN                      \ AHB2 sleep enable
$00000020 constant RCC_S_RCC_BUSLPENR_AHB3LPEN                      \ AHB3 sleep enable
$00000040 constant RCC_S_RCC_BUSLPENR_AHB4LPEN                      \ AHB4 sleep enable
$00000080 constant RCC_S_RCC_BUSLPENR_AHB5LPEN                      \ AHB5 sleep enable
$00000100 constant RCC_S_RCC_BUSLPENR_APB1LPEN                      \ APB1 sleep enable
$00000200 constant RCC_S_RCC_BUSLPENR_APB2LPEN                      \ APB2 sleep enable
$00000400 constant RCC_S_RCC_BUSLPENR_APB3LPEN                      \ APB3 sleep enable
$00000800 constant RCC_S_RCC_BUSLPENR_APB4LPEN                      \ APB4 sleep enable
$00001000 constant RCC_S_RCC_BUSLPENR_APB5LPEN                      \ APB5 sleep enable


\
\ @brief RCC miscellaneous configurations Sleep enable register
\ Address offset: 0x288
\ Reset value: 0x00000000
\

$00000001 constant RCC_S_RCC_MISCLPENR_DBGLPEN                      \ DBG sleep enable
$00000008 constant RCC_S_RCC_MISCLPENR_XSPIPHYCOMPLPEN              \ XSPIPHYCOMP sleep enable
$00000040 constant RCC_S_RCC_MISCLPENR_PERLPEN                      \ PER sleep enable


\
\ @brief RCC memory Sleep enable register
\ Address offset: 0x28C
\ Reset value: 0x00000000
\

$00000001 constant RCC_S_RCC_MEMLPENR_AXISRAM3LPEN                  \ AXISRAM3 sleep enable
$00000002 constant RCC_S_RCC_MEMLPENR_AXISRAM4LPEN                  \ AXISRAM4 sleep enable
$00000004 constant RCC_S_RCC_MEMLPENR_AXISRAM5LPEN                  \ AXISRAM5 sleep enable
$00000008 constant RCC_S_RCC_MEMLPENR_AXISRAM6LPEN                  \ AXISRAM6 sleep enable
$00000010 constant RCC_S_RCC_MEMLPENR_AHBSRAM1LPEN                  \ AHBSRAM1 sleep enable
$00000020 constant RCC_S_RCC_MEMLPENR_AHBSRAM2LPEN                  \ AHBSRAM2 sleep enable
$00000040 constant RCC_S_RCC_MEMLPENR_BKPSRAMLPEN                   \ BKPSRAM sleep enable
$00000080 constant RCC_S_RCC_MEMLPENR_AXISRAM1LPEN                  \ AXISRAM1 sleep enable
$00000100 constant RCC_S_RCC_MEMLPENR_AXISRAM2LPEN                  \ AXISRAM2 sleep enable
$00000200 constant RCC_S_RCC_MEMLPENR_FLEXRAMLPEN                   \ FLEXRAM sleep enable
$00000400 constant RCC_S_RCC_MEMLPENR_NPUCACHERAMLPEN               \ NPUCACHERAM sleep enable
$00000800 constant RCC_S_RCC_MEMLPENR_VENCRAMLPEN                   \ VENCRAM sleep enable
$00001000 constant RCC_S_RCC_MEMLPENR_BOOTROMLPEN                   \ BOOTROM sleep enable


\
\ @brief RCC AHB1 Sleep enable register
\ Address offset: 0x290
\ Reset value: 0x00000000
\

$00000010 constant RCC_S_RCC_AHB1LPENR_GPDMA1LPEN                   \ GPDMA1 sleep enable
$00000020 constant RCC_S_RCC_AHB1LPENR_ADC12LPEN                    \ ADC12 sleep enable


\
\ @brief RCC AHB2 Sleep enable register
\ Address offset: 0x294
\ Reset value: 0x00000000
\

$00001000 constant RCC_S_RCC_AHB2LPENR_RAMCFGLPEN                   \ RAMCFG sleep enable
$00010000 constant RCC_S_RCC_AHB2LPENR_MDF1LPEN                     \ MDF1 sleep enable
$00020000 constant RCC_S_RCC_AHB2LPENR_ADF1LPEN                     \ ADF1 sleep enable


\
\ @brief RCC AHB3 Sleep enable register
\ Address offset: 0x298
\ Reset value: 0x00000400
\

$00000001 constant RCC_S_RCC_AHB3LPENR_RNGLPEN                      \ RNG sleep enable
$00000002 constant RCC_S_RCC_AHB3LPENR_HASHLPEN                     \ HASH sleep enable
$00000004 constant RCC_S_RCC_AHB3LPENR_CRYPLPEN                     \ CRYP sleep enable
$00000010 constant RCC_S_RCC_AHB3LPENR_SAESLPEN                     \ SAES sleep enable
$00000100 constant RCC_S_RCC_AHB3LPENR_PKALPEN                      \ PKA sleep enable
$00000200 constant RCC_S_RCC_AHB3LPENR_RIFSCLPEN                    \ RIFSC sleep enable
$00000400 constant RCC_S_RCC_AHB3LPENR_IACLPEN                      \ IAC sleep enable
$00004000 constant RCC_S_RCC_AHB3LPENR_RISAFLPEN                    \ RISAF sleep enable


\
\ @brief RCC AHB4 Sleep enable register
\ Address offset: 0x29C
\ Reset value: 0x00040000
\

$00000001 constant RCC_S_RCC_AHB4LPENR_GPIOALPEN                    \ GPIOA sleep enable
$00000002 constant RCC_S_RCC_AHB4LPENR_GPIOBLPEN                    \ GPIOB sleep enable
$00000004 constant RCC_S_RCC_AHB4LPENR_GPIOCLPEN                    \ GPIOC sleep enable
$00000008 constant RCC_S_RCC_AHB4LPENR_GPIODLPEN                    \ GPIOD sleep enable
$00000010 constant RCC_S_RCC_AHB4LPENR_GPIOELPEN                    \ GPIOE sleep enable
$00000020 constant RCC_S_RCC_AHB4LPENR_GPIOFLPEN                    \ GPIOF sleep enable
$00000040 constant RCC_S_RCC_AHB4LPENR_GPIOGLPEN                    \ GPIOG sleep enable
$00000080 constant RCC_S_RCC_AHB4LPENR_GPIOHLPEN                    \ GPIOH sleep enable
$00002000 constant RCC_S_RCC_AHB4LPENR_GPIONLPEN                    \ GPION sleep enable
$00004000 constant RCC_S_RCC_AHB4LPENR_GPIOOLPEN                    \ GPIOO sleep enable
$00008000 constant RCC_S_RCC_AHB4LPENR_GPIOPLPEN                    \ GPIOP sleep enable
$00010000 constant RCC_S_RCC_AHB4LPENR_GPIOQLPEN                    \ GPIOQ sleep enable
$00040000 constant RCC_S_RCC_AHB4LPENR_PWRLPEN                      \ PWR sleep enable
$00080000 constant RCC_S_RCC_AHB4LPENR_CRCLPEN                      \ CRC sleep enable


\
\ @brief RCC AHB5 Sleep enable register
\ Address offset: 0x2A0
\ Reset value: 0x00000000
\

$00000001 constant RCC_S_RCC_AHB5LPENR_HPDMA1LPEN                   \ HPDMA1 sleep enable
$00000002 constant RCC_S_RCC_AHB5LPENR_DMA2DLPEN                    \ DMA2D sleep enable
$00000008 constant RCC_S_RCC_AHB5LPENR_JPEGLPEN                     \ JPEG sleep enable
$00000010 constant RCC_S_RCC_AHB5LPENR_FMCLPEN                      \ FMC sleep enable
$00000020 constant RCC_S_RCC_AHB5LPENR_XSPI1LPEN                    \ XSPI1 sleep enable
$00000040 constant RCC_S_RCC_AHB5LPENR_PSSILPEN                     \ PSSI sleep enable
$00000080 constant RCC_S_RCC_AHB5LPENR_SDMMC2LPEN                   \ SDMMC2 sleep enable
$00000100 constant RCC_S_RCC_AHB5LPENR_SDMMC1LPEN                   \ SDMMC1 sleep enable
$00001000 constant RCC_S_RCC_AHB5LPENR_XSPI2LPEN                    \ XSPI2 sleep enable
$00002000 constant RCC_S_RCC_AHB5LPENR_XSPIMLPEN                    \ XSPIM sleep enable
$00004000 constant RCC_S_RCC_AHB5LPENR_MCE1LPEN                     \ MCE1 sleep enable
$00008000 constant RCC_S_RCC_AHB5LPENR_MCE2LPEN                     \ MCE2 sleep enable
$00010000 constant RCC_S_RCC_AHB5LPENR_MCE3LPEN                     \ MCE3 sleep enable
$00020000 constant RCC_S_RCC_AHB5LPENR_XSPI3LPEN                    \ XSPI3 sleep enable
$00040000 constant RCC_S_RCC_AHB5LPENR_MCE4LPEN                     \ MCE4 sleep enable
$00080000 constant RCC_S_RCC_AHB5LPENR_GFXMMULPEN                   \ GFXMMU sleep enable
$00100000 constant RCC_S_RCC_AHB5LPENR_GPULPEN                      \ GPU sleep enable
$00400000 constant RCC_S_RCC_AHB5LPENR_ETH1MACLPEN                  \ ETH1MAC sleep enable
$00800000 constant RCC_S_RCC_AHB5LPENR_ETH1TXLPEN                   \ ETH1TX sleep enable
$01000000 constant RCC_S_RCC_AHB5LPENR_ETH1RXLPEN                   \ ETH1RX sleep enable
$02000000 constant RCC_S_RCC_AHB5LPENR_ETH1LPEN                     \ ETH1 sleep enable
$04000000 constant RCC_S_RCC_AHB5LPENR_OTG1LPEN                     \ OTG1 sleep enable
$08000000 constant RCC_S_RCC_AHB5LPENR_OTGPHY1LPEN                  \ OTGPHY1 sleep enable
$10000000 constant RCC_S_RCC_AHB5LPENR_OTGPHY2LPEN                  \ OTGPHY2 sleep enable
$20000000 constant RCC_S_RCC_AHB5LPENR_OTG2LPEN                     \ OTG2 sleep enable
$40000000 constant RCC_S_RCC_AHB5LPENR_NPUCACHELPEN                 \ NPUCACHE sleep enable
$80000000 constant RCC_S_RCC_AHB5LPENR_NPULPEN                      \ NPU sleep enable


\
\ @brief RCC APB1L Sleep enable register
\ Address offset: 0x2A4
\ Reset value: 0x00000000
\

$00000001 constant RCC_S_RCC_APB1LLPENR_TIM2LPEN                    \ TIM2 sleep enable
$00000002 constant RCC_S_RCC_APB1LLPENR_TIM3LPEN                    \ TIM3 sleep enable
$00000004 constant RCC_S_RCC_APB1LLPENR_TIM4LPEN                    \ TIM4 sleep enable
$00000008 constant RCC_S_RCC_APB1LLPENR_TIM5LPEN                    \ TIM5 sleep enable
$00000010 constant RCC_S_RCC_APB1LLPENR_TIM6LPEN                    \ TIM6 sleep enable
$00000020 constant RCC_S_RCC_APB1LLPENR_TIM7LPEN                    \ TIM7 sleep enable
$00000040 constant RCC_S_RCC_APB1LLPENR_TIM12LPEN                   \ TIM12 sleep enable
$00000080 constant RCC_S_RCC_APB1LLPENR_TIM13LPEN                   \ TIM13 sleep enable
$00000100 constant RCC_S_RCC_APB1LLPENR_TIM14LPEN                   \ TIM14 sleep enable
$00000200 constant RCC_S_RCC_APB1LLPENR_LPTIM1LPEN                  \ LPTIM1 sleep enable
$00000800 constant RCC_S_RCC_APB1LLPENR_WWDGLPEN                    \ WWDG sleep enable
$00001000 constant RCC_S_RCC_APB1LLPENR_TIM10LPEN                   \ TIM10 sleep enable
$00002000 constant RCC_S_RCC_APB1LLPENR_TIM11LPEN                   \ TIM11 sleep enable
$00004000 constant RCC_S_RCC_APB1LLPENR_SPI2LPEN                    \ SPI2 sleep enable
$00008000 constant RCC_S_RCC_APB1LLPENR_SPI3LPEN                    \ SPI3 sleep enable
$00010000 constant RCC_S_RCC_APB1LLPENR_SPDIFRX1LPEN                \ SPDIFRX1 sleep enable
$00020000 constant RCC_S_RCC_APB1LLPENR_USART2LPEN                  \ USART2 sleep enable
$00040000 constant RCC_S_RCC_APB1LLPENR_USART3LPEN                  \ USART3 sleep enable
$00080000 constant RCC_S_RCC_APB1LLPENR_UART4LPEN                   \ UART4 sleep enable
$00100000 constant RCC_S_RCC_APB1LLPENR_UART5LPEN                   \ UART5 sleep enable
$00200000 constant RCC_S_RCC_APB1LLPENR_I2C1LPEN                    \ I2C1 sleep enable
$00400000 constant RCC_S_RCC_APB1LLPENR_I2C2LPEN                    \ I2C2 sleep enable
$00800000 constant RCC_S_RCC_APB1LLPENR_I2C3LPEN                    \ I2C3 sleep enable
$01000000 constant RCC_S_RCC_APB1LLPENR_I3C1LPEN                    \ I3C1 sleep enable
$02000000 constant RCC_S_RCC_APB1LLPENR_I3C2LPEN                    \ I3C2 sleep enable
$40000000 constant RCC_S_RCC_APB1LLPENR_UART7LPEN                   \ UART7 sleep enable
$80000000 constant RCC_S_RCC_APB1LLPENR_UART8LPEN                   \ UART8 sleep enable


\
\ @brief RCC APB1H Sleep enable register
\ Address offset: 0x2A8
\ Reset value: 0x00000000
\

$00000020 constant RCC_S_RCC_APB1HLPENR_MDIOSLPEN                   \ MDIOS sleep enable
$00000100 constant RCC_S_RCC_APB1HLPENR_FDCANLPEN                   \ FDCAN sleep enable
$00040000 constant RCC_S_RCC_APB1HLPENR_UCPD1LPEN                   \ UCPD1 sleep enable


\
\ @brief RCC APB2 Sleep enable register
\ Address offset: 0x2AC
\ Reset value: 0x00000000
\

$00000001 constant RCC_S_RCC_APB2LPENR_TIM1LPEN                     \ TIM1 sleep enable
$00000002 constant RCC_S_RCC_APB2LPENR_TIM8LPEN                     \ TIM8 sleep enable
$00000010 constant RCC_S_RCC_APB2LPENR_USART1LPEN                   \ USART1 sleep enable
$00000020 constant RCC_S_RCC_APB2LPENR_USART6LPEN                   \ USART6 sleep enable
$00000040 constant RCC_S_RCC_APB2LPENR_UART9LPEN                    \ UART9 sleep enable
$00000080 constant RCC_S_RCC_APB2LPENR_USART10LPEN                  \ USART10 sleep enable
$00001000 constant RCC_S_RCC_APB2LPENR_SPI1LPEN                     \ SPI1 sleep enable
$00002000 constant RCC_S_RCC_APB2LPENR_SPI4LPEN                     \ SPI4 sleep enable
$00008000 constant RCC_S_RCC_APB2LPENR_TIM18LPEN                    \ TIM18 sleep enable
$00010000 constant RCC_S_RCC_APB2LPENR_TIM15LPEN                    \ TIM15 sleep enable
$00020000 constant RCC_S_RCC_APB2LPENR_TIM16LPEN                    \ TIM16 sleep enable
$00040000 constant RCC_S_RCC_APB2LPENR_TIM17LPEN                    \ TIM17 sleep enable
$00080000 constant RCC_S_RCC_APB2LPENR_TIM9LPEN                     \ TIM9 sleep enable
$00100000 constant RCC_S_RCC_APB2LPENR_SPI5LPEN                     \ SPI5 sleep enable
$00200000 constant RCC_S_RCC_APB2LPENR_SAI1LPEN                     \ SAI1 sleep enable
$00400000 constant RCC_S_RCC_APB2LPENR_SAI2LPEN                     \ SAI2 sleep enable


\
\ @brief RCC APB3 Sleep enable register
\ Address offset: 0x2B0
\ Reset value: 0x00000000
\

$00000004 constant RCC_S_RCC_APB3LPENR_DFTLPEN                      \ DFT sleep enable


\
\ @brief RCC APB4L Sleep enable register
\ Address offset: 0x2B4
\ Reset value: 0x00000000
\

$00000004 constant RCC_S_RCC_APB4LLPENR_HDPLPEN                     \ HDP sleep enable
$00000008 constant RCC_S_RCC_APB4LLPENR_LPUART1LPEN                 \ LPUART1 sleep enable
$00000020 constant RCC_S_RCC_APB4LLPENR_SPI6LPEN                    \ SPI6 sleep enable
$00000080 constant RCC_S_RCC_APB4LLPENR_I2C4LPEN                    \ I2C4 sleep enable
$00000200 constant RCC_S_RCC_APB4LLPENR_LPTIM2LPEN                  \ LPTIM2 sleep enable
$00000400 constant RCC_S_RCC_APB4LLPENR_LPTIM3LPEN                  \ LPTIM3 sleep enable
$00000800 constant RCC_S_RCC_APB4LLPENR_LPTIM4LPEN                  \ LPTIM4 sleep enable
$00001000 constant RCC_S_RCC_APB4LLPENR_LPTIM5LPEN                  \ LPTIM5 sleep enable
$00008000 constant RCC_S_RCC_APB4LLPENR_VREFBUFLPEN                 \ VREFBUF sleep enable
$00010000 constant RCC_S_RCC_APB4LLPENR_RTCLPEN                     \ RTC sleep enable
$00020000 constant RCC_S_RCC_APB4LLPENR_RTCAPBLPEN                  \ RTCAPB sleep enable
$00400000 constant RCC_S_RCC_APB4LLPENR_R2GRETLPEN                  \ R2GRET sleep enable
$00800000 constant RCC_S_RCC_APB4LLPENR_R2GNPULPEN                  \ R2GNPU sleep enable
$80000000 constant RCC_S_RCC_APB4LLPENR_SERFLPEN                    \ SERF sleep enable


\
\ @brief RCC APB4H Sleep enable register
\ Address offset: 0x2B8
\ Reset value: 0x00000002
\

$00000001 constant RCC_S_RCC_APB4HLPENR_SYSCFGLPEN                  \ SYSCFG sleep enable
$00000002 constant RCC_S_RCC_APB4HLPENR_BSECLPEN                    \ BSEC sleep enable
$00000004 constant RCC_S_RCC_APB4HLPENR_DTSLPEN                     \ DTS sleep enable
$00000010 constant RCC_S_RCC_APB4HLPENR_BUSPERFMLPEN                \ BUSPERFM sleep enable


\
\ @brief RCC APB5 Sleep enable register
\ Address offset: 0x2BC
\ Reset value: 0x00000000
\

$00000002 constant RCC_S_RCC_APB5LPENR_LTDCLPEN                     \ LTDC sleep enable
$00000004 constant RCC_S_RCC_APB5LPENR_DCMIPPLPEN                   \ DCMIPP sleep enable
$00000010 constant RCC_S_RCC_APB5LPENR_GFXTIMLPEN                   \ GFXTIM sleep enable
$00000020 constant RCC_S_RCC_APB5LPENR_VENCLPEN                     \ VENC sleep enable
$00000040 constant RCC_S_RCC_APB5LPENR_CSILPEN                      \ CSI sleep enable


\
\ @brief RCC APB5 Sleep enable register
\ Address offset: 0x44C
\ Reset value: 0x00060000
\

$001f0000 constant RCC_S_RCC_RDCR_MRD                               \ BOOTROM sleep enable
$0f000000 constant RCC_S_RCC_RDCR_EADLY                             \ BOOTROM sleep enable


\
\ @brief RCC oscillator secure configuration register0
\ Address offset: 0x780
\ Reset value: 0x00000000
\

$00000001 constant RCC_S_RCC_SECCFGR0_LSISEC                        \ Defines the secure protection of the LSI oscillator configuration bits.
$00000002 constant RCC_S_RCC_SECCFGR0_LSESEC                        \ Defines the secure protection of the LSE oscillator configuration bits.
$00000004 constant RCC_S_RCC_SECCFGR0_MSISEC                        \ Defines the secure protection of the MSI oscillator configuration bits.
$00000008 constant RCC_S_RCC_SECCFGR0_HSISEC                        \ Defines the secure protection of the HSI oscillator configuration bits.
$00000010 constant RCC_S_RCC_SECCFGR0_HSESEC                        \ Defines the secure protection of the HSE oscillator configuration bits.


\
\ @brief RCC oscillator privilege configuration register0
\ Address offset: 0x784
\ Reset value: 0x00000000
\

$00000001 constant RCC_S_RCC_PRIVCFGR0_LSIPV                        \ Defines the privilege protection of the LSI oscillator configuration bits.
$00000002 constant RCC_S_RCC_PRIVCFGR0_LSEPV                        \ Defines the privilege protection of the LSE oscillator configuration bits.
$00000004 constant RCC_S_RCC_PRIVCFGR0_MSIPV                        \ Defines the privilege protection of the MSI oscillator configuration bits.
$00000008 constant RCC_S_RCC_PRIVCFGR0_HSIPV                        \ Defines the privilege protection of the HSI oscillator configuration bits.
$00000010 constant RCC_S_RCC_PRIVCFGR0_HSEPV                        \ Defines the privilege protection of the HSE oscillator configuration bits.


\
\ @brief RCC oscillator lock configuration register0
\ Address offset: 0x788
\ Reset value: 0x00000000
\

$00000001 constant RCC_S_RCC_LOCKCFGR0_LSILOCK                      \ Defines the lock protection of the LSI oscillator configuration bits.
$00000002 constant RCC_S_RCC_LOCKCFGR0_LSELOCK                      \ Defines the lock protection of the LSE oscillator configuration bits.
$00000004 constant RCC_S_RCC_LOCKCFGR0_MSILOCK                      \ Defines the lock protection of the MSI oscillator configuration bits.
$00000008 constant RCC_S_RCC_LOCKCFGR0_HSILOCK                      \ Defines the lock protection of the HSI oscillator configuration bits.
$00000010 constant RCC_S_RCC_LOCKCFGR0_HSELOCK                      \ Defines the lock protection of the HSE oscillator configuration bits.


\
\ @brief RCC oscillator public configuration register0
\ Address offset: 0x78C
\ Reset value: 0x00000000
\

$00000001 constant RCC_S_RCC_PUBCFGR0_LSIPUB                        \ Defines the public protection of the LSI oscillator configuration bits.
$00000002 constant RCC_S_RCC_PUBCFGR0_LSEPUB                        \ Defines the public protection of the LSE oscillator configuration bits.
$00000004 constant RCC_S_RCC_PUBCFGR0_MSIPUB                        \ Defines the public protection of the MSI oscillator configuration bits.
$00000008 constant RCC_S_RCC_PUBCFGR0_HSIPUB                        \ Defines the public protection of the HSI oscillator configuration bits.
$00000010 constant RCC_S_RCC_PUBCFGR0_HSEPUB                        \ Defines the public protection of the HSE oscillator configuration bits.


\
\ @brief RCC PLL secure configuration register1
\ Address offset: 0x790
\ Reset value: 0x00000000
\

$00000001 constant RCC_S_RCC_SECCFGR1_PLL1SEC                       \ Defines the secure protection of the PLL1 PLL configuration bits.
$00000002 constant RCC_S_RCC_SECCFGR1_PLL2SEC                       \ Defines the secure protection of the PLL2 PLL configuration bits.
$00000004 constant RCC_S_RCC_SECCFGR1_PLL3SEC                       \ Defines the secure protection of the PLL3 PLL configuration bits.
$00000008 constant RCC_S_RCC_SECCFGR1_PLL4SEC                       \ Defines the secure protection of the PLL4 PLL configuration bits.


\
\ @brief RCC PLL privilege configuration register1
\ Address offset: 0x794
\ Reset value: 0x00000000
\

$00000001 constant RCC_S_RCC_PRIVCFGR1_PLL1PV                       \ Defines the privilege protection of the PLL1 PLL configuration bits.
$00000002 constant RCC_S_RCC_PRIVCFGR1_PLL2PV                       \ Defines the privilege protection of the PLL2 PLL configuration bits.
$00000004 constant RCC_S_RCC_PRIVCFGR1_PLL3PV                       \ Defines the privilege protection of the PLL3 PLL configuration bits.
$00000008 constant RCC_S_RCC_PRIVCFGR1_PLL4PV                       \ Defines the privilege protection of the PLL4 PLL configuration bits.


\
\ @brief RCC PLL lock configuration register1
\ Address offset: 0x798
\ Reset value: 0x00000000
\

$00000001 constant RCC_S_RCC_LOCKCFGR1_PLL1LOCK                     \ Defines the lock protection of the PLL1 PLL configuration bits.
$00000002 constant RCC_S_RCC_LOCKCFGR1_PLL2LOCK                     \ Defines the lock protection of the PLL2 PLL configuration bits.
$00000004 constant RCC_S_RCC_LOCKCFGR1_PLL3LOCK                     \ Defines the lock protection of the PLL3 PLL configuration bits.
$00000008 constant RCC_S_RCC_LOCKCFGR1_PLL4LOCK                     \ Defines the lock protection of the PLL4 PLL configuration bits.


\
\ @brief RCC PLL public configuration register1
\ Address offset: 0x79C
\ Reset value: 0x00000000
\

$00000001 constant RCC_S_RCC_PUBCFGR1_PLL1PUB                       \ Defines the public protection of the PLL1 PLL configuration bits.
$00000002 constant RCC_S_RCC_PUBCFGR1_PLL2PUB                       \ Defines the public protection of the PLL2 PLL configuration bits.
$00000004 constant RCC_S_RCC_PUBCFGR1_PLL3PUB                       \ Defines the public protection of the PLL3 PLL configuration bits.
$00000008 constant RCC_S_RCC_PUBCFGR1_PLL4PUB                       \ Defines the public protection of the PLL4 PLL configuration bits.


\
\ @brief RCC divider secure configuration register2
\ Address offset: 0x7A0
\ Reset value: 0x00000000
\

$00000001 constant RCC_S_RCC_SECCFGR2_IC1SEC                        \ Defines the secure protection of the IC1 divider configuration bits.
$00000002 constant RCC_S_RCC_SECCFGR2_IC2SEC                        \ Defines the secure protection of the IC2 divider configuration bits.
$00000004 constant RCC_S_RCC_SECCFGR2_IC3SEC                        \ Defines the secure protection of the IC3 divider configuration bits.
$00000008 constant RCC_S_RCC_SECCFGR2_IC4SEC                        \ Defines the secure protection of the IC4 divider configuration bits.
$00000010 constant RCC_S_RCC_SECCFGR2_IC5SEC                        \ Defines the secure protection of the IC5 divider configuration bits.
$00000020 constant RCC_S_RCC_SECCFGR2_IC6SEC                        \ Defines the secure protection of the IC6 divider configuration bits.
$00000040 constant RCC_S_RCC_SECCFGR2_IC7SEC                        \ Defines the secure protection of the IC7 divider configuration bits.
$00000080 constant RCC_S_RCC_SECCFGR2_IC8SEC                        \ Defines the secure protection of the IC8 divider configuration bits.
$00000100 constant RCC_S_RCC_SECCFGR2_IC9SEC                        \ Defines the secure protection of the IC9 divider configuration bits.
$00000200 constant RCC_S_RCC_SECCFGR2_IC10SEC                       \ Defines the secure protection of the IC10 divider configuration bits.
$00000400 constant RCC_S_RCC_SECCFGR2_IC11SEC                       \ Defines the secure protection of the IC11 divider configuration bits.
$00000800 constant RCC_S_RCC_SECCFGR2_IC12SEC                       \ Defines the secure protection of the IC12 divider configuration bits.
$00001000 constant RCC_S_RCC_SECCFGR2_IC13SEC                       \ Defines the secure protection of the IC13 divider configuration bits.
$00002000 constant RCC_S_RCC_SECCFGR2_IC14SEC                       \ Defines the secure protection of the IC14 divider configuration bits.
$00004000 constant RCC_S_RCC_SECCFGR2_IC15SEC                       \ Defines the secure protection of the IC15 divider configuration bits.
$00008000 constant RCC_S_RCC_SECCFGR2_IC16SEC                       \ Defines the secure protection of the IC16 divider configuration bits.
$00010000 constant RCC_S_RCC_SECCFGR2_IC17SEC                       \ Defines the secure protection of the IC17 divider configuration bits.
$00020000 constant RCC_S_RCC_SECCFGR2_IC18SEC                       \ Defines the secure protection of the IC18 divider configuration bits.
$00040000 constant RCC_S_RCC_SECCFGR2_IC19SEC                       \ Defines the secure protection of the IC19 divider configuration bits.
$00080000 constant RCC_S_RCC_SECCFGR2_IC20SEC                       \ Defines the secure protection of the IC20 divider configuration bits.


\
\ @brief RCC divider privilege configuration register2
\ Address offset: 0x7A4
\ Reset value: 0x00000000
\

$00000001 constant RCC_S_RCC_PRIVCFGR2_IC1PV                        \ Defines the privilege protection of the IC1 divider configuration bits.
$00000002 constant RCC_S_RCC_PRIVCFGR2_IC2PV                        \ Defines the privilege protection of the IC2 divider configuration bits.
$00000004 constant RCC_S_RCC_PRIVCFGR2_IC3PV                        \ Defines the privilege protection of the IC3 divider configuration bits.
$00000008 constant RCC_S_RCC_PRIVCFGR2_IC4PV                        \ Defines the privilege protection of the IC4 divider configuration bits.
$00000010 constant RCC_S_RCC_PRIVCFGR2_IC5PV                        \ Defines the privilege protection of the IC5 divider configuration bits.
$00000020 constant RCC_S_RCC_PRIVCFGR2_IC6PV                        \ Defines the privilege protection of the IC6 divider configuration bits.
$00000040 constant RCC_S_RCC_PRIVCFGR2_IC7PV                        \ Defines the privilege protection of the IC7 divider configuration bits.
$00000080 constant RCC_S_RCC_PRIVCFGR2_IC8PV                        \ Defines the privilege protection of the IC8 divider configuration bits.
$00000100 constant RCC_S_RCC_PRIVCFGR2_IC9PV                        \ Defines the privilege protection of the IC9 divider configuration bits.
$00000200 constant RCC_S_RCC_PRIVCFGR2_IC10PV                       \ Defines the privilege protection of the IC10 divider configuration bits.
$00000400 constant RCC_S_RCC_PRIVCFGR2_IC11PV                       \ Defines the privilege protection of the IC11 divider configuration bits.
$00000800 constant RCC_S_RCC_PRIVCFGR2_IC12PV                       \ Defines the privilege protection of the IC12 divider configuration bits.
$00001000 constant RCC_S_RCC_PRIVCFGR2_IC13PV                       \ Defines the privilege protection of the IC13 divider configuration bits.
$00002000 constant RCC_S_RCC_PRIVCFGR2_IC14PV                       \ Defines the privilege protection of the IC14 divider configuration bits.
$00004000 constant RCC_S_RCC_PRIVCFGR2_IC15PV                       \ Defines the privilege protection of the IC15 divider configuration bits.
$00008000 constant RCC_S_RCC_PRIVCFGR2_IC16PV                       \ Defines the privilege protection of the IC16 divider configuration bits.
$00010000 constant RCC_S_RCC_PRIVCFGR2_IC17PV                       \ Defines the privilege protection of the IC17 divider configuration bits.
$00020000 constant RCC_S_RCC_PRIVCFGR2_IC18PV                       \ Defines the privilege protection of the IC18 divider configuration bits.
$00040000 constant RCC_S_RCC_PRIVCFGR2_IC19PV                       \ Defines the privilege protection of the IC19 divider configuration bits.
$00080000 constant RCC_S_RCC_PRIVCFGR2_IC20PV                       \ Defines the privilege protection of the IC20 divider configuration bits.


\
\ @brief RCC divider lock configuration register2
\ Address offset: 0x7A8
\ Reset value: 0x00000000
\

$00000001 constant RCC_S_RCC_LOCKCFGR2_IC1LOCK                      \ Defines the lock protection of the IC1 divider configuration bits.
$00000002 constant RCC_S_RCC_LOCKCFGR2_IC2LOCK                      \ Defines the lock protection of the IC2 divider configuration bits.
$00000004 constant RCC_S_RCC_LOCKCFGR2_IC3LOCK                      \ Defines the lock protection of the IC3 divider configuration bits.
$00000008 constant RCC_S_RCC_LOCKCFGR2_IC4LOCK                      \ Defines the lock protection of the IC4 divider configuration bits.
$00000010 constant RCC_S_RCC_LOCKCFGR2_IC5LOCK                      \ Defines the lock protection of the IC5 divider configuration bits.
$00000020 constant RCC_S_RCC_LOCKCFGR2_IC6LOCK                      \ Defines the lock protection of the IC6 divider configuration bits.
$00000040 constant RCC_S_RCC_LOCKCFGR2_IC7LOCK                      \ Defines the lock protection of the IC7 divider configuration bits.
$00000080 constant RCC_S_RCC_LOCKCFGR2_IC8LOCK                      \ Defines the lock protection of the IC8 divider configuration bits.
$00000100 constant RCC_S_RCC_LOCKCFGR2_IC9LOCK                      \ Defines the lock protection of the IC9 divider configuration bits.
$00000200 constant RCC_S_RCC_LOCKCFGR2_IC10LOCK                     \ Defines the lock protection of the IC10 divider configuration bits.
$00000400 constant RCC_S_RCC_LOCKCFGR2_IC11LOCK                     \ Defines the lock protection of the IC11 divider configuration bits.
$00000800 constant RCC_S_RCC_LOCKCFGR2_IC12LOCK                     \ Defines the lock protection of the IC12 divider configuration bits.
$00001000 constant RCC_S_RCC_LOCKCFGR2_IC13LOCK                     \ Defines the lock protection of the IC13 divider configuration bits.
$00002000 constant RCC_S_RCC_LOCKCFGR2_IC14LOCK                     \ Defines the lock protection of the IC14 divider configuration bits.
$00004000 constant RCC_S_RCC_LOCKCFGR2_IC15LOCK                     \ Defines the lock protection of the IC15 divider configuration bits.
$00008000 constant RCC_S_RCC_LOCKCFGR2_IC16LOCK                     \ Defines the lock protection of the IC16 divider configuration bits.
$00010000 constant RCC_S_RCC_LOCKCFGR2_IC17LOCK                     \ Defines the lock protection of the IC17 divider configuration bits.
$00020000 constant RCC_S_RCC_LOCKCFGR2_IC18LOCK                     \ Defines the lock protection of the IC18 divider configuration bits.
$00040000 constant RCC_S_RCC_LOCKCFGR2_IC19LOCK                     \ Defines the lock protection of the IC19 divider configuration bits.
$00080000 constant RCC_S_RCC_LOCKCFGR2_IC20LOCK                     \ Defines the lock protection of the IC20 divider configuration bits.


\
\ @brief RCC divider public configuration register2
\ Address offset: 0x7AC
\ Reset value: 0x00000000
\

$00000001 constant RCC_S_RCC_PUBCFGR2_IC1PUB                        \ Defines the public protection of the IC1 divider configuration bits.
$00000002 constant RCC_S_RCC_PUBCFGR2_IC2PUB                        \ Defines the public protection of the IC2 divider configuration bits.
$00000004 constant RCC_S_RCC_PUBCFGR2_IC3PUB                        \ Defines the public protection of the IC3 divider configuration bits.
$00000008 constant RCC_S_RCC_PUBCFGR2_IC4PUB                        \ Defines the public protection of the IC4 divider configuration bits.
$00000010 constant RCC_S_RCC_PUBCFGR2_IC5PUB                        \ Defines the public protection of the IC5 divider configuration bits.
$00000020 constant RCC_S_RCC_PUBCFGR2_IC6PUB                        \ Defines the public protection of the IC6 divider configuration bits.
$00000040 constant RCC_S_RCC_PUBCFGR2_IC7PUB                        \ Defines the public protection of the IC7 divider configuration bits.
$00000080 constant RCC_S_RCC_PUBCFGR2_IC8PUB                        \ Defines the public protection of the IC8 divider configuration bits.
$00000100 constant RCC_S_RCC_PUBCFGR2_IC9PUB                        \ Defines the public protection of the IC9 divider configuration bits.
$00000200 constant RCC_S_RCC_PUBCFGR2_IC10PUB                       \ Defines the public protection of the IC10 divider configuration bits.
$00000400 constant RCC_S_RCC_PUBCFGR2_IC11PUB                       \ Defines the public protection of the IC11 divider configuration bits.
$00000800 constant RCC_S_RCC_PUBCFGR2_IC12PUB                       \ Defines the public protection of the IC12 divider configuration bits.
$00001000 constant RCC_S_RCC_PUBCFGR2_IC13PUB                       \ Defines the public protection of the IC13 divider configuration bits.
$00002000 constant RCC_S_RCC_PUBCFGR2_IC14PUB                       \ Defines the public protection of the IC14 divider configuration bits.
$00004000 constant RCC_S_RCC_PUBCFGR2_IC15PUB                       \ Defines the public protection of the IC15 divider configuration bits.
$00008000 constant RCC_S_RCC_PUBCFGR2_IC16PUB                       \ Defines the public protection of the IC16 divider configuration bits.
$00010000 constant RCC_S_RCC_PUBCFGR2_IC17PUB                       \ Defines the public protection of the IC17 divider configuration bits.
$00020000 constant RCC_S_RCC_PUBCFGR2_IC18PUB                       \ Defines the public protection of the IC18 divider configuration bits.
$00040000 constant RCC_S_RCC_PUBCFGR2_IC19PUB                       \ Defines the public protection of the IC19 divider configuration bits.
$00080000 constant RCC_S_RCC_PUBCFGR2_IC20PUB                       \ Defines the public protection of the IC20 divider configuration bits.


\
\ @brief RCC system secure configuration register3
\ Address offset: 0x7B0
\ Reset value: 0x00000000
\

$00000001 constant RCC_S_RCC_SECCFGR3_MODSEC                        \ Defines the secure protection of the MOD system configuration bits.
$00000002 constant RCC_S_RCC_SECCFGR3_SYSSEC                        \ Defines the secure protection of the SYS system configuration bits.
$00000004 constant RCC_S_RCC_SECCFGR3_BUSSEC                        \ Defines the secure protection of the BUS system configuration bits.
$00000008 constant RCC_S_RCC_SECCFGR3_PERSEC                        \ Defines the secure protection of the PER system configuration bits.
$00000010 constant RCC_S_RCC_SECCFGR3_INTSEC                        \ Defines the secure protection of the INT system configuration bits.
$00000020 constant RCC_S_RCC_SECCFGR3_RSTSEC                        \ Defines the secure protection of the RST system configuration bits.
$00000040 constant RCC_S_RCC_SECCFGR3_DFTSEC                        \ Defines the secure protection of the DFT system configuration bits.


\
\ @brief RCC system privilege configuration register3
\ Address offset: 0x7B4
\ Reset value: 0x00000000
\

$00000001 constant RCC_S_RCC_PRIVCFGR3_MODPV                        \ Defines the privilege protection of the MOD system configuration bits.
$00000002 constant RCC_S_RCC_PRIVCFGR3_SYSPV                        \ Defines the privilege protection of the SYS system configuration bits.
$00000004 constant RCC_S_RCC_PRIVCFGR3_BUSPV                        \ Defines the privilege protection of the BUS system configuration bits.
$00000008 constant RCC_S_RCC_PRIVCFGR3_PERPV                        \ Defines the privilege protection of the PER system configuration bits.
$00000010 constant RCC_S_RCC_PRIVCFGR3_INTPV                        \ Defines the privilege protection of the INT system configuration bits.
$00000020 constant RCC_S_RCC_PRIVCFGR3_RSTPV                        \ Defines the privilege protection of the RST system configuration bits.
$00000040 constant RCC_S_RCC_PRIVCFGR3_DFTPV                        \ Defines the privilege protection of the DFT system configuration bits.


\
\ @brief RCC system lock configuration register3
\ Address offset: 0x7B8
\ Reset value: 0x00000000
\

$00000001 constant RCC_S_RCC_LOCKCFGR3_MODLOCK                      \ Defines the lock protection of the MOD system configuration bits.
$00000002 constant RCC_S_RCC_LOCKCFGR3_SYSLOCK                      \ Defines the lock protection of the SYS system configuration bits.
$00000004 constant RCC_S_RCC_LOCKCFGR3_BUSLOCK                      \ Defines the lock protection of the BUS system configuration bits.
$00000008 constant RCC_S_RCC_LOCKCFGR3_PERLOCK                      \ Defines the lock protection of the PER system configuration bits.
$00000010 constant RCC_S_RCC_LOCKCFGR3_INTLOCK                      \ Defines the lock protection of the INT system configuration bits.
$00000020 constant RCC_S_RCC_LOCKCFGR3_RSTLOCK                      \ Defines the lock protection of the RST system configuration bits.
$00000040 constant RCC_S_RCC_LOCKCFGR3_DFTLOCK                      \ Defines the lock protection of the DFT system configuration bits.


\
\ @brief RCC system public configuration register3
\ Address offset: 0x7BC
\ Reset value: 0x00000000
\

$00000001 constant RCC_S_RCC_PUBCFGR3_MODPUB                        \ Defines the public protection of the MOD system configuration bits.
$00000002 constant RCC_S_RCC_PUBCFGR3_SYSPUB                        \ Defines the public protection of the SYS system configuration bits.
$00000004 constant RCC_S_RCC_PUBCFGR3_BUSPUB                        \ Defines the public protection of the BUS system configuration bits.
$00000008 constant RCC_S_RCC_PUBCFGR3_PERPUB                        \ Defines the public protection of the PER system configuration bits.
$00000010 constant RCC_S_RCC_PUBCFGR3_INTPUB                        \ Defines the public protection of the INT system configuration bits.
$00000020 constant RCC_S_RCC_PUBCFGR3_RSTPUB                        \ Defines the public protection of the RST system configuration bits.
$00000040 constant RCC_S_RCC_PUBCFGR3_DFTPUB                        \ Defines the public protection of the DFT system configuration bits.


\
\ @brief RCC bus secure configuration register4
\ Address offset: 0x7C0
\ Reset value: 0x00000000
\

$00000001 constant RCC_S_RCC_SECCFGR4_ACLKNSEC                      \ Defines the secure protection of the ACLKN bus configuration bits.
$00000002 constant RCC_S_RCC_SECCFGR4_ACLKNCSEC                     \ Defines the secure protection of the ACLKNC bus configuration bits.
$00000004 constant RCC_S_RCC_SECCFGR4_AHBMSEC                       \ Defines the secure protection of the AHBM bus configuration bits.
$00000008 constant RCC_S_RCC_SECCFGR4_AHB1SEC                       \ Defines the secure protection of the AHB1 bus configuration bits.
$00000010 constant RCC_S_RCC_SECCFGR4_AHB2SEC                       \ Defines the secure protection of the AHB2 bus configuration bits.
$00000020 constant RCC_S_RCC_SECCFGR4_AHB3SEC                       \ Defines the secure protection of the AHB3 bus configuration bits.
$00000040 constant RCC_S_RCC_SECCFGR4_AHB4SEC                       \ Defines the secure protection of the AHB4 bus configuration bits.
$00000080 constant RCC_S_RCC_SECCFGR4_AHB5SEC                       \ Defines the secure protection of the AHB5 bus configuration bits.
$00000100 constant RCC_S_RCC_SECCFGR4_APB1SEC                       \ Defines the secure protection of the APB1 bus configuration bits.
$00000200 constant RCC_S_RCC_SECCFGR4_APB2SEC                       \ Defines the secure protection of the APB2 bus configuration bits.
$00000400 constant RCC_S_RCC_SECCFGR4_APB3SEC                       \ Defines the secure protection of the APB3 bus configuration bits.
$00000800 constant RCC_S_RCC_SECCFGR4_APB4SEC                       \ Defines the secure protection of the APB4 bus configuration bits.
$00001000 constant RCC_S_RCC_SECCFGR4_APB5SEC                       \ Defines the secure protection of the APB5 bus configuration bits.
$00002000 constant RCC_S_RCC_SECCFGR4_NOCSEC                        \ Defines the secure protection of the NOC bus configuration bits.


\
\ @brief RCC bus privilege configuration register4
\ Address offset: 0x7C4
\ Reset value: 0x00000000
\

$00000001 constant RCC_S_RCC_PRIVCFGR4_ACLKNPV                      \ Defines the privilege protection of the ACLKN bus configuration bits.
$00000002 constant RCC_S_RCC_PRIVCFGR4_ACLKNCPV                     \ Defines the privilege protection of the ACLKNC bus configuration bits.
$00000004 constant RCC_S_RCC_PRIVCFGR4_AHBMPV                       \ Defines the privilege protection of the AHBM bus configuration bits.
$00000008 constant RCC_S_RCC_PRIVCFGR4_AHB1PV                       \ Defines the privilege protection of the AHB1 bus configuration bits.
$00000010 constant RCC_S_RCC_PRIVCFGR4_AHB2PV                       \ Defines the privilege protection of the AHB2 bus configuration bits.
$00000020 constant RCC_S_RCC_PRIVCFGR4_AHB3PV                       \ Defines the privilege protection of the AHB3 bus configuration bits.
$00000040 constant RCC_S_RCC_PRIVCFGR4_AHB4PV                       \ Defines the privilege protection of the AHB4 bus configuration bits.
$00000080 constant RCC_S_RCC_PRIVCFGR4_AHB5PV                       \ Defines the privilege protection of the AHB5 bus configuration bits.
$00000100 constant RCC_S_RCC_PRIVCFGR4_APB1PV                       \ Defines the privilege protection of the APB1 bus configuration bits.
$00000200 constant RCC_S_RCC_PRIVCFGR4_APB2PV                       \ Defines the privilege protection of the APB2 bus configuration bits.
$00000400 constant RCC_S_RCC_PRIVCFGR4_APB3PV                       \ Defines the privilege protection of the APB3 bus configuration bits.
$00000800 constant RCC_S_RCC_PRIVCFGR4_APB4PV                       \ Defines the privilege protection of the APB4 bus configuration bits.
$00001000 constant RCC_S_RCC_PRIVCFGR4_APB5PV                       \ Defines the privilege protection of the APB5 bus configuration bits.
$00002000 constant RCC_S_RCC_PRIVCFGR4_NOCPV                        \ Defines the privilege protection of the NOC bus configuration bits.


\
\ @brief RCC bus lock configuration register4
\ Address offset: 0x7C8
\ Reset value: 0x00000000
\

$00000001 constant RCC_S_RCC_LOCKCFGR4_ACLKNLOCK                    \ Defines the lock protection of the ACLKN bus configuration bits.
$00000002 constant RCC_S_RCC_LOCKCFGR4_ACLKNCLOCK                   \ Defines the lock protection of the ACLKNC bus configuration bits.
$00000004 constant RCC_S_RCC_LOCKCFGR4_AHBMLOCK                     \ Defines the lock protection of the AHBM bus configuration bits.
$00000008 constant RCC_S_RCC_LOCKCFGR4_AHB1LOCK                     \ Defines the lock protection of the AHB1 bus configuration bits.
$00000010 constant RCC_S_RCC_LOCKCFGR4_AHB2LOCK                     \ Defines the lock protection of the AHB2 bus configuration bits.
$00000020 constant RCC_S_RCC_LOCKCFGR4_AHB3LOCK                     \ Defines the lock protection of the AHB3 bus configuration bits.
$00000040 constant RCC_S_RCC_LOCKCFGR4_AHB4LOCK                     \ Defines the lock protection of the AHB4 bus configuration bits.
$00000080 constant RCC_S_RCC_LOCKCFGR4_AHB5LOCK                     \ Defines the lock protection of the AHB5 bus configuration bits.
$00000100 constant RCC_S_RCC_LOCKCFGR4_APB1LOCK                     \ Defines the lock protection of the APB1 bus configuration bits.
$00000200 constant RCC_S_RCC_LOCKCFGR4_APB2LOCK                     \ Defines the lock protection of the APB2 bus configuration bits.
$00000400 constant RCC_S_RCC_LOCKCFGR4_APB3LOCK                     \ Defines the lock protection of the APB3 bus configuration bits.
$00000800 constant RCC_S_RCC_LOCKCFGR4_APB4LOCK                     \ Defines the lock protection of the APB4 bus configuration bits.
$00001000 constant RCC_S_RCC_LOCKCFGR4_APB5LOCK                     \ Defines the lock protection of the APB5 bus configuration bits.
$00002000 constant RCC_S_RCC_LOCKCFGR4_NOCLOCK                      \ Defines the lock protection of the NOC bus configuration bits.


\
\ @brief RCC bus public configuration register4
\ Address offset: 0x7CC
\ Reset value: 0x00000000
\

$00000001 constant RCC_S_RCC_PUBCFGR4_ACLKNPUB                      \ Defines the public protection of the ACLKN bus configuration bits.
$00000002 constant RCC_S_RCC_PUBCFGR4_ACLKNCPUB                     \ Defines the public protection of the ACLKNC bus configuration bits.
$00000004 constant RCC_S_RCC_PUBCFGR4_AHBMPUB                       \ Defines the public protection of the AHBM bus configuration bits.
$00000008 constant RCC_S_RCC_PUBCFGR4_AHB1PUB                       \ Defines the public protection of the AHB1 bus configuration bits.
$00000010 constant RCC_S_RCC_PUBCFGR4_AHB2PUB                       \ Defines the public protection of the AHB2 bus configuration bits.
$00000020 constant RCC_S_RCC_PUBCFGR4_AHB3PUB                       \ Defines the public protection of the AHB3 bus configuration bits.
$00000040 constant RCC_S_RCC_PUBCFGR4_AHB4PUB                       \ Defines the public protection of the AHB4 bus configuration bits.
$00000080 constant RCC_S_RCC_PUBCFGR4_AHB5PUB                       \ Defines the public protection of the AHB5 bus configuration bits.
$00000100 constant RCC_S_RCC_PUBCFGR4_APB1PUB                       \ Defines the public protection of the APB1 bus configuration bits.
$00000200 constant RCC_S_RCC_PUBCFGR4_APB2PUB                       \ Defines the public protection of the APB2 bus configuration bits.
$00000400 constant RCC_S_RCC_PUBCFGR4_APB3PUB                       \ Defines the public protection of the APB3 bus configuration bits.
$00000800 constant RCC_S_RCC_PUBCFGR4_APB4PUB                       \ Defines the public protection of the APB4 bus configuration bits.
$00001000 constant RCC_S_RCC_PUBCFGR4_APB5PUB                       \ Defines the public protection of the APB5 bus configuration bits.
$00002000 constant RCC_S_RCC_PUBCFGR4_NOCPUB                        \ Defines the public protection of the NOC bus configuration bits.


\
\ @brief RCC bus public configuration register4
\ Address offset: 0x7D0
\ Reset value: 0x00000000
\

$00000001 constant RCC_S_RCC_PUBCFGR5_AXISRAM3PUB                   \ Defines the public protection of the AXISRAM3 bus configuration bits.
$00000002 constant RCC_S_RCC_PUBCFGR5_AXISRAM4PUB                   \ Defines the public protection of the AXISRAM4 bus configuration bits.
$00000004 constant RCC_S_RCC_PUBCFGR5_AXISRAM5PUB                   \ Defines the public protection of the AXISRAM5 bus configuration bits.
$00000008 constant RCC_S_RCC_PUBCFGR5_AXISRAM6PUB                   \ Defines the public protection of the AXISRAM6 bus configuration bits.
$00000010 constant RCC_S_RCC_PUBCFGR5_AHBSRAM1PUB                   \ Defines the public protection of the AHBSRAM1 bus configuration bits.
$00000020 constant RCC_S_RCC_PUBCFGR5_AHBSRAM2PUB                   \ Defines the public protection of the AHBSRAM2 bus configuration bits.
$00000040 constant RCC_S_RCC_PUBCFGR5_BKPSRAMPUB                    \ Defines the public protection of the BKPSRAM bus configuration bits.
$00000080 constant RCC_S_RCC_PUBCFGR5_AXISRAM1PUB                   \ Defines the public protection of the AXISRAM1 bus configuration bits.
$00000100 constant RCC_S_RCC_PUBCFGR5_AXISRAM2PUB                   \ Defines the public protection of the AXISRAM2 bus configuration bits.
$00000200 constant RCC_S_RCC_PUBCFGR5_FLEXRAMPUB                    \ Defines the public protection of the FLEXRAM bus configuration bits.
$00000400 constant RCC_S_RCC_PUBCFGR5_NPUCACHERAMPUB                \ Defines the public protection of the NPUCACHERAM bus configuration bits.
$00000800 constant RCC_S_RCC_PUBCFGR5_VENCRAMPUB                    \ Defines the public protection of the VENCRAM bus configuration bits.


\
\ @brief RCC control set register
\ Address offset: 0x800
\ Reset value: 0x00000000
\

$00000001 constant RCC_S_RCC_CSR_LSIONS                             \ LSI oscillator enable in Run/Sleep mode.
$00000002 constant RCC_S_RCC_CSR_LSEONS                             \ LSE oscillator enable in Run/Sleep mode.
$00000004 constant RCC_S_RCC_CSR_MSIONS                             \ MSI oscillator enable in Run/Sleep mode.
$00000008 constant RCC_S_RCC_CSR_HSIONS                             \ HSI oscillator enable in Run/Sleep mode.
$00000010 constant RCC_S_RCC_CSR_HSEONS                             \ HSE oscillator enable in Run/Sleep mode.
$00000100 constant RCC_S_RCC_CSR_PLL1ONS                            \ PLL1 oscillator enable in Run/Sleep mode.
$00000200 constant RCC_S_RCC_CSR_PLL2ONS                            \ PLL2 oscillator enable in Run/Sleep mode.
$00000400 constant RCC_S_RCC_CSR_PLL3ONS                            \ PLL3 oscillator enable in Run/Sleep mode.
$00000800 constant RCC_S_RCC_CSR_PLL4ONS                            \ PLL4 oscillator enable in Run/Sleep mode.


\
\ @brief RCC Stop configuration register
\ Address offset: 0x808
\ Reset value: 0x00000000
\

$00000001 constant RCC_S_RCC_STOPCSR_MSISTOPENS                     \ MSISTOPENS
$00000002 constant RCC_S_RCC_STOPCSR_HSISTOPENS                     \ HSISTOPENS


\
\ @brief RCC bus reset set register
\ Address offset: 0xA04
\ Reset value: 0x00000000
\

$00000001 constant RCC_S_RCC_BUSRSTSR_ACLKNRSTS                     \ ACLKN reset
$00000004 constant RCC_S_RCC_BUSRSTSR_AHBMRSTS                      \ AHBM reset
$00000008 constant RCC_S_RCC_BUSRSTSR_AHB1RSTS                      \ AHB1 reset
$00000010 constant RCC_S_RCC_BUSRSTSR_AHB2RSTS                      \ AHB2 reset
$00000020 constant RCC_S_RCC_BUSRSTSR_AHB3RSTS                      \ AHB3 reset
$00000040 constant RCC_S_RCC_BUSRSTSR_AHB4RSTS                      \ AHB4 reset
$00000080 constant RCC_S_RCC_BUSRSTSR_AHB5RSTS                      \ AHB5 reset
$00000100 constant RCC_S_RCC_BUSRSTSR_APB1RSTS                      \ APB1 reset
$00000200 constant RCC_S_RCC_BUSRSTSR_APB2RSTS                      \ APB2 reset
$00000400 constant RCC_S_RCC_BUSRSTSR_APB3RSTS                      \ APB3 reset
$00000800 constant RCC_S_RCC_BUSRSTSR_APB4RSTS                      \ APB4 reset
$00001000 constant RCC_S_RCC_BUSRSTSR_APB5RSTS                      \ APB5 reset
$00002000 constant RCC_S_RCC_BUSRSTSR_NOCRSTS                       \ NOC reset


\
\ @brief RCC miscellaneous reset register
\ Address offset: 0xA08
\ Reset value: 0x00000000
\

$00000001 constant RCC_S_RCC_MISCRSTSR_DBGRSTS                      \ DBG reset
$00000010 constant RCC_S_RCC_MISCRSTSR_XSPIPHY1RSTS                 \ XSPIPHY1 reset
$00000020 constant RCC_S_RCC_MISCRSTSR_XSPIPHY2RSTS                 \ XSPIPHY2 reset
$00000080 constant RCC_S_RCC_MISCRSTSR_SDMMC1DLLRSTS                \ SDMMC1DLL reset
$00000100 constant RCC_S_RCC_MISCRSTSR_SDMMC2DLLRSTS                \ SDMMC2DLL reset


\
\ @brief RCC memory reset register
\ Address offset: 0xA0C
\ Reset value: 0x00000000
\

$00000001 constant RCC_S_RCC_MEMRSTSR_AXISRAM3RSTS                  \ AXISRAM3 reset
$00000002 constant RCC_S_RCC_MEMRSTSR_AXISRAM4RSTS                  \ AXISRAM4 reset
$00000004 constant RCC_S_RCC_MEMRSTSR_AXISRAM5RSTS                  \ AXISRAM5 reset
$00000008 constant RCC_S_RCC_MEMRSTSR_AXISRAM6RSTS                  \ AXISRAM6 reset
$00000010 constant RCC_S_RCC_MEMRSTSR_AHBSRAM1RSTS                  \ AHBSRAM1 reset
$00000020 constant RCC_S_RCC_MEMRSTSR_AHBSRAM2RSTS                  \ AHBSRAM2 reset
$00000080 constant RCC_S_RCC_MEMRSTSR_AXISRAM1RSTS                  \ AXISRAM1 reset
$00000100 constant RCC_S_RCC_MEMRSTSR_AXISRAM2RSTS                  \ AXISRAM2 reset
$00000200 constant RCC_S_RCC_MEMRSTSR_FLEXRAMRSTS                   \ FLEXRAM reset
$00000400 constant RCC_S_RCC_MEMRSTSR_NPUCACHERAMRSTS               \ NPUCACHERAM reset
$00000800 constant RCC_S_RCC_MEMRSTSR_VENCRAMRSTS                   \ VENCRAM reset
$00001000 constant RCC_S_RCC_MEMRSTSR_BOOTROMRSTS                   \ BOOTROM reset


\
\ @brief RCC AHB1 reset register
\ Address offset: 0xA10
\ Reset value: 0x00000000
\

$00000010 constant RCC_S_RCC_AHB1RSTSR_GPDMA1RSTS                   \ GPDMA1 reset
$00000020 constant RCC_S_RCC_AHB1RSTSR_ADC12RSTS                    \ ADC12 reset


\
\ @brief RCC AHB2 reset register
\ Address offset: 0xA14
\ Reset value: 0x00000000
\

$00001000 constant RCC_S_RCC_AHB2RSTSR_RAMCFGRSTS                   \ RAMCFG reset
$00010000 constant RCC_S_RCC_AHB2RSTSR_MDF1RSTS                     \ MDF1 reset
$00020000 constant RCC_S_RCC_AHB2RSTSR_ADF1RSTS                     \ ADF1 reset


\
\ @brief RCC AHB3 reset register
\ Address offset: 0xA18
\ Reset value: 0x00000000
\

$00000001 constant RCC_S_RCC_AHB3RSTSR_RNGRSTS                      \ RNG reset
$00000002 constant RCC_S_RCC_AHB3RSTSR_HASHRSTS                     \ HASH reset
$00000004 constant RCC_S_RCC_AHB3RSTSR_CRYPRSTS                     \ CRYP reset
$00000010 constant RCC_S_RCC_AHB3RSTSR_SAESRSTS                     \ SAES reset
$00000100 constant RCC_S_RCC_AHB3RSTSR_PKARSTS                      \ PKA reset
$00000400 constant RCC_S_RCC_AHB3RSTSR_IACRSTS                      \ IAC reset


\
\ @brief RCC AHB4 reset register
\ Address offset: 0xA1C
\ Reset value: 0x00000000
\

$00000001 constant RCC_S_RCC_AHB4RSTSR_GPIOARSTS                    \ GPIOA reset
$00000002 constant RCC_S_RCC_AHB4RSTSR_GPIOBRSTS                    \ GPIOB reset
$00000004 constant RCC_S_RCC_AHB4RSTSR_GPIOCRSTS                    \ GPIOC reset
$00000008 constant RCC_S_RCC_AHB4RSTSR_GPIODRSTS                    \ GPIOD reset
$00000010 constant RCC_S_RCC_AHB4RSTSR_GPIOERSTS                    \ GPIOE reset
$00000020 constant RCC_S_RCC_AHB4RSTSR_GPIOFRSTS                    \ GPIOF reset
$00000040 constant RCC_S_RCC_AHB4RSTSR_GPIOGRSTS                    \ GPIOG reset
$00000080 constant RCC_S_RCC_AHB4RSTSR_GPIOHRSTS                    \ GPIOH reset
$00002000 constant RCC_S_RCC_AHB4RSTSR_GPIONRSTS                    \ GPION reset
$00004000 constant RCC_S_RCC_AHB4RSTSR_GPIOORSTS                    \ GPIOO reset
$00008000 constant RCC_S_RCC_AHB4RSTSR_GPIOPRSTS                    \ GPIOP reset
$00010000 constant RCC_S_RCC_AHB4RSTSR_GPIOQRSTS                    \ GPIOQ reset
$00040000 constant RCC_S_RCC_AHB4RSTSR_PWRRSTS                      \ PWR reset
$00080000 constant RCC_S_RCC_AHB4RSTSR_CRCRSTS                      \ CRC reset


\
\ @brief RCC AHB5 reset register
\ Address offset: 0xA20
\ Reset value: 0x00000000
\

$00000001 constant RCC_S_RCC_AHB5RSTSR_HPDMA1RSTS                   \ HPDMA1 reset
$00000002 constant RCC_S_RCC_AHB5RSTSR_DMA2DRSTS                    \ DMA2D reset
$00000008 constant RCC_S_RCC_AHB5RSTSR_JPEGRSTS                     \ JPEG reset
$00000010 constant RCC_S_RCC_AHB5RSTSR_FMCRSTS                      \ FMC reset
$00000020 constant RCC_S_RCC_AHB5RSTSR_XSPI1RSTS                    \ XSPI1 reset
$00000040 constant RCC_S_RCC_AHB5RSTSR_PSSIRSTS                     \ PSSI reset
$00000080 constant RCC_S_RCC_AHB5RSTSR_SDMMC2RSTS                   \ SDMMC2 reset
$00000100 constant RCC_S_RCC_AHB5RSTSR_SDMMC1RSTS                   \ SDMMC1 reset
$00001000 constant RCC_S_RCC_AHB5RSTSR_XSPI2RSTS                    \ XSPI2 reset
$00002000 constant RCC_S_RCC_AHB5RSTSR_XSPIMRSTS                    \ XSPIM reset
$00020000 constant RCC_S_RCC_AHB5RSTSR_XSPI3RSTS                    \ XSPI3 reset
$00040000 constant RCC_S_RCC_AHB5RSTSR_MCE4RSTS                     \ MCE4 reset
$00080000 constant RCC_S_RCC_AHB5RSTSR_GFXMMURSTS                   \ GFXMMU reset
$00100000 constant RCC_S_RCC_AHB5RSTSR_GPURSTS                      \ GPU reset
$00800000 constant RCC_S_RCC_AHB5RSTSR_SYSCFGOTGHSPHY1RSTS          \ SYSCFGOTGHSPHY1 reset
$01000000 constant RCC_S_RCC_AHB5RSTSR_SYSCFGOTGHSPHY2RSTS          \ SYSCFGOTGHSPHY2 reset
$02000000 constant RCC_S_RCC_AHB5RSTSR_ETH1RSTS                     \ ETH1 reset
$04000000 constant RCC_S_RCC_AHB5RSTSR_OTG1RSTS                     \ OTG1 reset
$08000000 constant RCC_S_RCC_AHB5RSTSR_OTGPHY1RSTS                  \ OTGPHY1 reset
$10000000 constant RCC_S_RCC_AHB5RSTSR_OTGPHY2RSTS                  \ OTGPHY2 reset
$20000000 constant RCC_S_RCC_AHB5RSTSR_OTG2RSTS                     \ OTG2 reset
$40000000 constant RCC_S_RCC_AHB5RSTSR_NPUCACHERSTS                 \ NPUCACHE reset
$80000000 constant RCC_S_RCC_AHB5RSTSR_NPURSTS                      \ NPU reset


\
\ @brief RCC APB1L reset register
\ Address offset: 0xA24
\ Reset value: 0x00000000
\

$00000001 constant RCC_S_RCC_APB1LRSTSR_TIM2RSTS                    \ TIM2 reset
$00000002 constant RCC_S_RCC_APB1LRSTSR_TIM3RSTS                    \ TIM3 reset
$00000004 constant RCC_S_RCC_APB1LRSTSR_TIM4RSTS                    \ TIM4 reset
$00000008 constant RCC_S_RCC_APB1LRSTSR_TIM5RSTS                    \ TIM5 reset
$00000010 constant RCC_S_RCC_APB1LRSTSR_TIM6RSTS                    \ TIM6 reset
$00000020 constant RCC_S_RCC_APB1LRSTSR_TIM7RSTS                    \ TIM7 reset
$00000040 constant RCC_S_RCC_APB1LRSTSR_TIM12RSTS                   \ TIM12 reset
$00000080 constant RCC_S_RCC_APB1LRSTSR_TIM13RSTS                   \ TIM13 reset
$00000100 constant RCC_S_RCC_APB1LRSTSR_TIM14RSTS                   \ TIM14 reset
$00000200 constant RCC_S_RCC_APB1LRSTSR_LPTIM1RSTS                  \ LPTIM1 reset
$00000800 constant RCC_S_RCC_APB1LRSTSR_WWDGRSTS                    \ WWDG reset
$00001000 constant RCC_S_RCC_APB1LRSTSR_TIM10RSTS                   \ TIM10 reset
$00002000 constant RCC_S_RCC_APB1LRSTSR_TIM11RSTS                   \ TIM11 reset
$00004000 constant RCC_S_RCC_APB1LRSTSR_SPI2RSTS                    \ SPI2 reset
$00008000 constant RCC_S_RCC_APB1LRSTSR_SPI3RSTS                    \ SPI3 reset
$00010000 constant RCC_S_RCC_APB1LRSTSR_SPDIFRX1RSTS                \ SPDIFRX1 reset
$00020000 constant RCC_S_RCC_APB1LRSTSR_USART2RSTS                  \ USART2 reset
$00040000 constant RCC_S_RCC_APB1LRSTSR_USART3RSTS                  \ USART3 reset
$00080000 constant RCC_S_RCC_APB1LRSTSR_UART4RSTS                   \ UART4 reset
$00100000 constant RCC_S_RCC_APB1LRSTSR_UART5RSTS                   \ UART5 reset
$00200000 constant RCC_S_RCC_APB1LRSTSR_I2C1RSTS                    \ I2C1 reset
$00400000 constant RCC_S_RCC_APB1LRSTSR_I2C2RSTS                    \ I2C2 reset
$00800000 constant RCC_S_RCC_APB1LRSTSR_I2C3RSTS                    \ I2C3 reset
$01000000 constant RCC_S_RCC_APB1LRSTSR_I3C1RSTS                    \ I3C1 reset
$02000000 constant RCC_S_RCC_APB1LRSTSR_I3C2RSTS                    \ I3C2 reset
$40000000 constant RCC_S_RCC_APB1LRSTSR_UART7RSTS                   \ UART7 reset
$80000000 constant RCC_S_RCC_APB1LRSTSR_UART8RSTS                   \ UART8 reset


\
\ @brief RCC APB1H reset register
\ Address offset: 0xA28
\ Reset value: 0x00000000
\

$00000020 constant RCC_S_RCC_APB1HRSTSR_MDIOSRSTS                   \ MDIOS reset
$00000100 constant RCC_S_RCC_APB1HRSTSR_FDCANRSTS                   \ FDCAN reset
$00040000 constant RCC_S_RCC_APB1HRSTSR_UCPD1RSTS                   \ UCPD1 reset


\
\ @brief RCC APB2 reset register
\ Address offset: 0xA2C
\ Reset value: 0x00000000
\

$00000001 constant RCC_S_RCC_APB2RSTSR_TIM1RSTS                     \ TIM1 reset
$00000002 constant RCC_S_RCC_APB2RSTSR_TIM8RSTS                     \ TIM8 reset
$00000010 constant RCC_S_RCC_APB2RSTSR_USART1RSTS                   \ USART1 reset
$00000020 constant RCC_S_RCC_APB2RSTSR_USART6RSTS                   \ USART6 reset
$00000040 constant RCC_S_RCC_APB2RSTSR_UART9RSTS                    \ UART9 reset
$00000080 constant RCC_S_RCC_APB2RSTSR_USART10RSTS                  \ USART10 reset
$00001000 constant RCC_S_RCC_APB2RSTSR_SPI1RSTS                     \ SPI1 reset
$00002000 constant RCC_S_RCC_APB2RSTSR_SPI4RSTS                     \ SPI4 reset
$00008000 constant RCC_S_RCC_APB2RSTSR_TIM18RSTS                    \ TIM18 reset
$00010000 constant RCC_S_RCC_APB2RSTSR_TIM15RSTS                    \ TIM15 reset
$00020000 constant RCC_S_RCC_APB2RSTSR_TIM16RSTS                    \ TIM16 reset
$00040000 constant RCC_S_RCC_APB2RSTSR_TIM17RSTS                    \ TIM17 reset
$00080000 constant RCC_S_RCC_APB2RSTSR_TIM9RSTS                     \ TIM9 reset
$00100000 constant RCC_S_RCC_APB2RSTSR_SPI5RSTS                     \ SPI5 reset
$00200000 constant RCC_S_RCC_APB2RSTSR_SAI1RSTS                     \ SAI1 reset
$00400000 constant RCC_S_RCC_APB2RSTSR_SAI2RSTS                     \ SAI2 reset


\
\ @brief RCC APB4L reset register
\ Address offset: 0xA34
\ Reset value: 0x00000000
\

$00000004 constant RCC_S_RCC_APB4LRSTSR_HDPRSTS                     \ HDP reset
$00000008 constant RCC_S_RCC_APB4LRSTSR_LPUART1RSTS                 \ LPUART1 reset
$00000020 constant RCC_S_RCC_APB4LRSTSR_SPI6RSTS                    \ SPI6 reset
$00000080 constant RCC_S_RCC_APB4LRSTSR_I2C4RSTS                    \ I2C4 reset
$00000200 constant RCC_S_RCC_APB4LRSTSR_LPTIM2RSTS                  \ LPTIM2 reset
$00000400 constant RCC_S_RCC_APB4LRSTSR_LPTIM3RSTS                  \ LPTIM3 reset
$00000800 constant RCC_S_RCC_APB4LRSTSR_LPTIM4RSTS                  \ LPTIM4 reset
$00001000 constant RCC_S_RCC_APB4LRSTSR_LPTIM5RSTS                  \ LPTIM5 reset
$00008000 constant RCC_S_RCC_APB4LRSTSR_VREFBUFRSTS                 \ VREFBUF reset
$00010000 constant RCC_S_RCC_APB4LRSTSR_RTCRSTS                     \ RTC reset
$00400000 constant RCC_S_RCC_APB4LRSTSR_R2GRETRSTS                  \ R2GRET reset
$00800000 constant RCC_S_RCC_APB4LRSTSR_R2GNPURSTS                  \ R2GNPU reset
$80000000 constant RCC_S_RCC_APB4LRSTSR_SERFRSTS                    \ SERF reset


\
\ @brief RCC APB4H reset register
\ Address offset: 0xA38
\ Reset value: 0x00000000
\

$00000001 constant RCC_S_RCC_APB4HRSTSR_SYSCFGRSTS                  \ SYSCFG reset
$00000004 constant RCC_S_RCC_APB4HRSTSR_DTSRSTS                     \ DTS reset
$00000010 constant RCC_S_RCC_APB4HRSTSR_BUSPERFMRSTS                \ BUSPERFM reset


\
\ @brief RCC APB5 reset register
\ Address offset: 0xA3C
\ Reset value: 0x00000000
\

$00000002 constant RCC_S_RCC_APB5RSTSR_LTDCRSTS                     \ LTDC reset
$00000004 constant RCC_S_RCC_APB5RSTSR_DCMIPPRSTS                   \ DCMIPP reset
$00000010 constant RCC_S_RCC_APB5RSTSR_GFXTIMRSTS                   \ GFXTIM reset
$00000020 constant RCC_S_RCC_APB5RSTSR_VENCRSTS                     \ VENC reset
$00000040 constant RCC_S_RCC_APB5RSTSR_CSIRSTS                      \ CSI reset


\
\ @brief RCC Divider enable register
\ Address offset: 0xA40
\ Reset value: 0x00000000
\

$00000001 constant RCC_S_RCC_DIVENSR_IC1ENS                         \ IC1 enable
$00000002 constant RCC_S_RCC_DIVENSR_IC2ENS                         \ IC2 enable
$00000004 constant RCC_S_RCC_DIVENSR_IC3ENS                         \ IC3 enable
$00000008 constant RCC_S_RCC_DIVENSR_IC4ENS                         \ IC4 enable
$00000010 constant RCC_S_RCC_DIVENSR_IC5ENS                         \ IC5 enable
$00000020 constant RCC_S_RCC_DIVENSR_IC6ENS                         \ IC6 enable
$00000040 constant RCC_S_RCC_DIVENSR_IC7ENS                         \ IC7 enable
$00000080 constant RCC_S_RCC_DIVENSR_IC8ENS                         \ IC8 enable
$00000100 constant RCC_S_RCC_DIVENSR_IC9ENS                         \ IC9 enable
$00000200 constant RCC_S_RCC_DIVENSR_IC10ENS                        \ IC10 enable
$00000400 constant RCC_S_RCC_DIVENSR_IC11ENS                        \ IC11 enable
$00000800 constant RCC_S_RCC_DIVENSR_IC12ENS                        \ IC12 enable
$00001000 constant RCC_S_RCC_DIVENSR_IC13ENS                        \ IC13 enable
$00002000 constant RCC_S_RCC_DIVENSR_IC14ENS                        \ IC14 enable
$00004000 constant RCC_S_RCC_DIVENSR_IC15ENS                        \ IC15 enable
$00008000 constant RCC_S_RCC_DIVENSR_IC16ENS                        \ IC16 enable
$00010000 constant RCC_S_RCC_DIVENSR_IC17ENS                        \ IC17 enable
$00020000 constant RCC_S_RCC_DIVENSR_IC18ENS                        \ IC18 enable
$00040000 constant RCC_S_RCC_DIVENSR_IC19ENS                        \ IC19 enable
$00080000 constant RCC_S_RCC_DIVENSR_IC20ENS                        \ IC20 enable


\
\ @brief RCC bus enable register
\ Address offset: 0xA44
\ Reset value: 0x00000000
\

$00000001 constant RCC_S_RCC_BUSENSR_ACLKNENS                       \ ACLKN enable
$00000002 constant RCC_S_RCC_BUSENSR_ACLKNCENS                      \ ACLKNC enable
$00000004 constant RCC_S_RCC_BUSENSR_AHBMENS                        \ AHBM enable
$00000008 constant RCC_S_RCC_BUSENSR_AHB1ENS                        \ AHB1 enable
$00000010 constant RCC_S_RCC_BUSENSR_AHB2ENS                        \ AHB2 enable
$00000020 constant RCC_S_RCC_BUSENSR_AHB3ENS                        \ AHB3 enable
$00000040 constant RCC_S_RCC_BUSENSR_AHB4ENS                        \ AHB4 enable
$00000080 constant RCC_S_RCC_BUSENSR_AHB5ENS                        \ AHB5 enable
$00000100 constant RCC_S_RCC_BUSENSR_APB1ENS                        \ APB1 enable
$00000200 constant RCC_S_RCC_BUSENSR_APB2ENS                        \ APB2 enable
$00000400 constant RCC_S_RCC_BUSENSR_APB3ENS                        \ APB3 enable
$00000800 constant RCC_S_RCC_BUSENSR_APB4ENS                        \ APB4 enable
$00001000 constant RCC_S_RCC_BUSENSR_APB5ENS                        \ APB5 enable


\
\ @brief RCC miscellaneous enable register
\ Address offset: 0xA48
\ Reset value: 0x00000000
\

$00000001 constant RCC_S_RCC_MISCENSR_DBGENS                        \ DBG enable
$00000002 constant RCC_S_RCC_MISCENSR_MCO1ENS                       \ MCO1 enable
$00000004 constant RCC_S_RCC_MISCENSR_MCO2ENS                       \ MCO2 enable
$00000008 constant RCC_S_RCC_MISCENSR_XSPIPHYCOMPENS                \ XSPIPHYCOMP enable
$00000040 constant RCC_S_RCC_MISCENSR_PERENS                        \ PER enable


\
\ @brief RCC memory enable register
\ Address offset: 0xA4C
\ Reset value: 0x00000000
\

$00000001 constant RCC_S_RCC_MEMENSR_AXISRAM3ENS                    \ AXISRAM3 enable
$00000002 constant RCC_S_RCC_MEMENSR_AXISRAM4ENS                    \ AXISRAM4 enable
$00000004 constant RCC_S_RCC_MEMENSR_AXISRAM5ENS                    \ AXISRAM5 enable
$00000008 constant RCC_S_RCC_MEMENSR_AXISRAM6ENS                    \ AXISRAM6 enable
$00000010 constant RCC_S_RCC_MEMENSR_AHBSRAM1ENS                    \ AHBSRAM1 enable
$00000020 constant RCC_S_RCC_MEMENSR_AHBSRAM2ENS                    \ AHBSRAM2 enable
$00000040 constant RCC_S_RCC_MEMENSR_BKPSRAMENS                     \ BKPSRAM enable
$00000080 constant RCC_S_RCC_MEMENSR_AXISRAM1ENS                    \ AXISRAM1 enable
$00000100 constant RCC_S_RCC_MEMENSR_AXISRAM2ENS                    \ AXISRAM2 enable
$00000200 constant RCC_S_RCC_MEMENSR_FLEXRAMENS                     \ FLEXRAM enable
$00000400 constant RCC_S_RCC_MEMENSR_NPUCACHERAMENS                 \ NPUCACHERAM enable
$00000800 constant RCC_S_RCC_MEMENSR_VENCRAMENS                     \ VENCRAM enable
$00001000 constant RCC_S_RCC_MEMENSR_BOOTROMENS                     \ BOOTROM enable


\
\ @brief RCC AHB1 enable register
\ Address offset: 0xA50
\ Reset value: 0x00000000
\

$00000010 constant RCC_S_RCC_AHB1ENSR_GPDMA1ENS                     \ GPDMA1 enable
$00000020 constant RCC_S_RCC_AHB1ENSR_ADC12ENS                      \ ADC12 enable


\
\ @brief RCC AHB2 enable register
\ Address offset: 0xA54
\ Reset value: 0x00000000
\

$00001000 constant RCC_S_RCC_AHB2ENSR_RAMCFGENS                     \ RAMCFG enable
$00010000 constant RCC_S_RCC_AHB2ENSR_MDF1ENS                       \ MDF1 enable
$00020000 constant RCC_S_RCC_AHB2ENSR_ADF1ENS                       \ ADF1 enable


\
\ @brief RCC AHB3 enable register
\ Address offset: 0xA58
\ Reset value: 0x00000000
\

$00000001 constant RCC_S_RCC_AHB3ENSR_RNGENS                        \ RNG enable
$00000002 constant RCC_S_RCC_AHB3ENSR_HASHENS                       \ HASH enable
$00000004 constant RCC_S_RCC_AHB3ENSR_CRYPENS                       \ CRYP enable
$00000010 constant RCC_S_RCC_AHB3ENSR_SAESENS                       \ SAES enable
$00000100 constant RCC_S_RCC_AHB3ENSR_PKAENS                        \ PKA enable
$00000200 constant RCC_S_RCC_AHB3ENSR_RIFSCENS                      \ RIFSC enable
$00000400 constant RCC_S_RCC_AHB3ENSR_IACENS                        \ IAC enable
$00004000 constant RCC_S_RCC_AHB3ENSR_RISAFENS                      \ RISAF enable


\
\ @brief RCC AHB4 enable register
\ Address offset: 0xA5C
\ Reset value: 0x00000000
\

$00000001 constant RCC_S_RCC_AHB4ENSR_GPIOAENS                      \ GPIOA enable
$00000002 constant RCC_S_RCC_AHB4ENSR_GPIOBENS                      \ GPIOB enable
$00000004 constant RCC_S_RCC_AHB4ENSR_GPIOCENS                      \ GPIOC enable
$00000008 constant RCC_S_RCC_AHB4ENSR_GPIODENS                      \ GPIOD enable
$00000010 constant RCC_S_RCC_AHB4ENSR_GPIOEENS                      \ GPIOE enable
$00000020 constant RCC_S_RCC_AHB4ENSR_GPIOFENS                      \ GPIOF enable
$00000040 constant RCC_S_RCC_AHB4ENSR_GPIOGENS                      \ GPIOG enable
$00000080 constant RCC_S_RCC_AHB4ENSR_GPIOHENS                      \ GPIOH enable
$00002000 constant RCC_S_RCC_AHB4ENSR_GPIONENS                      \ GPION enable
$00004000 constant RCC_S_RCC_AHB4ENSR_GPIOOENS                      \ GPIOO enable
$00008000 constant RCC_S_RCC_AHB4ENSR_GPIOPENS                      \ GPIOP enable
$00010000 constant RCC_S_RCC_AHB4ENSR_GPIOQENS                      \ GPIOQ enable
$00040000 constant RCC_S_RCC_AHB4ENSR_PWRENS                        \ PWR enable
$00080000 constant RCC_S_RCC_AHB4ENSR_CRCENS                        \ CRC enable


\
\ @brief RCC AHB5 enable register
\ Address offset: 0xA60
\ Reset value: 0x00000000
\

$00000001 constant RCC_S_RCC_AHB5ENSR_HPDMA1ENS                     \ HPDMA1 enable
$00000002 constant RCC_S_RCC_AHB5ENSR_DMA2DENS                      \ DMA2D enable
$00000008 constant RCC_S_RCC_AHB5ENSR_JPEGENS                       \ JPEG enable
$00000010 constant RCC_S_RCC_AHB5ENSR_FMCENS                        \ FMC enable
$00000020 constant RCC_S_RCC_AHB5ENSR_XSPI1ENS                      \ XSPI1 enable
$00000040 constant RCC_S_RCC_AHB5ENSR_PSSIENS                       \ PSSI enable
$00000080 constant RCC_S_RCC_AHB5ENSR_SDMMC2ENS                     \ SDMMC2 enable
$00000100 constant RCC_S_RCC_AHB5ENSR_SDMMC1ENS                     \ SDMMC1 enable
$00001000 constant RCC_S_RCC_AHB5ENSR_XSPI2ENS                      \ XSPI2 enable
$00002000 constant RCC_S_RCC_AHB5ENSR_XSPIMENS                      \ XSPIM enable
$00004000 constant RCC_S_RCC_AHB5ENSR_MCE1ENS                       \ MCE1 enable
$00008000 constant RCC_S_RCC_AHB5ENSR_MCE2ENS                       \ MCE2 enable
$00010000 constant RCC_S_RCC_AHB5ENSR_MCE3ENS                       \ MCE3 enable
$00020000 constant RCC_S_RCC_AHB5ENSR_XSPI3ENS                      \ XSPI3 enable
$00040000 constant RCC_S_RCC_AHB5ENSR_MCE4ENS                       \ MCE4 enable
$00080000 constant RCC_S_RCC_AHB5ENSR_GFXMMUENS                     \ GFXMMU enable
$00100000 constant RCC_S_RCC_AHB5ENSR_GPUENS                        \ GPU enable
$00400000 constant RCC_S_RCC_AHB5ENSR_ETH1MACENS                    \ ETH1MAC enable
$00800000 constant RCC_S_RCC_AHB5ENSR_ETH1TXENS                     \ ETH1TX enable
$01000000 constant RCC_S_RCC_AHB5ENSR_ETH1RXENS                     \ ETH1RX enable
$02000000 constant RCC_S_RCC_AHB5ENSR_ETH1ENS                       \ ETH1 enable
$04000000 constant RCC_S_RCC_AHB5ENSR_OTG1ENS                       \ OTG1 enable
$08000000 constant RCC_S_RCC_AHB5ENSR_OTGPHY1ENS                    \ OTGPHY1 enable
$10000000 constant RCC_S_RCC_AHB5ENSR_OTGPHY2ENS                    \ OTGPHY2 enable
$20000000 constant RCC_S_RCC_AHB5ENSR_OTG2ENS                       \ OTG2 enable
$40000000 constant RCC_S_RCC_AHB5ENSR_NPUCACHEENS                   \ NPUCACHE enable
$80000000 constant RCC_S_RCC_AHB5ENSR_NPUENS                        \ NPU enable


\
\ @brief RCC APB1L enable register
\ Address offset: 0xA64
\ Reset value: 0x00000000
\

$00000001 constant RCC_S_RCC_APB1LENSR_TIM2ENS                      \ TIM2 enable
$00000002 constant RCC_S_RCC_APB1LENSR_TIM3ENS                      \ TIM3 enable
$00000004 constant RCC_S_RCC_APB1LENSR_TIM4ENS                      \ TIM4 enable
$00000008 constant RCC_S_RCC_APB1LENSR_TIM5ENS                      \ TIM5 enable
$00000010 constant RCC_S_RCC_APB1LENSR_TIM6ENS                      \ TIM6 enable
$00000020 constant RCC_S_RCC_APB1LENSR_TIM7ENS                      \ TIM7 enable
$00000040 constant RCC_S_RCC_APB1LENSR_TIM12ENS                     \ TIM12 enable
$00000080 constant RCC_S_RCC_APB1LENSR_TIM13ENS                     \ TIM13 enable
$00000100 constant RCC_S_RCC_APB1LENSR_TIM14ENS                     \ TIM14 enable
$00000200 constant RCC_S_RCC_APB1LENSR_LPTIM1ENS                    \ LPTIM1 enable
$00000800 constant RCC_S_RCC_APB1LENSR_WWDGENS                      \ WWDG enable
$00001000 constant RCC_S_RCC_APB1LENSR_TIM10ENS                     \ TIM10 enable
$00002000 constant RCC_S_RCC_APB1LENSR_TIM11ENS                     \ TIM11 enable
$00004000 constant RCC_S_RCC_APB1LENSR_SPI2ENS                      \ SPI2 enable
$00008000 constant RCC_S_RCC_APB1LENSR_SPI3ENS                      \ SPI3 enable
$00010000 constant RCC_S_RCC_APB1LENSR_SPDIFRX1ENS                  \ SPDIFRX1 enable
$00020000 constant RCC_S_RCC_APB1LENSR_USART2ENS                    \ USART2 enable
$00040000 constant RCC_S_RCC_APB1LENSR_USART3ENS                    \ USART3 enable
$00080000 constant RCC_S_RCC_APB1LENSR_UART4ENS                     \ UART4 enable
$00100000 constant RCC_S_RCC_APB1LENSR_UART5ENS                     \ UART5 enable
$00200000 constant RCC_S_RCC_APB1LENSR_I2C1ENS                      \ I2C1 enable
$00400000 constant RCC_S_RCC_APB1LENSR_I2C2ENS                      \ I2C2 enable
$00800000 constant RCC_S_RCC_APB1LENSR_I2C3ENS                      \ I2C3 enable
$01000000 constant RCC_S_RCC_APB1LENSR_I3C1ENS                      \ I3C1 enable
$02000000 constant RCC_S_RCC_APB1LENSR_I3C2ENS                      \ I3C2 enable
$40000000 constant RCC_S_RCC_APB1LENSR_UART7ENS                     \ UART7 enable
$80000000 constant RCC_S_RCC_APB1LENSR_UART8ENS                     \ UART8 enable


\
\ @brief RCC APB1H enable register
\ Address offset: 0xA68
\ Reset value: 0x00000000
\

$00000020 constant RCC_S_RCC_APB1HENSR_MDIOSENS                     \ MDIOS enable
$00000100 constant RCC_S_RCC_APB1HENSR_FDCANENS                     \ FDCAN enable
$00040000 constant RCC_S_RCC_APB1HENSR_UCPD1ENS                     \ UCPD1 enable


\
\ @brief RCC APB2 enable register
\ Address offset: 0xA6C
\ Reset value: 0x00000000
\

$00000001 constant RCC_S_RCC_APB2ENSR_TIM1ENS                       \ TIM1 enable
$00000002 constant RCC_S_RCC_APB2ENSR_TIM8ENS                       \ TIM8 enable
$00000010 constant RCC_S_RCC_APB2ENSR_USART1ENS                     \ USART1 enable
$00000020 constant RCC_S_RCC_APB2ENSR_USART6ENS                     \ USART6 enable
$00000040 constant RCC_S_RCC_APB2ENSR_UART9ENS                      \ UART9 enable
$00000080 constant RCC_S_RCC_APB2ENSR_USART10ENS                    \ USART10 enable
$00001000 constant RCC_S_RCC_APB2ENSR_SPI1ENS                       \ SPI1 enable
$00002000 constant RCC_S_RCC_APB2ENSR_SPI4ENS                       \ SPI4 enable
$00008000 constant RCC_S_RCC_APB2ENSR_TIM18ENS                      \ TIM18 enable
$00010000 constant RCC_S_RCC_APB2ENSR_TIM15ENS                      \ TIM15 enable
$00020000 constant RCC_S_RCC_APB2ENSR_TIM16ENS                      \ TIM16 enable
$00040000 constant RCC_S_RCC_APB2ENSR_TIM17ENS                      \ TIM17 enable
$00080000 constant RCC_S_RCC_APB2ENSR_TIM9ENS                       \ TIM9 enable
$00100000 constant RCC_S_RCC_APB2ENSR_SPI5ENS                       \ SPI5 enable
$00200000 constant RCC_S_RCC_APB2ENSR_SAI1ENS                       \ SAI1 enable
$00400000 constant RCC_S_RCC_APB2ENSR_SAI2ENS                       \ SAI2 enable


\
\ @brief RCC APB3 enable register
\ Address offset: 0xA70
\ Reset value: 0x00000000
\

$00000004 constant RCC_S_RCC_APB3ENSR_DFTENS                        \ DFT enable


\
\ @brief RCC APB4L enable register
\ Address offset: 0xA74
\ Reset value: 0x00000000
\

$00000004 constant RCC_S_RCC_APB4LENSR_HDPENS                       \ HDP enable
$00000008 constant RCC_S_RCC_APB4LENSR_LPUART1ENS                   \ LPUART1 enable
$00000020 constant RCC_S_RCC_APB4LENSR_SPI6ENS                      \ SPI6 enable
$00000080 constant RCC_S_RCC_APB4LENSR_I2C4ENS                      \ I2C4 enable
$00000200 constant RCC_S_RCC_APB4LENSR_LPTIM2ENS                    \ LPTIM2 enable
$00000400 constant RCC_S_RCC_APB4LENSR_LPTIM3ENS                    \ LPTIM3 enable
$00000800 constant RCC_S_RCC_APB4LENSR_LPTIM4ENS                    \ LPTIM4 enable
$00001000 constant RCC_S_RCC_APB4LENSR_LPTIM5ENS                    \ LPTIM5 enable
$00008000 constant RCC_S_RCC_APB4LENSR_VREFBUFENS                   \ VREFBUF enable
$00010000 constant RCC_S_RCC_APB4LENSR_RTCENS                       \ RTC enable
$00020000 constant RCC_S_RCC_APB4LENSR_RTCAPBENS                    \ RTCAPB enable
$00400000 constant RCC_S_RCC_APB4LENSR_R2GRETENS                    \ R2GRET enable
$00800000 constant RCC_S_RCC_APB4LENSR_R2GNPUENS                    \ R2GNPU enable
$80000000 constant RCC_S_RCC_APB4LENSR_SERFENS                      \ SERF enable


\
\ @brief RCC APB4H enable register
\ Address offset: 0xA78
\ Reset value: 0x00000000
\

$00000001 constant RCC_S_RCC_APB4HENSR_SYSCFGENS                    \ SYSCFG enable
$00000002 constant RCC_S_RCC_APB4HENSR_BSECENS                      \ BSEC enable
$00000004 constant RCC_S_RCC_APB4HENSR_DTSENS                       \ DTS enable
$00000010 constant RCC_S_RCC_APB4HENSR_BUSPERFMENS                  \ BUSPERFM enable


\
\ @brief RCC APB5 enable register
\ Address offset: 0xA7C
\ Reset value: 0x00000000
\

$00000002 constant RCC_S_RCC_APB5ENSR_LTDCENS                       \ LTDC enable
$00000004 constant RCC_S_RCC_APB5ENSR_DCMIPPENS                     \ DCMIPP enable
$00000010 constant RCC_S_RCC_APB5ENSR_GFXTIMENS                     \ GFXTIM enable
$00000020 constant RCC_S_RCC_APB5ENSR_VENCENS                       \ VENC enable
$00000040 constant RCC_S_RCC_APB5ENSR_CSIENS                        \ CSI enable


\
\ @brief RCC divider Sleep enable register
\ Address offset: 0xA80
\ Reset value: 0x00000000
\

$00000001 constant RCC_S_RCC_DIVLPENSR_IC1LPENS                     \ IC1 sleep enable
$00000002 constant RCC_S_RCC_DIVLPENSR_IC2LPENS                     \ IC2 sleep enable
$00000004 constant RCC_S_RCC_DIVLPENSR_IC3LPENS                     \ IC3 sleep enable
$00000008 constant RCC_S_RCC_DIVLPENSR_IC4LPENS                     \ IC4 sleep enable
$00000010 constant RCC_S_RCC_DIVLPENSR_IC5LPENS                     \ IC5 sleep enable
$00000020 constant RCC_S_RCC_DIVLPENSR_IC6LPENS                     \ IC6 sleep enable
$00000040 constant RCC_S_RCC_DIVLPENSR_IC7LPENS                     \ IC7 sleep enable
$00000080 constant RCC_S_RCC_DIVLPENSR_IC8LPENS                     \ IC8 sleep enable
$00000100 constant RCC_S_RCC_DIVLPENSR_IC9LPENS                     \ IC9 sleep enable
$00000200 constant RCC_S_RCC_DIVLPENSR_IC10LPENS                    \ IC10 sleep enable
$00000400 constant RCC_S_RCC_DIVLPENSR_IC11LPENS                    \ IC11 sleep enable
$00000800 constant RCC_S_RCC_DIVLPENSR_IC12LPENS                    \ IC12 sleep enable
$00001000 constant RCC_S_RCC_DIVLPENSR_IC13LPENS                    \ IC13 sleep enable
$00002000 constant RCC_S_RCC_DIVLPENSR_IC14LPENS                    \ IC14 sleep enable
$00004000 constant RCC_S_RCC_DIVLPENSR_IC15LPENS                    \ IC15 sleep enable
$00008000 constant RCC_S_RCC_DIVLPENSR_IC16LPENS                    \ IC16 sleep enable
$00010000 constant RCC_S_RCC_DIVLPENSR_IC17LPENS                    \ IC17 sleep enable
$00020000 constant RCC_S_RCC_DIVLPENSR_IC18LPENS                    \ IC18 sleep enable
$00040000 constant RCC_S_RCC_DIVLPENSR_IC19LPENS                    \ IC19 sleep enable
$00080000 constant RCC_S_RCC_DIVLPENSR_IC20LPENS                    \ IC20 sleep enable


\
\ @brief RCC bus Sleep enable register
\ Address offset: 0xA84
\ Reset value: 0x00000000
\

$00000001 constant RCC_S_RCC_BUSLPENSR_ACLKNLPENS                   \ ACLKN sleep enable
$00000002 constant RCC_S_RCC_BUSLPENSR_ACLKNCLPENS                  \ ACLKNC sleep enable
$00000004 constant RCC_S_RCC_BUSLPENSR_AHBMLPENS                    \ AHBM sleep enable
$00000008 constant RCC_S_RCC_BUSLPENSR_AHB1LPENS                    \ AHB1 sleep enable
$00000010 constant RCC_S_RCC_BUSLPENSR_AHB2LPENS                    \ AHB2 sleep enable
$00000020 constant RCC_S_RCC_BUSLPENSR_AHB3LPENS                    \ AHB3 sleep enable
$00000040 constant RCC_S_RCC_BUSLPENSR_AHB4LPENS                    \ AHB4 sleep enable
$00000080 constant RCC_S_RCC_BUSLPENSR_AHB5LPENS                    \ AHB5 sleep enable
$00000100 constant RCC_S_RCC_BUSLPENSR_APB1LPENS                    \ APB1 sleep enable
$00000200 constant RCC_S_RCC_BUSLPENSR_APB2LPENS                    \ APB2 sleep enable
$00000400 constant RCC_S_RCC_BUSLPENSR_APB3LPENS                    \ APB3 sleep enable
$00000800 constant RCC_S_RCC_BUSLPENSR_APB4LPENS                    \ APB4 sleep enable
$00001000 constant RCC_S_RCC_BUSLPENSR_APB5LPENS                    \ APB5 sleep enable


\
\ @brief RCC miscellaneous Sleep enable register
\ Address offset: 0xA88
\ Reset value: 0x00000000
\

$00000001 constant RCC_S_RCC_MISCLPENSR_DBGLPENS                    \ DBG sleep enable
$00000008 constant RCC_S_RCC_MISCLPENSR_XSPIPHYCOMPLPENS            \ XSPIPHYCOMP sleep enable
$00000040 constant RCC_S_RCC_MISCLPENSR_PERLPENS                    \ PER sleep enable


\
\ @brief RCC memory sleep enable register
\ Address offset: 0xA8C
\ Reset value: 0x00000000
\

$00000001 constant RCC_S_RCC_MEMLPENSR_AXISRAM3LPENS                \ AXISRAM3 sleep enable
$00000002 constant RCC_S_RCC_MEMLPENSR_AXISRAM4LPENS                \ AXISRAM4 sleep enable
$00000004 constant RCC_S_RCC_MEMLPENSR_AXISRAM5LPENS                \ AXISRAM5 sleep enable
$00000008 constant RCC_S_RCC_MEMLPENSR_AXISRAM6LPENS                \ AXISRAM6 sleep enable
$00000010 constant RCC_S_RCC_MEMLPENSR_AHBSRAM1LPENS                \ AHBSRAM1 sleep enable
$00000020 constant RCC_S_RCC_MEMLPENSR_AHBSRAM2LPENS                \ AHBSRAM2 sleep enable
$00000040 constant RCC_S_RCC_MEMLPENSR_BKPSRAMLPENS                 \ BKPSRAM sleep enable
$00000080 constant RCC_S_RCC_MEMLPENSR_AXISRAM1LPENS                \ AXISRAM1 sleep enable
$00000100 constant RCC_S_RCC_MEMLPENSR_AXISRAM2LPENS                \ AXISRAM2 sleep enable
$00000200 constant RCC_S_RCC_MEMLPENSR_FLEXRAMLPENS                 \ FLEXRAM sleep enable
$00000400 constant RCC_S_RCC_MEMLPENSR_NPUCACHERAMLPENS             \ NPUCACHERAM sleep enable
$00000800 constant RCC_S_RCC_MEMLPENSR_VENCRAMLPENS                 \ VENCRAM sleep enable
$00001000 constant RCC_S_RCC_MEMLPENSR_BOOTROMLPENS                 \ BOOTROM sleep enable


\
\ @brief RCC AHB1 Sleep enable register
\ Address offset: 0xA90
\ Reset value: 0x00000000
\

$00000010 constant RCC_S_RCC_AHB1LPENSR_GPDMA1LPENS                 \ GPDMA1 sleep enable
$00000020 constant RCC_S_RCC_AHB1LPENSR_ADC12LPENS                  \ ADC12 sleep enable


\
\ @brief RCC AHB2 Sleep enable register
\ Address offset: 0xA94
\ Reset value: 0x00000000
\

$00001000 constant RCC_S_RCC_AHB2LPENSR_RAMCFGLPENS                 \ RAMCFG sleep enable
$00010000 constant RCC_S_RCC_AHB2LPENSR_MDF1LPENS                   \ MDF1 sleep enable
$00020000 constant RCC_S_RCC_AHB2LPENSR_ADF1LPENS                   \ ADF1 sleep enable


\
\ @brief RCC AHB3 Sleep enable register
\ Address offset: 0xA98
\ Reset value: 0x00000000
\

$00000001 constant RCC_S_RCC_AHB3LPENSR_RNGLPENS                    \ RNG sleep enable
$00000002 constant RCC_S_RCC_AHB3LPENSR_HASHLPENS                   \ HASH sleep enable
$00000004 constant RCC_S_RCC_AHB3LPENSR_CRYPLPENS                   \ CRYP sleep enable
$00000010 constant RCC_S_RCC_AHB3LPENSR_SAESLPENS                   \ SAES sleep enable
$00000100 constant RCC_S_RCC_AHB3LPENSR_PKALPENS                    \ PKA sleep enable
$00000200 constant RCC_S_RCC_AHB3LPENSR_RIFSCLPENS                  \ RIFSC sleep enable
$00000400 constant RCC_S_RCC_AHB3LPENSR_IACLPENS                    \ IAC sleep enable
$00004000 constant RCC_S_RCC_AHB3LPENSR_RISAFLPENS                  \ RISAF sleep enable


\
\ @brief RCC AHB4 Sleep enable register
\ Address offset: 0xA9C
\ Reset value: 0x00000000
\

$00000001 constant RCC_S_RCC_AHB4LPENSR_GPIOALPENS                  \ GPIOA sleep enable
$00000002 constant RCC_S_RCC_AHB4LPENSR_GPIOBLPENS                  \ GPIOB sleep enable
$00000004 constant RCC_S_RCC_AHB4LPENSR_GPIOCLPENS                  \ GPIOC sleep enable
$00000008 constant RCC_S_RCC_AHB4LPENSR_GPIODLPENS                  \ GPIOD sleep enable
$00000010 constant RCC_S_RCC_AHB4LPENSR_GPIOELPENS                  \ GPIOE sleep enable
$00000020 constant RCC_S_RCC_AHB4LPENSR_GPIOFLPENS                  \ GPIOF sleep enable
$00000040 constant RCC_S_RCC_AHB4LPENSR_GPIOGLPENS                  \ GPIOG sleep enable
$00000080 constant RCC_S_RCC_AHB4LPENSR_GPIOHLPENS                  \ GPIOH sleep enable
$00002000 constant RCC_S_RCC_AHB4LPENSR_GPIONLPENS                  \ GPION sleep enable
$00004000 constant RCC_S_RCC_AHB4LPENSR_GPIOOLPENS                  \ GPIOO sleep enable
$00008000 constant RCC_S_RCC_AHB4LPENSR_GPIOPLPENS                  \ GPIOP sleep enable
$00010000 constant RCC_S_RCC_AHB4LPENSR_GPIOQLPENS                  \ GPIOQ sleep enable
$00040000 constant RCC_S_RCC_AHB4LPENSR_PWRLPENS                    \ PWR sleep enable
$00080000 constant RCC_S_RCC_AHB4LPENSR_CRCLPENS                    \ CRC sleep enable


\
\ @brief RCC AHB5 Sleep enable register
\ Address offset: 0xAA0
\ Reset value: 0x00000000
\

$00000001 constant RCC_S_RCC_AHB5LPENSR_HPDMA1LPENS                 \ HPDMA1 sleep enable
$00000002 constant RCC_S_RCC_AHB5LPENSR_DMA2DLPENS                  \ DMA2D sleep enable
$00000008 constant RCC_S_RCC_AHB5LPENSR_JPEGLPENS                   \ JPEG sleep enable
$00000010 constant RCC_S_RCC_AHB5LPENSR_FMCLPENS                    \ FMC sleep enable
$00000020 constant RCC_S_RCC_AHB5LPENSR_XSPI1LPENS                  \ XSPI1 sleep enable
$00000040 constant RCC_S_RCC_AHB5LPENSR_PSSILPENS                   \ PSSI sleep enable
$00000080 constant RCC_S_RCC_AHB5LPENSR_SDMMC2LPENS                 \ SDMMC2 sleep enable
$00000100 constant RCC_S_RCC_AHB5LPENSR_SDMMC1LPENS                 \ SDMMC1 sleep enable
$00001000 constant RCC_S_RCC_AHB5LPENSR_XSPI2LPENS                  \ XSPI2 sleep enable
$00002000 constant RCC_S_RCC_AHB5LPENSR_XSPIMLPENS                  \ XSPIM sleep enable
$00004000 constant RCC_S_RCC_AHB5LPENSR_MCE1LPENS                   \ MCE1 sleep enable
$00008000 constant RCC_S_RCC_AHB5LPENSR_MCE2LPENS                   \ MCE2 sleep enable
$00010000 constant RCC_S_RCC_AHB5LPENSR_MCE3LPENS                   \ MCE3 sleep enable
$00020000 constant RCC_S_RCC_AHB5LPENSR_XSPI3LPENS                  \ XSPI3 sleep enable
$00040000 constant RCC_S_RCC_AHB5LPENSR_MCE4LPENS                   \ MCE4 sleep enable
$00080000 constant RCC_S_RCC_AHB5LPENSR_GFXMMULPENS                 \ GFXMMU sleep enable
$00100000 constant RCC_S_RCC_AHB5LPENSR_GPULPENS                    \ GPU sleep enable
$00400000 constant RCC_S_RCC_AHB5LPENSR_ETH1MACLPENS                \ ETH1MAC sleep enable
$00800000 constant RCC_S_RCC_AHB5LPENSR_ETH1TXLPENS                 \ ETH1TX sleep enable
$01000000 constant RCC_S_RCC_AHB5LPENSR_ETH1RXLPENS                 \ ETH1RX sleep enable
$02000000 constant RCC_S_RCC_AHB5LPENSR_ETH1LPENS                   \ ETH1 sleep enable
$04000000 constant RCC_S_RCC_AHB5LPENSR_OTG1LPENS                   \ OTG1 sleep enable
$08000000 constant RCC_S_RCC_AHB5LPENSR_OTGPHY1LPENS                \ OTGPHY1 sleep enable
$10000000 constant RCC_S_RCC_AHB5LPENSR_OTGPHY2LPENS                \ OTGPHY2 sleep enable
$20000000 constant RCC_S_RCC_AHB5LPENSR_OTG2LPENS                   \ OTG2 sleep enable
$40000000 constant RCC_S_RCC_AHB5LPENSR_NPUCACHELPENS               \ NPUCACHE sleep enable
$80000000 constant RCC_S_RCC_AHB5LPENSR_NPULPENS                    \ NPU sleep enable


\
\ @brief RCC APB1L Sleep enable register
\ Address offset: 0xAA4
\ Reset value: 0x00000000
\

$00000001 constant RCC_S_RCC_APB1LLPENSR_TIM2LPENS                  \ TIM2 sleep enable
$00000002 constant RCC_S_RCC_APB1LLPENSR_TIM3LPENS                  \ TIM3 sleep enable
$00000004 constant RCC_S_RCC_APB1LLPENSR_TIM4LPENS                  \ TIM4 sleep enable
$00000008 constant RCC_S_RCC_APB1LLPENSR_TIM5LPENS                  \ TIM5 sleep enable
$00000010 constant RCC_S_RCC_APB1LLPENSR_TIM6LPENS                  \ TIM6 sleep enable
$00000020 constant RCC_S_RCC_APB1LLPENSR_TIM7LPENS                  \ TIM7 sleep enable
$00000040 constant RCC_S_RCC_APB1LLPENSR_TIM12LPENS                 \ TIM12 sleep enable
$00000080 constant RCC_S_RCC_APB1LLPENSR_TIM13LPENS                 \ TIM13 sleep enable
$00000100 constant RCC_S_RCC_APB1LLPENSR_TIM14LPENS                 \ TIM14 sleep enable
$00000200 constant RCC_S_RCC_APB1LLPENSR_LPTIM1LPENS                \ LPTIM1 sleep enable
$00000800 constant RCC_S_RCC_APB1LLPENSR_WWDGLPENS                  \ WWDG sleep enable
$00001000 constant RCC_S_RCC_APB1LLPENSR_TIM10LPENS                 \ TIM10 sleep enable
$00002000 constant RCC_S_RCC_APB1LLPENSR_TIM11LPENS                 \ TIM11 sleep enable
$00004000 constant RCC_S_RCC_APB1LLPENSR_SPI2LPENS                  \ SPI2 sleep enable
$00008000 constant RCC_S_RCC_APB1LLPENSR_SPI3LPENS                  \ SPI3 sleep enable
$00010000 constant RCC_S_RCC_APB1LLPENSR_SPDIFRX1LPENS              \ SPDIFRX1 sleep enable
$00020000 constant RCC_S_RCC_APB1LLPENSR_USART2LPENS                \ USART2 sleep enable
$00040000 constant RCC_S_RCC_APB1LLPENSR_USART3LPENS                \ USART3 sleep enable
$00080000 constant RCC_S_RCC_APB1LLPENSR_UART4LPENS                 \ UART4 sleep enable
$00100000 constant RCC_S_RCC_APB1LLPENSR_UART5LPENS                 \ UART5 sleep enable
$00200000 constant RCC_S_RCC_APB1LLPENSR_I2C1LPENS                  \ I2C1 sleep enable
$00400000 constant RCC_S_RCC_APB1LLPENSR_I2C2LPENS                  \ I2C2 sleep enable
$00800000 constant RCC_S_RCC_APB1LLPENSR_I2C3LPENS                  \ I2C3 sleep enable
$01000000 constant RCC_S_RCC_APB1LLPENSR_I3C1LPENS                  \ I3C1 sleep enable
$02000000 constant RCC_S_RCC_APB1LLPENSR_I3C2LPENS                  \ I3C2 sleep enable
$40000000 constant RCC_S_RCC_APB1LLPENSR_UART7LPENS                 \ UART7 sleep enable
$80000000 constant RCC_S_RCC_APB1LLPENSR_UART8LPENS                 \ UART8 sleep enable


\
\ @brief RCC APB1H Sleep enable register
\ Address offset: 0xAA8
\ Reset value: 0x00000000
\

$00000020 constant RCC_S_RCC_APB1HLPENSR_MDIOSLPENS                 \ MDIOS sleep enable
$00000100 constant RCC_S_RCC_APB1HLPENSR_FDCANLPENS                 \ FDCAN sleep enable
$00040000 constant RCC_S_RCC_APB1HLPENSR_UCPD1LPENS                 \ UCPD1 sleep enable


\
\ @brief RCC APB2 Sleep enable register
\ Address offset: 0xAAC
\ Reset value: 0x00000000
\

$00000001 constant RCC_S_RCC_APB2LPENSR_TIM1LPENS                   \ TIM1 sleep enable
$00000002 constant RCC_S_RCC_APB2LPENSR_TIM8LPENS                   \ TIM8 sleep enable
$00000010 constant RCC_S_RCC_APB2LPENSR_USART1LPENS                 \ USART1 sleep enable
$00000020 constant RCC_S_RCC_APB2LPENSR_USART6LPENS                 \ USART6 sleep enable
$00000040 constant RCC_S_RCC_APB2LPENSR_UART9LPENS                  \ UART9 sleep enable
$00000080 constant RCC_S_RCC_APB2LPENSR_USART10LPENS                \ USART10 sleep enable
$00001000 constant RCC_S_RCC_APB2LPENSR_SPI1LPENS                   \ SPI1 sleep enable
$00002000 constant RCC_S_RCC_APB2LPENSR_SPI4LPENS                   \ SPI4 sleep enable
$00008000 constant RCC_S_RCC_APB2LPENSR_TIM18LPENS                  \ TIM18 sleep enable
$00010000 constant RCC_S_RCC_APB2LPENSR_TIM15LPENS                  \ TIM15 sleep enable
$00020000 constant RCC_S_RCC_APB2LPENSR_TIM16LPENS                  \ TIM16 sleep enable
$00040000 constant RCC_S_RCC_APB2LPENSR_TIM17LPENS                  \ TIM17 sleep enable
$00080000 constant RCC_S_RCC_APB2LPENSR_TIM9LPENS                   \ TIM9 sleep enable
$00100000 constant RCC_S_RCC_APB2LPENSR_SPI5LPENS                   \ SPI5 sleep enable
$00200000 constant RCC_S_RCC_APB2LPENSR_SAI1LPENS                   \ SAI1 sleep enable
$00400000 constant RCC_S_RCC_APB2LPENSR_SAI2LPENS                   \ SAI2 sleep enable


\
\ @brief RCC APB3 Sleep enable register
\ Address offset: 0xAB0
\ Reset value: 0x00000000
\

$00000004 constant RCC_S_RCC_APB3LPENSR_DFTLPENS                    \ DFT sleep enable


\
\ @brief RCC APB4L Sleep enable register
\ Address offset: 0xAB4
\ Reset value: 0x00000000
\

$00000004 constant RCC_S_RCC_APB4LLPENSR_HDPLPENS                   \ HDP sleep enable
$00000008 constant RCC_S_RCC_APB4LLPENSR_LPUART1LPENS               \ LPUART1 sleep enable
$00000020 constant RCC_S_RCC_APB4LLPENSR_SPI6LPENS                  \ SPI6 sleep enable
$00000080 constant RCC_S_RCC_APB4LLPENSR_I2C4LPENS                  \ I2C4 sleep enable
$00000200 constant RCC_S_RCC_APB4LLPENSR_LPTIM2LPENS                \ LPTIM2 sleep enable
$00000400 constant RCC_S_RCC_APB4LLPENSR_LPTIM3LPENS                \ LPTIM3 sleep enable
$00000800 constant RCC_S_RCC_APB4LLPENSR_LPTIM4LPENS                \ LPTIM4 sleep enable
$00001000 constant RCC_S_RCC_APB4LLPENSR_LPTIM5LPENS                \ LPTIM5 sleep enable
$00008000 constant RCC_S_RCC_APB4LLPENSR_VREFBUFLPENS               \ VREFBUF sleep enable
$00010000 constant RCC_S_RCC_APB4LLPENSR_RTCLPENS                   \ RTC sleep enable
$00020000 constant RCC_S_RCC_APB4LLPENSR_RTCAPBLPENS                \ RTCAPB sleep enable
$00400000 constant RCC_S_RCC_APB4LLPENSR_R2GRETLPENS                \ R2GRET sleep enable
$00800000 constant RCC_S_RCC_APB4LLPENSR_R2GNPULPENS                \ R2GNPU sleep enable
$80000000 constant RCC_S_RCC_APB4LLPENSR_SERFLPENS                  \ SERF sleep enable


\
\ @brief RCC APB4H Sleep enable register
\ Address offset: 0xAB8
\ Reset value: 0x00000000
\

$00000001 constant RCC_S_RCC_APB4HLPENSR_SYSCFGLPENS                \ SYSCFG sleep enable
$00000002 constant RCC_S_RCC_APB4HLPENSR_BSECLPENS                  \ BSEC sleep enable
$00000004 constant RCC_S_RCC_APB4HLPENSR_DTSLPENS                   \ DTS sleep enable
$00000010 constant RCC_S_RCC_APB4HLPENSR_BUSPERFMLPENS              \ BUSPERFM sleep enable


\
\ @brief RCC APB5 Sleep enable register
\ Address offset: 0xABC
\ Reset value: 0x00000000
\

$00000002 constant RCC_S_RCC_APB5LPENSR_LTDCLPENS                   \ LTDC sleep enable
$00000004 constant RCC_S_RCC_APB5LPENSR_DCMIPPLPENS                 \ DCMIPP sleep enable
$00000010 constant RCC_S_RCC_APB5LPENSR_GFXTIMLPENS                 \ GFXTIM sleep enable
$00000020 constant RCC_S_RCC_APB5LPENSR_VENCLPENS                   \ VENC sleep enable
$00000040 constant RCC_S_RCC_APB5LPENSR_CSILPENS                    \ CSI sleep enable


\
\ @brief RCC oscillator privilege configuration register0
\ Address offset: 0xF84
\ Reset value: 0x00000000
\

$00000001 constant RCC_S_RCC_PRIVCFGSR0_LSIPVS                      \ Defines the privilege protection of the LSI configuration bits (enable, ready, divider).
$00000002 constant RCC_S_RCC_PRIVCFGSR0_LSEPVS                      \ Defines the privilege protection of the LSE configuration bits (enable, ready, divider).
$00000004 constant RCC_S_RCC_PRIVCFGSR0_MSIPVS                      \ Defines the privilege protection of the MSI configuration bits (enable, ready, divider).
$00000008 constant RCC_S_RCC_PRIVCFGSR0_HSIPVS                      \ Defines the privilege protection of the HSI configuration bits (enable, ready, divider).
$00000010 constant RCC_S_RCC_PRIVCFGSR0_HSEPVS                      \ Defines the privilege protection of the HSE configuration bits (enable, ready, divider).


\
\ @brief RCC oscillator public configuration register0
\ Address offset: 0xF8C
\ Reset value: 0x00000000
\

$00000001 constant RCC_S_RCC_PUBCFGSR0_LSIPUBS                      \ Defines the public protection of the LSI configuration bits (enable, ready, divider).
$00000002 constant RCC_S_RCC_PUBCFGSR0_LSEPUBS                      \ Defines the public protection of the LSE configuration bits (enable, ready, divider).
$00000004 constant RCC_S_RCC_PUBCFGSR0_MSIPUBS                      \ Defines the public protection of the MSI configuration bits (enable, ready, divider).
$00000008 constant RCC_S_RCC_PUBCFGSR0_HSIPUBS                      \ Defines the public protection of the HSI configuration bits (enable, ready, divider).
$00000010 constant RCC_S_RCC_PUBCFGSR0_HSEPUBS                      \ Defines the public protection of the HSE configuration bits (enable, ready, divider).


\
\ @brief RCC PLL privilege configuration register1
\ Address offset: 0xF94
\ Reset value: 0x00000000
\

$00000001 constant RCC_S_RCC_PRIVCFGSR1_PLL1PVS                     \ Defines the privilege protection of the PLL1 configuration bits (enable, ready, divider).
$00000002 constant RCC_S_RCC_PRIVCFGSR1_PLL2PVS                     \ Defines the privilege protection of the PLL2 configuration bits (enable, ready, divider).
$00000004 constant RCC_S_RCC_PRIVCFGSR1_PLL3PVS                     \ Defines the privilege protection of the PLL3 configuration bits (enable, ready, divider).
$00000008 constant RCC_S_RCC_PRIVCFGSR1_PLL4PVS                     \ Defines the privilege protection of the PLL4 configuration bits (enable, ready, divider).


\
\ @brief RCC PLL public configuration register1
\ Address offset: 0xF9C
\ Reset value: 0x00000000
\

$00000001 constant RCC_S_RCC_PUBCFGSR1_PLL1PUBS                     \ Defines the public protection of the PLL1 configuration bits (enable, ready, divider).
$00000002 constant RCC_S_RCC_PUBCFGSR1_PLL2PUBS                     \ Defines the public protection of the PLL2 configuration bits (enable, ready, divider).
$00000004 constant RCC_S_RCC_PUBCFGSR1_PLL3PUBS                     \ Defines the public protection of the PLL3 configuration bits (enable, ready, divider).
$00000008 constant RCC_S_RCC_PUBCFGSR1_PLL4PUBS                     \ Defines the public protection of the PLL4 configuration bits (enable, ready, divider).


\
\ @brief RCC divider privilege configuration register2
\ Address offset: 0xFA4
\ Reset value: 0x00000000
\

$00000001 constant RCC_S_RCC_PRIVCFGSR2_IC1PVS                      \ Defines the privilege protection of the IC1 configuration bits (enable, ready, divider).
$00000002 constant RCC_S_RCC_PRIVCFGSR2_IC2PVS                      \ Defines the privilege protection of the IC2 configuration bits (enable, ready, divider).
$00000004 constant RCC_S_RCC_PRIVCFGSR2_IC3PVS                      \ Defines the privilege protection of the IC3 configuration bits (enable, ready, divider).
$00000008 constant RCC_S_RCC_PRIVCFGSR2_IC4PVS                      \ Defines the privilege protection of the IC4 configuration bits (enable, ready, divider).
$00000010 constant RCC_S_RCC_PRIVCFGSR2_IC5PVS                      \ Defines the privilege protection of the IC5 configuration bits (enable, ready, divider).
$00000020 constant RCC_S_RCC_PRIVCFGSR2_IC6PVS                      \ Defines the privilege protection of the IC6 configuration bits (enable, ready, divider).
$00000040 constant RCC_S_RCC_PRIVCFGSR2_IC7PVS                      \ Defines the privilege protection of the IC7 configuration bits (enable, ready, divider).
$00000080 constant RCC_S_RCC_PRIVCFGSR2_IC8PVS                      \ Defines the privilege protection of the IC8 configuration bits (enable, ready, divider).
$00000100 constant RCC_S_RCC_PRIVCFGSR2_IC9PVS                      \ Defines the privilege protection of the IC9 configuration bits (enable, ready, divider).
$00000200 constant RCC_S_RCC_PRIVCFGSR2_IC10PVS                     \ Defines the privilege protection of the IC10 configuration bits (enable, ready, divider).
$00000400 constant RCC_S_RCC_PRIVCFGSR2_IC11PVS                     \ Defines the privilege protection of the IC11 configuration bits (enable, ready, divider).
$00000800 constant RCC_S_RCC_PRIVCFGSR2_IC12PVS                     \ Defines the privilege protection of the IC12 configuration bits (enable, ready, divider).
$00001000 constant RCC_S_RCC_PRIVCFGSR2_IC13PVS                     \ Defines the privilege protection of the IC13 configuration bits (enable, ready, divider).
$00002000 constant RCC_S_RCC_PRIVCFGSR2_IC14PVS                     \ Defines the privilege protection of the IC14 configuration bits (enable, ready, divider).
$00004000 constant RCC_S_RCC_PRIVCFGSR2_IC15PVS                     \ Defines the privilege protection of the IC15 configuration bits (enable, ready, divider).
$00008000 constant RCC_S_RCC_PRIVCFGSR2_IC16PVS                     \ Defines the privilege protection of the IC16 configuration bits (enable, ready, divider).
$00010000 constant RCC_S_RCC_PRIVCFGSR2_IC17PVS                     \ Defines the privilege protection of the IC17 configuration bits (enable, ready, divider).
$00020000 constant RCC_S_RCC_PRIVCFGSR2_IC18PVS                     \ Defines the privilege protection of the IC18 configuration bits (enable, ready, divider).
$00040000 constant RCC_S_RCC_PRIVCFGSR2_IC19PVS                     \ Defines the privilege protection of the IC19 configuration bits (enable, ready, divider).
$00080000 constant RCC_S_RCC_PRIVCFGSR2_IC20PVS                     \ Defines the privilege protection of the IC20 configuration bits (enable, ready, divider).


\
\ @brief RCC divider public configuration register2
\ Address offset: 0xFAC
\ Reset value: 0x00000000
\

$00000001 constant RCC_S_RCC_PUBCFGSR2_IC1PUBS                      \ Defines the public protection of the IC1 configuration bits (enable, ready, divider).
$00000002 constant RCC_S_RCC_PUBCFGSR2_IC2PUBS                      \ Defines the public protection of the IC2 configuration bits (enable, ready, divider).
$00000004 constant RCC_S_RCC_PUBCFGSR2_IC3PUBS                      \ Defines the public protection of the IC3 configuration bits (enable, ready, divider).
$00000008 constant RCC_S_RCC_PUBCFGSR2_IC4PUBS                      \ Defines the public protection of the IC4 configuration bits (enable, ready, divider).
$00000010 constant RCC_S_RCC_PUBCFGSR2_IC5PUBS                      \ Defines the public protection of the IC5 configuration bits (enable, ready, divider).
$00000020 constant RCC_S_RCC_PUBCFGSR2_IC6PUBS                      \ Defines the public protection of the IC6 configuration bits (enable, ready, divider).
$00000040 constant RCC_S_RCC_PUBCFGSR2_IC7PUBS                      \ Defines the public protection of the IC7 configuration bits (enable, ready, divider).
$00000080 constant RCC_S_RCC_PUBCFGSR2_IC8PUBS                      \ Defines the public protection of the IC8 configuration bits (enable, ready, divider).
$00000100 constant RCC_S_RCC_PUBCFGSR2_IC9PUBS                      \ Defines the public protection of the IC9 configuration bits (enable, ready, divider).
$00000200 constant RCC_S_RCC_PUBCFGSR2_IC10PUBS                     \ Defines the public protection of the IC10 configuration bits (enable, ready, divider).
$00000400 constant RCC_S_RCC_PUBCFGSR2_IC11PUBS                     \ Defines the public protection of the IC11 configuration bits (enable, ready, divider).
$00000800 constant RCC_S_RCC_PUBCFGSR2_IC12PUBS                     \ Defines the public protection of the IC12 configuration bits (enable, ready, divider).
$00001000 constant RCC_S_RCC_PUBCFGSR2_IC13PUBS                     \ Defines the public protection of the IC13 configuration bits (enable, ready, divider).
$00002000 constant RCC_S_RCC_PUBCFGSR2_IC14PUBS                     \ Defines the public protection of the IC14 configuration bits (enable, ready, divider).
$00004000 constant RCC_S_RCC_PUBCFGSR2_IC15PUBS                     \ Defines the public protection of the IC15 configuration bits (enable, ready, divider).
$00008000 constant RCC_S_RCC_PUBCFGSR2_IC16PUBS                     \ Defines the public protection of the IC16 configuration bits (enable, ready, divider).
$00010000 constant RCC_S_RCC_PUBCFGSR2_IC17PUBS                     \ Defines the public protection of the IC17 configuration bits (enable, ready, divider).
$00020000 constant RCC_S_RCC_PUBCFGSR2_IC18PUBS                     \ Defines the public protection of the IC18 configuration bits (enable, ready, divider).
$00040000 constant RCC_S_RCC_PUBCFGSR2_IC19PUBS                     \ Defines the public protection of the IC19 configuration bits (enable, ready, divider).
$00080000 constant RCC_S_RCC_PUBCFGSR2_IC20PUBS                     \ Defines the public protection of the IC20 configuration bits (enable, ready, divider).


\
\ @brief RCC system secure configuration register3
\ Address offset: 0xFB0
\ Reset value: 0x00000000
\

$00000001 constant RCC_S_RCC_SECCFGSR3_MODSECS                      \ Defines the secure protection of the MOD configuration bits (enable, ready, divider).
$00000002 constant RCC_S_RCC_SECCFGSR3_SYSSECS                      \ Defines the secure protection of the SYS configuration bits (enable, ready, divider).
$00000004 constant RCC_S_RCC_SECCFGSR3_BUSSECS                      \ Defines the secure protection of the BUS configuration bits (enable, ready, divider).
$00000008 constant RCC_S_RCC_SECCFGSR3_PERSECS                      \ Defines the secure protection of the PER configuration bits (enable, ready, divider).
$00000010 constant RCC_S_RCC_SECCFGSR3_INTSECS                      \ Defines the secure protection of the INT configuration bits (enable, ready, divider).
$00000020 constant RCC_S_RCC_SECCFGSR3_RSTSECS                      \ Defines the secure protection of the RST configuration bits (enable, ready, divider).
$00000040 constant RCC_S_RCC_SECCFGSR3_DFTSECS                      \ Defines the secure protection of the DFT configuration bits (enable, ready, divider).


\
\ @brief RCC system privilege configuration register3
\ Address offset: 0xFB4
\ Reset value: 0x00000000
\

$00000001 constant RCC_S_RCC_PRIVCFGSR3_MODPVS                      \ Defines the privilege protection of the MOD configuration bits (enable, ready, divider).
$00000002 constant RCC_S_RCC_PRIVCFGSR3_SYSPVS                      \ Defines the privilege protection of the SYS configuration bits (enable, ready, divider).
$00000004 constant RCC_S_RCC_PRIVCFGSR3_BUSPVS                      \ Defines the privilege protection of the BUS configuration bits (enable, ready, divider).
$00000008 constant RCC_S_RCC_PRIVCFGSR3_PERPVS                      \ Defines the privilege protection of the PER configuration bits (enable, ready, divider).
$00000010 constant RCC_S_RCC_PRIVCFGSR3_INTPVS                      \ Defines the privilege protection of the INT configuration bits (enable, ready, divider).
$00000020 constant RCC_S_RCC_PRIVCFGSR3_RSTPVS                      \ Defines the privilege protection of the RST configuration bits (enable, ready, divider).
$00000040 constant RCC_S_RCC_PRIVCFGSR3_DFTPVS                      \ Defines the privilege protection of the DFT configuration bits (enable, ready, divider).


\
\ @brief RCC system lock configuration register3
\ Address offset: 0xFB8
\ Reset value: 0x00000000
\

$00000001 constant RCC_S_RCC_LOCKCFGSR3_MODLOCKS                    \ Defines the lock protection of the MOD configuration bits (enable, ready, divider).
$00000002 constant RCC_S_RCC_LOCKCFGSR3_SYSLOCKS                    \ Defines the lock protection of the SYS configuration bits (enable, ready, divider).
$00000004 constant RCC_S_RCC_LOCKCFGSR3_BUSLOCKS                    \ Defines the lock protection of the BUS configuration bits (enable, ready, divider).
$00000008 constant RCC_S_RCC_LOCKCFGSR3_PERLOCKS                    \ Defines the lock protection of the PER configuration bits (enable, ready, divider).
$00000010 constant RCC_S_RCC_LOCKCFGSR3_INTLOCKS                    \ Defines the lock protection of the INT configuration bits (enable, ready, divider).
$00000020 constant RCC_S_RCC_LOCKCFGSR3_RSTLOCKS                    \ Defines the lock protection of the RST configuration bits (enable, ready, divider).
$00000040 constant RCC_S_RCC_LOCKCFGSR3_DFTLOCKS                    \ Defines the lock protection of the DFT configuration bits (enable, ready, divider).


\
\ @brief RCC system public configuration register3
\ Address offset: 0xFBC
\ Reset value: 0x00000000
\

$00000001 constant RCC_S_RCC_PUBCFGSR3_MODPUBS                      \ Defines the public protection of the MOD configuration bits (enable, ready, divider).
$00000002 constant RCC_S_RCC_PUBCFGSR3_SYSPUBS                      \ Defines the public protection of the SYS configuration bits (enable, ready, divider).
$00000004 constant RCC_S_RCC_PUBCFGSR3_BUSPUBS                      \ Defines the public protection of the BUS configuration bits (enable, ready, divider).
$00000008 constant RCC_S_RCC_PUBCFGSR3_PERPUBS                      \ Defines the public protection of the PER configuration bits (enable, ready, divider).
$00000010 constant RCC_S_RCC_PUBCFGSR3_INTPUBS                      \ Defines the public protection of the INT configuration bits (enable, ready, divider).
$00000020 constant RCC_S_RCC_PUBCFGSR3_RSTPUBS                      \ Defines the public protection of the RST configuration bits (enable, ready, divider).
$00000040 constant RCC_S_RCC_PUBCFGSR3_DFTPUBS                      \ Defines the public protection of the DFT configuration bits (enable, ready, divider).


\
\ @brief RCC privilege configuration register4
\ Address offset: 0xFC4
\ Reset value: 0x00000000
\

$00000001 constant RCC_S_RCC_PRIVCFGSR4_ACLKNPVS                    \ Defines the privilege protection of the ACLKN configuration bits (enable, ready, divider).
$00000002 constant RCC_S_RCC_PRIVCFGSR4_ACLKNCPVS                   \ Defines the privilege protection of the ACLKNC configuration bits (enable, ready, divider).
$00000004 constant RCC_S_RCC_PRIVCFGSR4_AHBMPVS                     \ Defines the privilege protection of the AHBM configuration bits (enable, ready, divider).
$00000008 constant RCC_S_RCC_PRIVCFGSR4_AHB1PVS                     \ Defines the privilege protection of the AHB1 configuration bits (enable, ready, divider).
$00000010 constant RCC_S_RCC_PRIVCFGSR4_AHB2PVS                     \ Defines the privilege protection of the AHB2 configuration bits (enable, ready, divider).
$00000020 constant RCC_S_RCC_PRIVCFGSR4_AHB3PVS                     \ Defines the privilege protection of the AHB3 configuration bits (enable, ready, divider).
$00000040 constant RCC_S_RCC_PRIVCFGSR4_AHB4PVS                     \ Defines the privilege protection of the AHB4 configuration bits (enable, ready, divider).
$00000080 constant RCC_S_RCC_PRIVCFGSR4_AHB5PVS                     \ Defines the privilege protection of the AHB5 configuration bits (enable, ready, divider).
$00000100 constant RCC_S_RCC_PRIVCFGSR4_APB1PVS                     \ Defines the privilege protection of the APB1 configuration bits (enable, ready, divider).
$00000200 constant RCC_S_RCC_PRIVCFGSR4_APB2PVS                     \ Defines the privilege protection of the APB2 configuration bits (enable, ready, divider).
$00000400 constant RCC_S_RCC_PRIVCFGSR4_APB3PVS                     \ Defines the privilege protection of the APB3 configuration bits (enable, ready, divider).
$00000800 constant RCC_S_RCC_PRIVCFGSR4_APB4PVS                     \ Defines the privilege protection of the APB4 configuration bits (enable, ready, divider).
$00001000 constant RCC_S_RCC_PRIVCFGSR4_APB5PVS                     \ Defines the privilege protection of the APB5 configuration bits (enable, ready, divider).
$00002000 constant RCC_S_RCC_PRIVCFGSR4_NOCPVS                      \ Defines the privilege protection of the NOC configuration bits (enable, ready, divider).


\
\ @brief RCC public configuration register4
\ Address offset: 0xFCC
\ Reset value: 0x00000000
\

$00000001 constant RCC_S_RCC_PUBCFGSR4_ACLKNPUBS                    \ Defines the public protection of the ACLKN configuration bits (enable, ready, divider).
$00000002 constant RCC_S_RCC_PUBCFGSR4_ACLKNCPUBS                   \ Defines the public protection of the ACLKNC configuration bits (enable, ready, divider).
$00000004 constant RCC_S_RCC_PUBCFGSR4_AHBMPUBS                     \ Defines the public protection of the AHBM configuration bits (enable, ready, divider).
$00000008 constant RCC_S_RCC_PUBCFGSR4_AHB1PUBS                     \ Defines the public protection of the AHB1 configuration bits (enable, ready, divider).
$00000010 constant RCC_S_RCC_PUBCFGSR4_AHB2PUBS                     \ Defines the public protection of the AHB2 configuration bits (enable, ready, divider).
$00000020 constant RCC_S_RCC_PUBCFGSR4_AHB3PUBS                     \ Defines the public protection of the AHB3 configuration bits (enable, ready, divider).
$00000040 constant RCC_S_RCC_PUBCFGSR4_AHB4PUBS                     \ Defines the public protection of the AHB4 configuration bits (enable, ready, divider).
$00000080 constant RCC_S_RCC_PUBCFGSR4_AHB5PUBS                     \ Defines the public protection of the AHB5 configuration bits (enable, ready, divider).
$00000100 constant RCC_S_RCC_PUBCFGSR4_APB1PUBS                     \ Defines the public protection of the APB1 configuration bits (enable, ready, divider).
$00000200 constant RCC_S_RCC_PUBCFGSR4_APB2PUBS                     \ Defines the public protection of the APB2 configuration bits (enable, ready, divider).
$00000400 constant RCC_S_RCC_PUBCFGSR4_APB3PUBS                     \ Defines the public protection of the APB3 configuration bits (enable, ready, divider).
$00000800 constant RCC_S_RCC_PUBCFGSR4_APB4PUBS                     \ Defines the public protection of the APB4 configuration bits (enable, ready, divider).
$00001000 constant RCC_S_RCC_PUBCFGSR4_APB5PUBS                     \ Defines the public protection of the APB5 configuration bits (enable, ready, divider).
$00002000 constant RCC_S_RCC_PUBCFGSR4_NOCPUBS                      \ Defines the public protection of the NOC configuration bits (enable, ready, divider).


\
\ @brief RCC public configuration register4
\ Address offset: 0xFD0
\ Reset value: 0x00000000
\

$00000001 constant RCC_S_RCC_PUBCFGSR5_AXISRAM3PUBS                 \ Defines the public protection of the AXISRAM3 configuration bits (enable, ready, divider).
$00000002 constant RCC_S_RCC_PUBCFGSR5_AXISRAM4PUBS                 \ Defines the public protection of the AXISRAM4 configuration bits (enable, ready, divider).
$00000004 constant RCC_S_RCC_PUBCFGSR5_AXISRAM5PUBS                 \ Defines the public protection of the AXISRAM5 configuration bits (enable, ready, divider).
$00000008 constant RCC_S_RCC_PUBCFGSR5_AXISRAM6PUBS                 \ Defines the public protection of the AXISRAM6 configuration bits (enable, ready, divider).
$00000010 constant RCC_S_RCC_PUBCFGSR5_AHBSRAM1PUBS                 \ Defines the public protection of the AHBSRAM1 configuration bits (enable, ready, divider).
$00000020 constant RCC_S_RCC_PUBCFGSR5_AHBSRAM2PUBS                 \ Defines the public protection of the AHBSRAM2 configuration bits (enable, ready, divider).
$00000040 constant RCC_S_RCC_PUBCFGSR5_BKPSRAMPUBS                  \ Defines the public protection of the BKPSRAM configuration bits (enable, ready, divider).
$00000080 constant RCC_S_RCC_PUBCFGSR5_AXISRAM1PUBS                 \ Defines the public protection of the AXISRAM1 configuration bits (enable, ready, divider).
$00000100 constant RCC_S_RCC_PUBCFGSR5_AXISRAM2PUBS                 \ Defines the public protection of the AXISRAM2 configuration bits (enable, ready, divider).
$00000200 constant RCC_S_RCC_PUBCFGSR5_FLEXRAMPUBS                  \ Defines the public protection of the FLEXRAM configuration bits (enable, ready, divider).
$00000400 constant RCC_S_RCC_PUBCFGSR5_NPUCACHERAMPUBS              \ Defines the public protection of the NPUCACHERAM configuration bits (enable, ready, divider).
$00000800 constant RCC_S_RCC_PUBCFGSR5_VENCRAMPUBS                  \ Defines the public protection of the VENCRAM configuration bits (enable, ready, divider).


\
\ @brief RCC control Clear register
\ Address offset: 0x1000
\ Reset value: 0x00000000
\

$00000001 constant RCC_S_RCC_CCR_LSIONC                             \ LSI oscillator enable in Run/Sleep mode.
$00000002 constant RCC_S_RCC_CCR_LSEONC                             \ LSE oscillator enable in Run/Sleep mode.
$00000004 constant RCC_S_RCC_CCR_MSIONC                             \ MSI oscillator enable in Run/Sleep mode.
$00000008 constant RCC_S_RCC_CCR_HSIONC                             \ HSI oscillator enable in Run/Sleep mode.
$00000010 constant RCC_S_RCC_CCR_HSEONC                             \ HSE oscillator enable in Run/Sleep mode.
$00000100 constant RCC_S_RCC_CCR_PLL1ONC                            \ PLL1 oscillator enable in Run/Sleep mode.
$00000200 constant RCC_S_RCC_CCR_PLL2ONC                            \ PLL2 oscillator enable in Run/Sleep mode.
$00000400 constant RCC_S_RCC_CCR_PLL3ONC                            \ PLL3 oscillator enable in Run/Sleep mode.
$00000800 constant RCC_S_RCC_CCR_PLL4ONC                            \ PLL4 oscillator enable in Run/Sleep mode.


\
\ @brief RCC StopCCR configuration register
\ Address offset: 0x1008
\ Reset value: 0x00000000
\

$00000001 constant RCC_S_RCC_STOPCCR_LSISTOPENC                     \ LSI oscillator enable in Run/Sleep mode.
$00000002 constant RCC_S_RCC_STOPCCR_LSESTOPENC                     \ LSE oscillator enable in Run/Sleep mode.
$00000004 constant RCC_S_RCC_STOPCCR_MSISTOPENC                     \ MSI oscillator enable in Run/Sleep mode.
$00000008 constant RCC_S_RCC_STOPCCR_HSISTOPENC                     \ HSI oscillator enable in Run/Sleep mode.


\
\ @brief RCC bus reset register
\ Address offset: 0x1204
\ Reset value: 0x00000000
\

$00000001 constant RCC_S_RCC_BUSRSTCR_ACLKNRSTC                     \ ACLKN reset
$00000004 constant RCC_S_RCC_BUSRSTCR_AHBMRSTC                      \ AHBM reset
$00000008 constant RCC_S_RCC_BUSRSTCR_AHB1RSTC                      \ AHB1 reset
$00000010 constant RCC_S_RCC_BUSRSTCR_AHB2RSTC                      \ AHB2 reset
$00000020 constant RCC_S_RCC_BUSRSTCR_AHB3RSTC                      \ AHB3 reset
$00000040 constant RCC_S_RCC_BUSRSTCR_AHB4RSTC                      \ AHB4 reset
$00000080 constant RCC_S_RCC_BUSRSTCR_AHB5RSTC                      \ AHB5 reset
$00000100 constant RCC_S_RCC_BUSRSTCR_APB1RSTC                      \ APB1 reset
$00000200 constant RCC_S_RCC_BUSRSTCR_APB2RSTC                      \ APB2 reset
$00000400 constant RCC_S_RCC_BUSRSTCR_APB3RSTC                      \ APB3 reset
$00000800 constant RCC_S_RCC_BUSRSTCR_APB4RSTC                      \ APB4 reset
$00001000 constant RCC_S_RCC_BUSRSTCR_APB5RSTC                      \ APB5 reset
$00002000 constant RCC_S_RCC_BUSRSTCR_NOCRSTC                       \ NOC reset


\
\ @brief RCC miscellaneous reset register
\ Address offset: 0x1208
\ Reset value: 0x00000000
\

$00000001 constant RCC_S_RCC_MISCRSTCR_DBGRSTC                      \ DBG reset
$00000010 constant RCC_S_RCC_MISCRSTCR_XSPIPHY1RSTC                 \ XSPIPHY1 reset
$00000020 constant RCC_S_RCC_MISCRSTCR_XSPIPHY2RSTC                 \ XSPIPHY2 reset
$00000080 constant RCC_S_RCC_MISCRSTCR_SDMMC1DLLRSTC                \ SDMMC1DLL reset
$00000100 constant RCC_S_RCC_MISCRSTCR_SDMMC2DLLRSTC                \ SDMMC2DLL reset


\
\ @brief RCC memory reset register
\ Address offset: 0x120C
\ Reset value: 0x00000000
\

$00000001 constant RCC_S_RCC_MEMRSTCR_AXISRAM3RSTC                  \ AXISRAM3 reset
$00000002 constant RCC_S_RCC_MEMRSTCR_AXISRAM4RSTC                  \ AXISRAM4 reset
$00000004 constant RCC_S_RCC_MEMRSTCR_AXISRAM5RSTC                  \ AXISRAM5 reset
$00000008 constant RCC_S_RCC_MEMRSTCR_AXISRAM6RSTC                  \ AXISRAM6 reset
$00000010 constant RCC_S_RCC_MEMRSTCR_AHBSRAM1RSTC                  \ AHBSRAM1 reset
$00000020 constant RCC_S_RCC_MEMRSTCR_AHBSRAM2RSTC                  \ AHBSRAM2 reset
$00000080 constant RCC_S_RCC_MEMRSTCR_AXISRAM1RSTC                  \ AXISRAM1 reset
$00000100 constant RCC_S_RCC_MEMRSTCR_AXISRAM2RSTC                  \ AXISRAM2 reset
$00000200 constant RCC_S_RCC_MEMRSTCR_FLEXRAMRSTC                   \ FLEXRAM reset
$00000400 constant RCC_S_RCC_MEMRSTCR_NPUCACHERAMRSTC               \ NPUCACHERAM reset
$00000800 constant RCC_S_RCC_MEMRSTCR_VENCRAMRSTC                   \ VENCRAM reset
$00001000 constant RCC_S_RCC_MEMRSTCR_BOOTROMRSTC                   \ BOOTROM reset


\
\ @brief RCC AHB1 reset register
\ Address offset: 0x1210
\ Reset value: 0x00000000
\

$00000010 constant RCC_S_RCC_AHB1RSTCR_GPDMA1RSTC                   \ GPDMA1 reset
$00000020 constant RCC_S_RCC_AHB1RSTCR_ADC12RSTC                    \ ADC12 reset


\
\ @brief RCC AHB2 Reset register
\ Address offset: 0x1214
\ Reset value: 0x00000000
\

$00001000 constant RCC_S_RCC_AHB2RSTCR_RAMCFGRSTC                   \ RAMCFG reset
$00010000 constant RCC_S_RCC_AHB2RSTCR_MDF1RSTC                     \ MDF1 reset
$00020000 constant RCC_S_RCC_AHB2RSTCR_ADF1RSTC                     \ ADF1 reset


\
\ @brief RCC AHB3 reset register
\ Address offset: 0x1218
\ Reset value: 0x00000000
\

$00000001 constant RCC_S_RCC_AHB3RSTCR_RNGRSTC                      \ RNG reset
$00000002 constant RCC_S_RCC_AHB3RSTCR_HASHRSTC                     \ HASH reset
$00000004 constant RCC_S_RCC_AHB3RSTCR_CRYPRSTC                     \ CRYP reset
$00000010 constant RCC_S_RCC_AHB3RSTCR_SAESRSTC                     \ SAES reset
$00000100 constant RCC_S_RCC_AHB3RSTCR_PKARSTC                      \ PKA reset
$00000400 constant RCC_S_RCC_AHB3RSTCR_IACRSTC                      \ IAC reset


\
\ @brief RCC AHB4 reset register
\ Address offset: 0x121C
\ Reset value: 0x00000000
\

$00000001 constant RCC_S_RCC_AHB4RSTCR_GPIOARSTC                    \ GPIOA reset
$00000002 constant RCC_S_RCC_AHB4RSTCR_GPIOBRSTC                    \ GPIOB reset
$00000004 constant RCC_S_RCC_AHB4RSTCR_GPIOCRSTC                    \ GPIOC reset
$00000008 constant RCC_S_RCC_AHB4RSTCR_GPIODRSTC                    \ GPIOD reset
$00000010 constant RCC_S_RCC_AHB4RSTCR_GPIOERSTC                    \ GPIOE reset
$00000020 constant RCC_S_RCC_AHB4RSTCR_GPIOFRSTC                    \ GPIOF reset
$00000040 constant RCC_S_RCC_AHB4RSTCR_GPIOGRSTC                    \ GPIOG reset
$00000080 constant RCC_S_RCC_AHB4RSTCR_GPIOHRSTC                    \ GPIOH reset
$00002000 constant RCC_S_RCC_AHB4RSTCR_GPIONRSTC                    \ GPION reset
$00004000 constant RCC_S_RCC_AHB4RSTCR_GPIOORSTC                    \ GPIOO reset
$00008000 constant RCC_S_RCC_AHB4RSTCR_GPIOPRSTC                    \ GPIOP reset
$00010000 constant RCC_S_RCC_AHB4RSTCR_GPIOQRSTC                    \ GPIOQ reset
$00040000 constant RCC_S_RCC_AHB4RSTCR_PWRRSTC                      \ PWR reset
$00080000 constant RCC_S_RCC_AHB4RSTCR_CRCRSTC                      \ CRC reset


\
\ @brief RCC AHB5 reset register
\ Address offset: 0x1220
\ Reset value: 0x00000000
\

$00000001 constant RCC_S_RCC_AHB5RSTCR_HPDMA1RSTC                   \ HPDMA1 reset
$00000002 constant RCC_S_RCC_AHB5RSTCR_DMA2DRSTC                    \ DMA2D reset
$00000008 constant RCC_S_RCC_AHB5RSTCR_JPEGRSTC                     \ JPEG reset
$00000010 constant RCC_S_RCC_AHB5RSTCR_FMCRSTC                      \ FMC reset
$00000020 constant RCC_S_RCC_AHB5RSTCR_XSPI1RSTC                    \ XSPI1 reset
$00000040 constant RCC_S_RCC_AHB5RSTCR_PSSIRSTC                     \ PSSI reset
$00000080 constant RCC_S_RCC_AHB5RSTCR_SDMMC2RSTC                   \ SDMMC2 reset
$00000100 constant RCC_S_RCC_AHB5RSTCR_SDMMC1RSTC                   \ SDMMC1 reset
$00001000 constant RCC_S_RCC_AHB5RSTCR_XSPI2RSTC                    \ XSPI2 reset
$00002000 constant RCC_S_RCC_AHB5RSTCR_XSPIMRSTC                    \ XSPIM reset
$00020000 constant RCC_S_RCC_AHB5RSTCR_XSPI3RSTC                    \ XSPI3 reset
$00040000 constant RCC_S_RCC_AHB5RSTCR_MCE4RSTC                     \ MCE4 reset
$00080000 constant RCC_S_RCC_AHB5RSTCR_GFXMMURSTC                   \ GFXMMU reset
$00100000 constant RCC_S_RCC_AHB5RSTCR_GPURSTC                      \ GPU reset
$00800000 constant RCC_S_RCC_AHB5RSTCR_SYSCFGOTGHSPHY1RSTC          \ SYSCFGOTGHSPHY1 reset
$01000000 constant RCC_S_RCC_AHB5RSTCR_SYSCFGOTGHSPHY2RSTC          \ SYSCFGOTGHSPHY2 reset
$02000000 constant RCC_S_RCC_AHB5RSTCR_ETH1RSTC                     \ ETH1 reset
$04000000 constant RCC_S_RCC_AHB5RSTCR_OTG1RSTC                     \ OTG1 reset
$08000000 constant RCC_S_RCC_AHB5RSTCR_OTGPHY1RSTC                  \ OTGPHY1 reset
$10000000 constant RCC_S_RCC_AHB5RSTCR_OTGPHY2RSTC                  \ OTGPHY2 reset
$20000000 constant RCC_S_RCC_AHB5RSTCR_OTG2RSTC                     \ OTG2 reset
$40000000 constant RCC_S_RCC_AHB5RSTCR_NPUCACHERSTC                 \ NPUCACHE reset
$80000000 constant RCC_S_RCC_AHB5RSTCR_NPURSTC                      \ NPU reset


\
\ @brief RCC APB1L reset register
\ Address offset: 0x1224
\ Reset value: 0x00000000
\

$00000001 constant RCC_S_RCC_APB1LRSTCR_TIM2RSTC                    \ TIM2 reset
$00000002 constant RCC_S_RCC_APB1LRSTCR_TIM3RSTC                    \ TIM3 reset
$00000004 constant RCC_S_RCC_APB1LRSTCR_TIM4RSTC                    \ TIM4 reset
$00000008 constant RCC_S_RCC_APB1LRSTCR_TIM5RSTC                    \ TIM5 reset
$00000010 constant RCC_S_RCC_APB1LRSTCR_TIM6RSTC                    \ TIM6 reset
$00000020 constant RCC_S_RCC_APB1LRSTCR_TIM7RSTC                    \ TIM7 reset
$00000040 constant RCC_S_RCC_APB1LRSTCR_TIM12RSTC                   \ TIM12 reset
$00000080 constant RCC_S_RCC_APB1LRSTCR_TIM13RSTC                   \ TIM13 reset
$00000100 constant RCC_S_RCC_APB1LRSTCR_TIM14RSTC                   \ TIM14 reset
$00000200 constant RCC_S_RCC_APB1LRSTCR_LPTIM1RSTC                  \ LPTIM1 reset
$00000800 constant RCC_S_RCC_APB1LRSTCR_WWDGRSTC                    \ WWDG reset
$00001000 constant RCC_S_RCC_APB1LRSTCR_TIM10RSTC                   \ TIM10 reset
$00002000 constant RCC_S_RCC_APB1LRSTCR_TIM11RSTC                   \ TIM11 reset
$00004000 constant RCC_S_RCC_APB1LRSTCR_SPI2RSTC                    \ SPI2 reset
$00008000 constant RCC_S_RCC_APB1LRSTCR_SPI3RSTC                    \ SPI3 reset
$00010000 constant RCC_S_RCC_APB1LRSTCR_SPDIFRX1RSTC                \ SPDIFRX1 reset
$00020000 constant RCC_S_RCC_APB1LRSTCR_USART2RSTC                  \ USART2 reset
$00040000 constant RCC_S_RCC_APB1LRSTCR_USART3RSTC                  \ USART3 reset
$00080000 constant RCC_S_RCC_APB1LRSTCR_UART4RSTC                   \ UART4 reset
$00100000 constant RCC_S_RCC_APB1LRSTCR_UART5RSTC                   \ UART5 reset
$00200000 constant RCC_S_RCC_APB1LRSTCR_I2C1RSTC                    \ I2C1 reset
$00400000 constant RCC_S_RCC_APB1LRSTCR_I2C2RSTC                    \ I2C2 reset
$00800000 constant RCC_S_RCC_APB1LRSTCR_I2C3RSTC                    \ I2C3 reset
$01000000 constant RCC_S_RCC_APB1LRSTCR_I3C1RSTC                    \ I3C1 reset
$02000000 constant RCC_S_RCC_APB1LRSTCR_I3C2RSTC                    \ I3C2 reset
$40000000 constant RCC_S_RCC_APB1LRSTCR_UART7RSTC                   \ UART7 reset
$80000000 constant RCC_S_RCC_APB1LRSTCR_UART8RSTC                   \ UART8 reset


\
\ @brief RCC APB1H reset register
\ Address offset: 0x1228
\ Reset value: 0x00000000
\

$00000020 constant RCC_S_RCC_APB1HRSTCR_MDIOSRSTC                   \ MDIOS reset
$00000100 constant RCC_S_RCC_APB1HRSTCR_FDCANRSTC                   \ FDCAN reset
$00040000 constant RCC_S_RCC_APB1HRSTCR_UCPD1RSTC                   \ UCPD1 reset


\
\ @brief RCC APB2 reset register
\ Address offset: 0x122C
\ Reset value: 0x00000000
\

$00000001 constant RCC_S_RCC_APB2RSTCR_TIM1RSTC                     \ TIM1 reset
$00000002 constant RCC_S_RCC_APB2RSTCR_TIM8RSTC                     \ TIM8 reset
$00000010 constant RCC_S_RCC_APB2RSTCR_USART1RSTC                   \ USART1 reset
$00000020 constant RCC_S_RCC_APB2RSTCR_USART6RSTC                   \ USART6 reset
$00000040 constant RCC_S_RCC_APB2RSTCR_UART9RSTC                    \ UART9 reset
$00000080 constant RCC_S_RCC_APB2RSTCR_USART10RSTC                  \ USART10 reset
$00001000 constant RCC_S_RCC_APB2RSTCR_SPI1RSTC                     \ SPI1 reset
$00002000 constant RCC_S_RCC_APB2RSTCR_SPI4RSTC                     \ SPI4 reset
$00008000 constant RCC_S_RCC_APB2RSTCR_TIM18RSTC                    \ TIM18 reset
$00010000 constant RCC_S_RCC_APB2RSTCR_TIM15RSTC                    \ TIM15 reset
$00020000 constant RCC_S_RCC_APB2RSTCR_TIM16RSTC                    \ TIM16 reset
$00040000 constant RCC_S_RCC_APB2RSTCR_TIM17RSTC                    \ TIM17 reset
$00080000 constant RCC_S_RCC_APB2RSTCR_TIM9RSTC                     \ TIM9 reset
$00100000 constant RCC_S_RCC_APB2RSTCR_SPI5RSTC                     \ SPI5 reset
$00200000 constant RCC_S_RCC_APB2RSTCR_SAI1RSTC                     \ SAI1 reset
$00400000 constant RCC_S_RCC_APB2RSTCR_SAI2RSTC                     \ SAI2 reset


\
\ @brief RCC APB4L reset register
\ Address offset: 0x1234
\ Reset value: 0x00000000
\

$00000004 constant RCC_S_RCC_APB4LRSTCR_HDPRSTC                     \ HDP reset
$00000008 constant RCC_S_RCC_APB4LRSTCR_LPUART1RSTC                 \ LPUART1 reset
$00000020 constant RCC_S_RCC_APB4LRSTCR_SPI6RSTC                    \ SPI6 reset
$00000080 constant RCC_S_RCC_APB4LRSTCR_I2C4RSTC                    \ I2C4 reset
$00000200 constant RCC_S_RCC_APB4LRSTCR_LPTIM2RSTC                  \ LPTIM2 reset
$00000400 constant RCC_S_RCC_APB4LRSTCR_LPTIM3RSTC                  \ LPTIM3 reset
$00000800 constant RCC_S_RCC_APB4LRSTCR_LPTIM4RSTC                  \ LPTIM4 reset
$00001000 constant RCC_S_RCC_APB4LRSTCR_LPTIM5RSTC                  \ LPTIM5 reset
$00008000 constant RCC_S_RCC_APB4LRSTCR_VREFBUFRSTC                 \ VREFBUF reset
$00010000 constant RCC_S_RCC_APB4LRSTCR_RTCRSTC                     \ RTC reset
$00400000 constant RCC_S_RCC_APB4LRSTCR_R2GRETRSTC                  \ R2GRET reset
$00800000 constant RCC_S_RCC_APB4LRSTCR_R2GNPURSTC                  \ R2GNPU reset
$80000000 constant RCC_S_RCC_APB4LRSTCR_SERFRSTC                    \ SERF reset


\
\ @brief RCC APB4H reset register
\ Address offset: 0x1238
\ Reset value: 0x00000000
\

$00000001 constant RCC_S_RCC_APB4HRSTCR_SYSCFGRSTC                  \ SYSCFG reset
$00000004 constant RCC_S_RCC_APB4HRSTCR_DTSRSTC                     \ DTS reset
$00000010 constant RCC_S_RCC_APB4HRSTCR_BUSPERFMRSTC                \ BUSPERFM reset


\
\ @brief RCC APB5 reset register
\ Address offset: 0x123C
\ Reset value: 0x00000000
\

$00000002 constant RCC_S_RCC_APB5RSTCR_LTDCRSTC                     \ LTDC reset
$00000004 constant RCC_S_RCC_APB5RSTCR_DCMIPPRSTC                   \ DCMIPP reset
$00000010 constant RCC_S_RCC_APB5RSTCR_GFXTIMRSTC                   \ GFXTIM reset
$00000020 constant RCC_S_RCC_APB5RSTCR_VENCRSTC                     \ VENC reset
$00000040 constant RCC_S_RCC_APB5RSTCR_CSIRSTC                      \ CSI reset


\
\ @brief RCC divider enable register
\ Address offset: 0x1240
\ Reset value: 0x00000000
\

$00000001 constant RCC_S_RCC_DIVENCR_IC1ENC                         \ IC1 enable
$00000002 constant RCC_S_RCC_DIVENCR_IC2ENC                         \ IC2 enable
$00000004 constant RCC_S_RCC_DIVENCR_IC3ENC                         \ IC3 enable
$00000008 constant RCC_S_RCC_DIVENCR_IC4ENC                         \ IC4 enable
$00000010 constant RCC_S_RCC_DIVENCR_IC5ENC                         \ IC5 enable
$00000020 constant RCC_S_RCC_DIVENCR_IC6ENC                         \ IC6 enable
$00000040 constant RCC_S_RCC_DIVENCR_IC7ENC                         \ IC7 enable
$00000080 constant RCC_S_RCC_DIVENCR_IC8ENC                         \ IC8 enable
$00000100 constant RCC_S_RCC_DIVENCR_IC9ENC                         \ IC9 enable
$00000200 constant RCC_S_RCC_DIVENCR_IC10ENC                        \ IC10 enable
$00000400 constant RCC_S_RCC_DIVENCR_IC11ENC                        \ IC11 enable
$00000800 constant RCC_S_RCC_DIVENCR_IC12ENC                        \ IC12 enable
$00001000 constant RCC_S_RCC_DIVENCR_IC13ENC                        \ IC13 enable
$00002000 constant RCC_S_RCC_DIVENCR_IC14ENC                        \ IC14 enable
$00004000 constant RCC_S_RCC_DIVENCR_IC15ENC                        \ IC15 enable
$00008000 constant RCC_S_RCC_DIVENCR_IC16ENC                        \ IC16 enable
$00010000 constant RCC_S_RCC_DIVENCR_IC17ENC                        \ IC17 enable
$00020000 constant RCC_S_RCC_DIVENCR_IC18ENC                        \ IC18 enable
$00040000 constant RCC_S_RCC_DIVENCR_IC19ENC                        \ IC19 enable
$00080000 constant RCC_S_RCC_DIVENCR_IC20ENC                        \ IC20 enable


\
\ @brief RCC bus enable register
\ Address offset: 0x1244
\ Reset value: 0x00000000
\

$00000001 constant RCC_S_RCC_BUSENCR_ACLKNENC                       \ ACLKN enable
$00000002 constant RCC_S_RCC_BUSENCR_ACLKNCENC                      \ ACLKNC enable
$00000004 constant RCC_S_RCC_BUSENCR_AHBMENC                        \ AHBM enable
$00000008 constant RCC_S_RCC_BUSENCR_AHB1ENC                        \ AHB1 enable
$00000010 constant RCC_S_RCC_BUSENCR_AHB2ENC                        \ AHB2 enable
$00000020 constant RCC_S_RCC_BUSENCR_AHB3ENC                        \ AHB3 enable
$00000040 constant RCC_S_RCC_BUSENCR_AHB4ENC                        \ AHB4 enable
$00000080 constant RCC_S_RCC_BUSENCR_AHB5ENC                        \ AHB5 enable
$00000100 constant RCC_S_RCC_BUSENCR_APB1ENC                        \ APB1 enable
$00000200 constant RCC_S_RCC_BUSENCR_APB2ENC                        \ APB2 enable
$00000400 constant RCC_S_RCC_BUSENCR_APB3ENC                        \ APB3 enable
$00000800 constant RCC_S_RCC_BUSENCR_APB4ENC                        \ APB4 enable
$00001000 constant RCC_S_RCC_BUSENCR_APB5ENC                        \ APB5 enable


\
\ @brief RCC miscellaneous enable register
\ Address offset: 0x1248
\ Reset value: 0x00000000
\

$00000001 constant RCC_S_RCC_MISCENCR_DBGENC                        \ DBG enable
$00000002 constant RCC_S_RCC_MISCENCR_MCO1ENC                       \ MCO1 enable
$00000004 constant RCC_S_RCC_MISCENCR_MCO2ENC                       \ MCO2 enable
$00000008 constant RCC_S_RCC_MISCENCR_XSPIPHYCOMPENC                \ XSPIPHYCOMP enable
$00000040 constant RCC_S_RCC_MISCENCR_PERENC                        \ PER enable


\
\ @brief RCC memory enable register
\ Address offset: 0x124C
\ Reset value: 0x00000000
\

$00000001 constant RCC_S_RCC_MEMENCR_AXISRAM3ENC                    \ AXISRAM3 enable
$00000002 constant RCC_S_RCC_MEMENCR_AXISRAM4ENC                    \ AXISRAM4 enable
$00000004 constant RCC_S_RCC_MEMENCR_AXISRAM5ENC                    \ AXISRAM5 enable
$00000008 constant RCC_S_RCC_MEMENCR_AXISRAM6ENC                    \ AXISRAM6 enable
$00000010 constant RCC_S_RCC_MEMENCR_AHBSRAM1ENC                    \ AHBSRAM1 enable
$00000020 constant RCC_S_RCC_MEMENCR_AHBSRAM2ENC                    \ AHBSRAM2 enable
$00000040 constant RCC_S_RCC_MEMENCR_BKPSRAMENC                     \ BKPSRAM enable
$00000080 constant RCC_S_RCC_MEMENCR_AXISRAM1ENC                    \ AXISRAM1 enable
$00000100 constant RCC_S_RCC_MEMENCR_AXISRAM2ENC                    \ AXISRAM2 enable
$00000200 constant RCC_S_RCC_MEMENCR_FLEXRAMENC                     \ FLEXRAM enable
$00000400 constant RCC_S_RCC_MEMENCR_NPUCACHERAMENC                 \ NPUCACHERAM enable
$00000800 constant RCC_S_RCC_MEMENCR_VENCRAMENC                     \ VENCRAM enable
$00001000 constant RCC_S_RCC_MEMENCR_BOOTROMENC                     \ BOOTROM enable


\
\ @brief RCC AHB1 enable register
\ Address offset: 0x1250
\ Reset value: 0x00000000
\

$00000010 constant RCC_S_RCC_AHB1ENCR_GPDMA1ENC                     \ GPDMA1 enable
$00000020 constant RCC_S_RCC_AHB1ENCR_ADC12ENC                      \ ADC12 enable


\
\ @brief RCC AHB2 enable register
\ Address offset: 0x1254
\ Reset value: 0x00000000
\

$00001000 constant RCC_S_RCC_AHB2ENCR_RAMCFGENC                     \ RAMCFG enable
$00010000 constant RCC_S_RCC_AHB2ENCR_MDF1ENC                       \ MDF1 enable
$00020000 constant RCC_S_RCC_AHB2ENCR_ADF1ENC                       \ ADF1 enable


\
\ @brief RCC AHB3 enable register
\ Address offset: 0x1258
\ Reset value: 0x00000000
\

$00000001 constant RCC_S_RCC_AHB3ENCR_RNGENC                        \ RNG enable
$00000002 constant RCC_S_RCC_AHB3ENCR_HASHENC                       \ HASH enable
$00000004 constant RCC_S_RCC_AHB3ENCR_CRYPENC                       \ CRYP enable
$00000010 constant RCC_S_RCC_AHB3ENCR_SAESENC                       \ SAES enable
$00000100 constant RCC_S_RCC_AHB3ENCR_PKAENC                        \ PKA enable
$00000200 constant RCC_S_RCC_AHB3ENCR_RIFSCENC                      \ RIFSC enable
$00000400 constant RCC_S_RCC_AHB3ENCR_IACENC                        \ IAC enable
$00004000 constant RCC_S_RCC_AHB3ENCR_RISAFENC                      \ RISAF enable


\
\ @brief RCC AHB4 enable register
\ Address offset: 0x125C
\ Reset value: 0x00000000
\

$00000001 constant RCC_S_RCC_AHB4ENCR_GPIOAENC                      \ GPIOA enable
$00000002 constant RCC_S_RCC_AHB4ENCR_GPIOBENC                      \ GPIOB enable
$00000004 constant RCC_S_RCC_AHB4ENCR_GPIOCENC                      \ GPIOC enable
$00000008 constant RCC_S_RCC_AHB4ENCR_GPIODENC                      \ GPIOD enable
$00000010 constant RCC_S_RCC_AHB4ENCR_GPIOEENC                      \ GPIOE enable
$00000020 constant RCC_S_RCC_AHB4ENCR_GPIOFENC                      \ GPIOF enable
$00000040 constant RCC_S_RCC_AHB4ENCR_GPIOGENC                      \ GPIOG enable
$00000080 constant RCC_S_RCC_AHB4ENCR_GPIOHENC                      \ GPIOH enable
$00002000 constant RCC_S_RCC_AHB4ENCR_GPIONENC                      \ GPION enable
$00004000 constant RCC_S_RCC_AHB4ENCR_GPIOOENC                      \ GPIOO enable
$00008000 constant RCC_S_RCC_AHB4ENCR_GPIOPENC                      \ GPIOP enable
$00010000 constant RCC_S_RCC_AHB4ENCR_GPIOQENC                      \ GPIOQ enable
$00040000 constant RCC_S_RCC_AHB4ENCR_PWRENC                        \ PWR enable
$00080000 constant RCC_S_RCC_AHB4ENCR_CRCENC                        \ CRC enable


\
\ @brief RCC AHB5 enable register
\ Address offset: 0x1260
\ Reset value: 0x00000000
\

$00000001 constant RCC_S_RCC_AHB5ENCR_HPDMA1ENC                     \ HPDMA1 enable
$00000002 constant RCC_S_RCC_AHB5ENCR_DMA2DENC                      \ DMA2D enable
$00000008 constant RCC_S_RCC_AHB5ENCR_JPEGENC                       \ JPEG enable
$00000010 constant RCC_S_RCC_AHB5ENCR_FMCENC                        \ FMC enable
$00000020 constant RCC_S_RCC_AHB5ENCR_XSPI1ENC                      \ XSPI1 enable
$00000040 constant RCC_S_RCC_AHB5ENCR_PSSIENC                       \ PSSI enable
$00000080 constant RCC_S_RCC_AHB5ENCR_SDMMC2ENC                     \ SDMMC2 enable
$00000100 constant RCC_S_RCC_AHB5ENCR_SDMMC1ENC                     \ SDMMC1 enable
$00001000 constant RCC_S_RCC_AHB5ENCR_XSPI2ENC                      \ XSPI2 enable
$00002000 constant RCC_S_RCC_AHB5ENCR_XSPIMENC                      \ XSPIM enable
$00004000 constant RCC_S_RCC_AHB5ENCR_MCE1ENC                       \ MCE1 enable
$00008000 constant RCC_S_RCC_AHB5ENCR_MCE2ENC                       \ MCE2 enable
$00010000 constant RCC_S_RCC_AHB5ENCR_MCE3ENC                       \ MCE3 enable
$00020000 constant RCC_S_RCC_AHB5ENCR_XSPI3ENC                      \ XSPI3 enable
$00040000 constant RCC_S_RCC_AHB5ENCR_MCE4ENC                       \ MCE4 enable
$00080000 constant RCC_S_RCC_AHB5ENCR_GFXMMUENC                     \ GFXMMU enable
$00100000 constant RCC_S_RCC_AHB5ENCR_GPUENC                        \ GPU enable
$00400000 constant RCC_S_RCC_AHB5ENCR_ETH1MACENC                    \ ETH1MAC enable
$00800000 constant RCC_S_RCC_AHB5ENCR_ETH1TXENC                     \ ETH1TX enable
$01000000 constant RCC_S_RCC_AHB5ENCR_ETH1RXENC                     \ ETH1RX enable
$02000000 constant RCC_S_RCC_AHB5ENCR_ETH1ENC                       \ ETH1 enable
$04000000 constant RCC_S_RCC_AHB5ENCR_OTG1ENC                       \ OTG1 enable
$08000000 constant RCC_S_RCC_AHB5ENCR_OTGPHY1ENC                    \ OTGPHY1 enable
$10000000 constant RCC_S_RCC_AHB5ENCR_OTGPHY2ENC                    \ OTGPHY2 enable
$20000000 constant RCC_S_RCC_AHB5ENCR_OTG2ENC                       \ OTG2 enable
$40000000 constant RCC_S_RCC_AHB5ENCR_NPUCACHEENC                   \ NPUCACHE enable
$80000000 constant RCC_S_RCC_AHB5ENCR_NPUENC                        \ NPU enable


\
\ @brief RCC APB1L enable register
\ Address offset: 0x1264
\ Reset value: 0x00000000
\

$00000001 constant RCC_S_RCC_APB1LENCR_TIM2ENC                      \ TIM2 enable
$00000002 constant RCC_S_RCC_APB1LENCR_TIM3ENC                      \ TIM3 enable
$00000004 constant RCC_S_RCC_APB1LENCR_TIM4ENC                      \ TIM4 enable
$00000008 constant RCC_S_RCC_APB1LENCR_TIM5ENC                      \ TIM5 enable
$00000010 constant RCC_S_RCC_APB1LENCR_TIM6ENC                      \ TIM6 enable
$00000020 constant RCC_S_RCC_APB1LENCR_TIM7ENC                      \ TIM7 enable
$00000040 constant RCC_S_RCC_APB1LENCR_TIM12ENC                     \ TIM12 enable
$00000080 constant RCC_S_RCC_APB1LENCR_TIM13ENC                     \ TIM13 enable
$00000100 constant RCC_S_RCC_APB1LENCR_TIM14ENC                     \ TIM14 enable
$00000200 constant RCC_S_RCC_APB1LENCR_LPTIM1ENC                    \ LPTIM1 enable
$00001000 constant RCC_S_RCC_APB1LENCR_TIM10ENC                     \ TIM10 enable
$00002000 constant RCC_S_RCC_APB1LENCR_TIM11ENC                     \ TIM11 enable
$00004000 constant RCC_S_RCC_APB1LENCR_SPI2ENC                      \ SPI2 enable
$00008000 constant RCC_S_RCC_APB1LENCR_SPI3ENC                      \ SPI3 enable
$00010000 constant RCC_S_RCC_APB1LENCR_SPDIFRX1ENC                  \ SPDIFRX1 enable
$00020000 constant RCC_S_RCC_APB1LENCR_USART2ENC                    \ USART2 enable
$00040000 constant RCC_S_RCC_APB1LENCR_USART3ENC                    \ USART3 enable
$00080000 constant RCC_S_RCC_APB1LENCR_UART4ENC                     \ UART4 enable
$00100000 constant RCC_S_RCC_APB1LENCR_UART5ENC                     \ UART5 enable
$00200000 constant RCC_S_RCC_APB1LENCR_I2C1ENC                      \ I2C1 enable
$00400000 constant RCC_S_RCC_APB1LENCR_I2C2ENC                      \ I2C2 enable
$00800000 constant RCC_S_RCC_APB1LENCR_I2C3ENC                      \ I2C3 enable
$01000000 constant RCC_S_RCC_APB1LENCR_I3C1ENC                      \ I3C1 enable
$02000000 constant RCC_S_RCC_APB1LENCR_I3C2ENC                      \ I3C2 enable
$40000000 constant RCC_S_RCC_APB1LENCR_UART7ENC                     \ UART7 enable
$80000000 constant RCC_S_RCC_APB1LENCR_UART8ENC                     \ UART8 enable


\
\ @brief RCC APB1H enable register
\ Address offset: 0x1268
\ Reset value: 0x00000000
\

$00000020 constant RCC_S_RCC_APB1HENCR_MDIOSENC                     \ MDIOS enable
$00000100 constant RCC_S_RCC_APB1HENCR_FDCANENC                     \ FDCAN enable
$00040000 constant RCC_S_RCC_APB1HENCR_UCPD1ENC                     \ UCPD1 enable


\
\ @brief RCC APB2 enable register
\ Address offset: 0x126C
\ Reset value: 0x00000000
\

$00000001 constant RCC_S_RCC_APB2ENCR_TIM1ENC                       \ TIM1 enable
$00000002 constant RCC_S_RCC_APB2ENCR_TIM8ENC                       \ TIM8 enable
$00000010 constant RCC_S_RCC_APB2ENCR_USART1ENC                     \ USART1 enable
$00000020 constant RCC_S_RCC_APB2ENCR_USART6ENC                     \ USART6 enable
$00000040 constant RCC_S_RCC_APB2ENCR_UART9ENC                      \ UART9 enable
$00000080 constant RCC_S_RCC_APB2ENCR_USART10ENC                    \ USART10 enable
$00001000 constant RCC_S_RCC_APB2ENCR_SPI1ENC                       \ SPI1 enable
$00002000 constant RCC_S_RCC_APB2ENCR_SPI4ENC                       \ SPI4 enable
$00008000 constant RCC_S_RCC_APB2ENCR_TIM18ENC                      \ TIM18 enable
$00010000 constant RCC_S_RCC_APB2ENCR_TIM15ENC                      \ TIM15 enable
$00020000 constant RCC_S_RCC_APB2ENCR_TIM16ENC                      \ TIM16 enable
$00040000 constant RCC_S_RCC_APB2ENCR_TIM17ENC                      \ TIM17 enable
$00080000 constant RCC_S_RCC_APB2ENCR_TIM9ENC                       \ TIM9 enable
$00100000 constant RCC_S_RCC_APB2ENCR_SPI5ENC                       \ SPI5 enable
$00200000 constant RCC_S_RCC_APB2ENCR_SAI1ENC                       \ SAI1 enable
$00400000 constant RCC_S_RCC_APB2ENCR_SAI2ENC                       \ SAI2 enable


\
\ @brief RCC APB3 enable register
\ Address offset: 0x1270
\ Reset value: 0x00000000
\

$00000004 constant RCC_S_RCC_APB3ENCR_DFTENC                        \ DFT enable


\
\ @brief RCC APB4L enable register
\ Address offset: 0x1274
\ Reset value: 0x00000000
\

$00000004 constant RCC_S_RCC_APB4LENCR_HDPENC                       \ HDP enable
$00000008 constant RCC_S_RCC_APB4LENCR_LPUART1ENC                   \ LPUART1 enable
$00000020 constant RCC_S_RCC_APB4LENCR_SPI6ENC                      \ SPI6 enable
$00000080 constant RCC_S_RCC_APB4LENCR_I2C4ENC                      \ I2C4 enable
$00000200 constant RCC_S_RCC_APB4LENCR_LPTIM2ENC                    \ LPTIM2 enable
$00000400 constant RCC_S_RCC_APB4LENCR_LPTIM3ENC                    \ LPTIM3 enable
$00000800 constant RCC_S_RCC_APB4LENCR_LPTIM4ENC                    \ LPTIM4 enable
$00001000 constant RCC_S_RCC_APB4LENCR_LPTIM5ENC                    \ LPTIM5 enable
$00008000 constant RCC_S_RCC_APB4LENCR_VREFBUFENC                   \ VREFBUF enable
$00010000 constant RCC_S_RCC_APB4LENCR_RTCENC                       \ RTC enable
$00020000 constant RCC_S_RCC_APB4LENCR_RTCAPBENC                    \ RTCAPB enable
$00400000 constant RCC_S_RCC_APB4LENCR_R2GRETENC                    \ R2GRET enable
$00800000 constant RCC_S_RCC_APB4LENCR_R2GNPUENC                    \ R2GNPU enable
$80000000 constant RCC_S_RCC_APB4LENCR_SERFENC                      \ SERF enable


\
\ @brief RCC APB4H enable register
\ Address offset: 0x1278
\ Reset value: 0x00000000
\

$00000001 constant RCC_S_RCC_APB4HENCR_SYSCFGENC                    \ SYSCFG enable
$00000002 constant RCC_S_RCC_APB4HENCR_BSECENC                      \ BSEC enable
$00000004 constant RCC_S_RCC_APB4HENCR_DTSENC                       \ DTS enable
$00000010 constant RCC_S_RCC_APB4HENCR_BUSPERFMENC                  \ BUSPERFM enable


\
\ @brief RCC APB5 enable register
\ Address offset: 0x127C
\ Reset value: 0x00000000
\

$00000002 constant RCC_S_RCC_APB5ENCR_LTDCENC                       \ LTDC enable
$00000004 constant RCC_S_RCC_APB5ENCR_DCMIPPENC                     \ DCMIPP enable
$00000010 constant RCC_S_RCC_APB5ENCR_GFXTIMENC                     \ GFXTIM enable
$00000020 constant RCC_S_RCC_APB5ENCR_VENCENC                       \ VENC enable
$00000040 constant RCC_S_RCC_APB5ENCR_CSIENC                        \ CSI enable


\
\ @brief RCC divider Sleep enable register
\ Address offset: 0x1280
\ Reset value: 0x00000000
\

$00000001 constant RCC_S_RCC_DIVLPENCR_IC1LPENC                     \ IC1 sleep enable
$00000002 constant RCC_S_RCC_DIVLPENCR_IC2LPENC                     \ IC2 sleep enable
$00000004 constant RCC_S_RCC_DIVLPENCR_IC3LPENC                     \ IC3 sleep enable
$00000008 constant RCC_S_RCC_DIVLPENCR_IC4LPENC                     \ IC4 sleep enable
$00000010 constant RCC_S_RCC_DIVLPENCR_IC5LPENC                     \ IC5 sleep enable
$00000020 constant RCC_S_RCC_DIVLPENCR_IC6LPENC                     \ IC6 sleep enable
$00000040 constant RCC_S_RCC_DIVLPENCR_IC7LPENC                     \ IC7 sleep enable
$00000080 constant RCC_S_RCC_DIVLPENCR_IC8LPENC                     \ IC8 sleep enable
$00000100 constant RCC_S_RCC_DIVLPENCR_IC9LPENC                     \ IC9 sleep enable
$00000200 constant RCC_S_RCC_DIVLPENCR_IC10LPENC                    \ IC10 sleep enable
$00000400 constant RCC_S_RCC_DIVLPENCR_IC11LPENC                    \ IC11 sleep enable
$00000800 constant RCC_S_RCC_DIVLPENCR_IC12LPENC                    \ IC12 sleep enable
$00001000 constant RCC_S_RCC_DIVLPENCR_IC13LPENC                    \ IC13 sleep enable
$00002000 constant RCC_S_RCC_DIVLPENCR_IC14LPENC                    \ IC14 sleep enable
$00004000 constant RCC_S_RCC_DIVLPENCR_IC15LPENC                    \ IC15 sleep enable
$00008000 constant RCC_S_RCC_DIVLPENCR_IC16LPENC                    \ IC16 sleep enable
$00010000 constant RCC_S_RCC_DIVLPENCR_IC17LPENC                    \ IC17 sleep enable
$00020000 constant RCC_S_RCC_DIVLPENCR_IC18LPENC                    \ IC18 sleep enable
$00040000 constant RCC_S_RCC_DIVLPENCR_IC19LPENC                    \ IC19 sleep enable
$00080000 constant RCC_S_RCC_DIVLPENCR_IC20LPENC                    \ IC20 sleep enable


\
\ @brief RCC bus Sleep enable register
\ Address offset: 0x1284
\ Reset value: 0x00000000
\

$00000001 constant RCC_S_RCC_BUSLPENCR_ACLKNLPENC                   \ ACLKN sleep enable
$00000002 constant RCC_S_RCC_BUSLPENCR_ACLKNCLPENC                  \ ACLKNC sleep enable
$00000004 constant RCC_S_RCC_BUSLPENCR_AHBMLPENC                    \ AHBM sleep enable
$00000008 constant RCC_S_RCC_BUSLPENCR_AHB1LPENC                    \ AHB1 sleep enable
$00000010 constant RCC_S_RCC_BUSLPENCR_AHB2LPENC                    \ AHB2 sleep enable
$00000020 constant RCC_S_RCC_BUSLPENCR_AHB3LPENC                    \ AHB3 sleep enable
$00000040 constant RCC_S_RCC_BUSLPENCR_AHB4LPENC                    \ AHB4 sleep enable
$00000080 constant RCC_S_RCC_BUSLPENCR_AHB5LPENC                    \ AHB5 sleep enable
$00000100 constant RCC_S_RCC_BUSLPENCR_APB1LPENC                    \ APB1 sleep enable
$00000200 constant RCC_S_RCC_BUSLPENCR_APB2LPENC                    \ APB2 sleep enable
$00000400 constant RCC_S_RCC_BUSLPENCR_APB3LPENC                    \ APB3 sleep enable
$00000800 constant RCC_S_RCC_BUSLPENCR_APB4LPENC                    \ APB4 sleep enable
$00001000 constant RCC_S_RCC_BUSLPENCR_APB5LPENC                    \ APB5 sleep enable


\
\ @brief RCC miscellaneous Sleep enable register
\ Address offset: 0x1288
\ Reset value: 0x00000000
\

$00000001 constant RCC_S_RCC_MISCLPENCR_DBGLPENC                    \ DBG sleep enable
$00000008 constant RCC_S_RCC_MISCLPENCR_XSPIPHYCOMPLPENC            \ XSPIPHYCOMP sleep enable
$00000040 constant RCC_S_RCC_MISCLPENCR_PERLPENC                    \ PER sleep enable


\
\ @brief RCC memory Sleep enable register
\ Address offset: 0x128C
\ Reset value: 0x00000000
\

$00000001 constant RCC_S_RCC_MEMLPENCR_AXISRAM3LPENC                \ AXISRAM3 sleep enable
$00000002 constant RCC_S_RCC_MEMLPENCR_AXISRAM4LPENC                \ AXISRAM4 sleep enable
$00000004 constant RCC_S_RCC_MEMLPENCR_AXISRAM5LPENC                \ AXISRAM5 sleep enable
$00000008 constant RCC_S_RCC_MEMLPENCR_AXISRAM6LPENC                \ AXISRAM6 sleep enable
$00000010 constant RCC_S_RCC_MEMLPENCR_AHBSRAM1LPENC                \ AHBSRAM1 sleep enable
$00000020 constant RCC_S_RCC_MEMLPENCR_AHBSRAM2LPENC                \ AHBSRAM2 sleep enable
$00000040 constant RCC_S_RCC_MEMLPENCR_BKPSRAMLPENC                 \ BKPSRAM sleep enable
$00000080 constant RCC_S_RCC_MEMLPENCR_AXISRAM1LPENC                \ AXISRAM1 sleep enable
$00000100 constant RCC_S_RCC_MEMLPENCR_AXISRAM2LPENC                \ AXISRAM2 sleep enable
$00000200 constant RCC_S_RCC_MEMLPENCR_FLEXRAMLPENC                 \ FLEXRAM sleep enable
$00000400 constant RCC_S_RCC_MEMLPENCR_NPUCACHERAMLPENC             \ NPUCACHERAM sleep enable
$00000800 constant RCC_S_RCC_MEMLPENCR_VENCRAMLPENC                 \ VENCRAM sleep enable
$00001000 constant RCC_S_RCC_MEMLPENCR_BOOTROMLPENC                 \ BOOTROM sleep enable


\
\ @brief RCC AHB1 Sleep enable register
\ Address offset: 0x1290
\ Reset value: 0x00000000
\

$00000010 constant RCC_S_RCC_AHB1LPENCR_GPDMA1LPENC                 \ GPDMA1 sleep enable
$00000020 constant RCC_S_RCC_AHB1LPENCR_ADC12LPENC                  \ ADC12 sleep enable


\
\ @brief RCC AHB2 Sleep enable register
\ Address offset: 0x1294
\ Reset value: 0x00000000
\

$00001000 constant RCC_S_RCC_AHB2LPENCR_RAMCFGLPENC                 \ RAMCFG sleep enable
$00010000 constant RCC_S_RCC_AHB2LPENCR_MDF1LPENC                   \ MDF1 sleep enable
$00020000 constant RCC_S_RCC_AHB2LPENCR_ADF1LPENC                   \ ADF1 sleep enable


\
\ @brief RCC AHB3 Sleep enable register
\ Address offset: 0x1298
\ Reset value: 0x00000000
\

$00000001 constant RCC_S_RCC_AHB3LPENCR_RNGLPENC                    \ RNG sleep enable
$00000002 constant RCC_S_RCC_AHB3LPENCR_HASHLPENC                   \ HASH sleep enable
$00000004 constant RCC_S_RCC_AHB3LPENCR_CRYPLPENC                   \ CRYP sleep enable
$00000010 constant RCC_S_RCC_AHB3LPENCR_SAESLPENC                   \ SAES sleep enable
$00000100 constant RCC_S_RCC_AHB3LPENCR_PKALPENC                    \ PKA sleep enable
$00000200 constant RCC_S_RCC_AHB3LPENCR_RIFSCLPENC                  \ RIFSC sleep enable
$00000400 constant RCC_S_RCC_AHB3LPENCR_IACLPENC                    \ IAC sleep enable
$00004000 constant RCC_S_RCC_AHB3LPENCR_RISAFLPENC                  \ RISAF sleep enable


\
\ @brief RCC AHB4 Sleep enable register
\ Address offset: 0x129C
\ Reset value: 0x00000000
\

$00000001 constant RCC_S_RCC_AHB4LPENCR_GPIOALPENC                  \ GPIOA sleep enable
$00000002 constant RCC_S_RCC_AHB4LPENCR_GPIOBLPENC                  \ GPIOB sleep enable
$00000004 constant RCC_S_RCC_AHB4LPENCR_GPIOCLPENC                  \ GPIOC sleep enable
$00000008 constant RCC_S_RCC_AHB4LPENCR_GPIODLPENC                  \ GPIOD sleep enable
$00000010 constant RCC_S_RCC_AHB4LPENCR_GPIOELPENC                  \ GPIOE sleep enable
$00000020 constant RCC_S_RCC_AHB4LPENCR_GPIOFLPENC                  \ GPIOF sleep enable
$00000040 constant RCC_S_RCC_AHB4LPENCR_GPIOGLPENC                  \ GPIOG sleep enable
$00000080 constant RCC_S_RCC_AHB4LPENCR_GPIOHLPENC                  \ GPIOH sleep enable
$00002000 constant RCC_S_RCC_AHB4LPENCR_GPIONLPENC                  \ GPION sleep enable
$00004000 constant RCC_S_RCC_AHB4LPENCR_GPIOOLPENC                  \ GPIOO sleep enable
$00008000 constant RCC_S_RCC_AHB4LPENCR_GPIOPLPENC                  \ GPIOP sleep enable
$00010000 constant RCC_S_RCC_AHB4LPENCR_GPIOQLPENC                  \ GPIOQ sleep enable
$00040000 constant RCC_S_RCC_AHB4LPENCR_PWRLPENC                    \ PWR sleep enable
$00080000 constant RCC_S_RCC_AHB4LPENCR_CRCLPENC                    \ CRC sleep enable


\
\ @brief RCC AHB5 Sleep enable register
\ Address offset: 0x12A0
\ Reset value: 0x00000000
\

$00000001 constant RCC_S_RCC_AHB5LPENCR_HPDMA1LPENC                 \ HPDMA1 sleep enable
$00000002 constant RCC_S_RCC_AHB5LPENCR_DMA2DLPENC                  \ DMA2D sleep enable
$00000008 constant RCC_S_RCC_AHB5LPENCR_JPEGLPENC                   \ JPEG sleep enable
$00000010 constant RCC_S_RCC_AHB5LPENCR_FMCLPENC                    \ FMC sleep enable
$00000020 constant RCC_S_RCC_AHB5LPENCR_XSPI1LPENC                  \ XSPI1 sleep enable
$00000040 constant RCC_S_RCC_AHB5LPENCR_PSSILPENC                   \ PSSI sleep enable
$00000080 constant RCC_S_RCC_AHB5LPENCR_SDMMC2LPENC                 \ SDMMC2 sleep enable
$00000100 constant RCC_S_RCC_AHB5LPENCR_SDMMC1LPENC                 \ SDMMC1 sleep enable
$00001000 constant RCC_S_RCC_AHB5LPENCR_XSPI2LPENC                  \ XSPI2 sleep enable
$00002000 constant RCC_S_RCC_AHB5LPENCR_XSPIMLPENC                  \ XSPIM sleep enable
$00004000 constant RCC_S_RCC_AHB5LPENCR_MCE1LPENC                   \ MCE1 sleep enable
$00008000 constant RCC_S_RCC_AHB5LPENCR_MCE2LPENC                   \ MCE2 sleep enable
$00010000 constant RCC_S_RCC_AHB5LPENCR_MCE3LPENC                   \ MCE3 sleep enable
$00020000 constant RCC_S_RCC_AHB5LPENCR_XSPI3LPENC                  \ XSPI3 sleep enable
$00040000 constant RCC_S_RCC_AHB5LPENCR_MCE4LPENC                   \ MCE4 sleep enable
$00080000 constant RCC_S_RCC_AHB5LPENCR_GFXMMULPENC                 \ GFXMMU sleep enable
$00100000 constant RCC_S_RCC_AHB5LPENCR_GPULPENC                    \ GPU sleep enable
$00400000 constant RCC_S_RCC_AHB5LPENCR_ETH1MACLPENC                \ ETH1MAC sleep enable
$00800000 constant RCC_S_RCC_AHB5LPENCR_ETH1TXLPENC                 \ ETH1TX sleep enable
$01000000 constant RCC_S_RCC_AHB5LPENCR_ETH1RXLPENC                 \ ETH1RX sleep enable
$02000000 constant RCC_S_RCC_AHB5LPENCR_ETH1LPENC                   \ ETH1 sleep enable
$04000000 constant RCC_S_RCC_AHB5LPENCR_OTG1LPENC                   \ OTG1 sleep enable
$08000000 constant RCC_S_RCC_AHB5LPENCR_OTGPHY1LPENC                \ OTGPHY1 sleep enable
$10000000 constant RCC_S_RCC_AHB5LPENCR_OTGPHY2LPENC                \ OTGPHY2 sleep enable
$20000000 constant RCC_S_RCC_AHB5LPENCR_OTG2LPENC                   \ OTG2 sleep enable
$40000000 constant RCC_S_RCC_AHB5LPENCR_NPUCACHELPENC               \ NPUCACHE sleep enable
$80000000 constant RCC_S_RCC_AHB5LPENCR_NPULPENC                    \ NPU sleep enable


\
\ @brief RCC APB1L Sleep enable register
\ Address offset: 0x12A4
\ Reset value: 0x00000000
\

$00000001 constant RCC_S_RCC_APB1LLPENCR_TIM2LPENC                  \ TIM2 sleep enable
$00000002 constant RCC_S_RCC_APB1LLPENCR_TIM3LPENC                  \ TIM3 sleep enable
$00000004 constant RCC_S_RCC_APB1LLPENCR_TIM4LPENC                  \ TIM4 sleep enable
$00000008 constant RCC_S_RCC_APB1LLPENCR_TIM5LPENC                  \ TIM5 sleep enable
$00000010 constant RCC_S_RCC_APB1LLPENCR_TIM6LPENC                  \ TIM6 sleep enable
$00000020 constant RCC_S_RCC_APB1LLPENCR_TIM7LPENC                  \ TIM7 sleep enable
$00000040 constant RCC_S_RCC_APB1LLPENCR_TIM12LPENC                 \ TIM12 sleep enable
$00000080 constant RCC_S_RCC_APB1LLPENCR_TIM13LPENC                 \ TIM13 sleep enable
$00000100 constant RCC_S_RCC_APB1LLPENCR_TIM14LPENC                 \ TIM14 sleep enable
$00000200 constant RCC_S_RCC_APB1LLPENCR_LPTIM1LPENC                \ LPTIM1 sleep enable
$00000800 constant RCC_S_RCC_APB1LLPENCR_WWDGLPENC                  \ WWDG sleep enable
$00001000 constant RCC_S_RCC_APB1LLPENCR_TIM10LPENC                 \ TIM10 sleep enable
$00002000 constant RCC_S_RCC_APB1LLPENCR_TIM11LPENC                 \ TIM11 sleep enable
$00004000 constant RCC_S_RCC_APB1LLPENCR_SPI2LPENC                  \ SPI2 sleep enable
$00008000 constant RCC_S_RCC_APB1LLPENCR_SPI3LPENC                  \ SPI3 sleep enable
$00010000 constant RCC_S_RCC_APB1LLPENCR_SPDIFRX1LPENC              \ SPDIFRX1 sleep enable
$00020000 constant RCC_S_RCC_APB1LLPENCR_USART2LPENC                \ USART2 sleep enable
$00040000 constant RCC_S_RCC_APB1LLPENCR_USART3LPENC                \ USART3 sleep enable
$00080000 constant RCC_S_RCC_APB1LLPENCR_UART4LPENC                 \ UART4 sleep enable
$00100000 constant RCC_S_RCC_APB1LLPENCR_UART5LPENC                 \ UART5 sleep enable
$00200000 constant RCC_S_RCC_APB1LLPENCR_I2C1LPENC                  \ I2C1 sleep enable
$00400000 constant RCC_S_RCC_APB1LLPENCR_I2C2LPENC                  \ I2C2 sleep enable
$00800000 constant RCC_S_RCC_APB1LLPENCR_I2C3LPENC                  \ I2C3 sleep enable
$01000000 constant RCC_S_RCC_APB1LLPENCR_I3C1LPENC                  \ I3C1 sleep enable
$02000000 constant RCC_S_RCC_APB1LLPENCR_I3C2LPENC                  \ I3C2 sleep enable
$40000000 constant RCC_S_RCC_APB1LLPENCR_UART7LPENC                 \ UART7 sleep enable
$80000000 constant RCC_S_RCC_APB1LLPENCR_UART8LPENC                 \ UART8 sleep enable


\
\ @brief RCC APB1H Sleep enable register
\ Address offset: 0x12A8
\ Reset value: 0x00000000
\

$00000020 constant RCC_S_RCC_APB1HLPENCR_MDIOSLPENC                 \ MDIOS sleep enable
$00000100 constant RCC_S_RCC_APB1HLPENCR_FDCANLPENC                 \ FDCAN sleep enable
$00040000 constant RCC_S_RCC_APB1HLPENCR_UCPD1LPENC                 \ UCPD1 sleep enable


\
\ @brief RCC APB2 Sleep enable register
\ Address offset: 0x12AC
\ Reset value: 0x00000000
\

$00000001 constant RCC_S_RCC_APB2LPENCR_TIM1LPENC                   \ TIM1 sleep enable
$00000002 constant RCC_S_RCC_APB2LPENCR_TIM8LPENC                   \ TIM8 sleep enable
$00000010 constant RCC_S_RCC_APB2LPENCR_USART1LPENC                 \ USART1 sleep enable
$00000020 constant RCC_S_RCC_APB2LPENCR_USART6LPENC                 \ USART6 sleep enable
$00000040 constant RCC_S_RCC_APB2LPENCR_UART9LPENC                  \ UART9 sleep enable
$00000080 constant RCC_S_RCC_APB2LPENCR_USART10LPENC                \ USART10 sleep enable
$00001000 constant RCC_S_RCC_APB2LPENCR_SPI1LPENC                   \ SPI1 sleep enable
$00002000 constant RCC_S_RCC_APB2LPENCR_SPI4LPENC                   \ SPI4 sleep enable
$00008000 constant RCC_S_RCC_APB2LPENCR_TIM18LPENC                  \ TIM18 sleep enable
$00010000 constant RCC_S_RCC_APB2LPENCR_TIM15LPENC                  \ TIM15 sleep enable
$00020000 constant RCC_S_RCC_APB2LPENCR_TIM16LPENC                  \ TIM16 sleep enable
$00040000 constant RCC_S_RCC_APB2LPENCR_TIM17LPENC                  \ TIM17 sleep enable
$00080000 constant RCC_S_RCC_APB2LPENCR_TIM9LPENC                   \ TIM9 sleep enable
$00100000 constant RCC_S_RCC_APB2LPENCR_SPI5LPENC                   \ SPI5 sleep enable
$00200000 constant RCC_S_RCC_APB2LPENCR_SAI1LPENC                   \ SAI1 sleep enable
$00400000 constant RCC_S_RCC_APB2LPENCR_SAI2LPENC                   \ SAI2 sleep enable


\
\ @brief RCC APB3 Sleep enable register
\ Address offset: 0x12B0
\ Reset value: 0x00000000
\

$00000004 constant RCC_S_RCC_APB3LPENCR_DFTLPENC                    \ DFT sleep enable


\
\ @brief RCC APB4L Sleep enable register
\ Address offset: 0x12B4
\ Reset value: 0x00000000
\

$00000004 constant RCC_S_RCC_APB4LLPENCR_HDPLPENC                   \ HDP sleep enable
$00000008 constant RCC_S_RCC_APB4LLPENCR_LPUART1LPENC               \ LPUART1 sleep enable
$00000020 constant RCC_S_RCC_APB4LLPENCR_SPI6LPENC                  \ SPI6 sleep enable
$00000080 constant RCC_S_RCC_APB4LLPENCR_I2C4LPENC                  \ I2C4 sleep enable
$00000200 constant RCC_S_RCC_APB4LLPENCR_LPTIM2LPENC                \ LPTIM2 sleep enable
$00000400 constant RCC_S_RCC_APB4LLPENCR_LPTIM3LPENC                \ LPTIM3 sleep enable
$00000800 constant RCC_S_RCC_APB4LLPENCR_LPTIM4LPENC                \ LPTIM4 sleep enable
$00001000 constant RCC_S_RCC_APB4LLPENCR_LPTIM5LPENC                \ LPTIM5 sleep enable
$00008000 constant RCC_S_RCC_APB4LLPENCR_VREFBUFLPENC               \ VREFBUF sleep enable
$00010000 constant RCC_S_RCC_APB4LLPENCR_RTCLPENC                   \ RTC sleep enable
$00020000 constant RCC_S_RCC_APB4LLPENCR_RTCAPBLPENC                \ RTCAPB sleep enable
$00400000 constant RCC_S_RCC_APB4LLPENCR_R2GRETLPENC                \ R2GRET sleep enable
$00800000 constant RCC_S_RCC_APB4LLPENCR_R2GNPULPENC                \ R2GNPU sleep enable
$80000000 constant RCC_S_RCC_APB4LLPENCR_SERFLPENC                  \ SERF sleep enable


\
\ @brief RCC APB4H Sleep enable register
\ Address offset: 0x12B8
\ Reset value: 0x00000000
\

$00000001 constant RCC_S_RCC_APB4HLPENCR_SYSCFGLPENC                \ SYSCFG sleep enable
$00000002 constant RCC_S_RCC_APB4HLPENCR_BSECLPENC                  \ BSEC sleep enable
$00000004 constant RCC_S_RCC_APB4HLPENCR_DTSLPENC                   \ DTS sleep enable
$00000010 constant RCC_S_RCC_APB4HLPENCR_BUSPERFMLPENC              \ BUSPERFM sleep enable


\
\ @brief RCC APB5 Sleep enable register
\ Address offset: 0x12BC
\ Reset value: 0x00000000
\

$00000002 constant RCC_S_RCC_APB5LPENCR_LTDCLPENC                   \ LTDC sleep enable
$00000004 constant RCC_S_RCC_APB5LPENCR_DCMIPPLPENC                 \ DCMIPP sleep enable
$00000010 constant RCC_S_RCC_APB5LPENCR_GFXTIMLPENC                 \ GFXTIM sleep enable
$00000020 constant RCC_S_RCC_APB5LPENCR_VENCLPENC                   \ VENC sleep enable
$00000040 constant RCC_S_RCC_APB5LPENCR_CSILPENC                    \ CSI sleep enable


\
\ @brief RCC oscillator privilege configuration register0
\ Address offset: 0x1784
\ Reset value: 0x00000000
\

$00000001 constant RCC_S_RCC_PRIVCFGCR0_LSIPVC                      \ Defines the privilege protection of the LSI configuration bits (enable, ready, divider).
$00000002 constant RCC_S_RCC_PRIVCFGCR0_LSEPVC                      \ Defines the privilege protection of the LSE configuration bits (enable, ready, divider).
$00000004 constant RCC_S_RCC_PRIVCFGCR0_MSIPVC                      \ Defines the privilege protection of the MSI configuration bits (enable, ready, divider).
$00000008 constant RCC_S_RCC_PRIVCFGCR0_HSIPVC                      \ Defines the privilege protection of the HSI configuration bits (enable, ready, divider).
$00000010 constant RCC_S_RCC_PRIVCFGCR0_HSEPVC                      \ Defines the privilege protection of the HSE configuration bits (enable, ready, divider).


\
\ @brief RCC oscillator public configuration register0
\ Address offset: 0x178C
\ Reset value: 0x00000000
\

$00000001 constant RCC_S_RCC_PUBCFGCR0_LSIPUBC                      \ Defines the public protection of the LSI configuration bits (enable, ready, divider).
$00000002 constant RCC_S_RCC_PUBCFGCR0_LSEPUBC                      \ Defines the public protection of the LSE configuration bits (enable, ready, divider).
$00000004 constant RCC_S_RCC_PUBCFGCR0_MSIPUBC                      \ Defines the public protection of the MSI configuration bits (enable, ready, divider).
$00000008 constant RCC_S_RCC_PUBCFGCR0_HSIPUBC                      \ Defines the public protection of the HSI configuration bits (enable, ready, divider).
$00000010 constant RCC_S_RCC_PUBCFGCR0_HSEPUBC                      \ Defines the public protection of the HSE configuration bits (enable, ready, divider).


\
\ @brief RCC PLL privilege configuration register1
\ Address offset: 0x1794
\ Reset value: 0x00000000
\

$00000001 constant RCC_S_RCC_PRIVCFGCR1_PLL1PVC                     \ Defines the privilege protection of the PLL1 configuration bits (enable, ready, divider).
$00000002 constant RCC_S_RCC_PRIVCFGCR1_PLL2PVC                     \ Defines the privilege protection of the PLL2 configuration bits (enable, ready, divider).
$00000004 constant RCC_S_RCC_PRIVCFGCR1_PLL3PVC                     \ Defines the privilege protection of the PLL3 configuration bits (enable, ready, divider).
$00000008 constant RCC_S_RCC_PRIVCFGCR1_PLL4PVC                     \ Defines the privilege protection of the PLL4 configuration bits (enable, ready, divider).


\
\ @brief RCC PLL public configuration register1
\ Address offset: 0x179C
\ Reset value: 0x00000000
\

$00000001 constant RCC_S_RCC_PUBCFGCR1_PLL1PUBC                     \ Defines the public protection of the PLL1 configuration bits (enable, ready, divider).
$00000002 constant RCC_S_RCC_PUBCFGCR1_PLL2PUBC                     \ Defines the public protection of the PLL2 configuration bits (enable, ready, divider).
$00000004 constant RCC_S_RCC_PUBCFGCR1_PLL3PUBC                     \ Defines the public protection of the PLL3 configuration bits (enable, ready, divider).
$00000008 constant RCC_S_RCC_PUBCFGCR1_PLL4PUBC                     \ Defines the public protection of the PLL4 configuration bits (enable, ready, divider).


\
\ @brief RCC divider privilege configuration register2
\ Address offset: 0x17A4
\ Reset value: 0x00000000
\

$00000001 constant RCC_S_RCC_PRIVCFGCR2_IC1PVC                      \ Defines the privilege protection of the IC1 configuration bits (enable, ready, divider).
$00000002 constant RCC_S_RCC_PRIVCFGCR2_IC2PVC                      \ Defines the privilege protection of the IC2 configuration bits (enable, ready, divider).
$00000004 constant RCC_S_RCC_PRIVCFGCR2_IC3PVC                      \ Defines the privilege protection of the IC3 configuration bits (enable, ready, divider).
$00000008 constant RCC_S_RCC_PRIVCFGCR2_IC4PVC                      \ Defines the privilege protection of the IC4 configuration bits (enable, ready, divider).
$00000010 constant RCC_S_RCC_PRIVCFGCR2_IC5PVC                      \ Defines the privilege protection of the IC5 configuration bits (enable, ready, divider).
$00000020 constant RCC_S_RCC_PRIVCFGCR2_IC6PVC                      \ Defines the privilege protection of the IC6 configuration bits (enable, ready, divider).
$00000040 constant RCC_S_RCC_PRIVCFGCR2_IC7PVC                      \ Defines the privilege protection of the IC7 configuration bits (enable, ready, divider).
$00000080 constant RCC_S_RCC_PRIVCFGCR2_IC8PVC                      \ Defines the privilege protection of the IC8 configuration bits (enable, ready, divider).
$00000100 constant RCC_S_RCC_PRIVCFGCR2_IC9PVC                      \ Defines the privilege protection of the IC9 configuration bits (enable, ready, divider).
$00000200 constant RCC_S_RCC_PRIVCFGCR2_IC10PVC                     \ Defines the privilege protection of the IC10 configuration bits (enable, ready, divider).
$00000400 constant RCC_S_RCC_PRIVCFGCR2_IC11PVC                     \ Defines the privilege protection of the IC11 configuration bits (enable, ready, divider).
$00000800 constant RCC_S_RCC_PRIVCFGCR2_IC12PVC                     \ Defines the privilege protection of the IC12 configuration bits (enable, ready, divider).
$00001000 constant RCC_S_RCC_PRIVCFGCR2_IC13PVC                     \ Defines the privilege protection of the IC13 configuration bits (enable, ready, divider).
$00002000 constant RCC_S_RCC_PRIVCFGCR2_IC14PVC                     \ Defines the privilege protection of the IC14 configuration bits (enable, ready, divider).
$00004000 constant RCC_S_RCC_PRIVCFGCR2_IC15PVC                     \ Defines the privilege protection of the IC15 configuration bits (enable, ready, divider).
$00008000 constant RCC_S_RCC_PRIVCFGCR2_IC16PVC                     \ Defines the privilege protection of the IC16 configuration bits (enable, ready, divider).
$00010000 constant RCC_S_RCC_PRIVCFGCR2_IC17PVC                     \ Defines the privilege protection of the IC17 configuration bits (enable, ready, divider).
$00020000 constant RCC_S_RCC_PRIVCFGCR2_IC18PVC                     \ Defines the privilege protection of the IC18 configuration bits (enable, ready, divider).
$00040000 constant RCC_S_RCC_PRIVCFGCR2_IC19PVC                     \ Defines the privilege protection of the IC19 configuration bits (enable, ready, divider).
$00080000 constant RCC_S_RCC_PRIVCFGCR2_IC20PVC                     \ Defines the privilege protection of the IC20 configuration bits (enable, ready, divider).


\
\ @brief RCC divider public configuration register2
\ Address offset: 0x17AC
\ Reset value: 0x00000000
\

$00000001 constant RCC_S_RCC_PUBCFGCR2_IC1PUBC                      \ Defines the public protection of the IC1 configuration bits (enable, ready, divider).
$00000002 constant RCC_S_RCC_PUBCFGCR2_IC2PUBC                      \ Defines the public protection of the IC2 configuration bits (enable, ready, divider).
$00000004 constant RCC_S_RCC_PUBCFGCR2_IC3PUBC                      \ Defines the public protection of the IC3 configuration bits (enable, ready, divider).
$00000008 constant RCC_S_RCC_PUBCFGCR2_IC4PUBC                      \ Defines the public protection of the IC4 configuration bits (enable, ready, divider).
$00000010 constant RCC_S_RCC_PUBCFGCR2_IC5PUBC                      \ Defines the public protection of the IC5 configuration bits (enable, ready, divider).
$00000020 constant RCC_S_RCC_PUBCFGCR2_IC6PUBC                      \ Defines the public protection of the IC6 configuration bits (enable, ready, divider).
$00000040 constant RCC_S_RCC_PUBCFGCR2_IC7PUBC                      \ Defines the public protection of the IC7 configuration bits (enable, ready, divider).
$00000080 constant RCC_S_RCC_PUBCFGCR2_IC8PUBC                      \ Defines the public protection of the IC8 configuration bits (enable, ready, divider).
$00000100 constant RCC_S_RCC_PUBCFGCR2_IC9PUBC                      \ Defines the public protection of the IC9 configuration bits (enable, ready, divider).
$00000200 constant RCC_S_RCC_PUBCFGCR2_IC10PUBC                     \ Defines the public protection of the IC10 configuration bits (enable, ready, divider).
$00000400 constant RCC_S_RCC_PUBCFGCR2_IC11PUBC                     \ Defines the public protection of the IC11 configuration bits (enable, ready, divider).
$00000800 constant RCC_S_RCC_PUBCFGCR2_IC12PUBC                     \ Defines the public protection of the IC12 configuration bits (enable, ready, divider).
$00001000 constant RCC_S_RCC_PUBCFGCR2_IC13PUBC                     \ Defines the public protection of the IC13 configuration bits (enable, ready, divider).
$00002000 constant RCC_S_RCC_PUBCFGCR2_IC14PUBC                     \ Defines the public protection of the IC14 configuration bits (enable, ready, divider).
$00004000 constant RCC_S_RCC_PUBCFGCR2_IC15PUBC                     \ Defines the public protection of the IC15 configuration bits (enable, ready, divider).
$00008000 constant RCC_S_RCC_PUBCFGCR2_IC16PUBC                     \ Defines the public protection of the IC16 configuration bits (enable, ready, divider).
$00010000 constant RCC_S_RCC_PUBCFGCR2_IC17PUBC                     \ Defines the public protection of the IC17 configuration bits (enable, ready, divider).
$00020000 constant RCC_S_RCC_PUBCFGCR2_IC18PUBC                     \ Defines the public protection of the IC18 configuration bits (enable, ready, divider).
$00040000 constant RCC_S_RCC_PUBCFGCR2_IC19PUBC                     \ Defines the public protection of the IC19 configuration bits (enable, ready, divider).
$00080000 constant RCC_S_RCC_PUBCFGCR2_IC20PUBC                     \ Defines the public protection of the IC20 configuration bits (enable, ready, divider).


\
\ @brief RCC system privilege configuration register3
\ Address offset: 0x17B4
\ Reset value: 0x00000000
\

$00000001 constant RCC_S_RCC_PRIVCFGCR3_MODPVC                      \ Defines the privilege protection of the MOD configuration bits (enable, ready, divider).
$00000002 constant RCC_S_RCC_PRIVCFGCR3_SYSPVC                      \ Defines the privilege protection of the SYS configuration bits (enable, ready, divider).
$00000004 constant RCC_S_RCC_PRIVCFGCR3_BUSPVC                      \ Defines the privilege protection of the BUS configuration bits (enable, ready, divider).
$00000008 constant RCC_S_RCC_PRIVCFGCR3_PERPVC                      \ Defines the privilege protection of the PER configuration bits (enable, ready, divider).
$00000010 constant RCC_S_RCC_PRIVCFGCR3_INTPVC                      \ Defines the privilege protection of the INT configuration bits (enable, ready, divider).
$00000020 constant RCC_S_RCC_PRIVCFGCR3_RSTPVC                      \ Defines the privilege protection of the RST configuration bits (enable, ready, divider).
$00000040 constant RCC_S_RCC_PRIVCFGCR3_DFTPVC                      \ Defines the privilege protection of the DFT configuration bits (enable, ready, divider).


\
\ @brief RCC system public configuration register3
\ Address offset: 0x17BC
\ Reset value: 0x00000000
\

$00000001 constant RCC_S_RCC_PUBCFGCR3_MODPUBC                      \ Defines the public protection of the MOD configuration bits (enable, ready, divider).
$00000002 constant RCC_S_RCC_PUBCFGCR3_SYSPUBC                      \ Defines the public protection of the SYS configuration bits (enable, ready, divider).
$00000004 constant RCC_S_RCC_PUBCFGCR3_BUSPUBC                      \ Defines the public protection of the BUS configuration bits (enable, ready, divider).
$00000008 constant RCC_S_RCC_PUBCFGCR3_PERPUBC                      \ Defines the public protection of the PER configuration bits (enable, ready, divider).
$00000010 constant RCC_S_RCC_PUBCFGCR3_INTPUBC                      \ Defines the public protection of the INT configuration bits (enable, ready, divider).
$00000020 constant RCC_S_RCC_PUBCFGCR3_RSTPUBC                      \ Defines the public protection of the RST configuration bits (enable, ready, divider).
$00000040 constant RCC_S_RCC_PUBCFGCR3_DFTPUBC                      \ Defines the public protection of the DFT configuration bits (enable, ready, divider).


\
\ @brief RCC privilege configuration register4
\ Address offset: 0x17C4
\ Reset value: 0x00000000
\

$00000001 constant RCC_S_RCC_PRIVCFGCR4_ACLKNPVC                    \ Defines the privilege protection of the ACLKN configuration bits (enable, ready, divider).
$00000002 constant RCC_S_RCC_PRIVCFGCR4_ACLKNCPVC                   \ Defines the privilege protection of the ACLKNC configuration bits (enable, ready, divider).
$00000004 constant RCC_S_RCC_PRIVCFGCR4_AHBMPVC                     \ Defines the privilege protection of the AHBM configuration bits (enable, ready, divider).
$00000008 constant RCC_S_RCC_PRIVCFGCR4_AHB1PVC                     \ Defines the privilege protection of the AHB1 configuration bits (enable, ready, divider).
$00000010 constant RCC_S_RCC_PRIVCFGCR4_AHB2PVC                     \ Defines the privilege protection of the AHB2 configuration bits (enable, ready, divider).
$00000020 constant RCC_S_RCC_PRIVCFGCR4_AHB3PVC                     \ Defines the privilege protection of the AHB3 configuration bits (enable, ready, divider).
$00000040 constant RCC_S_RCC_PRIVCFGCR4_AHB4PVC                     \ Defines the privilege protection of the AHB4 configuration bits (enable, ready, divider).
$00000080 constant RCC_S_RCC_PRIVCFGCR4_AHB5PVC                     \ Defines the privilege protection of the AHB5 configuration bits (enable, ready, divider).
$00000100 constant RCC_S_RCC_PRIVCFGCR4_APB1PVC                     \ Defines the privilege protection of the APB1 configuration bits (enable, ready, divider).
$00000200 constant RCC_S_RCC_PRIVCFGCR4_APB2PVC                     \ Defines the privilege protection of the APB2 configuration bits (enable, ready, divider).
$00000400 constant RCC_S_RCC_PRIVCFGCR4_APB3PVC                     \ Defines the privilege protection of the APB3 configuration bits (enable, ready, divider).
$00000800 constant RCC_S_RCC_PRIVCFGCR4_APB4PVC                     \ Defines the privilege protection of the APB4 configuration bits (enable, ready, divider).
$00001000 constant RCC_S_RCC_PRIVCFGCR4_APB5PVC                     \ Defines the privilege protection of the APB5 configuration bits (enable, ready, divider).
$00002000 constant RCC_S_RCC_PRIVCFGCR4_NOCPVC                      \ Defines the privilege protection of the NOC configuration bits (enable, ready, divider).


\
\ @brief RCC public configuration register4
\ Address offset: 0x17CC
\ Reset value: 0x00000000
\

$00000001 constant RCC_S_RCC_PUBCFGCR4_ACLKNPUBC                    \ Defines the public protection of the ACLKN configuration bits (enable, ready, divider).
$00000002 constant RCC_S_RCC_PUBCFGCR4_ACLKNCPUBC                   \ Defines the public protection of the ACLKNC configuration bits (enable, ready, divider).
$00000004 constant RCC_S_RCC_PUBCFGCR4_AHBMPUBC                     \ Defines the public protection of the AHBM configuration bits (enable, ready, divider).
$00000008 constant RCC_S_RCC_PUBCFGCR4_AHB1PUBC                     \ Defines the public protection of the AHB1 configuration bits (enable, ready, divider).
$00000010 constant RCC_S_RCC_PUBCFGCR4_AHB2PUBC                     \ Defines the public protection of the AHB2 configuration bits (enable, ready, divider).
$00000020 constant RCC_S_RCC_PUBCFGCR4_AHB3PUBC                     \ Defines the public protection of the AHB3 configuration bits (enable, ready, divider).
$00000040 constant RCC_S_RCC_PUBCFGCR4_AHB4PUBC                     \ Defines the public protection of the AHB4 configuration bits (enable, ready, divider).
$00000080 constant RCC_S_RCC_PUBCFGCR4_AHB5PUBC                     \ Defines the public protection of the AHB5 configuration bits (enable, ready, divider).
$00000100 constant RCC_S_RCC_PUBCFGCR4_APB1PUBC                     \ Defines the public protection of the APB1 configuration bits (enable, ready, divider).
$00000200 constant RCC_S_RCC_PUBCFGCR4_APB2PUBC                     \ Defines the public protection of the APB2 configuration bits (enable, ready, divider).
$00000400 constant RCC_S_RCC_PUBCFGCR4_APB3PUBC                     \ Defines the public protection of the APB3 configuration bits (enable, ready, divider).
$00000800 constant RCC_S_RCC_PUBCFGCR4_APB4PUBC                     \ Defines the public protection of the APB4 configuration bits (enable, ready, divider).
$00001000 constant RCC_S_RCC_PUBCFGCR4_APB5PUBC                     \ Defines the public protection of the APB5 configuration bits (enable, ready, divider).
$00002000 constant RCC_S_RCC_PUBCFGCR4_NOCPUBC                      \ Defines the public protection of the NOC configuration bits (enable, ready, divider).


\
\ @brief RCC public configuration register4
\ Address offset: 0x17D0
\ Reset value: 0x00000000
\

$00000001 constant RCC_S_RCC_PUBCFGCR5_AXISRAM3PUBC                 \ Defines the public protection of the AXISRAM3 configuration bits (enable, ready, divider).
$00000002 constant RCC_S_RCC_PUBCFGCR5_AXISRAM4PUBC                 \ Defines the public protection of the AXISRAM4 configuration bits (enable, ready, divider).
$00000004 constant RCC_S_RCC_PUBCFGCR5_AXISRAM5PUBC                 \ Defines the public protection of the AXISRAM5 configuration bits (enable, ready, divider).
$00000008 constant RCC_S_RCC_PUBCFGCR5_AXISRAM6PUBC                 \ Defines the public protection of the AXISRAM6 configuration bits (enable, ready, divider).
$00000010 constant RCC_S_RCC_PUBCFGCR5_AHBSRAM1PUBC                 \ Defines the public protection of the AHBSRAM1 configuration bits (enable, ready, divider).
$00000020 constant RCC_S_RCC_PUBCFGCR5_AHBSRAM2PUBC                 \ Defines the public protection of the AHBSRAM2 configuration bits (enable, ready, divider).
$00000040 constant RCC_S_RCC_PUBCFGCR5_BKPSRAMPUBC                  \ Defines the public protection of the BKPSRAM configuration bits (enable, ready, divider).
$00000080 constant RCC_S_RCC_PUBCFGCR5_AXISRAM1PUBC                 \ Defines the public protection of the AXISRAM1 configuration bits (enable, ready, divider).
$00000100 constant RCC_S_RCC_PUBCFGCR5_AXISRAM2PUBC                 \ Defines the public protection of the AXISRAM2 configuration bits (enable, ready, divider).
$00000200 constant RCC_S_RCC_PUBCFGCR5_FLEXRAMPUBC                  \ Defines the public protection of the FLEXRAM configuration bits (enable, ready, divider).
$00000400 constant RCC_S_RCC_PUBCFGCR5_CACHEAXIRAMPUBC              \ Defines the public protection of the NPUCACHERAM configuration bits (enable, ready, divider).
$00000800 constant RCC_S_RCC_PUBCFGCR5_VENCRAMPUBC                  \ Defines the public protection of the VENCRAM configuration bits (enable, ready, divider).


\
\ @brief RCC global secure interrupt
\
$56028000 constant RCC_S_RCC_CR   \ offset: 0x00 : RCC control register
$56028004 constant RCC_S_RCC_SR   \ offset: 0x04 : RCC status register
$56028008 constant RCC_S_RCC_STOPCR  \ offset: 0x08 : RCC Stop mode control register
$56028020 constant RCC_S_RCC_CFGR1  \ offset: 0x20 : RCC configuration register 1
$56028024 constant RCC_S_RCC_CFGR2  \ offset: 0x24 : RCC configuration register 2
$56028028 constant RCC_S_RCC_CKPROTR  \ offset: 0x28 : RCC clock protection register
$5602802c constant RCC_S_RCC_BDCR  \ offset: 0x2C : RCC backup domain protection register
$56028030 constant RCC_S_RCC_HWRSR  \ offset: 0x30 : RCC reset status register for hardware
$56028034 constant RCC_S_RCC_RSR  \ offset: 0x34 : RCC reset register
$56028040 constant RCC_S_RCC_LSECFGR  \ offset: 0x40 : RCC LSE configuration register
$56028044 constant RCC_S_RCC_MSICFGR  \ offset: 0x44 : RCC MSI configuration register
$56028048 constant RCC_S_RCC_HSICFGR  \ offset: 0x48 : RCC HSI configuration register
$5602804c constant RCC_S_RCC_HSIMCR  \ offset: 0x4C : RCC HSI monitor control register
$56028050 constant RCC_S_RCC_HSIMSR  \ offset: 0x50 : RCC HSI monitor status register
$56028054 constant RCC_S_RCC_HSECFGR  \ offset: 0x54 : RCC HSE configuration register
$56028080 constant RCC_S_RCC_PLL1CFGR1  \ offset: 0x80 : RCC PLL1 configuration register 1
$56028084 constant RCC_S_RCC_PLL1CFGR2  \ offset: 0x84 : RCC PLL1 configuration register 2
$56028088 constant RCC_S_RCC_PLL1CFGR3  \ offset: 0x88 : RCC PLL1 configuration register 3
$56028090 constant RCC_S_RCC_PLL2CFGR1  \ offset: 0x90 : RCC PLL2 configuration register 1
$56028094 constant RCC_S_RCC_PLL2CFGR2  \ offset: 0x94 : RCC PLL2 configuration register 2
$56028098 constant RCC_S_RCC_PLL2CFGR3  \ offset: 0x98 : RCC PLL2 configuration register 3
$560280a0 constant RCC_S_RCC_PLL3CFGR1  \ offset: 0xA0 : RCC PLL3 configuration register 1
$560280a4 constant RCC_S_RCC_PLL3CFGR2  \ offset: 0xA4 : RCC PLL3 configuration register 2
$560280a8 constant RCC_S_RCC_PLL3CFGR3  \ offset: 0xA8 : RCC PLL3 configuration register 3
$560280b0 constant RCC_S_RCC_PLL4CFGR1  \ offset: 0xB0 : RCC PLL4 configuration register 1
$560280b4 constant RCC_S_RCC_PLL4CFGR2  \ offset: 0xB4 : RCC PLL4 configuration register 2
$560280b8 constant RCC_S_RCC_PLL4CFGR3  \ offset: 0xB8 : RCC PLL4 configuration register 3
$560280c4 constant RCC_S_RCC_IC1CFGR  \ offset: 0xC4 : RCC IC1 configuration register
$560280c8 constant RCC_S_RCC_IC2CFGR  \ offset: 0xC8 : RCC IC2 configuration register
$560280cc constant RCC_S_RCC_IC3CFGR  \ offset: 0xCC : RCC IC3 configuration register
$560280d0 constant RCC_S_RCC_IC4CFGR  \ offset: 0xD0 : RCC IC4 configuration register
$560280d4 constant RCC_S_RCC_IC5CFGR  \ offset: 0xD4 : RCC IC5 configuration register
$560280d8 constant RCC_S_RCC_IC6CFGR  \ offset: 0xD8 : RCC IC6 configuration register
$560280dc constant RCC_S_RCC_IC7CFGR  \ offset: 0xDC : RCC IC7 configuration register
$560280e0 constant RCC_S_RCC_IC8CFGR  \ offset: 0xE0 : RCC IC8 configuration register
$560280e4 constant RCC_S_RCC_IC9CFGR  \ offset: 0xE4 : RCC IC9 configuration register
$560280e8 constant RCC_S_RCC_IC10CFGR  \ offset: 0xE8 : RCC IC10 configuration register
$560280ec constant RCC_S_RCC_IC11CFGR  \ offset: 0xEC : RCC IC11 configuration register
$560280f0 constant RCC_S_RCC_IC12CFGR  \ offset: 0xF0 : RCC IC12 configuration register
$560280f4 constant RCC_S_RCC_IC13CFGR  \ offset: 0xF4 : RCC IC13 configuration register
$560280f8 constant RCC_S_RCC_IC14CFGR  \ offset: 0xF8 : RCC IC14 configuration register
$560280fc constant RCC_S_RCC_IC15CFGR  \ offset: 0xFC : RCC IC15 configuration register
$56028100 constant RCC_S_RCC_IC16CFGR  \ offset: 0x100 : RCC IC16 configuration register
$56028104 constant RCC_S_RCC_IC17CFGR  \ offset: 0x104 : RCC IC17 configuration register
$56028108 constant RCC_S_RCC_IC18CFGR  \ offset: 0x108 : RCC IC18 configuration register
$5602810c constant RCC_S_RCC_IC19CFGR  \ offset: 0x10C : RCC IC19 configuration register
$56028110 constant RCC_S_RCC_IC20CFGR  \ offset: 0x110 : RCC IC20 configuration register
$56028124 constant RCC_S_RCC_CIER  \ offset: 0x124 : RCC clock-source interrupt enable register
$56028128 constant RCC_S_RCC_CIFR  \ offset: 0x128 : RCC clock-source interrupt flag register
$5602812c constant RCC_S_RCC_CICR  \ offset: 0x12C : RCC clock-source interrupt Clear register
$56028144 constant RCC_S_RCC_CCIPR1  \ offset: 0x144 : RCC clock configuration for independent peripheral register1
$56028148 constant RCC_S_RCC_CCIPR2  \ offset: 0x148 : RCC clock configuration for independent peripheral register 2
$5602814c constant RCC_S_RCC_CCIPR3  \ offset: 0x14C : RCC clock configuration for independent peripheral register3
$56028150 constant RCC_S_RCC_CCIPR4  \ offset: 0x150 : RCC clock configuration for independent peripheral register4
$56028154 constant RCC_S_RCC_CCIPR5  \ offset: 0x154 : RCC lock configuration for independent peripheral register5
$56028158 constant RCC_S_RCC_CCIPR6  \ offset: 0x158 : RCC clock configuration for independent peripheral register6
$5602815c constant RCC_S_RCC_CCIPR7  \ offset: 0x15C : RCC clock configuration for independent peripheral register7
$56028160 constant RCC_S_RCC_CCIPR8  \ offset: 0x160 : RCC clock configuration for independent peripheral register8
$56028164 constant RCC_S_RCC_CCIPR9  \ offset: 0x164 : RCC clock configuration for independent peripheral register9
$56028170 constant RCC_S_RCC_CCIPR12  \ offset: 0x170 : RCC clock configuration for independent peripheral register12
$56028174 constant RCC_S_RCC_CCIPR13  \ offset: 0x174 : RCC clock configuration for independent peripheral register13
$56028178 constant RCC_S_RCC_CCIPR14  \ offset: 0x178 : RCC clock configuration for independent peripheral register14
$56028204 constant RCC_S_RCC_BUSRSTR  \ offset: 0x204 : RCC SoC buses reset register
$56028208 constant RCC_S_RCC_MISCRSTR  \ offset: 0x208 : RCC miscellaneous configurations reset register
$5602820c constant RCC_S_RCC_MEMRSTR  \ offset: 0x20C : RCC memories reset register
$56028210 constant RCC_S_RCC_AHB1RSTR  \ offset: 0x210 : RCC AHB1 Reset register
$56028214 constant RCC_S_RCC_AHB2RSTR  \ offset: 0x214 : RCC AHB2 reset register
$56028218 constant RCC_S_RCC_AHB3RSTR  \ offset: 0x218 : RCC AHB3 reset register
$5602821c constant RCC_S_RCC_AHB4RSTR  \ offset: 0x21C : RCC AHB4 reset register
$56028220 constant RCC_S_RCC_AHB5RSTR  \ offset: 0x220 : RCC AHB5 reset register
$56028224 constant RCC_S_RCC_APB1LRSTR  \ offset: 0x224 : RCC APB1L reset register
$56028228 constant RCC_S_RCC_APB1HRSTR  \ offset: 0x228 : RCC APB1H reset register
$5602822c constant RCC_S_RCC_APB2RSTR  \ offset: 0x22C : RCC APB2 reset register
$56028234 constant RCC_S_RCC_APB4LRSTR  \ offset: 0x234 : RCC APB4L reset register
$56028238 constant RCC_S_RCC_APB4HRSTR  \ offset: 0x238 : RCC APB4H reset register
$5602823c constant RCC_S_RCC_APB5RSTR  \ offset: 0x23C : RCC APB5 reset register
$56028240 constant RCC_S_RCC_DIVENR  \ offset: 0x240 : RCC IC dividers enable register
$56028244 constant RCC_S_RCC_BUSENR  \ offset: 0x244 : RCC SoC buses enable register
$56028248 constant RCC_S_RCC_MISCENR  \ offset: 0x248 : RCC miscellaneous configuration enable register
$5602824c constant RCC_S_RCC_MEMENR  \ offset: 0x24C : RCC memory enable register
$56028250 constant RCC_S_RCC_AHB1ENR  \ offset: 0x250 : RCC AHB1 enable register
$56028254 constant RCC_S_RCC_AHB2ENR  \ offset: 0x254 : RCC AHB2 enable register
$56028258 constant RCC_S_RCC_AHB3ENR  \ offset: 0x258 : RCC AHB3 enable register
$5602825c constant RCC_S_RCC_AHB4ENR  \ offset: 0x25C : RCC AHB4 enable register
$56028260 constant RCC_S_RCC_AHB5ENR  \ offset: 0x260 : RCC AHB5 enable register
$56028264 constant RCC_S_RCC_APB1LENR  \ offset: 0x264 : RCC APB1L enable register
$56028268 constant RCC_S_RCC_APB1HENR  \ offset: 0x268 : RCC APB1H enable register
$5602826c constant RCC_S_RCC_APB2ENR  \ offset: 0x26C : RCC APB2 enable register
$56028270 constant RCC_S_RCC_APB3ENR  \ offset: 0x270 : RCC APB3 enable register
$56028274 constant RCC_S_RCC_APB4LENR  \ offset: 0x274 : RCC APB4L enable register
$56028278 constant RCC_S_RCC_APB4HENR  \ offset: 0x278 : RCC APB4H enable register
$5602827c constant RCC_S_RCC_APB5ENR  \ offset: 0x27C : RCC APB5 enable register
$56028280 constant RCC_S_RCC_DIVLPENR  \ offset: 0x280 : RCC dividers Sleep enable register
$56028284 constant RCC_S_RCC_BUSLPENR  \ offset: 0x284 : RCC SoC buses Sleep enable register
$56028288 constant RCC_S_RCC_MISCLPENR  \ offset: 0x288 : RCC miscellaneous configurations Sleep enable register
$5602828c constant RCC_S_RCC_MEMLPENR  \ offset: 0x28C : RCC memory Sleep enable register
$56028290 constant RCC_S_RCC_AHB1LPENR  \ offset: 0x290 : RCC AHB1 Sleep enable register
$56028294 constant RCC_S_RCC_AHB2LPENR  \ offset: 0x294 : RCC AHB2 Sleep enable register
$56028298 constant RCC_S_RCC_AHB3LPENR  \ offset: 0x298 : RCC AHB3 Sleep enable register
$5602829c constant RCC_S_RCC_AHB4LPENR  \ offset: 0x29C : RCC AHB4 Sleep enable register
$560282a0 constant RCC_S_RCC_AHB5LPENR  \ offset: 0x2A0 : RCC AHB5 Sleep enable register
$560282a4 constant RCC_S_RCC_APB1LLPENR  \ offset: 0x2A4 : RCC APB1L Sleep enable register
$560282a8 constant RCC_S_RCC_APB1HLPENR  \ offset: 0x2A8 : RCC APB1H Sleep enable register
$560282ac constant RCC_S_RCC_APB2LPENR  \ offset: 0x2AC : RCC APB2 Sleep enable register
$560282b0 constant RCC_S_RCC_APB3LPENR  \ offset: 0x2B0 : RCC APB3 Sleep enable register
$560282b4 constant RCC_S_RCC_APB4LLPENR  \ offset: 0x2B4 : RCC APB4L Sleep enable register
$560282b8 constant RCC_S_RCC_APB4HLPENR  \ offset: 0x2B8 : RCC APB4H Sleep enable register
$560282bc constant RCC_S_RCC_APB5LPENR  \ offset: 0x2BC : RCC APB5 Sleep enable register
$5602844c constant RCC_S_RCC_RDCR  \ offset: 0x44C : RCC APB5 Sleep enable register
$56028780 constant RCC_S_RCC_SECCFGR0  \ offset: 0x780 : RCC oscillator secure configuration register0
$56028784 constant RCC_S_RCC_PRIVCFGR0  \ offset: 0x784 : RCC oscillator privilege configuration register0
$56028788 constant RCC_S_RCC_LOCKCFGR0  \ offset: 0x788 : RCC oscillator lock configuration register0
$5602878c constant RCC_S_RCC_PUBCFGR0  \ offset: 0x78C : RCC oscillator public configuration register0
$56028790 constant RCC_S_RCC_SECCFGR1  \ offset: 0x790 : RCC PLL secure configuration register1
$56028794 constant RCC_S_RCC_PRIVCFGR1  \ offset: 0x794 : RCC PLL privilege configuration register1
$56028798 constant RCC_S_RCC_LOCKCFGR1  \ offset: 0x798 : RCC PLL lock configuration register1
$5602879c constant RCC_S_RCC_PUBCFGR1  \ offset: 0x79C : RCC PLL public configuration register1
$560287a0 constant RCC_S_RCC_SECCFGR2  \ offset: 0x7A0 : RCC divider secure configuration register2
$560287a4 constant RCC_S_RCC_PRIVCFGR2  \ offset: 0x7A4 : RCC divider privilege configuration register2
$560287a8 constant RCC_S_RCC_LOCKCFGR2  \ offset: 0x7A8 : RCC divider lock configuration register2
$560287ac constant RCC_S_RCC_PUBCFGR2  \ offset: 0x7AC : RCC divider public configuration register2
$560287b0 constant RCC_S_RCC_SECCFGR3  \ offset: 0x7B0 : RCC system secure configuration register3
$560287b4 constant RCC_S_RCC_PRIVCFGR3  \ offset: 0x7B4 : RCC system privilege configuration register3
$560287b8 constant RCC_S_RCC_LOCKCFGR3  \ offset: 0x7B8 : RCC system lock configuration register3
$560287bc constant RCC_S_RCC_PUBCFGR3  \ offset: 0x7BC : RCC system public configuration register3
$560287c0 constant RCC_S_RCC_SECCFGR4  \ offset: 0x7C0 : RCC bus secure configuration register4
$560287c4 constant RCC_S_RCC_PRIVCFGR4  \ offset: 0x7C4 : RCC bus privilege configuration register4
$560287c8 constant RCC_S_RCC_LOCKCFGR4  \ offset: 0x7C8 : RCC bus lock configuration register4
$560287cc constant RCC_S_RCC_PUBCFGR4  \ offset: 0x7CC : RCC bus public configuration register4
$560287d0 constant RCC_S_RCC_PUBCFGR5  \ offset: 0x7D0 : RCC bus public configuration register4
$56028800 constant RCC_S_RCC_CSR  \ offset: 0x800 : RCC control set register
$56028808 constant RCC_S_RCC_STOPCSR  \ offset: 0x808 : RCC Stop configuration register
$56028a04 constant RCC_S_RCC_BUSRSTSR  \ offset: 0xA04 : RCC bus reset set register
$56028a08 constant RCC_S_RCC_MISCRSTSR  \ offset: 0xA08 : RCC miscellaneous reset register
$56028a0c constant RCC_S_RCC_MEMRSTSR  \ offset: 0xA0C : RCC memory reset register
$56028a10 constant RCC_S_RCC_AHB1RSTSR  \ offset: 0xA10 : RCC AHB1 reset register
$56028a14 constant RCC_S_RCC_AHB2RSTSR  \ offset: 0xA14 : RCC AHB2 reset register
$56028a18 constant RCC_S_RCC_AHB3RSTSR  \ offset: 0xA18 : RCC AHB3 reset register
$56028a1c constant RCC_S_RCC_AHB4RSTSR  \ offset: 0xA1C : RCC AHB4 reset register
$56028a20 constant RCC_S_RCC_AHB5RSTSR  \ offset: 0xA20 : RCC AHB5 reset register
$56028a24 constant RCC_S_RCC_APB1LRSTSR  \ offset: 0xA24 : RCC APB1L reset register
$56028a28 constant RCC_S_RCC_APB1HRSTSR  \ offset: 0xA28 : RCC APB1H reset register
$56028a2c constant RCC_S_RCC_APB2RSTSR  \ offset: 0xA2C : RCC APB2 reset register
$56028a34 constant RCC_S_RCC_APB4LRSTSR  \ offset: 0xA34 : RCC APB4L reset register
$56028a38 constant RCC_S_RCC_APB4HRSTSR  \ offset: 0xA38 : RCC APB4H reset register
$56028a3c constant RCC_S_RCC_APB5RSTSR  \ offset: 0xA3C : RCC APB5 reset register
$56028a40 constant RCC_S_RCC_DIVENSR  \ offset: 0xA40 : RCC Divider enable register
$56028a44 constant RCC_S_RCC_BUSENSR  \ offset: 0xA44 : RCC bus enable register
$56028a48 constant RCC_S_RCC_MISCENSR  \ offset: 0xA48 : RCC miscellaneous enable register
$56028a4c constant RCC_S_RCC_MEMENSR  \ offset: 0xA4C : RCC memory enable register
$56028a50 constant RCC_S_RCC_AHB1ENSR  \ offset: 0xA50 : RCC AHB1 enable register
$56028a54 constant RCC_S_RCC_AHB2ENSR  \ offset: 0xA54 : RCC AHB2 enable register
$56028a58 constant RCC_S_RCC_AHB3ENSR  \ offset: 0xA58 : RCC AHB3 enable register
$56028a5c constant RCC_S_RCC_AHB4ENSR  \ offset: 0xA5C : RCC AHB4 enable register
$56028a60 constant RCC_S_RCC_AHB5ENSR  \ offset: 0xA60 : RCC AHB5 enable register
$56028a64 constant RCC_S_RCC_APB1LENSR  \ offset: 0xA64 : RCC APB1L enable register
$56028a68 constant RCC_S_RCC_APB1HENSR  \ offset: 0xA68 : RCC APB1H enable register
$56028a6c constant RCC_S_RCC_APB2ENSR  \ offset: 0xA6C : RCC APB2 enable register
$56028a70 constant RCC_S_RCC_APB3ENSR  \ offset: 0xA70 : RCC APB3 enable register
$56028a74 constant RCC_S_RCC_APB4LENSR  \ offset: 0xA74 : RCC APB4L enable register
$56028a78 constant RCC_S_RCC_APB4HENSR  \ offset: 0xA78 : RCC APB4H enable register
$56028a7c constant RCC_S_RCC_APB5ENSR  \ offset: 0xA7C : RCC APB5 enable register
$56028a80 constant RCC_S_RCC_DIVLPENSR  \ offset: 0xA80 : RCC divider Sleep enable register
$56028a84 constant RCC_S_RCC_BUSLPENSR  \ offset: 0xA84 : RCC bus Sleep enable register
$56028a88 constant RCC_S_RCC_MISCLPENSR  \ offset: 0xA88 : RCC miscellaneous Sleep enable register
$56028a8c constant RCC_S_RCC_MEMLPENSR  \ offset: 0xA8C : RCC memory sleep enable register
$56028a90 constant RCC_S_RCC_AHB1LPENSR  \ offset: 0xA90 : RCC AHB1 Sleep enable register
$56028a94 constant RCC_S_RCC_AHB2LPENSR  \ offset: 0xA94 : RCC AHB2 Sleep enable register
$56028a98 constant RCC_S_RCC_AHB3LPENSR  \ offset: 0xA98 : RCC AHB3 Sleep enable register
$56028a9c constant RCC_S_RCC_AHB4LPENSR  \ offset: 0xA9C : RCC AHB4 Sleep enable register
$56028aa0 constant RCC_S_RCC_AHB5LPENSR  \ offset: 0xAA0 : RCC AHB5 Sleep enable register
$56028aa4 constant RCC_S_RCC_APB1LLPENSR  \ offset: 0xAA4 : RCC APB1L Sleep enable register
$56028aa8 constant RCC_S_RCC_APB1HLPENSR  \ offset: 0xAA8 : RCC APB1H Sleep enable register
$56028aac constant RCC_S_RCC_APB2LPENSR  \ offset: 0xAAC : RCC APB2 Sleep enable register
$56028ab0 constant RCC_S_RCC_APB3LPENSR  \ offset: 0xAB0 : RCC APB3 Sleep enable register
$56028ab4 constant RCC_S_RCC_APB4LLPENSR  \ offset: 0xAB4 : RCC APB4L Sleep enable register
$56028ab8 constant RCC_S_RCC_APB4HLPENSR  \ offset: 0xAB8 : RCC APB4H Sleep enable register
$56028abc constant RCC_S_RCC_APB5LPENSR  \ offset: 0xABC : RCC APB5 Sleep enable register
$56028f84 constant RCC_S_RCC_PRIVCFGSR0  \ offset: 0xF84 : RCC oscillator privilege configuration register0
$56028f8c constant RCC_S_RCC_PUBCFGSR0  \ offset: 0xF8C : RCC oscillator public configuration register0
$56028f94 constant RCC_S_RCC_PRIVCFGSR1  \ offset: 0xF94 : RCC PLL privilege configuration register1
$56028f9c constant RCC_S_RCC_PUBCFGSR1  \ offset: 0xF9C : RCC PLL public configuration register1
$56028fa4 constant RCC_S_RCC_PRIVCFGSR2  \ offset: 0xFA4 : RCC divider privilege configuration register2
$56028fac constant RCC_S_RCC_PUBCFGSR2  \ offset: 0xFAC : RCC divider public configuration register2
$56028fb0 constant RCC_S_RCC_SECCFGSR3  \ offset: 0xFB0 : RCC system secure configuration register3
$56028fb4 constant RCC_S_RCC_PRIVCFGSR3  \ offset: 0xFB4 : RCC system privilege configuration register3
$56028fb8 constant RCC_S_RCC_LOCKCFGSR3  \ offset: 0xFB8 : RCC system lock configuration register3
$56028fbc constant RCC_S_RCC_PUBCFGSR3  \ offset: 0xFBC : RCC system public configuration register3
$56028fc4 constant RCC_S_RCC_PRIVCFGSR4  \ offset: 0xFC4 : RCC privilege configuration register4
$56028fcc constant RCC_S_RCC_PUBCFGSR4  \ offset: 0xFCC : RCC public configuration register4
$56028fd0 constant RCC_S_RCC_PUBCFGSR5  \ offset: 0xFD0 : RCC public configuration register4
$56029000 constant RCC_S_RCC_CCR  \ offset: 0x1000 : RCC control Clear register
$56029008 constant RCC_S_RCC_STOPCCR  \ offset: 0x1008 : RCC StopCCR configuration register
$56029204 constant RCC_S_RCC_BUSRSTCR  \ offset: 0x1204 : RCC bus reset register
$56029208 constant RCC_S_RCC_MISCRSTCR  \ offset: 0x1208 : RCC miscellaneous reset register
$5602920c constant RCC_S_RCC_MEMRSTCR  \ offset: 0x120C : RCC memory reset register
$56029210 constant RCC_S_RCC_AHB1RSTCR  \ offset: 0x1210 : RCC AHB1 reset register
$56029214 constant RCC_S_RCC_AHB2RSTCR  \ offset: 0x1214 : RCC AHB2 Reset register
$56029218 constant RCC_S_RCC_AHB3RSTCR  \ offset: 0x1218 : RCC AHB3 reset register
$5602921c constant RCC_S_RCC_AHB4RSTCR  \ offset: 0x121C : RCC AHB4 reset register
$56029220 constant RCC_S_RCC_AHB5RSTCR  \ offset: 0x1220 : RCC AHB5 reset register
$56029224 constant RCC_S_RCC_APB1LRSTCR  \ offset: 0x1224 : RCC APB1L reset register
$56029228 constant RCC_S_RCC_APB1HRSTCR  \ offset: 0x1228 : RCC APB1H reset register
$5602922c constant RCC_S_RCC_APB2RSTCR  \ offset: 0x122C : RCC APB2 reset register
$56029234 constant RCC_S_RCC_APB4LRSTCR  \ offset: 0x1234 : RCC APB4L reset register
$56029238 constant RCC_S_RCC_APB4HRSTCR  \ offset: 0x1238 : RCC APB4H reset register
$5602923c constant RCC_S_RCC_APB5RSTCR  \ offset: 0x123C : RCC APB5 reset register
$56029240 constant RCC_S_RCC_DIVENCR  \ offset: 0x1240 : RCC divider enable register
$56029244 constant RCC_S_RCC_BUSENCR  \ offset: 0x1244 : RCC bus enable register
$56029248 constant RCC_S_RCC_MISCENCR  \ offset: 0x1248 : RCC miscellaneous enable register
$5602924c constant RCC_S_RCC_MEMENCR  \ offset: 0x124C : RCC memory enable register
$56029250 constant RCC_S_RCC_AHB1ENCR  \ offset: 0x1250 : RCC AHB1 enable register
$56029254 constant RCC_S_RCC_AHB2ENCR  \ offset: 0x1254 : RCC AHB2 enable register
$56029258 constant RCC_S_RCC_AHB3ENCR  \ offset: 0x1258 : RCC AHB3 enable register
$5602925c constant RCC_S_RCC_AHB4ENCR  \ offset: 0x125C : RCC AHB4 enable register
$56029260 constant RCC_S_RCC_AHB5ENCR  \ offset: 0x1260 : RCC AHB5 enable register
$56029264 constant RCC_S_RCC_APB1LENCR  \ offset: 0x1264 : RCC APB1L enable register
$56029268 constant RCC_S_RCC_APB1HENCR  \ offset: 0x1268 : RCC APB1H enable register
$5602926c constant RCC_S_RCC_APB2ENCR  \ offset: 0x126C : RCC APB2 enable register
$56029270 constant RCC_S_RCC_APB3ENCR  \ offset: 0x1270 : RCC APB3 enable register
$56029274 constant RCC_S_RCC_APB4LENCR  \ offset: 0x1274 : RCC APB4L enable register
$56029278 constant RCC_S_RCC_APB4HENCR  \ offset: 0x1278 : RCC APB4H enable register
$5602927c constant RCC_S_RCC_APB5ENCR  \ offset: 0x127C : RCC APB5 enable register
$56029280 constant RCC_S_RCC_DIVLPENCR  \ offset: 0x1280 : RCC divider Sleep enable register
$56029284 constant RCC_S_RCC_BUSLPENCR  \ offset: 0x1284 : RCC bus Sleep enable register
$56029288 constant RCC_S_RCC_MISCLPENCR  \ offset: 0x1288 : RCC miscellaneous Sleep enable register
$5602928c constant RCC_S_RCC_MEMLPENCR  \ offset: 0x128C : RCC memory Sleep enable register
$56029290 constant RCC_S_RCC_AHB1LPENCR  \ offset: 0x1290 : RCC AHB1 Sleep enable register
$56029294 constant RCC_S_RCC_AHB2LPENCR  \ offset: 0x1294 : RCC AHB2 Sleep enable register
$56029298 constant RCC_S_RCC_AHB3LPENCR  \ offset: 0x1298 : RCC AHB3 Sleep enable register
$5602929c constant RCC_S_RCC_AHB4LPENCR  \ offset: 0x129C : RCC AHB4 Sleep enable register
$560292a0 constant RCC_S_RCC_AHB5LPENCR  \ offset: 0x12A0 : RCC AHB5 Sleep enable register
$560292a4 constant RCC_S_RCC_APB1LLPENCR  \ offset: 0x12A4 : RCC APB1L Sleep enable register
$560292a8 constant RCC_S_RCC_APB1HLPENCR  \ offset: 0x12A8 : RCC APB1H Sleep enable register
$560292ac constant RCC_S_RCC_APB2LPENCR  \ offset: 0x12AC : RCC APB2 Sleep enable register
$560292b0 constant RCC_S_RCC_APB3LPENCR  \ offset: 0x12B0 : RCC APB3 Sleep enable register
$560292b4 constant RCC_S_RCC_APB4LLPENCR  \ offset: 0x12B4 : RCC APB4L Sleep enable register
$560292b8 constant RCC_S_RCC_APB4HLPENCR  \ offset: 0x12B8 : RCC APB4H Sleep enable register
$560292bc constant RCC_S_RCC_APB5LPENCR  \ offset: 0x12BC : RCC APB5 Sleep enable register
$56029784 constant RCC_S_RCC_PRIVCFGCR0  \ offset: 0x1784 : RCC oscillator privilege configuration register0
$5602978c constant RCC_S_RCC_PUBCFGCR0  \ offset: 0x178C : RCC oscillator public configuration register0
$56029794 constant RCC_S_RCC_PRIVCFGCR1  \ offset: 0x1794 : RCC PLL privilege configuration register1
$5602979c constant RCC_S_RCC_PUBCFGCR1  \ offset: 0x179C : RCC PLL public configuration register1
$560297a4 constant RCC_S_RCC_PRIVCFGCR2  \ offset: 0x17A4 : RCC divider privilege configuration register2
$560297ac constant RCC_S_RCC_PUBCFGCR2  \ offset: 0x17AC : RCC divider public configuration register2
$560297b4 constant RCC_S_RCC_PRIVCFGCR3  \ offset: 0x17B4 : RCC system privilege configuration register3
$560297bc constant RCC_S_RCC_PUBCFGCR3  \ offset: 0x17BC : RCC system public configuration register3
$560297c4 constant RCC_S_RCC_PRIVCFGCR4  \ offset: 0x17C4 : RCC privilege configuration register4
$560297cc constant RCC_S_RCC_PUBCFGCR4  \ offset: 0x17CC : RCC public configuration register4
$560297d0 constant RCC_S_RCC_PUBCFGCR5  \ offset: 0x17D0 : RCC public configuration register4

