\
\ @file rcc.fs
\ @brief RCC
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] RCC_DEF

  [ifdef] RCC_RCC_TZCR_DEF
    \
    \ @brief This register is used to switch the RCC into secure mode. This register can only be accessed in secure mode.
    \ Address offset: 0x00
    \ Reset value: 0x00000003
    \
    $00 constant RCC_TZEN                       \ [0x00] TZEN
    $01 constant RCC_MCKPROT                    \ [0x01] MCKPROT
  [then]


  [ifdef] RCC_RCC_OCENSETR_DEF
    \
    \ @brief This register is used to control the oscillators.Writing to this register has no effect, writing will set the corresponding bits. Reading will give the effective values of each bit.If TZEN = MCKPROT = , this register can only be modified in secure mode. Write access to this register is not allowed during the clock restore sequence. See Section: The clock restore sequence description for details.
    \ Address offset: 0x0C
    \ Reset value: 0x00000001
    \
    $00 constant RCC_HSION                      \ [0x00] HSION
    $01 constant RCC_HSIKERON                   \ [0x01] HSIKERON
    $04 constant RCC_CSION                      \ [0x04] CSION
    $05 constant RCC_CSIKERON                   \ [0x05] CSIKERON
    $07 constant RCC_DIGBYP                     \ [0x07] DIGBYP
    $08 constant RCC_HSEON                      \ [0x08] HSEON
    $09 constant RCC_HSEKERON                   \ [0x09] HSEKERON
    $0a constant RCC_HSEBYP                     \ [0x0a] HSEBYP
    $0b constant RCC_HSECSSON                   \ [0x0b] HSECSSON
  [then]


  [ifdef] RCC_RCC_OCENCLRR_DEF
    \
    \ @brief This register is used to control the oscillators.Writing to this register has no effect, writing will clear the corresponding bits. Reading will give the effective values of the enable bits.If TZEN = , this register can only be modified in secure mode. Write access to this register is not allowed during the clock restore sequence. See Section: The clock restore sequence description for details.
    \ Address offset: 0x10
    \ Reset value: 0x00000001
    \
    $00 constant RCC_HSION                      \ [0x00] HSION
    $01 constant RCC_HSIKERON                   \ [0x01] HSIKERON
    $04 constant RCC_CSION                      \ [0x04] CSION
    $05 constant RCC_CSIKERON                   \ [0x05] CSIKERON
    $07 constant RCC_DIGBYP                     \ [0x07] DIGBYP
    $08 constant RCC_HSEON                      \ [0x08] HSEON
    $09 constant RCC_HSEKERON                   \ [0x09] HSEKERON
    $0a constant RCC_HSEBYP                     \ [0x0a] HSEBYP
  [then]


  [ifdef] RCC_RCC_HSICFGR_DEF
    \
    \ @brief This register is used to configure the HSI. If TZEN = , this register can only be modified in secure mode. Write access to this register is not allowed during the clock restore sequence. See Section: The clock restore sequence description for details.
    \ Address offset: 0x18
    \ Reset value: 0x00000000
    \
    $00 constant RCC_HSIDIV                     \ [0x00 : 2] HSIDIV
    $08 constant RCC_HSITRIM                    \ [0x08 : 7] HSITRIM
    $10 constant RCC_HSICAL                     \ [0x10 : 12] HSICAL
  [then]


  [ifdef] RCC_RCC_CSICFGR_DEF
    \
    \ @brief This register is used to fine-tune the CSI frequency. If TZEN = MCKPROT = , this register can only be modified in secure mode. Write access to this register is not allowed during the clock restore sequence. See The clock restore sequence description for details.
    \ Address offset: 0x1C
    \ Reset value: 0x00001000
    \
    $08 constant RCC_CSITRIM                    \ [0x08 : 5] CSITRIM
    $10 constant RCC_CSICAL                     \ [0x10 : 8] CSICAL
  [then]


  [ifdef] RCC_RCC_MPCKSELR_DEF
    \
    \ @brief This register is used to select the clock source for the MPU. If TZEN = , this register can only be modified in secure mode. Write access to this register is not allowed during the clock restore sequence. See Section: The clock restore sequence description for details.
    \ Address offset: 0x20
    \ Reset value: 0x80000000
    \
    $00 constant RCC_MPUSRC                     \ [0x00 : 2] MPUSRC
    $1f constant RCC_MPUSRCRDY                  \ [0x1f] MPUSRCRDY
  [then]


  [ifdef] RCC_RCC_ASSCKSELR_DEF
    \
    \ @brief This register is used to select the clock source for the AXI sub-system. If TZEN = , this register can only be modified in secure mode. Write access to this register is not allowed during the clock restore sequence. See Section: The clock restore sequence description for details.
    \ Address offset: 0x24
    \ Reset value: 0x80000000
    \
    $00 constant RCC_AXISSRC                    \ [0x00 : 3] AXISSRC
    $1f constant RCC_AXISSRCRDY                 \ [0x1f] AXISSRCRDY
  [then]


  [ifdef] RCC_RCC_RCK12SELR_DEF
    \
    \ @brief This register is used to select the reference clock for PLL1 and PLL2. If TZEN = , this register can only be modified in secure mode. Write access to this register is not allowed during the clock restore sequence. See Section: The clock restore sequence description for details.
    \ Address offset: 0x28
    \ Reset value: 0x80000000
    \
    $00 constant RCC_PLL12SRC                   \ [0x00 : 2] PLL12SRC
    $1f constant RCC_PLL12SRCRDY                \ [0x1f] PLL12SRCRDY
  [then]


  [ifdef] RCC_RCC_MPCKDIVR_DEF
    \
    \ @brief This register is used to control the MPU clock prescaler. Refer to Section: Sub-system clock generation for additional information. If TZEN = , this register can only be modified in secure mode.
    \ Address offset: 0x2C
    \ Reset value: 0x80000001
    \
    $00 constant RCC_MPUDIV                     \ [0x00 : 3] MPUDIV
    $1f constant RCC_MPUDIVRDY                  \ [0x1f] MPUDIVRDY
  [then]


  [ifdef] RCC_RCC_AXIDIVR_DEF
    \
    \ @brief This register is used to control the AXI Matrix clock prescaler. Refer to Section: Sub-system clock generation for additional information. If TZEN = , this register can only be modified in secure mode.
    \ Address offset: 0x30
    \ Reset value: 0x80000000
    \
    $00 constant RCC_AXIDIV                     \ [0x00 : 3] AXIDIV
    $1f constant RCC_AXIDIVRDY                  \ [0x1f] AXIDIVRDY
  [then]


  [ifdef] RCC_RCC_APB4DIVR_DEF
    \
    \ @brief This register is used to control the APB4 clock divider. Refer to Section: Sub-system clock generation for additional information. If TZEN = , this register can only be modified in secure mode.
    \ Address offset: 0x3C
    \ Reset value: 0x80000000
    \
    $00 constant RCC_APB4DIV                    \ [0x00 : 3] APB4DIV
    $1f constant RCC_APB4DIVRDY                 \ [0x1f] APB4DIVRDY
  [then]


  [ifdef] RCC_RCC_APB5DIVR_DEF
    \
    \ @brief This register is used to control the APB5 clock divider. Refer to Section: Sub-system clock generation for additional information. If TZEN = , this register can only be modified in secure mode.
    \ Address offset: 0x40
    \ Reset value: 0x80000000
    \
    $00 constant RCC_APB5DIV                    \ [0x00 : 3] APB5DIV
    $1f constant RCC_APB5DIVRDY                 \ [0x1f] APB5DIVRDY
  [then]


  [ifdef] RCC_RCC_RTCDIVR_DEF
    \
    \ @brief This register is used to divide the HSE clock for RTC. If TZEN = , this register can only be modified in secure mode.
    \ Address offset: 0x44
    \ Reset value: 0x00000000
    \
    $00 constant RCC_RTCDIV                     \ [0x00 : 6] RTCDIV
  [then]


  [ifdef] RCC_RCC_MSSCKSELR_DEF
    \
    \ @brief This register is used to select the clock source for the MCU sub-system, including the MCU itself. If TZEN = MCKPROT = , this register can only be modified in secure mode. Write access to this register is not allowed during the clock restore sequence. See Section: The clock restore sequence description for details.
    \ Address offset: 0x48
    \ Reset value: 0x80000000
    \
    $00 constant RCC_MCUSSRC                    \ [0x00 : 2] MCUSSRC
    $1f constant RCC_MCUSSRCRDY                 \ [0x1f] MCUSSRCRDY
  [then]


  [ifdef] RCC_RCC_PLL1CR_DEF
    \
    \ @brief This register is used to control the PLL1. If TZEN = , this register can only be modified in secure mode. Write access to this register is not allowed during the clock restore sequence. See Section: The clock restore sequence description for details.
    \ Address offset: 0x80
    \ Reset value: 0x00000000
    \
    $00 constant RCC_PLLON                      \ [0x00] PLLON
    $01 constant RCC_PLL1RDY                    \ [0x01] PLL1RDY
    $02 constant RCC_SSCG_CTRL                  \ [0x02] SSCG_CTRL
    $04 constant RCC_DIVPEN                     \ [0x04] DIVPEN
    $05 constant RCC_DIVQEN                     \ [0x05] DIVQEN
    $06 constant RCC_DIVREN                     \ [0x06] DIVREN
  [then]


  [ifdef] RCC_RCC_PLL1CFGR1_DEF
    \
    \ @brief This register is used to configure the PLL1. If TZEN = , this register can only be modified in secure mode. Write access to this register is not allowed during the clock restore sequence. See Section: The clock restore sequence description for details.
    \ Address offset: 0x84
    \ Reset value: 0x00010031
    \
    $00 constant RCC_DIVN                       \ [0x00 : 9] DIVN
    $10 constant RCC_DIVM1                      \ [0x10 : 6] DIVM1
  [then]


  [ifdef] RCC_RCC_PLL1CFGR2_DEF
    \
    \ @brief This register is used to configure the PLL1. If TZEN = , this register can only be modified in secure mode. Write access to this register is not allowed during the clock restore sequence. See Section: The clock restore sequence description for details.
    \ Address offset: 0x88
    \ Reset value: 0x00010100
    \
    $00 constant RCC_DIVP                       \ [0x00 : 7] DIVP
    $08 constant RCC_DIVQ                       \ [0x08 : 7] DIVQ
    $10 constant RCC_DIVR                       \ [0x10 : 7] DIVR
  [then]


  [ifdef] RCC_RCC_PLL1FRACR_DEF
    \
    \ @brief This register is used to fine-tune the frequency of the PLL1 VCO. If TZEN = , this register can only be modified in secure mode. Write access to this register is not allowed during the clock restore sequence. See Section: The clock restore sequence description for details.
    \ Address offset: 0x8C
    \ Reset value: 0x00000000
    \
    $03 constant RCC_FRACV                      \ [0x03 : 13] FRACV
    $10 constant RCC_FRACLE                     \ [0x10] FRACLE
  [then]


  [ifdef] RCC_RCC_PLL1CSGR_DEF
    \
    \ @brief This register is used to configure the PLL1.It is not recommended to change the content of this register when the PLL1 is enabled (PLLON = ). Refer to Section: Using the PLLs in spread spectrum mode for details. If TZEN = , this register can only be modified in secure mode. Write access to this register is not allowed during the clock restore sequence. See Section: The clock restore sequence description for details.
    \ Address offset: 0x90
    \ Reset value: 0x00000000
    \
    $00 constant RCC_MOD_PER                    \ [0x00 : 13] MOD_PER
    $0d constant RCC_TPDFN_DIS                  \ [0x0d] TPDFN_DIS
    $0e constant RCC_RPDFN_DIS                  \ [0x0e] RPDFN_DIS
    $0f constant RCC_SSCG_MODE                  \ [0x0f] SSCG_MODE
    $10 constant RCC_INC_STEP                   \ [0x10 : 15] INC_STEP
  [then]


  [ifdef] RCC_RCC_PLL2CR_DEF
    \
    \ @brief This register is used to control the PLL2. If TZEN = , this register can only be modified in secure mode. Write access to this register is not allowed during the clock restore sequence. See Section: The clock restore sequence description for details.
    \ Address offset: 0x94
    \ Reset value: 0x00000000
    \
    $00 constant RCC_PLLON                      \ [0x00] PLLON
    $01 constant RCC_PLL2RDY                    \ [0x01] PLL2RDY
    $02 constant RCC_SSCG_CTRL                  \ [0x02] SSCG_CTRL
    $04 constant RCC_DIVPEN                     \ [0x04] DIVPEN
    $05 constant RCC_DIVQEN                     \ [0x05] DIVQEN
    $06 constant RCC_DIVREN                     \ [0x06] DIVREN
  [then]


  [ifdef] RCC_RCC_PLL2CFGR1_DEF
    \
    \ @brief This register is used to configure the PLL2. If TZEN = , this register can only be modified in secure mode. Write access to this register is not allowed during the clock restore sequence. See Section: The clock restore sequence description for details.
    \ Address offset: 0x98
    \ Reset value: 0x00010063
    \
    $00 constant RCC_DIVN                       \ [0x00 : 9] DIVN
    $10 constant RCC_DIVM2                      \ [0x10 : 6] DIVM2
  [then]


  [ifdef] RCC_RCC_PLL2CFGR2_DEF
    \
    \ @brief This register is used to configure the PLL2. If TZEN = , this register can only be modified in secure mode. Write access to this register is not allowed during the clock restore sequence. See Section: The clock restore sequence description for details.
    \ Address offset: 0x9C
    \ Reset value: 0x00010101
    \
    $00 constant RCC_DIVP                       \ [0x00 : 7] DIVP
    $08 constant RCC_DIVQ                       \ [0x08 : 7] DIVQ
    $10 constant RCC_DIVR                       \ [0x10 : 7] DIVR
  [then]


  [ifdef] RCC_RCC_PLL2FRACR_DEF
    \
    \ @brief This register is used to fine-tune the frequency of the PLL2 VCO. If TZEN = , this register can only be modified in secure mode. Write access to this register is not allowed during the clock restore sequence. See Section: The clock restore sequence description for details.
    \ Address offset: 0xA0
    \ Reset value: 0x00000000
    \
    $03 constant RCC_FRACV                      \ [0x03 : 13] FRACV
    $10 constant RCC_FRACLE                     \ [0x10] FRACLE
  [then]


  [ifdef] RCC_RCC_PLL2CSGR_DEF
    \
    \ @brief This register is used to configure the PLL2. It is not recommended to change the content of this register when the PLL2 is enabled (PLLON = ). Refer to Section: Using the PLLs in spread spectrum mode for details. If TZEN = , this register can only be modified in secure mode. Write access to this register is not allowed during the clock restore sequence. See Section: The clock restore sequence description for details.
    \ Address offset: 0xA4
    \ Reset value: 0x00000000
    \
    $00 constant RCC_MOD_PER                    \ [0x00 : 13] MOD_PER
    $0d constant RCC_TPDFN_DIS                  \ [0x0d] TPDFN_DIS
    $0e constant RCC_RPDFN_DIS                  \ [0x0e] RPDFN_DIS
    $0f constant RCC_SSCG_MODE                  \ [0x0f] SSCG_MODE
    $10 constant RCC_INC_STEP                   \ [0x10 : 15] INC_STEP
  [then]


  [ifdef] RCC_RCC_I2C46CKSELR_DEF
    \
    \ @brief This register is used to control the selection of the kernel clock for the I2C4 and I2C6. Note that changing the clock source on-the-fly is allowed, and will not generate any timing violation, however the user has to ensure that both the previous and the new clock sources are present during the switching, and for the whole transition time. Refer to Section: Clock enabling delays. If TZEN = , this register can only be modified in secure mode.
    \ Address offset: 0xC0
    \ Reset value: 0x00000000
    \
    $00 constant RCC_I2C46SRC                   \ [0x00 : 3] I2C46SRC
  [then]


  [ifdef] RCC_RCC_SPI6CKSELR_DEF
    \
    \ @brief This register is used to control the selection of the kernel clock for the SPI6. Note that changing the clock source on-the-fly is allowed, and will not generate any timing violation, however the user has to ensure that both the previous and the new clock sources are present during the switching, and for the whole transition time. Refer to Section: Clock enabling delays. If TZEN = , this register can only be modified in secure mode.
    \ Address offset: 0xC4
    \ Reset value: 0x00000000
    \
    $00 constant RCC_SPI6SRC                    \ [0x00 : 3] SPI6SRC
  [then]


  [ifdef] RCC_RCC_UART1CKSELR_DEF
    \
    \ @brief This register is used to control the selection of the kernel clock for the USART1. Note that changing the clock source on-the-fly is allowed, and will not generate any timing violation, however the user has to ensure that both the previous and the new clock sources are present during the switching, and for the whole transition time. Refer to Section: Clock enabling delays. If TZEN = , this register can only be modified in secure mode.
    \ Address offset: 0xC8
    \ Reset value: 0x00000000
    \
    $00 constant RCC_UART1SRC                   \ [0x00 : 3] UART1SRC
  [then]


  [ifdef] RCC_RCC_RNG1CKSELR_DEF
    \
    \ @brief This register is used to control the selection of the kernel clock for the RNG1. Note that changing the clock source on-the-fly is allowed, and will not generate any timing violation, however the user has to ensure that both the previous and the new clock sources are present during the switching, and for the whole transition time. Refer to Section: Clock enabling delays. If TZEN = , this register can only be modified in secure mode.
    \ Address offset: 0xCC
    \ Reset value: 0x00000000
    \
    $00 constant RCC_RNG1SRC                    \ [0x00 : 2] RNG1SRC
  [then]


  [ifdef] RCC_RCC_CPERCKSELR_DEF
    \
    \ @brief This register is used to select an oscillator source as kernel clock for the per_ck clock. The per_ck clock is distributed to several peripherals. Refer to Section: Clock enabling delays.
    \ Address offset: 0xD0
    \ Reset value: 0x00000000
    \
    $00 constant RCC_CKPERSRC                   \ [0x00 : 2] CKPERSRC
  [then]


  [ifdef] RCC_RCC_STGENCKSELR_DEF
    \
    \ @brief This register is used to select the peripheral clock for the STGEN block. Note that this clock is used to provide a time reference for the application. Refer to Section: Clock enabling delays. If TZEN = , this register can only be modified in secure mode.
    \ Address offset: 0xD4
    \ Reset value: 0x00000000
    \
    $00 constant RCC_STGENSRC                   \ [0x00 : 2] STGENSRC
  [then]


  [ifdef] RCC_RCC_DDRITFCR_DEF
    \
    \ @brief This register is used to control the DDR interface, including the DDRC and DDRPHYC. If TZEN = , this register can only be modified in secure mode.
    \ Address offset: 0xD8
    \ Reset value: 0x000FD02A
    \
    $00 constant RCC_DDRC1EN                    \ [0x00] DDRC1EN
    $01 constant RCC_DDRC1LPEN                  \ [0x01] DDRC1LPEN
    $02 constant RCC_DDRC2EN                    \ [0x02] DDRC2EN
    $03 constant RCC_DDRC2LPEN                  \ [0x03] DDRC2LPEN
    $04 constant RCC_DDRPHYCEN                  \ [0x04] DDRPHYCEN
    $05 constant RCC_DDRPHYCLPEN                \ [0x05] DDRPHYCLPEN
    $06 constant RCC_DDRCAPBEN                  \ [0x06] DDRCAPBEN
    $07 constant RCC_DDRCAPBLPEN                \ [0x07] DDRCAPBLPEN
    $08 constant RCC_AXIDCGEN                   \ [0x08] AXIDCGEN
    $09 constant RCC_DDRPHYCAPBEN               \ [0x09] DDRPHYCAPBEN
    $0a constant RCC_DDRPHYCAPBLPEN             \ [0x0a] DDRPHYCAPBLPEN
    $0b constant RCC_KERDCG_DLY                 \ [0x0b : 3] KERDCG_DLY
    $0e constant RCC_DDRCAPBRST                 \ [0x0e] DDRCAPBRST
    $0f constant RCC_DDRCAXIRST                 \ [0x0f] DDRCAXIRST
    $10 constant RCC_DDRCORERST                 \ [0x10] DDRCORERST
    $11 constant RCC_DPHYAPBRST                 \ [0x11] DPHYAPBRST
    $12 constant RCC_DPHYRST                    \ [0x12] DPHYRST
    $13 constant RCC_DPHYCTLRST                 \ [0x13] DPHYCTLRST
    $14 constant RCC_DDRCKMOD                   \ [0x14 : 3] DDRCKMOD
    $17 constant RCC_GSKPMOD                    \ [0x17] GSKPMOD
    $18 constant RCC_GSKPCTRL                   \ [0x18] GSKPCTRL
    $19 constant RCC_DFILP_WIDTH                \ [0x19 : 3] DFILP_WIDTH
    $1c constant RCC_GSKP_DUR                   \ [0x1c : 4] GSKP_DUR
  [then]


  [ifdef] RCC_RCC_MP_BOOTCR_DEF
    \
    \ @brief This register is used to control the HOLD boot function when the system exits from Standby. Refer to Section: MCU HOLD_BOOT after processor reset. This register is reset when a system reset occurs, but not when the circuit exits from Standby (app_rst reset).If TZEN = , this register can only be modified in secure mode. This register can only be accessed by the MPU.
    \ Address offset: 0x100
    \ Reset value: 0x00000000
    \
    $00 constant RCC_MCU_BEN                    \ [0x00] MCU_BEN
    $01 constant RCC_MPU_BEN                    \ [0x01] MPU_BEN
  [then]


  [ifdef] RCC_RCC_MP_SREQSETR_DEF
    \
    \ @brief Writing has no effect, reading will return the values of the bits. Writing a sets the corresponding bit to . The MCU cannot access to this register. If TZEN = , this register can only be modified in secure mode.
    \ Address offset: 0x104
    \ Reset value: 0x00000000
    \
    $00 constant RCC_STPREQ_P0                  \ [0x00] STPREQ_P0
    $01 constant RCC_STPREQ_P1                  \ [0x01] STPREQ_P1
  [then]


  [ifdef] RCC_RCC_MP_SREQCLRR_DEF
    \
    \ @brief Writing has no effect, reading will return the effective values of the bits. Writing a sets the corresponding bit to . The MCU cannot access to this register. If TZEN = , this register can only be modified in secure mode.
    \ Address offset: 0x108
    \ Reset value: 0x00000000
    \
    $00 constant RCC_STPREQ_P0                  \ [0x00] STPREQ_P0
    $01 constant RCC_STPREQ_P1                  \ [0x01] STPREQ_P1
  [then]


  [ifdef] RCC_RCC_MP_GCR_DEF
    \
    \ @brief The register contains global control bits. If TZEN = , this register can only be modified in secure mode.
    \ Address offset: 0x10C
    \ Reset value: 0x00000000
    \
    $00 constant RCC_BOOT_MCU                   \ [0x00] BOOT_MCU
  [then]


  [ifdef] RCC_RCC_MP_APRSTCR_DEF
    \
    \ @brief This register is used to control the behavior of the warm reset. If TZEN = , this register can only be modified in secure mode.
    \ Address offset: 0x110
    \ Reset value: 0x00007F00
    \
    $00 constant RCC_RDCTLEN                    \ [0x00] RDCTLEN
    $08 constant RCC_RSTTO                      \ [0x08 : 7] RSTTO
  [then]


  [ifdef] RCC_RCC_MP_APRSTSR_DEF
    \
    \ @brief This register provides a status of the RDCTL. If TZEN = , this register can only be modified in secure mode.
    \ Address offset: 0x114
    \ Reset value: 0x00000000
    \
    $08 constant RCC_RSTTOV                     \ [0x08 : 7] RSTTOV
  [then]


  [ifdef] RCC_RCC_BDCR_DEF
    \
    \ @brief This register is used to control the LSE function. Wait states are inserted in case of successive write accesses to this register. The number of wait states may be up to 7 cycles of AHB4 clock.After a system reset, the register RCC_BDCR is write-protected. In order to modify this register, the DBP bit in the PWR control register 1 (PWR_CR1) has to be set to . Bits of RCC_BDCR register are only reset after a backup domain reset: nreset_vsw (see Section10.3.6: Backup domain reset). Any other internal or external reset will not have any effect on these bits.This register is located into the VSW domain. If TZEN = , this register can only be modified in secure mode.
    \ Address offset: 0x140
    \ Reset value: 0x00000020
    \
    $00 constant RCC_LSEON                      \ [0x00] LSEON
    $01 constant RCC_LSEBYP                     \ [0x01] LSEBYP
    $02 constant RCC_LSERDY                     \ [0x02] LSERDY
    $03 constant RCC_DIGBYP                     \ [0x03] DIGBYP
    $04 constant RCC_LSEDRV                     \ [0x04 : 2] LSEDRV
    $08 constant RCC_LSECSSON                   \ [0x08] LSECSSON
    $09 constant RCC_LSECSSD                    \ [0x09] LSECSSD
    $10 constant RCC_RTCSRC                     \ [0x10 : 2] RTCSRC
    $14 constant RCC_RTCCKEN                    \ [0x14] RTCCKEN
    $1f constant RCC_VSWRST                     \ [0x1f] VSWRST
  [then]


  [ifdef] RCC_RCC_RDLSICR_DEF
    \
    \ @brief This register is used to control the minimum NRST active duration and LSI function.0 to 7 wait states are inserted for word, half-word and byte accesses. Wait states are inserted in case of successive accesses to this register.This register is reset by the por_rst reset, and it is located into the VDD domain. If TZEN = , this register can only be modified in secure mode.
    \ Address offset: 0x144
    \ Reset value: 0x00000000
    \
    $00 constant RCC_LSION                      \ [0x00] LSION
    $01 constant RCC_LSIRDY                     \ [0x01] LSIRDY
    $10 constant RCC_MRD                        \ [0x10 : 5] MRD
    $18 constant RCC_EADLY                      \ [0x18 : 3] EADLY
    $1b constant RCC_SPARE                      \ [0x1b : 5] SPARE
  [then]


  [ifdef] RCC_RCC_APB4RSTSETR_DEF
    \
    \ @brief This register is used to activate the reset of the corresponding peripheral. Writing has no effect, reading will return the effective values of the corresponding bits. Writing a activates the reset of the corresponding peripheral.
    \ Address offset: 0x180
    \ Reset value: 0x00000000
    \
    $00 constant RCC_LTDCRST                    \ [0x00] LTDCRST
    $04 constant RCC_DSIRST                     \ [0x04] DSIRST
    $08 constant RCC_DDRPERFMRST                \ [0x08] DDRPERFMRST
    $10 constant RCC_USBPHYRST                  \ [0x10] USBPHYRST
  [then]


  [ifdef] RCC_RCC_APB4RSTCLRR_DEF
    \
    \ @brief This register is used to release the reset of the corresponding peripheral. Writing has no effect, reading will return the effective values of the corresponding bits. Writing a releases the reset of the corresponding peripheral.
    \ Address offset: 0x184
    \ Reset value: 0x00000000
    \
    $00 constant RCC_LTDCRST                    \ [0x00] LTDCRST
    $04 constant RCC_DSIRST                     \ [0x04] DSIRST
    $08 constant RCC_DDRPERFMRST                \ [0x08] DDRPERFMRST
    $10 constant RCC_USBPHYRST                  \ [0x10] USBPHYRST
  [then]


  [ifdef] RCC_RCC_APB5RSTSETR_DEF
    \
    \ @brief This register is used to activate the reset of the corresponding peripheral. Writing has no effect, reading will return the effective values of the corresponding bits. Writing a activates the reset of the corresponding peripheral. If TZEN = , this register can only be modified in secure mode.
    \ Address offset: 0x188
    \ Reset value: 0x00000000
    \
    $00 constant RCC_SPI6RST                    \ [0x00] SPI6RST
    $02 constant RCC_I2C4RST                    \ [0x02] I2C4RST
    $03 constant RCC_I2C6RST                    \ [0x03] I2C6RST
    $04 constant RCC_USART1RST                  \ [0x04] USART1RST
    $14 constant RCC_STGENRST                   \ [0x14] STGENRST
  [then]


  [ifdef] RCC_RCC_APB5RSTCLRR_DEF
    \
    \ @brief This register is used to release the reset of the corresponding peripheral. Writing has no effect, reading will return the effective values of the corresponding bits. Writing a releases the reset of the corresponding peripheral. If TZEN = , this register can only be modified in secure mode.
    \ Address offset: 0x18C
    \ Reset value: 0x00000000
    \
    $00 constant RCC_SPI6RST                    \ [0x00] SPI6RST
    $02 constant RCC_I2C4RST                    \ [0x02] I2C4RST
    $03 constant RCC_I2C6RST                    \ [0x03] I2C6RST
    $04 constant RCC_USART1RST                  \ [0x04] USART1RST
    $14 constant RCC_STGENRST                   \ [0x14] STGENRST
  [then]


  [ifdef] RCC_RCC_AHB5RSTSETR_DEF
    \
    \ @brief This register is used to activate the reset of the corresponding peripheral. Writing has no effect, reading will return the effective values of the corresponding bits. Writing a activates the reset of the corresponding peripheral. If TZEN = , this register can only be modified in secure mode.
    \ Address offset: 0x190
    \ Reset value: 0x00000000
    \
    $00 constant RCC_GPIOZRST                   \ [0x00] GPIOZRST
    $04 constant RCC_CRYP1RST                   \ [0x04] CRYP1RST
    $05 constant RCC_HASH1RST                   \ [0x05] HASH1RST
    $06 constant RCC_RNG1RST                    \ [0x06] RNG1RST
    $10 constant RCC_AXIMCRST                   \ [0x10] AXIMCRST
  [then]


  [ifdef] RCC_RCC_AHB5RSTCLRR_DEF
    \
    \ @brief This register is used to release the reset of the corresponding peripheral. Writing has no effect, reading will return the effective values of the corresponding bits. Writing a releases the reset of the corresponding peripheral. If TZEN = , this register can only be modified in secure mode.
    \ Address offset: 0x194
    \ Reset value: 0x00000000
    \
    $00 constant RCC_GPIOZRST                   \ [0x00] GPIOZRST
    $04 constant RCC_CRYP1RST                   \ [0x04] CRYP1RST
    $05 constant RCC_HASH1RST                   \ [0x05] HASH1RST
    $06 constant RCC_RNG1RST                    \ [0x06] RNG1RST
    $10 constant RCC_AXIMCRST                   \ [0x10] AXIMCRST
  [then]


  [ifdef] RCC_RCC_AHB6RSTSETR_DEF
    \
    \ @brief This register is used to activate the reset of the corresponding peripheral. Writing has no effect, reading will return the effective values of the corresponding bits. Writing a activates the reset of the corresponding peripheral.
    \ Address offset: 0x198
    \ Reset value: 0x00000000
    \
    $05 constant RCC_GPURST                     \ [0x05] GPURST
    $0a constant RCC_ETHMACRST                  \ [0x0a] ETHMACRST
    $0c constant RCC_FMCRST                     \ [0x0c] FMCRST
    $0e constant RCC_QSPIRST                    \ [0x0e] QSPIRST
    $10 constant RCC_SDMMC1RST                  \ [0x10] SDMMC1RST
    $11 constant RCC_SDMMC2RST                  \ [0x11] SDMMC2RST
    $14 constant RCC_CRC1RST                    \ [0x14] CRC1RST
    $18 constant RCC_USBHRST                    \ [0x18] USBHRST
  [then]


  [ifdef] RCC_RCC_AHB6RSTCLRR_DEF
    \
    \ @brief This register is used to release the reset of the corresponding peripheral. Writing has no effect, reading will return the effective values of the corresponding bits. Writing a releases the reset of the corresponding peripheral.
    \ Address offset: 0x19C
    \ Reset value: 0x00000000
    \
    $0a constant RCC_ETHMACRST                  \ [0x0a] ETHMACRST
    $0c constant RCC_FMCRST                     \ [0x0c] FMCRST
    $0e constant RCC_QSPIRST                    \ [0x0e] QSPIRST
    $10 constant RCC_SDMMC1RST                  \ [0x10] SDMMC1RST
    $11 constant RCC_SDMMC2RST                  \ [0x11] SDMMC2RST
    $14 constant RCC_CRC1RST                    \ [0x14] CRC1RST
    $18 constant RCC_USBHRST                    \ [0x18] USBHRST
  [then]


  [ifdef] RCC_RCC_TZAHB6RSTSETR_DEF
    \
    \ @brief This register is used to activate the reset of the corresponding peripheral. Writing has no effect, reading will return the effective values of the corresponding bits. Writing a activates the reset of the corresponding peripheral. If TZEN = , this register can only be modified in secure mode.
    \ Address offset: 0x1A0
    \ Reset value: 0x00000000
    \
    $00 constant RCC_MDMARST                    \ [0x00] MDMARST
  [then]


  [ifdef] RCC_RCC_TZAHB6RSTCLRR_DEF
    \
    \ @brief This register is used to release the reset of the corresponding peripheral. Writing has no effect, reading will return the effective values of the corresponding bits. Writing a releases the reset of the corresponding peripheral. If TZEN = , this register can only be modified in secure mode.
    \ Address offset: 0x1A4
    \ Reset value: 0x00000000
    \
    $00 constant RCC_MDMARST                    \ [0x00] MDMARST
  [then]


  [ifdef] RCC_RCC_MP_APB4ENSETR_DEF
    \
    \ @brief This register is used to set the peripheral clock enable bit of the corresponding peripheral to . It shall be used to allocate a peripheral to the MPU. Writing has no effect, reading will return the effective values of the corresponding bits. Writing a sets the corresponding bit to .
    \ Address offset: 0x200
    \ Reset value: 0x00000000
    \
    $00 constant RCC_LTDCEN                     \ [0x00] LTDCEN
    $04 constant RCC_DSIEN                      \ [0x04] DSIEN
    $08 constant RCC_DDRPERFMEN                 \ [0x08] DDRPERFMEN
    $0f constant RCC_IWDG2APBEN                 \ [0x0f] IWDG2APBEN
    $10 constant RCC_USBPHYEN                   \ [0x10] USBPHYEN
    $14 constant RCC_STGENROEN                  \ [0x14] STGENROEN
  [then]


  [ifdef] RCC_RCC_MP_APB4ENCLRR_DEF
    \
    \ @brief This register is used to clear the peripheral clock enable bit of the corresponding peripheral. It shall be used to deallocate a peripheral from MPU. Writing has no effect, reading will return the effective values of the corresponding bits. Writing a sets the corresponding bit to .
    \ Address offset: 0x204
    \ Reset value: 0x00000000
    \
    $00 constant RCC_LTDCEN                     \ [0x00] LTDCEN
    $04 constant RCC_DSIEN                      \ [0x04] DSIEN
    $08 constant RCC_DDRPERFMEN                 \ [0x08] DDRPERFMEN
    $0f constant RCC_IWDG2APBEN                 \ [0x0f] IWDG2APBEN
    $10 constant RCC_USBPHYEN                   \ [0x10] USBPHYEN
    $14 constant RCC_STGENROEN                  \ [0x14] STGENROEN
  [then]


  [ifdef] RCC_RCC_MP_APB5ENSETR_DEF
    \
    \ @brief This register is used to set the peripheral clock enable bit of the corresponding peripheral to . It shall be used to allocate a peripheral to the MPU. Writing has no effect, reading will return the effective values of the corresponding bits. Writing a sets the corresponding bit to .
    \ Address offset: 0x208
    \ Reset value: 0x00000000
    \
    $00 constant RCC_SPI6EN                     \ [0x00] SPI6EN
    $02 constant RCC_I2C4EN                     \ [0x02] I2C4EN
    $03 constant RCC_I2C6EN                     \ [0x03] I2C6EN
    $04 constant RCC_USART1EN                   \ [0x04] USART1EN
    $08 constant RCC_RTCAPBEN                   \ [0x08] RTCAPBEN
    $0b constant RCC_TZC1EN                     \ [0x0b] TZC1EN
    $0c constant RCC_TZC2EN                     \ [0x0c] TZC2EN
    $0d constant RCC_TZPCEN                     \ [0x0d] TZPCEN
    $0f constant RCC_IWDG1APBEN                 \ [0x0f] IWDG1APBEN
    $10 constant RCC_BSECEN                     \ [0x10] BSECEN
    $14 constant RCC_STGENEN                    \ [0x14] STGENEN
  [then]


  [ifdef] RCC_RCC_MP_APB5ENCLRR_DEF
    \
    \ @brief This register is used to clear the peripheral clock enable bit of the corresponding peripheral. It shall be used to deallocate a peripheral from MPU. Writing has no effect, reading will return the effective values of the corresponding bits. Writing a sets the corresponding bit to .
    \ Address offset: 0x20C
    \ Reset value: 0x00000000
    \
    $00 constant RCC_SPI6EN                     \ [0x00] SPI6EN
    $02 constant RCC_I2C4EN                     \ [0x02] I2C4EN
    $03 constant RCC_I2C6EN                     \ [0x03] I2C6EN
    $04 constant RCC_USART1EN                   \ [0x04] USART1EN
    $08 constant RCC_RTCAPBEN                   \ [0x08] RTCAPBEN
    $0b constant RCC_TZC1EN                     \ [0x0b] TZC1EN
    $0c constant RCC_TZC2EN                     \ [0x0c] TZC2EN
    $0d constant RCC_TZPCEN                     \ [0x0d] TZPCEN
    $0f constant RCC_IWDG1APBEN                 \ [0x0f] IWDG1APBEN
    $10 constant RCC_BSECEN                     \ [0x10] BSECEN
    $14 constant RCC_STGENEN                    \ [0x14] STGENEN
  [then]


  [ifdef] RCC_RCC_MP_AHB5ENSETR_DEF
    \
    \ @brief This register is used to set the peripheral clock enable bit of the corresponding peripheral to . It shall be used to allocate a peripheral to the MPU. Writing has no effect, reading will return the effective values of the corresponding bits. Writing a sets the corresponding bit to . If TZEN = , this register can only be modified in secure mode.
    \ Address offset: 0x210
    \ Reset value: 0x00010000
    \
    $00 constant RCC_GPIOZEN                    \ [0x00] GPIOZEN
    $04 constant RCC_CRYP1EN                    \ [0x04] CRYP1EN
    $05 constant RCC_HASH1EN                    \ [0x05] HASH1EN
    $06 constant RCC_RNG1EN                     \ [0x06] RNG1EN
    $08 constant RCC_BKPSRAMEN                  \ [0x08] BKPSRAMEN
    $10 constant RCC_AXIMCEN                    \ [0x10] AXIMCEN
  [then]


  [ifdef] RCC_RCC_MP_AHB5ENCLRR_DEF
    \
    \ @brief This register is used to clear the peripheral clock enable bit of the corresponding peripheral. It shall be used to deallocate a peripheral from MPU. Writing has no effect, reading will return the effective values of the corresponding bits. Writing a sets the corresponding bit to . If TZEN = , this register can only be modified in secure mode.
    \ Address offset: 0x214
    \ Reset value: 0x00010000
    \
    $00 constant RCC_GPIOZEN                    \ [0x00] GPIOZEN
    $04 constant RCC_CRYP1EN                    \ [0x04] CRYP1EN
    $05 constant RCC_HASH1EN                    \ [0x05] HASH1EN
    $06 constant RCC_RNG1EN                     \ [0x06] RNG1EN
    $08 constant RCC_BKPSRAMEN                  \ [0x08] BKPSRAMEN
    $10 constant RCC_AXIMCEN                    \ [0x10] AXIMCEN
  [then]


  [ifdef] RCC_RCC_MP_AHB6ENSETR_DEF
    \
    \ @brief This register is used to set the peripheral clock enable bit of the corresponding peripheral to . It shall be used to allocate a peripheral to the MPU. Writing has no effect, reading will return the effective values of the corresponding bits. Writing a sets the corresponding bit to .
    \ Address offset: 0x218
    \ Reset value: 0x00000000
    \
    $00 constant RCC_MDMAEN                     \ [0x00] MDMAEN
    $05 constant RCC_GPUEN                      \ [0x05] GPUEN
    $07 constant RCC_ETHCKEN                    \ [0x07] ETHCKEN
    $08 constant RCC_ETHTXEN                    \ [0x08] ETHTXEN
    $09 constant RCC_ETHRXEN                    \ [0x09] ETHRXEN
    $0a constant RCC_ETHMACEN                   \ [0x0a] ETHMACEN
    $0c constant RCC_FMCEN                      \ [0x0c] FMCEN
    $0e constant RCC_QSPIEN                     \ [0x0e] QSPIEN
    $10 constant RCC_SDMMC1EN                   \ [0x10] SDMMC1EN
    $11 constant RCC_SDMMC2EN                   \ [0x11] SDMMC2EN
    $14 constant RCC_CRC1EN                     \ [0x14] CRC1EN
    $18 constant RCC_USBHEN                     \ [0x18] USBHEN
  [then]


  [ifdef] RCC_RCC_MP_AHB6ENCLRR_DEF
    \
    \ @brief This register is used to clear the peripheral clock enable bit of the corresponding peripheral. It shall be used to deallocate a peripheral from MPU. Writing has no effect, reading will return the effective values of the corresponding bits. Writing a sets the corresponding bit to .
    \ Address offset: 0x21C
    \ Reset value: 0x00000000
    \
    $00 constant RCC_MDMAEN                     \ [0x00] MDMAEN
    $05 constant RCC_GPUEN                      \ [0x05] GPUEN
    $07 constant RCC_ETHCKEN                    \ [0x07] ETHCKEN
    $08 constant RCC_ETHTXEN                    \ [0x08] ETHTXEN
    $09 constant RCC_ETHRXEN                    \ [0x09] ETHRXEN
    $0a constant RCC_ETHMACEN                   \ [0x0a] ETHMACEN
    $0c constant RCC_FMCEN                      \ [0x0c] FMCEN
    $0e constant RCC_QSPIEN                     \ [0x0e] QSPIEN
    $10 constant RCC_SDMMC1EN                   \ [0x10] SDMMC1EN
    $11 constant RCC_SDMMC2EN                   \ [0x11] SDMMC2EN
    $14 constant RCC_CRC1EN                     \ [0x14] CRC1EN
    $18 constant RCC_USBHEN                     \ [0x18] USBHEN
  [then]


  [ifdef] RCC_RCC_MP_TZAHB6ENSETR_DEF
    \
    \ @brief This register is used to set the peripheral clock enable bit of the corresponding peripheral to . It shall be used to allocate a peripheral to the MPU. Writing has no effect, reading will return the effective values of the corresponding bits. Writing a sets the corresponding bit to . If TZEN = , this register can only be modified in secure mode.
    \ Address offset: 0x220
    \ Reset value: 0x00000000
    \
    $00 constant RCC_MDMAEN                     \ [0x00] MDMAEN
  [then]


  [ifdef] RCC_RCC_MP_TZAHB6ENCLRR_DEF
    \
    \ @brief This register is used to clear the peripheral clock enable bit of the corresponding peripheral. It shall be used to deallocate a peripheral from MPU. Writing has no effect, reading will return the effective values of the corresponding bits. Writing a sets the corresponding bit to . If TZEN = , this register can only be modified in secure mode.
    \ Address offset: 0x224
    \ Reset value: 0x00000000
    \
    $00 constant RCC_MDMAEN                     \ [0x00] MDMAEN
  [then]


  [ifdef] RCC_RCC_MC_APB4ENSETR_DEF
    \
    \ @brief This register is used to set the peripheral clock enable bit
    \ Address offset: 0x280
    \ Reset value: 0x00000000
    \
    $00 constant RCC_LTDCEN                     \ [0x00] LTDCEN
    $04 constant RCC_DSIEN                      \ [0x04] DSIEN
    $08 constant RCC_DDRPERFMEN                 \ [0x08] DDRPERFMEN
    $10 constant RCC_USBPHYEN                   \ [0x10] USBPHYEN
    $14 constant RCC_STGENROEN                  \ [0x14] STGENROEN
  [then]


  [ifdef] RCC_RCC_MC_APB4ENCLRR_DEF
    \
    \ @brief This register is used to clear the peripheral clock enable bit
    \ Address offset: 0x284
    \ Reset value: 0x00000000
    \
    $00 constant RCC_LTDCEN                     \ [0x00] LTDCEN
    $04 constant RCC_DSIEN                      \ [0x04] DSIEN
    $08 constant RCC_DDRPERFMEN                 \ [0x08] DDRPERFMEN
    $10 constant RCC_USBPHYEN                   \ [0x10] USBPHYEN
    $14 constant RCC_STGENROEN                  \ [0x14] STGENROEN
  [then]


  [ifdef] RCC_RCC_MC_APB5ENSETR_DEF
    \
    \ @brief This register is used to set the peripheral clock enable bit
    \ Address offset: 0x288
    \ Reset value: 0x00000000
    \
    $00 constant RCC_SPI6EN                     \ [0x00] SPI6EN
    $02 constant RCC_I2C4EN                     \ [0x02] I2C4EN
    $03 constant RCC_I2C6EN                     \ [0x03] I2C6EN
    $04 constant RCC_USART1EN                   \ [0x04] USART1EN
    $08 constant RCC_RTCAPBEN                   \ [0x08] RTCAPBEN
    $0b constant RCC_TZC1EN                     \ [0x0b] TZC1EN
    $0c constant RCC_TZC2EN                     \ [0x0c] TZC2EN
    $0d constant RCC_TZPCEN                     \ [0x0d] TZPCEN
    $10 constant RCC_BSECEN                     \ [0x10] BSECEN
    $14 constant RCC_STGENEN                    \ [0x14] STGENEN
  [then]


  [ifdef] RCC_RCC_MC_APB5ENCLRR_DEF
    \
    \ @brief This register is used to clear the peripheral clock enable bit
    \ Address offset: 0x28C
    \ Reset value: 0x00000000
    \
    $00 constant RCC_SPI6EN                     \ [0x00] SPI6EN
    $02 constant RCC_I2C4EN                     \ [0x02] I2C4EN
    $03 constant RCC_I2C6EN                     \ [0x03] I2C6EN
    $04 constant RCC_USART1EN                   \ [0x04] USART1EN
    $08 constant RCC_RTCAPBEN                   \ [0x08] RTCAPBEN
    $0b constant RCC_TZC1EN                     \ [0x0b] TZC1EN
    $0c constant RCC_TZC2EN                     \ [0x0c] TZC2EN
    $0d constant RCC_TZPCEN                     \ [0x0d] TZPCEN
    $10 constant RCC_BSECEN                     \ [0x10] BSECEN
    $14 constant RCC_STGENEN                    \ [0x14] STGENEN
  [then]


  [ifdef] RCC_RCC_MC_AHB5ENSETR_DEF
    \
    \ @brief This register is used to set the peripheral clock enable bit If TZEN = , this register can only be modified in secure mode.
    \ Address offset: 0x290
    \ Reset value: 0x00000000
    \
    $00 constant RCC_GPIOZEN                    \ [0x00] GPIOZEN
    $04 constant RCC_CRYP1EN                    \ [0x04] CRYP1EN
    $05 constant RCC_HASH1EN                    \ [0x05] HASH1EN
    $06 constant RCC_RNG1EN                     \ [0x06] RNG1EN
    $08 constant RCC_BKPSRAMEN                  \ [0x08] BKPSRAMEN
  [then]


  [ifdef] RCC_RCC_MC_AHB5ENCLRR_DEF
    \
    \ @brief This register is used to clear the peripheral clock enable bit If TZEN = , this register can only be modified in secure mode.
    \ Address offset: 0x294
    \ Reset value: 0x00000000
    \
    $00 constant RCC_GPIOZEN                    \ [0x00] GPIOZEN
    $04 constant RCC_CRYP1EN                    \ [0x04] CRYP1EN
    $05 constant RCC_HASH1EN                    \ [0x05] HASH1EN
    $06 constant RCC_RNG1EN                     \ [0x06] RNG1EN
    $08 constant RCC_BKPSRAMEN                  \ [0x08] BKPSRAMEN
  [then]


  [ifdef] RCC_RCC_MC_AHB6ENSETR_DEF
    \
    \ @brief This register is used to set the peripheral clock enable bit
    \ Address offset: 0x298
    \ Reset value: 0x00000000
    \
    $00 constant RCC_MDMAEN                     \ [0x00] MDMAEN
    $05 constant RCC_GPUEN                      \ [0x05] GPUEN
    $07 constant RCC_ETHCKEN                    \ [0x07] ETHCKEN
    $08 constant RCC_ETHTXEN                    \ [0x08] ETHTXEN
    $09 constant RCC_ETHRXEN                    \ [0x09] ETHRXEN
    $0a constant RCC_ETHMACEN                   \ [0x0a] ETHMACEN
    $0c constant RCC_FMCEN                      \ [0x0c] FMCEN
    $0e constant RCC_QSPIEN                     \ [0x0e] QSPIEN
    $10 constant RCC_SDMMC1EN                   \ [0x10] SDMMC1EN
    $11 constant RCC_SDMMC2EN                   \ [0x11] SDMMC2EN
    $14 constant RCC_CRC1EN                     \ [0x14] CRC1EN
    $18 constant RCC_USBHEN                     \ [0x18] USBHEN
  [then]


  [ifdef] RCC_RCC_MC_AHB6ENCLRR_DEF
    \
    \ @brief This register is used to clear the peripheral clock enable bit
    \ Address offset: 0x29C
    \ Reset value: 0x00000000
    \
    $00 constant RCC_MDMAEN                     \ [0x00] MDMAEN
    $05 constant RCC_GPUEN                      \ [0x05] GPUEN
    $07 constant RCC_ETHCKEN                    \ [0x07] ETHCKEN
    $08 constant RCC_ETHTXEN                    \ [0x08] ETHTXEN
    $09 constant RCC_ETHRXEN                    \ [0x09] ETHRXEN
    $0a constant RCC_ETHMACEN                   \ [0x0a] ETHMACEN
    $0c constant RCC_FMCEN                      \ [0x0c] FMCEN
    $0e constant RCC_QSPIEN                     \ [0x0e] QSPIEN
    $10 constant RCC_SDMMC1EN                   \ [0x10] SDMMC1EN
    $11 constant RCC_SDMMC2EN                   \ [0x11] SDMMC2EN
    $14 constant RCC_CRC1EN                     \ [0x14] CRC1EN
    $18 constant RCC_USBHEN                     \ [0x18] USBHEN
  [then]


  [ifdef] RCC_RCC_MP_APB4LPENSETR_DEF
    \
    \ @brief This register is used by the MCU in order to clear the PERxLPEN bits
    \ Address offset: 0x300
    \ Reset value: 0x00118111
    \
    $00 constant RCC_LTDCLPEN                   \ [0x00] LTDCLPEN
    $04 constant RCC_DSILPEN                    \ [0x04] DSILPEN
    $08 constant RCC_DDRPERFMLPEN               \ [0x08] DDRPERFMLPEN
    $0f constant RCC_IWDG2APBLPEN               \ [0x0f] IWDG2APBLPEN
    $10 constant RCC_USBPHYLPEN                 \ [0x10] USBPHYLPEN
    $14 constant RCC_STGENROLPEN                \ [0x14] STGENROLPEN
    $15 constant RCC_STGENROSTPEN               \ [0x15] STGENROSTPEN
  [then]


  [ifdef] RCC_RCC_MP_APB4LPENCLRR_DEF
    \
    \ @brief This register is used by the MCU
    \ Address offset: 0x304
    \ Reset value: 0x00118111
    \
    $00 constant RCC_LTDCLPEN                   \ [0x00] LTDCLPEN
    $04 constant RCC_DSILPEN                    \ [0x04] DSILPEN
    $08 constant RCC_DDRPERFMLPEN               \ [0x08] DDRPERFMLPEN
    $0f constant RCC_IWDG2APBLPEN               \ [0x0f] IWDG2APBLPEN
    $10 constant RCC_USBPHYLPEN                 \ [0x10] USBPHYLPEN
    $14 constant RCC_STGENROLPEN                \ [0x14] STGENROLPEN
    $15 constant RCC_STGENROSTPEN               \ [0x15] STGENROSTPEN
  [then]


  [ifdef] RCC_RCC_MP_APB5LPENSETR_DEF
    \
    \ @brief This register is used by the MCU in order to clear the PERxLPEN bits If TZEN = , this register can only be modified in secure mode.
    \ Address offset: 0x308
    \ Reset value: 0x0011391D
    \
    $00 constant RCC_SPI6LPEN                   \ [0x00] SPI6LPEN
    $02 constant RCC_I2C4LPEN                   \ [0x02] I2C4LPEN
    $03 constant RCC_I2C6LPEN                   \ [0x03] I2C6LPEN
    $04 constant RCC_USART1LPEN                 \ [0x04] USART1LPEN
    $08 constant RCC_RTCAPBLPEN                 \ [0x08] RTCAPBLPEN
    $0b constant RCC_TZC1LPEN                   \ [0x0b] TZC1LPEN
    $0c constant RCC_TZC2LPEN                   \ [0x0c] TZC2LPEN
    $0d constant RCC_TZPCLPEN                   \ [0x0d] TZPCLPEN
    $0f constant RCC_IWDG1APBLPEN               \ [0x0f] IWDG1APBLPEN
    $10 constant RCC_BSECLPEN                   \ [0x10] BSECLPEN
    $14 constant RCC_STGENLPEN                  \ [0x14] STGENLPEN
    $15 constant RCC_STGENSTPEN                 \ [0x15] STGENSTPEN
  [then]


  [ifdef] RCC_RCC_MP_APB5LPENCLRR_DEF
    \
    \ @brief This register is used by the Mpu.
    \ Address offset: 0x30C
    \ Reset value: 0x0011391D
    \
    $00 constant RCC_SPI6LPEN                   \ [0x00] SPI6LPEN
    $02 constant RCC_I2C4LPEN                   \ [0x02] I2C4LPEN
    $03 constant RCC_I2C6LPEN                   \ [0x03] I2C6LPEN
    $04 constant RCC_USART1LPEN                 \ [0x04] USART1LPEN
    $08 constant RCC_RTCAPBLPEN                 \ [0x08] RTCAPBLPEN
    $0b constant RCC_TZC1LPEN                   \ [0x0b] TZC1LPEN
    $0c constant RCC_TZC2LPEN                   \ [0x0c] TZC2LPEN
    $0d constant RCC_TZPCLPEN                   \ [0x0d] TZPCLPEN
    $0f constant RCC_IWDG1APBLPEN               \ [0x0f] IWDG1APBLPEN
    $10 constant RCC_BSECLPEN                   \ [0x10] BSECLPEN
    $14 constant RCC_STGENLPEN                  \ [0x14] STGENLPEN
    $15 constant RCC_STGENSTPEN                 \ [0x15] STGENSTPEN
  [then]


  [ifdef] RCC_RCC_MP_AHB5LPENSETR_DEF
    \
    \ @brief This register is used by the MCU in order to clear the PERxLPEN bits If TZEN = , this register can only be modified in secure mode.
    \ Address offset: 0x310
    \ Reset value: 0x00000171
    \
    $00 constant RCC_GPIOZLPEN                  \ [0x00] GPIOZLPEN
    $04 constant RCC_CRYP1LPEN                  \ [0x04] CRYP1LPEN
    $05 constant RCC_HASH1LPEN                  \ [0x05] HASH1LPEN
    $06 constant RCC_RNG1LPEN                   \ [0x06] RNG1LPEN
    $08 constant RCC_BKPSRAMLPEN                \ [0x08] BKPSRAMLPEN
  [then]


  [ifdef] RCC_RCC_MP_AHB5LPENCLRR_DEF
    \
    \ @brief This register is used by the MCU
    \ Address offset: 0x314
    \ Reset value: 0x00000171
    \
    $00 constant RCC_GPIOZLPEN                  \ [0x00] GPIOZLPEN
    $04 constant RCC_CRYP1LPEN                  \ [0x04] CRYP1LPEN
    $05 constant RCC_HASH1LPEN                  \ [0x05] HASH1LPEN
    $06 constant RCC_RNG1LPEN                   \ [0x06] RNG1LPEN
    $08 constant RCC_BKPSRAMLPEN                \ [0x08] BKPSRAMLPEN
  [then]


  [ifdef] RCC_RCC_MP_AHB6LPENSETR_DEF
    \
    \ @brief This register is used by the MCU in order to clear the PERxLPEN bits
    \ Address offset: 0x318
    \ Reset value: 0x011357A1
    \
    $00 constant RCC_MDMALPEN                   \ [0x00] MDMALPEN
    $05 constant RCC_GPULPEN                    \ [0x05] GPULPEN
    $07 constant RCC_ETHCKLPEN                  \ [0x07] ETHCKLPEN
    $08 constant RCC_ETHTXLPEN                  \ [0x08] ETHTXLPEN
    $09 constant RCC_ETHRXLPEN                  \ [0x09] ETHRXLPEN
    $0a constant RCC_ETHMACLPEN                 \ [0x0a] ETHMACLPEN
    $0b constant RCC_ETHSTPEN                   \ [0x0b] ETHSTPEN
    $0c constant RCC_FMCLPEN                    \ [0x0c] FMCLPEN
    $0e constant RCC_QSPILPEN                   \ [0x0e] QSPILPEN
    $10 constant RCC_SDMMC1LPEN                 \ [0x10] SDMMC1LPEN
    $11 constant RCC_SDMMC2LPEN                 \ [0x11] SDMMC2LPEN
    $14 constant RCC_CRC1LPEN                   \ [0x14] CRC1LPEN
    $18 constant RCC_USBHLPEN                   \ [0x18] USBHLPEN
  [then]


  [ifdef] RCC_RCC_MP_AHB6LPENCLRR_DEF
    \
    \ @brief This register is used by the MCU in order to clear the PERxLPEN bits
    \ Address offset: 0x31C
    \ Reset value: 0x011357A1
    \
    $00 constant RCC_MDMALPEN                   \ [0x00] MDMALPEN
    $05 constant RCC_GPULPEN                    \ [0x05] GPULPEN
    $07 constant RCC_ETHCKLPEN                  \ [0x07] ETHCKLPEN
    $08 constant RCC_ETHTXLPEN                  \ [0x08] ETHTXLPEN
    $09 constant RCC_ETHRXLPEN                  \ [0x09] ETHRXLPEN
    $0a constant RCC_ETHMACLPEN                 \ [0x0a] ETHMACLPEN
    $0b constant RCC_ETHSTPEN                   \ [0x0b] ETHSTPEN
    $0c constant RCC_FMCLPEN                    \ [0x0c] FMCLPEN
    $0e constant RCC_QSPILPEN                   \ [0x0e] QSPILPEN
    $10 constant RCC_SDMMC1LPEN                 \ [0x10] SDMMC1LPEN
    $11 constant RCC_SDMMC2LPEN                 \ [0x11] SDMMC2LPEN
    $14 constant RCC_CRC1LPEN                   \ [0x14] CRC1LPEN
    $18 constant RCC_USBHLPEN                   \ [0x18] USBHLPEN
  [then]


  [ifdef] RCC_RCC_MP_TZAHB6LPENSETR_DEF
    \
    \ @brief This register is used by the MCU in order to clear the PERxLPEN bits If TZEN = , this register can only be modified in secure mode.
    \ Address offset: 0x320
    \ Reset value: 0x00000001
    \
    $00 constant RCC_MDMALPEN                   \ [0x00] MDMALPEN
  [then]


  [ifdef] RCC_RCC_MP_TZAHB6LPENCLRR_DEF
    \
    \ @brief This register is used by the MCU in order to clear the PERxLPEN bits If TZEN = , this register can only be modified in secure mode.
    \ Address offset: 0x324
    \ Reset value: 0x00000001
    \
    $00 constant RCC_MDMALPEN                   \ [0x00] MDMALPEN
  [then]


  [ifdef] RCC_RCC_MC_APB4LPENSETR_DEF
    \
    \ @brief This register is used by the MCU in order to set the PERxLPEN bit.
    \ Address offset: 0x380
    \ Reset value: 0x00110111
    \
    $00 constant RCC_LTDCLPEN                   \ [0x00] LTDCLPEN
    $04 constant RCC_DSILPEN                    \ [0x04] DSILPEN
    $08 constant RCC_DDRPERFMLPEN               \ [0x08] DDRPERFMLPEN
    $10 constant RCC_USBPHYLPEN                 \ [0x10] USBPHYLPEN
    $14 constant RCC_STGENROLPEN                \ [0x14] STGENROLPEN
    $15 constant RCC_STGENROSTPEN               \ [0x15] STGENROSTPEN
  [then]


  [ifdef] RCC_RCC_MC_APB4LPENCLRR_DEF
    \
    \ @brief This register is used by the MCU in order to clear the PERxLPEN bit
    \ Address offset: 0x384
    \ Reset value: 0x00110111
    \
    $00 constant RCC_LTDCLPEN                   \ [0x00] LTDCLPEN
    $04 constant RCC_DSILPEN                    \ [0x04] DSILPEN
    $08 constant RCC_DDRPERFMLPEN               \ [0x08] DDRPERFMLPEN
    $10 constant RCC_USBPHYLPEN                 \ [0x10] USBPHYLPEN
    $14 constant RCC_STGENROLPEN                \ [0x14] STGENROLPEN
    $15 constant RCC_STGENROSTPEN               \ [0x15] STGENROSTPEN
  [then]


  [ifdef] RCC_RCC_MC_APB5LPENSETR_DEF
    \
    \ @brief This register is used by the MCU in order to set the PERxLPEN bit.
    \ Address offset: 0x388
    \ Reset value: 0x0011391D
    \
    $00 constant RCC_SPI6LPEN                   \ [0x00] SPI6LPEN
    $02 constant RCC_I2C4LPEN                   \ [0x02] I2C4LPEN
    $03 constant RCC_I2C6LPEN                   \ [0x03] I2C6LPEN
    $04 constant RCC_USART1LPEN                 \ [0x04] USART1LPEN
    $08 constant RCC_RTCAPBLPEN                 \ [0x08] RTCAPBLPEN
    $0b constant RCC_TZC1LPEN                   \ [0x0b] TZC1LPEN
    $0c constant RCC_TZC2LPEN                   \ [0x0c] TZC2LPEN
    $0d constant RCC_TZPCLPEN                   \ [0x0d] TZPCLPEN
    $10 constant RCC_BSECLPEN                   \ [0x10] BSECLPEN
    $14 constant RCC_STGENLPEN                  \ [0x14] STGENLPEN
    $15 constant RCC_STGENSTPEN                 \ [0x15] STGENSTPEN
  [then]


  [ifdef] RCC_RCC_MC_APB5LPENCLRR_DEF
    \
    \ @brief This register is used by the MCU in order to clear the PERxLPEN bit
    \ Address offset: 0x38C
    \ Reset value: 0x0011391D
    \
    $00 constant RCC_SPI6LPEN                   \ [0x00] SPI6LPEN
    $02 constant RCC_I2C4LPEN                   \ [0x02] I2C4LPEN
    $03 constant RCC_I2C6LPEN                   \ [0x03] I2C6LPEN
    $04 constant RCC_USART1LPEN                 \ [0x04] USART1LPEN
    $08 constant RCC_RTCAPBLPEN                 \ [0x08] RTCAPBLPEN
    $0b constant RCC_TZC1LPEN                   \ [0x0b] TZC1LPEN
    $0c constant RCC_TZC2LPEN                   \ [0x0c] TZC2LPEN
    $0d constant RCC_TZPCLPEN                   \ [0x0d] TZPCLPEN
    $10 constant RCC_BSECLPEN                   \ [0x10] BSECLPEN
    $14 constant RCC_STGENLPEN                  \ [0x14] STGENLPEN
    $15 constant RCC_STGENSTPEN                 \ [0x15] STGENSTPEN
  [then]


  [ifdef] RCC_RCC_MC_AHB5LPENSETR_DEF
    \
    \ @brief This register is used by the MCU in order to set the PERxLPEN bit. If TZEN = , this register can only be modified in secure mode.
    \ Address offset: 0x390
    \ Reset value: 0x00000171
    \
    $00 constant RCC_GPIOZLPEN                  \ [0x00] GPIOZLPEN
    $04 constant RCC_CRYP1LPEN                  \ [0x04] CRYP1LPEN
    $05 constant RCC_HASH1LPEN                  \ [0x05] HASH1LPEN
    $06 constant RCC_RNG1LPEN                   \ [0x06] RNG1LPEN
    $08 constant RCC_BKPSRAMLPEN                \ [0x08] BKPSRAMLPEN
  [then]


  [ifdef] RCC_RCC_MC_AHB5LPENCLRR_DEF
    \
    \ @brief This register is used by the MCU in order to clear the PERxLPEN bit If TZEN = , this register can only be modified in secure mode.
    \ Address offset: 0x394
    \ Reset value: 0x00000171
    \
    $00 constant RCC_GPIOZLPEN                  \ [0x00] GPIOZLPEN
    $04 constant RCC_CRYP1LPEN                  \ [0x04] CRYP1LPEN
    $05 constant RCC_HASH1LPEN                  \ [0x05] HASH1LPEN
    $06 constant RCC_RNG1LPEN                   \ [0x06] RNG1LPEN
    $08 constant RCC_BKPSRAMLPEN                \ [0x08] BKPSRAMLPEN
  [then]


  [ifdef] RCC_RCC_MC_AHB6LPENSETR_DEF
    \
    \ @brief This register is used by the MCU in order to set the PERxLPEN bit.
    \ Address offset: 0x398
    \ Reset value: 0x011357A1
    \
    $00 constant RCC_MDMALPEN                   \ [0x00] MDMALPEN
    $05 constant RCC_GPULPEN                    \ [0x05] GPULPEN
    $07 constant RCC_ETHCKLPEN                  \ [0x07] ETHCKLPEN
    $08 constant RCC_ETHTXLPEN                  \ [0x08] ETHTXLPEN
    $09 constant RCC_ETHRXLPEN                  \ [0x09] ETHRXLPEN
    $0a constant RCC_ETHMACLPEN                 \ [0x0a] ETHMACLPEN
    $0b constant RCC_ETHSTPEN                   \ [0x0b] ETHSTPEN
    $0c constant RCC_FMCLPEN                    \ [0x0c] FMCLPEN
    $0e constant RCC_QSPILPEN                   \ [0x0e] QSPILPEN
    $10 constant RCC_SDMMC1LPEN                 \ [0x10] SDMMC1LPEN
    $11 constant RCC_SDMMC2LPEN                 \ [0x11] SDMMC2LPEN
    $14 constant RCC_CRC1LPEN                   \ [0x14] CRC1LPEN
    $18 constant RCC_USBHLPEN                   \ [0x18] USBHLPEN
  [then]


  [ifdef] RCC_RCC_MC_AHB6LPENCLRR_DEF
    \
    \ @brief This register is used by the MCU in order to clear the PERxLPEN bit
    \ Address offset: 0x39C
    \ Reset value: 0x011357A1
    \
    $00 constant RCC_MDMALPEN                   \ [0x00] MDMALPEN
    $05 constant RCC_GPULPEN                    \ [0x05] GPULPEN
    $07 constant RCC_ETHCKLPEN                  \ [0x07] ETHCKLPEN
    $08 constant RCC_ETHTXLPEN                  \ [0x08] ETHTXLPEN
    $09 constant RCC_ETHRXLPEN                  \ [0x09] ETHRXLPEN
    $0a constant RCC_ETHMACLPEN                 \ [0x0a] ETHMACLPEN
    $0b constant RCC_ETHSTPEN                   \ [0x0b] ETHSTPEN
    $0c constant RCC_FMCLPEN                    \ [0x0c] FMCLPEN
    $0e constant RCC_QSPILPEN                   \ [0x0e] QSPILPEN
    $10 constant RCC_SDMMC1LPEN                 \ [0x10] SDMMC1LPEN
    $11 constant RCC_SDMMC2LPEN                 \ [0x11] SDMMC2LPEN
    $14 constant RCC_CRC1LPEN                   \ [0x14] CRC1LPEN
    $18 constant RCC_USBHLPEN                   \ [0x18] USBHLPEN
  [then]


  [ifdef] RCC_RCC_BR_RSTSCLRR_DEF
    \
    \ @brief This register is used by the BOOTROM to check the reset source. Writing has no effect, reading will return the effective values of the corresponding bits. Writing a clears the corresponding bit to . In order to identify the reset source, the MPU application must use RCC MPU Reset Status Clear Register (RCC_MP_RSTSCLRR), and the MCU application must use the RCC MCU Reset Status Clear Register (RCC_MC_RSTSCLRR). Refer to Section10.3.13: Reset source identification for details.This register except MPUP[1:0]RSTF flags is located into VDD domain, and is reset by por_rst reset. The MPUP[1:0]RSTF flags are located into VDDCORE and are reset by nreset. If TZEN = , this register can only be modified in secure mode.
    \ Address offset: 0x400
    \ Reset value: 0x00000015
    \
    $00 constant RCC_PORRSTF                    \ [0x00] PORRSTF
    $01 constant RCC_BORRSTF                    \ [0x01] BORRSTF
    $02 constant RCC_PADRSTF                    \ [0x02] PADRSTF
    $03 constant RCC_HCSSRSTF                   \ [0x03] HCSSRSTF
    $04 constant RCC_VCORERSTF                  \ [0x04] VCORERSTF
    $06 constant RCC_MPSYSRSTF                  \ [0x06] MPSYSRSTF
    $07 constant RCC_MCSYSRSTF                  \ [0x07] MCSYSRSTF
    $08 constant RCC_IWDG1RSTF                  \ [0x08] IWDG1RSTF
    $09 constant RCC_IWDG2RSTF                  \ [0x09] IWDG2RSTF
    $0d constant RCC_MPUP0RSTF                  \ [0x0d] MPUP0RSTF
    $0e constant RCC_MPUP1RSTF                  \ [0x0e] MPUP1RSTF
  [then]


  [ifdef] RCC_RCC_MP_GRSTCSETR_DEF
    \
    \ @brief This register is used by the MPU in order to generate either a MCU reset or a system reset or a reset of one of the two MPU processors. Writing has no effect, reading returns the effective values of the corresponding bits. Writing a activates the reset.
    \ Address offset: 0x404
    \ Reset value: 0x00000000
    \
    $00 constant RCC_MPSYSRST                   \ [0x00] MPSYSRST
    $01 constant RCC_MCURST                     \ [0x01] MCURST
    $04 constant RCC_MPUP0RST                   \ [0x04] MPUP0RST
    $05 constant RCC_MPUP1RST                   \ [0x05] MPUP1RST
  [then]


  [ifdef] RCC_RCC_MP_RSTSCLRR_DEF
    \
    \ @brief This register is used by the MPU to check the reset source. This register is updated by the BOOTROM code, after a power-on reset (por_rst), a system reset (nreset), or an exit from Standby or CStandby.Writing has no effect, reading will return the effective values of the corresponding bits. Writing a clears the corresponding bit to .Refer to Section10.3.13: Reset source identification for details.The register is located in VDDCORE.If TZEN = , this register can only be modified in secure mode.
    \ Address offset: 0x408
    \ Reset value: 0x00000000
    \
    $00 constant RCC_PORRSTF                    \ [0x00] PORRSTF
    $01 constant RCC_BORRSTF                    \ [0x01] BORRSTF
    $02 constant RCC_PADRSTF                    \ [0x02] PADRSTF
    $03 constant RCC_HCSSRSTF                   \ [0x03] HCSSRSTF
    $04 constant RCC_VCORERSTF                  \ [0x04] VCORERSTF
    $06 constant RCC_MPSYSRSTF                  \ [0x06] MPSYSRSTF
    $07 constant RCC_MCSYSRSTF                  \ [0x07] MCSYSRSTF
    $08 constant RCC_IWDG1RSTF                  \ [0x08] IWDG1RSTF
    $09 constant RCC_IWDG2RSTF                  \ [0x09] IWDG2RSTF
    $0b constant RCC_STDBYRSTF                  \ [0x0b] STDBYRSTF
    $0c constant RCC_CSTDBYRSTF                 \ [0x0c] CSTDBYRSTF
    $0d constant RCC_MPUP0RSTF                  \ [0x0d] MPUP0RSTF
    $0e constant RCC_MPUP1RSTF                  \ [0x0e] MPUP1RSTF
    $0f constant RCC_SPARE                      \ [0x0f] SPARE
  [then]


  [ifdef] RCC_RCC_MP_IWDGFZSETR_DEF
    \
    \ @brief This register is used by the BOOTROM in order to freeze the IWDGs clocks. After a system reset or Standby reset (nreset), or a CStandby reset (cstby_rst) the MPU is allowed to write it once.Writing has no effect, reading will return the effective values of the corresponding bits. Writing a sets the corresponding bit to . If TZEN = , this register can only be modified in secure mode.
    \ Address offset: 0x40C
    \ Reset value: 0x00000000
    \
    $00 constant RCC_FZ_IWDG1                   \ [0x00] FZ_IWDG1
    $01 constant RCC_FZ_IWDG2                   \ [0x01] FZ_IWDG2
  [then]


  [ifdef] RCC_RCC_MP_IWDGFZCLRR_DEF
    \
    \ @brief This register is used by the BOOTROM in order to unfreeze the IWDGs clocks. Writing has no effect, reading will return the effective values of the corresponding bits. Writing a clears the corresponding bit to . If TZEN = , this register can only be modified in secure mode.
    \ Address offset: 0x410
    \ Reset value: 0x00000000
    \
    $00 constant RCC_FZ_IWDG1                   \ [0x00] FZ_IWDG1
    $01 constant RCC_FZ_IWDG2                   \ [0x01] FZ_IWDG2
  [then]


  [ifdef] RCC_RCC_MP_CIER_DEF
    \
    \ @brief This register shall be used by the MPU to control the interrupt source enable. Refer to Section10.5: RCC interrupts for more details. If TZEN = , this register can only be modified in secure mode.
    \ Address offset: 0x414
    \ Reset value: 0x00000000
    \
    $00 constant RCC_LSIRDYIE                   \ [0x00] LSIRDYIE
    $01 constant RCC_LSERDYIE                   \ [0x01] LSERDYIE
    $02 constant RCC_HSIRDYIE                   \ [0x02] HSIRDYIE
    $03 constant RCC_HSERDYIE                   \ [0x03] HSERDYIE
    $04 constant RCC_CSIRDYIE                   \ [0x04] CSIRDYIE
    $08 constant RCC_PLL1DYIE                   \ [0x08] PLL1DYIE
    $09 constant RCC_PLL2DYIE                   \ [0x09] PLL2DYIE
    $0a constant RCC_PLL3DYIE                   \ [0x0a] PLL3DYIE
    $0b constant RCC_PLL4DYIE                   \ [0x0b] PLL4DYIE
    $10 constant RCC_LSECSSIE                   \ [0x10] LSECSSIE
    $14 constant RCC_WKUPIE                     \ [0x14] WKUPIE
  [then]


  [ifdef] RCC_RCC_MP_CIFR_DEF
    \
    \ @brief This register shall be used by the MPU in order to read and clear the interrupt flags.Writing has no effect, writing will clear the corresponding flag.Refer to Section10.5: RCC interrupts for more details. If TZEN = , this register can only be modified in secure mode.
    \ Address offset: 0x418
    \ Reset value: 0x00000000
    \
    $00 constant RCC_LSIRDYF                    \ [0x00] LSIRDYF
    $01 constant RCC_LSERDYF                    \ [0x01] LSERDYF
    $02 constant RCC_HSIRDYF                    \ [0x02] HSIRDYF
    $03 constant RCC_HSERDYF                    \ [0x03] HSERDYF
    $04 constant RCC_CSIRDYF                    \ [0x04] CSIRDYF
    $08 constant RCC_PLL1DYF                    \ [0x08] PLL1DYF
    $09 constant RCC_PLL2DYF                    \ [0x09] PLL2DYF
    $0a constant RCC_PLL3DYF                    \ [0x0a] PLL3DYF
    $0b constant RCC_PLL4DYF                    \ [0x0b] PLL4DYF
    $10 constant RCC_LSECSSF                    \ [0x10] LSECSSF
    $14 constant RCC_WKUPF                      \ [0x14] WKUPF
  [then]


  [ifdef] RCC_RCC_PWRLPDLYCR_DEF
    \
    \ @brief This register is used to program the delay between the moment where the system exits from one of the Stop modes, and the moment where it is allowed to enable the PLLs and provide a clock to bridges and processors. If TZEN = , this register can only be modified in secure mode.
    \ Address offset: 0x41C
    \ Reset value: 0x00000000
    \
    $00 constant RCC_PWRLP_DLY                  \ [0x00 : 22] PWRLP_DLY
    $18 constant RCC_MCTMPSKP                   \ [0x18] MCTMPSKP
  [then]


  [ifdef] RCC_RCC_MP_RSTSSETR_DEF
    \
    \ @brief This register is dedicated to the BOOTROM code in order to update the reset source. This register is updated by the BOOTROM code, after a power-on reset (por_rst), a system reset (nreset), or an exit from Standby or CStandby. The application software shall not use this register. In order to identify the reset source, the MPU application must use RCC MPU Reset Status Clear Register (RCC_MP_RSTSCLRR), and the MCU application must use the RCC MCU Reset Status Clear Register (RCC_MC_RSTSCLRR).Writing has no effect, reading will return the effective values of the corresponding bits. Writing a sets the corresponding bit to .Refer to Section10.3.13: Reset source identification for details.The register is located in VDDCORE.If TZEN = , this register can only be modified in secure mode.
    \ Address offset: 0x420
    \ Reset value: 0x00000000
    \
    $00 constant RCC_PORRSTF                    \ [0x00] PORRSTF
    $01 constant RCC_BORRSTF                    \ [0x01] BORRSTF
    $02 constant RCC_PADRSTF                    \ [0x02] PADRSTF
    $03 constant RCC_HCSSRSTF                   \ [0x03] HCSSRSTF
    $04 constant RCC_VCORERSTF                  \ [0x04] VCORERSTF
    $06 constant RCC_MPSYSRSTF                  \ [0x06] MPSYSRSTF
    $07 constant RCC_MCSYSRSTF                  \ [0x07] MCSYSRSTF
    $08 constant RCC_IWDG1RSTF                  \ [0x08] IWDG1RSTF
    $09 constant RCC_IWDG2RSTF                  \ [0x09] IWDG2RSTF
    $0b constant RCC_STDBYRSTF                  \ [0x0b] STDBYRSTF
    $0c constant RCC_CSTDBYRSTF                 \ [0x0c] CSTDBYRSTF
    $0d constant RCC_MPUP0RSTF                  \ [0x0d] MPUP0RSTF
    $0e constant RCC_MPUP1RSTF                  \ [0x0e] MPUP1RSTF
    $0f constant RCC_SPARE                      \ [0x0f] SPARE
  [then]


  [ifdef] RCC_RCC_MCO1CFGR_DEF
    \
    \ @brief This register is used to select the clock generated on MCO1 output.
    \ Address offset: 0x800
    \ Reset value: 0x00000000
    \
    $00 constant RCC_MCO1SEL                    \ [0x00 : 3] MCO1SEL
    $04 constant RCC_MCO1DIV                    \ [0x04 : 4] MCO1DIV
    $0c constant RCC_MCO1ON                     \ [0x0c] MCO1ON
  [then]


  [ifdef] RCC_RCC_MCO2CFGR_DEF
    \
    \ @brief This register is used to select the clock generated on MCO2 output.
    \ Address offset: 0x804
    \ Reset value: 0x00000000
    \
    $00 constant RCC_MCO2SEL                    \ [0x00 : 3] MCO2SEL
    $04 constant RCC_MCO2DIV                    \ [0x04 : 4] MCO2DIV
    $0c constant RCC_MCO2ON                     \ [0x0c] MCO2ON
  [then]


  [ifdef] RCC_RCC_OCRDYR_DEF
    \
    \ @brief This is a read-only access register, It contains the status flags of oscillators. Writing has no effect.
    \ Address offset: 0x808
    \ Reset value: 0x00000000
    \
    $00 constant RCC_HSIRDY                     \ [0x00] HSIRDY
    $02 constant RCC_HSIDIVRDY                  \ [0x02] HSIDIVRDY
    $04 constant RCC_CSIRDY                     \ [0x04] CSIRDY
    $08 constant RCC_HSERDY                     \ [0x08] HSERDY
    $17 constant RCC_MPUCKRDY                   \ [0x17] MPUCKRDY
    $18 constant RCC_AXICKRDY                   \ [0x18] AXICKRDY
    $19 constant RCC_CKREST                     \ [0x19] CKREST
  [then]


  [ifdef] RCC_RCC_DBGCFGR_DEF
    \
    \ @brief This is register contains the enable control of the debug and trace function, and the clock divider for the trace function.
    \ Address offset: 0x80C
    \ Reset value: 0x00000001
    \
    $00 constant RCC_TRACEDIV                   \ [0x00 : 3] TRACEDIV
    $08 constant RCC_DBGCKEN                    \ [0x08] DBGCKEN
    $09 constant RCC_TRACECKEN                  \ [0x09] TRACECKEN
    $0c constant RCC_DBGRST                     \ [0x0c] DBGRST
  [then]


  [ifdef] RCC_RCC_RCK3SELR_DEF
    \
    \ @brief This register is used to select the reference clock for PLL3. If TZEN = MCKPROT = , this register can only be modified in secure mode.
    \ Address offset: 0x820
    \ Reset value: 0x80000000
    \
    $00 constant RCC_PLL3SRC                    \ [0x00 : 2] PLL3SRC
    $1f constant RCC_PLL3SRCRDY                 \ [0x1f] PLL3SRCRDY
  [then]


  [ifdef] RCC_RCC_RCK4SELR_DEF
    \
    \ @brief This register is used to select the reference clock for PLL4.
    \ Address offset: 0x824
    \ Reset value: 0x80000000
    \
    $00 constant RCC_PLL4SRC                    \ [0x00 : 2] PLL4SRC
    $1f constant RCC_PLL4SRCRDY                 \ [0x1f] PLL4SRCRDY
  [then]


  [ifdef] RCC_RCC_TIMG1PRER_DEF
    \
    \ @brief This register is used to control the prescaler value of timers located into APB1 domain. It concerns TIM2, TIM3, TIM4, TIM5, TIM6, TIM7, TIM12, TIM13 and TIM14. Refer to Section: Sub-system clock generation for additional information.
    \ Address offset: 0x828
    \ Reset value: 0x80000000
    \
    $00 constant RCC_TIMG1PRE                   \ [0x00] TIMG1PRE
    $1f constant RCC_TIMG1PRERDY                \ [0x1f] TIMG1PRERDY
  [then]


  [ifdef] RCC_RCC_TIMG2PRER_DEF
    \
    \ @brief This register is used to control the prescaler value of timers located into APB2 domain. It concerns TIM1, TIM8, TIM15, TIM16, and TIM17. Refer to Section: Sub-system clock generation for additional information.
    \ Address offset: 0x82C
    \ Reset value: 0x80000000
    \
    $00 constant RCC_TIMG2PRE                   \ [0x00] TIMG2PRE
    $1f constant RCC_TIMG2PRERDY                \ [0x1f] TIMG2PRERDY
  [then]


  [ifdef] RCC_RCC_MCUDIVR_DEF
    \
    \ @brief This register is used to control the MCU sub-system clock prescaler. Refer to Section: Sub-system clock generation for additional information. If TZEN = , this register can only be modified in secure mode.
    \ Address offset: 0x830
    \ Reset value: 0x80000000
    \
    $00 constant RCC_MCUDIV                     \ [0x00 : 4] MCUDIV
    $1f constant RCC_MCUDIVRDY                  \ [0x1f] MCUDIVRDY
  [then]


  [ifdef] RCC_RCC_APB1DIVR_DEF
    \
    \ @brief This register is used to control the APB1 clock prescaler. Refer to section Section1.4.6.3: Sub-System Clock Generation for additional information.
    \ Address offset: 0x834
    \ Reset value: 0x80000000
    \
    $00 constant RCC_APB1DIV                    \ [0x00 : 3] APB1DIV
    $1f constant RCC_APB1DIVRDY                 \ [0x1f] APB1DIVRDY
  [then]


  [ifdef] RCC_RCC_APB2DIVR_DEF
    \
    \ @brief This register is used to control the APB2 clock prescaler. Refer to Section: Sub-system clock generation for additional information.
    \ Address offset: 0x838
    \ Reset value: 0x80000000
    \
    $00 constant RCC_APB2DIV                    \ [0x00 : 3] APB2DIV
    $1f constant RCC_APB2DIVRDY                 \ [0x1f] APB2DIVRDY
  [then]


  [ifdef] RCC_RCC_APB3DIVR_DEF
    \
    \ @brief This register is used to control the APB3 clock prescaler. Refer to Section: Sub-system clock generation for additional information.
    \ Address offset: 0x83C
    \ Reset value: 0x80000000
    \
    $00 constant RCC_APB3DIV                    \ [0x00 : 3] APB3DIV
    $1f constant RCC_APB3DIVRDY                 \ [0x1f] APB3DIVRDY
  [then]


  [ifdef] RCC_RCC_PLL3CR_DEF
    \
    \ @brief This register is used to control the PLL3. If TZEN = MCKPROT = , this register can only be modified in secure mode.
    \ Address offset: 0x880
    \ Reset value: 0x00000000
    \
    $00 constant RCC_PLLON                      \ [0x00] PLLON
    $01 constant RCC_PLL3RDY                    \ [0x01] PLL3RDY
    $02 constant RCC_SSCG_CTRL                  \ [0x02] SSCG_CTRL
    $04 constant RCC_DIVPEN                     \ [0x04] DIVPEN
    $05 constant RCC_DIVQEN                     \ [0x05] DIVQEN
    $06 constant RCC_DIVREN                     \ [0x06] DIVREN
  [then]


  [ifdef] RCC_RCC_PLL3CFGR1_DEF
    \
    \ @brief This register is used to configure the PLL3. If TZEN = MCKPROT = , this register can only be modified in secure mode.
    \ Address offset: 0x884
    \ Reset value: 0x00010031
    \
    $00 constant RCC_DIVN                       \ [0x00 : 9] DIVN
    $10 constant RCC_DIVM3                      \ [0x10 : 6] DIVM3
    $18 constant RCC_IFRGE                      \ [0x18 : 2] IFRGE
  [then]


  [ifdef] RCC_RCC_PLL3CFGR2_DEF
    \
    \ @brief This register is used to configure the PLL3. If TZEN = MCKPROT = , this register can only be modified in secure mode.
    \ Address offset: 0x888
    \ Reset value: 0x00010101
    \
    $00 constant RCC_DIVP                       \ [0x00 : 7] DIVP
    $08 constant RCC_DIVQ                       \ [0x08 : 7] DIVQ
    $10 constant RCC_DIVR                       \ [0x10 : 7] DIVR
  [then]


  [ifdef] RCC_RCC_PLL3FRACR_DEF
    \
    \ @brief This register is used to fine-tune the frequency of the PLL3 VCO. If TZEN = MCKPROT = , this register can only be modified in secure mode.
    \ Address offset: 0x88C
    \ Reset value: 0x00000000
    \
    $03 constant RCC_FRACV                      \ [0x03 : 13] FRACV
    $10 constant RCC_FRACLE                     \ [0x10] FRACLE
  [then]


  [ifdef] RCC_RCC_PLL3CSGR_DEF
    \
    \ @brief This register is used to configure the PLL3.It is not recommended to change the content of this register when the PLL3 is enabled (PLLON = ). Refer to Section: Using the PLLs in spread spectrum mode for details. If TZEN = MCKPROT = , this register can only be modified in secure mode.
    \ Address offset: 0x890
    \ Reset value: 0x00000000
    \
    $00 constant RCC_MOD_PER                    \ [0x00 : 13] MOD_PER
    $0d constant RCC_TPDFN_DIS                  \ [0x0d] TPDFN_DIS
    $0e constant RCC_RPDFN_DIS                  \ [0x0e] RPDFN_DIS
    $0f constant RCC_SSCG_MODE                  \ [0x0f] SSCG_MODE
    $10 constant RCC_INC_STEP                   \ [0x10 : 15] INC_STEP
  [then]


  [ifdef] RCC_RCC_PLL4CR_DEF
    \
    \ @brief This register is used to control the PLL4.
    \ Address offset: 0x894
    \ Reset value: 0x00000000
    \
    $00 constant RCC_PLLON                      \ [0x00] PLLON
    $01 constant RCC_PLL4RDY                    \ [0x01] PLL4RDY
    $02 constant RCC_SSCG_CTRL                  \ [0x02] SSCG_CTRL
    $04 constant RCC_DIVPEN                     \ [0x04] DIVPEN
    $05 constant RCC_DIVQEN                     \ [0x05] DIVQEN
    $06 constant RCC_DIVREN                     \ [0x06] DIVREN
  [then]


  [ifdef] RCC_RCC_PLL4CFGR1_DEF
    \
    \ @brief This register is used to configure the PLL4.
    \ Address offset: 0x898
    \ Reset value: 0x00010031
    \
    $00 constant RCC_DIVN                       \ [0x00 : 9] DIVN
    $10 constant RCC_DIVM4                      \ [0x10 : 6] DIVM4
    $18 constant RCC_IFRGE                      \ [0x18 : 2] IFRGE
  [then]


  [ifdef] RCC_RCC_PLL4CFGR2_DEF
    \
    \ @brief This register is used to configure the PLL4.
    \ Address offset: 0x89C
    \ Reset value: 0x00000000
    \
    $00 constant RCC_DIVP                       \ [0x00 : 7] DIVP
    $08 constant RCC_DIVQ                       \ [0x08 : 7] DIVQ
    $10 constant RCC_DIVR                       \ [0x10 : 7] DIVR
  [then]


  [ifdef] RCC_RCC_PLL4FRACR_DEF
    \
    \ @brief This register is used to fine-tune the frequency of the PLL4 VCO.
    \ Address offset: 0x8A0
    \ Reset value: 0x00000000
    \
    $03 constant RCC_FRACV                      \ [0x03 : 13] FRACV
    $10 constant RCC_FRACLE                     \ [0x10] FRACLE
  [then]


  [ifdef] RCC_RCC_PLL4CSGR_DEF
    \
    \ @brief This register is used to configure the PLL4.It is not recommended to change the content of this register when the PLL4 is enabled (PLLON = ). Refer to Section: Using the PLLs in spread spectrum mode for details. If TZEN = MCKPROT = , this register can only be modified in secure mode.
    \ Address offset: 0x8A4
    \ Reset value: 0x00000000
    \
    $00 constant RCC_MOD_PER                    \ [0x00 : 13] MOD_PER
    $0d constant RCC_TPDFN_DIS                  \ [0x0d] TPDFN_DIS
    $0e constant RCC_RPDFN_DIS                  \ [0x0e] RPDFN_DIS
    $0f constant RCC_SSCG_MODE                  \ [0x0f] SSCG_MODE
    $10 constant RCC_INC_STEP                   \ [0x10 : 15] INC_STEP
  [then]


  [ifdef] RCC_RCC_I2C12CKSELR_DEF
    \
    \ @brief This register is used to control the selection of the kernel clock for the I2C1 and I2C2. Note that changing the clock source on-the-fly is allowed, and will not generate any timing violation, however the user has to ensure that both the previous and the new clock sources are present during the switching, and for the whole transition time. Refer to Section: Clock enabling delays.
    \ Address offset: 0x8C0
    \ Reset value: 0x00000000
    \
    $00 constant RCC_I2C12SRC                   \ [0x00 : 3] I2C12SRC
  [then]


  [ifdef] RCC_RCC_I2C35CKSELR_DEF
    \
    \ @brief This register is used to control the selection of the kernel clock for the I2C3 and I2C5. Note that changing the clock source on-the-fly is allowed, and will not generate any timing violation, however the user has to ensure that both the previous and the new clock sources are present during the switching, and for the whole transition time. Refer to Section: Clock enabling delays.
    \ Address offset: 0x8C4
    \ Reset value: 0x00000000
    \
    $00 constant RCC_I2C35SRC                   \ [0x00 : 3] I2C35SRC
  [then]


  [ifdef] RCC_RCC_SAI1CKSELR_DEF
    \
    \ @brief This register is used to control the selection of the kernel clock for the SAI1 and DFSDM audio clock. Note that changing the clock source on-the-fly is allowed, and will not generate any timing violation, however the user has to ensure that both the previous and the new clock sources are present during the switching, and for the whole transition time. Refer to Section: Clock enabling delays.
    \ Address offset: 0x8C8
    \ Reset value: 0x00000000
    \
    $00 constant RCC_SAI1SRC                    \ [0x00 : 3] SAI1SRC
  [then]


  [ifdef] RCC_RCC_SAI2CKSELR_DEF
    \
    \ @brief This register is used to control the selection of the kernel clock for the SAI2. Note that changing the clock source on-the-fly is allowed, and will not generate any timing violation, however the user has to ensure that both the previous and the new clock sources are present during the switching, and for the whole transition time. Refer to Section: Clock enabling delays.
    \ Address offset: 0x8CC
    \ Reset value: 0x00000000
    \
    $00 constant RCC_SAI2SRC                    \ [0x00 : 3] SAI2SRC
  [then]


  [ifdef] RCC_RCC_SAI3CKSELR_DEF
    \
    \ @brief This register is used to control the selection of the kernel clock for the SAI3. Note that changing the clock source on-the-fly is allowed, and will not generate any timing violation, however the user has to ensure that both the previous and the new clock sources are present during the switching, and for the whole transition time. Refer to Section: Clock enabling delays.
    \ Address offset: 0x8D0
    \ Reset value: 0x00000000
    \
    $00 constant RCC_SAI3SRC                    \ [0x00 : 3] SAI3SRC
  [then]


  [ifdef] RCC_RCC_SAI4CKSELR_DEF
    \
    \ @brief This register is used to control the selection of the kernel clock for the SAI4. Note that changing the clock source on-the-fly is allowed, and will not generate any timing violation, however the user has to ensure that both the previous and the new clock sources are present during the switching, and for the whole transition time. Refer to Section: Clock enabling delays.
    \ Address offset: 0x8D4
    \ Reset value: 0x00000000
    \
    $00 constant RCC_SAI4SRC                    \ [0x00 : 3] SAI4SRC
  [then]


  [ifdef] RCC_RCC_SPI2S1CKSELR_DEF
    \
    \ @brief This register is used to control the selection of the kernel clock for the SPI/I2S1. Note that changing the clock source on-the-fly is allowed, and will not generate any timing violation, however the user has to ensure that both the previous and the new clock sources are present during the switching, and for the whole transition time. Refer to Section: Clock enabling delays.
    \ Address offset: 0x8D8
    \ Reset value: 0x00000000
    \
    $00 constant RCC_SPI1SRC                    \ [0x00 : 3] SPI1SRC
  [then]


  [ifdef] RCC_RCC_SPI2S23CKSELR_DEF
    \
    \ @brief This register is used to control the selection of the kernel clock for the SPI/I2S2,3. Note that changing the clock source on-the-fly is allowed, and will not generate any timing violation, however the user has to ensure that both the previous and the new clock sources are present during the switching, and for the whole transition time. Refer to Section: Clock enabling delays.
    \ Address offset: 0x8DC
    \ Reset value: 0x00000000
    \
    $00 constant RCC_SPI23SRC                   \ [0x00 : 3] SPI23SRC
  [then]


  [ifdef] RCC_RCC_SPI45CKSELR_DEF
    \
    \ @brief This register is used to control the selection of the kernel clock for the SPI4,5. Note that changing the clock source on-the-fly is allowed, and will not generate any timing violation, however the user has to ensure that both the previous and the new clock sources are present during the switching, and for the whole transition time. Refer to Section: Clock enabling delays.
    \ Address offset: 0x8E0
    \ Reset value: 0x00000000
    \
    $00 constant RCC_SPI45SRC                   \ [0x00 : 3] SPI45SRC
  [then]


  [ifdef] RCC_RCC_UART6CKSELR_DEF
    \
    \ @brief This register is used to control the selection of the kernel clock for the USART6. Note that changing the clock source on-the-fly is allowed, and will not generate any timing violation, however the user has to ensure that both the previous and the new clock sources are present during the switching, and for the whole transition time. Refer to Section: Clock enabling delays.
    \ Address offset: 0x8E4
    \ Reset value: 0x00000000
    \
    $00 constant RCC_UART6SRC                   \ [0x00 : 3] UART6SRC
  [then]


  [ifdef] RCC_RCC_UART24CKSELR_DEF
    \
    \ @brief This register is used to control the selection of the kernel clock for the USART2 and UART4. Note that changing the clock source on-the-fly is allowed, and will not generate any timing violation, however the user has to ensure that both the previous and the new clock sources are present during the switching, and for the whole transition time. Refer to Section: Clock enabling delays.
    \ Address offset: 0x8E8
    \ Reset value: 0x00000000
    \
    $00 constant RCC_UART24SRC                  \ [0x00 : 3] UART24SRC
  [then]


  [ifdef] RCC_RCC_UART35CKSELR_DEF
    \
    \ @brief This register is used to control the selection of the kernel clock for the USART3 and UART5. Note that changing the clock source on-the-fly is allowed, and will not generate any timing violation, however the user has to ensure that both the previous and the new clock sources are present during the switching, and for the whole transition time. Refer to Section: Clock enabling delays.
    \ Address offset: 0x8EC
    \ Reset value: 0x00000000
    \
    $00 constant RCC_UART35SRC                  \ [0x00 : 3] UART35SRC
  [then]


  [ifdef] RCC_RCC_UART78CKSELR_DEF
    \
    \ @brief This register is used to control the selection of the kernel clock for the UART7 and UART8. Note that changing the clock source on-the-fly is allowed, and will not generate any timing violation, however the user has to ensure that both the previous and the new clock sources are present during the switching, and for the whole transition time. Refer to Section: Clock enabling delays.
    \ Address offset: 0x8F0
    \ Reset value: 0x00000000
    \
    $00 constant RCC_UART78SRC                  \ [0x00 : 3] UART78SRC
  [then]


  [ifdef] RCC_RCC_SDMMC12CKSELR_DEF
    \
    \ @brief This register is used to control the selection of the kernel clock for the SDMMC1 and SDMMC2. Note that changing the clock source on-the-fly is allowed, and will not generate any timing violation, however the user has to ensure that both the previous and the new clock sources are present during the switching, and for the whole transition time. Refer to Section: Clock enabling delays.
    \ Address offset: 0x8F4
    \ Reset value: 0x00000003
    \
    $00 constant RCC_SDMMC12SRC                 \ [0x00 : 3] SDMMC12SRC
  [then]


  [ifdef] RCC_RCC_SDMMC3CKSELR_DEF
    \
    \ @brief This register is used to control the selection of the kernel clock for the SDMMC3. Note that changing the clock source on-the-fly is allowed, and will not generate any timing violation, however the user has to ensure that both the previous and the new clock sources are present during the switching, and for the whole transition time. Refer to Section: Clock enabling delays.
    \ Address offset: 0x8F8
    \ Reset value: 0x00000000
    \
    $00 constant RCC_SDMMC3SRC                  \ [0x00 : 3] SDMMC3SRC
  [then]


  [ifdef] RCC_RCC_ETHCKSELR_DEF
    \
    \ @brief This register is used to control the selection of the kernel clock for the ETH block. Note that changing the clock source on-the-fly is allowed, and will not generate any timing violation, however the user has to ensure that both the previous and the new clock sources are present during the switching, and for the whole transition time. Refer to Section: Clock enabling delays.
    \ Address offset: 0x8FC
    \ Reset value: 0x00000000
    \
    $00 constant RCC_ETHSRC                     \ [0x00 : 2] ETHSRC
    $04 constant RCC_ETHPTPDIV                  \ [0x04 : 4] ETHPTPDIV
  [then]


  [ifdef] RCC_RCC_QSPICKSELR_DEF
    \
    \ @brief This register is used to control the selection of the kernel clock for the QUADSPI. Note that changing the clock source on-the-fly is allowed, and will not generate any timing violation, however the user has to ensure that both the previous and the new clock sources are present during the switching, and for the whole transition time. Refer to Section: Clock enabling delays.
    \ Address offset: 0x900
    \ Reset value: 0x00000000
    \
    $00 constant RCC_QSPISRC                    \ [0x00 : 2] QSPISRC
  [then]


  [ifdef] RCC_RCC_FMCCKSELR_DEF
    \
    \ @brief This register is used to control the selection of the kernel clock for the FMC block. Note that changing the clock source on-the-fly is allowed, and will not generate any timing violation, however the user has to ensure that both the previous and the new clock sources are present during the switching, and for the whole transition time. Refer to Section: Clock enabling delays.
    \ Address offset: 0x904
    \ Reset value: 0x00000000
    \
    $00 constant RCC_FMCSRC                     \ [0x00 : 2] FMCSRC
  [then]


  [ifdef] RCC_RCC_FDCANCKSELR_DEF
    \
    \ @brief This register is used to control the selection of the kernel clock for the FDCAN block. Note that changing the clock source on-the-fly is allowed, and will not generate any timing violation, however the user has to ensure that both the previous and the new clock sources are present during the switching, and for the whole transition time. Refer to Section: Clock enabling delays.
    \ Address offset: 0x90C
    \ Reset value: 0x00000000
    \
    $00 constant RCC_FDCANSRC                   \ [0x00 : 2] FDCANSRC
  [then]


  [ifdef] RCC_RCC_SPDIFCKSELR_DEF
    \
    \ @brief This register is used to control the selection of the kernel clock for the SPDIFRX. Note that changing the clock source on-the-fly is allowed, and will not generate any timing violation, however the user has to ensure that both the previous and the new clock sources are present during the switching, and for the whole transition time. Refer to Section: Clock enabling delays.
    \ Address offset: 0x914
    \ Reset value: 0x00000000
    \
    $00 constant RCC_SPDIFSRC                   \ [0x00 : 2] SPDIFSRC
  [then]


  [ifdef] RCC_RCC_CECCKSELR_DEF
    \
    \ @brief This register is used to control the selection of the kernel clock for the CEC-HDMI.
    \ Address offset: 0x918
    \ Reset value: 0x00000000
    \
    $00 constant RCC_CECSRC                     \ [0x00 : 2] CECSRC
  [then]


  [ifdef] RCC_RCC_USBCKSELR_DEF
    \
    \ @brief This register is used to control the selection of the kernel clock for the USBPHY PLL of the USB HOST and USB OTG
    \ Address offset: 0x91C
    \ Reset value: 0x00000000
    \
    $00 constant RCC_USBPHYSRC                  \ [0x00 : 2] USBPHYSRC
    $04 constant RCC_USBOSRC                    \ [0x04] USBOSRC
  [then]


  [ifdef] RCC_RCC_RNG2CKSELR_DEF
    \
    \ @brief This register is used to control the selection of the kernel clock for the RNG2.
    \ Address offset: 0x920
    \ Reset value: 0x00000000
    \
    $00 constant RCC_RNG2SRC                    \ [0x00 : 2] RNG2SRC
  [then]


  [ifdef] RCC_RCC_DSICKSELR_DEF
    \
    \ @brief This register is used to control the selection of the kernel clock for the DSI block.
    \ Address offset: 0x924
    \ Reset value: 0x00000000
    \
    $00 constant RCC_DSISRC                     \ [0x00] DSISRC
  [then]


  [ifdef] RCC_RCC_ADCCKSELR_DEF
    \
    \ @brief This register is used to control the selection of the kernel clock for the ADC block.
    \ Address offset: 0x928
    \ Reset value: 0x00000000
    \
    $00 constant RCC_ADCSRC                     \ [0x00 : 2] ADCSRC
  [then]


  [ifdef] RCC_RCC_LPTIM45CKSELR_DEF
    \
    \ @brief This register is used to control the selection of the kernel clock for the LPTIM4 and LPTIM5 blocks.
    \ Address offset: 0x92C
    \ Reset value: 0x00000000
    \
    $00 constant RCC_LPTIM45SRC                 \ [0x00 : 3] LPTIM45SRC
  [then]


  [ifdef] RCC_RCC_LPTIM23CKSELR_DEF
    \
    \ @brief This register is used to control the selection of the kernel clock for the LPTIM2 and LPTIM3 blocks.
    \ Address offset: 0x930
    \ Reset value: 0x00000000
    \
    $00 constant RCC_LPTIM23SRC                 \ [0x00 : 3] LPTIM23SRC
  [then]


  [ifdef] RCC_RCC_LPTIM1CKSELR_DEF
    \
    \ @brief This register is used to control the selection of the kernel clock for the LPTIM1 block.
    \ Address offset: 0x934
    \ Reset value: 0x00000000
    \
    $00 constant RCC_LPTIM1SRC                  \ [0x00 : 3] LPTIM1SRC
  [then]


  [ifdef] RCC_RCC_APB1RSTSETR_DEF
    \
    \ @brief This register is used to activate the reset of the corresponding peripheral.
    \ Address offset: 0x980
    \ Reset value: 0x00000000
    \
    $00 constant RCC_TIM2RST                    \ [0x00] TIM2RST
    $01 constant RCC_TIM3RST                    \ [0x01] TIM3RST
    $02 constant RCC_TIM4RST                    \ [0x02] TIM4RST
    $03 constant RCC_TIM5RST                    \ [0x03] TIM5RST
    $04 constant RCC_TIM6RST                    \ [0x04] TIM6RST
    $05 constant RCC_TIM7RST                    \ [0x05] TIM7RST
    $06 constant RCC_TIM12RST                   \ [0x06] TIM12RST
    $07 constant RCC_TIM13RST                   \ [0x07] TIM13RST
    $08 constant RCC_TIM14RST                   \ [0x08] TIM14RST
    $09 constant RCC_LPTIM1RST                  \ [0x09] LPTIM1RST
    $0b constant RCC_SPI2RST                    \ [0x0b] SPI2RST
    $0c constant RCC_SPI3RST                    \ [0x0c] SPI3RST
    $0e constant RCC_USART2RST                  \ [0x0e] USART2RST
    $0f constant RCC_USART3RST                  \ [0x0f] USART3RST
    $10 constant RCC_UART4RST                   \ [0x10] UART4RST
    $11 constant RCC_UART5RST                   \ [0x11] UART5RST
    $12 constant RCC_UART7RST                   \ [0x12] UART7RST
    $13 constant RCC_UART8RST                   \ [0x13] UART8RST
    $15 constant RCC_I2C1RST                    \ [0x15] I2C1RST
    $16 constant RCC_I2C2RST                    \ [0x16] I2C2RST
    $17 constant RCC_I2C3RST                    \ [0x17] I2C3RST
    $18 constant RCC_I2C5RST                    \ [0x18] I2C5RST
    $1a constant RCC_SPDIFRST                   \ [0x1a] SPDIFRST
    $1b constant RCC_CECRST                     \ [0x1b] CECRST
    $1d constant RCC_DAC12RST                   \ [0x1d] DAC12RST
    $1f constant RCC_MDIOSRST                   \ [0x1f] MDIOSRST
  [then]


  [ifdef] RCC_RCC_APB1RSTCLRR_DEF
    \
    \ @brief This register is used to release the reset of the corresponding peripheral.
    \ Address offset: 0x984
    \ Reset value: 0x00000000
    \
    $00 constant RCC_TIM2RST                    \ [0x00] TIM2RST
    $01 constant RCC_TIM3RST                    \ [0x01] TIM3RST
    $02 constant RCC_TIM4RST                    \ [0x02] TIM4RST
    $03 constant RCC_TIM5RST                    \ [0x03] TIM5RST
    $04 constant RCC_TIM6RST                    \ [0x04] TIM6RST
    $05 constant RCC_TIM7RST                    \ [0x05] TIM7RST
    $06 constant RCC_TIM12RST                   \ [0x06] TIM12RST
    $07 constant RCC_TIM13RST                   \ [0x07] TIM13RST
    $08 constant RCC_TIM14RST                   \ [0x08] TIM14RST
    $09 constant RCC_LPTIM1RST                  \ [0x09] LPTIM1RST
    $0b constant RCC_SPI2RST                    \ [0x0b] SPI2RST
    $0c constant RCC_SPI3RST                    \ [0x0c] SPI3RST
    $0e constant RCC_USART2RST                  \ [0x0e] USART2RST
    $0f constant RCC_USART3RST                  \ [0x0f] USART3RST
    $10 constant RCC_UART4RST                   \ [0x10] UART4RST
    $11 constant RCC_UART5RST                   \ [0x11] UART5RST
    $12 constant RCC_UART7RST                   \ [0x12] UART7RST
    $13 constant RCC_UART8RST                   \ [0x13] UART8RST
    $15 constant RCC_I2C1RST                    \ [0x15] I2C1RST
    $16 constant RCC_I2C2RST                    \ [0x16] I2C2RST
    $17 constant RCC_I2C3RST                    \ [0x17] I2C3RST
    $18 constant RCC_I2C5RST                    \ [0x18] I2C5RST
    $1a constant RCC_SPDIFRST                   \ [0x1a] SPDIFRST
    $1b constant RCC_CECRST                     \ [0x1b] CECRST
    $1d constant RCC_DAC12RST                   \ [0x1d] DAC12RST
    $1f constant RCC_MDIOSRST                   \ [0x1f] MDIOSRST
  [then]


  [ifdef] RCC_RCC_APB2RSTSETR_DEF
    \
    \ @brief This register is used to activate the reset of the corresponding peripheral.
    \ Address offset: 0x988
    \ Reset value: 0x00000000
    \
    $00 constant RCC_TIM1RST                    \ [0x00] TIM1RST
    $01 constant RCC_TIM8RST                    \ [0x01] TIM8RST
    $02 constant RCC_TIM15RST                   \ [0x02] TIM15RST
    $03 constant RCC_TIM16RST                   \ [0x03] TIM16RST
    $04 constant RCC_TIM17RST                   \ [0x04] TIM17RST
    $08 constant RCC_SPI1RST                    \ [0x08] SPI1RST
    $09 constant RCC_SPI4RST                    \ [0x09] SPI4RST
    $0a constant RCC_SPI5RST                    \ [0x0a] SPI5RST
    $0d constant RCC_USART6RST                  \ [0x0d] USART6RST
    $10 constant RCC_SAI1RST                    \ [0x10] SAI1RST
    $11 constant RCC_SAI2RST                    \ [0x11] SAI2RST
    $12 constant RCC_SAI3RST                    \ [0x12] SAI3RST
    $14 constant RCC_DFSDMRST                   \ [0x14] DFSDMRST
    $18 constant RCC_FDCANRST                   \ [0x18] FDCANRST
  [then]


  [ifdef] RCC_RCC_APB2RSTCLRR_DEF
    \
    \ @brief This register is used to release the reset of the corresponding peripheral.
    \ Address offset: 0x98C
    \ Reset value: 0x00000000
    \
    $00 constant RCC_TIM1RST                    \ [0x00] TIM1RST
    $01 constant RCC_TIM8RST                    \ [0x01] TIM8RST
    $02 constant RCC_TIM15RST                   \ [0x02] TIM15RST
    $03 constant RCC_TIM16RST                   \ [0x03] TIM16RST
    $04 constant RCC_TIM17RST                   \ [0x04] TIM17RST
    $08 constant RCC_SPI1RST                    \ [0x08] SPI1RST
    $09 constant RCC_SPI4RST                    \ [0x09] SPI4RST
    $0a constant RCC_SPI5RST                    \ [0x0a] SPI5RST
    $0d constant RCC_USART6RST                  \ [0x0d] USART6RST
    $10 constant RCC_SAI1RST                    \ [0x10] SAI1RST
    $11 constant RCC_SAI2RST                    \ [0x11] SAI2RST
    $12 constant RCC_SAI3RST                    \ [0x12] SAI3RST
    $14 constant RCC_DFSDMRST                   \ [0x14] DFSDMRST
    $18 constant RCC_FDCANRST                   \ [0x18] FDCANRST
  [then]


  [ifdef] RCC_RCC_APB3RSTSETR_DEF
    \
    \ @brief This register is used to activate the reset of the corresponding peripheral.
    \ Address offset: 0x990
    \ Reset value: 0x00000000
    \
    $00 constant RCC_LPTIM2RST                  \ [0x00] LPTIM2RST
    $01 constant RCC_LPTIM3RST                  \ [0x01] LPTIM3RST
    $02 constant RCC_LPTIM4RST                  \ [0x02] LPTIM4RST
    $03 constant RCC_LPTIM5RST                  \ [0x03] LPTIM5RST
    $08 constant RCC_SAI4RST                    \ [0x08] SAI4RST
    $0b constant RCC_SYSCFGRST                  \ [0x0b] SYSCFGRST
    $0d constant RCC_VREFRST                    \ [0x0d] VREFRST
    $10 constant RCC_DTSRST                     \ [0x10] DTSRST
  [then]


  [ifdef] RCC_RCC_APB3RSTCLRR_DEF
    \
    \ @brief This register is used to release the reset of the corresponding peripheral.
    \ Address offset: 0x994
    \ Reset value: 0x00000000
    \
    $00 constant RCC_LPTIM2RST                  \ [0x00] LPTIM2RST
    $01 constant RCC_LPTIM3RST                  \ [0x01] LPTIM3RST
    $02 constant RCC_LPTIM4RST                  \ [0x02] LPTIM4RST
    $03 constant RCC_LPTIM5RST                  \ [0x03] LPTIM5RST
    $08 constant RCC_SAI4RST                    \ [0x08] SAI4RST
    $0b constant RCC_SYSCFGRST                  \ [0x0b] SYSCFGRST
    $0d constant RCC_VREFRST                    \ [0x0d] VREFRST
    $10 constant RCC_DTSRST                     \ [0x10] DTSRST
  [then]


  [ifdef] RCC_RCC_AHB2RSTSETR_DEF
    \
    \ @brief This register is used to activate the reset of the corresponding peripheral.
    \ Address offset: 0x998
    \ Reset value: 0x00000000
    \
    $00 constant RCC_DMA1RST                    \ [0x00] DMA1RST
    $01 constant RCC_DMA2RST                    \ [0x01] DMA2RST
    $02 constant RCC_DMAMUXRST                  \ [0x02] DMAMUXRST
    $05 constant RCC_ADC12RST                   \ [0x05] ADC12RST
    $08 constant RCC_USBORST                    \ [0x08] USBORST
    $10 constant RCC_SDMMC3RST                  \ [0x10] SDMMC3RST
  [then]


  [ifdef] RCC_RCC_AHB2RSTCLRR_DEF
    \
    \ @brief This register is used to release the reset of the corresponding peripheral.
    \ Address offset: 0x99C
    \ Reset value: 0x00000000
    \
    $00 constant RCC_DMA1RST                    \ [0x00] DMA1RST
    $01 constant RCC_DMA2RST                    \ [0x01] DMA2RST
    $02 constant RCC_DMAMUXRST                  \ [0x02] DMAMUXRST
    $05 constant RCC_ADC12RST                   \ [0x05] ADC12RST
    $08 constant RCC_USBORST                    \ [0x08] USBORST
    $10 constant RCC_SDMMC3RST                  \ [0x10] SDMMC3RST
  [then]


  [ifdef] RCC_RCC_AHB3RSTSETR_DEF
    \
    \ @brief This register is used to activate the reset of the corresponding peripheral.
    \ Address offset: 0x9A0
    \ Reset value: 0x00000000
    \
    $00 constant RCC_DCMIRST                    \ [0x00] DCMIRST
    $04 constant RCC_CRYP2RST                   \ [0x04] CRYP2RST
    $05 constant RCC_HASH2RST                   \ [0x05] HASH2RST
    $06 constant RCC_RNG2RST                    \ [0x06] RNG2RST
    $07 constant RCC_CRC2RST                    \ [0x07] CRC2RST
    $0b constant RCC_HSEMRST                    \ [0x0b] HSEMRST
    $0c constant RCC_IPCCRST                    \ [0x0c] IPCCRST
  [then]


  [ifdef] RCC_RCC_AHB3RSTCLRR_DEF
    \
    \ @brief This register is used to release the reset of the corresponding peripheral.
    \ Address offset: 0x9A4
    \ Reset value: 0x00000000
    \
    $00 constant RCC_DCMIRST                    \ [0x00] DCMIRST
    $04 constant RCC_CRYP2RST                   \ [0x04] CRYP2RST
    $05 constant RCC_HASH2RST                   \ [0x05] HASH2RST
    $06 constant RCC_RNG2RST                    \ [0x06] RNG2RST
    $07 constant RCC_CRC2RST                    \ [0x07] CRC2RST
    $0b constant RCC_HSEMRST                    \ [0x0b] HSEMRST
    $0c constant RCC_IPCCRST                    \ [0x0c] IPCCRST
  [then]


  [ifdef] RCC_RCC_AHB4RSTSETR_DEF
    \
    \ @brief This register is used to activate the reset of the corresponding peripheral
    \ Address offset: 0x9A8
    \ Reset value: 0x00000000
    \
    $00 constant RCC_GPIOARST                   \ [0x00] GPIOARST
    $01 constant RCC_GPIOBRST                   \ [0x01] GPIOBRST
    $02 constant RCC_GPIOCRST                   \ [0x02] GPIOCRST
    $03 constant RCC_GPIODRST                   \ [0x03] GPIODRST
    $04 constant RCC_GPIOERST                   \ [0x04] GPIOERST
    $05 constant RCC_GPIOFRST                   \ [0x05] GPIOFRST
    $06 constant RCC_GPIOGRST                   \ [0x06] GPIOGRST
    $07 constant RCC_GPIOHRST                   \ [0x07] GPIOHRST
    $08 constant RCC_GPIOIRST                   \ [0x08] GPIOIRST
    $09 constant RCC_GPIOJRST                   \ [0x09] GPIOJRST
    $0a constant RCC_GPIOKRST                   \ [0x0a] GPIOKRST
  [then]


  [ifdef] RCC_RCC_AHB4RSTCLRR_DEF
    \
    \ @brief This register is used to release the reset of the corresponding peripheral.
    \ Address offset: 0x9AC
    \ Reset value: 0x00000000
    \
    $00 constant RCC_GPIOARST                   \ [0x00] GPIOARST
    $01 constant RCC_GPIOBRST                   \ [0x01] GPIOBRST
    $02 constant RCC_GPIOCRST                   \ [0x02] GPIOCRST
    $03 constant RCC_GPIODRST                   \ [0x03] GPIODRST
    $04 constant RCC_GPIOERST                   \ [0x04] GPIOERST
    $05 constant RCC_GPIOFRST                   \ [0x05] GPIOFRST
    $06 constant RCC_GPIOGRST                   \ [0x06] GPIOGRST
    $07 constant RCC_GPIOHRST                   \ [0x07] GPIOHRST
    $08 constant RCC_GPIOIRST                   \ [0x08] GPIOIRST
    $09 constant RCC_GPIOJRST                   \ [0x09] GPIOJRST
    $0a constant RCC_GPIOKRST                   \ [0x0a] GPIOKRST
  [then]


  [ifdef] RCC_RCC_MP_APB1ENSETR_DEF
    \
    \ @brief This register is used to set the peripheral clock enable bit
    \ Address offset: 0xA00
    \ Reset value: 0x00000000
    \
    $00 constant RCC_TIM2EN                     \ [0x00] TIM2EN
    $01 constant RCC_TIM3EN                     \ [0x01] TIM3EN
    $02 constant RCC_TIM4EN                     \ [0x02] TIM4EN
    $03 constant RCC_TIM5EN                     \ [0x03] TIM5EN
    $04 constant RCC_TIM6EN                     \ [0x04] TIM6EN
    $05 constant RCC_TIM7EN                     \ [0x05] TIM7EN
    $06 constant RCC_TIM12EN                    \ [0x06] TIM12EN
    $07 constant RCC_TIM13EN                    \ [0x07] TIM13EN
    $08 constant RCC_TIM14EN                    \ [0x08] TIM14EN
    $09 constant RCC_LPTIM1EN                   \ [0x09] LPTIM1EN
    $0b constant RCC_SPI2EN                     \ [0x0b] SPI2EN
    $0c constant RCC_SPI3EN                     \ [0x0c] SPI3EN
    $0e constant RCC_USART2EN                   \ [0x0e] USART2EN
    $0f constant RCC_USART3EN                   \ [0x0f] USART3EN
    $10 constant RCC_UART4EN                    \ [0x10] UART4EN
    $11 constant RCC_UART5EN                    \ [0x11] UART5EN
    $12 constant RCC_UART7EN                    \ [0x12] UART7EN
    $13 constant RCC_UART8EN                    \ [0x13] UART8EN
    $15 constant RCC_I2C1EN                     \ [0x15] I2C1EN
    $16 constant RCC_I2C2EN                     \ [0x16] I2C2EN
    $17 constant RCC_I2C3EN                     \ [0x17] I2C3EN
    $18 constant RCC_I2C5EN                     \ [0x18] I2C5EN
    $1a constant RCC_SPDIFEN                    \ [0x1a] SPDIFEN
    $1b constant RCC_CECEN                      \ [0x1b] CECEN
    $1d constant RCC_DAC12EN                    \ [0x1d] DAC12EN
    $1f constant RCC_MDIOSEN                    \ [0x1f] MDIOSEN
  [then]


  [ifdef] RCC_RCC_MP_APB1ENCLRR_DEF
    \
    \ @brief This register is used to clear the peripheral clock enable bit
    \ Address offset: 0xA04
    \ Reset value: 0x00000000
    \
    $00 constant RCC_TIM2EN                     \ [0x00] TIM2EN
    $01 constant RCC_TIM3EN                     \ [0x01] TIM3EN
    $02 constant RCC_TIM4EN                     \ [0x02] TIM4EN
    $03 constant RCC_TIM5EN                     \ [0x03] TIM5EN
    $04 constant RCC_TIM6EN                     \ [0x04] TIM6EN
    $05 constant RCC_TIM7EN                     \ [0x05] TIM7EN
    $06 constant RCC_TIM12EN                    \ [0x06] TIM12EN
    $07 constant RCC_TIM13EN                    \ [0x07] TIM13EN
    $08 constant RCC_TIM14EN                    \ [0x08] TIM14EN
    $09 constant RCC_LPTIM1EN                   \ [0x09] LPTIM1EN
    $0b constant RCC_SPI2EN                     \ [0x0b] SPI2EN
    $0c constant RCC_SPI3EN                     \ [0x0c] SPI3EN
    $0e constant RCC_USART2EN                   \ [0x0e] USART2EN
    $0f constant RCC_USART3EN                   \ [0x0f] USART3EN
    $10 constant RCC_UART4EN                    \ [0x10] UART4EN
    $11 constant RCC_UART5EN                    \ [0x11] UART5EN
    $12 constant RCC_UART7EN                    \ [0x12] UART7EN
    $13 constant RCC_UART8EN                    \ [0x13] UART8EN
    $15 constant RCC_I2C1EN                     \ [0x15] I2C1EN
    $16 constant RCC_I2C2EN                     \ [0x16] I2C2EN
    $17 constant RCC_I2C3EN                     \ [0x17] I2C3EN
    $18 constant RCC_I2C5EN                     \ [0x18] I2C5EN
    $1a constant RCC_SPDIFEN                    \ [0x1a] SPDIFEN
    $1b constant RCC_CECEN                      \ [0x1b] CECEN
    $1d constant RCC_DAC12EN                    \ [0x1d] DAC12EN
    $1f constant RCC_MDIOSEN                    \ [0x1f] MDIOSEN
  [then]


  [ifdef] RCC_RCC_MP_APB2ENSETR_DEF
    \
    \ @brief This register is used to set the peripheral clock enable bit
    \ Address offset: 0xA08
    \ Reset value: 0x00000000
    \
    $00 constant RCC_TIM1EN                     \ [0x00] TIM1EN
    $01 constant RCC_TIM8EN                     \ [0x01] TIM8EN
    $02 constant RCC_TIM15EN                    \ [0x02] TIM15EN
    $03 constant RCC_TIM16EN                    \ [0x03] TIM16EN
    $04 constant RCC_TIM17EN                    \ [0x04] TIM17EN
    $08 constant RCC_SPI1EN                     \ [0x08] SPI1EN
    $09 constant RCC_SPI4EN                     \ [0x09] SPI4EN
    $0a constant RCC_SPI5EN                     \ [0x0a] SPI5EN
    $0d constant RCC_USART6EN                   \ [0x0d] USART6EN
    $10 constant RCC_SAI1EN                     \ [0x10] SAI1EN
    $11 constant RCC_SAI2EN                     \ [0x11] SAI2EN
    $12 constant RCC_SAI3EN                     \ [0x12] SAI3EN
    $14 constant RCC_DFSDMEN                    \ [0x14] DFSDMEN
    $15 constant RCC_ADFSDMEN                   \ [0x15] ADFSDMEN
    $18 constant RCC_FDCANEN                    \ [0x18] FDCANEN
  [then]


  [ifdef] RCC_RCC_MP_APB2ENCLRR_DEF
    \
    \ @brief This register is used to clear the peripheral clock enable bit of the corresponding peripheral.
    \ Address offset: 0xA0C
    \ Reset value: 0x00000000
    \
    $00 constant RCC_TIM1EN                     \ [0x00] TIM1EN
    $01 constant RCC_TIM8EN                     \ [0x01] TIM8EN
    $02 constant RCC_TIM15EN                    \ [0x02] TIM15EN
    $03 constant RCC_TIM16EN                    \ [0x03] TIM16EN
    $04 constant RCC_TIM17EN                    \ [0x04] TIM17EN
    $08 constant RCC_SPI1EN                     \ [0x08] SPI1EN
    $09 constant RCC_SPI4EN                     \ [0x09] SPI4EN
    $0a constant RCC_SPI5EN                     \ [0x0a] SPI5EN
    $0d constant RCC_USART6EN                   \ [0x0d] USART6EN
    $10 constant RCC_SAI1EN                     \ [0x10] SAI1EN
    $11 constant RCC_SAI2EN                     \ [0x11] SAI2EN
    $12 constant RCC_SAI3EN                     \ [0x12] SAI3EN
    $14 constant RCC_DFSDMEN                    \ [0x14] DFSDMEN
    $15 constant RCC_ADFSDMEN                   \ [0x15] ADFSDMEN
    $18 constant RCC_FDCANEN                    \ [0x18] FDCANEN
  [then]


  [ifdef] RCC_RCC_MP_APB3ENSETR_DEF
    \
    \ @brief This register is used to set the peripheral clock enable bit
    \ Address offset: 0xA10
    \ Reset value: 0x00000000
    \
    $00 constant RCC_LPTIM2EN                   \ [0x00] LPTIM2EN
    $01 constant RCC_LPTIM3EN                   \ [0x01] LPTIM3EN
    $02 constant RCC_LPTIM4EN                   \ [0x02] LPTIM4EN
    $03 constant RCC_LPTIM5EN                   \ [0x03] LPTIM5EN
    $08 constant RCC_SAI4EN                     \ [0x08] SAI4EN
    $0b constant RCC_SYSCFGEN                   \ [0x0b] SYSCFGEN
    $0d constant RCC_VREFEN                     \ [0x0d] VREFEN
    $10 constant RCC_DTSEN                      \ [0x10] DTSEN
    $14 constant RCC_HDPEN                      \ [0x14] HDPEN
  [then]


  [ifdef] RCC_RCC_MP_APB3ENCLRR_DEF
    \
    \ @brief This register is used to clear the peripheral clock enable bit of the corresponding peripheral.
    \ Address offset: 0xA14
    \ Reset value: 0x00000000
    \
    $00 constant RCC_LPTIM2EN                   \ [0x00] LPTIM2EN
    $01 constant RCC_LPTIM3EN                   \ [0x01] LPTIM3EN
    $02 constant RCC_LPTIM4EN                   \ [0x02] LPTIM4EN
    $03 constant RCC_LPTIM5EN                   \ [0x03] LPTIM5EN
    $08 constant RCC_SAI4EN                     \ [0x08] SAI4EN
    $0b constant RCC_SYSCFGEN                   \ [0x0b] SYSCFGEN
    $0d constant RCC_VREFEN                     \ [0x0d] VREFEN
    $10 constant RCC_DTSEN                      \ [0x10] DTSEN
    $14 constant RCC_HDPEN                      \ [0x14] HDPEN
  [then]


  [ifdef] RCC_RCC_MP_AHB2ENSETR_DEF
    \
    \ @brief This register is used to set the peripheral clock enable bit of the corresponding peripheral
    \ Address offset: 0xA18
    \ Reset value: 0x00000000
    \
    $00 constant RCC_DMA1EN                     \ [0x00] DMA1EN
    $01 constant RCC_DMA2EN                     \ [0x01] DMA2EN
    $02 constant RCC_DMAMUXEN                   \ [0x02] DMAMUXEN
    $05 constant RCC_ADC12EN                    \ [0x05] ADC12EN
    $08 constant RCC_USBOEN                     \ [0x08] USBOEN
    $10 constant RCC_SDMMC3EN                   \ [0x10] SDMMC3EN
  [then]


  [ifdef] RCC_RCC_MP_AHB2ENCLRR_DEF
    \
    \ @brief This register is used to clear the peripheral clock enable bit of the corresponding peripheral.
    \ Address offset: 0xA1C
    \ Reset value: 0x00000000
    \
    $00 constant RCC_DMA1EN                     \ [0x00] DMA1EN
    $01 constant RCC_DMA2EN                     \ [0x01] DMA2EN
    $02 constant RCC_DMAMUXEN                   \ [0x02] DMAMUXEN
    $05 constant RCC_ADC12EN                    \ [0x05] ADC12EN
    $08 constant RCC_USBOEN                     \ [0x08] USBOEN
    $10 constant RCC_SDMMC3EN                   \ [0x10] SDMMC3EN
  [then]


  [ifdef] RCC_RCC_MP_AHB3ENSETR_DEF
    \
    \ @brief This register is used to set the peripheral clock enable bit of the corresponding peripheral
    \ Address offset: 0xA20
    \ Reset value: 0x00000000
    \
    $00 constant RCC_DCMIEN                     \ [0x00] DCMIEN
    $04 constant RCC_CRYP2EN                    \ [0x04] CRYP2EN
    $05 constant RCC_HASH2EN                    \ [0x05] HASH2EN
    $06 constant RCC_RNG2EN                     \ [0x06] RNG2EN
    $07 constant RCC_CRC2EN                     \ [0x07] CRC2EN
    $0b constant RCC_HSEMEN                     \ [0x0b] HSEMEN
    $0c constant RCC_IPCCEN                     \ [0x0c] IPCCEN
  [then]


  [ifdef] RCC_RCC_MP_AHB3ENCLRR_DEF
    \
    \ @brief This register is used to clear the peripheral clock enable bit of the corresponding peripheral.
    \ Address offset: 0xA24
    \ Reset value: 0x00000000
    \
    $00 constant RCC_DCMIEN                     \ [0x00] DCMIEN
    $04 constant RCC_CRYP2EN                    \ [0x04] CRYP2EN
    $05 constant RCC_HASH2EN                    \ [0x05] HASH2EN
    $06 constant RCC_RNG2EN                     \ [0x06] RNG2EN
    $07 constant RCC_CRC2EN                     \ [0x07] CRC2EN
    $0b constant RCC_HSEMEN                     \ [0x0b] HSEMEN
    $0c constant RCC_IPCCEN                     \ [0x0c] IPCCEN
  [then]


  [ifdef] RCC_RCC_MP_AHB4ENSETR_DEF
    \
    \ @brief This register is used to set the peripheral clock enable bit of the corresponding peripheral to . It shall be used to allocate a peripheral to the MPU.
    \ Address offset: 0xA28
    \ Reset value: 0x00000000
    \
    $00 constant RCC_GPIOAEN                    \ [0x00] GPIOAEN
    $01 constant RCC_GPIOBEN                    \ [0x01] GPIOBEN
    $02 constant RCC_GPIOCEN                    \ [0x02] GPIOCEN
    $03 constant RCC_GPIODEN                    \ [0x03] GPIODEN
    $04 constant RCC_GPIOEEN                    \ [0x04] GPIOEEN
    $05 constant RCC_GPIOFEN                    \ [0x05] GPIOFEN
    $06 constant RCC_GPIOGEN                    \ [0x06] GPIOGEN
    $07 constant RCC_GPIOHEN                    \ [0x07] GPIOHEN
    $08 constant RCC_GPIOIEN                    \ [0x08] GPIOIEN
    $09 constant RCC_GPIOJEN                    \ [0x09] GPIOJEN
    $0a constant RCC_GPIOKEN                    \ [0x0a] GPIOKEN
  [then]


  [ifdef] RCC_RCC_MP_AHB4ENCLRR_DEF
    \
    \ @brief This register is used to clear the peripheral clock enable bit
    \ Address offset: 0xA2C
    \ Reset value: 0x00000000
    \
    $00 constant RCC_GPIOAEN                    \ [0x00] GPIOAEN
    $01 constant RCC_GPIOBEN                    \ [0x01] GPIOBEN
    $02 constant RCC_GPIOCEN                    \ [0x02] GPIOCEN
    $03 constant RCC_GPIODEN                    \ [0x03] GPIODEN
    $04 constant RCC_GPIOEEN                    \ [0x04] GPIOEEN
    $05 constant RCC_GPIOFEN                    \ [0x05] GPIOFEN
    $06 constant RCC_GPIOGEN                    \ [0x06] GPIOGEN
    $07 constant RCC_GPIOHEN                    \ [0x07] GPIOHEN
    $08 constant RCC_GPIOIEN                    \ [0x08] GPIOIEN
    $09 constant RCC_GPIOJEN                    \ [0x09] GPIOJEN
    $0a constant RCC_GPIOKEN                    \ [0x0a] GPIOKEN
  [then]


  [ifdef] RCC_RCC_MP_MLAHBENSETR_DEF
    \
    \ @brief This register is used to set the peripheral clock enable bit
    \ Address offset: 0xA38
    \ Reset value: 0x00000010
    \
    $04 constant RCC_RETRAMEN                   \ [0x04] RETRAMEN
  [then]


  [ifdef] RCC_RCC_MP_MLAHBENCLRR_DEF
    \
    \ @brief This register is used to clear the peripheral clock enable bit.
    \ Address offset: 0xA3C
    \ Reset value: 0x00000010
    \
    $04 constant RCC_RETRAMEN                   \ [0x04] RETRAMEN
  [then]


  [ifdef] RCC_RCC_MC_APB1ENSETR_DEF
    \
    \ @brief This register is used to set the peripheral clock enable bit of the corresponding peripheral to . It shall be used to allocate a peripheral to the MCU. Writing has no effect, reading will return . Writing a sets the corresponding bit to .
    \ Address offset: 0xA80
    \ Reset value: 0x00000000
    \
    $00 constant RCC_TIM2EN                     \ [0x00] TIM2EN
    $01 constant RCC_TIM3EN                     \ [0x01] TIM3EN
    $02 constant RCC_TIM4EN                     \ [0x02] TIM4EN
    $03 constant RCC_TIM5EN                     \ [0x03] TIM5EN
    $04 constant RCC_TIM6EN                     \ [0x04] TIM6EN
    $05 constant RCC_TIM7EN                     \ [0x05] TIM7EN
    $06 constant RCC_TIM12EN                    \ [0x06] TIM12EN
    $07 constant RCC_TIM13EN                    \ [0x07] TIM13EN
    $08 constant RCC_TIM14EN                    \ [0x08] TIM14EN
    $09 constant RCC_LPTIM1EN                   \ [0x09] LPTIM1EN
    $0b constant RCC_SPI2EN                     \ [0x0b] SPI2EN
    $0c constant RCC_SPI3EN                     \ [0x0c] SPI3EN
    $0e constant RCC_USART2EN                   \ [0x0e] USART2EN
    $0f constant RCC_USART3EN                   \ [0x0f] USART3EN
    $10 constant RCC_UART4EN                    \ [0x10] UART4EN
    $11 constant RCC_UART5EN                    \ [0x11] UART5EN
    $12 constant RCC_UART7EN                    \ [0x12] UART7EN
    $13 constant RCC_UART8EN                    \ [0x13] UART8EN
    $15 constant RCC_I2C1EN                     \ [0x15] I2C1EN
    $16 constant RCC_I2C2EN                     \ [0x16] I2C2EN
    $17 constant RCC_I2C3EN                     \ [0x17] I2C3EN
    $18 constant RCC_I2C5EN                     \ [0x18] I2C5EN
    $1a constant RCC_SPDIFEN                    \ [0x1a] SPDIFEN
    $1b constant RCC_CECEN                      \ [0x1b] CECEN
    $1c constant RCC_WWDG1EN                    \ [0x1c] WWDG1EN
    $1d constant RCC_DAC12EN                    \ [0x1d] DAC12EN
    $1f constant RCC_MDIOSEN                    \ [0x1f] MDIOSEN
  [then]


  [ifdef] RCC_RCC_MC_APB1ENCLRR_DEF
    \
    \ @brief This register is used to clear the peripheral clock enable bit of the corresponding peripheral.
    \ Address offset: 0xA84
    \ Reset value: 0x00000000
    \
    $00 constant RCC_TIM2EN                     \ [0x00] TIM2EN
    $01 constant RCC_TIM3EN                     \ [0x01] TIM3EN
    $02 constant RCC_TIM4EN                     \ [0x02] TIM4EN
    $03 constant RCC_TIM5EN                     \ [0x03] TIM5EN
    $04 constant RCC_TIM6EN                     \ [0x04] TIM6EN
    $05 constant RCC_TIM7EN                     \ [0x05] TIM7EN
    $06 constant RCC_TIM12EN                    \ [0x06] TIM12EN
    $07 constant RCC_TIM13EN                    \ [0x07] TIM13EN
    $08 constant RCC_TIM14EN                    \ [0x08] TIM14EN
    $09 constant RCC_LPTIM1EN                   \ [0x09] LPTIM1EN
    $0b constant RCC_SPI2EN                     \ [0x0b] SPI2EN
    $0c constant RCC_SPI3EN                     \ [0x0c] SPI3EN
    $0e constant RCC_USART2EN                   \ [0x0e] USART2EN
    $0f constant RCC_USART3EN                   \ [0x0f] USART3EN
    $10 constant RCC_UART4EN                    \ [0x10] UART4EN
    $11 constant RCC_UART5EN                    \ [0x11] UART5EN
    $12 constant RCC_UART7EN                    \ [0x12] UART7EN
    $13 constant RCC_UART8EN                    \ [0x13] UART8EN
    $15 constant RCC_I2C1EN                     \ [0x15] I2C1EN
    $16 constant RCC_I2C2EN                     \ [0x16] I2C2EN
    $17 constant RCC_I2C3EN                     \ [0x17] I2C3EN
    $18 constant RCC_I2C5EN                     \ [0x18] I2C5EN
    $1a constant RCC_SPDIFEN                    \ [0x1a] SPDIFEN
    $1b constant RCC_CECEN                      \ [0x1b] CECEN
    $1d constant RCC_DAC12EN                    \ [0x1d] DAC12EN
    $1f constant RCC_MDIOSEN                    \ [0x1f] MDIOSEN
  [then]


  [ifdef] RCC_RCC_MC_APB2ENSETR_DEF
    \
    \ @brief This register is used to set the peripheral clock enable bit
    \ Address offset: 0xA88
    \ Reset value: 0x00000000
    \
    $00 constant RCC_TIM1EN                     \ [0x00] TIM1EN
    $01 constant RCC_TIM8EN                     \ [0x01] TIM8EN
    $02 constant RCC_TIM15EN                    \ [0x02] TIM15EN
    $03 constant RCC_TIM16EN                    \ [0x03] TIM16EN
    $04 constant RCC_TIM17EN                    \ [0x04] TIM17EN
    $08 constant RCC_SPI1EN                     \ [0x08] SPI1EN
    $09 constant RCC_SPI4EN                     \ [0x09] SPI4EN
    $0a constant RCC_SPI5EN                     \ [0x0a] SPI5EN
    $0d constant RCC_USART6EN                   \ [0x0d] USART6EN
    $10 constant RCC_SAI1EN                     \ [0x10] SAI1EN
    $11 constant RCC_SAI2EN                     \ [0x11] SAI2EN
    $12 constant RCC_SAI3EN                     \ [0x12] SAI3EN
    $14 constant RCC_DFSDMEN                    \ [0x14] DFSDMEN
    $15 constant RCC_ADFSDMEN                   \ [0x15] ADFSDMEN
    $18 constant RCC_FDCANEN                    \ [0x18] FDCANEN
  [then]


  [ifdef] RCC_RCC_MC_APB2ENCLRR_DEF
    \
    \ @brief This register is used to clear the peripheral clock enable bit
    \ Address offset: 0xA8C
    \ Reset value: 0x00000000
    \
    $00 constant RCC_TIM1EN                     \ [0x00] TIM1EN
    $01 constant RCC_TIM8EN                     \ [0x01] TIM8EN
    $02 constant RCC_TIM15EN                    \ [0x02] TIM15EN
    $03 constant RCC_TIM16EN                    \ [0x03] TIM16EN
    $04 constant RCC_TIM17EN                    \ [0x04] TIM17EN
    $08 constant RCC_SPI1EN                     \ [0x08] SPI1EN
    $09 constant RCC_SPI4EN                     \ [0x09] SPI4EN
    $0a constant RCC_SPI5EN                     \ [0x0a] SPI5EN
    $0d constant RCC_USART6EN                   \ [0x0d] USART6EN
    $10 constant RCC_SAI1EN                     \ [0x10] SAI1EN
    $11 constant RCC_SAI2EN                     \ [0x11] SAI2EN
    $12 constant RCC_SAI3EN                     \ [0x12] SAI3EN
    $14 constant RCC_DFSDMEN                    \ [0x14] DFSDMEN
    $15 constant RCC_ADFSDMEN                   \ [0x15] ADFSDMEN
    $18 constant RCC_FDCANEN                    \ [0x18] FDCANEN
  [then]


  [ifdef] RCC_RCC_MC_APB3ENSETR_DEF
    \
    \ @brief This register is used to set the peripheral clock enable bit
    \ Address offset: 0xA90
    \ Reset value: 0x00000000
    \
    $00 constant RCC_LPTIM2EN                   \ [0x00] LPTIM2EN
    $01 constant RCC_LPTIM3EN                   \ [0x01] LPTIM3EN
    $02 constant RCC_LPTIM4EN                   \ [0x02] LPTIM4EN
    $03 constant RCC_LPTIM5EN                   \ [0x03] LPTIM5EN
    $08 constant RCC_SAI4EN                     \ [0x08] SAI4EN
    $0b constant RCC_SYSCFGEN                   \ [0x0b] SYSCFGEN
    $0d constant RCC_VREFEN                     \ [0x0d] VREFEN
    $10 constant RCC_DTSEN                      \ [0x10] DTSEN
    $14 constant RCC_HDPEN                      \ [0x14] HDPEN
  [then]


  [ifdef] RCC_RCC_MC_APB3ENCLRR_DEF
    \
    \ @brief This register is used to clear the peripheral clock enable bit
    \ Address offset: 0xA94
    \ Reset value: 0x00000000
    \
    $00 constant RCC_LPTIM2EN                   \ [0x00] LPTIM2EN
    $01 constant RCC_LPTIM3EN                   \ [0x01] LPTIM3EN
    $02 constant RCC_LPTIM4EN                   \ [0x02] LPTIM4EN
    $03 constant RCC_LPTIM5EN                   \ [0x03] LPTIM5EN
    $08 constant RCC_SAI4EN                     \ [0x08] SAI4EN
    $0b constant RCC_SYSCFGEN                   \ [0x0b] SYSCFGEN
    $0d constant RCC_VREFEN                     \ [0x0d] VREFEN
    $10 constant RCC_DTSEN                      \ [0x10] DTSEN
    $14 constant RCC_HDPEN                      \ [0x14] HDPEN
  [then]


  [ifdef] RCC_RCC_MC_AHB2ENSETR_DEF
    \
    \ @brief This register is used to set the peripheral clock enable bit
    \ Address offset: 0xA98
    \ Reset value: 0x00000000
    \
    $00 constant RCC_DMA1EN                     \ [0x00] DMA1EN
    $01 constant RCC_DMA2EN                     \ [0x01] DMA2EN
    $02 constant RCC_DMAMUXEN                   \ [0x02] DMAMUXEN
    $05 constant RCC_ADC12EN                    \ [0x05] ADC12EN
    $08 constant RCC_USBOEN                     \ [0x08] USBOEN
    $10 constant RCC_SDMMC3EN                   \ [0x10] SDMMC3EN
  [then]


  [ifdef] RCC_RCC_MC_AHB2ENCLRR_DEF
    \
    \ @brief This register is used to clear the peripheral clock enable bit
    \ Address offset: 0xA9C
    \ Reset value: 0x00000000
    \
    $00 constant RCC_DMA1EN                     \ [0x00] DMA1EN
    $01 constant RCC_DMA2EN                     \ [0x01] DMA2EN
    $02 constant RCC_DMAMUXEN                   \ [0x02] DMAMUXEN
    $05 constant RCC_ADC12EN                    \ [0x05] ADC12EN
    $08 constant RCC_USBOEN                     \ [0x08] USBOEN
    $10 constant RCC_SDMMC3EN                   \ [0x10] SDMMC3EN
  [then]


  [ifdef] RCC_RCC_MC_AHB3ENSETR_DEF
    \
    \ @brief This register is used to set the peripheral clock enable bit
    \ Address offset: 0xAA0
    \ Reset value: 0x00000000
    \
    $00 constant RCC_DCMIEN                     \ [0x00] DCMIEN
    $04 constant RCC_CRYP2EN                    \ [0x04] CRYP2EN
    $05 constant RCC_HASH2EN                    \ [0x05] HASH2EN
    $06 constant RCC_RNG2EN                     \ [0x06] RNG2EN
    $07 constant RCC_CRC2EN                     \ [0x07] CRC2EN
    $0b constant RCC_HSEMEN                     \ [0x0b] HSEMEN
    $0c constant RCC_IPCCEN                     \ [0x0c] IPCCEN
  [then]


  [ifdef] RCC_RCC_MC_AHB3ENCLRR_DEF
    \
    \ @brief This register is used to clear the peripheral clock enable bit
    \ Address offset: 0xAA4
    \ Reset value: 0x00000000
    \
    $00 constant RCC_DCMIEN                     \ [0x00] DCMIEN
    $04 constant RCC_CRYP2EN                    \ [0x04] CRYP2EN
    $05 constant RCC_HASH2EN                    \ [0x05] HASH2EN
    $06 constant RCC_RNG2EN                     \ [0x06] RNG2EN
    $07 constant RCC_CRC2EN                     \ [0x07] CRC2EN
    $0b constant RCC_HSEMEN                     \ [0x0b] HSEMEN
    $0c constant RCC_IPCCEN                     \ [0x0c] IPCCEN
  [then]


  [ifdef] RCC_RCC_MC_AHB4ENSETR_DEF
    \
    \ @brief This register is used to set the peripheral clock enable bit
    \ Address offset: 0xAA8
    \ Reset value: 0x00000000
    \
    $00 constant RCC_GPIOAEN                    \ [0x00] GPIOAEN
    $01 constant RCC_GPIOBEN                    \ [0x01] GPIOBEN
    $02 constant RCC_GPIOCEN                    \ [0x02] GPIOCEN
    $03 constant RCC_GPIODEN                    \ [0x03] GPIODEN
    $04 constant RCC_GPIOEEN                    \ [0x04] GPIOEEN
    $05 constant RCC_GPIOFEN                    \ [0x05] GPIOFEN
    $06 constant RCC_GPIOGEN                    \ [0x06] GPIOGEN
    $07 constant RCC_GPIOHEN                    \ [0x07] GPIOHEN
    $08 constant RCC_GPIOIEN                    \ [0x08] GPIOIEN
    $09 constant RCC_GPIOJEN                    \ [0x09] GPIOJEN
    $0a constant RCC_GPIOKEN                    \ [0x0a] GPIOKEN
  [then]


  [ifdef] RCC_RCC_MC_AHB4ENCLRR_DEF
    \
    \ @brief This register is used to clear the peripheral clock enable bit
    \ Address offset: 0xAAC
    \ Reset value: 0x00000000
    \
    $00 constant RCC_GPIOAEN                    \ [0x00] GPIOAEN
    $01 constant RCC_GPIOBEN                    \ [0x01] GPIOBEN
    $02 constant RCC_GPIOCEN                    \ [0x02] GPIOCEN
    $03 constant RCC_GPIODEN                    \ [0x03] GPIODEN
    $04 constant RCC_GPIOEEN                    \ [0x04] GPIOEEN
    $05 constant RCC_GPIOFEN                    \ [0x05] GPIOFEN
    $06 constant RCC_GPIOGEN                    \ [0x06] GPIOGEN
    $07 constant RCC_GPIOHEN                    \ [0x07] GPIOHEN
    $08 constant RCC_GPIOIEN                    \ [0x08] GPIOIEN
    $09 constant RCC_GPIOJEN                    \ [0x09] GPIOJEN
    $0a constant RCC_GPIOKEN                    \ [0x0a] GPIOKEN
  [then]


  [ifdef] RCC_RCC_MC_AXIMENSETR_DEF
    \
    \ @brief This register is used to set the peripheral clock enable bit
    \ Address offset: 0xAB0
    \ Reset value: 0x00000000
    \
    $00 constant RCC_SYSRAMEN                   \ [0x00] SYSRAMEN
  [then]


  [ifdef] RCC_RCC_MC_AXIMENCLRR_DEF
    \
    \ @brief This register is used to clear the peripheral clock enable bit
    \ Address offset: 0xAB4
    \ Reset value: 0x00000000
    \
    $00 constant RCC_SYSRAMEN                   \ [0x00] SYSRAMEN
  [then]


  [ifdef] RCC_RCC_MC_MLAHBENSETR_DEF
    \
    \ @brief This register is used to set the peripheral clock enable bit
    \ Address offset: 0xAB8
    \ Reset value: 0x00000010
    \
    $04 constant RCC_RETRAMEN                   \ [0x04] RETRAMEN
  [then]


  [ifdef] RCC_RCC_MC_MLAHBENCLRR_DEF
    \
    \ @brief This register is used to clear the peripheral clock enable bit
    \ Address offset: 0xABC
    \ Reset value: 0x00000010
    \
    $04 constant RCC_RETRAMEN                   \ [0x04] RETRAMEN
  [then]


  [ifdef] RCC_RCC_MP_APB1LPENSETR_DEF
    \
    \ @brief This register is used by the MCU in order to clear the PERxLPEN bits
    \ Address offset: 0xB00
    \ Reset value: 0xADEFDBFF
    \
    $00 constant RCC_TIM2LPEN                   \ [0x00] TIM2LPEN
    $01 constant RCC_TIM3LPEN                   \ [0x01] TIM3LPEN
    $02 constant RCC_TIM4LPEN                   \ [0x02] TIM4LPEN
    $03 constant RCC_TIM5LPEN                   \ [0x03] TIM5LPEN
    $04 constant RCC_TIM6LPEN                   \ [0x04] TIM6LPEN
    $05 constant RCC_TIM7LPEN                   \ [0x05] TIM7LPEN
    $06 constant RCC_TIM12LPEN                  \ [0x06] TIM12LPEN
    $07 constant RCC_TIM13LPEN                  \ [0x07] TIM13LPEN
    $08 constant RCC_TIM14LPEN                  \ [0x08] TIM14LPEN
    $09 constant RCC_LPTIM1LPEN                 \ [0x09] LPTIM1LPEN
    $0b constant RCC_SPI2LPEN                   \ [0x0b] SPI2LPEN
    $0c constant RCC_SPI3LPEN                   \ [0x0c] SPI3LPEN
    $0e constant RCC_USART2LPEN                 \ [0x0e] USART2LPEN
    $0f constant RCC_USART3LPEN                 \ [0x0f] USART3LPEN
    $10 constant RCC_UART4LPEN                  \ [0x10] UART4LPEN
    $11 constant RCC_UART5LPEN                  \ [0x11] UART5LPEN
    $12 constant RCC_UART7LPEN                  \ [0x12] UART7LPEN
    $13 constant RCC_UART8LPEN                  \ [0x13] UART8LPEN
    $15 constant RCC_I2C1LPEN                   \ [0x15] I2C1LPEN
    $16 constant RCC_I2C2LPEN                   \ [0x16] I2C2LPEN
    $17 constant RCC_I2C3LPEN                   \ [0x17] I2C3LPEN
    $18 constant RCC_I2C5LPEN                   \ [0x18] I2C5LPEN
    $1a constant RCC_SPDIFLPEN                  \ [0x1a] SPDIFLPEN
    $1b constant RCC_CECLPEN                    \ [0x1b] CECLPEN
    $1d constant RCC_DAC12LPEN                  \ [0x1d] DAC12LPEN
    $1f constant RCC_MDIOSLPEN                  \ [0x1f] MDIOSLPEN
  [then]


  [ifdef] RCC_RCC_MP_APB1LPENCLRR_DEF
    \
    \ @brief This register is used by the MPU in order to clear the PERxLPEN bits .
    \ Address offset: 0xB04
    \ Reset value: 0xADEFDBFF
    \
    $00 constant RCC_TIM2LPEN                   \ [0x00] TIM2LPEN
    $01 constant RCC_TIM3LPEN                   \ [0x01] TIM3LPEN
    $02 constant RCC_TIM4LPEN                   \ [0x02] TIM4LPEN
    $03 constant RCC_TIM5LPEN                   \ [0x03] TIM5LPEN
    $04 constant RCC_TIM6LPEN                   \ [0x04] TIM6LPEN
    $05 constant RCC_TIM7LPEN                   \ [0x05] TIM7LPEN
    $06 constant RCC_TIM12LPEN                  \ [0x06] TIM12LPEN
    $07 constant RCC_TIM13LPEN                  \ [0x07] TIM13LPEN
    $08 constant RCC_TIM14LPEN                  \ [0x08] TIM14LPEN
    $09 constant RCC_LPTIM1LPEN                 \ [0x09] LPTIM1LPEN
    $0b constant RCC_SPI2LPEN                   \ [0x0b] SPI2LPEN
    $0c constant RCC_SPI3LPEN                   \ [0x0c] SPI3LPEN
    $0e constant RCC_USART2LPEN                 \ [0x0e] USART2LPEN
    $0f constant RCC_USART3LPEN                 \ [0x0f] USART3LPEN
    $10 constant RCC_UART4LPEN                  \ [0x10] UART4LPEN
    $11 constant RCC_UART5LPEN                  \ [0x11] UART5LPEN
    $12 constant RCC_UART7LPEN                  \ [0x12] UART7LPEN
    $13 constant RCC_UART8LPEN                  \ [0x13] UART8LPEN
    $15 constant RCC_I2C1LPEN                   \ [0x15] I2C1LPEN
    $16 constant RCC_I2C2LPEN                   \ [0x16] I2C2LPEN
    $17 constant RCC_I2C3LPEN                   \ [0x17] I2C3LPEN
    $18 constant RCC_I2C5LPEN                   \ [0x18] I2C5LPEN
    $1a constant RCC_SPDIFLPEN                  \ [0x1a] SPDIFLPEN
    $1b constant RCC_CECLPEN                    \ [0x1b] CECLPEN
    $1d constant RCC_DAC12LPEN                  \ [0x1d] DAC12LPEN
    $1f constant RCC_MDIOSLPEN                  \ [0x1f] MDIOSLPEN
  [then]


  [ifdef] RCC_RCC_MP_APB2LPENSETR_DEF
    \
    \ @brief This register is used by the MCU in order to clear the PERxLPEN bits
    \ Address offset: 0xB08
    \ Reset value: 0x0137271F
    \
    $00 constant RCC_TIM1LPEN                   \ [0x00] TIM1LPEN
    $01 constant RCC_TIM8LPEN                   \ [0x01] TIM8LPEN
    $02 constant RCC_TIM15LPEN                  \ [0x02] TIM15LPEN
    $03 constant RCC_TIM16LPEN                  \ [0x03] TIM16LPEN
    $04 constant RCC_TIM17LPEN                  \ [0x04] TIM17LPEN
    $08 constant RCC_SPI1LPEN                   \ [0x08] SPI1LPEN
    $09 constant RCC_SPI4LPEN                   \ [0x09] SPI4LPEN
    $0a constant RCC_SPI5LPEN                   \ [0x0a] SPI5LPEN
    $0d constant RCC_USART6LPEN                 \ [0x0d] USART6LPEN
    $10 constant RCC_SAI1LPEN                   \ [0x10] SAI1LPEN
    $11 constant RCC_SAI2LPEN                   \ [0x11] SAI2LPEN
    $12 constant RCC_SAI3LPEN                   \ [0x12] SAI3LPEN
    $14 constant RCC_DFSDMLPEN                  \ [0x14] DFSDMLPEN
    $15 constant RCC_ADFSDMLPEN                 \ [0x15] ADFSDMLPEN
    $18 constant RCC_FDCANLPEN                  \ [0x18] FDCANLPEN
  [then]


  [ifdef] RCC_RCC_MP_APB2LPENCLRR_DEF
    \
    \ @brief This register is used by the MCU in order to clear the PERxLPEN bits
    \ Address offset: 0xB0C
    \ Reset value: 0x0137271F
    \
    $00 constant RCC_TIM1LPEN                   \ [0x00] TIM1LPEN
    $01 constant RCC_TIM8LPEN                   \ [0x01] TIM8LPEN
    $02 constant RCC_TIM15LPEN                  \ [0x02] TIM15LPEN
    $03 constant RCC_TIM16LPEN                  \ [0x03] TIM16LPEN
    $04 constant RCC_TIM17LPEN                  \ [0x04] TIM17LPEN
    $08 constant RCC_SPI1LPEN                   \ [0x08] SPI1LPEN
    $09 constant RCC_SPI4LPEN                   \ [0x09] SPI4LPEN
    $0a constant RCC_SPI5LPEN                   \ [0x0a] SPI5LPEN
    $0d constant RCC_USART6LPEN                 \ [0x0d] USART6LPEN
    $10 constant RCC_SAI1LPEN                   \ [0x10] SAI1LPEN
    $11 constant RCC_SAI2LPEN                   \ [0x11] SAI2LPEN
    $12 constant RCC_SAI3LPEN                   \ [0x12] SAI3LPEN
    $14 constant RCC_DFSDMLPEN                  \ [0x14] DFSDMLPEN
    $15 constant RCC_ADFSDMLPEN                 \ [0x15] ADFSDMLPEN
    $18 constant RCC_FDCANLPEN                  \ [0x18] FDCANLPEN
  [then]


  [ifdef] RCC_RCC_MP_APB3LPENSETR_DEF
    \
    \ @brief This register is used by the MCU in order to clear the PERxLPEN bits
    \ Address offset: 0xB10
    \ Reset value: 0x0003290F
    \
    $00 constant RCC_LPTIM2LPEN                 \ [0x00] LPTIM2LPEN
    $01 constant RCC_LPTIM3LPEN                 \ [0x01] LPTIM3LPEN
    $02 constant RCC_LPTIM4LPEN                 \ [0x02] LPTIM4LPEN
    $03 constant RCC_LPTIM5LPEN                 \ [0x03] LPTIM5LPEN
    $08 constant RCC_SAI4LPEN                   \ [0x08] SAI4LPEN
    $0b constant RCC_SYSCFGLPEN                 \ [0x0b] SYSCFGLPEN
    $0d constant RCC_VREFLPEN                   \ [0x0d] VREFLPEN
    $10 constant RCC_DTSLPEN                    \ [0x10] DTSLPEN
  [then]


  [ifdef] RCC_RCC_MP_APB3LPENCLRR_DEF
    \
    \ @brief This register is used by the MCU in order to clear the PERxLPEN bits
    \ Address offset: 0xB14
    \ Reset value: 0x0003290F
    \
    $00 constant RCC_LPTIM2LPEN                 \ [0x00] LPTIM2LPEN
    $01 constant RCC_LPTIM3LPEN                 \ [0x01] LPTIM3LPEN
    $02 constant RCC_LPTIM4LPEN                 \ [0x02] LPTIM4LPEN
    $03 constant RCC_LPTIM5LPEN                 \ [0x03] LPTIM5LPEN
    $08 constant RCC_SAI4LPEN                   \ [0x08] SAI4LPEN
    $0b constant RCC_SYSCFGLPEN                 \ [0x0b] SYSCFGLPEN
    $0d constant RCC_VREFLPEN                   \ [0x0d] VREFLPEN
    $10 constant RCC_DTSLPEN                    \ [0x10] DTSLPEN
  [then]


  [ifdef] RCC_RCC_MP_AHB2LPENSETR_DEF
    \
    \ @brief This register is used by the MPU in order to set the PERxLPEN bit.
    \ Address offset: 0xB18
    \ Reset value: 0x00010127
    \
    $00 constant RCC_DMA1LPEN                   \ [0x00] DMA1LPEN
    $01 constant RCC_DMA2LPEN                   \ [0x01] DMA2LPEN
    $02 constant RCC_DMAMUXLPEN                 \ [0x02] DMAMUXLPEN
    $05 constant RCC_ADC12LPEN                  \ [0x05] ADC12LPEN
    $08 constant RCC_USBOLPEN                   \ [0x08] USBOLPEN
    $10 constant RCC_SDMMC3LPEN                 \ [0x10] SDMMC3LPEN
  [then]


  [ifdef] RCC_RCC_MP_AHB2LPENCLRR_DEF
    \
    \ @brief This register is used by the MCU in order to clear the PERxLPEN bits
    \ Address offset: 0xB1C
    \ Reset value: 0x00010127
    \
    $00 constant RCC_DMA1LPEN                   \ [0x00] DMA1LPEN
    $01 constant RCC_DMA2LPEN                   \ [0x01] DMA2LPEN
    $02 constant RCC_DMAMUXLPEN                 \ [0x02] DMAMUXLPEN
    $05 constant RCC_ADC12LPEN                  \ [0x05] ADC12LPEN
    $08 constant RCC_USBOLPEN                   \ [0x08] USBOLPEN
    $10 constant RCC_SDMMC3LPEN                 \ [0x10] SDMMC3LPEN
  [then]


  [ifdef] RCC_RCC_MP_AHB3LPENSETR_DEF
    \
    \ @brief This register is used by the MPU
    \ Address offset: 0xB20
    \ Reset value: 0x000018F1
    \
    $00 constant RCC_DCMILPEN                   \ [0x00] DCMILPEN
    $04 constant RCC_CRYP2LPEN                  \ [0x04] CRYP2LPEN
    $05 constant RCC_HASH2LPEN                  \ [0x05] HASH2LPEN
    $06 constant RCC_RNG2LPEN                   \ [0x06] RNG2LPEN
    $07 constant RCC_CRC2LPEN                   \ [0x07] CRC2LPEN
    $0b constant RCC_HSEMLPEN                   \ [0x0b] HSEMLPEN
    $0c constant RCC_IPCCLPEN                   \ [0x0c] IPCCLPEN
  [then]


  [ifdef] RCC_RCC_MP_AHB3LPENCLRR_DEF
    \
    \ @brief This register is used by the MPU in order to clear the PERxLPEN bit
    \ Address offset: 0xB24
    \ Reset value: 0x000018F1
    \
    $00 constant RCC_DCMILPEN                   \ [0x00] DCMILPEN
    $04 constant RCC_CRYP2LPEN                  \ [0x04] CRYP2LPEN
    $05 constant RCC_HASH2LPEN                  \ [0x05] HASH2LPEN
    $06 constant RCC_RNG2LPEN                   \ [0x06] RNG2LPEN
    $07 constant RCC_CRC2LPEN                   \ [0x07] CRC2LPEN
    $0b constant RCC_HSEMLPEN                   \ [0x0b] HSEMLPEN
    $0c constant RCC_IPCCLPEN                   \ [0x0c] IPCCLPEN
  [then]


  [ifdef] RCC_RCC_MP_AHB4LPENSETR_DEF
    \
    \ @brief This register is used by the MPU
    \ Address offset: 0xB28
    \ Reset value: 0x000007FF
    \
    $00 constant RCC_GPIOALPEN                  \ [0x00] GPIOALPEN
    $01 constant RCC_GPIOBLPEN                  \ [0x01] GPIOBLPEN
    $02 constant RCC_GPIOCLPEN                  \ [0x02] GPIOCLPEN
    $03 constant RCC_GPIODLPEN                  \ [0x03] GPIODLPEN
    $04 constant RCC_GPIOELPEN                  \ [0x04] GPIOELPEN
    $05 constant RCC_GPIOFLPEN                  \ [0x05] GPIOFLPEN
    $06 constant RCC_GPIOGLPEN                  \ [0x06] GPIOGLPEN
    $07 constant RCC_GPIOHLPEN                  \ [0x07] GPIOHLPEN
    $08 constant RCC_GPIOILPEN                  \ [0x08] GPIOILPEN
    $09 constant RCC_GPIOJLPEN                  \ [0x09] GPIOJLPEN
    $0a constant RCC_GPIOKLPEN                  \ [0x0a] GPIOKLPEN
  [then]


  [ifdef] RCC_RCC_MP_AHB4LPENCLRR_DEF
    \
    \ @brief This register is used by the MPU
    \ Address offset: 0xB2C
    \ Reset value: 0x000007FF
    \
    $00 constant RCC_GPIOALPEN                  \ [0x00] GPIOALPEN
    $01 constant RCC_GPIOBLPEN                  \ [0x01] GPIOBLPEN
    $02 constant RCC_GPIOCLPEN                  \ [0x02] GPIOCLPEN
    $03 constant RCC_GPIODLPEN                  \ [0x03] GPIODLPEN
    $04 constant RCC_GPIOELPEN                  \ [0x04] GPIOELPEN
    $05 constant RCC_GPIOFLPEN                  \ [0x05] GPIOFLPEN
    $06 constant RCC_GPIOGLPEN                  \ [0x06] GPIOGLPEN
    $07 constant RCC_GPIOHLPEN                  \ [0x07] GPIOHLPEN
    $08 constant RCC_GPIOILPEN                  \ [0x08] GPIOILPEN
    $09 constant RCC_GPIOJLPEN                  \ [0x09] GPIOJLPEN
    $0a constant RCC_GPIOKLPEN                  \ [0x0a] GPIOKLPEN
  [then]


  [ifdef] RCC_RCC_MP_AXIMLPENSETR_DEF
    \
    \ @brief This register is used by the MPU
    \ Address offset: 0xB30
    \ Reset value: 0x00000001
    \
    $00 constant RCC_SYSRAMLPEN                 \ [0x00] SYSRAMLPEN
  [then]


  [ifdef] RCC_RCC_MP_AXIMLPENCLRR_DEF
    \
    \ @brief This register is used by the MPU
    \ Address offset: 0xB34
    \ Reset value: 0x00000001
    \
    $00 constant RCC_SYSRAMLPEN                 \ [0x00] SYSRAMLPEN
  [then]


  [ifdef] RCC_RCC_MP_MLAHBLPENSETR_DEF
    \
    \ @brief This register is used by the MPU in order to set the PERxLPEN bit
    \ Address offset: 0xB38
    \ Reset value: 0x00000017
    \
    $00 constant RCC_SRAM1LPEN                  \ [0x00] SRAM1LPEN
    $01 constant RCC_SRAM2LPEN                  \ [0x01] SRAM2LPEN
    $02 constant RCC_SRAM34LPEN                 \ [0x02] SRAM34LPEN
    $04 constant RCC_RETRAMLPEN                 \ [0x04] RETRAMLPEN
  [then]


  [ifdef] RCC_RCC_MP_MLAHBLPENCLRR_DEF
    \
    \ @brief This register is used by the MPU in order to clear the PERxLPEN bit
    \ Address offset: 0xB3C
    \ Reset value: 0x00000017
    \
    $00 constant RCC_SRAM1LPEN                  \ [0x00] SRAM1LPEN
    $01 constant RCC_SRAM2LPEN                  \ [0x01] SRAM2LPEN
    $02 constant RCC_SRAM34LPEN                 \ [0x02] SRAM34LPEN
    $04 constant RCC_RETRAMLPEN                 \ [0x04] RETRAMLPEN
  [then]


  [ifdef] RCC_RCC_MC_APB1LPENSETR_DEF
    \
    \ @brief This register is used by the MCU in order to set the PERxLPEN bit.
    \ Address offset: 0xB80
    \ Reset value: 0xBDEFDBFF
    \
    $00 constant RCC_TIM2LPEN                   \ [0x00] TIM2LPEN
    $01 constant RCC_TIM3LPEN                   \ [0x01] TIM3LPEN
    $02 constant RCC_TIM4LPEN                   \ [0x02] TIM4LPEN
    $03 constant RCC_TIM5LPEN                   \ [0x03] TIM5LPEN
    $04 constant RCC_TIM6LPEN                   \ [0x04] TIM6LPEN
    $05 constant RCC_TIM7LPEN                   \ [0x05] TIM7LPEN
    $06 constant RCC_TIM12LPEN                  \ [0x06] TIM12LPEN
    $07 constant RCC_TIM13LPEN                  \ [0x07] TIM13LPEN
    $08 constant RCC_TIM14LPEN                  \ [0x08] TIM14LPEN
    $09 constant RCC_LPTIM1LPEN                 \ [0x09] LPTIM1LPEN
    $0b constant RCC_SPI2LPEN                   \ [0x0b] SPI2LPEN
    $0c constant RCC_SPI3LPEN                   \ [0x0c] SPI3LPEN
    $0e constant RCC_USART2LPEN                 \ [0x0e] USART2LPEN
    $0f constant RCC_USART3LPEN                 \ [0x0f] USART3LPEN
    $10 constant RCC_UART4LPEN                  \ [0x10] UART4LPEN
    $11 constant RCC_UART5LPEN                  \ [0x11] UART5LPEN
    $12 constant RCC_UART7LPEN                  \ [0x12] UART7LPEN
    $13 constant RCC_UART8LPEN                  \ [0x13] UART8LPEN
    $15 constant RCC_I2C1LPEN                   \ [0x15] I2C1LPEN
    $16 constant RCC_I2C2LPEN                   \ [0x16] I2C2LPEN
    $17 constant RCC_I2C3LPEN                   \ [0x17] I2C3LPEN
    $18 constant RCC_I2C5LPEN                   \ [0x18] I2C5LPEN
    $1a constant RCC_SPDIFLPEN                  \ [0x1a] SPDIFLPEN
    $1b constant RCC_CECLPEN                    \ [0x1b] CECLPEN
    $1c constant RCC_WWDG1LPEN                  \ [0x1c] WWDG1LPEN
    $1d constant RCC_DAC12LPEN                  \ [0x1d] DAC12LPEN
    $1f constant RCC_MDIOSLPEN                  \ [0x1f] MDIOSLPEN
  [then]


  [ifdef] RCC_RCC_MC_APB1LPENCLRR_DEF
    \
    \ @brief This register is used by the MCU in order to clear the PERxLPEN bits
    \ Address offset: 0xB84
    \ Reset value: 0xBDEFDBFF
    \
    $00 constant RCC_TIM2LPEN                   \ [0x00] TIM2LPEN
    $01 constant RCC_TIM3LPEN                   \ [0x01] TIM3LPEN
    $02 constant RCC_TIM4LPEN                   \ [0x02] TIM4LPEN
    $03 constant RCC_TIM5LPEN                   \ [0x03] TIM5LPEN
    $04 constant RCC_TIM6LPEN                   \ [0x04] TIM6LPEN
    $05 constant RCC_TIM7LPEN                   \ [0x05] TIM7LPEN
    $06 constant RCC_TIM12LPEN                  \ [0x06] TIM12LPEN
    $07 constant RCC_TIM13LPEN                  \ [0x07] TIM13LPEN
    $08 constant RCC_TIM14LPEN                  \ [0x08] TIM14LPEN
    $09 constant RCC_LPTIM1LPEN                 \ [0x09] LPTIM1LPEN
    $0b constant RCC_SPI2LPEN                   \ [0x0b] SPI2LPEN
    $0c constant RCC_SPI3LPEN                   \ [0x0c] SPI3LPEN
    $0e constant RCC_USART2LPEN                 \ [0x0e] USART2LPEN
    $0f constant RCC_USART3LPEN                 \ [0x0f] USART3LPEN
    $10 constant RCC_UART4LPEN                  \ [0x10] UART4LPEN
    $11 constant RCC_UART5LPEN                  \ [0x11] UART5LPEN
    $12 constant RCC_UART7LPEN                  \ [0x12] UART7LPEN
    $13 constant RCC_UART8LPEN                  \ [0x13] UART8LPEN
    $15 constant RCC_I2C1LPEN                   \ [0x15] I2C1LPEN
    $16 constant RCC_I2C2LPEN                   \ [0x16] I2C2LPEN
    $17 constant RCC_I2C3LPEN                   \ [0x17] I2C3LPEN
    $18 constant RCC_I2C5LPEN                   \ [0x18] I2C5LPEN
    $1a constant RCC_SPDIFLPEN                  \ [0x1a] SPDIFLPEN
    $1b constant RCC_CECLPEN                    \ [0x1b] CECLPEN
    $1c constant RCC_WWDG1LPEN                  \ [0x1c] WWDG1LPEN
    $1d constant RCC_DAC12LPEN                  \ [0x1d] DAC12LPEN
    $1f constant RCC_MDIOSLPEN                  \ [0x1f] MDIOSLPEN
  [then]


  [ifdef] RCC_RCC_MC_APB2LPENSETR_DEF
    \
    \ @brief This register is used by the MCU in order to set the PERxLPEN bit.
    \ Address offset: 0xB88
    \ Reset value: 0x0137271F
    \
    $00 constant RCC_TIM1LPEN                   \ [0x00] TIM1LPEN
    $01 constant RCC_TIM8LPEN                   \ [0x01] TIM8LPEN
    $02 constant RCC_TIM15LPEN                  \ [0x02] TIM15LPEN
    $03 constant RCC_TIM16LPEN                  \ [0x03] TIM16LPEN
    $04 constant RCC_TIM17LPEN                  \ [0x04] TIM17LPEN
    $08 constant RCC_SPI1LPEN                   \ [0x08] SPI1LPEN
    $09 constant RCC_SPI4LPEN                   \ [0x09] SPI4LPEN
    $0a constant RCC_SPI5LPEN                   \ [0x0a] SPI5LPEN
    $0d constant RCC_USART6LPEN                 \ [0x0d] USART6LPEN
    $10 constant RCC_SAI1LPEN                   \ [0x10] SAI1LPEN
    $11 constant RCC_SAI2LPEN                   \ [0x11] SAI2LPEN
    $12 constant RCC_SAI3LPEN                   \ [0x12] SAI3LPEN
    $14 constant RCC_DFSDMLPEN                  \ [0x14] DFSDMLPEN
    $15 constant RCC_ADFSDMLPEN                 \ [0x15] ADFSDMLPEN
    $18 constant RCC_FDCANLPEN                  \ [0x18] FDCANLPEN
  [then]


  [ifdef] RCC_RCC_MC_APB2LPENCLRR_DEF
    \
    \ @brief This register is used by the MCU in order to clear the PERxLPEN bit
    \ Address offset: 0xB8C
    \ Reset value: 0x0137271F
    \
    $00 constant RCC_TIM1LPEN                   \ [0x00] TIM1LPEN
    $01 constant RCC_TIM8LPEN                   \ [0x01] TIM8LPEN
    $02 constant RCC_TIM15LPEN                  \ [0x02] TIM15LPEN
    $03 constant RCC_TIM16LPEN                  \ [0x03] TIM16LPEN
    $04 constant RCC_TIM17LPEN                  \ [0x04] TIM17LPEN
    $08 constant RCC_SPI1LPEN                   \ [0x08] SPI1LPEN
    $09 constant RCC_SPI4LPEN                   \ [0x09] SPI4LPEN
    $0a constant RCC_SPI5LPEN                   \ [0x0a] SPI5LPEN
    $0d constant RCC_USART6LPEN                 \ [0x0d] USART6LPEN
    $10 constant RCC_SAI1LPEN                   \ [0x10] SAI1LPEN
    $11 constant RCC_SAI2LPEN                   \ [0x11] SAI2LPEN
    $12 constant RCC_SAI3LPEN                   \ [0x12] SAI3LPEN
    $14 constant RCC_DFSDMLPEN                  \ [0x14] DFSDMLPEN
    $15 constant RCC_ADFSDMLPEN                 \ [0x15] ADFSDMLPEN
    $18 constant RCC_FDCANLPEN                  \ [0x18] FDCANLPEN
  [then]


  [ifdef] RCC_RCC_MC_APB3LPENSETR_DEF
    \
    \ @brief This register is used by the MCU in order to set the PERxLPEN bit.
    \ Address offset: 0xB90
    \ Reset value: 0x0003290F
    \
    $00 constant RCC_LPTIM2LPEN                 \ [0x00] LPTIM2LPEN
    $01 constant RCC_LPTIM3LPEN                 \ [0x01] LPTIM3LPEN
    $02 constant RCC_LPTIM4LPEN                 \ [0x02] LPTIM4LPEN
    $03 constant RCC_LPTIM5LPEN                 \ [0x03] LPTIM5LPEN
    $08 constant RCC_SAI4LPEN                   \ [0x08] SAI4LPEN
    $0b constant RCC_SYSCFGLPEN                 \ [0x0b] SYSCFGLPEN
    $0d constant RCC_VREFLPEN                   \ [0x0d] VREFLPEN
    $10 constant RCC_DTSLPEN                    \ [0x10] DTSLPEN
  [then]


  [ifdef] RCC_RCC_MC_APB3LPENCLRR_DEF
    \
    \ @brief This register is used by the MCU in order to clear the PERxLPEN bit
    \ Address offset: 0xB94
    \ Reset value: 0x0003290F
    \
    $00 constant RCC_LPTIM2LPEN                 \ [0x00] LPTIM2LPEN
    $01 constant RCC_LPTIM3LPEN                 \ [0x01] LPTIM3LPEN
    $02 constant RCC_LPTIM4LPEN                 \ [0x02] LPTIM4LPEN
    $03 constant RCC_LPTIM5LPEN                 \ [0x03] LPTIM5LPEN
    $08 constant RCC_SAI4LPEN                   \ [0x08] SAI4LPEN
    $0b constant RCC_SYSCFGLPEN                 \ [0x0b] SYSCFGLPEN
    $0d constant RCC_VREFLPEN                   \ [0x0d] VREFLPEN
    $10 constant RCC_DTSLPEN                    \ [0x10] DTSLPEN
  [then]


  [ifdef] RCC_RCC_MC_AHB2LPENSETR_DEF
    \
    \ @brief This register is used by the MCU in order to set the PERxLPEN bit.
    \ Address offset: 0xB98
    \ Reset value: 0x00010127
    \
    $00 constant RCC_DMA1LPEN                   \ [0x00] DMA1LPEN
    $01 constant RCC_DMA2LPEN                   \ [0x01] DMA2LPEN
    $02 constant RCC_DMAMUXLPEN                 \ [0x02] DMAMUXLPEN
    $05 constant RCC_ADC12LPEN                  \ [0x05] ADC12LPEN
    $08 constant RCC_USBOLPEN                   \ [0x08] USBOLPEN
    $10 constant RCC_SDMMC3LPEN                 \ [0x10] SDMMC3LPEN
  [then]


  [ifdef] RCC_RCC_MC_AHB2LPENCLRR_DEF
    \
    \ @brief This register is used by the MCU in order to clear the PERxLPEN bit
    \ Address offset: 0xB9C
    \ Reset value: 0x00010127
    \
    $00 constant RCC_DMA1LPEN                   \ [0x00] DMA1LPEN
    $01 constant RCC_DMA2LPEN                   \ [0x01] DMA2LPEN
    $02 constant RCC_DMAMUXLPEN                 \ [0x02] DMAMUXLPEN
    $05 constant RCC_ADC12LPEN                  \ [0x05] ADC12LPEN
    $08 constant RCC_USBOLPEN                   \ [0x08] USBOLPEN
    $10 constant RCC_SDMMC3LPEN                 \ [0x10] SDMMC3LPEN
  [then]


  [ifdef] RCC_RCC_MC_AHB3LPENSETR_DEF
    \
    \ @brief This register is used by the MCU in order to set the PERxLPEN bit.
    \ Address offset: 0xBA0
    \ Reset value: 0x000018F1
    \
    $00 constant RCC_DCMILPEN                   \ [0x00] DCMILPEN
    $04 constant RCC_CRYP2LPEN                  \ [0x04] CRYP2LPEN
    $05 constant RCC_HASH2LPEN                  \ [0x05] HASH2LPEN
    $06 constant RCC_RNG2LPEN                   \ [0x06] RNG2LPEN
    $07 constant RCC_CRC2LPEN                   \ [0x07] CRC2LPEN
    $0b constant RCC_HSEMLPEN                   \ [0x0b] HSEMLPEN
    $0c constant RCC_IPCCLPEN                   \ [0x0c] IPCCLPEN
  [then]


  [ifdef] RCC_RCC_MC_AHB3LPENCLRR_DEF
    \
    \ @brief This register is used by the MCU in order to clear the PERxLPEN bit
    \ Address offset: 0xBA4
    \ Reset value: 0x000018F1
    \
    $00 constant RCC_DCMILPEN                   \ [0x00] DCMILPEN
    $04 constant RCC_CRYP2LPEN                  \ [0x04] CRYP2LPEN
    $05 constant RCC_HASH2LPEN                  \ [0x05] HASH2LPEN
    $06 constant RCC_RNG2LPEN                   \ [0x06] RNG2LPEN
    $07 constant RCC_CRC2LPEN                   \ [0x07] CRC2LPEN
    $0b constant RCC_HSEMLPEN                   \ [0x0b] HSEMLPEN
    $0c constant RCC_IPCCLPEN                   \ [0x0c] IPCCLPEN
  [then]


  [ifdef] RCC_RCC_MC_AHB4LPENSETR_DEF
    \
    \ @brief This register is used by the MCU in order to set the PERxLPEN bit.
    \ Address offset: 0xBA8
    \ Reset value: 0x000007FF
    \
    $00 constant RCC_GPIOALPEN                  \ [0x00] GPIOALPEN
    $01 constant RCC_GPIOBLPEN                  \ [0x01] GPIOBLPEN
    $02 constant RCC_GPIOCLPEN                  \ [0x02] GPIOCLPEN
    $03 constant RCC_GPIODLPEN                  \ [0x03] GPIODLPEN
    $04 constant RCC_GPIOELPEN                  \ [0x04] GPIOELPEN
    $05 constant RCC_GPIOFLPEN                  \ [0x05] GPIOFLPEN
    $06 constant RCC_GPIOGLPEN                  \ [0x06] GPIOGLPEN
    $07 constant RCC_GPIOHLPEN                  \ [0x07] GPIOHLPEN
    $08 constant RCC_GPIOILPEN                  \ [0x08] GPIOILPEN
    $09 constant RCC_GPIOJLPEN                  \ [0x09] GPIOJLPEN
    $0a constant RCC_GPIOKLPEN                  \ [0x0a] GPIOKLPEN
  [then]


  [ifdef] RCC_RCC_MC_AHB4LPENCLRR_DEF
    \
    \ @brief This register is used by the MCU in order to clear the PERxLPEN bit of the corresponding peripheral.
    \ Address offset: 0xBAC
    \ Reset value: 0x000007FF
    \
    $00 constant RCC_GPIOALPEN                  \ [0x00] GPIOALPEN
    $01 constant RCC_GPIOBLPEN                  \ [0x01] GPIOBLPEN
    $02 constant RCC_GPIOCLPEN                  \ [0x02] GPIOCLPEN
    $03 constant RCC_GPIODLPEN                  \ [0x03] GPIODLPEN
    $04 constant RCC_GPIOELPEN                  \ [0x04] GPIOELPEN
    $05 constant RCC_GPIOFLPEN                  \ [0x05] GPIOFLPEN
    $06 constant RCC_GPIOGLPEN                  \ [0x06] GPIOGLPEN
    $07 constant RCC_GPIOHLPEN                  \ [0x07] GPIOHLPEN
    $08 constant RCC_GPIOILPEN                  \ [0x08] GPIOILPEN
    $09 constant RCC_GPIOJLPEN                  \ [0x09] GPIOJLPEN
    $0a constant RCC_GPIOKLPEN                  \ [0x0a] GPIOKLPEN
  [then]


  [ifdef] RCC_RCC_MC_AXIMLPENSETR_DEF
    \
    \ @brief This register is used by the MCU in order to set the PERxLPEN bit of the corresponding peripheral.
    \ Address offset: 0xBB0
    \ Reset value: 0x00000001
    \
    $00 constant RCC_SYSRAMLPEN                 \ [0x00] SYSRAMLPEN
  [then]


  [ifdef] RCC_RCC_MC_AXIMLPENCLRR_DEF
    \
    \ @brief This register is used by the MCU in order to clear the PERxLPEN bit of the corresponding peripheral.
    \ Address offset: 0xBB4
    \ Reset value: 0x00000001
    \
    $00 constant RCC_SYSRAMLPEN                 \ [0x00] SYSRAMLPEN
  [then]


  [ifdef] RCC_RCC_MC_MLAHBLPENSETR_DEF
    \
    \ @brief This register is used by the MCU in order to set the PERxLPEN bit of the corresponding peripheral.
    \ Address offset: 0xBB8
    \ Reset value: 0x00000017
    \
    $00 constant RCC_SRAM1LPEN                  \ [0x00] SRAM1LPEN
    $01 constant RCC_SRAM2LPEN                  \ [0x01] SRAM2LPEN
    $02 constant RCC_SRAM34LPEN                 \ [0x02] SRAM34LPEN
    $04 constant RCC_RETRAMLPEN                 \ [0x04] RETRAMLPEN
  [then]


  [ifdef] RCC_RCC_MC_MLAHBLPENCLRR_DEF
    \
    \ @brief This register is used by the MCU in order to clear the PERxLPEN bit of the corresponding peripheral.
    \ Address offset: 0xBBC
    \ Reset value: 0x00000017
    \
    $00 constant RCC_SRAM1LPEN                  \ [0x00] SRAM1LPEN
    $01 constant RCC_SRAM2LPEN                  \ [0x01] SRAM2LPEN
    $02 constant RCC_SRAM34LPEN                 \ [0x02] SRAM34LPEN
    $04 constant RCC_RETRAMLPEN                 \ [0x04] RETRAMLPEN
  [then]


  [ifdef] RCC_RCC_MC_RSTSCLRR_DEF
    \
    \ @brief This register is used by the MCU to check the reset source.
    \ Address offset: 0xC00
    \ Reset value: 0x00000015
    \
    $00 constant RCC_PORRSTF                    \ [0x00] PORRSTF
    $01 constant RCC_BORRSTF                    \ [0x01] BORRSTF
    $02 constant RCC_PADRSTF                    \ [0x02] PADRSTF
    $03 constant RCC_HCSSRSTF                   \ [0x03] HCSSRSTF
    $04 constant RCC_VCORERSTF                  \ [0x04] VCORERSTF
    $05 constant RCC_MCURSTF                    \ [0x05] MCURSTF
    $06 constant RCC_MPSYSRSTF                  \ [0x06] MPSYSRSTF
    $07 constant RCC_MCSYSRSTF                  \ [0x07] MCSYSRSTF
    $08 constant RCC_IWDG1RSTF                  \ [0x08] IWDG1RSTF
    $09 constant RCC_IWDG2RSTF                  \ [0x09] IWDG2RSTF
    $0a constant RCC_WWDG1RSTF                  \ [0x0a] WWDG1RSTF
  [then]


  [ifdef] RCC_RCC_MC_CIER_DEF
    \
    \ @brief This register shall be used by the MCU to control the interrupt source enable. Refer to Section10.5: RCC interrupts for more details.
    \ Address offset: 0xC14
    \ Reset value: 0x00000000
    \
    $00 constant RCC_LSIRDYIE                   \ [0x00] LSIRDYIE
    $01 constant RCC_LSERDYIE                   \ [0x01] LSERDYIE
    $02 constant RCC_HSIRDYIE                   \ [0x02] HSIRDYIE
    $03 constant RCC_HSERDYIE                   \ [0x03] HSERDYIE
    $04 constant RCC_CSIRDYIE                   \ [0x04] CSIRDYIE
    $08 constant RCC_PLL1DYIE                   \ [0x08] PLL1DYIE
    $09 constant RCC_PLL2DYIE                   \ [0x09] PLL2DYIE
    $0a constant RCC_PLL3DYIE                   \ [0x0a] PLL3DYIE
    $0b constant RCC_PLL4DYIE                   \ [0x0b] PLL4DYIE
    $10 constant RCC_LSECSSIE                   \ [0x10] LSECSSIE
    $14 constant RCC_WKUPIE                     \ [0x14] WKUPIE
  [then]


  [ifdef] RCC_RCC_MC_CIFR_DEF
    \
    \ @brief This register shall be used by the MCU in order to read and clear the interrupt flags.
    \ Address offset: 0xC18
    \ Reset value: 0x00000000
    \
    $00 constant RCC_LSIRDYF                    \ [0x00] LSIRDYF
    $01 constant RCC_LSERDYF                    \ [0x01] LSERDYF
    $02 constant RCC_HSIRDYF                    \ [0x02] HSIRDYF
    $03 constant RCC_HSERDYF                    \ [0x03] HSERDYF
    $04 constant RCC_CSIRDYF                    \ [0x04] CSIRDYF
    $08 constant RCC_PLL1DYF                    \ [0x08] PLL1DYF
    $09 constant RCC_PLL2DYF                    \ [0x09] PLL2DYF
    $0a constant RCC_PLL3DYF                    \ [0x0a] PLL3DYF
    $0b constant RCC_PLL4DYF                    \ [0x0b] PLL4DYF
    $10 constant RCC_LSECSSF                    \ [0x10] LSECSSF
    $14 constant RCC_WKUPF                      \ [0x14] WKUPF
  [then]


  [ifdef] RCC_RCC_VERR_DEF
    \
    \ @brief This register gives the IP version
    \ Address offset: 0xFF4
    \ Reset value: 0x00000011
    \
    $00 constant RCC_MINREV                     \ [0x00 : 4] MINREV
    $04 constant RCC_MAJREV                     \ [0x04 : 4] MAJREV
  [then]


  [ifdef] RCC_RCC_IDR_DEF
    \
    \ @brief This register gives the unique identifier of the RCC
    \ Address offset: 0xFF8
    \ Reset value: 0x00000001
    \
    $00 constant RCC_ID                         \ [0x00 : 32] ID
  [then]


  [ifdef] RCC_RCC_SIDR_DEF
    \
    \ @brief This register gives the decoding space, which is for the RCC of 4 kB.
    \ Address offset: 0xFFC
    \ Reset value: 0xA3C5DD04
    \
    $00 constant RCC_SID                        \ [0x00 : 32] SID
  [then]

  \
  \ @brief RCC
  \
  $00 constant RCC_RCC_TZCR             \ This register is used to switch the RCC into secure mode. This register can only be accessed in secure mode.
  $0C constant RCC_RCC_OCENSETR         \ This register is used to control the oscillators.Writing to this register has no effect, writing will set the corresponding bits. Reading will give the effective values of each bit.If TZEN = MCKPROT = , this register can only be modified in secure mode. Write access to this register is not allowed during the clock restore sequence. See Section: The clock restore sequence description for details.
  $10 constant RCC_RCC_OCENCLRR         \ This register is used to control the oscillators.Writing to this register has no effect, writing will clear the corresponding bits. Reading will give the effective values of the enable bits.If TZEN = , this register can only be modified in secure mode. Write access to this register is not allowed during the clock restore sequence. See Section: The clock restore sequence description for details.
  $18 constant RCC_RCC_HSICFGR          \ This register is used to configure the HSI. If TZEN = , this register can only be modified in secure mode. Write access to this register is not allowed during the clock restore sequence. See Section: The clock restore sequence description for details.
  $1C constant RCC_RCC_CSICFGR          \ This register is used to fine-tune the CSI frequency. If TZEN = MCKPROT = , this register can only be modified in secure mode. Write access to this register is not allowed during the clock restore sequence. See The clock restore sequence description for details.
  $20 constant RCC_RCC_MPCKSELR         \ This register is used to select the clock source for the MPU. If TZEN = , this register can only be modified in secure mode. Write access to this register is not allowed during the clock restore sequence. See Section: The clock restore sequence description for details.
  $24 constant RCC_RCC_ASSCKSELR        \ This register is used to select the clock source for the AXI sub-system. If TZEN = , this register can only be modified in secure mode. Write access to this register is not allowed during the clock restore sequence. See Section: The clock restore sequence description for details.
  $28 constant RCC_RCC_RCK12SELR        \ This register is used to select the reference clock for PLL1 and PLL2. If TZEN = , this register can only be modified in secure mode. Write access to this register is not allowed during the clock restore sequence. See Section: The clock restore sequence description for details.
  $2C constant RCC_RCC_MPCKDIVR         \ This register is used to control the MPU clock prescaler. Refer to Section: Sub-system clock generation for additional information. If TZEN = , this register can only be modified in secure mode.
  $30 constant RCC_RCC_AXIDIVR          \ This register is used to control the AXI Matrix clock prescaler. Refer to Section: Sub-system clock generation for additional information. If TZEN = , this register can only be modified in secure mode.
  $3C constant RCC_RCC_APB4DIVR         \ This register is used to control the APB4 clock divider. Refer to Section: Sub-system clock generation for additional information. If TZEN = , this register can only be modified in secure mode.
  $40 constant RCC_RCC_APB5DIVR         \ This register is used to control the APB5 clock divider. Refer to Section: Sub-system clock generation for additional information. If TZEN = , this register can only be modified in secure mode.
  $44 constant RCC_RCC_RTCDIVR          \ This register is used to divide the HSE clock for RTC. If TZEN = , this register can only be modified in secure mode.
  $48 constant RCC_RCC_MSSCKSELR        \ This register is used to select the clock source for the MCU sub-system, including the MCU itself. If TZEN = MCKPROT = , this register can only be modified in secure mode. Write access to this register is not allowed during the clock restore sequence. See Section: The clock restore sequence description for details.
  $80 constant RCC_RCC_PLL1CR           \ This register is used to control the PLL1. If TZEN = , this register can only be modified in secure mode. Write access to this register is not allowed during the clock restore sequence. See Section: The clock restore sequence description for details.
  $84 constant RCC_RCC_PLL1CFGR1        \ This register is used to configure the PLL1. If TZEN = , this register can only be modified in secure mode. Write access to this register is not allowed during the clock restore sequence. See Section: The clock restore sequence description for details.
  $88 constant RCC_RCC_PLL1CFGR2        \ This register is used to configure the PLL1. If TZEN = , this register can only be modified in secure mode. Write access to this register is not allowed during the clock restore sequence. See Section: The clock restore sequence description for details.
  $8C constant RCC_RCC_PLL1FRACR        \ This register is used to fine-tune the frequency of the PLL1 VCO. If TZEN = , this register can only be modified in secure mode. Write access to this register is not allowed during the clock restore sequence. See Section: The clock restore sequence description for details.
  $90 constant RCC_RCC_PLL1CSGR         \ This register is used to configure the PLL1.It is not recommended to change the content of this register when the PLL1 is enabled (PLLON = ). Refer to Section: Using the PLLs in spread spectrum mode for details. If TZEN = , this register can only be modified in secure mode. Write access to this register is not allowed during the clock restore sequence. See Section: The clock restore sequence description for details.
  $94 constant RCC_RCC_PLL2CR           \ This register is used to control the PLL2. If TZEN = , this register can only be modified in secure mode. Write access to this register is not allowed during the clock restore sequence. See Section: The clock restore sequence description for details.
  $98 constant RCC_RCC_PLL2CFGR1        \ This register is used to configure the PLL2. If TZEN = , this register can only be modified in secure mode. Write access to this register is not allowed during the clock restore sequence. See Section: The clock restore sequence description for details.
  $9C constant RCC_RCC_PLL2CFGR2        \ This register is used to configure the PLL2. If TZEN = , this register can only be modified in secure mode. Write access to this register is not allowed during the clock restore sequence. See Section: The clock restore sequence description for details.
  $A0 constant RCC_RCC_PLL2FRACR        \ This register is used to fine-tune the frequency of the PLL2 VCO. If TZEN = , this register can only be modified in secure mode. Write access to this register is not allowed during the clock restore sequence. See Section: The clock restore sequence description for details.
  $A4 constant RCC_RCC_PLL2CSGR         \ This register is used to configure the PLL2. It is not recommended to change the content of this register when the PLL2 is enabled (PLLON = ). Refer to Section: Using the PLLs in spread spectrum mode for details. If TZEN = , this register can only be modified in secure mode. Write access to this register is not allowed during the clock restore sequence. See Section: The clock restore sequence description for details.
  $C0 constant RCC_RCC_I2C46CKSELR      \ This register is used to control the selection of the kernel clock for the I2C4 and I2C6. Note that changing the clock source on-the-fly is allowed, and will not generate any timing violation, however the user has to ensure that both the previous and the new clock sources are present during the switching, and for the whole transition time. Refer to Section: Clock enabling delays. If TZEN = , this register can only be modified in secure mode.
  $C4 constant RCC_RCC_SPI6CKSELR       \ This register is used to control the selection of the kernel clock for the SPI6. Note that changing the clock source on-the-fly is allowed, and will not generate any timing violation, however the user has to ensure that both the previous and the new clock sources are present during the switching, and for the whole transition time. Refer to Section: Clock enabling delays. If TZEN = , this register can only be modified in secure mode.
  $C8 constant RCC_RCC_UART1CKSELR      \ This register is used to control the selection of the kernel clock for the USART1. Note that changing the clock source on-the-fly is allowed, and will not generate any timing violation, however the user has to ensure that both the previous and the new clock sources are present during the switching, and for the whole transition time. Refer to Section: Clock enabling delays. If TZEN = , this register can only be modified in secure mode.
  $CC constant RCC_RCC_RNG1CKSELR       \ This register is used to control the selection of the kernel clock for the RNG1. Note that changing the clock source on-the-fly is allowed, and will not generate any timing violation, however the user has to ensure that both the previous and the new clock sources are present during the switching, and for the whole transition time. Refer to Section: Clock enabling delays. If TZEN = , this register can only be modified in secure mode.
  $D0 constant RCC_RCC_CPERCKSELR       \ This register is used to select an oscillator source as kernel clock for the per_ck clock. The per_ck clock is distributed to several peripherals. Refer to Section: Clock enabling delays.
  $D4 constant RCC_RCC_STGENCKSELR      \ This register is used to select the peripheral clock for the STGEN block. Note that this clock is used to provide a time reference for the application. Refer to Section: Clock enabling delays. If TZEN = , this register can only be modified in secure mode.
  $D8 constant RCC_RCC_DDRITFCR         \ This register is used to control the DDR interface, including the DDRC and DDRPHYC. If TZEN = , this register can only be modified in secure mode.
  $100 constant RCC_RCC_MP_BOOTCR       \ This register is used to control the HOLD boot function when the system exits from Standby. Refer to Section: MCU HOLD_BOOT after processor reset. This register is reset when a system reset occurs, but not when the circuit exits from Standby (app_rst reset).If TZEN = , this register can only be modified in secure mode. This register can only be accessed by the MPU.
  $104 constant RCC_RCC_MP_SREQSETR     \ Writing has no effect, reading will return the values of the bits. Writing a sets the corresponding bit to . The MCU cannot access to this register. If TZEN = , this register can only be modified in secure mode.
  $108 constant RCC_RCC_MP_SREQCLRR     \ Writing has no effect, reading will return the effective values of the bits. Writing a sets the corresponding bit to . The MCU cannot access to this register. If TZEN = , this register can only be modified in secure mode.
  $10C constant RCC_RCC_MP_GCR          \ The register contains global control bits. If TZEN = , this register can only be modified in secure mode.
  $110 constant RCC_RCC_MP_APRSTCR      \ This register is used to control the behavior of the warm reset. If TZEN = , this register can only be modified in secure mode.
  $114 constant RCC_RCC_MP_APRSTSR      \ This register provides a status of the RDCTL. If TZEN = , this register can only be modified in secure mode.
  $140 constant RCC_RCC_BDCR            \ This register is used to control the LSE function. Wait states are inserted in case of successive write accesses to this register. The number of wait states may be up to 7 cycles of AHB4 clock.After a system reset, the register RCC_BDCR is write-protected. In order to modify this register, the DBP bit in the PWR control register 1 (PWR_CR1) has to be set to . Bits of RCC_BDCR register are only reset after a backup domain reset: nreset_vsw (see Section10.3.6: Backup domain reset). Any other internal or external reset will not have any effect on these bits.This register is located into the VSW domain. If TZEN = , this register can only be modified in secure mode.
  $144 constant RCC_RCC_RDLSICR         \ This register is used to control the minimum NRST active duration and LSI function.0 to 7 wait states are inserted for word, half-word and byte accesses. Wait states are inserted in case of successive accesses to this register.This register is reset by the por_rst reset, and it is located into the VDD domain. If TZEN = , this register can only be modified in secure mode.
  $180 constant RCC_RCC_APB4RSTSETR     \ This register is used to activate the reset of the corresponding peripheral. Writing has no effect, reading will return the effective values of the corresponding bits. Writing a activates the reset of the corresponding peripheral.
  $184 constant RCC_RCC_APB4RSTCLRR     \ This register is used to release the reset of the corresponding peripheral. Writing has no effect, reading will return the effective values of the corresponding bits. Writing a releases the reset of the corresponding peripheral.
  $188 constant RCC_RCC_APB5RSTSETR     \ This register is used to activate the reset of the corresponding peripheral. Writing has no effect, reading will return the effective values of the corresponding bits. Writing a activates the reset of the corresponding peripheral. If TZEN = , this register can only be modified in secure mode.
  $18C constant RCC_RCC_APB5RSTCLRR     \ This register is used to release the reset of the corresponding peripheral. Writing has no effect, reading will return the effective values of the corresponding bits. Writing a releases the reset of the corresponding peripheral. If TZEN = , this register can only be modified in secure mode.
  $190 constant RCC_RCC_AHB5RSTSETR     \ This register is used to activate the reset of the corresponding peripheral. Writing has no effect, reading will return the effective values of the corresponding bits. Writing a activates the reset of the corresponding peripheral. If TZEN = , this register can only be modified in secure mode.
  $194 constant RCC_RCC_AHB5RSTCLRR     \ This register is used to release the reset of the corresponding peripheral. Writing has no effect, reading will return the effective values of the corresponding bits. Writing a releases the reset of the corresponding peripheral. If TZEN = , this register can only be modified in secure mode.
  $198 constant RCC_RCC_AHB6RSTSETR     \ This register is used to activate the reset of the corresponding peripheral. Writing has no effect, reading will return the effective values of the corresponding bits. Writing a activates the reset of the corresponding peripheral.
  $19C constant RCC_RCC_AHB6RSTCLRR     \ This register is used to release the reset of the corresponding peripheral. Writing has no effect, reading will return the effective values of the corresponding bits. Writing a releases the reset of the corresponding peripheral.
  $1A0 constant RCC_RCC_TZAHB6RSTSETR   \ This register is used to activate the reset of the corresponding peripheral. Writing has no effect, reading will return the effective values of the corresponding bits. Writing a activates the reset of the corresponding peripheral. If TZEN = , this register can only be modified in secure mode.
  $1A4 constant RCC_RCC_TZAHB6RSTCLRR   \ This register is used to release the reset of the corresponding peripheral. Writing has no effect, reading will return the effective values of the corresponding bits. Writing a releases the reset of the corresponding peripheral. If TZEN = , this register can only be modified in secure mode.
  $200 constant RCC_RCC_MP_APB4ENSETR   \ This register is used to set the peripheral clock enable bit of the corresponding peripheral to . It shall be used to allocate a peripheral to the MPU. Writing has no effect, reading will return the effective values of the corresponding bits. Writing a sets the corresponding bit to .
  $204 constant RCC_RCC_MP_APB4ENCLRR   \ This register is used to clear the peripheral clock enable bit of the corresponding peripheral. It shall be used to deallocate a peripheral from MPU. Writing has no effect, reading will return the effective values of the corresponding bits. Writing a sets the corresponding bit to .
  $208 constant RCC_RCC_MP_APB5ENSETR   \ This register is used to set the peripheral clock enable bit of the corresponding peripheral to . It shall be used to allocate a peripheral to the MPU. Writing has no effect, reading will return the effective values of the corresponding bits. Writing a sets the corresponding bit to .
  $20C constant RCC_RCC_MP_APB5ENCLRR   \ This register is used to clear the peripheral clock enable bit of the corresponding peripheral. It shall be used to deallocate a peripheral from MPU. Writing has no effect, reading will return the effective values of the corresponding bits. Writing a sets the corresponding bit to .
  $210 constant RCC_RCC_MP_AHB5ENSETR   \ This register is used to set the peripheral clock enable bit of the corresponding peripheral to . It shall be used to allocate a peripheral to the MPU. Writing has no effect, reading will return the effective values of the corresponding bits. Writing a sets the corresponding bit to . If TZEN = , this register can only be modified in secure mode.
  $214 constant RCC_RCC_MP_AHB5ENCLRR   \ This register is used to clear the peripheral clock enable bit of the corresponding peripheral. It shall be used to deallocate a peripheral from MPU. Writing has no effect, reading will return the effective values of the corresponding bits. Writing a sets the corresponding bit to . If TZEN = , this register can only be modified in secure mode.
  $218 constant RCC_RCC_MP_AHB6ENSETR   \ This register is used to set the peripheral clock enable bit of the corresponding peripheral to . It shall be used to allocate a peripheral to the MPU. Writing has no effect, reading will return the effective values of the corresponding bits. Writing a sets the corresponding bit to .
  $21C constant RCC_RCC_MP_AHB6ENCLRR   \ This register is used to clear the peripheral clock enable bit of the corresponding peripheral. It shall be used to deallocate a peripheral from MPU. Writing has no effect, reading will return the effective values of the corresponding bits. Writing a sets the corresponding bit to .
  $220 constant RCC_RCC_MP_TZAHB6ENSETR \ This register is used to set the peripheral clock enable bit of the corresponding peripheral to . It shall be used to allocate a peripheral to the MPU. Writing has no effect, reading will return the effective values of the corresponding bits. Writing a sets the corresponding bit to . If TZEN = , this register can only be modified in secure mode.
  $224 constant RCC_RCC_MP_TZAHB6ENCLRR \ This register is used to clear the peripheral clock enable bit of the corresponding peripheral. It shall be used to deallocate a peripheral from MPU. Writing has no effect, reading will return the effective values of the corresponding bits. Writing a sets the corresponding bit to . If TZEN = , this register can only be modified in secure mode.
  $280 constant RCC_RCC_MC_APB4ENSETR   \ This register is used to set the peripheral clock enable bit
  $284 constant RCC_RCC_MC_APB4ENCLRR   \ This register is used to clear the peripheral clock enable bit
  $288 constant RCC_RCC_MC_APB5ENSETR   \ This register is used to set the peripheral clock enable bit
  $28C constant RCC_RCC_MC_APB5ENCLRR   \ This register is used to clear the peripheral clock enable bit
  $290 constant RCC_RCC_MC_AHB5ENSETR   \ This register is used to set the peripheral clock enable bit If TZEN = , this register can only be modified in secure mode.
  $294 constant RCC_RCC_MC_AHB5ENCLRR   \ This register is used to clear the peripheral clock enable bit If TZEN = , this register can only be modified in secure mode.
  $298 constant RCC_RCC_MC_AHB6ENSETR   \ This register is used to set the peripheral clock enable bit
  $29C constant RCC_RCC_MC_AHB6ENCLRR   \ This register is used to clear the peripheral clock enable bit
  $300 constant RCC_RCC_MP_APB4LPENSETR \ This register is used by the MCU in order to clear the PERxLPEN bits
  $304 constant RCC_RCC_MP_APB4LPENCLRR \ This register is used by the MCU
  $308 constant RCC_RCC_MP_APB5LPENSETR \ This register is used by the MCU in order to clear the PERxLPEN bits If TZEN = , this register can only be modified in secure mode.
  $30C constant RCC_RCC_MP_APB5LPENCLRR \ This register is used by the Mpu.
  $310 constant RCC_RCC_MP_AHB5LPENSETR \ This register is used by the MCU in order to clear the PERxLPEN bits If TZEN = , this register can only be modified in secure mode.
  $314 constant RCC_RCC_MP_AHB5LPENCLRR \ This register is used by the MCU
  $318 constant RCC_RCC_MP_AHB6LPENSETR \ This register is used by the MCU in order to clear the PERxLPEN bits
  $31C constant RCC_RCC_MP_AHB6LPENCLRR \ This register is used by the MCU in order to clear the PERxLPEN bits
  $320 constant RCC_RCC_MP_TZAHB6LPENSETR    \ This register is used by the MCU in order to clear the PERxLPEN bits If TZEN = , this register can only be modified in secure mode.
  $324 constant RCC_RCC_MP_TZAHB6LPENCLRR    \ This register is used by the MCU in order to clear the PERxLPEN bits If TZEN = , this register can only be modified in secure mode.
  $380 constant RCC_RCC_MC_APB4LPENSETR \ This register is used by the MCU in order to set the PERxLPEN bit.
  $384 constant RCC_RCC_MC_APB4LPENCLRR \ This register is used by the MCU in order to clear the PERxLPEN bit
  $388 constant RCC_RCC_MC_APB5LPENSETR \ This register is used by the MCU in order to set the PERxLPEN bit.
  $38C constant RCC_RCC_MC_APB5LPENCLRR \ This register is used by the MCU in order to clear the PERxLPEN bit
  $390 constant RCC_RCC_MC_AHB5LPENSETR \ This register is used by the MCU in order to set the PERxLPEN bit. If TZEN = , this register can only be modified in secure mode.
  $394 constant RCC_RCC_MC_AHB5LPENCLRR \ This register is used by the MCU in order to clear the PERxLPEN bit If TZEN = , this register can only be modified in secure mode.
  $398 constant RCC_RCC_MC_AHB6LPENSETR \ This register is used by the MCU in order to set the PERxLPEN bit.
  $39C constant RCC_RCC_MC_AHB6LPENCLRR \ This register is used by the MCU in order to clear the PERxLPEN bit
  $400 constant RCC_RCC_BR_RSTSCLRR     \ This register is used by the BOOTROM to check the reset source. Writing has no effect, reading will return the effective values of the corresponding bits. Writing a clears the corresponding bit to . In order to identify the reset source, the MPU application must use RCC MPU Reset Status Clear Register (RCC_MP_RSTSCLRR), and the MCU application must use the RCC MCU Reset Status Clear Register (RCC_MC_RSTSCLRR). Refer to Section10.3.13: Reset source identification for details.This register except MPUP[1:0]RSTF flags is located into VDD domain, and is reset by por_rst reset. The MPUP[1:0]RSTF flags are located into VDDCORE and are reset by nreset. If TZEN = , this register can only be modified in secure mode.
  $404 constant RCC_RCC_MP_GRSTCSETR    \ This register is used by the MPU in order to generate either a MCU reset or a system reset or a reset of one of the two MPU processors. Writing has no effect, reading returns the effective values of the corresponding bits. Writing a activates the reset.
  $408 constant RCC_RCC_MP_RSTSCLRR     \ This register is used by the MPU to check the reset source. This register is updated by the BOOTROM code, after a power-on reset (por_rst), a system reset (nreset), or an exit from Standby or CStandby.Writing has no effect, reading will return the effective values of the corresponding bits. Writing a clears the corresponding bit to .Refer to Section10.3.13: Reset source identification for details.The register is located in VDDCORE.If TZEN = , this register can only be modified in secure mode.
  $40C constant RCC_RCC_MP_IWDGFZSETR   \ This register is used by the BOOTROM in order to freeze the IWDGs clocks. After a system reset or Standby reset (nreset), or a CStandby reset (cstby_rst) the MPU is allowed to write it once.Writing has no effect, reading will return the effective values of the corresponding bits. Writing a sets the corresponding bit to . If TZEN = , this register can only be modified in secure mode.
  $410 constant RCC_RCC_MP_IWDGFZCLRR   \ This register is used by the BOOTROM in order to unfreeze the IWDGs clocks. Writing has no effect, reading will return the effective values of the corresponding bits. Writing a clears the corresponding bit to . If TZEN = , this register can only be modified in secure mode.
  $414 constant RCC_RCC_MP_CIER         \ This register shall be used by the MPU to control the interrupt source enable. Refer to Section10.5: RCC interrupts for more details. If TZEN = , this register can only be modified in secure mode.
  $418 constant RCC_RCC_MP_CIFR         \ This register shall be used by the MPU in order to read and clear the interrupt flags.Writing has no effect, writing will clear the corresponding flag.Refer to Section10.5: RCC interrupts for more details. If TZEN = , this register can only be modified in secure mode.
  $41C constant RCC_RCC_PWRLPDLYCR      \ This register is used to program the delay between the moment where the system exits from one of the Stop modes, and the moment where it is allowed to enable the PLLs and provide a clock to bridges and processors. If TZEN = , this register can only be modified in secure mode.
  $420 constant RCC_RCC_MP_RSTSSETR     \ This register is dedicated to the BOOTROM code in order to update the reset source. This register is updated by the BOOTROM code, after a power-on reset (por_rst), a system reset (nreset), or an exit from Standby or CStandby. The application software shall not use this register. In order to identify the reset source, the MPU application must use RCC MPU Reset Status Clear Register (RCC_MP_RSTSCLRR), and the MCU application must use the RCC MCU Reset Status Clear Register (RCC_MC_RSTSCLRR).Writing has no effect, reading will return the effective values of the corresponding bits. Writing a sets the corresponding bit to .Refer to Section10.3.13: Reset source identification for details.The register is located in VDDCORE.If TZEN = , this register can only be modified in secure mode.
  $800 constant RCC_RCC_MCO1CFGR        \ This register is used to select the clock generated on MCO1 output.
  $804 constant RCC_RCC_MCO2CFGR        \ This register is used to select the clock generated on MCO2 output.
  $808 constant RCC_RCC_OCRDYR          \ This is a read-only access register, It contains the status flags of oscillators. Writing has no effect.
  $80C constant RCC_RCC_DBGCFGR         \ This is register contains the enable control of the debug and trace function, and the clock divider for the trace function.
  $820 constant RCC_RCC_RCK3SELR        \ This register is used to select the reference clock for PLL3. If TZEN = MCKPROT = , this register can only be modified in secure mode.
  $824 constant RCC_RCC_RCK4SELR        \ This register is used to select the reference clock for PLL4.
  $828 constant RCC_RCC_TIMG1PRER       \ This register is used to control the prescaler value of timers located into APB1 domain. It concerns TIM2, TIM3, TIM4, TIM5, TIM6, TIM7, TIM12, TIM13 and TIM14. Refer to Section: Sub-system clock generation for additional information.
  $82C constant RCC_RCC_TIMG2PRER       \ This register is used to control the prescaler value of timers located into APB2 domain. It concerns TIM1, TIM8, TIM15, TIM16, and TIM17. Refer to Section: Sub-system clock generation for additional information.
  $830 constant RCC_RCC_MCUDIVR         \ This register is used to control the MCU sub-system clock prescaler. Refer to Section: Sub-system clock generation for additional information. If TZEN = , this register can only be modified in secure mode.
  $834 constant RCC_RCC_APB1DIVR        \ This register is used to control the APB1 clock prescaler. Refer to section Section1.4.6.3: Sub-System Clock Generation for additional information.
  $838 constant RCC_RCC_APB2DIVR        \ This register is used to control the APB2 clock prescaler. Refer to Section: Sub-system clock generation for additional information.
  $83C constant RCC_RCC_APB3DIVR        \ This register is used to control the APB3 clock prescaler. Refer to Section: Sub-system clock generation for additional information.
  $880 constant RCC_RCC_PLL3CR          \ This register is used to control the PLL3. If TZEN = MCKPROT = , this register can only be modified in secure mode.
  $884 constant RCC_RCC_PLL3CFGR1       \ This register is used to configure the PLL3. If TZEN = MCKPROT = , this register can only be modified in secure mode.
  $888 constant RCC_RCC_PLL3CFGR2       \ This register is used to configure the PLL3. If TZEN = MCKPROT = , this register can only be modified in secure mode.
  $88C constant RCC_RCC_PLL3FRACR       \ This register is used to fine-tune the frequency of the PLL3 VCO. If TZEN = MCKPROT = , this register can only be modified in secure mode.
  $890 constant RCC_RCC_PLL3CSGR        \ This register is used to configure the PLL3.It is not recommended to change the content of this register when the PLL3 is enabled (PLLON = ). Refer to Section: Using the PLLs in spread spectrum mode for details. If TZEN = MCKPROT = , this register can only be modified in secure mode.
  $894 constant RCC_RCC_PLL4CR          \ This register is used to control the PLL4.
  $898 constant RCC_RCC_PLL4CFGR1       \ This register is used to configure the PLL4.
  $89C constant RCC_RCC_PLL4CFGR2       \ This register is used to configure the PLL4.
  $8A0 constant RCC_RCC_PLL4FRACR       \ This register is used to fine-tune the frequency of the PLL4 VCO.
  $8A4 constant RCC_RCC_PLL4CSGR        \ This register is used to configure the PLL4.It is not recommended to change the content of this register when the PLL4 is enabled (PLLON = ). Refer to Section: Using the PLLs in spread spectrum mode for details. If TZEN = MCKPROT = , this register can only be modified in secure mode.
  $8C0 constant RCC_RCC_I2C12CKSELR     \ This register is used to control the selection of the kernel clock for the I2C1 and I2C2. Note that changing the clock source on-the-fly is allowed, and will not generate any timing violation, however the user has to ensure that both the previous and the new clock sources are present during the switching, and for the whole transition time. Refer to Section: Clock enabling delays.
  $8C4 constant RCC_RCC_I2C35CKSELR     \ This register is used to control the selection of the kernel clock for the I2C3 and I2C5. Note that changing the clock source on-the-fly is allowed, and will not generate any timing violation, however the user has to ensure that both the previous and the new clock sources are present during the switching, and for the whole transition time. Refer to Section: Clock enabling delays.
  $8C8 constant RCC_RCC_SAI1CKSELR      \ This register is used to control the selection of the kernel clock for the SAI1 and DFSDM audio clock. Note that changing the clock source on-the-fly is allowed, and will not generate any timing violation, however the user has to ensure that both the previous and the new clock sources are present during the switching, and for the whole transition time. Refer to Section: Clock enabling delays.
  $8CC constant RCC_RCC_SAI2CKSELR      \ This register is used to control the selection of the kernel clock for the SAI2. Note that changing the clock source on-the-fly is allowed, and will not generate any timing violation, however the user has to ensure that both the previous and the new clock sources are present during the switching, and for the whole transition time. Refer to Section: Clock enabling delays.
  $8D0 constant RCC_RCC_SAI3CKSELR      \ This register is used to control the selection of the kernel clock for the SAI3. Note that changing the clock source on-the-fly is allowed, and will not generate any timing violation, however the user has to ensure that both the previous and the new clock sources are present during the switching, and for the whole transition time. Refer to Section: Clock enabling delays.
  $8D4 constant RCC_RCC_SAI4CKSELR      \ This register is used to control the selection of the kernel clock for the SAI4. Note that changing the clock source on-the-fly is allowed, and will not generate any timing violation, however the user has to ensure that both the previous and the new clock sources are present during the switching, and for the whole transition time. Refer to Section: Clock enabling delays.
  $8D8 constant RCC_RCC_SPI2S1CKSELR    \ This register is used to control the selection of the kernel clock for the SPI/I2S1. Note that changing the clock source on-the-fly is allowed, and will not generate any timing violation, however the user has to ensure that both the previous and the new clock sources are present during the switching, and for the whole transition time. Refer to Section: Clock enabling delays.
  $8DC constant RCC_RCC_SPI2S23CKSELR   \ This register is used to control the selection of the kernel clock for the SPI/I2S2,3. Note that changing the clock source on-the-fly is allowed, and will not generate any timing violation, however the user has to ensure that both the previous and the new clock sources are present during the switching, and for the whole transition time. Refer to Section: Clock enabling delays.
  $8E0 constant RCC_RCC_SPI45CKSELR     \ This register is used to control the selection of the kernel clock for the SPI4,5. Note that changing the clock source on-the-fly is allowed, and will not generate any timing violation, however the user has to ensure that both the previous and the new clock sources are present during the switching, and for the whole transition time. Refer to Section: Clock enabling delays.
  $8E4 constant RCC_RCC_UART6CKSELR     \ This register is used to control the selection of the kernel clock for the USART6. Note that changing the clock source on-the-fly is allowed, and will not generate any timing violation, however the user has to ensure that both the previous and the new clock sources are present during the switching, and for the whole transition time. Refer to Section: Clock enabling delays.
  $8E8 constant RCC_RCC_UART24CKSELR    \ This register is used to control the selection of the kernel clock for the USART2 and UART4. Note that changing the clock source on-the-fly is allowed, and will not generate any timing violation, however the user has to ensure that both the previous and the new clock sources are present during the switching, and for the whole transition time. Refer to Section: Clock enabling delays.
  $8EC constant RCC_RCC_UART35CKSELR    \ This register is used to control the selection of the kernel clock for the USART3 and UART5. Note that changing the clock source on-the-fly is allowed, and will not generate any timing violation, however the user has to ensure that both the previous and the new clock sources are present during the switching, and for the whole transition time. Refer to Section: Clock enabling delays.
  $8F0 constant RCC_RCC_UART78CKSELR    \ This register is used to control the selection of the kernel clock for the UART7 and UART8. Note that changing the clock source on-the-fly is allowed, and will not generate any timing violation, however the user has to ensure that both the previous and the new clock sources are present during the switching, and for the whole transition time. Refer to Section: Clock enabling delays.
  $8F4 constant RCC_RCC_SDMMC12CKSELR   \ This register is used to control the selection of the kernel clock for the SDMMC1 and SDMMC2. Note that changing the clock source on-the-fly is allowed, and will not generate any timing violation, however the user has to ensure that both the previous and the new clock sources are present during the switching, and for the whole transition time. Refer to Section: Clock enabling delays.
  $8F8 constant RCC_RCC_SDMMC3CKSELR    \ This register is used to control the selection of the kernel clock for the SDMMC3. Note that changing the clock source on-the-fly is allowed, and will not generate any timing violation, however the user has to ensure that both the previous and the new clock sources are present during the switching, and for the whole transition time. Refer to Section: Clock enabling delays.
  $8FC constant RCC_RCC_ETHCKSELR       \ This register is used to control the selection of the kernel clock for the ETH block. Note that changing the clock source on-the-fly is allowed, and will not generate any timing violation, however the user has to ensure that both the previous and the new clock sources are present during the switching, and for the whole transition time. Refer to Section: Clock enabling delays.
  $900 constant RCC_RCC_QSPICKSELR      \ This register is used to control the selection of the kernel clock for the QUADSPI. Note that changing the clock source on-the-fly is allowed, and will not generate any timing violation, however the user has to ensure that both the previous and the new clock sources are present during the switching, and for the whole transition time. Refer to Section: Clock enabling delays.
  $904 constant RCC_RCC_FMCCKSELR       \ This register is used to control the selection of the kernel clock for the FMC block. Note that changing the clock source on-the-fly is allowed, and will not generate any timing violation, however the user has to ensure that both the previous and the new clock sources are present during the switching, and for the whole transition time. Refer to Section: Clock enabling delays.
  $90C constant RCC_RCC_FDCANCKSELR     \ This register is used to control the selection of the kernel clock for the FDCAN block. Note that changing the clock source on-the-fly is allowed, and will not generate any timing violation, however the user has to ensure that both the previous and the new clock sources are present during the switching, and for the whole transition time. Refer to Section: Clock enabling delays.
  $914 constant RCC_RCC_SPDIFCKSELR     \ This register is used to control the selection of the kernel clock for the SPDIFRX. Note that changing the clock source on-the-fly is allowed, and will not generate any timing violation, however the user has to ensure that both the previous and the new clock sources are present during the switching, and for the whole transition time. Refer to Section: Clock enabling delays.
  $918 constant RCC_RCC_CECCKSELR       \ This register is used to control the selection of the kernel clock for the CEC-HDMI.
  $91C constant RCC_RCC_USBCKSELR       \ This register is used to control the selection of the kernel clock for the USBPHY PLL of the USB HOST and USB OTG
  $920 constant RCC_RCC_RNG2CKSELR      \ This register is used to control the selection of the kernel clock for the RNG2.
  $924 constant RCC_RCC_DSICKSELR       \ This register is used to control the selection of the kernel clock for the DSI block.
  $928 constant RCC_RCC_ADCCKSELR       \ This register is used to control the selection of the kernel clock for the ADC block.
  $92C constant RCC_RCC_LPTIM45CKSELR   \ This register is used to control the selection of the kernel clock for the LPTIM4 and LPTIM5 blocks.
  $930 constant RCC_RCC_LPTIM23CKSELR   \ This register is used to control the selection of the kernel clock for the LPTIM2 and LPTIM3 blocks.
  $934 constant RCC_RCC_LPTIM1CKSELR    \ This register is used to control the selection of the kernel clock for the LPTIM1 block.
  $980 constant RCC_RCC_APB1RSTSETR     \ This register is used to activate the reset of the corresponding peripheral.
  $984 constant RCC_RCC_APB1RSTCLRR     \ This register is used to release the reset of the corresponding peripheral.
  $988 constant RCC_RCC_APB2RSTSETR     \ This register is used to activate the reset of the corresponding peripheral.
  $98C constant RCC_RCC_APB2RSTCLRR     \ This register is used to release the reset of the corresponding peripheral.
  $990 constant RCC_RCC_APB3RSTSETR     \ This register is used to activate the reset of the corresponding peripheral.
  $994 constant RCC_RCC_APB3RSTCLRR     \ This register is used to release the reset of the corresponding peripheral.
  $998 constant RCC_RCC_AHB2RSTSETR     \ This register is used to activate the reset of the corresponding peripheral.
  $99C constant RCC_RCC_AHB2RSTCLRR     \ This register is used to release the reset of the corresponding peripheral.
  $9A0 constant RCC_RCC_AHB3RSTSETR     \ This register is used to activate the reset of the corresponding peripheral.
  $9A4 constant RCC_RCC_AHB3RSTCLRR     \ This register is used to release the reset of the corresponding peripheral.
  $9A8 constant RCC_RCC_AHB4RSTSETR     \ This register is used to activate the reset of the corresponding peripheral
  $9AC constant RCC_RCC_AHB4RSTCLRR     \ This register is used to release the reset of the corresponding peripheral.
  $A00 constant RCC_RCC_MP_APB1ENSETR   \ This register is used to set the peripheral clock enable bit
  $A04 constant RCC_RCC_MP_APB1ENCLRR   \ This register is used to clear the peripheral clock enable bit
  $A08 constant RCC_RCC_MP_APB2ENSETR   \ This register is used to set the peripheral clock enable bit
  $A0C constant RCC_RCC_MP_APB2ENCLRR   \ This register is used to clear the peripheral clock enable bit of the corresponding peripheral.
  $A10 constant RCC_RCC_MP_APB3ENSETR   \ This register is used to set the peripheral clock enable bit
  $A14 constant RCC_RCC_MP_APB3ENCLRR   \ This register is used to clear the peripheral clock enable bit of the corresponding peripheral.
  $A18 constant RCC_RCC_MP_AHB2ENSETR   \ This register is used to set the peripheral clock enable bit of the corresponding peripheral
  $A1C constant RCC_RCC_MP_AHB2ENCLRR   \ This register is used to clear the peripheral clock enable bit of the corresponding peripheral.
  $A20 constant RCC_RCC_MP_AHB3ENSETR   \ This register is used to set the peripheral clock enable bit of the corresponding peripheral
  $A24 constant RCC_RCC_MP_AHB3ENCLRR   \ This register is used to clear the peripheral clock enable bit of the corresponding peripheral.
  $A28 constant RCC_RCC_MP_AHB4ENSETR   \ This register is used to set the peripheral clock enable bit of the corresponding peripheral to . It shall be used to allocate a peripheral to the MPU.
  $A2C constant RCC_RCC_MP_AHB4ENCLRR   \ This register is used to clear the peripheral clock enable bit
  $A38 constant RCC_RCC_MP_MLAHBENSETR  \ This register is used to set the peripheral clock enable bit
  $A3C constant RCC_RCC_MP_MLAHBENCLRR  \ This register is used to clear the peripheral clock enable bit.
  $A80 constant RCC_RCC_MC_APB1ENSETR   \ This register is used to set the peripheral clock enable bit of the corresponding peripheral to . It shall be used to allocate a peripheral to the MCU. Writing has no effect, reading will return . Writing a sets the corresponding bit to .
  $A84 constant RCC_RCC_MC_APB1ENCLRR   \ This register is used to clear the peripheral clock enable bit of the corresponding peripheral.
  $A88 constant RCC_RCC_MC_APB2ENSETR   \ This register is used to set the peripheral clock enable bit
  $A8C constant RCC_RCC_MC_APB2ENCLRR   \ This register is used to clear the peripheral clock enable bit
  $A90 constant RCC_RCC_MC_APB3ENSETR   \ This register is used to set the peripheral clock enable bit
  $A94 constant RCC_RCC_MC_APB3ENCLRR   \ This register is used to clear the peripheral clock enable bit
  $A98 constant RCC_RCC_MC_AHB2ENSETR   \ This register is used to set the peripheral clock enable bit
  $A9C constant RCC_RCC_MC_AHB2ENCLRR   \ This register is used to clear the peripheral clock enable bit
  $AA0 constant RCC_RCC_MC_AHB3ENSETR   \ This register is used to set the peripheral clock enable bit
  $AA4 constant RCC_RCC_MC_AHB3ENCLRR   \ This register is used to clear the peripheral clock enable bit
  $AA8 constant RCC_RCC_MC_AHB4ENSETR   \ This register is used to set the peripheral clock enable bit
  $AAC constant RCC_RCC_MC_AHB4ENCLRR   \ This register is used to clear the peripheral clock enable bit
  $AB0 constant RCC_RCC_MC_AXIMENSETR   \ This register is used to set the peripheral clock enable bit
  $AB4 constant RCC_RCC_MC_AXIMENCLRR   \ This register is used to clear the peripheral clock enable bit
  $AB8 constant RCC_RCC_MC_MLAHBENSETR  \ This register is used to set the peripheral clock enable bit
  $ABC constant RCC_RCC_MC_MLAHBENCLRR  \ This register is used to clear the peripheral clock enable bit
  $B00 constant RCC_RCC_MP_APB1LPENSETR \ This register is used by the MCU in order to clear the PERxLPEN bits
  $B04 constant RCC_RCC_MP_APB1LPENCLRR \ This register is used by the MPU in order to clear the PERxLPEN bits .
  $B08 constant RCC_RCC_MP_APB2LPENSETR \ This register is used by the MCU in order to clear the PERxLPEN bits
  $B0C constant RCC_RCC_MP_APB2LPENCLRR \ This register is used by the MCU in order to clear the PERxLPEN bits
  $B10 constant RCC_RCC_MP_APB3LPENSETR \ This register is used by the MCU in order to clear the PERxLPEN bits
  $B14 constant RCC_RCC_MP_APB3LPENCLRR \ This register is used by the MCU in order to clear the PERxLPEN bits
  $B18 constant RCC_RCC_MP_AHB2LPENSETR \ This register is used by the MPU in order to set the PERxLPEN bit.
  $B1C constant RCC_RCC_MP_AHB2LPENCLRR \ This register is used by the MCU in order to clear the PERxLPEN bits
  $B20 constant RCC_RCC_MP_AHB3LPENSETR \ This register is used by the MPU
  $B24 constant RCC_RCC_MP_AHB3LPENCLRR \ This register is used by the MPU in order to clear the PERxLPEN bit
  $B28 constant RCC_RCC_MP_AHB4LPENSETR \ This register is used by the MPU
  $B2C constant RCC_RCC_MP_AHB4LPENCLRR \ This register is used by the MPU
  $B30 constant RCC_RCC_MP_AXIMLPENSETR \ This register is used by the MPU
  $B34 constant RCC_RCC_MP_AXIMLPENCLRR \ This register is used by the MPU
  $B38 constant RCC_RCC_MP_MLAHBLPENSETR    \ This register is used by the MPU in order to set the PERxLPEN bit
  $B3C constant RCC_RCC_MP_MLAHBLPENCLRR    \ This register is used by the MPU in order to clear the PERxLPEN bit
  $B80 constant RCC_RCC_MC_APB1LPENSETR \ This register is used by the MCU in order to set the PERxLPEN bit.
  $B84 constant RCC_RCC_MC_APB1LPENCLRR \ This register is used by the MCU in order to clear the PERxLPEN bits
  $B88 constant RCC_RCC_MC_APB2LPENSETR \ This register is used by the MCU in order to set the PERxLPEN bit.
  $B8C constant RCC_RCC_MC_APB2LPENCLRR \ This register is used by the MCU in order to clear the PERxLPEN bit
  $B90 constant RCC_RCC_MC_APB3LPENSETR \ This register is used by the MCU in order to set the PERxLPEN bit.
  $B94 constant RCC_RCC_MC_APB3LPENCLRR \ This register is used by the MCU in order to clear the PERxLPEN bit
  $B98 constant RCC_RCC_MC_AHB2LPENSETR \ This register is used by the MCU in order to set the PERxLPEN bit.
  $B9C constant RCC_RCC_MC_AHB2LPENCLRR \ This register is used by the MCU in order to clear the PERxLPEN bit
  $BA0 constant RCC_RCC_MC_AHB3LPENSETR \ This register is used by the MCU in order to set the PERxLPEN bit.
  $BA4 constant RCC_RCC_MC_AHB3LPENCLRR \ This register is used by the MCU in order to clear the PERxLPEN bit
  $BA8 constant RCC_RCC_MC_AHB4LPENSETR \ This register is used by the MCU in order to set the PERxLPEN bit.
  $BAC constant RCC_RCC_MC_AHB4LPENCLRR \ This register is used by the MCU in order to clear the PERxLPEN bit of the corresponding peripheral.
  $BB0 constant RCC_RCC_MC_AXIMLPENSETR \ This register is used by the MCU in order to set the PERxLPEN bit of the corresponding peripheral.
  $BB4 constant RCC_RCC_MC_AXIMLPENCLRR \ This register is used by the MCU in order to clear the PERxLPEN bit of the corresponding peripheral.
  $BB8 constant RCC_RCC_MC_MLAHBLPENSETR    \ This register is used by the MCU in order to set the PERxLPEN bit of the corresponding peripheral.
  $BBC constant RCC_RCC_MC_MLAHBLPENCLRR    \ This register is used by the MCU in order to clear the PERxLPEN bit of the corresponding peripheral.
  $C00 constant RCC_RCC_MC_RSTSCLRR     \ This register is used by the MCU to check the reset source.
  $C14 constant RCC_RCC_MC_CIER         \ This register shall be used by the MCU to control the interrupt source enable. Refer to Section10.5: RCC interrupts for more details.
  $C18 constant RCC_RCC_MC_CIFR         \ This register shall be used by the MCU in order to read and clear the interrupt flags.
  $FF4 constant RCC_RCC_VERR            \ This register gives the IP version
  $FF8 constant RCC_RCC_IDR             \ This register gives the unique identifier of the RCC
  $FFC constant RCC_RCC_SIDR            \ This register gives the decoding space, which is for the RCC of 4 kB.

: RCC_DEF ; [then]
