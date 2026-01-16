\
\ @file otg2_hs_device.fs
\ @brief USB 1 on the go high speed
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief OTG_HS device configuration register
\ Address offset: 0x00
\ Reset value: 0x02200000
\

$00000003 constant OTG2_HS_DEVICE_OTG_HS_DCFG_DSPD                  \ Device speed
$00000004 constant OTG2_HS_DEVICE_OTG_HS_DCFG_NZLSOHSK              \ Nonzero-length status OUT handshake
$000007f0 constant OTG2_HS_DEVICE_OTG_HS_DCFG_DAD                   \ Device address
$00001800 constant OTG2_HS_DEVICE_OTG_HS_DCFG_PFIVL                 \ Periodic (micro)frame interval
$03000000 constant OTG2_HS_DEVICE_OTG_HS_DCFG_PERSCHIVL             \ Periodic scheduling interval


\
\ @brief OTG_HS device control register
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$00000001 constant OTG2_HS_DEVICE_OTG_HS_DCTL_RWUSIG                \ Remote wakeup signaling
$00000002 constant OTG2_HS_DEVICE_OTG_HS_DCTL_SDIS                  \ Soft disconnect
$00000004 constant OTG2_HS_DEVICE_OTG_HS_DCTL_GINSTS                \ Global IN NAK status
$00000008 constant OTG2_HS_DEVICE_OTG_HS_DCTL_GONSTS                \ Global OUT NAK status
$00000070 constant OTG2_HS_DEVICE_OTG_HS_DCTL_TCTL                  \ Test control
$00000080 constant OTG2_HS_DEVICE_OTG_HS_DCTL_SGINAK                \ Set global IN NAK
$00000100 constant OTG2_HS_DEVICE_OTG_HS_DCTL_CGINAK                \ Clear global IN NAK
$00000200 constant OTG2_HS_DEVICE_OTG_HS_DCTL_SGONAK                \ Set global OUT NAK
$00000400 constant OTG2_HS_DEVICE_OTG_HS_DCTL_CGONAK                \ Clear global OUT NAK
$00000800 constant OTG2_HS_DEVICE_OTG_HS_DCTL_POPRGDNE              \ Power-on programming done


\
\ @brief OTG_HS device status register
\ Address offset: 0x08
\ Reset value: 0x00000010
\

$00000001 constant OTG2_HS_DEVICE_OTG_HS_DSTS_SUSPSTS               \ Suspend status
$00000006 constant OTG2_HS_DEVICE_OTG_HS_DSTS_ENUMSPD               \ Enumerated speed
$00000008 constant OTG2_HS_DEVICE_OTG_HS_DSTS_EERR                  \ Erratic error
$003fff00 constant OTG2_HS_DEVICE_OTG_HS_DSTS_FNSOF                 \ Frame number of the received SOF


\
\ @brief OTG_HS device IN endpoint common interrupt mask register
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$00000001 constant OTG2_HS_DEVICE_OTG_HS_DIEPMSK_XFRCM              \ Transfer completed interrupt mask
$00000002 constant OTG2_HS_DEVICE_OTG_HS_DIEPMSK_EPDM               \ Endpoint disabled interrupt mask
$00000008 constant OTG2_HS_DEVICE_OTG_HS_DIEPMSK_TOM                \ Timeout condition mask (nonisochronous endpoints)
$00000010 constant OTG2_HS_DEVICE_OTG_HS_DIEPMSK_ITTXFEMSK          \ IN token received when TxFIFO empty mask
$00000020 constant OTG2_HS_DEVICE_OTG_HS_DIEPMSK_INEPNMM            \ IN token received with EP mismatch mask
$00000040 constant OTG2_HS_DEVICE_OTG_HS_DIEPMSK_INEPNEM            \ IN endpoint NAK effective mask
$00000100 constant OTG2_HS_DEVICE_OTG_HS_DIEPMSK_TXFURM             \ FIFO underrun mask
$00000200 constant OTG2_HS_DEVICE_OTG_HS_DIEPMSK_BIM                \ BNA interrupt mask


\
\ @brief OTG_HS device OUT endpoint common interrupt mask register
\ Address offset: 0x14
\ Reset value: 0x00000000
\

$00000001 constant OTG2_HS_DEVICE_OTG_HS_DOEPMSK_XFRCM              \ Transfer completed interrupt mask
$00000002 constant OTG2_HS_DEVICE_OTG_HS_DOEPMSK_EPDM               \ Endpoint disabled interrupt mask
$00000008 constant OTG2_HS_DEVICE_OTG_HS_DOEPMSK_STUPM              \ SETUP phase done mask
$00000010 constant OTG2_HS_DEVICE_OTG_HS_DOEPMSK_OTEPDM             \ OUT token received when endpoint disabled mask
$00000040 constant OTG2_HS_DEVICE_OTG_HS_DOEPMSK_B2BSTUP            \ Back-to-back SETUP packets received mask
$00000100 constant OTG2_HS_DEVICE_OTG_HS_DOEPMSK_OPEM               \ OUT packet error mask
$00000200 constant OTG2_HS_DEVICE_OTG_HS_DOEPMSK_BOIM               \ BNA interrupt mask


\
\ @brief OTG_HS device all endpoints interrupt register
\ Address offset: 0x18
\ Reset value: 0x00000000
\

$0000ffff constant OTG2_HS_DEVICE_OTG_HS_DAINT_IEPINT               \ IN endpoint interrupt bits
$ffff0000 constant OTG2_HS_DEVICE_OTG_HS_DAINT_OEPINT               \ OUT endpoint interrupt bits


\
\ @brief OTG_HS all endpoints interrupt mask register
\ Address offset: 0x1C
\ Reset value: 0x00000000
\

$0000ffff constant OTG2_HS_DEVICE_OTG_HS_DAINTMSK_IEPM              \ IN EP interrupt mask bits
$ffff0000 constant OTG2_HS_DEVICE_OTG_HS_DAINTMSK_OEPM              \ OUT EP interrupt mask bits


\
\ @brief OTG_HS device VBUS discharge time register
\ Address offset: 0x28
\ Reset value: 0x000017D7
\

$0000ffff constant OTG2_HS_DEVICE_OTG_HS_DVBUSDIS_VBUSDT            \ Device VBUS discharge time


\
\ @brief OTG_HS device VBUS pulsing time register
\ Address offset: 0x2C
\ Reset value: 0x000005B8
\

$00000fff constant OTG2_HS_DEVICE_OTG_HS_DVBUSPULSE_DVBUSP          \ Device VBUS pulsing time


\
\ @brief OTG_HS Device threshold control register
\ Address offset: 0x30
\ Reset value: 0x00000000
\

$00000001 constant OTG2_HS_DEVICE_OTG_HS_DTHRCTL_NONISOTHREN        \ Nonisochronous IN endpoints threshold enable
$00000002 constant OTG2_HS_DEVICE_OTG_HS_DTHRCTL_ISOTHREN           \ ISO IN endpoint threshold enable
$000007fc constant OTG2_HS_DEVICE_OTG_HS_DTHRCTL_TXTHRLEN           \ Transmit threshold length
$00010000 constant OTG2_HS_DEVICE_OTG_HS_DTHRCTL_RXTHREN            \ Receive threshold enable
$03fe0000 constant OTG2_HS_DEVICE_OTG_HS_DTHRCTL_RXTHRLEN           \ Receive threshold length
$08000000 constant OTG2_HS_DEVICE_OTG_HS_DTHRCTL_ARPEN              \ Arbiter parking enable


\
\ @brief OTG_HS device IN endpoint FIFO empty interrupt mask register
\ Address offset: 0x34
\ Reset value: 0x00000000
\

$0000ffff constant OTG2_HS_DEVICE_OTG_HS_DIEPEMPMSK_INEPTXFEM       \ IN EP Tx FIFO empty interrupt mask bits


\
\ @brief OTG_HS device each endpoint interrupt register
\ Address offset: 0x38
\ Reset value: 0x00000000
\

$00000002 constant OTG2_HS_DEVICE_OTG_HS_DEACHINT_IEP1INT           \ IN endpoint 1interrupt bit
$00020000 constant OTG2_HS_DEVICE_OTG_HS_DEACHINT_OEP1INT           \ OUT endpoint 1 interrupt bit


\
\ @brief OTG_HS device each endpoint interrupt register mask
\ Address offset: 0x3C
\ Reset value: 0x00000000
\

$00000002 constant OTG2_HS_DEVICE_OTG_HS_DEACHINTMSK_IEP1INTM       \ IN Endpoint 1 interrupt mask bit
$00020000 constant OTG2_HS_DEVICE_OTG_HS_DEACHINTMSK_OEP1INTM       \ OUT Endpoint 1 interrupt mask bit


\
\ @brief OTG device endpoint-0 control register
\ Address offset: 0x100
\ Reset value: 0x00000000
\

$000007ff constant OTG2_HS_DEVICE_OTG_HS_DIEPCTL0_MPSIZ             \ Maximum packet size
$00008000 constant OTG2_HS_DEVICE_OTG_HS_DIEPCTL0_USBAEP            \ USB active endpoint
$00010000 constant OTG2_HS_DEVICE_OTG_HS_DIEPCTL0_EONUM_DPID        \ Even/odd frame
$00020000 constant OTG2_HS_DEVICE_OTG_HS_DIEPCTL0_NAKSTS            \ NAK status
$000c0000 constant OTG2_HS_DEVICE_OTG_HS_DIEPCTL0_EPTYP             \ Endpoint type
$00200000 constant OTG2_HS_DEVICE_OTG_HS_DIEPCTL0_STALL             \ STALL handshake
$03c00000 constant OTG2_HS_DEVICE_OTG_HS_DIEPCTL0_TXFNUM            \ TxFIFO number
$04000000 constant OTG2_HS_DEVICE_OTG_HS_DIEPCTL0_CNAK              \ Clear NAK
$08000000 constant OTG2_HS_DEVICE_OTG_HS_DIEPCTL0_SNAK              \ Set NAK
$10000000 constant OTG2_HS_DEVICE_OTG_HS_DIEPCTL0_SD0PID_SEVNFRM    \ Set DATA0 PID
$20000000 constant OTG2_HS_DEVICE_OTG_HS_DIEPCTL0_SODDFRM           \ Set odd frame
$40000000 constant OTG2_HS_DEVICE_OTG_HS_DIEPCTL0_EPDIS             \ Endpoint disable
$80000000 constant OTG2_HS_DEVICE_OTG_HS_DIEPCTL0_EPENA             \ Endpoint enable


\
\ @brief OTG device endpoint-0 interrupt register
\ Address offset: 0x108
\ Reset value: 0x00000080
\

$00000001 constant OTG2_HS_DEVICE_OTG_HS_DIEPINT0_XFRC              \ Transfer completed interrupt
$00000002 constant OTG2_HS_DEVICE_OTG_HS_DIEPINT0_EPDISD            \ Endpoint disabled interrupt
$00000008 constant OTG2_HS_DEVICE_OTG_HS_DIEPINT0_TOC               \ Timeout condition
$00000010 constant OTG2_HS_DEVICE_OTG_HS_DIEPINT0_ITTXFE            \ IN token received when TxFIFO is empty
$00000040 constant OTG2_HS_DEVICE_OTG_HS_DIEPINT0_INEPNE            \ IN endpoint NAK effective
$00000080 constant OTG2_HS_DEVICE_OTG_HS_DIEPINT0_TXFE              \ Transmit FIFO empty
$00000100 constant OTG2_HS_DEVICE_OTG_HS_DIEPINT0_TXFIFOUDRN        \ Transmit Fifo Underrun
$00000200 constant OTG2_HS_DEVICE_OTG_HS_DIEPINT0_BNA               \ Buffer not available interrupt
$00000800 constant OTG2_HS_DEVICE_OTG_HS_DIEPINT0_PKTDRPSTS         \ Packet dropped status
$00001000 constant OTG2_HS_DEVICE_OTG_HS_DIEPINT0_BERR              \ Babble error interrupt
$00002000 constant OTG2_HS_DEVICE_OTG_HS_DIEPINT0_NAK               \ NAK interrupt


\
\ @brief OTG_HS device IN endpoint 0 transfer size register
\ Address offset: 0x110
\ Reset value: 0x00000000
\

$0000007f constant OTG2_HS_DEVICE_OTG_HS_DIEPTSIZ0_XFRSIZ           \ Transfer size
$00180000 constant OTG2_HS_DEVICE_OTG_HS_DIEPTSIZ0_PKTCNT           \ Packet count


\
\ @brief OTG_HS device endpoint-1 DMA address register
\ Address offset: 0x114
\ Reset value: 0x00000000
\

$00000000 constant OTG2_HS_DEVICE_OTG_HS_DIEPDMA1_DMAADDR           \ DMA address


\
\ @brief OTG_HS device IN endpoint transmit FIFO status register
\ Address offset: 0x118
\ Reset value: 0x00000000
\

$0000ffff constant OTG2_HS_DEVICE_OTG_HS_DTXFSTS0_INEPTFSAV         \ IN endpoint TxFIFO space avail


\
\ @brief OTG device endpoint-1 control register
\ Address offset: 0x120
\ Reset value: 0x00000000
\

$000007ff constant OTG2_HS_DEVICE_OTG_HS_DIEPCTL1_MPSIZ             \ Maximum packet size
$00008000 constant OTG2_HS_DEVICE_OTG_HS_DIEPCTL1_USBAEP            \ USB active endpoint
$00010000 constant OTG2_HS_DEVICE_OTG_HS_DIEPCTL1_EONUM_DPID        \ Even/odd frame
$00020000 constant OTG2_HS_DEVICE_OTG_HS_DIEPCTL1_NAKSTS            \ NAK status
$000c0000 constant OTG2_HS_DEVICE_OTG_HS_DIEPCTL1_EPTYP             \ Endpoint type
$00200000 constant OTG2_HS_DEVICE_OTG_HS_DIEPCTL1_STALL             \ STALL handshake
$03c00000 constant OTG2_HS_DEVICE_OTG_HS_DIEPCTL1_TXFNUM            \ TxFIFO number
$04000000 constant OTG2_HS_DEVICE_OTG_HS_DIEPCTL1_CNAK              \ Clear NAK
$08000000 constant OTG2_HS_DEVICE_OTG_HS_DIEPCTL1_SNAK              \ Set NAK
$10000000 constant OTG2_HS_DEVICE_OTG_HS_DIEPCTL1_SD0PID_SEVNFRM    \ Set DATA0 PID
$20000000 constant OTG2_HS_DEVICE_OTG_HS_DIEPCTL1_SODDFRM           \ Set odd frame
$40000000 constant OTG2_HS_DEVICE_OTG_HS_DIEPCTL1_EPDIS             \ Endpoint disable
$80000000 constant OTG2_HS_DEVICE_OTG_HS_DIEPCTL1_EPENA             \ Endpoint enable


\
\ @brief OTG device endpoint-1 interrupt register
\ Address offset: 0x128
\ Reset value: 0x00000000
\

$00000001 constant OTG2_HS_DEVICE_OTG_HS_DIEPINT1_XFRC              \ Transfer completed interrupt
$00000002 constant OTG2_HS_DEVICE_OTG_HS_DIEPINT1_EPDISD            \ Endpoint disabled interrupt
$00000008 constant OTG2_HS_DEVICE_OTG_HS_DIEPINT1_TOC               \ Timeout condition
$00000010 constant OTG2_HS_DEVICE_OTG_HS_DIEPINT1_ITTXFE            \ IN token received when TxFIFO is empty
$00000040 constant OTG2_HS_DEVICE_OTG_HS_DIEPINT1_INEPNE            \ IN endpoint NAK effective
$00000080 constant OTG2_HS_DEVICE_OTG_HS_DIEPINT1_TXFE              \ Transmit FIFO empty
$00000100 constant OTG2_HS_DEVICE_OTG_HS_DIEPINT1_TXFIFOUDRN        \ Transmit Fifo Underrun
$00000200 constant OTG2_HS_DEVICE_OTG_HS_DIEPINT1_BNA               \ Buffer not available interrupt
$00000800 constant OTG2_HS_DEVICE_OTG_HS_DIEPINT1_PKTDRPSTS         \ Packet dropped status
$00001000 constant OTG2_HS_DEVICE_OTG_HS_DIEPINT1_BERR              \ Babble error interrupt
$00002000 constant OTG2_HS_DEVICE_OTG_HS_DIEPINT1_NAK               \ NAK interrupt


\
\ @brief OTG_HS device endpoint transfer size register
\ Address offset: 0x130
\ Reset value: 0x00000000
\

$0007ffff constant OTG2_HS_DEVICE_OTG_HS_DIEPTSIZ1_XFRSIZ           \ Transfer size
$1ff80000 constant OTG2_HS_DEVICE_OTG_HS_DIEPTSIZ1_PKTCNT           \ Packet count
$60000000 constant OTG2_HS_DEVICE_OTG_HS_DIEPTSIZ1_MCNT             \ Multi count


\
\ @brief OTG_HS device endpoint-2 DMA address register
\ Address offset: 0x134
\ Reset value: 0x00000000
\

$00000000 constant OTG2_HS_DEVICE_OTG_HS_DIEPDMA2_DMAADDR           \ DMA address


\
\ @brief OTG_HS device IN endpoint transmit FIFO status register
\ Address offset: 0x138
\ Reset value: 0x00000000
\

$0000ffff constant OTG2_HS_DEVICE_OTG_HS_DTXFSTS1_INEPTFSAV         \ IN endpoint TxFIFO space avail


\
\ @brief OTG device endpoint-2 control register
\ Address offset: 0x140
\ Reset value: 0x00000000
\

$000007ff constant OTG2_HS_DEVICE_OTG_HS_DIEPCTL2_MPSIZ             \ Maximum packet size
$00008000 constant OTG2_HS_DEVICE_OTG_HS_DIEPCTL2_USBAEP            \ USB active endpoint
$00010000 constant OTG2_HS_DEVICE_OTG_HS_DIEPCTL2_EONUM_DPID        \ Even/odd frame
$00020000 constant OTG2_HS_DEVICE_OTG_HS_DIEPCTL2_NAKSTS            \ NAK status
$000c0000 constant OTG2_HS_DEVICE_OTG_HS_DIEPCTL2_EPTYP             \ Endpoint type
$00200000 constant OTG2_HS_DEVICE_OTG_HS_DIEPCTL2_STALL             \ STALL handshake
$03c00000 constant OTG2_HS_DEVICE_OTG_HS_DIEPCTL2_TXFNUM            \ TxFIFO number
$04000000 constant OTG2_HS_DEVICE_OTG_HS_DIEPCTL2_CNAK              \ Clear NAK
$08000000 constant OTG2_HS_DEVICE_OTG_HS_DIEPCTL2_SNAK              \ Set NAK
$10000000 constant OTG2_HS_DEVICE_OTG_HS_DIEPCTL2_SD0PID_SEVNFRM    \ Set DATA0 PID
$20000000 constant OTG2_HS_DEVICE_OTG_HS_DIEPCTL2_SODDFRM           \ Set odd frame
$40000000 constant OTG2_HS_DEVICE_OTG_HS_DIEPCTL2_EPDIS             \ Endpoint disable
$80000000 constant OTG2_HS_DEVICE_OTG_HS_DIEPCTL2_EPENA             \ Endpoint enable


\
\ @brief OTG device endpoint-2 interrupt register
\ Address offset: 0x148
\ Reset value: 0x00000000
\

$00000001 constant OTG2_HS_DEVICE_OTG_HS_DIEPINT2_XFRC              \ Transfer completed interrupt
$00000002 constant OTG2_HS_DEVICE_OTG_HS_DIEPINT2_EPDISD            \ Endpoint disabled interrupt
$00000008 constant OTG2_HS_DEVICE_OTG_HS_DIEPINT2_TOC               \ Timeout condition
$00000010 constant OTG2_HS_DEVICE_OTG_HS_DIEPINT2_ITTXFE            \ IN token received when TxFIFO is empty
$00000040 constant OTG2_HS_DEVICE_OTG_HS_DIEPINT2_INEPNE            \ IN endpoint NAK effective
$00000080 constant OTG2_HS_DEVICE_OTG_HS_DIEPINT2_TXFE              \ Transmit FIFO empty
$00000100 constant OTG2_HS_DEVICE_OTG_HS_DIEPINT2_TXFIFOUDRN        \ Transmit Fifo Underrun
$00000200 constant OTG2_HS_DEVICE_OTG_HS_DIEPINT2_BNA               \ Buffer not available interrupt
$00000800 constant OTG2_HS_DEVICE_OTG_HS_DIEPINT2_PKTDRPSTS         \ Packet dropped status
$00001000 constant OTG2_HS_DEVICE_OTG_HS_DIEPINT2_BERR              \ Babble error interrupt
$00002000 constant OTG2_HS_DEVICE_OTG_HS_DIEPINT2_NAK               \ NAK interrupt


\
\ @brief OTG_HS device endpoint transfer size register
\ Address offset: 0x150
\ Reset value: 0x00000000
\

$0007ffff constant OTG2_HS_DEVICE_OTG_HS_DIEPTSIZ2_XFRSIZ           \ Transfer size
$1ff80000 constant OTG2_HS_DEVICE_OTG_HS_DIEPTSIZ2_PKTCNT           \ Packet count
$60000000 constant OTG2_HS_DEVICE_OTG_HS_DIEPTSIZ2_MCNT             \ Multi count


\
\ @brief OTG_HS device endpoint-3 DMA address register
\ Address offset: 0x154
\ Reset value: 0x00000000
\

$00000000 constant OTG2_HS_DEVICE_OTG_HS_DIEPDMA3_DMAADDR           \ DMA address


\
\ @brief OTG_HS device IN endpoint transmit FIFO status register
\ Address offset: 0x158
\ Reset value: 0x00000000
\

$0000ffff constant OTG2_HS_DEVICE_OTG_HS_DTXFSTS2_INEPTFSAV         \ IN endpoint TxFIFO space avail


\
\ @brief OTG device endpoint-3 control register
\ Address offset: 0x160
\ Reset value: 0x00000000
\

$000007ff constant OTG2_HS_DEVICE_OTG_HS_DIEPCTL3_MPSIZ             \ Maximum packet size
$00008000 constant OTG2_HS_DEVICE_OTG_HS_DIEPCTL3_USBAEP            \ USB active endpoint
$00010000 constant OTG2_HS_DEVICE_OTG_HS_DIEPCTL3_EONUM_DPID        \ Even/odd frame
$00020000 constant OTG2_HS_DEVICE_OTG_HS_DIEPCTL3_NAKSTS            \ NAK status
$000c0000 constant OTG2_HS_DEVICE_OTG_HS_DIEPCTL3_EPTYP             \ Endpoint type
$00200000 constant OTG2_HS_DEVICE_OTG_HS_DIEPCTL3_STALL             \ STALL handshake
$03c00000 constant OTG2_HS_DEVICE_OTG_HS_DIEPCTL3_TXFNUM            \ TxFIFO number
$04000000 constant OTG2_HS_DEVICE_OTG_HS_DIEPCTL3_CNAK              \ Clear NAK
$08000000 constant OTG2_HS_DEVICE_OTG_HS_DIEPCTL3_SNAK              \ Set NAK
$10000000 constant OTG2_HS_DEVICE_OTG_HS_DIEPCTL3_SD0PID_SEVNFRM    \ Set DATA0 PID
$20000000 constant OTG2_HS_DEVICE_OTG_HS_DIEPCTL3_SODDFRM           \ Set odd frame
$40000000 constant OTG2_HS_DEVICE_OTG_HS_DIEPCTL3_EPDIS             \ Endpoint disable
$80000000 constant OTG2_HS_DEVICE_OTG_HS_DIEPCTL3_EPENA             \ Endpoint enable


\
\ @brief OTG device endpoint-3 interrupt register
\ Address offset: 0x168
\ Reset value: 0x00000000
\

$00000001 constant OTG2_HS_DEVICE_OTG_HS_DIEPINT3_XFRC              \ Transfer completed interrupt
$00000002 constant OTG2_HS_DEVICE_OTG_HS_DIEPINT3_EPDISD            \ Endpoint disabled interrupt
$00000008 constant OTG2_HS_DEVICE_OTG_HS_DIEPINT3_TOC               \ Timeout condition
$00000010 constant OTG2_HS_DEVICE_OTG_HS_DIEPINT3_ITTXFE            \ IN token received when TxFIFO is empty
$00000040 constant OTG2_HS_DEVICE_OTG_HS_DIEPINT3_INEPNE            \ IN endpoint NAK effective
$00000080 constant OTG2_HS_DEVICE_OTG_HS_DIEPINT3_TXFE              \ Transmit FIFO empty
$00000100 constant OTG2_HS_DEVICE_OTG_HS_DIEPINT3_TXFIFOUDRN        \ Transmit Fifo Underrun
$00000200 constant OTG2_HS_DEVICE_OTG_HS_DIEPINT3_BNA               \ Buffer not available interrupt
$00000800 constant OTG2_HS_DEVICE_OTG_HS_DIEPINT3_PKTDRPSTS         \ Packet dropped status
$00001000 constant OTG2_HS_DEVICE_OTG_HS_DIEPINT3_BERR              \ Babble error interrupt
$00002000 constant OTG2_HS_DEVICE_OTG_HS_DIEPINT3_NAK               \ NAK interrupt


\
\ @brief OTG_HS device endpoint transfer size register
\ Address offset: 0x170
\ Reset value: 0x00000000
\

$0007ffff constant OTG2_HS_DEVICE_OTG_HS_DIEPTSIZ3_XFRSIZ           \ Transfer size
$1ff80000 constant OTG2_HS_DEVICE_OTG_HS_DIEPTSIZ3_PKTCNT           \ Packet count
$60000000 constant OTG2_HS_DEVICE_OTG_HS_DIEPTSIZ3_MCNT             \ Multi count


\
\ @brief OTG_HS device endpoint-4 DMA address register
\ Address offset: 0x174
\ Reset value: 0x00000000
\

$00000000 constant OTG2_HS_DEVICE_OTG_HS_DIEPDMA4_DMAADDR           \ DMA address


\
\ @brief OTG_HS device IN endpoint transmit FIFO status register
\ Address offset: 0x178
\ Reset value: 0x00000000
\

$0000ffff constant OTG2_HS_DEVICE_OTG_HS_DTXFSTS3_INEPTFSAV         \ IN endpoint TxFIFO space avail


\
\ @brief OTG device endpoint-4 control register
\ Address offset: 0x180
\ Reset value: 0x00000000
\

$000007ff constant OTG2_HS_DEVICE_OTG_HS_DIEPCTL4_MPSIZ             \ Maximum packet size
$00008000 constant OTG2_HS_DEVICE_OTG_HS_DIEPCTL4_USBAEP            \ USB active endpoint
$00010000 constant OTG2_HS_DEVICE_OTG_HS_DIEPCTL4_EONUM_DPID        \ Even/odd frame
$00020000 constant OTG2_HS_DEVICE_OTG_HS_DIEPCTL4_NAKSTS            \ NAK status
$000c0000 constant OTG2_HS_DEVICE_OTG_HS_DIEPCTL4_EPTYP             \ Endpoint type
$00200000 constant OTG2_HS_DEVICE_OTG_HS_DIEPCTL4_STALL             \ STALL handshake
$03c00000 constant OTG2_HS_DEVICE_OTG_HS_DIEPCTL4_TXFNUM            \ TxFIFO number
$04000000 constant OTG2_HS_DEVICE_OTG_HS_DIEPCTL4_CNAK              \ Clear NAK
$08000000 constant OTG2_HS_DEVICE_OTG_HS_DIEPCTL4_SNAK              \ Set NAK
$10000000 constant OTG2_HS_DEVICE_OTG_HS_DIEPCTL4_SD0PID_SEVNFRM    \ Set DATA0 PID
$20000000 constant OTG2_HS_DEVICE_OTG_HS_DIEPCTL4_SODDFRM           \ Set odd frame
$40000000 constant OTG2_HS_DEVICE_OTG_HS_DIEPCTL4_EPDIS             \ Endpoint disable
$80000000 constant OTG2_HS_DEVICE_OTG_HS_DIEPCTL4_EPENA             \ Endpoint enable


\
\ @brief OTG device endpoint-4 interrupt register
\ Address offset: 0x188
\ Reset value: 0x00000000
\

$00000001 constant OTG2_HS_DEVICE_OTG_HS_DIEPINT4_XFRC              \ Transfer completed interrupt
$00000002 constant OTG2_HS_DEVICE_OTG_HS_DIEPINT4_EPDISD            \ Endpoint disabled interrupt
$00000008 constant OTG2_HS_DEVICE_OTG_HS_DIEPINT4_TOC               \ Timeout condition
$00000010 constant OTG2_HS_DEVICE_OTG_HS_DIEPINT4_ITTXFE            \ IN token received when TxFIFO is empty
$00000040 constant OTG2_HS_DEVICE_OTG_HS_DIEPINT4_INEPNE            \ IN endpoint NAK effective
$00000080 constant OTG2_HS_DEVICE_OTG_HS_DIEPINT4_TXFE              \ Transmit FIFO empty
$00000100 constant OTG2_HS_DEVICE_OTG_HS_DIEPINT4_TXFIFOUDRN        \ Transmit Fifo Underrun
$00000200 constant OTG2_HS_DEVICE_OTG_HS_DIEPINT4_BNA               \ Buffer not available interrupt
$00000800 constant OTG2_HS_DEVICE_OTG_HS_DIEPINT4_PKTDRPSTS         \ Packet dropped status
$00001000 constant OTG2_HS_DEVICE_OTG_HS_DIEPINT4_BERR              \ Babble error interrupt
$00002000 constant OTG2_HS_DEVICE_OTG_HS_DIEPINT4_NAK               \ NAK interrupt


\
\ @brief OTG_HS device endpoint transfer size register
\ Address offset: 0x190
\ Reset value: 0x00000000
\

$0007ffff constant OTG2_HS_DEVICE_OTG_HS_DIEPTSIZ4_XFRSIZ           \ Transfer size
$1ff80000 constant OTG2_HS_DEVICE_OTG_HS_DIEPTSIZ4_PKTCNT           \ Packet count
$60000000 constant OTG2_HS_DEVICE_OTG_HS_DIEPTSIZ4_MCNT             \ Multi count


\
\ @brief OTG_HS device endpoint-5 DMA address register
\ Address offset: 0x194
\ Reset value: 0x00000000
\

$00000000 constant OTG2_HS_DEVICE_OTG_HS_DIEPDMA5_DMAADDR           \ DMA address


\
\ @brief OTG_HS device IN endpoint transmit FIFO status register
\ Address offset: 0x198
\ Reset value: 0x00000000
\

$0000ffff constant OTG2_HS_DEVICE_OTG_HS_DTXFSTS4_INEPTFSAV         \ IN endpoint TxFIFO space avail


\
\ @brief OTG device endpoint-5 control register
\ Address offset: 0x1A0
\ Reset value: 0x00000000
\

$000007ff constant OTG2_HS_DEVICE_OTG_HS_DIEPCTL5_MPSIZ             \ Maximum packet size
$00008000 constant OTG2_HS_DEVICE_OTG_HS_DIEPCTL5_USBAEP            \ USB active endpoint
$00010000 constant OTG2_HS_DEVICE_OTG_HS_DIEPCTL5_EONUM_DPID        \ Even/odd frame
$00020000 constant OTG2_HS_DEVICE_OTG_HS_DIEPCTL5_NAKSTS            \ NAK status
$000c0000 constant OTG2_HS_DEVICE_OTG_HS_DIEPCTL5_EPTYP             \ Endpoint type
$00200000 constant OTG2_HS_DEVICE_OTG_HS_DIEPCTL5_STALL             \ STALL handshake
$03c00000 constant OTG2_HS_DEVICE_OTG_HS_DIEPCTL5_TXFNUM            \ TxFIFO number
$04000000 constant OTG2_HS_DEVICE_OTG_HS_DIEPCTL5_CNAK              \ Clear NAK
$08000000 constant OTG2_HS_DEVICE_OTG_HS_DIEPCTL5_SNAK              \ Set NAK
$10000000 constant OTG2_HS_DEVICE_OTG_HS_DIEPCTL5_SD0PID_SEVNFRM    \ Set DATA0 PID
$20000000 constant OTG2_HS_DEVICE_OTG_HS_DIEPCTL5_SODDFRM           \ Set odd frame
$40000000 constant OTG2_HS_DEVICE_OTG_HS_DIEPCTL5_EPDIS             \ Endpoint disable
$80000000 constant OTG2_HS_DEVICE_OTG_HS_DIEPCTL5_EPENA             \ Endpoint enable


\
\ @brief OTG_HS device endpoint transfer size register
\ Address offset: 0x1A0
\ Reset value: 0x00000000
\

$0007ffff constant OTG2_HS_DEVICE_OTG_HS_DIEPTSIZ6_XFRSIZ           \ Transfer size
$1ff80000 constant OTG2_HS_DEVICE_OTG_HS_DIEPTSIZ6_PKTCNT           \ Packet count
$60000000 constant OTG2_HS_DEVICE_OTG_HS_DIEPTSIZ6_MCNT             \ Multi count


\
\ @brief OTG_HS device IN endpoint transmit FIFO status register
\ Address offset: 0x1A4
\ Reset value: 0x00000000
\

$0000ffff constant OTG2_HS_DEVICE_OTG_HS_DTXFSTS6_INEPTFSAV         \ IN endpoint TxFIFO space avail


\
\ @brief OTG device endpoint-5 interrupt register
\ Address offset: 0x1A8
\ Reset value: 0x00000000
\

$00000001 constant OTG2_HS_DEVICE_OTG_HS_DIEPINT5_XFRC              \ Transfer completed interrupt
$00000002 constant OTG2_HS_DEVICE_OTG_HS_DIEPINT5_EPDISD            \ Endpoint disabled interrupt
$00000008 constant OTG2_HS_DEVICE_OTG_HS_DIEPINT5_TOC               \ Timeout condition
$00000010 constant OTG2_HS_DEVICE_OTG_HS_DIEPINT5_ITTXFE            \ IN token received when TxFIFO is empty
$00000040 constant OTG2_HS_DEVICE_OTG_HS_DIEPINT5_INEPNE            \ IN endpoint NAK effective
$00000080 constant OTG2_HS_DEVICE_OTG_HS_DIEPINT5_TXFE              \ Transmit FIFO empty
$00000100 constant OTG2_HS_DEVICE_OTG_HS_DIEPINT5_TXFIFOUDRN        \ Transmit Fifo Underrun
$00000200 constant OTG2_HS_DEVICE_OTG_HS_DIEPINT5_BNA               \ Buffer not available interrupt
$00000800 constant OTG2_HS_DEVICE_OTG_HS_DIEPINT5_PKTDRPSTS         \ Packet dropped status
$00001000 constant OTG2_HS_DEVICE_OTG_HS_DIEPINT5_BERR              \ Babble error interrupt
$00002000 constant OTG2_HS_DEVICE_OTG_HS_DIEPINT5_NAK               \ NAK interrupt


\
\ @brief OTG_HS device endpoint transfer size register
\ Address offset: 0x1A8
\ Reset value: 0x00000000
\

$0007ffff constant OTG2_HS_DEVICE_OTG_HS_DIEPTSIZ7_XFRSIZ           \ Transfer size
$1ff80000 constant OTG2_HS_DEVICE_OTG_HS_DIEPTSIZ7_PKTCNT           \ Packet count
$60000000 constant OTG2_HS_DEVICE_OTG_HS_DIEPTSIZ7_MCNT             \ Multi count


\
\ @brief OTG_HS device IN endpoint transmit FIFO status register
\ Address offset: 0x1AC
\ Reset value: 0x00000000
\

$0000ffff constant OTG2_HS_DEVICE_OTG_HS_DTXFSTS7_INEPTFSAV         \ IN endpoint TxFIFO space avail


\
\ @brief OTG_HS device endpoint transfer size register
\ Address offset: 0x1B0
\ Reset value: 0x00000000
\

$0007ffff constant OTG2_HS_DEVICE_OTG_HS_DIEPTSIZ5_XFRSIZ           \ Transfer size
$1ff80000 constant OTG2_HS_DEVICE_OTG_HS_DIEPTSIZ5_PKTCNT           \ Packet count
$60000000 constant OTG2_HS_DEVICE_OTG_HS_DIEPTSIZ5_MCNT             \ Multi count


\
\ @brief OTG_HS device IN endpoint transmit FIFO status register
\ Address offset: 0x1B8
\ Reset value: 0x00000000
\

$0000ffff constant OTG2_HS_DEVICE_OTG_HS_DTXFSTS5_INEPTFSAV         \ IN endpoint TxFIFO space avail


\
\ @brief OTG device endpoint-6 control register
\ Address offset: 0x1C0
\ Reset value: 0x00000000
\

$000007ff constant OTG2_HS_DEVICE_OTG_HS_DIEPCTL6_MPSIZ             \ Maximum packet size
$00008000 constant OTG2_HS_DEVICE_OTG_HS_DIEPCTL6_USBAEP            \ USB active endpoint
$00010000 constant OTG2_HS_DEVICE_OTG_HS_DIEPCTL6_EONUM_DPID        \ Even/odd frame
$00020000 constant OTG2_HS_DEVICE_OTG_HS_DIEPCTL6_NAKSTS            \ NAK status
$000c0000 constant OTG2_HS_DEVICE_OTG_HS_DIEPCTL6_EPTYP             \ Endpoint type
$00200000 constant OTG2_HS_DEVICE_OTG_HS_DIEPCTL6_STALL             \ STALL handshake
$03c00000 constant OTG2_HS_DEVICE_OTG_HS_DIEPCTL6_TXFNUM            \ TxFIFO number
$04000000 constant OTG2_HS_DEVICE_OTG_HS_DIEPCTL6_CNAK              \ Clear NAK
$08000000 constant OTG2_HS_DEVICE_OTG_HS_DIEPCTL6_SNAK              \ Set NAK
$10000000 constant OTG2_HS_DEVICE_OTG_HS_DIEPCTL6_SD0PID_SEVNFRM    \ Set DATA0 PID
$20000000 constant OTG2_HS_DEVICE_OTG_HS_DIEPCTL6_SODDFRM           \ Set odd frame
$40000000 constant OTG2_HS_DEVICE_OTG_HS_DIEPCTL6_EPDIS             \ Endpoint disable
$80000000 constant OTG2_HS_DEVICE_OTG_HS_DIEPCTL6_EPENA             \ Endpoint enable


\
\ @brief OTG device endpoint-6 interrupt register
\ Address offset: 0x1C8
\ Reset value: 0x00000000
\

$00000001 constant OTG2_HS_DEVICE_OTG_HS_DIEPINT6_XFRC              \ Transfer completed interrupt
$00000002 constant OTG2_HS_DEVICE_OTG_HS_DIEPINT6_EPDISD            \ Endpoint disabled interrupt
$00000008 constant OTG2_HS_DEVICE_OTG_HS_DIEPINT6_TOC               \ Timeout condition
$00000010 constant OTG2_HS_DEVICE_OTG_HS_DIEPINT6_ITTXFE            \ IN token received when TxFIFO is empty
$00000040 constant OTG2_HS_DEVICE_OTG_HS_DIEPINT6_INEPNE            \ IN endpoint NAK effective
$00000080 constant OTG2_HS_DEVICE_OTG_HS_DIEPINT6_TXFE              \ Transmit FIFO empty
$00000100 constant OTG2_HS_DEVICE_OTG_HS_DIEPINT6_TXFIFOUDRN        \ Transmit Fifo Underrun
$00000200 constant OTG2_HS_DEVICE_OTG_HS_DIEPINT6_BNA               \ Buffer not available interrupt
$00000800 constant OTG2_HS_DEVICE_OTG_HS_DIEPINT6_PKTDRPSTS         \ Packet dropped status
$00001000 constant OTG2_HS_DEVICE_OTG_HS_DIEPINT6_BERR              \ Babble error interrupt
$00002000 constant OTG2_HS_DEVICE_OTG_HS_DIEPINT6_NAK               \ NAK interrupt


\
\ @brief OTG device endpoint-7 control register
\ Address offset: 0x1E0
\ Reset value: 0x00000000
\

$000007ff constant OTG2_HS_DEVICE_OTG_HS_DIEPCTL7_MPSIZ             \ Maximum packet size
$00008000 constant OTG2_HS_DEVICE_OTG_HS_DIEPCTL7_USBAEP            \ USB active endpoint
$00010000 constant OTG2_HS_DEVICE_OTG_HS_DIEPCTL7_EONUM_DPID        \ Even/odd frame
$00020000 constant OTG2_HS_DEVICE_OTG_HS_DIEPCTL7_NAKSTS            \ NAK status
$000c0000 constant OTG2_HS_DEVICE_OTG_HS_DIEPCTL7_EPTYP             \ Endpoint type
$00200000 constant OTG2_HS_DEVICE_OTG_HS_DIEPCTL7_STALL             \ STALL handshake
$03c00000 constant OTG2_HS_DEVICE_OTG_HS_DIEPCTL7_TXFNUM            \ TxFIFO number
$04000000 constant OTG2_HS_DEVICE_OTG_HS_DIEPCTL7_CNAK              \ Clear NAK
$08000000 constant OTG2_HS_DEVICE_OTG_HS_DIEPCTL7_SNAK              \ Set NAK
$10000000 constant OTG2_HS_DEVICE_OTG_HS_DIEPCTL7_SD0PID_SEVNFRM    \ Set DATA0 PID
$20000000 constant OTG2_HS_DEVICE_OTG_HS_DIEPCTL7_SODDFRM           \ Set odd frame
$40000000 constant OTG2_HS_DEVICE_OTG_HS_DIEPCTL7_EPDIS             \ Endpoint disable
$80000000 constant OTG2_HS_DEVICE_OTG_HS_DIEPCTL7_EPENA             \ Endpoint enable


\
\ @brief OTG device endpoint-7 interrupt register
\ Address offset: 0x1E8
\ Reset value: 0x00000000
\

$00000001 constant OTG2_HS_DEVICE_OTG_HS_DIEPINT7_XFRC              \ Transfer completed interrupt
$00000002 constant OTG2_HS_DEVICE_OTG_HS_DIEPINT7_EPDISD            \ Endpoint disabled interrupt
$00000008 constant OTG2_HS_DEVICE_OTG_HS_DIEPINT7_TOC               \ Timeout condition
$00000010 constant OTG2_HS_DEVICE_OTG_HS_DIEPINT7_ITTXFE            \ IN token received when TxFIFO is empty
$00000040 constant OTG2_HS_DEVICE_OTG_HS_DIEPINT7_INEPNE            \ IN endpoint NAK effective
$00000080 constant OTG2_HS_DEVICE_OTG_HS_DIEPINT7_TXFE              \ Transmit FIFO empty
$00000100 constant OTG2_HS_DEVICE_OTG_HS_DIEPINT7_TXFIFOUDRN        \ Transmit Fifo Underrun
$00000200 constant OTG2_HS_DEVICE_OTG_HS_DIEPINT7_BNA               \ Buffer not available interrupt
$00000800 constant OTG2_HS_DEVICE_OTG_HS_DIEPINT7_PKTDRPSTS         \ Packet dropped status
$00001000 constant OTG2_HS_DEVICE_OTG_HS_DIEPINT7_BERR              \ Babble error interrupt
$00002000 constant OTG2_HS_DEVICE_OTG_HS_DIEPINT7_NAK               \ NAK interrupt


\
\ @brief OTG_HS device control OUT endpoint 0 control register
\ Address offset: 0x300
\ Reset value: 0x00008000
\

$00000003 constant OTG2_HS_DEVICE_OTG_HS_DOEPCTL0_MPSIZ             \ Maximum packet size
$00008000 constant OTG2_HS_DEVICE_OTG_HS_DOEPCTL0_USBAEP            \ USB active endpoint
$00020000 constant OTG2_HS_DEVICE_OTG_HS_DOEPCTL0_NAKSTS            \ NAK status
$000c0000 constant OTG2_HS_DEVICE_OTG_HS_DOEPCTL0_EPTYP             \ Endpoint type
$00100000 constant OTG2_HS_DEVICE_OTG_HS_DOEPCTL0_SNPM              \ Snoop mode
$00200000 constant OTG2_HS_DEVICE_OTG_HS_DOEPCTL0_STALL             \ STALL handshake
$04000000 constant OTG2_HS_DEVICE_OTG_HS_DOEPCTL0_CNAK              \ Clear NAK
$08000000 constant OTG2_HS_DEVICE_OTG_HS_DOEPCTL0_SNAK              \ Set NAK
$40000000 constant OTG2_HS_DEVICE_OTG_HS_DOEPCTL0_EPDIS             \ Endpoint disable
$80000000 constant OTG2_HS_DEVICE_OTG_HS_DOEPCTL0_EPENA             \ Endpoint enable


\
\ @brief OTG_HS device endpoint-0 interrupt register
\ Address offset: 0x308
\ Reset value: 0x00000080
\

$00000001 constant OTG2_HS_DEVICE_OTG_HS_DOEPINT0_XFRC              \ Transfer completed interrupt
$00000002 constant OTG2_HS_DEVICE_OTG_HS_DOEPINT0_EPDISD            \ Endpoint disabled interrupt
$00000008 constant OTG2_HS_DEVICE_OTG_HS_DOEPINT0_STUP              \ SETUP phase done
$00000010 constant OTG2_HS_DEVICE_OTG_HS_DOEPINT0_OTEPDIS           \ OUT token received when endpoint disabled
$00000040 constant OTG2_HS_DEVICE_OTG_HS_DOEPINT0_B2BSTUP           \ Back-to-back SETUP packets received
$00004000 constant OTG2_HS_DEVICE_OTG_HS_DOEPINT0_NYET              \ NYET interrupt


\
\ @brief OTG_HS device endpoint-0 transfer size register
\ Address offset: 0x310
\ Reset value: 0x00000000
\

$0000007f constant OTG2_HS_DEVICE_OTG_HS_DOEPTSIZ0_XFRSIZ           \ Transfer size
$00080000 constant OTG2_HS_DEVICE_OTG_HS_DOEPTSIZ0_PKTCNT           \ Packet count
$60000000 constant OTG2_HS_DEVICE_OTG_HS_DOEPTSIZ0_STUPCNT          \ SETUP packet count


\
\ @brief OTG device endpoint-1 control register
\ Address offset: 0x320
\ Reset value: 0x00000000
\

$000007ff constant OTG2_HS_DEVICE_OTG_HS_DOEPCTL1_MPSIZ             \ Maximum packet size
$00008000 constant OTG2_HS_DEVICE_OTG_HS_DOEPCTL1_USBAEP            \ USB active endpoint
$00010000 constant OTG2_HS_DEVICE_OTG_HS_DOEPCTL1_EONUM_DPID        \ Even odd frame/Endpoint data PID
$00020000 constant OTG2_HS_DEVICE_OTG_HS_DOEPCTL1_NAKSTS            \ NAK status
$000c0000 constant OTG2_HS_DEVICE_OTG_HS_DOEPCTL1_EPTYP             \ Endpoint type
$00100000 constant OTG2_HS_DEVICE_OTG_HS_DOEPCTL1_SNPM              \ Snoop mode
$00200000 constant OTG2_HS_DEVICE_OTG_HS_DOEPCTL1_STALL             \ STALL handshake
$04000000 constant OTG2_HS_DEVICE_OTG_HS_DOEPCTL1_CNAK              \ Clear NAK
$08000000 constant OTG2_HS_DEVICE_OTG_HS_DOEPCTL1_SNAK              \ Set NAK
$10000000 constant OTG2_HS_DEVICE_OTG_HS_DOEPCTL1_SD0PID_SEVNFRM    \ Set DATA0 PID/Set even frame
$20000000 constant OTG2_HS_DEVICE_OTG_HS_DOEPCTL1_SODDFRM           \ Set odd frame
$40000000 constant OTG2_HS_DEVICE_OTG_HS_DOEPCTL1_EPDIS             \ Endpoint disable
$80000000 constant OTG2_HS_DEVICE_OTG_HS_DOEPCTL1_EPENA             \ Endpoint enable


\
\ @brief OTG_HS device endpoint-1 interrupt register
\ Address offset: 0x328
\ Reset value: 0x00000000
\

$00000001 constant OTG2_HS_DEVICE_OTG_HS_DOEPINT1_XFRC              \ Transfer completed interrupt
$00000002 constant OTG2_HS_DEVICE_OTG_HS_DOEPINT1_EPDISD            \ Endpoint disabled interrupt
$00000008 constant OTG2_HS_DEVICE_OTG_HS_DOEPINT1_STUP              \ SETUP phase done
$00000010 constant OTG2_HS_DEVICE_OTG_HS_DOEPINT1_OTEPDIS           \ OUT token received when endpoint disabled
$00000040 constant OTG2_HS_DEVICE_OTG_HS_DOEPINT1_B2BSTUP           \ Back-to-back SETUP packets received
$00004000 constant OTG2_HS_DEVICE_OTG_HS_DOEPINT1_NYET              \ NYET interrupt


\
\ @brief OTG_HS device endpoint-1 transfer size register
\ Address offset: 0x330
\ Reset value: 0x00000000
\

$0007ffff constant OTG2_HS_DEVICE_OTG_HS_DOEPTSIZ1_XFRSIZ           \ Transfer size
$1ff80000 constant OTG2_HS_DEVICE_OTG_HS_DOEPTSIZ1_PKTCNT           \ Packet count
$60000000 constant OTG2_HS_DEVICE_OTG_HS_DOEPTSIZ1_RXDPID_STUPCNT    \ Received data PID/SETUP packet count


\
\ @brief OTG device endpoint-2 control register
\ Address offset: 0x340
\ Reset value: 0x00000000
\

$000007ff constant OTG2_HS_DEVICE_OTG_HS_DOEPCTL2_MPSIZ             \ Maximum packet size
$00008000 constant OTG2_HS_DEVICE_OTG_HS_DOEPCTL2_USBAEP            \ USB active endpoint
$00010000 constant OTG2_HS_DEVICE_OTG_HS_DOEPCTL2_EONUM_DPID        \ Even odd frame/Endpoint data PID
$00020000 constant OTG2_HS_DEVICE_OTG_HS_DOEPCTL2_NAKSTS            \ NAK status
$000c0000 constant OTG2_HS_DEVICE_OTG_HS_DOEPCTL2_EPTYP             \ Endpoint type
$00100000 constant OTG2_HS_DEVICE_OTG_HS_DOEPCTL2_SNPM              \ Snoop mode
$00200000 constant OTG2_HS_DEVICE_OTG_HS_DOEPCTL2_STALL             \ STALL handshake
$04000000 constant OTG2_HS_DEVICE_OTG_HS_DOEPCTL2_CNAK              \ Clear NAK
$08000000 constant OTG2_HS_DEVICE_OTG_HS_DOEPCTL2_SNAK              \ Set NAK
$10000000 constant OTG2_HS_DEVICE_OTG_HS_DOEPCTL2_SD0PID_SEVNFRM    \ Set DATA0 PID/Set even frame
$20000000 constant OTG2_HS_DEVICE_OTG_HS_DOEPCTL2_SODDFRM           \ Set odd frame
$40000000 constant OTG2_HS_DEVICE_OTG_HS_DOEPCTL2_EPDIS             \ Endpoint disable
$80000000 constant OTG2_HS_DEVICE_OTG_HS_DOEPCTL2_EPENA             \ Endpoint enable


\
\ @brief OTG_HS device endpoint-2 interrupt register
\ Address offset: 0x348
\ Reset value: 0x00000000
\

$00000001 constant OTG2_HS_DEVICE_OTG_HS_DOEPINT2_XFRC              \ Transfer completed interrupt
$00000002 constant OTG2_HS_DEVICE_OTG_HS_DOEPINT2_EPDISD            \ Endpoint disabled interrupt
$00000008 constant OTG2_HS_DEVICE_OTG_HS_DOEPINT2_STUP              \ SETUP phase done
$00000010 constant OTG2_HS_DEVICE_OTG_HS_DOEPINT2_OTEPDIS           \ OUT token received when endpoint disabled
$00000040 constant OTG2_HS_DEVICE_OTG_HS_DOEPINT2_B2BSTUP           \ Back-to-back SETUP packets received
$00004000 constant OTG2_HS_DEVICE_OTG_HS_DOEPINT2_NYET              \ NYET interrupt


\
\ @brief OTG_HS device endpoint-2 transfer size register
\ Address offset: 0x350
\ Reset value: 0x00000000
\

$0007ffff constant OTG2_HS_DEVICE_OTG_HS_DOEPTSIZ2_XFRSIZ           \ Transfer size
$1ff80000 constant OTG2_HS_DEVICE_OTG_HS_DOEPTSIZ2_PKTCNT           \ Packet count
$60000000 constant OTG2_HS_DEVICE_OTG_HS_DOEPTSIZ2_RXDPID_STUPCNT    \ Received data PID/SETUP packet count


\
\ @brief OTG device endpoint-3 control register
\ Address offset: 0x360
\ Reset value: 0x00000000
\

$000007ff constant OTG2_HS_DEVICE_OTG_HS_DOEPCTL3_MPSIZ             \ Maximum packet size
$00008000 constant OTG2_HS_DEVICE_OTG_HS_DOEPCTL3_USBAEP            \ USB active endpoint
$00010000 constant OTG2_HS_DEVICE_OTG_HS_DOEPCTL3_EONUM_DPID        \ Even odd frame/Endpoint data PID
$00020000 constant OTG2_HS_DEVICE_OTG_HS_DOEPCTL3_NAKSTS            \ NAK status
$000c0000 constant OTG2_HS_DEVICE_OTG_HS_DOEPCTL3_EPTYP             \ Endpoint type
$00100000 constant OTG2_HS_DEVICE_OTG_HS_DOEPCTL3_SNPM              \ Snoop mode
$00200000 constant OTG2_HS_DEVICE_OTG_HS_DOEPCTL3_STALL             \ STALL handshake
$04000000 constant OTG2_HS_DEVICE_OTG_HS_DOEPCTL3_CNAK              \ Clear NAK
$08000000 constant OTG2_HS_DEVICE_OTG_HS_DOEPCTL3_SNAK              \ Set NAK
$10000000 constant OTG2_HS_DEVICE_OTG_HS_DOEPCTL3_SD0PID_SEVNFRM    \ Set DATA0 PID/Set even frame
$20000000 constant OTG2_HS_DEVICE_OTG_HS_DOEPCTL3_SODDFRM           \ Set odd frame
$40000000 constant OTG2_HS_DEVICE_OTG_HS_DOEPCTL3_EPDIS             \ Endpoint disable
$80000000 constant OTG2_HS_DEVICE_OTG_HS_DOEPCTL3_EPENA             \ Endpoint enable


\
\ @brief OTG_HS device endpoint-3 interrupt register
\ Address offset: 0x368
\ Reset value: 0x00000000
\

$00000001 constant OTG2_HS_DEVICE_OTG_HS_DOEPINT3_XFRC              \ Transfer completed interrupt
$00000002 constant OTG2_HS_DEVICE_OTG_HS_DOEPINT3_EPDISD            \ Endpoint disabled interrupt
$00000008 constant OTG2_HS_DEVICE_OTG_HS_DOEPINT3_STUP              \ SETUP phase done
$00000010 constant OTG2_HS_DEVICE_OTG_HS_DOEPINT3_OTEPDIS           \ OUT token received when endpoint disabled
$00000040 constant OTG2_HS_DEVICE_OTG_HS_DOEPINT3_B2BSTUP           \ Back-to-back SETUP packets received
$00004000 constant OTG2_HS_DEVICE_OTG_HS_DOEPINT3_NYET              \ NYET interrupt


\
\ @brief OTG_HS device endpoint-3 transfer size register
\ Address offset: 0x370
\ Reset value: 0x00000000
\

$0007ffff constant OTG2_HS_DEVICE_OTG_HS_DOEPTSIZ3_XFRSIZ           \ Transfer size
$1ff80000 constant OTG2_HS_DEVICE_OTG_HS_DOEPTSIZ3_PKTCNT           \ Packet count
$60000000 constant OTG2_HS_DEVICE_OTG_HS_DOEPTSIZ3_RXDPID_STUPCNT    \ Received data PID/SETUP packet count


\
\ @brief OTG device endpoint-4 control register
\ Address offset: 0x380
\ Reset value: 0x00000000
\

$000007ff constant OTG2_HS_DEVICE_OTG_HS_DOEPCTL4_MPSIZ             \ Maximum packet size
$00008000 constant OTG2_HS_DEVICE_OTG_HS_DOEPCTL4_USBAEP            \ USB active endpoint
$00010000 constant OTG2_HS_DEVICE_OTG_HS_DOEPCTL4_EONUM_DPID        \ Even odd frame/Endpoint data PID
$00020000 constant OTG2_HS_DEVICE_OTG_HS_DOEPCTL4_NAKSTS            \ NAK status
$000c0000 constant OTG2_HS_DEVICE_OTG_HS_DOEPCTL4_EPTYP             \ Endpoint type
$00100000 constant OTG2_HS_DEVICE_OTG_HS_DOEPCTL4_SNPM              \ Snoop mode
$00200000 constant OTG2_HS_DEVICE_OTG_HS_DOEPCTL4_STALL             \ STALL handshake
$04000000 constant OTG2_HS_DEVICE_OTG_HS_DOEPCTL4_CNAK              \ Clear NAK
$08000000 constant OTG2_HS_DEVICE_OTG_HS_DOEPCTL4_SNAK              \ Set NAK
$10000000 constant OTG2_HS_DEVICE_OTG_HS_DOEPCTL4_SD0PID_SEVNFRM    \ Set DATA0 PID/Set even frame
$20000000 constant OTG2_HS_DEVICE_OTG_HS_DOEPCTL4_SODDFRM           \ Set odd frame
$40000000 constant OTG2_HS_DEVICE_OTG_HS_DOEPCTL4_EPDIS             \ Endpoint disable
$80000000 constant OTG2_HS_DEVICE_OTG_HS_DOEPCTL4_EPENA             \ Endpoint enable


\
\ @brief OTG_HS device endpoint-4 interrupt register
\ Address offset: 0x388
\ Reset value: 0x00000000
\

$00000001 constant OTG2_HS_DEVICE_OTG_HS_DOEPINT4_XFRC              \ Transfer completed interrupt
$00000002 constant OTG2_HS_DEVICE_OTG_HS_DOEPINT4_EPDISD            \ Endpoint disabled interrupt
$00000008 constant OTG2_HS_DEVICE_OTG_HS_DOEPINT4_STUP              \ SETUP phase done
$00000010 constant OTG2_HS_DEVICE_OTG_HS_DOEPINT4_OTEPDIS           \ OUT token received when endpoint disabled
$00000040 constant OTG2_HS_DEVICE_OTG_HS_DOEPINT4_B2BSTUP           \ Back-to-back SETUP packets received
$00004000 constant OTG2_HS_DEVICE_OTG_HS_DOEPINT4_NYET              \ NYET interrupt


\
\ @brief OTG_HS device endpoint-4 transfer size register
\ Address offset: 0x390
\ Reset value: 0x00000000
\

$0007ffff constant OTG2_HS_DEVICE_OTG_HS_DOEPTSIZ4_XFRSIZ           \ Transfer size
$1ff80000 constant OTG2_HS_DEVICE_OTG_HS_DOEPTSIZ4_PKTCNT           \ Packet count
$60000000 constant OTG2_HS_DEVICE_OTG_HS_DOEPTSIZ4_RXDPID_STUPCNT    \ Received data PID/SETUP packet count


\
\ @brief OTG device endpoint-5 control register
\ Address offset: 0x3A0
\ Reset value: 0x00000000
\

$000007ff constant OTG2_HS_DEVICE_OTG_HS_DOEPCTL5_MPSIZ             \ Maximum packet size
$00008000 constant OTG2_HS_DEVICE_OTG_HS_DOEPCTL5_USBAEP            \ USB active endpoint
$00010000 constant OTG2_HS_DEVICE_OTG_HS_DOEPCTL5_EONUM_DPID        \ Even odd frame/Endpoint data PID
$00020000 constant OTG2_HS_DEVICE_OTG_HS_DOEPCTL5_NAKSTS            \ NAK status
$000c0000 constant OTG2_HS_DEVICE_OTG_HS_DOEPCTL5_EPTYP             \ Endpoint type
$00100000 constant OTG2_HS_DEVICE_OTG_HS_DOEPCTL5_SNPM              \ Snoop mode
$00200000 constant OTG2_HS_DEVICE_OTG_HS_DOEPCTL5_STALL             \ STALL handshake
$04000000 constant OTG2_HS_DEVICE_OTG_HS_DOEPCTL5_CNAK              \ Clear NAK
$08000000 constant OTG2_HS_DEVICE_OTG_HS_DOEPCTL5_SNAK              \ Set NAK
$10000000 constant OTG2_HS_DEVICE_OTG_HS_DOEPCTL5_SD0PID_SEVNFRM    \ Set DATA0 PID/Set even frame
$20000000 constant OTG2_HS_DEVICE_OTG_HS_DOEPCTL5_SODDFRM           \ Set odd frame
$40000000 constant OTG2_HS_DEVICE_OTG_HS_DOEPCTL5_EPDIS             \ Endpoint disable
$80000000 constant OTG2_HS_DEVICE_OTG_HS_DOEPCTL5_EPENA             \ Endpoint enable


\
\ @brief OTG_HS device endpoint-5 interrupt register
\ Address offset: 0x3A8
\ Reset value: 0x00000000
\

$00000001 constant OTG2_HS_DEVICE_OTG_HS_DOEPINT5_XFRC              \ Transfer completed interrupt
$00000002 constant OTG2_HS_DEVICE_OTG_HS_DOEPINT5_EPDISD            \ Endpoint disabled interrupt
$00000008 constant OTG2_HS_DEVICE_OTG_HS_DOEPINT5_STUP              \ SETUP phase done
$00000010 constant OTG2_HS_DEVICE_OTG_HS_DOEPINT5_OTEPDIS           \ OUT token received when endpoint disabled
$00000040 constant OTG2_HS_DEVICE_OTG_HS_DOEPINT5_B2BSTUP           \ Back-to-back SETUP packets received
$00004000 constant OTG2_HS_DEVICE_OTG_HS_DOEPINT5_NYET              \ NYET interrupt


\
\ @brief OTG_HS device endpoint-5 transfer size register
\ Address offset: 0x3B0
\ Reset value: 0x00000000
\

$0007ffff constant OTG2_HS_DEVICE_OTG_HS_DOEPTSIZ5_XFRSIZ           \ Transfer size
$1ff80000 constant OTG2_HS_DEVICE_OTG_HS_DOEPTSIZ5_PKTCNT           \ Packet count
$60000000 constant OTG2_HS_DEVICE_OTG_HS_DOEPTSIZ5_RXDPID_STUPCNT    \ Received data PID/SETUP packet count


\
\ @brief OTG device endpoint-6 control register
\ Address offset: 0x3C0
\ Reset value: 0x00000000
\

$000007ff constant OTG2_HS_DEVICE_OTG_HS_DOEPCTL6_MPSIZ             \ Maximum packet size
$00008000 constant OTG2_HS_DEVICE_OTG_HS_DOEPCTL6_USBAEP            \ USB active endpoint
$00010000 constant OTG2_HS_DEVICE_OTG_HS_DOEPCTL6_EONUM_DPID        \ Even odd frame/Endpoint data PID
$00020000 constant OTG2_HS_DEVICE_OTG_HS_DOEPCTL6_NAKSTS            \ NAK status
$000c0000 constant OTG2_HS_DEVICE_OTG_HS_DOEPCTL6_EPTYP             \ Endpoint type
$00100000 constant OTG2_HS_DEVICE_OTG_HS_DOEPCTL6_SNPM              \ Snoop mode
$00200000 constant OTG2_HS_DEVICE_OTG_HS_DOEPCTL6_STALL             \ STALL handshake
$04000000 constant OTG2_HS_DEVICE_OTG_HS_DOEPCTL6_CNAK              \ Clear NAK
$08000000 constant OTG2_HS_DEVICE_OTG_HS_DOEPCTL6_SNAK              \ Set NAK
$10000000 constant OTG2_HS_DEVICE_OTG_HS_DOEPCTL6_SD0PID_SEVNFRM    \ Set DATA0 PID/Set even frame
$20000000 constant OTG2_HS_DEVICE_OTG_HS_DOEPCTL6_SODDFRM           \ Set odd frame
$40000000 constant OTG2_HS_DEVICE_OTG_HS_DOEPCTL6_EPDIS             \ Endpoint disable
$80000000 constant OTG2_HS_DEVICE_OTG_HS_DOEPCTL6_EPENA             \ Endpoint enable


\
\ @brief OTG_HS device endpoint-6 interrupt register
\ Address offset: 0x3C8
\ Reset value: 0x00000000
\

$00000001 constant OTG2_HS_DEVICE_OTG_HS_DOEPINT6_XFRC              \ Transfer completed interrupt
$00000002 constant OTG2_HS_DEVICE_OTG_HS_DOEPINT6_EPDISD            \ Endpoint disabled interrupt
$00000008 constant OTG2_HS_DEVICE_OTG_HS_DOEPINT6_STUP              \ SETUP phase done
$00000010 constant OTG2_HS_DEVICE_OTG_HS_DOEPINT6_OTEPDIS           \ OUT token received when endpoint disabled
$00000040 constant OTG2_HS_DEVICE_OTG_HS_DOEPINT6_B2BSTUP           \ Back-to-back SETUP packets received
$00004000 constant OTG2_HS_DEVICE_OTG_HS_DOEPINT6_NYET              \ NYET interrupt


\
\ @brief OTG_HS device endpoint-6 transfer size register
\ Address offset: 0x3D0
\ Reset value: 0x00000000
\

$0007ffff constant OTG2_HS_DEVICE_OTG_HS_DOEPTSIZ6_XFRSIZ           \ Transfer size
$1ff80000 constant OTG2_HS_DEVICE_OTG_HS_DOEPTSIZ6_PKTCNT           \ Packet count
$60000000 constant OTG2_HS_DEVICE_OTG_HS_DOEPTSIZ6_RXDPID_STUPCNT    \ Received data PID/SETUP packet count


\
\ @brief OTG device endpoint-7 control register
\ Address offset: 0x3E0
\ Reset value: 0x00000000
\

$000007ff constant OTG2_HS_DEVICE_OTG_HS_DOEPCTL7_MPSIZ             \ Maximum packet size
$00008000 constant OTG2_HS_DEVICE_OTG_HS_DOEPCTL7_USBAEP            \ USB active endpoint
$00010000 constant OTG2_HS_DEVICE_OTG_HS_DOEPCTL7_EONUM_DPID        \ Even odd frame/Endpoint data PID
$00020000 constant OTG2_HS_DEVICE_OTG_HS_DOEPCTL7_NAKSTS            \ NAK status
$000c0000 constant OTG2_HS_DEVICE_OTG_HS_DOEPCTL7_EPTYP             \ Endpoint type
$00100000 constant OTG2_HS_DEVICE_OTG_HS_DOEPCTL7_SNPM              \ Snoop mode
$00200000 constant OTG2_HS_DEVICE_OTG_HS_DOEPCTL7_STALL             \ STALL handshake
$04000000 constant OTG2_HS_DEVICE_OTG_HS_DOEPCTL7_CNAK              \ Clear NAK
$08000000 constant OTG2_HS_DEVICE_OTG_HS_DOEPCTL7_SNAK              \ Set NAK
$10000000 constant OTG2_HS_DEVICE_OTG_HS_DOEPCTL7_SD0PID_SEVNFRM    \ Set DATA0 PID/Set even frame
$20000000 constant OTG2_HS_DEVICE_OTG_HS_DOEPCTL7_SODDFRM           \ Set odd frame
$40000000 constant OTG2_HS_DEVICE_OTG_HS_DOEPCTL7_EPDIS             \ Endpoint disable
$80000000 constant OTG2_HS_DEVICE_OTG_HS_DOEPCTL7_EPENA             \ Endpoint enable


\
\ @brief OTG_HS device endpoint-7 interrupt register
\ Address offset: 0x3E8
\ Reset value: 0x00000000
\

$00000001 constant OTG2_HS_DEVICE_OTG_HS_DOEPINT7_XFRC              \ Transfer completed interrupt
$00000002 constant OTG2_HS_DEVICE_OTG_HS_DOEPINT7_EPDISD            \ Endpoint disabled interrupt
$00000008 constant OTG2_HS_DEVICE_OTG_HS_DOEPINT7_STUP              \ SETUP phase done
$00000010 constant OTG2_HS_DEVICE_OTG_HS_DOEPINT7_OTEPDIS           \ OUT token received when endpoint disabled
$00000040 constant OTG2_HS_DEVICE_OTG_HS_DOEPINT7_B2BSTUP           \ Back-to-back SETUP packets received
$00004000 constant OTG2_HS_DEVICE_OTG_HS_DOEPINT7_NYET              \ NYET interrupt


\
\ @brief OTG_HS device endpoint-7 transfer size register
\ Address offset: 0x3F0
\ Reset value: 0x00000000
\

$0007ffff constant OTG2_HS_DEVICE_OTG_HS_DOEPTSIZ7_XFRSIZ           \ Transfer size
$1ff80000 constant OTG2_HS_DEVICE_OTG_HS_DOEPTSIZ7_PKTCNT           \ Packet count
$60000000 constant OTG2_HS_DEVICE_OTG_HS_DOEPTSIZ7_RXDPID_STUPCNT    \ Received data PID/SETUP packet count


\
\ @brief USB 1 on the go high speed
\
$40080800 constant OTG2_HS_DEVICE_OTG_HS_DCFG  \ offset: 0x00 : OTG_HS device configuration register
$40080804 constant OTG2_HS_DEVICE_OTG_HS_DCTL  \ offset: 0x04 : OTG_HS device control register
$40080808 constant OTG2_HS_DEVICE_OTG_HS_DSTS  \ offset: 0x08 : OTG_HS device status register
$40080810 constant OTG2_HS_DEVICE_OTG_HS_DIEPMSK  \ offset: 0x10 : OTG_HS device IN endpoint common interrupt mask register
$40080814 constant OTG2_HS_DEVICE_OTG_HS_DOEPMSK  \ offset: 0x14 : OTG_HS device OUT endpoint common interrupt mask register
$40080818 constant OTG2_HS_DEVICE_OTG_HS_DAINT  \ offset: 0x18 : OTG_HS device all endpoints interrupt register
$4008081c constant OTG2_HS_DEVICE_OTG_HS_DAINTMSK  \ offset: 0x1C : OTG_HS all endpoints interrupt mask register
$40080828 constant OTG2_HS_DEVICE_OTG_HS_DVBUSDIS  \ offset: 0x28 : OTG_HS device VBUS discharge time register
$4008082c constant OTG2_HS_DEVICE_OTG_HS_DVBUSPULSE  \ offset: 0x2C : OTG_HS device VBUS pulsing time register
$40080830 constant OTG2_HS_DEVICE_OTG_HS_DTHRCTL  \ offset: 0x30 : OTG_HS Device threshold control register
$40080834 constant OTG2_HS_DEVICE_OTG_HS_DIEPEMPMSK  \ offset: 0x34 : OTG_HS device IN endpoint FIFO empty interrupt mask register
$40080838 constant OTG2_HS_DEVICE_OTG_HS_DEACHINT  \ offset: 0x38 : OTG_HS device each endpoint interrupt register
$4008083c constant OTG2_HS_DEVICE_OTG_HS_DEACHINTMSK  \ offset: 0x3C : OTG_HS device each endpoint interrupt register mask
$40080900 constant OTG2_HS_DEVICE_OTG_HS_DIEPCTL0  \ offset: 0x100 : OTG device endpoint-0 control register
$40080908 constant OTG2_HS_DEVICE_OTG_HS_DIEPINT0  \ offset: 0x108 : OTG device endpoint-0 interrupt register
$40080910 constant OTG2_HS_DEVICE_OTG_HS_DIEPTSIZ0  \ offset: 0x110 : OTG_HS device IN endpoint 0 transfer size register
$40080914 constant OTG2_HS_DEVICE_OTG_HS_DIEPDMA1  \ offset: 0x114 : OTG_HS device endpoint-1 DMA address register
$40080918 constant OTG2_HS_DEVICE_OTG_HS_DTXFSTS0  \ offset: 0x118 : OTG_HS device IN endpoint transmit FIFO status register
$40080920 constant OTG2_HS_DEVICE_OTG_HS_DIEPCTL1  \ offset: 0x120 : OTG device endpoint-1 control register
$40080928 constant OTG2_HS_DEVICE_OTG_HS_DIEPINT1  \ offset: 0x128 : OTG device endpoint-1 interrupt register
$40080930 constant OTG2_HS_DEVICE_OTG_HS_DIEPTSIZ1  \ offset: 0x130 : OTG_HS device endpoint transfer size register
$40080934 constant OTG2_HS_DEVICE_OTG_HS_DIEPDMA2  \ offset: 0x134 : OTG_HS device endpoint-2 DMA address register
$40080938 constant OTG2_HS_DEVICE_OTG_HS_DTXFSTS1  \ offset: 0x138 : OTG_HS device IN endpoint transmit FIFO status register
$40080940 constant OTG2_HS_DEVICE_OTG_HS_DIEPCTL2  \ offset: 0x140 : OTG device endpoint-2 control register
$40080948 constant OTG2_HS_DEVICE_OTG_HS_DIEPINT2  \ offset: 0x148 : OTG device endpoint-2 interrupt register
$40080950 constant OTG2_HS_DEVICE_OTG_HS_DIEPTSIZ2  \ offset: 0x150 : OTG_HS device endpoint transfer size register
$40080954 constant OTG2_HS_DEVICE_OTG_HS_DIEPDMA3  \ offset: 0x154 : OTG_HS device endpoint-3 DMA address register
$40080958 constant OTG2_HS_DEVICE_OTG_HS_DTXFSTS2  \ offset: 0x158 : OTG_HS device IN endpoint transmit FIFO status register
$40080960 constant OTG2_HS_DEVICE_OTG_HS_DIEPCTL3  \ offset: 0x160 : OTG device endpoint-3 control register
$40080968 constant OTG2_HS_DEVICE_OTG_HS_DIEPINT3  \ offset: 0x168 : OTG device endpoint-3 interrupt register
$40080970 constant OTG2_HS_DEVICE_OTG_HS_DIEPTSIZ3  \ offset: 0x170 : OTG_HS device endpoint transfer size register
$40080974 constant OTG2_HS_DEVICE_OTG_HS_DIEPDMA4  \ offset: 0x174 : OTG_HS device endpoint-4 DMA address register
$40080978 constant OTG2_HS_DEVICE_OTG_HS_DTXFSTS3  \ offset: 0x178 : OTG_HS device IN endpoint transmit FIFO status register
$40080980 constant OTG2_HS_DEVICE_OTG_HS_DIEPCTL4  \ offset: 0x180 : OTG device endpoint-4 control register
$40080988 constant OTG2_HS_DEVICE_OTG_HS_DIEPINT4  \ offset: 0x188 : OTG device endpoint-4 interrupt register
$40080990 constant OTG2_HS_DEVICE_OTG_HS_DIEPTSIZ4  \ offset: 0x190 : OTG_HS device endpoint transfer size register
$40080994 constant OTG2_HS_DEVICE_OTG_HS_DIEPDMA5  \ offset: 0x194 : OTG_HS device endpoint-5 DMA address register
$40080998 constant OTG2_HS_DEVICE_OTG_HS_DTXFSTS4  \ offset: 0x198 : OTG_HS device IN endpoint transmit FIFO status register
$400809a0 constant OTG2_HS_DEVICE_OTG_HS_DIEPCTL5  \ offset: 0x1A0 : OTG device endpoint-5 control register
$400809a0 constant OTG2_HS_DEVICE_OTG_HS_DIEPTSIZ6  \ offset: 0x1A0 : OTG_HS device endpoint transfer size register
$400809a4 constant OTG2_HS_DEVICE_OTG_HS_DTXFSTS6  \ offset: 0x1A4 : OTG_HS device IN endpoint transmit FIFO status register
$400809a8 constant OTG2_HS_DEVICE_OTG_HS_DIEPINT5  \ offset: 0x1A8 : OTG device endpoint-5 interrupt register
$400809a8 constant OTG2_HS_DEVICE_OTG_HS_DIEPTSIZ7  \ offset: 0x1A8 : OTG_HS device endpoint transfer size register
$400809ac constant OTG2_HS_DEVICE_OTG_HS_DTXFSTS7  \ offset: 0x1AC : OTG_HS device IN endpoint transmit FIFO status register
$400809b0 constant OTG2_HS_DEVICE_OTG_HS_DIEPTSIZ5  \ offset: 0x1B0 : OTG_HS device endpoint transfer size register
$400809b8 constant OTG2_HS_DEVICE_OTG_HS_DTXFSTS5  \ offset: 0x1B8 : OTG_HS device IN endpoint transmit FIFO status register
$400809c0 constant OTG2_HS_DEVICE_OTG_HS_DIEPCTL6  \ offset: 0x1C0 : OTG device endpoint-6 control register
$400809c8 constant OTG2_HS_DEVICE_OTG_HS_DIEPINT6  \ offset: 0x1C8 : OTG device endpoint-6 interrupt register
$400809e0 constant OTG2_HS_DEVICE_OTG_HS_DIEPCTL7  \ offset: 0x1E0 : OTG device endpoint-7 control register
$400809e8 constant OTG2_HS_DEVICE_OTG_HS_DIEPINT7  \ offset: 0x1E8 : OTG device endpoint-7 interrupt register
$40080b00 constant OTG2_HS_DEVICE_OTG_HS_DOEPCTL0  \ offset: 0x300 : OTG_HS device control OUT endpoint 0 control register
$40080b08 constant OTG2_HS_DEVICE_OTG_HS_DOEPINT0  \ offset: 0x308 : OTG_HS device endpoint-0 interrupt register
$40080b10 constant OTG2_HS_DEVICE_OTG_HS_DOEPTSIZ0  \ offset: 0x310 : OTG_HS device endpoint-0 transfer size register
$40080b20 constant OTG2_HS_DEVICE_OTG_HS_DOEPCTL1  \ offset: 0x320 : OTG device endpoint-1 control register
$40080b28 constant OTG2_HS_DEVICE_OTG_HS_DOEPINT1  \ offset: 0x328 : OTG_HS device endpoint-1 interrupt register
$40080b30 constant OTG2_HS_DEVICE_OTG_HS_DOEPTSIZ1  \ offset: 0x330 : OTG_HS device endpoint-1 transfer size register
$40080b40 constant OTG2_HS_DEVICE_OTG_HS_DOEPCTL2  \ offset: 0x340 : OTG device endpoint-2 control register
$40080b48 constant OTG2_HS_DEVICE_OTG_HS_DOEPINT2  \ offset: 0x348 : OTG_HS device endpoint-2 interrupt register
$40080b50 constant OTG2_HS_DEVICE_OTG_HS_DOEPTSIZ2  \ offset: 0x350 : OTG_HS device endpoint-2 transfer size register
$40080b60 constant OTG2_HS_DEVICE_OTG_HS_DOEPCTL3  \ offset: 0x360 : OTG device endpoint-3 control register
$40080b68 constant OTG2_HS_DEVICE_OTG_HS_DOEPINT3  \ offset: 0x368 : OTG_HS device endpoint-3 interrupt register
$40080b70 constant OTG2_HS_DEVICE_OTG_HS_DOEPTSIZ3  \ offset: 0x370 : OTG_HS device endpoint-3 transfer size register
$40080b80 constant OTG2_HS_DEVICE_OTG_HS_DOEPCTL4  \ offset: 0x380 : OTG device endpoint-4 control register
$40080b88 constant OTG2_HS_DEVICE_OTG_HS_DOEPINT4  \ offset: 0x388 : OTG_HS device endpoint-4 interrupt register
$40080b90 constant OTG2_HS_DEVICE_OTG_HS_DOEPTSIZ4  \ offset: 0x390 : OTG_HS device endpoint-4 transfer size register
$40080ba0 constant OTG2_HS_DEVICE_OTG_HS_DOEPCTL5  \ offset: 0x3A0 : OTG device endpoint-5 control register
$40080ba8 constant OTG2_HS_DEVICE_OTG_HS_DOEPINT5  \ offset: 0x3A8 : OTG_HS device endpoint-5 interrupt register
$40080bb0 constant OTG2_HS_DEVICE_OTG_HS_DOEPTSIZ5  \ offset: 0x3B0 : OTG_HS device endpoint-5 transfer size register
$40080bc0 constant OTG2_HS_DEVICE_OTG_HS_DOEPCTL6  \ offset: 0x3C0 : OTG device endpoint-6 control register
$40080bc8 constant OTG2_HS_DEVICE_OTG_HS_DOEPINT6  \ offset: 0x3C8 : OTG_HS device endpoint-6 interrupt register
$40080bd0 constant OTG2_HS_DEVICE_OTG_HS_DOEPTSIZ6  \ offset: 0x3D0 : OTG_HS device endpoint-6 transfer size register
$40080be0 constant OTG2_HS_DEVICE_OTG_HS_DOEPCTL7  \ offset: 0x3E0 : OTG device endpoint-7 control register
$40080be8 constant OTG2_HS_DEVICE_OTG_HS_DOEPINT7  \ offset: 0x3E8 : OTG_HS device endpoint-7 interrupt register
$40080bf0 constant OTG2_HS_DEVICE_OTG_HS_DOEPTSIZ7  \ offset: 0x3F0 : OTG_HS device endpoint-7 transfer size register

