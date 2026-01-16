\
\ @file dsi.fs
\ @brief DSI Host
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief DSI Host Version Register
\ Address offset: 0x00
\ Reset value: 0x3133302A
\

$00000000 constant DSI_DSI_VR_VERSION                               \ Version of the DSI Host


\
\ @brief DSI Host Control Register
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$00000001 constant DSI_DSI_CR_EN                                    \ Enable


\
\ @brief DSI HOST Clock Control Register
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$000000ff constant DSI_DSI_CCR_TXECKDIV                             \ TX Escape Clock Division
$0000ff00 constant DSI_DSI_CCR_TOCKDIV                              \ Timeout Clock Division


\
\ @brief DSI Host LTDC VCID Register
\ Address offset: 0x0C
\ Reset value: 0x00000000
\

$00000003 constant DSI_DSI_LVCIDR_VCID                              \ Virtual Channel ID


\
\ @brief DSI Host LTDC Color Coding Register
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$0000000f constant DSI_DSI_LCOLCR_COLC                              \ Color Coding
$00000100 constant DSI_DSI_LCOLCR_LPE                               \ Loosely Packet Enable


\
\ @brief DSI Host LTDC Polarity Configuration Register
\ Address offset: 0x14
\ Reset value: 0x00000000
\

$00000001 constant DSI_DSI_LPCR_DEP                                 \ Data Enable Polarity
$00000002 constant DSI_DSI_LPCR_VSP                                 \ VSYNC Polarity
$00000004 constant DSI_DSI_LPCR_HSP                                 \ HSYNC Polarity


\
\ @brief DSI Host Low-Power mode Configuration Register
\ Address offset: 0x18
\ Reset value: 0x00000000
\

$000000ff constant DSI_DSI_LPMCR_VLPSIZE                            \ VACT Largest Packet Size
$00ff0000 constant DSI_DSI_LPMCR_LPSIZE                             \ Largest Packet Size


\
\ @brief DSI Host Protocol Configuration Register
\ Address offset: 0x2C
\ Reset value: 0x00000000
\

$00000001 constant DSI_DSI_PCR_ETTXE                                \ EoTp Transmission Enable
$00000002 constant DSI_DSI_PCR_ETRXE                                \ EoTp Reception Enable
$00000004 constant DSI_DSI_PCR_BTAE                                 \ Bus Turn Around Enable
$00000008 constant DSI_DSI_PCR_ECCRXE                               \ ECC Reception Enable
$00000010 constant DSI_DSI_PCR_CRCRXE                               \ CRC Reception Enable


\
\ @brief DSI Host Generic VCID Register
\ Address offset: 0x30
\ Reset value: 0x00000000
\

$00000003 constant DSI_DSI_GVCIDR_VCID                              \ Virtual Channel ID


\
\ @brief DSI Host mode Configuration Register
\ Address offset: 0x34
\ Reset value: 0x00000000
\

$00000001 constant DSI_DSI_MCR_CMDM                                 \ Command mode


\
\ @brief DSI Host Video mode Configuration Register
\ Address offset: 0x38
\ Reset value: 0x00000000
\

$00000003 constant DSI_DSI_VMCR_VMT                                 \ Video mode Type
$00000100 constant DSI_DSI_VMCR_LPVSAE                              \ Low-Power Vertical Sync Active Enable
$00000200 constant DSI_DSI_VMCR_LPVBPE                              \ Low-power Vertical Back-Porch Enable
$00000400 constant DSI_DSI_VMCR_LPVFPE                              \ Low-power Vertical Front-porch Enable
$00000800 constant DSI_DSI_VMCR_LPVAE                               \ Low-Power Vertical Active Enable
$00001000 constant DSI_DSI_VMCR_LPHBPE                              \ Low-Power Horizontal Back-Porch Enable
$00002000 constant DSI_DSI_VMCR_LPHFPE                              \ Low-Power Horizontal Front-Porch Enable
$00004000 constant DSI_DSI_VMCR_FBTAAE                              \ Frame Bus-Turn-Around Acknowledge Enable
$00008000 constant DSI_DSI_VMCR_LPCE                                \ Low-Power Command Enable
$00010000 constant DSI_DSI_VMCR_PGE                                 \ Pattern Generator Enable
$00100000 constant DSI_DSI_VMCR_PGM                                 \ Pattern Generator mode
$01000000 constant DSI_DSI_VMCR_PGO                                 \ Pattern Generator Orientation


\
\ @brief DSI Host Video Packet Configuration Register
\ Address offset: 0x3C
\ Reset value: 0x00000000
\

$00003fff constant DSI_DSI_VPCR_VPSIZE                              \ Video Packet Size


\
\ @brief DSI Host Video Chunks Configuration Register
\ Address offset: 0x40
\ Reset value: 0x00000000
\

$00001fff constant DSI_DSI_VCCR_NUMC                                \ Number of Chunks


\
\ @brief DSI Host Video Null Packet Configuration Register
\ Address offset: 0x44
\ Reset value: 0x00000000
\

$00001fff constant DSI_DSI_VNPCR_NPSIZE                             \ Null Packet Size


\
\ @brief DSI Host Video HSA Configuration Register
\ Address offset: 0x48
\ Reset value: 0x00000000
\

$00000fff constant DSI_DSI_VHSACR_HSA                               \ Horizontal Synchronism Active duration


\
\ @brief DSI Host Video HBP Configuration Register
\ Address offset: 0x4C
\ Reset value: 0x00000000
\

$00000fff constant DSI_DSI_VHBPCR_HBP                               \ Horizontal Back-Porch duration


\
\ @brief DSI Host Video Line Configuration Register
\ Address offset: 0x50
\ Reset value: 0x00000000
\

$00007fff constant DSI_DSI_VLCR_HLINE                               \ Horizontal Line duration


\
\ @brief DSI Host Video VSA Configuration Register
\ Address offset: 0x54
\ Reset value: 0x00000000
\

$000003ff constant DSI_DSI_VVSACR_VSA                               \ Vertical Synchronism Active duration


\
\ @brief DSI Host Video VBP Configuration Register
\ Address offset: 0x58
\ Reset value: 0x00000000
\

$000003ff constant DSI_DSI_VVBPCR_VBP                               \ Vertical Back-Porch duration


\
\ @brief DSI Host Video VFP Configuration Register
\ Address offset: 0x5C
\ Reset value: 0x00000000
\

$000003ff constant DSI_DSI_VVFPCR_VFP                               \ Vertical Front-Porch duration


\
\ @brief DSI Host Video VA Configuration Register
\ Address offset: 0x60
\ Reset value: 0x00000000
\

$00003fff constant DSI_DSI_VVACR_VA                                 \ Vertical Active duration


\
\ @brief DSI Host LTDC Command Configuration Register
\ Address offset: 0x64
\ Reset value: 0x00000000
\

$0000ffff constant DSI_DSI_LCCR_CMDSIZE                             \ Command Size


\
\ @brief DSI Host Command mode Configuration Register
\ Address offset: 0x68
\ Reset value: 0x00000000
\

$00000001 constant DSI_DSI_CMCR_TEARE                               \ Tearing Effect Acknowledge Request Enable
$00000002 constant DSI_DSI_CMCR_ARE                                 \ Acknowledge Request Enable
$00000100 constant DSI_DSI_CMCR_GSW0TX                              \ Generic Short Write Zero parameters Transmission
$00000200 constant DSI_DSI_CMCR_GSW1TX                              \ Generic Short Write One parameters Transmission
$00000400 constant DSI_DSI_CMCR_GSW2TX                              \ Generic Short Write Two parameters Transmission
$00000800 constant DSI_DSI_CMCR_GSR0TX                              \ Generic Short Read Zero parameters Transmission
$00001000 constant DSI_DSI_CMCR_GSR1TX                              \ Generic Short Read One parameters Transmission
$00002000 constant DSI_DSI_CMCR_GSR2TX                              \ Generic Short Read Two parameters Transmission
$00004000 constant DSI_DSI_CMCR_GLWTX                               \ Generic Long Write Transmission
$00010000 constant DSI_DSI_CMCR_DSW0TX                              \ DCS Short Write Zero parameter Transmission
$00020000 constant DSI_DSI_CMCR_DSW1TX                              \ DCS Short Read One parameter Transmission
$00040000 constant DSI_DSI_CMCR_DSR0TX                              \ DCS Short Read Zero parameter Transmission
$00080000 constant DSI_DSI_CMCR_DLWTX                               \ DCS Long Write Transmission
$01000000 constant DSI_DSI_CMCR_MRDPS                               \ Maximum Read Packet Size


\
\ @brief DSI Host Generic Header Configuration Register
\ Address offset: 0x6C
\ Reset value: 0x00000000
\

$0000003f constant DSI_DSI_GHCR_DT                                  \ Type
$000000c0 constant DSI_DSI_GHCR_VCID                                \ Channel
$0000ff00 constant DSI_DSI_GHCR_WCLSB                               \ WordCount LSB
$00ff0000 constant DSI_DSI_GHCR_WCMSB                               \ WordCount MSB


\
\ @brief DSI Host Generic Payload Data Register
\ Address offset: 0x70
\ Reset value: 0x00000000
\

$000000ff constant DSI_DSI_GPDR_DATA1                               \ Payload Byte 1
$0000ff00 constant DSI_DSI_GPDR_DATA2                               \ Payload Byte 2
$00ff0000 constant DSI_DSI_GPDR_DATA3                               \ Payload Byte 3
$ff000000 constant DSI_DSI_GPDR_DATA4                               \ Payload Byte 4


\
\ @brief DSI Host Generic Packet Status Register
\ Address offset: 0x74
\ Reset value: 0x00000000
\

$00000001 constant DSI_DSI_GPSR_CMDFE                               \ Command FIFO Empty
$00000002 constant DSI_DSI_GPSR_CMDFF                               \ Command FIFO Full
$00000004 constant DSI_DSI_GPSR_PWRFE                               \ Payload Write FIFO Empty
$00000008 constant DSI_DSI_GPSR_PWRFF                               \ Payload Write FIFO Full
$00000010 constant DSI_DSI_GPSR_PRDFE                               \ Payload Read FIFO Empty
$00000020 constant DSI_DSI_GPSR_PRDFF                               \ Payload Read FIFO Full
$00000040 constant DSI_DSI_GPSR_RCB                                 \ Read Command Busy


\
\ @brief DSI Host Timeout Counter Configuration Register 0
\ Address offset: 0x78
\ Reset value: 0x00000000
\

$0000ffff constant DSI_DSI_TCCR0_LPRX_TOCNT                         \ Low-power Reception Timeout Counter
$ffff0000 constant DSI_DSI_TCCR0_HSTX_TOCNT                         \ High-Speed Transmission Timeout Counter


\
\ @brief DSI Host Timeout Counter Configuration Register 1
\ Address offset: 0x7C
\ Reset value: 0x00000000
\

$0000ffff constant DSI_DSI_TCCR1_HSRD_TOCNT                         \ High-Speed Read Timeout Counter


\
\ @brief DSI Host Timeout Counter Configuration Register 2
\ Address offset: 0x80
\ Reset value: 0x00000000
\

$0000ffff constant DSI_DSI_TCCR2_LPRD_TOCNT                         \ Low-Power Read Timeout Counter


\
\ @brief DSI Host Timeout Counter Configuration Register 3
\ Address offset: 0x84
\ Reset value: 0x00000000
\

$0000ffff constant DSI_DSI_TCCR3_HSWR_TOCNT                         \ High-Speed Write Timeout Counter
$01000000 constant DSI_DSI_TCCR3_PM                                 \ Presp mode


\
\ @brief DSI Host Timeout Counter Configuration Register 4
\ Address offset: 0x88
\ Reset value: 0x00000000
\

$0000ffff constant DSI_DSI_TCCR4_LSWR_TOCNT                         \ Low-Power Write Timeout Counter


\
\ @brief DSI Host Timeout Counter Configuration Register 5
\ Address offset: 0x8C
\ Reset value: 0x00000000
\

$0000ffff constant DSI_DSI_TCCR5_BTA_TOCNT                          \ Bus-Turn-Around Timeout Counter


\
\ @brief DSI Host Clock Lane Configuration Register
\ Address offset: 0x94
\ Reset value: 0x00000000
\

$00000001 constant DSI_DSI_CLCR_DPCC                                \ D-PHY Clock Control
$00000002 constant DSI_DSI_CLCR_ACR                                 \ Automatic Clock lane Control


\
\ @brief DSI Host Clock Lane Timer Configuration Register
\ Address offset: 0x98
\ Reset value: 0x00000000
\

$000003ff constant DSI_DSI_CLTCR_LP2HS_TIME                         \ Low-Power to High-Speed Time
$03ff0000 constant DSI_DSI_CLTCR_HS2LP_TIME                         \ High-Speed to Low-Power Time


\
\ @brief DSI Host Data Lane Timer Configuration Register
\ Address offset: 0x9C
\ Reset value: 0x00000000
\

$00007fff constant DSI_DSI_DLTCR_MRD_TIME                           \ Maximum Read Time
$00ff0000 constant DSI_DSI_DLTCR_LP2HS_TIME                         \ Low-Power To High-Speed Time
$ff000000 constant DSI_DSI_DLTCR_HS2LP_TIME                         \ High-Speed To Low-Power Time


\
\ @brief DSI Host PHY Control Register
\ Address offset: 0xA0
\ Reset value: 0x00000000
\

$00000002 constant DSI_DSI_PCTLR_DEN                                \ Digital Enable
$00000004 constant DSI_DSI_PCTLR_CKE                                \ Clock Enable


\
\ @brief DSI Host PHY Configuration Register
\ Address offset: 0xA4
\ Reset value: 0x00000000
\

$00000003 constant DSI_DSI_PCONFR_NL                                \ Number of Lanes
$0000ff00 constant DSI_DSI_PCONFR_SW_TIME                           \ Stop Wait Time


\
\ @brief DSI Host PHY ULPS Control Register
\ Address offset: 0xA8
\ Reset value: 0x00000000
\

$00000001 constant DSI_DSI_PUCR_URCL                                \ ULPS Request on Clock Lane
$00000002 constant DSI_DSI_PUCR_UECL                                \ ULPS Exit on Clock Lane
$00000004 constant DSI_DSI_PUCR_URDL                                \ ULPS Request on Data Lane
$00000008 constant DSI_DSI_PUCR_UEDL                                \ ULPS Exit on Data Lane


\
\ @brief DSI Host PHY TX Triggers Configuration Register
\ Address offset: 0xAC
\ Reset value: 0x00000000
\

$0000000f constant DSI_DSI_PTTCR_TX_TRIG                            \ Transmission Trigger


\
\ @brief DSI Host PHY Status Register
\ Address offset: 0xB0
\ Reset value: 0x00000000
\

$00000002 constant DSI_DSI_PSR_PD                                   \ PHY Direction
$00000004 constant DSI_DSI_PSR_PSSC                                 \ PHY Stop State Clock lane
$00000008 constant DSI_DSI_PSR_UANC                                 \ ULPS Active Not Clock lane
$00000010 constant DSI_DSI_PSR_PSS0                                 \ PHY Stop State lane 0
$00000020 constant DSI_DSI_PSR_UAN0                                 \ ULPS Active Not lane 1
$00000040 constant DSI_DSI_PSR_RUE0                                 \ RX ULPS Escape lane 0
$00000080 constant DSI_DSI_PSR_PSS1                                 \ PHY Stop State lane 1
$00000100 constant DSI_DSI_PSR_UAN1                                 \ ULPS Active Not lane 1


\
\ @brief DSI Host Interrupt & Status Register 0
\ Address offset: 0xBC
\ Reset value: 0x00000000
\

$00000001 constant DSI_DSI_ISR0_AE0                                 \ Acknowledge Error 0
$00000002 constant DSI_DSI_ISR0_AE1                                 \ Acknowledge Error 1
$00000004 constant DSI_DSI_ISR0_AE2                                 \ Acknowledge Error 2
$00000008 constant DSI_DSI_ISR0_AE3                                 \ Acknowledge Error 3
$00000010 constant DSI_DSI_ISR0_AE4                                 \ Acknowledge Error 4
$00000020 constant DSI_DSI_ISR0_AE5                                 \ Acknowledge Error 5
$00000040 constant DSI_DSI_ISR0_AE6                                 \ Acknowledge Error 6
$00000080 constant DSI_DSI_ISR0_AE7                                 \ Acknowledge Error 7
$00000100 constant DSI_DSI_ISR0_AE8                                 \ Acknowledge Error 8
$00000200 constant DSI_DSI_ISR0_AE9                                 \ Acknowledge Error 9
$00000400 constant DSI_DSI_ISR0_AE10                                \ Acknowledge Error 10
$00000800 constant DSI_DSI_ISR0_AE11                                \ Acknowledge Error 11
$00001000 constant DSI_DSI_ISR0_AE12                                \ Acknowledge Error 12
$00002000 constant DSI_DSI_ISR0_AE13                                \ Acknowledge Error 13
$00004000 constant DSI_DSI_ISR0_AE14                                \ Acknowledge Error 14
$00008000 constant DSI_DSI_ISR0_AE15                                \ Acknowledge Error 15
$00010000 constant DSI_DSI_ISR0_PE0                                 \ PHY Error 0
$00020000 constant DSI_DSI_ISR0_PE1                                 \ PHY Error 1
$00040000 constant DSI_DSI_ISR0_PE2                                 \ PHY Error 2
$00080000 constant DSI_DSI_ISR0_PE3                                 \ PHY Error 3
$00100000 constant DSI_DSI_ISR0_PE4                                 \ PHY Error 4


\
\ @brief DSI Host Interrupt & Status Register 1
\ Address offset: 0xC0
\ Reset value: 0x00000000
\

$00000001 constant DSI_DSI_ISR1_TOHSTX                              \ Timeout High-Speed Transmission
$00000002 constant DSI_DSI_ISR1_TOLPRX                              \ Timeout Low-Power Reception
$00000004 constant DSI_DSI_ISR1_ECCSE                               \ ECC Single-bit Error
$00000008 constant DSI_DSI_ISR1_ECCME                               \ ECC Multi-bit Error
$00000010 constant DSI_DSI_ISR1_CRCE                                \ CRC Error
$00000020 constant DSI_DSI_ISR1_PSE                                 \ Packet Size Error
$00000040 constant DSI_DSI_ISR1_EOTPE                               \ EoTp Error
$00000080 constant DSI_DSI_ISR1_LPWRE                               \ LTDC Payload Write Error
$00000100 constant DSI_DSI_ISR1_GCWRE                               \ Generic Command Write Error
$00000200 constant DSI_DSI_ISR1_GPWRE                               \ Generic Payload Write Error
$00000400 constant DSI_DSI_ISR1_GPTXE                               \ Generic Payload Transmit Error
$00000800 constant DSI_DSI_ISR1_GPRDE                               \ Generic Payload Read Error
$00001000 constant DSI_DSI_ISR1_GPRXE                               \ Generic Payload Receive Error


\
\ @brief DSI Host Interrupt Enable Register 0
\ Address offset: 0xC4
\ Reset value: 0x00000000
\

$00000001 constant DSI_DSI_IER0_AE0IE                               \ Acknowledge Error 0 Interrupt Enable
$00000002 constant DSI_DSI_IER0_AE1IE                               \ Acknowledge Error 1 Interrupt Enable
$00000004 constant DSI_DSI_IER0_AE2IE                               \ Acknowledge Error 2 Interrupt Enable
$00000008 constant DSI_DSI_IER0_AE3IE                               \ Acknowledge Error 3 Interrupt Enable
$00000010 constant DSI_DSI_IER0_AE4IE                               \ Acknowledge Error 4 Interrupt Enable
$00000020 constant DSI_DSI_IER0_AE5IE                               \ Acknowledge Error 5 Interrupt Enable
$00000040 constant DSI_DSI_IER0_AE6IE                               \ Acknowledge Error 6 Interrupt Enable
$00000080 constant DSI_DSI_IER0_AE7IE                               \ Acknowledge Error 7 Interrupt Enable
$00000100 constant DSI_DSI_IER0_AE8IE                               \ Acknowledge Error 8 Interrupt Enable
$00000200 constant DSI_DSI_IER0_AE9IE                               \ Acknowledge Error 9 Interrupt Enable
$00000400 constant DSI_DSI_IER0_AE10IE                              \ Acknowledge Error 10 Interrupt Enable
$00000800 constant DSI_DSI_IER0_AE11IE                              \ Acknowledge Error 11 Interrupt Enable
$00001000 constant DSI_DSI_IER0_AE12IE                              \ Acknowledge Error 12 Interrupt Enable
$00002000 constant DSI_DSI_IER0_AE13IE                              \ Acknowledge Error 13 Interrupt Enable
$00004000 constant DSI_DSI_IER0_AE14IE                              \ Acknowledge Error 14 Interrupt Enable
$00008000 constant DSI_DSI_IER0_AE15IE                              \ Acknowledge Error 15 Interrupt Enable
$00010000 constant DSI_DSI_IER0_PE0IE                               \ PHY Error 0 Interrupt Enable
$00020000 constant DSI_DSI_IER0_PE1IE                               \ PHY Error 1 Interrupt Enable
$00040000 constant DSI_DSI_IER0_PE2IE                               \ PHY Error 2 Interrupt Enable
$00080000 constant DSI_DSI_IER0_PE3IE                               \ PHY Error 3 Interrupt Enable
$00100000 constant DSI_DSI_IER0_PE4IE                               \ PHY Error 4 Interrupt Enable


\
\ @brief DSI Host Interrupt Enable Register 1
\ Address offset: 0xC8
\ Reset value: 0x00000000
\

$00000001 constant DSI_DSI_IER1_TOHSTXIE                            \ Timeout High-Speed Transmission Interrupt Enable
$00000002 constant DSI_DSI_IER1_TOLPRXIE                            \ Timeout Low-Power Reception Interrupt Enable
$00000004 constant DSI_DSI_IER1_ECCSEIE                             \ ECC Single-bit Error Interrupt Enable
$00000008 constant DSI_DSI_IER1_ECCMEIE                             \ ECC Multi-bit Error Interrupt Enable
$00000010 constant DSI_DSI_IER1_CRCEIE                              \ CRC Error Interrupt Enable
$00000020 constant DSI_DSI_IER1_PSEIE                               \ Packet Size Error Interrupt Enable
$00000040 constant DSI_DSI_IER1_EOTPEIE                             \ EoTp Error Interrupt Enable
$00000080 constant DSI_DSI_IER1_LPWREIE                             \ LTDC Payload Write Error Interrupt Enable
$00000100 constant DSI_DSI_IER1_GCWREIE                             \ Generic Command Write Error Interrupt Enable
$00000200 constant DSI_DSI_IER1_GPWREIE                             \ Generic Payload Write Error Interrupt Enable
$00000400 constant DSI_DSI_IER1_GPTXEIE                             \ Generic Payload Transmit Error Interrupt Enable
$00000800 constant DSI_DSI_IER1_GPRDEIE                             \ Generic Payload Read Error Interrupt Enable
$00001000 constant DSI_DSI_IER1_GPRXEIE                             \ Generic Payload Receive Error Interrupt Enable


\
\ @brief DSI Host Force Interrupt Register 0
\ Address offset: 0xD8
\ Reset value: 0x00000000
\

$00000001 constant DSI_DSI_FIR0_FAE0                                \ Force Acknowledge Error 0
$00000002 constant DSI_DSI_FIR0_FAE1                                \ Force Acknowledge Error 1
$00000004 constant DSI_DSI_FIR0_FAE2                                \ Force Acknowledge Error 2
$00000008 constant DSI_DSI_FIR0_FAE3                                \ Force Acknowledge Error 3
$00000010 constant DSI_DSI_FIR0_FAE4                                \ Force Acknowledge Error 4
$00000020 constant DSI_DSI_FIR0_FAE5                                \ Force Acknowledge Error 5
$00000040 constant DSI_DSI_FIR0_FAE6                                \ Force Acknowledge Error 6
$00000080 constant DSI_DSI_FIR0_FAE7                                \ Force Acknowledge Error 7
$00000100 constant DSI_DSI_FIR0_FAE8                                \ Force Acknowledge Error 8
$00000200 constant DSI_DSI_FIR0_FAE9                                \ Force Acknowledge Error 9
$00000400 constant DSI_DSI_FIR0_FAE10                               \ Force Acknowledge Error 10
$00000800 constant DSI_DSI_FIR0_FAE11                               \ Force Acknowledge Error 11
$00001000 constant DSI_DSI_FIR0_FAE12                               \ Force Acknowledge Error 12
$00002000 constant DSI_DSI_FIR0_FAE13                               \ Force Acknowledge Error 13
$00004000 constant DSI_DSI_FIR0_FAE14                               \ Force Acknowledge Error 14
$00008000 constant DSI_DSI_FIR0_FAE15                               \ Force Acknowledge Error 15
$00010000 constant DSI_DSI_FIR0_FPE0                                \ Force PHY Error 0
$00020000 constant DSI_DSI_FIR0_FPE1                                \ Force PHY Error 1
$00040000 constant DSI_DSI_FIR0_FPE2                                \ Force PHY Error 2
$00080000 constant DSI_DSI_FIR0_FPE3                                \ Force PHY Error 3
$00100000 constant DSI_DSI_FIR0_FPE4                                \ Force PHY Error 4


\
\ @brief DSI Host Force Interrupt Register 1
\ Address offset: 0xDC
\ Reset value: 0x00000000
\

$00000001 constant DSI_DSI_FIR1_FTOHSTX                             \ Force Timeout High-Speed Transmission
$00000002 constant DSI_DSI_FIR1_FTOLPRX                             \ Force Timeout Low-Power Reception
$00000004 constant DSI_DSI_FIR1_FECCSE                              \ Force ECC Single-bit Error
$00000008 constant DSI_DSI_FIR1_FECCME                              \ Force ECC Multi-bit Error
$00000010 constant DSI_DSI_FIR1_FCRCE                               \ Force CRC Error
$00000020 constant DSI_DSI_FIR1_FPSE                                \ Force Packet Size Error
$00000040 constant DSI_DSI_FIR1_FEOTPE                              \ Force EoTp Error
$00000080 constant DSI_DSI_FIR1_FLPWRE                              \ Force LTDC Payload Write Error
$00000100 constant DSI_DSI_FIR1_FGCWRE                              \ Force Generic Command Write Error
$00000200 constant DSI_DSI_FIR1_FGPWRE                              \ Force Generic Payload Write Error
$00000400 constant DSI_DSI_FIR1_FGPTXE                              \ Force Generic Payload Transmit Error
$00000800 constant DSI_DSI_FIR1_FGPRDE                              \ Force Generic Payload Read Error
$00001000 constant DSI_DSI_FIR1_FGPRXE                              \ Force Generic Payload Receive Error


\
\ @brief DSI Host Video Shadow Control Register
\ Address offset: 0x100
\ Reset value: 0x00000000
\

$00000001 constant DSI_DSI_VSCR_EN                                  \ Enable
$00000100 constant DSI_DSI_VSCR_UR                                  \ Update Register


\
\ @brief DSI Host LTDC Current VCID Register
\ Address offset: 0x10C
\ Reset value: 0x00000000
\

$00000003 constant DSI_DSI_LCVCIDR_VCID                             \ Virtual Channel ID


\
\ @brief DSI Host LTDC Current Color Coding Register
\ Address offset: 0x110
\ Reset value: 0x00000000
\

$0000000f constant DSI_DSI_LCCCR_COLC                               \ Color Coding
$00000100 constant DSI_DSI_LCCCR_LPE                                \ Loosely Packed Enable


\
\ @brief DSI Host Low-Power mode Current Configuration Register
\ Address offset: 0x118
\ Reset value: 0x00000000
\

$000000ff constant DSI_DSI_LPMCCR_VLPSIZE                           \ VACT Largest Packet Size
$00ff0000 constant DSI_DSI_LPMCCR_LPSIZE                            \ Largest Packet Size


\
\ @brief DSI Host Video mode Current Configuration Register
\ Address offset: 0x138
\ Reset value: 0x00000000
\

$00000003 constant DSI_DSI_VMCCR_VMT                                \ Video mode Type
$00000004 constant DSI_DSI_VMCCR_LPVSAE                             \ Low-Power Vertical Sync time Enable
$00000008 constant DSI_DSI_VMCCR_LPVBPE                             \ Low-power Vertical Back-Porch Enable
$00000010 constant DSI_DSI_VMCCR_LPVFPE                             \ Low-power Vertical Front-Porch Enable
$00000020 constant DSI_DSI_VMCCR_LPVAE                              \ Low-Power Vertical Active Enable
$00000040 constant DSI_DSI_VMCCR_LPHBPE                             \ Low-power Horizontal Back-Porch Enable
$00000080 constant DSI_DSI_VMCCR_LPHFE                              \ Low-Power Horizontal Front-Porch Enable
$00000100 constant DSI_DSI_VMCCR_FBTAAE                             \ Frame BTA Acknowledge Enable
$00000200 constant DSI_DSI_VMCCR_LPCE                               \ Low-Power Command Enable


\
\ @brief DSI Host Video Packet Current Configuration Register
\ Address offset: 0x13C
\ Reset value: 0x00000000
\

$00003fff constant DSI_DSI_VPCCR_VPSIZE                             \ Video Packet Size


\
\ @brief DSI Host Video Chunks Current Configuration Register
\ Address offset: 0x140
\ Reset value: 0x00000000
\

$00001fff constant DSI_DSI_VCCCR_NUMC                               \ Number of Chunks


\
\ @brief DSI Host Video Null Packet Current Configuration Register
\ Address offset: 0x144
\ Reset value: 0x00000000
\

$00001fff constant DSI_DSI_VNPCCR_NPSIZE                            \ Null Packet Size


\
\ @brief DSI Host Video HSA Current Configuration Register
\ Address offset: 0x148
\ Reset value: 0x00000000
\

$00000fff constant DSI_DSI_VHSACCR_HSA                              \ Horizontal Synchronism Active duration


\
\ @brief DSI Host Video HBP Current Configuration Register
\ Address offset: 0x14C
\ Reset value: 0x00000000
\

$00000fff constant DSI_DSI_VHBPCCR_HBP                              \ Horizontal Back-Porch duration


\
\ @brief DSI Host Video Line Current Configuration Register
\ Address offset: 0x150
\ Reset value: 0x00000000
\

$00007fff constant DSI_DSI_VLCCR_HLINE                              \ Horizontal Line duration


\
\ @brief DSI Host Video VSA Current Configuration Register
\ Address offset: 0x154
\ Reset value: 0x00000000
\

$000003ff constant DSI_DSI_VVSACCR_VSA                              \ Vertical Synchronism Active duration


\
\ @brief DSI Host Video VBP Current Configuration Register
\ Address offset: 0x158
\ Reset value: 0x00000000
\

$000003ff constant DSI_DSI_VVBPCCR_VBP                              \ Vertical Back-Porch duration


\
\ @brief DSI Host Video VFP Current Configuration Register
\ Address offset: 0x15C
\ Reset value: 0x00000000
\

$000003ff constant DSI_DSI_VVFPCCR_VFP                              \ Vertical Front-Porch duration


\
\ @brief DSI Host Video VA Current Configuration Register
\ Address offset: 0x160
\ Reset value: 0x00000000
\

$00003fff constant DSI_DSI_VVACCR_VA                                \ Vertical Active duration


\
\ @brief DSI Wrapper Configuration Register
\ Address offset: 0x400
\ Reset value: 0x00000000
\

$00000001 constant DSI_DSI_WCFGR_DSIM                               \ DSI Mode
$0000000e constant DSI_DSI_WCFGR_COLMUX                             \ Color Multiplexing
$00000010 constant DSI_DSI_WCFGR_TESRC                              \ TE Source
$00000020 constant DSI_DSI_WCFGR_TEPOL                              \ TE Polarity
$00000040 constant DSI_DSI_WCFGR_AR                                 \ Automatic Refresh
$00000080 constant DSI_DSI_WCFGR_VSPOL                              \ VSync Polarity


\
\ @brief DSI Wrapper Control Register
\ Address offset: 0x404
\ Reset value: 0x00000000
\

$00000001 constant DSI_DSI_WCR_COLM                                 \ Color Mode
$00000002 constant DSI_DSI_WCR_SHTDN                                \ Shutdown
$00000004 constant DSI_DSI_WCR_LTDCEN                               \ LTDC Enable
$00000008 constant DSI_DSI_WCR_DSIEN                                \ DSI Enable


\
\ @brief DSI Wrapper Interrupt Enable Register
\ Address offset: 0x408
\ Reset value: 0x00000000
\

$00000001 constant DSI_DSI_WIER_TEIE                                \ Tearing Effect Interrupt Enable
$00000002 constant DSI_DSI_WIER_ERIE                                \ End of Refresh Interrupt Enable
$00000200 constant DSI_DSI_WIER_PLLLIE                              \ PLL Lock Interrupt Enable
$00000400 constant DSI_DSI_WIER_PLLUIE                              \ PLL Unlock Interrupt Enable
$00002000 constant DSI_DSI_WIER_RRIE                                \ Regulator Ready Interrupt Enable


\
\ @brief DSI Wrapper Interrupt & Status Register
\ Address offset: 0x40C
\ Reset value: 0x00000000
\

$00000001 constant DSI_DSI_WISR_TEIF                                \ Tearing Effect Interrupt Flag
$00000002 constant DSI_DSI_WISR_ERIF                                \ End of Refresh Interrupt Flag
$00000004 constant DSI_DSI_WISR_BUSY                                \ Busy Flag
$00000100 constant DSI_DSI_WISR_PLLLS                               \ PLL Lock Status
$00000200 constant DSI_DSI_WISR_PLLLIF                              \ PLL Lock Interrupt Flag
$00000400 constant DSI_DSI_WISR_PLLUIF                              \ PLL Unlock Interrupt Flag
$00001000 constant DSI_DSI_WISR_RRS                                 \ Regulator Ready Status
$00002000 constant DSI_DSI_WISR_RRIF                                \ Regulator Ready Interrupt Flag


\
\ @brief DSI Wrapper Interrupt Flag Clear Register
\ Address offset: 0x410
\ Reset value: 0x00000000
\

$00000001 constant DSI_DSI_WIFCR_CTEIF                              \ Clear Tearing Effect Interrupt Flag
$00000002 constant DSI_DSI_WIFCR_CERIF                              \ Clear End of Refresh Interrupt Flag
$00000200 constant DSI_DSI_WIFCR_CPLLLIF                            \ Clear PLL Lock Interrupt Flag
$00000400 constant DSI_DSI_WIFCR_CPLLUIF                            \ Clear PLL Unlock Interrupt Flag
$00002000 constant DSI_DSI_WIFCR_CRRIF                              \ Clear Regulator Ready Interrupt Flag


\
\ @brief DSI Wrapper PHY Configuration Register 1
\ Address offset: 0x418
\ Reset value: 0x00000000
\

$0000003f constant DSI_DSI_WPCR1_UIX4                               \ Unit Interval multiplied by 4
$00000040 constant DSI_DSI_WPCR1_SWCL                               \ Swap Clock Lane pins
$00000080 constant DSI_DSI_WPCR1_SWDL0                              \ Swap Data Lane 0 pins
$00000100 constant DSI_DSI_WPCR1_SWDL1                              \ Swap Data Lane 1 pins
$00000200 constant DSI_DSI_WPCR1_HSICL                              \ Invert Hight-Speed data signal on Clock Lane
$00000400 constant DSI_DSI_WPCR1_HSIDL0                             \ Invert the Hight-Speed data signal on Data Lane 0
$00000800 constant DSI_DSI_WPCR1_HSIDL1                             \ Invert the High-Speed data signal on Data Lane 1
$00001000 constant DSI_DSI_WPCR1_FTXSMCL                            \ Force in TX Stop Mode the Clock Lane
$00002000 constant DSI_DSI_WPCR1_FTXSMDL                            \ Force in TX Stop Mode the Data Lanes
$00004000 constant DSI_DSI_WPCR1_CDOFFDL                            \ Contention Detection OFF on Data Lanes
$00010000 constant DSI_DSI_WPCR1_TDDL                               \ Turn Disable Data Lanes
$00040000 constant DSI_DSI_WPCR1_PDEN                               \ Pull-Down Enable
$00080000 constant DSI_DSI_WPCR1_TCLKPREPEN                         \ custom time for tCLK-PREPARE Enable
$00100000 constant DSI_DSI_WPCR1_TCLKZEROEN                         \ custom time for tCLK-ZERO Enable
$00200000 constant DSI_DSI_WPCR1_THSPREPEN                          \ custom time for tHS-PREPARE Enable
$00400000 constant DSI_DSI_WPCR1_THSTRAILEN                         \ custom time for tHS-TRAIL Enable
$00800000 constant DSI_DSI_WPCR1_THSZEROEN                          \ custom time for tHS-ZERO Enable
$01000000 constant DSI_DSI_WPCR1_TLPXDEN                            \ custom time for tLPX for Data lanes Enable
$02000000 constant DSI_DSI_WPCR1_THSEXITEN                          \ custom time for tHS-EXIT Enable
$04000000 constant DSI_DSI_WPCR1_TLPXCEN                            \ custom time for tLPX for Clock lane Enable
$08000000 constant DSI_DSI_WPCR1_TCLKPOSTEN                         \ custom time for tCLK-POST Enable


\
\ @brief DSI Wrapper PHY Configuration Register 2
\ Address offset: 0x41C
\ Reset value: 0x00000000
\

$00000003 constant DSI_DSI_WPCR2_HSTXDCL                            \ High-Speed Transmission Delay on Clock Lane
$0000000c constant DSI_DSI_WPCR2_HSTXDLL                            \ High-Speed Transmission Delay on Data Lanes
$000000c0 constant DSI_DSI_WPCR2_LPSRCL                             \ Low-Power transmission Slew Rate Compensation on Clock Lane
$00000300 constant DSI_DSI_WPCR2_LPSRDL                             \ Low-Power transmission Slew Rate Compensation on Data Lanes
$00001000 constant DSI_DSI_WPCR2_SDCC                               \ SDD Control
$00030000 constant DSI_DSI_WPCR2_HSTXSRCCL                          \ High-Speed Transmission Slew Rate Control on Clock Lane
$000c0000 constant DSI_DSI_WPCR2_HSTXSRCDL                          \ High-Speed Transmission Slew Rate Control on Data Lanes
$00400000 constant DSI_DSI_WPCR2_FLPRXLPM                           \ Forces LP Receiver in Low-Power Mode
$06000000 constant DSI_DSI_WPCR2_LPRXFT                             \ Low-Power RX low-pass Filtering Tuning


\
\ @brief DSI Wrapper PHY Configuration Register 3
\ Address offset: 0x420
\ Reset value: 0x00000000
\

$000000ff constant DSI_DSI_WPCR3_TCLKPREP                           \ tCLK-PREPARE
$0000ff00 constant DSI_DSI_WPCR3_TCLKZEO                            \ tCLK-ZERO
$00ff0000 constant DSI_DSI_WPCR3_THSPREP                            \ tHS-PREPARE
$ff000000 constant DSI_DSI_WPCR3_THSTRAIL                           \ tHSTRAIL


\
\ @brief DSI_WPCR4
\ Address offset: 0x424
\ Reset value: 0x3133302A
\

$000000ff constant DSI_DSI_WPCR4_THSZERO                            \ tHS-ZERO
$0000ff00 constant DSI_DSI_WPCR4_TLPXD                              \ tLPX for Data lanes
$00ff0000 constant DSI_DSI_WPCR4_THSEXIT                            \ tHSEXIT
$ff000000 constant DSI_DSI_WPCR4_TLPXC                              \ tLPXC for Clock lane


\
\ @brief DSI Wrapper PHY Configuration Register 5
\ Address offset: 0x428
\ Reset value: 0x00000000
\

$000000ff constant DSI_DSI_WPCR5_THSZERO                            \ tCLK-POST


\
\ @brief DSI Wrapper Regulator and PLL Control Register
\ Address offset: 0x430
\ Reset value: 0x00000000
\

$00000001 constant DSI_DSI_WRPCR_PLLEN                              \ PLL Enable
$000001fc constant DSI_DSI_WRPCR_NDIV                               \ PLL Loop Division Factor
$00007800 constant DSI_DSI_WRPCR_IDF                                \ PLL Input Division Factor
$00030000 constant DSI_DSI_WRPCR_ODF                                \ PLL Output Division Factor
$01000000 constant DSI_DSI_WRPCR_REGEN                              \ Regulator Enable


\
\ @brief DSI Host
\
$40016c00 constant DSI_DSI_VR     \ offset: 0x00 : DSI Host Version Register
$40016c04 constant DSI_DSI_CR     \ offset: 0x04 : DSI Host Control Register
$40016c08 constant DSI_DSI_CCR    \ offset: 0x08 : DSI HOST Clock Control Register
$40016c0c constant DSI_DSI_LVCIDR  \ offset: 0x0C : DSI Host LTDC VCID Register
$40016c10 constant DSI_DSI_LCOLCR  \ offset: 0x10 : DSI Host LTDC Color Coding Register
$40016c14 constant DSI_DSI_LPCR   \ offset: 0x14 : DSI Host LTDC Polarity Configuration Register
$40016c18 constant DSI_DSI_LPMCR  \ offset: 0x18 : DSI Host Low-Power mode Configuration Register
$40016c2c constant DSI_DSI_PCR    \ offset: 0x2C : DSI Host Protocol Configuration Register
$40016c30 constant DSI_DSI_GVCIDR  \ offset: 0x30 : DSI Host Generic VCID Register
$40016c34 constant DSI_DSI_MCR    \ offset: 0x34 : DSI Host mode Configuration Register
$40016c38 constant DSI_DSI_VMCR   \ offset: 0x38 : DSI Host Video mode Configuration Register
$40016c3c constant DSI_DSI_VPCR   \ offset: 0x3C : DSI Host Video Packet Configuration Register
$40016c40 constant DSI_DSI_VCCR   \ offset: 0x40 : DSI Host Video Chunks Configuration Register
$40016c44 constant DSI_DSI_VNPCR  \ offset: 0x44 : DSI Host Video Null Packet Configuration Register
$40016c48 constant DSI_DSI_VHSACR  \ offset: 0x48 : DSI Host Video HSA Configuration Register
$40016c4c constant DSI_DSI_VHBPCR  \ offset: 0x4C : DSI Host Video HBP Configuration Register
$40016c50 constant DSI_DSI_VLCR   \ offset: 0x50 : DSI Host Video Line Configuration Register
$40016c54 constant DSI_DSI_VVSACR  \ offset: 0x54 : DSI Host Video VSA Configuration Register
$40016c58 constant DSI_DSI_VVBPCR  \ offset: 0x58 : DSI Host Video VBP Configuration Register
$40016c5c constant DSI_DSI_VVFPCR  \ offset: 0x5C : DSI Host Video VFP Configuration Register
$40016c60 constant DSI_DSI_VVACR  \ offset: 0x60 : DSI Host Video VA Configuration Register
$40016c64 constant DSI_DSI_LCCR   \ offset: 0x64 : DSI Host LTDC Command Configuration Register
$40016c68 constant DSI_DSI_CMCR   \ offset: 0x68 : DSI Host Command mode Configuration Register
$40016c6c constant DSI_DSI_GHCR   \ offset: 0x6C : DSI Host Generic Header Configuration Register
$40016c70 constant DSI_DSI_GPDR   \ offset: 0x70 : DSI Host Generic Payload Data Register
$40016c74 constant DSI_DSI_GPSR   \ offset: 0x74 : DSI Host Generic Packet Status Register
$40016c78 constant DSI_DSI_TCCR0  \ offset: 0x78 : DSI Host Timeout Counter Configuration Register 0
$40016c7c constant DSI_DSI_TCCR1  \ offset: 0x7C : DSI Host Timeout Counter Configuration Register 1
$40016c80 constant DSI_DSI_TCCR2  \ offset: 0x80 : DSI Host Timeout Counter Configuration Register 2
$40016c84 constant DSI_DSI_TCCR3  \ offset: 0x84 : DSI Host Timeout Counter Configuration Register 3
$40016c88 constant DSI_DSI_TCCR4  \ offset: 0x88 : DSI Host Timeout Counter Configuration Register 4
$40016c8c constant DSI_DSI_TCCR5  \ offset: 0x8C : DSI Host Timeout Counter Configuration Register 5
$40016c94 constant DSI_DSI_CLCR   \ offset: 0x94 : DSI Host Clock Lane Configuration Register
$40016c98 constant DSI_DSI_CLTCR  \ offset: 0x98 : DSI Host Clock Lane Timer Configuration Register
$40016c9c constant DSI_DSI_DLTCR  \ offset: 0x9C : DSI Host Data Lane Timer Configuration Register
$40016ca0 constant DSI_DSI_PCTLR  \ offset: 0xA0 : DSI Host PHY Control Register
$40016ca4 constant DSI_DSI_PCONFR  \ offset: 0xA4 : DSI Host PHY Configuration Register
$40016ca8 constant DSI_DSI_PUCR   \ offset: 0xA8 : DSI Host PHY ULPS Control Register
$40016cac constant DSI_DSI_PTTCR  \ offset: 0xAC : DSI Host PHY TX Triggers Configuration Register
$40016cb0 constant DSI_DSI_PSR    \ offset: 0xB0 : DSI Host PHY Status Register
$40016cbc constant DSI_DSI_ISR0   \ offset: 0xBC : DSI Host Interrupt & Status Register 0
$40016cc0 constant DSI_DSI_ISR1   \ offset: 0xC0 : DSI Host Interrupt & Status Register 1
$40016cc4 constant DSI_DSI_IER0   \ offset: 0xC4 : DSI Host Interrupt Enable Register 0
$40016cc8 constant DSI_DSI_IER1   \ offset: 0xC8 : DSI Host Interrupt Enable Register 1
$40016cd8 constant DSI_DSI_FIR0   \ offset: 0xD8 : DSI Host Force Interrupt Register 0
$40016cdc constant DSI_DSI_FIR1   \ offset: 0xDC : DSI Host Force Interrupt Register 1
$40016d00 constant DSI_DSI_VSCR   \ offset: 0x100 : DSI Host Video Shadow Control Register
$40016d0c constant DSI_DSI_LCVCIDR  \ offset: 0x10C : DSI Host LTDC Current VCID Register
$40016d10 constant DSI_DSI_LCCCR  \ offset: 0x110 : DSI Host LTDC Current Color Coding Register
$40016d18 constant DSI_DSI_LPMCCR  \ offset: 0x118 : DSI Host Low-Power mode Current Configuration Register
$40016d38 constant DSI_DSI_VMCCR  \ offset: 0x138 : DSI Host Video mode Current Configuration Register
$40016d3c constant DSI_DSI_VPCCR  \ offset: 0x13C : DSI Host Video Packet Current Configuration Register
$40016d40 constant DSI_DSI_VCCCR  \ offset: 0x140 : DSI Host Video Chunks Current Configuration Register
$40016d44 constant DSI_DSI_VNPCCR  \ offset: 0x144 : DSI Host Video Null Packet Current Configuration Register
$40016d48 constant DSI_DSI_VHSACCR  \ offset: 0x148 : DSI Host Video HSA Current Configuration Register
$40016d4c constant DSI_DSI_VHBPCCR  \ offset: 0x14C : DSI Host Video HBP Current Configuration Register
$40016d50 constant DSI_DSI_VLCCR  \ offset: 0x150 : DSI Host Video Line Current Configuration Register
$40016d54 constant DSI_DSI_VVSACCR  \ offset: 0x154 : DSI Host Video VSA Current Configuration Register
$40016d58 constant DSI_DSI_VVBPCCR  \ offset: 0x158 : DSI Host Video VBP Current Configuration Register
$40016d5c constant DSI_DSI_VVFPCCR  \ offset: 0x15C : DSI Host Video VFP Current Configuration Register
$40016d60 constant DSI_DSI_VVACCR  \ offset: 0x160 : DSI Host Video VA Current Configuration Register
$40017000 constant DSI_DSI_WCFGR  \ offset: 0x400 : DSI Wrapper Configuration Register
$40017004 constant DSI_DSI_WCR    \ offset: 0x404 : DSI Wrapper Control Register
$40017008 constant DSI_DSI_WIER   \ offset: 0x408 : DSI Wrapper Interrupt Enable Register
$4001700c constant DSI_DSI_WISR   \ offset: 0x40C : DSI Wrapper Interrupt & Status Register
$40017010 constant DSI_DSI_WIFCR  \ offset: 0x410 : DSI Wrapper Interrupt Flag Clear Register
$40017018 constant DSI_DSI_WPCR1  \ offset: 0x418 : DSI Wrapper PHY Configuration Register 1
$4001701c constant DSI_DSI_WPCR2  \ offset: 0x41C : DSI Wrapper PHY Configuration Register 2
$40017020 constant DSI_DSI_WPCR3  \ offset: 0x420 : DSI Wrapper PHY Configuration Register 3
$40017024 constant DSI_DSI_WPCR4  \ offset: 0x424 : DSI_WPCR4
$40017028 constant DSI_DSI_WPCR5  \ offset: 0x428 : DSI Wrapper PHY Configuration Register 5
$40017030 constant DSI_DSI_WRPCR  \ offset: 0x430 : DSI Wrapper Regulator and PLL Control Register

