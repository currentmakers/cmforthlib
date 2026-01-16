\
\ @file sec_otg_fs.fs
\ @brief OTG_FS
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief The GOTGCTL register controls the behavior and reflects the status of the OTG function of the core.
\ Address offset: 0x00
\ Reset value: 0x00010000
\

$00000001 constant SEC_OTG_FS_GOTGCTL_SRQSCS                        \ SRQSCS
$00000002 constant SEC_OTG_FS_GOTGCTL_SRQ                           \ SRQ
$00000004 constant SEC_OTG_FS_GOTGCTL_VBVALOEN                      \ VBVALOEN
$00000008 constant SEC_OTG_FS_GOTGCTL_VBVALOVAL                     \ VBVALOVAL
$00000010 constant SEC_OTG_FS_GOTGCTL_AVALOEN                       \ AVALOEN
$00000020 constant SEC_OTG_FS_GOTGCTL_AVALOVAL                      \ AVALOVAL
$00000040 constant SEC_OTG_FS_GOTGCTL_BVALOEN                       \ BVALOEN
$00000080 constant SEC_OTG_FS_GOTGCTL_BVALOVAL                      \ BVALOVAL
$00000100 constant SEC_OTG_FS_GOTGCTL_HNGSCS                        \ HNGSCS
$00000200 constant SEC_OTG_FS_GOTGCTL_HNPRQ                         \ HNPRQ
$00000400 constant SEC_OTG_FS_GOTGCTL_HSHNPEN                       \ HSHNPEN
$00000800 constant SEC_OTG_FS_GOTGCTL_DHNPEN                        \ DHNPEN
$00001000 constant SEC_OTG_FS_GOTGCTL_EHEN                          \ EHEN
$00010000 constant SEC_OTG_FS_GOTGCTL_CIDSTS                        \ CIDSTS
$00020000 constant SEC_OTG_FS_GOTGCTL_DBCT                          \ DBCT
$00040000 constant SEC_OTG_FS_GOTGCTL_ASVLD                         \ ASVLD
$00080000 constant SEC_OTG_FS_GOTGCTL_BSVLD                         \ BSVLD
$00100000 constant SEC_OTG_FS_GOTGCTL_OTGVER                        \ OTGVER
$00200000 constant SEC_OTG_FS_GOTGCTL_CURMOD                        \ CURMOD


\
\ @brief The application reads this register whenever there is an OTG interrupt and clears the bits in this register to clear the OTG interrupt.
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$00000004 constant SEC_OTG_FS_GOTGINT_SEDET                         \ SEDET
$00000100 constant SEC_OTG_FS_GOTGINT_SRSSCHG                       \ SRSSCHG
$00000200 constant SEC_OTG_FS_GOTGINT_HNSSCHG                       \ HNSSCHG
$00020000 constant SEC_OTG_FS_GOTGINT_HNGDET                        \ HNGDET
$00040000 constant SEC_OTG_FS_GOTGINT_ADTOCHG                       \ ADTOCHG
$00080000 constant SEC_OTG_FS_GOTGINT_DBCDNE                        \ DBCDNE


\
\ @brief This register can be used to configure the core after power-on or a change in mode. This register mainly contains AHB system-related configuration parameters. Do not change this register after the initial programming. The application must program this register before starting any transactions on either the AHB or the USB.
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$00000001 constant SEC_OTG_FS_GAHBCFG_GINTMSK                       \ GINTMSK
$00000080 constant SEC_OTG_FS_GAHBCFG_TXFELVL                       \ TXFELVL
$00000100 constant SEC_OTG_FS_GAHBCFG_PTXFELVL                      \ PTXFELVL


\
\ @brief This register can be used to configure the core after power-on or a changing to host mode or device mode. It contains USB and USB-PHY related configuration parameters. The application must program this register before starting any transactions on either the AHB or the USB. Do not make changes to this register after the initial programming.
\ Address offset: 0x0C
\ Reset value: 0x00001440
\

$00000007 constant SEC_OTG_FS_GUSBCFG_TOCAL                         \ TOCAL
$00000040 constant SEC_OTG_FS_GUSBCFG_PHYSEL                        \ PHYSEL
$00000100 constant SEC_OTG_FS_GUSBCFG_SRPCAP                        \ SRPCAP
$00000200 constant SEC_OTG_FS_GUSBCFG_HNPCAP                        \ HNPCAP
$00003c00 constant SEC_OTG_FS_GUSBCFG_TRDT                          \ TRDT
$20000000 constant SEC_OTG_FS_GUSBCFG_FHMOD                         \ FHMOD
$40000000 constant SEC_OTG_FS_GUSBCFG_FDMOD                         \ FDMOD


\
\ @brief The application uses this register to reset various hardware features inside the core.
\ Address offset: 0x10
\ Reset value: 0x80000000
\

$00000001 constant SEC_OTG_FS_GRSTCTL_CSRST                         \ CSRST
$00000002 constant SEC_OTG_FS_GRSTCTL_PSRST                         \ PSRST
$00000004 constant SEC_OTG_FS_GRSTCTL_FSRST                         \ FSRST
$00000010 constant SEC_OTG_FS_GRSTCTL_RXFFLSH                       \ RXFFLSH
$00000020 constant SEC_OTG_FS_GRSTCTL_TXFFLSH                       \ TXFFLSH
$000007c0 constant SEC_OTG_FS_GRSTCTL_TXFNUM                        \ TXFNUM
$80000000 constant SEC_OTG_FS_GRSTCTL_AHBIDL                        \ AHBIDL


\
\ @brief This register interrupts the application for system-level events in the current mode (device mode or host mode). Some of the bits in this register are valid only in host mode, while others are valid in device mode only. This register also indicates the current mode. To clear the interrupt status bits of the rc_w1 type, the application must write 1 into the bit. The FIFO status interrupts are read-only; once software reads from or writes to the FIFO while servicing these interrupts, FIFO interrupt conditions are cleared automatically. The application must clear the GINTSTS register at initialization before unmasking the interrupt bit to avoid any interrupts generated prior to initialization.
\ Address offset: 0x14
\ Reset value: 0x04000020
\

$00000001 constant SEC_OTG_FS_GINTSTS_CMOD                          \ CMOD
$00000002 constant SEC_OTG_FS_GINTSTS_MMIS                          \ MMIS
$00000004 constant SEC_OTG_FS_GINTSTS_OTGINT                        \ OTGINT
$00000008 constant SEC_OTG_FS_GINTSTS_SOF                           \ SOF
$00000010 constant SEC_OTG_FS_GINTSTS_RXFLVL                        \ RXFLVL
$00000020 constant SEC_OTG_FS_GINTSTS_NPTXFE                        \ NPTXFE
$00000040 constant SEC_OTG_FS_GINTSTS_GINAKEFF                      \ GINAKEFF
$00000080 constant SEC_OTG_FS_GINTSTS_GONAKEFF                      \ GONAKEFF
$00000400 constant SEC_OTG_FS_GINTSTS_ESUSP                         \ ESUSP
$00000800 constant SEC_OTG_FS_GINTSTS_USBSUSP                       \ USBSUSP
$00001000 constant SEC_OTG_FS_GINTSTS_USBRST                        \ USBRST
$00002000 constant SEC_OTG_FS_GINTSTS_ENUMDNE                       \ ENUMDNE
$00004000 constant SEC_OTG_FS_GINTSTS_ISOODRP                       \ ISOODRP
$00008000 constant SEC_OTG_FS_GINTSTS_EOPF                          \ EOPF
$00040000 constant SEC_OTG_FS_GINTSTS_IEPINT                        \ IEPINT
$00080000 constant SEC_OTG_FS_GINTSTS_OEPINT                        \ OEPINT
$00100000 constant SEC_OTG_FS_GINTSTS_IISOIXFR                      \ IISOIXFR
$00200000 constant SEC_OTG_FS_GINTSTS_IPXFR                         \ IPXFR
$00800000 constant SEC_OTG_FS_GINTSTS_RSTDET                        \ RSTDET
$01000000 constant SEC_OTG_FS_GINTSTS_HPRTINT                       \ HPRTINT
$02000000 constant SEC_OTG_FS_GINTSTS_HCINT                         \ HCINT
$04000000 constant SEC_OTG_FS_GINTSTS_PTXFE                         \ PTXFE
$08000000 constant SEC_OTG_FS_GINTSTS_LPMINT                        \ LPMINT
$10000000 constant SEC_OTG_FS_GINTSTS_CIDSCHG                       \ CIDSCHG
$20000000 constant SEC_OTG_FS_GINTSTS_DISCINT                       \ DISCINT
$40000000 constant SEC_OTG_FS_GINTSTS_SRQINT                        \ SRQINT
$80000000 constant SEC_OTG_FS_GINTSTS_WKUPINT                       \ WKUPINT


\
\ @brief This register works with the core interrupt register to interrupt the application. When an interrupt bit is masked, the interrupt associated with that bit is not generated. However, the core interrupt (GINTSTS) register bit corresponding to that interrupt is still set.
\ Address offset: 0x18
\ Reset value: 0x00000000
\

$00000002 constant SEC_OTG_FS_GINTMSK_MMISM                         \ MMISM
$00000004 constant SEC_OTG_FS_GINTMSK_OTGINT                        \ OTGINT
$00000008 constant SEC_OTG_FS_GINTMSK_SOFM                          \ SOFM
$00000010 constant SEC_OTG_FS_GINTMSK_RXFLVLM                       \ RXFLVLM
$00000020 constant SEC_OTG_FS_GINTMSK_NPTXFEM                       \ NPTXFEM
$00000040 constant SEC_OTG_FS_GINTMSK_GINAKEFFM                     \ GINAKEFFM
$00000080 constant SEC_OTG_FS_GINTMSK_GONAKEFFM                     \ GONAKEFFM
$00000400 constant SEC_OTG_FS_GINTMSK_ESUSPM                        \ ESUSPM
$00000800 constant SEC_OTG_FS_GINTMSK_USBSUSPM                      \ USBSUSPM
$00001000 constant SEC_OTG_FS_GINTMSK_USBRST                        \ USBRST
$00002000 constant SEC_OTG_FS_GINTMSK_ENUMDNEM                      \ ENUMDNEM
$00004000 constant SEC_OTG_FS_GINTMSK_ISOODRPM                      \ ISOODRPM
$00008000 constant SEC_OTG_FS_GINTMSK_EOPFM                         \ EOPFM
$00040000 constant SEC_OTG_FS_GINTMSK_IEPINT                        \ IEPINT
$00080000 constant SEC_OTG_FS_GINTMSK_OEPINT                        \ OEPINT
$00100000 constant SEC_OTG_FS_GINTMSK_IISOIXFRM                     \ IISOIXFRM
$00200000 constant SEC_OTG_FS_GINTMSK_IPXFRM                        \ IPXFRM
$00800000 constant SEC_OTG_FS_GINTMSK_RSTDETM                       \ RSTDETM
$01000000 constant SEC_OTG_FS_GINTMSK_PRTIM                         \ PRTIM
$02000000 constant SEC_OTG_FS_GINTMSK_HCIM                          \ HCIM
$04000000 constant SEC_OTG_FS_GINTMSK_PTXFEM                        \ PTXFEM
$08000000 constant SEC_OTG_FS_GINTMSK_LPMINTM                       \ LPMINTM
$10000000 constant SEC_OTG_FS_GINTMSK_CIDSCHGM                      \ CIDSCHGM
$20000000 constant SEC_OTG_FS_GINTMSK_DISCINT                       \ DISCINT
$40000000 constant SEC_OTG_FS_GINTMSK_SRQIM                         \ SRQIM
$80000000 constant SEC_OTG_FS_GINTMSK_WUIM                          \ WUIM


\
\ @brief This description is for register GRXSTSR in Device mode. A read to the receive status debug read register returns the contents of the top of the receive FIFO. The core ignores the receive status read when the receive FIFO is empty and returns a value of 0x00000000.
\ Address offset: 0x1C
\ Reset value: 0x00000000
\

$0000000f constant SEC_OTG_FS_GRXSTSR_DEVICE_EPNUM                  \ EPNUM
$00007ff0 constant SEC_OTG_FS_GRXSTSR_DEVICE_BCNT                   \ BCNT
$00018000 constant SEC_OTG_FS_GRXSTSR_DEVICE_DPID                   \ DPID
$001e0000 constant SEC_OTG_FS_GRXSTSR_DEVICE_PKTSTS                 \ PKTSTS
$01e00000 constant SEC_OTG_FS_GRXSTSR_DEVICE_FRMNUM                 \ FRMNUM
$08000000 constant SEC_OTG_FS_GRXSTSR_DEVICE_STSPHST                \ STSPHST


\
\ @brief This description is for register GRXSTSR in Host mode
\ Address offset: 0x1C
\ Reset value: 0x00000000
\

$0000000f constant SEC_OTG_FS_GRXSTSR_HOST_CHNUM                    \ CHNUM
$00007ff0 constant SEC_OTG_FS_GRXSTSR_HOST_BCNT                     \ BCNT
$00018000 constant SEC_OTG_FS_GRXSTSR_HOST_DPID                     \ DPID
$001e0000 constant SEC_OTG_FS_GRXSTSR_HOST_PKTSTS                   \ PKTSTS


\
\ @brief This description is for register GRXSTSP in Device mode. Similarly to GRXSTSR (receive status debug read register) where a read returns the contents of the top of the receive FIFO, a read to GRXSTSP (receive status read and pop register) additionally pops the top data entry out of the Rx FIFO. The core ignores the receive status pop/read when the receive FIFO is empty and returns a value of 0x00000000. The application must only pop the receive status FIFO when the receive FIFO non-empty bit of the core interrupt register (RXFLVL bit in GINTSTS) is asserted.
\ Address offset: 0x20
\ Reset value: 0x00000000
\

$0000000f constant SEC_OTG_FS_GRXSTSP_DEVICE_EPNUM                  \ EPNUM
$00007ff0 constant SEC_OTG_FS_GRXSTSP_DEVICE_BCNT                   \ BCNT
$00018000 constant SEC_OTG_FS_GRXSTSP_DEVICE_DPID                   \ DPID
$001e0000 constant SEC_OTG_FS_GRXSTSP_DEVICE_PKTSTS                 \ PKTSTS
$01e00000 constant SEC_OTG_FS_GRXSTSP_DEVICE_FRMNUM                 \ FRMNUM
$08000000 constant SEC_OTG_FS_GRXSTSP_DEVICE_STSPHST                \ STSPHST


\
\ @brief This description is for register GRXSTSP in HOST mode
\ Address offset: 0x20
\ Reset value: 0x00000000
\

$0000000f constant SEC_OTG_FS_GRXSTSP_HOST_CHNUM                    \ CHNUM
$00007ff0 constant SEC_OTG_FS_GRXSTSP_HOST_BCNT                     \ BCNT
$00018000 constant SEC_OTG_FS_GRXSTSP_HOST_DPID                     \ DPID
$001e0000 constant SEC_OTG_FS_GRXSTSP_HOST_PKTSTS                   \ PKTSTS


\
\ @brief The application can program the RAM size that must be allocated to the Rx FIFO.
\ Address offset: 0x24
\ Reset value: 0x00000200
\

$0000ffff constant SEC_OTG_FS_GRXFSIZ_RXFD                          \ RXFD


\
\ @brief Host mode
\ Address offset: 0x28
\ Reset value: 0x02000200
\

$0000ffff constant SEC_OTG_FS_HNPTXFSIZ_NPTXFSA                     \ NPTXFSA
$ffff0000 constant SEC_OTG_FS_HNPTXFSIZ_NPTXFD                      \ NPTXFD


\
\ @brief In device mode, this register is not valid. This read-only register contains the free space information for the non-periodic Tx FIFO and the non-periodic transmit request queue.
\ Address offset: 0x2C
\ Reset value: 0x00080200
\

$0000ffff constant SEC_OTG_FS_HNPTXSTS_NPTXFSAV                     \ NPTXFSAV
$00ff0000 constant SEC_OTG_FS_HNPTXSTS_NPTQXSAV                     \ NPTQXSAV
$7f000000 constant SEC_OTG_FS_HNPTXSTS_NPTXQTOP                     \ NPTXQTOP


\
\ @brief OTG general core configuration register
\ Address offset: 0x38
\ Reset value: 0x00000000
\

$00000001 constant SEC_OTG_FS_GCCFG_DCDET                           \ DCDET
$00000002 constant SEC_OTG_FS_GCCFG_PDET                            \ PDET
$00000004 constant SEC_OTG_FS_GCCFG_SDET                            \ SDET
$00000008 constant SEC_OTG_FS_GCCFG_PS2DET                          \ PS2DET
$00010000 constant SEC_OTG_FS_GCCFG_PWRDWN                          \ PWRDWN
$00020000 constant SEC_OTG_FS_GCCFG_BCDEN                           \ BCDEN
$00040000 constant SEC_OTG_FS_GCCFG_DCDEN                           \ DCDEN
$00080000 constant SEC_OTG_FS_GCCFG_PDEN                            \ PDEN
$00100000 constant SEC_OTG_FS_GCCFG_SDEN                            \ SDEN
$00200000 constant SEC_OTG_FS_GCCFG_VBDEN                           \ VBDEN


\
\ @brief This is a register containing the Product ID as reset value.
\ Address offset: 0x3C
\ Reset value: 0x00003000
\

$00000000 constant SEC_OTG_FS_CID_PRODUCT_ID                        \ PRODUCT_ID


\
\ @brief OTG core LPM configuration register
\ Address offset: 0x54
\ Reset value: 0x00000000
\

$00000001 constant SEC_OTG_FS_GLPMCFG_LPMEN                         \ LPMEN
$00000002 constant SEC_OTG_FS_GLPMCFG_LPMACK                        \ LPMACK
$0000003c constant SEC_OTG_FS_GLPMCFG_BESL                          \ BESL
$00000040 constant SEC_OTG_FS_GLPMCFG_REMWAKE                       \ REMWAKE
$00000080 constant SEC_OTG_FS_GLPMCFG_L1SSEN                        \ L1SSEN
$00000f00 constant SEC_OTG_FS_GLPMCFG_BESLTHRS                      \ BESLTHRS
$00001000 constant SEC_OTG_FS_GLPMCFG_L1DSEN                        \ L1DSEN
$00006000 constant SEC_OTG_FS_GLPMCFG_LPMRSP                        \ LPMRSP
$00008000 constant SEC_OTG_FS_GLPMCFG_SLPSTS                        \ SLPSTS
$00010000 constant SEC_OTG_FS_GLPMCFG_L1RSMOK                       \ L1RSMOK
$001e0000 constant SEC_OTG_FS_GLPMCFG_LPMCHIDX                      \ LPMCHIDX
$00e00000 constant SEC_OTG_FS_GLPMCFG_LPMRCNT                       \ LPMRCNT
$01000000 constant SEC_OTG_FS_GLPMCFG_SNDLPM                        \ SNDLPM
$0e000000 constant SEC_OTG_FS_GLPMCFG_LPMRCNTSTS                    \ LPMRCNTSTS
$10000000 constant SEC_OTG_FS_GLPMCFG_ENBESL                        \ ENBESL


\
\ @brief OTG host periodic transmit FIFO size register
\ Address offset: 0x100
\ Reset value: 0x02000400
\

$0000ffff constant SEC_OTG_FS_HPTXFSIZ_PTXSA                        \ PTXSA
$ffff0000 constant SEC_OTG_FS_HPTXFSIZ_PTXFSIZ                      \ PTXFSIZ


\
\ @brief OTG device IN endpoint transmit FIFO 1 size register
\ Address offset: 0x104
\ Reset value: 0x02000400
\

$0000ffff constant SEC_OTG_FS_DIEPTXF1_INEPTXSA                     \ INEPTXSA
$ffff0000 constant SEC_OTG_FS_DIEPTXF1_INEPTXFD                     \ INEPTXFD


\
\ @brief OTG device IN endpoint transmit FIFO 2 size register
\ Address offset: 0x108
\ Reset value: 0x02000600
\

$0000ffff constant SEC_OTG_FS_DIEPTXF2_INEPTXSA                     \ INEPTXSA
$ffff0000 constant SEC_OTG_FS_DIEPTXF2_INEPTXFD                     \ INEPTXFD


\
\ @brief OTG device IN endpoint transmit FIFO 3 size register
\ Address offset: 0x10C
\ Reset value: 0x02000800
\

$0000ffff constant SEC_OTG_FS_DIEPTXF3_INEPTXSA                     \ INEPTXSA
$ffff0000 constant SEC_OTG_FS_DIEPTXF3_INEPTXFD                     \ INEPTXFD


\
\ @brief OTG device IN endpoint transmit FIFO 4 size register
\ Address offset: 0x110
\ Reset value: 0x02000A00
\

$0000ffff constant SEC_OTG_FS_DIEPTXF4_INEPTXSA                     \ INEPTXSA
$ffff0000 constant SEC_OTG_FS_DIEPTXF4_INEPTXFD                     \ INEPTXFD


\
\ @brief OTG device IN endpoint transmit FIFO 5 size register
\ Address offset: 0x114
\ Reset value: 0x02000C00
\

$0000ffff constant SEC_OTG_FS_DIEPTXF5_INEPTXSA                     \ INEPTXSA
$ffff0000 constant SEC_OTG_FS_DIEPTXF5_INEPTXFD                     \ INEPTXFD


\
\ @brief This register configures the core after power-on. Do not make changes to this register after initializing the host.
\ Address offset: 0x400
\ Reset value: 0x00000000
\

$00000003 constant SEC_OTG_FS_HCFG_FSLSPCS                          \ FSLSPCS
$00000004 constant SEC_OTG_FS_HCFG_FSLSS                            \ FSLSS


\
\ @brief This register stores the frame interval information for the current speed to which the OTG controller has enumerated.
\ Address offset: 0x404
\ Reset value: 0x0000EA60
\

$0000ffff constant SEC_OTG_FS_HFIR_FRIVL                            \ FRIVL
$00010000 constant SEC_OTG_FS_HFIR_RLDCTRL                          \ RLDCTRL


\
\ @brief This register indicates the current frame number. It also indicates the time remaining (in terms of the number of PHY clocks) in the current frame.
\ Address offset: 0x408
\ Reset value: 0x00003FFF
\

$0000ffff constant SEC_OTG_FS_HFNUM_FRNUM                           \ FRNUM
$ffff0000 constant SEC_OTG_FS_HFNUM_FTREM                           \ FTREM


\
\ @brief This read-only register contains the free space information for the periodic Tx FIFO and the periodic transmit request queue.
\ Address offset: 0x410
\ Reset value: 0x00080100
\

$0000ffff constant SEC_OTG_FS_HPTXSTS_PTXFSAVL                      \ PTXFSAVL
$00ff0000 constant SEC_OTG_FS_HPTXSTS_PTXQSAV                       \ PTXQSAV
$ff000000 constant SEC_OTG_FS_HPTXSTS_PTXQTOP                       \ PTXQTOP


\
\ @brief When a significant event occurs on a channel, the host all channels interrupt register interrupts the application using the host channels interrupt bit of the core interrupt register (HCINT bit in GINTSTS). This is shown in Figure724. There is one interrupt bit per channel, up to a maximum of 16 bits. Bits in this register are set and cleared when the application sets and clears bits in the corresponding host channel-x interrupt register.
\ Address offset: 0x414
\ Reset value: 0x00000000
\

$0000ffff constant SEC_OTG_FS_HAINT_HAINT                           \ HAINT


\
\ @brief The host all channel interrupt mask register works with the host all channel interrupt register to interrupt the application when an event occurs on a channel. There is one interrupt mask bit per channel, up to a maximum of 16 bits.
\ Address offset: 0x418
\ Reset value: 0x00000000
\

$0000ffff constant SEC_OTG_FS_HAINTMSK_HAINTM                       \ HAINTM


\
\ @brief This register is available only in host mode. Currently, the OTG host supports only one port. A single register holds USB port-related information such as USB reset, enable, suspend, resume, connect status, and test mode for each port. It is shown in Figure724. The rc_w1 bits in this register can trigger an interrupt to the application through the host port interrupt bit of the core interrupt register (HPRTINT bit in GINTSTS). On a port interrupt, the application must read this register and clear the bit that caused the interrupt. For the rc_w1 bits, the application must write a 1 to the bit to clear the interrupt.
\ Address offset: 0x440
\ Reset value: 0x00000000
\

$00000001 constant SEC_OTG_FS_HPRT_PCSTS                            \ PCSTS
$00000002 constant SEC_OTG_FS_HPRT_PCDET                            \ PCDET
$00000004 constant SEC_OTG_FS_HPRT_PENA                             \ PENA
$00000008 constant SEC_OTG_FS_HPRT_PENCHNG                          \ PENCHNG
$00000010 constant SEC_OTG_FS_HPRT_POCA                             \ POCA
$00000020 constant SEC_OTG_FS_HPRT_POCCHNG                          \ POCCHNG
$00000040 constant SEC_OTG_FS_HPRT_PRES                             \ PRES
$00000080 constant SEC_OTG_FS_HPRT_PSUSP                            \ PSUSP
$00000100 constant SEC_OTG_FS_HPRT_PRST                             \ PRST
$00000c00 constant SEC_OTG_FS_HPRT_PLSTS                            \ PLSTS
$00001000 constant SEC_OTG_FS_HPRT_PPWR                             \ PPWR
$0001e000 constant SEC_OTG_FS_HPRT_PTCTL                            \ PTCTL
$00060000 constant SEC_OTG_FS_HPRT_PSPD                             \ PSPD


\
\ @brief OTG host channel 0 characteristics register
\ Address offset: 0x500
\ Reset value: 0x00000000
\

$000007ff constant SEC_OTG_FS_HCCHAR0_MPSIZ                         \ MPSIZ
$00007800 constant SEC_OTG_FS_HCCHAR0_EPNUM                         \ EPNUM
$00008000 constant SEC_OTG_FS_HCCHAR0_EPDIR                         \ EPDIR
$00020000 constant SEC_OTG_FS_HCCHAR0_LSDEV                         \ LSDEV
$000c0000 constant SEC_OTG_FS_HCCHAR0_EPTYP                         \ EPTYP
$00300000 constant SEC_OTG_FS_HCCHAR0_MCNT                          \ MCNT
$1fc00000 constant SEC_OTG_FS_HCCHAR0_DAD                           \ DAD
$20000000 constant SEC_OTG_FS_HCCHAR0_ODDFRM                        \ ODDFRM
$40000000 constant SEC_OTG_FS_HCCHAR0_CHDIS                         \ CHDIS
$80000000 constant SEC_OTG_FS_HCCHAR0_CHENA                         \ CHENA


\
\ @brief This register indicates the status of a channel with respect to USB- and AHB-related events. It is shown in Figure724. The application must read this register when the host channels interrupt bit in the core interrupt register (HCINT bit in GINTSTS) is set. Before the application can read this register, it must first read the host all channels interrupt (HAINT) register to get the exact channel number for the host channel-x interrupt register. The application must clear the appropriate bit in this register to clear the corresponding bits in the HAINT and GINTSTS registers.
\ Address offset: 0x508
\ Reset value: 0x00000000
\

$00000001 constant SEC_OTG_FS_HCINT0_XFRC                           \ XFRC
$00000002 constant SEC_OTG_FS_HCINT0_CHH                            \ CHH
$00000008 constant SEC_OTG_FS_HCINT0_STALL                          \ STALL
$00000010 constant SEC_OTG_FS_HCINT0_NAK                            \ NAK
$00000020 constant SEC_OTG_FS_HCINT0_ACK                            \ ACK
$00000080 constant SEC_OTG_FS_HCINT0_TXERR                          \ TXERR
$00000100 constant SEC_OTG_FS_HCINT0_BBERR                          \ BBERR
$00000200 constant SEC_OTG_FS_HCINT0_FRMOR                          \ FRMOR
$00000400 constant SEC_OTG_FS_HCINT0_DTERR                          \ DTERR


\
\ @brief This register reflects the mask for each channel status described in the previous section.
\ Address offset: 0x50C
\ Reset value: 0x00000000
\

$00000001 constant SEC_OTG_FS_HCINTMSK0_XFRCM                       \ XFRCM
$00000002 constant SEC_OTG_FS_HCINTMSK0_CHHM                        \ CHHM
$00000008 constant SEC_OTG_FS_HCINTMSK0_STALLM                      \ STALLM
$00000010 constant SEC_OTG_FS_HCINTMSK0_NAKM                        \ NAKM
$00000020 constant SEC_OTG_FS_HCINTMSK0_ACKM                        \ ACKM
$00000080 constant SEC_OTG_FS_HCINTMSK0_TXERRM                      \ TXERRM
$00000100 constant SEC_OTG_FS_HCINTMSK0_BBERRM                      \ BBERRM
$00000200 constant SEC_OTG_FS_HCINTMSK0_FRMORM                      \ FRMORM
$00000400 constant SEC_OTG_FS_HCINTMSK0_DTERRM                      \ DTERRM


\
\ @brief OTG host channel 0 transfer size register
\ Address offset: 0x510
\ Reset value: 0x00000000
\

$0007ffff constant SEC_OTG_FS_HCTSIZ0_XFRSIZ                        \ XFRSIZ
$1ff80000 constant SEC_OTG_FS_HCTSIZ0_PKTCNT                        \ PKTCNT
$60000000 constant SEC_OTG_FS_HCTSIZ0_DPID                          \ DPID
$80000000 constant SEC_OTG_FS_HCTSIZ0_DOPNG                         \ DOPNG


\
\ @brief OTG host channel 1 characteristics register
\ Address offset: 0x520
\ Reset value: 0x00000000
\

$000007ff constant SEC_OTG_FS_HCCHAR1_MPSIZ                         \ MPSIZ
$00007800 constant SEC_OTG_FS_HCCHAR1_EPNUM                         \ EPNUM
$00008000 constant SEC_OTG_FS_HCCHAR1_EPDIR                         \ EPDIR
$00020000 constant SEC_OTG_FS_HCCHAR1_LSDEV                         \ LSDEV
$000c0000 constant SEC_OTG_FS_HCCHAR1_EPTYP                         \ EPTYP
$00300000 constant SEC_OTG_FS_HCCHAR1_MCNT                          \ MCNT
$1fc00000 constant SEC_OTG_FS_HCCHAR1_DAD                           \ DAD
$20000000 constant SEC_OTG_FS_HCCHAR1_ODDFRM                        \ ODDFRM
$40000000 constant SEC_OTG_FS_HCCHAR1_CHDIS                         \ CHDIS
$80000000 constant SEC_OTG_FS_HCCHAR1_CHENA                         \ CHENA


\
\ @brief This register indicates the status of a channel with respect to USB- and AHB-related events. It is shown in Figure724. The application must read this register when the host channels interrupt bit in the core interrupt register (HCINT bit in GINTSTS) is set. Before the application can read this register, it must first read the host all channels interrupt (HAINT) register to get the exact channel number for the host channel-x interrupt register. The application must clear the appropriate bit in this register to clear the corresponding bits in the HAINT and GINTSTS registers.
\ Address offset: 0x528
\ Reset value: 0x00000000
\

$00000001 constant SEC_OTG_FS_HCINT1_XFRC                           \ XFRC
$00000002 constant SEC_OTG_FS_HCINT1_CHH                            \ CHH
$00000008 constant SEC_OTG_FS_HCINT1_STALL                          \ STALL
$00000010 constant SEC_OTG_FS_HCINT1_NAK                            \ NAK
$00000020 constant SEC_OTG_FS_HCINT1_ACK                            \ ACK
$00000080 constant SEC_OTG_FS_HCINT1_TXERR                          \ TXERR
$00000100 constant SEC_OTG_FS_HCINT1_BBERR                          \ BBERR
$00000200 constant SEC_OTG_FS_HCINT1_FRMOR                          \ FRMOR
$00000400 constant SEC_OTG_FS_HCINT1_DTERR                          \ DTERR


\
\ @brief This register reflects the mask for each channel status described in the previous section.
\ Address offset: 0x52C
\ Reset value: 0x00000000
\

$00000001 constant SEC_OTG_FS_HCINTMSK1_XFRCM                       \ XFRCM
$00000002 constant SEC_OTG_FS_HCINTMSK1_CHHM                        \ CHHM
$00000008 constant SEC_OTG_FS_HCINTMSK1_STALLM                      \ STALLM
$00000010 constant SEC_OTG_FS_HCINTMSK1_NAKM                        \ NAKM
$00000020 constant SEC_OTG_FS_HCINTMSK1_ACKM                        \ ACKM
$00000080 constant SEC_OTG_FS_HCINTMSK1_TXERRM                      \ TXERRM
$00000100 constant SEC_OTG_FS_HCINTMSK1_BBERRM                      \ BBERRM
$00000200 constant SEC_OTG_FS_HCINTMSK1_FRMORM                      \ FRMORM
$00000400 constant SEC_OTG_FS_HCINTMSK1_DTERRM                      \ DTERRM


\
\ @brief OTG host channel 1 transfer size register
\ Address offset: 0x530
\ Reset value: 0x00000000
\

$0007ffff constant SEC_OTG_FS_HCTSIZ1_XFRSIZ                        \ XFRSIZ
$1ff80000 constant SEC_OTG_FS_HCTSIZ1_PKTCNT                        \ PKTCNT
$60000000 constant SEC_OTG_FS_HCTSIZ1_DPID                          \ DPID
$80000000 constant SEC_OTG_FS_HCTSIZ1_DOPNG                         \ DOPNG


\
\ @brief OTG host channel 2 characteristics register
\ Address offset: 0x540
\ Reset value: 0x00000000
\

$000007ff constant SEC_OTG_FS_HCCHAR2_MPSIZ                         \ MPSIZ
$00007800 constant SEC_OTG_FS_HCCHAR2_EPNUM                         \ EPNUM
$00008000 constant SEC_OTG_FS_HCCHAR2_EPDIR                         \ EPDIR
$00020000 constant SEC_OTG_FS_HCCHAR2_LSDEV                         \ LSDEV
$000c0000 constant SEC_OTG_FS_HCCHAR2_EPTYP                         \ EPTYP
$00300000 constant SEC_OTG_FS_HCCHAR2_MCNT                          \ MCNT
$1fc00000 constant SEC_OTG_FS_HCCHAR2_DAD                           \ DAD
$20000000 constant SEC_OTG_FS_HCCHAR2_ODDFRM                        \ ODDFRM
$40000000 constant SEC_OTG_FS_HCCHAR2_CHDIS                         \ CHDIS
$80000000 constant SEC_OTG_FS_HCCHAR2_CHENA                         \ CHENA


\
\ @brief This register indicates the status of a channel with respect to USB- and AHB-related events. It is shown in Figure724. The application must read this register when the host channels interrupt bit in the core interrupt register (HCINT bit in GINTSTS) is set. Before the application can read this register, it must first read the host all channels interrupt (HAINT) register to get the exact channel number for the host channel-x interrupt register. The application must clear the appropriate bit in this register to clear the corresponding bits in the HAINT and GINTSTS registers.
\ Address offset: 0x548
\ Reset value: 0x00000000
\

$00000001 constant SEC_OTG_FS_HCINT2_XFRC                           \ XFRC
$00000002 constant SEC_OTG_FS_HCINT2_CHH                            \ CHH
$00000008 constant SEC_OTG_FS_HCINT2_STALL                          \ STALL
$00000010 constant SEC_OTG_FS_HCINT2_NAK                            \ NAK
$00000020 constant SEC_OTG_FS_HCINT2_ACK                            \ ACK
$00000080 constant SEC_OTG_FS_HCINT2_TXERR                          \ TXERR
$00000100 constant SEC_OTG_FS_HCINT2_BBERR                          \ BBERR
$00000200 constant SEC_OTG_FS_HCINT2_FRMOR                          \ FRMOR
$00000400 constant SEC_OTG_FS_HCINT2_DTERR                          \ DTERR


\
\ @brief This register reflects the mask for each channel status described in the previous section.
\ Address offset: 0x54C
\ Reset value: 0x00000000
\

$00000001 constant SEC_OTG_FS_HCINTMSK2_XFRCM                       \ XFRCM
$00000002 constant SEC_OTG_FS_HCINTMSK2_CHHM                        \ CHHM
$00000008 constant SEC_OTG_FS_HCINTMSK2_STALLM                      \ STALLM
$00000010 constant SEC_OTG_FS_HCINTMSK2_NAKM                        \ NAKM
$00000020 constant SEC_OTG_FS_HCINTMSK2_ACKM                        \ ACKM
$00000080 constant SEC_OTG_FS_HCINTMSK2_TXERRM                      \ TXERRM
$00000100 constant SEC_OTG_FS_HCINTMSK2_BBERRM                      \ BBERRM
$00000200 constant SEC_OTG_FS_HCINTMSK2_FRMORM                      \ FRMORM
$00000400 constant SEC_OTG_FS_HCINTMSK2_DTERRM                      \ DTERRM


\
\ @brief OTG host channel 2 transfer size register
\ Address offset: 0x550
\ Reset value: 0x00000000
\

$0007ffff constant SEC_OTG_FS_HCTSIZ2_XFRSIZ                        \ XFRSIZ
$1ff80000 constant SEC_OTG_FS_HCTSIZ2_PKTCNT                        \ PKTCNT
$60000000 constant SEC_OTG_FS_HCTSIZ2_DPID                          \ DPID
$80000000 constant SEC_OTG_FS_HCTSIZ2_DOPNG                         \ DOPNG


\
\ @brief OTG host channel 3 characteristics register
\ Address offset: 0x560
\ Reset value: 0x00000000
\

$000007ff constant SEC_OTG_FS_HCCHAR3_MPSIZ                         \ MPSIZ
$00007800 constant SEC_OTG_FS_HCCHAR3_EPNUM                         \ EPNUM
$00008000 constant SEC_OTG_FS_HCCHAR3_EPDIR                         \ EPDIR
$00020000 constant SEC_OTG_FS_HCCHAR3_LSDEV                         \ LSDEV
$000c0000 constant SEC_OTG_FS_HCCHAR3_EPTYP                         \ EPTYP
$00300000 constant SEC_OTG_FS_HCCHAR3_MCNT                          \ MCNT
$1fc00000 constant SEC_OTG_FS_HCCHAR3_DAD                           \ DAD
$20000000 constant SEC_OTG_FS_HCCHAR3_ODDFRM                        \ ODDFRM
$40000000 constant SEC_OTG_FS_HCCHAR3_CHDIS                         \ CHDIS
$80000000 constant SEC_OTG_FS_HCCHAR3_CHENA                         \ CHENA


\
\ @brief This register indicates the status of a channel with respect to USB- and AHB-related events. It is shown in Figure724. The application must read this register when the host channels interrupt bit in the core interrupt register (HCINT bit in GINTSTS) is set. Before the application can read this register, it must first read the host all channels interrupt (HAINT) register to get the exact channel number for the host channel-x interrupt register. The application must clear the appropriate bit in this register to clear the corresponding bits in the HAINT and GINTSTS registers.
\ Address offset: 0x568
\ Reset value: 0x00000000
\

$00000001 constant SEC_OTG_FS_HCINT3_XFRC                           \ XFRC
$00000002 constant SEC_OTG_FS_HCINT3_CHH                            \ CHH
$00000008 constant SEC_OTG_FS_HCINT3_STALL                          \ STALL
$00000010 constant SEC_OTG_FS_HCINT3_NAK                            \ NAK
$00000020 constant SEC_OTG_FS_HCINT3_ACK                            \ ACK
$00000080 constant SEC_OTG_FS_HCINT3_TXERR                          \ TXERR
$00000100 constant SEC_OTG_FS_HCINT3_BBERR                          \ BBERR
$00000200 constant SEC_OTG_FS_HCINT3_FRMOR                          \ FRMOR
$00000400 constant SEC_OTG_FS_HCINT3_DTERR                          \ DTERR


\
\ @brief This register reflects the mask for each channel status described in the previous section.
\ Address offset: 0x56C
\ Reset value: 0x00000000
\

$00000001 constant SEC_OTG_FS_HCINTMSK3_XFRCM                       \ XFRCM
$00000002 constant SEC_OTG_FS_HCINTMSK3_CHHM                        \ CHHM
$00000008 constant SEC_OTG_FS_HCINTMSK3_STALLM                      \ STALLM
$00000010 constant SEC_OTG_FS_HCINTMSK3_NAKM                        \ NAKM
$00000020 constant SEC_OTG_FS_HCINTMSK3_ACKM                        \ ACKM
$00000080 constant SEC_OTG_FS_HCINTMSK3_TXERRM                      \ TXERRM
$00000100 constant SEC_OTG_FS_HCINTMSK3_BBERRM                      \ BBERRM
$00000200 constant SEC_OTG_FS_HCINTMSK3_FRMORM                      \ FRMORM
$00000400 constant SEC_OTG_FS_HCINTMSK3_DTERRM                      \ DTERRM


\
\ @brief OTG host channel 3 transfer size register
\ Address offset: 0x570
\ Reset value: 0x00000000
\

$0007ffff constant SEC_OTG_FS_HCTSIZ3_XFRSIZ                        \ XFRSIZ
$1ff80000 constant SEC_OTG_FS_HCTSIZ3_PKTCNT                        \ PKTCNT
$60000000 constant SEC_OTG_FS_HCTSIZ3_DPID                          \ DPID
$80000000 constant SEC_OTG_FS_HCTSIZ3_DOPNG                         \ DOPNG


\
\ @brief OTG host channel 4 characteristics register
\ Address offset: 0x580
\ Reset value: 0x00000000
\

$000007ff constant SEC_OTG_FS_HCCHAR4_MPSIZ                         \ MPSIZ
$00007800 constant SEC_OTG_FS_HCCHAR4_EPNUM                         \ EPNUM
$00008000 constant SEC_OTG_FS_HCCHAR4_EPDIR                         \ EPDIR
$00020000 constant SEC_OTG_FS_HCCHAR4_LSDEV                         \ LSDEV
$000c0000 constant SEC_OTG_FS_HCCHAR4_EPTYP                         \ EPTYP
$00300000 constant SEC_OTG_FS_HCCHAR4_MCNT                          \ MCNT
$1fc00000 constant SEC_OTG_FS_HCCHAR4_DAD                           \ DAD
$20000000 constant SEC_OTG_FS_HCCHAR4_ODDFRM                        \ ODDFRM
$40000000 constant SEC_OTG_FS_HCCHAR4_CHDIS                         \ CHDIS
$80000000 constant SEC_OTG_FS_HCCHAR4_CHENA                         \ CHENA


\
\ @brief This register indicates the status of a channel with respect to USB- and AHB-related events. It is shown in Figure724. The application must read this register when the host channels interrupt bit in the core interrupt register (HCINT bit in GINTSTS) is set. Before the application can read this register, it must first read the host all channels interrupt (HAINT) register to get the exact channel number for the host channel-x interrupt register. The application must clear the appropriate bit in this register to clear the corresponding bits in the HAINT and GINTSTS registers.
\ Address offset: 0x588
\ Reset value: 0x00000000
\

$00000001 constant SEC_OTG_FS_HCINT4_XFRC                           \ XFRC
$00000002 constant SEC_OTG_FS_HCINT4_CHH                            \ CHH
$00000008 constant SEC_OTG_FS_HCINT4_STALL                          \ STALL
$00000010 constant SEC_OTG_FS_HCINT4_NAK                            \ NAK
$00000020 constant SEC_OTG_FS_HCINT4_ACK                            \ ACK
$00000080 constant SEC_OTG_FS_HCINT4_TXERR                          \ TXERR
$00000100 constant SEC_OTG_FS_HCINT4_BBERR                          \ BBERR
$00000200 constant SEC_OTG_FS_HCINT4_FRMOR                          \ FRMOR
$00000400 constant SEC_OTG_FS_HCINT4_DTERR                          \ DTERR


\
\ @brief This register reflects the mask for each channel status described in the previous section.
\ Address offset: 0x58C
\ Reset value: 0x00000000
\

$00000001 constant SEC_OTG_FS_HCINTMSK4_XFRCM                       \ XFRCM
$00000002 constant SEC_OTG_FS_HCINTMSK4_CHHM                        \ CHHM
$00000008 constant SEC_OTG_FS_HCINTMSK4_STALLM                      \ STALLM
$00000010 constant SEC_OTG_FS_HCINTMSK4_NAKM                        \ NAKM
$00000020 constant SEC_OTG_FS_HCINTMSK4_ACKM                        \ ACKM
$00000080 constant SEC_OTG_FS_HCINTMSK4_TXERRM                      \ TXERRM
$00000100 constant SEC_OTG_FS_HCINTMSK4_BBERRM                      \ BBERRM
$00000200 constant SEC_OTG_FS_HCINTMSK4_FRMORM                      \ FRMORM
$00000400 constant SEC_OTG_FS_HCINTMSK4_DTERRM                      \ DTERRM


\
\ @brief OTG host channel 4 transfer size register
\ Address offset: 0x590
\ Reset value: 0x00000000
\

$0007ffff constant SEC_OTG_FS_HCTSIZ4_XFRSIZ                        \ XFRSIZ
$1ff80000 constant SEC_OTG_FS_HCTSIZ4_PKTCNT                        \ PKTCNT
$60000000 constant SEC_OTG_FS_HCTSIZ4_DPID                          \ DPID
$80000000 constant SEC_OTG_FS_HCTSIZ4_DOPNG                         \ DOPNG


\
\ @brief OTG host channel 5 characteristics register
\ Address offset: 0x5A0
\ Reset value: 0x00000000
\

$000007ff constant SEC_OTG_FS_HCCHAR5_MPSIZ                         \ MPSIZ
$00007800 constant SEC_OTG_FS_HCCHAR5_EPNUM                         \ EPNUM
$00008000 constant SEC_OTG_FS_HCCHAR5_EPDIR                         \ EPDIR
$00020000 constant SEC_OTG_FS_HCCHAR5_LSDEV                         \ LSDEV
$000c0000 constant SEC_OTG_FS_HCCHAR5_EPTYP                         \ EPTYP
$00300000 constant SEC_OTG_FS_HCCHAR5_MCNT                          \ MCNT
$1fc00000 constant SEC_OTG_FS_HCCHAR5_DAD                           \ DAD
$20000000 constant SEC_OTG_FS_HCCHAR5_ODDFRM                        \ ODDFRM
$40000000 constant SEC_OTG_FS_HCCHAR5_CHDIS                         \ CHDIS
$80000000 constant SEC_OTG_FS_HCCHAR5_CHENA                         \ CHENA


\
\ @brief This register indicates the status of a channel with respect to USB- and AHB-related events. It is shown in Figure724. The application must read this register when the host channels interrupt bit in the core interrupt register (HCINT bit in GINTSTS) is set. Before the application can read this register, it must first read the host all channels interrupt (HAINT) register to get the exact channel number for the host channel-x interrupt register. The application must clear the appropriate bit in this register to clear the corresponding bits in the HAINT and GINTSTS registers.
\ Address offset: 0x5A8
\ Reset value: 0x00000000
\

$00000001 constant SEC_OTG_FS_HCINT5_XFRC                           \ XFRC
$00000002 constant SEC_OTG_FS_HCINT5_CHH                            \ CHH
$00000008 constant SEC_OTG_FS_HCINT5_STALL                          \ STALL
$00000010 constant SEC_OTG_FS_HCINT5_NAK                            \ NAK
$00000020 constant SEC_OTG_FS_HCINT5_ACK                            \ ACK
$00000080 constant SEC_OTG_FS_HCINT5_TXERR                          \ TXERR
$00000100 constant SEC_OTG_FS_HCINT5_BBERR                          \ BBERR
$00000200 constant SEC_OTG_FS_HCINT5_FRMOR                          \ FRMOR
$00000400 constant SEC_OTG_FS_HCINT5_DTERR                          \ DTERR


\
\ @brief This register reflects the mask for each channel status described in the previous section.
\ Address offset: 0x5AC
\ Reset value: 0x00000000
\

$00000001 constant SEC_OTG_FS_HCINTMSK5_XFRCM                       \ XFRCM
$00000002 constant SEC_OTG_FS_HCINTMSK5_CHHM                        \ CHHM
$00000008 constant SEC_OTG_FS_HCINTMSK5_STALLM                      \ STALLM
$00000010 constant SEC_OTG_FS_HCINTMSK5_NAKM                        \ NAKM
$00000020 constant SEC_OTG_FS_HCINTMSK5_ACKM                        \ ACKM
$00000080 constant SEC_OTG_FS_HCINTMSK5_TXERRM                      \ TXERRM
$00000100 constant SEC_OTG_FS_HCINTMSK5_BBERRM                      \ BBERRM
$00000200 constant SEC_OTG_FS_HCINTMSK5_FRMORM                      \ FRMORM
$00000400 constant SEC_OTG_FS_HCINTMSK5_DTERRM                      \ DTERRM


\
\ @brief OTG host channel 5 transfer size register
\ Address offset: 0x5B0
\ Reset value: 0x00000000
\

$0007ffff constant SEC_OTG_FS_HCTSIZ5_XFRSIZ                        \ XFRSIZ
$1ff80000 constant SEC_OTG_FS_HCTSIZ5_PKTCNT                        \ PKTCNT
$60000000 constant SEC_OTG_FS_HCTSIZ5_DPID                          \ DPID
$80000000 constant SEC_OTG_FS_HCTSIZ5_DOPNG                         \ DOPNG


\
\ @brief OTG host channel 6 characteristics register
\ Address offset: 0x5C0
\ Reset value: 0x00000000
\

$000007ff constant SEC_OTG_FS_HCCHAR6_MPSIZ                         \ MPSIZ
$00007800 constant SEC_OTG_FS_HCCHAR6_EPNUM                         \ EPNUM
$00008000 constant SEC_OTG_FS_HCCHAR6_EPDIR                         \ EPDIR
$00020000 constant SEC_OTG_FS_HCCHAR6_LSDEV                         \ LSDEV
$000c0000 constant SEC_OTG_FS_HCCHAR6_EPTYP                         \ EPTYP
$00300000 constant SEC_OTG_FS_HCCHAR6_MCNT                          \ MCNT
$1fc00000 constant SEC_OTG_FS_HCCHAR6_DAD                           \ DAD
$20000000 constant SEC_OTG_FS_HCCHAR6_ODDFRM                        \ ODDFRM
$40000000 constant SEC_OTG_FS_HCCHAR6_CHDIS                         \ CHDIS
$80000000 constant SEC_OTG_FS_HCCHAR6_CHENA                         \ CHENA


\
\ @brief This register indicates the status of a channel with respect to USB- and AHB-related events. It is shown in Figure724. The application must read this register when the host channels interrupt bit in the core interrupt register (HCINT bit in GINTSTS) is set. Before the application can read this register, it must first read the host all channels interrupt (HAINT) register to get the exact channel number for the host channel-x interrupt register. The application must clear the appropriate bit in this register to clear the corresponding bits in the HAINT and GINTSTS registers.
\ Address offset: 0x5C8
\ Reset value: 0x00000000
\

$00000001 constant SEC_OTG_FS_HCINT6_XFRC                           \ XFRC
$00000002 constant SEC_OTG_FS_HCINT6_CHH                            \ CHH
$00000008 constant SEC_OTG_FS_HCINT6_STALL                          \ STALL
$00000010 constant SEC_OTG_FS_HCINT6_NAK                            \ NAK
$00000020 constant SEC_OTG_FS_HCINT6_ACK                            \ ACK
$00000080 constant SEC_OTG_FS_HCINT6_TXERR                          \ TXERR
$00000100 constant SEC_OTG_FS_HCINT6_BBERR                          \ BBERR
$00000200 constant SEC_OTG_FS_HCINT6_FRMOR                          \ FRMOR
$00000400 constant SEC_OTG_FS_HCINT6_DTERR                          \ DTERR


\
\ @brief This register reflects the mask for each channel status described in the previous section.
\ Address offset: 0x5CC
\ Reset value: 0x00000000
\

$00000001 constant SEC_OTG_FS_HCINTMSK6_XFRCM                       \ XFRCM
$00000002 constant SEC_OTG_FS_HCINTMSK6_CHHM                        \ CHHM
$00000008 constant SEC_OTG_FS_HCINTMSK6_STALLM                      \ STALLM
$00000010 constant SEC_OTG_FS_HCINTMSK6_NAKM                        \ NAKM
$00000020 constant SEC_OTG_FS_HCINTMSK6_ACKM                        \ ACKM
$00000080 constant SEC_OTG_FS_HCINTMSK6_TXERRM                      \ TXERRM
$00000100 constant SEC_OTG_FS_HCINTMSK6_BBERRM                      \ BBERRM
$00000200 constant SEC_OTG_FS_HCINTMSK6_FRMORM                      \ FRMORM
$00000400 constant SEC_OTG_FS_HCINTMSK6_DTERRM                      \ DTERRM


\
\ @brief OTG host channel 6 transfer size register
\ Address offset: 0x5D0
\ Reset value: 0x00000000
\

$0007ffff constant SEC_OTG_FS_HCTSIZ6_XFRSIZ                        \ XFRSIZ
$1ff80000 constant SEC_OTG_FS_HCTSIZ6_PKTCNT                        \ PKTCNT
$60000000 constant SEC_OTG_FS_HCTSIZ6_DPID                          \ DPID
$80000000 constant SEC_OTG_FS_HCTSIZ6_DOPNG                         \ DOPNG


\
\ @brief OTG host channel 7 characteristics register
\ Address offset: 0x5E0
\ Reset value: 0x00000000
\

$000007ff constant SEC_OTG_FS_HCCHAR7_MPSIZ                         \ MPSIZ
$00007800 constant SEC_OTG_FS_HCCHAR7_EPNUM                         \ EPNUM
$00008000 constant SEC_OTG_FS_HCCHAR7_EPDIR                         \ EPDIR
$00020000 constant SEC_OTG_FS_HCCHAR7_LSDEV                         \ LSDEV
$000c0000 constant SEC_OTG_FS_HCCHAR7_EPTYP                         \ EPTYP
$00300000 constant SEC_OTG_FS_HCCHAR7_MCNT                          \ MCNT
$1fc00000 constant SEC_OTG_FS_HCCHAR7_DAD                           \ DAD
$20000000 constant SEC_OTG_FS_HCCHAR7_ODDFRM                        \ ODDFRM
$40000000 constant SEC_OTG_FS_HCCHAR7_CHDIS                         \ CHDIS
$80000000 constant SEC_OTG_FS_HCCHAR7_CHENA                         \ CHENA


\
\ @brief This register indicates the status of a channel with respect to USB- and AHB-related events. It is shown in Figure724. The application must read this register when the host channels interrupt bit in the core interrupt register (HCINT bit in GINTSTS) is set. Before the application can read this register, it must first read the host all channels interrupt (HAINT) register to get the exact channel number for the host channel-x interrupt register. The application must clear the appropriate bit in this register to clear the corresponding bits in the HAINT and GINTSTS registers.
\ Address offset: 0x5E8
\ Reset value: 0x00000000
\

$00000001 constant SEC_OTG_FS_HCINT7_XFRC                           \ XFRC
$00000002 constant SEC_OTG_FS_HCINT7_CHH                            \ CHH
$00000008 constant SEC_OTG_FS_HCINT7_STALL                          \ STALL
$00000010 constant SEC_OTG_FS_HCINT7_NAK                            \ NAK
$00000020 constant SEC_OTG_FS_HCINT7_ACK                            \ ACK
$00000080 constant SEC_OTG_FS_HCINT7_TXERR                          \ TXERR
$00000100 constant SEC_OTG_FS_HCINT7_BBERR                          \ BBERR
$00000200 constant SEC_OTG_FS_HCINT7_FRMOR                          \ FRMOR
$00000400 constant SEC_OTG_FS_HCINT7_DTERR                          \ DTERR


\
\ @brief This register reflects the mask for each channel status described in the previous section.
\ Address offset: 0x5EC
\ Reset value: 0x00000000
\

$00000001 constant SEC_OTG_FS_HCINTMSK7_XFRCM                       \ XFRCM
$00000002 constant SEC_OTG_FS_HCINTMSK7_CHHM                        \ CHHM
$00000008 constant SEC_OTG_FS_HCINTMSK7_STALLM                      \ STALLM
$00000010 constant SEC_OTG_FS_HCINTMSK7_NAKM                        \ NAKM
$00000020 constant SEC_OTG_FS_HCINTMSK7_ACKM                        \ ACKM
$00000080 constant SEC_OTG_FS_HCINTMSK7_TXERRM                      \ TXERRM
$00000100 constant SEC_OTG_FS_HCINTMSK7_BBERRM                      \ BBERRM
$00000200 constant SEC_OTG_FS_HCINTMSK7_FRMORM                      \ FRMORM
$00000400 constant SEC_OTG_FS_HCINTMSK7_DTERRM                      \ DTERRM


\
\ @brief OTG host channel 7 transfer size register
\ Address offset: 0x5F0
\ Reset value: 0x00000000
\

$0007ffff constant SEC_OTG_FS_HCTSIZ7_XFRSIZ                        \ XFRSIZ
$1ff80000 constant SEC_OTG_FS_HCTSIZ7_PKTCNT                        \ PKTCNT
$60000000 constant SEC_OTG_FS_HCTSIZ7_DPID                          \ DPID
$80000000 constant SEC_OTG_FS_HCTSIZ7_DOPNG                         \ DOPNG


\
\ @brief OTG host channel 8 characteristics register
\ Address offset: 0x600
\ Reset value: 0x00000000
\

$000007ff constant SEC_OTG_FS_HCCHAR8_MPSIZ                         \ MPSIZ
$00007800 constant SEC_OTG_FS_HCCHAR8_EPNUM                         \ EPNUM
$00008000 constant SEC_OTG_FS_HCCHAR8_EPDIR                         \ EPDIR
$00020000 constant SEC_OTG_FS_HCCHAR8_LSDEV                         \ LSDEV
$000c0000 constant SEC_OTG_FS_HCCHAR8_EPTYP                         \ EPTYP
$00300000 constant SEC_OTG_FS_HCCHAR8_MCNT                          \ MCNT
$1fc00000 constant SEC_OTG_FS_HCCHAR8_DAD                           \ DAD
$20000000 constant SEC_OTG_FS_HCCHAR8_ODDFRM                        \ ODDFRM
$40000000 constant SEC_OTG_FS_HCCHAR8_CHDIS                         \ CHDIS
$80000000 constant SEC_OTG_FS_HCCHAR8_CHENA                         \ CHENA


\
\ @brief This register indicates the status of a channel with respect to USB- and AHB-related events. It is shown in Figure724. The application must read this register when the host channels interrupt bit in the core interrupt register (HCINT bit in GINTSTS) is set. Before the application can read this register, it must first read the host all channels interrupt (HAINT) register to get the exact channel number for the host channel-x interrupt register. The application must clear the appropriate bit in this register to clear the corresponding bits in the HAINT and GINTSTS registers.
\ Address offset: 0x608
\ Reset value: 0x00000000
\

$00000001 constant SEC_OTG_FS_HCINT8_XFRC                           \ XFRC
$00000002 constant SEC_OTG_FS_HCINT8_CHH                            \ CHH
$00000008 constant SEC_OTG_FS_HCINT8_STALL                          \ STALL
$00000010 constant SEC_OTG_FS_HCINT8_NAK                            \ NAK
$00000020 constant SEC_OTG_FS_HCINT8_ACK                            \ ACK
$00000080 constant SEC_OTG_FS_HCINT8_TXERR                          \ TXERR
$00000100 constant SEC_OTG_FS_HCINT8_BBERR                          \ BBERR
$00000200 constant SEC_OTG_FS_HCINT8_FRMOR                          \ FRMOR
$00000400 constant SEC_OTG_FS_HCINT8_DTERR                          \ DTERR


\
\ @brief This register reflects the mask for each channel status described in the previous section.
\ Address offset: 0x60C
\ Reset value: 0x00000000
\

$00000001 constant SEC_OTG_FS_HCINTMSK8_XFRCM                       \ XFRCM
$00000002 constant SEC_OTG_FS_HCINTMSK8_CHHM                        \ CHHM
$00000008 constant SEC_OTG_FS_HCINTMSK8_STALLM                      \ STALLM
$00000010 constant SEC_OTG_FS_HCINTMSK8_NAKM                        \ NAKM
$00000020 constant SEC_OTG_FS_HCINTMSK8_ACKM                        \ ACKM
$00000080 constant SEC_OTG_FS_HCINTMSK8_TXERRM                      \ TXERRM
$00000100 constant SEC_OTG_FS_HCINTMSK8_BBERRM                      \ BBERRM
$00000200 constant SEC_OTG_FS_HCINTMSK8_FRMORM                      \ FRMORM
$00000400 constant SEC_OTG_FS_HCINTMSK8_DTERRM                      \ DTERRM


\
\ @brief OTG host channel 8 transfer size register
\ Address offset: 0x610
\ Reset value: 0x00000000
\

$0007ffff constant SEC_OTG_FS_HCTSIZ8_XFRSIZ                        \ XFRSIZ
$1ff80000 constant SEC_OTG_FS_HCTSIZ8_PKTCNT                        \ PKTCNT
$60000000 constant SEC_OTG_FS_HCTSIZ8_DPID                          \ DPID
$80000000 constant SEC_OTG_FS_HCTSIZ8_DOPNG                         \ DOPNG


\
\ @brief OTG host channel 9 characteristics register
\ Address offset: 0x620
\ Reset value: 0x00000000
\

$000007ff constant SEC_OTG_FS_HCCHAR9_MPSIZ                         \ MPSIZ
$00007800 constant SEC_OTG_FS_HCCHAR9_EPNUM                         \ EPNUM
$00008000 constant SEC_OTG_FS_HCCHAR9_EPDIR                         \ EPDIR
$00020000 constant SEC_OTG_FS_HCCHAR9_LSDEV                         \ LSDEV
$000c0000 constant SEC_OTG_FS_HCCHAR9_EPTYP                         \ EPTYP
$00300000 constant SEC_OTG_FS_HCCHAR9_MCNT                          \ MCNT
$1fc00000 constant SEC_OTG_FS_HCCHAR9_DAD                           \ DAD
$20000000 constant SEC_OTG_FS_HCCHAR9_ODDFRM                        \ ODDFRM
$40000000 constant SEC_OTG_FS_HCCHAR9_CHDIS                         \ CHDIS
$80000000 constant SEC_OTG_FS_HCCHAR9_CHENA                         \ CHENA


\
\ @brief This register indicates the status of a channel with respect to USB- and AHB-related events. It is shown in Figure724. The application must read this register when the host channels interrupt bit in the core interrupt register (HCINT bit in GINTSTS) is set. Before the application can read this register, it must first read the host all channels interrupt (HAINT) register to get the exact channel number for the host channel-x interrupt register. The application must clear the appropriate bit in this register to clear the corresponding bits in the HAINT and GINTSTS registers.
\ Address offset: 0x628
\ Reset value: 0x00000000
\

$00000001 constant SEC_OTG_FS_HCINT9_XFRC                           \ XFRC
$00000002 constant SEC_OTG_FS_HCINT9_CHH                            \ CHH
$00000008 constant SEC_OTG_FS_HCINT9_STALL                          \ STALL
$00000010 constant SEC_OTG_FS_HCINT9_NAK                            \ NAK
$00000020 constant SEC_OTG_FS_HCINT9_ACK                            \ ACK
$00000080 constant SEC_OTG_FS_HCINT9_TXERR                          \ TXERR
$00000100 constant SEC_OTG_FS_HCINT9_BBERR                          \ BBERR
$00000200 constant SEC_OTG_FS_HCINT9_FRMOR                          \ FRMOR
$00000400 constant SEC_OTG_FS_HCINT9_DTERR                          \ DTERR


\
\ @brief This register reflects the mask for each channel status described in the previous section.
\ Address offset: 0x62C
\ Reset value: 0x00000000
\

$00000001 constant SEC_OTG_FS_HCINTMSK9_XFRCM                       \ XFRCM
$00000002 constant SEC_OTG_FS_HCINTMSK9_CHHM                        \ CHHM
$00000008 constant SEC_OTG_FS_HCINTMSK9_STALLM                      \ STALLM
$00000010 constant SEC_OTG_FS_HCINTMSK9_NAKM                        \ NAKM
$00000020 constant SEC_OTG_FS_HCINTMSK9_ACKM                        \ ACKM
$00000080 constant SEC_OTG_FS_HCINTMSK9_TXERRM                      \ TXERRM
$00000100 constant SEC_OTG_FS_HCINTMSK9_BBERRM                      \ BBERRM
$00000200 constant SEC_OTG_FS_HCINTMSK9_FRMORM                      \ FRMORM
$00000400 constant SEC_OTG_FS_HCINTMSK9_DTERRM                      \ DTERRM


\
\ @brief OTG host channel 9 transfer size register
\ Address offset: 0x630
\ Reset value: 0x00000000
\

$0007ffff constant SEC_OTG_FS_HCTSIZ9_XFRSIZ                        \ XFRSIZ
$1ff80000 constant SEC_OTG_FS_HCTSIZ9_PKTCNT                        \ PKTCNT
$60000000 constant SEC_OTG_FS_HCTSIZ9_DPID                          \ DPID
$80000000 constant SEC_OTG_FS_HCTSIZ9_DOPNG                         \ DOPNG


\
\ @brief OTG host channel 10 characteristics register
\ Address offset: 0x640
\ Reset value: 0x00000000
\

$000007ff constant SEC_OTG_FS_HCCHAR10_MPSIZ                        \ MPSIZ
$00007800 constant SEC_OTG_FS_HCCHAR10_EPNUM                        \ EPNUM
$00008000 constant SEC_OTG_FS_HCCHAR10_EPDIR                        \ EPDIR
$00020000 constant SEC_OTG_FS_HCCHAR10_LSDEV                        \ LSDEV
$000c0000 constant SEC_OTG_FS_HCCHAR10_EPTYP                        \ EPTYP
$00300000 constant SEC_OTG_FS_HCCHAR10_MCNT                         \ MCNT
$1fc00000 constant SEC_OTG_FS_HCCHAR10_DAD                          \ DAD
$20000000 constant SEC_OTG_FS_HCCHAR10_ODDFRM                       \ ODDFRM
$40000000 constant SEC_OTG_FS_HCCHAR10_CHDIS                        \ CHDIS
$80000000 constant SEC_OTG_FS_HCCHAR10_CHENA                        \ CHENA


\
\ @brief This register indicates the status of a channel with respect to USB- and AHB-related events. It is shown in Figure724. The application must read this register when the host channels interrupt bit in the core interrupt register (HCINT bit in GINTSTS) is set. Before the application can read this register, it must first read the host all channels interrupt (HAINT) register to get the exact channel number for the host channel-x interrupt register. The application must clear the appropriate bit in this register to clear the corresponding bits in the HAINT and GINTSTS registers.
\ Address offset: 0x648
\ Reset value: 0x00000000
\

$00000001 constant SEC_OTG_FS_HCINT10_XFRC                          \ XFRC
$00000002 constant SEC_OTG_FS_HCINT10_CHH                           \ CHH
$00000008 constant SEC_OTG_FS_HCINT10_STALL                         \ STALL
$00000010 constant SEC_OTG_FS_HCINT10_NAK                           \ NAK
$00000020 constant SEC_OTG_FS_HCINT10_ACK                           \ ACK
$00000080 constant SEC_OTG_FS_HCINT10_TXERR                         \ TXERR
$00000100 constant SEC_OTG_FS_HCINT10_BBERR                         \ BBERR
$00000200 constant SEC_OTG_FS_HCINT10_FRMOR                         \ FRMOR
$00000400 constant SEC_OTG_FS_HCINT10_DTERR                         \ DTERR


\
\ @brief This register reflects the mask for each channel status described in the previous section.
\ Address offset: 0x64C
\ Reset value: 0x00000000
\

$00000001 constant SEC_OTG_FS_HCINTMSK10_XFRCM                      \ XFRCM
$00000002 constant SEC_OTG_FS_HCINTMSK10_CHHM                       \ CHHM
$00000008 constant SEC_OTG_FS_HCINTMSK10_STALLM                     \ STALLM
$00000010 constant SEC_OTG_FS_HCINTMSK10_NAKM                       \ NAKM
$00000020 constant SEC_OTG_FS_HCINTMSK10_ACKM                       \ ACKM
$00000080 constant SEC_OTG_FS_HCINTMSK10_TXERRM                     \ TXERRM
$00000100 constant SEC_OTG_FS_HCINTMSK10_BBERRM                     \ BBERRM
$00000200 constant SEC_OTG_FS_HCINTMSK10_FRMORM                     \ FRMORM
$00000400 constant SEC_OTG_FS_HCINTMSK10_DTERRM                     \ DTERRM


\
\ @brief OTG host channel 10 transfer size register
\ Address offset: 0x650
\ Reset value: 0x00000000
\

$0007ffff constant SEC_OTG_FS_HCTSIZ10_XFRSIZ                       \ XFRSIZ
$1ff80000 constant SEC_OTG_FS_HCTSIZ10_PKTCNT                       \ PKTCNT
$60000000 constant SEC_OTG_FS_HCTSIZ10_DPID                         \ DPID
$80000000 constant SEC_OTG_FS_HCTSIZ10_DOPNG                        \ DOPNG


\
\ @brief OTG host channel 11 characteristics register
\ Address offset: 0x660
\ Reset value: 0x00000000
\

$000007ff constant SEC_OTG_FS_HCCHAR11_MPSIZ                        \ MPSIZ
$00007800 constant SEC_OTG_FS_HCCHAR11_EPNUM                        \ EPNUM
$00008000 constant SEC_OTG_FS_HCCHAR11_EPDIR                        \ EPDIR
$00020000 constant SEC_OTG_FS_HCCHAR11_LSDEV                        \ LSDEV
$000c0000 constant SEC_OTG_FS_HCCHAR11_EPTYP                        \ EPTYP
$00300000 constant SEC_OTG_FS_HCCHAR11_MCNT                         \ MCNT
$1fc00000 constant SEC_OTG_FS_HCCHAR11_DAD                          \ DAD
$20000000 constant SEC_OTG_FS_HCCHAR11_ODDFRM                       \ ODDFRM
$40000000 constant SEC_OTG_FS_HCCHAR11_CHDIS                        \ CHDIS
$80000000 constant SEC_OTG_FS_HCCHAR11_CHENA                        \ CHENA


\
\ @brief This register indicates the status of a channel with respect to USB- and AHB-related events. It is shown in Figure724. The application must read this register when the host channels interrupt bit in the core interrupt register (HCINT bit in GINTSTS) is set. Before the application can read this register, it must first read the host all channels interrupt (HAINT) register to get the exact channel number for the host channel-x interrupt register. The application must clear the appropriate bit in this register to clear the corresponding bits in the HAINT and GINTSTS registers.
\ Address offset: 0x668
\ Reset value: 0x00000000
\

$00000001 constant SEC_OTG_FS_HCINT11_XFRC                          \ XFRC
$00000002 constant SEC_OTG_FS_HCINT11_CHH                           \ CHH
$00000008 constant SEC_OTG_FS_HCINT11_STALL                         \ STALL
$00000010 constant SEC_OTG_FS_HCINT11_NAK                           \ NAK
$00000020 constant SEC_OTG_FS_HCINT11_ACK                           \ ACK
$00000080 constant SEC_OTG_FS_HCINT11_TXERR                         \ TXERR
$00000100 constant SEC_OTG_FS_HCINT11_BBERR                         \ BBERR
$00000200 constant SEC_OTG_FS_HCINT11_FRMOR                         \ FRMOR
$00000400 constant SEC_OTG_FS_HCINT11_DTERR                         \ DTERR


\
\ @brief This register reflects the mask for each channel status described in the previous section.
\ Address offset: 0x66C
\ Reset value: 0x00000000
\

$00000001 constant SEC_OTG_FS_HCINTMSK11_XFRCM                      \ XFRCM
$00000002 constant SEC_OTG_FS_HCINTMSK11_CHHM                       \ CHHM
$00000008 constant SEC_OTG_FS_HCINTMSK11_STALLM                     \ STALLM
$00000010 constant SEC_OTG_FS_HCINTMSK11_NAKM                       \ NAKM
$00000020 constant SEC_OTG_FS_HCINTMSK11_ACKM                       \ ACKM
$00000080 constant SEC_OTG_FS_HCINTMSK11_TXERRM                     \ TXERRM
$00000100 constant SEC_OTG_FS_HCINTMSK11_BBERRM                     \ BBERRM
$00000200 constant SEC_OTG_FS_HCINTMSK11_FRMORM                     \ FRMORM
$00000400 constant SEC_OTG_FS_HCINTMSK11_DTERRM                     \ DTERRM


\
\ @brief OTG host channel 11 transfer size register
\ Address offset: 0x670
\ Reset value: 0x00000000
\

$0007ffff constant SEC_OTG_FS_HCTSIZ11_XFRSIZ                       \ XFRSIZ
$1ff80000 constant SEC_OTG_FS_HCTSIZ11_PKTCNT                       \ PKTCNT
$60000000 constant SEC_OTG_FS_HCTSIZ11_DPID                         \ DPID
$80000000 constant SEC_OTG_FS_HCTSIZ11_DOPNG                        \ DOPNG


\
\ @brief This register configures the core in device mode after power-on or after certain control commands or enumeration. Do not make changes to this register after initial programming.
\ Address offset: 0x800
\ Reset value: 0x02200000
\

$00000003 constant SEC_OTG_FS_DCFG_DSPD                             \ DSPD
$00000004 constant SEC_OTG_FS_DCFG_NZLSOHSK                         \ NZLSOHSK
$000007f0 constant SEC_OTG_FS_DCFG_DAD                              \ DAD
$00001800 constant SEC_OTG_FS_DCFG_PFIVL                            \ PFIVL
$00008000 constant SEC_OTG_FS_DCFG_ERRATIM                          \ ERRATIM


\
\ @brief OTG device control register
\ Address offset: 0x804
\ Reset value: 0x00000002
\

$00000001 constant SEC_OTG_FS_DCTL_RWUSIG                           \ RWUSIG
$00000002 constant SEC_OTG_FS_DCTL_SDIS                             \ SDIS
$00000004 constant SEC_OTG_FS_DCTL_GINSTS                           \ GINSTS
$00000008 constant SEC_OTG_FS_DCTL_GONSTS                           \ GONSTS
$00000070 constant SEC_OTG_FS_DCTL_TCTL                             \ TCTL
$00000080 constant SEC_OTG_FS_DCTL_SGINAK                           \ SGINAK
$00000100 constant SEC_OTG_FS_DCTL_CGINAK                           \ CGINAK
$00000200 constant SEC_OTG_FS_DCTL_SGONAK                           \ SGONAK
$00000400 constant SEC_OTG_FS_DCTL_CGONAK                           \ CGONAK
$00000800 constant SEC_OTG_FS_DCTL_POPRGDNE                         \ POPRGDNE
$00040000 constant SEC_OTG_FS_DCTL_DSBESLRJCT                       \ DSBESLRJCT


\
\ @brief This register indicates the status of the core with respect to USB-related events. It must be read on interrupts from the device all interrupts (DAINT) register.
\ Address offset: 0x808
\ Reset value: 0x00000010
\

$00000001 constant SEC_OTG_FS_DSTS_SUSPSTS                          \ SUSPSTS
$00000006 constant SEC_OTG_FS_DSTS_ENUMSPD                          \ ENUMSPD
$00000008 constant SEC_OTG_FS_DSTS_EERR                             \ EERR
$003fff00 constant SEC_OTG_FS_DSTS_FNSOF                            \ FNSOF
$00c00000 constant SEC_OTG_FS_DSTS_DEVLNSTS                         \ DEVLNSTS


\
\ @brief This register works with each of the DIEPINTx registers for all endpoints to generate an interrupt per IN endpoint. The IN endpoint interrupt for a specific status in the DIEPINTx register can be masked by writing to the corresponding bit in this register. Status bits are masked by default.
\ Address offset: 0x810
\ Reset value: 0x00000000
\

$00000001 constant SEC_OTG_FS_DIEPMSK_XFRCM                         \ XFRCM
$00000002 constant SEC_OTG_FS_DIEPMSK_EPDM                          \ EPDM
$00000008 constant SEC_OTG_FS_DIEPMSK_TOM                           \ TOM
$00000010 constant SEC_OTG_FS_DIEPMSK_ITTXFEMSK                     \ ITTXFEMSK
$00000020 constant SEC_OTG_FS_DIEPMSK_INEPNMM                       \ INEPNMM
$00000040 constant SEC_OTG_FS_DIEPMSK_INEPNEM                       \ INEPNEM
$00002000 constant SEC_OTG_FS_DIEPMSK_NAKM                          \ NAKM


\
\ @brief This register works with each of the DOEPINTx registers for all endpoints to generate an interrupt per OUT endpoint. The OUT endpoint interrupt for a specific status in the DOEPINTx register can be masked by writing into the corresponding bit in this register. Status bits are masked by default.
\ Address offset: 0x814
\ Reset value: 0x00000000
\

$00000001 constant SEC_OTG_FS_DOEPMSK_XFRCM                         \ XFRCM
$00000002 constant SEC_OTG_FS_DOEPMSK_EPDM                          \ EPDM
$00000008 constant SEC_OTG_FS_DOEPMSK_STUPM                         \ STUPM
$00000010 constant SEC_OTG_FS_DOEPMSK_OTEPDM                        \ OTEPDM
$00000020 constant SEC_OTG_FS_DOEPMSK_STSPHSRXM                     \ STSPHSRXM
$00000100 constant SEC_OTG_FS_DOEPMSK_OUTPKTERRM                    \ OUTPKTERRM
$00001000 constant SEC_OTG_FS_DOEPMSK_BERRM                         \ BERRM
$00002000 constant SEC_OTG_FS_DOEPMSK_NAKMSK                        \ NAKMSK


\
\ @brief When a significant event occurs on an endpoint, a DAINT register interrupts the application using the device OUT endpoints interrupt bit or device IN endpoints interrupt bit of the GINTSTS register (OEPINT or IEPINT in GINTSTS, respectively). There is one interrupt bit per endpoint, up to a maximum of 16 bits for OUT endpoints and 16 bits for IN endpoints. For a bidirectional endpoint, the corresponding IN and OUT interrupt bits are used. Bits in this register are set and cleared when the application sets and clears bits in the corresponding device endpoint-x interrupt register (DIEPINTx/DOEPINTx).
\ Address offset: 0x818
\ Reset value: 0x00000000
\

$0000ffff constant SEC_OTG_FS_DAINT_IEPINT                          \ IEPINT
$ffff0000 constant SEC_OTG_FS_DAINT_OEPINT                          \ OEPINT


\
\ @brief The DAINTMSK register works with the device endpoint interrupt register to interrupt the application when an event occurs on a device endpoint. However, the DAINT register bit corresponding to that interrupt is still set.
\ Address offset: 0x81C
\ Reset value: 0x00000000
\

$0000ffff constant SEC_OTG_FS_DAINTMSK_IEPM                         \ IEPM
$ffff0000 constant SEC_OTG_FS_DAINTMSK_OEPM                         \ OEPM


\
\ @brief This register specifies the VBUS discharge time after VBUS pulsing during SRP.
\ Address offset: 0x828
\ Reset value: 0x000017D7
\

$0000ffff constant SEC_OTG_FS_DVBUSDIS_VBUSDT                       \ VBUSDT


\
\ @brief This register specifies the VBUS pulsing time during SRP.
\ Address offset: 0x82C
\ Reset value: 0x000005B8
\

$0000ffff constant SEC_OTG_FS_DVBUSPULSE_DVBUSP                     \ DVBUSP


\
\ @brief This register is used to control the IN endpoint FIFO empty interrupt generation (TXFE_DIEPINTx).
\ Address offset: 0x834
\ Reset value: 0x00000000
\

$0000ffff constant SEC_OTG_FS_DIEPEMPMSK_INEPTXFEM                  \ INEPTXFEM


\
\ @brief The application uses this register to control the behavior of each logical endpoint other than endpoint 0.
\ Address offset: 0x900
\ Reset value: 0x00000000
\

$00000003 constant SEC_OTG_FS_DIEPCTL0_MPSIZ                        \ MPSIZ
$00008000 constant SEC_OTG_FS_DIEPCTL0_USBAEP                       \ USBAEP
$00020000 constant SEC_OTG_FS_DIEPCTL0_NAKSTS                       \ NAKSTS
$000c0000 constant SEC_OTG_FS_DIEPCTL0_EPTYP                        \ EPTYP
$00200000 constant SEC_OTG_FS_DIEPCTL0_STALL                        \ STALL
$03c00000 constant SEC_OTG_FS_DIEPCTL0_TXFNUM                       \ TXFNUM
$04000000 constant SEC_OTG_FS_DIEPCTL0_CNAK                         \ CNAK
$08000000 constant SEC_OTG_FS_DIEPCTL0_SNAK                         \ SNAK
$40000000 constant SEC_OTG_FS_DIEPCTL0_EPDIS                        \ EPDIS
$80000000 constant SEC_OTG_FS_DIEPCTL0_EPENA                        \ EPENA


\
\ @brief This register indicates the status of an endpoint with respect to USB- and AHB-related events. It is shown in Figure724. The application must read this register when the IN endpoints interrupt bit of the core interrupt register (IEPINT in GINTSTS) is set. Before the application can read this register, it must first read the device all endpoints interrupt (DAINT) register to get the exact endpoint number for the device endpoint-x interrupt register. The application must clear the appropriate bit in this register to clear the corresponding bits in the DAINT and GINTSTS registers.
\ Address offset: 0x908
\ Reset value: 0x00000080
\

$00000001 constant SEC_OTG_FS_DIEPINT0_XFRC                         \ XFRC
$00000002 constant SEC_OTG_FS_DIEPINT0_EPDISD                       \ EPDISD
$00000008 constant SEC_OTG_FS_DIEPINT0_TOC                          \ TOC
$00000010 constant SEC_OTG_FS_DIEPINT0_ITTXFE                       \ ITTXFE
$00000020 constant SEC_OTG_FS_DIEPINT0_INEPNM                       \ INEPNM
$00000040 constant SEC_OTG_FS_DIEPINT0_INEPNE                       \ INEPNE
$00000080 constant SEC_OTG_FS_DIEPINT0_TXFE                         \ TXFE
$00000800 constant SEC_OTG_FS_DIEPINT0_PKTDRPSTS                    \ PKTDRPSTS
$00002000 constant SEC_OTG_FS_DIEPINT0_NAK                          \ NAK


\
\ @brief The application must modify this register before enabling endpoint 0.
\ Address offset: 0x910
\ Reset value: 0x00000000
\

$0000007f constant SEC_OTG_FS_DIEPTSIZ0_XFRSIZ                      \ XFRSIZ
$00180000 constant SEC_OTG_FS_DIEPTSIZ0_PKTCNT                      \ PKTCNT


\
\ @brief This read-only register contains the free space information for the device IN endpoint Tx FIFO.
\ Address offset: 0x918
\ Reset value: 0x00000200
\

$0000ffff constant SEC_OTG_FS_DTXFSTS0_INEPTFSAV                    \ INEPTFSAV


\
\ @brief The application uses this register to control the behavior of each logical endpoint other than endpoint 0.
\ Address offset: 0x920
\ Reset value: 0x00000000
\

$000007ff constant SEC_OTG_FS_DIEPCTL1_MPSIZ                        \ MPSIZ
$00008000 constant SEC_OTG_FS_DIEPCTL1_USBAEP                       \ USBAEP
$00010000 constant SEC_OTG_FS_DIEPCTL1_EONUM_DPIP                   \ EONUM_DPIP
$00020000 constant SEC_OTG_FS_DIEPCTL1_NAKSTS                       \ NAKSTS
$000c0000 constant SEC_OTG_FS_DIEPCTL1_EPTYP                        \ EPTYP
$00200000 constant SEC_OTG_FS_DIEPCTL1_STALL                        \ STALL
$03c00000 constant SEC_OTG_FS_DIEPCTL1_TXFNUM                       \ TXFNUM
$04000000 constant SEC_OTG_FS_DIEPCTL1_CNAK                         \ CNAK
$08000000 constant SEC_OTG_FS_DIEPCTL1_SNAK                         \ SNAK
$10000000 constant SEC_OTG_FS_DIEPCTL1_SD0PID_SEVNFRM               \ SD0PID_SEVNFRM
$20000000 constant SEC_OTG_FS_DIEPCTL1_SODDFRM                      \ SODDFRM
$40000000 constant SEC_OTG_FS_DIEPCTL1_EPDIS                        \ EPDIS
$80000000 constant SEC_OTG_FS_DIEPCTL1_EPENA                        \ EPENA


\
\ @brief This register indicates the status of an endpoint with respect to USB- and AHB-related events. It is shown in Figure724. The application must read this register when the IN endpoints interrupt bit of the core interrupt register (IEPINT in GINTSTS) is set. Before the application can read this register, it must first read the device all endpoints interrupt (DAINT) register to get the exact endpoint number for the device endpoint-x interrupt register. The application must clear the appropriate bit in this register to clear the corresponding bits in the DAINT and GINTSTS registers.
\ Address offset: 0x928
\ Reset value: 0x00000080
\

$00000001 constant SEC_OTG_FS_DIEPINT1_XFRC                         \ XFRC
$00000002 constant SEC_OTG_FS_DIEPINT1_EPDISD                       \ EPDISD
$00000008 constant SEC_OTG_FS_DIEPINT1_TOC                          \ TOC
$00000010 constant SEC_OTG_FS_DIEPINT1_ITTXFE                       \ ITTXFE
$00000020 constant SEC_OTG_FS_DIEPINT1_INEPNM                       \ INEPNM
$00000040 constant SEC_OTG_FS_DIEPINT1_INEPNE                       \ INEPNE
$00000080 constant SEC_OTG_FS_DIEPINT1_TXFE                         \ TXFE
$00000800 constant SEC_OTG_FS_DIEPINT1_PKTDRPSTS                    \ PKTDRPSTS
$00002000 constant SEC_OTG_FS_DIEPINT1_NAK                          \ NAK


\
\ @brief The application must modify this register before enabling the endpoint. Once the endpoint is enabled using the endpoint enable bit in the DIEPCTLx registers (EPENA bit in DIEPCTLx), the core modifies this register. The application can only read this register once the core has cleared the endpoint enable bit.
\ Address offset: 0x930
\ Reset value: 0x00000000
\

$0007ffff constant SEC_OTG_FS_DIEPTSIZ1_XFRSIZ                      \ XFRSIZ
$1ff80000 constant SEC_OTG_FS_DIEPTSIZ1_PKTCNT                      \ PKTCNT
$60000000 constant SEC_OTG_FS_DIEPTSIZ1_MCNT                        \ MCNT


\
\ @brief This read-only register contains the free space information for the device IN endpoint Tx FIFO.
\ Address offset: 0x938
\ Reset value: 0x00000200
\

$0000ffff constant SEC_OTG_FS_DTXFSTS1_INEPTFSAV                    \ INEPTFSAV


\
\ @brief The application uses this register to control the behavior of each logical endpoint other than endpoint 0.
\ Address offset: 0x940
\ Reset value: 0x00000000
\

$000007ff constant SEC_OTG_FS_DIEPCTL2_MPSIZ                        \ MPSIZ
$00008000 constant SEC_OTG_FS_DIEPCTL2_USBAEP                       \ USBAEP
$00010000 constant SEC_OTG_FS_DIEPCTL2_EONUM_DPIP                   \ EONUM_DPIP
$00020000 constant SEC_OTG_FS_DIEPCTL2_NAKSTS                       \ NAKSTS
$000c0000 constant SEC_OTG_FS_DIEPCTL2_EPTYP                        \ EPTYP
$00200000 constant SEC_OTG_FS_DIEPCTL2_STALL                        \ STALL
$03c00000 constant SEC_OTG_FS_DIEPCTL2_TXFNUM                       \ TXFNUM
$04000000 constant SEC_OTG_FS_DIEPCTL2_CNAK                         \ CNAK
$08000000 constant SEC_OTG_FS_DIEPCTL2_SNAK                         \ SNAK
$10000000 constant SEC_OTG_FS_DIEPCTL2_SD0PID_SEVNFRM               \ SD0PID_SEVNFRM
$20000000 constant SEC_OTG_FS_DIEPCTL2_SODDFRM                      \ SODDFRM
$40000000 constant SEC_OTG_FS_DIEPCTL2_EPDIS                        \ EPDIS
$80000000 constant SEC_OTG_FS_DIEPCTL2_EPENA                        \ EPENA


\
\ @brief This register indicates the status of an endpoint with respect to USB- and AHB-related events. It is shown in Figure724. The application must read this register when the IN endpoints interrupt bit of the core interrupt register (IEPINT in GINTSTS) is set. Before the application can read this register, it must first read the device all endpoints interrupt (DAINT) register to get the exact endpoint number for the device endpoint-x interrupt register. The application must clear the appropriate bit in this register to clear the corresponding bits in the DAINT and GINTSTS registers.
\ Address offset: 0x948
\ Reset value: 0x00000080
\

$00000001 constant SEC_OTG_FS_DIEPINT2_XFRC                         \ XFRC
$00000002 constant SEC_OTG_FS_DIEPINT2_EPDISD                       \ EPDISD
$00000008 constant SEC_OTG_FS_DIEPINT2_TOC                          \ TOC
$00000010 constant SEC_OTG_FS_DIEPINT2_ITTXFE                       \ ITTXFE
$00000020 constant SEC_OTG_FS_DIEPINT2_INEPNM                       \ INEPNM
$00000040 constant SEC_OTG_FS_DIEPINT2_INEPNE                       \ INEPNE
$00000080 constant SEC_OTG_FS_DIEPINT2_TXFE                         \ TXFE
$00000800 constant SEC_OTG_FS_DIEPINT2_PKTDRPSTS                    \ PKTDRPSTS
$00002000 constant SEC_OTG_FS_DIEPINT2_NAK                          \ NAK


\
\ @brief The application must modify this register before enabling the endpoint. Once the endpoint is enabled using the endpoint enable bit in the DIEPCTLx registers (EPENA bit in DIEPCTLx), the core modifies this register. The application can only read this register once the core has cleared the endpoint enable bit.
\ Address offset: 0x950
\ Reset value: 0x00000000
\

$0007ffff constant SEC_OTG_FS_DIEPTSIZ2_XFRSIZ                      \ XFRSIZ
$1ff80000 constant SEC_OTG_FS_DIEPTSIZ2_PKTCNT                      \ PKTCNT
$60000000 constant SEC_OTG_FS_DIEPTSIZ2_MCNT                        \ MCNT


\
\ @brief This read-only register contains the free space information for the device IN endpoint Tx FIFO.
\ Address offset: 0x958
\ Reset value: 0x00000200
\

$0000ffff constant SEC_OTG_FS_DTXFSTS2_INEPTFSAV                    \ INEPTFSAV


\
\ @brief The application uses this register to control the behavior of each logical endpoint other than endpoint 0.
\ Address offset: 0x960
\ Reset value: 0x00000000
\

$000007ff constant SEC_OTG_FS_DIEPCTL3_MPSIZ                        \ MPSIZ
$00008000 constant SEC_OTG_FS_DIEPCTL3_USBAEP                       \ USBAEP
$00010000 constant SEC_OTG_FS_DIEPCTL3_EONUM_DPIP                   \ EONUM_DPIP
$00020000 constant SEC_OTG_FS_DIEPCTL3_NAKSTS                       \ NAKSTS
$000c0000 constant SEC_OTG_FS_DIEPCTL3_EPTYP                        \ EPTYP
$00200000 constant SEC_OTG_FS_DIEPCTL3_STALL                        \ STALL
$03c00000 constant SEC_OTG_FS_DIEPCTL3_TXFNUM                       \ TXFNUM
$04000000 constant SEC_OTG_FS_DIEPCTL3_CNAK                         \ CNAK
$08000000 constant SEC_OTG_FS_DIEPCTL3_SNAK                         \ SNAK
$10000000 constant SEC_OTG_FS_DIEPCTL3_SD0PID_SEVNFRM               \ SD0PID_SEVNFRM
$20000000 constant SEC_OTG_FS_DIEPCTL3_SODDFRM                      \ SODDFRM
$40000000 constant SEC_OTG_FS_DIEPCTL3_EPDIS                        \ EPDIS
$80000000 constant SEC_OTG_FS_DIEPCTL3_EPENA                        \ EPENA


\
\ @brief This register indicates the status of an endpoint with respect to USB- and AHB-related events. It is shown in Figure724. The application must read this register when the IN endpoints interrupt bit of the core interrupt register (IEPINT in GINTSTS) is set. Before the application can read this register, it must first read the device all endpoints interrupt (DAINT) register to get the exact endpoint number for the device endpoint-x interrupt register. The application must clear the appropriate bit in this register to clear the corresponding bits in the DAINT and GINTSTS registers.
\ Address offset: 0x968
\ Reset value: 0x00000080
\

$00000001 constant SEC_OTG_FS_DIEPINT3_XFRC                         \ XFRC
$00000002 constant SEC_OTG_FS_DIEPINT3_EPDISD                       \ EPDISD
$00000008 constant SEC_OTG_FS_DIEPINT3_TOC                          \ TOC
$00000010 constant SEC_OTG_FS_DIEPINT3_ITTXFE                       \ ITTXFE
$00000020 constant SEC_OTG_FS_DIEPINT3_INEPNM                       \ INEPNM
$00000040 constant SEC_OTG_FS_DIEPINT3_INEPNE                       \ INEPNE
$00000080 constant SEC_OTG_FS_DIEPINT3_TXFE                         \ TXFE
$00000800 constant SEC_OTG_FS_DIEPINT3_PKTDRPSTS                    \ PKTDRPSTS
$00002000 constant SEC_OTG_FS_DIEPINT3_NAK                          \ NAK


\
\ @brief The application must modify this register before enabling the endpoint. Once the endpoint is enabled using the endpoint enable bit in the DIEPCTLx registers (EPENA bit in DIEPCTLx), the core modifies this register. The application can only read this register once the core has cleared the endpoint enable bit.
\ Address offset: 0x970
\ Reset value: 0x00000000
\

$0007ffff constant SEC_OTG_FS_DIEPTSIZ3_XFRSIZ                      \ XFRSIZ
$1ff80000 constant SEC_OTG_FS_DIEPTSIZ3_PKTCNT                      \ PKTCNT
$60000000 constant SEC_OTG_FS_DIEPTSIZ3_MCNT                        \ MCNT


\
\ @brief This read-only register contains the free space information for the device IN endpoint Tx FIFO.
\ Address offset: 0x978
\ Reset value: 0x00000200
\

$0000ffff constant SEC_OTG_FS_DTXFSTS3_INEPTFSAV                    \ INEPTFSAV


\
\ @brief The application uses this register to control the behavior of each logical endpoint other than endpoint 0.
\ Address offset: 0x980
\ Reset value: 0x00000000
\

$000007ff constant SEC_OTG_FS_DIEPCTL4_MPSIZ                        \ MPSIZ
$00008000 constant SEC_OTG_FS_DIEPCTL4_USBAEP                       \ USBAEP
$00010000 constant SEC_OTG_FS_DIEPCTL4_EONUM_DPIP                   \ EONUM_DPIP
$00020000 constant SEC_OTG_FS_DIEPCTL4_NAKSTS                       \ NAKSTS
$000c0000 constant SEC_OTG_FS_DIEPCTL4_EPTYP                        \ EPTYP
$00200000 constant SEC_OTG_FS_DIEPCTL4_STALL                        \ STALL
$03c00000 constant SEC_OTG_FS_DIEPCTL4_TXFNUM                       \ TXFNUM
$04000000 constant SEC_OTG_FS_DIEPCTL4_CNAK                         \ CNAK
$08000000 constant SEC_OTG_FS_DIEPCTL4_SNAK                         \ SNAK
$10000000 constant SEC_OTG_FS_DIEPCTL4_SD0PID_SEVNFRM               \ SD0PID_SEVNFRM
$20000000 constant SEC_OTG_FS_DIEPCTL4_SODDFRM                      \ SODDFRM
$40000000 constant SEC_OTG_FS_DIEPCTL4_EPDIS                        \ EPDIS
$80000000 constant SEC_OTG_FS_DIEPCTL4_EPENA                        \ EPENA


\
\ @brief This register indicates the status of an endpoint with respect to USB- and AHB-related events. It is shown in Figure724. The application must read this register when the IN endpoints interrupt bit of the core interrupt register (IEPINT in GINTSTS) is set. Before the application can read this register, it must first read the device all endpoints interrupt (DAINT) register to get the exact endpoint number for the device endpoint-x interrupt register. The application must clear the appropriate bit in this register to clear the corresponding bits in the DAINT and GINTSTS registers.
\ Address offset: 0x988
\ Reset value: 0x00000080
\

$00000001 constant SEC_OTG_FS_DIEPINT4_XFRC                         \ XFRC
$00000002 constant SEC_OTG_FS_DIEPINT4_EPDISD                       \ EPDISD
$00000008 constant SEC_OTG_FS_DIEPINT4_TOC                          \ TOC
$00000010 constant SEC_OTG_FS_DIEPINT4_ITTXFE                       \ ITTXFE
$00000020 constant SEC_OTG_FS_DIEPINT4_INEPNM                       \ INEPNM
$00000040 constant SEC_OTG_FS_DIEPINT4_INEPNE                       \ INEPNE
$00000080 constant SEC_OTG_FS_DIEPINT4_TXFE                         \ TXFE
$00000800 constant SEC_OTG_FS_DIEPINT4_PKTDRPSTS                    \ PKTDRPSTS
$00002000 constant SEC_OTG_FS_DIEPINT4_NAK                          \ NAK


\
\ @brief The application must modify this register before enabling the endpoint. Once the endpoint is enabled using the endpoint enable bit in the DIEPCTLx registers (EPENA bit in DIEPCTLx), the core modifies this register. The application can only read this register once the core has cleared the endpoint enable bit.
\ Address offset: 0x990
\ Reset value: 0x00000000
\

$0007ffff constant SEC_OTG_FS_DIEPTSIZ4_XFRSIZ                      \ XFRSIZ
$1ff80000 constant SEC_OTG_FS_DIEPTSIZ4_PKTCNT                      \ PKTCNT
$60000000 constant SEC_OTG_FS_DIEPTSIZ4_MCNT                        \ MCNT


\
\ @brief This read-only register contains the free space information for the device IN endpoint Tx FIFO.
\ Address offset: 0x998
\ Reset value: 0x00000200
\

$0000ffff constant SEC_OTG_FS_DTXFSTS4_INEPTFSAV                    \ INEPTFSAV


\
\ @brief The application uses this register to control the behavior of each logical endpoint other than endpoint 0.
\ Address offset: 0x9A0
\ Reset value: 0x00000000
\

$000007ff constant SEC_OTG_FS_DIEPCTL5_MPSIZ                        \ MPSIZ
$00008000 constant SEC_OTG_FS_DIEPCTL5_USBAEP                       \ USBAEP
$00010000 constant SEC_OTG_FS_DIEPCTL5_EONUM_DPIP                   \ EONUM_DPIP
$00020000 constant SEC_OTG_FS_DIEPCTL5_NAKSTS                       \ NAKSTS
$000c0000 constant SEC_OTG_FS_DIEPCTL5_EPTYP                        \ EPTYP
$00200000 constant SEC_OTG_FS_DIEPCTL5_STALL                        \ STALL
$03c00000 constant SEC_OTG_FS_DIEPCTL5_TXFNUM                       \ TXFNUM
$04000000 constant SEC_OTG_FS_DIEPCTL5_CNAK                         \ CNAK
$08000000 constant SEC_OTG_FS_DIEPCTL5_SNAK                         \ SNAK
$10000000 constant SEC_OTG_FS_DIEPCTL5_SD0PID_SEVNFRM               \ SD0PID_SEVNFRM
$20000000 constant SEC_OTG_FS_DIEPCTL5_SODDFRM                      \ SODDFRM
$40000000 constant SEC_OTG_FS_DIEPCTL5_EPDIS                        \ EPDIS
$80000000 constant SEC_OTG_FS_DIEPCTL5_EPENA                        \ EPENA


\
\ @brief This register indicates the status of an endpoint with respect to USB- and AHB-related events. It is shown in Figure724. The application must read this register when the IN endpoints interrupt bit of the core interrupt register (IEPINT in GINTSTS) is set. Before the application can read this register, it must first read the device all endpoints interrupt (DAINT) register to get the exact endpoint number for the device endpoint-x interrupt register. The application must clear the appropriate bit in this register to clear the corresponding bits in the DAINT and GINTSTS registers.
\ Address offset: 0x9A8
\ Reset value: 0x00000080
\

$00000001 constant SEC_OTG_FS_DIEPINT5_XFRC                         \ XFRC
$00000002 constant SEC_OTG_FS_DIEPINT5_EPDISD                       \ EPDISD
$00000008 constant SEC_OTG_FS_DIEPINT5_TOC                          \ TOC
$00000010 constant SEC_OTG_FS_DIEPINT5_ITTXFE                       \ ITTXFE
$00000020 constant SEC_OTG_FS_DIEPINT5_INEPNM                       \ INEPNM
$00000040 constant SEC_OTG_FS_DIEPINT5_INEPNE                       \ INEPNE
$00000080 constant SEC_OTG_FS_DIEPINT5_TXFE                         \ TXFE
$00000800 constant SEC_OTG_FS_DIEPINT5_PKTDRPSTS                    \ PKTDRPSTS
$00002000 constant SEC_OTG_FS_DIEPINT5_NAK                          \ NAK


\
\ @brief The application must modify this register before enabling the endpoint. Once the endpoint is enabled using the endpoint enable bit in the DIEPCTLx registers (EPENA bit in DIEPCTLx), the core modifies this register. The application can only read this register once the core has cleared the endpoint enable bit.
\ Address offset: 0x9B0
\ Reset value: 0x00000000
\

$0007ffff constant SEC_OTG_FS_DIEPTSIZ5_XFRSIZ                      \ XFRSIZ
$1ff80000 constant SEC_OTG_FS_DIEPTSIZ5_PKTCNT                      \ PKTCNT
$60000000 constant SEC_OTG_FS_DIEPTSIZ5_MCNT                        \ MCNT


\
\ @brief This read-only register contains the free space information for the device IN endpoint Tx FIFO.
\ Address offset: 0x9B8
\ Reset value: 0x00000200
\

$0000ffff constant SEC_OTG_FS_DTXFSTS5_INEPTFSAV                    \ INEPTFSAV


\
\ @brief This section describes the DOEPCTL0 register.
\ Address offset: 0xB00
\ Reset value: 0x00008000
\

$00000003 constant SEC_OTG_FS_DOEPCTL0_MPSIZ                        \ MPSIZ
$00008000 constant SEC_OTG_FS_DOEPCTL0_USBAEP                       \ USBAEP
$00020000 constant SEC_OTG_FS_DOEPCTL0_NAKSTS                       \ NAKSTS
$000c0000 constant SEC_OTG_FS_DOEPCTL0_EPTYP                        \ EPTYP
$00100000 constant SEC_OTG_FS_DOEPCTL0_SNPM                         \ SNPM
$00200000 constant SEC_OTG_FS_DOEPCTL0_STALL                        \ STALL
$04000000 constant SEC_OTG_FS_DOEPCTL0_CNAK                         \ CNAK
$08000000 constant SEC_OTG_FS_DOEPCTL0_SNAK                         \ SNAK
$40000000 constant SEC_OTG_FS_DOEPCTL0_EPDIS                        \ EPDIS
$80000000 constant SEC_OTG_FS_DOEPCTL0_EPENA                        \ EPENA


\
\ @brief This register indicates the status of an endpoint with respect to USB- and AHB-related events. It is shown in Figure724. The application must read this register when the OUT endpoints interrupt bit of the GINTSTS register (OEPINT bit in GINTSTS) is set. Before the application can read this register, it must first read the DAINT register to get the exact endpoint number for the DOEPINTx register. The application must clear the appropriate bit in this register to clear the corresponding bits in the DAINT and GINTSTS registers.
\ Address offset: 0xB08
\ Reset value: 0x00000080
\

$00000001 constant SEC_OTG_FS_DOEPINT0_XFRC                         \ XFRC
$00000002 constant SEC_OTG_FS_DOEPINT0_EPDISD                       \ EPDISD
$00000004 constant SEC_OTG_FS_DOEPINT0_AHBERR                       \ AHBERR
$00000008 constant SEC_OTG_FS_DOEPINT0_STUP                         \ STUP
$00000010 constant SEC_OTG_FS_DOEPINT0_OTEPDIS                      \ OTEPDIS
$00000020 constant SEC_OTG_FS_DOEPINT0_STSPHSRX                     \ STSPHSRX
$00000040 constant SEC_OTG_FS_DOEPINT0_B2BSTUP                      \ B2BSTUP
$00000100 constant SEC_OTG_FS_DOEPINT0_OUTPKTERR                    \ OUTPKTERR
$00000200 constant SEC_OTG_FS_DOEPINT0_BNA                          \ BNA
$00001000 constant SEC_OTG_FS_DOEPINT0_BERR                         \ BERR
$00002000 constant SEC_OTG_FS_DOEPINT0_NAK                          \ NAK
$00004000 constant SEC_OTG_FS_DOEPINT0_NYET                         \ NYET
$00008000 constant SEC_OTG_FS_DOEPINT0_STPKTRX                      \ STPKTRX


\
\ @brief The application must modify this register before enabling endpoint 0.
\ Address offset: 0xB10
\ Reset value: 0x00000000
\

$0000007f constant SEC_OTG_FS_DOEPTSIZ0_XFRSIZ                      \ XFRSIZ
$00080000 constant SEC_OTG_FS_DOEPTSIZ0_PKTCNT                      \ PKTCNT
$60000000 constant SEC_OTG_FS_DOEPTSIZ0_STUPCNT                     \ STUPCNT


\
\ @brief The application uses this register to control the behavior of each logical endpoint other than endpoint 0.
\ Address offset: 0xB20
\ Reset value: 0x00000000
\

$000007ff constant SEC_OTG_FS_DOEPCTL1_MPSIZ                        \ MPSIZ
$00008000 constant SEC_OTG_FS_DOEPCTL1_USBAEP                       \ USBAEP
$00010000 constant SEC_OTG_FS_DOEPCTL1_EONUM_DPIP                   \ EONUM_DPIP
$00020000 constant SEC_OTG_FS_DOEPCTL1_NAKSTS                       \ NAKSTS
$000c0000 constant SEC_OTG_FS_DOEPCTL1_EPTYP                        \ EPTYP
$00100000 constant SEC_OTG_FS_DOEPCTL1_SNPM                         \ SNPM
$00200000 constant SEC_OTG_FS_DOEPCTL1_STALL                        \ STALL
$04000000 constant SEC_OTG_FS_DOEPCTL1_CNAK                         \ CNAK
$08000000 constant SEC_OTG_FS_DOEPCTL1_SNAK                         \ SNAK
$10000000 constant SEC_OTG_FS_DOEPCTL1_SD0PID_SEVNFRM               \ SD0PID_SEVNFRM
$20000000 constant SEC_OTG_FS_DOEPCTL1_SD1PID_SODDFRM               \ SD1PID_SODDFRM
$40000000 constant SEC_OTG_FS_DOEPCTL1_EPDIS                        \ EPDIS
$80000000 constant SEC_OTG_FS_DOEPCTL1_EPENA                        \ EPENA


\
\ @brief This register indicates the status of an endpoint with respect to USB- and AHB-related events. It is shown in Figure724. The application must read this register when the OUT endpoints interrupt bit of the GINTSTS register (OEPINT bit in GINTSTS) is set. Before the application can read this register, it must first read the DAINT register to get the exact endpoint number for the DOEPINTx register. The application must clear the appropriate bit in this register to clear the corresponding bits in the DAINT and GINTSTS registers.
\ Address offset: 0xB28
\ Reset value: 0x00000080
\

$00000001 constant SEC_OTG_FS_DOEPINT1_XFRC                         \ XFRC
$00000002 constant SEC_OTG_FS_DOEPINT1_EPDISD                       \ EPDISD
$00000004 constant SEC_OTG_FS_DOEPINT1_AHBERR                       \ AHBERR
$00000008 constant SEC_OTG_FS_DOEPINT1_STUP                         \ STUP
$00000010 constant SEC_OTG_FS_DOEPINT1_OTEPDIS                      \ OTEPDIS
$00000020 constant SEC_OTG_FS_DOEPINT1_STSPHSRX                     \ STSPHSRX
$00000040 constant SEC_OTG_FS_DOEPINT1_B2BSTUP                      \ B2BSTUP
$00000100 constant SEC_OTG_FS_DOEPINT1_OUTPKTERR                    \ OUTPKTERR
$00000200 constant SEC_OTG_FS_DOEPINT1_BNA                          \ BNA
$00001000 constant SEC_OTG_FS_DOEPINT1_BERR                         \ BERR
$00002000 constant SEC_OTG_FS_DOEPINT1_NAK                          \ NAK
$00004000 constant SEC_OTG_FS_DOEPINT1_NYET                         \ NYET
$00008000 constant SEC_OTG_FS_DOEPINT1_STPKTRX                      \ STPKTRX


\
\ @brief The application must modify this register before enabling the endpoint. Once the endpoint is enabled using endpoint enable bit of the DOEPCTLx registers (EPENA bit in DOEPCTLx), the core modifies this register. The application can only read this register once the core has cleared the endpoint enable bit.
\ Address offset: 0xB30
\ Reset value: 0x00000000
\

$0007ffff constant SEC_OTG_FS_DOEPTSIZ1_XFRSIZ                      \ XFRSIZ
$1ff80000 constant SEC_OTG_FS_DOEPTSIZ1_PKTCNT                      \ PKTCNT
$60000000 constant SEC_OTG_FS_DOEPTSIZ1_RXDPID_STUPCNT              \ RXDPID_STUPCNT


\
\ @brief The application uses this register to control the behavior of each logical endpoint other than endpoint 0.
\ Address offset: 0xB40
\ Reset value: 0x00000000
\

$000007ff constant SEC_OTG_FS_DOEPCTL2_MPSIZ                        \ MPSIZ
$00008000 constant SEC_OTG_FS_DOEPCTL2_USBAEP                       \ USBAEP
$00010000 constant SEC_OTG_FS_DOEPCTL2_EONUM_DPIP                   \ EONUM_DPIP
$00020000 constant SEC_OTG_FS_DOEPCTL2_NAKSTS                       \ NAKSTS
$000c0000 constant SEC_OTG_FS_DOEPCTL2_EPTYP                        \ EPTYP
$00100000 constant SEC_OTG_FS_DOEPCTL2_SNPM                         \ SNPM
$00200000 constant SEC_OTG_FS_DOEPCTL2_STALL                        \ STALL
$04000000 constant SEC_OTG_FS_DOEPCTL2_CNAK                         \ CNAK
$08000000 constant SEC_OTG_FS_DOEPCTL2_SNAK                         \ SNAK
$10000000 constant SEC_OTG_FS_DOEPCTL2_SD0PID_SEVNFRM               \ SD0PID_SEVNFRM
$20000000 constant SEC_OTG_FS_DOEPCTL2_SD1PID_SODDFRM               \ SD1PID_SODDFRM
$40000000 constant SEC_OTG_FS_DOEPCTL2_EPDIS                        \ EPDIS
$80000000 constant SEC_OTG_FS_DOEPCTL2_EPENA                        \ EPENA


\
\ @brief This register indicates the status of an endpoint with respect to USB- and AHB-related events. It is shown in Figure724. The application must read this register when the OUT endpoints interrupt bit of the GINTSTS register (OEPINT bit in GINTSTS) is set. Before the application can read this register, it must first read the DAINT register to get the exact endpoint number for the DOEPINTx register. The application must clear the appropriate bit in this register to clear the corresponding bits in the DAINT and GINTSTS registers.
\ Address offset: 0xB48
\ Reset value: 0x00000080
\

$00000001 constant SEC_OTG_FS_DOEPINT2_XFRC                         \ XFRC
$00000002 constant SEC_OTG_FS_DOEPINT2_EPDISD                       \ EPDISD
$00000004 constant SEC_OTG_FS_DOEPINT2_AHBERR                       \ AHBERR
$00000008 constant SEC_OTG_FS_DOEPINT2_STUP                         \ STUP
$00000010 constant SEC_OTG_FS_DOEPINT2_OTEPDIS                      \ OTEPDIS
$00000020 constant SEC_OTG_FS_DOEPINT2_STSPHSRX                     \ STSPHSRX
$00000040 constant SEC_OTG_FS_DOEPINT2_B2BSTUP                      \ B2BSTUP
$00000100 constant SEC_OTG_FS_DOEPINT2_OUTPKTERR                    \ OUTPKTERR
$00000200 constant SEC_OTG_FS_DOEPINT2_BNA                          \ BNA
$00001000 constant SEC_OTG_FS_DOEPINT2_BERR                         \ BERR
$00002000 constant SEC_OTG_FS_DOEPINT2_NAK                          \ NAK
$00004000 constant SEC_OTG_FS_DOEPINT2_NYET                         \ NYET
$00008000 constant SEC_OTG_FS_DOEPINT2_STPKTRX                      \ STPKTRX


\
\ @brief The application must modify this register before enabling the endpoint. Once the endpoint is enabled using endpoint enable bit of the DOEPCTLx registers (EPENA bit in DOEPCTLx), the core modifies this register. The application can only read this register once the core has cleared the endpoint enable bit.
\ Address offset: 0xB50
\ Reset value: 0x00000000
\

$0007ffff constant SEC_OTG_FS_DOEPTSIZ2_XFRSIZ                      \ XFRSIZ
$1ff80000 constant SEC_OTG_FS_DOEPTSIZ2_PKTCNT                      \ PKTCNT
$60000000 constant SEC_OTG_FS_DOEPTSIZ2_RXDPID_STUPCNT              \ RXDPID_STUPCNT


\
\ @brief The application uses this register to control the behavior of each logical endpoint other than endpoint 0.
\ Address offset: 0xB60
\ Reset value: 0x00000000
\

$000007ff constant SEC_OTG_FS_DOEPCTL3_MPSIZ                        \ MPSIZ
$00008000 constant SEC_OTG_FS_DOEPCTL3_USBAEP                       \ USBAEP
$00010000 constant SEC_OTG_FS_DOEPCTL3_EONUM_DPIP                   \ EONUM_DPIP
$00020000 constant SEC_OTG_FS_DOEPCTL3_NAKSTS                       \ NAKSTS
$000c0000 constant SEC_OTG_FS_DOEPCTL3_EPTYP                        \ EPTYP
$00100000 constant SEC_OTG_FS_DOEPCTL3_SNPM                         \ SNPM
$00200000 constant SEC_OTG_FS_DOEPCTL3_STALL                        \ STALL
$04000000 constant SEC_OTG_FS_DOEPCTL3_CNAK                         \ CNAK
$08000000 constant SEC_OTG_FS_DOEPCTL3_SNAK                         \ SNAK
$10000000 constant SEC_OTG_FS_DOEPCTL3_SD0PID_SEVNFRM               \ SD0PID_SEVNFRM
$20000000 constant SEC_OTG_FS_DOEPCTL3_SD1PID_SODDFRM               \ SD1PID_SODDFRM
$40000000 constant SEC_OTG_FS_DOEPCTL3_EPDIS                        \ EPDIS
$80000000 constant SEC_OTG_FS_DOEPCTL3_EPENA                        \ EPENA


\
\ @brief This register indicates the status of an endpoint with respect to USB- and AHB-related events. It is shown in Figure724. The application must read this register when the OUT endpoints interrupt bit of the GINTSTS register (OEPINT bit in GINTSTS) is set. Before the application can read this register, it must first read the DAINT register to get the exact endpoint number for the DOEPINTx register. The application must clear the appropriate bit in this register to clear the corresponding bits in the DAINT and GINTSTS registers.
\ Address offset: 0xB68
\ Reset value: 0x00000080
\

$00000001 constant SEC_OTG_FS_DOEPINT3_XFRC                         \ XFRC
$00000002 constant SEC_OTG_FS_DOEPINT3_EPDISD                       \ EPDISD
$00000004 constant SEC_OTG_FS_DOEPINT3_AHBERR                       \ AHBERR
$00000008 constant SEC_OTG_FS_DOEPINT3_STUP                         \ STUP
$00000010 constant SEC_OTG_FS_DOEPINT3_OTEPDIS                      \ OTEPDIS
$00000020 constant SEC_OTG_FS_DOEPINT3_STSPHSRX                     \ STSPHSRX
$00000040 constant SEC_OTG_FS_DOEPINT3_B2BSTUP                      \ B2BSTUP
$00000100 constant SEC_OTG_FS_DOEPINT3_OUTPKTERR                    \ OUTPKTERR
$00000200 constant SEC_OTG_FS_DOEPINT3_BNA                          \ BNA
$00001000 constant SEC_OTG_FS_DOEPINT3_BERR                         \ BERR
$00002000 constant SEC_OTG_FS_DOEPINT3_NAK                          \ NAK
$00004000 constant SEC_OTG_FS_DOEPINT3_NYET                         \ NYET
$00008000 constant SEC_OTG_FS_DOEPINT3_STPKTRX                      \ STPKTRX


\
\ @brief The application must modify this register before enabling the endpoint. Once the endpoint is enabled using endpoint enable bit of the DOEPCTLx registers (EPENA bit in DOEPCTLx), the core modifies this register. The application can only read this register once the core has cleared the endpoint enable bit.
\ Address offset: 0xB70
\ Reset value: 0x00000000
\

$0007ffff constant SEC_OTG_FS_DOEPTSIZ3_XFRSIZ                      \ XFRSIZ
$1ff80000 constant SEC_OTG_FS_DOEPTSIZ3_PKTCNT                      \ PKTCNT
$60000000 constant SEC_OTG_FS_DOEPTSIZ3_RXDPID_STUPCNT              \ RXDPID_STUPCNT


\
\ @brief The application uses this register to control the behavior of each logical endpoint other than endpoint 0.
\ Address offset: 0xB80
\ Reset value: 0x00000000
\

$000007ff constant SEC_OTG_FS_DOEPCTL4_MPSIZ                        \ MPSIZ
$00008000 constant SEC_OTG_FS_DOEPCTL4_USBAEP                       \ USBAEP
$00010000 constant SEC_OTG_FS_DOEPCTL4_EONUM_DPIP                   \ EONUM_DPIP
$00020000 constant SEC_OTG_FS_DOEPCTL4_NAKSTS                       \ NAKSTS
$000c0000 constant SEC_OTG_FS_DOEPCTL4_EPTYP                        \ EPTYP
$00100000 constant SEC_OTG_FS_DOEPCTL4_SNPM                         \ SNPM
$00200000 constant SEC_OTG_FS_DOEPCTL4_STALL                        \ STALL
$04000000 constant SEC_OTG_FS_DOEPCTL4_CNAK                         \ CNAK
$08000000 constant SEC_OTG_FS_DOEPCTL4_SNAK                         \ SNAK
$10000000 constant SEC_OTG_FS_DOEPCTL4_SD0PID_SEVNFRM               \ SD0PID_SEVNFRM
$20000000 constant SEC_OTG_FS_DOEPCTL4_SD1PID_SODDFRM               \ SD1PID_SODDFRM
$40000000 constant SEC_OTG_FS_DOEPCTL4_EPDIS                        \ EPDIS
$80000000 constant SEC_OTG_FS_DOEPCTL4_EPENA                        \ EPENA


\
\ @brief This register indicates the status of an endpoint with respect to USB- and AHB-related events. It is shown in Figure724. The application must read this register when the OUT endpoints interrupt bit of the GINTSTS register (OEPINT bit in GINTSTS) is set. Before the application can read this register, it must first read the DAINT register to get the exact endpoint number for the DOEPINTx register. The application must clear the appropriate bit in this register to clear the corresponding bits in the DAINT and GINTSTS registers.
\ Address offset: 0xB88
\ Reset value: 0x00000080
\

$00000001 constant SEC_OTG_FS_DOEPINT4_XFRC                         \ XFRC
$00000002 constant SEC_OTG_FS_DOEPINT4_EPDISD                       \ EPDISD
$00000004 constant SEC_OTG_FS_DOEPINT4_AHBERR                       \ AHBERR
$00000008 constant SEC_OTG_FS_DOEPINT4_STUP                         \ STUP
$00000010 constant SEC_OTG_FS_DOEPINT4_OTEPDIS                      \ OTEPDIS
$00000020 constant SEC_OTG_FS_DOEPINT4_STSPHSRX                     \ STSPHSRX
$00000040 constant SEC_OTG_FS_DOEPINT4_B2BSTUP                      \ B2BSTUP
$00000100 constant SEC_OTG_FS_DOEPINT4_OUTPKTERR                    \ OUTPKTERR
$00000200 constant SEC_OTG_FS_DOEPINT4_BNA                          \ BNA
$00001000 constant SEC_OTG_FS_DOEPINT4_BERR                         \ BERR
$00002000 constant SEC_OTG_FS_DOEPINT4_NAK                          \ NAK
$00004000 constant SEC_OTG_FS_DOEPINT4_NYET                         \ NYET
$00008000 constant SEC_OTG_FS_DOEPINT4_STPKTRX                      \ STPKTRX


\
\ @brief The application must modify this register before enabling the endpoint. Once the endpoint is enabled using endpoint enable bit of the DOEPCTLx registers (EPENA bit in DOEPCTLx), the core modifies this register. The application can only read this register once the core has cleared the endpoint enable bit.
\ Address offset: 0xB90
\ Reset value: 0x00000000
\

$0007ffff constant SEC_OTG_FS_DOEPTSIZ4_XFRSIZ                      \ XFRSIZ
$1ff80000 constant SEC_OTG_FS_DOEPTSIZ4_PKTCNT                      \ PKTCNT
$60000000 constant SEC_OTG_FS_DOEPTSIZ4_RXDPID_STUPCNT              \ RXDPID_STUPCNT


\
\ @brief The application uses this register to control the behavior of each logical endpoint other than endpoint 0.
\ Address offset: 0xBA0
\ Reset value: 0x00000000
\

$000007ff constant SEC_OTG_FS_DOEPCTL5_MPSIZ                        \ MPSIZ
$00008000 constant SEC_OTG_FS_DOEPCTL5_USBAEP                       \ USBAEP
$00010000 constant SEC_OTG_FS_DOEPCTL5_EONUM_DPIP                   \ EONUM_DPIP
$00020000 constant SEC_OTG_FS_DOEPCTL5_NAKSTS                       \ NAKSTS
$000c0000 constant SEC_OTG_FS_DOEPCTL5_EPTYP                        \ EPTYP
$00100000 constant SEC_OTG_FS_DOEPCTL5_SNPM                         \ SNPM
$00200000 constant SEC_OTG_FS_DOEPCTL5_STALL                        \ STALL
$04000000 constant SEC_OTG_FS_DOEPCTL5_CNAK                         \ CNAK
$08000000 constant SEC_OTG_FS_DOEPCTL5_SNAK                         \ SNAK
$10000000 constant SEC_OTG_FS_DOEPCTL5_SD0PID_SEVNFRM               \ SD0PID_SEVNFRM
$20000000 constant SEC_OTG_FS_DOEPCTL5_SD1PID_SODDFRM               \ SD1PID_SODDFRM
$40000000 constant SEC_OTG_FS_DOEPCTL5_EPDIS                        \ EPDIS
$80000000 constant SEC_OTG_FS_DOEPCTL5_EPENA                        \ EPENA


\
\ @brief This register indicates the status of an endpoint with respect to USB- and AHB-related events. It is shown in Figure724. The application must read this register when the OUT endpoints interrupt bit of the GINTSTS register (OEPINT bit in GINTSTS) is set. Before the application can read this register, it must first read the DAINT register to get the exact endpoint number for the DOEPINTx register. The application must clear the appropriate bit in this register to clear the corresponding bits in the DAINT and GINTSTS registers.
\ Address offset: 0xBA8
\ Reset value: 0x00000080
\

$00000001 constant SEC_OTG_FS_DOEPINT5_XFRC                         \ XFRC
$00000002 constant SEC_OTG_FS_DOEPINT5_EPDISD                       \ EPDISD
$00000004 constant SEC_OTG_FS_DOEPINT5_AHBERR                       \ AHBERR
$00000008 constant SEC_OTG_FS_DOEPINT5_STUP                         \ STUP
$00000010 constant SEC_OTG_FS_DOEPINT5_OTEPDIS                      \ OTEPDIS
$00000020 constant SEC_OTG_FS_DOEPINT5_STSPHSRX                     \ STSPHSRX
$00000040 constant SEC_OTG_FS_DOEPINT5_B2BSTUP                      \ B2BSTUP
$00000100 constant SEC_OTG_FS_DOEPINT5_OUTPKTERR                    \ OUTPKTERR
$00000200 constant SEC_OTG_FS_DOEPINT5_BNA                          \ BNA
$00001000 constant SEC_OTG_FS_DOEPINT5_BERR                         \ BERR
$00002000 constant SEC_OTG_FS_DOEPINT5_NAK                          \ NAK
$00004000 constant SEC_OTG_FS_DOEPINT5_NYET                         \ NYET
$00008000 constant SEC_OTG_FS_DOEPINT5_STPKTRX                      \ STPKTRX


\
\ @brief The application must modify this register before enabling the endpoint. Once the endpoint is enabled using endpoint enable bit of the DOEPCTLx registers (EPENA bit in DOEPCTLx), the core modifies this register. The application can only read this register once the core has cleared the endpoint enable bit.
\ Address offset: 0xBB0
\ Reset value: 0x00000000
\

$0007ffff constant SEC_OTG_FS_DOEPTSIZ5_XFRSIZ                      \ XFRSIZ
$1ff80000 constant SEC_OTG_FS_DOEPTSIZ5_PKTCNT                      \ PKTCNT
$60000000 constant SEC_OTG_FS_DOEPTSIZ5_RXDPID_STUPCNT              \ RXDPID_STUPCNT


\
\ @brief This register is available in host and device modes.
\ Address offset: 0xE00
\ Reset value: 0x200B8000
\

$00000001 constant SEC_OTG_FS_PCGCCTL_STPPCLK                       \ STPPCLK
$00000002 constant SEC_OTG_FS_PCGCCTL_GATEHCLK                      \ GATEHCLK
$00000010 constant SEC_OTG_FS_PCGCCTL_PHYSUSP                       \ PHYSUSP
$00000020 constant SEC_OTG_FS_PCGCCTL_ENL1GTG                       \ ENL1GTG
$00000040 constant SEC_OTG_FS_PCGCCTL_PHYSLEEP                      \ PHYSLEEP
$00000080 constant SEC_OTG_FS_PCGCCTL_SUSP                          \ SUSP


\
\ @brief OTG_FS
\
$52040000 constant SEC_OTG_FS_GOTGCTL  \ offset: 0x00 : The GOTGCTL register controls the behavior and reflects the status of the OTG function of the core.
$52040004 constant SEC_OTG_FS_GOTGINT  \ offset: 0x04 : The application reads this register whenever there is an OTG interrupt and clears the bits in this register to clear the OTG interrupt.
$52040008 constant SEC_OTG_FS_GAHBCFG  \ offset: 0x08 : This register can be used to configure the core after power-on or a change in mode. This register mainly contains AHB system-related configuration parameters. Do not change this register after the initial programming. The application must program this register before starting any transactions on either the AHB or the USB.
$5204000c constant SEC_OTG_FS_GUSBCFG  \ offset: 0x0C : This register can be used to configure the core after power-on or a changing to host mode or device mode. It contains USB and USB-PHY related configuration parameters. The application must program this register before starting any transactions on either the AHB or the USB. Do not make changes to this register after the initial programming.
$52040010 constant SEC_OTG_FS_GRSTCTL  \ offset: 0x10 : The application uses this register to reset various hardware features inside the core.
$52040014 constant SEC_OTG_FS_GINTSTS  \ offset: 0x14 : This register interrupts the application for system-level events in the current mode (device mode or host mode). Some of the bits in this register are valid only in host mode, while others are valid in device mode only. This register also indicates the current mode. To clear the interrupt status bits of the rc_w1 type, the application must write 1 into the bit. The FIFO status interrupts are read-only; once software reads from or writes to the FIFO while servicing these interrupts, FIFO interrupt conditions are cleared automatically. The application must clear the GINTSTS register at initialization before unmasking the interrupt bit to avoid any interrupts generated prior to initialization.
$52040018 constant SEC_OTG_FS_GINTMSK  \ offset: 0x18 : This register works with the core interrupt register to interrupt the application. When an interrupt bit is masked, the interrupt associated with that bit is not generated. However, the core interrupt (GINTSTS) register bit corresponding to that interrupt is still set.
$5204001c constant SEC_OTG_FS_GRXSTSR_DEVICE  \ offset: 0x1C : This description is for register GRXSTSR in Device mode. A read to the receive status debug read register returns the contents of the top of the receive FIFO. The core ignores the receive status read when the receive FIFO is empty and returns a value of 0x00000000.
$5204001c constant SEC_OTG_FS_GRXSTSR_HOST  \ offset: 0x1C : This description is for register GRXSTSR in Host mode
$52040020 constant SEC_OTG_FS_GRXSTSP_DEVICE  \ offset: 0x20 : This description is for register GRXSTSP in Device mode. Similarly to GRXSTSR (receive status debug read register) where a read returns the contents of the top of the receive FIFO, a read to GRXSTSP (receive status read and pop register) additionally pops the top data entry out of the Rx FIFO. The core ignores the receive status pop/read when the receive FIFO is empty and returns a value of 0x00000000. The application must only pop the receive status FIFO when the receive FIFO non-empty bit of the core interrupt register (RXFLVL bit in GINTSTS) is asserted.
$52040020 constant SEC_OTG_FS_GRXSTSP_HOST  \ offset: 0x20 : This description is for register GRXSTSP in HOST mode
$52040024 constant SEC_OTG_FS_GRXFSIZ  \ offset: 0x24 : The application can program the RAM size that must be allocated to the Rx FIFO.
$52040028 constant SEC_OTG_FS_HNPTXFSIZ  \ offset: 0x28 : Host mode
$5204002c constant SEC_OTG_FS_HNPTXSTS  \ offset: 0x2C : In device mode, this register is not valid. This read-only register contains the free space information for the non-periodic Tx FIFO and the non-periodic transmit request queue.
$52040038 constant SEC_OTG_FS_GCCFG  \ offset: 0x38 : OTG general core configuration register
$5204003c constant SEC_OTG_FS_CID  \ offset: 0x3C : This is a register containing the Product ID as reset value.
$52040054 constant SEC_OTG_FS_GLPMCFG  \ offset: 0x54 : OTG core LPM configuration register
$52040100 constant SEC_OTG_FS_HPTXFSIZ  \ offset: 0x100 : OTG host periodic transmit FIFO size register
$52040104 constant SEC_OTG_FS_DIEPTXF1  \ offset: 0x104 : OTG device IN endpoint transmit FIFO 1 size register
$52040108 constant SEC_OTG_FS_DIEPTXF2  \ offset: 0x108 : OTG device IN endpoint transmit FIFO 2 size register
$5204010c constant SEC_OTG_FS_DIEPTXF3  \ offset: 0x10C : OTG device IN endpoint transmit FIFO 3 size register
$52040110 constant SEC_OTG_FS_DIEPTXF4  \ offset: 0x110 : OTG device IN endpoint transmit FIFO 4 size register
$52040114 constant SEC_OTG_FS_DIEPTXF5  \ offset: 0x114 : OTG device IN endpoint transmit FIFO 5 size register
$52040400 constant SEC_OTG_FS_HCFG  \ offset: 0x400 : This register configures the core after power-on. Do not make changes to this register after initializing the host.
$52040404 constant SEC_OTG_FS_HFIR  \ offset: 0x404 : This register stores the frame interval information for the current speed to which the OTG controller has enumerated.
$52040408 constant SEC_OTG_FS_HFNUM  \ offset: 0x408 : This register indicates the current frame number. It also indicates the time remaining (in terms of the number of PHY clocks) in the current frame.
$52040410 constant SEC_OTG_FS_HPTXSTS  \ offset: 0x410 : This read-only register contains the free space information for the periodic Tx FIFO and the periodic transmit request queue.
$52040414 constant SEC_OTG_FS_HAINT  \ offset: 0x414 : When a significant event occurs on a channel, the host all channels interrupt register interrupts the application using the host channels interrupt bit of the core interrupt register (HCINT bit in GINTSTS). This is shown in Figure724. There is one interrupt bit per channel, up to a maximum of 16 bits. Bits in this register are set and cleared when the application sets and clears bits in the corresponding host channel-x interrupt register.
$52040418 constant SEC_OTG_FS_HAINTMSK  \ offset: 0x418 : The host all channel interrupt mask register works with the host all channel interrupt register to interrupt the application when an event occurs on a channel. There is one interrupt mask bit per channel, up to a maximum of 16 bits.
$52040440 constant SEC_OTG_FS_HPRT  \ offset: 0x440 : This register is available only in host mode. Currently, the OTG host supports only one port. A single register holds USB port-related information such as USB reset, enable, suspend, resume, connect status, and test mode for each port. It is shown in Figure724. The rc_w1 bits in this register can trigger an interrupt to the application through the host port interrupt bit of the core interrupt register (HPRTINT bit in GINTSTS). On a port interrupt, the application must read this register and clear the bit that caused the interrupt. For the rc_w1 bits, the application must write a 1 to the bit to clear the interrupt.
$52040500 constant SEC_OTG_FS_HCCHAR0  \ offset: 0x500 : OTG host channel 0 characteristics register
$52040508 constant SEC_OTG_FS_HCINT0  \ offset: 0x508 : This register indicates the status of a channel with respect to USB- and AHB-related events. It is shown in Figure724. The application must read this register when the host channels interrupt bit in the core interrupt register (HCINT bit in GINTSTS) is set. Before the application can read this register, it must first read the host all channels interrupt (HAINT) register to get the exact channel number for the host channel-x interrupt register. The application must clear the appropriate bit in this register to clear the corresponding bits in the HAINT and GINTSTS registers.
$5204050c constant SEC_OTG_FS_HCINTMSK0  \ offset: 0x50C : This register reflects the mask for each channel status described in the previous section.
$52040510 constant SEC_OTG_FS_HCTSIZ0  \ offset: 0x510 : OTG host channel 0 transfer size register
$52040520 constant SEC_OTG_FS_HCCHAR1  \ offset: 0x520 : OTG host channel 1 characteristics register
$52040528 constant SEC_OTG_FS_HCINT1  \ offset: 0x528 : This register indicates the status of a channel with respect to USB- and AHB-related events. It is shown in Figure724. The application must read this register when the host channels interrupt bit in the core interrupt register (HCINT bit in GINTSTS) is set. Before the application can read this register, it must first read the host all channels interrupt (HAINT) register to get the exact channel number for the host channel-x interrupt register. The application must clear the appropriate bit in this register to clear the corresponding bits in the HAINT and GINTSTS registers.
$5204052c constant SEC_OTG_FS_HCINTMSK1  \ offset: 0x52C : This register reflects the mask for each channel status described in the previous section.
$52040530 constant SEC_OTG_FS_HCTSIZ1  \ offset: 0x530 : OTG host channel 1 transfer size register
$52040540 constant SEC_OTG_FS_HCCHAR2  \ offset: 0x540 : OTG host channel 2 characteristics register
$52040548 constant SEC_OTG_FS_HCINT2  \ offset: 0x548 : This register indicates the status of a channel with respect to USB- and AHB-related events. It is shown in Figure724. The application must read this register when the host channels interrupt bit in the core interrupt register (HCINT bit in GINTSTS) is set. Before the application can read this register, it must first read the host all channels interrupt (HAINT) register to get the exact channel number for the host channel-x interrupt register. The application must clear the appropriate bit in this register to clear the corresponding bits in the HAINT and GINTSTS registers.
$5204054c constant SEC_OTG_FS_HCINTMSK2  \ offset: 0x54C : This register reflects the mask for each channel status described in the previous section.
$52040550 constant SEC_OTG_FS_HCTSIZ2  \ offset: 0x550 : OTG host channel 2 transfer size register
$52040560 constant SEC_OTG_FS_HCCHAR3  \ offset: 0x560 : OTG host channel 3 characteristics register
$52040568 constant SEC_OTG_FS_HCINT3  \ offset: 0x568 : This register indicates the status of a channel with respect to USB- and AHB-related events. It is shown in Figure724. The application must read this register when the host channels interrupt bit in the core interrupt register (HCINT bit in GINTSTS) is set. Before the application can read this register, it must first read the host all channels interrupt (HAINT) register to get the exact channel number for the host channel-x interrupt register. The application must clear the appropriate bit in this register to clear the corresponding bits in the HAINT and GINTSTS registers.
$5204056c constant SEC_OTG_FS_HCINTMSK3  \ offset: 0x56C : This register reflects the mask for each channel status described in the previous section.
$52040570 constant SEC_OTG_FS_HCTSIZ3  \ offset: 0x570 : OTG host channel 3 transfer size register
$52040580 constant SEC_OTG_FS_HCCHAR4  \ offset: 0x580 : OTG host channel 4 characteristics register
$52040588 constant SEC_OTG_FS_HCINT4  \ offset: 0x588 : This register indicates the status of a channel with respect to USB- and AHB-related events. It is shown in Figure724. The application must read this register when the host channels interrupt bit in the core interrupt register (HCINT bit in GINTSTS) is set. Before the application can read this register, it must first read the host all channels interrupt (HAINT) register to get the exact channel number for the host channel-x interrupt register. The application must clear the appropriate bit in this register to clear the corresponding bits in the HAINT and GINTSTS registers.
$5204058c constant SEC_OTG_FS_HCINTMSK4  \ offset: 0x58C : This register reflects the mask for each channel status described in the previous section.
$52040590 constant SEC_OTG_FS_HCTSIZ4  \ offset: 0x590 : OTG host channel 4 transfer size register
$520405a0 constant SEC_OTG_FS_HCCHAR5  \ offset: 0x5A0 : OTG host channel 5 characteristics register
$520405a8 constant SEC_OTG_FS_HCINT5  \ offset: 0x5A8 : This register indicates the status of a channel with respect to USB- and AHB-related events. It is shown in Figure724. The application must read this register when the host channels interrupt bit in the core interrupt register (HCINT bit in GINTSTS) is set. Before the application can read this register, it must first read the host all channels interrupt (HAINT) register to get the exact channel number for the host channel-x interrupt register. The application must clear the appropriate bit in this register to clear the corresponding bits in the HAINT and GINTSTS registers.
$520405ac constant SEC_OTG_FS_HCINTMSK5  \ offset: 0x5AC : This register reflects the mask for each channel status described in the previous section.
$520405b0 constant SEC_OTG_FS_HCTSIZ5  \ offset: 0x5B0 : OTG host channel 5 transfer size register
$520405c0 constant SEC_OTG_FS_HCCHAR6  \ offset: 0x5C0 : OTG host channel 6 characteristics register
$520405c8 constant SEC_OTG_FS_HCINT6  \ offset: 0x5C8 : This register indicates the status of a channel with respect to USB- and AHB-related events. It is shown in Figure724. The application must read this register when the host channels interrupt bit in the core interrupt register (HCINT bit in GINTSTS) is set. Before the application can read this register, it must first read the host all channels interrupt (HAINT) register to get the exact channel number for the host channel-x interrupt register. The application must clear the appropriate bit in this register to clear the corresponding bits in the HAINT and GINTSTS registers.
$520405cc constant SEC_OTG_FS_HCINTMSK6  \ offset: 0x5CC : This register reflects the mask for each channel status described in the previous section.
$520405d0 constant SEC_OTG_FS_HCTSIZ6  \ offset: 0x5D0 : OTG host channel 6 transfer size register
$520405e0 constant SEC_OTG_FS_HCCHAR7  \ offset: 0x5E0 : OTG host channel 7 characteristics register
$520405e8 constant SEC_OTG_FS_HCINT7  \ offset: 0x5E8 : This register indicates the status of a channel with respect to USB- and AHB-related events. It is shown in Figure724. The application must read this register when the host channels interrupt bit in the core interrupt register (HCINT bit in GINTSTS) is set. Before the application can read this register, it must first read the host all channels interrupt (HAINT) register to get the exact channel number for the host channel-x interrupt register. The application must clear the appropriate bit in this register to clear the corresponding bits in the HAINT and GINTSTS registers.
$520405ec constant SEC_OTG_FS_HCINTMSK7  \ offset: 0x5EC : This register reflects the mask for each channel status described in the previous section.
$520405f0 constant SEC_OTG_FS_HCTSIZ7  \ offset: 0x5F0 : OTG host channel 7 transfer size register
$52040600 constant SEC_OTG_FS_HCCHAR8  \ offset: 0x600 : OTG host channel 8 characteristics register
$52040608 constant SEC_OTG_FS_HCINT8  \ offset: 0x608 : This register indicates the status of a channel with respect to USB- and AHB-related events. It is shown in Figure724. The application must read this register when the host channels interrupt bit in the core interrupt register (HCINT bit in GINTSTS) is set. Before the application can read this register, it must first read the host all channels interrupt (HAINT) register to get the exact channel number for the host channel-x interrupt register. The application must clear the appropriate bit in this register to clear the corresponding bits in the HAINT and GINTSTS registers.
$5204060c constant SEC_OTG_FS_HCINTMSK8  \ offset: 0x60C : This register reflects the mask for each channel status described in the previous section.
$52040610 constant SEC_OTG_FS_HCTSIZ8  \ offset: 0x610 : OTG host channel 8 transfer size register
$52040620 constant SEC_OTG_FS_HCCHAR9  \ offset: 0x620 : OTG host channel 9 characteristics register
$52040628 constant SEC_OTG_FS_HCINT9  \ offset: 0x628 : This register indicates the status of a channel with respect to USB- and AHB-related events. It is shown in Figure724. The application must read this register when the host channels interrupt bit in the core interrupt register (HCINT bit in GINTSTS) is set. Before the application can read this register, it must first read the host all channels interrupt (HAINT) register to get the exact channel number for the host channel-x interrupt register. The application must clear the appropriate bit in this register to clear the corresponding bits in the HAINT and GINTSTS registers.
$5204062c constant SEC_OTG_FS_HCINTMSK9  \ offset: 0x62C : This register reflects the mask for each channel status described in the previous section.
$52040630 constant SEC_OTG_FS_HCTSIZ9  \ offset: 0x630 : OTG host channel 9 transfer size register
$52040640 constant SEC_OTG_FS_HCCHAR10  \ offset: 0x640 : OTG host channel 10 characteristics register
$52040648 constant SEC_OTG_FS_HCINT10  \ offset: 0x648 : This register indicates the status of a channel with respect to USB- and AHB-related events. It is shown in Figure724. The application must read this register when the host channels interrupt bit in the core interrupt register (HCINT bit in GINTSTS) is set. Before the application can read this register, it must first read the host all channels interrupt (HAINT) register to get the exact channel number for the host channel-x interrupt register. The application must clear the appropriate bit in this register to clear the corresponding bits in the HAINT and GINTSTS registers.
$5204064c constant SEC_OTG_FS_HCINTMSK10  \ offset: 0x64C : This register reflects the mask for each channel status described in the previous section.
$52040650 constant SEC_OTG_FS_HCTSIZ10  \ offset: 0x650 : OTG host channel 10 transfer size register
$52040660 constant SEC_OTG_FS_HCCHAR11  \ offset: 0x660 : OTG host channel 11 characteristics register
$52040668 constant SEC_OTG_FS_HCINT11  \ offset: 0x668 : This register indicates the status of a channel with respect to USB- and AHB-related events. It is shown in Figure724. The application must read this register when the host channels interrupt bit in the core interrupt register (HCINT bit in GINTSTS) is set. Before the application can read this register, it must first read the host all channels interrupt (HAINT) register to get the exact channel number for the host channel-x interrupt register. The application must clear the appropriate bit in this register to clear the corresponding bits in the HAINT and GINTSTS registers.
$5204066c constant SEC_OTG_FS_HCINTMSK11  \ offset: 0x66C : This register reflects the mask for each channel status described in the previous section.
$52040670 constant SEC_OTG_FS_HCTSIZ11  \ offset: 0x670 : OTG host channel 11 transfer size register
$52040800 constant SEC_OTG_FS_DCFG  \ offset: 0x800 : This register configures the core in device mode after power-on or after certain control commands or enumeration. Do not make changes to this register after initial programming.
$52040804 constant SEC_OTG_FS_DCTL  \ offset: 0x804 : OTG device control register
$52040808 constant SEC_OTG_FS_DSTS  \ offset: 0x808 : This register indicates the status of the core with respect to USB-related events. It must be read on interrupts from the device all interrupts (DAINT) register.
$52040810 constant SEC_OTG_FS_DIEPMSK  \ offset: 0x810 : This register works with each of the DIEPINTx registers for all endpoints to generate an interrupt per IN endpoint. The IN endpoint interrupt for a specific status in the DIEPINTx register can be masked by writing to the corresponding bit in this register. Status bits are masked by default.
$52040814 constant SEC_OTG_FS_DOEPMSK  \ offset: 0x814 : This register works with each of the DOEPINTx registers for all endpoints to generate an interrupt per OUT endpoint. The OUT endpoint interrupt for a specific status in the DOEPINTx register can be masked by writing into the corresponding bit in this register. Status bits are masked by default.
$52040818 constant SEC_OTG_FS_DAINT  \ offset: 0x818 : When a significant event occurs on an endpoint, a DAINT register interrupts the application using the device OUT endpoints interrupt bit or device IN endpoints interrupt bit of the GINTSTS register (OEPINT or IEPINT in GINTSTS, respectively). There is one interrupt bit per endpoint, up to a maximum of 16 bits for OUT endpoints and 16 bits for IN endpoints. For a bidirectional endpoint, the corresponding IN and OUT interrupt bits are used. Bits in this register are set and cleared when the application sets and clears bits in the corresponding device endpoint-x interrupt register (DIEPINTx/DOEPINTx).
$5204081c constant SEC_OTG_FS_DAINTMSK  \ offset: 0x81C : The DAINTMSK register works with the device endpoint interrupt register to interrupt the application when an event occurs on a device endpoint. However, the DAINT register bit corresponding to that interrupt is still set.
$52040828 constant SEC_OTG_FS_DVBUSDIS  \ offset: 0x828 : This register specifies the VBUS discharge time after VBUS pulsing during SRP.
$5204082c constant SEC_OTG_FS_DVBUSPULSE  \ offset: 0x82C : This register specifies the VBUS pulsing time during SRP.
$52040834 constant SEC_OTG_FS_DIEPEMPMSK  \ offset: 0x834 : This register is used to control the IN endpoint FIFO empty interrupt generation (TXFE_DIEPINTx).
$52040900 constant SEC_OTG_FS_DIEPCTL0  \ offset: 0x900 : The application uses this register to control the behavior of each logical endpoint other than endpoint 0.
$52040908 constant SEC_OTG_FS_DIEPINT0  \ offset: 0x908 : This register indicates the status of an endpoint with respect to USB- and AHB-related events. It is shown in Figure724. The application must read this register when the IN endpoints interrupt bit of the core interrupt register (IEPINT in GINTSTS) is set. Before the application can read this register, it must first read the device all endpoints interrupt (DAINT) register to get the exact endpoint number for the device endpoint-x interrupt register. The application must clear the appropriate bit in this register to clear the corresponding bits in the DAINT and GINTSTS registers.
$52040910 constant SEC_OTG_FS_DIEPTSIZ0  \ offset: 0x910 : The application must modify this register before enabling endpoint 0.
$52040918 constant SEC_OTG_FS_DTXFSTS0  \ offset: 0x918 : This read-only register contains the free space information for the device IN endpoint Tx FIFO.
$52040920 constant SEC_OTG_FS_DIEPCTL1  \ offset: 0x920 : The application uses this register to control the behavior of each logical endpoint other than endpoint 0.
$52040928 constant SEC_OTG_FS_DIEPINT1  \ offset: 0x928 : This register indicates the status of an endpoint with respect to USB- and AHB-related events. It is shown in Figure724. The application must read this register when the IN endpoints interrupt bit of the core interrupt register (IEPINT in GINTSTS) is set. Before the application can read this register, it must first read the device all endpoints interrupt (DAINT) register to get the exact endpoint number for the device endpoint-x interrupt register. The application must clear the appropriate bit in this register to clear the corresponding bits in the DAINT and GINTSTS registers.
$52040930 constant SEC_OTG_FS_DIEPTSIZ1  \ offset: 0x930 : The application must modify this register before enabling the endpoint. Once the endpoint is enabled using the endpoint enable bit in the DIEPCTLx registers (EPENA bit in DIEPCTLx), the core modifies this register. The application can only read this register once the core has cleared the endpoint enable bit.
$52040938 constant SEC_OTG_FS_DTXFSTS1  \ offset: 0x938 : This read-only register contains the free space information for the device IN endpoint Tx FIFO.
$52040940 constant SEC_OTG_FS_DIEPCTL2  \ offset: 0x940 : The application uses this register to control the behavior of each logical endpoint other than endpoint 0.
$52040948 constant SEC_OTG_FS_DIEPINT2  \ offset: 0x948 : This register indicates the status of an endpoint with respect to USB- and AHB-related events. It is shown in Figure724. The application must read this register when the IN endpoints interrupt bit of the core interrupt register (IEPINT in GINTSTS) is set. Before the application can read this register, it must first read the device all endpoints interrupt (DAINT) register to get the exact endpoint number for the device endpoint-x interrupt register. The application must clear the appropriate bit in this register to clear the corresponding bits in the DAINT and GINTSTS registers.
$52040950 constant SEC_OTG_FS_DIEPTSIZ2  \ offset: 0x950 : The application must modify this register before enabling the endpoint. Once the endpoint is enabled using the endpoint enable bit in the DIEPCTLx registers (EPENA bit in DIEPCTLx), the core modifies this register. The application can only read this register once the core has cleared the endpoint enable bit.
$52040958 constant SEC_OTG_FS_DTXFSTS2  \ offset: 0x958 : This read-only register contains the free space information for the device IN endpoint Tx FIFO.
$52040960 constant SEC_OTG_FS_DIEPCTL3  \ offset: 0x960 : The application uses this register to control the behavior of each logical endpoint other than endpoint 0.
$52040968 constant SEC_OTG_FS_DIEPINT3  \ offset: 0x968 : This register indicates the status of an endpoint with respect to USB- and AHB-related events. It is shown in Figure724. The application must read this register when the IN endpoints interrupt bit of the core interrupt register (IEPINT in GINTSTS) is set. Before the application can read this register, it must first read the device all endpoints interrupt (DAINT) register to get the exact endpoint number for the device endpoint-x interrupt register. The application must clear the appropriate bit in this register to clear the corresponding bits in the DAINT and GINTSTS registers.
$52040970 constant SEC_OTG_FS_DIEPTSIZ3  \ offset: 0x970 : The application must modify this register before enabling the endpoint. Once the endpoint is enabled using the endpoint enable bit in the DIEPCTLx registers (EPENA bit in DIEPCTLx), the core modifies this register. The application can only read this register once the core has cleared the endpoint enable bit.
$52040978 constant SEC_OTG_FS_DTXFSTS3  \ offset: 0x978 : This read-only register contains the free space information for the device IN endpoint Tx FIFO.
$52040980 constant SEC_OTG_FS_DIEPCTL4  \ offset: 0x980 : The application uses this register to control the behavior of each logical endpoint other than endpoint 0.
$52040988 constant SEC_OTG_FS_DIEPINT4  \ offset: 0x988 : This register indicates the status of an endpoint with respect to USB- and AHB-related events. It is shown in Figure724. The application must read this register when the IN endpoints interrupt bit of the core interrupt register (IEPINT in GINTSTS) is set. Before the application can read this register, it must first read the device all endpoints interrupt (DAINT) register to get the exact endpoint number for the device endpoint-x interrupt register. The application must clear the appropriate bit in this register to clear the corresponding bits in the DAINT and GINTSTS registers.
$52040990 constant SEC_OTG_FS_DIEPTSIZ4  \ offset: 0x990 : The application must modify this register before enabling the endpoint. Once the endpoint is enabled using the endpoint enable bit in the DIEPCTLx registers (EPENA bit in DIEPCTLx), the core modifies this register. The application can only read this register once the core has cleared the endpoint enable bit.
$52040998 constant SEC_OTG_FS_DTXFSTS4  \ offset: 0x998 : This read-only register contains the free space information for the device IN endpoint Tx FIFO.
$520409a0 constant SEC_OTG_FS_DIEPCTL5  \ offset: 0x9A0 : The application uses this register to control the behavior of each logical endpoint other than endpoint 0.
$520409a8 constant SEC_OTG_FS_DIEPINT5  \ offset: 0x9A8 : This register indicates the status of an endpoint with respect to USB- and AHB-related events. It is shown in Figure724. The application must read this register when the IN endpoints interrupt bit of the core interrupt register (IEPINT in GINTSTS) is set. Before the application can read this register, it must first read the device all endpoints interrupt (DAINT) register to get the exact endpoint number for the device endpoint-x interrupt register. The application must clear the appropriate bit in this register to clear the corresponding bits in the DAINT and GINTSTS registers.
$520409b0 constant SEC_OTG_FS_DIEPTSIZ5  \ offset: 0x9B0 : The application must modify this register before enabling the endpoint. Once the endpoint is enabled using the endpoint enable bit in the DIEPCTLx registers (EPENA bit in DIEPCTLx), the core modifies this register. The application can only read this register once the core has cleared the endpoint enable bit.
$520409b8 constant SEC_OTG_FS_DTXFSTS5  \ offset: 0x9B8 : This read-only register contains the free space information for the device IN endpoint Tx FIFO.
$52040b00 constant SEC_OTG_FS_DOEPCTL0  \ offset: 0xB00 : This section describes the DOEPCTL0 register.
$52040b08 constant SEC_OTG_FS_DOEPINT0  \ offset: 0xB08 : This register indicates the status of an endpoint with respect to USB- and AHB-related events. It is shown in Figure724. The application must read this register when the OUT endpoints interrupt bit of the GINTSTS register (OEPINT bit in GINTSTS) is set. Before the application can read this register, it must first read the DAINT register to get the exact endpoint number for the DOEPINTx register. The application must clear the appropriate bit in this register to clear the corresponding bits in the DAINT and GINTSTS registers.
$52040b10 constant SEC_OTG_FS_DOEPTSIZ0  \ offset: 0xB10 : The application must modify this register before enabling endpoint 0.
$52040b20 constant SEC_OTG_FS_DOEPCTL1  \ offset: 0xB20 : The application uses this register to control the behavior of each logical endpoint other than endpoint 0.
$52040b28 constant SEC_OTG_FS_DOEPINT1  \ offset: 0xB28 : This register indicates the status of an endpoint with respect to USB- and AHB-related events. It is shown in Figure724. The application must read this register when the OUT endpoints interrupt bit of the GINTSTS register (OEPINT bit in GINTSTS) is set. Before the application can read this register, it must first read the DAINT register to get the exact endpoint number for the DOEPINTx register. The application must clear the appropriate bit in this register to clear the corresponding bits in the DAINT and GINTSTS registers.
$52040b30 constant SEC_OTG_FS_DOEPTSIZ1  \ offset: 0xB30 : The application must modify this register before enabling the endpoint. Once the endpoint is enabled using endpoint enable bit of the DOEPCTLx registers (EPENA bit in DOEPCTLx), the core modifies this register. The application can only read this register once the core has cleared the endpoint enable bit.
$52040b40 constant SEC_OTG_FS_DOEPCTL2  \ offset: 0xB40 : The application uses this register to control the behavior of each logical endpoint other than endpoint 0.
$52040b48 constant SEC_OTG_FS_DOEPINT2  \ offset: 0xB48 : This register indicates the status of an endpoint with respect to USB- and AHB-related events. It is shown in Figure724. The application must read this register when the OUT endpoints interrupt bit of the GINTSTS register (OEPINT bit in GINTSTS) is set. Before the application can read this register, it must first read the DAINT register to get the exact endpoint number for the DOEPINTx register. The application must clear the appropriate bit in this register to clear the corresponding bits in the DAINT and GINTSTS registers.
$52040b50 constant SEC_OTG_FS_DOEPTSIZ2  \ offset: 0xB50 : The application must modify this register before enabling the endpoint. Once the endpoint is enabled using endpoint enable bit of the DOEPCTLx registers (EPENA bit in DOEPCTLx), the core modifies this register. The application can only read this register once the core has cleared the endpoint enable bit.
$52040b60 constant SEC_OTG_FS_DOEPCTL3  \ offset: 0xB60 : The application uses this register to control the behavior of each logical endpoint other than endpoint 0.
$52040b68 constant SEC_OTG_FS_DOEPINT3  \ offset: 0xB68 : This register indicates the status of an endpoint with respect to USB- and AHB-related events. It is shown in Figure724. The application must read this register when the OUT endpoints interrupt bit of the GINTSTS register (OEPINT bit in GINTSTS) is set. Before the application can read this register, it must first read the DAINT register to get the exact endpoint number for the DOEPINTx register. The application must clear the appropriate bit in this register to clear the corresponding bits in the DAINT and GINTSTS registers.
$52040b70 constant SEC_OTG_FS_DOEPTSIZ3  \ offset: 0xB70 : The application must modify this register before enabling the endpoint. Once the endpoint is enabled using endpoint enable bit of the DOEPCTLx registers (EPENA bit in DOEPCTLx), the core modifies this register. The application can only read this register once the core has cleared the endpoint enable bit.
$52040b80 constant SEC_OTG_FS_DOEPCTL4  \ offset: 0xB80 : The application uses this register to control the behavior of each logical endpoint other than endpoint 0.
$52040b88 constant SEC_OTG_FS_DOEPINT4  \ offset: 0xB88 : This register indicates the status of an endpoint with respect to USB- and AHB-related events. It is shown in Figure724. The application must read this register when the OUT endpoints interrupt bit of the GINTSTS register (OEPINT bit in GINTSTS) is set. Before the application can read this register, it must first read the DAINT register to get the exact endpoint number for the DOEPINTx register. The application must clear the appropriate bit in this register to clear the corresponding bits in the DAINT and GINTSTS registers.
$52040b90 constant SEC_OTG_FS_DOEPTSIZ4  \ offset: 0xB90 : The application must modify this register before enabling the endpoint. Once the endpoint is enabled using endpoint enable bit of the DOEPCTLx registers (EPENA bit in DOEPCTLx), the core modifies this register. The application can only read this register once the core has cleared the endpoint enable bit.
$52040ba0 constant SEC_OTG_FS_DOEPCTL5  \ offset: 0xBA0 : The application uses this register to control the behavior of each logical endpoint other than endpoint 0.
$52040ba8 constant SEC_OTG_FS_DOEPINT5  \ offset: 0xBA8 : This register indicates the status of an endpoint with respect to USB- and AHB-related events. It is shown in Figure724. The application must read this register when the OUT endpoints interrupt bit of the GINTSTS register (OEPINT bit in GINTSTS) is set. Before the application can read this register, it must first read the DAINT register to get the exact endpoint number for the DOEPINTx register. The application must clear the appropriate bit in this register to clear the corresponding bits in the DAINT and GINTSTS registers.
$52040bb0 constant SEC_OTG_FS_DOEPTSIZ5  \ offset: 0xBB0 : The application must modify this register before enabling the endpoint. Once the endpoint is enabled using endpoint enable bit of the DOEPCTLx registers (EPENA bit in DOEPCTLx), the core modifies this register. The application can only read this register once the core has cleared the endpoint enable bit.
$52040e00 constant SEC_OTG_FS_PCGCCTL  \ offset: 0xE00 : This register is available in host and device modes.

