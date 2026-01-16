\
\ @file dsihost1.fs
\ @brief DSIHOST1
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief DSI Host version register
\ Address offset: 0x00
\ Reset value: 0x3133312A
\

$00000000 constant DSIHOST1_DSI_VR_VERSION                          \ VERSION


\
\ @brief DSI Host control register
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$00000001 constant DSIHOST1_DSI_CR_EN                               \ EN


\
\ @brief DSI Host clock control register
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$000000ff constant DSIHOST1_DSI_CCR_TXECKDIV                        \ TXECKDIV
$0000ff00 constant DSIHOST1_DSI_CCR_TOCKDIV                         \ TOCKDIV


\
\ @brief DSI Host LTDC VCID register
\ Address offset: 0x0C
\ Reset value: 0x00000000
\

$00000003 constant DSIHOST1_DSI_LVCIDR_VCID                         \ VCID


\
\ @brief DSI Host LTDC color coding register
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$0000000f constant DSIHOST1_DSI_LCOLCR_COLC                         \ COLC
$00000100 constant DSIHOST1_DSI_LCOLCR_LPE                          \ LPE


\
\ @brief DSI Host LTDC polarity configuration register
\ Address offset: 0x14
\ Reset value: 0x00000000
\

$00000001 constant DSIHOST1_DSI_LPCR_DEP                            \ DEP
$00000002 constant DSIHOST1_DSI_LPCR_VSP                            \ VSP
$00000004 constant DSIHOST1_DSI_LPCR_HSP                            \ HSP


\
\ @brief DSI Host low-power mode configuration register
\ Address offset: 0x18
\ Reset value: 0x00000000
\

$000000ff constant DSIHOST1_DSI_LPMCR_VLPSIZE                       \ VLPSIZE
$00ff0000 constant DSIHOST1_DSI_LPMCR_LPSIZE                        \ LPSIZE


\
\ @brief DSI Host protocol configuration register
\ Address offset: 0x2C
\ Reset value: 0x00000000
\

$00000001 constant DSIHOST1_DSI_PCR_ETTXE                           \ ETTXE
$00000002 constant DSIHOST1_DSI_PCR_ETRXE                           \ ETRXE
$00000004 constant DSIHOST1_DSI_PCR_BTAE                            \ BTAE
$00000008 constant DSIHOST1_DSI_PCR_ECCRXE                          \ ECCRXE
$00000010 constant DSIHOST1_DSI_PCR_CRCRXE                          \ CRCRXE


\
\ @brief DSI Host generic VCID register
\ Address offset: 0x30
\ Reset value: 0x00000000
\

$00000003 constant DSIHOST1_DSI_GVCIDR_VCID                         \ VCID


\
\ @brief DSI Host mode configuration register
\ Address offset: 0x34
\ Reset value: 0x00000001
\

$00000001 constant DSIHOST1_DSI_MCR_CMDM                            \ CMDM


\
\ @brief DSI Host video mode configuration register
\ Address offset: 0x38
\ Reset value: 0x00000000
\

$00000003 constant DSIHOST1_DSI_VMCR_VMT                            \ VMT
$00000100 constant DSIHOST1_DSI_VMCR_LPVSAE                         \ LPVSAE
$00000200 constant DSIHOST1_DSI_VMCR_LPVBPE                         \ LPVBPE
$00000400 constant DSIHOST1_DSI_VMCR_LPVFPE                         \ LPVFPE
$00000800 constant DSIHOST1_DSI_VMCR_LPVAE                          \ LPVAE
$00001000 constant DSIHOST1_DSI_VMCR_LPHBPE                         \ LPHBPE
$00002000 constant DSIHOST1_DSI_VMCR_LPHFPE                         \ LPHFPE
$00004000 constant DSIHOST1_DSI_VMCR_FBTAAE                         \ FBTAAE
$00008000 constant DSIHOST1_DSI_VMCR_LPCE                           \ LPCE
$00010000 constant DSIHOST1_DSI_VMCR_PGE                            \ PGE
$00100000 constant DSIHOST1_DSI_VMCR_PGM                            \ PGM
$01000000 constant DSIHOST1_DSI_VMCR_PGO                            \ PGO


\
\ @brief DSI Host video packet configuration register
\ Address offset: 0x3C
\ Reset value: 0x00000000
\

$00003fff constant DSIHOST1_DSI_VPCR_VPSIZE                         \ VPSIZE


\
\ @brief DSI Host video chunks configuration register
\ Address offset: 0x40
\ Reset value: 0x00000000
\

$00001fff constant DSIHOST1_DSI_VCCR_NUMC                           \ NUMC


\
\ @brief DSI Host video null packet configuration register
\ Address offset: 0x44
\ Reset value: 0x00000000
\

$00001fff constant DSIHOST1_DSI_VNPCR_NPSIZE                        \ NPSIZE


\
\ @brief DSI Host video HSA configuration register
\ Address offset: 0x48
\ Reset value: 0x00000000
\

$00000fff constant DSIHOST1_DSI_VHSACR_HSA                          \ HSA


\
\ @brief DSI Host video HBP configuration register
\ Address offset: 0x4C
\ Reset value: 0x00000000
\

$00000fff constant DSIHOST1_DSI_VHBPCR_HBP                          \ HBP


\
\ @brief DSI Host video line configuration register
\ Address offset: 0x50
\ Reset value: 0x00000000
\

$00007fff constant DSIHOST1_DSI_VLCR_HLINE                          \ HLINE


\
\ @brief DSI Host video VSA configuration register
\ Address offset: 0x54
\ Reset value: 0x00000000
\

$000003ff constant DSIHOST1_DSI_VVSACR_VSA                          \ VSA


\
\ @brief DSI Host video VBP configuration register
\ Address offset: 0x58
\ Reset value: 0x00000000
\

$000003ff constant DSIHOST1_DSI_VVBPCR_VBP                          \ VBP


\
\ @brief DSI Host video VFP configuration register
\ Address offset: 0x5C
\ Reset value: 0x00000000
\

$000003ff constant DSIHOST1_DSI_VVFPCR_VFP                          \ VFP


\
\ @brief DSI Host video VA configuration register
\ Address offset: 0x60
\ Reset value: 0x00000000
\

$00003fff constant DSIHOST1_DSI_VVACR_VA                            \ VA


\
\ @brief DSI Host LTDC command configuration register
\ Address offset: 0x64
\ Reset value: 0x00000000
\

$0000ffff constant DSIHOST1_DSI_LCCR_CMDSIZE                        \ CMDSIZE


\
\ @brief DSI Host command mode configuration register
\ Address offset: 0x68
\ Reset value: 0x00000000
\

$00000001 constant DSIHOST1_DSI_CMCR_TEARE                          \ TEARE
$00000002 constant DSIHOST1_DSI_CMCR_ARE                            \ ARE
$00000100 constant DSIHOST1_DSI_CMCR_GSW0TX                         \ GSW0TX
$00000200 constant DSIHOST1_DSI_CMCR_GSW1TX                         \ GSW1TX
$00000400 constant DSIHOST1_DSI_CMCR_GSW2TX                         \ GSW2TX
$00000800 constant DSIHOST1_DSI_CMCR_GSR0TX                         \ GSR0TX
$00001000 constant DSIHOST1_DSI_CMCR_GSR1TX                         \ GSR1TX
$00002000 constant DSIHOST1_DSI_CMCR_GSR2TX                         \ GSR2TX
$00004000 constant DSIHOST1_DSI_CMCR_GLWTX                          \ GLWTX
$00010000 constant DSIHOST1_DSI_CMCR_DSW0TX                         \ DSW0TX
$00020000 constant DSIHOST1_DSI_CMCR_DSW1TX                         \ DSW1TX
$00040000 constant DSIHOST1_DSI_CMCR_DSR0TX                         \ DSR0TX
$00080000 constant DSIHOST1_DSI_CMCR_DLWTX                          \ DLWTX
$01000000 constant DSIHOST1_DSI_CMCR_MRDPS                          \ MRDPS


\
\ @brief DSI Host generic header configuration register
\ Address offset: 0x6C
\ Reset value: 0x00000000
\

$0000003f constant DSIHOST1_DSI_GHCR_DT                             \ DT
$000000c0 constant DSIHOST1_DSI_GHCR_VCID                           \ VCID
$0000ff00 constant DSIHOST1_DSI_GHCR_WCLSB                          \ WCLSB
$00ff0000 constant DSIHOST1_DSI_GHCR_WCMSB                          \ WCMSB


\
\ @brief DSI Host generic payload data register
\ Address offset: 0x70
\ Reset value: 0x00000000
\

$000000ff constant DSIHOST1_DSI_GPDR_DATA1                          \ DATA1
$0000ff00 constant DSIHOST1_DSI_GPDR_DATA2                          \ DATA2
$00ff0000 constant DSIHOST1_DSI_GPDR_DATA3                          \ DATA3
$ff000000 constant DSIHOST1_DSI_GPDR_DATA4                          \ DATA4


\
\ @brief DSI Host generic packet status register
\ Address offset: 0x74
\ Reset value: 0x00000015
\

$00000001 constant DSIHOST1_DSI_GPSR_CMDFE                          \ CMDFE
$00000002 constant DSIHOST1_DSI_GPSR_CMDFF                          \ CMDFF
$00000004 constant DSIHOST1_DSI_GPSR_PWRFE                          \ PWRFE
$00000008 constant DSIHOST1_DSI_GPSR_PWRFF                          \ PWRFF
$00000010 constant DSIHOST1_DSI_GPSR_PRDFE                          \ PRDFE
$00000020 constant DSIHOST1_DSI_GPSR_PRDFF                          \ PRDFF
$00000040 constant DSIHOST1_DSI_GPSR_RCB                            \ RCB


\
\ @brief DSI Host timeout counter configuration register 0
\ Address offset: 0x78
\ Reset value: 0x00000000
\

$0000ffff constant DSIHOST1_DSI_TCCR0_LPRX_TOCNT                    \ LPRX_TOCNT
$ffff0000 constant DSIHOST1_DSI_TCCR0_HSTX_TOCNT                    \ HSTX_TOCNT


\
\ @brief DSI Host timeout counter configuration register 1
\ Address offset: 0x7C
\ Reset value: 0x00000000
\

$0000ffff constant DSIHOST1_DSI_TCCR1_HSRD_TOCNT                    \ HSRD_TOCNT


\
\ @brief DSI Host timeout counter configuration register 2
\ Address offset: 0x80
\ Reset value: 0x00000000
\

$0000ffff constant DSIHOST1_DSI_TCCR2_LPRD_TOCNT                    \ LPRD_TOCNT


\
\ @brief DSI Host timeout counter configuration register 3
\ Address offset: 0x84
\ Reset value: 0x00000000
\

$0000ffff constant DSIHOST1_DSI_TCCR3_HSWR_TOCNT                    \ HSWR_TOCNT
$01000000 constant DSIHOST1_DSI_TCCR3_PM                            \ PM


\
\ @brief DSI Host timeout counter configuration register 4
\ Address offset: 0x88
\ Reset value: 0x00000000
\

$0000ffff constant DSIHOST1_DSI_TCCR4_LPWR_TOCNT                    \ LPWR_TOCNT


\
\ @brief DSI Host timeout counter configuration register 5
\ Address offset: 0x8C
\ Reset value: 0x00000000
\

$0000ffff constant DSIHOST1_DSI_TCCR5_BTA_TOCNT                     \ BTA_TOCNT


\
\ @brief DSI Host clock lane configuration register
\ Address offset: 0x94
\ Reset value: 0x00000000
\

$00000001 constant DSIHOST1_DSI_CLCR_DPCC                           \ DPCC
$00000002 constant DSIHOST1_DSI_CLCR_ACR                            \ ACR


\
\ @brief DSI Host clock lane timer configuration register
\ Address offset: 0x98
\ Reset value: 0x00000000
\

$000003ff constant DSIHOST1_DSI_CLTCR_LP2HS_TIME                    \ LP2HS_TIME
$03ff0000 constant DSIHOST1_DSI_CLTCR_HS2LP_TIME                    \ HS2LP_TIME


\
\ @brief DSI Host data lane timer configuration register
\ Address offset: 0x9C
\ Reset value: 0x00000000
\

$000003ff constant DSIHOST1_DSI_DLTCR_LP2HS_TIME                    \ LP2HS_TIME
$03ff0000 constant DSIHOST1_DSI_DLTCR_HS2LP_TIME                    \ HS2LP_TIME


\
\ @brief DSI Host PHY control register
\ Address offset: 0xA0
\ Reset value: 0x00000000
\

$00000002 constant DSIHOST1_DSI_PCTLR_DEN                           \ DEN
$00000004 constant DSIHOST1_DSI_PCTLR_CKE                           \ CKE


\
\ @brief DSI Host PHY configuration register
\ Address offset: 0xA4
\ Reset value: 0x00000001
\

$00000003 constant DSIHOST1_DSI_PCONFR_NL                           \ NL
$0000ff00 constant DSIHOST1_DSI_PCONFR_SW_TIME                      \ SW_TIME


\
\ @brief DSI Host PHY ULPS control register
\ Address offset: 0xA8
\ Reset value: 0x00000000
\

$00000001 constant DSIHOST1_DSI_PUCR_URCL                           \ URCL
$00000002 constant DSIHOST1_DSI_PUCR_UECL                           \ UECL
$00000004 constant DSIHOST1_DSI_PUCR_URDL                           \ URDL
$00000008 constant DSIHOST1_DSI_PUCR_UEDL                           \ UEDL


\
\ @brief DSI Host PHY TX triggers configuration register
\ Address offset: 0xAC
\ Reset value: 0x00000000
\

$0000000f constant DSIHOST1_DSI_PTTCR_TX_TRIG                       \ TX_TRIG


\
\ @brief DSI Host PHY status register
\ Address offset: 0xB0
\ Reset value: 0x00001528
\

$00000002 constant DSIHOST1_DSI_PSR_PD                              \ PD
$00000004 constant DSIHOST1_DSI_PSR_PSSC                            \ PSSC
$00000008 constant DSIHOST1_DSI_PSR_UANC                            \ UANC
$00000010 constant DSIHOST1_DSI_PSR_PSS0                            \ PSS0
$00000020 constant DSIHOST1_DSI_PSR_UAN0                            \ UAN0
$00000040 constant DSIHOST1_DSI_PSR_RUE0                            \ RUE0
$00000080 constant DSIHOST1_DSI_PSR_PSS1                            \ PSS1
$00000100 constant DSIHOST1_DSI_PSR_UAN1                            \ UAN1


\
\ @brief DSI Host interrupt and status register 0
\ Address offset: 0xBC
\ Reset value: 0x00000000
\

$00000001 constant DSIHOST1_DSI_ISR0_AE0                            \ AE0
$00000002 constant DSIHOST1_DSI_ISR0_AE1                            \ AE1
$00000004 constant DSIHOST1_DSI_ISR0_AE2                            \ AE2
$00000008 constant DSIHOST1_DSI_ISR0_AE3                            \ AE3
$00000010 constant DSIHOST1_DSI_ISR0_AE4                            \ AE4
$00000020 constant DSIHOST1_DSI_ISR0_AE5                            \ AE5
$00000040 constant DSIHOST1_DSI_ISR0_AE6                            \ AE6
$00000080 constant DSIHOST1_DSI_ISR0_AE7                            \ AE7
$00000100 constant DSIHOST1_DSI_ISR0_AE8                            \ AE8
$00000200 constant DSIHOST1_DSI_ISR0_AE9                            \ AE9
$00000400 constant DSIHOST1_DSI_ISR0_AE10                           \ AE10
$00000800 constant DSIHOST1_DSI_ISR0_AE11                           \ AE11
$00001000 constant DSIHOST1_DSI_ISR0_AE12                           \ AE12
$00002000 constant DSIHOST1_DSI_ISR0_AE13                           \ AE13
$00004000 constant DSIHOST1_DSI_ISR0_AE14                           \ AE14
$00008000 constant DSIHOST1_DSI_ISR0_AE15                           \ AE15
$00010000 constant DSIHOST1_DSI_ISR0_PE0                            \ PE0
$00020000 constant DSIHOST1_DSI_ISR0_PE1                            \ PE1
$00040000 constant DSIHOST1_DSI_ISR0_PE2                            \ PE2
$00080000 constant DSIHOST1_DSI_ISR0_PE3                            \ PE3
$00100000 constant DSIHOST1_DSI_ISR0_PE4                            \ PE4


\
\ @brief DSI Host interrupt and status register 1
\ Address offset: 0xC0
\ Reset value: 0x00000000
\

$00000001 constant DSIHOST1_DSI_ISR1_TOHSTX                         \ TOHSTX
$00000002 constant DSIHOST1_DSI_ISR1_TOLPRX                         \ TOLPRX
$00000004 constant DSIHOST1_DSI_ISR1_ECCSE                          \ ECCSE
$00000008 constant DSIHOST1_DSI_ISR1_ECCME                          \ ECCME
$00000010 constant DSIHOST1_DSI_ISR1_CRCE                           \ CRCE
$00000020 constant DSIHOST1_DSI_ISR1_PSE                            \ PSE
$00000040 constant DSIHOST1_DSI_ISR1_EOTPE                          \ EOTPE
$00000080 constant DSIHOST1_DSI_ISR1_LPWRE                          \ LPWRE
$00000100 constant DSIHOST1_DSI_ISR1_GCWRE                          \ GCWRE
$00000200 constant DSIHOST1_DSI_ISR1_GPWRE                          \ GPWRE
$00000400 constant DSIHOST1_DSI_ISR1_GPTXE                          \ GPTXE
$00000800 constant DSIHOST1_DSI_ISR1_GPRDE                          \ GPRDE
$00001000 constant DSIHOST1_DSI_ISR1_GPRXE                          \ GPRXE


\
\ @brief DSI Host interrupt enable register 0
\ Address offset: 0xC4
\ Reset value: 0x00000000
\

$00000001 constant DSIHOST1_DSI_IER0_AE0IE                          \ AE0IE
$00000002 constant DSIHOST1_DSI_IER0_AE1IE                          \ AE1IE
$00000004 constant DSIHOST1_DSI_IER0_AE2IE                          \ AE2IE
$00000008 constant DSIHOST1_DSI_IER0_AE3IE                          \ AE3IE
$00000010 constant DSIHOST1_DSI_IER0_AE4IE                          \ AE4IE
$00000020 constant DSIHOST1_DSI_IER0_AE5IE                          \ AE5IE
$00000040 constant DSIHOST1_DSI_IER0_AE6IE                          \ AE6IE
$00000080 constant DSIHOST1_DSI_IER0_AE7IE                          \ AE7IE
$00000100 constant DSIHOST1_DSI_IER0_AE8IE                          \ AE8IE
$00000200 constant DSIHOST1_DSI_IER0_AE9IE                          \ AE9IE
$00000400 constant DSIHOST1_DSI_IER0_AE10IE                         \ AE10IE
$00000800 constant DSIHOST1_DSI_IER0_AE11IE                         \ AE11IE
$00001000 constant DSIHOST1_DSI_IER0_AE12IE                         \ AE12IE
$00002000 constant DSIHOST1_DSI_IER0_AE13IE                         \ AE13IE
$00004000 constant DSIHOST1_DSI_IER0_AE14IE                         \ AE14IE
$00008000 constant DSIHOST1_DSI_IER0_AE15IE                         \ AE15IE
$00010000 constant DSIHOST1_DSI_IER0_PE0IE                          \ PE0IE
$00020000 constant DSIHOST1_DSI_IER0_PE1IE                          \ PE1IE
$00040000 constant DSIHOST1_DSI_IER0_PE2IE                          \ PE2IE
$00080000 constant DSIHOST1_DSI_IER0_PE3IE                          \ PE3IE
$00100000 constant DSIHOST1_DSI_IER0_PE4IE                          \ PE4IE


\
\ @brief DSI Host interrupt enable register 1
\ Address offset: 0xC8
\ Reset value: 0x00000000
\

$00000001 constant DSIHOST1_DSI_IER1_TOHSTXIE                       \ TOHSTXIE
$00000002 constant DSIHOST1_DSI_IER1_TOLPRXIE                       \ TOLPRXIE
$00000004 constant DSIHOST1_DSI_IER1_ECCSEIE                        \ ECCSEIE
$00000008 constant DSIHOST1_DSI_IER1_ECCMEIE                        \ ECCMEIE
$00000010 constant DSIHOST1_DSI_IER1_CRCEIE                         \ CRCEIE
$00000020 constant DSIHOST1_DSI_IER1_PSEIE                          \ PSEIE
$00000040 constant DSIHOST1_DSI_IER1_EOTPEIE                        \ EOTPEIE
$00000080 constant DSIHOST1_DSI_IER1_LPWREIE                        \ LPWREIE
$00000100 constant DSIHOST1_DSI_IER1_GCWREIE                        \ GCWREIE
$00000200 constant DSIHOST1_DSI_IER1_GPWREIE                        \ GPWREIE
$00000400 constant DSIHOST1_DSI_IER1_GPTXEIE                        \ GPTXEIE
$00000800 constant DSIHOST1_DSI_IER1_GPRDEIE                        \ GPRDEIE
$00001000 constant DSIHOST1_DSI_IER1_GPRXEIE                        \ GPRXEIE


\
\ @brief DSI Host force interrupt register 0
\ Address offset: 0xD8
\ Reset value: 0x00000000
\

$00000001 constant DSIHOST1_DSI_FIR0_FAE0                           \ FAE0
$00000002 constant DSIHOST1_DSI_FIR0_FAE1                           \ FAE1
$00000004 constant DSIHOST1_DSI_FIR0_FAE2                           \ FAE2
$00000008 constant DSIHOST1_DSI_FIR0_FAE3                           \ FAE3
$00000010 constant DSIHOST1_DSI_FIR0_FAE4                           \ FAE4
$00000020 constant DSIHOST1_DSI_FIR0_FAE5                           \ FAE5
$00000040 constant DSIHOST1_DSI_FIR0_FAE6                           \ FAE6
$00000080 constant DSIHOST1_DSI_FIR0_FAE7                           \ FAE7
$00000100 constant DSIHOST1_DSI_FIR0_FAE8                           \ FAE8
$00000200 constant DSIHOST1_DSI_FIR0_FAE9                           \ FAE9
$00000400 constant DSIHOST1_DSI_FIR0_FAE10                          \ FAE10
$00000800 constant DSIHOST1_DSI_FIR0_FAE11                          \ FAE11
$00001000 constant DSIHOST1_DSI_FIR0_FAE12                          \ FAE12
$00002000 constant DSIHOST1_DSI_FIR0_FAE13                          \ FAE13
$00004000 constant DSIHOST1_DSI_FIR0_FAE14                          \ FAE14
$00008000 constant DSIHOST1_DSI_FIR0_FAE15                          \ FAE15
$00010000 constant DSIHOST1_DSI_FIR0_FPE0                           \ FPE0
$00020000 constant DSIHOST1_DSI_FIR0_FPE1                           \ FPE1
$00040000 constant DSIHOST1_DSI_FIR0_FPE2                           \ FPE2
$00080000 constant DSIHOST1_DSI_FIR0_FPE3                           \ FPE3
$00100000 constant DSIHOST1_DSI_FIR0_FPE4                           \ FPE4


\
\ @brief DSI Host force interrupt register 1
\ Address offset: 0xDC
\ Reset value: 0x00000000
\

$00000001 constant DSIHOST1_DSI_FIR1_FTOHSTX                        \ FTOHSTX
$00000002 constant DSIHOST1_DSI_FIR1_FTOLPRX                        \ FTOLPRX
$00000004 constant DSIHOST1_DSI_FIR1_FECCSE                         \ FECCSE
$00000008 constant DSIHOST1_DSI_FIR1_FECCME                         \ FECCME
$00000010 constant DSIHOST1_DSI_FIR1_FCRCE                          \ FCRCE
$00000020 constant DSIHOST1_DSI_FIR1_FPSE                           \ FPSE
$00000040 constant DSIHOST1_DSI_FIR1_FEOTPE                         \ FEOTPE
$00000080 constant DSIHOST1_DSI_FIR1_FLPWRE                         \ FLPWRE
$00000100 constant DSIHOST1_DSI_FIR1_FGCWRE                         \ FGCWRE
$00000200 constant DSIHOST1_DSI_FIR1_FGPWRE                         \ FGPWRE
$00000400 constant DSIHOST1_DSI_FIR1_FGPTXE                         \ FGPTXE
$00000800 constant DSIHOST1_DSI_FIR1_FGPRDE                         \ FGPRDE
$00001000 constant DSIHOST1_DSI_FIR1_FGPRXE                         \ FGPRXE


\
\ @brief DSI Host data lane timer read configuration register
\ Address offset: 0xF4
\ Reset value: 0x00000000
\

$00007fff constant DSIHOST1_DSI_DLTRCR_MRD_TIME                     \ MRD_TIME


\
\ @brief DSI Host video shadow control register
\ Address offset: 0x100
\ Reset value: 0x00000000
\

$00000001 constant DSIHOST1_DSI_VSCR_EN                             \ EN
$00000100 constant DSIHOST1_DSI_VSCR_UR                             \ UR


\
\ @brief DSI Host LTDC current VCID register
\ Address offset: 0x10C
\ Reset value: 0x00000000
\

$00000003 constant DSIHOST1_DSI_LCVCIDR_VCID                        \ VCID


\
\ @brief DSI Host LTDC current color coding register
\ Address offset: 0x110
\ Reset value: 0x00000000
\

$0000000f constant DSIHOST1_DSI_LCCCR_COLC                          \ COLC
$00000100 constant DSIHOST1_DSI_LCCCR_LPE                           \ LPE


\
\ @brief DSI Host low-power mode current configuration register
\ Address offset: 0x118
\ Reset value: 0x00000000
\

$000000ff constant DSIHOST1_DSI_LPMCCR_VLPSIZE                      \ VLPSIZE
$00ff0000 constant DSIHOST1_DSI_LPMCCR_LPSIZE                       \ LPSIZE


\
\ @brief DSI Host video mode current configuration register
\ Address offset: 0x138
\ Reset value: 0x00000000
\

$00000003 constant DSIHOST1_DSI_VMCCR_VMT                           \ VMT
$00000004 constant DSIHOST1_DSI_VMCCR_LPVSAE                        \ LPVSAE
$00000008 constant DSIHOST1_DSI_VMCCR_LPVBPE                        \ LPVBPE
$00000010 constant DSIHOST1_DSI_VMCCR_LPVFPE                        \ LPVFPE
$00000020 constant DSIHOST1_DSI_VMCCR_LPVAE                         \ LPVAE
$00000040 constant DSIHOST1_DSI_VMCCR_LPHBPE                        \ LPHBPE
$00000080 constant DSIHOST1_DSI_VMCCR_LPHFE                         \ LPHFE
$00000100 constant DSIHOST1_DSI_VMCCR_FBTAAE                        \ FBTAAE
$00000200 constant DSIHOST1_DSI_VMCCR_LPCE                          \ LPCE


\
\ @brief DSI Host video packet current configuration register
\ Address offset: 0x13C
\ Reset value: 0x00000000
\

$00003fff constant DSIHOST1_DSI_VPCCR_VPSIZE                        \ VPSIZE


\
\ @brief DSI Host video chunks current configuration register
\ Address offset: 0x140
\ Reset value: 0x00000000
\

$00001fff constant DSIHOST1_DSI_VCCCR_NUMC                          \ NUMC


\
\ @brief DSI Host video null packet current configuration register
\ Address offset: 0x144
\ Reset value: 0x00000000
\

$00001fff constant DSIHOST1_DSI_VNPCCR_NPSIZE                       \ NPSIZE


\
\ @brief DSI Host video HSA current configuration register
\ Address offset: 0x148
\ Reset value: 0x00000000
\

$00000fff constant DSIHOST1_DSI_VHSACCR_HSA                         \ HSA


\
\ @brief DSI Host video HBP current configuration register
\ Address offset: 0x14C
\ Reset value: 0x00000000
\

$00000fff constant DSIHOST1_DSI_VHBPCCR_HBP                         \ HBP


\
\ @brief DSI Host video line current configuration register
\ Address offset: 0x150
\ Reset value: 0x00000000
\

$00007fff constant DSIHOST1_DSI_VLCCR_HLINE                         \ HLINE


\
\ @brief DSI Host video VSA current configuration register
\ Address offset: 0x154
\ Reset value: 0x00000000
\

$000003ff constant DSIHOST1_DSI_VVSACCR_VSA                         \ VSA


\
\ @brief DSI Host video VBP current configuration register
\ Address offset: 0x158
\ Reset value: 0x00000000
\

$000003ff constant DSIHOST1_DSI_VVBPCCR_VBP                         \ VBP


\
\ @brief DSI Host video VFP current configuration register
\ Address offset: 0x15C
\ Reset value: 0x00000000
\

$000003ff constant DSIHOST1_DSI_VVFPCCR_VFP                         \ VFP


\
\ @brief DSI Host video VA current configuration register
\ Address offset: 0x160
\ Reset value: 0x00000000
\

$00003fff constant DSIHOST1_DSI_VVACCR_VA                           \ VA


\
\ @brief DSI wrapper configuration register
\ Address offset: 0x400
\ Reset value: 0x00000000
\

$00000001 constant DSIHOST1_DSI_WCFGR_DSIM                          \ DSIM
$0000000e constant DSIHOST1_DSI_WCFGR_COLMUX                        \ COLMUX
$00000010 constant DSIHOST1_DSI_WCFGR_TESRC                         \ TESRC
$00000020 constant DSIHOST1_DSI_WCFGR_TEPOL                         \ TEPOL
$00000040 constant DSIHOST1_DSI_WCFGR_AR                            \ AR
$00000080 constant DSIHOST1_DSI_WCFGR_VSPOL                         \ VSPOL


\
\ @brief DSI wrapper control register
\ Address offset: 0x404
\ Reset value: 0x00000000
\

$00000001 constant DSIHOST1_DSI_WCR_COLM                            \ COLM
$00000002 constant DSIHOST1_DSI_WCR_SHTDN                           \ SHTDN
$00000004 constant DSIHOST1_DSI_WCR_LTDCEN                          \ LTDCEN
$00000008 constant DSIHOST1_DSI_WCR_DSIEN                           \ DSIEN


\
\ @brief DSI wrapper interrupt enable register
\ Address offset: 0x408
\ Reset value: 0x00000000
\

$00000001 constant DSIHOST1_DSI_WIER_TEIE                           \ TEIE
$00000002 constant DSIHOST1_DSI_WIER_ERIE                           \ ERIE
$00000200 constant DSIHOST1_DSI_WIER_PLLLIE                         \ PLLLIE
$00000400 constant DSIHOST1_DSI_WIER_PLLUIE                         \ PLLUIE
$00002000 constant DSIHOST1_DSI_WIER_RRIE                           \ RRIE


\
\ @brief DSI wrapper interrupt and status register
\ Address offset: 0x40C
\ Reset value: 0x00000000
\

$00000001 constant DSIHOST1_DSI_WISR_TEIF                           \ TEIF
$00000002 constant DSIHOST1_DSI_WISR_ERIF                           \ ERIF
$00000004 constant DSIHOST1_DSI_WISR_BUSY                           \ BUSY
$00000100 constant DSIHOST1_DSI_WISR_PLLLS                          \ PLLLS
$00000200 constant DSIHOST1_DSI_WISR_PLLLIF                         \ PLLLIF
$00000400 constant DSIHOST1_DSI_WISR_PLLUIF                         \ PLLUIF
$00001000 constant DSIHOST1_DSI_WISR_RRS                            \ RRS
$00002000 constant DSIHOST1_DSI_WISR_RRIF                           \ RRIF


\
\ @brief DSI wrapper interrupt flag clear register
\ Address offset: 0x410
\ Reset value: 0x00000000
\

$00000001 constant DSIHOST1_DSI_WIFCR_CTEIF                         \ CTEIF
$00000002 constant DSIHOST1_DSI_WIFCR_CERIF                         \ CERIF
$00000200 constant DSIHOST1_DSI_WIFCR_CPLLLIF                       \ CPLLLIF
$00000400 constant DSIHOST1_DSI_WIFCR_CPLLUIF                       \ CPLLUIF
$00002000 constant DSIHOST1_DSI_WIFCR_CRRIF                         \ CRRIF


\
\ @brief DSI wrapper PHY configuration register 0
\ Address offset: 0x418
\ Reset value: 0x00000000
\

$0000003f constant DSIHOST1_DSI_WPCR0_UIX4                          \ UIX4
$00000040 constant DSIHOST1_DSI_WPCR0_SWCL                          \ SWCL
$00000080 constant DSIHOST1_DSI_WPCR0_SWDL0                         \ SWDL0
$00000100 constant DSIHOST1_DSI_WPCR0_SWDL1                         \ SWDL1
$00000200 constant DSIHOST1_DSI_WPCR0_HSICL                         \ HSICL
$00000400 constant DSIHOST1_DSI_WPCR0_HSIDL0                        \ HSIDL0
$00000800 constant DSIHOST1_DSI_WPCR0_HSIDL1                        \ HSIDL1
$00001000 constant DSIHOST1_DSI_WPCR0_FTXSMCL                       \ FTXSMCL
$00002000 constant DSIHOST1_DSI_WPCR0_FTXSMDL                       \ FTXSMDL
$00004000 constant DSIHOST1_DSI_WPCR0_CDOFFDL                       \ CDOFFDL
$00010000 constant DSIHOST1_DSI_WPCR0_TDDL                          \ TDDL


\
\ @brief This register shall be programmed only when DSI is stopped (CR. DSIEN=0 and CR.EN = 0).
\ Address offset: 0x41C
\ Reset value: 0x00000000
\

$00000003 constant DSIHOST1_DSI_WPCR1_SKEWCL                        \ SKEWCL
$0000000c constant DSIHOST1_DSI_WPCR1_SKEWDL                        \ SKEWDL
$000000c0 constant DSIHOST1_DSI_WPCR1_LPTXSRCL                      \ LPTXSRCL
$00000300 constant DSIHOST1_DSI_WPCR1_LPTXSRDL                      \ LPTXSRDL
$00001000 constant DSIHOST1_DSI_WPCR1_SDDCCL                        \ SDDCCL
$00002000 constant DSIHOST1_DSI_WPCR1_SDDCDL                        \ SDDCDL
$00010000 constant DSIHOST1_DSI_WPCR1_HSTXSRUCL                     \ HSTXSRUCL
$00020000 constant DSIHOST1_DSI_WPCR1_HSTXSRDCL                     \ HSTXSRDCL
$00040000 constant DSIHOST1_DSI_WPCR1_HSTXSRUDL                     \ HSTXSRUDL
$00080000 constant DSIHOST1_DSI_WPCR1_HSTXSRDDL                     \ HSTXSRDDL


\
\ @brief DSI wrapper regulator and PLL control register
\ Address offset: 0x430
\ Reset value: 0x00000000
\

$00000001 constant DSIHOST1_DSI_WRPCR_PLLEN                         \ PLLEN
$000001fc constant DSIHOST1_DSI_WRPCR_NDIV                          \ NDIV
$00007800 constant DSIHOST1_DSI_WRPCR_IDF                           \ IDF
$00030000 constant DSIHOST1_DSI_WRPCR_ODF                           \ ODF
$01000000 constant DSIHOST1_DSI_WRPCR_REGEN                         \ REGEN
$10000000 constant DSIHOST1_DSI_WRPCR_BGREN                         \ BGREN


\
\ @brief DSI Host hardware configuration register
\ Address offset: 0x7F0
\ Reset value: 0x00005A01
\

$0000000f constant DSIHOST1_DSI_HWCFGR_TECHNO                       \ TECHNO
$0000fff0 constant DSIHOST1_DSI_HWCFGR_FIFOSIZE                     \ FIFOSIZE


\
\ @brief DSI Host version register
\ Address offset: 0x7F4
\ Reset value: 0x00000020
\

$0000000f constant DSIHOST1_DSI_VERR_MINREV                         \ MINREV
$000000f0 constant DSIHOST1_DSI_VERR_MAJREV                         \ MAJREV


\
\ @brief DSI Host identification register
\ Address offset: 0x7F8
\ Reset value: 0x00160071
\

$00000000 constant DSIHOST1_DSI_IPIDR_ID                            \ ID


\
\ @brief DSI Host size identification register
\ Address offset: 0x7FC
\ Reset value: 0xA3C5DD02
\

$00000000 constant DSIHOST1_DSI_SIDR_SID                            \ SID


\
\ @brief DSIHOST1
\
$5a000000 constant DSIHOST1_DSI_VR  \ offset: 0x00 : DSI Host version register
$5a000004 constant DSIHOST1_DSI_CR  \ offset: 0x04 : DSI Host control register
$5a000008 constant DSIHOST1_DSI_CCR  \ offset: 0x08 : DSI Host clock control register
$5a00000c constant DSIHOST1_DSI_LVCIDR  \ offset: 0x0C : DSI Host LTDC VCID register
$5a000010 constant DSIHOST1_DSI_LCOLCR  \ offset: 0x10 : DSI Host LTDC color coding register
$5a000014 constant DSIHOST1_DSI_LPCR  \ offset: 0x14 : DSI Host LTDC polarity configuration register
$5a000018 constant DSIHOST1_DSI_LPMCR  \ offset: 0x18 : DSI Host low-power mode configuration register
$5a00002c constant DSIHOST1_DSI_PCR  \ offset: 0x2C : DSI Host protocol configuration register
$5a000030 constant DSIHOST1_DSI_GVCIDR  \ offset: 0x30 : DSI Host generic VCID register
$5a000034 constant DSIHOST1_DSI_MCR  \ offset: 0x34 : DSI Host mode configuration register
$5a000038 constant DSIHOST1_DSI_VMCR  \ offset: 0x38 : DSI Host video mode configuration register
$5a00003c constant DSIHOST1_DSI_VPCR  \ offset: 0x3C : DSI Host video packet configuration register
$5a000040 constant DSIHOST1_DSI_VCCR  \ offset: 0x40 : DSI Host video chunks configuration register
$5a000044 constant DSIHOST1_DSI_VNPCR  \ offset: 0x44 : DSI Host video null packet configuration register
$5a000048 constant DSIHOST1_DSI_VHSACR  \ offset: 0x48 : DSI Host video HSA configuration register
$5a00004c constant DSIHOST1_DSI_VHBPCR  \ offset: 0x4C : DSI Host video HBP configuration register
$5a000050 constant DSIHOST1_DSI_VLCR  \ offset: 0x50 : DSI Host video line configuration register
$5a000054 constant DSIHOST1_DSI_VVSACR  \ offset: 0x54 : DSI Host video VSA configuration register
$5a000058 constant DSIHOST1_DSI_VVBPCR  \ offset: 0x58 : DSI Host video VBP configuration register
$5a00005c constant DSIHOST1_DSI_VVFPCR  \ offset: 0x5C : DSI Host video VFP configuration register
$5a000060 constant DSIHOST1_DSI_VVACR  \ offset: 0x60 : DSI Host video VA configuration register
$5a000064 constant DSIHOST1_DSI_LCCR  \ offset: 0x64 : DSI Host LTDC command configuration register
$5a000068 constant DSIHOST1_DSI_CMCR  \ offset: 0x68 : DSI Host command mode configuration register
$5a00006c constant DSIHOST1_DSI_GHCR  \ offset: 0x6C : DSI Host generic header configuration register
$5a000070 constant DSIHOST1_DSI_GPDR  \ offset: 0x70 : DSI Host generic payload data register
$5a000074 constant DSIHOST1_DSI_GPSR  \ offset: 0x74 : DSI Host generic packet status register
$5a000078 constant DSIHOST1_DSI_TCCR0  \ offset: 0x78 : DSI Host timeout counter configuration register 0
$5a00007c constant DSIHOST1_DSI_TCCR1  \ offset: 0x7C : DSI Host timeout counter configuration register 1
$5a000080 constant DSIHOST1_DSI_TCCR2  \ offset: 0x80 : DSI Host timeout counter configuration register 2
$5a000084 constant DSIHOST1_DSI_TCCR3  \ offset: 0x84 : DSI Host timeout counter configuration register 3
$5a000088 constant DSIHOST1_DSI_TCCR4  \ offset: 0x88 : DSI Host timeout counter configuration register 4
$5a00008c constant DSIHOST1_DSI_TCCR5  \ offset: 0x8C : DSI Host timeout counter configuration register 5
$5a000094 constant DSIHOST1_DSI_CLCR  \ offset: 0x94 : DSI Host clock lane configuration register
$5a000098 constant DSIHOST1_DSI_CLTCR  \ offset: 0x98 : DSI Host clock lane timer configuration register
$5a00009c constant DSIHOST1_DSI_DLTCR  \ offset: 0x9C : DSI Host data lane timer configuration register
$5a0000a0 constant DSIHOST1_DSI_PCTLR  \ offset: 0xA0 : DSI Host PHY control register
$5a0000a4 constant DSIHOST1_DSI_PCONFR  \ offset: 0xA4 : DSI Host PHY configuration register
$5a0000a8 constant DSIHOST1_DSI_PUCR  \ offset: 0xA8 : DSI Host PHY ULPS control register
$5a0000ac constant DSIHOST1_DSI_PTTCR  \ offset: 0xAC : DSI Host PHY TX triggers configuration register
$5a0000b0 constant DSIHOST1_DSI_PSR  \ offset: 0xB0 : DSI Host PHY status register
$5a0000bc constant DSIHOST1_DSI_ISR0  \ offset: 0xBC : DSI Host interrupt and status register 0
$5a0000c0 constant DSIHOST1_DSI_ISR1  \ offset: 0xC0 : DSI Host interrupt and status register 1
$5a0000c4 constant DSIHOST1_DSI_IER0  \ offset: 0xC4 : DSI Host interrupt enable register 0
$5a0000c8 constant DSIHOST1_DSI_IER1  \ offset: 0xC8 : DSI Host interrupt enable register 1
$5a0000d8 constant DSIHOST1_DSI_FIR0  \ offset: 0xD8 : DSI Host force interrupt register 0
$5a0000dc constant DSIHOST1_DSI_FIR1  \ offset: 0xDC : DSI Host force interrupt register 1
$5a0000f4 constant DSIHOST1_DSI_DLTRCR  \ offset: 0xF4 : DSI Host data lane timer read configuration register
$5a000100 constant DSIHOST1_DSI_VSCR  \ offset: 0x100 : DSI Host video shadow control register
$5a00010c constant DSIHOST1_DSI_LCVCIDR  \ offset: 0x10C : DSI Host LTDC current VCID register
$5a000110 constant DSIHOST1_DSI_LCCCR  \ offset: 0x110 : DSI Host LTDC current color coding register
$5a000118 constant DSIHOST1_DSI_LPMCCR  \ offset: 0x118 : DSI Host low-power mode current configuration register
$5a000138 constant DSIHOST1_DSI_VMCCR  \ offset: 0x138 : DSI Host video mode current configuration register
$5a00013c constant DSIHOST1_DSI_VPCCR  \ offset: 0x13C : DSI Host video packet current configuration register
$5a000140 constant DSIHOST1_DSI_VCCCR  \ offset: 0x140 : DSI Host video chunks current configuration register
$5a000144 constant DSIHOST1_DSI_VNPCCR  \ offset: 0x144 : DSI Host video null packet current configuration register
$5a000148 constant DSIHOST1_DSI_VHSACCR  \ offset: 0x148 : DSI Host video HSA current configuration register
$5a00014c constant DSIHOST1_DSI_VHBPCCR  \ offset: 0x14C : DSI Host video HBP current configuration register
$5a000150 constant DSIHOST1_DSI_VLCCR  \ offset: 0x150 : DSI Host video line current configuration register
$5a000154 constant DSIHOST1_DSI_VVSACCR  \ offset: 0x154 : DSI Host video VSA current configuration register
$5a000158 constant DSIHOST1_DSI_VVBPCCR  \ offset: 0x158 : DSI Host video VBP current configuration register
$5a00015c constant DSIHOST1_DSI_VVFPCCR  \ offset: 0x15C : DSI Host video VFP current configuration register
$5a000160 constant DSIHOST1_DSI_VVACCR  \ offset: 0x160 : DSI Host video VA current configuration register
$5a000400 constant DSIHOST1_DSI_WCFGR  \ offset: 0x400 : DSI wrapper configuration register
$5a000404 constant DSIHOST1_DSI_WCR  \ offset: 0x404 : DSI wrapper control register
$5a000408 constant DSIHOST1_DSI_WIER  \ offset: 0x408 : DSI wrapper interrupt enable register
$5a00040c constant DSIHOST1_DSI_WISR  \ offset: 0x40C : DSI wrapper interrupt and status register
$5a000410 constant DSIHOST1_DSI_WIFCR  \ offset: 0x410 : DSI wrapper interrupt flag clear register
$5a000418 constant DSIHOST1_DSI_WPCR0  \ offset: 0x418 : DSI wrapper PHY configuration register 0
$5a00041c constant DSIHOST1_DSI_WPCR1  \ offset: 0x41C : This register shall be programmed only when DSI is stopped (CR. DSIEN=0 and CR.EN = 0).
$5a000430 constant DSIHOST1_DSI_WRPCR  \ offset: 0x430 : DSI wrapper regulator and PLL control register
$5a0007f0 constant DSIHOST1_DSI_HWCFGR  \ offset: 0x7F0 : DSI Host hardware configuration register
$5a0007f4 constant DSIHOST1_DSI_VERR  \ offset: 0x7F4 : DSI Host version register
$5a0007f8 constant DSIHOST1_DSI_IPIDR  \ offset: 0x7F8 : DSI Host identification register
$5a0007fc constant DSIHOST1_DSI_SIDR  \ offset: 0x7FC : DSI Host size identification register

