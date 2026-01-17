\
\ @file usb_otg_global.fs
\ @brief USB on the go full speed
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] USB_OTG_GLOBAL_DEF

  [ifdef] USB_OTG_GLOBAL_FS_GOTGCTL_DEF
    \
    \ @brief OTG_FS control and status register (OTG_FS_GOTGCTL)
    \ Address offset: 0x00
    \ Reset value: 0x00000800
    \
    $00 constant USB_OTG_GLOBAL_SRQSCS          \ [0x00] Session request success
    $01 constant USB_OTG_GLOBAL_SRQ             \ [0x01] Session request
    $08 constant USB_OTG_GLOBAL_HNGSCS          \ [0x08] Host negotiation success
    $09 constant USB_OTG_GLOBAL_HNPRQ           \ [0x09] HNP request
    $0a constant USB_OTG_GLOBAL_HSHNPEN         \ [0x0a] Host set HNP enable
    $0b constant USB_OTG_GLOBAL_DHNPEN          \ [0x0b] Device HNP enabled
    $10 constant USB_OTG_GLOBAL_CIDSTS          \ [0x10] Connector ID status
    $11 constant USB_OTG_GLOBAL_DBCT            \ [0x11] Long/short debounce time
    $12 constant USB_OTG_GLOBAL_ASVLD           \ [0x12] A-session valid
    $13 constant USB_OTG_GLOBAL_BSVLD           \ [0x13] B-session valid
  [then]


  [ifdef] USB_OTG_GLOBAL_FS_GOTGINT_DEF
    \
    \ @brief OTG_FS interrupt register (OTG_FS_GOTGINT)
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $02 constant USB_OTG_GLOBAL_SEDET           \ [0x02] Session end detected
    $08 constant USB_OTG_GLOBAL_SRSSCHG         \ [0x08] Session request success status change
    $09 constant USB_OTG_GLOBAL_HNSSCHG         \ [0x09] Host negotiation success status change
    $11 constant USB_OTG_GLOBAL_HNGDET          \ [0x11] Host negotiation detected
    $12 constant USB_OTG_GLOBAL_ADTOCHG         \ [0x12] A-device timeout change
    $13 constant USB_OTG_GLOBAL_DBCDNE          \ [0x13] Debounce done
  [then]


  [ifdef] USB_OTG_GLOBAL_FS_GAHBCFG_DEF
    \
    \ @brief OTG_FS AHB configuration register (OTG_FS_GAHBCFG)
    \ Address offset: 0x08
    \ Reset value: 0x00000000
    \
    $00 constant USB_OTG_GLOBAL_GINT            \ [0x00] Global interrupt mask
    $07 constant USB_OTG_GLOBAL_TXFELVL         \ [0x07] TxFIFO empty level
    $08 constant USB_OTG_GLOBAL_PTXFELVL        \ [0x08] Periodic TxFIFO empty level
  [then]


  [ifdef] USB_OTG_GLOBAL_FS_GUSBCFG_DEF
    \
    \ @brief OTG_FS USB configuration register (OTG_FS_GUSBCFG)
    \ Address offset: 0x0C
    \ Reset value: 0x00000A00
    \
    $00 constant USB_OTG_GLOBAL_TOCAL           \ [0x00 : 3] FS timeout calibration
    $07 constant USB_OTG_GLOBAL_PHYSEL          \ [0x07] Full Speed serial transceiver select
    $08 constant USB_OTG_GLOBAL_SRPCAP          \ [0x08] SRP-capable
    $09 constant USB_OTG_GLOBAL_HNPCAP          \ [0x09] HNP-capable
    $0a constant USB_OTG_GLOBAL_TRDT            \ [0x0a : 4] USB turnaround time
    $1d constant USB_OTG_GLOBAL_FHMOD           \ [0x1d] Force host mode
    $1e constant USB_OTG_GLOBAL_FDMOD           \ [0x1e] Force device mode
    $1f constant USB_OTG_GLOBAL_CTXPKT          \ [0x1f] Corrupt Tx packet
  [then]


  [ifdef] USB_OTG_GLOBAL_FS_GRSTCTL_DEF
    \
    \ @brief OTG_FS reset register (OTG_FS_GRSTCTL)
    \ Address offset: 0x10
    \ Reset value: 0x20000000
    \
    $00 constant USB_OTG_GLOBAL_CSRST           \ [0x00] Core soft reset
    $01 constant USB_OTG_GLOBAL_HSRST           \ [0x01] HCLK soft reset
    $02 constant USB_OTG_GLOBAL_FCRST           \ [0x02] Host frame counter reset
    $04 constant USB_OTG_GLOBAL_RXFFLSH         \ [0x04] RxFIFO flush
    $05 constant USB_OTG_GLOBAL_TXFFLSH         \ [0x05] TxFIFO flush
    $06 constant USB_OTG_GLOBAL_TXFNUM          \ [0x06 : 5] TxFIFO number
    $1f constant USB_OTG_GLOBAL_AHBIDL          \ [0x1f] AHB master idle
  [then]


  [ifdef] USB_OTG_GLOBAL_FS_GINTSTS_DEF
    \
    \ @brief OTG_FS core interrupt register (OTG_FS_GINTSTS)
    \ Address offset: 0x14
    \ Reset value: 0x04000020
    \
    $00 constant USB_OTG_GLOBAL_CMOD            \ [0x00] Current mode of operation
    $01 constant USB_OTG_GLOBAL_MMIS            \ [0x01] Mode mismatch interrupt
    $02 constant USB_OTG_GLOBAL_OTGINT          \ [0x02] OTG interrupt
    $03 constant USB_OTG_GLOBAL_SOF             \ [0x03] Start of frame
    $04 constant USB_OTG_GLOBAL_RXFLVL          \ [0x04] RxFIFO non-empty
    $05 constant USB_OTG_GLOBAL_NPTXFE          \ [0x05] Non-periodic TxFIFO empty
    $06 constant USB_OTG_GLOBAL_GINAKEFF        \ [0x06] Global IN non-periodic NAK effective
    $07 constant USB_OTG_GLOBAL_GOUTNAKEFF      \ [0x07] Global OUT NAK effective
    $0a constant USB_OTG_GLOBAL_ESUSP           \ [0x0a] Early suspend
    $0b constant USB_OTG_GLOBAL_USBSUSP         \ [0x0b] USB suspend
    $0c constant USB_OTG_GLOBAL_USBRST          \ [0x0c] USB reset
    $0d constant USB_OTG_GLOBAL_ENUMDNE         \ [0x0d] Enumeration done
    $0e constant USB_OTG_GLOBAL_ISOODRP         \ [0x0e] Isochronous OUT packet dropped interrupt
    $0f constant USB_OTG_GLOBAL_EOPF            \ [0x0f] End of periodic frame interrupt
    $12 constant USB_OTG_GLOBAL_IEPINT          \ [0x12] IN endpoint interrupt
    $13 constant USB_OTG_GLOBAL_OEPINT          \ [0x13] OUT endpoint interrupt
    $14 constant USB_OTG_GLOBAL_IISOIXFR        \ [0x14] Incomplete isochronous IN transfer
    $15 constant USB_OTG_GLOBAL_IPXFR_INCOMPISOOUT     \ [0x15] Incomplete periodic transfer(Host mode)/Incomplete isochronous OUT transfer(Device mode)
    $18 constant USB_OTG_GLOBAL_HPRTINT         \ [0x18] Host port interrupt
    $19 constant USB_OTG_GLOBAL_HCINT           \ [0x19] Host channels interrupt
    $1a constant USB_OTG_GLOBAL_PTXFE           \ [0x1a] Periodic TxFIFO empty
    $1c constant USB_OTG_GLOBAL_CIDSCHG         \ [0x1c] Connector ID status change
    $1d constant USB_OTG_GLOBAL_DISCINT         \ [0x1d] Disconnect detected interrupt
    $1e constant USB_OTG_GLOBAL_SRQINT          \ [0x1e] Session request/new session detected interrupt
    $1f constant USB_OTG_GLOBAL_WKUPINT         \ [0x1f] Resume/remote wakeup detected interrupt
  [then]


  [ifdef] USB_OTG_GLOBAL_FS_GINTMSK_DEF
    \
    \ @brief OTG_FS interrupt mask register (OTG_FS_GINTMSK)
    \ Address offset: 0x18
    \ Reset value: 0x00000000
    \
    $01 constant USB_OTG_GLOBAL_MMISM           \ [0x01] Mode mismatch interrupt mask
    $02 constant USB_OTG_GLOBAL_OTGINT          \ [0x02] OTG interrupt mask
    $03 constant USB_OTG_GLOBAL_SOFM            \ [0x03] Start of frame mask
    $04 constant USB_OTG_GLOBAL_RXFLVLM         \ [0x04] Receive FIFO non-empty mask
    $05 constant USB_OTG_GLOBAL_NPTXFEM         \ [0x05] Non-periodic TxFIFO empty mask
    $06 constant USB_OTG_GLOBAL_GINAKEFFM       \ [0x06] Global non-periodic IN NAK effective mask
    $07 constant USB_OTG_GLOBAL_GONAKEFFM       \ [0x07] Global OUT NAK effective mask
    $0a constant USB_OTG_GLOBAL_ESUSPM          \ [0x0a] Early suspend mask
    $0b constant USB_OTG_GLOBAL_USBSUSPM        \ [0x0b] USB suspend mask
    $0c constant USB_OTG_GLOBAL_USBRST          \ [0x0c] USB reset mask
    $0d constant USB_OTG_GLOBAL_ENUMDNEM        \ [0x0d] Enumeration done mask
    $0e constant USB_OTG_GLOBAL_ISOODRPM        \ [0x0e] Isochronous OUT packet dropped interrupt mask
    $0f constant USB_OTG_GLOBAL_EOPFM           \ [0x0f] End of periodic frame interrupt mask
    $11 constant USB_OTG_GLOBAL_EPMISM          \ [0x11] Endpoint mismatch interrupt mask
    $12 constant USB_OTG_GLOBAL_IEPINT          \ [0x12] IN endpoints interrupt mask
    $13 constant USB_OTG_GLOBAL_OEPINT          \ [0x13] OUT endpoints interrupt mask
    $14 constant USB_OTG_GLOBAL_IISOIXFRM       \ [0x14] Incomplete isochronous IN transfer mask
    $15 constant USB_OTG_GLOBAL_IPXFRM_IISOOXFRM     \ [0x15] Incomplete periodic transfer mask(Host mode)/Incomplete isochronous OUT transfer mask(Device mode)
    $18 constant USB_OTG_GLOBAL_PRTIM           \ [0x18] Host port interrupt mask
    $19 constant USB_OTG_GLOBAL_HCIM            \ [0x19] Host channels interrupt mask
    $1a constant USB_OTG_GLOBAL_PTXFEM          \ [0x1a] Periodic TxFIFO empty mask
    $1c constant USB_OTG_GLOBAL_CIDSCHGM        \ [0x1c] Connector ID status change mask
    $1d constant USB_OTG_GLOBAL_DISCINT         \ [0x1d] Disconnect detected interrupt mask
    $1e constant USB_OTG_GLOBAL_SRQIM           \ [0x1e] Session request/new session detected interrupt mask
    $1f constant USB_OTG_GLOBAL_WUIM            \ [0x1f] Resume/remote wakeup detected interrupt mask
  [then]


  [ifdef] USB_OTG_GLOBAL_FS_GRXSTSR_Device_DEF
    \
    \ @brief OTG_FS Receive status debug read(Device mode)
    \ Address offset: 0x1C
    \ Reset value: 0x00000000
    \
    $00 constant USB_OTG_GLOBAL_EPNUM           \ [0x00 : 4] Endpoint number
    $04 constant USB_OTG_GLOBAL_BCNT            \ [0x04 : 11] Byte count
    $0f constant USB_OTG_GLOBAL_DPID            \ [0x0f : 2] Data PID
    $11 constant USB_OTG_GLOBAL_PKTSTS          \ [0x11 : 4] Packet status
    $15 constant USB_OTG_GLOBAL_FRMNUM          \ [0x15 : 4] Frame number
  [then]


  [ifdef] USB_OTG_GLOBAL_FS_GRXSTSR_Host_DEF
    \
    \ @brief OTG_FS Receive status debug read(Host mode)
    \ Address offset: 0x1C
    \ Reset value: 0x00000000
    \
    $00 constant USB_OTG_GLOBAL_EPNUM           \ [0x00 : 4] Endpoint number
    $04 constant USB_OTG_GLOBAL_BCNT            \ [0x04 : 11] Byte count
    $0f constant USB_OTG_GLOBAL_DPID            \ [0x0f : 2] Data PID
    $11 constant USB_OTG_GLOBAL_PKTSTS          \ [0x11 : 4] Packet status
    $15 constant USB_OTG_GLOBAL_FRMNUM          \ [0x15 : 4] Frame number
  [then]


  [ifdef] USB_OTG_GLOBAL_FS_GRXFSIZ_DEF
    \
    \ @brief OTG_FS Receive FIFO size register (OTG_FS_GRXFSIZ)
    \ Address offset: 0x24
    \ Reset value: 0x00000200
    \
    $00 constant USB_OTG_GLOBAL_RXFD            \ [0x00 : 16] RxFIFO depth
  [then]


  [ifdef] USB_OTG_GLOBAL_FS_GNPTXFSIZ_Device_DEF
    \
    \ @brief OTG_FS non-periodic transmit FIFO size register (Device mode)
    \ Address offset: 0x28
    \ Reset value: 0x00000200
    \
    $00 constant USB_OTG_GLOBAL_TX0FSA          \ [0x00 : 16] Endpoint 0 transmit RAM start address
    $10 constant USB_OTG_GLOBAL_TX0FD           \ [0x10 : 16] Endpoint 0 TxFIFO depth
  [then]


  [ifdef] USB_OTG_GLOBAL_FS_GNPTXFSIZ_Host_DEF
    \
    \ @brief OTG_FS non-periodic transmit FIFO size register (Host mode)
    \ Address offset: 0x28
    \ Reset value: 0x00000200
    \
    $00 constant USB_OTG_GLOBAL_NPTXFSA         \ [0x00 : 16] Non-periodic transmit RAM start address
    $10 constant USB_OTG_GLOBAL_NPTXFD          \ [0x10 : 16] Non-periodic TxFIFO depth
  [then]


  [ifdef] USB_OTG_GLOBAL_FS_GNPTXSTS_DEF
    \
    \ @brief OTG_FS non-periodic transmit FIFO/queue status register (OTG_FS_GNPTXSTS)
    \ Address offset: 0x2C
    \ Reset value: 0x00080200
    \
    $00 constant USB_OTG_GLOBAL_NPTXFSAV        \ [0x00 : 16] Non-periodic TxFIFO space available
    $10 constant USB_OTG_GLOBAL_NPTQXSAV        \ [0x10 : 8] Non-periodic transmit request queue space available
    $18 constant USB_OTG_GLOBAL_NPTXQTOP        \ [0x18 : 7] Top of the non-periodic transmit request queue
  [then]


  [ifdef] USB_OTG_GLOBAL_FS_GCCFG_DEF
    \
    \ @brief OTG_FS general core configuration register (OTG_FS_GCCFG)
    \ Address offset: 0x38
    \ Reset value: 0x00000000
    \
    $10 constant USB_OTG_GLOBAL_PWRDWN          \ [0x10] Power down
    $12 constant USB_OTG_GLOBAL_VBUSASEN        \ [0x12] Enable the VBUS sensing device
    $13 constant USB_OTG_GLOBAL_VBUSBSEN        \ [0x13] Enable the VBUS sensing device
    $14 constant USB_OTG_GLOBAL_SOFOUTEN        \ [0x14] SOF output enable
  [then]


  [ifdef] USB_OTG_GLOBAL_FS_CID_DEF
    \
    \ @brief core ID register
    \ Address offset: 0x3C
    \ Reset value: 0x00001000
    \
    $00 constant USB_OTG_GLOBAL_PRODUCT_ID      \ [0x00 : 32] Product ID field
  [then]


  [ifdef] USB_OTG_GLOBAL_FS_HPTXFSIZ_DEF
    \
    \ @brief OTG_FS Host periodic transmit FIFO size register (OTG_FS_HPTXFSIZ)
    \ Address offset: 0x100
    \ Reset value: 0x02000600
    \
    $00 constant USB_OTG_GLOBAL_PTXSA           \ [0x00 : 16] Host periodic TxFIFO start address
    $10 constant USB_OTG_GLOBAL_PTXFSIZ         \ [0x10 : 16] Host periodic TxFIFO depth
  [then]


  [ifdef] USB_OTG_GLOBAL_FS_DIEPTXF1_DEF
    \
    \ @brief OTG_FS device IN endpoint transmit FIFO size register (OTG_FS_DIEPTXF2)
    \ Address offset: 0x104
    \ Reset value: 0x02000400
    \
    $00 constant USB_OTG_GLOBAL_INEPTXSA        \ [0x00 : 16] IN endpoint FIFO2 transmit RAM start address
    $10 constant USB_OTG_GLOBAL_INEPTXFD        \ [0x10 : 16] IN endpoint TxFIFO depth
  [then]


  [ifdef] USB_OTG_GLOBAL_FS_DIEPTXF2_DEF
    \
    \ @brief OTG_FS device IN endpoint transmit FIFO size register (OTG_FS_DIEPTXF3)
    \ Address offset: 0x108
    \ Reset value: 0x02000400
    \
    $00 constant USB_OTG_GLOBAL_INEPTXSA        \ [0x00 : 16] IN endpoint FIFO3 transmit RAM start address
    $10 constant USB_OTG_GLOBAL_INEPTXFD        \ [0x10 : 16] IN endpoint TxFIFO depth
  [then]


  [ifdef] USB_OTG_GLOBAL_FS_DIEPTXF3_DEF
    \
    \ @brief OTG_FS device IN endpoint transmit FIFO size register (OTG_FS_DIEPTXF4)
    \ Address offset: 0x10C
    \ Reset value: 0x02000400
    \
    $00 constant USB_OTG_GLOBAL_INEPTXSA        \ [0x00 : 16] IN endpoint FIFO4 transmit RAM start address
    $10 constant USB_OTG_GLOBAL_INEPTXFD        \ [0x10 : 16] IN endpoint TxFIFO depth
  [then]

  \
  \ @brief USB on the go full speed
  \
  $00 constant USB_OTG_GLOBAL_FS_GOTGCTL    \ OTG_FS control and status register (OTG_FS_GOTGCTL)
  $04 constant USB_OTG_GLOBAL_FS_GOTGINT    \ OTG_FS interrupt register (OTG_FS_GOTGINT)
  $08 constant USB_OTG_GLOBAL_FS_GAHBCFG    \ OTG_FS AHB configuration register (OTG_FS_GAHBCFG)
  $0C constant USB_OTG_GLOBAL_FS_GUSBCFG    \ OTG_FS USB configuration register (OTG_FS_GUSBCFG)
  $10 constant USB_OTG_GLOBAL_FS_GRSTCTL    \ OTG_FS reset register (OTG_FS_GRSTCTL)
  $14 constant USB_OTG_GLOBAL_FS_GINTSTS    \ OTG_FS core interrupt register (OTG_FS_GINTSTS)
  $18 constant USB_OTG_GLOBAL_FS_GINTMSK    \ OTG_FS interrupt mask register (OTG_FS_GINTMSK)
  $1C constant USB_OTG_GLOBAL_FS_GRXSTSR_DEVICE    \ OTG_FS Receive status debug read(Device mode)
  $1C constant USB_OTG_GLOBAL_FS_GRXSTSR_HOST    \ OTG_FS Receive status debug read(Host mode)
  $24 constant USB_OTG_GLOBAL_FS_GRXFSIZ    \ OTG_FS Receive FIFO size register (OTG_FS_GRXFSIZ)
  $28 constant USB_OTG_GLOBAL_FS_GNPTXFSIZ_DEVICE    \ OTG_FS non-periodic transmit FIFO size register (Device mode)
  $28 constant USB_OTG_GLOBAL_FS_GNPTXFSIZ_HOST    \ OTG_FS non-periodic transmit FIFO size register (Host mode)
  $2C constant USB_OTG_GLOBAL_FS_GNPTXSTS    \ OTG_FS non-periodic transmit FIFO/queue status register (OTG_FS_GNPTXSTS)
  $38 constant USB_OTG_GLOBAL_FS_GCCFG  \ OTG_FS general core configuration register (OTG_FS_GCCFG)
  $3C constant USB_OTG_GLOBAL_FS_CID    \ core ID register
  $100 constant USB_OTG_GLOBAL_FS_HPTXFSIZ    \ OTG_FS Host periodic transmit FIFO size register (OTG_FS_HPTXFSIZ)
  $104 constant USB_OTG_GLOBAL_FS_DIEPTXF1    \ OTG_FS device IN endpoint transmit FIFO size register (OTG_FS_DIEPTXF2)
  $108 constant USB_OTG_GLOBAL_FS_DIEPTXF2    \ OTG_FS device IN endpoint transmit FIFO size register (OTG_FS_DIEPTXF3)
  $10C constant USB_OTG_GLOBAL_FS_DIEPTXF3    \ OTG_FS device IN endpoint transmit FIFO size register (OTG_FS_DIEPTXF4)

: USB_OTG_GLOBAL_DEF ; [then]
