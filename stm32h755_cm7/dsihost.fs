\
\ @file dsihost.fs
\ @brief DSIHOST
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] DSIHOST_DEF

  [ifdef] DSIHOST_DSI_VR_DEF
    \
    \ @brief DSI Host version register
    \ Address offset: 0x00
    \ Reset value: 0x3133302A
    \
    $00 constant DSIHOST_VERSION                \ [0x00 : 32] VERSION
  [then]


  [ifdef] DSIHOST_DSI_CR_DEF
    \
    \ @brief DSI Host control register
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $00 constant DSIHOST_EN                     \ [0x00] EN
  [then]


  [ifdef] DSIHOST_DSI_CCR_DEF
    \
    \ @brief DSI Host clock control register
    \ Address offset: 0x08
    \ Reset value: 0x00000000
    \
    $00 constant DSIHOST_TXECKDIV               \ [0x00 : 8] TXECKDIV
    $08 constant DSIHOST_TOCKDIV                \ [0x08 : 8] TOCKDIV
  [then]


  [ifdef] DSIHOST_DSI_LVCIDR_DEF
    \
    \ @brief DSI Host LTDC VCID register
    \ Address offset: 0x0C
    \ Reset value: 0x00000000
    \
    $00 constant DSIHOST_VCID                   \ [0x00 : 2] VCID
  [then]


  [ifdef] DSIHOST_DSI_LCOLCR_DEF
    \
    \ @brief DSI Host LTDC color coding register
    \ Address offset: 0x10
    \ Reset value: 0x00000000
    \
    $00 constant DSIHOST_COLC                   \ [0x00 : 4] COLC
    $08 constant DSIHOST_LPE                    \ [0x08] LPE
  [then]


  [ifdef] DSIHOST_DSI_LPCR_DEF
    \
    \ @brief DSI Host LTDC polarity configuration register
    \ Address offset: 0x14
    \ Reset value: 0x00000000
    \
    $00 constant DSIHOST_DEP                    \ [0x00] DEP
    $01 constant DSIHOST_VSP                    \ [0x01] VSP
    $02 constant DSIHOST_HSP                    \ [0x02] HSP
  [then]


  [ifdef] DSIHOST_DSI_LPMCR_DEF
    \
    \ @brief DSI Host low-power mode configuration register
    \ Address offset: 0x18
    \ Reset value: 0x00000000
    \
    $00 constant DSIHOST_VLPSIZE                \ [0x00 : 8] VLPSIZE
    $10 constant DSIHOST_LPSIZE                 \ [0x10 : 8] LPSIZE
  [then]


  [ifdef] DSIHOST_DSI_PCR_DEF
    \
    \ @brief DSI Host protocol configuration register
    \ Address offset: 0x2C
    \ Reset value: 0x00000000
    \
    $00 constant DSIHOST_ETTXE                  \ [0x00] ETTXE
    $01 constant DSIHOST_ETRXE                  \ [0x01] ETRXE
    $02 constant DSIHOST_BTAE                   \ [0x02] BTAE
    $03 constant DSIHOST_ECCRXE                 \ [0x03] ECCRXE
    $04 constant DSIHOST_CRCRXE                 \ [0x04] CRCRXE
  [then]


  [ifdef] DSIHOST_DSI_GVCIDR_DEF
    \
    \ @brief DSI Host generic VCID register
    \ Address offset: 0x30
    \ Reset value: 0x00000000
    \
    $00 constant DSIHOST_VCID                   \ [0x00 : 2] VCID
  [then]


  [ifdef] DSIHOST_DSI_MCR_DEF
    \
    \ @brief DSI Host mode configuration register
    \ Address offset: 0x34
    \ Reset value: 0x00000001
    \
    $00 constant DSIHOST_CMDM                   \ [0x00] CMDM
  [then]


  [ifdef] DSIHOST_DSI_VMCR_DEF
    \
    \ @brief DSI Host video mode configuration register
    \ Address offset: 0x38
    \ Reset value: 0x00000000
    \
    $00 constant DSIHOST_VMT                    \ [0x00 : 2] VMT
    $08 constant DSIHOST_LPVSAE                 \ [0x08] LPVSAE
    $09 constant DSIHOST_LPVBPE                 \ [0x09] LPVBPE
    $0a constant DSIHOST_LPVFPE                 \ [0x0a] LPVFPE
    $0b constant DSIHOST_LPVAE                  \ [0x0b] LPVAE
    $0c constant DSIHOST_LPHBPE                 \ [0x0c] LPHBPE
    $0d constant DSIHOST_LPHFPE                 \ [0x0d] LPHFPE
    $0e constant DSIHOST_FBTAAE                 \ [0x0e] FBTAAE
    $0f constant DSIHOST_LPCE                   \ [0x0f] LPCE
    $10 constant DSIHOST_PGE                    \ [0x10] PGE
    $14 constant DSIHOST_PGM                    \ [0x14] PGM
    $18 constant DSIHOST_PGO                    \ [0x18] PGO
  [then]


  [ifdef] DSIHOST_DSI_VPCR_DEF
    \
    \ @brief DSI Host video packet configuration register
    \ Address offset: 0x3C
    \ Reset value: 0x00000000
    \
    $00 constant DSIHOST_VPSIZE                 \ [0x00 : 14] VPSIZE
  [then]


  [ifdef] DSIHOST_DSI_VCCR_DEF
    \
    \ @brief DSI Host video chunks configuration register
    \ Address offset: 0x40
    \ Reset value: 0x00000000
    \
    $00 constant DSIHOST_NUMC                   \ [0x00 : 13] NUMC
  [then]


  [ifdef] DSIHOST_DSI_VNPCR_DEF
    \
    \ @brief DSI Host video null packet configuration register
    \ Address offset: 0x44
    \ Reset value: 0x00000000
    \
    $00 constant DSIHOST_NPSIZE                 \ [0x00 : 13] NPSIZE
  [then]


  [ifdef] DSIHOST_DSI_VHSACR_DEF
    \
    \ @brief DSI Host video HSA configuration register
    \ Address offset: 0x48
    \ Reset value: 0x00000000
    \
    $00 constant DSIHOST_HSA                    \ [0x00 : 12] HSA
  [then]


  [ifdef] DSIHOST_DSI_VHBPCR_DEF
    \
    \ @brief DSI Host video HBP configuration register
    \ Address offset: 0x4C
    \ Reset value: 0x00000000
    \
    $00 constant DSIHOST_HBP                    \ [0x00 : 12] HBP
  [then]


  [ifdef] DSIHOST_DSI_VLCR_DEF
    \
    \ @brief DSI Host video line configuration register
    \ Address offset: 0x50
    \ Reset value: 0x00000000
    \
    $00 constant DSIHOST_HLINE                  \ [0x00 : 15] HLINE
  [then]


  [ifdef] DSIHOST_DSI_VVSACR_DEF
    \
    \ @brief DSI Host video VSA configuration register
    \ Address offset: 0x54
    \ Reset value: 0x00000000
    \
    $00 constant DSIHOST_VSA                    \ [0x00 : 10] VSA
  [then]


  [ifdef] DSIHOST_DSI_VVBPCR_DEF
    \
    \ @brief DSI Host video VBP configuration register
    \ Address offset: 0x58
    \ Reset value: 0x00000000
    \
    $00 constant DSIHOST_VBP                    \ [0x00 : 10] VBP
  [then]


  [ifdef] DSIHOST_DSI_VVFPCR_DEF
    \
    \ @brief DSI Host video VFP configuration register
    \ Address offset: 0x5C
    \ Reset value: 0x00000000
    \
    $00 constant DSIHOST_VFP                    \ [0x00 : 10] VFP
  [then]


  [ifdef] DSIHOST_DSI_VVACR_DEF
    \
    \ @brief DSI Host video VA configuration register
    \ Address offset: 0x60
    \ Reset value: 0x00000000
    \
    $00 constant DSIHOST_VA                     \ [0x00 : 14] VA
  [then]


  [ifdef] DSIHOST_DSI_LCCR_DEF
    \
    \ @brief DSI Host LTDC command configuration register
    \ Address offset: 0x64
    \ Reset value: 0x00000000
    \
    $00 constant DSIHOST_CMDSIZE                \ [0x00 : 16] CMDSIZE
  [then]


  [ifdef] DSIHOST_DSI_CMCR_DEF
    \
    \ @brief DSI Host command mode configuration register
    \ Address offset: 0x68
    \ Reset value: 0x00000000
    \
    $00 constant DSIHOST_TEARE                  \ [0x00] TEARE
    $01 constant DSIHOST_ARE                    \ [0x01] ARE
    $08 constant DSIHOST_GSW0TX                 \ [0x08] GSW0TX
    $09 constant DSIHOST_GSW1TX                 \ [0x09] GSW1TX
    $0a constant DSIHOST_GSW2TX                 \ [0x0a] GSW2TX
    $0b constant DSIHOST_GSR0TX                 \ [0x0b] GSR0TX
    $0c constant DSIHOST_GSR1TX                 \ [0x0c] GSR1TX
    $0d constant DSIHOST_GSR2TX                 \ [0x0d] GSR2TX
    $0e constant DSIHOST_GLWTX                  \ [0x0e] GLWTX
    $10 constant DSIHOST_DSW0TX                 \ [0x10] DSW0TX
    $11 constant DSIHOST_DSW1TX                 \ [0x11] DSW1TX
    $12 constant DSIHOST_DSR0TX                 \ [0x12] DSR0TX
    $13 constant DSIHOST_DLWTX                  \ [0x13] DLWTX
    $18 constant DSIHOST_MRDPS                  \ [0x18] MRDPS
  [then]


  [ifdef] DSIHOST_DSI_GHCR_DEF
    \
    \ @brief DSI Host generic header configuration register
    \ Address offset: 0x6C
    \ Reset value: 0x00000000
    \
    $00 constant DSIHOST_DT                     \ [0x00 : 6] DT
    $06 constant DSIHOST_VCID                   \ [0x06 : 2] VCID
    $08 constant DSIHOST_WCLSB                  \ [0x08 : 8] WCLSB
    $10 constant DSIHOST_WCMSB                  \ [0x10 : 8] WCMSB
  [then]


  [ifdef] DSIHOST_DSI_GPDR_DEF
    \
    \ @brief DSI Host generic payload data register
    \ Address offset: 0x70
    \ Reset value: 0x00000000
    \
    $00 constant DSIHOST_DATA1                  \ [0x00 : 8] DATA1
    $08 constant DSIHOST_DATA2                  \ [0x08 : 8] DATA2
    $10 constant DSIHOST_DATA3                  \ [0x10 : 8] DATA3
    $18 constant DSIHOST_DATA4                  \ [0x18 : 8] DATA4
  [then]


  [ifdef] DSIHOST_DSI_GPSR_DEF
    \
    \ @brief DSI Host generic packet status register
    \ Address offset: 0x74
    \ Reset value: 0x00000015
    \
    $00 constant DSIHOST_CMDFE                  \ [0x00] CMDFE
    $01 constant DSIHOST_CMDFF                  \ [0x01] CMDFF
    $02 constant DSIHOST_PWRFE                  \ [0x02] PWRFE
    $03 constant DSIHOST_PWRFF                  \ [0x03] PWRFF
    $04 constant DSIHOST_PRDFE                  \ [0x04] PRDFE
    $05 constant DSIHOST_PRDFF                  \ [0x05] PRDFF
    $06 constant DSIHOST_RCB                    \ [0x06] RCB
  [then]


  [ifdef] DSIHOST_DSI_TCCR0_DEF
    \
    \ @brief DSI Host timeout counter configuration register 0
    \ Address offset: 0x78
    \ Reset value: 0x00000000
    \
    $00 constant DSIHOST_LPRX_TOCNT             \ [0x00 : 16] LPRX_TOCNT
    $10 constant DSIHOST_HSTX_TOCNT             \ [0x10 : 16] HSTX_TOCNT
  [then]


  [ifdef] DSIHOST_DSI_TCCR1_DEF
    \
    \ @brief DSI Host timeout counter configuration register 1
    \ Address offset: 0x7C
    \ Reset value: 0x00000000
    \
    $00 constant DSIHOST_HSRD_TOCNT             \ [0x00 : 16] HSRD_TOCNT
  [then]


  [ifdef] DSIHOST_DSI_TCCR2_DEF
    \
    \ @brief DSI Host timeout counter configuration register 2
    \ Address offset: 0x80
    \ Reset value: 0x00000000
    \
    $00 constant DSIHOST_LPRD_TOCNT             \ [0x00 : 16] LPRD_TOCNT
  [then]


  [ifdef] DSIHOST_DSI_TCCR3_DEF
    \
    \ @brief DSI Host timeout counter configuration register 3
    \ Address offset: 0x84
    \ Reset value: 0x00000000
    \
    $00 constant DSIHOST_HSWR_TOCNT             \ [0x00 : 16] HSWR_TOCNT
    $18 constant DSIHOST_PM                     \ [0x18] PM
  [then]


  [ifdef] DSIHOST_DSI_TCCR4_DEF
    \
    \ @brief DSI Host timeout counter configuration register 4
    \ Address offset: 0x88
    \ Reset value: 0x00000000
    \
    $00 constant DSIHOST_LPWR_TOCNT             \ [0x00 : 16] LPWR_TOCNT
  [then]


  [ifdef] DSIHOST_DSI_TCCR5_DEF
    \
    \ @brief DSI Host timeout counter configuration register 5
    \ Address offset: 0x8C
    \ Reset value: 0x00000000
    \
    $00 constant DSIHOST_BTA_TOCNT              \ [0x00 : 16] BTA_TOCNT
  [then]


  [ifdef] DSIHOST_DSI_CLCR_DEF
    \
    \ @brief DSI Host clock lane configuration register
    \ Address offset: 0x94
    \ Reset value: 0x00000000
    \
    $00 constant DSIHOST_DPCC                   \ [0x00] DPCC
    $01 constant DSIHOST_ACR                    \ [0x01] ACR
  [then]


  [ifdef] DSIHOST_DSI_CLTCR_DEF
    \
    \ @brief DSI Host clock lane timer configuration register
    \ Address offset: 0x98
    \ Reset value: 0x00000000
    \
    $00 constant DSIHOST_LP2HS_TIME             \ [0x00 : 10] LP2HS_TIME
    $10 constant DSIHOST_HS2LP_TIME             \ [0x10 : 10] HS2LP_TIME
  [then]


  [ifdef] DSIHOST_DSI_DLTCR_DEF
    \
    \ @brief DSI Host data lane timer configuration register
    \ Address offset: 0x9C
    \ Reset value: 0x00000000
    \
    $00 constant DSIHOST_MRD_TIME               \ [0x00 : 15] Maximum read time
    $10 constant DSIHOST_LP2HS_TIME             \ [0x10 : 8] LP2HS_TIME
    $18 constant DSIHOST_HS2LP_TIME             \ [0x18 : 8] HS2LP_TIME
  [then]


  [ifdef] DSIHOST_DSI_PCTLR_DEF
    \
    \ @brief DSI Host PHY control register
    \ Address offset: 0xA0
    \ Reset value: 0x00000000
    \
    $01 constant DSIHOST_DEN                    \ [0x01] DEN
    $02 constant DSIHOST_CKE                    \ [0x02] CKE
  [then]


  [ifdef] DSIHOST_DSI_PCONFR_DEF
    \
    \ @brief DSI Host PHY configuration register
    \ Address offset: 0xA4
    \ Reset value: 0x00000001
    \
    $00 constant DSIHOST_NL                     \ [0x00 : 2] NL
    $08 constant DSIHOST_SW_TIME                \ [0x08 : 8] SW_TIME
  [then]


  [ifdef] DSIHOST_DSI_PUCR_DEF
    \
    \ @brief DSI Host PHY ULPS control register
    \ Address offset: 0xA8
    \ Reset value: 0x00000000
    \
    $00 constant DSIHOST_URCL                   \ [0x00] URCL
    $01 constant DSIHOST_UECL                   \ [0x01] UECL
    $02 constant DSIHOST_URDL                   \ [0x02] URDL
    $03 constant DSIHOST_UEDL                   \ [0x03] UEDL
  [then]


  [ifdef] DSIHOST_DSI_PTTCR_DEF
    \
    \ @brief DSI Host PHY TX triggers configuration register
    \ Address offset: 0xAC
    \ Reset value: 0x00000000
    \
    $00 constant DSIHOST_TX_TRIG                \ [0x00 : 4] TX_TRIG
  [then]


  [ifdef] DSIHOST_DSI_PSR_DEF
    \
    \ @brief DSI Host PHY status register
    \ Address offset: 0xB0
    \ Reset value: 0x00001528
    \
    $01 constant DSIHOST_PD                     \ [0x01] PD
    $02 constant DSIHOST_PSSC                   \ [0x02] PSSC
    $03 constant DSIHOST_UANC                   \ [0x03] UANC
    $04 constant DSIHOST_PSS0                   \ [0x04] PSS0
    $05 constant DSIHOST_UAN0                   \ [0x05] UAN0
    $06 constant DSIHOST_RUE0                   \ [0x06] RUE0
    $07 constant DSIHOST_PSS1                   \ [0x07] PSS1
    $08 constant DSIHOST_UAN1                   \ [0x08] UAN1
  [then]


  [ifdef] DSIHOST_DSI_ISR0_DEF
    \
    \ @brief DSI Host interrupt and status register 0
    \ Address offset: 0xBC
    \ Reset value: 0x00000000
    \
    $00 constant DSIHOST_AE0                    \ [0x00] AE0
    $01 constant DSIHOST_AE1                    \ [0x01] AE1
    $02 constant DSIHOST_AE2                    \ [0x02] AE2
    $03 constant DSIHOST_AE3                    \ [0x03] AE3
    $04 constant DSIHOST_AE4                    \ [0x04] AE4
    $05 constant DSIHOST_AE5                    \ [0x05] AE5
    $06 constant DSIHOST_AE6                    \ [0x06] AE6
    $07 constant DSIHOST_AE7                    \ [0x07] AE7
    $08 constant DSIHOST_AE8                    \ [0x08] AE8
    $09 constant DSIHOST_AE9                    \ [0x09] AE9
    $0a constant DSIHOST_AE10                   \ [0x0a] AE10
    $0b constant DSIHOST_AE11                   \ [0x0b] AE11
    $0c constant DSIHOST_AE12                   \ [0x0c] AE12
    $0d constant DSIHOST_AE13                   \ [0x0d] AE13
    $0e constant DSIHOST_AE14                   \ [0x0e] AE14
    $0f constant DSIHOST_AE15                   \ [0x0f] AE15
    $10 constant DSIHOST_PE0                    \ [0x10] PE0
    $11 constant DSIHOST_PE1                    \ [0x11] PE1
    $12 constant DSIHOST_PE2                    \ [0x12] PE2
    $13 constant DSIHOST_PE3                    \ [0x13] PE3
    $14 constant DSIHOST_PE4                    \ [0x14] PE4
  [then]


  [ifdef] DSIHOST_DSI_ISR1_DEF
    \
    \ @brief DSI Host interrupt and status register 1
    \ Address offset: 0xC0
    \ Reset value: 0x00000000
    \
    $00 constant DSIHOST_TOHSTX                 \ [0x00] TOHSTX
    $01 constant DSIHOST_TOLPRX                 \ [0x01] TOLPRX
    $02 constant DSIHOST_ECCSE                  \ [0x02] ECCSE
    $03 constant DSIHOST_ECCME                  \ [0x03] ECCME
    $04 constant DSIHOST_CRCE                   \ [0x04] CRCE
    $05 constant DSIHOST_PSE                    \ [0x05] PSE
    $06 constant DSIHOST_EOTPE                  \ [0x06] EOTPE
    $07 constant DSIHOST_LPWRE                  \ [0x07] LPWRE
    $08 constant DSIHOST_GCWRE                  \ [0x08] GCWRE
    $09 constant DSIHOST_GPWRE                  \ [0x09] GPWRE
    $0a constant DSIHOST_GPTXE                  \ [0x0a] GPTXE
    $0b constant DSIHOST_GPRDE                  \ [0x0b] GPRDE
    $0c constant DSIHOST_GPRXE                  \ [0x0c] GPRXE
  [then]


  [ifdef] DSIHOST_DSI_IER0_DEF
    \
    \ @brief DSI Host interrupt enable register 0
    \ Address offset: 0xC4
    \ Reset value: 0x00000000
    \
    $00 constant DSIHOST_AE0IE                  \ [0x00] AE0IE
    $01 constant DSIHOST_AE1IE                  \ [0x01] AE1IE
    $02 constant DSIHOST_AE2IE                  \ [0x02] AE2IE
    $03 constant DSIHOST_AE3IE                  \ [0x03] AE3IE
    $04 constant DSIHOST_AE4IE                  \ [0x04] AE4IE
    $05 constant DSIHOST_AE5IE                  \ [0x05] AE5IE
    $06 constant DSIHOST_AE6IE                  \ [0x06] AE6IE
    $07 constant DSIHOST_AE7IE                  \ [0x07] AE7IE
    $08 constant DSIHOST_AE8IE                  \ [0x08] AE8IE
    $09 constant DSIHOST_AE9IE                  \ [0x09] AE9IE
    $0a constant DSIHOST_AE10IE                 \ [0x0a] AE10IE
    $0b constant DSIHOST_AE11IE                 \ [0x0b] AE11IE
    $0c constant DSIHOST_AE12IE                 \ [0x0c] AE12IE
    $0d constant DSIHOST_AE13IE                 \ [0x0d] AE13IE
    $0e constant DSIHOST_AE14IE                 \ [0x0e] AE14IE
    $0f constant DSIHOST_AE15IE                 \ [0x0f] AE15IE
    $10 constant DSIHOST_PE0IE                  \ [0x10] PE0IE
    $11 constant DSIHOST_PE1IE                  \ [0x11] PE1IE
    $12 constant DSIHOST_PE2IE                  \ [0x12] PE2IE
    $13 constant DSIHOST_PE3IE                  \ [0x13] PE3IE
    $14 constant DSIHOST_PE4IE                  \ [0x14] PE4IE
  [then]


  [ifdef] DSIHOST_DSI_IER1_DEF
    \
    \ @brief DSI Host interrupt enable register 1
    \ Address offset: 0xC8
    \ Reset value: 0x00000000
    \
    $00 constant DSIHOST_TOHSTXIE               \ [0x00] TOHSTXIE
    $01 constant DSIHOST_TOLPRXIE               \ [0x01] TOLPRXIE
    $02 constant DSIHOST_ECCSEIE                \ [0x02] ECCSEIE
    $03 constant DSIHOST_ECCMEIE                \ [0x03] ECCMEIE
    $04 constant DSIHOST_CRCEIE                 \ [0x04] CRCEIE
    $05 constant DSIHOST_PSEIE                  \ [0x05] PSEIE
    $06 constant DSIHOST_EOTPEIE                \ [0x06] EOTPEIE
    $07 constant DSIHOST_LPWREIE                \ [0x07] LPWREIE
    $08 constant DSIHOST_GCWREIE                \ [0x08] GCWREIE
    $09 constant DSIHOST_GPWREIE                \ [0x09] GPWREIE
    $0a constant DSIHOST_GPTXEIE                \ [0x0a] GPTXEIE
    $0b constant DSIHOST_GPRDEIE                \ [0x0b] GPRDEIE
    $0c constant DSIHOST_GPRXEIE                \ [0x0c] GPRXEIE
  [then]


  [ifdef] DSIHOST_DSI_FIR0_DEF
    \
    \ @brief DSI Host force interrupt register 0
    \ Address offset: 0xD8
    \ Reset value: 0x00000000
    \
    $00 constant DSIHOST_FAE0                   \ [0x00] FAE0
    $01 constant DSIHOST_FAE1                   \ [0x01] FAE1
    $02 constant DSIHOST_FAE2                   \ [0x02] FAE2
    $03 constant DSIHOST_FAE3                   \ [0x03] FAE3
    $04 constant DSIHOST_FAE4                   \ [0x04] FAE4
    $05 constant DSIHOST_FAE5                   \ [0x05] FAE5
    $06 constant DSIHOST_FAE6                   \ [0x06] FAE6
    $07 constant DSIHOST_FAE7                   \ [0x07] FAE7
    $08 constant DSIHOST_FAE8                   \ [0x08] FAE8
    $09 constant DSIHOST_FAE9                   \ [0x09] FAE9
    $0a constant DSIHOST_FAE10                  \ [0x0a] FAE10
    $0b constant DSIHOST_FAE11                  \ [0x0b] FAE11
    $0c constant DSIHOST_FAE12                  \ [0x0c] FAE12
    $0d constant DSIHOST_FAE13                  \ [0x0d] FAE13
    $0e constant DSIHOST_FAE14                  \ [0x0e] FAE14
    $0f constant DSIHOST_FAE15                  \ [0x0f] FAE15
    $10 constant DSIHOST_FPE0                   \ [0x10] FPE0
    $11 constant DSIHOST_FPE1                   \ [0x11] FPE1
    $12 constant DSIHOST_FPE2                   \ [0x12] FPE2
    $13 constant DSIHOST_FPE3                   \ [0x13] FPE3
    $14 constant DSIHOST_FPE4                   \ [0x14] FPE4
  [then]


  [ifdef] DSIHOST_DSI_FIR1_DEF
    \
    \ @brief DSI Host force interrupt register 1
    \ Address offset: 0xDC
    \ Reset value: 0x00000000
    \
    $00 constant DSIHOST_FTOHSTX                \ [0x00] FTOHSTX
    $01 constant DSIHOST_FTOLPRX                \ [0x01] FTOLPRX
    $02 constant DSIHOST_FECCSE                 \ [0x02] FECCSE
    $03 constant DSIHOST_FECCME                 \ [0x03] FECCME
    $04 constant DSIHOST_FCRCE                  \ [0x04] FCRCE
    $05 constant DSIHOST_FPSE                   \ [0x05] FPSE
    $06 constant DSIHOST_FEOTPE                 \ [0x06] FEOTPE
    $07 constant DSIHOST_FLPWRE                 \ [0x07] FLPWRE
    $08 constant DSIHOST_FGCWRE                 \ [0x08] FGCWRE
    $09 constant DSIHOST_FGPWRE                 \ [0x09] FGPWRE
    $0a constant DSIHOST_FGPTXE                 \ [0x0a] FGPTXE
    $0b constant DSIHOST_FGPRDE                 \ [0x0b] FGPRDE
    $0c constant DSIHOST_FGPRXE                 \ [0x0c] FGPRXE
  [then]


  [ifdef] DSIHOST_DSI_VSCR_DEF
    \
    \ @brief DSI Host video shadow control register
    \ Address offset: 0x100
    \ Reset value: 0x00000000
    \
    $00 constant DSIHOST_EN                     \ [0x00] EN
    $08 constant DSIHOST_UR                     \ [0x08] UR
  [then]


  [ifdef] DSIHOST_DSI_LCVCIDR_DEF
    \
    \ @brief DSI Host LTDC current VCID register
    \ Address offset: 0x10C
    \ Reset value: 0x00000000
    \
    $00 constant DSIHOST_VCID                   \ [0x00 : 2] VCID
  [then]


  [ifdef] DSIHOST_DSI_LCCCR_DEF
    \
    \ @brief DSI Host LTDC current color coding register
    \ Address offset: 0x110
    \ Reset value: 0x00000000
    \
    $00 constant DSIHOST_COLC                   \ [0x00 : 4] COLC
    $08 constant DSIHOST_LPE                    \ [0x08] LPE
  [then]


  [ifdef] DSIHOST_DSI_LPMCCR_DEF
    \
    \ @brief DSI Host low-power mode current configuration register
    \ Address offset: 0x118
    \ Reset value: 0x00000000
    \
    $00 constant DSIHOST_VLPSIZE                \ [0x00 : 8] VLPSIZE
    $10 constant DSIHOST_LPSIZE                 \ [0x10 : 8] LPSIZE
  [then]


  [ifdef] DSIHOST_DSI_VMCCR_DEF
    \
    \ @brief DSI Host video mode current configuration register
    \ Address offset: 0x138
    \ Reset value: 0x00000000
    \
    $00 constant DSIHOST_VMT                    \ [0x00 : 2] VMT
    $02 constant DSIHOST_LPVSAE                 \ [0x02] LPVSAE
    $03 constant DSIHOST_LPVBPE                 \ [0x03] LPVBPE
    $04 constant DSIHOST_LPVFPE                 \ [0x04] LPVFPE
    $05 constant DSIHOST_LPVAE                  \ [0x05] LPVAE
    $06 constant DSIHOST_LPHBPE                 \ [0x06] LPHBPE
    $07 constant DSIHOST_LPHFE                  \ [0x07] LPHFE
    $08 constant DSIHOST_FBTAAE                 \ [0x08] FBTAAE
    $09 constant DSIHOST_LPCE                   \ [0x09] LPCE
  [then]


  [ifdef] DSIHOST_DSI_VPCCR_DEF
    \
    \ @brief DSI Host video packet current configuration register
    \ Address offset: 0x13C
    \ Reset value: 0x00000000
    \
    $00 constant DSIHOST_VPSIZE                 \ [0x00 : 14] VPSIZE
  [then]


  [ifdef] DSIHOST_DSI_VCCCR_DEF
    \
    \ @brief DSI Host video chunks current configuration register
    \ Address offset: 0x140
    \ Reset value: 0x00000000
    \
    $00 constant DSIHOST_NUMC                   \ [0x00 : 13] NUMC
  [then]


  [ifdef] DSIHOST_DSI_VNPCCR_DEF
    \
    \ @brief DSI Host video null packet current configuration register
    \ Address offset: 0x144
    \ Reset value: 0x00000000
    \
    $00 constant DSIHOST_NPSIZE                 \ [0x00 : 13] NPSIZE
  [then]


  [ifdef] DSIHOST_DSI_VHSACCR_DEF
    \
    \ @brief DSI Host video HSA current configuration register
    \ Address offset: 0x148
    \ Reset value: 0x00000000
    \
    $00 constant DSIHOST_HSA                    \ [0x00 : 12] HSA
  [then]


  [ifdef] DSIHOST_DSI_VHBPCCR_DEF
    \
    \ @brief DSI Host video HBP current configuration register
    \ Address offset: 0x14C
    \ Reset value: 0x00000000
    \
    $00 constant DSIHOST_HBP                    \ [0x00 : 12] HBP
  [then]


  [ifdef] DSIHOST_DSI_VLCCR_DEF
    \
    \ @brief DSI Host video line current configuration register
    \ Address offset: 0x150
    \ Reset value: 0x00000000
    \
    $00 constant DSIHOST_HLINE                  \ [0x00 : 15] HLINE
  [then]


  [ifdef] DSIHOST_DSI_VVSACCR_DEF
    \
    \ @brief DSI Host video VSA current configuration register
    \ Address offset: 0x154
    \ Reset value: 0x00000000
    \
    $00 constant DSIHOST_VSA                    \ [0x00 : 10] VSA
  [then]


  [ifdef] DSIHOST_DSI_VVBPCCR_DEF
    \
    \ @brief DSI Host video VBP current configuration register
    \ Address offset: 0x158
    \ Reset value: 0x00000000
    \
    $00 constant DSIHOST_VBP                    \ [0x00 : 10] VBP
  [then]


  [ifdef] DSIHOST_DSI_VVFPCCR_DEF
    \
    \ @brief DSI Host video VFP current configuration register
    \ Address offset: 0x15C
    \ Reset value: 0x00000000
    \
    $00 constant DSIHOST_VFP                    \ [0x00 : 10] VFP
  [then]


  [ifdef] DSIHOST_DSI_VVACCR_DEF
    \
    \ @brief DSI Host video VA current configuration register
    \ Address offset: 0x160
    \ Reset value: 0x00000000
    \
    $00 constant DSIHOST_VA                     \ [0x00 : 14] VA
  [then]


  [ifdef] DSIHOST_DSI_WCFGR_DEF
    \
    \ @brief DSI wrapper configuration register
    \ Address offset: 0x400
    \ Reset value: 0x00000000
    \
    $00 constant DSIHOST_DSIM                   \ [0x00] DSIM
    $01 constant DSIHOST_COLMUX                 \ [0x01 : 3] COLMUX
    $04 constant DSIHOST_TESRC                  \ [0x04] TESRC
    $05 constant DSIHOST_TEPOL                  \ [0x05] TEPOL
    $06 constant DSIHOST_AR                     \ [0x06] AR
    $07 constant DSIHOST_VSPOL                  \ [0x07] VSPOL
  [then]


  [ifdef] DSIHOST_DSI_WCR_DEF
    \
    \ @brief DSI wrapper control register
    \ Address offset: 0x404
    \ Reset value: 0x00000000
    \
    $00 constant DSIHOST_COLM                   \ [0x00] COLM
    $01 constant DSIHOST_SHTDN                  \ [0x01] SHTDN
    $02 constant DSIHOST_LTDCEN                 \ [0x02] LTDCEN
    $03 constant DSIHOST_DSIEN                  \ [0x03] DSIEN
  [then]


  [ifdef] DSIHOST_DSI_WIER_DEF
    \
    \ @brief DSI wrapper interrupt enable register
    \ Address offset: 0x408
    \ Reset value: 0x00000000
    \
    $00 constant DSIHOST_TEIE                   \ [0x00] TEIE
    $01 constant DSIHOST_ERIE                   \ [0x01] ERIE
    $09 constant DSIHOST_PLLLIE                 \ [0x09] PLLLIE
    $0a constant DSIHOST_PLLUIE                 \ [0x0a] PLLUIE
    $0d constant DSIHOST_RRIE                   \ [0x0d] RRIE
  [then]


  [ifdef] DSIHOST_DSI_WISR_DEF
    \
    \ @brief DSI wrapper interrupt and status register
    \ Address offset: 0x40C
    \ Reset value: 0x00000000
    \
    $00 constant DSIHOST_TEIF                   \ [0x00] TEIF
    $01 constant DSIHOST_ERIF                   \ [0x01] ERIF
    $02 constant DSIHOST_BUSY                   \ [0x02] BUSY
    $08 constant DSIHOST_PLLLS                  \ [0x08] PLLLS
    $09 constant DSIHOST_PLLLIF                 \ [0x09] PLLLIF
    $0a constant DSIHOST_PLLUIF                 \ [0x0a] PLLUIF
    $0c constant DSIHOST_RRS                    \ [0x0c] RRS
    $0d constant DSIHOST_RRIF                   \ [0x0d] RRIF
  [then]


  [ifdef] DSIHOST_DSI_WIFCR_DEF
    \
    \ @brief DSI wrapper interrupt flag clear register
    \ Address offset: 0x410
    \ Reset value: 0x00000000
    \
    $00 constant DSIHOST_CTEIF                  \ [0x00] CTEIF
    $01 constant DSIHOST_CERIF                  \ [0x01] CERIF
    $09 constant DSIHOST_CPLLLIF                \ [0x09] CPLLLIF
    $0a constant DSIHOST_CPLLUIF                \ [0x0a] CPLLUIF
    $0d constant DSIHOST_CRRIF                  \ [0x0d] CRRIF
  [then]


  [ifdef] DSIHOST_DSI_WPCR0_DEF
    \
    \ @brief DSI wrapper PHY configuration register 0
    \ Address offset: 0x418
    \ Reset value: 0x00000000
    \
    $00 constant DSIHOST_UIX4                   \ [0x00 : 6] UIX4
    $06 constant DSIHOST_SWCL                   \ [0x06] SWCL
    $07 constant DSIHOST_SWDL0                  \ [0x07] SWDL0
    $08 constant DSIHOST_SWDL1                  \ [0x08] SWDL1
    $09 constant DSIHOST_HSICL                  \ [0x09] HSICL
    $0a constant DSIHOST_HSIDL0                 \ [0x0a] HSIDL0
    $0b constant DSIHOST_HSIDL1                 \ [0x0b] HSIDL1
    $0c constant DSIHOST_FTXSMCL                \ [0x0c] FTXSMCL
    $0d constant DSIHOST_FTXSMDL                \ [0x0d] FTXSMDL
    $0e constant DSIHOST_CDOFFDL                \ [0x0e] CDOFFDL
    $10 constant DSIHOST_TDDL                   \ [0x10] TDDL
    $12 constant DSIHOST_PDEN                   \ [0x12] Pull-down enable
    $13 constant DSIHOST_TCLKPREPEN             \ [0x13] Custom time for tCLK-PREPARE enable
    $14 constant DSIHOST_TCLKZEROEN             \ [0x14] Custom time for tCLK-ZERO enable
    $15 constant DSIHOST_THSPREPEN              \ [0x15] Custom time for tHS-PREPARE enable
    $16 constant DSIHOST_THSTRAILEN             \ [0x16] Custom time for tHS-TRAIL enable
    $17 constant DSIHOST_THSZEROEN              \ [0x17] Custom time for tHS-ZERO enable
    $18 constant DSIHOST_TLPXDEN                \ [0x18] Custom time for tLPX for data lanes enable
    $19 constant DSIHOST_THSEXITEN              \ [0x19] Custom time for tHS-EXIT enable
    $1a constant DSIHOST_TLPXCEN                \ [0x1a] Custom time for tLPX for clock lane enable
    $1b constant DSIHOST_TCLKPOSTEN             \ [0x1b] Custom time for tCLK-POST enable
  [then]


  [ifdef] DSIHOST_DSI_WPCR1_DEF
    \
    \ @brief This register shall be programmed only when DSI is stopped (CR. DSIEN=0 and CR.EN = 0).
    \ Address offset: 0x41C
    \ Reset value: 0x00000000
    \
    $00 constant DSIHOST_HSTXDCL                \ [0x00 : 2] High-speed transmission delay on clock lane
    $02 constant DSIHOST_HSTXDDL                \ [0x02 : 2] High-speed transmission delay on data lanes
    $06 constant DSIHOST_LPSRCCL                \ [0x06 : 2] Low-power transmission slew-rate compensation on clock lane
    $08 constant DSIHOST_LPSRCDL                \ [0x08 : 2] Low-power transmission slew-rate compensation on data lanes
    $0c constant DSIHOST_SDDC                   \ [0x0c] SDD control
    $10 constant DSIHOST_HSTXSRCCL              \ [0x10 : 2] High-speed transmission slew-rate control on clock lane
    $12 constant DSIHOST_HSTXSRCDL              \ [0x12 : 2] High-speed transmission slew-rate control on data lanes
    $16 constant DSIHOST_FLPRXLPM               \ [0x16] Forces LP receiver in low-power mode
    $19 constant DSIHOST_LPRXFT                 \ [0x19 : 2] Low-power RX low-pass filtering tuning
  [then]


  [ifdef] DSIHOST_DSI_WPCR2_DEF
    \
    \ @brief DSI wrapper PHY configuration register 2
    \ Address offset: 0x420
    \ Reset value: 0x00000000
    \
    $00 constant DSIHOST_TCLKPREP               \ [0x00 : 8] TCLKPREP
    $08 constant DSIHOST_TCLKZERO               \ [0x08 : 8] TCLKZERO
    $10 constant DSIHOST_THSPREP                \ [0x10 : 8] THSPREP
    $18 constant DSIHOST_THSTRAIL               \ [0x18 : 8] THSTRAIL
  [then]


  [ifdef] DSIHOST_DSI_WPCR3_DEF
    \
    \ @brief DSI wrapper PHY configuration register 3
    \ Address offset: 0x424
    \ Reset value: 0x00000000
    \
    $00 constant DSIHOST_THSZERO                \ [0x00 : 8] THSZERO
    $08 constant DSIHOST_TLPXD                  \ [0x08 : 8] TLPXD
    $10 constant DSIHOST_THSEXIT                \ [0x10 : 8] THSEXIT
    $18 constant DSIHOST_TLPXC                  \ [0x18 : 8] TLPXC
  [then]


  [ifdef] DSIHOST_DSI_WPCR4_DEF
    \
    \ @brief DSI wrapper PHY configuration register 4
    \ Address offset: 0x428
    \ Reset value: 0x00000000
    \
    $00 constant DSIHOST_TCLKPOST               \ [0x00 : 8] TCLKPOST
  [then]


  [ifdef] DSIHOST_DSI_WRPCR_DEF
    \
    \ @brief DSI wrapper regulator and PLL control register
    \ Address offset: 0x430
    \ Reset value: 0x00000000
    \
    $00 constant DSIHOST_PLLEN                  \ [0x00] PLLEN
    $02 constant DSIHOST_NDIV                   \ [0x02 : 7] NDIV
    $0b constant DSIHOST_IDF                    \ [0x0b : 4] IDF
    $10 constant DSIHOST_ODF                    \ [0x10 : 2] ODF
    $18 constant DSIHOST_REGEN                  \ [0x18] REGEN
  [then]

  \
  \ @brief DSIHOST
  \
  $00 constant DSIHOST_DSI_VR           \ DSI Host version register
  $04 constant DSIHOST_DSI_CR           \ DSI Host control register
  $08 constant DSIHOST_DSI_CCR          \ DSI Host clock control register
  $0C constant DSIHOST_DSI_LVCIDR       \ DSI Host LTDC VCID register
  $10 constant DSIHOST_DSI_LCOLCR       \ DSI Host LTDC color coding register
  $14 constant DSIHOST_DSI_LPCR         \ DSI Host LTDC polarity configuration register
  $18 constant DSIHOST_DSI_LPMCR        \ DSI Host low-power mode configuration register
  $2C constant DSIHOST_DSI_PCR          \ DSI Host protocol configuration register
  $30 constant DSIHOST_DSI_GVCIDR       \ DSI Host generic VCID register
  $34 constant DSIHOST_DSI_MCR          \ DSI Host mode configuration register
  $38 constant DSIHOST_DSI_VMCR         \ DSI Host video mode configuration register
  $3C constant DSIHOST_DSI_VPCR         \ DSI Host video packet configuration register
  $40 constant DSIHOST_DSI_VCCR         \ DSI Host video chunks configuration register
  $44 constant DSIHOST_DSI_VNPCR        \ DSI Host video null packet configuration register
  $48 constant DSIHOST_DSI_VHSACR       \ DSI Host video HSA configuration register
  $4C constant DSIHOST_DSI_VHBPCR       \ DSI Host video HBP configuration register
  $50 constant DSIHOST_DSI_VLCR         \ DSI Host video line configuration register
  $54 constant DSIHOST_DSI_VVSACR       \ DSI Host video VSA configuration register
  $58 constant DSIHOST_DSI_VVBPCR       \ DSI Host video VBP configuration register
  $5C constant DSIHOST_DSI_VVFPCR       \ DSI Host video VFP configuration register
  $60 constant DSIHOST_DSI_VVACR        \ DSI Host video VA configuration register
  $64 constant DSIHOST_DSI_LCCR         \ DSI Host LTDC command configuration register
  $68 constant DSIHOST_DSI_CMCR         \ DSI Host command mode configuration register
  $6C constant DSIHOST_DSI_GHCR         \ DSI Host generic header configuration register
  $70 constant DSIHOST_DSI_GPDR         \ DSI Host generic payload data register
  $74 constant DSIHOST_DSI_GPSR         \ DSI Host generic packet status register
  $78 constant DSIHOST_DSI_TCCR0        \ DSI Host timeout counter configuration register 0
  $7C constant DSIHOST_DSI_TCCR1        \ DSI Host timeout counter configuration register 1
  $80 constant DSIHOST_DSI_TCCR2        \ DSI Host timeout counter configuration register 2
  $84 constant DSIHOST_DSI_TCCR3        \ DSI Host timeout counter configuration register 3
  $88 constant DSIHOST_DSI_TCCR4        \ DSI Host timeout counter configuration register 4
  $8C constant DSIHOST_DSI_TCCR5        \ DSI Host timeout counter configuration register 5
  $94 constant DSIHOST_DSI_CLCR         \ DSI Host clock lane configuration register
  $98 constant DSIHOST_DSI_CLTCR        \ DSI Host clock lane timer configuration register
  $9C constant DSIHOST_DSI_DLTCR        \ DSI Host data lane timer configuration register
  $A0 constant DSIHOST_DSI_PCTLR        \ DSI Host PHY control register
  $A4 constant DSIHOST_DSI_PCONFR       \ DSI Host PHY configuration register
  $A8 constant DSIHOST_DSI_PUCR         \ DSI Host PHY ULPS control register
  $AC constant DSIHOST_DSI_PTTCR        \ DSI Host PHY TX triggers configuration register
  $B0 constant DSIHOST_DSI_PSR          \ DSI Host PHY status register
  $BC constant DSIHOST_DSI_ISR0         \ DSI Host interrupt and status register 0
  $C0 constant DSIHOST_DSI_ISR1         \ DSI Host interrupt and status register 1
  $C4 constant DSIHOST_DSI_IER0         \ DSI Host interrupt enable register 0
  $C8 constant DSIHOST_DSI_IER1         \ DSI Host interrupt enable register 1
  $D8 constant DSIHOST_DSI_FIR0         \ DSI Host force interrupt register 0
  $DC constant DSIHOST_DSI_FIR1         \ DSI Host force interrupt register 1
  $100 constant DSIHOST_DSI_VSCR        \ DSI Host video shadow control register
  $10C constant DSIHOST_DSI_LCVCIDR     \ DSI Host LTDC current VCID register
  $110 constant DSIHOST_DSI_LCCCR       \ DSI Host LTDC current color coding register
  $118 constant DSIHOST_DSI_LPMCCR      \ DSI Host low-power mode current configuration register
  $138 constant DSIHOST_DSI_VMCCR       \ DSI Host video mode current configuration register
  $13C constant DSIHOST_DSI_VPCCR       \ DSI Host video packet current configuration register
  $140 constant DSIHOST_DSI_VCCCR       \ DSI Host video chunks current configuration register
  $144 constant DSIHOST_DSI_VNPCCR      \ DSI Host video null packet current configuration register
  $148 constant DSIHOST_DSI_VHSACCR     \ DSI Host video HSA current configuration register
  $14C constant DSIHOST_DSI_VHBPCCR     \ DSI Host video HBP current configuration register
  $150 constant DSIHOST_DSI_VLCCR       \ DSI Host video line current configuration register
  $154 constant DSIHOST_DSI_VVSACCR     \ DSI Host video VSA current configuration register
  $158 constant DSIHOST_DSI_VVBPCCR     \ DSI Host video VBP current configuration register
  $15C constant DSIHOST_DSI_VVFPCCR     \ DSI Host video VFP current configuration register
  $160 constant DSIHOST_DSI_VVACCR      \ DSI Host video VA current configuration register
  $400 constant DSIHOST_DSI_WCFGR       \ DSI wrapper configuration register
  $404 constant DSIHOST_DSI_WCR         \ DSI wrapper control register
  $408 constant DSIHOST_DSI_WIER        \ DSI wrapper interrupt enable register
  $40C constant DSIHOST_DSI_WISR        \ DSI wrapper interrupt and status register
  $410 constant DSIHOST_DSI_WIFCR       \ DSI wrapper interrupt flag clear register
  $418 constant DSIHOST_DSI_WPCR0       \ DSI wrapper PHY configuration register 0
  $41C constant DSIHOST_DSI_WPCR1       \ This register shall be programmed only when DSI is stopped (CR. DSIEN=0 and CR.EN = 0).
  $420 constant DSIHOST_DSI_WPCR2       \ DSI wrapper PHY configuration register 2
  $424 constant DSIHOST_DSI_WPCR3       \ DSI wrapper PHY configuration register 3
  $428 constant DSIHOST_DSI_WPCR4       \ DSI wrapper PHY configuration register 4
  $430 constant DSIHOST_DSI_WRPCR       \ DSI wrapper regulator and PLL control register

: DSIHOST_DEF ; [then]
