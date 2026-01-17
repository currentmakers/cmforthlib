\
\ @file otg1_hs_device.fs
\ @brief USB 1 on the go high speed
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] OTG1_HS_DEVICE_DEF

  [ifdef] OTG1_HS_DEVICE_OTG_HS_DCFG_DEF
    \
    \ @brief OTG_HS device configuration register
    \ Address offset: 0x00
    \ Reset value: 0x02200000
    \
    $00 constant OTG1_HS_DEVICE_DSPD            \ [0x00 : 2] Device speed
    $02 constant OTG1_HS_DEVICE_NZLSOHSK        \ [0x02] Nonzero-length status OUT handshake
    $04 constant OTG1_HS_DEVICE_DAD             \ [0x04 : 7] Device address
    $0b constant OTG1_HS_DEVICE_PFIVL           \ [0x0b : 2] Periodic (micro)frame interval
    $18 constant OTG1_HS_DEVICE_PERSCHIVL       \ [0x18 : 2] Periodic scheduling interval
  [then]


  [ifdef] OTG1_HS_DEVICE_OTG_HS_DCTL_DEF
    \
    \ @brief OTG_HS device control register
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $00 constant OTG1_HS_DEVICE_RWUSIG          \ [0x00] Remote wakeup signaling
    $01 constant OTG1_HS_DEVICE_SDIS            \ [0x01] Soft disconnect
    $02 constant OTG1_HS_DEVICE_GINSTS          \ [0x02] Global IN NAK status
    $03 constant OTG1_HS_DEVICE_GONSTS          \ [0x03] Global OUT NAK status
    $04 constant OTG1_HS_DEVICE_TCTL            \ [0x04 : 3] Test control
    $07 constant OTG1_HS_DEVICE_SGINAK          \ [0x07] Set global IN NAK
    $08 constant OTG1_HS_DEVICE_CGINAK          \ [0x08] Clear global IN NAK
    $09 constant OTG1_HS_DEVICE_SGONAK          \ [0x09] Set global OUT NAK
    $0a constant OTG1_HS_DEVICE_CGONAK          \ [0x0a] Clear global OUT NAK
    $0b constant OTG1_HS_DEVICE_POPRGDNE        \ [0x0b] Power-on programming done
  [then]


  [ifdef] OTG1_HS_DEVICE_OTG_HS_DSTS_DEF
    \
    \ @brief OTG_HS device status register
    \ Address offset: 0x08
    \ Reset value: 0x00000010
    \
    $00 constant OTG1_HS_DEVICE_SUSPSTS         \ [0x00] Suspend status
    $01 constant OTG1_HS_DEVICE_ENUMSPD         \ [0x01 : 2] Enumerated speed
    $03 constant OTG1_HS_DEVICE_EERR            \ [0x03] Erratic error
    $08 constant OTG1_HS_DEVICE_FNSOF           \ [0x08 : 14] Frame number of the received SOF
  [then]


  [ifdef] OTG1_HS_DEVICE_OTG_HS_DIEPMSK_DEF
    \
    \ @brief OTG_HS device IN endpoint common interrupt mask register
    \ Address offset: 0x10
    \ Reset value: 0x00000000
    \
    $00 constant OTG1_HS_DEVICE_XFRCM           \ [0x00] Transfer completed interrupt mask
    $01 constant OTG1_HS_DEVICE_EPDM            \ [0x01] Endpoint disabled interrupt mask
    $03 constant OTG1_HS_DEVICE_TOM             \ [0x03] Timeout condition mask (nonisochronous endpoints)
    $04 constant OTG1_HS_DEVICE_ITTXFEMSK       \ [0x04] IN token received when TxFIFO empty mask
    $05 constant OTG1_HS_DEVICE_INEPNMM         \ [0x05] IN token received with EP mismatch mask
    $06 constant OTG1_HS_DEVICE_INEPNEM         \ [0x06] IN endpoint NAK effective mask
    $08 constant OTG1_HS_DEVICE_TXFURM          \ [0x08] FIFO underrun mask
    $09 constant OTG1_HS_DEVICE_BIM             \ [0x09] BNA interrupt mask
  [then]


  [ifdef] OTG1_HS_DEVICE_OTG_HS_DOEPMSK_DEF
    \
    \ @brief OTG_HS device OUT endpoint common interrupt mask register
    \ Address offset: 0x14
    \ Reset value: 0x00000000
    \
    $00 constant OTG1_HS_DEVICE_XFRCM           \ [0x00] Transfer completed interrupt mask
    $01 constant OTG1_HS_DEVICE_EPDM            \ [0x01] Endpoint disabled interrupt mask
    $03 constant OTG1_HS_DEVICE_STUPM           \ [0x03] SETUP phase done mask
    $04 constant OTG1_HS_DEVICE_OTEPDM          \ [0x04] OUT token received when endpoint disabled mask
    $06 constant OTG1_HS_DEVICE_B2BSTUP         \ [0x06] Back-to-back SETUP packets received mask
    $08 constant OTG1_HS_DEVICE_OPEM            \ [0x08] OUT packet error mask
    $09 constant OTG1_HS_DEVICE_BOIM            \ [0x09] BNA interrupt mask
  [then]


  [ifdef] OTG1_HS_DEVICE_OTG_HS_DAINT_DEF
    \
    \ @brief OTG_HS device all endpoints interrupt register
    \ Address offset: 0x18
    \ Reset value: 0x00000000
    \
    $00 constant OTG1_HS_DEVICE_IEPINT          \ [0x00 : 16] IN endpoint interrupt bits
    $10 constant OTG1_HS_DEVICE_OEPINT          \ [0x10 : 16] OUT endpoint interrupt bits
  [then]


  [ifdef] OTG1_HS_DEVICE_OTG_HS_DAINTMSK_DEF
    \
    \ @brief OTG_HS all endpoints interrupt mask register
    \ Address offset: 0x1C
    \ Reset value: 0x00000000
    \
    $00 constant OTG1_HS_DEVICE_IEPM            \ [0x00 : 16] IN EP interrupt mask bits
    $10 constant OTG1_HS_DEVICE_OEPM            \ [0x10 : 16] OUT EP interrupt mask bits
  [then]


  [ifdef] OTG1_HS_DEVICE_OTG_HS_DVBUSDIS_DEF
    \
    \ @brief OTG_HS device VBUS discharge time register
    \ Address offset: 0x28
    \ Reset value: 0x000017D7
    \
    $00 constant OTG1_HS_DEVICE_VBUSDT          \ [0x00 : 16] Device VBUS discharge time
  [then]


  [ifdef] OTG1_HS_DEVICE_OTG_HS_DVBUSPULSE_DEF
    \
    \ @brief OTG_HS device VBUS pulsing time register
    \ Address offset: 0x2C
    \ Reset value: 0x000005B8
    \
    $00 constant OTG1_HS_DEVICE_DVBUSP          \ [0x00 : 12] Device VBUS pulsing time
  [then]


  [ifdef] OTG1_HS_DEVICE_OTG_HS_DTHRCTL_DEF
    \
    \ @brief OTG_HS Device threshold control register
    \ Address offset: 0x30
    \ Reset value: 0x00000000
    \
    $00 constant OTG1_HS_DEVICE_NONISOTHREN     \ [0x00] Nonisochronous IN endpoints threshold enable
    $01 constant OTG1_HS_DEVICE_ISOTHREN        \ [0x01] ISO IN endpoint threshold enable
    $02 constant OTG1_HS_DEVICE_TXTHRLEN        \ [0x02 : 9] Transmit threshold length
    $10 constant OTG1_HS_DEVICE_RXTHREN         \ [0x10] Receive threshold enable
    $11 constant OTG1_HS_DEVICE_RXTHRLEN        \ [0x11 : 9] Receive threshold length
    $1b constant OTG1_HS_DEVICE_ARPEN           \ [0x1b] Arbiter parking enable
  [then]


  [ifdef] OTG1_HS_DEVICE_OTG_HS_DIEPEMPMSK_DEF
    \
    \ @brief OTG_HS device IN endpoint FIFO empty interrupt mask register
    \ Address offset: 0x34
    \ Reset value: 0x00000000
    \
    $00 constant OTG1_HS_DEVICE_INEPTXFEM       \ [0x00 : 16] IN EP Tx FIFO empty interrupt mask bits
  [then]


  [ifdef] OTG1_HS_DEVICE_OTG_HS_DEACHINT_DEF
    \
    \ @brief OTG_HS device each endpoint interrupt register
    \ Address offset: 0x38
    \ Reset value: 0x00000000
    \
    $01 constant OTG1_HS_DEVICE_IEP1INT         \ [0x01] IN endpoint 1interrupt bit
    $11 constant OTG1_HS_DEVICE_OEP1INT         \ [0x11] OUT endpoint 1 interrupt bit
  [then]


  [ifdef] OTG1_HS_DEVICE_OTG_HS_DEACHINTMSK_DEF
    \
    \ @brief OTG_HS device each endpoint interrupt register mask
    \ Address offset: 0x3C
    \ Reset value: 0x00000000
    \
    $01 constant OTG1_HS_DEVICE_IEP1INTM        \ [0x01] IN Endpoint 1 interrupt mask bit
    $11 constant OTG1_HS_DEVICE_OEP1INTM        \ [0x11] OUT Endpoint 1 interrupt mask bit
  [then]


  [ifdef] OTG1_HS_DEVICE_OTG_HS_DIEPCTL0_DEF
    \
    \ @brief OTG device endpoint-0 control register
    \ Address offset: 0x100
    \ Reset value: 0x00000000
    \
    $00 constant OTG1_HS_DEVICE_MPSIZ           \ [0x00 : 11] Maximum packet size
    $0f constant OTG1_HS_DEVICE_USBAEP          \ [0x0f] USB active endpoint
    $10 constant OTG1_HS_DEVICE_EONUM_DPID      \ [0x10] Even/odd frame
    $11 constant OTG1_HS_DEVICE_NAKSTS          \ [0x11] NAK status
    $12 constant OTG1_HS_DEVICE_EPTYP           \ [0x12 : 2] Endpoint type
    $15 constant OTG1_HS_DEVICE_Stall           \ [0x15] STALL handshake
    $16 constant OTG1_HS_DEVICE_TXFNUM          \ [0x16 : 4] TxFIFO number
    $1a constant OTG1_HS_DEVICE_CNAK            \ [0x1a] Clear NAK
    $1b constant OTG1_HS_DEVICE_SNAK            \ [0x1b] Set NAK
    $1c constant OTG1_HS_DEVICE_SD0PID_SEVNFRM  \ [0x1c] Set DATA0 PID
    $1d constant OTG1_HS_DEVICE_SODDFRM         \ [0x1d] Set odd frame
    $1e constant OTG1_HS_DEVICE_EPDIS           \ [0x1e] Endpoint disable
    $1f constant OTG1_HS_DEVICE_EPENA           \ [0x1f] Endpoint enable
  [then]


  [ifdef] OTG1_HS_DEVICE_OTG_HS_DIEPINT0_DEF
    \
    \ @brief OTG device endpoint-0 interrupt register
    \ Address offset: 0x108
    \ Reset value: 0x00000080
    \
    $00 constant OTG1_HS_DEVICE_XFRC            \ [0x00] Transfer completed interrupt
    $01 constant OTG1_HS_DEVICE_EPDISD          \ [0x01] Endpoint disabled interrupt
    $03 constant OTG1_HS_DEVICE_TOC             \ [0x03] Timeout condition
    $04 constant OTG1_HS_DEVICE_ITTXFE          \ [0x04] IN token received when TxFIFO is empty
    $06 constant OTG1_HS_DEVICE_INEPNE          \ [0x06] IN endpoint NAK effective
    $07 constant OTG1_HS_DEVICE_TXFE            \ [0x07] Transmit FIFO empty
    $08 constant OTG1_HS_DEVICE_TXFIFOUDRN      \ [0x08] Transmit Fifo Underrun
    $09 constant OTG1_HS_DEVICE_BNA             \ [0x09] Buffer not available interrupt
    $0b constant OTG1_HS_DEVICE_PKTDRPSTS       \ [0x0b] Packet dropped status
    $0c constant OTG1_HS_DEVICE_BERR            \ [0x0c] Babble error interrupt
    $0d constant OTG1_HS_DEVICE_NAK             \ [0x0d] NAK interrupt
  [then]


  [ifdef] OTG1_HS_DEVICE_OTG_HS_DIEPTSIZ0_DEF
    \
    \ @brief OTG_HS device IN endpoint 0 transfer size register
    \ Address offset: 0x110
    \ Reset value: 0x00000000
    \
    $00 constant OTG1_HS_DEVICE_XFRSIZ          \ [0x00 : 7] Transfer size
    $13 constant OTG1_HS_DEVICE_PKTCNT          \ [0x13 : 2] Packet count
  [then]


  [ifdef] OTG1_HS_DEVICE_OTG_HS_DIEPDMA1_DEF
    \
    \ @brief OTG_HS device endpoint-1 DMA address register
    \ Address offset: 0x114
    \ Reset value: 0x00000000
    \
    $00 constant OTG1_HS_DEVICE_DMAADDR         \ [0x00 : 32] DMA address
  [then]


  [ifdef] OTG1_HS_DEVICE_OTG_HS_DTXFSTS0_DEF
    \
    \ @brief OTG_HS device IN endpoint transmit FIFO status register
    \ Address offset: 0x118
    \ Reset value: 0x00000000
    \
    $00 constant OTG1_HS_DEVICE_INEPTFSAV       \ [0x00 : 16] IN endpoint TxFIFO space avail
  [then]


  [ifdef] OTG1_HS_DEVICE_OTG_HS_DIEPCTL1_DEF
    \
    \ @brief OTG device endpoint-1 control register
    \ Address offset: 0x120
    \ Reset value: 0x00000000
    \
    $00 constant OTG1_HS_DEVICE_MPSIZ           \ [0x00 : 11] Maximum packet size
    $0f constant OTG1_HS_DEVICE_USBAEP          \ [0x0f] USB active endpoint
    $10 constant OTG1_HS_DEVICE_EONUM_DPID      \ [0x10] Even/odd frame
    $11 constant OTG1_HS_DEVICE_NAKSTS          \ [0x11] NAK status
    $12 constant OTG1_HS_DEVICE_EPTYP           \ [0x12 : 2] Endpoint type
    $15 constant OTG1_HS_DEVICE_Stall           \ [0x15] STALL handshake
    $16 constant OTG1_HS_DEVICE_TXFNUM          \ [0x16 : 4] TxFIFO number
    $1a constant OTG1_HS_DEVICE_CNAK            \ [0x1a] Clear NAK
    $1b constant OTG1_HS_DEVICE_SNAK            \ [0x1b] Set NAK
    $1c constant OTG1_HS_DEVICE_SD0PID_SEVNFRM  \ [0x1c] Set DATA0 PID
    $1d constant OTG1_HS_DEVICE_SODDFRM         \ [0x1d] Set odd frame
    $1e constant OTG1_HS_DEVICE_EPDIS           \ [0x1e] Endpoint disable
    $1f constant OTG1_HS_DEVICE_EPENA           \ [0x1f] Endpoint enable
  [then]


  [ifdef] OTG1_HS_DEVICE_OTG_HS_DIEPINT1_DEF
    \
    \ @brief OTG device endpoint-1 interrupt register
    \ Address offset: 0x128
    \ Reset value: 0x00000000
    \
    $00 constant OTG1_HS_DEVICE_XFRC            \ [0x00] Transfer completed interrupt
    $01 constant OTG1_HS_DEVICE_EPDISD          \ [0x01] Endpoint disabled interrupt
    $03 constant OTG1_HS_DEVICE_TOC             \ [0x03] Timeout condition
    $04 constant OTG1_HS_DEVICE_ITTXFE          \ [0x04] IN token received when TxFIFO is empty
    $06 constant OTG1_HS_DEVICE_INEPNE          \ [0x06] IN endpoint NAK effective
    $07 constant OTG1_HS_DEVICE_TXFE            \ [0x07] Transmit FIFO empty
    $08 constant OTG1_HS_DEVICE_TXFIFOUDRN      \ [0x08] Transmit Fifo Underrun
    $09 constant OTG1_HS_DEVICE_BNA             \ [0x09] Buffer not available interrupt
    $0b constant OTG1_HS_DEVICE_PKTDRPSTS       \ [0x0b] Packet dropped status
    $0c constant OTG1_HS_DEVICE_BERR            \ [0x0c] Babble error interrupt
    $0d constant OTG1_HS_DEVICE_NAK             \ [0x0d] NAK interrupt
  [then]


  [ifdef] OTG1_HS_DEVICE_OTG_HS_DIEPTSIZ1_DEF
    \
    \ @brief OTG_HS device endpoint transfer size register
    \ Address offset: 0x130
    \ Reset value: 0x00000000
    \
    $00 constant OTG1_HS_DEVICE_XFRSIZ          \ [0x00 : 19] Transfer size
    $13 constant OTG1_HS_DEVICE_PKTCNT          \ [0x13 : 10] Packet count
    $1d constant OTG1_HS_DEVICE_MCNT            \ [0x1d : 2] Multi count
  [then]


  [ifdef] OTG1_HS_DEVICE_OTG_HS_DIEPDMA2_DEF
    \
    \ @brief OTG_HS device endpoint-2 DMA address register
    \ Address offset: 0x134
    \ Reset value: 0x00000000
    \
    $00 constant OTG1_HS_DEVICE_DMAADDR         \ [0x00 : 32] DMA address
  [then]


  [ifdef] OTG1_HS_DEVICE_OTG_HS_DTXFSTS1_DEF
    \
    \ @brief OTG_HS device IN endpoint transmit FIFO status register
    \ Address offset: 0x138
    \ Reset value: 0x00000000
    \
    $00 constant OTG1_HS_DEVICE_INEPTFSAV       \ [0x00 : 16] IN endpoint TxFIFO space avail
  [then]


  [ifdef] OTG1_HS_DEVICE_OTG_HS_DIEPCTL2_DEF
    \
    \ @brief OTG device endpoint-2 control register
    \ Address offset: 0x140
    \ Reset value: 0x00000000
    \
    $00 constant OTG1_HS_DEVICE_MPSIZ           \ [0x00 : 11] Maximum packet size
    $0f constant OTG1_HS_DEVICE_USBAEP          \ [0x0f] USB active endpoint
    $10 constant OTG1_HS_DEVICE_EONUM_DPID      \ [0x10] Even/odd frame
    $11 constant OTG1_HS_DEVICE_NAKSTS          \ [0x11] NAK status
    $12 constant OTG1_HS_DEVICE_EPTYP           \ [0x12 : 2] Endpoint type
    $15 constant OTG1_HS_DEVICE_Stall           \ [0x15] STALL handshake
    $16 constant OTG1_HS_DEVICE_TXFNUM          \ [0x16 : 4] TxFIFO number
    $1a constant OTG1_HS_DEVICE_CNAK            \ [0x1a] Clear NAK
    $1b constant OTG1_HS_DEVICE_SNAK            \ [0x1b] Set NAK
    $1c constant OTG1_HS_DEVICE_SD0PID_SEVNFRM  \ [0x1c] Set DATA0 PID
    $1d constant OTG1_HS_DEVICE_SODDFRM         \ [0x1d] Set odd frame
    $1e constant OTG1_HS_DEVICE_EPDIS           \ [0x1e] Endpoint disable
    $1f constant OTG1_HS_DEVICE_EPENA           \ [0x1f] Endpoint enable
  [then]


  [ifdef] OTG1_HS_DEVICE_OTG_HS_DIEPINT2_DEF
    \
    \ @brief OTG device endpoint-2 interrupt register
    \ Address offset: 0x148
    \ Reset value: 0x00000000
    \
    $00 constant OTG1_HS_DEVICE_XFRC            \ [0x00] Transfer completed interrupt
    $01 constant OTG1_HS_DEVICE_EPDISD          \ [0x01] Endpoint disabled interrupt
    $03 constant OTG1_HS_DEVICE_TOC             \ [0x03] Timeout condition
    $04 constant OTG1_HS_DEVICE_ITTXFE          \ [0x04] IN token received when TxFIFO is empty
    $06 constant OTG1_HS_DEVICE_INEPNE          \ [0x06] IN endpoint NAK effective
    $07 constant OTG1_HS_DEVICE_TXFE            \ [0x07] Transmit FIFO empty
    $08 constant OTG1_HS_DEVICE_TXFIFOUDRN      \ [0x08] Transmit Fifo Underrun
    $09 constant OTG1_HS_DEVICE_BNA             \ [0x09] Buffer not available interrupt
    $0b constant OTG1_HS_DEVICE_PKTDRPSTS       \ [0x0b] Packet dropped status
    $0c constant OTG1_HS_DEVICE_BERR            \ [0x0c] Babble error interrupt
    $0d constant OTG1_HS_DEVICE_NAK             \ [0x0d] NAK interrupt
  [then]


  [ifdef] OTG1_HS_DEVICE_OTG_HS_DIEPTSIZ2_DEF
    \
    \ @brief OTG_HS device endpoint transfer size register
    \ Address offset: 0x150
    \ Reset value: 0x00000000
    \
    $00 constant OTG1_HS_DEVICE_XFRSIZ          \ [0x00 : 19] Transfer size
    $13 constant OTG1_HS_DEVICE_PKTCNT          \ [0x13 : 10] Packet count
    $1d constant OTG1_HS_DEVICE_MCNT            \ [0x1d : 2] Multi count
  [then]


  [ifdef] OTG1_HS_DEVICE_OTG_HS_DIEPDMA3_DEF
    \
    \ @brief OTG_HS device endpoint-3 DMA address register
    \ Address offset: 0x154
    \ Reset value: 0x00000000
    \
    $00 constant OTG1_HS_DEVICE_DMAADDR         \ [0x00 : 32] DMA address
  [then]


  [ifdef] OTG1_HS_DEVICE_OTG_HS_DTXFSTS2_DEF
    \
    \ @brief OTG_HS device IN endpoint transmit FIFO status register
    \ Address offset: 0x158
    \ Reset value: 0x00000000
    \
    $00 constant OTG1_HS_DEVICE_INEPTFSAV       \ [0x00 : 16] IN endpoint TxFIFO space avail
  [then]


  [ifdef] OTG1_HS_DEVICE_OTG_HS_DIEPCTL3_DEF
    \
    \ @brief OTG device endpoint-3 control register
    \ Address offset: 0x160
    \ Reset value: 0x00000000
    \
    $00 constant OTG1_HS_DEVICE_MPSIZ           \ [0x00 : 11] Maximum packet size
    $0f constant OTG1_HS_DEVICE_USBAEP          \ [0x0f] USB active endpoint
    $10 constant OTG1_HS_DEVICE_EONUM_DPID      \ [0x10] Even/odd frame
    $11 constant OTG1_HS_DEVICE_NAKSTS          \ [0x11] NAK status
    $12 constant OTG1_HS_DEVICE_EPTYP           \ [0x12 : 2] Endpoint type
    $15 constant OTG1_HS_DEVICE_Stall           \ [0x15] STALL handshake
    $16 constant OTG1_HS_DEVICE_TXFNUM          \ [0x16 : 4] TxFIFO number
    $1a constant OTG1_HS_DEVICE_CNAK            \ [0x1a] Clear NAK
    $1b constant OTG1_HS_DEVICE_SNAK            \ [0x1b] Set NAK
    $1c constant OTG1_HS_DEVICE_SD0PID_SEVNFRM  \ [0x1c] Set DATA0 PID
    $1d constant OTG1_HS_DEVICE_SODDFRM         \ [0x1d] Set odd frame
    $1e constant OTG1_HS_DEVICE_EPDIS           \ [0x1e] Endpoint disable
    $1f constant OTG1_HS_DEVICE_EPENA           \ [0x1f] Endpoint enable
  [then]


  [ifdef] OTG1_HS_DEVICE_OTG_HS_DIEPINT3_DEF
    \
    \ @brief OTG device endpoint-3 interrupt register
    \ Address offset: 0x168
    \ Reset value: 0x00000000
    \
    $00 constant OTG1_HS_DEVICE_XFRC            \ [0x00] Transfer completed interrupt
    $01 constant OTG1_HS_DEVICE_EPDISD          \ [0x01] Endpoint disabled interrupt
    $03 constant OTG1_HS_DEVICE_TOC             \ [0x03] Timeout condition
    $04 constant OTG1_HS_DEVICE_ITTXFE          \ [0x04] IN token received when TxFIFO is empty
    $06 constant OTG1_HS_DEVICE_INEPNE          \ [0x06] IN endpoint NAK effective
    $07 constant OTG1_HS_DEVICE_TXFE            \ [0x07] Transmit FIFO empty
    $08 constant OTG1_HS_DEVICE_TXFIFOUDRN      \ [0x08] Transmit Fifo Underrun
    $09 constant OTG1_HS_DEVICE_BNA             \ [0x09] Buffer not available interrupt
    $0b constant OTG1_HS_DEVICE_PKTDRPSTS       \ [0x0b] Packet dropped status
    $0c constant OTG1_HS_DEVICE_BERR            \ [0x0c] Babble error interrupt
    $0d constant OTG1_HS_DEVICE_NAK             \ [0x0d] NAK interrupt
  [then]


  [ifdef] OTG1_HS_DEVICE_OTG_HS_DIEPTSIZ3_DEF
    \
    \ @brief OTG_HS device endpoint transfer size register
    \ Address offset: 0x170
    \ Reset value: 0x00000000
    \
    $00 constant OTG1_HS_DEVICE_XFRSIZ          \ [0x00 : 19] Transfer size
    $13 constant OTG1_HS_DEVICE_PKTCNT          \ [0x13 : 10] Packet count
    $1d constant OTG1_HS_DEVICE_MCNT            \ [0x1d : 2] Multi count
  [then]


  [ifdef] OTG1_HS_DEVICE_OTG_HS_DIEPDMA4_DEF
    \
    \ @brief OTG_HS device endpoint-4 DMA address register
    \ Address offset: 0x174
    \ Reset value: 0x00000000
    \
    $00 constant OTG1_HS_DEVICE_DMAADDR         \ [0x00 : 32] DMA address
  [then]


  [ifdef] OTG1_HS_DEVICE_OTG_HS_DTXFSTS3_DEF
    \
    \ @brief OTG_HS device IN endpoint transmit FIFO status register
    \ Address offset: 0x178
    \ Reset value: 0x00000000
    \
    $00 constant OTG1_HS_DEVICE_INEPTFSAV       \ [0x00 : 16] IN endpoint TxFIFO space avail
  [then]


  [ifdef] OTG1_HS_DEVICE_OTG_HS_DIEPCTL4_DEF
    \
    \ @brief OTG device endpoint-4 control register
    \ Address offset: 0x180
    \ Reset value: 0x00000000
    \
    $00 constant OTG1_HS_DEVICE_MPSIZ           \ [0x00 : 11] Maximum packet size
    $0f constant OTG1_HS_DEVICE_USBAEP          \ [0x0f] USB active endpoint
    $10 constant OTG1_HS_DEVICE_EONUM_DPID      \ [0x10] Even/odd frame
    $11 constant OTG1_HS_DEVICE_NAKSTS          \ [0x11] NAK status
    $12 constant OTG1_HS_DEVICE_EPTYP           \ [0x12 : 2] Endpoint type
    $15 constant OTG1_HS_DEVICE_Stall           \ [0x15] STALL handshake
    $16 constant OTG1_HS_DEVICE_TXFNUM          \ [0x16 : 4] TxFIFO number
    $1a constant OTG1_HS_DEVICE_CNAK            \ [0x1a] Clear NAK
    $1b constant OTG1_HS_DEVICE_SNAK            \ [0x1b] Set NAK
    $1c constant OTG1_HS_DEVICE_SD0PID_SEVNFRM  \ [0x1c] Set DATA0 PID
    $1d constant OTG1_HS_DEVICE_SODDFRM         \ [0x1d] Set odd frame
    $1e constant OTG1_HS_DEVICE_EPDIS           \ [0x1e] Endpoint disable
    $1f constant OTG1_HS_DEVICE_EPENA           \ [0x1f] Endpoint enable
  [then]


  [ifdef] OTG1_HS_DEVICE_OTG_HS_DIEPINT4_DEF
    \
    \ @brief OTG device endpoint-4 interrupt register
    \ Address offset: 0x188
    \ Reset value: 0x00000000
    \
    $00 constant OTG1_HS_DEVICE_XFRC            \ [0x00] Transfer completed interrupt
    $01 constant OTG1_HS_DEVICE_EPDISD          \ [0x01] Endpoint disabled interrupt
    $03 constant OTG1_HS_DEVICE_TOC             \ [0x03] Timeout condition
    $04 constant OTG1_HS_DEVICE_ITTXFE          \ [0x04] IN token received when TxFIFO is empty
    $06 constant OTG1_HS_DEVICE_INEPNE          \ [0x06] IN endpoint NAK effective
    $07 constant OTG1_HS_DEVICE_TXFE            \ [0x07] Transmit FIFO empty
    $08 constant OTG1_HS_DEVICE_TXFIFOUDRN      \ [0x08] Transmit Fifo Underrun
    $09 constant OTG1_HS_DEVICE_BNA             \ [0x09] Buffer not available interrupt
    $0b constant OTG1_HS_DEVICE_PKTDRPSTS       \ [0x0b] Packet dropped status
    $0c constant OTG1_HS_DEVICE_BERR            \ [0x0c] Babble error interrupt
    $0d constant OTG1_HS_DEVICE_NAK             \ [0x0d] NAK interrupt
  [then]


  [ifdef] OTG1_HS_DEVICE_OTG_HS_DIEPTSIZ4_DEF
    \
    \ @brief OTG_HS device endpoint transfer size register
    \ Address offset: 0x190
    \ Reset value: 0x00000000
    \
    $00 constant OTG1_HS_DEVICE_XFRSIZ          \ [0x00 : 19] Transfer size
    $13 constant OTG1_HS_DEVICE_PKTCNT          \ [0x13 : 10] Packet count
    $1d constant OTG1_HS_DEVICE_MCNT            \ [0x1d : 2] Multi count
  [then]


  [ifdef] OTG1_HS_DEVICE_OTG_HS_DIEPDMA5_DEF
    \
    \ @brief OTG_HS device endpoint-5 DMA address register
    \ Address offset: 0x194
    \ Reset value: 0x00000000
    \
    $00 constant OTG1_HS_DEVICE_DMAADDR         \ [0x00 : 32] DMA address
  [then]


  [ifdef] OTG1_HS_DEVICE_OTG_HS_DTXFSTS4_DEF
    \
    \ @brief OTG_HS device IN endpoint transmit FIFO status register
    \ Address offset: 0x198
    \ Reset value: 0x00000000
    \
    $00 constant OTG1_HS_DEVICE_INEPTFSAV       \ [0x00 : 16] IN endpoint TxFIFO space avail
  [then]


  [ifdef] OTG1_HS_DEVICE_OTG_HS_DIEPCTL5_DEF
    \
    \ @brief OTG device endpoint-5 control register
    \ Address offset: 0x1A0
    \ Reset value: 0x00000000
    \
    $00 constant OTG1_HS_DEVICE_MPSIZ           \ [0x00 : 11] Maximum packet size
    $0f constant OTG1_HS_DEVICE_USBAEP          \ [0x0f] USB active endpoint
    $10 constant OTG1_HS_DEVICE_EONUM_DPID      \ [0x10] Even/odd frame
    $11 constant OTG1_HS_DEVICE_NAKSTS          \ [0x11] NAK status
    $12 constant OTG1_HS_DEVICE_EPTYP           \ [0x12 : 2] Endpoint type
    $15 constant OTG1_HS_DEVICE_Stall           \ [0x15] STALL handshake
    $16 constant OTG1_HS_DEVICE_TXFNUM          \ [0x16 : 4] TxFIFO number
    $1a constant OTG1_HS_DEVICE_CNAK            \ [0x1a] Clear NAK
    $1b constant OTG1_HS_DEVICE_SNAK            \ [0x1b] Set NAK
    $1c constant OTG1_HS_DEVICE_SD0PID_SEVNFRM  \ [0x1c] Set DATA0 PID
    $1d constant OTG1_HS_DEVICE_SODDFRM         \ [0x1d] Set odd frame
    $1e constant OTG1_HS_DEVICE_EPDIS           \ [0x1e] Endpoint disable
    $1f constant OTG1_HS_DEVICE_EPENA           \ [0x1f] Endpoint enable
  [then]


  [ifdef] OTG1_HS_DEVICE_OTG_HS_DIEPTSIZ6_DEF
    \
    \ @brief OTG_HS device endpoint transfer size register
    \ Address offset: 0x1A0
    \ Reset value: 0x00000000
    \
    $00 constant OTG1_HS_DEVICE_XFRSIZ          \ [0x00 : 19] Transfer size
    $13 constant OTG1_HS_DEVICE_PKTCNT          \ [0x13 : 10] Packet count
    $1d constant OTG1_HS_DEVICE_MCNT            \ [0x1d : 2] Multi count
  [then]


  [ifdef] OTG1_HS_DEVICE_OTG_HS_DTXFSTS6_DEF
    \
    \ @brief OTG_HS device IN endpoint transmit FIFO status register
    \ Address offset: 0x1A4
    \ Reset value: 0x00000000
    \
    $00 constant OTG1_HS_DEVICE_INEPTFSAV       \ [0x00 : 16] IN endpoint TxFIFO space avail
  [then]


  [ifdef] OTG1_HS_DEVICE_OTG_HS_DIEPINT5_DEF
    \
    \ @brief OTG device endpoint-5 interrupt register
    \ Address offset: 0x1A8
    \ Reset value: 0x00000000
    \
    $00 constant OTG1_HS_DEVICE_XFRC            \ [0x00] Transfer completed interrupt
    $01 constant OTG1_HS_DEVICE_EPDISD          \ [0x01] Endpoint disabled interrupt
    $03 constant OTG1_HS_DEVICE_TOC             \ [0x03] Timeout condition
    $04 constant OTG1_HS_DEVICE_ITTXFE          \ [0x04] IN token received when TxFIFO is empty
    $06 constant OTG1_HS_DEVICE_INEPNE          \ [0x06] IN endpoint NAK effective
    $07 constant OTG1_HS_DEVICE_TXFE            \ [0x07] Transmit FIFO empty
    $08 constant OTG1_HS_DEVICE_TXFIFOUDRN      \ [0x08] Transmit Fifo Underrun
    $09 constant OTG1_HS_DEVICE_BNA             \ [0x09] Buffer not available interrupt
    $0b constant OTG1_HS_DEVICE_PKTDRPSTS       \ [0x0b] Packet dropped status
    $0c constant OTG1_HS_DEVICE_BERR            \ [0x0c] Babble error interrupt
    $0d constant OTG1_HS_DEVICE_NAK             \ [0x0d] NAK interrupt
  [then]


  [ifdef] OTG1_HS_DEVICE_OTG_HS_DIEPTSIZ7_DEF
    \
    \ @brief OTG_HS device endpoint transfer size register
    \ Address offset: 0x1A8
    \ Reset value: 0x00000000
    \
    $00 constant OTG1_HS_DEVICE_XFRSIZ          \ [0x00 : 19] Transfer size
    $13 constant OTG1_HS_DEVICE_PKTCNT          \ [0x13 : 10] Packet count
    $1d constant OTG1_HS_DEVICE_MCNT            \ [0x1d : 2] Multi count
  [then]


  [ifdef] OTG1_HS_DEVICE_OTG_HS_DTXFSTS7_DEF
    \
    \ @brief OTG_HS device IN endpoint transmit FIFO status register
    \ Address offset: 0x1AC
    \ Reset value: 0x00000000
    \
    $00 constant OTG1_HS_DEVICE_INEPTFSAV       \ [0x00 : 16] IN endpoint TxFIFO space avail
  [then]


  [ifdef] OTG1_HS_DEVICE_OTG_HS_DIEPTSIZ5_DEF
    \
    \ @brief OTG_HS device endpoint transfer size register
    \ Address offset: 0x1B0
    \ Reset value: 0x00000000
    \
    $00 constant OTG1_HS_DEVICE_XFRSIZ          \ [0x00 : 19] Transfer size
    $13 constant OTG1_HS_DEVICE_PKTCNT          \ [0x13 : 10] Packet count
    $1d constant OTG1_HS_DEVICE_MCNT            \ [0x1d : 2] Multi count
  [then]


  [ifdef] OTG1_HS_DEVICE_OTG_HS_DTXFSTS5_DEF
    \
    \ @brief OTG_HS device IN endpoint transmit FIFO status register
    \ Address offset: 0x1B8
    \ Reset value: 0x00000000
    \
    $00 constant OTG1_HS_DEVICE_INEPTFSAV       \ [0x00 : 16] IN endpoint TxFIFO space avail
  [then]


  [ifdef] OTG1_HS_DEVICE_OTG_HS_DIEPCTL6_DEF
    \
    \ @brief OTG device endpoint-6 control register
    \ Address offset: 0x1C0
    \ Reset value: 0x00000000
    \
    $00 constant OTG1_HS_DEVICE_MPSIZ           \ [0x00 : 11] Maximum packet size
    $0f constant OTG1_HS_DEVICE_USBAEP          \ [0x0f] USB active endpoint
    $10 constant OTG1_HS_DEVICE_EONUM_DPID      \ [0x10] Even/odd frame
    $11 constant OTG1_HS_DEVICE_NAKSTS          \ [0x11] NAK status
    $12 constant OTG1_HS_DEVICE_EPTYP           \ [0x12 : 2] Endpoint type
    $15 constant OTG1_HS_DEVICE_Stall           \ [0x15] STALL handshake
    $16 constant OTG1_HS_DEVICE_TXFNUM          \ [0x16 : 4] TxFIFO number
    $1a constant OTG1_HS_DEVICE_CNAK            \ [0x1a] Clear NAK
    $1b constant OTG1_HS_DEVICE_SNAK            \ [0x1b] Set NAK
    $1c constant OTG1_HS_DEVICE_SD0PID_SEVNFRM  \ [0x1c] Set DATA0 PID
    $1d constant OTG1_HS_DEVICE_SODDFRM         \ [0x1d] Set odd frame
    $1e constant OTG1_HS_DEVICE_EPDIS           \ [0x1e] Endpoint disable
    $1f constant OTG1_HS_DEVICE_EPENA           \ [0x1f] Endpoint enable
  [then]


  [ifdef] OTG1_HS_DEVICE_OTG_HS_DIEPINT6_DEF
    \
    \ @brief OTG device endpoint-6 interrupt register
    \ Address offset: 0x1C8
    \ Reset value: 0x00000000
    \
    $00 constant OTG1_HS_DEVICE_XFRC            \ [0x00] Transfer completed interrupt
    $01 constant OTG1_HS_DEVICE_EPDISD          \ [0x01] Endpoint disabled interrupt
    $03 constant OTG1_HS_DEVICE_TOC             \ [0x03] Timeout condition
    $04 constant OTG1_HS_DEVICE_ITTXFE          \ [0x04] IN token received when TxFIFO is empty
    $06 constant OTG1_HS_DEVICE_INEPNE          \ [0x06] IN endpoint NAK effective
    $07 constant OTG1_HS_DEVICE_TXFE            \ [0x07] Transmit FIFO empty
    $08 constant OTG1_HS_DEVICE_TXFIFOUDRN      \ [0x08] Transmit Fifo Underrun
    $09 constant OTG1_HS_DEVICE_BNA             \ [0x09] Buffer not available interrupt
    $0b constant OTG1_HS_DEVICE_PKTDRPSTS       \ [0x0b] Packet dropped status
    $0c constant OTG1_HS_DEVICE_BERR            \ [0x0c] Babble error interrupt
    $0d constant OTG1_HS_DEVICE_NAK             \ [0x0d] NAK interrupt
  [then]


  [ifdef] OTG1_HS_DEVICE_OTG_HS_DIEPCTL7_DEF
    \
    \ @brief OTG device endpoint-7 control register
    \ Address offset: 0x1E0
    \ Reset value: 0x00000000
    \
    $00 constant OTG1_HS_DEVICE_MPSIZ           \ [0x00 : 11] Maximum packet size
    $0f constant OTG1_HS_DEVICE_USBAEP          \ [0x0f] USB active endpoint
    $10 constant OTG1_HS_DEVICE_EONUM_DPID      \ [0x10] Even/odd frame
    $11 constant OTG1_HS_DEVICE_NAKSTS          \ [0x11] NAK status
    $12 constant OTG1_HS_DEVICE_EPTYP           \ [0x12 : 2] Endpoint type
    $15 constant OTG1_HS_DEVICE_Stall           \ [0x15] STALL handshake
    $16 constant OTG1_HS_DEVICE_TXFNUM          \ [0x16 : 4] TxFIFO number
    $1a constant OTG1_HS_DEVICE_CNAK            \ [0x1a] Clear NAK
    $1b constant OTG1_HS_DEVICE_SNAK            \ [0x1b] Set NAK
    $1c constant OTG1_HS_DEVICE_SD0PID_SEVNFRM  \ [0x1c] Set DATA0 PID
    $1d constant OTG1_HS_DEVICE_SODDFRM         \ [0x1d] Set odd frame
    $1e constant OTG1_HS_DEVICE_EPDIS           \ [0x1e] Endpoint disable
    $1f constant OTG1_HS_DEVICE_EPENA           \ [0x1f] Endpoint enable
  [then]


  [ifdef] OTG1_HS_DEVICE_OTG_HS_DIEPINT7_DEF
    \
    \ @brief OTG device endpoint-7 interrupt register
    \ Address offset: 0x1E8
    \ Reset value: 0x00000000
    \
    $00 constant OTG1_HS_DEVICE_XFRC            \ [0x00] Transfer completed interrupt
    $01 constant OTG1_HS_DEVICE_EPDISD          \ [0x01] Endpoint disabled interrupt
    $03 constant OTG1_HS_DEVICE_TOC             \ [0x03] Timeout condition
    $04 constant OTG1_HS_DEVICE_ITTXFE          \ [0x04] IN token received when TxFIFO is empty
    $06 constant OTG1_HS_DEVICE_INEPNE          \ [0x06] IN endpoint NAK effective
    $07 constant OTG1_HS_DEVICE_TXFE            \ [0x07] Transmit FIFO empty
    $08 constant OTG1_HS_DEVICE_TXFIFOUDRN      \ [0x08] Transmit Fifo Underrun
    $09 constant OTG1_HS_DEVICE_BNA             \ [0x09] Buffer not available interrupt
    $0b constant OTG1_HS_DEVICE_PKTDRPSTS       \ [0x0b] Packet dropped status
    $0c constant OTG1_HS_DEVICE_BERR            \ [0x0c] Babble error interrupt
    $0d constant OTG1_HS_DEVICE_NAK             \ [0x0d] NAK interrupt
  [then]


  [ifdef] OTG1_HS_DEVICE_OTG_HS_DOEPCTL0_DEF
    \
    \ @brief OTG_HS device control OUT endpoint 0 control register
    \ Address offset: 0x300
    \ Reset value: 0x00008000
    \
    $00 constant OTG1_HS_DEVICE_MPSIZ           \ [0x00 : 2] Maximum packet size
    $0f constant OTG1_HS_DEVICE_USBAEP          \ [0x0f] USB active endpoint
    $11 constant OTG1_HS_DEVICE_NAKSTS          \ [0x11] NAK status
    $12 constant OTG1_HS_DEVICE_EPTYP           \ [0x12 : 2] Endpoint type
    $14 constant OTG1_HS_DEVICE_SNPM            \ [0x14] Snoop mode
    $15 constant OTG1_HS_DEVICE_Stall           \ [0x15] STALL handshake
    $1a constant OTG1_HS_DEVICE_CNAK            \ [0x1a] Clear NAK
    $1b constant OTG1_HS_DEVICE_SNAK            \ [0x1b] Set NAK
    $1e constant OTG1_HS_DEVICE_EPDIS           \ [0x1e] Endpoint disable
    $1f constant OTG1_HS_DEVICE_EPENA           \ [0x1f] Endpoint enable
  [then]


  [ifdef] OTG1_HS_DEVICE_OTG_HS_DOEPINT0_DEF
    \
    \ @brief OTG_HS device endpoint-0 interrupt register
    \ Address offset: 0x308
    \ Reset value: 0x00000080
    \
    $00 constant OTG1_HS_DEVICE_XFRC            \ [0x00] Transfer completed interrupt
    $01 constant OTG1_HS_DEVICE_EPDISD          \ [0x01] Endpoint disabled interrupt
    $03 constant OTG1_HS_DEVICE_STUP            \ [0x03] SETUP phase done
    $04 constant OTG1_HS_DEVICE_OTEPDIS         \ [0x04] OUT token received when endpoint disabled
    $06 constant OTG1_HS_DEVICE_B2BSTUP         \ [0x06] Back-to-back SETUP packets received
    $0e constant OTG1_HS_DEVICE_NYET            \ [0x0e] NYET interrupt
  [then]


  [ifdef] OTG1_HS_DEVICE_OTG_HS_DOEPTSIZ0_DEF
    \
    \ @brief OTG_HS device endpoint-0 transfer size register
    \ Address offset: 0x310
    \ Reset value: 0x00000000
    \
    $00 constant OTG1_HS_DEVICE_XFRSIZ          \ [0x00 : 7] Transfer size
    $13 constant OTG1_HS_DEVICE_PKTCNT          \ [0x13] Packet count
    $1d constant OTG1_HS_DEVICE_STUPCNT         \ [0x1d : 2] SETUP packet count
  [then]


  [ifdef] OTG1_HS_DEVICE_OTG_HS_DOEPCTL1_DEF
    \
    \ @brief OTG device endpoint-1 control register
    \ Address offset: 0x320
    \ Reset value: 0x00000000
    \
    $00 constant OTG1_HS_DEVICE_MPSIZ           \ [0x00 : 11] Maximum packet size
    $0f constant OTG1_HS_DEVICE_USBAEP          \ [0x0f] USB active endpoint
    $10 constant OTG1_HS_DEVICE_EONUM_DPID      \ [0x10] Even odd frame/Endpoint data PID
    $11 constant OTG1_HS_DEVICE_NAKSTS          \ [0x11] NAK status
    $12 constant OTG1_HS_DEVICE_EPTYP           \ [0x12 : 2] Endpoint type
    $14 constant OTG1_HS_DEVICE_SNPM            \ [0x14] Snoop mode
    $15 constant OTG1_HS_DEVICE_Stall           \ [0x15] STALL handshake
    $1a constant OTG1_HS_DEVICE_CNAK            \ [0x1a] Clear NAK
    $1b constant OTG1_HS_DEVICE_SNAK            \ [0x1b] Set NAK
    $1c constant OTG1_HS_DEVICE_SD0PID_SEVNFRM  \ [0x1c] Set DATA0 PID/Set even frame
    $1d constant OTG1_HS_DEVICE_SODDFRM         \ [0x1d] Set odd frame
    $1e constant OTG1_HS_DEVICE_EPDIS           \ [0x1e] Endpoint disable
    $1f constant OTG1_HS_DEVICE_EPENA           \ [0x1f] Endpoint enable
  [then]


  [ifdef] OTG1_HS_DEVICE_OTG_HS_DOEPINT1_DEF
    \
    \ @brief OTG_HS device endpoint-1 interrupt register
    \ Address offset: 0x328
    \ Reset value: 0x00000000
    \
    $00 constant OTG1_HS_DEVICE_XFRC            \ [0x00] Transfer completed interrupt
    $01 constant OTG1_HS_DEVICE_EPDISD          \ [0x01] Endpoint disabled interrupt
    $03 constant OTG1_HS_DEVICE_STUP            \ [0x03] SETUP phase done
    $04 constant OTG1_HS_DEVICE_OTEPDIS         \ [0x04] OUT token received when endpoint disabled
    $06 constant OTG1_HS_DEVICE_B2BSTUP         \ [0x06] Back-to-back SETUP packets received
    $0e constant OTG1_HS_DEVICE_NYET            \ [0x0e] NYET interrupt
  [then]


  [ifdef] OTG1_HS_DEVICE_OTG_HS_DOEPTSIZ1_DEF
    \
    \ @brief OTG_HS device endpoint-1 transfer size register
    \ Address offset: 0x330
    \ Reset value: 0x00000000
    \
    $00 constant OTG1_HS_DEVICE_XFRSIZ          \ [0x00 : 19] Transfer size
    $13 constant OTG1_HS_DEVICE_PKTCNT          \ [0x13 : 10] Packet count
    $1d constant OTG1_HS_DEVICE_RXDPID_STUPCNT  \ [0x1d : 2] Received data PID/SETUP packet count
  [then]


  [ifdef] OTG1_HS_DEVICE_OTG_HS_DOEPCTL2_DEF
    \
    \ @brief OTG device endpoint-2 control register
    \ Address offset: 0x340
    \ Reset value: 0x00000000
    \
    $00 constant OTG1_HS_DEVICE_MPSIZ           \ [0x00 : 11] Maximum packet size
    $0f constant OTG1_HS_DEVICE_USBAEP          \ [0x0f] USB active endpoint
    $10 constant OTG1_HS_DEVICE_EONUM_DPID      \ [0x10] Even odd frame/Endpoint data PID
    $11 constant OTG1_HS_DEVICE_NAKSTS          \ [0x11] NAK status
    $12 constant OTG1_HS_DEVICE_EPTYP           \ [0x12 : 2] Endpoint type
    $14 constant OTG1_HS_DEVICE_SNPM            \ [0x14] Snoop mode
    $15 constant OTG1_HS_DEVICE_Stall           \ [0x15] STALL handshake
    $1a constant OTG1_HS_DEVICE_CNAK            \ [0x1a] Clear NAK
    $1b constant OTG1_HS_DEVICE_SNAK            \ [0x1b] Set NAK
    $1c constant OTG1_HS_DEVICE_SD0PID_SEVNFRM  \ [0x1c] Set DATA0 PID/Set even frame
    $1d constant OTG1_HS_DEVICE_SODDFRM         \ [0x1d] Set odd frame
    $1e constant OTG1_HS_DEVICE_EPDIS           \ [0x1e] Endpoint disable
    $1f constant OTG1_HS_DEVICE_EPENA           \ [0x1f] Endpoint enable
  [then]


  [ifdef] OTG1_HS_DEVICE_OTG_HS_DOEPINT2_DEF
    \
    \ @brief OTG_HS device endpoint-2 interrupt register
    \ Address offset: 0x348
    \ Reset value: 0x00000000
    \
    $00 constant OTG1_HS_DEVICE_XFRC            \ [0x00] Transfer completed interrupt
    $01 constant OTG1_HS_DEVICE_EPDISD          \ [0x01] Endpoint disabled interrupt
    $03 constant OTG1_HS_DEVICE_STUP            \ [0x03] SETUP phase done
    $04 constant OTG1_HS_DEVICE_OTEPDIS         \ [0x04] OUT token received when endpoint disabled
    $06 constant OTG1_HS_DEVICE_B2BSTUP         \ [0x06] Back-to-back SETUP packets received
    $0e constant OTG1_HS_DEVICE_NYET            \ [0x0e] NYET interrupt
  [then]


  [ifdef] OTG1_HS_DEVICE_OTG_HS_DOEPTSIZ2_DEF
    \
    \ @brief OTG_HS device endpoint-2 transfer size register
    \ Address offset: 0x350
    \ Reset value: 0x00000000
    \
    $00 constant OTG1_HS_DEVICE_XFRSIZ          \ [0x00 : 19] Transfer size
    $13 constant OTG1_HS_DEVICE_PKTCNT          \ [0x13 : 10] Packet count
    $1d constant OTG1_HS_DEVICE_RXDPID_STUPCNT  \ [0x1d : 2] Received data PID/SETUP packet count
  [then]


  [ifdef] OTG1_HS_DEVICE_OTG_HS_DOEPCTL3_DEF
    \
    \ @brief OTG device endpoint-3 control register
    \ Address offset: 0x360
    \ Reset value: 0x00000000
    \
    $00 constant OTG1_HS_DEVICE_MPSIZ           \ [0x00 : 11] Maximum packet size
    $0f constant OTG1_HS_DEVICE_USBAEP          \ [0x0f] USB active endpoint
    $10 constant OTG1_HS_DEVICE_EONUM_DPID      \ [0x10] Even odd frame/Endpoint data PID
    $11 constant OTG1_HS_DEVICE_NAKSTS          \ [0x11] NAK status
    $12 constant OTG1_HS_DEVICE_EPTYP           \ [0x12 : 2] Endpoint type
    $14 constant OTG1_HS_DEVICE_SNPM            \ [0x14] Snoop mode
    $15 constant OTG1_HS_DEVICE_Stall           \ [0x15] STALL handshake
    $1a constant OTG1_HS_DEVICE_CNAK            \ [0x1a] Clear NAK
    $1b constant OTG1_HS_DEVICE_SNAK            \ [0x1b] Set NAK
    $1c constant OTG1_HS_DEVICE_SD0PID_SEVNFRM  \ [0x1c] Set DATA0 PID/Set even frame
    $1d constant OTG1_HS_DEVICE_SODDFRM         \ [0x1d] Set odd frame
    $1e constant OTG1_HS_DEVICE_EPDIS           \ [0x1e] Endpoint disable
    $1f constant OTG1_HS_DEVICE_EPENA           \ [0x1f] Endpoint enable
  [then]


  [ifdef] OTG1_HS_DEVICE_OTG_HS_DOEPINT3_DEF
    \
    \ @brief OTG_HS device endpoint-3 interrupt register
    \ Address offset: 0x368
    \ Reset value: 0x00000000
    \
    $00 constant OTG1_HS_DEVICE_XFRC            \ [0x00] Transfer completed interrupt
    $01 constant OTG1_HS_DEVICE_EPDISD          \ [0x01] Endpoint disabled interrupt
    $03 constant OTG1_HS_DEVICE_STUP            \ [0x03] SETUP phase done
    $04 constant OTG1_HS_DEVICE_OTEPDIS         \ [0x04] OUT token received when endpoint disabled
    $06 constant OTG1_HS_DEVICE_B2BSTUP         \ [0x06] Back-to-back SETUP packets received
    $0e constant OTG1_HS_DEVICE_NYET            \ [0x0e] NYET interrupt
  [then]


  [ifdef] OTG1_HS_DEVICE_OTG_HS_DOEPTSIZ3_DEF
    \
    \ @brief OTG_HS device endpoint-3 transfer size register
    \ Address offset: 0x370
    \ Reset value: 0x00000000
    \
    $00 constant OTG1_HS_DEVICE_XFRSIZ          \ [0x00 : 19] Transfer size
    $13 constant OTG1_HS_DEVICE_PKTCNT          \ [0x13 : 10] Packet count
    $1d constant OTG1_HS_DEVICE_RXDPID_STUPCNT  \ [0x1d : 2] Received data PID/SETUP packet count
  [then]


  [ifdef] OTG1_HS_DEVICE_OTG_HS_DOEPCTL4_DEF
    \
    \ @brief OTG device endpoint-4 control register
    \ Address offset: 0x380
    \ Reset value: 0x00000000
    \
    $00 constant OTG1_HS_DEVICE_MPSIZ           \ [0x00 : 11] Maximum packet size
    $0f constant OTG1_HS_DEVICE_USBAEP          \ [0x0f] USB active endpoint
    $10 constant OTG1_HS_DEVICE_EONUM_DPID      \ [0x10] Even odd frame/Endpoint data PID
    $11 constant OTG1_HS_DEVICE_NAKSTS          \ [0x11] NAK status
    $12 constant OTG1_HS_DEVICE_EPTYP           \ [0x12 : 2] Endpoint type
    $14 constant OTG1_HS_DEVICE_SNPM            \ [0x14] Snoop mode
    $15 constant OTG1_HS_DEVICE_Stall           \ [0x15] STALL handshake
    $1a constant OTG1_HS_DEVICE_CNAK            \ [0x1a] Clear NAK
    $1b constant OTG1_HS_DEVICE_SNAK            \ [0x1b] Set NAK
    $1c constant OTG1_HS_DEVICE_SD0PID_SEVNFRM  \ [0x1c] Set DATA0 PID/Set even frame
    $1d constant OTG1_HS_DEVICE_SODDFRM         \ [0x1d] Set odd frame
    $1e constant OTG1_HS_DEVICE_EPDIS           \ [0x1e] Endpoint disable
    $1f constant OTG1_HS_DEVICE_EPENA           \ [0x1f] Endpoint enable
  [then]


  [ifdef] OTG1_HS_DEVICE_OTG_HS_DOEPINT4_DEF
    \
    \ @brief OTG_HS device endpoint-4 interrupt register
    \ Address offset: 0x388
    \ Reset value: 0x00000000
    \
    $00 constant OTG1_HS_DEVICE_XFRC            \ [0x00] Transfer completed interrupt
    $01 constant OTG1_HS_DEVICE_EPDISD          \ [0x01] Endpoint disabled interrupt
    $03 constant OTG1_HS_DEVICE_STUP            \ [0x03] SETUP phase done
    $04 constant OTG1_HS_DEVICE_OTEPDIS         \ [0x04] OUT token received when endpoint disabled
    $06 constant OTG1_HS_DEVICE_B2BSTUP         \ [0x06] Back-to-back SETUP packets received
    $0e constant OTG1_HS_DEVICE_NYET            \ [0x0e] NYET interrupt
  [then]


  [ifdef] OTG1_HS_DEVICE_OTG_HS_DOEPTSIZ4_DEF
    \
    \ @brief OTG_HS device endpoint-4 transfer size register
    \ Address offset: 0x390
    \ Reset value: 0x00000000
    \
    $00 constant OTG1_HS_DEVICE_XFRSIZ          \ [0x00 : 19] Transfer size
    $13 constant OTG1_HS_DEVICE_PKTCNT          \ [0x13 : 10] Packet count
    $1d constant OTG1_HS_DEVICE_RXDPID_STUPCNT  \ [0x1d : 2] Received data PID/SETUP packet count
  [then]


  [ifdef] OTG1_HS_DEVICE_OTG_HS_DOEPCTL5_DEF
    \
    \ @brief OTG device endpoint-5 control register
    \ Address offset: 0x3A0
    \ Reset value: 0x00000000
    \
    $00 constant OTG1_HS_DEVICE_MPSIZ           \ [0x00 : 11] Maximum packet size
    $0f constant OTG1_HS_DEVICE_USBAEP          \ [0x0f] USB active endpoint
    $10 constant OTG1_HS_DEVICE_EONUM_DPID      \ [0x10] Even odd frame/Endpoint data PID
    $11 constant OTG1_HS_DEVICE_NAKSTS          \ [0x11] NAK status
    $12 constant OTG1_HS_DEVICE_EPTYP           \ [0x12 : 2] Endpoint type
    $14 constant OTG1_HS_DEVICE_SNPM            \ [0x14] Snoop mode
    $15 constant OTG1_HS_DEVICE_Stall           \ [0x15] STALL handshake
    $1a constant OTG1_HS_DEVICE_CNAK            \ [0x1a] Clear NAK
    $1b constant OTG1_HS_DEVICE_SNAK            \ [0x1b] Set NAK
    $1c constant OTG1_HS_DEVICE_SD0PID_SEVNFRM  \ [0x1c] Set DATA0 PID/Set even frame
    $1d constant OTG1_HS_DEVICE_SODDFRM         \ [0x1d] Set odd frame
    $1e constant OTG1_HS_DEVICE_EPDIS           \ [0x1e] Endpoint disable
    $1f constant OTG1_HS_DEVICE_EPENA           \ [0x1f] Endpoint enable
  [then]


  [ifdef] OTG1_HS_DEVICE_OTG_HS_DOEPINT5_DEF
    \
    \ @brief OTG_HS device endpoint-5 interrupt register
    \ Address offset: 0x3A8
    \ Reset value: 0x00000000
    \
    $00 constant OTG1_HS_DEVICE_XFRC            \ [0x00] Transfer completed interrupt
    $01 constant OTG1_HS_DEVICE_EPDISD          \ [0x01] Endpoint disabled interrupt
    $03 constant OTG1_HS_DEVICE_STUP            \ [0x03] SETUP phase done
    $04 constant OTG1_HS_DEVICE_OTEPDIS         \ [0x04] OUT token received when endpoint disabled
    $06 constant OTG1_HS_DEVICE_B2BSTUP         \ [0x06] Back-to-back SETUP packets received
    $0e constant OTG1_HS_DEVICE_NYET            \ [0x0e] NYET interrupt
  [then]


  [ifdef] OTG1_HS_DEVICE_OTG_HS_DOEPTSIZ5_DEF
    \
    \ @brief OTG_HS device endpoint-5 transfer size register
    \ Address offset: 0x3B0
    \ Reset value: 0x00000000
    \
    $00 constant OTG1_HS_DEVICE_XFRSIZ          \ [0x00 : 19] Transfer size
    $13 constant OTG1_HS_DEVICE_PKTCNT          \ [0x13 : 10] Packet count
    $1d constant OTG1_HS_DEVICE_RXDPID_STUPCNT  \ [0x1d : 2] Received data PID/SETUP packet count
  [then]


  [ifdef] OTG1_HS_DEVICE_OTG_HS_DOEPCTL6_DEF
    \
    \ @brief OTG device endpoint-6 control register
    \ Address offset: 0x3C0
    \ Reset value: 0x00000000
    \
    $00 constant OTG1_HS_DEVICE_MPSIZ           \ [0x00 : 11] Maximum packet size
    $0f constant OTG1_HS_DEVICE_USBAEP          \ [0x0f] USB active endpoint
    $10 constant OTG1_HS_DEVICE_EONUM_DPID      \ [0x10] Even odd frame/Endpoint data PID
    $11 constant OTG1_HS_DEVICE_NAKSTS          \ [0x11] NAK status
    $12 constant OTG1_HS_DEVICE_EPTYP           \ [0x12 : 2] Endpoint type
    $14 constant OTG1_HS_DEVICE_SNPM            \ [0x14] Snoop mode
    $15 constant OTG1_HS_DEVICE_Stall           \ [0x15] STALL handshake
    $1a constant OTG1_HS_DEVICE_CNAK            \ [0x1a] Clear NAK
    $1b constant OTG1_HS_DEVICE_SNAK            \ [0x1b] Set NAK
    $1c constant OTG1_HS_DEVICE_SD0PID_SEVNFRM  \ [0x1c] Set DATA0 PID/Set even frame
    $1d constant OTG1_HS_DEVICE_SODDFRM         \ [0x1d] Set odd frame
    $1e constant OTG1_HS_DEVICE_EPDIS           \ [0x1e] Endpoint disable
    $1f constant OTG1_HS_DEVICE_EPENA           \ [0x1f] Endpoint enable
  [then]


  [ifdef] OTG1_HS_DEVICE_OTG_HS_DOEPINT6_DEF
    \
    \ @brief OTG_HS device endpoint-6 interrupt register
    \ Address offset: 0x3C8
    \ Reset value: 0x00000000
    \
    $00 constant OTG1_HS_DEVICE_XFRC            \ [0x00] Transfer completed interrupt
    $01 constant OTG1_HS_DEVICE_EPDISD          \ [0x01] Endpoint disabled interrupt
    $03 constant OTG1_HS_DEVICE_STUP            \ [0x03] SETUP phase done
    $04 constant OTG1_HS_DEVICE_OTEPDIS         \ [0x04] OUT token received when endpoint disabled
    $06 constant OTG1_HS_DEVICE_B2BSTUP         \ [0x06] Back-to-back SETUP packets received
    $0e constant OTG1_HS_DEVICE_NYET            \ [0x0e] NYET interrupt
  [then]


  [ifdef] OTG1_HS_DEVICE_OTG_HS_DOEPTSIZ6_DEF
    \
    \ @brief OTG_HS device endpoint-6 transfer size register
    \ Address offset: 0x3D0
    \ Reset value: 0x00000000
    \
    $00 constant OTG1_HS_DEVICE_XFRSIZ          \ [0x00 : 19] Transfer size
    $13 constant OTG1_HS_DEVICE_PKTCNT          \ [0x13 : 10] Packet count
    $1d constant OTG1_HS_DEVICE_RXDPID_STUPCNT  \ [0x1d : 2] Received data PID/SETUP packet count
  [then]


  [ifdef] OTG1_HS_DEVICE_OTG_HS_DOEPCTL7_DEF
    \
    \ @brief OTG device endpoint-7 control register
    \ Address offset: 0x3E0
    \ Reset value: 0x00000000
    \
    $00 constant OTG1_HS_DEVICE_MPSIZ           \ [0x00 : 11] Maximum packet size
    $0f constant OTG1_HS_DEVICE_USBAEP          \ [0x0f] USB active endpoint
    $10 constant OTG1_HS_DEVICE_EONUM_DPID      \ [0x10] Even odd frame/Endpoint data PID
    $11 constant OTG1_HS_DEVICE_NAKSTS          \ [0x11] NAK status
    $12 constant OTG1_HS_DEVICE_EPTYP           \ [0x12 : 2] Endpoint type
    $14 constant OTG1_HS_DEVICE_SNPM            \ [0x14] Snoop mode
    $15 constant OTG1_HS_DEVICE_Stall           \ [0x15] STALL handshake
    $1a constant OTG1_HS_DEVICE_CNAK            \ [0x1a] Clear NAK
    $1b constant OTG1_HS_DEVICE_SNAK            \ [0x1b] Set NAK
    $1c constant OTG1_HS_DEVICE_SD0PID_SEVNFRM  \ [0x1c] Set DATA0 PID/Set even frame
    $1d constant OTG1_HS_DEVICE_SODDFRM         \ [0x1d] Set odd frame
    $1e constant OTG1_HS_DEVICE_EPDIS           \ [0x1e] Endpoint disable
    $1f constant OTG1_HS_DEVICE_EPENA           \ [0x1f] Endpoint enable
  [then]


  [ifdef] OTG1_HS_DEVICE_OTG_HS_DOEPINT7_DEF
    \
    \ @brief OTG_HS device endpoint-7 interrupt register
    \ Address offset: 0x3E8
    \ Reset value: 0x00000000
    \
    $00 constant OTG1_HS_DEVICE_XFRC            \ [0x00] Transfer completed interrupt
    $01 constant OTG1_HS_DEVICE_EPDISD          \ [0x01] Endpoint disabled interrupt
    $03 constant OTG1_HS_DEVICE_STUP            \ [0x03] SETUP phase done
    $04 constant OTG1_HS_DEVICE_OTEPDIS         \ [0x04] OUT token received when endpoint disabled
    $06 constant OTG1_HS_DEVICE_B2BSTUP         \ [0x06] Back-to-back SETUP packets received
    $0e constant OTG1_HS_DEVICE_NYET            \ [0x0e] NYET interrupt
  [then]


  [ifdef] OTG1_HS_DEVICE_OTG_HS_DOEPTSIZ7_DEF
    \
    \ @brief OTG_HS device endpoint-7 transfer size register
    \ Address offset: 0x3F0
    \ Reset value: 0x00000000
    \
    $00 constant OTG1_HS_DEVICE_XFRSIZ          \ [0x00 : 19] Transfer size
    $13 constant OTG1_HS_DEVICE_PKTCNT          \ [0x13 : 10] Packet count
    $1d constant OTG1_HS_DEVICE_RXDPID_STUPCNT  \ [0x1d : 2] Received data PID/SETUP packet count
  [then]

  \
  \ @brief USB 1 on the go high speed
  \
  $00 constant OTG1_HS_DEVICE_OTG_HS_DCFG    \ OTG_HS device configuration register
  $04 constant OTG1_HS_DEVICE_OTG_HS_DCTL    \ OTG_HS device control register
  $08 constant OTG1_HS_DEVICE_OTG_HS_DSTS    \ OTG_HS device status register
  $10 constant OTG1_HS_DEVICE_OTG_HS_DIEPMSK    \ OTG_HS device IN endpoint common interrupt mask register
  $14 constant OTG1_HS_DEVICE_OTG_HS_DOEPMSK    \ OTG_HS device OUT endpoint common interrupt mask register
  $18 constant OTG1_HS_DEVICE_OTG_HS_DAINT    \ OTG_HS device all endpoints interrupt register
  $1C constant OTG1_HS_DEVICE_OTG_HS_DAINTMSK    \ OTG_HS all endpoints interrupt mask register
  $28 constant OTG1_HS_DEVICE_OTG_HS_DVBUSDIS    \ OTG_HS device VBUS discharge time register
  $2C constant OTG1_HS_DEVICE_OTG_HS_DVBUSPULSE    \ OTG_HS device VBUS pulsing time register
  $30 constant OTG1_HS_DEVICE_OTG_HS_DTHRCTL    \ OTG_HS Device threshold control register
  $34 constant OTG1_HS_DEVICE_OTG_HS_DIEPEMPMSK    \ OTG_HS device IN endpoint FIFO empty interrupt mask register
  $38 constant OTG1_HS_DEVICE_OTG_HS_DEACHINT    \ OTG_HS device each endpoint interrupt register
  $3C constant OTG1_HS_DEVICE_OTG_HS_DEACHINTMSK    \ OTG_HS device each endpoint interrupt register mask
  $100 constant OTG1_HS_DEVICE_OTG_HS_DIEPCTL0    \ OTG device endpoint-0 control register
  $108 constant OTG1_HS_DEVICE_OTG_HS_DIEPINT0    \ OTG device endpoint-0 interrupt register
  $110 constant OTG1_HS_DEVICE_OTG_HS_DIEPTSIZ0    \ OTG_HS device IN endpoint 0 transfer size register
  $114 constant OTG1_HS_DEVICE_OTG_HS_DIEPDMA1    \ OTG_HS device endpoint-1 DMA address register
  $118 constant OTG1_HS_DEVICE_OTG_HS_DTXFSTS0    \ OTG_HS device IN endpoint transmit FIFO status register
  $120 constant OTG1_HS_DEVICE_OTG_HS_DIEPCTL1    \ OTG device endpoint-1 control register
  $128 constant OTG1_HS_DEVICE_OTG_HS_DIEPINT1    \ OTG device endpoint-1 interrupt register
  $130 constant OTG1_HS_DEVICE_OTG_HS_DIEPTSIZ1    \ OTG_HS device endpoint transfer size register
  $134 constant OTG1_HS_DEVICE_OTG_HS_DIEPDMA2    \ OTG_HS device endpoint-2 DMA address register
  $138 constant OTG1_HS_DEVICE_OTG_HS_DTXFSTS1    \ OTG_HS device IN endpoint transmit FIFO status register
  $140 constant OTG1_HS_DEVICE_OTG_HS_DIEPCTL2    \ OTG device endpoint-2 control register
  $148 constant OTG1_HS_DEVICE_OTG_HS_DIEPINT2    \ OTG device endpoint-2 interrupt register
  $150 constant OTG1_HS_DEVICE_OTG_HS_DIEPTSIZ2    \ OTG_HS device endpoint transfer size register
  $154 constant OTG1_HS_DEVICE_OTG_HS_DIEPDMA3    \ OTG_HS device endpoint-3 DMA address register
  $158 constant OTG1_HS_DEVICE_OTG_HS_DTXFSTS2    \ OTG_HS device IN endpoint transmit FIFO status register
  $160 constant OTG1_HS_DEVICE_OTG_HS_DIEPCTL3    \ OTG device endpoint-3 control register
  $168 constant OTG1_HS_DEVICE_OTG_HS_DIEPINT3    \ OTG device endpoint-3 interrupt register
  $170 constant OTG1_HS_DEVICE_OTG_HS_DIEPTSIZ3    \ OTG_HS device endpoint transfer size register
  $174 constant OTG1_HS_DEVICE_OTG_HS_DIEPDMA4    \ OTG_HS device endpoint-4 DMA address register
  $178 constant OTG1_HS_DEVICE_OTG_HS_DTXFSTS3    \ OTG_HS device IN endpoint transmit FIFO status register
  $180 constant OTG1_HS_DEVICE_OTG_HS_DIEPCTL4    \ OTG device endpoint-4 control register
  $188 constant OTG1_HS_DEVICE_OTG_HS_DIEPINT4    \ OTG device endpoint-4 interrupt register
  $190 constant OTG1_HS_DEVICE_OTG_HS_DIEPTSIZ4    \ OTG_HS device endpoint transfer size register
  $194 constant OTG1_HS_DEVICE_OTG_HS_DIEPDMA5    \ OTG_HS device endpoint-5 DMA address register
  $198 constant OTG1_HS_DEVICE_OTG_HS_DTXFSTS4    \ OTG_HS device IN endpoint transmit FIFO status register
  $1A0 constant OTG1_HS_DEVICE_OTG_HS_DIEPCTL5    \ OTG device endpoint-5 control register
  $1A0 constant OTG1_HS_DEVICE_OTG_HS_DIEPTSIZ6    \ OTG_HS device endpoint transfer size register
  $1A4 constant OTG1_HS_DEVICE_OTG_HS_DTXFSTS6    \ OTG_HS device IN endpoint transmit FIFO status register
  $1A8 constant OTG1_HS_DEVICE_OTG_HS_DIEPINT5    \ OTG device endpoint-5 interrupt register
  $1A8 constant OTG1_HS_DEVICE_OTG_HS_DIEPTSIZ7    \ OTG_HS device endpoint transfer size register
  $1AC constant OTG1_HS_DEVICE_OTG_HS_DTXFSTS7    \ OTG_HS device IN endpoint transmit FIFO status register
  $1B0 constant OTG1_HS_DEVICE_OTG_HS_DIEPTSIZ5    \ OTG_HS device endpoint transfer size register
  $1B8 constant OTG1_HS_DEVICE_OTG_HS_DTXFSTS5    \ OTG_HS device IN endpoint transmit FIFO status register
  $1C0 constant OTG1_HS_DEVICE_OTG_HS_DIEPCTL6    \ OTG device endpoint-6 control register
  $1C8 constant OTG1_HS_DEVICE_OTG_HS_DIEPINT6    \ OTG device endpoint-6 interrupt register
  $1E0 constant OTG1_HS_DEVICE_OTG_HS_DIEPCTL7    \ OTG device endpoint-7 control register
  $1E8 constant OTG1_HS_DEVICE_OTG_HS_DIEPINT7    \ OTG device endpoint-7 interrupt register
  $300 constant OTG1_HS_DEVICE_OTG_HS_DOEPCTL0    \ OTG_HS device control OUT endpoint 0 control register
  $308 constant OTG1_HS_DEVICE_OTG_HS_DOEPINT0    \ OTG_HS device endpoint-0 interrupt register
  $310 constant OTG1_HS_DEVICE_OTG_HS_DOEPTSIZ0    \ OTG_HS device endpoint-0 transfer size register
  $320 constant OTG1_HS_DEVICE_OTG_HS_DOEPCTL1    \ OTG device endpoint-1 control register
  $328 constant OTG1_HS_DEVICE_OTG_HS_DOEPINT1    \ OTG_HS device endpoint-1 interrupt register
  $330 constant OTG1_HS_DEVICE_OTG_HS_DOEPTSIZ1    \ OTG_HS device endpoint-1 transfer size register
  $340 constant OTG1_HS_DEVICE_OTG_HS_DOEPCTL2    \ OTG device endpoint-2 control register
  $348 constant OTG1_HS_DEVICE_OTG_HS_DOEPINT2    \ OTG_HS device endpoint-2 interrupt register
  $350 constant OTG1_HS_DEVICE_OTG_HS_DOEPTSIZ2    \ OTG_HS device endpoint-2 transfer size register
  $360 constant OTG1_HS_DEVICE_OTG_HS_DOEPCTL3    \ OTG device endpoint-3 control register
  $368 constant OTG1_HS_DEVICE_OTG_HS_DOEPINT3    \ OTG_HS device endpoint-3 interrupt register
  $370 constant OTG1_HS_DEVICE_OTG_HS_DOEPTSIZ3    \ OTG_HS device endpoint-3 transfer size register
  $380 constant OTG1_HS_DEVICE_OTG_HS_DOEPCTL4    \ OTG device endpoint-4 control register
  $388 constant OTG1_HS_DEVICE_OTG_HS_DOEPINT4    \ OTG_HS device endpoint-4 interrupt register
  $390 constant OTG1_HS_DEVICE_OTG_HS_DOEPTSIZ4    \ OTG_HS device endpoint-4 transfer size register
  $3A0 constant OTG1_HS_DEVICE_OTG_HS_DOEPCTL5    \ OTG device endpoint-5 control register
  $3A8 constant OTG1_HS_DEVICE_OTG_HS_DOEPINT5    \ OTG_HS device endpoint-5 interrupt register
  $3B0 constant OTG1_HS_DEVICE_OTG_HS_DOEPTSIZ5    \ OTG_HS device endpoint-5 transfer size register
  $3C0 constant OTG1_HS_DEVICE_OTG_HS_DOEPCTL6    \ OTG device endpoint-6 control register
  $3C8 constant OTG1_HS_DEVICE_OTG_HS_DOEPINT6    \ OTG_HS device endpoint-6 interrupt register
  $3D0 constant OTG1_HS_DEVICE_OTG_HS_DOEPTSIZ6    \ OTG_HS device endpoint-6 transfer size register
  $3E0 constant OTG1_HS_DEVICE_OTG_HS_DOEPCTL7    \ OTG device endpoint-7 control register
  $3E8 constant OTG1_HS_DEVICE_OTG_HS_DOEPINT7    \ OTG_HS device endpoint-7 interrupt register
  $3F0 constant OTG1_HS_DEVICE_OTG_HS_DOEPTSIZ7    \ OTG_HS device endpoint-7 transfer size register

: OTG1_HS_DEVICE_DEF ; [then]
