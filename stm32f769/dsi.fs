\
\ @file dsi.fs
\ @brief DSI Host
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] DSI_DEF

  [ifdef] DSI_DSI_VR_DEF
    \
    \ @brief DSI Host Version Register
    \ Address offset: 0x00
    \ Reset value: 0x3133302A
    \
    $00 constant DSI_VERSION                    \ [0x00 : 32] Version of the DSI Host
  [then]


  [ifdef] DSI_DSI_CR_DEF
    \
    \ @brief DSI Host Control Register
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $00 constant DSI_EN                         \ [0x00] Enable
  [then]


  [ifdef] DSI_DSI_CCR_DEF
    \
    \ @brief DSI HOST Clock Control Register
    \ Address offset: 0x08
    \ Reset value: 0x00000000
    \
    $00 constant DSI_TXECKDIV                   \ [0x00 : 8] TX Escape Clock Division
    $08 constant DSI_TOCKDIV                    \ [0x08 : 8] Timeout Clock Division
  [then]


  [ifdef] DSI_DSI_LVCIDR_DEF
    \
    \ @brief DSI Host LTDC VCID Register
    \ Address offset: 0x0C
    \ Reset value: 0x00000000
    \
    $00 constant DSI_VCID                       \ [0x00 : 2] Virtual Channel ID
  [then]


  [ifdef] DSI_DSI_LCOLCR_DEF
    \
    \ @brief DSI Host LTDC Color Coding Register
    \ Address offset: 0x10
    \ Reset value: 0x00000000
    \
    $00 constant DSI_COLC                       \ [0x00 : 4] Color Coding
    $08 constant DSI_LPE                        \ [0x08] Loosely Packet Enable
  [then]


  [ifdef] DSI_DSI_LPCR_DEF
    \
    \ @brief DSI Host LTDC Polarity Configuration Register
    \ Address offset: 0x14
    \ Reset value: 0x00000000
    \
    $00 constant DSI_DEP                        \ [0x00] Data Enable Polarity
    $01 constant DSI_VSP                        \ [0x01] VSYNC Polarity
    $02 constant DSI_HSP                        \ [0x02] HSYNC Polarity
  [then]


  [ifdef] DSI_DSI_LPMCR_DEF
    \
    \ @brief DSI Host Low-Power mode Configuration Register
    \ Address offset: 0x18
    \ Reset value: 0x00000000
    \
    $00 constant DSI_VLPSIZE                    \ [0x00 : 8] VACT Largest Packet Size
    $10 constant DSI_LPSIZE                     \ [0x10 : 8] Largest Packet Size
  [then]


  [ifdef] DSI_DSI_PCR_DEF
    \
    \ @brief DSI Host Protocol Configuration Register
    \ Address offset: 0x2C
    \ Reset value: 0x00000000
    \
    $00 constant DSI_ETTXE                      \ [0x00] EoTp Transmission Enable
    $01 constant DSI_ETRXE                      \ [0x01] EoTp Reception Enable
    $02 constant DSI_BTAE                       \ [0x02] Bus Turn Around Enable
    $03 constant DSI_ECCRXE                     \ [0x03] ECC Reception Enable
    $04 constant DSI_CRCRXE                     \ [0x04] CRC Reception Enable
  [then]


  [ifdef] DSI_DSI_GVCIDR_DEF
    \
    \ @brief DSI Host Generic VCID Register
    \ Address offset: 0x30
    \ Reset value: 0x00000000
    \
    $00 constant DSI_VCID                       \ [0x00 : 2] Virtual Channel ID
  [then]


  [ifdef] DSI_DSI_MCR_DEF
    \
    \ @brief DSI Host mode Configuration Register
    \ Address offset: 0x34
    \ Reset value: 0x00000000
    \
    $00 constant DSI_CMDM                       \ [0x00] Command mode
  [then]


  [ifdef] DSI_DSI_VMCR_DEF
    \
    \ @brief DSI Host Video mode Configuration Register
    \ Address offset: 0x38
    \ Reset value: 0x00000000
    \
    $00 constant DSI_VMT                        \ [0x00 : 2] Video mode Type
    $08 constant DSI_LPVSAE                     \ [0x08] Low-Power Vertical Sync Active Enable
    $09 constant DSI_LPVBPE                     \ [0x09] Low-power Vertical Back-Porch Enable
    $0a constant DSI_LPVFPE                     \ [0x0a] Low-power Vertical Front-porch Enable
    $0b constant DSI_LPVAE                      \ [0x0b] Low-Power Vertical Active Enable
    $0c constant DSI_LPHBPE                     \ [0x0c] Low-Power Horizontal Back-Porch Enable
    $0d constant DSI_LPHFPE                     \ [0x0d] Low-Power Horizontal Front-Porch Enable
    $0e constant DSI_FBTAAE                     \ [0x0e] Frame Bus-Turn-Around Acknowledge Enable
    $0f constant DSI_LPCE                       \ [0x0f] Low-Power Command Enable
    $10 constant DSI_PGE                        \ [0x10] Pattern Generator Enable
    $14 constant DSI_PGM                        \ [0x14] Pattern Generator mode
    $18 constant DSI_PGO                        \ [0x18] Pattern Generator Orientation
  [then]


  [ifdef] DSI_DSI_VPCR_DEF
    \
    \ @brief DSI Host Video Packet Configuration Register
    \ Address offset: 0x3C
    \ Reset value: 0x00000000
    \
    $00 constant DSI_VPSIZE                     \ [0x00 : 14] Video Packet Size
  [then]


  [ifdef] DSI_DSI_VCCR_DEF
    \
    \ @brief DSI Host Video Chunks Configuration Register
    \ Address offset: 0x40
    \ Reset value: 0x00000000
    \
    $00 constant DSI_NUMC                       \ [0x00 : 13] Number of Chunks
  [then]


  [ifdef] DSI_DSI_VNPCR_DEF
    \
    \ @brief DSI Host Video Null Packet Configuration Register
    \ Address offset: 0x44
    \ Reset value: 0x00000000
    \
    $00 constant DSI_NPSIZE                     \ [0x00 : 13] Null Packet Size
  [then]


  [ifdef] DSI_DSI_VHSACR_DEF
    \
    \ @brief DSI Host Video HSA Configuration Register
    \ Address offset: 0x48
    \ Reset value: 0x00000000
    \
    $00 constant DSI_HSA                        \ [0x00 : 12] Horizontal Synchronism Active duration
  [then]


  [ifdef] DSI_DSI_VHBPCR_DEF
    \
    \ @brief DSI Host Video HBP Configuration Register
    \ Address offset: 0x4C
    \ Reset value: 0x00000000
    \
    $00 constant DSI_HBP                        \ [0x00 : 12] Horizontal Back-Porch duration
  [then]


  [ifdef] DSI_DSI_VLCR_DEF
    \
    \ @brief DSI Host Video Line Configuration Register
    \ Address offset: 0x50
    \ Reset value: 0x00000000
    \
    $00 constant DSI_HLINE                      \ [0x00 : 15] Horizontal Line duration
  [then]


  [ifdef] DSI_DSI_VVSACR_DEF
    \
    \ @brief DSI Host Video VSA Configuration Register
    \ Address offset: 0x54
    \ Reset value: 0x00000000
    \
    $00 constant DSI_VSA                        \ [0x00 : 10] Vertical Synchronism Active duration
  [then]


  [ifdef] DSI_DSI_VVBPCR_DEF
    \
    \ @brief DSI Host Video VBP Configuration Register
    \ Address offset: 0x58
    \ Reset value: 0x00000000
    \
    $00 constant DSI_VBP                        \ [0x00 : 10] Vertical Back-Porch duration
  [then]


  [ifdef] DSI_DSI_VVFPCR_DEF
    \
    \ @brief DSI Host Video VFP Configuration Register
    \ Address offset: 0x5C
    \ Reset value: 0x00000000
    \
    $00 constant DSI_VFP                        \ [0x00 : 10] Vertical Front-Porch duration
  [then]


  [ifdef] DSI_DSI_VVACR_DEF
    \
    \ @brief DSI Host Video VA Configuration Register
    \ Address offset: 0x60
    \ Reset value: 0x00000000
    \
    $00 constant DSI_VA                         \ [0x00 : 14] Vertical Active duration
  [then]


  [ifdef] DSI_DSI_LCCR_DEF
    \
    \ @brief DSI Host LTDC Command Configuration Register
    \ Address offset: 0x64
    \ Reset value: 0x00000000
    \
    $00 constant DSI_CMDSIZE                    \ [0x00 : 16] Command Size
  [then]


  [ifdef] DSI_DSI_CMCR_DEF
    \
    \ @brief DSI Host Command mode Configuration Register
    \ Address offset: 0x68
    \ Reset value: 0x00000000
    \
    $00 constant DSI_TEARE                      \ [0x00] Tearing Effect Acknowledge Request Enable
    $01 constant DSI_ARE                        \ [0x01] Acknowledge Request Enable
    $08 constant DSI_GSW0TX                     \ [0x08] Generic Short Write Zero parameters Transmission
    $09 constant DSI_GSW1TX                     \ [0x09] Generic Short Write One parameters Transmission
    $0a constant DSI_GSW2TX                     \ [0x0a] Generic Short Write Two parameters Transmission
    $0b constant DSI_GSR0TX                     \ [0x0b] Generic Short Read Zero parameters Transmission
    $0c constant DSI_GSR1TX                     \ [0x0c] Generic Short Read One parameters Transmission
    $0d constant DSI_GSR2TX                     \ [0x0d] Generic Short Read Two parameters Transmission
    $0e constant DSI_GLWTX                      \ [0x0e] Generic Long Write Transmission
    $10 constant DSI_DSW0TX                     \ [0x10] DCS Short Write Zero parameter Transmission
    $11 constant DSI_DSW1TX                     \ [0x11] DCS Short Read One parameter Transmission
    $12 constant DSI_DSR0TX                     \ [0x12] DCS Short Read Zero parameter Transmission
    $13 constant DSI_DLWTX                      \ [0x13] DCS Long Write Transmission
    $18 constant DSI_MRDPS                      \ [0x18] Maximum Read Packet Size
  [then]


  [ifdef] DSI_DSI_GHCR_DEF
    \
    \ @brief DSI Host Generic Header Configuration Register
    \ Address offset: 0x6C
    \ Reset value: 0x00000000
    \
    $00 constant DSI_DT                         \ [0x00 : 6] Type
    $06 constant DSI_VCID                       \ [0x06 : 2] Channel
    $08 constant DSI_WCLSB                      \ [0x08 : 8] WordCount LSB
    $10 constant DSI_WCMSB                      \ [0x10 : 8] WordCount MSB
  [then]


  [ifdef] DSI_DSI_GPDR_DEF
    \
    \ @brief DSI Host Generic Payload Data Register
    \ Address offset: 0x70
    \ Reset value: 0x00000000
    \
    $00 constant DSI_DATA1                      \ [0x00 : 8] Payload Byte 1
    $08 constant DSI_DATA2                      \ [0x08 : 8] Payload Byte 2
    $10 constant DSI_DATA3                      \ [0x10 : 8] Payload Byte 3
    $18 constant DSI_DATA4                      \ [0x18 : 8] Payload Byte 4
  [then]


  [ifdef] DSI_DSI_GPSR_DEF
    \
    \ @brief DSI Host Generic Packet Status Register
    \ Address offset: 0x74
    \ Reset value: 0x00000000
    \
    $00 constant DSI_CMDFE                      \ [0x00] Command FIFO Empty
    $01 constant DSI_CMDFF                      \ [0x01] Command FIFO Full
    $02 constant DSI_PWRFE                      \ [0x02] Payload Write FIFO Empty
    $03 constant DSI_PWRFF                      \ [0x03] Payload Write FIFO Full
    $04 constant DSI_PRDFE                      \ [0x04] Payload Read FIFO Empty
    $05 constant DSI_PRDFF                      \ [0x05] Payload Read FIFO Full
    $06 constant DSI_RCB                        \ [0x06] Read Command Busy
  [then]


  [ifdef] DSI_DSI_TCCR0_DEF
    \
    \ @brief DSI Host Timeout Counter Configuration Register 0
    \ Address offset: 0x78
    \ Reset value: 0x00000000
    \
    $00 constant DSI_LPRX_TOCNT                 \ [0x00 : 16] Low-power Reception Timeout Counter
    $10 constant DSI_HSTX_TOCNT                 \ [0x10 : 16] High-Speed Transmission Timeout Counter
  [then]


  [ifdef] DSI_DSI_TCCR1_DEF
    \
    \ @brief DSI Host Timeout Counter Configuration Register 1
    \ Address offset: 0x7C
    \ Reset value: 0x00000000
    \
    $00 constant DSI_HSRD_TOCNT                 \ [0x00 : 16] High-Speed Read Timeout Counter
  [then]


  [ifdef] DSI_DSI_TCCR2_DEF
    \
    \ @brief DSI Host Timeout Counter Configuration Register 2
    \ Address offset: 0x80
    \ Reset value: 0x00000000
    \
    $00 constant DSI_LPRD_TOCNT                 \ [0x00 : 16] Low-Power Read Timeout Counter
  [then]


  [ifdef] DSI_DSI_TCCR3_DEF
    \
    \ @brief DSI Host Timeout Counter Configuration Register 3
    \ Address offset: 0x84
    \ Reset value: 0x00000000
    \
    $00 constant DSI_HSWR_TOCNT                 \ [0x00 : 16] High-Speed Write Timeout Counter
    $18 constant DSI_PM                         \ [0x18] Presp mode
  [then]


  [ifdef] DSI_DSI_TCCR4_DEF
    \
    \ @brief DSI Host Timeout Counter Configuration Register 4
    \ Address offset: 0x88
    \ Reset value: 0x00000000
    \
    $00 constant DSI_LSWR_TOCNT                 \ [0x00 : 16] Low-Power Write Timeout Counter
  [then]


  [ifdef] DSI_DSI_TCCR5_DEF
    \
    \ @brief DSI Host Timeout Counter Configuration Register 5
    \ Address offset: 0x8C
    \ Reset value: 0x00000000
    \
    $00 constant DSI_BTA_TOCNT                  \ [0x00 : 16] Bus-Turn-Around Timeout Counter
  [then]


  [ifdef] DSI_DSI_CLCR_DEF
    \
    \ @brief DSI Host Clock Lane Configuration Register
    \ Address offset: 0x94
    \ Reset value: 0x00000000
    \
    $00 constant DSI_DPCC                       \ [0x00] D-PHY Clock Control
    $01 constant DSI_ACR                        \ [0x01] Automatic Clock lane Control
  [then]


  [ifdef] DSI_DSI_CLTCR_DEF
    \
    \ @brief DSI Host Clock Lane Timer Configuration Register
    \ Address offset: 0x98
    \ Reset value: 0x00000000
    \
    $00 constant DSI_LP2HS_TIME                 \ [0x00 : 10] Low-Power to High-Speed Time
    $10 constant DSI_HS2LP_TIME                 \ [0x10 : 10] High-Speed to Low-Power Time
  [then]


  [ifdef] DSI_DSI_DLTCR_DEF
    \
    \ @brief DSI Host Data Lane Timer Configuration Register
    \ Address offset: 0x9C
    \ Reset value: 0x00000000
    \
    $00 constant DSI_MRD_TIME                   \ [0x00 : 15] Maximum Read Time
    $10 constant DSI_LP2HS_TIME                 \ [0x10 : 8] Low-Power To High-Speed Time
    $18 constant DSI_HS2LP_TIME                 \ [0x18 : 8] High-Speed To Low-Power Time
  [then]


  [ifdef] DSI_DSI_PCTLR_DEF
    \
    \ @brief DSI Host PHY Control Register
    \ Address offset: 0xA0
    \ Reset value: 0x00000000
    \
    $01 constant DSI_DEN                        \ [0x01] Digital Enable
    $02 constant DSI_CKE                        \ [0x02] Clock Enable
  [then]


  [ifdef] DSI_DSI_PCONFR_DEF
    \
    \ @brief DSI Host PHY Configuration Register
    \ Address offset: 0xA4
    \ Reset value: 0x00000000
    \
    $00 constant DSI_NL                         \ [0x00 : 2] Number of Lanes
    $08 constant DSI_SW_TIME                    \ [0x08 : 8] Stop Wait Time
  [then]


  [ifdef] DSI_DSI_PUCR_DEF
    \
    \ @brief DSI Host PHY ULPS Control Register
    \ Address offset: 0xA8
    \ Reset value: 0x00000000
    \
    $00 constant DSI_URCL                       \ [0x00] ULPS Request on Clock Lane
    $01 constant DSI_UECL                       \ [0x01] ULPS Exit on Clock Lane
    $02 constant DSI_URDL                       \ [0x02] ULPS Request on Data Lane
    $03 constant DSI_UEDL                       \ [0x03] ULPS Exit on Data Lane
  [then]


  [ifdef] DSI_DSI_PTTCR_DEF
    \
    \ @brief DSI Host PHY TX Triggers Configuration Register
    \ Address offset: 0xAC
    \ Reset value: 0x00000000
    \
    $00 constant DSI_TX_TRIG                    \ [0x00 : 4] Transmission Trigger
  [then]


  [ifdef] DSI_DSI_PSR_DEF
    \
    \ @brief DSI Host PHY Status Register
    \ Address offset: 0xB0
    \ Reset value: 0x00000000
    \
    $01 constant DSI_PD                         \ [0x01] PHY Direction
    $02 constant DSI_PSSC                       \ [0x02] PHY Stop State Clock lane
    $03 constant DSI_UANC                       \ [0x03] ULPS Active Not Clock lane
    $04 constant DSI_PSS0                       \ [0x04] PHY Stop State lane 0
    $05 constant DSI_UAN0                       \ [0x05] ULPS Active Not lane 1
    $06 constant DSI_RUE0                       \ [0x06] RX ULPS Escape lane 0
    $07 constant DSI_PSS1                       \ [0x07] PHY Stop State lane 1
    $08 constant DSI_UAN1                       \ [0x08] ULPS Active Not lane 1
  [then]


  [ifdef] DSI_DSI_ISR0_DEF
    \
    \ @brief DSI Host Interrupt & Status Register 0
    \ Address offset: 0xBC
    \ Reset value: 0x00000000
    \
    $00 constant DSI_AE0                        \ [0x00] Acknowledge Error 0
    $01 constant DSI_AE1                        \ [0x01] Acknowledge Error 1
    $02 constant DSI_AE2                        \ [0x02] Acknowledge Error 2
    $03 constant DSI_AE3                        \ [0x03] Acknowledge Error 3
    $04 constant DSI_AE4                        \ [0x04] Acknowledge Error 4
    $05 constant DSI_AE5                        \ [0x05] Acknowledge Error 5
    $06 constant DSI_AE6                        \ [0x06] Acknowledge Error 6
    $07 constant DSI_AE7                        \ [0x07] Acknowledge Error 7
    $08 constant DSI_AE8                        \ [0x08] Acknowledge Error 8
    $09 constant DSI_AE9                        \ [0x09] Acknowledge Error 9
    $0a constant DSI_AE10                       \ [0x0a] Acknowledge Error 10
    $0b constant DSI_AE11                       \ [0x0b] Acknowledge Error 11
    $0c constant DSI_AE12                       \ [0x0c] Acknowledge Error 12
    $0d constant DSI_AE13                       \ [0x0d] Acknowledge Error 13
    $0e constant DSI_AE14                       \ [0x0e] Acknowledge Error 14
    $0f constant DSI_AE15                       \ [0x0f] Acknowledge Error 15
    $10 constant DSI_PE0                        \ [0x10] PHY Error 0
    $11 constant DSI_PE1                        \ [0x11] PHY Error 1
    $12 constant DSI_PE2                        \ [0x12] PHY Error 2
    $13 constant DSI_PE3                        \ [0x13] PHY Error 3
    $14 constant DSI_PE4                        \ [0x14] PHY Error 4
  [then]


  [ifdef] DSI_DSI_ISR1_DEF
    \
    \ @brief DSI Host Interrupt & Status Register 1
    \ Address offset: 0xC0
    \ Reset value: 0x00000000
    \
    $00 constant DSI_TOHSTX                     \ [0x00] Timeout High-Speed Transmission
    $01 constant DSI_TOLPRX                     \ [0x01] Timeout Low-Power Reception
    $02 constant DSI_ECCSE                      \ [0x02] ECC Single-bit Error
    $03 constant DSI_ECCME                      \ [0x03] ECC Multi-bit Error
    $04 constant DSI_CRCE                       \ [0x04] CRC Error
    $05 constant DSI_PSE                        \ [0x05] Packet Size Error
    $06 constant DSI_EOTPE                      \ [0x06] EoTp Error
    $07 constant DSI_LPWRE                      \ [0x07] LTDC Payload Write Error
    $08 constant DSI_GCWRE                      \ [0x08] Generic Command Write Error
    $09 constant DSI_GPWRE                      \ [0x09] Generic Payload Write Error
    $0a constant DSI_GPTXE                      \ [0x0a] Generic Payload Transmit Error
    $0b constant DSI_GPRDE                      \ [0x0b] Generic Payload Read Error
    $0c constant DSI_GPRXE                      \ [0x0c] Generic Payload Receive Error
  [then]


  [ifdef] DSI_DSI_IER0_DEF
    \
    \ @brief DSI Host Interrupt Enable Register 0
    \ Address offset: 0xC4
    \ Reset value: 0x00000000
    \
    $00 constant DSI_AE0IE                      \ [0x00] Acknowledge Error 0 Interrupt Enable
    $01 constant DSI_AE1IE                      \ [0x01] Acknowledge Error 1 Interrupt Enable
    $02 constant DSI_AE2IE                      \ [0x02] Acknowledge Error 2 Interrupt Enable
    $03 constant DSI_AE3IE                      \ [0x03] Acknowledge Error 3 Interrupt Enable
    $04 constant DSI_AE4IE                      \ [0x04] Acknowledge Error 4 Interrupt Enable
    $05 constant DSI_AE5IE                      \ [0x05] Acknowledge Error 5 Interrupt Enable
    $06 constant DSI_AE6IE                      \ [0x06] Acknowledge Error 6 Interrupt Enable
    $07 constant DSI_AE7IE                      \ [0x07] Acknowledge Error 7 Interrupt Enable
    $08 constant DSI_AE8IE                      \ [0x08] Acknowledge Error 8 Interrupt Enable
    $09 constant DSI_AE9IE                      \ [0x09] Acknowledge Error 9 Interrupt Enable
    $0a constant DSI_AE10IE                     \ [0x0a] Acknowledge Error 10 Interrupt Enable
    $0b constant DSI_AE11IE                     \ [0x0b] Acknowledge Error 11 Interrupt Enable
    $0c constant DSI_AE12IE                     \ [0x0c] Acknowledge Error 12 Interrupt Enable
    $0d constant DSI_AE13IE                     \ [0x0d] Acknowledge Error 13 Interrupt Enable
    $0e constant DSI_AE14IE                     \ [0x0e] Acknowledge Error 14 Interrupt Enable
    $0f constant DSI_AE15IE                     \ [0x0f] Acknowledge Error 15 Interrupt Enable
    $10 constant DSI_PE0IE                      \ [0x10] PHY Error 0 Interrupt Enable
    $11 constant DSI_PE1IE                      \ [0x11] PHY Error 1 Interrupt Enable
    $12 constant DSI_PE2IE                      \ [0x12] PHY Error 2 Interrupt Enable
    $13 constant DSI_PE3IE                      \ [0x13] PHY Error 3 Interrupt Enable
    $14 constant DSI_PE4IE                      \ [0x14] PHY Error 4 Interrupt Enable
  [then]


  [ifdef] DSI_DSI_IER1_DEF
    \
    \ @brief DSI Host Interrupt Enable Register 1
    \ Address offset: 0xC8
    \ Reset value: 0x00000000
    \
    $00 constant DSI_TOHSTXIE                   \ [0x00] Timeout High-Speed Transmission Interrupt Enable
    $01 constant DSI_TOLPRXIE                   \ [0x01] Timeout Low-Power Reception Interrupt Enable
    $02 constant DSI_ECCSEIE                    \ [0x02] ECC Single-bit Error Interrupt Enable
    $03 constant DSI_ECCMEIE                    \ [0x03] ECC Multi-bit Error Interrupt Enable
    $04 constant DSI_CRCEIE                     \ [0x04] CRC Error Interrupt Enable
    $05 constant DSI_PSEIE                      \ [0x05] Packet Size Error Interrupt Enable
    $06 constant DSI_EOTPEIE                    \ [0x06] EoTp Error Interrupt Enable
    $07 constant DSI_LPWREIE                    \ [0x07] LTDC Payload Write Error Interrupt Enable
    $08 constant DSI_GCWREIE                    \ [0x08] Generic Command Write Error Interrupt Enable
    $09 constant DSI_GPWREIE                    \ [0x09] Generic Payload Write Error Interrupt Enable
    $0a constant DSI_GPTXEIE                    \ [0x0a] Generic Payload Transmit Error Interrupt Enable
    $0b constant DSI_GPRDEIE                    \ [0x0b] Generic Payload Read Error Interrupt Enable
    $0c constant DSI_GPRXEIE                    \ [0x0c] Generic Payload Receive Error Interrupt Enable
  [then]


  [ifdef] DSI_DSI_FIR0_DEF
    \
    \ @brief DSI Host Force Interrupt Register 0
    \ Address offset: 0xD8
    \ Reset value: 0x00000000
    \
    $00 constant DSI_FAE0                       \ [0x00] Force Acknowledge Error 0
    $01 constant DSI_FAE1                       \ [0x01] Force Acknowledge Error 1
    $02 constant DSI_FAE2                       \ [0x02] Force Acknowledge Error 2
    $03 constant DSI_FAE3                       \ [0x03] Force Acknowledge Error 3
    $04 constant DSI_FAE4                       \ [0x04] Force Acknowledge Error 4
    $05 constant DSI_FAE5                       \ [0x05] Force Acknowledge Error 5
    $06 constant DSI_FAE6                       \ [0x06] Force Acknowledge Error 6
    $07 constant DSI_FAE7                       \ [0x07] Force Acknowledge Error 7
    $08 constant DSI_FAE8                       \ [0x08] Force Acknowledge Error 8
    $09 constant DSI_FAE9                       \ [0x09] Force Acknowledge Error 9
    $0a constant DSI_FAE10                      \ [0x0a] Force Acknowledge Error 10
    $0b constant DSI_FAE11                      \ [0x0b] Force Acknowledge Error 11
    $0c constant DSI_FAE12                      \ [0x0c] Force Acknowledge Error 12
    $0d constant DSI_FAE13                      \ [0x0d] Force Acknowledge Error 13
    $0e constant DSI_FAE14                      \ [0x0e] Force Acknowledge Error 14
    $0f constant DSI_FAE15                      \ [0x0f] Force Acknowledge Error 15
    $10 constant DSI_FPE0                       \ [0x10] Force PHY Error 0
    $11 constant DSI_FPE1                       \ [0x11] Force PHY Error 1
    $12 constant DSI_FPE2                       \ [0x12] Force PHY Error 2
    $13 constant DSI_FPE3                       \ [0x13] Force PHY Error 3
    $14 constant DSI_FPE4                       \ [0x14] Force PHY Error 4
  [then]


  [ifdef] DSI_DSI_FIR1_DEF
    \
    \ @brief DSI Host Force Interrupt Register 1
    \ Address offset: 0xDC
    \ Reset value: 0x00000000
    \
    $00 constant DSI_FTOHSTX                    \ [0x00] Force Timeout High-Speed Transmission
    $01 constant DSI_FTOLPRX                    \ [0x01] Force Timeout Low-Power Reception
    $02 constant DSI_FECCSE                     \ [0x02] Force ECC Single-bit Error
    $03 constant DSI_FECCME                     \ [0x03] Force ECC Multi-bit Error
    $04 constant DSI_FCRCE                      \ [0x04] Force CRC Error
    $05 constant DSI_FPSE                       \ [0x05] Force Packet Size Error
    $06 constant DSI_FEOTPE                     \ [0x06] Force EoTp Error
    $07 constant DSI_FLPWRE                     \ [0x07] Force LTDC Payload Write Error
    $08 constant DSI_FGCWRE                     \ [0x08] Force Generic Command Write Error
    $09 constant DSI_FGPWRE                     \ [0x09] Force Generic Payload Write Error
    $0a constant DSI_FGPTXE                     \ [0x0a] Force Generic Payload Transmit Error
    $0b constant DSI_FGPRDE                     \ [0x0b] Force Generic Payload Read Error
    $0c constant DSI_FGPRXE                     \ [0x0c] Force Generic Payload Receive Error
  [then]


  [ifdef] DSI_DSI_VSCR_DEF
    \
    \ @brief DSI Host Video Shadow Control Register
    \ Address offset: 0x100
    \ Reset value: 0x00000000
    \
    $00 constant DSI_EN                         \ [0x00] Enable
    $08 constant DSI_UR                         \ [0x08] Update Register
  [then]


  [ifdef] DSI_DSI_LCVCIDR_DEF
    \
    \ @brief DSI Host LTDC Current VCID Register
    \ Address offset: 0x10C
    \ Reset value: 0x00000000
    \
    $00 constant DSI_VCID                       \ [0x00 : 2] Virtual Channel ID
  [then]


  [ifdef] DSI_DSI_LCCCR_DEF
    \
    \ @brief DSI Host LTDC Current Color Coding Register
    \ Address offset: 0x110
    \ Reset value: 0x00000000
    \
    $00 constant DSI_COLC                       \ [0x00 : 4] Color Coding
    $08 constant DSI_LPE                        \ [0x08] Loosely Packed Enable
  [then]


  [ifdef] DSI_DSI_LPMCCR_DEF
    \
    \ @brief DSI Host Low-Power mode Current Configuration Register
    \ Address offset: 0x118
    \ Reset value: 0x00000000
    \
    $00 constant DSI_VLPSIZE                    \ [0x00 : 8] VACT Largest Packet Size
    $10 constant DSI_LPSIZE                     \ [0x10 : 8] Largest Packet Size
  [then]


  [ifdef] DSI_DSI_VMCCR_DEF
    \
    \ @brief DSI Host Video mode Current Configuration Register
    \ Address offset: 0x138
    \ Reset value: 0x00000000
    \
    $00 constant DSI_VMT                        \ [0x00 : 2] Video mode Type
    $02 constant DSI_LPVSAE                     \ [0x02] Low-Power Vertical Sync time Enable
    $03 constant DSI_LPVBPE                     \ [0x03] Low-power Vertical Back-Porch Enable
    $04 constant DSI_LPVFPE                     \ [0x04] Low-power Vertical Front-Porch Enable
    $05 constant DSI_LPVAE                      \ [0x05] Low-Power Vertical Active Enable
    $06 constant DSI_LPHBPE                     \ [0x06] Low-power Horizontal Back-Porch Enable
    $07 constant DSI_LPHFE                      \ [0x07] Low-Power Horizontal Front-Porch Enable
    $08 constant DSI_FBTAAE                     \ [0x08] Frame BTA Acknowledge Enable
    $09 constant DSI_LPCE                       \ [0x09] Low-Power Command Enable
  [then]


  [ifdef] DSI_DSI_VPCCR_DEF
    \
    \ @brief DSI Host Video Packet Current Configuration Register
    \ Address offset: 0x13C
    \ Reset value: 0x00000000
    \
    $00 constant DSI_VPSIZE                     \ [0x00 : 14] Video Packet Size
  [then]


  [ifdef] DSI_DSI_VCCCR_DEF
    \
    \ @brief DSI Host Video Chunks Current Configuration Register
    \ Address offset: 0x140
    \ Reset value: 0x00000000
    \
    $00 constant DSI_NUMC                       \ [0x00 : 13] Number of Chunks
  [then]


  [ifdef] DSI_DSI_VNPCCR_DEF
    \
    \ @brief DSI Host Video Null Packet Current Configuration Register
    \ Address offset: 0x144
    \ Reset value: 0x00000000
    \
    $00 constant DSI_NPSIZE                     \ [0x00 : 13] Null Packet Size
  [then]


  [ifdef] DSI_DSI_VHSACCR_DEF
    \
    \ @brief DSI Host Video HSA Current Configuration Register
    \ Address offset: 0x148
    \ Reset value: 0x00000000
    \
    $00 constant DSI_HSA                        \ [0x00 : 12] Horizontal Synchronism Active duration
  [then]


  [ifdef] DSI_DSI_VHBPCCR_DEF
    \
    \ @brief DSI Host Video HBP Current Configuration Register
    \ Address offset: 0x14C
    \ Reset value: 0x00000000
    \
    $00 constant DSI_HBP                        \ [0x00 : 12] Horizontal Back-Porch duration
  [then]


  [ifdef] DSI_DSI_VLCCR_DEF
    \
    \ @brief DSI Host Video Line Current Configuration Register
    \ Address offset: 0x150
    \ Reset value: 0x00000000
    \
    $00 constant DSI_HLINE                      \ [0x00 : 15] Horizontal Line duration
  [then]


  [ifdef] DSI_DSI_VVSACCR_DEF
    \
    \ @brief DSI Host Video VSA Current Configuration Register
    \ Address offset: 0x154
    \ Reset value: 0x00000000
    \
    $00 constant DSI_VSA                        \ [0x00 : 10] Vertical Synchronism Active duration
  [then]


  [ifdef] DSI_DSI_VVBPCCR_DEF
    \
    \ @brief DSI Host Video VBP Current Configuration Register
    \ Address offset: 0x158
    \ Reset value: 0x00000000
    \
    $00 constant DSI_VBP                        \ [0x00 : 10] Vertical Back-Porch duration
  [then]


  [ifdef] DSI_DSI_VVFPCCR_DEF
    \
    \ @brief DSI Host Video VFP Current Configuration Register
    \ Address offset: 0x15C
    \ Reset value: 0x00000000
    \
    $00 constant DSI_VFP                        \ [0x00 : 10] Vertical Front-Porch duration
  [then]


  [ifdef] DSI_DSI_VVACCR_DEF
    \
    \ @brief DSI Host Video VA Current Configuration Register
    \ Address offset: 0x160
    \ Reset value: 0x00000000
    \
    $00 constant DSI_VA                         \ [0x00 : 14] Vertical Active duration
  [then]


  [ifdef] DSI_DSI_WCFGR_DEF
    \
    \ @brief DSI Wrapper Configuration Register
    \ Address offset: 0x400
    \ Reset value: 0x00000000
    \
    $00 constant DSI_DSIM                       \ [0x00] DSI Mode
    $01 constant DSI_COLMUX                     \ [0x01 : 3] Color Multiplexing
    $04 constant DSI_TESRC                      \ [0x04] TE Source
    $05 constant DSI_TEPOL                      \ [0x05] TE Polarity
    $06 constant DSI_AR                         \ [0x06] Automatic Refresh
    $07 constant DSI_VSPOL                      \ [0x07] VSync Polarity
  [then]


  [ifdef] DSI_DSI_WCR_DEF
    \
    \ @brief DSI Wrapper Control Register
    \ Address offset: 0x404
    \ Reset value: 0x00000000
    \
    $00 constant DSI_COLM                       \ [0x00] Color Mode
    $01 constant DSI_SHTDN                      \ [0x01] Shutdown
    $02 constant DSI_LTDCEN                     \ [0x02] LTDC Enable
    $03 constant DSI_DSIEN                      \ [0x03] DSI Enable
  [then]


  [ifdef] DSI_DSI_WIER_DEF
    \
    \ @brief DSI Wrapper Interrupt Enable Register
    \ Address offset: 0x408
    \ Reset value: 0x00000000
    \
    $00 constant DSI_TEIE                       \ [0x00] Tearing Effect Interrupt Enable
    $01 constant DSI_ERIE                       \ [0x01] End of Refresh Interrupt Enable
    $09 constant DSI_PLLLIE                     \ [0x09] PLL Lock Interrupt Enable
    $0a constant DSI_PLLUIE                     \ [0x0a] PLL Unlock Interrupt Enable
    $0d constant DSI_RRIE                       \ [0x0d] Regulator Ready Interrupt Enable
  [then]


  [ifdef] DSI_DSI_WISR_DEF
    \
    \ @brief DSI Wrapper Interrupt & Status Register
    \ Address offset: 0x40C
    \ Reset value: 0x00000000
    \
    $00 constant DSI_TEIF                       \ [0x00] Tearing Effect Interrupt Flag
    $01 constant DSI_ERIF                       \ [0x01] End of Refresh Interrupt Flag
    $02 constant DSI_BUSY                       \ [0x02] Busy Flag
    $08 constant DSI_PLLLS                      \ [0x08] PLL Lock Status
    $09 constant DSI_PLLLIF                     \ [0x09] PLL Lock Interrupt Flag
    $0a constant DSI_PLLUIF                     \ [0x0a] PLL Unlock Interrupt Flag
    $0c constant DSI_RRS                        \ [0x0c] Regulator Ready Status
    $0d constant DSI_RRIF                       \ [0x0d] Regulator Ready Interrupt Flag
  [then]


  [ifdef] DSI_DSI_WIFCR_DEF
    \
    \ @brief DSI Wrapper Interrupt Flag Clear Register
    \ Address offset: 0x410
    \ Reset value: 0x00000000
    \
    $00 constant DSI_CTEIF                      \ [0x00] Clear Tearing Effect Interrupt Flag
    $01 constant DSI_CERIF                      \ [0x01] Clear End of Refresh Interrupt Flag
    $09 constant DSI_CPLLLIF                    \ [0x09] Clear PLL Lock Interrupt Flag
    $0a constant DSI_CPLLUIF                    \ [0x0a] Clear PLL Unlock Interrupt Flag
    $0d constant DSI_CRRIF                      \ [0x0d] Clear Regulator Ready Interrupt Flag
  [then]


  [ifdef] DSI_DSI_WPCR1_DEF
    \
    \ @brief DSI Wrapper PHY Configuration Register 1
    \ Address offset: 0x418
    \ Reset value: 0x00000000
    \
    $00 constant DSI_UIX4                       \ [0x00 : 6] Unit Interval multiplied by 4
    $06 constant DSI_SWCL                       \ [0x06] Swap Clock Lane pins
    $07 constant DSI_SWDL0                      \ [0x07] Swap Data Lane 0 pins
    $08 constant DSI_SWDL1                      \ [0x08] Swap Data Lane 1 pins
    $09 constant DSI_HSICL                      \ [0x09] Invert Hight-Speed data signal on Clock Lane
    $0a constant DSI_HSIDL0                     \ [0x0a] Invert the Hight-Speed data signal on Data Lane 0
    $0b constant DSI_HSIDL1                     \ [0x0b] Invert the High-Speed data signal on Data Lane 1
    $0c constant DSI_FTXSMCL                    \ [0x0c] Force in TX Stop Mode the Clock Lane
    $0d constant DSI_FTXSMDL                    \ [0x0d] Force in TX Stop Mode the Data Lanes
    $0e constant DSI_CDOFFDL                    \ [0x0e] Contention Detection OFF on Data Lanes
    $10 constant DSI_TDDL                       \ [0x10] Turn Disable Data Lanes
    $12 constant DSI_PDEN                       \ [0x12] Pull-Down Enable
    $13 constant DSI_TCLKPREPEN                 \ [0x13] custom time for tCLK-PREPARE Enable
    $14 constant DSI_TCLKZEROEN                 \ [0x14] custom time for tCLK-ZERO Enable
    $15 constant DSI_THSPREPEN                  \ [0x15] custom time for tHS-PREPARE Enable
    $16 constant DSI_THSTRAILEN                 \ [0x16] custom time for tHS-TRAIL Enable
    $17 constant DSI_THSZEROEN                  \ [0x17] custom time for tHS-ZERO Enable
    $18 constant DSI_TLPXDEN                    \ [0x18] custom time for tLPX for Data lanes Enable
    $19 constant DSI_THSEXITEN                  \ [0x19] custom time for tHS-EXIT Enable
    $1a constant DSI_TLPXCEN                    \ [0x1a] custom time for tLPX for Clock lane Enable
    $1b constant DSI_TCLKPOSTEN                 \ [0x1b] custom time for tCLK-POST Enable
  [then]


  [ifdef] DSI_DSI_WPCR2_DEF
    \
    \ @brief DSI Wrapper PHY Configuration Register 2
    \ Address offset: 0x41C
    \ Reset value: 0x00000000
    \
    $00 constant DSI_HSTXDCL                    \ [0x00 : 2] High-Speed Transmission Delay on Clock Lane
    $02 constant DSI_HSTXDLL                    \ [0x02 : 2] High-Speed Transmission Delay on Data Lanes
    $06 constant DSI_LPSRCL                     \ [0x06 : 2] Low-Power transmission Slew Rate Compensation on Clock Lane
    $08 constant DSI_LPSRDL                     \ [0x08 : 2] Low-Power transmission Slew Rate Compensation on Data Lanes
    $0c constant DSI_SDCC                       \ [0x0c] SDD Control
    $10 constant DSI_HSTXSRCCL                  \ [0x10 : 2] High-Speed Transmission Slew Rate Control on Clock Lane
    $12 constant DSI_HSTXSRCDL                  \ [0x12 : 2] High-Speed Transmission Slew Rate Control on Data Lanes
    $16 constant DSI_FLPRXLPM                   \ [0x16] Forces LP Receiver in Low-Power Mode
    $19 constant DSI_LPRXFT                     \ [0x19 : 2] Low-Power RX low-pass Filtering Tuning
  [then]


  [ifdef] DSI_DSI_WPCR3_DEF
    \
    \ @brief DSI Wrapper PHY Configuration Register 3
    \ Address offset: 0x420
    \ Reset value: 0x00000000
    \
    $00 constant DSI_TCLKPREP                   \ [0x00 : 8] tCLK-PREPARE
    $08 constant DSI_TCLKZEO                    \ [0x08 : 8] tCLK-ZERO
    $10 constant DSI_THSPREP                    \ [0x10 : 8] tHS-PREPARE
    $18 constant DSI_THSTRAIL                   \ [0x18 : 8] tHSTRAIL
  [then]


  [ifdef] DSI_DSI_WPCR4_DEF
    \
    \ @brief DSI_WPCR4
    \ Address offset: 0x424
    \ Reset value: 0x3133302A
    \
    $00 constant DSI_THSZERO                    \ [0x00 : 8] tHS-ZERO
    $08 constant DSI_TLPXD                      \ [0x08 : 8] tLPX for Data lanes
    $10 constant DSI_THSEXIT                    \ [0x10 : 8] tHSEXIT
    $18 constant DSI_TLPXC                      \ [0x18 : 8] tLPXC for Clock lane
  [then]


  [ifdef] DSI_DSI_WPCR5_DEF
    \
    \ @brief DSI Wrapper PHY Configuration Register 5
    \ Address offset: 0x428
    \ Reset value: 0x00000000
    \
    $00 constant DSI_THSZERO                    \ [0x00 : 8] tCLK-POST
  [then]


  [ifdef] DSI_DSI_WRPCR_DEF
    \
    \ @brief DSI Wrapper Regulator and PLL Control Register
    \ Address offset: 0x430
    \ Reset value: 0x00000000
    \
    $00 constant DSI_PLLEN                      \ [0x00] PLL Enable
    $02 constant DSI_NDIV                       \ [0x02 : 7] PLL Loop Division Factor
    $0b constant DSI_IDF                        \ [0x0b : 4] PLL Input Division Factor
    $10 constant DSI_ODF                        \ [0x10 : 2] PLL Output Division Factor
    $18 constant DSI_REGEN                      \ [0x18] Regulator Enable
  [then]

  \
  \ @brief DSI Host
  \
  $00 constant DSI_DSI_VR               \ DSI Host Version Register
  $04 constant DSI_DSI_CR               \ DSI Host Control Register
  $08 constant DSI_DSI_CCR              \ DSI HOST Clock Control Register
  $0C constant DSI_DSI_LVCIDR           \ DSI Host LTDC VCID Register
  $10 constant DSI_DSI_LCOLCR           \ DSI Host LTDC Color Coding Register
  $14 constant DSI_DSI_LPCR             \ DSI Host LTDC Polarity Configuration Register
  $18 constant DSI_DSI_LPMCR            \ DSI Host Low-Power mode Configuration Register
  $2C constant DSI_DSI_PCR              \ DSI Host Protocol Configuration Register
  $30 constant DSI_DSI_GVCIDR           \ DSI Host Generic VCID Register
  $34 constant DSI_DSI_MCR              \ DSI Host mode Configuration Register
  $38 constant DSI_DSI_VMCR             \ DSI Host Video mode Configuration Register
  $3C constant DSI_DSI_VPCR             \ DSI Host Video Packet Configuration Register
  $40 constant DSI_DSI_VCCR             \ DSI Host Video Chunks Configuration Register
  $44 constant DSI_DSI_VNPCR            \ DSI Host Video Null Packet Configuration Register
  $48 constant DSI_DSI_VHSACR           \ DSI Host Video HSA Configuration Register
  $4C constant DSI_DSI_VHBPCR           \ DSI Host Video HBP Configuration Register
  $50 constant DSI_DSI_VLCR             \ DSI Host Video Line Configuration Register
  $54 constant DSI_DSI_VVSACR           \ DSI Host Video VSA Configuration Register
  $58 constant DSI_DSI_VVBPCR           \ DSI Host Video VBP Configuration Register
  $5C constant DSI_DSI_VVFPCR           \ DSI Host Video VFP Configuration Register
  $60 constant DSI_DSI_VVACR            \ DSI Host Video VA Configuration Register
  $64 constant DSI_DSI_LCCR             \ DSI Host LTDC Command Configuration Register
  $68 constant DSI_DSI_CMCR             \ DSI Host Command mode Configuration Register
  $6C constant DSI_DSI_GHCR             \ DSI Host Generic Header Configuration Register
  $70 constant DSI_DSI_GPDR             \ DSI Host Generic Payload Data Register
  $74 constant DSI_DSI_GPSR             \ DSI Host Generic Packet Status Register
  $78 constant DSI_DSI_TCCR0            \ DSI Host Timeout Counter Configuration Register 0
  $7C constant DSI_DSI_TCCR1            \ DSI Host Timeout Counter Configuration Register 1
  $80 constant DSI_DSI_TCCR2            \ DSI Host Timeout Counter Configuration Register 2
  $84 constant DSI_DSI_TCCR3            \ DSI Host Timeout Counter Configuration Register 3
  $88 constant DSI_DSI_TCCR4            \ DSI Host Timeout Counter Configuration Register 4
  $8C constant DSI_DSI_TCCR5            \ DSI Host Timeout Counter Configuration Register 5
  $94 constant DSI_DSI_CLCR             \ DSI Host Clock Lane Configuration Register
  $98 constant DSI_DSI_CLTCR            \ DSI Host Clock Lane Timer Configuration Register
  $9C constant DSI_DSI_DLTCR            \ DSI Host Data Lane Timer Configuration Register
  $A0 constant DSI_DSI_PCTLR            \ DSI Host PHY Control Register
  $A4 constant DSI_DSI_PCONFR           \ DSI Host PHY Configuration Register
  $A8 constant DSI_DSI_PUCR             \ DSI Host PHY ULPS Control Register
  $AC constant DSI_DSI_PTTCR            \ DSI Host PHY TX Triggers Configuration Register
  $B0 constant DSI_DSI_PSR              \ DSI Host PHY Status Register
  $BC constant DSI_DSI_ISR0             \ DSI Host Interrupt & Status Register 0
  $C0 constant DSI_DSI_ISR1             \ DSI Host Interrupt & Status Register 1
  $C4 constant DSI_DSI_IER0             \ DSI Host Interrupt Enable Register 0
  $C8 constant DSI_DSI_IER1             \ DSI Host Interrupt Enable Register 1
  $D8 constant DSI_DSI_FIR0             \ DSI Host Force Interrupt Register 0
  $DC constant DSI_DSI_FIR1             \ DSI Host Force Interrupt Register 1
  $100 constant DSI_DSI_VSCR            \ DSI Host Video Shadow Control Register
  $10C constant DSI_DSI_LCVCIDR         \ DSI Host LTDC Current VCID Register
  $110 constant DSI_DSI_LCCCR           \ DSI Host LTDC Current Color Coding Register
  $118 constant DSI_DSI_LPMCCR          \ DSI Host Low-Power mode Current Configuration Register
  $138 constant DSI_DSI_VMCCR           \ DSI Host Video mode Current Configuration Register
  $13C constant DSI_DSI_VPCCR           \ DSI Host Video Packet Current Configuration Register
  $140 constant DSI_DSI_VCCCR           \ DSI Host Video Chunks Current Configuration Register
  $144 constant DSI_DSI_VNPCCR          \ DSI Host Video Null Packet Current Configuration Register
  $148 constant DSI_DSI_VHSACCR         \ DSI Host Video HSA Current Configuration Register
  $14C constant DSI_DSI_VHBPCCR         \ DSI Host Video HBP Current Configuration Register
  $150 constant DSI_DSI_VLCCR           \ DSI Host Video Line Current Configuration Register
  $154 constant DSI_DSI_VVSACCR         \ DSI Host Video VSA Current Configuration Register
  $158 constant DSI_DSI_VVBPCCR         \ DSI Host Video VBP Current Configuration Register
  $15C constant DSI_DSI_VVFPCCR         \ DSI Host Video VFP Current Configuration Register
  $160 constant DSI_DSI_VVACCR          \ DSI Host Video VA Current Configuration Register
  $400 constant DSI_DSI_WCFGR           \ DSI Wrapper Configuration Register
  $404 constant DSI_DSI_WCR             \ DSI Wrapper Control Register
  $408 constant DSI_DSI_WIER            \ DSI Wrapper Interrupt Enable Register
  $40C constant DSI_DSI_WISR            \ DSI Wrapper Interrupt & Status Register
  $410 constant DSI_DSI_WIFCR           \ DSI Wrapper Interrupt Flag Clear Register
  $418 constant DSI_DSI_WPCR1           \ DSI Wrapper PHY Configuration Register 1
  $41C constant DSI_DSI_WPCR2           \ DSI Wrapper PHY Configuration Register 2
  $420 constant DSI_DSI_WPCR3           \ DSI Wrapper PHY Configuration Register 3
  $424 constant DSI_DSI_WPCR4           \ DSI_WPCR4
  $428 constant DSI_DSI_WPCR5           \ DSI Wrapper PHY Configuration Register 5
  $430 constant DSI_DSI_WRPCR           \ DSI Wrapper Regulator and PLL Control Register

: DSI_DEF ; [then]
