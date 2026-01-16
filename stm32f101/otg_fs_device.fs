\
\ @file otg_fs_device.fs
\ @brief USB on the go full speed
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief OTG_FS device configuration register (OTG_FS_DCFG)
\ Address offset: 0x00
\ Reset value: 0x02200000
\

$00000003 constant OTG_FS_DEVICE_FS_DCFG_DSPD                       \ Device speed
$00000004 constant OTG_FS_DEVICE_FS_DCFG_NZLSOHSK                   \ Non-zero-length status OUT handshake
$000007f0 constant OTG_FS_DEVICE_FS_DCFG_DAD                        \ Device address
$00001800 constant OTG_FS_DEVICE_FS_DCFG_PFIVL                      \ Periodic frame interval


\
\ @brief OTG_FS device control register (OTG_FS_DCTL)
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$00000001 constant OTG_FS_DEVICE_FS_DCTL_RWUSIG                     \ Remote wakeup signaling
$00000002 constant OTG_FS_DEVICE_FS_DCTL_SDIS                       \ Soft disconnect
$00000004 constant OTG_FS_DEVICE_FS_DCTL_GINSTS                     \ Global IN NAK status
$00000008 constant OTG_FS_DEVICE_FS_DCTL_GONSTS                     \ Global OUT NAK status
$00000070 constant OTG_FS_DEVICE_FS_DCTL_TCTL                       \ Test control
$00000080 constant OTG_FS_DEVICE_FS_DCTL_SGINAK                     \ Set global IN NAK
$00000100 constant OTG_FS_DEVICE_FS_DCTL_CGINAK                     \ Clear global IN NAK
$00000200 constant OTG_FS_DEVICE_FS_DCTL_SGONAK                     \ Set global OUT NAK
$00000400 constant OTG_FS_DEVICE_FS_DCTL_CGONAK                     \ Clear global OUT NAK
$00000800 constant OTG_FS_DEVICE_FS_DCTL_POPRGDNE                   \ Power-on programming done


\
\ @brief OTG_FS device status register (OTG_FS_DSTS)
\ Address offset: 0x08
\ Reset value: 0x00000010
\

$00000001 constant OTG_FS_DEVICE_FS_DSTS_SUSPSTS                    \ Suspend status
$00000006 constant OTG_FS_DEVICE_FS_DSTS_ENUMSPD                    \ Enumerated speed
$00000008 constant OTG_FS_DEVICE_FS_DSTS_EERR                       \ Erratic error
$003fff00 constant OTG_FS_DEVICE_FS_DSTS_FNSOF                      \ Frame number of the received SOF


\
\ @brief OTG_FS device IN endpoint common interrupt mask register (OTG_FS_DIEPMSK)
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$00000001 constant OTG_FS_DEVICE_FS_DIEPMSK_XFRCM                   \ Transfer completed interrupt mask
$00000002 constant OTG_FS_DEVICE_FS_DIEPMSK_EPDM                    \ Endpoint disabled interrupt mask
$00000008 constant OTG_FS_DEVICE_FS_DIEPMSK_TOM                     \ Timeout condition mask (Non-isochronous endpoints)
$00000010 constant OTG_FS_DEVICE_FS_DIEPMSK_ITTXFEMSK               \ IN token received when TxFIFO empty mask
$00000020 constant OTG_FS_DEVICE_FS_DIEPMSK_INEPNMM                 \ IN token received with EP mismatch mask
$00000040 constant OTG_FS_DEVICE_FS_DIEPMSK_INEPNEM                 \ IN endpoint NAK effective mask


\
\ @brief OTG_FS device OUT endpoint common interrupt mask register (OTG_FS_DOEPMSK)
\ Address offset: 0x14
\ Reset value: 0x00000000
\

$00000001 constant OTG_FS_DEVICE_FS_DOEPMSK_XFRCM                   \ Transfer completed interrupt mask
$00000002 constant OTG_FS_DEVICE_FS_DOEPMSK_EPDM                    \ Endpoint disabled interrupt mask
$00000008 constant OTG_FS_DEVICE_FS_DOEPMSK_STUPM                   \ SETUP phase done mask
$00000010 constant OTG_FS_DEVICE_FS_DOEPMSK_OTEPDM                  \ OUT token received when endpoint disabled mask


\
\ @brief OTG_FS device all endpoints interrupt register (OTG_FS_DAINT)
\ Address offset: 0x18
\ Reset value: 0x00000000
\

$0000ffff constant OTG_FS_DEVICE_FS_DAINT_IEPINT                    \ IN endpoint interrupt bits
$ffff0000 constant OTG_FS_DEVICE_FS_DAINT_OEPINT                    \ OUT endpoint interrupt bits


\
\ @brief OTG_FS all endpoints interrupt mask register (OTG_FS_DAINTMSK)
\ Address offset: 0x1C
\ Reset value: 0x00000000
\

$0000ffff constant OTG_FS_DEVICE_FS_DAINTMSK_IEPM                   \ IN EP interrupt mask bits
$ffff0000 constant OTG_FS_DEVICE_FS_DAINTMSK_OEPINT                 \ OUT endpoint interrupt bits


\
\ @brief OTG_FS device VBUS discharge time register
\ Address offset: 0x28
\ Reset value: 0x000017D7
\

$0000ffff constant OTG_FS_DEVICE_DVBUSDIS_VBUSDT                    \ Device VBUS discharge time


\
\ @brief OTG_FS device VBUS pulsing time register
\ Address offset: 0x2C
\ Reset value: 0x000005B8
\

$00000fff constant OTG_FS_DEVICE_DVBUSPULSE_DVBUSP                  \ Device VBUS pulsing time


\
\ @brief OTG_FS device IN endpoint FIFO empty interrupt mask register
\ Address offset: 0x34
\ Reset value: 0x00000000
\

$0000ffff constant OTG_FS_DEVICE_DIEPEMPMSK_INEPTXFEM               \ IN EP Tx FIFO empty interrupt mask bits


\
\ @brief OTG_FS device control IN endpoint 0 control register (OTG_FS_DIEPCTL0)
\ Address offset: 0x100
\ Reset value: 0x00000000
\

$00000003 constant OTG_FS_DEVICE_FS_DIEPCTL0_MPSIZ                  \ Maximum packet size
$00008000 constant OTG_FS_DEVICE_FS_DIEPCTL0_USBAEP                 \ USB active endpoint
$00020000 constant OTG_FS_DEVICE_FS_DIEPCTL0_NAKSTS                 \ NAK status
$000c0000 constant OTG_FS_DEVICE_FS_DIEPCTL0_EPTYP                  \ Endpoint type
$00200000 constant OTG_FS_DEVICE_FS_DIEPCTL0_STALL                  \ STALL handshake
$03c00000 constant OTG_FS_DEVICE_FS_DIEPCTL0_TXFNUM                 \ TxFIFO number
$04000000 constant OTG_FS_DEVICE_FS_DIEPCTL0_CNAK                   \ Clear NAK
$08000000 constant OTG_FS_DEVICE_FS_DIEPCTL0_SNAK                   \ Set NAK
$40000000 constant OTG_FS_DEVICE_FS_DIEPCTL0_EPDIS                  \ Endpoint disable
$80000000 constant OTG_FS_DEVICE_FS_DIEPCTL0_EPENA                  \ Endpoint enable


\
\ @brief device endpoint-x interrupt register
\ Address offset: 0x108
\ Reset value: 0x00000080
\

$00000001 constant OTG_FS_DEVICE_DIEPINT0_XFRC                      \ XFRC
$00000002 constant OTG_FS_DEVICE_DIEPINT0_EPDISD                    \ EPDISD
$00000008 constant OTG_FS_DEVICE_DIEPINT0_TOC                       \ TOC
$00000010 constant OTG_FS_DEVICE_DIEPINT0_ITTXFE                    \ ITTXFE
$00000040 constant OTG_FS_DEVICE_DIEPINT0_INEPNE                    \ INEPNE
$00000080 constant OTG_FS_DEVICE_DIEPINT0_TXFE                      \ TXFE


\
\ @brief device endpoint-0 transfer size register
\ Address offset: 0x110
\ Reset value: 0x00000000
\

$0000007f constant OTG_FS_DEVICE_DIEPTSIZ0_XFRSIZ                   \ Transfer size
$00180000 constant OTG_FS_DEVICE_DIEPTSIZ0_PKTCNT                   \ Packet count


\
\ @brief OTG_FS device IN endpoint transmit FIFO status register
\ Address offset: 0x118
\ Reset value: 0x00000000
\

$0000ffff constant OTG_FS_DEVICE_DTXFSTS0_INEPTFSAV                 \ IN endpoint TxFIFO space available


\
\ @brief OTG device endpoint-1 control register
\ Address offset: 0x120
\ Reset value: 0x00000000
\

$000007ff constant OTG_FS_DEVICE_DIEPCTL1_MPSIZ                     \ MPSIZ
$00008000 constant OTG_FS_DEVICE_DIEPCTL1_USBAEP                    \ USBAEP
$00010000 constant OTG_FS_DEVICE_DIEPCTL1_EONUM_DPID                \ EONUM/DPID
$00020000 constant OTG_FS_DEVICE_DIEPCTL1_NAKSTS                    \ NAKSTS
$000c0000 constant OTG_FS_DEVICE_DIEPCTL1_EPTYP                     \ EPTYP
$00200000 constant OTG_FS_DEVICE_DIEPCTL1_STALL                     \ Stall
$03c00000 constant OTG_FS_DEVICE_DIEPCTL1_TXFNUM                    \ TXFNUM
$04000000 constant OTG_FS_DEVICE_DIEPCTL1_CNAK                      \ CNAK
$08000000 constant OTG_FS_DEVICE_DIEPCTL1_SNAK                      \ SNAK
$10000000 constant OTG_FS_DEVICE_DIEPCTL1_SD0PID_SEVNFRM            \ SD0PID/SEVNFRM
$20000000 constant OTG_FS_DEVICE_DIEPCTL1_SODDFRM_SD1PID            \ SODDFRM/SD1PID
$40000000 constant OTG_FS_DEVICE_DIEPCTL1_EPDIS                     \ EPDIS
$80000000 constant OTG_FS_DEVICE_DIEPCTL1_EPENA                     \ EPENA


\
\ @brief device endpoint-1 interrupt register
\ Address offset: 0x128
\ Reset value: 0x00000080
\

$00000001 constant OTG_FS_DEVICE_DIEPINT1_XFRC                      \ XFRC
$00000002 constant OTG_FS_DEVICE_DIEPINT1_EPDISD                    \ EPDISD
$00000008 constant OTG_FS_DEVICE_DIEPINT1_TOC                       \ TOC
$00000010 constant OTG_FS_DEVICE_DIEPINT1_ITTXFE                    \ ITTXFE
$00000040 constant OTG_FS_DEVICE_DIEPINT1_INEPNE                    \ INEPNE
$00000080 constant OTG_FS_DEVICE_DIEPINT1_TXFE                      \ TXFE


\
\ @brief device endpoint-1 transfer size register
\ Address offset: 0x130
\ Reset value: 0x00000000
\

$0007ffff constant OTG_FS_DEVICE_DIEPTSIZ1_XFRSIZ                   \ Transfer size
$1ff80000 constant OTG_FS_DEVICE_DIEPTSIZ1_PKTCNT                   \ Packet count
$60000000 constant OTG_FS_DEVICE_DIEPTSIZ1_MCNT                     \ Multi count


\
\ @brief OTG_FS device IN endpoint transmit FIFO status register
\ Address offset: 0x138
\ Reset value: 0x00000000
\

$0000ffff constant OTG_FS_DEVICE_DTXFSTS1_INEPTFSAV                 \ IN endpoint TxFIFO space available


\
\ @brief OTG device endpoint-2 control register
\ Address offset: 0x140
\ Reset value: 0x00000000
\

$000007ff constant OTG_FS_DEVICE_DIEPCTL2_MPSIZ                     \ MPSIZ
$00008000 constant OTG_FS_DEVICE_DIEPCTL2_USBAEP                    \ USBAEP
$00010000 constant OTG_FS_DEVICE_DIEPCTL2_EONUM_DPID                \ EONUM/DPID
$00020000 constant OTG_FS_DEVICE_DIEPCTL2_NAKSTS                    \ NAKSTS
$000c0000 constant OTG_FS_DEVICE_DIEPCTL2_EPTYP                     \ EPTYP
$00200000 constant OTG_FS_DEVICE_DIEPCTL2_STALL                     \ Stall
$03c00000 constant OTG_FS_DEVICE_DIEPCTL2_TXFNUM                    \ TXFNUM
$04000000 constant OTG_FS_DEVICE_DIEPCTL2_CNAK                      \ CNAK
$08000000 constant OTG_FS_DEVICE_DIEPCTL2_SNAK                      \ SNAK
$10000000 constant OTG_FS_DEVICE_DIEPCTL2_SD0PID_SEVNFRM            \ SD0PID/SEVNFRM
$20000000 constant OTG_FS_DEVICE_DIEPCTL2_SODDFRM                   \ SODDFRM
$40000000 constant OTG_FS_DEVICE_DIEPCTL2_EPDIS                     \ EPDIS
$80000000 constant OTG_FS_DEVICE_DIEPCTL2_EPENA                     \ EPENA


\
\ @brief device endpoint-2 interrupt register
\ Address offset: 0x148
\ Reset value: 0x00000080
\

$00000001 constant OTG_FS_DEVICE_DIEPINT2_XFRC                      \ XFRC
$00000002 constant OTG_FS_DEVICE_DIEPINT2_EPDISD                    \ EPDISD
$00000008 constant OTG_FS_DEVICE_DIEPINT2_TOC                       \ TOC
$00000010 constant OTG_FS_DEVICE_DIEPINT2_ITTXFE                    \ ITTXFE
$00000040 constant OTG_FS_DEVICE_DIEPINT2_INEPNE                    \ INEPNE
$00000080 constant OTG_FS_DEVICE_DIEPINT2_TXFE                      \ TXFE


\
\ @brief device endpoint-2 transfer size register
\ Address offset: 0x150
\ Reset value: 0x00000000
\

$0007ffff constant OTG_FS_DEVICE_DIEPTSIZ2_XFRSIZ                   \ Transfer size
$1ff80000 constant OTG_FS_DEVICE_DIEPTSIZ2_PKTCNT                   \ Packet count
$60000000 constant OTG_FS_DEVICE_DIEPTSIZ2_MCNT                     \ Multi count


\
\ @brief OTG_FS device IN endpoint transmit FIFO status register
\ Address offset: 0x158
\ Reset value: 0x00000000
\

$0000ffff constant OTG_FS_DEVICE_DTXFSTS2_INEPTFSAV                 \ IN endpoint TxFIFO space available


\
\ @brief OTG device endpoint-3 control register
\ Address offset: 0x160
\ Reset value: 0x00000000
\

$000007ff constant OTG_FS_DEVICE_DIEPCTL3_MPSIZ                     \ MPSIZ
$00008000 constant OTG_FS_DEVICE_DIEPCTL3_USBAEP                    \ USBAEP
$00010000 constant OTG_FS_DEVICE_DIEPCTL3_EONUM_DPID                \ EONUM/DPID
$00020000 constant OTG_FS_DEVICE_DIEPCTL3_NAKSTS                    \ NAKSTS
$000c0000 constant OTG_FS_DEVICE_DIEPCTL3_EPTYP                     \ EPTYP
$00200000 constant OTG_FS_DEVICE_DIEPCTL3_STALL                     \ Stall
$03c00000 constant OTG_FS_DEVICE_DIEPCTL3_TXFNUM                    \ TXFNUM
$04000000 constant OTG_FS_DEVICE_DIEPCTL3_CNAK                      \ CNAK
$08000000 constant OTG_FS_DEVICE_DIEPCTL3_SNAK                      \ SNAK
$10000000 constant OTG_FS_DEVICE_DIEPCTL3_SD0PID_SEVNFRM            \ SD0PID/SEVNFRM
$20000000 constant OTG_FS_DEVICE_DIEPCTL3_SODDFRM                   \ SODDFRM
$40000000 constant OTG_FS_DEVICE_DIEPCTL3_EPDIS                     \ EPDIS
$80000000 constant OTG_FS_DEVICE_DIEPCTL3_EPENA                     \ EPENA


\
\ @brief device endpoint-3 interrupt register
\ Address offset: 0x168
\ Reset value: 0x00000080
\

$00000001 constant OTG_FS_DEVICE_DIEPINT3_XFRC                      \ XFRC
$00000002 constant OTG_FS_DEVICE_DIEPINT3_EPDISD                    \ EPDISD
$00000008 constant OTG_FS_DEVICE_DIEPINT3_TOC                       \ TOC
$00000010 constant OTG_FS_DEVICE_DIEPINT3_ITTXFE                    \ ITTXFE
$00000040 constant OTG_FS_DEVICE_DIEPINT3_INEPNE                    \ INEPNE
$00000080 constant OTG_FS_DEVICE_DIEPINT3_TXFE                      \ TXFE


\
\ @brief device endpoint-3 transfer size register
\ Address offset: 0x170
\ Reset value: 0x00000000
\

$0007ffff constant OTG_FS_DEVICE_DIEPTSIZ3_XFRSIZ                   \ Transfer size
$1ff80000 constant OTG_FS_DEVICE_DIEPTSIZ3_PKTCNT                   \ Packet count
$60000000 constant OTG_FS_DEVICE_DIEPTSIZ3_MCNT                     \ Multi count


\
\ @brief OTG_FS device IN endpoint transmit FIFO status register
\ Address offset: 0x178
\ Reset value: 0x00000000
\

$0000ffff constant OTG_FS_DEVICE_DTXFSTS3_INEPTFSAV                 \ IN endpoint TxFIFO space available


\
\ @brief device endpoint-0 control register
\ Address offset: 0x300
\ Reset value: 0x00008000
\

$00000003 constant OTG_FS_DEVICE_DOEPCTL0_MPSIZ                     \ MPSIZ
$00008000 constant OTG_FS_DEVICE_DOEPCTL0_USBAEP                    \ USBAEP
$00020000 constant OTG_FS_DEVICE_DOEPCTL0_NAKSTS                    \ NAKSTS
$000c0000 constant OTG_FS_DEVICE_DOEPCTL0_EPTYP                     \ EPTYP
$00100000 constant OTG_FS_DEVICE_DOEPCTL0_SNPM                      \ SNPM
$00200000 constant OTG_FS_DEVICE_DOEPCTL0_STALL                     \ Stall
$04000000 constant OTG_FS_DEVICE_DOEPCTL0_CNAK                      \ CNAK
$08000000 constant OTG_FS_DEVICE_DOEPCTL0_SNAK                      \ SNAK
$40000000 constant OTG_FS_DEVICE_DOEPCTL0_EPDIS                     \ EPDIS
$80000000 constant OTG_FS_DEVICE_DOEPCTL0_EPENA                     \ EPENA


\
\ @brief device endpoint-0 interrupt register
\ Address offset: 0x308
\ Reset value: 0x00000080
\

$00000001 constant OTG_FS_DEVICE_DOEPINT0_XFRC                      \ XFRC
$00000002 constant OTG_FS_DEVICE_DOEPINT0_EPDISD                    \ EPDISD
$00000008 constant OTG_FS_DEVICE_DOEPINT0_STUP                      \ STUP
$00000010 constant OTG_FS_DEVICE_DOEPINT0_OTEPDIS                   \ OTEPDIS
$00000040 constant OTG_FS_DEVICE_DOEPINT0_B2BSTUP                   \ B2BSTUP


\
\ @brief device OUT endpoint-0 transfer size register
\ Address offset: 0x310
\ Reset value: 0x00000000
\

$0000007f constant OTG_FS_DEVICE_DOEPTSIZ0_XFRSIZ                   \ Transfer size
$00080000 constant OTG_FS_DEVICE_DOEPTSIZ0_PKTCNT                   \ Packet count
$60000000 constant OTG_FS_DEVICE_DOEPTSIZ0_STUPCNT                  \ SETUP packet count


\
\ @brief device endpoint-1 control register
\ Address offset: 0x320
\ Reset value: 0x00000000
\

$000007ff constant OTG_FS_DEVICE_DOEPCTL1_MPSIZ                     \ MPSIZ
$00008000 constant OTG_FS_DEVICE_DOEPCTL1_USBAEP                    \ USBAEP
$00010000 constant OTG_FS_DEVICE_DOEPCTL1_EONUM_DPID                \ EONUM/DPID
$00020000 constant OTG_FS_DEVICE_DOEPCTL1_NAKSTS                    \ NAKSTS
$000c0000 constant OTG_FS_DEVICE_DOEPCTL1_EPTYP                     \ EPTYP
$00100000 constant OTG_FS_DEVICE_DOEPCTL1_SNPM                      \ SNPM
$00200000 constant OTG_FS_DEVICE_DOEPCTL1_STALL                     \ Stall
$04000000 constant OTG_FS_DEVICE_DOEPCTL1_CNAK                      \ CNAK
$08000000 constant OTG_FS_DEVICE_DOEPCTL1_SNAK                      \ SNAK
$10000000 constant OTG_FS_DEVICE_DOEPCTL1_SD0PID_SEVNFRM            \ SD0PID/SEVNFRM
$20000000 constant OTG_FS_DEVICE_DOEPCTL1_SODDFRM                   \ SODDFRM
$40000000 constant OTG_FS_DEVICE_DOEPCTL1_EPDIS                     \ EPDIS
$80000000 constant OTG_FS_DEVICE_DOEPCTL1_EPENA                     \ EPENA


\
\ @brief device endpoint-1 interrupt register
\ Address offset: 0x328
\ Reset value: 0x00000080
\

$00000001 constant OTG_FS_DEVICE_DOEPINT1_XFRC                      \ XFRC
$00000002 constant OTG_FS_DEVICE_DOEPINT1_EPDISD                    \ EPDISD
$00000008 constant OTG_FS_DEVICE_DOEPINT1_STUP                      \ STUP
$00000010 constant OTG_FS_DEVICE_DOEPINT1_OTEPDIS                   \ OTEPDIS
$00000040 constant OTG_FS_DEVICE_DOEPINT1_B2BSTUP                   \ B2BSTUP


\
\ @brief device OUT endpoint-1 transfer size register
\ Address offset: 0x330
\ Reset value: 0x00000000
\

$0007ffff constant OTG_FS_DEVICE_DOEPTSIZ1_XFRSIZ                   \ Transfer size
$1ff80000 constant OTG_FS_DEVICE_DOEPTSIZ1_PKTCNT                   \ Packet count
$60000000 constant OTG_FS_DEVICE_DOEPTSIZ1_RXDPID_STUPCNT           \ Received data PID/SETUP packet count


\
\ @brief device endpoint-2 control register
\ Address offset: 0x340
\ Reset value: 0x00000000
\

$000007ff constant OTG_FS_DEVICE_DOEPCTL2_MPSIZ                     \ MPSIZ
$00008000 constant OTG_FS_DEVICE_DOEPCTL2_USBAEP                    \ USBAEP
$00010000 constant OTG_FS_DEVICE_DOEPCTL2_EONUM_DPID                \ EONUM/DPID
$00020000 constant OTG_FS_DEVICE_DOEPCTL2_NAKSTS                    \ NAKSTS
$000c0000 constant OTG_FS_DEVICE_DOEPCTL2_EPTYP                     \ EPTYP
$00100000 constant OTG_FS_DEVICE_DOEPCTL2_SNPM                      \ SNPM
$00200000 constant OTG_FS_DEVICE_DOEPCTL2_STALL                     \ Stall
$04000000 constant OTG_FS_DEVICE_DOEPCTL2_CNAK                      \ CNAK
$08000000 constant OTG_FS_DEVICE_DOEPCTL2_SNAK                      \ SNAK
$10000000 constant OTG_FS_DEVICE_DOEPCTL2_SD0PID_SEVNFRM            \ SD0PID/SEVNFRM
$20000000 constant OTG_FS_DEVICE_DOEPCTL2_SODDFRM                   \ SODDFRM
$40000000 constant OTG_FS_DEVICE_DOEPCTL2_EPDIS                     \ EPDIS
$80000000 constant OTG_FS_DEVICE_DOEPCTL2_EPENA                     \ EPENA


\
\ @brief device endpoint-2 interrupt register
\ Address offset: 0x348
\ Reset value: 0x00000080
\

$00000001 constant OTG_FS_DEVICE_DOEPINT2_XFRC                      \ XFRC
$00000002 constant OTG_FS_DEVICE_DOEPINT2_EPDISD                    \ EPDISD
$00000008 constant OTG_FS_DEVICE_DOEPINT2_STUP                      \ STUP
$00000010 constant OTG_FS_DEVICE_DOEPINT2_OTEPDIS                   \ OTEPDIS
$00000040 constant OTG_FS_DEVICE_DOEPINT2_B2BSTUP                   \ B2BSTUP


\
\ @brief device OUT endpoint-2 transfer size register
\ Address offset: 0x350
\ Reset value: 0x00000000
\

$0007ffff constant OTG_FS_DEVICE_DOEPTSIZ2_XFRSIZ                   \ Transfer size
$1ff80000 constant OTG_FS_DEVICE_DOEPTSIZ2_PKTCNT                   \ Packet count
$60000000 constant OTG_FS_DEVICE_DOEPTSIZ2_RXDPID_STUPCNT           \ Received data PID/SETUP packet count


\
\ @brief device endpoint-3 control register
\ Address offset: 0x360
\ Reset value: 0x00000000
\

$000007ff constant OTG_FS_DEVICE_DOEPCTL3_MPSIZ                     \ MPSIZ
$00008000 constant OTG_FS_DEVICE_DOEPCTL3_USBAEP                    \ USBAEP
$00010000 constant OTG_FS_DEVICE_DOEPCTL3_EONUM_DPID                \ EONUM/DPID
$00020000 constant OTG_FS_DEVICE_DOEPCTL3_NAKSTS                    \ NAKSTS
$000c0000 constant OTG_FS_DEVICE_DOEPCTL3_EPTYP                     \ EPTYP
$00100000 constant OTG_FS_DEVICE_DOEPCTL3_SNPM                      \ SNPM
$00200000 constant OTG_FS_DEVICE_DOEPCTL3_STALL                     \ Stall
$04000000 constant OTG_FS_DEVICE_DOEPCTL3_CNAK                      \ CNAK
$08000000 constant OTG_FS_DEVICE_DOEPCTL3_SNAK                      \ SNAK
$10000000 constant OTG_FS_DEVICE_DOEPCTL3_SD0PID_SEVNFRM            \ SD0PID/SEVNFRM
$20000000 constant OTG_FS_DEVICE_DOEPCTL3_SODDFRM                   \ SODDFRM
$40000000 constant OTG_FS_DEVICE_DOEPCTL3_EPDIS                     \ EPDIS
$80000000 constant OTG_FS_DEVICE_DOEPCTL3_EPENA                     \ EPENA


\
\ @brief device endpoint-3 interrupt register
\ Address offset: 0x368
\ Reset value: 0x00000080
\

$00000001 constant OTG_FS_DEVICE_DOEPINT3_XFRC                      \ XFRC
$00000002 constant OTG_FS_DEVICE_DOEPINT3_EPDISD                    \ EPDISD
$00000008 constant OTG_FS_DEVICE_DOEPINT3_STUP                      \ STUP
$00000010 constant OTG_FS_DEVICE_DOEPINT3_OTEPDIS                   \ OTEPDIS
$00000040 constant OTG_FS_DEVICE_DOEPINT3_B2BSTUP                   \ B2BSTUP


\
\ @brief device OUT endpoint-3 transfer size register
\ Address offset: 0x370
\ Reset value: 0x00000000
\

$0007ffff constant OTG_FS_DEVICE_DOEPTSIZ3_XFRSIZ                   \ Transfer size
$1ff80000 constant OTG_FS_DEVICE_DOEPTSIZ3_PKTCNT                   \ Packet count
$60000000 constant OTG_FS_DEVICE_DOEPTSIZ3_RXDPID_STUPCNT           \ Received data PID/SETUP packet count


\
\ @brief USB on the go full speed
\
$50000800 constant OTG_FS_DEVICE_FS_DCFG  \ offset: 0x00 : OTG_FS device configuration register (OTG_FS_DCFG)
$50000804 constant OTG_FS_DEVICE_FS_DCTL  \ offset: 0x04 : OTG_FS device control register (OTG_FS_DCTL)
$50000808 constant OTG_FS_DEVICE_FS_DSTS  \ offset: 0x08 : OTG_FS device status register (OTG_FS_DSTS)
$50000810 constant OTG_FS_DEVICE_FS_DIEPMSK  \ offset: 0x10 : OTG_FS device IN endpoint common interrupt mask register (OTG_FS_DIEPMSK)
$50000814 constant OTG_FS_DEVICE_FS_DOEPMSK  \ offset: 0x14 : OTG_FS device OUT endpoint common interrupt mask register (OTG_FS_DOEPMSK)
$50000818 constant OTG_FS_DEVICE_FS_DAINT  \ offset: 0x18 : OTG_FS device all endpoints interrupt register (OTG_FS_DAINT)
$5000081c constant OTG_FS_DEVICE_FS_DAINTMSK  \ offset: 0x1C : OTG_FS all endpoints interrupt mask register (OTG_FS_DAINTMSK)
$50000828 constant OTG_FS_DEVICE_DVBUSDIS  \ offset: 0x28 : OTG_FS device VBUS discharge time register
$5000082c constant OTG_FS_DEVICE_DVBUSPULSE  \ offset: 0x2C : OTG_FS device VBUS pulsing time register
$50000834 constant OTG_FS_DEVICE_DIEPEMPMSK  \ offset: 0x34 : OTG_FS device IN endpoint FIFO empty interrupt mask register
$50000900 constant OTG_FS_DEVICE_FS_DIEPCTL0  \ offset: 0x100 : OTG_FS device control IN endpoint 0 control register (OTG_FS_DIEPCTL0)
$50000908 constant OTG_FS_DEVICE_DIEPINT0  \ offset: 0x108 : device endpoint-x interrupt register
$50000910 constant OTG_FS_DEVICE_DIEPTSIZ0  \ offset: 0x110 : device endpoint-0 transfer size register
$50000918 constant OTG_FS_DEVICE_DTXFSTS0  \ offset: 0x118 : OTG_FS device IN endpoint transmit FIFO status register
$50000920 constant OTG_FS_DEVICE_DIEPCTL1  \ offset: 0x120 : OTG device endpoint-1 control register
$50000928 constant OTG_FS_DEVICE_DIEPINT1  \ offset: 0x128 : device endpoint-1 interrupt register
$50000930 constant OTG_FS_DEVICE_DIEPTSIZ1  \ offset: 0x130 : device endpoint-1 transfer size register
$50000938 constant OTG_FS_DEVICE_DTXFSTS1  \ offset: 0x138 : OTG_FS device IN endpoint transmit FIFO status register
$50000940 constant OTG_FS_DEVICE_DIEPCTL2  \ offset: 0x140 : OTG device endpoint-2 control register
$50000948 constant OTG_FS_DEVICE_DIEPINT2  \ offset: 0x148 : device endpoint-2 interrupt register
$50000950 constant OTG_FS_DEVICE_DIEPTSIZ2  \ offset: 0x150 : device endpoint-2 transfer size register
$50000958 constant OTG_FS_DEVICE_DTXFSTS2  \ offset: 0x158 : OTG_FS device IN endpoint transmit FIFO status register
$50000960 constant OTG_FS_DEVICE_DIEPCTL3  \ offset: 0x160 : OTG device endpoint-3 control register
$50000968 constant OTG_FS_DEVICE_DIEPINT3  \ offset: 0x168 : device endpoint-3 interrupt register
$50000970 constant OTG_FS_DEVICE_DIEPTSIZ3  \ offset: 0x170 : device endpoint-3 transfer size register
$50000978 constant OTG_FS_DEVICE_DTXFSTS3  \ offset: 0x178 : OTG_FS device IN endpoint transmit FIFO status register
$50000b00 constant OTG_FS_DEVICE_DOEPCTL0  \ offset: 0x300 : device endpoint-0 control register
$50000b08 constant OTG_FS_DEVICE_DOEPINT0  \ offset: 0x308 : device endpoint-0 interrupt register
$50000b10 constant OTG_FS_DEVICE_DOEPTSIZ0  \ offset: 0x310 : device OUT endpoint-0 transfer size register
$50000b20 constant OTG_FS_DEVICE_DOEPCTL1  \ offset: 0x320 : device endpoint-1 control register
$50000b28 constant OTG_FS_DEVICE_DOEPINT1  \ offset: 0x328 : device endpoint-1 interrupt register
$50000b30 constant OTG_FS_DEVICE_DOEPTSIZ1  \ offset: 0x330 : device OUT endpoint-1 transfer size register
$50000b40 constant OTG_FS_DEVICE_DOEPCTL2  \ offset: 0x340 : device endpoint-2 control register
$50000b48 constant OTG_FS_DEVICE_DOEPINT2  \ offset: 0x348 : device endpoint-2 interrupt register
$50000b50 constant OTG_FS_DEVICE_DOEPTSIZ2  \ offset: 0x350 : device OUT endpoint-2 transfer size register
$50000b60 constant OTG_FS_DEVICE_DOEPCTL3  \ offset: 0x360 : device endpoint-3 control register
$50000b68 constant OTG_FS_DEVICE_DOEPINT3  \ offset: 0x368 : device endpoint-3 interrupt register
$50000b70 constant OTG_FS_DEVICE_DOEPTSIZ3  \ offset: 0x370 : device OUT endpoint-3 transfer size register

