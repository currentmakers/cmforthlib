\
\ @file otg_hs_host.fs
\ @brief USB on the go high speed
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief OTG_HS host configuration register
\ Address offset: 0x00
\ Reset value: 0x00000000
\

$00000003 constant OTG_HS_HOST_OTG_HS_HCFG_FSLSPCS                  \ FS/LS PHY clock select
$00000004 constant OTG_HS_HOST_OTG_HS_HCFG_FSLSS                    \ FS- and LS-only support


\
\ @brief OTG_HS Host frame interval register
\ Address offset: 0x04
\ Reset value: 0x0000EA60
\

$0000ffff constant OTG_HS_HOST_OTG_HS_HFIR_FRIVL                    \ Frame interval


\
\ @brief OTG_HS host frame number/frame time remaining register
\ Address offset: 0x08
\ Reset value: 0x00003FFF
\

$0000ffff constant OTG_HS_HOST_OTG_HS_HFNUM_FRNUM                   \ Frame number
$ffff0000 constant OTG_HS_HOST_OTG_HS_HFNUM_FTREM                   \ Frame time remaining


\
\ @brief OTG_HS_Host periodic transmit FIFO/queue status register
\ Address offset: 0x10
\ Reset value: 0x00080100
\

$0000ffff constant OTG_HS_HOST_OTG_HS_HPTXSTS_PTXFSAVL              \ Periodic transmit data FIFO space available
$00ff0000 constant OTG_HS_HOST_OTG_HS_HPTXSTS_PTXQSAV               \ Periodic transmit request queue space available
$ff000000 constant OTG_HS_HOST_OTG_HS_HPTXSTS_PTXQTOP               \ Top of the periodic transmit request queue


\
\ @brief OTG_HS Host all channels interrupt register
\ Address offset: 0x14
\ Reset value: 0x00000000
\

$0000ffff constant OTG_HS_HOST_OTG_HS_HAINT_HAINT                   \ Channel interrupts


\
\ @brief OTG_HS host all channels interrupt mask register
\ Address offset: 0x18
\ Reset value: 0x00000000
\

$0000ffff constant OTG_HS_HOST_OTG_HS_HAINTMSK_HAINTM               \ Channel interrupt mask


\
\ @brief OTG_HS host port control and status register
\ Address offset: 0x40
\ Reset value: 0x00000000
\

$00000001 constant OTG_HS_HOST_OTG_HS_HPRT_PCSTS                    \ Port connect status
$00000002 constant OTG_HS_HOST_OTG_HS_HPRT_PCDET                    \ Port connect detected
$00000004 constant OTG_HS_HOST_OTG_HS_HPRT_PENA                     \ Port enable
$00000008 constant OTG_HS_HOST_OTG_HS_HPRT_PENCHNG                  \ Port enable/disable change
$00000010 constant OTG_HS_HOST_OTG_HS_HPRT_POCA                     \ Port overcurrent active
$00000020 constant OTG_HS_HOST_OTG_HS_HPRT_POCCHNG                  \ Port overcurrent change
$00000040 constant OTG_HS_HOST_OTG_HS_HPRT_PRES                     \ Port resume
$00000080 constant OTG_HS_HOST_OTG_HS_HPRT_PSUSP                    \ Port suspend
$00000100 constant OTG_HS_HOST_OTG_HS_HPRT_PRST                     \ Port reset
$00000c00 constant OTG_HS_HOST_OTG_HS_HPRT_PLSTS                    \ Port line status
$00001000 constant OTG_HS_HOST_OTG_HS_HPRT_PPWR                     \ Port power
$0001e000 constant OTG_HS_HOST_OTG_HS_HPRT_PTCTL                    \ Port test control
$00060000 constant OTG_HS_HOST_OTG_HS_HPRT_PSPD                     \ Port speed


\
\ @brief OTG_HS host channel-0 characteristics register
\ Address offset: 0x100
\ Reset value: 0x00000000
\

$000007ff constant OTG_HS_HOST_OTG_HS_HCCHAR0_MPSIZ                 \ Maximum packet size
$00007800 constant OTG_HS_HOST_OTG_HS_HCCHAR0_EPNUM                 \ Endpoint number
$00008000 constant OTG_HS_HOST_OTG_HS_HCCHAR0_EPDIR                 \ Endpoint direction
$00020000 constant OTG_HS_HOST_OTG_HS_HCCHAR0_LSDEV                 \ Low-speed device
$000c0000 constant OTG_HS_HOST_OTG_HS_HCCHAR0_EPTYP                 \ Endpoint type
$00300000 constant OTG_HS_HOST_OTG_HS_HCCHAR0_MC                    \ Multi Count (MC) / Error Count (EC)
$1fc00000 constant OTG_HS_HOST_OTG_HS_HCCHAR0_DAD                   \ Device address
$20000000 constant OTG_HS_HOST_OTG_HS_HCCHAR0_ODDFRM                \ Odd frame
$40000000 constant OTG_HS_HOST_OTG_HS_HCCHAR0_CHDIS                 \ Channel disable
$80000000 constant OTG_HS_HOST_OTG_HS_HCCHAR0_CHENA                 \ Channel enable


\
\ @brief OTG_HS host channel-0 split control register
\ Address offset: 0x104
\ Reset value: 0x00000000
\

$0000007f constant OTG_HS_HOST_OTG_HS_HCSPLT0_PRTADDR               \ Port address
$00003f80 constant OTG_HS_HOST_OTG_HS_HCSPLT0_HUBADDR               \ Hub address
$0000c000 constant OTG_HS_HOST_OTG_HS_HCSPLT0_XACTPOS               \ XACTPOS
$00010000 constant OTG_HS_HOST_OTG_HS_HCSPLT0_COMPLSPLT             \ Do complete split
$80000000 constant OTG_HS_HOST_OTG_HS_HCSPLT0_SPLITEN               \ Split enable


\
\ @brief OTG_HS host channel-11 interrupt register
\ Address offset: 0x108
\ Reset value: 0x00000000
\

$00000001 constant OTG_HS_HOST_OTG_HS_HCINT0_XFRC                   \ Transfer completed
$00000002 constant OTG_HS_HOST_OTG_HS_HCINT0_CHH                    \ Channel halted
$00000004 constant OTG_HS_HOST_OTG_HS_HCINT0_AHBERR                 \ AHB error
$00000008 constant OTG_HS_HOST_OTG_HS_HCINT0_STALL                  \ STALL response received interrupt
$00000010 constant OTG_HS_HOST_OTG_HS_HCINT0_NAK                    \ NAK response received interrupt
$00000020 constant OTG_HS_HOST_OTG_HS_HCINT0_ACK                    \ ACK response received/transmitted interrupt
$00000040 constant OTG_HS_HOST_OTG_HS_HCINT0_NYET                   \ Response received interrupt
$00000080 constant OTG_HS_HOST_OTG_HS_HCINT0_TXERR                  \ Transaction error
$00000100 constant OTG_HS_HOST_OTG_HS_HCINT0_BBERR                  \ Babble error
$00000200 constant OTG_HS_HOST_OTG_HS_HCINT0_FRMOR                  \ Frame overrun
$00000400 constant OTG_HS_HOST_OTG_HS_HCINT0_DTERR                  \ Data toggle error


\
\ @brief OTG_HS host channel-11 interrupt mask register
\ Address offset: 0x10C
\ Reset value: 0x00000000
\

$00000001 constant OTG_HS_HOST_OTG_HS_HCINTMSK0_XFRCM               \ Transfer completed mask
$00000002 constant OTG_HS_HOST_OTG_HS_HCINTMSK0_CHHM                \ Channel halted mask
$00000004 constant OTG_HS_HOST_OTG_HS_HCINTMSK0_AHBERR              \ AHB error
$00000008 constant OTG_HS_HOST_OTG_HS_HCINTMSK0_STALLM              \ STALL response received interrupt mask
$00000010 constant OTG_HS_HOST_OTG_HS_HCINTMSK0_NAKM                \ NAK response received interrupt mask
$00000020 constant OTG_HS_HOST_OTG_HS_HCINTMSK0_ACKM                \ ACK response received/transmitted interrupt mask
$00000040 constant OTG_HS_HOST_OTG_HS_HCINTMSK0_NYET                \ response received interrupt mask
$00000080 constant OTG_HS_HOST_OTG_HS_HCINTMSK0_TXERRM              \ Transaction error mask
$00000100 constant OTG_HS_HOST_OTG_HS_HCINTMSK0_BBERRM              \ Babble error mask
$00000200 constant OTG_HS_HOST_OTG_HS_HCINTMSK0_FRMORM              \ Frame overrun mask
$00000400 constant OTG_HS_HOST_OTG_HS_HCINTMSK0_DTERRM              \ Data toggle error mask


\
\ @brief OTG_HS host channel-11 transfer size register
\ Address offset: 0x110
\ Reset value: 0x00000000
\

$0007ffff constant OTG_HS_HOST_OTG_HS_HCTSIZ0_XFRSIZ                \ Transfer size
$1ff80000 constant OTG_HS_HOST_OTG_HS_HCTSIZ0_PKTCNT                \ Packet count
$60000000 constant OTG_HS_HOST_OTG_HS_HCTSIZ0_DPID                  \ Data PID


\
\ @brief OTG_HS host channel-0 DMA address register
\ Address offset: 0x114
\ Reset value: 0x00000000
\

$00000000 constant OTG_HS_HOST_OTG_HS_HCDMA0_DMAADDR                \ DMA address


\
\ @brief OTG_HS host channel-1 characteristics register
\ Address offset: 0x120
\ Reset value: 0x00000000
\

$000007ff constant OTG_HS_HOST_OTG_HS_HCCHAR1_MPSIZ                 \ Maximum packet size
$00007800 constant OTG_HS_HOST_OTG_HS_HCCHAR1_EPNUM                 \ Endpoint number
$00008000 constant OTG_HS_HOST_OTG_HS_HCCHAR1_EPDIR                 \ Endpoint direction
$00020000 constant OTG_HS_HOST_OTG_HS_HCCHAR1_LSDEV                 \ Low-speed device
$000c0000 constant OTG_HS_HOST_OTG_HS_HCCHAR1_EPTYP                 \ Endpoint type
$00300000 constant OTG_HS_HOST_OTG_HS_HCCHAR1_MC                    \ Multi Count (MC) / Error Count (EC)
$1fc00000 constant OTG_HS_HOST_OTG_HS_HCCHAR1_DAD                   \ Device address
$20000000 constant OTG_HS_HOST_OTG_HS_HCCHAR1_ODDFRM                \ Odd frame
$40000000 constant OTG_HS_HOST_OTG_HS_HCCHAR1_CHDIS                 \ Channel disable
$80000000 constant OTG_HS_HOST_OTG_HS_HCCHAR1_CHENA                 \ Channel enable


\
\ @brief OTG_HS host channel-1 split control register
\ Address offset: 0x124
\ Reset value: 0x00000000
\

$0000007f constant OTG_HS_HOST_OTG_HS_HCSPLT1_PRTADDR               \ Port address
$00003f80 constant OTG_HS_HOST_OTG_HS_HCSPLT1_HUBADDR               \ Hub address
$0000c000 constant OTG_HS_HOST_OTG_HS_HCSPLT1_XACTPOS               \ XACTPOS
$00010000 constant OTG_HS_HOST_OTG_HS_HCSPLT1_COMPLSPLT             \ Do complete split
$80000000 constant OTG_HS_HOST_OTG_HS_HCSPLT1_SPLITEN               \ Split enable


\
\ @brief OTG_HS host channel-1 interrupt register
\ Address offset: 0x128
\ Reset value: 0x00000000
\

$00000001 constant OTG_HS_HOST_OTG_HS_HCINT1_XFRC                   \ Transfer completed
$00000002 constant OTG_HS_HOST_OTG_HS_HCINT1_CHH                    \ Channel halted
$00000004 constant OTG_HS_HOST_OTG_HS_HCINT1_AHBERR                 \ AHB error
$00000008 constant OTG_HS_HOST_OTG_HS_HCINT1_STALL                  \ STALL response received interrupt
$00000010 constant OTG_HS_HOST_OTG_HS_HCINT1_NAK                    \ NAK response received interrupt
$00000020 constant OTG_HS_HOST_OTG_HS_HCINT1_ACK                    \ ACK response received/transmitted interrupt
$00000040 constant OTG_HS_HOST_OTG_HS_HCINT1_NYET                   \ Response received interrupt
$00000080 constant OTG_HS_HOST_OTG_HS_HCINT1_TXERR                  \ Transaction error
$00000100 constant OTG_HS_HOST_OTG_HS_HCINT1_BBERR                  \ Babble error
$00000200 constant OTG_HS_HOST_OTG_HS_HCINT1_FRMOR                  \ Frame overrun
$00000400 constant OTG_HS_HOST_OTG_HS_HCINT1_DTERR                  \ Data toggle error


\
\ @brief OTG_HS host channel-1 interrupt mask register
\ Address offset: 0x12C
\ Reset value: 0x00000000
\

$00000001 constant OTG_HS_HOST_OTG_HS_HCINTMSK1_XFRCM               \ Transfer completed mask
$00000002 constant OTG_HS_HOST_OTG_HS_HCINTMSK1_CHHM                \ Channel halted mask
$00000004 constant OTG_HS_HOST_OTG_HS_HCINTMSK1_AHBERR              \ AHB error
$00000008 constant OTG_HS_HOST_OTG_HS_HCINTMSK1_STALLM              \ STALL response received interrupt mask
$00000010 constant OTG_HS_HOST_OTG_HS_HCINTMSK1_NAKM                \ NAK response received interrupt mask
$00000020 constant OTG_HS_HOST_OTG_HS_HCINTMSK1_ACKM                \ ACK response received/transmitted interrupt mask
$00000040 constant OTG_HS_HOST_OTG_HS_HCINTMSK1_NYET                \ response received interrupt mask
$00000080 constant OTG_HS_HOST_OTG_HS_HCINTMSK1_TXERRM              \ Transaction error mask
$00000100 constant OTG_HS_HOST_OTG_HS_HCINTMSK1_BBERRM              \ Babble error mask
$00000200 constant OTG_HS_HOST_OTG_HS_HCINTMSK1_FRMORM              \ Frame overrun mask
$00000400 constant OTG_HS_HOST_OTG_HS_HCINTMSK1_DTERRM              \ Data toggle error mask


\
\ @brief OTG_HS host channel-1 transfer size register
\ Address offset: 0x130
\ Reset value: 0x00000000
\

$0007ffff constant OTG_HS_HOST_OTG_HS_HCTSIZ1_XFRSIZ                \ Transfer size
$1ff80000 constant OTG_HS_HOST_OTG_HS_HCTSIZ1_PKTCNT                \ Packet count
$60000000 constant OTG_HS_HOST_OTG_HS_HCTSIZ1_DPID                  \ Data PID


\
\ @brief OTG_HS host channel-1 DMA address register
\ Address offset: 0x134
\ Reset value: 0x00000000
\

$00000000 constant OTG_HS_HOST_OTG_HS_HCDMA1_DMAADDR                \ DMA address


\
\ @brief OTG_HS host channel-2 characteristics register
\ Address offset: 0x140
\ Reset value: 0x00000000
\

$000007ff constant OTG_HS_HOST_OTG_HS_HCCHAR2_MPSIZ                 \ Maximum packet size
$00007800 constant OTG_HS_HOST_OTG_HS_HCCHAR2_EPNUM                 \ Endpoint number
$00008000 constant OTG_HS_HOST_OTG_HS_HCCHAR2_EPDIR                 \ Endpoint direction
$00020000 constant OTG_HS_HOST_OTG_HS_HCCHAR2_LSDEV                 \ Low-speed device
$000c0000 constant OTG_HS_HOST_OTG_HS_HCCHAR2_EPTYP                 \ Endpoint type
$00300000 constant OTG_HS_HOST_OTG_HS_HCCHAR2_MC                    \ Multi Count (MC) / Error Count (EC)
$1fc00000 constant OTG_HS_HOST_OTG_HS_HCCHAR2_DAD                   \ Device address
$20000000 constant OTG_HS_HOST_OTG_HS_HCCHAR2_ODDFRM                \ Odd frame
$40000000 constant OTG_HS_HOST_OTG_HS_HCCHAR2_CHDIS                 \ Channel disable
$80000000 constant OTG_HS_HOST_OTG_HS_HCCHAR2_CHENA                 \ Channel enable


\
\ @brief OTG_HS host channel-2 split control register
\ Address offset: 0x144
\ Reset value: 0x00000000
\

$0000007f constant OTG_HS_HOST_OTG_HS_HCSPLT2_PRTADDR               \ Port address
$00003f80 constant OTG_HS_HOST_OTG_HS_HCSPLT2_HUBADDR               \ Hub address
$0000c000 constant OTG_HS_HOST_OTG_HS_HCSPLT2_XACTPOS               \ XACTPOS
$00010000 constant OTG_HS_HOST_OTG_HS_HCSPLT2_COMPLSPLT             \ Do complete split
$80000000 constant OTG_HS_HOST_OTG_HS_HCSPLT2_SPLITEN               \ Split enable


\
\ @brief OTG_HS host channel-2 interrupt register
\ Address offset: 0x148
\ Reset value: 0x00000000
\

$00000001 constant OTG_HS_HOST_OTG_HS_HCINT2_XFRC                   \ Transfer completed
$00000002 constant OTG_HS_HOST_OTG_HS_HCINT2_CHH                    \ Channel halted
$00000004 constant OTG_HS_HOST_OTG_HS_HCINT2_AHBERR                 \ AHB error
$00000008 constant OTG_HS_HOST_OTG_HS_HCINT2_STALL                  \ STALL response received interrupt
$00000010 constant OTG_HS_HOST_OTG_HS_HCINT2_NAK                    \ NAK response received interrupt
$00000020 constant OTG_HS_HOST_OTG_HS_HCINT2_ACK                    \ ACK response received/transmitted interrupt
$00000040 constant OTG_HS_HOST_OTG_HS_HCINT2_NYET                   \ Response received interrupt
$00000080 constant OTG_HS_HOST_OTG_HS_HCINT2_TXERR                  \ Transaction error
$00000100 constant OTG_HS_HOST_OTG_HS_HCINT2_BBERR                  \ Babble error
$00000200 constant OTG_HS_HOST_OTG_HS_HCINT2_FRMOR                  \ Frame overrun
$00000400 constant OTG_HS_HOST_OTG_HS_HCINT2_DTERR                  \ Data toggle error


\
\ @brief OTG_HS host channel-2 interrupt mask register
\ Address offset: 0x14C
\ Reset value: 0x00000000
\

$00000001 constant OTG_HS_HOST_OTG_HS_HCINTMSK2_XFRCM               \ Transfer completed mask
$00000002 constant OTG_HS_HOST_OTG_HS_HCINTMSK2_CHHM                \ Channel halted mask
$00000004 constant OTG_HS_HOST_OTG_HS_HCINTMSK2_AHBERR              \ AHB error
$00000008 constant OTG_HS_HOST_OTG_HS_HCINTMSK2_STALLM              \ STALL response received interrupt mask
$00000010 constant OTG_HS_HOST_OTG_HS_HCINTMSK2_NAKM                \ NAK response received interrupt mask
$00000020 constant OTG_HS_HOST_OTG_HS_HCINTMSK2_ACKM                \ ACK response received/transmitted interrupt mask
$00000040 constant OTG_HS_HOST_OTG_HS_HCINTMSK2_NYET                \ response received interrupt mask
$00000080 constant OTG_HS_HOST_OTG_HS_HCINTMSK2_TXERRM              \ Transaction error mask
$00000100 constant OTG_HS_HOST_OTG_HS_HCINTMSK2_BBERRM              \ Babble error mask
$00000200 constant OTG_HS_HOST_OTG_HS_HCINTMSK2_FRMORM              \ Frame overrun mask
$00000400 constant OTG_HS_HOST_OTG_HS_HCINTMSK2_DTERRM              \ Data toggle error mask


\
\ @brief OTG_HS host channel-2 transfer size register
\ Address offset: 0x150
\ Reset value: 0x00000000
\

$0007ffff constant OTG_HS_HOST_OTG_HS_HCTSIZ2_XFRSIZ                \ Transfer size
$1ff80000 constant OTG_HS_HOST_OTG_HS_HCTSIZ2_PKTCNT                \ Packet count
$60000000 constant OTG_HS_HOST_OTG_HS_HCTSIZ2_DPID                  \ Data PID


\
\ @brief OTG_HS host channel-2 DMA address register
\ Address offset: 0x154
\ Reset value: 0x00000000
\

$00000000 constant OTG_HS_HOST_OTG_HS_HCDMA2_DMAADDR                \ DMA address


\
\ @brief OTG_HS host channel-3 characteristics register
\ Address offset: 0x160
\ Reset value: 0x00000000
\

$000007ff constant OTG_HS_HOST_OTG_HS_HCCHAR3_MPSIZ                 \ Maximum packet size
$00007800 constant OTG_HS_HOST_OTG_HS_HCCHAR3_EPNUM                 \ Endpoint number
$00008000 constant OTG_HS_HOST_OTG_HS_HCCHAR3_EPDIR                 \ Endpoint direction
$00020000 constant OTG_HS_HOST_OTG_HS_HCCHAR3_LSDEV                 \ Low-speed device
$000c0000 constant OTG_HS_HOST_OTG_HS_HCCHAR3_EPTYP                 \ Endpoint type
$00300000 constant OTG_HS_HOST_OTG_HS_HCCHAR3_MC                    \ Multi Count (MC) / Error Count (EC)
$1fc00000 constant OTG_HS_HOST_OTG_HS_HCCHAR3_DAD                   \ Device address
$20000000 constant OTG_HS_HOST_OTG_HS_HCCHAR3_ODDFRM                \ Odd frame
$40000000 constant OTG_HS_HOST_OTG_HS_HCCHAR3_CHDIS                 \ Channel disable
$80000000 constant OTG_HS_HOST_OTG_HS_HCCHAR3_CHENA                 \ Channel enable


\
\ @brief OTG_HS host channel-3 split control register
\ Address offset: 0x164
\ Reset value: 0x00000000
\

$0000007f constant OTG_HS_HOST_OTG_HS_HCSPLT3_PRTADDR               \ Port address
$00003f80 constant OTG_HS_HOST_OTG_HS_HCSPLT3_HUBADDR               \ Hub address
$0000c000 constant OTG_HS_HOST_OTG_HS_HCSPLT3_XACTPOS               \ XACTPOS
$00010000 constant OTG_HS_HOST_OTG_HS_HCSPLT3_COMPLSPLT             \ Do complete split
$80000000 constant OTG_HS_HOST_OTG_HS_HCSPLT3_SPLITEN               \ Split enable


\
\ @brief OTG_HS host channel-3 interrupt register
\ Address offset: 0x168
\ Reset value: 0x00000000
\

$00000001 constant OTG_HS_HOST_OTG_HS_HCINT3_XFRC                   \ Transfer completed
$00000002 constant OTG_HS_HOST_OTG_HS_HCINT3_CHH                    \ Channel halted
$00000004 constant OTG_HS_HOST_OTG_HS_HCINT3_AHBERR                 \ AHB error
$00000008 constant OTG_HS_HOST_OTG_HS_HCINT3_STALL                  \ STALL response received interrupt
$00000010 constant OTG_HS_HOST_OTG_HS_HCINT3_NAK                    \ NAK response received interrupt
$00000020 constant OTG_HS_HOST_OTG_HS_HCINT3_ACK                    \ ACK response received/transmitted interrupt
$00000040 constant OTG_HS_HOST_OTG_HS_HCINT3_NYET                   \ Response received interrupt
$00000080 constant OTG_HS_HOST_OTG_HS_HCINT3_TXERR                  \ Transaction error
$00000100 constant OTG_HS_HOST_OTG_HS_HCINT3_BBERR                  \ Babble error
$00000200 constant OTG_HS_HOST_OTG_HS_HCINT3_FRMOR                  \ Frame overrun
$00000400 constant OTG_HS_HOST_OTG_HS_HCINT3_DTERR                  \ Data toggle error


\
\ @brief OTG_HS host channel-3 interrupt mask register
\ Address offset: 0x16C
\ Reset value: 0x00000000
\

$00000001 constant OTG_HS_HOST_OTG_HS_HCINTMSK3_XFRCM               \ Transfer completed mask
$00000002 constant OTG_HS_HOST_OTG_HS_HCINTMSK3_CHHM                \ Channel halted mask
$00000004 constant OTG_HS_HOST_OTG_HS_HCINTMSK3_AHBERR              \ AHB error
$00000008 constant OTG_HS_HOST_OTG_HS_HCINTMSK3_STALLM              \ STALL response received interrupt mask
$00000010 constant OTG_HS_HOST_OTG_HS_HCINTMSK3_NAKM                \ NAK response received interrupt mask
$00000020 constant OTG_HS_HOST_OTG_HS_HCINTMSK3_ACKM                \ ACK response received/transmitted interrupt mask
$00000040 constant OTG_HS_HOST_OTG_HS_HCINTMSK3_NYET                \ response received interrupt mask
$00000080 constant OTG_HS_HOST_OTG_HS_HCINTMSK3_TXERRM              \ Transaction error mask
$00000100 constant OTG_HS_HOST_OTG_HS_HCINTMSK3_BBERRM              \ Babble error mask
$00000200 constant OTG_HS_HOST_OTG_HS_HCINTMSK3_FRMORM              \ Frame overrun mask
$00000400 constant OTG_HS_HOST_OTG_HS_HCINTMSK3_DTERRM              \ Data toggle error mask


\
\ @brief OTG_HS host channel-3 transfer size register
\ Address offset: 0x170
\ Reset value: 0x00000000
\

$0007ffff constant OTG_HS_HOST_OTG_HS_HCTSIZ3_XFRSIZ                \ Transfer size
$1ff80000 constant OTG_HS_HOST_OTG_HS_HCTSIZ3_PKTCNT                \ Packet count
$60000000 constant OTG_HS_HOST_OTG_HS_HCTSIZ3_DPID                  \ Data PID


\
\ @brief OTG_HS host channel-3 DMA address register
\ Address offset: 0x174
\ Reset value: 0x00000000
\

$00000000 constant OTG_HS_HOST_OTG_HS_HCDMA3_DMAADDR                \ DMA address


\
\ @brief OTG_HS host channel-4 characteristics register
\ Address offset: 0x180
\ Reset value: 0x00000000
\

$000007ff constant OTG_HS_HOST_OTG_HS_HCCHAR4_MPSIZ                 \ Maximum packet size
$00007800 constant OTG_HS_HOST_OTG_HS_HCCHAR4_EPNUM                 \ Endpoint number
$00008000 constant OTG_HS_HOST_OTG_HS_HCCHAR4_EPDIR                 \ Endpoint direction
$00020000 constant OTG_HS_HOST_OTG_HS_HCCHAR4_LSDEV                 \ Low-speed device
$000c0000 constant OTG_HS_HOST_OTG_HS_HCCHAR4_EPTYP                 \ Endpoint type
$00300000 constant OTG_HS_HOST_OTG_HS_HCCHAR4_MC                    \ Multi Count (MC) / Error Count (EC)
$1fc00000 constant OTG_HS_HOST_OTG_HS_HCCHAR4_DAD                   \ Device address
$20000000 constant OTG_HS_HOST_OTG_HS_HCCHAR4_ODDFRM                \ Odd frame
$40000000 constant OTG_HS_HOST_OTG_HS_HCCHAR4_CHDIS                 \ Channel disable
$80000000 constant OTG_HS_HOST_OTG_HS_HCCHAR4_CHENA                 \ Channel enable


\
\ @brief OTG_HS host channel-4 split control register
\ Address offset: 0x184
\ Reset value: 0x00000000
\

$0000007f constant OTG_HS_HOST_OTG_HS_HCSPLT4_PRTADDR               \ Port address
$00003f80 constant OTG_HS_HOST_OTG_HS_HCSPLT4_HUBADDR               \ Hub address
$0000c000 constant OTG_HS_HOST_OTG_HS_HCSPLT4_XACTPOS               \ XACTPOS
$00010000 constant OTG_HS_HOST_OTG_HS_HCSPLT4_COMPLSPLT             \ Do complete split
$80000000 constant OTG_HS_HOST_OTG_HS_HCSPLT4_SPLITEN               \ Split enable


\
\ @brief OTG_HS host channel-4 interrupt register
\ Address offset: 0x188
\ Reset value: 0x00000000
\

$00000001 constant OTG_HS_HOST_OTG_HS_HCINT4_XFRC                   \ Transfer completed
$00000002 constant OTG_HS_HOST_OTG_HS_HCINT4_CHH                    \ Channel halted
$00000004 constant OTG_HS_HOST_OTG_HS_HCINT4_AHBERR                 \ AHB error
$00000008 constant OTG_HS_HOST_OTG_HS_HCINT4_STALL                  \ STALL response received interrupt
$00000010 constant OTG_HS_HOST_OTG_HS_HCINT4_NAK                    \ NAK response received interrupt
$00000020 constant OTG_HS_HOST_OTG_HS_HCINT4_ACK                    \ ACK response received/transmitted interrupt
$00000040 constant OTG_HS_HOST_OTG_HS_HCINT4_NYET                   \ Response received interrupt
$00000080 constant OTG_HS_HOST_OTG_HS_HCINT4_TXERR                  \ Transaction error
$00000100 constant OTG_HS_HOST_OTG_HS_HCINT4_BBERR                  \ Babble error
$00000200 constant OTG_HS_HOST_OTG_HS_HCINT4_FRMOR                  \ Frame overrun
$00000400 constant OTG_HS_HOST_OTG_HS_HCINT4_DTERR                  \ Data toggle error


\
\ @brief OTG_HS host channel-4 interrupt mask register
\ Address offset: 0x18C
\ Reset value: 0x00000000
\

$00000001 constant OTG_HS_HOST_OTG_HS_HCINTMSK4_XFRCM               \ Transfer completed mask
$00000002 constant OTG_HS_HOST_OTG_HS_HCINTMSK4_CHHM                \ Channel halted mask
$00000004 constant OTG_HS_HOST_OTG_HS_HCINTMSK4_AHBERR              \ AHB error
$00000008 constant OTG_HS_HOST_OTG_HS_HCINTMSK4_STALLM              \ STALL response received interrupt mask
$00000010 constant OTG_HS_HOST_OTG_HS_HCINTMSK4_NAKM                \ NAK response received interrupt mask
$00000020 constant OTG_HS_HOST_OTG_HS_HCINTMSK4_ACKM                \ ACK response received/transmitted interrupt mask
$00000040 constant OTG_HS_HOST_OTG_HS_HCINTMSK4_NYET                \ response received interrupt mask
$00000080 constant OTG_HS_HOST_OTG_HS_HCINTMSK4_TXERRM              \ Transaction error mask
$00000100 constant OTG_HS_HOST_OTG_HS_HCINTMSK4_BBERRM              \ Babble error mask
$00000200 constant OTG_HS_HOST_OTG_HS_HCINTMSK4_FRMORM              \ Frame overrun mask
$00000400 constant OTG_HS_HOST_OTG_HS_HCINTMSK4_DTERRM              \ Data toggle error mask


\
\ @brief OTG_HS host channel-4 transfer size register
\ Address offset: 0x190
\ Reset value: 0x00000000
\

$0007ffff constant OTG_HS_HOST_OTG_HS_HCTSIZ4_XFRSIZ                \ Transfer size
$1ff80000 constant OTG_HS_HOST_OTG_HS_HCTSIZ4_PKTCNT                \ Packet count
$60000000 constant OTG_HS_HOST_OTG_HS_HCTSIZ4_DPID                  \ Data PID


\
\ @brief OTG_HS host channel-4 DMA address register
\ Address offset: 0x194
\ Reset value: 0x00000000
\

$00000000 constant OTG_HS_HOST_OTG_HS_HCDMA4_DMAADDR                \ DMA address


\
\ @brief OTG_HS host channel-5 characteristics register
\ Address offset: 0x1A0
\ Reset value: 0x00000000
\

$000007ff constant OTG_HS_HOST_OTG_HS_HCCHAR5_MPSIZ                 \ Maximum packet size
$00007800 constant OTG_HS_HOST_OTG_HS_HCCHAR5_EPNUM                 \ Endpoint number
$00008000 constant OTG_HS_HOST_OTG_HS_HCCHAR5_EPDIR                 \ Endpoint direction
$00020000 constant OTG_HS_HOST_OTG_HS_HCCHAR5_LSDEV                 \ Low-speed device
$000c0000 constant OTG_HS_HOST_OTG_HS_HCCHAR5_EPTYP                 \ Endpoint type
$00300000 constant OTG_HS_HOST_OTG_HS_HCCHAR5_MC                    \ Multi Count (MC) / Error Count (EC)
$1fc00000 constant OTG_HS_HOST_OTG_HS_HCCHAR5_DAD                   \ Device address
$20000000 constant OTG_HS_HOST_OTG_HS_HCCHAR5_ODDFRM                \ Odd frame
$40000000 constant OTG_HS_HOST_OTG_HS_HCCHAR5_CHDIS                 \ Channel disable
$80000000 constant OTG_HS_HOST_OTG_HS_HCCHAR5_CHENA                 \ Channel enable


\
\ @brief OTG_HS host channel-5 split control register
\ Address offset: 0x1A4
\ Reset value: 0x00000000
\

$0000007f constant OTG_HS_HOST_OTG_HS_HCSPLT5_PRTADDR               \ Port address
$00003f80 constant OTG_HS_HOST_OTG_HS_HCSPLT5_HUBADDR               \ Hub address
$0000c000 constant OTG_HS_HOST_OTG_HS_HCSPLT5_XACTPOS               \ XACTPOS
$00010000 constant OTG_HS_HOST_OTG_HS_HCSPLT5_COMPLSPLT             \ Do complete split
$80000000 constant OTG_HS_HOST_OTG_HS_HCSPLT5_SPLITEN               \ Split enable


\
\ @brief OTG_HS host channel-5 interrupt register
\ Address offset: 0x1A8
\ Reset value: 0x00000000
\

$00000001 constant OTG_HS_HOST_OTG_HS_HCINT5_XFRC                   \ Transfer completed
$00000002 constant OTG_HS_HOST_OTG_HS_HCINT5_CHH                    \ Channel halted
$00000004 constant OTG_HS_HOST_OTG_HS_HCINT5_AHBERR                 \ AHB error
$00000008 constant OTG_HS_HOST_OTG_HS_HCINT5_STALL                  \ STALL response received interrupt
$00000010 constant OTG_HS_HOST_OTG_HS_HCINT5_NAK                    \ NAK response received interrupt
$00000020 constant OTG_HS_HOST_OTG_HS_HCINT5_ACK                    \ ACK response received/transmitted interrupt
$00000040 constant OTG_HS_HOST_OTG_HS_HCINT5_NYET                   \ Response received interrupt
$00000080 constant OTG_HS_HOST_OTG_HS_HCINT5_TXERR                  \ Transaction error
$00000100 constant OTG_HS_HOST_OTG_HS_HCINT5_BBERR                  \ Babble error
$00000200 constant OTG_HS_HOST_OTG_HS_HCINT5_FRMOR                  \ Frame overrun
$00000400 constant OTG_HS_HOST_OTG_HS_HCINT5_DTERR                  \ Data toggle error


\
\ @brief OTG_HS host channel-5 interrupt mask register
\ Address offset: 0x1AC
\ Reset value: 0x00000000
\

$00000001 constant OTG_HS_HOST_OTG_HS_HCINTMSK5_XFRCM               \ Transfer completed mask
$00000002 constant OTG_HS_HOST_OTG_HS_HCINTMSK5_CHHM                \ Channel halted mask
$00000004 constant OTG_HS_HOST_OTG_HS_HCINTMSK5_AHBERR              \ AHB error
$00000008 constant OTG_HS_HOST_OTG_HS_HCINTMSK5_STALLM              \ STALL response received interrupt mask
$00000010 constant OTG_HS_HOST_OTG_HS_HCINTMSK5_NAKM                \ NAK response received interrupt mask
$00000020 constant OTG_HS_HOST_OTG_HS_HCINTMSK5_ACKM                \ ACK response received/transmitted interrupt mask
$00000040 constant OTG_HS_HOST_OTG_HS_HCINTMSK5_NYET                \ response received interrupt mask
$00000080 constant OTG_HS_HOST_OTG_HS_HCINTMSK5_TXERRM              \ Transaction error mask
$00000100 constant OTG_HS_HOST_OTG_HS_HCINTMSK5_BBERRM              \ Babble error mask
$00000200 constant OTG_HS_HOST_OTG_HS_HCINTMSK5_FRMORM              \ Frame overrun mask
$00000400 constant OTG_HS_HOST_OTG_HS_HCINTMSK5_DTERRM              \ Data toggle error mask


\
\ @brief OTG_HS host channel-5 transfer size register
\ Address offset: 0x1B0
\ Reset value: 0x00000000
\

$0007ffff constant OTG_HS_HOST_OTG_HS_HCTSIZ5_XFRSIZ                \ Transfer size
$1ff80000 constant OTG_HS_HOST_OTG_HS_HCTSIZ5_PKTCNT                \ Packet count
$60000000 constant OTG_HS_HOST_OTG_HS_HCTSIZ5_DPID                  \ Data PID


\
\ @brief OTG_HS host channel-5 DMA address register
\ Address offset: 0x1B4
\ Reset value: 0x00000000
\

$00000000 constant OTG_HS_HOST_OTG_HS_HCDMA5_DMAADDR                \ DMA address


\
\ @brief OTG_HS host channel-6 characteristics register
\ Address offset: 0x1C0
\ Reset value: 0x00000000
\

$000007ff constant OTG_HS_HOST_OTG_HS_HCCHAR6_MPSIZ                 \ Maximum packet size
$00007800 constant OTG_HS_HOST_OTG_HS_HCCHAR6_EPNUM                 \ Endpoint number
$00008000 constant OTG_HS_HOST_OTG_HS_HCCHAR6_EPDIR                 \ Endpoint direction
$00020000 constant OTG_HS_HOST_OTG_HS_HCCHAR6_LSDEV                 \ Low-speed device
$000c0000 constant OTG_HS_HOST_OTG_HS_HCCHAR6_EPTYP                 \ Endpoint type
$00300000 constant OTG_HS_HOST_OTG_HS_HCCHAR6_MC                    \ Multi Count (MC) / Error Count (EC)
$1fc00000 constant OTG_HS_HOST_OTG_HS_HCCHAR6_DAD                   \ Device address
$20000000 constant OTG_HS_HOST_OTG_HS_HCCHAR6_ODDFRM                \ Odd frame
$40000000 constant OTG_HS_HOST_OTG_HS_HCCHAR6_CHDIS                 \ Channel disable
$80000000 constant OTG_HS_HOST_OTG_HS_HCCHAR6_CHENA                 \ Channel enable


\
\ @brief OTG_HS host channel-6 split control register
\ Address offset: 0x1C4
\ Reset value: 0x00000000
\

$0000007f constant OTG_HS_HOST_OTG_HS_HCSPLT6_PRTADDR               \ Port address
$00003f80 constant OTG_HS_HOST_OTG_HS_HCSPLT6_HUBADDR               \ Hub address
$0000c000 constant OTG_HS_HOST_OTG_HS_HCSPLT6_XACTPOS               \ XACTPOS
$00010000 constant OTG_HS_HOST_OTG_HS_HCSPLT6_COMPLSPLT             \ Do complete split
$80000000 constant OTG_HS_HOST_OTG_HS_HCSPLT6_SPLITEN               \ Split enable


\
\ @brief OTG_HS host channel-6 interrupt register
\ Address offset: 0x1C8
\ Reset value: 0x00000000
\

$00000001 constant OTG_HS_HOST_OTG_HS_HCINT6_XFRC                   \ Transfer completed
$00000002 constant OTG_HS_HOST_OTG_HS_HCINT6_CHH                    \ Channel halted
$00000004 constant OTG_HS_HOST_OTG_HS_HCINT6_AHBERR                 \ AHB error
$00000008 constant OTG_HS_HOST_OTG_HS_HCINT6_STALL                  \ STALL response received interrupt
$00000010 constant OTG_HS_HOST_OTG_HS_HCINT6_NAK                    \ NAK response received interrupt
$00000020 constant OTG_HS_HOST_OTG_HS_HCINT6_ACK                    \ ACK response received/transmitted interrupt
$00000040 constant OTG_HS_HOST_OTG_HS_HCINT6_NYET                   \ Response received interrupt
$00000080 constant OTG_HS_HOST_OTG_HS_HCINT6_TXERR                  \ Transaction error
$00000100 constant OTG_HS_HOST_OTG_HS_HCINT6_BBERR                  \ Babble error
$00000200 constant OTG_HS_HOST_OTG_HS_HCINT6_FRMOR                  \ Frame overrun
$00000400 constant OTG_HS_HOST_OTG_HS_HCINT6_DTERR                  \ Data toggle error


\
\ @brief OTG_HS host channel-6 interrupt mask register
\ Address offset: 0x1CC
\ Reset value: 0x00000000
\

$00000001 constant OTG_HS_HOST_OTG_HS_HCINTMSK6_XFRCM               \ Transfer completed mask
$00000002 constant OTG_HS_HOST_OTG_HS_HCINTMSK6_CHHM                \ Channel halted mask
$00000004 constant OTG_HS_HOST_OTG_HS_HCINTMSK6_AHBERR              \ AHB error
$00000008 constant OTG_HS_HOST_OTG_HS_HCINTMSK6_STALLM              \ STALL response received interrupt mask
$00000010 constant OTG_HS_HOST_OTG_HS_HCINTMSK6_NAKM                \ NAK response received interrupt mask
$00000020 constant OTG_HS_HOST_OTG_HS_HCINTMSK6_ACKM                \ ACK response received/transmitted interrupt mask
$00000040 constant OTG_HS_HOST_OTG_HS_HCINTMSK6_NYET                \ response received interrupt mask
$00000080 constant OTG_HS_HOST_OTG_HS_HCINTMSK6_TXERRM              \ Transaction error mask
$00000100 constant OTG_HS_HOST_OTG_HS_HCINTMSK6_BBERRM              \ Babble error mask
$00000200 constant OTG_HS_HOST_OTG_HS_HCINTMSK6_FRMORM              \ Frame overrun mask
$00000400 constant OTG_HS_HOST_OTG_HS_HCINTMSK6_DTERRM              \ Data toggle error mask


\
\ @brief OTG_HS host channel-6 transfer size register
\ Address offset: 0x1D0
\ Reset value: 0x00000000
\

$0007ffff constant OTG_HS_HOST_OTG_HS_HCTSIZ6_XFRSIZ                \ Transfer size
$1ff80000 constant OTG_HS_HOST_OTG_HS_HCTSIZ6_PKTCNT                \ Packet count
$60000000 constant OTG_HS_HOST_OTG_HS_HCTSIZ6_DPID                  \ Data PID


\
\ @brief OTG_HS host channel-6 DMA address register
\ Address offset: 0x1D4
\ Reset value: 0x00000000
\

$00000000 constant OTG_HS_HOST_OTG_HS_HCDMA6_DMAADDR                \ DMA address


\
\ @brief OTG_HS host channel-7 characteristics register
\ Address offset: 0x1E0
\ Reset value: 0x00000000
\

$000007ff constant OTG_HS_HOST_OTG_HS_HCCHAR7_MPSIZ                 \ Maximum packet size
$00007800 constant OTG_HS_HOST_OTG_HS_HCCHAR7_EPNUM                 \ Endpoint number
$00008000 constant OTG_HS_HOST_OTG_HS_HCCHAR7_EPDIR                 \ Endpoint direction
$00020000 constant OTG_HS_HOST_OTG_HS_HCCHAR7_LSDEV                 \ Low-speed device
$000c0000 constant OTG_HS_HOST_OTG_HS_HCCHAR7_EPTYP                 \ Endpoint type
$00300000 constant OTG_HS_HOST_OTG_HS_HCCHAR7_MC                    \ Multi Count (MC) / Error Count (EC)
$1fc00000 constant OTG_HS_HOST_OTG_HS_HCCHAR7_DAD                   \ Device address
$20000000 constant OTG_HS_HOST_OTG_HS_HCCHAR7_ODDFRM                \ Odd frame
$40000000 constant OTG_HS_HOST_OTG_HS_HCCHAR7_CHDIS                 \ Channel disable
$80000000 constant OTG_HS_HOST_OTG_HS_HCCHAR7_CHENA                 \ Channel enable


\
\ @brief OTG_HS host channel-7 split control register
\ Address offset: 0x1E4
\ Reset value: 0x00000000
\

$0000007f constant OTG_HS_HOST_OTG_HS_HCSPLT7_PRTADDR               \ Port address
$00003f80 constant OTG_HS_HOST_OTG_HS_HCSPLT7_HUBADDR               \ Hub address
$0000c000 constant OTG_HS_HOST_OTG_HS_HCSPLT7_XACTPOS               \ XACTPOS
$00010000 constant OTG_HS_HOST_OTG_HS_HCSPLT7_COMPLSPLT             \ Do complete split
$80000000 constant OTG_HS_HOST_OTG_HS_HCSPLT7_SPLITEN               \ Split enable


\
\ @brief OTG_HS host channel-7 interrupt register
\ Address offset: 0x1E8
\ Reset value: 0x00000000
\

$00000001 constant OTG_HS_HOST_OTG_HS_HCINT7_XFRC                   \ Transfer completed
$00000002 constant OTG_HS_HOST_OTG_HS_HCINT7_CHH                    \ Channel halted
$00000004 constant OTG_HS_HOST_OTG_HS_HCINT7_AHBERR                 \ AHB error
$00000008 constant OTG_HS_HOST_OTG_HS_HCINT7_STALL                  \ STALL response received interrupt
$00000010 constant OTG_HS_HOST_OTG_HS_HCINT7_NAK                    \ NAK response received interrupt
$00000020 constant OTG_HS_HOST_OTG_HS_HCINT7_ACK                    \ ACK response received/transmitted interrupt
$00000040 constant OTG_HS_HOST_OTG_HS_HCINT7_NYET                   \ Response received interrupt
$00000080 constant OTG_HS_HOST_OTG_HS_HCINT7_TXERR                  \ Transaction error
$00000100 constant OTG_HS_HOST_OTG_HS_HCINT7_BBERR                  \ Babble error
$00000200 constant OTG_HS_HOST_OTG_HS_HCINT7_FRMOR                  \ Frame overrun
$00000400 constant OTG_HS_HOST_OTG_HS_HCINT7_DTERR                  \ Data toggle error


\
\ @brief OTG_HS host channel-7 interrupt mask register
\ Address offset: 0x1EC
\ Reset value: 0x00000000
\

$00000001 constant OTG_HS_HOST_OTG_HS_HCINTMSK7_XFRCM               \ Transfer completed mask
$00000002 constant OTG_HS_HOST_OTG_HS_HCINTMSK7_CHHM                \ Channel halted mask
$00000004 constant OTG_HS_HOST_OTG_HS_HCINTMSK7_AHBERR              \ AHB error
$00000008 constant OTG_HS_HOST_OTG_HS_HCINTMSK7_STALLM              \ STALL response received interrupt mask
$00000010 constant OTG_HS_HOST_OTG_HS_HCINTMSK7_NAKM                \ NAK response received interrupt mask
$00000020 constant OTG_HS_HOST_OTG_HS_HCINTMSK7_ACKM                \ ACK response received/transmitted interrupt mask
$00000040 constant OTG_HS_HOST_OTG_HS_HCINTMSK7_NYET                \ response received interrupt mask
$00000080 constant OTG_HS_HOST_OTG_HS_HCINTMSK7_TXERRM              \ Transaction error mask
$00000100 constant OTG_HS_HOST_OTG_HS_HCINTMSK7_BBERRM              \ Babble error mask
$00000200 constant OTG_HS_HOST_OTG_HS_HCINTMSK7_FRMORM              \ Frame overrun mask
$00000400 constant OTG_HS_HOST_OTG_HS_HCINTMSK7_DTERRM              \ Data toggle error mask


\
\ @brief OTG_HS host channel-7 transfer size register
\ Address offset: 0x1F0
\ Reset value: 0x00000000
\

$0007ffff constant OTG_HS_HOST_OTG_HS_HCTSIZ7_XFRSIZ                \ Transfer size
$1ff80000 constant OTG_HS_HOST_OTG_HS_HCTSIZ7_PKTCNT                \ Packet count
$60000000 constant OTG_HS_HOST_OTG_HS_HCTSIZ7_DPID                  \ Data PID


\
\ @brief OTG_HS host channel-7 DMA address register
\ Address offset: 0x1F4
\ Reset value: 0x00000000
\

$00000000 constant OTG_HS_HOST_OTG_HS_HCDMA7_DMAADDR                \ DMA address


\
\ @brief OTG_HS host channel-8 characteristics register
\ Address offset: 0x200
\ Reset value: 0x00000000
\

$000007ff constant OTG_HS_HOST_OTG_HS_HCCHAR8_MPSIZ                 \ Maximum packet size
$00007800 constant OTG_HS_HOST_OTG_HS_HCCHAR8_EPNUM                 \ Endpoint number
$00008000 constant OTG_HS_HOST_OTG_HS_HCCHAR8_EPDIR                 \ Endpoint direction
$00020000 constant OTG_HS_HOST_OTG_HS_HCCHAR8_LSDEV                 \ Low-speed device
$000c0000 constant OTG_HS_HOST_OTG_HS_HCCHAR8_EPTYP                 \ Endpoint type
$00300000 constant OTG_HS_HOST_OTG_HS_HCCHAR8_MC                    \ Multi Count (MC) / Error Count (EC)
$1fc00000 constant OTG_HS_HOST_OTG_HS_HCCHAR8_DAD                   \ Device address
$20000000 constant OTG_HS_HOST_OTG_HS_HCCHAR8_ODDFRM                \ Odd frame
$40000000 constant OTG_HS_HOST_OTG_HS_HCCHAR8_CHDIS                 \ Channel disable
$80000000 constant OTG_HS_HOST_OTG_HS_HCCHAR8_CHENA                 \ Channel enable


\
\ @brief OTG_HS host channel-8 split control register
\ Address offset: 0x204
\ Reset value: 0x00000000
\

$0000007f constant OTG_HS_HOST_OTG_HS_HCSPLT8_PRTADDR               \ Port address
$00003f80 constant OTG_HS_HOST_OTG_HS_HCSPLT8_HUBADDR               \ Hub address
$0000c000 constant OTG_HS_HOST_OTG_HS_HCSPLT8_XACTPOS               \ XACTPOS
$00010000 constant OTG_HS_HOST_OTG_HS_HCSPLT8_COMPLSPLT             \ Do complete split
$80000000 constant OTG_HS_HOST_OTG_HS_HCSPLT8_SPLITEN               \ Split enable


\
\ @brief OTG_HS host channel-8 interrupt register
\ Address offset: 0x208
\ Reset value: 0x00000000
\

$00000001 constant OTG_HS_HOST_OTG_HS_HCINT8_XFRC                   \ Transfer completed
$00000002 constant OTG_HS_HOST_OTG_HS_HCINT8_CHH                    \ Channel halted
$00000004 constant OTG_HS_HOST_OTG_HS_HCINT8_AHBERR                 \ AHB error
$00000008 constant OTG_HS_HOST_OTG_HS_HCINT8_STALL                  \ STALL response received interrupt
$00000010 constant OTG_HS_HOST_OTG_HS_HCINT8_NAK                    \ NAK response received interrupt
$00000020 constant OTG_HS_HOST_OTG_HS_HCINT8_ACK                    \ ACK response received/transmitted interrupt
$00000040 constant OTG_HS_HOST_OTG_HS_HCINT8_NYET                   \ Response received interrupt
$00000080 constant OTG_HS_HOST_OTG_HS_HCINT8_TXERR                  \ Transaction error
$00000100 constant OTG_HS_HOST_OTG_HS_HCINT8_BBERR                  \ Babble error
$00000200 constant OTG_HS_HOST_OTG_HS_HCINT8_FRMOR                  \ Frame overrun
$00000400 constant OTG_HS_HOST_OTG_HS_HCINT8_DTERR                  \ Data toggle error


\
\ @brief OTG_HS host channel-8 interrupt mask register
\ Address offset: 0x20C
\ Reset value: 0x00000000
\

$00000001 constant OTG_HS_HOST_OTG_HS_HCINTMSK8_XFRCM               \ Transfer completed mask
$00000002 constant OTG_HS_HOST_OTG_HS_HCINTMSK8_CHHM                \ Channel halted mask
$00000004 constant OTG_HS_HOST_OTG_HS_HCINTMSK8_AHBERR              \ AHB error
$00000008 constant OTG_HS_HOST_OTG_HS_HCINTMSK8_STALLM              \ STALL response received interrupt mask
$00000010 constant OTG_HS_HOST_OTG_HS_HCINTMSK8_NAKM                \ NAK response received interrupt mask
$00000020 constant OTG_HS_HOST_OTG_HS_HCINTMSK8_ACKM                \ ACK response received/transmitted interrupt mask
$00000040 constant OTG_HS_HOST_OTG_HS_HCINTMSK8_NYET                \ response received interrupt mask
$00000080 constant OTG_HS_HOST_OTG_HS_HCINTMSK8_TXERRM              \ Transaction error mask
$00000100 constant OTG_HS_HOST_OTG_HS_HCINTMSK8_BBERRM              \ Babble error mask
$00000200 constant OTG_HS_HOST_OTG_HS_HCINTMSK8_FRMORM              \ Frame overrun mask
$00000400 constant OTG_HS_HOST_OTG_HS_HCINTMSK8_DTERRM              \ Data toggle error mask


\
\ @brief OTG_HS host channel-8 transfer size register
\ Address offset: 0x210
\ Reset value: 0x00000000
\

$0007ffff constant OTG_HS_HOST_OTG_HS_HCTSIZ8_XFRSIZ                \ Transfer size
$1ff80000 constant OTG_HS_HOST_OTG_HS_HCTSIZ8_PKTCNT                \ Packet count
$60000000 constant OTG_HS_HOST_OTG_HS_HCTSIZ8_DPID                  \ Data PID


\
\ @brief OTG_HS host channel-8 DMA address register
\ Address offset: 0x214
\ Reset value: 0x00000000
\

$00000000 constant OTG_HS_HOST_OTG_HS_HCDMA8_DMAADDR                \ DMA address


\
\ @brief OTG_HS host channel-9 characteristics register
\ Address offset: 0x220
\ Reset value: 0x00000000
\

$000007ff constant OTG_HS_HOST_OTG_HS_HCCHAR9_MPSIZ                 \ Maximum packet size
$00007800 constant OTG_HS_HOST_OTG_HS_HCCHAR9_EPNUM                 \ Endpoint number
$00008000 constant OTG_HS_HOST_OTG_HS_HCCHAR9_EPDIR                 \ Endpoint direction
$00020000 constant OTG_HS_HOST_OTG_HS_HCCHAR9_LSDEV                 \ Low-speed device
$000c0000 constant OTG_HS_HOST_OTG_HS_HCCHAR9_EPTYP                 \ Endpoint type
$00300000 constant OTG_HS_HOST_OTG_HS_HCCHAR9_MC                    \ Multi Count (MC) / Error Count (EC)
$1fc00000 constant OTG_HS_HOST_OTG_HS_HCCHAR9_DAD                   \ Device address
$20000000 constant OTG_HS_HOST_OTG_HS_HCCHAR9_ODDFRM                \ Odd frame
$40000000 constant OTG_HS_HOST_OTG_HS_HCCHAR9_CHDIS                 \ Channel disable
$80000000 constant OTG_HS_HOST_OTG_HS_HCCHAR9_CHENA                 \ Channel enable


\
\ @brief OTG_HS host channel-9 split control register
\ Address offset: 0x224
\ Reset value: 0x00000000
\

$0000007f constant OTG_HS_HOST_OTG_HS_HCSPLT9_PRTADDR               \ Port address
$00003f80 constant OTG_HS_HOST_OTG_HS_HCSPLT9_HUBADDR               \ Hub address
$0000c000 constant OTG_HS_HOST_OTG_HS_HCSPLT9_XACTPOS               \ XACTPOS
$00010000 constant OTG_HS_HOST_OTG_HS_HCSPLT9_COMPLSPLT             \ Do complete split
$80000000 constant OTG_HS_HOST_OTG_HS_HCSPLT9_SPLITEN               \ Split enable


\
\ @brief OTG_HS host channel-9 interrupt register
\ Address offset: 0x228
\ Reset value: 0x00000000
\

$00000001 constant OTG_HS_HOST_OTG_HS_HCINT9_XFRC                   \ Transfer completed
$00000002 constant OTG_HS_HOST_OTG_HS_HCINT9_CHH                    \ Channel halted
$00000004 constant OTG_HS_HOST_OTG_HS_HCINT9_AHBERR                 \ AHB error
$00000008 constant OTG_HS_HOST_OTG_HS_HCINT9_STALL                  \ STALL response received interrupt
$00000010 constant OTG_HS_HOST_OTG_HS_HCINT9_NAK                    \ NAK response received interrupt
$00000020 constant OTG_HS_HOST_OTG_HS_HCINT9_ACK                    \ ACK response received/transmitted interrupt
$00000040 constant OTG_HS_HOST_OTG_HS_HCINT9_NYET                   \ Response received interrupt
$00000080 constant OTG_HS_HOST_OTG_HS_HCINT9_TXERR                  \ Transaction error
$00000100 constant OTG_HS_HOST_OTG_HS_HCINT9_BBERR                  \ Babble error
$00000200 constant OTG_HS_HOST_OTG_HS_HCINT9_FRMOR                  \ Frame overrun
$00000400 constant OTG_HS_HOST_OTG_HS_HCINT9_DTERR                  \ Data toggle error


\
\ @brief OTG_HS host channel-9 interrupt mask register
\ Address offset: 0x22C
\ Reset value: 0x00000000
\

$00000001 constant OTG_HS_HOST_OTG_HS_HCINTMSK9_XFRCM               \ Transfer completed mask
$00000002 constant OTG_HS_HOST_OTG_HS_HCINTMSK9_CHHM                \ Channel halted mask
$00000004 constant OTG_HS_HOST_OTG_HS_HCINTMSK9_AHBERR              \ AHB error
$00000008 constant OTG_HS_HOST_OTG_HS_HCINTMSK9_STALLM              \ STALL response received interrupt mask
$00000010 constant OTG_HS_HOST_OTG_HS_HCINTMSK9_NAKM                \ NAK response received interrupt mask
$00000020 constant OTG_HS_HOST_OTG_HS_HCINTMSK9_ACKM                \ ACK response received/transmitted interrupt mask
$00000040 constant OTG_HS_HOST_OTG_HS_HCINTMSK9_NYET                \ response received interrupt mask
$00000080 constant OTG_HS_HOST_OTG_HS_HCINTMSK9_TXERRM              \ Transaction error mask
$00000100 constant OTG_HS_HOST_OTG_HS_HCINTMSK9_BBERRM              \ Babble error mask
$00000200 constant OTG_HS_HOST_OTG_HS_HCINTMSK9_FRMORM              \ Frame overrun mask
$00000400 constant OTG_HS_HOST_OTG_HS_HCINTMSK9_DTERRM              \ Data toggle error mask


\
\ @brief OTG_HS host channel-9 transfer size register
\ Address offset: 0x230
\ Reset value: 0x00000000
\

$0007ffff constant OTG_HS_HOST_OTG_HS_HCTSIZ9_XFRSIZ                \ Transfer size
$1ff80000 constant OTG_HS_HOST_OTG_HS_HCTSIZ9_PKTCNT                \ Packet count
$60000000 constant OTG_HS_HOST_OTG_HS_HCTSIZ9_DPID                  \ Data PID


\
\ @brief OTG_HS host channel-9 DMA address register
\ Address offset: 0x234
\ Reset value: 0x00000000
\

$00000000 constant OTG_HS_HOST_OTG_HS_HCDMA9_DMAADDR                \ DMA address


\
\ @brief OTG_HS host channel-10 characteristics register
\ Address offset: 0x240
\ Reset value: 0x00000000
\

$000007ff constant OTG_HS_HOST_OTG_HS_HCCHAR10_MPSIZ                \ Maximum packet size
$00007800 constant OTG_HS_HOST_OTG_HS_HCCHAR10_EPNUM                \ Endpoint number
$00008000 constant OTG_HS_HOST_OTG_HS_HCCHAR10_EPDIR                \ Endpoint direction
$00020000 constant OTG_HS_HOST_OTG_HS_HCCHAR10_LSDEV                \ Low-speed device
$000c0000 constant OTG_HS_HOST_OTG_HS_HCCHAR10_EPTYP                \ Endpoint type
$00300000 constant OTG_HS_HOST_OTG_HS_HCCHAR10_MC                   \ Multi Count (MC) / Error Count (EC)
$1fc00000 constant OTG_HS_HOST_OTG_HS_HCCHAR10_DAD                  \ Device address
$20000000 constant OTG_HS_HOST_OTG_HS_HCCHAR10_ODDFRM               \ Odd frame
$40000000 constant OTG_HS_HOST_OTG_HS_HCCHAR10_CHDIS                \ Channel disable
$80000000 constant OTG_HS_HOST_OTG_HS_HCCHAR10_CHENA                \ Channel enable


\
\ @brief OTG_HS host channel-10 split control register
\ Address offset: 0x244
\ Reset value: 0x00000000
\

$0000007f constant OTG_HS_HOST_OTG_HS_HCSPLT10_PRTADDR              \ Port address
$00003f80 constant OTG_HS_HOST_OTG_HS_HCSPLT10_HUBADDR              \ Hub address
$0000c000 constant OTG_HS_HOST_OTG_HS_HCSPLT10_XACTPOS              \ XACTPOS
$00010000 constant OTG_HS_HOST_OTG_HS_HCSPLT10_COMPLSPLT            \ Do complete split
$80000000 constant OTG_HS_HOST_OTG_HS_HCSPLT10_SPLITEN              \ Split enable


\
\ @brief OTG_HS host channel-10 interrupt register
\ Address offset: 0x248
\ Reset value: 0x00000000
\

$00000001 constant OTG_HS_HOST_OTG_HS_HCINT10_XFRC                  \ Transfer completed
$00000002 constant OTG_HS_HOST_OTG_HS_HCINT10_CHH                   \ Channel halted
$00000004 constant OTG_HS_HOST_OTG_HS_HCINT10_AHBERR                \ AHB error
$00000008 constant OTG_HS_HOST_OTG_HS_HCINT10_STALL                 \ STALL response received interrupt
$00000010 constant OTG_HS_HOST_OTG_HS_HCINT10_NAK                   \ NAK response received interrupt
$00000020 constant OTG_HS_HOST_OTG_HS_HCINT10_ACK                   \ ACK response received/transmitted interrupt
$00000040 constant OTG_HS_HOST_OTG_HS_HCINT10_NYET                  \ Response received interrupt
$00000080 constant OTG_HS_HOST_OTG_HS_HCINT10_TXERR                 \ Transaction error
$00000100 constant OTG_HS_HOST_OTG_HS_HCINT10_BBERR                 \ Babble error
$00000200 constant OTG_HS_HOST_OTG_HS_HCINT10_FRMOR                 \ Frame overrun
$00000400 constant OTG_HS_HOST_OTG_HS_HCINT10_DTERR                 \ Data toggle error


\
\ @brief OTG_HS host channel-10 interrupt mask register
\ Address offset: 0x24C
\ Reset value: 0x00000000
\

$00000001 constant OTG_HS_HOST_OTG_HS_HCINTMSK10_XFRCM              \ Transfer completed mask
$00000002 constant OTG_HS_HOST_OTG_HS_HCINTMSK10_CHHM               \ Channel halted mask
$00000004 constant OTG_HS_HOST_OTG_HS_HCINTMSK10_AHBERR             \ AHB error
$00000008 constant OTG_HS_HOST_OTG_HS_HCINTMSK10_STALLM             \ STALL response received interrupt mask
$00000010 constant OTG_HS_HOST_OTG_HS_HCINTMSK10_NAKM               \ NAK response received interrupt mask
$00000020 constant OTG_HS_HOST_OTG_HS_HCINTMSK10_ACKM               \ ACK response received/transmitted interrupt mask
$00000040 constant OTG_HS_HOST_OTG_HS_HCINTMSK10_NYET               \ response received interrupt mask
$00000080 constant OTG_HS_HOST_OTG_HS_HCINTMSK10_TXERRM             \ Transaction error mask
$00000100 constant OTG_HS_HOST_OTG_HS_HCINTMSK10_BBERRM             \ Babble error mask
$00000200 constant OTG_HS_HOST_OTG_HS_HCINTMSK10_FRMORM             \ Frame overrun mask
$00000400 constant OTG_HS_HOST_OTG_HS_HCINTMSK10_DTERRM             \ Data toggle error mask


\
\ @brief OTG_HS host channel-10 transfer size register
\ Address offset: 0x250
\ Reset value: 0x00000000
\

$0007ffff constant OTG_HS_HOST_OTG_HS_HCTSIZ10_XFRSIZ               \ Transfer size
$1ff80000 constant OTG_HS_HOST_OTG_HS_HCTSIZ10_PKTCNT               \ Packet count
$60000000 constant OTG_HS_HOST_OTG_HS_HCTSIZ10_DPID                 \ Data PID


\
\ @brief OTG_HS host channel-10 DMA address register
\ Address offset: 0x254
\ Reset value: 0x00000000
\

$00000000 constant OTG_HS_HOST_OTG_HS_HCDMA10_DMAADDR               \ DMA address


\
\ @brief OTG_HS host channel-11 characteristics register
\ Address offset: 0x260
\ Reset value: 0x00000000
\

$000007ff constant OTG_HS_HOST_OTG_HS_HCCHAR11_MPSIZ                \ Maximum packet size
$00007800 constant OTG_HS_HOST_OTG_HS_HCCHAR11_EPNUM                \ Endpoint number
$00008000 constant OTG_HS_HOST_OTG_HS_HCCHAR11_EPDIR                \ Endpoint direction
$00020000 constant OTG_HS_HOST_OTG_HS_HCCHAR11_LSDEV                \ Low-speed device
$000c0000 constant OTG_HS_HOST_OTG_HS_HCCHAR11_EPTYP                \ Endpoint type
$00300000 constant OTG_HS_HOST_OTG_HS_HCCHAR11_MC                   \ Multi Count (MC) / Error Count (EC)
$1fc00000 constant OTG_HS_HOST_OTG_HS_HCCHAR11_DAD                  \ Device address
$20000000 constant OTG_HS_HOST_OTG_HS_HCCHAR11_ODDFRM               \ Odd frame
$40000000 constant OTG_HS_HOST_OTG_HS_HCCHAR11_CHDIS                \ Channel disable
$80000000 constant OTG_HS_HOST_OTG_HS_HCCHAR11_CHENA                \ Channel enable


\
\ @brief OTG_HS host channel-11 split control register
\ Address offset: 0x264
\ Reset value: 0x00000000
\

$0000007f constant OTG_HS_HOST_OTG_HS_HCSPLT11_PRTADDR              \ Port address
$00003f80 constant OTG_HS_HOST_OTG_HS_HCSPLT11_HUBADDR              \ Hub address
$0000c000 constant OTG_HS_HOST_OTG_HS_HCSPLT11_XACTPOS              \ XACTPOS
$00010000 constant OTG_HS_HOST_OTG_HS_HCSPLT11_COMPLSPLT            \ Do complete split
$80000000 constant OTG_HS_HOST_OTG_HS_HCSPLT11_SPLITEN              \ Split enable


\
\ @brief OTG_HS host channel-11 interrupt register
\ Address offset: 0x268
\ Reset value: 0x00000000
\

$00000001 constant OTG_HS_HOST_OTG_HS_HCINT11_XFRC                  \ Transfer completed
$00000002 constant OTG_HS_HOST_OTG_HS_HCINT11_CHH                   \ Channel halted
$00000004 constant OTG_HS_HOST_OTG_HS_HCINT11_AHBERR                \ AHB error
$00000008 constant OTG_HS_HOST_OTG_HS_HCINT11_STALL                 \ STALL response received interrupt
$00000010 constant OTG_HS_HOST_OTG_HS_HCINT11_NAK                   \ NAK response received interrupt
$00000020 constant OTG_HS_HOST_OTG_HS_HCINT11_ACK                   \ ACK response received/transmitted interrupt
$00000040 constant OTG_HS_HOST_OTG_HS_HCINT11_NYET                  \ Response received interrupt
$00000080 constant OTG_HS_HOST_OTG_HS_HCINT11_TXERR                 \ Transaction error
$00000100 constant OTG_HS_HOST_OTG_HS_HCINT11_BBERR                 \ Babble error
$00000200 constant OTG_HS_HOST_OTG_HS_HCINT11_FRMOR                 \ Frame overrun
$00000400 constant OTG_HS_HOST_OTG_HS_HCINT11_DTERR                 \ Data toggle error


\
\ @brief OTG_HS host channel-11 interrupt mask register
\ Address offset: 0x26C
\ Reset value: 0x00000000
\

$00000001 constant OTG_HS_HOST_OTG_HS_HCINTMSK11_XFRCM              \ Transfer completed mask
$00000002 constant OTG_HS_HOST_OTG_HS_HCINTMSK11_CHHM               \ Channel halted mask
$00000004 constant OTG_HS_HOST_OTG_HS_HCINTMSK11_AHBERR             \ AHB error
$00000008 constant OTG_HS_HOST_OTG_HS_HCINTMSK11_STALLM             \ STALL response received interrupt mask
$00000010 constant OTG_HS_HOST_OTG_HS_HCINTMSK11_NAKM               \ NAK response received interrupt mask
$00000020 constant OTG_HS_HOST_OTG_HS_HCINTMSK11_ACKM               \ ACK response received/transmitted interrupt mask
$00000040 constant OTG_HS_HOST_OTG_HS_HCINTMSK11_NYET               \ response received interrupt mask
$00000080 constant OTG_HS_HOST_OTG_HS_HCINTMSK11_TXERRM             \ Transaction error mask
$00000100 constant OTG_HS_HOST_OTG_HS_HCINTMSK11_BBERRM             \ Babble error mask
$00000200 constant OTG_HS_HOST_OTG_HS_HCINTMSK11_FRMORM             \ Frame overrun mask
$00000400 constant OTG_HS_HOST_OTG_HS_HCINTMSK11_DTERRM             \ Data toggle error mask


\
\ @brief OTG_HS host channel-11 transfer size register
\ Address offset: 0x270
\ Reset value: 0x00000000
\

$0007ffff constant OTG_HS_HOST_OTG_HS_HCTSIZ11_XFRSIZ               \ Transfer size
$1ff80000 constant OTG_HS_HOST_OTG_HS_HCTSIZ11_PKTCNT               \ Packet count
$60000000 constant OTG_HS_HOST_OTG_HS_HCTSIZ11_DPID                 \ Data PID


\
\ @brief OTG_HS host channel-11 DMA address register
\ Address offset: 0x274
\ Reset value: 0x00000000
\

$00000000 constant OTG_HS_HOST_OTG_HS_HCDMA11_DMAADDR               \ DMA address


\
\ @brief USB on the go high speed
\
$40040400 constant OTG_HS_HOST_OTG_HS_HCFG  \ offset: 0x00 : OTG_HS host configuration register
$40040404 constant OTG_HS_HOST_OTG_HS_HFIR  \ offset: 0x04 : OTG_HS Host frame interval register
$40040408 constant OTG_HS_HOST_OTG_HS_HFNUM  \ offset: 0x08 : OTG_HS host frame number/frame time remaining register
$40040410 constant OTG_HS_HOST_OTG_HS_HPTXSTS  \ offset: 0x10 : OTG_HS_Host periodic transmit FIFO/queue status register
$40040414 constant OTG_HS_HOST_OTG_HS_HAINT  \ offset: 0x14 : OTG_HS Host all channels interrupt register
$40040418 constant OTG_HS_HOST_OTG_HS_HAINTMSK  \ offset: 0x18 : OTG_HS host all channels interrupt mask register
$40040440 constant OTG_HS_HOST_OTG_HS_HPRT  \ offset: 0x40 : OTG_HS host port control and status register
$40040500 constant OTG_HS_HOST_OTG_HS_HCCHAR0  \ offset: 0x100 : OTG_HS host channel-0 characteristics register
$40040504 constant OTG_HS_HOST_OTG_HS_HCSPLT0  \ offset: 0x104 : OTG_HS host channel-0 split control register
$40040508 constant OTG_HS_HOST_OTG_HS_HCINT0  \ offset: 0x108 : OTG_HS host channel-11 interrupt register
$4004050c constant OTG_HS_HOST_OTG_HS_HCINTMSK0  \ offset: 0x10C : OTG_HS host channel-11 interrupt mask register
$40040510 constant OTG_HS_HOST_OTG_HS_HCTSIZ0  \ offset: 0x110 : OTG_HS host channel-11 transfer size register
$40040514 constant OTG_HS_HOST_OTG_HS_HCDMA0  \ offset: 0x114 : OTG_HS host channel-0 DMA address register
$40040520 constant OTG_HS_HOST_OTG_HS_HCCHAR1  \ offset: 0x120 : OTG_HS host channel-1 characteristics register
$40040524 constant OTG_HS_HOST_OTG_HS_HCSPLT1  \ offset: 0x124 : OTG_HS host channel-1 split control register
$40040528 constant OTG_HS_HOST_OTG_HS_HCINT1  \ offset: 0x128 : OTG_HS host channel-1 interrupt register
$4004052c constant OTG_HS_HOST_OTG_HS_HCINTMSK1  \ offset: 0x12C : OTG_HS host channel-1 interrupt mask register
$40040530 constant OTG_HS_HOST_OTG_HS_HCTSIZ1  \ offset: 0x130 : OTG_HS host channel-1 transfer size register
$40040534 constant OTG_HS_HOST_OTG_HS_HCDMA1  \ offset: 0x134 : OTG_HS host channel-1 DMA address register
$40040540 constant OTG_HS_HOST_OTG_HS_HCCHAR2  \ offset: 0x140 : OTG_HS host channel-2 characteristics register
$40040544 constant OTG_HS_HOST_OTG_HS_HCSPLT2  \ offset: 0x144 : OTG_HS host channel-2 split control register
$40040548 constant OTG_HS_HOST_OTG_HS_HCINT2  \ offset: 0x148 : OTG_HS host channel-2 interrupt register
$4004054c constant OTG_HS_HOST_OTG_HS_HCINTMSK2  \ offset: 0x14C : OTG_HS host channel-2 interrupt mask register
$40040550 constant OTG_HS_HOST_OTG_HS_HCTSIZ2  \ offset: 0x150 : OTG_HS host channel-2 transfer size register
$40040554 constant OTG_HS_HOST_OTG_HS_HCDMA2  \ offset: 0x154 : OTG_HS host channel-2 DMA address register
$40040560 constant OTG_HS_HOST_OTG_HS_HCCHAR3  \ offset: 0x160 : OTG_HS host channel-3 characteristics register
$40040564 constant OTG_HS_HOST_OTG_HS_HCSPLT3  \ offset: 0x164 : OTG_HS host channel-3 split control register
$40040568 constant OTG_HS_HOST_OTG_HS_HCINT3  \ offset: 0x168 : OTG_HS host channel-3 interrupt register
$4004056c constant OTG_HS_HOST_OTG_HS_HCINTMSK3  \ offset: 0x16C : OTG_HS host channel-3 interrupt mask register
$40040570 constant OTG_HS_HOST_OTG_HS_HCTSIZ3  \ offset: 0x170 : OTG_HS host channel-3 transfer size register
$40040574 constant OTG_HS_HOST_OTG_HS_HCDMA3  \ offset: 0x174 : OTG_HS host channel-3 DMA address register
$40040580 constant OTG_HS_HOST_OTG_HS_HCCHAR4  \ offset: 0x180 : OTG_HS host channel-4 characteristics register
$40040584 constant OTG_HS_HOST_OTG_HS_HCSPLT4  \ offset: 0x184 : OTG_HS host channel-4 split control register
$40040588 constant OTG_HS_HOST_OTG_HS_HCINT4  \ offset: 0x188 : OTG_HS host channel-4 interrupt register
$4004058c constant OTG_HS_HOST_OTG_HS_HCINTMSK4  \ offset: 0x18C : OTG_HS host channel-4 interrupt mask register
$40040590 constant OTG_HS_HOST_OTG_HS_HCTSIZ4  \ offset: 0x190 : OTG_HS host channel-4 transfer size register
$40040594 constant OTG_HS_HOST_OTG_HS_HCDMA4  \ offset: 0x194 : OTG_HS host channel-4 DMA address register
$400405a0 constant OTG_HS_HOST_OTG_HS_HCCHAR5  \ offset: 0x1A0 : OTG_HS host channel-5 characteristics register
$400405a4 constant OTG_HS_HOST_OTG_HS_HCSPLT5  \ offset: 0x1A4 : OTG_HS host channel-5 split control register
$400405a8 constant OTG_HS_HOST_OTG_HS_HCINT5  \ offset: 0x1A8 : OTG_HS host channel-5 interrupt register
$400405ac constant OTG_HS_HOST_OTG_HS_HCINTMSK5  \ offset: 0x1AC : OTG_HS host channel-5 interrupt mask register
$400405b0 constant OTG_HS_HOST_OTG_HS_HCTSIZ5  \ offset: 0x1B0 : OTG_HS host channel-5 transfer size register
$400405b4 constant OTG_HS_HOST_OTG_HS_HCDMA5  \ offset: 0x1B4 : OTG_HS host channel-5 DMA address register
$400405c0 constant OTG_HS_HOST_OTG_HS_HCCHAR6  \ offset: 0x1C0 : OTG_HS host channel-6 characteristics register
$400405c4 constant OTG_HS_HOST_OTG_HS_HCSPLT6  \ offset: 0x1C4 : OTG_HS host channel-6 split control register
$400405c8 constant OTG_HS_HOST_OTG_HS_HCINT6  \ offset: 0x1C8 : OTG_HS host channel-6 interrupt register
$400405cc constant OTG_HS_HOST_OTG_HS_HCINTMSK6  \ offset: 0x1CC : OTG_HS host channel-6 interrupt mask register
$400405d0 constant OTG_HS_HOST_OTG_HS_HCTSIZ6  \ offset: 0x1D0 : OTG_HS host channel-6 transfer size register
$400405d4 constant OTG_HS_HOST_OTG_HS_HCDMA6  \ offset: 0x1D4 : OTG_HS host channel-6 DMA address register
$400405e0 constant OTG_HS_HOST_OTG_HS_HCCHAR7  \ offset: 0x1E0 : OTG_HS host channel-7 characteristics register
$400405e4 constant OTG_HS_HOST_OTG_HS_HCSPLT7  \ offset: 0x1E4 : OTG_HS host channel-7 split control register
$400405e8 constant OTG_HS_HOST_OTG_HS_HCINT7  \ offset: 0x1E8 : OTG_HS host channel-7 interrupt register
$400405ec constant OTG_HS_HOST_OTG_HS_HCINTMSK7  \ offset: 0x1EC : OTG_HS host channel-7 interrupt mask register
$400405f0 constant OTG_HS_HOST_OTG_HS_HCTSIZ7  \ offset: 0x1F0 : OTG_HS host channel-7 transfer size register
$400405f4 constant OTG_HS_HOST_OTG_HS_HCDMA7  \ offset: 0x1F4 : OTG_HS host channel-7 DMA address register
$40040600 constant OTG_HS_HOST_OTG_HS_HCCHAR8  \ offset: 0x200 : OTG_HS host channel-8 characteristics register
$40040604 constant OTG_HS_HOST_OTG_HS_HCSPLT8  \ offset: 0x204 : OTG_HS host channel-8 split control register
$40040608 constant OTG_HS_HOST_OTG_HS_HCINT8  \ offset: 0x208 : OTG_HS host channel-8 interrupt register
$4004060c constant OTG_HS_HOST_OTG_HS_HCINTMSK8  \ offset: 0x20C : OTG_HS host channel-8 interrupt mask register
$40040610 constant OTG_HS_HOST_OTG_HS_HCTSIZ8  \ offset: 0x210 : OTG_HS host channel-8 transfer size register
$40040614 constant OTG_HS_HOST_OTG_HS_HCDMA8  \ offset: 0x214 : OTG_HS host channel-8 DMA address register
$40040620 constant OTG_HS_HOST_OTG_HS_HCCHAR9  \ offset: 0x220 : OTG_HS host channel-9 characteristics register
$40040624 constant OTG_HS_HOST_OTG_HS_HCSPLT9  \ offset: 0x224 : OTG_HS host channel-9 split control register
$40040628 constant OTG_HS_HOST_OTG_HS_HCINT9  \ offset: 0x228 : OTG_HS host channel-9 interrupt register
$4004062c constant OTG_HS_HOST_OTG_HS_HCINTMSK9  \ offset: 0x22C : OTG_HS host channel-9 interrupt mask register
$40040630 constant OTG_HS_HOST_OTG_HS_HCTSIZ9  \ offset: 0x230 : OTG_HS host channel-9 transfer size register
$40040634 constant OTG_HS_HOST_OTG_HS_HCDMA9  \ offset: 0x234 : OTG_HS host channel-9 DMA address register
$40040640 constant OTG_HS_HOST_OTG_HS_HCCHAR10  \ offset: 0x240 : OTG_HS host channel-10 characteristics register
$40040644 constant OTG_HS_HOST_OTG_HS_HCSPLT10  \ offset: 0x244 : OTG_HS host channel-10 split control register
$40040648 constant OTG_HS_HOST_OTG_HS_HCINT10  \ offset: 0x248 : OTG_HS host channel-10 interrupt register
$4004064c constant OTG_HS_HOST_OTG_HS_HCINTMSK10  \ offset: 0x24C : OTG_HS host channel-10 interrupt mask register
$40040650 constant OTG_HS_HOST_OTG_HS_HCTSIZ10  \ offset: 0x250 : OTG_HS host channel-10 transfer size register
$40040654 constant OTG_HS_HOST_OTG_HS_HCDMA10  \ offset: 0x254 : OTG_HS host channel-10 DMA address register
$40040660 constant OTG_HS_HOST_OTG_HS_HCCHAR11  \ offset: 0x260 : OTG_HS host channel-11 characteristics register
$40040664 constant OTG_HS_HOST_OTG_HS_HCSPLT11  \ offset: 0x264 : OTG_HS host channel-11 split control register
$40040668 constant OTG_HS_HOST_OTG_HS_HCINT11  \ offset: 0x268 : OTG_HS host channel-11 interrupt register
$4004066c constant OTG_HS_HOST_OTG_HS_HCINTMSK11  \ offset: 0x26C : OTG_HS host channel-11 interrupt mask register
$40040670 constant OTG_HS_HOST_OTG_HS_HCTSIZ11  \ offset: 0x270 : OTG_HS host channel-11 transfer size register
$40040674 constant OTG_HS_HOST_OTG_HS_HCDMA11  \ offset: 0x274 : OTG_HS host channel-11 DMA address register

