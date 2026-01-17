\
\ @file fdcan.fs
\ @brief FDCAN1
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] FDCAN_DEF

  [ifdef] FDCAN_FDCAN_CREL_DEF
    \
    \ @brief FDCAN core release register
    \ Address offset: 0x00
    \ Reset value: 0x32141218
    \
    $00 constant FDCAN_DAY                      \ [0x00 : 8] DAY
    $08 constant FDCAN_MON                      \ [0x08 : 8] MON
    $10 constant FDCAN_YEAR                     \ [0x10 : 4] YEAR
    $14 constant FDCAN_SUBSTEP                  \ [0x14 : 4] SUBSTEP
    $18 constant FDCAN_STEP                     \ [0x18 : 4] STEP
    $1c constant FDCAN_REL                      \ [0x1c : 4] REL
  [then]


  [ifdef] FDCAN_FDCAN_ENDN_DEF
    \
    \ @brief FDCAN Endian register
    \ Address offset: 0x04
    \ Reset value: 0x87654321
    \
    $00 constant FDCAN_ETV                      \ [0x00 : 32] ETV
  [then]


  [ifdef] FDCAN_FDCAN_DBTP_DEF
    \
    \ @brief This register is dedicated to data bit timing phase and only writable if bits FDCAN_CCCR.CCE and FDCAN_CCCR.INIT are set. The CAN time quantum may be programmed in the range from 1 to 32 FDCAN clock periods. tq = (DBRP + 1) FDCAN clock periods. DTSEG1 is the sum of Prop_Seg and Phase_Seg1. DTSEG2 is Phase_Seg2. Therefore the length of the bit time is (DTSEG1 + DTSEG2 + 3) tq for programmed values, or (Sync_Seg+Prop_Seg+Phase_Seg1+Phase_Seg2) tq for functional values. The information processing time (IPT) is zero, meaning the data for the next bit is available at the first clock edge after the sample point.
    \ Address offset: 0x0C
    \ Reset value: 0x00000A33
    \
    $00 constant FDCAN_DSJW                     \ [0x00 : 4] DSJW
    $04 constant FDCAN_DTSEG2                   \ [0x04 : 4] DTSEG2
    $08 constant FDCAN_DTSEG1                   \ [0x08 : 5] DTSEG1
    $10 constant FDCAN_DBRP                     \ [0x10 : 5] DBRP
    $17 constant FDCAN_TDC                      \ [0x17] TDC
  [then]


  [ifdef] FDCAN_FDCAN_TEST_DEF
    \
    \ @brief Write access to this register has to be enabled by setting bit FDCAN_CCCR.TEST to 1. All register functions are set to their reset values when bit FDCAN_CCCR.TEST is reset. Loop back mode and software control of Tx pin FDCANx_TX are hardware test modes. Programming TX differently from 00 may disturb the message transfer on the CAN bus.
    \ Address offset: 0x10
    \ Reset value: 0x00000000
    \
    $04 constant FDCAN_LBCK                     \ [0x04] LBCK
    $05 constant FDCAN_TX                       \ [0x05 : 2] TX
    $07 constant FDCAN_RX                       \ [0x07] RX
  [then]


  [ifdef] FDCAN_FDCAN_RWD_DEF
    \
    \ @brief The RAM watchdog monitors the READY output of the message RAM. A message RAM access starts the message RAM watchdog counter with the value configured by the FDCAN_RWD.WDC bits. The counter is reloaded with FDCAN_RWD.WDC bits when the message RAM signals successful completion by activating its READY output. In case there is no response from the message RAM until the counter has counted down to 0, the counter stops and interrupt flag FDCAN_IR.WDI bit is set. The RAM watchdog counter is clocked by the fdcan_pclk clock.
    \ Address offset: 0x14
    \ Reset value: 0x00000000
    \
    $00 constant FDCAN_WDC                      \ [0x00 : 8] WDC
    $08 constant FDCAN_WDV                      \ [0x08 : 8] WDV
  [then]


  [ifdef] FDCAN_FDCAN_CCCR_DEF
    \
    \ @brief For details about setting and resetting of single bits see Software initialization.
    \ Address offset: 0x18
    \ Reset value: 0x00000001
    \
    $00 constant FDCAN_INIT                     \ [0x00] INIT
    $01 constant FDCAN_CCE                      \ [0x01] CCE
    $02 constant FDCAN_ASM                      \ [0x02] ASM
    $03 constant FDCAN_CSA                      \ [0x03] CSA
    $04 constant FDCAN_CSR                      \ [0x04] CSR
    $05 constant FDCAN_MON                      \ [0x05] MON
    $06 constant FDCAN_DAR                      \ [0x06] DAR
    $07 constant FDCAN_TEST                     \ [0x07] TEST
    $08 constant FDCAN_FDOE                     \ [0x08] FDOE
    $09 constant FDCAN_BRSE                     \ [0x09] BRSE
    $0c constant FDCAN_PXHD                     \ [0x0c] PXHD
    $0d constant FDCAN_EFBI                     \ [0x0d] EFBI
    $0e constant FDCAN_TXP                      \ [0x0e] TXP
    $0f constant FDCAN_NISO                     \ [0x0f] NISO
  [then]


  [ifdef] FDCAN_FDCAN_NBTP_DEF
    \
    \ @brief This register is dedicated to the nominal bit timing used during the arbitration phase.
    \ Address offset: 0x1C
    \ Reset value: 0x00000A33
    \
    $00 constant FDCAN_NTSEG2                   \ [0x00 : 7] NTSEG2
    $08 constant FDCAN_NTSEG1                   \ [0x08 : 8] NTSEG1
    $10 constant FDCAN_NBRP                     \ [0x10 : 9] NBRP
    $19 constant FDCAN_NSJW                     \ [0x19 : 7] NSJW
  [then]


  [ifdef] FDCAN_FDCAN_TSCC_DEF
    \
    \ @brief FDCAN timestamp counter configuration register
    \ Address offset: 0x20
    \ Reset value: 0x00000000
    \
    $00 constant FDCAN_TSS                      \ [0x00 : 2] TSS
    $10 constant FDCAN_TCP                      \ [0x10 : 4] TCP
  [then]


  [ifdef] FDCAN_FDCAN_TSCV_DEF
    \
    \ @brief FDCAN timestamp counter value register
    \ Address offset: 0x24
    \ Reset value: 0x00000000
    \
    $00 constant FDCAN_TSC                      \ [0x00 : 16] TSC
  [then]


  [ifdef] FDCAN_FDCAN_TOCC_DEF
    \
    \ @brief FDCAN timeout counter configuration register
    \ Address offset: 0x28
    \ Reset value: 0xFFFF0000
    \
    $00 constant FDCAN_ETOC                     \ [0x00] ETOC
    $01 constant FDCAN_TOS                      \ [0x01 : 2] TOS
    $10 constant FDCAN_TOP                      \ [0x10 : 16] TOP
  [then]


  [ifdef] FDCAN_FDCAN_TOCV_DEF
    \
    \ @brief FDCAN timeout counter value register
    \ Address offset: 0x2C
    \ Reset value: 0x0000FFFF
    \
    $00 constant FDCAN_TOC                      \ [0x00 : 16] TOC
  [then]


  [ifdef] FDCAN_FDCAN_ECR_DEF
    \
    \ @brief FDCAN error counter register
    \ Address offset: 0x40
    \ Reset value: 0x00000000
    \
    $00 constant FDCAN_TEC                      \ [0x00 : 8] TEC
    $08 constant FDCAN_TREC                     \ [0x08 : 7] TREC
    $0f constant FDCAN_RP                       \ [0x0f] RP
    $10 constant FDCAN_CEL                      \ [0x10 : 8] CEL
  [then]


  [ifdef] FDCAN_FDCAN_PSR_DEF
    \
    \ @brief FDCAN protocol status register
    \ Address offset: 0x44
    \ Reset value: 0x00000707
    \
    $00 constant FDCAN_LEC                      \ [0x00 : 3] LEC
    $03 constant FDCAN_ACT                      \ [0x03 : 2] ACT
    $05 constant FDCAN_EP                       \ [0x05] EP
    $06 constant FDCAN_EW                       \ [0x06] EW
    $07 constant FDCAN_BO                       \ [0x07] BO
    $08 constant FDCAN_DLEC                     \ [0x08 : 3] DLEC
    $0b constant FDCAN_RESI                     \ [0x0b] RESI
    $0c constant FDCAN_RBRS                     \ [0x0c] RBRS
    $0d constant FDCAN_REDL                     \ [0x0d] REDL
    $0e constant FDCAN_PXE                      \ [0x0e] PXE
    $10 constant FDCAN_TDCV                     \ [0x10 : 7] TDCV
  [then]


  [ifdef] FDCAN_FDCAN_TDCR_DEF
    \
    \ @brief FDCAN transmitter delay compensation register
    \ Address offset: 0x48
    \ Reset value: 0x00000000
    \
    $00 constant FDCAN_TDCF                     \ [0x00 : 7] TDCF
    $08 constant FDCAN_TDCO                     \ [0x08 : 7] TDCO
  [then]


  [ifdef] FDCAN_FDCAN_IR_DEF
    \
    \ @brief The flags are set when one of the listed conditions is detected (edge-sensitive). The flags remain set until the Host clears them. A flag is cleared by writing a 1 to the corresponding bit position. Writing a 0 has no effect. A hard reset will clear the register. The configuration of IE controls whether an interrupt is generated. The configuration of ILS controls on which interrupt line an interrupt is signaled.
    \ Address offset: 0x50
    \ Reset value: 0x00000000
    \
    $00 constant FDCAN_RF0N                     \ [0x00] RF0N
    $01 constant FDCAN_RF0W                     \ [0x01] RF0W
    $02 constant FDCAN_RF0F                     \ [0x02] RF0F
    $03 constant FDCAN_RF0L                     \ [0x03] RF0L
    $04 constant FDCAN_RF1N                     \ [0x04] RF1N
    $05 constant FDCAN_RF1W                     \ [0x05] RF1W
    $06 constant FDCAN_RF1F                     \ [0x06] RF1F
    $07 constant FDCAN_RF1L                     \ [0x07] RF1L
    $08 constant FDCAN_HPM                      \ [0x08] HPM
    $09 constant FDCAN_TC                       \ [0x09] TC
    $0a constant FDCAN_TCF                      \ [0x0a] TCF
    $0b constant FDCAN_TFE                      \ [0x0b] TFE
    $0c constant FDCAN_TEFN                     \ [0x0c] TEFN
    $0d constant FDCAN_TEFW                     \ [0x0d] TEFW
    $0e constant FDCAN_TEFF                     \ [0x0e] TEFF
    $0f constant FDCAN_TEFL                     \ [0x0f] TEFL
    $10 constant FDCAN_TSW                      \ [0x10] TSW
    $11 constant FDCAN_MRAF                     \ [0x11] MRAF
    $12 constant FDCAN_TOO                      \ [0x12] TOO
    $13 constant FDCAN_DRX                      \ [0x13] DRX
    $16 constant FDCAN_ELO                      \ [0x16] ELO
    $17 constant FDCAN_EP                       \ [0x17] EP
    $18 constant FDCAN_EW                       \ [0x18] EW
    $19 constant FDCAN_BO                       \ [0x19] BO
    $1a constant FDCAN_WDI                      \ [0x1a] WDI
    $1b constant FDCAN_PEA                      \ [0x1b] PEA
    $1c constant FDCAN_PED                      \ [0x1c] PED
    $1d constant FDCAN_ARA                      \ [0x1d] ARA
  [then]


  [ifdef] FDCAN_FDCAN_IE_DEF
    \
    \ @brief The settings in the interrupt enable register determine which status changes in the interrupt register will be signaled on an interrupt line.
    \ Address offset: 0x54
    \ Reset value: 0x00000000
    \
    $00 constant FDCAN_RF0NE                    \ [0x00] RF0NE
    $01 constant FDCAN_RF0WE                    \ [0x01] RF0WE
    $02 constant FDCAN_RF0FE                    \ [0x02] RF0FE
    $03 constant FDCAN_RF0LE                    \ [0x03] RF0LE
    $04 constant FDCAN_RF1NE                    \ [0x04] RF1NE
    $05 constant FDCAN_RF1WE                    \ [0x05] RF1WE
    $06 constant FDCAN_RF1FE                    \ [0x06] RF1FE
    $07 constant FDCAN_RF1LE                    \ [0x07] RF1LE
    $08 constant FDCAN_HPME                     \ [0x08] HPME
    $09 constant FDCAN_TCE                      \ [0x09] TCE
    $0a constant FDCAN_TCFE                     \ [0x0a] TCFE
    $0b constant FDCAN_TFEE                     \ [0x0b] TFEE
    $0c constant FDCAN_TEFNE                    \ [0x0c] TEFNE
    $0d constant FDCAN_TEFWE                    \ [0x0d] TEFWE
    $0e constant FDCAN_TEFFE                    \ [0x0e] TEFFE
    $0f constant FDCAN_TEFLE                    \ [0x0f] TEFLE
    $10 constant FDCAN_TSWE                     \ [0x10] TSWE
    $11 constant FDCAN_MRAFE                    \ [0x11] MRAFE
    $12 constant FDCAN_TOOE                     \ [0x12] TOOE
    $13 constant FDCAN_DRXE                     \ [0x13] DRXE
    $14 constant FDCAN_BECE                     \ [0x14] BECE
    $15 constant FDCAN_BEUE                     \ [0x15] BEUE
    $16 constant FDCAN_ELOE                     \ [0x16] ELOE
    $17 constant FDCAN_EPE                      \ [0x17] EPE
    $18 constant FDCAN_EWE                      \ [0x18] EWE
    $19 constant FDCAN_BOE                      \ [0x19] BOE
    $1a constant FDCAN_WDIE                     \ [0x1a] WDIE
    $1b constant FDCAN_PEAE                     \ [0x1b] PEAE
    $1c constant FDCAN_PEDE                     \ [0x1c] PEDE
    $1d constant FDCAN_ARAE                     \ [0x1d] ARAE
  [then]


  [ifdef] FDCAN_FDCAN_ILS_DEF
    \
    \ @brief This register assigns an interrupt generated by a specific interrupt flag from the interrupt register to one of the two module interrupt lines. For interrupt generation the respective interrupt line has to be enabled via FDCAN_ILE.EINT0 and FDCAN_ILE.EINT1.
    \ Address offset: 0x58
    \ Reset value: 0x00000000
    \
    $00 constant FDCAN_RF0NL                    \ [0x00] RF0NL
    $01 constant FDCAN_RF0WL                    \ [0x01] RF0WL
    $02 constant FDCAN_RF0FL                    \ [0x02] RF0FL
    $03 constant FDCAN_RF0LL                    \ [0x03] RF0LL
    $04 constant FDCAN_RF1NL                    \ [0x04] RF1NL
    $05 constant FDCAN_RF1WL                    \ [0x05] RF1WL
    $06 constant FDCAN_RF1FL                    \ [0x06] RF1FL
    $07 constant FDCAN_RF1LL                    \ [0x07] RF1LL
    $08 constant FDCAN_HPML                     \ [0x08] HPML
    $09 constant FDCAN_TCL                      \ [0x09] TCL
    $0a constant FDCAN_TCFL                     \ [0x0a] TCFL
    $0b constant FDCAN_TFEL                     \ [0x0b] TFEL
    $0c constant FDCAN_TEFNL                    \ [0x0c] TEFNL
    $0d constant FDCAN_TEFWL                    \ [0x0d] TEFWL
    $0e constant FDCAN_TEFFL                    \ [0x0e] TEFFL
    $0f constant FDCAN_TEFLL                    \ [0x0f] TEFLL
    $10 constant FDCAN_TSWL                     \ [0x10] TSWL
    $11 constant FDCAN_MRAFL                    \ [0x11] MRAFL
    $12 constant FDCAN_TOOL                     \ [0x12] TOOL
    $13 constant FDCAN_DRXL                     \ [0x13] DRXL
    $14 constant FDCAN_BECL                     \ [0x14] BECL
    $15 constant FDCAN_BEUL                     \ [0x15] BEUL
    $16 constant FDCAN_ELOL                     \ [0x16] ELOL
    $17 constant FDCAN_EPL                      \ [0x17] EPL
    $18 constant FDCAN_EWL                      \ [0x18] EWL
    $19 constant FDCAN_BOL                      \ [0x19] BOL
    $1a constant FDCAN_WDIL                     \ [0x1a] WDIL
    $1b constant FDCAN_PEAL                     \ [0x1b] PEAL
    $1c constant FDCAN_PEDL                     \ [0x1c] PEDL
    $1d constant FDCAN_ARAL                     \ [0x1d] ARAL
  [then]


  [ifdef] FDCAN_FDCAN_ILE_DEF
    \
    \ @brief Each of the two interrupt lines to the CPU can be enabled/disabled separately by programming bits EINT0 and EINT1.
    \ Address offset: 0x5C
    \ Reset value: 0x00000000
    \
    $00 constant FDCAN_EINT0                    \ [0x00] EINT0
    $01 constant FDCAN_EINT1                    \ [0x01] EINT1
  [then]


  [ifdef] FDCAN_FDCAN_GFC_DEF
    \
    \ @brief Global settings for message ID filtering. The global filter configuration register controls the filter path for standard and extended messages as described in Figure708: Standard message ID filter path and Figure709: Extended message ID filter path.
    \ Address offset: 0x80
    \ Reset value: 0x00000000
    \
    $00 constant FDCAN_RRFE                     \ [0x00] RRFE
    $01 constant FDCAN_RRFS                     \ [0x01] RRFS
    $02 constant FDCAN_ANFE                     \ [0x02 : 2] ANFE
    $04 constant FDCAN_ANFS                     \ [0x04 : 2] ANFS
  [then]


  [ifdef] FDCAN_FDCAN_SIDFC_DEF
    \
    \ @brief Settings for 11-bit standard message ID filtering.The standard ID filter configuration register controls the filter path for standard messages as described in Figure708.
    \ Address offset: 0x84
    \ Reset value: 0x00000000
    \
    $02 constant FDCAN_FLSSA                    \ [0x02 : 14] FLSSA
    $10 constant FDCAN_LSS                      \ [0x10 : 8] LSS
  [then]


  [ifdef] FDCAN_FDCAN_XIDFC_DEF
    \
    \ @brief Settings for 29-bit extended message ID filtering. The FDCAN extended ID filter configuration register controls the filter path for standard messages as described in Figure709: Extended message ID filter path.
    \ Address offset: 0x88
    \ Reset value: 0x00000000
    \
    $02 constant FDCAN_FLESA                    \ [0x02 : 14] FLESA
    $10 constant FDCAN_LSE                      \ [0x10 : 8] LSE
  [then]


  [ifdef] FDCAN_FDCAN_XIDAM_DEF
    \
    \ @brief FDCAN extended ID and mask register
    \ Address offset: 0x90
    \ Reset value: 0x1FFFFFFF
    \
    $00 constant FDCAN_EIDM                     \ [0x00 : 29] EIDM
  [then]


  [ifdef] FDCAN_FDCAN_HPMS_DEF
    \
    \ @brief This register is updated every time a message ID filter element configured to generate a priority event match. This can be used to monitor the status of incoming high priority messages and to enable fast access to these messages.
    \ Address offset: 0x94
    \ Reset value: 0x00000000
    \
    $00 constant FDCAN_BIDX                     \ [0x00 : 6] BIDX
    $06 constant FDCAN_MSI                      \ [0x06 : 2] MSI
    $08 constant FDCAN_FIDX                     \ [0x08 : 7] FIDX
    $0f constant FDCAN_FLST                     \ [0x0f] FLST
  [then]


  [ifdef] FDCAN_FDCAN_NDAT1_DEF
    \
    \ @brief FDCAN new data 1 register
    \ Address offset: 0x98
    \ Reset value: 0x00000000
    \
    $00 constant FDCAN_ND0                      \ [0x00] ND0
    $01 constant FDCAN_ND1                      \ [0x01] ND1
    $02 constant FDCAN_ND2                      \ [0x02] ND2
    $03 constant FDCAN_ND3                      \ [0x03] ND3
    $04 constant FDCAN_ND4                      \ [0x04] ND4
    $05 constant FDCAN_ND5                      \ [0x05] ND5
    $06 constant FDCAN_ND6                      \ [0x06] ND6
    $07 constant FDCAN_ND7                      \ [0x07] ND7
    $08 constant FDCAN_ND8                      \ [0x08] ND8
    $09 constant FDCAN_ND9                      \ [0x09] ND9
    $0a constant FDCAN_ND10                     \ [0x0a] ND10
    $0b constant FDCAN_ND11                     \ [0x0b] ND11
    $0c constant FDCAN_ND12                     \ [0x0c] ND12
    $0d constant FDCAN_ND13                     \ [0x0d] ND13
    $0e constant FDCAN_ND14                     \ [0x0e] ND14
    $0f constant FDCAN_ND15                     \ [0x0f] ND15
    $10 constant FDCAN_ND16                     \ [0x10] ND16
    $11 constant FDCAN_ND17                     \ [0x11] ND17
    $12 constant FDCAN_ND18                     \ [0x12] ND18
    $13 constant FDCAN_ND19                     \ [0x13] ND19
    $14 constant FDCAN_ND20                     \ [0x14] ND20
    $15 constant FDCAN_ND21                     \ [0x15] ND21
    $16 constant FDCAN_ND22                     \ [0x16] ND22
    $17 constant FDCAN_ND23                     \ [0x17] ND23
    $18 constant FDCAN_ND24                     \ [0x18] ND24
    $19 constant FDCAN_ND25                     \ [0x19] ND25
    $1a constant FDCAN_ND26                     \ [0x1a] ND26
    $1b constant FDCAN_ND27                     \ [0x1b] ND27
    $1c constant FDCAN_ND28                     \ [0x1c] ND28
    $1d constant FDCAN_ND29                     \ [0x1d] ND29
    $1e constant FDCAN_ND30                     \ [0x1e] ND30
    $1f constant FDCAN_ND31                     \ [0x1f] ND31
  [then]


  [ifdef] FDCAN_FDCAN_NDAT2_DEF
    \
    \ @brief FDCAN new data 2 register
    \ Address offset: 0x9C
    \ Reset value: 0x00000000
    \
    $00 constant FDCAN_ND32                     \ [0x00] ND32
    $01 constant FDCAN_ND33                     \ [0x01] ND33
    $02 constant FDCAN_ND34                     \ [0x02] ND34
    $03 constant FDCAN_ND35                     \ [0x03] ND35
    $04 constant FDCAN_ND36                     \ [0x04] ND36
    $05 constant FDCAN_ND37                     \ [0x05] ND37
    $06 constant FDCAN_ND38                     \ [0x06] ND38
    $07 constant FDCAN_ND39                     \ [0x07] ND39
    $08 constant FDCAN_ND40                     \ [0x08] ND40
    $09 constant FDCAN_ND41                     \ [0x09] ND41
    $0a constant FDCAN_ND42                     \ [0x0a] ND42
    $0b constant FDCAN_ND43                     \ [0x0b] ND43
    $0c constant FDCAN_ND44                     \ [0x0c] ND44
    $0d constant FDCAN_ND45                     \ [0x0d] ND45
    $0e constant FDCAN_ND46                     \ [0x0e] ND46
    $0f constant FDCAN_ND47                     \ [0x0f] ND47
    $10 constant FDCAN_ND48                     \ [0x10] ND48
    $11 constant FDCAN_ND49                     \ [0x11] ND49
    $12 constant FDCAN_ND50                     \ [0x12] ND50
    $13 constant FDCAN_ND51                     \ [0x13] ND51
    $14 constant FDCAN_ND52                     \ [0x14] ND52
    $15 constant FDCAN_ND53                     \ [0x15] ND53
    $16 constant FDCAN_ND54                     \ [0x16] ND54
    $17 constant FDCAN_ND55                     \ [0x17] ND55
    $18 constant FDCAN_ND56                     \ [0x18] ND56
    $19 constant FDCAN_ND57                     \ [0x19] ND57
    $1a constant FDCAN_ND58                     \ [0x1a] ND58
    $1b constant FDCAN_ND59                     \ [0x1b] ND59
    $1c constant FDCAN_ND60                     \ [0x1c] ND60
    $1d constant FDCAN_ND61                     \ [0x1d] ND61
    $1e constant FDCAN_ND62                     \ [0x1e] ND62
    $1f constant FDCAN_ND63                     \ [0x1f] ND63
  [then]


  [ifdef] FDCAN_FDCAN_RXF0C_DEF
    \
    \ @brief FDCAN Rx FIFO 0 configuration register
    \ Address offset: 0xA0
    \ Reset value: 0x00000000
    \
    $02 constant FDCAN_F0SA                     \ [0x02 : 14] F0SA
    $10 constant FDCAN_F0S                      \ [0x10 : 7] F0S
    $18 constant FDCAN_F0WM                     \ [0x18 : 7] F0WM
    $1f constant FDCAN_F0OM                     \ [0x1f] F0OM
  [then]


  [ifdef] FDCAN_FDCAN_RXF0S_DEF
    \
    \ @brief FDCAN Rx FIFO 0 status register
    \ Address offset: 0xA4
    \ Reset value: 0x00000000
    \
    $00 constant FDCAN_F0FL                     \ [0x00 : 7] F0FL
    $08 constant FDCAN_F0GI                     \ [0x08 : 6] F0GI
    $10 constant FDCAN_F0PI                     \ [0x10 : 6] F0PI
    $18 constant FDCAN_F0F                      \ [0x18] F0F
    $19 constant FDCAN_RF0L                     \ [0x19] RF0L
  [then]


  [ifdef] FDCAN_FDCAN_RXF0A_DEF
    \
    \ @brief FDCAN Rx FIFO 0 acknowledge register
    \ Address offset: 0xA8
    \ Reset value: 0x00000000
    \
    $00 constant FDCAN_F0AI                     \ [0x00 : 6] F0AI
  [then]


  [ifdef] FDCAN_FDCAN_RXBC_DEF
    \
    \ @brief FDCAN Rx buffer configuration register
    \ Address offset: 0xAC
    \ Reset value: 0x00000000
    \
    $02 constant FDCAN_RBSA                     \ [0x02 : 14] RBSA
  [then]


  [ifdef] FDCAN_FDCAN_RXF1C_DEF
    \
    \ @brief FDCAN Rx FIFO 1 configuration register
    \ Address offset: 0xB0
    \ Reset value: 0x00000000
    \
    $02 constant FDCAN_F1SA                     \ [0x02 : 14] F1SA
    $10 constant FDCAN_F1S                      \ [0x10 : 7] F1S
    $18 constant FDCAN_F1WM                     \ [0x18 : 7] F1WM
    $1f constant FDCAN_F1OM                     \ [0x1f] F1OM
  [then]


  [ifdef] FDCAN_FDCAN_RXF1S_DEF
    \
    \ @brief FDCAN Rx FIFO 1 status register
    \ Address offset: 0xB4
    \ Reset value: 0x00000000
    \
    $00 constant FDCAN_F1FL                     \ [0x00 : 7] F1FL
    $08 constant FDCAN_F1GI                     \ [0x08 : 6] F1GI
    $10 constant FDCAN_F1PI                     \ [0x10 : 6] F1PI
    $18 constant FDCAN_F1F                      \ [0x18] F1F
    $19 constant FDCAN_RF1L                     \ [0x19] RF1L
    $1e constant FDCAN_DMS                      \ [0x1e : 2] DMS
  [then]


  [ifdef] FDCAN_FDCAN_RXF1A_DEF
    \
    \ @brief FDCAN Rx FIFO 1 acknowledge register
    \ Address offset: 0xB8
    \ Reset value: 0x00000000
    \
    $00 constant FDCAN_F1AI                     \ [0x00 : 6] F1AI
  [then]


  [ifdef] FDCAN_FDCAN_RXESC_DEF
    \
    \ @brief Configures the number of data bytes belonging to an Rx buffer / Rx FIFO element. Data field sizes higher than 8 bytes are intended for CAN FD operation only.
    \ Address offset: 0xBC
    \ Reset value: 0x00000000
    \
    $00 constant FDCAN_F0DS                     \ [0x00 : 3] F0DS
    $04 constant FDCAN_F1DS                     \ [0x04 : 3] F1DS
    $08 constant FDCAN_RBDS                     \ [0x08 : 3] RBDS
  [then]


  [ifdef] FDCAN_FDCAN_TXBC_DEF
    \
    \ @brief FDCAN Tx buffer configuration register
    \ Address offset: 0xC0
    \ Reset value: 0x00000000
    \
    $02 constant FDCAN_TBSA                     \ [0x02 : 14] TBSA
    $10 constant FDCAN_NDTB                     \ [0x10 : 6] NDTB
    $18 constant FDCAN_TFQS                     \ [0x18 : 6] TFQS
    $1e constant FDCAN_TFQM                     \ [0x1e] TFQM
  [then]


  [ifdef] FDCAN_FDCAN_TXFQS_DEF
    \
    \ @brief The Tx FIFO/queue status is related to the pending Tx requests listed in register FDCAN_TXBRP. Therefore the effect of add/cancellation requests may be delayed due to a running Tx scan (FDCAN_TXBRP not yet updated).
    \ Address offset: 0xC4
    \ Reset value: 0x00000000
    \
    $00 constant FDCAN_TFFL                     \ [0x00 : 6] TFFL
    $08 constant FDCAN_TFGI                     \ [0x08 : 5] TFGI
    $10 constant FDCAN_TFQPI                    \ [0x10 : 5] TFQPI
    $15 constant FDCAN_TFQF                     \ [0x15] TFQF
  [then]


  [ifdef] FDCAN_FDCAN_TXESC_DEF
    \
    \ @brief Configures the number of data bytes belonging to a Tx buffer element. Data field sizes &gt;8 bytes are intended for CAN FD operation only.
    \ Address offset: 0xC8
    \ Reset value: 0x00000000
    \
    $00 constant FDCAN_TBDS                     \ [0x00 : 3] TBDS
  [then]


  [ifdef] FDCAN_FDCAN_TXBAR_DEF
    \
    \ @brief FDCAN Tx buffer add request register
    \ Address offset: 0xD0
    \ Reset value: 0x00000000
    \
    $00 constant FDCAN_AR                       \ [0x00 : 32] AR
  [then]


  [ifdef] FDCAN_FDCAN_TXBCR_DEF
    \
    \ @brief FDCAN Tx buffer cancellation request register
    \ Address offset: 0xD4
    \ Reset value: 0x00000000
    \
    $00 constant FDCAN_CR                       \ [0x00 : 32] CR
  [then]


  [ifdef] FDCAN_FDCAN_TXBTO_DEF
    \
    \ @brief FDCAN Tx buffer transmission occurred register
    \ Address offset: 0xD8
    \ Reset value: 0x00000000
    \
    $00 constant FDCAN_TO                       \ [0x00 : 32] TO
  [then]


  [ifdef] FDCAN_FDCAN_TXBCF_DEF
    \
    \ @brief FDCAN Tx buffer cancellation finished register
    \ Address offset: 0xDC
    \ Reset value: 0x00000000
    \
    $00 constant FDCAN_CF                       \ [0x00 : 32] CF
  [then]


  [ifdef] FDCAN_FDCAN_TXBTIE_DEF
    \
    \ @brief FDCAN Tx buffer transmission interrupt enable register
    \ Address offset: 0xE0
    \ Reset value: 0x00000000
    \
    $00 constant FDCAN_TIE                      \ [0x00 : 32] TIE
  [then]


  [ifdef] FDCAN_FDCAN_TXBCIE_DEF
    \
    \ @brief FDCAN Tx buffer cancellation finished interrupt enable register
    \ Address offset: 0xE4
    \ Reset value: 0x00000000
    \
    $00 constant FDCAN_CFIE                     \ [0x00 : 32] CFIE
  [then]


  [ifdef] FDCAN_FDCAN_TXEFC_DEF
    \
    \ @brief FDCAN Tx event FIFO configuration register
    \ Address offset: 0xF0
    \ Reset value: 0x00000000
    \
    $02 constant FDCAN_EFSA                     \ [0x02 : 14] EFSA
    $10 constant FDCAN_EFS                      \ [0x10 : 6] EFS
    $18 constant FDCAN_EFWM                     \ [0x18 : 6] EFWM
  [then]


  [ifdef] FDCAN_FDCAN_TXEFS_DEF
    \
    \ @brief FDCAN Tx event FIFO status register
    \ Address offset: 0xF4
    \ Reset value: 0x00000000
    \
    $00 constant FDCAN_EFFL                     \ [0x00 : 6] EFFL
    $08 constant FDCAN_EFGI                     \ [0x08 : 5] EFGI
    $10 constant FDCAN_EFPI                     \ [0x10 : 5] EFPI
    $18 constant FDCAN_EFF                      \ [0x18] EFF
    $19 constant FDCAN_TEFL                     \ [0x19] TEFL
  [then]


  [ifdef] FDCAN_FDCAN_TXEFA_DEF
    \
    \ @brief FDCAN Tx event FIFO acknowledge register
    \ Address offset: 0xF8
    \ Reset value: 0x00000000
    \
    $00 constant FDCAN_EFAI                     \ [0x00 : 5] EFAI
  [then]


  [ifdef] FDCAN_FDCAN_TTTMC_DEF
    \
    \ @brief FDCAN TT trigger memory configuration register
    \ Address offset: 0x100
    \ Reset value: 0x00000000
    \
    $02 constant FDCAN_TMSA                     \ [0x02 : 14] TMSA
    $10 constant FDCAN_TME                      \ [0x10 : 7] TME
  [then]


  [ifdef] FDCAN_FDCAN_TTRMC_DEF
    \
    \ @brief FDCAN TT reference message configuration register
    \ Address offset: 0x104
    \ Reset value: 0x00000000
    \
    $00 constant FDCAN_RID                      \ [0x00 : 29] RID
    $1e constant FDCAN_XTD                      \ [0x1e] XTD
    $1f constant FDCAN_RMPS                     \ [0x1f] RMPS
  [then]


  [ifdef] FDCAN_FDCAN_TTOCF_DEF
    \
    \ @brief FDCAN TT operation configuration register
    \ Address offset: 0x108
    \ Reset value: 0x00010000
    \
    $00 constant FDCAN_OM                       \ [0x00 : 2] OM
    $03 constant FDCAN_GEN                      \ [0x03] GEN
    $04 constant FDCAN_TM                       \ [0x04] TM
    $05 constant FDCAN_LDSDL                    \ [0x05 : 3] LDSDL
    $08 constant FDCAN_IRTO                     \ [0x08 : 7] IRTO
    $0f constant FDCAN_EECS                     \ [0x0f] EECS
    $10 constant FDCAN_AWL                      \ [0x10 : 8] AWL
    $18 constant FDCAN_EGTF                     \ [0x18] EGTF
    $19 constant FDCAN_ECC                      \ [0x19] ECC
    $1a constant FDCAN_EVTP                     \ [0x1a] EVTP
  [then]


  [ifdef] FDCAN_FDCAN_TTMLM_DEF
    \
    \ @brief FDCAN TT matrix limits register
    \ Address offset: 0x10C
    \ Reset value: 0x00000000
    \
    $00 constant FDCAN_CCM                      \ [0x00 : 6] CCM
    $06 constant FDCAN_CSS                      \ [0x06 : 2] CSS
    $08 constant FDCAN_TXEW                     \ [0x08 : 4] TXEW
    $10 constant FDCAN_ENTT                     \ [0x10 : 12] ENTT
  [then]


  [ifdef] FDCAN_FDCAN_TURCF_DEF
    \
    \ @brief The length of the NTU is given by: NTU = CAN clock period x NC/DC. NC is an 18-bit value. Its high part, NCH[17:16] is hard wired to 0b01. Therefore the range of NC extends from 0x10000 to 0x1FFFF. The value configured by NCL is the initial value for FDCAN_TURNA.NAV[15:0]. DC is set to 0x1000 by hardware reset and it may not be written to 0x0000. Level 1: NC 4 * DC and NTU = CAN bit time Levels 0 and 2: NC 8 * DC The actual value of FDCAN_TUR may be changed by the clock drift compensation function of TTCAN level 0 and level 2 in order to adjust the node local view of the NTU to the time master view of the NTU. DC will not be changed by the automatic drift compensation, FDCAN_TURNA.NAV may be adjusted around NC in the range of the synchronization deviation limit given by FDCAN_TTOCF.LDSDL. NC and DC should be programmed to the largest suitable values in achieve the best computational accuracy for the drift compensation process.
    \ Address offset: 0x110
    \ Reset value: 0x00000000
    \
    $00 constant FDCAN_NCL                      \ [0x00 : 16] NCL
    $10 constant FDCAN_DC                       \ [0x10 : 14] DC
    $1f constant FDCAN_ELT                      \ [0x1f] ELT
  [then]


  [ifdef] FDCAN_FDCAN_TTOCN_DEF
    \
    \ @brief FDCAN TT operation control register
    \ Address offset: 0x114
    \ Reset value: 0x00000000
    \
    $00 constant FDCAN_SGT                      \ [0x00] SGT
    $01 constant FDCAN_ECS                      \ [0x01] ECS
    $02 constant FDCAN_SWP                      \ [0x02] SWP
    $03 constant FDCAN_SWS                      \ [0x03 : 2] SWS
    $05 constant FDCAN_RTIE                     \ [0x05] RTIE
    $06 constant FDCAN_TMC                      \ [0x06 : 2] TMC
    $08 constant FDCAN_TTIE                     \ [0x08] TTIE
    $09 constant FDCAN_GCS                      \ [0x09] GCS
    $0a constant FDCAN_FGP                      \ [0x0a] FGP
    $0b constant FDCAN_TMG                      \ [0x0b] TMG
    $0c constant FDCAN_NIG                      \ [0x0c] NIG
    $0d constant FDCAN_ESCN                     \ [0x0d] ESCN
    $0f constant FDCAN_LCKC                     \ [0x0f] LCKC
  [then]


  [ifdef] FDCAN_FDCAN_TTGTP_DEF
    \
    \ @brief If TTOST.WGDT is set, the next reference message will be transmitted with the Master_Ref_Mark modified by the preset value and with Disc_Bit = 1, presetting the global time in all nodes simultaneously. TP is reset to 0x0000 each time a reference message with Disc_Bit = 1 becomes valid or if the node is not the current time master. TP is locked while FDCAN_TTOST.WGTD = 1 after setting FDCAN_TTOCN.SGT until the reference message with Disc_Bit = 1 becomes valid or until the node is no longer the current time master.
    \ Address offset: 0x118
    \ Reset value: 0x00000000
    \
    $00 constant FDCAN_TP                       \ [0x00 : 16] TP
    $10 constant FDCAN_CTP                      \ [0x10 : 16] CTP
  [then]


  [ifdef] FDCAN_FDCAN_TTTMK_DEF
    \
    \ @brief A time mark interrupt (FDCAN_TTIR.TMI = 1) is generated when the time base indicated by FDCAN_TTOCN.TMC (cycle time, local time, or global time) has the same value as TM.
    \ Address offset: 0x11C
    \ Reset value: 0x00000000
    \
    $00 constant FDCAN_TM                       \ [0x00 : 16] TM
    $10 constant FDCAN_TICC                     \ [0x10 : 7] TICC
    $1f constant FDCAN_LCKM                     \ [0x1f] LCKM
  [then]


  [ifdef] FDCAN_FDCAN_TTIR_DEF
    \
    \ @brief The flags are set when one of the listed conditions is detected (edge-sensitive). The flags remain set until the Host clears them. A flag is cleared by writing a 1 to the corresponding bit position. Writing a 0 has no effect. A hard reset will clear the register.
    \ Address offset: 0x120
    \ Reset value: 0x00000000
    \
    $00 constant FDCAN_SBC                      \ [0x00] SBC
    $01 constant FDCAN_SMC                      \ [0x01] SMC
    $02 constant FDCAN_CSM                      \ [0x02] CSM
    $03 constant FDCAN_SOG                      \ [0x03] SOG
    $04 constant FDCAN_RTMI                     \ [0x04] RTMI
    $05 constant FDCAN_TTMI                     \ [0x05] TTMI
    $06 constant FDCAN_SWE                      \ [0x06] SWE
    $07 constant FDCAN_GTW                      \ [0x07] GTW
    $08 constant FDCAN_GTD                      \ [0x08] GTD
    $09 constant FDCAN_GTE                      \ [0x09] GTE
    $0a constant FDCAN_TXU                      \ [0x0a] TXU
    $0b constant FDCAN_TXO                      \ [0x0b] TXO
    $0c constant FDCAN_SE1                      \ [0x0c] SE1
    $0d constant FDCAN_SE2                      \ [0x0d] SE2
    $0e constant FDCAN_ELC                      \ [0x0e] ELC
    $0f constant FDCAN_IWTG                     \ [0x0f] IWTG
    $10 constant FDCAN_WT                       \ [0x10] WT
    $11 constant FDCAN_AW                       \ [0x11] AW
    $12 constant FDCAN_CER                      \ [0x12] CER
  [then]


  [ifdef] FDCAN_FDCAN_TTIE_DEF
    \
    \ @brief The settings in the TT interrupt enable register determine which status changes in the TT interrupt register will result in an interrupt.
    \ Address offset: 0x124
    \ Reset value: 0x00000000
    \
    $00 constant FDCAN_SBCE                     \ [0x00] SBCE
    $01 constant FDCAN_SMCE                     \ [0x01] SMCE
    $02 constant FDCAN_CSME                     \ [0x02] CSME
    $03 constant FDCAN_SOGE                     \ [0x03] SOGE
    $04 constant FDCAN_RTMIE                    \ [0x04] RTMIE
    $05 constant FDCAN_TTMIE                    \ [0x05] TTMIE
    $06 constant FDCAN_SWEE                     \ [0x06] SWEE
    $07 constant FDCAN_GTWE                     \ [0x07] GTWE
    $08 constant FDCAN_GTDE                     \ [0x08] GTDE
    $09 constant FDCAN_GTEE                     \ [0x09] GTEE
    $0a constant FDCAN_TXUE                     \ [0x0a] TXUE
    $0b constant FDCAN_TXOE                     \ [0x0b] TXOE
    $0c constant FDCAN_SE1E                     \ [0x0c] SE1E
    $0d constant FDCAN_SE2E                     \ [0x0d] SE2E
    $0e constant FDCAN_ELCE                     \ [0x0e] ELCE
    $0f constant FDCAN_IWTE                     \ [0x0f] IWTE
    $10 constant FDCAN_WTE                      \ [0x10] WTE
    $11 constant FDCAN_AWE                      \ [0x11] AWE
    $12 constant FDCAN_CERE                     \ [0x12] CERE
  [then]


  [ifdef] FDCAN_FDCAN_TTILS_DEF
    \
    \ @brief The TT interrupt Line select register assigns an interrupt generated by a specific interrupt flag from the TT interrupt register to one of the two module interrupt lines. For interrupt generation the respective interrupt line has to be enabled via FDCAN_ILE.EINT0 and FDCAN_ILE.EINT1.
    \ Address offset: 0x128
    \ Reset value: 0x00000000
    \
    $00 constant FDCAN_SBCL                     \ [0x00] SBCL
    $01 constant FDCAN_SMCL                     \ [0x01] SMCL
    $02 constant FDCAN_CSML                     \ [0x02] CSML
    $03 constant FDCAN_SOGL                     \ [0x03] SOGL
    $04 constant FDCAN_RTMIL                    \ [0x04] RTMIL
    $05 constant FDCAN_TTMIL                    \ [0x05] TTMIL
    $06 constant FDCAN_SWEL                     \ [0x06] SWEL
    $07 constant FDCAN_GTWL                     \ [0x07] GTWL
    $08 constant FDCAN_GTDL                     \ [0x08] GTDL
    $09 constant FDCAN_GTEL                     \ [0x09] GTEL
    $0a constant FDCAN_TXUL                     \ [0x0a] TXUL
    $0b constant FDCAN_TXOL                     \ [0x0b] TXOL
    $0c constant FDCAN_SE1L                     \ [0x0c] SE1L
    $0d constant FDCAN_SE2L                     \ [0x0d] SE2L
    $0e constant FDCAN_ELCL                     \ [0x0e] ELCL
    $0f constant FDCAN_IWTL                     \ [0x0f] IWTL
    $10 constant FDCAN_WTL                      \ [0x10] WTL
    $11 constant FDCAN_AWL                      \ [0x11] AWL
    $12 constant FDCAN_CERL                     \ [0x12] CERL
  [then]


  [ifdef] FDCAN_FDCAN_TTOST_DEF
    \
    \ @brief FDCAN TT operation status register
    \ Address offset: 0x12C
    \ Reset value: 0x00000080
    \
    $00 constant FDCAN_EL                       \ [0x00 : 2] EL
    $02 constant FDCAN_MS                       \ [0x02 : 2] MS
    $04 constant FDCAN_SYS                      \ [0x04 : 2] SYS
    $06 constant FDCAN_QGTP                     \ [0x06] QGTP
    $07 constant FDCAN_QCS                      \ [0x07] QCS
    $08 constant FDCAN_RTO                      \ [0x08 : 8] RTO
    $16 constant FDCAN_WGTD                     \ [0x16] WGTD
    $17 constant FDCAN_GFI                      \ [0x17] GFI
    $18 constant FDCAN_TMP                      \ [0x18 : 3] TMP
    $1b constant FDCAN_GSI                      \ [0x1b] GSI
    $1c constant FDCAN_WFE                      \ [0x1c] WFE
    $1d constant FDCAN_AWE                      \ [0x1d] AWE
    $1e constant FDCAN_WECS                     \ [0x1e] WECS
    $1f constant FDCAN_SPL                      \ [0x1f] SPL
  [then]


  [ifdef] FDCAN_FDCAN_TURNA_DEF
    \
    \ @brief There is no drift compensation in TTCAN level 1.
    \ Address offset: 0x130
    \ Reset value: 0x00000000
    \
    $00 constant FDCAN_NAV                      \ [0x00 : 18] NAV
  [then]


  [ifdef] FDCAN_FDCAN_TTLGT_DEF
    \
    \ @brief FDCAN TT local and global time register
    \ Address offset: 0x134
    \ Reset value: 0x00000000
    \
    $00 constant FDCAN_LT                       \ [0x00 : 16] LT
    $10 constant FDCAN_GT                       \ [0x10 : 16] GT
  [then]


  [ifdef] FDCAN_FDCAN_TTCTC_DEF
    \
    \ @brief FDCAN TT cycle time and count register
    \ Address offset: 0x138
    \ Reset value: 0x003F0000
    \
    $00 constant FDCAN_CT                       \ [0x00 : 16] CT
    $10 constant FDCAN_CC                       \ [0x10 : 6] CC
  [then]


  [ifdef] FDCAN_FDCAN_TTCPT_DEF
    \
    \ @brief FDCAN TT capture time register
    \ Address offset: 0x13C
    \ Reset value: 0x00000000
    \
    $00 constant FDCAN_CCV                      \ [0x00 : 6] CCV
    $10 constant FDCAN_SWV                      \ [0x10 : 16] SWV
  [then]


  [ifdef] FDCAN_FDCAN_TTCSM_DEF
    \
    \ @brief FDCAN TT cycle sync mark register
    \ Address offset: 0x140
    \ Reset value: 0x00000000
    \
    $00 constant FDCAN_CSM                      \ [0x00 : 16] CSM
  [then]


  [ifdef] FDCAN_FDCAN_TTTS_DEF
    \
    \ @brief The settings in the FDCAN_TTTS register select the input to be used as event trigger and stop watch trigger.
    \ Address offset: 0x300
    \ Reset value: 0x00000000
    \
    $00 constant FDCAN_SWTDEL                   \ [0x00 : 2] SWTDEL
    $04 constant FDCAN_EVTSEL                   \ [0x04 : 2] EVTSEL
  [then]

  \
  \ @brief FDCAN1
  \
  $00 constant FDCAN_FDCAN_CREL         \ FDCAN core release register
  $04 constant FDCAN_FDCAN_ENDN         \ FDCAN Endian register
  $0C constant FDCAN_FDCAN_DBTP         \ This register is dedicated to data bit timing phase and only writable if bits FDCAN_CCCR.CCE and FDCAN_CCCR.INIT are set. The CAN time quantum may be programmed in the range from 1 to 32 FDCAN clock periods. tq = (DBRP + 1) FDCAN clock periods. DTSEG1 is the sum of Prop_Seg and Phase_Seg1. DTSEG2 is Phase_Seg2. Therefore the length of the bit time is (DTSEG1 + DTSEG2 + 3) tq for programmed values, or (Sync_Seg+Prop_Seg+Phase_Seg1+Phase_Seg2) tq for functional values. The information processing time (IPT) is zero, meaning the data for the next bit is available at the first clock edge after the sample point.
  $10 constant FDCAN_FDCAN_TEST         \ Write access to this register has to be enabled by setting bit FDCAN_CCCR.TEST to 1. All register functions are set to their reset values when bit FDCAN_CCCR.TEST is reset. Loop back mode and software control of Tx pin FDCANx_TX are hardware test modes. Programming TX differently from 00 may disturb the message transfer on the CAN bus.
  $14 constant FDCAN_FDCAN_RWD          \ The RAM watchdog monitors the READY output of the message RAM. A message RAM access starts the message RAM watchdog counter with the value configured by the FDCAN_RWD.WDC bits. The counter is reloaded with FDCAN_RWD.WDC bits when the message RAM signals successful completion by activating its READY output. In case there is no response from the message RAM until the counter has counted down to 0, the counter stops and interrupt flag FDCAN_IR.WDI bit is set. The RAM watchdog counter is clocked by the fdcan_pclk clock.
  $18 constant FDCAN_FDCAN_CCCR         \ For details about setting and resetting of single bits see Software initialization.
  $1C constant FDCAN_FDCAN_NBTP         \ This register is dedicated to the nominal bit timing used during the arbitration phase.
  $20 constant FDCAN_FDCAN_TSCC         \ FDCAN timestamp counter configuration register
  $24 constant FDCAN_FDCAN_TSCV         \ FDCAN timestamp counter value register
  $28 constant FDCAN_FDCAN_TOCC         \ FDCAN timeout counter configuration register
  $2C constant FDCAN_FDCAN_TOCV         \ FDCAN timeout counter value register
  $40 constant FDCAN_FDCAN_ECR          \ FDCAN error counter register
  $44 constant FDCAN_FDCAN_PSR          \ FDCAN protocol status register
  $48 constant FDCAN_FDCAN_TDCR         \ FDCAN transmitter delay compensation register
  $50 constant FDCAN_FDCAN_IR           \ The flags are set when one of the listed conditions is detected (edge-sensitive). The flags remain set until the Host clears them. A flag is cleared by writing a 1 to the corresponding bit position. Writing a 0 has no effect. A hard reset will clear the register. The configuration of IE controls whether an interrupt is generated. The configuration of ILS controls on which interrupt line an interrupt is signaled.
  $54 constant FDCAN_FDCAN_IE           \ The settings in the interrupt enable register determine which status changes in the interrupt register will be signaled on an interrupt line.
  $58 constant FDCAN_FDCAN_ILS          \ This register assigns an interrupt generated by a specific interrupt flag from the interrupt register to one of the two module interrupt lines. For interrupt generation the respective interrupt line has to be enabled via FDCAN_ILE.EINT0 and FDCAN_ILE.EINT1.
  $5C constant FDCAN_FDCAN_ILE          \ Each of the two interrupt lines to the CPU can be enabled/disabled separately by programming bits EINT0 and EINT1.
  $80 constant FDCAN_FDCAN_GFC          \ Global settings for message ID filtering. The global filter configuration register controls the filter path for standard and extended messages as described in Figure708: Standard message ID filter path and Figure709: Extended message ID filter path.
  $84 constant FDCAN_FDCAN_SIDFC        \ Settings for 11-bit standard message ID filtering.The standard ID filter configuration register controls the filter path for standard messages as described in Figure708.
  $88 constant FDCAN_FDCAN_XIDFC        \ Settings for 29-bit extended message ID filtering. The FDCAN extended ID filter configuration register controls the filter path for standard messages as described in Figure709: Extended message ID filter path.
  $90 constant FDCAN_FDCAN_XIDAM        \ FDCAN extended ID and mask register
  $94 constant FDCAN_FDCAN_HPMS         \ This register is updated every time a message ID filter element configured to generate a priority event match. This can be used to monitor the status of incoming high priority messages and to enable fast access to these messages.
  $98 constant FDCAN_FDCAN_NDAT1        \ FDCAN new data 1 register
  $9C constant FDCAN_FDCAN_NDAT2        \ FDCAN new data 2 register
  $A0 constant FDCAN_FDCAN_RXF0C        \ FDCAN Rx FIFO 0 configuration register
  $A4 constant FDCAN_FDCAN_RXF0S        \ FDCAN Rx FIFO 0 status register
  $A8 constant FDCAN_FDCAN_RXF0A        \ FDCAN Rx FIFO 0 acknowledge register
  $AC constant FDCAN_FDCAN_RXBC         \ FDCAN Rx buffer configuration register
  $B0 constant FDCAN_FDCAN_RXF1C        \ FDCAN Rx FIFO 1 configuration register
  $B4 constant FDCAN_FDCAN_RXF1S        \ FDCAN Rx FIFO 1 status register
  $B8 constant FDCAN_FDCAN_RXF1A        \ FDCAN Rx FIFO 1 acknowledge register
  $BC constant FDCAN_FDCAN_RXESC        \ Configures the number of data bytes belonging to an Rx buffer / Rx FIFO element. Data field sizes higher than 8 bytes are intended for CAN FD operation only.
  $C0 constant FDCAN_FDCAN_TXBC         \ FDCAN Tx buffer configuration register
  $C4 constant FDCAN_FDCAN_TXFQS        \ The Tx FIFO/queue status is related to the pending Tx requests listed in register FDCAN_TXBRP. Therefore the effect of add/cancellation requests may be delayed due to a running Tx scan (FDCAN_TXBRP not yet updated).
  $C8 constant FDCAN_FDCAN_TXESC        \ Configures the number of data bytes belonging to a Tx buffer element. Data field sizes &gt;8 bytes are intended for CAN FD operation only.
  $D0 constant FDCAN_FDCAN_TXBAR        \ FDCAN Tx buffer add request register
  $D4 constant FDCAN_FDCAN_TXBCR        \ FDCAN Tx buffer cancellation request register
  $D8 constant FDCAN_FDCAN_TXBTO        \ FDCAN Tx buffer transmission occurred register
  $DC constant FDCAN_FDCAN_TXBCF        \ FDCAN Tx buffer cancellation finished register
  $E0 constant FDCAN_FDCAN_TXBTIE       \ FDCAN Tx buffer transmission interrupt enable register
  $E4 constant FDCAN_FDCAN_TXBCIE       \ FDCAN Tx buffer cancellation finished interrupt enable register
  $F0 constant FDCAN_FDCAN_TXEFC        \ FDCAN Tx event FIFO configuration register
  $F4 constant FDCAN_FDCAN_TXEFS        \ FDCAN Tx event FIFO status register
  $F8 constant FDCAN_FDCAN_TXEFA        \ FDCAN Tx event FIFO acknowledge register
  $100 constant FDCAN_FDCAN_TTTMC       \ FDCAN TT trigger memory configuration register
  $104 constant FDCAN_FDCAN_TTRMC       \ FDCAN TT reference message configuration register
  $108 constant FDCAN_FDCAN_TTOCF       \ FDCAN TT operation configuration register
  $10C constant FDCAN_FDCAN_TTMLM       \ FDCAN TT matrix limits register
  $110 constant FDCAN_FDCAN_TURCF       \ The length of the NTU is given by: NTU = CAN clock period x NC/DC. NC is an 18-bit value. Its high part, NCH[17:16] is hard wired to 0b01. Therefore the range of NC extends from 0x10000 to 0x1FFFF. The value configured by NCL is the initial value for FDCAN_TURNA.NAV[15:0]. DC is set to 0x1000 by hardware reset and it may not be written to 0x0000. Level 1: NC 4 * DC and NTU = CAN bit time Levels 0 and 2: NC 8 * DC The actual value of FDCAN_TUR may be changed by the clock drift compensation function of TTCAN level 0 and level 2 in order to adjust the node local view of the NTU to the time master view of the NTU. DC will not be changed by the automatic drift compensation, FDCAN_TURNA.NAV may be adjusted around NC in the range of the synchronization deviation limit given by FDCAN_TTOCF.LDSDL. NC and DC should be programmed to the largest suitable values in achieve the best computational accuracy for the drift compensation process.
  $114 constant FDCAN_FDCAN_TTOCN       \ FDCAN TT operation control register
  $118 constant FDCAN_FDCAN_TTGTP       \ If TTOST.WGDT is set, the next reference message will be transmitted with the Master_Ref_Mark modified by the preset value and with Disc_Bit = 1, presetting the global time in all nodes simultaneously. TP is reset to 0x0000 each time a reference message with Disc_Bit = 1 becomes valid or if the node is not the current time master. TP is locked while FDCAN_TTOST.WGTD = 1 after setting FDCAN_TTOCN.SGT until the reference message with Disc_Bit = 1 becomes valid or until the node is no longer the current time master.
  $11C constant FDCAN_FDCAN_TTTMK       \ A time mark interrupt (FDCAN_TTIR.TMI = 1) is generated when the time base indicated by FDCAN_TTOCN.TMC (cycle time, local time, or global time) has the same value as TM.
  $120 constant FDCAN_FDCAN_TTIR        \ The flags are set when one of the listed conditions is detected (edge-sensitive). The flags remain set until the Host clears them. A flag is cleared by writing a 1 to the corresponding bit position. Writing a 0 has no effect. A hard reset will clear the register.
  $124 constant FDCAN_FDCAN_TTIE        \ The settings in the TT interrupt enable register determine which status changes in the TT interrupt register will result in an interrupt.
  $128 constant FDCAN_FDCAN_TTILS       \ The TT interrupt Line select register assigns an interrupt generated by a specific interrupt flag from the TT interrupt register to one of the two module interrupt lines. For interrupt generation the respective interrupt line has to be enabled via FDCAN_ILE.EINT0 and FDCAN_ILE.EINT1.
  $12C constant FDCAN_FDCAN_TTOST       \ FDCAN TT operation status register
  $130 constant FDCAN_FDCAN_TURNA       \ There is no drift compensation in TTCAN level 1.
  $134 constant FDCAN_FDCAN_TTLGT       \ FDCAN TT local and global time register
  $138 constant FDCAN_FDCAN_TTCTC       \ FDCAN TT cycle time and count register
  $13C constant FDCAN_FDCAN_TTCPT       \ FDCAN TT capture time register
  $140 constant FDCAN_FDCAN_TTCSM       \ FDCAN TT cycle sync mark register
  $300 constant FDCAN_FDCAN_TTTS        \ The settings in the FDCAN_TTTS register select the input to be used as event trigger and stop watch trigger.

: FDCAN_DEF ; [then]
