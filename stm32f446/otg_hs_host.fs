\
\ @file otg_hs_host.fs
\ @brief USB on the go high speed
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] OTG_HS_HOST_DEF

  [ifdef] OTG_HS_HOST_OTG_HS_HCFG_DEF
    \
    \ @brief OTG_HS host configuration register
    \ Address offset: 0x00
    \ Reset value: 0x00000000
    \
    $00 constant OTG_HS_HOST_FSLSPCS            \ [0x00 : 2] FS/LS PHY clock select
    $02 constant OTG_HS_HOST_FSLSS              \ [0x02] FS- and LS-only support
  [then]


  [ifdef] OTG_HS_HOST_OTG_HS_HFIR_DEF
    \
    \ @brief OTG_HS Host frame interval register
    \ Address offset: 0x04
    \ Reset value: 0x0000EA60
    \
    $00 constant OTG_HS_HOST_FRIVL              \ [0x00 : 16] Frame interval
    $10 constant OTG_HS_HOST_RLDCTRL            \ [0x10] Reload control
  [then]


  [ifdef] OTG_HS_HOST_OTG_HS_HFNUM_DEF
    \
    \ @brief OTG_HS host frame number/frame time remaining register
    \ Address offset: 0x08
    \ Reset value: 0x00003FFF
    \
    $00 constant OTG_HS_HOST_FRNUM              \ [0x00 : 16] Frame number
    $10 constant OTG_HS_HOST_FTREM              \ [0x10 : 16] Frame time remaining
  [then]


  [ifdef] OTG_HS_HOST_OTG_HS_HPTXSTS_DEF
    \
    \ @brief OTG_HS_Host periodic transmit FIFO/queue status register
    \ Address offset: 0x10
    \ Reset value: 0x00080100
    \
    $00 constant OTG_HS_HOST_PTXFSAVL           \ [0x00 : 16] Periodic transmit data FIFO space available
    $10 constant OTG_HS_HOST_PTXQSAV            \ [0x10 : 8] Periodic transmit request queue space available
    $18 constant OTG_HS_HOST_PTXQTOP            \ [0x18 : 8] Top of the periodic transmit request queue
  [then]


  [ifdef] OTG_HS_HOST_OTG_HS_HAINT_DEF
    \
    \ @brief OTG_HS Host all channels interrupt register
    \ Address offset: 0x14
    \ Reset value: 0x00000000
    \
    $00 constant OTG_HS_HOST_HAINT              \ [0x00 : 16] Channel interrupts
  [then]


  [ifdef] OTG_HS_HOST_OTG_HS_HAINTMSK_DEF
    \
    \ @brief OTG_HS host all channels interrupt mask register
    \ Address offset: 0x18
    \ Reset value: 0x00000000
    \
    $00 constant OTG_HS_HOST_HAINTM             \ [0x00 : 16] Channel interrupt mask
  [then]


  [ifdef] OTG_HS_HOST_OTG_HS_HPRT_DEF
    \
    \ @brief OTG_HS host port control and status register
    \ Address offset: 0x40
    \ Reset value: 0x00000000
    \
    $00 constant OTG_HS_HOST_PCSTS              \ [0x00] Port connect status
    $01 constant OTG_HS_HOST_PCDET              \ [0x01] Port connect detected
    $02 constant OTG_HS_HOST_PENA               \ [0x02] Port enable
    $03 constant OTG_HS_HOST_PENCHNG            \ [0x03] Port enable/disable change
    $04 constant OTG_HS_HOST_POCA               \ [0x04] Port overcurrent active
    $05 constant OTG_HS_HOST_POCCHNG            \ [0x05] Port overcurrent change
    $06 constant OTG_HS_HOST_PRES               \ [0x06] Port resume
    $07 constant OTG_HS_HOST_PSUSP              \ [0x07] Port suspend
    $08 constant OTG_HS_HOST_PRST               \ [0x08] Port reset
    $0a constant OTG_HS_HOST_PLSTS              \ [0x0a : 2] Port line status
    $0c constant OTG_HS_HOST_PPWR               \ [0x0c] Port power
    $0d constant OTG_HS_HOST_PTCTL              \ [0x0d : 4] Port test control
    $11 constant OTG_HS_HOST_PSPD               \ [0x11 : 2] Port speed
  [then]


  [ifdef] OTG_HS_HOST_OTG_HS_HCCHAR0_DEF
    \
    \ @brief OTG_HS host channel-0 characteristics register
    \ Address offset: 0x100
    \ Reset value: 0x00000000
    \
    $00 constant OTG_HS_HOST_MPSIZ              \ [0x00 : 11] Maximum packet size
    $0b constant OTG_HS_HOST_EPNUM              \ [0x0b : 4] Endpoint number
    $0f constant OTG_HS_HOST_EPDIR              \ [0x0f] Endpoint direction
    $11 constant OTG_HS_HOST_LSDEV              \ [0x11] Low-speed device
    $12 constant OTG_HS_HOST_EPTYP              \ [0x12 : 2] Endpoint type
    $14 constant OTG_HS_HOST_MCNT               \ [0x14 : 2] Multi Count (MC) / Error Count (EC)
    $16 constant OTG_HS_HOST_DAD                \ [0x16 : 7] Device address
    $1d constant OTG_HS_HOST_ODDFRM             \ [0x1d] Odd frame
    $1e constant OTG_HS_HOST_CHDIS              \ [0x1e] Channel disable
    $1f constant OTG_HS_HOST_CHENA              \ [0x1f] Channel enable
  [then]


  [ifdef] OTG_HS_HOST_OTG_HS_HCSPLT0_DEF
    \
    \ @brief OTG_HS host channel-0 split control register
    \ Address offset: 0x104
    \ Reset value: 0x00000000
    \
    $00 constant OTG_HS_HOST_PRTADDR            \ [0x00 : 7] Port address
    $07 constant OTG_HS_HOST_HUBADDR            \ [0x07 : 7] Hub address
    $0e constant OTG_HS_HOST_XACTPOS            \ [0x0e : 2] XACTPOS
    $10 constant OTG_HS_HOST_COMPLSPLT          \ [0x10] Do complete split
    $1f constant OTG_HS_HOST_SPLITEN            \ [0x1f] Split enable
  [then]


  [ifdef] OTG_HS_HOST_OTG_HS_HCINT0_DEF
    \
    \ @brief OTG_HS host channel-11 interrupt register
    \ Address offset: 0x108
    \ Reset value: 0x00000000
    \
    $00 constant OTG_HS_HOST_XFRC               \ [0x00] Transfer completed
    $01 constant OTG_HS_HOST_CHH                \ [0x01] Channel halted
    $03 constant OTG_HS_HOST_STALL              \ [0x03] STALL response received interrupt
    $04 constant OTG_HS_HOST_NAK                \ [0x04] NAK response received interrupt
    $05 constant OTG_HS_HOST_ACK                \ [0x05] ACK response received/transmitted interrupt
    $07 constant OTG_HS_HOST_TXERR              \ [0x07] Transaction error
    $08 constant OTG_HS_HOST_BBERR              \ [0x08] Babble error
    $09 constant OTG_HS_HOST_FRMOR              \ [0x09] Frame overrun
    $0a constant OTG_HS_HOST_DTERR              \ [0x0a] Data toggle error
  [then]


  [ifdef] OTG_HS_HOST_OTG_HS_HCINTMSK0_DEF
    \
    \ @brief OTG_HS host channel-11 interrupt mask register
    \ Address offset: 0x10C
    \ Reset value: 0x00000000
    \
    $00 constant OTG_HS_HOST_XFRCM              \ [0x00] Transfer completed mask
    $01 constant OTG_HS_HOST_CHHM               \ [0x01] Channel halted mask
    $02 constant OTG_HS_HOST_AHBERRM            \ [0x02] AHB error
    $03 constant OTG_HS_HOST_STALLM             \ [0x03] STALL response received interrupt mask
    $04 constant OTG_HS_HOST_NAKM               \ [0x04] NAK response received interrupt mask
    $05 constant OTG_HS_HOST_ACKM               \ [0x05] ACK response received/transmitted interrupt mask
    $06 constant OTG_HS_HOST_NYET               \ [0x06] response received interrupt mask
    $07 constant OTG_HS_HOST_TXERRM             \ [0x07] Transaction error mask
    $08 constant OTG_HS_HOST_BBERRM             \ [0x08] Babble error mask
    $09 constant OTG_HS_HOST_FRMORM             \ [0x09] Frame overrun mask
    $0a constant OTG_HS_HOST_DTERRM             \ [0x0a] Data toggle error mask
  [then]


  [ifdef] OTG_HS_HOST_OTG_HS_HCTSIZ0_DEF
    \
    \ @brief OTG_HS host channel-11 transfer size register
    \ Address offset: 0x110
    \ Reset value: 0x00000000
    \
    $00 constant OTG_HS_HOST_XFRSIZ             \ [0x00 : 19] Transfer size
    $13 constant OTG_HS_HOST_PKTCNT             \ [0x13 : 10] Packet count
    $1d constant OTG_HS_HOST_DPID               \ [0x1d : 2] Data PID
  [then]


  [ifdef] OTG_HS_HOST_OTG_HS_HCDMA0_DEF
    \
    \ @brief OTG_HS host channel-0 DMA address register
    \ Address offset: 0x114
    \ Reset value: 0x00000000
    \
    $00 constant OTG_HS_HOST_DMAADDR            \ [0x00 : 32] DMA address
  [then]


  [ifdef] OTG_HS_HOST_OTG_HS_HCCHAR1_DEF
    \
    \ @brief OTG_HS host channel-1 characteristics register
    \ Address offset: 0x120
    \ Reset value: 0x00000000
    \
    $00 constant OTG_HS_HOST_MPSIZ              \ [0x00 : 11] Maximum packet size
    $0b constant OTG_HS_HOST_EPNUM              \ [0x0b : 4] Endpoint number
    $0f constant OTG_HS_HOST_EPDIR              \ [0x0f] Endpoint direction
    $11 constant OTG_HS_HOST_LSDEV              \ [0x11] Low-speed device
    $12 constant OTG_HS_HOST_EPTYP              \ [0x12 : 2] Endpoint type
    $14 constant OTG_HS_HOST_MCNT               \ [0x14 : 2] Multi Count (MC) / Error Count (EC)
    $16 constant OTG_HS_HOST_DAD                \ [0x16 : 7] Device address
    $1d constant OTG_HS_HOST_ODDFRM             \ [0x1d] Odd frame
    $1e constant OTG_HS_HOST_CHDIS              \ [0x1e] Channel disable
    $1f constant OTG_HS_HOST_CHENA              \ [0x1f] Channel enable
  [then]


  [ifdef] OTG_HS_HOST_OTG_HS_HCSPLT1_DEF
    \
    \ @brief OTG_HS host channel-1 split control register
    \ Address offset: 0x124
    \ Reset value: 0x00000000
    \
    $00 constant OTG_HS_HOST_PRTADDR            \ [0x00 : 7] Port address
    $07 constant OTG_HS_HOST_HUBADDR            \ [0x07 : 7] Hub address
    $0e constant OTG_HS_HOST_XACTPOS            \ [0x0e : 2] XACTPOS
    $10 constant OTG_HS_HOST_COMPLSPLT          \ [0x10] Do complete split
    $1f constant OTG_HS_HOST_SPLITEN            \ [0x1f] Split enable
  [then]


  [ifdef] OTG_HS_HOST_OTG_HS_HCINT1_DEF
    \
    \ @brief OTG_HS host channel-1 interrupt register
    \ Address offset: 0x128
    \ Reset value: 0x00000000
    \
    $00 constant OTG_HS_HOST_XFRC               \ [0x00] Transfer completed
    $01 constant OTG_HS_HOST_CHH                \ [0x01] Channel halted
    $02 constant OTG_HS_HOST_AHBERR             \ [0x02] AHB error
    $03 constant OTG_HS_HOST_STALL              \ [0x03] STALL response received interrupt
    $04 constant OTG_HS_HOST_NAK                \ [0x04] NAK response received interrupt
    $05 constant OTG_HS_HOST_ACK                \ [0x05] ACK response received/transmitted interrupt
    $06 constant OTG_HS_HOST_NYET               \ [0x06] Response received interrupt
    $07 constant OTG_HS_HOST_TXERR              \ [0x07] Transaction error
    $08 constant OTG_HS_HOST_BBERR              \ [0x08] Babble error
    $09 constant OTG_HS_HOST_FRMOR              \ [0x09] Frame overrun
    $0a constant OTG_HS_HOST_DTERR              \ [0x0a] Data toggle error
  [then]


  [ifdef] OTG_HS_HOST_OTG_HS_HCINTMSK1_DEF
    \
    \ @brief OTG_HS host channel-1 interrupt mask register
    \ Address offset: 0x12C
    \ Reset value: 0x00000000
    \
    $00 constant OTG_HS_HOST_XFRCM              \ [0x00] Transfer completed mask
    $01 constant OTG_HS_HOST_CHHM               \ [0x01] Channel halted mask
    $02 constant OTG_HS_HOST_AHBERRM            \ [0x02] AHB error
    $03 constant OTG_HS_HOST_STALLM             \ [0x03] STALL response received interrupt mask
    $04 constant OTG_HS_HOST_NAKM               \ [0x04] NAK response received interrupt mask
    $05 constant OTG_HS_HOST_ACKM               \ [0x05] ACK response received/transmitted interrupt mask
    $06 constant OTG_HS_HOST_NYET               \ [0x06] response received interrupt mask
    $07 constant OTG_HS_HOST_TXERRM             \ [0x07] Transaction error mask
    $08 constant OTG_HS_HOST_BBERRM             \ [0x08] Babble error mask
    $09 constant OTG_HS_HOST_FRMORM             \ [0x09] Frame overrun mask
    $0a constant OTG_HS_HOST_DTERRM             \ [0x0a] Data toggle error mask
  [then]


  [ifdef] OTG_HS_HOST_OTG_HS_HCTSIZ1_DEF
    \
    \ @brief OTG_HS host channel-1 transfer size register
    \ Address offset: 0x130
    \ Reset value: 0x00000000
    \
    $00 constant OTG_HS_HOST_XFRSIZ             \ [0x00 : 19] Transfer size
    $13 constant OTG_HS_HOST_PKTCNT             \ [0x13 : 10] Packet count
    $1d constant OTG_HS_HOST_DPID               \ [0x1d : 2] Data PID
  [then]


  [ifdef] OTG_HS_HOST_OTG_HS_HCDMA1_DEF
    \
    \ @brief OTG_HS host channel-1 DMA address register
    \ Address offset: 0x134
    \ Reset value: 0x00000000
    \
    $00 constant OTG_HS_HOST_DMAADDR            \ [0x00 : 32] DMA address
  [then]


  [ifdef] OTG_HS_HOST_OTG_HS_HCCHAR2_DEF
    \
    \ @brief OTG_HS host channel-2 characteristics register
    \ Address offset: 0x140
    \ Reset value: 0x00000000
    \
    $00 constant OTG_HS_HOST_MPSIZ              \ [0x00 : 11] Maximum packet size
    $0b constant OTG_HS_HOST_EPNUM              \ [0x0b : 4] Endpoint number
    $0f constant OTG_HS_HOST_EPDIR              \ [0x0f] Endpoint direction
    $11 constant OTG_HS_HOST_LSDEV              \ [0x11] Low-speed device
    $12 constant OTG_HS_HOST_EPTYP              \ [0x12 : 2] Endpoint type
    $14 constant OTG_HS_HOST_MCNT               \ [0x14 : 2] Multi Count (MC) / Error Count (EC)
    $16 constant OTG_HS_HOST_DAD                \ [0x16 : 7] Device address
    $1d constant OTG_HS_HOST_ODDFRM             \ [0x1d] Odd frame
    $1e constant OTG_HS_HOST_CHDIS              \ [0x1e] Channel disable
    $1f constant OTG_HS_HOST_CHENA              \ [0x1f] Channel enable
  [then]


  [ifdef] OTG_HS_HOST_OTG_HS_HCSPLT2_DEF
    \
    \ @brief OTG_HS host channel-2 split control register
    \ Address offset: 0x144
    \ Reset value: 0x00000000
    \
    $00 constant OTG_HS_HOST_PRTADDR            \ [0x00 : 7] Port address
    $07 constant OTG_HS_HOST_HUBADDR            \ [0x07 : 7] Hub address
    $0e constant OTG_HS_HOST_XACTPOS            \ [0x0e : 2] XACTPOS
    $10 constant OTG_HS_HOST_COMPLSPLT          \ [0x10] Do complete split
    $1f constant OTG_HS_HOST_SPLITEN            \ [0x1f] Split enable
  [then]


  [ifdef] OTG_HS_HOST_OTG_HS_HCINT2_DEF
    \
    \ @brief OTG_HS host channel-2 interrupt register
    \ Address offset: 0x148
    \ Reset value: 0x00000000
    \
    $00 constant OTG_HS_HOST_XFRC               \ [0x00] Transfer completed
    $01 constant OTG_HS_HOST_CHH                \ [0x01] Channel halted
    $02 constant OTG_HS_HOST_AHBERR             \ [0x02] AHB error
    $03 constant OTG_HS_HOST_STALL              \ [0x03] STALL response received interrupt
    $04 constant OTG_HS_HOST_NAK                \ [0x04] NAK response received interrupt
    $05 constant OTG_HS_HOST_ACK                \ [0x05] ACK response received/transmitted interrupt
    $06 constant OTG_HS_HOST_NYET               \ [0x06] Response received interrupt
    $07 constant OTG_HS_HOST_TXERR              \ [0x07] Transaction error
    $08 constant OTG_HS_HOST_BBERR              \ [0x08] Babble error
    $09 constant OTG_HS_HOST_FRMOR              \ [0x09] Frame overrun
    $0a constant OTG_HS_HOST_DTERR              \ [0x0a] Data toggle error
  [then]


  [ifdef] OTG_HS_HOST_OTG_HS_HCINTMSK2_DEF
    \
    \ @brief OTG_HS host channel-2 interrupt mask register
    \ Address offset: 0x14C
    \ Reset value: 0x00000000
    \
    $00 constant OTG_HS_HOST_XFRCM              \ [0x00] Transfer completed mask
    $01 constant OTG_HS_HOST_CHHM               \ [0x01] Channel halted mask
    $02 constant OTG_HS_HOST_AHBERRM            \ [0x02] AHB error
    $03 constant OTG_HS_HOST_STALLM             \ [0x03] STALL response received interrupt mask
    $04 constant OTG_HS_HOST_NAKM               \ [0x04] NAK response received interrupt mask
    $05 constant OTG_HS_HOST_ACKM               \ [0x05] ACK response received/transmitted interrupt mask
    $06 constant OTG_HS_HOST_NYET               \ [0x06] response received interrupt mask
    $07 constant OTG_HS_HOST_TXERRM             \ [0x07] Transaction error mask
    $08 constant OTG_HS_HOST_BBERRM             \ [0x08] Babble error mask
    $09 constant OTG_HS_HOST_FRMORM             \ [0x09] Frame overrun mask
    $0a constant OTG_HS_HOST_DTERRM             \ [0x0a] Data toggle error mask
  [then]


  [ifdef] OTG_HS_HOST_OTG_HS_HCTSIZ2_DEF
    \
    \ @brief OTG_HS host channel-2 transfer size register
    \ Address offset: 0x150
    \ Reset value: 0x00000000
    \
    $00 constant OTG_HS_HOST_XFRSIZ             \ [0x00 : 19] Transfer size
    $13 constant OTG_HS_HOST_PKTCNT             \ [0x13 : 10] Packet count
    $1d constant OTG_HS_HOST_DPID               \ [0x1d : 2] Data PID
  [then]


  [ifdef] OTG_HS_HOST_OTG_HS_HCDMA2_DEF
    \
    \ @brief OTG_HS host channel-2 DMA address register
    \ Address offset: 0x154
    \ Reset value: 0x00000000
    \
    $00 constant OTG_HS_HOST_DMAADDR            \ [0x00 : 32] DMA address
  [then]


  [ifdef] OTG_HS_HOST_OTG_HS_HCCHAR3_DEF
    \
    \ @brief OTG_HS host channel-3 characteristics register
    \ Address offset: 0x160
    \ Reset value: 0x00000000
    \
    $00 constant OTG_HS_HOST_MPSIZ              \ [0x00 : 11] Maximum packet size
    $0b constant OTG_HS_HOST_EPNUM              \ [0x0b : 4] Endpoint number
    $0f constant OTG_HS_HOST_EPDIR              \ [0x0f] Endpoint direction
    $11 constant OTG_HS_HOST_LSDEV              \ [0x11] Low-speed device
    $12 constant OTG_HS_HOST_EPTYP              \ [0x12 : 2] Endpoint type
    $14 constant OTG_HS_HOST_MCNT               \ [0x14 : 2] Multi Count (MC) / Error Count (EC)
    $16 constant OTG_HS_HOST_DAD                \ [0x16 : 7] Device address
    $1d constant OTG_HS_HOST_ODDFRM             \ [0x1d] Odd frame
    $1e constant OTG_HS_HOST_CHDIS              \ [0x1e] Channel disable
    $1f constant OTG_HS_HOST_CHENA              \ [0x1f] Channel enable
  [then]


  [ifdef] OTG_HS_HOST_OTG_HS_HCSPLT3_DEF
    \
    \ @brief OTG_HS host channel-3 split control register
    \ Address offset: 0x164
    \ Reset value: 0x00000000
    \
    $00 constant OTG_HS_HOST_PRTADDR            \ [0x00 : 7] Port address
    $07 constant OTG_HS_HOST_HUBADDR            \ [0x07 : 7] Hub address
    $0e constant OTG_HS_HOST_XACTPOS            \ [0x0e : 2] XACTPOS
    $10 constant OTG_HS_HOST_COMPLSPLT          \ [0x10] Do complete split
    $1f constant OTG_HS_HOST_SPLITEN            \ [0x1f] Split enable
  [then]


  [ifdef] OTG_HS_HOST_OTG_HS_HCINT3_DEF
    \
    \ @brief OTG_HS host channel-3 interrupt register
    \ Address offset: 0x168
    \ Reset value: 0x00000000
    \
    $00 constant OTG_HS_HOST_XFRC               \ [0x00] Transfer completed
    $01 constant OTG_HS_HOST_CHH                \ [0x01] Channel halted
    $02 constant OTG_HS_HOST_AHBERR             \ [0x02] AHB error
    $03 constant OTG_HS_HOST_STALL              \ [0x03] STALL response received interrupt
    $04 constant OTG_HS_HOST_NAK                \ [0x04] NAK response received interrupt
    $05 constant OTG_HS_HOST_ACK                \ [0x05] ACK response received/transmitted interrupt
    $06 constant OTG_HS_HOST_NYET               \ [0x06] Response received interrupt
    $07 constant OTG_HS_HOST_TXERR              \ [0x07] Transaction error
    $08 constant OTG_HS_HOST_BBERR              \ [0x08] Babble error
    $09 constant OTG_HS_HOST_FRMOR              \ [0x09] Frame overrun
    $0a constant OTG_HS_HOST_DTERR              \ [0x0a] Data toggle error
  [then]


  [ifdef] OTG_HS_HOST_OTG_HS_HCINTMSK3_DEF
    \
    \ @brief OTG_HS host channel-3 interrupt mask register
    \ Address offset: 0x16C
    \ Reset value: 0x00000000
    \
    $00 constant OTG_HS_HOST_XFRCM              \ [0x00] Transfer completed mask
    $01 constant OTG_HS_HOST_CHHM               \ [0x01] Channel halted mask
    $02 constant OTG_HS_HOST_AHBERRM            \ [0x02] AHB error
    $03 constant OTG_HS_HOST_STALLM             \ [0x03] STALL response received interrupt mask
    $04 constant OTG_HS_HOST_NAKM               \ [0x04] NAK response received interrupt mask
    $05 constant OTG_HS_HOST_ACKM               \ [0x05] ACK response received/transmitted interrupt mask
    $06 constant OTG_HS_HOST_NYET               \ [0x06] response received interrupt mask
    $07 constant OTG_HS_HOST_TXERRM             \ [0x07] Transaction error mask
    $08 constant OTG_HS_HOST_BBERRM             \ [0x08] Babble error mask
    $09 constant OTG_HS_HOST_FRMORM             \ [0x09] Frame overrun mask
    $0a constant OTG_HS_HOST_DTERRM             \ [0x0a] Data toggle error mask
  [then]


  [ifdef] OTG_HS_HOST_OTG_HS_HCTSIZ3_DEF
    \
    \ @brief OTG_HS host channel-3 transfer size register
    \ Address offset: 0x170
    \ Reset value: 0x00000000
    \
    $00 constant OTG_HS_HOST_XFRSIZ             \ [0x00 : 19] Transfer size
    $13 constant OTG_HS_HOST_PKTCNT             \ [0x13 : 10] Packet count
    $1d constant OTG_HS_HOST_DPID               \ [0x1d : 2] Data PID
  [then]


  [ifdef] OTG_HS_HOST_OTG_HS_HCDMA3_DEF
    \
    \ @brief OTG_HS host channel-3 DMA address register
    \ Address offset: 0x174
    \ Reset value: 0x00000000
    \
    $00 constant OTG_HS_HOST_DMAADDR            \ [0x00 : 32] DMA address
  [then]


  [ifdef] OTG_HS_HOST_OTG_HS_HCCHAR4_DEF
    \
    \ @brief OTG_HS host channel-4 characteristics register
    \ Address offset: 0x180
    \ Reset value: 0x00000000
    \
    $00 constant OTG_HS_HOST_MPSIZ              \ [0x00 : 11] Maximum packet size
    $0b constant OTG_HS_HOST_EPNUM              \ [0x0b : 4] Endpoint number
    $0f constant OTG_HS_HOST_EPDIR              \ [0x0f] Endpoint direction
    $11 constant OTG_HS_HOST_LSDEV              \ [0x11] Low-speed device
    $12 constant OTG_HS_HOST_EPTYP              \ [0x12 : 2] Endpoint type
    $14 constant OTG_HS_HOST_MCNT               \ [0x14 : 2] Multi Count (MC) / Error Count (EC)
    $16 constant OTG_HS_HOST_DAD                \ [0x16 : 7] Device address
    $1d constant OTG_HS_HOST_ODDFRM             \ [0x1d] Odd frame
    $1e constant OTG_HS_HOST_CHDIS              \ [0x1e] Channel disable
    $1f constant OTG_HS_HOST_CHENA              \ [0x1f] Channel enable
  [then]


  [ifdef] OTG_HS_HOST_OTG_HS_HCSPLT4_DEF
    \
    \ @brief OTG_HS host channel-4 split control register
    \ Address offset: 0x184
    \ Reset value: 0x00000000
    \
    $00 constant OTG_HS_HOST_PRTADDR            \ [0x00 : 7] Port address
    $07 constant OTG_HS_HOST_HUBADDR            \ [0x07 : 7] Hub address
    $0e constant OTG_HS_HOST_XACTPOS            \ [0x0e : 2] XACTPOS
    $10 constant OTG_HS_HOST_COMPLSPLT          \ [0x10] Do complete split
    $1f constant OTG_HS_HOST_SPLITEN            \ [0x1f] Split enable
  [then]


  [ifdef] OTG_HS_HOST_OTG_HS_HCINT4_DEF
    \
    \ @brief OTG_HS host channel-4 interrupt register
    \ Address offset: 0x188
    \ Reset value: 0x00000000
    \
    $00 constant OTG_HS_HOST_XFRC               \ [0x00] Transfer completed
    $01 constant OTG_HS_HOST_CHH                \ [0x01] Channel halted
    $02 constant OTG_HS_HOST_AHBERR             \ [0x02] AHB error
    $03 constant OTG_HS_HOST_STALL              \ [0x03] STALL response received interrupt
    $04 constant OTG_HS_HOST_NAK                \ [0x04] NAK response received interrupt
    $05 constant OTG_HS_HOST_ACK                \ [0x05] ACK response received/transmitted interrupt
    $06 constant OTG_HS_HOST_NYET               \ [0x06] Response received interrupt
    $07 constant OTG_HS_HOST_TXERR              \ [0x07] Transaction error
    $08 constant OTG_HS_HOST_BBERR              \ [0x08] Babble error
    $09 constant OTG_HS_HOST_FRMOR              \ [0x09] Frame overrun
    $0a constant OTG_HS_HOST_DTERR              \ [0x0a] Data toggle error
  [then]


  [ifdef] OTG_HS_HOST_OTG_HS_HCINTMSK4_DEF
    \
    \ @brief OTG_HS host channel-4 interrupt mask register
    \ Address offset: 0x18C
    \ Reset value: 0x00000000
    \
    $00 constant OTG_HS_HOST_XFRCM              \ [0x00] Transfer completed mask
    $01 constant OTG_HS_HOST_CHHM               \ [0x01] Channel halted mask
    $02 constant OTG_HS_HOST_AHBERRM            \ [0x02] AHB error
    $03 constant OTG_HS_HOST_STALLM             \ [0x03] STALL response received interrupt mask
    $04 constant OTG_HS_HOST_NAKM               \ [0x04] NAK response received interrupt mask
    $05 constant OTG_HS_HOST_ACKM               \ [0x05] ACK response received/transmitted interrupt mask
    $06 constant OTG_HS_HOST_NYET               \ [0x06] response received interrupt mask
    $07 constant OTG_HS_HOST_TXERRM             \ [0x07] Transaction error mask
    $08 constant OTG_HS_HOST_BBERRM             \ [0x08] Babble error mask
    $09 constant OTG_HS_HOST_FRMORM             \ [0x09] Frame overrun mask
    $0a constant OTG_HS_HOST_DTERRM             \ [0x0a] Data toggle error mask
  [then]


  [ifdef] OTG_HS_HOST_OTG_HS_HCTSIZ4_DEF
    \
    \ @brief OTG_HS host channel-4 transfer size register
    \ Address offset: 0x190
    \ Reset value: 0x00000000
    \
    $00 constant OTG_HS_HOST_XFRSIZ             \ [0x00 : 19] Transfer size
    $13 constant OTG_HS_HOST_PKTCNT             \ [0x13 : 10] Packet count
    $1d constant OTG_HS_HOST_DPID               \ [0x1d : 2] Data PID
  [then]


  [ifdef] OTG_HS_HOST_OTG_HS_HCDMA4_DEF
    \
    \ @brief OTG_HS host channel-4 DMA address register
    \ Address offset: 0x194
    \ Reset value: 0x00000000
    \
    $00 constant OTG_HS_HOST_DMAADDR            \ [0x00 : 32] DMA address
  [then]


  [ifdef] OTG_HS_HOST_OTG_HS_HCCHAR5_DEF
    \
    \ @brief OTG_HS host channel-5 characteristics register
    \ Address offset: 0x1A0
    \ Reset value: 0x00000000
    \
    $00 constant OTG_HS_HOST_MPSIZ              \ [0x00 : 11] Maximum packet size
    $0b constant OTG_HS_HOST_EPNUM              \ [0x0b : 4] Endpoint number
    $0f constant OTG_HS_HOST_EPDIR              \ [0x0f] Endpoint direction
    $11 constant OTG_HS_HOST_LSDEV              \ [0x11] Low-speed device
    $12 constant OTG_HS_HOST_EPTYP              \ [0x12 : 2] Endpoint type
    $14 constant OTG_HS_HOST_MCNT               \ [0x14 : 2] Multi Count (MC) / Error Count (EC)
    $16 constant OTG_HS_HOST_DAD                \ [0x16 : 7] Device address
    $1d constant OTG_HS_HOST_ODDFRM             \ [0x1d] Odd frame
    $1e constant OTG_HS_HOST_CHDIS              \ [0x1e] Channel disable
    $1f constant OTG_HS_HOST_CHENA              \ [0x1f] Channel enable
  [then]


  [ifdef] OTG_HS_HOST_OTG_HS_HCSPLT5_DEF
    \
    \ @brief OTG_HS host channel-5 split control register
    \ Address offset: 0x1A4
    \ Reset value: 0x00000000
    \
    $00 constant OTG_HS_HOST_PRTADDR            \ [0x00 : 7] Port address
    $07 constant OTG_HS_HOST_HUBADDR            \ [0x07 : 7] Hub address
    $0e constant OTG_HS_HOST_XACTPOS            \ [0x0e : 2] XACTPOS
    $10 constant OTG_HS_HOST_COMPLSPLT          \ [0x10] Do complete split
    $1f constant OTG_HS_HOST_SPLITEN            \ [0x1f] Split enable
  [then]


  [ifdef] OTG_HS_HOST_OTG_HS_HCINT5_DEF
    \
    \ @brief OTG_HS host channel-5 interrupt register
    \ Address offset: 0x1A8
    \ Reset value: 0x00000000
    \
    $00 constant OTG_HS_HOST_XFRC               \ [0x00] Transfer completed
    $01 constant OTG_HS_HOST_CHH                \ [0x01] Channel halted
    $02 constant OTG_HS_HOST_AHBERR             \ [0x02] AHB error
    $03 constant OTG_HS_HOST_STALL              \ [0x03] STALL response received interrupt
    $04 constant OTG_HS_HOST_NAK                \ [0x04] NAK response received interrupt
    $05 constant OTG_HS_HOST_ACK                \ [0x05] ACK response received/transmitted interrupt
    $06 constant OTG_HS_HOST_NYET               \ [0x06] Response received interrupt
    $07 constant OTG_HS_HOST_TXERR              \ [0x07] Transaction error
    $08 constant OTG_HS_HOST_BBERR              \ [0x08] Babble error
    $09 constant OTG_HS_HOST_FRMOR              \ [0x09] Frame overrun
    $0a constant OTG_HS_HOST_DTERR              \ [0x0a] Data toggle error
  [then]


  [ifdef] OTG_HS_HOST_OTG_HS_HCINTMSK5_DEF
    \
    \ @brief OTG_HS host channel-5 interrupt mask register
    \ Address offset: 0x1AC
    \ Reset value: 0x00000000
    \
    $00 constant OTG_HS_HOST_XFRCM              \ [0x00] Transfer completed mask
    $01 constant OTG_HS_HOST_CHHM               \ [0x01] Channel halted mask
    $02 constant OTG_HS_HOST_AHBERRM            \ [0x02] AHB error
    $03 constant OTG_HS_HOST_STALLM             \ [0x03] STALL response received interrupt mask
    $04 constant OTG_HS_HOST_NAKM               \ [0x04] NAK response received interrupt mask
    $05 constant OTG_HS_HOST_ACKM               \ [0x05] ACK response received/transmitted interrupt mask
    $06 constant OTG_HS_HOST_NYET               \ [0x06] response received interrupt mask
    $07 constant OTG_HS_HOST_TXERRM             \ [0x07] Transaction error mask
    $08 constant OTG_HS_HOST_BBERRM             \ [0x08] Babble error mask
    $09 constant OTG_HS_HOST_FRMORM             \ [0x09] Frame overrun mask
    $0a constant OTG_HS_HOST_DTERRM             \ [0x0a] Data toggle error mask
  [then]


  [ifdef] OTG_HS_HOST_OTG_HS_HCTSIZ5_DEF
    \
    \ @brief OTG_HS host channel-5 transfer size register
    \ Address offset: 0x1B0
    \ Reset value: 0x00000000
    \
    $00 constant OTG_HS_HOST_XFRSIZ             \ [0x00 : 19] Transfer size
    $13 constant OTG_HS_HOST_PKTCNT             \ [0x13 : 10] Packet count
    $1d constant OTG_HS_HOST_DPID               \ [0x1d : 2] Data PID
  [then]


  [ifdef] OTG_HS_HOST_OTG_HS_HCDMA5_DEF
    \
    \ @brief OTG_HS host channel-5 DMA address register
    \ Address offset: 0x1B4
    \ Reset value: 0x00000000
    \
    $00 constant OTG_HS_HOST_DMAADDR            \ [0x00 : 32] DMA address
  [then]


  [ifdef] OTG_HS_HOST_OTG_HS_HCCHAR6_DEF
    \
    \ @brief OTG_HS host channel-6 characteristics register
    \ Address offset: 0x1C0
    \ Reset value: 0x00000000
    \
    $00 constant OTG_HS_HOST_MPSIZ              \ [0x00 : 11] Maximum packet size
    $0b constant OTG_HS_HOST_EPNUM              \ [0x0b : 4] Endpoint number
    $0f constant OTG_HS_HOST_EPDIR              \ [0x0f] Endpoint direction
    $11 constant OTG_HS_HOST_LSDEV              \ [0x11] Low-speed device
    $12 constant OTG_HS_HOST_EPTYP              \ [0x12 : 2] Endpoint type
    $14 constant OTG_HS_HOST_MCNT               \ [0x14 : 2] Multi Count (MC) / Error Count (EC)
    $16 constant OTG_HS_HOST_DAD                \ [0x16 : 7] Device address
    $1d constant OTG_HS_HOST_ODDFRM             \ [0x1d] Odd frame
    $1e constant OTG_HS_HOST_CHDIS              \ [0x1e] Channel disable
    $1f constant OTG_HS_HOST_CHENA              \ [0x1f] Channel enable
  [then]


  [ifdef] OTG_HS_HOST_OTG_HS_HCSPLT6_DEF
    \
    \ @brief OTG_HS host channel-6 split control register
    \ Address offset: 0x1C4
    \ Reset value: 0x00000000
    \
    $00 constant OTG_HS_HOST_PRTADDR            \ [0x00 : 7] Port address
    $07 constant OTG_HS_HOST_HUBADDR            \ [0x07 : 7] Hub address
    $0e constant OTG_HS_HOST_XACTPOS            \ [0x0e : 2] XACTPOS
    $10 constant OTG_HS_HOST_COMPLSPLT          \ [0x10] Do complete split
    $1f constant OTG_HS_HOST_SPLITEN            \ [0x1f] Split enable
  [then]


  [ifdef] OTG_HS_HOST_OTG_HS_HCINT6_DEF
    \
    \ @brief OTG_HS host channel-6 interrupt register
    \ Address offset: 0x1C8
    \ Reset value: 0x00000000
    \
    $00 constant OTG_HS_HOST_XFRC               \ [0x00] Transfer completed
    $01 constant OTG_HS_HOST_CHH                \ [0x01] Channel halted
    $02 constant OTG_HS_HOST_AHBERR             \ [0x02] AHB error
    $03 constant OTG_HS_HOST_STALL              \ [0x03] STALL response received interrupt
    $04 constant OTG_HS_HOST_NAK                \ [0x04] NAK response received interrupt
    $05 constant OTG_HS_HOST_ACK                \ [0x05] ACK response received/transmitted interrupt
    $06 constant OTG_HS_HOST_NYET               \ [0x06] Response received interrupt
    $07 constant OTG_HS_HOST_TXERR              \ [0x07] Transaction error
    $08 constant OTG_HS_HOST_BBERR              \ [0x08] Babble error
    $09 constant OTG_HS_HOST_FRMOR              \ [0x09] Frame overrun
    $0a constant OTG_HS_HOST_DTERR              \ [0x0a] Data toggle error
  [then]


  [ifdef] OTG_HS_HOST_OTG_HS_HCINTMSK6_DEF
    \
    \ @brief OTG_HS host channel-6 interrupt mask register
    \ Address offset: 0x1CC
    \ Reset value: 0x00000000
    \
    $00 constant OTG_HS_HOST_XFRCM              \ [0x00] Transfer completed mask
    $01 constant OTG_HS_HOST_CHHM               \ [0x01] Channel halted mask
    $02 constant OTG_HS_HOST_AHBERRM            \ [0x02] AHB error
    $03 constant OTG_HS_HOST_STALLM             \ [0x03] STALL response received interrupt mask
    $04 constant OTG_HS_HOST_NAKM               \ [0x04] NAK response received interrupt mask
    $05 constant OTG_HS_HOST_ACKM               \ [0x05] ACK response received/transmitted interrupt mask
    $06 constant OTG_HS_HOST_NYET               \ [0x06] response received interrupt mask
    $07 constant OTG_HS_HOST_TXERRM             \ [0x07] Transaction error mask
    $08 constant OTG_HS_HOST_BBERRM             \ [0x08] Babble error mask
    $09 constant OTG_HS_HOST_FRMORM             \ [0x09] Frame overrun mask
    $0a constant OTG_HS_HOST_DTERRM             \ [0x0a] Data toggle error mask
  [then]


  [ifdef] OTG_HS_HOST_OTG_HS_HCTSIZ6_DEF
    \
    \ @brief OTG_HS host channel-6 transfer size register
    \ Address offset: 0x1D0
    \ Reset value: 0x00000000
    \
    $00 constant OTG_HS_HOST_XFRSIZ             \ [0x00 : 19] Transfer size
    $13 constant OTG_HS_HOST_PKTCNT             \ [0x13 : 10] Packet count
    $1d constant OTG_HS_HOST_DPID               \ [0x1d : 2] Data PID
  [then]


  [ifdef] OTG_HS_HOST_OTG_HS_HCDMA6_DEF
    \
    \ @brief OTG_HS host channel-6 DMA address register
    \ Address offset: 0x1D4
    \ Reset value: 0x00000000
    \
    $00 constant OTG_HS_HOST_DMAADDR            \ [0x00 : 32] DMA address
  [then]


  [ifdef] OTG_HS_HOST_OTG_HS_HCCHAR7_DEF
    \
    \ @brief OTG_HS host channel-7 characteristics register
    \ Address offset: 0x1E0
    \ Reset value: 0x00000000
    \
    $00 constant OTG_HS_HOST_MPSIZ              \ [0x00 : 11] Maximum packet size
    $0b constant OTG_HS_HOST_EPNUM              \ [0x0b : 4] Endpoint number
    $0f constant OTG_HS_HOST_EPDIR              \ [0x0f] Endpoint direction
    $11 constant OTG_HS_HOST_LSDEV              \ [0x11] Low-speed device
    $12 constant OTG_HS_HOST_EPTYP              \ [0x12 : 2] Endpoint type
    $14 constant OTG_HS_HOST_MCNT               \ [0x14 : 2] Multi Count (MC) / Error Count (EC)
    $16 constant OTG_HS_HOST_DAD                \ [0x16 : 7] Device address
    $1d constant OTG_HS_HOST_ODDFRM             \ [0x1d] Odd frame
    $1e constant OTG_HS_HOST_CHDIS              \ [0x1e] Channel disable
    $1f constant OTG_HS_HOST_CHENA              \ [0x1f] Channel enable
  [then]


  [ifdef] OTG_HS_HOST_OTG_HS_HCSPLT7_DEF
    \
    \ @brief OTG_HS host channel-7 split control register
    \ Address offset: 0x1E4
    \ Reset value: 0x00000000
    \
    $00 constant OTG_HS_HOST_PRTADDR            \ [0x00 : 7] Port address
    $07 constant OTG_HS_HOST_HUBADDR            \ [0x07 : 7] Hub address
    $0e constant OTG_HS_HOST_XACTPOS            \ [0x0e : 2] XACTPOS
    $10 constant OTG_HS_HOST_COMPLSPLT          \ [0x10] Do complete split
    $1f constant OTG_HS_HOST_SPLITEN            \ [0x1f] Split enable
  [then]


  [ifdef] OTG_HS_HOST_OTG_HS_HCINT7_DEF
    \
    \ @brief OTG_HS host channel-7 interrupt register
    \ Address offset: 0x1E8
    \ Reset value: 0x00000000
    \
    $00 constant OTG_HS_HOST_XFRC               \ [0x00] Transfer completed
    $01 constant OTG_HS_HOST_CHH                \ [0x01] Channel halted
    $02 constant OTG_HS_HOST_AHBERR             \ [0x02] AHB error
    $03 constant OTG_HS_HOST_STALL              \ [0x03] STALL response received interrupt
    $04 constant OTG_HS_HOST_NAK                \ [0x04] NAK response received interrupt
    $05 constant OTG_HS_HOST_ACK                \ [0x05] ACK response received/transmitted interrupt
    $06 constant OTG_HS_HOST_NYET               \ [0x06] Response received interrupt
    $07 constant OTG_HS_HOST_TXERR              \ [0x07] Transaction error
    $08 constant OTG_HS_HOST_BBERR              \ [0x08] Babble error
    $09 constant OTG_HS_HOST_FRMOR              \ [0x09] Frame overrun
    $0a constant OTG_HS_HOST_DTERR              \ [0x0a] Data toggle error
  [then]


  [ifdef] OTG_HS_HOST_OTG_HS_HCINTMSK7_DEF
    \
    \ @brief OTG_HS host channel-7 interrupt mask register
    \ Address offset: 0x1EC
    \ Reset value: 0x00000000
    \
    $00 constant OTG_HS_HOST_XFRCM              \ [0x00] Transfer completed mask
    $01 constant OTG_HS_HOST_CHHM               \ [0x01] Channel halted mask
    $02 constant OTG_HS_HOST_AHBERRM            \ [0x02] AHB error
    $03 constant OTG_HS_HOST_STALLM             \ [0x03] STALL response received interrupt mask
    $04 constant OTG_HS_HOST_NAKM               \ [0x04] NAK response received interrupt mask
    $05 constant OTG_HS_HOST_ACKM               \ [0x05] ACK response received/transmitted interrupt mask
    $06 constant OTG_HS_HOST_NYET               \ [0x06] response received interrupt mask
    $07 constant OTG_HS_HOST_TXERRM             \ [0x07] Transaction error mask
    $08 constant OTG_HS_HOST_BBERRM             \ [0x08] Babble error mask
    $09 constant OTG_HS_HOST_FRMORM             \ [0x09] Frame overrun mask
    $0a constant OTG_HS_HOST_DTERRM             \ [0x0a] Data toggle error mask
  [then]


  [ifdef] OTG_HS_HOST_OTG_HS_HCTSIZ7_DEF
    \
    \ @brief OTG_HS host channel-7 transfer size register
    \ Address offset: 0x1F0
    \ Reset value: 0x00000000
    \
    $00 constant OTG_HS_HOST_XFRSIZ             \ [0x00 : 19] Transfer size
    $13 constant OTG_HS_HOST_PKTCNT             \ [0x13 : 10] Packet count
    $1d constant OTG_HS_HOST_DPID               \ [0x1d : 2] Data PID
  [then]


  [ifdef] OTG_HS_HOST_OTG_HS_HCDMA7_DEF
    \
    \ @brief OTG_HS host channel-7 DMA address register
    \ Address offset: 0x1F4
    \ Reset value: 0x00000000
    \
    $00 constant OTG_HS_HOST_DMAADDR            \ [0x00 : 32] DMA address
  [then]


  [ifdef] OTG_HS_HOST_OTG_HS_HCCHAR8_DEF
    \
    \ @brief OTG_HS host channel-8 characteristics register
    \ Address offset: 0x200
    \ Reset value: 0x00000000
    \
    $00 constant OTG_HS_HOST_MPSIZ              \ [0x00 : 11] Maximum packet size
    $0b constant OTG_HS_HOST_EPNUM              \ [0x0b : 4] Endpoint number
    $0f constant OTG_HS_HOST_EPDIR              \ [0x0f] Endpoint direction
    $11 constant OTG_HS_HOST_LSDEV              \ [0x11] Low-speed device
    $12 constant OTG_HS_HOST_EPTYP              \ [0x12 : 2] Endpoint type
    $14 constant OTG_HS_HOST_MCNT               \ [0x14 : 2] Multi Count (MC) / Error Count (EC)
    $16 constant OTG_HS_HOST_DAD                \ [0x16 : 7] Device address
    $1d constant OTG_HS_HOST_ODDFRM             \ [0x1d] Odd frame
    $1e constant OTG_HS_HOST_CHDIS              \ [0x1e] Channel disable
    $1f constant OTG_HS_HOST_CHENA              \ [0x1f] Channel enable
  [then]


  [ifdef] OTG_HS_HOST_OTG_HS_HCSPLT8_DEF
    \
    \ @brief OTG_HS host channel-8 split control register
    \ Address offset: 0x204
    \ Reset value: 0x00000000
    \
    $00 constant OTG_HS_HOST_PRTADDR            \ [0x00 : 7] Port address
    $07 constant OTG_HS_HOST_HUBADDR            \ [0x07 : 7] Hub address
    $0e constant OTG_HS_HOST_XACTPOS            \ [0x0e : 2] XACTPOS
    $10 constant OTG_HS_HOST_COMPLSPLT          \ [0x10] Do complete split
    $1f constant OTG_HS_HOST_SPLITEN            \ [0x1f] Split enable
  [then]


  [ifdef] OTG_HS_HOST_OTG_HS_HCINT8_DEF
    \
    \ @brief OTG_HS host channel-8 interrupt register
    \ Address offset: 0x208
    \ Reset value: 0x00000000
    \
    $00 constant OTG_HS_HOST_XFRC               \ [0x00] Transfer completed
    $01 constant OTG_HS_HOST_CHH                \ [0x01] Channel halted
    $02 constant OTG_HS_HOST_AHBERR             \ [0x02] AHB error
    $03 constant OTG_HS_HOST_STALL              \ [0x03] STALL response received interrupt
    $04 constant OTG_HS_HOST_NAK                \ [0x04] NAK response received interrupt
    $05 constant OTG_HS_HOST_ACK                \ [0x05] ACK response received/transmitted interrupt
    $06 constant OTG_HS_HOST_NYET               \ [0x06] Response received interrupt
    $07 constant OTG_HS_HOST_TXERR              \ [0x07] Transaction error
    $08 constant OTG_HS_HOST_BBERR              \ [0x08] Babble error
    $09 constant OTG_HS_HOST_FRMOR              \ [0x09] Frame overrun
    $0a constant OTG_HS_HOST_DTERR              \ [0x0a] Data toggle error
  [then]


  [ifdef] OTG_HS_HOST_OTG_HS_HCINTMSK8_DEF
    \
    \ @brief OTG_HS host channel-8 interrupt mask register
    \ Address offset: 0x20C
    \ Reset value: 0x00000000
    \
    $00 constant OTG_HS_HOST_XFRCM              \ [0x00] Transfer completed mask
    $01 constant OTG_HS_HOST_CHHM               \ [0x01] Channel halted mask
    $02 constant OTG_HS_HOST_AHBERRM            \ [0x02] AHB error
    $03 constant OTG_HS_HOST_STALLM             \ [0x03] STALL response received interrupt mask
    $04 constant OTG_HS_HOST_NAKM               \ [0x04] NAK response received interrupt mask
    $05 constant OTG_HS_HOST_ACKM               \ [0x05] ACK response received/transmitted interrupt mask
    $06 constant OTG_HS_HOST_NYET               \ [0x06] response received interrupt mask
    $07 constant OTG_HS_HOST_TXERRM             \ [0x07] Transaction error mask
    $08 constant OTG_HS_HOST_BBERRM             \ [0x08] Babble error mask
    $09 constant OTG_HS_HOST_FRMORM             \ [0x09] Frame overrun mask
    $0a constant OTG_HS_HOST_DTERRM             \ [0x0a] Data toggle error mask
  [then]


  [ifdef] OTG_HS_HOST_OTG_HS_HCTSIZ8_DEF
    \
    \ @brief OTG_HS host channel-8 transfer size register
    \ Address offset: 0x210
    \ Reset value: 0x00000000
    \
    $00 constant OTG_HS_HOST_XFRSIZ             \ [0x00 : 19] Transfer size
    $13 constant OTG_HS_HOST_PKTCNT             \ [0x13 : 10] Packet count
    $1d constant OTG_HS_HOST_DPID               \ [0x1d : 2] Data PID
  [then]


  [ifdef] OTG_HS_HOST_OTG_HS_HCDMA8_DEF
    \
    \ @brief OTG_HS host channel-8 DMA address register
    \ Address offset: 0x214
    \ Reset value: 0x00000000
    \
    $00 constant OTG_HS_HOST_DMAADDR            \ [0x00 : 32] DMA address
  [then]


  [ifdef] OTG_HS_HOST_OTG_HS_HCCHAR9_DEF
    \
    \ @brief OTG_HS host channel-9 characteristics register
    \ Address offset: 0x220
    \ Reset value: 0x00000000
    \
    $00 constant OTG_HS_HOST_MPSIZ              \ [0x00 : 11] Maximum packet size
    $0b constant OTG_HS_HOST_EPNUM              \ [0x0b : 4] Endpoint number
    $0f constant OTG_HS_HOST_EPDIR              \ [0x0f] Endpoint direction
    $11 constant OTG_HS_HOST_LSDEV              \ [0x11] Low-speed device
    $12 constant OTG_HS_HOST_EPTYP              \ [0x12 : 2] Endpoint type
    $14 constant OTG_HS_HOST_MCNT               \ [0x14 : 2] Multi Count (MC) / Error Count (EC)
    $16 constant OTG_HS_HOST_DAD                \ [0x16 : 7] Device address
    $1d constant OTG_HS_HOST_ODDFRM             \ [0x1d] Odd frame
    $1e constant OTG_HS_HOST_CHDIS              \ [0x1e] Channel disable
    $1f constant OTG_HS_HOST_CHENA              \ [0x1f] Channel enable
  [then]


  [ifdef] OTG_HS_HOST_OTG_HS_HCSPLT9_DEF
    \
    \ @brief OTG_HS host channel-9 split control register
    \ Address offset: 0x224
    \ Reset value: 0x00000000
    \
    $00 constant OTG_HS_HOST_PRTADDR            \ [0x00 : 7] Port address
    $07 constant OTG_HS_HOST_HUBADDR            \ [0x07 : 7] Hub address
    $0e constant OTG_HS_HOST_XACTPOS            \ [0x0e : 2] XACTPOS
    $10 constant OTG_HS_HOST_COMPLSPLT          \ [0x10] Do complete split
    $1f constant OTG_HS_HOST_SPLITEN            \ [0x1f] Split enable
  [then]


  [ifdef] OTG_HS_HOST_OTG_HS_HCINT9_DEF
    \
    \ @brief OTG_HS host channel-9 interrupt register
    \ Address offset: 0x228
    \ Reset value: 0x00000000
    \
    $00 constant OTG_HS_HOST_XFRC               \ [0x00] Transfer completed
    $01 constant OTG_HS_HOST_CHH                \ [0x01] Channel halted
    $02 constant OTG_HS_HOST_AHBERR             \ [0x02] AHB error
    $03 constant OTG_HS_HOST_STALL              \ [0x03] STALL response received interrupt
    $04 constant OTG_HS_HOST_NAK                \ [0x04] NAK response received interrupt
    $05 constant OTG_HS_HOST_ACK                \ [0x05] ACK response received/transmitted interrupt
    $06 constant OTG_HS_HOST_NYET               \ [0x06] Response received interrupt
    $07 constant OTG_HS_HOST_TXERR              \ [0x07] Transaction error
    $08 constant OTG_HS_HOST_BBERR              \ [0x08] Babble error
    $09 constant OTG_HS_HOST_FRMOR              \ [0x09] Frame overrun
    $0a constant OTG_HS_HOST_DTERR              \ [0x0a] Data toggle error
  [then]


  [ifdef] OTG_HS_HOST_OTG_HS_HCINTMSK9_DEF
    \
    \ @brief OTG_HS host channel-9 interrupt mask register
    \ Address offset: 0x22C
    \ Reset value: 0x00000000
    \
    $00 constant OTG_HS_HOST_XFRCM              \ [0x00] Transfer completed mask
    $01 constant OTG_HS_HOST_CHHM               \ [0x01] Channel halted mask
    $02 constant OTG_HS_HOST_AHBERRM            \ [0x02] AHB error
    $03 constant OTG_HS_HOST_STALLM             \ [0x03] STALL response received interrupt mask
    $04 constant OTG_HS_HOST_NAKM               \ [0x04] NAK response received interrupt mask
    $05 constant OTG_HS_HOST_ACKM               \ [0x05] ACK response received/transmitted interrupt mask
    $06 constant OTG_HS_HOST_NYET               \ [0x06] response received interrupt mask
    $07 constant OTG_HS_HOST_TXERRM             \ [0x07] Transaction error mask
    $08 constant OTG_HS_HOST_BBERRM             \ [0x08] Babble error mask
    $09 constant OTG_HS_HOST_FRMORM             \ [0x09] Frame overrun mask
    $0a constant OTG_HS_HOST_DTERRM             \ [0x0a] Data toggle error mask
  [then]


  [ifdef] OTG_HS_HOST_OTG_HS_HCTSIZ9_DEF
    \
    \ @brief OTG_HS host channel-9 transfer size register
    \ Address offset: 0x230
    \ Reset value: 0x00000000
    \
    $00 constant OTG_HS_HOST_XFRSIZ             \ [0x00 : 19] Transfer size
    $13 constant OTG_HS_HOST_PKTCNT             \ [0x13 : 10] Packet count
    $1d constant OTG_HS_HOST_DPID               \ [0x1d : 2] Data PID
  [then]


  [ifdef] OTG_HS_HOST_OTG_HS_HCDMA9_DEF
    \
    \ @brief OTG_HS host channel-9 DMA address register
    \ Address offset: 0x234
    \ Reset value: 0x00000000
    \
    $00 constant OTG_HS_HOST_DMAADDR            \ [0x00 : 32] DMA address
  [then]


  [ifdef] OTG_HS_HOST_OTG_HS_HCCHAR10_DEF
    \
    \ @brief OTG_HS host channel-10 characteristics register
    \ Address offset: 0x240
    \ Reset value: 0x00000000
    \
    $00 constant OTG_HS_HOST_MPSIZ              \ [0x00 : 11] Maximum packet size
    $0b constant OTG_HS_HOST_EPNUM              \ [0x0b : 4] Endpoint number
    $0f constant OTG_HS_HOST_EPDIR              \ [0x0f] Endpoint direction
    $11 constant OTG_HS_HOST_LSDEV              \ [0x11] Low-speed device
    $12 constant OTG_HS_HOST_EPTYP              \ [0x12 : 2] Endpoint type
    $14 constant OTG_HS_HOST_MCNT               \ [0x14 : 2] Multi Count (MC) / Error Count (EC)
    $16 constant OTG_HS_HOST_DAD                \ [0x16 : 7] Device address
    $1d constant OTG_HS_HOST_ODDFRM             \ [0x1d] Odd frame
    $1e constant OTG_HS_HOST_CHDIS              \ [0x1e] Channel disable
    $1f constant OTG_HS_HOST_CHENA              \ [0x1f] Channel enable
  [then]


  [ifdef] OTG_HS_HOST_OTG_HS_HCSPLT10_DEF
    \
    \ @brief OTG_HS host channel-10 split control register
    \ Address offset: 0x244
    \ Reset value: 0x00000000
    \
    $00 constant OTG_HS_HOST_PRTADDR            \ [0x00 : 7] Port address
    $07 constant OTG_HS_HOST_HUBADDR            \ [0x07 : 7] Hub address
    $0e constant OTG_HS_HOST_XACTPOS            \ [0x0e : 2] XACTPOS
    $10 constant OTG_HS_HOST_COMPLSPLT          \ [0x10] Do complete split
    $1f constant OTG_HS_HOST_SPLITEN            \ [0x1f] Split enable
  [then]


  [ifdef] OTG_HS_HOST_OTG_HS_HCINT10_DEF
    \
    \ @brief OTG_HS host channel-10 interrupt register
    \ Address offset: 0x248
    \ Reset value: 0x00000000
    \
    $00 constant OTG_HS_HOST_XFRC               \ [0x00] Transfer completed
    $01 constant OTG_HS_HOST_CHH                \ [0x01] Channel halted
    $02 constant OTG_HS_HOST_AHBERR             \ [0x02] AHB error
    $03 constant OTG_HS_HOST_STALL              \ [0x03] STALL response received interrupt
    $04 constant OTG_HS_HOST_NAK                \ [0x04] NAK response received interrupt
    $05 constant OTG_HS_HOST_ACK                \ [0x05] ACK response received/transmitted interrupt
    $06 constant OTG_HS_HOST_NYET               \ [0x06] Response received interrupt
    $07 constant OTG_HS_HOST_TXERR              \ [0x07] Transaction error
    $08 constant OTG_HS_HOST_BBERR              \ [0x08] Babble error
    $09 constant OTG_HS_HOST_FRMOR              \ [0x09] Frame overrun
    $0a constant OTG_HS_HOST_DTERR              \ [0x0a] Data toggle error
  [then]


  [ifdef] OTG_HS_HOST_OTG_HS_HCINTMSK10_DEF
    \
    \ @brief OTG_HS host channel-10 interrupt mask register
    \ Address offset: 0x24C
    \ Reset value: 0x00000000
    \
    $00 constant OTG_HS_HOST_XFRCM              \ [0x00] Transfer completed mask
    $01 constant OTG_HS_HOST_CHHM               \ [0x01] Channel halted mask
    $02 constant OTG_HS_HOST_AHBERRM            \ [0x02] AHB error
    $03 constant OTG_HS_HOST_STALLM             \ [0x03] STALL response received interrupt mask
    $04 constant OTG_HS_HOST_NAKM               \ [0x04] NAK response received interrupt mask
    $05 constant OTG_HS_HOST_ACKM               \ [0x05] ACK response received/transmitted interrupt mask
    $06 constant OTG_HS_HOST_NYET               \ [0x06] response received interrupt mask
    $07 constant OTG_HS_HOST_TXERRM             \ [0x07] Transaction error mask
    $08 constant OTG_HS_HOST_BBERRM             \ [0x08] Babble error mask
    $09 constant OTG_HS_HOST_FRMORM             \ [0x09] Frame overrun mask
    $0a constant OTG_HS_HOST_DTERRM             \ [0x0a] Data toggle error mask
  [then]


  [ifdef] OTG_HS_HOST_OTG_HS_HCTSIZ10_DEF
    \
    \ @brief OTG_HS host channel-10 transfer size register
    \ Address offset: 0x250
    \ Reset value: 0x00000000
    \
    $00 constant OTG_HS_HOST_XFRSIZ             \ [0x00 : 19] Transfer size
    $13 constant OTG_HS_HOST_PKTCNT             \ [0x13 : 10] Packet count
    $1d constant OTG_HS_HOST_DPID               \ [0x1d : 2] Data PID
  [then]


  [ifdef] OTG_HS_HOST_OTG_HS_HCDMA10_DEF
    \
    \ @brief OTG_HS host channel-10 DMA address register
    \ Address offset: 0x254
    \ Reset value: 0x00000000
    \
    $00 constant OTG_HS_HOST_DMAADDR            \ [0x00 : 32] DMA address
  [then]


  [ifdef] OTG_HS_HOST_OTG_HS_HCCHAR11_DEF
    \
    \ @brief OTG_HS host channel-11 characteristics register
    \ Address offset: 0x260
    \ Reset value: 0x00000000
    \
    $00 constant OTG_HS_HOST_MPSIZ              \ [0x00 : 11] Maximum packet size
    $0b constant OTG_HS_HOST_EPNUM              \ [0x0b : 4] Endpoint number
    $0f constant OTG_HS_HOST_EPDIR              \ [0x0f] Endpoint direction
    $11 constant OTG_HS_HOST_LSDEV              \ [0x11] Low-speed device
    $12 constant OTG_HS_HOST_EPTYP              \ [0x12 : 2] Endpoint type
    $14 constant OTG_HS_HOST_MCNT               \ [0x14 : 2] Multi Count (MC) / Error Count (EC)
    $16 constant OTG_HS_HOST_DAD                \ [0x16 : 7] Device address
    $1d constant OTG_HS_HOST_ODDFRM             \ [0x1d] Odd frame
    $1e constant OTG_HS_HOST_CHDIS              \ [0x1e] Channel disable
    $1f constant OTG_HS_HOST_CHENA              \ [0x1f] Channel enable
  [then]


  [ifdef] OTG_HS_HOST_OTG_HS_HCSPLT11_DEF
    \
    \ @brief OTG_HS host channel-11 split control register
    \ Address offset: 0x264
    \ Reset value: 0x00000000
    \
    $00 constant OTG_HS_HOST_PRTADDR            \ [0x00 : 7] Port address
    $07 constant OTG_HS_HOST_HUBADDR            \ [0x07 : 7] Hub address
    $0e constant OTG_HS_HOST_XACTPOS            \ [0x0e : 2] XACTPOS
    $10 constant OTG_HS_HOST_COMPLSPLT          \ [0x10] Do complete split
    $1f constant OTG_HS_HOST_SPLITEN            \ [0x1f] Split enable
  [then]


  [ifdef] OTG_HS_HOST_OTG_HS_HCINT11_DEF
    \
    \ @brief OTG_HS host channel-11 interrupt register
    \ Address offset: 0x268
    \ Reset value: 0x00000000
    \
    $00 constant OTG_HS_HOST_XFRC               \ [0x00] Transfer completed
    $01 constant OTG_HS_HOST_CHH                \ [0x01] Channel halted
    $02 constant OTG_HS_HOST_AHBERR             \ [0x02] AHB error
    $03 constant OTG_HS_HOST_STALL              \ [0x03] STALL response received interrupt
    $04 constant OTG_HS_HOST_NAK                \ [0x04] NAK response received interrupt
    $05 constant OTG_HS_HOST_ACK                \ [0x05] ACK response received/transmitted interrupt
    $06 constant OTG_HS_HOST_NYET               \ [0x06] Response received interrupt
    $07 constant OTG_HS_HOST_TXERR              \ [0x07] Transaction error
    $08 constant OTG_HS_HOST_BBERR              \ [0x08] Babble error
    $09 constant OTG_HS_HOST_FRMOR              \ [0x09] Frame overrun
    $0a constant OTG_HS_HOST_DTERR              \ [0x0a] Data toggle error
  [then]


  [ifdef] OTG_HS_HOST_OTG_HS_HCINTMSK11_DEF
    \
    \ @brief OTG_HS host channel-11 interrupt mask register
    \ Address offset: 0x26C
    \ Reset value: 0x00000000
    \
    $00 constant OTG_HS_HOST_XFRCM              \ [0x00] Transfer completed mask
    $01 constant OTG_HS_HOST_CHHM               \ [0x01] Channel halted mask
    $02 constant OTG_HS_HOST_AHBERRM            \ [0x02] AHB error
    $03 constant OTG_HS_HOST_STALLM             \ [0x03] STALL response received interrupt mask
    $04 constant OTG_HS_HOST_NAKM               \ [0x04] NAK response received interrupt mask
    $05 constant OTG_HS_HOST_ACKM               \ [0x05] ACK response received/transmitted interrupt mask
    $06 constant OTG_HS_HOST_NYET               \ [0x06] response received interrupt mask
    $07 constant OTG_HS_HOST_TXERRM             \ [0x07] Transaction error mask
    $08 constant OTG_HS_HOST_BBERRM             \ [0x08] Babble error mask
    $09 constant OTG_HS_HOST_FRMORM             \ [0x09] Frame overrun mask
    $0a constant OTG_HS_HOST_DTERRM             \ [0x0a] Data toggle error mask
  [then]


  [ifdef] OTG_HS_HOST_OTG_HS_HCTSIZ11_DEF
    \
    \ @brief OTG_HS host channel-11 transfer size register
    \ Address offset: 0x270
    \ Reset value: 0x00000000
    \
    $00 constant OTG_HS_HOST_XFRSIZ             \ [0x00 : 19] Transfer size
    $13 constant OTG_HS_HOST_PKTCNT             \ [0x13 : 10] Packet count
    $1d constant OTG_HS_HOST_DPID               \ [0x1d : 2] Data PID
  [then]


  [ifdef] OTG_HS_HOST_OTG_HS_HCDMA11_DEF
    \
    \ @brief OTG_HS host channel-11 DMA address register
    \ Address offset: 0x274
    \ Reset value: 0x00000000
    \
    $00 constant OTG_HS_HOST_DMAADDR            \ [0x00 : 32] DMA address
  [then]


  [ifdef] OTG_HS_HOST_OTG_HS_HCCHAR12_DEF
    \
    \ @brief OTG_HS host channel-12 characteristics register
    \ Address offset: 0x280
    \ Reset value: 0x00000000
    \
    $00 constant OTG_HS_HOST_MPSIZ              \ [0x00 : 11] Maximum packet size
    $0b constant OTG_HS_HOST_EPNUM              \ [0x0b : 4] Endpoint number
    $0f constant OTG_HS_HOST_EPDIR              \ [0x0f] Endpoint direction
    $11 constant OTG_HS_HOST_LSDEV              \ [0x11] Low-speed device
    $12 constant OTG_HS_HOST_EPTYP              \ [0x12 : 2] Endpoint type
    $14 constant OTG_HS_HOST_MCNT               \ [0x14 : 2] Multi Count (MC) / Error Count (EC)
    $16 constant OTG_HS_HOST_DAD                \ [0x16 : 7] Device address
    $1d constant OTG_HS_HOST_ODDFRM             \ [0x1d] Odd frame
    $1e constant OTG_HS_HOST_CHDIS              \ [0x1e] Channel disable
    $1f constant OTG_HS_HOST_CHENA              \ [0x1f] Channel enable
  [then]


  [ifdef] OTG_HS_HOST_OTG_HS_HCSPLT12_DEF
    \
    \ @brief OTG_HS host channel-12 split control register
    \ Address offset: 0x284
    \ Reset value: 0x00000000
    \
    $00 constant OTG_HS_HOST_PRTADDR            \ [0x00 : 7] Port address
    $07 constant OTG_HS_HOST_HUBADDR            \ [0x07 : 7] Hub address
    $0e constant OTG_HS_HOST_XACTPOS            \ [0x0e : 2] XACTPOS
    $10 constant OTG_HS_HOST_COMPLSPLT          \ [0x10] Do complete split
    $1f constant OTG_HS_HOST_SPLITEN            \ [0x1f] Split enable
  [then]


  [ifdef] OTG_HS_HOST_OTG_HS_HCINT12_DEF
    \
    \ @brief OTG_HS host channel-12 interrupt register
    \ Address offset: 0x288
    \ Reset value: 0x00000000
    \
    $00 constant OTG_HS_HOST_XFRC               \ [0x00] Transfer completed
    $01 constant OTG_HS_HOST_CHH                \ [0x01] Channel halted
    $02 constant OTG_HS_HOST_AHBERR             \ [0x02] AHB error
    $03 constant OTG_HS_HOST_STALL              \ [0x03] STALL response received interrupt
    $04 constant OTG_HS_HOST_NAK                \ [0x04] NAK response received interrupt
    $05 constant OTG_HS_HOST_ACK                \ [0x05] ACK response received/transmitted interrupt
    $06 constant OTG_HS_HOST_NYET               \ [0x06] Response received interrupt
    $07 constant OTG_HS_HOST_TXERR              \ [0x07] Transaction error
    $08 constant OTG_HS_HOST_BBERR              \ [0x08] Babble error
    $09 constant OTG_HS_HOST_FRMOR              \ [0x09] Frame overrun
    $0a constant OTG_HS_HOST_DTERR              \ [0x0a] Data toggle error
  [then]


  [ifdef] OTG_HS_HOST_OTG_HS_HCINTMSK12_DEF
    \
    \ @brief OTG_HS host channel-12 interrupt mask register
    \ Address offset: 0x28C
    \ Reset value: 0x00000000
    \
    $00 constant OTG_HS_HOST_XFRCM              \ [0x00] Transfer completed mask
    $01 constant OTG_HS_HOST_CHHM               \ [0x01] Channel halted mask
    $02 constant OTG_HS_HOST_AHBERRM            \ [0x02] AHB error
    $03 constant OTG_HS_HOST_STALLM             \ [0x03] STALL response received interrupt mask
    $04 constant OTG_HS_HOST_NAKM               \ [0x04] NAK response received interrupt mask
    $05 constant OTG_HS_HOST_ACKM               \ [0x05] ACK response received/transmitted interrupt mask
    $06 constant OTG_HS_HOST_NYET               \ [0x06] response received interrupt mask
    $07 constant OTG_HS_HOST_TXERRM             \ [0x07] Transaction error mask
    $08 constant OTG_HS_HOST_BBERRM             \ [0x08] Babble error mask
    $09 constant OTG_HS_HOST_FRMORM             \ [0x09] Frame overrun mask
    $0a constant OTG_HS_HOST_DTERRM             \ [0x0a] Data toggle error mask
  [then]


  [ifdef] OTG_HS_HOST_OTG_HS_HCTSIZ12_DEF
    \
    \ @brief OTG_HS host channel-12 transfer size register
    \ Address offset: 0x290
    \ Reset value: 0x00000000
    \
    $00 constant OTG_HS_HOST_XFRSIZ             \ [0x00 : 19] Transfer size
    $13 constant OTG_HS_HOST_PKTCNT             \ [0x13 : 10] Packet count
    $1d constant OTG_HS_HOST_DPID               \ [0x1d : 2] Data PID
  [then]


  [ifdef] OTG_HS_HOST_OTG_HS_HCDMA12_DEF
    \
    \ @brief OTG_HS host channel-12 DMA address register
    \ Address offset: 0x294
    \ Reset value: 0x00000000
    \
    $00 constant OTG_HS_HOST_DMAADDR            \ [0x00 : 32] DMA address
  [then]


  [ifdef] OTG_HS_HOST_OTG_HS_HCCHAR13_DEF
    \
    \ @brief OTG_HS host channel-13 characteristics register
    \ Address offset: 0x2A0
    \ Reset value: 0x00000000
    \
    $00 constant OTG_HS_HOST_MPSIZ              \ [0x00 : 11] Maximum packet size
    $0b constant OTG_HS_HOST_EPNUM              \ [0x0b : 4] Endpoint number
    $0f constant OTG_HS_HOST_EPDIR              \ [0x0f] Endpoint direction
    $11 constant OTG_HS_HOST_LSDEV              \ [0x11] Low-speed device
    $12 constant OTG_HS_HOST_EPTYP              \ [0x12 : 2] Endpoint type
    $14 constant OTG_HS_HOST_MCNT               \ [0x14 : 2] Multi Count (MC) / Error Count (EC)
    $16 constant OTG_HS_HOST_DAD                \ [0x16 : 7] Device address
    $1d constant OTG_HS_HOST_ODDFRM             \ [0x1d] Odd frame
    $1e constant OTG_HS_HOST_CHDIS              \ [0x1e] Channel disable
    $1f constant OTG_HS_HOST_CHENA              \ [0x1f] Channel enable
  [then]


  [ifdef] OTG_HS_HOST_OTG_HS_HCSPLT13_DEF
    \
    \ @brief OTG_HS host channel-13 split control register
    \ Address offset: 0x2A4
    \ Reset value: 0x00000000
    \
    $00 constant OTG_HS_HOST_PRTADDR            \ [0x00 : 7] Port address
    $07 constant OTG_HS_HOST_HUBADDR            \ [0x07 : 7] Hub address
    $0e constant OTG_HS_HOST_XACTPOS            \ [0x0e : 2] XACTPOS
    $10 constant OTG_HS_HOST_COMPLSPLT          \ [0x10] Do complete split
    $1f constant OTG_HS_HOST_SPLITEN            \ [0x1f] Split enable
  [then]


  [ifdef] OTG_HS_HOST_OTG_HS_HCINT13_DEF
    \
    \ @brief OTG_HS host channel-13 interrupt register
    \ Address offset: 0x2A8
    \ Reset value: 0x00000000
    \
    $00 constant OTG_HS_HOST_XFRC               \ [0x00] Transfer completed
    $01 constant OTG_HS_HOST_CHH                \ [0x01] Channel halted
    $02 constant OTG_HS_HOST_AHBERR             \ [0x02] AHB error
    $03 constant OTG_HS_HOST_STALL              \ [0x03] STALL response received interrupt
    $04 constant OTG_HS_HOST_NAK                \ [0x04] NAK response received interrupt
    $05 constant OTG_HS_HOST_ACK                \ [0x05] ACK response received/transmitted interrupt
    $06 constant OTG_HS_HOST_NYET               \ [0x06] Response received interrupt
    $07 constant OTG_HS_HOST_TXERR              \ [0x07] Transaction error
    $08 constant OTG_HS_HOST_BBERR              \ [0x08] Babble error
    $09 constant OTG_HS_HOST_FRMOR              \ [0x09] Frame overrun
    $0a constant OTG_HS_HOST_DTERR              \ [0x0a] Data toggle error
  [then]


  [ifdef] OTG_HS_HOST_OTG_HS_HCINTMSK13_DEF
    \
    \ @brief OTG_HS host channel-13 interrupt mask register
    \ Address offset: 0x2AC
    \ Reset value: 0x00000000
    \
    $00 constant OTG_HS_HOST_XFRCM              \ [0x00] Transfer completed mask
    $01 constant OTG_HS_HOST_CHHM               \ [0x01] Channel halted mask
    $02 constant OTG_HS_HOST_AHBERRM            \ [0x02] AHB error
    $03 constant OTG_HS_HOST_STALLM             \ [0x03] STALL response received interrupt mask
    $04 constant OTG_HS_HOST_NAKM               \ [0x04] NAK response received interrupt mask
    $05 constant OTG_HS_HOST_ACKM               \ [0x05] ACK response received/transmitted interrupt mask
    $06 constant OTG_HS_HOST_NYET               \ [0x06] response received interrupt mask
    $07 constant OTG_HS_HOST_TXERRM             \ [0x07] Transaction error mask
    $08 constant OTG_HS_HOST_BBERRM             \ [0x08] Babble error mask
    $09 constant OTG_HS_HOST_FRMORM             \ [0x09] Frame overrun mask
    $0a constant OTG_HS_HOST_DTERRM             \ [0x0a] Data toggle error mask
  [then]


  [ifdef] OTG_HS_HOST_OTG_HS_HCTSIZ13_DEF
    \
    \ @brief OTG_HS host channel-13 transfer size register
    \ Address offset: 0x2B0
    \ Reset value: 0x00000000
    \
    $00 constant OTG_HS_HOST_XFRSIZ             \ [0x00 : 19] Transfer size
    $13 constant OTG_HS_HOST_PKTCNT             \ [0x13 : 10] Packet count
    $1d constant OTG_HS_HOST_DPID               \ [0x1d : 2] Data PID
  [then]


  [ifdef] OTG_HS_HOST_OTG_HS_HCDMA13_DEF
    \
    \ @brief OTG_HS host channel-13 DMA address register
    \ Address offset: 0x2B4
    \ Reset value: 0x00000000
    \
    $00 constant OTG_HS_HOST_DMAADDR            \ [0x00 : 32] DMA address
  [then]


  [ifdef] OTG_HS_HOST_OTG_HS_HCCHAR14_DEF
    \
    \ @brief OTG_HS host channel-14 characteristics register
    \ Address offset: 0x2C0
    \ Reset value: 0x00000000
    \
    $00 constant OTG_HS_HOST_MPSIZ              \ [0x00 : 11] Maximum packet size
    $0b constant OTG_HS_HOST_EPNUM              \ [0x0b : 4] Endpoint number
    $0f constant OTG_HS_HOST_EPDIR              \ [0x0f] Endpoint direction
    $11 constant OTG_HS_HOST_LSDEV              \ [0x11] Low-speed device
    $12 constant OTG_HS_HOST_EPTYP              \ [0x12 : 2] Endpoint type
    $14 constant OTG_HS_HOST_MCNT               \ [0x14 : 2] Multi Count (MC) / Error Count (EC)
    $16 constant OTG_HS_HOST_DAD                \ [0x16 : 7] Device address
    $1d constant OTG_HS_HOST_ODDFRM             \ [0x1d] Odd frame
    $1e constant OTG_HS_HOST_CHDIS              \ [0x1e] Channel disable
    $1f constant OTG_HS_HOST_CHENA              \ [0x1f] Channel enable
  [then]


  [ifdef] OTG_HS_HOST_OTG_HS_HCSPLT14_DEF
    \
    \ @brief OTG_HS host channel-14 split control register
    \ Address offset: 0x2C4
    \ Reset value: 0x00000000
    \
    $00 constant OTG_HS_HOST_PRTADDR            \ [0x00 : 7] Port address
    $07 constant OTG_HS_HOST_HUBADDR            \ [0x07 : 7] Hub address
    $0e constant OTG_HS_HOST_XACTPOS            \ [0x0e : 2] XACTPOS
    $10 constant OTG_HS_HOST_COMPLSPLT          \ [0x10] Do complete split
    $1f constant OTG_HS_HOST_SPLITEN            \ [0x1f] Split enable
  [then]


  [ifdef] OTG_HS_HOST_OTG_HS_HCINT14_DEF
    \
    \ @brief OTG_HS host channel-14 interrupt register
    \ Address offset: 0x2C8
    \ Reset value: 0x00000000
    \
    $00 constant OTG_HS_HOST_XFRC               \ [0x00] Transfer completed
    $01 constant OTG_HS_HOST_CHH                \ [0x01] Channel halted
    $02 constant OTG_HS_HOST_AHBERR             \ [0x02] AHB error
    $03 constant OTG_HS_HOST_STALL              \ [0x03] STALL response received interrupt
    $04 constant OTG_HS_HOST_NAK                \ [0x04] NAK response received interrupt
    $05 constant OTG_HS_HOST_ACK                \ [0x05] ACK response received/transmitted interrupt
    $06 constant OTG_HS_HOST_NYET               \ [0x06] Response received interrupt
    $07 constant OTG_HS_HOST_TXERR              \ [0x07] Transaction error
    $08 constant OTG_HS_HOST_BBERR              \ [0x08] Babble error
    $09 constant OTG_HS_HOST_FRMOR              \ [0x09] Frame overrun
    $0a constant OTG_HS_HOST_DTERR              \ [0x0a] Data toggle error
  [then]


  [ifdef] OTG_HS_HOST_OTG_HS_HCINTMSK14_DEF
    \
    \ @brief OTG_HS host channel-14 interrupt mask register
    \ Address offset: 0x2CC
    \ Reset value: 0x00000000
    \
    $00 constant OTG_HS_HOST_XFRCM              \ [0x00] Transfer completed mask
    $01 constant OTG_HS_HOST_CHHM               \ [0x01] Channel halted mask
    $02 constant OTG_HS_HOST_AHBERRM            \ [0x02] AHB error
    $03 constant OTG_HS_HOST_STALLM             \ [0x03] STALL response received interrupt mask
    $04 constant OTG_HS_HOST_NAKM               \ [0x04] NAK response received interrupt mask
    $05 constant OTG_HS_HOST_ACKM               \ [0x05] ACK response received/transmitted interrupt mask
    $06 constant OTG_HS_HOST_NYET               \ [0x06] response received interrupt mask
    $07 constant OTG_HS_HOST_TXERRM             \ [0x07] Transaction error mask
    $08 constant OTG_HS_HOST_BBERRM             \ [0x08] Babble error mask
    $09 constant OTG_HS_HOST_FRMORM             \ [0x09] Frame overrun mask
    $0a constant OTG_HS_HOST_DTERRM             \ [0x0a] Data toggle error mask
  [then]


  [ifdef] OTG_HS_HOST_OTG_HS_HCTSIZ14_DEF
    \
    \ @brief OTG_HS host channel-14 transfer size register
    \ Address offset: 0x2D0
    \ Reset value: 0x00000000
    \
    $00 constant OTG_HS_HOST_XFRSIZ             \ [0x00 : 19] Transfer size
    $13 constant OTG_HS_HOST_PKTCNT             \ [0x13 : 10] Packet count
    $1d constant OTG_HS_HOST_DPID               \ [0x1d : 2] Data PID
  [then]


  [ifdef] OTG_HS_HOST_OTG_HS_HCDMA14_DEF
    \
    \ @brief OTG_HS host channel-14 DMA address register
    \ Address offset: 0x2D4
    \ Reset value: 0x00000000
    \
    $00 constant OTG_HS_HOST_DMAADDR            \ [0x00 : 32] DMA address
  [then]


  [ifdef] OTG_HS_HOST_OTG_HS_HCCHAR15_DEF
    \
    \ @brief OTG_HS host channel-15 characteristics register
    \ Address offset: 0x2E0
    \ Reset value: 0x00000000
    \
    $00 constant OTG_HS_HOST_MPSIZ              \ [0x00 : 11] Maximum packet size
    $0b constant OTG_HS_HOST_EPNUM              \ [0x0b : 4] Endpoint number
    $0f constant OTG_HS_HOST_EPDIR              \ [0x0f] Endpoint direction
    $11 constant OTG_HS_HOST_LSDEV              \ [0x11] Low-speed device
    $12 constant OTG_HS_HOST_EPTYP              \ [0x12 : 2] Endpoint type
    $14 constant OTG_HS_HOST_MCNT               \ [0x14 : 2] Multi Count (MC) / Error Count (EC)
    $16 constant OTG_HS_HOST_DAD                \ [0x16 : 7] Device address
    $1d constant OTG_HS_HOST_ODDFRM             \ [0x1d] Odd frame
    $1e constant OTG_HS_HOST_CHDIS              \ [0x1e] Channel disable
    $1f constant OTG_HS_HOST_CHENA              \ [0x1f] Channel enable
  [then]


  [ifdef] OTG_HS_HOST_OTG_HS_HCSPLT15_DEF
    \
    \ @brief OTG_HS host channel-15 split control register
    \ Address offset: 0x2E4
    \ Reset value: 0x00000000
    \
    $00 constant OTG_HS_HOST_PRTADDR            \ [0x00 : 7] Port address
    $07 constant OTG_HS_HOST_HUBADDR            \ [0x07 : 7] Hub address
    $0e constant OTG_HS_HOST_XACTPOS            \ [0x0e : 2] XACTPOS
    $10 constant OTG_HS_HOST_COMPLSPLT          \ [0x10] Do complete split
    $1f constant OTG_HS_HOST_SPLITEN            \ [0x1f] Split enable
  [then]


  [ifdef] OTG_HS_HOST_OTG_HS_HCINT15_DEF
    \
    \ @brief OTG_HS host channel-15 interrupt register
    \ Address offset: 0x2E8
    \ Reset value: 0x00000000
    \
    $00 constant OTG_HS_HOST_XFRC               \ [0x00] Transfer completed
    $01 constant OTG_HS_HOST_CHH                \ [0x01] Channel halted
    $02 constant OTG_HS_HOST_AHBERR             \ [0x02] AHB error
    $03 constant OTG_HS_HOST_STALL              \ [0x03] STALL response received interrupt
    $04 constant OTG_HS_HOST_NAK                \ [0x04] NAK response received interrupt
    $05 constant OTG_HS_HOST_ACK                \ [0x05] ACK response received/transmitted interrupt
    $06 constant OTG_HS_HOST_NYET               \ [0x06] Response received interrupt
    $07 constant OTG_HS_HOST_TXERR              \ [0x07] Transaction error
    $08 constant OTG_HS_HOST_BBERR              \ [0x08] Babble error
    $09 constant OTG_HS_HOST_FRMOR              \ [0x09] Frame overrun
    $0a constant OTG_HS_HOST_DTERR              \ [0x0a] Data toggle error
  [then]


  [ifdef] OTG_HS_HOST_OTG_HS_HCINTMSK15_DEF
    \
    \ @brief OTG_HS host channel-15 interrupt mask register
    \ Address offset: 0x2EC
    \ Reset value: 0x00000000
    \
    $00 constant OTG_HS_HOST_XFRCM              \ [0x00] Transfer completed mask
    $01 constant OTG_HS_HOST_CHHM               \ [0x01] Channel halted mask
    $02 constant OTG_HS_HOST_AHBERRM            \ [0x02] AHB error
    $03 constant OTG_HS_HOST_STALLM             \ [0x03] STALL response received interrupt mask
    $04 constant OTG_HS_HOST_NAKM               \ [0x04] NAK response received interrupt mask
    $05 constant OTG_HS_HOST_ACKM               \ [0x05] ACK response received/transmitted interrupt mask
    $06 constant OTG_HS_HOST_NYET               \ [0x06] response received interrupt mask
    $07 constant OTG_HS_HOST_TXERRM             \ [0x07] Transaction error mask
    $08 constant OTG_HS_HOST_BBERRM             \ [0x08] Babble error mask
    $09 constant OTG_HS_HOST_FRMORM             \ [0x09] Frame overrun mask
    $0a constant OTG_HS_HOST_DTERRM             \ [0x0a] Data toggle error mask
  [then]


  [ifdef] OTG_HS_HOST_OTG_HS_HCTSIZ15_DEF
    \
    \ @brief OTG_HS host channel-15 transfer size register
    \ Address offset: 0x2F0
    \ Reset value: 0x00000000
    \
    $00 constant OTG_HS_HOST_XFRSIZ             \ [0x00 : 19] Transfer size
    $13 constant OTG_HS_HOST_PKTCNT             \ [0x13 : 10] Packet count
    $1d constant OTG_HS_HOST_DPID               \ [0x1d : 2] Data PID
  [then]


  [ifdef] OTG_HS_HOST_OTG_HS_HCDMA15_DEF
    \
    \ @brief OTG_HS host channel-15 DMA address register
    \ Address offset: 0x2F4
    \ Reset value: 0x00000000
    \
    $00 constant OTG_HS_HOST_DMAADDR            \ [0x00 : 32] DMA address
  [then]

  \
  \ @brief USB on the go high speed
  \
  $00 constant OTG_HS_HOST_OTG_HS_HCFG  \ OTG_HS host configuration register
  $04 constant OTG_HS_HOST_OTG_HS_HFIR  \ OTG_HS Host frame interval register
  $08 constant OTG_HS_HOST_OTG_HS_HFNUM \ OTG_HS host frame number/frame time remaining register
  $10 constant OTG_HS_HOST_OTG_HS_HPTXSTS    \ OTG_HS_Host periodic transmit FIFO/queue status register
  $14 constant OTG_HS_HOST_OTG_HS_HAINT \ OTG_HS Host all channels interrupt register
  $18 constant OTG_HS_HOST_OTG_HS_HAINTMSK    \ OTG_HS host all channels interrupt mask register
  $40 constant OTG_HS_HOST_OTG_HS_HPRT  \ OTG_HS host port control and status register
  $100 constant OTG_HS_HOST_OTG_HS_HCCHAR0    \ OTG_HS host channel-0 characteristics register
  $104 constant OTG_HS_HOST_OTG_HS_HCSPLT0    \ OTG_HS host channel-0 split control register
  $108 constant OTG_HS_HOST_OTG_HS_HCINT0    \ OTG_HS host channel-11 interrupt register
  $10C constant OTG_HS_HOST_OTG_HS_HCINTMSK0    \ OTG_HS host channel-11 interrupt mask register
  $110 constant OTG_HS_HOST_OTG_HS_HCTSIZ0    \ OTG_HS host channel-11 transfer size register
  $114 constant OTG_HS_HOST_OTG_HS_HCDMA0    \ OTG_HS host channel-0 DMA address register
  $120 constant OTG_HS_HOST_OTG_HS_HCCHAR1    \ OTG_HS host channel-1 characteristics register
  $124 constant OTG_HS_HOST_OTG_HS_HCSPLT1    \ OTG_HS host channel-1 split control register
  $128 constant OTG_HS_HOST_OTG_HS_HCINT1    \ OTG_HS host channel-1 interrupt register
  $12C constant OTG_HS_HOST_OTG_HS_HCINTMSK1    \ OTG_HS host channel-1 interrupt mask register
  $130 constant OTG_HS_HOST_OTG_HS_HCTSIZ1    \ OTG_HS host channel-1 transfer size register
  $134 constant OTG_HS_HOST_OTG_HS_HCDMA1    \ OTG_HS host channel-1 DMA address register
  $140 constant OTG_HS_HOST_OTG_HS_HCCHAR2    \ OTG_HS host channel-2 characteristics register
  $144 constant OTG_HS_HOST_OTG_HS_HCSPLT2    \ OTG_HS host channel-2 split control register
  $148 constant OTG_HS_HOST_OTG_HS_HCINT2    \ OTG_HS host channel-2 interrupt register
  $14C constant OTG_HS_HOST_OTG_HS_HCINTMSK2    \ OTG_HS host channel-2 interrupt mask register
  $150 constant OTG_HS_HOST_OTG_HS_HCTSIZ2    \ OTG_HS host channel-2 transfer size register
  $154 constant OTG_HS_HOST_OTG_HS_HCDMA2    \ OTG_HS host channel-2 DMA address register
  $160 constant OTG_HS_HOST_OTG_HS_HCCHAR3    \ OTG_HS host channel-3 characteristics register
  $164 constant OTG_HS_HOST_OTG_HS_HCSPLT3    \ OTG_HS host channel-3 split control register
  $168 constant OTG_HS_HOST_OTG_HS_HCINT3    \ OTG_HS host channel-3 interrupt register
  $16C constant OTG_HS_HOST_OTG_HS_HCINTMSK3    \ OTG_HS host channel-3 interrupt mask register
  $170 constant OTG_HS_HOST_OTG_HS_HCTSIZ3    \ OTG_HS host channel-3 transfer size register
  $174 constant OTG_HS_HOST_OTG_HS_HCDMA3    \ OTG_HS host channel-3 DMA address register
  $180 constant OTG_HS_HOST_OTG_HS_HCCHAR4    \ OTG_HS host channel-4 characteristics register
  $184 constant OTG_HS_HOST_OTG_HS_HCSPLT4    \ OTG_HS host channel-4 split control register
  $188 constant OTG_HS_HOST_OTG_HS_HCINT4    \ OTG_HS host channel-4 interrupt register
  $18C constant OTG_HS_HOST_OTG_HS_HCINTMSK4    \ OTG_HS host channel-4 interrupt mask register
  $190 constant OTG_HS_HOST_OTG_HS_HCTSIZ4    \ OTG_HS host channel-4 transfer size register
  $194 constant OTG_HS_HOST_OTG_HS_HCDMA4    \ OTG_HS host channel-4 DMA address register
  $1A0 constant OTG_HS_HOST_OTG_HS_HCCHAR5    \ OTG_HS host channel-5 characteristics register
  $1A4 constant OTG_HS_HOST_OTG_HS_HCSPLT5    \ OTG_HS host channel-5 split control register
  $1A8 constant OTG_HS_HOST_OTG_HS_HCINT5    \ OTG_HS host channel-5 interrupt register
  $1AC constant OTG_HS_HOST_OTG_HS_HCINTMSK5    \ OTG_HS host channel-5 interrupt mask register
  $1B0 constant OTG_HS_HOST_OTG_HS_HCTSIZ5    \ OTG_HS host channel-5 transfer size register
  $1B4 constant OTG_HS_HOST_OTG_HS_HCDMA5    \ OTG_HS host channel-5 DMA address register
  $1C0 constant OTG_HS_HOST_OTG_HS_HCCHAR6    \ OTG_HS host channel-6 characteristics register
  $1C4 constant OTG_HS_HOST_OTG_HS_HCSPLT6    \ OTG_HS host channel-6 split control register
  $1C8 constant OTG_HS_HOST_OTG_HS_HCINT6    \ OTG_HS host channel-6 interrupt register
  $1CC constant OTG_HS_HOST_OTG_HS_HCINTMSK6    \ OTG_HS host channel-6 interrupt mask register
  $1D0 constant OTG_HS_HOST_OTG_HS_HCTSIZ6    \ OTG_HS host channel-6 transfer size register
  $1D4 constant OTG_HS_HOST_OTG_HS_HCDMA6    \ OTG_HS host channel-6 DMA address register
  $1E0 constant OTG_HS_HOST_OTG_HS_HCCHAR7    \ OTG_HS host channel-7 characteristics register
  $1E4 constant OTG_HS_HOST_OTG_HS_HCSPLT7    \ OTG_HS host channel-7 split control register
  $1E8 constant OTG_HS_HOST_OTG_HS_HCINT7    \ OTG_HS host channel-7 interrupt register
  $1EC constant OTG_HS_HOST_OTG_HS_HCINTMSK7    \ OTG_HS host channel-7 interrupt mask register
  $1F0 constant OTG_HS_HOST_OTG_HS_HCTSIZ7    \ OTG_HS host channel-7 transfer size register
  $1F4 constant OTG_HS_HOST_OTG_HS_HCDMA7    \ OTG_HS host channel-7 DMA address register
  $200 constant OTG_HS_HOST_OTG_HS_HCCHAR8    \ OTG_HS host channel-8 characteristics register
  $204 constant OTG_HS_HOST_OTG_HS_HCSPLT8    \ OTG_HS host channel-8 split control register
  $208 constant OTG_HS_HOST_OTG_HS_HCINT8    \ OTG_HS host channel-8 interrupt register
  $20C constant OTG_HS_HOST_OTG_HS_HCINTMSK8    \ OTG_HS host channel-8 interrupt mask register
  $210 constant OTG_HS_HOST_OTG_HS_HCTSIZ8    \ OTG_HS host channel-8 transfer size register
  $214 constant OTG_HS_HOST_OTG_HS_HCDMA8    \ OTG_HS host channel-8 DMA address register
  $220 constant OTG_HS_HOST_OTG_HS_HCCHAR9    \ OTG_HS host channel-9 characteristics register
  $224 constant OTG_HS_HOST_OTG_HS_HCSPLT9    \ OTG_HS host channel-9 split control register
  $228 constant OTG_HS_HOST_OTG_HS_HCINT9    \ OTG_HS host channel-9 interrupt register
  $22C constant OTG_HS_HOST_OTG_HS_HCINTMSK9    \ OTG_HS host channel-9 interrupt mask register
  $230 constant OTG_HS_HOST_OTG_HS_HCTSIZ9    \ OTG_HS host channel-9 transfer size register
  $234 constant OTG_HS_HOST_OTG_HS_HCDMA9    \ OTG_HS host channel-9 DMA address register
  $240 constant OTG_HS_HOST_OTG_HS_HCCHAR10    \ OTG_HS host channel-10 characteristics register
  $244 constant OTG_HS_HOST_OTG_HS_HCSPLT10    \ OTG_HS host channel-10 split control register
  $248 constant OTG_HS_HOST_OTG_HS_HCINT10    \ OTG_HS host channel-10 interrupt register
  $24C constant OTG_HS_HOST_OTG_HS_HCINTMSK10    \ OTG_HS host channel-10 interrupt mask register
  $250 constant OTG_HS_HOST_OTG_HS_HCTSIZ10    \ OTG_HS host channel-10 transfer size register
  $254 constant OTG_HS_HOST_OTG_HS_HCDMA10    \ OTG_HS host channel-10 DMA address register
  $260 constant OTG_HS_HOST_OTG_HS_HCCHAR11    \ OTG_HS host channel-11 characteristics register
  $264 constant OTG_HS_HOST_OTG_HS_HCSPLT11    \ OTG_HS host channel-11 split control register
  $268 constant OTG_HS_HOST_OTG_HS_HCINT11    \ OTG_HS host channel-11 interrupt register
  $26C constant OTG_HS_HOST_OTG_HS_HCINTMSK11    \ OTG_HS host channel-11 interrupt mask register
  $270 constant OTG_HS_HOST_OTG_HS_HCTSIZ11    \ OTG_HS host channel-11 transfer size register
  $274 constant OTG_HS_HOST_OTG_HS_HCDMA11    \ OTG_HS host channel-11 DMA address register
  $280 constant OTG_HS_HOST_OTG_HS_HCCHAR12    \ OTG_HS host channel-12 characteristics register
  $284 constant OTG_HS_HOST_OTG_HS_HCSPLT12    \ OTG_HS host channel-12 split control register
  $288 constant OTG_HS_HOST_OTG_HS_HCINT12    \ OTG_HS host channel-12 interrupt register
  $28C constant OTG_HS_HOST_OTG_HS_HCINTMSK12    \ OTG_HS host channel-12 interrupt mask register
  $290 constant OTG_HS_HOST_OTG_HS_HCTSIZ12    \ OTG_HS host channel-12 transfer size register
  $294 constant OTG_HS_HOST_OTG_HS_HCDMA12    \ OTG_HS host channel-12 DMA address register
  $2A0 constant OTG_HS_HOST_OTG_HS_HCCHAR13    \ OTG_HS host channel-13 characteristics register
  $2A4 constant OTG_HS_HOST_OTG_HS_HCSPLT13    \ OTG_HS host channel-13 split control register
  $2A8 constant OTG_HS_HOST_OTG_HS_HCINT13    \ OTG_HS host channel-13 interrupt register
  $2AC constant OTG_HS_HOST_OTG_HS_HCINTMSK13    \ OTG_HS host channel-13 interrupt mask register
  $2B0 constant OTG_HS_HOST_OTG_HS_HCTSIZ13    \ OTG_HS host channel-13 transfer size register
  $2B4 constant OTG_HS_HOST_OTG_HS_HCDMA13    \ OTG_HS host channel-13 DMA address register
  $2C0 constant OTG_HS_HOST_OTG_HS_HCCHAR14    \ OTG_HS host channel-14 characteristics register
  $2C4 constant OTG_HS_HOST_OTG_HS_HCSPLT14    \ OTG_HS host channel-14 split control register
  $2C8 constant OTG_HS_HOST_OTG_HS_HCINT14    \ OTG_HS host channel-14 interrupt register
  $2CC constant OTG_HS_HOST_OTG_HS_HCINTMSK14    \ OTG_HS host channel-14 interrupt mask register
  $2D0 constant OTG_HS_HOST_OTG_HS_HCTSIZ14    \ OTG_HS host channel-14 transfer size register
  $2D4 constant OTG_HS_HOST_OTG_HS_HCDMA14    \ OTG_HS host channel-14 DMA address register
  $2E0 constant OTG_HS_HOST_OTG_HS_HCCHAR15    \ OTG_HS host channel-15 characteristics register
  $2E4 constant OTG_HS_HOST_OTG_HS_HCSPLT15    \ OTG_HS host channel-15 split control register
  $2E8 constant OTG_HS_HOST_OTG_HS_HCINT15    \ OTG_HS host channel-15 interrupt register
  $2EC constant OTG_HS_HOST_OTG_HS_HCINTMSK15    \ OTG_HS host channel-15 interrupt mask register
  $2F0 constant OTG_HS_HOST_OTG_HS_HCTSIZ15    \ OTG_HS host channel-15 transfer size register
  $2F4 constant OTG_HS_HOST_OTG_HS_HCDMA15    \ OTG_HS host channel-15 DMA address register

: OTG_HS_HOST_DEF ; [then]
