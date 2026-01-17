\
\ @file hpdma.fs
\ @brief High-performance direct memory access controller
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] HPDMA_DEF

  [ifdef] HPDMA_HPDMA_SECCFGR_DEF
    \
    \ @brief HPDMA secure configuration register
    \ Address offset: 0x00
    \ Reset value: 0x00000000
    \
    $00 constant HPDMA_SEC0                     \ [0x00] secure state of channel x
    $01 constant HPDMA_SEC1                     \ [0x01] secure state of channel x
    $02 constant HPDMA_SEC2                     \ [0x02] secure state of channel x
    $03 constant HPDMA_SEC3                     \ [0x03] secure state of channel x
    $04 constant HPDMA_SEC4                     \ [0x04] secure state of channel x
    $05 constant HPDMA_SEC5                     \ [0x05] secure state of channel x
    $06 constant HPDMA_SEC6                     \ [0x06] secure state of channel x
    $07 constant HPDMA_SEC7                     \ [0x07] secure state of channel x
    $08 constant HPDMA_SEC8                     \ [0x08] secure state of channel x
    $09 constant HPDMA_SEC9                     \ [0x09] secure state of channel x
    $0a constant HPDMA_SEC10                    \ [0x0a] secure state of channel x
    $0b constant HPDMA_SEC11                    \ [0x0b] secure state of channel x
    $0c constant HPDMA_SEC12                    \ [0x0c] secure state of channel x
    $0d constant HPDMA_SEC13                    \ [0x0d] secure state of channel x
    $0e constant HPDMA_SEC14                    \ [0x0e] secure state of channel x
    $0f constant HPDMA_SEC15                    \ [0x0f] secure state of channel x
  [then]


  [ifdef] HPDMA_HPDMA_PRIVCFGR_DEF
    \
    \ @brief HPDMA privileged configuration register
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $00 constant HPDMA_PRIV0                    \ [0x00] privileged state of channel x
    $01 constant HPDMA_PRIV1                    \ [0x01] privileged state of channel x
    $02 constant HPDMA_PRIV2                    \ [0x02] privileged state of channel x
    $03 constant HPDMA_PRIV3                    \ [0x03] privileged state of channel x
    $04 constant HPDMA_PRIV4                    \ [0x04] privileged state of channel x
    $05 constant HPDMA_PRIV5                    \ [0x05] privileged state of channel x
    $06 constant HPDMA_PRIV6                    \ [0x06] privileged state of channel x
    $07 constant HPDMA_PRIV7                    \ [0x07] privileged state of channel x
    $08 constant HPDMA_PRIV8                    \ [0x08] privileged state of channel x
    $09 constant HPDMA_PRIV9                    \ [0x09] privileged state of channel x
    $0a constant HPDMA_PRIV10                   \ [0x0a] privileged state of channel x
    $0b constant HPDMA_PRIV11                   \ [0x0b] privileged state of channel x
    $0c constant HPDMA_PRIV12                   \ [0x0c] privileged state of channel x
    $0d constant HPDMA_PRIV13                   \ [0x0d] privileged state of channel x
    $0e constant HPDMA_PRIV14                   \ [0x0e] privileged state of channel x
    $0f constant HPDMA_PRIV15                   \ [0x0f] privileged state of channel x
  [then]


  [ifdef] HPDMA_HPDMA_RCFGLOCKR_DEF
    \
    \ @brief HPDMA configuration lock register
    \ Address offset: 0x08
    \ Reset value: 0x00000000
    \
    $00 constant HPDMA_LOCK0                    \ [0x00] lock the configuration of HPDMA_SECCFGR.SECx, HPDMA_PRIVCFGR.PRIVx, and HPDMA_CxCIDCFGR until a global HPDMA reset
    $01 constant HPDMA_LOCK1                    \ [0x01] lock the configuration of HPDMA_SECCFGR.SECx, HPDMA_PRIVCFGR.PRIVx, and HPDMA_CxCIDCFGR until a global HPDMA reset
    $02 constant HPDMA_LOCK2                    \ [0x02] lock the configuration of HPDMA_SECCFGR.SECx, HPDMA_PRIVCFGR.PRIVx, and HPDMA_CxCIDCFGR until a global HPDMA reset
    $03 constant HPDMA_LOCK3                    \ [0x03] lock the configuration of HPDMA_SECCFGR.SECx, HPDMA_PRIVCFGR.PRIVx, and HPDMA_CxCIDCFGR until a global HPDMA reset
    $04 constant HPDMA_LOCK4                    \ [0x04] lock the configuration of HPDMA_SECCFGR.SECx, HPDMA_PRIVCFGR.PRIVx, and HPDMA_CxCIDCFGR until a global HPDMA reset
    $05 constant HPDMA_LOCK5                    \ [0x05] lock the configuration of HPDMA_SECCFGR.SECx, HPDMA_PRIVCFGR.PRIVx, and HPDMA_CxCIDCFGR until a global HPDMA reset
    $06 constant HPDMA_LOCK6                    \ [0x06] lock the configuration of HPDMA_SECCFGR.SECx, HPDMA_PRIVCFGR.PRIVx, and HPDMA_CxCIDCFGR until a global HPDMA reset
    $07 constant HPDMA_LOCK7                    \ [0x07] lock the configuration of HPDMA_SECCFGR.SECx, HPDMA_PRIVCFGR.PRIVx, and HPDMA_CxCIDCFGR until a global HPDMA reset
    $08 constant HPDMA_LOCK8                    \ [0x08] lock the configuration of HPDMA_SECCFGR.SECx, HPDMA_PRIVCFGR.PRIVx, and HPDMA_CxCIDCFGR until a global HPDMA reset
    $09 constant HPDMA_LOCK9                    \ [0x09] lock the configuration of HPDMA_SECCFGR.SECx, HPDMA_PRIVCFGR.PRIVx, and HPDMA_CxCIDCFGR until a global HPDMA reset
    $0a constant HPDMA_LOCK10                   \ [0x0a] lock the configuration of HPDMA_SECCFGR.SECx, HPDMA_PRIVCFGR.PRIVx, and HPDMA_CxCIDCFGR until a global HPDMA reset
    $0b constant HPDMA_LOCK11                   \ [0x0b] lock the configuration of HPDMA_SECCFGR.SECx, HPDMA_PRIVCFGR.PRIVx, and HPDMA_CxCIDCFGR until a global HPDMA reset
    $0c constant HPDMA_LOCK12                   \ [0x0c] lock the configuration of HPDMA_SECCFGR.SECx, HPDMA_PRIVCFGR.PRIVx, and HPDMA_CxCIDCFGR until a global HPDMA reset
    $0d constant HPDMA_LOCK13                   \ [0x0d] lock the configuration of HPDMA_SECCFGR.SECx, HPDMA_PRIVCFGR.PRIVx, and HPDMA_CxCIDCFGR until a global HPDMA reset
    $0e constant HPDMA_LOCK14                   \ [0x0e] lock the configuration of HPDMA_SECCFGR.SECx, HPDMA_PRIVCFGR.PRIVx, and HPDMA_CxCIDCFGR until a global HPDMA reset
    $0f constant HPDMA_LOCK15                   \ [0x0f] lock the configuration of HPDMA_SECCFGR.SECx, HPDMA_PRIVCFGR.PRIVx, and HPDMA_CxCIDCFGR until a global HPDMA reset
  [then]


  [ifdef] HPDMA_HPDMA_MISR_DEF
    \
    \ @brief HPDMA non-secure masked interrupt status register
    \ Address offset: 0x0C
    \ Reset value: 0x00000000
    \
    $00 constant HPDMA_MIS0                     \ [0x00] masked interrupt status of channel x
    $01 constant HPDMA_MIS1                     \ [0x01] masked interrupt status of channel x
    $02 constant HPDMA_MIS2                     \ [0x02] masked interrupt status of channel x
    $03 constant HPDMA_MIS3                     \ [0x03] masked interrupt status of channel x
    $04 constant HPDMA_MIS4                     \ [0x04] masked interrupt status of channel x
    $05 constant HPDMA_MIS5                     \ [0x05] masked interrupt status of channel x
    $06 constant HPDMA_MIS6                     \ [0x06] masked interrupt status of channel x
    $07 constant HPDMA_MIS7                     \ [0x07] masked interrupt status of channel x
    $08 constant HPDMA_MIS8                     \ [0x08] masked interrupt status of channel x
    $09 constant HPDMA_MIS9                     \ [0x09] masked interrupt status of channel x
    $0a constant HPDMA_MIS10                    \ [0x0a] masked interrupt status of channel x
    $0b constant HPDMA_MIS11                    \ [0x0b] masked interrupt status of channel x
    $0c constant HPDMA_MIS12                    \ [0x0c] masked interrupt status of channel x
    $0d constant HPDMA_MIS13                    \ [0x0d] masked interrupt status of channel x
    $0e constant HPDMA_MIS14                    \ [0x0e] masked interrupt status of channel x
    $0f constant HPDMA_MIS15                    \ [0x0f] masked interrupt status of channel x
  [then]


  [ifdef] HPDMA_HPDMA_SMISR_DEF
    \
    \ @brief HPDMA secure masked interrupt status register
    \ Address offset: 0x10
    \ Reset value: 0x00000000
    \
    $00 constant HPDMA_MIS0                     \ [0x00] masked interrupt status of the secure channel x
    $01 constant HPDMA_MIS1                     \ [0x01] masked interrupt status of the secure channel x
    $02 constant HPDMA_MIS2                     \ [0x02] masked interrupt status of the secure channel x
    $03 constant HPDMA_MIS3                     \ [0x03] masked interrupt status of the secure channel x
    $04 constant HPDMA_MIS4                     \ [0x04] masked interrupt status of the secure channel x
    $05 constant HPDMA_MIS5                     \ [0x05] masked interrupt status of the secure channel x
    $06 constant HPDMA_MIS6                     \ [0x06] masked interrupt status of the secure channel x
    $07 constant HPDMA_MIS7                     \ [0x07] masked interrupt status of the secure channel x
    $08 constant HPDMA_MIS8                     \ [0x08] masked interrupt status of the secure channel x
    $09 constant HPDMA_MIS9                     \ [0x09] masked interrupt status of the secure channel x
    $0a constant HPDMA_MIS10                    \ [0x0a] masked interrupt status of the secure channel x
    $0b constant HPDMA_MIS11                    \ [0x0b] masked interrupt status of the secure channel x
    $0c constant HPDMA_MIS12                    \ [0x0c] masked interrupt status of the secure channel x
    $0d constant HPDMA_MIS13                    \ [0x0d] masked interrupt status of the secure channel x
    $0e constant HPDMA_MIS14                    \ [0x0e] masked interrupt status of the secure channel x
    $0f constant HPDMA_MIS15                    \ [0x0f] masked interrupt status of the secure channel x
  [then]


  [ifdef] HPDMA_HPDMA_C0LBAR_DEF
    \
    \ @brief HPDMA channel 0 linked-list base address register
    \ Address offset: 0x50
    \ Reset value: 0x00000000
    \
    $10 constant HPDMA_LBA                      \ [0x10 : 16] linked-list base address of HPDMA channel x
  [then]


  [ifdef] HPDMA_HPDMA_C0CIDCFGR_DEF
    \
    \ @brief HPDMA channel 0 CID register
    \ Address offset: 0x54
    \ Reset value: 0x00000000
    \
    $00 constant HPDMA_CFEN                     \ [0x00] CID filtering enable of the channel x
    $01 constant HPDMA_SEM_EN                   \ [0x01] semaphore mode enable (for the CID allocation policy to the channel x)
    $04 constant HPDMA_SCID                     \ [0x04 : 3] allocate a static/single CID to the channel x (for when the channel x CID configuration is not in semaphore mode)
    $10 constant HPDMA_SEM_WLIST_CID0           \ [0x10] white-listed CID0 in the CID allocation pool (for when the channel x in semaphore mode)
    $11 constant HPDMA_SEM_WLIST_CID1           \ [0x11] white-listed CID1 in the CID allocation pool (for when the channel x in semaphore mode)
    $12 constant HPDMA_SEM_WLIST_CID2           \ [0x12] white-listed CID2 in the CID allocation pool (for when the channel x in semaphore mode)
    $13 constant HPDMA_SEM_WLIST_CID3           \ [0x13] white-listed CID3 in the CID allocation pool (for when the channel x in semaphore mode)
    $14 constant HPDMA_SEM_WLIST_CID4           \ [0x14] white-listed CID4 in the CID allocation pool (for when the channel x in semaphore mode)
    $15 constant HPDMA_SEM_WLIST_CID5           \ [0x15] white-listed CID5 in the CID allocation pool (for when the channel x in semaphore mode)
    $16 constant HPDMA_SEM_WLIST_CID6           \ [0x16] white-listed CID6 in the CID allocation pool (for when the channel x in semaphore mode)
  [then]


  [ifdef] HPDMA_HPDMA_C0SEMCR_DEF
    \
    \ @brief HPDMA channel 0 semaphore control register
    \ Address offset: 0x58
    \ Reset value: 0x00000000
    \
    $00 constant HPDMA_SEM_MUTEX                \ [0x00] mutual exclusion semaphore for the CID allocation of the channel x (in semaphore mode)
    $04 constant HPDMA_SEM_CCID                 \ [0x04 : 3] current CID allocated to the channel x (in semaphore mode)
  [then]


  [ifdef] HPDMA_HPDMA_C0FCR_DEF
    \
    \ @brief HPDMA channel 0 flag clear register
    \ Address offset: 0x5C
    \ Reset value: 0x00000000
    \
    $08 constant HPDMA_TCF                      \ [0x08] transfer complete flag clear
    $09 constant HPDMA_HTF                      \ [0x09] half transfer flag clear
    $0a constant HPDMA_DTEF                     \ [0x0a] data transfer error flag clear
    $0b constant HPDMA_ULEF                     \ [0x0b] update link transfer error flag clear
    $0c constant HPDMA_USEF                     \ [0x0c] user setting error flag clear
    $0d constant HPDMA_SUSPF                    \ [0x0d] completed suspension flag clear
    $0e constant HPDMA_TOF                      \ [0x0e] trigger overrun flag clear
  [then]


  [ifdef] HPDMA_HPDMA_C0SR_DEF
    \
    \ @brief HPDMA channel 0 status register
    \ Address offset: 0x60
    \ Reset value: 0x00000001
    \
    $00 constant HPDMA_IDLEF                    \ [0x00] idle flag
    $08 constant HPDMA_TCF                      \ [0x08] transfer complete flag
    $09 constant HPDMA_HTF                      \ [0x09] half transfer flag
    $0a constant HPDMA_DTEF                     \ [0x0a] data transfer error flag
    $0b constant HPDMA_ULEF                     \ [0x0b] update link transfer error flag
    $0c constant HPDMA_USEF                     \ [0x0c] user setting error flag
    $0d constant HPDMA_SUSPF                    \ [0x0d] completed suspension flag
    $0e constant HPDMA_TOF                      \ [0x0e] trigger overrun flag
    $10 constant HPDMA_FIFOL                    \ [0x10 : 9] monitored FIFO level
  [then]


  [ifdef] HPDMA_HPDMA_C0CR_DEF
    \
    \ @brief HPDMA channel 0 control register
    \ Address offset: 0x64
    \ Reset value: 0x00000000
    \
    $00 constant HPDMA_EN                       \ [0x00] enable
    $01 constant HPDMA_RESET                    \ [0x01] reset
    $02 constant HPDMA_SUSP                     \ [0x02] suspend
    $08 constant HPDMA_TCIE                     \ [0x08] transfer complete interrupt enable
    $09 constant HPDMA_HTIE                     \ [0x09] half transfer complete interrupt enable
    $0a constant HPDMA_DTEIE                    \ [0x0a] data transfer error interrupt enable
    $0b constant HPDMA_ULEIE                    \ [0x0b] update link transfer error interrupt enable
    $0c constant HPDMA_USEIE                    \ [0x0c] user setting error interrupt enable
    $0d constant HPDMA_SUSPIE                   \ [0x0d] completed suspension interrupt enable
    $0e constant HPDMA_TOIE                     \ [0x0e] trigger overrun interrupt enable
    $10 constant HPDMA_LSM                      \ [0x10] Link step mode
    $11 constant HPDMA_LAP                      \ [0x11] linked-list allocated port
    $16 constant HPDMA_PRIO                     \ [0x16 : 2] priority level of the channel x HPDMA transfer versus others
  [then]


  [ifdef] HPDMA_HPDMA_C0TR1_DEF
    \
    \ @brief HPDMA channel 0 transfer register 1
    \ Address offset: 0x90
    \ Reset value: 0x00000000
    \
    $00 constant HPDMA_SDW_LOG2                 \ [0x00 : 2] binary logarithm of the source data width of a burst in bytes
    $03 constant HPDMA_SINC                     \ [0x03] source incrementing burst
    $04 constant HPDMA_SBL_1                    \ [0x04 : 6] source burst length minus 1, between 0 and 63
    $0b constant HPDMA_PAM                      \ [0x0b : 2] padding/alignment mode
    $0d constant HPDMA_SBX                      \ [0x0d] source byte exchange within the unaligned half-word of each source word
    $0e constant HPDMA_SAP                      \ [0x0e] source allocated port
    $0f constant HPDMA_SSEC                     \ [0x0f] security attribute of the HPDMA transfer from the source
    $10 constant HPDMA_DDW_LOG2                 \ [0x10 : 2] binary logarithm of the destination data width of a burst, in bytes
    $13 constant HPDMA_DINC                     \ [0x13] destination incrementing burst
    $14 constant HPDMA_DBL_1                    \ [0x14 : 6] destination burst length minus 1, between 0 and 63
    $1a constant HPDMA_DBX                      \ [0x1a] destination byte exchange
    $1b constant HPDMA_DHX                      \ [0x1b] destination half-word exchange
    $1c constant HPDMA_DWX                      \ [0x1c] destination word exchange
    $1e constant HPDMA_DAP                      \ [0x1e] destination allocated port
    $1f constant HPDMA_DSEC                     \ [0x1f] security attribute of the HPDMA transfer to the destination
  [then]


  [ifdef] HPDMA_HPDMA_C0TR2_DEF
    \
    \ @brief HPDMA channel 0 transfer register 2
    \ Address offset: 0x94
    \ Reset value: 0x00000000
    \
    $00 constant HPDMA_REQSEL                   \ [0x00 : 8] hardware request selection
    $09 constant HPDMA_SWREQ                    \ [0x09] software request
    $0a constant HPDMA_DREQ                     \ [0x0a] destination hardware request
    $0b constant HPDMA_BREQ                     \ [0x0b] Block hardware request
    $0c constant HPDMA_PFREQ                    \ [0x0c] Hardware request in peripheral flow control mode
    $0e constant HPDMA_TRIGM                    \ [0x0e : 2] trigger mode
    $10 constant HPDMA_TRIGSEL                  \ [0x10 : 7] trigger event input selection
    $18 constant HPDMA_TRIGPOL                  \ [0x18 : 2] trigger event polarity
    $1e constant HPDMA_TCEM                     \ [0x1e : 2] transfer complete event mode
  [then]


  [ifdef] HPDMA_HPDMA_C0BR1_DEF
    \
    \ @brief HPDMA channel 0 block register 1
    \ Address offset: 0x98
    \ Reset value: 0x00000000
    \
    $00 constant HPDMA_BNDT                     \ [0x00 : 16] block number of data bytes to transfer from the source
  [then]


  [ifdef] HPDMA_HPDMA_C0SAR_DEF
    \
    \ @brief HPDMA channel 0 source address register
    \ Address offset: 0x9C
    \ Reset value: 0x00000000
    \
    $00 constant HPDMA_SA                       \ [0x00 : 32] source address
  [then]


  [ifdef] HPDMA_HPDMA_C0DAR_DEF
    \
    \ @brief HPDMA channel 0 destination address register
    \ Address offset: 0xA0
    \ Reset value: 0x00000000
    \
    $00 constant HPDMA_DA                       \ [0x00 : 32] destination address
  [then]


  [ifdef] HPDMA_HPDMA_C0LLR_DEF
    \
    \ @brief HPDMA channel 0 linked-list address register
    \ Address offset: 0xCC
    \ Reset value: 0x00000000
    \
    $02 constant HPDMA_LA                       \ [0x02 : 14] pointer (16-bit low-significant address) to the next linked-list data structure
    $10 constant HPDMA_ULL                      \ [0x10] Update HPDMA_CxLLR register from memory
    $1b constant HPDMA_UDA                      \ [0x1b] Update HPDMA_CxDAR register from memory
    $1c constant HPDMA_USA                      \ [0x1c] update HPDMA_CxSAR from memory
    $1d constant HPDMA_UB1                      \ [0x1d] Update HPDMA_CxBR1 from memory
    $1e constant HPDMA_UT2                      \ [0x1e] Update HPDMA_CxTR2 from memory
    $1f constant HPDMA_UT1                      \ [0x1f] Update HPDMA_CxTR1 from memory
  [then]


  [ifdef] HPDMA_HPDMA_C1LBAR_DEF
    \
    \ @brief HPDMA channel 1 linked-list base address register
    \ Address offset: 0xD0
    \ Reset value: 0x00000000
    \
    $10 constant HPDMA_LBA                      \ [0x10 : 16] linked-list base address of HPDMA channel x
  [then]


  [ifdef] HPDMA_HPDMA_C1CIDCFGR_DEF
    \
    \ @brief HPDMA channel 1 CID register
    \ Address offset: 0xD4
    \ Reset value: 0x00000000
    \
    $00 constant HPDMA_CFEN                     \ [0x00] CID filtering enable of the channel x
    $01 constant HPDMA_SEM_EN                   \ [0x01] semaphore mode enable (for the CID allocation policy to the channel x)
    $04 constant HPDMA_SCID                     \ [0x04 : 3] allocate a static/single CID to the channel x (for when the channel x CID configuration is not in semaphore mode)
    $10 constant HPDMA_SEM_WLIST_CID0           \ [0x10] white-listed CID0 in the CID allocation pool (for when the channel x in semaphore mode)
    $11 constant HPDMA_SEM_WLIST_CID1           \ [0x11] white-listed CID1 in the CID allocation pool (for when the channel x in semaphore mode)
    $12 constant HPDMA_SEM_WLIST_CID2           \ [0x12] white-listed CID2 in the CID allocation pool (for when the channel x in semaphore mode)
    $13 constant HPDMA_SEM_WLIST_CID3           \ [0x13] white-listed CID3 in the CID allocation pool (for when the channel x in semaphore mode)
    $14 constant HPDMA_SEM_WLIST_CID4           \ [0x14] white-listed CID4 in the CID allocation pool (for when the channel x in semaphore mode)
    $15 constant HPDMA_SEM_WLIST_CID5           \ [0x15] white-listed CID5 in the CID allocation pool (for when the channel x in semaphore mode)
    $16 constant HPDMA_SEM_WLIST_CID6           \ [0x16] white-listed CID6 in the CID allocation pool (for when the channel x in semaphore mode)
  [then]


  [ifdef] HPDMA_HPDMA_C1SEMCR_DEF
    \
    \ @brief HPDMA channel 1 semaphore control register
    \ Address offset: 0xD8
    \ Reset value: 0x00000000
    \
    $00 constant HPDMA_SEM_MUTEX                \ [0x00] mutual exclusion semaphore for the CID allocation of the channel x (in semaphore mode)
    $04 constant HPDMA_SEM_CCID                 \ [0x04 : 3] current CID allocated to the channel x (in semaphore mode)
  [then]


  [ifdef] HPDMA_HPDMA_C1FCR_DEF
    \
    \ @brief HPDMA channel 1 flag clear register
    \ Address offset: 0xDC
    \ Reset value: 0x00000000
    \
    $08 constant HPDMA_TCF                      \ [0x08] transfer complete flag clear
    $09 constant HPDMA_HTF                      \ [0x09] half transfer flag clear
    $0a constant HPDMA_DTEF                     \ [0x0a] data transfer error flag clear
    $0b constant HPDMA_ULEF                     \ [0x0b] update link transfer error flag clear
    $0c constant HPDMA_USEF                     \ [0x0c] user setting error flag clear
    $0d constant HPDMA_SUSPF                    \ [0x0d] completed suspension flag clear
    $0e constant HPDMA_TOF                      \ [0x0e] trigger overrun flag clear
  [then]


  [ifdef] HPDMA_HPDMA_C1SR_DEF
    \
    \ @brief HPDMA channel 1 status register
    \ Address offset: 0xE0
    \ Reset value: 0x00000001
    \
    $00 constant HPDMA_IDLEF                    \ [0x00] idle flag
    $08 constant HPDMA_TCF                      \ [0x08] transfer complete flag
    $09 constant HPDMA_HTF                      \ [0x09] half transfer flag
    $0a constant HPDMA_DTEF                     \ [0x0a] data transfer error flag
    $0b constant HPDMA_ULEF                     \ [0x0b] update link transfer error flag
    $0c constant HPDMA_USEF                     \ [0x0c] user setting error flag
    $0d constant HPDMA_SUSPF                    \ [0x0d] completed suspension flag
    $0e constant HPDMA_TOF                      \ [0x0e] trigger overrun flag
    $10 constant HPDMA_FIFOL                    \ [0x10 : 9] monitored FIFO level
  [then]


  [ifdef] HPDMA_HPDMA_C1CR_DEF
    \
    \ @brief HPDMA channel 1 control register
    \ Address offset: 0xE4
    \ Reset value: 0x00000000
    \
    $00 constant HPDMA_EN                       \ [0x00] enable
    $01 constant HPDMA_RESET                    \ [0x01] reset
    $02 constant HPDMA_SUSP                     \ [0x02] suspend
    $08 constant HPDMA_TCIE                     \ [0x08] transfer complete interrupt enable
    $09 constant HPDMA_HTIE                     \ [0x09] half transfer complete interrupt enable
    $0a constant HPDMA_DTEIE                    \ [0x0a] data transfer error interrupt enable
    $0b constant HPDMA_ULEIE                    \ [0x0b] update link transfer error interrupt enable
    $0c constant HPDMA_USEIE                    \ [0x0c] user setting error interrupt enable
    $0d constant HPDMA_SUSPIE                   \ [0x0d] completed suspension interrupt enable
    $0e constant HPDMA_TOIE                     \ [0x0e] trigger overrun interrupt enable
    $10 constant HPDMA_LSM                      \ [0x10] Link step mode
    $11 constant HPDMA_LAP                      \ [0x11] linked-list allocated port
    $16 constant HPDMA_PRIO                     \ [0x16 : 2] priority level of the channel x HPDMA transfer versus others
  [then]


  [ifdef] HPDMA_HPDMA_C1TR1_DEF
    \
    \ @brief HPDMA channel 1 transfer register 1
    \ Address offset: 0x110
    \ Reset value: 0x00000000
    \
    $00 constant HPDMA_SDW_LOG2                 \ [0x00 : 2] binary logarithm of the source data width of a burst in bytes
    $03 constant HPDMA_SINC                     \ [0x03] source incrementing burst
    $04 constant HPDMA_SBL_1                    \ [0x04 : 6] source burst length minus 1, between 0 and 63
    $0b constant HPDMA_PAM                      \ [0x0b : 2] padding/alignment mode
    $0d constant HPDMA_SBX                      \ [0x0d] source byte exchange within the unaligned half-word of each source word
    $0e constant HPDMA_SAP                      \ [0x0e] source allocated port
    $0f constant HPDMA_SSEC                     \ [0x0f] security attribute of the HPDMA transfer from the source
    $10 constant HPDMA_DDW_LOG2                 \ [0x10 : 2] binary logarithm of the destination data width of a burst, in bytes
    $13 constant HPDMA_DINC                     \ [0x13] destination incrementing burst
    $14 constant HPDMA_DBL_1                    \ [0x14 : 6] destination burst length minus 1, between 0 and 63
    $1a constant HPDMA_DBX                      \ [0x1a] destination byte exchange
    $1b constant HPDMA_DHX                      \ [0x1b] destination half-word exchange
    $1c constant HPDMA_DWX                      \ [0x1c] destination word exchange
    $1e constant HPDMA_DAP                      \ [0x1e] destination allocated port
    $1f constant HPDMA_DSEC                     \ [0x1f] security attribute of the HPDMA transfer to the destination
  [then]


  [ifdef] HPDMA_HPDMA_C1TR2_DEF
    \
    \ @brief HPDMA channel 1 transfer register 2
    \ Address offset: 0x114
    \ Reset value: 0x00000000
    \
    $00 constant HPDMA_REQSEL                   \ [0x00 : 8] hardware request selection
    $09 constant HPDMA_SWREQ                    \ [0x09] software request
    $0a constant HPDMA_DREQ                     \ [0x0a] destination hardware request
    $0b constant HPDMA_BREQ                     \ [0x0b] Block hardware request
    $0c constant HPDMA_PFREQ                    \ [0x0c] Hardware request in peripheral flow control mode
    $0e constant HPDMA_TRIGM                    \ [0x0e : 2] trigger mode
    $10 constant HPDMA_TRIGSEL                  \ [0x10 : 7] trigger event input selection
    $18 constant HPDMA_TRIGPOL                  \ [0x18 : 2] trigger event polarity
    $1e constant HPDMA_TCEM                     \ [0x1e : 2] transfer complete event mode
  [then]


  [ifdef] HPDMA_HPDMA_C1BR1_DEF
    \
    \ @brief HPDMA channel 1 block register 1
    \ Address offset: 0x118
    \ Reset value: 0x00000000
    \
    $00 constant HPDMA_BNDT                     \ [0x00 : 16] block number of data bytes to transfer from the source
  [then]


  [ifdef] HPDMA_HPDMA_C1SAR_DEF
    \
    \ @brief HPDMA channel 1 source address register
    \ Address offset: 0x11C
    \ Reset value: 0x00000000
    \
    $00 constant HPDMA_SA                       \ [0x00 : 32] source address
  [then]


  [ifdef] HPDMA_HPDMA_C1DAR_DEF
    \
    \ @brief HPDMA channel 1 destination address register
    \ Address offset: 0x120
    \ Reset value: 0x00000000
    \
    $00 constant HPDMA_DA                       \ [0x00 : 32] destination address
  [then]


  [ifdef] HPDMA_HPDMA_C1LLR_DEF
    \
    \ @brief HPDMA channel 1 linked-list address register
    \ Address offset: 0x14C
    \ Reset value: 0x00000000
    \
    $02 constant HPDMA_LA                       \ [0x02 : 14] pointer (16-bit low-significant address) to the next linked-list data structure
    $10 constant HPDMA_ULL                      \ [0x10] Update HPDMA_CxLLR register from memory
    $1b constant HPDMA_UDA                      \ [0x1b] Update HPDMA_CxDAR register from memory
    $1c constant HPDMA_USA                      \ [0x1c] update HPDMA_CxSAR from memory
    $1d constant HPDMA_UB1                      \ [0x1d] Update HPDMA_CxBR1 from memory
    $1e constant HPDMA_UT2                      \ [0x1e] Update HPDMA_CxTR2 from memory
    $1f constant HPDMA_UT1                      \ [0x1f] Update HPDMA_CxTR1 from memory
  [then]


  [ifdef] HPDMA_HPDMA_C2LBAR_DEF
    \
    \ @brief HPDMA channel 2 linked-list base address register
    \ Address offset: 0x150
    \ Reset value: 0x00000000
    \
    $10 constant HPDMA_LBA                      \ [0x10 : 16] linked-list base address of HPDMA channel x
  [then]


  [ifdef] HPDMA_HPDMA_C2CIDCFGR_DEF
    \
    \ @brief HPDMA channel 2 CID register
    \ Address offset: 0x154
    \ Reset value: 0x00000000
    \
    $00 constant HPDMA_CFEN                     \ [0x00] CID filtering enable of the channel x
    $01 constant HPDMA_SEM_EN                   \ [0x01] semaphore mode enable (for the CID allocation policy to the channel x)
    $04 constant HPDMA_SCID                     \ [0x04 : 3] allocate a static/single CID to the channel x (for when the channel x CID configuration is not in semaphore mode)
    $10 constant HPDMA_SEM_WLIST_CID0           \ [0x10] white-listed CID0 in the CID allocation pool (for when the channel x in semaphore mode)
    $11 constant HPDMA_SEM_WLIST_CID1           \ [0x11] white-listed CID1 in the CID allocation pool (for when the channel x in semaphore mode)
    $12 constant HPDMA_SEM_WLIST_CID2           \ [0x12] white-listed CID2 in the CID allocation pool (for when the channel x in semaphore mode)
    $13 constant HPDMA_SEM_WLIST_CID3           \ [0x13] white-listed CID3 in the CID allocation pool (for when the channel x in semaphore mode)
    $14 constant HPDMA_SEM_WLIST_CID4           \ [0x14] white-listed CID4 in the CID allocation pool (for when the channel x in semaphore mode)
    $15 constant HPDMA_SEM_WLIST_CID5           \ [0x15] white-listed CID5 in the CID allocation pool (for when the channel x in semaphore mode)
    $16 constant HPDMA_SEM_WLIST_CID6           \ [0x16] white-listed CID6 in the CID allocation pool (for when the channel x in semaphore mode)
  [then]


  [ifdef] HPDMA_HPDMA_C2SEMCR_DEF
    \
    \ @brief HPDMA channel 2 semaphore control register
    \ Address offset: 0x158
    \ Reset value: 0x00000000
    \
    $00 constant HPDMA_SEM_MUTEX                \ [0x00] mutual exclusion semaphore for the CID allocation of the channel x (in semaphore mode)
    $04 constant HPDMA_SEM_CCID                 \ [0x04 : 3] current CID allocated to the channel x (in semaphore mode)
  [then]


  [ifdef] HPDMA_HPDMA_C2FCR_DEF
    \
    \ @brief HPDMA channel 2 flag clear register
    \ Address offset: 0x15C
    \ Reset value: 0x00000000
    \
    $08 constant HPDMA_TCF                      \ [0x08] transfer complete flag clear
    $09 constant HPDMA_HTF                      \ [0x09] half transfer flag clear
    $0a constant HPDMA_DTEF                     \ [0x0a] data transfer error flag clear
    $0b constant HPDMA_ULEF                     \ [0x0b] update link transfer error flag clear
    $0c constant HPDMA_USEF                     \ [0x0c] user setting error flag clear
    $0d constant HPDMA_SUSPF                    \ [0x0d] completed suspension flag clear
    $0e constant HPDMA_TOF                      \ [0x0e] trigger overrun flag clear
  [then]


  [ifdef] HPDMA_HPDMA_C2SR_DEF
    \
    \ @brief HPDMA channel 2 status register
    \ Address offset: 0x160
    \ Reset value: 0x00000001
    \
    $00 constant HPDMA_IDLEF                    \ [0x00] idle flag
    $08 constant HPDMA_TCF                      \ [0x08] transfer complete flag
    $09 constant HPDMA_HTF                      \ [0x09] half transfer flag
    $0a constant HPDMA_DTEF                     \ [0x0a] data transfer error flag
    $0b constant HPDMA_ULEF                     \ [0x0b] update link transfer error flag
    $0c constant HPDMA_USEF                     \ [0x0c] user setting error flag
    $0d constant HPDMA_SUSPF                    \ [0x0d] completed suspension flag
    $0e constant HPDMA_TOF                      \ [0x0e] trigger overrun flag
    $10 constant HPDMA_FIFOL                    \ [0x10 : 9] monitored FIFO level
  [then]


  [ifdef] HPDMA_HPDMA_C2CR_DEF
    \
    \ @brief HPDMA channel 2 control register
    \ Address offset: 0x164
    \ Reset value: 0x00000000
    \
    $00 constant HPDMA_EN                       \ [0x00] enable
    $01 constant HPDMA_RESET                    \ [0x01] reset
    $02 constant HPDMA_SUSP                     \ [0x02] suspend
    $08 constant HPDMA_TCIE                     \ [0x08] transfer complete interrupt enable
    $09 constant HPDMA_HTIE                     \ [0x09] half transfer complete interrupt enable
    $0a constant HPDMA_DTEIE                    \ [0x0a] data transfer error interrupt enable
    $0b constant HPDMA_ULEIE                    \ [0x0b] update link transfer error interrupt enable
    $0c constant HPDMA_USEIE                    \ [0x0c] user setting error interrupt enable
    $0d constant HPDMA_SUSPIE                   \ [0x0d] completed suspension interrupt enable
    $0e constant HPDMA_TOIE                     \ [0x0e] trigger overrun interrupt enable
    $10 constant HPDMA_LSM                      \ [0x10] Link step mode
    $11 constant HPDMA_LAP                      \ [0x11] linked-list allocated port
    $16 constant HPDMA_PRIO                     \ [0x16 : 2] priority level of the channel x HPDMA transfer versus others
  [then]


  [ifdef] HPDMA_HPDMA_C2TR1_DEF
    \
    \ @brief HPDMA channel 2 transfer register 1
    \ Address offset: 0x190
    \ Reset value: 0x00000000
    \
    $00 constant HPDMA_SDW_LOG2                 \ [0x00 : 2] binary logarithm of the source data width of a burst in bytes
    $03 constant HPDMA_SINC                     \ [0x03] source incrementing burst
    $04 constant HPDMA_SBL_1                    \ [0x04 : 6] source burst length minus 1, between 0 and 63
    $0b constant HPDMA_PAM                      \ [0x0b : 2] padding/alignment mode
    $0d constant HPDMA_SBX                      \ [0x0d] source byte exchange within the unaligned half-word of each source word
    $0e constant HPDMA_SAP                      \ [0x0e] source allocated port
    $0f constant HPDMA_SSEC                     \ [0x0f] security attribute of the HPDMA transfer from the source
    $10 constant HPDMA_DDW_LOG2                 \ [0x10 : 2] binary logarithm of the destination data width of a burst, in bytes
    $13 constant HPDMA_DINC                     \ [0x13] destination incrementing burst
    $14 constant HPDMA_DBL_1                    \ [0x14 : 6] destination burst length minus 1, between 0 and 63
    $1a constant HPDMA_DBX                      \ [0x1a] destination byte exchange
    $1b constant HPDMA_DHX                      \ [0x1b] destination half-word exchange
    $1c constant HPDMA_DWX                      \ [0x1c] destination word exchange
    $1e constant HPDMA_DAP                      \ [0x1e] destination allocated port
    $1f constant HPDMA_DSEC                     \ [0x1f] security attribute of the HPDMA transfer to the destination
  [then]


  [ifdef] HPDMA_HPDMA_C2TR2_DEF
    \
    \ @brief HPDMA channel 2 transfer register 2
    \ Address offset: 0x194
    \ Reset value: 0x00000000
    \
    $00 constant HPDMA_REQSEL                   \ [0x00 : 8] hardware request selection
    $09 constant HPDMA_SWREQ                    \ [0x09] software request
    $0a constant HPDMA_DREQ                     \ [0x0a] destination hardware request
    $0b constant HPDMA_BREQ                     \ [0x0b] Block hardware request
    $0c constant HPDMA_PFREQ                    \ [0x0c] Hardware request in peripheral flow control mode
    $0e constant HPDMA_TRIGM                    \ [0x0e : 2] trigger mode
    $10 constant HPDMA_TRIGSEL                  \ [0x10 : 7] trigger event input selection
    $18 constant HPDMA_TRIGPOL                  \ [0x18 : 2] trigger event polarity
    $1e constant HPDMA_TCEM                     \ [0x1e : 2] transfer complete event mode
  [then]


  [ifdef] HPDMA_HPDMA_C2BR1_DEF
    \
    \ @brief HPDMA channel 2 block register 1
    \ Address offset: 0x198
    \ Reset value: 0x00000000
    \
    $00 constant HPDMA_BNDT                     \ [0x00 : 16] block number of data bytes to transfer from the source
  [then]


  [ifdef] HPDMA_HPDMA_C2SAR_DEF
    \
    \ @brief HPDMA channel 2 source address register
    \ Address offset: 0x19C
    \ Reset value: 0x00000000
    \
    $00 constant HPDMA_SA                       \ [0x00 : 32] source address
  [then]


  [ifdef] HPDMA_HPDMA_C2DAR_DEF
    \
    \ @brief HPDMA channel 2 destination address register
    \ Address offset: 0x1A0
    \ Reset value: 0x00000000
    \
    $00 constant HPDMA_DA                       \ [0x00 : 32] destination address
  [then]


  [ifdef] HPDMA_HPDMA_C2LLR_DEF
    \
    \ @brief HPDMA channel 2 linked-list address register
    \ Address offset: 0x1CC
    \ Reset value: 0x00000000
    \
    $02 constant HPDMA_LA                       \ [0x02 : 14] pointer (16-bit low-significant address) to the next linked-list data structure
    $10 constant HPDMA_ULL                      \ [0x10] Update HPDMA_CxLLR register from memory
    $1b constant HPDMA_UDA                      \ [0x1b] Update HPDMA_CxDAR register from memory
    $1c constant HPDMA_USA                      \ [0x1c] update HPDMA_CxSAR from memory
    $1d constant HPDMA_UB1                      \ [0x1d] Update HPDMA_CxBR1 from memory
    $1e constant HPDMA_UT2                      \ [0x1e] Update HPDMA_CxTR2 from memory
    $1f constant HPDMA_UT1                      \ [0x1f] Update HPDMA_CxTR1 from memory
  [then]


  [ifdef] HPDMA_HPDMA_C3LBAR_DEF
    \
    \ @brief HPDMA channel 3 linked-list base address register
    \ Address offset: 0x1D0
    \ Reset value: 0x00000000
    \
    $10 constant HPDMA_LBA                      \ [0x10 : 16] linked-list base address of HPDMA channel x
  [then]


  [ifdef] HPDMA_HPDMA_C3CIDCFGR_DEF
    \
    \ @brief HPDMA channel 3 CID register
    \ Address offset: 0x1D4
    \ Reset value: 0x00000000
    \
    $00 constant HPDMA_CFEN                     \ [0x00] CID filtering enable of the channel x
    $01 constant HPDMA_SEM_EN                   \ [0x01] semaphore mode enable (for the CID allocation policy to the channel x)
    $04 constant HPDMA_SCID                     \ [0x04 : 3] allocate a static/single CID to the channel x (for when the channel x CID configuration is not in semaphore mode)
    $10 constant HPDMA_SEM_WLIST_CID0           \ [0x10] white-listed CID0 in the CID allocation pool (for when the channel x in semaphore mode)
    $11 constant HPDMA_SEM_WLIST_CID1           \ [0x11] white-listed CID1 in the CID allocation pool (for when the channel x in semaphore mode)
    $12 constant HPDMA_SEM_WLIST_CID2           \ [0x12] white-listed CID2 in the CID allocation pool (for when the channel x in semaphore mode)
    $13 constant HPDMA_SEM_WLIST_CID3           \ [0x13] white-listed CID3 in the CID allocation pool (for when the channel x in semaphore mode)
    $14 constant HPDMA_SEM_WLIST_CID4           \ [0x14] white-listed CID4 in the CID allocation pool (for when the channel x in semaphore mode)
    $15 constant HPDMA_SEM_WLIST_CID5           \ [0x15] white-listed CID5 in the CID allocation pool (for when the channel x in semaphore mode)
    $16 constant HPDMA_SEM_WLIST_CID6           \ [0x16] white-listed CID6 in the CID allocation pool (for when the channel x in semaphore mode)
  [then]


  [ifdef] HPDMA_HPDMA_C3SEMCR_DEF
    \
    \ @brief HPDMA channel 3 semaphore control register
    \ Address offset: 0x1D8
    \ Reset value: 0x00000000
    \
    $00 constant HPDMA_SEM_MUTEX                \ [0x00] mutual exclusion semaphore for the CID allocation of the channel x (in semaphore mode)
    $04 constant HPDMA_SEM_CCID                 \ [0x04 : 3] current CID allocated to the channel x (in semaphore mode)
  [then]


  [ifdef] HPDMA_HPDMA_C3FCR_DEF
    \
    \ @brief HPDMA channel 3 flag clear register
    \ Address offset: 0x1DC
    \ Reset value: 0x00000000
    \
    $08 constant HPDMA_TCF                      \ [0x08] transfer complete flag clear
    $09 constant HPDMA_HTF                      \ [0x09] half transfer flag clear
    $0a constant HPDMA_DTEF                     \ [0x0a] data transfer error flag clear
    $0b constant HPDMA_ULEF                     \ [0x0b] update link transfer error flag clear
    $0c constant HPDMA_USEF                     \ [0x0c] user setting error flag clear
    $0d constant HPDMA_SUSPF                    \ [0x0d] completed suspension flag clear
    $0e constant HPDMA_TOF                      \ [0x0e] trigger overrun flag clear
  [then]


  [ifdef] HPDMA_HPDMA_C3SR_DEF
    \
    \ @brief HPDMA channel 3 status register
    \ Address offset: 0x1E0
    \ Reset value: 0x00000001
    \
    $00 constant HPDMA_IDLEF                    \ [0x00] idle flag
    $08 constant HPDMA_TCF                      \ [0x08] transfer complete flag
    $09 constant HPDMA_HTF                      \ [0x09] half transfer flag
    $0a constant HPDMA_DTEF                     \ [0x0a] data transfer error flag
    $0b constant HPDMA_ULEF                     \ [0x0b] update link transfer error flag
    $0c constant HPDMA_USEF                     \ [0x0c] user setting error flag
    $0d constant HPDMA_SUSPF                    \ [0x0d] completed suspension flag
    $0e constant HPDMA_TOF                      \ [0x0e] trigger overrun flag
    $10 constant HPDMA_FIFOL                    \ [0x10 : 9] monitored FIFO level
  [then]


  [ifdef] HPDMA_HPDMA_C3CR_DEF
    \
    \ @brief HPDMA channel 3 control register
    \ Address offset: 0x1E4
    \ Reset value: 0x00000000
    \
    $00 constant HPDMA_EN                       \ [0x00] enable
    $01 constant HPDMA_RESET                    \ [0x01] reset
    $02 constant HPDMA_SUSP                     \ [0x02] suspend
    $08 constant HPDMA_TCIE                     \ [0x08] transfer complete interrupt enable
    $09 constant HPDMA_HTIE                     \ [0x09] half transfer complete interrupt enable
    $0a constant HPDMA_DTEIE                    \ [0x0a] data transfer error interrupt enable
    $0b constant HPDMA_ULEIE                    \ [0x0b] update link transfer error interrupt enable
    $0c constant HPDMA_USEIE                    \ [0x0c] user setting error interrupt enable
    $0d constant HPDMA_SUSPIE                   \ [0x0d] completed suspension interrupt enable
    $0e constant HPDMA_TOIE                     \ [0x0e] trigger overrun interrupt enable
    $10 constant HPDMA_LSM                      \ [0x10] Link step mode
    $11 constant HPDMA_LAP                      \ [0x11] linked-list allocated port
    $16 constant HPDMA_PRIO                     \ [0x16 : 2] priority level of the channel x HPDMA transfer versus others
  [then]


  [ifdef] HPDMA_HPDMA_C3TR1_DEF
    \
    \ @brief HPDMA channel 3 transfer register 1
    \ Address offset: 0x210
    \ Reset value: 0x00000000
    \
    $00 constant HPDMA_SDW_LOG2                 \ [0x00 : 2] binary logarithm of the source data width of a burst in bytes
    $03 constant HPDMA_SINC                     \ [0x03] source incrementing burst
    $04 constant HPDMA_SBL_1                    \ [0x04 : 6] source burst length minus 1, between 0 and 63
    $0b constant HPDMA_PAM                      \ [0x0b : 2] padding/alignment mode
    $0d constant HPDMA_SBX                      \ [0x0d] source byte exchange within the unaligned half-word of each source word
    $0e constant HPDMA_SAP                      \ [0x0e] source allocated port
    $0f constant HPDMA_SSEC                     \ [0x0f] security attribute of the HPDMA transfer from the source
    $10 constant HPDMA_DDW_LOG2                 \ [0x10 : 2] binary logarithm of the destination data width of a burst, in bytes
    $13 constant HPDMA_DINC                     \ [0x13] destination incrementing burst
    $14 constant HPDMA_DBL_1                    \ [0x14 : 6] destination burst length minus 1, between 0 and 63
    $1a constant HPDMA_DBX                      \ [0x1a] destination byte exchange
    $1b constant HPDMA_DHX                      \ [0x1b] destination half-word exchange
    $1c constant HPDMA_DWX                      \ [0x1c] destination word exchange
    $1e constant HPDMA_DAP                      \ [0x1e] destination allocated port
    $1f constant HPDMA_DSEC                     \ [0x1f] security attribute of the HPDMA transfer to the destination
  [then]


  [ifdef] HPDMA_HPDMA_C3TR2_DEF
    \
    \ @brief HPDMA channel 3 transfer register 2
    \ Address offset: 0x214
    \ Reset value: 0x00000000
    \
    $00 constant HPDMA_REQSEL                   \ [0x00 : 8] hardware request selection
    $09 constant HPDMA_SWREQ                    \ [0x09] software request
    $0a constant HPDMA_DREQ                     \ [0x0a] destination hardware request
    $0b constant HPDMA_BREQ                     \ [0x0b] Block hardware request
    $0c constant HPDMA_PFREQ                    \ [0x0c] Hardware request in peripheral flow control mode
    $0e constant HPDMA_TRIGM                    \ [0x0e : 2] trigger mode
    $10 constant HPDMA_TRIGSEL                  \ [0x10 : 7] trigger event input selection
    $18 constant HPDMA_TRIGPOL                  \ [0x18 : 2] trigger event polarity
    $1e constant HPDMA_TCEM                     \ [0x1e : 2] transfer complete event mode
  [then]


  [ifdef] HPDMA_HPDMA_C3BR1_DEF
    \
    \ @brief HPDMA channel 3 block register 1
    \ Address offset: 0x218
    \ Reset value: 0x00000000
    \
    $00 constant HPDMA_BNDT                     \ [0x00 : 16] block number of data bytes to transfer from the source
  [then]


  [ifdef] HPDMA_HPDMA_C3SAR_DEF
    \
    \ @brief HPDMA channel 3 source address register
    \ Address offset: 0x21C
    \ Reset value: 0x00000000
    \
    $00 constant HPDMA_SA                       \ [0x00 : 32] source address
  [then]


  [ifdef] HPDMA_HPDMA_C3DAR_DEF
    \
    \ @brief HPDMA channel 3 destination address register
    \ Address offset: 0x220
    \ Reset value: 0x00000000
    \
    $00 constant HPDMA_DA                       \ [0x00 : 32] destination address
  [then]


  [ifdef] HPDMA_HPDMA_C3LLR_DEF
    \
    \ @brief HPDMA channel 3 linked-list address register
    \ Address offset: 0x24C
    \ Reset value: 0x00000000
    \
    $02 constant HPDMA_LA                       \ [0x02 : 14] pointer (16-bit low-significant address) to the next linked-list data structure
    $10 constant HPDMA_ULL                      \ [0x10] Update HPDMA_CxLLR register from memory
    $1b constant HPDMA_UDA                      \ [0x1b] Update HPDMA_CxDAR register from memory
    $1c constant HPDMA_USA                      \ [0x1c] update HPDMA_CxSAR from memory
    $1d constant HPDMA_UB1                      \ [0x1d] Update HPDMA_CxBR1 from memory
    $1e constant HPDMA_UT2                      \ [0x1e] Update HPDMA_CxTR2 from memory
    $1f constant HPDMA_UT1                      \ [0x1f] Update HPDMA_CxTR1 from memory
  [then]


  [ifdef] HPDMA_HPDMA_C4LBAR_DEF
    \
    \ @brief HPDMA channel 4 linked-list base address register
    \ Address offset: 0x250
    \ Reset value: 0x00000000
    \
    $10 constant HPDMA_LBA                      \ [0x10 : 16] linked-list base address of HPDMA channel x
  [then]


  [ifdef] HPDMA_HPDMA_C4CIDCFGR_DEF
    \
    \ @brief HPDMA channel 4 CID register
    \ Address offset: 0x254
    \ Reset value: 0x00000000
    \
    $00 constant HPDMA_CFEN                     \ [0x00] CID filtering enable of the channel x
    $01 constant HPDMA_SEM_EN                   \ [0x01] semaphore mode enable (for the CID allocation policy to the channel x)
    $04 constant HPDMA_SCID                     \ [0x04 : 3] allocate a static/single CID to the channel x (for when the channel x CID configuration is not in semaphore mode)
    $10 constant HPDMA_SEM_WLIST_CID0           \ [0x10] white-listed CID0 in the CID allocation pool (for when the channel x in semaphore mode)
    $11 constant HPDMA_SEM_WLIST_CID1           \ [0x11] white-listed CID1 in the CID allocation pool (for when the channel x in semaphore mode)
    $12 constant HPDMA_SEM_WLIST_CID2           \ [0x12] white-listed CID2 in the CID allocation pool (for when the channel x in semaphore mode)
    $13 constant HPDMA_SEM_WLIST_CID3           \ [0x13] white-listed CID3 in the CID allocation pool (for when the channel x in semaphore mode)
    $14 constant HPDMA_SEM_WLIST_CID4           \ [0x14] white-listed CID4 in the CID allocation pool (for when the channel x in semaphore mode)
    $15 constant HPDMA_SEM_WLIST_CID5           \ [0x15] white-listed CID5 in the CID allocation pool (for when the channel x in semaphore mode)
    $16 constant HPDMA_SEM_WLIST_CID6           \ [0x16] white-listed CID6 in the CID allocation pool (for when the channel x in semaphore mode)
  [then]


  [ifdef] HPDMA_HPDMA_C4SEMCR_DEF
    \
    \ @brief HPDMA channel 4 semaphore control register
    \ Address offset: 0x258
    \ Reset value: 0x00000000
    \
    $00 constant HPDMA_SEM_MUTEX                \ [0x00] mutual exclusion semaphore for the CID allocation of the channel x (in semaphore mode)
    $04 constant HPDMA_SEM_CCID                 \ [0x04 : 3] current CID allocated to the channel x (in semaphore mode)
  [then]


  [ifdef] HPDMA_HPDMA_C4FCR_DEF
    \
    \ @brief HPDMA channel 4 flag clear register
    \ Address offset: 0x25C
    \ Reset value: 0x00000000
    \
    $08 constant HPDMA_TCF                      \ [0x08] transfer complete flag clear
    $09 constant HPDMA_HTF                      \ [0x09] half transfer flag clear
    $0a constant HPDMA_DTEF                     \ [0x0a] data transfer error flag clear
    $0b constant HPDMA_ULEF                     \ [0x0b] update link transfer error flag clear
    $0c constant HPDMA_USEF                     \ [0x0c] user setting error flag clear
    $0d constant HPDMA_SUSPF                    \ [0x0d] completed suspension flag clear
    $0e constant HPDMA_TOF                      \ [0x0e] trigger overrun flag clear
  [then]


  [ifdef] HPDMA_HPDMA_C4SR_DEF
    \
    \ @brief HPDMA channel 4 status register
    \ Address offset: 0x260
    \ Reset value: 0x00000001
    \
    $00 constant HPDMA_IDLEF                    \ [0x00] idle flag
    $08 constant HPDMA_TCF                      \ [0x08] transfer complete flag
    $09 constant HPDMA_HTF                      \ [0x09] half transfer flag
    $0a constant HPDMA_DTEF                     \ [0x0a] data transfer error flag
    $0b constant HPDMA_ULEF                     \ [0x0b] update link transfer error flag
    $0c constant HPDMA_USEF                     \ [0x0c] user setting error flag
    $0d constant HPDMA_SUSPF                    \ [0x0d] completed suspension flag
    $0e constant HPDMA_TOF                      \ [0x0e] trigger overrun flag
    $10 constant HPDMA_FIFOL                    \ [0x10 : 9] monitored FIFO level
  [then]


  [ifdef] HPDMA_HPDMA_C4CR_DEF
    \
    \ @brief HPDMA channel 4 control register
    \ Address offset: 0x264
    \ Reset value: 0x00000000
    \
    $00 constant HPDMA_EN                       \ [0x00] enable
    $01 constant HPDMA_RESET                    \ [0x01] reset
    $02 constant HPDMA_SUSP                     \ [0x02] suspend
    $08 constant HPDMA_TCIE                     \ [0x08] transfer complete interrupt enable
    $09 constant HPDMA_HTIE                     \ [0x09] half transfer complete interrupt enable
    $0a constant HPDMA_DTEIE                    \ [0x0a] data transfer error interrupt enable
    $0b constant HPDMA_ULEIE                    \ [0x0b] update link transfer error interrupt enable
    $0c constant HPDMA_USEIE                    \ [0x0c] user setting error interrupt enable
    $0d constant HPDMA_SUSPIE                   \ [0x0d] completed suspension interrupt enable
    $0e constant HPDMA_TOIE                     \ [0x0e] trigger overrun interrupt enable
    $10 constant HPDMA_LSM                      \ [0x10] Link step mode
    $11 constant HPDMA_LAP                      \ [0x11] linked-list allocated port
    $16 constant HPDMA_PRIO                     \ [0x16 : 2] priority level of the channel x HPDMA transfer versus others
  [then]


  [ifdef] HPDMA_HPDMA_C4TR1_DEF
    \
    \ @brief HPDMA channel 4 transfer register 1
    \ Address offset: 0x290
    \ Reset value: 0x00000000
    \
    $00 constant HPDMA_SDW_LOG2                 \ [0x00 : 2] binary logarithm of the source data width of a burst in bytes
    $03 constant HPDMA_SINC                     \ [0x03] source incrementing burst
    $04 constant HPDMA_SBL_1                    \ [0x04 : 6] source burst length minus 1, between 0 and 63
    $0b constant HPDMA_PAM                      \ [0x0b : 2] padding/alignment mode
    $0d constant HPDMA_SBX                      \ [0x0d] source byte exchange within the unaligned half-word of each source word
    $0e constant HPDMA_SAP                      \ [0x0e] source allocated port
    $0f constant HPDMA_SSEC                     \ [0x0f] security attribute of the HPDMA transfer from the source
    $10 constant HPDMA_DDW_LOG2                 \ [0x10 : 2] binary logarithm of the destination data width of a burst, in bytes
    $13 constant HPDMA_DINC                     \ [0x13] destination incrementing burst
    $14 constant HPDMA_DBL_1                    \ [0x14 : 6] destination burst length minus 1, between 0 and 63
    $1a constant HPDMA_DBX                      \ [0x1a] destination byte exchange
    $1b constant HPDMA_DHX                      \ [0x1b] destination half-word exchange
    $1c constant HPDMA_DWX                      \ [0x1c] destination word exchange
    $1e constant HPDMA_DAP                      \ [0x1e] destination allocated port
    $1f constant HPDMA_DSEC                     \ [0x1f] security attribute of the HPDMA transfer to the destination
  [then]


  [ifdef] HPDMA_HPDMA_C4TR2_DEF
    \
    \ @brief HPDMA channel 4 transfer register 2
    \ Address offset: 0x294
    \ Reset value: 0x00000000
    \
    $00 constant HPDMA_REQSEL                   \ [0x00 : 8] hardware request selection
    $09 constant HPDMA_SWREQ                    \ [0x09] software request
    $0a constant HPDMA_DREQ                     \ [0x0a] destination hardware request
    $0b constant HPDMA_BREQ                     \ [0x0b] Block hardware request
    $0c constant HPDMA_PFREQ                    \ [0x0c] Hardware request in peripheral flow control mode
    $0e constant HPDMA_TRIGM                    \ [0x0e : 2] trigger mode
    $10 constant HPDMA_TRIGSEL                  \ [0x10 : 7] trigger event input selection
    $18 constant HPDMA_TRIGPOL                  \ [0x18 : 2] trigger event polarity
    $1e constant HPDMA_TCEM                     \ [0x1e : 2] transfer complete event mode
  [then]


  [ifdef] HPDMA_HPDMA_C4BR1_DEF
    \
    \ @brief HPDMA channel 4 block register 1
    \ Address offset: 0x298
    \ Reset value: 0x00000000
    \
    $00 constant HPDMA_BNDT                     \ [0x00 : 16] block number of data bytes to transfer from the source
  [then]


  [ifdef] HPDMA_HPDMA_C4SAR_DEF
    \
    \ @brief HPDMA channel 4 source address register
    \ Address offset: 0x29C
    \ Reset value: 0x00000000
    \
    $00 constant HPDMA_SA                       \ [0x00 : 32] source address
  [then]


  [ifdef] HPDMA_HPDMA_C4DAR_DEF
    \
    \ @brief HPDMA channel 4 destination address register
    \ Address offset: 0x2A0
    \ Reset value: 0x00000000
    \
    $00 constant HPDMA_DA                       \ [0x00 : 32] destination address
  [then]


  [ifdef] HPDMA_HPDMA_C4LLR_DEF
    \
    \ @brief HPDMA channel 4 linked-list address register
    \ Address offset: 0x2CC
    \ Reset value: 0x00000000
    \
    $02 constant HPDMA_LA                       \ [0x02 : 14] pointer (16-bit low-significant address) to the next linked-list data structure
    $10 constant HPDMA_ULL                      \ [0x10] Update HPDMA_CxLLR register from memory
    $1b constant HPDMA_UDA                      \ [0x1b] Update HPDMA_CxDAR register from memory
    $1c constant HPDMA_USA                      \ [0x1c] update HPDMA_CxSAR from memory
    $1d constant HPDMA_UB1                      \ [0x1d] Update HPDMA_CxBR1 from memory
    $1e constant HPDMA_UT2                      \ [0x1e] Update HPDMA_CxTR2 from memory
    $1f constant HPDMA_UT1                      \ [0x1f] Update HPDMA_CxTR1 from memory
  [then]


  [ifdef] HPDMA_HPDMA_C5LBAR_DEF
    \
    \ @brief HPDMA channel 5 linked-list base address register
    \ Address offset: 0x2D0
    \ Reset value: 0x00000000
    \
    $10 constant HPDMA_LBA                      \ [0x10 : 16] linked-list base address of HPDMA channel x
  [then]


  [ifdef] HPDMA_HPDMA_C5CIDCFGR_DEF
    \
    \ @brief HPDMA channel 5 CID register
    \ Address offset: 0x2D4
    \ Reset value: 0x00000000
    \
    $00 constant HPDMA_CFEN                     \ [0x00] CID filtering enable of the channel x
    $01 constant HPDMA_SEM_EN                   \ [0x01] semaphore mode enable (for the CID allocation policy to the channel x)
    $04 constant HPDMA_SCID                     \ [0x04 : 3] allocate a static/single CID to the channel x (for when the channel x CID configuration is not in semaphore mode)
    $10 constant HPDMA_SEM_WLIST_CID0           \ [0x10] white-listed CID0 in the CID allocation pool (for when the channel x in semaphore mode)
    $11 constant HPDMA_SEM_WLIST_CID1           \ [0x11] white-listed CID1 in the CID allocation pool (for when the channel x in semaphore mode)
    $12 constant HPDMA_SEM_WLIST_CID2           \ [0x12] white-listed CID2 in the CID allocation pool (for when the channel x in semaphore mode)
    $13 constant HPDMA_SEM_WLIST_CID3           \ [0x13] white-listed CID3 in the CID allocation pool (for when the channel x in semaphore mode)
    $14 constant HPDMA_SEM_WLIST_CID4           \ [0x14] white-listed CID4 in the CID allocation pool (for when the channel x in semaphore mode)
    $15 constant HPDMA_SEM_WLIST_CID5           \ [0x15] white-listed CID5 in the CID allocation pool (for when the channel x in semaphore mode)
    $16 constant HPDMA_SEM_WLIST_CID6           \ [0x16] white-listed CID6 in the CID allocation pool (for when the channel x in semaphore mode)
  [then]


  [ifdef] HPDMA_HPDMA_C5SEMCR_DEF
    \
    \ @brief HPDMA channel 5 semaphore control register
    \ Address offset: 0x2D8
    \ Reset value: 0x00000000
    \
    $00 constant HPDMA_SEM_MUTEX                \ [0x00] mutual exclusion semaphore for the CID allocation of the channel x (in semaphore mode)
    $04 constant HPDMA_SEM_CCID                 \ [0x04 : 3] current CID allocated to the channel x (in semaphore mode)
  [then]


  [ifdef] HPDMA_HPDMA_C5FCR_DEF
    \
    \ @brief HPDMA channel 5 flag clear register
    \ Address offset: 0x2DC
    \ Reset value: 0x00000000
    \
    $08 constant HPDMA_TCF                      \ [0x08] transfer complete flag clear
    $09 constant HPDMA_HTF                      \ [0x09] half transfer flag clear
    $0a constant HPDMA_DTEF                     \ [0x0a] data transfer error flag clear
    $0b constant HPDMA_ULEF                     \ [0x0b] update link transfer error flag clear
    $0c constant HPDMA_USEF                     \ [0x0c] user setting error flag clear
    $0d constant HPDMA_SUSPF                    \ [0x0d] completed suspension flag clear
    $0e constant HPDMA_TOF                      \ [0x0e] trigger overrun flag clear
  [then]


  [ifdef] HPDMA_HPDMA_C5SR_DEF
    \
    \ @brief HPDMA channel 5 status register
    \ Address offset: 0x2E0
    \ Reset value: 0x00000001
    \
    $00 constant HPDMA_IDLEF                    \ [0x00] idle flag
    $08 constant HPDMA_TCF                      \ [0x08] transfer complete flag
    $09 constant HPDMA_HTF                      \ [0x09] half transfer flag
    $0a constant HPDMA_DTEF                     \ [0x0a] data transfer error flag
    $0b constant HPDMA_ULEF                     \ [0x0b] update link transfer error flag
    $0c constant HPDMA_USEF                     \ [0x0c] user setting error flag
    $0d constant HPDMA_SUSPF                    \ [0x0d] completed suspension flag
    $0e constant HPDMA_TOF                      \ [0x0e] trigger overrun flag
    $10 constant HPDMA_FIFOL                    \ [0x10 : 9] monitored FIFO level
  [then]


  [ifdef] HPDMA_HPDMA_C5CR_DEF
    \
    \ @brief HPDMA channel 5 control register
    \ Address offset: 0x2E4
    \ Reset value: 0x00000000
    \
    $00 constant HPDMA_EN                       \ [0x00] enable
    $01 constant HPDMA_RESET                    \ [0x01] reset
    $02 constant HPDMA_SUSP                     \ [0x02] suspend
    $08 constant HPDMA_TCIE                     \ [0x08] transfer complete interrupt enable
    $09 constant HPDMA_HTIE                     \ [0x09] half transfer complete interrupt enable
    $0a constant HPDMA_DTEIE                    \ [0x0a] data transfer error interrupt enable
    $0b constant HPDMA_ULEIE                    \ [0x0b] update link transfer error interrupt enable
    $0c constant HPDMA_USEIE                    \ [0x0c] user setting error interrupt enable
    $0d constant HPDMA_SUSPIE                   \ [0x0d] completed suspension interrupt enable
    $0e constant HPDMA_TOIE                     \ [0x0e] trigger overrun interrupt enable
    $10 constant HPDMA_LSM                      \ [0x10] Link step mode
    $11 constant HPDMA_LAP                      \ [0x11] linked-list allocated port
    $16 constant HPDMA_PRIO                     \ [0x16 : 2] priority level of the channel x HPDMA transfer versus others
  [then]


  [ifdef] HPDMA_HPDMA_C5TR1_DEF
    \
    \ @brief HPDMA channel 5 transfer register 1
    \ Address offset: 0x310
    \ Reset value: 0x00000000
    \
    $00 constant HPDMA_SDW_LOG2                 \ [0x00 : 2] binary logarithm of the source data width of a burst in bytes
    $03 constant HPDMA_SINC                     \ [0x03] source incrementing burst
    $04 constant HPDMA_SBL_1                    \ [0x04 : 6] source burst length minus 1, between 0 and 63
    $0b constant HPDMA_PAM                      \ [0x0b : 2] padding/alignment mode
    $0d constant HPDMA_SBX                      \ [0x0d] source byte exchange within the unaligned half-word of each source word
    $0e constant HPDMA_SAP                      \ [0x0e] source allocated port
    $0f constant HPDMA_SSEC                     \ [0x0f] security attribute of the HPDMA transfer from the source
    $10 constant HPDMA_DDW_LOG2                 \ [0x10 : 2] binary logarithm of the destination data width of a burst, in bytes
    $13 constant HPDMA_DINC                     \ [0x13] destination incrementing burst
    $14 constant HPDMA_DBL_1                    \ [0x14 : 6] destination burst length minus 1, between 0 and 63
    $1a constant HPDMA_DBX                      \ [0x1a] destination byte exchange
    $1b constant HPDMA_DHX                      \ [0x1b] destination half-word exchange
    $1c constant HPDMA_DWX                      \ [0x1c] destination word exchange
    $1e constant HPDMA_DAP                      \ [0x1e] destination allocated port
    $1f constant HPDMA_DSEC                     \ [0x1f] security attribute of the HPDMA transfer to the destination
  [then]


  [ifdef] HPDMA_HPDMA_C5TR2_DEF
    \
    \ @brief HPDMA channel 5 transfer register 2
    \ Address offset: 0x314
    \ Reset value: 0x00000000
    \
    $00 constant HPDMA_REQSEL                   \ [0x00 : 8] hardware request selection
    $09 constant HPDMA_SWREQ                    \ [0x09] software request
    $0a constant HPDMA_DREQ                     \ [0x0a] destination hardware request
    $0b constant HPDMA_BREQ                     \ [0x0b] Block hardware request
    $0c constant HPDMA_PFREQ                    \ [0x0c] Hardware request in peripheral flow control mode
    $0e constant HPDMA_TRIGM                    \ [0x0e : 2] trigger mode
    $10 constant HPDMA_TRIGSEL                  \ [0x10 : 7] trigger event input selection
    $18 constant HPDMA_TRIGPOL                  \ [0x18 : 2] trigger event polarity
    $1e constant HPDMA_TCEM                     \ [0x1e : 2] transfer complete event mode
  [then]


  [ifdef] HPDMA_HPDMA_C5BR1_DEF
    \
    \ @brief HPDMA channel 5 block register 1
    \ Address offset: 0x318
    \ Reset value: 0x00000000
    \
    $00 constant HPDMA_BNDT                     \ [0x00 : 16] block number of data bytes to transfer from the source
  [then]


  [ifdef] HPDMA_HPDMA_C5SAR_DEF
    \
    \ @brief HPDMA channel 5 source address register
    \ Address offset: 0x31C
    \ Reset value: 0x00000000
    \
    $00 constant HPDMA_SA                       \ [0x00 : 32] source address
  [then]


  [ifdef] HPDMA_HPDMA_C5DAR_DEF
    \
    \ @brief HPDMA channel 5 destination address register
    \ Address offset: 0x320
    \ Reset value: 0x00000000
    \
    $00 constant HPDMA_DA                       \ [0x00 : 32] destination address
  [then]


  [ifdef] HPDMA_HPDMA_C5LLR_DEF
    \
    \ @brief HPDMA channel 5 linked-list address register
    \ Address offset: 0x34C
    \ Reset value: 0x00000000
    \
    $02 constant HPDMA_LA                       \ [0x02 : 14] pointer (16-bit low-significant address) to the next linked-list data structure
    $10 constant HPDMA_ULL                      \ [0x10] Update HPDMA_CxLLR register from memory
    $1b constant HPDMA_UDA                      \ [0x1b] Update HPDMA_CxDAR register from memory
    $1c constant HPDMA_USA                      \ [0x1c] update HPDMA_CxSAR from memory
    $1d constant HPDMA_UB1                      \ [0x1d] Update HPDMA_CxBR1 from memory
    $1e constant HPDMA_UT2                      \ [0x1e] Update HPDMA_CxTR2 from memory
    $1f constant HPDMA_UT1                      \ [0x1f] Update HPDMA_CxTR1 from memory
  [then]


  [ifdef] HPDMA_HPDMA_C6LBAR_DEF
    \
    \ @brief HPDMA channel 6 linked-list base address register
    \ Address offset: 0x350
    \ Reset value: 0x00000000
    \
    $10 constant HPDMA_LBA                      \ [0x10 : 16] linked-list base address of HPDMA channel x
  [then]


  [ifdef] HPDMA_HPDMA_C6CIDCFGR_DEF
    \
    \ @brief HPDMA channel 6 CID register
    \ Address offset: 0x354
    \ Reset value: 0x00000000
    \
    $00 constant HPDMA_CFEN                     \ [0x00] CID filtering enable of the channel x
    $01 constant HPDMA_SEM_EN                   \ [0x01] semaphore mode enable (for the CID allocation policy to the channel x)
    $04 constant HPDMA_SCID                     \ [0x04 : 3] allocate a static/single CID to the channel x (for when the channel x CID configuration is not in semaphore mode)
    $10 constant HPDMA_SEM_WLIST_CID0           \ [0x10] white-listed CID0 in the CID allocation pool (for when the channel x in semaphore mode)
    $11 constant HPDMA_SEM_WLIST_CID1           \ [0x11] white-listed CID1 in the CID allocation pool (for when the channel x in semaphore mode)
    $12 constant HPDMA_SEM_WLIST_CID2           \ [0x12] white-listed CID2 in the CID allocation pool (for when the channel x in semaphore mode)
    $13 constant HPDMA_SEM_WLIST_CID3           \ [0x13] white-listed CID3 in the CID allocation pool (for when the channel x in semaphore mode)
    $14 constant HPDMA_SEM_WLIST_CID4           \ [0x14] white-listed CID4 in the CID allocation pool (for when the channel x in semaphore mode)
    $15 constant HPDMA_SEM_WLIST_CID5           \ [0x15] white-listed CID5 in the CID allocation pool (for when the channel x in semaphore mode)
    $16 constant HPDMA_SEM_WLIST_CID6           \ [0x16] white-listed CID6 in the CID allocation pool (for when the channel x in semaphore mode)
  [then]


  [ifdef] HPDMA_HPDMA_C6SEMCR_DEF
    \
    \ @brief HPDMA channel 6 semaphore control register
    \ Address offset: 0x358
    \ Reset value: 0x00000000
    \
    $00 constant HPDMA_SEM_MUTEX                \ [0x00] mutual exclusion semaphore for the CID allocation of the channel x (in semaphore mode)
    $04 constant HPDMA_SEM_CCID                 \ [0x04 : 3] current CID allocated to the channel x (in semaphore mode)
  [then]


  [ifdef] HPDMA_HPDMA_C6FCR_DEF
    \
    \ @brief HPDMA channel 6 flag clear register
    \ Address offset: 0x35C
    \ Reset value: 0x00000000
    \
    $08 constant HPDMA_TCF                      \ [0x08] transfer complete flag clear
    $09 constant HPDMA_HTF                      \ [0x09] half transfer flag clear
    $0a constant HPDMA_DTEF                     \ [0x0a] data transfer error flag clear
    $0b constant HPDMA_ULEF                     \ [0x0b] update link transfer error flag clear
    $0c constant HPDMA_USEF                     \ [0x0c] user setting error flag clear
    $0d constant HPDMA_SUSPF                    \ [0x0d] completed suspension flag clear
    $0e constant HPDMA_TOF                      \ [0x0e] trigger overrun flag clear
  [then]


  [ifdef] HPDMA_HPDMA_C6SR_DEF
    \
    \ @brief HPDMA channel 6 status register
    \ Address offset: 0x360
    \ Reset value: 0x00000001
    \
    $00 constant HPDMA_IDLEF                    \ [0x00] idle flag
    $08 constant HPDMA_TCF                      \ [0x08] transfer complete flag
    $09 constant HPDMA_HTF                      \ [0x09] half transfer flag
    $0a constant HPDMA_DTEF                     \ [0x0a] data transfer error flag
    $0b constant HPDMA_ULEF                     \ [0x0b] update link transfer error flag
    $0c constant HPDMA_USEF                     \ [0x0c] user setting error flag
    $0d constant HPDMA_SUSPF                    \ [0x0d] completed suspension flag
    $0e constant HPDMA_TOF                      \ [0x0e] trigger overrun flag
    $10 constant HPDMA_FIFOL                    \ [0x10 : 9] monitored FIFO level
  [then]


  [ifdef] HPDMA_HPDMA_C6CR_DEF
    \
    \ @brief HPDMA channel 6 control register
    \ Address offset: 0x364
    \ Reset value: 0x00000000
    \
    $00 constant HPDMA_EN                       \ [0x00] enable
    $01 constant HPDMA_RESET                    \ [0x01] reset
    $02 constant HPDMA_SUSP                     \ [0x02] suspend
    $08 constant HPDMA_TCIE                     \ [0x08] transfer complete interrupt enable
    $09 constant HPDMA_HTIE                     \ [0x09] half transfer complete interrupt enable
    $0a constant HPDMA_DTEIE                    \ [0x0a] data transfer error interrupt enable
    $0b constant HPDMA_ULEIE                    \ [0x0b] update link transfer error interrupt enable
    $0c constant HPDMA_USEIE                    \ [0x0c] user setting error interrupt enable
    $0d constant HPDMA_SUSPIE                   \ [0x0d] completed suspension interrupt enable
    $0e constant HPDMA_TOIE                     \ [0x0e] trigger overrun interrupt enable
    $10 constant HPDMA_LSM                      \ [0x10] Link step mode
    $11 constant HPDMA_LAP                      \ [0x11] linked-list allocated port
    $16 constant HPDMA_PRIO                     \ [0x16 : 2] priority level of the channel x HPDMA transfer versus others
  [then]


  [ifdef] HPDMA_HPDMA_C6TR1_DEF
    \
    \ @brief HPDMA channel 6 transfer register 1
    \ Address offset: 0x390
    \ Reset value: 0x00000000
    \
    $00 constant HPDMA_SDW_LOG2                 \ [0x00 : 2] binary logarithm of the source data width of a burst in bytes
    $03 constant HPDMA_SINC                     \ [0x03] source incrementing burst
    $04 constant HPDMA_SBL_1                    \ [0x04 : 6] source burst length minus 1, between 0 and 63
    $0b constant HPDMA_PAM                      \ [0x0b : 2] padding/alignment mode
    $0d constant HPDMA_SBX                      \ [0x0d] source byte exchange within the unaligned half-word of each source word
    $0e constant HPDMA_SAP                      \ [0x0e] source allocated port
    $0f constant HPDMA_SSEC                     \ [0x0f] security attribute of the HPDMA transfer from the source
    $10 constant HPDMA_DDW_LOG2                 \ [0x10 : 2] binary logarithm of the destination data width of a burst, in bytes
    $13 constant HPDMA_DINC                     \ [0x13] destination incrementing burst
    $14 constant HPDMA_DBL_1                    \ [0x14 : 6] destination burst length minus 1, between 0 and 63
    $1a constant HPDMA_DBX                      \ [0x1a] destination byte exchange
    $1b constant HPDMA_DHX                      \ [0x1b] destination half-word exchange
    $1c constant HPDMA_DWX                      \ [0x1c] destination word exchange
    $1e constant HPDMA_DAP                      \ [0x1e] destination allocated port
    $1f constant HPDMA_DSEC                     \ [0x1f] security attribute of the HPDMA transfer to the destination
  [then]


  [ifdef] HPDMA_HPDMA_C6TR2_DEF
    \
    \ @brief HPDMA channel 6 transfer register 2
    \ Address offset: 0x394
    \ Reset value: 0x00000000
    \
    $00 constant HPDMA_REQSEL                   \ [0x00 : 8] hardware request selection
    $09 constant HPDMA_SWREQ                    \ [0x09] software request
    $0a constant HPDMA_DREQ                     \ [0x0a] destination hardware request
    $0b constant HPDMA_BREQ                     \ [0x0b] Block hardware request
    $0c constant HPDMA_PFREQ                    \ [0x0c] Hardware request in peripheral flow control mode
    $0e constant HPDMA_TRIGM                    \ [0x0e : 2] trigger mode
    $10 constant HPDMA_TRIGSEL                  \ [0x10 : 7] trigger event input selection
    $18 constant HPDMA_TRIGPOL                  \ [0x18 : 2] trigger event polarity
    $1e constant HPDMA_TCEM                     \ [0x1e : 2] transfer complete event mode
  [then]


  [ifdef] HPDMA_HPDMA_C6BR1_DEF
    \
    \ @brief HPDMA channel 6 block register 1
    \ Address offset: 0x398
    \ Reset value: 0x00000000
    \
    $00 constant HPDMA_BNDT                     \ [0x00 : 16] block number of data bytes to transfer from the source
  [then]


  [ifdef] HPDMA_HPDMA_C6SAR_DEF
    \
    \ @brief HPDMA channel 6 source address register
    \ Address offset: 0x39C
    \ Reset value: 0x00000000
    \
    $00 constant HPDMA_SA                       \ [0x00 : 32] source address
  [then]


  [ifdef] HPDMA_HPDMA_C6DAR_DEF
    \
    \ @brief HPDMA channel 6 destination address register
    \ Address offset: 0x3A0
    \ Reset value: 0x00000000
    \
    $00 constant HPDMA_DA                       \ [0x00 : 32] destination address
  [then]


  [ifdef] HPDMA_HPDMA_C6LLR_DEF
    \
    \ @brief HPDMA channel 6 linked-list address register
    \ Address offset: 0x3CC
    \ Reset value: 0x00000000
    \
    $02 constant HPDMA_LA                       \ [0x02 : 14] pointer (16-bit low-significant address) to the next linked-list data structure
    $10 constant HPDMA_ULL                      \ [0x10] Update HPDMA_CxLLR register from memory
    $1b constant HPDMA_UDA                      \ [0x1b] Update HPDMA_CxDAR register from memory
    $1c constant HPDMA_USA                      \ [0x1c] update HPDMA_CxSAR from memory
    $1d constant HPDMA_UB1                      \ [0x1d] Update HPDMA_CxBR1 from memory
    $1e constant HPDMA_UT2                      \ [0x1e] Update HPDMA_CxTR2 from memory
    $1f constant HPDMA_UT1                      \ [0x1f] Update HPDMA_CxTR1 from memory
  [then]


  [ifdef] HPDMA_HPDMA_C7LBAR_DEF
    \
    \ @brief HPDMA channel 7 linked-list base address register
    \ Address offset: 0x3D0
    \ Reset value: 0x00000000
    \
    $10 constant HPDMA_LBA                      \ [0x10 : 16] linked-list base address of HPDMA channel x
  [then]


  [ifdef] HPDMA_HPDMA_C7CIDCFGR_DEF
    \
    \ @brief HPDMA channel 7 CID register
    \ Address offset: 0x3D4
    \ Reset value: 0x00000000
    \
    $00 constant HPDMA_CFEN                     \ [0x00] CID filtering enable of the channel x
    $01 constant HPDMA_SEM_EN                   \ [0x01] semaphore mode enable (for the CID allocation policy to the channel x)
    $04 constant HPDMA_SCID                     \ [0x04 : 3] allocate a static/single CID to the channel x (for when the channel x CID configuration is not in semaphore mode)
    $10 constant HPDMA_SEM_WLIST_CID0           \ [0x10] white-listed CID0 in the CID allocation pool (for when the channel x in semaphore mode)
    $11 constant HPDMA_SEM_WLIST_CID1           \ [0x11] white-listed CID1 in the CID allocation pool (for when the channel x in semaphore mode)
    $12 constant HPDMA_SEM_WLIST_CID2           \ [0x12] white-listed CID2 in the CID allocation pool (for when the channel x in semaphore mode)
    $13 constant HPDMA_SEM_WLIST_CID3           \ [0x13] white-listed CID3 in the CID allocation pool (for when the channel x in semaphore mode)
    $14 constant HPDMA_SEM_WLIST_CID4           \ [0x14] white-listed CID4 in the CID allocation pool (for when the channel x in semaphore mode)
    $15 constant HPDMA_SEM_WLIST_CID5           \ [0x15] white-listed CID5 in the CID allocation pool (for when the channel x in semaphore mode)
    $16 constant HPDMA_SEM_WLIST_CID6           \ [0x16] white-listed CID6 in the CID allocation pool (for when the channel x in semaphore mode)
  [then]


  [ifdef] HPDMA_HPDMA_C7SEMCR_DEF
    \
    \ @brief HPDMA channel 7 semaphore control register
    \ Address offset: 0x3D8
    \ Reset value: 0x00000000
    \
    $00 constant HPDMA_SEM_MUTEX                \ [0x00] mutual exclusion semaphore for the CID allocation of the channel x (in semaphore mode)
    $04 constant HPDMA_SEM_CCID                 \ [0x04 : 3] current CID allocated to the channel x (in semaphore mode)
  [then]


  [ifdef] HPDMA_HPDMA_C7FCR_DEF
    \
    \ @brief HPDMA channel 7 flag clear register
    \ Address offset: 0x3DC
    \ Reset value: 0x00000000
    \
    $08 constant HPDMA_TCF                      \ [0x08] transfer complete flag clear
    $09 constant HPDMA_HTF                      \ [0x09] half transfer flag clear
    $0a constant HPDMA_DTEF                     \ [0x0a] data transfer error flag clear
    $0b constant HPDMA_ULEF                     \ [0x0b] update link transfer error flag clear
    $0c constant HPDMA_USEF                     \ [0x0c] user setting error flag clear
    $0d constant HPDMA_SUSPF                    \ [0x0d] completed suspension flag clear
    $0e constant HPDMA_TOF                      \ [0x0e] trigger overrun flag clear
  [then]


  [ifdef] HPDMA_HPDMA_C7SR_DEF
    \
    \ @brief HPDMA channel 7 status register
    \ Address offset: 0x3E0
    \ Reset value: 0x00000001
    \
    $00 constant HPDMA_IDLEF                    \ [0x00] idle flag
    $08 constant HPDMA_TCF                      \ [0x08] transfer complete flag
    $09 constant HPDMA_HTF                      \ [0x09] half transfer flag
    $0a constant HPDMA_DTEF                     \ [0x0a] data transfer error flag
    $0b constant HPDMA_ULEF                     \ [0x0b] update link transfer error flag
    $0c constant HPDMA_USEF                     \ [0x0c] user setting error flag
    $0d constant HPDMA_SUSPF                    \ [0x0d] completed suspension flag
    $0e constant HPDMA_TOF                      \ [0x0e] trigger overrun flag
    $10 constant HPDMA_FIFOL                    \ [0x10 : 9] monitored FIFO level
  [then]


  [ifdef] HPDMA_HPDMA_C7CR_DEF
    \
    \ @brief HPDMA channel 7 control register
    \ Address offset: 0x3E4
    \ Reset value: 0x00000000
    \
    $00 constant HPDMA_EN                       \ [0x00] enable
    $01 constant HPDMA_RESET                    \ [0x01] reset
    $02 constant HPDMA_SUSP                     \ [0x02] suspend
    $08 constant HPDMA_TCIE                     \ [0x08] transfer complete interrupt enable
    $09 constant HPDMA_HTIE                     \ [0x09] half transfer complete interrupt enable
    $0a constant HPDMA_DTEIE                    \ [0x0a] data transfer error interrupt enable
    $0b constant HPDMA_ULEIE                    \ [0x0b] update link transfer error interrupt enable
    $0c constant HPDMA_USEIE                    \ [0x0c] user setting error interrupt enable
    $0d constant HPDMA_SUSPIE                   \ [0x0d] completed suspension interrupt enable
    $0e constant HPDMA_TOIE                     \ [0x0e] trigger overrun interrupt enable
    $10 constant HPDMA_LSM                      \ [0x10] Link step mode
    $11 constant HPDMA_LAP                      \ [0x11] linked-list allocated port
    $16 constant HPDMA_PRIO                     \ [0x16 : 2] priority level of the channel x HPDMA transfer versus others
  [then]


  [ifdef] HPDMA_HPDMA_C7TR1_DEF
    \
    \ @brief HPDMA channel 7 transfer register 1
    \ Address offset: 0x410
    \ Reset value: 0x00000000
    \
    $00 constant HPDMA_SDW_LOG2                 \ [0x00 : 2] binary logarithm of the source data width of a burst in bytes
    $03 constant HPDMA_SINC                     \ [0x03] source incrementing burst
    $04 constant HPDMA_SBL_1                    \ [0x04 : 6] source burst length minus 1, between 0 and 63
    $0b constant HPDMA_PAM                      \ [0x0b : 2] padding/alignment mode
    $0d constant HPDMA_SBX                      \ [0x0d] source byte exchange within the unaligned half-word of each source word
    $0e constant HPDMA_SAP                      \ [0x0e] source allocated port
    $0f constant HPDMA_SSEC                     \ [0x0f] security attribute of the HPDMA transfer from the source
    $10 constant HPDMA_DDW_LOG2                 \ [0x10 : 2] binary logarithm of the destination data width of a burst, in bytes
    $13 constant HPDMA_DINC                     \ [0x13] destination incrementing burst
    $14 constant HPDMA_DBL_1                    \ [0x14 : 6] destination burst length minus 1, between 0 and 63
    $1a constant HPDMA_DBX                      \ [0x1a] destination byte exchange
    $1b constant HPDMA_DHX                      \ [0x1b] destination half-word exchange
    $1c constant HPDMA_DWX                      \ [0x1c] destination word exchange
    $1e constant HPDMA_DAP                      \ [0x1e] destination allocated port
    $1f constant HPDMA_DSEC                     \ [0x1f] security attribute of the HPDMA transfer to the destination
  [then]


  [ifdef] HPDMA_HPDMA_C7TR2_DEF
    \
    \ @brief HPDMA channel 7 transfer register 2
    \ Address offset: 0x414
    \ Reset value: 0x00000000
    \
    $00 constant HPDMA_REQSEL                   \ [0x00 : 8] hardware request selection
    $09 constant HPDMA_SWREQ                    \ [0x09] software request
    $0a constant HPDMA_DREQ                     \ [0x0a] destination hardware request
    $0b constant HPDMA_BREQ                     \ [0x0b] Block hardware request
    $0c constant HPDMA_PFREQ                    \ [0x0c] Hardware request in peripheral flow control mode
    $0e constant HPDMA_TRIGM                    \ [0x0e : 2] trigger mode
    $10 constant HPDMA_TRIGSEL                  \ [0x10 : 7] trigger event input selection
    $18 constant HPDMA_TRIGPOL                  \ [0x18 : 2] trigger event polarity
    $1e constant HPDMA_TCEM                     \ [0x1e : 2] transfer complete event mode
  [then]


  [ifdef] HPDMA_HPDMA_C7BR1_DEF
    \
    \ @brief HPDMA channel 7 block register 1
    \ Address offset: 0x418
    \ Reset value: 0x00000000
    \
    $00 constant HPDMA_BNDT                     \ [0x00 : 16] block number of data bytes to transfer from the source
  [then]


  [ifdef] HPDMA_HPDMA_C7SAR_DEF
    \
    \ @brief HPDMA channel 7 source address register
    \ Address offset: 0x41C
    \ Reset value: 0x00000000
    \
    $00 constant HPDMA_SA                       \ [0x00 : 32] source address
  [then]


  [ifdef] HPDMA_HPDMA_C7DAR_DEF
    \
    \ @brief HPDMA channel 7 destination address register
    \ Address offset: 0x420
    \ Reset value: 0x00000000
    \
    $00 constant HPDMA_DA                       \ [0x00 : 32] destination address
  [then]


  [ifdef] HPDMA_HPDMA_C7LLR_DEF
    \
    \ @brief HPDMA channel 7 linked-list address register
    \ Address offset: 0x44C
    \ Reset value: 0x00000000
    \
    $02 constant HPDMA_LA                       \ [0x02 : 14] pointer (16-bit low-significant address) to the next linked-list data structure
    $10 constant HPDMA_ULL                      \ [0x10] Update HPDMA_CxLLR register from memory
    $1b constant HPDMA_UDA                      \ [0x1b] Update HPDMA_CxDAR register from memory
    $1c constant HPDMA_USA                      \ [0x1c] update HPDMA_CxSAR from memory
    $1d constant HPDMA_UB1                      \ [0x1d] Update HPDMA_CxBR1 from memory
    $1e constant HPDMA_UT2                      \ [0x1e] Update HPDMA_CxTR2 from memory
    $1f constant HPDMA_UT1                      \ [0x1f] Update HPDMA_CxTR1 from memory
  [then]


  [ifdef] HPDMA_HPDMA_C8LBAR_DEF
    \
    \ @brief HPDMA channel 8 linked-list base address register
    \ Address offset: 0x450
    \ Reset value: 0x00000000
    \
    $10 constant HPDMA_LBA                      \ [0x10 : 16] linked-list base address of HPDMA channel x
  [then]


  [ifdef] HPDMA_HPDMA_C8CIDCFGR_DEF
    \
    \ @brief HPDMA channel 8 CID register
    \ Address offset: 0x454
    \ Reset value: 0x00000000
    \
    $00 constant HPDMA_CFEN                     \ [0x00] CID filtering enable of the channel x
    $01 constant HPDMA_SEM_EN                   \ [0x01] semaphore mode enable (for the CID allocation policy to the channel x)
    $04 constant HPDMA_SCID                     \ [0x04 : 3] allocate a static/single CID to the channel x (for when the channel x CID configuration is not in semaphore mode)
    $10 constant HPDMA_SEM_WLIST_CID0           \ [0x10] white-listed CID0 in the CID allocation pool (for when the channel x in semaphore mode)
    $11 constant HPDMA_SEM_WLIST_CID1           \ [0x11] white-listed CID1 in the CID allocation pool (for when the channel x in semaphore mode)
    $12 constant HPDMA_SEM_WLIST_CID2           \ [0x12] white-listed CID2 in the CID allocation pool (for when the channel x in semaphore mode)
    $13 constant HPDMA_SEM_WLIST_CID3           \ [0x13] white-listed CID3 in the CID allocation pool (for when the channel x in semaphore mode)
    $14 constant HPDMA_SEM_WLIST_CID4           \ [0x14] white-listed CID4 in the CID allocation pool (for when the channel x in semaphore mode)
    $15 constant HPDMA_SEM_WLIST_CID5           \ [0x15] white-listed CID5 in the CID allocation pool (for when the channel x in semaphore mode)
    $16 constant HPDMA_SEM_WLIST_CID6           \ [0x16] white-listed CID6 in the CID allocation pool (for when the channel x in semaphore mode)
  [then]


  [ifdef] HPDMA_HPDMA_C8SEMCR_DEF
    \
    \ @brief HPDMA channel 8 semaphore control register
    \ Address offset: 0x458
    \ Reset value: 0x00000000
    \
    $00 constant HPDMA_SEM_MUTEX                \ [0x00] mutual exclusion semaphore for the CID allocation of the channel x (in semaphore mode)
    $04 constant HPDMA_SEM_CCID                 \ [0x04 : 3] current CID allocated to the channel x (in semaphore mode)
  [then]


  [ifdef] HPDMA_HPDMA_C8FCR_DEF
    \
    \ @brief HPDMA channel 8 flag clear register
    \ Address offset: 0x45C
    \ Reset value: 0x00000000
    \
    $08 constant HPDMA_TCF                      \ [0x08] transfer complete flag clear
    $09 constant HPDMA_HTF                      \ [0x09] half transfer flag clear
    $0a constant HPDMA_DTEF                     \ [0x0a] data transfer error flag clear
    $0b constant HPDMA_ULEF                     \ [0x0b] update link transfer error flag clear
    $0c constant HPDMA_USEF                     \ [0x0c] user setting error flag clear
    $0d constant HPDMA_SUSPF                    \ [0x0d] completed suspension flag clear
    $0e constant HPDMA_TOF                      \ [0x0e] trigger overrun flag clear
  [then]


  [ifdef] HPDMA_HPDMA_C8SR_DEF
    \
    \ @brief HPDMA channel 8 status register
    \ Address offset: 0x460
    \ Reset value: 0x00000001
    \
    $00 constant HPDMA_IDLEF                    \ [0x00] idle flag
    $08 constant HPDMA_TCF                      \ [0x08] transfer complete flag
    $09 constant HPDMA_HTF                      \ [0x09] half transfer flag
    $0a constant HPDMA_DTEF                     \ [0x0a] data transfer error flag
    $0b constant HPDMA_ULEF                     \ [0x0b] update link transfer error flag
    $0c constant HPDMA_USEF                     \ [0x0c] user setting error flag
    $0d constant HPDMA_SUSPF                    \ [0x0d] completed suspension flag
    $0e constant HPDMA_TOF                      \ [0x0e] trigger overrun flag
    $10 constant HPDMA_FIFOL                    \ [0x10 : 9] monitored FIFO level
  [then]


  [ifdef] HPDMA_HPDMA_C8CR_DEF
    \
    \ @brief HPDMA channel 8 control register
    \ Address offset: 0x464
    \ Reset value: 0x00000000
    \
    $00 constant HPDMA_EN                       \ [0x00] enable
    $01 constant HPDMA_RESET                    \ [0x01] reset
    $02 constant HPDMA_SUSP                     \ [0x02] suspend
    $08 constant HPDMA_TCIE                     \ [0x08] transfer complete interrupt enable
    $09 constant HPDMA_HTIE                     \ [0x09] half transfer complete interrupt enable
    $0a constant HPDMA_DTEIE                    \ [0x0a] data transfer error interrupt enable
    $0b constant HPDMA_ULEIE                    \ [0x0b] update link transfer error interrupt enable
    $0c constant HPDMA_USEIE                    \ [0x0c] user setting error interrupt enable
    $0d constant HPDMA_SUSPIE                   \ [0x0d] completed suspension interrupt enable
    $0e constant HPDMA_TOIE                     \ [0x0e] trigger overrun interrupt enable
    $10 constant HPDMA_LSM                      \ [0x10] Link step mode
    $11 constant HPDMA_LAP                      \ [0x11] linked-list allocated port
    $16 constant HPDMA_PRIO                     \ [0x16 : 2] priority level of the channel x HPDMA transfer versus others
  [then]


  [ifdef] HPDMA_HPDMA_C8TR1_DEF
    \
    \ @brief HPDMA channel 8 transfer register 1
    \ Address offset: 0x490
    \ Reset value: 0x00000000
    \
    $00 constant HPDMA_SDW_LOG2                 \ [0x00 : 2] binary logarithm of the source data width of a burst in bytes
    $03 constant HPDMA_SINC                     \ [0x03] source incrementing burst
    $04 constant HPDMA_SBL_1                    \ [0x04 : 6] source burst length minus 1, between 0 and 63
    $0b constant HPDMA_PAM                      \ [0x0b : 2] padding/alignment mode
    $0d constant HPDMA_SBX                      \ [0x0d] source byte exchange within the unaligned half-word of each source word
    $0e constant HPDMA_SAP                      \ [0x0e] source allocated port
    $0f constant HPDMA_SSEC                     \ [0x0f] security attribute of the HPDMA transfer from the source
    $10 constant HPDMA_DDW_LOG2                 \ [0x10 : 2] binary logarithm of the destination data width of a burst, in bytes
    $13 constant HPDMA_DINC                     \ [0x13] destination incrementing burst
    $14 constant HPDMA_DBL_1                    \ [0x14 : 6] destination burst length minus 1, between 0 and 63
    $1a constant HPDMA_DBX                      \ [0x1a] destination byte exchange
    $1b constant HPDMA_DHX                      \ [0x1b] destination half-word exchange
    $1c constant HPDMA_DWX                      \ [0x1c] destination word exchange
    $1e constant HPDMA_DAP                      \ [0x1e] destination allocated port
    $1f constant HPDMA_DSEC                     \ [0x1f] security attribute of the HPDMA transfer to the destination
  [then]


  [ifdef] HPDMA_HPDMA_C8TR2_DEF
    \
    \ @brief HPDMA channel 8 transfer register 2
    \ Address offset: 0x494
    \ Reset value: 0x00000000
    \
    $00 constant HPDMA_REQSEL                   \ [0x00 : 8] hardware request selection
    $09 constant HPDMA_SWREQ                    \ [0x09] software request
    $0a constant HPDMA_DREQ                     \ [0x0a] destination hardware request
    $0b constant HPDMA_BREQ                     \ [0x0b] Block hardware request
    $0c constant HPDMA_PFREQ                    \ [0x0c] Hardware request in peripheral flow control mode
    $0e constant HPDMA_TRIGM                    \ [0x0e : 2] trigger mode
    $10 constant HPDMA_TRIGSEL                  \ [0x10 : 7] trigger event input selection
    $18 constant HPDMA_TRIGPOL                  \ [0x18 : 2] trigger event polarity
    $1e constant HPDMA_TCEM                     \ [0x1e : 2] transfer complete event mode
  [then]


  [ifdef] HPDMA_HPDMA_C8BR1_DEF
    \
    \ @brief HPDMA channel 8 block register 1
    \ Address offset: 0x498
    \ Reset value: 0x00000000
    \
    $00 constant HPDMA_BNDT                     \ [0x00 : 16] block number of data bytes to transfer from the source
  [then]


  [ifdef] HPDMA_HPDMA_C8SAR_DEF
    \
    \ @brief HPDMA channel 8 source address register
    \ Address offset: 0x49C
    \ Reset value: 0x00000000
    \
    $00 constant HPDMA_SA                       \ [0x00 : 32] source address
  [then]


  [ifdef] HPDMA_HPDMA_C8DAR_DEF
    \
    \ @brief HPDMA channel 8 destination address register
    \ Address offset: 0x4A0
    \ Reset value: 0x00000000
    \
    $00 constant HPDMA_DA                       \ [0x00 : 32] destination address
  [then]


  [ifdef] HPDMA_HPDMA_C8LLR_DEF
    \
    \ @brief HPDMA channel 8 linked-list address register
    \ Address offset: 0x4CC
    \ Reset value: 0x00000000
    \
    $02 constant HPDMA_LA                       \ [0x02 : 14] pointer (16-bit low-significant address) to the next linked-list data structure
    $10 constant HPDMA_ULL                      \ [0x10] Update HPDMA_CxLLR register from memory
    $1b constant HPDMA_UDA                      \ [0x1b] Update HPDMA_CxDAR register from memory
    $1c constant HPDMA_USA                      \ [0x1c] update HPDMA_CxSAR from memory
    $1d constant HPDMA_UB1                      \ [0x1d] Update HPDMA_CxBR1 from memory
    $1e constant HPDMA_UT2                      \ [0x1e] Update HPDMA_CxTR2 from memory
    $1f constant HPDMA_UT1                      \ [0x1f] Update HPDMA_CxTR1 from memory
  [then]


  [ifdef] HPDMA_HPDMA_C9LBAR_DEF
    \
    \ @brief HPDMA channel 9 linked-list base address register
    \ Address offset: 0x4D0
    \ Reset value: 0x00000000
    \
    $10 constant HPDMA_LBA                      \ [0x10 : 16] linked-list base address of HPDMA channel x
  [then]


  [ifdef] HPDMA_HPDMA_C9CIDCFGR_DEF
    \
    \ @brief HPDMA channel 9 CID register
    \ Address offset: 0x4D4
    \ Reset value: 0x00000000
    \
    $00 constant HPDMA_CFEN                     \ [0x00] CID filtering enable of the channel x
    $01 constant HPDMA_SEM_EN                   \ [0x01] semaphore mode enable (for the CID allocation policy to the channel x)
    $04 constant HPDMA_SCID                     \ [0x04 : 3] allocate a static/single CID to the channel x (for when the channel x CID configuration is not in semaphore mode)
    $10 constant HPDMA_SEM_WLIST_CID0           \ [0x10] white-listed CID0 in the CID allocation pool (for when the channel x in semaphore mode)
    $11 constant HPDMA_SEM_WLIST_CID1           \ [0x11] white-listed CID1 in the CID allocation pool (for when the channel x in semaphore mode)
    $12 constant HPDMA_SEM_WLIST_CID2           \ [0x12] white-listed CID2 in the CID allocation pool (for when the channel x in semaphore mode)
    $13 constant HPDMA_SEM_WLIST_CID3           \ [0x13] white-listed CID3 in the CID allocation pool (for when the channel x in semaphore mode)
    $14 constant HPDMA_SEM_WLIST_CID4           \ [0x14] white-listed CID4 in the CID allocation pool (for when the channel x in semaphore mode)
    $15 constant HPDMA_SEM_WLIST_CID5           \ [0x15] white-listed CID5 in the CID allocation pool (for when the channel x in semaphore mode)
    $16 constant HPDMA_SEM_WLIST_CID6           \ [0x16] white-listed CID6 in the CID allocation pool (for when the channel x in semaphore mode)
  [then]


  [ifdef] HPDMA_HPDMA_C9SEMCR_DEF
    \
    \ @brief HPDMA channel 9 semaphore control register
    \ Address offset: 0x4D8
    \ Reset value: 0x00000000
    \
    $00 constant HPDMA_SEM_MUTEX                \ [0x00] mutual exclusion semaphore for the CID allocation of the channel x (in semaphore mode)
    $04 constant HPDMA_SEM_CCID                 \ [0x04 : 3] current CID allocated to the channel x (in semaphore mode)
  [then]


  [ifdef] HPDMA_HPDMA_C9FCR_DEF
    \
    \ @brief HPDMA channel 9 flag clear register
    \ Address offset: 0x4DC
    \ Reset value: 0x00000000
    \
    $08 constant HPDMA_TCF                      \ [0x08] transfer complete flag clear
    $09 constant HPDMA_HTF                      \ [0x09] half transfer flag clear
    $0a constant HPDMA_DTEF                     \ [0x0a] data transfer error flag clear
    $0b constant HPDMA_ULEF                     \ [0x0b] update link transfer error flag clear
    $0c constant HPDMA_USEF                     \ [0x0c] user setting error flag clear
    $0d constant HPDMA_SUSPF                    \ [0x0d] completed suspension flag clear
    $0e constant HPDMA_TOF                      \ [0x0e] trigger overrun flag clear
  [then]


  [ifdef] HPDMA_HPDMA_C9SR_DEF
    \
    \ @brief HPDMA channel 9 status register
    \ Address offset: 0x4E0
    \ Reset value: 0x00000001
    \
    $00 constant HPDMA_IDLEF                    \ [0x00] idle flag
    $08 constant HPDMA_TCF                      \ [0x08] transfer complete flag
    $09 constant HPDMA_HTF                      \ [0x09] half transfer flag
    $0a constant HPDMA_DTEF                     \ [0x0a] data transfer error flag
    $0b constant HPDMA_ULEF                     \ [0x0b] update link transfer error flag
    $0c constant HPDMA_USEF                     \ [0x0c] user setting error flag
    $0d constant HPDMA_SUSPF                    \ [0x0d] completed suspension flag
    $0e constant HPDMA_TOF                      \ [0x0e] trigger overrun flag
    $10 constant HPDMA_FIFOL                    \ [0x10 : 9] monitored FIFO level
  [then]


  [ifdef] HPDMA_HPDMA_C9CR_DEF
    \
    \ @brief HPDMA channel 9 control register
    \ Address offset: 0x4E4
    \ Reset value: 0x00000000
    \
    $00 constant HPDMA_EN                       \ [0x00] enable
    $01 constant HPDMA_RESET                    \ [0x01] reset
    $02 constant HPDMA_SUSP                     \ [0x02] suspend
    $08 constant HPDMA_TCIE                     \ [0x08] transfer complete interrupt enable
    $09 constant HPDMA_HTIE                     \ [0x09] half transfer complete interrupt enable
    $0a constant HPDMA_DTEIE                    \ [0x0a] data transfer error interrupt enable
    $0b constant HPDMA_ULEIE                    \ [0x0b] update link transfer error interrupt enable
    $0c constant HPDMA_USEIE                    \ [0x0c] user setting error interrupt enable
    $0d constant HPDMA_SUSPIE                   \ [0x0d] completed suspension interrupt enable
    $0e constant HPDMA_TOIE                     \ [0x0e] trigger overrun interrupt enable
    $10 constant HPDMA_LSM                      \ [0x10] Link step mode
    $11 constant HPDMA_LAP                      \ [0x11] linked-list allocated port
    $16 constant HPDMA_PRIO                     \ [0x16 : 2] priority level of the channel x HPDMA transfer versus others
  [then]


  [ifdef] HPDMA_HPDMA_C9TR1_DEF
    \
    \ @brief HPDMA channel 9 transfer register 1
    \ Address offset: 0x510
    \ Reset value: 0x00000000
    \
    $00 constant HPDMA_SDW_LOG2                 \ [0x00 : 2] binary logarithm of the source data width of a burst in bytes
    $03 constant HPDMA_SINC                     \ [0x03] source incrementing burst
    $04 constant HPDMA_SBL_1                    \ [0x04 : 6] source burst length minus 1, between 0 and 63
    $0b constant HPDMA_PAM                      \ [0x0b : 2] padding/alignment mode
    $0d constant HPDMA_SBX                      \ [0x0d] source byte exchange within the unaligned half-word of each source word
    $0e constant HPDMA_SAP                      \ [0x0e] source allocated port
    $0f constant HPDMA_SSEC                     \ [0x0f] security attribute of the HPDMA transfer from the source
    $10 constant HPDMA_DDW_LOG2                 \ [0x10 : 2] binary logarithm of the destination data width of a burst, in bytes
    $13 constant HPDMA_DINC                     \ [0x13] destination incrementing burst
    $14 constant HPDMA_DBL_1                    \ [0x14 : 6] destination burst length minus 1, between 0 and 63
    $1a constant HPDMA_DBX                      \ [0x1a] destination byte exchange
    $1b constant HPDMA_DHX                      \ [0x1b] destination half-word exchange
    $1c constant HPDMA_DWX                      \ [0x1c] destination word exchange
    $1e constant HPDMA_DAP                      \ [0x1e] destination allocated port
    $1f constant HPDMA_DSEC                     \ [0x1f] security attribute of the HPDMA transfer to the destination
  [then]


  [ifdef] HPDMA_HPDMA_C9TR2_DEF
    \
    \ @brief HPDMA channel 9 transfer register 2
    \ Address offset: 0x514
    \ Reset value: 0x00000000
    \
    $00 constant HPDMA_REQSEL                   \ [0x00 : 8] hardware request selection
    $09 constant HPDMA_SWREQ                    \ [0x09] software request
    $0a constant HPDMA_DREQ                     \ [0x0a] destination hardware request
    $0b constant HPDMA_BREQ                     \ [0x0b] Block hardware request
    $0c constant HPDMA_PFREQ                    \ [0x0c] Hardware request in peripheral flow control mode
    $0e constant HPDMA_TRIGM                    \ [0x0e : 2] trigger mode
    $10 constant HPDMA_TRIGSEL                  \ [0x10 : 7] trigger event input selection
    $18 constant HPDMA_TRIGPOL                  \ [0x18 : 2] trigger event polarity
    $1e constant HPDMA_TCEM                     \ [0x1e : 2] transfer complete event mode
  [then]


  [ifdef] HPDMA_HPDMA_C9BR1_DEF
    \
    \ @brief HPDMA channel 9 block register 1
    \ Address offset: 0x518
    \ Reset value: 0x00000000
    \
    $00 constant HPDMA_BNDT                     \ [0x00 : 16] block number of data bytes to transfer from the source
  [then]


  [ifdef] HPDMA_HPDMA_C9SAR_DEF
    \
    \ @brief HPDMA channel 9 source address register
    \ Address offset: 0x51C
    \ Reset value: 0x00000000
    \
    $00 constant HPDMA_SA                       \ [0x00 : 32] source address
  [then]


  [ifdef] HPDMA_HPDMA_C9DAR_DEF
    \
    \ @brief HPDMA channel 9 destination address register
    \ Address offset: 0x520
    \ Reset value: 0x00000000
    \
    $00 constant HPDMA_DA                       \ [0x00 : 32] destination address
  [then]


  [ifdef] HPDMA_HPDMA_C9LLR_DEF
    \
    \ @brief HPDMA channel 9 linked-list address register
    \ Address offset: 0x54C
    \ Reset value: 0x00000000
    \
    $02 constant HPDMA_LA                       \ [0x02 : 14] pointer (16-bit low-significant address) to the next linked-list data structure
    $10 constant HPDMA_ULL                      \ [0x10] Update HPDMA_CxLLR register from memory
    $1b constant HPDMA_UDA                      \ [0x1b] Update HPDMA_CxDAR register from memory
    $1c constant HPDMA_USA                      \ [0x1c] update HPDMA_CxSAR from memory
    $1d constant HPDMA_UB1                      \ [0x1d] Update HPDMA_CxBR1 from memory
    $1e constant HPDMA_UT2                      \ [0x1e] Update HPDMA_CxTR2 from memory
    $1f constant HPDMA_UT1                      \ [0x1f] Update HPDMA_CxTR1 from memory
  [then]


  [ifdef] HPDMA_HPDMA_C10LBAR_DEF
    \
    \ @brief HPDMA channel 10 linked-list base address register
    \ Address offset: 0x550
    \ Reset value: 0x00000000
    \
    $10 constant HPDMA_LBA                      \ [0x10 : 16] linked-list base address of HPDMA channel x
  [then]


  [ifdef] HPDMA_HPDMA_C10CIDCFGR_DEF
    \
    \ @brief HPDMA channel 10 CID register
    \ Address offset: 0x554
    \ Reset value: 0x00000000
    \
    $00 constant HPDMA_CFEN                     \ [0x00] CID filtering enable of the channel x
    $01 constant HPDMA_SEM_EN                   \ [0x01] semaphore mode enable (for the CID allocation policy to the channel x)
    $04 constant HPDMA_SCID                     \ [0x04 : 3] allocate a static/single CID to the channel x (for when the channel x CID configuration is not in semaphore mode)
    $10 constant HPDMA_SEM_WLIST_CID0           \ [0x10] white-listed CID0 in the CID allocation pool (for when the channel x in semaphore mode)
    $11 constant HPDMA_SEM_WLIST_CID1           \ [0x11] white-listed CID1 in the CID allocation pool (for when the channel x in semaphore mode)
    $12 constant HPDMA_SEM_WLIST_CID2           \ [0x12] white-listed CID2 in the CID allocation pool (for when the channel x in semaphore mode)
    $13 constant HPDMA_SEM_WLIST_CID3           \ [0x13] white-listed CID3 in the CID allocation pool (for when the channel x in semaphore mode)
    $14 constant HPDMA_SEM_WLIST_CID4           \ [0x14] white-listed CID4 in the CID allocation pool (for when the channel x in semaphore mode)
    $15 constant HPDMA_SEM_WLIST_CID5           \ [0x15] white-listed CID5 in the CID allocation pool (for when the channel x in semaphore mode)
    $16 constant HPDMA_SEM_WLIST_CID6           \ [0x16] white-listed CID6 in the CID allocation pool (for when the channel x in semaphore mode)
  [then]


  [ifdef] HPDMA_HPDMA_C10SEMCR_DEF
    \
    \ @brief HPDMA channel 10 semaphore control register
    \ Address offset: 0x558
    \ Reset value: 0x00000000
    \
    $00 constant HPDMA_SEM_MUTEX                \ [0x00] mutual exclusion semaphore for the CID allocation of the channel x (in semaphore mode)
    $04 constant HPDMA_SEM_CCID                 \ [0x04 : 3] current CID allocated to the channel x (in semaphore mode)
  [then]


  [ifdef] HPDMA_HPDMA_C10FCR_DEF
    \
    \ @brief HPDMA channel 10 flag clear register
    \ Address offset: 0x55C
    \ Reset value: 0x00000000
    \
    $08 constant HPDMA_TCF                      \ [0x08] transfer complete flag clear
    $09 constant HPDMA_HTF                      \ [0x09] half transfer flag clear
    $0a constant HPDMA_DTEF                     \ [0x0a] data transfer error flag clear
    $0b constant HPDMA_ULEF                     \ [0x0b] update link transfer error flag clear
    $0c constant HPDMA_USEF                     \ [0x0c] user setting error flag clear
    $0d constant HPDMA_SUSPF                    \ [0x0d] completed suspension flag clear
    $0e constant HPDMA_TOF                      \ [0x0e] trigger overrun flag clear
  [then]


  [ifdef] HPDMA_HPDMA_C10SR_DEF
    \
    \ @brief HPDMA channel 10 status register
    \ Address offset: 0x560
    \ Reset value: 0x00000001
    \
    $00 constant HPDMA_IDLEF                    \ [0x00] idle flag
    $08 constant HPDMA_TCF                      \ [0x08] transfer complete flag
    $09 constant HPDMA_HTF                      \ [0x09] half transfer flag
    $0a constant HPDMA_DTEF                     \ [0x0a] data transfer error flag
    $0b constant HPDMA_ULEF                     \ [0x0b] update link transfer error flag
    $0c constant HPDMA_USEF                     \ [0x0c] user setting error flag
    $0d constant HPDMA_SUSPF                    \ [0x0d] completed suspension flag
    $0e constant HPDMA_TOF                      \ [0x0e] trigger overrun flag
    $10 constant HPDMA_FIFOL                    \ [0x10 : 9] monitored FIFO level
  [then]


  [ifdef] HPDMA_HPDMA_C10CR_DEF
    \
    \ @brief HPDMA channel 10 control register
    \ Address offset: 0x564
    \ Reset value: 0x00000000
    \
    $00 constant HPDMA_EN                       \ [0x00] enable
    $01 constant HPDMA_RESET                    \ [0x01] reset
    $02 constant HPDMA_SUSP                     \ [0x02] suspend
    $08 constant HPDMA_TCIE                     \ [0x08] transfer complete interrupt enable
    $09 constant HPDMA_HTIE                     \ [0x09] half transfer complete interrupt enable
    $0a constant HPDMA_DTEIE                    \ [0x0a] data transfer error interrupt enable
    $0b constant HPDMA_ULEIE                    \ [0x0b] update link transfer error interrupt enable
    $0c constant HPDMA_USEIE                    \ [0x0c] user setting error interrupt enable
    $0d constant HPDMA_SUSPIE                   \ [0x0d] completed suspension interrupt enable
    $0e constant HPDMA_TOIE                     \ [0x0e] trigger overrun interrupt enable
    $10 constant HPDMA_LSM                      \ [0x10] Link step mode
    $11 constant HPDMA_LAP                      \ [0x11] linked-list allocated port
    $16 constant HPDMA_PRIO                     \ [0x16 : 2] priority level of the channel x HPDMA transfer versus others
  [then]


  [ifdef] HPDMA_HPDMA_C10TR1_DEF
    \
    \ @brief HPDMA channel 10 transfer register 1
    \ Address offset: 0x590
    \ Reset value: 0x00000000
    \
    $00 constant HPDMA_SDW_LOG2                 \ [0x00 : 2] binary logarithm of the source data width of a burst in bytes
    $03 constant HPDMA_SINC                     \ [0x03] source incrementing burst
    $04 constant HPDMA_SBL_1                    \ [0x04 : 6] source burst length minus 1, between 0 and 63
    $0b constant HPDMA_PAM                      \ [0x0b : 2] padding/alignment mode
    $0d constant HPDMA_SBX                      \ [0x0d] source byte exchange within the unaligned half-word of each source word
    $0e constant HPDMA_SAP                      \ [0x0e] source allocated port
    $0f constant HPDMA_SSEC                     \ [0x0f] security attribute of the HPDMA transfer from the source
    $10 constant HPDMA_DDW_LOG2                 \ [0x10 : 2] binary logarithm of the destination data width of a burst, in bytes
    $13 constant HPDMA_DINC                     \ [0x13] destination incrementing burst
    $14 constant HPDMA_DBL_1                    \ [0x14 : 6] destination burst length minus 1, between 0 and 63
    $1a constant HPDMA_DBX                      \ [0x1a] destination byte exchange
    $1b constant HPDMA_DHX                      \ [0x1b] destination half-word exchange
    $1c constant HPDMA_DWX                      \ [0x1c] destination word exchange
    $1e constant HPDMA_DAP                      \ [0x1e] destination allocated port
    $1f constant HPDMA_DSEC                     \ [0x1f] security attribute of the HPDMA transfer to the destination
  [then]


  [ifdef] HPDMA_HPDMA_C10TR2_DEF
    \
    \ @brief HPDMA channel 10 transfer register 2
    \ Address offset: 0x594
    \ Reset value: 0x00000000
    \
    $00 constant HPDMA_REQSEL                   \ [0x00 : 8] hardware request selection
    $09 constant HPDMA_SWREQ                    \ [0x09] software request
    $0a constant HPDMA_DREQ                     \ [0x0a] destination hardware request
    $0b constant HPDMA_BREQ                     \ [0x0b] Block hardware request
    $0c constant HPDMA_PFREQ                    \ [0x0c] Hardware request in peripheral flow control mode
    $0e constant HPDMA_TRIGM                    \ [0x0e : 2] trigger mode
    $10 constant HPDMA_TRIGSEL                  \ [0x10 : 7] trigger event input selection
    $18 constant HPDMA_TRIGPOL                  \ [0x18 : 2] trigger event polarity
    $1e constant HPDMA_TCEM                     \ [0x1e : 2] transfer complete event mode
  [then]


  [ifdef] HPDMA_HPDMA_C10BR1_DEF
    \
    \ @brief HPDMA channel 10 block register 1
    \ Address offset: 0x598
    \ Reset value: 0x00000000
    \
    $00 constant HPDMA_BNDT                     \ [0x00 : 16] block number of data bytes to transfer from the source
  [then]


  [ifdef] HPDMA_HPDMA_C10SAR_DEF
    \
    \ @brief HPDMA channel 10 source address register
    \ Address offset: 0x59C
    \ Reset value: 0x00000000
    \
    $00 constant HPDMA_SA                       \ [0x00 : 32] source address
  [then]


  [ifdef] HPDMA_HPDMA_C10DAR_DEF
    \
    \ @brief HPDMA channel 10 destination address register
    \ Address offset: 0x5A0
    \ Reset value: 0x00000000
    \
    $00 constant HPDMA_DA                       \ [0x00 : 32] destination address
  [then]


  [ifdef] HPDMA_HPDMA_C10LLR_DEF
    \
    \ @brief HPDMA channel 10 linked-list address register
    \ Address offset: 0x5CC
    \ Reset value: 0x00000000
    \
    $02 constant HPDMA_LA                       \ [0x02 : 14] pointer (16-bit low-significant address) to the next linked-list data structure
    $10 constant HPDMA_ULL                      \ [0x10] Update HPDMA_CxLLR register from memory
    $1b constant HPDMA_UDA                      \ [0x1b] Update HPDMA_CxDAR register from memory
    $1c constant HPDMA_USA                      \ [0x1c] update HPDMA_CxSAR from memory
    $1d constant HPDMA_UB1                      \ [0x1d] Update HPDMA_CxBR1 from memory
    $1e constant HPDMA_UT2                      \ [0x1e] Update HPDMA_CxTR2 from memory
    $1f constant HPDMA_UT1                      \ [0x1f] Update HPDMA_CxTR1 from memory
  [then]


  [ifdef] HPDMA_HPDMA_C11LBAR_DEF
    \
    \ @brief HPDMA channel 11 linked-list base address register
    \ Address offset: 0x5D0
    \ Reset value: 0x00000000
    \
    $10 constant HPDMA_LBA                      \ [0x10 : 16] linked-list base address of HPDMA channel x
  [then]


  [ifdef] HPDMA_HPDMA_C11CIDCFGR_DEF
    \
    \ @brief HPDMA channel 11 CID register
    \ Address offset: 0x5D4
    \ Reset value: 0x00000000
    \
    $00 constant HPDMA_CFEN                     \ [0x00] CID filtering enable of the channel x
    $01 constant HPDMA_SEM_EN                   \ [0x01] semaphore mode enable (for the CID allocation policy to the channel x)
    $04 constant HPDMA_SCID                     \ [0x04 : 3] allocate a static/single CID to the channel x (for when the channel x CID configuration is not in semaphore mode)
    $10 constant HPDMA_SEM_WLIST_CID0           \ [0x10] white-listed CID0 in the CID allocation pool (for when the channel x in semaphore mode)
    $11 constant HPDMA_SEM_WLIST_CID1           \ [0x11] white-listed CID1 in the CID allocation pool (for when the channel x in semaphore mode)
    $12 constant HPDMA_SEM_WLIST_CID2           \ [0x12] white-listed CID2 in the CID allocation pool (for when the channel x in semaphore mode)
    $13 constant HPDMA_SEM_WLIST_CID3           \ [0x13] white-listed CID3 in the CID allocation pool (for when the channel x in semaphore mode)
    $14 constant HPDMA_SEM_WLIST_CID4           \ [0x14] white-listed CID4 in the CID allocation pool (for when the channel x in semaphore mode)
    $15 constant HPDMA_SEM_WLIST_CID5           \ [0x15] white-listed CID5 in the CID allocation pool (for when the channel x in semaphore mode)
    $16 constant HPDMA_SEM_WLIST_CID6           \ [0x16] white-listed CID6 in the CID allocation pool (for when the channel x in semaphore mode)
  [then]


  [ifdef] HPDMA_HPDMA_C11SEMCR_DEF
    \
    \ @brief HPDMA channel 11 semaphore control register
    \ Address offset: 0x5D8
    \ Reset value: 0x00000000
    \
    $00 constant HPDMA_SEM_MUTEX                \ [0x00] mutual exclusion semaphore for the CID allocation of the channel x (in semaphore mode)
    $04 constant HPDMA_SEM_CCID                 \ [0x04 : 3] current CID allocated to the channel x (in semaphore mode)
  [then]


  [ifdef] HPDMA_HPDMA_C11FCR_DEF
    \
    \ @brief HPDMA channel 11 flag clear register
    \ Address offset: 0x5DC
    \ Reset value: 0x00000000
    \
    $08 constant HPDMA_TCF                      \ [0x08] transfer complete flag clear
    $09 constant HPDMA_HTF                      \ [0x09] half transfer flag clear
    $0a constant HPDMA_DTEF                     \ [0x0a] data transfer error flag clear
    $0b constant HPDMA_ULEF                     \ [0x0b] update link transfer error flag clear
    $0c constant HPDMA_USEF                     \ [0x0c] user setting error flag clear
    $0d constant HPDMA_SUSPF                    \ [0x0d] completed suspension flag clear
    $0e constant HPDMA_TOF                      \ [0x0e] trigger overrun flag clear
  [then]


  [ifdef] HPDMA_HPDMA_C11SR_DEF
    \
    \ @brief HPDMA channel 11 status register
    \ Address offset: 0x5E0
    \ Reset value: 0x00000001
    \
    $00 constant HPDMA_IDLEF                    \ [0x00] idle flag
    $08 constant HPDMA_TCF                      \ [0x08] transfer complete flag
    $09 constant HPDMA_HTF                      \ [0x09] half transfer flag
    $0a constant HPDMA_DTEF                     \ [0x0a] data transfer error flag
    $0b constant HPDMA_ULEF                     \ [0x0b] update link transfer error flag
    $0c constant HPDMA_USEF                     \ [0x0c] user setting error flag
    $0d constant HPDMA_SUSPF                    \ [0x0d] completed suspension flag
    $0e constant HPDMA_TOF                      \ [0x0e] trigger overrun flag
    $10 constant HPDMA_FIFOL                    \ [0x10 : 9] monitored FIFO level
  [then]


  [ifdef] HPDMA_HPDMA_C11CR_DEF
    \
    \ @brief HPDMA channel 11 control register
    \ Address offset: 0x5E4
    \ Reset value: 0x00000000
    \
    $00 constant HPDMA_EN                       \ [0x00] enable
    $01 constant HPDMA_RESET                    \ [0x01] reset
    $02 constant HPDMA_SUSP                     \ [0x02] suspend
    $08 constant HPDMA_TCIE                     \ [0x08] transfer complete interrupt enable
    $09 constant HPDMA_HTIE                     \ [0x09] half transfer complete interrupt enable
    $0a constant HPDMA_DTEIE                    \ [0x0a] data transfer error interrupt enable
    $0b constant HPDMA_ULEIE                    \ [0x0b] update link transfer error interrupt enable
    $0c constant HPDMA_USEIE                    \ [0x0c] user setting error interrupt enable
    $0d constant HPDMA_SUSPIE                   \ [0x0d] completed suspension interrupt enable
    $0e constant HPDMA_TOIE                     \ [0x0e] trigger overrun interrupt enable
    $10 constant HPDMA_LSM                      \ [0x10] Link step mode
    $11 constant HPDMA_LAP                      \ [0x11] linked-list allocated port
    $16 constant HPDMA_PRIO                     \ [0x16 : 2] priority level of the channel x HPDMA transfer versus others
  [then]


  [ifdef] HPDMA_HPDMA_C11TR1_DEF
    \
    \ @brief HPDMA channel 11 transfer register 1
    \ Address offset: 0x610
    \ Reset value: 0x00000000
    \
    $00 constant HPDMA_SDW_LOG2                 \ [0x00 : 2] binary logarithm of the source data width of a burst in bytes
    $03 constant HPDMA_SINC                     \ [0x03] source incrementing burst
    $04 constant HPDMA_SBL_1                    \ [0x04 : 6] source burst length minus 1, between 0 and 63
    $0b constant HPDMA_PAM                      \ [0x0b : 2] padding/alignment mode
    $0d constant HPDMA_SBX                      \ [0x0d] source byte exchange within the unaligned half-word of each source word
    $0e constant HPDMA_SAP                      \ [0x0e] source allocated port
    $0f constant HPDMA_SSEC                     \ [0x0f] security attribute of the HPDMA transfer from the source
    $10 constant HPDMA_DDW_LOG2                 \ [0x10 : 2] binary logarithm of the destination data width of a burst, in bytes
    $13 constant HPDMA_DINC                     \ [0x13] destination incrementing burst
    $14 constant HPDMA_DBL_1                    \ [0x14 : 6] destination burst length minus 1, between 0 and 63
    $1a constant HPDMA_DBX                      \ [0x1a] destination byte exchange
    $1b constant HPDMA_DHX                      \ [0x1b] destination half-word exchange
    $1c constant HPDMA_DWX                      \ [0x1c] destination word exchange
    $1e constant HPDMA_DAP                      \ [0x1e] destination allocated port
    $1f constant HPDMA_DSEC                     \ [0x1f] security attribute of the HPDMA transfer to the destination
  [then]


  [ifdef] HPDMA_HPDMA_C11TR2_DEF
    \
    \ @brief HPDMA channel 11 transfer register 2
    \ Address offset: 0x614
    \ Reset value: 0x00000000
    \
    $00 constant HPDMA_REQSEL                   \ [0x00 : 8] hardware request selection
    $09 constant HPDMA_SWREQ                    \ [0x09] software request
    $0a constant HPDMA_DREQ                     \ [0x0a] destination hardware request
    $0b constant HPDMA_BREQ                     \ [0x0b] Block hardware request
    $0c constant HPDMA_PFREQ                    \ [0x0c] Hardware request in peripheral flow control mode
    $0e constant HPDMA_TRIGM                    \ [0x0e : 2] trigger mode
    $10 constant HPDMA_TRIGSEL                  \ [0x10 : 7] trigger event input selection
    $18 constant HPDMA_TRIGPOL                  \ [0x18 : 2] trigger event polarity
    $1e constant HPDMA_TCEM                     \ [0x1e : 2] transfer complete event mode
  [then]


  [ifdef] HPDMA_HPDMA_C11BR1_DEF
    \
    \ @brief HPDMA channel 11 block register 1
    \ Address offset: 0x618
    \ Reset value: 0x00000000
    \
    $00 constant HPDMA_BNDT                     \ [0x00 : 16] block number of data bytes to transfer from the source
  [then]


  [ifdef] HPDMA_HPDMA_C11SAR_DEF
    \
    \ @brief HPDMA channel 11 source address register
    \ Address offset: 0x61C
    \ Reset value: 0x00000000
    \
    $00 constant HPDMA_SA                       \ [0x00 : 32] source address
  [then]


  [ifdef] HPDMA_HPDMA_C11DAR_DEF
    \
    \ @brief HPDMA channel 11 destination address register
    \ Address offset: 0x620
    \ Reset value: 0x00000000
    \
    $00 constant HPDMA_DA                       \ [0x00 : 32] destination address
  [then]


  [ifdef] HPDMA_HPDMA_C11LLR_DEF
    \
    \ @brief HPDMA channel 11 linked-list address register
    \ Address offset: 0x64C
    \ Reset value: 0x00000000
    \
    $02 constant HPDMA_LA                       \ [0x02 : 14] pointer (16-bit low-significant address) to the next linked-list data structure
    $10 constant HPDMA_ULL                      \ [0x10] Update HPDMA_CxLLR register from memory
    $1b constant HPDMA_UDA                      \ [0x1b] Update HPDMA_CxDAR register from memory
    $1c constant HPDMA_USA                      \ [0x1c] update HPDMA_CxSAR from memory
    $1d constant HPDMA_UB1                      \ [0x1d] Update HPDMA_CxBR1 from memory
    $1e constant HPDMA_UT2                      \ [0x1e] Update HPDMA_CxTR2 from memory
    $1f constant HPDMA_UT1                      \ [0x1f] Update HPDMA_CxTR1 from memory
  [then]


  [ifdef] HPDMA_HPDMA_C12LBAR_DEF
    \
    \ @brief HPDMA channel 12 linked-list base address register
    \ Address offset: 0x650
    \ Reset value: 0x00000000
    \
    $10 constant HPDMA_LBA                      \ [0x10 : 16] linked-list base address of HPDMA channel x
  [then]


  [ifdef] HPDMA_HPDMA_C12CIDCFGR_DEF
    \
    \ @brief HPDMA channel 12 CID register
    \ Address offset: 0x654
    \ Reset value: 0x00000000
    \
    $00 constant HPDMA_CFEN                     \ [0x00] CID filtering enable of the channel x
    $01 constant HPDMA_SEM_EN                   \ [0x01] semaphore mode enable (for the CID allocation policy to the channel x)
    $04 constant HPDMA_SCID                     \ [0x04 : 3] allocate a static/single CID to the channel x (for when the channel x CID configuration is not in semaphore mode)
    $10 constant HPDMA_SEM_WLIST_CID0           \ [0x10] white-listed CID0 in the CID allocation pool (for when the channel x in semaphore mode)
    $11 constant HPDMA_SEM_WLIST_CID1           \ [0x11] white-listed CID1 in the CID allocation pool (for when the channel x in semaphore mode)
    $12 constant HPDMA_SEM_WLIST_CID2           \ [0x12] white-listed CID2 in the CID allocation pool (for when the channel x in semaphore mode)
    $13 constant HPDMA_SEM_WLIST_CID3           \ [0x13] white-listed CID3 in the CID allocation pool (for when the channel x in semaphore mode)
    $14 constant HPDMA_SEM_WLIST_CID4           \ [0x14] white-listed CID4 in the CID allocation pool (for when the channel x in semaphore mode)
    $15 constant HPDMA_SEM_WLIST_CID5           \ [0x15] white-listed CID5 in the CID allocation pool (for when the channel x in semaphore mode)
    $16 constant HPDMA_SEM_WLIST_CID6           \ [0x16] white-listed CID6 in the CID allocation pool (for when the channel x in semaphore mode)
  [then]


  [ifdef] HPDMA_HPDMA_C12SEMCR_DEF
    \
    \ @brief HPDMA channel 12 semaphore control register
    \ Address offset: 0x658
    \ Reset value: 0x00000000
    \
    $00 constant HPDMA_SEM_MUTEX                \ [0x00] mutual exclusion semaphore for the CID allocation of the channel x (in semaphore mode)
    $04 constant HPDMA_SEM_CCID                 \ [0x04 : 3] current CID allocated to the channel x (in semaphore mode)
  [then]


  [ifdef] HPDMA_HPDMA_C12FCR_DEF
    \
    \ @brief HPDMA channel 12 flag clear register
    \ Address offset: 0x65C
    \ Reset value: 0x00000000
    \
    $08 constant HPDMA_TCF                      \ [0x08] transfer complete flag clear
    $09 constant HPDMA_HTF                      \ [0x09] half transfer flag clear
    $0a constant HPDMA_DTEF                     \ [0x0a] data transfer error flag clear
    $0b constant HPDMA_ULEF                     \ [0x0b] update link transfer error flag clear
    $0c constant HPDMA_USEF                     \ [0x0c] user setting error flag clear
    $0d constant HPDMA_SUSPF                    \ [0x0d] completed suspension flag clear
    $0e constant HPDMA_TOF                      \ [0x0e] trigger overrun flag clear
  [then]


  [ifdef] HPDMA_HPDMA_C12SR_DEF
    \
    \ @brief HPDMA channel 12 status register
    \ Address offset: 0x660
    \ Reset value: 0x00000001
    \
    $00 constant HPDMA_IDLEF                    \ [0x00] idle flag
    $08 constant HPDMA_TCF                      \ [0x08] transfer complete flag
    $09 constant HPDMA_HTF                      \ [0x09] half transfer flag
    $0a constant HPDMA_DTEF                     \ [0x0a] data transfer error flag
    $0b constant HPDMA_ULEF                     \ [0x0b] update link transfer error flag
    $0c constant HPDMA_USEF                     \ [0x0c] user setting error flag
    $0d constant HPDMA_SUSPF                    \ [0x0d] completed suspension flag
    $0e constant HPDMA_TOF                      \ [0x0e] trigger overrun flag
    $10 constant HPDMA_FIFOL                    \ [0x10 : 9] monitored FIFO level
  [then]


  [ifdef] HPDMA_HPDMA_C12CR_DEF
    \
    \ @brief HPDMA channel 12 control register
    \ Address offset: 0x664
    \ Reset value: 0x00000000
    \
    $00 constant HPDMA_EN                       \ [0x00] enable
    $01 constant HPDMA_RESET                    \ [0x01] reset
    $02 constant HPDMA_SUSP                     \ [0x02] suspend
    $08 constant HPDMA_TCIE                     \ [0x08] transfer complete interrupt enable
    $09 constant HPDMA_HTIE                     \ [0x09] half transfer complete interrupt enable
    $0a constant HPDMA_DTEIE                    \ [0x0a] data transfer error interrupt enable
    $0b constant HPDMA_ULEIE                    \ [0x0b] update link transfer error interrupt enable
    $0c constant HPDMA_USEIE                    \ [0x0c] user setting error interrupt enable
    $0d constant HPDMA_SUSPIE                   \ [0x0d] completed suspension interrupt enable
    $0e constant HPDMA_TOIE                     \ [0x0e] trigger overrun interrupt enable
    $10 constant HPDMA_LSM                      \ [0x10] Link step mode
    $11 constant HPDMA_LAP                      \ [0x11] linked-list allocated port
    $16 constant HPDMA_PRIO                     \ [0x16 : 2] priority level of the channel x HPDMA transfer versus others
  [then]


  [ifdef] HPDMA_HPDMA_C12TR1_DEF
    \
    \ @brief HPDMA channel 12 transfer register 1
    \ Address offset: 0x690
    \ Reset value: 0x00000000
    \
    $00 constant HPDMA_SDW_LOG2                 \ [0x00 : 2] binary logarithm of the source data width of a burst in bytes
    $03 constant HPDMA_SINC                     \ [0x03] source incrementing burst
    $04 constant HPDMA_SBL_1                    \ [0x04 : 6] source burst length minus 1, between 0 and 63
    $0b constant HPDMA_PAM                      \ [0x0b : 2] padding/alignment mode
    $0d constant HPDMA_SBX                      \ [0x0d] source byte exchange within the unaligned half-word of each source word
    $0e constant HPDMA_SAP                      \ [0x0e] source allocated port
    $0f constant HPDMA_SSEC                     \ [0x0f] security attribute of the HPDMA transfer from the source
    $10 constant HPDMA_DDW_LOG2                 \ [0x10 : 2] binary logarithm of the destination data width of a burst, in bytes
    $13 constant HPDMA_DINC                     \ [0x13] destination incrementing burst
    $14 constant HPDMA_DBL_1                    \ [0x14 : 6] destination burst length minus 1, between 0 and 63
    $1a constant HPDMA_DBX                      \ [0x1a] destination byte exchange
    $1b constant HPDMA_DHX                      \ [0x1b] destination half-word exchange
    $1c constant HPDMA_DWX                      \ [0x1c] destination word exchange
    $1e constant HPDMA_DAP                      \ [0x1e] destination allocated port
    $1f constant HPDMA_DSEC                     \ [0x1f] security attribute of the HPDMA transfer to the destination
  [then]


  [ifdef] HPDMA_HPDMA_C12TR2_DEF
    \
    \ @brief HPDMA channel 12 transfer register 2
    \ Address offset: 0x694
    \ Reset value: 0x00000000
    \
    $00 constant HPDMA_REQSEL                   \ [0x00 : 8] hardware request selection
    $09 constant HPDMA_SWREQ                    \ [0x09] software request
    $0a constant HPDMA_DREQ                     \ [0x0a] destination hardware request
    $0b constant HPDMA_BREQ                     \ [0x0b] Block hardware request
    $0c constant HPDMA_PFREQ                    \ [0x0c] Hardware request in peripheral flow control mode
    $0e constant HPDMA_TRIGM                    \ [0x0e : 2] trigger mode
    $10 constant HPDMA_TRIGSEL                  \ [0x10 : 7] trigger event input selection
    $18 constant HPDMA_TRIGPOL                  \ [0x18 : 2] trigger event polarity
    $1e constant HPDMA_TCEM                     \ [0x1e : 2] transfer complete event mode
  [then]


  [ifdef] HPDMA_HPDMA_C12BR1_DEF
    \
    \ @brief HPDMA channel 12 alternate block register 1
    \ Address offset: 0x698
    \ Reset value: 0x00000000
    \
    $00 constant HPDMA_BNDT                     \ [0x00 : 16] block number of data bytes to transfer from the source
    $10 constant HPDMA_BRC                      \ [0x10 : 11] Block repeat counter
    $1c constant HPDMA_SDEC                     \ [0x1c] source address decrement
    $1d constant HPDMA_DDEC                     \ [0x1d] destination address decrement
    $1e constant HPDMA_BRSDEC                   \ [0x1e] Block repeat source address decrement
    $1f constant HPDMA_BRDDEC                   \ [0x1f] Block repeat destination address decrement
  [then]


  [ifdef] HPDMA_HPDMA_C12SAR_DEF
    \
    \ @brief HPDMA channel 12 source address register
    \ Address offset: 0x69C
    \ Reset value: 0x00000000
    \
    $00 constant HPDMA_SA                       \ [0x00 : 32] source address
  [then]


  [ifdef] HPDMA_HPDMA_C12DAR_DEF
    \
    \ @brief HPDMA channel 12 destination address register
    \ Address offset: 0x6A0
    \ Reset value: 0x00000000
    \
    $00 constant HPDMA_DA                       \ [0x00 : 32] destination address
  [then]


  [ifdef] HPDMA_HPDMA_C12TR3_DEF
    \
    \ @brief HPDMA channel 12 transfer register 3
    \ Address offset: 0x6A4
    \ Reset value: 0x00000000
    \
    $00 constant HPDMA_SAO                      \ [0x00 : 13] source address offset increment
    $10 constant HPDMA_DAO                      \ [0x10 : 13] destination address offset increment
  [then]


  [ifdef] HPDMA_HPDMA_C12BR2_DEF
    \
    \ @brief HPDMA channel 12 block register 2
    \ Address offset: 0x6A8
    \ Reset value: 0x00000000
    \
    $00 constant HPDMA_BRSAO                    \ [0x00 : 16] Block repeated source address offset
    $10 constant HPDMA_BRDAO                    \ [0x10 : 16] Block repeated destination address offset
  [then]


  [ifdef] HPDMA_HPDMA_C12LLR_DEF
    \
    \ @brief HPDMA channel 12 alternate linked-list address register
    \ Address offset: 0x6CC
    \ Reset value: 0x00000000
    \
    $02 constant HPDMA_LA                       \ [0x02 : 14] pointer (16-bit low-significant address) to the next linked-list data structure
    $10 constant HPDMA_ULL                      \ [0x10] Update HPDMA_CxLLR register from memory
    $19 constant HPDMA_UB2                      \ [0x19] Update HPDMA_CxBR2 from memory
    $1a constant HPDMA_UT3                      \ [0x1a] Update HPDMA_CxTR3 from memory
    $1b constant HPDMA_UDA                      \ [0x1b] Update HPDMA_CxDAR register from memory
    $1c constant HPDMA_USA                      \ [0x1c] update HPDMA_CxSAR from memory
    $1d constant HPDMA_UB1                      \ [0x1d] Update HPDMA_CxBR1 from memory
    $1e constant HPDMA_UT2                      \ [0x1e] Update HPDMA_CxTR2 from memory
    $1f constant HPDMA_UT1                      \ [0x1f] Update HPDMA_CxTR1 from memory
  [then]


  [ifdef] HPDMA_HPDMA_C13LBAR_DEF
    \
    \ @brief HPDMA channel 13 linked-list base address register
    \ Address offset: 0x6D0
    \ Reset value: 0x00000000
    \
    $10 constant HPDMA_LBA                      \ [0x10 : 16] linked-list base address of HPDMA channel x
  [then]


  [ifdef] HPDMA_HPDMA_C13CIDCFGR_DEF
    \
    \ @brief HPDMA channel 13 CID register
    \ Address offset: 0x6D4
    \ Reset value: 0x00000000
    \
    $00 constant HPDMA_CFEN                     \ [0x00] CID filtering enable of the channel x
    $01 constant HPDMA_SEM_EN                   \ [0x01] semaphore mode enable (for the CID allocation policy to the channel x)
    $04 constant HPDMA_SCID                     \ [0x04 : 3] allocate a static/single CID to the channel x (for when the channel x CID configuration is not in semaphore mode)
    $10 constant HPDMA_SEM_WLIST_CID0           \ [0x10] white-listed CID0 in the CID allocation pool (for when the channel x in semaphore mode)
    $11 constant HPDMA_SEM_WLIST_CID1           \ [0x11] white-listed CID1 in the CID allocation pool (for when the channel x in semaphore mode)
    $12 constant HPDMA_SEM_WLIST_CID2           \ [0x12] white-listed CID2 in the CID allocation pool (for when the channel x in semaphore mode)
    $13 constant HPDMA_SEM_WLIST_CID3           \ [0x13] white-listed CID3 in the CID allocation pool (for when the channel x in semaphore mode)
    $14 constant HPDMA_SEM_WLIST_CID4           \ [0x14] white-listed CID4 in the CID allocation pool (for when the channel x in semaphore mode)
    $15 constant HPDMA_SEM_WLIST_CID5           \ [0x15] white-listed CID5 in the CID allocation pool (for when the channel x in semaphore mode)
    $16 constant HPDMA_SEM_WLIST_CID6           \ [0x16] white-listed CID6 in the CID allocation pool (for when the channel x in semaphore mode)
  [then]


  [ifdef] HPDMA_HPDMA_C13SEMCR_DEF
    \
    \ @brief HPDMA channel 13 semaphore control register
    \ Address offset: 0x6D8
    \ Reset value: 0x00000000
    \
    $00 constant HPDMA_SEM_MUTEX                \ [0x00] mutual exclusion semaphore for the CID allocation of the channel x (in semaphore mode)
    $04 constant HPDMA_SEM_CCID                 \ [0x04 : 3] current CID allocated to the channel x (in semaphore mode)
  [then]


  [ifdef] HPDMA_HPDMA_C13FCR_DEF
    \
    \ @brief HPDMA channel 13 flag clear register
    \ Address offset: 0x6DC
    \ Reset value: 0x00000000
    \
    $08 constant HPDMA_TCF                      \ [0x08] transfer complete flag clear
    $09 constant HPDMA_HTF                      \ [0x09] half transfer flag clear
    $0a constant HPDMA_DTEF                     \ [0x0a] data transfer error flag clear
    $0b constant HPDMA_ULEF                     \ [0x0b] update link transfer error flag clear
    $0c constant HPDMA_USEF                     \ [0x0c] user setting error flag clear
    $0d constant HPDMA_SUSPF                    \ [0x0d] completed suspension flag clear
    $0e constant HPDMA_TOF                      \ [0x0e] trigger overrun flag clear
  [then]


  [ifdef] HPDMA_HPDMA_C13SR_DEF
    \
    \ @brief HPDMA channel 13 status register
    \ Address offset: 0x6E0
    \ Reset value: 0x00000001
    \
    $00 constant HPDMA_IDLEF                    \ [0x00] idle flag
    $08 constant HPDMA_TCF                      \ [0x08] transfer complete flag
    $09 constant HPDMA_HTF                      \ [0x09] half transfer flag
    $0a constant HPDMA_DTEF                     \ [0x0a] data transfer error flag
    $0b constant HPDMA_ULEF                     \ [0x0b] update link transfer error flag
    $0c constant HPDMA_USEF                     \ [0x0c] user setting error flag
    $0d constant HPDMA_SUSPF                    \ [0x0d] completed suspension flag
    $0e constant HPDMA_TOF                      \ [0x0e] trigger overrun flag
    $10 constant HPDMA_FIFOL                    \ [0x10 : 9] monitored FIFO level
  [then]


  [ifdef] HPDMA_HPDMA_C13CR_DEF
    \
    \ @brief HPDMA channel 13 control register
    \ Address offset: 0x6E4
    \ Reset value: 0x00000000
    \
    $00 constant HPDMA_EN                       \ [0x00] enable
    $01 constant HPDMA_RESET                    \ [0x01] reset
    $02 constant HPDMA_SUSP                     \ [0x02] suspend
    $08 constant HPDMA_TCIE                     \ [0x08] transfer complete interrupt enable
    $09 constant HPDMA_HTIE                     \ [0x09] half transfer complete interrupt enable
    $0a constant HPDMA_DTEIE                    \ [0x0a] data transfer error interrupt enable
    $0b constant HPDMA_ULEIE                    \ [0x0b] update link transfer error interrupt enable
    $0c constant HPDMA_USEIE                    \ [0x0c] user setting error interrupt enable
    $0d constant HPDMA_SUSPIE                   \ [0x0d] completed suspension interrupt enable
    $0e constant HPDMA_TOIE                     \ [0x0e] trigger overrun interrupt enable
    $10 constant HPDMA_LSM                      \ [0x10] Link step mode
    $11 constant HPDMA_LAP                      \ [0x11] linked-list allocated port
    $16 constant HPDMA_PRIO                     \ [0x16 : 2] priority level of the channel x HPDMA transfer versus others
  [then]


  [ifdef] HPDMA_HPDMA_C13TR1_DEF
    \
    \ @brief HPDMA channel 13 transfer register 1
    \ Address offset: 0x710
    \ Reset value: 0x00000000
    \
    $00 constant HPDMA_SDW_LOG2                 \ [0x00 : 2] binary logarithm of the source data width of a burst in bytes
    $03 constant HPDMA_SINC                     \ [0x03] source incrementing burst
    $04 constant HPDMA_SBL_1                    \ [0x04 : 6] source burst length minus 1, between 0 and 63
    $0b constant HPDMA_PAM                      \ [0x0b : 2] padding/alignment mode
    $0d constant HPDMA_SBX                      \ [0x0d] source byte exchange within the unaligned half-word of each source word
    $0e constant HPDMA_SAP                      \ [0x0e] source allocated port
    $0f constant HPDMA_SSEC                     \ [0x0f] security attribute of the HPDMA transfer from the source
    $10 constant HPDMA_DDW_LOG2                 \ [0x10 : 2] binary logarithm of the destination data width of a burst, in bytes
    $13 constant HPDMA_DINC                     \ [0x13] destination incrementing burst
    $14 constant HPDMA_DBL_1                    \ [0x14 : 6] destination burst length minus 1, between 0 and 63
    $1a constant HPDMA_DBX                      \ [0x1a] destination byte exchange
    $1b constant HPDMA_DHX                      \ [0x1b] destination half-word exchange
    $1c constant HPDMA_DWX                      \ [0x1c] destination word exchange
    $1e constant HPDMA_DAP                      \ [0x1e] destination allocated port
    $1f constant HPDMA_DSEC                     \ [0x1f] security attribute of the HPDMA transfer to the destination
  [then]


  [ifdef] HPDMA_HPDMA_C13TR2_DEF
    \
    \ @brief HPDMA channel 13 transfer register 2
    \ Address offset: 0x714
    \ Reset value: 0x00000000
    \
    $00 constant HPDMA_REQSEL                   \ [0x00 : 8] hardware request selection
    $09 constant HPDMA_SWREQ                    \ [0x09] software request
    $0a constant HPDMA_DREQ                     \ [0x0a] destination hardware request
    $0b constant HPDMA_BREQ                     \ [0x0b] Block hardware request
    $0c constant HPDMA_PFREQ                    \ [0x0c] Hardware request in peripheral flow control mode
    $0e constant HPDMA_TRIGM                    \ [0x0e : 2] trigger mode
    $10 constant HPDMA_TRIGSEL                  \ [0x10 : 7] trigger event input selection
    $18 constant HPDMA_TRIGPOL                  \ [0x18 : 2] trigger event polarity
    $1e constant HPDMA_TCEM                     \ [0x1e : 2] transfer complete event mode
  [then]


  [ifdef] HPDMA_HPDMA_C13BR1_DEF
    \
    \ @brief HPDMA channel 13 alternate block register 1
    \ Address offset: 0x718
    \ Reset value: 0x00000000
    \
    $00 constant HPDMA_BNDT                     \ [0x00 : 16] block number of data bytes to transfer from the source
    $10 constant HPDMA_BRC                      \ [0x10 : 11] Block repeat counter
    $1c constant HPDMA_SDEC                     \ [0x1c] source address decrement
    $1d constant HPDMA_DDEC                     \ [0x1d] destination address decrement
    $1e constant HPDMA_BRSDEC                   \ [0x1e] Block repeat source address decrement
    $1f constant HPDMA_BRDDEC                   \ [0x1f] Block repeat destination address decrement
  [then]


  [ifdef] HPDMA_HPDMA_C13SAR_DEF
    \
    \ @brief HPDMA channel 13 source address register
    \ Address offset: 0x71C
    \ Reset value: 0x00000000
    \
    $00 constant HPDMA_SA                       \ [0x00 : 32] source address
  [then]


  [ifdef] HPDMA_HPDMA_C13DAR_DEF
    \
    \ @brief HPDMA channel 13 destination address register
    \ Address offset: 0x720
    \ Reset value: 0x00000000
    \
    $00 constant HPDMA_DA                       \ [0x00 : 32] destination address
  [then]


  [ifdef] HPDMA_HPDMA_C13TR3_DEF
    \
    \ @brief HPDMA channel 13 transfer register 3
    \ Address offset: 0x724
    \ Reset value: 0x00000000
    \
    $00 constant HPDMA_SAO                      \ [0x00 : 13] source address offset increment
    $10 constant HPDMA_DAO                      \ [0x10 : 13] destination address offset increment
  [then]


  [ifdef] HPDMA_HPDMA_C13BR2_DEF
    \
    \ @brief HPDMA channel 13 block register 2
    \ Address offset: 0x728
    \ Reset value: 0x00000000
    \
    $00 constant HPDMA_BRSAO                    \ [0x00 : 16] Block repeated source address offset
    $10 constant HPDMA_BRDAO                    \ [0x10 : 16] Block repeated destination address offset
  [then]


  [ifdef] HPDMA_HPDMA_C13LLR_DEF
    \
    \ @brief HPDMA channel 13 alternate linked-list address register
    \ Address offset: 0x74C
    \ Reset value: 0x00000000
    \
    $02 constant HPDMA_LA                       \ [0x02 : 14] pointer (16-bit low-significant address) to the next linked-list data structure
    $10 constant HPDMA_ULL                      \ [0x10] Update HPDMA_CxLLR register from memory
    $19 constant HPDMA_UB2                      \ [0x19] Update HPDMA_CxBR2 from memory
    $1a constant HPDMA_UT3                      \ [0x1a] Update HPDMA_CxTR3 from memory
    $1b constant HPDMA_UDA                      \ [0x1b] Update HPDMA_CxDAR register from memory
    $1c constant HPDMA_USA                      \ [0x1c] update HPDMA_CxSAR from memory
    $1d constant HPDMA_UB1                      \ [0x1d] Update HPDMA_CxBR1 from memory
    $1e constant HPDMA_UT2                      \ [0x1e] Update HPDMA_CxTR2 from memory
    $1f constant HPDMA_UT1                      \ [0x1f] Update HPDMA_CxTR1 from memory
  [then]


  [ifdef] HPDMA_HPDMA_C14LBAR_DEF
    \
    \ @brief HPDMA channel 14 linked-list base address register
    \ Address offset: 0x750
    \ Reset value: 0x00000000
    \
    $10 constant HPDMA_LBA                      \ [0x10 : 16] linked-list base address of HPDMA channel x
  [then]


  [ifdef] HPDMA_HPDMA_C14CIDCFGR_DEF
    \
    \ @brief HPDMA channel 14 CID register
    \ Address offset: 0x754
    \ Reset value: 0x00000000
    \
    $00 constant HPDMA_CFEN                     \ [0x00] CID filtering enable of the channel x
    $01 constant HPDMA_SEM_EN                   \ [0x01] semaphore mode enable (for the CID allocation policy to the channel x)
    $04 constant HPDMA_SCID                     \ [0x04 : 3] allocate a static/single CID to the channel x (for when the channel x CID configuration is not in semaphore mode)
    $10 constant HPDMA_SEM_WLIST_CID0           \ [0x10] white-listed CID0 in the CID allocation pool (for when the channel x in semaphore mode)
    $11 constant HPDMA_SEM_WLIST_CID1           \ [0x11] white-listed CID1 in the CID allocation pool (for when the channel x in semaphore mode)
    $12 constant HPDMA_SEM_WLIST_CID2           \ [0x12] white-listed CID2 in the CID allocation pool (for when the channel x in semaphore mode)
    $13 constant HPDMA_SEM_WLIST_CID3           \ [0x13] white-listed CID3 in the CID allocation pool (for when the channel x in semaphore mode)
    $14 constant HPDMA_SEM_WLIST_CID4           \ [0x14] white-listed CID4 in the CID allocation pool (for when the channel x in semaphore mode)
    $15 constant HPDMA_SEM_WLIST_CID5           \ [0x15] white-listed CID5 in the CID allocation pool (for when the channel x in semaphore mode)
    $16 constant HPDMA_SEM_WLIST_CID6           \ [0x16] white-listed CID6 in the CID allocation pool (for when the channel x in semaphore mode)
  [then]


  [ifdef] HPDMA_HPDMA_C14SEMCR_DEF
    \
    \ @brief HPDMA channel 14 semaphore control register
    \ Address offset: 0x758
    \ Reset value: 0x00000000
    \
    $00 constant HPDMA_SEM_MUTEX                \ [0x00] mutual exclusion semaphore for the CID allocation of the channel x (in semaphore mode)
    $04 constant HPDMA_SEM_CCID                 \ [0x04 : 3] current CID allocated to the channel x (in semaphore mode)
  [then]


  [ifdef] HPDMA_HPDMA_C14FCR_DEF
    \
    \ @brief HPDMA channel 14 flag clear register
    \ Address offset: 0x75C
    \ Reset value: 0x00000000
    \
    $08 constant HPDMA_TCF                      \ [0x08] transfer complete flag clear
    $09 constant HPDMA_HTF                      \ [0x09] half transfer flag clear
    $0a constant HPDMA_DTEF                     \ [0x0a] data transfer error flag clear
    $0b constant HPDMA_ULEF                     \ [0x0b] update link transfer error flag clear
    $0c constant HPDMA_USEF                     \ [0x0c] user setting error flag clear
    $0d constant HPDMA_SUSPF                    \ [0x0d] completed suspension flag clear
    $0e constant HPDMA_TOF                      \ [0x0e] trigger overrun flag clear
  [then]


  [ifdef] HPDMA_HPDMA_C14SR_DEF
    \
    \ @brief HPDMA channel 14 status register
    \ Address offset: 0x760
    \ Reset value: 0x00000001
    \
    $00 constant HPDMA_IDLEF                    \ [0x00] idle flag
    $08 constant HPDMA_TCF                      \ [0x08] transfer complete flag
    $09 constant HPDMA_HTF                      \ [0x09] half transfer flag
    $0a constant HPDMA_DTEF                     \ [0x0a] data transfer error flag
    $0b constant HPDMA_ULEF                     \ [0x0b] update link transfer error flag
    $0c constant HPDMA_USEF                     \ [0x0c] user setting error flag
    $0d constant HPDMA_SUSPF                    \ [0x0d] completed suspension flag
    $0e constant HPDMA_TOF                      \ [0x0e] trigger overrun flag
    $10 constant HPDMA_FIFOL                    \ [0x10 : 9] monitored FIFO level
  [then]


  [ifdef] HPDMA_HPDMA_C14CR_DEF
    \
    \ @brief HPDMA channel 14 control register
    \ Address offset: 0x764
    \ Reset value: 0x00000000
    \
    $00 constant HPDMA_EN                       \ [0x00] enable
    $01 constant HPDMA_RESET                    \ [0x01] reset
    $02 constant HPDMA_SUSP                     \ [0x02] suspend
    $08 constant HPDMA_TCIE                     \ [0x08] transfer complete interrupt enable
    $09 constant HPDMA_HTIE                     \ [0x09] half transfer complete interrupt enable
    $0a constant HPDMA_DTEIE                    \ [0x0a] data transfer error interrupt enable
    $0b constant HPDMA_ULEIE                    \ [0x0b] update link transfer error interrupt enable
    $0c constant HPDMA_USEIE                    \ [0x0c] user setting error interrupt enable
    $0d constant HPDMA_SUSPIE                   \ [0x0d] completed suspension interrupt enable
    $0e constant HPDMA_TOIE                     \ [0x0e] trigger overrun interrupt enable
    $10 constant HPDMA_LSM                      \ [0x10] Link step mode
    $11 constant HPDMA_LAP                      \ [0x11] linked-list allocated port
    $16 constant HPDMA_PRIO                     \ [0x16 : 2] priority level of the channel x HPDMA transfer versus others
  [then]


  [ifdef] HPDMA_HPDMA_C14TR1_DEF
    \
    \ @brief HPDMA channel 14 transfer register 1
    \ Address offset: 0x790
    \ Reset value: 0x00000000
    \
    $00 constant HPDMA_SDW_LOG2                 \ [0x00 : 2] binary logarithm of the source data width of a burst in bytes
    $03 constant HPDMA_SINC                     \ [0x03] source incrementing burst
    $04 constant HPDMA_SBL_1                    \ [0x04 : 6] source burst length minus 1, between 0 and 63
    $0b constant HPDMA_PAM                      \ [0x0b : 2] padding/alignment mode
    $0d constant HPDMA_SBX                      \ [0x0d] source byte exchange within the unaligned half-word of each source word
    $0e constant HPDMA_SAP                      \ [0x0e] source allocated port
    $0f constant HPDMA_SSEC                     \ [0x0f] security attribute of the HPDMA transfer from the source
    $10 constant HPDMA_DDW_LOG2                 \ [0x10 : 2] binary logarithm of the destination data width of a burst, in bytes
    $13 constant HPDMA_DINC                     \ [0x13] destination incrementing burst
    $14 constant HPDMA_DBL_1                    \ [0x14 : 6] destination burst length minus 1, between 0 and 63
    $1a constant HPDMA_DBX                      \ [0x1a] destination byte exchange
    $1b constant HPDMA_DHX                      \ [0x1b] destination half-word exchange
    $1c constant HPDMA_DWX                      \ [0x1c] destination word exchange
    $1e constant HPDMA_DAP                      \ [0x1e] destination allocated port
    $1f constant HPDMA_DSEC                     \ [0x1f] security attribute of the HPDMA transfer to the destination
  [then]


  [ifdef] HPDMA_HPDMA_C14TR2_DEF
    \
    \ @brief HPDMA channel 14 transfer register 2
    \ Address offset: 0x794
    \ Reset value: 0x00000000
    \
    $00 constant HPDMA_REQSEL                   \ [0x00 : 8] hardware request selection
    $09 constant HPDMA_SWREQ                    \ [0x09] software request
    $0a constant HPDMA_DREQ                     \ [0x0a] destination hardware request
    $0b constant HPDMA_BREQ                     \ [0x0b] Block hardware request
    $0c constant HPDMA_PFREQ                    \ [0x0c] Hardware request in peripheral flow control mode
    $0e constant HPDMA_TRIGM                    \ [0x0e : 2] trigger mode
    $10 constant HPDMA_TRIGSEL                  \ [0x10 : 7] trigger event input selection
    $18 constant HPDMA_TRIGPOL                  \ [0x18 : 2] trigger event polarity
    $1e constant HPDMA_TCEM                     \ [0x1e : 2] transfer complete event mode
  [then]


  [ifdef] HPDMA_HPDMA_C14BR1_DEF
    \
    \ @brief HPDMA channel 14 alternate block register 1
    \ Address offset: 0x798
    \ Reset value: 0x00000000
    \
    $00 constant HPDMA_BNDT                     \ [0x00 : 16] block number of data bytes to transfer from the source
    $10 constant HPDMA_BRC                      \ [0x10 : 11] Block repeat counter
    $1c constant HPDMA_SDEC                     \ [0x1c] source address decrement
    $1d constant HPDMA_DDEC                     \ [0x1d] destination address decrement
    $1e constant HPDMA_BRSDEC                   \ [0x1e] Block repeat source address decrement
    $1f constant HPDMA_BRDDEC                   \ [0x1f] Block repeat destination address decrement
  [then]


  [ifdef] HPDMA_HPDMA_C14SAR_DEF
    \
    \ @brief HPDMA channel 14 source address register
    \ Address offset: 0x79C
    \ Reset value: 0x00000000
    \
    $00 constant HPDMA_SA                       \ [0x00 : 32] source address
  [then]


  [ifdef] HPDMA_HPDMA_C14DAR_DEF
    \
    \ @brief HPDMA channel 14 destination address register
    \ Address offset: 0x7A0
    \ Reset value: 0x00000000
    \
    $00 constant HPDMA_DA                       \ [0x00 : 32] destination address
  [then]


  [ifdef] HPDMA_HPDMA_C14TR3_DEF
    \
    \ @brief HPDMA channel 14 transfer register 3
    \ Address offset: 0x7A4
    \ Reset value: 0x00000000
    \
    $00 constant HPDMA_SAO                      \ [0x00 : 13] source address offset increment
    $10 constant HPDMA_DAO                      \ [0x10 : 13] destination address offset increment
  [then]


  [ifdef] HPDMA_HPDMA_C14BR2_DEF
    \
    \ @brief HPDMA channel 14 block register 2
    \ Address offset: 0x7A8
    \ Reset value: 0x00000000
    \
    $00 constant HPDMA_BRSAO                    \ [0x00 : 16] Block repeated source address offset
    $10 constant HPDMA_BRDAO                    \ [0x10 : 16] Block repeated destination address offset
  [then]


  [ifdef] HPDMA_HPDMA_C14LLR_DEF
    \
    \ @brief HPDMA channel 14 alternate linked-list address register
    \ Address offset: 0x7CC
    \ Reset value: 0x00000000
    \
    $02 constant HPDMA_LA                       \ [0x02 : 14] pointer (16-bit low-significant address) to the next linked-list data structure
    $10 constant HPDMA_ULL                      \ [0x10] Update HPDMA_CxLLR register from memory
    $19 constant HPDMA_UB2                      \ [0x19] Update HPDMA_CxBR2 from memory
    $1a constant HPDMA_UT3                      \ [0x1a] Update HPDMA_CxTR3 from memory
    $1b constant HPDMA_UDA                      \ [0x1b] Update HPDMA_CxDAR register from memory
    $1c constant HPDMA_USA                      \ [0x1c] update HPDMA_CxSAR from memory
    $1d constant HPDMA_UB1                      \ [0x1d] Update HPDMA_CxBR1 from memory
    $1e constant HPDMA_UT2                      \ [0x1e] Update HPDMA_CxTR2 from memory
    $1f constant HPDMA_UT1                      \ [0x1f] Update HPDMA_CxTR1 from memory
  [then]


  [ifdef] HPDMA_HPDMA_C15LBAR_DEF
    \
    \ @brief HPDMA channel 15 linked-list base address register
    \ Address offset: 0x7D0
    \ Reset value: 0x00000000
    \
    $10 constant HPDMA_LBA                      \ [0x10 : 16] linked-list base address of HPDMA channel x
  [then]


  [ifdef] HPDMA_HPDMA_C15CIDCFGR_DEF
    \
    \ @brief HPDMA channel 15 CID register
    \ Address offset: 0x7D4
    \ Reset value: 0x00000000
    \
    $00 constant HPDMA_CFEN                     \ [0x00] CID filtering enable of the channel x
    $01 constant HPDMA_SEM_EN                   \ [0x01] semaphore mode enable (for the CID allocation policy to the channel x)
    $04 constant HPDMA_SCID                     \ [0x04 : 3] allocate a static/single CID to the channel x (for when the channel x CID configuration is not in semaphore mode)
    $10 constant HPDMA_SEM_WLIST_CID0           \ [0x10] white-listed CID0 in the CID allocation pool (for when the channel x in semaphore mode)
    $11 constant HPDMA_SEM_WLIST_CID1           \ [0x11] white-listed CID1 in the CID allocation pool (for when the channel x in semaphore mode)
    $12 constant HPDMA_SEM_WLIST_CID2           \ [0x12] white-listed CID2 in the CID allocation pool (for when the channel x in semaphore mode)
    $13 constant HPDMA_SEM_WLIST_CID3           \ [0x13] white-listed CID3 in the CID allocation pool (for when the channel x in semaphore mode)
    $14 constant HPDMA_SEM_WLIST_CID4           \ [0x14] white-listed CID4 in the CID allocation pool (for when the channel x in semaphore mode)
    $15 constant HPDMA_SEM_WLIST_CID5           \ [0x15] white-listed CID5 in the CID allocation pool (for when the channel x in semaphore mode)
    $16 constant HPDMA_SEM_WLIST_CID6           \ [0x16] white-listed CID6 in the CID allocation pool (for when the channel x in semaphore mode)
  [then]


  [ifdef] HPDMA_HPDMA_C15SEMCR_DEF
    \
    \ @brief HPDMA channel 15 semaphore control register
    \ Address offset: 0x7D8
    \ Reset value: 0x00000000
    \
    $00 constant HPDMA_SEM_MUTEX                \ [0x00] mutual exclusion semaphore for the CID allocation of the channel x (in semaphore mode)
    $04 constant HPDMA_SEM_CCID                 \ [0x04 : 3] current CID allocated to the channel x (in semaphore mode)
  [then]


  [ifdef] HPDMA_HPDMA_C15FCR_DEF
    \
    \ @brief HPDMA channel 15 flag clear register
    \ Address offset: 0x7DC
    \ Reset value: 0x00000000
    \
    $08 constant HPDMA_TCF                      \ [0x08] transfer complete flag clear
    $09 constant HPDMA_HTF                      \ [0x09] half transfer flag clear
    $0a constant HPDMA_DTEF                     \ [0x0a] data transfer error flag clear
    $0b constant HPDMA_ULEF                     \ [0x0b] update link transfer error flag clear
    $0c constant HPDMA_USEF                     \ [0x0c] user setting error flag clear
    $0d constant HPDMA_SUSPF                    \ [0x0d] completed suspension flag clear
    $0e constant HPDMA_TOF                      \ [0x0e] trigger overrun flag clear
  [then]


  [ifdef] HPDMA_HPDMA_C15SR_DEF
    \
    \ @brief HPDMA channel 15 status register
    \ Address offset: 0x7E0
    \ Reset value: 0x00000001
    \
    $00 constant HPDMA_IDLEF                    \ [0x00] idle flag
    $08 constant HPDMA_TCF                      \ [0x08] transfer complete flag
    $09 constant HPDMA_HTF                      \ [0x09] half transfer flag
    $0a constant HPDMA_DTEF                     \ [0x0a] data transfer error flag
    $0b constant HPDMA_ULEF                     \ [0x0b] update link transfer error flag
    $0c constant HPDMA_USEF                     \ [0x0c] user setting error flag
    $0d constant HPDMA_SUSPF                    \ [0x0d] completed suspension flag
    $0e constant HPDMA_TOF                      \ [0x0e] trigger overrun flag
    $10 constant HPDMA_FIFOL                    \ [0x10 : 9] monitored FIFO level
  [then]


  [ifdef] HPDMA_HPDMA_C15CR_DEF
    \
    \ @brief HPDMA channel 15 control register
    \ Address offset: 0x7E4
    \ Reset value: 0x00000000
    \
    $00 constant HPDMA_EN                       \ [0x00] enable
    $01 constant HPDMA_RESET                    \ [0x01] reset
    $02 constant HPDMA_SUSP                     \ [0x02] suspend
    $08 constant HPDMA_TCIE                     \ [0x08] transfer complete interrupt enable
    $09 constant HPDMA_HTIE                     \ [0x09] half transfer complete interrupt enable
    $0a constant HPDMA_DTEIE                    \ [0x0a] data transfer error interrupt enable
    $0b constant HPDMA_ULEIE                    \ [0x0b] update link transfer error interrupt enable
    $0c constant HPDMA_USEIE                    \ [0x0c] user setting error interrupt enable
    $0d constant HPDMA_SUSPIE                   \ [0x0d] completed suspension interrupt enable
    $0e constant HPDMA_TOIE                     \ [0x0e] trigger overrun interrupt enable
    $10 constant HPDMA_LSM                      \ [0x10] Link step mode
    $11 constant HPDMA_LAP                      \ [0x11] linked-list allocated port
    $16 constant HPDMA_PRIO                     \ [0x16 : 2] priority level of the channel x HPDMA transfer versus others
  [then]


  [ifdef] HPDMA_HPDMA_C15TR1_DEF
    \
    \ @brief HPDMA channel 15 transfer register 1
    \ Address offset: 0x810
    \ Reset value: 0x00000000
    \
    $00 constant HPDMA_SDW_LOG2                 \ [0x00 : 2] binary logarithm of the source data width of a burst in bytes
    $03 constant HPDMA_SINC                     \ [0x03] source incrementing burst
    $04 constant HPDMA_SBL_1                    \ [0x04 : 6] source burst length minus 1, between 0 and 63
    $0b constant HPDMA_PAM                      \ [0x0b : 2] padding/alignment mode
    $0d constant HPDMA_SBX                      \ [0x0d] source byte exchange within the unaligned half-word of each source word
    $0e constant HPDMA_SAP                      \ [0x0e] source allocated port
    $0f constant HPDMA_SSEC                     \ [0x0f] security attribute of the HPDMA transfer from the source
    $10 constant HPDMA_DDW_LOG2                 \ [0x10 : 2] binary logarithm of the destination data width of a burst, in bytes
    $13 constant HPDMA_DINC                     \ [0x13] destination incrementing burst
    $14 constant HPDMA_DBL_1                    \ [0x14 : 6] destination burst length minus 1, between 0 and 63
    $1a constant HPDMA_DBX                      \ [0x1a] destination byte exchange
    $1b constant HPDMA_DHX                      \ [0x1b] destination half-word exchange
    $1c constant HPDMA_DWX                      \ [0x1c] destination word exchange
    $1e constant HPDMA_DAP                      \ [0x1e] destination allocated port
    $1f constant HPDMA_DSEC                     \ [0x1f] security attribute of the HPDMA transfer to the destination
  [then]


  [ifdef] HPDMA_HPDMA_C15TR2_DEF
    \
    \ @brief HPDMA channel 15 transfer register 2
    \ Address offset: 0x814
    \ Reset value: 0x00000000
    \
    $00 constant HPDMA_REQSEL                   \ [0x00 : 8] hardware request selection
    $09 constant HPDMA_SWREQ                    \ [0x09] software request
    $0a constant HPDMA_DREQ                     \ [0x0a] destination hardware request
    $0b constant HPDMA_BREQ                     \ [0x0b] Block hardware request
    $0c constant HPDMA_PFREQ                    \ [0x0c] Hardware request in peripheral flow control mode
    $0e constant HPDMA_TRIGM                    \ [0x0e : 2] trigger mode
    $10 constant HPDMA_TRIGSEL                  \ [0x10 : 7] trigger event input selection
    $18 constant HPDMA_TRIGPOL                  \ [0x18 : 2] trigger event polarity
    $1e constant HPDMA_TCEM                     \ [0x1e : 2] transfer complete event mode
  [then]


  [ifdef] HPDMA_HPDMA_C15BR1_DEF
    \
    \ @brief HPDMA channel 15 alternate block register 1
    \ Address offset: 0x818
    \ Reset value: 0x00000000
    \
    $00 constant HPDMA_BNDT                     \ [0x00 : 16] block number of data bytes to transfer from the source
    $10 constant HPDMA_BRC                      \ [0x10 : 11] Block repeat counter
    $1c constant HPDMA_SDEC                     \ [0x1c] source address decrement
    $1d constant HPDMA_DDEC                     \ [0x1d] destination address decrement
    $1e constant HPDMA_BRSDEC                   \ [0x1e] Block repeat source address decrement
    $1f constant HPDMA_BRDDEC                   \ [0x1f] Block repeat destination address decrement
  [then]


  [ifdef] HPDMA_HPDMA_C15SAR_DEF
    \
    \ @brief HPDMA channel 15 source address register
    \ Address offset: 0x81C
    \ Reset value: 0x00000000
    \
    $00 constant HPDMA_SA                       \ [0x00 : 32] source address
  [then]


  [ifdef] HPDMA_HPDMA_C15DAR_DEF
    \
    \ @brief HPDMA channel 15 destination address register
    \ Address offset: 0x820
    \ Reset value: 0x00000000
    \
    $00 constant HPDMA_DA                       \ [0x00 : 32] destination address
  [then]


  [ifdef] HPDMA_HPDMA_C15TR3_DEF
    \
    \ @brief HPDMA channel 15 transfer register 3
    \ Address offset: 0x824
    \ Reset value: 0x00000000
    \
    $00 constant HPDMA_SAO                      \ [0x00 : 13] source address offset increment
    $10 constant HPDMA_DAO                      \ [0x10 : 13] destination address offset increment
  [then]


  [ifdef] HPDMA_HPDMA_C15BR2_DEF
    \
    \ @brief HPDMA channel 15 block register 2
    \ Address offset: 0x828
    \ Reset value: 0x00000000
    \
    $00 constant HPDMA_BRSAO                    \ [0x00 : 16] Block repeated source address offset
    $10 constant HPDMA_BRDAO                    \ [0x10 : 16] Block repeated destination address offset
  [then]


  [ifdef] HPDMA_HPDMA_C15LLR_DEF
    \
    \ @brief HPDMA channel 15 alternate linked-list address register
    \ Address offset: 0x84C
    \ Reset value: 0x00000000
    \
    $02 constant HPDMA_LA                       \ [0x02 : 14] pointer (16-bit low-significant address) to the next linked-list data structure
    $10 constant HPDMA_ULL                      \ [0x10] Update HPDMA_CxLLR register from memory
    $19 constant HPDMA_UB2                      \ [0x19] Update HPDMA_CxBR2 from memory
    $1a constant HPDMA_UT3                      \ [0x1a] Update HPDMA_CxTR3 from memory
    $1b constant HPDMA_UDA                      \ [0x1b] Update HPDMA_CxDAR register from memory
    $1c constant HPDMA_USA                      \ [0x1c] update HPDMA_CxSAR from memory
    $1d constant HPDMA_UB1                      \ [0x1d] Update HPDMA_CxBR1 from memory
    $1e constant HPDMA_UT2                      \ [0x1e] Update HPDMA_CxTR2 from memory
    $1f constant HPDMA_UT1                      \ [0x1f] Update HPDMA_CxTR1 from memory
  [then]

  \
  \ @brief High-performance direct memory access controller
  \
  $00 constant HPDMA_HPDMA_SECCFGR      \ HPDMA secure configuration register
  $04 constant HPDMA_HPDMA_PRIVCFGR     \ HPDMA privileged configuration register
  $08 constant HPDMA_HPDMA_RCFGLOCKR    \ HPDMA configuration lock register
  $0C constant HPDMA_HPDMA_MISR         \ HPDMA non-secure masked interrupt status register
  $10 constant HPDMA_HPDMA_SMISR        \ HPDMA secure masked interrupt status register
  $50 constant HPDMA_HPDMA_C0LBAR       \ HPDMA channel 0 linked-list base address register
  $54 constant HPDMA_HPDMA_C0CIDCFGR    \ HPDMA channel 0 CID register
  $58 constant HPDMA_HPDMA_C0SEMCR      \ HPDMA channel 0 semaphore control register
  $5C constant HPDMA_HPDMA_C0FCR        \ HPDMA channel 0 flag clear register
  $60 constant HPDMA_HPDMA_C0SR         \ HPDMA channel 0 status register
  $64 constant HPDMA_HPDMA_C0CR         \ HPDMA channel 0 control register
  $90 constant HPDMA_HPDMA_C0TR1        \ HPDMA channel 0 transfer register 1
  $94 constant HPDMA_HPDMA_C0TR2        \ HPDMA channel 0 transfer register 2
  $98 constant HPDMA_HPDMA_C0BR1        \ HPDMA channel 0 block register 1
  $9C constant HPDMA_HPDMA_C0SAR        \ HPDMA channel 0 source address register
  $A0 constant HPDMA_HPDMA_C0DAR        \ HPDMA channel 0 destination address register
  $CC constant HPDMA_HPDMA_C0LLR        \ HPDMA channel 0 linked-list address register
  $D0 constant HPDMA_HPDMA_C1LBAR       \ HPDMA channel 1 linked-list base address register
  $D4 constant HPDMA_HPDMA_C1CIDCFGR    \ HPDMA channel 1 CID register
  $D8 constant HPDMA_HPDMA_C1SEMCR      \ HPDMA channel 1 semaphore control register
  $DC constant HPDMA_HPDMA_C1FCR        \ HPDMA channel 1 flag clear register
  $E0 constant HPDMA_HPDMA_C1SR         \ HPDMA channel 1 status register
  $E4 constant HPDMA_HPDMA_C1CR         \ HPDMA channel 1 control register
  $110 constant HPDMA_HPDMA_C1TR1       \ HPDMA channel 1 transfer register 1
  $114 constant HPDMA_HPDMA_C1TR2       \ HPDMA channel 1 transfer register 2
  $118 constant HPDMA_HPDMA_C1BR1       \ HPDMA channel 1 block register 1
  $11C constant HPDMA_HPDMA_C1SAR       \ HPDMA channel 1 source address register
  $120 constant HPDMA_HPDMA_C1DAR       \ HPDMA channel 1 destination address register
  $14C constant HPDMA_HPDMA_C1LLR       \ HPDMA channel 1 linked-list address register
  $150 constant HPDMA_HPDMA_C2LBAR      \ HPDMA channel 2 linked-list base address register
  $154 constant HPDMA_HPDMA_C2CIDCFGR   \ HPDMA channel 2 CID register
  $158 constant HPDMA_HPDMA_C2SEMCR     \ HPDMA channel 2 semaphore control register
  $15C constant HPDMA_HPDMA_C2FCR       \ HPDMA channel 2 flag clear register
  $160 constant HPDMA_HPDMA_C2SR        \ HPDMA channel 2 status register
  $164 constant HPDMA_HPDMA_C2CR        \ HPDMA channel 2 control register
  $190 constant HPDMA_HPDMA_C2TR1       \ HPDMA channel 2 transfer register 1
  $194 constant HPDMA_HPDMA_C2TR2       \ HPDMA channel 2 transfer register 2
  $198 constant HPDMA_HPDMA_C2BR1       \ HPDMA channel 2 block register 1
  $19C constant HPDMA_HPDMA_C2SAR       \ HPDMA channel 2 source address register
  $1A0 constant HPDMA_HPDMA_C2DAR       \ HPDMA channel 2 destination address register
  $1CC constant HPDMA_HPDMA_C2LLR       \ HPDMA channel 2 linked-list address register
  $1D0 constant HPDMA_HPDMA_C3LBAR      \ HPDMA channel 3 linked-list base address register
  $1D4 constant HPDMA_HPDMA_C3CIDCFGR   \ HPDMA channel 3 CID register
  $1D8 constant HPDMA_HPDMA_C3SEMCR     \ HPDMA channel 3 semaphore control register
  $1DC constant HPDMA_HPDMA_C3FCR       \ HPDMA channel 3 flag clear register
  $1E0 constant HPDMA_HPDMA_C3SR        \ HPDMA channel 3 status register
  $1E4 constant HPDMA_HPDMA_C3CR        \ HPDMA channel 3 control register
  $210 constant HPDMA_HPDMA_C3TR1       \ HPDMA channel 3 transfer register 1
  $214 constant HPDMA_HPDMA_C3TR2       \ HPDMA channel 3 transfer register 2
  $218 constant HPDMA_HPDMA_C3BR1       \ HPDMA channel 3 block register 1
  $21C constant HPDMA_HPDMA_C3SAR       \ HPDMA channel 3 source address register
  $220 constant HPDMA_HPDMA_C3DAR       \ HPDMA channel 3 destination address register
  $24C constant HPDMA_HPDMA_C3LLR       \ HPDMA channel 3 linked-list address register
  $250 constant HPDMA_HPDMA_C4LBAR      \ HPDMA channel 4 linked-list base address register
  $254 constant HPDMA_HPDMA_C4CIDCFGR   \ HPDMA channel 4 CID register
  $258 constant HPDMA_HPDMA_C4SEMCR     \ HPDMA channel 4 semaphore control register
  $25C constant HPDMA_HPDMA_C4FCR       \ HPDMA channel 4 flag clear register
  $260 constant HPDMA_HPDMA_C4SR        \ HPDMA channel 4 status register
  $264 constant HPDMA_HPDMA_C4CR        \ HPDMA channel 4 control register
  $290 constant HPDMA_HPDMA_C4TR1       \ HPDMA channel 4 transfer register 1
  $294 constant HPDMA_HPDMA_C4TR2       \ HPDMA channel 4 transfer register 2
  $298 constant HPDMA_HPDMA_C4BR1       \ HPDMA channel 4 block register 1
  $29C constant HPDMA_HPDMA_C4SAR       \ HPDMA channel 4 source address register
  $2A0 constant HPDMA_HPDMA_C4DAR       \ HPDMA channel 4 destination address register
  $2CC constant HPDMA_HPDMA_C4LLR       \ HPDMA channel 4 linked-list address register
  $2D0 constant HPDMA_HPDMA_C5LBAR      \ HPDMA channel 5 linked-list base address register
  $2D4 constant HPDMA_HPDMA_C5CIDCFGR   \ HPDMA channel 5 CID register
  $2D8 constant HPDMA_HPDMA_C5SEMCR     \ HPDMA channel 5 semaphore control register
  $2DC constant HPDMA_HPDMA_C5FCR       \ HPDMA channel 5 flag clear register
  $2E0 constant HPDMA_HPDMA_C5SR        \ HPDMA channel 5 status register
  $2E4 constant HPDMA_HPDMA_C5CR        \ HPDMA channel 5 control register
  $310 constant HPDMA_HPDMA_C5TR1       \ HPDMA channel 5 transfer register 1
  $314 constant HPDMA_HPDMA_C5TR2       \ HPDMA channel 5 transfer register 2
  $318 constant HPDMA_HPDMA_C5BR1       \ HPDMA channel 5 block register 1
  $31C constant HPDMA_HPDMA_C5SAR       \ HPDMA channel 5 source address register
  $320 constant HPDMA_HPDMA_C5DAR       \ HPDMA channel 5 destination address register
  $34C constant HPDMA_HPDMA_C5LLR       \ HPDMA channel 5 linked-list address register
  $350 constant HPDMA_HPDMA_C6LBAR      \ HPDMA channel 6 linked-list base address register
  $354 constant HPDMA_HPDMA_C6CIDCFGR   \ HPDMA channel 6 CID register
  $358 constant HPDMA_HPDMA_C6SEMCR     \ HPDMA channel 6 semaphore control register
  $35C constant HPDMA_HPDMA_C6FCR       \ HPDMA channel 6 flag clear register
  $360 constant HPDMA_HPDMA_C6SR        \ HPDMA channel 6 status register
  $364 constant HPDMA_HPDMA_C6CR        \ HPDMA channel 6 control register
  $390 constant HPDMA_HPDMA_C6TR1       \ HPDMA channel 6 transfer register 1
  $394 constant HPDMA_HPDMA_C6TR2       \ HPDMA channel 6 transfer register 2
  $398 constant HPDMA_HPDMA_C6BR1       \ HPDMA channel 6 block register 1
  $39C constant HPDMA_HPDMA_C6SAR       \ HPDMA channel 6 source address register
  $3A0 constant HPDMA_HPDMA_C6DAR       \ HPDMA channel 6 destination address register
  $3CC constant HPDMA_HPDMA_C6LLR       \ HPDMA channel 6 linked-list address register
  $3D0 constant HPDMA_HPDMA_C7LBAR      \ HPDMA channel 7 linked-list base address register
  $3D4 constant HPDMA_HPDMA_C7CIDCFGR   \ HPDMA channel 7 CID register
  $3D8 constant HPDMA_HPDMA_C7SEMCR     \ HPDMA channel 7 semaphore control register
  $3DC constant HPDMA_HPDMA_C7FCR       \ HPDMA channel 7 flag clear register
  $3E0 constant HPDMA_HPDMA_C7SR        \ HPDMA channel 7 status register
  $3E4 constant HPDMA_HPDMA_C7CR        \ HPDMA channel 7 control register
  $410 constant HPDMA_HPDMA_C7TR1       \ HPDMA channel 7 transfer register 1
  $414 constant HPDMA_HPDMA_C7TR2       \ HPDMA channel 7 transfer register 2
  $418 constant HPDMA_HPDMA_C7BR1       \ HPDMA channel 7 block register 1
  $41C constant HPDMA_HPDMA_C7SAR       \ HPDMA channel 7 source address register
  $420 constant HPDMA_HPDMA_C7DAR       \ HPDMA channel 7 destination address register
  $44C constant HPDMA_HPDMA_C7LLR       \ HPDMA channel 7 linked-list address register
  $450 constant HPDMA_HPDMA_C8LBAR      \ HPDMA channel 8 linked-list base address register
  $454 constant HPDMA_HPDMA_C8CIDCFGR   \ HPDMA channel 8 CID register
  $458 constant HPDMA_HPDMA_C8SEMCR     \ HPDMA channel 8 semaphore control register
  $45C constant HPDMA_HPDMA_C8FCR       \ HPDMA channel 8 flag clear register
  $460 constant HPDMA_HPDMA_C8SR        \ HPDMA channel 8 status register
  $464 constant HPDMA_HPDMA_C8CR        \ HPDMA channel 8 control register
  $490 constant HPDMA_HPDMA_C8TR1       \ HPDMA channel 8 transfer register 1
  $494 constant HPDMA_HPDMA_C8TR2       \ HPDMA channel 8 transfer register 2
  $498 constant HPDMA_HPDMA_C8BR1       \ HPDMA channel 8 block register 1
  $49C constant HPDMA_HPDMA_C8SAR       \ HPDMA channel 8 source address register
  $4A0 constant HPDMA_HPDMA_C8DAR       \ HPDMA channel 8 destination address register
  $4CC constant HPDMA_HPDMA_C8LLR       \ HPDMA channel 8 linked-list address register
  $4D0 constant HPDMA_HPDMA_C9LBAR      \ HPDMA channel 9 linked-list base address register
  $4D4 constant HPDMA_HPDMA_C9CIDCFGR   \ HPDMA channel 9 CID register
  $4D8 constant HPDMA_HPDMA_C9SEMCR     \ HPDMA channel 9 semaphore control register
  $4DC constant HPDMA_HPDMA_C9FCR       \ HPDMA channel 9 flag clear register
  $4E0 constant HPDMA_HPDMA_C9SR        \ HPDMA channel 9 status register
  $4E4 constant HPDMA_HPDMA_C9CR        \ HPDMA channel 9 control register
  $510 constant HPDMA_HPDMA_C9TR1       \ HPDMA channel 9 transfer register 1
  $514 constant HPDMA_HPDMA_C9TR2       \ HPDMA channel 9 transfer register 2
  $518 constant HPDMA_HPDMA_C9BR1       \ HPDMA channel 9 block register 1
  $51C constant HPDMA_HPDMA_C9SAR       \ HPDMA channel 9 source address register
  $520 constant HPDMA_HPDMA_C9DAR       \ HPDMA channel 9 destination address register
  $54C constant HPDMA_HPDMA_C9LLR       \ HPDMA channel 9 linked-list address register
  $550 constant HPDMA_HPDMA_C10LBAR     \ HPDMA channel 10 linked-list base address register
  $554 constant HPDMA_HPDMA_C10CIDCFGR  \ HPDMA channel 10 CID register
  $558 constant HPDMA_HPDMA_C10SEMCR    \ HPDMA channel 10 semaphore control register
  $55C constant HPDMA_HPDMA_C10FCR      \ HPDMA channel 10 flag clear register
  $560 constant HPDMA_HPDMA_C10SR       \ HPDMA channel 10 status register
  $564 constant HPDMA_HPDMA_C10CR       \ HPDMA channel 10 control register
  $590 constant HPDMA_HPDMA_C10TR1      \ HPDMA channel 10 transfer register 1
  $594 constant HPDMA_HPDMA_C10TR2      \ HPDMA channel 10 transfer register 2
  $598 constant HPDMA_HPDMA_C10BR1      \ HPDMA channel 10 block register 1
  $59C constant HPDMA_HPDMA_C10SAR      \ HPDMA channel 10 source address register
  $5A0 constant HPDMA_HPDMA_C10DAR      \ HPDMA channel 10 destination address register
  $5CC constant HPDMA_HPDMA_C10LLR      \ HPDMA channel 10 linked-list address register
  $5D0 constant HPDMA_HPDMA_C11LBAR     \ HPDMA channel 11 linked-list base address register
  $5D4 constant HPDMA_HPDMA_C11CIDCFGR  \ HPDMA channel 11 CID register
  $5D8 constant HPDMA_HPDMA_C11SEMCR    \ HPDMA channel 11 semaphore control register
  $5DC constant HPDMA_HPDMA_C11FCR      \ HPDMA channel 11 flag clear register
  $5E0 constant HPDMA_HPDMA_C11SR       \ HPDMA channel 11 status register
  $5E4 constant HPDMA_HPDMA_C11CR       \ HPDMA channel 11 control register
  $610 constant HPDMA_HPDMA_C11TR1      \ HPDMA channel 11 transfer register 1
  $614 constant HPDMA_HPDMA_C11TR2      \ HPDMA channel 11 transfer register 2
  $618 constant HPDMA_HPDMA_C11BR1      \ HPDMA channel 11 block register 1
  $61C constant HPDMA_HPDMA_C11SAR      \ HPDMA channel 11 source address register
  $620 constant HPDMA_HPDMA_C11DAR      \ HPDMA channel 11 destination address register
  $64C constant HPDMA_HPDMA_C11LLR      \ HPDMA channel 11 linked-list address register
  $650 constant HPDMA_HPDMA_C12LBAR     \ HPDMA channel 12 linked-list base address register
  $654 constant HPDMA_HPDMA_C12CIDCFGR  \ HPDMA channel 12 CID register
  $658 constant HPDMA_HPDMA_C12SEMCR    \ HPDMA channel 12 semaphore control register
  $65C constant HPDMA_HPDMA_C12FCR      \ HPDMA channel 12 flag clear register
  $660 constant HPDMA_HPDMA_C12SR       \ HPDMA channel 12 status register
  $664 constant HPDMA_HPDMA_C12CR       \ HPDMA channel 12 control register
  $690 constant HPDMA_HPDMA_C12TR1      \ HPDMA channel 12 transfer register 1
  $694 constant HPDMA_HPDMA_C12TR2      \ HPDMA channel 12 transfer register 2
  $698 constant HPDMA_HPDMA_C12BR1      \ HPDMA channel 12 alternate block register 1
  $69C constant HPDMA_HPDMA_C12SAR      \ HPDMA channel 12 source address register
  $6A0 constant HPDMA_HPDMA_C12DAR      \ HPDMA channel 12 destination address register
  $6A4 constant HPDMA_HPDMA_C12TR3      \ HPDMA channel 12 transfer register 3
  $6A8 constant HPDMA_HPDMA_C12BR2      \ HPDMA channel 12 block register 2
  $6CC constant HPDMA_HPDMA_C12LLR      \ HPDMA channel 12 alternate linked-list address register
  $6D0 constant HPDMA_HPDMA_C13LBAR     \ HPDMA channel 13 linked-list base address register
  $6D4 constant HPDMA_HPDMA_C13CIDCFGR  \ HPDMA channel 13 CID register
  $6D8 constant HPDMA_HPDMA_C13SEMCR    \ HPDMA channel 13 semaphore control register
  $6DC constant HPDMA_HPDMA_C13FCR      \ HPDMA channel 13 flag clear register
  $6E0 constant HPDMA_HPDMA_C13SR       \ HPDMA channel 13 status register
  $6E4 constant HPDMA_HPDMA_C13CR       \ HPDMA channel 13 control register
  $710 constant HPDMA_HPDMA_C13TR1      \ HPDMA channel 13 transfer register 1
  $714 constant HPDMA_HPDMA_C13TR2      \ HPDMA channel 13 transfer register 2
  $718 constant HPDMA_HPDMA_C13BR1      \ HPDMA channel 13 alternate block register 1
  $71C constant HPDMA_HPDMA_C13SAR      \ HPDMA channel 13 source address register
  $720 constant HPDMA_HPDMA_C13DAR      \ HPDMA channel 13 destination address register
  $724 constant HPDMA_HPDMA_C13TR3      \ HPDMA channel 13 transfer register 3
  $728 constant HPDMA_HPDMA_C13BR2      \ HPDMA channel 13 block register 2
  $74C constant HPDMA_HPDMA_C13LLR      \ HPDMA channel 13 alternate linked-list address register
  $750 constant HPDMA_HPDMA_C14LBAR     \ HPDMA channel 14 linked-list base address register
  $754 constant HPDMA_HPDMA_C14CIDCFGR  \ HPDMA channel 14 CID register
  $758 constant HPDMA_HPDMA_C14SEMCR    \ HPDMA channel 14 semaphore control register
  $75C constant HPDMA_HPDMA_C14FCR      \ HPDMA channel 14 flag clear register
  $760 constant HPDMA_HPDMA_C14SR       \ HPDMA channel 14 status register
  $764 constant HPDMA_HPDMA_C14CR       \ HPDMA channel 14 control register
  $790 constant HPDMA_HPDMA_C14TR1      \ HPDMA channel 14 transfer register 1
  $794 constant HPDMA_HPDMA_C14TR2      \ HPDMA channel 14 transfer register 2
  $798 constant HPDMA_HPDMA_C14BR1      \ HPDMA channel 14 alternate block register 1
  $79C constant HPDMA_HPDMA_C14SAR      \ HPDMA channel 14 source address register
  $7A0 constant HPDMA_HPDMA_C14DAR      \ HPDMA channel 14 destination address register
  $7A4 constant HPDMA_HPDMA_C14TR3      \ HPDMA channel 14 transfer register 3
  $7A8 constant HPDMA_HPDMA_C14BR2      \ HPDMA channel 14 block register 2
  $7CC constant HPDMA_HPDMA_C14LLR      \ HPDMA channel 14 alternate linked-list address register
  $7D0 constant HPDMA_HPDMA_C15LBAR     \ HPDMA channel 15 linked-list base address register
  $7D4 constant HPDMA_HPDMA_C15CIDCFGR  \ HPDMA channel 15 CID register
  $7D8 constant HPDMA_HPDMA_C15SEMCR    \ HPDMA channel 15 semaphore control register
  $7DC constant HPDMA_HPDMA_C15FCR      \ HPDMA channel 15 flag clear register
  $7E0 constant HPDMA_HPDMA_C15SR       \ HPDMA channel 15 status register
  $7E4 constant HPDMA_HPDMA_C15CR       \ HPDMA channel 15 control register
  $810 constant HPDMA_HPDMA_C15TR1      \ HPDMA channel 15 transfer register 1
  $814 constant HPDMA_HPDMA_C15TR2      \ HPDMA channel 15 transfer register 2
  $818 constant HPDMA_HPDMA_C15BR1      \ HPDMA channel 15 alternate block register 1
  $81C constant HPDMA_HPDMA_C15SAR      \ HPDMA channel 15 source address register
  $820 constant HPDMA_HPDMA_C15DAR      \ HPDMA channel 15 destination address register
  $824 constant HPDMA_HPDMA_C15TR3      \ HPDMA channel 15 transfer register 3
  $828 constant HPDMA_HPDMA_C15BR2      \ HPDMA channel 15 block register 2
  $84C constant HPDMA_HPDMA_C15LLR      \ HPDMA channel 15 alternate linked-list address register

: HPDMA_DEF ; [then]
