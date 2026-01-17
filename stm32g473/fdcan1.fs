\
\ @file fdcan1.fs
\ @brief FDCAN
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] FDCAN1_DEF

  [ifdef] FDCAN1_CREL_DEF
    \
    \ @brief FDCAN Core Release Register
    \ Address offset: 0x00
    \ Reset value: 0x32141218
    \
    $00 constant FDCAN1_DAY                     \ [0x00 : 8] DAY
    $08 constant FDCAN1_MON                     \ [0x08 : 8] MON
    $10 constant FDCAN1_YEAR                    \ [0x10 : 4] YEAR
    $14 constant FDCAN1_SUBSTEP                 \ [0x14 : 4] SUBSTEP
    $18 constant FDCAN1_STEP                    \ [0x18 : 4] STEP
    $1c constant FDCAN1_REL                     \ [0x1c : 4] REL
  [then]


  [ifdef] FDCAN1_ENDN_DEF
    \
    \ @brief FDCAN Core Release Register
    \ Address offset: 0x04
    \ Reset value: 0x87654321
    \
    $00 constant FDCAN1_ETV                     \ [0x00 : 32] ETV
  [then]


  [ifdef] FDCAN1_DBTP_DEF
    \
    \ @brief This register is only writable if bits CCCR.CCE and CCCR.INIT are set. The CAN bit time may be programed in the range of 4 to 25 time quanta. The CAN time quantum may be programmed in the range of 1 to 1024 FDCAN clock periods. tq = (DBRP + 1) FDCAN clock period. DTSEG1 is the sum of Prop_Seg and Phase_Seg1. DTSEG2 is Phase_Seg2. Therefore the length of the bit time is (programmed values) [DTSEG1 + DTSEG2 + 3] tq or (functional values) [Sync_Seg + Prop_Seg + Phase_Seg1 + Phase_Seg2] tq. The Information Processing Time (IPT) is zero, meaning the data for the next bit is available at the first clock edge after the sample point.
    \ Address offset: 0x0C
    \ Reset value: 0x00000A33
    \
    $00 constant FDCAN1_DSJW                    \ [0x00 : 4] DSJW
    $04 constant FDCAN1_DTSEG2                  \ [0x04 : 4] DTSEG2
    $08 constant FDCAN1_DTSEG1                  \ [0x08 : 5] DTSEG1
    $10 constant FDCAN1_DBRP                    \ [0x10 : 5] DBRP
    $17 constant FDCAN1_TDC                     \ [0x17] TDC
  [then]


  [ifdef] FDCAN1_TEST_DEF
    \
    \ @brief Write access to the Test Register has to be enabled by setting bit CCCR[TEST] to 1 . All Test Register functions are set to their reset values when bit CCCR[TEST] is reset. Loop Back mode and software control of Tx pin FDCANx_TX are hardware test modes. Programming TX differently from 00 may disturb the message transfer on the CAN bus.
    \ Address offset: 0x10
    \ Reset value: 0x00000000
    \
    $04 constant FDCAN1_LBCK                    \ [0x04] LBCK
    $05 constant FDCAN1_TX                      \ [0x05 : 2] TX
    $07 constant FDCAN1_RX                      \ [0x07] RX
  [then]


  [ifdef] FDCAN1_RWD_DEF
    \
    \ @brief The RAM Watchdog monitors the READY output of the Message RAM. A Message RAM access starts the Message RAM Watchdog Counter with the value configured by the RWD[WDC] bits. The counter is reloaded with RWD[WDC] bits when the Message RAM signals successful completion by activating its READY output. In case there is no response from the Message RAM until the counter has counted down to 0, the counter stops and interrupt flag IR[WDI] bit is set. The RAM Watchdog Counter is clocked by the fdcan_pclk clock.
    \ Address offset: 0x14
    \ Reset value: 0x00000000
    \
    $00 constant FDCAN1_WDC                     \ [0x00 : 8] WDC
    $08 constant FDCAN1_WDV                     \ [0x08 : 8] WDV
  [then]


  [ifdef] FDCAN1_CCCR_DEF
    \
    \ @brief For details about setting and resetting of single bits see Software initialization.
    \ Address offset: 0x18
    \ Reset value: 0x00000001
    \
    $00 constant FDCAN1_INIT                    \ [0x00] INIT
    $01 constant FDCAN1_CCE                     \ [0x01] CCE
    $02 constant FDCAN1_ASM                     \ [0x02] ASM
    $03 constant FDCAN1_CSA                     \ [0x03] CSA
    $04 constant FDCAN1_CSR                     \ [0x04] CSR
    $05 constant FDCAN1_MON                     \ [0x05] MON
    $06 constant FDCAN1_DAR                     \ [0x06] DAR
    $07 constant FDCAN1_TEST                    \ [0x07] TEST
    $08 constant FDCAN1_FDOE                    \ [0x08] FDOE
    $09 constant FDCAN1_BRSE                    \ [0x09] BRSE
    $0c constant FDCAN1_PXHD                    \ [0x0c] PXHD
    $0d constant FDCAN1_EFBI                    \ [0x0d] EFBI
    $0e constant FDCAN1_TXP                     \ [0x0e] TXP
    $0f constant FDCAN1_NISO                    \ [0x0f] NISO
  [then]


  [ifdef] FDCAN1_NBTP_DEF
    \
    \ @brief FDCAN_NBTP
    \ Address offset: 0x1C
    \ Reset value: 0x06000A03
    \
    $00 constant FDCAN1_NTSEG2                  \ [0x00 : 7] NTSEG2
    $08 constant FDCAN1_NTSEG1                  \ [0x08 : 8] NTSEG1
    $10 constant FDCAN1_NBRP                    \ [0x10 : 9] NBRP
    $19 constant FDCAN1_NSJW                    \ [0x19 : 7] NSJW
  [then]


  [ifdef] FDCAN1_TSCC_DEF
    \
    \ @brief FDCAN Timestamp Counter Configuration Register
    \ Address offset: 0x20
    \ Reset value: 0x00000000
    \
    $00 constant FDCAN1_TSS                     \ [0x00 : 2] TSS
    $10 constant FDCAN1_TCP                     \ [0x10 : 4] TCP
  [then]


  [ifdef] FDCAN1_TSCV_DEF
    \
    \ @brief FDCAN Timestamp Counter Value Register
    \ Address offset: 0x24
    \ Reset value: 0x00000000
    \
    $00 constant FDCAN1_TSC                     \ [0x00 : 16] TSC
  [then]


  [ifdef] FDCAN1_TOCC_DEF
    \
    \ @brief FDCAN Timeout Counter Configuration Register
    \ Address offset: 0x28
    \ Reset value: 0xFFFF0000
    \
    $00 constant FDCAN1_ETOC                    \ [0x00] ETOC
    $01 constant FDCAN1_TOS                     \ [0x01 : 2] TOS
    $10 constant FDCAN1_TOP                     \ [0x10 : 16] TOP
  [then]


  [ifdef] FDCAN1_TOCV_DEF
    \
    \ @brief FDCAN Timeout Counter Value Register
    \ Address offset: 0x2C
    \ Reset value: 0x0000FFFF
    \
    $00 constant FDCAN1_TOC                     \ [0x00 : 16] TOC
  [then]


  [ifdef] FDCAN1_ECR_DEF
    \
    \ @brief FDCAN Error Counter Register
    \ Address offset: 0x40
    \ Reset value: 0x00000000
    \
    $00 constant FDCAN1_TEC                     \ [0x00 : 8] TEC
    $08 constant FDCAN1_REC                     \ [0x08 : 7] TREC
    $0f constant FDCAN1_RP                      \ [0x0f] RP
    $10 constant FDCAN1_CEL                     \ [0x10 : 8] CEL
  [then]


  [ifdef] FDCAN1_PSR_DEF
    \
    \ @brief FDCAN Protocol Status Register
    \ Address offset: 0x44
    \ Reset value: 0x00000707
    \
    $00 constant FDCAN1_LEC                     \ [0x00 : 3] LEC
    $03 constant FDCAN1_ACT                     \ [0x03 : 2] ACT
    $05 constant FDCAN1_EP                      \ [0x05] EP
    $06 constant FDCAN1_EW                      \ [0x06] EW
    $07 constant FDCAN1_BO                      \ [0x07] BO
    $08 constant FDCAN1_DLEC                    \ [0x08 : 3] DLEC
    $0b constant FDCAN1_RESI                    \ [0x0b] RESI
    $0c constant FDCAN1_RBRS                    \ [0x0c] RBRS
    $0d constant FDCAN1_REDL                    \ [0x0d] REDL
    $0e constant FDCAN1_PXE                     \ [0x0e] PXE
    $10 constant FDCAN1_TDCV                    \ [0x10 : 7] TDCV
  [then]


  [ifdef] FDCAN1_TDCR_DEF
    \
    \ @brief FDCAN Transmitter Delay Compensation Register
    \ Address offset: 0x48
    \ Reset value: 0x00000000
    \
    $00 constant FDCAN1_TDCF                    \ [0x00 : 7] TDCF
    $08 constant FDCAN1_TDCO                    \ [0x08 : 7] TDCO
  [then]


  [ifdef] FDCAN1_IR_DEF
    \
    \ @brief The flags are set when one of the listed conditions is detected (edge-sensitive). The flags remain set until the Host clears them. A flag is cleared by writing a 1 to the corresponding bit position. Writing a 0 has no effect. A hard reset will clear the register. The configuration of IE controls whether an interrupt is generated. The configuration of ILS controls on which interrupt line an interrupt is signaled.
    \ Address offset: 0x50
    \ Reset value: 0x00000000
    \
    $00 constant FDCAN1_RF0N                    \ [0x00] RF0N
    $01 constant FDCAN1_RF0F                    \ [0x01] RF0F
    $02 constant FDCAN1_RF0L                    \ [0x02] RF0L
    $03 constant FDCAN1_RF1N                    \ [0x03] RF1N
    $04 constant FDCAN1_RF1F                    \ [0x04] RF1F
    $05 constant FDCAN1_RF1L                    \ [0x05] RF1L
    $06 constant FDCAN1_HPM                     \ [0x06] HPM
    $07 constant FDCAN1_TC                      \ [0x07] TC
    $08 constant FDCAN1_TCF                     \ [0x08] TCF
    $09 constant FDCAN1_TFE                     \ [0x09] TFE
    $0a constant FDCAN1_TEFN                    \ [0x0a] TEFN
    $0b constant FDCAN1_TEFF                    \ [0x0b] TEFF
    $0c constant FDCAN1_TEFL                    \ [0x0c] TEFL
    $0d constant FDCAN1_TSW                     \ [0x0d] TSW
    $0e constant FDCAN1_MRAF                    \ [0x0e] MRAF
    $0f constant FDCAN1_TOO                     \ [0x0f] TOO
    $10 constant FDCAN1_ELO                     \ [0x10] ELO
    $11 constant FDCAN1_EP                      \ [0x11] EP
    $12 constant FDCAN1_EW                      \ [0x12] EW
    $13 constant FDCAN1_BO                      \ [0x13] BO
    $14 constant FDCAN1_WDI                     \ [0x14] WDI
    $15 constant FDCAN1_PEA                     \ [0x15] PEA
    $16 constant FDCAN1_PED                     \ [0x16] PED
    $17 constant FDCAN1_ARA                     \ [0x17] ARA
  [then]


  [ifdef] FDCAN1_IE_DEF
    \
    \ @brief The settings in the Interrupt Enable register determine which status changes in the Interrupt Register will be signaled on an interrupt line.
    \ Address offset: 0x54
    \ Reset value: 0x00000000
    \
    $00 constant FDCAN1_RF0NE                   \ [0x00] RF0NE
    $01 constant FDCAN1_RF0FE                   \ [0x01] RF0FE
    $02 constant FDCAN1_RF0LE                   \ [0x02] RF0LE
    $03 constant FDCAN1_RF1NE                   \ [0x03] RF1NE
    $04 constant FDCAN1_RF1FE                   \ [0x04] RF1FE
    $05 constant FDCAN1_RF1LE                   \ [0x05] RF1LE
    $06 constant FDCAN1_HPME                    \ [0x06] HPME
    $07 constant FDCAN1_TCE                     \ [0x07] TCE
    $08 constant FDCAN1_TCFE                    \ [0x08] TCFE
    $09 constant FDCAN1_TFEE                    \ [0x09] TFEE
    $0a constant FDCAN1_TEFNE                   \ [0x0a] TEFNE
    $0b constant FDCAN1_TEFFE                   \ [0x0b] TEFFE
    $0c constant FDCAN1_TEFLE                   \ [0x0c] TEFLE
    $0d constant FDCAN1_TSWE                    \ [0x0d] TSWE
    $0e constant FDCAN1_MRAFE                   \ [0x0e] MRAFE
    $0f constant FDCAN1_TOOE                    \ [0x0f] TOOE
    $10 constant FDCAN1_ELOE                    \ [0x10] ELOE
    $11 constant FDCAN1_EPE                     \ [0x11] EPE
    $12 constant FDCAN1_EWE                     \ [0x12] EWE
    $13 constant FDCAN1_BOE                     \ [0x13] BOE
    $14 constant FDCAN1_WDIE                    \ [0x14] WDIE
    $15 constant FDCAN1_PEAE                    \ [0x15] PEAE
    $16 constant FDCAN1_PEDE                    \ [0x16] PEDE
    $17 constant FDCAN1_ARAE                    \ [0x17] ARAE
  [then]


  [ifdef] FDCAN1_ILS_DEF
    \
    \ @brief The Interrupt Line Select register assigns an interrupt generated by a specific interrupt flag from the Interrupt Register to one of the two module interrupt lines. For interrupt generation the respective interrupt line has to be enabled via ILE[EINT0] and ILE[EINT1].
    \ Address offset: 0x58
    \ Reset value: 0x00000000
    \
    $00 constant FDCAN1_RxFIFO0                 \ [0x00] RxFIFO0
    $01 constant FDCAN1_RxFIFO1                 \ [0x01] RxFIFO1
    $02 constant FDCAN1_SMSG                    \ [0x02] SMSG
    $03 constant FDCAN1_TFERR                   \ [0x03] TFERR
    $04 constant FDCAN1_MISC                    \ [0x04] MISC
    $05 constant FDCAN1_BERR                    \ [0x05] BERR
    $06 constant FDCAN1_PERR                    \ [0x06] PERR
  [then]


  [ifdef] FDCAN1_ILE_DEF
    \
    \ @brief Each of the two interrupt lines to the CPU can be enabled/disabled separately by programming bits EINT0 and EINT1.
    \ Address offset: 0x5C
    \ Reset value: 0x00000000
    \
    $00 constant FDCAN1_EINT0                   \ [0x00] EINT0
    $01 constant FDCAN1_EINT1                   \ [0x01] EINT1
  [then]


  [ifdef] FDCAN1_RXGFC_DEF
    \
    \ @brief Global settings for Message ID filtering. The Global Filter Configuration controls the filter path for standard and extended messages as described in Figure706: Standard Message ID filter path and Figure707: Extended Message ID filter path.
    \ Address offset: 0x80
    \ Reset value: 0x00000000
    \
    $00 constant FDCAN1_RRFE                    \ [0x00] RRFE
    $01 constant FDCAN1_RRFS                    \ [0x01] RRFS
    $02 constant FDCAN1_ANFE                    \ [0x02 : 2] ANFE
    $04 constant FDCAN1_ANFS                    \ [0x04 : 2] ANFS
    $08 constant FDCAN1_F1OM                    \ [0x08] F1OM
    $09 constant FDCAN1_F0OM                    \ [0x09] F0OM
    $10 constant FDCAN1_LSS                     \ [0x10 : 5] LSS
    $18 constant FDCAN1_LSE                     \ [0x18 : 4] LSE
  [then]


  [ifdef] FDCAN1_XIDAM_DEF
    \
    \ @brief FDCAN Extended ID and Mask Register
    \ Address offset: 0x84
    \ Reset value: 0x1FFFFFFF
    \
    $00 constant FDCAN1_EIDM                    \ [0x00 : 29] EIDM
  [then]


  [ifdef] FDCAN1_HPMS_DEF
    \
    \ @brief This register is updated every time a Message ID filter element configured to generate a priority event match. This can be used to monitor the status of incoming high priority messages and to enable fast access to these messages.
    \ Address offset: 0x88
    \ Reset value: 0x00000000
    \
    $00 constant FDCAN1_BIDX                    \ [0x00 : 3] BIDX
    $06 constant FDCAN1_MSI                     \ [0x06 : 2] MSI
    $08 constant FDCAN1_FIDX                    \ [0x08 : 5] FIDX
    $0f constant FDCAN1_FLST                    \ [0x0f] FLST
  [then]


  [ifdef] FDCAN1_RXF0S_DEF
    \
    \ @brief FDCAN Rx FIFO 0 Status Register
    \ Address offset: 0x90
    \ Reset value: 0x00000000
    \
    $00 constant FDCAN1_F0FL                    \ [0x00 : 4] F0FL
    $08 constant FDCAN1_F0GI                    \ [0x08 : 2] F0GI
    $10 constant FDCAN1_F0PI                    \ [0x10 : 2] F0PI
    $18 constant FDCAN1_F0F                     \ [0x18] F0F
    $19 constant FDCAN1_RF0L                    \ [0x19] RF0L
  [then]


  [ifdef] FDCAN1_RXF0A_DEF
    \
    \ @brief CAN Rx FIFO 0 Acknowledge Register
    \ Address offset: 0x94
    \ Reset value: 0x00000000
    \
    $00 constant FDCAN1_F0AI                    \ [0x00 : 3] F0AI
  [then]


  [ifdef] FDCAN1_RXF1S_DEF
    \
    \ @brief FDCAN Rx FIFO 1 Status Register
    \ Address offset: 0x98
    \ Reset value: 0x00000000
    \
    $00 constant FDCAN1_F1FL                    \ [0x00 : 4] F1FL
    $08 constant FDCAN1_F1GI                    \ [0x08 : 2] F1GI
    $10 constant FDCAN1_F1PI                    \ [0x10 : 2] F1PI
    $18 constant FDCAN1_F1F                     \ [0x18] F1F
    $19 constant FDCAN1_RF1L                    \ [0x19] RF1L
  [then]


  [ifdef] FDCAN1_RXF1A_DEF
    \
    \ @brief FDCAN Rx FIFO 1 Acknowledge Register
    \ Address offset: 0x9C
    \ Reset value: 0x00000000
    \
    $00 constant FDCAN1_F1AI                    \ [0x00 : 3] F1AI
  [then]


  [ifdef] FDCAN1_TXBC_DEF
    \
    \ @brief FDCAN Tx Buffer Configuration Register
    \ Address offset: 0xC0
    \ Reset value: 0x00000000
    \
    $18 constant FDCAN1_TFQM                    \ [0x18] TFQM
  [then]


  [ifdef] FDCAN1_TXFQS_DEF
    \
    \ @brief The Tx FIFO/Queue status is related to the pending Tx requests listed in register TXBRP. Therefore the effect of Add/Cancellation requests may be delayed due to a running Tx scan (TXBRP not yet updated).
    \ Address offset: 0xC4
    \ Reset value: 0x00000003
    \
    $00 constant FDCAN1_TFFL                    \ [0x00 : 3] TFFL
    $08 constant FDCAN1_TFGI                    \ [0x08 : 2] TFGI
    $10 constant FDCAN1_TFQPI                   \ [0x10 : 2] TFQPI
    $15 constant FDCAN1_TFQF                    \ [0x15] TFQF
  [then]


  [ifdef] FDCAN1_TXBRP_DEF
    \
    \ @brief FDCAN Tx Buffer Request Pending Register
    \ Address offset: 0xC8
    \ Reset value: 0x00000000
    \
    $00 constant FDCAN1_TRP                     \ [0x00 : 3] TRP
  [then]


  [ifdef] FDCAN1_TXBAR_DEF
    \
    \ @brief FDCAN Tx Buffer Add Request Register
    \ Address offset: 0xCC
    \ Reset value: 0x00000000
    \
    $00 constant FDCAN1_AR                      \ [0x00 : 3] AR
  [then]


  [ifdef] FDCAN1_TXBCR_DEF
    \
    \ @brief FDCAN Tx Buffer Cancellation Request Register
    \ Address offset: 0xD0
    \ Reset value: 0x00000000
    \
    $00 constant FDCAN1_CR                      \ [0x00 : 3] CR
  [then]


  [ifdef] FDCAN1_TXBTO_DEF
    \
    \ @brief FDCAN Tx Buffer Transmission Occurred Register
    \ Address offset: 0xD4
    \ Reset value: 0x00000000
    \
    $00 constant FDCAN1_TO                      \ [0x00 : 3] TO
  [then]


  [ifdef] FDCAN1_TXBCF_DEF
    \
    \ @brief FDCAN Tx Buffer Cancellation Finished Register
    \ Address offset: 0xD8
    \ Reset value: 0x00000000
    \
    $00 constant FDCAN1_CF                      \ [0x00 : 3] CF
  [then]


  [ifdef] FDCAN1_TXBTIE_DEF
    \
    \ @brief FDCAN Tx Buffer Transmission Interrupt Enable Register
    \ Address offset: 0xDC
    \ Reset value: 0x00000000
    \
    $00 constant FDCAN1_TIE                     \ [0x00 : 3] TIE
  [then]


  [ifdef] FDCAN1_TXBCIE_DEF
    \
    \ @brief FDCAN Tx Buffer Cancellation Finished Interrupt Enable Register
    \ Address offset: 0xE0
    \ Reset value: 0x00000000
    \
    $00 constant FDCAN1_CFIE                    \ [0x00 : 3] CFIE
  [then]


  [ifdef] FDCAN1_TXEFS_DEF
    \
    \ @brief FDCAN Tx Event FIFO Status Register
    \ Address offset: 0xE4
    \ Reset value: 0x00000000
    \
    $00 constant FDCAN1_EFFL                    \ [0x00 : 3] EFFL
    $08 constant FDCAN1_EFGI                    \ [0x08 : 2] EFGI
    $10 constant FDCAN1_EFPI                    \ [0x10 : 2] EFPI
    $18 constant FDCAN1_EFF                     \ [0x18] EFF
    $19 constant FDCAN1_TEFL                    \ [0x19] TEFL
  [then]


  [ifdef] FDCAN1_TXEFA_DEF
    \
    \ @brief FDCAN Tx Event FIFO Acknowledge Register
    \ Address offset: 0xE8
    \ Reset value: 0x00000000
    \
    $00 constant FDCAN1_EFAI                    \ [0x00 : 2] EFAI
  [then]


  [ifdef] FDCAN1_CKDIV_DEF
    \
    \ @brief FDCAN CFG clock divider register
    \ Address offset: 0x100
    \ Reset value: 0x00000000
    \
    $00 constant FDCAN1_PDIV                    \ [0x00 : 4] input clock divider. the APB clock could be divided prior to be used by the CAN sub
  [then]

  \
  \ @brief FDCAN
  \
  $00 constant FDCAN1_CREL              \ FDCAN Core Release Register
  $04 constant FDCAN1_ENDN              \ FDCAN Core Release Register
  $0C constant FDCAN1_DBTP              \ This register is only writable if bits CCCR.CCE and CCCR.INIT are set. The CAN bit time may be programed in the range of 4 to 25 time quanta. The CAN time quantum may be programmed in the range of 1 to 1024 FDCAN clock periods. tq = (DBRP + 1) FDCAN clock period. DTSEG1 is the sum of Prop_Seg and Phase_Seg1. DTSEG2 is Phase_Seg2. Therefore the length of the bit time is (programmed values) [DTSEG1 + DTSEG2 + 3] tq or (functional values) [Sync_Seg + Prop_Seg + Phase_Seg1 + Phase_Seg2] tq. The Information Processing Time (IPT) is zero, meaning the data for the next bit is available at the first clock edge after the sample point.
  $10 constant FDCAN1_TEST              \ Write access to the Test Register has to be enabled by setting bit CCCR[TEST] to 1 . All Test Register functions are set to their reset values when bit CCCR[TEST] is reset. Loop Back mode and software control of Tx pin FDCANx_TX are hardware test modes. Programming TX differently from 00 may disturb the message transfer on the CAN bus.
  $14 constant FDCAN1_RWD               \ The RAM Watchdog monitors the READY output of the Message RAM. A Message RAM access starts the Message RAM Watchdog Counter with the value configured by the RWD[WDC] bits. The counter is reloaded with RWD[WDC] bits when the Message RAM signals successful completion by activating its READY output. In case there is no response from the Message RAM until the counter has counted down to 0, the counter stops and interrupt flag IR[WDI] bit is set. The RAM Watchdog Counter is clocked by the fdcan_pclk clock.
  $18 constant FDCAN1_CCCR              \ For details about setting and resetting of single bits see Software initialization.
  $1C constant FDCAN1_NBTP              \ FDCAN_NBTP
  $20 constant FDCAN1_TSCC              \ FDCAN Timestamp Counter Configuration Register
  $24 constant FDCAN1_TSCV              \ FDCAN Timestamp Counter Value Register
  $28 constant FDCAN1_TOCC              \ FDCAN Timeout Counter Configuration Register
  $2C constant FDCAN1_TOCV              \ FDCAN Timeout Counter Value Register
  $40 constant FDCAN1_ECR               \ FDCAN Error Counter Register
  $44 constant FDCAN1_PSR               \ FDCAN Protocol Status Register
  $48 constant FDCAN1_TDCR              \ FDCAN Transmitter Delay Compensation Register
  $50 constant FDCAN1_IR                \ The flags are set when one of the listed conditions is detected (edge-sensitive). The flags remain set until the Host clears them. A flag is cleared by writing a 1 to the corresponding bit position. Writing a 0 has no effect. A hard reset will clear the register. The configuration of IE controls whether an interrupt is generated. The configuration of ILS controls on which interrupt line an interrupt is signaled.
  $54 constant FDCAN1_IE                \ The settings in the Interrupt Enable register determine which status changes in the Interrupt Register will be signaled on an interrupt line.
  $58 constant FDCAN1_ILS               \ The Interrupt Line Select register assigns an interrupt generated by a specific interrupt flag from the Interrupt Register to one of the two module interrupt lines. For interrupt generation the respective interrupt line has to be enabled via ILE[EINT0] and ILE[EINT1].
  $5C constant FDCAN1_ILE               \ Each of the two interrupt lines to the CPU can be enabled/disabled separately by programming bits EINT0 and EINT1.
  $80 constant FDCAN1_RXGFC             \ Global settings for Message ID filtering. The Global Filter Configuration controls the filter path for standard and extended messages as described in Figure706: Standard Message ID filter path and Figure707: Extended Message ID filter path.
  $84 constant FDCAN1_XIDAM             \ FDCAN Extended ID and Mask Register
  $88 constant FDCAN1_HPMS              \ This register is updated every time a Message ID filter element configured to generate a priority event match. This can be used to monitor the status of incoming high priority messages and to enable fast access to these messages.
  $90 constant FDCAN1_RXF0S             \ FDCAN Rx FIFO 0 Status Register
  $94 constant FDCAN1_RXF0A             \ CAN Rx FIFO 0 Acknowledge Register
  $98 constant FDCAN1_RXF1S             \ FDCAN Rx FIFO 1 Status Register
  $9C constant FDCAN1_RXF1A             \ FDCAN Rx FIFO 1 Acknowledge Register
  $C0 constant FDCAN1_TXBC              \ FDCAN Tx Buffer Configuration Register
  $C4 constant FDCAN1_TXFQS             \ The Tx FIFO/Queue status is related to the pending Tx requests listed in register TXBRP. Therefore the effect of Add/Cancellation requests may be delayed due to a running Tx scan (TXBRP not yet updated).
  $C8 constant FDCAN1_TXBRP             \ FDCAN Tx Buffer Request Pending Register
  $CC constant FDCAN1_TXBAR             \ FDCAN Tx Buffer Add Request Register
  $D0 constant FDCAN1_TXBCR             \ FDCAN Tx Buffer Cancellation Request Register
  $D4 constant FDCAN1_TXBTO             \ FDCAN Tx Buffer Transmission Occurred Register
  $D8 constant FDCAN1_TXBCF             \ FDCAN Tx Buffer Cancellation Finished Register
  $DC constant FDCAN1_TXBTIE            \ FDCAN Tx Buffer Transmission Interrupt Enable Register
  $E0 constant FDCAN1_TXBCIE            \ FDCAN Tx Buffer Cancellation Finished Interrupt Enable Register
  $E4 constant FDCAN1_TXEFS             \ FDCAN Tx Event FIFO Status Register
  $E8 constant FDCAN1_TXEFA             \ FDCAN Tx Event FIFO Acknowledge Register
  $100 constant FDCAN1_CKDIV            \ FDCAN CFG clock divider register

: FDCAN1_DEF ; [then]
