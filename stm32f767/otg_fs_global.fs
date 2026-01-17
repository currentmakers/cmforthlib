\
\ @file otg_fs_global.fs
\ @brief USB on the go full speed
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] OTG_FS_GLOBAL_DEF

  [ifdef] OTG_FS_GLOBAL_OTG_FS_GOTGCTL_DEF
    \
    \ @brief OTG_FS control and status register (OTG_FS_GOTGCTL)
    \ Address offset: 0x00
    \ Reset value: 0x00000800
    \
    $00 constant OTG_FS_GLOBAL_SRQSCS           \ [0x00] Session request success
    $01 constant OTG_FS_GLOBAL_SRQ              \ [0x01] Session request
    $02 constant OTG_FS_GLOBAL_VBVALOEN         \ [0x02] VBUS valid override enable
    $03 constant OTG_FS_GLOBAL_VBVALOVAL        \ [0x03] VBUS valid override value
    $04 constant OTG_FS_GLOBAL_AVALOEN          \ [0x04] A-peripheral session valid override enable
    $05 constant OTG_FS_GLOBAL_AVALOVAL         \ [0x05] A-peripheral session valid override value
    $06 constant OTG_FS_GLOBAL_BVALOEN          \ [0x06] B-peripheral session valid override enable
    $07 constant OTG_FS_GLOBAL_BVALOVAL         \ [0x07] B-peripheral session valid override value
    $08 constant OTG_FS_GLOBAL_HNGSCS           \ [0x08] Host negotiation success
    $09 constant OTG_FS_GLOBAL_HNPRQ            \ [0x09] HNP request
    $0a constant OTG_FS_GLOBAL_HSHNPEN          \ [0x0a] Host set HNP enable
    $0b constant OTG_FS_GLOBAL_DHNPEN           \ [0x0b] Device HNP enabled
    $0c constant OTG_FS_GLOBAL_EHEN             \ [0x0c] Embedded host enable
    $10 constant OTG_FS_GLOBAL_CIDSTS           \ [0x10] Connector ID status
    $11 constant OTG_FS_GLOBAL_DBCT             \ [0x11] Long/short debounce time
    $12 constant OTG_FS_GLOBAL_ASVLD            \ [0x12] A-session valid
    $13 constant OTG_FS_GLOBAL_BSVLD            \ [0x13] B-session valid
    $14 constant OTG_FS_GLOBAL_OTGVER           \ [0x14] OTG version
  [then]


  [ifdef] OTG_FS_GLOBAL_OTG_FS_GOTGINT_DEF
    \
    \ @brief OTG_FS interrupt register (OTG_FS_GOTGINT)
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $02 constant OTG_FS_GLOBAL_SEDET            \ [0x02] Session end detected
    $08 constant OTG_FS_GLOBAL_SRSSCHG          \ [0x08] Session request success status change
    $09 constant OTG_FS_GLOBAL_HNSSCHG          \ [0x09] Host negotiation success status change
    $11 constant OTG_FS_GLOBAL_HNGDET           \ [0x11] Host negotiation detected
    $12 constant OTG_FS_GLOBAL_ADTOCHG          \ [0x12] A-device timeout change
    $13 constant OTG_FS_GLOBAL_DBCDNE           \ [0x13] Debounce done
    $14 constant OTG_FS_GLOBAL_IDCHNG           \ [0x14] ID input pin changed
  [then]


  [ifdef] OTG_FS_GLOBAL_OTG_FS_GAHBCFG_DEF
    \
    \ @brief OTG_FS AHB configuration register (OTG_FS_GAHBCFG)
    \ Address offset: 0x08
    \ Reset value: 0x00000000
    \
    $00 constant OTG_FS_GLOBAL_GINT             \ [0x00] Global interrupt mask
    $07 constant OTG_FS_GLOBAL_TXFELVL          \ [0x07] TxFIFO empty level
    $08 constant OTG_FS_GLOBAL_PTXFELVL         \ [0x08] Periodic TxFIFO empty level
  [then]


  [ifdef] OTG_FS_GLOBAL_OTG_FS_GUSBCFG_DEF
    \
    \ @brief OTG_FS USB configuration register (OTG_FS_GUSBCFG)
    \ Address offset: 0x0C
    \ Reset value: 0x00000A00
    \
    $00 constant OTG_FS_GLOBAL_TOCAL            \ [0x00 : 3] FS timeout calibration
    $06 constant OTG_FS_GLOBAL_PHYSEL           \ [0x06] Full Speed serial transceiver select
    $08 constant OTG_FS_GLOBAL_SRPCAP           \ [0x08] SRP-capable
    $09 constant OTG_FS_GLOBAL_HNPCAP           \ [0x09] HNP-capable
    $0a constant OTG_FS_GLOBAL_TRDT             \ [0x0a : 4] USB turnaround time
    $1d constant OTG_FS_GLOBAL_FHMOD            \ [0x1d] Force host mode
    $1e constant OTG_FS_GLOBAL_FDMOD            \ [0x1e] Force device mode
  [then]


  [ifdef] OTG_FS_GLOBAL_OTG_FS_GRSTCTL_DEF
    \
    \ @brief OTG_FS reset register (OTG_FS_GRSTCTL)
    \ Address offset: 0x10
    \ Reset value: 0x20000000
    \
    $00 constant OTG_FS_GLOBAL_CSRST            \ [0x00] Core soft reset
    $01 constant OTG_FS_GLOBAL_HSRST            \ [0x01] HCLK soft reset
    $02 constant OTG_FS_GLOBAL_FCRST            \ [0x02] Host frame counter reset
    $04 constant OTG_FS_GLOBAL_RXFFLSH          \ [0x04] RxFIFO flush
    $05 constant OTG_FS_GLOBAL_TXFFLSH          \ [0x05] TxFIFO flush
    $06 constant OTG_FS_GLOBAL_TXFNUM           \ [0x06 : 5] TxFIFO number
    $1f constant OTG_FS_GLOBAL_AHBIDL           \ [0x1f] AHB master idle
  [then]


  [ifdef] OTG_FS_GLOBAL_OTG_FS_GINTSTS_DEF
    \
    \ @brief OTG_FS core interrupt register (OTG_FS_GINTSTS)
    \ Address offset: 0x14
    \ Reset value: 0x04000020
    \
    $00 constant OTG_FS_GLOBAL_CMOD             \ [0x00] Current mode of operation
    $01 constant OTG_FS_GLOBAL_MMIS             \ [0x01] Mode mismatch interrupt
    $02 constant OTG_FS_GLOBAL_OTGINT           \ [0x02] OTG interrupt
    $03 constant OTG_FS_GLOBAL_SOF              \ [0x03] Start of frame
    $04 constant OTG_FS_GLOBAL_RXFLVL           \ [0x04] RxFIFO non-empty
    $05 constant OTG_FS_GLOBAL_NPTXFE           \ [0x05] Non-periodic TxFIFO empty
    $06 constant OTG_FS_GLOBAL_GINAKEFF         \ [0x06] Global IN non-periodic NAK effective
    $07 constant OTG_FS_GLOBAL_GOUTNAKEFF       \ [0x07] Global OUT NAK effective
    $0a constant OTG_FS_GLOBAL_ESUSP            \ [0x0a] Early suspend
    $0b constant OTG_FS_GLOBAL_USBSUSP          \ [0x0b] USB suspend
    $0c constant OTG_FS_GLOBAL_USBRST           \ [0x0c] USB reset
    $0d constant OTG_FS_GLOBAL_ENUMDNE          \ [0x0d] Enumeration done
    $0e constant OTG_FS_GLOBAL_ISOODRP          \ [0x0e] Isochronous OUT packet dropped interrupt
    $0f constant OTG_FS_GLOBAL_EOPF             \ [0x0f] End of periodic frame interrupt
    $12 constant OTG_FS_GLOBAL_IEPINT           \ [0x12] IN endpoint interrupt
    $13 constant OTG_FS_GLOBAL_OEPINT           \ [0x13] OUT endpoint interrupt
    $14 constant OTG_FS_GLOBAL_IISOIXFR         \ [0x14] Incomplete isochronous IN transfer
    $15 constant OTG_FS_GLOBAL_IPXFR_INCOMPISOOUT     \ [0x15] Incomplete periodic transfer(Host mode)/Incomplete isochronous OUT transfer(Device mode)
    $17 constant OTG_FS_GLOBAL_RSTDET           \ [0x17] Reset detected interrupt
    $18 constant OTG_FS_GLOBAL_HPRTINT          \ [0x18] Host port interrupt
    $19 constant OTG_FS_GLOBAL_HCINT            \ [0x19] Host channels interrupt
    $1a constant OTG_FS_GLOBAL_PTXFE            \ [0x1a] Periodic TxFIFO empty
    $1c constant OTG_FS_GLOBAL_CIDSCHG          \ [0x1c] Connector ID status change
    $1d constant OTG_FS_GLOBAL_DISCINT          \ [0x1d] Disconnect detected interrupt
    $1e constant OTG_FS_GLOBAL_SRQINT           \ [0x1e] Session request/new session detected interrupt
    $1f constant OTG_FS_GLOBAL_WKUPINT          \ [0x1f] Resume/remote wakeup detected interrupt
  [then]


  [ifdef] OTG_FS_GLOBAL_OTG_FS_GINTMSK_DEF
    \
    \ @brief OTG_FS interrupt mask register (OTG_FS_GINTMSK)
    \ Address offset: 0x18
    \ Reset value: 0x00000000
    \
    $01 constant OTG_FS_GLOBAL_MMISM            \ [0x01] Mode mismatch interrupt mask
    $02 constant OTG_FS_GLOBAL_OTGINT           \ [0x02] OTG interrupt mask
    $03 constant OTG_FS_GLOBAL_SOFM             \ [0x03] Start of frame mask
    $04 constant OTG_FS_GLOBAL_RXFLVLM          \ [0x04] Receive FIFO non-empty mask
    $05 constant OTG_FS_GLOBAL_NPTXFEM          \ [0x05] Non-periodic TxFIFO empty mask
    $06 constant OTG_FS_GLOBAL_GINAKEFFM        \ [0x06] Global non-periodic IN NAK effective mask
    $07 constant OTG_FS_GLOBAL_GONAKEFFM        \ [0x07] Global OUT NAK effective mask
    $0a constant OTG_FS_GLOBAL_ESUSPM           \ [0x0a] Early suspend mask
    $0b constant OTG_FS_GLOBAL_USBSUSPM         \ [0x0b] USB suspend mask
    $0c constant OTG_FS_GLOBAL_USBRST           \ [0x0c] USB reset mask
    $0d constant OTG_FS_GLOBAL_ENUMDNEM         \ [0x0d] Enumeration done mask
    $0e constant OTG_FS_GLOBAL_ISOODRPM         \ [0x0e] Isochronous OUT packet dropped interrupt mask
    $0f constant OTG_FS_GLOBAL_EOPFM            \ [0x0f] End of periodic frame interrupt mask
    $12 constant OTG_FS_GLOBAL_IEPINT           \ [0x12] IN endpoints interrupt mask
    $13 constant OTG_FS_GLOBAL_OEPINT           \ [0x13] OUT endpoints interrupt mask
    $14 constant OTG_FS_GLOBAL_IISOIXFRM        \ [0x14] Incomplete isochronous IN transfer mask
    $15 constant OTG_FS_GLOBAL_IPXFRM_IISOOXFRM     \ [0x15] Incomplete periodic transfer mask(Host mode)/Incomplete isochronous OUT transfer mask(Device mode)
    $17 constant OTG_FS_GLOBAL_RSTDETM          \ [0x17] Reset detected interrupt mask
    $18 constant OTG_FS_GLOBAL_PRTIM            \ [0x18] Host port interrupt mask
    $19 constant OTG_FS_GLOBAL_HCIM             \ [0x19] Host channels interrupt mask
    $1a constant OTG_FS_GLOBAL_PTXFEM           \ [0x1a] Periodic TxFIFO empty mask
    $1b constant OTG_FS_GLOBAL_LPMIN            \ [0x1b] LPM interrupt mask
    $1c constant OTG_FS_GLOBAL_CIDSCHGM         \ [0x1c] Connector ID status change mask
    $1d constant OTG_FS_GLOBAL_DISCINT          \ [0x1d] Disconnect detected interrupt mask
    $1e constant OTG_FS_GLOBAL_SRQIM            \ [0x1e] Session request/new session detected interrupt mask
    $1f constant OTG_FS_GLOBAL_WUIM             \ [0x1f] Resume/remote wakeup detected interrupt mask
  [then]


  [ifdef] OTG_FS_GLOBAL_OTG_FS_GRXSTSR_Device_DEF
    \
    \ @brief OTG_FS Receive status debug read(Device mode)
    \ Address offset: 0x1C
    \ Reset value: 0x00000000
    \
    $00 constant OTG_FS_GLOBAL_EPNUM            \ [0x00 : 4] Endpoint number
    $04 constant OTG_FS_GLOBAL_BCNT             \ [0x04 : 11] Byte count
    $0f constant OTG_FS_GLOBAL_DPID             \ [0x0f : 2] Data PID
    $11 constant OTG_FS_GLOBAL_PKTSTS           \ [0x11 : 4] Packet status
    $15 constant OTG_FS_GLOBAL_FRMNUM           \ [0x15 : 4] Frame number
  [then]


  [ifdef] OTG_FS_GLOBAL_OTG_FS_GRXSTSR_Host_DEF
    \
    \ @brief OTG_FS Receive status debug read(Host mode)
    \ Address offset: 0x1C
    \ Reset value: 0x00000000
    \
    $00 constant OTG_FS_GLOBAL_CHNUM            \ [0x00 : 4] Endpoint number
    $04 constant OTG_FS_GLOBAL_BCNT             \ [0x04 : 11] Byte count
    $0f constant OTG_FS_GLOBAL_DPID             \ [0x0f : 2] Data PID
    $11 constant OTG_FS_GLOBAL_PKTSTS           \ [0x11 : 4] Packet status
  [then]


  [ifdef] OTG_FS_GLOBAL_OTG_FS_GRXSTSP_Device_DEF
    \
    \ @brief OTG status read and pop register (Device mode)
    \ Address offset: 0x20
    \ Reset value: 0x02000400
    \
    $00 constant OTG_FS_GLOBAL_EPNUM            \ [0x00 : 4] Endpoint number
    $04 constant OTG_FS_GLOBAL_BCNT             \ [0x04 : 11] Byte count
    $0f constant OTG_FS_GLOBAL_DPID             \ [0x0f : 2] Data PID
    $11 constant OTG_FS_GLOBAL_PKTSTS           \ [0x11 : 4] Packet status
    $15 constant OTG_FS_GLOBAL_FRMNUM           \ [0x15 : 4] Frame number
  [then]


  [ifdef] OTG_FS_GLOBAL_OTG_FS_GRXSTSP_Host_DEF
    \
    \ @brief OTG status read and pop register (Host mode)
    \ Address offset: 0x20
    \ Reset value: 0x02000400
    \
    $00 constant OTG_FS_GLOBAL_CHNUM            \ [0x00 : 4] Channel number
    $04 constant OTG_FS_GLOBAL_BCNT             \ [0x04 : 11] Byte count
    $0f constant OTG_FS_GLOBAL_DPID             \ [0x0f : 2] Data PID
    $11 constant OTG_FS_GLOBAL_PKTSTS           \ [0x11 : 4] Packet status
  [then]


  [ifdef] OTG_FS_GLOBAL_OTG_FS_GRXFSIZ_DEF
    \
    \ @brief OTG_FS Receive FIFO size register (OTG_FS_GRXFSIZ)
    \ Address offset: 0x24
    \ Reset value: 0x00000200
    \
    $00 constant OTG_FS_GLOBAL_RXFD             \ [0x00 : 16] RxFIFO depth
  [then]


  [ifdef] OTG_FS_GLOBAL_OTG_FS_DIEPTXF0_Device_DEF
    \
    \ @brief OTG_FS Endpoint 0 Transmit FIFO size
    \ Address offset: 0x28
    \ Reset value: 0x00000200
    \
    $00 constant OTG_FS_GLOBAL_TX0FSA           \ [0x00 : 16] Endpoint 0 transmit RAM start address
    $10 constant OTG_FS_GLOBAL_TX0FD            \ [0x10 : 16] Endpoint 0 TxFIFO depth
  [then]


  [ifdef] OTG_FS_GLOBAL_OTG_FS_HNPTXFSIZ_Host_DEF
    \
    \ @brief OTG_FS Host non-periodic transmit FIFO size register
    \ Address offset: 0x28
    \ Reset value: 0x00000200
    \
    $00 constant OTG_FS_GLOBAL_NPTXFSA          \ [0x00 : 16] Non-periodic transmit RAM start address
    $10 constant OTG_FS_GLOBAL_NPTXFD           \ [0x10 : 16] Non-periodic TxFIFO depth
  [then]


  [ifdef] OTG_FS_GLOBAL_OTG_FS_HNPTXSTS_DEF
    \
    \ @brief OTG_FS non-periodic transmit FIFO/queue status register (OTG_FS_GNPTXSTS)
    \ Address offset: 0x2C
    \ Reset value: 0x00080200
    \
    $00 constant OTG_FS_GLOBAL_NPTXFSAV         \ [0x00 : 16] Non-periodic TxFIFO space available
    $10 constant OTG_FS_GLOBAL_NPTQXSAV         \ [0x10 : 8] Non-periodic transmit request queue space available
    $18 constant OTG_FS_GLOBAL_NPTXQTOP         \ [0x18 : 7] Top of the non-periodic transmit request queue
  [then]


  [ifdef] OTG_FS_GLOBAL_OTG_FS_GI2CCTL_DEF
    \
    \ @brief OTG I2C access register
    \ Address offset: 0x30
    \ Reset value: 0x02000400
    \
    $00 constant OTG_FS_GLOBAL_RWDATA           \ [0x00 : 8] I2C Read/Write Data
    $08 constant OTG_FS_GLOBAL_REGADDR          \ [0x08 : 8] I2C Register Address
    $10 constant OTG_FS_GLOBAL_ADDR             \ [0x10 : 7] I2C Address
    $17 constant OTG_FS_GLOBAL_I2CEN            \ [0x17] I2C Enable
    $18 constant OTG_FS_GLOBAL_ACK              \ [0x18] I2C ACK
    $1a constant OTG_FS_GLOBAL_I2CDEVADR        \ [0x1a : 2] I2C Device Address
    $1c constant OTG_FS_GLOBAL_I2CDATSE0        \ [0x1c] I2C DatSe0 USB mode
    $1e constant OTG_FS_GLOBAL_RW               \ [0x1e] Read/Write Indicator
    $1f constant OTG_FS_GLOBAL_BSYDNE           \ [0x1f] I2C Busy/Done
  [then]


  [ifdef] OTG_FS_GLOBAL_OTG_FS_GCCFG_DEF
    \
    \ @brief OTG_FS general core configuration register (OTG_FS_GCCFG)
    \ Address offset: 0x38
    \ Reset value: 0x00000000
    \
    $00 constant OTG_FS_GLOBAL_DCDET            \ [0x00] Data contact detection (DCD) status
    $01 constant OTG_FS_GLOBAL_PDET             \ [0x01] Primary detection (PD) status
    $02 constant OTG_FS_GLOBAL_SDET             \ [0x02] Secondary detection (SD) status
    $03 constant OTG_FS_GLOBAL_PS2DET           \ [0x03] DM pull-up detection status
    $10 constant OTG_FS_GLOBAL_PWRDWN           \ [0x10] Power down
    $11 constant OTG_FS_GLOBAL_BCDEN            \ [0x11] Battery charging detector (BCD) enable
    $12 constant OTG_FS_GLOBAL_DCDEN            \ [0x12] Data contact detection (DCD) mode enable
    $13 constant OTG_FS_GLOBAL_PDEN             \ [0x13] Primary detection (PD) mode enable
    $14 constant OTG_FS_GLOBAL_SDEN             \ [0x14] Secondary detection (SD) mode enable
    $15 constant OTG_FS_GLOBAL_VBDEN            \ [0x15] USB VBUS detection enable
  [then]


  [ifdef] OTG_FS_GLOBAL_OTG_FS_CID_DEF
    \
    \ @brief core ID register
    \ Address offset: 0x3C
    \ Reset value: 0x00001000
    \
    $00 constant OTG_FS_GLOBAL_PRODUCT_ID       \ [0x00 : 32] Product ID field
  [then]


  [ifdef] OTG_FS_GLOBAL_OTG_FS_GLPMCFG_DEF
    \
    \ @brief OTG core LPM configuration register
    \ Address offset: 0x54
    \ Reset value: 0x02000400
    \
    $00 constant OTG_FS_GLOBAL_LPMEN            \ [0x00] LPM support enable
    $01 constant OTG_FS_GLOBAL_LPMACK           \ [0x01] LPM token acknowledge enable
    $02 constant OTG_FS_GLOBAL_BESL             \ [0x02 : 4] Best effort service latency
    $06 constant OTG_FS_GLOBAL_REMWAKE          \ [0x06] bRemoteWake value
    $07 constant OTG_FS_GLOBAL_L1SSEN           \ [0x07] L1 Shallow Sleep enable
    $08 constant OTG_FS_GLOBAL_BESLTHRS         \ [0x08 : 4] BESL threshold
    $0c constant OTG_FS_GLOBAL_L1DSEN           \ [0x0c] L1 deep sleep enable
    $0d constant OTG_FS_GLOBAL_LPMRST           \ [0x0d : 2] LPM response
    $0f constant OTG_FS_GLOBAL_SLPSTS           \ [0x0f] Port sleep status
    $10 constant OTG_FS_GLOBAL_L1RSMOK          \ [0x10] Sleep State Resume OK
    $11 constant OTG_FS_GLOBAL_LPMCHIDX         \ [0x11 : 4] LPM Channel Index
    $15 constant OTG_FS_GLOBAL_LPMRCNT          \ [0x15 : 3] LPM retry count
    $18 constant OTG_FS_GLOBAL_SNDLPM           \ [0x18] Send LPM transaction
    $19 constant OTG_FS_GLOBAL_LPMRCNTSTS       \ [0x19 : 3] LPM retry count status
    $1c constant OTG_FS_GLOBAL_ENBESL           \ [0x1c] Enable best effort service latency
  [then]


  [ifdef] OTG_FS_GLOBAL_OTG_FS_GPWRDN_DEF
    \
    \ @brief OTG power down register
    \ Address offset: 0x58
    \ Reset value: 0x02000400
    \
    $00 constant OTG_FS_GLOBAL_ADPMEN           \ [0x00] ADP module enable
    $17 constant OTG_FS_GLOBAL_ADPIF            \ [0x17] ADP interrupt flag
  [then]


  [ifdef] OTG_FS_GLOBAL_OTG_FS_GADPCTL_DEF
    \
    \ @brief OTG ADP timer, control and status register
    \ Address offset: 0x60
    \ Reset value: 0x02000400
    \
    $00 constant OTG_FS_GLOBAL_PRBDSCHG         \ [0x00 : 2] Probe discharge
    $02 constant OTG_FS_GLOBAL_PRBDELTA         \ [0x02 : 2] Probe delta
    $04 constant OTG_FS_GLOBAL_PRBPER           \ [0x04 : 2] Probe period
    $06 constant OTG_FS_GLOBAL_RTIM             \ [0x06 : 11] Ramp time
    $11 constant OTG_FS_GLOBAL_ENAPRB           \ [0x11] Enable probe
    $12 constant OTG_FS_GLOBAL_ENASNS           \ [0x12] Enable sense
    $13 constant OTG_FS_GLOBAL_ADPRST           \ [0x13] ADP reset
    $14 constant OTG_FS_GLOBAL_ADPEN            \ [0x14] ADP enable
    $15 constant OTG_FS_GLOBAL_ADPPRBIF         \ [0x15] ADP probe interrupt flag
    $16 constant OTG_FS_GLOBAL_ADPSNSIF         \ [0x16] ADP sense interrupt flag
    $17 constant OTG_FS_GLOBAL_ADPTOIF          \ [0x17] ADP timeout interrupt flag
    $18 constant OTG_FS_GLOBAL_ADPPRBIM         \ [0x18] ADP probe interrupt mask
    $19 constant OTG_FS_GLOBAL_ADPSNSIM         \ [0x19] ADP sense interrupt mask
    $1a constant OTG_FS_GLOBAL_ADPTOIM          \ [0x1a] ADP timeout interrupt mask
    $1b constant OTG_FS_GLOBAL_AR               \ [0x1b : 2] Access request
  [then]


  [ifdef] OTG_FS_GLOBAL_OTG_FS_HPTXFSIZ_DEF
    \
    \ @brief OTG_FS Host periodic transmit FIFO size register (OTG_FS_HPTXFSIZ)
    \ Address offset: 0x100
    \ Reset value: 0x02000600
    \
    $00 constant OTG_FS_GLOBAL_PTXSA            \ [0x00 : 16] Host periodic TxFIFO start address
    $10 constant OTG_FS_GLOBAL_PTXFSIZ          \ [0x10 : 16] Host periodic TxFIFO depth
  [then]


  [ifdef] OTG_FS_GLOBAL_OTG_FS_DIEPTXF1_DEF
    \
    \ @brief OTG_FS device IN endpoint transmit FIFO size register (OTG_FS_DIEPTXF1)
    \ Address offset: 0x104
    \ Reset value: 0x02000400
    \
    $00 constant OTG_FS_GLOBAL_INEPTXSA         \ [0x00 : 16] IN endpoint FIFO2 transmit RAM start address
    $10 constant OTG_FS_GLOBAL_INEPTXFD         \ [0x10 : 16] IN endpoint TxFIFO depth
  [then]


  [ifdef] OTG_FS_GLOBAL_OTG_FS_DIEPTXF2_DEF
    \
    \ @brief OTG_FS device IN endpoint transmit FIFO size register (OTG_FS_DIEPTXF2)
    \ Address offset: 0x108
    \ Reset value: 0x02000400
    \
    $00 constant OTG_FS_GLOBAL_INEPTXSA         \ [0x00 : 16] IN endpoint FIFO3 transmit RAM start address
    $10 constant OTG_FS_GLOBAL_INEPTXFD         \ [0x10 : 16] IN endpoint TxFIFO depth
  [then]


  [ifdef] OTG_FS_GLOBAL_OTG_FS_DIEPTXF3_DEF
    \
    \ @brief OTG_FS device IN endpoint transmit FIFO size register (OTG_FS_DIEPTXF3)
    \ Address offset: 0x10C
    \ Reset value: 0x02000400
    \
    $00 constant OTG_FS_GLOBAL_INEPTXSA         \ [0x00 : 16] IN endpoint FIFO4 transmit RAM start address
    $10 constant OTG_FS_GLOBAL_INEPTXFD         \ [0x10 : 16] IN endpoint TxFIFO depth
  [then]


  [ifdef] OTG_FS_GLOBAL_OTG_FS_DIEPTXF4_DEF
    \
    \ @brief OTG_FS device IN endpoint transmit FIFO size register (OTG_FS_DIEPTXF4)
    \ Address offset: 0x110
    \ Reset value: 0x02000400
    \
    $00 constant OTG_FS_GLOBAL_INEPTXSA         \ [0x00 : 16] IN endpoint FIFOx transmit RAM start address
    $10 constant OTG_FS_GLOBAL_INEPTXFD         \ [0x10 : 16] IN endpoint Tx FIFO depth
  [then]


  [ifdef] OTG_FS_GLOBAL_OTG_FS_DIEPTXF5_DEF
    \
    \ @brief OTG_FS device IN endpoint transmit FIFO size register (OTG_FS_DIEPTXF5)
    \ Address offset: 0x114
    \ Reset value: 0x02000400
    \
    $00 constant OTG_FS_GLOBAL_INEPTXSA         \ [0x00 : 16] IN endpoint FIFOx transmit RAM start address
    $10 constant OTG_FS_GLOBAL_INEPTXFD         \ [0x10 : 16] IN endpoint Tx FIFO depth
  [then]

  \
  \ @brief USB on the go full speed
  \
  $00 constant OTG_FS_GLOBAL_OTG_FS_GOTGCTL    \ OTG_FS control and status register (OTG_FS_GOTGCTL)
  $04 constant OTG_FS_GLOBAL_OTG_FS_GOTGINT    \ OTG_FS interrupt register (OTG_FS_GOTGINT)
  $08 constant OTG_FS_GLOBAL_OTG_FS_GAHBCFG    \ OTG_FS AHB configuration register (OTG_FS_GAHBCFG)
  $0C constant OTG_FS_GLOBAL_OTG_FS_GUSBCFG    \ OTG_FS USB configuration register (OTG_FS_GUSBCFG)
  $10 constant OTG_FS_GLOBAL_OTG_FS_GRSTCTL    \ OTG_FS reset register (OTG_FS_GRSTCTL)
  $14 constant OTG_FS_GLOBAL_OTG_FS_GINTSTS    \ OTG_FS core interrupt register (OTG_FS_GINTSTS)
  $18 constant OTG_FS_GLOBAL_OTG_FS_GINTMSK    \ OTG_FS interrupt mask register (OTG_FS_GINTMSK)
  $1C constant OTG_FS_GLOBAL_OTG_FS_GRXSTSR_DEVICE    \ OTG_FS Receive status debug read(Device mode)
  $1C constant OTG_FS_GLOBAL_OTG_FS_GRXSTSR_HOST    \ OTG_FS Receive status debug read(Host mode)
  $20 constant OTG_FS_GLOBAL_OTG_FS_GRXSTSP_DEVICE    \ OTG status read and pop register (Device mode)
  $20 constant OTG_FS_GLOBAL_OTG_FS_GRXSTSP_HOST    \ OTG status read and pop register (Host mode)
  $24 constant OTG_FS_GLOBAL_OTG_FS_GRXFSIZ    \ OTG_FS Receive FIFO size register (OTG_FS_GRXFSIZ)
  $28 constant OTG_FS_GLOBAL_OTG_FS_DIEPTXF0_DEVICE    \ OTG_FS Endpoint 0 Transmit FIFO size
  $28 constant OTG_FS_GLOBAL_OTG_FS_HNPTXFSIZ_HOST    \ OTG_FS Host non-periodic transmit FIFO size register
  $2C constant OTG_FS_GLOBAL_OTG_FS_HNPTXSTS    \ OTG_FS non-periodic transmit FIFO/queue status register (OTG_FS_GNPTXSTS)
  $30 constant OTG_FS_GLOBAL_OTG_FS_GI2CCTL    \ OTG I2C access register
  $38 constant OTG_FS_GLOBAL_OTG_FS_GCCFG    \ OTG_FS general core configuration register (OTG_FS_GCCFG)
  $3C constant OTG_FS_GLOBAL_OTG_FS_CID \ core ID register
  $54 constant OTG_FS_GLOBAL_OTG_FS_GLPMCFG    \ OTG core LPM configuration register
  $58 constant OTG_FS_GLOBAL_OTG_FS_GPWRDN    \ OTG power down register
  $60 constant OTG_FS_GLOBAL_OTG_FS_GADPCTL    \ OTG ADP timer, control and status register
  $100 constant OTG_FS_GLOBAL_OTG_FS_HPTXFSIZ    \ OTG_FS Host periodic transmit FIFO size register (OTG_FS_HPTXFSIZ)
  $104 constant OTG_FS_GLOBAL_OTG_FS_DIEPTXF1    \ OTG_FS device IN endpoint transmit FIFO size register (OTG_FS_DIEPTXF1)
  $108 constant OTG_FS_GLOBAL_OTG_FS_DIEPTXF2    \ OTG_FS device IN endpoint transmit FIFO size register (OTG_FS_DIEPTXF2)
  $10C constant OTG_FS_GLOBAL_OTG_FS_DIEPTXF3    \ OTG_FS device IN endpoint transmit FIFO size register (OTG_FS_DIEPTXF3)
  $110 constant OTG_FS_GLOBAL_OTG_FS_DIEPTXF4    \ OTG_FS device IN endpoint transmit FIFO size register (OTG_FS_DIEPTXF4)
  $114 constant OTG_FS_GLOBAL_OTG_FS_DIEPTXF5    \ OTG_FS device IN endpoint transmit FIFO size register (OTG_FS_DIEPTXF5)

: OTG_FS_GLOBAL_DEF ; [then]
