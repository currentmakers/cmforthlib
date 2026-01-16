\
\ @file rcc.fs
\ @brief RCC
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief This register is used to switch the RCC into secure mode. This register can only be accessed in secure mode.
\ Address offset: 0x00
\ Reset value: 0x00000003
\

$00000001 constant RCC_RCC_TZCR_TZEN                                \ TZEN
$00000002 constant RCC_RCC_TZCR_MCKPROT                             \ MCKPROT


\
\ @brief This register is used to control the oscillators.Writing to this register has no effect, writing will set the corresponding bits. Reading will give the effective values of each bit.If TZEN = MCKPROT = , this register can only be modified in secure mode. Write access to this register is not allowed during the clock restore sequence. See Section: The clock restore sequence description for details.
\ Address offset: 0x0C
\ Reset value: 0x00000001
\

$00000001 constant RCC_RCC_OCENSETR_HSION                           \ HSION
$00000002 constant RCC_RCC_OCENSETR_HSIKERON                        \ HSIKERON
$00000010 constant RCC_RCC_OCENSETR_CSION                           \ CSION
$00000020 constant RCC_RCC_OCENSETR_CSIKERON                        \ CSIKERON
$00000080 constant RCC_RCC_OCENSETR_DIGBYP                          \ DIGBYP
$00000100 constant RCC_RCC_OCENSETR_HSEON                           \ HSEON
$00000200 constant RCC_RCC_OCENSETR_HSEKERON                        \ HSEKERON
$00000400 constant RCC_RCC_OCENSETR_HSEBYP                          \ HSEBYP
$00000800 constant RCC_RCC_OCENSETR_HSECSSON                        \ HSECSSON


\
\ @brief This register is used to control the oscillators.Writing to this register has no effect, writing will clear the corresponding bits. Reading will give the effective values of the enable bits.If TZEN = , this register can only be modified in secure mode. Write access to this register is not allowed during the clock restore sequence. See Section: The clock restore sequence description for details.
\ Address offset: 0x10
\ Reset value: 0x00000001
\

$00000001 constant RCC_RCC_OCENCLRR_HSION                           \ HSION
$00000002 constant RCC_RCC_OCENCLRR_HSIKERON                        \ HSIKERON
$00000010 constant RCC_RCC_OCENCLRR_CSION                           \ CSION
$00000020 constant RCC_RCC_OCENCLRR_CSIKERON                        \ CSIKERON
$00000080 constant RCC_RCC_OCENCLRR_DIGBYP                          \ DIGBYP
$00000100 constant RCC_RCC_OCENCLRR_HSEON                           \ HSEON
$00000200 constant RCC_RCC_OCENCLRR_HSEKERON                        \ HSEKERON
$00000400 constant RCC_RCC_OCENCLRR_HSEBYP                          \ HSEBYP


\
\ @brief This register is used to configure the HSI. If TZEN = , this register can only be modified in secure mode. Write access to this register is not allowed during the clock restore sequence. See Section: The clock restore sequence description for details.
\ Address offset: 0x18
\ Reset value: 0x00000000
\

$00000003 constant RCC_RCC_HSICFGR_HSIDIV                           \ HSIDIV
$00007f00 constant RCC_RCC_HSICFGR_HSITRIM                          \ HSITRIM
$0fff0000 constant RCC_RCC_HSICFGR_HSICAL                           \ HSICAL


\
\ @brief This register is used to fine-tune the CSI frequency. If TZEN = MCKPROT = , this register can only be modified in secure mode. Write access to this register is not allowed during the clock restore sequence. See The clock restore sequence description for details.
\ Address offset: 0x1C
\ Reset value: 0x00001000
\

$00001f00 constant RCC_RCC_CSICFGR_CSITRIM                          \ CSITRIM
$00ff0000 constant RCC_RCC_CSICFGR_CSICAL                           \ CSICAL


\
\ @brief This register is used to select the clock source for the MPU. If TZEN = , this register can only be modified in secure mode. Write access to this register is not allowed during the clock restore sequence. See Section: The clock restore sequence description for details.
\ Address offset: 0x20
\ Reset value: 0x80000000
\

$00000003 constant RCC_RCC_MPCKSELR_MPUSRC                          \ MPUSRC
$80000000 constant RCC_RCC_MPCKSELR_MPUSRCRDY                       \ MPUSRCRDY


\
\ @brief This register is used to select the clock source for the AXI sub-system. If TZEN = , this register can only be modified in secure mode. Write access to this register is not allowed during the clock restore sequence. See Section: The clock restore sequence description for details.
\ Address offset: 0x24
\ Reset value: 0x80000000
\

$00000007 constant RCC_RCC_ASSCKSELR_AXISSRC                        \ AXISSRC
$80000000 constant RCC_RCC_ASSCKSELR_AXISSRCRDY                     \ AXISSRCRDY


\
\ @brief This register is used to select the reference clock for PLL1 and PLL2. If TZEN = , this register can only be modified in secure mode. Write access to this register is not allowed during the clock restore sequence. See Section: The clock restore sequence description for details.
\ Address offset: 0x28
\ Reset value: 0x80000000
\

$00000003 constant RCC_RCC_RCK12SELR_PLL12SRC                       \ PLL12SRC
$80000000 constant RCC_RCC_RCK12SELR_PLL12SRCRDY                    \ PLL12SRCRDY


\
\ @brief This register is used to control the MPU clock prescaler. Refer to Section: Sub-system clock generation for additional information. If TZEN = , this register can only be modified in secure mode.
\ Address offset: 0x2C
\ Reset value: 0x80000001
\

$00000007 constant RCC_RCC_MPCKDIVR_MPUDIV                          \ MPUDIV
$80000000 constant RCC_RCC_MPCKDIVR_MPUDIVRDY                       \ MPUDIVRDY


\
\ @brief This register is used to control the AXI Matrix clock prescaler. Refer to Section: Sub-system clock generation for additional information. If TZEN = , this register can only be modified in secure mode.
\ Address offset: 0x30
\ Reset value: 0x80000000
\

$00000007 constant RCC_RCC_AXIDIVR_AXIDIV                           \ AXIDIV
$80000000 constant RCC_RCC_AXIDIVR_AXIDIVRDY                        \ AXIDIVRDY


\
\ @brief This register is used to control the APB4 clock divider. Refer to Section: Sub-system clock generation for additional information. If TZEN = , this register can only be modified in secure mode.
\ Address offset: 0x3C
\ Reset value: 0x80000000
\

$00000007 constant RCC_RCC_APB4DIVR_APB4DIV                         \ APB4DIV
$80000000 constant RCC_RCC_APB4DIVR_APB4DIVRDY                      \ APB4DIVRDY


\
\ @brief This register is used to control the APB5 clock divider. Refer to Section: Sub-system clock generation for additional information. If TZEN = , this register can only be modified in secure mode.
\ Address offset: 0x40
\ Reset value: 0x80000000
\

$00000007 constant RCC_RCC_APB5DIVR_APB5DIV                         \ APB5DIV
$80000000 constant RCC_RCC_APB5DIVR_APB5DIVRDY                      \ APB5DIVRDY


\
\ @brief This register is used to divide the HSE clock for RTC. If TZEN = , this register can only be modified in secure mode.
\ Address offset: 0x44
\ Reset value: 0x00000000
\

$0000003f constant RCC_RCC_RTCDIVR_RTCDIV                           \ RTCDIV


\
\ @brief This register is used to select the clock source for the MCU sub-system, including the MCU itself. If TZEN = MCKPROT = , this register can only be modified in secure mode. Write access to this register is not allowed during the clock restore sequence. See Section: The clock restore sequence description for details.
\ Address offset: 0x48
\ Reset value: 0x80000000
\

$00000003 constant RCC_RCC_MSSCKSELR_MCUSSRC                        \ MCUSSRC
$80000000 constant RCC_RCC_MSSCKSELR_MCUSSRCRDY                     \ MCUSSRCRDY


\
\ @brief This register is used to control the PLL1. If TZEN = , this register can only be modified in secure mode. Write access to this register is not allowed during the clock restore sequence. See Section: The clock restore sequence description for details.
\ Address offset: 0x80
\ Reset value: 0x00000000
\

$00000001 constant RCC_RCC_PLL1CR_PLLON                             \ PLLON
$00000002 constant RCC_RCC_PLL1CR_PLL1RDY                           \ PLL1RDY
$00000004 constant RCC_RCC_PLL1CR_SSCG_CTRL                         \ SSCG_CTRL
$00000010 constant RCC_RCC_PLL1CR_DIVPEN                            \ DIVPEN
$00000020 constant RCC_RCC_PLL1CR_DIVQEN                            \ DIVQEN
$00000040 constant RCC_RCC_PLL1CR_DIVREN                            \ DIVREN


\
\ @brief This register is used to configure the PLL1. If TZEN = , this register can only be modified in secure mode. Write access to this register is not allowed during the clock restore sequence. See Section: The clock restore sequence description for details.
\ Address offset: 0x84
\ Reset value: 0x00010031
\

$000001ff constant RCC_RCC_PLL1CFGR1_DIVN                           \ DIVN
$003f0000 constant RCC_RCC_PLL1CFGR1_DIVM1                          \ DIVM1


\
\ @brief This register is used to configure the PLL1. If TZEN = , this register can only be modified in secure mode. Write access to this register is not allowed during the clock restore sequence. See Section: The clock restore sequence description for details.
\ Address offset: 0x88
\ Reset value: 0x00010100
\

$0000007f constant RCC_RCC_PLL1CFGR2_DIVP                           \ DIVP
$00007f00 constant RCC_RCC_PLL1CFGR2_DIVQ                           \ DIVQ
$007f0000 constant RCC_RCC_PLL1CFGR2_DIVR                           \ DIVR


\
\ @brief This register is used to fine-tune the frequency of the PLL1 VCO. If TZEN = , this register can only be modified in secure mode. Write access to this register is not allowed during the clock restore sequence. See Section: The clock restore sequence description for details.
\ Address offset: 0x8C
\ Reset value: 0x00000000
\

$0000fff8 constant RCC_RCC_PLL1FRACR_FRACV                          \ FRACV
$00010000 constant RCC_RCC_PLL1FRACR_FRACLE                         \ FRACLE


\
\ @brief This register is used to configure the PLL1.It is not recommended to change the content of this register when the PLL1 is enabled (PLLON = ). Refer to Section: Using the PLLs in spread spectrum mode for details. If TZEN = , this register can only be modified in secure mode. Write access to this register is not allowed during the clock restore sequence. See Section: The clock restore sequence description for details.
\ Address offset: 0x90
\ Reset value: 0x00000000
\

$00001fff constant RCC_RCC_PLL1CSGR_MOD_PER                         \ MOD_PER
$00002000 constant RCC_RCC_PLL1CSGR_TPDFN_DIS                       \ TPDFN_DIS
$00004000 constant RCC_RCC_PLL1CSGR_RPDFN_DIS                       \ RPDFN_DIS
$00008000 constant RCC_RCC_PLL1CSGR_SSCG_MODE                       \ SSCG_MODE
$7fff0000 constant RCC_RCC_PLL1CSGR_INC_STEP                        \ INC_STEP


\
\ @brief This register is used to control the PLL2. If TZEN = , this register can only be modified in secure mode. Write access to this register is not allowed during the clock restore sequence. See Section: The clock restore sequence description for details.
\ Address offset: 0x94
\ Reset value: 0x00000000
\

$00000001 constant RCC_RCC_PLL2CR_PLLON                             \ PLLON
$00000002 constant RCC_RCC_PLL2CR_PLL2RDY                           \ PLL2RDY
$00000004 constant RCC_RCC_PLL2CR_SSCG_CTRL                         \ SSCG_CTRL
$00000010 constant RCC_RCC_PLL2CR_DIVPEN                            \ DIVPEN
$00000020 constant RCC_RCC_PLL2CR_DIVQEN                            \ DIVQEN
$00000040 constant RCC_RCC_PLL2CR_DIVREN                            \ DIVREN


\
\ @brief This register is used to configure the PLL2. If TZEN = , this register can only be modified in secure mode. Write access to this register is not allowed during the clock restore sequence. See Section: The clock restore sequence description for details.
\ Address offset: 0x98
\ Reset value: 0x00010063
\

$000001ff constant RCC_RCC_PLL2CFGR1_DIVN                           \ DIVN
$003f0000 constant RCC_RCC_PLL2CFGR1_DIVM2                          \ DIVM2


\
\ @brief This register is used to configure the PLL2. If TZEN = , this register can only be modified in secure mode. Write access to this register is not allowed during the clock restore sequence. See Section: The clock restore sequence description for details.
\ Address offset: 0x9C
\ Reset value: 0x00010101
\

$0000007f constant RCC_RCC_PLL2CFGR2_DIVP                           \ DIVP
$00007f00 constant RCC_RCC_PLL2CFGR2_DIVQ                           \ DIVQ
$007f0000 constant RCC_RCC_PLL2CFGR2_DIVR                           \ DIVR


\
\ @brief This register is used to fine-tune the frequency of the PLL2 VCO. If TZEN = , this register can only be modified in secure mode. Write access to this register is not allowed during the clock restore sequence. See Section: The clock restore sequence description for details.
\ Address offset: 0xA0
\ Reset value: 0x00000000
\

$0000fff8 constant RCC_RCC_PLL2FRACR_FRACV                          \ FRACV
$00010000 constant RCC_RCC_PLL2FRACR_FRACLE                         \ FRACLE


\
\ @brief This register is used to configure the PLL2. It is not recommended to change the content of this register when the PLL2 is enabled (PLLON = ). Refer to Section: Using the PLLs in spread spectrum mode for details. If TZEN = , this register can only be modified in secure mode. Write access to this register is not allowed during the clock restore sequence. See Section: The clock restore sequence description for details.
\ Address offset: 0xA4
\ Reset value: 0x00000000
\

$00001fff constant RCC_RCC_PLL2CSGR_MOD_PER                         \ MOD_PER
$00002000 constant RCC_RCC_PLL2CSGR_TPDFN_DIS                       \ TPDFN_DIS
$00004000 constant RCC_RCC_PLL2CSGR_RPDFN_DIS                       \ RPDFN_DIS
$00008000 constant RCC_RCC_PLL2CSGR_SSCG_MODE                       \ SSCG_MODE
$7fff0000 constant RCC_RCC_PLL2CSGR_INC_STEP                        \ INC_STEP


\
\ @brief This register is used to control the selection of the kernel clock for the I2C4 and I2C6. Note that changing the clock source on-the-fly is allowed, and will not generate any timing violation, however the user has to ensure that both the previous and the new clock sources are present during the switching, and for the whole transition time. Refer to Section: Clock enabling delays. If TZEN = , this register can only be modified in secure mode.
\ Address offset: 0xC0
\ Reset value: 0x00000000
\

$00000007 constant RCC_RCC_I2C46CKSELR_I2C46SRC                     \ I2C46SRC


\
\ @brief This register is used to control the selection of the kernel clock for the SPI6. Note that changing the clock source on-the-fly is allowed, and will not generate any timing violation, however the user has to ensure that both the previous and the new clock sources are present during the switching, and for the whole transition time. Refer to Section: Clock enabling delays. If TZEN = , this register can only be modified in secure mode.
\ Address offset: 0xC4
\ Reset value: 0x00000000
\

$00000007 constant RCC_RCC_SPI6CKSELR_SPI6SRC                       \ SPI6SRC


\
\ @brief This register is used to control the selection of the kernel clock for the USART1. Note that changing the clock source on-the-fly is allowed, and will not generate any timing violation, however the user has to ensure that both the previous and the new clock sources are present during the switching, and for the whole transition time. Refer to Section: Clock enabling delays. If TZEN = , this register can only be modified in secure mode.
\ Address offset: 0xC8
\ Reset value: 0x00000000
\

$00000007 constant RCC_RCC_UART1CKSELR_UART1SRC                     \ UART1SRC


\
\ @brief This register is used to control the selection of the kernel clock for the RNG1. Note that changing the clock source on-the-fly is allowed, and will not generate any timing violation, however the user has to ensure that both the previous and the new clock sources are present during the switching, and for the whole transition time. Refer to Section: Clock enabling delays. If TZEN = , this register can only be modified in secure mode.
\ Address offset: 0xCC
\ Reset value: 0x00000000
\

$00000003 constant RCC_RCC_RNG1CKSELR_RNG1SRC                       \ RNG1SRC


\
\ @brief This register is used to select an oscillator source as kernel clock for the per_ck clock. The per_ck clock is distributed to several peripherals. Refer to Section: Clock enabling delays.
\ Address offset: 0xD0
\ Reset value: 0x00000000
\

$00000003 constant RCC_RCC_CPERCKSELR_CKPERSRC                      \ CKPERSRC


\
\ @brief This register is used to select the peripheral clock for the STGEN block. Note that this clock is used to provide a time reference for the application. Refer to Section: Clock enabling delays. If TZEN = , this register can only be modified in secure mode.
\ Address offset: 0xD4
\ Reset value: 0x00000000
\

$00000003 constant RCC_RCC_STGENCKSELR_STGENSRC                     \ STGENSRC


\
\ @brief This register is used to control the DDR interface, including the DDRC and DDRPHYC. If TZEN = , this register can only be modified in secure mode.
\ Address offset: 0xD8
\ Reset value: 0x000FD02A
\

$00000001 constant RCC_RCC_DDRITFCR_DDRC1EN                         \ DDRC1EN
$00000002 constant RCC_RCC_DDRITFCR_DDRC1LPEN                       \ DDRC1LPEN
$00000004 constant RCC_RCC_DDRITFCR_DDRC2EN                         \ DDRC2EN
$00000008 constant RCC_RCC_DDRITFCR_DDRC2LPEN                       \ DDRC2LPEN
$00000010 constant RCC_RCC_DDRITFCR_DDRPHYCEN                       \ DDRPHYCEN
$00000020 constant RCC_RCC_DDRITFCR_DDRPHYCLPEN                     \ DDRPHYCLPEN
$00000040 constant RCC_RCC_DDRITFCR_DDRCAPBEN                       \ DDRCAPBEN
$00000080 constant RCC_RCC_DDRITFCR_DDRCAPBLPEN                     \ DDRCAPBLPEN
$00000100 constant RCC_RCC_DDRITFCR_AXIDCGEN                        \ AXIDCGEN
$00000200 constant RCC_RCC_DDRITFCR_DDRPHYCAPBEN                    \ DDRPHYCAPBEN
$00000400 constant RCC_RCC_DDRITFCR_DDRPHYCAPBLPEN                  \ DDRPHYCAPBLPEN
$00003800 constant RCC_RCC_DDRITFCR_KERDCG_DLY                      \ KERDCG_DLY
$00004000 constant RCC_RCC_DDRITFCR_DDRCAPBRST                      \ DDRCAPBRST
$00008000 constant RCC_RCC_DDRITFCR_DDRCAXIRST                      \ DDRCAXIRST
$00010000 constant RCC_RCC_DDRITFCR_DDRCORERST                      \ DDRCORERST
$00020000 constant RCC_RCC_DDRITFCR_DPHYAPBRST                      \ DPHYAPBRST
$00040000 constant RCC_RCC_DDRITFCR_DPHYRST                         \ DPHYRST
$00080000 constant RCC_RCC_DDRITFCR_DPHYCTLRST                      \ DPHYCTLRST
$00700000 constant RCC_RCC_DDRITFCR_DDRCKMOD                        \ DDRCKMOD
$00800000 constant RCC_RCC_DDRITFCR_GSKPMOD                         \ GSKPMOD
$01000000 constant RCC_RCC_DDRITFCR_GSKPCTRL                        \ GSKPCTRL
$0e000000 constant RCC_RCC_DDRITFCR_DFILP_WIDTH                     \ DFILP_WIDTH
$f0000000 constant RCC_RCC_DDRITFCR_GSKP_DUR                        \ GSKP_DUR


\
\ @brief This register is used to control the HOLD boot function when the system exits from Standby. Refer to Section: MCU HOLD_BOOT after processor reset. This register is reset when a system reset occurs, but not when the circuit exits from Standby (app_rst reset).If TZEN = , this register can only be modified in secure mode. This register can only be accessed by the MPU.
\ Address offset: 0x100
\ Reset value: 0x00000000
\

$00000001 constant RCC_RCC_MP_BOOTCR_MCU_BEN                        \ MCU_BEN
$00000002 constant RCC_RCC_MP_BOOTCR_MPU_BEN                        \ MPU_BEN


\
\ @brief Writing has no effect, reading will return the values of the bits. Writing a sets the corresponding bit to . The MCU cannot access to this register. If TZEN = , this register can only be modified in secure mode.
\ Address offset: 0x104
\ Reset value: 0x00000000
\

$00000001 constant RCC_RCC_MP_SREQSETR_STPREQ_P0                    \ STPREQ_P0
$00000002 constant RCC_RCC_MP_SREQSETR_STPREQ_P1                    \ STPREQ_P1


\
\ @brief Writing has no effect, reading will return the effective values of the bits. Writing a sets the corresponding bit to . The MCU cannot access to this register. If TZEN = , this register can only be modified in secure mode.
\ Address offset: 0x108
\ Reset value: 0x00000000
\

$00000001 constant RCC_RCC_MP_SREQCLRR_STPREQ_P0                    \ STPREQ_P0
$00000002 constant RCC_RCC_MP_SREQCLRR_STPREQ_P1                    \ STPREQ_P1


\
\ @brief The register contains global control bits. If TZEN = , this register can only be modified in secure mode.
\ Address offset: 0x10C
\ Reset value: 0x00000000
\

$00000001 constant RCC_RCC_MP_GCR_BOOT_MCU                          \ BOOT_MCU


\
\ @brief This register is used to control the behavior of the warm reset. If TZEN = , this register can only be modified in secure mode.
\ Address offset: 0x110
\ Reset value: 0x00007F00
\

$00000001 constant RCC_RCC_MP_APRSTCR_RDCTLEN                       \ RDCTLEN
$00007f00 constant RCC_RCC_MP_APRSTCR_RSTTO                         \ RSTTO


\
\ @brief This register provides a status of the RDCTL. If TZEN = , this register can only be modified in secure mode.
\ Address offset: 0x114
\ Reset value: 0x00000000
\

$00007f00 constant RCC_RCC_MP_APRSTSR_RSTTOV                        \ RSTTOV


\
\ @brief This register is used to control the LSE function. Wait states are inserted in case of successive write accesses to this register. The number of wait states may be up to 7 cycles of AHB4 clock.After a system reset, the register RCC_BDCR is write-protected. In order to modify this register, the DBP bit in the PWR control register 1 (PWR_CR1) has to be set to . Bits of RCC_BDCR register are only reset after a backup domain reset: nreset_vsw (see Section10.3.6: Backup domain reset). Any other internal or external reset will not have any effect on these bits.This register is located into the VSW domain. If TZEN = , this register can only be modified in secure mode.
\ Address offset: 0x140
\ Reset value: 0x00000020
\

$00000001 constant RCC_RCC_BDCR_LSEON                               \ LSEON
$00000002 constant RCC_RCC_BDCR_LSEBYP                              \ LSEBYP
$00000004 constant RCC_RCC_BDCR_LSERDY                              \ LSERDY
$00000008 constant RCC_RCC_BDCR_DIGBYP                              \ DIGBYP
$00000030 constant RCC_RCC_BDCR_LSEDRV                              \ LSEDRV
$00000100 constant RCC_RCC_BDCR_LSECSSON                            \ LSECSSON
$00000200 constant RCC_RCC_BDCR_LSECSSD                             \ LSECSSD
$00030000 constant RCC_RCC_BDCR_RTCSRC                              \ RTCSRC
$00100000 constant RCC_RCC_BDCR_RTCCKEN                             \ RTCCKEN
$80000000 constant RCC_RCC_BDCR_VSWRST                              \ VSWRST


\
\ @brief This register is used to control the minimum NRST active duration and LSI function.0 to 7 wait states are inserted for word, half-word and byte accesses. Wait states are inserted in case of successive accesses to this register.This register is reset by the por_rst reset, and it is located into the VDD domain. If TZEN = , this register can only be modified in secure mode.
\ Address offset: 0x144
\ Reset value: 0x00000000
\

$00000001 constant RCC_RCC_RDLSICR_LSION                            \ LSION
$00000002 constant RCC_RCC_RDLSICR_LSIRDY                           \ LSIRDY
$001f0000 constant RCC_RCC_RDLSICR_MRD                              \ MRD
$07000000 constant RCC_RCC_RDLSICR_EADLY                            \ EADLY
$f8000000 constant RCC_RCC_RDLSICR_SPARE                            \ SPARE


\
\ @brief This register is used to activate the reset of the corresponding peripheral. Writing has no effect, reading will return the effective values of the corresponding bits. Writing a activates the reset of the corresponding peripheral.
\ Address offset: 0x180
\ Reset value: 0x00000000
\

$00000001 constant RCC_RCC_APB4RSTSETR_LTDCRST                      \ LTDCRST
$00000010 constant RCC_RCC_APB4RSTSETR_DSIRST                       \ DSIRST
$00000100 constant RCC_RCC_APB4RSTSETR_DDRPERFMRST                  \ DDRPERFMRST
$00010000 constant RCC_RCC_APB4RSTSETR_USBPHYRST                    \ USBPHYRST


\
\ @brief This register is used to release the reset of the corresponding peripheral. Writing has no effect, reading will return the effective values of the corresponding bits. Writing a releases the reset of the corresponding peripheral.
\ Address offset: 0x184
\ Reset value: 0x00000000
\

$00000001 constant RCC_RCC_APB4RSTCLRR_LTDCRST                      \ LTDCRST
$00000010 constant RCC_RCC_APB4RSTCLRR_DSIRST                       \ DSIRST
$00000100 constant RCC_RCC_APB4RSTCLRR_DDRPERFMRST                  \ DDRPERFMRST
$00010000 constant RCC_RCC_APB4RSTCLRR_USBPHYRST                    \ USBPHYRST


\
\ @brief This register is used to activate the reset of the corresponding peripheral. Writing has no effect, reading will return the effective values of the corresponding bits. Writing a activates the reset of the corresponding peripheral. If TZEN = , this register can only be modified in secure mode.
\ Address offset: 0x188
\ Reset value: 0x00000000
\

$00000001 constant RCC_RCC_APB5RSTSETR_SPI6RST                      \ SPI6RST
$00000004 constant RCC_RCC_APB5RSTSETR_I2C4RST                      \ I2C4RST
$00000008 constant RCC_RCC_APB5RSTSETR_I2C6RST                      \ I2C6RST
$00000010 constant RCC_RCC_APB5RSTSETR_USART1RST                    \ USART1RST
$00100000 constant RCC_RCC_APB5RSTSETR_STGENRST                     \ STGENRST


\
\ @brief This register is used to release the reset of the corresponding peripheral. Writing has no effect, reading will return the effective values of the corresponding bits. Writing a releases the reset of the corresponding peripheral. If TZEN = , this register can only be modified in secure mode.
\ Address offset: 0x18C
\ Reset value: 0x00000000
\

$00000001 constant RCC_RCC_APB5RSTCLRR_SPI6RST                      \ SPI6RST
$00000004 constant RCC_RCC_APB5RSTCLRR_I2C4RST                      \ I2C4RST
$00000008 constant RCC_RCC_APB5RSTCLRR_I2C6RST                      \ I2C6RST
$00000010 constant RCC_RCC_APB5RSTCLRR_USART1RST                    \ USART1RST
$00100000 constant RCC_RCC_APB5RSTCLRR_STGENRST                     \ STGENRST


\
\ @brief This register is used to activate the reset of the corresponding peripheral. Writing has no effect, reading will return the effective values of the corresponding bits. Writing a activates the reset of the corresponding peripheral. If TZEN = , this register can only be modified in secure mode.
\ Address offset: 0x190
\ Reset value: 0x00000000
\

$00000001 constant RCC_RCC_AHB5RSTSETR_GPIOZRST                     \ GPIOZRST
$00000010 constant RCC_RCC_AHB5RSTSETR_CRYP1RST                     \ CRYP1RST
$00000020 constant RCC_RCC_AHB5RSTSETR_HASH1RST                     \ HASH1RST
$00000040 constant RCC_RCC_AHB5RSTSETR_RNG1RST                      \ RNG1RST
$00010000 constant RCC_RCC_AHB5RSTSETR_AXIMCRST                     \ AXIMCRST


\
\ @brief This register is used to release the reset of the corresponding peripheral. Writing has no effect, reading will return the effective values of the corresponding bits. Writing a releases the reset of the corresponding peripheral. If TZEN = , this register can only be modified in secure mode.
\ Address offset: 0x194
\ Reset value: 0x00000000
\

$00000001 constant RCC_RCC_AHB5RSTCLRR_GPIOZRST                     \ GPIOZRST
$00000010 constant RCC_RCC_AHB5RSTCLRR_CRYP1RST                     \ CRYP1RST
$00000020 constant RCC_RCC_AHB5RSTCLRR_HASH1RST                     \ HASH1RST
$00000040 constant RCC_RCC_AHB5RSTCLRR_RNG1RST                      \ RNG1RST
$00010000 constant RCC_RCC_AHB5RSTCLRR_AXIMCRST                     \ AXIMCRST


\
\ @brief This register is used to activate the reset of the corresponding peripheral. Writing has no effect, reading will return the effective values of the corresponding bits. Writing a activates the reset of the corresponding peripheral.
\ Address offset: 0x198
\ Reset value: 0x00000000
\

$00000020 constant RCC_RCC_AHB6RSTSETR_GPURST                       \ GPURST
$00000400 constant RCC_RCC_AHB6RSTSETR_ETHMACRST                    \ ETHMACRST
$00001000 constant RCC_RCC_AHB6RSTSETR_FMCRST                       \ FMCRST
$00004000 constant RCC_RCC_AHB6RSTSETR_QSPIRST                      \ QSPIRST
$00010000 constant RCC_RCC_AHB6RSTSETR_SDMMC1RST                    \ SDMMC1RST
$00020000 constant RCC_RCC_AHB6RSTSETR_SDMMC2RST                    \ SDMMC2RST
$00100000 constant RCC_RCC_AHB6RSTSETR_CRC1RST                      \ CRC1RST
$01000000 constant RCC_RCC_AHB6RSTSETR_USBHRST                      \ USBHRST


\
\ @brief This register is used to release the reset of the corresponding peripheral. Writing has no effect, reading will return the effective values of the corresponding bits. Writing a releases the reset of the corresponding peripheral.
\ Address offset: 0x19C
\ Reset value: 0x00000000
\

$00000400 constant RCC_RCC_AHB6RSTCLRR_ETHMACRST                    \ ETHMACRST
$00001000 constant RCC_RCC_AHB6RSTCLRR_FMCRST                       \ FMCRST
$00004000 constant RCC_RCC_AHB6RSTCLRR_QSPIRST                      \ QSPIRST
$00010000 constant RCC_RCC_AHB6RSTCLRR_SDMMC1RST                    \ SDMMC1RST
$00020000 constant RCC_RCC_AHB6RSTCLRR_SDMMC2RST                    \ SDMMC2RST
$00100000 constant RCC_RCC_AHB6RSTCLRR_CRC1RST                      \ CRC1RST
$01000000 constant RCC_RCC_AHB6RSTCLRR_USBHRST                      \ USBHRST


\
\ @brief This register is used to activate the reset of the corresponding peripheral. Writing has no effect, reading will return the effective values of the corresponding bits. Writing a activates the reset of the corresponding peripheral. If TZEN = , this register can only be modified in secure mode.
\ Address offset: 0x1A0
\ Reset value: 0x00000000
\

$00000001 constant RCC_RCC_TZAHB6RSTSETR_MDMARST                    \ MDMARST


\
\ @brief This register is used to release the reset of the corresponding peripheral. Writing has no effect, reading will return the effective values of the corresponding bits. Writing a releases the reset of the corresponding peripheral. If TZEN = , this register can only be modified in secure mode.
\ Address offset: 0x1A4
\ Reset value: 0x00000000
\

$00000001 constant RCC_RCC_TZAHB6RSTCLRR_MDMARST                    \ MDMARST


\
\ @brief This register is used to set the peripheral clock enable bit of the corresponding peripheral to . It shall be used to allocate a peripheral to the MPU. Writing has no effect, reading will return the effective values of the corresponding bits. Writing a sets the corresponding bit to .
\ Address offset: 0x200
\ Reset value: 0x00000000
\

$00000001 constant RCC_RCC_MP_APB4ENSETR_LTDCEN                     \ LTDCEN
$00000010 constant RCC_RCC_MP_APB4ENSETR_DSIEN                      \ DSIEN
$00000100 constant RCC_RCC_MP_APB4ENSETR_DDRPERFMEN                 \ DDRPERFMEN
$00008000 constant RCC_RCC_MP_APB4ENSETR_IWDG2APBEN                 \ IWDG2APBEN
$00010000 constant RCC_RCC_MP_APB4ENSETR_USBPHYEN                   \ USBPHYEN
$00100000 constant RCC_RCC_MP_APB4ENSETR_STGENROEN                  \ STGENROEN


\
\ @brief This register is used to clear the peripheral clock enable bit of the corresponding peripheral. It shall be used to deallocate a peripheral from MPU. Writing has no effect, reading will return the effective values of the corresponding bits. Writing a sets the corresponding bit to .
\ Address offset: 0x204
\ Reset value: 0x00000000
\

$00000001 constant RCC_RCC_MP_APB4ENCLRR_LTDCEN                     \ LTDCEN
$00000010 constant RCC_RCC_MP_APB4ENCLRR_DSIEN                      \ DSIEN
$00000100 constant RCC_RCC_MP_APB4ENCLRR_DDRPERFMEN                 \ DDRPERFMEN
$00008000 constant RCC_RCC_MP_APB4ENCLRR_IWDG2APBEN                 \ IWDG2APBEN
$00010000 constant RCC_RCC_MP_APB4ENCLRR_USBPHYEN                   \ USBPHYEN
$00100000 constant RCC_RCC_MP_APB4ENCLRR_STGENROEN                  \ STGENROEN


\
\ @brief This register is used to set the peripheral clock enable bit of the corresponding peripheral to . It shall be used to allocate a peripheral to the MPU. Writing has no effect, reading will return the effective values of the corresponding bits. Writing a sets the corresponding bit to .
\ Address offset: 0x208
\ Reset value: 0x00000000
\

$00000001 constant RCC_RCC_MP_APB5ENSETR_SPI6EN                     \ SPI6EN
$00000004 constant RCC_RCC_MP_APB5ENSETR_I2C4EN                     \ I2C4EN
$00000008 constant RCC_RCC_MP_APB5ENSETR_I2C6EN                     \ I2C6EN
$00000010 constant RCC_RCC_MP_APB5ENSETR_USART1EN                   \ USART1EN
$00000100 constant RCC_RCC_MP_APB5ENSETR_RTCAPBEN                   \ RTCAPBEN
$00000800 constant RCC_RCC_MP_APB5ENSETR_TZC1EN                     \ TZC1EN
$00001000 constant RCC_RCC_MP_APB5ENSETR_TZC2EN                     \ TZC2EN
$00002000 constant RCC_RCC_MP_APB5ENSETR_TZPCEN                     \ TZPCEN
$00008000 constant RCC_RCC_MP_APB5ENSETR_IWDG1APBEN                 \ IWDG1APBEN
$00010000 constant RCC_RCC_MP_APB5ENSETR_BSECEN                     \ BSECEN
$00100000 constant RCC_RCC_MP_APB5ENSETR_STGENEN                    \ STGENEN


\
\ @brief This register is used to clear the peripheral clock enable bit of the corresponding peripheral. It shall be used to deallocate a peripheral from MPU. Writing has no effect, reading will return the effective values of the corresponding bits. Writing a sets the corresponding bit to .
\ Address offset: 0x20C
\ Reset value: 0x00000000
\

$00000001 constant RCC_RCC_MP_APB5ENCLRR_SPI6EN                     \ SPI6EN
$00000004 constant RCC_RCC_MP_APB5ENCLRR_I2C4EN                     \ I2C4EN
$00000008 constant RCC_RCC_MP_APB5ENCLRR_I2C6EN                     \ I2C6EN
$00000010 constant RCC_RCC_MP_APB5ENCLRR_USART1EN                   \ USART1EN
$00000100 constant RCC_RCC_MP_APB5ENCLRR_RTCAPBEN                   \ RTCAPBEN
$00000800 constant RCC_RCC_MP_APB5ENCLRR_TZC1EN                     \ TZC1EN
$00001000 constant RCC_RCC_MP_APB5ENCLRR_TZC2EN                     \ TZC2EN
$00002000 constant RCC_RCC_MP_APB5ENCLRR_TZPCEN                     \ TZPCEN
$00008000 constant RCC_RCC_MP_APB5ENCLRR_IWDG1APBEN                 \ IWDG1APBEN
$00010000 constant RCC_RCC_MP_APB5ENCLRR_BSECEN                     \ BSECEN
$00100000 constant RCC_RCC_MP_APB5ENCLRR_STGENEN                    \ STGENEN


\
\ @brief This register is used to set the peripheral clock enable bit of the corresponding peripheral to . It shall be used to allocate a peripheral to the MPU. Writing has no effect, reading will return the effective values of the corresponding bits. Writing a sets the corresponding bit to . If TZEN = , this register can only be modified in secure mode.
\ Address offset: 0x210
\ Reset value: 0x00010000
\

$00000001 constant RCC_RCC_MP_AHB5ENSETR_GPIOZEN                    \ GPIOZEN
$00000010 constant RCC_RCC_MP_AHB5ENSETR_CRYP1EN                    \ CRYP1EN
$00000020 constant RCC_RCC_MP_AHB5ENSETR_HASH1EN                    \ HASH1EN
$00000040 constant RCC_RCC_MP_AHB5ENSETR_RNG1EN                     \ RNG1EN
$00000100 constant RCC_RCC_MP_AHB5ENSETR_BKPSRAMEN                  \ BKPSRAMEN
$00010000 constant RCC_RCC_MP_AHB5ENSETR_AXIMCEN                    \ AXIMCEN


\
\ @brief This register is used to clear the peripheral clock enable bit of the corresponding peripheral. It shall be used to deallocate a peripheral from MPU. Writing has no effect, reading will return the effective values of the corresponding bits. Writing a sets the corresponding bit to . If TZEN = , this register can only be modified in secure mode.
\ Address offset: 0x214
\ Reset value: 0x00010000
\

$00000001 constant RCC_RCC_MP_AHB5ENCLRR_GPIOZEN                    \ GPIOZEN
$00000010 constant RCC_RCC_MP_AHB5ENCLRR_CRYP1EN                    \ CRYP1EN
$00000020 constant RCC_RCC_MP_AHB5ENCLRR_HASH1EN                    \ HASH1EN
$00000040 constant RCC_RCC_MP_AHB5ENCLRR_RNG1EN                     \ RNG1EN
$00000100 constant RCC_RCC_MP_AHB5ENCLRR_BKPSRAMEN                  \ BKPSRAMEN
$00010000 constant RCC_RCC_MP_AHB5ENCLRR_AXIMCEN                    \ AXIMCEN


\
\ @brief This register is used to set the peripheral clock enable bit of the corresponding peripheral to . It shall be used to allocate a peripheral to the MPU. Writing has no effect, reading will return the effective values of the corresponding bits. Writing a sets the corresponding bit to .
\ Address offset: 0x218
\ Reset value: 0x00000000
\

$00000001 constant RCC_RCC_MP_AHB6ENSETR_MDMAEN                     \ MDMAEN
$00000020 constant RCC_RCC_MP_AHB6ENSETR_GPUEN                      \ GPUEN
$00000080 constant RCC_RCC_MP_AHB6ENSETR_ETHCKEN                    \ ETHCKEN
$00000100 constant RCC_RCC_MP_AHB6ENSETR_ETHTXEN                    \ ETHTXEN
$00000200 constant RCC_RCC_MP_AHB6ENSETR_ETHRXEN                    \ ETHRXEN
$00000400 constant RCC_RCC_MP_AHB6ENSETR_ETHMACEN                   \ ETHMACEN
$00001000 constant RCC_RCC_MP_AHB6ENSETR_FMCEN                      \ FMCEN
$00004000 constant RCC_RCC_MP_AHB6ENSETR_QSPIEN                     \ QSPIEN
$00010000 constant RCC_RCC_MP_AHB6ENSETR_SDMMC1EN                   \ SDMMC1EN
$00020000 constant RCC_RCC_MP_AHB6ENSETR_SDMMC2EN                   \ SDMMC2EN
$00100000 constant RCC_RCC_MP_AHB6ENSETR_CRC1EN                     \ CRC1EN
$01000000 constant RCC_RCC_MP_AHB6ENSETR_USBHEN                     \ USBHEN


\
\ @brief This register is used to clear the peripheral clock enable bit of the corresponding peripheral. It shall be used to deallocate a peripheral from MPU. Writing has no effect, reading will return the effective values of the corresponding bits. Writing a sets the corresponding bit to .
\ Address offset: 0x21C
\ Reset value: 0x00000000
\

$00000001 constant RCC_RCC_MP_AHB6ENCLRR_MDMAEN                     \ MDMAEN
$00000020 constant RCC_RCC_MP_AHB6ENCLRR_GPUEN                      \ GPUEN
$00000080 constant RCC_RCC_MP_AHB6ENCLRR_ETHCKEN                    \ ETHCKEN
$00000100 constant RCC_RCC_MP_AHB6ENCLRR_ETHTXEN                    \ ETHTXEN
$00000200 constant RCC_RCC_MP_AHB6ENCLRR_ETHRXEN                    \ ETHRXEN
$00000400 constant RCC_RCC_MP_AHB6ENCLRR_ETHMACEN                   \ ETHMACEN
$00001000 constant RCC_RCC_MP_AHB6ENCLRR_FMCEN                      \ FMCEN
$00004000 constant RCC_RCC_MP_AHB6ENCLRR_QSPIEN                     \ QSPIEN
$00010000 constant RCC_RCC_MP_AHB6ENCLRR_SDMMC1EN                   \ SDMMC1EN
$00020000 constant RCC_RCC_MP_AHB6ENCLRR_SDMMC2EN                   \ SDMMC2EN
$00100000 constant RCC_RCC_MP_AHB6ENCLRR_CRC1EN                     \ CRC1EN
$01000000 constant RCC_RCC_MP_AHB6ENCLRR_USBHEN                     \ USBHEN


\
\ @brief This register is used to set the peripheral clock enable bit of the corresponding peripheral to . It shall be used to allocate a peripheral to the MPU. Writing has no effect, reading will return the effective values of the corresponding bits. Writing a sets the corresponding bit to . If TZEN = , this register can only be modified in secure mode.
\ Address offset: 0x220
\ Reset value: 0x00000000
\

$00000001 constant RCC_RCC_MP_TZAHB6ENSETR_MDMAEN                   \ MDMAEN


\
\ @brief This register is used to clear the peripheral clock enable bit of the corresponding peripheral. It shall be used to deallocate a peripheral from MPU. Writing has no effect, reading will return the effective values of the corresponding bits. Writing a sets the corresponding bit to . If TZEN = , this register can only be modified in secure mode.
\ Address offset: 0x224
\ Reset value: 0x00000000
\

$00000001 constant RCC_RCC_MP_TZAHB6ENCLRR_MDMAEN                   \ MDMAEN


\
\ @brief This register is used to set the peripheral clock enable bit
\ Address offset: 0x280
\ Reset value: 0x00000000
\

$00000001 constant RCC_RCC_MC_APB4ENSETR_LTDCEN                     \ LTDCEN
$00000010 constant RCC_RCC_MC_APB4ENSETR_DSIEN                      \ DSIEN
$00000100 constant RCC_RCC_MC_APB4ENSETR_DDRPERFMEN                 \ DDRPERFMEN
$00010000 constant RCC_RCC_MC_APB4ENSETR_USBPHYEN                   \ USBPHYEN
$00100000 constant RCC_RCC_MC_APB4ENSETR_STGENROEN                  \ STGENROEN


\
\ @brief This register is used to clear the peripheral clock enable bit
\ Address offset: 0x284
\ Reset value: 0x00000000
\

$00000001 constant RCC_RCC_MC_APB4ENCLRR_LTDCEN                     \ LTDCEN
$00000010 constant RCC_RCC_MC_APB4ENCLRR_DSIEN                      \ DSIEN
$00000100 constant RCC_RCC_MC_APB4ENCLRR_DDRPERFMEN                 \ DDRPERFMEN
$00010000 constant RCC_RCC_MC_APB4ENCLRR_USBPHYEN                   \ USBPHYEN
$00100000 constant RCC_RCC_MC_APB4ENCLRR_STGENROEN                  \ STGENROEN


\
\ @brief This register is used to set the peripheral clock enable bit
\ Address offset: 0x288
\ Reset value: 0x00000000
\

$00000001 constant RCC_RCC_MC_APB5ENSETR_SPI6EN                     \ SPI6EN
$00000004 constant RCC_RCC_MC_APB5ENSETR_I2C4EN                     \ I2C4EN
$00000008 constant RCC_RCC_MC_APB5ENSETR_I2C6EN                     \ I2C6EN
$00000010 constant RCC_RCC_MC_APB5ENSETR_USART1EN                   \ USART1EN
$00000100 constant RCC_RCC_MC_APB5ENSETR_RTCAPBEN                   \ RTCAPBEN
$00000800 constant RCC_RCC_MC_APB5ENSETR_TZC1EN                     \ TZC1EN
$00001000 constant RCC_RCC_MC_APB5ENSETR_TZC2EN                     \ TZC2EN
$00002000 constant RCC_RCC_MC_APB5ENSETR_TZPCEN                     \ TZPCEN
$00010000 constant RCC_RCC_MC_APB5ENSETR_BSECEN                     \ BSECEN
$00100000 constant RCC_RCC_MC_APB5ENSETR_STGENEN                    \ STGENEN


\
\ @brief This register is used to clear the peripheral clock enable bit
\ Address offset: 0x28C
\ Reset value: 0x00000000
\

$00000001 constant RCC_RCC_MC_APB5ENCLRR_SPI6EN                     \ SPI6EN
$00000004 constant RCC_RCC_MC_APB5ENCLRR_I2C4EN                     \ I2C4EN
$00000008 constant RCC_RCC_MC_APB5ENCLRR_I2C6EN                     \ I2C6EN
$00000010 constant RCC_RCC_MC_APB5ENCLRR_USART1EN                   \ USART1EN
$00000100 constant RCC_RCC_MC_APB5ENCLRR_RTCAPBEN                   \ RTCAPBEN
$00000800 constant RCC_RCC_MC_APB5ENCLRR_TZC1EN                     \ TZC1EN
$00001000 constant RCC_RCC_MC_APB5ENCLRR_TZC2EN                     \ TZC2EN
$00002000 constant RCC_RCC_MC_APB5ENCLRR_TZPCEN                     \ TZPCEN
$00010000 constant RCC_RCC_MC_APB5ENCLRR_BSECEN                     \ BSECEN
$00100000 constant RCC_RCC_MC_APB5ENCLRR_STGENEN                    \ STGENEN


\
\ @brief This register is used to set the peripheral clock enable bit If TZEN = , this register can only be modified in secure mode.
\ Address offset: 0x290
\ Reset value: 0x00000000
\

$00000001 constant RCC_RCC_MC_AHB5ENSETR_GPIOZEN                    \ GPIOZEN
$00000010 constant RCC_RCC_MC_AHB5ENSETR_CRYP1EN                    \ CRYP1EN
$00000020 constant RCC_RCC_MC_AHB5ENSETR_HASH1EN                    \ HASH1EN
$00000040 constant RCC_RCC_MC_AHB5ENSETR_RNG1EN                     \ RNG1EN
$00000100 constant RCC_RCC_MC_AHB5ENSETR_BKPSRAMEN                  \ BKPSRAMEN


\
\ @brief This register is used to clear the peripheral clock enable bit If TZEN = , this register can only be modified in secure mode.
\ Address offset: 0x294
\ Reset value: 0x00000000
\

$00000001 constant RCC_RCC_MC_AHB5ENCLRR_GPIOZEN                    \ GPIOZEN
$00000010 constant RCC_RCC_MC_AHB5ENCLRR_CRYP1EN                    \ CRYP1EN
$00000020 constant RCC_RCC_MC_AHB5ENCLRR_HASH1EN                    \ HASH1EN
$00000040 constant RCC_RCC_MC_AHB5ENCLRR_RNG1EN                     \ RNG1EN
$00000100 constant RCC_RCC_MC_AHB5ENCLRR_BKPSRAMEN                  \ BKPSRAMEN


\
\ @brief This register is used to set the peripheral clock enable bit
\ Address offset: 0x298
\ Reset value: 0x00000000
\

$00000001 constant RCC_RCC_MC_AHB6ENSETR_MDMAEN                     \ MDMAEN
$00000020 constant RCC_RCC_MC_AHB6ENSETR_GPUEN                      \ GPUEN
$00000080 constant RCC_RCC_MC_AHB6ENSETR_ETHCKEN                    \ ETHCKEN
$00000100 constant RCC_RCC_MC_AHB6ENSETR_ETHTXEN                    \ ETHTXEN
$00000200 constant RCC_RCC_MC_AHB6ENSETR_ETHRXEN                    \ ETHRXEN
$00000400 constant RCC_RCC_MC_AHB6ENSETR_ETHMACEN                   \ ETHMACEN
$00001000 constant RCC_RCC_MC_AHB6ENSETR_FMCEN                      \ FMCEN
$00004000 constant RCC_RCC_MC_AHB6ENSETR_QSPIEN                     \ QSPIEN
$00010000 constant RCC_RCC_MC_AHB6ENSETR_SDMMC1EN                   \ SDMMC1EN
$00020000 constant RCC_RCC_MC_AHB6ENSETR_SDMMC2EN                   \ SDMMC2EN
$00100000 constant RCC_RCC_MC_AHB6ENSETR_CRC1EN                     \ CRC1EN
$01000000 constant RCC_RCC_MC_AHB6ENSETR_USBHEN                     \ USBHEN


\
\ @brief This register is used to clear the peripheral clock enable bit
\ Address offset: 0x29C
\ Reset value: 0x00000000
\

$00000001 constant RCC_RCC_MC_AHB6ENCLRR_MDMAEN                     \ MDMAEN
$00000020 constant RCC_RCC_MC_AHB6ENCLRR_GPUEN                      \ GPUEN
$00000080 constant RCC_RCC_MC_AHB6ENCLRR_ETHCKEN                    \ ETHCKEN
$00000100 constant RCC_RCC_MC_AHB6ENCLRR_ETHTXEN                    \ ETHTXEN
$00000200 constant RCC_RCC_MC_AHB6ENCLRR_ETHRXEN                    \ ETHRXEN
$00000400 constant RCC_RCC_MC_AHB6ENCLRR_ETHMACEN                   \ ETHMACEN
$00001000 constant RCC_RCC_MC_AHB6ENCLRR_FMCEN                      \ FMCEN
$00004000 constant RCC_RCC_MC_AHB6ENCLRR_QSPIEN                     \ QSPIEN
$00010000 constant RCC_RCC_MC_AHB6ENCLRR_SDMMC1EN                   \ SDMMC1EN
$00020000 constant RCC_RCC_MC_AHB6ENCLRR_SDMMC2EN                   \ SDMMC2EN
$00100000 constant RCC_RCC_MC_AHB6ENCLRR_CRC1EN                     \ CRC1EN
$01000000 constant RCC_RCC_MC_AHB6ENCLRR_USBHEN                     \ USBHEN


\
\ @brief This register is used by the MCU in order to clear the PERxLPEN bits
\ Address offset: 0x300
\ Reset value: 0x00118111
\

$00000001 constant RCC_RCC_MP_APB4LPENSETR_LTDCLPEN                 \ LTDCLPEN
$00000010 constant RCC_RCC_MP_APB4LPENSETR_DSILPEN                  \ DSILPEN
$00000100 constant RCC_RCC_MP_APB4LPENSETR_DDRPERFMLPEN             \ DDRPERFMLPEN
$00008000 constant RCC_RCC_MP_APB4LPENSETR_IWDG2APBLPEN             \ IWDG2APBLPEN
$00010000 constant RCC_RCC_MP_APB4LPENSETR_USBPHYLPEN               \ USBPHYLPEN
$00100000 constant RCC_RCC_MP_APB4LPENSETR_STGENROLPEN              \ STGENROLPEN
$00200000 constant RCC_RCC_MP_APB4LPENSETR_STGENROSTPEN             \ STGENROSTPEN


\
\ @brief This register is used by the MCU
\ Address offset: 0x304
\ Reset value: 0x00118111
\

$00000001 constant RCC_RCC_MP_APB4LPENCLRR_LTDCLPEN                 \ LTDCLPEN
$00000010 constant RCC_RCC_MP_APB4LPENCLRR_DSILPEN                  \ DSILPEN
$00000100 constant RCC_RCC_MP_APB4LPENCLRR_DDRPERFMLPEN             \ DDRPERFMLPEN
$00008000 constant RCC_RCC_MP_APB4LPENCLRR_IWDG2APBLPEN             \ IWDG2APBLPEN
$00010000 constant RCC_RCC_MP_APB4LPENCLRR_USBPHYLPEN               \ USBPHYLPEN
$00100000 constant RCC_RCC_MP_APB4LPENCLRR_STGENROLPEN              \ STGENROLPEN
$00200000 constant RCC_RCC_MP_APB4LPENCLRR_STGENROSTPEN             \ STGENROSTPEN


\
\ @brief This register is used by the MCU in order to clear the PERxLPEN bits If TZEN = , this register can only be modified in secure mode.
\ Address offset: 0x308
\ Reset value: 0x0011391D
\

$00000001 constant RCC_RCC_MP_APB5LPENSETR_SPI6LPEN                 \ SPI6LPEN
$00000004 constant RCC_RCC_MP_APB5LPENSETR_I2C4LPEN                 \ I2C4LPEN
$00000008 constant RCC_RCC_MP_APB5LPENSETR_I2C6LPEN                 \ I2C6LPEN
$00000010 constant RCC_RCC_MP_APB5LPENSETR_USART1LPEN               \ USART1LPEN
$00000100 constant RCC_RCC_MP_APB5LPENSETR_RTCAPBLPEN               \ RTCAPBLPEN
$00000800 constant RCC_RCC_MP_APB5LPENSETR_TZC1LPEN                 \ TZC1LPEN
$00001000 constant RCC_RCC_MP_APB5LPENSETR_TZC2LPEN                 \ TZC2LPEN
$00002000 constant RCC_RCC_MP_APB5LPENSETR_TZPCLPEN                 \ TZPCLPEN
$00008000 constant RCC_RCC_MP_APB5LPENSETR_IWDG1APBLPEN             \ IWDG1APBLPEN
$00010000 constant RCC_RCC_MP_APB5LPENSETR_BSECLPEN                 \ BSECLPEN
$00100000 constant RCC_RCC_MP_APB5LPENSETR_STGENLPEN                \ STGENLPEN
$00200000 constant RCC_RCC_MP_APB5LPENSETR_STGENSTPEN               \ STGENSTPEN


\
\ @brief This register is used by the Mpu.
\ Address offset: 0x30C
\ Reset value: 0x0011391D
\

$00000001 constant RCC_RCC_MP_APB5LPENCLRR_SPI6LPEN                 \ SPI6LPEN
$00000004 constant RCC_RCC_MP_APB5LPENCLRR_I2C4LPEN                 \ I2C4LPEN
$00000008 constant RCC_RCC_MP_APB5LPENCLRR_I2C6LPEN                 \ I2C6LPEN
$00000010 constant RCC_RCC_MP_APB5LPENCLRR_USART1LPEN               \ USART1LPEN
$00000100 constant RCC_RCC_MP_APB5LPENCLRR_RTCAPBLPEN               \ RTCAPBLPEN
$00000800 constant RCC_RCC_MP_APB5LPENCLRR_TZC1LPEN                 \ TZC1LPEN
$00001000 constant RCC_RCC_MP_APB5LPENCLRR_TZC2LPEN                 \ TZC2LPEN
$00002000 constant RCC_RCC_MP_APB5LPENCLRR_TZPCLPEN                 \ TZPCLPEN
$00008000 constant RCC_RCC_MP_APB5LPENCLRR_IWDG1APBLPEN             \ IWDG1APBLPEN
$00010000 constant RCC_RCC_MP_APB5LPENCLRR_BSECLPEN                 \ BSECLPEN
$00100000 constant RCC_RCC_MP_APB5LPENCLRR_STGENLPEN                \ STGENLPEN
$00200000 constant RCC_RCC_MP_APB5LPENCLRR_STGENSTPEN               \ STGENSTPEN


\
\ @brief This register is used by the MCU in order to clear the PERxLPEN bits If TZEN = , this register can only be modified in secure mode.
\ Address offset: 0x310
\ Reset value: 0x00000171
\

$00000001 constant RCC_RCC_MP_AHB5LPENSETR_GPIOZLPEN                \ GPIOZLPEN
$00000010 constant RCC_RCC_MP_AHB5LPENSETR_CRYP1LPEN                \ CRYP1LPEN
$00000020 constant RCC_RCC_MP_AHB5LPENSETR_HASH1LPEN                \ HASH1LPEN
$00000040 constant RCC_RCC_MP_AHB5LPENSETR_RNG1LPEN                 \ RNG1LPEN
$00000100 constant RCC_RCC_MP_AHB5LPENSETR_BKPSRAMLPEN              \ BKPSRAMLPEN


\
\ @brief This register is used by the MCU
\ Address offset: 0x314
\ Reset value: 0x00000171
\

$00000001 constant RCC_RCC_MP_AHB5LPENCLRR_GPIOZLPEN                \ GPIOZLPEN
$00000010 constant RCC_RCC_MP_AHB5LPENCLRR_CRYP1LPEN                \ CRYP1LPEN
$00000020 constant RCC_RCC_MP_AHB5LPENCLRR_HASH1LPEN                \ HASH1LPEN
$00000040 constant RCC_RCC_MP_AHB5LPENCLRR_RNG1LPEN                 \ RNG1LPEN
$00000100 constant RCC_RCC_MP_AHB5LPENCLRR_BKPSRAMLPEN              \ BKPSRAMLPEN


\
\ @brief This register is used by the MCU in order to clear the PERxLPEN bits
\ Address offset: 0x318
\ Reset value: 0x011357A1
\

$00000001 constant RCC_RCC_MP_AHB6LPENSETR_MDMALPEN                 \ MDMALPEN
$00000020 constant RCC_RCC_MP_AHB6LPENSETR_GPULPEN                  \ GPULPEN
$00000080 constant RCC_RCC_MP_AHB6LPENSETR_ETHCKLPEN                \ ETHCKLPEN
$00000100 constant RCC_RCC_MP_AHB6LPENSETR_ETHTXLPEN                \ ETHTXLPEN
$00000200 constant RCC_RCC_MP_AHB6LPENSETR_ETHRXLPEN                \ ETHRXLPEN
$00000400 constant RCC_RCC_MP_AHB6LPENSETR_ETHMACLPEN               \ ETHMACLPEN
$00000800 constant RCC_RCC_MP_AHB6LPENSETR_ETHSTPEN                 \ ETHSTPEN
$00001000 constant RCC_RCC_MP_AHB6LPENSETR_FMCLPEN                  \ FMCLPEN
$00004000 constant RCC_RCC_MP_AHB6LPENSETR_QSPILPEN                 \ QSPILPEN
$00010000 constant RCC_RCC_MP_AHB6LPENSETR_SDMMC1LPEN               \ SDMMC1LPEN
$00020000 constant RCC_RCC_MP_AHB6LPENSETR_SDMMC2LPEN               \ SDMMC2LPEN
$00100000 constant RCC_RCC_MP_AHB6LPENSETR_CRC1LPEN                 \ CRC1LPEN
$01000000 constant RCC_RCC_MP_AHB6LPENSETR_USBHLPEN                 \ USBHLPEN


\
\ @brief This register is used by the MCU in order to clear the PERxLPEN bits
\ Address offset: 0x31C
\ Reset value: 0x011357A1
\

$00000001 constant RCC_RCC_MP_AHB6LPENCLRR_MDMALPEN                 \ MDMALPEN
$00000020 constant RCC_RCC_MP_AHB6LPENCLRR_GPULPEN                  \ GPULPEN
$00000080 constant RCC_RCC_MP_AHB6LPENCLRR_ETHCKLPEN                \ ETHCKLPEN
$00000100 constant RCC_RCC_MP_AHB6LPENCLRR_ETHTXLPEN                \ ETHTXLPEN
$00000200 constant RCC_RCC_MP_AHB6LPENCLRR_ETHRXLPEN                \ ETHRXLPEN
$00000400 constant RCC_RCC_MP_AHB6LPENCLRR_ETHMACLPEN               \ ETHMACLPEN
$00000800 constant RCC_RCC_MP_AHB6LPENCLRR_ETHSTPEN                 \ ETHSTPEN
$00001000 constant RCC_RCC_MP_AHB6LPENCLRR_FMCLPEN                  \ FMCLPEN
$00004000 constant RCC_RCC_MP_AHB6LPENCLRR_QSPILPEN                 \ QSPILPEN
$00010000 constant RCC_RCC_MP_AHB6LPENCLRR_SDMMC1LPEN               \ SDMMC1LPEN
$00020000 constant RCC_RCC_MP_AHB6LPENCLRR_SDMMC2LPEN               \ SDMMC2LPEN
$00100000 constant RCC_RCC_MP_AHB6LPENCLRR_CRC1LPEN                 \ CRC1LPEN
$01000000 constant RCC_RCC_MP_AHB6LPENCLRR_USBHLPEN                 \ USBHLPEN


\
\ @brief This register is used by the MCU in order to clear the PERxLPEN bits If TZEN = , this register can only be modified in secure mode.
\ Address offset: 0x320
\ Reset value: 0x00000001
\

$00000001 constant RCC_RCC_MP_TZAHB6LPENSETR_MDMALPEN               \ MDMALPEN


\
\ @brief This register is used by the MCU in order to clear the PERxLPEN bits If TZEN = , this register can only be modified in secure mode.
\ Address offset: 0x324
\ Reset value: 0x00000001
\

$00000001 constant RCC_RCC_MP_TZAHB6LPENCLRR_MDMALPEN               \ MDMALPEN


\
\ @brief This register is used by the MCU in order to set the PERxLPEN bit.
\ Address offset: 0x380
\ Reset value: 0x00110111
\

$00000001 constant RCC_RCC_MC_APB4LPENSETR_LTDCLPEN                 \ LTDCLPEN
$00000010 constant RCC_RCC_MC_APB4LPENSETR_DSILPEN                  \ DSILPEN
$00000100 constant RCC_RCC_MC_APB4LPENSETR_DDRPERFMLPEN             \ DDRPERFMLPEN
$00010000 constant RCC_RCC_MC_APB4LPENSETR_USBPHYLPEN               \ USBPHYLPEN
$00100000 constant RCC_RCC_MC_APB4LPENSETR_STGENROLPEN              \ STGENROLPEN
$00200000 constant RCC_RCC_MC_APB4LPENSETR_STGENROSTPEN             \ STGENROSTPEN


\
\ @brief This register is used by the MCU in order to clear the PERxLPEN bit
\ Address offset: 0x384
\ Reset value: 0x00110111
\

$00000001 constant RCC_RCC_MC_APB4LPENCLRR_LTDCLPEN                 \ LTDCLPEN
$00000010 constant RCC_RCC_MC_APB4LPENCLRR_DSILPEN                  \ DSILPEN
$00000100 constant RCC_RCC_MC_APB4LPENCLRR_DDRPERFMLPEN             \ DDRPERFMLPEN
$00010000 constant RCC_RCC_MC_APB4LPENCLRR_USBPHYLPEN               \ USBPHYLPEN
$00100000 constant RCC_RCC_MC_APB4LPENCLRR_STGENROLPEN              \ STGENROLPEN
$00200000 constant RCC_RCC_MC_APB4LPENCLRR_STGENROSTPEN             \ STGENROSTPEN


\
\ @brief This register is used by the MCU in order to set the PERxLPEN bit.
\ Address offset: 0x388
\ Reset value: 0x0011391D
\

$00000001 constant RCC_RCC_MC_APB5LPENSETR_SPI6LPEN                 \ SPI6LPEN
$00000004 constant RCC_RCC_MC_APB5LPENSETR_I2C4LPEN                 \ I2C4LPEN
$00000008 constant RCC_RCC_MC_APB5LPENSETR_I2C6LPEN                 \ I2C6LPEN
$00000010 constant RCC_RCC_MC_APB5LPENSETR_USART1LPEN               \ USART1LPEN
$00000100 constant RCC_RCC_MC_APB5LPENSETR_RTCAPBLPEN               \ RTCAPBLPEN
$00000800 constant RCC_RCC_MC_APB5LPENSETR_TZC1LPEN                 \ TZC1LPEN
$00001000 constant RCC_RCC_MC_APB5LPENSETR_TZC2LPEN                 \ TZC2LPEN
$00002000 constant RCC_RCC_MC_APB5LPENSETR_TZPCLPEN                 \ TZPCLPEN
$00010000 constant RCC_RCC_MC_APB5LPENSETR_BSECLPEN                 \ BSECLPEN
$00100000 constant RCC_RCC_MC_APB5LPENSETR_STGENLPEN                \ STGENLPEN
$00200000 constant RCC_RCC_MC_APB5LPENSETR_STGENSTPEN               \ STGENSTPEN


\
\ @brief This register is used by the MCU in order to clear the PERxLPEN bit
\ Address offset: 0x38C
\ Reset value: 0x0011391D
\

$00000001 constant RCC_RCC_MC_APB5LPENCLRR_SPI6LPEN                 \ SPI6LPEN
$00000004 constant RCC_RCC_MC_APB5LPENCLRR_I2C4LPEN                 \ I2C4LPEN
$00000008 constant RCC_RCC_MC_APB5LPENCLRR_I2C6LPEN                 \ I2C6LPEN
$00000010 constant RCC_RCC_MC_APB5LPENCLRR_USART1LPEN               \ USART1LPEN
$00000100 constant RCC_RCC_MC_APB5LPENCLRR_RTCAPBLPEN               \ RTCAPBLPEN
$00000800 constant RCC_RCC_MC_APB5LPENCLRR_TZC1LPEN                 \ TZC1LPEN
$00001000 constant RCC_RCC_MC_APB5LPENCLRR_TZC2LPEN                 \ TZC2LPEN
$00002000 constant RCC_RCC_MC_APB5LPENCLRR_TZPCLPEN                 \ TZPCLPEN
$00010000 constant RCC_RCC_MC_APB5LPENCLRR_BSECLPEN                 \ BSECLPEN
$00100000 constant RCC_RCC_MC_APB5LPENCLRR_STGENLPEN                \ STGENLPEN
$00200000 constant RCC_RCC_MC_APB5LPENCLRR_STGENSTPEN               \ STGENSTPEN


\
\ @brief This register is used by the MCU in order to set the PERxLPEN bit. If TZEN = , this register can only be modified in secure mode.
\ Address offset: 0x390
\ Reset value: 0x00000171
\

$00000001 constant RCC_RCC_MC_AHB5LPENSETR_GPIOZLPEN                \ GPIOZLPEN
$00000010 constant RCC_RCC_MC_AHB5LPENSETR_CRYP1LPEN                \ CRYP1LPEN
$00000020 constant RCC_RCC_MC_AHB5LPENSETR_HASH1LPEN                \ HASH1LPEN
$00000040 constant RCC_RCC_MC_AHB5LPENSETR_RNG1LPEN                 \ RNG1LPEN
$00000100 constant RCC_RCC_MC_AHB5LPENSETR_BKPSRAMLPEN              \ BKPSRAMLPEN


\
\ @brief This register is used by the MCU in order to clear the PERxLPEN bit If TZEN = , this register can only be modified in secure mode.
\ Address offset: 0x394
\ Reset value: 0x00000171
\

$00000001 constant RCC_RCC_MC_AHB5LPENCLRR_GPIOZLPEN                \ GPIOZLPEN
$00000010 constant RCC_RCC_MC_AHB5LPENCLRR_CRYP1LPEN                \ CRYP1LPEN
$00000020 constant RCC_RCC_MC_AHB5LPENCLRR_HASH1LPEN                \ HASH1LPEN
$00000040 constant RCC_RCC_MC_AHB5LPENCLRR_RNG1LPEN                 \ RNG1LPEN
$00000100 constant RCC_RCC_MC_AHB5LPENCLRR_BKPSRAMLPEN              \ BKPSRAMLPEN


\
\ @brief This register is used by the MCU in order to set the PERxLPEN bit.
\ Address offset: 0x398
\ Reset value: 0x011357A1
\

$00000001 constant RCC_RCC_MC_AHB6LPENSETR_MDMALPEN                 \ MDMALPEN
$00000020 constant RCC_RCC_MC_AHB6LPENSETR_GPULPEN                  \ GPULPEN
$00000080 constant RCC_RCC_MC_AHB6LPENSETR_ETHCKLPEN                \ ETHCKLPEN
$00000100 constant RCC_RCC_MC_AHB6LPENSETR_ETHTXLPEN                \ ETHTXLPEN
$00000200 constant RCC_RCC_MC_AHB6LPENSETR_ETHRXLPEN                \ ETHRXLPEN
$00000400 constant RCC_RCC_MC_AHB6LPENSETR_ETHMACLPEN               \ ETHMACLPEN
$00000800 constant RCC_RCC_MC_AHB6LPENSETR_ETHSTPEN                 \ ETHSTPEN
$00001000 constant RCC_RCC_MC_AHB6LPENSETR_FMCLPEN                  \ FMCLPEN
$00004000 constant RCC_RCC_MC_AHB6LPENSETR_QSPILPEN                 \ QSPILPEN
$00010000 constant RCC_RCC_MC_AHB6LPENSETR_SDMMC1LPEN               \ SDMMC1LPEN
$00020000 constant RCC_RCC_MC_AHB6LPENSETR_SDMMC2LPEN               \ SDMMC2LPEN
$00100000 constant RCC_RCC_MC_AHB6LPENSETR_CRC1LPEN                 \ CRC1LPEN
$01000000 constant RCC_RCC_MC_AHB6LPENSETR_USBHLPEN                 \ USBHLPEN


\
\ @brief This register is used by the MCU in order to clear the PERxLPEN bit
\ Address offset: 0x39C
\ Reset value: 0x011357A1
\

$00000001 constant RCC_RCC_MC_AHB6LPENCLRR_MDMALPEN                 \ MDMALPEN
$00000020 constant RCC_RCC_MC_AHB6LPENCLRR_GPULPEN                  \ GPULPEN
$00000080 constant RCC_RCC_MC_AHB6LPENCLRR_ETHCKLPEN                \ ETHCKLPEN
$00000100 constant RCC_RCC_MC_AHB6LPENCLRR_ETHTXLPEN                \ ETHTXLPEN
$00000200 constant RCC_RCC_MC_AHB6LPENCLRR_ETHRXLPEN                \ ETHRXLPEN
$00000400 constant RCC_RCC_MC_AHB6LPENCLRR_ETHMACLPEN               \ ETHMACLPEN
$00000800 constant RCC_RCC_MC_AHB6LPENCLRR_ETHSTPEN                 \ ETHSTPEN
$00001000 constant RCC_RCC_MC_AHB6LPENCLRR_FMCLPEN                  \ FMCLPEN
$00004000 constant RCC_RCC_MC_AHB6LPENCLRR_QSPILPEN                 \ QSPILPEN
$00010000 constant RCC_RCC_MC_AHB6LPENCLRR_SDMMC1LPEN               \ SDMMC1LPEN
$00020000 constant RCC_RCC_MC_AHB6LPENCLRR_SDMMC2LPEN               \ SDMMC2LPEN
$00100000 constant RCC_RCC_MC_AHB6LPENCLRR_CRC1LPEN                 \ CRC1LPEN
$01000000 constant RCC_RCC_MC_AHB6LPENCLRR_USBHLPEN                 \ USBHLPEN


\
\ @brief This register is used by the BOOTROM to check the reset source. Writing has no effect, reading will return the effective values of the corresponding bits. Writing a clears the corresponding bit to . In order to identify the reset source, the MPU application must use RCC MPU Reset Status Clear Register (RCC_MP_RSTSCLRR), and the MCU application must use the RCC MCU Reset Status Clear Register (RCC_MC_RSTSCLRR). Refer to Section10.3.13: Reset source identification for details.This register except MPUP[1:0]RSTF flags is located into VDD domain, and is reset by por_rst reset. The MPUP[1:0]RSTF flags are located into VDDCORE and are reset by nreset. If TZEN = , this register can only be modified in secure mode.
\ Address offset: 0x400
\ Reset value: 0x00000015
\

$00000001 constant RCC_RCC_BR_RSTSCLRR_PORRSTF                      \ PORRSTF
$00000002 constant RCC_RCC_BR_RSTSCLRR_BORRSTF                      \ BORRSTF
$00000004 constant RCC_RCC_BR_RSTSCLRR_PADRSTF                      \ PADRSTF
$00000008 constant RCC_RCC_BR_RSTSCLRR_HCSSRSTF                     \ HCSSRSTF
$00000010 constant RCC_RCC_BR_RSTSCLRR_VCORERSTF                    \ VCORERSTF
$00000040 constant RCC_RCC_BR_RSTSCLRR_MPSYSRSTF                    \ MPSYSRSTF
$00000080 constant RCC_RCC_BR_RSTSCLRR_MCSYSRSTF                    \ MCSYSRSTF
$00000100 constant RCC_RCC_BR_RSTSCLRR_IWDG1RSTF                    \ IWDG1RSTF
$00000200 constant RCC_RCC_BR_RSTSCLRR_IWDG2RSTF                    \ IWDG2RSTF
$00002000 constant RCC_RCC_BR_RSTSCLRR_MPUP0RSTF                    \ MPUP0RSTF
$00004000 constant RCC_RCC_BR_RSTSCLRR_MPUP1RSTF                    \ MPUP1RSTF


\
\ @brief This register is used by the MPU in order to generate either a MCU reset or a system reset or a reset of one of the two MPU processors. Writing has no effect, reading returns the effective values of the corresponding bits. Writing a activates the reset.
\ Address offset: 0x404
\ Reset value: 0x00000000
\

$00000001 constant RCC_RCC_MP_GRSTCSETR_MPSYSRST                    \ MPSYSRST
$00000002 constant RCC_RCC_MP_GRSTCSETR_MCURST                      \ MCURST
$00000010 constant RCC_RCC_MP_GRSTCSETR_MPUP0RST                    \ MPUP0RST
$00000020 constant RCC_RCC_MP_GRSTCSETR_MPUP1RST                    \ MPUP1RST


\
\ @brief This register is used by the MPU to check the reset source. This register is updated by the BOOTROM code, after a power-on reset (por_rst), a system reset (nreset), or an exit from Standby or CStandby.Writing has no effect, reading will return the effective values of the corresponding bits. Writing a clears the corresponding bit to .Refer to Section10.3.13: Reset source identification for details.The register is located in VDDCORE.If TZEN = , this register can only be modified in secure mode.
\ Address offset: 0x408
\ Reset value: 0x00000000
\

$00000001 constant RCC_RCC_MP_RSTSCLRR_PORRSTF                      \ PORRSTF
$00000002 constant RCC_RCC_MP_RSTSCLRR_BORRSTF                      \ BORRSTF
$00000004 constant RCC_RCC_MP_RSTSCLRR_PADRSTF                      \ PADRSTF
$00000008 constant RCC_RCC_MP_RSTSCLRR_HCSSRSTF                     \ HCSSRSTF
$00000010 constant RCC_RCC_MP_RSTSCLRR_VCORERSTF                    \ VCORERSTF
$00000040 constant RCC_RCC_MP_RSTSCLRR_MPSYSRSTF                    \ MPSYSRSTF
$00000080 constant RCC_RCC_MP_RSTSCLRR_MCSYSRSTF                    \ MCSYSRSTF
$00000100 constant RCC_RCC_MP_RSTSCLRR_IWDG1RSTF                    \ IWDG1RSTF
$00000200 constant RCC_RCC_MP_RSTSCLRR_IWDG2RSTF                    \ IWDG2RSTF
$00000800 constant RCC_RCC_MP_RSTSCLRR_STDBYRSTF                    \ STDBYRSTF
$00001000 constant RCC_RCC_MP_RSTSCLRR_CSTDBYRSTF                   \ CSTDBYRSTF
$00002000 constant RCC_RCC_MP_RSTSCLRR_MPUP0RSTF                    \ MPUP0RSTF
$00004000 constant RCC_RCC_MP_RSTSCLRR_MPUP1RSTF                    \ MPUP1RSTF
$00008000 constant RCC_RCC_MP_RSTSCLRR_SPARE                        \ SPARE


\
\ @brief This register is used by the BOOTROM in order to freeze the IWDGs clocks. After a system reset or Standby reset (nreset), or a CStandby reset (cstby_rst) the MPU is allowed to write it once.Writing has no effect, reading will return the effective values of the corresponding bits. Writing a sets the corresponding bit to . If TZEN = , this register can only be modified in secure mode.
\ Address offset: 0x40C
\ Reset value: 0x00000000
\

$00000001 constant RCC_RCC_MP_IWDGFZSETR_FZ_IWDG1                   \ FZ_IWDG1
$00000002 constant RCC_RCC_MP_IWDGFZSETR_FZ_IWDG2                   \ FZ_IWDG2


\
\ @brief This register is used by the BOOTROM in order to unfreeze the IWDGs clocks. Writing has no effect, reading will return the effective values of the corresponding bits. Writing a clears the corresponding bit to . If TZEN = , this register can only be modified in secure mode.
\ Address offset: 0x410
\ Reset value: 0x00000000
\

$00000001 constant RCC_RCC_MP_IWDGFZCLRR_FZ_IWDG1                   \ FZ_IWDG1
$00000002 constant RCC_RCC_MP_IWDGFZCLRR_FZ_IWDG2                   \ FZ_IWDG2


\
\ @brief This register shall be used by the MPU to control the interrupt source enable. Refer to Section10.5: RCC interrupts for more details. If TZEN = , this register can only be modified in secure mode.
\ Address offset: 0x414
\ Reset value: 0x00000000
\

$00000001 constant RCC_RCC_MP_CIER_LSIRDYIE                         \ LSIRDYIE
$00000002 constant RCC_RCC_MP_CIER_LSERDYIE                         \ LSERDYIE
$00000004 constant RCC_RCC_MP_CIER_HSIRDYIE                         \ HSIRDYIE
$00000008 constant RCC_RCC_MP_CIER_HSERDYIE                         \ HSERDYIE
$00000010 constant RCC_RCC_MP_CIER_CSIRDYIE                         \ CSIRDYIE
$00000100 constant RCC_RCC_MP_CIER_PLL1DYIE                         \ PLL1DYIE
$00000200 constant RCC_RCC_MP_CIER_PLL2DYIE                         \ PLL2DYIE
$00000400 constant RCC_RCC_MP_CIER_PLL3DYIE                         \ PLL3DYIE
$00000800 constant RCC_RCC_MP_CIER_PLL4DYIE                         \ PLL4DYIE
$00010000 constant RCC_RCC_MP_CIER_LSECSSIE                         \ LSECSSIE
$00100000 constant RCC_RCC_MP_CIER_WKUPIE                           \ WKUPIE


\
\ @brief This register shall be used by the MPU in order to read and clear the interrupt flags.Writing has no effect, writing will clear the corresponding flag.Refer to Section10.5: RCC interrupts for more details. If TZEN = , this register can only be modified in secure mode.
\ Address offset: 0x418
\ Reset value: 0x00000000
\

$00000001 constant RCC_RCC_MP_CIFR_LSIRDYF                          \ LSIRDYF
$00000002 constant RCC_RCC_MP_CIFR_LSERDYF                          \ LSERDYF
$00000004 constant RCC_RCC_MP_CIFR_HSIRDYF                          \ HSIRDYF
$00000008 constant RCC_RCC_MP_CIFR_HSERDYF                          \ HSERDYF
$00000010 constant RCC_RCC_MP_CIFR_CSIRDYF                          \ CSIRDYF
$00000100 constant RCC_RCC_MP_CIFR_PLL1DYF                          \ PLL1DYF
$00000200 constant RCC_RCC_MP_CIFR_PLL2DYF                          \ PLL2DYF
$00000400 constant RCC_RCC_MP_CIFR_PLL3DYF                          \ PLL3DYF
$00000800 constant RCC_RCC_MP_CIFR_PLL4DYF                          \ PLL4DYF
$00010000 constant RCC_RCC_MP_CIFR_LSECSSF                          \ LSECSSF
$00100000 constant RCC_RCC_MP_CIFR_WKUPF                            \ WKUPF


\
\ @brief This register is used to program the delay between the moment where the system exits from one of the Stop modes, and the moment where it is allowed to enable the PLLs and provide a clock to bridges and processors. If TZEN = , this register can only be modified in secure mode.
\ Address offset: 0x41C
\ Reset value: 0x00000000
\

$003fffff constant RCC_RCC_PWRLPDLYCR_PWRLP_DLY                     \ PWRLP_DLY
$01000000 constant RCC_RCC_PWRLPDLYCR_MCTMPSKP                      \ MCTMPSKP


\
\ @brief This register is dedicated to the BOOTROM code in order to update the reset source. This register is updated by the BOOTROM code, after a power-on reset (por_rst), a system reset (nreset), or an exit from Standby or CStandby. The application software shall not use this register. In order to identify the reset source, the MPU application must use RCC MPU Reset Status Clear Register (RCC_MP_RSTSCLRR), and the MCU application must use the RCC MCU Reset Status Clear Register (RCC_MC_RSTSCLRR).Writing has no effect, reading will return the effective values of the corresponding bits. Writing a sets the corresponding bit to .Refer to Section10.3.13: Reset source identification for details.The register is located in VDDCORE.If TZEN = , this register can only be modified in secure mode.
\ Address offset: 0x420
\ Reset value: 0x00000000
\

$00000001 constant RCC_RCC_MP_RSTSSETR_PORRSTF                      \ PORRSTF
$00000002 constant RCC_RCC_MP_RSTSSETR_BORRSTF                      \ BORRSTF
$00000004 constant RCC_RCC_MP_RSTSSETR_PADRSTF                      \ PADRSTF
$00000008 constant RCC_RCC_MP_RSTSSETR_HCSSRSTF                     \ HCSSRSTF
$00000010 constant RCC_RCC_MP_RSTSSETR_VCORERSTF                    \ VCORERSTF
$00000040 constant RCC_RCC_MP_RSTSSETR_MPSYSRSTF                    \ MPSYSRSTF
$00000080 constant RCC_RCC_MP_RSTSSETR_MCSYSRSTF                    \ MCSYSRSTF
$00000100 constant RCC_RCC_MP_RSTSSETR_IWDG1RSTF                    \ IWDG1RSTF
$00000200 constant RCC_RCC_MP_RSTSSETR_IWDG2RSTF                    \ IWDG2RSTF
$00000800 constant RCC_RCC_MP_RSTSSETR_STDBYRSTF                    \ STDBYRSTF
$00001000 constant RCC_RCC_MP_RSTSSETR_CSTDBYRSTF                   \ CSTDBYRSTF
$00002000 constant RCC_RCC_MP_RSTSSETR_MPUP0RSTF                    \ MPUP0RSTF
$00004000 constant RCC_RCC_MP_RSTSSETR_MPUP1RSTF                    \ MPUP1RSTF
$00008000 constant RCC_RCC_MP_RSTSSETR_SPARE                        \ SPARE


\
\ @brief This register is used to select the clock generated on MCO1 output.
\ Address offset: 0x800
\ Reset value: 0x00000000
\

$00000007 constant RCC_RCC_MCO1CFGR_MCO1SEL                         \ MCO1SEL
$000000f0 constant RCC_RCC_MCO1CFGR_MCO1DIV                         \ MCO1DIV
$00001000 constant RCC_RCC_MCO1CFGR_MCO1ON                          \ MCO1ON


\
\ @brief This register is used to select the clock generated on MCO2 output.
\ Address offset: 0x804
\ Reset value: 0x00000000
\

$00000007 constant RCC_RCC_MCO2CFGR_MCO2SEL                         \ MCO2SEL
$000000f0 constant RCC_RCC_MCO2CFGR_MCO2DIV                         \ MCO2DIV
$00001000 constant RCC_RCC_MCO2CFGR_MCO2ON                          \ MCO2ON


\
\ @brief This is a read-only access register, It contains the status flags of oscillators. Writing has no effect.
\ Address offset: 0x808
\ Reset value: 0x00000000
\

$00000001 constant RCC_RCC_OCRDYR_HSIRDY                            \ HSIRDY
$00000004 constant RCC_RCC_OCRDYR_HSIDIVRDY                         \ HSIDIVRDY
$00000010 constant RCC_RCC_OCRDYR_CSIRDY                            \ CSIRDY
$00000100 constant RCC_RCC_OCRDYR_HSERDY                            \ HSERDY
$00800000 constant RCC_RCC_OCRDYR_MPUCKRDY                          \ MPUCKRDY
$01000000 constant RCC_RCC_OCRDYR_AXICKRDY                          \ AXICKRDY
$02000000 constant RCC_RCC_OCRDYR_CKREST                            \ CKREST


\
\ @brief This is register contains the enable control of the debug and trace function, and the clock divider for the trace function.
\ Address offset: 0x80C
\ Reset value: 0x00000001
\

$00000007 constant RCC_RCC_DBGCFGR_TRACEDIV                         \ TRACEDIV
$00000100 constant RCC_RCC_DBGCFGR_DBGCKEN                          \ DBGCKEN
$00000200 constant RCC_RCC_DBGCFGR_TRACECKEN                        \ TRACECKEN
$00001000 constant RCC_RCC_DBGCFGR_DBGRST                           \ DBGRST


\
\ @brief This register is used to select the reference clock for PLL3. If TZEN = MCKPROT = , this register can only be modified in secure mode.
\ Address offset: 0x820
\ Reset value: 0x80000000
\

$00000003 constant RCC_RCC_RCK3SELR_PLL3SRC                         \ PLL3SRC
$80000000 constant RCC_RCC_RCK3SELR_PLL3SRCRDY                      \ PLL3SRCRDY


\
\ @brief This register is used to select the reference clock for PLL4.
\ Address offset: 0x824
\ Reset value: 0x80000000
\

$00000003 constant RCC_RCC_RCK4SELR_PLL4SRC                         \ PLL4SRC
$80000000 constant RCC_RCC_RCK4SELR_PLL4SRCRDY                      \ PLL4SRCRDY


\
\ @brief This register is used to control the prescaler value of timers located into APB1 domain. It concerns TIM2, TIM3, TIM4, TIM5, TIM6, TIM7, TIM12, TIM13 and TIM14. Refer to Section: Sub-system clock generation for additional information.
\ Address offset: 0x828
\ Reset value: 0x80000000
\

$00000001 constant RCC_RCC_TIMG1PRER_TIMG1PRE                       \ TIMG1PRE
$80000000 constant RCC_RCC_TIMG1PRER_TIMG1PRERDY                    \ TIMG1PRERDY


\
\ @brief This register is used to control the prescaler value of timers located into APB2 domain. It concerns TIM1, TIM8, TIM15, TIM16, and TIM17. Refer to Section: Sub-system clock generation for additional information.
\ Address offset: 0x82C
\ Reset value: 0x80000000
\

$00000001 constant RCC_RCC_TIMG2PRER_TIMG2PRE                       \ TIMG2PRE
$80000000 constant RCC_RCC_TIMG2PRER_TIMG2PRERDY                    \ TIMG2PRERDY


\
\ @brief This register is used to control the MCU sub-system clock prescaler. Refer to Section: Sub-system clock generation for additional information. If TZEN = , this register can only be modified in secure mode.
\ Address offset: 0x830
\ Reset value: 0x80000000
\

$0000000f constant RCC_RCC_MCUDIVR_MCUDIV                           \ MCUDIV
$80000000 constant RCC_RCC_MCUDIVR_MCUDIVRDY                        \ MCUDIVRDY


\
\ @brief This register is used to control the APB1 clock prescaler. Refer to section Section1.4.6.3: Sub-System Clock Generation for additional information.
\ Address offset: 0x834
\ Reset value: 0x80000000
\

$00000007 constant RCC_RCC_APB1DIVR_APB1DIV                         \ APB1DIV
$80000000 constant RCC_RCC_APB1DIVR_APB1DIVRDY                      \ APB1DIVRDY


\
\ @brief This register is used to control the APB2 clock prescaler. Refer to Section: Sub-system clock generation for additional information.
\ Address offset: 0x838
\ Reset value: 0x80000000
\

$00000007 constant RCC_RCC_APB2DIVR_APB2DIV                         \ APB2DIV
$80000000 constant RCC_RCC_APB2DIVR_APB2DIVRDY                      \ APB2DIVRDY


\
\ @brief This register is used to control the APB3 clock prescaler. Refer to Section: Sub-system clock generation for additional information.
\ Address offset: 0x83C
\ Reset value: 0x80000000
\

$00000007 constant RCC_RCC_APB3DIVR_APB3DIV                         \ APB3DIV
$80000000 constant RCC_RCC_APB3DIVR_APB3DIVRDY                      \ APB3DIVRDY


\
\ @brief This register is used to control the PLL3. If TZEN = MCKPROT = , this register can only be modified in secure mode.
\ Address offset: 0x880
\ Reset value: 0x00000000
\

$00000001 constant RCC_RCC_PLL3CR_PLLON                             \ PLLON
$00000002 constant RCC_RCC_PLL3CR_PLL3RDY                           \ PLL3RDY
$00000004 constant RCC_RCC_PLL3CR_SSCG_CTRL                         \ SSCG_CTRL
$00000010 constant RCC_RCC_PLL3CR_DIVPEN                            \ DIVPEN
$00000020 constant RCC_RCC_PLL3CR_DIVQEN                            \ DIVQEN
$00000040 constant RCC_RCC_PLL3CR_DIVREN                            \ DIVREN


\
\ @brief This register is used to configure the PLL3. If TZEN = MCKPROT = , this register can only be modified in secure mode.
\ Address offset: 0x884
\ Reset value: 0x00010031
\

$000001ff constant RCC_RCC_PLL3CFGR1_DIVN                           \ DIVN
$003f0000 constant RCC_RCC_PLL3CFGR1_DIVM3                          \ DIVM3
$03000000 constant RCC_RCC_PLL3CFGR1_IFRGE                          \ IFRGE


\
\ @brief This register is used to configure the PLL3. If TZEN = MCKPROT = , this register can only be modified in secure mode.
\ Address offset: 0x888
\ Reset value: 0x00010101
\

$0000007f constant RCC_RCC_PLL3CFGR2_DIVP                           \ DIVP
$00007f00 constant RCC_RCC_PLL3CFGR2_DIVQ                           \ DIVQ
$007f0000 constant RCC_RCC_PLL3CFGR2_DIVR                           \ DIVR


\
\ @brief This register is used to fine-tune the frequency of the PLL3 VCO. If TZEN = MCKPROT = , this register can only be modified in secure mode.
\ Address offset: 0x88C
\ Reset value: 0x00000000
\

$0000fff8 constant RCC_RCC_PLL3FRACR_FRACV                          \ FRACV
$00010000 constant RCC_RCC_PLL3FRACR_FRACLE                         \ FRACLE


\
\ @brief This register is used to configure the PLL3.It is not recommended to change the content of this register when the PLL3 is enabled (PLLON = ). Refer to Section: Using the PLLs in spread spectrum mode for details. If TZEN = MCKPROT = , this register can only be modified in secure mode.
\ Address offset: 0x890
\ Reset value: 0x00000000
\

$00001fff constant RCC_RCC_PLL3CSGR_MOD_PER                         \ MOD_PER
$00002000 constant RCC_RCC_PLL3CSGR_TPDFN_DIS                       \ TPDFN_DIS
$00004000 constant RCC_RCC_PLL3CSGR_RPDFN_DIS                       \ RPDFN_DIS
$00008000 constant RCC_RCC_PLL3CSGR_SSCG_MODE                       \ SSCG_MODE
$7fff0000 constant RCC_RCC_PLL3CSGR_INC_STEP                        \ INC_STEP


\
\ @brief This register is used to control the PLL4.
\ Address offset: 0x894
\ Reset value: 0x00000000
\

$00000001 constant RCC_RCC_PLL4CR_PLLON                             \ PLLON
$00000002 constant RCC_RCC_PLL4CR_PLL4RDY                           \ PLL4RDY
$00000004 constant RCC_RCC_PLL4CR_SSCG_CTRL                         \ SSCG_CTRL
$00000010 constant RCC_RCC_PLL4CR_DIVPEN                            \ DIVPEN
$00000020 constant RCC_RCC_PLL4CR_DIVQEN                            \ DIVQEN
$00000040 constant RCC_RCC_PLL4CR_DIVREN                            \ DIVREN


\
\ @brief This register is used to configure the PLL4.
\ Address offset: 0x898
\ Reset value: 0x00010031
\

$000001ff constant RCC_RCC_PLL4CFGR1_DIVN                           \ DIVN
$003f0000 constant RCC_RCC_PLL4CFGR1_DIVM4                          \ DIVM4
$03000000 constant RCC_RCC_PLL4CFGR1_IFRGE                          \ IFRGE


\
\ @brief This register is used to configure the PLL4.
\ Address offset: 0x89C
\ Reset value: 0x00000000
\

$0000007f constant RCC_RCC_PLL4CFGR2_DIVP                           \ DIVP
$00007f00 constant RCC_RCC_PLL4CFGR2_DIVQ                           \ DIVQ
$007f0000 constant RCC_RCC_PLL4CFGR2_DIVR                           \ DIVR


\
\ @brief This register is used to fine-tune the frequency of the PLL4 VCO.
\ Address offset: 0x8A0
\ Reset value: 0x00000000
\

$0000fff8 constant RCC_RCC_PLL4FRACR_FRACV                          \ FRACV
$00010000 constant RCC_RCC_PLL4FRACR_FRACLE                         \ FRACLE


\
\ @brief This register is used to configure the PLL4.It is not recommended to change the content of this register when the PLL4 is enabled (PLLON = ). Refer to Section: Using the PLLs in spread spectrum mode for details. If TZEN = MCKPROT = , this register can only be modified in secure mode.
\ Address offset: 0x8A4
\ Reset value: 0x00000000
\

$00001fff constant RCC_RCC_PLL4CSGR_MOD_PER                         \ MOD_PER
$00002000 constant RCC_RCC_PLL4CSGR_TPDFN_DIS                       \ TPDFN_DIS
$00004000 constant RCC_RCC_PLL4CSGR_RPDFN_DIS                       \ RPDFN_DIS
$00008000 constant RCC_RCC_PLL4CSGR_SSCG_MODE                       \ SSCG_MODE
$7fff0000 constant RCC_RCC_PLL4CSGR_INC_STEP                        \ INC_STEP


\
\ @brief This register is used to control the selection of the kernel clock for the I2C1 and I2C2. Note that changing the clock source on-the-fly is allowed, and will not generate any timing violation, however the user has to ensure that both the previous and the new clock sources are present during the switching, and for the whole transition time. Refer to Section: Clock enabling delays.
\ Address offset: 0x8C0
\ Reset value: 0x00000000
\

$00000007 constant RCC_RCC_I2C12CKSELR_I2C12SRC                     \ I2C12SRC


\
\ @brief This register is used to control the selection of the kernel clock for the I2C3 and I2C5. Note that changing the clock source on-the-fly is allowed, and will not generate any timing violation, however the user has to ensure that both the previous and the new clock sources are present during the switching, and for the whole transition time. Refer to Section: Clock enabling delays.
\ Address offset: 0x8C4
\ Reset value: 0x00000000
\

$00000007 constant RCC_RCC_I2C35CKSELR_I2C35SRC                     \ I2C35SRC


\
\ @brief This register is used to control the selection of the kernel clock for the SAI1 and DFSDM audio clock. Note that changing the clock source on-the-fly is allowed, and will not generate any timing violation, however the user has to ensure that both the previous and the new clock sources are present during the switching, and for the whole transition time. Refer to Section: Clock enabling delays.
\ Address offset: 0x8C8
\ Reset value: 0x00000000
\

$00000007 constant RCC_RCC_SAI1CKSELR_SAI1SRC                       \ SAI1SRC


\
\ @brief This register is used to control the selection of the kernel clock for the SAI2. Note that changing the clock source on-the-fly is allowed, and will not generate any timing violation, however the user has to ensure that both the previous and the new clock sources are present during the switching, and for the whole transition time. Refer to Section: Clock enabling delays.
\ Address offset: 0x8CC
\ Reset value: 0x00000000
\

$00000007 constant RCC_RCC_SAI2CKSELR_SAI2SRC                       \ SAI2SRC


\
\ @brief This register is used to control the selection of the kernel clock for the SAI3. Note that changing the clock source on-the-fly is allowed, and will not generate any timing violation, however the user has to ensure that both the previous and the new clock sources are present during the switching, and for the whole transition time. Refer to Section: Clock enabling delays.
\ Address offset: 0x8D0
\ Reset value: 0x00000000
\

$00000007 constant RCC_RCC_SAI3CKSELR_SAI3SRC                       \ SAI3SRC


\
\ @brief This register is used to control the selection of the kernel clock for the SAI4. Note that changing the clock source on-the-fly is allowed, and will not generate any timing violation, however the user has to ensure that both the previous and the new clock sources are present during the switching, and for the whole transition time. Refer to Section: Clock enabling delays.
\ Address offset: 0x8D4
\ Reset value: 0x00000000
\

$00000007 constant RCC_RCC_SAI4CKSELR_SAI4SRC                       \ SAI4SRC


\
\ @brief This register is used to control the selection of the kernel clock for the SPI/I2S1. Note that changing the clock source on-the-fly is allowed, and will not generate any timing violation, however the user has to ensure that both the previous and the new clock sources are present during the switching, and for the whole transition time. Refer to Section: Clock enabling delays.
\ Address offset: 0x8D8
\ Reset value: 0x00000000
\

$00000007 constant RCC_RCC_SPI2S1CKSELR_SPI1SRC                     \ SPI1SRC


\
\ @brief This register is used to control the selection of the kernel clock for the SPI/I2S2,3. Note that changing the clock source on-the-fly is allowed, and will not generate any timing violation, however the user has to ensure that both the previous and the new clock sources are present during the switching, and for the whole transition time. Refer to Section: Clock enabling delays.
\ Address offset: 0x8DC
\ Reset value: 0x00000000
\

$00000007 constant RCC_RCC_SPI2S23CKSELR_SPI23SRC                   \ SPI23SRC


\
\ @brief This register is used to control the selection of the kernel clock for the SPI4,5. Note that changing the clock source on-the-fly is allowed, and will not generate any timing violation, however the user has to ensure that both the previous and the new clock sources are present during the switching, and for the whole transition time. Refer to Section: Clock enabling delays.
\ Address offset: 0x8E0
\ Reset value: 0x00000000
\

$00000007 constant RCC_RCC_SPI45CKSELR_SPI45SRC                     \ SPI45SRC


\
\ @brief This register is used to control the selection of the kernel clock for the USART6. Note that changing the clock source on-the-fly is allowed, and will not generate any timing violation, however the user has to ensure that both the previous and the new clock sources are present during the switching, and for the whole transition time. Refer to Section: Clock enabling delays.
\ Address offset: 0x8E4
\ Reset value: 0x00000000
\

$00000007 constant RCC_RCC_UART6CKSELR_UART6SRC                     \ UART6SRC


\
\ @brief This register is used to control the selection of the kernel clock for the USART2 and UART4. Note that changing the clock source on-the-fly is allowed, and will not generate any timing violation, however the user has to ensure that both the previous and the new clock sources are present during the switching, and for the whole transition time. Refer to Section: Clock enabling delays.
\ Address offset: 0x8E8
\ Reset value: 0x00000000
\

$00000007 constant RCC_RCC_UART24CKSELR_UART24SRC                   \ UART24SRC


\
\ @brief This register is used to control the selection of the kernel clock for the USART3 and UART5. Note that changing the clock source on-the-fly is allowed, and will not generate any timing violation, however the user has to ensure that both the previous and the new clock sources are present during the switching, and for the whole transition time. Refer to Section: Clock enabling delays.
\ Address offset: 0x8EC
\ Reset value: 0x00000000
\

$00000007 constant RCC_RCC_UART35CKSELR_UART35SRC                   \ UART35SRC


\
\ @brief This register is used to control the selection of the kernel clock for the UART7 and UART8. Note that changing the clock source on-the-fly is allowed, and will not generate any timing violation, however the user has to ensure that both the previous and the new clock sources are present during the switching, and for the whole transition time. Refer to Section: Clock enabling delays.
\ Address offset: 0x8F0
\ Reset value: 0x00000000
\

$00000007 constant RCC_RCC_UART78CKSELR_UART78SRC                   \ UART78SRC


\
\ @brief This register is used to control the selection of the kernel clock for the SDMMC1 and SDMMC2. Note that changing the clock source on-the-fly is allowed, and will not generate any timing violation, however the user has to ensure that both the previous and the new clock sources are present during the switching, and for the whole transition time. Refer to Section: Clock enabling delays.
\ Address offset: 0x8F4
\ Reset value: 0x00000003
\

$00000007 constant RCC_RCC_SDMMC12CKSELR_SDMMC12SRC                 \ SDMMC12SRC


\
\ @brief This register is used to control the selection of the kernel clock for the SDMMC3. Note that changing the clock source on-the-fly is allowed, and will not generate any timing violation, however the user has to ensure that both the previous and the new clock sources are present during the switching, and for the whole transition time. Refer to Section: Clock enabling delays.
\ Address offset: 0x8F8
\ Reset value: 0x00000000
\

$00000007 constant RCC_RCC_SDMMC3CKSELR_SDMMC3SRC                   \ SDMMC3SRC


\
\ @brief This register is used to control the selection of the kernel clock for the ETH block. Note that changing the clock source on-the-fly is allowed, and will not generate any timing violation, however the user has to ensure that both the previous and the new clock sources are present during the switching, and for the whole transition time. Refer to Section: Clock enabling delays.
\ Address offset: 0x8FC
\ Reset value: 0x00000000
\

$00000003 constant RCC_RCC_ETHCKSELR_ETHSRC                         \ ETHSRC
$000000f0 constant RCC_RCC_ETHCKSELR_ETHPTPDIV                      \ ETHPTPDIV


\
\ @brief This register is used to control the selection of the kernel clock for the QUADSPI. Note that changing the clock source on-the-fly is allowed, and will not generate any timing violation, however the user has to ensure that both the previous and the new clock sources are present during the switching, and for the whole transition time. Refer to Section: Clock enabling delays.
\ Address offset: 0x900
\ Reset value: 0x00000000
\

$00000003 constant RCC_RCC_QSPICKSELR_QSPISRC                       \ QSPISRC


\
\ @brief This register is used to control the selection of the kernel clock for the FMC block. Note that changing the clock source on-the-fly is allowed, and will not generate any timing violation, however the user has to ensure that both the previous and the new clock sources are present during the switching, and for the whole transition time. Refer to Section: Clock enabling delays.
\ Address offset: 0x904
\ Reset value: 0x00000000
\

$00000003 constant RCC_RCC_FMCCKSELR_FMCSRC                         \ FMCSRC


\
\ @brief This register is used to control the selection of the kernel clock for the FDCAN block. Note that changing the clock source on-the-fly is allowed, and will not generate any timing violation, however the user has to ensure that both the previous and the new clock sources are present during the switching, and for the whole transition time. Refer to Section: Clock enabling delays.
\ Address offset: 0x90C
\ Reset value: 0x00000000
\

$00000003 constant RCC_RCC_FDCANCKSELR_FDCANSRC                     \ FDCANSRC


\
\ @brief This register is used to control the selection of the kernel clock for the SPDIFRX. Note that changing the clock source on-the-fly is allowed, and will not generate any timing violation, however the user has to ensure that both the previous and the new clock sources are present during the switching, and for the whole transition time. Refer to Section: Clock enabling delays.
\ Address offset: 0x914
\ Reset value: 0x00000000
\

$00000003 constant RCC_RCC_SPDIFCKSELR_SPDIFSRC                     \ SPDIFSRC


\
\ @brief This register is used to control the selection of the kernel clock for the CEC-HDMI.
\ Address offset: 0x918
\ Reset value: 0x00000000
\

$00000003 constant RCC_RCC_CECCKSELR_CECSRC                         \ CECSRC


\
\ @brief This register is used to control the selection of the kernel clock for the USBPHY PLL of the USB HOST and USB OTG
\ Address offset: 0x91C
\ Reset value: 0x00000000
\

$00000003 constant RCC_RCC_USBCKSELR_USBPHYSRC                      \ USBPHYSRC
$00000010 constant RCC_RCC_USBCKSELR_USBOSRC                        \ USBOSRC


\
\ @brief This register is used to control the selection of the kernel clock for the RNG2.
\ Address offset: 0x920
\ Reset value: 0x00000000
\

$00000003 constant RCC_RCC_RNG2CKSELR_RNG2SRC                       \ RNG2SRC


\
\ @brief This register is used to control the selection of the kernel clock for the DSI block.
\ Address offset: 0x924
\ Reset value: 0x00000000
\

$00000001 constant RCC_RCC_DSICKSELR_DSISRC                         \ DSISRC


\
\ @brief This register is used to control the selection of the kernel clock for the ADC block.
\ Address offset: 0x928
\ Reset value: 0x00000000
\

$00000003 constant RCC_RCC_ADCCKSELR_ADCSRC                         \ ADCSRC


\
\ @brief This register is used to control the selection of the kernel clock for the LPTIM4 and LPTIM5 blocks.
\ Address offset: 0x92C
\ Reset value: 0x00000000
\

$00000007 constant RCC_RCC_LPTIM45CKSELR_LPTIM45SRC                 \ LPTIM45SRC


\
\ @brief This register is used to control the selection of the kernel clock for the LPTIM2 and LPTIM3 blocks.
\ Address offset: 0x930
\ Reset value: 0x00000000
\

$00000007 constant RCC_RCC_LPTIM23CKSELR_LPTIM23SRC                 \ LPTIM23SRC


\
\ @brief This register is used to control the selection of the kernel clock for the LPTIM1 block.
\ Address offset: 0x934
\ Reset value: 0x00000000
\

$00000007 constant RCC_RCC_LPTIM1CKSELR_LPTIM1SRC                   \ LPTIM1SRC


\
\ @brief This register is used to activate the reset of the corresponding peripheral.
\ Address offset: 0x980
\ Reset value: 0x00000000
\

$00000001 constant RCC_RCC_APB1RSTSETR_TIM2RST                      \ TIM2RST
$00000002 constant RCC_RCC_APB1RSTSETR_TIM3RST                      \ TIM3RST
$00000004 constant RCC_RCC_APB1RSTSETR_TIM4RST                      \ TIM4RST
$00000008 constant RCC_RCC_APB1RSTSETR_TIM5RST                      \ TIM5RST
$00000010 constant RCC_RCC_APB1RSTSETR_TIM6RST                      \ TIM6RST
$00000020 constant RCC_RCC_APB1RSTSETR_TIM7RST                      \ TIM7RST
$00000040 constant RCC_RCC_APB1RSTSETR_TIM12RST                     \ TIM12RST
$00000080 constant RCC_RCC_APB1RSTSETR_TIM13RST                     \ TIM13RST
$00000100 constant RCC_RCC_APB1RSTSETR_TIM14RST                     \ TIM14RST
$00000200 constant RCC_RCC_APB1RSTSETR_LPTIM1RST                    \ LPTIM1RST
$00000800 constant RCC_RCC_APB1RSTSETR_SPI2RST                      \ SPI2RST
$00001000 constant RCC_RCC_APB1RSTSETR_SPI3RST                      \ SPI3RST
$00004000 constant RCC_RCC_APB1RSTSETR_USART2RST                    \ USART2RST
$00008000 constant RCC_RCC_APB1RSTSETR_USART3RST                    \ USART3RST
$00010000 constant RCC_RCC_APB1RSTSETR_UART4RST                     \ UART4RST
$00020000 constant RCC_RCC_APB1RSTSETR_UART5RST                     \ UART5RST
$00040000 constant RCC_RCC_APB1RSTSETR_UART7RST                     \ UART7RST
$00080000 constant RCC_RCC_APB1RSTSETR_UART8RST                     \ UART8RST
$00200000 constant RCC_RCC_APB1RSTSETR_I2C1RST                      \ I2C1RST
$00400000 constant RCC_RCC_APB1RSTSETR_I2C2RST                      \ I2C2RST
$00800000 constant RCC_RCC_APB1RSTSETR_I2C3RST                      \ I2C3RST
$01000000 constant RCC_RCC_APB1RSTSETR_I2C5RST                      \ I2C5RST
$04000000 constant RCC_RCC_APB1RSTSETR_SPDIFRST                     \ SPDIFRST
$08000000 constant RCC_RCC_APB1RSTSETR_CECRST                       \ CECRST
$20000000 constant RCC_RCC_APB1RSTSETR_DAC12RST                     \ DAC12RST
$80000000 constant RCC_RCC_APB1RSTSETR_MDIOSRST                     \ MDIOSRST


\
\ @brief This register is used to release the reset of the corresponding peripheral.
\ Address offset: 0x984
\ Reset value: 0x00000000
\

$00000001 constant RCC_RCC_APB1RSTCLRR_TIM2RST                      \ TIM2RST
$00000002 constant RCC_RCC_APB1RSTCLRR_TIM3RST                      \ TIM3RST
$00000004 constant RCC_RCC_APB1RSTCLRR_TIM4RST                      \ TIM4RST
$00000008 constant RCC_RCC_APB1RSTCLRR_TIM5RST                      \ TIM5RST
$00000010 constant RCC_RCC_APB1RSTCLRR_TIM6RST                      \ TIM6RST
$00000020 constant RCC_RCC_APB1RSTCLRR_TIM7RST                      \ TIM7RST
$00000040 constant RCC_RCC_APB1RSTCLRR_TIM12RST                     \ TIM12RST
$00000080 constant RCC_RCC_APB1RSTCLRR_TIM13RST                     \ TIM13RST
$00000100 constant RCC_RCC_APB1RSTCLRR_TIM14RST                     \ TIM14RST
$00000200 constant RCC_RCC_APB1RSTCLRR_LPTIM1RST                    \ LPTIM1RST
$00000800 constant RCC_RCC_APB1RSTCLRR_SPI2RST                      \ SPI2RST
$00001000 constant RCC_RCC_APB1RSTCLRR_SPI3RST                      \ SPI3RST
$00004000 constant RCC_RCC_APB1RSTCLRR_USART2RST                    \ USART2RST
$00008000 constant RCC_RCC_APB1RSTCLRR_USART3RST                    \ USART3RST
$00010000 constant RCC_RCC_APB1RSTCLRR_UART4RST                     \ UART4RST
$00020000 constant RCC_RCC_APB1RSTCLRR_UART5RST                     \ UART5RST
$00040000 constant RCC_RCC_APB1RSTCLRR_UART7RST                     \ UART7RST
$00080000 constant RCC_RCC_APB1RSTCLRR_UART8RST                     \ UART8RST
$00200000 constant RCC_RCC_APB1RSTCLRR_I2C1RST                      \ I2C1RST
$00400000 constant RCC_RCC_APB1RSTCLRR_I2C2RST                      \ I2C2RST
$00800000 constant RCC_RCC_APB1RSTCLRR_I2C3RST                      \ I2C3RST
$01000000 constant RCC_RCC_APB1RSTCLRR_I2C5RST                      \ I2C5RST
$04000000 constant RCC_RCC_APB1RSTCLRR_SPDIFRST                     \ SPDIFRST
$08000000 constant RCC_RCC_APB1RSTCLRR_CECRST                       \ CECRST
$20000000 constant RCC_RCC_APB1RSTCLRR_DAC12RST                     \ DAC12RST
$80000000 constant RCC_RCC_APB1RSTCLRR_MDIOSRST                     \ MDIOSRST


\
\ @brief This register is used to activate the reset of the corresponding peripheral.
\ Address offset: 0x988
\ Reset value: 0x00000000
\

$00000001 constant RCC_RCC_APB2RSTSETR_TIM1RST                      \ TIM1RST
$00000002 constant RCC_RCC_APB2RSTSETR_TIM8RST                      \ TIM8RST
$00000004 constant RCC_RCC_APB2RSTSETR_TIM15RST                     \ TIM15RST
$00000008 constant RCC_RCC_APB2RSTSETR_TIM16RST                     \ TIM16RST
$00000010 constant RCC_RCC_APB2RSTSETR_TIM17RST                     \ TIM17RST
$00000100 constant RCC_RCC_APB2RSTSETR_SPI1RST                      \ SPI1RST
$00000200 constant RCC_RCC_APB2RSTSETR_SPI4RST                      \ SPI4RST
$00000400 constant RCC_RCC_APB2RSTSETR_SPI5RST                      \ SPI5RST
$00002000 constant RCC_RCC_APB2RSTSETR_USART6RST                    \ USART6RST
$00010000 constant RCC_RCC_APB2RSTSETR_SAI1RST                      \ SAI1RST
$00020000 constant RCC_RCC_APB2RSTSETR_SAI2RST                      \ SAI2RST
$00040000 constant RCC_RCC_APB2RSTSETR_SAI3RST                      \ SAI3RST
$00100000 constant RCC_RCC_APB2RSTSETR_DFSDMRST                     \ DFSDMRST
$01000000 constant RCC_RCC_APB2RSTSETR_FDCANRST                     \ FDCANRST


\
\ @brief This register is used to release the reset of the corresponding peripheral.
\ Address offset: 0x98C
\ Reset value: 0x00000000
\

$00000001 constant RCC_RCC_APB2RSTCLRR_TIM1RST                      \ TIM1RST
$00000002 constant RCC_RCC_APB2RSTCLRR_TIM8RST                      \ TIM8RST
$00000004 constant RCC_RCC_APB2RSTCLRR_TIM15RST                     \ TIM15RST
$00000008 constant RCC_RCC_APB2RSTCLRR_TIM16RST                     \ TIM16RST
$00000010 constant RCC_RCC_APB2RSTCLRR_TIM17RST                     \ TIM17RST
$00000100 constant RCC_RCC_APB2RSTCLRR_SPI1RST                      \ SPI1RST
$00000200 constant RCC_RCC_APB2RSTCLRR_SPI4RST                      \ SPI4RST
$00000400 constant RCC_RCC_APB2RSTCLRR_SPI5RST                      \ SPI5RST
$00002000 constant RCC_RCC_APB2RSTCLRR_USART6RST                    \ USART6RST
$00010000 constant RCC_RCC_APB2RSTCLRR_SAI1RST                      \ SAI1RST
$00020000 constant RCC_RCC_APB2RSTCLRR_SAI2RST                      \ SAI2RST
$00040000 constant RCC_RCC_APB2RSTCLRR_SAI3RST                      \ SAI3RST
$00100000 constant RCC_RCC_APB2RSTCLRR_DFSDMRST                     \ DFSDMRST
$01000000 constant RCC_RCC_APB2RSTCLRR_FDCANRST                     \ FDCANRST


\
\ @brief This register is used to activate the reset of the corresponding peripheral.
\ Address offset: 0x990
\ Reset value: 0x00000000
\

$00000001 constant RCC_RCC_APB3RSTSETR_LPTIM2RST                    \ LPTIM2RST
$00000002 constant RCC_RCC_APB3RSTSETR_LPTIM3RST                    \ LPTIM3RST
$00000004 constant RCC_RCC_APB3RSTSETR_LPTIM4RST                    \ LPTIM4RST
$00000008 constant RCC_RCC_APB3RSTSETR_LPTIM5RST                    \ LPTIM5RST
$00000100 constant RCC_RCC_APB3RSTSETR_SAI4RST                      \ SAI4RST
$00000800 constant RCC_RCC_APB3RSTSETR_SYSCFGRST                    \ SYSCFGRST
$00002000 constant RCC_RCC_APB3RSTSETR_VREFRST                      \ VREFRST
$00010000 constant RCC_RCC_APB3RSTSETR_DTSRST                       \ DTSRST


\
\ @brief This register is used to release the reset of the corresponding peripheral.
\ Address offset: 0x994
\ Reset value: 0x00000000
\

$00000001 constant RCC_RCC_APB3RSTCLRR_LPTIM2RST                    \ LPTIM2RST
$00000002 constant RCC_RCC_APB3RSTCLRR_LPTIM3RST                    \ LPTIM3RST
$00000004 constant RCC_RCC_APB3RSTCLRR_LPTIM4RST                    \ LPTIM4RST
$00000008 constant RCC_RCC_APB3RSTCLRR_LPTIM5RST                    \ LPTIM5RST
$00000100 constant RCC_RCC_APB3RSTCLRR_SAI4RST                      \ SAI4RST
$00000800 constant RCC_RCC_APB3RSTCLRR_SYSCFGRST                    \ SYSCFGRST
$00002000 constant RCC_RCC_APB3RSTCLRR_VREFRST                      \ VREFRST
$00010000 constant RCC_RCC_APB3RSTCLRR_DTSRST                       \ DTSRST


\
\ @brief This register is used to activate the reset of the corresponding peripheral.
\ Address offset: 0x998
\ Reset value: 0x00000000
\

$00000001 constant RCC_RCC_AHB2RSTSETR_DMA1RST                      \ DMA1RST
$00000002 constant RCC_RCC_AHB2RSTSETR_DMA2RST                      \ DMA2RST
$00000004 constant RCC_RCC_AHB2RSTSETR_DMAMUXRST                    \ DMAMUXRST
$00000020 constant RCC_RCC_AHB2RSTSETR_ADC12RST                     \ ADC12RST
$00000100 constant RCC_RCC_AHB2RSTSETR_USBORST                      \ USBORST
$00010000 constant RCC_RCC_AHB2RSTSETR_SDMMC3RST                    \ SDMMC3RST


\
\ @brief This register is used to release the reset of the corresponding peripheral.
\ Address offset: 0x99C
\ Reset value: 0x00000000
\

$00000001 constant RCC_RCC_AHB2RSTCLRR_DMA1RST                      \ DMA1RST
$00000002 constant RCC_RCC_AHB2RSTCLRR_DMA2RST                      \ DMA2RST
$00000004 constant RCC_RCC_AHB2RSTCLRR_DMAMUXRST                    \ DMAMUXRST
$00000020 constant RCC_RCC_AHB2RSTCLRR_ADC12RST                     \ ADC12RST
$00000100 constant RCC_RCC_AHB2RSTCLRR_USBORST                      \ USBORST
$00010000 constant RCC_RCC_AHB2RSTCLRR_SDMMC3RST                    \ SDMMC3RST


\
\ @brief This register is used to activate the reset of the corresponding peripheral.
\ Address offset: 0x9A0
\ Reset value: 0x00000000
\

$00000001 constant RCC_RCC_AHB3RSTSETR_DCMIRST                      \ DCMIRST
$00000010 constant RCC_RCC_AHB3RSTSETR_CRYP2RST                     \ CRYP2RST
$00000020 constant RCC_RCC_AHB3RSTSETR_HASH2RST                     \ HASH2RST
$00000040 constant RCC_RCC_AHB3RSTSETR_RNG2RST                      \ RNG2RST
$00000080 constant RCC_RCC_AHB3RSTSETR_CRC2RST                      \ CRC2RST
$00000800 constant RCC_RCC_AHB3RSTSETR_HSEMRST                      \ HSEMRST
$00001000 constant RCC_RCC_AHB3RSTSETR_IPCCRST                      \ IPCCRST


\
\ @brief This register is used to release the reset of the corresponding peripheral.
\ Address offset: 0x9A4
\ Reset value: 0x00000000
\

$00000001 constant RCC_RCC_AHB3RSTCLRR_DCMIRST                      \ DCMIRST
$00000010 constant RCC_RCC_AHB3RSTCLRR_CRYP2RST                     \ CRYP2RST
$00000020 constant RCC_RCC_AHB3RSTCLRR_HASH2RST                     \ HASH2RST
$00000040 constant RCC_RCC_AHB3RSTCLRR_RNG2RST                      \ RNG2RST
$00000080 constant RCC_RCC_AHB3RSTCLRR_CRC2RST                      \ CRC2RST
$00000800 constant RCC_RCC_AHB3RSTCLRR_HSEMRST                      \ HSEMRST
$00001000 constant RCC_RCC_AHB3RSTCLRR_IPCCRST                      \ IPCCRST


\
\ @brief This register is used to activate the reset of the corresponding peripheral
\ Address offset: 0x9A8
\ Reset value: 0x00000000
\

$00000001 constant RCC_RCC_AHB4RSTSETR_GPIOARST                     \ GPIOARST
$00000002 constant RCC_RCC_AHB4RSTSETR_GPIOBRST                     \ GPIOBRST
$00000004 constant RCC_RCC_AHB4RSTSETR_GPIOCRST                     \ GPIOCRST
$00000008 constant RCC_RCC_AHB4RSTSETR_GPIODRST                     \ GPIODRST
$00000010 constant RCC_RCC_AHB4RSTSETR_GPIOERST                     \ GPIOERST
$00000020 constant RCC_RCC_AHB4RSTSETR_GPIOFRST                     \ GPIOFRST
$00000040 constant RCC_RCC_AHB4RSTSETR_GPIOGRST                     \ GPIOGRST
$00000080 constant RCC_RCC_AHB4RSTSETR_GPIOHRST                     \ GPIOHRST
$00000100 constant RCC_RCC_AHB4RSTSETR_GPIOIRST                     \ GPIOIRST
$00000200 constant RCC_RCC_AHB4RSTSETR_GPIOJRST                     \ GPIOJRST
$00000400 constant RCC_RCC_AHB4RSTSETR_GPIOKRST                     \ GPIOKRST


\
\ @brief This register is used to release the reset of the corresponding peripheral.
\ Address offset: 0x9AC
\ Reset value: 0x00000000
\

$00000001 constant RCC_RCC_AHB4RSTCLRR_GPIOARST                     \ GPIOARST
$00000002 constant RCC_RCC_AHB4RSTCLRR_GPIOBRST                     \ GPIOBRST
$00000004 constant RCC_RCC_AHB4RSTCLRR_GPIOCRST                     \ GPIOCRST
$00000008 constant RCC_RCC_AHB4RSTCLRR_GPIODRST                     \ GPIODRST
$00000010 constant RCC_RCC_AHB4RSTCLRR_GPIOERST                     \ GPIOERST
$00000020 constant RCC_RCC_AHB4RSTCLRR_GPIOFRST                     \ GPIOFRST
$00000040 constant RCC_RCC_AHB4RSTCLRR_GPIOGRST                     \ GPIOGRST
$00000080 constant RCC_RCC_AHB4RSTCLRR_GPIOHRST                     \ GPIOHRST
$00000100 constant RCC_RCC_AHB4RSTCLRR_GPIOIRST                     \ GPIOIRST
$00000200 constant RCC_RCC_AHB4RSTCLRR_GPIOJRST                     \ GPIOJRST
$00000400 constant RCC_RCC_AHB4RSTCLRR_GPIOKRST                     \ GPIOKRST


\
\ @brief This register is used to set the peripheral clock enable bit
\ Address offset: 0xA00
\ Reset value: 0x00000000
\

$00000001 constant RCC_RCC_MP_APB1ENSETR_TIM2EN                     \ TIM2EN
$00000002 constant RCC_RCC_MP_APB1ENSETR_TIM3EN                     \ TIM3EN
$00000004 constant RCC_RCC_MP_APB1ENSETR_TIM4EN                     \ TIM4EN
$00000008 constant RCC_RCC_MP_APB1ENSETR_TIM5EN                     \ TIM5EN
$00000010 constant RCC_RCC_MP_APB1ENSETR_TIM6EN                     \ TIM6EN
$00000020 constant RCC_RCC_MP_APB1ENSETR_TIM7EN                     \ TIM7EN
$00000040 constant RCC_RCC_MP_APB1ENSETR_TIM12EN                    \ TIM12EN
$00000080 constant RCC_RCC_MP_APB1ENSETR_TIM13EN                    \ TIM13EN
$00000100 constant RCC_RCC_MP_APB1ENSETR_TIM14EN                    \ TIM14EN
$00000200 constant RCC_RCC_MP_APB1ENSETR_LPTIM1EN                   \ LPTIM1EN
$00000800 constant RCC_RCC_MP_APB1ENSETR_SPI2EN                     \ SPI2EN
$00001000 constant RCC_RCC_MP_APB1ENSETR_SPI3EN                     \ SPI3EN
$00004000 constant RCC_RCC_MP_APB1ENSETR_USART2EN                   \ USART2EN
$00008000 constant RCC_RCC_MP_APB1ENSETR_USART3EN                   \ USART3EN
$00010000 constant RCC_RCC_MP_APB1ENSETR_UART4EN                    \ UART4EN
$00020000 constant RCC_RCC_MP_APB1ENSETR_UART5EN                    \ UART5EN
$00040000 constant RCC_RCC_MP_APB1ENSETR_UART7EN                    \ UART7EN
$00080000 constant RCC_RCC_MP_APB1ENSETR_UART8EN                    \ UART8EN
$00200000 constant RCC_RCC_MP_APB1ENSETR_I2C1EN                     \ I2C1EN
$00400000 constant RCC_RCC_MP_APB1ENSETR_I2C2EN                     \ I2C2EN
$00800000 constant RCC_RCC_MP_APB1ENSETR_I2C3EN                     \ I2C3EN
$01000000 constant RCC_RCC_MP_APB1ENSETR_I2C5EN                     \ I2C5EN
$04000000 constant RCC_RCC_MP_APB1ENSETR_SPDIFEN                    \ SPDIFEN
$08000000 constant RCC_RCC_MP_APB1ENSETR_CECEN                      \ CECEN
$20000000 constant RCC_RCC_MP_APB1ENSETR_DAC12EN                    \ DAC12EN
$80000000 constant RCC_RCC_MP_APB1ENSETR_MDIOSEN                    \ MDIOSEN


\
\ @brief This register is used to clear the peripheral clock enable bit
\ Address offset: 0xA04
\ Reset value: 0x00000000
\

$00000001 constant RCC_RCC_MP_APB1ENCLRR_TIM2EN                     \ TIM2EN
$00000002 constant RCC_RCC_MP_APB1ENCLRR_TIM3EN                     \ TIM3EN
$00000004 constant RCC_RCC_MP_APB1ENCLRR_TIM4EN                     \ TIM4EN
$00000008 constant RCC_RCC_MP_APB1ENCLRR_TIM5EN                     \ TIM5EN
$00000010 constant RCC_RCC_MP_APB1ENCLRR_TIM6EN                     \ TIM6EN
$00000020 constant RCC_RCC_MP_APB1ENCLRR_TIM7EN                     \ TIM7EN
$00000040 constant RCC_RCC_MP_APB1ENCLRR_TIM12EN                    \ TIM12EN
$00000080 constant RCC_RCC_MP_APB1ENCLRR_TIM13EN                    \ TIM13EN
$00000100 constant RCC_RCC_MP_APB1ENCLRR_TIM14EN                    \ TIM14EN
$00000200 constant RCC_RCC_MP_APB1ENCLRR_LPTIM1EN                   \ LPTIM1EN
$00000800 constant RCC_RCC_MP_APB1ENCLRR_SPI2EN                     \ SPI2EN
$00001000 constant RCC_RCC_MP_APB1ENCLRR_SPI3EN                     \ SPI3EN
$00004000 constant RCC_RCC_MP_APB1ENCLRR_USART2EN                   \ USART2EN
$00008000 constant RCC_RCC_MP_APB1ENCLRR_USART3EN                   \ USART3EN
$00010000 constant RCC_RCC_MP_APB1ENCLRR_UART4EN                    \ UART4EN
$00020000 constant RCC_RCC_MP_APB1ENCLRR_UART5EN                    \ UART5EN
$00040000 constant RCC_RCC_MP_APB1ENCLRR_UART7EN                    \ UART7EN
$00080000 constant RCC_RCC_MP_APB1ENCLRR_UART8EN                    \ UART8EN
$00200000 constant RCC_RCC_MP_APB1ENCLRR_I2C1EN                     \ I2C1EN
$00400000 constant RCC_RCC_MP_APB1ENCLRR_I2C2EN                     \ I2C2EN
$00800000 constant RCC_RCC_MP_APB1ENCLRR_I2C3EN                     \ I2C3EN
$01000000 constant RCC_RCC_MP_APB1ENCLRR_I2C5EN                     \ I2C5EN
$04000000 constant RCC_RCC_MP_APB1ENCLRR_SPDIFEN                    \ SPDIFEN
$08000000 constant RCC_RCC_MP_APB1ENCLRR_CECEN                      \ CECEN
$20000000 constant RCC_RCC_MP_APB1ENCLRR_DAC12EN                    \ DAC12EN
$80000000 constant RCC_RCC_MP_APB1ENCLRR_MDIOSEN                    \ MDIOSEN


\
\ @brief This register is used to set the peripheral clock enable bit
\ Address offset: 0xA08
\ Reset value: 0x00000000
\

$00000001 constant RCC_RCC_MP_APB2ENSETR_TIM1EN                     \ TIM1EN
$00000002 constant RCC_RCC_MP_APB2ENSETR_TIM8EN                     \ TIM8EN
$00000004 constant RCC_RCC_MP_APB2ENSETR_TIM15EN                    \ TIM15EN
$00000008 constant RCC_RCC_MP_APB2ENSETR_TIM16EN                    \ TIM16EN
$00000010 constant RCC_RCC_MP_APB2ENSETR_TIM17EN                    \ TIM17EN
$00000100 constant RCC_RCC_MP_APB2ENSETR_SPI1EN                     \ SPI1EN
$00000200 constant RCC_RCC_MP_APB2ENSETR_SPI4EN                     \ SPI4EN
$00000400 constant RCC_RCC_MP_APB2ENSETR_SPI5EN                     \ SPI5EN
$00002000 constant RCC_RCC_MP_APB2ENSETR_USART6EN                   \ USART6EN
$00010000 constant RCC_RCC_MP_APB2ENSETR_SAI1EN                     \ SAI1EN
$00020000 constant RCC_RCC_MP_APB2ENSETR_SAI2EN                     \ SAI2EN
$00040000 constant RCC_RCC_MP_APB2ENSETR_SAI3EN                     \ SAI3EN
$00100000 constant RCC_RCC_MP_APB2ENSETR_DFSDMEN                    \ DFSDMEN
$00200000 constant RCC_RCC_MP_APB2ENSETR_ADFSDMEN                   \ ADFSDMEN
$01000000 constant RCC_RCC_MP_APB2ENSETR_FDCANEN                    \ FDCANEN


\
\ @brief This register is used to clear the peripheral clock enable bit of the corresponding peripheral.
\ Address offset: 0xA0C
\ Reset value: 0x00000000
\

$00000001 constant RCC_RCC_MP_APB2ENCLRR_TIM1EN                     \ TIM1EN
$00000002 constant RCC_RCC_MP_APB2ENCLRR_TIM8EN                     \ TIM8EN
$00000004 constant RCC_RCC_MP_APB2ENCLRR_TIM15EN                    \ TIM15EN
$00000008 constant RCC_RCC_MP_APB2ENCLRR_TIM16EN                    \ TIM16EN
$00000010 constant RCC_RCC_MP_APB2ENCLRR_TIM17EN                    \ TIM17EN
$00000100 constant RCC_RCC_MP_APB2ENCLRR_SPI1EN                     \ SPI1EN
$00000200 constant RCC_RCC_MP_APB2ENCLRR_SPI4EN                     \ SPI4EN
$00000400 constant RCC_RCC_MP_APB2ENCLRR_SPI5EN                     \ SPI5EN
$00002000 constant RCC_RCC_MP_APB2ENCLRR_USART6EN                   \ USART6EN
$00010000 constant RCC_RCC_MP_APB2ENCLRR_SAI1EN                     \ SAI1EN
$00020000 constant RCC_RCC_MP_APB2ENCLRR_SAI2EN                     \ SAI2EN
$00040000 constant RCC_RCC_MP_APB2ENCLRR_SAI3EN                     \ SAI3EN
$00100000 constant RCC_RCC_MP_APB2ENCLRR_DFSDMEN                    \ DFSDMEN
$00200000 constant RCC_RCC_MP_APB2ENCLRR_ADFSDMEN                   \ ADFSDMEN
$01000000 constant RCC_RCC_MP_APB2ENCLRR_FDCANEN                    \ FDCANEN


\
\ @brief This register is used to set the peripheral clock enable bit
\ Address offset: 0xA10
\ Reset value: 0x00000000
\

$00000001 constant RCC_RCC_MP_APB3ENSETR_LPTIM2EN                   \ LPTIM2EN
$00000002 constant RCC_RCC_MP_APB3ENSETR_LPTIM3EN                   \ LPTIM3EN
$00000004 constant RCC_RCC_MP_APB3ENSETR_LPTIM4EN                   \ LPTIM4EN
$00000008 constant RCC_RCC_MP_APB3ENSETR_LPTIM5EN                   \ LPTIM5EN
$00000100 constant RCC_RCC_MP_APB3ENSETR_SAI4EN                     \ SAI4EN
$00000800 constant RCC_RCC_MP_APB3ENSETR_SYSCFGEN                   \ SYSCFGEN
$00002000 constant RCC_RCC_MP_APB3ENSETR_VREFEN                     \ VREFEN
$00010000 constant RCC_RCC_MP_APB3ENSETR_DTSEN                      \ DTSEN
$00100000 constant RCC_RCC_MP_APB3ENSETR_HDPEN                      \ HDPEN


\
\ @brief This register is used to clear the peripheral clock enable bit of the corresponding peripheral.
\ Address offset: 0xA14
\ Reset value: 0x00000000
\

$00000001 constant RCC_RCC_MP_APB3ENCLRR_LPTIM2EN                   \ LPTIM2EN
$00000002 constant RCC_RCC_MP_APB3ENCLRR_LPTIM3EN                   \ LPTIM3EN
$00000004 constant RCC_RCC_MP_APB3ENCLRR_LPTIM4EN                   \ LPTIM4EN
$00000008 constant RCC_RCC_MP_APB3ENCLRR_LPTIM5EN                   \ LPTIM5EN
$00000100 constant RCC_RCC_MP_APB3ENCLRR_SAI4EN                     \ SAI4EN
$00000800 constant RCC_RCC_MP_APB3ENCLRR_SYSCFGEN                   \ SYSCFGEN
$00002000 constant RCC_RCC_MP_APB3ENCLRR_VREFEN                     \ VREFEN
$00010000 constant RCC_RCC_MP_APB3ENCLRR_DTSEN                      \ DTSEN
$00100000 constant RCC_RCC_MP_APB3ENCLRR_HDPEN                      \ HDPEN


\
\ @brief This register is used to set the peripheral clock enable bit of the corresponding peripheral
\ Address offset: 0xA18
\ Reset value: 0x00000000
\

$00000001 constant RCC_RCC_MP_AHB2ENSETR_DMA1EN                     \ DMA1EN
$00000002 constant RCC_RCC_MP_AHB2ENSETR_DMA2EN                     \ DMA2EN
$00000004 constant RCC_RCC_MP_AHB2ENSETR_DMAMUXEN                   \ DMAMUXEN
$00000020 constant RCC_RCC_MP_AHB2ENSETR_ADC12EN                    \ ADC12EN
$00000100 constant RCC_RCC_MP_AHB2ENSETR_USBOEN                     \ USBOEN
$00010000 constant RCC_RCC_MP_AHB2ENSETR_SDMMC3EN                   \ SDMMC3EN


\
\ @brief This register is used to clear the peripheral clock enable bit of the corresponding peripheral.
\ Address offset: 0xA1C
\ Reset value: 0x00000000
\

$00000001 constant RCC_RCC_MP_AHB2ENCLRR_DMA1EN                     \ DMA1EN
$00000002 constant RCC_RCC_MP_AHB2ENCLRR_DMA2EN                     \ DMA2EN
$00000004 constant RCC_RCC_MP_AHB2ENCLRR_DMAMUXEN                   \ DMAMUXEN
$00000020 constant RCC_RCC_MP_AHB2ENCLRR_ADC12EN                    \ ADC12EN
$00000100 constant RCC_RCC_MP_AHB2ENCLRR_USBOEN                     \ USBOEN
$00010000 constant RCC_RCC_MP_AHB2ENCLRR_SDMMC3EN                   \ SDMMC3EN


\
\ @brief This register is used to set the peripheral clock enable bit of the corresponding peripheral
\ Address offset: 0xA20
\ Reset value: 0x00000000
\

$00000001 constant RCC_RCC_MP_AHB3ENSETR_DCMIEN                     \ DCMIEN
$00000010 constant RCC_RCC_MP_AHB3ENSETR_CRYP2EN                    \ CRYP2EN
$00000020 constant RCC_RCC_MP_AHB3ENSETR_HASH2EN                    \ HASH2EN
$00000040 constant RCC_RCC_MP_AHB3ENSETR_RNG2EN                     \ RNG2EN
$00000080 constant RCC_RCC_MP_AHB3ENSETR_CRC2EN                     \ CRC2EN
$00000800 constant RCC_RCC_MP_AHB3ENSETR_HSEMEN                     \ HSEMEN
$00001000 constant RCC_RCC_MP_AHB3ENSETR_IPCCEN                     \ IPCCEN


\
\ @brief This register is used to clear the peripheral clock enable bit of the corresponding peripheral.
\ Address offset: 0xA24
\ Reset value: 0x00000000
\

$00000001 constant RCC_RCC_MP_AHB3ENCLRR_DCMIEN                     \ DCMIEN
$00000010 constant RCC_RCC_MP_AHB3ENCLRR_CRYP2EN                    \ CRYP2EN
$00000020 constant RCC_RCC_MP_AHB3ENCLRR_HASH2EN                    \ HASH2EN
$00000040 constant RCC_RCC_MP_AHB3ENCLRR_RNG2EN                     \ RNG2EN
$00000080 constant RCC_RCC_MP_AHB3ENCLRR_CRC2EN                     \ CRC2EN
$00000800 constant RCC_RCC_MP_AHB3ENCLRR_HSEMEN                     \ HSEMEN
$00001000 constant RCC_RCC_MP_AHB3ENCLRR_IPCCEN                     \ IPCCEN


\
\ @brief This register is used to set the peripheral clock enable bit of the corresponding peripheral to . It shall be used to allocate a peripheral to the MPU.
\ Address offset: 0xA28
\ Reset value: 0x00000000
\

$00000001 constant RCC_RCC_MP_AHB4ENSETR_GPIOAEN                    \ GPIOAEN
$00000002 constant RCC_RCC_MP_AHB4ENSETR_GPIOBEN                    \ GPIOBEN
$00000004 constant RCC_RCC_MP_AHB4ENSETR_GPIOCEN                    \ GPIOCEN
$00000008 constant RCC_RCC_MP_AHB4ENSETR_GPIODEN                    \ GPIODEN
$00000010 constant RCC_RCC_MP_AHB4ENSETR_GPIOEEN                    \ GPIOEEN
$00000020 constant RCC_RCC_MP_AHB4ENSETR_GPIOFEN                    \ GPIOFEN
$00000040 constant RCC_RCC_MP_AHB4ENSETR_GPIOGEN                    \ GPIOGEN
$00000080 constant RCC_RCC_MP_AHB4ENSETR_GPIOHEN                    \ GPIOHEN
$00000100 constant RCC_RCC_MP_AHB4ENSETR_GPIOIEN                    \ GPIOIEN
$00000200 constant RCC_RCC_MP_AHB4ENSETR_GPIOJEN                    \ GPIOJEN
$00000400 constant RCC_RCC_MP_AHB4ENSETR_GPIOKEN                    \ GPIOKEN


\
\ @brief This register is used to clear the peripheral clock enable bit
\ Address offset: 0xA2C
\ Reset value: 0x00000000
\

$00000001 constant RCC_RCC_MP_AHB4ENCLRR_GPIOAEN                    \ GPIOAEN
$00000002 constant RCC_RCC_MP_AHB4ENCLRR_GPIOBEN                    \ GPIOBEN
$00000004 constant RCC_RCC_MP_AHB4ENCLRR_GPIOCEN                    \ GPIOCEN
$00000008 constant RCC_RCC_MP_AHB4ENCLRR_GPIODEN                    \ GPIODEN
$00000010 constant RCC_RCC_MP_AHB4ENCLRR_GPIOEEN                    \ GPIOEEN
$00000020 constant RCC_RCC_MP_AHB4ENCLRR_GPIOFEN                    \ GPIOFEN
$00000040 constant RCC_RCC_MP_AHB4ENCLRR_GPIOGEN                    \ GPIOGEN
$00000080 constant RCC_RCC_MP_AHB4ENCLRR_GPIOHEN                    \ GPIOHEN
$00000100 constant RCC_RCC_MP_AHB4ENCLRR_GPIOIEN                    \ GPIOIEN
$00000200 constant RCC_RCC_MP_AHB4ENCLRR_GPIOJEN                    \ GPIOJEN
$00000400 constant RCC_RCC_MP_AHB4ENCLRR_GPIOKEN                    \ GPIOKEN


\
\ @brief This register is used to set the peripheral clock enable bit
\ Address offset: 0xA38
\ Reset value: 0x00000010
\

$00000010 constant RCC_RCC_MP_MLAHBENSETR_RETRAMEN                  \ RETRAMEN


\
\ @brief This register is used to clear the peripheral clock enable bit.
\ Address offset: 0xA3C
\ Reset value: 0x00000010
\

$00000010 constant RCC_RCC_MP_MLAHBENCLRR_RETRAMEN                  \ RETRAMEN


\
\ @brief This register is used to set the peripheral clock enable bit of the corresponding peripheral to . It shall be used to allocate a peripheral to the MCU. Writing has no effect, reading will return . Writing a sets the corresponding bit to .
\ Address offset: 0xA80
\ Reset value: 0x00000000
\

$00000001 constant RCC_RCC_MC_APB1ENSETR_TIM2EN                     \ TIM2EN
$00000002 constant RCC_RCC_MC_APB1ENSETR_TIM3EN                     \ TIM3EN
$00000004 constant RCC_RCC_MC_APB1ENSETR_TIM4EN                     \ TIM4EN
$00000008 constant RCC_RCC_MC_APB1ENSETR_TIM5EN                     \ TIM5EN
$00000010 constant RCC_RCC_MC_APB1ENSETR_TIM6EN                     \ TIM6EN
$00000020 constant RCC_RCC_MC_APB1ENSETR_TIM7EN                     \ TIM7EN
$00000040 constant RCC_RCC_MC_APB1ENSETR_TIM12EN                    \ TIM12EN
$00000080 constant RCC_RCC_MC_APB1ENSETR_TIM13EN                    \ TIM13EN
$00000100 constant RCC_RCC_MC_APB1ENSETR_TIM14EN                    \ TIM14EN
$00000200 constant RCC_RCC_MC_APB1ENSETR_LPTIM1EN                   \ LPTIM1EN
$00000800 constant RCC_RCC_MC_APB1ENSETR_SPI2EN                     \ SPI2EN
$00001000 constant RCC_RCC_MC_APB1ENSETR_SPI3EN                     \ SPI3EN
$00004000 constant RCC_RCC_MC_APB1ENSETR_USART2EN                   \ USART2EN
$00008000 constant RCC_RCC_MC_APB1ENSETR_USART3EN                   \ USART3EN
$00010000 constant RCC_RCC_MC_APB1ENSETR_UART4EN                    \ UART4EN
$00020000 constant RCC_RCC_MC_APB1ENSETR_UART5EN                    \ UART5EN
$00040000 constant RCC_RCC_MC_APB1ENSETR_UART7EN                    \ UART7EN
$00080000 constant RCC_RCC_MC_APB1ENSETR_UART8EN                    \ UART8EN
$00200000 constant RCC_RCC_MC_APB1ENSETR_I2C1EN                     \ I2C1EN
$00400000 constant RCC_RCC_MC_APB1ENSETR_I2C2EN                     \ I2C2EN
$00800000 constant RCC_RCC_MC_APB1ENSETR_I2C3EN                     \ I2C3EN
$01000000 constant RCC_RCC_MC_APB1ENSETR_I2C5EN                     \ I2C5EN
$04000000 constant RCC_RCC_MC_APB1ENSETR_SPDIFEN                    \ SPDIFEN
$08000000 constant RCC_RCC_MC_APB1ENSETR_CECEN                      \ CECEN
$10000000 constant RCC_RCC_MC_APB1ENSETR_WWDG1EN                    \ WWDG1EN
$20000000 constant RCC_RCC_MC_APB1ENSETR_DAC12EN                    \ DAC12EN
$80000000 constant RCC_RCC_MC_APB1ENSETR_MDIOSEN                    \ MDIOSEN


\
\ @brief This register is used to clear the peripheral clock enable bit of the corresponding peripheral.
\ Address offset: 0xA84
\ Reset value: 0x00000000
\

$00000001 constant RCC_RCC_MC_APB1ENCLRR_TIM2EN                     \ TIM2EN
$00000002 constant RCC_RCC_MC_APB1ENCLRR_TIM3EN                     \ TIM3EN
$00000004 constant RCC_RCC_MC_APB1ENCLRR_TIM4EN                     \ TIM4EN
$00000008 constant RCC_RCC_MC_APB1ENCLRR_TIM5EN                     \ TIM5EN
$00000010 constant RCC_RCC_MC_APB1ENCLRR_TIM6EN                     \ TIM6EN
$00000020 constant RCC_RCC_MC_APB1ENCLRR_TIM7EN                     \ TIM7EN
$00000040 constant RCC_RCC_MC_APB1ENCLRR_TIM12EN                    \ TIM12EN
$00000080 constant RCC_RCC_MC_APB1ENCLRR_TIM13EN                    \ TIM13EN
$00000100 constant RCC_RCC_MC_APB1ENCLRR_TIM14EN                    \ TIM14EN
$00000200 constant RCC_RCC_MC_APB1ENCLRR_LPTIM1EN                   \ LPTIM1EN
$00000800 constant RCC_RCC_MC_APB1ENCLRR_SPI2EN                     \ SPI2EN
$00001000 constant RCC_RCC_MC_APB1ENCLRR_SPI3EN                     \ SPI3EN
$00004000 constant RCC_RCC_MC_APB1ENCLRR_USART2EN                   \ USART2EN
$00008000 constant RCC_RCC_MC_APB1ENCLRR_USART3EN                   \ USART3EN
$00010000 constant RCC_RCC_MC_APB1ENCLRR_UART4EN                    \ UART4EN
$00020000 constant RCC_RCC_MC_APB1ENCLRR_UART5EN                    \ UART5EN
$00040000 constant RCC_RCC_MC_APB1ENCLRR_UART7EN                    \ UART7EN
$00080000 constant RCC_RCC_MC_APB1ENCLRR_UART8EN                    \ UART8EN
$00200000 constant RCC_RCC_MC_APB1ENCLRR_I2C1EN                     \ I2C1EN
$00400000 constant RCC_RCC_MC_APB1ENCLRR_I2C2EN                     \ I2C2EN
$00800000 constant RCC_RCC_MC_APB1ENCLRR_I2C3EN                     \ I2C3EN
$01000000 constant RCC_RCC_MC_APB1ENCLRR_I2C5EN                     \ I2C5EN
$04000000 constant RCC_RCC_MC_APB1ENCLRR_SPDIFEN                    \ SPDIFEN
$08000000 constant RCC_RCC_MC_APB1ENCLRR_CECEN                      \ CECEN
$20000000 constant RCC_RCC_MC_APB1ENCLRR_DAC12EN                    \ DAC12EN
$80000000 constant RCC_RCC_MC_APB1ENCLRR_MDIOSEN                    \ MDIOSEN


\
\ @brief This register is used to set the peripheral clock enable bit
\ Address offset: 0xA88
\ Reset value: 0x00000000
\

$00000001 constant RCC_RCC_MC_APB2ENSETR_TIM1EN                     \ TIM1EN
$00000002 constant RCC_RCC_MC_APB2ENSETR_TIM8EN                     \ TIM8EN
$00000004 constant RCC_RCC_MC_APB2ENSETR_TIM15EN                    \ TIM15EN
$00000008 constant RCC_RCC_MC_APB2ENSETR_TIM16EN                    \ TIM16EN
$00000010 constant RCC_RCC_MC_APB2ENSETR_TIM17EN                    \ TIM17EN
$00000100 constant RCC_RCC_MC_APB2ENSETR_SPI1EN                     \ SPI1EN
$00000200 constant RCC_RCC_MC_APB2ENSETR_SPI4EN                     \ SPI4EN
$00000400 constant RCC_RCC_MC_APB2ENSETR_SPI5EN                     \ SPI5EN
$00002000 constant RCC_RCC_MC_APB2ENSETR_USART6EN                   \ USART6EN
$00010000 constant RCC_RCC_MC_APB2ENSETR_SAI1EN                     \ SAI1EN
$00020000 constant RCC_RCC_MC_APB2ENSETR_SAI2EN                     \ SAI2EN
$00040000 constant RCC_RCC_MC_APB2ENSETR_SAI3EN                     \ SAI3EN
$00100000 constant RCC_RCC_MC_APB2ENSETR_DFSDMEN                    \ DFSDMEN
$00200000 constant RCC_RCC_MC_APB2ENSETR_ADFSDMEN                   \ ADFSDMEN
$01000000 constant RCC_RCC_MC_APB2ENSETR_FDCANEN                    \ FDCANEN


\
\ @brief This register is used to clear the peripheral clock enable bit
\ Address offset: 0xA8C
\ Reset value: 0x00000000
\

$00000001 constant RCC_RCC_MC_APB2ENCLRR_TIM1EN                     \ TIM1EN
$00000002 constant RCC_RCC_MC_APB2ENCLRR_TIM8EN                     \ TIM8EN
$00000004 constant RCC_RCC_MC_APB2ENCLRR_TIM15EN                    \ TIM15EN
$00000008 constant RCC_RCC_MC_APB2ENCLRR_TIM16EN                    \ TIM16EN
$00000010 constant RCC_RCC_MC_APB2ENCLRR_TIM17EN                    \ TIM17EN
$00000100 constant RCC_RCC_MC_APB2ENCLRR_SPI1EN                     \ SPI1EN
$00000200 constant RCC_RCC_MC_APB2ENCLRR_SPI4EN                     \ SPI4EN
$00000400 constant RCC_RCC_MC_APB2ENCLRR_SPI5EN                     \ SPI5EN
$00002000 constant RCC_RCC_MC_APB2ENCLRR_USART6EN                   \ USART6EN
$00010000 constant RCC_RCC_MC_APB2ENCLRR_SAI1EN                     \ SAI1EN
$00020000 constant RCC_RCC_MC_APB2ENCLRR_SAI2EN                     \ SAI2EN
$00040000 constant RCC_RCC_MC_APB2ENCLRR_SAI3EN                     \ SAI3EN
$00100000 constant RCC_RCC_MC_APB2ENCLRR_DFSDMEN                    \ DFSDMEN
$00200000 constant RCC_RCC_MC_APB2ENCLRR_ADFSDMEN                   \ ADFSDMEN
$01000000 constant RCC_RCC_MC_APB2ENCLRR_FDCANEN                    \ FDCANEN


\
\ @brief This register is used to set the peripheral clock enable bit
\ Address offset: 0xA90
\ Reset value: 0x00000000
\

$00000001 constant RCC_RCC_MC_APB3ENSETR_LPTIM2EN                   \ LPTIM2EN
$00000002 constant RCC_RCC_MC_APB3ENSETR_LPTIM3EN                   \ LPTIM3EN
$00000004 constant RCC_RCC_MC_APB3ENSETR_LPTIM4EN                   \ LPTIM4EN
$00000008 constant RCC_RCC_MC_APB3ENSETR_LPTIM5EN                   \ LPTIM5EN
$00000100 constant RCC_RCC_MC_APB3ENSETR_SAI4EN                     \ SAI4EN
$00000800 constant RCC_RCC_MC_APB3ENSETR_SYSCFGEN                   \ SYSCFGEN
$00002000 constant RCC_RCC_MC_APB3ENSETR_VREFEN                     \ VREFEN
$00010000 constant RCC_RCC_MC_APB3ENSETR_DTSEN                      \ DTSEN
$00100000 constant RCC_RCC_MC_APB3ENSETR_HDPEN                      \ HDPEN


\
\ @brief This register is used to clear the peripheral clock enable bit
\ Address offset: 0xA94
\ Reset value: 0x00000000
\

$00000001 constant RCC_RCC_MC_APB3ENCLRR_LPTIM2EN                   \ LPTIM2EN
$00000002 constant RCC_RCC_MC_APB3ENCLRR_LPTIM3EN                   \ LPTIM3EN
$00000004 constant RCC_RCC_MC_APB3ENCLRR_LPTIM4EN                   \ LPTIM4EN
$00000008 constant RCC_RCC_MC_APB3ENCLRR_LPTIM5EN                   \ LPTIM5EN
$00000100 constant RCC_RCC_MC_APB3ENCLRR_SAI4EN                     \ SAI4EN
$00000800 constant RCC_RCC_MC_APB3ENCLRR_SYSCFGEN                   \ SYSCFGEN
$00002000 constant RCC_RCC_MC_APB3ENCLRR_VREFEN                     \ VREFEN
$00010000 constant RCC_RCC_MC_APB3ENCLRR_DTSEN                      \ DTSEN
$00100000 constant RCC_RCC_MC_APB3ENCLRR_HDPEN                      \ HDPEN


\
\ @brief This register is used to set the peripheral clock enable bit
\ Address offset: 0xA98
\ Reset value: 0x00000000
\

$00000001 constant RCC_RCC_MC_AHB2ENSETR_DMA1EN                     \ DMA1EN
$00000002 constant RCC_RCC_MC_AHB2ENSETR_DMA2EN                     \ DMA2EN
$00000004 constant RCC_RCC_MC_AHB2ENSETR_DMAMUXEN                   \ DMAMUXEN
$00000020 constant RCC_RCC_MC_AHB2ENSETR_ADC12EN                    \ ADC12EN
$00000100 constant RCC_RCC_MC_AHB2ENSETR_USBOEN                     \ USBOEN
$00010000 constant RCC_RCC_MC_AHB2ENSETR_SDMMC3EN                   \ SDMMC3EN


\
\ @brief This register is used to clear the peripheral clock enable bit
\ Address offset: 0xA9C
\ Reset value: 0x00000000
\

$00000001 constant RCC_RCC_MC_AHB2ENCLRR_DMA1EN                     \ DMA1EN
$00000002 constant RCC_RCC_MC_AHB2ENCLRR_DMA2EN                     \ DMA2EN
$00000004 constant RCC_RCC_MC_AHB2ENCLRR_DMAMUXEN                   \ DMAMUXEN
$00000020 constant RCC_RCC_MC_AHB2ENCLRR_ADC12EN                    \ ADC12EN
$00000100 constant RCC_RCC_MC_AHB2ENCLRR_USBOEN                     \ USBOEN
$00010000 constant RCC_RCC_MC_AHB2ENCLRR_SDMMC3EN                   \ SDMMC3EN


\
\ @brief This register is used to set the peripheral clock enable bit
\ Address offset: 0xAA0
\ Reset value: 0x00000000
\

$00000001 constant RCC_RCC_MC_AHB3ENSETR_DCMIEN                     \ DCMIEN
$00000010 constant RCC_RCC_MC_AHB3ENSETR_CRYP2EN                    \ CRYP2EN
$00000020 constant RCC_RCC_MC_AHB3ENSETR_HASH2EN                    \ HASH2EN
$00000040 constant RCC_RCC_MC_AHB3ENSETR_RNG2EN                     \ RNG2EN
$00000080 constant RCC_RCC_MC_AHB3ENSETR_CRC2EN                     \ CRC2EN
$00000800 constant RCC_RCC_MC_AHB3ENSETR_HSEMEN                     \ HSEMEN
$00001000 constant RCC_RCC_MC_AHB3ENSETR_IPCCEN                     \ IPCCEN


\
\ @brief This register is used to clear the peripheral clock enable bit
\ Address offset: 0xAA4
\ Reset value: 0x00000000
\

$00000001 constant RCC_RCC_MC_AHB3ENCLRR_DCMIEN                     \ DCMIEN
$00000010 constant RCC_RCC_MC_AHB3ENCLRR_CRYP2EN                    \ CRYP2EN
$00000020 constant RCC_RCC_MC_AHB3ENCLRR_HASH2EN                    \ HASH2EN
$00000040 constant RCC_RCC_MC_AHB3ENCLRR_RNG2EN                     \ RNG2EN
$00000080 constant RCC_RCC_MC_AHB3ENCLRR_CRC2EN                     \ CRC2EN
$00000800 constant RCC_RCC_MC_AHB3ENCLRR_HSEMEN                     \ HSEMEN
$00001000 constant RCC_RCC_MC_AHB3ENCLRR_IPCCEN                     \ IPCCEN


\
\ @brief This register is used to set the peripheral clock enable bit
\ Address offset: 0xAA8
\ Reset value: 0x00000000
\

$00000001 constant RCC_RCC_MC_AHB4ENSETR_GPIOAEN                    \ GPIOAEN
$00000002 constant RCC_RCC_MC_AHB4ENSETR_GPIOBEN                    \ GPIOBEN
$00000004 constant RCC_RCC_MC_AHB4ENSETR_GPIOCEN                    \ GPIOCEN
$00000008 constant RCC_RCC_MC_AHB4ENSETR_GPIODEN                    \ GPIODEN
$00000010 constant RCC_RCC_MC_AHB4ENSETR_GPIOEEN                    \ GPIOEEN
$00000020 constant RCC_RCC_MC_AHB4ENSETR_GPIOFEN                    \ GPIOFEN
$00000040 constant RCC_RCC_MC_AHB4ENSETR_GPIOGEN                    \ GPIOGEN
$00000080 constant RCC_RCC_MC_AHB4ENSETR_GPIOHEN                    \ GPIOHEN
$00000100 constant RCC_RCC_MC_AHB4ENSETR_GPIOIEN                    \ GPIOIEN
$00000200 constant RCC_RCC_MC_AHB4ENSETR_GPIOJEN                    \ GPIOJEN
$00000400 constant RCC_RCC_MC_AHB4ENSETR_GPIOKEN                    \ GPIOKEN


\
\ @brief This register is used to clear the peripheral clock enable bit
\ Address offset: 0xAAC
\ Reset value: 0x00000000
\

$00000001 constant RCC_RCC_MC_AHB4ENCLRR_GPIOAEN                    \ GPIOAEN
$00000002 constant RCC_RCC_MC_AHB4ENCLRR_GPIOBEN                    \ GPIOBEN
$00000004 constant RCC_RCC_MC_AHB4ENCLRR_GPIOCEN                    \ GPIOCEN
$00000008 constant RCC_RCC_MC_AHB4ENCLRR_GPIODEN                    \ GPIODEN
$00000010 constant RCC_RCC_MC_AHB4ENCLRR_GPIOEEN                    \ GPIOEEN
$00000020 constant RCC_RCC_MC_AHB4ENCLRR_GPIOFEN                    \ GPIOFEN
$00000040 constant RCC_RCC_MC_AHB4ENCLRR_GPIOGEN                    \ GPIOGEN
$00000080 constant RCC_RCC_MC_AHB4ENCLRR_GPIOHEN                    \ GPIOHEN
$00000100 constant RCC_RCC_MC_AHB4ENCLRR_GPIOIEN                    \ GPIOIEN
$00000200 constant RCC_RCC_MC_AHB4ENCLRR_GPIOJEN                    \ GPIOJEN
$00000400 constant RCC_RCC_MC_AHB4ENCLRR_GPIOKEN                    \ GPIOKEN


\
\ @brief This register is used to set the peripheral clock enable bit
\ Address offset: 0xAB0
\ Reset value: 0x00000000
\

$00000001 constant RCC_RCC_MC_AXIMENSETR_SYSRAMEN                   \ SYSRAMEN


\
\ @brief This register is used to clear the peripheral clock enable bit
\ Address offset: 0xAB4
\ Reset value: 0x00000000
\

$00000001 constant RCC_RCC_MC_AXIMENCLRR_SYSRAMEN                   \ SYSRAMEN


\
\ @brief This register is used to set the peripheral clock enable bit
\ Address offset: 0xAB8
\ Reset value: 0x00000010
\

$00000010 constant RCC_RCC_MC_MLAHBENSETR_RETRAMEN                  \ RETRAMEN


\
\ @brief This register is used to clear the peripheral clock enable bit
\ Address offset: 0xABC
\ Reset value: 0x00000010
\

$00000010 constant RCC_RCC_MC_MLAHBENCLRR_RETRAMEN                  \ RETRAMEN


\
\ @brief This register is used by the MCU in order to clear the PERxLPEN bits
\ Address offset: 0xB00
\ Reset value: 0xADEFDBFF
\

$00000001 constant RCC_RCC_MP_APB1LPENSETR_TIM2LPEN                 \ TIM2LPEN
$00000002 constant RCC_RCC_MP_APB1LPENSETR_TIM3LPEN                 \ TIM3LPEN
$00000004 constant RCC_RCC_MP_APB1LPENSETR_TIM4LPEN                 \ TIM4LPEN
$00000008 constant RCC_RCC_MP_APB1LPENSETR_TIM5LPEN                 \ TIM5LPEN
$00000010 constant RCC_RCC_MP_APB1LPENSETR_TIM6LPEN                 \ TIM6LPEN
$00000020 constant RCC_RCC_MP_APB1LPENSETR_TIM7LPEN                 \ TIM7LPEN
$00000040 constant RCC_RCC_MP_APB1LPENSETR_TIM12LPEN                \ TIM12LPEN
$00000080 constant RCC_RCC_MP_APB1LPENSETR_TIM13LPEN                \ TIM13LPEN
$00000100 constant RCC_RCC_MP_APB1LPENSETR_TIM14LPEN                \ TIM14LPEN
$00000200 constant RCC_RCC_MP_APB1LPENSETR_LPTIM1LPEN               \ LPTIM1LPEN
$00000800 constant RCC_RCC_MP_APB1LPENSETR_SPI2LPEN                 \ SPI2LPEN
$00001000 constant RCC_RCC_MP_APB1LPENSETR_SPI3LPEN                 \ SPI3LPEN
$00004000 constant RCC_RCC_MP_APB1LPENSETR_USART2LPEN               \ USART2LPEN
$00008000 constant RCC_RCC_MP_APB1LPENSETR_USART3LPEN               \ USART3LPEN
$00010000 constant RCC_RCC_MP_APB1LPENSETR_UART4LPEN                \ UART4LPEN
$00020000 constant RCC_RCC_MP_APB1LPENSETR_UART5LPEN                \ UART5LPEN
$00040000 constant RCC_RCC_MP_APB1LPENSETR_UART7LPEN                \ UART7LPEN
$00080000 constant RCC_RCC_MP_APB1LPENSETR_UART8LPEN                \ UART8LPEN
$00200000 constant RCC_RCC_MP_APB1LPENSETR_I2C1LPEN                 \ I2C1LPEN
$00400000 constant RCC_RCC_MP_APB1LPENSETR_I2C2LPEN                 \ I2C2LPEN
$00800000 constant RCC_RCC_MP_APB1LPENSETR_I2C3LPEN                 \ I2C3LPEN
$01000000 constant RCC_RCC_MP_APB1LPENSETR_I2C5LPEN                 \ I2C5LPEN
$04000000 constant RCC_RCC_MP_APB1LPENSETR_SPDIFLPEN                \ SPDIFLPEN
$08000000 constant RCC_RCC_MP_APB1LPENSETR_CECLPEN                  \ CECLPEN
$20000000 constant RCC_RCC_MP_APB1LPENSETR_DAC12LPEN                \ DAC12LPEN
$80000000 constant RCC_RCC_MP_APB1LPENSETR_MDIOSLPEN                \ MDIOSLPEN


\
\ @brief This register is used by the MPU in order to clear the PERxLPEN bits .
\ Address offset: 0xB04
\ Reset value: 0xADEFDBFF
\

$00000001 constant RCC_RCC_MP_APB1LPENCLRR_TIM2LPEN                 \ TIM2LPEN
$00000002 constant RCC_RCC_MP_APB1LPENCLRR_TIM3LPEN                 \ TIM3LPEN
$00000004 constant RCC_RCC_MP_APB1LPENCLRR_TIM4LPEN                 \ TIM4LPEN
$00000008 constant RCC_RCC_MP_APB1LPENCLRR_TIM5LPEN                 \ TIM5LPEN
$00000010 constant RCC_RCC_MP_APB1LPENCLRR_TIM6LPEN                 \ TIM6LPEN
$00000020 constant RCC_RCC_MP_APB1LPENCLRR_TIM7LPEN                 \ TIM7LPEN
$00000040 constant RCC_RCC_MP_APB1LPENCLRR_TIM12LPEN                \ TIM12LPEN
$00000080 constant RCC_RCC_MP_APB1LPENCLRR_TIM13LPEN                \ TIM13LPEN
$00000100 constant RCC_RCC_MP_APB1LPENCLRR_TIM14LPEN                \ TIM14LPEN
$00000200 constant RCC_RCC_MP_APB1LPENCLRR_LPTIM1LPEN               \ LPTIM1LPEN
$00000800 constant RCC_RCC_MP_APB1LPENCLRR_SPI2LPEN                 \ SPI2LPEN
$00001000 constant RCC_RCC_MP_APB1LPENCLRR_SPI3LPEN                 \ SPI3LPEN
$00004000 constant RCC_RCC_MP_APB1LPENCLRR_USART2LPEN               \ USART2LPEN
$00008000 constant RCC_RCC_MP_APB1LPENCLRR_USART3LPEN               \ USART3LPEN
$00010000 constant RCC_RCC_MP_APB1LPENCLRR_UART4LPEN                \ UART4LPEN
$00020000 constant RCC_RCC_MP_APB1LPENCLRR_UART5LPEN                \ UART5LPEN
$00040000 constant RCC_RCC_MP_APB1LPENCLRR_UART7LPEN                \ UART7LPEN
$00080000 constant RCC_RCC_MP_APB1LPENCLRR_UART8LPEN                \ UART8LPEN
$00200000 constant RCC_RCC_MP_APB1LPENCLRR_I2C1LPEN                 \ I2C1LPEN
$00400000 constant RCC_RCC_MP_APB1LPENCLRR_I2C2LPEN                 \ I2C2LPEN
$00800000 constant RCC_RCC_MP_APB1LPENCLRR_I2C3LPEN                 \ I2C3LPEN
$01000000 constant RCC_RCC_MP_APB1LPENCLRR_I2C5LPEN                 \ I2C5LPEN
$04000000 constant RCC_RCC_MP_APB1LPENCLRR_SPDIFLPEN                \ SPDIFLPEN
$08000000 constant RCC_RCC_MP_APB1LPENCLRR_CECLPEN                  \ CECLPEN
$20000000 constant RCC_RCC_MP_APB1LPENCLRR_DAC12LPEN                \ DAC12LPEN
$80000000 constant RCC_RCC_MP_APB1LPENCLRR_MDIOSLPEN                \ MDIOSLPEN


\
\ @brief This register is used by the MCU in order to clear the PERxLPEN bits
\ Address offset: 0xB08
\ Reset value: 0x0137271F
\

$00000001 constant RCC_RCC_MP_APB2LPENSETR_TIM1LPEN                 \ TIM1LPEN
$00000002 constant RCC_RCC_MP_APB2LPENSETR_TIM8LPEN                 \ TIM8LPEN
$00000004 constant RCC_RCC_MP_APB2LPENSETR_TIM15LPEN                \ TIM15LPEN
$00000008 constant RCC_RCC_MP_APB2LPENSETR_TIM16LPEN                \ TIM16LPEN
$00000010 constant RCC_RCC_MP_APB2LPENSETR_TIM17LPEN                \ TIM17LPEN
$00000100 constant RCC_RCC_MP_APB2LPENSETR_SPI1LPEN                 \ SPI1LPEN
$00000200 constant RCC_RCC_MP_APB2LPENSETR_SPI4LPEN                 \ SPI4LPEN
$00000400 constant RCC_RCC_MP_APB2LPENSETR_SPI5LPEN                 \ SPI5LPEN
$00002000 constant RCC_RCC_MP_APB2LPENSETR_USART6LPEN               \ USART6LPEN
$00010000 constant RCC_RCC_MP_APB2LPENSETR_SAI1LPEN                 \ SAI1LPEN
$00020000 constant RCC_RCC_MP_APB2LPENSETR_SAI2LPEN                 \ SAI2LPEN
$00040000 constant RCC_RCC_MP_APB2LPENSETR_SAI3LPEN                 \ SAI3LPEN
$00100000 constant RCC_RCC_MP_APB2LPENSETR_DFSDMLPEN                \ DFSDMLPEN
$00200000 constant RCC_RCC_MP_APB2LPENSETR_ADFSDMLPEN               \ ADFSDMLPEN
$01000000 constant RCC_RCC_MP_APB2LPENSETR_FDCANLPEN                \ FDCANLPEN


\
\ @brief This register is used by the MCU in order to clear the PERxLPEN bits
\ Address offset: 0xB0C
\ Reset value: 0x0137271F
\

$00000001 constant RCC_RCC_MP_APB2LPENCLRR_TIM1LPEN                 \ TIM1LPEN
$00000002 constant RCC_RCC_MP_APB2LPENCLRR_TIM8LPEN                 \ TIM8LPEN
$00000004 constant RCC_RCC_MP_APB2LPENCLRR_TIM15LPEN                \ TIM15LPEN
$00000008 constant RCC_RCC_MP_APB2LPENCLRR_TIM16LPEN                \ TIM16LPEN
$00000010 constant RCC_RCC_MP_APB2LPENCLRR_TIM17LPEN                \ TIM17LPEN
$00000100 constant RCC_RCC_MP_APB2LPENCLRR_SPI1LPEN                 \ SPI1LPEN
$00000200 constant RCC_RCC_MP_APB2LPENCLRR_SPI4LPEN                 \ SPI4LPEN
$00000400 constant RCC_RCC_MP_APB2LPENCLRR_SPI5LPEN                 \ SPI5LPEN
$00002000 constant RCC_RCC_MP_APB2LPENCLRR_USART6LPEN               \ USART6LPEN
$00010000 constant RCC_RCC_MP_APB2LPENCLRR_SAI1LPEN                 \ SAI1LPEN
$00020000 constant RCC_RCC_MP_APB2LPENCLRR_SAI2LPEN                 \ SAI2LPEN
$00040000 constant RCC_RCC_MP_APB2LPENCLRR_SAI3LPEN                 \ SAI3LPEN
$00100000 constant RCC_RCC_MP_APB2LPENCLRR_DFSDMLPEN                \ DFSDMLPEN
$00200000 constant RCC_RCC_MP_APB2LPENCLRR_ADFSDMLPEN               \ ADFSDMLPEN
$01000000 constant RCC_RCC_MP_APB2LPENCLRR_FDCANLPEN                \ FDCANLPEN


\
\ @brief This register is used by the MCU in order to clear the PERxLPEN bits
\ Address offset: 0xB10
\ Reset value: 0x0003290F
\

$00000001 constant RCC_RCC_MP_APB3LPENSETR_LPTIM2LPEN               \ LPTIM2LPEN
$00000002 constant RCC_RCC_MP_APB3LPENSETR_LPTIM3LPEN               \ LPTIM3LPEN
$00000004 constant RCC_RCC_MP_APB3LPENSETR_LPTIM4LPEN               \ LPTIM4LPEN
$00000008 constant RCC_RCC_MP_APB3LPENSETR_LPTIM5LPEN               \ LPTIM5LPEN
$00000100 constant RCC_RCC_MP_APB3LPENSETR_SAI4LPEN                 \ SAI4LPEN
$00000800 constant RCC_RCC_MP_APB3LPENSETR_SYSCFGLPEN               \ SYSCFGLPEN
$00002000 constant RCC_RCC_MP_APB3LPENSETR_VREFLPEN                 \ VREFLPEN
$00010000 constant RCC_RCC_MP_APB3LPENSETR_DTSLPEN                  \ DTSLPEN


\
\ @brief This register is used by the MCU in order to clear the PERxLPEN bits
\ Address offset: 0xB14
\ Reset value: 0x0003290F
\

$00000001 constant RCC_RCC_MP_APB3LPENCLRR_LPTIM2LPEN               \ LPTIM2LPEN
$00000002 constant RCC_RCC_MP_APB3LPENCLRR_LPTIM3LPEN               \ LPTIM3LPEN
$00000004 constant RCC_RCC_MP_APB3LPENCLRR_LPTIM4LPEN               \ LPTIM4LPEN
$00000008 constant RCC_RCC_MP_APB3LPENCLRR_LPTIM5LPEN               \ LPTIM5LPEN
$00000100 constant RCC_RCC_MP_APB3LPENCLRR_SAI4LPEN                 \ SAI4LPEN
$00000800 constant RCC_RCC_MP_APB3LPENCLRR_SYSCFGLPEN               \ SYSCFGLPEN
$00002000 constant RCC_RCC_MP_APB3LPENCLRR_VREFLPEN                 \ VREFLPEN
$00010000 constant RCC_RCC_MP_APB3LPENCLRR_DTSLPEN                  \ DTSLPEN


\
\ @brief This register is used by the MPU in order to set the PERxLPEN bit.
\ Address offset: 0xB18
\ Reset value: 0x00010127
\

$00000001 constant RCC_RCC_MP_AHB2LPENSETR_DMA1LPEN                 \ DMA1LPEN
$00000002 constant RCC_RCC_MP_AHB2LPENSETR_DMA2LPEN                 \ DMA2LPEN
$00000004 constant RCC_RCC_MP_AHB2LPENSETR_DMAMUXLPEN               \ DMAMUXLPEN
$00000020 constant RCC_RCC_MP_AHB2LPENSETR_ADC12LPEN                \ ADC12LPEN
$00000100 constant RCC_RCC_MP_AHB2LPENSETR_USBOLPEN                 \ USBOLPEN
$00010000 constant RCC_RCC_MP_AHB2LPENSETR_SDMMC3LPEN               \ SDMMC3LPEN


\
\ @brief This register is used by the MCU in order to clear the PERxLPEN bits
\ Address offset: 0xB1C
\ Reset value: 0x00010127
\

$00000001 constant RCC_RCC_MP_AHB2LPENCLRR_DMA1LPEN                 \ DMA1LPEN
$00000002 constant RCC_RCC_MP_AHB2LPENCLRR_DMA2LPEN                 \ DMA2LPEN
$00000004 constant RCC_RCC_MP_AHB2LPENCLRR_DMAMUXLPEN               \ DMAMUXLPEN
$00000020 constant RCC_RCC_MP_AHB2LPENCLRR_ADC12LPEN                \ ADC12LPEN
$00000100 constant RCC_RCC_MP_AHB2LPENCLRR_USBOLPEN                 \ USBOLPEN
$00010000 constant RCC_RCC_MP_AHB2LPENCLRR_SDMMC3LPEN               \ SDMMC3LPEN


\
\ @brief This register is used by the MPU
\ Address offset: 0xB20
\ Reset value: 0x000018F1
\

$00000001 constant RCC_RCC_MP_AHB3LPENSETR_DCMILPEN                 \ DCMILPEN
$00000010 constant RCC_RCC_MP_AHB3LPENSETR_CRYP2LPEN                \ CRYP2LPEN
$00000020 constant RCC_RCC_MP_AHB3LPENSETR_HASH2LPEN                \ HASH2LPEN
$00000040 constant RCC_RCC_MP_AHB3LPENSETR_RNG2LPEN                 \ RNG2LPEN
$00000080 constant RCC_RCC_MP_AHB3LPENSETR_CRC2LPEN                 \ CRC2LPEN
$00000800 constant RCC_RCC_MP_AHB3LPENSETR_HSEMLPEN                 \ HSEMLPEN
$00001000 constant RCC_RCC_MP_AHB3LPENSETR_IPCCLPEN                 \ IPCCLPEN


\
\ @brief This register is used by the MPU in order to clear the PERxLPEN bit
\ Address offset: 0xB24
\ Reset value: 0x000018F1
\

$00000001 constant RCC_RCC_MP_AHB3LPENCLRR_DCMILPEN                 \ DCMILPEN
$00000010 constant RCC_RCC_MP_AHB3LPENCLRR_CRYP2LPEN                \ CRYP2LPEN
$00000020 constant RCC_RCC_MP_AHB3LPENCLRR_HASH2LPEN                \ HASH2LPEN
$00000040 constant RCC_RCC_MP_AHB3LPENCLRR_RNG2LPEN                 \ RNG2LPEN
$00000080 constant RCC_RCC_MP_AHB3LPENCLRR_CRC2LPEN                 \ CRC2LPEN
$00000800 constant RCC_RCC_MP_AHB3LPENCLRR_HSEMLPEN                 \ HSEMLPEN
$00001000 constant RCC_RCC_MP_AHB3LPENCLRR_IPCCLPEN                 \ IPCCLPEN


\
\ @brief This register is used by the MPU
\ Address offset: 0xB28
\ Reset value: 0x000007FF
\

$00000001 constant RCC_RCC_MP_AHB4LPENSETR_GPIOALPEN                \ GPIOALPEN
$00000002 constant RCC_RCC_MP_AHB4LPENSETR_GPIOBLPEN                \ GPIOBLPEN
$00000004 constant RCC_RCC_MP_AHB4LPENSETR_GPIOCLPEN                \ GPIOCLPEN
$00000008 constant RCC_RCC_MP_AHB4LPENSETR_GPIODLPEN                \ GPIODLPEN
$00000010 constant RCC_RCC_MP_AHB4LPENSETR_GPIOELPEN                \ GPIOELPEN
$00000020 constant RCC_RCC_MP_AHB4LPENSETR_GPIOFLPEN                \ GPIOFLPEN
$00000040 constant RCC_RCC_MP_AHB4LPENSETR_GPIOGLPEN                \ GPIOGLPEN
$00000080 constant RCC_RCC_MP_AHB4LPENSETR_GPIOHLPEN                \ GPIOHLPEN
$00000100 constant RCC_RCC_MP_AHB4LPENSETR_GPIOILPEN                \ GPIOILPEN
$00000200 constant RCC_RCC_MP_AHB4LPENSETR_GPIOJLPEN                \ GPIOJLPEN
$00000400 constant RCC_RCC_MP_AHB4LPENSETR_GPIOKLPEN                \ GPIOKLPEN


\
\ @brief This register is used by the MPU
\ Address offset: 0xB2C
\ Reset value: 0x000007FF
\

$00000001 constant RCC_RCC_MP_AHB4LPENCLRR_GPIOALPEN                \ GPIOALPEN
$00000002 constant RCC_RCC_MP_AHB4LPENCLRR_GPIOBLPEN                \ GPIOBLPEN
$00000004 constant RCC_RCC_MP_AHB4LPENCLRR_GPIOCLPEN                \ GPIOCLPEN
$00000008 constant RCC_RCC_MP_AHB4LPENCLRR_GPIODLPEN                \ GPIODLPEN
$00000010 constant RCC_RCC_MP_AHB4LPENCLRR_GPIOELPEN                \ GPIOELPEN
$00000020 constant RCC_RCC_MP_AHB4LPENCLRR_GPIOFLPEN                \ GPIOFLPEN
$00000040 constant RCC_RCC_MP_AHB4LPENCLRR_GPIOGLPEN                \ GPIOGLPEN
$00000080 constant RCC_RCC_MP_AHB4LPENCLRR_GPIOHLPEN                \ GPIOHLPEN
$00000100 constant RCC_RCC_MP_AHB4LPENCLRR_GPIOILPEN                \ GPIOILPEN
$00000200 constant RCC_RCC_MP_AHB4LPENCLRR_GPIOJLPEN                \ GPIOJLPEN
$00000400 constant RCC_RCC_MP_AHB4LPENCLRR_GPIOKLPEN                \ GPIOKLPEN


\
\ @brief This register is used by the MPU
\ Address offset: 0xB30
\ Reset value: 0x00000001
\

$00000001 constant RCC_RCC_MP_AXIMLPENSETR_SYSRAMLPEN               \ SYSRAMLPEN


\
\ @brief This register is used by the MPU
\ Address offset: 0xB34
\ Reset value: 0x00000001
\

$00000001 constant RCC_RCC_MP_AXIMLPENCLRR_SYSRAMLPEN               \ SYSRAMLPEN


\
\ @brief This register is used by the MPU in order to set the PERxLPEN bit
\ Address offset: 0xB38
\ Reset value: 0x00000017
\

$00000001 constant RCC_RCC_MP_MLAHBLPENSETR_SRAM1LPEN               \ SRAM1LPEN
$00000002 constant RCC_RCC_MP_MLAHBLPENSETR_SRAM2LPEN               \ SRAM2LPEN
$00000004 constant RCC_RCC_MP_MLAHBLPENSETR_SRAM34LPEN              \ SRAM34LPEN
$00000010 constant RCC_RCC_MP_MLAHBLPENSETR_RETRAMLPEN              \ RETRAMLPEN


\
\ @brief This register is used by the MPU in order to clear the PERxLPEN bit
\ Address offset: 0xB3C
\ Reset value: 0x00000017
\

$00000001 constant RCC_RCC_MP_MLAHBLPENCLRR_SRAM1LPEN               \ SRAM1LPEN
$00000002 constant RCC_RCC_MP_MLAHBLPENCLRR_SRAM2LPEN               \ SRAM2LPEN
$00000004 constant RCC_RCC_MP_MLAHBLPENCLRR_SRAM34LPEN              \ SRAM34LPEN
$00000010 constant RCC_RCC_MP_MLAHBLPENCLRR_RETRAMLPEN              \ RETRAMLPEN


\
\ @brief This register is used by the MCU in order to set the PERxLPEN bit.
\ Address offset: 0xB80
\ Reset value: 0xBDEFDBFF
\

$00000001 constant RCC_RCC_MC_APB1LPENSETR_TIM2LPEN                 \ TIM2LPEN
$00000002 constant RCC_RCC_MC_APB1LPENSETR_TIM3LPEN                 \ TIM3LPEN
$00000004 constant RCC_RCC_MC_APB1LPENSETR_TIM4LPEN                 \ TIM4LPEN
$00000008 constant RCC_RCC_MC_APB1LPENSETR_TIM5LPEN                 \ TIM5LPEN
$00000010 constant RCC_RCC_MC_APB1LPENSETR_TIM6LPEN                 \ TIM6LPEN
$00000020 constant RCC_RCC_MC_APB1LPENSETR_TIM7LPEN                 \ TIM7LPEN
$00000040 constant RCC_RCC_MC_APB1LPENSETR_TIM12LPEN                \ TIM12LPEN
$00000080 constant RCC_RCC_MC_APB1LPENSETR_TIM13LPEN                \ TIM13LPEN
$00000100 constant RCC_RCC_MC_APB1LPENSETR_TIM14LPEN                \ TIM14LPEN
$00000200 constant RCC_RCC_MC_APB1LPENSETR_LPTIM1LPEN               \ LPTIM1LPEN
$00000800 constant RCC_RCC_MC_APB1LPENSETR_SPI2LPEN                 \ SPI2LPEN
$00001000 constant RCC_RCC_MC_APB1LPENSETR_SPI3LPEN                 \ SPI3LPEN
$00004000 constant RCC_RCC_MC_APB1LPENSETR_USART2LPEN               \ USART2LPEN
$00008000 constant RCC_RCC_MC_APB1LPENSETR_USART3LPEN               \ USART3LPEN
$00010000 constant RCC_RCC_MC_APB1LPENSETR_UART4LPEN                \ UART4LPEN
$00020000 constant RCC_RCC_MC_APB1LPENSETR_UART5LPEN                \ UART5LPEN
$00040000 constant RCC_RCC_MC_APB1LPENSETR_UART7LPEN                \ UART7LPEN
$00080000 constant RCC_RCC_MC_APB1LPENSETR_UART8LPEN                \ UART8LPEN
$00200000 constant RCC_RCC_MC_APB1LPENSETR_I2C1LPEN                 \ I2C1LPEN
$00400000 constant RCC_RCC_MC_APB1LPENSETR_I2C2LPEN                 \ I2C2LPEN
$00800000 constant RCC_RCC_MC_APB1LPENSETR_I2C3LPEN                 \ I2C3LPEN
$01000000 constant RCC_RCC_MC_APB1LPENSETR_I2C5LPEN                 \ I2C5LPEN
$04000000 constant RCC_RCC_MC_APB1LPENSETR_SPDIFLPEN                \ SPDIFLPEN
$08000000 constant RCC_RCC_MC_APB1LPENSETR_CECLPEN                  \ CECLPEN
$10000000 constant RCC_RCC_MC_APB1LPENSETR_WWDG1LPEN                \ WWDG1LPEN
$20000000 constant RCC_RCC_MC_APB1LPENSETR_DAC12LPEN                \ DAC12LPEN
$80000000 constant RCC_RCC_MC_APB1LPENSETR_MDIOSLPEN                \ MDIOSLPEN


\
\ @brief This register is used by the MCU in order to clear the PERxLPEN bits
\ Address offset: 0xB84
\ Reset value: 0xBDEFDBFF
\

$00000001 constant RCC_RCC_MC_APB1LPENCLRR_TIM2LPEN                 \ TIM2LPEN
$00000002 constant RCC_RCC_MC_APB1LPENCLRR_TIM3LPEN                 \ TIM3LPEN
$00000004 constant RCC_RCC_MC_APB1LPENCLRR_TIM4LPEN                 \ TIM4LPEN
$00000008 constant RCC_RCC_MC_APB1LPENCLRR_TIM5LPEN                 \ TIM5LPEN
$00000010 constant RCC_RCC_MC_APB1LPENCLRR_TIM6LPEN                 \ TIM6LPEN
$00000020 constant RCC_RCC_MC_APB1LPENCLRR_TIM7LPEN                 \ TIM7LPEN
$00000040 constant RCC_RCC_MC_APB1LPENCLRR_TIM12LPEN                \ TIM12LPEN
$00000080 constant RCC_RCC_MC_APB1LPENCLRR_TIM13LPEN                \ TIM13LPEN
$00000100 constant RCC_RCC_MC_APB1LPENCLRR_TIM14LPEN                \ TIM14LPEN
$00000200 constant RCC_RCC_MC_APB1LPENCLRR_LPTIM1LPEN               \ LPTIM1LPEN
$00000800 constant RCC_RCC_MC_APB1LPENCLRR_SPI2LPEN                 \ SPI2LPEN
$00001000 constant RCC_RCC_MC_APB1LPENCLRR_SPI3LPEN                 \ SPI3LPEN
$00004000 constant RCC_RCC_MC_APB1LPENCLRR_USART2LPEN               \ USART2LPEN
$00008000 constant RCC_RCC_MC_APB1LPENCLRR_USART3LPEN               \ USART3LPEN
$00010000 constant RCC_RCC_MC_APB1LPENCLRR_UART4LPEN                \ UART4LPEN
$00020000 constant RCC_RCC_MC_APB1LPENCLRR_UART5LPEN                \ UART5LPEN
$00040000 constant RCC_RCC_MC_APB1LPENCLRR_UART7LPEN                \ UART7LPEN
$00080000 constant RCC_RCC_MC_APB1LPENCLRR_UART8LPEN                \ UART8LPEN
$00200000 constant RCC_RCC_MC_APB1LPENCLRR_I2C1LPEN                 \ I2C1LPEN
$00400000 constant RCC_RCC_MC_APB1LPENCLRR_I2C2LPEN                 \ I2C2LPEN
$00800000 constant RCC_RCC_MC_APB1LPENCLRR_I2C3LPEN                 \ I2C3LPEN
$01000000 constant RCC_RCC_MC_APB1LPENCLRR_I2C5LPEN                 \ I2C5LPEN
$04000000 constant RCC_RCC_MC_APB1LPENCLRR_SPDIFLPEN                \ SPDIFLPEN
$08000000 constant RCC_RCC_MC_APB1LPENCLRR_CECLPEN                  \ CECLPEN
$10000000 constant RCC_RCC_MC_APB1LPENCLRR_WWDG1LPEN                \ WWDG1LPEN
$20000000 constant RCC_RCC_MC_APB1LPENCLRR_DAC12LPEN                \ DAC12LPEN
$80000000 constant RCC_RCC_MC_APB1LPENCLRR_MDIOSLPEN                \ MDIOSLPEN


\
\ @brief This register is used by the MCU in order to set the PERxLPEN bit.
\ Address offset: 0xB88
\ Reset value: 0x0137271F
\

$00000001 constant RCC_RCC_MC_APB2LPENSETR_TIM1LPEN                 \ TIM1LPEN
$00000002 constant RCC_RCC_MC_APB2LPENSETR_TIM8LPEN                 \ TIM8LPEN
$00000004 constant RCC_RCC_MC_APB2LPENSETR_TIM15LPEN                \ TIM15LPEN
$00000008 constant RCC_RCC_MC_APB2LPENSETR_TIM16LPEN                \ TIM16LPEN
$00000010 constant RCC_RCC_MC_APB2LPENSETR_TIM17LPEN                \ TIM17LPEN
$00000100 constant RCC_RCC_MC_APB2LPENSETR_SPI1LPEN                 \ SPI1LPEN
$00000200 constant RCC_RCC_MC_APB2LPENSETR_SPI4LPEN                 \ SPI4LPEN
$00000400 constant RCC_RCC_MC_APB2LPENSETR_SPI5LPEN                 \ SPI5LPEN
$00002000 constant RCC_RCC_MC_APB2LPENSETR_USART6LPEN               \ USART6LPEN
$00010000 constant RCC_RCC_MC_APB2LPENSETR_SAI1LPEN                 \ SAI1LPEN
$00020000 constant RCC_RCC_MC_APB2LPENSETR_SAI2LPEN                 \ SAI2LPEN
$00040000 constant RCC_RCC_MC_APB2LPENSETR_SAI3LPEN                 \ SAI3LPEN
$00100000 constant RCC_RCC_MC_APB2LPENSETR_DFSDMLPEN                \ DFSDMLPEN
$00200000 constant RCC_RCC_MC_APB2LPENSETR_ADFSDMLPEN               \ ADFSDMLPEN
$01000000 constant RCC_RCC_MC_APB2LPENSETR_FDCANLPEN                \ FDCANLPEN


\
\ @brief This register is used by the MCU in order to clear the PERxLPEN bit
\ Address offset: 0xB8C
\ Reset value: 0x0137271F
\

$00000001 constant RCC_RCC_MC_APB2LPENCLRR_TIM1LPEN                 \ TIM1LPEN
$00000002 constant RCC_RCC_MC_APB2LPENCLRR_TIM8LPEN                 \ TIM8LPEN
$00000004 constant RCC_RCC_MC_APB2LPENCLRR_TIM15LPEN                \ TIM15LPEN
$00000008 constant RCC_RCC_MC_APB2LPENCLRR_TIM16LPEN                \ TIM16LPEN
$00000010 constant RCC_RCC_MC_APB2LPENCLRR_TIM17LPEN                \ TIM17LPEN
$00000100 constant RCC_RCC_MC_APB2LPENCLRR_SPI1LPEN                 \ SPI1LPEN
$00000200 constant RCC_RCC_MC_APB2LPENCLRR_SPI4LPEN                 \ SPI4LPEN
$00000400 constant RCC_RCC_MC_APB2LPENCLRR_SPI5LPEN                 \ SPI5LPEN
$00002000 constant RCC_RCC_MC_APB2LPENCLRR_USART6LPEN               \ USART6LPEN
$00010000 constant RCC_RCC_MC_APB2LPENCLRR_SAI1LPEN                 \ SAI1LPEN
$00020000 constant RCC_RCC_MC_APB2LPENCLRR_SAI2LPEN                 \ SAI2LPEN
$00040000 constant RCC_RCC_MC_APB2LPENCLRR_SAI3LPEN                 \ SAI3LPEN
$00100000 constant RCC_RCC_MC_APB2LPENCLRR_DFSDMLPEN                \ DFSDMLPEN
$00200000 constant RCC_RCC_MC_APB2LPENCLRR_ADFSDMLPEN               \ ADFSDMLPEN
$01000000 constant RCC_RCC_MC_APB2LPENCLRR_FDCANLPEN                \ FDCANLPEN


\
\ @brief This register is used by the MCU in order to set the PERxLPEN bit.
\ Address offset: 0xB90
\ Reset value: 0x0003290F
\

$00000001 constant RCC_RCC_MC_APB3LPENSETR_LPTIM2LPEN               \ LPTIM2LPEN
$00000002 constant RCC_RCC_MC_APB3LPENSETR_LPTIM3LPEN               \ LPTIM3LPEN
$00000004 constant RCC_RCC_MC_APB3LPENSETR_LPTIM4LPEN               \ LPTIM4LPEN
$00000008 constant RCC_RCC_MC_APB3LPENSETR_LPTIM5LPEN               \ LPTIM5LPEN
$00000100 constant RCC_RCC_MC_APB3LPENSETR_SAI4LPEN                 \ SAI4LPEN
$00000800 constant RCC_RCC_MC_APB3LPENSETR_SYSCFGLPEN               \ SYSCFGLPEN
$00002000 constant RCC_RCC_MC_APB3LPENSETR_VREFLPEN                 \ VREFLPEN
$00010000 constant RCC_RCC_MC_APB3LPENSETR_DTSLPEN                  \ DTSLPEN


\
\ @brief This register is used by the MCU in order to clear the PERxLPEN bit
\ Address offset: 0xB94
\ Reset value: 0x0003290F
\

$00000001 constant RCC_RCC_MC_APB3LPENCLRR_LPTIM2LPEN               \ LPTIM2LPEN
$00000002 constant RCC_RCC_MC_APB3LPENCLRR_LPTIM3LPEN               \ LPTIM3LPEN
$00000004 constant RCC_RCC_MC_APB3LPENCLRR_LPTIM4LPEN               \ LPTIM4LPEN
$00000008 constant RCC_RCC_MC_APB3LPENCLRR_LPTIM5LPEN               \ LPTIM5LPEN
$00000100 constant RCC_RCC_MC_APB3LPENCLRR_SAI4LPEN                 \ SAI4LPEN
$00000800 constant RCC_RCC_MC_APB3LPENCLRR_SYSCFGLPEN               \ SYSCFGLPEN
$00002000 constant RCC_RCC_MC_APB3LPENCLRR_VREFLPEN                 \ VREFLPEN
$00010000 constant RCC_RCC_MC_APB3LPENCLRR_DTSLPEN                  \ DTSLPEN


\
\ @brief This register is used by the MCU in order to set the PERxLPEN bit.
\ Address offset: 0xB98
\ Reset value: 0x00010127
\

$00000001 constant RCC_RCC_MC_AHB2LPENSETR_DMA1LPEN                 \ DMA1LPEN
$00000002 constant RCC_RCC_MC_AHB2LPENSETR_DMA2LPEN                 \ DMA2LPEN
$00000004 constant RCC_RCC_MC_AHB2LPENSETR_DMAMUXLPEN               \ DMAMUXLPEN
$00000020 constant RCC_RCC_MC_AHB2LPENSETR_ADC12LPEN                \ ADC12LPEN
$00000100 constant RCC_RCC_MC_AHB2LPENSETR_USBOLPEN                 \ USBOLPEN
$00010000 constant RCC_RCC_MC_AHB2LPENSETR_SDMMC3LPEN               \ SDMMC3LPEN


\
\ @brief This register is used by the MCU in order to clear the PERxLPEN bit
\ Address offset: 0xB9C
\ Reset value: 0x00010127
\

$00000001 constant RCC_RCC_MC_AHB2LPENCLRR_DMA1LPEN                 \ DMA1LPEN
$00000002 constant RCC_RCC_MC_AHB2LPENCLRR_DMA2LPEN                 \ DMA2LPEN
$00000004 constant RCC_RCC_MC_AHB2LPENCLRR_DMAMUXLPEN               \ DMAMUXLPEN
$00000020 constant RCC_RCC_MC_AHB2LPENCLRR_ADC12LPEN                \ ADC12LPEN
$00000100 constant RCC_RCC_MC_AHB2LPENCLRR_USBOLPEN                 \ USBOLPEN
$00010000 constant RCC_RCC_MC_AHB2LPENCLRR_SDMMC3LPEN               \ SDMMC3LPEN


\
\ @brief This register is used by the MCU in order to set the PERxLPEN bit.
\ Address offset: 0xBA0
\ Reset value: 0x000018F1
\

$00000001 constant RCC_RCC_MC_AHB3LPENSETR_DCMILPEN                 \ DCMILPEN
$00000010 constant RCC_RCC_MC_AHB3LPENSETR_CRYP2LPEN                \ CRYP2LPEN
$00000020 constant RCC_RCC_MC_AHB3LPENSETR_HASH2LPEN                \ HASH2LPEN
$00000040 constant RCC_RCC_MC_AHB3LPENSETR_RNG2LPEN                 \ RNG2LPEN
$00000080 constant RCC_RCC_MC_AHB3LPENSETR_CRC2LPEN                 \ CRC2LPEN
$00000800 constant RCC_RCC_MC_AHB3LPENSETR_HSEMLPEN                 \ HSEMLPEN
$00001000 constant RCC_RCC_MC_AHB3LPENSETR_IPCCLPEN                 \ IPCCLPEN


\
\ @brief This register is used by the MCU in order to clear the PERxLPEN bit
\ Address offset: 0xBA4
\ Reset value: 0x000018F1
\

$00000001 constant RCC_RCC_MC_AHB3LPENCLRR_DCMILPEN                 \ DCMILPEN
$00000010 constant RCC_RCC_MC_AHB3LPENCLRR_CRYP2LPEN                \ CRYP2LPEN
$00000020 constant RCC_RCC_MC_AHB3LPENCLRR_HASH2LPEN                \ HASH2LPEN
$00000040 constant RCC_RCC_MC_AHB3LPENCLRR_RNG2LPEN                 \ RNG2LPEN
$00000080 constant RCC_RCC_MC_AHB3LPENCLRR_CRC2LPEN                 \ CRC2LPEN
$00000800 constant RCC_RCC_MC_AHB3LPENCLRR_HSEMLPEN                 \ HSEMLPEN
$00001000 constant RCC_RCC_MC_AHB3LPENCLRR_IPCCLPEN                 \ IPCCLPEN


\
\ @brief This register is used by the MCU in order to set the PERxLPEN bit.
\ Address offset: 0xBA8
\ Reset value: 0x000007FF
\

$00000001 constant RCC_RCC_MC_AHB4LPENSETR_GPIOALPEN                \ GPIOALPEN
$00000002 constant RCC_RCC_MC_AHB4LPENSETR_GPIOBLPEN                \ GPIOBLPEN
$00000004 constant RCC_RCC_MC_AHB4LPENSETR_GPIOCLPEN                \ GPIOCLPEN
$00000008 constant RCC_RCC_MC_AHB4LPENSETR_GPIODLPEN                \ GPIODLPEN
$00000010 constant RCC_RCC_MC_AHB4LPENSETR_GPIOELPEN                \ GPIOELPEN
$00000020 constant RCC_RCC_MC_AHB4LPENSETR_GPIOFLPEN                \ GPIOFLPEN
$00000040 constant RCC_RCC_MC_AHB4LPENSETR_GPIOGLPEN                \ GPIOGLPEN
$00000080 constant RCC_RCC_MC_AHB4LPENSETR_GPIOHLPEN                \ GPIOHLPEN
$00000100 constant RCC_RCC_MC_AHB4LPENSETR_GPIOILPEN                \ GPIOILPEN
$00000200 constant RCC_RCC_MC_AHB4LPENSETR_GPIOJLPEN                \ GPIOJLPEN
$00000400 constant RCC_RCC_MC_AHB4LPENSETR_GPIOKLPEN                \ GPIOKLPEN


\
\ @brief This register is used by the MCU in order to clear the PERxLPEN bit of the corresponding peripheral.
\ Address offset: 0xBAC
\ Reset value: 0x000007FF
\

$00000001 constant RCC_RCC_MC_AHB4LPENCLRR_GPIOALPEN                \ GPIOALPEN
$00000002 constant RCC_RCC_MC_AHB4LPENCLRR_GPIOBLPEN                \ GPIOBLPEN
$00000004 constant RCC_RCC_MC_AHB4LPENCLRR_GPIOCLPEN                \ GPIOCLPEN
$00000008 constant RCC_RCC_MC_AHB4LPENCLRR_GPIODLPEN                \ GPIODLPEN
$00000010 constant RCC_RCC_MC_AHB4LPENCLRR_GPIOELPEN                \ GPIOELPEN
$00000020 constant RCC_RCC_MC_AHB4LPENCLRR_GPIOFLPEN                \ GPIOFLPEN
$00000040 constant RCC_RCC_MC_AHB4LPENCLRR_GPIOGLPEN                \ GPIOGLPEN
$00000080 constant RCC_RCC_MC_AHB4LPENCLRR_GPIOHLPEN                \ GPIOHLPEN
$00000100 constant RCC_RCC_MC_AHB4LPENCLRR_GPIOILPEN                \ GPIOILPEN
$00000200 constant RCC_RCC_MC_AHB4LPENCLRR_GPIOJLPEN                \ GPIOJLPEN
$00000400 constant RCC_RCC_MC_AHB4LPENCLRR_GPIOKLPEN                \ GPIOKLPEN


\
\ @brief This register is used by the MCU in order to set the PERxLPEN bit of the corresponding peripheral.
\ Address offset: 0xBB0
\ Reset value: 0x00000001
\

$00000001 constant RCC_RCC_MC_AXIMLPENSETR_SYSRAMLPEN               \ SYSRAMLPEN


\
\ @brief This register is used by the MCU in order to clear the PERxLPEN bit of the corresponding peripheral.
\ Address offset: 0xBB4
\ Reset value: 0x00000001
\

$00000001 constant RCC_RCC_MC_AXIMLPENCLRR_SYSRAMLPEN               \ SYSRAMLPEN


\
\ @brief This register is used by the MCU in order to set the PERxLPEN bit of the corresponding peripheral.
\ Address offset: 0xBB8
\ Reset value: 0x00000017
\

$00000001 constant RCC_RCC_MC_MLAHBLPENSETR_SRAM1LPEN               \ SRAM1LPEN
$00000002 constant RCC_RCC_MC_MLAHBLPENSETR_SRAM2LPEN               \ SRAM2LPEN
$00000004 constant RCC_RCC_MC_MLAHBLPENSETR_SRAM34LPEN              \ SRAM34LPEN
$00000010 constant RCC_RCC_MC_MLAHBLPENSETR_RETRAMLPEN              \ RETRAMLPEN


\
\ @brief This register is used by the MCU in order to clear the PERxLPEN bit of the corresponding peripheral.
\ Address offset: 0xBBC
\ Reset value: 0x00000017
\

$00000001 constant RCC_RCC_MC_MLAHBLPENCLRR_SRAM1LPEN               \ SRAM1LPEN
$00000002 constant RCC_RCC_MC_MLAHBLPENCLRR_SRAM2LPEN               \ SRAM2LPEN
$00000004 constant RCC_RCC_MC_MLAHBLPENCLRR_SRAM34LPEN              \ SRAM34LPEN
$00000010 constant RCC_RCC_MC_MLAHBLPENCLRR_RETRAMLPEN              \ RETRAMLPEN


\
\ @brief This register is used by the MCU to check the reset source.
\ Address offset: 0xC00
\ Reset value: 0x00000015
\

$00000001 constant RCC_RCC_MC_RSTSCLRR_PORRSTF                      \ PORRSTF
$00000002 constant RCC_RCC_MC_RSTSCLRR_BORRSTF                      \ BORRSTF
$00000004 constant RCC_RCC_MC_RSTSCLRR_PADRSTF                      \ PADRSTF
$00000008 constant RCC_RCC_MC_RSTSCLRR_HCSSRSTF                     \ HCSSRSTF
$00000010 constant RCC_RCC_MC_RSTSCLRR_VCORERSTF                    \ VCORERSTF
$00000020 constant RCC_RCC_MC_RSTSCLRR_MCURSTF                      \ MCURSTF
$00000040 constant RCC_RCC_MC_RSTSCLRR_MPSYSRSTF                    \ MPSYSRSTF
$00000080 constant RCC_RCC_MC_RSTSCLRR_MCSYSRSTF                    \ MCSYSRSTF
$00000100 constant RCC_RCC_MC_RSTSCLRR_IWDG1RSTF                    \ IWDG1RSTF
$00000200 constant RCC_RCC_MC_RSTSCLRR_IWDG2RSTF                    \ IWDG2RSTF
$00000400 constant RCC_RCC_MC_RSTSCLRR_WWDG1RSTF                    \ WWDG1RSTF


\
\ @brief This register shall be used by the MCU to control the interrupt source enable. Refer to Section10.5: RCC interrupts for more details.
\ Address offset: 0xC14
\ Reset value: 0x00000000
\

$00000001 constant RCC_RCC_MC_CIER_LSIRDYIE                         \ LSIRDYIE
$00000002 constant RCC_RCC_MC_CIER_LSERDYIE                         \ LSERDYIE
$00000004 constant RCC_RCC_MC_CIER_HSIRDYIE                         \ HSIRDYIE
$00000008 constant RCC_RCC_MC_CIER_HSERDYIE                         \ HSERDYIE
$00000010 constant RCC_RCC_MC_CIER_CSIRDYIE                         \ CSIRDYIE
$00000100 constant RCC_RCC_MC_CIER_PLL1DYIE                         \ PLL1DYIE
$00000200 constant RCC_RCC_MC_CIER_PLL2DYIE                         \ PLL2DYIE
$00000400 constant RCC_RCC_MC_CIER_PLL3DYIE                         \ PLL3DYIE
$00000800 constant RCC_RCC_MC_CIER_PLL4DYIE                         \ PLL4DYIE
$00010000 constant RCC_RCC_MC_CIER_LSECSSIE                         \ LSECSSIE
$00100000 constant RCC_RCC_MC_CIER_WKUPIE                           \ WKUPIE


\
\ @brief This register shall be used by the MCU in order to read and clear the interrupt flags.
\ Address offset: 0xC18
\ Reset value: 0x00000000
\

$00000001 constant RCC_RCC_MC_CIFR_LSIRDYF                          \ LSIRDYF
$00000002 constant RCC_RCC_MC_CIFR_LSERDYF                          \ LSERDYF
$00000004 constant RCC_RCC_MC_CIFR_HSIRDYF                          \ HSIRDYF
$00000008 constant RCC_RCC_MC_CIFR_HSERDYF                          \ HSERDYF
$00000010 constant RCC_RCC_MC_CIFR_CSIRDYF                          \ CSIRDYF
$00000100 constant RCC_RCC_MC_CIFR_PLL1DYF                          \ PLL1DYF
$00000200 constant RCC_RCC_MC_CIFR_PLL2DYF                          \ PLL2DYF
$00000400 constant RCC_RCC_MC_CIFR_PLL3DYF                          \ PLL3DYF
$00000800 constant RCC_RCC_MC_CIFR_PLL4DYF                          \ PLL4DYF
$00010000 constant RCC_RCC_MC_CIFR_LSECSSF                          \ LSECSSF
$00100000 constant RCC_RCC_MC_CIFR_WKUPF                            \ WKUPF


\
\ @brief This register gives the IP version
\ Address offset: 0xFF4
\ Reset value: 0x00000011
\

$0000000f constant RCC_RCC_VERR_MINREV                              \ MINREV
$000000f0 constant RCC_RCC_VERR_MAJREV                              \ MAJREV


\
\ @brief This register gives the unique identifier of the RCC
\ Address offset: 0xFF8
\ Reset value: 0x00000001
\

$00000000 constant RCC_RCC_IDR_ID                                   \ ID


\
\ @brief This register gives the decoding space, which is for the RCC of 4 kB.
\ Address offset: 0xFFC
\ Reset value: 0xA3C5DD04
\

$00000000 constant RCC_RCC_SIDR_SID                                 \ SID


\
\ @brief RCC
\
$50000000 constant RCC_RCC_TZCR   \ offset: 0x00 : This register is used to switch the RCC into secure mode. This register can only be accessed in secure mode.
$5000000c constant RCC_RCC_OCENSETR  \ offset: 0x0C : This register is used to control the oscillators.Writing to this register has no effect, writing will set the corresponding bits. Reading will give the effective values of each bit.If TZEN = MCKPROT = , this register can only be modified in secure mode. Write access to this register is not allowed during the clock restore sequence. See Section: The clock restore sequence description for details.
$50000010 constant RCC_RCC_OCENCLRR  \ offset: 0x10 : This register is used to control the oscillators.Writing to this register has no effect, writing will clear the corresponding bits. Reading will give the effective values of the enable bits.If TZEN = , this register can only be modified in secure mode. Write access to this register is not allowed during the clock restore sequence. See Section: The clock restore sequence description for details.
$50000018 constant RCC_RCC_HSICFGR  \ offset: 0x18 : This register is used to configure the HSI. If TZEN = , this register can only be modified in secure mode. Write access to this register is not allowed during the clock restore sequence. See Section: The clock restore sequence description for details.
$5000001c constant RCC_RCC_CSICFGR  \ offset: 0x1C : This register is used to fine-tune the CSI frequency. If TZEN = MCKPROT = , this register can only be modified in secure mode. Write access to this register is not allowed during the clock restore sequence. See The clock restore sequence description for details.
$50000020 constant RCC_RCC_MPCKSELR  \ offset: 0x20 : This register is used to select the clock source for the MPU. If TZEN = , this register can only be modified in secure mode. Write access to this register is not allowed during the clock restore sequence. See Section: The clock restore sequence description for details.
$50000024 constant RCC_RCC_ASSCKSELR  \ offset: 0x24 : This register is used to select the clock source for the AXI sub-system. If TZEN = , this register can only be modified in secure mode. Write access to this register is not allowed during the clock restore sequence. See Section: The clock restore sequence description for details.
$50000028 constant RCC_RCC_RCK12SELR  \ offset: 0x28 : This register is used to select the reference clock for PLL1 and PLL2. If TZEN = , this register can only be modified in secure mode. Write access to this register is not allowed during the clock restore sequence. See Section: The clock restore sequence description for details.
$5000002c constant RCC_RCC_MPCKDIVR  \ offset: 0x2C : This register is used to control the MPU clock prescaler. Refer to Section: Sub-system clock generation for additional information. If TZEN = , this register can only be modified in secure mode.
$50000030 constant RCC_RCC_AXIDIVR  \ offset: 0x30 : This register is used to control the AXI Matrix clock prescaler. Refer to Section: Sub-system clock generation for additional information. If TZEN = , this register can only be modified in secure mode.
$5000003c constant RCC_RCC_APB4DIVR  \ offset: 0x3C : This register is used to control the APB4 clock divider. Refer to Section: Sub-system clock generation for additional information. If TZEN = , this register can only be modified in secure mode.
$50000040 constant RCC_RCC_APB5DIVR  \ offset: 0x40 : This register is used to control the APB5 clock divider. Refer to Section: Sub-system clock generation for additional information. If TZEN = , this register can only be modified in secure mode.
$50000044 constant RCC_RCC_RTCDIVR  \ offset: 0x44 : This register is used to divide the HSE clock for RTC. If TZEN = , this register can only be modified in secure mode.
$50000048 constant RCC_RCC_MSSCKSELR  \ offset: 0x48 : This register is used to select the clock source for the MCU sub-system, including the MCU itself. If TZEN = MCKPROT = , this register can only be modified in secure mode. Write access to this register is not allowed during the clock restore sequence. See Section: The clock restore sequence description for details.
$50000080 constant RCC_RCC_PLL1CR  \ offset: 0x80 : This register is used to control the PLL1. If TZEN = , this register can only be modified in secure mode. Write access to this register is not allowed during the clock restore sequence. See Section: The clock restore sequence description for details.
$50000084 constant RCC_RCC_PLL1CFGR1  \ offset: 0x84 : This register is used to configure the PLL1. If TZEN = , this register can only be modified in secure mode. Write access to this register is not allowed during the clock restore sequence. See Section: The clock restore sequence description for details.
$50000088 constant RCC_RCC_PLL1CFGR2  \ offset: 0x88 : This register is used to configure the PLL1. If TZEN = , this register can only be modified in secure mode. Write access to this register is not allowed during the clock restore sequence. See Section: The clock restore sequence description for details.
$5000008c constant RCC_RCC_PLL1FRACR  \ offset: 0x8C : This register is used to fine-tune the frequency of the PLL1 VCO. If TZEN = , this register can only be modified in secure mode. Write access to this register is not allowed during the clock restore sequence. See Section: The clock restore sequence description for details.
$50000090 constant RCC_RCC_PLL1CSGR  \ offset: 0x90 : This register is used to configure the PLL1.It is not recommended to change the content of this register when the PLL1 is enabled (PLLON = ). Refer to Section: Using the PLLs in spread spectrum mode for details. If TZEN = , this register can only be modified in secure mode. Write access to this register is not allowed during the clock restore sequence. See Section: The clock restore sequence description for details.
$50000094 constant RCC_RCC_PLL2CR  \ offset: 0x94 : This register is used to control the PLL2. If TZEN = , this register can only be modified in secure mode. Write access to this register is not allowed during the clock restore sequence. See Section: The clock restore sequence description for details.
$50000098 constant RCC_RCC_PLL2CFGR1  \ offset: 0x98 : This register is used to configure the PLL2. If TZEN = , this register can only be modified in secure mode. Write access to this register is not allowed during the clock restore sequence. See Section: The clock restore sequence description for details.
$5000009c constant RCC_RCC_PLL2CFGR2  \ offset: 0x9C : This register is used to configure the PLL2. If TZEN = , this register can only be modified in secure mode. Write access to this register is not allowed during the clock restore sequence. See Section: The clock restore sequence description for details.
$500000a0 constant RCC_RCC_PLL2FRACR  \ offset: 0xA0 : This register is used to fine-tune the frequency of the PLL2 VCO. If TZEN = , this register can only be modified in secure mode. Write access to this register is not allowed during the clock restore sequence. See Section: The clock restore sequence description for details.
$500000a4 constant RCC_RCC_PLL2CSGR  \ offset: 0xA4 : This register is used to configure the PLL2. It is not recommended to change the content of this register when the PLL2 is enabled (PLLON = ). Refer to Section: Using the PLLs in spread spectrum mode for details. If TZEN = , this register can only be modified in secure mode. Write access to this register is not allowed during the clock restore sequence. See Section: The clock restore sequence description for details.
$500000c0 constant RCC_RCC_I2C46CKSELR  \ offset: 0xC0 : This register is used to control the selection of the kernel clock for the I2C4 and I2C6. Note that changing the clock source on-the-fly is allowed, and will not generate any timing violation, however the user has to ensure that both the previous and the new clock sources are present during the switching, and for the whole transition time. Refer to Section: Clock enabling delays. If TZEN = , this register can only be modified in secure mode.
$500000c4 constant RCC_RCC_SPI6CKSELR  \ offset: 0xC4 : This register is used to control the selection of the kernel clock for the SPI6. Note that changing the clock source on-the-fly is allowed, and will not generate any timing violation, however the user has to ensure that both the previous and the new clock sources are present during the switching, and for the whole transition time. Refer to Section: Clock enabling delays. If TZEN = , this register can only be modified in secure mode.
$500000c8 constant RCC_RCC_UART1CKSELR  \ offset: 0xC8 : This register is used to control the selection of the kernel clock for the USART1. Note that changing the clock source on-the-fly is allowed, and will not generate any timing violation, however the user has to ensure that both the previous and the new clock sources are present during the switching, and for the whole transition time. Refer to Section: Clock enabling delays. If TZEN = , this register can only be modified in secure mode.
$500000cc constant RCC_RCC_RNG1CKSELR  \ offset: 0xCC : This register is used to control the selection of the kernel clock for the RNG1. Note that changing the clock source on-the-fly is allowed, and will not generate any timing violation, however the user has to ensure that both the previous and the new clock sources are present during the switching, and for the whole transition time. Refer to Section: Clock enabling delays. If TZEN = , this register can only be modified in secure mode.
$500000d0 constant RCC_RCC_CPERCKSELR  \ offset: 0xD0 : This register is used to select an oscillator source as kernel clock for the per_ck clock. The per_ck clock is distributed to several peripherals. Refer to Section: Clock enabling delays.
$500000d4 constant RCC_RCC_STGENCKSELR  \ offset: 0xD4 : This register is used to select the peripheral clock for the STGEN block. Note that this clock is used to provide a time reference for the application. Refer to Section: Clock enabling delays. If TZEN = , this register can only be modified in secure mode.
$500000d8 constant RCC_RCC_DDRITFCR  \ offset: 0xD8 : This register is used to control the DDR interface, including the DDRC and DDRPHYC. If TZEN = , this register can only be modified in secure mode.
$50000100 constant RCC_RCC_MP_BOOTCR  \ offset: 0x100 : This register is used to control the HOLD boot function when the system exits from Standby. Refer to Section: MCU HOLD_BOOT after processor reset. This register is reset when a system reset occurs, but not when the circuit exits from Standby (app_rst reset).If TZEN = , this register can only be modified in secure mode. This register can only be accessed by the MPU.
$50000104 constant RCC_RCC_MP_SREQSETR  \ offset: 0x104 : Writing has no effect, reading will return the values of the bits. Writing a sets the corresponding bit to . The MCU cannot access to this register. If TZEN = , this register can only be modified in secure mode.
$50000108 constant RCC_RCC_MP_SREQCLRR  \ offset: 0x108 : Writing has no effect, reading will return the effective values of the bits. Writing a sets the corresponding bit to . The MCU cannot access to this register. If TZEN = , this register can only be modified in secure mode.
$5000010c constant RCC_RCC_MP_GCR  \ offset: 0x10C : The register contains global control bits. If TZEN = , this register can only be modified in secure mode.
$50000110 constant RCC_RCC_MP_APRSTCR  \ offset: 0x110 : This register is used to control the behavior of the warm reset. If TZEN = , this register can only be modified in secure mode.
$50000114 constant RCC_RCC_MP_APRSTSR  \ offset: 0x114 : This register provides a status of the RDCTL. If TZEN = , this register can only be modified in secure mode.
$50000140 constant RCC_RCC_BDCR   \ offset: 0x140 : This register is used to control the LSE function. Wait states are inserted in case of successive write accesses to this register. The number of wait states may be up to 7 cycles of AHB4 clock.After a system reset, the register RCC_BDCR is write-protected. In order to modify this register, the DBP bit in the PWR control register 1 (PWR_CR1) has to be set to . Bits of RCC_BDCR register are only reset after a backup domain reset: nreset_vsw (see Section10.3.6: Backup domain reset). Any other internal or external reset will not have any effect on these bits.This register is located into the VSW domain. If TZEN = , this register can only be modified in secure mode.
$50000144 constant RCC_RCC_RDLSICR  \ offset: 0x144 : This register is used to control the minimum NRST active duration and LSI function.0 to 7 wait states are inserted for word, half-word and byte accesses. Wait states are inserted in case of successive accesses to this register.This register is reset by the por_rst reset, and it is located into the VDD domain. If TZEN = , this register can only be modified in secure mode.
$50000180 constant RCC_RCC_APB4RSTSETR  \ offset: 0x180 : This register is used to activate the reset of the corresponding peripheral. Writing has no effect, reading will return the effective values of the corresponding bits. Writing a activates the reset of the corresponding peripheral.
$50000184 constant RCC_RCC_APB4RSTCLRR  \ offset: 0x184 : This register is used to release the reset of the corresponding peripheral. Writing has no effect, reading will return the effective values of the corresponding bits. Writing a releases the reset of the corresponding peripheral.
$50000188 constant RCC_RCC_APB5RSTSETR  \ offset: 0x188 : This register is used to activate the reset of the corresponding peripheral. Writing has no effect, reading will return the effective values of the corresponding bits. Writing a activates the reset of the corresponding peripheral. If TZEN = , this register can only be modified in secure mode.
$5000018c constant RCC_RCC_APB5RSTCLRR  \ offset: 0x18C : This register is used to release the reset of the corresponding peripheral. Writing has no effect, reading will return the effective values of the corresponding bits. Writing a releases the reset of the corresponding peripheral. If TZEN = , this register can only be modified in secure mode.
$50000190 constant RCC_RCC_AHB5RSTSETR  \ offset: 0x190 : This register is used to activate the reset of the corresponding peripheral. Writing has no effect, reading will return the effective values of the corresponding bits. Writing a activates the reset of the corresponding peripheral. If TZEN = , this register can only be modified in secure mode.
$50000194 constant RCC_RCC_AHB5RSTCLRR  \ offset: 0x194 : This register is used to release the reset of the corresponding peripheral. Writing has no effect, reading will return the effective values of the corresponding bits. Writing a releases the reset of the corresponding peripheral. If TZEN = , this register can only be modified in secure mode.
$50000198 constant RCC_RCC_AHB6RSTSETR  \ offset: 0x198 : This register is used to activate the reset of the corresponding peripheral. Writing has no effect, reading will return the effective values of the corresponding bits. Writing a activates the reset of the corresponding peripheral.
$5000019c constant RCC_RCC_AHB6RSTCLRR  \ offset: 0x19C : This register is used to release the reset of the corresponding peripheral. Writing has no effect, reading will return the effective values of the corresponding bits. Writing a releases the reset of the corresponding peripheral.
$500001a0 constant RCC_RCC_TZAHB6RSTSETR  \ offset: 0x1A0 : This register is used to activate the reset of the corresponding peripheral. Writing has no effect, reading will return the effective values of the corresponding bits. Writing a activates the reset of the corresponding peripheral. If TZEN = , this register can only be modified in secure mode.
$500001a4 constant RCC_RCC_TZAHB6RSTCLRR  \ offset: 0x1A4 : This register is used to release the reset of the corresponding peripheral. Writing has no effect, reading will return the effective values of the corresponding bits. Writing a releases the reset of the corresponding peripheral. If TZEN = , this register can only be modified in secure mode.
$50000200 constant RCC_RCC_MP_APB4ENSETR  \ offset: 0x200 : This register is used to set the peripheral clock enable bit of the corresponding peripheral to . It shall be used to allocate a peripheral to the MPU. Writing has no effect, reading will return the effective values of the corresponding bits. Writing a sets the corresponding bit to .
$50000204 constant RCC_RCC_MP_APB4ENCLRR  \ offset: 0x204 : This register is used to clear the peripheral clock enable bit of the corresponding peripheral. It shall be used to deallocate a peripheral from MPU. Writing has no effect, reading will return the effective values of the corresponding bits. Writing a sets the corresponding bit to .
$50000208 constant RCC_RCC_MP_APB5ENSETR  \ offset: 0x208 : This register is used to set the peripheral clock enable bit of the corresponding peripheral to . It shall be used to allocate a peripheral to the MPU. Writing has no effect, reading will return the effective values of the corresponding bits. Writing a sets the corresponding bit to .
$5000020c constant RCC_RCC_MP_APB5ENCLRR  \ offset: 0x20C : This register is used to clear the peripheral clock enable bit of the corresponding peripheral. It shall be used to deallocate a peripheral from MPU. Writing has no effect, reading will return the effective values of the corresponding bits. Writing a sets the corresponding bit to .
$50000210 constant RCC_RCC_MP_AHB5ENSETR  \ offset: 0x210 : This register is used to set the peripheral clock enable bit of the corresponding peripheral to . It shall be used to allocate a peripheral to the MPU. Writing has no effect, reading will return the effective values of the corresponding bits. Writing a sets the corresponding bit to . If TZEN = , this register can only be modified in secure mode.
$50000214 constant RCC_RCC_MP_AHB5ENCLRR  \ offset: 0x214 : This register is used to clear the peripheral clock enable bit of the corresponding peripheral. It shall be used to deallocate a peripheral from MPU. Writing has no effect, reading will return the effective values of the corresponding bits. Writing a sets the corresponding bit to . If TZEN = , this register can only be modified in secure mode.
$50000218 constant RCC_RCC_MP_AHB6ENSETR  \ offset: 0x218 : This register is used to set the peripheral clock enable bit of the corresponding peripheral to . It shall be used to allocate a peripheral to the MPU. Writing has no effect, reading will return the effective values of the corresponding bits. Writing a sets the corresponding bit to .
$5000021c constant RCC_RCC_MP_AHB6ENCLRR  \ offset: 0x21C : This register is used to clear the peripheral clock enable bit of the corresponding peripheral. It shall be used to deallocate a peripheral from MPU. Writing has no effect, reading will return the effective values of the corresponding bits. Writing a sets the corresponding bit to .
$50000220 constant RCC_RCC_MP_TZAHB6ENSETR  \ offset: 0x220 : This register is used to set the peripheral clock enable bit of the corresponding peripheral to . It shall be used to allocate a peripheral to the MPU. Writing has no effect, reading will return the effective values of the corresponding bits. Writing a sets the corresponding bit to . If TZEN = , this register can only be modified in secure mode.
$50000224 constant RCC_RCC_MP_TZAHB6ENCLRR  \ offset: 0x224 : This register is used to clear the peripheral clock enable bit of the corresponding peripheral. It shall be used to deallocate a peripheral from MPU. Writing has no effect, reading will return the effective values of the corresponding bits. Writing a sets the corresponding bit to . If TZEN = , this register can only be modified in secure mode.
$50000280 constant RCC_RCC_MC_APB4ENSETR  \ offset: 0x280 : This register is used to set the peripheral clock enable bit
$50000284 constant RCC_RCC_MC_APB4ENCLRR  \ offset: 0x284 : This register is used to clear the peripheral clock enable bit
$50000288 constant RCC_RCC_MC_APB5ENSETR  \ offset: 0x288 : This register is used to set the peripheral clock enable bit
$5000028c constant RCC_RCC_MC_APB5ENCLRR  \ offset: 0x28C : This register is used to clear the peripheral clock enable bit
$50000290 constant RCC_RCC_MC_AHB5ENSETR  \ offset: 0x290 : This register is used to set the peripheral clock enable bit If TZEN = , this register can only be modified in secure mode.
$50000294 constant RCC_RCC_MC_AHB5ENCLRR  \ offset: 0x294 : This register is used to clear the peripheral clock enable bit If TZEN = , this register can only be modified in secure mode.
$50000298 constant RCC_RCC_MC_AHB6ENSETR  \ offset: 0x298 : This register is used to set the peripheral clock enable bit
$5000029c constant RCC_RCC_MC_AHB6ENCLRR  \ offset: 0x29C : This register is used to clear the peripheral clock enable bit
$50000300 constant RCC_RCC_MP_APB4LPENSETR  \ offset: 0x300 : This register is used by the MCU in order to clear the PERxLPEN bits
$50000304 constant RCC_RCC_MP_APB4LPENCLRR  \ offset: 0x304 : This register is used by the MCU
$50000308 constant RCC_RCC_MP_APB5LPENSETR  \ offset: 0x308 : This register is used by the MCU in order to clear the PERxLPEN bits If TZEN = , this register can only be modified in secure mode.
$5000030c constant RCC_RCC_MP_APB5LPENCLRR  \ offset: 0x30C : This register is used by the Mpu.
$50000310 constant RCC_RCC_MP_AHB5LPENSETR  \ offset: 0x310 : This register is used by the MCU in order to clear the PERxLPEN bits If TZEN = , this register can only be modified in secure mode.
$50000314 constant RCC_RCC_MP_AHB5LPENCLRR  \ offset: 0x314 : This register is used by the MCU
$50000318 constant RCC_RCC_MP_AHB6LPENSETR  \ offset: 0x318 : This register is used by the MCU in order to clear the PERxLPEN bits
$5000031c constant RCC_RCC_MP_AHB6LPENCLRR  \ offset: 0x31C : This register is used by the MCU in order to clear the PERxLPEN bits
$50000320 constant RCC_RCC_MP_TZAHB6LPENSETR  \ offset: 0x320 : This register is used by the MCU in order to clear the PERxLPEN bits If TZEN = , this register can only be modified in secure mode.
$50000324 constant RCC_RCC_MP_TZAHB6LPENCLRR  \ offset: 0x324 : This register is used by the MCU in order to clear the PERxLPEN bits If TZEN = , this register can only be modified in secure mode.
$50000380 constant RCC_RCC_MC_APB4LPENSETR  \ offset: 0x380 : This register is used by the MCU in order to set the PERxLPEN bit.
$50000384 constant RCC_RCC_MC_APB4LPENCLRR  \ offset: 0x384 : This register is used by the MCU in order to clear the PERxLPEN bit
$50000388 constant RCC_RCC_MC_APB5LPENSETR  \ offset: 0x388 : This register is used by the MCU in order to set the PERxLPEN bit.
$5000038c constant RCC_RCC_MC_APB5LPENCLRR  \ offset: 0x38C : This register is used by the MCU in order to clear the PERxLPEN bit
$50000390 constant RCC_RCC_MC_AHB5LPENSETR  \ offset: 0x390 : This register is used by the MCU in order to set the PERxLPEN bit. If TZEN = , this register can only be modified in secure mode.
$50000394 constant RCC_RCC_MC_AHB5LPENCLRR  \ offset: 0x394 : This register is used by the MCU in order to clear the PERxLPEN bit If TZEN = , this register can only be modified in secure mode.
$50000398 constant RCC_RCC_MC_AHB6LPENSETR  \ offset: 0x398 : This register is used by the MCU in order to set the PERxLPEN bit.
$5000039c constant RCC_RCC_MC_AHB6LPENCLRR  \ offset: 0x39C : This register is used by the MCU in order to clear the PERxLPEN bit
$50000400 constant RCC_RCC_BR_RSTSCLRR  \ offset: 0x400 : This register is used by the BOOTROM to check the reset source. Writing has no effect, reading will return the effective values of the corresponding bits. Writing a clears the corresponding bit to . In order to identify the reset source, the MPU application must use RCC MPU Reset Status Clear Register (RCC_MP_RSTSCLRR), and the MCU application must use the RCC MCU Reset Status Clear Register (RCC_MC_RSTSCLRR). Refer to Section10.3.13: Reset source identification for details.This register except MPUP[1:0]RSTF flags is located into VDD domain, and is reset by por_rst reset. The MPUP[1:0]RSTF flags are located into VDDCORE and are reset by nreset. If TZEN = , this register can only be modified in secure mode.
$50000404 constant RCC_RCC_MP_GRSTCSETR  \ offset: 0x404 : This register is used by the MPU in order to generate either a MCU reset or a system reset or a reset of one of the two MPU processors. Writing has no effect, reading returns the effective values of the corresponding bits. Writing a activates the reset.
$50000408 constant RCC_RCC_MP_RSTSCLRR  \ offset: 0x408 : This register is used by the MPU to check the reset source. This register is updated by the BOOTROM code, after a power-on reset (por_rst), a system reset (nreset), or an exit from Standby or CStandby.Writing has no effect, reading will return the effective values of the corresponding bits. Writing a clears the corresponding bit to .Refer to Section10.3.13: Reset source identification for details.The register is located in VDDCORE.If TZEN = , this register can only be modified in secure mode.
$5000040c constant RCC_RCC_MP_IWDGFZSETR  \ offset: 0x40C : This register is used by the BOOTROM in order to freeze the IWDGs clocks. After a system reset or Standby reset (nreset), or a CStandby reset (cstby_rst) the MPU is allowed to write it once.Writing has no effect, reading will return the effective values of the corresponding bits. Writing a sets the corresponding bit to . If TZEN = , this register can only be modified in secure mode.
$50000410 constant RCC_RCC_MP_IWDGFZCLRR  \ offset: 0x410 : This register is used by the BOOTROM in order to unfreeze the IWDGs clocks. Writing has no effect, reading will return the effective values of the corresponding bits. Writing a clears the corresponding bit to . If TZEN = , this register can only be modified in secure mode.
$50000414 constant RCC_RCC_MP_CIER  \ offset: 0x414 : This register shall be used by the MPU to control the interrupt source enable. Refer to Section10.5: RCC interrupts for more details. If TZEN = , this register can only be modified in secure mode.
$50000418 constant RCC_RCC_MP_CIFR  \ offset: 0x418 : This register shall be used by the MPU in order to read and clear the interrupt flags.Writing has no effect, writing will clear the corresponding flag.Refer to Section10.5: RCC interrupts for more details. If TZEN = , this register can only be modified in secure mode.
$5000041c constant RCC_RCC_PWRLPDLYCR  \ offset: 0x41C : This register is used to program the delay between the moment where the system exits from one of the Stop modes, and the moment where it is allowed to enable the PLLs and provide a clock to bridges and processors. If TZEN = , this register can only be modified in secure mode.
$50000420 constant RCC_RCC_MP_RSTSSETR  \ offset: 0x420 : This register is dedicated to the BOOTROM code in order to update the reset source. This register is updated by the BOOTROM code, after a power-on reset (por_rst), a system reset (nreset), or an exit from Standby or CStandby. The application software shall not use this register. In order to identify the reset source, the MPU application must use RCC MPU Reset Status Clear Register (RCC_MP_RSTSCLRR), and the MCU application must use the RCC MCU Reset Status Clear Register (RCC_MC_RSTSCLRR).Writing has no effect, reading will return the effective values of the corresponding bits. Writing a sets the corresponding bit to .Refer to Section10.3.13: Reset source identification for details.The register is located in VDDCORE.If TZEN = , this register can only be modified in secure mode.
$50000800 constant RCC_RCC_MCO1CFGR  \ offset: 0x800 : This register is used to select the clock generated on MCO1 output.
$50000804 constant RCC_RCC_MCO2CFGR  \ offset: 0x804 : This register is used to select the clock generated on MCO2 output.
$50000808 constant RCC_RCC_OCRDYR  \ offset: 0x808 : This is a read-only access register, It contains the status flags of oscillators. Writing has no effect.
$5000080c constant RCC_RCC_DBGCFGR  \ offset: 0x80C : This is register contains the enable control of the debug and trace function, and the clock divider for the trace function.
$50000820 constant RCC_RCC_RCK3SELR  \ offset: 0x820 : This register is used to select the reference clock for PLL3. If TZEN = MCKPROT = , this register can only be modified in secure mode.
$50000824 constant RCC_RCC_RCK4SELR  \ offset: 0x824 : This register is used to select the reference clock for PLL4.
$50000828 constant RCC_RCC_TIMG1PRER  \ offset: 0x828 : This register is used to control the prescaler value of timers located into APB1 domain. It concerns TIM2, TIM3, TIM4, TIM5, TIM6, TIM7, TIM12, TIM13 and TIM14. Refer to Section: Sub-system clock generation for additional information.
$5000082c constant RCC_RCC_TIMG2PRER  \ offset: 0x82C : This register is used to control the prescaler value of timers located into APB2 domain. It concerns TIM1, TIM8, TIM15, TIM16, and TIM17. Refer to Section: Sub-system clock generation for additional information.
$50000830 constant RCC_RCC_MCUDIVR  \ offset: 0x830 : This register is used to control the MCU sub-system clock prescaler. Refer to Section: Sub-system clock generation for additional information. If TZEN = , this register can only be modified in secure mode.
$50000834 constant RCC_RCC_APB1DIVR  \ offset: 0x834 : This register is used to control the APB1 clock prescaler. Refer to section Section1.4.6.3: Sub-System Clock Generation for additional information.
$50000838 constant RCC_RCC_APB2DIVR  \ offset: 0x838 : This register is used to control the APB2 clock prescaler. Refer to Section: Sub-system clock generation for additional information.
$5000083c constant RCC_RCC_APB3DIVR  \ offset: 0x83C : This register is used to control the APB3 clock prescaler. Refer to Section: Sub-system clock generation for additional information.
$50000880 constant RCC_RCC_PLL3CR  \ offset: 0x880 : This register is used to control the PLL3. If TZEN = MCKPROT = , this register can only be modified in secure mode.
$50000884 constant RCC_RCC_PLL3CFGR1  \ offset: 0x884 : This register is used to configure the PLL3. If TZEN = MCKPROT = , this register can only be modified in secure mode.
$50000888 constant RCC_RCC_PLL3CFGR2  \ offset: 0x888 : This register is used to configure the PLL3. If TZEN = MCKPROT = , this register can only be modified in secure mode.
$5000088c constant RCC_RCC_PLL3FRACR  \ offset: 0x88C : This register is used to fine-tune the frequency of the PLL3 VCO. If TZEN = MCKPROT = , this register can only be modified in secure mode.
$50000890 constant RCC_RCC_PLL3CSGR  \ offset: 0x890 : This register is used to configure the PLL3.It is not recommended to change the content of this register when the PLL3 is enabled (PLLON = ). Refer to Section: Using the PLLs in spread spectrum mode for details. If TZEN = MCKPROT = , this register can only be modified in secure mode.
$50000894 constant RCC_RCC_PLL4CR  \ offset: 0x894 : This register is used to control the PLL4.
$50000898 constant RCC_RCC_PLL4CFGR1  \ offset: 0x898 : This register is used to configure the PLL4.
$5000089c constant RCC_RCC_PLL4CFGR2  \ offset: 0x89C : This register is used to configure the PLL4.
$500008a0 constant RCC_RCC_PLL4FRACR  \ offset: 0x8A0 : This register is used to fine-tune the frequency of the PLL4 VCO.
$500008a4 constant RCC_RCC_PLL4CSGR  \ offset: 0x8A4 : This register is used to configure the PLL4.It is not recommended to change the content of this register when the PLL4 is enabled (PLLON = ). Refer to Section: Using the PLLs in spread spectrum mode for details. If TZEN = MCKPROT = , this register can only be modified in secure mode.
$500008c0 constant RCC_RCC_I2C12CKSELR  \ offset: 0x8C0 : This register is used to control the selection of the kernel clock for the I2C1 and I2C2. Note that changing the clock source on-the-fly is allowed, and will not generate any timing violation, however the user has to ensure that both the previous and the new clock sources are present during the switching, and for the whole transition time. Refer to Section: Clock enabling delays.
$500008c4 constant RCC_RCC_I2C35CKSELR  \ offset: 0x8C4 : This register is used to control the selection of the kernel clock for the I2C3 and I2C5. Note that changing the clock source on-the-fly is allowed, and will not generate any timing violation, however the user has to ensure that both the previous and the new clock sources are present during the switching, and for the whole transition time. Refer to Section: Clock enabling delays.
$500008c8 constant RCC_RCC_SAI1CKSELR  \ offset: 0x8C8 : This register is used to control the selection of the kernel clock for the SAI1 and DFSDM audio clock. Note that changing the clock source on-the-fly is allowed, and will not generate any timing violation, however the user has to ensure that both the previous and the new clock sources are present during the switching, and for the whole transition time. Refer to Section: Clock enabling delays.
$500008cc constant RCC_RCC_SAI2CKSELR  \ offset: 0x8CC : This register is used to control the selection of the kernel clock for the SAI2. Note that changing the clock source on-the-fly is allowed, and will not generate any timing violation, however the user has to ensure that both the previous and the new clock sources are present during the switching, and for the whole transition time. Refer to Section: Clock enabling delays.
$500008d0 constant RCC_RCC_SAI3CKSELR  \ offset: 0x8D0 : This register is used to control the selection of the kernel clock for the SAI3. Note that changing the clock source on-the-fly is allowed, and will not generate any timing violation, however the user has to ensure that both the previous and the new clock sources are present during the switching, and for the whole transition time. Refer to Section: Clock enabling delays.
$500008d4 constant RCC_RCC_SAI4CKSELR  \ offset: 0x8D4 : This register is used to control the selection of the kernel clock for the SAI4. Note that changing the clock source on-the-fly is allowed, and will not generate any timing violation, however the user has to ensure that both the previous and the new clock sources are present during the switching, and for the whole transition time. Refer to Section: Clock enabling delays.
$500008d8 constant RCC_RCC_SPI2S1CKSELR  \ offset: 0x8D8 : This register is used to control the selection of the kernel clock for the SPI/I2S1. Note that changing the clock source on-the-fly is allowed, and will not generate any timing violation, however the user has to ensure that both the previous and the new clock sources are present during the switching, and for the whole transition time. Refer to Section: Clock enabling delays.
$500008dc constant RCC_RCC_SPI2S23CKSELR  \ offset: 0x8DC : This register is used to control the selection of the kernel clock for the SPI/I2S2,3. Note that changing the clock source on-the-fly is allowed, and will not generate any timing violation, however the user has to ensure that both the previous and the new clock sources are present during the switching, and for the whole transition time. Refer to Section: Clock enabling delays.
$500008e0 constant RCC_RCC_SPI45CKSELR  \ offset: 0x8E0 : This register is used to control the selection of the kernel clock for the SPI4,5. Note that changing the clock source on-the-fly is allowed, and will not generate any timing violation, however the user has to ensure that both the previous and the new clock sources are present during the switching, and for the whole transition time. Refer to Section: Clock enabling delays.
$500008e4 constant RCC_RCC_UART6CKSELR  \ offset: 0x8E4 : This register is used to control the selection of the kernel clock for the USART6. Note that changing the clock source on-the-fly is allowed, and will not generate any timing violation, however the user has to ensure that both the previous and the new clock sources are present during the switching, and for the whole transition time. Refer to Section: Clock enabling delays.
$500008e8 constant RCC_RCC_UART24CKSELR  \ offset: 0x8E8 : This register is used to control the selection of the kernel clock for the USART2 and UART4. Note that changing the clock source on-the-fly is allowed, and will not generate any timing violation, however the user has to ensure that both the previous and the new clock sources are present during the switching, and for the whole transition time. Refer to Section: Clock enabling delays.
$500008ec constant RCC_RCC_UART35CKSELR  \ offset: 0x8EC : This register is used to control the selection of the kernel clock for the USART3 and UART5. Note that changing the clock source on-the-fly is allowed, and will not generate any timing violation, however the user has to ensure that both the previous and the new clock sources are present during the switching, and for the whole transition time. Refer to Section: Clock enabling delays.
$500008f0 constant RCC_RCC_UART78CKSELR  \ offset: 0x8F0 : This register is used to control the selection of the kernel clock for the UART7 and UART8. Note that changing the clock source on-the-fly is allowed, and will not generate any timing violation, however the user has to ensure that both the previous and the new clock sources are present during the switching, and for the whole transition time. Refer to Section: Clock enabling delays.
$500008f4 constant RCC_RCC_SDMMC12CKSELR  \ offset: 0x8F4 : This register is used to control the selection of the kernel clock for the SDMMC1 and SDMMC2. Note that changing the clock source on-the-fly is allowed, and will not generate any timing violation, however the user has to ensure that both the previous and the new clock sources are present during the switching, and for the whole transition time. Refer to Section: Clock enabling delays.
$500008f8 constant RCC_RCC_SDMMC3CKSELR  \ offset: 0x8F8 : This register is used to control the selection of the kernel clock for the SDMMC3. Note that changing the clock source on-the-fly is allowed, and will not generate any timing violation, however the user has to ensure that both the previous and the new clock sources are present during the switching, and for the whole transition time. Refer to Section: Clock enabling delays.
$500008fc constant RCC_RCC_ETHCKSELR  \ offset: 0x8FC : This register is used to control the selection of the kernel clock for the ETH block. Note that changing the clock source on-the-fly is allowed, and will not generate any timing violation, however the user has to ensure that both the previous and the new clock sources are present during the switching, and for the whole transition time. Refer to Section: Clock enabling delays.
$50000900 constant RCC_RCC_QSPICKSELR  \ offset: 0x900 : This register is used to control the selection of the kernel clock for the QUADSPI. Note that changing the clock source on-the-fly is allowed, and will not generate any timing violation, however the user has to ensure that both the previous and the new clock sources are present during the switching, and for the whole transition time. Refer to Section: Clock enabling delays.
$50000904 constant RCC_RCC_FMCCKSELR  \ offset: 0x904 : This register is used to control the selection of the kernel clock for the FMC block. Note that changing the clock source on-the-fly is allowed, and will not generate any timing violation, however the user has to ensure that both the previous and the new clock sources are present during the switching, and for the whole transition time. Refer to Section: Clock enabling delays.
$5000090c constant RCC_RCC_FDCANCKSELR  \ offset: 0x90C : This register is used to control the selection of the kernel clock for the FDCAN block. Note that changing the clock source on-the-fly is allowed, and will not generate any timing violation, however the user has to ensure that both the previous and the new clock sources are present during the switching, and for the whole transition time. Refer to Section: Clock enabling delays.
$50000914 constant RCC_RCC_SPDIFCKSELR  \ offset: 0x914 : This register is used to control the selection of the kernel clock for the SPDIFRX. Note that changing the clock source on-the-fly is allowed, and will not generate any timing violation, however the user has to ensure that both the previous and the new clock sources are present during the switching, and for the whole transition time. Refer to Section: Clock enabling delays.
$50000918 constant RCC_RCC_CECCKSELR  \ offset: 0x918 : This register is used to control the selection of the kernel clock for the CEC-HDMI.
$5000091c constant RCC_RCC_USBCKSELR  \ offset: 0x91C : This register is used to control the selection of the kernel clock for the USBPHY PLL of the USB HOST and USB OTG
$50000920 constant RCC_RCC_RNG2CKSELR  \ offset: 0x920 : This register is used to control the selection of the kernel clock for the RNG2.
$50000924 constant RCC_RCC_DSICKSELR  \ offset: 0x924 : This register is used to control the selection of the kernel clock for the DSI block.
$50000928 constant RCC_RCC_ADCCKSELR  \ offset: 0x928 : This register is used to control the selection of the kernel clock for the ADC block.
$5000092c constant RCC_RCC_LPTIM45CKSELR  \ offset: 0x92C : This register is used to control the selection of the kernel clock for the LPTIM4 and LPTIM5 blocks.
$50000930 constant RCC_RCC_LPTIM23CKSELR  \ offset: 0x930 : This register is used to control the selection of the kernel clock for the LPTIM2 and LPTIM3 blocks.
$50000934 constant RCC_RCC_LPTIM1CKSELR  \ offset: 0x934 : This register is used to control the selection of the kernel clock for the LPTIM1 block.
$50000980 constant RCC_RCC_APB1RSTSETR  \ offset: 0x980 : This register is used to activate the reset of the corresponding peripheral.
$50000984 constant RCC_RCC_APB1RSTCLRR  \ offset: 0x984 : This register is used to release the reset of the corresponding peripheral.
$50000988 constant RCC_RCC_APB2RSTSETR  \ offset: 0x988 : This register is used to activate the reset of the corresponding peripheral.
$5000098c constant RCC_RCC_APB2RSTCLRR  \ offset: 0x98C : This register is used to release the reset of the corresponding peripheral.
$50000990 constant RCC_RCC_APB3RSTSETR  \ offset: 0x990 : This register is used to activate the reset of the corresponding peripheral.
$50000994 constant RCC_RCC_APB3RSTCLRR  \ offset: 0x994 : This register is used to release the reset of the corresponding peripheral.
$50000998 constant RCC_RCC_AHB2RSTSETR  \ offset: 0x998 : This register is used to activate the reset of the corresponding peripheral.
$5000099c constant RCC_RCC_AHB2RSTCLRR  \ offset: 0x99C : This register is used to release the reset of the corresponding peripheral.
$500009a0 constant RCC_RCC_AHB3RSTSETR  \ offset: 0x9A0 : This register is used to activate the reset of the corresponding peripheral.
$500009a4 constant RCC_RCC_AHB3RSTCLRR  \ offset: 0x9A4 : This register is used to release the reset of the corresponding peripheral.
$500009a8 constant RCC_RCC_AHB4RSTSETR  \ offset: 0x9A8 : This register is used to activate the reset of the corresponding peripheral
$500009ac constant RCC_RCC_AHB4RSTCLRR  \ offset: 0x9AC : This register is used to release the reset of the corresponding peripheral.
$50000a00 constant RCC_RCC_MP_APB1ENSETR  \ offset: 0xA00 : This register is used to set the peripheral clock enable bit
$50000a04 constant RCC_RCC_MP_APB1ENCLRR  \ offset: 0xA04 : This register is used to clear the peripheral clock enable bit
$50000a08 constant RCC_RCC_MP_APB2ENSETR  \ offset: 0xA08 : This register is used to set the peripheral clock enable bit
$50000a0c constant RCC_RCC_MP_APB2ENCLRR  \ offset: 0xA0C : This register is used to clear the peripheral clock enable bit of the corresponding peripheral.
$50000a10 constant RCC_RCC_MP_APB3ENSETR  \ offset: 0xA10 : This register is used to set the peripheral clock enable bit
$50000a14 constant RCC_RCC_MP_APB3ENCLRR  \ offset: 0xA14 : This register is used to clear the peripheral clock enable bit of the corresponding peripheral.
$50000a18 constant RCC_RCC_MP_AHB2ENSETR  \ offset: 0xA18 : This register is used to set the peripheral clock enable bit of the corresponding peripheral
$50000a1c constant RCC_RCC_MP_AHB2ENCLRR  \ offset: 0xA1C : This register is used to clear the peripheral clock enable bit of the corresponding peripheral.
$50000a20 constant RCC_RCC_MP_AHB3ENSETR  \ offset: 0xA20 : This register is used to set the peripheral clock enable bit of the corresponding peripheral
$50000a24 constant RCC_RCC_MP_AHB3ENCLRR  \ offset: 0xA24 : This register is used to clear the peripheral clock enable bit of the corresponding peripheral.
$50000a28 constant RCC_RCC_MP_AHB4ENSETR  \ offset: 0xA28 : This register is used to set the peripheral clock enable bit of the corresponding peripheral to . It shall be used to allocate a peripheral to the MPU.
$50000a2c constant RCC_RCC_MP_AHB4ENCLRR  \ offset: 0xA2C : This register is used to clear the peripheral clock enable bit
$50000a38 constant RCC_RCC_MP_MLAHBENSETR  \ offset: 0xA38 : This register is used to set the peripheral clock enable bit
$50000a3c constant RCC_RCC_MP_MLAHBENCLRR  \ offset: 0xA3C : This register is used to clear the peripheral clock enable bit.
$50000a80 constant RCC_RCC_MC_APB1ENSETR  \ offset: 0xA80 : This register is used to set the peripheral clock enable bit of the corresponding peripheral to . It shall be used to allocate a peripheral to the MCU. Writing has no effect, reading will return . Writing a sets the corresponding bit to .
$50000a84 constant RCC_RCC_MC_APB1ENCLRR  \ offset: 0xA84 : This register is used to clear the peripheral clock enable bit of the corresponding peripheral.
$50000a88 constant RCC_RCC_MC_APB2ENSETR  \ offset: 0xA88 : This register is used to set the peripheral clock enable bit
$50000a8c constant RCC_RCC_MC_APB2ENCLRR  \ offset: 0xA8C : This register is used to clear the peripheral clock enable bit
$50000a90 constant RCC_RCC_MC_APB3ENSETR  \ offset: 0xA90 : This register is used to set the peripheral clock enable bit
$50000a94 constant RCC_RCC_MC_APB3ENCLRR  \ offset: 0xA94 : This register is used to clear the peripheral clock enable bit
$50000a98 constant RCC_RCC_MC_AHB2ENSETR  \ offset: 0xA98 : This register is used to set the peripheral clock enable bit
$50000a9c constant RCC_RCC_MC_AHB2ENCLRR  \ offset: 0xA9C : This register is used to clear the peripheral clock enable bit
$50000aa0 constant RCC_RCC_MC_AHB3ENSETR  \ offset: 0xAA0 : This register is used to set the peripheral clock enable bit
$50000aa4 constant RCC_RCC_MC_AHB3ENCLRR  \ offset: 0xAA4 : This register is used to clear the peripheral clock enable bit
$50000aa8 constant RCC_RCC_MC_AHB4ENSETR  \ offset: 0xAA8 : This register is used to set the peripheral clock enable bit
$50000aac constant RCC_RCC_MC_AHB4ENCLRR  \ offset: 0xAAC : This register is used to clear the peripheral clock enable bit
$50000ab0 constant RCC_RCC_MC_AXIMENSETR  \ offset: 0xAB0 : This register is used to set the peripheral clock enable bit
$50000ab4 constant RCC_RCC_MC_AXIMENCLRR  \ offset: 0xAB4 : This register is used to clear the peripheral clock enable bit
$50000ab8 constant RCC_RCC_MC_MLAHBENSETR  \ offset: 0xAB8 : This register is used to set the peripheral clock enable bit
$50000abc constant RCC_RCC_MC_MLAHBENCLRR  \ offset: 0xABC : This register is used to clear the peripheral clock enable bit
$50000b00 constant RCC_RCC_MP_APB1LPENSETR  \ offset: 0xB00 : This register is used by the MCU in order to clear the PERxLPEN bits
$50000b04 constant RCC_RCC_MP_APB1LPENCLRR  \ offset: 0xB04 : This register is used by the MPU in order to clear the PERxLPEN bits .
$50000b08 constant RCC_RCC_MP_APB2LPENSETR  \ offset: 0xB08 : This register is used by the MCU in order to clear the PERxLPEN bits
$50000b0c constant RCC_RCC_MP_APB2LPENCLRR  \ offset: 0xB0C : This register is used by the MCU in order to clear the PERxLPEN bits
$50000b10 constant RCC_RCC_MP_APB3LPENSETR  \ offset: 0xB10 : This register is used by the MCU in order to clear the PERxLPEN bits
$50000b14 constant RCC_RCC_MP_APB3LPENCLRR  \ offset: 0xB14 : This register is used by the MCU in order to clear the PERxLPEN bits
$50000b18 constant RCC_RCC_MP_AHB2LPENSETR  \ offset: 0xB18 : This register is used by the MPU in order to set the PERxLPEN bit.
$50000b1c constant RCC_RCC_MP_AHB2LPENCLRR  \ offset: 0xB1C : This register is used by the MCU in order to clear the PERxLPEN bits
$50000b20 constant RCC_RCC_MP_AHB3LPENSETR  \ offset: 0xB20 : This register is used by the MPU
$50000b24 constant RCC_RCC_MP_AHB3LPENCLRR  \ offset: 0xB24 : This register is used by the MPU in order to clear the PERxLPEN bit
$50000b28 constant RCC_RCC_MP_AHB4LPENSETR  \ offset: 0xB28 : This register is used by the MPU
$50000b2c constant RCC_RCC_MP_AHB4LPENCLRR  \ offset: 0xB2C : This register is used by the MPU
$50000b30 constant RCC_RCC_MP_AXIMLPENSETR  \ offset: 0xB30 : This register is used by the MPU
$50000b34 constant RCC_RCC_MP_AXIMLPENCLRR  \ offset: 0xB34 : This register is used by the MPU
$50000b38 constant RCC_RCC_MP_MLAHBLPENSETR  \ offset: 0xB38 : This register is used by the MPU in order to set the PERxLPEN bit
$50000b3c constant RCC_RCC_MP_MLAHBLPENCLRR  \ offset: 0xB3C : This register is used by the MPU in order to clear the PERxLPEN bit
$50000b80 constant RCC_RCC_MC_APB1LPENSETR  \ offset: 0xB80 : This register is used by the MCU in order to set the PERxLPEN bit.
$50000b84 constant RCC_RCC_MC_APB1LPENCLRR  \ offset: 0xB84 : This register is used by the MCU in order to clear the PERxLPEN bits
$50000b88 constant RCC_RCC_MC_APB2LPENSETR  \ offset: 0xB88 : This register is used by the MCU in order to set the PERxLPEN bit.
$50000b8c constant RCC_RCC_MC_APB2LPENCLRR  \ offset: 0xB8C : This register is used by the MCU in order to clear the PERxLPEN bit
$50000b90 constant RCC_RCC_MC_APB3LPENSETR  \ offset: 0xB90 : This register is used by the MCU in order to set the PERxLPEN bit.
$50000b94 constant RCC_RCC_MC_APB3LPENCLRR  \ offset: 0xB94 : This register is used by the MCU in order to clear the PERxLPEN bit
$50000b98 constant RCC_RCC_MC_AHB2LPENSETR  \ offset: 0xB98 : This register is used by the MCU in order to set the PERxLPEN bit.
$50000b9c constant RCC_RCC_MC_AHB2LPENCLRR  \ offset: 0xB9C : This register is used by the MCU in order to clear the PERxLPEN bit
$50000ba0 constant RCC_RCC_MC_AHB3LPENSETR  \ offset: 0xBA0 : This register is used by the MCU in order to set the PERxLPEN bit.
$50000ba4 constant RCC_RCC_MC_AHB3LPENCLRR  \ offset: 0xBA4 : This register is used by the MCU in order to clear the PERxLPEN bit
$50000ba8 constant RCC_RCC_MC_AHB4LPENSETR  \ offset: 0xBA8 : This register is used by the MCU in order to set the PERxLPEN bit.
$50000bac constant RCC_RCC_MC_AHB4LPENCLRR  \ offset: 0xBAC : This register is used by the MCU in order to clear the PERxLPEN bit of the corresponding peripheral.
$50000bb0 constant RCC_RCC_MC_AXIMLPENSETR  \ offset: 0xBB0 : This register is used by the MCU in order to set the PERxLPEN bit of the corresponding peripheral.
$50000bb4 constant RCC_RCC_MC_AXIMLPENCLRR  \ offset: 0xBB4 : This register is used by the MCU in order to clear the PERxLPEN bit of the corresponding peripheral.
$50000bb8 constant RCC_RCC_MC_MLAHBLPENSETR  \ offset: 0xBB8 : This register is used by the MCU in order to set the PERxLPEN bit of the corresponding peripheral.
$50000bbc constant RCC_RCC_MC_MLAHBLPENCLRR  \ offset: 0xBBC : This register is used by the MCU in order to clear the PERxLPEN bit of the corresponding peripheral.
$50000c00 constant RCC_RCC_MC_RSTSCLRR  \ offset: 0xC00 : This register is used by the MCU to check the reset source.
$50000c14 constant RCC_RCC_MC_CIER  \ offset: 0xC14 : This register shall be used by the MCU to control the interrupt source enable. Refer to Section10.5: RCC interrupts for more details.
$50000c18 constant RCC_RCC_MC_CIFR  \ offset: 0xC18 : This register shall be used by the MCU in order to read and clear the interrupt flags.
$50000ff4 constant RCC_RCC_VERR   \ offset: 0xFF4 : This register gives the IP version
$50000ff8 constant RCC_RCC_IDR    \ offset: 0xFF8 : This register gives the unique identifier of the RCC
$50000ffc constant RCC_RCC_SIDR   \ offset: 0xFFC : This register gives the decoding space, which is for the RCC of 4 kB.

