\
\ @file dsihost1.fs
\ @brief DSIHOST1
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] DSIHOST1_DEF

  [ifdef] DSIHOST1_DSI_VR_DEF
    \
    \ @brief DSI Host version register
    \ Address offset: 0x00
    \ Reset value: 0x3133312A
    \
    $00 constant DSIHOST1_VERSION               \ [0x00 : 32] VERSION
  [then]


  [ifdef] DSIHOST1_DSI_CR_DEF
    \
    \ @brief DSI Host control register
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $00 constant DSIHOST1_EN                    \ [0x00] EN
  [then]


  [ifdef] DSIHOST1_DSI_CCR_DEF
    \
    \ @brief DSI Host clock control register
    \ Address offset: 0x08
    \ Reset value: 0x00000000
    \
    $00 constant DSIHOST1_TXECKDIV              \ [0x00 : 8] TXECKDIV
    $08 constant DSIHOST1_TOCKDIV               \ [0x08 : 8] TOCKDIV
  [then]


  [ifdef] DSIHOST1_DSI_LVCIDR_DEF
    \
    \ @brief DSI Host LTDC VCID register
    \ Address offset: 0x0C
    \ Reset value: 0x00000000
    \
    $00 constant DSIHOST1_VCID                  \ [0x00 : 2] VCID
  [then]


  [ifdef] DSIHOST1_DSI_LCOLCR_DEF
    \
    \ @brief DSI Host LTDC color coding register
    \ Address offset: 0x10
    \ Reset value: 0x00000000
    \
    $00 constant DSIHOST1_COLC                  \ [0x00 : 4] COLC
    $08 constant DSIHOST1_LPE                   \ [0x08] LPE
  [then]


  [ifdef] DSIHOST1_DSI_LPCR_DEF
    \
    \ @brief DSI Host LTDC polarity configuration register
    \ Address offset: 0x14
    \ Reset value: 0x00000000
    \
    $00 constant DSIHOST1_DEP                   \ [0x00] DEP
    $01 constant DSIHOST1_VSP                   \ [0x01] VSP
    $02 constant DSIHOST1_HSP                   \ [0x02] HSP
  [then]


  [ifdef] DSIHOST1_DSI_LPMCR_DEF
    \
    \ @brief DSI Host low-power mode configuration register
    \ Address offset: 0x18
    \ Reset value: 0x00000000
    \
    $00 constant DSIHOST1_VLPSIZE               \ [0x00 : 8] VLPSIZE
    $10 constant DSIHOST1_LPSIZE                \ [0x10 : 8] LPSIZE
  [then]


  [ifdef] DSIHOST1_DSI_PCR_DEF
    \
    \ @brief DSI Host protocol configuration register
    \ Address offset: 0x2C
    \ Reset value: 0x00000000
    \
    $00 constant DSIHOST1_ETTXE                 \ [0x00] ETTXE
    $01 constant DSIHOST1_ETRXE                 \ [0x01] ETRXE
    $02 constant DSIHOST1_BTAE                  \ [0x02] BTAE
    $03 constant DSIHOST1_ECCRXE                \ [0x03] ECCRXE
    $04 constant DSIHOST1_CRCRXE                \ [0x04] CRCRXE
  [then]


  [ifdef] DSIHOST1_DSI_GVCIDR_DEF
    \
    \ @brief DSI Host generic VCID register
    \ Address offset: 0x30
    \ Reset value: 0x00000000
    \
    $00 constant DSIHOST1_VCID                  \ [0x00 : 2] VCID
  [then]


  [ifdef] DSIHOST1_DSI_MCR_DEF
    \
    \ @brief DSI Host mode configuration register
    \ Address offset: 0x34
    \ Reset value: 0x00000001
    \
    $00 constant DSIHOST1_CMDM                  \ [0x00] CMDM
  [then]


  [ifdef] DSIHOST1_DSI_VMCR_DEF
    \
    \ @brief DSI Host video mode configuration register
    \ Address offset: 0x38
    \ Reset value: 0x00000000
    \
    $00 constant DSIHOST1_VMT                   \ [0x00 : 2] VMT
    $08 constant DSIHOST1_LPVSAE                \ [0x08] LPVSAE
    $09 constant DSIHOST1_LPVBPE                \ [0x09] LPVBPE
    $0a constant DSIHOST1_LPVFPE                \ [0x0a] LPVFPE
    $0b constant DSIHOST1_LPVAE                 \ [0x0b] LPVAE
    $0c constant DSIHOST1_LPHBPE                \ [0x0c] LPHBPE
    $0d constant DSIHOST1_LPHFPE                \ [0x0d] LPHFPE
    $0e constant DSIHOST1_FBTAAE                \ [0x0e] FBTAAE
    $0f constant DSIHOST1_LPCE                  \ [0x0f] LPCE
    $10 constant DSIHOST1_PGE                   \ [0x10] PGE
    $14 constant DSIHOST1_PGM                   \ [0x14] PGM
    $18 constant DSIHOST1_PGO                   \ [0x18] PGO
  [then]


  [ifdef] DSIHOST1_DSI_VPCR_DEF
    \
    \ @brief DSI Host video packet configuration register
    \ Address offset: 0x3C
    \ Reset value: 0x00000000
    \
    $00 constant DSIHOST1_VPSIZE                \ [0x00 : 14] VPSIZE
  [then]


  [ifdef] DSIHOST1_DSI_VCCR_DEF
    \
    \ @brief DSI Host video chunks configuration register
    \ Address offset: 0x40
    \ Reset value: 0x00000000
    \
    $00 constant DSIHOST1_NUMC                  \ [0x00 : 13] NUMC
  [then]


  [ifdef] DSIHOST1_DSI_VNPCR_DEF
    \
    \ @brief DSI Host video null packet configuration register
    \ Address offset: 0x44
    \ Reset value: 0x00000000
    \
    $00 constant DSIHOST1_NPSIZE                \ [0x00 : 13] NPSIZE
  [then]


  [ifdef] DSIHOST1_DSI_VHSACR_DEF
    \
    \ @brief DSI Host video HSA configuration register
    \ Address offset: 0x48
    \ Reset value: 0x00000000
    \
    $00 constant DSIHOST1_HSA                   \ [0x00 : 12] HSA
  [then]


  [ifdef] DSIHOST1_DSI_VHBPCR_DEF
    \
    \ @brief DSI Host video HBP configuration register
    \ Address offset: 0x4C
    \ Reset value: 0x00000000
    \
    $00 constant DSIHOST1_HBP                   \ [0x00 : 12] HBP
  [then]


  [ifdef] DSIHOST1_DSI_VLCR_DEF
    \
    \ @brief DSI Host video line configuration register
    \ Address offset: 0x50
    \ Reset value: 0x00000000
    \
    $00 constant DSIHOST1_HLINE                 \ [0x00 : 15] HLINE
  [then]


  [ifdef] DSIHOST1_DSI_VVSACR_DEF
    \
    \ @brief DSI Host video VSA configuration register
    \ Address offset: 0x54
    \ Reset value: 0x00000000
    \
    $00 constant DSIHOST1_VSA                   \ [0x00 : 10] VSA
  [then]


  [ifdef] DSIHOST1_DSI_VVBPCR_DEF
    \
    \ @brief DSI Host video VBP configuration register
    \ Address offset: 0x58
    \ Reset value: 0x00000000
    \
    $00 constant DSIHOST1_VBP                   \ [0x00 : 10] VBP
  [then]


  [ifdef] DSIHOST1_DSI_VVFPCR_DEF
    \
    \ @brief DSI Host video VFP configuration register
    \ Address offset: 0x5C
    \ Reset value: 0x00000000
    \
    $00 constant DSIHOST1_VFP                   \ [0x00 : 10] VFP
  [then]


  [ifdef] DSIHOST1_DSI_VVACR_DEF
    \
    \ @brief DSI Host video VA configuration register
    \ Address offset: 0x60
    \ Reset value: 0x00000000
    \
    $00 constant DSIHOST1_VA                    \ [0x00 : 14] VA
  [then]


  [ifdef] DSIHOST1_DSI_LCCR_DEF
    \
    \ @brief DSI Host LTDC command configuration register
    \ Address offset: 0x64
    \ Reset value: 0x00000000
    \
    $00 constant DSIHOST1_CMDSIZE               \ [0x00 : 16] CMDSIZE
  [then]


  [ifdef] DSIHOST1_DSI_CMCR_DEF
    \
    \ @brief DSI Host command mode configuration register
    \ Address offset: 0x68
    \ Reset value: 0x00000000
    \
    $00 constant DSIHOST1_TEARE                 \ [0x00] TEARE
    $01 constant DSIHOST1_ARE                   \ [0x01] ARE
    $08 constant DSIHOST1_GSW0TX                \ [0x08] GSW0TX
    $09 constant DSIHOST1_GSW1TX                \ [0x09] GSW1TX
    $0a constant DSIHOST1_GSW2TX                \ [0x0a] GSW2TX
    $0b constant DSIHOST1_GSR0TX                \ [0x0b] GSR0TX
    $0c constant DSIHOST1_GSR1TX                \ [0x0c] GSR1TX
    $0d constant DSIHOST1_GSR2TX                \ [0x0d] GSR2TX
    $0e constant DSIHOST1_GLWTX                 \ [0x0e] GLWTX
    $10 constant DSIHOST1_DSW0TX                \ [0x10] DSW0TX
    $11 constant DSIHOST1_DSW1TX                \ [0x11] DSW1TX
    $12 constant DSIHOST1_DSR0TX                \ [0x12] DSR0TX
    $13 constant DSIHOST1_DLWTX                 \ [0x13] DLWTX
    $18 constant DSIHOST1_MRDPS                 \ [0x18] MRDPS
  [then]


  [ifdef] DSIHOST1_DSI_GHCR_DEF
    \
    \ @brief DSI Host generic header configuration register
    \ Address offset: 0x6C
    \ Reset value: 0x00000000
    \
    $00 constant DSIHOST1_DT                    \ [0x00 : 6] DT
    $06 constant DSIHOST1_VCID                  \ [0x06 : 2] VCID
    $08 constant DSIHOST1_WCLSB                 \ [0x08 : 8] WCLSB
    $10 constant DSIHOST1_WCMSB                 \ [0x10 : 8] WCMSB
  [then]


  [ifdef] DSIHOST1_DSI_GPDR_DEF
    \
    \ @brief DSI Host generic payload data register
    \ Address offset: 0x70
    \ Reset value: 0x00000000
    \
    $00 constant DSIHOST1_DATA1                 \ [0x00 : 8] DATA1
    $08 constant DSIHOST1_DATA2                 \ [0x08 : 8] DATA2
    $10 constant DSIHOST1_DATA3                 \ [0x10 : 8] DATA3
    $18 constant DSIHOST1_DATA4                 \ [0x18 : 8] DATA4
  [then]


  [ifdef] DSIHOST1_DSI_GPSR_DEF
    \
    \ @brief DSI Host generic packet status register
    \ Address offset: 0x74
    \ Reset value: 0x00000015
    \
    $00 constant DSIHOST1_CMDFE                 \ [0x00] CMDFE
    $01 constant DSIHOST1_CMDFF                 \ [0x01] CMDFF
    $02 constant DSIHOST1_PWRFE                 \ [0x02] PWRFE
    $03 constant DSIHOST1_PWRFF                 \ [0x03] PWRFF
    $04 constant DSIHOST1_PRDFE                 \ [0x04] PRDFE
    $05 constant DSIHOST1_PRDFF                 \ [0x05] PRDFF
    $06 constant DSIHOST1_RCB                   \ [0x06] RCB
  [then]


  [ifdef] DSIHOST1_DSI_TCCR0_DEF
    \
    \ @brief DSI Host timeout counter configuration register 0
    \ Address offset: 0x78
    \ Reset value: 0x00000000
    \
    $00 constant DSIHOST1_LPRX_TOCNT            \ [0x00 : 16] LPRX_TOCNT
    $10 constant DSIHOST1_HSTX_TOCNT            \ [0x10 : 16] HSTX_TOCNT
  [then]


  [ifdef] DSIHOST1_DSI_TCCR1_DEF
    \
    \ @brief DSI Host timeout counter configuration register 1
    \ Address offset: 0x7C
    \ Reset value: 0x00000000
    \
    $00 constant DSIHOST1_HSRD_TOCNT            \ [0x00 : 16] HSRD_TOCNT
  [then]


  [ifdef] DSIHOST1_DSI_TCCR2_DEF
    \
    \ @brief DSI Host timeout counter configuration register 2
    \ Address offset: 0x80
    \ Reset value: 0x00000000
    \
    $00 constant DSIHOST1_LPRD_TOCNT            \ [0x00 : 16] LPRD_TOCNT
  [then]


  [ifdef] DSIHOST1_DSI_TCCR3_DEF
    \
    \ @brief DSI Host timeout counter configuration register 3
    \ Address offset: 0x84
    \ Reset value: 0x00000000
    \
    $00 constant DSIHOST1_HSWR_TOCNT            \ [0x00 : 16] HSWR_TOCNT
    $18 constant DSIHOST1_PM                    \ [0x18] PM
  [then]


  [ifdef] DSIHOST1_DSI_TCCR4_DEF
    \
    \ @brief DSI Host timeout counter configuration register 4
    \ Address offset: 0x88
    \ Reset value: 0x00000000
    \
    $00 constant DSIHOST1_LPWR_TOCNT            \ [0x00 : 16] LPWR_TOCNT
  [then]


  [ifdef] DSIHOST1_DSI_TCCR5_DEF
    \
    \ @brief DSI Host timeout counter configuration register 5
    \ Address offset: 0x8C
    \ Reset value: 0x00000000
    \
    $00 constant DSIHOST1_BTA_TOCNT             \ [0x00 : 16] BTA_TOCNT
  [then]


  [ifdef] DSIHOST1_DSI_CLCR_DEF
    \
    \ @brief DSI Host clock lane configuration register
    \ Address offset: 0x94
    \ Reset value: 0x00000000
    \
    $00 constant DSIHOST1_DPCC                  \ [0x00] DPCC
    $01 constant DSIHOST1_ACR                   \ [0x01] ACR
  [then]


  [ifdef] DSIHOST1_DSI_CLTCR_DEF
    \
    \ @brief DSI Host clock lane timer configuration register
    \ Address offset: 0x98
    \ Reset value: 0x00000000
    \
    $00 constant DSIHOST1_LP2HS_TIME            \ [0x00 : 10] LP2HS_TIME
    $10 constant DSIHOST1_HS2LP_TIME            \ [0x10 : 10] HS2LP_TIME
  [then]


  [ifdef] DSIHOST1_DSI_DLTCR_DEF
    \
    \ @brief DSI Host data lane timer configuration register
    \ Address offset: 0x9C
    \ Reset value: 0x00000000
    \
    $00 constant DSIHOST1_LP2HS_TIME            \ [0x00 : 10] LP2HS_TIME
    $10 constant DSIHOST1_HS2LP_TIME            \ [0x10 : 10] HS2LP_TIME
  [then]


  [ifdef] DSIHOST1_DSI_PCTLR_DEF
    \
    \ @brief DSI Host PHY control register
    \ Address offset: 0xA0
    \ Reset value: 0x00000000
    \
    $01 constant DSIHOST1_DEN                   \ [0x01] DEN
    $02 constant DSIHOST1_CKE                   \ [0x02] CKE
  [then]


  [ifdef] DSIHOST1_DSI_PCONFR_DEF
    \
    \ @brief DSI Host PHY configuration register
    \ Address offset: 0xA4
    \ Reset value: 0x00000001
    \
    $00 constant DSIHOST1_NL                    \ [0x00 : 2] NL
    $08 constant DSIHOST1_SW_TIME               \ [0x08 : 8] SW_TIME
  [then]


  [ifdef] DSIHOST1_DSI_PUCR_DEF
    \
    \ @brief DSI Host PHY ULPS control register
    \ Address offset: 0xA8
    \ Reset value: 0x00000000
    \
    $00 constant DSIHOST1_URCL                  \ [0x00] URCL
    $01 constant DSIHOST1_UECL                  \ [0x01] UECL
    $02 constant DSIHOST1_URDL                  \ [0x02] URDL
    $03 constant DSIHOST1_UEDL                  \ [0x03] UEDL
  [then]


  [ifdef] DSIHOST1_DSI_PTTCR_DEF
    \
    \ @brief DSI Host PHY TX triggers configuration register
    \ Address offset: 0xAC
    \ Reset value: 0x00000000
    \
    $00 constant DSIHOST1_TX_TRIG               \ [0x00 : 4] TX_TRIG
  [then]


  [ifdef] DSIHOST1_DSI_PSR_DEF
    \
    \ @brief DSI Host PHY status register
    \ Address offset: 0xB0
    \ Reset value: 0x00001528
    \
    $01 constant DSIHOST1_PD                    \ [0x01] PD
    $02 constant DSIHOST1_PSSC                  \ [0x02] PSSC
    $03 constant DSIHOST1_UANC                  \ [0x03] UANC
    $04 constant DSIHOST1_PSS0                  \ [0x04] PSS0
    $05 constant DSIHOST1_UAN0                  \ [0x05] UAN0
    $06 constant DSIHOST1_RUE0                  \ [0x06] RUE0
    $07 constant DSIHOST1_PSS1                  \ [0x07] PSS1
    $08 constant DSIHOST1_UAN1                  \ [0x08] UAN1
  [then]


  [ifdef] DSIHOST1_DSI_ISR0_DEF
    \
    \ @brief DSI Host interrupt and status register 0
    \ Address offset: 0xBC
    \ Reset value: 0x00000000
    \
    $00 constant DSIHOST1_AE0                   \ [0x00] AE0
    $01 constant DSIHOST1_AE1                   \ [0x01] AE1
    $02 constant DSIHOST1_AE2                   \ [0x02] AE2
    $03 constant DSIHOST1_AE3                   \ [0x03] AE3
    $04 constant DSIHOST1_AE4                   \ [0x04] AE4
    $05 constant DSIHOST1_AE5                   \ [0x05] AE5
    $06 constant DSIHOST1_AE6                   \ [0x06] AE6
    $07 constant DSIHOST1_AE7                   \ [0x07] AE7
    $08 constant DSIHOST1_AE8                   \ [0x08] AE8
    $09 constant DSIHOST1_AE9                   \ [0x09] AE9
    $0a constant DSIHOST1_AE10                  \ [0x0a] AE10
    $0b constant DSIHOST1_AE11                  \ [0x0b] AE11
    $0c constant DSIHOST1_AE12                  \ [0x0c] AE12
    $0d constant DSIHOST1_AE13                  \ [0x0d] AE13
    $0e constant DSIHOST1_AE14                  \ [0x0e] AE14
    $0f constant DSIHOST1_AE15                  \ [0x0f] AE15
    $10 constant DSIHOST1_PE0                   \ [0x10] PE0
    $11 constant DSIHOST1_PE1                   \ [0x11] PE1
    $12 constant DSIHOST1_PE2                   \ [0x12] PE2
    $13 constant DSIHOST1_PE3                   \ [0x13] PE3
    $14 constant DSIHOST1_PE4                   \ [0x14] PE4
  [then]


  [ifdef] DSIHOST1_DSI_ISR1_DEF
    \
    \ @brief DSI Host interrupt and status register 1
    \ Address offset: 0xC0
    \ Reset value: 0x00000000
    \
    $00 constant DSIHOST1_TOHSTX                \ [0x00] TOHSTX
    $01 constant DSIHOST1_TOLPRX                \ [0x01] TOLPRX
    $02 constant DSIHOST1_ECCSE                 \ [0x02] ECCSE
    $03 constant DSIHOST1_ECCME                 \ [0x03] ECCME
    $04 constant DSIHOST1_CRCE                  \ [0x04] CRCE
    $05 constant DSIHOST1_PSE                   \ [0x05] PSE
    $06 constant DSIHOST1_EOTPE                 \ [0x06] EOTPE
    $07 constant DSIHOST1_LPWRE                 \ [0x07] LPWRE
    $08 constant DSIHOST1_GCWRE                 \ [0x08] GCWRE
    $09 constant DSIHOST1_GPWRE                 \ [0x09] GPWRE
    $0a constant DSIHOST1_GPTXE                 \ [0x0a] GPTXE
    $0b constant DSIHOST1_GPRDE                 \ [0x0b] GPRDE
    $0c constant DSIHOST1_GPRXE                 \ [0x0c] GPRXE
  [then]


  [ifdef] DSIHOST1_DSI_IER0_DEF
    \
    \ @brief DSI Host interrupt enable register 0
    \ Address offset: 0xC4
    \ Reset value: 0x00000000
    \
    $00 constant DSIHOST1_AE0IE                 \ [0x00] AE0IE
    $01 constant DSIHOST1_AE1IE                 \ [0x01] AE1IE
    $02 constant DSIHOST1_AE2IE                 \ [0x02] AE2IE
    $03 constant DSIHOST1_AE3IE                 \ [0x03] AE3IE
    $04 constant DSIHOST1_AE4IE                 \ [0x04] AE4IE
    $05 constant DSIHOST1_AE5IE                 \ [0x05] AE5IE
    $06 constant DSIHOST1_AE6IE                 \ [0x06] AE6IE
    $07 constant DSIHOST1_AE7IE                 \ [0x07] AE7IE
    $08 constant DSIHOST1_AE8IE                 \ [0x08] AE8IE
    $09 constant DSIHOST1_AE9IE                 \ [0x09] AE9IE
    $0a constant DSIHOST1_AE10IE                \ [0x0a] AE10IE
    $0b constant DSIHOST1_AE11IE                \ [0x0b] AE11IE
    $0c constant DSIHOST1_AE12IE                \ [0x0c] AE12IE
    $0d constant DSIHOST1_AE13IE                \ [0x0d] AE13IE
    $0e constant DSIHOST1_AE14IE                \ [0x0e] AE14IE
    $0f constant DSIHOST1_AE15IE                \ [0x0f] AE15IE
    $10 constant DSIHOST1_PE0IE                 \ [0x10] PE0IE
    $11 constant DSIHOST1_PE1IE                 \ [0x11] PE1IE
    $12 constant DSIHOST1_PE2IE                 \ [0x12] PE2IE
    $13 constant DSIHOST1_PE3IE                 \ [0x13] PE3IE
    $14 constant DSIHOST1_PE4IE                 \ [0x14] PE4IE
  [then]


  [ifdef] DSIHOST1_DSI_IER1_DEF
    \
    \ @brief DSI Host interrupt enable register 1
    \ Address offset: 0xC8
    \ Reset value: 0x00000000
    \
    $00 constant DSIHOST1_TOHSTXIE              \ [0x00] TOHSTXIE
    $01 constant DSIHOST1_TOLPRXIE              \ [0x01] TOLPRXIE
    $02 constant DSIHOST1_ECCSEIE               \ [0x02] ECCSEIE
    $03 constant DSIHOST1_ECCMEIE               \ [0x03] ECCMEIE
    $04 constant DSIHOST1_CRCEIE                \ [0x04] CRCEIE
    $05 constant DSIHOST1_PSEIE                 \ [0x05] PSEIE
    $06 constant DSIHOST1_EOTPEIE               \ [0x06] EOTPEIE
    $07 constant DSIHOST1_LPWREIE               \ [0x07] LPWREIE
    $08 constant DSIHOST1_GCWREIE               \ [0x08] GCWREIE
    $09 constant DSIHOST1_GPWREIE               \ [0x09] GPWREIE
    $0a constant DSIHOST1_GPTXEIE               \ [0x0a] GPTXEIE
    $0b constant DSIHOST1_GPRDEIE               \ [0x0b] GPRDEIE
    $0c constant DSIHOST1_GPRXEIE               \ [0x0c] GPRXEIE
  [then]


  [ifdef] DSIHOST1_DSI_FIR0_DEF
    \
    \ @brief DSI Host force interrupt register 0
    \ Address offset: 0xD8
    \ Reset value: 0x00000000
    \
    $00 constant DSIHOST1_FAE0                  \ [0x00] FAE0
    $01 constant DSIHOST1_FAE1                  \ [0x01] FAE1
    $02 constant DSIHOST1_FAE2                  \ [0x02] FAE2
    $03 constant DSIHOST1_FAE3                  \ [0x03] FAE3
    $04 constant DSIHOST1_FAE4                  \ [0x04] FAE4
    $05 constant DSIHOST1_FAE5                  \ [0x05] FAE5
    $06 constant DSIHOST1_FAE6                  \ [0x06] FAE6
    $07 constant DSIHOST1_FAE7                  \ [0x07] FAE7
    $08 constant DSIHOST1_FAE8                  \ [0x08] FAE8
    $09 constant DSIHOST1_FAE9                  \ [0x09] FAE9
    $0a constant DSIHOST1_FAE10                 \ [0x0a] FAE10
    $0b constant DSIHOST1_FAE11                 \ [0x0b] FAE11
    $0c constant DSIHOST1_FAE12                 \ [0x0c] FAE12
    $0d constant DSIHOST1_FAE13                 \ [0x0d] FAE13
    $0e constant DSIHOST1_FAE14                 \ [0x0e] FAE14
    $0f constant DSIHOST1_FAE15                 \ [0x0f] FAE15
    $10 constant DSIHOST1_FPE0                  \ [0x10] FPE0
    $11 constant DSIHOST1_FPE1                  \ [0x11] FPE1
    $12 constant DSIHOST1_FPE2                  \ [0x12] FPE2
    $13 constant DSIHOST1_FPE3                  \ [0x13] FPE3
    $14 constant DSIHOST1_FPE4                  \ [0x14] FPE4
  [then]


  [ifdef] DSIHOST1_DSI_FIR1_DEF
    \
    \ @brief DSI Host force interrupt register 1
    \ Address offset: 0xDC
    \ Reset value: 0x00000000
    \
    $00 constant DSIHOST1_FTOHSTX               \ [0x00] FTOHSTX
    $01 constant DSIHOST1_FTOLPRX               \ [0x01] FTOLPRX
    $02 constant DSIHOST1_FECCSE                \ [0x02] FECCSE
    $03 constant DSIHOST1_FECCME                \ [0x03] FECCME
    $04 constant DSIHOST1_FCRCE                 \ [0x04] FCRCE
    $05 constant DSIHOST1_FPSE                  \ [0x05] FPSE
    $06 constant DSIHOST1_FEOTPE                \ [0x06] FEOTPE
    $07 constant DSIHOST1_FLPWRE                \ [0x07] FLPWRE
    $08 constant DSIHOST1_FGCWRE                \ [0x08] FGCWRE
    $09 constant DSIHOST1_FGPWRE                \ [0x09] FGPWRE
    $0a constant DSIHOST1_FGPTXE                \ [0x0a] FGPTXE
    $0b constant DSIHOST1_FGPRDE                \ [0x0b] FGPRDE
    $0c constant DSIHOST1_FGPRXE                \ [0x0c] FGPRXE
  [then]


  [ifdef] DSIHOST1_DSI_DLTRCR_DEF
    \
    \ @brief DSI Host data lane timer read configuration register
    \ Address offset: 0xF4
    \ Reset value: 0x00000000
    \
    $00 constant DSIHOST1_MRD_TIME              \ [0x00 : 15] MRD_TIME
  [then]


  [ifdef] DSIHOST1_DSI_VSCR_DEF
    \
    \ @brief DSI Host video shadow control register
    \ Address offset: 0x100
    \ Reset value: 0x00000000
    \
    $00 constant DSIHOST1_EN                    \ [0x00] EN
    $08 constant DSIHOST1_UR                    \ [0x08] UR
  [then]


  [ifdef] DSIHOST1_DSI_LCVCIDR_DEF
    \
    \ @brief DSI Host LTDC current VCID register
    \ Address offset: 0x10C
    \ Reset value: 0x00000000
    \
    $00 constant DSIHOST1_VCID                  \ [0x00 : 2] VCID
  [then]


  [ifdef] DSIHOST1_DSI_LCCCR_DEF
    \
    \ @brief DSI Host LTDC current color coding register
    \ Address offset: 0x110
    \ Reset value: 0x00000000
    \
    $00 constant DSIHOST1_COLC                  \ [0x00 : 4] COLC
    $08 constant DSIHOST1_LPE                   \ [0x08] LPE
  [then]


  [ifdef] DSIHOST1_DSI_LPMCCR_DEF
    \
    \ @brief DSI Host low-power mode current configuration register
    \ Address offset: 0x118
    \ Reset value: 0x00000000
    \
    $00 constant DSIHOST1_VLPSIZE               \ [0x00 : 8] VLPSIZE
    $10 constant DSIHOST1_LPSIZE                \ [0x10 : 8] LPSIZE
  [then]


  [ifdef] DSIHOST1_DSI_VMCCR_DEF
    \
    \ @brief DSI Host video mode current configuration register
    \ Address offset: 0x138
    \ Reset value: 0x00000000
    \
    $00 constant DSIHOST1_VMT                   \ [0x00 : 2] VMT
    $02 constant DSIHOST1_LPVSAE                \ [0x02] LPVSAE
    $03 constant DSIHOST1_LPVBPE                \ [0x03] LPVBPE
    $04 constant DSIHOST1_LPVFPE                \ [0x04] LPVFPE
    $05 constant DSIHOST1_LPVAE                 \ [0x05] LPVAE
    $06 constant DSIHOST1_LPHBPE                \ [0x06] LPHBPE
    $07 constant DSIHOST1_LPHFE                 \ [0x07] LPHFE
    $08 constant DSIHOST1_FBTAAE                \ [0x08] FBTAAE
    $09 constant DSIHOST1_LPCE                  \ [0x09] LPCE
  [then]


  [ifdef] DSIHOST1_DSI_VPCCR_DEF
    \
    \ @brief DSI Host video packet current configuration register
    \ Address offset: 0x13C
    \ Reset value: 0x00000000
    \
    $00 constant DSIHOST1_VPSIZE                \ [0x00 : 14] VPSIZE
  [then]


  [ifdef] DSIHOST1_DSI_VCCCR_DEF
    \
    \ @brief DSI Host video chunks current configuration register
    \ Address offset: 0x140
    \ Reset value: 0x00000000
    \
    $00 constant DSIHOST1_NUMC                  \ [0x00 : 13] NUMC
  [then]


  [ifdef] DSIHOST1_DSI_VNPCCR_DEF
    \
    \ @brief DSI Host video null packet current configuration register
    \ Address offset: 0x144
    \ Reset value: 0x00000000
    \
    $00 constant DSIHOST1_NPSIZE                \ [0x00 : 13] NPSIZE
  [then]


  [ifdef] DSIHOST1_DSI_VHSACCR_DEF
    \
    \ @brief DSI Host video HSA current configuration register
    \ Address offset: 0x148
    \ Reset value: 0x00000000
    \
    $00 constant DSIHOST1_HSA                   \ [0x00 : 12] HSA
  [then]


  [ifdef] DSIHOST1_DSI_VHBPCCR_DEF
    \
    \ @brief DSI Host video HBP current configuration register
    \ Address offset: 0x14C
    \ Reset value: 0x00000000
    \
    $00 constant DSIHOST1_HBP                   \ [0x00 : 12] HBP
  [then]


  [ifdef] DSIHOST1_DSI_VLCCR_DEF
    \
    \ @brief DSI Host video line current configuration register
    \ Address offset: 0x150
    \ Reset value: 0x00000000
    \
    $00 constant DSIHOST1_HLINE                 \ [0x00 : 15] HLINE
  [then]


  [ifdef] DSIHOST1_DSI_VVSACCR_DEF
    \
    \ @brief DSI Host video VSA current configuration register
    \ Address offset: 0x154
    \ Reset value: 0x00000000
    \
    $00 constant DSIHOST1_VSA                   \ [0x00 : 10] VSA
  [then]


  [ifdef] DSIHOST1_DSI_VVBPCCR_DEF
    \
    \ @brief DSI Host video VBP current configuration register
    \ Address offset: 0x158
    \ Reset value: 0x00000000
    \
    $00 constant DSIHOST1_VBP                   \ [0x00 : 10] VBP
  [then]


  [ifdef] DSIHOST1_DSI_VVFPCCR_DEF
    \
    \ @brief DSI Host video VFP current configuration register
    \ Address offset: 0x15C
    \ Reset value: 0x00000000
    \
    $00 constant DSIHOST1_VFP                   \ [0x00 : 10] VFP
  [then]


  [ifdef] DSIHOST1_DSI_VVACCR_DEF
    \
    \ @brief DSI Host video VA current configuration register
    \ Address offset: 0x160
    \ Reset value: 0x00000000
    \
    $00 constant DSIHOST1_VA                    \ [0x00 : 14] VA
  [then]


  [ifdef] DSIHOST1_DSI_WCFGR_DEF
    \
    \ @brief DSI wrapper configuration register
    \ Address offset: 0x400
    \ Reset value: 0x00000000
    \
    $00 constant DSIHOST1_DSIM                  \ [0x00] DSIM
    $01 constant DSIHOST1_COLMUX                \ [0x01 : 3] COLMUX
    $04 constant DSIHOST1_TESRC                 \ [0x04] TESRC
    $05 constant DSIHOST1_TEPOL                 \ [0x05] TEPOL
    $06 constant DSIHOST1_AR                    \ [0x06] AR
    $07 constant DSIHOST1_VSPOL                 \ [0x07] VSPOL
  [then]


  [ifdef] DSIHOST1_DSI_WCR_DEF
    \
    \ @brief DSI wrapper control register
    \ Address offset: 0x404
    \ Reset value: 0x00000000
    \
    $00 constant DSIHOST1_COLM                  \ [0x00] COLM
    $01 constant DSIHOST1_SHTDN                 \ [0x01] SHTDN
    $02 constant DSIHOST1_LTDCEN                \ [0x02] LTDCEN
    $03 constant DSIHOST1_DSIEN                 \ [0x03] DSIEN
  [then]


  [ifdef] DSIHOST1_DSI_WIER_DEF
    \
    \ @brief DSI wrapper interrupt enable register
    \ Address offset: 0x408
    \ Reset value: 0x00000000
    \
    $00 constant DSIHOST1_TEIE                  \ [0x00] TEIE
    $01 constant DSIHOST1_ERIE                  \ [0x01] ERIE
    $09 constant DSIHOST1_PLLLIE                \ [0x09] PLLLIE
    $0a constant DSIHOST1_PLLUIE                \ [0x0a] PLLUIE
    $0d constant DSIHOST1_RRIE                  \ [0x0d] RRIE
  [then]


  [ifdef] DSIHOST1_DSI_WISR_DEF
    \
    \ @brief DSI wrapper interrupt and status register
    \ Address offset: 0x40C
    \ Reset value: 0x00000000
    \
    $00 constant DSIHOST1_TEIF                  \ [0x00] TEIF
    $01 constant DSIHOST1_ERIF                  \ [0x01] ERIF
    $02 constant DSIHOST1_BUSY                  \ [0x02] BUSY
    $08 constant DSIHOST1_PLLLS                 \ [0x08] PLLLS
    $09 constant DSIHOST1_PLLLIF                \ [0x09] PLLLIF
    $0a constant DSIHOST1_PLLUIF                \ [0x0a] PLLUIF
    $0c constant DSIHOST1_RRS                   \ [0x0c] RRS
    $0d constant DSIHOST1_RRIF                  \ [0x0d] RRIF
  [then]


  [ifdef] DSIHOST1_DSI_WIFCR_DEF
    \
    \ @brief DSI wrapper interrupt flag clear register
    \ Address offset: 0x410
    \ Reset value: 0x00000000
    \
    $00 constant DSIHOST1_CTEIF                 \ [0x00] CTEIF
    $01 constant DSIHOST1_CERIF                 \ [0x01] CERIF
    $09 constant DSIHOST1_CPLLLIF               \ [0x09] CPLLLIF
    $0a constant DSIHOST1_CPLLUIF               \ [0x0a] CPLLUIF
    $0d constant DSIHOST1_CRRIF                 \ [0x0d] CRRIF
  [then]


  [ifdef] DSIHOST1_DSI_WPCR0_DEF
    \
    \ @brief DSI wrapper PHY configuration register 0
    \ Address offset: 0x418
    \ Reset value: 0x00000000
    \
    $00 constant DSIHOST1_UIX4                  \ [0x00 : 6] UIX4
    $06 constant DSIHOST1_SWCL                  \ [0x06] SWCL
    $07 constant DSIHOST1_SWDL0                 \ [0x07] SWDL0
    $08 constant DSIHOST1_SWDL1                 \ [0x08] SWDL1
    $09 constant DSIHOST1_HSICL                 \ [0x09] HSICL
    $0a constant DSIHOST1_HSIDL0                \ [0x0a] HSIDL0
    $0b constant DSIHOST1_HSIDL1                \ [0x0b] HSIDL1
    $0c constant DSIHOST1_FTXSMCL               \ [0x0c] FTXSMCL
    $0d constant DSIHOST1_FTXSMDL               \ [0x0d] FTXSMDL
    $0e constant DSIHOST1_CDOFFDL               \ [0x0e] CDOFFDL
    $10 constant DSIHOST1_TDDL                  \ [0x10] TDDL
  [then]


  [ifdef] DSIHOST1_DSI_WPCR1_DEF
    \
    \ @brief This register shall be programmed only when DSI is stopped (CR. DSIEN=0 and CR.EN = 0).
    \ Address offset: 0x41C
    \ Reset value: 0x00000000
    \
    $00 constant DSIHOST1_SKEWCL                \ [0x00 : 2] SKEWCL
    $02 constant DSIHOST1_SKEWDL                \ [0x02 : 2] SKEWDL
    $06 constant DSIHOST1_LPTXSRCL              \ [0x06 : 2] LPTXSRCL
    $08 constant DSIHOST1_LPTXSRDL              \ [0x08 : 2] LPTXSRDL
    $0c constant DSIHOST1_SDDCCL                \ [0x0c] SDDCCL
    $0d constant DSIHOST1_SDDCDL                \ [0x0d] SDDCDL
    $10 constant DSIHOST1_HSTXSRUCL             \ [0x10] HSTXSRUCL
    $11 constant DSIHOST1_HSTXSRDCL             \ [0x11] HSTXSRDCL
    $12 constant DSIHOST1_HSTXSRUDL             \ [0x12] HSTXSRUDL
    $13 constant DSIHOST1_HSTXSRDDL             \ [0x13] HSTXSRDDL
  [then]


  [ifdef] DSIHOST1_DSI_WRPCR_DEF
    \
    \ @brief DSI wrapper regulator and PLL control register
    \ Address offset: 0x430
    \ Reset value: 0x00000000
    \
    $00 constant DSIHOST1_PLLEN                 \ [0x00] PLLEN
    $02 constant DSIHOST1_NDIV                  \ [0x02 : 7] NDIV
    $0b constant DSIHOST1_IDF                   \ [0x0b : 4] IDF
    $10 constant DSIHOST1_ODF                   \ [0x10 : 2] ODF
    $18 constant DSIHOST1_REGEN                 \ [0x18] REGEN
    $1c constant DSIHOST1_BGREN                 \ [0x1c] BGREN
  [then]


  [ifdef] DSIHOST1_DSI_HWCFGR_DEF
    \
    \ @brief DSI Host hardware configuration register
    \ Address offset: 0x7F0
    \ Reset value: 0x00005A01
    \
    $00 constant DSIHOST1_TECHNO                \ [0x00 : 4] TECHNO
    $04 constant DSIHOST1_FIFOSIZE              \ [0x04 : 12] FIFOSIZE
  [then]


  [ifdef] DSIHOST1_DSI_VERR_DEF
    \
    \ @brief DSI Host version register
    \ Address offset: 0x7F4
    \ Reset value: 0x00000020
    \
    $00 constant DSIHOST1_MINREV                \ [0x00 : 4] MINREV
    $04 constant DSIHOST1_MAJREV                \ [0x04 : 4] MAJREV
  [then]


  [ifdef] DSIHOST1_DSI_IPIDR_DEF
    \
    \ @brief DSI Host identification register
    \ Address offset: 0x7F8
    \ Reset value: 0x00160071
    \
    $00 constant DSIHOST1_ID                    \ [0x00 : 32] ID
  [then]


  [ifdef] DSIHOST1_DSI_SIDR_DEF
    \
    \ @brief DSI Host size identification register
    \ Address offset: 0x7FC
    \ Reset value: 0xA3C5DD02
    \
    $00 constant DSIHOST1_SID                   \ [0x00 : 32] SID
  [then]

  \
  \ @brief DSIHOST1
  \
  $00 constant DSIHOST1_DSI_VR          \ DSI Host version register
  $04 constant DSIHOST1_DSI_CR          \ DSI Host control register
  $08 constant DSIHOST1_DSI_CCR         \ DSI Host clock control register
  $0C constant DSIHOST1_DSI_LVCIDR      \ DSI Host LTDC VCID register
  $10 constant DSIHOST1_DSI_LCOLCR      \ DSI Host LTDC color coding register
  $14 constant DSIHOST1_DSI_LPCR        \ DSI Host LTDC polarity configuration register
  $18 constant DSIHOST1_DSI_LPMCR       \ DSI Host low-power mode configuration register
  $2C constant DSIHOST1_DSI_PCR         \ DSI Host protocol configuration register
  $30 constant DSIHOST1_DSI_GVCIDR      \ DSI Host generic VCID register
  $34 constant DSIHOST1_DSI_MCR         \ DSI Host mode configuration register
  $38 constant DSIHOST1_DSI_VMCR        \ DSI Host video mode configuration register
  $3C constant DSIHOST1_DSI_VPCR        \ DSI Host video packet configuration register
  $40 constant DSIHOST1_DSI_VCCR        \ DSI Host video chunks configuration register
  $44 constant DSIHOST1_DSI_VNPCR       \ DSI Host video null packet configuration register
  $48 constant DSIHOST1_DSI_VHSACR      \ DSI Host video HSA configuration register
  $4C constant DSIHOST1_DSI_VHBPCR      \ DSI Host video HBP configuration register
  $50 constant DSIHOST1_DSI_VLCR        \ DSI Host video line configuration register
  $54 constant DSIHOST1_DSI_VVSACR      \ DSI Host video VSA configuration register
  $58 constant DSIHOST1_DSI_VVBPCR      \ DSI Host video VBP configuration register
  $5C constant DSIHOST1_DSI_VVFPCR      \ DSI Host video VFP configuration register
  $60 constant DSIHOST1_DSI_VVACR       \ DSI Host video VA configuration register
  $64 constant DSIHOST1_DSI_LCCR        \ DSI Host LTDC command configuration register
  $68 constant DSIHOST1_DSI_CMCR        \ DSI Host command mode configuration register
  $6C constant DSIHOST1_DSI_GHCR        \ DSI Host generic header configuration register
  $70 constant DSIHOST1_DSI_GPDR        \ DSI Host generic payload data register
  $74 constant DSIHOST1_DSI_GPSR        \ DSI Host generic packet status register
  $78 constant DSIHOST1_DSI_TCCR0       \ DSI Host timeout counter configuration register 0
  $7C constant DSIHOST1_DSI_TCCR1       \ DSI Host timeout counter configuration register 1
  $80 constant DSIHOST1_DSI_TCCR2       \ DSI Host timeout counter configuration register 2
  $84 constant DSIHOST1_DSI_TCCR3       \ DSI Host timeout counter configuration register 3
  $88 constant DSIHOST1_DSI_TCCR4       \ DSI Host timeout counter configuration register 4
  $8C constant DSIHOST1_DSI_TCCR5       \ DSI Host timeout counter configuration register 5
  $94 constant DSIHOST1_DSI_CLCR        \ DSI Host clock lane configuration register
  $98 constant DSIHOST1_DSI_CLTCR       \ DSI Host clock lane timer configuration register
  $9C constant DSIHOST1_DSI_DLTCR       \ DSI Host data lane timer configuration register
  $A0 constant DSIHOST1_DSI_PCTLR       \ DSI Host PHY control register
  $A4 constant DSIHOST1_DSI_PCONFR      \ DSI Host PHY configuration register
  $A8 constant DSIHOST1_DSI_PUCR        \ DSI Host PHY ULPS control register
  $AC constant DSIHOST1_DSI_PTTCR       \ DSI Host PHY TX triggers configuration register
  $B0 constant DSIHOST1_DSI_PSR         \ DSI Host PHY status register
  $BC constant DSIHOST1_DSI_ISR0        \ DSI Host interrupt and status register 0
  $C0 constant DSIHOST1_DSI_ISR1        \ DSI Host interrupt and status register 1
  $C4 constant DSIHOST1_DSI_IER0        \ DSI Host interrupt enable register 0
  $C8 constant DSIHOST1_DSI_IER1        \ DSI Host interrupt enable register 1
  $D8 constant DSIHOST1_DSI_FIR0        \ DSI Host force interrupt register 0
  $DC constant DSIHOST1_DSI_FIR1        \ DSI Host force interrupt register 1
  $F4 constant DSIHOST1_DSI_DLTRCR      \ DSI Host data lane timer read configuration register
  $100 constant DSIHOST1_DSI_VSCR       \ DSI Host video shadow control register
  $10C constant DSIHOST1_DSI_LCVCIDR    \ DSI Host LTDC current VCID register
  $110 constant DSIHOST1_DSI_LCCCR      \ DSI Host LTDC current color coding register
  $118 constant DSIHOST1_DSI_LPMCCR     \ DSI Host low-power mode current configuration register
  $138 constant DSIHOST1_DSI_VMCCR      \ DSI Host video mode current configuration register
  $13C constant DSIHOST1_DSI_VPCCR      \ DSI Host video packet current configuration register
  $140 constant DSIHOST1_DSI_VCCCR      \ DSI Host video chunks current configuration register
  $144 constant DSIHOST1_DSI_VNPCCR     \ DSI Host video null packet current configuration register
  $148 constant DSIHOST1_DSI_VHSACCR    \ DSI Host video HSA current configuration register
  $14C constant DSIHOST1_DSI_VHBPCCR    \ DSI Host video HBP current configuration register
  $150 constant DSIHOST1_DSI_VLCCR      \ DSI Host video line current configuration register
  $154 constant DSIHOST1_DSI_VVSACCR    \ DSI Host video VSA current configuration register
  $158 constant DSIHOST1_DSI_VVBPCCR    \ DSI Host video VBP current configuration register
  $15C constant DSIHOST1_DSI_VVFPCCR    \ DSI Host video VFP current configuration register
  $160 constant DSIHOST1_DSI_VVACCR     \ DSI Host video VA current configuration register
  $400 constant DSIHOST1_DSI_WCFGR      \ DSI wrapper configuration register
  $404 constant DSIHOST1_DSI_WCR        \ DSI wrapper control register
  $408 constant DSIHOST1_DSI_WIER       \ DSI wrapper interrupt enable register
  $40C constant DSIHOST1_DSI_WISR       \ DSI wrapper interrupt and status register
  $410 constant DSIHOST1_DSI_WIFCR      \ DSI wrapper interrupt flag clear register
  $418 constant DSIHOST1_DSI_WPCR0      \ DSI wrapper PHY configuration register 0
  $41C constant DSIHOST1_DSI_WPCR1      \ This register shall be programmed only when DSI is stopped (CR. DSIEN=0 and CR.EN = 0).
  $430 constant DSIHOST1_DSI_WRPCR      \ DSI wrapper regulator and PLL control register
  $7F0 constant DSIHOST1_DSI_HWCFGR     \ DSI Host hardware configuration register
  $7F4 constant DSIHOST1_DSI_VERR       \ DSI Host version register
  $7F8 constant DSIHOST1_DSI_IPIDR      \ DSI Host identification register
  $7FC constant DSIHOST1_DSI_SIDR       \ DSI Host size identification register

: DSIHOST1_DEF ; [then]
