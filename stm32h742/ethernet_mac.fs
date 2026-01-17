\
\ @file ethernet_mac.fs
\ @brief Ethernet: media access control (MAC)
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] ETHERNET_MAC_DEF

  [ifdef] ETHERNET_MAC_MACCR_DEF
    \
    \ @brief Operating mode configuration register
    \ Address offset: 0x00
    \ Reset value: 0x00000000
    \
    $00 constant ETHERNET_MAC_RE                \ [0x00] Receiver Enable
    $01 constant ETHERNET_MAC_TE                \ [0x01] TE
    $02 constant ETHERNET_MAC_PRELEN            \ [0x02 : 2] PRELEN
    $04 constant ETHERNET_MAC_DC                \ [0x04] DC
    $05 constant ETHERNET_MAC_BL                \ [0x05 : 2] BL
    $08 constant ETHERNET_MAC_DR                \ [0x08] DR
    $09 constant ETHERNET_MAC_DCRS              \ [0x09] DCRS
    $0a constant ETHERNET_MAC_DO                \ [0x0a] DO
    $0b constant ETHERNET_MAC_ECRSFD            \ [0x0b] ECRSFD
    $0c constant ETHERNET_MAC_LM                \ [0x0c] LM
    $0d constant ETHERNET_MAC_DM                \ [0x0d] DM
    $0e constant ETHERNET_MAC_FES               \ [0x0e] FES
    $10 constant ETHERNET_MAC_JE                \ [0x10] JE
    $11 constant ETHERNET_MAC_JD                \ [0x11] JD
    $13 constant ETHERNET_MAC_WD                \ [0x13] WD
    $14 constant ETHERNET_MAC_ACS               \ [0x14] ACS
    $15 constant ETHERNET_MAC_CST               \ [0x15] CST
    $16 constant ETHERNET_MAC_S2KP              \ [0x16] S2KP
    $17 constant ETHERNET_MAC_GPSLCE            \ [0x17] GPSLCE
    $18 constant ETHERNET_MAC_IPG               \ [0x18 : 3] IPG
    $1b constant ETHERNET_MAC_IPC               \ [0x1b] IPC
    $1c constant ETHERNET_MAC_SARC              \ [0x1c : 3] SARC
    $1f constant ETHERNET_MAC_ARPEN             \ [0x1f] ARPEN
  [then]


  [ifdef] ETHERNET_MAC_MACECR_DEF
    \
    \ @brief Extended operating mode configuration register
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $00 constant ETHERNET_MAC_GPSL              \ [0x00 : 14] GPSL
    $10 constant ETHERNET_MAC_DCRCC             \ [0x10] DCRCC
    $11 constant ETHERNET_MAC_SPEN              \ [0x11] SPEN
    $12 constant ETHERNET_MAC_USP               \ [0x12] USP
    $18 constant ETHERNET_MAC_EIPGEN            \ [0x18] EIPGEN
    $19 constant ETHERNET_MAC_EIPG              \ [0x19 : 5] EIPG
  [then]


  [ifdef] ETHERNET_MAC_MACPFR_DEF
    \
    \ @brief Packet filtering control register
    \ Address offset: 0x08
    \ Reset value: 0x00000000
    \
    $00 constant ETHERNET_MAC_PR                \ [0x00] PR
    $01 constant ETHERNET_MAC_HUC               \ [0x01] HUC
    $02 constant ETHERNET_MAC_HMC               \ [0x02] HMC
    $03 constant ETHERNET_MAC_DAIF              \ [0x03] DAIF
    $04 constant ETHERNET_MAC_PM                \ [0x04] PM
    $05 constant ETHERNET_MAC_DBF               \ [0x05] DBF
    $06 constant ETHERNET_MAC_PCF               \ [0x06 : 2] PCF
    $08 constant ETHERNET_MAC_SAIF              \ [0x08] SAIF
    $09 constant ETHERNET_MAC_SAF               \ [0x09] SAF
    $0a constant ETHERNET_MAC_HPF               \ [0x0a] HPF
    $10 constant ETHERNET_MAC_VTFE              \ [0x10] VTFE
    $14 constant ETHERNET_MAC_IPFE              \ [0x14] IPFE
    $15 constant ETHERNET_MAC_DNTU              \ [0x15] DNTU
    $1f constant ETHERNET_MAC_RA                \ [0x1f] RA
  [then]


  [ifdef] ETHERNET_MAC_MACWTR_DEF
    \
    \ @brief Watchdog timeout register
    \ Address offset: 0x0C
    \ Reset value: 0x00000000
    \
    $00 constant ETHERNET_MAC_WTO               \ [0x00 : 4] WTO
    $08 constant ETHERNET_MAC_PWE               \ [0x08] PWE
  [then]


  [ifdef] ETHERNET_MAC_MACHT0R_DEF
    \
    \ @brief Hash Table 0 register
    \ Address offset: 0x10
    \ Reset value: 0x00000000
    \
    $00 constant ETHERNET_MAC_HT31T0            \ [0x00 : 32] HT31T0
  [then]


  [ifdef] ETHERNET_MAC_MACHT1R_DEF
    \
    \ @brief Hash Table 1 register
    \ Address offset: 0x14
    \ Reset value: 0x00000000
    \
    $00 constant ETHERNET_MAC_HT63T32           \ [0x00 : 32] HT63T32
  [then]


  [ifdef] ETHERNET_MAC_MACVTR_DEF
    \
    \ @brief VLAN tag register
    \ Address offset: 0x50
    \ Reset value: 0x00000000
    \
    $00 constant ETHERNET_MAC_VL                \ [0x00 : 16] VL
    $10 constant ETHERNET_MAC_ETV               \ [0x10] ETV
    $11 constant ETHERNET_MAC_VTIM              \ [0x11] VTIM
    $12 constant ETHERNET_MAC_ESVL              \ [0x12] ESVL
    $13 constant ETHERNET_MAC_ERSVLM            \ [0x13] ERSVLM
    $14 constant ETHERNET_MAC_DOVLTC            \ [0x14] DOVLTC
    $15 constant ETHERNET_MAC_EVLS              \ [0x15 : 2] EVLS
    $18 constant ETHERNET_MAC_EVLRXS            \ [0x18] EVLRXS
    $19 constant ETHERNET_MAC_VTHM              \ [0x19] VTHM
    $1a constant ETHERNET_MAC_EDVLP             \ [0x1a] EDVLP
    $1b constant ETHERNET_MAC_ERIVLT            \ [0x1b] ERIVLT
    $1c constant ETHERNET_MAC_EIVLS             \ [0x1c : 2] EIVLS
    $1f constant ETHERNET_MAC_EIVLRXS           \ [0x1f] EIVLRXS
  [then]


  [ifdef] ETHERNET_MAC_MACVHTR_DEF
    \
    \ @brief VLAN Hash table register
    \ Address offset: 0x58
    \ Reset value: 0x00000000
    \
    $00 constant ETHERNET_MAC_VLHT              \ [0x00 : 16] VLHT
  [then]


  [ifdef] ETHERNET_MAC_MACVIR_DEF
    \
    \ @brief VLAN inclusion register
    \ Address offset: 0x60
    \ Reset value: 0x00000000
    \
    $00 constant ETHERNET_MAC_VLT               \ [0x00 : 16] VLT
    $10 constant ETHERNET_MAC_VLC               \ [0x10 : 2] VLC
    $12 constant ETHERNET_MAC_VLP               \ [0x12] VLP
    $13 constant ETHERNET_MAC_CSVL              \ [0x13] CSVL
    $14 constant ETHERNET_MAC_VLTI              \ [0x14] VLTI
  [then]


  [ifdef] ETHERNET_MAC_MACIVIR_DEF
    \
    \ @brief Inner VLAN inclusion register
    \ Address offset: 0x64
    \ Reset value: 0x00000000
    \
    $00 constant ETHERNET_MAC_VLT               \ [0x00 : 16] VLT
    $10 constant ETHERNET_MAC_VLC               \ [0x10 : 2] VLC
    $12 constant ETHERNET_MAC_VLP               \ [0x12] VLP
    $13 constant ETHERNET_MAC_CSVL              \ [0x13] CSVL
    $14 constant ETHERNET_MAC_VLTI              \ [0x14] VLTI
  [then]


  [ifdef] ETHERNET_MAC_MACQTxFCR_DEF
    \
    \ @brief Tx Queue flow control register
    \ Address offset: 0x70
    \ Reset value: 0x00000000
    \
    $00 constant ETHERNET_MAC_FCB_BPA           \ [0x00] FCB_BPA
    $01 constant ETHERNET_MAC_TFE               \ [0x01] TFE
    $04 constant ETHERNET_MAC_PLT               \ [0x04 : 3] PLT
    $07 constant ETHERNET_MAC_DZPQ              \ [0x07] DZPQ
    $10 constant ETHERNET_MAC_PT                \ [0x10 : 16] PT
  [then]


  [ifdef] ETHERNET_MAC_MACRxFCR_DEF
    \
    \ @brief Rx flow control register
    \ Address offset: 0x90
    \ Reset value: 0x00000000
    \
    $00 constant ETHERNET_MAC_RFE               \ [0x00] RFE
    $01 constant ETHERNET_MAC_UP                \ [0x01] UP
  [then]


  [ifdef] ETHERNET_MAC_MACISR_DEF
    \
    \ @brief Interrupt status register
    \ Address offset: 0xB0
    \ Reset value: 0x00000000
    \
    $03 constant ETHERNET_MAC_PHYIS             \ [0x03] PHYIS
    $04 constant ETHERNET_MAC_PMTIS             \ [0x04] PMTIS
    $05 constant ETHERNET_MAC_LPIIS             \ [0x05] LPIIS
    $08 constant ETHERNET_MAC_MMCIS             \ [0x08] MMCIS
    $09 constant ETHERNET_MAC_MMCRXIS           \ [0x09] MMCRXIS
    $0a constant ETHERNET_MAC_MMCTXIS           \ [0x0a] MMCTXIS
    $0c constant ETHERNET_MAC_TSIS              \ [0x0c] TSIS
    $0d constant ETHERNET_MAC_TXSTSIS           \ [0x0d] TXSTSIS
    $0e constant ETHERNET_MAC_RXSTSIS           \ [0x0e] RXSTSIS
  [then]


  [ifdef] ETHERNET_MAC_MACIER_DEF
    \
    \ @brief Interrupt enable register
    \ Address offset: 0xB4
    \ Reset value: 0x00000000
    \
    $03 constant ETHERNET_MAC_PHYIE             \ [0x03] PHYIE
    $04 constant ETHERNET_MAC_PMTIE             \ [0x04] PMTIE
    $05 constant ETHERNET_MAC_LPIIE             \ [0x05] LPIIE
    $0c constant ETHERNET_MAC_TSIE              \ [0x0c] TSIE
    $0d constant ETHERNET_MAC_TXSTSIE           \ [0x0d] TXSTSIE
    $0e constant ETHERNET_MAC_RXSTSIE           \ [0x0e] RXSTSIE
  [then]


  [ifdef] ETHERNET_MAC_MACRxTxSR_DEF
    \
    \ @brief Rx Tx status register
    \ Address offset: 0xB8
    \ Reset value: 0x00000000
    \
    $00 constant ETHERNET_MAC_TJT               \ [0x00] TJT
    $01 constant ETHERNET_MAC_NCARR             \ [0x01] NCARR
    $02 constant ETHERNET_MAC_LCARR             \ [0x02] LCARR
    $03 constant ETHERNET_MAC_EXDEF             \ [0x03] EXDEF
    $04 constant ETHERNET_MAC_LCOL              \ [0x04] LCOL
    $05 constant ETHERNET_MAC_EXCOL             \ [0x05] LCOL
    $08 constant ETHERNET_MAC_RWT               \ [0x08] RWT
  [then]


  [ifdef] ETHERNET_MAC_MACPCSR_DEF
    \
    \ @brief PMT control status register
    \ Address offset: 0xC0
    \ Reset value: 0x00000000
    \
    $00 constant ETHERNET_MAC_PWRDWN            \ [0x00] PWRDWN
    $01 constant ETHERNET_MAC_MGKPKTEN          \ [0x01] MGKPKTEN
    $02 constant ETHERNET_MAC_RWKPKTEN          \ [0x02] RWKPKTEN
    $05 constant ETHERNET_MAC_MGKPRCVD          \ [0x05] MGKPRCVD
    $06 constant ETHERNET_MAC_RWKPRCVD          \ [0x06] RWKPRCVD
    $09 constant ETHERNET_MAC_GLBLUCAST         \ [0x09] GLBLUCAST
    $0a constant ETHERNET_MAC_RWKPFE            \ [0x0a] RWKPFE
    $18 constant ETHERNET_MAC_RWKPTR            \ [0x18 : 5] RWKPTR
    $1f constant ETHERNET_MAC_RWKFILTRST        \ [0x1f] RWKFILTRST
  [then]


  [ifdef] ETHERNET_MAC_MACRWKPFR_DEF
    \
    \ @brief Remove wakeup packet filter register
    \ Address offset: 0xC4
    \ Reset value: 0x00000000
    \
    $00 constant ETHERNET_MAC_MACRWKPFR         \ [0x00 : 32] MACRWKPFR
  [then]


  [ifdef] ETHERNET_MAC_MACLCSR_DEF
    \
    \ @brief LPI control status register
    \ Address offset: 0xD0
    \ Reset value: 0x00000000
    \
    $00 constant ETHERNET_MAC_TLPIEN            \ [0x00] TLPIEN
    $01 constant ETHERNET_MAC_TLPIEX            \ [0x01] TLPIEX
    $02 constant ETHERNET_MAC_RLPIEN            \ [0x02] RLPIEN
    $03 constant ETHERNET_MAC_RLPIEX            \ [0x03] RLPIEX
    $08 constant ETHERNET_MAC_TLPIST            \ [0x08] TLPIST
    $09 constant ETHERNET_MAC_RLPIST            \ [0x09] RLPIST
    $10 constant ETHERNET_MAC_LPIEN             \ [0x10] LPIEN
    $11 constant ETHERNET_MAC_PLS               \ [0x11] PLS
    $12 constant ETHERNET_MAC_PLSEN             \ [0x12] PLSEN
    $13 constant ETHERNET_MAC_LPITXA            \ [0x13] LPITXA
    $14 constant ETHERNET_MAC_LPITE             \ [0x14] LPITE
  [then]


  [ifdef] ETHERNET_MAC_MACLTCR_DEF
    \
    \ @brief LPI timers control register
    \ Address offset: 0xD4
    \ Reset value: 0x03E80000
    \
    $00 constant ETHERNET_MAC_TWT               \ [0x00 : 16] TWT
    $10 constant ETHERNET_MAC_LST               \ [0x10 : 10] LST
  [then]


  [ifdef] ETHERNET_MAC_MACLETR_DEF
    \
    \ @brief LPI entry timer register
    \ Address offset: 0xD8
    \ Reset value: 0x00000000
    \
    $00 constant ETHERNET_MAC_LPIET             \ [0x00 : 17] LPIET
  [then]


  [ifdef] ETHERNET_MAC_MAC1USTCR_DEF
    \
    \ @brief 1-microsecond-tick counter register
    \ Address offset: 0xDC
    \ Reset value: 0x00000000
    \
    $00 constant ETHERNET_MAC_TIC_1US_CNTR      \ [0x00 : 12] TIC_1US_CNTR
  [then]


  [ifdef] ETHERNET_MAC_MACVR_DEF
    \
    \ @brief Version register
    \ Address offset: 0x110
    \ Reset value: 0x00003041
    \
    $00 constant ETHERNET_MAC_SNPSVER           \ [0x00 : 8] SNPSVER
    $08 constant ETHERNET_MAC_USERVER           \ [0x08 : 8] USERVER
  [then]


  [ifdef] ETHERNET_MAC_MACDR_DEF
    \
    \ @brief Debug register
    \ Address offset: 0x114
    \ Reset value: 0x00000000
    \
    $00 constant ETHERNET_MAC_RPESTS            \ [0x00] RPESTS
    $01 constant ETHERNET_MAC_RFCFCSTS          \ [0x01 : 2] RFCFCSTS
    $10 constant ETHERNET_MAC_TPESTS            \ [0x10] TPESTS
    $11 constant ETHERNET_MAC_TFCSTS            \ [0x11 : 2] TFCSTS
  [then]


  [ifdef] ETHERNET_MAC_MACHWF1R_DEF
    \
    \ @brief HW feature 1 register
    \ Address offset: 0x120
    \ Reset value: 0x11841904
    \
    $00 constant ETHERNET_MAC_RXFIFOSIZE        \ [0x00 : 5] RXFIFOSIZE
    $06 constant ETHERNET_MAC_TXFIFOSIZE        \ [0x06 : 5] TXFIFOSIZE
    $0b constant ETHERNET_MAC_OSTEN             \ [0x0b] OSTEN
    $0c constant ETHERNET_MAC_PTOEN             \ [0x0c] PTOEN
    $0d constant ETHERNET_MAC_ADVTHWORD         \ [0x0d] ADVTHWORD
    $0e constant ETHERNET_MAC_ADDR64            \ [0x0e : 2] ADDR64
    $10 constant ETHERNET_MAC_DCBEN             \ [0x10] DCBEN
    $11 constant ETHERNET_MAC_SPHEN             \ [0x11] SPHEN
    $12 constant ETHERNET_MAC_TSOEN             \ [0x12] TSOEN
    $13 constant ETHERNET_MAC_DBGMEMA           \ [0x13] DBGMEMA
    $14 constant ETHERNET_MAC_AVSEL             \ [0x14] AVSEL
    $18 constant ETHERNET_MAC_HASHTBLSZ         \ [0x18 : 2] HASHTBLSZ
    $1b constant ETHERNET_MAC_L3L4FNUM          \ [0x1b : 4] L3L4FNUM
  [then]


  [ifdef] ETHERNET_MAC_MACHWF2R_DEF
    \
    \ @brief HW feature 2 register
    \ Address offset: 0x124
    \ Reset value: 0x41000000
    \
    $00 constant ETHERNET_MAC_RXQCNT            \ [0x00 : 4] RXQCNT
    $06 constant ETHERNET_MAC_TXQCNT            \ [0x06 : 4] TXQCNT
    $0c constant ETHERNET_MAC_RXCHCNT           \ [0x0c : 4] RXCHCNT
    $12 constant ETHERNET_MAC_TXCHCNT           \ [0x12 : 4] TXCHCNT
    $18 constant ETHERNET_MAC_PPSOUTNUM         \ [0x18 : 3] PPSOUTNUM
    $1c constant ETHERNET_MAC_AUXSNAPNUM        \ [0x1c : 3] AUXSNAPNUM
  [then]


  [ifdef] ETHERNET_MAC_MACMDIOAR_DEF
    \
    \ @brief MDIO address register
    \ Address offset: 0x200
    \ Reset value: 0x00000000
    \
    $00 constant ETHERNET_MAC_MB                \ [0x00] MB
    $01 constant ETHERNET_MAC_C45E              \ [0x01] C45E
    $02 constant ETHERNET_MAC_GOC               \ [0x02 : 2] GOC
    $04 constant ETHERNET_MAC_SKAP              \ [0x04] SKAP
    $08 constant ETHERNET_MAC_CR                \ [0x08 : 4] CR
    $0c constant ETHERNET_MAC_NTC               \ [0x0c : 3] NTC
    $10 constant ETHERNET_MAC_RDA               \ [0x10 : 5] RDA
    $15 constant ETHERNET_MAC_PA                \ [0x15 : 5] PA
    $1a constant ETHERNET_MAC_BTB               \ [0x1a] BTB
    $1b constant ETHERNET_MAC_PSE               \ [0x1b] PSE
  [then]


  [ifdef] ETHERNET_MAC_MACMDIODR_DEF
    \
    \ @brief MDIO data register
    \ Address offset: 0x204
    \ Reset value: 0x00000000
    \
    $00 constant ETHERNET_MAC_MD                \ [0x00 : 16] MD
    $10 constant ETHERNET_MAC_RA                \ [0x10 : 16] RA
  [then]


  [ifdef] ETHERNET_MAC_MACA0HR_DEF
    \
    \ @brief Address 0 high register
    \ Address offset: 0x300
    \ Reset value: 0x8000FFFF
    \
    $00 constant ETHERNET_MAC_ADDRHI            \ [0x00 : 16] ADDRHI
    $1f constant ETHERNET_MAC_AE                \ [0x1f] AE
  [then]


  [ifdef] ETHERNET_MAC_MACA0LR_DEF
    \
    \ @brief Address 0 low register
    \ Address offset: 0x304
    \ Reset value: 0xFFFFFFFF
    \
    $00 constant ETHERNET_MAC_ADDRLO            \ [0x00 : 32] ADDRLO
  [then]


  [ifdef] ETHERNET_MAC_MACA1HR_DEF
    \
    \ @brief Address 1 high register
    \ Address offset: 0x308
    \ Reset value: 0x0000FFFF
    \
    $00 constant ETHERNET_MAC_ADDRHI            \ [0x00 : 16] ADDRHI
    $18 constant ETHERNET_MAC_MBC               \ [0x18 : 6] MBC
    $1e constant ETHERNET_MAC_SA                \ [0x1e] SA
    $1f constant ETHERNET_MAC_AE                \ [0x1f] AE
  [then]


  [ifdef] ETHERNET_MAC_MACA1LR_DEF
    \
    \ @brief Address 1 low register
    \ Address offset: 0x30C
    \ Reset value: 0xFFFFFFFF
    \
    $00 constant ETHERNET_MAC_ADDRLO            \ [0x00 : 32] ADDRLO
  [then]


  [ifdef] ETHERNET_MAC_MACA2HR_DEF
    \
    \ @brief Address 2 high register
    \ Address offset: 0x310
    \ Reset value: 0x0000FFFF
    \
    $00 constant ETHERNET_MAC_ADDRHI            \ [0x00 : 16] ADDRHI
    $18 constant ETHERNET_MAC_MBC               \ [0x18 : 6] MBC
    $1e constant ETHERNET_MAC_SA                \ [0x1e] SA
    $1f constant ETHERNET_MAC_AE                \ [0x1f] AE
  [then]


  [ifdef] ETHERNET_MAC_MACA2LR_DEF
    \
    \ @brief Address 2 low register
    \ Address offset: 0x314
    \ Reset value: 0xFFFFFFFF
    \
    $00 constant ETHERNET_MAC_ADDRLO            \ [0x00 : 32] ADDRLO
  [then]


  [ifdef] ETHERNET_MAC_MACA3HR_DEF
    \
    \ @brief Address 3 high register
    \ Address offset: 0x318
    \ Reset value: 0x0000FFFF
    \
    $00 constant ETHERNET_MAC_ADDRHI            \ [0x00 : 16] ADDRHI
    $18 constant ETHERNET_MAC_MBC               \ [0x18 : 6] MBC
    $1e constant ETHERNET_MAC_SA                \ [0x1e] SA
    $1f constant ETHERNET_MAC_AE                \ [0x1f] AE
  [then]


  [ifdef] ETHERNET_MAC_MACA3LR_DEF
    \
    \ @brief Address 3 low register
    \ Address offset: 0x31C
    \ Reset value: 0xFFFFFFFF
    \
    $00 constant ETHERNET_MAC_ADDRLO            \ [0x00 : 32] ADDRLO
  [then]


  [ifdef] ETHERNET_MAC_MMC_CONTROL_DEF
    \
    \ @brief MMC control register
    \ Address offset: 0x700
    \ Reset value: 0x00000000
    \
    $00 constant ETHERNET_MAC_CNTRST            \ [0x00] CNTRST
    $01 constant ETHERNET_MAC_CNTSTOPRO         \ [0x01] CNTSTOPRO
    $02 constant ETHERNET_MAC_RSTONRD           \ [0x02] RSTONRD
    $03 constant ETHERNET_MAC_CNTFREEZ          \ [0x03] CNTFREEZ
    $04 constant ETHERNET_MAC_CNTPRST           \ [0x04] CNTPRST
    $05 constant ETHERNET_MAC_CNTPRSTLVL        \ [0x05] CNTPRSTLVL
    $08 constant ETHERNET_MAC_UCDBC             \ [0x08] UCDBC
  [then]


  [ifdef] ETHERNET_MAC_MMC_RX_INTERRUPT_DEF
    \
    \ @brief MMC Rx interrupt register
    \ Address offset: 0x704
    \ Reset value: 0x00000000
    \
    $05 constant ETHERNET_MAC_RXCRCERPIS        \ [0x05] RXCRCERPIS
    $06 constant ETHERNET_MAC_RXALGNERPIS       \ [0x06] RXALGNERPIS
    $11 constant ETHERNET_MAC_RXUCGPIS          \ [0x11] RXUCGPIS
    $1a constant ETHERNET_MAC_RXLPIUSCIS        \ [0x1a] RXLPIUSCIS
    $1b constant ETHERNET_MAC_RXLPITRCIS        \ [0x1b] RXLPITRCIS
  [then]


  [ifdef] ETHERNET_MAC_MMC_TX_INTERRUPT_DEF
    \
    \ @brief MMC Tx interrupt register
    \ Address offset: 0x708
    \ Reset value: 0x00000000
    \
    $0e constant ETHERNET_MAC_TXSCOLGPIS        \ [0x0e] TXSCOLGPIS
    $0f constant ETHERNET_MAC_TXMCOLGPIS        \ [0x0f] TXMCOLGPIS
    $15 constant ETHERNET_MAC_TXGPKTIS          \ [0x15] TXGPKTIS
    $1a constant ETHERNET_MAC_TXLPIUSCIS        \ [0x1a] TXLPIUSCIS
    $1b constant ETHERNET_MAC_TXLPITRCIS        \ [0x1b] TXLPITRCIS
  [then]


  [ifdef] ETHERNET_MAC_MMC_RX_INTERRUPT_MASK_DEF
    \
    \ @brief MMC Rx interrupt mask register
    \ Address offset: 0x70C
    \ Reset value: 0x00000000
    \
    $05 constant ETHERNET_MAC_RXCRCERPIM        \ [0x05] RXCRCERPIM
    $06 constant ETHERNET_MAC_RXALGNERPIM       \ [0x06] RXALGNERPIM
    $11 constant ETHERNET_MAC_RXUCGPIM          \ [0x11] RXUCGPIM
    $1a constant ETHERNET_MAC_RXLPIUSCIM        \ [0x1a] RXLPIUSCIM
    $1b constant ETHERNET_MAC_RXLPITRCIM        \ [0x1b] RXLPITRCIM
  [then]


  [ifdef] ETHERNET_MAC_MMC_TX_INTERRUPT_MASK_DEF
    \
    \ @brief MMC Tx interrupt mask register
    \ Address offset: 0x710
    \ Reset value: 0x00000000
    \
    $0e constant ETHERNET_MAC_TXSCOLGPIM        \ [0x0e] TXSCOLGPIM
    $0f constant ETHERNET_MAC_TXMCOLGPIM        \ [0x0f] TXMCOLGPIM
    $15 constant ETHERNET_MAC_TXGPKTIM          \ [0x15] TXGPKTIM
    $1a constant ETHERNET_MAC_TXLPIUSCIM        \ [0x1a] TXLPIUSCIM
    $1b constant ETHERNET_MAC_TXLPITRCIM        \ [0x1b] TXLPITRCIM
  [then]


  [ifdef] ETHERNET_MAC_TX_SINGLE_COLLISION_GOOD_PACKETS_DEF
    \
    \ @brief Tx single collision good packets register
    \ Address offset: 0x74C
    \ Reset value: 0x00000000
    \
    $00 constant ETHERNET_MAC_TXSNGLCOLG        \ [0x00 : 32] TXSNGLCOLG
  [then]


  [ifdef] ETHERNET_MAC_TX_MULTIPLE_COLLISION_GOOD_PACKETS_DEF
    \
    \ @brief Tx multiple collision good packets register
    \ Address offset: 0x750
    \ Reset value: 0x00000000
    \
    $00 constant ETHERNET_MAC_TXMULTCOLG        \ [0x00 : 32] TXMULTCOLG
  [then]


  [ifdef] ETHERNET_MAC_TX_PACKET_COUNT_GOOD_DEF
    \
    \ @brief Tx packet count good register
    \ Address offset: 0x768
    \ Reset value: 0x00000000
    \
    $00 constant ETHERNET_MAC_TXPKTG            \ [0x00 : 32] TXPKTG
  [then]


  [ifdef] ETHERNET_MAC_RX_CRC_ERROR_PACKETS_DEF
    \
    \ @brief Rx CRC error packets register
    \ Address offset: 0x794
    \ Reset value: 0x00000000
    \
    $00 constant ETHERNET_MAC_RXCRCERR          \ [0x00 : 32] RXCRCERR
  [then]


  [ifdef] ETHERNET_MAC_RX_ALIGNMENT_ERROR_PACKETS_DEF
    \
    \ @brief Rx alignment error packets register
    \ Address offset: 0x798
    \ Reset value: 0x00000000
    \
    $00 constant ETHERNET_MAC_RXALGNERR         \ [0x00 : 32] RXALGNERR
  [then]


  [ifdef] ETHERNET_MAC_RX_UNICAST_PACKETS_GOOD_DEF
    \
    \ @brief Rx unicast packets good register
    \ Address offset: 0x7C4
    \ Reset value: 0x00000000
    \
    $00 constant ETHERNET_MAC_RXUCASTG          \ [0x00 : 32] RXUCASTG
  [then]


  [ifdef] ETHERNET_MAC_TX_LPI_USEC_CNTR_DEF
    \
    \ @brief Tx LPI microsecond timer register
    \ Address offset: 0x7EC
    \ Reset value: 0x00000000
    \
    $00 constant ETHERNET_MAC_TXLPIUSC          \ [0x00 : 32] TXLPIUSC
  [then]


  [ifdef] ETHERNET_MAC_TX_LPI_TRAN_CNTR_DEF
    \
    \ @brief Tx LPI transition counter register
    \ Address offset: 0x7F0
    \ Reset value: 0x00000000
    \
    $00 constant ETHERNET_MAC_TXLPITRC          \ [0x00 : 32] TXLPITRC
  [then]


  [ifdef] ETHERNET_MAC_RX_LPI_USEC_CNTR_DEF
    \
    \ @brief Rx LPI microsecond counter register
    \ Address offset: 0x7F4
    \ Reset value: 0x00000000
    \
    $00 constant ETHERNET_MAC_RXLPIUSC          \ [0x00 : 32] RXLPIUSC
  [then]


  [ifdef] ETHERNET_MAC_RX_LPI_TRAN_CNTR_DEF
    \
    \ @brief Rx LPI transition counter register
    \ Address offset: 0x7F8
    \ Reset value: 0x00000000
    \
    $00 constant ETHERNET_MAC_RXLPITRC          \ [0x00 : 32] RXLPITRC
  [then]


  [ifdef] ETHERNET_MAC_MACL3L4C0R_DEF
    \
    \ @brief L3 and L4 control 0 register
    \ Address offset: 0x900
    \ Reset value: 0x00000000
    \
    $00 constant ETHERNET_MAC_L3PEN0            \ [0x00] L3PEN0
    $02 constant ETHERNET_MAC_L3SAM0            \ [0x02] L3SAM0
    $03 constant ETHERNET_MAC_L3SAIM0           \ [0x03] L3SAIM0
    $04 constant ETHERNET_MAC_L3DAM0            \ [0x04] L3DAM0
    $05 constant ETHERNET_MAC_L3DAIM0           \ [0x05] L3DAIM0
    $06 constant ETHERNET_MAC_L3HSBM0           \ [0x06 : 5] L3HSBM0
    $0b constant ETHERNET_MAC_L3HDBM0           \ [0x0b : 5] L3HDBM0
    $10 constant ETHERNET_MAC_L4PEN0            \ [0x10] L4PEN0
    $12 constant ETHERNET_MAC_L4SPM0            \ [0x12] L4SPM0
    $13 constant ETHERNET_MAC_L4SPIM0           \ [0x13] L4SPIM0
    $14 constant ETHERNET_MAC_L4DPM0            \ [0x14] L4DPM0
    $15 constant ETHERNET_MAC_L4DPIM0           \ [0x15] L4DPIM0
  [then]


  [ifdef] ETHERNET_MAC_MACL4A0R_DEF
    \
    \ @brief Layer4 address filter 0 register
    \ Address offset: 0x904
    \ Reset value: 0x00000000
    \
    $00 constant ETHERNET_MAC_L4SP0             \ [0x00 : 16] L4SP0
    $10 constant ETHERNET_MAC_L4DP0             \ [0x10 : 16] L4DP0
  [then]


  [ifdef] ETHERNET_MAC_MACL3A00R_DEF
    \
    \ @brief MACL3A00R
    \ Address offset: 0x910
    \ Reset value: 0x00000000
    \
    $00 constant ETHERNET_MAC_L3A00             \ [0x00 : 32] L3A00
  [then]


  [ifdef] ETHERNET_MAC_MACL3A10R_DEF
    \
    \ @brief Layer3 address 1 filter 0 register
    \ Address offset: 0x914
    \ Reset value: 0x00000000
    \
    $00 constant ETHERNET_MAC_L3A10             \ [0x00 : 32] L3A10
  [then]


  [ifdef] ETHERNET_MAC_MACL3A20_DEF
    \
    \ @brief Layer3 Address 2 filter 0 register
    \ Address offset: 0x918
    \ Reset value: 0x00000000
    \
    $00 constant ETHERNET_MAC_L3A20             \ [0x00 : 32] L3A20
  [then]


  [ifdef] ETHERNET_MAC_MACL3A30_DEF
    \
    \ @brief Layer3 Address 3 filter 0 register
    \ Address offset: 0x91C
    \ Reset value: 0x00000000
    \
    $00 constant ETHERNET_MAC_L3A30             \ [0x00 : 32] L3A30
  [then]


  [ifdef] ETHERNET_MAC_MACL3L4C1R_DEF
    \
    \ @brief L3 and L4 control 1 register
    \ Address offset: 0x930
    \ Reset value: 0x00000000
    \
    $00 constant ETHERNET_MAC_L3PEN1            \ [0x00] L3PEN1
    $02 constant ETHERNET_MAC_L3SAM1            \ [0x02] L3SAM1
    $03 constant ETHERNET_MAC_L3SAIM1           \ [0x03] L3SAIM1
    $04 constant ETHERNET_MAC_L3DAM1            \ [0x04] L3DAM1
    $05 constant ETHERNET_MAC_L3DAIM1           \ [0x05] L3DAIM1
    $06 constant ETHERNET_MAC_L3HSBM1           \ [0x06 : 5] L3HSBM1
    $0b constant ETHERNET_MAC_L3HDBM1           \ [0x0b : 5] L3HDBM1
    $10 constant ETHERNET_MAC_L4PEN1            \ [0x10] L4PEN1
    $12 constant ETHERNET_MAC_L4SPM1            \ [0x12] L4SPM1
    $13 constant ETHERNET_MAC_L4SPIM1           \ [0x13] L4SPIM1
    $14 constant ETHERNET_MAC_L4DPM1            \ [0x14] L4DPM1
    $15 constant ETHERNET_MAC_L4DPIM1           \ [0x15] L4DPIM1
  [then]


  [ifdef] ETHERNET_MAC_MACL4A1R_DEF
    \
    \ @brief Layer 4 address filter 1 register
    \ Address offset: 0x934
    \ Reset value: 0x00000000
    \
    $00 constant ETHERNET_MAC_L4SP1             \ [0x00 : 16] L4SP1
    $10 constant ETHERNET_MAC_L4DP1             \ [0x10 : 16] L4DP1
  [then]


  [ifdef] ETHERNET_MAC_MACL3A01R_DEF
    \
    \ @brief Layer3 address 0 filter 1 Register
    \ Address offset: 0x940
    \ Reset value: 0x00000000
    \
    $00 constant ETHERNET_MAC_L3A01             \ [0x00 : 32] L3A01
  [then]


  [ifdef] ETHERNET_MAC_MACL3A11R_DEF
    \
    \ @brief Layer3 address 1 filter 1 register
    \ Address offset: 0x944
    \ Reset value: 0x00000000
    \
    $00 constant ETHERNET_MAC_L3A11             \ [0x00 : 32] L3A11
  [then]


  [ifdef] ETHERNET_MAC_MACL3A21R_DEF
    \
    \ @brief Layer3 address 2 filter 1 Register
    \ Address offset: 0x948
    \ Reset value: 0x00000000
    \
    $00 constant ETHERNET_MAC_L3A21             \ [0x00 : 32] L3A21
  [then]


  [ifdef] ETHERNET_MAC_MACL3A31R_DEF
    \
    \ @brief Layer3 address 3 filter 1 register
    \ Address offset: 0x94C
    \ Reset value: 0x00000000
    \
    $00 constant ETHERNET_MAC_L3A31             \ [0x00 : 32] L3A31
  [then]


  [ifdef] ETHERNET_MAC_MACARPAR_DEF
    \
    \ @brief ARP address register
    \ Address offset: 0xAE0
    \ Reset value: 0x00000000
    \
    $00 constant ETHERNET_MAC_ARPPA             \ [0x00 : 32] ARPPA
  [then]


  [ifdef] ETHERNET_MAC_MACTSCR_DEF
    \
    \ @brief Timestamp control Register
    \ Address offset: 0xB00
    \ Reset value: 0x00000200
    \
    $00 constant ETHERNET_MAC_TSENA             \ [0x00] TSENA
    $01 constant ETHERNET_MAC_TSCFUPDT          \ [0x01] TSCFUPDT
    $02 constant ETHERNET_MAC_TSINIT            \ [0x02] TSINIT
    $03 constant ETHERNET_MAC_TSUPDT            \ [0x03] TSUPDT
    $05 constant ETHERNET_MAC_TSADDREG          \ [0x05] TSADDREG
    $08 constant ETHERNET_MAC_TSENALL           \ [0x08] TSENALL
    $09 constant ETHERNET_MAC_TSCTRLSSR         \ [0x09] TSCTRLSSR
    $0a constant ETHERNET_MAC_TSVER2ENA         \ [0x0a] TSVER2ENA
    $0b constant ETHERNET_MAC_TSIPENA           \ [0x0b] TSIPENA
    $0c constant ETHERNET_MAC_TSIPV6ENA         \ [0x0c] TSIPV6ENA
    $0d constant ETHERNET_MAC_TSIPV4ENA         \ [0x0d] TSIPV4ENA
    $0e constant ETHERNET_MAC_TSEVNTENA         \ [0x0e] TSEVNTENA
    $0f constant ETHERNET_MAC_TSMSTRENA         \ [0x0f] TSMSTRENA
    $10 constant ETHERNET_MAC_SNAPTYPSEL        \ [0x10 : 2] SNAPTYPSEL
    $12 constant ETHERNET_MAC_TSENMACADDR       \ [0x12] TSENMACADDR
    $13 constant ETHERNET_MAC_CSC               \ [0x13] CSC
    $18 constant ETHERNET_MAC_TXTSSTSM          \ [0x18] TXTSSTSM
  [then]


  [ifdef] ETHERNET_MAC_MACSSIR_DEF
    \
    \ @brief Sub-second increment register
    \ Address offset: 0xB04
    \ Reset value: 0x00000000
    \
    $08 constant ETHERNET_MAC_SNSINC            \ [0x08 : 8] SNSINC
    $10 constant ETHERNET_MAC_SSINC             \ [0x10 : 8] SSINC
  [then]


  [ifdef] ETHERNET_MAC_MACSTSR_DEF
    \
    \ @brief System time seconds register
    \ Address offset: 0xB08
    \ Reset value: 0x00000000
    \
    $00 constant ETHERNET_MAC_TSS               \ [0x00 : 32] TSS
  [then]


  [ifdef] ETHERNET_MAC_MACSTNR_DEF
    \
    \ @brief System time nanoseconds register
    \ Address offset: 0xB0C
    \ Reset value: 0x00000000
    \
    $00 constant ETHERNET_MAC_TSSS              \ [0x00 : 31] TSSS
  [then]


  [ifdef] ETHERNET_MAC_MACSTSUR_DEF
    \
    \ @brief System time seconds update register
    \ Address offset: 0xB10
    \ Reset value: 0x00000000
    \
    $00 constant ETHERNET_MAC_TSS               \ [0x00 : 32] TSS
  [then]


  [ifdef] ETHERNET_MAC_MACSTNUR_DEF
    \
    \ @brief System time nanoseconds update register
    \ Address offset: 0xB14
    \ Reset value: 0x00000000
    \
    $00 constant ETHERNET_MAC_TSSS              \ [0x00 : 31] TSSS
    $1f constant ETHERNET_MAC_ADDSUB            \ [0x1f] ADDSUB
  [then]


  [ifdef] ETHERNET_MAC_MACTSAR_DEF
    \
    \ @brief Timestamp addend register
    \ Address offset: 0xB18
    \ Reset value: 0x00000000
    \
    $00 constant ETHERNET_MAC_TSAR              \ [0x00 : 32] TSAR
  [then]


  [ifdef] ETHERNET_MAC_MACTSSR_DEF
    \
    \ @brief Timestamp status register
    \ Address offset: 0xB20
    \ Reset value: 0x00000000
    \
    $00 constant ETHERNET_MAC_TSSOVF            \ [0x00] TSSOVF
    $01 constant ETHERNET_MAC_TSTARGT0          \ [0x01] TSTARGT0
    $02 constant ETHERNET_MAC_AUXTSTRIG         \ [0x02] AUXTSTRIG
    $03 constant ETHERNET_MAC_TSTRGTERR0        \ [0x03] TSTRGTERR0
    $0f constant ETHERNET_MAC_TXTSSIS           \ [0x0f] TXTSSIS
    $10 constant ETHERNET_MAC_ATSSTN            \ [0x10 : 4] ATSSTN
    $18 constant ETHERNET_MAC_ATSSTM            \ [0x18] ATSSTM
    $19 constant ETHERNET_MAC_ATSNS             \ [0x19 : 5] ATSNS
  [then]


  [ifdef] ETHERNET_MAC_MACTxTSSNR_DEF
    \
    \ @brief Tx timestamp status nanoseconds register
    \ Address offset: 0xB30
    \ Reset value: 0x00000000
    \
    $00 constant ETHERNET_MAC_TXTSSLO           \ [0x00 : 31] TXTSSLO
    $1f constant ETHERNET_MAC_TXTSSMIS          \ [0x1f] TXTSSMIS
  [then]


  [ifdef] ETHERNET_MAC_MACTxTSSSR_DEF
    \
    \ @brief Tx timestamp status seconds register
    \ Address offset: 0xB34
    \ Reset value: 0x00000000
    \
    $00 constant ETHERNET_MAC_TXTSSHI           \ [0x00 : 32] TXTSSHI
  [then]


  [ifdef] ETHERNET_MAC_MACACR_DEF
    \
    \ @brief Auxiliary control register
    \ Address offset: 0xB40
    \ Reset value: 0x00000000
    \
    $00 constant ETHERNET_MAC_ATSFC             \ [0x00] ATSFC
    $04 constant ETHERNET_MAC_ATSEN0            \ [0x04] ATSEN0
    $05 constant ETHERNET_MAC_ATSEN1            \ [0x05] ATSEN1
    $06 constant ETHERNET_MAC_ATSEN2            \ [0x06] ATSEN2
    $07 constant ETHERNET_MAC_ATSEN3            \ [0x07] ATSEN3
  [then]


  [ifdef] ETHERNET_MAC_MACATSNR_DEF
    \
    \ @brief Auxiliary timestamp nanoseconds register
    \ Address offset: 0xB48
    \ Reset value: 0x00000000
    \
    $00 constant ETHERNET_MAC_AUXTSLO           \ [0x00 : 31] AUXTSLO
  [then]


  [ifdef] ETHERNET_MAC_MACATSSR_DEF
    \
    \ @brief Auxiliary timestamp seconds register
    \ Address offset: 0xB4C
    \ Reset value: 0x00000000
    \
    $00 constant ETHERNET_MAC_AUXTSHI           \ [0x00 : 32] AUXTSHI
  [then]


  [ifdef] ETHERNET_MAC_MACTSIACR_DEF
    \
    \ @brief Timestamp Ingress asymmetric correction register
    \ Address offset: 0xB50
    \ Reset value: 0x00000000
    \
    $00 constant ETHERNET_MAC_OSTIAC            \ [0x00 : 32] OSTIAC
  [then]


  [ifdef] ETHERNET_MAC_MACTSEACR_DEF
    \
    \ @brief Timestamp Egress asymmetric correction register
    \ Address offset: 0xB54
    \ Reset value: 0x00000000
    \
    $00 constant ETHERNET_MAC_OSTEAC            \ [0x00 : 32] OSTEAC
  [then]


  [ifdef] ETHERNET_MAC_MACTSICNR_DEF
    \
    \ @brief Timestamp Ingress correction nanosecond register
    \ Address offset: 0xB58
    \ Reset value: 0x00000000
    \
    $00 constant ETHERNET_MAC_TSIC              \ [0x00 : 32] TSIC
  [then]


  [ifdef] ETHERNET_MAC_MACTSECNR_DEF
    \
    \ @brief Timestamp Egress correction nanosecond register
    \ Address offset: 0xB5C
    \ Reset value: 0x00000000
    \
    $00 constant ETHERNET_MAC_TSEC              \ [0x00 : 32] TSEC
  [then]


  [ifdef] ETHERNET_MAC_MACPPSCR_DEF
    \
    \ @brief PPS control register
    \ Address offset: 0xB70
    \ Reset value: 0x00000000
    \
    $00 constant ETHERNET_MAC_PPSCTRL           \ [0x00 : 4] PPSCTRL
    $04 constant ETHERNET_MAC_PPSEN0            \ [0x04] PPSEN0
    $05 constant ETHERNET_MAC_TRGTMODSEL0       \ [0x05 : 2] TRGTMODSEL0
  [then]


  [ifdef] ETHERNET_MAC_MACPPSTTSR_DEF
    \
    \ @brief PPS target time seconds register
    \ Address offset: 0xB80
    \ Reset value: 0x00000000
    \
    $00 constant ETHERNET_MAC_TSTRH0            \ [0x00 : 31] TSTRH0
  [then]


  [ifdef] ETHERNET_MAC_MACPPSTTNR_DEF
    \
    \ @brief PPS target time nanoseconds register
    \ Address offset: 0xB84
    \ Reset value: 0x00000000
    \
    $00 constant ETHERNET_MAC_TTSL0             \ [0x00 : 31] TTSL0
    $1f constant ETHERNET_MAC_TRGTBUSY0         \ [0x1f] TRGTBUSY0
  [then]


  [ifdef] ETHERNET_MAC_MACPPSIR_DEF
    \
    \ @brief PPS interval register
    \ Address offset: 0xB88
    \ Reset value: 0x00000000
    \
    $00 constant ETHERNET_MAC_PPSINT0           \ [0x00 : 32] PPSINT0
  [then]


  [ifdef] ETHERNET_MAC_MACPPSWR_DEF
    \
    \ @brief PPS width register
    \ Address offset: 0xB8C
    \ Reset value: 0x00000000
    \
    $00 constant ETHERNET_MAC_PPSWIDTH0         \ [0x00 : 32] PPSWIDTH0
  [then]


  [ifdef] ETHERNET_MAC_MACPOCR_DEF
    \
    \ @brief PTP Offload control register
    \ Address offset: 0xBC0
    \ Reset value: 0x00000000
    \
    $00 constant ETHERNET_MAC_PTOEN             \ [0x00] PTOEN
    $01 constant ETHERNET_MAC_ASYNCEN           \ [0x01] ASYNCEN
    $02 constant ETHERNET_MAC_APDREQEN          \ [0x02] APDREQEN
    $04 constant ETHERNET_MAC_ASYNCTRIG         \ [0x04] ASYNCTRIG
    $05 constant ETHERNET_MAC_APDREQTRIG        \ [0x05] APDREQTRIG
    $06 constant ETHERNET_MAC_DRRDIS            \ [0x06] DRRDIS
    $08 constant ETHERNET_MAC_DN                \ [0x08 : 8] DN
  [then]


  [ifdef] ETHERNET_MAC_MACSPI0R_DEF
    \
    \ @brief PTP Source Port Identity 0 Register
    \ Address offset: 0xBC4
    \ Reset value: 0x00000000
    \
    $00 constant ETHERNET_MAC_SPI0              \ [0x00 : 32] SPI0
  [then]


  [ifdef] ETHERNET_MAC_MACSPI1R_DEF
    \
    \ @brief PTP Source port identity 1 register
    \ Address offset: 0xBC8
    \ Reset value: 0x00000000
    \
    $00 constant ETHERNET_MAC_SPI1              \ [0x00 : 32] SPI1
  [then]


  [ifdef] ETHERNET_MAC_MACSPI2R_DEF
    \
    \ @brief PTP Source port identity 2 register
    \ Address offset: 0xBCC
    \ Reset value: 0x00000000
    \
    $00 constant ETHERNET_MAC_SPI2              \ [0x00 : 16] SPI2
  [then]


  [ifdef] ETHERNET_MAC_MACLMIR_DEF
    \
    \ @brief Log message interval register
    \ Address offset: 0xBD0
    \ Reset value: 0x00000000
    \
    $00 constant ETHERNET_MAC_LSI               \ [0x00 : 8] LSI
    $08 constant ETHERNET_MAC_DRSYNCR           \ [0x08 : 3] DRSYNCR
    $18 constant ETHERNET_MAC_LMPDRI            \ [0x18 : 8] LMPDRI
  [then]

  \
  \ @brief Ethernet: media access control (MAC)
  \
  $00 constant ETHERNET_MAC_MACCR       \ Operating mode configuration register
  $04 constant ETHERNET_MAC_MACECR      \ Extended operating mode configuration register
  $08 constant ETHERNET_MAC_MACPFR      \ Packet filtering control register
  $0C constant ETHERNET_MAC_MACWTR      \ Watchdog timeout register
  $10 constant ETHERNET_MAC_MACHT0R     \ Hash Table 0 register
  $14 constant ETHERNET_MAC_MACHT1R     \ Hash Table 1 register
  $50 constant ETHERNET_MAC_MACVTR      \ VLAN tag register
  $58 constant ETHERNET_MAC_MACVHTR     \ VLAN Hash table register
  $60 constant ETHERNET_MAC_MACVIR      \ VLAN inclusion register
  $64 constant ETHERNET_MAC_MACIVIR     \ Inner VLAN inclusion register
  $70 constant ETHERNET_MAC_MACQTXFCR   \ Tx Queue flow control register
  $90 constant ETHERNET_MAC_MACRXFCR    \ Rx flow control register
  $B0 constant ETHERNET_MAC_MACISR      \ Interrupt status register
  $B4 constant ETHERNET_MAC_MACIER      \ Interrupt enable register
  $B8 constant ETHERNET_MAC_MACRXTXSR   \ Rx Tx status register
  $C0 constant ETHERNET_MAC_MACPCSR     \ PMT control status register
  $C4 constant ETHERNET_MAC_MACRWKPFR   \ Remove wakeup packet filter register
  $D0 constant ETHERNET_MAC_MACLCSR     \ LPI control status register
  $D4 constant ETHERNET_MAC_MACLTCR     \ LPI timers control register
  $D8 constant ETHERNET_MAC_MACLETR     \ LPI entry timer register
  $DC constant ETHERNET_MAC_MAC1USTCR   \ 1-microsecond-tick counter register
  $110 constant ETHERNET_MAC_MACVR      \ Version register
  $114 constant ETHERNET_MAC_MACDR      \ Debug register
  $120 constant ETHERNET_MAC_MACHWF1R   \ HW feature 1 register
  $124 constant ETHERNET_MAC_MACHWF2R   \ HW feature 2 register
  $200 constant ETHERNET_MAC_MACMDIOAR  \ MDIO address register
  $204 constant ETHERNET_MAC_MACMDIODR  \ MDIO data register
  $300 constant ETHERNET_MAC_MACA0HR    \ Address 0 high register
  $304 constant ETHERNET_MAC_MACA0LR    \ Address 0 low register
  $308 constant ETHERNET_MAC_MACA1HR    \ Address 1 high register
  $30C constant ETHERNET_MAC_MACA1LR    \ Address 1 low register
  $310 constant ETHERNET_MAC_MACA2HR    \ Address 2 high register
  $314 constant ETHERNET_MAC_MACA2LR    \ Address 2 low register
  $318 constant ETHERNET_MAC_MACA3HR    \ Address 3 high register
  $31C constant ETHERNET_MAC_MACA3LR    \ Address 3 low register
  $700 constant ETHERNET_MAC_MMC_CONTROL    \ MMC control register
  $704 constant ETHERNET_MAC_MMC_RX_INTERRUPT    \ MMC Rx interrupt register
  $708 constant ETHERNET_MAC_MMC_TX_INTERRUPT    \ MMC Tx interrupt register
  $70C constant ETHERNET_MAC_MMC_RX_INTERRUPT_MASK    \ MMC Rx interrupt mask register
  $710 constant ETHERNET_MAC_MMC_TX_INTERRUPT_MASK    \ MMC Tx interrupt mask register
  $74C constant ETHERNET_MAC_TX_SINGLE_COLLISION_GOOD_PACKETS    \ Tx single collision good packets register
  $750 constant ETHERNET_MAC_TX_MULTIPLE_COLLISION_GOOD_PACKETS    \ Tx multiple collision good packets register
  $768 constant ETHERNET_MAC_TX_PACKET_COUNT_GOOD    \ Tx packet count good register
  $794 constant ETHERNET_MAC_RX_CRC_ERROR_PACKETS    \ Rx CRC error packets register
  $798 constant ETHERNET_MAC_RX_ALIGNMENT_ERROR_PACKETS    \ Rx alignment error packets register
  $7C4 constant ETHERNET_MAC_RX_UNICAST_PACKETS_GOOD    \ Rx unicast packets good register
  $7EC constant ETHERNET_MAC_TX_LPI_USEC_CNTR    \ Tx LPI microsecond timer register
  $7F0 constant ETHERNET_MAC_TX_LPI_TRAN_CNTR    \ Tx LPI transition counter register
  $7F4 constant ETHERNET_MAC_RX_LPI_USEC_CNTR    \ Rx LPI microsecond counter register
  $7F8 constant ETHERNET_MAC_RX_LPI_TRAN_CNTR    \ Rx LPI transition counter register
  $900 constant ETHERNET_MAC_MACL3L4C0R \ L3 and L4 control 0 register
  $904 constant ETHERNET_MAC_MACL4A0R   \ Layer4 address filter 0 register
  $910 constant ETHERNET_MAC_MACL3A00R  \ MACL3A00R
  $914 constant ETHERNET_MAC_MACL3A10R  \ Layer3 address 1 filter 0 register
  $918 constant ETHERNET_MAC_MACL3A20   \ Layer3 Address 2 filter 0 register
  $91C constant ETHERNET_MAC_MACL3A30   \ Layer3 Address 3 filter 0 register
  $930 constant ETHERNET_MAC_MACL3L4C1R \ L3 and L4 control 1 register
  $934 constant ETHERNET_MAC_MACL4A1R   \ Layer 4 address filter 1 register
  $940 constant ETHERNET_MAC_MACL3A01R  \ Layer3 address 0 filter 1 Register
  $944 constant ETHERNET_MAC_MACL3A11R  \ Layer3 address 1 filter 1 register
  $948 constant ETHERNET_MAC_MACL3A21R  \ Layer3 address 2 filter 1 Register
  $94C constant ETHERNET_MAC_MACL3A31R  \ Layer3 address 3 filter 1 register
  $AE0 constant ETHERNET_MAC_MACARPAR   \ ARP address register
  $B00 constant ETHERNET_MAC_MACTSCR    \ Timestamp control Register
  $B04 constant ETHERNET_MAC_MACSSIR    \ Sub-second increment register
  $B08 constant ETHERNET_MAC_MACSTSR    \ System time seconds register
  $B0C constant ETHERNET_MAC_MACSTNR    \ System time nanoseconds register
  $B10 constant ETHERNET_MAC_MACSTSUR   \ System time seconds update register
  $B14 constant ETHERNET_MAC_MACSTNUR   \ System time nanoseconds update register
  $B18 constant ETHERNET_MAC_MACTSAR    \ Timestamp addend register
  $B20 constant ETHERNET_MAC_MACTSSR    \ Timestamp status register
  $B30 constant ETHERNET_MAC_MACTXTSSNR \ Tx timestamp status nanoseconds register
  $B34 constant ETHERNET_MAC_MACTXTSSSR \ Tx timestamp status seconds register
  $B40 constant ETHERNET_MAC_MACACR     \ Auxiliary control register
  $B48 constant ETHERNET_MAC_MACATSNR   \ Auxiliary timestamp nanoseconds register
  $B4C constant ETHERNET_MAC_MACATSSR   \ Auxiliary timestamp seconds register
  $B50 constant ETHERNET_MAC_MACTSIACR  \ Timestamp Ingress asymmetric correction register
  $B54 constant ETHERNET_MAC_MACTSEACR  \ Timestamp Egress asymmetric correction register
  $B58 constant ETHERNET_MAC_MACTSICNR  \ Timestamp Ingress correction nanosecond register
  $B5C constant ETHERNET_MAC_MACTSECNR  \ Timestamp Egress correction nanosecond register
  $B70 constant ETHERNET_MAC_MACPPSCR   \ PPS control register
  $B80 constant ETHERNET_MAC_MACPPSTTSR \ PPS target time seconds register
  $B84 constant ETHERNET_MAC_MACPPSTTNR \ PPS target time nanoseconds register
  $B88 constant ETHERNET_MAC_MACPPSIR   \ PPS interval register
  $B8C constant ETHERNET_MAC_MACPPSWR   \ PPS width register
  $BC0 constant ETHERNET_MAC_MACPOCR    \ PTP Offload control register
  $BC4 constant ETHERNET_MAC_MACSPI0R   \ PTP Source Port Identity 0 Register
  $BC8 constant ETHERNET_MAC_MACSPI1R   \ PTP Source port identity 1 register
  $BCC constant ETHERNET_MAC_MACSPI2R   \ PTP Source port identity 2 register
  $BD0 constant ETHERNET_MAC_MACLMIR    \ Log message interval register

: ETHERNET_MAC_DEF ; [then]
