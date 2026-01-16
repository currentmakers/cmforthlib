\
\ @file otg_hs_global.fs
\ @brief USB on the go high speed
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief OTG_HS control and status register
\ Address offset: 0x00
\ Reset value: 0x00000800
\

$00000001 constant OTG_HS_GLOBAL_OTG_HS_GOTGCTL_SRQSCS              \ Session request success
$00000002 constant OTG_HS_GLOBAL_OTG_HS_GOTGCTL_SRQ                 \ Session request
$00000100 constant OTG_HS_GLOBAL_OTG_HS_GOTGCTL_HNGSCS              \ Host negotiation success
$00000200 constant OTG_HS_GLOBAL_OTG_HS_GOTGCTL_HNPRQ               \ HNP request
$00000400 constant OTG_HS_GLOBAL_OTG_HS_GOTGCTL_HSHNPEN             \ Host set HNP enable
$00000800 constant OTG_HS_GLOBAL_OTG_HS_GOTGCTL_DHNPEN              \ Device HNP enabled
$00001000 constant OTG_HS_GLOBAL_OTG_HS_GOTGCTL_EHEN                \ Embedded host enable
$00010000 constant OTG_HS_GLOBAL_OTG_HS_GOTGCTL_CIDSTS              \ Connector ID status
$00020000 constant OTG_HS_GLOBAL_OTG_HS_GOTGCTL_DBCT                \ Long/short debounce time
$00040000 constant OTG_HS_GLOBAL_OTG_HS_GOTGCTL_ASVLD               \ A-session valid
$00080000 constant OTG_HS_GLOBAL_OTG_HS_GOTGCTL_BSVLD               \ B-session valid


\
\ @brief OTG_HS interrupt register
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$00000004 constant OTG_HS_GLOBAL_OTG_HS_GOTGINT_SEDET               \ Session end detected
$00000100 constant OTG_HS_GLOBAL_OTG_HS_GOTGINT_SRSSCHG             \ Session request success status change
$00000200 constant OTG_HS_GLOBAL_OTG_HS_GOTGINT_HNSSCHG             \ Host negotiation success status change
$00020000 constant OTG_HS_GLOBAL_OTG_HS_GOTGINT_HNGDET              \ Host negotiation detected
$00040000 constant OTG_HS_GLOBAL_OTG_HS_GOTGINT_ADTOCHG             \ A-device timeout change
$00080000 constant OTG_HS_GLOBAL_OTG_HS_GOTGINT_DBCDNE              \ Debounce done
$00100000 constant OTG_HS_GLOBAL_OTG_HS_GOTGINT_IDCHNG              \ ID input pin changed


\
\ @brief OTG_HS AHB configuration register
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$00000001 constant OTG_HS_GLOBAL_OTG_HS_GAHBCFG_GINT                \ Global interrupt mask
$0000001e constant OTG_HS_GLOBAL_OTG_HS_GAHBCFG_HBSTLEN             \ Burst length/type
$00000020 constant OTG_HS_GLOBAL_OTG_HS_GAHBCFG_DMAEN               \ DMA enable
$00000080 constant OTG_HS_GLOBAL_OTG_HS_GAHBCFG_TXFELVL             \ TxFIFO empty level
$00000100 constant OTG_HS_GLOBAL_OTG_HS_GAHBCFG_PTXFELVL            \ Periodic TxFIFO empty level


\
\ @brief OTG_HS USB configuration register
\ Address offset: 0x0C
\ Reset value: 0x00000A00
\

$00000007 constant OTG_HS_GLOBAL_OTG_HS_GUSBCFG_TOCAL               \ FS timeout calibration
$00000040 constant OTG_HS_GLOBAL_OTG_HS_GUSBCFG_PHYSEL              \ USB 2.0 high-speed ULPI PHY or USB 1.1 full-speed serial transceiver select
$00000100 constant OTG_HS_GLOBAL_OTG_HS_GUSBCFG_SRPCAP              \ SRP-capable
$00000200 constant OTG_HS_GLOBAL_OTG_HS_GUSBCFG_HNPCAP              \ HNP-capable
$00003c00 constant OTG_HS_GLOBAL_OTG_HS_GUSBCFG_TRDT                \ USB turnaround time
$00008000 constant OTG_HS_GLOBAL_OTG_HS_GUSBCFG_PHYLPCS             \ PHY Low-power clock select
$00020000 constant OTG_HS_GLOBAL_OTG_HS_GUSBCFG_ULPIFSLS            \ ULPI FS/LS select
$00040000 constant OTG_HS_GLOBAL_OTG_HS_GUSBCFG_ULPIAR              \ ULPI Auto-resume
$00080000 constant OTG_HS_GLOBAL_OTG_HS_GUSBCFG_ULPICSM             \ ULPI Clock SuspendM
$00100000 constant OTG_HS_GLOBAL_OTG_HS_GUSBCFG_ULPIEVBUSD          \ ULPI External VBUS Drive
$00200000 constant OTG_HS_GLOBAL_OTG_HS_GUSBCFG_ULPIEVBUSI          \ ULPI external VBUS indicator
$00400000 constant OTG_HS_GLOBAL_OTG_HS_GUSBCFG_TSDPS               \ TermSel DLine pulsing selection
$00800000 constant OTG_HS_GLOBAL_OTG_HS_GUSBCFG_PCCI                \ Indicator complement
$01000000 constant OTG_HS_GLOBAL_OTG_HS_GUSBCFG_PTCI                \ Indicator pass through
$02000000 constant OTG_HS_GLOBAL_OTG_HS_GUSBCFG_ULPIIPD             \ ULPI interface protect disable
$20000000 constant OTG_HS_GLOBAL_OTG_HS_GUSBCFG_FHMOD               \ Forced host mode
$40000000 constant OTG_HS_GLOBAL_OTG_HS_GUSBCFG_FDMOD               \ Forced peripheral mode


\
\ @brief OTG_HS reset register
\ Address offset: 0x10
\ Reset value: 0x20000000
\

$00000001 constant OTG_HS_GLOBAL_OTG_HS_GRSTCTL_CSRST               \ Core soft reset
$00000002 constant OTG_HS_GLOBAL_OTG_HS_GRSTCTL_HSRST               \ HCLK soft reset
$00000004 constant OTG_HS_GLOBAL_OTG_HS_GRSTCTL_FCRST               \ Host frame counter reset
$00000010 constant OTG_HS_GLOBAL_OTG_HS_GRSTCTL_RXFFLSH             \ RxFIFO flush
$00000020 constant OTG_HS_GLOBAL_OTG_HS_GRSTCTL_TXFFLSH             \ TxFIFO flush
$000007c0 constant OTG_HS_GLOBAL_OTG_HS_GRSTCTL_TXFNUM              \ TxFIFO number
$40000000 constant OTG_HS_GLOBAL_OTG_HS_GRSTCTL_DMAREQ              \ DMA request signal enabled for USB OTG HS
$80000000 constant OTG_HS_GLOBAL_OTG_HS_GRSTCTL_AHBIDL              \ AHB master idle


\
\ @brief OTG_HS core interrupt register
\ Address offset: 0x14
\ Reset value: 0x04000020
\

$00000001 constant OTG_HS_GLOBAL_OTG_HS_GINTSTS_CMOD                \ Current mode of operation
$00000002 constant OTG_HS_GLOBAL_OTG_HS_GINTSTS_MMIS                \ Mode mismatch interrupt
$00000004 constant OTG_HS_GLOBAL_OTG_HS_GINTSTS_OTGINT              \ OTG interrupt
$00000008 constant OTG_HS_GLOBAL_OTG_HS_GINTSTS_SOF                 \ Start of frame
$00000010 constant OTG_HS_GLOBAL_OTG_HS_GINTSTS_RXFLVL              \ RxFIFO nonempty
$00000020 constant OTG_HS_GLOBAL_OTG_HS_GINTSTS_NPTXFE              \ Nonperiodic TxFIFO empty
$00000040 constant OTG_HS_GLOBAL_OTG_HS_GINTSTS_GINAKEFF            \ Global IN nonperiodic NAK effective
$00000080 constant OTG_HS_GLOBAL_OTG_HS_GINTSTS_BOUTNAKEFF          \ Global OUT NAK effective
$00000400 constant OTG_HS_GLOBAL_OTG_HS_GINTSTS_ESUSP               \ Early suspend
$00000800 constant OTG_HS_GLOBAL_OTG_HS_GINTSTS_USBSUSP             \ USB suspend
$00001000 constant OTG_HS_GLOBAL_OTG_HS_GINTSTS_USBRST              \ USB reset
$00002000 constant OTG_HS_GLOBAL_OTG_HS_GINTSTS_ENUMDNE             \ Enumeration done
$00004000 constant OTG_HS_GLOBAL_OTG_HS_GINTSTS_ISOODRP             \ Isochronous OUT packet dropped interrupt
$00008000 constant OTG_HS_GLOBAL_OTG_HS_GINTSTS_EOPF                \ End of periodic frame interrupt
$00040000 constant OTG_HS_GLOBAL_OTG_HS_GINTSTS_IEPINT              \ IN endpoint interrupt
$00080000 constant OTG_HS_GLOBAL_OTG_HS_GINTSTS_OEPINT              \ OUT endpoint interrupt
$00100000 constant OTG_HS_GLOBAL_OTG_HS_GINTSTS_IISOIXFR            \ Incomplete isochronous IN transfer
$00200000 constant OTG_HS_GLOBAL_OTG_HS_GINTSTS_PXFR_INCOMPISOOUT    \ Incomplete periodic transfer
$00400000 constant OTG_HS_GLOBAL_OTG_HS_GINTSTS_DATAFSUSP           \ Data fetch suspended
$01000000 constant OTG_HS_GLOBAL_OTG_HS_GINTSTS_HPRTINT             \ Host port interrupt
$02000000 constant OTG_HS_GLOBAL_OTG_HS_GINTSTS_HCINT               \ Host channels interrupt
$04000000 constant OTG_HS_GLOBAL_OTG_HS_GINTSTS_PTXFE               \ Periodic TxFIFO empty
$10000000 constant OTG_HS_GLOBAL_OTG_HS_GINTSTS_CIDSCHG             \ Connector ID status change
$20000000 constant OTG_HS_GLOBAL_OTG_HS_GINTSTS_DISCINT             \ Disconnect detected interrupt
$40000000 constant OTG_HS_GLOBAL_OTG_HS_GINTSTS_SRQINT              \ Session request/new session detected interrupt
$80000000 constant OTG_HS_GLOBAL_OTG_HS_GINTSTS_WKUINT              \ Resume/remote wakeup detected interrupt


\
\ @brief OTG_HS interrupt mask register
\ Address offset: 0x18
\ Reset value: 0x00000000
\

$00000002 constant OTG_HS_GLOBAL_OTG_HS_GINTMSK_MMISM               \ Mode mismatch interrupt mask
$00000004 constant OTG_HS_GLOBAL_OTG_HS_GINTMSK_OTGINT              \ OTG interrupt mask
$00000008 constant OTG_HS_GLOBAL_OTG_HS_GINTMSK_SOFM                \ Start of frame mask
$00000010 constant OTG_HS_GLOBAL_OTG_HS_GINTMSK_RXFLVLM             \ Receive FIFO nonempty mask
$00000020 constant OTG_HS_GLOBAL_OTG_HS_GINTMSK_NPTXFEM             \ Nonperiodic TxFIFO empty mask
$00000040 constant OTG_HS_GLOBAL_OTG_HS_GINTMSK_GINAKEFFM           \ Global nonperiodic IN NAK effective mask
$00000080 constant OTG_HS_GLOBAL_OTG_HS_GINTMSK_GONAKEFFM           \ Global OUT NAK effective mask
$00000400 constant OTG_HS_GLOBAL_OTG_HS_GINTMSK_ESUSPM              \ Early suspend mask
$00000800 constant OTG_HS_GLOBAL_OTG_HS_GINTMSK_USBSUSPM            \ USB suspend mask
$00001000 constant OTG_HS_GLOBAL_OTG_HS_GINTMSK_USBRST              \ USB reset mask
$00002000 constant OTG_HS_GLOBAL_OTG_HS_GINTMSK_ENUMDNEM            \ Enumeration done mask
$00004000 constant OTG_HS_GLOBAL_OTG_HS_GINTMSK_ISOODRPM            \ Isochronous OUT packet dropped interrupt mask
$00008000 constant OTG_HS_GLOBAL_OTG_HS_GINTMSK_EOPFM               \ End of periodic frame interrupt mask
$00040000 constant OTG_HS_GLOBAL_OTG_HS_GINTMSK_IEPINT              \ IN endpoints interrupt mask
$00080000 constant OTG_HS_GLOBAL_OTG_HS_GINTMSK_OEPINT              \ OUT endpoints interrupt mask
$00100000 constant OTG_HS_GLOBAL_OTG_HS_GINTMSK_IISOIXFRM           \ Incomplete isochronous IN transfer mask
$00200000 constant OTG_HS_GLOBAL_OTG_HS_GINTMSK_PXFRM_IISOOXFRM     \ Incomplete periodic transfer mask
$00400000 constant OTG_HS_GLOBAL_OTG_HS_GINTMSK_FSUSPM              \ Data fetch suspended mask
$00800000 constant OTG_HS_GLOBAL_OTG_HS_GINTMSK_RSTDE               \ Reset detected interrupt mask
$01000000 constant OTG_HS_GLOBAL_OTG_HS_GINTMSK_PRTIM               \ Host port interrupt mask
$02000000 constant OTG_HS_GLOBAL_OTG_HS_GINTMSK_HCIM                \ Host channels interrupt mask
$04000000 constant OTG_HS_GLOBAL_OTG_HS_GINTMSK_PTXFEM              \ Periodic TxFIFO empty mask
$08000000 constant OTG_HS_GLOBAL_OTG_HS_GINTMSK_LPMINTM             \ LPM interrupt mask
$10000000 constant OTG_HS_GLOBAL_OTG_HS_GINTMSK_CIDSCHGM            \ Connector ID status change mask
$20000000 constant OTG_HS_GLOBAL_OTG_HS_GINTMSK_DISCINT             \ Disconnect detected interrupt mask
$40000000 constant OTG_HS_GLOBAL_OTG_HS_GINTMSK_SRQIM               \ Session request/new session detected interrupt mask
$80000000 constant OTG_HS_GLOBAL_OTG_HS_GINTMSK_WUIM                \ Resume/remote wakeup detected interrupt mask


\
\ @brief OTG_HS Receive status debug read register (host mode)
\ Address offset: 0x1C
\ Reset value: 0x00000000
\

$0000000f constant OTG_HS_GLOBAL_OTG_HS_GRXSTSR_HOST_CHNUM          \ Channel number
$00007ff0 constant OTG_HS_GLOBAL_OTG_HS_GRXSTSR_HOST_BCNT           \ Byte count
$00018000 constant OTG_HS_GLOBAL_OTG_HS_GRXSTSR_HOST_DPID           \ Data PID
$001e0000 constant OTG_HS_GLOBAL_OTG_HS_GRXSTSR_HOST_PKTSTS         \ Packet status


\
\ @brief OTG_HS Receive status debug read register (peripheral mode mode)
\ Address offset: 0x1C
\ Reset value: 0x00000000
\

$0000000f constant OTG_HS_GLOBAL_OTG_HS_GRXSTSR_DEVICE_EPNUM        \ Endpoint number
$00007ff0 constant OTG_HS_GLOBAL_OTG_HS_GRXSTSR_DEVICE_BCNT         \ Byte count
$00018000 constant OTG_HS_GLOBAL_OTG_HS_GRXSTSR_DEVICE_DPID         \ Data PID
$001e0000 constant OTG_HS_GLOBAL_OTG_HS_GRXSTSR_DEVICE_PKTSTS       \ Packet status
$01e00000 constant OTG_HS_GLOBAL_OTG_HS_GRXSTSR_DEVICE_FRMNUM       \ Frame number


\
\ @brief OTG_HS status read and pop register (host mode)
\ Address offset: 0x20
\ Reset value: 0x00000000
\

$0000000f constant OTG_HS_GLOBAL_OTG_HS_GRXSTSP_HOST_CHNUM          \ Channel number
$00007ff0 constant OTG_HS_GLOBAL_OTG_HS_GRXSTSP_HOST_BCNT           \ Byte count
$00018000 constant OTG_HS_GLOBAL_OTG_HS_GRXSTSP_HOST_DPID           \ Data PID
$001e0000 constant OTG_HS_GLOBAL_OTG_HS_GRXSTSP_HOST_PKTSTS         \ Packet status


\
\ @brief OTG_HS status read and pop register (peripheral mode)
\ Address offset: 0x20
\ Reset value: 0x00000000
\

$0000000f constant OTG_HS_GLOBAL_OTG_HS_GRXSTSP_DEVICE_EPNUM        \ Endpoint number
$00007ff0 constant OTG_HS_GLOBAL_OTG_HS_GRXSTSP_DEVICE_BCNT         \ Byte count
$00018000 constant OTG_HS_GLOBAL_OTG_HS_GRXSTSP_DEVICE_DPID         \ Data PID
$001e0000 constant OTG_HS_GLOBAL_OTG_HS_GRXSTSP_DEVICE_PKTSTS       \ Packet status
$01e00000 constant OTG_HS_GLOBAL_OTG_HS_GRXSTSP_DEVICE_FRMNUM       \ Frame number


\
\ @brief OTG_HS Receive FIFO size register
\ Address offset: 0x24
\ Reset value: 0x00000200
\

$0000ffff constant OTG_HS_GLOBAL_OTG_HS_GRXFSIZ_RXFD                \ RxFIFO depth


\
\ @brief OTG_HS nonperiodic transmit FIFO size register (host mode)
\ Address offset: 0x28
\ Reset value: 0x00000200
\

$0000ffff constant OTG_HS_GLOBAL_OTG_HS_HNPTXFSIZ_HOST_NPTXFSA      \ Nonperiodic transmit RAM start address
$ffff0000 constant OTG_HS_GLOBAL_OTG_HS_HNPTXFSIZ_HOST_NPTXFD       \ Nonperiodic TxFIFO depth


\
\ @brief Endpoint 0 transmit FIFO size (peripheral mode)
\ Address offset: 0x28
\ Reset value: 0x00000200
\

$0000ffff constant OTG_HS_GLOBAL_OTG_HS_DIEPTXF0_DEVICE_TX0FSA      \ Endpoint 0 transmit RAM start address
$ffff0000 constant OTG_HS_GLOBAL_OTG_HS_DIEPTXF0_DEVICE_TX0FD       \ Endpoint 0 TxFIFO depth


\
\ @brief OTG_HS nonperiodic transmit FIFO/queue status register
\ Address offset: 0x2C
\ Reset value: 0x00080200
\

$0000ffff constant OTG_HS_GLOBAL_OTG_HS_HNPTXSTS_NPTXFSAV           \ Nonperiodic TxFIFO space available
$00ff0000 constant OTG_HS_GLOBAL_OTG_HS_HNPTXSTS_NPTQXSAV           \ Nonperiodic transmit request queue space available
$7f000000 constant OTG_HS_GLOBAL_OTG_HS_HNPTXSTS_NPTXQTOP           \ Top of the nonperiodic transmit request queue


\
\ @brief OTG I2C access register
\ Address offset: 0x30
\ Reset value: 0x00000000
\

$000000ff constant OTG_HS_GLOBAL_OTG_HS_GI2CCTL_RWDATA              \ I2C Read/Write Data
$0000ff00 constant OTG_HS_GLOBAL_OTG_HS_GI2CCTL_REGADDR             \ I2C Register Address
$007f0000 constant OTG_HS_GLOBAL_OTG_HS_GI2CCTL_ADDR                \ I2C Address
$00800000 constant OTG_HS_GLOBAL_OTG_HS_GI2CCTL_I2CEN               \ I2C Enable
$01000000 constant OTG_HS_GLOBAL_OTG_HS_GI2CCTL_ACK                 \ I2C ACK
$0c000000 constant OTG_HS_GLOBAL_OTG_HS_GI2CCTL_I2CDEVADR           \ I2C Device Address
$10000000 constant OTG_HS_GLOBAL_OTG_HS_GI2CCTL_I2CDATSE0           \ I2C DatSe0 USB mode
$40000000 constant OTG_HS_GLOBAL_OTG_HS_GI2CCTL_RW                  \ Read/Write Indicator
$80000000 constant OTG_HS_GLOBAL_OTG_HS_GI2CCTL_BSYDNE              \ I2C Busy/Done


\
\ @brief OTG_HS general core configuration register
\ Address offset: 0x38
\ Reset value: 0x00000000
\

$00000001 constant OTG_HS_GLOBAL_OTG_HS_GCCFG_DCDET                 \ Data contact detection (DCD) status
$00000002 constant OTG_HS_GLOBAL_OTG_HS_GCCFG_PDET                  \ Primary detection (PD) status
$00000004 constant OTG_HS_GLOBAL_OTG_HS_GCCFG_SDET                  \ Secondary detection (SD) status
$00000008 constant OTG_HS_GLOBAL_OTG_HS_GCCFG_PS2DET                \ DM pull-up detection status
$00010000 constant OTG_HS_GLOBAL_OTG_HS_GCCFG_PWRDWN                \ Power down
$00020000 constant OTG_HS_GLOBAL_OTG_HS_GCCFG_BCDEN                 \ Battery charging detector (BCD) enable
$00040000 constant OTG_HS_GLOBAL_OTG_HS_GCCFG_DCDEN                 \ Data contact detection (DCD) mode enable
$00080000 constant OTG_HS_GLOBAL_OTG_HS_GCCFG_PDEN                  \ Primary detection (PD) mode enable
$00100000 constant OTG_HS_GLOBAL_OTG_HS_GCCFG_SDEN                  \ Secondary detection (SD) mode enable
$00200000 constant OTG_HS_GLOBAL_OTG_HS_GCCFG_VBDEN                 \ USB VBUS detection enable


\
\ @brief OTG_HS core ID register
\ Address offset: 0x3C
\ Reset value: 0x00001200
\

$00000000 constant OTG_HS_GLOBAL_OTG_HS_CID_PRODUCT_ID              \ Product ID field


\
\ @brief OTG core LPM configuration register
\ Address offset: 0x54
\ Reset value: 0x00000000
\

$00000001 constant OTG_HS_GLOBAL_OTG_HS_GLPMCFG_LPMEN               \ LPM support enable
$00000002 constant OTG_HS_GLOBAL_OTG_HS_GLPMCFG_LPMACK              \ LPM token acknowledge enable
$0000003c constant OTG_HS_GLOBAL_OTG_HS_GLPMCFG_BESL                \ Best effort service latency
$00000040 constant OTG_HS_GLOBAL_OTG_HS_GLPMCFG_REMWAKE             \ bRemoteWake value
$00000080 constant OTG_HS_GLOBAL_OTG_HS_GLPMCFG_L1SSEN              \ L1 Shallow Sleep enable
$00000f00 constant OTG_HS_GLOBAL_OTG_HS_GLPMCFG_BESLTHRS            \ BESL threshold
$00001000 constant OTG_HS_GLOBAL_OTG_HS_GLPMCFG_L1DSEN              \ L1 deep sleep enable
$00006000 constant OTG_HS_GLOBAL_OTG_HS_GLPMCFG_LPMRST              \ LPM response
$00008000 constant OTG_HS_GLOBAL_OTG_HS_GLPMCFG_SLPSTS              \ Port sleep status
$00010000 constant OTG_HS_GLOBAL_OTG_HS_GLPMCFG_L1RSMOK             \ Sleep State Resume OK
$001e0000 constant OTG_HS_GLOBAL_OTG_HS_GLPMCFG_LPMCHIDX            \ LPM Channel Index
$00e00000 constant OTG_HS_GLOBAL_OTG_HS_GLPMCFG_LPMRCNT             \ LPM retry count
$01000000 constant OTG_HS_GLOBAL_OTG_HS_GLPMCFG_SNDLPM              \ Send LPM transaction
$0e000000 constant OTG_HS_GLOBAL_OTG_HS_GLPMCFG_LPMRCNTSTS          \ LPM retry count status
$10000000 constant OTG_HS_GLOBAL_OTG_HS_GLPMCFG_ENBESL              \ Enable best effort service latency


\
\ @brief OTG_HS Host periodic transmit FIFO size register
\ Address offset: 0x100
\ Reset value: 0x02000600
\

$0000ffff constant OTG_HS_GLOBAL_OTG_HS_HPTXFSIZ_PTXSA              \ Host periodic TxFIFO start address
$ffff0000 constant OTG_HS_GLOBAL_OTG_HS_HPTXFSIZ_PTXFD              \ Host periodic TxFIFO depth


\
\ @brief OTG_HS device IN endpoint transmit FIFO size register
\ Address offset: 0x104
\ Reset value: 0x02000400
\

$0000ffff constant OTG_HS_GLOBAL_OTG_HS_DIEPTXF1_INEPTXSA           \ IN endpoint FIFOx transmit RAM start address
$ffff0000 constant OTG_HS_GLOBAL_OTG_HS_DIEPTXF1_INEPTXFD           \ IN endpoint TxFIFO depth


\
\ @brief OTG_HS device IN endpoint transmit FIFO size register
\ Address offset: 0x108
\ Reset value: 0x02000600
\

$0000ffff constant OTG_HS_GLOBAL_OTG_HS_DIEPTXF2_INEPTXSA           \ IN endpoint FIFOx transmit RAM start address
$ffff0000 constant OTG_HS_GLOBAL_OTG_HS_DIEPTXF2_INEPTXFD           \ IN endpoint TxFIFO depth


\
\ @brief OTG_HS device IN endpoint transmit FIFO size register
\ Address offset: 0x10C
\ Reset value: 0x02000800
\

$0000ffff constant OTG_HS_GLOBAL_OTG_HS_DIEPTXF3_INEPTXSA           \ IN endpoint FIFOx transmit RAM start address
$ffff0000 constant OTG_HS_GLOBAL_OTG_HS_DIEPTXF3_INEPTXFD           \ IN endpoint TxFIFO depth


\
\ @brief OTG_HS device IN endpoint transmit FIFO size register
\ Address offset: 0x110
\ Reset value: 0x02000A00
\

$0000ffff constant OTG_HS_GLOBAL_OTG_HS_DIEPTXF4_INEPTXSA           \ IN endpoint FIFOx transmit RAM start address
$ffff0000 constant OTG_HS_GLOBAL_OTG_HS_DIEPTXF4_INEPTXFD           \ IN endpoint TxFIFO depth


\
\ @brief OTG_HS device IN endpoint transmit FIFO size register
\ Address offset: 0x114
\ Reset value: 0x02000C00
\

$0000ffff constant OTG_HS_GLOBAL_OTG_HS_DIEPTXF5_INEPTXSA           \ IN endpoint FIFOx transmit RAM start address
$ffff0000 constant OTG_HS_GLOBAL_OTG_HS_DIEPTXF5_INEPTXFD           \ IN endpoint TxFIFO depth


\
\ @brief OTG_HS device IN endpoint transmit FIFO size register
\ Address offset: 0x118
\ Reset value: 0x02000E00
\

$0000ffff constant OTG_HS_GLOBAL_OTG_HS_DIEPTXF6_INEPTXSA           \ IN endpoint FIFOx transmit RAM start address
$ffff0000 constant OTG_HS_GLOBAL_OTG_HS_DIEPTXF6_INEPTXFD           \ IN endpoint TxFIFO depth


\
\ @brief OTG_HS device IN endpoint transmit FIFO size register
\ Address offset: 0x11C
\ Reset value: 0x02001000
\

$0000ffff constant OTG_HS_GLOBAL_OTG_HS_DIEPTXF7_INEPTXSA           \ IN endpoint FIFOx transmit RAM start address
$ffff0000 constant OTG_HS_GLOBAL_OTG_HS_DIEPTXF7_INEPTXFD           \ IN endpoint TxFIFO depth


\
\ @brief IN endpoint FIFOx transmit RAM start address This field contains the memory start address for IN endpoint transmit FIFOx. The address must be aligned with a 32-bit memory location.
\ Address offset: 0x120
\ Reset value: 0x02001200
\

$0000ffff constant OTG_HS_GLOBAL_OTG_HS_DIEPTXF8_INEPTXSA           \ IN endpoint FIFOx transmit RAM start address This field contains the memory start address for IN endpoint transmit FIFOx. The address must be aligned with a 32-bit memory location.
$ffff0000 constant OTG_HS_GLOBAL_OTG_HS_DIEPTXF8_INEPTXFD           \ IN endpoint Tx FIFO depth This value is in terms of 32-bit words. Minimum value is 16


\
\ @brief USB on the go high speed
\
$40040000 constant OTG_HS_GLOBAL_OTG_HS_GOTGCTL  \ offset: 0x00 : OTG_HS control and status register
$40040004 constant OTG_HS_GLOBAL_OTG_HS_GOTGINT  \ offset: 0x04 : OTG_HS interrupt register
$40040008 constant OTG_HS_GLOBAL_OTG_HS_GAHBCFG  \ offset: 0x08 : OTG_HS AHB configuration register
$4004000c constant OTG_HS_GLOBAL_OTG_HS_GUSBCFG  \ offset: 0x0C : OTG_HS USB configuration register
$40040010 constant OTG_HS_GLOBAL_OTG_HS_GRSTCTL  \ offset: 0x10 : OTG_HS reset register
$40040014 constant OTG_HS_GLOBAL_OTG_HS_GINTSTS  \ offset: 0x14 : OTG_HS core interrupt register
$40040018 constant OTG_HS_GLOBAL_OTG_HS_GINTMSK  \ offset: 0x18 : OTG_HS interrupt mask register
$4004001c constant OTG_HS_GLOBAL_OTG_HS_GRXSTSR_HOST  \ offset: 0x1C : OTG_HS Receive status debug read register (host mode)
$4004001c constant OTG_HS_GLOBAL_OTG_HS_GRXSTSR_DEVICE  \ offset: 0x1C : OTG_HS Receive status debug read register (peripheral mode mode)
$40040020 constant OTG_HS_GLOBAL_OTG_HS_GRXSTSP_HOST  \ offset: 0x20 : OTG_HS status read and pop register (host mode)
$40040020 constant OTG_HS_GLOBAL_OTG_HS_GRXSTSP_DEVICE  \ offset: 0x20 : OTG_HS status read and pop register (peripheral mode)
$40040024 constant OTG_HS_GLOBAL_OTG_HS_GRXFSIZ  \ offset: 0x24 : OTG_HS Receive FIFO size register
$40040028 constant OTG_HS_GLOBAL_OTG_HS_HNPTXFSIZ_HOST  \ offset: 0x28 : OTG_HS nonperiodic transmit FIFO size register (host mode)
$40040028 constant OTG_HS_GLOBAL_OTG_HS_DIEPTXF0_DEVICE  \ offset: 0x28 : Endpoint 0 transmit FIFO size (peripheral mode)
$4004002c constant OTG_HS_GLOBAL_OTG_HS_HNPTXSTS  \ offset: 0x2C : OTG_HS nonperiodic transmit FIFO/queue status register
$40040030 constant OTG_HS_GLOBAL_OTG_HS_GI2CCTL  \ offset: 0x30 : OTG I2C access register
$40040038 constant OTG_HS_GLOBAL_OTG_HS_GCCFG  \ offset: 0x38 : OTG_HS general core configuration register
$4004003c constant OTG_HS_GLOBAL_OTG_HS_CID  \ offset: 0x3C : OTG_HS core ID register
$40040054 constant OTG_HS_GLOBAL_OTG_HS_GLPMCFG  \ offset: 0x54 : OTG core LPM configuration register
$40040100 constant OTG_HS_GLOBAL_OTG_HS_HPTXFSIZ  \ offset: 0x100 : OTG_HS Host periodic transmit FIFO size register
$40040104 constant OTG_HS_GLOBAL_OTG_HS_DIEPTXF1  \ offset: 0x104 : OTG_HS device IN endpoint transmit FIFO size register
$40040108 constant OTG_HS_GLOBAL_OTG_HS_DIEPTXF2  \ offset: 0x108 : OTG_HS device IN endpoint transmit FIFO size register
$4004010c constant OTG_HS_GLOBAL_OTG_HS_DIEPTXF3  \ offset: 0x10C : OTG_HS device IN endpoint transmit FIFO size register
$40040110 constant OTG_HS_GLOBAL_OTG_HS_DIEPTXF4  \ offset: 0x110 : OTG_HS device IN endpoint transmit FIFO size register
$40040114 constant OTG_HS_GLOBAL_OTG_HS_DIEPTXF5  \ offset: 0x114 : OTG_HS device IN endpoint transmit FIFO size register
$40040118 constant OTG_HS_GLOBAL_OTG_HS_DIEPTXF6  \ offset: 0x118 : OTG_HS device IN endpoint transmit FIFO size register
$4004011c constant OTG_HS_GLOBAL_OTG_HS_DIEPTXF7  \ offset: 0x11C : OTG_HS device IN endpoint transmit FIFO size register
$40040120 constant OTG_HS_GLOBAL_OTG_HS_DIEPTXF8  \ offset: 0x120 : IN endpoint FIFOx transmit RAM start address This field contains the memory start address for IN endpoint transmit FIFOx. The address must be aligned with a 32-bit memory location.

