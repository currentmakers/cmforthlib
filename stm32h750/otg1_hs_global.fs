\
\ @file otg1_hs_global.fs
\ @brief USB 1 on the go high speed
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] OTG1_HS_GLOBAL_DEF

  [ifdef] OTG1_HS_GLOBAL_OTG_HS_GOTGCTL_DEF
    \
    \ @brief OTG_HS control and status register
    \ Address offset: 0x00
    \ Reset value: 0x00000800
    \
    $00 constant OTG1_HS_GLOBAL_SRQSCS          \ [0x00] Session request success
    $01 constant OTG1_HS_GLOBAL_SRQ             \ [0x01] Session request
    $02 constant OTG1_HS_GLOBAL_VBVALOEN        \ [0x02] VBUS valid override enable
    $03 constant OTG1_HS_GLOBAL_VBVALOVAL       \ [0x03] VBUS valid override value
    $04 constant OTG1_HS_GLOBAL_AVALOEN         \ [0x04] A-peripheral session valid override enable
    $05 constant OTG1_HS_GLOBAL_AVALOVAL        \ [0x05] A-peripheral session valid override value
    $06 constant OTG1_HS_GLOBAL_BVALOEN         \ [0x06] B-peripheral session valid override enable.
    $07 constant OTG1_HS_GLOBAL_BVALOVAL        \ [0x07] B-peripheral session valid override value
    $08 constant OTG1_HS_GLOBAL_HNGSCS          \ [0x08] Host negotiation success
    $09 constant OTG1_HS_GLOBAL_HNPRQ           \ [0x09] HNP request
    $0a constant OTG1_HS_GLOBAL_HSHNPEN         \ [0x0a] Host set HNP enable
    $0b constant OTG1_HS_GLOBAL_DHNPEN          \ [0x0b] Device HNP enabled
    $0c constant OTG1_HS_GLOBAL_EHEN            \ [0x0c] Embedded host enable
    $10 constant OTG1_HS_GLOBAL_CIDSTS          \ [0x10] Connector ID status
    $11 constant OTG1_HS_GLOBAL_DBCT            \ [0x11] Long/short debounce time
    $12 constant OTG1_HS_GLOBAL_ASVLD           \ [0x12] A-session valid
    $13 constant OTG1_HS_GLOBAL_BSVLD           \ [0x13] B-session valid
    $14 constant OTG1_HS_GLOBAL_OTGVER          \ [0x14] OTG version
    $15 constant OTG1_HS_GLOBAL_CURMOD          \ [0x15] Current mode of operation
  [then]


  [ifdef] OTG1_HS_GLOBAL_OTG_HS_GOTGINT_DEF
    \
    \ @brief OTG_HS interrupt register
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $02 constant OTG1_HS_GLOBAL_SEDET           \ [0x02] Session end detected
    $08 constant OTG1_HS_GLOBAL_SRSSCHG         \ [0x08] Session request success status change
    $09 constant OTG1_HS_GLOBAL_HNSSCHG         \ [0x09] Host negotiation success status change
    $11 constant OTG1_HS_GLOBAL_HNGDET          \ [0x11] Host negotiation detected
    $12 constant OTG1_HS_GLOBAL_ADTOCHG         \ [0x12] A-device timeout change
    $13 constant OTG1_HS_GLOBAL_DBCDNE          \ [0x13] Debounce done
    $14 constant OTG1_HS_GLOBAL_IDCHNG          \ [0x14] ID input pin changed
  [then]


  [ifdef] OTG1_HS_GLOBAL_OTG_HS_GAHBCFG_DEF
    \
    \ @brief OTG_HS AHB configuration register
    \ Address offset: 0x08
    \ Reset value: 0x00000000
    \
    $00 constant OTG1_HS_GLOBAL_GINT            \ [0x00] Global interrupt mask
    $01 constant OTG1_HS_GLOBAL_HBSTLEN         \ [0x01 : 4] Burst length/type
    $05 constant OTG1_HS_GLOBAL_DMAEN           \ [0x05] DMA enable
    $07 constant OTG1_HS_GLOBAL_TXFELVL         \ [0x07] TxFIFO empty level
    $08 constant OTG1_HS_GLOBAL_PTXFELVL        \ [0x08] Periodic TxFIFO empty level
  [then]


  [ifdef] OTG1_HS_GLOBAL_OTG_HS_GUSBCFG_DEF
    \
    \ @brief OTG_HS USB configuration register
    \ Address offset: 0x0C
    \ Reset value: 0x00000A00
    \
    $00 constant OTG1_HS_GLOBAL_TOCAL           \ [0x00 : 3] FS timeout calibration
    $06 constant OTG1_HS_GLOBAL_PHYSEL          \ [0x06] USB 2.0 high-speed ULPI PHY or USB 1.1 full-speed serial transceiver select
    $08 constant OTG1_HS_GLOBAL_SRPCAP          \ [0x08] SRP-capable
    $09 constant OTG1_HS_GLOBAL_HNPCAP          \ [0x09] HNP-capable
    $0a constant OTG1_HS_GLOBAL_TRDT            \ [0x0a : 4] USB turnaround time
    $0f constant OTG1_HS_GLOBAL_PHYLPCS         \ [0x0f] PHY Low-power clock select
    $11 constant OTG1_HS_GLOBAL_ULPIFSLS        \ [0x11] ULPI FS/LS select
    $12 constant OTG1_HS_GLOBAL_ULPIAR          \ [0x12] ULPI Auto-resume
    $13 constant OTG1_HS_GLOBAL_ULPICSM         \ [0x13] ULPI Clock SuspendM
    $14 constant OTG1_HS_GLOBAL_ULPIEVBUSD      \ [0x14] ULPI External VBUS Drive
    $15 constant OTG1_HS_GLOBAL_ULPIEVBUSI      \ [0x15] ULPI external VBUS indicator
    $16 constant OTG1_HS_GLOBAL_TSDPS           \ [0x16] TermSel DLine pulsing selection
    $17 constant OTG1_HS_GLOBAL_PCCI            \ [0x17] Indicator complement
    $18 constant OTG1_HS_GLOBAL_PTCI            \ [0x18] Indicator pass through
    $19 constant OTG1_HS_GLOBAL_ULPIIPD         \ [0x19] ULPI interface protect disable
    $1d constant OTG1_HS_GLOBAL_FHMOD           \ [0x1d] Forced host mode
    $1e constant OTG1_HS_GLOBAL_FDMOD           \ [0x1e] Forced peripheral mode
  [then]


  [ifdef] OTG1_HS_GLOBAL_OTG_HS_GRSTCTL_DEF
    \
    \ @brief OTG_HS reset register
    \ Address offset: 0x10
    \ Reset value: 0x20000000
    \
    $00 constant OTG1_HS_GLOBAL_CSRST           \ [0x00] Core soft reset
    $01 constant OTG1_HS_GLOBAL_HSRST           \ [0x01] HCLK soft reset
    $02 constant OTG1_HS_GLOBAL_FCRST           \ [0x02] Host frame counter reset
    $04 constant OTG1_HS_GLOBAL_RXFFLSH         \ [0x04] RxFIFO flush
    $05 constant OTG1_HS_GLOBAL_TXFFLSH         \ [0x05] TxFIFO flush
    $06 constant OTG1_HS_GLOBAL_TXFNUM          \ [0x06 : 5] TxFIFO number
    $1e constant OTG1_HS_GLOBAL_DMAREQ          \ [0x1e] DMA request signal enabled for USB OTG HS
    $1f constant OTG1_HS_GLOBAL_AHBIDL          \ [0x1f] AHB master idle
  [then]


  [ifdef] OTG1_HS_GLOBAL_OTG_HS_GINTSTS_DEF
    \
    \ @brief OTG_HS core interrupt register
    \ Address offset: 0x14
    \ Reset value: 0x04000020
    \
    $00 constant OTG1_HS_GLOBAL_CMOD            \ [0x00] Current mode of operation
    $01 constant OTG1_HS_GLOBAL_MMIS            \ [0x01] Mode mismatch interrupt
    $02 constant OTG1_HS_GLOBAL_OTGINT          \ [0x02] OTG interrupt
    $03 constant OTG1_HS_GLOBAL_SOF             \ [0x03] Start of frame
    $04 constant OTG1_HS_GLOBAL_RXFLVL          \ [0x04] RxFIFO nonempty
    $05 constant OTG1_HS_GLOBAL_NPTXFE          \ [0x05] Nonperiodic TxFIFO empty
    $06 constant OTG1_HS_GLOBAL_GINAKEFF        \ [0x06] Global IN nonperiodic NAK effective
    $07 constant OTG1_HS_GLOBAL_BOUTNAKEFF      \ [0x07] Global OUT NAK effective
    $0a constant OTG1_HS_GLOBAL_ESUSP           \ [0x0a] Early suspend
    $0b constant OTG1_HS_GLOBAL_USBSUSP         \ [0x0b] USB suspend
    $0c constant OTG1_HS_GLOBAL_USBRST          \ [0x0c] USB reset
    $0d constant OTG1_HS_GLOBAL_ENUMDNE         \ [0x0d] Enumeration done
    $0e constant OTG1_HS_GLOBAL_ISOODRP         \ [0x0e] Isochronous OUT packet dropped interrupt
    $0f constant OTG1_HS_GLOBAL_EOPF            \ [0x0f] End of periodic frame interrupt
    $12 constant OTG1_HS_GLOBAL_IEPINT          \ [0x12] IN endpoint interrupt
    $13 constant OTG1_HS_GLOBAL_OEPINT          \ [0x13] OUT endpoint interrupt
    $14 constant OTG1_HS_GLOBAL_IISOIXFR        \ [0x14] Incomplete isochronous IN transfer
    $15 constant OTG1_HS_GLOBAL_PXFR_INCOMPISOOUT     \ [0x15] Incomplete periodic transfer
    $16 constant OTG1_HS_GLOBAL_DATAFSUSP       \ [0x16] Data fetch suspended
    $18 constant OTG1_HS_GLOBAL_HPRTINT         \ [0x18] Host port interrupt
    $19 constant OTG1_HS_GLOBAL_HCINT           \ [0x19] Host channels interrupt
    $1a constant OTG1_HS_GLOBAL_PTXFE           \ [0x1a] Periodic TxFIFO empty
    $1c constant OTG1_HS_GLOBAL_CIDSCHG         \ [0x1c] Connector ID status change
    $1d constant OTG1_HS_GLOBAL_DISCINT         \ [0x1d] Disconnect detected interrupt
    $1e constant OTG1_HS_GLOBAL_SRQINT          \ [0x1e] Session request/new session detected interrupt
    $1f constant OTG1_HS_GLOBAL_WKUINT          \ [0x1f] Resume/remote wakeup detected interrupt
  [then]


  [ifdef] OTG1_HS_GLOBAL_OTG_HS_GINTMSK_DEF
    \
    \ @brief OTG_HS interrupt mask register
    \ Address offset: 0x18
    \ Reset value: 0x00000000
    \
    $01 constant OTG1_HS_GLOBAL_MMISM           \ [0x01] Mode mismatch interrupt mask
    $02 constant OTG1_HS_GLOBAL_OTGINT          \ [0x02] OTG interrupt mask
    $03 constant OTG1_HS_GLOBAL_SOFM            \ [0x03] Start of frame mask
    $04 constant OTG1_HS_GLOBAL_RXFLVLM         \ [0x04] Receive FIFO nonempty mask
    $05 constant OTG1_HS_GLOBAL_NPTXFEM         \ [0x05] Nonperiodic TxFIFO empty mask
    $06 constant OTG1_HS_GLOBAL_GINAKEFFM       \ [0x06] Global nonperiodic IN NAK effective mask
    $07 constant OTG1_HS_GLOBAL_GONAKEFFM       \ [0x07] Global OUT NAK effective mask
    $0a constant OTG1_HS_GLOBAL_ESUSPM          \ [0x0a] Early suspend mask
    $0b constant OTG1_HS_GLOBAL_USBSUSPM        \ [0x0b] USB suspend mask
    $0c constant OTG1_HS_GLOBAL_USBRST          \ [0x0c] USB reset mask
    $0d constant OTG1_HS_GLOBAL_ENUMDNEM        \ [0x0d] Enumeration done mask
    $0e constant OTG1_HS_GLOBAL_ISOODRPM        \ [0x0e] Isochronous OUT packet dropped interrupt mask
    $0f constant OTG1_HS_GLOBAL_EOPFM           \ [0x0f] End of periodic frame interrupt mask
    $12 constant OTG1_HS_GLOBAL_IEPINT          \ [0x12] IN endpoints interrupt mask
    $13 constant OTG1_HS_GLOBAL_OEPINT          \ [0x13] OUT endpoints interrupt mask
    $14 constant OTG1_HS_GLOBAL_IISOIXFRM       \ [0x14] Incomplete isochronous IN transfer mask
    $15 constant OTG1_HS_GLOBAL_PXFRM_IISOOXFRM     \ [0x15] Incomplete periodic transfer mask
    $16 constant OTG1_HS_GLOBAL_FSUSPM          \ [0x16] Data fetch suspended mask
    $17 constant OTG1_HS_GLOBAL_RSTDE           \ [0x17] Reset detected interrupt mask
    $18 constant OTG1_HS_GLOBAL_PRTIM           \ [0x18] Host port interrupt mask
    $19 constant OTG1_HS_GLOBAL_HCIM            \ [0x19] Host channels interrupt mask
    $1a constant OTG1_HS_GLOBAL_PTXFEM          \ [0x1a] Periodic TxFIFO empty mask
    $1b constant OTG1_HS_GLOBAL_LPMINTM         \ [0x1b] LPM interrupt mask
    $1c constant OTG1_HS_GLOBAL_CIDSCHGM        \ [0x1c] Connector ID status change mask
    $1d constant OTG1_HS_GLOBAL_DISCINT         \ [0x1d] Disconnect detected interrupt mask
    $1e constant OTG1_HS_GLOBAL_SRQIM           \ [0x1e] Session request/new session detected interrupt mask
    $1f constant OTG1_HS_GLOBAL_WUIM            \ [0x1f] Resume/remote wakeup detected interrupt mask
  [then]


  [ifdef] OTG1_HS_GLOBAL_OTG_HS_GRXSTSR_Host_DEF
    \
    \ @brief OTG_HS Receive status debug read register (host mode)
    \ Address offset: 0x1C
    \ Reset value: 0x00000000
    \
    $00 constant OTG1_HS_GLOBAL_CHNUM           \ [0x00 : 4] Channel number
    $04 constant OTG1_HS_GLOBAL_BCNT            \ [0x04 : 11] Byte count
    $0f constant OTG1_HS_GLOBAL_DPID            \ [0x0f : 2] Data PID
    $11 constant OTG1_HS_GLOBAL_PKTSTS          \ [0x11 : 4] Packet status
  [then]


  [ifdef] OTG1_HS_GLOBAL_OTG_HS_GRXSTSR_Device_DEF
    \
    \ @brief OTG_HS Receive status debug read register (peripheral mode mode)
    \ Address offset: 0x1C
    \ Reset value: 0x00000000
    \
    $00 constant OTG1_HS_GLOBAL_EPNUM           \ [0x00 : 4] Endpoint number
    $04 constant OTG1_HS_GLOBAL_BCNT            \ [0x04 : 11] Byte count
    $0f constant OTG1_HS_GLOBAL_DPID            \ [0x0f : 2] Data PID
    $11 constant OTG1_HS_GLOBAL_PKTSTS          \ [0x11 : 4] Packet status
    $15 constant OTG1_HS_GLOBAL_FRMNUM          \ [0x15 : 4] Frame number
  [then]


  [ifdef] OTG1_HS_GLOBAL_OTG_HS_GRXSTSP_Host_DEF
    \
    \ @brief OTG_HS status read and pop register (host mode)
    \ Address offset: 0x20
    \ Reset value: 0x00000000
    \
    $00 constant OTG1_HS_GLOBAL_CHNUM           \ [0x00 : 4] Channel number
    $04 constant OTG1_HS_GLOBAL_BCNT            \ [0x04 : 11] Byte count
    $0f constant OTG1_HS_GLOBAL_DPID            \ [0x0f : 2] Data PID
    $11 constant OTG1_HS_GLOBAL_PKTSTS          \ [0x11 : 4] Packet status
  [then]


  [ifdef] OTG1_HS_GLOBAL_OTG_HS_GRXSTSP_Device_DEF
    \
    \ @brief OTG_HS status read and pop register (peripheral mode)
    \ Address offset: 0x20
    \ Reset value: 0x00000000
    \
    $00 constant OTG1_HS_GLOBAL_EPNUM           \ [0x00 : 4] Endpoint number
    $04 constant OTG1_HS_GLOBAL_BCNT            \ [0x04 : 11] Byte count
    $0f constant OTG1_HS_GLOBAL_DPID            \ [0x0f : 2] Data PID
    $11 constant OTG1_HS_GLOBAL_PKTSTS          \ [0x11 : 4] Packet status
    $15 constant OTG1_HS_GLOBAL_FRMNUM          \ [0x15 : 4] Frame number
  [then]


  [ifdef] OTG1_HS_GLOBAL_OTG_HS_GRXFSIZ_DEF
    \
    \ @brief OTG_HS Receive FIFO size register
    \ Address offset: 0x24
    \ Reset value: 0x00000200
    \
    $00 constant OTG1_HS_GLOBAL_RXFD            \ [0x00 : 16] RxFIFO depth
  [then]


  [ifdef] OTG1_HS_GLOBAL_OTG_HS_HNPTXFSIZ_Host_DEF
    \
    \ @brief OTG_HS nonperiodic transmit FIFO size register (host mode)
    \ Address offset: 0x28
    \ Reset value: 0x00000200
    \
    $00 constant OTG1_HS_GLOBAL_NPTXFSA         \ [0x00 : 16] Nonperiodic transmit RAM start address
    $10 constant OTG1_HS_GLOBAL_NPTXFD          \ [0x10 : 16] Nonperiodic TxFIFO depth
  [then]


  [ifdef] OTG1_HS_GLOBAL_OTG_HS_DIEPTXF0_Device_DEF
    \
    \ @brief Endpoint 0 transmit FIFO size (peripheral mode)
    \ Address offset: 0x28
    \ Reset value: 0x00000200
    \
    $00 constant OTG1_HS_GLOBAL_TX0FSA          \ [0x00 : 16] Endpoint 0 transmit RAM start address
    $10 constant OTG1_HS_GLOBAL_TX0FD           \ [0x10 : 16] Endpoint 0 TxFIFO depth
  [then]


  [ifdef] OTG1_HS_GLOBAL_OTG_HS_GNPTXSTS_DEF
    \
    \ @brief OTG_HS nonperiodic transmit FIFO/queue status register
    \ Address offset: 0x2C
    \ Reset value: 0x00080200
    \
    $00 constant OTG1_HS_GLOBAL_NPTXFSAV        \ [0x00 : 16] Nonperiodic TxFIFO space available
    $10 constant OTG1_HS_GLOBAL_NPTQXSAV        \ [0x10 : 8] Nonperiodic transmit request queue space available
    $18 constant OTG1_HS_GLOBAL_NPTXQTOP        \ [0x18 : 7] Top of the nonperiodic transmit request queue
  [then]


  [ifdef] OTG1_HS_GLOBAL_OTG_HS_GCCFG_DEF
    \
    \ @brief OTG_HS general core configuration register
    \ Address offset: 0x38
    \ Reset value: 0x00000000
    \
    $00 constant OTG1_HS_GLOBAL_DCDET           \ [0x00] Data contact detection (DCD) status
    $01 constant OTG1_HS_GLOBAL_PDET            \ [0x01] Primary detection (PD) status
    $02 constant OTG1_HS_GLOBAL_SDET            \ [0x02] Secondary detection (SD) status
    $03 constant OTG1_HS_GLOBAL_PS2DET          \ [0x03] DM pull-up detection status
    $10 constant OTG1_HS_GLOBAL_PWRDWN          \ [0x10] Power down
    $11 constant OTG1_HS_GLOBAL_BCDEN           \ [0x11] Battery charging detector (BCD) enable
    $12 constant OTG1_HS_GLOBAL_DCDEN           \ [0x12] Data contact detection (DCD) mode enable
    $13 constant OTG1_HS_GLOBAL_PDEN            \ [0x13] Primary detection (PD) mode enable
    $14 constant OTG1_HS_GLOBAL_SDEN            \ [0x14] Secondary detection (SD) mode enable
    $15 constant OTG1_HS_GLOBAL_VBDEN           \ [0x15] USB VBUS detection enable
  [then]


  [ifdef] OTG1_HS_GLOBAL_OTG_HS_CID_DEF
    \
    \ @brief OTG_HS core ID register
    \ Address offset: 0x3C
    \ Reset value: 0x00001200
    \
    $00 constant OTG1_HS_GLOBAL_PRODUCT_ID      \ [0x00 : 32] Product ID field
  [then]


  [ifdef] OTG1_HS_GLOBAL_OTG_HS_GLPMCFG_DEF
    \
    \ @brief OTG core LPM configuration register
    \ Address offset: 0x54
    \ Reset value: 0x00000000
    \
    $00 constant OTG1_HS_GLOBAL_LPMEN           \ [0x00] LPM support enable
    $01 constant OTG1_HS_GLOBAL_LPMACK          \ [0x01] LPM token acknowledge enable
    $02 constant OTG1_HS_GLOBAL_BESL            \ [0x02 : 4] Best effort service latency
    $06 constant OTG1_HS_GLOBAL_REMWAKE         \ [0x06] bRemoteWake value
    $07 constant OTG1_HS_GLOBAL_L1SSEN          \ [0x07] L1 Shallow Sleep enable
    $08 constant OTG1_HS_GLOBAL_BESLTHRS        \ [0x08 : 4] BESL threshold
    $0c constant OTG1_HS_GLOBAL_L1DSEN          \ [0x0c] L1 deep sleep enable
    $0d constant OTG1_HS_GLOBAL_LPMRST          \ [0x0d : 2] LPM response
    $0f constant OTG1_HS_GLOBAL_SLPSTS          \ [0x0f] Port sleep status
    $10 constant OTG1_HS_GLOBAL_L1RSMOK         \ [0x10] Sleep State Resume OK
    $11 constant OTG1_HS_GLOBAL_LPMCHIDX        \ [0x11 : 4] LPM Channel Index
    $15 constant OTG1_HS_GLOBAL_LPMRCNT         \ [0x15 : 3] LPM retry count
    $18 constant OTG1_HS_GLOBAL_SNDLPM          \ [0x18] Send LPM transaction
    $19 constant OTG1_HS_GLOBAL_LPMRCNTSTS      \ [0x19 : 3] LPM retry count status
    $1c constant OTG1_HS_GLOBAL_ENBESL          \ [0x1c] Enable best effort service latency
  [then]


  [ifdef] OTG1_HS_GLOBAL_OTG_HS_HPTXFSIZ_DEF
    \
    \ @brief OTG_HS Host periodic transmit FIFO size register
    \ Address offset: 0x100
    \ Reset value: 0x02000600
    \
    $00 constant OTG1_HS_GLOBAL_PTXSA           \ [0x00 : 16] Host periodic TxFIFO start address
    $10 constant OTG1_HS_GLOBAL_PTXFD           \ [0x10 : 16] Host periodic TxFIFO depth
  [then]


  [ifdef] OTG1_HS_GLOBAL_OTG_HS_DIEPTXF1_DEF
    \
    \ @brief OTG_HS device IN endpoint transmit FIFO size register
    \ Address offset: 0x104
    \ Reset value: 0x02000400
    \
    $00 constant OTG1_HS_GLOBAL_INEPTXSA        \ [0x00 : 16] IN endpoint FIFOx transmit RAM start address
    $10 constant OTG1_HS_GLOBAL_INEPTXFD        \ [0x10 : 16] IN endpoint TxFIFO depth
  [then]


  [ifdef] OTG1_HS_GLOBAL_OTG_HS_DIEPTXF2_DEF
    \
    \ @brief OTG_HS device IN endpoint transmit FIFO size register
    \ Address offset: 0x108
    \ Reset value: 0x02000600
    \
    $00 constant OTG1_HS_GLOBAL_INEPTXSA        \ [0x00 : 16] IN endpoint FIFOx transmit RAM start address
    $10 constant OTG1_HS_GLOBAL_INEPTXFD        \ [0x10 : 16] IN endpoint TxFIFO depth
  [then]


  [ifdef] OTG1_HS_GLOBAL_OTG_HS_DIEPTXF3_DEF
    \
    \ @brief OTG_HS device IN endpoint transmit FIFO size register
    \ Address offset: 0x10C
    \ Reset value: 0x02000800
    \
    $00 constant OTG1_HS_GLOBAL_INEPTXSA        \ [0x00 : 16] IN endpoint FIFOx transmit RAM start address
    $10 constant OTG1_HS_GLOBAL_INEPTXFD        \ [0x10 : 16] IN endpoint TxFIFO depth
  [then]


  [ifdef] OTG1_HS_GLOBAL_OTG_HS_DIEPTXF4_DEF
    \
    \ @brief OTG_HS device IN endpoint transmit FIFO size register
    \ Address offset: 0x110
    \ Reset value: 0x02000A00
    \
    $00 constant OTG1_HS_GLOBAL_INEPTXSA        \ [0x00 : 16] IN endpoint FIFOx transmit RAM start address
    $10 constant OTG1_HS_GLOBAL_INEPTXFD        \ [0x10 : 16] IN endpoint TxFIFO depth
  [then]


  [ifdef] OTG1_HS_GLOBAL_OTG_HS_DIEPTXF5_DEF
    \
    \ @brief OTG_HS device IN endpoint transmit FIFO size register
    \ Address offset: 0x114
    \ Reset value: 0x02000C00
    \
    $00 constant OTG1_HS_GLOBAL_INEPTXSA        \ [0x00 : 16] IN endpoint FIFOx transmit RAM start address
    $10 constant OTG1_HS_GLOBAL_INEPTXFD        \ [0x10 : 16] IN endpoint TxFIFO depth
  [then]


  [ifdef] OTG1_HS_GLOBAL_OTG_HS_DIEPTXF6_DEF
    \
    \ @brief OTG_HS device IN endpoint transmit FIFO size register
    \ Address offset: 0x118
    \ Reset value: 0x02000E00
    \
    $00 constant OTG1_HS_GLOBAL_INEPTXSA        \ [0x00 : 16] IN endpoint FIFOx transmit RAM start address
    $10 constant OTG1_HS_GLOBAL_INEPTXFD        \ [0x10 : 16] IN endpoint TxFIFO depth
  [then]


  [ifdef] OTG1_HS_GLOBAL_OTG_HS_DIEPTXF7_DEF
    \
    \ @brief OTG_HS device IN endpoint transmit FIFO size register
    \ Address offset: 0x11C
    \ Reset value: 0x02001000
    \
    $00 constant OTG1_HS_GLOBAL_INEPTXSA        \ [0x00 : 16] IN endpoint FIFOx transmit RAM start address
    $10 constant OTG1_HS_GLOBAL_INEPTXFD        \ [0x10 : 16] IN endpoint TxFIFO depth
  [then]


  [ifdef] OTG1_HS_GLOBAL_OTG_DIEPTXF8_DEF
    \
    \ @brief IN endpoint FIFOx transmit RAM start address This field contains the memory start address for IN endpoint transmit FIFOx. The address must be aligned with a 32-bit memory location.
    \ Address offset: 0x120
    \ Reset value: 0x02001200
    \
    $00 constant OTG1_HS_GLOBAL_INEPTXSA        \ [0x00 : 16] IN endpoint FIFOx transmit RAM start address This field contains the memory start address for IN endpoint transmit FIFOx. The address must be aligned with a 32-bit memory location.
    $10 constant OTG1_HS_GLOBAL_INEPTXFD        \ [0x10 : 16] IN endpoint Tx FIFO depth This value is in terms of 32-bit words. Minimum value is 16
  [then]

  \
  \ @brief USB 1 on the go high speed
  \
  $00 constant OTG1_HS_GLOBAL_OTG_HS_GOTGCTL    \ OTG_HS control and status register
  $04 constant OTG1_HS_GLOBAL_OTG_HS_GOTGINT    \ OTG_HS interrupt register
  $08 constant OTG1_HS_GLOBAL_OTG_HS_GAHBCFG    \ OTG_HS AHB configuration register
  $0C constant OTG1_HS_GLOBAL_OTG_HS_GUSBCFG    \ OTG_HS USB configuration register
  $10 constant OTG1_HS_GLOBAL_OTG_HS_GRSTCTL    \ OTG_HS reset register
  $14 constant OTG1_HS_GLOBAL_OTG_HS_GINTSTS    \ OTG_HS core interrupt register
  $18 constant OTG1_HS_GLOBAL_OTG_HS_GINTMSK    \ OTG_HS interrupt mask register
  $1C constant OTG1_HS_GLOBAL_OTG_HS_GRXSTSR_HOST    \ OTG_HS Receive status debug read register (host mode)
  $1C constant OTG1_HS_GLOBAL_OTG_HS_GRXSTSR_DEVICE    \ OTG_HS Receive status debug read register (peripheral mode mode)
  $20 constant OTG1_HS_GLOBAL_OTG_HS_GRXSTSP_HOST    \ OTG_HS status read and pop register (host mode)
  $20 constant OTG1_HS_GLOBAL_OTG_HS_GRXSTSP_DEVICE    \ OTG_HS status read and pop register (peripheral mode)
  $24 constant OTG1_HS_GLOBAL_OTG_HS_GRXFSIZ    \ OTG_HS Receive FIFO size register
  $28 constant OTG1_HS_GLOBAL_OTG_HS_HNPTXFSIZ_HOST    \ OTG_HS nonperiodic transmit FIFO size register (host mode)
  $28 constant OTG1_HS_GLOBAL_OTG_HS_DIEPTXF0_DEVICE    \ Endpoint 0 transmit FIFO size (peripheral mode)
  $2C constant OTG1_HS_GLOBAL_OTG_HS_GNPTXSTS    \ OTG_HS nonperiodic transmit FIFO/queue status register
  $38 constant OTG1_HS_GLOBAL_OTG_HS_GCCFG    \ OTG_HS general core configuration register
  $3C constant OTG1_HS_GLOBAL_OTG_HS_CID    \ OTG_HS core ID register
  $54 constant OTG1_HS_GLOBAL_OTG_HS_GLPMCFG    \ OTG core LPM configuration register
  $100 constant OTG1_HS_GLOBAL_OTG_HS_HPTXFSIZ    \ OTG_HS Host periodic transmit FIFO size register
  $104 constant OTG1_HS_GLOBAL_OTG_HS_DIEPTXF1    \ OTG_HS device IN endpoint transmit FIFO size register
  $108 constant OTG1_HS_GLOBAL_OTG_HS_DIEPTXF2    \ OTG_HS device IN endpoint transmit FIFO size register
  $10C constant OTG1_HS_GLOBAL_OTG_HS_DIEPTXF3    \ OTG_HS device IN endpoint transmit FIFO size register
  $110 constant OTG1_HS_GLOBAL_OTG_HS_DIEPTXF4    \ OTG_HS device IN endpoint transmit FIFO size register
  $114 constant OTG1_HS_GLOBAL_OTG_HS_DIEPTXF5    \ OTG_HS device IN endpoint transmit FIFO size register
  $118 constant OTG1_HS_GLOBAL_OTG_HS_DIEPTXF6    \ OTG_HS device IN endpoint transmit FIFO size register
  $11C constant OTG1_HS_GLOBAL_OTG_HS_DIEPTXF7    \ OTG_HS device IN endpoint transmit FIFO size register
  $120 constant OTG1_HS_GLOBAL_OTG_DIEPTXF8    \ IN endpoint FIFOx transmit RAM start address This field contains the memory start address for IN endpoint transmit FIFOx. The address must be aligned with a 32-bit memory location.

: OTG1_HS_GLOBAL_DEF ; [then]
