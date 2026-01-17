\
\ @file otg_fs_host.fs
\ @brief USB on the go full speed
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] OTG_FS_HOST_DEF

  [ifdef] OTG_FS_HOST_FS_HCFG_DEF
    \
    \ @brief OTG_FS host configuration register (OTG_FS_HCFG)
    \ Address offset: 0x00
    \ Reset value: 0x00000000
    \
    $00 constant OTG_FS_HOST_FSLSPCS            \ [0x00 : 2] FS/LS PHY clock select
    $02 constant OTG_FS_HOST_FSLSS              \ [0x02] FS- and LS-only support
  [then]


  [ifdef] OTG_FS_HOST_HFIR_DEF
    \
    \ @brief OTG_FS Host frame interval register
    \ Address offset: 0x04
    \ Reset value: 0x0000EA60
    \
    $00 constant OTG_FS_HOST_FRIVL              \ [0x00 : 16] Frame interval
  [then]


  [ifdef] OTG_FS_HOST_FS_HFNUM_DEF
    \
    \ @brief OTG_FS host frame number/frame time remaining register (OTG_FS_HFNUM)
    \ Address offset: 0x08
    \ Reset value: 0x00003FFF
    \
    $00 constant OTG_FS_HOST_FRNUM              \ [0x00 : 16] Frame number
    $10 constant OTG_FS_HOST_FTREM              \ [0x10 : 16] Frame time remaining
  [then]


  [ifdef] OTG_FS_HOST_FS_HPTXSTS_DEF
    \
    \ @brief OTG_FS_Host periodic transmit FIFO/queue status register (OTG_FS_HPTXSTS)
    \ Address offset: 0x10
    \ Reset value: 0x00080100
    \
    $00 constant OTG_FS_HOST_PTXFSAVL           \ [0x00 : 16] Periodic transmit data FIFO space available
    $10 constant OTG_FS_HOST_PTXQSAV            \ [0x10 : 8] Periodic transmit request queue space available
    $18 constant OTG_FS_HOST_PTXQTOP            \ [0x18 : 8] Top of the periodic transmit request queue
  [then]


  [ifdef] OTG_FS_HOST_HAINT_DEF
    \
    \ @brief OTG_FS Host all channels interrupt register
    \ Address offset: 0x14
    \ Reset value: 0x00000000
    \
    $00 constant OTG_FS_HOST_HAINT              \ [0x00 : 16] Channel interrupts
  [then]


  [ifdef] OTG_FS_HOST_HAINTMSK_DEF
    \
    \ @brief OTG_FS host all channels interrupt mask register
    \ Address offset: 0x18
    \ Reset value: 0x00000000
    \
    $00 constant OTG_FS_HOST_HAINTM             \ [0x00 : 16] Channel interrupt mask
  [then]


  [ifdef] OTG_FS_HOST_FS_HPRT_DEF
    \
    \ @brief OTG_FS host port control and status register (OTG_FS_HPRT)
    \ Address offset: 0x40
    \ Reset value: 0x00000000
    \
    $00 constant OTG_FS_HOST_PCSTS              \ [0x00] Port connect status
    $01 constant OTG_FS_HOST_PCDET              \ [0x01] Port connect detected
    $02 constant OTG_FS_HOST_PENA               \ [0x02] Port enable
    $03 constant OTG_FS_HOST_PENCHNG            \ [0x03] Port enable/disable change
    $04 constant OTG_FS_HOST_POCA               \ [0x04] Port overcurrent active
    $05 constant OTG_FS_HOST_POCCHNG            \ [0x05] Port overcurrent change
    $06 constant OTG_FS_HOST_PRES               \ [0x06] Port resume
    $07 constant OTG_FS_HOST_PSUSP              \ [0x07] Port suspend
    $08 constant OTG_FS_HOST_PRST               \ [0x08] Port reset
    $0a constant OTG_FS_HOST_PLSTS              \ [0x0a : 2] Port line status
    $0c constant OTG_FS_HOST_PPWR               \ [0x0c] Port power
    $0d constant OTG_FS_HOST_PTCTL              \ [0x0d : 4] Port test control
    $11 constant OTG_FS_HOST_PSPD               \ [0x11 : 2] Port speed
  [then]


  [ifdef] OTG_FS_HOST_FS_HCCHAR0_DEF
    \
    \ @brief OTG_FS host channel-0 characteristics register (OTG_FS_HCCHAR0)
    \ Address offset: 0x100
    \ Reset value: 0x00000000
    \
    $00 constant OTG_FS_HOST_MPSIZ              \ [0x00 : 11] Maximum packet size
    $0b constant OTG_FS_HOST_EPNUM              \ [0x0b : 4] Endpoint number
    $0f constant OTG_FS_HOST_EPDIR              \ [0x0f] Endpoint direction
    $11 constant OTG_FS_HOST_LSDEV              \ [0x11] Low-speed device
    $12 constant OTG_FS_HOST_EPTYP              \ [0x12 : 2] Endpoint type
    $14 constant OTG_FS_HOST_MCNT               \ [0x14 : 2] Multicount
    $16 constant OTG_FS_HOST_DAD                \ [0x16 : 7] Device address
    $1d constant OTG_FS_HOST_ODDFRM             \ [0x1d] Odd frame
    $1e constant OTG_FS_HOST_CHDIS              \ [0x1e] Channel disable
    $1f constant OTG_FS_HOST_CHENA              \ [0x1f] Channel enable
  [then]


  [ifdef] OTG_FS_HOST_FS_HCINT0_DEF
    \
    \ @brief OTG_FS host channel-0 interrupt register (OTG_FS_HCINT0)
    \ Address offset: 0x108
    \ Reset value: 0x00000000
    \
    $00 constant OTG_FS_HOST_XFRC               \ [0x00] Transfer completed
    $01 constant OTG_FS_HOST_CHH                \ [0x01] Channel halted
    $03 constant OTG_FS_HOST_STALL              \ [0x03] STALL response received interrupt
    $04 constant OTG_FS_HOST_NAK                \ [0x04] NAK response received interrupt
    $05 constant OTG_FS_HOST_ACK                \ [0x05] ACK response received/transmitted interrupt
    $07 constant OTG_FS_HOST_TXERR              \ [0x07] Transaction error
    $08 constant OTG_FS_HOST_BBERR              \ [0x08] Babble error
    $09 constant OTG_FS_HOST_FRMOR              \ [0x09] Frame overrun
    $0a constant OTG_FS_HOST_DTERR              \ [0x0a] Data toggle error
  [then]


  [ifdef] OTG_FS_HOST_FS_HCINTMSK0_DEF
    \
    \ @brief OTG_FS host channel-0 mask register (OTG_FS_HCINTMSK0)
    \ Address offset: 0x10C
    \ Reset value: 0x00000000
    \
    $00 constant OTG_FS_HOST_XFRCM              \ [0x00] Transfer completed mask
    $01 constant OTG_FS_HOST_CHHM               \ [0x01] Channel halted mask
    $03 constant OTG_FS_HOST_STALLM             \ [0x03] STALL response received interrupt mask
    $04 constant OTG_FS_HOST_NAKM               \ [0x04] NAK response received interrupt mask
    $05 constant OTG_FS_HOST_ACKM               \ [0x05] ACK response received/transmitted interrupt mask
    $06 constant OTG_FS_HOST_NYET               \ [0x06] response received interrupt mask
    $07 constant OTG_FS_HOST_TXERRM             \ [0x07] Transaction error mask
    $08 constant OTG_FS_HOST_BBERRM             \ [0x08] Babble error mask
    $09 constant OTG_FS_HOST_FRMORM             \ [0x09] Frame overrun mask
    $0a constant OTG_FS_HOST_DTERRM             \ [0x0a] Data toggle error mask
  [then]


  [ifdef] OTG_FS_HOST_FS_HCTSIZ0_DEF
    \
    \ @brief OTG_FS host channel-0 transfer size register
    \ Address offset: 0x110
    \ Reset value: 0x00000000
    \
    $00 constant OTG_FS_HOST_XFRSIZ             \ [0x00 : 19] Transfer size
    $13 constant OTG_FS_HOST_PKTCNT             \ [0x13 : 10] Packet count
    $1d constant OTG_FS_HOST_DPID               \ [0x1d : 2] Data PID
  [then]


  [ifdef] OTG_FS_HOST_FS_HCCHAR1_DEF
    \
    \ @brief OTG_FS host channel-1 characteristics register (OTG_FS_HCCHAR1)
    \ Address offset: 0x120
    \ Reset value: 0x00000000
    \
    $00 constant OTG_FS_HOST_MPSIZ              \ [0x00 : 11] Maximum packet size
    $0b constant OTG_FS_HOST_EPNUM              \ [0x0b : 4] Endpoint number
    $0f constant OTG_FS_HOST_EPDIR              \ [0x0f] Endpoint direction
    $11 constant OTG_FS_HOST_LSDEV              \ [0x11] Low-speed device
    $12 constant OTG_FS_HOST_EPTYP              \ [0x12 : 2] Endpoint type
    $14 constant OTG_FS_HOST_MCNT               \ [0x14 : 2] Multicount
    $16 constant OTG_FS_HOST_DAD                \ [0x16 : 7] Device address
    $1d constant OTG_FS_HOST_ODDFRM             \ [0x1d] Odd frame
    $1e constant OTG_FS_HOST_CHDIS              \ [0x1e] Channel disable
    $1f constant OTG_FS_HOST_CHENA              \ [0x1f] Channel enable
  [then]


  [ifdef] OTG_FS_HOST_FS_HCINT1_DEF
    \
    \ @brief OTG_FS host channel-1 interrupt register (OTG_FS_HCINT1)
    \ Address offset: 0x128
    \ Reset value: 0x00000000
    \
    $00 constant OTG_FS_HOST_XFRC               \ [0x00] Transfer completed
    $01 constant OTG_FS_HOST_CHH                \ [0x01] Channel halted
    $03 constant OTG_FS_HOST_STALL              \ [0x03] STALL response received interrupt
    $04 constant OTG_FS_HOST_NAK                \ [0x04] NAK response received interrupt
    $05 constant OTG_FS_HOST_ACK                \ [0x05] ACK response received/transmitted interrupt
    $07 constant OTG_FS_HOST_TXERR              \ [0x07] Transaction error
    $08 constant OTG_FS_HOST_BBERR              \ [0x08] Babble error
    $09 constant OTG_FS_HOST_FRMOR              \ [0x09] Frame overrun
    $0a constant OTG_FS_HOST_DTERR              \ [0x0a] Data toggle error
  [then]


  [ifdef] OTG_FS_HOST_FS_HCINTMSK1_DEF
    \
    \ @brief OTG_FS host channel-1 mask register (OTG_FS_HCINTMSK1)
    \ Address offset: 0x12C
    \ Reset value: 0x00000000
    \
    $00 constant OTG_FS_HOST_XFRCM              \ [0x00] Transfer completed mask
    $01 constant OTG_FS_HOST_CHHM               \ [0x01] Channel halted mask
    $03 constant OTG_FS_HOST_STALLM             \ [0x03] STALL response received interrupt mask
    $04 constant OTG_FS_HOST_NAKM               \ [0x04] NAK response received interrupt mask
    $05 constant OTG_FS_HOST_ACKM               \ [0x05] ACK response received/transmitted interrupt mask
    $06 constant OTG_FS_HOST_NYET               \ [0x06] response received interrupt mask
    $07 constant OTG_FS_HOST_TXERRM             \ [0x07] Transaction error mask
    $08 constant OTG_FS_HOST_BBERRM             \ [0x08] Babble error mask
    $09 constant OTG_FS_HOST_FRMORM             \ [0x09] Frame overrun mask
    $0a constant OTG_FS_HOST_DTERRM             \ [0x0a] Data toggle error mask
  [then]


  [ifdef] OTG_FS_HOST_FS_HCTSIZ1_DEF
    \
    \ @brief OTG_FS host channel-1 transfer size register
    \ Address offset: 0x130
    \ Reset value: 0x00000000
    \
    $00 constant OTG_FS_HOST_XFRSIZ             \ [0x00 : 19] Transfer size
    $13 constant OTG_FS_HOST_PKTCNT             \ [0x13 : 10] Packet count
    $1d constant OTG_FS_HOST_DPID               \ [0x1d : 2] Data PID
  [then]


  [ifdef] OTG_FS_HOST_FS_HCCHAR2_DEF
    \
    \ @brief OTG_FS host channel-2 characteristics register (OTG_FS_HCCHAR2)
    \ Address offset: 0x140
    \ Reset value: 0x00000000
    \
    $00 constant OTG_FS_HOST_MPSIZ              \ [0x00 : 11] Maximum packet size
    $0b constant OTG_FS_HOST_EPNUM              \ [0x0b : 4] Endpoint number
    $0f constant OTG_FS_HOST_EPDIR              \ [0x0f] Endpoint direction
    $11 constant OTG_FS_HOST_LSDEV              \ [0x11] Low-speed device
    $12 constant OTG_FS_HOST_EPTYP              \ [0x12 : 2] Endpoint type
    $14 constant OTG_FS_HOST_MCNT               \ [0x14 : 2] Multicount
    $16 constant OTG_FS_HOST_DAD                \ [0x16 : 7] Device address
    $1d constant OTG_FS_HOST_ODDFRM             \ [0x1d] Odd frame
    $1e constant OTG_FS_HOST_CHDIS              \ [0x1e] Channel disable
    $1f constant OTG_FS_HOST_CHENA              \ [0x1f] Channel enable
  [then]


  [ifdef] OTG_FS_HOST_FS_HCINT2_DEF
    \
    \ @brief OTG_FS host channel-2 interrupt register (OTG_FS_HCINT2)
    \ Address offset: 0x148
    \ Reset value: 0x00000000
    \
    $00 constant OTG_FS_HOST_XFRC               \ [0x00] Transfer completed
    $01 constant OTG_FS_HOST_CHH                \ [0x01] Channel halted
    $03 constant OTG_FS_HOST_STALL              \ [0x03] STALL response received interrupt
    $04 constant OTG_FS_HOST_NAK                \ [0x04] NAK response received interrupt
    $05 constant OTG_FS_HOST_ACK                \ [0x05] ACK response received/transmitted interrupt
    $07 constant OTG_FS_HOST_TXERR              \ [0x07] Transaction error
    $08 constant OTG_FS_HOST_BBERR              \ [0x08] Babble error
    $09 constant OTG_FS_HOST_FRMOR              \ [0x09] Frame overrun
    $0a constant OTG_FS_HOST_DTERR              \ [0x0a] Data toggle error
  [then]


  [ifdef] OTG_FS_HOST_FS_HCINTMSK2_DEF
    \
    \ @brief OTG_FS host channel-2 mask register (OTG_FS_HCINTMSK2)
    \ Address offset: 0x14C
    \ Reset value: 0x00000000
    \
    $00 constant OTG_FS_HOST_XFRCM              \ [0x00] Transfer completed mask
    $01 constant OTG_FS_HOST_CHHM               \ [0x01] Channel halted mask
    $03 constant OTG_FS_HOST_STALLM             \ [0x03] STALL response received interrupt mask
    $04 constant OTG_FS_HOST_NAKM               \ [0x04] NAK response received interrupt mask
    $05 constant OTG_FS_HOST_ACKM               \ [0x05] ACK response received/transmitted interrupt mask
    $06 constant OTG_FS_HOST_NYET               \ [0x06] response received interrupt mask
    $07 constant OTG_FS_HOST_TXERRM             \ [0x07] Transaction error mask
    $08 constant OTG_FS_HOST_BBERRM             \ [0x08] Babble error mask
    $09 constant OTG_FS_HOST_FRMORM             \ [0x09] Frame overrun mask
    $0a constant OTG_FS_HOST_DTERRM             \ [0x0a] Data toggle error mask
  [then]


  [ifdef] OTG_FS_HOST_FS_HCTSIZ2_DEF
    \
    \ @brief OTG_FS host channel-2 transfer size register
    \ Address offset: 0x150
    \ Reset value: 0x00000000
    \
    $00 constant OTG_FS_HOST_XFRSIZ             \ [0x00 : 19] Transfer size
    $13 constant OTG_FS_HOST_PKTCNT             \ [0x13 : 10] Packet count
    $1d constant OTG_FS_HOST_DPID               \ [0x1d : 2] Data PID
  [then]


  [ifdef] OTG_FS_HOST_FS_HCCHAR3_DEF
    \
    \ @brief OTG_FS host channel-3 characteristics register (OTG_FS_HCCHAR3)
    \ Address offset: 0x160
    \ Reset value: 0x00000000
    \
    $00 constant OTG_FS_HOST_MPSIZ              \ [0x00 : 11] Maximum packet size
    $0b constant OTG_FS_HOST_EPNUM              \ [0x0b : 4] Endpoint number
    $0f constant OTG_FS_HOST_EPDIR              \ [0x0f] Endpoint direction
    $11 constant OTG_FS_HOST_LSDEV              \ [0x11] Low-speed device
    $12 constant OTG_FS_HOST_EPTYP              \ [0x12 : 2] Endpoint type
    $14 constant OTG_FS_HOST_MCNT               \ [0x14 : 2] Multicount
    $16 constant OTG_FS_HOST_DAD                \ [0x16 : 7] Device address
    $1d constant OTG_FS_HOST_ODDFRM             \ [0x1d] Odd frame
    $1e constant OTG_FS_HOST_CHDIS              \ [0x1e] Channel disable
    $1f constant OTG_FS_HOST_CHENA              \ [0x1f] Channel enable
  [then]


  [ifdef] OTG_FS_HOST_FS_HCINT3_DEF
    \
    \ @brief OTG_FS host channel-3 interrupt register (OTG_FS_HCINT3)
    \ Address offset: 0x168
    \ Reset value: 0x00000000
    \
    $00 constant OTG_FS_HOST_XFRC               \ [0x00] Transfer completed
    $01 constant OTG_FS_HOST_CHH                \ [0x01] Channel halted
    $03 constant OTG_FS_HOST_STALL              \ [0x03] STALL response received interrupt
    $04 constant OTG_FS_HOST_NAK                \ [0x04] NAK response received interrupt
    $05 constant OTG_FS_HOST_ACK                \ [0x05] ACK response received/transmitted interrupt
    $07 constant OTG_FS_HOST_TXERR              \ [0x07] Transaction error
    $08 constant OTG_FS_HOST_BBERR              \ [0x08] Babble error
    $09 constant OTG_FS_HOST_FRMOR              \ [0x09] Frame overrun
    $0a constant OTG_FS_HOST_DTERR              \ [0x0a] Data toggle error
  [then]


  [ifdef] OTG_FS_HOST_FS_HCINTMSK3_DEF
    \
    \ @brief OTG_FS host channel-3 mask register (OTG_FS_HCINTMSK3)
    \ Address offset: 0x16C
    \ Reset value: 0x00000000
    \
    $00 constant OTG_FS_HOST_XFRCM              \ [0x00] Transfer completed mask
    $01 constant OTG_FS_HOST_CHHM               \ [0x01] Channel halted mask
    $03 constant OTG_FS_HOST_STALLM             \ [0x03] STALL response received interrupt mask
    $04 constant OTG_FS_HOST_NAKM               \ [0x04] NAK response received interrupt mask
    $05 constant OTG_FS_HOST_ACKM               \ [0x05] ACK response received/transmitted interrupt mask
    $06 constant OTG_FS_HOST_NYET               \ [0x06] response received interrupt mask
    $07 constant OTG_FS_HOST_TXERRM             \ [0x07] Transaction error mask
    $08 constant OTG_FS_HOST_BBERRM             \ [0x08] Babble error mask
    $09 constant OTG_FS_HOST_FRMORM             \ [0x09] Frame overrun mask
    $0a constant OTG_FS_HOST_DTERRM             \ [0x0a] Data toggle error mask
  [then]


  [ifdef] OTG_FS_HOST_FS_HCTSIZ3_DEF
    \
    \ @brief OTG_FS host channel-3 transfer size register
    \ Address offset: 0x170
    \ Reset value: 0x00000000
    \
    $00 constant OTG_FS_HOST_XFRSIZ             \ [0x00 : 19] Transfer size
    $13 constant OTG_FS_HOST_PKTCNT             \ [0x13 : 10] Packet count
    $1d constant OTG_FS_HOST_DPID               \ [0x1d : 2] Data PID
  [then]


  [ifdef] OTG_FS_HOST_FS_HCCHAR4_DEF
    \
    \ @brief OTG_FS host channel-4 characteristics register (OTG_FS_HCCHAR4)
    \ Address offset: 0x180
    \ Reset value: 0x00000000
    \
    $00 constant OTG_FS_HOST_MPSIZ              \ [0x00 : 11] Maximum packet size
    $0b constant OTG_FS_HOST_EPNUM              \ [0x0b : 4] Endpoint number
    $0f constant OTG_FS_HOST_EPDIR              \ [0x0f] Endpoint direction
    $11 constant OTG_FS_HOST_LSDEV              \ [0x11] Low-speed device
    $12 constant OTG_FS_HOST_EPTYP              \ [0x12 : 2] Endpoint type
    $14 constant OTG_FS_HOST_MCNT               \ [0x14 : 2] Multicount
    $16 constant OTG_FS_HOST_DAD                \ [0x16 : 7] Device address
    $1d constant OTG_FS_HOST_ODDFRM             \ [0x1d] Odd frame
    $1e constant OTG_FS_HOST_CHDIS              \ [0x1e] Channel disable
    $1f constant OTG_FS_HOST_CHENA              \ [0x1f] Channel enable
  [then]


  [ifdef] OTG_FS_HOST_FS_HCINT4_DEF
    \
    \ @brief OTG_FS host channel-4 interrupt register (OTG_FS_HCINT4)
    \ Address offset: 0x188
    \ Reset value: 0x00000000
    \
    $00 constant OTG_FS_HOST_XFRC               \ [0x00] Transfer completed
    $01 constant OTG_FS_HOST_CHH                \ [0x01] Channel halted
    $03 constant OTG_FS_HOST_STALL              \ [0x03] STALL response received interrupt
    $04 constant OTG_FS_HOST_NAK                \ [0x04] NAK response received interrupt
    $05 constant OTG_FS_HOST_ACK                \ [0x05] ACK response received/transmitted interrupt
    $07 constant OTG_FS_HOST_TXERR              \ [0x07] Transaction error
    $08 constant OTG_FS_HOST_BBERR              \ [0x08] Babble error
    $09 constant OTG_FS_HOST_FRMOR              \ [0x09] Frame overrun
    $0a constant OTG_FS_HOST_DTERR              \ [0x0a] Data toggle error
  [then]


  [ifdef] OTG_FS_HOST_FS_HCINTMSK4_DEF
    \
    \ @brief OTG_FS host channel-4 mask register (OTG_FS_HCINTMSK4)
    \ Address offset: 0x18C
    \ Reset value: 0x00000000
    \
    $00 constant OTG_FS_HOST_XFRCM              \ [0x00] Transfer completed mask
    $01 constant OTG_FS_HOST_CHHM               \ [0x01] Channel halted mask
    $03 constant OTG_FS_HOST_STALLM             \ [0x03] STALL response received interrupt mask
    $04 constant OTG_FS_HOST_NAKM               \ [0x04] NAK response received interrupt mask
    $05 constant OTG_FS_HOST_ACKM               \ [0x05] ACK response received/transmitted interrupt mask
    $06 constant OTG_FS_HOST_NYET               \ [0x06] response received interrupt mask
    $07 constant OTG_FS_HOST_TXERRM             \ [0x07] Transaction error mask
    $08 constant OTG_FS_HOST_BBERRM             \ [0x08] Babble error mask
    $09 constant OTG_FS_HOST_FRMORM             \ [0x09] Frame overrun mask
    $0a constant OTG_FS_HOST_DTERRM             \ [0x0a] Data toggle error mask
  [then]


  [ifdef] OTG_FS_HOST_FS_HCTSIZ4_DEF
    \
    \ @brief OTG_FS host channel-x transfer size register
    \ Address offset: 0x190
    \ Reset value: 0x00000000
    \
    $00 constant OTG_FS_HOST_XFRSIZ             \ [0x00 : 19] Transfer size
    $13 constant OTG_FS_HOST_PKTCNT             \ [0x13 : 10] Packet count
    $1d constant OTG_FS_HOST_DPID               \ [0x1d : 2] Data PID
  [then]


  [ifdef] OTG_FS_HOST_FS_HCCHAR5_DEF
    \
    \ @brief OTG_FS host channel-5 characteristics register (OTG_FS_HCCHAR5)
    \ Address offset: 0x1A0
    \ Reset value: 0x00000000
    \
    $00 constant OTG_FS_HOST_MPSIZ              \ [0x00 : 11] Maximum packet size
    $0b constant OTG_FS_HOST_EPNUM              \ [0x0b : 4] Endpoint number
    $0f constant OTG_FS_HOST_EPDIR              \ [0x0f] Endpoint direction
    $11 constant OTG_FS_HOST_LSDEV              \ [0x11] Low-speed device
    $12 constant OTG_FS_HOST_EPTYP              \ [0x12 : 2] Endpoint type
    $14 constant OTG_FS_HOST_MCNT               \ [0x14 : 2] Multicount
    $16 constant OTG_FS_HOST_DAD                \ [0x16 : 7] Device address
    $1d constant OTG_FS_HOST_ODDFRM             \ [0x1d] Odd frame
    $1e constant OTG_FS_HOST_CHDIS              \ [0x1e] Channel disable
    $1f constant OTG_FS_HOST_CHENA              \ [0x1f] Channel enable
  [then]


  [ifdef] OTG_FS_HOST_FS_HCINT5_DEF
    \
    \ @brief OTG_FS host channel-5 interrupt register (OTG_FS_HCINT5)
    \ Address offset: 0x1A8
    \ Reset value: 0x00000000
    \
    $00 constant OTG_FS_HOST_XFRC               \ [0x00] Transfer completed
    $01 constant OTG_FS_HOST_CHH                \ [0x01] Channel halted
    $03 constant OTG_FS_HOST_STALL              \ [0x03] STALL response received interrupt
    $04 constant OTG_FS_HOST_NAK                \ [0x04] NAK response received interrupt
    $05 constant OTG_FS_HOST_ACK                \ [0x05] ACK response received/transmitted interrupt
    $07 constant OTG_FS_HOST_TXERR              \ [0x07] Transaction error
    $08 constant OTG_FS_HOST_BBERR              \ [0x08] Babble error
    $09 constant OTG_FS_HOST_FRMOR              \ [0x09] Frame overrun
    $0a constant OTG_FS_HOST_DTERR              \ [0x0a] Data toggle error
  [then]


  [ifdef] OTG_FS_HOST_FS_HCINTMSK5_DEF
    \
    \ @brief OTG_FS host channel-5 mask register (OTG_FS_HCINTMSK5)
    \ Address offset: 0x1AC
    \ Reset value: 0x00000000
    \
    $00 constant OTG_FS_HOST_XFRCM              \ [0x00] Transfer completed mask
    $01 constant OTG_FS_HOST_CHHM               \ [0x01] Channel halted mask
    $03 constant OTG_FS_HOST_STALLM             \ [0x03] STALL response received interrupt mask
    $04 constant OTG_FS_HOST_NAKM               \ [0x04] NAK response received interrupt mask
    $05 constant OTG_FS_HOST_ACKM               \ [0x05] ACK response received/transmitted interrupt mask
    $06 constant OTG_FS_HOST_NYET               \ [0x06] response received interrupt mask
    $07 constant OTG_FS_HOST_TXERRM             \ [0x07] Transaction error mask
    $08 constant OTG_FS_HOST_BBERRM             \ [0x08] Babble error mask
    $09 constant OTG_FS_HOST_FRMORM             \ [0x09] Frame overrun mask
    $0a constant OTG_FS_HOST_DTERRM             \ [0x0a] Data toggle error mask
  [then]


  [ifdef] OTG_FS_HOST_FS_HCTSIZ5_DEF
    \
    \ @brief OTG_FS host channel-5 transfer size register
    \ Address offset: 0x1B0
    \ Reset value: 0x00000000
    \
    $00 constant OTG_FS_HOST_XFRSIZ             \ [0x00 : 19] Transfer size
    $13 constant OTG_FS_HOST_PKTCNT             \ [0x13 : 10] Packet count
    $1d constant OTG_FS_HOST_DPID               \ [0x1d : 2] Data PID
  [then]


  [ifdef] OTG_FS_HOST_FS_HCCHAR6_DEF
    \
    \ @brief OTG_FS host channel-6 characteristics register (OTG_FS_HCCHAR6)
    \ Address offset: 0x1C0
    \ Reset value: 0x00000000
    \
    $00 constant OTG_FS_HOST_MPSIZ              \ [0x00 : 11] Maximum packet size
    $0b constant OTG_FS_HOST_EPNUM              \ [0x0b : 4] Endpoint number
    $0f constant OTG_FS_HOST_EPDIR              \ [0x0f] Endpoint direction
    $11 constant OTG_FS_HOST_LSDEV              \ [0x11] Low-speed device
    $12 constant OTG_FS_HOST_EPTYP              \ [0x12 : 2] Endpoint type
    $14 constant OTG_FS_HOST_MCNT               \ [0x14 : 2] Multicount
    $16 constant OTG_FS_HOST_DAD                \ [0x16 : 7] Device address
    $1d constant OTG_FS_HOST_ODDFRM             \ [0x1d] Odd frame
    $1e constant OTG_FS_HOST_CHDIS              \ [0x1e] Channel disable
    $1f constant OTG_FS_HOST_CHENA              \ [0x1f] Channel enable
  [then]


  [ifdef] OTG_FS_HOST_FS_HCINT6_DEF
    \
    \ @brief OTG_FS host channel-6 interrupt register (OTG_FS_HCINT6)
    \ Address offset: 0x1C8
    \ Reset value: 0x00000000
    \
    $00 constant OTG_FS_HOST_XFRC               \ [0x00] Transfer completed
    $01 constant OTG_FS_HOST_CHH                \ [0x01] Channel halted
    $03 constant OTG_FS_HOST_STALL              \ [0x03] STALL response received interrupt
    $04 constant OTG_FS_HOST_NAK                \ [0x04] NAK response received interrupt
    $05 constant OTG_FS_HOST_ACK                \ [0x05] ACK response received/transmitted interrupt
    $07 constant OTG_FS_HOST_TXERR              \ [0x07] Transaction error
    $08 constant OTG_FS_HOST_BBERR              \ [0x08] Babble error
    $09 constant OTG_FS_HOST_FRMOR              \ [0x09] Frame overrun
    $0a constant OTG_FS_HOST_DTERR              \ [0x0a] Data toggle error
  [then]


  [ifdef] OTG_FS_HOST_FS_HCINTMSK6_DEF
    \
    \ @brief OTG_FS host channel-6 mask register (OTG_FS_HCINTMSK6)
    \ Address offset: 0x1CC
    \ Reset value: 0x00000000
    \
    $00 constant OTG_FS_HOST_XFRCM              \ [0x00] Transfer completed mask
    $01 constant OTG_FS_HOST_CHHM               \ [0x01] Channel halted mask
    $03 constant OTG_FS_HOST_STALLM             \ [0x03] STALL response received interrupt mask
    $04 constant OTG_FS_HOST_NAKM               \ [0x04] NAK response received interrupt mask
    $05 constant OTG_FS_HOST_ACKM               \ [0x05] ACK response received/transmitted interrupt mask
    $06 constant OTG_FS_HOST_NYET               \ [0x06] response received interrupt mask
    $07 constant OTG_FS_HOST_TXERRM             \ [0x07] Transaction error mask
    $08 constant OTG_FS_HOST_BBERRM             \ [0x08] Babble error mask
    $09 constant OTG_FS_HOST_FRMORM             \ [0x09] Frame overrun mask
    $0a constant OTG_FS_HOST_DTERRM             \ [0x0a] Data toggle error mask
  [then]


  [ifdef] OTG_FS_HOST_FS_HCTSIZ6_DEF
    \
    \ @brief OTG_FS host channel-6 transfer size register
    \ Address offset: 0x1D0
    \ Reset value: 0x00000000
    \
    $00 constant OTG_FS_HOST_XFRSIZ             \ [0x00 : 19] Transfer size
    $13 constant OTG_FS_HOST_PKTCNT             \ [0x13 : 10] Packet count
    $1d constant OTG_FS_HOST_DPID               \ [0x1d : 2] Data PID
  [then]


  [ifdef] OTG_FS_HOST_FS_HCCHAR7_DEF
    \
    \ @brief OTG_FS host channel-7 characteristics register (OTG_FS_HCCHAR7)
    \ Address offset: 0x1E0
    \ Reset value: 0x00000000
    \
    $00 constant OTG_FS_HOST_MPSIZ              \ [0x00 : 11] Maximum packet size
    $0b constant OTG_FS_HOST_EPNUM              \ [0x0b : 4] Endpoint number
    $0f constant OTG_FS_HOST_EPDIR              \ [0x0f] Endpoint direction
    $11 constant OTG_FS_HOST_LSDEV              \ [0x11] Low-speed device
    $12 constant OTG_FS_HOST_EPTYP              \ [0x12 : 2] Endpoint type
    $14 constant OTG_FS_HOST_MCNT               \ [0x14 : 2] Multicount
    $16 constant OTG_FS_HOST_DAD                \ [0x16 : 7] Device address
    $1d constant OTG_FS_HOST_ODDFRM             \ [0x1d] Odd frame
    $1e constant OTG_FS_HOST_CHDIS              \ [0x1e] Channel disable
    $1f constant OTG_FS_HOST_CHENA              \ [0x1f] Channel enable
  [then]


  [ifdef] OTG_FS_HOST_FS_HCINT7_DEF
    \
    \ @brief OTG_FS host channel-7 interrupt register (OTG_FS_HCINT7)
    \ Address offset: 0x1E8
    \ Reset value: 0x00000000
    \
    $00 constant OTG_FS_HOST_XFRC               \ [0x00] Transfer completed
    $01 constant OTG_FS_HOST_CHH                \ [0x01] Channel halted
    $03 constant OTG_FS_HOST_STALL              \ [0x03] STALL response received interrupt
    $04 constant OTG_FS_HOST_NAK                \ [0x04] NAK response received interrupt
    $05 constant OTG_FS_HOST_ACK                \ [0x05] ACK response received/transmitted interrupt
    $07 constant OTG_FS_HOST_TXERR              \ [0x07] Transaction error
    $08 constant OTG_FS_HOST_BBERR              \ [0x08] Babble error
    $09 constant OTG_FS_HOST_FRMOR              \ [0x09] Frame overrun
    $0a constant OTG_FS_HOST_DTERR              \ [0x0a] Data toggle error
  [then]


  [ifdef] OTG_FS_HOST_FS_HCINTMSK7_DEF
    \
    \ @brief OTG_FS host channel-7 mask register (OTG_FS_HCINTMSK7)
    \ Address offset: 0x1EC
    \ Reset value: 0x00000000
    \
    $00 constant OTG_FS_HOST_XFRCM              \ [0x00] Transfer completed mask
    $01 constant OTG_FS_HOST_CHHM               \ [0x01] Channel halted mask
    $03 constant OTG_FS_HOST_STALLM             \ [0x03] STALL response received interrupt mask
    $04 constant OTG_FS_HOST_NAKM               \ [0x04] NAK response received interrupt mask
    $05 constant OTG_FS_HOST_ACKM               \ [0x05] ACK response received/transmitted interrupt mask
    $06 constant OTG_FS_HOST_NYET               \ [0x06] response received interrupt mask
    $07 constant OTG_FS_HOST_TXERRM             \ [0x07] Transaction error mask
    $08 constant OTG_FS_HOST_BBERRM             \ [0x08] Babble error mask
    $09 constant OTG_FS_HOST_FRMORM             \ [0x09] Frame overrun mask
    $0a constant OTG_FS_HOST_DTERRM             \ [0x0a] Data toggle error mask
  [then]


  [ifdef] OTG_FS_HOST_FS_HCTSIZ7_DEF
    \
    \ @brief OTG_FS host channel-7 transfer size register
    \ Address offset: 0x1F0
    \ Reset value: 0x00000000
    \
    $00 constant OTG_FS_HOST_XFRSIZ             \ [0x00 : 19] Transfer size
    $13 constant OTG_FS_HOST_PKTCNT             \ [0x13 : 10] Packet count
    $1d constant OTG_FS_HOST_DPID               \ [0x1d : 2] Data PID
  [then]

  \
  \ @brief USB on the go full speed
  \
  $00 constant OTG_FS_HOST_FS_HCFG      \ OTG_FS host configuration register (OTG_FS_HCFG)
  $04 constant OTG_FS_HOST_HFIR         \ OTG_FS Host frame interval register
  $08 constant OTG_FS_HOST_FS_HFNUM     \ OTG_FS host frame number/frame time remaining register (OTG_FS_HFNUM)
  $10 constant OTG_FS_HOST_FS_HPTXSTS   \ OTG_FS_Host periodic transmit FIFO/queue status register (OTG_FS_HPTXSTS)
  $14 constant OTG_FS_HOST_HAINT        \ OTG_FS Host all channels interrupt register
  $18 constant OTG_FS_HOST_HAINTMSK     \ OTG_FS host all channels interrupt mask register
  $40 constant OTG_FS_HOST_FS_HPRT      \ OTG_FS host port control and status register (OTG_FS_HPRT)
  $100 constant OTG_FS_HOST_FS_HCCHAR0  \ OTG_FS host channel-0 characteristics register (OTG_FS_HCCHAR0)
  $108 constant OTG_FS_HOST_FS_HCINT0   \ OTG_FS host channel-0 interrupt register (OTG_FS_HCINT0)
  $10C constant OTG_FS_HOST_FS_HCINTMSK0    \ OTG_FS host channel-0 mask register (OTG_FS_HCINTMSK0)
  $110 constant OTG_FS_HOST_FS_HCTSIZ0  \ OTG_FS host channel-0 transfer size register
  $120 constant OTG_FS_HOST_FS_HCCHAR1  \ OTG_FS host channel-1 characteristics register (OTG_FS_HCCHAR1)
  $128 constant OTG_FS_HOST_FS_HCINT1   \ OTG_FS host channel-1 interrupt register (OTG_FS_HCINT1)
  $12C constant OTG_FS_HOST_FS_HCINTMSK1    \ OTG_FS host channel-1 mask register (OTG_FS_HCINTMSK1)
  $130 constant OTG_FS_HOST_FS_HCTSIZ1  \ OTG_FS host channel-1 transfer size register
  $140 constant OTG_FS_HOST_FS_HCCHAR2  \ OTG_FS host channel-2 characteristics register (OTG_FS_HCCHAR2)
  $148 constant OTG_FS_HOST_FS_HCINT2   \ OTG_FS host channel-2 interrupt register (OTG_FS_HCINT2)
  $14C constant OTG_FS_HOST_FS_HCINTMSK2    \ OTG_FS host channel-2 mask register (OTG_FS_HCINTMSK2)
  $150 constant OTG_FS_HOST_FS_HCTSIZ2  \ OTG_FS host channel-2 transfer size register
  $160 constant OTG_FS_HOST_FS_HCCHAR3  \ OTG_FS host channel-3 characteristics register (OTG_FS_HCCHAR3)
  $168 constant OTG_FS_HOST_FS_HCINT3   \ OTG_FS host channel-3 interrupt register (OTG_FS_HCINT3)
  $16C constant OTG_FS_HOST_FS_HCINTMSK3    \ OTG_FS host channel-3 mask register (OTG_FS_HCINTMSK3)
  $170 constant OTG_FS_HOST_FS_HCTSIZ3  \ OTG_FS host channel-3 transfer size register
  $180 constant OTG_FS_HOST_FS_HCCHAR4  \ OTG_FS host channel-4 characteristics register (OTG_FS_HCCHAR4)
  $188 constant OTG_FS_HOST_FS_HCINT4   \ OTG_FS host channel-4 interrupt register (OTG_FS_HCINT4)
  $18C constant OTG_FS_HOST_FS_HCINTMSK4    \ OTG_FS host channel-4 mask register (OTG_FS_HCINTMSK4)
  $190 constant OTG_FS_HOST_FS_HCTSIZ4  \ OTG_FS host channel-x transfer size register
  $1A0 constant OTG_FS_HOST_FS_HCCHAR5  \ OTG_FS host channel-5 characteristics register (OTG_FS_HCCHAR5)
  $1A8 constant OTG_FS_HOST_FS_HCINT5   \ OTG_FS host channel-5 interrupt register (OTG_FS_HCINT5)
  $1AC constant OTG_FS_HOST_FS_HCINTMSK5    \ OTG_FS host channel-5 mask register (OTG_FS_HCINTMSK5)
  $1B0 constant OTG_FS_HOST_FS_HCTSIZ5  \ OTG_FS host channel-5 transfer size register
  $1C0 constant OTG_FS_HOST_FS_HCCHAR6  \ OTG_FS host channel-6 characteristics register (OTG_FS_HCCHAR6)
  $1C8 constant OTG_FS_HOST_FS_HCINT6   \ OTG_FS host channel-6 interrupt register (OTG_FS_HCINT6)
  $1CC constant OTG_FS_HOST_FS_HCINTMSK6    \ OTG_FS host channel-6 mask register (OTG_FS_HCINTMSK6)
  $1D0 constant OTG_FS_HOST_FS_HCTSIZ6  \ OTG_FS host channel-6 transfer size register
  $1E0 constant OTG_FS_HOST_FS_HCCHAR7  \ OTG_FS host channel-7 characteristics register (OTG_FS_HCCHAR7)
  $1E8 constant OTG_FS_HOST_FS_HCINT7   \ OTG_FS host channel-7 interrupt register (OTG_FS_HCINT7)
  $1EC constant OTG_FS_HOST_FS_HCINTMSK7    \ OTG_FS host channel-7 mask register (OTG_FS_HCINTMSK7)
  $1F0 constant OTG_FS_HOST_FS_HCTSIZ7  \ OTG_FS host channel-7 transfer size register

: OTG_FS_HOST_DEF ; [then]
