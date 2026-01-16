\
\ @file otg_fs_global.fs
\ @brief USB on the go full speed
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief OTG_FS control and status register (OTG_FS_GOTGCTL)
\ Address offset: 0x00
\ Reset value: 0x00000800
\

$00000001 constant OTG_FS_GLOBAL_FS_GOTGCTL_SRQSCS                  \ Session request success
$00000002 constant OTG_FS_GLOBAL_FS_GOTGCTL_SRQ                     \ Session request
$00000100 constant OTG_FS_GLOBAL_FS_GOTGCTL_HNGSCS                  \ Host negotiation success
$00000200 constant OTG_FS_GLOBAL_FS_GOTGCTL_HNPRQ                   \ HNP request
$00000400 constant OTG_FS_GLOBAL_FS_GOTGCTL_HSHNPEN                 \ Host set HNP enable
$00000800 constant OTG_FS_GLOBAL_FS_GOTGCTL_DHNPEN                  \ Device HNP enabled
$00010000 constant OTG_FS_GLOBAL_FS_GOTGCTL_CIDSTS                  \ Connector ID status
$00020000 constant OTG_FS_GLOBAL_FS_GOTGCTL_DBCT                    \ Long/short debounce time
$00040000 constant OTG_FS_GLOBAL_FS_GOTGCTL_ASVLD                   \ A-session valid
$00080000 constant OTG_FS_GLOBAL_FS_GOTGCTL_BSVLD                   \ B-session valid


\
\ @brief OTG_FS interrupt register (OTG_FS_GOTGINT)
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$00000004 constant OTG_FS_GLOBAL_FS_GOTGINT_SEDET                   \ Session end detected
$00000100 constant OTG_FS_GLOBAL_FS_GOTGINT_SRSSCHG                 \ Session request success status change
$00000200 constant OTG_FS_GLOBAL_FS_GOTGINT_HNSSCHG                 \ Host negotiation success status change
$00020000 constant OTG_FS_GLOBAL_FS_GOTGINT_HNGDET                  \ Host negotiation detected
$00040000 constant OTG_FS_GLOBAL_FS_GOTGINT_ADTOCHG                 \ A-device timeout change
$00080000 constant OTG_FS_GLOBAL_FS_GOTGINT_DBCDNE                  \ Debounce done


\
\ @brief OTG_FS AHB configuration register (OTG_FS_GAHBCFG)
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$00000001 constant OTG_FS_GLOBAL_FS_GAHBCFG_GINT                    \ Global interrupt mask
$00000080 constant OTG_FS_GLOBAL_FS_GAHBCFG_TXFELVL                 \ TxFIFO empty level
$00000100 constant OTG_FS_GLOBAL_FS_GAHBCFG_PTXFELVL                \ Periodic TxFIFO empty level


\
\ @brief OTG_FS USB configuration register (OTG_FS_GUSBCFG)
\ Address offset: 0x0C
\ Reset value: 0x00000A00
\

$00000007 constant OTG_FS_GLOBAL_FS_GUSBCFG_TOCAL                   \ FS timeout calibration
$00000040 constant OTG_FS_GLOBAL_FS_GUSBCFG_PHYSEL                  \ Full Speed serial transceiver select
$00000100 constant OTG_FS_GLOBAL_FS_GUSBCFG_SRPCAP                  \ SRP-capable
$00000200 constant OTG_FS_GLOBAL_FS_GUSBCFG_HNPCAP                  \ HNP-capable
$00003c00 constant OTG_FS_GLOBAL_FS_GUSBCFG_TRDT                    \ USB turnaround time
$20000000 constant OTG_FS_GLOBAL_FS_GUSBCFG_FHMOD                   \ Force host mode
$40000000 constant OTG_FS_GLOBAL_FS_GUSBCFG_FDMOD                   \ Force device mode
$80000000 constant OTG_FS_GLOBAL_FS_GUSBCFG_CTXPKT                  \ Corrupt Tx packet


\
\ @brief OTG_FS reset register (OTG_FS_GRSTCTL)
\ Address offset: 0x10
\ Reset value: 0x20000000
\

$00000001 constant OTG_FS_GLOBAL_FS_GRSTCTL_CSRST                   \ Core soft reset
$00000002 constant OTG_FS_GLOBAL_FS_GRSTCTL_HSRST                   \ HCLK soft reset
$00000004 constant OTG_FS_GLOBAL_FS_GRSTCTL_FCRST                   \ Host frame counter reset
$00000010 constant OTG_FS_GLOBAL_FS_GRSTCTL_RXFFLSH                 \ RxFIFO flush
$00000020 constant OTG_FS_GLOBAL_FS_GRSTCTL_TXFFLSH                 \ TxFIFO flush
$000007c0 constant OTG_FS_GLOBAL_FS_GRSTCTL_TXFNUM                  \ TxFIFO number
$80000000 constant OTG_FS_GLOBAL_FS_GRSTCTL_AHBIDL                  \ AHB master idle


\
\ @brief OTG_FS core interrupt register (OTG_FS_GINTSTS)
\ Address offset: 0x14
\ Reset value: 0x04000020
\

$00000001 constant OTG_FS_GLOBAL_FS_GINTSTS_CMOD                    \ Current mode of operation
$00000002 constant OTG_FS_GLOBAL_FS_GINTSTS_MMIS                    \ Mode mismatch interrupt
$00000004 constant OTG_FS_GLOBAL_FS_GINTSTS_OTGINT                  \ OTG interrupt
$00000008 constant OTG_FS_GLOBAL_FS_GINTSTS_SOF                     \ Start of frame
$00000010 constant OTG_FS_GLOBAL_FS_GINTSTS_RXFLVL                  \ RxFIFO non-empty
$00000020 constant OTG_FS_GLOBAL_FS_GINTSTS_NPTXFE                  \ Non-periodic TxFIFO empty
$00000040 constant OTG_FS_GLOBAL_FS_GINTSTS_GINAKEFF                \ Global IN non-periodic NAK effective
$00000080 constant OTG_FS_GLOBAL_FS_GINTSTS_GOUTNAKEFF              \ Global OUT NAK effective
$00000400 constant OTG_FS_GLOBAL_FS_GINTSTS_ESUSP                   \ Early suspend
$00000800 constant OTG_FS_GLOBAL_FS_GINTSTS_USBSUSP                 \ USB suspend
$00001000 constant OTG_FS_GLOBAL_FS_GINTSTS_USBRST                  \ USB reset
$00002000 constant OTG_FS_GLOBAL_FS_GINTSTS_ENUMDNE                 \ Enumeration done
$00004000 constant OTG_FS_GLOBAL_FS_GINTSTS_ISOODRP                 \ Isochronous OUT packet dropped interrupt
$00008000 constant OTG_FS_GLOBAL_FS_GINTSTS_EOPF                    \ End of periodic frame interrupt
$00040000 constant OTG_FS_GLOBAL_FS_GINTSTS_IEPINT                  \ IN endpoint interrupt
$00080000 constant OTG_FS_GLOBAL_FS_GINTSTS_OEPINT                  \ OUT endpoint interrupt
$00100000 constant OTG_FS_GLOBAL_FS_GINTSTS_IISOIXFR                \ Incomplete isochronous IN transfer
$00200000 constant OTG_FS_GLOBAL_FS_GINTSTS_IPXFR_INCOMPISOOUT      \ Incomplete periodic transfer(Host mode)/Incomplete isochronous OUT transfer(Device mode)
$01000000 constant OTG_FS_GLOBAL_FS_GINTSTS_HPRTINT                 \ Host port interrupt
$02000000 constant OTG_FS_GLOBAL_FS_GINTSTS_HCINT                   \ Host channels interrupt
$04000000 constant OTG_FS_GLOBAL_FS_GINTSTS_PTXFE                   \ Periodic TxFIFO empty
$10000000 constant OTG_FS_GLOBAL_FS_GINTSTS_CIDSCHG                 \ Connector ID status change
$20000000 constant OTG_FS_GLOBAL_FS_GINTSTS_DISCINT                 \ Disconnect detected interrupt
$40000000 constant OTG_FS_GLOBAL_FS_GINTSTS_SRQINT                  \ Session request/new session detected interrupt
$80000000 constant OTG_FS_GLOBAL_FS_GINTSTS_WKUPINT                 \ Resume/remote wakeup detected interrupt


\
\ @brief OTG_FS interrupt mask register (OTG_FS_GINTMSK)
\ Address offset: 0x18
\ Reset value: 0x00000000
\

$00000002 constant OTG_FS_GLOBAL_FS_GINTMSK_MMISM                   \ Mode mismatch interrupt mask
$00000004 constant OTG_FS_GLOBAL_FS_GINTMSK_OTGINT                  \ OTG interrupt mask
$00000008 constant OTG_FS_GLOBAL_FS_GINTMSK_SOFM                    \ Start of frame mask
$00000010 constant OTG_FS_GLOBAL_FS_GINTMSK_RXFLVLM                 \ Receive FIFO non-empty mask
$00000020 constant OTG_FS_GLOBAL_FS_GINTMSK_NPTXFEM                 \ Non-periodic TxFIFO empty mask
$00000040 constant OTG_FS_GLOBAL_FS_GINTMSK_GINAKEFFM               \ Global non-periodic IN NAK effective mask
$00000080 constant OTG_FS_GLOBAL_FS_GINTMSK_GONAKEFFM               \ Global OUT NAK effective mask
$00000400 constant OTG_FS_GLOBAL_FS_GINTMSK_ESUSPM                  \ Early suspend mask
$00000800 constant OTG_FS_GLOBAL_FS_GINTMSK_USBSUSPM                \ USB suspend mask
$00001000 constant OTG_FS_GLOBAL_FS_GINTMSK_USBRST                  \ USB reset mask
$00002000 constant OTG_FS_GLOBAL_FS_GINTMSK_ENUMDNEM                \ Enumeration done mask
$00004000 constant OTG_FS_GLOBAL_FS_GINTMSK_ISOODRPM                \ Isochronous OUT packet dropped interrupt mask
$00008000 constant OTG_FS_GLOBAL_FS_GINTMSK_EOPFM                   \ End of periodic frame interrupt mask
$00020000 constant OTG_FS_GLOBAL_FS_GINTMSK_EPMISM                  \ Endpoint mismatch interrupt mask
$00040000 constant OTG_FS_GLOBAL_FS_GINTMSK_IEPINT                  \ IN endpoints interrupt mask
$00080000 constant OTG_FS_GLOBAL_FS_GINTMSK_OEPINT                  \ OUT endpoints interrupt mask
$00100000 constant OTG_FS_GLOBAL_FS_GINTMSK_IISOIXFRM               \ Incomplete isochronous IN transfer mask
$00200000 constant OTG_FS_GLOBAL_FS_GINTMSK_IPXFRM_IISOOXFRM        \ Incomplete periodic transfer mask(Host mode)/Incomplete isochronous OUT transfer mask(Device mode)
$01000000 constant OTG_FS_GLOBAL_FS_GINTMSK_PRTIM                   \ Host port interrupt mask
$02000000 constant OTG_FS_GLOBAL_FS_GINTMSK_HCIM                    \ Host channels interrupt mask
$04000000 constant OTG_FS_GLOBAL_FS_GINTMSK_PTXFEM                  \ Periodic TxFIFO empty mask
$10000000 constant OTG_FS_GLOBAL_FS_GINTMSK_CIDSCHGM                \ Connector ID status change mask
$20000000 constant OTG_FS_GLOBAL_FS_GINTMSK_DISCINT                 \ Disconnect detected interrupt mask
$40000000 constant OTG_FS_GLOBAL_FS_GINTMSK_SRQIM                   \ Session request/new session detected interrupt mask
$80000000 constant OTG_FS_GLOBAL_FS_GINTMSK_WUIM                    \ Resume/remote wakeup detected interrupt mask


\
\ @brief OTG_FS Receive status debug read(Device mode)
\ Address offset: 0x1C
\ Reset value: 0x00000000
\

$0000000f constant OTG_FS_GLOBAL_FS_GRXSTSR_DEVICE_EPNUM            \ Endpoint number
$00007ff0 constant OTG_FS_GLOBAL_FS_GRXSTSR_DEVICE_BCNT             \ Byte count
$00018000 constant OTG_FS_GLOBAL_FS_GRXSTSR_DEVICE_DPID             \ Data PID
$001e0000 constant OTG_FS_GLOBAL_FS_GRXSTSR_DEVICE_PKTSTS           \ Packet status
$01e00000 constant OTG_FS_GLOBAL_FS_GRXSTSR_DEVICE_FRMNUM           \ Frame number


\
\ @brief OTG_FS Receive status debug read(Hostmode)
\ Address offset: 0x1C
\ Reset value: 0x00000000
\

$0000000f constant OTG_FS_GLOBAL_FS_GRXSTSR_HOST_EPNUM              \ Endpoint number
$00007ff0 constant OTG_FS_GLOBAL_FS_GRXSTSR_HOST_BCNT               \ Byte count
$00018000 constant OTG_FS_GLOBAL_FS_GRXSTSR_HOST_DPID               \ Data PID
$001e0000 constant OTG_FS_GLOBAL_FS_GRXSTSR_HOST_PKTSTS             \ Packet status
$01e00000 constant OTG_FS_GLOBAL_FS_GRXSTSR_HOST_FRMNUM             \ Frame number


\
\ @brief OTG_FS Receive FIFO size register (OTG_FS_GRXFSIZ)
\ Address offset: 0x24
\ Reset value: 0x00000200
\

$0000ffff constant OTG_FS_GLOBAL_FS_GRXFSIZ_RXFD                    \ RxFIFO depth


\
\ @brief OTG_FS non-periodic transmit FIFO size register (Device mode)
\ Address offset: 0x28
\ Reset value: 0x00000200
\

$0000ffff constant OTG_FS_GLOBAL_FS_GNPTXFSIZ_DEVICE_TX0FSA         \ Endpoint 0 transmit RAM start address
$ffff0000 constant OTG_FS_GLOBAL_FS_GNPTXFSIZ_DEVICE_TX0FD          \ Endpoint 0 TxFIFO depth


\
\ @brief OTG_FS non-periodic transmit FIFO size register (Host mode)
\ Address offset: 0x28
\ Reset value: 0x00000200
\

$0000ffff constant OTG_FS_GLOBAL_FS_GNPTXFSIZ_HOST_NPTXFSA          \ Non-periodic transmit RAM start address
$ffff0000 constant OTG_FS_GLOBAL_FS_GNPTXFSIZ_HOST_NPTXFD           \ Non-periodic TxFIFO depth


\
\ @brief OTG_FS non-periodic transmit FIFO/queue status register (OTG_FS_GNPTXSTS)
\ Address offset: 0x2C
\ Reset value: 0x00080200
\

$0000ffff constant OTG_FS_GLOBAL_FS_GNPTXSTS_NPTXFSAV               \ Non-periodic TxFIFO space available
$00ff0000 constant OTG_FS_GLOBAL_FS_GNPTXSTS_NPTQXSAV               \ Non-periodic transmit request queue space available
$7f000000 constant OTG_FS_GLOBAL_FS_GNPTXSTS_NPTXQTOP               \ Top of the non-periodic transmit request queue


\
\ @brief OTG_FS general core configuration register (OTG_FS_GCCFG)
\ Address offset: 0x38
\ Reset value: 0x00000000
\

$00010000 constant OTG_FS_GLOBAL_FS_GCCFG_PWRDWN                    \ Power down
$00040000 constant OTG_FS_GLOBAL_FS_GCCFG_VBUSASEN                  \ Enable the VBUS sensing device
$00080000 constant OTG_FS_GLOBAL_FS_GCCFG_VBUSBSEN                  \ Enable the VBUS sensing device
$00100000 constant OTG_FS_GLOBAL_FS_GCCFG_SOFOUTEN                  \ SOF output enable


\
\ @brief core ID register
\ Address offset: 0x3C
\ Reset value: 0x00001000
\

$00000000 constant OTG_FS_GLOBAL_FS_CID_PRODUCT_ID                  \ Product ID field


\
\ @brief OTG_FS Host periodic transmit FIFO size register (OTG_FS_HPTXFSIZ)
\ Address offset: 0x100
\ Reset value: 0x02000600
\

$0000ffff constant OTG_FS_GLOBAL_FS_HPTXFSIZ_PTXSA                  \ Host periodic TxFIFO start address
$ffff0000 constant OTG_FS_GLOBAL_FS_HPTXFSIZ_PTXFSIZ                \ Host periodic TxFIFO depth


\
\ @brief OTG_FS device IN endpoint transmit FIFO size register (OTG_FS_DIEPTXF1)
\ Address offset: 0x104
\ Reset value: 0x02000400
\

$0000ffff constant OTG_FS_GLOBAL_FS_DIEPTXF1_INEPTXSA               \ IN endpoint FIFO2 transmit RAM start address
$ffff0000 constant OTG_FS_GLOBAL_FS_DIEPTXF1_INEPTXFD               \ IN endpoint TxFIFO depth


\
\ @brief OTG_FS device IN endpoint transmit FIFO size register (OTG_FS_DIEPTXF2)
\ Address offset: 0x108
\ Reset value: 0x02000400
\

$0000ffff constant OTG_FS_GLOBAL_FS_DIEPTXF2_INEPTXSA               \ IN endpoint FIFO3 transmit RAM start address
$ffff0000 constant OTG_FS_GLOBAL_FS_DIEPTXF2_INEPTXFD               \ IN endpoint TxFIFO depth


\
\ @brief OTG_FS device IN endpoint transmit FIFO size register (OTG_FS_DIEPTXF3)
\ Address offset: 0x10C
\ Reset value: 0x02000400
\

$0000ffff constant OTG_FS_GLOBAL_FS_DIEPTXF3_INEPTXSA               \ IN endpoint FIFO4 transmit RAM start address
$ffff0000 constant OTG_FS_GLOBAL_FS_DIEPTXF3_INEPTXFD               \ IN endpoint TxFIFO depth


\
\ @brief OTG_FS device IN endpoint transmit FIFO size register (OTG_FS_DIEPTXF4)
\ Address offset: 0x110
\ Reset value: 0x02000400
\


\
\ @brief OTG_FS device IN endpoint transmit FIFO size register (OTG_FS_DIEPTXF5)
\ Address offset: 0x114
\ Reset value: 0x02000400
\


\
\ @brief USB on the go full speed
\
$50000000 constant OTG_FS_GLOBAL_FS_GOTGCTL  \ offset: 0x00 : OTG_FS control and status register (OTG_FS_GOTGCTL)
$50000004 constant OTG_FS_GLOBAL_FS_GOTGINT  \ offset: 0x04 : OTG_FS interrupt register (OTG_FS_GOTGINT)
$50000008 constant OTG_FS_GLOBAL_FS_GAHBCFG  \ offset: 0x08 : OTG_FS AHB configuration register (OTG_FS_GAHBCFG)
$5000000c constant OTG_FS_GLOBAL_FS_GUSBCFG  \ offset: 0x0C : OTG_FS USB configuration register (OTG_FS_GUSBCFG)
$50000010 constant OTG_FS_GLOBAL_FS_GRSTCTL  \ offset: 0x10 : OTG_FS reset register (OTG_FS_GRSTCTL)
$50000014 constant OTG_FS_GLOBAL_FS_GINTSTS  \ offset: 0x14 : OTG_FS core interrupt register (OTG_FS_GINTSTS)
$50000018 constant OTG_FS_GLOBAL_FS_GINTMSK  \ offset: 0x18 : OTG_FS interrupt mask register (OTG_FS_GINTMSK)
$5000001c constant OTG_FS_GLOBAL_FS_GRXSTSR_DEVICE  \ offset: 0x1C : OTG_FS Receive status debug read(Device mode)
$5000001c constant OTG_FS_GLOBAL_FS_GRXSTSR_HOST  \ offset: 0x1C : OTG_FS Receive status debug read(Hostmode)
$50000024 constant OTG_FS_GLOBAL_FS_GRXFSIZ  \ offset: 0x24 : OTG_FS Receive FIFO size register (OTG_FS_GRXFSIZ)
$50000028 constant OTG_FS_GLOBAL_FS_GNPTXFSIZ_DEVICE  \ offset: 0x28 : OTG_FS non-periodic transmit FIFO size register (Device mode)
$50000028 constant OTG_FS_GLOBAL_FS_GNPTXFSIZ_HOST  \ offset: 0x28 : OTG_FS non-periodic transmit FIFO size register (Host mode)
$5000002c constant OTG_FS_GLOBAL_FS_GNPTXSTS  \ offset: 0x2C : OTG_FS non-periodic transmit FIFO/queue status register (OTG_FS_GNPTXSTS)
$50000038 constant OTG_FS_GLOBAL_FS_GCCFG  \ offset: 0x38 : OTG_FS general core configuration register (OTG_FS_GCCFG)
$5000003c constant OTG_FS_GLOBAL_FS_CID  \ offset: 0x3C : core ID register
$50000100 constant OTG_FS_GLOBAL_FS_HPTXFSIZ  \ offset: 0x100 : OTG_FS Host periodic transmit FIFO size register (OTG_FS_HPTXFSIZ)
$50000104 constant OTG_FS_GLOBAL_FS_DIEPTXF1  \ offset: 0x104 : OTG_FS device IN endpoint transmit FIFO size register (OTG_FS_DIEPTXF1)
$50000108 constant OTG_FS_GLOBAL_FS_DIEPTXF2  \ offset: 0x108 : OTG_FS device IN endpoint transmit FIFO size register (OTG_FS_DIEPTXF2)
$5000010c constant OTG_FS_GLOBAL_FS_DIEPTXF3  \ offset: 0x10C : OTG_FS device IN endpoint transmit FIFO size register (OTG_FS_DIEPTXF3)
$50000110 constant OTG_FS_GLOBAL_FS_DIEPTXF4  \ offset: 0x110 : OTG_FS device IN endpoint transmit FIFO size register (OTG_FS_DIEPTXF4)
$50000114 constant OTG_FS_GLOBAL_FS_DIEPTXF5  \ offset: 0x114 : OTG_FS device IN endpoint transmit FIFO size register (OTG_FS_DIEPTXF5)

