\
\ @file otg.fs
\ @brief OTG
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief The OTG_GOTGCTL register controls the behavior and reflects the status of the OTG function of the core.
\ Address offset: 0x00
\ Reset value: 0x00010000
\

$00000001 constant OTG_OTG_GOTGCTL_SRQSCS                           \ SRQSCS
$00000002 constant OTG_OTG_GOTGCTL_SRQ                              \ SRQ
$00000004 constant OTG_OTG_GOTGCTL_VBVALOEN                         \ VBVALOEN
$00000008 constant OTG_OTG_GOTGCTL_VBVALOVAL                        \ VBVALOVAL
$00000010 constant OTG_OTG_GOTGCTL_AVALOEN                          \ AVALOEN
$00000020 constant OTG_OTG_GOTGCTL_AVALOVAL                         \ AVALOVAL
$00000040 constant OTG_OTG_GOTGCTL_BVALOEN                          \ BVALOEN
$00000080 constant OTG_OTG_GOTGCTL_BVALOVAL                         \ BVALOVAL
$00000100 constant OTG_OTG_GOTGCTL_HNGSCS                           \ HNGSCS
$00000200 constant OTG_OTG_GOTGCTL_HNPRQ                            \ HNPRQ
$00000400 constant OTG_OTG_GOTGCTL_HSHNPEN                          \ HSHNPEN
$00000800 constant OTG_OTG_GOTGCTL_DHNPEN                           \ DHNPEN
$00001000 constant OTG_OTG_GOTGCTL_EHEN                             \ EHEN
$00010000 constant OTG_OTG_GOTGCTL_CIDSTS                           \ CIDSTS
$00020000 constant OTG_OTG_GOTGCTL_DBCT                             \ DBCT
$00040000 constant OTG_OTG_GOTGCTL_ASVLD                            \ ASVLD
$00080000 constant OTG_OTG_GOTGCTL_BSVLD                            \ BSVLD
$00100000 constant OTG_OTG_GOTGCTL_OTGVER                           \ OTGVER
$00200000 constant OTG_OTG_GOTGCTL_CURMOD                           \ CURMOD


\
\ @brief The application reads this register whenever there is an OTG interrupt and clears the bits in this register to clear the OTG interrupt.
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$00000004 constant OTG_OTG_GOTGINT_SEDET                            \ SEDET
$00000100 constant OTG_OTG_GOTGINT_SRSSCHG                          \ SRSSCHG
$00000200 constant OTG_OTG_GOTGINT_HNSSCHG                          \ HNSSCHG
$00020000 constant OTG_OTG_GOTGINT_HNGDET                           \ HNGDET
$00040000 constant OTG_OTG_GOTGINT_ADTOCHG                          \ ADTOCHG
$00080000 constant OTG_OTG_GOTGINT_DBCDNE                           \ DBCDNE
$00100000 constant OTG_OTG_GOTGINT_IDCHNG                           \ IDCHNG


\
\ @brief This register can be used to configure the core after power-on or a change in mode. This register mainly contains AHB system-related configuration parameters. Do not change this register after the initial programming. The application must program this register before starting any transactions on either the AHB or the USB.
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$00000001 constant OTG_OTG_GAHBCFG_GINTMSK                          \ GINTMSK
$0000001e constant OTG_OTG_GAHBCFG_HBSTLEN                          \ HBSTLEN
$00000020 constant OTG_OTG_GAHBCFG_DMAEN                            \ DMAEN
$00000080 constant OTG_OTG_GAHBCFG_TXFELVL                          \ TXFELVL
$00000100 constant OTG_OTG_GAHBCFG_PTXFELVL                         \ PTXFELVL


\
\ @brief This register can be used to configure the core after power-on or a changing to host mode or device mode. It contains USB and USB-PHY related configuration parameters. The application must program this register before starting any transactions on either the AHB or the USB. Do not make changes to this register after the initial programming.
\ Address offset: 0x0C
\ Reset value: 0x00001400
\

$00000007 constant OTG_OTG_GUSBCFG_TOCAL                            \ TOCAL
$00000040 constant OTG_OTG_GUSBCFG_PHYSEL                           \ PHYSEL
$00000100 constant OTG_OTG_GUSBCFG_SRPCAP                           \ SRPCAP
$00000200 constant OTG_OTG_GUSBCFG_HNPCAP                           \ HNPCAP
$00003c00 constant OTG_OTG_GUSBCFG_TRDT                             \ TRDT
$00008000 constant OTG_OTG_GUSBCFG_PHYLPC                           \ PHYLPC
$00400000 constant OTG_OTG_GUSBCFG_TSDPS                            \ TSDPS
$20000000 constant OTG_OTG_GUSBCFG_FHMOD                            \ FHMOD
$40000000 constant OTG_OTG_GUSBCFG_FDMOD                            \ FDMOD


\
\ @brief The application uses this register to reset various hardware features inside the core.
\ Address offset: 0x10
\ Reset value: 0x80000000
\

$00000001 constant OTG_OTG_GRSTCTL_CSRST                            \ CSRST
$00000002 constant OTG_OTG_GRSTCTL_PSRST                            \ PSRST
$00000010 constant OTG_OTG_GRSTCTL_RXFFLSH                          \ RXFFLSH
$00000020 constant OTG_OTG_GRSTCTL_TXFFLSH                          \ TXFFLSH
$000007c0 constant OTG_OTG_GRSTCTL_TXFNUM                           \ TXFNUM
$40000000 constant OTG_OTG_GRSTCTL_DMAREQ                           \ DMAREQ
$80000000 constant OTG_OTG_GRSTCTL_AHBIDL                           \ AHBIDL


\
\ @brief This register interrupts the application for system-level events in the current mode (device mode or host mode). Some of the bits in this register are valid only in host mode, while others are valid in device mode only. This register also indicates the current mode. To clear the interrupt status bits of the rc_w1 type, the application must write 1 into the bit. The FIFO status interrupts are read-only; once software reads from or writes to the FIFO while servicing these interrupts, FIFO interrupt conditions are cleared automatically. The application must clear the OTG_GINTSTS register at initialization before unmasking the interrupt bit to avoid any interrupts generated prior to initialization.
\ Address offset: 0x14
\ Reset value: 0x14000020
\

$00000001 constant OTG_OTG_GINTSTS_CMOD                             \ CMOD
$00000002 constant OTG_OTG_GINTSTS_MMIS                             \ MMIS
$00000004 constant OTG_OTG_GINTSTS_OTGINT                           \ OTGINT
$00000008 constant OTG_OTG_GINTSTS_SOF                              \ SOF
$00000010 constant OTG_OTG_GINTSTS_RXFLVL                           \ RXFLVL
$00000020 constant OTG_OTG_GINTSTS_NPTXFE                           \ NPTXFE
$00000040 constant OTG_OTG_GINTSTS_GINAKEFF                         \ GINAKEFF
$00000080 constant OTG_OTG_GINTSTS_GONAKEFF                         \ GONAKEFF
$00000400 constant OTG_OTG_GINTSTS_ESUSP                            \ ESUSP
$00000800 constant OTG_OTG_GINTSTS_USBSUSP                          \ USBSUSP
$00001000 constant OTG_OTG_GINTSTS_USBRST                           \ USBRST
$00002000 constant OTG_OTG_GINTSTS_ENUMDNE                          \ ENUMDNE
$00004000 constant OTG_OTG_GINTSTS_ISOODRP                          \ ISOODRP
$00008000 constant OTG_OTG_GINTSTS_EOPF                             \ EOPF
$00040000 constant OTG_OTG_GINTSTS_IEPINT                           \ IEPINT
$00080000 constant OTG_OTG_GINTSTS_OEPINT                           \ OEPINT
$00100000 constant OTG_OTG_GINTSTS_IISOIXFR                         \ IISOIXFR
$00200000 constant OTG_OTG_GINTSTS_IPXFR                            \ IPXFR
$00400000 constant OTG_OTG_GINTSTS_DATAFSUSP                        \ DATAFSUSP
$01000000 constant OTG_OTG_GINTSTS_HPRTINT                          \ HPRTINT
$02000000 constant OTG_OTG_GINTSTS_HCINT                            \ HCINT
$04000000 constant OTG_OTG_GINTSTS_PTXFE                            \ PTXFE
$10000000 constant OTG_OTG_GINTSTS_CIDSCHG                          \ CIDSCHG
$20000000 constant OTG_OTG_GINTSTS_DISCINT                          \ DISCINT
$40000000 constant OTG_OTG_GINTSTS_SRQINT                           \ SRQINT
$80000000 constant OTG_OTG_GINTSTS_WKUPINT                          \ WKUPINT


\
\ @brief This register works with the core interrupt register to interrupt the application. When an interrupt bit is masked, the interrupt associated with that bit is not generated. However, the core interrupt (OTG_GINTSTS) register bit corresponding to that interrupt is still set.
\ Address offset: 0x18
\ Reset value: 0x00000000
\

$00000002 constant OTG_OTG_GINTMSK_MMISM                            \ MMISM
$00000004 constant OTG_OTG_GINTMSK_OTGINT                           \ OTGINT
$00000008 constant OTG_OTG_GINTMSK_SOFM                             \ SOFM
$00000010 constant OTG_OTG_GINTMSK_RXFLVLM                          \ RXFLVLM
$00000020 constant OTG_OTG_GINTMSK_NPTXFEM                          \ NPTXFEM
$00000040 constant OTG_OTG_GINTMSK_GINAKEFFM                        \ GINAKEFFM
$00000080 constant OTG_OTG_GINTMSK_GONAKEFFM                        \ GONAKEFFM
$00000400 constant OTG_OTG_GINTMSK_ESUSPM                           \ ESUSPM
$00000800 constant OTG_OTG_GINTMSK_USBSUSPM                         \ USBSUSPM
$00001000 constant OTG_OTG_GINTMSK_USBRST                           \ USBRST
$00002000 constant OTG_OTG_GINTMSK_ENUMDNEM                         \ ENUMDNEM
$00004000 constant OTG_OTG_GINTMSK_ISOODRPM                         \ ISOODRPM
$00008000 constant OTG_OTG_GINTMSK_EOPFM                            \ EOPFM
$00040000 constant OTG_OTG_GINTMSK_IEPINT                           \ IEPINT
$00080000 constant OTG_OTG_GINTMSK_OEPINT                           \ OEPINT
$00100000 constant OTG_OTG_GINTMSK_IISOIXFRM                        \ IISOIXFRM
$00200000 constant OTG_OTG_GINTMSK_IPXFRM                           \ IPXFRM
$00400000 constant OTG_OTG_GINTMSK_FSUSPM                           \ FSUSPM
$00800000 constant OTG_OTG_GINTMSK_RSTDETM                          \ RSTDETM
$01000000 constant OTG_OTG_GINTMSK_PRTIM                            \ PRTIM
$02000000 constant OTG_OTG_GINTMSK_HCIM                             \ HCIM
$04000000 constant OTG_OTG_GINTMSK_PTXFEM                           \ PTXFEM
$08000000 constant OTG_OTG_GINTMSK_LPMINTM                          \ LPMINTM
$10000000 constant OTG_OTG_GINTMSK_CIDSCHGM                         \ CIDSCHGM
$20000000 constant OTG_OTG_GINTMSK_DISCINT                          \ DISCINT
$40000000 constant OTG_OTG_GINTMSK_SRQIM                            \ SRQIM
$80000000 constant OTG_OTG_GINTMSK_WUIM                             \ WUIM


\
\ @brief This description is for register OTG_GRXSTSR in Device mode. A read to the receive status debug read register returns the contents of the top of the receive FIFO. The core ignores the receive status read when the receive FIFO is empty and returns a value of 0x00000000.
\ Address offset: 0x1C
\ Reset value: 0x00000000
\

$0000000f constant OTG_OTG_GRXSTSR_EPNUM                            \ EPNUM
$00007ff0 constant OTG_OTG_GRXSTSR_BCNT                             \ BCNT
$00018000 constant OTG_OTG_GRXSTSR_DPID                             \ DPID
$001e0000 constant OTG_OTG_GRXSTSR_PKTSTS                           \ PKTSTS
$01e00000 constant OTG_OTG_GRXSTSR_FRMNUM                           \ FRMNUM
$08000000 constant OTG_OTG_GRXSTSR_STSPHST                          \ STSPHST


\
\ @brief This description is for register OTG_GRXSTSP in Device mode. Similarly to OTG_GRXSTSR (receive status debug read register) where a read returns the contents of the top of the receive FIFO, a read to OTG_GRXSTSP (receive status read and pop register) additionally pops the top data entry out of the Rx FIFO. The core ignores the receive status pop/read when the receive FIFO is empty and returns a value of 0x00000000. The application must only pop the receive status FIFO when the receive FIFO non-empty bit of the core interrupt register (RXFLVL bit in OTG_GINTSTS) is asserted.
\ Address offset: 0x20
\ Reset value: 0x00000000
\

$0000000f constant OTG_OTG_GRXSTSP_EPNUM                            \ EPNUM
$00007ff0 constant OTG_OTG_GRXSTSP_BCNT                             \ BCNT
$00018000 constant OTG_OTG_GRXSTSP_DPID                             \ DPID
$001e0000 constant OTG_OTG_GRXSTSP_PKTSTS                           \ PKTSTS
$01e00000 constant OTG_OTG_GRXSTSP_FRMNUM                           \ FRMNUM
$08000000 constant OTG_OTG_GRXSTSP_STSPHST                          \ STSPHST


\
\ @brief The application can program the RAM size that must be allocated to the Rx FIFO.
\ Address offset: 0x24
\ Reset value: 0x00000400
\

$0000ffff constant OTG_OTG_GRXFSIZ_RXFD                             \ RXFD


\
\ @brief Host mode
\ Address offset: 0x28
\ Reset value: 0x02000200
\

$0000ffff constant OTG_OTG_HNPTXFSIZ_NPTXFSA                        \ NPTXFSA
$ffff0000 constant OTG_OTG_HNPTXFSIZ_NPTXFD                         \ NPTXFD


\
\ @brief In device mode, this register is not valid. This read-only register contains the free space information for the non-periodic Tx FIFO and the non-periodic transmit request queue.
\ Address offset: 0x2C
\ Reset value: 0x00080400
\

$0000ffff constant OTG_OTG_HNPTXSTS_NPTXFSAV                        \ NPTXFSAV
$00ff0000 constant OTG_OTG_HNPTXSTS_NPTQXSAV                        \ NPTQXSAV
$7f000000 constant OTG_OTG_HNPTXSTS_NPTXQTOP                        \ NPTXQTOP


\
\ @brief OTG general core configuration register
\ Address offset: 0x38
\ Reset value: 0x00000000
\

$00000002 constant OTG_OTG_GCCFG_PDET                               \ PDET
$00000004 constant OTG_OTG_GCCFG_SDET                               \ SDET
$00000008 constant OTG_OTG_GCCFG_PS2DET                             \ PS2DET
$00010000 constant OTG_OTG_GCCFG_PWRDWN                             \ PWRDWN
$00020000 constant OTG_OTG_GCCFG_BCDEN                              \ BCDEN
$00080000 constant OTG_OTG_GCCFG_PDEN                               \ PDEN
$00100000 constant OTG_OTG_GCCFG_SDEN                               \ SDEN
$00200000 constant OTG_OTG_GCCFG_VBDEN                              \ VBDEN
$00400000 constant OTG_OTG_GCCFG_IDEN                               \ IDEN


\
\ @brief This is a register containing the Product ID as reset value.
\ Address offset: 0x3C
\ Reset value: 0x00004000
\

$00000000 constant OTG_OTG_CID_PRODUCT_ID                           \ PRODUCT_ID


\
\ @brief OTG core LPM configuration register
\ Address offset: 0x54
\ Reset value: 0x00000000
\

$00000001 constant OTG_OTG_GLPMCFG_LPMEN                            \ LPMEN
$00000002 constant OTG_OTG_GLPMCFG_LPMACK                           \ LPMACK
$0000003c constant OTG_OTG_GLPMCFG_BESL                             \ BESL
$00000040 constant OTG_OTG_GLPMCFG_REMWAKE                          \ REMWAKE
$00000080 constant OTG_OTG_GLPMCFG_L1SSEN                           \ L1SSEN
$00000f00 constant OTG_OTG_GLPMCFG_BESLTHRS                         \ BESLTHRS
$00001000 constant OTG_OTG_GLPMCFG_L1DSEN                           \ L1DSEN
$00006000 constant OTG_OTG_GLPMCFG_LPMRSP                           \ LPMRSP
$00008000 constant OTG_OTG_GLPMCFG_SLPSTS                           \ SLPSTS
$00010000 constant OTG_OTG_GLPMCFG_L1RSMOK                          \ L1RSMOK
$001e0000 constant OTG_OTG_GLPMCFG_LPMCHIDX                         \ LPMCHIDX
$00e00000 constant OTG_OTG_GLPMCFG_LPMRCNT                          \ LPMRCNT
$01000000 constant OTG_OTG_GLPMCFG_SNDLPM                           \ SNDLPM
$0e000000 constant OTG_OTG_GLPMCFG_LPMRCNTSTS                       \ LPMRCNTSTS
$10000000 constant OTG_OTG_GLPMCFG_ENBESL                           \ ENBESL


\
\ @brief OTG host periodic transmit FIFO size register
\ Address offset: 0x100
\ Reset value: 0x02000400
\

$0000ffff constant OTG_OTG_HPTXFSIZ_PTXSA                           \ PTXSA
$ffff0000 constant OTG_OTG_HPTXFSIZ_PTXFSIZ                         \ PTXFSIZ


\
\ @brief OTG device IN endpoint transmit FIFO 1 size register
\ Address offset: 0x104
\ Reset value: 0x02000400
\

$0000ffff constant OTG_OTG_DIEPTXF1_INEPTXSA                        \ INEPTXSA
$ffff0000 constant OTG_OTG_DIEPTXF1_INEPTXFD                        \ INEPTXFD


\
\ @brief OTG device IN endpoint transmit FIFO 2 size register
\ Address offset: 0x108
\ Reset value: 0x02000400
\

$0000ffff constant OTG_OTG_DIEPTXF2_INEPTXSA                        \ INEPTXSA
$ffff0000 constant OTG_OTG_DIEPTXF2_INEPTXFD                        \ INEPTXFD


\
\ @brief OTG device IN endpoint transmit FIFO 3 size register
\ Address offset: 0x10C
\ Reset value: 0x02000400
\

$0000ffff constant OTG_OTG_DIEPTXF3_INEPTXSA                        \ INEPTXSA
$ffff0000 constant OTG_OTG_DIEPTXF3_INEPTXFD                        \ INEPTXFD


\
\ @brief OTG device IN endpoint transmit FIFO 4 size register
\ Address offset: 0x110
\ Reset value: 0x02000400
\

$0000ffff constant OTG_OTG_DIEPTXF4_INEPTXSA                        \ INEPTXSA
$ffff0000 constant OTG_OTG_DIEPTXF4_INEPTXFD                        \ INEPTXFD


\
\ @brief OTG device IN endpoint transmit FIFO 5 size register
\ Address offset: 0x114
\ Reset value: 0x02000400
\

$0000ffff constant OTG_OTG_DIEPTXF5_INEPTXSA                        \ INEPTXSA
$ffff0000 constant OTG_OTG_DIEPTXF5_INEPTXFD                        \ INEPTXFD


\
\ @brief OTG device IN endpoint transmit FIFO 6 size register
\ Address offset: 0x118
\ Reset value: 0x02000400
\

$0000ffff constant OTG_OTG_DIEPTXF6_INEPTXSA                        \ INEPTXSA
$ffff0000 constant OTG_OTG_DIEPTXF6_INEPTXFD                        \ INEPTXFD


\
\ @brief OTG device IN endpoint transmit FIFO 7 size register
\ Address offset: 0x11C
\ Reset value: 0x02000400
\

$0000ffff constant OTG_OTG_DIEPTXF7_INEPTXSA                        \ INEPTXSA
$ffff0000 constant OTG_OTG_DIEPTXF7_INEPTXFD                        \ INEPTXFD


\
\ @brief OTG device IN endpoint transmit FIFO 8 size register
\ Address offset: 0x120
\ Reset value: 0x02000400
\

$0000ffff constant OTG_OTG_DIEPTXF8_INEPTXSA                        \ INEPTXSA
$ffff0000 constant OTG_OTG_DIEPTXF8_INEPTXFD                        \ INEPTXFD


\
\ @brief This register configures the core after power-on. Do not make changes to this register after initializing the host.
\ Address offset: 0x400
\ Reset value: 0x00000000
\

$00000003 constant OTG_OTG_HCFG_FSLSPCS                             \ FSLSPCS
$00000004 constant OTG_OTG_HCFG_FSLSS                               \ FSLSS
$00800000 constant OTG_OTG_HCFG_DESCDMA                             \ DESCDMA
$03000000 constant OTG_OTG_HCFG_FRLSTEN                             \ FRLSTEN
$04000000 constant OTG_OTG_HCFG_PERSSCHEDENA                        \ PERSSCHEDENA


\
\ @brief This register stores the frame interval information for the current speed to which the OTG controller has enumerated.
\ Address offset: 0x404
\ Reset value: 0x0000EA60
\

$0000ffff constant OTG_OTG_HFIR_FRIVL                               \ FRIVL
$00010000 constant OTG_OTG_HFIR_RLDCTRL                             \ RLDCTRL


\
\ @brief This register indicates the current frame number. It also indicates the time remaining (in terms of the number of PHY clocks) in the current frame.
\ Address offset: 0x408
\ Reset value: 0x00003FFF
\

$0000ffff constant OTG_OTG_HFNUM_FRNUM                              \ FRNUM
$ffff0000 constant OTG_OTG_HFNUM_FTREM                              \ FTREM


\
\ @brief This read-only register contains the free space information for the periodic Tx FIFO and the periodic transmit request queue.
\ Address offset: 0x410
\ Reset value: 0x00080100
\

$0000ffff constant OTG_OTG_HPTXSTS_PTXFSAVL                         \ PTXFSAVL
$00ff0000 constant OTG_OTG_HPTXSTS_PTXQSAV                          \ PTXQSAV
$ff000000 constant OTG_OTG_HPTXSTS_PTXQTOP                          \ PTXQTOP


\
\ @brief When a significant event occurs on a channel, the host all channels interrupt register interrupts the application using the host channels interrupt bit of the core interrupt register (HCINT bit in OTG_GINTSTS). This is shown in Figure724. There is one interrupt bit per channel, up to a maximum of 16 bits. Bits in this register are set and cleared when the application sets and clears bits in the corresponding host channel-x interrupt register.
\ Address offset: 0x414
\ Reset value: 0x00000000
\

$0000ffff constant OTG_OTG_HAINT_HAINT                              \ HAINT


\
\ @brief The host all channel interrupt mask register works with the host all channel interrupt register to interrupt the application when an event occurs on a channel. There is one interrupt mask bit per channel, up to a maximum of 16 bits.
\ Address offset: 0x418
\ Reset value: 0x00000000
\

$0000ffff constant OTG_OTG_HAINTMSK_HAINTM                          \ HAINTM


\
\ @brief This register holds the starting address of the frame list information (scatter/gather mode).
\ Address offset: 0x41C
\ Reset value: 0x00000000
\

$00000000 constant OTG_OTG_HFLBADDR_HFLBADDR                        \ HFLBADDR


\
\ @brief This register is available only in host mode. Currently, the OTG host supports only one port. A single register holds USB port-related information such as USB reset, enable, suspend, resume, connect status, and test mode for each port. It is shown in Figure724. The rc_w1 bits in this register can trigger an interrupt to the application through the host port interrupt bit of the core interrupt register (HPRTINT bit in OTG_GINTSTS). On a port interrupt, the application must read this register and clear the bit that caused the interrupt. For the rc_w1 bits, the application must write a 1 to the bit to clear the interrupt.
\ Address offset: 0x440
\ Reset value: 0x00000000
\

$00000001 constant OTG_OTG_HPRT_PCSTS                               \ PCSTS
$00000002 constant OTG_OTG_HPRT_PCDET                               \ PCDET
$00000004 constant OTG_OTG_HPRT_PENA                                \ PENA
$00000008 constant OTG_OTG_HPRT_PENCHNG                             \ PENCHNG
$00000010 constant OTG_OTG_HPRT_POCA                                \ POCA
$00000020 constant OTG_OTG_HPRT_POCCHNG                             \ POCCHNG
$00000040 constant OTG_OTG_HPRT_PRES                                \ PRES
$00000080 constant OTG_OTG_HPRT_PSUSP                               \ PSUSP
$00000100 constant OTG_OTG_HPRT_PRST                                \ PRST
$00000c00 constant OTG_OTG_HPRT_PLSTS                               \ PLSTS
$00001000 constant OTG_OTG_HPRT_PPWR                                \ PPWR
$0001e000 constant OTG_OTG_HPRT_PTCTL                               \ PTCTL
$00060000 constant OTG_OTG_HPRT_PSPD                                \ PSPD


\
\ @brief OTG host channel 0 characteristics register
\ Address offset: 0x500
\ Reset value: 0x00000000
\

$000007ff constant OTG_OTG_HCCHAR0_MPSIZ                            \ MPSIZ
$00007800 constant OTG_OTG_HCCHAR0_EPNUM                            \ EPNUM
$00008000 constant OTG_OTG_HCCHAR0_EPDIR                            \ EPDIR
$00020000 constant OTG_OTG_HCCHAR0_LSDEV                            \ LSDEV
$000c0000 constant OTG_OTG_HCCHAR0_EPTYP                            \ EPTYP
$00300000 constant OTG_OTG_HCCHAR0_MCNT                             \ MCNT
$1fc00000 constant OTG_OTG_HCCHAR0_DAD                              \ DAD
$40000000 constant OTG_OTG_HCCHAR0_CHDIS                            \ CHDIS
$80000000 constant OTG_OTG_HCCHAR0_CHENA                            \ CHENA


\
\ @brief OTG host channel 0 split control register
\ Address offset: 0x504
\ Reset value: 0x00000000
\

$0000007f constant OTG_OTG_HCSPLT0_PRTADDR                          \ PRTADDR
$00003f80 constant OTG_OTG_HCSPLT0_HUBADDR                          \ HUBADDR
$0000c000 constant OTG_OTG_HCSPLT0_XACTPOS                          \ XACTPOS
$00010000 constant OTG_OTG_HCSPLT0_COMPLSPLT                        \ COMPLSPLT
$80000000 constant OTG_OTG_HCSPLT0_SPLITEN                          \ SPLITEN


\
\ @brief This register indicates the status of a channel with respect to USB- and AHB-related events. It is shown in Figure724. The application must read this register when the host channels interrupt bit in the core interrupt register (HCINT bit in OTG_GINTSTS) is set. Before the application can read this register, it must first read the host all channels interrupt (OTG_HAINT) register to get the exact channel number for the host channel-x interrupt register. The application must clear the appropriate bit in this register to clear the corresponding bits in the OTG_HAINT and OTG_GINTSTS registers.
\ Address offset: 0x508
\ Reset value: 0x00000000
\

$00000001 constant OTG_OTG_HCINT0_XFRC                              \ XFRC
$00000002 constant OTG_OTG_HCINT0_CHH                               \ CHH
$00000004 constant OTG_OTG_HCINT0_AHBERR                            \ AHBERR
$00000008 constant OTG_OTG_HCINT0_STALL                             \ STALL
$00000010 constant OTG_OTG_HCINT0_NAK                               \ NAK
$00000020 constant OTG_OTG_HCINT0_ACK                               \ ACK
$00000040 constant OTG_OTG_HCINT0_NYET                              \ NYET
$00000080 constant OTG_OTG_HCINT0_TXERR                             \ TXERR
$00000100 constant OTG_OTG_HCINT0_BBERR                             \ BBERR
$00000200 constant OTG_OTG_HCINT0_FRMOR                             \ FRMOR
$00000400 constant OTG_OTG_HCINT0_DTERR                             \ DTERR
$00000800 constant OTG_OTG_HCINT0_BNA                               \ BNA
$00001000 constant OTG_OTG_HCINT0_XCSXACTERR                        \ XCSXACTERR
$00002000 constant OTG_OTG_HCINT0_DESCLSTROLL                       \ DESCLSTROLL


\
\ @brief This register reflects the mask for each channel status described in the previous section.
\ Address offset: 0x50C
\ Reset value: 0x00000000
\

$00000001 constant OTG_OTG_HCINTMSK0_XFRCM                          \ XFRCM
$00000002 constant OTG_OTG_HCINTMSK0_CHHM                           \ CHHM
$00000004 constant OTG_OTG_HCINTMSK0_AHBERRM                        \ AHBERRM
$00000008 constant OTG_OTG_HCINTMSK0_STALLM                         \ STALLM
$00000010 constant OTG_OTG_HCINTMSK0_NAKM                           \ NAKM
$00000020 constant OTG_OTG_HCINTMSK0_ACKM                           \ ACKM
$00000040 constant OTG_OTG_HCINTMSK0_NYET                           \ NYET
$00000080 constant OTG_OTG_HCINTMSK0_TXERRM                         \ TXERRM
$00000100 constant OTG_OTG_HCINTMSK0_BBERRM                         \ BBERRM
$00000200 constant OTG_OTG_HCINTMSK0_FRMORM                         \ FRMORM
$00000400 constant OTG_OTG_HCINTMSK0_DTERRM                         \ DTERRM
$00000800 constant OTG_OTG_HCINTMSK0_BNAMSK                         \ BNAMSK
$00002000 constant OTG_OTG_HCINTMSK0_DESCLSTROLLMSK                 \ DESCLSTROLLMSK


\
\ @brief OTG host channel 0 transfer size register
\ Address offset: 0x510
\ Reset value: 0x00000000
\

$0007ffff constant OTG_OTG_HCTSIZ0_XFRSIZ                           \ XFRSIZ
$1ff80000 constant OTG_OTG_HCTSIZ0_PKTCNT                           \ PKTCNT
$60000000 constant OTG_OTG_HCTSIZ0_DPID                             \ DPID


\
\ @brief OTG host channel 0 DMA address register in buffer DMA [alternate]
\ Address offset: 0x514
\ Reset value: 0x00000000
\

$00000000 constant OTG_OTG_HCDMA0_DMAADDR                           \ DMAADDR


\
\ @brief OTG host channel-n DMA address buffer register
\ Address offset: 0x51C
\ Reset value: 0x00000000
\

$00000000 constant OTG_OTG_HCDMAB0_HCDMAB                           \ HCDMAB


\
\ @brief OTG host channel 1 characteristics register
\ Address offset: 0x520
\ Reset value: 0x00000000
\

$000007ff constant OTG_OTG_HCCHAR1_MPSIZ                            \ MPSIZ
$00007800 constant OTG_OTG_HCCHAR1_EPNUM                            \ EPNUM
$00008000 constant OTG_OTG_HCCHAR1_EPDIR                            \ EPDIR
$00020000 constant OTG_OTG_HCCHAR1_LSDEV                            \ LSDEV
$000c0000 constant OTG_OTG_HCCHAR1_EPTYP                            \ EPTYP
$00300000 constant OTG_OTG_HCCHAR1_MCNT                             \ MCNT
$1fc00000 constant OTG_OTG_HCCHAR1_DAD                              \ DAD
$40000000 constant OTG_OTG_HCCHAR1_CHDIS                            \ CHDIS
$80000000 constant OTG_OTG_HCCHAR1_CHENA                            \ CHENA


\
\ @brief OTG host channel 1 split control register
\ Address offset: 0x524
\ Reset value: 0x00000000
\

$0000007f constant OTG_OTG_HCSPLT1_PRTADDR                          \ PRTADDR
$00003f80 constant OTG_OTG_HCSPLT1_HUBADDR                          \ HUBADDR
$0000c000 constant OTG_OTG_HCSPLT1_XACTPOS                          \ XACTPOS
$00010000 constant OTG_OTG_HCSPLT1_COMPLSPLT                        \ COMPLSPLT
$80000000 constant OTG_OTG_HCSPLT1_SPLITEN                          \ SPLITEN


\
\ @brief This register indicates the status of a channel with respect to USB- and AHB-related events. It is shown in Figure724. The application must read this register when the host channels interrupt bit in the core interrupt register (HCINT bit in OTG_GINTSTS) is set. Before the application can read this register, it must first read the host all channels interrupt (OTG_HAINT) register to get the exact channel number for the host channel-x interrupt register. The application must clear the appropriate bit in this register to clear the corresponding bits in the OTG_HAINT and OTG_GINTSTS registers.
\ Address offset: 0x528
\ Reset value: 0x00000000
\

$00000001 constant OTG_OTG_HCINT1_XFRC                              \ XFRC
$00000002 constant OTG_OTG_HCINT1_CHH                               \ CHH
$00000004 constant OTG_OTG_HCINT1_AHBERR                            \ AHBERR
$00000008 constant OTG_OTG_HCINT1_STALL                             \ STALL
$00000010 constant OTG_OTG_HCINT1_NAK                               \ NAK
$00000020 constant OTG_OTG_HCINT1_ACK                               \ ACK
$00000040 constant OTG_OTG_HCINT1_NYET                              \ NYET
$00000080 constant OTG_OTG_HCINT1_TXERR                             \ TXERR
$00000100 constant OTG_OTG_HCINT1_BBERR                             \ BBERR
$00000200 constant OTG_OTG_HCINT1_FRMOR                             \ FRMOR
$00000400 constant OTG_OTG_HCINT1_DTERR                             \ DTERR
$00000800 constant OTG_OTG_HCINT1_BNA                               \ BNA
$00001000 constant OTG_OTG_HCINT1_XCSXACTERR                        \ XCSXACTERR
$00002000 constant OTG_OTG_HCINT1_DESCLSTROLL                       \ DESCLSTROLL


\
\ @brief This register reflects the mask for each channel status described in the previous section.
\ Address offset: 0x52C
\ Reset value: 0x00000000
\

$00000001 constant OTG_OTG_HCINTMSK1_XFRCM                          \ XFRCM
$00000002 constant OTG_OTG_HCINTMSK1_CHHM                           \ CHHM
$00000004 constant OTG_OTG_HCINTMSK1_AHBERRM                        \ AHBERRM
$00000008 constant OTG_OTG_HCINTMSK1_STALLM                         \ STALLM
$00000010 constant OTG_OTG_HCINTMSK1_NAKM                           \ NAKM
$00000020 constant OTG_OTG_HCINTMSK1_ACKM                           \ ACKM
$00000040 constant OTG_OTG_HCINTMSK1_NYET                           \ NYET
$00000080 constant OTG_OTG_HCINTMSK1_TXERRM                         \ TXERRM
$00000100 constant OTG_OTG_HCINTMSK1_BBERRM                         \ BBERRM
$00000200 constant OTG_OTG_HCINTMSK1_FRMORM                         \ FRMORM
$00000400 constant OTG_OTG_HCINTMSK1_DTERRM                         \ DTERRM
$00000800 constant OTG_OTG_HCINTMSK1_BNAMSK                         \ BNAMSK
$00002000 constant OTG_OTG_HCINTMSK1_DESCLSTROLLMSK                 \ DESCLSTROLLMSK


\
\ @brief OTG host channel 1 transfer size register
\ Address offset: 0x530
\ Reset value: 0x00000000
\

$0007ffff constant OTG_OTG_HCTSIZ1_XFRSIZ                           \ XFRSIZ
$1ff80000 constant OTG_OTG_HCTSIZ1_PKTCNT                           \ PKTCNT
$60000000 constant OTG_OTG_HCTSIZ1_DPID                             \ DPID


\
\ @brief OTG host channel 1 DMA address register in buffer DMA [alternate]
\ Address offset: 0x534
\ Reset value: 0x00000000
\

$00000000 constant OTG_OTG_HCDMA1_DMAADDR                           \ DMAADDR


\
\ @brief OTG host channel-n DMA address buffer register
\ Address offset: 0x53C
\ Reset value: 0x00000000
\

$00000000 constant OTG_OTG_HCDMAB1_HCDMAB                           \ HCDMAB


\
\ @brief OTG host channel 2 characteristics register
\ Address offset: 0x540
\ Reset value: 0x00000000
\

$000007ff constant OTG_OTG_HCCHAR2_MPSIZ                            \ MPSIZ
$00007800 constant OTG_OTG_HCCHAR2_EPNUM                            \ EPNUM
$00008000 constant OTG_OTG_HCCHAR2_EPDIR                            \ EPDIR
$00020000 constant OTG_OTG_HCCHAR2_LSDEV                            \ LSDEV
$000c0000 constant OTG_OTG_HCCHAR2_EPTYP                            \ EPTYP
$00300000 constant OTG_OTG_HCCHAR2_MCNT                             \ MCNT
$1fc00000 constant OTG_OTG_HCCHAR2_DAD                              \ DAD
$40000000 constant OTG_OTG_HCCHAR2_CHDIS                            \ CHDIS
$80000000 constant OTG_OTG_HCCHAR2_CHENA                            \ CHENA


\
\ @brief OTG host channel 2 split control register
\ Address offset: 0x544
\ Reset value: 0x00000000
\

$0000007f constant OTG_OTG_HCSPLT2_PRTADDR                          \ PRTADDR
$00003f80 constant OTG_OTG_HCSPLT2_HUBADDR                          \ HUBADDR
$0000c000 constant OTG_OTG_HCSPLT2_XACTPOS                          \ XACTPOS
$00010000 constant OTG_OTG_HCSPLT2_COMPLSPLT                        \ COMPLSPLT
$80000000 constant OTG_OTG_HCSPLT2_SPLITEN                          \ SPLITEN


\
\ @brief This register indicates the status of a channel with respect to USB- and AHB-related events. It is shown in Figure724. The application must read this register when the host channels interrupt bit in the core interrupt register (HCINT bit in OTG_GINTSTS) is set. Before the application can read this register, it must first read the host all channels interrupt (OTG_HAINT) register to get the exact channel number for the host channel-x interrupt register. The application must clear the appropriate bit in this register to clear the corresponding bits in the OTG_HAINT and OTG_GINTSTS registers.
\ Address offset: 0x548
\ Reset value: 0x00000000
\

$00000001 constant OTG_OTG_HCINT2_XFRC                              \ XFRC
$00000002 constant OTG_OTG_HCINT2_CHH                               \ CHH
$00000004 constant OTG_OTG_HCINT2_AHBERR                            \ AHBERR
$00000008 constant OTG_OTG_HCINT2_STALL                             \ STALL
$00000010 constant OTG_OTG_HCINT2_NAK                               \ NAK
$00000020 constant OTG_OTG_HCINT2_ACK                               \ ACK
$00000040 constant OTG_OTG_HCINT2_NYET                              \ NYET
$00000080 constant OTG_OTG_HCINT2_TXERR                             \ TXERR
$00000100 constant OTG_OTG_HCINT2_BBERR                             \ BBERR
$00000200 constant OTG_OTG_HCINT2_FRMOR                             \ FRMOR
$00000400 constant OTG_OTG_HCINT2_DTERR                             \ DTERR
$00000800 constant OTG_OTG_HCINT2_BNA                               \ BNA
$00001000 constant OTG_OTG_HCINT2_XCSXACTERR                        \ XCSXACTERR
$00002000 constant OTG_OTG_HCINT2_DESCLSTROLL                       \ DESCLSTROLL


\
\ @brief This register reflects the mask for each channel status described in the previous section.
\ Address offset: 0x54C
\ Reset value: 0x00000000
\

$00000001 constant OTG_OTG_HCINTMSK2_XFRCM                          \ XFRCM
$00000002 constant OTG_OTG_HCINTMSK2_CHHM                           \ CHHM
$00000004 constant OTG_OTG_HCINTMSK2_AHBERRM                        \ AHBERRM
$00000008 constant OTG_OTG_HCINTMSK2_STALLM                         \ STALLM
$00000010 constant OTG_OTG_HCINTMSK2_NAKM                           \ NAKM
$00000020 constant OTG_OTG_HCINTMSK2_ACKM                           \ ACKM
$00000040 constant OTG_OTG_HCINTMSK2_NYET                           \ NYET
$00000080 constant OTG_OTG_HCINTMSK2_TXERRM                         \ TXERRM
$00000100 constant OTG_OTG_HCINTMSK2_BBERRM                         \ BBERRM
$00000200 constant OTG_OTG_HCINTMSK2_FRMORM                         \ FRMORM
$00000400 constant OTG_OTG_HCINTMSK2_DTERRM                         \ DTERRM
$00000800 constant OTG_OTG_HCINTMSK2_BNAMSK                         \ BNAMSK
$00002000 constant OTG_OTG_HCINTMSK2_DESCLSTROLLMSK                 \ DESCLSTROLLMSK


\
\ @brief OTG host channel 2 transfer size register
\ Address offset: 0x550
\ Reset value: 0x00000000
\

$0007ffff constant OTG_OTG_HCTSIZ2_XFRSIZ                           \ XFRSIZ
$1ff80000 constant OTG_OTG_HCTSIZ2_PKTCNT                           \ PKTCNT
$60000000 constant OTG_OTG_HCTSIZ2_DPID                             \ DPID


\
\ @brief OTG host channel 2 DMA address register in buffer DMA [alternate]
\ Address offset: 0x554
\ Reset value: 0x00000000
\

$00000000 constant OTG_OTG_HCDMA2_DMAADDR                           \ DMAADDR


\
\ @brief OTG host channel-n DMA address buffer register
\ Address offset: 0x55C
\ Reset value: 0x00000000
\

$00000000 constant OTG_OTG_HCDMAB2_HCDMAB                           \ HCDMAB


\
\ @brief OTG host channel 3 characteristics register
\ Address offset: 0x560
\ Reset value: 0x00000000
\

$000007ff constant OTG_OTG_HCCHAR3_MPSIZ                            \ MPSIZ
$00007800 constant OTG_OTG_HCCHAR3_EPNUM                            \ EPNUM
$00008000 constant OTG_OTG_HCCHAR3_EPDIR                            \ EPDIR
$00020000 constant OTG_OTG_HCCHAR3_LSDEV                            \ LSDEV
$000c0000 constant OTG_OTG_HCCHAR3_EPTYP                            \ EPTYP
$00300000 constant OTG_OTG_HCCHAR3_MCNT                             \ MCNT
$1fc00000 constant OTG_OTG_HCCHAR3_DAD                              \ DAD
$40000000 constant OTG_OTG_HCCHAR3_CHDIS                            \ CHDIS
$80000000 constant OTG_OTG_HCCHAR3_CHENA                            \ CHENA


\
\ @brief OTG host channel 3 split control register
\ Address offset: 0x564
\ Reset value: 0x00000000
\

$0000007f constant OTG_OTG_HCSPLT3_PRTADDR                          \ PRTADDR
$00003f80 constant OTG_OTG_HCSPLT3_HUBADDR                          \ HUBADDR
$0000c000 constant OTG_OTG_HCSPLT3_XACTPOS                          \ XACTPOS
$00010000 constant OTG_OTG_HCSPLT3_COMPLSPLT                        \ COMPLSPLT
$80000000 constant OTG_OTG_HCSPLT3_SPLITEN                          \ SPLITEN


\
\ @brief This register indicates the status of a channel with respect to USB- and AHB-related events. It is shown in Figure724. The application must read this register when the host channels interrupt bit in the core interrupt register (HCINT bit in OTG_GINTSTS) is set. Before the application can read this register, it must first read the host all channels interrupt (OTG_HAINT) register to get the exact channel number for the host channel-x interrupt register. The application must clear the appropriate bit in this register to clear the corresponding bits in the OTG_HAINT and OTG_GINTSTS registers.
\ Address offset: 0x568
\ Reset value: 0x00000000
\

$00000001 constant OTG_OTG_HCINT3_XFRC                              \ XFRC
$00000002 constant OTG_OTG_HCINT3_CHH                               \ CHH
$00000004 constant OTG_OTG_HCINT3_AHBERR                            \ AHBERR
$00000008 constant OTG_OTG_HCINT3_STALL                             \ STALL
$00000010 constant OTG_OTG_HCINT3_NAK                               \ NAK
$00000020 constant OTG_OTG_HCINT3_ACK                               \ ACK
$00000040 constant OTG_OTG_HCINT3_NYET                              \ NYET
$00000080 constant OTG_OTG_HCINT3_TXERR                             \ TXERR
$00000100 constant OTG_OTG_HCINT3_BBERR                             \ BBERR
$00000200 constant OTG_OTG_HCINT3_FRMOR                             \ FRMOR
$00000400 constant OTG_OTG_HCINT3_DTERR                             \ DTERR
$00000800 constant OTG_OTG_HCINT3_BNA                               \ BNA
$00001000 constant OTG_OTG_HCINT3_XCSXACTERR                        \ XCSXACTERR
$00002000 constant OTG_OTG_HCINT3_DESCLSTROLL                       \ DESCLSTROLL


\
\ @brief This register reflects the mask for each channel status described in the previous section.
\ Address offset: 0x56C
\ Reset value: 0x00000000
\

$00000001 constant OTG_OTG_HCINTMSK3_XFRCM                          \ XFRCM
$00000002 constant OTG_OTG_HCINTMSK3_CHHM                           \ CHHM
$00000004 constant OTG_OTG_HCINTMSK3_AHBERRM                        \ AHBERRM
$00000008 constant OTG_OTG_HCINTMSK3_STALLM                         \ STALLM
$00000010 constant OTG_OTG_HCINTMSK3_NAKM                           \ NAKM
$00000020 constant OTG_OTG_HCINTMSK3_ACKM                           \ ACKM
$00000040 constant OTG_OTG_HCINTMSK3_NYET                           \ NYET
$00000080 constant OTG_OTG_HCINTMSK3_TXERRM                         \ TXERRM
$00000100 constant OTG_OTG_HCINTMSK3_BBERRM                         \ BBERRM
$00000200 constant OTG_OTG_HCINTMSK3_FRMORM                         \ FRMORM
$00000400 constant OTG_OTG_HCINTMSK3_DTERRM                         \ DTERRM
$00000800 constant OTG_OTG_HCINTMSK3_BNAMSK                         \ BNAMSK
$00002000 constant OTG_OTG_HCINTMSK3_DESCLSTROLLMSK                 \ DESCLSTROLLMSK


\
\ @brief OTG host channel 3 transfer size register
\ Address offset: 0x570
\ Reset value: 0x00000000
\

$0007ffff constant OTG_OTG_HCTSIZ3_XFRSIZ                           \ XFRSIZ
$1ff80000 constant OTG_OTG_HCTSIZ3_PKTCNT                           \ PKTCNT
$60000000 constant OTG_OTG_HCTSIZ3_DPID                             \ DPID


\
\ @brief OTG host channel 3 DMA address register in buffer DMA [alternate]
\ Address offset: 0x574
\ Reset value: 0x00000000
\

$00000000 constant OTG_OTG_HCDMA3_DMAADDR                           \ DMAADDR


\
\ @brief OTG host channel-n DMA address buffer register
\ Address offset: 0x57C
\ Reset value: 0x00000000
\

$00000000 constant OTG_OTG_HCDMAB3_HCDMAB                           \ HCDMAB


\
\ @brief OTG host channel 4 characteristics register
\ Address offset: 0x580
\ Reset value: 0x00000000
\

$000007ff constant OTG_OTG_HCCHAR4_MPSIZ                            \ MPSIZ
$00007800 constant OTG_OTG_HCCHAR4_EPNUM                            \ EPNUM
$00008000 constant OTG_OTG_HCCHAR4_EPDIR                            \ EPDIR
$00020000 constant OTG_OTG_HCCHAR4_LSDEV                            \ LSDEV
$000c0000 constant OTG_OTG_HCCHAR4_EPTYP                            \ EPTYP
$00300000 constant OTG_OTG_HCCHAR4_MCNT                             \ MCNT
$1fc00000 constant OTG_OTG_HCCHAR4_DAD                              \ DAD
$40000000 constant OTG_OTG_HCCHAR4_CHDIS                            \ CHDIS
$80000000 constant OTG_OTG_HCCHAR4_CHENA                            \ CHENA


\
\ @brief OTG host channel 4 split control register
\ Address offset: 0x584
\ Reset value: 0x00000000
\

$0000007f constant OTG_OTG_HCSPLT4_PRTADDR                          \ PRTADDR
$00003f80 constant OTG_OTG_HCSPLT4_HUBADDR                          \ HUBADDR
$0000c000 constant OTG_OTG_HCSPLT4_XACTPOS                          \ XACTPOS
$00010000 constant OTG_OTG_HCSPLT4_COMPLSPLT                        \ COMPLSPLT
$80000000 constant OTG_OTG_HCSPLT4_SPLITEN                          \ SPLITEN


\
\ @brief This register indicates the status of a channel with respect to USB- and AHB-related events. It is shown in Figure724. The application must read this register when the host channels interrupt bit in the core interrupt register (HCINT bit in OTG_GINTSTS) is set. Before the application can read this register, it must first read the host all channels interrupt (OTG_HAINT) register to get the exact channel number for the host channel-x interrupt register. The application must clear the appropriate bit in this register to clear the corresponding bits in the OTG_HAINT and OTG_GINTSTS registers.
\ Address offset: 0x588
\ Reset value: 0x00000000
\

$00000001 constant OTG_OTG_HCINT4_XFRC                              \ XFRC
$00000002 constant OTG_OTG_HCINT4_CHH                               \ CHH
$00000004 constant OTG_OTG_HCINT4_AHBERR                            \ AHBERR
$00000008 constant OTG_OTG_HCINT4_STALL                             \ STALL
$00000010 constant OTG_OTG_HCINT4_NAK                               \ NAK
$00000020 constant OTG_OTG_HCINT4_ACK                               \ ACK
$00000040 constant OTG_OTG_HCINT4_NYET                              \ NYET
$00000080 constant OTG_OTG_HCINT4_TXERR                             \ TXERR
$00000100 constant OTG_OTG_HCINT4_BBERR                             \ BBERR
$00000200 constant OTG_OTG_HCINT4_FRMOR                             \ FRMOR
$00000400 constant OTG_OTG_HCINT4_DTERR                             \ DTERR
$00000800 constant OTG_OTG_HCINT4_BNA                               \ BNA
$00001000 constant OTG_OTG_HCINT4_XCSXACTERR                        \ XCSXACTERR
$00002000 constant OTG_OTG_HCINT4_DESCLSTROLL                       \ DESCLSTROLL


\
\ @brief This register reflects the mask for each channel status described in the previous section.
\ Address offset: 0x58C
\ Reset value: 0x00000000
\

$00000001 constant OTG_OTG_HCINTMSK4_XFRCM                          \ XFRCM
$00000002 constant OTG_OTG_HCINTMSK4_CHHM                           \ CHHM
$00000004 constant OTG_OTG_HCINTMSK4_AHBERRM                        \ AHBERRM
$00000008 constant OTG_OTG_HCINTMSK4_STALLM                         \ STALLM
$00000010 constant OTG_OTG_HCINTMSK4_NAKM                           \ NAKM
$00000020 constant OTG_OTG_HCINTMSK4_ACKM                           \ ACKM
$00000040 constant OTG_OTG_HCINTMSK4_NYET                           \ NYET
$00000080 constant OTG_OTG_HCINTMSK4_TXERRM                         \ TXERRM
$00000100 constant OTG_OTG_HCINTMSK4_BBERRM                         \ BBERRM
$00000200 constant OTG_OTG_HCINTMSK4_FRMORM                         \ FRMORM
$00000400 constant OTG_OTG_HCINTMSK4_DTERRM                         \ DTERRM
$00000800 constant OTG_OTG_HCINTMSK4_BNAMSK                         \ BNAMSK
$00002000 constant OTG_OTG_HCINTMSK4_DESCLSTROLLMSK                 \ DESCLSTROLLMSK


\
\ @brief OTG host channel 4 transfer size register
\ Address offset: 0x590
\ Reset value: 0x00000000
\

$0007ffff constant OTG_OTG_HCTSIZ4_XFRSIZ                           \ XFRSIZ
$1ff80000 constant OTG_OTG_HCTSIZ4_PKTCNT                           \ PKTCNT
$60000000 constant OTG_OTG_HCTSIZ4_DPID                             \ DPID


\
\ @brief OTG host channel 4 DMA address register in buffer DMA [alternate]
\ Address offset: 0x594
\ Reset value: 0x00000000
\

$00000000 constant OTG_OTG_HCDMA4_DMAADDR                           \ DMAADDR


\
\ @brief OTG host channel-n DMA address buffer register
\ Address offset: 0x59C
\ Reset value: 0x00000000
\

$00000000 constant OTG_OTG_HCDMAB4_HCDMAB                           \ HCDMAB


\
\ @brief OTG host channel 5 characteristics register
\ Address offset: 0x5A0
\ Reset value: 0x00000000
\

$000007ff constant OTG_OTG_HCCHAR5_MPSIZ                            \ MPSIZ
$00007800 constant OTG_OTG_HCCHAR5_EPNUM                            \ EPNUM
$00008000 constant OTG_OTG_HCCHAR5_EPDIR                            \ EPDIR
$00020000 constant OTG_OTG_HCCHAR5_LSDEV                            \ LSDEV
$000c0000 constant OTG_OTG_HCCHAR5_EPTYP                            \ EPTYP
$00300000 constant OTG_OTG_HCCHAR5_MCNT                             \ MCNT
$1fc00000 constant OTG_OTG_HCCHAR5_DAD                              \ DAD
$40000000 constant OTG_OTG_HCCHAR5_CHDIS                            \ CHDIS
$80000000 constant OTG_OTG_HCCHAR5_CHENA                            \ CHENA


\
\ @brief OTG host channel 5 split control register
\ Address offset: 0x5A4
\ Reset value: 0x00000000
\

$0000007f constant OTG_OTG_HCSPLT5_PRTADDR                          \ PRTADDR
$00003f80 constant OTG_OTG_HCSPLT5_HUBADDR                          \ HUBADDR
$0000c000 constant OTG_OTG_HCSPLT5_XACTPOS                          \ XACTPOS
$00010000 constant OTG_OTG_HCSPLT5_COMPLSPLT                        \ COMPLSPLT
$80000000 constant OTG_OTG_HCSPLT5_SPLITEN                          \ SPLITEN


\
\ @brief This register indicates the status of a channel with respect to USB- and AHB-related events. It is shown in Figure724. The application must read this register when the host channels interrupt bit in the core interrupt register (HCINT bit in OTG_GINTSTS) is set. Before the application can read this register, it must first read the host all channels interrupt (OTG_HAINT) register to get the exact channel number for the host channel-x interrupt register. The application must clear the appropriate bit in this register to clear the corresponding bits in the OTG_HAINT and OTG_GINTSTS registers.
\ Address offset: 0x5A8
\ Reset value: 0x00000000
\

$00000001 constant OTG_OTG_HCINT5_XFRC                              \ XFRC
$00000002 constant OTG_OTG_HCINT5_CHH                               \ CHH
$00000004 constant OTG_OTG_HCINT5_AHBERR                            \ AHBERR
$00000008 constant OTG_OTG_HCINT5_STALL                             \ STALL
$00000010 constant OTG_OTG_HCINT5_NAK                               \ NAK
$00000020 constant OTG_OTG_HCINT5_ACK                               \ ACK
$00000040 constant OTG_OTG_HCINT5_NYET                              \ NYET
$00000080 constant OTG_OTG_HCINT5_TXERR                             \ TXERR
$00000100 constant OTG_OTG_HCINT5_BBERR                             \ BBERR
$00000200 constant OTG_OTG_HCINT5_FRMOR                             \ FRMOR
$00000400 constant OTG_OTG_HCINT5_DTERR                             \ DTERR
$00000800 constant OTG_OTG_HCINT5_BNA                               \ BNA
$00001000 constant OTG_OTG_HCINT5_XCSXACTERR                        \ XCSXACTERR
$00002000 constant OTG_OTG_HCINT5_DESCLSTROLL                       \ DESCLSTROLL


\
\ @brief This register reflects the mask for each channel status described in the previous section.
\ Address offset: 0x5AC
\ Reset value: 0x00000000
\

$00000001 constant OTG_OTG_HCINTMSK5_XFRCM                          \ XFRCM
$00000002 constant OTG_OTG_HCINTMSK5_CHHM                           \ CHHM
$00000004 constant OTG_OTG_HCINTMSK5_AHBERRM                        \ AHBERRM
$00000008 constant OTG_OTG_HCINTMSK5_STALLM                         \ STALLM
$00000010 constant OTG_OTG_HCINTMSK5_NAKM                           \ NAKM
$00000020 constant OTG_OTG_HCINTMSK5_ACKM                           \ ACKM
$00000040 constant OTG_OTG_HCINTMSK5_NYET                           \ NYET
$00000080 constant OTG_OTG_HCINTMSK5_TXERRM                         \ TXERRM
$00000100 constant OTG_OTG_HCINTMSK5_BBERRM                         \ BBERRM
$00000200 constant OTG_OTG_HCINTMSK5_FRMORM                         \ FRMORM
$00000400 constant OTG_OTG_HCINTMSK5_DTERRM                         \ DTERRM
$00000800 constant OTG_OTG_HCINTMSK5_BNAMSK                         \ BNAMSK
$00002000 constant OTG_OTG_HCINTMSK5_DESCLSTROLLMSK                 \ DESCLSTROLLMSK


\
\ @brief OTG host channel 5 transfer size register
\ Address offset: 0x5B0
\ Reset value: 0x00000000
\

$0007ffff constant OTG_OTG_HCTSIZ5_XFRSIZ                           \ XFRSIZ
$1ff80000 constant OTG_OTG_HCTSIZ5_PKTCNT                           \ PKTCNT
$60000000 constant OTG_OTG_HCTSIZ5_DPID                             \ DPID


\
\ @brief OTG host channel 5 DMA address register in buffer DMA [alternate]
\ Address offset: 0x5B4
\ Reset value: 0x00000000
\

$00000000 constant OTG_OTG_HCDMA5_DMAADDR                           \ DMAADDR


\
\ @brief OTG host channel-n DMA address buffer register
\ Address offset: 0x5BC
\ Reset value: 0x00000000
\

$00000000 constant OTG_OTG_HCDMAB5_HCDMAB                           \ HCDMAB


\
\ @brief OTG host channel 6 characteristics register
\ Address offset: 0x5C0
\ Reset value: 0x00000000
\

$000007ff constant OTG_OTG_HCCHAR6_MPSIZ                            \ MPSIZ
$00007800 constant OTG_OTG_HCCHAR6_EPNUM                            \ EPNUM
$00008000 constant OTG_OTG_HCCHAR6_EPDIR                            \ EPDIR
$00020000 constant OTG_OTG_HCCHAR6_LSDEV                            \ LSDEV
$000c0000 constant OTG_OTG_HCCHAR6_EPTYP                            \ EPTYP
$00300000 constant OTG_OTG_HCCHAR6_MCNT                             \ MCNT
$1fc00000 constant OTG_OTG_HCCHAR6_DAD                              \ DAD
$40000000 constant OTG_OTG_HCCHAR6_CHDIS                            \ CHDIS
$80000000 constant OTG_OTG_HCCHAR6_CHENA                            \ CHENA


\
\ @brief OTG host channel 6 split control register
\ Address offset: 0x5C4
\ Reset value: 0x00000000
\

$0000007f constant OTG_OTG_HCSPLT6_PRTADDR                          \ PRTADDR
$00003f80 constant OTG_OTG_HCSPLT6_HUBADDR                          \ HUBADDR
$0000c000 constant OTG_OTG_HCSPLT6_XACTPOS                          \ XACTPOS
$00010000 constant OTG_OTG_HCSPLT6_COMPLSPLT                        \ COMPLSPLT
$80000000 constant OTG_OTG_HCSPLT6_SPLITEN                          \ SPLITEN


\
\ @brief This register indicates the status of a channel with respect to USB- and AHB-related events. It is shown in Figure724. The application must read this register when the host channels interrupt bit in the core interrupt register (HCINT bit in OTG_GINTSTS) is set. Before the application can read this register, it must first read the host all channels interrupt (OTG_HAINT) register to get the exact channel number for the host channel-x interrupt register. The application must clear the appropriate bit in this register to clear the corresponding bits in the OTG_HAINT and OTG_GINTSTS registers.
\ Address offset: 0x5C8
\ Reset value: 0x00000000
\

$00000001 constant OTG_OTG_HCINT6_XFRC                              \ XFRC
$00000002 constant OTG_OTG_HCINT6_CHH                               \ CHH
$00000004 constant OTG_OTG_HCINT6_AHBERR                            \ AHBERR
$00000008 constant OTG_OTG_HCINT6_STALL                             \ STALL
$00000010 constant OTG_OTG_HCINT6_NAK                               \ NAK
$00000020 constant OTG_OTG_HCINT6_ACK                               \ ACK
$00000040 constant OTG_OTG_HCINT6_NYET                              \ NYET
$00000080 constant OTG_OTG_HCINT6_TXERR                             \ TXERR
$00000100 constant OTG_OTG_HCINT6_BBERR                             \ BBERR
$00000200 constant OTG_OTG_HCINT6_FRMOR                             \ FRMOR
$00000400 constant OTG_OTG_HCINT6_DTERR                             \ DTERR
$00000800 constant OTG_OTG_HCINT6_BNA                               \ BNA
$00001000 constant OTG_OTG_HCINT6_XCSXACTERR                        \ XCSXACTERR
$00002000 constant OTG_OTG_HCINT6_DESCLSTROLL                       \ DESCLSTROLL


\
\ @brief This register reflects the mask for each channel status described in the previous section.
\ Address offset: 0x5CC
\ Reset value: 0x00000000
\

$00000001 constant OTG_OTG_HCINTMSK6_XFRCM                          \ XFRCM
$00000002 constant OTG_OTG_HCINTMSK6_CHHM                           \ CHHM
$00000004 constant OTG_OTG_HCINTMSK6_AHBERRM                        \ AHBERRM
$00000008 constant OTG_OTG_HCINTMSK6_STALLM                         \ STALLM
$00000010 constant OTG_OTG_HCINTMSK6_NAKM                           \ NAKM
$00000020 constant OTG_OTG_HCINTMSK6_ACKM                           \ ACKM
$00000040 constant OTG_OTG_HCINTMSK6_NYET                           \ NYET
$00000080 constant OTG_OTG_HCINTMSK6_TXERRM                         \ TXERRM
$00000100 constant OTG_OTG_HCINTMSK6_BBERRM                         \ BBERRM
$00000200 constant OTG_OTG_HCINTMSK6_FRMORM                         \ FRMORM
$00000400 constant OTG_OTG_HCINTMSK6_DTERRM                         \ DTERRM
$00000800 constant OTG_OTG_HCINTMSK6_BNAMSK                         \ BNAMSK
$00002000 constant OTG_OTG_HCINTMSK6_DESCLSTROLLMSK                 \ DESCLSTROLLMSK


\
\ @brief OTG host channel 6 transfer size register
\ Address offset: 0x5D0
\ Reset value: 0x00000000
\

$0007ffff constant OTG_OTG_HCTSIZ6_XFRSIZ                           \ XFRSIZ
$1ff80000 constant OTG_OTG_HCTSIZ6_PKTCNT                           \ PKTCNT
$60000000 constant OTG_OTG_HCTSIZ6_DPID                             \ DPID


\
\ @brief OTG host channel 6 DMA address register in buffer DMA [alternate]
\ Address offset: 0x5D4
\ Reset value: 0x00000000
\

$00000000 constant OTG_OTG_HCDMA6_DMAADDR                           \ DMAADDR


\
\ @brief OTG host channel-n DMA address buffer register
\ Address offset: 0x5DC
\ Reset value: 0x00000000
\

$00000000 constant OTG_OTG_HCDMAB6_HCDMAB                           \ HCDMAB


\
\ @brief OTG host channel 7 characteristics register
\ Address offset: 0x5E0
\ Reset value: 0x00000000
\

$000007ff constant OTG_OTG_HCCHAR7_MPSIZ                            \ MPSIZ
$00007800 constant OTG_OTG_HCCHAR7_EPNUM                            \ EPNUM
$00008000 constant OTG_OTG_HCCHAR7_EPDIR                            \ EPDIR
$00020000 constant OTG_OTG_HCCHAR7_LSDEV                            \ LSDEV
$000c0000 constant OTG_OTG_HCCHAR7_EPTYP                            \ EPTYP
$00300000 constant OTG_OTG_HCCHAR7_MCNT                             \ MCNT
$1fc00000 constant OTG_OTG_HCCHAR7_DAD                              \ DAD
$40000000 constant OTG_OTG_HCCHAR7_CHDIS                            \ CHDIS
$80000000 constant OTG_OTG_HCCHAR7_CHENA                            \ CHENA


\
\ @brief OTG host channel 7 split control register
\ Address offset: 0x5E4
\ Reset value: 0x00000000
\

$0000007f constant OTG_OTG_HCSPLT7_PRTADDR                          \ PRTADDR
$00003f80 constant OTG_OTG_HCSPLT7_HUBADDR                          \ HUBADDR
$0000c000 constant OTG_OTG_HCSPLT7_XACTPOS                          \ XACTPOS
$00010000 constant OTG_OTG_HCSPLT7_COMPLSPLT                        \ COMPLSPLT
$80000000 constant OTG_OTG_HCSPLT7_SPLITEN                          \ SPLITEN


\
\ @brief This register indicates the status of a channel with respect to USB- and AHB-related events. It is shown in Figure724. The application must read this register when the host channels interrupt bit in the core interrupt register (HCINT bit in OTG_GINTSTS) is set. Before the application can read this register, it must first read the host all channels interrupt (OTG_HAINT) register to get the exact channel number for the host channel-x interrupt register. The application must clear the appropriate bit in this register to clear the corresponding bits in the OTG_HAINT and OTG_GINTSTS registers.
\ Address offset: 0x5E8
\ Reset value: 0x00000000
\

$00000001 constant OTG_OTG_HCINT7_XFRC                              \ XFRC
$00000002 constant OTG_OTG_HCINT7_CHH                               \ CHH
$00000004 constant OTG_OTG_HCINT7_AHBERR                            \ AHBERR
$00000008 constant OTG_OTG_HCINT7_STALL                             \ STALL
$00000010 constant OTG_OTG_HCINT7_NAK                               \ NAK
$00000020 constant OTG_OTG_HCINT7_ACK                               \ ACK
$00000040 constant OTG_OTG_HCINT7_NYET                              \ NYET
$00000080 constant OTG_OTG_HCINT7_TXERR                             \ TXERR
$00000100 constant OTG_OTG_HCINT7_BBERR                             \ BBERR
$00000200 constant OTG_OTG_HCINT7_FRMOR                             \ FRMOR
$00000400 constant OTG_OTG_HCINT7_DTERR                             \ DTERR
$00000800 constant OTG_OTG_HCINT7_BNA                               \ BNA
$00001000 constant OTG_OTG_HCINT7_XCSXACTERR                        \ XCSXACTERR
$00002000 constant OTG_OTG_HCINT7_DESCLSTROLL                       \ DESCLSTROLL


\
\ @brief This register reflects the mask for each channel status described in the previous section.
\ Address offset: 0x5EC
\ Reset value: 0x00000000
\

$00000001 constant OTG_OTG_HCINTMSK7_XFRCM                          \ XFRCM
$00000002 constant OTG_OTG_HCINTMSK7_CHHM                           \ CHHM
$00000004 constant OTG_OTG_HCINTMSK7_AHBERRM                        \ AHBERRM
$00000008 constant OTG_OTG_HCINTMSK7_STALLM                         \ STALLM
$00000010 constant OTG_OTG_HCINTMSK7_NAKM                           \ NAKM
$00000020 constant OTG_OTG_HCINTMSK7_ACKM                           \ ACKM
$00000040 constant OTG_OTG_HCINTMSK7_NYET                           \ NYET
$00000080 constant OTG_OTG_HCINTMSK7_TXERRM                         \ TXERRM
$00000100 constant OTG_OTG_HCINTMSK7_BBERRM                         \ BBERRM
$00000200 constant OTG_OTG_HCINTMSK7_FRMORM                         \ FRMORM
$00000400 constant OTG_OTG_HCINTMSK7_DTERRM                         \ DTERRM
$00000800 constant OTG_OTG_HCINTMSK7_BNAMSK                         \ BNAMSK
$00002000 constant OTG_OTG_HCINTMSK7_DESCLSTROLLMSK                 \ DESCLSTROLLMSK


\
\ @brief OTG host channel 7 transfer size register
\ Address offset: 0x5F0
\ Reset value: 0x00000000
\

$0007ffff constant OTG_OTG_HCTSIZ7_XFRSIZ                           \ XFRSIZ
$1ff80000 constant OTG_OTG_HCTSIZ7_PKTCNT                           \ PKTCNT
$60000000 constant OTG_OTG_HCTSIZ7_DPID                             \ DPID


\
\ @brief OTG host channel 7 DMA address register in buffer DMA [alternate]
\ Address offset: 0x5F4
\ Reset value: 0x00000000
\

$00000000 constant OTG_OTG_HCDMA7_DMAADDR                           \ DMAADDR


\
\ @brief OTG host channel-n DMA address buffer register
\ Address offset: 0x5FC
\ Reset value: 0x00000000
\

$00000000 constant OTG_OTG_HCDMAB7_HCDMAB                           \ HCDMAB


\
\ @brief OTG host channel 8 characteristics register
\ Address offset: 0x600
\ Reset value: 0x00000000
\

$000007ff constant OTG_OTG_HCCHAR8_MPSIZ                            \ MPSIZ
$00007800 constant OTG_OTG_HCCHAR8_EPNUM                            \ EPNUM
$00008000 constant OTG_OTG_HCCHAR8_EPDIR                            \ EPDIR
$00020000 constant OTG_OTG_HCCHAR8_LSDEV                            \ LSDEV
$000c0000 constant OTG_OTG_HCCHAR8_EPTYP                            \ EPTYP
$00300000 constant OTG_OTG_HCCHAR8_MCNT                             \ MCNT
$1fc00000 constant OTG_OTG_HCCHAR8_DAD                              \ DAD
$40000000 constant OTG_OTG_HCCHAR8_CHDIS                            \ CHDIS
$80000000 constant OTG_OTG_HCCHAR8_CHENA                            \ CHENA


\
\ @brief OTG host channel 8 split control register
\ Address offset: 0x604
\ Reset value: 0x00000000
\

$0000007f constant OTG_OTG_HCSPLT8_PRTADDR                          \ PRTADDR
$00003f80 constant OTG_OTG_HCSPLT8_HUBADDR                          \ HUBADDR
$0000c000 constant OTG_OTG_HCSPLT8_XACTPOS                          \ XACTPOS
$00010000 constant OTG_OTG_HCSPLT8_COMPLSPLT                        \ COMPLSPLT
$80000000 constant OTG_OTG_HCSPLT8_SPLITEN                          \ SPLITEN


\
\ @brief This register indicates the status of a channel with respect to USB- and AHB-related events. It is shown in Figure724. The application must read this register when the host channels interrupt bit in the core interrupt register (HCINT bit in OTG_GINTSTS) is set. Before the application can read this register, it must first read the host all channels interrupt (OTG_HAINT) register to get the exact channel number for the host channel-x interrupt register. The application must clear the appropriate bit in this register to clear the corresponding bits in the OTG_HAINT and OTG_GINTSTS registers.
\ Address offset: 0x608
\ Reset value: 0x00000000
\

$00000001 constant OTG_OTG_HCINT8_XFRC                              \ XFRC
$00000002 constant OTG_OTG_HCINT8_CHH                               \ CHH
$00000004 constant OTG_OTG_HCINT8_AHBERR                            \ AHBERR
$00000008 constant OTG_OTG_HCINT8_STALL                             \ STALL
$00000010 constant OTG_OTG_HCINT8_NAK                               \ NAK
$00000020 constant OTG_OTG_HCINT8_ACK                               \ ACK
$00000040 constant OTG_OTG_HCINT8_NYET                              \ NYET
$00000080 constant OTG_OTG_HCINT8_TXERR                             \ TXERR
$00000100 constant OTG_OTG_HCINT8_BBERR                             \ BBERR
$00000200 constant OTG_OTG_HCINT8_FRMOR                             \ FRMOR
$00000400 constant OTG_OTG_HCINT8_DTERR                             \ DTERR
$00000800 constant OTG_OTG_HCINT8_BNA                               \ BNA
$00001000 constant OTG_OTG_HCINT8_XCSXACTERR                        \ XCSXACTERR
$00002000 constant OTG_OTG_HCINT8_DESCLSTROLL                       \ DESCLSTROLL


\
\ @brief This register reflects the mask for each channel status described in the previous section.
\ Address offset: 0x60C
\ Reset value: 0x00000000
\

$00000001 constant OTG_OTG_HCINTMSK8_XFRCM                          \ XFRCM
$00000002 constant OTG_OTG_HCINTMSK8_CHHM                           \ CHHM
$00000004 constant OTG_OTG_HCINTMSK8_AHBERRM                        \ AHBERRM
$00000008 constant OTG_OTG_HCINTMSK8_STALLM                         \ STALLM
$00000010 constant OTG_OTG_HCINTMSK8_NAKM                           \ NAKM
$00000020 constant OTG_OTG_HCINTMSK8_ACKM                           \ ACKM
$00000040 constant OTG_OTG_HCINTMSK8_NYET                           \ NYET
$00000080 constant OTG_OTG_HCINTMSK8_TXERRM                         \ TXERRM
$00000100 constant OTG_OTG_HCINTMSK8_BBERRM                         \ BBERRM
$00000200 constant OTG_OTG_HCINTMSK8_FRMORM                         \ FRMORM
$00000400 constant OTG_OTG_HCINTMSK8_DTERRM                         \ DTERRM
$00000800 constant OTG_OTG_HCINTMSK8_BNAMSK                         \ BNAMSK
$00002000 constant OTG_OTG_HCINTMSK8_DESCLSTROLLMSK                 \ DESCLSTROLLMSK


\
\ @brief OTG host channel 8 transfer size register
\ Address offset: 0x610
\ Reset value: 0x00000000
\

$0007ffff constant OTG_OTG_HCTSIZ8_XFRSIZ                           \ XFRSIZ
$1ff80000 constant OTG_OTG_HCTSIZ8_PKTCNT                           \ PKTCNT
$60000000 constant OTG_OTG_HCTSIZ8_DPID                             \ DPID


\
\ @brief OTG host channel 8 DMA address register in buffer DMA [alternate]
\ Address offset: 0x614
\ Reset value: 0x00000000
\

$00000000 constant OTG_OTG_HCDMA8_DMAADDR                           \ DMAADDR


\
\ @brief OTG host channel-n DMA address buffer register
\ Address offset: 0x61C
\ Reset value: 0x00000000
\

$00000000 constant OTG_OTG_HCDMAB8_HCDMAB                           \ HCDMAB


\
\ @brief OTG host channel 9 characteristics register
\ Address offset: 0x620
\ Reset value: 0x00000000
\

$000007ff constant OTG_OTG_HCCHAR9_MPSIZ                            \ MPSIZ
$00007800 constant OTG_OTG_HCCHAR9_EPNUM                            \ EPNUM
$00008000 constant OTG_OTG_HCCHAR9_EPDIR                            \ EPDIR
$00020000 constant OTG_OTG_HCCHAR9_LSDEV                            \ LSDEV
$000c0000 constant OTG_OTG_HCCHAR9_EPTYP                            \ EPTYP
$00300000 constant OTG_OTG_HCCHAR9_MCNT                             \ MCNT
$1fc00000 constant OTG_OTG_HCCHAR9_DAD                              \ DAD
$40000000 constant OTG_OTG_HCCHAR9_CHDIS                            \ CHDIS
$80000000 constant OTG_OTG_HCCHAR9_CHENA                            \ CHENA


\
\ @brief OTG host channel 9 split control register
\ Address offset: 0x624
\ Reset value: 0x00000000
\

$0000007f constant OTG_OTG_HCSPLT9_PRTADDR                          \ PRTADDR
$00003f80 constant OTG_OTG_HCSPLT9_HUBADDR                          \ HUBADDR
$0000c000 constant OTG_OTG_HCSPLT9_XACTPOS                          \ XACTPOS
$00010000 constant OTG_OTG_HCSPLT9_COMPLSPLT                        \ COMPLSPLT
$80000000 constant OTG_OTG_HCSPLT9_SPLITEN                          \ SPLITEN


\
\ @brief This register indicates the status of a channel with respect to USB- and AHB-related events. It is shown in Figure724. The application must read this register when the host channels interrupt bit in the core interrupt register (HCINT bit in OTG_GINTSTS) is set. Before the application can read this register, it must first read the host all channels interrupt (OTG_HAINT) register to get the exact channel number for the host channel-x interrupt register. The application must clear the appropriate bit in this register to clear the corresponding bits in the OTG_HAINT and OTG_GINTSTS registers.
\ Address offset: 0x628
\ Reset value: 0x00000000
\

$00000001 constant OTG_OTG_HCINT9_XFRC                              \ XFRC
$00000002 constant OTG_OTG_HCINT9_CHH                               \ CHH
$00000004 constant OTG_OTG_HCINT9_AHBERR                            \ AHBERR
$00000008 constant OTG_OTG_HCINT9_STALL                             \ STALL
$00000010 constant OTG_OTG_HCINT9_NAK                               \ NAK
$00000020 constant OTG_OTG_HCINT9_ACK                               \ ACK
$00000040 constant OTG_OTG_HCINT9_NYET                              \ NYET
$00000080 constant OTG_OTG_HCINT9_TXERR                             \ TXERR
$00000100 constant OTG_OTG_HCINT9_BBERR                             \ BBERR
$00000200 constant OTG_OTG_HCINT9_FRMOR                             \ FRMOR
$00000400 constant OTG_OTG_HCINT9_DTERR                             \ DTERR
$00000800 constant OTG_OTG_HCINT9_BNA                               \ BNA
$00001000 constant OTG_OTG_HCINT9_XCSXACTERR                        \ XCSXACTERR
$00002000 constant OTG_OTG_HCINT9_DESCLSTROLL                       \ DESCLSTROLL


\
\ @brief This register reflects the mask for each channel status described in the previous section.
\ Address offset: 0x62C
\ Reset value: 0x00000000
\

$00000001 constant OTG_OTG_HCINTMSK9_XFRCM                          \ XFRCM
$00000002 constant OTG_OTG_HCINTMSK9_CHHM                           \ CHHM
$00000004 constant OTG_OTG_HCINTMSK9_AHBERRM                        \ AHBERRM
$00000008 constant OTG_OTG_HCINTMSK9_STALLM                         \ STALLM
$00000010 constant OTG_OTG_HCINTMSK9_NAKM                           \ NAKM
$00000020 constant OTG_OTG_HCINTMSK9_ACKM                           \ ACKM
$00000040 constant OTG_OTG_HCINTMSK9_NYET                           \ NYET
$00000080 constant OTG_OTG_HCINTMSK9_TXERRM                         \ TXERRM
$00000100 constant OTG_OTG_HCINTMSK9_BBERRM                         \ BBERRM
$00000200 constant OTG_OTG_HCINTMSK9_FRMORM                         \ FRMORM
$00000400 constant OTG_OTG_HCINTMSK9_DTERRM                         \ DTERRM
$00000800 constant OTG_OTG_HCINTMSK9_BNAMSK                         \ BNAMSK
$00002000 constant OTG_OTG_HCINTMSK9_DESCLSTROLLMSK                 \ DESCLSTROLLMSK


\
\ @brief OTG host channel 9 transfer size register
\ Address offset: 0x630
\ Reset value: 0x00000000
\

$0007ffff constant OTG_OTG_HCTSIZ9_XFRSIZ                           \ XFRSIZ
$1ff80000 constant OTG_OTG_HCTSIZ9_PKTCNT                           \ PKTCNT
$60000000 constant OTG_OTG_HCTSIZ9_DPID                             \ DPID


\
\ @brief OTG host channel 9 DMA address register in buffer DMA [alternate]
\ Address offset: 0x634
\ Reset value: 0x00000000
\

$00000000 constant OTG_OTG_HCDMA9_DMAADDR                           \ DMAADDR


\
\ @brief OTG host channel-n DMA address buffer register
\ Address offset: 0x63C
\ Reset value: 0x00000000
\

$00000000 constant OTG_OTG_HCDMAB9_HCDMAB                           \ HCDMAB


\
\ @brief OTG host channel 10 characteristics register
\ Address offset: 0x640
\ Reset value: 0x00000000
\

$000007ff constant OTG_OTG_HCCHAR10_MPSIZ                           \ MPSIZ
$00007800 constant OTG_OTG_HCCHAR10_EPNUM                           \ EPNUM
$00008000 constant OTG_OTG_HCCHAR10_EPDIR                           \ EPDIR
$00020000 constant OTG_OTG_HCCHAR10_LSDEV                           \ LSDEV
$000c0000 constant OTG_OTG_HCCHAR10_EPTYP                           \ EPTYP
$00300000 constant OTG_OTG_HCCHAR10_MCNT                            \ MCNT
$1fc00000 constant OTG_OTG_HCCHAR10_DAD                             \ DAD
$40000000 constant OTG_OTG_HCCHAR10_CHDIS                           \ CHDIS
$80000000 constant OTG_OTG_HCCHAR10_CHENA                           \ CHENA


\
\ @brief OTG host channel 10 split control register
\ Address offset: 0x644
\ Reset value: 0x00000000
\

$0000007f constant OTG_OTG_HCSPLT10_PRTADDR                         \ PRTADDR
$00003f80 constant OTG_OTG_HCSPLT10_HUBADDR                         \ HUBADDR
$0000c000 constant OTG_OTG_HCSPLT10_XACTPOS                         \ XACTPOS
$00010000 constant OTG_OTG_HCSPLT10_COMPLSPLT                       \ COMPLSPLT
$80000000 constant OTG_OTG_HCSPLT10_SPLITEN                         \ SPLITEN


\
\ @brief This register indicates the status of a channel with respect to USB- and AHB-related events. It is shown in Figure724. The application must read this register when the host channels interrupt bit in the core interrupt register (HCINT bit in OTG_GINTSTS) is set. Before the application can read this register, it must first read the host all channels interrupt (OTG_HAINT) register to get the exact channel number for the host channel-x interrupt register. The application must clear the appropriate bit in this register to clear the corresponding bits in the OTG_HAINT and OTG_GINTSTS registers.
\ Address offset: 0x648
\ Reset value: 0x00000000
\

$00000001 constant OTG_OTG_HCINT10_XFRC                             \ XFRC
$00000002 constant OTG_OTG_HCINT10_CHH                              \ CHH
$00000004 constant OTG_OTG_HCINT10_AHBERR                           \ AHBERR
$00000008 constant OTG_OTG_HCINT10_STALL                            \ STALL
$00000010 constant OTG_OTG_HCINT10_NAK                              \ NAK
$00000020 constant OTG_OTG_HCINT10_ACK                              \ ACK
$00000040 constant OTG_OTG_HCINT10_NYET                             \ NYET
$00000080 constant OTG_OTG_HCINT10_TXERR                            \ TXERR
$00000100 constant OTG_OTG_HCINT10_BBERR                            \ BBERR
$00000200 constant OTG_OTG_HCINT10_FRMOR                            \ FRMOR
$00000400 constant OTG_OTG_HCINT10_DTERR                            \ DTERR
$00000800 constant OTG_OTG_HCINT10_BNA                              \ BNA
$00001000 constant OTG_OTG_HCINT10_XCSXACTERR                       \ XCSXACTERR
$00002000 constant OTG_OTG_HCINT10_DESCLSTROLL                      \ DESCLSTROLL


\
\ @brief This register reflects the mask for each channel status described in the previous section.
\ Address offset: 0x64C
\ Reset value: 0x00000000
\

$00000001 constant OTG_OTG_HCINTMSK10_XFRCM                         \ XFRCM
$00000002 constant OTG_OTG_HCINTMSK10_CHHM                          \ CHHM
$00000004 constant OTG_OTG_HCINTMSK10_AHBERRM                       \ AHBERRM
$00000008 constant OTG_OTG_HCINTMSK10_STALLM                        \ STALLM
$00000010 constant OTG_OTG_HCINTMSK10_NAKM                          \ NAKM
$00000020 constant OTG_OTG_HCINTMSK10_ACKM                          \ ACKM
$00000040 constant OTG_OTG_HCINTMSK10_NYET                          \ NYET
$00000080 constant OTG_OTG_HCINTMSK10_TXERRM                        \ TXERRM
$00000100 constant OTG_OTG_HCINTMSK10_BBERRM                        \ BBERRM
$00000200 constant OTG_OTG_HCINTMSK10_FRMORM                        \ FRMORM
$00000400 constant OTG_OTG_HCINTMSK10_DTERRM                        \ DTERRM
$00000800 constant OTG_OTG_HCINTMSK10_BNAMSK                        \ BNAMSK
$00002000 constant OTG_OTG_HCINTMSK10_DESCLSTROLLMSK                \ DESCLSTROLLMSK


\
\ @brief OTG host channel 10 transfer size register
\ Address offset: 0x650
\ Reset value: 0x00000000
\

$0007ffff constant OTG_OTG_HCTSIZ10_XFRSIZ                          \ XFRSIZ
$1ff80000 constant OTG_OTG_HCTSIZ10_PKTCNT                          \ PKTCNT
$60000000 constant OTG_OTG_HCTSIZ10_DPID                            \ DPID


\
\ @brief OTG host channel 10 DMA address register in buffer DMA [alternate]
\ Address offset: 0x654
\ Reset value: 0x00000000
\

$00000000 constant OTG_OTG_HCDMA10_DMAADDR                          \ DMAADDR


\
\ @brief OTG host channel-n DMA address buffer register
\ Address offset: 0x65C
\ Reset value: 0x00000000
\

$00000000 constant OTG_OTG_HCDMAB10_HCDMAB                          \ HCDMAB


\
\ @brief OTG host channel 11 characteristics register
\ Address offset: 0x660
\ Reset value: 0x00000000
\

$000007ff constant OTG_OTG_HCCHAR11_MPSIZ                           \ MPSIZ
$00007800 constant OTG_OTG_HCCHAR11_EPNUM                           \ EPNUM
$00008000 constant OTG_OTG_HCCHAR11_EPDIR                           \ EPDIR
$00020000 constant OTG_OTG_HCCHAR11_LSDEV                           \ LSDEV
$000c0000 constant OTG_OTG_HCCHAR11_EPTYP                           \ EPTYP
$00300000 constant OTG_OTG_HCCHAR11_MCNT                            \ MCNT
$1fc00000 constant OTG_OTG_HCCHAR11_DAD                             \ DAD
$40000000 constant OTG_OTG_HCCHAR11_CHDIS                           \ CHDIS
$80000000 constant OTG_OTG_HCCHAR11_CHENA                           \ CHENA


\
\ @brief OTG host channel 11 split control register
\ Address offset: 0x664
\ Reset value: 0x00000000
\

$0000007f constant OTG_OTG_HCSPLT11_PRTADDR                         \ PRTADDR
$00003f80 constant OTG_OTG_HCSPLT11_HUBADDR                         \ HUBADDR
$0000c000 constant OTG_OTG_HCSPLT11_XACTPOS                         \ XACTPOS
$00010000 constant OTG_OTG_HCSPLT11_COMPLSPLT                       \ COMPLSPLT
$80000000 constant OTG_OTG_HCSPLT11_SPLITEN                         \ SPLITEN


\
\ @brief This register indicates the status of a channel with respect to USB- and AHB-related events. It is shown in Figure724. The application must read this register when the host channels interrupt bit in the core interrupt register (HCINT bit in OTG_GINTSTS) is set. Before the application can read this register, it must first read the host all channels interrupt (OTG_HAINT) register to get the exact channel number for the host channel-x interrupt register. The application must clear the appropriate bit in this register to clear the corresponding bits in the OTG_HAINT and OTG_GINTSTS registers.
\ Address offset: 0x668
\ Reset value: 0x00000000
\

$00000001 constant OTG_OTG_HCINT11_XFRC                             \ XFRC
$00000002 constant OTG_OTG_HCINT11_CHH                              \ CHH
$00000004 constant OTG_OTG_HCINT11_AHBERR                           \ AHBERR
$00000008 constant OTG_OTG_HCINT11_STALL                            \ STALL
$00000010 constant OTG_OTG_HCINT11_NAK                              \ NAK
$00000020 constant OTG_OTG_HCINT11_ACK                              \ ACK
$00000040 constant OTG_OTG_HCINT11_NYET                             \ NYET
$00000080 constant OTG_OTG_HCINT11_TXERR                            \ TXERR
$00000100 constant OTG_OTG_HCINT11_BBERR                            \ BBERR
$00000200 constant OTG_OTG_HCINT11_FRMOR                            \ FRMOR
$00000400 constant OTG_OTG_HCINT11_DTERR                            \ DTERR
$00000800 constant OTG_OTG_HCINT11_BNA                              \ BNA
$00001000 constant OTG_OTG_HCINT11_XCSXACTERR                       \ XCSXACTERR
$00002000 constant OTG_OTG_HCINT11_DESCLSTROLL                      \ DESCLSTROLL


\
\ @brief This register reflects the mask for each channel status described in the previous section.
\ Address offset: 0x66C
\ Reset value: 0x00000000
\

$00000001 constant OTG_OTG_HCINTMSK11_XFRCM                         \ XFRCM
$00000002 constant OTG_OTG_HCINTMSK11_CHHM                          \ CHHM
$00000004 constant OTG_OTG_HCINTMSK11_AHBERRM                       \ AHBERRM
$00000008 constant OTG_OTG_HCINTMSK11_STALLM                        \ STALLM
$00000010 constant OTG_OTG_HCINTMSK11_NAKM                          \ NAKM
$00000020 constant OTG_OTG_HCINTMSK11_ACKM                          \ ACKM
$00000040 constant OTG_OTG_HCINTMSK11_NYET                          \ NYET
$00000080 constant OTG_OTG_HCINTMSK11_TXERRM                        \ TXERRM
$00000100 constant OTG_OTG_HCINTMSK11_BBERRM                        \ BBERRM
$00000200 constant OTG_OTG_HCINTMSK11_FRMORM                        \ FRMORM
$00000400 constant OTG_OTG_HCINTMSK11_DTERRM                        \ DTERRM
$00000800 constant OTG_OTG_HCINTMSK11_BNAMSK                        \ BNAMSK
$00002000 constant OTG_OTG_HCINTMSK11_DESCLSTROLLMSK                \ DESCLSTROLLMSK


\
\ @brief OTG host channel 11 transfer size register
\ Address offset: 0x670
\ Reset value: 0x00000000
\

$0007ffff constant OTG_OTG_HCTSIZ11_XFRSIZ                          \ XFRSIZ
$1ff80000 constant OTG_OTG_HCTSIZ11_PKTCNT                          \ PKTCNT
$60000000 constant OTG_OTG_HCTSIZ11_DPID                            \ DPID


\
\ @brief OTG host channel 11 DMA address register in buffer DMA [alternate]
\ Address offset: 0x674
\ Reset value: 0x00000000
\

$00000000 constant OTG_OTG_HCDMA11_DMAADDR                          \ DMAADDR


\
\ @brief OTG host channel-n DMA address buffer register
\ Address offset: 0x67C
\ Reset value: 0x00000000
\

$00000000 constant OTG_OTG_HCDMAB11_HCDMAB                          \ HCDMAB


\
\ @brief OTG host channel 12 characteristics register
\ Address offset: 0x680
\ Reset value: 0x00000000
\

$000007ff constant OTG_OTG_HCCHAR12_MPSIZ                           \ MPSIZ
$00007800 constant OTG_OTG_HCCHAR12_EPNUM                           \ EPNUM
$00008000 constant OTG_OTG_HCCHAR12_EPDIR                           \ EPDIR
$00020000 constant OTG_OTG_HCCHAR12_LSDEV                           \ LSDEV
$000c0000 constant OTG_OTG_HCCHAR12_EPTYP                           \ EPTYP
$00300000 constant OTG_OTG_HCCHAR12_MCNT                            \ MCNT
$1fc00000 constant OTG_OTG_HCCHAR12_DAD                             \ DAD
$40000000 constant OTG_OTG_HCCHAR12_CHDIS                           \ CHDIS
$80000000 constant OTG_OTG_HCCHAR12_CHENA                           \ CHENA


\
\ @brief OTG host channel 12 split control register
\ Address offset: 0x684
\ Reset value: 0x00000000
\

$0000007f constant OTG_OTG_HCSPLT12_PRTADDR                         \ PRTADDR
$00003f80 constant OTG_OTG_HCSPLT12_HUBADDR                         \ HUBADDR
$0000c000 constant OTG_OTG_HCSPLT12_XACTPOS                         \ XACTPOS
$00010000 constant OTG_OTG_HCSPLT12_COMPLSPLT                       \ COMPLSPLT
$80000000 constant OTG_OTG_HCSPLT12_SPLITEN                         \ SPLITEN


\
\ @brief This register indicates the status of a channel with respect to USB- and AHB-related events. It is shown in Figure724. The application must read this register when the host channels interrupt bit in the core interrupt register (HCINT bit in OTG_GINTSTS) is set. Before the application can read this register, it must first read the host all channels interrupt (OTG_HAINT) register to get the exact channel number for the host channel-x interrupt register. The application must clear the appropriate bit in this register to clear the corresponding bits in the OTG_HAINT and OTG_GINTSTS registers.
\ Address offset: 0x688
\ Reset value: 0x00000000
\

$00000001 constant OTG_OTG_HCINT12_XFRC                             \ XFRC
$00000002 constant OTG_OTG_HCINT12_CHH                              \ CHH
$00000004 constant OTG_OTG_HCINT12_AHBERR                           \ AHBERR
$00000008 constant OTG_OTG_HCINT12_STALL                            \ STALL
$00000010 constant OTG_OTG_HCINT12_NAK                              \ NAK
$00000020 constant OTG_OTG_HCINT12_ACK                              \ ACK
$00000040 constant OTG_OTG_HCINT12_NYET                             \ NYET
$00000080 constant OTG_OTG_HCINT12_TXERR                            \ TXERR
$00000100 constant OTG_OTG_HCINT12_BBERR                            \ BBERR
$00000200 constant OTG_OTG_HCINT12_FRMOR                            \ FRMOR
$00000400 constant OTG_OTG_HCINT12_DTERR                            \ DTERR
$00000800 constant OTG_OTG_HCINT12_BNA                              \ BNA
$00001000 constant OTG_OTG_HCINT12_XCSXACTERR                       \ XCSXACTERR
$00002000 constant OTG_OTG_HCINT12_DESCLSTROLL                      \ DESCLSTROLL


\
\ @brief This register reflects the mask for each channel status described in the previous section.
\ Address offset: 0x68C
\ Reset value: 0x00000000
\

$00000001 constant OTG_OTG_HCINTMSK12_XFRCM                         \ XFRCM
$00000002 constant OTG_OTG_HCINTMSK12_CHHM                          \ CHHM
$00000004 constant OTG_OTG_HCINTMSK12_AHBERRM                       \ AHBERRM
$00000008 constant OTG_OTG_HCINTMSK12_STALLM                        \ STALLM
$00000010 constant OTG_OTG_HCINTMSK12_NAKM                          \ NAKM
$00000020 constant OTG_OTG_HCINTMSK12_ACKM                          \ ACKM
$00000040 constant OTG_OTG_HCINTMSK12_NYET                          \ NYET
$00000080 constant OTG_OTG_HCINTMSK12_TXERRM                        \ TXERRM
$00000100 constant OTG_OTG_HCINTMSK12_BBERRM                        \ BBERRM
$00000200 constant OTG_OTG_HCINTMSK12_FRMORM                        \ FRMORM
$00000400 constant OTG_OTG_HCINTMSK12_DTERRM                        \ DTERRM
$00000800 constant OTG_OTG_HCINTMSK12_BNAMSK                        \ BNAMSK
$00002000 constant OTG_OTG_HCINTMSK12_DESCLSTROLLMSK                \ DESCLSTROLLMSK


\
\ @brief OTG host channel 12 transfer size register
\ Address offset: 0x690
\ Reset value: 0x00000000
\

$0007ffff constant OTG_OTG_HCTSIZ12_XFRSIZ                          \ XFRSIZ
$1ff80000 constant OTG_OTG_HCTSIZ12_PKTCNT                          \ PKTCNT
$60000000 constant OTG_OTG_HCTSIZ12_DPID                            \ DPID


\
\ @brief OTG host channel 12 DMA address register in buffer DMA [alternate]
\ Address offset: 0x694
\ Reset value: 0x00000000
\

$00000000 constant OTG_OTG_HCDMA12_DMAADDR                          \ DMAADDR


\
\ @brief OTG host channel-n DMA address buffer register
\ Address offset: 0x69C
\ Reset value: 0x00000000
\

$00000000 constant OTG_OTG_HCDMAB12_HCDMAB                          \ HCDMAB


\
\ @brief OTG host channel 13 characteristics register
\ Address offset: 0x6A0
\ Reset value: 0x00000000
\

$000007ff constant OTG_OTG_HCCHAR13_MPSIZ                           \ MPSIZ
$00007800 constant OTG_OTG_HCCHAR13_EPNUM                           \ EPNUM
$00008000 constant OTG_OTG_HCCHAR13_EPDIR                           \ EPDIR
$00020000 constant OTG_OTG_HCCHAR13_LSDEV                           \ LSDEV
$000c0000 constant OTG_OTG_HCCHAR13_EPTYP                           \ EPTYP
$00300000 constant OTG_OTG_HCCHAR13_MCNT                            \ MCNT
$1fc00000 constant OTG_OTG_HCCHAR13_DAD                             \ DAD
$40000000 constant OTG_OTG_HCCHAR13_CHDIS                           \ CHDIS
$80000000 constant OTG_OTG_HCCHAR13_CHENA                           \ CHENA


\
\ @brief OTG host channel 13 split control register
\ Address offset: 0x6A4
\ Reset value: 0x00000000
\

$0000007f constant OTG_OTG_HCSPLT13_PRTADDR                         \ PRTADDR
$00003f80 constant OTG_OTG_HCSPLT13_HUBADDR                         \ HUBADDR
$0000c000 constant OTG_OTG_HCSPLT13_XACTPOS                         \ XACTPOS
$00010000 constant OTG_OTG_HCSPLT13_COMPLSPLT                       \ COMPLSPLT
$80000000 constant OTG_OTG_HCSPLT13_SPLITEN                         \ SPLITEN


\
\ @brief This register indicates the status of a channel with respect to USB- and AHB-related events. It is shown in Figure724. The application must read this register when the host channels interrupt bit in the core interrupt register (HCINT bit in OTG_GINTSTS) is set. Before the application can read this register, it must first read the host all channels interrupt (OTG_HAINT) register to get the exact channel number for the host channel-x interrupt register. The application must clear the appropriate bit in this register to clear the corresponding bits in the OTG_HAINT and OTG_GINTSTS registers.
\ Address offset: 0x6A8
\ Reset value: 0x00000000
\

$00000001 constant OTG_OTG_HCINT13_XFRC                             \ XFRC
$00000002 constant OTG_OTG_HCINT13_CHH                              \ CHH
$00000004 constant OTG_OTG_HCINT13_AHBERR                           \ AHBERR
$00000008 constant OTG_OTG_HCINT13_STALL                            \ STALL
$00000010 constant OTG_OTG_HCINT13_NAK                              \ NAK
$00000020 constant OTG_OTG_HCINT13_ACK                              \ ACK
$00000040 constant OTG_OTG_HCINT13_NYET                             \ NYET
$00000080 constant OTG_OTG_HCINT13_TXERR                            \ TXERR
$00000100 constant OTG_OTG_HCINT13_BBERR                            \ BBERR
$00000200 constant OTG_OTG_HCINT13_FRMOR                            \ FRMOR
$00000400 constant OTG_OTG_HCINT13_DTERR                            \ DTERR
$00000800 constant OTG_OTG_HCINT13_BNA                              \ BNA
$00001000 constant OTG_OTG_HCINT13_XCSXACTERR                       \ XCSXACTERR
$00002000 constant OTG_OTG_HCINT13_DESCLSTROLL                      \ DESCLSTROLL


\
\ @brief This register reflects the mask for each channel status described in the previous section.
\ Address offset: 0x6AC
\ Reset value: 0x00000000
\

$00000001 constant OTG_OTG_HCINTMSK13_XFRCM                         \ XFRCM
$00000002 constant OTG_OTG_HCINTMSK13_CHHM                          \ CHHM
$00000004 constant OTG_OTG_HCINTMSK13_AHBERRM                       \ AHBERRM
$00000008 constant OTG_OTG_HCINTMSK13_STALLM                        \ STALLM
$00000010 constant OTG_OTG_HCINTMSK13_NAKM                          \ NAKM
$00000020 constant OTG_OTG_HCINTMSK13_ACKM                          \ ACKM
$00000040 constant OTG_OTG_HCINTMSK13_NYET                          \ NYET
$00000080 constant OTG_OTG_HCINTMSK13_TXERRM                        \ TXERRM
$00000100 constant OTG_OTG_HCINTMSK13_BBERRM                        \ BBERRM
$00000200 constant OTG_OTG_HCINTMSK13_FRMORM                        \ FRMORM
$00000400 constant OTG_OTG_HCINTMSK13_DTERRM                        \ DTERRM
$00000800 constant OTG_OTG_HCINTMSK13_BNAMSK                        \ BNAMSK
$00002000 constant OTG_OTG_HCINTMSK13_DESCLSTROLLMSK                \ DESCLSTROLLMSK


\
\ @brief OTG host channel 13 transfer size register
\ Address offset: 0x6B0
\ Reset value: 0x00000000
\

$0007ffff constant OTG_OTG_HCTSIZ13_XFRSIZ                          \ XFRSIZ
$1ff80000 constant OTG_OTG_HCTSIZ13_PKTCNT                          \ PKTCNT
$60000000 constant OTG_OTG_HCTSIZ13_DPID                            \ DPID


\
\ @brief OTG host channel 13 DMA address register in buffer DMA [alternate]
\ Address offset: 0x6B4
\ Reset value: 0x00000000
\

$00000000 constant OTG_OTG_HCDMA13_DMAADDR                          \ DMAADDR


\
\ @brief OTG host channel-n DMA address buffer register
\ Address offset: 0x6BC
\ Reset value: 0x00000000
\

$00000000 constant OTG_OTG_HCDMAB13_HCDMAB                          \ HCDMAB


\
\ @brief OTG host channel 14 characteristics register
\ Address offset: 0x6C0
\ Reset value: 0x00000000
\

$000007ff constant OTG_OTG_HCCHAR14_MPSIZ                           \ MPSIZ
$00007800 constant OTG_OTG_HCCHAR14_EPNUM                           \ EPNUM
$00008000 constant OTG_OTG_HCCHAR14_EPDIR                           \ EPDIR
$00020000 constant OTG_OTG_HCCHAR14_LSDEV                           \ LSDEV
$000c0000 constant OTG_OTG_HCCHAR14_EPTYP                           \ EPTYP
$00300000 constant OTG_OTG_HCCHAR14_MCNT                            \ MCNT
$1fc00000 constant OTG_OTG_HCCHAR14_DAD                             \ DAD
$40000000 constant OTG_OTG_HCCHAR14_CHDIS                           \ CHDIS
$80000000 constant OTG_OTG_HCCHAR14_CHENA                           \ CHENA


\
\ @brief OTG host channel 14 split control register
\ Address offset: 0x6C4
\ Reset value: 0x00000000
\

$0000007f constant OTG_OTG_HCSPLT14_PRTADDR                         \ PRTADDR
$00003f80 constant OTG_OTG_HCSPLT14_HUBADDR                         \ HUBADDR
$0000c000 constant OTG_OTG_HCSPLT14_XACTPOS                         \ XACTPOS
$00010000 constant OTG_OTG_HCSPLT14_COMPLSPLT                       \ COMPLSPLT
$80000000 constant OTG_OTG_HCSPLT14_SPLITEN                         \ SPLITEN


\
\ @brief This register indicates the status of a channel with respect to USB- and AHB-related events. It is shown in Figure724. The application must read this register when the host channels interrupt bit in the core interrupt register (HCINT bit in OTG_GINTSTS) is set. Before the application can read this register, it must first read the host all channels interrupt (OTG_HAINT) register to get the exact channel number for the host channel-x interrupt register. The application must clear the appropriate bit in this register to clear the corresponding bits in the OTG_HAINT and OTG_GINTSTS registers.
\ Address offset: 0x6C8
\ Reset value: 0x00000000
\

$00000001 constant OTG_OTG_HCINT14_XFRC                             \ XFRC
$00000002 constant OTG_OTG_HCINT14_CHH                              \ CHH
$00000004 constant OTG_OTG_HCINT14_AHBERR                           \ AHBERR
$00000008 constant OTG_OTG_HCINT14_STALL                            \ STALL
$00000010 constant OTG_OTG_HCINT14_NAK                              \ NAK
$00000020 constant OTG_OTG_HCINT14_ACK                              \ ACK
$00000040 constant OTG_OTG_HCINT14_NYET                             \ NYET
$00000080 constant OTG_OTG_HCINT14_TXERR                            \ TXERR
$00000100 constant OTG_OTG_HCINT14_BBERR                            \ BBERR
$00000200 constant OTG_OTG_HCINT14_FRMOR                            \ FRMOR
$00000400 constant OTG_OTG_HCINT14_DTERR                            \ DTERR
$00000800 constant OTG_OTG_HCINT14_BNA                              \ BNA
$00001000 constant OTG_OTG_HCINT14_XCSXACTERR                       \ XCSXACTERR
$00002000 constant OTG_OTG_HCINT14_DESCLSTROLL                      \ DESCLSTROLL


\
\ @brief This register reflects the mask for each channel status described in the previous section.
\ Address offset: 0x6CC
\ Reset value: 0x00000000
\

$00000001 constant OTG_OTG_HCINTMSK14_XFRCM                         \ XFRCM
$00000002 constant OTG_OTG_HCINTMSK14_CHHM                          \ CHHM
$00000004 constant OTG_OTG_HCINTMSK14_AHBERRM                       \ AHBERRM
$00000008 constant OTG_OTG_HCINTMSK14_STALLM                        \ STALLM
$00000010 constant OTG_OTG_HCINTMSK14_NAKM                          \ NAKM
$00000020 constant OTG_OTG_HCINTMSK14_ACKM                          \ ACKM
$00000040 constant OTG_OTG_HCINTMSK14_NYET                          \ NYET
$00000080 constant OTG_OTG_HCINTMSK14_TXERRM                        \ TXERRM
$00000100 constant OTG_OTG_HCINTMSK14_BBERRM                        \ BBERRM
$00000200 constant OTG_OTG_HCINTMSK14_FRMORM                        \ FRMORM
$00000400 constant OTG_OTG_HCINTMSK14_DTERRM                        \ DTERRM
$00000800 constant OTG_OTG_HCINTMSK14_BNAMSK                        \ BNAMSK
$00002000 constant OTG_OTG_HCINTMSK14_DESCLSTROLLMSK                \ DESCLSTROLLMSK


\
\ @brief OTG host channel 14 transfer size register
\ Address offset: 0x6D0
\ Reset value: 0x00000000
\

$0007ffff constant OTG_OTG_HCTSIZ14_XFRSIZ                          \ XFRSIZ
$1ff80000 constant OTG_OTG_HCTSIZ14_PKTCNT                          \ PKTCNT
$60000000 constant OTG_OTG_HCTSIZ14_DPID                            \ DPID


\
\ @brief OTG host channel 14 DMA address register in buffer DMA [alternate]
\ Address offset: 0x6D4
\ Reset value: 0x00000000
\

$00000000 constant OTG_OTG_HCDMA14_DMAADDR                          \ DMAADDR


\
\ @brief OTG host channel-n DMA address buffer register
\ Address offset: 0x6DC
\ Reset value: 0x00000000
\

$00000000 constant OTG_OTG_HCDMAB14_HCDMAB                          \ HCDMAB


\
\ @brief OTG host channel 15 characteristics register
\ Address offset: 0x6E0
\ Reset value: 0x00000000
\

$000007ff constant OTG_OTG_HCCHAR15_MPSIZ                           \ MPSIZ
$00007800 constant OTG_OTG_HCCHAR15_EPNUM                           \ EPNUM
$00008000 constant OTG_OTG_HCCHAR15_EPDIR                           \ EPDIR
$00020000 constant OTG_OTG_HCCHAR15_LSDEV                           \ LSDEV
$000c0000 constant OTG_OTG_HCCHAR15_EPTYP                           \ EPTYP
$00300000 constant OTG_OTG_HCCHAR15_MCNT                            \ MCNT
$1fc00000 constant OTG_OTG_HCCHAR15_DAD                             \ DAD
$40000000 constant OTG_OTG_HCCHAR15_CHDIS                           \ CHDIS
$80000000 constant OTG_OTG_HCCHAR15_CHENA                           \ CHENA


\
\ @brief OTG host channel 15 split control register
\ Address offset: 0x6E4
\ Reset value: 0x00000000
\

$0000007f constant OTG_OTG_HCSPLT15_PRTADDR                         \ PRTADDR
$00003f80 constant OTG_OTG_HCSPLT15_HUBADDR                         \ HUBADDR
$0000c000 constant OTG_OTG_HCSPLT15_XACTPOS                         \ XACTPOS
$00010000 constant OTG_OTG_HCSPLT15_COMPLSPLT                       \ COMPLSPLT
$80000000 constant OTG_OTG_HCSPLT15_SPLITEN                         \ SPLITEN


\
\ @brief This register indicates the status of a channel with respect to USB- and AHB-related events. It is shown in Figure724. The application must read this register when the host channels interrupt bit in the core interrupt register (HCINT bit in OTG_GINTSTS) is set. Before the application can read this register, it must first read the host all channels interrupt (OTG_HAINT) register to get the exact channel number for the host channel-x interrupt register. The application must clear the appropriate bit in this register to clear the corresponding bits in the OTG_HAINT and OTG_GINTSTS registers.
\ Address offset: 0x6E8
\ Reset value: 0x00000000
\

$00000001 constant OTG_OTG_HCINT15_XFRC                             \ XFRC
$00000002 constant OTG_OTG_HCINT15_CHH                              \ CHH
$00000004 constant OTG_OTG_HCINT15_AHBERR                           \ AHBERR
$00000008 constant OTG_OTG_HCINT15_STALL                            \ STALL
$00000010 constant OTG_OTG_HCINT15_NAK                              \ NAK
$00000020 constant OTG_OTG_HCINT15_ACK                              \ ACK
$00000040 constant OTG_OTG_HCINT15_NYET                             \ NYET
$00000080 constant OTG_OTG_HCINT15_TXERR                            \ TXERR
$00000100 constant OTG_OTG_HCINT15_BBERR                            \ BBERR
$00000200 constant OTG_OTG_HCINT15_FRMOR                            \ FRMOR
$00000400 constant OTG_OTG_HCINT15_DTERR                            \ DTERR
$00000800 constant OTG_OTG_HCINT15_BNA                              \ BNA
$00001000 constant OTG_OTG_HCINT15_XCSXACTERR                       \ XCSXACTERR
$00002000 constant OTG_OTG_HCINT15_DESCLSTROLL                      \ DESCLSTROLL


\
\ @brief This register reflects the mask for each channel status described in the previous section.
\ Address offset: 0x6EC
\ Reset value: 0x00000000
\

$00000001 constant OTG_OTG_HCINTMSK15_XFRCM                         \ XFRCM
$00000002 constant OTG_OTG_HCINTMSK15_CHHM                          \ CHHM
$00000004 constant OTG_OTG_HCINTMSK15_AHBERRM                       \ AHBERRM
$00000008 constant OTG_OTG_HCINTMSK15_STALLM                        \ STALLM
$00000010 constant OTG_OTG_HCINTMSK15_NAKM                          \ NAKM
$00000020 constant OTG_OTG_HCINTMSK15_ACKM                          \ ACKM
$00000040 constant OTG_OTG_HCINTMSK15_NYET                          \ NYET
$00000080 constant OTG_OTG_HCINTMSK15_TXERRM                        \ TXERRM
$00000100 constant OTG_OTG_HCINTMSK15_BBERRM                        \ BBERRM
$00000200 constant OTG_OTG_HCINTMSK15_FRMORM                        \ FRMORM
$00000400 constant OTG_OTG_HCINTMSK15_DTERRM                        \ DTERRM
$00000800 constant OTG_OTG_HCINTMSK15_BNAMSK                        \ BNAMSK
$00002000 constant OTG_OTG_HCINTMSK15_DESCLSTROLLMSK                \ DESCLSTROLLMSK


\
\ @brief OTG host channel 15 transfer size register
\ Address offset: 0x6F0
\ Reset value: 0x00000000
\

$0007ffff constant OTG_OTG_HCTSIZ15_XFRSIZ                          \ XFRSIZ
$1ff80000 constant OTG_OTG_HCTSIZ15_PKTCNT                          \ PKTCNT
$60000000 constant OTG_OTG_HCTSIZ15_DPID                            \ DPID


\
\ @brief OTG host channel 15 DMA address register in buffer DMA [alternate]
\ Address offset: 0x6F4
\ Reset value: 0x00000000
\

$00000000 constant OTG_OTG_HCDMA15_DMAADDR                          \ DMAADDR


\
\ @brief OTG host channel-n DMA address buffer register
\ Address offset: 0x6FC
\ Reset value: 0x00000000
\

$00000000 constant OTG_OTG_HCDMAB15_HCDMAB                          \ HCDMAB


\
\ @brief This register configures the core in device mode after power-on or after certain control commands or enumeration. Do not make changes to this register after initial programming.
\ Address offset: 0x800
\ Reset value: 0x02200000
\

$00000003 constant OTG_OTG_DCFG_DSPD                                \ DSPD
$00000004 constant OTG_OTG_DCFG_NZLSOHSK                            \ NZLSOHSK
$000007f0 constant OTG_OTG_DCFG_DAD                                 \ DAD
$00001800 constant OTG_OTG_DCFG_PFIVL                               \ PFIVL
$00004000 constant OTG_OTG_DCFG_XCVRDLY                             \ XCVRDLY
$00008000 constant OTG_OTG_DCFG_ERRATIM                             \ ERRATIM
$03000000 constant OTG_OTG_DCFG_PERSCHIVL                           \ PERSCHIVL


\
\ @brief OTG device control register
\ Address offset: 0x804
\ Reset value: 0x00000002
\

$00000001 constant OTG_OTG_DCTL_RWUSIG                              \ RWUSIG
$00000002 constant OTG_OTG_DCTL_SDIS                                \ SDIS
$00000004 constant OTG_OTG_DCTL_GINSTS                              \ GINSTS
$00000008 constant OTG_OTG_DCTL_GONSTS                              \ GONSTS
$00000070 constant OTG_OTG_DCTL_TCTL                                \ TCTL
$00000080 constant OTG_OTG_DCTL_SGINAK                              \ SGINAK
$00000100 constant OTG_OTG_DCTL_CGINAK                              \ CGINAK
$00000200 constant OTG_OTG_DCTL_SGONAK                              \ SGONAK
$00000400 constant OTG_OTG_DCTL_CGONAK                              \ CGONAK
$00000800 constant OTG_OTG_DCTL_POPRGDNE                            \ POPRGDNE
$00040000 constant OTG_OTG_DCTL_DSBESLRJCT                          \ DSBESLRJCT


\
\ @brief This register indicates the status of the core with respect to USB-related events. It must be read on interrupts from the device all interrupts (OTG_DAINT) register.
\ Address offset: 0x808
\ Reset value: 0x00000010
\

$00000001 constant OTG_OTG_DSTS_SUSPSTS                             \ SUSPSTS
$00000006 constant OTG_OTG_DSTS_ENUMSPD                             \ ENUMSPD
$00000008 constant OTG_OTG_DSTS_EERR                                \ EERR
$003fff00 constant OTG_OTG_DSTS_FNSOF                               \ FNSOF
$00c00000 constant OTG_OTG_DSTS_DEVLNSTS                            \ DEVLNSTS


\
\ @brief This register works with each of the OTG_DIEPINTx registers for all endpoints to generate an interrupt per IN endpoint. The IN endpoint interrupt for a specific status in the OTG_DIEPINTx register can be masked by writing to the corresponding bit in this register. Status bits are masked by default.
\ Address offset: 0x810
\ Reset value: 0x00000000
\

$00000001 constant OTG_OTG_DIEPMSK_XFRCM                            \ XFRCM
$00000002 constant OTG_OTG_DIEPMSK_EPDM                             \ EPDM
$00000004 constant OTG_OTG_DIEPMSK_AHBERRM                          \ AHBERRM
$00000008 constant OTG_OTG_DIEPMSK_TOM                              \ TOM
$00000010 constant OTG_OTG_DIEPMSK_ITTXFEMSK                        \ ITTXFEMSK
$00000020 constant OTG_OTG_DIEPMSK_INEPNMM                          \ INEPNMM
$00000040 constant OTG_OTG_DIEPMSK_INEPNEM                          \ INEPNEM
$00000100 constant OTG_OTG_DIEPMSK_TXFURM                           \ TXFURM
$00000200 constant OTG_OTG_DIEPMSK_BNAM                             \ BNAM
$00002000 constant OTG_OTG_DIEPMSK_NAKM                             \ NAKM


\
\ @brief This register works with each of the OTG_DOEPINTx registers for all endpoints to generate an interrupt per OUT endpoint. The OUT endpoint interrupt for a specific status in the OTG_DOEPINTx register can be masked by writing into the corresponding bit in this register. Status bits are masked by default.
\ Address offset: 0x814
\ Reset value: 0x00000000
\

$00000001 constant OTG_OTG_DOEPMSK_XFRCM                            \ XFRCM
$00000002 constant OTG_OTG_DOEPMSK_EPDM                             \ EPDM
$00000004 constant OTG_OTG_DOEPMSK_AHBERRM                          \ AHBERRM
$00000008 constant OTG_OTG_DOEPMSK_STUPM                            \ STUPM
$00000010 constant OTG_OTG_DOEPMSK_OTEPDM                           \ OTEPDM
$00000020 constant OTG_OTG_DOEPMSK_STSPHSRXM                        \ STSPHSRXM
$00000040 constant OTG_OTG_DOEPMSK_B2BSTUPM                         \ B2BSTUPM
$00000100 constant OTG_OTG_DOEPMSK_OUTPKTERRM                       \ OUTPKTERRM
$00000200 constant OTG_OTG_DOEPMSK_BNAM                             \ BNAM
$00001000 constant OTG_OTG_DOEPMSK_BERRM                            \ BERRM
$00002000 constant OTG_OTG_DOEPMSK_NAKMSK                           \ NAKMSK
$00004000 constant OTG_OTG_DOEPMSK_NYETMSK                          \ NYETMSK


\
\ @brief When a significant event occurs on an endpoint, a OTG_DAINT register interrupts the application using the device OUT endpoints interrupt bit or device IN endpoints interrupt bit of the OTG_GINTSTS register (OEPINT or IEPINT in OTG_GINTSTS, respectively). There is one interrupt bit per endpoint, up to a maximum of 16 bits for OUT endpoints and 16 bits for IN endpoints. For a bidirectional endpoint, the corresponding IN and OUT interrupt bits are used. Bits in this register are set and cleared when the application sets and clears bits in the corresponding device endpoint-x interrupt register (OTG_DIEPINTx/OTG_DOEPINTx).
\ Address offset: 0x818
\ Reset value: 0x00000000
\

$0000ffff constant OTG_OTG_DAINT_IEPINT                             \ IEPINT
$ffff0000 constant OTG_OTG_DAINT_OEPINT                             \ OEPINT


\
\ @brief The OTG_DAINTMSK register works with the device endpoint interrupt register to interrupt the application when an event occurs on a device endpoint. However, the OTG_DAINT register bit corresponding to that interrupt is still set.
\ Address offset: 0x81C
\ Reset value: 0x00000000
\

$0000ffff constant OTG_OTG_DAINTMSK_IEPM                            \ IEPM
$ffff0000 constant OTG_OTG_DAINTMSK_OEPM                            \ OEPM


\
\ @brief This register specifies the VBUS discharge time after VBUS pulsing during SRP.
\ Address offset: 0x828
\ Reset value: 0x000017D7
\

$0000ffff constant OTG_OTG_DVBUSDIS_VBUSDT                          \ VBUSDT


\
\ @brief This register specifies the VBUS pulsing time during SRP.
\ Address offset: 0x82C
\ Reset value: 0x000005B8
\

$0000ffff constant OTG_OTG_DVBUSPULSE_DVBUSP                        \ DVBUSP


\
\ @brief OTG device threshold control register
\ Address offset: 0x830
\ Reset value: 0x00000000
\

$00000001 constant OTG_OTG_DTHRCTL_NONISOTHREN                      \ NONISOTHREN
$00000002 constant OTG_OTG_DTHRCTL_ISOTHREN                         \ ISOTHREN
$000007fc constant OTG_OTG_DTHRCTL_TXTHRLEN                         \ TXTHRLEN
$00010000 constant OTG_OTG_DTHRCTL_RXTHREN                          \ RXTHREN
$03fe0000 constant OTG_OTG_DTHRCTL_RXTHRLEN                         \ RXTHRLEN
$08000000 constant OTG_OTG_DTHRCTL_ARPEN                            \ ARPEN


\
\ @brief This register is used to control the IN endpoint FIFO empty interrupt generation (TXFE_OTG_DIEPINTx).
\ Address offset: 0x834
\ Reset value: 0x00000000
\

$0000ffff constant OTG_OTG_DIEPEMPMSK_INEPTXFEM                     \ INEPTXFEM


\
\ @brief OTG device each endpoint interrupt register
\ Address offset: 0x838
\ Reset value: 0x00000000
\

$00000002 constant OTG_OTG_DEACHINT_IEP1INT                         \ IEP1INT
$00020000 constant OTG_OTG_DEACHINT_OEP1INT                         \ OEP1INT


\
\ @brief There is one interrupt bit for endpoint 1 IN and one interrupt bit for endpoint 1 OUT.
\ Address offset: 0x83C
\ Reset value: 0x00000000
\

$00000002 constant OTG_OTG_DEACHINTMSK_IEP1INTM                     \ IEP1INTM
$00020000 constant OTG_OTG_DEACHINTMSK_OEP1INTM                     \ OEP1INTM


\
\ @brief This register works with the OTG_DIEPINT1 register to generate a dedicated interrupt OTG_HS_EP1_IN for endpoint #1. The IN endpoint interrupt for a specific status in the OTG_DOEPINT1 register can be masked by writing into the corresponding bit in this register. Status bits are masked by default.
\ Address offset: 0x844
\ Reset value: 0x00000000
\

$00000001 constant OTG_OTG_HS_DIEPEACHMSK1_XFRCM                    \ XFRCM
$00000002 constant OTG_OTG_HS_DIEPEACHMSK1_EPDM                     \ EPDM
$00000004 constant OTG_OTG_HS_DIEPEACHMSK1_AHBERRM                  \ AHBERRM
$00000008 constant OTG_OTG_HS_DIEPEACHMSK1_TOM                      \ TOM
$00000010 constant OTG_OTG_HS_DIEPEACHMSK1_ITTXFEMSK                \ ITTXFEMSK
$00000040 constant OTG_OTG_HS_DIEPEACHMSK1_INEPNEM                  \ INEPNEM
$00000100 constant OTG_OTG_HS_DIEPEACHMSK1_TXFURM                   \ TXFURM
$00000200 constant OTG_OTG_HS_DIEPEACHMSK1_BNAM                     \ BNAM
$00002000 constant OTG_OTG_HS_DIEPEACHMSK1_NAKM                     \ NAKM


\
\ @brief This register works with the OTG_DOEPINT1 register to generate a dedicated interrupt OTG_HS_EP1_OUT for endpoint #1. The OUT endpoint interrupt for a specific status in the OTG_DOEPINT1 register can be masked by writing into the corresponding bit in this register. Status bits are masked by default.
\ Address offset: 0x884
\ Reset value: 0x00000000
\

$00000001 constant OTG_OTG_HS_DOEPEACHMSK1_XFRCM                    \ XFRCM
$00000002 constant OTG_OTG_HS_DOEPEACHMSK1_EPDM                     \ EPDM
$00000004 constant OTG_OTG_HS_DOEPEACHMSK1_AHBERRM                  \ AHBERRM
$00000008 constant OTG_OTG_HS_DOEPEACHMSK1_STUPM                    \ STUPM
$00000010 constant OTG_OTG_HS_DOEPEACHMSK1_OTEPDM                   \ OTEPDM
$00000040 constant OTG_OTG_HS_DOEPEACHMSK1_B2BSTUPM                 \ B2BSTUPM
$00000100 constant OTG_OTG_HS_DOEPEACHMSK1_OUTPKTERRM               \ OUTPKTERRM
$00000200 constant OTG_OTG_HS_DOEPEACHMSK1_BNAM                     \ BNAM
$00001000 constant OTG_OTG_HS_DOEPEACHMSK1_BERRM                    \ BERRM
$00002000 constant OTG_OTG_HS_DOEPEACHMSK1_NAKMSK                   \ NAKMSK
$00004000 constant OTG_OTG_HS_DOEPEACHMSK1_NYETMSK                  \ NYETMSK


\
\ @brief The application uses this register to control the behavior of each logical endpoint other than endpoint 0.
\ Address offset: 0x900
\ Reset value: 0x00000000
\

$000007ff constant OTG_OTG_DIEPCTL0_MPSIZ                           \ MPSIZ
$00008000 constant OTG_OTG_DIEPCTL0_USBAEP                          \ USBAEP
$00010000 constant OTG_OTG_DIEPCTL0_EONUM_DPIP                      \ EONUM_DPIP
$00020000 constant OTG_OTG_DIEPCTL0_NAKSTS                          \ NAKSTS
$000c0000 constant OTG_OTG_DIEPCTL0_EPTYP                           \ EPTYP
$00200000 constant OTG_OTG_DIEPCTL0_STALL                           \ STALL
$03c00000 constant OTG_OTG_DIEPCTL0_TXFNUM                          \ TXFNUM
$04000000 constant OTG_OTG_DIEPCTL0_CNAK                            \ CNAK
$08000000 constant OTG_OTG_DIEPCTL0_SNAK                            \ SNAK
$10000000 constant OTG_OTG_DIEPCTL0_SD0PID_SEVNFRM                  \ SD0PID_SEVNFRM
$20000000 constant OTG_OTG_DIEPCTL0_SODDFRM                         \ SODDFRM
$40000000 constant OTG_OTG_DIEPCTL0_EPDIS                           \ EPDIS
$80000000 constant OTG_OTG_DIEPCTL0_EPENA                           \ EPENA


\
\ @brief This register indicates the status of an endpoint with respect to USB- and AHB-related events. It is shown in Figure724. The application must read this register when the IN endpoints interrupt bit of the core interrupt register (IEPINT in OTG_GINTSTS) is set. Before the application can read this register, it must first read the device all endpoints interrupt (OTG_DAINT) register to get the exact endpoint number for the device endpoint-x interrupt register. The application must clear the appropriate bit in this register to clear the corresponding bits in the OTG_DAINT and OTG_GINTSTS registers.
\ Address offset: 0x908
\ Reset value: 0x00000080
\

$00000001 constant OTG_OTG_DIEPINT0_XFRC                            \ XFRC
$00000002 constant OTG_OTG_DIEPINT0_EPDISD                          \ EPDISD
$00000004 constant OTG_OTG_DIEPINT0_AHBERR                          \ AHBERR
$00000008 constant OTG_OTG_DIEPINT0_TOC                             \ TOC
$00000010 constant OTG_OTG_DIEPINT0_ITTXFE                          \ ITTXFE
$00000020 constant OTG_OTG_DIEPINT0_INEPNM                          \ INEPNM
$00000040 constant OTG_OTG_DIEPINT0_INEPNE                          \ INEPNE
$00000080 constant OTG_OTG_DIEPINT0_TXFE                            \ TXFE
$00000100 constant OTG_OTG_DIEPINT0_TXFIFOUDRN                      \ TXFIFOUDRN
$00000200 constant OTG_OTG_DIEPINT0_BNA                             \ BNA
$00000800 constant OTG_OTG_DIEPINT0_PKTDRPSTS                       \ PKTDRPSTS
$00002000 constant OTG_OTG_DIEPINT0_NAK                             \ NAK


\
\ @brief The application must modify this register before enabling endpoint 0.
\ Address offset: 0x910
\ Reset value: 0x00000000
\

$0000007f constant OTG_OTG_DIEPTSIZ0_XFRSIZ                         \ XFRSIZ
$00180000 constant OTG_OTG_DIEPTSIZ0_PKTCNT                         \ PKTCNT


\
\ @brief OTG device IN endpoint 0 DMA address register
\ Address offset: 0x914
\ Reset value: 0x00000000
\

$00000000 constant OTG_OTG_DIEPDMA0_DMAADDR                         \ DMAADDR


\
\ @brief This read-only register contains the free space information for the device IN endpoint Tx FIFO.
\ Address offset: 0x918
\ Reset value: 0x00000200
\

$0000ffff constant OTG_OTG_DTXFSTS0_INEPTFSAV                       \ INEPTFSAV


\
\ @brief The application uses this register to control the behavior of each logical endpoint other than endpoint 0.
\ Address offset: 0x920
\ Reset value: 0x00000000
\

$000007ff constant OTG_OTG_DIEPCTL1_MPSIZ                           \ MPSIZ
$00008000 constant OTG_OTG_DIEPCTL1_USBAEP                          \ USBAEP
$00010000 constant OTG_OTG_DIEPCTL1_EONUM_DPIP                      \ EONUM_DPIP
$00020000 constant OTG_OTG_DIEPCTL1_NAKSTS                          \ NAKSTS
$000c0000 constant OTG_OTG_DIEPCTL1_EPTYP                           \ EPTYP
$00200000 constant OTG_OTG_DIEPCTL1_STALL                           \ STALL
$03c00000 constant OTG_OTG_DIEPCTL1_TXFNUM                          \ TXFNUM
$04000000 constant OTG_OTG_DIEPCTL1_CNAK                            \ CNAK
$08000000 constant OTG_OTG_DIEPCTL1_SNAK                            \ SNAK
$10000000 constant OTG_OTG_DIEPCTL1_SD0PID_SEVNFRM                  \ SD0PID_SEVNFRM
$20000000 constant OTG_OTG_DIEPCTL1_SODDFRM                         \ SODDFRM
$40000000 constant OTG_OTG_DIEPCTL1_EPDIS                           \ EPDIS
$80000000 constant OTG_OTG_DIEPCTL1_EPENA                           \ EPENA


\
\ @brief This register indicates the status of an endpoint with respect to USB- and AHB-related events. It is shown in Figure724. The application must read this register when the IN endpoints interrupt bit of the core interrupt register (IEPINT in OTG_GINTSTS) is set. Before the application can read this register, it must first read the device all endpoints interrupt (OTG_DAINT) register to get the exact endpoint number for the device endpoint-x interrupt register. The application must clear the appropriate bit in this register to clear the corresponding bits in the OTG_DAINT and OTG_GINTSTS registers.
\ Address offset: 0x928
\ Reset value: 0x00000080
\

$00000001 constant OTG_OTG_DIEPINT1_XFRC                            \ XFRC
$00000002 constant OTG_OTG_DIEPINT1_EPDISD                          \ EPDISD
$00000004 constant OTG_OTG_DIEPINT1_AHBERR                          \ AHBERR
$00000008 constant OTG_OTG_DIEPINT1_TOC                             \ TOC
$00000010 constant OTG_OTG_DIEPINT1_ITTXFE                          \ ITTXFE
$00000020 constant OTG_OTG_DIEPINT1_INEPNM                          \ INEPNM
$00000040 constant OTG_OTG_DIEPINT1_INEPNE                          \ INEPNE
$00000080 constant OTG_OTG_DIEPINT1_TXFE                            \ TXFE
$00000100 constant OTG_OTG_DIEPINT1_TXFIFOUDRN                      \ TXFIFOUDRN
$00000200 constant OTG_OTG_DIEPINT1_BNA                             \ BNA
$00000800 constant OTG_OTG_DIEPINT1_PKTDRPSTS                       \ PKTDRPSTS
$00002000 constant OTG_OTG_DIEPINT1_NAK                             \ NAK


\
\ @brief The application must modify this register before enabling the endpoint. Once the endpoint is enabled using the endpoint enable bit in the OTG_DIEPCTLx registers (EPENA bit in OTG_DIEPCTLx), the core modifies this register. The application can only read this register once the core has cleared the endpoint enable bit.
\ Address offset: 0x930
\ Reset value: 0x00000000
\

$0007ffff constant OTG_OTG_DIEPTSIZ1_XFRSIZ                         \ XFRSIZ
$1ff80000 constant OTG_OTG_DIEPTSIZ1_PKTCNT                         \ PKTCNT
$60000000 constant OTG_OTG_DIEPTSIZ1_MCNT                           \ MCNT


\
\ @brief OTG device IN endpoint 1 DMA address register
\ Address offset: 0x934
\ Reset value: 0x00000000
\

$00000000 constant OTG_OTG_DIEPDMA1_DMAADDR                         \ DMAADDR


\
\ @brief This read-only register contains the free space information for the device IN endpoint Tx FIFO.
\ Address offset: 0x938
\ Reset value: 0x00000200
\

$0000ffff constant OTG_OTG_DTXFSTS1_INEPTFSAV                       \ INEPTFSAV


\
\ @brief The application uses this register to control the behavior of each logical endpoint other than endpoint 0.
\ Address offset: 0x940
\ Reset value: 0x00000000
\

$000007ff constant OTG_OTG_DIEPCTL2_MPSIZ                           \ MPSIZ
$00008000 constant OTG_OTG_DIEPCTL2_USBAEP                          \ USBAEP
$00010000 constant OTG_OTG_DIEPCTL2_EONUM_DPIP                      \ EONUM_DPIP
$00020000 constant OTG_OTG_DIEPCTL2_NAKSTS                          \ NAKSTS
$000c0000 constant OTG_OTG_DIEPCTL2_EPTYP                           \ EPTYP
$00200000 constant OTG_OTG_DIEPCTL2_STALL                           \ STALL
$03c00000 constant OTG_OTG_DIEPCTL2_TXFNUM                          \ TXFNUM
$04000000 constant OTG_OTG_DIEPCTL2_CNAK                            \ CNAK
$08000000 constant OTG_OTG_DIEPCTL2_SNAK                            \ SNAK
$10000000 constant OTG_OTG_DIEPCTL2_SD0PID_SEVNFRM                  \ SD0PID_SEVNFRM
$20000000 constant OTG_OTG_DIEPCTL2_SODDFRM                         \ SODDFRM
$40000000 constant OTG_OTG_DIEPCTL2_EPDIS                           \ EPDIS
$80000000 constant OTG_OTG_DIEPCTL2_EPENA                           \ EPENA


\
\ @brief This register indicates the status of an endpoint with respect to USB- and AHB-related events. It is shown in Figure724. The application must read this register when the IN endpoints interrupt bit of the core interrupt register (IEPINT in OTG_GINTSTS) is set. Before the application can read this register, it must first read the device all endpoints interrupt (OTG_DAINT) register to get the exact endpoint number for the device endpoint-x interrupt register. The application must clear the appropriate bit in this register to clear the corresponding bits in the OTG_DAINT and OTG_GINTSTS registers.
\ Address offset: 0x948
\ Reset value: 0x00000080
\

$00000001 constant OTG_OTG_DIEPINT2_XFRC                            \ XFRC
$00000002 constant OTG_OTG_DIEPINT2_EPDISD                          \ EPDISD
$00000004 constant OTG_OTG_DIEPINT2_AHBERR                          \ AHBERR
$00000008 constant OTG_OTG_DIEPINT2_TOC                             \ TOC
$00000010 constant OTG_OTG_DIEPINT2_ITTXFE                          \ ITTXFE
$00000020 constant OTG_OTG_DIEPINT2_INEPNM                          \ INEPNM
$00000040 constant OTG_OTG_DIEPINT2_INEPNE                          \ INEPNE
$00000080 constant OTG_OTG_DIEPINT2_TXFE                            \ TXFE
$00000100 constant OTG_OTG_DIEPINT2_TXFIFOUDRN                      \ TXFIFOUDRN
$00000200 constant OTG_OTG_DIEPINT2_BNA                             \ BNA
$00000800 constant OTG_OTG_DIEPINT2_PKTDRPSTS                       \ PKTDRPSTS
$00002000 constant OTG_OTG_DIEPINT2_NAK                             \ NAK


\
\ @brief The application must modify this register before enabling the endpoint. Once the endpoint is enabled using the endpoint enable bit in the OTG_DIEPCTLx registers (EPENA bit in OTG_DIEPCTLx), the core modifies this register. The application can only read this register once the core has cleared the endpoint enable bit.
\ Address offset: 0x950
\ Reset value: 0x00000000
\

$0007ffff constant OTG_OTG_DIEPTSIZ2_XFRSIZ                         \ XFRSIZ
$1ff80000 constant OTG_OTG_DIEPTSIZ2_PKTCNT                         \ PKTCNT
$60000000 constant OTG_OTG_DIEPTSIZ2_MCNT                           \ MCNT


\
\ @brief OTG device IN endpoint 2 DMA address register
\ Address offset: 0x954
\ Reset value: 0x00000000
\

$00000000 constant OTG_OTG_DIEPDMA2_DMAADDR                         \ DMAADDR


\
\ @brief This read-only register contains the free space information for the device IN endpoint Tx FIFO.
\ Address offset: 0x958
\ Reset value: 0x00000200
\

$0000ffff constant OTG_OTG_DTXFSTS2_INEPTFSAV                       \ INEPTFSAV


\
\ @brief The application uses this register to control the behavior of each logical endpoint other than endpoint 0.
\ Address offset: 0x960
\ Reset value: 0x00000000
\

$000007ff constant OTG_OTG_DIEPCTL3_MPSIZ                           \ MPSIZ
$00008000 constant OTG_OTG_DIEPCTL3_USBAEP                          \ USBAEP
$00010000 constant OTG_OTG_DIEPCTL3_EONUM_DPIP                      \ EONUM_DPIP
$00020000 constant OTG_OTG_DIEPCTL3_NAKSTS                          \ NAKSTS
$000c0000 constant OTG_OTG_DIEPCTL3_EPTYP                           \ EPTYP
$00200000 constant OTG_OTG_DIEPCTL3_STALL                           \ STALL
$03c00000 constant OTG_OTG_DIEPCTL3_TXFNUM                          \ TXFNUM
$04000000 constant OTG_OTG_DIEPCTL3_CNAK                            \ CNAK
$08000000 constant OTG_OTG_DIEPCTL3_SNAK                            \ SNAK
$10000000 constant OTG_OTG_DIEPCTL3_SD0PID_SEVNFRM                  \ SD0PID_SEVNFRM
$20000000 constant OTG_OTG_DIEPCTL3_SODDFRM                         \ SODDFRM
$40000000 constant OTG_OTG_DIEPCTL3_EPDIS                           \ EPDIS
$80000000 constant OTG_OTG_DIEPCTL3_EPENA                           \ EPENA


\
\ @brief This register indicates the status of an endpoint with respect to USB- and AHB-related events. It is shown in Figure724. The application must read this register when the IN endpoints interrupt bit of the core interrupt register (IEPINT in OTG_GINTSTS) is set. Before the application can read this register, it must first read the device all endpoints interrupt (OTG_DAINT) register to get the exact endpoint number for the device endpoint-x interrupt register. The application must clear the appropriate bit in this register to clear the corresponding bits in the OTG_DAINT and OTG_GINTSTS registers.
\ Address offset: 0x968
\ Reset value: 0x00000080
\

$00000001 constant OTG_OTG_DIEPINT3_XFRC                            \ XFRC
$00000002 constant OTG_OTG_DIEPINT3_EPDISD                          \ EPDISD
$00000004 constant OTG_OTG_DIEPINT3_AHBERR                          \ AHBERR
$00000008 constant OTG_OTG_DIEPINT3_TOC                             \ TOC
$00000010 constant OTG_OTG_DIEPINT3_ITTXFE                          \ ITTXFE
$00000020 constant OTG_OTG_DIEPINT3_INEPNM                          \ INEPNM
$00000040 constant OTG_OTG_DIEPINT3_INEPNE                          \ INEPNE
$00000080 constant OTG_OTG_DIEPINT3_TXFE                            \ TXFE
$00000100 constant OTG_OTG_DIEPINT3_TXFIFOUDRN                      \ TXFIFOUDRN
$00000200 constant OTG_OTG_DIEPINT3_BNA                             \ BNA
$00000800 constant OTG_OTG_DIEPINT3_PKTDRPSTS                       \ PKTDRPSTS
$00002000 constant OTG_OTG_DIEPINT3_NAK                             \ NAK


\
\ @brief The application must modify this register before enabling the endpoint. Once the endpoint is enabled using the endpoint enable bit in the OTG_DIEPCTLx registers (EPENA bit in OTG_DIEPCTLx), the core modifies this register. The application can only read this register once the core has cleared the endpoint enable bit.
\ Address offset: 0x970
\ Reset value: 0x00000000
\

$0007ffff constant OTG_OTG_DIEPTSIZ3_XFRSIZ                         \ XFRSIZ
$1ff80000 constant OTG_OTG_DIEPTSIZ3_PKTCNT                         \ PKTCNT
$60000000 constant OTG_OTG_DIEPTSIZ3_MCNT                           \ MCNT


\
\ @brief OTG device IN endpoint 3 DMA address register
\ Address offset: 0x974
\ Reset value: 0x00000000
\

$00000000 constant OTG_OTG_DIEPDMA3_DMAADDR                         \ DMAADDR


\
\ @brief This read-only register contains the free space information for the device IN endpoint Tx FIFO.
\ Address offset: 0x978
\ Reset value: 0x00000200
\

$0000ffff constant OTG_OTG_DTXFSTS3_INEPTFSAV                       \ INEPTFSAV


\
\ @brief The application uses this register to control the behavior of each logical endpoint other than endpoint 0.
\ Address offset: 0x980
\ Reset value: 0x00000000
\

$000007ff constant OTG_OTG_DIEPCTL4_MPSIZ                           \ MPSIZ
$00008000 constant OTG_OTG_DIEPCTL4_USBAEP                          \ USBAEP
$00010000 constant OTG_OTG_DIEPCTL4_EONUM_DPIP                      \ EONUM_DPIP
$00020000 constant OTG_OTG_DIEPCTL4_NAKSTS                          \ NAKSTS
$000c0000 constant OTG_OTG_DIEPCTL4_EPTYP                           \ EPTYP
$00200000 constant OTG_OTG_DIEPCTL4_STALL                           \ STALL
$03c00000 constant OTG_OTG_DIEPCTL4_TXFNUM                          \ TXFNUM
$04000000 constant OTG_OTG_DIEPCTL4_CNAK                            \ CNAK
$08000000 constant OTG_OTG_DIEPCTL4_SNAK                            \ SNAK
$10000000 constant OTG_OTG_DIEPCTL4_SD0PID_SEVNFRM                  \ SD0PID_SEVNFRM
$20000000 constant OTG_OTG_DIEPCTL4_SODDFRM                         \ SODDFRM
$40000000 constant OTG_OTG_DIEPCTL4_EPDIS                           \ EPDIS
$80000000 constant OTG_OTG_DIEPCTL4_EPENA                           \ EPENA


\
\ @brief This register indicates the status of an endpoint with respect to USB- and AHB-related events. It is shown in Figure724. The application must read this register when the IN endpoints interrupt bit of the core interrupt register (IEPINT in OTG_GINTSTS) is set. Before the application can read this register, it must first read the device all endpoints interrupt (OTG_DAINT) register to get the exact endpoint number for the device endpoint-x interrupt register. The application must clear the appropriate bit in this register to clear the corresponding bits in the OTG_DAINT and OTG_GINTSTS registers.
\ Address offset: 0x988
\ Reset value: 0x00000080
\

$00000001 constant OTG_OTG_DIEPINT4_XFRC                            \ XFRC
$00000002 constant OTG_OTG_DIEPINT4_EPDISD                          \ EPDISD
$00000004 constant OTG_OTG_DIEPINT4_AHBERR                          \ AHBERR
$00000008 constant OTG_OTG_DIEPINT4_TOC                             \ TOC
$00000010 constant OTG_OTG_DIEPINT4_ITTXFE                          \ ITTXFE
$00000020 constant OTG_OTG_DIEPINT4_INEPNM                          \ INEPNM
$00000040 constant OTG_OTG_DIEPINT4_INEPNE                          \ INEPNE
$00000080 constant OTG_OTG_DIEPINT4_TXFE                            \ TXFE
$00000100 constant OTG_OTG_DIEPINT4_TXFIFOUDRN                      \ TXFIFOUDRN
$00000200 constant OTG_OTG_DIEPINT4_BNA                             \ BNA
$00000800 constant OTG_OTG_DIEPINT4_PKTDRPSTS                       \ PKTDRPSTS
$00002000 constant OTG_OTG_DIEPINT4_NAK                             \ NAK


\
\ @brief The application must modify this register before enabling the endpoint. Once the endpoint is enabled using the endpoint enable bit in the OTG_DIEPCTLx registers (EPENA bit in OTG_DIEPCTLx), the core modifies this register. The application can only read this register once the core has cleared the endpoint enable bit.
\ Address offset: 0x990
\ Reset value: 0x00000000
\

$0007ffff constant OTG_OTG_DIEPTSIZ4_XFRSIZ                         \ XFRSIZ
$1ff80000 constant OTG_OTG_DIEPTSIZ4_PKTCNT                         \ PKTCNT
$60000000 constant OTG_OTG_DIEPTSIZ4_MCNT                           \ MCNT


\
\ @brief OTG device IN endpoint 4 DMA address register
\ Address offset: 0x994
\ Reset value: 0x00000000
\

$00000000 constant OTG_OTG_DIEPDMA4_DMAADDR                         \ DMAADDR


\
\ @brief This read-only register contains the free space information for the device IN endpoint Tx FIFO.
\ Address offset: 0x998
\ Reset value: 0x00000200
\

$0000ffff constant OTG_OTG_DTXFSTS4_INEPTFSAV                       \ INEPTFSAV


\
\ @brief The application uses this register to control the behavior of each logical endpoint other than endpoint 0.
\ Address offset: 0x9A0
\ Reset value: 0x00000000
\

$000007ff constant OTG_OTG_DIEPCTL5_MPSIZ                           \ MPSIZ
$00008000 constant OTG_OTG_DIEPCTL5_USBAEP                          \ USBAEP
$00010000 constant OTG_OTG_DIEPCTL5_EONUM_DPIP                      \ EONUM_DPIP
$00020000 constant OTG_OTG_DIEPCTL5_NAKSTS                          \ NAKSTS
$000c0000 constant OTG_OTG_DIEPCTL5_EPTYP                           \ EPTYP
$00200000 constant OTG_OTG_DIEPCTL5_STALL                           \ STALL
$03c00000 constant OTG_OTG_DIEPCTL5_TXFNUM                          \ TXFNUM
$04000000 constant OTG_OTG_DIEPCTL5_CNAK                            \ CNAK
$08000000 constant OTG_OTG_DIEPCTL5_SNAK                            \ SNAK
$10000000 constant OTG_OTG_DIEPCTL5_SD0PID_SEVNFRM                  \ SD0PID_SEVNFRM
$20000000 constant OTG_OTG_DIEPCTL5_SODDFRM                         \ SODDFRM
$40000000 constant OTG_OTG_DIEPCTL5_EPDIS                           \ EPDIS
$80000000 constant OTG_OTG_DIEPCTL5_EPENA                           \ EPENA


\
\ @brief This register indicates the status of an endpoint with respect to USB- and AHB-related events. It is shown in Figure724. The application must read this register when the IN endpoints interrupt bit of the core interrupt register (IEPINT in OTG_GINTSTS) is set. Before the application can read this register, it must first read the device all endpoints interrupt (OTG_DAINT) register to get the exact endpoint number for the device endpoint-x interrupt register. The application must clear the appropriate bit in this register to clear the corresponding bits in the OTG_DAINT and OTG_GINTSTS registers.
\ Address offset: 0x9A8
\ Reset value: 0x00000080
\

$00000001 constant OTG_OTG_DIEPINT5_XFRC                            \ XFRC
$00000002 constant OTG_OTG_DIEPINT5_EPDISD                          \ EPDISD
$00000004 constant OTG_OTG_DIEPINT5_AHBERR                          \ AHBERR
$00000008 constant OTG_OTG_DIEPINT5_TOC                             \ TOC
$00000010 constant OTG_OTG_DIEPINT5_ITTXFE                          \ ITTXFE
$00000020 constant OTG_OTG_DIEPINT5_INEPNM                          \ INEPNM
$00000040 constant OTG_OTG_DIEPINT5_INEPNE                          \ INEPNE
$00000080 constant OTG_OTG_DIEPINT5_TXFE                            \ TXFE
$00000100 constant OTG_OTG_DIEPINT5_TXFIFOUDRN                      \ TXFIFOUDRN
$00000200 constant OTG_OTG_DIEPINT5_BNA                             \ BNA
$00000800 constant OTG_OTG_DIEPINT5_PKTDRPSTS                       \ PKTDRPSTS
$00002000 constant OTG_OTG_DIEPINT5_NAK                             \ NAK


\
\ @brief The application must modify this register before enabling the endpoint. Once the endpoint is enabled using the endpoint enable bit in the OTG_DIEPCTLx registers (EPENA bit in OTG_DIEPCTLx), the core modifies this register. The application can only read this register once the core has cleared the endpoint enable bit.
\ Address offset: 0x9B0
\ Reset value: 0x00000000
\

$0007ffff constant OTG_OTG_DIEPTSIZ5_XFRSIZ                         \ XFRSIZ
$1ff80000 constant OTG_OTG_DIEPTSIZ5_PKTCNT                         \ PKTCNT
$60000000 constant OTG_OTG_DIEPTSIZ5_MCNT                           \ MCNT


\
\ @brief OTG device IN endpoint 5 DMA address register
\ Address offset: 0x9B4
\ Reset value: 0x00000000
\

$00000000 constant OTG_OTG_DIEPDMA5_DMAADDR                         \ DMAADDR


\
\ @brief This read-only register contains the free space information for the device IN endpoint Tx FIFO.
\ Address offset: 0x9B8
\ Reset value: 0x00000200
\

$0000ffff constant OTG_OTG_DTXFSTS5_INEPTFSAV                       \ INEPTFSAV


\
\ @brief The application uses this register to control the behavior of each logical endpoint other than endpoint 0.
\ Address offset: 0x9C0
\ Reset value: 0x00000000
\

$000007ff constant OTG_OTG_DIEPCTL6_MPSIZ                           \ MPSIZ
$00008000 constant OTG_OTG_DIEPCTL6_USBAEP                          \ USBAEP
$00010000 constant OTG_OTG_DIEPCTL6_EONUM_DPIP                      \ EONUM_DPIP
$00020000 constant OTG_OTG_DIEPCTL6_NAKSTS                          \ NAKSTS
$000c0000 constant OTG_OTG_DIEPCTL6_EPTYP                           \ EPTYP
$00200000 constant OTG_OTG_DIEPCTL6_STALL                           \ STALL
$03c00000 constant OTG_OTG_DIEPCTL6_TXFNUM                          \ TXFNUM
$04000000 constant OTG_OTG_DIEPCTL6_CNAK                            \ CNAK
$08000000 constant OTG_OTG_DIEPCTL6_SNAK                            \ SNAK
$10000000 constant OTG_OTG_DIEPCTL6_SD0PID_SEVNFRM                  \ SD0PID_SEVNFRM
$20000000 constant OTG_OTG_DIEPCTL6_SODDFRM                         \ SODDFRM
$40000000 constant OTG_OTG_DIEPCTL6_EPDIS                           \ EPDIS
$80000000 constant OTG_OTG_DIEPCTL6_EPENA                           \ EPENA


\
\ @brief This register indicates the status of an endpoint with respect to USB- and AHB-related events. It is shown in Figure724. The application must read this register when the IN endpoints interrupt bit of the core interrupt register (IEPINT in OTG_GINTSTS) is set. Before the application can read this register, it must first read the device all endpoints interrupt (OTG_DAINT) register to get the exact endpoint number for the device endpoint-x interrupt register. The application must clear the appropriate bit in this register to clear the corresponding bits in the OTG_DAINT and OTG_GINTSTS registers.
\ Address offset: 0x9C8
\ Reset value: 0x00000080
\

$00000001 constant OTG_OTG_DIEPINT6_XFRC                            \ XFRC
$00000002 constant OTG_OTG_DIEPINT6_EPDISD                          \ EPDISD
$00000004 constant OTG_OTG_DIEPINT6_AHBERR                          \ AHBERR
$00000008 constant OTG_OTG_DIEPINT6_TOC                             \ TOC
$00000010 constant OTG_OTG_DIEPINT6_ITTXFE                          \ ITTXFE
$00000020 constant OTG_OTG_DIEPINT6_INEPNM                          \ INEPNM
$00000040 constant OTG_OTG_DIEPINT6_INEPNE                          \ INEPNE
$00000080 constant OTG_OTG_DIEPINT6_TXFE                            \ TXFE
$00000100 constant OTG_OTG_DIEPINT6_TXFIFOUDRN                      \ TXFIFOUDRN
$00000200 constant OTG_OTG_DIEPINT6_BNA                             \ BNA
$00000800 constant OTG_OTG_DIEPINT6_PKTDRPSTS                       \ PKTDRPSTS
$00002000 constant OTG_OTG_DIEPINT6_NAK                             \ NAK


\
\ @brief The application must modify this register before enabling the endpoint. Once the endpoint is enabled using the endpoint enable bit in the OTG_DIEPCTLx registers (EPENA bit in OTG_DIEPCTLx), the core modifies this register. The application can only read this register once the core has cleared the endpoint enable bit.
\ Address offset: 0x9D0
\ Reset value: 0x00000000
\

$0007ffff constant OTG_OTG_DIEPTSIZ6_XFRSIZ                         \ XFRSIZ
$1ff80000 constant OTG_OTG_DIEPTSIZ6_PKTCNT                         \ PKTCNT
$60000000 constant OTG_OTG_DIEPTSIZ6_MCNT                           \ MCNT


\
\ @brief OTG device IN endpoint 6 DMA address register
\ Address offset: 0x9D4
\ Reset value: 0x00000000
\

$00000000 constant OTG_OTG_DIEPDMA6_DMAADDR                         \ DMAADDR


\
\ @brief This read-only register contains the free space information for the device IN endpoint Tx FIFO.
\ Address offset: 0x9D8
\ Reset value: 0x00000200
\

$0000ffff constant OTG_OTG_DTXFSTS6_INEPTFSAV                       \ INEPTFSAV


\
\ @brief The application uses this register to control the behavior of each logical endpoint other than endpoint 0.
\ Address offset: 0x9E0
\ Reset value: 0x00000000
\

$000007ff constant OTG_OTG_DIEPCTL7_MPSIZ                           \ MPSIZ
$00008000 constant OTG_OTG_DIEPCTL7_USBAEP                          \ USBAEP
$00010000 constant OTG_OTG_DIEPCTL7_EONUM_DPIP                      \ EONUM_DPIP
$00020000 constant OTG_OTG_DIEPCTL7_NAKSTS                          \ NAKSTS
$000c0000 constant OTG_OTG_DIEPCTL7_EPTYP                           \ EPTYP
$00200000 constant OTG_OTG_DIEPCTL7_STALL                           \ STALL
$03c00000 constant OTG_OTG_DIEPCTL7_TXFNUM                          \ TXFNUM
$04000000 constant OTG_OTG_DIEPCTL7_CNAK                            \ CNAK
$08000000 constant OTG_OTG_DIEPCTL7_SNAK                            \ SNAK
$10000000 constant OTG_OTG_DIEPCTL7_SD0PID_SEVNFRM                  \ SD0PID_SEVNFRM
$20000000 constant OTG_OTG_DIEPCTL7_SODDFRM                         \ SODDFRM
$40000000 constant OTG_OTG_DIEPCTL7_EPDIS                           \ EPDIS
$80000000 constant OTG_OTG_DIEPCTL7_EPENA                           \ EPENA


\
\ @brief This register indicates the status of an endpoint with respect to USB- and AHB-related events. It is shown in Figure724. The application must read this register when the IN endpoints interrupt bit of the core interrupt register (IEPINT in OTG_GINTSTS) is set. Before the application can read this register, it must first read the device all endpoints interrupt (OTG_DAINT) register to get the exact endpoint number for the device endpoint-x interrupt register. The application must clear the appropriate bit in this register to clear the corresponding bits in the OTG_DAINT and OTG_GINTSTS registers.
\ Address offset: 0x9E8
\ Reset value: 0x00000080
\

$00000001 constant OTG_OTG_DIEPINT7_XFRC                            \ XFRC
$00000002 constant OTG_OTG_DIEPINT7_EPDISD                          \ EPDISD
$00000004 constant OTG_OTG_DIEPINT7_AHBERR                          \ AHBERR
$00000008 constant OTG_OTG_DIEPINT7_TOC                             \ TOC
$00000010 constant OTG_OTG_DIEPINT7_ITTXFE                          \ ITTXFE
$00000020 constant OTG_OTG_DIEPINT7_INEPNM                          \ INEPNM
$00000040 constant OTG_OTG_DIEPINT7_INEPNE                          \ INEPNE
$00000080 constant OTG_OTG_DIEPINT7_TXFE                            \ TXFE
$00000100 constant OTG_OTG_DIEPINT7_TXFIFOUDRN                      \ TXFIFOUDRN
$00000200 constant OTG_OTG_DIEPINT7_BNA                             \ BNA
$00000800 constant OTG_OTG_DIEPINT7_PKTDRPSTS                       \ PKTDRPSTS
$00002000 constant OTG_OTG_DIEPINT7_NAK                             \ NAK


\
\ @brief The application must modify this register before enabling the endpoint. Once the endpoint is enabled using the endpoint enable bit in the OTG_DIEPCTLx registers (EPENA bit in OTG_DIEPCTLx), the core modifies this register. The application can only read this register once the core has cleared the endpoint enable bit.
\ Address offset: 0x9F0
\ Reset value: 0x00000000
\

$0007ffff constant OTG_OTG_DIEPTSIZ7_XFRSIZ                         \ XFRSIZ
$1ff80000 constant OTG_OTG_DIEPTSIZ7_PKTCNT                         \ PKTCNT
$60000000 constant OTG_OTG_DIEPTSIZ7_MCNT                           \ MCNT


\
\ @brief OTG device IN endpoint 7 DMA address register
\ Address offset: 0x9F4
\ Reset value: 0x00000000
\

$00000000 constant OTG_OTG_DIEPDMA7_DMAADDR                         \ DMAADDR


\
\ @brief This read-only register contains the free space information for the device IN endpoint Tx FIFO.
\ Address offset: 0x9F8
\ Reset value: 0x00000200
\

$0000ffff constant OTG_OTG_DTXFSTS7_INEPTFSAV                       \ INEPTFSAV


\
\ @brief The application uses this register to control the behavior of each logical endpoint other than endpoint 0.
\ Address offset: 0xA00
\ Reset value: 0x00000000
\

$000007ff constant OTG_OTG_DIEPCTL8_MPSIZ                           \ MPSIZ
$00008000 constant OTG_OTG_DIEPCTL8_USBAEP                          \ USBAEP
$00010000 constant OTG_OTG_DIEPCTL8_EONUM_DPIP                      \ EONUM_DPIP
$00020000 constant OTG_OTG_DIEPCTL8_NAKSTS                          \ NAKSTS
$000c0000 constant OTG_OTG_DIEPCTL8_EPTYP                           \ EPTYP
$00200000 constant OTG_OTG_DIEPCTL8_STALL                           \ STALL
$03c00000 constant OTG_OTG_DIEPCTL8_TXFNUM                          \ TXFNUM
$04000000 constant OTG_OTG_DIEPCTL8_CNAK                            \ CNAK
$08000000 constant OTG_OTG_DIEPCTL8_SNAK                            \ SNAK
$10000000 constant OTG_OTG_DIEPCTL8_SD0PID_SEVNFRM                  \ SD0PID_SEVNFRM
$20000000 constant OTG_OTG_DIEPCTL8_SODDFRM                         \ SODDFRM
$40000000 constant OTG_OTG_DIEPCTL8_EPDIS                           \ EPDIS
$80000000 constant OTG_OTG_DIEPCTL8_EPENA                           \ EPENA


\
\ @brief This register indicates the status of an endpoint with respect to USB- and AHB-related events. It is shown in Figure724. The application must read this register when the IN endpoints interrupt bit of the core interrupt register (IEPINT in OTG_GINTSTS) is set. Before the application can read this register, it must first read the device all endpoints interrupt (OTG_DAINT) register to get the exact endpoint number for the device endpoint-x interrupt register. The application must clear the appropriate bit in this register to clear the corresponding bits in the OTG_DAINT and OTG_GINTSTS registers.
\ Address offset: 0xA08
\ Reset value: 0x00000080
\

$00000001 constant OTG_OTG_DIEPINT8_XFRC                            \ XFRC
$00000002 constant OTG_OTG_DIEPINT8_EPDISD                          \ EPDISD
$00000004 constant OTG_OTG_DIEPINT8_AHBERR                          \ AHBERR
$00000008 constant OTG_OTG_DIEPINT8_TOC                             \ TOC
$00000010 constant OTG_OTG_DIEPINT8_ITTXFE                          \ ITTXFE
$00000020 constant OTG_OTG_DIEPINT8_INEPNM                          \ INEPNM
$00000040 constant OTG_OTG_DIEPINT8_INEPNE                          \ INEPNE
$00000080 constant OTG_OTG_DIEPINT8_TXFE                            \ TXFE
$00000100 constant OTG_OTG_DIEPINT8_TXFIFOUDRN                      \ TXFIFOUDRN
$00000200 constant OTG_OTG_DIEPINT8_BNA                             \ BNA
$00000800 constant OTG_OTG_DIEPINT8_PKTDRPSTS                       \ PKTDRPSTS
$00002000 constant OTG_OTG_DIEPINT8_NAK                             \ NAK


\
\ @brief The application must modify this register before enabling the endpoint. Once the endpoint is enabled using the endpoint enable bit in the OTG_DIEPCTLx registers (EPENA bit in OTG_DIEPCTLx), the core modifies this register. The application can only read this register once the core has cleared the endpoint enable bit.
\ Address offset: 0xA10
\ Reset value: 0x00000000
\

$0007ffff constant OTG_OTG_DIEPTSIZ8_XFRSIZ                         \ XFRSIZ
$1ff80000 constant OTG_OTG_DIEPTSIZ8_PKTCNT                         \ PKTCNT
$60000000 constant OTG_OTG_DIEPTSIZ8_MCNT                           \ MCNT


\
\ @brief OTG device IN endpoint 8 DMA address register
\ Address offset: 0xA14
\ Reset value: 0x00000000
\

$00000000 constant OTG_OTG_DIEPDMA8_DMAADDR                         \ DMAADDR


\
\ @brief This read-only register contains the free space information for the device IN endpoint Tx FIFO.
\ Address offset: 0xA18
\ Reset value: 0x00000200
\

$0000ffff constant OTG_OTG_DTXFSTS8_INEPTFSAV                       \ INEPTFSAV


\
\ @brief This section describes the OTG_DOEPCTL0 register.
\ Address offset: 0xB00
\ Reset value: 0x00008000
\

$00000003 constant OTG_OTG_DOEPCTL0_MPSIZ                           \ MPSIZ
$00008000 constant OTG_OTG_DOEPCTL0_USBAEP                          \ USBAEP
$00020000 constant OTG_OTG_DOEPCTL0_NAKSTS                          \ NAKSTS
$000c0000 constant OTG_OTG_DOEPCTL0_EPTYP                           \ EPTYP
$00100000 constant OTG_OTG_DOEPCTL0_SNPM                            \ SNPM
$00200000 constant OTG_OTG_DOEPCTL0_STALL                           \ STALL
$04000000 constant OTG_OTG_DOEPCTL0_CNAK                            \ CNAK
$08000000 constant OTG_OTG_DOEPCTL0_SNAK                            \ SNAK
$40000000 constant OTG_OTG_DOEPCTL0_EPDIS                           \ EPDIS
$80000000 constant OTG_OTG_DOEPCTL0_EPENA                           \ EPENA


\
\ @brief This register indicates the status of an endpoint with respect to USB- and AHB-related events. It is shown in Figure724. The application must read this register when the OUT endpoints interrupt bit of the OTG_GINTSTS register (OEPINT bit in OTG_GINTSTS) is set. Before the application can read this register, it must first read the OTG_DAINT register to get the exact endpoint number for the OTG_DOEPINTx register. The application must clear the appropriate bit in this register to clear the corresponding bits in the OTG_DAINT and OTG_GINTSTS registers.
\ Address offset: 0xB08
\ Reset value: 0x00000080
\

$00000001 constant OTG_OTG_DOEPINT0_XFRC                            \ XFRC
$00000002 constant OTG_OTG_DOEPINT0_EPDISD                          \ EPDISD
$00000004 constant OTG_OTG_DOEPINT0_AHBERR                          \ AHBERR
$00000008 constant OTG_OTG_DOEPINT0_STUP                            \ STUP
$00000010 constant OTG_OTG_DOEPINT0_OTEPDIS                         \ OTEPDIS
$00000020 constant OTG_OTG_DOEPINT0_STSPHSRX                        \ STSPHSRX
$00000040 constant OTG_OTG_DOEPINT0_B2BSTUP                         \ B2BSTUP
$00000100 constant OTG_OTG_DOEPINT0_OUTPKTERR                       \ OUTPKTERR
$00000200 constant OTG_OTG_DOEPINT0_BNA                             \ BNA
$00001000 constant OTG_OTG_DOEPINT0_BERR                            \ BERR
$00002000 constant OTG_OTG_DOEPINT0_NAK                             \ NAK
$00004000 constant OTG_OTG_DOEPINT0_NYET                            \ NYET
$00008000 constant OTG_OTG_DOEPINT0_STPKTRX                         \ STPKTRX


\
\ @brief The application must modify this register before enabling endpoint 0.
\ Address offset: 0xB10
\ Reset value: 0x00000000
\

$0000007f constant OTG_OTG_DOEPTSIZ0_XFRSIZ                         \ XFRSIZ
$00080000 constant OTG_OTG_DOEPTSIZ0_PKTCNT                         \ PKTCNT
$60000000 constant OTG_OTG_DOEPTSIZ0_STUPCNT                        \ STUPCNT


\
\ @brief OTG device OUT endpoint 0 DMA address register
\ Address offset: 0xB14
\ Reset value: 0x00000000
\

$00000000 constant OTG_OTG_DOEPDMA0_DMAADDR                         \ DMAADDR


\
\ @brief The application uses this register to control the behavior of each logical endpoint other than endpoint 0.
\ Address offset: 0xB20
\ Reset value: 0x00000000
\

$000007ff constant OTG_OTG_DOEPCTL1_MPSIZ                           \ MPSIZ
$00008000 constant OTG_OTG_DOEPCTL1_USBAEP                          \ USBAEP
$00010000 constant OTG_OTG_DOEPCTL1_EONUM_DPIP                      \ EONUM_DPIP
$00020000 constant OTG_OTG_DOEPCTL1_NAKSTS                          \ NAKSTS
$000c0000 constant OTG_OTG_DOEPCTL1_EPTYP                           \ EPTYP
$00100000 constant OTG_OTG_DOEPCTL1_SNPM                            \ SNPM
$00200000 constant OTG_OTG_DOEPCTL1_STALL                           \ STALL
$04000000 constant OTG_OTG_DOEPCTL1_CNAK                            \ CNAK
$08000000 constant OTG_OTG_DOEPCTL1_SNAK                            \ SNAK
$10000000 constant OTG_OTG_DOEPCTL1_SD0PID_SEVNFRM                  \ SD0PID_SEVNFRM
$20000000 constant OTG_OTG_DOEPCTL1_SD1PID_SODDFRM                  \ SD1PID_SODDFRM
$40000000 constant OTG_OTG_DOEPCTL1_EPDIS                           \ EPDIS
$80000000 constant OTG_OTG_DOEPCTL1_EPENA                           \ EPENA


\
\ @brief This register indicates the status of an endpoint with respect to USB- and AHB-related events. It is shown in Figure724. The application must read this register when the OUT endpoints interrupt bit of the OTG_GINTSTS register (OEPINT bit in OTG_GINTSTS) is set. Before the application can read this register, it must first read the OTG_DAINT register to get the exact endpoint number for the OTG_DOEPINTx register. The application must clear the appropriate bit in this register to clear the corresponding bits in the OTG_DAINT and OTG_GINTSTS registers.
\ Address offset: 0xB28
\ Reset value: 0x00000080
\

$00000001 constant OTG_OTG_DOEPINT1_XFRC                            \ XFRC
$00000002 constant OTG_OTG_DOEPINT1_EPDISD                          \ EPDISD
$00000004 constant OTG_OTG_DOEPINT1_AHBERR                          \ AHBERR
$00000008 constant OTG_OTG_DOEPINT1_STUP                            \ STUP
$00000010 constant OTG_OTG_DOEPINT1_OTEPDIS                         \ OTEPDIS
$00000020 constant OTG_OTG_DOEPINT1_STSPHSRX                        \ STSPHSRX
$00000040 constant OTG_OTG_DOEPINT1_B2BSTUP                         \ B2BSTUP
$00000100 constant OTG_OTG_DOEPINT1_OUTPKTERR                       \ OUTPKTERR
$00000200 constant OTG_OTG_DOEPINT1_BNA                             \ BNA
$00001000 constant OTG_OTG_DOEPINT1_BERR                            \ BERR
$00002000 constant OTG_OTG_DOEPINT1_NAK                             \ NAK
$00004000 constant OTG_OTG_DOEPINT1_NYET                            \ NYET
$00008000 constant OTG_OTG_DOEPINT1_STPKTRX                         \ STPKTRX


\
\ @brief The application must modify this register before enabling the endpoint. Once the endpoint is enabled using endpoint enable bit of the OTG_DOEPCTLx registers (EPENA bit in OTG_DOEPCTLx), the core modifies this register. The application can only read this register once the core has cleared the endpoint enable bit.
\ Address offset: 0xB30
\ Reset value: 0x00000000
\

$0007ffff constant OTG_OTG_DOEPTSIZ1_XFRSIZ                         \ XFRSIZ
$1ff80000 constant OTG_OTG_DOEPTSIZ1_PKTCNT                         \ PKTCNT
$60000000 constant OTG_OTG_DOEPTSIZ1_RXDPID_STUPCNT                 \ RXDPID_STUPCNT


\
\ @brief OTG device OUT endpoint 1 DMA address register
\ Address offset: 0xB34
\ Reset value: 0x00000000
\

$00000000 constant OTG_OTG_DOEPDMA1_DMAADDR                         \ DMAADDR


\
\ @brief The application uses this register to control the behavior of each logical endpoint other than endpoint 0.
\ Address offset: 0xB40
\ Reset value: 0x00000000
\

$000007ff constant OTG_OTG_DOEPCTL2_MPSIZ                           \ MPSIZ
$00008000 constant OTG_OTG_DOEPCTL2_USBAEP                          \ USBAEP
$00010000 constant OTG_OTG_DOEPCTL2_EONUM_DPIP                      \ EONUM_DPIP
$00020000 constant OTG_OTG_DOEPCTL2_NAKSTS                          \ NAKSTS
$000c0000 constant OTG_OTG_DOEPCTL2_EPTYP                           \ EPTYP
$00100000 constant OTG_OTG_DOEPCTL2_SNPM                            \ SNPM
$00200000 constant OTG_OTG_DOEPCTL2_STALL                           \ STALL
$04000000 constant OTG_OTG_DOEPCTL2_CNAK                            \ CNAK
$08000000 constant OTG_OTG_DOEPCTL2_SNAK                            \ SNAK
$10000000 constant OTG_OTG_DOEPCTL2_SD0PID_SEVNFRM                  \ SD0PID_SEVNFRM
$20000000 constant OTG_OTG_DOEPCTL2_SD1PID_SODDFRM                  \ SD1PID_SODDFRM
$40000000 constant OTG_OTG_DOEPCTL2_EPDIS                           \ EPDIS
$80000000 constant OTG_OTG_DOEPCTL2_EPENA                           \ EPENA


\
\ @brief This register indicates the status of an endpoint with respect to USB- and AHB-related events. It is shown in Figure724. The application must read this register when the OUT endpoints interrupt bit of the OTG_GINTSTS register (OEPINT bit in OTG_GINTSTS) is set. Before the application can read this register, it must first read the OTG_DAINT register to get the exact endpoint number for the OTG_DOEPINTx register. The application must clear the appropriate bit in this register to clear the corresponding bits in the OTG_DAINT and OTG_GINTSTS registers.
\ Address offset: 0xB48
\ Reset value: 0x00000080
\

$00000001 constant OTG_OTG_DOEPINT2_XFRC                            \ XFRC
$00000002 constant OTG_OTG_DOEPINT2_EPDISD                          \ EPDISD
$00000004 constant OTG_OTG_DOEPINT2_AHBERR                          \ AHBERR
$00000008 constant OTG_OTG_DOEPINT2_STUP                            \ STUP
$00000010 constant OTG_OTG_DOEPINT2_OTEPDIS                         \ OTEPDIS
$00000020 constant OTG_OTG_DOEPINT2_STSPHSRX                        \ STSPHSRX
$00000040 constant OTG_OTG_DOEPINT2_B2BSTUP                         \ B2BSTUP
$00000100 constant OTG_OTG_DOEPINT2_OUTPKTERR                       \ OUTPKTERR
$00000200 constant OTG_OTG_DOEPINT2_BNA                             \ BNA
$00001000 constant OTG_OTG_DOEPINT2_BERR                            \ BERR
$00002000 constant OTG_OTG_DOEPINT2_NAK                             \ NAK
$00004000 constant OTG_OTG_DOEPINT2_NYET                            \ NYET
$00008000 constant OTG_OTG_DOEPINT2_STPKTRX                         \ STPKTRX


\
\ @brief The application must modify this register before enabling the endpoint. Once the endpoint is enabled using endpoint enable bit of the OTG_DOEPCTLx registers (EPENA bit in OTG_DOEPCTLx), the core modifies this register. The application can only read this register once the core has cleared the endpoint enable bit.
\ Address offset: 0xB50
\ Reset value: 0x00000000
\

$0007ffff constant OTG_OTG_DOEPTSIZ2_XFRSIZ                         \ XFRSIZ
$1ff80000 constant OTG_OTG_DOEPTSIZ2_PKTCNT                         \ PKTCNT
$60000000 constant OTG_OTG_DOEPTSIZ2_RXDPID_STUPCNT                 \ RXDPID_STUPCNT


\
\ @brief OTG device OUT endpoint 2 DMA address register
\ Address offset: 0xB54
\ Reset value: 0x00000000
\

$00000000 constant OTG_OTG_DOEPDMA2_DMAADDR                         \ DMAADDR


\
\ @brief The application uses this register to control the behavior of each logical endpoint other than endpoint 0.
\ Address offset: 0xB60
\ Reset value: 0x00000000
\

$000007ff constant OTG_OTG_DOEPCTL3_MPSIZ                           \ MPSIZ
$00008000 constant OTG_OTG_DOEPCTL3_USBAEP                          \ USBAEP
$00010000 constant OTG_OTG_DOEPCTL3_EONUM_DPIP                      \ EONUM_DPIP
$00020000 constant OTG_OTG_DOEPCTL3_NAKSTS                          \ NAKSTS
$000c0000 constant OTG_OTG_DOEPCTL3_EPTYP                           \ EPTYP
$00100000 constant OTG_OTG_DOEPCTL3_SNPM                            \ SNPM
$00200000 constant OTG_OTG_DOEPCTL3_STALL                           \ STALL
$04000000 constant OTG_OTG_DOEPCTL3_CNAK                            \ CNAK
$08000000 constant OTG_OTG_DOEPCTL3_SNAK                            \ SNAK
$10000000 constant OTG_OTG_DOEPCTL3_SD0PID_SEVNFRM                  \ SD0PID_SEVNFRM
$20000000 constant OTG_OTG_DOEPCTL3_SD1PID_SODDFRM                  \ SD1PID_SODDFRM
$40000000 constant OTG_OTG_DOEPCTL3_EPDIS                           \ EPDIS
$80000000 constant OTG_OTG_DOEPCTL3_EPENA                           \ EPENA


\
\ @brief This register indicates the status of an endpoint with respect to USB- and AHB-related events. It is shown in Figure724. The application must read this register when the OUT endpoints interrupt bit of the OTG_GINTSTS register (OEPINT bit in OTG_GINTSTS) is set. Before the application can read this register, it must first read the OTG_DAINT register to get the exact endpoint number for the OTG_DOEPINTx register. The application must clear the appropriate bit in this register to clear the corresponding bits in the OTG_DAINT and OTG_GINTSTS registers.
\ Address offset: 0xB68
\ Reset value: 0x00000080
\

$00000001 constant OTG_OTG_DOEPINT3_XFRC                            \ XFRC
$00000002 constant OTG_OTG_DOEPINT3_EPDISD                          \ EPDISD
$00000004 constant OTG_OTG_DOEPINT3_AHBERR                          \ AHBERR
$00000008 constant OTG_OTG_DOEPINT3_STUP                            \ STUP
$00000010 constant OTG_OTG_DOEPINT3_OTEPDIS                         \ OTEPDIS
$00000020 constant OTG_OTG_DOEPINT3_STSPHSRX                        \ STSPHSRX
$00000040 constant OTG_OTG_DOEPINT3_B2BSTUP                         \ B2BSTUP
$00000100 constant OTG_OTG_DOEPINT3_OUTPKTERR                       \ OUTPKTERR
$00000200 constant OTG_OTG_DOEPINT3_BNA                             \ BNA
$00001000 constant OTG_OTG_DOEPINT3_BERR                            \ BERR
$00002000 constant OTG_OTG_DOEPINT3_NAK                             \ NAK
$00004000 constant OTG_OTG_DOEPINT3_NYET                            \ NYET
$00008000 constant OTG_OTG_DOEPINT3_STPKTRX                         \ STPKTRX


\
\ @brief The application must modify this register before enabling the endpoint. Once the endpoint is enabled using endpoint enable bit of the OTG_DOEPCTLx registers (EPENA bit in OTG_DOEPCTLx), the core modifies this register. The application can only read this register once the core has cleared the endpoint enable bit.
\ Address offset: 0xB70
\ Reset value: 0x00000000
\

$0007ffff constant OTG_OTG_DOEPTSIZ3_XFRSIZ                         \ XFRSIZ
$1ff80000 constant OTG_OTG_DOEPTSIZ3_PKTCNT                         \ PKTCNT
$60000000 constant OTG_OTG_DOEPTSIZ3_RXDPID_STUPCNT                 \ RXDPID_STUPCNT


\
\ @brief OTG device OUT endpoint 3 DMA address register
\ Address offset: 0xB74
\ Reset value: 0x00000000
\

$00000000 constant OTG_OTG_DOEPDMA3_DMAADDR                         \ DMAADDR


\
\ @brief The application uses this register to control the behavior of each logical endpoint other than endpoint 0.
\ Address offset: 0xB80
\ Reset value: 0x00000000
\

$000007ff constant OTG_OTG_DOEPCTL4_MPSIZ                           \ MPSIZ
$00008000 constant OTG_OTG_DOEPCTL4_USBAEP                          \ USBAEP
$00010000 constant OTG_OTG_DOEPCTL4_EONUM_DPIP                      \ EONUM_DPIP
$00020000 constant OTG_OTG_DOEPCTL4_NAKSTS                          \ NAKSTS
$000c0000 constant OTG_OTG_DOEPCTL4_EPTYP                           \ EPTYP
$00100000 constant OTG_OTG_DOEPCTL4_SNPM                            \ SNPM
$00200000 constant OTG_OTG_DOEPCTL4_STALL                           \ STALL
$04000000 constant OTG_OTG_DOEPCTL4_CNAK                            \ CNAK
$08000000 constant OTG_OTG_DOEPCTL4_SNAK                            \ SNAK
$10000000 constant OTG_OTG_DOEPCTL4_SD0PID_SEVNFRM                  \ SD0PID_SEVNFRM
$20000000 constant OTG_OTG_DOEPCTL4_SD1PID_SODDFRM                  \ SD1PID_SODDFRM
$40000000 constant OTG_OTG_DOEPCTL4_EPDIS                           \ EPDIS
$80000000 constant OTG_OTG_DOEPCTL4_EPENA                           \ EPENA


\
\ @brief This register indicates the status of an endpoint with respect to USB- and AHB-related events. It is shown in Figure724. The application must read this register when the OUT endpoints interrupt bit of the OTG_GINTSTS register (OEPINT bit in OTG_GINTSTS) is set. Before the application can read this register, it must first read the OTG_DAINT register to get the exact endpoint number for the OTG_DOEPINTx register. The application must clear the appropriate bit in this register to clear the corresponding bits in the OTG_DAINT and OTG_GINTSTS registers.
\ Address offset: 0xB88
\ Reset value: 0x00000080
\

$00000001 constant OTG_OTG_DOEPINT4_XFRC                            \ XFRC
$00000002 constant OTG_OTG_DOEPINT4_EPDISD                          \ EPDISD
$00000004 constant OTG_OTG_DOEPINT4_AHBERR                          \ AHBERR
$00000008 constant OTG_OTG_DOEPINT4_STUP                            \ STUP
$00000010 constant OTG_OTG_DOEPINT4_OTEPDIS                         \ OTEPDIS
$00000020 constant OTG_OTG_DOEPINT4_STSPHSRX                        \ STSPHSRX
$00000040 constant OTG_OTG_DOEPINT4_B2BSTUP                         \ B2BSTUP
$00000100 constant OTG_OTG_DOEPINT4_OUTPKTERR                       \ OUTPKTERR
$00000200 constant OTG_OTG_DOEPINT4_BNA                             \ BNA
$00001000 constant OTG_OTG_DOEPINT4_BERR                            \ BERR
$00002000 constant OTG_OTG_DOEPINT4_NAK                             \ NAK
$00004000 constant OTG_OTG_DOEPINT4_NYET                            \ NYET
$00008000 constant OTG_OTG_DOEPINT4_STPKTRX                         \ STPKTRX


\
\ @brief The application must modify this register before enabling the endpoint. Once the endpoint is enabled using endpoint enable bit of the OTG_DOEPCTLx registers (EPENA bit in OTG_DOEPCTLx), the core modifies this register. The application can only read this register once the core has cleared the endpoint enable bit.
\ Address offset: 0xB90
\ Reset value: 0x00000000
\

$0007ffff constant OTG_OTG_DOEPTSIZ4_XFRSIZ                         \ XFRSIZ
$1ff80000 constant OTG_OTG_DOEPTSIZ4_PKTCNT                         \ PKTCNT
$60000000 constant OTG_OTG_DOEPTSIZ4_RXDPID_STUPCNT                 \ RXDPID_STUPCNT


\
\ @brief OTG device OUT endpoint 4 DMA address register
\ Address offset: 0xB94
\ Reset value: 0x00000000
\

$00000000 constant OTG_OTG_DOEPDMA4_DMAADDR                         \ DMAADDR


\
\ @brief The application uses this register to control the behavior of each logical endpoint other than endpoint 0.
\ Address offset: 0xBA0
\ Reset value: 0x00000000
\

$000007ff constant OTG_OTG_DOEPCTL5_MPSIZ                           \ MPSIZ
$00008000 constant OTG_OTG_DOEPCTL5_USBAEP                          \ USBAEP
$00010000 constant OTG_OTG_DOEPCTL5_EONUM_DPIP                      \ EONUM_DPIP
$00020000 constant OTG_OTG_DOEPCTL5_NAKSTS                          \ NAKSTS
$000c0000 constant OTG_OTG_DOEPCTL5_EPTYP                           \ EPTYP
$00100000 constant OTG_OTG_DOEPCTL5_SNPM                            \ SNPM
$00200000 constant OTG_OTG_DOEPCTL5_STALL                           \ STALL
$04000000 constant OTG_OTG_DOEPCTL5_CNAK                            \ CNAK
$08000000 constant OTG_OTG_DOEPCTL5_SNAK                            \ SNAK
$10000000 constant OTG_OTG_DOEPCTL5_SD0PID_SEVNFRM                  \ SD0PID_SEVNFRM
$20000000 constant OTG_OTG_DOEPCTL5_SD1PID_SODDFRM                  \ SD1PID_SODDFRM
$40000000 constant OTG_OTG_DOEPCTL5_EPDIS                           \ EPDIS
$80000000 constant OTG_OTG_DOEPCTL5_EPENA                           \ EPENA


\
\ @brief This register indicates the status of an endpoint with respect to USB- and AHB-related events. It is shown in Figure724. The application must read this register when the OUT endpoints interrupt bit of the OTG_GINTSTS register (OEPINT bit in OTG_GINTSTS) is set. Before the application can read this register, it must first read the OTG_DAINT register to get the exact endpoint number for the OTG_DOEPINTx register. The application must clear the appropriate bit in this register to clear the corresponding bits in the OTG_DAINT and OTG_GINTSTS registers.
\ Address offset: 0xBA8
\ Reset value: 0x00000080
\

$00000001 constant OTG_OTG_DOEPINT5_XFRC                            \ XFRC
$00000002 constant OTG_OTG_DOEPINT5_EPDISD                          \ EPDISD
$00000004 constant OTG_OTG_DOEPINT5_AHBERR                          \ AHBERR
$00000008 constant OTG_OTG_DOEPINT5_STUP                            \ STUP
$00000010 constant OTG_OTG_DOEPINT5_OTEPDIS                         \ OTEPDIS
$00000020 constant OTG_OTG_DOEPINT5_STSPHSRX                        \ STSPHSRX
$00000040 constant OTG_OTG_DOEPINT5_B2BSTUP                         \ B2BSTUP
$00000100 constant OTG_OTG_DOEPINT5_OUTPKTERR                       \ OUTPKTERR
$00000200 constant OTG_OTG_DOEPINT5_BNA                             \ BNA
$00001000 constant OTG_OTG_DOEPINT5_BERR                            \ BERR
$00002000 constant OTG_OTG_DOEPINT5_NAK                             \ NAK
$00004000 constant OTG_OTG_DOEPINT5_NYET                            \ NYET
$00008000 constant OTG_OTG_DOEPINT5_STPKTRX                         \ STPKTRX


\
\ @brief The application must modify this register before enabling the endpoint. Once the endpoint is enabled using endpoint enable bit of the OTG_DOEPCTLx registers (EPENA bit in OTG_DOEPCTLx), the core modifies this register. The application can only read this register once the core has cleared the endpoint enable bit.
\ Address offset: 0xBB0
\ Reset value: 0x00000000
\

$0007ffff constant OTG_OTG_DOEPTSIZ5_XFRSIZ                         \ XFRSIZ
$1ff80000 constant OTG_OTG_DOEPTSIZ5_PKTCNT                         \ PKTCNT
$60000000 constant OTG_OTG_DOEPTSIZ5_RXDPID_STUPCNT                 \ RXDPID_STUPCNT


\
\ @brief OTG device OUT endpoint 5 DMA address register
\ Address offset: 0xBB4
\ Reset value: 0x00000000
\

$00000000 constant OTG_OTG_DOEPDMA5_DMAADDR                         \ DMAADDR


\
\ @brief The application uses this register to control the behavior of each logical endpoint other than endpoint 0.
\ Address offset: 0xBC0
\ Reset value: 0x00000000
\

$000007ff constant OTG_OTG_DOEPCTL6_MPSIZ                           \ MPSIZ
$00008000 constant OTG_OTG_DOEPCTL6_USBAEP                          \ USBAEP
$00010000 constant OTG_OTG_DOEPCTL6_EONUM_DPIP                      \ EONUM_DPIP
$00020000 constant OTG_OTG_DOEPCTL6_NAKSTS                          \ NAKSTS
$000c0000 constant OTG_OTG_DOEPCTL6_EPTYP                           \ EPTYP
$00100000 constant OTG_OTG_DOEPCTL6_SNPM                            \ SNPM
$00200000 constant OTG_OTG_DOEPCTL6_STALL                           \ STALL
$04000000 constant OTG_OTG_DOEPCTL6_CNAK                            \ CNAK
$08000000 constant OTG_OTG_DOEPCTL6_SNAK                            \ SNAK
$10000000 constant OTG_OTG_DOEPCTL6_SD0PID_SEVNFRM                  \ SD0PID_SEVNFRM
$20000000 constant OTG_OTG_DOEPCTL6_SD1PID_SODDFRM                  \ SD1PID_SODDFRM
$40000000 constant OTG_OTG_DOEPCTL6_EPDIS                           \ EPDIS
$80000000 constant OTG_OTG_DOEPCTL6_EPENA                           \ EPENA


\
\ @brief This register indicates the status of an endpoint with respect to USB- and AHB-related events. It is shown in Figure724. The application must read this register when the OUT endpoints interrupt bit of the OTG_GINTSTS register (OEPINT bit in OTG_GINTSTS) is set. Before the application can read this register, it must first read the OTG_DAINT register to get the exact endpoint number for the OTG_DOEPINTx register. The application must clear the appropriate bit in this register to clear the corresponding bits in the OTG_DAINT and OTG_GINTSTS registers.
\ Address offset: 0xBC8
\ Reset value: 0x00000080
\

$00000001 constant OTG_OTG_DOEPINT6_XFRC                            \ XFRC
$00000002 constant OTG_OTG_DOEPINT6_EPDISD                          \ EPDISD
$00000004 constant OTG_OTG_DOEPINT6_AHBERR                          \ AHBERR
$00000008 constant OTG_OTG_DOEPINT6_STUP                            \ STUP
$00000010 constant OTG_OTG_DOEPINT6_OTEPDIS                         \ OTEPDIS
$00000020 constant OTG_OTG_DOEPINT6_STSPHSRX                        \ STSPHSRX
$00000040 constant OTG_OTG_DOEPINT6_B2BSTUP                         \ B2BSTUP
$00000100 constant OTG_OTG_DOEPINT6_OUTPKTERR                       \ OUTPKTERR
$00000200 constant OTG_OTG_DOEPINT6_BNA                             \ BNA
$00001000 constant OTG_OTG_DOEPINT6_BERR                            \ BERR
$00002000 constant OTG_OTG_DOEPINT6_NAK                             \ NAK
$00004000 constant OTG_OTG_DOEPINT6_NYET                            \ NYET
$00008000 constant OTG_OTG_DOEPINT6_STPKTRX                         \ STPKTRX


\
\ @brief The application must modify this register before enabling the endpoint. Once the endpoint is enabled using endpoint enable bit of the OTG_DOEPCTLx registers (EPENA bit in OTG_DOEPCTLx), the core modifies this register. The application can only read this register once the core has cleared the endpoint enable bit.
\ Address offset: 0xBD0
\ Reset value: 0x00000000
\

$0007ffff constant OTG_OTG_DOEPTSIZ6_XFRSIZ                         \ XFRSIZ
$1ff80000 constant OTG_OTG_DOEPTSIZ6_PKTCNT                         \ PKTCNT
$60000000 constant OTG_OTG_DOEPTSIZ6_RXDPID_STUPCNT                 \ RXDPID_STUPCNT


\
\ @brief OTG device OUT endpoint 6 DMA address register
\ Address offset: 0xBD4
\ Reset value: 0x00000000
\

$00000000 constant OTG_OTG_DOEPDMA6_DMAADDR                         \ DMAADDR


\
\ @brief The application uses this register to control the behavior of each logical endpoint other than endpoint 0.
\ Address offset: 0xBE0
\ Reset value: 0x00000000
\

$000007ff constant OTG_OTG_DOEPCTL7_MPSIZ                           \ MPSIZ
$00008000 constant OTG_OTG_DOEPCTL7_USBAEP                          \ USBAEP
$00010000 constant OTG_OTG_DOEPCTL7_EONUM_DPIP                      \ EONUM_DPIP
$00020000 constant OTG_OTG_DOEPCTL7_NAKSTS                          \ NAKSTS
$000c0000 constant OTG_OTG_DOEPCTL7_EPTYP                           \ EPTYP
$00100000 constant OTG_OTG_DOEPCTL7_SNPM                            \ SNPM
$00200000 constant OTG_OTG_DOEPCTL7_STALL                           \ STALL
$04000000 constant OTG_OTG_DOEPCTL7_CNAK                            \ CNAK
$08000000 constant OTG_OTG_DOEPCTL7_SNAK                            \ SNAK
$10000000 constant OTG_OTG_DOEPCTL7_SD0PID_SEVNFRM                  \ SD0PID_SEVNFRM
$20000000 constant OTG_OTG_DOEPCTL7_SD1PID_SODDFRM                  \ SD1PID_SODDFRM
$40000000 constant OTG_OTG_DOEPCTL7_EPDIS                           \ EPDIS
$80000000 constant OTG_OTG_DOEPCTL7_EPENA                           \ EPENA


\
\ @brief This register indicates the status of an endpoint with respect to USB- and AHB-related events. It is shown in Figure724. The application must read this register when the OUT endpoints interrupt bit of the OTG_GINTSTS register (OEPINT bit in OTG_GINTSTS) is set. Before the application can read this register, it must first read the OTG_DAINT register to get the exact endpoint number for the OTG_DOEPINTx register. The application must clear the appropriate bit in this register to clear the corresponding bits in the OTG_DAINT and OTG_GINTSTS registers.
\ Address offset: 0xBE8
\ Reset value: 0x00000080
\

$00000001 constant OTG_OTG_DOEPINT7_XFRC                            \ XFRC
$00000002 constant OTG_OTG_DOEPINT7_EPDISD                          \ EPDISD
$00000004 constant OTG_OTG_DOEPINT7_AHBERR                          \ AHBERR
$00000008 constant OTG_OTG_DOEPINT7_STUP                            \ STUP
$00000010 constant OTG_OTG_DOEPINT7_OTEPDIS                         \ OTEPDIS
$00000020 constant OTG_OTG_DOEPINT7_STSPHSRX                        \ STSPHSRX
$00000040 constant OTG_OTG_DOEPINT7_B2BSTUP                         \ B2BSTUP
$00000100 constant OTG_OTG_DOEPINT7_OUTPKTERR                       \ OUTPKTERR
$00000200 constant OTG_OTG_DOEPINT7_BNA                             \ BNA
$00001000 constant OTG_OTG_DOEPINT7_BERR                            \ BERR
$00002000 constant OTG_OTG_DOEPINT7_NAK                             \ NAK
$00004000 constant OTG_OTG_DOEPINT7_NYET                            \ NYET
$00008000 constant OTG_OTG_DOEPINT7_STPKTRX                         \ STPKTRX


\
\ @brief The application must modify this register before enabling the endpoint. Once the endpoint is enabled using endpoint enable bit of the OTG_DOEPCTLx registers (EPENA bit in OTG_DOEPCTLx), the core modifies this register. The application can only read this register once the core has cleared the endpoint enable bit.
\ Address offset: 0xBF0
\ Reset value: 0x00000000
\

$0007ffff constant OTG_OTG_DOEPTSIZ7_XFRSIZ                         \ XFRSIZ
$1ff80000 constant OTG_OTG_DOEPTSIZ7_PKTCNT                         \ PKTCNT
$60000000 constant OTG_OTG_DOEPTSIZ7_RXDPID_STUPCNT                 \ RXDPID_STUPCNT


\
\ @brief OTG device OUT endpoint 7 DMA address register
\ Address offset: 0xBF4
\ Reset value: 0x00000000
\

$00000000 constant OTG_OTG_DOEPDMA7_DMAADDR                         \ DMAADDR


\
\ @brief The application uses this register to control the behavior of each logical endpoint other than endpoint 0.
\ Address offset: 0xC00
\ Reset value: 0x00000000
\

$000007ff constant OTG_OTG_DOEPCTL8_MPSIZ                           \ MPSIZ
$00008000 constant OTG_OTG_DOEPCTL8_USBAEP                          \ USBAEP
$00010000 constant OTG_OTG_DOEPCTL8_EONUM_DPIP                      \ EONUM_DPIP
$00020000 constant OTG_OTG_DOEPCTL8_NAKSTS                          \ NAKSTS
$000c0000 constant OTG_OTG_DOEPCTL8_EPTYP                           \ EPTYP
$00100000 constant OTG_OTG_DOEPCTL8_SNPM                            \ SNPM
$00200000 constant OTG_OTG_DOEPCTL8_STALL                           \ STALL
$04000000 constant OTG_OTG_DOEPCTL8_CNAK                            \ CNAK
$08000000 constant OTG_OTG_DOEPCTL8_SNAK                            \ SNAK
$10000000 constant OTG_OTG_DOEPCTL8_SD0PID_SEVNFRM                  \ SD0PID_SEVNFRM
$20000000 constant OTG_OTG_DOEPCTL8_SD1PID_SODDFRM                  \ SD1PID_SODDFRM
$40000000 constant OTG_OTG_DOEPCTL8_EPDIS                           \ EPDIS
$80000000 constant OTG_OTG_DOEPCTL8_EPENA                           \ EPENA


\
\ @brief This register indicates the status of an endpoint with respect to USB- and AHB-related events. It is shown in Figure724. The application must read this register when the OUT endpoints interrupt bit of the OTG_GINTSTS register (OEPINT bit in OTG_GINTSTS) is set. Before the application can read this register, it must first read the OTG_DAINT register to get the exact endpoint number for the OTG_DOEPINTx register. The application must clear the appropriate bit in this register to clear the corresponding bits in the OTG_DAINT and OTG_GINTSTS registers.
\ Address offset: 0xC08
\ Reset value: 0x00000080
\

$00000001 constant OTG_OTG_DOEPINT8_XFRC                            \ XFRC
$00000002 constant OTG_OTG_DOEPINT8_EPDISD                          \ EPDISD
$00000004 constant OTG_OTG_DOEPINT8_AHBERR                          \ AHBERR
$00000008 constant OTG_OTG_DOEPINT8_STUP                            \ STUP
$00000010 constant OTG_OTG_DOEPINT8_OTEPDIS                         \ OTEPDIS
$00000020 constant OTG_OTG_DOEPINT8_STSPHSRX                        \ STSPHSRX
$00000040 constant OTG_OTG_DOEPINT8_B2BSTUP                         \ B2BSTUP
$00000100 constant OTG_OTG_DOEPINT8_OUTPKTERR                       \ OUTPKTERR
$00000200 constant OTG_OTG_DOEPINT8_BNA                             \ BNA
$00001000 constant OTG_OTG_DOEPINT8_BERR                            \ BERR
$00002000 constant OTG_OTG_DOEPINT8_NAK                             \ NAK
$00004000 constant OTG_OTG_DOEPINT8_NYET                            \ NYET
$00008000 constant OTG_OTG_DOEPINT8_STPKTRX                         \ STPKTRX


\
\ @brief The application must modify this register before enabling the endpoint. Once the endpoint is enabled using endpoint enable bit of the OTG_DOEPCTLx registers (EPENA bit in OTG_DOEPCTLx), the core modifies this register. The application can only read this register once the core has cleared the endpoint enable bit.
\ Address offset: 0xC10
\ Reset value: 0x00000000
\

$0007ffff constant OTG_OTG_DOEPTSIZ8_XFRSIZ                         \ XFRSIZ
$1ff80000 constant OTG_OTG_DOEPTSIZ8_PKTCNT                         \ PKTCNT
$60000000 constant OTG_OTG_DOEPTSIZ8_RXDPID_STUPCNT                 \ RXDPID_STUPCNT


\
\ @brief OTG device OUT endpoint 8 DMA address register
\ Address offset: 0xC14
\ Reset value: 0x00000000
\

$00000000 constant OTG_OTG_DOEPDMA8_DMAADDR                         \ DMAADDR


\
\ @brief This register is available in host and device modes.
\ Address offset: 0xE00
\ Reset value: 0x200B8000
\

$00000001 constant OTG_OTG_PCGCCTL_STPPCLK                          \ STPPCLK
$00000002 constant OTG_OTG_PCGCCTL_GATEHCLK                         \ GATEHCLK
$00000010 constant OTG_OTG_PCGCCTL_PHYSUSP                          \ PHYSUSP
$00000020 constant OTG_OTG_PCGCCTL_ENL1GTG                          \ ENL1GTG
$00000040 constant OTG_OTG_PCGCCTL_PHYSLEEP                         \ PHYSLEEP
$00000080 constant OTG_OTG_PCGCCTL_SUSP                             \ SUSP


\
\ @brief OTG
\
$49000000 constant OTG_OTG_GOTGCTL  \ offset: 0x00 : The OTG_GOTGCTL register controls the behavior and reflects the status of the OTG function of the core.
$49000004 constant OTG_OTG_GOTGINT  \ offset: 0x04 : The application reads this register whenever there is an OTG interrupt and clears the bits in this register to clear the OTG interrupt.
$49000008 constant OTG_OTG_GAHBCFG  \ offset: 0x08 : This register can be used to configure the core after power-on or a change in mode. This register mainly contains AHB system-related configuration parameters. Do not change this register after the initial programming. The application must program this register before starting any transactions on either the AHB or the USB.
$4900000c constant OTG_OTG_GUSBCFG  \ offset: 0x0C : This register can be used to configure the core after power-on or a changing to host mode or device mode. It contains USB and USB-PHY related configuration parameters. The application must program this register before starting any transactions on either the AHB or the USB. Do not make changes to this register after the initial programming.
$49000010 constant OTG_OTG_GRSTCTL  \ offset: 0x10 : The application uses this register to reset various hardware features inside the core.
$49000014 constant OTG_OTG_GINTSTS  \ offset: 0x14 : This register interrupts the application for system-level events in the current mode (device mode or host mode). Some of the bits in this register are valid only in host mode, while others are valid in device mode only. This register also indicates the current mode. To clear the interrupt status bits of the rc_w1 type, the application must write 1 into the bit. The FIFO status interrupts are read-only; once software reads from or writes to the FIFO while servicing these interrupts, FIFO interrupt conditions are cleared automatically. The application must clear the OTG_GINTSTS register at initialization before unmasking the interrupt bit to avoid any interrupts generated prior to initialization.
$49000018 constant OTG_OTG_GINTMSK  \ offset: 0x18 : This register works with the core interrupt register to interrupt the application. When an interrupt bit is masked, the interrupt associated with that bit is not generated. However, the core interrupt (OTG_GINTSTS) register bit corresponding to that interrupt is still set.
$4900001c constant OTG_OTG_GRXSTSR  \ offset: 0x1C : This description is for register OTG_GRXSTSR in Device mode. A read to the receive status debug read register returns the contents of the top of the receive FIFO. The core ignores the receive status read when the receive FIFO is empty and returns a value of 0x00000000.
$49000020 constant OTG_OTG_GRXSTSP  \ offset: 0x20 : This description is for register OTG_GRXSTSP in Device mode. Similarly to OTG_GRXSTSR (receive status debug read register) where a read returns the contents of the top of the receive FIFO, a read to OTG_GRXSTSP (receive status read and pop register) additionally pops the top data entry out of the Rx FIFO. The core ignores the receive status pop/read when the receive FIFO is empty and returns a value of 0x00000000. The application must only pop the receive status FIFO when the receive FIFO non-empty bit of the core interrupt register (RXFLVL bit in OTG_GINTSTS) is asserted.
$49000024 constant OTG_OTG_GRXFSIZ  \ offset: 0x24 : The application can program the RAM size that must be allocated to the Rx FIFO.
$49000028 constant OTG_OTG_HNPTXFSIZ  \ offset: 0x28 : Host mode
$4900002c constant OTG_OTG_HNPTXSTS  \ offset: 0x2C : In device mode, this register is not valid. This read-only register contains the free space information for the non-periodic Tx FIFO and the non-periodic transmit request queue.
$49000038 constant OTG_OTG_GCCFG  \ offset: 0x38 : OTG general core configuration register
$4900003c constant OTG_OTG_CID    \ offset: 0x3C : This is a register containing the Product ID as reset value.
$49000054 constant OTG_OTG_GLPMCFG  \ offset: 0x54 : OTG core LPM configuration register
$49000100 constant OTG_OTG_HPTXFSIZ  \ offset: 0x100 : OTG host periodic transmit FIFO size register
$49000104 constant OTG_OTG_DIEPTXF1  \ offset: 0x104 : OTG device IN endpoint transmit FIFO 1 size register
$49000108 constant OTG_OTG_DIEPTXF2  \ offset: 0x108 : OTG device IN endpoint transmit FIFO 2 size register
$4900010c constant OTG_OTG_DIEPTXF3  \ offset: 0x10C : OTG device IN endpoint transmit FIFO 3 size register
$49000110 constant OTG_OTG_DIEPTXF4  \ offset: 0x110 : OTG device IN endpoint transmit FIFO 4 size register
$49000114 constant OTG_OTG_DIEPTXF5  \ offset: 0x114 : OTG device IN endpoint transmit FIFO 5 size register
$49000118 constant OTG_OTG_DIEPTXF6  \ offset: 0x118 : OTG device IN endpoint transmit FIFO 6 size register
$4900011c constant OTG_OTG_DIEPTXF7  \ offset: 0x11C : OTG device IN endpoint transmit FIFO 7 size register
$49000120 constant OTG_OTG_DIEPTXF8  \ offset: 0x120 : OTG device IN endpoint transmit FIFO 8 size register
$49000400 constant OTG_OTG_HCFG   \ offset: 0x400 : This register configures the core after power-on. Do not make changes to this register after initializing the host.
$49000404 constant OTG_OTG_HFIR   \ offset: 0x404 : This register stores the frame interval information for the current speed to which the OTG controller has enumerated.
$49000408 constant OTG_OTG_HFNUM  \ offset: 0x408 : This register indicates the current frame number. It also indicates the time remaining (in terms of the number of PHY clocks) in the current frame.
$49000410 constant OTG_OTG_HPTXSTS  \ offset: 0x410 : This read-only register contains the free space information for the periodic Tx FIFO and the periodic transmit request queue.
$49000414 constant OTG_OTG_HAINT  \ offset: 0x414 : When a significant event occurs on a channel, the host all channels interrupt register interrupts the application using the host channels interrupt bit of the core interrupt register (HCINT bit in OTG_GINTSTS). This is shown in Figure724. There is one interrupt bit per channel, up to a maximum of 16 bits. Bits in this register are set and cleared when the application sets and clears bits in the corresponding host channel-x interrupt register.
$49000418 constant OTG_OTG_HAINTMSK  \ offset: 0x418 : The host all channel interrupt mask register works with the host all channel interrupt register to interrupt the application when an event occurs on a channel. There is one interrupt mask bit per channel, up to a maximum of 16 bits.
$4900041c constant OTG_OTG_HFLBADDR  \ offset: 0x41C : This register holds the starting address of the frame list information (scatter/gather mode).
$49000440 constant OTG_OTG_HPRT   \ offset: 0x440 : This register is available only in host mode. Currently, the OTG host supports only one port. A single register holds USB port-related information such as USB reset, enable, suspend, resume, connect status, and test mode for each port. It is shown in Figure724. The rc_w1 bits in this register can trigger an interrupt to the application through the host port interrupt bit of the core interrupt register (HPRTINT bit in OTG_GINTSTS). On a port interrupt, the application must read this register and clear the bit that caused the interrupt. For the rc_w1 bits, the application must write a 1 to the bit to clear the interrupt.
$49000500 constant OTG_OTG_HCCHAR0  \ offset: 0x500 : OTG host channel 0 characteristics register
$49000504 constant OTG_OTG_HCSPLT0  \ offset: 0x504 : OTG host channel 0 split control register
$49000508 constant OTG_OTG_HCINT0  \ offset: 0x508 : This register indicates the status of a channel with respect to USB- and AHB-related events. It is shown in Figure724. The application must read this register when the host channels interrupt bit in the core interrupt register (HCINT bit in OTG_GINTSTS) is set. Before the application can read this register, it must first read the host all channels interrupt (OTG_HAINT) register to get the exact channel number for the host channel-x interrupt register. The application must clear the appropriate bit in this register to clear the corresponding bits in the OTG_HAINT and OTG_GINTSTS registers.
$4900050c constant OTG_OTG_HCINTMSK0  \ offset: 0x50C : This register reflects the mask for each channel status described in the previous section.
$49000510 constant OTG_OTG_HCTSIZ0  \ offset: 0x510 : OTG host channel 0 transfer size register
$49000514 constant OTG_OTG_HCDMA0  \ offset: 0x514 : OTG host channel 0 DMA address register in buffer DMA [alternate]
$4900051c constant OTG_OTG_HCDMAB0  \ offset: 0x51C : OTG host channel-n DMA address buffer register
$49000520 constant OTG_OTG_HCCHAR1  \ offset: 0x520 : OTG host channel 1 characteristics register
$49000524 constant OTG_OTG_HCSPLT1  \ offset: 0x524 : OTG host channel 1 split control register
$49000528 constant OTG_OTG_HCINT1  \ offset: 0x528 : This register indicates the status of a channel with respect to USB- and AHB-related events. It is shown in Figure724. The application must read this register when the host channels interrupt bit in the core interrupt register (HCINT bit in OTG_GINTSTS) is set. Before the application can read this register, it must first read the host all channels interrupt (OTG_HAINT) register to get the exact channel number for the host channel-x interrupt register. The application must clear the appropriate bit in this register to clear the corresponding bits in the OTG_HAINT and OTG_GINTSTS registers.
$4900052c constant OTG_OTG_HCINTMSK1  \ offset: 0x52C : This register reflects the mask for each channel status described in the previous section.
$49000530 constant OTG_OTG_HCTSIZ1  \ offset: 0x530 : OTG host channel 1 transfer size register
$49000534 constant OTG_OTG_HCDMA1  \ offset: 0x534 : OTG host channel 1 DMA address register in buffer DMA [alternate]
$4900053c constant OTG_OTG_HCDMAB1  \ offset: 0x53C : OTG host channel-n DMA address buffer register
$49000540 constant OTG_OTG_HCCHAR2  \ offset: 0x540 : OTG host channel 2 characteristics register
$49000544 constant OTG_OTG_HCSPLT2  \ offset: 0x544 : OTG host channel 2 split control register
$49000548 constant OTG_OTG_HCINT2  \ offset: 0x548 : This register indicates the status of a channel with respect to USB- and AHB-related events. It is shown in Figure724. The application must read this register when the host channels interrupt bit in the core interrupt register (HCINT bit in OTG_GINTSTS) is set. Before the application can read this register, it must first read the host all channels interrupt (OTG_HAINT) register to get the exact channel number for the host channel-x interrupt register. The application must clear the appropriate bit in this register to clear the corresponding bits in the OTG_HAINT and OTG_GINTSTS registers.
$4900054c constant OTG_OTG_HCINTMSK2  \ offset: 0x54C : This register reflects the mask for each channel status described in the previous section.
$49000550 constant OTG_OTG_HCTSIZ2  \ offset: 0x550 : OTG host channel 2 transfer size register
$49000554 constant OTG_OTG_HCDMA2  \ offset: 0x554 : OTG host channel 2 DMA address register in buffer DMA [alternate]
$4900055c constant OTG_OTG_HCDMAB2  \ offset: 0x55C : OTG host channel-n DMA address buffer register
$49000560 constant OTG_OTG_HCCHAR3  \ offset: 0x560 : OTG host channel 3 characteristics register
$49000564 constant OTG_OTG_HCSPLT3  \ offset: 0x564 : OTG host channel 3 split control register
$49000568 constant OTG_OTG_HCINT3  \ offset: 0x568 : This register indicates the status of a channel with respect to USB- and AHB-related events. It is shown in Figure724. The application must read this register when the host channels interrupt bit in the core interrupt register (HCINT bit in OTG_GINTSTS) is set. Before the application can read this register, it must first read the host all channels interrupt (OTG_HAINT) register to get the exact channel number for the host channel-x interrupt register. The application must clear the appropriate bit in this register to clear the corresponding bits in the OTG_HAINT and OTG_GINTSTS registers.
$4900056c constant OTG_OTG_HCINTMSK3  \ offset: 0x56C : This register reflects the mask for each channel status described in the previous section.
$49000570 constant OTG_OTG_HCTSIZ3  \ offset: 0x570 : OTG host channel 3 transfer size register
$49000574 constant OTG_OTG_HCDMA3  \ offset: 0x574 : OTG host channel 3 DMA address register in buffer DMA [alternate]
$4900057c constant OTG_OTG_HCDMAB3  \ offset: 0x57C : OTG host channel-n DMA address buffer register
$49000580 constant OTG_OTG_HCCHAR4  \ offset: 0x580 : OTG host channel 4 characteristics register
$49000584 constant OTG_OTG_HCSPLT4  \ offset: 0x584 : OTG host channel 4 split control register
$49000588 constant OTG_OTG_HCINT4  \ offset: 0x588 : This register indicates the status of a channel with respect to USB- and AHB-related events. It is shown in Figure724. The application must read this register when the host channels interrupt bit in the core interrupt register (HCINT bit in OTG_GINTSTS) is set. Before the application can read this register, it must first read the host all channels interrupt (OTG_HAINT) register to get the exact channel number for the host channel-x interrupt register. The application must clear the appropriate bit in this register to clear the corresponding bits in the OTG_HAINT and OTG_GINTSTS registers.
$4900058c constant OTG_OTG_HCINTMSK4  \ offset: 0x58C : This register reflects the mask for each channel status described in the previous section.
$49000590 constant OTG_OTG_HCTSIZ4  \ offset: 0x590 : OTG host channel 4 transfer size register
$49000594 constant OTG_OTG_HCDMA4  \ offset: 0x594 : OTG host channel 4 DMA address register in buffer DMA [alternate]
$4900059c constant OTG_OTG_HCDMAB4  \ offset: 0x59C : OTG host channel-n DMA address buffer register
$490005a0 constant OTG_OTG_HCCHAR5  \ offset: 0x5A0 : OTG host channel 5 characteristics register
$490005a4 constant OTG_OTG_HCSPLT5  \ offset: 0x5A4 : OTG host channel 5 split control register
$490005a8 constant OTG_OTG_HCINT5  \ offset: 0x5A8 : This register indicates the status of a channel with respect to USB- and AHB-related events. It is shown in Figure724. The application must read this register when the host channels interrupt bit in the core interrupt register (HCINT bit in OTG_GINTSTS) is set. Before the application can read this register, it must first read the host all channels interrupt (OTG_HAINT) register to get the exact channel number for the host channel-x interrupt register. The application must clear the appropriate bit in this register to clear the corresponding bits in the OTG_HAINT and OTG_GINTSTS registers.
$490005ac constant OTG_OTG_HCINTMSK5  \ offset: 0x5AC : This register reflects the mask for each channel status described in the previous section.
$490005b0 constant OTG_OTG_HCTSIZ5  \ offset: 0x5B0 : OTG host channel 5 transfer size register
$490005b4 constant OTG_OTG_HCDMA5  \ offset: 0x5B4 : OTG host channel 5 DMA address register in buffer DMA [alternate]
$490005bc constant OTG_OTG_HCDMAB5  \ offset: 0x5BC : OTG host channel-n DMA address buffer register
$490005c0 constant OTG_OTG_HCCHAR6  \ offset: 0x5C0 : OTG host channel 6 characteristics register
$490005c4 constant OTG_OTG_HCSPLT6  \ offset: 0x5C4 : OTG host channel 6 split control register
$490005c8 constant OTG_OTG_HCINT6  \ offset: 0x5C8 : This register indicates the status of a channel with respect to USB- and AHB-related events. It is shown in Figure724. The application must read this register when the host channels interrupt bit in the core interrupt register (HCINT bit in OTG_GINTSTS) is set. Before the application can read this register, it must first read the host all channels interrupt (OTG_HAINT) register to get the exact channel number for the host channel-x interrupt register. The application must clear the appropriate bit in this register to clear the corresponding bits in the OTG_HAINT and OTG_GINTSTS registers.
$490005cc constant OTG_OTG_HCINTMSK6  \ offset: 0x5CC : This register reflects the mask for each channel status described in the previous section.
$490005d0 constant OTG_OTG_HCTSIZ6  \ offset: 0x5D0 : OTG host channel 6 transfer size register
$490005d4 constant OTG_OTG_HCDMA6  \ offset: 0x5D4 : OTG host channel 6 DMA address register in buffer DMA [alternate]
$490005dc constant OTG_OTG_HCDMAB6  \ offset: 0x5DC : OTG host channel-n DMA address buffer register
$490005e0 constant OTG_OTG_HCCHAR7  \ offset: 0x5E0 : OTG host channel 7 characteristics register
$490005e4 constant OTG_OTG_HCSPLT7  \ offset: 0x5E4 : OTG host channel 7 split control register
$490005e8 constant OTG_OTG_HCINT7  \ offset: 0x5E8 : This register indicates the status of a channel with respect to USB- and AHB-related events. It is shown in Figure724. The application must read this register when the host channels interrupt bit in the core interrupt register (HCINT bit in OTG_GINTSTS) is set. Before the application can read this register, it must first read the host all channels interrupt (OTG_HAINT) register to get the exact channel number for the host channel-x interrupt register. The application must clear the appropriate bit in this register to clear the corresponding bits in the OTG_HAINT and OTG_GINTSTS registers.
$490005ec constant OTG_OTG_HCINTMSK7  \ offset: 0x5EC : This register reflects the mask for each channel status described in the previous section.
$490005f0 constant OTG_OTG_HCTSIZ7  \ offset: 0x5F0 : OTG host channel 7 transfer size register
$490005f4 constant OTG_OTG_HCDMA7  \ offset: 0x5F4 : OTG host channel 7 DMA address register in buffer DMA [alternate]
$490005fc constant OTG_OTG_HCDMAB7  \ offset: 0x5FC : OTG host channel-n DMA address buffer register
$49000600 constant OTG_OTG_HCCHAR8  \ offset: 0x600 : OTG host channel 8 characteristics register
$49000604 constant OTG_OTG_HCSPLT8  \ offset: 0x604 : OTG host channel 8 split control register
$49000608 constant OTG_OTG_HCINT8  \ offset: 0x608 : This register indicates the status of a channel with respect to USB- and AHB-related events. It is shown in Figure724. The application must read this register when the host channels interrupt bit in the core interrupt register (HCINT bit in OTG_GINTSTS) is set. Before the application can read this register, it must first read the host all channels interrupt (OTG_HAINT) register to get the exact channel number for the host channel-x interrupt register. The application must clear the appropriate bit in this register to clear the corresponding bits in the OTG_HAINT and OTG_GINTSTS registers.
$4900060c constant OTG_OTG_HCINTMSK8  \ offset: 0x60C : This register reflects the mask for each channel status described in the previous section.
$49000610 constant OTG_OTG_HCTSIZ8  \ offset: 0x610 : OTG host channel 8 transfer size register
$49000614 constant OTG_OTG_HCDMA8  \ offset: 0x614 : OTG host channel 8 DMA address register in buffer DMA [alternate]
$4900061c constant OTG_OTG_HCDMAB8  \ offset: 0x61C : OTG host channel-n DMA address buffer register
$49000620 constant OTG_OTG_HCCHAR9  \ offset: 0x620 : OTG host channel 9 characteristics register
$49000624 constant OTG_OTG_HCSPLT9  \ offset: 0x624 : OTG host channel 9 split control register
$49000628 constant OTG_OTG_HCINT9  \ offset: 0x628 : This register indicates the status of a channel with respect to USB- and AHB-related events. It is shown in Figure724. The application must read this register when the host channels interrupt bit in the core interrupt register (HCINT bit in OTG_GINTSTS) is set. Before the application can read this register, it must first read the host all channels interrupt (OTG_HAINT) register to get the exact channel number for the host channel-x interrupt register. The application must clear the appropriate bit in this register to clear the corresponding bits in the OTG_HAINT and OTG_GINTSTS registers.
$4900062c constant OTG_OTG_HCINTMSK9  \ offset: 0x62C : This register reflects the mask for each channel status described in the previous section.
$49000630 constant OTG_OTG_HCTSIZ9  \ offset: 0x630 : OTG host channel 9 transfer size register
$49000634 constant OTG_OTG_HCDMA9  \ offset: 0x634 : OTG host channel 9 DMA address register in buffer DMA [alternate]
$4900063c constant OTG_OTG_HCDMAB9  \ offset: 0x63C : OTG host channel-n DMA address buffer register
$49000640 constant OTG_OTG_HCCHAR10  \ offset: 0x640 : OTG host channel 10 characteristics register
$49000644 constant OTG_OTG_HCSPLT10  \ offset: 0x644 : OTG host channel 10 split control register
$49000648 constant OTG_OTG_HCINT10  \ offset: 0x648 : This register indicates the status of a channel with respect to USB- and AHB-related events. It is shown in Figure724. The application must read this register when the host channels interrupt bit in the core interrupt register (HCINT bit in OTG_GINTSTS) is set. Before the application can read this register, it must first read the host all channels interrupt (OTG_HAINT) register to get the exact channel number for the host channel-x interrupt register. The application must clear the appropriate bit in this register to clear the corresponding bits in the OTG_HAINT and OTG_GINTSTS registers.
$4900064c constant OTG_OTG_HCINTMSK10  \ offset: 0x64C : This register reflects the mask for each channel status described in the previous section.
$49000650 constant OTG_OTG_HCTSIZ10  \ offset: 0x650 : OTG host channel 10 transfer size register
$49000654 constant OTG_OTG_HCDMA10  \ offset: 0x654 : OTG host channel 10 DMA address register in buffer DMA [alternate]
$4900065c constant OTG_OTG_HCDMAB10  \ offset: 0x65C : OTG host channel-n DMA address buffer register
$49000660 constant OTG_OTG_HCCHAR11  \ offset: 0x660 : OTG host channel 11 characteristics register
$49000664 constant OTG_OTG_HCSPLT11  \ offset: 0x664 : OTG host channel 11 split control register
$49000668 constant OTG_OTG_HCINT11  \ offset: 0x668 : This register indicates the status of a channel with respect to USB- and AHB-related events. It is shown in Figure724. The application must read this register when the host channels interrupt bit in the core interrupt register (HCINT bit in OTG_GINTSTS) is set. Before the application can read this register, it must first read the host all channels interrupt (OTG_HAINT) register to get the exact channel number for the host channel-x interrupt register. The application must clear the appropriate bit in this register to clear the corresponding bits in the OTG_HAINT and OTG_GINTSTS registers.
$4900066c constant OTG_OTG_HCINTMSK11  \ offset: 0x66C : This register reflects the mask for each channel status described in the previous section.
$49000670 constant OTG_OTG_HCTSIZ11  \ offset: 0x670 : OTG host channel 11 transfer size register
$49000674 constant OTG_OTG_HCDMA11  \ offset: 0x674 : OTG host channel 11 DMA address register in buffer DMA [alternate]
$4900067c constant OTG_OTG_HCDMAB11  \ offset: 0x67C : OTG host channel-n DMA address buffer register
$49000680 constant OTG_OTG_HCCHAR12  \ offset: 0x680 : OTG host channel 12 characteristics register
$49000684 constant OTG_OTG_HCSPLT12  \ offset: 0x684 : OTG host channel 12 split control register
$49000688 constant OTG_OTG_HCINT12  \ offset: 0x688 : This register indicates the status of a channel with respect to USB- and AHB-related events. It is shown in Figure724. The application must read this register when the host channels interrupt bit in the core interrupt register (HCINT bit in OTG_GINTSTS) is set. Before the application can read this register, it must first read the host all channels interrupt (OTG_HAINT) register to get the exact channel number for the host channel-x interrupt register. The application must clear the appropriate bit in this register to clear the corresponding bits in the OTG_HAINT and OTG_GINTSTS registers.
$4900068c constant OTG_OTG_HCINTMSK12  \ offset: 0x68C : This register reflects the mask for each channel status described in the previous section.
$49000690 constant OTG_OTG_HCTSIZ12  \ offset: 0x690 : OTG host channel 12 transfer size register
$49000694 constant OTG_OTG_HCDMA12  \ offset: 0x694 : OTG host channel 12 DMA address register in buffer DMA [alternate]
$4900069c constant OTG_OTG_HCDMAB12  \ offset: 0x69C : OTG host channel-n DMA address buffer register
$490006a0 constant OTG_OTG_HCCHAR13  \ offset: 0x6A0 : OTG host channel 13 characteristics register
$490006a4 constant OTG_OTG_HCSPLT13  \ offset: 0x6A4 : OTG host channel 13 split control register
$490006a8 constant OTG_OTG_HCINT13  \ offset: 0x6A8 : This register indicates the status of a channel with respect to USB- and AHB-related events. It is shown in Figure724. The application must read this register when the host channels interrupt bit in the core interrupt register (HCINT bit in OTG_GINTSTS) is set. Before the application can read this register, it must first read the host all channels interrupt (OTG_HAINT) register to get the exact channel number for the host channel-x interrupt register. The application must clear the appropriate bit in this register to clear the corresponding bits in the OTG_HAINT and OTG_GINTSTS registers.
$490006ac constant OTG_OTG_HCINTMSK13  \ offset: 0x6AC : This register reflects the mask for each channel status described in the previous section.
$490006b0 constant OTG_OTG_HCTSIZ13  \ offset: 0x6B0 : OTG host channel 13 transfer size register
$490006b4 constant OTG_OTG_HCDMA13  \ offset: 0x6B4 : OTG host channel 13 DMA address register in buffer DMA [alternate]
$490006bc constant OTG_OTG_HCDMAB13  \ offset: 0x6BC : OTG host channel-n DMA address buffer register
$490006c0 constant OTG_OTG_HCCHAR14  \ offset: 0x6C0 : OTG host channel 14 characteristics register
$490006c4 constant OTG_OTG_HCSPLT14  \ offset: 0x6C4 : OTG host channel 14 split control register
$490006c8 constant OTG_OTG_HCINT14  \ offset: 0x6C8 : This register indicates the status of a channel with respect to USB- and AHB-related events. It is shown in Figure724. The application must read this register when the host channels interrupt bit in the core interrupt register (HCINT bit in OTG_GINTSTS) is set. Before the application can read this register, it must first read the host all channels interrupt (OTG_HAINT) register to get the exact channel number for the host channel-x interrupt register. The application must clear the appropriate bit in this register to clear the corresponding bits in the OTG_HAINT and OTG_GINTSTS registers.
$490006cc constant OTG_OTG_HCINTMSK14  \ offset: 0x6CC : This register reflects the mask for each channel status described in the previous section.
$490006d0 constant OTG_OTG_HCTSIZ14  \ offset: 0x6D0 : OTG host channel 14 transfer size register
$490006d4 constant OTG_OTG_HCDMA14  \ offset: 0x6D4 : OTG host channel 14 DMA address register in buffer DMA [alternate]
$490006dc constant OTG_OTG_HCDMAB14  \ offset: 0x6DC : OTG host channel-n DMA address buffer register
$490006e0 constant OTG_OTG_HCCHAR15  \ offset: 0x6E0 : OTG host channel 15 characteristics register
$490006e4 constant OTG_OTG_HCSPLT15  \ offset: 0x6E4 : OTG host channel 15 split control register
$490006e8 constant OTG_OTG_HCINT15  \ offset: 0x6E8 : This register indicates the status of a channel with respect to USB- and AHB-related events. It is shown in Figure724. The application must read this register when the host channels interrupt bit in the core interrupt register (HCINT bit in OTG_GINTSTS) is set. Before the application can read this register, it must first read the host all channels interrupt (OTG_HAINT) register to get the exact channel number for the host channel-x interrupt register. The application must clear the appropriate bit in this register to clear the corresponding bits in the OTG_HAINT and OTG_GINTSTS registers.
$490006ec constant OTG_OTG_HCINTMSK15  \ offset: 0x6EC : This register reflects the mask for each channel status described in the previous section.
$490006f0 constant OTG_OTG_HCTSIZ15  \ offset: 0x6F0 : OTG host channel 15 transfer size register
$490006f4 constant OTG_OTG_HCDMA15  \ offset: 0x6F4 : OTG host channel 15 DMA address register in buffer DMA [alternate]
$490006fc constant OTG_OTG_HCDMAB15  \ offset: 0x6FC : OTG host channel-n DMA address buffer register
$49000800 constant OTG_OTG_DCFG   \ offset: 0x800 : This register configures the core in device mode after power-on or after certain control commands or enumeration. Do not make changes to this register after initial programming.
$49000804 constant OTG_OTG_DCTL   \ offset: 0x804 : OTG device control register
$49000808 constant OTG_OTG_DSTS   \ offset: 0x808 : This register indicates the status of the core with respect to USB-related events. It must be read on interrupts from the device all interrupts (OTG_DAINT) register.
$49000810 constant OTG_OTG_DIEPMSK  \ offset: 0x810 : This register works with each of the OTG_DIEPINTx registers for all endpoints to generate an interrupt per IN endpoint. The IN endpoint interrupt for a specific status in the OTG_DIEPINTx register can be masked by writing to the corresponding bit in this register. Status bits are masked by default.
$49000814 constant OTG_OTG_DOEPMSK  \ offset: 0x814 : This register works with each of the OTG_DOEPINTx registers for all endpoints to generate an interrupt per OUT endpoint. The OUT endpoint interrupt for a specific status in the OTG_DOEPINTx register can be masked by writing into the corresponding bit in this register. Status bits are masked by default.
$49000818 constant OTG_OTG_DAINT  \ offset: 0x818 : When a significant event occurs on an endpoint, a OTG_DAINT register interrupts the application using the device OUT endpoints interrupt bit or device IN endpoints interrupt bit of the OTG_GINTSTS register (OEPINT or IEPINT in OTG_GINTSTS, respectively). There is one interrupt bit per endpoint, up to a maximum of 16 bits for OUT endpoints and 16 bits for IN endpoints. For a bidirectional endpoint, the corresponding IN and OUT interrupt bits are used. Bits in this register are set and cleared when the application sets and clears bits in the corresponding device endpoint-x interrupt register (OTG_DIEPINTx/OTG_DOEPINTx).
$4900081c constant OTG_OTG_DAINTMSK  \ offset: 0x81C : The OTG_DAINTMSK register works with the device endpoint interrupt register to interrupt the application when an event occurs on a device endpoint. However, the OTG_DAINT register bit corresponding to that interrupt is still set.
$49000828 constant OTG_OTG_DVBUSDIS  \ offset: 0x828 : This register specifies the VBUS discharge time after VBUS pulsing during SRP.
$4900082c constant OTG_OTG_DVBUSPULSE  \ offset: 0x82C : This register specifies the VBUS pulsing time during SRP.
$49000830 constant OTG_OTG_DTHRCTL  \ offset: 0x830 : OTG device threshold control register
$49000834 constant OTG_OTG_DIEPEMPMSK  \ offset: 0x834 : This register is used to control the IN endpoint FIFO empty interrupt generation (TXFE_OTG_DIEPINTx).
$49000838 constant OTG_OTG_DEACHINT  \ offset: 0x838 : OTG device each endpoint interrupt register
$4900083c constant OTG_OTG_DEACHINTMSK  \ offset: 0x83C : There is one interrupt bit for endpoint 1 IN and one interrupt bit for endpoint 1 OUT.
$49000844 constant OTG_OTG_HS_DIEPEACHMSK1  \ offset: 0x844 : This register works with the OTG_DIEPINT1 register to generate a dedicated interrupt OTG_HS_EP1_IN for endpoint #1. The IN endpoint interrupt for a specific status in the OTG_DOEPINT1 register can be masked by writing into the corresponding bit in this register. Status bits are masked by default.
$49000884 constant OTG_OTG_HS_DOEPEACHMSK1  \ offset: 0x884 : This register works with the OTG_DOEPINT1 register to generate a dedicated interrupt OTG_HS_EP1_OUT for endpoint #1. The OUT endpoint interrupt for a specific status in the OTG_DOEPINT1 register can be masked by writing into the corresponding bit in this register. Status bits are masked by default.
$49000900 constant OTG_OTG_DIEPCTL0  \ offset: 0x900 : The application uses this register to control the behavior of each logical endpoint other than endpoint 0.
$49000908 constant OTG_OTG_DIEPINT0  \ offset: 0x908 : This register indicates the status of an endpoint with respect to USB- and AHB-related events. It is shown in Figure724. The application must read this register when the IN endpoints interrupt bit of the core interrupt register (IEPINT in OTG_GINTSTS) is set. Before the application can read this register, it must first read the device all endpoints interrupt (OTG_DAINT) register to get the exact endpoint number for the device endpoint-x interrupt register. The application must clear the appropriate bit in this register to clear the corresponding bits in the OTG_DAINT and OTG_GINTSTS registers.
$49000910 constant OTG_OTG_DIEPTSIZ0  \ offset: 0x910 : The application must modify this register before enabling endpoint 0.
$49000914 constant OTG_OTG_DIEPDMA0  \ offset: 0x914 : OTG device IN endpoint 0 DMA address register
$49000918 constant OTG_OTG_DTXFSTS0  \ offset: 0x918 : This read-only register contains the free space information for the device IN endpoint Tx FIFO.
$49000920 constant OTG_OTG_DIEPCTL1  \ offset: 0x920 : The application uses this register to control the behavior of each logical endpoint other than endpoint 0.
$49000928 constant OTG_OTG_DIEPINT1  \ offset: 0x928 : This register indicates the status of an endpoint with respect to USB- and AHB-related events. It is shown in Figure724. The application must read this register when the IN endpoints interrupt bit of the core interrupt register (IEPINT in OTG_GINTSTS) is set. Before the application can read this register, it must first read the device all endpoints interrupt (OTG_DAINT) register to get the exact endpoint number for the device endpoint-x interrupt register. The application must clear the appropriate bit in this register to clear the corresponding bits in the OTG_DAINT and OTG_GINTSTS registers.
$49000930 constant OTG_OTG_DIEPTSIZ1  \ offset: 0x930 : The application must modify this register before enabling the endpoint. Once the endpoint is enabled using the endpoint enable bit in the OTG_DIEPCTLx registers (EPENA bit in OTG_DIEPCTLx), the core modifies this register. The application can only read this register once the core has cleared the endpoint enable bit.
$49000934 constant OTG_OTG_DIEPDMA1  \ offset: 0x934 : OTG device IN endpoint 1 DMA address register
$49000938 constant OTG_OTG_DTXFSTS1  \ offset: 0x938 : This read-only register contains the free space information for the device IN endpoint Tx FIFO.
$49000940 constant OTG_OTG_DIEPCTL2  \ offset: 0x940 : The application uses this register to control the behavior of each logical endpoint other than endpoint 0.
$49000948 constant OTG_OTG_DIEPINT2  \ offset: 0x948 : This register indicates the status of an endpoint with respect to USB- and AHB-related events. It is shown in Figure724. The application must read this register when the IN endpoints interrupt bit of the core interrupt register (IEPINT in OTG_GINTSTS) is set. Before the application can read this register, it must first read the device all endpoints interrupt (OTG_DAINT) register to get the exact endpoint number for the device endpoint-x interrupt register. The application must clear the appropriate bit in this register to clear the corresponding bits in the OTG_DAINT and OTG_GINTSTS registers.
$49000950 constant OTG_OTG_DIEPTSIZ2  \ offset: 0x950 : The application must modify this register before enabling the endpoint. Once the endpoint is enabled using the endpoint enable bit in the OTG_DIEPCTLx registers (EPENA bit in OTG_DIEPCTLx), the core modifies this register. The application can only read this register once the core has cleared the endpoint enable bit.
$49000954 constant OTG_OTG_DIEPDMA2  \ offset: 0x954 : OTG device IN endpoint 2 DMA address register
$49000958 constant OTG_OTG_DTXFSTS2  \ offset: 0x958 : This read-only register contains the free space information for the device IN endpoint Tx FIFO.
$49000960 constant OTG_OTG_DIEPCTL3  \ offset: 0x960 : The application uses this register to control the behavior of each logical endpoint other than endpoint 0.
$49000968 constant OTG_OTG_DIEPINT3  \ offset: 0x968 : This register indicates the status of an endpoint with respect to USB- and AHB-related events. It is shown in Figure724. The application must read this register when the IN endpoints interrupt bit of the core interrupt register (IEPINT in OTG_GINTSTS) is set. Before the application can read this register, it must first read the device all endpoints interrupt (OTG_DAINT) register to get the exact endpoint number for the device endpoint-x interrupt register. The application must clear the appropriate bit in this register to clear the corresponding bits in the OTG_DAINT and OTG_GINTSTS registers.
$49000970 constant OTG_OTG_DIEPTSIZ3  \ offset: 0x970 : The application must modify this register before enabling the endpoint. Once the endpoint is enabled using the endpoint enable bit in the OTG_DIEPCTLx registers (EPENA bit in OTG_DIEPCTLx), the core modifies this register. The application can only read this register once the core has cleared the endpoint enable bit.
$49000974 constant OTG_OTG_DIEPDMA3  \ offset: 0x974 : OTG device IN endpoint 3 DMA address register
$49000978 constant OTG_OTG_DTXFSTS3  \ offset: 0x978 : This read-only register contains the free space information for the device IN endpoint Tx FIFO.
$49000980 constant OTG_OTG_DIEPCTL4  \ offset: 0x980 : The application uses this register to control the behavior of each logical endpoint other than endpoint 0.
$49000988 constant OTG_OTG_DIEPINT4  \ offset: 0x988 : This register indicates the status of an endpoint with respect to USB- and AHB-related events. It is shown in Figure724. The application must read this register when the IN endpoints interrupt bit of the core interrupt register (IEPINT in OTG_GINTSTS) is set. Before the application can read this register, it must first read the device all endpoints interrupt (OTG_DAINT) register to get the exact endpoint number for the device endpoint-x interrupt register. The application must clear the appropriate bit in this register to clear the corresponding bits in the OTG_DAINT and OTG_GINTSTS registers.
$49000990 constant OTG_OTG_DIEPTSIZ4  \ offset: 0x990 : The application must modify this register before enabling the endpoint. Once the endpoint is enabled using the endpoint enable bit in the OTG_DIEPCTLx registers (EPENA bit in OTG_DIEPCTLx), the core modifies this register. The application can only read this register once the core has cleared the endpoint enable bit.
$49000994 constant OTG_OTG_DIEPDMA4  \ offset: 0x994 : OTG device IN endpoint 4 DMA address register
$49000998 constant OTG_OTG_DTXFSTS4  \ offset: 0x998 : This read-only register contains the free space information for the device IN endpoint Tx FIFO.
$490009a0 constant OTG_OTG_DIEPCTL5  \ offset: 0x9A0 : The application uses this register to control the behavior of each logical endpoint other than endpoint 0.
$490009a8 constant OTG_OTG_DIEPINT5  \ offset: 0x9A8 : This register indicates the status of an endpoint with respect to USB- and AHB-related events. It is shown in Figure724. The application must read this register when the IN endpoints interrupt bit of the core interrupt register (IEPINT in OTG_GINTSTS) is set. Before the application can read this register, it must first read the device all endpoints interrupt (OTG_DAINT) register to get the exact endpoint number for the device endpoint-x interrupt register. The application must clear the appropriate bit in this register to clear the corresponding bits in the OTG_DAINT and OTG_GINTSTS registers.
$490009b0 constant OTG_OTG_DIEPTSIZ5  \ offset: 0x9B0 : The application must modify this register before enabling the endpoint. Once the endpoint is enabled using the endpoint enable bit in the OTG_DIEPCTLx registers (EPENA bit in OTG_DIEPCTLx), the core modifies this register. The application can only read this register once the core has cleared the endpoint enable bit.
$490009b4 constant OTG_OTG_DIEPDMA5  \ offset: 0x9B4 : OTG device IN endpoint 5 DMA address register
$490009b8 constant OTG_OTG_DTXFSTS5  \ offset: 0x9B8 : This read-only register contains the free space information for the device IN endpoint Tx FIFO.
$490009c0 constant OTG_OTG_DIEPCTL6  \ offset: 0x9C0 : The application uses this register to control the behavior of each logical endpoint other than endpoint 0.
$490009c8 constant OTG_OTG_DIEPINT6  \ offset: 0x9C8 : This register indicates the status of an endpoint with respect to USB- and AHB-related events. It is shown in Figure724. The application must read this register when the IN endpoints interrupt bit of the core interrupt register (IEPINT in OTG_GINTSTS) is set. Before the application can read this register, it must first read the device all endpoints interrupt (OTG_DAINT) register to get the exact endpoint number for the device endpoint-x interrupt register. The application must clear the appropriate bit in this register to clear the corresponding bits in the OTG_DAINT and OTG_GINTSTS registers.
$490009d0 constant OTG_OTG_DIEPTSIZ6  \ offset: 0x9D0 : The application must modify this register before enabling the endpoint. Once the endpoint is enabled using the endpoint enable bit in the OTG_DIEPCTLx registers (EPENA bit in OTG_DIEPCTLx), the core modifies this register. The application can only read this register once the core has cleared the endpoint enable bit.
$490009d4 constant OTG_OTG_DIEPDMA6  \ offset: 0x9D4 : OTG device IN endpoint 6 DMA address register
$490009d8 constant OTG_OTG_DTXFSTS6  \ offset: 0x9D8 : This read-only register contains the free space information for the device IN endpoint Tx FIFO.
$490009e0 constant OTG_OTG_DIEPCTL7  \ offset: 0x9E0 : The application uses this register to control the behavior of each logical endpoint other than endpoint 0.
$490009e8 constant OTG_OTG_DIEPINT7  \ offset: 0x9E8 : This register indicates the status of an endpoint with respect to USB- and AHB-related events. It is shown in Figure724. The application must read this register when the IN endpoints interrupt bit of the core interrupt register (IEPINT in OTG_GINTSTS) is set. Before the application can read this register, it must first read the device all endpoints interrupt (OTG_DAINT) register to get the exact endpoint number for the device endpoint-x interrupt register. The application must clear the appropriate bit in this register to clear the corresponding bits in the OTG_DAINT and OTG_GINTSTS registers.
$490009f0 constant OTG_OTG_DIEPTSIZ7  \ offset: 0x9F0 : The application must modify this register before enabling the endpoint. Once the endpoint is enabled using the endpoint enable bit in the OTG_DIEPCTLx registers (EPENA bit in OTG_DIEPCTLx), the core modifies this register. The application can only read this register once the core has cleared the endpoint enable bit.
$490009f4 constant OTG_OTG_DIEPDMA7  \ offset: 0x9F4 : OTG device IN endpoint 7 DMA address register
$490009f8 constant OTG_OTG_DTXFSTS7  \ offset: 0x9F8 : This read-only register contains the free space information for the device IN endpoint Tx FIFO.
$49000a00 constant OTG_OTG_DIEPCTL8  \ offset: 0xA00 : The application uses this register to control the behavior of each logical endpoint other than endpoint 0.
$49000a08 constant OTG_OTG_DIEPINT8  \ offset: 0xA08 : This register indicates the status of an endpoint with respect to USB- and AHB-related events. It is shown in Figure724. The application must read this register when the IN endpoints interrupt bit of the core interrupt register (IEPINT in OTG_GINTSTS) is set. Before the application can read this register, it must first read the device all endpoints interrupt (OTG_DAINT) register to get the exact endpoint number for the device endpoint-x interrupt register. The application must clear the appropriate bit in this register to clear the corresponding bits in the OTG_DAINT and OTG_GINTSTS registers.
$49000a10 constant OTG_OTG_DIEPTSIZ8  \ offset: 0xA10 : The application must modify this register before enabling the endpoint. Once the endpoint is enabled using the endpoint enable bit in the OTG_DIEPCTLx registers (EPENA bit in OTG_DIEPCTLx), the core modifies this register. The application can only read this register once the core has cleared the endpoint enable bit.
$49000a14 constant OTG_OTG_DIEPDMA8  \ offset: 0xA14 : OTG device IN endpoint 8 DMA address register
$49000a18 constant OTG_OTG_DTXFSTS8  \ offset: 0xA18 : This read-only register contains the free space information for the device IN endpoint Tx FIFO.
$49000b00 constant OTG_OTG_DOEPCTL0  \ offset: 0xB00 : This section describes the OTG_DOEPCTL0 register.
$49000b08 constant OTG_OTG_DOEPINT0  \ offset: 0xB08 : This register indicates the status of an endpoint with respect to USB- and AHB-related events. It is shown in Figure724. The application must read this register when the OUT endpoints interrupt bit of the OTG_GINTSTS register (OEPINT bit in OTG_GINTSTS) is set. Before the application can read this register, it must first read the OTG_DAINT register to get the exact endpoint number for the OTG_DOEPINTx register. The application must clear the appropriate bit in this register to clear the corresponding bits in the OTG_DAINT and OTG_GINTSTS registers.
$49000b10 constant OTG_OTG_DOEPTSIZ0  \ offset: 0xB10 : The application must modify this register before enabling endpoint 0.
$49000b14 constant OTG_OTG_DOEPDMA0  \ offset: 0xB14 : OTG device OUT endpoint 0 DMA address register
$49000b20 constant OTG_OTG_DOEPCTL1  \ offset: 0xB20 : The application uses this register to control the behavior of each logical endpoint other than endpoint 0.
$49000b28 constant OTG_OTG_DOEPINT1  \ offset: 0xB28 : This register indicates the status of an endpoint with respect to USB- and AHB-related events. It is shown in Figure724. The application must read this register when the OUT endpoints interrupt bit of the OTG_GINTSTS register (OEPINT bit in OTG_GINTSTS) is set. Before the application can read this register, it must first read the OTG_DAINT register to get the exact endpoint number for the OTG_DOEPINTx register. The application must clear the appropriate bit in this register to clear the corresponding bits in the OTG_DAINT and OTG_GINTSTS registers.
$49000b30 constant OTG_OTG_DOEPTSIZ1  \ offset: 0xB30 : The application must modify this register before enabling the endpoint. Once the endpoint is enabled using endpoint enable bit of the OTG_DOEPCTLx registers (EPENA bit in OTG_DOEPCTLx), the core modifies this register. The application can only read this register once the core has cleared the endpoint enable bit.
$49000b34 constant OTG_OTG_DOEPDMA1  \ offset: 0xB34 : OTG device OUT endpoint 1 DMA address register
$49000b40 constant OTG_OTG_DOEPCTL2  \ offset: 0xB40 : The application uses this register to control the behavior of each logical endpoint other than endpoint 0.
$49000b48 constant OTG_OTG_DOEPINT2  \ offset: 0xB48 : This register indicates the status of an endpoint with respect to USB- and AHB-related events. It is shown in Figure724. The application must read this register when the OUT endpoints interrupt bit of the OTG_GINTSTS register (OEPINT bit in OTG_GINTSTS) is set. Before the application can read this register, it must first read the OTG_DAINT register to get the exact endpoint number for the OTG_DOEPINTx register. The application must clear the appropriate bit in this register to clear the corresponding bits in the OTG_DAINT and OTG_GINTSTS registers.
$49000b50 constant OTG_OTG_DOEPTSIZ2  \ offset: 0xB50 : The application must modify this register before enabling the endpoint. Once the endpoint is enabled using endpoint enable bit of the OTG_DOEPCTLx registers (EPENA bit in OTG_DOEPCTLx), the core modifies this register. The application can only read this register once the core has cleared the endpoint enable bit.
$49000b54 constant OTG_OTG_DOEPDMA2  \ offset: 0xB54 : OTG device OUT endpoint 2 DMA address register
$49000b60 constant OTG_OTG_DOEPCTL3  \ offset: 0xB60 : The application uses this register to control the behavior of each logical endpoint other than endpoint 0.
$49000b68 constant OTG_OTG_DOEPINT3  \ offset: 0xB68 : This register indicates the status of an endpoint with respect to USB- and AHB-related events. It is shown in Figure724. The application must read this register when the OUT endpoints interrupt bit of the OTG_GINTSTS register (OEPINT bit in OTG_GINTSTS) is set. Before the application can read this register, it must first read the OTG_DAINT register to get the exact endpoint number for the OTG_DOEPINTx register. The application must clear the appropriate bit in this register to clear the corresponding bits in the OTG_DAINT and OTG_GINTSTS registers.
$49000b70 constant OTG_OTG_DOEPTSIZ3  \ offset: 0xB70 : The application must modify this register before enabling the endpoint. Once the endpoint is enabled using endpoint enable bit of the OTG_DOEPCTLx registers (EPENA bit in OTG_DOEPCTLx), the core modifies this register. The application can only read this register once the core has cleared the endpoint enable bit.
$49000b74 constant OTG_OTG_DOEPDMA3  \ offset: 0xB74 : OTG device OUT endpoint 3 DMA address register
$49000b80 constant OTG_OTG_DOEPCTL4  \ offset: 0xB80 : The application uses this register to control the behavior of each logical endpoint other than endpoint 0.
$49000b88 constant OTG_OTG_DOEPINT4  \ offset: 0xB88 : This register indicates the status of an endpoint with respect to USB- and AHB-related events. It is shown in Figure724. The application must read this register when the OUT endpoints interrupt bit of the OTG_GINTSTS register (OEPINT bit in OTG_GINTSTS) is set. Before the application can read this register, it must first read the OTG_DAINT register to get the exact endpoint number for the OTG_DOEPINTx register. The application must clear the appropriate bit in this register to clear the corresponding bits in the OTG_DAINT and OTG_GINTSTS registers.
$49000b90 constant OTG_OTG_DOEPTSIZ4  \ offset: 0xB90 : The application must modify this register before enabling the endpoint. Once the endpoint is enabled using endpoint enable bit of the OTG_DOEPCTLx registers (EPENA bit in OTG_DOEPCTLx), the core modifies this register. The application can only read this register once the core has cleared the endpoint enable bit.
$49000b94 constant OTG_OTG_DOEPDMA4  \ offset: 0xB94 : OTG device OUT endpoint 4 DMA address register
$49000ba0 constant OTG_OTG_DOEPCTL5  \ offset: 0xBA0 : The application uses this register to control the behavior of each logical endpoint other than endpoint 0.
$49000ba8 constant OTG_OTG_DOEPINT5  \ offset: 0xBA8 : This register indicates the status of an endpoint with respect to USB- and AHB-related events. It is shown in Figure724. The application must read this register when the OUT endpoints interrupt bit of the OTG_GINTSTS register (OEPINT bit in OTG_GINTSTS) is set. Before the application can read this register, it must first read the OTG_DAINT register to get the exact endpoint number for the OTG_DOEPINTx register. The application must clear the appropriate bit in this register to clear the corresponding bits in the OTG_DAINT and OTG_GINTSTS registers.
$49000bb0 constant OTG_OTG_DOEPTSIZ5  \ offset: 0xBB0 : The application must modify this register before enabling the endpoint. Once the endpoint is enabled using endpoint enable bit of the OTG_DOEPCTLx registers (EPENA bit in OTG_DOEPCTLx), the core modifies this register. The application can only read this register once the core has cleared the endpoint enable bit.
$49000bb4 constant OTG_OTG_DOEPDMA5  \ offset: 0xBB4 : OTG device OUT endpoint 5 DMA address register
$49000bc0 constant OTG_OTG_DOEPCTL6  \ offset: 0xBC0 : The application uses this register to control the behavior of each logical endpoint other than endpoint 0.
$49000bc8 constant OTG_OTG_DOEPINT6  \ offset: 0xBC8 : This register indicates the status of an endpoint with respect to USB- and AHB-related events. It is shown in Figure724. The application must read this register when the OUT endpoints interrupt bit of the OTG_GINTSTS register (OEPINT bit in OTG_GINTSTS) is set. Before the application can read this register, it must first read the OTG_DAINT register to get the exact endpoint number for the OTG_DOEPINTx register. The application must clear the appropriate bit in this register to clear the corresponding bits in the OTG_DAINT and OTG_GINTSTS registers.
$49000bd0 constant OTG_OTG_DOEPTSIZ6  \ offset: 0xBD0 : The application must modify this register before enabling the endpoint. Once the endpoint is enabled using endpoint enable bit of the OTG_DOEPCTLx registers (EPENA bit in OTG_DOEPCTLx), the core modifies this register. The application can only read this register once the core has cleared the endpoint enable bit.
$49000bd4 constant OTG_OTG_DOEPDMA6  \ offset: 0xBD4 : OTG device OUT endpoint 6 DMA address register
$49000be0 constant OTG_OTG_DOEPCTL7  \ offset: 0xBE0 : The application uses this register to control the behavior of each logical endpoint other than endpoint 0.
$49000be8 constant OTG_OTG_DOEPINT7  \ offset: 0xBE8 : This register indicates the status of an endpoint with respect to USB- and AHB-related events. It is shown in Figure724. The application must read this register when the OUT endpoints interrupt bit of the OTG_GINTSTS register (OEPINT bit in OTG_GINTSTS) is set. Before the application can read this register, it must first read the OTG_DAINT register to get the exact endpoint number for the OTG_DOEPINTx register. The application must clear the appropriate bit in this register to clear the corresponding bits in the OTG_DAINT and OTG_GINTSTS registers.
$49000bf0 constant OTG_OTG_DOEPTSIZ7  \ offset: 0xBF0 : The application must modify this register before enabling the endpoint. Once the endpoint is enabled using endpoint enable bit of the OTG_DOEPCTLx registers (EPENA bit in OTG_DOEPCTLx), the core modifies this register. The application can only read this register once the core has cleared the endpoint enable bit.
$49000bf4 constant OTG_OTG_DOEPDMA7  \ offset: 0xBF4 : OTG device OUT endpoint 7 DMA address register
$49000c00 constant OTG_OTG_DOEPCTL8  \ offset: 0xC00 : The application uses this register to control the behavior of each logical endpoint other than endpoint 0.
$49000c08 constant OTG_OTG_DOEPINT8  \ offset: 0xC08 : This register indicates the status of an endpoint with respect to USB- and AHB-related events. It is shown in Figure724. The application must read this register when the OUT endpoints interrupt bit of the OTG_GINTSTS register (OEPINT bit in OTG_GINTSTS) is set. Before the application can read this register, it must first read the OTG_DAINT register to get the exact endpoint number for the OTG_DOEPINTx register. The application must clear the appropriate bit in this register to clear the corresponding bits in the OTG_DAINT and OTG_GINTSTS registers.
$49000c10 constant OTG_OTG_DOEPTSIZ8  \ offset: 0xC10 : The application must modify this register before enabling the endpoint. Once the endpoint is enabled using endpoint enable bit of the OTG_DOEPCTLx registers (EPENA bit in OTG_DOEPCTLx), the core modifies this register. The application can only read this register once the core has cleared the endpoint enable bit.
$49000c14 constant OTG_OTG_DOEPDMA8  \ offset: 0xC14 : OTG device OUT endpoint 8 DMA address register
$49000e00 constant OTG_OTG_PCGCCTL  \ offset: 0xE00 : This register is available in host and device modes.

