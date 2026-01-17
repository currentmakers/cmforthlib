\
\ @file otg_fs_device.fs
\ @brief USB on the go full speed
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] OTG_FS_DEVICE_DEF

  [ifdef] OTG_FS_DEVICE_FS_DCFG_DEF
    \
    \ @brief OTG_FS device configuration register (OTG_FS_DCFG)
    \ Address offset: 0x00
    \ Reset value: 0x02200000
    \
    $00 constant OTG_FS_DEVICE_DSPD             \ [0x00 : 2] Device speed
    $02 constant OTG_FS_DEVICE_NZLSOHSK         \ [0x02] Non-zero-length status OUT handshake
    $04 constant OTG_FS_DEVICE_DAD              \ [0x04 : 7] Device address
    $0b constant OTG_FS_DEVICE_PFIVL            \ [0x0b : 2] Periodic frame interval
  [then]


  [ifdef] OTG_FS_DEVICE_FS_DCTL_DEF
    \
    \ @brief OTG_FS device control register (OTG_FS_DCTL)
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $00 constant OTG_FS_DEVICE_RWUSIG           \ [0x00] Remote wakeup signaling
    $01 constant OTG_FS_DEVICE_SDIS             \ [0x01] Soft disconnect
    $02 constant OTG_FS_DEVICE_GINSTS           \ [0x02] Global IN NAK status
    $03 constant OTG_FS_DEVICE_GONSTS           \ [0x03] Global OUT NAK status
    $04 constant OTG_FS_DEVICE_TCTL             \ [0x04 : 3] Test control
    $07 constant OTG_FS_DEVICE_SGINAK           \ [0x07] Set global IN NAK
    $08 constant OTG_FS_DEVICE_CGINAK           \ [0x08] Clear global IN NAK
    $09 constant OTG_FS_DEVICE_SGONAK           \ [0x09] Set global OUT NAK
    $0a constant OTG_FS_DEVICE_CGONAK           \ [0x0a] Clear global OUT NAK
    $0b constant OTG_FS_DEVICE_POPRGDNE         \ [0x0b] Power-on programming done
  [then]


  [ifdef] OTG_FS_DEVICE_FS_DSTS_DEF
    \
    \ @brief OTG_FS device status register (OTG_FS_DSTS)
    \ Address offset: 0x08
    \ Reset value: 0x00000010
    \
    $00 constant OTG_FS_DEVICE_SUSPSTS          \ [0x00] Suspend status
    $01 constant OTG_FS_DEVICE_ENUMSPD          \ [0x01 : 2] Enumerated speed
    $03 constant OTG_FS_DEVICE_EERR             \ [0x03] Erratic error
    $08 constant OTG_FS_DEVICE_FNSOF            \ [0x08 : 14] Frame number of the received SOF
    $16 constant OTG_FS_DEVICE_DEVLNSTS         \ [0x16 : 2] Device line status
  [then]


  [ifdef] OTG_FS_DEVICE_FS_DIEPMSK_DEF
    \
    \ @brief OTG_FS device IN endpoint common interrupt mask register (OTG_FS_DIEPMSK)
    \ Address offset: 0x10
    \ Reset value: 0x00000000
    \
    $00 constant OTG_FS_DEVICE_XFRCM            \ [0x00] Transfer completed interrupt mask
    $01 constant OTG_FS_DEVICE_EPDM             \ [0x01] Endpoint disabled interrupt mask
    $03 constant OTG_FS_DEVICE_TOM              \ [0x03] Timeout condition mask (Non-isochronous endpoints)
    $04 constant OTG_FS_DEVICE_ITTXFEMSK        \ [0x04] IN token received when TxFIFO empty mask
    $05 constant OTG_FS_DEVICE_INEPNMM          \ [0x05] IN token received with EP mismatch mask
    $06 constant OTG_FS_DEVICE_INEPNEM          \ [0x06] IN endpoint NAK effective mask
  [then]


  [ifdef] OTG_FS_DEVICE_FS_DOEPMSK_DEF
    \
    \ @brief OTG_FS device OUT endpoint common interrupt mask register (OTG_FS_DOEPMSK)
    \ Address offset: 0x14
    \ Reset value: 0x00000000
    \
    $00 constant OTG_FS_DEVICE_XFRCM            \ [0x00] Transfer completed interrupt mask
    $01 constant OTG_FS_DEVICE_EPDM             \ [0x01] Endpoint disabled interrupt mask
    $03 constant OTG_FS_DEVICE_STUPM            \ [0x03] SETUP phase done mask
    $04 constant OTG_FS_DEVICE_OTEPDM           \ [0x04] OUT token received when endpoint disabled mask
  [then]


  [ifdef] OTG_FS_DEVICE_FS_DAINT_DEF
    \
    \ @brief OTG_FS device all endpoints interrupt register (OTG_FS_DAINT)
    \ Address offset: 0x18
    \ Reset value: 0x00000000
    \
    $00 constant OTG_FS_DEVICE_IEPINT           \ [0x00 : 16] IN endpoint interrupt bits
    $10 constant OTG_FS_DEVICE_OEPINT           \ [0x10 : 16] OUT endpoint interrupt bits
  [then]


  [ifdef] OTG_FS_DEVICE_FS_DAINTMSK_DEF
    \
    \ @brief OTG_FS all endpoints interrupt mask register (OTG_FS_DAINTMSK)
    \ Address offset: 0x1C
    \ Reset value: 0x00000000
    \
    $00 constant OTG_FS_DEVICE_IEPM             \ [0x00 : 16] IN EP interrupt mask bits
    $10 constant OTG_FS_DEVICE_OEPINT           \ [0x10 : 16] OUT endpoint interrupt bits
  [then]


  [ifdef] OTG_FS_DEVICE_DVBUSDIS_DEF
    \
    \ @brief OTG_FS device VBUS discharge time register
    \ Address offset: 0x28
    \ Reset value: 0x000017D7
    \
    $00 constant OTG_FS_DEVICE_VBUSDT           \ [0x00 : 16] Device VBUS discharge time
  [then]


  [ifdef] OTG_FS_DEVICE_DVBUSPULSE_DEF
    \
    \ @brief OTG_FS device VBUS pulsing time register
    \ Address offset: 0x2C
    \ Reset value: 0x000005B8
    \
    $00 constant OTG_FS_DEVICE_DVBUSP           \ [0x00 : 12] Device VBUS pulsing time
  [then]


  [ifdef] OTG_FS_DEVICE_DIEPEMPMSK_DEF
    \
    \ @brief OTG_FS device IN endpoint FIFO empty interrupt mask register
    \ Address offset: 0x34
    \ Reset value: 0x00000000
    \
    $00 constant OTG_FS_DEVICE_INEPTXFEM        \ [0x00 : 16] IN EP Tx FIFO empty interrupt mask bits
  [then]


  [ifdef] OTG_FS_DEVICE_FS_DIEPCTL0_DEF
    \
    \ @brief OTG_FS device control IN endpoint 0 control register (OTG_FS_DIEPCTL0)
    \ Address offset: 0x100
    \ Reset value: 0x00000000
    \
    $00 constant OTG_FS_DEVICE_MPSIZ            \ [0x00 : 2] Maximum packet size
    $0f constant OTG_FS_DEVICE_USBAEP           \ [0x0f] USB active endpoint
    $11 constant OTG_FS_DEVICE_NAKSTS           \ [0x11] NAK status
    $12 constant OTG_FS_DEVICE_EPTYP            \ [0x12 : 2] Endpoint type
    $15 constant OTG_FS_DEVICE_STALL            \ [0x15] STALL handshake
    $16 constant OTG_FS_DEVICE_TXFNUM           \ [0x16 : 4] TxFIFO number
    $1a constant OTG_FS_DEVICE_CNAK             \ [0x1a] Clear NAK
    $1b constant OTG_FS_DEVICE_SNAK             \ [0x1b] Set NAK
    $1e constant OTG_FS_DEVICE_EPDIS            \ [0x1e] Endpoint disable
    $1f constant OTG_FS_DEVICE_EPENA            \ [0x1f] Endpoint enable
  [then]


  [ifdef] OTG_FS_DEVICE_DIEPINT0_DEF
    \
    \ @brief device endpoint-x interrupt register
    \ Address offset: 0x108
    \ Reset value: 0x00000080
    \
    $00 constant OTG_FS_DEVICE_XFRC             \ [0x00] XFRC
    $01 constant OTG_FS_DEVICE_EPDISD           \ [0x01] EPDISD
    $03 constant OTG_FS_DEVICE_TOC              \ [0x03] TOC
    $04 constant OTG_FS_DEVICE_ITTXFE           \ [0x04] ITTXFE
    $06 constant OTG_FS_DEVICE_INEPNE           \ [0x06] INEPNE
    $07 constant OTG_FS_DEVICE_TXFE             \ [0x07] TXFE
  [then]


  [ifdef] OTG_FS_DEVICE_DIEPTSIZ0_DEF
    \
    \ @brief device endpoint-0 transfer size register
    \ Address offset: 0x110
    \ Reset value: 0x00000000
    \
    $00 constant OTG_FS_DEVICE_XFRSIZ           \ [0x00 : 7] Transfer size
    $13 constant OTG_FS_DEVICE_PKTCNT           \ [0x13 : 2] Packet count
  [then]


  [ifdef] OTG_FS_DEVICE_DTXFSTS0_DEF
    \
    \ @brief OTG_FS device IN endpoint transmit FIFO status register
    \ Address offset: 0x118
    \ Reset value: 0x00000000
    \
    $00 constant OTG_FS_DEVICE_INEPTFSAV        \ [0x00 : 16] IN endpoint TxFIFO space available
  [then]


  [ifdef] OTG_FS_DEVICE_DIEPCTL1_DEF
    \
    \ @brief OTG device endpoint-1 control register
    \ Address offset: 0x120
    \ Reset value: 0x00000000
    \
    $00 constant OTG_FS_DEVICE_MPSIZ            \ [0x00 : 11] MPSIZ
    $0f constant OTG_FS_DEVICE_USBAEP           \ [0x0f] USBAEP
    $10 constant OTG_FS_DEVICE_EONUM_DPID       \ [0x10] EONUM/DPID
    $11 constant OTG_FS_DEVICE_NAKSTS           \ [0x11] NAKSTS
    $12 constant OTG_FS_DEVICE_EPTYP            \ [0x12 : 2] EPTYP
    $15 constant OTG_FS_DEVICE_Stall            \ [0x15] Stall
    $16 constant OTG_FS_DEVICE_TXFNUM           \ [0x16 : 4] TXFNUM
    $1a constant OTG_FS_DEVICE_CNAK             \ [0x1a] CNAK
    $1b constant OTG_FS_DEVICE_SNAK             \ [0x1b] SNAK
    $1c constant OTG_FS_DEVICE_SD0PID_SEVNFRM   \ [0x1c] SD0PID/SEVNFRM
    $1d constant OTG_FS_DEVICE_SODDFRM_SD1PID   \ [0x1d] SODDFRM/SD1PID
    $1e constant OTG_FS_DEVICE_EPDIS            \ [0x1e] EPDIS
    $1f constant OTG_FS_DEVICE_EPENA            \ [0x1f] EPENA
  [then]


  [ifdef] OTG_FS_DEVICE_DIEPINT1_DEF
    \
    \ @brief device endpoint-1 interrupt register
    \ Address offset: 0x128
    \ Reset value: 0x00000080
    \
    $00 constant OTG_FS_DEVICE_XFRC             \ [0x00] XFRC
    $01 constant OTG_FS_DEVICE_EPDISD           \ [0x01] EPDISD
    $03 constant OTG_FS_DEVICE_TOC              \ [0x03] TOC
    $04 constant OTG_FS_DEVICE_ITTXFE           \ [0x04] ITTXFE
    $06 constant OTG_FS_DEVICE_INEPNE           \ [0x06] INEPNE
    $07 constant OTG_FS_DEVICE_TXFE             \ [0x07] TXFE
  [then]


  [ifdef] OTG_FS_DEVICE_DIEPTSIZ1_DEF
    \
    \ @brief device endpoint-1 transfer size register
    \ Address offset: 0x130
    \ Reset value: 0x00000000
    \
    $00 constant OTG_FS_DEVICE_XFRSIZ           \ [0x00 : 19] Transfer size
    $13 constant OTG_FS_DEVICE_PKTCNT           \ [0x13 : 10] Packet count
    $1d constant OTG_FS_DEVICE_MCNT             \ [0x1d : 2] Multi count
  [then]


  [ifdef] OTG_FS_DEVICE_DTXFSTS1_DEF
    \
    \ @brief OTG_FS device IN endpoint transmit FIFO status register
    \ Address offset: 0x138
    \ Reset value: 0x00000000
    \
    $00 constant OTG_FS_DEVICE_INEPTFSAV        \ [0x00 : 16] IN endpoint TxFIFO space available
  [then]


  [ifdef] OTG_FS_DEVICE_DIEPCTL2_DEF
    \
    \ @brief OTG device endpoint-2 control register
    \ Address offset: 0x140
    \ Reset value: 0x00000000
    \
    $00 constant OTG_FS_DEVICE_MPSIZ            \ [0x00 : 11] MPSIZ
    $0f constant OTG_FS_DEVICE_USBAEP           \ [0x0f] USBAEP
    $10 constant OTG_FS_DEVICE_EONUM_DPID       \ [0x10] EONUM/DPID
    $11 constant OTG_FS_DEVICE_NAKSTS           \ [0x11] NAKSTS
    $12 constant OTG_FS_DEVICE_EPTYP            \ [0x12 : 2] EPTYP
    $15 constant OTG_FS_DEVICE_Stall            \ [0x15] Stall
    $16 constant OTG_FS_DEVICE_TXFNUM           \ [0x16 : 4] TXFNUM
    $1a constant OTG_FS_DEVICE_CNAK             \ [0x1a] CNAK
    $1b constant OTG_FS_DEVICE_SNAK             \ [0x1b] SNAK
    $1c constant OTG_FS_DEVICE_SD0PID_SEVNFRM   \ [0x1c] SD0PID/SEVNFRM
    $1d constant OTG_FS_DEVICE_SODDFRM          \ [0x1d] SODDFRM
    $1e constant OTG_FS_DEVICE_EPDIS            \ [0x1e] EPDIS
    $1f constant OTG_FS_DEVICE_EPENA            \ [0x1f] EPENA
  [then]


  [ifdef] OTG_FS_DEVICE_DIEPINT2_DEF
    \
    \ @brief device endpoint-2 interrupt register
    \ Address offset: 0x148
    \ Reset value: 0x00000080
    \
    $00 constant OTG_FS_DEVICE_XFRC             \ [0x00] XFRC
    $01 constant OTG_FS_DEVICE_EPDISD           \ [0x01] EPDISD
    $03 constant OTG_FS_DEVICE_TOC              \ [0x03] TOC
    $04 constant OTG_FS_DEVICE_ITTXFE           \ [0x04] ITTXFE
    $06 constant OTG_FS_DEVICE_INEPNE           \ [0x06] INEPNE
    $07 constant OTG_FS_DEVICE_TXFE             \ [0x07] TXFE
  [then]


  [ifdef] OTG_FS_DEVICE_DIEPTSIZ2_DEF
    \
    \ @brief device endpoint-2 transfer size register
    \ Address offset: 0x150
    \ Reset value: 0x00000000
    \
    $00 constant OTG_FS_DEVICE_XFRSIZ           \ [0x00 : 19] Transfer size
    $13 constant OTG_FS_DEVICE_PKTCNT           \ [0x13 : 10] Packet count
    $1d constant OTG_FS_DEVICE_MCNT             \ [0x1d : 2] Multi count
  [then]


  [ifdef] OTG_FS_DEVICE_DTXFSTS2_DEF
    \
    \ @brief OTG_FS device IN endpoint transmit FIFO status register
    \ Address offset: 0x158
    \ Reset value: 0x00000000
    \
    $00 constant OTG_FS_DEVICE_INEPTFSAV        \ [0x00 : 16] IN endpoint TxFIFO space available
  [then]


  [ifdef] OTG_FS_DEVICE_DIEPCTL3_DEF
    \
    \ @brief OTG device endpoint-3 control register
    \ Address offset: 0x160
    \ Reset value: 0x00000000
    \
    $00 constant OTG_FS_DEVICE_MPSIZ            \ [0x00 : 11] MPSIZ
    $0f constant OTG_FS_DEVICE_USBAEP           \ [0x0f] USBAEP
    $10 constant OTG_FS_DEVICE_EONUM_DPID       \ [0x10] EONUM/DPID
    $11 constant OTG_FS_DEVICE_NAKSTS           \ [0x11] NAKSTS
    $12 constant OTG_FS_DEVICE_EPTYP            \ [0x12 : 2] EPTYP
    $15 constant OTG_FS_DEVICE_Stall            \ [0x15] Stall
    $16 constant OTG_FS_DEVICE_TXFNUM           \ [0x16 : 4] TXFNUM
    $1a constant OTG_FS_DEVICE_CNAK             \ [0x1a] CNAK
    $1b constant OTG_FS_DEVICE_SNAK             \ [0x1b] SNAK
    $1c constant OTG_FS_DEVICE_SD0PID_SEVNFRM   \ [0x1c] SD0PID/SEVNFRM
    $1d constant OTG_FS_DEVICE_SODDFRM          \ [0x1d] SODDFRM
    $1e constant OTG_FS_DEVICE_EPDIS            \ [0x1e] EPDIS
    $1f constant OTG_FS_DEVICE_EPENA            \ [0x1f] EPENA
  [then]


  [ifdef] OTG_FS_DEVICE_DIEPINT3_DEF
    \
    \ @brief device endpoint-3 interrupt register
    \ Address offset: 0x168
    \ Reset value: 0x00000080
    \
    $00 constant OTG_FS_DEVICE_XFRC             \ [0x00] XFRC
    $01 constant OTG_FS_DEVICE_EPDISD           \ [0x01] EPDISD
    $03 constant OTG_FS_DEVICE_TOC              \ [0x03] TOC
    $04 constant OTG_FS_DEVICE_ITTXFE           \ [0x04] ITTXFE
    $06 constant OTG_FS_DEVICE_INEPNE           \ [0x06] INEPNE
    $07 constant OTG_FS_DEVICE_TXFE             \ [0x07] TXFE
  [then]


  [ifdef] OTG_FS_DEVICE_DIEPTSIZ3_DEF
    \
    \ @brief device endpoint-3 transfer size register
    \ Address offset: 0x170
    \ Reset value: 0x00000000
    \
    $00 constant OTG_FS_DEVICE_XFRSIZ           \ [0x00 : 19] Transfer size
    $13 constant OTG_FS_DEVICE_PKTCNT           \ [0x13 : 10] Packet count
    $1d constant OTG_FS_DEVICE_MCNT             \ [0x1d : 2] Multi count
  [then]


  [ifdef] OTG_FS_DEVICE_DTXFSTS3_DEF
    \
    \ @brief OTG_FS device IN endpoint transmit FIFO status register
    \ Address offset: 0x178
    \ Reset value: 0x00000000
    \
    $00 constant OTG_FS_DEVICE_INEPTFSAV        \ [0x00 : 16] IN endpoint TxFIFO space available
  [then]


  [ifdef] OTG_FS_DEVICE_DOEPCTL0_DEF
    \
    \ @brief device endpoint-0 control register
    \ Address offset: 0x300
    \ Reset value: 0x00008000
    \
    $00 constant OTG_FS_DEVICE_MPSIZ            \ [0x00 : 2] MPSIZ
    $0f constant OTG_FS_DEVICE_USBAEP           \ [0x0f] USBAEP
    $11 constant OTG_FS_DEVICE_NAKSTS           \ [0x11] NAKSTS
    $12 constant OTG_FS_DEVICE_EPTYP            \ [0x12 : 2] EPTYP
    $14 constant OTG_FS_DEVICE_SNPM             \ [0x14] SNPM
    $15 constant OTG_FS_DEVICE_Stall            \ [0x15] Stall
    $1a constant OTG_FS_DEVICE_CNAK             \ [0x1a] CNAK
    $1b constant OTG_FS_DEVICE_SNAK             \ [0x1b] SNAK
    $1e constant OTG_FS_DEVICE_EPDIS            \ [0x1e] EPDIS
    $1f constant OTG_FS_DEVICE_EPENA            \ [0x1f] EPENA
  [then]


  [ifdef] OTG_FS_DEVICE_DOEPINT0_DEF
    \
    \ @brief device endpoint-0 interrupt register
    \ Address offset: 0x308
    \ Reset value: 0x00000080
    \
    $00 constant OTG_FS_DEVICE_XFRC             \ [0x00] XFRC
    $01 constant OTG_FS_DEVICE_EPDISD           \ [0x01] EPDISD
    $03 constant OTG_FS_DEVICE_STUP             \ [0x03] STUP
    $04 constant OTG_FS_DEVICE_OTEPDIS          \ [0x04] OTEPDIS
    $06 constant OTG_FS_DEVICE_B2BSTUP          \ [0x06] B2BSTUP
  [then]


  [ifdef] OTG_FS_DEVICE_DOEPTSIZ0_DEF
    \
    \ @brief device OUT endpoint-0 transfer size register
    \ Address offset: 0x310
    \ Reset value: 0x00000000
    \
    $00 constant OTG_FS_DEVICE_XFRSIZ           \ [0x00 : 7] Transfer size
    $13 constant OTG_FS_DEVICE_PKTCNT           \ [0x13] Packet count
    $1d constant OTG_FS_DEVICE_STUPCNT          \ [0x1d : 2] SETUP packet count
  [then]


  [ifdef] OTG_FS_DEVICE_DOEPCTL1_DEF
    \
    \ @brief device endpoint-1 control register
    \ Address offset: 0x320
    \ Reset value: 0x00000000
    \
    $00 constant OTG_FS_DEVICE_MPSIZ            \ [0x00 : 11] MPSIZ
    $0f constant OTG_FS_DEVICE_USBAEP           \ [0x0f] USBAEP
    $10 constant OTG_FS_DEVICE_EONUM_DPID       \ [0x10] EONUM/DPID
    $11 constant OTG_FS_DEVICE_NAKSTS           \ [0x11] NAKSTS
    $12 constant OTG_FS_DEVICE_EPTYP            \ [0x12 : 2] EPTYP
    $14 constant OTG_FS_DEVICE_SNPM             \ [0x14] SNPM
    $15 constant OTG_FS_DEVICE_Stall            \ [0x15] Stall
    $1a constant OTG_FS_DEVICE_CNAK             \ [0x1a] CNAK
    $1b constant OTG_FS_DEVICE_SNAK             \ [0x1b] SNAK
    $1c constant OTG_FS_DEVICE_SD0PID_SEVNFRM   \ [0x1c] SD0PID/SEVNFRM
    $1d constant OTG_FS_DEVICE_SODDFRM          \ [0x1d] SODDFRM
    $1e constant OTG_FS_DEVICE_EPDIS            \ [0x1e] EPDIS
    $1f constant OTG_FS_DEVICE_EPENA            \ [0x1f] EPENA
  [then]


  [ifdef] OTG_FS_DEVICE_DOEPINT1_DEF
    \
    \ @brief device endpoint-1 interrupt register
    \ Address offset: 0x328
    \ Reset value: 0x00000080
    \
    $00 constant OTG_FS_DEVICE_XFRC             \ [0x00] XFRC
    $01 constant OTG_FS_DEVICE_EPDISD           \ [0x01] EPDISD
    $03 constant OTG_FS_DEVICE_STUP             \ [0x03] STUP
    $04 constant OTG_FS_DEVICE_OTEPDIS          \ [0x04] OTEPDIS
    $06 constant OTG_FS_DEVICE_B2BSTUP          \ [0x06] B2BSTUP
  [then]


  [ifdef] OTG_FS_DEVICE_DOEPTSIZ1_DEF
    \
    \ @brief device OUT endpoint-1 transfer size register
    \ Address offset: 0x330
    \ Reset value: 0x00000000
    \
    $00 constant OTG_FS_DEVICE_XFRSIZ           \ [0x00 : 19] Transfer size
    $13 constant OTG_FS_DEVICE_PKTCNT           \ [0x13 : 10] Packet count
    $1d constant OTG_FS_DEVICE_RXDPID_STUPCNT   \ [0x1d : 2] Received data PID/SETUP packet count
  [then]


  [ifdef] OTG_FS_DEVICE_DOEPCTL2_DEF
    \
    \ @brief device endpoint-2 control register
    \ Address offset: 0x340
    \ Reset value: 0x00000000
    \
    $00 constant OTG_FS_DEVICE_MPSIZ            \ [0x00 : 11] MPSIZ
    $0f constant OTG_FS_DEVICE_USBAEP           \ [0x0f] USBAEP
    $10 constant OTG_FS_DEVICE_EONUM_DPID       \ [0x10] EONUM/DPID
    $11 constant OTG_FS_DEVICE_NAKSTS           \ [0x11] NAKSTS
    $12 constant OTG_FS_DEVICE_EPTYP            \ [0x12 : 2] EPTYP
    $14 constant OTG_FS_DEVICE_SNPM             \ [0x14] SNPM
    $15 constant OTG_FS_DEVICE_Stall            \ [0x15] Stall
    $1a constant OTG_FS_DEVICE_CNAK             \ [0x1a] CNAK
    $1b constant OTG_FS_DEVICE_SNAK             \ [0x1b] SNAK
    $1c constant OTG_FS_DEVICE_SD0PID_SEVNFRM   \ [0x1c] SD0PID/SEVNFRM
    $1d constant OTG_FS_DEVICE_SODDFRM          \ [0x1d] SODDFRM
    $1e constant OTG_FS_DEVICE_EPDIS            \ [0x1e] EPDIS
    $1f constant OTG_FS_DEVICE_EPENA            \ [0x1f] EPENA
  [then]


  [ifdef] OTG_FS_DEVICE_DOEPINT2_DEF
    \
    \ @brief device endpoint-2 interrupt register
    \ Address offset: 0x348
    \ Reset value: 0x00000080
    \
    $00 constant OTG_FS_DEVICE_XFRC             \ [0x00] XFRC
    $01 constant OTG_FS_DEVICE_EPDISD           \ [0x01] EPDISD
    $03 constant OTG_FS_DEVICE_STUP             \ [0x03] STUP
    $04 constant OTG_FS_DEVICE_OTEPDIS          \ [0x04] OTEPDIS
    $06 constant OTG_FS_DEVICE_B2BSTUP          \ [0x06] B2BSTUP
  [then]


  [ifdef] OTG_FS_DEVICE_DOEPTSIZ2_DEF
    \
    \ @brief device OUT endpoint-2 transfer size register
    \ Address offset: 0x350
    \ Reset value: 0x00000000
    \
    $00 constant OTG_FS_DEVICE_XFRSIZ           \ [0x00 : 19] Transfer size
    $13 constant OTG_FS_DEVICE_PKTCNT           \ [0x13 : 10] Packet count
    $1d constant OTG_FS_DEVICE_RXDPID_STUPCNT   \ [0x1d : 2] Received data PID/SETUP packet count
  [then]


  [ifdef] OTG_FS_DEVICE_DOEPCTL3_DEF
    \
    \ @brief device endpoint-3 control register
    \ Address offset: 0x360
    \ Reset value: 0x00000000
    \
    $00 constant OTG_FS_DEVICE_MPSIZ            \ [0x00 : 11] MPSIZ
    $0f constant OTG_FS_DEVICE_USBAEP           \ [0x0f] USBAEP
    $10 constant OTG_FS_DEVICE_EONUM_DPID       \ [0x10] EONUM/DPID
    $11 constant OTG_FS_DEVICE_NAKSTS           \ [0x11] NAKSTS
    $12 constant OTG_FS_DEVICE_EPTYP            \ [0x12 : 2] EPTYP
    $14 constant OTG_FS_DEVICE_SNPM             \ [0x14] SNPM
    $15 constant OTG_FS_DEVICE_Stall            \ [0x15] Stall
    $1a constant OTG_FS_DEVICE_CNAK             \ [0x1a] CNAK
    $1b constant OTG_FS_DEVICE_SNAK             \ [0x1b] SNAK
    $1c constant OTG_FS_DEVICE_SD0PID_SEVNFRM   \ [0x1c] SD0PID/SEVNFRM
    $1d constant OTG_FS_DEVICE_SODDFRM          \ [0x1d] SODDFRM
    $1e constant OTG_FS_DEVICE_EPDIS            \ [0x1e] EPDIS
    $1f constant OTG_FS_DEVICE_EPENA            \ [0x1f] EPENA
  [then]


  [ifdef] OTG_FS_DEVICE_DOEPINT3_DEF
    \
    \ @brief device endpoint-3 interrupt register
    \ Address offset: 0x368
    \ Reset value: 0x00000080
    \
    $00 constant OTG_FS_DEVICE_XFRC             \ [0x00] XFRC
    $01 constant OTG_FS_DEVICE_EPDISD           \ [0x01] EPDISD
    $03 constant OTG_FS_DEVICE_STUP             \ [0x03] STUP
    $04 constant OTG_FS_DEVICE_OTEPDIS          \ [0x04] OTEPDIS
    $06 constant OTG_FS_DEVICE_B2BSTUP          \ [0x06] B2BSTUP
  [then]


  [ifdef] OTG_FS_DEVICE_DOEPTSIZ3_DEF
    \
    \ @brief device OUT endpoint-3 transfer size register
    \ Address offset: 0x370
    \ Reset value: 0x00000000
    \
    $00 constant OTG_FS_DEVICE_XFRSIZ           \ [0x00 : 19] Transfer size
    $13 constant OTG_FS_DEVICE_PKTCNT           \ [0x13 : 10] Packet count
    $1d constant OTG_FS_DEVICE_RXDPID_STUPCNT   \ [0x1d : 2] Received data PID/SETUP packet count
  [then]

  \
  \ @brief USB on the go full speed
  \
  $00 constant OTG_FS_DEVICE_FS_DCFG    \ OTG_FS device configuration register (OTG_FS_DCFG)
  $04 constant OTG_FS_DEVICE_FS_DCTL    \ OTG_FS device control register (OTG_FS_DCTL)
  $08 constant OTG_FS_DEVICE_FS_DSTS    \ OTG_FS device status register (OTG_FS_DSTS)
  $10 constant OTG_FS_DEVICE_FS_DIEPMSK \ OTG_FS device IN endpoint common interrupt mask register (OTG_FS_DIEPMSK)
  $14 constant OTG_FS_DEVICE_FS_DOEPMSK \ OTG_FS device OUT endpoint common interrupt mask register (OTG_FS_DOEPMSK)
  $18 constant OTG_FS_DEVICE_FS_DAINT   \ OTG_FS device all endpoints interrupt register (OTG_FS_DAINT)
  $1C constant OTG_FS_DEVICE_FS_DAINTMSK    \ OTG_FS all endpoints interrupt mask register (OTG_FS_DAINTMSK)
  $28 constant OTG_FS_DEVICE_DVBUSDIS   \ OTG_FS device VBUS discharge time register
  $2C constant OTG_FS_DEVICE_DVBUSPULSE \ OTG_FS device VBUS pulsing time register
  $34 constant OTG_FS_DEVICE_DIEPEMPMSK \ OTG_FS device IN endpoint FIFO empty interrupt mask register
  $100 constant OTG_FS_DEVICE_FS_DIEPCTL0    \ OTG_FS device control IN endpoint 0 control register (OTG_FS_DIEPCTL0)
  $108 constant OTG_FS_DEVICE_DIEPINT0  \ device endpoint-x interrupt register
  $110 constant OTG_FS_DEVICE_DIEPTSIZ0 \ device endpoint-0 transfer size register
  $118 constant OTG_FS_DEVICE_DTXFSTS0  \ OTG_FS device IN endpoint transmit FIFO status register
  $120 constant OTG_FS_DEVICE_DIEPCTL1  \ OTG device endpoint-1 control register
  $128 constant OTG_FS_DEVICE_DIEPINT1  \ device endpoint-1 interrupt register
  $130 constant OTG_FS_DEVICE_DIEPTSIZ1 \ device endpoint-1 transfer size register
  $138 constant OTG_FS_DEVICE_DTXFSTS1  \ OTG_FS device IN endpoint transmit FIFO status register
  $140 constant OTG_FS_DEVICE_DIEPCTL2  \ OTG device endpoint-2 control register
  $148 constant OTG_FS_DEVICE_DIEPINT2  \ device endpoint-2 interrupt register
  $150 constant OTG_FS_DEVICE_DIEPTSIZ2 \ device endpoint-2 transfer size register
  $158 constant OTG_FS_DEVICE_DTXFSTS2  \ OTG_FS device IN endpoint transmit FIFO status register
  $160 constant OTG_FS_DEVICE_DIEPCTL3  \ OTG device endpoint-3 control register
  $168 constant OTG_FS_DEVICE_DIEPINT3  \ device endpoint-3 interrupt register
  $170 constant OTG_FS_DEVICE_DIEPTSIZ3 \ device endpoint-3 transfer size register
  $178 constant OTG_FS_DEVICE_DTXFSTS3  \ OTG_FS device IN endpoint transmit FIFO status register
  $300 constant OTG_FS_DEVICE_DOEPCTL0  \ device endpoint-0 control register
  $308 constant OTG_FS_DEVICE_DOEPINT0  \ device endpoint-0 interrupt register
  $310 constant OTG_FS_DEVICE_DOEPTSIZ0 \ device OUT endpoint-0 transfer size register
  $320 constant OTG_FS_DEVICE_DOEPCTL1  \ device endpoint-1 control register
  $328 constant OTG_FS_DEVICE_DOEPINT1  \ device endpoint-1 interrupt register
  $330 constant OTG_FS_DEVICE_DOEPTSIZ1 \ device OUT endpoint-1 transfer size register
  $340 constant OTG_FS_DEVICE_DOEPCTL2  \ device endpoint-2 control register
  $348 constant OTG_FS_DEVICE_DOEPINT2  \ device endpoint-2 interrupt register
  $350 constant OTG_FS_DEVICE_DOEPTSIZ2 \ device OUT endpoint-2 transfer size register
  $360 constant OTG_FS_DEVICE_DOEPCTL3  \ device endpoint-3 control register
  $368 constant OTG_FS_DEVICE_DOEPINT3  \ device endpoint-3 interrupt register
  $370 constant OTG_FS_DEVICE_DOEPTSIZ3 \ device OUT endpoint-3 transfer size register

: OTG_FS_DEVICE_DEF ; [then]
