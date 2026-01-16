\
\ @file otg_fs_host.fs
\ @brief USB on the go full speed
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief OTG_FS host configuration register (OTG_FS_HCFG)
\ Address offset: 0x00
\ Reset value: 0x00000000
\

$00000003 constant OTG_FS_HOST_OTG_FS_HCFG_FSLSPCS                  \ FS/LS PHY clock select
$00000004 constant OTG_FS_HOST_OTG_FS_HCFG_FSLSS                    \ FS- and LS-only support


\
\ @brief OTG_FS Host frame interval register
\ Address offset: 0x04
\ Reset value: 0x0000EA60
\

$0000ffff constant OTG_FS_HOST_OTG_FS_HFIR_FRIVL                    \ Frame interval


\
\ @brief OTG_FS host frame number/frame time remaining register (OTG_FS_HFNUM)
\ Address offset: 0x08
\ Reset value: 0x00003FFF
\

$0000ffff constant OTG_FS_HOST_OTG_FS_HFNUM_FRNUM                   \ Frame number
$ffff0000 constant OTG_FS_HOST_OTG_FS_HFNUM_FTREM                   \ Frame time remaining


\
\ @brief OTG_FS_Host periodic transmit FIFO/queue status register (OTG_FS_HPTXSTS)
\ Address offset: 0x10
\ Reset value: 0x00080100
\

$0000ffff constant OTG_FS_HOST_OTG_FS_HPTXSTS_PTXFSAVL              \ Periodic transmit data FIFO space available
$00ff0000 constant OTG_FS_HOST_OTG_FS_HPTXSTS_PTXQSAV               \ Periodic transmit request queue space available
$ff000000 constant OTG_FS_HOST_OTG_FS_HPTXSTS_PTXQTOP               \ Top of the periodic transmit request queue


\
\ @brief OTG_FS Host all channels interrupt register
\ Address offset: 0x14
\ Reset value: 0x00000000
\

$0000ffff constant OTG_FS_HOST_OTG_FS_HAINT_HAINT                   \ Channel interrupts


\
\ @brief OTG_FS host all channels interrupt mask register
\ Address offset: 0x18
\ Reset value: 0x00000000
\

$0000ffff constant OTG_FS_HOST_OTG_FS_HAINTMSK_HAINTM               \ Channel interrupt mask


\
\ @brief OTG_FS host port control and status register (OTG_FS_HPRT)
\ Address offset: 0x40
\ Reset value: 0x00000000
\

$00000001 constant OTG_FS_HOST_OTG_FS_HPRT_PCSTS                    \ Port connect status
$00000002 constant OTG_FS_HOST_OTG_FS_HPRT_PCDET                    \ Port connect detected
$00000004 constant OTG_FS_HOST_OTG_FS_HPRT_PENA                     \ Port enable
$00000008 constant OTG_FS_HOST_OTG_FS_HPRT_PENCHNG                  \ Port enable/disable change
$00000010 constant OTG_FS_HOST_OTG_FS_HPRT_POCA                     \ Port overcurrent active
$00000020 constant OTG_FS_HOST_OTG_FS_HPRT_POCCHNG                  \ Port overcurrent change
$00000040 constant OTG_FS_HOST_OTG_FS_HPRT_PRES                     \ Port resume
$00000080 constant OTG_FS_HOST_OTG_FS_HPRT_PSUSP                    \ Port suspend
$00000100 constant OTG_FS_HOST_OTG_FS_HPRT_PRST                     \ Port reset
$00000c00 constant OTG_FS_HOST_OTG_FS_HPRT_PLSTS                    \ Port line status
$00001000 constant OTG_FS_HOST_OTG_FS_HPRT_PPWR                     \ Port power
$0001e000 constant OTG_FS_HOST_OTG_FS_HPRT_PTCTL                    \ Port test control
$00060000 constant OTG_FS_HOST_OTG_FS_HPRT_PSPD                     \ Port speed


\
\ @brief OTG_FS host channel-0 characteristics register (OTG_FS_HCCHAR0)
\ Address offset: 0x100
\ Reset value: 0x00000000
\

$000007ff constant OTG_FS_HOST_OTG_FS_HCCHAR0_MPSIZ                 \ Maximum packet size
$00007800 constant OTG_FS_HOST_OTG_FS_HCCHAR0_EPNUM                 \ Endpoint number
$00008000 constant OTG_FS_HOST_OTG_FS_HCCHAR0_EPDIR                 \ Endpoint direction
$00020000 constant OTG_FS_HOST_OTG_FS_HCCHAR0_LSDEV                 \ Low-speed device
$000c0000 constant OTG_FS_HOST_OTG_FS_HCCHAR0_EPTYP                 \ Endpoint type
$00300000 constant OTG_FS_HOST_OTG_FS_HCCHAR0_MCNT                  \ Multicount
$1fc00000 constant OTG_FS_HOST_OTG_FS_HCCHAR0_DAD                   \ Device address
$20000000 constant OTG_FS_HOST_OTG_FS_HCCHAR0_ODDFRM                \ Odd frame
$40000000 constant OTG_FS_HOST_OTG_FS_HCCHAR0_CHDIS                 \ Channel disable
$80000000 constant OTG_FS_HOST_OTG_FS_HCCHAR0_CHENA                 \ Channel enable


\
\ @brief OTG_FS host channel-0 interrupt register (OTG_FS_HCINT0)
\ Address offset: 0x108
\ Reset value: 0x00000000
\

$00000001 constant OTG_FS_HOST_OTG_FS_HCINT0_XFRC                   \ Transfer completed
$00000002 constant OTG_FS_HOST_OTG_FS_HCINT0_CHH                    \ Channel halted
$00000008 constant OTG_FS_HOST_OTG_FS_HCINT0_STALL                  \ STALL response received interrupt
$00000010 constant OTG_FS_HOST_OTG_FS_HCINT0_NAK                    \ NAK response received interrupt
$00000020 constant OTG_FS_HOST_OTG_FS_HCINT0_ACK                    \ ACK response received/transmitted interrupt
$00000080 constant OTG_FS_HOST_OTG_FS_HCINT0_TXERR                  \ Transaction error
$00000100 constant OTG_FS_HOST_OTG_FS_HCINT0_BBERR                  \ Babble error
$00000200 constant OTG_FS_HOST_OTG_FS_HCINT0_FRMOR                  \ Frame overrun
$00000400 constant OTG_FS_HOST_OTG_FS_HCINT0_DTERR                  \ Data toggle error


\
\ @brief OTG_FS host channel-0 mask register (OTG_FS_HCINTMSK0)
\ Address offset: 0x10C
\ Reset value: 0x00000000
\

$00000001 constant OTG_FS_HOST_OTG_FS_HCINTMSK0_XFRCM               \ Transfer completed mask
$00000002 constant OTG_FS_HOST_OTG_FS_HCINTMSK0_CHHM                \ Channel halted mask
$00000008 constant OTG_FS_HOST_OTG_FS_HCINTMSK0_STALLM              \ STALL response received interrupt mask
$00000010 constant OTG_FS_HOST_OTG_FS_HCINTMSK0_NAKM                \ NAK response received interrupt mask
$00000020 constant OTG_FS_HOST_OTG_FS_HCINTMSK0_ACKM                \ ACK response received/transmitted interrupt mask
$00000040 constant OTG_FS_HOST_OTG_FS_HCINTMSK0_NYET                \ response received interrupt mask
$00000080 constant OTG_FS_HOST_OTG_FS_HCINTMSK0_TXERRM              \ Transaction error mask
$00000100 constant OTG_FS_HOST_OTG_FS_HCINTMSK0_BBERRM              \ Babble error mask
$00000200 constant OTG_FS_HOST_OTG_FS_HCINTMSK0_FRMORM              \ Frame overrun mask
$00000400 constant OTG_FS_HOST_OTG_FS_HCINTMSK0_DTERRM              \ Data toggle error mask


\
\ @brief OTG_FS host channel-0 transfer size register
\ Address offset: 0x110
\ Reset value: 0x00000000
\

$0007ffff constant OTG_FS_HOST_OTG_FS_HCTSIZ0_XFRSIZ                \ Transfer size
$1ff80000 constant OTG_FS_HOST_OTG_FS_HCTSIZ0_PKTCNT                \ Packet count
$60000000 constant OTG_FS_HOST_OTG_FS_HCTSIZ0_DPID                  \ Data PID


\
\ @brief OTG_FS host channel-1 characteristics register (OTG_FS_HCCHAR1)
\ Address offset: 0x120
\ Reset value: 0x00000000
\

$000007ff constant OTG_FS_HOST_OTG_FS_HCCHAR1_MPSIZ                 \ Maximum packet size
$00007800 constant OTG_FS_HOST_OTG_FS_HCCHAR1_EPNUM                 \ Endpoint number
$00008000 constant OTG_FS_HOST_OTG_FS_HCCHAR1_EPDIR                 \ Endpoint direction
$00020000 constant OTG_FS_HOST_OTG_FS_HCCHAR1_LSDEV                 \ Low-speed device
$000c0000 constant OTG_FS_HOST_OTG_FS_HCCHAR1_EPTYP                 \ Endpoint type
$00300000 constant OTG_FS_HOST_OTG_FS_HCCHAR1_MCNT                  \ Multicount
$1fc00000 constant OTG_FS_HOST_OTG_FS_HCCHAR1_DAD                   \ Device address
$20000000 constant OTG_FS_HOST_OTG_FS_HCCHAR1_ODDFRM                \ Odd frame
$40000000 constant OTG_FS_HOST_OTG_FS_HCCHAR1_CHDIS                 \ Channel disable
$80000000 constant OTG_FS_HOST_OTG_FS_HCCHAR1_CHENA                 \ Channel enable


\
\ @brief OTG_FS host channel-1 interrupt register (OTG_FS_HCINT1)
\ Address offset: 0x128
\ Reset value: 0x00000000
\

$00000001 constant OTG_FS_HOST_OTG_FS_HCINT1_XFRC                   \ Transfer completed
$00000002 constant OTG_FS_HOST_OTG_FS_HCINT1_CHH                    \ Channel halted
$00000008 constant OTG_FS_HOST_OTG_FS_HCINT1_STALL                  \ STALL response received interrupt
$00000010 constant OTG_FS_HOST_OTG_FS_HCINT1_NAK                    \ NAK response received interrupt
$00000020 constant OTG_FS_HOST_OTG_FS_HCINT1_ACK                    \ ACK response received/transmitted interrupt
$00000080 constant OTG_FS_HOST_OTG_FS_HCINT1_TXERR                  \ Transaction error
$00000100 constant OTG_FS_HOST_OTG_FS_HCINT1_BBERR                  \ Babble error
$00000200 constant OTG_FS_HOST_OTG_FS_HCINT1_FRMOR                  \ Frame overrun
$00000400 constant OTG_FS_HOST_OTG_FS_HCINT1_DTERR                  \ Data toggle error


\
\ @brief OTG_FS host channel-1 mask register (OTG_FS_HCINTMSK1)
\ Address offset: 0x12C
\ Reset value: 0x00000000
\

$00000001 constant OTG_FS_HOST_OTG_FS_HCINTMSK1_XFRCM               \ Transfer completed mask
$00000002 constant OTG_FS_HOST_OTG_FS_HCINTMSK1_CHHM                \ Channel halted mask
$00000008 constant OTG_FS_HOST_OTG_FS_HCINTMSK1_STALLM              \ STALL response received interrupt mask
$00000010 constant OTG_FS_HOST_OTG_FS_HCINTMSK1_NAKM                \ NAK response received interrupt mask
$00000020 constant OTG_FS_HOST_OTG_FS_HCINTMSK1_ACKM                \ ACK response received/transmitted interrupt mask
$00000040 constant OTG_FS_HOST_OTG_FS_HCINTMSK1_NYET                \ response received interrupt mask
$00000080 constant OTG_FS_HOST_OTG_FS_HCINTMSK1_TXERRM              \ Transaction error mask
$00000100 constant OTG_FS_HOST_OTG_FS_HCINTMSK1_BBERRM              \ Babble error mask
$00000200 constant OTG_FS_HOST_OTG_FS_HCINTMSK1_FRMORM              \ Frame overrun mask
$00000400 constant OTG_FS_HOST_OTG_FS_HCINTMSK1_DTERRM              \ Data toggle error mask


\
\ @brief OTG_FS host channel-1 transfer size register
\ Address offset: 0x130
\ Reset value: 0x00000000
\

$0007ffff constant OTG_FS_HOST_OTG_FS_HCTSIZ1_XFRSIZ                \ Transfer size
$1ff80000 constant OTG_FS_HOST_OTG_FS_HCTSIZ1_PKTCNT                \ Packet count
$60000000 constant OTG_FS_HOST_OTG_FS_HCTSIZ1_DPID                  \ Data PID


\
\ @brief OTG_FS host channel-2 characteristics register (OTG_FS_HCCHAR2)
\ Address offset: 0x140
\ Reset value: 0x00000000
\

$000007ff constant OTG_FS_HOST_OTG_FS_HCCHAR2_MPSIZ                 \ Maximum packet size
$00007800 constant OTG_FS_HOST_OTG_FS_HCCHAR2_EPNUM                 \ Endpoint number
$00008000 constant OTG_FS_HOST_OTG_FS_HCCHAR2_EPDIR                 \ Endpoint direction
$00020000 constant OTG_FS_HOST_OTG_FS_HCCHAR2_LSDEV                 \ Low-speed device
$000c0000 constant OTG_FS_HOST_OTG_FS_HCCHAR2_EPTYP                 \ Endpoint type
$00300000 constant OTG_FS_HOST_OTG_FS_HCCHAR2_MCNT                  \ Multicount
$1fc00000 constant OTG_FS_HOST_OTG_FS_HCCHAR2_DAD                   \ Device address
$20000000 constant OTG_FS_HOST_OTG_FS_HCCHAR2_ODDFRM                \ Odd frame
$40000000 constant OTG_FS_HOST_OTG_FS_HCCHAR2_CHDIS                 \ Channel disable
$80000000 constant OTG_FS_HOST_OTG_FS_HCCHAR2_CHENA                 \ Channel enable


\
\ @brief OTG_FS host channel-2 interrupt register (OTG_FS_HCINT2)
\ Address offset: 0x148
\ Reset value: 0x00000000
\

$00000001 constant OTG_FS_HOST_OTG_FS_HCINT2_XFRC                   \ Transfer completed
$00000002 constant OTG_FS_HOST_OTG_FS_HCINT2_CHH                    \ Channel halted
$00000008 constant OTG_FS_HOST_OTG_FS_HCINT2_STALL                  \ STALL response received interrupt
$00000010 constant OTG_FS_HOST_OTG_FS_HCINT2_NAK                    \ NAK response received interrupt
$00000020 constant OTG_FS_HOST_OTG_FS_HCINT2_ACK                    \ ACK response received/transmitted interrupt
$00000080 constant OTG_FS_HOST_OTG_FS_HCINT2_TXERR                  \ Transaction error
$00000100 constant OTG_FS_HOST_OTG_FS_HCINT2_BBERR                  \ Babble error
$00000200 constant OTG_FS_HOST_OTG_FS_HCINT2_FRMOR                  \ Frame overrun
$00000400 constant OTG_FS_HOST_OTG_FS_HCINT2_DTERR                  \ Data toggle error


\
\ @brief OTG_FS host channel-2 mask register (OTG_FS_HCINTMSK2)
\ Address offset: 0x14C
\ Reset value: 0x00000000
\

$00000001 constant OTG_FS_HOST_OTG_FS_HCINTMSK2_XFRCM               \ Transfer completed mask
$00000002 constant OTG_FS_HOST_OTG_FS_HCINTMSK2_CHHM                \ Channel halted mask
$00000008 constant OTG_FS_HOST_OTG_FS_HCINTMSK2_STALLM              \ STALL response received interrupt mask
$00000010 constant OTG_FS_HOST_OTG_FS_HCINTMSK2_NAKM                \ NAK response received interrupt mask
$00000020 constant OTG_FS_HOST_OTG_FS_HCINTMSK2_ACKM                \ ACK response received/transmitted interrupt mask
$00000040 constant OTG_FS_HOST_OTG_FS_HCINTMSK2_NYET                \ response received interrupt mask
$00000080 constant OTG_FS_HOST_OTG_FS_HCINTMSK2_TXERRM              \ Transaction error mask
$00000100 constant OTG_FS_HOST_OTG_FS_HCINTMSK2_BBERRM              \ Babble error mask
$00000200 constant OTG_FS_HOST_OTG_FS_HCINTMSK2_FRMORM              \ Frame overrun mask
$00000400 constant OTG_FS_HOST_OTG_FS_HCINTMSK2_DTERRM              \ Data toggle error mask


\
\ @brief OTG_FS host channel-2 transfer size register
\ Address offset: 0x150
\ Reset value: 0x00000000
\

$0007ffff constant OTG_FS_HOST_OTG_FS_HCTSIZ2_XFRSIZ                \ Transfer size
$1ff80000 constant OTG_FS_HOST_OTG_FS_HCTSIZ2_PKTCNT                \ Packet count
$60000000 constant OTG_FS_HOST_OTG_FS_HCTSIZ2_DPID                  \ Data PID


\
\ @brief OTG_FS host channel-3 characteristics register (OTG_FS_HCCHAR3)
\ Address offset: 0x160
\ Reset value: 0x00000000
\

$000007ff constant OTG_FS_HOST_OTG_FS_HCCHAR3_MPSIZ                 \ Maximum packet size
$00007800 constant OTG_FS_HOST_OTG_FS_HCCHAR3_EPNUM                 \ Endpoint number
$00008000 constant OTG_FS_HOST_OTG_FS_HCCHAR3_EPDIR                 \ Endpoint direction
$00020000 constant OTG_FS_HOST_OTG_FS_HCCHAR3_LSDEV                 \ Low-speed device
$000c0000 constant OTG_FS_HOST_OTG_FS_HCCHAR3_EPTYP                 \ Endpoint type
$00300000 constant OTG_FS_HOST_OTG_FS_HCCHAR3_MCNT                  \ Multicount
$1fc00000 constant OTG_FS_HOST_OTG_FS_HCCHAR3_DAD                   \ Device address
$20000000 constant OTG_FS_HOST_OTG_FS_HCCHAR3_ODDFRM                \ Odd frame
$40000000 constant OTG_FS_HOST_OTG_FS_HCCHAR3_CHDIS                 \ Channel disable
$80000000 constant OTG_FS_HOST_OTG_FS_HCCHAR3_CHENA                 \ Channel enable


\
\ @brief OTG_FS host channel-3 interrupt register (OTG_FS_HCINT3)
\ Address offset: 0x168
\ Reset value: 0x00000000
\

$00000001 constant OTG_FS_HOST_OTG_FS_HCINT3_XFRC                   \ Transfer completed
$00000002 constant OTG_FS_HOST_OTG_FS_HCINT3_CHH                    \ Channel halted
$00000008 constant OTG_FS_HOST_OTG_FS_HCINT3_STALL                  \ STALL response received interrupt
$00000010 constant OTG_FS_HOST_OTG_FS_HCINT3_NAK                    \ NAK response received interrupt
$00000020 constant OTG_FS_HOST_OTG_FS_HCINT3_ACK                    \ ACK response received/transmitted interrupt
$00000080 constant OTG_FS_HOST_OTG_FS_HCINT3_TXERR                  \ Transaction error
$00000100 constant OTG_FS_HOST_OTG_FS_HCINT3_BBERR                  \ Babble error
$00000200 constant OTG_FS_HOST_OTG_FS_HCINT3_FRMOR                  \ Frame overrun
$00000400 constant OTG_FS_HOST_OTG_FS_HCINT3_DTERR                  \ Data toggle error


\
\ @brief OTG_FS host channel-3 mask register (OTG_FS_HCINTMSK3)
\ Address offset: 0x16C
\ Reset value: 0x00000000
\

$00000001 constant OTG_FS_HOST_OTG_FS_HCINTMSK3_XFRCM               \ Transfer completed mask
$00000002 constant OTG_FS_HOST_OTG_FS_HCINTMSK3_CHHM                \ Channel halted mask
$00000008 constant OTG_FS_HOST_OTG_FS_HCINTMSK3_STALLM              \ STALL response received interrupt mask
$00000010 constant OTG_FS_HOST_OTG_FS_HCINTMSK3_NAKM                \ NAK response received interrupt mask
$00000020 constant OTG_FS_HOST_OTG_FS_HCINTMSK3_ACKM                \ ACK response received/transmitted interrupt mask
$00000040 constant OTG_FS_HOST_OTG_FS_HCINTMSK3_NYET                \ response received interrupt mask
$00000080 constant OTG_FS_HOST_OTG_FS_HCINTMSK3_TXERRM              \ Transaction error mask
$00000100 constant OTG_FS_HOST_OTG_FS_HCINTMSK3_BBERRM              \ Babble error mask
$00000200 constant OTG_FS_HOST_OTG_FS_HCINTMSK3_FRMORM              \ Frame overrun mask
$00000400 constant OTG_FS_HOST_OTG_FS_HCINTMSK3_DTERRM              \ Data toggle error mask


\
\ @brief OTG_FS host channel-3 transfer size register
\ Address offset: 0x170
\ Reset value: 0x00000000
\

$0007ffff constant OTG_FS_HOST_OTG_FS_HCTSIZ3_XFRSIZ                \ Transfer size
$1ff80000 constant OTG_FS_HOST_OTG_FS_HCTSIZ3_PKTCNT                \ Packet count
$60000000 constant OTG_FS_HOST_OTG_FS_HCTSIZ3_DPID                  \ Data PID


\
\ @brief OTG_FS host channel-4 characteristics register (OTG_FS_HCCHAR4)
\ Address offset: 0x180
\ Reset value: 0x00000000
\

$000007ff constant OTG_FS_HOST_OTG_FS_HCCHAR4_MPSIZ                 \ Maximum packet size
$00007800 constant OTG_FS_HOST_OTG_FS_HCCHAR4_EPNUM                 \ Endpoint number
$00008000 constant OTG_FS_HOST_OTG_FS_HCCHAR4_EPDIR                 \ Endpoint direction
$00020000 constant OTG_FS_HOST_OTG_FS_HCCHAR4_LSDEV                 \ Low-speed device
$000c0000 constant OTG_FS_HOST_OTG_FS_HCCHAR4_EPTYP                 \ Endpoint type
$00300000 constant OTG_FS_HOST_OTG_FS_HCCHAR4_MCNT                  \ Multicount
$1fc00000 constant OTG_FS_HOST_OTG_FS_HCCHAR4_DAD                   \ Device address
$20000000 constant OTG_FS_HOST_OTG_FS_HCCHAR4_ODDFRM                \ Odd frame
$40000000 constant OTG_FS_HOST_OTG_FS_HCCHAR4_CHDIS                 \ Channel disable
$80000000 constant OTG_FS_HOST_OTG_FS_HCCHAR4_CHENA                 \ Channel enable


\
\ @brief OTG_FS host channel-4 interrupt register (OTG_FS_HCINT4)
\ Address offset: 0x188
\ Reset value: 0x00000000
\

$00000001 constant OTG_FS_HOST_OTG_FS_HCINT4_XFRC                   \ Transfer completed
$00000002 constant OTG_FS_HOST_OTG_FS_HCINT4_CHH                    \ Channel halted
$00000008 constant OTG_FS_HOST_OTG_FS_HCINT4_STALL                  \ STALL response received interrupt
$00000010 constant OTG_FS_HOST_OTG_FS_HCINT4_NAK                    \ NAK response received interrupt
$00000020 constant OTG_FS_HOST_OTG_FS_HCINT4_ACK                    \ ACK response received/transmitted interrupt
$00000080 constant OTG_FS_HOST_OTG_FS_HCINT4_TXERR                  \ Transaction error
$00000100 constant OTG_FS_HOST_OTG_FS_HCINT4_BBERR                  \ Babble error
$00000200 constant OTG_FS_HOST_OTG_FS_HCINT4_FRMOR                  \ Frame overrun
$00000400 constant OTG_FS_HOST_OTG_FS_HCINT4_DTERR                  \ Data toggle error


\
\ @brief OTG_FS host channel-4 mask register (OTG_FS_HCINTMSK4)
\ Address offset: 0x18C
\ Reset value: 0x00000000
\

$00000001 constant OTG_FS_HOST_OTG_FS_HCINTMSK4_XFRCM               \ Transfer completed mask
$00000002 constant OTG_FS_HOST_OTG_FS_HCINTMSK4_CHHM                \ Channel halted mask
$00000008 constant OTG_FS_HOST_OTG_FS_HCINTMSK4_STALLM              \ STALL response received interrupt mask
$00000010 constant OTG_FS_HOST_OTG_FS_HCINTMSK4_NAKM                \ NAK response received interrupt mask
$00000020 constant OTG_FS_HOST_OTG_FS_HCINTMSK4_ACKM                \ ACK response received/transmitted interrupt mask
$00000040 constant OTG_FS_HOST_OTG_FS_HCINTMSK4_NYET                \ response received interrupt mask
$00000080 constant OTG_FS_HOST_OTG_FS_HCINTMSK4_TXERRM              \ Transaction error mask
$00000100 constant OTG_FS_HOST_OTG_FS_HCINTMSK4_BBERRM              \ Babble error mask
$00000200 constant OTG_FS_HOST_OTG_FS_HCINTMSK4_FRMORM              \ Frame overrun mask
$00000400 constant OTG_FS_HOST_OTG_FS_HCINTMSK4_DTERRM              \ Data toggle error mask


\
\ @brief OTG_FS host channel-x transfer size register
\ Address offset: 0x190
\ Reset value: 0x00000000
\

$0007ffff constant OTG_FS_HOST_OTG_FS_HCTSIZ4_XFRSIZ                \ Transfer size
$1ff80000 constant OTG_FS_HOST_OTG_FS_HCTSIZ4_PKTCNT                \ Packet count
$60000000 constant OTG_FS_HOST_OTG_FS_HCTSIZ4_DPID                  \ Data PID


\
\ @brief OTG_FS host channel-5 characteristics register (OTG_FS_HCCHAR5)
\ Address offset: 0x1A0
\ Reset value: 0x00000000
\

$000007ff constant OTG_FS_HOST_OTG_FS_HCCHAR5_MPSIZ                 \ Maximum packet size
$00007800 constant OTG_FS_HOST_OTG_FS_HCCHAR5_EPNUM                 \ Endpoint number
$00008000 constant OTG_FS_HOST_OTG_FS_HCCHAR5_EPDIR                 \ Endpoint direction
$00020000 constant OTG_FS_HOST_OTG_FS_HCCHAR5_LSDEV                 \ Low-speed device
$000c0000 constant OTG_FS_HOST_OTG_FS_HCCHAR5_EPTYP                 \ Endpoint type
$00300000 constant OTG_FS_HOST_OTG_FS_HCCHAR5_MCNT                  \ Multicount
$1fc00000 constant OTG_FS_HOST_OTG_FS_HCCHAR5_DAD                   \ Device address
$20000000 constant OTG_FS_HOST_OTG_FS_HCCHAR5_ODDFRM                \ Odd frame
$40000000 constant OTG_FS_HOST_OTG_FS_HCCHAR5_CHDIS                 \ Channel disable
$80000000 constant OTG_FS_HOST_OTG_FS_HCCHAR5_CHENA                 \ Channel enable


\
\ @brief OTG_FS host channel-5 interrupt register (OTG_FS_HCINT5)
\ Address offset: 0x1A8
\ Reset value: 0x00000000
\

$00000001 constant OTG_FS_HOST_OTG_FS_HCINT5_XFRC                   \ Transfer completed
$00000002 constant OTG_FS_HOST_OTG_FS_HCINT5_CHH                    \ Channel halted
$00000008 constant OTG_FS_HOST_OTG_FS_HCINT5_STALL                  \ STALL response received interrupt
$00000010 constant OTG_FS_HOST_OTG_FS_HCINT5_NAK                    \ NAK response received interrupt
$00000020 constant OTG_FS_HOST_OTG_FS_HCINT5_ACK                    \ ACK response received/transmitted interrupt
$00000080 constant OTG_FS_HOST_OTG_FS_HCINT5_TXERR                  \ Transaction error
$00000100 constant OTG_FS_HOST_OTG_FS_HCINT5_BBERR                  \ Babble error
$00000200 constant OTG_FS_HOST_OTG_FS_HCINT5_FRMOR                  \ Frame overrun
$00000400 constant OTG_FS_HOST_OTG_FS_HCINT5_DTERR                  \ Data toggle error


\
\ @brief OTG_FS host channel-5 mask register (OTG_FS_HCINTMSK5)
\ Address offset: 0x1AC
\ Reset value: 0x00000000
\

$00000001 constant OTG_FS_HOST_OTG_FS_HCINTMSK5_XFRCM               \ Transfer completed mask
$00000002 constant OTG_FS_HOST_OTG_FS_HCINTMSK5_CHHM                \ Channel halted mask
$00000008 constant OTG_FS_HOST_OTG_FS_HCINTMSK5_STALLM              \ STALL response received interrupt mask
$00000010 constant OTG_FS_HOST_OTG_FS_HCINTMSK5_NAKM                \ NAK response received interrupt mask
$00000020 constant OTG_FS_HOST_OTG_FS_HCINTMSK5_ACKM                \ ACK response received/transmitted interrupt mask
$00000040 constant OTG_FS_HOST_OTG_FS_HCINTMSK5_NYET                \ response received interrupt mask
$00000080 constant OTG_FS_HOST_OTG_FS_HCINTMSK5_TXERRM              \ Transaction error mask
$00000100 constant OTG_FS_HOST_OTG_FS_HCINTMSK5_BBERRM              \ Babble error mask
$00000200 constant OTG_FS_HOST_OTG_FS_HCINTMSK5_FRMORM              \ Frame overrun mask
$00000400 constant OTG_FS_HOST_OTG_FS_HCINTMSK5_DTERRM              \ Data toggle error mask


\
\ @brief OTG_FS host channel-5 transfer size register
\ Address offset: 0x1B0
\ Reset value: 0x00000000
\

$0007ffff constant OTG_FS_HOST_OTG_FS_HCTSIZ5_XFRSIZ                \ Transfer size
$1ff80000 constant OTG_FS_HOST_OTG_FS_HCTSIZ5_PKTCNT                \ Packet count
$60000000 constant OTG_FS_HOST_OTG_FS_HCTSIZ5_DPID                  \ Data PID


\
\ @brief OTG_FS host channel-6 characteristics register (OTG_FS_HCCHAR6)
\ Address offset: 0x1C0
\ Reset value: 0x00000000
\

$000007ff constant OTG_FS_HOST_OTG_FS_HCCHAR6_MPSIZ                 \ Maximum packet size
$00007800 constant OTG_FS_HOST_OTG_FS_HCCHAR6_EPNUM                 \ Endpoint number
$00008000 constant OTG_FS_HOST_OTG_FS_HCCHAR6_EPDIR                 \ Endpoint direction
$00020000 constant OTG_FS_HOST_OTG_FS_HCCHAR6_LSDEV                 \ Low-speed device
$000c0000 constant OTG_FS_HOST_OTG_FS_HCCHAR6_EPTYP                 \ Endpoint type
$00300000 constant OTG_FS_HOST_OTG_FS_HCCHAR6_MCNT                  \ Multicount
$1fc00000 constant OTG_FS_HOST_OTG_FS_HCCHAR6_DAD                   \ Device address
$20000000 constant OTG_FS_HOST_OTG_FS_HCCHAR6_ODDFRM                \ Odd frame
$40000000 constant OTG_FS_HOST_OTG_FS_HCCHAR6_CHDIS                 \ Channel disable
$80000000 constant OTG_FS_HOST_OTG_FS_HCCHAR6_CHENA                 \ Channel enable


\
\ @brief OTG_FS host channel-6 interrupt register (OTG_FS_HCINT6)
\ Address offset: 0x1C8
\ Reset value: 0x00000000
\

$00000001 constant OTG_FS_HOST_OTG_FS_HCINT6_XFRC                   \ Transfer completed
$00000002 constant OTG_FS_HOST_OTG_FS_HCINT6_CHH                    \ Channel halted
$00000008 constant OTG_FS_HOST_OTG_FS_HCINT6_STALL                  \ STALL response received interrupt
$00000010 constant OTG_FS_HOST_OTG_FS_HCINT6_NAK                    \ NAK response received interrupt
$00000020 constant OTG_FS_HOST_OTG_FS_HCINT6_ACK                    \ ACK response received/transmitted interrupt
$00000080 constant OTG_FS_HOST_OTG_FS_HCINT6_TXERR                  \ Transaction error
$00000100 constant OTG_FS_HOST_OTG_FS_HCINT6_BBERR                  \ Babble error
$00000200 constant OTG_FS_HOST_OTG_FS_HCINT6_FRMOR                  \ Frame overrun
$00000400 constant OTG_FS_HOST_OTG_FS_HCINT6_DTERR                  \ Data toggle error


\
\ @brief OTG_FS host channel-6 mask register (OTG_FS_HCINTMSK6)
\ Address offset: 0x1CC
\ Reset value: 0x00000000
\

$00000001 constant OTG_FS_HOST_OTG_FS_HCINTMSK6_XFRCM               \ Transfer completed mask
$00000002 constant OTG_FS_HOST_OTG_FS_HCINTMSK6_CHHM                \ Channel halted mask
$00000008 constant OTG_FS_HOST_OTG_FS_HCINTMSK6_STALLM              \ STALL response received interrupt mask
$00000010 constant OTG_FS_HOST_OTG_FS_HCINTMSK6_NAKM                \ NAK response received interrupt mask
$00000020 constant OTG_FS_HOST_OTG_FS_HCINTMSK6_ACKM                \ ACK response received/transmitted interrupt mask
$00000040 constant OTG_FS_HOST_OTG_FS_HCINTMSK6_NYET                \ response received interrupt mask
$00000080 constant OTG_FS_HOST_OTG_FS_HCINTMSK6_TXERRM              \ Transaction error mask
$00000100 constant OTG_FS_HOST_OTG_FS_HCINTMSK6_BBERRM              \ Babble error mask
$00000200 constant OTG_FS_HOST_OTG_FS_HCINTMSK6_FRMORM              \ Frame overrun mask
$00000400 constant OTG_FS_HOST_OTG_FS_HCINTMSK6_DTERRM              \ Data toggle error mask


\
\ @brief OTG_FS host channel-6 transfer size register
\ Address offset: 0x1D0
\ Reset value: 0x00000000
\

$0007ffff constant OTG_FS_HOST_OTG_FS_HCTSIZ6_XFRSIZ                \ Transfer size
$1ff80000 constant OTG_FS_HOST_OTG_FS_HCTSIZ6_PKTCNT                \ Packet count
$60000000 constant OTG_FS_HOST_OTG_FS_HCTSIZ6_DPID                  \ Data PID


\
\ @brief OTG_FS host channel-7 characteristics register (OTG_FS_HCCHAR7)
\ Address offset: 0x1E0
\ Reset value: 0x00000000
\

$000007ff constant OTG_FS_HOST_OTG_FS_HCCHAR7_MPSIZ                 \ Maximum packet size
$00007800 constant OTG_FS_HOST_OTG_FS_HCCHAR7_EPNUM                 \ Endpoint number
$00008000 constant OTG_FS_HOST_OTG_FS_HCCHAR7_EPDIR                 \ Endpoint direction
$00020000 constant OTG_FS_HOST_OTG_FS_HCCHAR7_LSDEV                 \ Low-speed device
$000c0000 constant OTG_FS_HOST_OTG_FS_HCCHAR7_EPTYP                 \ Endpoint type
$00300000 constant OTG_FS_HOST_OTG_FS_HCCHAR7_MCNT                  \ Multicount
$1fc00000 constant OTG_FS_HOST_OTG_FS_HCCHAR7_DAD                   \ Device address
$20000000 constant OTG_FS_HOST_OTG_FS_HCCHAR7_ODDFRM                \ Odd frame
$40000000 constant OTG_FS_HOST_OTG_FS_HCCHAR7_CHDIS                 \ Channel disable
$80000000 constant OTG_FS_HOST_OTG_FS_HCCHAR7_CHENA                 \ Channel enable


\
\ @brief OTG_FS host channel-7 interrupt register (OTG_FS_HCINT7)
\ Address offset: 0x1E8
\ Reset value: 0x00000000
\

$00000001 constant OTG_FS_HOST_OTG_FS_HCINT7_XFRC                   \ Transfer completed
$00000002 constant OTG_FS_HOST_OTG_FS_HCINT7_CHH                    \ Channel halted
$00000008 constant OTG_FS_HOST_OTG_FS_HCINT7_STALL                  \ STALL response received interrupt
$00000010 constant OTG_FS_HOST_OTG_FS_HCINT7_NAK                    \ NAK response received interrupt
$00000020 constant OTG_FS_HOST_OTG_FS_HCINT7_ACK                    \ ACK response received/transmitted interrupt
$00000080 constant OTG_FS_HOST_OTG_FS_HCINT7_TXERR                  \ Transaction error
$00000100 constant OTG_FS_HOST_OTG_FS_HCINT7_BBERR                  \ Babble error
$00000200 constant OTG_FS_HOST_OTG_FS_HCINT7_FRMOR                  \ Frame overrun
$00000400 constant OTG_FS_HOST_OTG_FS_HCINT7_DTERR                  \ Data toggle error


\
\ @brief OTG_FS host channel-7 mask register (OTG_FS_HCINTMSK7)
\ Address offset: 0x1EC
\ Reset value: 0x00000000
\

$00000001 constant OTG_FS_HOST_OTG_FS_HCINTMSK7_XFRCM               \ Transfer completed mask
$00000002 constant OTG_FS_HOST_OTG_FS_HCINTMSK7_CHHM                \ Channel halted mask
$00000008 constant OTG_FS_HOST_OTG_FS_HCINTMSK7_STALLM              \ STALL response received interrupt mask
$00000010 constant OTG_FS_HOST_OTG_FS_HCINTMSK7_NAKM                \ NAK response received interrupt mask
$00000020 constant OTG_FS_HOST_OTG_FS_HCINTMSK7_ACKM                \ ACK response received/transmitted interrupt mask
$00000040 constant OTG_FS_HOST_OTG_FS_HCINTMSK7_NYET                \ response received interrupt mask
$00000080 constant OTG_FS_HOST_OTG_FS_HCINTMSK7_TXERRM              \ Transaction error mask
$00000100 constant OTG_FS_HOST_OTG_FS_HCINTMSK7_BBERRM              \ Babble error mask
$00000200 constant OTG_FS_HOST_OTG_FS_HCINTMSK7_FRMORM              \ Frame overrun mask
$00000400 constant OTG_FS_HOST_OTG_FS_HCINTMSK7_DTERRM              \ Data toggle error mask


\
\ @brief OTG_FS host channel-7 transfer size register
\ Address offset: 0x1F0
\ Reset value: 0x00000000
\

$0007ffff constant OTG_FS_HOST_OTG_FS_HCTSIZ7_XFRSIZ                \ Transfer size
$1ff80000 constant OTG_FS_HOST_OTG_FS_HCTSIZ7_PKTCNT                \ Packet count
$60000000 constant OTG_FS_HOST_OTG_FS_HCTSIZ7_DPID                  \ Data PID


\
\ @brief OTG_FS host channel-8 characteristics register
\ Address offset: 0x1F4
\ Reset value: 0x00000000
\

$000007ff constant OTG_FS_HOST_OTG_FS_HCCHAR8_MPSIZ                 \ Maximum packet size
$00007800 constant OTG_FS_HOST_OTG_FS_HCCHAR8_EPNUM                 \ Endpoint number
$00008000 constant OTG_FS_HOST_OTG_FS_HCCHAR8_EPDIR                 \ Endpoint direction
$00020000 constant OTG_FS_HOST_OTG_FS_HCCHAR8_LSDEV                 \ Low-speed device
$000c0000 constant OTG_FS_HOST_OTG_FS_HCCHAR8_EPTYP                 \ Endpoint type
$00300000 constant OTG_FS_HOST_OTG_FS_HCCHAR8_MCNT                  \ Multicount
$1fc00000 constant OTG_FS_HOST_OTG_FS_HCCHAR8_DAD                   \ Device address
$20000000 constant OTG_FS_HOST_OTG_FS_HCCHAR8_ODDFRM                \ Odd frame
$40000000 constant OTG_FS_HOST_OTG_FS_HCCHAR8_CHDIS                 \ Channel disable
$80000000 constant OTG_FS_HOST_OTG_FS_HCCHAR8_CHENA                 \ Channel enable


\
\ @brief OTG_FS host channel-8 interrupt register
\ Address offset: 0x1F8
\ Reset value: 0x00000000
\

$00000001 constant OTG_FS_HOST_OTG_FS_HCINT8_XFRC                   \ Transfer completed
$00000002 constant OTG_FS_HOST_OTG_FS_HCINT8_CHH                    \ Channel halted
$00000008 constant OTG_FS_HOST_OTG_FS_HCINT8_STALL                  \ STALL response received interrupt
$00000010 constant OTG_FS_HOST_OTG_FS_HCINT8_NAK                    \ NAK response received interrupt
$00000020 constant OTG_FS_HOST_OTG_FS_HCINT8_ACK                    \ ACK response received/transmitted interrupt
$00000080 constant OTG_FS_HOST_OTG_FS_HCINT8_TXERR                  \ Transaction error
$00000100 constant OTG_FS_HOST_OTG_FS_HCINT8_BBERR                  \ Babble error
$00000200 constant OTG_FS_HOST_OTG_FS_HCINT8_FRMOR                  \ Frame overrun
$00000400 constant OTG_FS_HOST_OTG_FS_HCINT8_DTERR                  \ Data toggle error


\
\ @brief OTG_FS host channel-8 mask register
\ Address offset: 0x1FC
\ Reset value: 0x00000000
\

$00000001 constant OTG_FS_HOST_OTG_FS_HCINTMSK8_XFRCM               \ Transfer completed mask
$00000002 constant OTG_FS_HOST_OTG_FS_HCINTMSK8_CHHM                \ Channel halted mask
$00000008 constant OTG_FS_HOST_OTG_FS_HCINTMSK8_STALLM              \ STALL response received interrupt mask
$00000010 constant OTG_FS_HOST_OTG_FS_HCINTMSK8_NAKM                \ NAK response received interrupt mask
$00000020 constant OTG_FS_HOST_OTG_FS_HCINTMSK8_ACKM                \ ACK response received/transmitted interrupt mask
$00000040 constant OTG_FS_HOST_OTG_FS_HCINTMSK8_NYET                \ response received interrupt mask
$00000080 constant OTG_FS_HOST_OTG_FS_HCINTMSK8_TXERRM              \ Transaction error
$00000100 constant OTG_FS_HOST_OTG_FS_HCINTMSK8_BBERRM              \ Babble error mask
$00000200 constant OTG_FS_HOST_OTG_FS_HCINTMSK8_FRMORM              \ Frame overrun mask
$00000400 constant OTG_FS_HOST_OTG_FS_HCINTMSK8_DTERRM              \ Data toggle error mask


\
\ @brief OTG_FS host channel-8 transfer size register
\ Address offset: 0x200
\ Reset value: 0x00000000
\

$0007ffff constant OTG_FS_HOST_OTG_FS_HCTSIZ8_XFRSIZ                \ Transfer size
$1ff80000 constant OTG_FS_HOST_OTG_FS_HCTSIZ8_PKTCNT                \ Packet count
$60000000 constant OTG_FS_HOST_OTG_FS_HCTSIZ8_DPID                  \ Data PID


\
\ @brief OTG_FS host channel-9 characteristics register
\ Address offset: 0x204
\ Reset value: 0x00000000
\

$000007ff constant OTG_FS_HOST_OTG_FS_HCCHAR9_MPSIZ                 \ Maximum packet size
$00007800 constant OTG_FS_HOST_OTG_FS_HCCHAR9_EPNUM                 \ Endpoint number
$00008000 constant OTG_FS_HOST_OTG_FS_HCCHAR9_EPDIR                 \ Endpoint direction
$00020000 constant OTG_FS_HOST_OTG_FS_HCCHAR9_LSDEV                 \ Low-speed device
$000c0000 constant OTG_FS_HOST_OTG_FS_HCCHAR9_EPTYP                 \ Endpoint type
$00300000 constant OTG_FS_HOST_OTG_FS_HCCHAR9_MCNT                  \ Multicount
$1fc00000 constant OTG_FS_HOST_OTG_FS_HCCHAR9_DAD                   \ Device address
$20000000 constant OTG_FS_HOST_OTG_FS_HCCHAR9_ODDFRM                \ Odd frame
$40000000 constant OTG_FS_HOST_OTG_FS_HCCHAR9_CHDIS                 \ Channel disable
$80000000 constant OTG_FS_HOST_OTG_FS_HCCHAR9_CHENA                 \ Channel enable


\
\ @brief OTG_FS host channel-9 interrupt register
\ Address offset: 0x208
\ Reset value: 0x00000000
\

$00000001 constant OTG_FS_HOST_OTG_FS_HCINT9_XFRC                   \ Transfer completed
$00000002 constant OTG_FS_HOST_OTG_FS_HCINT9_CHH                    \ Channel halted
$00000008 constant OTG_FS_HOST_OTG_FS_HCINT9_STALL                  \ STALL response received interrupt
$00000010 constant OTG_FS_HOST_OTG_FS_HCINT9_NAK                    \ NAK response received interrupt
$00000020 constant OTG_FS_HOST_OTG_FS_HCINT9_ACK                    \ ACK response received/transmitted interrupt
$00000080 constant OTG_FS_HOST_OTG_FS_HCINT9_TXERR                  \ Transaction error
$00000100 constant OTG_FS_HOST_OTG_FS_HCINT9_BBERR                  \ Babble error
$00000200 constant OTG_FS_HOST_OTG_FS_HCINT9_FRMOR                  \ Frame overrun
$00000400 constant OTG_FS_HOST_OTG_FS_HCINT9_DTERR                  \ Data toggle error


\
\ @brief OTG_FS host channel-9 mask register
\ Address offset: 0x20C
\ Reset value: 0x00000000
\

$00000001 constant OTG_FS_HOST_OTG_FS_HCINTMSK9_XFRCM               \ Transfer completed mask
$00000002 constant OTG_FS_HOST_OTG_FS_HCINTMSK9_CHHM                \ Channel halted mask
$00000008 constant OTG_FS_HOST_OTG_FS_HCINTMSK9_STALLM              \ STALL response received interrupt mask
$00000010 constant OTG_FS_HOST_OTG_FS_HCINTMSK9_NAKM                \ NAK response received interrupt mask
$00000020 constant OTG_FS_HOST_OTG_FS_HCINTMSK9_ACKM                \ ACK response received/transmitted interrupt mask
$00000040 constant OTG_FS_HOST_OTG_FS_HCINTMSK9_NYET                \ response received interrupt mask
$00000080 constant OTG_FS_HOST_OTG_FS_HCINTMSK9_TXERRM              \ Transaction error mask
$00000100 constant OTG_FS_HOST_OTG_FS_HCINTMSK9_BBERRM              \ Babble error mask
$00000200 constant OTG_FS_HOST_OTG_FS_HCINTMSK9_FRMORM              \ Frame overrun mask
$00000400 constant OTG_FS_HOST_OTG_FS_HCINTMSK9_DTERRM              \ Data toggle error mask


\
\ @brief OTG_FS host channel-9 transfer size register
\ Address offset: 0x210
\ Reset value: 0x00000000
\

$0007ffff constant OTG_FS_HOST_OTG_FS_HCTSIZ9_XFRSIZ                \ Transfer size
$1ff80000 constant OTG_FS_HOST_OTG_FS_HCTSIZ9_PKTCNT                \ Packet count
$60000000 constant OTG_FS_HOST_OTG_FS_HCTSIZ9_DPID                  \ Data PID


\
\ @brief OTG_FS host channel-10 characteristics register
\ Address offset: 0x214
\ Reset value: 0x00000000
\

$000007ff constant OTG_FS_HOST_OTG_FS_HCCHAR10_MPSIZ                \ Maximum packet size
$00007800 constant OTG_FS_HOST_OTG_FS_HCCHAR10_EPNUM                \ Endpoint number
$00008000 constant OTG_FS_HOST_OTG_FS_HCCHAR10_EPDIR                \ Endpoint direction
$00020000 constant OTG_FS_HOST_OTG_FS_HCCHAR10_LSDEV                \ Low-speed device
$000c0000 constant OTG_FS_HOST_OTG_FS_HCCHAR10_EPTYP                \ Endpoint type
$00300000 constant OTG_FS_HOST_OTG_FS_HCCHAR10_MCNT                 \ Multicount
$1fc00000 constant OTG_FS_HOST_OTG_FS_HCCHAR10_DAD                  \ Device address
$20000000 constant OTG_FS_HOST_OTG_FS_HCCHAR10_ODDFRM               \ Odd frame
$40000000 constant OTG_FS_HOST_OTG_FS_HCCHAR10_CHDIS                \ Channel disable
$80000000 constant OTG_FS_HOST_OTG_FS_HCCHAR10_CHENA                \ Channel enable


\
\ @brief OTG_FS host channel-10 interrupt register
\ Address offset: 0x218
\ Reset value: 0x00000000
\

$00000001 constant OTG_FS_HOST_OTG_FS_HCINT10_XFRC                  \ Transfer completed
$00000002 constant OTG_FS_HOST_OTG_FS_HCINT10_CHH                   \ Channel halted
$00000008 constant OTG_FS_HOST_OTG_FS_HCINT10_STALL                 \ STALL response received interrupt
$00000010 constant OTG_FS_HOST_OTG_FS_HCINT10_NAK                   \ NAK response received interrupt
$00000020 constant OTG_FS_HOST_OTG_FS_HCINT10_ACK                   \ ACK response received/transmitted interrupt
$00000080 constant OTG_FS_HOST_OTG_FS_HCINT10_TXERR                 \ Transaction error
$00000100 constant OTG_FS_HOST_OTG_FS_HCINT10_BBERR                 \ Babble error
$00000200 constant OTG_FS_HOST_OTG_FS_HCINT10_FRMOR                 \ Frame overrun
$00000400 constant OTG_FS_HOST_OTG_FS_HCINT10_DTERR                 \ Data toggle error


\
\ @brief OTG_FS host channel-10 mask register
\ Address offset: 0x21C
\ Reset value: 0x00000000
\

$00000001 constant OTG_FS_HOST_OTG_FS_HCINTMSK10_XFRCM              \ Transfer completed mask
$00000002 constant OTG_FS_HOST_OTG_FS_HCINTMSK10_CHHM               \ Channel halted mask
$00000008 constant OTG_FS_HOST_OTG_FS_HCINTMSK10_STALLM             \ STALL response received interrupt mask
$00000010 constant OTG_FS_HOST_OTG_FS_HCINTMSK10_NAKM               \ NAK response received interrupt mask
$00000020 constant OTG_FS_HOST_OTG_FS_HCINTMSK10_ACKM               \ ACK response received/transmitted interrupt mask
$00000040 constant OTG_FS_HOST_OTG_FS_HCINTMSK10_NYET               \ response received interrupt mask
$00000080 constant OTG_FS_HOST_OTG_FS_HCINTMSK10_TXERRM             \ Transaction error mask
$00000100 constant OTG_FS_HOST_OTG_FS_HCINTMSK10_BBERRM             \ Babble error mask
$00000200 constant OTG_FS_HOST_OTG_FS_HCINTMSK10_FRMORM             \ Frame overrun mask
$00000400 constant OTG_FS_HOST_OTG_FS_HCINTMSK10_DTERRM             \ Data toggle error mask


\
\ @brief OTG_FS host channel-10 transfer size register
\ Address offset: 0x220
\ Reset value: 0x00000000
\

$0007ffff constant OTG_FS_HOST_OTG_FS_HCTSIZ10_XFRSIZ               \ Transfer size
$1ff80000 constant OTG_FS_HOST_OTG_FS_HCTSIZ10_PKTCNT               \ Packet count
$60000000 constant OTG_FS_HOST_OTG_FS_HCTSIZ10_DPID                 \ Data PID


\
\ @brief OTG_FS host channel-11 characteristics register
\ Address offset: 0x224
\ Reset value: 0x00000000
\

$000007ff constant OTG_FS_HOST_OTG_FS_HCCHAR11_MPSIZ                \ Maximum packet size
$00007800 constant OTG_FS_HOST_OTG_FS_HCCHAR11_EPNUM                \ Endpoint number
$00008000 constant OTG_FS_HOST_OTG_FS_HCCHAR11_EPDIR                \ Endpoint direction
$00020000 constant OTG_FS_HOST_OTG_FS_HCCHAR11_LSDEV                \ Low-speed device
$000c0000 constant OTG_FS_HOST_OTG_FS_HCCHAR11_EPTYP                \ Endpoint type
$00300000 constant OTG_FS_HOST_OTG_FS_HCCHAR11_MCNT                 \ Multicount
$1fc00000 constant OTG_FS_HOST_OTG_FS_HCCHAR11_DAD                  \ Device address
$20000000 constant OTG_FS_HOST_OTG_FS_HCCHAR11_ODDFRM               \ Odd frame
$40000000 constant OTG_FS_HOST_OTG_FS_HCCHAR11_CHDIS                \ Channel disable
$80000000 constant OTG_FS_HOST_OTG_FS_HCCHAR11_CHENA                \ Channel enable


\
\ @brief OTG_FS host channel-11 interrupt register
\ Address offset: 0x228
\ Reset value: 0x00000000
\

$00000001 constant OTG_FS_HOST_OTG_FS_HCINT11_XFRC                  \ Transfer completed
$00000002 constant OTG_FS_HOST_OTG_FS_HCINT11_CHH                   \ Channel halted
$00000008 constant OTG_FS_HOST_OTG_FS_HCINT11_STALL                 \ STALL response received interrupt
$00000010 constant OTG_FS_HOST_OTG_FS_HCINT11_NAK                   \ NAK response received interrupt
$00000020 constant OTG_FS_HOST_OTG_FS_HCINT11_ACK                   \ ACK response received/transmitted interrupt
$00000080 constant OTG_FS_HOST_OTG_FS_HCINT11_TXERR                 \ Transaction error
$00000100 constant OTG_FS_HOST_OTG_FS_HCINT11_BBERR                 \ Babble error
$00000200 constant OTG_FS_HOST_OTG_FS_HCINT11_FRMOR                 \ Frame overrun
$00000400 constant OTG_FS_HOST_OTG_FS_HCINT11_DTERR                 \ Data toggle error


\
\ @brief OTG_FS host channel-11 mask register
\ Address offset: 0x22C
\ Reset value: 0x00000000
\

$00000001 constant OTG_FS_HOST_OTG_FS_HCINTMSK11_XFRCM              \ Transfer completed mask
$00000002 constant OTG_FS_HOST_OTG_FS_HCINTMSK11_CHHM               \ Channel halted mask
$00000008 constant OTG_FS_HOST_OTG_FS_HCINTMSK11_STALLM             \ STALL response received interrupt mask
$00000010 constant OTG_FS_HOST_OTG_FS_HCINTMSK11_NAKM               \ NAK response received interrupt mask
$00000020 constant OTG_FS_HOST_OTG_FS_HCINTMSK11_ACKM               \ ACK response received/transmitted interrupt mask
$00000040 constant OTG_FS_HOST_OTG_FS_HCINTMSK11_NYET               \ response received interrupt mask
$00000080 constant OTG_FS_HOST_OTG_FS_HCINTMSK11_TXERRM             \ Transaction error mask
$00000100 constant OTG_FS_HOST_OTG_FS_HCINTMSK11_BBERRM             \ Babble error mask
$00000200 constant OTG_FS_HOST_OTG_FS_HCINTMSK11_FRMORM             \ Frame overrun mask
$00000400 constant OTG_FS_HOST_OTG_FS_HCINTMSK11_DTERRM             \ Data toggle error mask


\
\ @brief OTG_FS host channel-11 transfer size register
\ Address offset: 0x230
\ Reset value: 0x00000000
\

$0007ffff constant OTG_FS_HOST_OTG_FS_HCTSIZ11_XFRSIZ               \ Transfer size
$1ff80000 constant OTG_FS_HOST_OTG_FS_HCTSIZ11_PKTCNT               \ Packet count
$60000000 constant OTG_FS_HOST_OTG_FS_HCTSIZ11_DPID                 \ Data PID


\
\ @brief USB on the go full speed
\
$50000400 constant OTG_FS_HOST_OTG_FS_HCFG  \ offset: 0x00 : OTG_FS host configuration register (OTG_FS_HCFG)
$50000404 constant OTG_FS_HOST_OTG_FS_HFIR  \ offset: 0x04 : OTG_FS Host frame interval register
$50000408 constant OTG_FS_HOST_OTG_FS_HFNUM  \ offset: 0x08 : OTG_FS host frame number/frame time remaining register (OTG_FS_HFNUM)
$50000410 constant OTG_FS_HOST_OTG_FS_HPTXSTS  \ offset: 0x10 : OTG_FS_Host periodic transmit FIFO/queue status register (OTG_FS_HPTXSTS)
$50000414 constant OTG_FS_HOST_OTG_FS_HAINT  \ offset: 0x14 : OTG_FS Host all channels interrupt register
$50000418 constant OTG_FS_HOST_OTG_FS_HAINTMSK  \ offset: 0x18 : OTG_FS host all channels interrupt mask register
$50000440 constant OTG_FS_HOST_OTG_FS_HPRT  \ offset: 0x40 : OTG_FS host port control and status register (OTG_FS_HPRT)
$50000500 constant OTG_FS_HOST_OTG_FS_HCCHAR0  \ offset: 0x100 : OTG_FS host channel-0 characteristics register (OTG_FS_HCCHAR0)
$50000508 constant OTG_FS_HOST_OTG_FS_HCINT0  \ offset: 0x108 : OTG_FS host channel-0 interrupt register (OTG_FS_HCINT0)
$5000050c constant OTG_FS_HOST_OTG_FS_HCINTMSK0  \ offset: 0x10C : OTG_FS host channel-0 mask register (OTG_FS_HCINTMSK0)
$50000510 constant OTG_FS_HOST_OTG_FS_HCTSIZ0  \ offset: 0x110 : OTG_FS host channel-0 transfer size register
$50000520 constant OTG_FS_HOST_OTG_FS_HCCHAR1  \ offset: 0x120 : OTG_FS host channel-1 characteristics register (OTG_FS_HCCHAR1)
$50000528 constant OTG_FS_HOST_OTG_FS_HCINT1  \ offset: 0x128 : OTG_FS host channel-1 interrupt register (OTG_FS_HCINT1)
$5000052c constant OTG_FS_HOST_OTG_FS_HCINTMSK1  \ offset: 0x12C : OTG_FS host channel-1 mask register (OTG_FS_HCINTMSK1)
$50000530 constant OTG_FS_HOST_OTG_FS_HCTSIZ1  \ offset: 0x130 : OTG_FS host channel-1 transfer size register
$50000540 constant OTG_FS_HOST_OTG_FS_HCCHAR2  \ offset: 0x140 : OTG_FS host channel-2 characteristics register (OTG_FS_HCCHAR2)
$50000548 constant OTG_FS_HOST_OTG_FS_HCINT2  \ offset: 0x148 : OTG_FS host channel-2 interrupt register (OTG_FS_HCINT2)
$5000054c constant OTG_FS_HOST_OTG_FS_HCINTMSK2  \ offset: 0x14C : OTG_FS host channel-2 mask register (OTG_FS_HCINTMSK2)
$50000550 constant OTG_FS_HOST_OTG_FS_HCTSIZ2  \ offset: 0x150 : OTG_FS host channel-2 transfer size register
$50000560 constant OTG_FS_HOST_OTG_FS_HCCHAR3  \ offset: 0x160 : OTG_FS host channel-3 characteristics register (OTG_FS_HCCHAR3)
$50000568 constant OTG_FS_HOST_OTG_FS_HCINT3  \ offset: 0x168 : OTG_FS host channel-3 interrupt register (OTG_FS_HCINT3)
$5000056c constant OTG_FS_HOST_OTG_FS_HCINTMSK3  \ offset: 0x16C : OTG_FS host channel-3 mask register (OTG_FS_HCINTMSK3)
$50000570 constant OTG_FS_HOST_OTG_FS_HCTSIZ3  \ offset: 0x170 : OTG_FS host channel-3 transfer size register
$50000580 constant OTG_FS_HOST_OTG_FS_HCCHAR4  \ offset: 0x180 : OTG_FS host channel-4 characteristics register (OTG_FS_HCCHAR4)
$50000588 constant OTG_FS_HOST_OTG_FS_HCINT4  \ offset: 0x188 : OTG_FS host channel-4 interrupt register (OTG_FS_HCINT4)
$5000058c constant OTG_FS_HOST_OTG_FS_HCINTMSK4  \ offset: 0x18C : OTG_FS host channel-4 mask register (OTG_FS_HCINTMSK4)
$50000590 constant OTG_FS_HOST_OTG_FS_HCTSIZ4  \ offset: 0x190 : OTG_FS host channel-x transfer size register
$500005a0 constant OTG_FS_HOST_OTG_FS_HCCHAR5  \ offset: 0x1A0 : OTG_FS host channel-5 characteristics register (OTG_FS_HCCHAR5)
$500005a8 constant OTG_FS_HOST_OTG_FS_HCINT5  \ offset: 0x1A8 : OTG_FS host channel-5 interrupt register (OTG_FS_HCINT5)
$500005ac constant OTG_FS_HOST_OTG_FS_HCINTMSK5  \ offset: 0x1AC : OTG_FS host channel-5 mask register (OTG_FS_HCINTMSK5)
$500005b0 constant OTG_FS_HOST_OTG_FS_HCTSIZ5  \ offset: 0x1B0 : OTG_FS host channel-5 transfer size register
$500005c0 constant OTG_FS_HOST_OTG_FS_HCCHAR6  \ offset: 0x1C0 : OTG_FS host channel-6 characteristics register (OTG_FS_HCCHAR6)
$500005c8 constant OTG_FS_HOST_OTG_FS_HCINT6  \ offset: 0x1C8 : OTG_FS host channel-6 interrupt register (OTG_FS_HCINT6)
$500005cc constant OTG_FS_HOST_OTG_FS_HCINTMSK6  \ offset: 0x1CC : OTG_FS host channel-6 mask register (OTG_FS_HCINTMSK6)
$500005d0 constant OTG_FS_HOST_OTG_FS_HCTSIZ6  \ offset: 0x1D0 : OTG_FS host channel-6 transfer size register
$500005e0 constant OTG_FS_HOST_OTG_FS_HCCHAR7  \ offset: 0x1E0 : OTG_FS host channel-7 characteristics register (OTG_FS_HCCHAR7)
$500005e8 constant OTG_FS_HOST_OTG_FS_HCINT7  \ offset: 0x1E8 : OTG_FS host channel-7 interrupt register (OTG_FS_HCINT7)
$500005ec constant OTG_FS_HOST_OTG_FS_HCINTMSK7  \ offset: 0x1EC : OTG_FS host channel-7 mask register (OTG_FS_HCINTMSK7)
$500005f0 constant OTG_FS_HOST_OTG_FS_HCTSIZ7  \ offset: 0x1F0 : OTG_FS host channel-7 transfer size register
$500005f4 constant OTG_FS_HOST_OTG_FS_HCCHAR8  \ offset: 0x1F4 : OTG_FS host channel-8 characteristics register
$500005f8 constant OTG_FS_HOST_OTG_FS_HCINT8  \ offset: 0x1F8 : OTG_FS host channel-8 interrupt register
$500005fc constant OTG_FS_HOST_OTG_FS_HCINTMSK8  \ offset: 0x1FC : OTG_FS host channel-8 mask register
$50000600 constant OTG_FS_HOST_OTG_FS_HCTSIZ8  \ offset: 0x200 : OTG_FS host channel-8 transfer size register
$50000604 constant OTG_FS_HOST_OTG_FS_HCCHAR9  \ offset: 0x204 : OTG_FS host channel-9 characteristics register
$50000608 constant OTG_FS_HOST_OTG_FS_HCINT9  \ offset: 0x208 : OTG_FS host channel-9 interrupt register
$5000060c constant OTG_FS_HOST_OTG_FS_HCINTMSK9  \ offset: 0x20C : OTG_FS host channel-9 mask register
$50000610 constant OTG_FS_HOST_OTG_FS_HCTSIZ9  \ offset: 0x210 : OTG_FS host channel-9 transfer size register
$50000614 constant OTG_FS_HOST_OTG_FS_HCCHAR10  \ offset: 0x214 : OTG_FS host channel-10 characteristics register
$50000618 constant OTG_FS_HOST_OTG_FS_HCINT10  \ offset: 0x218 : OTG_FS host channel-10 interrupt register
$5000061c constant OTG_FS_HOST_OTG_FS_HCINTMSK10  \ offset: 0x21C : OTG_FS host channel-10 mask register
$50000620 constant OTG_FS_HOST_OTG_FS_HCTSIZ10  \ offset: 0x220 : OTG_FS host channel-10 transfer size register
$50000624 constant OTG_FS_HOST_OTG_FS_HCCHAR11  \ offset: 0x224 : OTG_FS host channel-11 characteristics register
$50000628 constant OTG_FS_HOST_OTG_FS_HCINT11  \ offset: 0x228 : OTG_FS host channel-11 interrupt register
$5000062c constant OTG_FS_HOST_OTG_FS_HCINTMSK11  \ offset: 0x22C : OTG_FS host channel-11 mask register
$50000630 constant OTG_FS_HOST_OTG_FS_HCTSIZ11  \ offset: 0x230 : OTG_FS host channel-11 transfer size register

