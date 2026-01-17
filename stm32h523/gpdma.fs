\
\ @file gpdma.fs
\ @brief GPDMA register block
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] GPDMA_DEF

  [ifdef] GPDMA_GPDMA_SECCFGR_DEF
    \
    \ @brief GPDMA secure configuration register
    \ Address offset: 0x00
    \ Reset value: 0x00000000
    \
    $00 constant GPDMA_SEC0                     \ [0x00] secure state of channel x
    $01 constant GPDMA_SEC1                     \ [0x01] secure state of channel x
    $02 constant GPDMA_SEC2                     \ [0x02] secure state of channel x
    $03 constant GPDMA_SEC3                     \ [0x03] secure state of channel x
    $04 constant GPDMA_SEC4                     \ [0x04] secure state of channel x
    $05 constant GPDMA_SEC5                     \ [0x05] secure state of channel x
    $06 constant GPDMA_SEC6                     \ [0x06] secure state of channel x
    $07 constant GPDMA_SEC7                     \ [0x07] secure state of channel x
  [then]


  [ifdef] GPDMA_GPDMA_PRIVCFGR_DEF
    \
    \ @brief GPDMA privileged configuration register
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $00 constant GPDMA_PRIV0                    \ [0x00] privileged state of channel x
    $01 constant GPDMA_PRIV1                    \ [0x01] privileged state of channel x
    $02 constant GPDMA_PRIV2                    \ [0x02] privileged state of channel x
    $03 constant GPDMA_PRIV3                    \ [0x03] privileged state of channel x
    $04 constant GPDMA_PRIV4                    \ [0x04] privileged state of channel x
    $05 constant GPDMA_PRIV5                    \ [0x05] privileged state of channel x
    $06 constant GPDMA_PRIV6                    \ [0x06] privileged state of channel x
    $07 constant GPDMA_PRIV7                    \ [0x07] privileged state of channel x
  [then]


  [ifdef] GPDMA_GPDMA_RCFGLOCKR_DEF
    \
    \ @brief GPDMA configuration lock register
    \ Address offset: 0x08
    \ Reset value: 0x00000000
    \
    $00 constant GPDMA_LOCK0                    \ [0x00] lock the configuration of GPDMA_SECCFGR.
    $01 constant GPDMA_LOCK1                    \ [0x01] lock the configuration of GPDMA_SECCFGR.
    $02 constant GPDMA_LOCK2                    \ [0x02] lock the configuration of GPDMA_SECCFGR.
    $03 constant GPDMA_LOCK3                    \ [0x03] lock the configuration of GPDMA_SECCFGR.
    $04 constant GPDMA_LOCK4                    \ [0x04] lock the configuration of GPDMA_SECCFGR.
    $05 constant GPDMA_LOCK5                    \ [0x05] lock the configuration of GPDMA_SECCFGR.
    $06 constant GPDMA_LOCK6                    \ [0x06] lock the configuration of GPDMA_SECCFGR.
    $07 constant GPDMA_LOCK7                    \ [0x07] lock the configuration of GPDMA_SECCFGR.
  [then]


  [ifdef] GPDMA_GPDMA_MISR_DEF
    \
    \ @brief GPDMA nonsecure masked interrupt status register
    \ Address offset: 0x0C
    \ Reset value: 0x00000000
    \
    $00 constant GPDMA_MIS0                     \ [0x00] masked interrupt status of channel x
    $01 constant GPDMA_MIS1                     \ [0x01] masked interrupt status of channel x
    $02 constant GPDMA_MIS2                     \ [0x02] masked interrupt status of channel x
    $03 constant GPDMA_MIS3                     \ [0x03] masked interrupt status of channel x
    $04 constant GPDMA_MIS4                     \ [0x04] masked interrupt status of channel x
    $05 constant GPDMA_MIS5                     \ [0x05] masked interrupt status of channel x
    $06 constant GPDMA_MIS6                     \ [0x06] masked interrupt status of channel x
    $07 constant GPDMA_MIS7                     \ [0x07] masked interrupt status of channel x
  [then]


  [ifdef] GPDMA_GPDMA_SMISR_DEF
    \
    \ @brief GPDMA secure masked interrupt status register
    \ Address offset: 0x10
    \ Reset value: 0x00000000
    \
    $00 constant GPDMA_MIS0                     \ [0x00] masked interrupt status of the secure channel x
    $01 constant GPDMA_MIS1                     \ [0x01] masked interrupt status of the secure channel x
    $02 constant GPDMA_MIS2                     \ [0x02] masked interrupt status of the secure channel x
    $03 constant GPDMA_MIS3                     \ [0x03] masked interrupt status of the secure channel x
    $04 constant GPDMA_MIS4                     \ [0x04] masked interrupt status of the secure channel x
    $05 constant GPDMA_MIS5                     \ [0x05] masked interrupt status of the secure channel x
    $06 constant GPDMA_MIS6                     \ [0x06] masked interrupt status of the secure channel x
    $07 constant GPDMA_MIS7                     \ [0x07] masked interrupt status of the secure channel x
  [then]


  [ifdef] GPDMA_GPDMA_C0LBAR_DEF
    \
    \ @brief GPDMA channel 0 linked-list base address register
    \ Address offset: 0x50
    \ Reset value: 0x00000000
    \
    $10 constant GPDMA_LBA                      \ [0x10 : 16] linked-list base address of GPDMA channel x
  [then]


  [ifdef] GPDMA_GPDMA_C0FCR_DEF
    \
    \ @brief GPDMA channel 0 flag clear register
    \ Address offset: 0x5C
    \ Reset value: 0x00000000
    \
    $08 constant GPDMA_TCF                      \ [0x08] transfer complete flag clear
    $09 constant GPDMA_HTF                      \ [0x09] half transfer flag clear
    $0a constant GPDMA_DTEF                     \ [0x0a] data transfer error flag clear
    $0b constant GPDMA_ULEF                     \ [0x0b] update link transfer error flag clear
    $0c constant GPDMA_USEF                     \ [0x0c] user setting error flag clear
    $0d constant GPDMA_SUSPF                    \ [0x0d] completed suspension flag clear
    $0e constant GPDMA_TOF                      \ [0x0e] trigger overrun flag clear
  [then]


  [ifdef] GPDMA_GPDMA_C0SR_DEF
    \
    \ @brief GPDMA channel 0 status register
    \ Address offset: 0x60
    \ Reset value: 0x00000001
    \
    $00 constant GPDMA_IDLEF                    \ [0x00] idle flag
    $08 constant GPDMA_TCF                      \ [0x08] transfer complete flag
    $09 constant GPDMA_HTF                      \ [0x09] half transfer flag
    $0a constant GPDMA_DTEF                     \ [0x0a] data transfer error flag
    $0b constant GPDMA_ULEF                     \ [0x0b] update link transfer error flag
    $0c constant GPDMA_USEF                     \ [0x0c] user setting error flag
    $0d constant GPDMA_SUSPF                    \ [0x0d] completed suspension flag
    $0e constant GPDMA_TOF                      \ [0x0e] trigger overrun flag
    $10 constant GPDMA_FIFOL                    \ [0x10 : 8] monitored FIFO level
  [then]


  [ifdef] GPDMA_GPDMA_C0CR_DEF
    \
    \ @brief GPDMA channel 0 control register
    \ Address offset: 0x64
    \ Reset value: 0x00000000
    \
    $00 constant GPDMA_EN                       \ [0x00] enable
    $01 constant GPDMA_RESET                    \ [0x01] reset
    $02 constant GPDMA_SUSP                     \ [0x02] suspend
    $08 constant GPDMA_TCIE                     \ [0x08] transfer complete interrupt enable
    $09 constant GPDMA_HTIE                     \ [0x09] half transfer complete interrupt enable
    $0a constant GPDMA_DTEIE                    \ [0x0a] data transfer error interrupt enable
    $0b constant GPDMA_ULEIE                    \ [0x0b] update link transfer error interrupt enable
    $0c constant GPDMA_USEIE                    \ [0x0c] user setting error interrupt enable
    $0d constant GPDMA_SUSPIE                   \ [0x0d] completed suspension interrupt enable
    $0e constant GPDMA_TOIE                     \ [0x0e] trigger overrun interrupt enable
    $10 constant GPDMA_LSM                      \ [0x10] Link step mode
    $11 constant GPDMA_LAP                      \ [0x11] linked-list allocated port
    $16 constant GPDMA_PRIO                     \ [0x16 : 2] priority level of the channel x GPDMA transfer versus others
  [then]


  [ifdef] GPDMA_GPDMA_C0TR1_DEF
    \
    \ @brief GPDMA channel 0 transfer register 1
    \ Address offset: 0x90
    \ Reset value: 0x00000000
    \
    $00 constant GPDMA_SDW_LOG2                 \ [0x00 : 2] binary logarithm of the source data width of a burst in bytes
    $03 constant GPDMA_SINC                     \ [0x03] source incrementing burst
    $04 constant GPDMA_SBL_1                    \ [0x04 : 6] source burst length minus 1, between 0 and 63
    $0b constant GPDMA_PAM                      \ [0x0b : 2] padding/alignment mode
    $0d constant GPDMA_SBX                      \ [0x0d] source byte exchange within the unaligned half-word of each source word
    $0e constant GPDMA_SAP                      \ [0x0e] source allocated port
    $0f constant GPDMA_SSEC                     \ [0x0f] security attribute of the GPDMA transfer from the source
    $10 constant GPDMA_DDW_LOG2                 \ [0x10 : 2] binary logarithm of the destination data width of a burst, in bytes
    $13 constant GPDMA_DINC                     \ [0x13] destination incrementing burst
    $14 constant GPDMA_DBL_1                    \ [0x14 : 6] destination burst length minus 1, between 0 and 63
    $1a constant GPDMA_DBX                      \ [0x1a] destination byte exchange
    $1b constant GPDMA_DHX                      \ [0x1b] destination half-word exchange
    $1e constant GPDMA_DAP                      \ [0x1e] destination allocated port
    $1f constant GPDMA_DSEC                     \ [0x1f] security attribute of the GPDMA transfer to the destination
  [then]


  [ifdef] GPDMA_GPDMA_C0TR2_DEF
    \
    \ @brief GPDMA channel 0 transfer register 2
    \ Address offset: 0x94
    \ Reset value: 0x00000000
    \
    $00 constant GPDMA_REQSEL                   \ [0x00 : 8] GPDMA hardware request selection
    $09 constant GPDMA_SWREQ                    \ [0x09] software request
    $0a constant GPDMA_DREQ                     \ [0x0a] destination hardware request
    $0b constant GPDMA_BREQ                     \ [0x0b] Block hardware request
    $0c constant GPDMA_PFREQ                    \ [0x0c] Hardware request in peripheral flow control mode
    $0e constant GPDMA_TRIGM                    \ [0x0e : 2] trigger mode
    $10 constant GPDMA_TRIGSEL                  \ [0x10 : 6] trigger event input selection
    $18 constant GPDMA_TRIGPOL                  \ [0x18 : 2] trigger event polarity
    $1e constant GPDMA_TCEM                     \ [0x1e : 2] transfer complete event mode
  [then]


  [ifdef] GPDMA_GPDMA_C0BR1_DEF
    \
    \ @brief GPDMA channel 0 block register 1
    \ Address offset: 0x98
    \ Reset value: 0x00000000
    \
    $00 constant GPDMA_BNDT                     \ [0x00 : 16] block number of data bytes to transfer from the source
  [then]


  [ifdef] GPDMA_GPDMA_C0SAR_DEF
    \
    \ @brief GPDMA channel 0 source address register
    \ Address offset: 0x9C
    \ Reset value: 0x00000000
    \
    $00 constant GPDMA_SA                       \ [0x00 : 32] source address
  [then]


  [ifdef] GPDMA_GPDMA_C0DAR_DEF
    \
    \ @brief GPDMA channel 0 destination address register
    \ Address offset: 0xA0
    \ Reset value: 0x00000000
    \
    $00 constant GPDMA_DA                       \ [0x00 : 32] destination address
  [then]


  [ifdef] GPDMA_GPDMA_C0LLR_DEF
    \
    \ @brief GPDMA channel 0 linked-list address register
    \ Address offset: 0xCC
    \ Reset value: 0x00000000
    \
    $02 constant GPDMA_LA                       \ [0x02 : 14] pointer (16-bit low-significant address) to the next linked-list data structure
    $10 constant GPDMA_ULL                      \ [0x10] Update GPDMA_CxLLR register from memory
    $1b constant GPDMA_UDA                      \ [0x1b] Update GPDMA_CxDAR register from memory
    $1c constant GPDMA_USA                      \ [0x1c] update GPDMA_CxSAR from memory
    $1d constant GPDMA_UB1                      \ [0x1d] Update GPDMA_CxBR1 from memory
    $1e constant GPDMA_UT2                      \ [0x1e] Update GPDMA_CxTR2 from memory
    $1f constant GPDMA_UT1                      \ [0x1f] Update GPDMA_CxTR1 from memory
  [then]


  [ifdef] GPDMA_GPDMA_C1LBAR_DEF
    \
    \ @brief GPDMA channel 1 linked-list base address register
    \ Address offset: 0xD0
    \ Reset value: 0x00000000
    \
    $10 constant GPDMA_LBA                      \ [0x10 : 16] linked-list base address of GPDMA channel x
  [then]


  [ifdef] GPDMA_GPDMA_C1FCR_DEF
    \
    \ @brief GPDMA channel 1 flag clear register
    \ Address offset: 0xDC
    \ Reset value: 0x00000000
    \
    $08 constant GPDMA_TCF                      \ [0x08] transfer complete flag clear
    $09 constant GPDMA_HTF                      \ [0x09] half transfer flag clear
    $0a constant GPDMA_DTEF                     \ [0x0a] data transfer error flag clear
    $0b constant GPDMA_ULEF                     \ [0x0b] update link transfer error flag clear
    $0c constant GPDMA_USEF                     \ [0x0c] user setting error flag clear
    $0d constant GPDMA_SUSPF                    \ [0x0d] completed suspension flag clear
    $0e constant GPDMA_TOF                      \ [0x0e] trigger overrun flag clear
  [then]


  [ifdef] GPDMA_GPDMA_C1SR_DEF
    \
    \ @brief GPDMA channel 1 status register
    \ Address offset: 0xE0
    \ Reset value: 0x00000001
    \
    $00 constant GPDMA_IDLEF                    \ [0x00] idle flag
    $08 constant GPDMA_TCF                      \ [0x08] transfer complete flag
    $09 constant GPDMA_HTF                      \ [0x09] half transfer flag
    $0a constant GPDMA_DTEF                     \ [0x0a] data transfer error flag
    $0b constant GPDMA_ULEF                     \ [0x0b] update link transfer error flag
    $0c constant GPDMA_USEF                     \ [0x0c] user setting error flag
    $0d constant GPDMA_SUSPF                    \ [0x0d] completed suspension flag
    $0e constant GPDMA_TOF                      \ [0x0e] trigger overrun flag
    $10 constant GPDMA_FIFOL                    \ [0x10 : 8] monitored FIFO level
  [then]


  [ifdef] GPDMA_GPDMA_C1CR_DEF
    \
    \ @brief GPDMA channel 1 control register
    \ Address offset: 0xE4
    \ Reset value: 0x00000000
    \
    $00 constant GPDMA_EN                       \ [0x00] enable
    $01 constant GPDMA_RESET                    \ [0x01] reset
    $02 constant GPDMA_SUSP                     \ [0x02] suspend
    $08 constant GPDMA_TCIE                     \ [0x08] transfer complete interrupt enable
    $09 constant GPDMA_HTIE                     \ [0x09] half transfer complete interrupt enable
    $0a constant GPDMA_DTEIE                    \ [0x0a] data transfer error interrupt enable
    $0b constant GPDMA_ULEIE                    \ [0x0b] update link transfer error interrupt enable
    $0c constant GPDMA_USEIE                    \ [0x0c] user setting error interrupt enable
    $0d constant GPDMA_SUSPIE                   \ [0x0d] completed suspension interrupt enable
    $0e constant GPDMA_TOIE                     \ [0x0e] trigger overrun interrupt enable
    $10 constant GPDMA_LSM                      \ [0x10] Link step mode
    $11 constant GPDMA_LAP                      \ [0x11] linked-list allocated port
    $16 constant GPDMA_PRIO                     \ [0x16 : 2] priority level of the channel x GPDMA transfer versus others
  [then]


  [ifdef] GPDMA_GPDMA_C1TR1_DEF
    \
    \ @brief GPDMA channel 1 transfer register 1
    \ Address offset: 0x110
    \ Reset value: 0x00000000
    \
    $00 constant GPDMA_SDW_LOG2                 \ [0x00 : 2] binary logarithm of the source data width of a burst in bytes
    $03 constant GPDMA_SINC                     \ [0x03] source incrementing burst
    $04 constant GPDMA_SBL_1                    \ [0x04 : 6] source burst length minus 1, between 0 and 63
    $0b constant GPDMA_PAM                      \ [0x0b : 2] padding/alignment mode
    $0d constant GPDMA_SBX                      \ [0x0d] source byte exchange within the unaligned half-word of each source word
    $0e constant GPDMA_SAP                      \ [0x0e] source allocated port
    $0f constant GPDMA_SSEC                     \ [0x0f] security attribute of the GPDMA transfer from the source
    $10 constant GPDMA_DDW_LOG2                 \ [0x10 : 2] binary logarithm of the destination data width of a burst, in bytes
    $13 constant GPDMA_DINC                     \ [0x13] destination incrementing burst
    $14 constant GPDMA_DBL_1                    \ [0x14 : 6] destination burst length minus 1, between 0 and 63
    $1a constant GPDMA_DBX                      \ [0x1a] destination byte exchange
    $1b constant GPDMA_DHX                      \ [0x1b] destination half-word exchange
    $1e constant GPDMA_DAP                      \ [0x1e] destination allocated port
    $1f constant GPDMA_DSEC                     \ [0x1f] security attribute of the GPDMA transfer to the destination
  [then]


  [ifdef] GPDMA_GPDMA_C1TR2_DEF
    \
    \ @brief GPDMA channel 1 transfer register 2
    \ Address offset: 0x114
    \ Reset value: 0x00000000
    \
    $00 constant GPDMA_REQSEL                   \ [0x00 : 8] GPDMA hardware request selection
    $09 constant GPDMA_SWREQ                    \ [0x09] software request
    $0a constant GPDMA_DREQ                     \ [0x0a] destination hardware request
    $0b constant GPDMA_BREQ                     \ [0x0b] Block hardware request
    $0c constant GPDMA_PFREQ                    \ [0x0c] Hardware request in peripheral flow control mode
    $0e constant GPDMA_TRIGM                    \ [0x0e : 2] trigger mode
    $10 constant GPDMA_TRIGSEL                  \ [0x10 : 6] trigger event input selection
    $18 constant GPDMA_TRIGPOL                  \ [0x18 : 2] trigger event polarity
    $1e constant GPDMA_TCEM                     \ [0x1e : 2] transfer complete event mode
  [then]


  [ifdef] GPDMA_GPDMA_C1BR1_DEF
    \
    \ @brief GPDMA channel 1 block register 1
    \ Address offset: 0x118
    \ Reset value: 0x00000000
    \
    $00 constant GPDMA_BNDT                     \ [0x00 : 16] block number of data bytes to transfer from the source
  [then]


  [ifdef] GPDMA_GPDMA_C1SAR_DEF
    \
    \ @brief GPDMA channel 1 source address register
    \ Address offset: 0x11C
    \ Reset value: 0x00000000
    \
    $00 constant GPDMA_SA                       \ [0x00 : 32] source address
  [then]


  [ifdef] GPDMA_GPDMA_C1DAR_DEF
    \
    \ @brief GPDMA channel 1 destination address register
    \ Address offset: 0x120
    \ Reset value: 0x00000000
    \
    $00 constant GPDMA_DA                       \ [0x00 : 32] destination address
  [then]


  [ifdef] GPDMA_GPDMA_C1LLR_DEF
    \
    \ @brief GPDMA channel 1 linked-list address register
    \ Address offset: 0x14C
    \ Reset value: 0x00000000
    \
    $02 constant GPDMA_LA                       \ [0x02 : 14] pointer (16-bit low-significant address) to the next linked-list data structure
    $10 constant GPDMA_ULL                      \ [0x10] Update GPDMA_CxLLR register from memory
    $1b constant GPDMA_UDA                      \ [0x1b] Update GPDMA_CxDAR register from memory
    $1c constant GPDMA_USA                      \ [0x1c] update GPDMA_CxSAR from memory
    $1d constant GPDMA_UB1                      \ [0x1d] Update GPDMA_CxBR1 from memory
    $1e constant GPDMA_UT2                      \ [0x1e] Update GPDMA_CxTR2 from memory
    $1f constant GPDMA_UT1                      \ [0x1f] Update GPDMA_CxTR1 from memory
  [then]


  [ifdef] GPDMA_GPDMA_C2LBAR_DEF
    \
    \ @brief GPDMA channel 2 linked-list base address register
    \ Address offset: 0x150
    \ Reset value: 0x00000000
    \
    $10 constant GPDMA_LBA                      \ [0x10 : 16] linked-list base address of GPDMA channel x
  [then]


  [ifdef] GPDMA_GPDMA_C2FCR_DEF
    \
    \ @brief GPDMA channel 2 flag clear register
    \ Address offset: 0x15C
    \ Reset value: 0x00000000
    \
    $08 constant GPDMA_TCF                      \ [0x08] transfer complete flag clear
    $09 constant GPDMA_HTF                      \ [0x09] half transfer flag clear
    $0a constant GPDMA_DTEF                     \ [0x0a] data transfer error flag clear
    $0b constant GPDMA_ULEF                     \ [0x0b] update link transfer error flag clear
    $0c constant GPDMA_USEF                     \ [0x0c] user setting error flag clear
    $0d constant GPDMA_SUSPF                    \ [0x0d] completed suspension flag clear
    $0e constant GPDMA_TOF                      \ [0x0e] trigger overrun flag clear
  [then]


  [ifdef] GPDMA_GPDMA_C2SR_DEF
    \
    \ @brief GPDMA channel 2 status register
    \ Address offset: 0x160
    \ Reset value: 0x00000001
    \
    $00 constant GPDMA_IDLEF                    \ [0x00] idle flag
    $08 constant GPDMA_TCF                      \ [0x08] transfer complete flag
    $09 constant GPDMA_HTF                      \ [0x09] half transfer flag
    $0a constant GPDMA_DTEF                     \ [0x0a] data transfer error flag
    $0b constant GPDMA_ULEF                     \ [0x0b] update link transfer error flag
    $0c constant GPDMA_USEF                     \ [0x0c] user setting error flag
    $0d constant GPDMA_SUSPF                    \ [0x0d] completed suspension flag
    $0e constant GPDMA_TOF                      \ [0x0e] trigger overrun flag
    $10 constant GPDMA_FIFOL                    \ [0x10 : 8] monitored FIFO level
  [then]


  [ifdef] GPDMA_GPDMA_C2CR_DEF
    \
    \ @brief GPDMA channel 2 control register
    \ Address offset: 0x164
    \ Reset value: 0x00000000
    \
    $00 constant GPDMA_EN                       \ [0x00] enable
    $01 constant GPDMA_RESET                    \ [0x01] reset
    $02 constant GPDMA_SUSP                     \ [0x02] suspend
    $08 constant GPDMA_TCIE                     \ [0x08] transfer complete interrupt enable
    $09 constant GPDMA_HTIE                     \ [0x09] half transfer complete interrupt enable
    $0a constant GPDMA_DTEIE                    \ [0x0a] data transfer error interrupt enable
    $0b constant GPDMA_ULEIE                    \ [0x0b] update link transfer error interrupt enable
    $0c constant GPDMA_USEIE                    \ [0x0c] user setting error interrupt enable
    $0d constant GPDMA_SUSPIE                   \ [0x0d] completed suspension interrupt enable
    $0e constant GPDMA_TOIE                     \ [0x0e] trigger overrun interrupt enable
    $10 constant GPDMA_LSM                      \ [0x10] Link step mode
    $11 constant GPDMA_LAP                      \ [0x11] linked-list allocated port
    $16 constant GPDMA_PRIO                     \ [0x16 : 2] priority level of the channel x GPDMA transfer versus others
  [then]


  [ifdef] GPDMA_GPDMA_C2TR1_DEF
    \
    \ @brief GPDMA channel 2 transfer register 1
    \ Address offset: 0x190
    \ Reset value: 0x00000000
    \
    $00 constant GPDMA_SDW_LOG2                 \ [0x00 : 2] binary logarithm of the source data width of a burst in bytes
    $03 constant GPDMA_SINC                     \ [0x03] source incrementing burst
    $04 constant GPDMA_SBL_1                    \ [0x04 : 6] source burst length minus 1, between 0 and 63
    $0b constant GPDMA_PAM                      \ [0x0b : 2] padding/alignment mode
    $0d constant GPDMA_SBX                      \ [0x0d] source byte exchange within the unaligned half-word of each source word
    $0e constant GPDMA_SAP                      \ [0x0e] source allocated port
    $0f constant GPDMA_SSEC                     \ [0x0f] security attribute of the GPDMA transfer from the source
    $10 constant GPDMA_DDW_LOG2                 \ [0x10 : 2] binary logarithm of the destination data width of a burst, in bytes
    $13 constant GPDMA_DINC                     \ [0x13] destination incrementing burst
    $14 constant GPDMA_DBL_1                    \ [0x14 : 6] destination burst length minus 1, between 0 and 63
    $1a constant GPDMA_DBX                      \ [0x1a] destination byte exchange
    $1b constant GPDMA_DHX                      \ [0x1b] destination half-word exchange
    $1e constant GPDMA_DAP                      \ [0x1e] destination allocated port
    $1f constant GPDMA_DSEC                     \ [0x1f] security attribute of the GPDMA transfer to the destination
  [then]


  [ifdef] GPDMA_GPDMA_C2TR2_DEF
    \
    \ @brief GPDMA channel 2 transfer register 2
    \ Address offset: 0x194
    \ Reset value: 0x00000000
    \
    $00 constant GPDMA_REQSEL                   \ [0x00 : 8] GPDMA hardware request selection
    $09 constant GPDMA_SWREQ                    \ [0x09] software request
    $0a constant GPDMA_DREQ                     \ [0x0a] destination hardware request
    $0b constant GPDMA_BREQ                     \ [0x0b] Block hardware request
    $0c constant GPDMA_PFREQ                    \ [0x0c] Hardware request in peripheral flow control mode
    $0e constant GPDMA_TRIGM                    \ [0x0e : 2] trigger mode
    $10 constant GPDMA_TRIGSEL                  \ [0x10 : 6] trigger event input selection
    $18 constant GPDMA_TRIGPOL                  \ [0x18 : 2] trigger event polarity
    $1e constant GPDMA_TCEM                     \ [0x1e : 2] transfer complete event mode
  [then]


  [ifdef] GPDMA_GPDMA_C2BR1_DEF
    \
    \ @brief GPDMA channel 2 block register 1
    \ Address offset: 0x198
    \ Reset value: 0x00000000
    \
    $00 constant GPDMA_BNDT                     \ [0x00 : 16] block number of data bytes to transfer from the source
  [then]


  [ifdef] GPDMA_GPDMA_C2SAR_DEF
    \
    \ @brief GPDMA channel 2 source address register
    \ Address offset: 0x19C
    \ Reset value: 0x00000000
    \
    $00 constant GPDMA_SA                       \ [0x00 : 32] source address
  [then]


  [ifdef] GPDMA_GPDMA_C2DAR_DEF
    \
    \ @brief GPDMA channel 2 destination address register
    \ Address offset: 0x1A0
    \ Reset value: 0x00000000
    \
    $00 constant GPDMA_DA                       \ [0x00 : 32] destination address
  [then]


  [ifdef] GPDMA_GPDMA_C2LLR_DEF
    \
    \ @brief GPDMA channel 2 linked-list address register
    \ Address offset: 0x1CC
    \ Reset value: 0x00000000
    \
    $02 constant GPDMA_LA                       \ [0x02 : 14] pointer (16-bit low-significant address) to the next linked-list data structure
    $10 constant GPDMA_ULL                      \ [0x10] Update GPDMA_CxLLR register from memory
    $1b constant GPDMA_UDA                      \ [0x1b] Update GPDMA_CxDAR register from memory
    $1c constant GPDMA_USA                      \ [0x1c] update GPDMA_CxSAR from memory
    $1d constant GPDMA_UB1                      \ [0x1d] Update GPDMA_CxBR1 from memory
    $1e constant GPDMA_UT2                      \ [0x1e] Update GPDMA_CxTR2 from memory
    $1f constant GPDMA_UT1                      \ [0x1f] Update GPDMA_CxTR1 from memory
  [then]


  [ifdef] GPDMA_GPDMA_C3LBAR_DEF
    \
    \ @brief GPDMA channel 3 linked-list base address register
    \ Address offset: 0x1D0
    \ Reset value: 0x00000000
    \
    $10 constant GPDMA_LBA                      \ [0x10 : 16] linked-list base address of GPDMA channel x
  [then]


  [ifdef] GPDMA_GPDMA_C3FCR_DEF
    \
    \ @brief GPDMA channel 3 flag clear register
    \ Address offset: 0x1DC
    \ Reset value: 0x00000000
    \
    $08 constant GPDMA_TCF                      \ [0x08] transfer complete flag clear
    $09 constant GPDMA_HTF                      \ [0x09] half transfer flag clear
    $0a constant GPDMA_DTEF                     \ [0x0a] data transfer error flag clear
    $0b constant GPDMA_ULEF                     \ [0x0b] update link transfer error flag clear
    $0c constant GPDMA_USEF                     \ [0x0c] user setting error flag clear
    $0d constant GPDMA_SUSPF                    \ [0x0d] completed suspension flag clear
    $0e constant GPDMA_TOF                      \ [0x0e] trigger overrun flag clear
  [then]


  [ifdef] GPDMA_GPDMA_C3SR_DEF
    \
    \ @brief GPDMA channel 3 status register
    \ Address offset: 0x1E0
    \ Reset value: 0x00000001
    \
    $00 constant GPDMA_IDLEF                    \ [0x00] idle flag
    $08 constant GPDMA_TCF                      \ [0x08] transfer complete flag
    $09 constant GPDMA_HTF                      \ [0x09] half transfer flag
    $0a constant GPDMA_DTEF                     \ [0x0a] data transfer error flag
    $0b constant GPDMA_ULEF                     \ [0x0b] update link transfer error flag
    $0c constant GPDMA_USEF                     \ [0x0c] user setting error flag
    $0d constant GPDMA_SUSPF                    \ [0x0d] completed suspension flag
    $0e constant GPDMA_TOF                      \ [0x0e] trigger overrun flag
    $10 constant GPDMA_FIFOL                    \ [0x10 : 8] monitored FIFO level
  [then]


  [ifdef] GPDMA_GPDMA_C3CR_DEF
    \
    \ @brief GPDMA channel 3 control register
    \ Address offset: 0x1E4
    \ Reset value: 0x00000000
    \
    $00 constant GPDMA_EN                       \ [0x00] enable
    $01 constant GPDMA_RESET                    \ [0x01] reset
    $02 constant GPDMA_SUSP                     \ [0x02] suspend
    $08 constant GPDMA_TCIE                     \ [0x08] transfer complete interrupt enable
    $09 constant GPDMA_HTIE                     \ [0x09] half transfer complete interrupt enable
    $0a constant GPDMA_DTEIE                    \ [0x0a] data transfer error interrupt enable
    $0b constant GPDMA_ULEIE                    \ [0x0b] update link transfer error interrupt enable
    $0c constant GPDMA_USEIE                    \ [0x0c] user setting error interrupt enable
    $0d constant GPDMA_SUSPIE                   \ [0x0d] completed suspension interrupt enable
    $0e constant GPDMA_TOIE                     \ [0x0e] trigger overrun interrupt enable
    $10 constant GPDMA_LSM                      \ [0x10] Link step mode
    $11 constant GPDMA_LAP                      \ [0x11] linked-list allocated port
    $16 constant GPDMA_PRIO                     \ [0x16 : 2] priority level of the channel x GPDMA transfer versus others
  [then]


  [ifdef] GPDMA_GPDMA_C3TR1_DEF
    \
    \ @brief GPDMA channel 3 transfer register 1
    \ Address offset: 0x210
    \ Reset value: 0x00000000
    \
    $00 constant GPDMA_SDW_LOG2                 \ [0x00 : 2] binary logarithm of the source data width of a burst in bytes
    $03 constant GPDMA_SINC                     \ [0x03] source incrementing burst
    $04 constant GPDMA_SBL_1                    \ [0x04 : 6] source burst length minus 1, between 0 and 63
    $0b constant GPDMA_PAM                      \ [0x0b : 2] padding/alignment mode
    $0d constant GPDMA_SBX                      \ [0x0d] source byte exchange within the unaligned half-word of each source word
    $0e constant GPDMA_SAP                      \ [0x0e] source allocated port
    $0f constant GPDMA_SSEC                     \ [0x0f] security attribute of the GPDMA transfer from the source
    $10 constant GPDMA_DDW_LOG2                 \ [0x10 : 2] binary logarithm of the destination data width of a burst, in bytes
    $13 constant GPDMA_DINC                     \ [0x13] destination incrementing burst
    $14 constant GPDMA_DBL_1                    \ [0x14 : 6] destination burst length minus 1, between 0 and 63
    $1a constant GPDMA_DBX                      \ [0x1a] destination byte exchange
    $1b constant GPDMA_DHX                      \ [0x1b] destination half-word exchange
    $1e constant GPDMA_DAP                      \ [0x1e] destination allocated port
    $1f constant GPDMA_DSEC                     \ [0x1f] security attribute of the GPDMA transfer to the destination
  [then]


  [ifdef] GPDMA_GPDMA_C3TR2_DEF
    \
    \ @brief GPDMA channel 3 transfer register 2
    \ Address offset: 0x214
    \ Reset value: 0x00000000
    \
    $00 constant GPDMA_REQSEL                   \ [0x00 : 8] GPDMA hardware request selection
    $09 constant GPDMA_SWREQ                    \ [0x09] software request
    $0a constant GPDMA_DREQ                     \ [0x0a] destination hardware request
    $0b constant GPDMA_BREQ                     \ [0x0b] Block hardware request
    $0c constant GPDMA_PFREQ                    \ [0x0c] Hardware request in peripheral flow control mode
    $0e constant GPDMA_TRIGM                    \ [0x0e : 2] trigger mode
    $10 constant GPDMA_TRIGSEL                  \ [0x10 : 6] trigger event input selection
    $18 constant GPDMA_TRIGPOL                  \ [0x18 : 2] trigger event polarity
    $1e constant GPDMA_TCEM                     \ [0x1e : 2] transfer complete event mode
  [then]


  [ifdef] GPDMA_GPDMA_C3BR1_DEF
    \
    \ @brief GPDMA channel 3 block register 1
    \ Address offset: 0x218
    \ Reset value: 0x00000000
    \
    $00 constant GPDMA_BNDT                     \ [0x00 : 16] block number of data bytes to transfer from the source
  [then]


  [ifdef] GPDMA_GPDMA_C3SAR_DEF
    \
    \ @brief GPDMA channel 3 source address register
    \ Address offset: 0x21C
    \ Reset value: 0x00000000
    \
    $00 constant GPDMA_SA                       \ [0x00 : 32] source address
  [then]


  [ifdef] GPDMA_GPDMA_C3DAR_DEF
    \
    \ @brief GPDMA channel 3 destination address register
    \ Address offset: 0x220
    \ Reset value: 0x00000000
    \
    $00 constant GPDMA_DA                       \ [0x00 : 32] destination address
  [then]


  [ifdef] GPDMA_GPDMA_C3LLR_DEF
    \
    \ @brief GPDMA channel 3 linked-list address register
    \ Address offset: 0x24C
    \ Reset value: 0x00000000
    \
    $02 constant GPDMA_LA                       \ [0x02 : 14] pointer (16-bit low-significant address) to the next linked-list data structure
    $10 constant GPDMA_ULL                      \ [0x10] Update GPDMA_CxLLR register from memory
    $1b constant GPDMA_UDA                      \ [0x1b] Update GPDMA_CxDAR register from memory
    $1c constant GPDMA_USA                      \ [0x1c] update GPDMA_CxSAR from memory
    $1d constant GPDMA_UB1                      \ [0x1d] Update GPDMA_CxBR1 from memory
    $1e constant GPDMA_UT2                      \ [0x1e] Update GPDMA_CxTR2 from memory
    $1f constant GPDMA_UT1                      \ [0x1f] Update GPDMA_CxTR1 from memory
  [then]


  [ifdef] GPDMA_GPDMA_C4LBAR_DEF
    \
    \ @brief GPDMA channel 4 linked-list base address register
    \ Address offset: 0x250
    \ Reset value: 0x00000000
    \
    $10 constant GPDMA_LBA                      \ [0x10 : 16] linked-list base address of GPDMA channel x
  [then]


  [ifdef] GPDMA_GPDMA_C4FCR_DEF
    \
    \ @brief GPDMA channel 4 flag clear register
    \ Address offset: 0x25C
    \ Reset value: 0x00000000
    \
    $08 constant GPDMA_TCF                      \ [0x08] transfer complete flag clear
    $09 constant GPDMA_HTF                      \ [0x09] half transfer flag clear
    $0a constant GPDMA_DTEF                     \ [0x0a] data transfer error flag clear
    $0b constant GPDMA_ULEF                     \ [0x0b] update link transfer error flag clear
    $0c constant GPDMA_USEF                     \ [0x0c] user setting error flag clear
    $0d constant GPDMA_SUSPF                    \ [0x0d] completed suspension flag clear
    $0e constant GPDMA_TOF                      \ [0x0e] trigger overrun flag clear
  [then]


  [ifdef] GPDMA_GPDMA_C4SR_DEF
    \
    \ @brief GPDMA channel 4 status register
    \ Address offset: 0x260
    \ Reset value: 0x00000001
    \
    $00 constant GPDMA_IDLEF                    \ [0x00] idle flag
    $08 constant GPDMA_TCF                      \ [0x08] transfer complete flag
    $09 constant GPDMA_HTF                      \ [0x09] half transfer flag
    $0a constant GPDMA_DTEF                     \ [0x0a] data transfer error flag
    $0b constant GPDMA_ULEF                     \ [0x0b] update link transfer error flag
    $0c constant GPDMA_USEF                     \ [0x0c] user setting error flag
    $0d constant GPDMA_SUSPF                    \ [0x0d] completed suspension flag
    $0e constant GPDMA_TOF                      \ [0x0e] trigger overrun flag
    $10 constant GPDMA_FIFOL                    \ [0x10 : 8] monitored FIFO level
  [then]


  [ifdef] GPDMA_GPDMA_C4CR_DEF
    \
    \ @brief GPDMA channel 4 control register
    \ Address offset: 0x264
    \ Reset value: 0x00000000
    \
    $00 constant GPDMA_EN                       \ [0x00] enable
    $01 constant GPDMA_RESET                    \ [0x01] reset
    $02 constant GPDMA_SUSP                     \ [0x02] suspend
    $08 constant GPDMA_TCIE                     \ [0x08] transfer complete interrupt enable
    $09 constant GPDMA_HTIE                     \ [0x09] half transfer complete interrupt enable
    $0a constant GPDMA_DTEIE                    \ [0x0a] data transfer error interrupt enable
    $0b constant GPDMA_ULEIE                    \ [0x0b] update link transfer error interrupt enable
    $0c constant GPDMA_USEIE                    \ [0x0c] user setting error interrupt enable
    $0d constant GPDMA_SUSPIE                   \ [0x0d] completed suspension interrupt enable
    $0e constant GPDMA_TOIE                     \ [0x0e] trigger overrun interrupt enable
    $10 constant GPDMA_LSM                      \ [0x10] Link step mode
    $11 constant GPDMA_LAP                      \ [0x11] linked-list allocated port
    $16 constant GPDMA_PRIO                     \ [0x16 : 2] priority level of the channel x GPDMA transfer versus others
  [then]


  [ifdef] GPDMA_GPDMA_C4TR1_DEF
    \
    \ @brief GPDMA channel 4 transfer register 1
    \ Address offset: 0x290
    \ Reset value: 0x00000000
    \
    $00 constant GPDMA_SDW_LOG2                 \ [0x00 : 2] binary logarithm of the source data width of a burst in bytes
    $03 constant GPDMA_SINC                     \ [0x03] source incrementing burst
    $04 constant GPDMA_SBL_1                    \ [0x04 : 6] source burst length minus 1, between 0 and 63
    $0b constant GPDMA_PAM                      \ [0x0b : 2] padding/alignment mode
    $0d constant GPDMA_SBX                      \ [0x0d] source byte exchange within the unaligned half-word of each source word
    $0e constant GPDMA_SAP                      \ [0x0e] source allocated port
    $0f constant GPDMA_SSEC                     \ [0x0f] security attribute of the GPDMA transfer from the source
    $10 constant GPDMA_DDW_LOG2                 \ [0x10 : 2] binary logarithm of the destination data width of a burst, in bytes
    $13 constant GPDMA_DINC                     \ [0x13] destination incrementing burst
    $14 constant GPDMA_DBL_1                    \ [0x14 : 6] destination burst length minus 1, between 0 and 63
    $1a constant GPDMA_DBX                      \ [0x1a] destination byte exchange
    $1b constant GPDMA_DHX                      \ [0x1b] destination half-word exchange
    $1e constant GPDMA_DAP                      \ [0x1e] destination allocated port
    $1f constant GPDMA_DSEC                     \ [0x1f] security attribute of the GPDMA transfer to the destination
  [then]


  [ifdef] GPDMA_GPDMA_C4TR2_DEF
    \
    \ @brief GPDMA channel 4 transfer register 2
    \ Address offset: 0x294
    \ Reset value: 0x00000000
    \
    $00 constant GPDMA_REQSEL                   \ [0x00 : 8] GPDMA hardware request selection
    $09 constant GPDMA_SWREQ                    \ [0x09] software request
    $0a constant GPDMA_DREQ                     \ [0x0a] destination hardware request
    $0b constant GPDMA_BREQ                     \ [0x0b] Block hardware request
    $0c constant GPDMA_PFREQ                    \ [0x0c] Hardware request in peripheral flow control mode
    $0e constant GPDMA_TRIGM                    \ [0x0e : 2] trigger mode
    $10 constant GPDMA_TRIGSEL                  \ [0x10 : 6] trigger event input selection
    $18 constant GPDMA_TRIGPOL                  \ [0x18 : 2] trigger event polarity
    $1e constant GPDMA_TCEM                     \ [0x1e : 2] transfer complete event mode
  [then]


  [ifdef] GPDMA_GPDMA_C4BR1_DEF
    \
    \ @brief GPDMA channel 4 block register 1
    \ Address offset: 0x298
    \ Reset value: 0x00000000
    \
    $00 constant GPDMA_BNDT                     \ [0x00 : 16] block number of data bytes to transfer from the source
  [then]


  [ifdef] GPDMA_GPDMA_C4SAR_DEF
    \
    \ @brief GPDMA channel 4 source address register
    \ Address offset: 0x29C
    \ Reset value: 0x00000000
    \
    $00 constant GPDMA_SA                       \ [0x00 : 32] source address
  [then]


  [ifdef] GPDMA_GPDMA_C4DAR_DEF
    \
    \ @brief GPDMA channel 4 destination address register
    \ Address offset: 0x2A0
    \ Reset value: 0x00000000
    \
    $00 constant GPDMA_DA                       \ [0x00 : 32] destination address
  [then]


  [ifdef] GPDMA_GPDMA_C4LLR_DEF
    \
    \ @brief GPDMA channel 4 linked-list address register
    \ Address offset: 0x2CC
    \ Reset value: 0x00000000
    \
    $02 constant GPDMA_LA                       \ [0x02 : 14] pointer (16-bit low-significant address) to the next linked-list data structure
    $10 constant GPDMA_ULL                      \ [0x10] Update GPDMA_CxLLR register from memory
    $1b constant GPDMA_UDA                      \ [0x1b] Update GPDMA_CxDAR register from memory
    $1c constant GPDMA_USA                      \ [0x1c] update GPDMA_CxSAR from memory
    $1d constant GPDMA_UB1                      \ [0x1d] Update GPDMA_CxBR1 from memory
    $1e constant GPDMA_UT2                      \ [0x1e] Update GPDMA_CxTR2 from memory
    $1f constant GPDMA_UT1                      \ [0x1f] Update GPDMA_CxTR1 from memory
  [then]


  [ifdef] GPDMA_GPDMA_C5LBAR_DEF
    \
    \ @brief GPDMA channel 5 linked-list base address register
    \ Address offset: 0x2D0
    \ Reset value: 0x00000000
    \
    $10 constant GPDMA_LBA                      \ [0x10 : 16] linked-list base address of GPDMA channel x
  [then]


  [ifdef] GPDMA_GPDMA_C5FCR_DEF
    \
    \ @brief GPDMA channel 5 flag clear register
    \ Address offset: 0x2DC
    \ Reset value: 0x00000000
    \
    $08 constant GPDMA_TCF                      \ [0x08] transfer complete flag clear
    $09 constant GPDMA_HTF                      \ [0x09] half transfer flag clear
    $0a constant GPDMA_DTEF                     \ [0x0a] data transfer error flag clear
    $0b constant GPDMA_ULEF                     \ [0x0b] update link transfer error flag clear
    $0c constant GPDMA_USEF                     \ [0x0c] user setting error flag clear
    $0d constant GPDMA_SUSPF                    \ [0x0d] completed suspension flag clear
    $0e constant GPDMA_TOF                      \ [0x0e] trigger overrun flag clear
  [then]


  [ifdef] GPDMA_GPDMA_C5SR_DEF
    \
    \ @brief GPDMA channel 5 status register
    \ Address offset: 0x2E0
    \ Reset value: 0x00000001
    \
    $00 constant GPDMA_IDLEF                    \ [0x00] idle flag
    $08 constant GPDMA_TCF                      \ [0x08] transfer complete flag
    $09 constant GPDMA_HTF                      \ [0x09] half transfer flag
    $0a constant GPDMA_DTEF                     \ [0x0a] data transfer error flag
    $0b constant GPDMA_ULEF                     \ [0x0b] update link transfer error flag
    $0c constant GPDMA_USEF                     \ [0x0c] user setting error flag
    $0d constant GPDMA_SUSPF                    \ [0x0d] completed suspension flag
    $0e constant GPDMA_TOF                      \ [0x0e] trigger overrun flag
    $10 constant GPDMA_FIFOL                    \ [0x10 : 8] monitored FIFO level
  [then]


  [ifdef] GPDMA_GPDMA_C5CR_DEF
    \
    \ @brief GPDMA channel 5 control register
    \ Address offset: 0x2E4
    \ Reset value: 0x00000000
    \
    $00 constant GPDMA_EN                       \ [0x00] enable
    $01 constant GPDMA_RESET                    \ [0x01] reset
    $02 constant GPDMA_SUSP                     \ [0x02] suspend
    $08 constant GPDMA_TCIE                     \ [0x08] transfer complete interrupt enable
    $09 constant GPDMA_HTIE                     \ [0x09] half transfer complete interrupt enable
    $0a constant GPDMA_DTEIE                    \ [0x0a] data transfer error interrupt enable
    $0b constant GPDMA_ULEIE                    \ [0x0b] update link transfer error interrupt enable
    $0c constant GPDMA_USEIE                    \ [0x0c] user setting error interrupt enable
    $0d constant GPDMA_SUSPIE                   \ [0x0d] completed suspension interrupt enable
    $0e constant GPDMA_TOIE                     \ [0x0e] trigger overrun interrupt enable
    $10 constant GPDMA_LSM                      \ [0x10] Link step mode
    $11 constant GPDMA_LAP                      \ [0x11] linked-list allocated port
    $16 constant GPDMA_PRIO                     \ [0x16 : 2] priority level of the channel x GPDMA transfer versus others
  [then]


  [ifdef] GPDMA_GPDMA_C5TR1_DEF
    \
    \ @brief GPDMA channel 5 transfer register 1
    \ Address offset: 0x310
    \ Reset value: 0x00000000
    \
    $00 constant GPDMA_SDW_LOG2                 \ [0x00 : 2] binary logarithm of the source data width of a burst in bytes
    $03 constant GPDMA_SINC                     \ [0x03] source incrementing burst
    $04 constant GPDMA_SBL_1                    \ [0x04 : 6] source burst length minus 1, between 0 and 63
    $0b constant GPDMA_PAM                      \ [0x0b : 2] padding/alignment mode
    $0d constant GPDMA_SBX                      \ [0x0d] source byte exchange within the unaligned half-word of each source word
    $0e constant GPDMA_SAP                      \ [0x0e] source allocated port
    $0f constant GPDMA_SSEC                     \ [0x0f] security attribute of the GPDMA transfer from the source
    $10 constant GPDMA_DDW_LOG2                 \ [0x10 : 2] binary logarithm of the destination data width of a burst, in bytes
    $13 constant GPDMA_DINC                     \ [0x13] destination incrementing burst
    $14 constant GPDMA_DBL_1                    \ [0x14 : 6] destination burst length minus 1, between 0 and 63
    $1a constant GPDMA_DBX                      \ [0x1a] destination byte exchange
    $1b constant GPDMA_DHX                      \ [0x1b] destination half-word exchange
    $1e constant GPDMA_DAP                      \ [0x1e] destination allocated port
    $1f constant GPDMA_DSEC                     \ [0x1f] security attribute of the GPDMA transfer to the destination
  [then]


  [ifdef] GPDMA_GPDMA_C5TR2_DEF
    \
    \ @brief GPDMA channel 5 transfer register 2
    \ Address offset: 0x314
    \ Reset value: 0x00000000
    \
    $00 constant GPDMA_REQSEL                   \ [0x00 : 8] GPDMA hardware request selection
    $09 constant GPDMA_SWREQ                    \ [0x09] software request
    $0a constant GPDMA_DREQ                     \ [0x0a] destination hardware request
    $0b constant GPDMA_BREQ                     \ [0x0b] Block hardware request
    $0c constant GPDMA_PFREQ                    \ [0x0c] Hardware request in peripheral flow control mode
    $0e constant GPDMA_TRIGM                    \ [0x0e : 2] trigger mode
    $10 constant GPDMA_TRIGSEL                  \ [0x10 : 6] trigger event input selection
    $18 constant GPDMA_TRIGPOL                  \ [0x18 : 2] trigger event polarity
    $1e constant GPDMA_TCEM                     \ [0x1e : 2] transfer complete event mode
  [then]


  [ifdef] GPDMA_GPDMA_C5BR1_DEF
    \
    \ @brief GPDMA channel 5 block register 1
    \ Address offset: 0x318
    \ Reset value: 0x00000000
    \
    $00 constant GPDMA_BNDT                     \ [0x00 : 16] block number of data bytes to transfer from the source
  [then]


  [ifdef] GPDMA_GPDMA_C5SAR_DEF
    \
    \ @brief GPDMA channel 5 source address register
    \ Address offset: 0x31C
    \ Reset value: 0x00000000
    \
    $00 constant GPDMA_SA                       \ [0x00 : 32] source address
  [then]


  [ifdef] GPDMA_GPDMA_C5DAR_DEF
    \
    \ @brief GPDMA channel 5 destination address register
    \ Address offset: 0x320
    \ Reset value: 0x00000000
    \
    $00 constant GPDMA_DA                       \ [0x00 : 32] destination address
  [then]


  [ifdef] GPDMA_GPDMA_C5LLR_DEF
    \
    \ @brief GPDMA channel 5 linked-list address register
    \ Address offset: 0x34C
    \ Reset value: 0x00000000
    \
    $02 constant GPDMA_LA                       \ [0x02 : 14] pointer (16-bit low-significant address) to the next linked-list data structure
    $10 constant GPDMA_ULL                      \ [0x10] Update GPDMA_CxLLR register from memory
    $1b constant GPDMA_UDA                      \ [0x1b] Update GPDMA_CxDAR register from memory
    $1c constant GPDMA_USA                      \ [0x1c] update GPDMA_CxSAR from memory
    $1d constant GPDMA_UB1                      \ [0x1d] Update GPDMA_CxBR1 from memory
    $1e constant GPDMA_UT2                      \ [0x1e] Update GPDMA_CxTR2 from memory
    $1f constant GPDMA_UT1                      \ [0x1f] Update GPDMA_CxTR1 from memory
  [then]


  [ifdef] GPDMA_GPDMA_C6LBAR_DEF
    \
    \ @brief GPDMA channel 6 linked-list base address register
    \ Address offset: 0x350
    \ Reset value: 0x00000000
    \
    $10 constant GPDMA_LBA                      \ [0x10 : 16] linked-list base address of GPDMA channel x
  [then]


  [ifdef] GPDMA_GPDMA_C6FCR_DEF
    \
    \ @brief GPDMA channel 6 flag clear register
    \ Address offset: 0x35C
    \ Reset value: 0x00000000
    \
    $08 constant GPDMA_TCF                      \ [0x08] transfer complete flag clear
    $09 constant GPDMA_HTF                      \ [0x09] half transfer flag clear
    $0a constant GPDMA_DTEF                     \ [0x0a] data transfer error flag clear
    $0b constant GPDMA_ULEF                     \ [0x0b] update link transfer error flag clear
    $0c constant GPDMA_USEF                     \ [0x0c] user setting error flag clear
    $0d constant GPDMA_SUSPF                    \ [0x0d] completed suspension flag clear
    $0e constant GPDMA_TOF                      \ [0x0e] trigger overrun flag clear
  [then]


  [ifdef] GPDMA_GPDMA_C6SR_DEF
    \
    \ @brief GPDMA channel 6 status register
    \ Address offset: 0x360
    \ Reset value: 0x00000001
    \
    $00 constant GPDMA_IDLEF                    \ [0x00] idle flag
    $08 constant GPDMA_TCF                      \ [0x08] transfer complete flag
    $09 constant GPDMA_HTF                      \ [0x09] half transfer flag
    $0a constant GPDMA_DTEF                     \ [0x0a] data transfer error flag
    $0b constant GPDMA_ULEF                     \ [0x0b] update link transfer error flag
    $0c constant GPDMA_USEF                     \ [0x0c] user setting error flag
    $0d constant GPDMA_SUSPF                    \ [0x0d] completed suspension flag
    $0e constant GPDMA_TOF                      \ [0x0e] trigger overrun flag
    $10 constant GPDMA_FIFOL                    \ [0x10 : 8] monitored FIFO level
  [then]


  [ifdef] GPDMA_GPDMA_C6CR_DEF
    \
    \ @brief GPDMA channel 6 control register
    \ Address offset: 0x364
    \ Reset value: 0x00000000
    \
    $00 constant GPDMA_EN                       \ [0x00] enable
    $01 constant GPDMA_RESET                    \ [0x01] reset
    $02 constant GPDMA_SUSP                     \ [0x02] suspend
    $08 constant GPDMA_TCIE                     \ [0x08] transfer complete interrupt enable
    $09 constant GPDMA_HTIE                     \ [0x09] half transfer complete interrupt enable
    $0a constant GPDMA_DTEIE                    \ [0x0a] data transfer error interrupt enable
    $0b constant GPDMA_ULEIE                    \ [0x0b] update link transfer error interrupt enable
    $0c constant GPDMA_USEIE                    \ [0x0c] user setting error interrupt enable
    $0d constant GPDMA_SUSPIE                   \ [0x0d] completed suspension interrupt enable
    $0e constant GPDMA_TOIE                     \ [0x0e] trigger overrun interrupt enable
    $10 constant GPDMA_LSM                      \ [0x10] Link step mode
    $11 constant GPDMA_LAP                      \ [0x11] linked-list allocated port
    $16 constant GPDMA_PRIO                     \ [0x16 : 2] priority level of the channel x GPDMA transfer versus others
  [then]


  [ifdef] GPDMA_GPDMA_C6TR1_DEF
    \
    \ @brief GPDMA channel 6 transfer register 1
    \ Address offset: 0x390
    \ Reset value: 0x00000000
    \
    $00 constant GPDMA_SDW_LOG2                 \ [0x00 : 2] binary logarithm of the source data width of a burst in bytes
    $03 constant GPDMA_SINC                     \ [0x03] source incrementing burst
    $04 constant GPDMA_SBL_1                    \ [0x04 : 6] source burst length minus 1, between 0 and 63
    $0b constant GPDMA_PAM                      \ [0x0b : 2] padding/alignment mode
    $0d constant GPDMA_SBX                      \ [0x0d] source byte exchange within the unaligned half-word of each source word
    $0e constant GPDMA_SAP                      \ [0x0e] source allocated port
    $0f constant GPDMA_SSEC                     \ [0x0f] security attribute of the GPDMA transfer from the source
    $10 constant GPDMA_DDW_LOG2                 \ [0x10 : 2] binary logarithm of the destination data width of a burst, in bytes
    $13 constant GPDMA_DINC                     \ [0x13] destination incrementing burst
    $14 constant GPDMA_DBL_1                    \ [0x14 : 6] destination burst length minus 1, between 0 and 63
    $1a constant GPDMA_DBX                      \ [0x1a] destination byte exchange
    $1b constant GPDMA_DHX                      \ [0x1b] destination half-word exchange
    $1e constant GPDMA_DAP                      \ [0x1e] destination allocated port
    $1f constant GPDMA_DSEC                     \ [0x1f] security attribute of the GPDMA transfer to the destination
  [then]


  [ifdef] GPDMA_GPDMA_C6TR2_DEF
    \
    \ @brief GPDMA channel 6 transfer register 2
    \ Address offset: 0x394
    \ Reset value: 0x00000000
    \
    $00 constant GPDMA_REQSEL                   \ [0x00 : 8] GPDMA hardware request selection
    $09 constant GPDMA_SWREQ                    \ [0x09] software request
    $0a constant GPDMA_DREQ                     \ [0x0a] destination hardware request
    $0b constant GPDMA_BREQ                     \ [0x0b] Block hardware request
    $0c constant GPDMA_PFREQ                    \ [0x0c] Hardware request in peripheral flow control mode
    $0e constant GPDMA_TRIGM                    \ [0x0e : 2] trigger mode
    $10 constant GPDMA_TRIGSEL                  \ [0x10 : 6] trigger event input selection
    $18 constant GPDMA_TRIGPOL                  \ [0x18 : 2] trigger event polarity
    $1e constant GPDMA_TCEM                     \ [0x1e : 2] transfer complete event mode
  [then]


  [ifdef] GPDMA_GPDMA_C6BR1_DEF
    \
    \ @brief GPDMA channel 6 alternate block register 1
    \ Address offset: 0x398
    \ Reset value: 0x00000000
    \
    $00 constant GPDMA_BNDT                     \ [0x00 : 16] block number of data bytes to transfer from the source
    $10 constant GPDMA_BRC                      \ [0x10 : 11] Block repeat counter
    $1c constant GPDMA_SDEC                     \ [0x1c] source address decrement
    $1d constant GPDMA_DDEC                     \ [0x1d] destination address decrement
    $1e constant GPDMA_BRSDEC                   \ [0x1e] Block repeat source address decrement
    $1f constant GPDMA_BRDDEC                   \ [0x1f] Block repeat destination address decrement
  [then]


  [ifdef] GPDMA_GPDMA_C6SAR_DEF
    \
    \ @brief GPDMA channel 6 source address register
    \ Address offset: 0x39C
    \ Reset value: 0x00000000
    \
    $00 constant GPDMA_SA                       \ [0x00 : 32] source address
  [then]


  [ifdef] GPDMA_GPDMA_C6DAR_DEF
    \
    \ @brief GPDMA channel 6 destination address register
    \ Address offset: 0x3A0
    \ Reset value: 0x00000000
    \
    $00 constant GPDMA_DA                       \ [0x00 : 32] destination address
  [then]


  [ifdef] GPDMA_GPDMA_C6TR3_DEF
    \
    \ @brief GPDMA channel 6 transfer register 3
    \ Address offset: 0x3A4
    \ Reset value: 0x00000000
    \
    $00 constant GPDMA_SAO                      \ [0x00 : 13] source address offset increment
    $10 constant GPDMA_DAO                      \ [0x10 : 13] destination address offset increment
  [then]


  [ifdef] GPDMA_GPDMA_C6BR2_DEF
    \
    \ @brief GPDMA channel 6 block register 2
    \ Address offset: 0x3A8
    \ Reset value: 0x00000000
    \
    $00 constant GPDMA_BRSAO                    \ [0x00 : 16] Block repeated source address offset
    $10 constant GPDMA_BRDAO                    \ [0x10 : 16] Block repeated destination address offset
  [then]


  [ifdef] GPDMA_GPDMA_C6LLR_DEF
    \
    \ @brief GPDMA channel 6 alternate linked-list address register
    \ Address offset: 0x3CC
    \ Reset value: 0x00000000
    \
    $02 constant GPDMA_LA                       \ [0x02 : 14] pointer (16-bit low-significant address) to the next linked-list data structure
    $10 constant GPDMA_ULL                      \ [0x10] Update GPDMA_CxLLR register from memory
    $19 constant GPDMA_UB2                      \ [0x19] Update GPDMA_CxBR2 from memory
    $1a constant GPDMA_UT3                      \ [0x1a] Update GPDMA_CxTR3 from memory
    $1b constant GPDMA_UDA                      \ [0x1b] Update GPDMA_CxDAR register from memory
    $1c constant GPDMA_USA                      \ [0x1c] update GPDMA_CxSAR from memory
    $1d constant GPDMA_UB1                      \ [0x1d] Update GPDMA_CxBR1 from memory
    $1e constant GPDMA_UT2                      \ [0x1e] Update GPDMA_CxTR2 from memory
    $1f constant GPDMA_UT1                      \ [0x1f] Update GPDMA_CxTR1 from memory
  [then]


  [ifdef] GPDMA_GPDMA_C7LBAR_DEF
    \
    \ @brief GPDMA channel 7 linked-list base address register
    \ Address offset: 0x3D0
    \ Reset value: 0x00000000
    \
    $10 constant GPDMA_LBA                      \ [0x10 : 16] linked-list base address of GPDMA channel x
  [then]


  [ifdef] GPDMA_GPDMA_C7FCR_DEF
    \
    \ @brief GPDMA channel 7 flag clear register
    \ Address offset: 0x3DC
    \ Reset value: 0x00000000
    \
    $08 constant GPDMA_TCF                      \ [0x08] transfer complete flag clear
    $09 constant GPDMA_HTF                      \ [0x09] half transfer flag clear
    $0a constant GPDMA_DTEF                     \ [0x0a] data transfer error flag clear
    $0b constant GPDMA_ULEF                     \ [0x0b] update link transfer error flag clear
    $0c constant GPDMA_USEF                     \ [0x0c] user setting error flag clear
    $0d constant GPDMA_SUSPF                    \ [0x0d] completed suspension flag clear
    $0e constant GPDMA_TOF                      \ [0x0e] trigger overrun flag clear
  [then]


  [ifdef] GPDMA_GPDMA_C7SR_DEF
    \
    \ @brief GPDMA channel 7 status register
    \ Address offset: 0x3E0
    \ Reset value: 0x00000001
    \
    $00 constant GPDMA_IDLEF                    \ [0x00] idle flag
    $08 constant GPDMA_TCF                      \ [0x08] transfer complete flag
    $09 constant GPDMA_HTF                      \ [0x09] half transfer flag
    $0a constant GPDMA_DTEF                     \ [0x0a] data transfer error flag
    $0b constant GPDMA_ULEF                     \ [0x0b] update link transfer error flag
    $0c constant GPDMA_USEF                     \ [0x0c] user setting error flag
    $0d constant GPDMA_SUSPF                    \ [0x0d] completed suspension flag
    $0e constant GPDMA_TOF                      \ [0x0e] trigger overrun flag
    $10 constant GPDMA_FIFOL                    \ [0x10 : 8] monitored FIFO level
  [then]


  [ifdef] GPDMA_GPDMA_C7CR_DEF
    \
    \ @brief GPDMA channel 7 control register
    \ Address offset: 0x3E4
    \ Reset value: 0x00000000
    \
    $00 constant GPDMA_EN                       \ [0x00] enable
    $01 constant GPDMA_RESET                    \ [0x01] reset
    $02 constant GPDMA_SUSP                     \ [0x02] suspend
    $08 constant GPDMA_TCIE                     \ [0x08] transfer complete interrupt enable
    $09 constant GPDMA_HTIE                     \ [0x09] half transfer complete interrupt enable
    $0a constant GPDMA_DTEIE                    \ [0x0a] data transfer error interrupt enable
    $0b constant GPDMA_ULEIE                    \ [0x0b] update link transfer error interrupt enable
    $0c constant GPDMA_USEIE                    \ [0x0c] user setting error interrupt enable
    $0d constant GPDMA_SUSPIE                   \ [0x0d] completed suspension interrupt enable
    $0e constant GPDMA_TOIE                     \ [0x0e] trigger overrun interrupt enable
    $10 constant GPDMA_LSM                      \ [0x10] Link step mode
    $11 constant GPDMA_LAP                      \ [0x11] linked-list allocated port
    $16 constant GPDMA_PRIO                     \ [0x16 : 2] priority level of the channel x GPDMA transfer versus others
  [then]


  [ifdef] GPDMA_GPDMA_C7TR1_DEF
    \
    \ @brief GPDMA channel 7 transfer register 1
    \ Address offset: 0x410
    \ Reset value: 0x00000000
    \
    $00 constant GPDMA_SDW_LOG2                 \ [0x00 : 2] binary logarithm of the source data width of a burst in bytes
    $03 constant GPDMA_SINC                     \ [0x03] source incrementing burst
    $04 constant GPDMA_SBL_1                    \ [0x04 : 6] source burst length minus 1, between 0 and 63
    $0b constant GPDMA_PAM                      \ [0x0b : 2] padding/alignment mode
    $0d constant GPDMA_SBX                      \ [0x0d] source byte exchange within the unaligned half-word of each source word
    $0e constant GPDMA_SAP                      \ [0x0e] source allocated port
    $0f constant GPDMA_SSEC                     \ [0x0f] security attribute of the GPDMA transfer from the source
    $10 constant GPDMA_DDW_LOG2                 \ [0x10 : 2] binary logarithm of the destination data width of a burst, in bytes
    $13 constant GPDMA_DINC                     \ [0x13] destination incrementing burst
    $14 constant GPDMA_DBL_1                    \ [0x14 : 6] destination burst length minus 1, between 0 and 63
    $1a constant GPDMA_DBX                      \ [0x1a] destination byte exchange
    $1b constant GPDMA_DHX                      \ [0x1b] destination half-word exchange
    $1e constant GPDMA_DAP                      \ [0x1e] destination allocated port
    $1f constant GPDMA_DSEC                     \ [0x1f] security attribute of the GPDMA transfer to the destination
  [then]


  [ifdef] GPDMA_GPDMA_C7TR2_DEF
    \
    \ @brief GPDMA channel 7 transfer register 2
    \ Address offset: 0x414
    \ Reset value: 0x00000000
    \
    $00 constant GPDMA_REQSEL                   \ [0x00 : 8] GPDMA hardware request selection
    $09 constant GPDMA_SWREQ                    \ [0x09] software request
    $0a constant GPDMA_DREQ                     \ [0x0a] destination hardware request
    $0b constant GPDMA_BREQ                     \ [0x0b] Block hardware request
    $0c constant GPDMA_PFREQ                    \ [0x0c] Hardware request in peripheral flow control mode
    $0e constant GPDMA_TRIGM                    \ [0x0e : 2] trigger mode
    $10 constant GPDMA_TRIGSEL                  \ [0x10 : 6] trigger event input selection
    $18 constant GPDMA_TRIGPOL                  \ [0x18 : 2] trigger event polarity
    $1e constant GPDMA_TCEM                     \ [0x1e : 2] transfer complete event mode
  [then]


  [ifdef] GPDMA_GPDMA_C7BR1_DEF
    \
    \ @brief GPDMA channel 7 alternate block register 1
    \ Address offset: 0x418
    \ Reset value: 0x00000000
    \
    $00 constant GPDMA_BNDT                     \ [0x00 : 16] block number of data bytes to transfer from the source
    $10 constant GPDMA_BRC                      \ [0x10 : 11] Block repeat counter
    $1c constant GPDMA_SDEC                     \ [0x1c] source address decrement
    $1d constant GPDMA_DDEC                     \ [0x1d] destination address decrement
    $1e constant GPDMA_BRSDEC                   \ [0x1e] Block repeat source address decrement
    $1f constant GPDMA_BRDDEC                   \ [0x1f] Block repeat destination address decrement
  [then]


  [ifdef] GPDMA_GPDMA_C7SAR_DEF
    \
    \ @brief GPDMA channel 7 source address register
    \ Address offset: 0x41C
    \ Reset value: 0x00000000
    \
    $00 constant GPDMA_SA                       \ [0x00 : 32] source address
  [then]


  [ifdef] GPDMA_GPDMA_C7DAR_DEF
    \
    \ @brief GPDMA channel 7 destination address register
    \ Address offset: 0x420
    \ Reset value: 0x00000000
    \
    $00 constant GPDMA_DA                       \ [0x00 : 32] destination address
  [then]


  [ifdef] GPDMA_GPDMA_C7TR3_DEF
    \
    \ @brief GPDMA channel 7 transfer register 3
    \ Address offset: 0x424
    \ Reset value: 0x00000000
    \
    $00 constant GPDMA_SAO                      \ [0x00 : 13] source address offset increment
    $10 constant GPDMA_DAO                      \ [0x10 : 13] destination address offset increment
  [then]


  [ifdef] GPDMA_GPDMA_C7BR2_DEF
    \
    \ @brief GPDMA channel 7 block register 2
    \ Address offset: 0x428
    \ Reset value: 0x00000000
    \
    $00 constant GPDMA_BRSAO                    \ [0x00 : 16] Block repeated source address offset
    $10 constant GPDMA_BRDAO                    \ [0x10 : 16] Block repeated destination address offset
  [then]


  [ifdef] GPDMA_GPDMA_C7LLR_DEF
    \
    \ @brief GPDMA channel 7 alternate linked-list address register
    \ Address offset: 0x44C
    \ Reset value: 0x00000000
    \
    $02 constant GPDMA_LA                       \ [0x02 : 14] pointer (16-bit low-significant address) to the next linked-list data structure
    $10 constant GPDMA_ULL                      \ [0x10] Update GPDMA_CxLLR register from memory
    $19 constant GPDMA_UB2                      \ [0x19] Update GPDMA_CxBR2 from memory
    $1a constant GPDMA_UT3                      \ [0x1a] Update GPDMA_CxTR3 from memory
    $1b constant GPDMA_UDA                      \ [0x1b] Update GPDMA_CxDAR register from memory
    $1c constant GPDMA_USA                      \ [0x1c] update GPDMA_CxSAR from memory
    $1d constant GPDMA_UB1                      \ [0x1d] Update GPDMA_CxBR1 from memory
    $1e constant GPDMA_UT2                      \ [0x1e] Update GPDMA_CxTR2 from memory
    $1f constant GPDMA_UT1                      \ [0x1f] Update GPDMA_CxTR1 from memory
  [then]

  \
  \ @brief GPDMA register block
  \
  $00 constant GPDMA_GPDMA_SECCFGR      \ GPDMA secure configuration register
  $04 constant GPDMA_GPDMA_PRIVCFGR     \ GPDMA privileged configuration register
  $08 constant GPDMA_GPDMA_RCFGLOCKR    \ GPDMA configuration lock register
  $0C constant GPDMA_GPDMA_MISR         \ GPDMA nonsecure masked interrupt status register
  $10 constant GPDMA_GPDMA_SMISR        \ GPDMA secure masked interrupt status register
  $50 constant GPDMA_GPDMA_C0LBAR       \ GPDMA channel 0 linked-list base address register
  $5C constant GPDMA_GPDMA_C0FCR        \ GPDMA channel 0 flag clear register
  $60 constant GPDMA_GPDMA_C0SR         \ GPDMA channel 0 status register
  $64 constant GPDMA_GPDMA_C0CR         \ GPDMA channel 0 control register
  $90 constant GPDMA_GPDMA_C0TR1        \ GPDMA channel 0 transfer register 1
  $94 constant GPDMA_GPDMA_C0TR2        \ GPDMA channel 0 transfer register 2
  $98 constant GPDMA_GPDMA_C0BR1        \ GPDMA channel 0 block register 1
  $9C constant GPDMA_GPDMA_C0SAR        \ GPDMA channel 0 source address register
  $A0 constant GPDMA_GPDMA_C0DAR        \ GPDMA channel 0 destination address register
  $CC constant GPDMA_GPDMA_C0LLR        \ GPDMA channel 0 linked-list address register
  $D0 constant GPDMA_GPDMA_C1LBAR       \ GPDMA channel 1 linked-list base address register
  $DC constant GPDMA_GPDMA_C1FCR        \ GPDMA channel 1 flag clear register
  $E0 constant GPDMA_GPDMA_C1SR         \ GPDMA channel 1 status register
  $E4 constant GPDMA_GPDMA_C1CR         \ GPDMA channel 1 control register
  $110 constant GPDMA_GPDMA_C1TR1       \ GPDMA channel 1 transfer register 1
  $114 constant GPDMA_GPDMA_C1TR2       \ GPDMA channel 1 transfer register 2
  $118 constant GPDMA_GPDMA_C1BR1       \ GPDMA channel 1 block register 1
  $11C constant GPDMA_GPDMA_C1SAR       \ GPDMA channel 1 source address register
  $120 constant GPDMA_GPDMA_C1DAR       \ GPDMA channel 1 destination address register
  $14C constant GPDMA_GPDMA_C1LLR       \ GPDMA channel 1 linked-list address register
  $150 constant GPDMA_GPDMA_C2LBAR      \ GPDMA channel 2 linked-list base address register
  $15C constant GPDMA_GPDMA_C2FCR       \ GPDMA channel 2 flag clear register
  $160 constant GPDMA_GPDMA_C2SR        \ GPDMA channel 2 status register
  $164 constant GPDMA_GPDMA_C2CR        \ GPDMA channel 2 control register
  $190 constant GPDMA_GPDMA_C2TR1       \ GPDMA channel 2 transfer register 1
  $194 constant GPDMA_GPDMA_C2TR2       \ GPDMA channel 2 transfer register 2
  $198 constant GPDMA_GPDMA_C2BR1       \ GPDMA channel 2 block register 1
  $19C constant GPDMA_GPDMA_C2SAR       \ GPDMA channel 2 source address register
  $1A0 constant GPDMA_GPDMA_C2DAR       \ GPDMA channel 2 destination address register
  $1CC constant GPDMA_GPDMA_C2LLR       \ GPDMA channel 2 linked-list address register
  $1D0 constant GPDMA_GPDMA_C3LBAR      \ GPDMA channel 3 linked-list base address register
  $1DC constant GPDMA_GPDMA_C3FCR       \ GPDMA channel 3 flag clear register
  $1E0 constant GPDMA_GPDMA_C3SR        \ GPDMA channel 3 status register
  $1E4 constant GPDMA_GPDMA_C3CR        \ GPDMA channel 3 control register
  $210 constant GPDMA_GPDMA_C3TR1       \ GPDMA channel 3 transfer register 1
  $214 constant GPDMA_GPDMA_C3TR2       \ GPDMA channel 3 transfer register 2
  $218 constant GPDMA_GPDMA_C3BR1       \ GPDMA channel 3 block register 1
  $21C constant GPDMA_GPDMA_C3SAR       \ GPDMA channel 3 source address register
  $220 constant GPDMA_GPDMA_C3DAR       \ GPDMA channel 3 destination address register
  $24C constant GPDMA_GPDMA_C3LLR       \ GPDMA channel 3 linked-list address register
  $250 constant GPDMA_GPDMA_C4LBAR      \ GPDMA channel 4 linked-list base address register
  $25C constant GPDMA_GPDMA_C4FCR       \ GPDMA channel 4 flag clear register
  $260 constant GPDMA_GPDMA_C4SR        \ GPDMA channel 4 status register
  $264 constant GPDMA_GPDMA_C4CR        \ GPDMA channel 4 control register
  $290 constant GPDMA_GPDMA_C4TR1       \ GPDMA channel 4 transfer register 1
  $294 constant GPDMA_GPDMA_C4TR2       \ GPDMA channel 4 transfer register 2
  $298 constant GPDMA_GPDMA_C4BR1       \ GPDMA channel 4 block register 1
  $29C constant GPDMA_GPDMA_C4SAR       \ GPDMA channel 4 source address register
  $2A0 constant GPDMA_GPDMA_C4DAR       \ GPDMA channel 4 destination address register
  $2CC constant GPDMA_GPDMA_C4LLR       \ GPDMA channel 4 linked-list address register
  $2D0 constant GPDMA_GPDMA_C5LBAR      \ GPDMA channel 5 linked-list base address register
  $2DC constant GPDMA_GPDMA_C5FCR       \ GPDMA channel 5 flag clear register
  $2E0 constant GPDMA_GPDMA_C5SR        \ GPDMA channel 5 status register
  $2E4 constant GPDMA_GPDMA_C5CR        \ GPDMA channel 5 control register
  $310 constant GPDMA_GPDMA_C5TR1       \ GPDMA channel 5 transfer register 1
  $314 constant GPDMA_GPDMA_C5TR2       \ GPDMA channel 5 transfer register 2
  $318 constant GPDMA_GPDMA_C5BR1       \ GPDMA channel 5 block register 1
  $31C constant GPDMA_GPDMA_C5SAR       \ GPDMA channel 5 source address register
  $320 constant GPDMA_GPDMA_C5DAR       \ GPDMA channel 5 destination address register
  $34C constant GPDMA_GPDMA_C5LLR       \ GPDMA channel 5 linked-list address register
  $350 constant GPDMA_GPDMA_C6LBAR      \ GPDMA channel 6 linked-list base address register
  $35C constant GPDMA_GPDMA_C6FCR       \ GPDMA channel 6 flag clear register
  $360 constant GPDMA_GPDMA_C6SR        \ GPDMA channel 6 status register
  $364 constant GPDMA_GPDMA_C6CR        \ GPDMA channel 6 control register
  $390 constant GPDMA_GPDMA_C6TR1       \ GPDMA channel 6 transfer register 1
  $394 constant GPDMA_GPDMA_C6TR2       \ GPDMA channel 6 transfer register 2
  $398 constant GPDMA_GPDMA_C6BR1       \ GPDMA channel 6 alternate block register 1
  $39C constant GPDMA_GPDMA_C6SAR       \ GPDMA channel 6 source address register
  $3A0 constant GPDMA_GPDMA_C6DAR       \ GPDMA channel 6 destination address register
  $3A4 constant GPDMA_GPDMA_C6TR3       \ GPDMA channel 6 transfer register 3
  $3A8 constant GPDMA_GPDMA_C6BR2       \ GPDMA channel 6 block register 2
  $3CC constant GPDMA_GPDMA_C6LLR       \ GPDMA channel 6 alternate linked-list address register
  $3D0 constant GPDMA_GPDMA_C7LBAR      \ GPDMA channel 7 linked-list base address register
  $3DC constant GPDMA_GPDMA_C7FCR       \ GPDMA channel 7 flag clear register
  $3E0 constant GPDMA_GPDMA_C7SR        \ GPDMA channel 7 status register
  $3E4 constant GPDMA_GPDMA_C7CR        \ GPDMA channel 7 control register
  $410 constant GPDMA_GPDMA_C7TR1       \ GPDMA channel 7 transfer register 1
  $414 constant GPDMA_GPDMA_C7TR2       \ GPDMA channel 7 transfer register 2
  $418 constant GPDMA_GPDMA_C7BR1       \ GPDMA channel 7 alternate block register 1
  $41C constant GPDMA_GPDMA_C7SAR       \ GPDMA channel 7 source address register
  $420 constant GPDMA_GPDMA_C7DAR       \ GPDMA channel 7 destination address register
  $424 constant GPDMA_GPDMA_C7TR3       \ GPDMA channel 7 transfer register 3
  $428 constant GPDMA_GPDMA_C7BR2       \ GPDMA channel 7 block register 2
  $44C constant GPDMA_GPDMA_C7LLR       \ GPDMA channel 7 alternate linked-list address register

: GPDMA_DEF ; [then]
