\
\ @file otg.fs
\ @brief USB on-the-go high-speed
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] OTG_DEF

  [ifdef] OTG_OTG_GOTGCTL_DEF
    \
    \ @brief OTG control and status register
    \ Address offset: 0x00
    \ Reset value: 0x00010000
    \
    $02 constant OTG_VBVALOEN                   \ [0x02] V less than sub>BUS less than /sub> valid override enable.
    $03 constant OTG_VBVALOVAL                  \ [0x03] V less than sub>BUS less than /sub> valid override value.
    $04 constant OTG_AVALOEN                    \ [0x04] A-peripheral session valid override enable.
    $05 constant OTG_AVALOVAL                   \ [0x05] A-peripheral session valid override value.
    $06 constant OTG_BVALOEN                    \ [0x06] B-peripheral session valid override enable.
    $07 constant OTG_BVALOVAL                   \ [0x07] B-peripheral session valid override value.
    $0c constant OTG_EHEN                       \ [0x0c] Embedded host enable
    $10 constant OTG_CIDSTS                     \ [0x10] Connector ID status
    $11 constant OTG_DBCT                       \ [0x11] Long/short debounce time
    $12 constant OTG_ASVLD                      \ [0x12] A-session valid
    $13 constant OTG_BSVLD                      \ [0x13] B-session valid
    $14 constant OTG_OTGVER                     \ [0x14] OTG version
    $15 constant OTG_CURMOD                     \ [0x15] Current mode of operation
  [then]


  [ifdef] OTG_OTG_GOTGINT_DEF
    \
    \ @brief OTG interrupt register
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $02 constant OTG_SEDET                      \ [0x02] Session end detected
    $12 constant OTG_ADTOCHG                    \ [0x12] A-device timeout change
  [then]


  [ifdef] OTG_OTG_GAHBCFG_DEF
    \
    \ @brief OTG AHB configuration register
    \ Address offset: 0x08
    \ Reset value: 0x00000000
    \
    $00 constant OTG_GINTMSK                    \ [0x00] Global interrupt mask
    $01 constant OTG_HBSTLEN                    \ [0x01 : 4] Burst length/type
    $05 constant OTG_DMAEN                      \ [0x05] DMA enabled
    $07 constant OTG_TXFELVL                    \ [0x07] Tx FIFO empty level
    $08 constant OTG_PTXFELVL                   \ [0x08] Periodic Tx FIFO empty level
  [then]


  [ifdef] OTG_OTG_GUSBCFG_DEF
    \
    \ @brief OTG USB configuration register
    \ Address offset: 0x0C
    \ Reset value: 0x00001400
    \
    $00 constant OTG_TOCAL                      \ [0x00 : 3] FS timeout calibration
    $0a constant OTG_TRDT                       \ [0x0a : 4] USB turnaround time
    $0f constant OTG_PHYLPC                     \ [0x0f] PHY Low-power clock select
    $16 constant OTG_TSDPS                      \ [0x16] TermSel DLine pulsing selection
    $1d constant OTG_FHMOD                      \ [0x1d] Force host mode
    $1e constant OTG_FDMOD                      \ [0x1e] Force device mode
  [then]


  [ifdef] OTG_OTG_GRSTCTL_DEF
    \
    \ @brief OTG reset register
    \ Address offset: 0x10
    \ Reset value: 0x80000000
    \
    $00 constant OTG_CSRST                      \ [0x00] Core soft reset
    $01 constant OTG_PSRST                      \ [0x01] Partial soft reset
    $02 constant OTG_FCRST                      \ [0x02] Host frame counter reset
    $04 constant OTG_RXFFLSH                    \ [0x04] Rx FIFO flush
    $05 constant OTG_TXFFLSH                    \ [0x05] Tx FIFO flush
    $06 constant OTG_TXFNUM                     \ [0x06 : 5] Tx FIFO number
    $1e constant OTG_DMAREQ                     \ [0x1e] DMA request signal enabled
    $1f constant OTG_AHBIDL                     \ [0x1f] AHB master idle
  [then]


  [ifdef] OTG_OTG_GINTSTS_DEF
    \
    \ @brief OTG core interrupt register [alternate]
    \ Address offset: 0x14
    \ Reset value: 0x04000020
    \
    $00 constant OTG_CMOD                       \ [0x00] Current mode of operation
    $01 constant OTG_MMIS                       \ [0x01] Mode mismatch interrupt
    $02 constant OTG_OTGINT                     \ [0x02] OTG interrupt
    $03 constant OTG_SOF                        \ [0x03] Start of frame
    $04 constant OTG_RXFLVL                     \ [0x04] Rx FIFO non-empty
    $05 constant OTG_NPTXFE                     \ [0x05] Non-periodic Tx FIFO empty
    $06 constant OTG_GINAKEFF                   \ [0x06] Global IN non-periodic NAK effective
    $07 constant OTG_GONAKEFF                   \ [0x07] Global OUT NAK effective
    $0a constant OTG_ESUSP                      \ [0x0a] Early suspend
    $0b constant OTG_USBSUSP                    \ [0x0b] USB suspend
    $0c constant OTG_USBRST                     \ [0x0c] USB reset
    $0d constant OTG_ENUMDNE                    \ [0x0d] Enumeration done
    $0e constant OTG_ISOODRP                    \ [0x0e] Isochronous OUT packet dropped interrupt
    $0f constant OTG_EOPF                       \ [0x0f] End of periodic frame interrupt
    $12 constant OTG_IEPINT                     \ [0x12] IN endpoint interrupt
    $13 constant OTG_OEPINT                     \ [0x13] OUT endpoint interrupt
    $14 constant OTG_IISOIXFR                   \ [0x14] Incomplete isochronous IN transfer
    $15 constant OTG_IPXFR                      \ [0x15] Incomplete periodic transfer
    $16 constant OTG_DATAFSUSP                  \ [0x16] Data fetch suspended
    $17 constant OTG_RSTDET                     \ [0x17] Reset detected interrupt
    $18 constant OTG_HPRTINT                    \ [0x18] Host port interrupt
    $19 constant OTG_HCINT                      \ [0x19] Host channels interrupt
    $1a constant OTG_PTXFE                      \ [0x1a] Periodic Tx FIFO empty
    $1b constant OTG_LPMINT                     \ [0x1b] LPM interrupt
    $1c constant OTG_CIDSCHG                    \ [0x1c] Connector ID status change
    $1d constant OTG_DISCINT                    \ [0x1d] Disconnect detected interrupt
    $1e constant OTG_SRQINT                     \ [0x1e] Session request/new session detected interrupt
    $1f constant OTG_WKUPINT                    \ [0x1f] Resume/remote wake-up detected interrupt
  [then]


  [ifdef] OTG_OTG_GINTSTS_ALTERNATE_DEF
    \
    \ @brief OTG core interrupt register [alternate]
    \ Address offset: 0x14
    \ Reset value: 0x04000020
    \
    $00 constant OTG_CMOD                       \ [0x00] Current mode of operation
    $01 constant OTG_MMIS                       \ [0x01] Mode mismatch interrupt
    $02 constant OTG_OTGINT                     \ [0x02] OTG interrupt
    $03 constant OTG_SOF                        \ [0x03] Start of frame
    $04 constant OTG_RXFLVL                     \ [0x04] Rx FIFO non-empty
    $05 constant OTG_NPTXFE                     \ [0x05] Non-periodic Tx FIFO empty
    $06 constant OTG_GINAKEFF                   \ [0x06] Global IN non-periodic NAK effective
    $07 constant OTG_GONAKEFF                   \ [0x07] Global OUT NAK effective
    $0a constant OTG_ESUSP                      \ [0x0a] Early suspend
    $0b constant OTG_USBSUSP                    \ [0x0b] USB suspend
    $0c constant OTG_USBRST                     \ [0x0c] USB reset
    $0d constant OTG_ENUMDNE                    \ [0x0d] Enumeration done
    $0e constant OTG_ISOODRP                    \ [0x0e] Isochronous OUT packet dropped interrupt
    $0f constant OTG_EOPF                       \ [0x0f] End of periodic frame interrupt
    $12 constant OTG_IEPINT                     \ [0x12] IN endpoint interrupt
    $13 constant OTG_OEPINT                     \ [0x13] OUT endpoint interrupt
    $14 constant OTG_IISOIXFR                   \ [0x14] Incomplete isochronous IN transfer
    $15 constant OTG_INCOMPISOOUT               \ [0x15] Incomplete isochronous OUT transfer
    $16 constant OTG_DATAFSUSP                  \ [0x16] Data fetch suspended
    $17 constant OTG_RSTDET                     \ [0x17] Reset detected interrupt
    $18 constant OTG_HPRTINT                    \ [0x18] Host port interrupt
    $19 constant OTG_HCINT                      \ [0x19] Host channels interrupt
    $1a constant OTG_PTXFE                      \ [0x1a] Periodic Tx FIFO empty
    $1b constant OTG_LPMINT                     \ [0x1b] LPM interrupt
    $1c constant OTG_CIDSCHG                    \ [0x1c] Connector ID status change
    $1d constant OTG_DISCINT                    \ [0x1d] Disconnect detected interrupt
    $1e constant OTG_SRQINT                     \ [0x1e] Session request/new session detected interrupt
    $1f constant OTG_WKUPINT                    \ [0x1f] Resume/remote wake-up detected interrupt
  [then]


  [ifdef] OTG_OTG_GINTMSK_DEF
    \
    \ @brief OTG interrupt mask register [alternate]
    \ Address offset: 0x18
    \ Reset value: 0x00000000
    \
    $01 constant OTG_MMISM                      \ [0x01] Mode mismatch interrupt mask
    $02 constant OTG_OTGINT                     \ [0x02] OTG interrupt mask
    $03 constant OTG_SOFM                       \ [0x03] Start of frame mask
    $04 constant OTG_RXFLVLM                    \ [0x04] Receive FIFO non-empty mask
    $05 constant OTG_NPTXFEM                    \ [0x05] Non-periodic Tx FIFO empty mask
    $15 constant OTG_IPXFRM                     \ [0x15] Incomplete periodic transfer mask
    $18 constant OTG_PRTIM                      \ [0x18] Host port interrupt mask
    $19 constant OTG_HCIM                       \ [0x19] Host channels interrupt mask
    $1a constant OTG_PTXFEM                     \ [0x1a] Periodic Tx FIFO empty mask
    $1b constant OTG_LPMINTM                    \ [0x1b] LPM interrupt mask
    $1c constant OTG_CIDSCHGM                   \ [0x1c] Connector ID status change mask
    $1d constant OTG_DISCINT                    \ [0x1d] Disconnect detected interrupt mask
    $1e constant OTG_SRQIM                      \ [0x1e] Session request/new session detected interrupt mask
    $1f constant OTG_WUIM                       \ [0x1f] Resume/remote wake-up detected interrupt mask
  [then]


  [ifdef] OTG_OTG_GINTMSK_ALTERNATE_DEF
    \
    \ @brief OTG interrupt mask register [alternate]
    \ Address offset: 0x18
    \ Reset value: 0x00000000
    \
    $01 constant OTG_MMISM                      \ [0x01] Mode mismatch interrupt mask
    $02 constant OTG_OTGINT                     \ [0x02] OTG interrupt mask
    $03 constant OTG_SOFM                       \ [0x03] Start of frame mask
    $04 constant OTG_RXFLVLM                    \ [0x04] Receive FIFO non-empty mask
    $06 constant OTG_GINAKEFFM                  \ [0x06] Global non-periodic IN NAK effective mask
    $07 constant OTG_GONAKEFFM                  \ [0x07] Global OUT NAK effective mask
    $0a constant OTG_ESUSPM                     \ [0x0a] Early suspend mask
    $0b constant OTG_USBSUSPM                   \ [0x0b] USB suspend mask
    $0c constant OTG_USBRST                     \ [0x0c] USB reset mask
    $0d constant OTG_ENUMDNEM                   \ [0x0d] Enumeration done mask
    $0e constant OTG_ISOODRPM                   \ [0x0e] Isochronous OUT packet dropped interrupt mask
    $0f constant OTG_EOPFM                      \ [0x0f] End of periodic frame interrupt mask
    $12 constant OTG_IEPINT                     \ [0x12] IN endpoints interrupt mask
    $13 constant OTG_OEPINT                     \ [0x13] OUT endpoints interrupt mask
    $14 constant OTG_IISOIXFRM                  \ [0x14] Incomplete isochronous IN transfer mask
    $15 constant OTG_IISOOXFRM                  \ [0x15] Incomplete isochronous OUT transfer mask
    $16 constant OTG_FSUSPM                     \ [0x16] Data fetch suspended mask
    $17 constant OTG_RSTDETM                    \ [0x17] Reset detected interrupt mask
    $1b constant OTG_LPMINTM                    \ [0x1b] LPM interrupt mask
    $1c constant OTG_CIDSCHGM                   \ [0x1c] Connector ID status change mask
    $1e constant OTG_SRQIM                      \ [0x1e] Session request/new session detected interrupt mask
    $1f constant OTG_WUIM                       \ [0x1f] Resume/remote wake-up detected interrupt mask
  [then]


  [ifdef] OTG_OTG_GRXSTSR_DEF
    \
    \ @brief OTG receive status debug read register [alternate]
    \ Address offset: 0x1C
    \ Reset value: 0x00000000
    \
    $00 constant OTG_EPNUM                      \ [0x00 : 4] Endpoint number
    $04 constant OTG_BCNT                       \ [0x04 : 11] Byte count
    $0f constant OTG_DPID                       \ [0x0f : 2] Data PID
    $11 constant OTG_PKTSTS                     \ [0x11 : 4] Packet status
    $15 constant OTG_FRMNUM                     \ [0x15 : 4] Frame number
    $1b constant OTG_STSPHST                    \ [0x1b] Status phase start
  [then]


  [ifdef] OTG_OTG_GRXSTSR_ALTERNATE_DEF
    \
    \ @brief OTG receive status debug read register [alternate]
    \ Address offset: 0x1C
    \ Reset value: 0x00000000
    \
    $00 constant OTG_CHNUM                      \ [0x00 : 4] Channel number
    $04 constant OTG_BCNT                       \ [0x04 : 11] Byte count
    $0f constant OTG_DPID                       \ [0x0f : 2] Data PID
    $11 constant OTG_PKTSTS                     \ [0x11 : 4] Packet status
  [then]


  [ifdef] OTG_OTG_GRXSTSP_DEF
    \
    \ @brief OTG status read and pop registers
    \ Address offset: 0x20
    \ Reset value: 0x00000000
    \
    $00 constant OTG_EPNUM                      \ [0x00 : 4] Endpoint number
    $04 constant OTG_BCNT                       \ [0x04 : 11] Byte count
    $0f constant OTG_DPID                       \ [0x0f : 2] Data PID
    $11 constant OTG_PKTSTS                     \ [0x11 : 4] Packet status
    $15 constant OTG_FRMNUM                     \ [0x15 : 4] Frame number
    $1b constant OTG_STSPHST                    \ [0x1b] Status phase start
  [then]


  [ifdef] OTG_OTG_GRXSTSP_ALTERNATE_DEF
    \
    \ @brief OTG status read and pop registers
    \ Address offset: 0x20
    \ Reset value: 0x00000000
    \
    $00 constant OTG_CHNUM                      \ [0x00 : 4] Channel number
    $04 constant OTG_BCNT                       \ [0x04 : 11] Byte count
    $0f constant OTG_DPID                       \ [0x0f : 2] Data PID
    $11 constant OTG_PKTSTS                     \ [0x11 : 4] Packet status
  [then]


  [ifdef] OTG_OTG_GRXFSIZ_DEF
    \
    \ @brief OTG receive FIFO size register
    \ Address offset: 0x24
    \ Reset value: 0x00000400
    \
    $00 constant OTG_RXFD                       \ [0x00 : 16] Rx FIFO depth
  [then]


  [ifdef] OTG_OTG_HNPTXFSIZ_DEF
    \
    \ @brief OTG host non-periodic transmit FIFO size register [alternate]
    \ Address offset: 0x28
    \ Reset value: 0x02000200
    \
    $00 constant OTG_NPTXFSA                    \ [0x00 : 16] Non-periodic transmit RAM start address
    $10 constant OTG_NPTXFD                     \ [0x10 : 16] Non-periodic Tx FIFO depth
  [then]


  [ifdef] OTG_OTG_HNPTXFSIZ_ALTERNATE_DEF
    \
    \ @brief OTG host non-periodic transmit FIFO size register [alternate]
    \ Address offset: 0x28
    \ Reset value: 0x02000200
    \
    $00 constant OTG_TX0FSA                     \ [0x00 : 16] Endpoint 0 transmit RAM start address
    $10 constant OTG_TX0FD                      \ [0x10 : 16] Endpoint 0 Tx FIFO depth
  [then]


  [ifdef] OTG_OTG_HNPTXSTS_DEF
    \
    \ @brief OTG non-periodic transmit FIFO/queue status register
    \ Address offset: 0x2C
    \ Reset value: 0x00080400
    \
    $00 constant OTG_NPTXFSAV                   \ [0x00 : 16] Non-periodic Tx FIFO space available
    $10 constant OTG_NPTQXSAV                   \ [0x10 : 8] Non-periodic transmit request queue space available
    $18 constant OTG_NPTXQTOP                   \ [0x18 : 7] Top of the non-periodic transmit request queue
  [then]


  [ifdef] OTG_OTG_GCCFG_DEF
    \
    \ @brief OTG general core configuration register
    \ Address offset: 0x38
    \ Reset value: 0x00000000
    \
    $00 constant OTG_CHGDET                     \ [0x00] Charger detection, result of the current mode (primary or secondary).
    $01 constant OTG_FSVPLUS                    \ [0x01] Single-Ended DP indicator
    $02 constant OTG_FSVMINUS                   \ [0x02] Single-Ended DM indicator
    $03 constant OTG_SESSVLD                    \ [0x03] VBUS session indicator
    $04 constant OTG_VBUSVLD                    \ [0x04] VBUS valid indicator
    $10 constant OTG_HCDPEN                     \ [0x10] Host CDP behavior enable
    $11 constant OTG_HCDPDETEN                  \ [0x11] Host CDP port voltage detector enable on DP
    $12 constant OTG_HVDMSRCEN                  \ [0x12] Host CDP port Voltage source enable on DM
    $13 constant OTG_DCDEN                      \ [0x13] Data Contact Detection enable
    $14 constant OTG_PDEN                       \ [0x14] Primary detection enable
    $16 constant OTG_SDEN                       \ [0x16] Secondary detection enable
    $17 constant OTG_VBVALOVAL                  \ [0x17] Software override value of the VBUS B-session detection
    $19 constant OTG_FORCEHOSTPD                \ [0x19] Force host mode pull-downs
    $1a constant OTG_BCDEN                      \ [0x1a] Force Battery charging (BC) mode
    $1c constant OTG_IDPULLUPDIS                \ [0x1c] Disable ID pin pull-up
  [then]


  [ifdef] OTG_OTG_CID_DEF
    \
    \ @brief OTG core ID register
    \ Address offset: 0x3C
    \ Reset value: 0x00005000
    \
    $00 constant OTG_PRODUCT_ID                 \ [0x00 : 32] Product ID field
  [then]


  [ifdef] OTG_OTG_GLPMCFG_DEF
    \
    \ @brief OTG core LPM configuration register
    \ Address offset: 0x54
    \ Reset value: 0x00000000
    \
    $00 constant OTG_LPMEN                      \ [0x00] LPM support enable
    $01 constant OTG_LPMACK                     \ [0x01] LPM token acknowledge enable
    $02 constant OTG_BESL                       \ [0x02 : 4] Best effort service latency
    $06 constant OTG_REMWAKE                    \ [0x06] bRemoteWake value
    $07 constant OTG_L1SSEN                     \ [0x07] L1 Shallow Sleep enable
    $08 constant OTG_BESLTHRS                   \ [0x08 : 4] BESL threshold
    $0c constant OTG_L1DSEN                     \ [0x0c] L1 deep sleep enable
    $0d constant OTG_LPMRSP                     \ [0x0d : 2] LPM response
    $0f constant OTG_SLPSTS                     \ [0x0f] Port sleep status
    $10 constant OTG_L1RSMOK                    \ [0x10] Sleep state resume OK
    $11 constant OTG_LPMCHIDX                   \ [0x11 : 4] LPM Channel Index
    $15 constant OTG_LPMRCNT                    \ [0x15 : 3] LPM retry count
    $18 constant OTG_SNDLPM                     \ [0x18] Send LPM transaction
    $19 constant OTG_LPMRCNTSTS                 \ [0x19 : 3] LPM retry count status
    $1c constant OTG_ENBESL                     \ [0x1c] Enable best effort service latency
  [then]


  [ifdef] OTG_OTG_HPTXFSIZ_DEF
    \
    \ @brief OTG host periodic transmit FIFO size register
    \ Address offset: 0x100
    \ Reset value: 0x04000800
    \
    $00 constant OTG_PTXSA                      \ [0x00 : 16] Host periodic Tx FIFO start address
    $10 constant OTG_PTXFSIZ                    \ [0x10 : 16] Host periodic Tx FIFO depth
  [then]


  [ifdef] OTG_OTG_DIEPTXF1_DEF
    \
    \ @brief OTG device IN endpoint transmit FIFO 1 size register
    \ Address offset: 0x104
    \ Reset value: 0x02000400
    \
    $00 constant OTG_INEPTXSA                   \ [0x00 : 16] IN endpoint FIFOx transmit RAM start address
    $10 constant OTG_INEPTXFD                   \ [0x10 : 16] IN endpoint Tx FIFO depth
  [then]


  [ifdef] OTG_OTG_DIEPTXF2_DEF
    \
    \ @brief OTG device IN endpoint transmit FIFO 2 size register
    \ Address offset: 0x108
    \ Reset value: 0x02000600
    \
    $00 constant OTG_INEPTXSA                   \ [0x00 : 16] IN endpoint FIFOx transmit RAM start address
    $10 constant OTG_INEPTXFD                   \ [0x10 : 16] IN endpoint Tx FIFO depth
  [then]


  [ifdef] OTG_OTG_DIEPTXF3_DEF
    \
    \ @brief OTG device IN endpoint transmit FIFO 3 size register
    \ Address offset: 0x10C
    \ Reset value: 0x02000800
    \
    $00 constant OTG_INEPTXSA                   \ [0x00 : 16] IN endpoint FIFOx transmit RAM start address
    $10 constant OTG_INEPTXFD                   \ [0x10 : 16] IN endpoint Tx FIFO depth
  [then]


  [ifdef] OTG_OTG_DIEPTXF4_DEF
    \
    \ @brief OTG device IN endpoint transmit FIFO 4 size register
    \ Address offset: 0x110
    \ Reset value: 0x02000A00
    \
    $00 constant OTG_INEPTXSA                   \ [0x00 : 16] IN endpoint FIFOx transmit RAM start address
    $10 constant OTG_INEPTXFD                   \ [0x10 : 16] IN endpoint Tx FIFO depth
  [then]


  [ifdef] OTG_OTG_DIEPTXF5_DEF
    \
    \ @brief OTG device IN endpoint transmit FIFO 5 size register
    \ Address offset: 0x114
    \ Reset value: 0x02000C00
    \
    $00 constant OTG_INEPTXSA                   \ [0x00 : 16] IN endpoint FIFOx transmit RAM start address
    $10 constant OTG_INEPTXFD                   \ [0x10 : 16] IN endpoint Tx FIFO depth
  [then]


  [ifdef] OTG_OTG_DIEPTXF6_DEF
    \
    \ @brief OTG device IN endpoint transmit FIFO 6 size register
    \ Address offset: 0x118
    \ Reset value: 0x02000E00
    \
    $00 constant OTG_INEPTXSA                   \ [0x00 : 16] IN endpoint FIFOx transmit RAM start address
    $10 constant OTG_INEPTXFD                   \ [0x10 : 16] IN endpoint Tx FIFO depth
  [then]


  [ifdef] OTG_OTG_DIEPTXF7_DEF
    \
    \ @brief OTG device IN endpoint transmit FIFO 7 size register
    \ Address offset: 0x11C
    \ Reset value: 0x02001000
    \
    $00 constant OTG_INEPTXSA                   \ [0x00 : 16] IN endpoint FIFOx transmit RAM start address
    $10 constant OTG_INEPTXFD                   \ [0x10 : 16] IN endpoint Tx FIFO depth
  [then]


  [ifdef] OTG_OTG_DIEPTXF8_DEF
    \
    \ @brief OTG device IN endpoint transmit FIFO 8 size register
    \ Address offset: 0x120
    \ Reset value: 0x02001200
    \
    $00 constant OTG_INEPTXSA                   \ [0x00 : 16] IN endpoint FIFOx transmit RAM start address
    $10 constant OTG_INEPTXFD                   \ [0x10 : 16] IN endpoint Tx FIFO depth
  [then]


  [ifdef] OTG_OTG_HCFG_DEF
    \
    \ @brief OTG host configuration register
    \ Address offset: 0x400
    \ Reset value: 0x00000000
    \
    $00 constant OTG_FSLSPCS                    \ [0x00 : 2] FS/LS PHY clock select
    $02 constant OTG_FSLSS                      \ [0x02] FS- and LS-only support
  [then]


  [ifdef] OTG_OTG_HFIR_DEF
    \
    \ @brief OTG host frame interval register
    \ Address offset: 0x404
    \ Reset value: 0x0000EA60
    \
    $00 constant OTG_FRIVL                      \ [0x00 : 16] Frame interval
    $10 constant OTG_RLDCTRL                    \ [0x10] Reload control
  [then]


  [ifdef] OTG_OTG_HFNUM_DEF
    \
    \ @brief OTG host frame number/frame time remaining register
    \ Address offset: 0x408
    \ Reset value: 0x00003FFF
    \
    $00 constant OTG_FRNUM                      \ [0x00 : 16] Frame number
    $10 constant OTG_FTREM                      \ [0x10 : 16] Frame time remaining
  [then]


  [ifdef] OTG_OTG_HPTXSTS_DEF
    \
    \ @brief OTG_Host periodic transmit FIFO/queue status register
    \ Address offset: 0x410
    \ Reset value: 0x00080100
    \
    $00 constant OTG_PTXFSAVL                   \ [0x00 : 16] Periodic transmit data FIFO space available
    $10 constant OTG_PTXQSAV                    \ [0x10 : 8] Periodic transmit request queue space available
    $18 constant OTG_PTXQTOP                    \ [0x18 : 8] Top of the periodic transmit request queue
  [then]


  [ifdef] OTG_OTG_HAINT_DEF
    \
    \ @brief OTG host all channels interrupt register
    \ Address offset: 0x414
    \ Reset value: 0x00000000
    \
    $00 constant OTG_HAINT                      \ [0x00 : 16] Channel interrupts
  [then]


  [ifdef] OTG_OTG_HAINTMSK_DEF
    \
    \ @brief OTG host all channels interrupt mask register
    \ Address offset: 0x418
    \ Reset value: 0x00000000
    \
    $00 constant OTG_HAINTM                     \ [0x00 : 16] Channel interrupt mask
  [then]


  [ifdef] OTG_OTG_HPRT_DEF
    \
    \ @brief OTG host port control and status register
    \ Address offset: 0x440
    \ Reset value: 0x00000000
    \
    $00 constant OTG_PCSTS                      \ [0x00] Port connect status
    $01 constant OTG_PCDET                      \ [0x01] Port connect detected
    $02 constant OTG_PENA                       \ [0x02] Port enable
    $03 constant OTG_PENCHNG                    \ [0x03] Port enable/disable change
    $04 constant OTG_POCA                       \ [0x04] Port overcurrent active
    $05 constant OTG_POCCHNG                    \ [0x05] Port overcurrent change
    $06 constant OTG_PRES                       \ [0x06] Port resume
    $07 constant OTG_PSUSP                      \ [0x07] Port suspend
    $08 constant OTG_PRST                       \ [0x08] Port reset
    $0a constant OTG_PLSTS                      \ [0x0a : 2] Port line status
    $0c constant OTG_PPWR                       \ [0x0c] Port power
    $0d constant OTG_PTCTL                      \ [0x0d : 4] Port test control
    $11 constant OTG_PSPD                       \ [0x11 : 2] Port speed
  [then]


  [ifdef] OTG_OTG_HCCHAR0_DEF
    \
    \ @brief OTG host channel 0 characteristics register
    \ Address offset: 0x500
    \ Reset value: 0x00000000
    \
    $00 constant OTG_MPSIZ                      \ [0x00 : 11] Maximum packet size
    $0b constant OTG_EPNUM                      \ [0x0b : 4] Endpoint number
    $0f constant OTG_EPDIR                      \ [0x0f] Endpoint direction
    $11 constant OTG_LSDEV                      \ [0x11] Low-speed device
    $12 constant OTG_EPTYP                      \ [0x12 : 2] Endpoint type
    $14 constant OTG_MCNT                       \ [0x14 : 2] Multicount
    $16 constant OTG_DAD                        \ [0x16 : 7] Device address
    $1d constant OTG_ODDFRM                     \ [0x1d] Odd frame
    $1e constant OTG_CHDIS                      \ [0x1e] Channel disable
    $1f constant OTG_CHENA                      \ [0x1f] Channel enable
  [then]


  [ifdef] OTG_OTG_HCSPLT0_DEF
    \
    \ @brief OTG host channel 0 split control register
    \ Address offset: 0x504
    \ Reset value: 0x00000000
    \
    $00 constant OTG_PRTADDR                    \ [0x00 : 7] Port address
    $07 constant OTG_HUBADDR                    \ [0x07 : 7] Hub address
    $0e constant OTG_XACTPOS                    \ [0x0e : 2] Transaction position
    $10 constant OTG_COMPLSPLT                  \ [0x10] Do complete split
    $1f constant OTG_SPLITEN                    \ [0x1f] Split enable
  [then]


  [ifdef] OTG_OTG_HCINT0_DEF
    \
    \ @brief OTG host channel 0 interrupt register
    \ Address offset: 0x508
    \ Reset value: 0x00000000
    \
    $00 constant OTG_XFRC                       \ [0x00] Transfer completed.
    $01 constant OTG_CHH                        \ [0x01] Channel halted.
    $02 constant OTG_AHBERR                     \ [0x02] AHB error
    $03 constant OTG_STALL                      \ [0x03] STALL response received interrupt.
    $04 constant OTG_NAK                        \ [0x04] NAK response received interrupt.
    $05 constant OTG_ACK                        \ [0x05] ACK response received/transmitted interrupt.
    $06 constant OTG_NYET                       \ [0x06] Not yet ready response received interrupt.
    $07 constant OTG_TXERR                      \ [0x07] Transaction error.
    $08 constant OTG_BBERR                      \ [0x08] Babble error.
    $09 constant OTG_FRMOR                      \ [0x09] Frame overrun.
    $0a constant OTG_DTERR                      \ [0x0a] Data toggle error.
  [then]


  [ifdef] OTG_OTG_HCINTMSK0_DEF
    \
    \ @brief OTG host channel 0 interrupt mask register
    \ Address offset: 0x50C
    \ Reset value: 0x00000000
    \
    $00 constant OTG_XFRCM                      \ [0x00] Transfer completed mask
    $01 constant OTG_CHHM                       \ [0x01] Channel halted mask
    $02 constant OTG_AHBERRM                    \ [0x02] AHB error.
    $03 constant OTG_STALLM                     \ [0x03] STALL response received interrupt mask.
    $04 constant OTG_NAKM                       \ [0x04] NAK response received interrupt mask.
    $05 constant OTG_ACKM                       \ [0x05] ACK response received/transmitted interrupt mask.
    $06 constant OTG_NYET                       \ [0x06] response received interrupt mask.
    $07 constant OTG_TXERRM                     \ [0x07] Transaction error mask.
    $08 constant OTG_BBERRM                     \ [0x08] Babble error mask.
    $09 constant OTG_FRMORM                     \ [0x09] Frame overrun mask.
    $0a constant OTG_DTERRM                     \ [0x0a] Data toggle error mask.
  [then]


  [ifdef] OTG_OTG_HCTSIZ0_DEF
    \
    \ @brief OTG host channel 0 transfer size register
    \ Address offset: 0x510
    \ Reset value: 0x00000000
    \
    $00 constant OTG_XFRSIZ                     \ [0x00 : 19] Transfer size
    $13 constant OTG_PKTCNT                     \ [0x13 : 10] Packet count
    $1d constant OTG_DPID                       \ [0x1d : 2] Data PID
    $1f constant OTG_DOPNG                      \ [0x1f] Do Ping
  [then]


  [ifdef] OTG_OTG_HCDMA0_DEF
    \
    \ @brief OTG host channel 0 DMA address register
    \ Address offset: 0x514
    \ Reset value: 0x00000000
    \
    $00 constant OTG_DMAADDR                    \ [0x00 : 32] DMA address
  [then]


  [ifdef] OTG_OTG_HCCHAR1_DEF
    \
    \ @brief OTG host channel 1 characteristics register
    \ Address offset: 0x520
    \ Reset value: 0x00000000
    \
    $00 constant OTG_MPSIZ                      \ [0x00 : 11] Maximum packet size
    $0b constant OTG_EPNUM                      \ [0x0b : 4] Endpoint number
    $0f constant OTG_EPDIR                      \ [0x0f] Endpoint direction
    $11 constant OTG_LSDEV                      \ [0x11] Low-speed device
    $12 constant OTG_EPTYP                      \ [0x12 : 2] Endpoint type
    $14 constant OTG_MCNT                       \ [0x14 : 2] Multicount
    $16 constant OTG_DAD                        \ [0x16 : 7] Device address
    $1d constant OTG_ODDFRM                     \ [0x1d] Odd frame
    $1e constant OTG_CHDIS                      \ [0x1e] Channel disable
    $1f constant OTG_CHENA                      \ [0x1f] Channel enable
  [then]


  [ifdef] OTG_OTG_HCSPLT1_DEF
    \
    \ @brief OTG host channel 1 split control register
    \ Address offset: 0x524
    \ Reset value: 0x00000000
    \
    $00 constant OTG_PRTADDR                    \ [0x00 : 7] Port address
    $07 constant OTG_HUBADDR                    \ [0x07 : 7] Hub address
    $0e constant OTG_XACTPOS                    \ [0x0e : 2] Transaction position
    $10 constant OTG_COMPLSPLT                  \ [0x10] Do complete split
    $1f constant OTG_SPLITEN                    \ [0x1f] Split enable
  [then]


  [ifdef] OTG_OTG_HCINT1_DEF
    \
    \ @brief OTG host channel 1 interrupt register
    \ Address offset: 0x528
    \ Reset value: 0x00000000
    \
    $00 constant OTG_XFRC                       \ [0x00] Transfer completed.
    $01 constant OTG_CHH                        \ [0x01] Channel halted.
    $02 constant OTG_AHBERR                     \ [0x02] AHB error
    $03 constant OTG_STALL                      \ [0x03] STALL response received interrupt.
    $04 constant OTG_NAK                        \ [0x04] NAK response received interrupt.
    $05 constant OTG_ACK                        \ [0x05] ACK response received/transmitted interrupt.
    $06 constant OTG_NYET                       \ [0x06] Not yet ready response received interrupt.
    $07 constant OTG_TXERR                      \ [0x07] Transaction error.
    $08 constant OTG_BBERR                      \ [0x08] Babble error.
    $09 constant OTG_FRMOR                      \ [0x09] Frame overrun.
    $0a constant OTG_DTERR                      \ [0x0a] Data toggle error.
  [then]


  [ifdef] OTG_OTG_HCINTMSK1_DEF
    \
    \ @brief OTG host channel 1 interrupt mask register
    \ Address offset: 0x52C
    \ Reset value: 0x00000000
    \
    $00 constant OTG_XFRCM                      \ [0x00] Transfer completed mask
    $01 constant OTG_CHHM                       \ [0x01] Channel halted mask
    $02 constant OTG_AHBERRM                    \ [0x02] AHB error.
    $03 constant OTG_STALLM                     \ [0x03] STALL response received interrupt mask.
    $04 constant OTG_NAKM                       \ [0x04] NAK response received interrupt mask.
    $05 constant OTG_ACKM                       \ [0x05] ACK response received/transmitted interrupt mask.
    $06 constant OTG_NYET                       \ [0x06] response received interrupt mask.
    $07 constant OTG_TXERRM                     \ [0x07] Transaction error mask.
    $08 constant OTG_BBERRM                     \ [0x08] Babble error mask.
    $09 constant OTG_FRMORM                     \ [0x09] Frame overrun mask.
    $0a constant OTG_DTERRM                     \ [0x0a] Data toggle error mask.
  [then]


  [ifdef] OTG_OTG_HCTSIZ1_DEF
    \
    \ @brief OTG host channel 1 transfer size register
    \ Address offset: 0x530
    \ Reset value: 0x00000000
    \
    $00 constant OTG_XFRSIZ                     \ [0x00 : 19] Transfer size
    $13 constant OTG_PKTCNT                     \ [0x13 : 10] Packet count
    $1d constant OTG_DPID                       \ [0x1d : 2] Data PID
    $1f constant OTG_DOPNG                      \ [0x1f] Do Ping
  [then]


  [ifdef] OTG_OTG_HCDMA1_DEF
    \
    \ @brief OTG host channel 1 DMA address register
    \ Address offset: 0x534
    \ Reset value: 0x00000000
    \
    $00 constant OTG_DMAADDR                    \ [0x00 : 32] DMA address
  [then]


  [ifdef] OTG_OTG_HCCHAR2_DEF
    \
    \ @brief OTG host channel 2 characteristics register
    \ Address offset: 0x540
    \ Reset value: 0x00000000
    \
    $00 constant OTG_MPSIZ                      \ [0x00 : 11] Maximum packet size
    $0b constant OTG_EPNUM                      \ [0x0b : 4] Endpoint number
    $0f constant OTG_EPDIR                      \ [0x0f] Endpoint direction
    $11 constant OTG_LSDEV                      \ [0x11] Low-speed device
    $12 constant OTG_EPTYP                      \ [0x12 : 2] Endpoint type
    $14 constant OTG_MCNT                       \ [0x14 : 2] Multicount
    $16 constant OTG_DAD                        \ [0x16 : 7] Device address
    $1d constant OTG_ODDFRM                     \ [0x1d] Odd frame
    $1e constant OTG_CHDIS                      \ [0x1e] Channel disable
    $1f constant OTG_CHENA                      \ [0x1f] Channel enable
  [then]


  [ifdef] OTG_OTG_HCSPLT2_DEF
    \
    \ @brief OTG host channel 2 split control register
    \ Address offset: 0x544
    \ Reset value: 0x00000000
    \
    $00 constant OTG_PRTADDR                    \ [0x00 : 7] Port address
    $07 constant OTG_HUBADDR                    \ [0x07 : 7] Hub address
    $0e constant OTG_XACTPOS                    \ [0x0e : 2] Transaction position
    $10 constant OTG_COMPLSPLT                  \ [0x10] Do complete split
    $1f constant OTG_SPLITEN                    \ [0x1f] Split enable
  [then]


  [ifdef] OTG_OTG_HCINT2_DEF
    \
    \ @brief OTG host channel 2 interrupt register
    \ Address offset: 0x548
    \ Reset value: 0x00000000
    \
    $00 constant OTG_XFRC                       \ [0x00] Transfer completed.
    $01 constant OTG_CHH                        \ [0x01] Channel halted.
    $02 constant OTG_AHBERR                     \ [0x02] AHB error
    $03 constant OTG_STALL                      \ [0x03] STALL response received interrupt.
    $04 constant OTG_NAK                        \ [0x04] NAK response received interrupt.
    $05 constant OTG_ACK                        \ [0x05] ACK response received/transmitted interrupt.
    $06 constant OTG_NYET                       \ [0x06] Not yet ready response received interrupt.
    $07 constant OTG_TXERR                      \ [0x07] Transaction error.
    $08 constant OTG_BBERR                      \ [0x08] Babble error.
    $09 constant OTG_FRMOR                      \ [0x09] Frame overrun.
    $0a constant OTG_DTERR                      \ [0x0a] Data toggle error.
  [then]


  [ifdef] OTG_OTG_HCINTMSK2_DEF
    \
    \ @brief OTG host channel 2 interrupt mask register
    \ Address offset: 0x54C
    \ Reset value: 0x00000000
    \
    $00 constant OTG_XFRCM                      \ [0x00] Transfer completed mask
    $01 constant OTG_CHHM                       \ [0x01] Channel halted mask
    $02 constant OTG_AHBERRM                    \ [0x02] AHB error.
    $03 constant OTG_STALLM                     \ [0x03] STALL response received interrupt mask.
    $04 constant OTG_NAKM                       \ [0x04] NAK response received interrupt mask.
    $05 constant OTG_ACKM                       \ [0x05] ACK response received/transmitted interrupt mask.
    $06 constant OTG_NYET                       \ [0x06] response received interrupt mask.
    $07 constant OTG_TXERRM                     \ [0x07] Transaction error mask.
    $08 constant OTG_BBERRM                     \ [0x08] Babble error mask.
    $09 constant OTG_FRMORM                     \ [0x09] Frame overrun mask.
    $0a constant OTG_DTERRM                     \ [0x0a] Data toggle error mask.
  [then]


  [ifdef] OTG_OTG_HCTSIZ2_DEF
    \
    \ @brief OTG host channel 2 transfer size register
    \ Address offset: 0x550
    \ Reset value: 0x00000000
    \
    $00 constant OTG_XFRSIZ                     \ [0x00 : 19] Transfer size
    $13 constant OTG_PKTCNT                     \ [0x13 : 10] Packet count
    $1d constant OTG_DPID                       \ [0x1d : 2] Data PID
    $1f constant OTG_DOPNG                      \ [0x1f] Do Ping
  [then]


  [ifdef] OTG_OTG_HCDMA2_DEF
    \
    \ @brief OTG host channel 2 DMA address register
    \ Address offset: 0x554
    \ Reset value: 0x00000000
    \
    $00 constant OTG_DMAADDR                    \ [0x00 : 32] DMA address
  [then]


  [ifdef] OTG_OTG_HCCHAR3_DEF
    \
    \ @brief OTG host channel 3 characteristics register
    \ Address offset: 0x560
    \ Reset value: 0x00000000
    \
    $00 constant OTG_MPSIZ                      \ [0x00 : 11] Maximum packet size
    $0b constant OTG_EPNUM                      \ [0x0b : 4] Endpoint number
    $0f constant OTG_EPDIR                      \ [0x0f] Endpoint direction
    $11 constant OTG_LSDEV                      \ [0x11] Low-speed device
    $12 constant OTG_EPTYP                      \ [0x12 : 2] Endpoint type
    $14 constant OTG_MCNT                       \ [0x14 : 2] Multicount
    $16 constant OTG_DAD                        \ [0x16 : 7] Device address
    $1d constant OTG_ODDFRM                     \ [0x1d] Odd frame
    $1e constant OTG_CHDIS                      \ [0x1e] Channel disable
    $1f constant OTG_CHENA                      \ [0x1f] Channel enable
  [then]


  [ifdef] OTG_OTG_HCSPLT3_DEF
    \
    \ @brief OTG host channel 3 split control register
    \ Address offset: 0x564
    \ Reset value: 0x00000000
    \
    $00 constant OTG_PRTADDR                    \ [0x00 : 7] Port address
    $07 constant OTG_HUBADDR                    \ [0x07 : 7] Hub address
    $0e constant OTG_XACTPOS                    \ [0x0e : 2] Transaction position
    $10 constant OTG_COMPLSPLT                  \ [0x10] Do complete split
    $1f constant OTG_SPLITEN                    \ [0x1f] Split enable
  [then]


  [ifdef] OTG_OTG_HCINT3_DEF
    \
    \ @brief OTG host channel 3 interrupt register
    \ Address offset: 0x568
    \ Reset value: 0x00000000
    \
    $00 constant OTG_XFRC                       \ [0x00] Transfer completed.
    $01 constant OTG_CHH                        \ [0x01] Channel halted.
    $02 constant OTG_AHBERR                     \ [0x02] AHB error
    $03 constant OTG_STALL                      \ [0x03] STALL response received interrupt.
    $04 constant OTG_NAK                        \ [0x04] NAK response received interrupt.
    $05 constant OTG_ACK                        \ [0x05] ACK response received/transmitted interrupt.
    $06 constant OTG_NYET                       \ [0x06] Not yet ready response received interrupt.
    $07 constant OTG_TXERR                      \ [0x07] Transaction error.
    $08 constant OTG_BBERR                      \ [0x08] Babble error.
    $09 constant OTG_FRMOR                      \ [0x09] Frame overrun.
    $0a constant OTG_DTERR                      \ [0x0a] Data toggle error.
  [then]


  [ifdef] OTG_OTG_HCINTMSK3_DEF
    \
    \ @brief OTG host channel 3 interrupt mask register
    \ Address offset: 0x56C
    \ Reset value: 0x00000000
    \
    $00 constant OTG_XFRCM                      \ [0x00] Transfer completed mask
    $01 constant OTG_CHHM                       \ [0x01] Channel halted mask
    $02 constant OTG_AHBERRM                    \ [0x02] AHB error.
    $03 constant OTG_STALLM                     \ [0x03] STALL response received interrupt mask.
    $04 constant OTG_NAKM                       \ [0x04] NAK response received interrupt mask.
    $05 constant OTG_ACKM                       \ [0x05] ACK response received/transmitted interrupt mask.
    $06 constant OTG_NYET                       \ [0x06] response received interrupt mask.
    $07 constant OTG_TXERRM                     \ [0x07] Transaction error mask.
    $08 constant OTG_BBERRM                     \ [0x08] Babble error mask.
    $09 constant OTG_FRMORM                     \ [0x09] Frame overrun mask.
    $0a constant OTG_DTERRM                     \ [0x0a] Data toggle error mask.
  [then]


  [ifdef] OTG_OTG_HCTSIZ3_DEF
    \
    \ @brief OTG host channel 3 transfer size register
    \ Address offset: 0x570
    \ Reset value: 0x00000000
    \
    $00 constant OTG_XFRSIZ                     \ [0x00 : 19] Transfer size
    $13 constant OTG_PKTCNT                     \ [0x13 : 10] Packet count
    $1d constant OTG_DPID                       \ [0x1d : 2] Data PID
    $1f constant OTG_DOPNG                      \ [0x1f] Do Ping
  [then]


  [ifdef] OTG_OTG_HCDMA3_DEF
    \
    \ @brief OTG host channel 3 DMA address register
    \ Address offset: 0x574
    \ Reset value: 0x00000000
    \
    $00 constant OTG_DMAADDR                    \ [0x00 : 32] DMA address
  [then]


  [ifdef] OTG_OTG_HCCHAR4_DEF
    \
    \ @brief OTG host channel 4 characteristics register
    \ Address offset: 0x580
    \ Reset value: 0x00000000
    \
    $00 constant OTG_MPSIZ                      \ [0x00 : 11] Maximum packet size
    $0b constant OTG_EPNUM                      \ [0x0b : 4] Endpoint number
    $0f constant OTG_EPDIR                      \ [0x0f] Endpoint direction
    $11 constant OTG_LSDEV                      \ [0x11] Low-speed device
    $12 constant OTG_EPTYP                      \ [0x12 : 2] Endpoint type
    $14 constant OTG_MCNT                       \ [0x14 : 2] Multicount
    $16 constant OTG_DAD                        \ [0x16 : 7] Device address
    $1d constant OTG_ODDFRM                     \ [0x1d] Odd frame
    $1e constant OTG_CHDIS                      \ [0x1e] Channel disable
    $1f constant OTG_CHENA                      \ [0x1f] Channel enable
  [then]


  [ifdef] OTG_OTG_HCSPLT4_DEF
    \
    \ @brief OTG host channel 4 split control register
    \ Address offset: 0x584
    \ Reset value: 0x00000000
    \
    $00 constant OTG_PRTADDR                    \ [0x00 : 7] Port address
    $07 constant OTG_HUBADDR                    \ [0x07 : 7] Hub address
    $0e constant OTG_XACTPOS                    \ [0x0e : 2] Transaction position
    $10 constant OTG_COMPLSPLT                  \ [0x10] Do complete split
    $1f constant OTG_SPLITEN                    \ [0x1f] Split enable
  [then]


  [ifdef] OTG_OTG_HCINT4_DEF
    \
    \ @brief OTG host channel 4 interrupt register
    \ Address offset: 0x588
    \ Reset value: 0x00000000
    \
    $00 constant OTG_XFRC                       \ [0x00] Transfer completed.
    $01 constant OTG_CHH                        \ [0x01] Channel halted.
    $02 constant OTG_AHBERR                     \ [0x02] AHB error
    $03 constant OTG_STALL                      \ [0x03] STALL response received interrupt.
    $04 constant OTG_NAK                        \ [0x04] NAK response received interrupt.
    $05 constant OTG_ACK                        \ [0x05] ACK response received/transmitted interrupt.
    $06 constant OTG_NYET                       \ [0x06] Not yet ready response received interrupt.
    $07 constant OTG_TXERR                      \ [0x07] Transaction error.
    $08 constant OTG_BBERR                      \ [0x08] Babble error.
    $09 constant OTG_FRMOR                      \ [0x09] Frame overrun.
    $0a constant OTG_DTERR                      \ [0x0a] Data toggle error.
  [then]


  [ifdef] OTG_OTG_HCINTMSK4_DEF
    \
    \ @brief OTG host channel 4 interrupt mask register
    \ Address offset: 0x58C
    \ Reset value: 0x00000000
    \
    $00 constant OTG_XFRCM                      \ [0x00] Transfer completed mask
    $01 constant OTG_CHHM                       \ [0x01] Channel halted mask
    $02 constant OTG_AHBERRM                    \ [0x02] AHB error.
    $03 constant OTG_STALLM                     \ [0x03] STALL response received interrupt mask.
    $04 constant OTG_NAKM                       \ [0x04] NAK response received interrupt mask.
    $05 constant OTG_ACKM                       \ [0x05] ACK response received/transmitted interrupt mask.
    $06 constant OTG_NYET                       \ [0x06] response received interrupt mask.
    $07 constant OTG_TXERRM                     \ [0x07] Transaction error mask.
    $08 constant OTG_BBERRM                     \ [0x08] Babble error mask.
    $09 constant OTG_FRMORM                     \ [0x09] Frame overrun mask.
    $0a constant OTG_DTERRM                     \ [0x0a] Data toggle error mask.
  [then]


  [ifdef] OTG_OTG_HCTSIZ4_DEF
    \
    \ @brief OTG host channel 4 transfer size register
    \ Address offset: 0x590
    \ Reset value: 0x00000000
    \
    $00 constant OTG_XFRSIZ                     \ [0x00 : 19] Transfer size
    $13 constant OTG_PKTCNT                     \ [0x13 : 10] Packet count
    $1d constant OTG_DPID                       \ [0x1d : 2] Data PID
    $1f constant OTG_DOPNG                      \ [0x1f] Do Ping
  [then]


  [ifdef] OTG_OTG_HCDMA4_DEF
    \
    \ @brief OTG host channel 4 DMA address register
    \ Address offset: 0x594
    \ Reset value: 0x00000000
    \
    $00 constant OTG_DMAADDR                    \ [0x00 : 32] DMA address
  [then]


  [ifdef] OTG_OTG_HCCHAR5_DEF
    \
    \ @brief OTG host channel 5 characteristics register
    \ Address offset: 0x5A0
    \ Reset value: 0x00000000
    \
    $00 constant OTG_MPSIZ                      \ [0x00 : 11] Maximum packet size
    $0b constant OTG_EPNUM                      \ [0x0b : 4] Endpoint number
    $0f constant OTG_EPDIR                      \ [0x0f] Endpoint direction
    $11 constant OTG_LSDEV                      \ [0x11] Low-speed device
    $12 constant OTG_EPTYP                      \ [0x12 : 2] Endpoint type
    $14 constant OTG_MCNT                       \ [0x14 : 2] Multicount
    $16 constant OTG_DAD                        \ [0x16 : 7] Device address
    $1d constant OTG_ODDFRM                     \ [0x1d] Odd frame
    $1e constant OTG_CHDIS                      \ [0x1e] Channel disable
    $1f constant OTG_CHENA                      \ [0x1f] Channel enable
  [then]


  [ifdef] OTG_OTG_HCSPLT5_DEF
    \
    \ @brief OTG host channel 5 split control register
    \ Address offset: 0x5A4
    \ Reset value: 0x00000000
    \
    $00 constant OTG_PRTADDR                    \ [0x00 : 7] Port address
    $07 constant OTG_HUBADDR                    \ [0x07 : 7] Hub address
    $0e constant OTG_XACTPOS                    \ [0x0e : 2] Transaction position
    $10 constant OTG_COMPLSPLT                  \ [0x10] Do complete split
    $1f constant OTG_SPLITEN                    \ [0x1f] Split enable
  [then]


  [ifdef] OTG_OTG_HCINT5_DEF
    \
    \ @brief OTG host channel 5 interrupt register
    \ Address offset: 0x5A8
    \ Reset value: 0x00000000
    \
    $00 constant OTG_XFRC                       \ [0x00] Transfer completed.
    $01 constant OTG_CHH                        \ [0x01] Channel halted.
    $02 constant OTG_AHBERR                     \ [0x02] AHB error
    $03 constant OTG_STALL                      \ [0x03] STALL response received interrupt.
    $04 constant OTG_NAK                        \ [0x04] NAK response received interrupt.
    $05 constant OTG_ACK                        \ [0x05] ACK response received/transmitted interrupt.
    $06 constant OTG_NYET                       \ [0x06] Not yet ready response received interrupt.
    $07 constant OTG_TXERR                      \ [0x07] Transaction error.
    $08 constant OTG_BBERR                      \ [0x08] Babble error.
    $09 constant OTG_FRMOR                      \ [0x09] Frame overrun.
    $0a constant OTG_DTERR                      \ [0x0a] Data toggle error.
  [then]


  [ifdef] OTG_OTG_HCINTMSK5_DEF
    \
    \ @brief OTG host channel 5 interrupt mask register
    \ Address offset: 0x5AC
    \ Reset value: 0x00000000
    \
    $00 constant OTG_XFRCM                      \ [0x00] Transfer completed mask
    $01 constant OTG_CHHM                       \ [0x01] Channel halted mask
    $02 constant OTG_AHBERRM                    \ [0x02] AHB error.
    $03 constant OTG_STALLM                     \ [0x03] STALL response received interrupt mask.
    $04 constant OTG_NAKM                       \ [0x04] NAK response received interrupt mask.
    $05 constant OTG_ACKM                       \ [0x05] ACK response received/transmitted interrupt mask.
    $06 constant OTG_NYET                       \ [0x06] response received interrupt mask.
    $07 constant OTG_TXERRM                     \ [0x07] Transaction error mask.
    $08 constant OTG_BBERRM                     \ [0x08] Babble error mask.
    $09 constant OTG_FRMORM                     \ [0x09] Frame overrun mask.
    $0a constant OTG_DTERRM                     \ [0x0a] Data toggle error mask.
  [then]


  [ifdef] OTG_OTG_HCTSIZ5_DEF
    \
    \ @brief OTG host channel 5 transfer size register
    \ Address offset: 0x5B0
    \ Reset value: 0x00000000
    \
    $00 constant OTG_XFRSIZ                     \ [0x00 : 19] Transfer size
    $13 constant OTG_PKTCNT                     \ [0x13 : 10] Packet count
    $1d constant OTG_DPID                       \ [0x1d : 2] Data PID
    $1f constant OTG_DOPNG                      \ [0x1f] Do Ping
  [then]


  [ifdef] OTG_OTG_HCDMA5_DEF
    \
    \ @brief OTG host channel 5 DMA address register
    \ Address offset: 0x5B4
    \ Reset value: 0x00000000
    \
    $00 constant OTG_DMAADDR                    \ [0x00 : 32] DMA address
  [then]


  [ifdef] OTG_OTG_HCCHAR6_DEF
    \
    \ @brief OTG host channel 6 characteristics register
    \ Address offset: 0x5C0
    \ Reset value: 0x00000000
    \
    $00 constant OTG_MPSIZ                      \ [0x00 : 11] Maximum packet size
    $0b constant OTG_EPNUM                      \ [0x0b : 4] Endpoint number
    $0f constant OTG_EPDIR                      \ [0x0f] Endpoint direction
    $11 constant OTG_LSDEV                      \ [0x11] Low-speed device
    $12 constant OTG_EPTYP                      \ [0x12 : 2] Endpoint type
    $14 constant OTG_MCNT                       \ [0x14 : 2] Multicount
    $16 constant OTG_DAD                        \ [0x16 : 7] Device address
    $1d constant OTG_ODDFRM                     \ [0x1d] Odd frame
    $1e constant OTG_CHDIS                      \ [0x1e] Channel disable
    $1f constant OTG_CHENA                      \ [0x1f] Channel enable
  [then]


  [ifdef] OTG_OTG_HCSPLT6_DEF
    \
    \ @brief OTG host channel 6 split control register
    \ Address offset: 0x5C4
    \ Reset value: 0x00000000
    \
    $00 constant OTG_PRTADDR                    \ [0x00 : 7] Port address
    $07 constant OTG_HUBADDR                    \ [0x07 : 7] Hub address
    $0e constant OTG_XACTPOS                    \ [0x0e : 2] Transaction position
    $10 constant OTG_COMPLSPLT                  \ [0x10] Do complete split
    $1f constant OTG_SPLITEN                    \ [0x1f] Split enable
  [then]


  [ifdef] OTG_OTG_HCINT6_DEF
    \
    \ @brief OTG host channel 6 interrupt register
    \ Address offset: 0x5C8
    \ Reset value: 0x00000000
    \
    $00 constant OTG_XFRC                       \ [0x00] Transfer completed.
    $01 constant OTG_CHH                        \ [0x01] Channel halted.
    $02 constant OTG_AHBERR                     \ [0x02] AHB error
    $03 constant OTG_STALL                      \ [0x03] STALL response received interrupt.
    $04 constant OTG_NAK                        \ [0x04] NAK response received interrupt.
    $05 constant OTG_ACK                        \ [0x05] ACK response received/transmitted interrupt.
    $06 constant OTG_NYET                       \ [0x06] Not yet ready response received interrupt.
    $07 constant OTG_TXERR                      \ [0x07] Transaction error.
    $08 constant OTG_BBERR                      \ [0x08] Babble error.
    $09 constant OTG_FRMOR                      \ [0x09] Frame overrun.
    $0a constant OTG_DTERR                      \ [0x0a] Data toggle error.
  [then]


  [ifdef] OTG_OTG_HCINTMSK6_DEF
    \
    \ @brief OTG host channel 6 interrupt mask register
    \ Address offset: 0x5CC
    \ Reset value: 0x00000000
    \
    $00 constant OTG_XFRCM                      \ [0x00] Transfer completed mask
    $01 constant OTG_CHHM                       \ [0x01] Channel halted mask
    $02 constant OTG_AHBERRM                    \ [0x02] AHB error.
    $03 constant OTG_STALLM                     \ [0x03] STALL response received interrupt mask.
    $04 constant OTG_NAKM                       \ [0x04] NAK response received interrupt mask.
    $05 constant OTG_ACKM                       \ [0x05] ACK response received/transmitted interrupt mask.
    $06 constant OTG_NYET                       \ [0x06] response received interrupt mask.
    $07 constant OTG_TXERRM                     \ [0x07] Transaction error mask.
    $08 constant OTG_BBERRM                     \ [0x08] Babble error mask.
    $09 constant OTG_FRMORM                     \ [0x09] Frame overrun mask.
    $0a constant OTG_DTERRM                     \ [0x0a] Data toggle error mask.
  [then]


  [ifdef] OTG_OTG_HCTSIZ6_DEF
    \
    \ @brief OTG host channel 6 transfer size register
    \ Address offset: 0x5D0
    \ Reset value: 0x00000000
    \
    $00 constant OTG_XFRSIZ                     \ [0x00 : 19] Transfer size
    $13 constant OTG_PKTCNT                     \ [0x13 : 10] Packet count
    $1d constant OTG_DPID                       \ [0x1d : 2] Data PID
    $1f constant OTG_DOPNG                      \ [0x1f] Do Ping
  [then]


  [ifdef] OTG_OTG_HCDMA6_DEF
    \
    \ @brief OTG host channel 6 DMA address register
    \ Address offset: 0x5D4
    \ Reset value: 0x00000000
    \
    $00 constant OTG_DMAADDR                    \ [0x00 : 32] DMA address
  [then]


  [ifdef] OTG_OTG_HCCHAR7_DEF
    \
    \ @brief OTG host channel 7 characteristics register
    \ Address offset: 0x5E0
    \ Reset value: 0x00000000
    \
    $00 constant OTG_MPSIZ                      \ [0x00 : 11] Maximum packet size
    $0b constant OTG_EPNUM                      \ [0x0b : 4] Endpoint number
    $0f constant OTG_EPDIR                      \ [0x0f] Endpoint direction
    $11 constant OTG_LSDEV                      \ [0x11] Low-speed device
    $12 constant OTG_EPTYP                      \ [0x12 : 2] Endpoint type
    $14 constant OTG_MCNT                       \ [0x14 : 2] Multicount
    $16 constant OTG_DAD                        \ [0x16 : 7] Device address
    $1d constant OTG_ODDFRM                     \ [0x1d] Odd frame
    $1e constant OTG_CHDIS                      \ [0x1e] Channel disable
    $1f constant OTG_CHENA                      \ [0x1f] Channel enable
  [then]


  [ifdef] OTG_OTG_HCSPLT7_DEF
    \
    \ @brief OTG host channel 7 split control register
    \ Address offset: 0x5E4
    \ Reset value: 0x00000000
    \
    $00 constant OTG_PRTADDR                    \ [0x00 : 7] Port address
    $07 constant OTG_HUBADDR                    \ [0x07 : 7] Hub address
    $0e constant OTG_XACTPOS                    \ [0x0e : 2] Transaction position
    $10 constant OTG_COMPLSPLT                  \ [0x10] Do complete split
    $1f constant OTG_SPLITEN                    \ [0x1f] Split enable
  [then]


  [ifdef] OTG_OTG_HCINT7_DEF
    \
    \ @brief OTG host channel 7 interrupt register
    \ Address offset: 0x5E8
    \ Reset value: 0x00000000
    \
    $00 constant OTG_XFRC                       \ [0x00] Transfer completed.
    $01 constant OTG_CHH                        \ [0x01] Channel halted.
    $02 constant OTG_AHBERR                     \ [0x02] AHB error
    $03 constant OTG_STALL                      \ [0x03] STALL response received interrupt.
    $04 constant OTG_NAK                        \ [0x04] NAK response received interrupt.
    $05 constant OTG_ACK                        \ [0x05] ACK response received/transmitted interrupt.
    $06 constant OTG_NYET                       \ [0x06] Not yet ready response received interrupt.
    $07 constant OTG_TXERR                      \ [0x07] Transaction error.
    $08 constant OTG_BBERR                      \ [0x08] Babble error.
    $09 constant OTG_FRMOR                      \ [0x09] Frame overrun.
    $0a constant OTG_DTERR                      \ [0x0a] Data toggle error.
  [then]


  [ifdef] OTG_OTG_HCINTMSK7_DEF
    \
    \ @brief OTG host channel 7 interrupt mask register
    \ Address offset: 0x5EC
    \ Reset value: 0x00000000
    \
    $00 constant OTG_XFRCM                      \ [0x00] Transfer completed mask
    $01 constant OTG_CHHM                       \ [0x01] Channel halted mask
    $02 constant OTG_AHBERRM                    \ [0x02] AHB error.
    $03 constant OTG_STALLM                     \ [0x03] STALL response received interrupt mask.
    $04 constant OTG_NAKM                       \ [0x04] NAK response received interrupt mask.
    $05 constant OTG_ACKM                       \ [0x05] ACK response received/transmitted interrupt mask.
    $06 constant OTG_NYET                       \ [0x06] response received interrupt mask.
    $07 constant OTG_TXERRM                     \ [0x07] Transaction error mask.
    $08 constant OTG_BBERRM                     \ [0x08] Babble error mask.
    $09 constant OTG_FRMORM                     \ [0x09] Frame overrun mask.
    $0a constant OTG_DTERRM                     \ [0x0a] Data toggle error mask.
  [then]


  [ifdef] OTG_OTG_HCTSIZ7_DEF
    \
    \ @brief OTG host channel 7 transfer size register
    \ Address offset: 0x5F0
    \ Reset value: 0x00000000
    \
    $00 constant OTG_XFRSIZ                     \ [0x00 : 19] Transfer size
    $13 constant OTG_PKTCNT                     \ [0x13 : 10] Packet count
    $1d constant OTG_DPID                       \ [0x1d : 2] Data PID
    $1f constant OTG_DOPNG                      \ [0x1f] Do Ping
  [then]


  [ifdef] OTG_OTG_HCDMA7_DEF
    \
    \ @brief OTG host channel 7 DMA address register
    \ Address offset: 0x5F4
    \ Reset value: 0x00000000
    \
    $00 constant OTG_DMAADDR                    \ [0x00 : 32] DMA address
  [then]


  [ifdef] OTG_OTG_HCCHAR8_DEF
    \
    \ @brief OTG host channel 8 characteristics register
    \ Address offset: 0x600
    \ Reset value: 0x00000000
    \
    $00 constant OTG_MPSIZ                      \ [0x00 : 11] Maximum packet size
    $0b constant OTG_EPNUM                      \ [0x0b : 4] Endpoint number
    $0f constant OTG_EPDIR                      \ [0x0f] Endpoint direction
    $11 constant OTG_LSDEV                      \ [0x11] Low-speed device
    $12 constant OTG_EPTYP                      \ [0x12 : 2] Endpoint type
    $14 constant OTG_MCNT                       \ [0x14 : 2] Multicount
    $16 constant OTG_DAD                        \ [0x16 : 7] Device address
    $1d constant OTG_ODDFRM                     \ [0x1d] Odd frame
    $1e constant OTG_CHDIS                      \ [0x1e] Channel disable
    $1f constant OTG_CHENA                      \ [0x1f] Channel enable
  [then]


  [ifdef] OTG_OTG_HCSPLT8_DEF
    \
    \ @brief OTG host channel 8 split control register
    \ Address offset: 0x604
    \ Reset value: 0x00000000
    \
    $00 constant OTG_PRTADDR                    \ [0x00 : 7] Port address
    $07 constant OTG_HUBADDR                    \ [0x07 : 7] Hub address
    $0e constant OTG_XACTPOS                    \ [0x0e : 2] Transaction position
    $10 constant OTG_COMPLSPLT                  \ [0x10] Do complete split
    $1f constant OTG_SPLITEN                    \ [0x1f] Split enable
  [then]


  [ifdef] OTG_OTG_HCINT8_DEF
    \
    \ @brief OTG host channel 8 interrupt register
    \ Address offset: 0x608
    \ Reset value: 0x00000000
    \
    $00 constant OTG_XFRC                       \ [0x00] Transfer completed.
    $01 constant OTG_CHH                        \ [0x01] Channel halted.
    $02 constant OTG_AHBERR                     \ [0x02] AHB error
    $03 constant OTG_STALL                      \ [0x03] STALL response received interrupt.
    $04 constant OTG_NAK                        \ [0x04] NAK response received interrupt.
    $05 constant OTG_ACK                        \ [0x05] ACK response received/transmitted interrupt.
    $06 constant OTG_NYET                       \ [0x06] Not yet ready response received interrupt.
    $07 constant OTG_TXERR                      \ [0x07] Transaction error.
    $08 constant OTG_BBERR                      \ [0x08] Babble error.
    $09 constant OTG_FRMOR                      \ [0x09] Frame overrun.
    $0a constant OTG_DTERR                      \ [0x0a] Data toggle error.
  [then]


  [ifdef] OTG_OTG_HCINTMSK8_DEF
    \
    \ @brief OTG host channel 8 interrupt mask register
    \ Address offset: 0x60C
    \ Reset value: 0x00000000
    \
    $00 constant OTG_XFRCM                      \ [0x00] Transfer completed mask
    $01 constant OTG_CHHM                       \ [0x01] Channel halted mask
    $02 constant OTG_AHBERRM                    \ [0x02] AHB error.
    $03 constant OTG_STALLM                     \ [0x03] STALL response received interrupt mask.
    $04 constant OTG_NAKM                       \ [0x04] NAK response received interrupt mask.
    $05 constant OTG_ACKM                       \ [0x05] ACK response received/transmitted interrupt mask.
    $06 constant OTG_NYET                       \ [0x06] response received interrupt mask.
    $07 constant OTG_TXERRM                     \ [0x07] Transaction error mask.
    $08 constant OTG_BBERRM                     \ [0x08] Babble error mask.
    $09 constant OTG_FRMORM                     \ [0x09] Frame overrun mask.
    $0a constant OTG_DTERRM                     \ [0x0a] Data toggle error mask.
  [then]


  [ifdef] OTG_OTG_HCTSIZ8_DEF
    \
    \ @brief OTG host channel 8 transfer size register
    \ Address offset: 0x610
    \ Reset value: 0x00000000
    \
    $00 constant OTG_XFRSIZ                     \ [0x00 : 19] Transfer size
    $13 constant OTG_PKTCNT                     \ [0x13 : 10] Packet count
    $1d constant OTG_DPID                       \ [0x1d : 2] Data PID
    $1f constant OTG_DOPNG                      \ [0x1f] Do Ping
  [then]


  [ifdef] OTG_OTG_HCDMA8_DEF
    \
    \ @brief OTG host channel 8 DMA address register
    \ Address offset: 0x614
    \ Reset value: 0x00000000
    \
    $00 constant OTG_DMAADDR                    \ [0x00 : 32] DMA address
  [then]


  [ifdef] OTG_OTG_HCCHAR9_DEF
    \
    \ @brief OTG host channel 9 characteristics register
    \ Address offset: 0x620
    \ Reset value: 0x00000000
    \
    $00 constant OTG_MPSIZ                      \ [0x00 : 11] Maximum packet size
    $0b constant OTG_EPNUM                      \ [0x0b : 4] Endpoint number
    $0f constant OTG_EPDIR                      \ [0x0f] Endpoint direction
    $11 constant OTG_LSDEV                      \ [0x11] Low-speed device
    $12 constant OTG_EPTYP                      \ [0x12 : 2] Endpoint type
    $14 constant OTG_MCNT                       \ [0x14 : 2] Multicount
    $16 constant OTG_DAD                        \ [0x16 : 7] Device address
    $1d constant OTG_ODDFRM                     \ [0x1d] Odd frame
    $1e constant OTG_CHDIS                      \ [0x1e] Channel disable
    $1f constant OTG_CHENA                      \ [0x1f] Channel enable
  [then]


  [ifdef] OTG_OTG_HCSPLT9_DEF
    \
    \ @brief OTG host channel 9 split control register
    \ Address offset: 0x624
    \ Reset value: 0x00000000
    \
    $00 constant OTG_PRTADDR                    \ [0x00 : 7] Port address
    $07 constant OTG_HUBADDR                    \ [0x07 : 7] Hub address
    $0e constant OTG_XACTPOS                    \ [0x0e : 2] Transaction position
    $10 constant OTG_COMPLSPLT                  \ [0x10] Do complete split
    $1f constant OTG_SPLITEN                    \ [0x1f] Split enable
  [then]


  [ifdef] OTG_OTG_HCINT9_DEF
    \
    \ @brief OTG host channel 9 interrupt register
    \ Address offset: 0x628
    \ Reset value: 0x00000000
    \
    $00 constant OTG_XFRC                       \ [0x00] Transfer completed.
    $01 constant OTG_CHH                        \ [0x01] Channel halted.
    $02 constant OTG_AHBERR                     \ [0x02] AHB error
    $03 constant OTG_STALL                      \ [0x03] STALL response received interrupt.
    $04 constant OTG_NAK                        \ [0x04] NAK response received interrupt.
    $05 constant OTG_ACK                        \ [0x05] ACK response received/transmitted interrupt.
    $06 constant OTG_NYET                       \ [0x06] Not yet ready response received interrupt.
    $07 constant OTG_TXERR                      \ [0x07] Transaction error.
    $08 constant OTG_BBERR                      \ [0x08] Babble error.
    $09 constant OTG_FRMOR                      \ [0x09] Frame overrun.
    $0a constant OTG_DTERR                      \ [0x0a] Data toggle error.
  [then]


  [ifdef] OTG_OTG_HCINTMSK9_DEF
    \
    \ @brief OTG host channel 9 interrupt mask register
    \ Address offset: 0x62C
    \ Reset value: 0x00000000
    \
    $00 constant OTG_XFRCM                      \ [0x00] Transfer completed mask
    $01 constant OTG_CHHM                       \ [0x01] Channel halted mask
    $02 constant OTG_AHBERRM                    \ [0x02] AHB error.
    $03 constant OTG_STALLM                     \ [0x03] STALL response received interrupt mask.
    $04 constant OTG_NAKM                       \ [0x04] NAK response received interrupt mask.
    $05 constant OTG_ACKM                       \ [0x05] ACK response received/transmitted interrupt mask.
    $06 constant OTG_NYET                       \ [0x06] response received interrupt mask.
    $07 constant OTG_TXERRM                     \ [0x07] Transaction error mask.
    $08 constant OTG_BBERRM                     \ [0x08] Babble error mask.
    $09 constant OTG_FRMORM                     \ [0x09] Frame overrun mask.
    $0a constant OTG_DTERRM                     \ [0x0a] Data toggle error mask.
  [then]


  [ifdef] OTG_OTG_HCTSIZ9_DEF
    \
    \ @brief OTG host channel 9 transfer size register
    \ Address offset: 0x630
    \ Reset value: 0x00000000
    \
    $00 constant OTG_XFRSIZ                     \ [0x00 : 19] Transfer size
    $13 constant OTG_PKTCNT                     \ [0x13 : 10] Packet count
    $1d constant OTG_DPID                       \ [0x1d : 2] Data PID
    $1f constant OTG_DOPNG                      \ [0x1f] Do Ping
  [then]


  [ifdef] OTG_OTG_HCDMA9_DEF
    \
    \ @brief OTG host channel 9 DMA address register
    \ Address offset: 0x634
    \ Reset value: 0x00000000
    \
    $00 constant OTG_DMAADDR                    \ [0x00 : 32] DMA address
  [then]


  [ifdef] OTG_OTG_HCCHAR10_DEF
    \
    \ @brief OTG host channel 10 characteristics register
    \ Address offset: 0x640
    \ Reset value: 0x00000000
    \
    $00 constant OTG_MPSIZ                      \ [0x00 : 11] Maximum packet size
    $0b constant OTG_EPNUM                      \ [0x0b : 4] Endpoint number
    $0f constant OTG_EPDIR                      \ [0x0f] Endpoint direction
    $11 constant OTG_LSDEV                      \ [0x11] Low-speed device
    $12 constant OTG_EPTYP                      \ [0x12 : 2] Endpoint type
    $14 constant OTG_MCNT                       \ [0x14 : 2] Multicount
    $16 constant OTG_DAD                        \ [0x16 : 7] Device address
    $1d constant OTG_ODDFRM                     \ [0x1d] Odd frame
    $1e constant OTG_CHDIS                      \ [0x1e] Channel disable
    $1f constant OTG_CHENA                      \ [0x1f] Channel enable
  [then]


  [ifdef] OTG_OTG_HCSPLT10_DEF
    \
    \ @brief OTG host channel 10 split control register
    \ Address offset: 0x644
    \ Reset value: 0x00000000
    \
    $00 constant OTG_PRTADDR                    \ [0x00 : 7] Port address
    $07 constant OTG_HUBADDR                    \ [0x07 : 7] Hub address
    $0e constant OTG_XACTPOS                    \ [0x0e : 2] Transaction position
    $10 constant OTG_COMPLSPLT                  \ [0x10] Do complete split
    $1f constant OTG_SPLITEN                    \ [0x1f] Split enable
  [then]


  [ifdef] OTG_OTG_HCINT10_DEF
    \
    \ @brief OTG host channel 10 interrupt register
    \ Address offset: 0x648
    \ Reset value: 0x00000000
    \
    $00 constant OTG_XFRC                       \ [0x00] Transfer completed.
    $01 constant OTG_CHH                        \ [0x01] Channel halted.
    $02 constant OTG_AHBERR                     \ [0x02] AHB error
    $03 constant OTG_STALL                      \ [0x03] STALL response received interrupt.
    $04 constant OTG_NAK                        \ [0x04] NAK response received interrupt.
    $05 constant OTG_ACK                        \ [0x05] ACK response received/transmitted interrupt.
    $06 constant OTG_NYET                       \ [0x06] Not yet ready response received interrupt.
    $07 constant OTG_TXERR                      \ [0x07] Transaction error.
    $08 constant OTG_BBERR                      \ [0x08] Babble error.
    $09 constant OTG_FRMOR                      \ [0x09] Frame overrun.
    $0a constant OTG_DTERR                      \ [0x0a] Data toggle error.
  [then]


  [ifdef] OTG_OTG_HCINTMSK10_DEF
    \
    \ @brief OTG host channel 10 interrupt mask register
    \ Address offset: 0x64C
    \ Reset value: 0x00000000
    \
    $00 constant OTG_XFRCM                      \ [0x00] Transfer completed mask
    $01 constant OTG_CHHM                       \ [0x01] Channel halted mask
    $02 constant OTG_AHBERRM                    \ [0x02] AHB error.
    $03 constant OTG_STALLM                     \ [0x03] STALL response received interrupt mask.
    $04 constant OTG_NAKM                       \ [0x04] NAK response received interrupt mask.
    $05 constant OTG_ACKM                       \ [0x05] ACK response received/transmitted interrupt mask.
    $06 constant OTG_NYET                       \ [0x06] response received interrupt mask.
    $07 constant OTG_TXERRM                     \ [0x07] Transaction error mask.
    $08 constant OTG_BBERRM                     \ [0x08] Babble error mask.
    $09 constant OTG_FRMORM                     \ [0x09] Frame overrun mask.
    $0a constant OTG_DTERRM                     \ [0x0a] Data toggle error mask.
  [then]


  [ifdef] OTG_OTG_HCTSIZ10_DEF
    \
    \ @brief OTG host channel 10 transfer size register
    \ Address offset: 0x650
    \ Reset value: 0x00000000
    \
    $00 constant OTG_XFRSIZ                     \ [0x00 : 19] Transfer size
    $13 constant OTG_PKTCNT                     \ [0x13 : 10] Packet count
    $1d constant OTG_DPID                       \ [0x1d : 2] Data PID
    $1f constant OTG_DOPNG                      \ [0x1f] Do Ping
  [then]


  [ifdef] OTG_OTG_HCDMA10_DEF
    \
    \ @brief OTG host channel 10 DMA address register
    \ Address offset: 0x654
    \ Reset value: 0x00000000
    \
    $00 constant OTG_DMAADDR                    \ [0x00 : 32] DMA address
  [then]


  [ifdef] OTG_OTG_HCCHAR11_DEF
    \
    \ @brief OTG host channel 11 characteristics register
    \ Address offset: 0x660
    \ Reset value: 0x00000000
    \
    $00 constant OTG_MPSIZ                      \ [0x00 : 11] Maximum packet size
    $0b constant OTG_EPNUM                      \ [0x0b : 4] Endpoint number
    $0f constant OTG_EPDIR                      \ [0x0f] Endpoint direction
    $11 constant OTG_LSDEV                      \ [0x11] Low-speed device
    $12 constant OTG_EPTYP                      \ [0x12 : 2] Endpoint type
    $14 constant OTG_MCNT                       \ [0x14 : 2] Multicount
    $16 constant OTG_DAD                        \ [0x16 : 7] Device address
    $1d constant OTG_ODDFRM                     \ [0x1d] Odd frame
    $1e constant OTG_CHDIS                      \ [0x1e] Channel disable
    $1f constant OTG_CHENA                      \ [0x1f] Channel enable
  [then]


  [ifdef] OTG_OTG_HCSPLT11_DEF
    \
    \ @brief OTG host channel 11 split control register
    \ Address offset: 0x664
    \ Reset value: 0x00000000
    \
    $00 constant OTG_PRTADDR                    \ [0x00 : 7] Port address
    $07 constant OTG_HUBADDR                    \ [0x07 : 7] Hub address
    $0e constant OTG_XACTPOS                    \ [0x0e : 2] Transaction position
    $10 constant OTG_COMPLSPLT                  \ [0x10] Do complete split
    $1f constant OTG_SPLITEN                    \ [0x1f] Split enable
  [then]


  [ifdef] OTG_OTG_HCINT11_DEF
    \
    \ @brief OTG host channel 11 interrupt register
    \ Address offset: 0x668
    \ Reset value: 0x00000000
    \
    $00 constant OTG_XFRC                       \ [0x00] Transfer completed.
    $01 constant OTG_CHH                        \ [0x01] Channel halted.
    $02 constant OTG_AHBERR                     \ [0x02] AHB error
    $03 constant OTG_STALL                      \ [0x03] STALL response received interrupt.
    $04 constant OTG_NAK                        \ [0x04] NAK response received interrupt.
    $05 constant OTG_ACK                        \ [0x05] ACK response received/transmitted interrupt.
    $06 constant OTG_NYET                       \ [0x06] Not yet ready response received interrupt.
    $07 constant OTG_TXERR                      \ [0x07] Transaction error.
    $08 constant OTG_BBERR                      \ [0x08] Babble error.
    $09 constant OTG_FRMOR                      \ [0x09] Frame overrun.
    $0a constant OTG_DTERR                      \ [0x0a] Data toggle error.
  [then]


  [ifdef] OTG_OTG_HCINTMSK11_DEF
    \
    \ @brief OTG host channel 11 interrupt mask register
    \ Address offset: 0x66C
    \ Reset value: 0x00000000
    \
    $00 constant OTG_XFRCM                      \ [0x00] Transfer completed mask
    $01 constant OTG_CHHM                       \ [0x01] Channel halted mask
    $02 constant OTG_AHBERRM                    \ [0x02] AHB error.
    $03 constant OTG_STALLM                     \ [0x03] STALL response received interrupt mask.
    $04 constant OTG_NAKM                       \ [0x04] NAK response received interrupt mask.
    $05 constant OTG_ACKM                       \ [0x05] ACK response received/transmitted interrupt mask.
    $06 constant OTG_NYET                       \ [0x06] response received interrupt mask.
    $07 constant OTG_TXERRM                     \ [0x07] Transaction error mask.
    $08 constant OTG_BBERRM                     \ [0x08] Babble error mask.
    $09 constant OTG_FRMORM                     \ [0x09] Frame overrun mask.
    $0a constant OTG_DTERRM                     \ [0x0a] Data toggle error mask.
  [then]


  [ifdef] OTG_OTG_HCTSIZ11_DEF
    \
    \ @brief OTG host channel 11 transfer size register
    \ Address offset: 0x670
    \ Reset value: 0x00000000
    \
    $00 constant OTG_XFRSIZ                     \ [0x00 : 19] Transfer size
    $13 constant OTG_PKTCNT                     \ [0x13 : 10] Packet count
    $1d constant OTG_DPID                       \ [0x1d : 2] Data PID
    $1f constant OTG_DOPNG                      \ [0x1f] Do Ping
  [then]


  [ifdef] OTG_OTG_HCDMA11_DEF
    \
    \ @brief OTG host channel 11 DMA address register
    \ Address offset: 0x674
    \ Reset value: 0x00000000
    \
    $00 constant OTG_DMAADDR                    \ [0x00 : 32] DMA address
  [then]


  [ifdef] OTG_OTG_HCCHAR12_DEF
    \
    \ @brief OTG host channel 12 characteristics register
    \ Address offset: 0x680
    \ Reset value: 0x00000000
    \
    $00 constant OTG_MPSIZ                      \ [0x00 : 11] Maximum packet size
    $0b constant OTG_EPNUM                      \ [0x0b : 4] Endpoint number
    $0f constant OTG_EPDIR                      \ [0x0f] Endpoint direction
    $11 constant OTG_LSDEV                      \ [0x11] Low-speed device
    $12 constant OTG_EPTYP                      \ [0x12 : 2] Endpoint type
    $14 constant OTG_MCNT                       \ [0x14 : 2] Multicount
    $16 constant OTG_DAD                        \ [0x16 : 7] Device address
    $1d constant OTG_ODDFRM                     \ [0x1d] Odd frame
    $1e constant OTG_CHDIS                      \ [0x1e] Channel disable
    $1f constant OTG_CHENA                      \ [0x1f] Channel enable
  [then]


  [ifdef] OTG_OTG_HCSPLT12_DEF
    \
    \ @brief OTG host channel 12 split control register
    \ Address offset: 0x684
    \ Reset value: 0x00000000
    \
    $00 constant OTG_PRTADDR                    \ [0x00 : 7] Port address
    $07 constant OTG_HUBADDR                    \ [0x07 : 7] Hub address
    $0e constant OTG_XACTPOS                    \ [0x0e : 2] Transaction position
    $10 constant OTG_COMPLSPLT                  \ [0x10] Do complete split
    $1f constant OTG_SPLITEN                    \ [0x1f] Split enable
  [then]


  [ifdef] OTG_OTG_HCINT12_DEF
    \
    \ @brief OTG host channel 12 interrupt register
    \ Address offset: 0x688
    \ Reset value: 0x00000000
    \
    $00 constant OTG_XFRC                       \ [0x00] Transfer completed.
    $01 constant OTG_CHH                        \ [0x01] Channel halted.
    $02 constant OTG_AHBERR                     \ [0x02] AHB error
    $03 constant OTG_STALL                      \ [0x03] STALL response received interrupt.
    $04 constant OTG_NAK                        \ [0x04] NAK response received interrupt.
    $05 constant OTG_ACK                        \ [0x05] ACK response received/transmitted interrupt.
    $06 constant OTG_NYET                       \ [0x06] Not yet ready response received interrupt.
    $07 constant OTG_TXERR                      \ [0x07] Transaction error.
    $08 constant OTG_BBERR                      \ [0x08] Babble error.
    $09 constant OTG_FRMOR                      \ [0x09] Frame overrun.
    $0a constant OTG_DTERR                      \ [0x0a] Data toggle error.
  [then]


  [ifdef] OTG_OTG_HCINTMSK12_DEF
    \
    \ @brief OTG host channel 12 interrupt mask register
    \ Address offset: 0x68C
    \ Reset value: 0x00000000
    \
    $00 constant OTG_XFRCM                      \ [0x00] Transfer completed mask
    $01 constant OTG_CHHM                       \ [0x01] Channel halted mask
    $02 constant OTG_AHBERRM                    \ [0x02] AHB error.
    $03 constant OTG_STALLM                     \ [0x03] STALL response received interrupt mask.
    $04 constant OTG_NAKM                       \ [0x04] NAK response received interrupt mask.
    $05 constant OTG_ACKM                       \ [0x05] ACK response received/transmitted interrupt mask.
    $06 constant OTG_NYET                       \ [0x06] response received interrupt mask.
    $07 constant OTG_TXERRM                     \ [0x07] Transaction error mask.
    $08 constant OTG_BBERRM                     \ [0x08] Babble error mask.
    $09 constant OTG_FRMORM                     \ [0x09] Frame overrun mask.
    $0a constant OTG_DTERRM                     \ [0x0a] Data toggle error mask.
  [then]


  [ifdef] OTG_OTG_HCTSIZ12_DEF
    \
    \ @brief OTG host channel 12 transfer size register
    \ Address offset: 0x690
    \ Reset value: 0x00000000
    \
    $00 constant OTG_XFRSIZ                     \ [0x00 : 19] Transfer size
    $13 constant OTG_PKTCNT                     \ [0x13 : 10] Packet count
    $1d constant OTG_DPID                       \ [0x1d : 2] Data PID
    $1f constant OTG_DOPNG                      \ [0x1f] Do Ping
  [then]


  [ifdef] OTG_OTG_HCDMA12_DEF
    \
    \ @brief OTG host channel 12 DMA address register
    \ Address offset: 0x694
    \ Reset value: 0x00000000
    \
    $00 constant OTG_DMAADDR                    \ [0x00 : 32] DMA address
  [then]


  [ifdef] OTG_OTG_HCCHAR13_DEF
    \
    \ @brief OTG host channel 13 characteristics register
    \ Address offset: 0x6A0
    \ Reset value: 0x00000000
    \
    $00 constant OTG_MPSIZ                      \ [0x00 : 11] Maximum packet size
    $0b constant OTG_EPNUM                      \ [0x0b : 4] Endpoint number
    $0f constant OTG_EPDIR                      \ [0x0f] Endpoint direction
    $11 constant OTG_LSDEV                      \ [0x11] Low-speed device
    $12 constant OTG_EPTYP                      \ [0x12 : 2] Endpoint type
    $14 constant OTG_MCNT                       \ [0x14 : 2] Multicount
    $16 constant OTG_DAD                        \ [0x16 : 7] Device address
    $1d constant OTG_ODDFRM                     \ [0x1d] Odd frame
    $1e constant OTG_CHDIS                      \ [0x1e] Channel disable
    $1f constant OTG_CHENA                      \ [0x1f] Channel enable
  [then]


  [ifdef] OTG_OTG_HCSPLT13_DEF
    \
    \ @brief OTG host channel 13 split control register
    \ Address offset: 0x6A4
    \ Reset value: 0x00000000
    \
    $00 constant OTG_PRTADDR                    \ [0x00 : 7] Port address
    $07 constant OTG_HUBADDR                    \ [0x07 : 7] Hub address
    $0e constant OTG_XACTPOS                    \ [0x0e : 2] Transaction position
    $10 constant OTG_COMPLSPLT                  \ [0x10] Do complete split
    $1f constant OTG_SPLITEN                    \ [0x1f] Split enable
  [then]


  [ifdef] OTG_OTG_HCINT13_DEF
    \
    \ @brief OTG host channel 13 interrupt register
    \ Address offset: 0x6A8
    \ Reset value: 0x00000000
    \
    $00 constant OTG_XFRC                       \ [0x00] Transfer completed.
    $01 constant OTG_CHH                        \ [0x01] Channel halted.
    $02 constant OTG_AHBERR                     \ [0x02] AHB error
    $03 constant OTG_STALL                      \ [0x03] STALL response received interrupt.
    $04 constant OTG_NAK                        \ [0x04] NAK response received interrupt.
    $05 constant OTG_ACK                        \ [0x05] ACK response received/transmitted interrupt.
    $06 constant OTG_NYET                       \ [0x06] Not yet ready response received interrupt.
    $07 constant OTG_TXERR                      \ [0x07] Transaction error.
    $08 constant OTG_BBERR                      \ [0x08] Babble error.
    $09 constant OTG_FRMOR                      \ [0x09] Frame overrun.
    $0a constant OTG_DTERR                      \ [0x0a] Data toggle error.
  [then]


  [ifdef] OTG_OTG_HCINTMSK13_DEF
    \
    \ @brief OTG host channel 13 interrupt mask register
    \ Address offset: 0x6AC
    \ Reset value: 0x00000000
    \
    $00 constant OTG_XFRCM                      \ [0x00] Transfer completed mask
    $01 constant OTG_CHHM                       \ [0x01] Channel halted mask
    $02 constant OTG_AHBERRM                    \ [0x02] AHB error.
    $03 constant OTG_STALLM                     \ [0x03] STALL response received interrupt mask.
    $04 constant OTG_NAKM                       \ [0x04] NAK response received interrupt mask.
    $05 constant OTG_ACKM                       \ [0x05] ACK response received/transmitted interrupt mask.
    $06 constant OTG_NYET                       \ [0x06] response received interrupt mask.
    $07 constant OTG_TXERRM                     \ [0x07] Transaction error mask.
    $08 constant OTG_BBERRM                     \ [0x08] Babble error mask.
    $09 constant OTG_FRMORM                     \ [0x09] Frame overrun mask.
    $0a constant OTG_DTERRM                     \ [0x0a] Data toggle error mask.
  [then]


  [ifdef] OTG_OTG_HCTSIZ13_DEF
    \
    \ @brief OTG host channel 13 transfer size register
    \ Address offset: 0x6B0
    \ Reset value: 0x00000000
    \
    $00 constant OTG_XFRSIZ                     \ [0x00 : 19] Transfer size
    $13 constant OTG_PKTCNT                     \ [0x13 : 10] Packet count
    $1d constant OTG_DPID                       \ [0x1d : 2] Data PID
    $1f constant OTG_DOPNG                      \ [0x1f] Do Ping
  [then]


  [ifdef] OTG_OTG_HCDMA13_DEF
    \
    \ @brief OTG host channel 13 DMA address register
    \ Address offset: 0x6B4
    \ Reset value: 0x00000000
    \
    $00 constant OTG_DMAADDR                    \ [0x00 : 32] DMA address
  [then]


  [ifdef] OTG_OTG_HCCHAR14_DEF
    \
    \ @brief OTG host channel 14 characteristics register
    \ Address offset: 0x6C0
    \ Reset value: 0x00000000
    \
    $00 constant OTG_MPSIZ                      \ [0x00 : 11] Maximum packet size
    $0b constant OTG_EPNUM                      \ [0x0b : 4] Endpoint number
    $0f constant OTG_EPDIR                      \ [0x0f] Endpoint direction
    $11 constant OTG_LSDEV                      \ [0x11] Low-speed device
    $12 constant OTG_EPTYP                      \ [0x12 : 2] Endpoint type
    $14 constant OTG_MCNT                       \ [0x14 : 2] Multicount
    $16 constant OTG_DAD                        \ [0x16 : 7] Device address
    $1d constant OTG_ODDFRM                     \ [0x1d] Odd frame
    $1e constant OTG_CHDIS                      \ [0x1e] Channel disable
    $1f constant OTG_CHENA                      \ [0x1f] Channel enable
  [then]


  [ifdef] OTG_OTG_HCSPLT14_DEF
    \
    \ @brief OTG host channel 14 split control register
    \ Address offset: 0x6C4
    \ Reset value: 0x00000000
    \
    $00 constant OTG_PRTADDR                    \ [0x00 : 7] Port address
    $07 constant OTG_HUBADDR                    \ [0x07 : 7] Hub address
    $0e constant OTG_XACTPOS                    \ [0x0e : 2] Transaction position
    $10 constant OTG_COMPLSPLT                  \ [0x10] Do complete split
    $1f constant OTG_SPLITEN                    \ [0x1f] Split enable
  [then]


  [ifdef] OTG_OTG_HCINT14_DEF
    \
    \ @brief OTG host channel 14 interrupt register
    \ Address offset: 0x6C8
    \ Reset value: 0x00000000
    \
    $00 constant OTG_XFRC                       \ [0x00] Transfer completed.
    $01 constant OTG_CHH                        \ [0x01] Channel halted.
    $02 constant OTG_AHBERR                     \ [0x02] AHB error
    $03 constant OTG_STALL                      \ [0x03] STALL response received interrupt.
    $04 constant OTG_NAK                        \ [0x04] NAK response received interrupt.
    $05 constant OTG_ACK                        \ [0x05] ACK response received/transmitted interrupt.
    $06 constant OTG_NYET                       \ [0x06] Not yet ready response received interrupt.
    $07 constant OTG_TXERR                      \ [0x07] Transaction error.
    $08 constant OTG_BBERR                      \ [0x08] Babble error.
    $09 constant OTG_FRMOR                      \ [0x09] Frame overrun.
    $0a constant OTG_DTERR                      \ [0x0a] Data toggle error.
  [then]


  [ifdef] OTG_OTG_HCINTMSK14_DEF
    \
    \ @brief OTG host channel 14 interrupt mask register
    \ Address offset: 0x6CC
    \ Reset value: 0x00000000
    \
    $00 constant OTG_XFRCM                      \ [0x00] Transfer completed mask
    $01 constant OTG_CHHM                       \ [0x01] Channel halted mask
    $02 constant OTG_AHBERRM                    \ [0x02] AHB error.
    $03 constant OTG_STALLM                     \ [0x03] STALL response received interrupt mask.
    $04 constant OTG_NAKM                       \ [0x04] NAK response received interrupt mask.
    $05 constant OTG_ACKM                       \ [0x05] ACK response received/transmitted interrupt mask.
    $06 constant OTG_NYET                       \ [0x06] response received interrupt mask.
    $07 constant OTG_TXERRM                     \ [0x07] Transaction error mask.
    $08 constant OTG_BBERRM                     \ [0x08] Babble error mask.
    $09 constant OTG_FRMORM                     \ [0x09] Frame overrun mask.
    $0a constant OTG_DTERRM                     \ [0x0a] Data toggle error mask.
  [then]


  [ifdef] OTG_OTG_HCTSIZ14_DEF
    \
    \ @brief OTG host channel 14 transfer size register
    \ Address offset: 0x6D0
    \ Reset value: 0x00000000
    \
    $00 constant OTG_XFRSIZ                     \ [0x00 : 19] Transfer size
    $13 constant OTG_PKTCNT                     \ [0x13 : 10] Packet count
    $1d constant OTG_DPID                       \ [0x1d : 2] Data PID
    $1f constant OTG_DOPNG                      \ [0x1f] Do Ping
  [then]


  [ifdef] OTG_OTG_HCDMA14_DEF
    \
    \ @brief OTG host channel 14 DMA address register
    \ Address offset: 0x6D4
    \ Reset value: 0x00000000
    \
    $00 constant OTG_DMAADDR                    \ [0x00 : 32] DMA address
  [then]


  [ifdef] OTG_OTG_HCCHAR15_DEF
    \
    \ @brief OTG host channel 15 characteristics register
    \ Address offset: 0x6E0
    \ Reset value: 0x00000000
    \
    $00 constant OTG_MPSIZ                      \ [0x00 : 11] Maximum packet size
    $0b constant OTG_EPNUM                      \ [0x0b : 4] Endpoint number
    $0f constant OTG_EPDIR                      \ [0x0f] Endpoint direction
    $11 constant OTG_LSDEV                      \ [0x11] Low-speed device
    $12 constant OTG_EPTYP                      \ [0x12 : 2] Endpoint type
    $14 constant OTG_MCNT                       \ [0x14 : 2] Multicount
    $16 constant OTG_DAD                        \ [0x16 : 7] Device address
    $1d constant OTG_ODDFRM                     \ [0x1d] Odd frame
    $1e constant OTG_CHDIS                      \ [0x1e] Channel disable
    $1f constant OTG_CHENA                      \ [0x1f] Channel enable
  [then]


  [ifdef] OTG_OTG_HCSPLT15_DEF
    \
    \ @brief OTG host channel 15 split control register
    \ Address offset: 0x6E4
    \ Reset value: 0x00000000
    \
    $00 constant OTG_PRTADDR                    \ [0x00 : 7] Port address
    $07 constant OTG_HUBADDR                    \ [0x07 : 7] Hub address
    $0e constant OTG_XACTPOS                    \ [0x0e : 2] Transaction position
    $10 constant OTG_COMPLSPLT                  \ [0x10] Do complete split
    $1f constant OTG_SPLITEN                    \ [0x1f] Split enable
  [then]


  [ifdef] OTG_OTG_HCINT15_DEF
    \
    \ @brief OTG host channel 15 interrupt register
    \ Address offset: 0x6E8
    \ Reset value: 0x00000000
    \
    $00 constant OTG_XFRC                       \ [0x00] Transfer completed.
    $01 constant OTG_CHH                        \ [0x01] Channel halted.
    $02 constant OTG_AHBERR                     \ [0x02] AHB error
    $03 constant OTG_STALL                      \ [0x03] STALL response received interrupt.
    $04 constant OTG_NAK                        \ [0x04] NAK response received interrupt.
    $05 constant OTG_ACK                        \ [0x05] ACK response received/transmitted interrupt.
    $06 constant OTG_NYET                       \ [0x06] Not yet ready response received interrupt.
    $07 constant OTG_TXERR                      \ [0x07] Transaction error.
    $08 constant OTG_BBERR                      \ [0x08] Babble error.
    $09 constant OTG_FRMOR                      \ [0x09] Frame overrun.
    $0a constant OTG_DTERR                      \ [0x0a] Data toggle error.
  [then]


  [ifdef] OTG_OTG_HCINTMSK15_DEF
    \
    \ @brief OTG host channel 15 interrupt mask register
    \ Address offset: 0x6EC
    \ Reset value: 0x00000000
    \
    $00 constant OTG_XFRCM                      \ [0x00] Transfer completed mask
    $01 constant OTG_CHHM                       \ [0x01] Channel halted mask
    $02 constant OTG_AHBERRM                    \ [0x02] AHB error.
    $03 constant OTG_STALLM                     \ [0x03] STALL response received interrupt mask.
    $04 constant OTG_NAKM                       \ [0x04] NAK response received interrupt mask.
    $05 constant OTG_ACKM                       \ [0x05] ACK response received/transmitted interrupt mask.
    $06 constant OTG_NYET                       \ [0x06] response received interrupt mask.
    $07 constant OTG_TXERRM                     \ [0x07] Transaction error mask.
    $08 constant OTG_BBERRM                     \ [0x08] Babble error mask.
    $09 constant OTG_FRMORM                     \ [0x09] Frame overrun mask.
    $0a constant OTG_DTERRM                     \ [0x0a] Data toggle error mask.
  [then]


  [ifdef] OTG_OTG_HCTSIZ15_DEF
    \
    \ @brief OTG host channel 15 transfer size register
    \ Address offset: 0x6F0
    \ Reset value: 0x00000000
    \
    $00 constant OTG_XFRSIZ                     \ [0x00 : 19] Transfer size
    $13 constant OTG_PKTCNT                     \ [0x13 : 10] Packet count
    $1d constant OTG_DPID                       \ [0x1d : 2] Data PID
    $1f constant OTG_DOPNG                      \ [0x1f] Do Ping
  [then]


  [ifdef] OTG_OTG_HCDMA15_DEF
    \
    \ @brief OTG host channel 15 DMA address register
    \ Address offset: 0x6F4
    \ Reset value: 0x00000000
    \
    $00 constant OTG_DMAADDR                    \ [0x00 : 32] DMA address
  [then]


  [ifdef] OTG_OTG_DCFG_DEF
    \
    \ @brief OTG device configuration register
    \ Address offset: 0x800
    \ Reset value: 0x02200000
    \
    $00 constant OTG_DSPD                       \ [0x00 : 2] Device speed
    $02 constant OTG_NZLSOHSK                   \ [0x02] Non-zero-length status OUT handshake
    $04 constant OTG_DAD                        \ [0x04 : 7] Device address
    $0b constant OTG_PFIVL                      \ [0x0b : 2] Periodic frame interval
    $0f constant OTG_ERRATIM                    \ [0x0f] Erratic error interrupt mask
    $18 constant OTG_PERSCHIVL                  \ [0x18 : 2] Periodic schedule interval
  [then]


  [ifdef] OTG_OTG_DCTL_DEF
    \
    \ @brief OTG device control register
    \ Address offset: 0x804
    \ Reset value: 0x00000002
    \
    $00 constant OTG_RWUSIG                     \ [0x00] Remote wake-up signaling
    $01 constant OTG_SDIS                       \ [0x01] Soft disconnect
    $02 constant OTG_GINSTS                     \ [0x02] Global IN NAK status
    $03 constant OTG_GONSTS                     \ [0x03] Global OUT NAK status
    $04 constant OTG_TCTL                       \ [0x04 : 3] Test control
    $07 constant OTG_SGINAK                     \ [0x07] Set global IN NAK
    $08 constant OTG_CGINAK                     \ [0x08] Clear global IN NAK
    $09 constant OTG_SGONAK                     \ [0x09] Set global OUT NAK
    $0a constant OTG_CGONAK                     \ [0x0a] Clear global OUT NAK
    $0b constant OTG_POPRGDNE                   \ [0x0b] Power-on programming done
    $12 constant OTG_DSBESLRJCT                 \ [0x12] Deep sleep BESL reject
  [then]


  [ifdef] OTG_OTG_DSTS_DEF
    \
    \ @brief OTG device status register
    \ Address offset: 0x808
    \ Reset value: 0x00000010
    \
    $00 constant OTG_SUSPSTS                    \ [0x00] Suspend status
    $01 constant OTG_ENUMSPD                    \ [0x01 : 2] Enumerated speed
    $03 constant OTG_EERR                       \ [0x03] Erratic error
    $08 constant OTG_FNSOF                      \ [0x08 : 14] Frame number of the received SOF
    $16 constant OTG_DEVLNSTS                   \ [0x16 : 2] Device line status
  [then]


  [ifdef] OTG_OTG_DIEPMSK_DEF
    \
    \ @brief OTG device IN endpoint common interrupt mask register
    \ Address offset: 0x810
    \ Reset value: 0x00000000
    \
    $00 constant OTG_XFRCM                      \ [0x00] Transfer completed interrupt mask
    $01 constant OTG_EPDM                       \ [0x01] Endpoint disabled interrupt mask
    $02 constant OTG_AHBERRM                    \ [0x02] AHB error mask
    $03 constant OTG_TOM                        \ [0x03] Timeout condition mask (Non-isochronous endpoints)
    $04 constant OTG_ITTXFEMSK                  \ [0x04] IN token received when Tx FIFO empty mask
    $05 constant OTG_INEPNMM                    \ [0x05] IN token received with EP mismatch mask
    $06 constant OTG_INEPNEM                    \ [0x06] IN endpoint NAK effective mask
    $08 constant OTG_TXFURM                     \ [0x08] FIFO underrun mask
    $0d constant OTG_NAKM                       \ [0x0d] NAK interrupt mask
  [then]


  [ifdef] OTG_OTG_DOEPMSK_DEF
    \
    \ @brief OTG device OUT endpoint common interrupt mask register
    \ Address offset: 0x814
    \ Reset value: 0x00000000
    \
    $00 constant OTG_XFRCM                      \ [0x00] Transfer completed interrupt mask
    $01 constant OTG_EPDM                       \ [0x01] Endpoint disabled interrupt mask
    $02 constant OTG_AHBERRM                    \ [0x02] AHB error mask
    $03 constant OTG_STUPM                      \ [0x03] STUPM: SETUP phase done mask. Applies to control endpoints only.
    $04 constant OTG_OTEPDM                     \ [0x04] OUT token received when endpoint disabled mask. Applies to control OUT endpoints only.
    $05 constant OTG_STSPHSRXM                  \ [0x05] Status phase received for control write mask
    $06 constant OTG_B2BSTUPM                   \ [0x06] Back-to-back SETUP packets received mask
    $08 constant OTG_OUTPKTERRM                 \ [0x08] Out packet error mask
    $0c constant OTG_BERRM                      \ [0x0c] Babble error interrupt mask
    $0d constant OTG_NAKMSK                     \ [0x0d] NAK interrupt mask
    $0e constant OTG_NYETMSK                    \ [0x0e] NYET interrupt mask
  [then]


  [ifdef] OTG_OTG_DAINT_DEF
    \
    \ @brief OTG device all endpoints interrupt register
    \ Address offset: 0x818
    \ Reset value: 0x00000000
    \
    $00 constant OTG_IEPINT                     \ [0x00 : 16] IN endpoint interrupt bits
    $10 constant OTG_OEPINT                     \ [0x10 : 16] OUT endpoint interrupt bits
  [then]


  [ifdef] OTG_OTG_DAINTMSK_DEF
    \
    \ @brief OTG all endpoints interrupt mask register
    \ Address offset: 0x81C
    \ Reset value: 0x00000000
    \
    $00 constant OTG_IEPM                       \ [0x00 : 16] IN EP interrupt mask bits
    $10 constant OTG_OEPM                       \ [0x10 : 16] OUT EP interrupt mask bits
  [then]


  [ifdef] OTG_OTG_DTHRCTL_DEF
    \
    \ @brief OTG device threshold control register
    \ Address offset: 0x830
    \ Reset value: 0x00000000
    \
    $00 constant OTG_NONISOTHREN                \ [0x00] Nonisochronous IN endpoints threshold enable
    $01 constant OTG_ISOTHREN                   \ [0x01] ISO IN endpoint threshold enable
    $02 constant OTG_TXTHRLEN                   \ [0x02 : 9] Transmit threshold length
    $10 constant OTG_RXTHREN                    \ [0x10] Receive threshold enable
    $11 constant OTG_RXTHRLEN                   \ [0x11 : 9] Receive threshold length
    $1b constant OTG_ARPEN                      \ [0x1b] Arbiter parking enable
  [then]


  [ifdef] OTG_OTG_DIEPEMPMSK_DEF
    \
    \ @brief OTG device IN endpoint FIFO empty interrupt mask register
    \ Address offset: 0x834
    \ Reset value: 0x00000000
    \
    $00 constant OTG_INEPTXFEM                  \ [0x00 : 16] IN EP Tx FIFO empty interrupt mask bits
  [then]


  [ifdef] OTG_OTG_DIEPCTL0_DEF
    \
    \ @brief OTG device IN endpoint 0 control register [alternate]
    \ Address offset: 0x900
    \ Reset value: 0x00000000
    \
    $00 constant OTG_MPSIZ                      \ [0x00 : 11] Maximum packet size
    $0f constant OTG_USBAEP                     \ [0x0f] USB active endpoint
    $10 constant OTG_DPID                       \ [0x10] Endpoint data PID
    $11 constant OTG_NAKSTS                     \ [0x11] NAK status
    $12 constant OTG_EPTYP                      \ [0x12 : 2] Endpoint type
    $15 constant OTG_STALL                      \ [0x15] STALL handshake
    $16 constant OTG_TXFNUM                     \ [0x16 : 4] Tx FIFO number
    $1a constant OTG_CNAK                       \ [0x1a] Clear NAK
    $1b constant OTG_SNAK                       \ [0x1b] Set NAK
    $1c constant OTG_SD0PID                     \ [0x1c] Set DATA0 PID
    $1d constant OTG_SD1PID                     \ [0x1d] Set DATA1 PID
    $1e constant OTG_EPDIS                      \ [0x1e] Endpoint disable
    $1f constant OTG_EPENA                      \ [0x1f] Endpoint enable
  [then]


  [ifdef] OTG_OTG_DIEPCTL0_ALTERNATE_DEF
    \
    \ @brief OTG device IN endpoint 0 control register [alternate]
    \ Address offset: 0x900
    \ Reset value: 0x00000000
    \
    $00 constant OTG_MPSIZ                      \ [0x00 : 11] Maximum packet size
    $0f constant OTG_USBAEP                     \ [0x0f] USB active endpoint
    $10 constant OTG_EONUM                      \ [0x10] Even/odd frame
    $11 constant OTG_NAKSTS                     \ [0x11] NAK status
    $12 constant OTG_EPTYP                      \ [0x12 : 2] Endpoint type
    $15 constant OTG_STALL                      \ [0x15] STALL handshake
    $16 constant OTG_TXFNUM                     \ [0x16 : 4] Tx FIFO number
    $1a constant OTG_CNAK                       \ [0x1a] Clear NAK
    $1b constant OTG_SNAK                       \ [0x1b] Set NAK
    $1c constant OTG_SEVNFRM                    \ [0x1c] Set even frame
    $1d constant OTG_SODDFRM                    \ [0x1d] Set odd frame
    $1e constant OTG_EPDIS                      \ [0x1e] Endpoint disable
    $1f constant OTG_EPENA                      \ [0x1f] Endpoint enable
  [then]


  [ifdef] OTG_OTG_DIEPINT0_DEF
    \
    \ @brief OTG device IN endpoint 0 interrupt register
    \ Address offset: 0x908
    \ Reset value: 0x00000080
    \
    $00 constant OTG_XFRC                       \ [0x00] Transfer completed interrupt
    $01 constant OTG_EPDISD                     \ [0x01] Endpoint disabled interrupt
    $02 constant OTG_AHBERR                     \ [0x02] AHB error
    $03 constant OTG_TOC                        \ [0x03] Timeout condition
    $04 constant OTG_ITTXFE                     \ [0x04] IN token received when Tx FIFO is empty
    $05 constant OTG_INEPNM                     \ [0x05] IN token received with EP mismatch
    $06 constant OTG_INEPNE                     \ [0x06] IN endpoint NAK effective
    $07 constant OTG_TXFE                       \ [0x07] Transmit FIFO empty
    $08 constant OTG_TXFIFOUDRN                 \ [0x08] Transmit Fifo Underrun (TxfifoUndrn)
    $0b constant OTG_PKTDRPSTS                  \ [0x0b] Packet dropped status
    $0d constant OTG_NAK                        \ [0x0d] NAK input
  [then]


  [ifdef] OTG_OTG_DIEPTSIZ0_DEF
    \
    \ @brief OTG device IN endpoint 0 transfer size register
    \ Address offset: 0x910
    \ Reset value: 0x00000000
    \
    $00 constant OTG_XFRSIZ                     \ [0x00 : 7] Transfer size
    $13 constant OTG_PKTCNT                     \ [0x13 : 2] Packet count
  [then]


  [ifdef] OTG_OTG_DIEPDMA0_DEF
    \
    \ @brief OTG device IN endpoint 0 DMA address register
    \ Address offset: 0x914
    \ Reset value: 0x00000000
    \
    $00 constant OTG_DMAADDR                    \ [0x00 : 32] DMA Address
  [then]


  [ifdef] OTG_OTG_DTXFSTS0_DEF
    \
    \ @brief OTG device IN endpoint transmit FIFO status register
    \ Address offset: 0x918
    \ Reset value: 0x00000200
    \
    $00 constant OTG_INEPTFSAV                  \ [0x00 : 16] IN endpoint Tx FIFO space available
  [then]


  [ifdef] OTG_OTG_DIEPCTL1_DEF
    \
    \ @brief OTG device IN endpoint 1 control register [alternate]
    \ Address offset: 0x920
    \ Reset value: 0x00000000
    \
    $00 constant OTG_MPSIZ                      \ [0x00 : 11] Maximum packet size
    $0f constant OTG_USBAEP                     \ [0x0f] USB active endpoint
    $10 constant OTG_DPID                       \ [0x10] Endpoint data PID
    $11 constant OTG_NAKSTS                     \ [0x11] NAK status
    $12 constant OTG_EPTYP                      \ [0x12 : 2] Endpoint type
    $15 constant OTG_STALL                      \ [0x15] STALL handshake
    $16 constant OTG_TXFNUM                     \ [0x16 : 4] Tx FIFO number
    $1a constant OTG_CNAK                       \ [0x1a] Clear NAK
    $1b constant OTG_SNAK                       \ [0x1b] Set NAK
    $1c constant OTG_SD0PID                     \ [0x1c] Set DATA0 PID
    $1d constant OTG_SD1PID                     \ [0x1d] Set DATA1 PID
    $1e constant OTG_EPDIS                      \ [0x1e] Endpoint disable
    $1f constant OTG_EPENA                      \ [0x1f] Endpoint enable
  [then]


  [ifdef] OTG_OTG_DIEPCTL1_ALTERNATE_DEF
    \
    \ @brief OTG device IN endpoint 1 control register [alternate]
    \ Address offset: 0x920
    \ Reset value: 0x00000000
    \
    $00 constant OTG_MPSIZ                      \ [0x00 : 11] Maximum packet size
    $0f constant OTG_USBAEP                     \ [0x0f] USB active endpoint
    $10 constant OTG_EONUM                      \ [0x10] Even/odd frame
    $11 constant OTG_NAKSTS                     \ [0x11] NAK status
    $12 constant OTG_EPTYP                      \ [0x12 : 2] Endpoint type
    $15 constant OTG_STALL                      \ [0x15] STALL handshake
    $16 constant OTG_TXFNUM                     \ [0x16 : 4] Tx FIFO number
    $1a constant OTG_CNAK                       \ [0x1a] Clear NAK
    $1b constant OTG_SNAK                       \ [0x1b] Set NAK
    $1c constant OTG_SEVNFRM                    \ [0x1c] Set even frame
    $1d constant OTG_SODDFRM                    \ [0x1d] Set odd frame
    $1e constant OTG_EPDIS                      \ [0x1e] Endpoint disable
    $1f constant OTG_EPENA                      \ [0x1f] Endpoint enable
  [then]


  [ifdef] OTG_OTG_DIEPINT1_DEF
    \
    \ @brief OTG device IN endpoint 1 interrupt register
    \ Address offset: 0x928
    \ Reset value: 0x00000080
    \
    $00 constant OTG_XFRC                       \ [0x00] Transfer completed interrupt
    $01 constant OTG_EPDISD                     \ [0x01] Endpoint disabled interrupt
    $02 constant OTG_AHBERR                     \ [0x02] AHB error
    $03 constant OTG_TOC                        \ [0x03] Timeout condition
    $04 constant OTG_ITTXFE                     \ [0x04] IN token received when Tx FIFO is empty
    $05 constant OTG_INEPNM                     \ [0x05] IN token received with EP mismatch
    $06 constant OTG_INEPNE                     \ [0x06] IN endpoint NAK effective
    $07 constant OTG_TXFE                       \ [0x07] Transmit FIFO empty
    $08 constant OTG_TXFIFOUDRN                 \ [0x08] Transmit Fifo Underrun (TxfifoUndrn)
    $0b constant OTG_PKTDRPSTS                  \ [0x0b] Packet dropped status
    $0d constant OTG_NAK                        \ [0x0d] NAK input
  [then]


  [ifdef] OTG_OTG_DIEPTSIZ1_DEF
    \
    \ @brief OTG device IN endpoint 1 transfer size register
    \ Address offset: 0x930
    \ Reset value: 0x00000000
    \
    $00 constant OTG_XFRSIZ                     \ [0x00 : 19] Transfer size
    $13 constant OTG_PKTCNT                     \ [0x13 : 10] Packet count
    $1d constant OTG_MCNT                       \ [0x1d : 2] Multi count
  [then]


  [ifdef] OTG_OTG_DIEPDMA1_DEF
    \
    \ @brief OTG device IN endpoint 1 DMA address register
    \ Address offset: 0x934
    \ Reset value: 0x00000000
    \
    $00 constant OTG_DMAADDR                    \ [0x00 : 32] DMA Address
  [then]


  [ifdef] OTG_OTG_DTXFSTS1_DEF
    \
    \ @brief OTG device IN endpoint transmit FIFO status register
    \ Address offset: 0x938
    \ Reset value: 0x00000200
    \
    $00 constant OTG_INEPTFSAV                  \ [0x00 : 16] IN endpoint Tx FIFO space available
  [then]


  [ifdef] OTG_OTG_DIEPCTL2_DEF
    \
    \ @brief OTG device IN endpoint 2 control register [alternate]
    \ Address offset: 0x940
    \ Reset value: 0x00000000
    \
    $00 constant OTG_MPSIZ                      \ [0x00 : 11] Maximum packet size
    $0f constant OTG_USBAEP                     \ [0x0f] USB active endpoint
    $10 constant OTG_DPID                       \ [0x10] Endpoint data PID
    $11 constant OTG_NAKSTS                     \ [0x11] NAK status
    $12 constant OTG_EPTYP                      \ [0x12 : 2] Endpoint type
    $15 constant OTG_STALL                      \ [0x15] STALL handshake
    $16 constant OTG_TXFNUM                     \ [0x16 : 4] Tx FIFO number
    $1a constant OTG_CNAK                       \ [0x1a] Clear NAK
    $1b constant OTG_SNAK                       \ [0x1b] Set NAK
    $1c constant OTG_SD0PID                     \ [0x1c] Set DATA0 PID
    $1d constant OTG_SD1PID                     \ [0x1d] Set DATA1 PID
    $1e constant OTG_EPDIS                      \ [0x1e] Endpoint disable
    $1f constant OTG_EPENA                      \ [0x1f] Endpoint enable
  [then]


  [ifdef] OTG_OTG_DIEPCTL2_ALTERNATE_DEF
    \
    \ @brief OTG device IN endpoint 2 control register [alternate]
    \ Address offset: 0x940
    \ Reset value: 0x00000000
    \
    $00 constant OTG_MPSIZ                      \ [0x00 : 11] Maximum packet size
    $0f constant OTG_USBAEP                     \ [0x0f] USB active endpoint
    $10 constant OTG_EONUM                      \ [0x10] Even/odd frame
    $11 constant OTG_NAKSTS                     \ [0x11] NAK status
    $12 constant OTG_EPTYP                      \ [0x12 : 2] Endpoint type
    $15 constant OTG_STALL                      \ [0x15] STALL handshake
    $16 constant OTG_TXFNUM                     \ [0x16 : 4] Tx FIFO number
    $1a constant OTG_CNAK                       \ [0x1a] Clear NAK
    $1b constant OTG_SNAK                       \ [0x1b] Set NAK
    $1c constant OTG_SEVNFRM                    \ [0x1c] Set even frame
    $1d constant OTG_SODDFRM                    \ [0x1d] Set odd frame
    $1e constant OTG_EPDIS                      \ [0x1e] Endpoint disable
    $1f constant OTG_EPENA                      \ [0x1f] Endpoint enable
  [then]


  [ifdef] OTG_OTG_DIEPINT2_DEF
    \
    \ @brief OTG device IN endpoint 2 interrupt register
    \ Address offset: 0x948
    \ Reset value: 0x00000080
    \
    $00 constant OTG_XFRC                       \ [0x00] Transfer completed interrupt
    $01 constant OTG_EPDISD                     \ [0x01] Endpoint disabled interrupt
    $02 constant OTG_AHBERR                     \ [0x02] AHB error
    $03 constant OTG_TOC                        \ [0x03] Timeout condition
    $04 constant OTG_ITTXFE                     \ [0x04] IN token received when Tx FIFO is empty
    $05 constant OTG_INEPNM                     \ [0x05] IN token received with EP mismatch
    $06 constant OTG_INEPNE                     \ [0x06] IN endpoint NAK effective
    $07 constant OTG_TXFE                       \ [0x07] Transmit FIFO empty
    $08 constant OTG_TXFIFOUDRN                 \ [0x08] Transmit Fifo Underrun (TxfifoUndrn)
    $0b constant OTG_PKTDRPSTS                  \ [0x0b] Packet dropped status
    $0d constant OTG_NAK                        \ [0x0d] NAK input
  [then]


  [ifdef] OTG_OTG_DIEPTSIZ2_DEF
    \
    \ @brief OTG device IN endpoint 2 transfer size register
    \ Address offset: 0x950
    \ Reset value: 0x00000000
    \
    $00 constant OTG_XFRSIZ                     \ [0x00 : 19] Transfer size
    $13 constant OTG_PKTCNT                     \ [0x13 : 10] Packet count
    $1d constant OTG_MCNT                       \ [0x1d : 2] Multi count
  [then]


  [ifdef] OTG_OTG_DIEPDMA2_DEF
    \
    \ @brief OTG device IN endpoint 2 DMA address register
    \ Address offset: 0x954
    \ Reset value: 0x00000000
    \
    $00 constant OTG_DMAADDR                    \ [0x00 : 32] DMA Address
  [then]


  [ifdef] OTG_OTG_DTXFSTS2_DEF
    \
    \ @brief OTG device IN endpoint transmit FIFO status register
    \ Address offset: 0x958
    \ Reset value: 0x00000200
    \
    $00 constant OTG_INEPTFSAV                  \ [0x00 : 16] IN endpoint Tx FIFO space available
  [then]


  [ifdef] OTG_OTG_DIEPCTL3_DEF
    \
    \ @brief OTG device IN endpoint 3 control register [alternate]
    \ Address offset: 0x960
    \ Reset value: 0x00000000
    \
    $00 constant OTG_MPSIZ                      \ [0x00 : 11] Maximum packet size
    $0f constant OTG_USBAEP                     \ [0x0f] USB active endpoint
    $10 constant OTG_DPID                       \ [0x10] Endpoint data PID
    $11 constant OTG_NAKSTS                     \ [0x11] NAK status
    $12 constant OTG_EPTYP                      \ [0x12 : 2] Endpoint type
    $15 constant OTG_STALL                      \ [0x15] STALL handshake
    $16 constant OTG_TXFNUM                     \ [0x16 : 4] Tx FIFO number
    $1a constant OTG_CNAK                       \ [0x1a] Clear NAK
    $1b constant OTG_SNAK                       \ [0x1b] Set NAK
    $1c constant OTG_SD0PID                     \ [0x1c] Set DATA0 PID
    $1d constant OTG_SD1PID                     \ [0x1d] Set DATA1 PID
    $1e constant OTG_EPDIS                      \ [0x1e] Endpoint disable
    $1f constant OTG_EPENA                      \ [0x1f] Endpoint enable
  [then]


  [ifdef] OTG_OTG_DIEPCTL3_ALTERNATE_DEF
    \
    \ @brief OTG device IN endpoint 3 control register [alternate]
    \ Address offset: 0x960
    \ Reset value: 0x00000000
    \
    $00 constant OTG_MPSIZ                      \ [0x00 : 11] Maximum packet size
    $0f constant OTG_USBAEP                     \ [0x0f] USB active endpoint
    $10 constant OTG_EONUM                      \ [0x10] Even/odd frame
    $11 constant OTG_NAKSTS                     \ [0x11] NAK status
    $12 constant OTG_EPTYP                      \ [0x12 : 2] Endpoint type
    $15 constant OTG_STALL                      \ [0x15] STALL handshake
    $16 constant OTG_TXFNUM                     \ [0x16 : 4] Tx FIFO number
    $1a constant OTG_CNAK                       \ [0x1a] Clear NAK
    $1b constant OTG_SNAK                       \ [0x1b] Set NAK
    $1c constant OTG_SEVNFRM                    \ [0x1c] Set even frame
    $1d constant OTG_SODDFRM                    \ [0x1d] Set odd frame
    $1e constant OTG_EPDIS                      \ [0x1e] Endpoint disable
    $1f constant OTG_EPENA                      \ [0x1f] Endpoint enable
  [then]


  [ifdef] OTG_OTG_DIEPINT3_DEF
    \
    \ @brief OTG device IN endpoint 3 interrupt register
    \ Address offset: 0x968
    \ Reset value: 0x00000080
    \
    $00 constant OTG_XFRC                       \ [0x00] Transfer completed interrupt
    $01 constant OTG_EPDISD                     \ [0x01] Endpoint disabled interrupt
    $02 constant OTG_AHBERR                     \ [0x02] AHB error
    $03 constant OTG_TOC                        \ [0x03] Timeout condition
    $04 constant OTG_ITTXFE                     \ [0x04] IN token received when Tx FIFO is empty
    $05 constant OTG_INEPNM                     \ [0x05] IN token received with EP mismatch
    $06 constant OTG_INEPNE                     \ [0x06] IN endpoint NAK effective
    $07 constant OTG_TXFE                       \ [0x07] Transmit FIFO empty
    $08 constant OTG_TXFIFOUDRN                 \ [0x08] Transmit Fifo Underrun (TxfifoUndrn)
    $0b constant OTG_PKTDRPSTS                  \ [0x0b] Packet dropped status
    $0d constant OTG_NAK                        \ [0x0d] NAK input
  [then]


  [ifdef] OTG_OTG_DIEPTSIZ3_DEF
    \
    \ @brief OTG device IN endpoint 3 transfer size register
    \ Address offset: 0x970
    \ Reset value: 0x00000000
    \
    $00 constant OTG_XFRSIZ                     \ [0x00 : 19] Transfer size
    $13 constant OTG_PKTCNT                     \ [0x13 : 10] Packet count
    $1d constant OTG_MCNT                       \ [0x1d : 2] Multi count
  [then]


  [ifdef] OTG_OTG_DIEPDMA3_DEF
    \
    \ @brief OTG device IN endpoint 3 DMA address register
    \ Address offset: 0x974
    \ Reset value: 0x00000000
    \
    $00 constant OTG_DMAADDR                    \ [0x00 : 32] DMA Address
  [then]


  [ifdef] OTG_OTG_DTXFSTS3_DEF
    \
    \ @brief OTG device IN endpoint transmit FIFO status register
    \ Address offset: 0x978
    \ Reset value: 0x00000200
    \
    $00 constant OTG_INEPTFSAV                  \ [0x00 : 16] IN endpoint Tx FIFO space available
  [then]


  [ifdef] OTG_OTG_DIEPCTL4_DEF
    \
    \ @brief OTG device IN endpoint 4 control register [alternate]
    \ Address offset: 0x980
    \ Reset value: 0x00000000
    \
    $00 constant OTG_MPSIZ                      \ [0x00 : 11] Maximum packet size
    $0f constant OTG_USBAEP                     \ [0x0f] USB active endpoint
    $10 constant OTG_DPID                       \ [0x10] Endpoint data PID
    $11 constant OTG_NAKSTS                     \ [0x11] NAK status
    $12 constant OTG_EPTYP                      \ [0x12 : 2] Endpoint type
    $15 constant OTG_STALL                      \ [0x15] STALL handshake
    $16 constant OTG_TXFNUM                     \ [0x16 : 4] Tx FIFO number
    $1a constant OTG_CNAK                       \ [0x1a] Clear NAK
    $1b constant OTG_SNAK                       \ [0x1b] Set NAK
    $1c constant OTG_SD0PID                     \ [0x1c] Set DATA0 PID
    $1d constant OTG_SD1PID                     \ [0x1d] Set DATA1 PID
    $1e constant OTG_EPDIS                      \ [0x1e] Endpoint disable
    $1f constant OTG_EPENA                      \ [0x1f] Endpoint enable
  [then]


  [ifdef] OTG_OTG_DIEPCTL4_ALTERNATE_DEF
    \
    \ @brief OTG device IN endpoint 4 control register [alternate]
    \ Address offset: 0x980
    \ Reset value: 0x00000000
    \
    $00 constant OTG_MPSIZ                      \ [0x00 : 11] Maximum packet size
    $0f constant OTG_USBAEP                     \ [0x0f] USB active endpoint
    $10 constant OTG_EONUM                      \ [0x10] Even/odd frame
    $11 constant OTG_NAKSTS                     \ [0x11] NAK status
    $12 constant OTG_EPTYP                      \ [0x12 : 2] Endpoint type
    $15 constant OTG_STALL                      \ [0x15] STALL handshake
    $16 constant OTG_TXFNUM                     \ [0x16 : 4] Tx FIFO number
    $1a constant OTG_CNAK                       \ [0x1a] Clear NAK
    $1b constant OTG_SNAK                       \ [0x1b] Set NAK
    $1c constant OTG_SEVNFRM                    \ [0x1c] Set even frame
    $1d constant OTG_SODDFRM                    \ [0x1d] Set odd frame
    $1e constant OTG_EPDIS                      \ [0x1e] Endpoint disable
    $1f constant OTG_EPENA                      \ [0x1f] Endpoint enable
  [then]


  [ifdef] OTG_OTG_DIEPINT4_DEF
    \
    \ @brief OTG device IN endpoint 4 interrupt register
    \ Address offset: 0x988
    \ Reset value: 0x00000080
    \
    $00 constant OTG_XFRC                       \ [0x00] Transfer completed interrupt
    $01 constant OTG_EPDISD                     \ [0x01] Endpoint disabled interrupt
    $02 constant OTG_AHBERR                     \ [0x02] AHB error
    $03 constant OTG_TOC                        \ [0x03] Timeout condition
    $04 constant OTG_ITTXFE                     \ [0x04] IN token received when Tx FIFO is empty
    $05 constant OTG_INEPNM                     \ [0x05] IN token received with EP mismatch
    $06 constant OTG_INEPNE                     \ [0x06] IN endpoint NAK effective
    $07 constant OTG_TXFE                       \ [0x07] Transmit FIFO empty
    $08 constant OTG_TXFIFOUDRN                 \ [0x08] Transmit Fifo Underrun (TxfifoUndrn)
    $0b constant OTG_PKTDRPSTS                  \ [0x0b] Packet dropped status
    $0d constant OTG_NAK                        \ [0x0d] NAK input
  [then]


  [ifdef] OTG_OTG_DIEPTSIZ4_DEF
    \
    \ @brief OTG device IN endpoint 4 transfer size register
    \ Address offset: 0x990
    \ Reset value: 0x00000000
    \
    $00 constant OTG_XFRSIZ                     \ [0x00 : 19] Transfer size
    $13 constant OTG_PKTCNT                     \ [0x13 : 10] Packet count
    $1d constant OTG_MCNT                       \ [0x1d : 2] Multi count
  [then]


  [ifdef] OTG_OTG_DIEPDMA4_DEF
    \
    \ @brief OTG device IN endpoint 4 DMA address register
    \ Address offset: 0x994
    \ Reset value: 0x00000000
    \
    $00 constant OTG_DMAADDR                    \ [0x00 : 32] DMA Address
  [then]


  [ifdef] OTG_OTG_DTXFSTS4_DEF
    \
    \ @brief OTG device IN endpoint transmit FIFO status register
    \ Address offset: 0x998
    \ Reset value: 0x00000200
    \
    $00 constant OTG_INEPTFSAV                  \ [0x00 : 16] IN endpoint Tx FIFO space available
  [then]


  [ifdef] OTG_OTG_DIEPCTL5_DEF
    \
    \ @brief OTG device IN endpoint 5 control register [alternate]
    \ Address offset: 0x9A0
    \ Reset value: 0x00000000
    \
    $00 constant OTG_MPSIZ                      \ [0x00 : 11] Maximum packet size
    $0f constant OTG_USBAEP                     \ [0x0f] USB active endpoint
    $10 constant OTG_DPID                       \ [0x10] Endpoint data PID
    $11 constant OTG_NAKSTS                     \ [0x11] NAK status
    $12 constant OTG_EPTYP                      \ [0x12 : 2] Endpoint type
    $15 constant OTG_STALL                      \ [0x15] STALL handshake
    $16 constant OTG_TXFNUM                     \ [0x16 : 4] Tx FIFO number
    $1a constant OTG_CNAK                       \ [0x1a] Clear NAK
    $1b constant OTG_SNAK                       \ [0x1b] Set NAK
    $1c constant OTG_SD0PID                     \ [0x1c] Set DATA0 PID
    $1d constant OTG_SD1PID                     \ [0x1d] Set DATA1 PID
    $1e constant OTG_EPDIS                      \ [0x1e] Endpoint disable
    $1f constant OTG_EPENA                      \ [0x1f] Endpoint enable
  [then]


  [ifdef] OTG_OTG_DIEPCTL5_ALTERNATE_DEF
    \
    \ @brief OTG device IN endpoint 5 control register [alternate]
    \ Address offset: 0x9A0
    \ Reset value: 0x00000000
    \
    $00 constant OTG_MPSIZ                      \ [0x00 : 11] Maximum packet size
    $0f constant OTG_USBAEP                     \ [0x0f] USB active endpoint
    $10 constant OTG_EONUM                      \ [0x10] Even/odd frame
    $11 constant OTG_NAKSTS                     \ [0x11] NAK status
    $12 constant OTG_EPTYP                      \ [0x12 : 2] Endpoint type
    $15 constant OTG_STALL                      \ [0x15] STALL handshake
    $16 constant OTG_TXFNUM                     \ [0x16 : 4] Tx FIFO number
    $1a constant OTG_CNAK                       \ [0x1a] Clear NAK
    $1b constant OTG_SNAK                       \ [0x1b] Set NAK
    $1c constant OTG_SEVNFRM                    \ [0x1c] Set even frame
    $1d constant OTG_SODDFRM                    \ [0x1d] Set odd frame
    $1e constant OTG_EPDIS                      \ [0x1e] Endpoint disable
    $1f constant OTG_EPENA                      \ [0x1f] Endpoint enable
  [then]


  [ifdef] OTG_OTG_DIEPINT5_DEF
    \
    \ @brief OTG device IN endpoint 5 interrupt register
    \ Address offset: 0x9A8
    \ Reset value: 0x00000080
    \
    $00 constant OTG_XFRC                       \ [0x00] Transfer completed interrupt
    $01 constant OTG_EPDISD                     \ [0x01] Endpoint disabled interrupt
    $02 constant OTG_AHBERR                     \ [0x02] AHB error
    $03 constant OTG_TOC                        \ [0x03] Timeout condition
    $04 constant OTG_ITTXFE                     \ [0x04] IN token received when Tx FIFO is empty
    $05 constant OTG_INEPNM                     \ [0x05] IN token received with EP mismatch
    $06 constant OTG_INEPNE                     \ [0x06] IN endpoint NAK effective
    $07 constant OTG_TXFE                       \ [0x07] Transmit FIFO empty
    $08 constant OTG_TXFIFOUDRN                 \ [0x08] Transmit Fifo Underrun (TxfifoUndrn)
    $0b constant OTG_PKTDRPSTS                  \ [0x0b] Packet dropped status
    $0d constant OTG_NAK                        \ [0x0d] NAK input
  [then]


  [ifdef] OTG_OTG_DIEPTSIZ5_DEF
    \
    \ @brief OTG device IN endpoint 5 transfer size register
    \ Address offset: 0x9B0
    \ Reset value: 0x00000000
    \
    $00 constant OTG_XFRSIZ                     \ [0x00 : 19] Transfer size
    $13 constant OTG_PKTCNT                     \ [0x13 : 10] Packet count
    $1d constant OTG_MCNT                       \ [0x1d : 2] Multi count
  [then]


  [ifdef] OTG_OTG_DIEPDMA5_DEF
    \
    \ @brief OTG device IN endpoint 5 DMA address register
    \ Address offset: 0x9B4
    \ Reset value: 0x00000000
    \
    $00 constant OTG_DMAADDR                    \ [0x00 : 32] DMA Address
  [then]


  [ifdef] OTG_OTG_DTXFSTS5_DEF
    \
    \ @brief OTG device IN endpoint transmit FIFO status register
    \ Address offset: 0x9B8
    \ Reset value: 0x00000200
    \
    $00 constant OTG_INEPTFSAV                  \ [0x00 : 16] IN endpoint Tx FIFO space available
  [then]


  [ifdef] OTG_OTG_DIEPCTL6_DEF
    \
    \ @brief OTG device IN endpoint 6 control register [alternate]
    \ Address offset: 0x9C0
    \ Reset value: 0x00000000
    \
    $00 constant OTG_MPSIZ                      \ [0x00 : 11] Maximum packet size
    $0f constant OTG_USBAEP                     \ [0x0f] USB active endpoint
    $10 constant OTG_DPID                       \ [0x10] Endpoint data PID
    $11 constant OTG_NAKSTS                     \ [0x11] NAK status
    $12 constant OTG_EPTYP                      \ [0x12 : 2] Endpoint type
    $15 constant OTG_STALL                      \ [0x15] STALL handshake
    $16 constant OTG_TXFNUM                     \ [0x16 : 4] Tx FIFO number
    $1a constant OTG_CNAK                       \ [0x1a] Clear NAK
    $1b constant OTG_SNAK                       \ [0x1b] Set NAK
    $1c constant OTG_SD0PID                     \ [0x1c] Set DATA0 PID
    $1d constant OTG_SD1PID                     \ [0x1d] Set DATA1 PID
    $1e constant OTG_EPDIS                      \ [0x1e] Endpoint disable
    $1f constant OTG_EPENA                      \ [0x1f] Endpoint enable
  [then]


  [ifdef] OTG_OTG_DIEPCTL6_ALTERNATE_DEF
    \
    \ @brief OTG device IN endpoint 6 control register [alternate]
    \ Address offset: 0x9C0
    \ Reset value: 0x00000000
    \
    $00 constant OTG_MPSIZ                      \ [0x00 : 11] Maximum packet size
    $0f constant OTG_USBAEP                     \ [0x0f] USB active endpoint
    $10 constant OTG_EONUM                      \ [0x10] Even/odd frame
    $11 constant OTG_NAKSTS                     \ [0x11] NAK status
    $12 constant OTG_EPTYP                      \ [0x12 : 2] Endpoint type
    $15 constant OTG_STALL                      \ [0x15] STALL handshake
    $16 constant OTG_TXFNUM                     \ [0x16 : 4] Tx FIFO number
    $1a constant OTG_CNAK                       \ [0x1a] Clear NAK
    $1b constant OTG_SNAK                       \ [0x1b] Set NAK
    $1c constant OTG_SEVNFRM                    \ [0x1c] Set even frame
    $1d constant OTG_SODDFRM                    \ [0x1d] Set odd frame
    $1e constant OTG_EPDIS                      \ [0x1e] Endpoint disable
    $1f constant OTG_EPENA                      \ [0x1f] Endpoint enable
  [then]


  [ifdef] OTG_OTG_DIEPINT6_DEF
    \
    \ @brief OTG device IN endpoint 6 interrupt register
    \ Address offset: 0x9C8
    \ Reset value: 0x00000080
    \
    $00 constant OTG_XFRC                       \ [0x00] Transfer completed interrupt
    $01 constant OTG_EPDISD                     \ [0x01] Endpoint disabled interrupt
    $02 constant OTG_AHBERR                     \ [0x02] AHB error
    $03 constant OTG_TOC                        \ [0x03] Timeout condition
    $04 constant OTG_ITTXFE                     \ [0x04] IN token received when Tx FIFO is empty
    $05 constant OTG_INEPNM                     \ [0x05] IN token received with EP mismatch
    $06 constant OTG_INEPNE                     \ [0x06] IN endpoint NAK effective
    $07 constant OTG_TXFE                       \ [0x07] Transmit FIFO empty
    $08 constant OTG_TXFIFOUDRN                 \ [0x08] Transmit Fifo Underrun (TxfifoUndrn)
    $0b constant OTG_PKTDRPSTS                  \ [0x0b] Packet dropped status
    $0d constant OTG_NAK                        \ [0x0d] NAK input
  [then]


  [ifdef] OTG_OTG_DIEPTSIZ6_DEF
    \
    \ @brief OTG device IN endpoint 6 transfer size register
    \ Address offset: 0x9D0
    \ Reset value: 0x00000000
    \
    $00 constant OTG_XFRSIZ                     \ [0x00 : 19] Transfer size
    $13 constant OTG_PKTCNT                     \ [0x13 : 10] Packet count
    $1d constant OTG_MCNT                       \ [0x1d : 2] Multi count
  [then]


  [ifdef] OTG_OTG_DIEPDMA6_DEF
    \
    \ @brief OTG device IN endpoint 6 DMA address register
    \ Address offset: 0x9D4
    \ Reset value: 0x00000000
    \
    $00 constant OTG_DMAADDR                    \ [0x00 : 32] DMA Address
  [then]


  [ifdef] OTG_OTG_DTXFSTS6_DEF
    \
    \ @brief OTG device IN endpoint transmit FIFO status register
    \ Address offset: 0x9D8
    \ Reset value: 0x00000200
    \
    $00 constant OTG_INEPTFSAV                  \ [0x00 : 16] IN endpoint Tx FIFO space available
  [then]


  [ifdef] OTG_OTG_DIEPCTL7_DEF
    \
    \ @brief OTG device IN endpoint 7 control register [alternate]
    \ Address offset: 0x9E0
    \ Reset value: 0x00000000
    \
    $00 constant OTG_MPSIZ                      \ [0x00 : 11] Maximum packet size
    $0f constant OTG_USBAEP                     \ [0x0f] USB active endpoint
    $10 constant OTG_DPID                       \ [0x10] Endpoint data PID
    $11 constant OTG_NAKSTS                     \ [0x11] NAK status
    $12 constant OTG_EPTYP                      \ [0x12 : 2] Endpoint type
    $15 constant OTG_STALL                      \ [0x15] STALL handshake
    $16 constant OTG_TXFNUM                     \ [0x16 : 4] Tx FIFO number
    $1a constant OTG_CNAK                       \ [0x1a] Clear NAK
    $1b constant OTG_SNAK                       \ [0x1b] Set NAK
    $1c constant OTG_SD0PID                     \ [0x1c] Set DATA0 PID
    $1d constant OTG_SD1PID                     \ [0x1d] Set DATA1 PID
    $1e constant OTG_EPDIS                      \ [0x1e] Endpoint disable
    $1f constant OTG_EPENA                      \ [0x1f] Endpoint enable
  [then]


  [ifdef] OTG_OTG_DIEPCTL7_ALTERNATE_DEF
    \
    \ @brief OTG device IN endpoint 7 control register [alternate]
    \ Address offset: 0x9E0
    \ Reset value: 0x00000000
    \
    $00 constant OTG_MPSIZ                      \ [0x00 : 11] Maximum packet size
    $0f constant OTG_USBAEP                     \ [0x0f] USB active endpoint
    $10 constant OTG_EONUM                      \ [0x10] Even/odd frame
    $11 constant OTG_NAKSTS                     \ [0x11] NAK status
    $12 constant OTG_EPTYP                      \ [0x12 : 2] Endpoint type
    $15 constant OTG_STALL                      \ [0x15] STALL handshake
    $16 constant OTG_TXFNUM                     \ [0x16 : 4] Tx FIFO number
    $1a constant OTG_CNAK                       \ [0x1a] Clear NAK
    $1b constant OTG_SNAK                       \ [0x1b] Set NAK
    $1c constant OTG_SEVNFRM                    \ [0x1c] Set even frame
    $1d constant OTG_SODDFRM                    \ [0x1d] Set odd frame
    $1e constant OTG_EPDIS                      \ [0x1e] Endpoint disable
    $1f constant OTG_EPENA                      \ [0x1f] Endpoint enable
  [then]


  [ifdef] OTG_OTG_DIEPINT7_DEF
    \
    \ @brief OTG device IN endpoint 7 interrupt register
    \ Address offset: 0x9E8
    \ Reset value: 0x00000080
    \
    $00 constant OTG_XFRC                       \ [0x00] Transfer completed interrupt
    $01 constant OTG_EPDISD                     \ [0x01] Endpoint disabled interrupt
    $02 constant OTG_AHBERR                     \ [0x02] AHB error
    $03 constant OTG_TOC                        \ [0x03] Timeout condition
    $04 constant OTG_ITTXFE                     \ [0x04] IN token received when Tx FIFO is empty
    $05 constant OTG_INEPNM                     \ [0x05] IN token received with EP mismatch
    $06 constant OTG_INEPNE                     \ [0x06] IN endpoint NAK effective
    $07 constant OTG_TXFE                       \ [0x07] Transmit FIFO empty
    $08 constant OTG_TXFIFOUDRN                 \ [0x08] Transmit Fifo Underrun (TxfifoUndrn)
    $0b constant OTG_PKTDRPSTS                  \ [0x0b] Packet dropped status
    $0d constant OTG_NAK                        \ [0x0d] NAK input
  [then]


  [ifdef] OTG_OTG_DIEPTSIZ7_DEF
    \
    \ @brief OTG device IN endpoint 7 transfer size register
    \ Address offset: 0x9F0
    \ Reset value: 0x00000000
    \
    $00 constant OTG_XFRSIZ                     \ [0x00 : 19] Transfer size
    $13 constant OTG_PKTCNT                     \ [0x13 : 10] Packet count
    $1d constant OTG_MCNT                       \ [0x1d : 2] Multi count
  [then]


  [ifdef] OTG_OTG_DIEPDMA7_DEF
    \
    \ @brief OTG device IN endpoint 7 DMA address register
    \ Address offset: 0x9F4
    \ Reset value: 0x00000000
    \
    $00 constant OTG_DMAADDR                    \ [0x00 : 32] DMA Address
  [then]


  [ifdef] OTG_OTG_DTXFSTS7_DEF
    \
    \ @brief OTG device IN endpoint transmit FIFO status register
    \ Address offset: 0x9F8
    \ Reset value: 0x00000200
    \
    $00 constant OTG_INEPTFSAV                  \ [0x00 : 16] IN endpoint Tx FIFO space available
  [then]


  [ifdef] OTG_OTG_DIEPCTL8_DEF
    \
    \ @brief OTG device IN endpoint 8 control register [alternate]
    \ Address offset: 0xA00
    \ Reset value: 0x00000000
    \
    $00 constant OTG_MPSIZ                      \ [0x00 : 11] Maximum packet size
    $0f constant OTG_USBAEP                     \ [0x0f] USB active endpoint
    $10 constant OTG_DPID                       \ [0x10] Endpoint data PID
    $11 constant OTG_NAKSTS                     \ [0x11] NAK status
    $12 constant OTG_EPTYP                      \ [0x12 : 2] Endpoint type
    $15 constant OTG_STALL                      \ [0x15] STALL handshake
    $16 constant OTG_TXFNUM                     \ [0x16 : 4] Tx FIFO number
    $1a constant OTG_CNAK                       \ [0x1a] Clear NAK
    $1b constant OTG_SNAK                       \ [0x1b] Set NAK
    $1c constant OTG_SD0PID                     \ [0x1c] Set DATA0 PID
    $1d constant OTG_SD1PID                     \ [0x1d] Set DATA1 PID
    $1e constant OTG_EPDIS                      \ [0x1e] Endpoint disable
    $1f constant OTG_EPENA                      \ [0x1f] Endpoint enable
  [then]


  [ifdef] OTG_OTG_DIEPCTL8_ALTERNATE_DEF
    \
    \ @brief OTG device IN endpoint 8 control register [alternate]
    \ Address offset: 0xA00
    \ Reset value: 0x00000000
    \
    $00 constant OTG_MPSIZ                      \ [0x00 : 11] Maximum packet size
    $0f constant OTG_USBAEP                     \ [0x0f] USB active endpoint
    $10 constant OTG_EONUM                      \ [0x10] Even/odd frame
    $11 constant OTG_NAKSTS                     \ [0x11] NAK status
    $12 constant OTG_EPTYP                      \ [0x12 : 2] Endpoint type
    $15 constant OTG_STALL                      \ [0x15] STALL handshake
    $16 constant OTG_TXFNUM                     \ [0x16 : 4] Tx FIFO number
    $1a constant OTG_CNAK                       \ [0x1a] Clear NAK
    $1b constant OTG_SNAK                       \ [0x1b] Set NAK
    $1c constant OTG_SEVNFRM                    \ [0x1c] Set even frame
    $1d constant OTG_SODDFRM                    \ [0x1d] Set odd frame
    $1e constant OTG_EPDIS                      \ [0x1e] Endpoint disable
    $1f constant OTG_EPENA                      \ [0x1f] Endpoint enable
  [then]


  [ifdef] OTG_OTG_DIEPINT8_DEF
    \
    \ @brief OTG device IN endpoint 8 interrupt register
    \ Address offset: 0xA08
    \ Reset value: 0x00000080
    \
    $00 constant OTG_XFRC                       \ [0x00] Transfer completed interrupt
    $01 constant OTG_EPDISD                     \ [0x01] Endpoint disabled interrupt
    $02 constant OTG_AHBERR                     \ [0x02] AHB error
    $03 constant OTG_TOC                        \ [0x03] Timeout condition
    $04 constant OTG_ITTXFE                     \ [0x04] IN token received when Tx FIFO is empty
    $05 constant OTG_INEPNM                     \ [0x05] IN token received with EP mismatch
    $06 constant OTG_INEPNE                     \ [0x06] IN endpoint NAK effective
    $07 constant OTG_TXFE                       \ [0x07] Transmit FIFO empty
    $08 constant OTG_TXFIFOUDRN                 \ [0x08] Transmit Fifo Underrun (TxfifoUndrn)
    $0b constant OTG_PKTDRPSTS                  \ [0x0b] Packet dropped status
    $0d constant OTG_NAK                        \ [0x0d] NAK input
  [then]


  [ifdef] OTG_OTG_DIEPTSIZ8_DEF
    \
    \ @brief OTG device IN endpoint 8 transfer size register
    \ Address offset: 0xA10
    \ Reset value: 0x00000000
    \
    $00 constant OTG_XFRSIZ                     \ [0x00 : 19] Transfer size
    $13 constant OTG_PKTCNT                     \ [0x13 : 10] Packet count
    $1d constant OTG_MCNT                       \ [0x1d : 2] Multi count
  [then]


  [ifdef] OTG_OTG_DIEPDMA8_DEF
    \
    \ @brief OTG device IN endpoint 8 DMA address register
    \ Address offset: 0xA14
    \ Reset value: 0x00000000
    \
    $00 constant OTG_DMAADDR                    \ [0x00 : 32] DMA Address
  [then]


  [ifdef] OTG_OTG_DTXFSTS8_DEF
    \
    \ @brief OTG device IN endpoint transmit FIFO status register
    \ Address offset: 0xA18
    \ Reset value: 0x00000200
    \
    $00 constant OTG_INEPTFSAV                  \ [0x00 : 16] IN endpoint Tx FIFO space available
  [then]


  [ifdef] OTG_OTG_DOEPCTL0_DEF
    \
    \ @brief OTG device control OUT endpoint 0 control register
    \ Address offset: 0xB00
    \ Reset value: 0x00008000
    \
    $00 constant OTG_MPSIZ                      \ [0x00 : 2] Maximum packet size
    $0f constant OTG_USBAEP                     \ [0x0f] USB active endpoint
    $11 constant OTG_NAKSTS                     \ [0x11] NAK status
    $12 constant OTG_EPTYP                      \ [0x12 : 2] Endpoint type
    $14 constant OTG_SNPM                       \ [0x14] Snoop mode
    $15 constant OTG_STALL                      \ [0x15] STALL handshake
    $1a constant OTG_CNAK                       \ [0x1a] Clear NAK
    $1b constant OTG_SNAK                       \ [0x1b] Set NAK
    $1e constant OTG_EPDIS                      \ [0x1e] Endpoint disable
    $1f constant OTG_EPENA                      \ [0x1f] Endpoint enable
  [then]


  [ifdef] OTG_OTG_DOEPINT0_DEF
    \
    \ @brief OTG device OUT endpoint 0 interrupt register
    \ Address offset: 0xB08
    \ Reset value: 0x00000080
    \
    $00 constant OTG_XFRC                       \ [0x00] Transfer completed interrupt
    $01 constant OTG_EPDISD                     \ [0x01] Endpoint disabled interrupt
    $02 constant OTG_AHBERR                     \ [0x02] AHB error
    $03 constant OTG_STUP                       \ [0x03] SETUP phase done
    $04 constant OTG_OTEPDIS                    \ [0x04] OUT token received when endpoint disabled
    $05 constant OTG_STSPHSRX                   \ [0x05] Status phase received for control write
    $06 constant OTG_B2BSTUP                    \ [0x06] Back-to-back SETUP packets received
    $08 constant OTG_OUTPKTERR                  \ [0x08] OUT packet error
    $0c constant OTG_BERR                       \ [0x0c] Babble error interrupt
    $0d constant OTG_NAK                        \ [0x0d] NAK input
    $0e constant OTG_NYET                       \ [0x0e] NYET interrupt
    $0f constant OTG_STPKTRX                    \ [0x0f] Setup packet received
  [then]


  [ifdef] OTG_OTG_DOEPTSIZ0_DEF
    \
    \ @brief OTG device OUT endpoint 0 transfer size register
    \ Address offset: 0xB10
    \ Reset value: 0x00000000
    \
    $00 constant OTG_XFRSIZ                     \ [0x00 : 7] Transfer size
    $13 constant OTG_PKTCNT                     \ [0x13] Packet count
    $1d constant OTG_STUPCNT                    \ [0x1d : 2] SETUP packet count
  [then]


  [ifdef] OTG_OTG_DOEPDMA0_DEF
    \
    \ @brief OTG device OUT endpoint 0 DMA address register
    \ Address offset: 0xB14
    \ Reset value: 0x00000000
    \
    $00 constant OTG_DMAADDR                    \ [0x00 : 32] DMA Address
  [then]


  [ifdef] OTG_OTG_DOEPCTL1_DEF
    \
    \ @brief OTG device OUT endpoint 1 control register [alternate]
    \ Address offset: 0xB20
    \ Reset value: 0x00000000
    \
    $00 constant OTG_MPSIZ                      \ [0x00 : 11] Maximum packet size
    $0f constant OTG_USBAEP                     \ [0x0f] USB active endpoint
    $10 constant OTG_DPID                       \ [0x10] Endpoint data PID
    $11 constant OTG_NAKSTS                     \ [0x11] NAK status
    $12 constant OTG_EPTYP                      \ [0x12 : 2] Endpoint type
    $14 constant OTG_SNPM                       \ [0x14] Snoop mode
    $15 constant OTG_STALL                      \ [0x15] STALL handshake
    $1a constant OTG_CNAK                       \ [0x1a] Clear NAK
    $1b constant OTG_SNAK                       \ [0x1b] Set NAK
    $1c constant OTG_SD0PID                     \ [0x1c] Set DATA0 PID
    $1d constant OTG_SD1PID                     \ [0x1d] Set DATA1 PID
    $1e constant OTG_EPDIS                      \ [0x1e] Endpoint disable
    $1f constant OTG_EPENA                      \ [0x1f] Endpoint enable
  [then]


  [ifdef] OTG_OTG_DOEPCTL1_ALTERNATE_DEF
    \
    \ @brief OTG device OUT endpoint 1 control register [alternate]
    \ Address offset: 0xB20
    \ Reset value: 0x00000000
    \
    $00 constant OTG_MPSIZ                      \ [0x00 : 11] Maximum packet size
    $0f constant OTG_USBAEP                     \ [0x0f] USB active endpoint
    $10 constant OTG_EONUM                      \ [0x10] Even/odd frame
    $11 constant OTG_NAKSTS                     \ [0x11] NAK status
    $12 constant OTG_EPTYP                      \ [0x12 : 2] Endpoint type
    $14 constant OTG_SNPM                       \ [0x14] Snoop mode
    $15 constant OTG_STALL                      \ [0x15] STALL handshake
    $1a constant OTG_CNAK                       \ [0x1a] Clear NAK
    $1b constant OTG_SNAK                       \ [0x1b] Set NAK
    $1c constant OTG_SEVNFRM                    \ [0x1c] Set even frame
    $1d constant OTG_SODDFRM                    \ [0x1d] Set odd frame
    $1e constant OTG_EPDIS                      \ [0x1e] Endpoint disable
    $1f constant OTG_EPENA                      \ [0x1f] Endpoint enable
  [then]


  [ifdef] OTG_OTG_DOEPINT1_DEF
    \
    \ @brief OTG device OUT endpoint 1 interrupt register
    \ Address offset: 0xB28
    \ Reset value: 0x00000080
    \
    $00 constant OTG_XFRC                       \ [0x00] Transfer completed interrupt
    $01 constant OTG_EPDISD                     \ [0x01] Endpoint disabled interrupt
    $02 constant OTG_AHBERR                     \ [0x02] AHB error
    $03 constant OTG_STUP                       \ [0x03] SETUP phase done
    $04 constant OTG_OTEPDIS                    \ [0x04] OUT token received when endpoint disabled
    $05 constant OTG_STSPHSRX                   \ [0x05] Status phase received for control write
    $06 constant OTG_B2BSTUP                    \ [0x06] Back-to-back SETUP packets received
    $08 constant OTG_OUTPKTERR                  \ [0x08] OUT packet error
    $0c constant OTG_BERR                       \ [0x0c] Babble error interrupt
    $0d constant OTG_NAK                        \ [0x0d] NAK input
    $0e constant OTG_NYET                       \ [0x0e] NYET interrupt
    $0f constant OTG_STPKTRX                    \ [0x0f] Setup packet received
  [then]


  [ifdef] OTG_OTG_DOEPTSIZ1_DEF
    \
    \ @brief OTG device OUT endpoint 1 transfer size register
    \ Address offset: 0xB30
    \ Reset value: 0x00000000
    \
    $00 constant OTG_XFRSIZ                     \ [0x00 : 19] Transfer size
    $13 constant OTG_PKTCNT                     \ [0x13 : 10] Packet count
    $1d constant OTG_RXDPID                     \ [0x1d : 2] Received data PID
  [then]


  [ifdef] OTG_OTG_DOEPDMA1_DEF
    \
    \ @brief OTG device OUT endpoint 1 DMA address register
    \ Address offset: 0xB34
    \ Reset value: 0x00000000
    \
    $00 constant OTG_DMAADDR                    \ [0x00 : 32] DMA Address
  [then]


  [ifdef] OTG_OTG_DOEPCTL2_DEF
    \
    \ @brief OTG device OUT endpoint 2 control register [alternate]
    \ Address offset: 0xB40
    \ Reset value: 0x00000000
    \
    $00 constant OTG_MPSIZ                      \ [0x00 : 11] Maximum packet size
    $0f constant OTG_USBAEP                     \ [0x0f] USB active endpoint
    $10 constant OTG_DPID                       \ [0x10] Endpoint data PID
    $11 constant OTG_NAKSTS                     \ [0x11] NAK status
    $12 constant OTG_EPTYP                      \ [0x12 : 2] Endpoint type
    $14 constant OTG_SNPM                       \ [0x14] Snoop mode
    $15 constant OTG_STALL                      \ [0x15] STALL handshake
    $1a constant OTG_CNAK                       \ [0x1a] Clear NAK
    $1b constant OTG_SNAK                       \ [0x1b] Set NAK
    $1c constant OTG_SD0PID                     \ [0x1c] Set DATA0 PID
    $1d constant OTG_SD1PID                     \ [0x1d] Set DATA1 PID
    $1e constant OTG_EPDIS                      \ [0x1e] Endpoint disable
    $1f constant OTG_EPENA                      \ [0x1f] Endpoint enable
  [then]


  [ifdef] OTG_OTG_DOEPCTL2_ALTERNATE_DEF
    \
    \ @brief OTG device OUT endpoint 2 control register [alternate]
    \ Address offset: 0xB40
    \ Reset value: 0x00000000
    \
    $00 constant OTG_MPSIZ                      \ [0x00 : 11] Maximum packet size
    $0f constant OTG_USBAEP                     \ [0x0f] USB active endpoint
    $10 constant OTG_EONUM                      \ [0x10] Even/odd frame
    $11 constant OTG_NAKSTS                     \ [0x11] NAK status
    $12 constant OTG_EPTYP                      \ [0x12 : 2] Endpoint type
    $14 constant OTG_SNPM                       \ [0x14] Snoop mode
    $15 constant OTG_STALL                      \ [0x15] STALL handshake
    $1a constant OTG_CNAK                       \ [0x1a] Clear NAK
    $1b constant OTG_SNAK                       \ [0x1b] Set NAK
    $1c constant OTG_SEVNFRM                    \ [0x1c] Set even frame
    $1d constant OTG_SODDFRM                    \ [0x1d] Set odd frame
    $1e constant OTG_EPDIS                      \ [0x1e] Endpoint disable
    $1f constant OTG_EPENA                      \ [0x1f] Endpoint enable
  [then]


  [ifdef] OTG_OTG_DOEPINT2_DEF
    \
    \ @brief OTG device OUT endpoint 2 interrupt register
    \ Address offset: 0xB48
    \ Reset value: 0x00000080
    \
    $00 constant OTG_XFRC                       \ [0x00] Transfer completed interrupt
    $01 constant OTG_EPDISD                     \ [0x01] Endpoint disabled interrupt
    $02 constant OTG_AHBERR                     \ [0x02] AHB error
    $03 constant OTG_STUP                       \ [0x03] SETUP phase done
    $04 constant OTG_OTEPDIS                    \ [0x04] OUT token received when endpoint disabled
    $05 constant OTG_STSPHSRX                   \ [0x05] Status phase received for control write
    $06 constant OTG_B2BSTUP                    \ [0x06] Back-to-back SETUP packets received
    $08 constant OTG_OUTPKTERR                  \ [0x08] OUT packet error
    $0c constant OTG_BERR                       \ [0x0c] Babble error interrupt
    $0d constant OTG_NAK                        \ [0x0d] NAK input
    $0e constant OTG_NYET                       \ [0x0e] NYET interrupt
    $0f constant OTG_STPKTRX                    \ [0x0f] Setup packet received
  [then]


  [ifdef] OTG_OTG_DOEPTSIZ2_DEF
    \
    \ @brief OTG device OUT endpoint 2 transfer size register
    \ Address offset: 0xB50
    \ Reset value: 0x00000000
    \
    $00 constant OTG_XFRSIZ                     \ [0x00 : 19] Transfer size
    $13 constant OTG_PKTCNT                     \ [0x13 : 10] Packet count
    $1d constant OTG_RXDPID                     \ [0x1d : 2] Received data PID
  [then]


  [ifdef] OTG_OTG_DOEPDMA2_DEF
    \
    \ @brief OTG device OUT endpoint 2 DMA address register
    \ Address offset: 0xB54
    \ Reset value: 0x00000000
    \
    $00 constant OTG_DMAADDR                    \ [0x00 : 32] DMA Address
  [then]


  [ifdef] OTG_OTG_DOEPCTL3_DEF
    \
    \ @brief OTG device OUT endpoint 3 control register [alternate]
    \ Address offset: 0xB60
    \ Reset value: 0x00000000
    \
    $00 constant OTG_MPSIZ                      \ [0x00 : 11] Maximum packet size
    $0f constant OTG_USBAEP                     \ [0x0f] USB active endpoint
    $10 constant OTG_DPID                       \ [0x10] Endpoint data PID
    $11 constant OTG_NAKSTS                     \ [0x11] NAK status
    $12 constant OTG_EPTYP                      \ [0x12 : 2] Endpoint type
    $14 constant OTG_SNPM                       \ [0x14] Snoop mode
    $15 constant OTG_STALL                      \ [0x15] STALL handshake
    $1a constant OTG_CNAK                       \ [0x1a] Clear NAK
    $1b constant OTG_SNAK                       \ [0x1b] Set NAK
    $1c constant OTG_SD0PID                     \ [0x1c] Set DATA0 PID
    $1d constant OTG_SD1PID                     \ [0x1d] Set DATA1 PID
    $1e constant OTG_EPDIS                      \ [0x1e] Endpoint disable
    $1f constant OTG_EPENA                      \ [0x1f] Endpoint enable
  [then]


  [ifdef] OTG_OTG_DOEPCTL3_ALTERNATE_DEF
    \
    \ @brief OTG device OUT endpoint 3 control register [alternate]
    \ Address offset: 0xB60
    \ Reset value: 0x00000000
    \
    $00 constant OTG_MPSIZ                      \ [0x00 : 11] Maximum packet size
    $0f constant OTG_USBAEP                     \ [0x0f] USB active endpoint
    $10 constant OTG_EONUM                      \ [0x10] Even/odd frame
    $11 constant OTG_NAKSTS                     \ [0x11] NAK status
    $12 constant OTG_EPTYP                      \ [0x12 : 2] Endpoint type
    $14 constant OTG_SNPM                       \ [0x14] Snoop mode
    $15 constant OTG_STALL                      \ [0x15] STALL handshake
    $1a constant OTG_CNAK                       \ [0x1a] Clear NAK
    $1b constant OTG_SNAK                       \ [0x1b] Set NAK
    $1c constant OTG_SEVNFRM                    \ [0x1c] Set even frame
    $1d constant OTG_SODDFRM                    \ [0x1d] Set odd frame
    $1e constant OTG_EPDIS                      \ [0x1e] Endpoint disable
    $1f constant OTG_EPENA                      \ [0x1f] Endpoint enable
  [then]


  [ifdef] OTG_OTG_DOEPINT3_DEF
    \
    \ @brief OTG device OUT endpoint 3 interrupt register
    \ Address offset: 0xB68
    \ Reset value: 0x00000080
    \
    $00 constant OTG_XFRC                       \ [0x00] Transfer completed interrupt
    $01 constant OTG_EPDISD                     \ [0x01] Endpoint disabled interrupt
    $02 constant OTG_AHBERR                     \ [0x02] AHB error
    $03 constant OTG_STUP                       \ [0x03] SETUP phase done
    $04 constant OTG_OTEPDIS                    \ [0x04] OUT token received when endpoint disabled
    $05 constant OTG_STSPHSRX                   \ [0x05] Status phase received for control write
    $06 constant OTG_B2BSTUP                    \ [0x06] Back-to-back SETUP packets received
    $08 constant OTG_OUTPKTERR                  \ [0x08] OUT packet error
    $0c constant OTG_BERR                       \ [0x0c] Babble error interrupt
    $0d constant OTG_NAK                        \ [0x0d] NAK input
    $0e constant OTG_NYET                       \ [0x0e] NYET interrupt
    $0f constant OTG_STPKTRX                    \ [0x0f] Setup packet received
  [then]


  [ifdef] OTG_OTG_DOEPTSIZ3_DEF
    \
    \ @brief OTG device OUT endpoint 3 transfer size register
    \ Address offset: 0xB70
    \ Reset value: 0x00000000
    \
    $00 constant OTG_XFRSIZ                     \ [0x00 : 19] Transfer size
    $13 constant OTG_PKTCNT                     \ [0x13 : 10] Packet count
    $1d constant OTG_RXDPID                     \ [0x1d : 2] Received data PID
  [then]


  [ifdef] OTG_OTG_DOEPDMA3_DEF
    \
    \ @brief OTG device OUT endpoint 3 DMA address register
    \ Address offset: 0xB74
    \ Reset value: 0x00000000
    \
    $00 constant OTG_DMAADDR                    \ [0x00 : 32] DMA Address
  [then]


  [ifdef] OTG_OTG_DOEPCTL4_DEF
    \
    \ @brief OTG device OUT endpoint 4 control register [alternate]
    \ Address offset: 0xB80
    \ Reset value: 0x00000000
    \
    $00 constant OTG_MPSIZ                      \ [0x00 : 11] Maximum packet size
    $0f constant OTG_USBAEP                     \ [0x0f] USB active endpoint
    $10 constant OTG_DPID                       \ [0x10] Endpoint data PID
    $11 constant OTG_NAKSTS                     \ [0x11] NAK status
    $12 constant OTG_EPTYP                      \ [0x12 : 2] Endpoint type
    $14 constant OTG_SNPM                       \ [0x14] Snoop mode
    $15 constant OTG_STALL                      \ [0x15] STALL handshake
    $1a constant OTG_CNAK                       \ [0x1a] Clear NAK
    $1b constant OTG_SNAK                       \ [0x1b] Set NAK
    $1c constant OTG_SD0PID                     \ [0x1c] Set DATA0 PID
    $1d constant OTG_SD1PID                     \ [0x1d] Set DATA1 PID
    $1e constant OTG_EPDIS                      \ [0x1e] Endpoint disable
    $1f constant OTG_EPENA                      \ [0x1f] Endpoint enable
  [then]


  [ifdef] OTG_OTG_DOEPCTL4_ALTERNATE_DEF
    \
    \ @brief OTG device OUT endpoint 4 control register [alternate]
    \ Address offset: 0xB80
    \ Reset value: 0x00000000
    \
    $00 constant OTG_MPSIZ                      \ [0x00 : 11] Maximum packet size
    $0f constant OTG_USBAEP                     \ [0x0f] USB active endpoint
    $10 constant OTG_EONUM                      \ [0x10] Even/odd frame
    $11 constant OTG_NAKSTS                     \ [0x11] NAK status
    $12 constant OTG_EPTYP                      \ [0x12 : 2] Endpoint type
    $14 constant OTG_SNPM                       \ [0x14] Snoop mode
    $15 constant OTG_STALL                      \ [0x15] STALL handshake
    $1a constant OTG_CNAK                       \ [0x1a] Clear NAK
    $1b constant OTG_SNAK                       \ [0x1b] Set NAK
    $1c constant OTG_SEVNFRM                    \ [0x1c] Set even frame
    $1d constant OTG_SODDFRM                    \ [0x1d] Set odd frame
    $1e constant OTG_EPDIS                      \ [0x1e] Endpoint disable
    $1f constant OTG_EPENA                      \ [0x1f] Endpoint enable
  [then]


  [ifdef] OTG_OTG_DOEPINT4_DEF
    \
    \ @brief OTG device OUT endpoint 4 interrupt register
    \ Address offset: 0xB88
    \ Reset value: 0x00000080
    \
    $00 constant OTG_XFRC                       \ [0x00] Transfer completed interrupt
    $01 constant OTG_EPDISD                     \ [0x01] Endpoint disabled interrupt
    $02 constant OTG_AHBERR                     \ [0x02] AHB error
    $03 constant OTG_STUP                       \ [0x03] SETUP phase done
    $04 constant OTG_OTEPDIS                    \ [0x04] OUT token received when endpoint disabled
    $05 constant OTG_STSPHSRX                   \ [0x05] Status phase received for control write
    $06 constant OTG_B2BSTUP                    \ [0x06] Back-to-back SETUP packets received
    $08 constant OTG_OUTPKTERR                  \ [0x08] OUT packet error
    $0c constant OTG_BERR                       \ [0x0c] Babble error interrupt
    $0d constant OTG_NAK                        \ [0x0d] NAK input
    $0e constant OTG_NYET                       \ [0x0e] NYET interrupt
    $0f constant OTG_STPKTRX                    \ [0x0f] Setup packet received
  [then]


  [ifdef] OTG_OTG_DOEPTSIZ4_DEF
    \
    \ @brief OTG device OUT endpoint 4 transfer size register
    \ Address offset: 0xB90
    \ Reset value: 0x00000000
    \
    $00 constant OTG_XFRSIZ                     \ [0x00 : 19] Transfer size
    $13 constant OTG_PKTCNT                     \ [0x13 : 10] Packet count
    $1d constant OTG_RXDPID                     \ [0x1d : 2] Received data PID
  [then]


  [ifdef] OTG_OTG_DOEPDMA4_DEF
    \
    \ @brief OTG device OUT endpoint 4 DMA address register
    \ Address offset: 0xB94
    \ Reset value: 0x00000000
    \
    $00 constant OTG_DMAADDR                    \ [0x00 : 32] DMA Address
  [then]


  [ifdef] OTG_OTG_DOEPCTL5_DEF
    \
    \ @brief OTG device OUT endpoint 5 control register [alternate]
    \ Address offset: 0xBA0
    \ Reset value: 0x00000000
    \
    $00 constant OTG_MPSIZ                      \ [0x00 : 11] Maximum packet size
    $0f constant OTG_USBAEP                     \ [0x0f] USB active endpoint
    $10 constant OTG_DPID                       \ [0x10] Endpoint data PID
    $11 constant OTG_NAKSTS                     \ [0x11] NAK status
    $12 constant OTG_EPTYP                      \ [0x12 : 2] Endpoint type
    $14 constant OTG_SNPM                       \ [0x14] Snoop mode
    $15 constant OTG_STALL                      \ [0x15] STALL handshake
    $1a constant OTG_CNAK                       \ [0x1a] Clear NAK
    $1b constant OTG_SNAK                       \ [0x1b] Set NAK
    $1c constant OTG_SD0PID                     \ [0x1c] Set DATA0 PID
    $1d constant OTG_SD1PID                     \ [0x1d] Set DATA1 PID
    $1e constant OTG_EPDIS                      \ [0x1e] Endpoint disable
    $1f constant OTG_EPENA                      \ [0x1f] Endpoint enable
  [then]


  [ifdef] OTG_OTG_DOEPCTL5_ALTERNATE_DEF
    \
    \ @brief OTG device OUT endpoint 5 control register [alternate]
    \ Address offset: 0xBA0
    \ Reset value: 0x00000000
    \
    $00 constant OTG_MPSIZ                      \ [0x00 : 11] Maximum packet size
    $0f constant OTG_USBAEP                     \ [0x0f] USB active endpoint
    $10 constant OTG_EONUM                      \ [0x10] Even/odd frame
    $11 constant OTG_NAKSTS                     \ [0x11] NAK status
    $12 constant OTG_EPTYP                      \ [0x12 : 2] Endpoint type
    $14 constant OTG_SNPM                       \ [0x14] Snoop mode
    $15 constant OTG_STALL                      \ [0x15] STALL handshake
    $1a constant OTG_CNAK                       \ [0x1a] Clear NAK
    $1b constant OTG_SNAK                       \ [0x1b] Set NAK
    $1c constant OTG_SEVNFRM                    \ [0x1c] Set even frame
    $1d constant OTG_SODDFRM                    \ [0x1d] Set odd frame
    $1e constant OTG_EPDIS                      \ [0x1e] Endpoint disable
    $1f constant OTG_EPENA                      \ [0x1f] Endpoint enable
  [then]


  [ifdef] OTG_OTG_DOEPINT5_DEF
    \
    \ @brief OTG device OUT endpoint 5 interrupt register
    \ Address offset: 0xBA8
    \ Reset value: 0x00000080
    \
    $00 constant OTG_XFRC                       \ [0x00] Transfer completed interrupt
    $01 constant OTG_EPDISD                     \ [0x01] Endpoint disabled interrupt
    $02 constant OTG_AHBERR                     \ [0x02] AHB error
    $03 constant OTG_STUP                       \ [0x03] SETUP phase done
    $04 constant OTG_OTEPDIS                    \ [0x04] OUT token received when endpoint disabled
    $05 constant OTG_STSPHSRX                   \ [0x05] Status phase received for control write
    $06 constant OTG_B2BSTUP                    \ [0x06] Back-to-back SETUP packets received
    $08 constant OTG_OUTPKTERR                  \ [0x08] OUT packet error
    $0c constant OTG_BERR                       \ [0x0c] Babble error interrupt
    $0d constant OTG_NAK                        \ [0x0d] NAK input
    $0e constant OTG_NYET                       \ [0x0e] NYET interrupt
    $0f constant OTG_STPKTRX                    \ [0x0f] Setup packet received
  [then]


  [ifdef] OTG_OTG_DOEPTSIZ5_DEF
    \
    \ @brief OTG device OUT endpoint 5 transfer size register
    \ Address offset: 0xBB0
    \ Reset value: 0x00000000
    \
    $00 constant OTG_XFRSIZ                     \ [0x00 : 19] Transfer size
    $13 constant OTG_PKTCNT                     \ [0x13 : 10] Packet count
    $1d constant OTG_RXDPID                     \ [0x1d : 2] Received data PID
  [then]


  [ifdef] OTG_OTG_DOEPDMA5_DEF
    \
    \ @brief OTG device OUT endpoint 5 DMA address register
    \ Address offset: 0xBB4
    \ Reset value: 0x00000000
    \
    $00 constant OTG_DMAADDR                    \ [0x00 : 32] DMA Address
  [then]


  [ifdef] OTG_OTG_DOEPCTL6_DEF
    \
    \ @brief OTG device OUT endpoint 6 control register [alternate]
    \ Address offset: 0xBC0
    \ Reset value: 0x00000000
    \
    $00 constant OTG_MPSIZ                      \ [0x00 : 11] Maximum packet size
    $0f constant OTG_USBAEP                     \ [0x0f] USB active endpoint
    $10 constant OTG_DPID                       \ [0x10] Endpoint data PID
    $11 constant OTG_NAKSTS                     \ [0x11] NAK status
    $12 constant OTG_EPTYP                      \ [0x12 : 2] Endpoint type
    $14 constant OTG_SNPM                       \ [0x14] Snoop mode
    $15 constant OTG_STALL                      \ [0x15] STALL handshake
    $1a constant OTG_CNAK                       \ [0x1a] Clear NAK
    $1b constant OTG_SNAK                       \ [0x1b] Set NAK
    $1c constant OTG_SD0PID                     \ [0x1c] Set DATA0 PID
    $1d constant OTG_SD1PID                     \ [0x1d] Set DATA1 PID
    $1e constant OTG_EPDIS                      \ [0x1e] Endpoint disable
    $1f constant OTG_EPENA                      \ [0x1f] Endpoint enable
  [then]


  [ifdef] OTG_OTG_DOEPCTL6_ALTERNATE_DEF
    \
    \ @brief OTG device OUT endpoint 6 control register [alternate]
    \ Address offset: 0xBC0
    \ Reset value: 0x00000000
    \
    $00 constant OTG_MPSIZ                      \ [0x00 : 11] Maximum packet size
    $0f constant OTG_USBAEP                     \ [0x0f] USB active endpoint
    $10 constant OTG_EONUM                      \ [0x10] Even/odd frame
    $11 constant OTG_NAKSTS                     \ [0x11] NAK status
    $12 constant OTG_EPTYP                      \ [0x12 : 2] Endpoint type
    $14 constant OTG_SNPM                       \ [0x14] Snoop mode
    $15 constant OTG_STALL                      \ [0x15] STALL handshake
    $1a constant OTG_CNAK                       \ [0x1a] Clear NAK
    $1b constant OTG_SNAK                       \ [0x1b] Set NAK
    $1c constant OTG_SEVNFRM                    \ [0x1c] Set even frame
    $1d constant OTG_SODDFRM                    \ [0x1d] Set odd frame
    $1e constant OTG_EPDIS                      \ [0x1e] Endpoint disable
    $1f constant OTG_EPENA                      \ [0x1f] Endpoint enable
  [then]


  [ifdef] OTG_OTG_DOEPINT6_DEF
    \
    \ @brief OTG device OUT endpoint 6 interrupt register
    \ Address offset: 0xBC8
    \ Reset value: 0x00000080
    \
    $00 constant OTG_XFRC                       \ [0x00] Transfer completed interrupt
    $01 constant OTG_EPDISD                     \ [0x01] Endpoint disabled interrupt
    $02 constant OTG_AHBERR                     \ [0x02] AHB error
    $03 constant OTG_STUP                       \ [0x03] SETUP phase done
    $04 constant OTG_OTEPDIS                    \ [0x04] OUT token received when endpoint disabled
    $05 constant OTG_STSPHSRX                   \ [0x05] Status phase received for control write
    $06 constant OTG_B2BSTUP                    \ [0x06] Back-to-back SETUP packets received
    $08 constant OTG_OUTPKTERR                  \ [0x08] OUT packet error
    $0c constant OTG_BERR                       \ [0x0c] Babble error interrupt
    $0d constant OTG_NAK                        \ [0x0d] NAK input
    $0e constant OTG_NYET                       \ [0x0e] NYET interrupt
    $0f constant OTG_STPKTRX                    \ [0x0f] Setup packet received
  [then]


  [ifdef] OTG_OTG_DOEPTSIZ6_DEF
    \
    \ @brief OTG device OUT endpoint 6 transfer size register
    \ Address offset: 0xBD0
    \ Reset value: 0x00000000
    \
    $00 constant OTG_XFRSIZ                     \ [0x00 : 19] Transfer size
    $13 constant OTG_PKTCNT                     \ [0x13 : 10] Packet count
    $1d constant OTG_RXDPID                     \ [0x1d : 2] Received data PID
  [then]


  [ifdef] OTG_OTG_DOEPDMA6_DEF
    \
    \ @brief OTG device OUT endpoint 6 DMA address register
    \ Address offset: 0xBD4
    \ Reset value: 0x00000000
    \
    $00 constant OTG_DMAADDR                    \ [0x00 : 32] DMA Address
  [then]


  [ifdef] OTG_OTG_DOEPCTL7_DEF
    \
    \ @brief OTG device OUT endpoint 7 control register [alternate]
    \ Address offset: 0xBE0
    \ Reset value: 0x00000000
    \
    $00 constant OTG_MPSIZ                      \ [0x00 : 11] Maximum packet size
    $0f constant OTG_USBAEP                     \ [0x0f] USB active endpoint
    $10 constant OTG_DPID                       \ [0x10] Endpoint data PID
    $11 constant OTG_NAKSTS                     \ [0x11] NAK status
    $12 constant OTG_EPTYP                      \ [0x12 : 2] Endpoint type
    $14 constant OTG_SNPM                       \ [0x14] Snoop mode
    $15 constant OTG_STALL                      \ [0x15] STALL handshake
    $1a constant OTG_CNAK                       \ [0x1a] Clear NAK
    $1b constant OTG_SNAK                       \ [0x1b] Set NAK
    $1c constant OTG_SD0PID                     \ [0x1c] Set DATA0 PID
    $1d constant OTG_SD1PID                     \ [0x1d] Set DATA1 PID
    $1e constant OTG_EPDIS                      \ [0x1e] Endpoint disable
    $1f constant OTG_EPENA                      \ [0x1f] Endpoint enable
  [then]


  [ifdef] OTG_OTG_DOEPCTL7_ALTERNATE_DEF
    \
    \ @brief OTG device OUT endpoint 7 control register [alternate]
    \ Address offset: 0xBE0
    \ Reset value: 0x00000000
    \
    $00 constant OTG_MPSIZ                      \ [0x00 : 11] Maximum packet size
    $0f constant OTG_USBAEP                     \ [0x0f] USB active endpoint
    $10 constant OTG_EONUM                      \ [0x10] Even/odd frame
    $11 constant OTG_NAKSTS                     \ [0x11] NAK status
    $12 constant OTG_EPTYP                      \ [0x12 : 2] Endpoint type
    $14 constant OTG_SNPM                       \ [0x14] Snoop mode
    $15 constant OTG_STALL                      \ [0x15] STALL handshake
    $1a constant OTG_CNAK                       \ [0x1a] Clear NAK
    $1b constant OTG_SNAK                       \ [0x1b] Set NAK
    $1c constant OTG_SEVNFRM                    \ [0x1c] Set even frame
    $1d constant OTG_SODDFRM                    \ [0x1d] Set odd frame
    $1e constant OTG_EPDIS                      \ [0x1e] Endpoint disable
    $1f constant OTG_EPENA                      \ [0x1f] Endpoint enable
  [then]


  [ifdef] OTG_OTG_DOEPINT7_DEF
    \
    \ @brief OTG device OUT endpoint 7 interrupt register
    \ Address offset: 0xBE8
    \ Reset value: 0x00000080
    \
    $00 constant OTG_XFRC                       \ [0x00] Transfer completed interrupt
    $01 constant OTG_EPDISD                     \ [0x01] Endpoint disabled interrupt
    $02 constant OTG_AHBERR                     \ [0x02] AHB error
    $03 constant OTG_STUP                       \ [0x03] SETUP phase done
    $04 constant OTG_OTEPDIS                    \ [0x04] OUT token received when endpoint disabled
    $05 constant OTG_STSPHSRX                   \ [0x05] Status phase received for control write
    $06 constant OTG_B2BSTUP                    \ [0x06] Back-to-back SETUP packets received
    $08 constant OTG_OUTPKTERR                  \ [0x08] OUT packet error
    $0c constant OTG_BERR                       \ [0x0c] Babble error interrupt
    $0d constant OTG_NAK                        \ [0x0d] NAK input
    $0e constant OTG_NYET                       \ [0x0e] NYET interrupt
    $0f constant OTG_STPKTRX                    \ [0x0f] Setup packet received
  [then]


  [ifdef] OTG_OTG_DOEPTSIZ7_DEF
    \
    \ @brief OTG device OUT endpoint 7 transfer size register
    \ Address offset: 0xBF0
    \ Reset value: 0x00000000
    \
    $00 constant OTG_XFRSIZ                     \ [0x00 : 19] Transfer size
    $13 constant OTG_PKTCNT                     \ [0x13 : 10] Packet count
    $1d constant OTG_RXDPID                     \ [0x1d : 2] Received data PID
  [then]


  [ifdef] OTG_OTG_DOEPDMA7_DEF
    \
    \ @brief OTG device OUT endpoint 7 DMA address register
    \ Address offset: 0xBF4
    \ Reset value: 0x00000000
    \
    $00 constant OTG_DMAADDR                    \ [0x00 : 32] DMA Address
  [then]


  [ifdef] OTG_OTG_DOEPCTL8_DEF
    \
    \ @brief OTG device OUT endpoint 8 control register [alternate]
    \ Address offset: 0xC00
    \ Reset value: 0x00000000
    \
    $00 constant OTG_MPSIZ                      \ [0x00 : 11] Maximum packet size
    $0f constant OTG_USBAEP                     \ [0x0f] USB active endpoint
    $10 constant OTG_DPID                       \ [0x10] Endpoint data PID
    $11 constant OTG_NAKSTS                     \ [0x11] NAK status
    $12 constant OTG_EPTYP                      \ [0x12 : 2] Endpoint type
    $14 constant OTG_SNPM                       \ [0x14] Snoop mode
    $15 constant OTG_STALL                      \ [0x15] STALL handshake
    $1a constant OTG_CNAK                       \ [0x1a] Clear NAK
    $1b constant OTG_SNAK                       \ [0x1b] Set NAK
    $1c constant OTG_SD0PID                     \ [0x1c] Set DATA0 PID
    $1d constant OTG_SD1PID                     \ [0x1d] Set DATA1 PID
    $1e constant OTG_EPDIS                      \ [0x1e] Endpoint disable
    $1f constant OTG_EPENA                      \ [0x1f] Endpoint enable
  [then]


  [ifdef] OTG_OTG_DOEPCTL8_ALTERNATE_DEF
    \
    \ @brief OTG device OUT endpoint 8 control register [alternate]
    \ Address offset: 0xC00
    \ Reset value: 0x00000000
    \
    $00 constant OTG_MPSIZ                      \ [0x00 : 11] Maximum packet size
    $0f constant OTG_USBAEP                     \ [0x0f] USB active endpoint
    $10 constant OTG_EONUM                      \ [0x10] Even/odd frame
    $11 constant OTG_NAKSTS                     \ [0x11] NAK status
    $12 constant OTG_EPTYP                      \ [0x12 : 2] Endpoint type
    $14 constant OTG_SNPM                       \ [0x14] Snoop mode
    $15 constant OTG_STALL                      \ [0x15] STALL handshake
    $1a constant OTG_CNAK                       \ [0x1a] Clear NAK
    $1b constant OTG_SNAK                       \ [0x1b] Set NAK
    $1c constant OTG_SEVNFRM                    \ [0x1c] Set even frame
    $1d constant OTG_SODDFRM                    \ [0x1d] Set odd frame
    $1e constant OTG_EPDIS                      \ [0x1e] Endpoint disable
    $1f constant OTG_EPENA                      \ [0x1f] Endpoint enable
  [then]


  [ifdef] OTG_OTG_DOEPINT8_DEF
    \
    \ @brief OTG device OUT endpoint 8 interrupt register
    \ Address offset: 0xC08
    \ Reset value: 0x00000080
    \
    $00 constant OTG_XFRC                       \ [0x00] Transfer completed interrupt
    $01 constant OTG_EPDISD                     \ [0x01] Endpoint disabled interrupt
    $02 constant OTG_AHBERR                     \ [0x02] AHB error
    $03 constant OTG_STUP                       \ [0x03] SETUP phase done
    $04 constant OTG_OTEPDIS                    \ [0x04] OUT token received when endpoint disabled
    $05 constant OTG_STSPHSRX                   \ [0x05] Status phase received for control write
    $06 constant OTG_B2BSTUP                    \ [0x06] Back-to-back SETUP packets received
    $08 constant OTG_OUTPKTERR                  \ [0x08] OUT packet error
    $0c constant OTG_BERR                       \ [0x0c] Babble error interrupt
    $0d constant OTG_NAK                        \ [0x0d] NAK input
    $0e constant OTG_NYET                       \ [0x0e] NYET interrupt
    $0f constant OTG_STPKTRX                    \ [0x0f] Setup packet received
  [then]


  [ifdef] OTG_OTG_DOEPTSIZ8_DEF
    \
    \ @brief OTG device OUT endpoint 8 transfer size register
    \ Address offset: 0xC10
    \ Reset value: 0x00000000
    \
    $00 constant OTG_XFRSIZ                     \ [0x00 : 19] Transfer size
    $13 constant OTG_PKTCNT                     \ [0x13 : 10] Packet count
    $1d constant OTG_RXDPID                     \ [0x1d : 2] Received data PID
  [then]


  [ifdef] OTG_OTG_DOEPDMA8_DEF
    \
    \ @brief OTG device OUT endpoint 8 DMA address register
    \ Address offset: 0xC14
    \ Reset value: 0x00000000
    \
    $00 constant OTG_DMAADDR                    \ [0x00 : 32] DMA Address
  [then]


  [ifdef] OTG_OTG_PCGCCTL_DEF
    \
    \ @brief OTG power and clock gating control register
    \ Address offset: 0xE00
    \ Reset value: 0x200B8000
    \
    $00 constant OTG_STPPCLK                    \ [0x00] Stop PHY clock
    $01 constant OTG_GATEHCLK                   \ [0x01] Gate HCLK
    $04 constant OTG_PHYSUSP                    \ [0x04] PHY suspended
    $05 constant OTG_ENL1GTG                    \ [0x05] Enable sleep clock gating
    $06 constant OTG_PHYSLEEP                   \ [0x06] PHY in Sleep
    $07 constant OTG_SUSP                       \ [0x07] Deep Sleep
  [then]


  [ifdef] OTG_OTG_PCGCCTL1_DEF
    \
    \ @brief OTG power and clock gating control register 1
    \ Address offset: 0xE04
    \ Reset value: 0x00000000
    \
    $00 constant OTG_GATEEN                     \ [0x00] Enable active clock gating
    $01 constant OTG_CNTGATECLK                 \ [0x01 : 2] Counter for clock gating
    $03 constant OTG_RAMGATEEN                  \ [0x03] Enable RAM clock gating
  [then]

  \
  \ @brief USB on-the-go high-speed
  \
  $00 constant OTG_OTG_GOTGCTL          \ OTG control and status register
  $04 constant OTG_OTG_GOTGINT          \ OTG interrupt register
  $08 constant OTG_OTG_GAHBCFG          \ OTG AHB configuration register
  $0C constant OTG_OTG_GUSBCFG          \ OTG USB configuration register
  $10 constant OTG_OTG_GRSTCTL          \ OTG reset register
  $14 constant OTG_OTG_GINTSTS          \ OTG core interrupt register [alternate]
  $14 constant OTG_OTG_GINTSTS_ALTERNATE    \ OTG core interrupt register [alternate]
  $18 constant OTG_OTG_GINTMSK          \ OTG interrupt mask register [alternate]
  $18 constant OTG_OTG_GINTMSK_ALTERNATE    \ OTG interrupt mask register [alternate]
  $1C constant OTG_OTG_GRXSTSR          \ OTG receive status debug read register [alternate]
  $1C constant OTG_OTG_GRXSTSR_ALTERNATE    \ OTG receive status debug read register [alternate]
  $20 constant OTG_OTG_GRXSTSP          \ OTG status read and pop registers
  $20 constant OTG_OTG_GRXSTSP_ALTERNATE    \ OTG status read and pop registers
  $24 constant OTG_OTG_GRXFSIZ          \ OTG receive FIFO size register
  $28 constant OTG_OTG_HNPTXFSIZ        \ OTG host non-periodic transmit FIFO size register [alternate]
  $28 constant OTG_OTG_HNPTXFSIZ_ALTERNATE    \ OTG host non-periodic transmit FIFO size register [alternate]
  $2C constant OTG_OTG_HNPTXSTS         \ OTG non-periodic transmit FIFO/queue status register
  $38 constant OTG_OTG_GCCFG            \ OTG general core configuration register
  $3C constant OTG_OTG_CID              \ OTG core ID register
  $54 constant OTG_OTG_GLPMCFG          \ OTG core LPM configuration register
  $100 constant OTG_OTG_HPTXFSIZ        \ OTG host periodic transmit FIFO size register
  $104 constant OTG_OTG_DIEPTXF1        \ OTG device IN endpoint transmit FIFO 1 size register
  $108 constant OTG_OTG_DIEPTXF2        \ OTG device IN endpoint transmit FIFO 2 size register
  $10C constant OTG_OTG_DIEPTXF3        \ OTG device IN endpoint transmit FIFO 3 size register
  $110 constant OTG_OTG_DIEPTXF4        \ OTG device IN endpoint transmit FIFO 4 size register
  $114 constant OTG_OTG_DIEPTXF5        \ OTG device IN endpoint transmit FIFO 5 size register
  $118 constant OTG_OTG_DIEPTXF6        \ OTG device IN endpoint transmit FIFO 6 size register
  $11C constant OTG_OTG_DIEPTXF7        \ OTG device IN endpoint transmit FIFO 7 size register
  $120 constant OTG_OTG_DIEPTXF8        \ OTG device IN endpoint transmit FIFO 8 size register
  $400 constant OTG_OTG_HCFG            \ OTG host configuration register
  $404 constant OTG_OTG_HFIR            \ OTG host frame interval register
  $408 constant OTG_OTG_HFNUM           \ OTG host frame number/frame time remaining register
  $410 constant OTG_OTG_HPTXSTS         \ OTG_Host periodic transmit FIFO/queue status register
  $414 constant OTG_OTG_HAINT           \ OTG host all channels interrupt register
  $418 constant OTG_OTG_HAINTMSK        \ OTG host all channels interrupt mask register
  $440 constant OTG_OTG_HPRT            \ OTG host port control and status register
  $500 constant OTG_OTG_HCCHAR0         \ OTG host channel 0 characteristics register
  $504 constant OTG_OTG_HCSPLT0         \ OTG host channel 0 split control register
  $508 constant OTG_OTG_HCINT0          \ OTG host channel 0 interrupt register
  $50C constant OTG_OTG_HCINTMSK0       \ OTG host channel 0 interrupt mask register
  $510 constant OTG_OTG_HCTSIZ0         \ OTG host channel 0 transfer size register
  $514 constant OTG_OTG_HCDMA0          \ OTG host channel 0 DMA address register
  $520 constant OTG_OTG_HCCHAR1         \ OTG host channel 1 characteristics register
  $524 constant OTG_OTG_HCSPLT1         \ OTG host channel 1 split control register
  $528 constant OTG_OTG_HCINT1          \ OTG host channel 1 interrupt register
  $52C constant OTG_OTG_HCINTMSK1       \ OTG host channel 1 interrupt mask register
  $530 constant OTG_OTG_HCTSIZ1         \ OTG host channel 1 transfer size register
  $534 constant OTG_OTG_HCDMA1          \ OTG host channel 1 DMA address register
  $540 constant OTG_OTG_HCCHAR2         \ OTG host channel 2 characteristics register
  $544 constant OTG_OTG_HCSPLT2         \ OTG host channel 2 split control register
  $548 constant OTG_OTG_HCINT2          \ OTG host channel 2 interrupt register
  $54C constant OTG_OTG_HCINTMSK2       \ OTG host channel 2 interrupt mask register
  $550 constant OTG_OTG_HCTSIZ2         \ OTG host channel 2 transfer size register
  $554 constant OTG_OTG_HCDMA2          \ OTG host channel 2 DMA address register
  $560 constant OTG_OTG_HCCHAR3         \ OTG host channel 3 characteristics register
  $564 constant OTG_OTG_HCSPLT3         \ OTG host channel 3 split control register
  $568 constant OTG_OTG_HCINT3          \ OTG host channel 3 interrupt register
  $56C constant OTG_OTG_HCINTMSK3       \ OTG host channel 3 interrupt mask register
  $570 constant OTG_OTG_HCTSIZ3         \ OTG host channel 3 transfer size register
  $574 constant OTG_OTG_HCDMA3          \ OTG host channel 3 DMA address register
  $580 constant OTG_OTG_HCCHAR4         \ OTG host channel 4 characteristics register
  $584 constant OTG_OTG_HCSPLT4         \ OTG host channel 4 split control register
  $588 constant OTG_OTG_HCINT4          \ OTG host channel 4 interrupt register
  $58C constant OTG_OTG_HCINTMSK4       \ OTG host channel 4 interrupt mask register
  $590 constant OTG_OTG_HCTSIZ4         \ OTG host channel 4 transfer size register
  $594 constant OTG_OTG_HCDMA4          \ OTG host channel 4 DMA address register
  $5A0 constant OTG_OTG_HCCHAR5         \ OTG host channel 5 characteristics register
  $5A4 constant OTG_OTG_HCSPLT5         \ OTG host channel 5 split control register
  $5A8 constant OTG_OTG_HCINT5          \ OTG host channel 5 interrupt register
  $5AC constant OTG_OTG_HCINTMSK5       \ OTG host channel 5 interrupt mask register
  $5B0 constant OTG_OTG_HCTSIZ5         \ OTG host channel 5 transfer size register
  $5B4 constant OTG_OTG_HCDMA5          \ OTG host channel 5 DMA address register
  $5C0 constant OTG_OTG_HCCHAR6         \ OTG host channel 6 characteristics register
  $5C4 constant OTG_OTG_HCSPLT6         \ OTG host channel 6 split control register
  $5C8 constant OTG_OTG_HCINT6          \ OTG host channel 6 interrupt register
  $5CC constant OTG_OTG_HCINTMSK6       \ OTG host channel 6 interrupt mask register
  $5D0 constant OTG_OTG_HCTSIZ6         \ OTG host channel 6 transfer size register
  $5D4 constant OTG_OTG_HCDMA6          \ OTG host channel 6 DMA address register
  $5E0 constant OTG_OTG_HCCHAR7         \ OTG host channel 7 characteristics register
  $5E4 constant OTG_OTG_HCSPLT7         \ OTG host channel 7 split control register
  $5E8 constant OTG_OTG_HCINT7          \ OTG host channel 7 interrupt register
  $5EC constant OTG_OTG_HCINTMSK7       \ OTG host channel 7 interrupt mask register
  $5F0 constant OTG_OTG_HCTSIZ7         \ OTG host channel 7 transfer size register
  $5F4 constant OTG_OTG_HCDMA7          \ OTG host channel 7 DMA address register
  $600 constant OTG_OTG_HCCHAR8         \ OTG host channel 8 characteristics register
  $604 constant OTG_OTG_HCSPLT8         \ OTG host channel 8 split control register
  $608 constant OTG_OTG_HCINT8          \ OTG host channel 8 interrupt register
  $60C constant OTG_OTG_HCINTMSK8       \ OTG host channel 8 interrupt mask register
  $610 constant OTG_OTG_HCTSIZ8         \ OTG host channel 8 transfer size register
  $614 constant OTG_OTG_HCDMA8          \ OTG host channel 8 DMA address register
  $620 constant OTG_OTG_HCCHAR9         \ OTG host channel 9 characteristics register
  $624 constant OTG_OTG_HCSPLT9         \ OTG host channel 9 split control register
  $628 constant OTG_OTG_HCINT9          \ OTG host channel 9 interrupt register
  $62C constant OTG_OTG_HCINTMSK9       \ OTG host channel 9 interrupt mask register
  $630 constant OTG_OTG_HCTSIZ9         \ OTG host channel 9 transfer size register
  $634 constant OTG_OTG_HCDMA9          \ OTG host channel 9 DMA address register
  $640 constant OTG_OTG_HCCHAR10        \ OTG host channel 10 characteristics register
  $644 constant OTG_OTG_HCSPLT10        \ OTG host channel 10 split control register
  $648 constant OTG_OTG_HCINT10         \ OTG host channel 10 interrupt register
  $64C constant OTG_OTG_HCINTMSK10      \ OTG host channel 10 interrupt mask register
  $650 constant OTG_OTG_HCTSIZ10        \ OTG host channel 10 transfer size register
  $654 constant OTG_OTG_HCDMA10         \ OTG host channel 10 DMA address register
  $660 constant OTG_OTG_HCCHAR11        \ OTG host channel 11 characteristics register
  $664 constant OTG_OTG_HCSPLT11        \ OTG host channel 11 split control register
  $668 constant OTG_OTG_HCINT11         \ OTG host channel 11 interrupt register
  $66C constant OTG_OTG_HCINTMSK11      \ OTG host channel 11 interrupt mask register
  $670 constant OTG_OTG_HCTSIZ11        \ OTG host channel 11 transfer size register
  $674 constant OTG_OTG_HCDMA11         \ OTG host channel 11 DMA address register
  $680 constant OTG_OTG_HCCHAR12        \ OTG host channel 12 characteristics register
  $684 constant OTG_OTG_HCSPLT12        \ OTG host channel 12 split control register
  $688 constant OTG_OTG_HCINT12         \ OTG host channel 12 interrupt register
  $68C constant OTG_OTG_HCINTMSK12      \ OTG host channel 12 interrupt mask register
  $690 constant OTG_OTG_HCTSIZ12        \ OTG host channel 12 transfer size register
  $694 constant OTG_OTG_HCDMA12         \ OTG host channel 12 DMA address register
  $6A0 constant OTG_OTG_HCCHAR13        \ OTG host channel 13 characteristics register
  $6A4 constant OTG_OTG_HCSPLT13        \ OTG host channel 13 split control register
  $6A8 constant OTG_OTG_HCINT13         \ OTG host channel 13 interrupt register
  $6AC constant OTG_OTG_HCINTMSK13      \ OTG host channel 13 interrupt mask register
  $6B0 constant OTG_OTG_HCTSIZ13        \ OTG host channel 13 transfer size register
  $6B4 constant OTG_OTG_HCDMA13         \ OTG host channel 13 DMA address register
  $6C0 constant OTG_OTG_HCCHAR14        \ OTG host channel 14 characteristics register
  $6C4 constant OTG_OTG_HCSPLT14        \ OTG host channel 14 split control register
  $6C8 constant OTG_OTG_HCINT14         \ OTG host channel 14 interrupt register
  $6CC constant OTG_OTG_HCINTMSK14      \ OTG host channel 14 interrupt mask register
  $6D0 constant OTG_OTG_HCTSIZ14        \ OTG host channel 14 transfer size register
  $6D4 constant OTG_OTG_HCDMA14         \ OTG host channel 14 DMA address register
  $6E0 constant OTG_OTG_HCCHAR15        \ OTG host channel 15 characteristics register
  $6E4 constant OTG_OTG_HCSPLT15        \ OTG host channel 15 split control register
  $6E8 constant OTG_OTG_HCINT15         \ OTG host channel 15 interrupt register
  $6EC constant OTG_OTG_HCINTMSK15      \ OTG host channel 15 interrupt mask register
  $6F0 constant OTG_OTG_HCTSIZ15        \ OTG host channel 15 transfer size register
  $6F4 constant OTG_OTG_HCDMA15         \ OTG host channel 15 DMA address register
  $800 constant OTG_OTG_DCFG            \ OTG device configuration register
  $804 constant OTG_OTG_DCTL            \ OTG device control register
  $808 constant OTG_OTG_DSTS            \ OTG device status register
  $810 constant OTG_OTG_DIEPMSK         \ OTG device IN endpoint common interrupt mask register
  $814 constant OTG_OTG_DOEPMSK         \ OTG device OUT endpoint common interrupt mask register
  $818 constant OTG_OTG_DAINT           \ OTG device all endpoints interrupt register
  $81C constant OTG_OTG_DAINTMSK        \ OTG all endpoints interrupt mask register
  $830 constant OTG_OTG_DTHRCTL         \ OTG device threshold control register
  $834 constant OTG_OTG_DIEPEMPMSK      \ OTG device IN endpoint FIFO empty interrupt mask register
  $900 constant OTG_OTG_DIEPCTL0        \ OTG device IN endpoint 0 control register [alternate]
  $900 constant OTG_OTG_DIEPCTL0_ALTERNATE    \ OTG device IN endpoint 0 control register [alternate]
  $908 constant OTG_OTG_DIEPINT0        \ OTG device IN endpoint 0 interrupt register
  $910 constant OTG_OTG_DIEPTSIZ0       \ OTG device IN endpoint 0 transfer size register
  $914 constant OTG_OTG_DIEPDMA0        \ OTG device IN endpoint 0 DMA address register
  $918 constant OTG_OTG_DTXFSTS0        \ OTG device IN endpoint transmit FIFO status register
  $920 constant OTG_OTG_DIEPCTL1        \ OTG device IN endpoint 1 control register [alternate]
  $920 constant OTG_OTG_DIEPCTL1_ALTERNATE    \ OTG device IN endpoint 1 control register [alternate]
  $928 constant OTG_OTG_DIEPINT1        \ OTG device IN endpoint 1 interrupt register
  $930 constant OTG_OTG_DIEPTSIZ1       \ OTG device IN endpoint 1 transfer size register
  $934 constant OTG_OTG_DIEPDMA1        \ OTG device IN endpoint 1 DMA address register
  $938 constant OTG_OTG_DTXFSTS1        \ OTG device IN endpoint transmit FIFO status register
  $940 constant OTG_OTG_DIEPCTL2        \ OTG device IN endpoint 2 control register [alternate]
  $940 constant OTG_OTG_DIEPCTL2_ALTERNATE    \ OTG device IN endpoint 2 control register [alternate]
  $948 constant OTG_OTG_DIEPINT2        \ OTG device IN endpoint 2 interrupt register
  $950 constant OTG_OTG_DIEPTSIZ2       \ OTG device IN endpoint 2 transfer size register
  $954 constant OTG_OTG_DIEPDMA2        \ OTG device IN endpoint 2 DMA address register
  $958 constant OTG_OTG_DTXFSTS2        \ OTG device IN endpoint transmit FIFO status register
  $960 constant OTG_OTG_DIEPCTL3        \ OTG device IN endpoint 3 control register [alternate]
  $960 constant OTG_OTG_DIEPCTL3_ALTERNATE    \ OTG device IN endpoint 3 control register [alternate]
  $968 constant OTG_OTG_DIEPINT3        \ OTG device IN endpoint 3 interrupt register
  $970 constant OTG_OTG_DIEPTSIZ3       \ OTG device IN endpoint 3 transfer size register
  $974 constant OTG_OTG_DIEPDMA3        \ OTG device IN endpoint 3 DMA address register
  $978 constant OTG_OTG_DTXFSTS3        \ OTG device IN endpoint transmit FIFO status register
  $980 constant OTG_OTG_DIEPCTL4        \ OTG device IN endpoint 4 control register [alternate]
  $980 constant OTG_OTG_DIEPCTL4_ALTERNATE    \ OTG device IN endpoint 4 control register [alternate]
  $988 constant OTG_OTG_DIEPINT4        \ OTG device IN endpoint 4 interrupt register
  $990 constant OTG_OTG_DIEPTSIZ4       \ OTG device IN endpoint 4 transfer size register
  $994 constant OTG_OTG_DIEPDMA4        \ OTG device IN endpoint 4 DMA address register
  $998 constant OTG_OTG_DTXFSTS4        \ OTG device IN endpoint transmit FIFO status register
  $9A0 constant OTG_OTG_DIEPCTL5        \ OTG device IN endpoint 5 control register [alternate]
  $9A0 constant OTG_OTG_DIEPCTL5_ALTERNATE    \ OTG device IN endpoint 5 control register [alternate]
  $9A8 constant OTG_OTG_DIEPINT5        \ OTG device IN endpoint 5 interrupt register
  $9B0 constant OTG_OTG_DIEPTSIZ5       \ OTG device IN endpoint 5 transfer size register
  $9B4 constant OTG_OTG_DIEPDMA5        \ OTG device IN endpoint 5 DMA address register
  $9B8 constant OTG_OTG_DTXFSTS5        \ OTG device IN endpoint transmit FIFO status register
  $9C0 constant OTG_OTG_DIEPCTL6        \ OTG device IN endpoint 6 control register [alternate]
  $9C0 constant OTG_OTG_DIEPCTL6_ALTERNATE    \ OTG device IN endpoint 6 control register [alternate]
  $9C8 constant OTG_OTG_DIEPINT6        \ OTG device IN endpoint 6 interrupt register
  $9D0 constant OTG_OTG_DIEPTSIZ6       \ OTG device IN endpoint 6 transfer size register
  $9D4 constant OTG_OTG_DIEPDMA6        \ OTG device IN endpoint 6 DMA address register
  $9D8 constant OTG_OTG_DTXFSTS6        \ OTG device IN endpoint transmit FIFO status register
  $9E0 constant OTG_OTG_DIEPCTL7        \ OTG device IN endpoint 7 control register [alternate]
  $9E0 constant OTG_OTG_DIEPCTL7_ALTERNATE    \ OTG device IN endpoint 7 control register [alternate]
  $9E8 constant OTG_OTG_DIEPINT7        \ OTG device IN endpoint 7 interrupt register
  $9F0 constant OTG_OTG_DIEPTSIZ7       \ OTG device IN endpoint 7 transfer size register
  $9F4 constant OTG_OTG_DIEPDMA7        \ OTG device IN endpoint 7 DMA address register
  $9F8 constant OTG_OTG_DTXFSTS7        \ OTG device IN endpoint transmit FIFO status register
  $A00 constant OTG_OTG_DIEPCTL8        \ OTG device IN endpoint 8 control register [alternate]
  $A00 constant OTG_OTG_DIEPCTL8_ALTERNATE    \ OTG device IN endpoint 8 control register [alternate]
  $A08 constant OTG_OTG_DIEPINT8        \ OTG device IN endpoint 8 interrupt register
  $A10 constant OTG_OTG_DIEPTSIZ8       \ OTG device IN endpoint 8 transfer size register
  $A14 constant OTG_OTG_DIEPDMA8        \ OTG device IN endpoint 8 DMA address register
  $A18 constant OTG_OTG_DTXFSTS8        \ OTG device IN endpoint transmit FIFO status register
  $B00 constant OTG_OTG_DOEPCTL0        \ OTG device control OUT endpoint 0 control register
  $B08 constant OTG_OTG_DOEPINT0        \ OTG device OUT endpoint 0 interrupt register
  $B10 constant OTG_OTG_DOEPTSIZ0       \ OTG device OUT endpoint 0 transfer size register
  $B14 constant OTG_OTG_DOEPDMA0        \ OTG device OUT endpoint 0 DMA address register
  $B20 constant OTG_OTG_DOEPCTL1        \ OTG device OUT endpoint 1 control register [alternate]
  $B20 constant OTG_OTG_DOEPCTL1_ALTERNATE    \ OTG device OUT endpoint 1 control register [alternate]
  $B28 constant OTG_OTG_DOEPINT1        \ OTG device OUT endpoint 1 interrupt register
  $B30 constant OTG_OTG_DOEPTSIZ1       \ OTG device OUT endpoint 1 transfer size register
  $B34 constant OTG_OTG_DOEPDMA1        \ OTG device OUT endpoint 1 DMA address register
  $B40 constant OTG_OTG_DOEPCTL2        \ OTG device OUT endpoint 2 control register [alternate]
  $B40 constant OTG_OTG_DOEPCTL2_ALTERNATE    \ OTG device OUT endpoint 2 control register [alternate]
  $B48 constant OTG_OTG_DOEPINT2        \ OTG device OUT endpoint 2 interrupt register
  $B50 constant OTG_OTG_DOEPTSIZ2       \ OTG device OUT endpoint 2 transfer size register
  $B54 constant OTG_OTG_DOEPDMA2        \ OTG device OUT endpoint 2 DMA address register
  $B60 constant OTG_OTG_DOEPCTL3        \ OTG device OUT endpoint 3 control register [alternate]
  $B60 constant OTG_OTG_DOEPCTL3_ALTERNATE    \ OTG device OUT endpoint 3 control register [alternate]
  $B68 constant OTG_OTG_DOEPINT3        \ OTG device OUT endpoint 3 interrupt register
  $B70 constant OTG_OTG_DOEPTSIZ3       \ OTG device OUT endpoint 3 transfer size register
  $B74 constant OTG_OTG_DOEPDMA3        \ OTG device OUT endpoint 3 DMA address register
  $B80 constant OTG_OTG_DOEPCTL4        \ OTG device OUT endpoint 4 control register [alternate]
  $B80 constant OTG_OTG_DOEPCTL4_ALTERNATE    \ OTG device OUT endpoint 4 control register [alternate]
  $B88 constant OTG_OTG_DOEPINT4        \ OTG device OUT endpoint 4 interrupt register
  $B90 constant OTG_OTG_DOEPTSIZ4       \ OTG device OUT endpoint 4 transfer size register
  $B94 constant OTG_OTG_DOEPDMA4        \ OTG device OUT endpoint 4 DMA address register
  $BA0 constant OTG_OTG_DOEPCTL5        \ OTG device OUT endpoint 5 control register [alternate]
  $BA0 constant OTG_OTG_DOEPCTL5_ALTERNATE    \ OTG device OUT endpoint 5 control register [alternate]
  $BA8 constant OTG_OTG_DOEPINT5        \ OTG device OUT endpoint 5 interrupt register
  $BB0 constant OTG_OTG_DOEPTSIZ5       \ OTG device OUT endpoint 5 transfer size register
  $BB4 constant OTG_OTG_DOEPDMA5        \ OTG device OUT endpoint 5 DMA address register
  $BC0 constant OTG_OTG_DOEPCTL6        \ OTG device OUT endpoint 6 control register [alternate]
  $BC0 constant OTG_OTG_DOEPCTL6_ALTERNATE    \ OTG device OUT endpoint 6 control register [alternate]
  $BC8 constant OTG_OTG_DOEPINT6        \ OTG device OUT endpoint 6 interrupt register
  $BD0 constant OTG_OTG_DOEPTSIZ6       \ OTG device OUT endpoint 6 transfer size register
  $BD4 constant OTG_OTG_DOEPDMA6        \ OTG device OUT endpoint 6 DMA address register
  $BE0 constant OTG_OTG_DOEPCTL7        \ OTG device OUT endpoint 7 control register [alternate]
  $BE0 constant OTG_OTG_DOEPCTL7_ALTERNATE    \ OTG device OUT endpoint 7 control register [alternate]
  $BE8 constant OTG_OTG_DOEPINT7        \ OTG device OUT endpoint 7 interrupt register
  $BF0 constant OTG_OTG_DOEPTSIZ7       \ OTG device OUT endpoint 7 transfer size register
  $BF4 constant OTG_OTG_DOEPDMA7        \ OTG device OUT endpoint 7 DMA address register
  $C00 constant OTG_OTG_DOEPCTL8        \ OTG device OUT endpoint 8 control register [alternate]
  $C00 constant OTG_OTG_DOEPCTL8_ALTERNATE    \ OTG device OUT endpoint 8 control register [alternate]
  $C08 constant OTG_OTG_DOEPINT8        \ OTG device OUT endpoint 8 interrupt register
  $C10 constant OTG_OTG_DOEPTSIZ8       \ OTG device OUT endpoint 8 transfer size register
  $C14 constant OTG_OTG_DOEPDMA8        \ OTG device OUT endpoint 8 DMA address register
  $E00 constant OTG_OTG_PCGCCTL         \ OTG power and clock gating control register
  $E04 constant OTG_OTG_PCGCCTL1        \ OTG power and clock gating control register 1

: OTG_DEF ; [then]
