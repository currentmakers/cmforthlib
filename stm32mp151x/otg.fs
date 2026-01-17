\
\ @file otg.fs
\ @brief OTG
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] OTG_DEF

  [ifdef] OTG_OTG_GOTGCTL_DEF
    \
    \ @brief The OTG_GOTGCTL register controls the behavior and reflects the status of the OTG function of the core.
    \ Address offset: 0x00
    \ Reset value: 0x00010000
    \
    $00 constant OTG_SRQSCS                     \ [0x00] SRQSCS
    $01 constant OTG_SRQ                        \ [0x01] SRQ
    $02 constant OTG_VBVALOEN                   \ [0x02] VBVALOEN
    $03 constant OTG_VBVALOVAL                  \ [0x03] VBVALOVAL
    $04 constant OTG_AVALOEN                    \ [0x04] AVALOEN
    $05 constant OTG_AVALOVAL                   \ [0x05] AVALOVAL
    $06 constant OTG_BVALOEN                    \ [0x06] BVALOEN
    $07 constant OTG_BVALOVAL                   \ [0x07] BVALOVAL
    $08 constant OTG_HNGSCS                     \ [0x08] HNGSCS
    $09 constant OTG_HNPRQ                      \ [0x09] HNPRQ
    $0a constant OTG_HSHNPEN                    \ [0x0a] HSHNPEN
    $0b constant OTG_DHNPEN                     \ [0x0b] DHNPEN
    $0c constant OTG_EHEN                       \ [0x0c] EHEN
    $10 constant OTG_CIDSTS                     \ [0x10] CIDSTS
    $11 constant OTG_DBCT                       \ [0x11] DBCT
    $12 constant OTG_ASVLD                      \ [0x12] ASVLD
    $13 constant OTG_BSVLD                      \ [0x13] BSVLD
    $14 constant OTG_OTGVER                     \ [0x14] OTGVER
    $15 constant OTG_CURMOD                     \ [0x15] CURMOD
  [then]


  [ifdef] OTG_OTG_GOTGINT_DEF
    \
    \ @brief The application reads this register whenever there is an OTG interrupt and clears the bits in this register to clear the OTG interrupt.
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $02 constant OTG_SEDET                      \ [0x02] SEDET
    $08 constant OTG_SRSSCHG                    \ [0x08] SRSSCHG
    $09 constant OTG_HNSSCHG                    \ [0x09] HNSSCHG
    $11 constant OTG_HNGDET                     \ [0x11] HNGDET
    $12 constant OTG_ADTOCHG                    \ [0x12] ADTOCHG
    $13 constant OTG_DBCDNE                     \ [0x13] DBCDNE
    $14 constant OTG_IDCHNG                     \ [0x14] IDCHNG
  [then]


  [ifdef] OTG_OTG_GAHBCFG_DEF
    \
    \ @brief This register can be used to configure the core after power-on or a change in mode. This register mainly contains AHB system-related configuration parameters. Do not change this register after the initial programming. The application must program this register before starting any transactions on either the AHB or the USB.
    \ Address offset: 0x08
    \ Reset value: 0x00000000
    \
    $00 constant OTG_GINTMSK                    \ [0x00] GINTMSK
    $01 constant OTG_HBSTLEN                    \ [0x01 : 4] HBSTLEN
    $05 constant OTG_DMAEN                      \ [0x05] DMAEN
    $07 constant OTG_TXFELVL                    \ [0x07] TXFELVL
    $08 constant OTG_PTXFELVL                   \ [0x08] PTXFELVL
  [then]


  [ifdef] OTG_OTG_GUSBCFG_DEF
    \
    \ @brief This register can be used to configure the core after power-on or a changing to host mode or device mode. It contains USB and USB-PHY related configuration parameters. The application must program this register before starting any transactions on either the AHB or the USB. Do not make changes to this register after the initial programming.
    \ Address offset: 0x0C
    \ Reset value: 0x00001400
    \
    $00 constant OTG_TOCAL                      \ [0x00 : 3] TOCAL
    $06 constant OTG_PHYSEL                     \ [0x06] PHYSEL
    $08 constant OTG_SRPCAP                     \ [0x08] SRPCAP
    $09 constant OTG_HNPCAP                     \ [0x09] HNPCAP
    $0a constant OTG_TRDT                       \ [0x0a : 4] TRDT
    $0f constant OTG_PHYLPC                     \ [0x0f] PHYLPC
    $16 constant OTG_TSDPS                      \ [0x16] TSDPS
    $1d constant OTG_FHMOD                      \ [0x1d] FHMOD
    $1e constant OTG_FDMOD                      \ [0x1e] FDMOD
  [then]


  [ifdef] OTG_OTG_GRSTCTL_DEF
    \
    \ @brief The application uses this register to reset various hardware features inside the core.
    \ Address offset: 0x10
    \ Reset value: 0x80000000
    \
    $00 constant OTG_CSRST                      \ [0x00] CSRST
    $01 constant OTG_PSRST                      \ [0x01] PSRST
    $04 constant OTG_RXFFLSH                    \ [0x04] RXFFLSH
    $05 constant OTG_TXFFLSH                    \ [0x05] TXFFLSH
    $06 constant OTG_TXFNUM                     \ [0x06 : 5] TXFNUM
    $1e constant OTG_DMAREQ                     \ [0x1e] DMAREQ
    $1f constant OTG_AHBIDL                     \ [0x1f] AHBIDL
  [then]


  [ifdef] OTG_OTG_GINTSTS_DEF
    \
    \ @brief This register interrupts the application for system-level events in the current mode (device mode or host mode). Some of the bits in this register are valid only in host mode, while others are valid in device mode only. This register also indicates the current mode. To clear the interrupt status bits of the rc_w1 type, the application must write 1 into the bit. The FIFO status interrupts are read-only; once software reads from or writes to the FIFO while servicing these interrupts, FIFO interrupt conditions are cleared automatically. The application must clear the OTG_GINTSTS register at initialization before unmasking the interrupt bit to avoid any interrupts generated prior to initialization.
    \ Address offset: 0x14
    \ Reset value: 0x14000020
    \
    $00 constant OTG_CMOD                       \ [0x00] CMOD
    $01 constant OTG_MMIS                       \ [0x01] MMIS
    $02 constant OTG_OTGINT                     \ [0x02] OTGINT
    $03 constant OTG_SOF                        \ [0x03] SOF
    $04 constant OTG_RXFLVL                     \ [0x04] RXFLVL
    $05 constant OTG_NPTXFE                     \ [0x05] NPTXFE
    $06 constant OTG_GINAKEFF                   \ [0x06] GINAKEFF
    $07 constant OTG_GONAKEFF                   \ [0x07] GONAKEFF
    $0a constant OTG_ESUSP                      \ [0x0a] ESUSP
    $0b constant OTG_USBSUSP                    \ [0x0b] USBSUSP
    $0c constant OTG_USBRST                     \ [0x0c] USBRST
    $0d constant OTG_ENUMDNE                    \ [0x0d] ENUMDNE
    $0e constant OTG_ISOODRP                    \ [0x0e] ISOODRP
    $0f constant OTG_EOPF                       \ [0x0f] EOPF
    $12 constant OTG_IEPINT                     \ [0x12] IEPINT
    $13 constant OTG_OEPINT                     \ [0x13] OEPINT
    $14 constant OTG_IISOIXFR                   \ [0x14] IISOIXFR
    $15 constant OTG_IPXFR                      \ [0x15] IPXFR
    $16 constant OTG_DATAFSUSP                  \ [0x16] DATAFSUSP
    $18 constant OTG_HPRTINT                    \ [0x18] HPRTINT
    $19 constant OTG_HCINT                      \ [0x19] HCINT
    $1a constant OTG_PTXFE                      \ [0x1a] PTXFE
    $1c constant OTG_CIDSCHG                    \ [0x1c] CIDSCHG
    $1d constant OTG_DISCINT                    \ [0x1d] DISCINT
    $1e constant OTG_SRQINT                     \ [0x1e] SRQINT
    $1f constant OTG_WKUPINT                    \ [0x1f] WKUPINT
  [then]


  [ifdef] OTG_OTG_GINTMSK_DEF
    \
    \ @brief This register works with the core interrupt register to interrupt the application. When an interrupt bit is masked, the interrupt associated with that bit is not generated. However, the core interrupt (OTG_GINTSTS) register bit corresponding to that interrupt is still set.
    \ Address offset: 0x18
    \ Reset value: 0x00000000
    \
    $01 constant OTG_MMISM                      \ [0x01] MMISM
    $02 constant OTG_OTGINT                     \ [0x02] OTGINT
    $03 constant OTG_SOFM                       \ [0x03] SOFM
    $04 constant OTG_RXFLVLM                    \ [0x04] RXFLVLM
    $05 constant OTG_NPTXFEM                    \ [0x05] NPTXFEM
    $06 constant OTG_GINAKEFFM                  \ [0x06] GINAKEFFM
    $07 constant OTG_GONAKEFFM                  \ [0x07] GONAKEFFM
    $0a constant OTG_ESUSPM                     \ [0x0a] ESUSPM
    $0b constant OTG_USBSUSPM                   \ [0x0b] USBSUSPM
    $0c constant OTG_USBRST                     \ [0x0c] USBRST
    $0d constant OTG_ENUMDNEM                   \ [0x0d] ENUMDNEM
    $0e constant OTG_ISOODRPM                   \ [0x0e] ISOODRPM
    $0f constant OTG_EOPFM                      \ [0x0f] EOPFM
    $12 constant OTG_IEPINT                     \ [0x12] IEPINT
    $13 constant OTG_OEPINT                     \ [0x13] OEPINT
    $14 constant OTG_IISOIXFRM                  \ [0x14] IISOIXFRM
    $15 constant OTG_IPXFRM                     \ [0x15] IPXFRM
    $16 constant OTG_FSUSPM                     \ [0x16] FSUSPM
    $17 constant OTG_RSTDETM                    \ [0x17] RSTDETM
    $18 constant OTG_PRTIM                      \ [0x18] PRTIM
    $19 constant OTG_HCIM                       \ [0x19] HCIM
    $1a constant OTG_PTXFEM                     \ [0x1a] PTXFEM
    $1b constant OTG_LPMINTM                    \ [0x1b] LPMINTM
    $1c constant OTG_CIDSCHGM                   \ [0x1c] CIDSCHGM
    $1d constant OTG_DISCINT                    \ [0x1d] DISCINT
    $1e constant OTG_SRQIM                      \ [0x1e] SRQIM
    $1f constant OTG_WUIM                       \ [0x1f] WUIM
  [then]


  [ifdef] OTG_OTG_GRXSTSR_DEF
    \
    \ @brief This description is for register OTG_GRXSTSR in Device mode. A read to the receive status debug read register returns the contents of the top of the receive FIFO. The core ignores the receive status read when the receive FIFO is empty and returns a value of 0x00000000.
    \ Address offset: 0x1C
    \ Reset value: 0x00000000
    \
    $00 constant OTG_EPNUM                      \ [0x00 : 4] EPNUM
    $04 constant OTG_BCNT                       \ [0x04 : 11] BCNT
    $0f constant OTG_DPID                       \ [0x0f : 2] DPID
    $11 constant OTG_PKTSTS                     \ [0x11 : 4] PKTSTS
    $15 constant OTG_FRMNUM                     \ [0x15 : 4] FRMNUM
    $1b constant OTG_STSPHST                    \ [0x1b] STSPHST
  [then]


  [ifdef] OTG_OTG_GRXSTSP_DEF
    \
    \ @brief This description is for register OTG_GRXSTSP in Device mode. Similarly to OTG_GRXSTSR (receive status debug read register) where a read returns the contents of the top of the receive FIFO, a read to OTG_GRXSTSP (receive status read and pop register) additionally pops the top data entry out of the Rx FIFO. The core ignores the receive status pop/read when the receive FIFO is empty and returns a value of 0x00000000. The application must only pop the receive status FIFO when the receive FIFO non-empty bit of the core interrupt register (RXFLVL bit in OTG_GINTSTS) is asserted.
    \ Address offset: 0x20
    \ Reset value: 0x00000000
    \
    $00 constant OTG_EPNUM                      \ [0x00 : 4] EPNUM
    $04 constant OTG_BCNT                       \ [0x04 : 11] BCNT
    $0f constant OTG_DPID                       \ [0x0f : 2] DPID
    $11 constant OTG_PKTSTS                     \ [0x11 : 4] PKTSTS
    $15 constant OTG_FRMNUM                     \ [0x15 : 4] FRMNUM
    $1b constant OTG_STSPHST                    \ [0x1b] STSPHST
  [then]


  [ifdef] OTG_OTG_GRXFSIZ_DEF
    \
    \ @brief The application can program the RAM size that must be allocated to the Rx FIFO.
    \ Address offset: 0x24
    \ Reset value: 0x00000400
    \
    $00 constant OTG_RXFD                       \ [0x00 : 16] RXFD
  [then]


  [ifdef] OTG_OTG_HNPTXFSIZ_DEF
    \
    \ @brief Host mode
    \ Address offset: 0x28
    \ Reset value: 0x02000200
    \
    $00 constant OTG_NPTXFSA                    \ [0x00 : 16] NPTXFSA
    $10 constant OTG_NPTXFD                     \ [0x10 : 16] NPTXFD
  [then]


  [ifdef] OTG_OTG_HNPTXSTS_DEF
    \
    \ @brief In device mode, this register is not valid. This read-only register contains the free space information for the non-periodic Tx FIFO and the non-periodic transmit request queue.
    \ Address offset: 0x2C
    \ Reset value: 0x00080400
    \
    $00 constant OTG_NPTXFSAV                   \ [0x00 : 16] NPTXFSAV
    $10 constant OTG_NPTQXSAV                   \ [0x10 : 8] NPTQXSAV
    $18 constant OTG_NPTXQTOP                   \ [0x18 : 7] NPTXQTOP
  [then]


  [ifdef] OTG_OTG_GCCFG_DEF
    \
    \ @brief OTG general core configuration register
    \ Address offset: 0x38
    \ Reset value: 0x00000000
    \
    $01 constant OTG_PDET                       \ [0x01] PDET
    $02 constant OTG_SDET                       \ [0x02] SDET
    $03 constant OTG_PS2DET                     \ [0x03] PS2DET
    $10 constant OTG_PWRDWN                     \ [0x10] PWRDWN
    $11 constant OTG_BCDEN                      \ [0x11] BCDEN
    $13 constant OTG_PDEN                       \ [0x13] PDEN
    $14 constant OTG_SDEN                       \ [0x14] SDEN
    $15 constant OTG_VBDEN                      \ [0x15] VBDEN
    $16 constant OTG_IDEN                       \ [0x16] IDEN
  [then]


  [ifdef] OTG_OTG_CID_DEF
    \
    \ @brief This is a register containing the Product ID as reset value.
    \ Address offset: 0x3C
    \ Reset value: 0x00004000
    \
    $00 constant OTG_PRODUCT_ID                 \ [0x00 : 32] PRODUCT_ID
  [then]


  [ifdef] OTG_OTG_GLPMCFG_DEF
    \
    \ @brief OTG core LPM configuration register
    \ Address offset: 0x54
    \ Reset value: 0x00000000
    \
    $00 constant OTG_LPMEN                      \ [0x00] LPMEN
    $01 constant OTG_LPMACK                     \ [0x01] LPMACK
    $02 constant OTG_BESL                       \ [0x02 : 4] BESL
    $06 constant OTG_REMWAKE                    \ [0x06] REMWAKE
    $07 constant OTG_L1SSEN                     \ [0x07] L1SSEN
    $08 constant OTG_BESLTHRS                   \ [0x08 : 4] BESLTHRS
    $0c constant OTG_L1DSEN                     \ [0x0c] L1DSEN
    $0d constant OTG_LPMRSP                     \ [0x0d : 2] LPMRSP
    $0f constant OTG_SLPSTS                     \ [0x0f] SLPSTS
    $10 constant OTG_L1RSMOK                    \ [0x10] L1RSMOK
    $11 constant OTG_LPMCHIDX                   \ [0x11 : 4] LPMCHIDX
    $15 constant OTG_LPMRCNT                    \ [0x15 : 3] LPMRCNT
    $18 constant OTG_SNDLPM                     \ [0x18] SNDLPM
    $19 constant OTG_LPMRCNTSTS                 \ [0x19 : 3] LPMRCNTSTS
    $1c constant OTG_ENBESL                     \ [0x1c] ENBESL
  [then]


  [ifdef] OTG_OTG_HPTXFSIZ_DEF
    \
    \ @brief OTG host periodic transmit FIFO size register
    \ Address offset: 0x100
    \ Reset value: 0x02000400
    \
    $00 constant OTG_PTXSA                      \ [0x00 : 16] PTXSA
    $10 constant OTG_PTXFSIZ                    \ [0x10 : 16] PTXFSIZ
  [then]


  [ifdef] OTG_OTG_DIEPTXF1_DEF
    \
    \ @brief OTG device IN endpoint transmit FIFO 1 size register
    \ Address offset: 0x104
    \ Reset value: 0x02000400
    \
    $00 constant OTG_INEPTXSA                   \ [0x00 : 16] INEPTXSA
    $10 constant OTG_INEPTXFD                   \ [0x10 : 16] INEPTXFD
  [then]


  [ifdef] OTG_OTG_DIEPTXF2_DEF
    \
    \ @brief OTG device IN endpoint transmit FIFO 2 size register
    \ Address offset: 0x108
    \ Reset value: 0x02000400
    \
    $00 constant OTG_INEPTXSA                   \ [0x00 : 16] INEPTXSA
    $10 constant OTG_INEPTXFD                   \ [0x10 : 16] INEPTXFD
  [then]


  [ifdef] OTG_OTG_DIEPTXF3_DEF
    \
    \ @brief OTG device IN endpoint transmit FIFO 3 size register
    \ Address offset: 0x10C
    \ Reset value: 0x02000400
    \
    $00 constant OTG_INEPTXSA                   \ [0x00 : 16] INEPTXSA
    $10 constant OTG_INEPTXFD                   \ [0x10 : 16] INEPTXFD
  [then]


  [ifdef] OTG_OTG_DIEPTXF4_DEF
    \
    \ @brief OTG device IN endpoint transmit FIFO 4 size register
    \ Address offset: 0x110
    \ Reset value: 0x02000400
    \
    $00 constant OTG_INEPTXSA                   \ [0x00 : 16] INEPTXSA
    $10 constant OTG_INEPTXFD                   \ [0x10 : 16] INEPTXFD
  [then]


  [ifdef] OTG_OTG_DIEPTXF5_DEF
    \
    \ @brief OTG device IN endpoint transmit FIFO 5 size register
    \ Address offset: 0x114
    \ Reset value: 0x02000400
    \
    $00 constant OTG_INEPTXSA                   \ [0x00 : 16] INEPTXSA
    $10 constant OTG_INEPTXFD                   \ [0x10 : 16] INEPTXFD
  [then]


  [ifdef] OTG_OTG_DIEPTXF6_DEF
    \
    \ @brief OTG device IN endpoint transmit FIFO 6 size register
    \ Address offset: 0x118
    \ Reset value: 0x02000400
    \
    $00 constant OTG_INEPTXSA                   \ [0x00 : 16] INEPTXSA
    $10 constant OTG_INEPTXFD                   \ [0x10 : 16] INEPTXFD
  [then]


  [ifdef] OTG_OTG_DIEPTXF7_DEF
    \
    \ @brief OTG device IN endpoint transmit FIFO 7 size register
    \ Address offset: 0x11C
    \ Reset value: 0x02000400
    \
    $00 constant OTG_INEPTXSA                   \ [0x00 : 16] INEPTXSA
    $10 constant OTG_INEPTXFD                   \ [0x10 : 16] INEPTXFD
  [then]


  [ifdef] OTG_OTG_DIEPTXF8_DEF
    \
    \ @brief OTG device IN endpoint transmit FIFO 8 size register
    \ Address offset: 0x120
    \ Reset value: 0x02000400
    \
    $00 constant OTG_INEPTXSA                   \ [0x00 : 16] INEPTXSA
    $10 constant OTG_INEPTXFD                   \ [0x10 : 16] INEPTXFD
  [then]


  [ifdef] OTG_OTG_HCFG_DEF
    \
    \ @brief This register configures the core after power-on. Do not make changes to this register after initializing the host.
    \ Address offset: 0x400
    \ Reset value: 0x00000000
    \
    $00 constant OTG_FSLSPCS                    \ [0x00 : 2] FSLSPCS
    $02 constant OTG_FSLSS                      \ [0x02] FSLSS
    $17 constant OTG_DESCDMA                    \ [0x17] DESCDMA
    $18 constant OTG_FRLSTEN                    \ [0x18 : 2] FRLSTEN
    $1a constant OTG_PERSSCHEDENA               \ [0x1a] PERSSCHEDENA
  [then]


  [ifdef] OTG_OTG_HFIR_DEF
    \
    \ @brief This register stores the frame interval information for the current speed to which the OTG controller has enumerated.
    \ Address offset: 0x404
    \ Reset value: 0x0000EA60
    \
    $00 constant OTG_FRIVL                      \ [0x00 : 16] FRIVL
    $10 constant OTG_RLDCTRL                    \ [0x10] RLDCTRL
  [then]


  [ifdef] OTG_OTG_HFNUM_DEF
    \
    \ @brief This register indicates the current frame number. It also indicates the time remaining (in terms of the number of PHY clocks) in the current frame.
    \ Address offset: 0x408
    \ Reset value: 0x00003FFF
    \
    $00 constant OTG_FRNUM                      \ [0x00 : 16] FRNUM
    $10 constant OTG_FTREM                      \ [0x10 : 16] FTREM
  [then]


  [ifdef] OTG_OTG_HPTXSTS_DEF
    \
    \ @brief This read-only register contains the free space information for the periodic Tx FIFO and the periodic transmit request queue.
    \ Address offset: 0x410
    \ Reset value: 0x00080100
    \
    $00 constant OTG_PTXFSAVL                   \ [0x00 : 16] PTXFSAVL
    $10 constant OTG_PTXQSAV                    \ [0x10 : 8] PTXQSAV
    $18 constant OTG_PTXQTOP                    \ [0x18 : 8] PTXQTOP
  [then]


  [ifdef] OTG_OTG_HAINT_DEF
    \
    \ @brief When a significant event occurs on a channel, the host all channels interrupt register interrupts the application using the host channels interrupt bit of the core interrupt register (HCINT bit in OTG_GINTSTS). This is shown in Figure724. There is one interrupt bit per channel, up to a maximum of 16 bits. Bits in this register are set and cleared when the application sets and clears bits in the corresponding host channel-x interrupt register.
    \ Address offset: 0x414
    \ Reset value: 0x00000000
    \
    $00 constant OTG_HAINT                      \ [0x00 : 16] HAINT
  [then]


  [ifdef] OTG_OTG_HAINTMSK_DEF
    \
    \ @brief The host all channel interrupt mask register works with the host all channel interrupt register to interrupt the application when an event occurs on a channel. There is one interrupt mask bit per channel, up to a maximum of 16 bits.
    \ Address offset: 0x418
    \ Reset value: 0x00000000
    \
    $00 constant OTG_HAINTM                     \ [0x00 : 16] HAINTM
  [then]


  [ifdef] OTG_OTG_HFLBADDR_DEF
    \
    \ @brief This register holds the starting address of the frame list information (scatter/gather mode).
    \ Address offset: 0x41C
    \ Reset value: 0x00000000
    \
    $00 constant OTG_HFLBADDR                   \ [0x00 : 32] HFLBADDR
  [then]


  [ifdef] OTG_OTG_HPRT_DEF
    \
    \ @brief This register is available only in host mode. Currently, the OTG host supports only one port. A single register holds USB port-related information such as USB reset, enable, suspend, resume, connect status, and test mode for each port. It is shown in Figure724. The rc_w1 bits in this register can trigger an interrupt to the application through the host port interrupt bit of the core interrupt register (HPRTINT bit in OTG_GINTSTS). On a port interrupt, the application must read this register and clear the bit that caused the interrupt. For the rc_w1 bits, the application must write a 1 to the bit to clear the interrupt.
    \ Address offset: 0x440
    \ Reset value: 0x00000000
    \
    $00 constant OTG_PCSTS                      \ [0x00] PCSTS
    $01 constant OTG_PCDET                      \ [0x01] PCDET
    $02 constant OTG_PENA                       \ [0x02] PENA
    $03 constant OTG_PENCHNG                    \ [0x03] PENCHNG
    $04 constant OTG_POCA                       \ [0x04] POCA
    $05 constant OTG_POCCHNG                    \ [0x05] POCCHNG
    $06 constant OTG_PRES                       \ [0x06] PRES
    $07 constant OTG_PSUSP                      \ [0x07] PSUSP
    $08 constant OTG_PRST                       \ [0x08] PRST
    $0a constant OTG_PLSTS                      \ [0x0a : 2] PLSTS
    $0c constant OTG_PPWR                       \ [0x0c] PPWR
    $0d constant OTG_PTCTL                      \ [0x0d : 4] PTCTL
    $11 constant OTG_PSPD                       \ [0x11 : 2] PSPD
  [then]


  [ifdef] OTG_OTG_HCCHAR0_DEF
    \
    \ @brief OTG host channel 0 characteristics register
    \ Address offset: 0x500
    \ Reset value: 0x00000000
    \
    $00 constant OTG_MPSIZ                      \ [0x00 : 11] MPSIZ
    $0b constant OTG_EPNUM                      \ [0x0b : 4] EPNUM
    $0f constant OTG_EPDIR                      \ [0x0f] EPDIR
    $11 constant OTG_LSDEV                      \ [0x11] LSDEV
    $12 constant OTG_EPTYP                      \ [0x12 : 2] EPTYP
    $14 constant OTG_MCNT                       \ [0x14 : 2] MCNT
    $16 constant OTG_DAD                        \ [0x16 : 7] DAD
    $1e constant OTG_CHDIS                      \ [0x1e] CHDIS
    $1f constant OTG_CHENA                      \ [0x1f] CHENA
  [then]


  [ifdef] OTG_OTG_HCSPLT0_DEF
    \
    \ @brief OTG host channel 0 split control register
    \ Address offset: 0x504
    \ Reset value: 0x00000000
    \
    $00 constant OTG_PRTADDR                    \ [0x00 : 7] PRTADDR
    $07 constant OTG_HUBADDR                    \ [0x07 : 7] HUBADDR
    $0e constant OTG_XACTPOS                    \ [0x0e : 2] XACTPOS
    $10 constant OTG_COMPLSPLT                  \ [0x10] COMPLSPLT
    $1f constant OTG_SPLITEN                    \ [0x1f] SPLITEN
  [then]


  [ifdef] OTG_OTG_HCINT0_DEF
    \
    \ @brief This register indicates the status of a channel with respect to USB- and AHB-related events. It is shown in Figure724. The application must read this register when the host channels interrupt bit in the core interrupt register (HCINT bit in OTG_GINTSTS) is set. Before the application can read this register, it must first read the host all channels interrupt (OTG_HAINT) register to get the exact channel number for the host channel-x interrupt register. The application must clear the appropriate bit in this register to clear the corresponding bits in the OTG_HAINT and OTG_GINTSTS registers.
    \ Address offset: 0x508
    \ Reset value: 0x00000000
    \
    $00 constant OTG_XFRC                       \ [0x00] XFRC
    $01 constant OTG_CHH                        \ [0x01] CHH
    $02 constant OTG_AHBERR                     \ [0x02] AHBERR
    $03 constant OTG_STALL                      \ [0x03] STALL
    $04 constant OTG_NAK                        \ [0x04] NAK
    $05 constant OTG_ACK                        \ [0x05] ACK
    $06 constant OTG_NYET                       \ [0x06] NYET
    $07 constant OTG_TXERR                      \ [0x07] TXERR
    $08 constant OTG_BBERR                      \ [0x08] BBERR
    $09 constant OTG_FRMOR                      \ [0x09] FRMOR
    $0a constant OTG_DTERR                      \ [0x0a] DTERR
    $0b constant OTG_BNA                        \ [0x0b] BNA
    $0c constant OTG_XCSXACTERR                 \ [0x0c] XCSXACTERR
    $0d constant OTG_DESCLSTROLL                \ [0x0d] DESCLSTROLL
  [then]


  [ifdef] OTG_OTG_HCINTMSK0_DEF
    \
    \ @brief This register reflects the mask for each channel status described in the previous section.
    \ Address offset: 0x50C
    \ Reset value: 0x00000000
    \
    $00 constant OTG_XFRCM                      \ [0x00] XFRCM
    $01 constant OTG_CHHM                       \ [0x01] CHHM
    $02 constant OTG_AHBERRM                    \ [0x02] AHBERRM
    $03 constant OTG_STALLM                     \ [0x03] STALLM
    $04 constant OTG_NAKM                       \ [0x04] NAKM
    $05 constant OTG_ACKM                       \ [0x05] ACKM
    $06 constant OTG_NYET                       \ [0x06] NYET
    $07 constant OTG_TXERRM                     \ [0x07] TXERRM
    $08 constant OTG_BBERRM                     \ [0x08] BBERRM
    $09 constant OTG_FRMORM                     \ [0x09] FRMORM
    $0a constant OTG_DTERRM                     \ [0x0a] DTERRM
    $0b constant OTG_BNAMSK                     \ [0x0b] BNAMSK
    $0d constant OTG_DESCLSTROLLMSK             \ [0x0d] DESCLSTROLLMSK
  [then]


  [ifdef] OTG_OTG_HCTSIZ0_DEF
    \
    \ @brief OTG host channel 0 transfer size register
    \ Address offset: 0x510
    \ Reset value: 0x00000000
    \
    $00 constant OTG_XFRSIZ                     \ [0x00 : 19] XFRSIZ
    $13 constant OTG_PKTCNT                     \ [0x13 : 10] PKTCNT
    $1d constant OTG_DPID                       \ [0x1d : 2] DPID
  [then]


  [ifdef] OTG_OTG_HCDMA0_DEF
    \
    \ @brief OTG host channel 0 DMA address register in buffer DMA [alternate]
    \ Address offset: 0x514
    \ Reset value: 0x00000000
    \
    $00 constant OTG_DMAADDR                    \ [0x00 : 32] DMAADDR
  [then]


  [ifdef] OTG_OTG_HCDMAB0_DEF
    \
    \ @brief OTG host channel-n DMA address buffer register
    \ Address offset: 0x51C
    \ Reset value: 0x00000000
    \
    $00 constant OTG_HCDMAB                     \ [0x00 : 32] HCDMAB
  [then]


  [ifdef] OTG_OTG_HCCHAR1_DEF
    \
    \ @brief OTG host channel 1 characteristics register
    \ Address offset: 0x520
    \ Reset value: 0x00000000
    \
    $00 constant OTG_MPSIZ                      \ [0x00 : 11] MPSIZ
    $0b constant OTG_EPNUM                      \ [0x0b : 4] EPNUM
    $0f constant OTG_EPDIR                      \ [0x0f] EPDIR
    $11 constant OTG_LSDEV                      \ [0x11] LSDEV
    $12 constant OTG_EPTYP                      \ [0x12 : 2] EPTYP
    $14 constant OTG_MCNT                       \ [0x14 : 2] MCNT
    $16 constant OTG_DAD                        \ [0x16 : 7] DAD
    $1e constant OTG_CHDIS                      \ [0x1e] CHDIS
    $1f constant OTG_CHENA                      \ [0x1f] CHENA
  [then]


  [ifdef] OTG_OTG_HCSPLT1_DEF
    \
    \ @brief OTG host channel 1 split control register
    \ Address offset: 0x524
    \ Reset value: 0x00000000
    \
    $00 constant OTG_PRTADDR                    \ [0x00 : 7] PRTADDR
    $07 constant OTG_HUBADDR                    \ [0x07 : 7] HUBADDR
    $0e constant OTG_XACTPOS                    \ [0x0e : 2] XACTPOS
    $10 constant OTG_COMPLSPLT                  \ [0x10] COMPLSPLT
    $1f constant OTG_SPLITEN                    \ [0x1f] SPLITEN
  [then]


  [ifdef] OTG_OTG_HCINT1_DEF
    \
    \ @brief This register indicates the status of a channel with respect to USB- and AHB-related events. It is shown in Figure724. The application must read this register when the host channels interrupt bit in the core interrupt register (HCINT bit in OTG_GINTSTS) is set. Before the application can read this register, it must first read the host all channels interrupt (OTG_HAINT) register to get the exact channel number for the host channel-x interrupt register. The application must clear the appropriate bit in this register to clear the corresponding bits in the OTG_HAINT and OTG_GINTSTS registers.
    \ Address offset: 0x528
    \ Reset value: 0x00000000
    \
    $00 constant OTG_XFRC                       \ [0x00] XFRC
    $01 constant OTG_CHH                        \ [0x01] CHH
    $02 constant OTG_AHBERR                     \ [0x02] AHBERR
    $03 constant OTG_STALL                      \ [0x03] STALL
    $04 constant OTG_NAK                        \ [0x04] NAK
    $05 constant OTG_ACK                        \ [0x05] ACK
    $06 constant OTG_NYET                       \ [0x06] NYET
    $07 constant OTG_TXERR                      \ [0x07] TXERR
    $08 constant OTG_BBERR                      \ [0x08] BBERR
    $09 constant OTG_FRMOR                      \ [0x09] FRMOR
    $0a constant OTG_DTERR                      \ [0x0a] DTERR
    $0b constant OTG_BNA                        \ [0x0b] BNA
    $0c constant OTG_XCSXACTERR                 \ [0x0c] XCSXACTERR
    $0d constant OTG_DESCLSTROLL                \ [0x0d] DESCLSTROLL
  [then]


  [ifdef] OTG_OTG_HCINTMSK1_DEF
    \
    \ @brief This register reflects the mask for each channel status described in the previous section.
    \ Address offset: 0x52C
    \ Reset value: 0x00000000
    \
    $00 constant OTG_XFRCM                      \ [0x00] XFRCM
    $01 constant OTG_CHHM                       \ [0x01] CHHM
    $02 constant OTG_AHBERRM                    \ [0x02] AHBERRM
    $03 constant OTG_STALLM                     \ [0x03] STALLM
    $04 constant OTG_NAKM                       \ [0x04] NAKM
    $05 constant OTG_ACKM                       \ [0x05] ACKM
    $06 constant OTG_NYET                       \ [0x06] NYET
    $07 constant OTG_TXERRM                     \ [0x07] TXERRM
    $08 constant OTG_BBERRM                     \ [0x08] BBERRM
    $09 constant OTG_FRMORM                     \ [0x09] FRMORM
    $0a constant OTG_DTERRM                     \ [0x0a] DTERRM
    $0b constant OTG_BNAMSK                     \ [0x0b] BNAMSK
    $0d constant OTG_DESCLSTROLLMSK             \ [0x0d] DESCLSTROLLMSK
  [then]


  [ifdef] OTG_OTG_HCTSIZ1_DEF
    \
    \ @brief OTG host channel 1 transfer size register
    \ Address offset: 0x530
    \ Reset value: 0x00000000
    \
    $00 constant OTG_XFRSIZ                     \ [0x00 : 19] XFRSIZ
    $13 constant OTG_PKTCNT                     \ [0x13 : 10] PKTCNT
    $1d constant OTG_DPID                       \ [0x1d : 2] DPID
  [then]


  [ifdef] OTG_OTG_HCDMA1_DEF
    \
    \ @brief OTG host channel 1 DMA address register in buffer DMA [alternate]
    \ Address offset: 0x534
    \ Reset value: 0x00000000
    \
    $00 constant OTG_DMAADDR                    \ [0x00 : 32] DMAADDR
  [then]


  [ifdef] OTG_OTG_HCDMAB1_DEF
    \
    \ @brief OTG host channel-n DMA address buffer register
    \ Address offset: 0x53C
    \ Reset value: 0x00000000
    \
    $00 constant OTG_HCDMAB                     \ [0x00 : 32] HCDMAB
  [then]


  [ifdef] OTG_OTG_HCCHAR2_DEF
    \
    \ @brief OTG host channel 2 characteristics register
    \ Address offset: 0x540
    \ Reset value: 0x00000000
    \
    $00 constant OTG_MPSIZ                      \ [0x00 : 11] MPSIZ
    $0b constant OTG_EPNUM                      \ [0x0b : 4] EPNUM
    $0f constant OTG_EPDIR                      \ [0x0f] EPDIR
    $11 constant OTG_LSDEV                      \ [0x11] LSDEV
    $12 constant OTG_EPTYP                      \ [0x12 : 2] EPTYP
    $14 constant OTG_MCNT                       \ [0x14 : 2] MCNT
    $16 constant OTG_DAD                        \ [0x16 : 7] DAD
    $1e constant OTG_CHDIS                      \ [0x1e] CHDIS
    $1f constant OTG_CHENA                      \ [0x1f] CHENA
  [then]


  [ifdef] OTG_OTG_HCSPLT2_DEF
    \
    \ @brief OTG host channel 2 split control register
    \ Address offset: 0x544
    \ Reset value: 0x00000000
    \
    $00 constant OTG_PRTADDR                    \ [0x00 : 7] PRTADDR
    $07 constant OTG_HUBADDR                    \ [0x07 : 7] HUBADDR
    $0e constant OTG_XACTPOS                    \ [0x0e : 2] XACTPOS
    $10 constant OTG_COMPLSPLT                  \ [0x10] COMPLSPLT
    $1f constant OTG_SPLITEN                    \ [0x1f] SPLITEN
  [then]


  [ifdef] OTG_OTG_HCINT2_DEF
    \
    \ @brief This register indicates the status of a channel with respect to USB- and AHB-related events. It is shown in Figure724. The application must read this register when the host channels interrupt bit in the core interrupt register (HCINT bit in OTG_GINTSTS) is set. Before the application can read this register, it must first read the host all channels interrupt (OTG_HAINT) register to get the exact channel number for the host channel-x interrupt register. The application must clear the appropriate bit in this register to clear the corresponding bits in the OTG_HAINT and OTG_GINTSTS registers.
    \ Address offset: 0x548
    \ Reset value: 0x00000000
    \
    $00 constant OTG_XFRC                       \ [0x00] XFRC
    $01 constant OTG_CHH                        \ [0x01] CHH
    $02 constant OTG_AHBERR                     \ [0x02] AHBERR
    $03 constant OTG_STALL                      \ [0x03] STALL
    $04 constant OTG_NAK                        \ [0x04] NAK
    $05 constant OTG_ACK                        \ [0x05] ACK
    $06 constant OTG_NYET                       \ [0x06] NYET
    $07 constant OTG_TXERR                      \ [0x07] TXERR
    $08 constant OTG_BBERR                      \ [0x08] BBERR
    $09 constant OTG_FRMOR                      \ [0x09] FRMOR
    $0a constant OTG_DTERR                      \ [0x0a] DTERR
    $0b constant OTG_BNA                        \ [0x0b] BNA
    $0c constant OTG_XCSXACTERR                 \ [0x0c] XCSXACTERR
    $0d constant OTG_DESCLSTROLL                \ [0x0d] DESCLSTROLL
  [then]


  [ifdef] OTG_OTG_HCINTMSK2_DEF
    \
    \ @brief This register reflects the mask for each channel status described in the previous section.
    \ Address offset: 0x54C
    \ Reset value: 0x00000000
    \
    $00 constant OTG_XFRCM                      \ [0x00] XFRCM
    $01 constant OTG_CHHM                       \ [0x01] CHHM
    $02 constant OTG_AHBERRM                    \ [0x02] AHBERRM
    $03 constant OTG_STALLM                     \ [0x03] STALLM
    $04 constant OTG_NAKM                       \ [0x04] NAKM
    $05 constant OTG_ACKM                       \ [0x05] ACKM
    $06 constant OTG_NYET                       \ [0x06] NYET
    $07 constant OTG_TXERRM                     \ [0x07] TXERRM
    $08 constant OTG_BBERRM                     \ [0x08] BBERRM
    $09 constant OTG_FRMORM                     \ [0x09] FRMORM
    $0a constant OTG_DTERRM                     \ [0x0a] DTERRM
    $0b constant OTG_BNAMSK                     \ [0x0b] BNAMSK
    $0d constant OTG_DESCLSTROLLMSK             \ [0x0d] DESCLSTROLLMSK
  [then]


  [ifdef] OTG_OTG_HCTSIZ2_DEF
    \
    \ @brief OTG host channel 2 transfer size register
    \ Address offset: 0x550
    \ Reset value: 0x00000000
    \
    $00 constant OTG_XFRSIZ                     \ [0x00 : 19] XFRSIZ
    $13 constant OTG_PKTCNT                     \ [0x13 : 10] PKTCNT
    $1d constant OTG_DPID                       \ [0x1d : 2] DPID
  [then]


  [ifdef] OTG_OTG_HCDMA2_DEF
    \
    \ @brief OTG host channel 2 DMA address register in buffer DMA [alternate]
    \ Address offset: 0x554
    \ Reset value: 0x00000000
    \
    $00 constant OTG_DMAADDR                    \ [0x00 : 32] DMAADDR
  [then]


  [ifdef] OTG_OTG_HCDMAB2_DEF
    \
    \ @brief OTG host channel-n DMA address buffer register
    \ Address offset: 0x55C
    \ Reset value: 0x00000000
    \
    $00 constant OTG_HCDMAB                     \ [0x00 : 32] HCDMAB
  [then]


  [ifdef] OTG_OTG_HCCHAR3_DEF
    \
    \ @brief OTG host channel 3 characteristics register
    \ Address offset: 0x560
    \ Reset value: 0x00000000
    \
    $00 constant OTG_MPSIZ                      \ [0x00 : 11] MPSIZ
    $0b constant OTG_EPNUM                      \ [0x0b : 4] EPNUM
    $0f constant OTG_EPDIR                      \ [0x0f] EPDIR
    $11 constant OTG_LSDEV                      \ [0x11] LSDEV
    $12 constant OTG_EPTYP                      \ [0x12 : 2] EPTYP
    $14 constant OTG_MCNT                       \ [0x14 : 2] MCNT
    $16 constant OTG_DAD                        \ [0x16 : 7] DAD
    $1e constant OTG_CHDIS                      \ [0x1e] CHDIS
    $1f constant OTG_CHENA                      \ [0x1f] CHENA
  [then]


  [ifdef] OTG_OTG_HCSPLT3_DEF
    \
    \ @brief OTG host channel 3 split control register
    \ Address offset: 0x564
    \ Reset value: 0x00000000
    \
    $00 constant OTG_PRTADDR                    \ [0x00 : 7] PRTADDR
    $07 constant OTG_HUBADDR                    \ [0x07 : 7] HUBADDR
    $0e constant OTG_XACTPOS                    \ [0x0e : 2] XACTPOS
    $10 constant OTG_COMPLSPLT                  \ [0x10] COMPLSPLT
    $1f constant OTG_SPLITEN                    \ [0x1f] SPLITEN
  [then]


  [ifdef] OTG_OTG_HCINT3_DEF
    \
    \ @brief This register indicates the status of a channel with respect to USB- and AHB-related events. It is shown in Figure724. The application must read this register when the host channels interrupt bit in the core interrupt register (HCINT bit in OTG_GINTSTS) is set. Before the application can read this register, it must first read the host all channels interrupt (OTG_HAINT) register to get the exact channel number for the host channel-x interrupt register. The application must clear the appropriate bit in this register to clear the corresponding bits in the OTG_HAINT and OTG_GINTSTS registers.
    \ Address offset: 0x568
    \ Reset value: 0x00000000
    \
    $00 constant OTG_XFRC                       \ [0x00] XFRC
    $01 constant OTG_CHH                        \ [0x01] CHH
    $02 constant OTG_AHBERR                     \ [0x02] AHBERR
    $03 constant OTG_STALL                      \ [0x03] STALL
    $04 constant OTG_NAK                        \ [0x04] NAK
    $05 constant OTG_ACK                        \ [0x05] ACK
    $06 constant OTG_NYET                       \ [0x06] NYET
    $07 constant OTG_TXERR                      \ [0x07] TXERR
    $08 constant OTG_BBERR                      \ [0x08] BBERR
    $09 constant OTG_FRMOR                      \ [0x09] FRMOR
    $0a constant OTG_DTERR                      \ [0x0a] DTERR
    $0b constant OTG_BNA                        \ [0x0b] BNA
    $0c constant OTG_XCSXACTERR                 \ [0x0c] XCSXACTERR
    $0d constant OTG_DESCLSTROLL                \ [0x0d] DESCLSTROLL
  [then]


  [ifdef] OTG_OTG_HCINTMSK3_DEF
    \
    \ @brief This register reflects the mask for each channel status described in the previous section.
    \ Address offset: 0x56C
    \ Reset value: 0x00000000
    \
    $00 constant OTG_XFRCM                      \ [0x00] XFRCM
    $01 constant OTG_CHHM                       \ [0x01] CHHM
    $02 constant OTG_AHBERRM                    \ [0x02] AHBERRM
    $03 constant OTG_STALLM                     \ [0x03] STALLM
    $04 constant OTG_NAKM                       \ [0x04] NAKM
    $05 constant OTG_ACKM                       \ [0x05] ACKM
    $06 constant OTG_NYET                       \ [0x06] NYET
    $07 constant OTG_TXERRM                     \ [0x07] TXERRM
    $08 constant OTG_BBERRM                     \ [0x08] BBERRM
    $09 constant OTG_FRMORM                     \ [0x09] FRMORM
    $0a constant OTG_DTERRM                     \ [0x0a] DTERRM
    $0b constant OTG_BNAMSK                     \ [0x0b] BNAMSK
    $0d constant OTG_DESCLSTROLLMSK             \ [0x0d] DESCLSTROLLMSK
  [then]


  [ifdef] OTG_OTG_HCTSIZ3_DEF
    \
    \ @brief OTG host channel 3 transfer size register
    \ Address offset: 0x570
    \ Reset value: 0x00000000
    \
    $00 constant OTG_XFRSIZ                     \ [0x00 : 19] XFRSIZ
    $13 constant OTG_PKTCNT                     \ [0x13 : 10] PKTCNT
    $1d constant OTG_DPID                       \ [0x1d : 2] DPID
  [then]


  [ifdef] OTG_OTG_HCDMA3_DEF
    \
    \ @brief OTG host channel 3 DMA address register in buffer DMA [alternate]
    \ Address offset: 0x574
    \ Reset value: 0x00000000
    \
    $00 constant OTG_DMAADDR                    \ [0x00 : 32] DMAADDR
  [then]


  [ifdef] OTG_OTG_HCDMAB3_DEF
    \
    \ @brief OTG host channel-n DMA address buffer register
    \ Address offset: 0x57C
    \ Reset value: 0x00000000
    \
    $00 constant OTG_HCDMAB                     \ [0x00 : 32] HCDMAB
  [then]


  [ifdef] OTG_OTG_HCCHAR4_DEF
    \
    \ @brief OTG host channel 4 characteristics register
    \ Address offset: 0x580
    \ Reset value: 0x00000000
    \
    $00 constant OTG_MPSIZ                      \ [0x00 : 11] MPSIZ
    $0b constant OTG_EPNUM                      \ [0x0b : 4] EPNUM
    $0f constant OTG_EPDIR                      \ [0x0f] EPDIR
    $11 constant OTG_LSDEV                      \ [0x11] LSDEV
    $12 constant OTG_EPTYP                      \ [0x12 : 2] EPTYP
    $14 constant OTG_MCNT                       \ [0x14 : 2] MCNT
    $16 constant OTG_DAD                        \ [0x16 : 7] DAD
    $1e constant OTG_CHDIS                      \ [0x1e] CHDIS
    $1f constant OTG_CHENA                      \ [0x1f] CHENA
  [then]


  [ifdef] OTG_OTG_HCSPLT4_DEF
    \
    \ @brief OTG host channel 4 split control register
    \ Address offset: 0x584
    \ Reset value: 0x00000000
    \
    $00 constant OTG_PRTADDR                    \ [0x00 : 7] PRTADDR
    $07 constant OTG_HUBADDR                    \ [0x07 : 7] HUBADDR
    $0e constant OTG_XACTPOS                    \ [0x0e : 2] XACTPOS
    $10 constant OTG_COMPLSPLT                  \ [0x10] COMPLSPLT
    $1f constant OTG_SPLITEN                    \ [0x1f] SPLITEN
  [then]


  [ifdef] OTG_OTG_HCINT4_DEF
    \
    \ @brief This register indicates the status of a channel with respect to USB- and AHB-related events. It is shown in Figure724. The application must read this register when the host channels interrupt bit in the core interrupt register (HCINT bit in OTG_GINTSTS) is set. Before the application can read this register, it must first read the host all channels interrupt (OTG_HAINT) register to get the exact channel number for the host channel-x interrupt register. The application must clear the appropriate bit in this register to clear the corresponding bits in the OTG_HAINT and OTG_GINTSTS registers.
    \ Address offset: 0x588
    \ Reset value: 0x00000000
    \
    $00 constant OTG_XFRC                       \ [0x00] XFRC
    $01 constant OTG_CHH                        \ [0x01] CHH
    $02 constant OTG_AHBERR                     \ [0x02] AHBERR
    $03 constant OTG_STALL                      \ [0x03] STALL
    $04 constant OTG_NAK                        \ [0x04] NAK
    $05 constant OTG_ACK                        \ [0x05] ACK
    $06 constant OTG_NYET                       \ [0x06] NYET
    $07 constant OTG_TXERR                      \ [0x07] TXERR
    $08 constant OTG_BBERR                      \ [0x08] BBERR
    $09 constant OTG_FRMOR                      \ [0x09] FRMOR
    $0a constant OTG_DTERR                      \ [0x0a] DTERR
    $0b constant OTG_BNA                        \ [0x0b] BNA
    $0c constant OTG_XCSXACTERR                 \ [0x0c] XCSXACTERR
    $0d constant OTG_DESCLSTROLL                \ [0x0d] DESCLSTROLL
  [then]


  [ifdef] OTG_OTG_HCINTMSK4_DEF
    \
    \ @brief This register reflects the mask for each channel status described in the previous section.
    \ Address offset: 0x58C
    \ Reset value: 0x00000000
    \
    $00 constant OTG_XFRCM                      \ [0x00] XFRCM
    $01 constant OTG_CHHM                       \ [0x01] CHHM
    $02 constant OTG_AHBERRM                    \ [0x02] AHBERRM
    $03 constant OTG_STALLM                     \ [0x03] STALLM
    $04 constant OTG_NAKM                       \ [0x04] NAKM
    $05 constant OTG_ACKM                       \ [0x05] ACKM
    $06 constant OTG_NYET                       \ [0x06] NYET
    $07 constant OTG_TXERRM                     \ [0x07] TXERRM
    $08 constant OTG_BBERRM                     \ [0x08] BBERRM
    $09 constant OTG_FRMORM                     \ [0x09] FRMORM
    $0a constant OTG_DTERRM                     \ [0x0a] DTERRM
    $0b constant OTG_BNAMSK                     \ [0x0b] BNAMSK
    $0d constant OTG_DESCLSTROLLMSK             \ [0x0d] DESCLSTROLLMSK
  [then]


  [ifdef] OTG_OTG_HCTSIZ4_DEF
    \
    \ @brief OTG host channel 4 transfer size register
    \ Address offset: 0x590
    \ Reset value: 0x00000000
    \
    $00 constant OTG_XFRSIZ                     \ [0x00 : 19] XFRSIZ
    $13 constant OTG_PKTCNT                     \ [0x13 : 10] PKTCNT
    $1d constant OTG_DPID                       \ [0x1d : 2] DPID
  [then]


  [ifdef] OTG_OTG_HCDMA4_DEF
    \
    \ @brief OTG host channel 4 DMA address register in buffer DMA [alternate]
    \ Address offset: 0x594
    \ Reset value: 0x00000000
    \
    $00 constant OTG_DMAADDR                    \ [0x00 : 32] DMAADDR
  [then]


  [ifdef] OTG_OTG_HCDMAB4_DEF
    \
    \ @brief OTG host channel-n DMA address buffer register
    \ Address offset: 0x59C
    \ Reset value: 0x00000000
    \
    $00 constant OTG_HCDMAB                     \ [0x00 : 32] HCDMAB
  [then]


  [ifdef] OTG_OTG_HCCHAR5_DEF
    \
    \ @brief OTG host channel 5 characteristics register
    \ Address offset: 0x5A0
    \ Reset value: 0x00000000
    \
    $00 constant OTG_MPSIZ                      \ [0x00 : 11] MPSIZ
    $0b constant OTG_EPNUM                      \ [0x0b : 4] EPNUM
    $0f constant OTG_EPDIR                      \ [0x0f] EPDIR
    $11 constant OTG_LSDEV                      \ [0x11] LSDEV
    $12 constant OTG_EPTYP                      \ [0x12 : 2] EPTYP
    $14 constant OTG_MCNT                       \ [0x14 : 2] MCNT
    $16 constant OTG_DAD                        \ [0x16 : 7] DAD
    $1e constant OTG_CHDIS                      \ [0x1e] CHDIS
    $1f constant OTG_CHENA                      \ [0x1f] CHENA
  [then]


  [ifdef] OTG_OTG_HCSPLT5_DEF
    \
    \ @brief OTG host channel 5 split control register
    \ Address offset: 0x5A4
    \ Reset value: 0x00000000
    \
    $00 constant OTG_PRTADDR                    \ [0x00 : 7] PRTADDR
    $07 constant OTG_HUBADDR                    \ [0x07 : 7] HUBADDR
    $0e constant OTG_XACTPOS                    \ [0x0e : 2] XACTPOS
    $10 constant OTG_COMPLSPLT                  \ [0x10] COMPLSPLT
    $1f constant OTG_SPLITEN                    \ [0x1f] SPLITEN
  [then]


  [ifdef] OTG_OTG_HCINT5_DEF
    \
    \ @brief This register indicates the status of a channel with respect to USB- and AHB-related events. It is shown in Figure724. The application must read this register when the host channels interrupt bit in the core interrupt register (HCINT bit in OTG_GINTSTS) is set. Before the application can read this register, it must first read the host all channels interrupt (OTG_HAINT) register to get the exact channel number for the host channel-x interrupt register. The application must clear the appropriate bit in this register to clear the corresponding bits in the OTG_HAINT and OTG_GINTSTS registers.
    \ Address offset: 0x5A8
    \ Reset value: 0x00000000
    \
    $00 constant OTG_XFRC                       \ [0x00] XFRC
    $01 constant OTG_CHH                        \ [0x01] CHH
    $02 constant OTG_AHBERR                     \ [0x02] AHBERR
    $03 constant OTG_STALL                      \ [0x03] STALL
    $04 constant OTG_NAK                        \ [0x04] NAK
    $05 constant OTG_ACK                        \ [0x05] ACK
    $06 constant OTG_NYET                       \ [0x06] NYET
    $07 constant OTG_TXERR                      \ [0x07] TXERR
    $08 constant OTG_BBERR                      \ [0x08] BBERR
    $09 constant OTG_FRMOR                      \ [0x09] FRMOR
    $0a constant OTG_DTERR                      \ [0x0a] DTERR
    $0b constant OTG_BNA                        \ [0x0b] BNA
    $0c constant OTG_XCSXACTERR                 \ [0x0c] XCSXACTERR
    $0d constant OTG_DESCLSTROLL                \ [0x0d] DESCLSTROLL
  [then]


  [ifdef] OTG_OTG_HCINTMSK5_DEF
    \
    \ @brief This register reflects the mask for each channel status described in the previous section.
    \ Address offset: 0x5AC
    \ Reset value: 0x00000000
    \
    $00 constant OTG_XFRCM                      \ [0x00] XFRCM
    $01 constant OTG_CHHM                       \ [0x01] CHHM
    $02 constant OTG_AHBERRM                    \ [0x02] AHBERRM
    $03 constant OTG_STALLM                     \ [0x03] STALLM
    $04 constant OTG_NAKM                       \ [0x04] NAKM
    $05 constant OTG_ACKM                       \ [0x05] ACKM
    $06 constant OTG_NYET                       \ [0x06] NYET
    $07 constant OTG_TXERRM                     \ [0x07] TXERRM
    $08 constant OTG_BBERRM                     \ [0x08] BBERRM
    $09 constant OTG_FRMORM                     \ [0x09] FRMORM
    $0a constant OTG_DTERRM                     \ [0x0a] DTERRM
    $0b constant OTG_BNAMSK                     \ [0x0b] BNAMSK
    $0d constant OTG_DESCLSTROLLMSK             \ [0x0d] DESCLSTROLLMSK
  [then]


  [ifdef] OTG_OTG_HCTSIZ5_DEF
    \
    \ @brief OTG host channel 5 transfer size register
    \ Address offset: 0x5B0
    \ Reset value: 0x00000000
    \
    $00 constant OTG_XFRSIZ                     \ [0x00 : 19] XFRSIZ
    $13 constant OTG_PKTCNT                     \ [0x13 : 10] PKTCNT
    $1d constant OTG_DPID                       \ [0x1d : 2] DPID
  [then]


  [ifdef] OTG_OTG_HCDMA5_DEF
    \
    \ @brief OTG host channel 5 DMA address register in buffer DMA [alternate]
    \ Address offset: 0x5B4
    \ Reset value: 0x00000000
    \
    $00 constant OTG_DMAADDR                    \ [0x00 : 32] DMAADDR
  [then]


  [ifdef] OTG_OTG_HCDMAB5_DEF
    \
    \ @brief OTG host channel-n DMA address buffer register
    \ Address offset: 0x5BC
    \ Reset value: 0x00000000
    \
    $00 constant OTG_HCDMAB                     \ [0x00 : 32] HCDMAB
  [then]


  [ifdef] OTG_OTG_HCCHAR6_DEF
    \
    \ @brief OTG host channel 6 characteristics register
    \ Address offset: 0x5C0
    \ Reset value: 0x00000000
    \
    $00 constant OTG_MPSIZ                      \ [0x00 : 11] MPSIZ
    $0b constant OTG_EPNUM                      \ [0x0b : 4] EPNUM
    $0f constant OTG_EPDIR                      \ [0x0f] EPDIR
    $11 constant OTG_LSDEV                      \ [0x11] LSDEV
    $12 constant OTG_EPTYP                      \ [0x12 : 2] EPTYP
    $14 constant OTG_MCNT                       \ [0x14 : 2] MCNT
    $16 constant OTG_DAD                        \ [0x16 : 7] DAD
    $1e constant OTG_CHDIS                      \ [0x1e] CHDIS
    $1f constant OTG_CHENA                      \ [0x1f] CHENA
  [then]


  [ifdef] OTG_OTG_HCSPLT6_DEF
    \
    \ @brief OTG host channel 6 split control register
    \ Address offset: 0x5C4
    \ Reset value: 0x00000000
    \
    $00 constant OTG_PRTADDR                    \ [0x00 : 7] PRTADDR
    $07 constant OTG_HUBADDR                    \ [0x07 : 7] HUBADDR
    $0e constant OTG_XACTPOS                    \ [0x0e : 2] XACTPOS
    $10 constant OTG_COMPLSPLT                  \ [0x10] COMPLSPLT
    $1f constant OTG_SPLITEN                    \ [0x1f] SPLITEN
  [then]


  [ifdef] OTG_OTG_HCINT6_DEF
    \
    \ @brief This register indicates the status of a channel with respect to USB- and AHB-related events. It is shown in Figure724. The application must read this register when the host channels interrupt bit in the core interrupt register (HCINT bit in OTG_GINTSTS) is set. Before the application can read this register, it must first read the host all channels interrupt (OTG_HAINT) register to get the exact channel number for the host channel-x interrupt register. The application must clear the appropriate bit in this register to clear the corresponding bits in the OTG_HAINT and OTG_GINTSTS registers.
    \ Address offset: 0x5C8
    \ Reset value: 0x00000000
    \
    $00 constant OTG_XFRC                       \ [0x00] XFRC
    $01 constant OTG_CHH                        \ [0x01] CHH
    $02 constant OTG_AHBERR                     \ [0x02] AHBERR
    $03 constant OTG_STALL                      \ [0x03] STALL
    $04 constant OTG_NAK                        \ [0x04] NAK
    $05 constant OTG_ACK                        \ [0x05] ACK
    $06 constant OTG_NYET                       \ [0x06] NYET
    $07 constant OTG_TXERR                      \ [0x07] TXERR
    $08 constant OTG_BBERR                      \ [0x08] BBERR
    $09 constant OTG_FRMOR                      \ [0x09] FRMOR
    $0a constant OTG_DTERR                      \ [0x0a] DTERR
    $0b constant OTG_BNA                        \ [0x0b] BNA
    $0c constant OTG_XCSXACTERR                 \ [0x0c] XCSXACTERR
    $0d constant OTG_DESCLSTROLL                \ [0x0d] DESCLSTROLL
  [then]


  [ifdef] OTG_OTG_HCINTMSK6_DEF
    \
    \ @brief This register reflects the mask for each channel status described in the previous section.
    \ Address offset: 0x5CC
    \ Reset value: 0x00000000
    \
    $00 constant OTG_XFRCM                      \ [0x00] XFRCM
    $01 constant OTG_CHHM                       \ [0x01] CHHM
    $02 constant OTG_AHBERRM                    \ [0x02] AHBERRM
    $03 constant OTG_STALLM                     \ [0x03] STALLM
    $04 constant OTG_NAKM                       \ [0x04] NAKM
    $05 constant OTG_ACKM                       \ [0x05] ACKM
    $06 constant OTG_NYET                       \ [0x06] NYET
    $07 constant OTG_TXERRM                     \ [0x07] TXERRM
    $08 constant OTG_BBERRM                     \ [0x08] BBERRM
    $09 constant OTG_FRMORM                     \ [0x09] FRMORM
    $0a constant OTG_DTERRM                     \ [0x0a] DTERRM
    $0b constant OTG_BNAMSK                     \ [0x0b] BNAMSK
    $0d constant OTG_DESCLSTROLLMSK             \ [0x0d] DESCLSTROLLMSK
  [then]


  [ifdef] OTG_OTG_HCTSIZ6_DEF
    \
    \ @brief OTG host channel 6 transfer size register
    \ Address offset: 0x5D0
    \ Reset value: 0x00000000
    \
    $00 constant OTG_XFRSIZ                     \ [0x00 : 19] XFRSIZ
    $13 constant OTG_PKTCNT                     \ [0x13 : 10] PKTCNT
    $1d constant OTG_DPID                       \ [0x1d : 2] DPID
  [then]


  [ifdef] OTG_OTG_HCDMA6_DEF
    \
    \ @brief OTG host channel 6 DMA address register in buffer DMA [alternate]
    \ Address offset: 0x5D4
    \ Reset value: 0x00000000
    \
    $00 constant OTG_DMAADDR                    \ [0x00 : 32] DMAADDR
  [then]


  [ifdef] OTG_OTG_HCDMAB6_DEF
    \
    \ @brief OTG host channel-n DMA address buffer register
    \ Address offset: 0x5DC
    \ Reset value: 0x00000000
    \
    $00 constant OTG_HCDMAB                     \ [0x00 : 32] HCDMAB
  [then]


  [ifdef] OTG_OTG_HCCHAR7_DEF
    \
    \ @brief OTG host channel 7 characteristics register
    \ Address offset: 0x5E0
    \ Reset value: 0x00000000
    \
    $00 constant OTG_MPSIZ                      \ [0x00 : 11] MPSIZ
    $0b constant OTG_EPNUM                      \ [0x0b : 4] EPNUM
    $0f constant OTG_EPDIR                      \ [0x0f] EPDIR
    $11 constant OTG_LSDEV                      \ [0x11] LSDEV
    $12 constant OTG_EPTYP                      \ [0x12 : 2] EPTYP
    $14 constant OTG_MCNT                       \ [0x14 : 2] MCNT
    $16 constant OTG_DAD                        \ [0x16 : 7] DAD
    $1e constant OTG_CHDIS                      \ [0x1e] CHDIS
    $1f constant OTG_CHENA                      \ [0x1f] CHENA
  [then]


  [ifdef] OTG_OTG_HCSPLT7_DEF
    \
    \ @brief OTG host channel 7 split control register
    \ Address offset: 0x5E4
    \ Reset value: 0x00000000
    \
    $00 constant OTG_PRTADDR                    \ [0x00 : 7] PRTADDR
    $07 constant OTG_HUBADDR                    \ [0x07 : 7] HUBADDR
    $0e constant OTG_XACTPOS                    \ [0x0e : 2] XACTPOS
    $10 constant OTG_COMPLSPLT                  \ [0x10] COMPLSPLT
    $1f constant OTG_SPLITEN                    \ [0x1f] SPLITEN
  [then]


  [ifdef] OTG_OTG_HCINT7_DEF
    \
    \ @brief This register indicates the status of a channel with respect to USB- and AHB-related events. It is shown in Figure724. The application must read this register when the host channels interrupt bit in the core interrupt register (HCINT bit in OTG_GINTSTS) is set. Before the application can read this register, it must first read the host all channels interrupt (OTG_HAINT) register to get the exact channel number for the host channel-x interrupt register. The application must clear the appropriate bit in this register to clear the corresponding bits in the OTG_HAINT and OTG_GINTSTS registers.
    \ Address offset: 0x5E8
    \ Reset value: 0x00000000
    \
    $00 constant OTG_XFRC                       \ [0x00] XFRC
    $01 constant OTG_CHH                        \ [0x01] CHH
    $02 constant OTG_AHBERR                     \ [0x02] AHBERR
    $03 constant OTG_STALL                      \ [0x03] STALL
    $04 constant OTG_NAK                        \ [0x04] NAK
    $05 constant OTG_ACK                        \ [0x05] ACK
    $06 constant OTG_NYET                       \ [0x06] NYET
    $07 constant OTG_TXERR                      \ [0x07] TXERR
    $08 constant OTG_BBERR                      \ [0x08] BBERR
    $09 constant OTG_FRMOR                      \ [0x09] FRMOR
    $0a constant OTG_DTERR                      \ [0x0a] DTERR
    $0b constant OTG_BNA                        \ [0x0b] BNA
    $0c constant OTG_XCSXACTERR                 \ [0x0c] XCSXACTERR
    $0d constant OTG_DESCLSTROLL                \ [0x0d] DESCLSTROLL
  [then]


  [ifdef] OTG_OTG_HCINTMSK7_DEF
    \
    \ @brief This register reflects the mask for each channel status described in the previous section.
    \ Address offset: 0x5EC
    \ Reset value: 0x00000000
    \
    $00 constant OTG_XFRCM                      \ [0x00] XFRCM
    $01 constant OTG_CHHM                       \ [0x01] CHHM
    $02 constant OTG_AHBERRM                    \ [0x02] AHBERRM
    $03 constant OTG_STALLM                     \ [0x03] STALLM
    $04 constant OTG_NAKM                       \ [0x04] NAKM
    $05 constant OTG_ACKM                       \ [0x05] ACKM
    $06 constant OTG_NYET                       \ [0x06] NYET
    $07 constant OTG_TXERRM                     \ [0x07] TXERRM
    $08 constant OTG_BBERRM                     \ [0x08] BBERRM
    $09 constant OTG_FRMORM                     \ [0x09] FRMORM
    $0a constant OTG_DTERRM                     \ [0x0a] DTERRM
    $0b constant OTG_BNAMSK                     \ [0x0b] BNAMSK
    $0d constant OTG_DESCLSTROLLMSK             \ [0x0d] DESCLSTROLLMSK
  [then]


  [ifdef] OTG_OTG_HCTSIZ7_DEF
    \
    \ @brief OTG host channel 7 transfer size register
    \ Address offset: 0x5F0
    \ Reset value: 0x00000000
    \
    $00 constant OTG_XFRSIZ                     \ [0x00 : 19] XFRSIZ
    $13 constant OTG_PKTCNT                     \ [0x13 : 10] PKTCNT
    $1d constant OTG_DPID                       \ [0x1d : 2] DPID
  [then]


  [ifdef] OTG_OTG_HCDMA7_DEF
    \
    \ @brief OTG host channel 7 DMA address register in buffer DMA [alternate]
    \ Address offset: 0x5F4
    \ Reset value: 0x00000000
    \
    $00 constant OTG_DMAADDR                    \ [0x00 : 32] DMAADDR
  [then]


  [ifdef] OTG_OTG_HCDMAB7_DEF
    \
    \ @brief OTG host channel-n DMA address buffer register
    \ Address offset: 0x5FC
    \ Reset value: 0x00000000
    \
    $00 constant OTG_HCDMAB                     \ [0x00 : 32] HCDMAB
  [then]


  [ifdef] OTG_OTG_HCCHAR8_DEF
    \
    \ @brief OTG host channel 8 characteristics register
    \ Address offset: 0x600
    \ Reset value: 0x00000000
    \
    $00 constant OTG_MPSIZ                      \ [0x00 : 11] MPSIZ
    $0b constant OTG_EPNUM                      \ [0x0b : 4] EPNUM
    $0f constant OTG_EPDIR                      \ [0x0f] EPDIR
    $11 constant OTG_LSDEV                      \ [0x11] LSDEV
    $12 constant OTG_EPTYP                      \ [0x12 : 2] EPTYP
    $14 constant OTG_MCNT                       \ [0x14 : 2] MCNT
    $16 constant OTG_DAD                        \ [0x16 : 7] DAD
    $1e constant OTG_CHDIS                      \ [0x1e] CHDIS
    $1f constant OTG_CHENA                      \ [0x1f] CHENA
  [then]


  [ifdef] OTG_OTG_HCSPLT8_DEF
    \
    \ @brief OTG host channel 8 split control register
    \ Address offset: 0x604
    \ Reset value: 0x00000000
    \
    $00 constant OTG_PRTADDR                    \ [0x00 : 7] PRTADDR
    $07 constant OTG_HUBADDR                    \ [0x07 : 7] HUBADDR
    $0e constant OTG_XACTPOS                    \ [0x0e : 2] XACTPOS
    $10 constant OTG_COMPLSPLT                  \ [0x10] COMPLSPLT
    $1f constant OTG_SPLITEN                    \ [0x1f] SPLITEN
  [then]


  [ifdef] OTG_OTG_HCINT8_DEF
    \
    \ @brief This register indicates the status of a channel with respect to USB- and AHB-related events. It is shown in Figure724. The application must read this register when the host channels interrupt bit in the core interrupt register (HCINT bit in OTG_GINTSTS) is set. Before the application can read this register, it must first read the host all channels interrupt (OTG_HAINT) register to get the exact channel number for the host channel-x interrupt register. The application must clear the appropriate bit in this register to clear the corresponding bits in the OTG_HAINT and OTG_GINTSTS registers.
    \ Address offset: 0x608
    \ Reset value: 0x00000000
    \
    $00 constant OTG_XFRC                       \ [0x00] XFRC
    $01 constant OTG_CHH                        \ [0x01] CHH
    $02 constant OTG_AHBERR                     \ [0x02] AHBERR
    $03 constant OTG_STALL                      \ [0x03] STALL
    $04 constant OTG_NAK                        \ [0x04] NAK
    $05 constant OTG_ACK                        \ [0x05] ACK
    $06 constant OTG_NYET                       \ [0x06] NYET
    $07 constant OTG_TXERR                      \ [0x07] TXERR
    $08 constant OTG_BBERR                      \ [0x08] BBERR
    $09 constant OTG_FRMOR                      \ [0x09] FRMOR
    $0a constant OTG_DTERR                      \ [0x0a] DTERR
    $0b constant OTG_BNA                        \ [0x0b] BNA
    $0c constant OTG_XCSXACTERR                 \ [0x0c] XCSXACTERR
    $0d constant OTG_DESCLSTROLL                \ [0x0d] DESCLSTROLL
  [then]


  [ifdef] OTG_OTG_HCINTMSK8_DEF
    \
    \ @brief This register reflects the mask for each channel status described in the previous section.
    \ Address offset: 0x60C
    \ Reset value: 0x00000000
    \
    $00 constant OTG_XFRCM                      \ [0x00] XFRCM
    $01 constant OTG_CHHM                       \ [0x01] CHHM
    $02 constant OTG_AHBERRM                    \ [0x02] AHBERRM
    $03 constant OTG_STALLM                     \ [0x03] STALLM
    $04 constant OTG_NAKM                       \ [0x04] NAKM
    $05 constant OTG_ACKM                       \ [0x05] ACKM
    $06 constant OTG_NYET                       \ [0x06] NYET
    $07 constant OTG_TXERRM                     \ [0x07] TXERRM
    $08 constant OTG_BBERRM                     \ [0x08] BBERRM
    $09 constant OTG_FRMORM                     \ [0x09] FRMORM
    $0a constant OTG_DTERRM                     \ [0x0a] DTERRM
    $0b constant OTG_BNAMSK                     \ [0x0b] BNAMSK
    $0d constant OTG_DESCLSTROLLMSK             \ [0x0d] DESCLSTROLLMSK
  [then]


  [ifdef] OTG_OTG_HCTSIZ8_DEF
    \
    \ @brief OTG host channel 8 transfer size register
    \ Address offset: 0x610
    \ Reset value: 0x00000000
    \
    $00 constant OTG_XFRSIZ                     \ [0x00 : 19] XFRSIZ
    $13 constant OTG_PKTCNT                     \ [0x13 : 10] PKTCNT
    $1d constant OTG_DPID                       \ [0x1d : 2] DPID
  [then]


  [ifdef] OTG_OTG_HCDMA8_DEF
    \
    \ @brief OTG host channel 8 DMA address register in buffer DMA [alternate]
    \ Address offset: 0x614
    \ Reset value: 0x00000000
    \
    $00 constant OTG_DMAADDR                    \ [0x00 : 32] DMAADDR
  [then]


  [ifdef] OTG_OTG_HCDMAB8_DEF
    \
    \ @brief OTG host channel-n DMA address buffer register
    \ Address offset: 0x61C
    \ Reset value: 0x00000000
    \
    $00 constant OTG_HCDMAB                     \ [0x00 : 32] HCDMAB
  [then]


  [ifdef] OTG_OTG_HCCHAR9_DEF
    \
    \ @brief OTG host channel 9 characteristics register
    \ Address offset: 0x620
    \ Reset value: 0x00000000
    \
    $00 constant OTG_MPSIZ                      \ [0x00 : 11] MPSIZ
    $0b constant OTG_EPNUM                      \ [0x0b : 4] EPNUM
    $0f constant OTG_EPDIR                      \ [0x0f] EPDIR
    $11 constant OTG_LSDEV                      \ [0x11] LSDEV
    $12 constant OTG_EPTYP                      \ [0x12 : 2] EPTYP
    $14 constant OTG_MCNT                       \ [0x14 : 2] MCNT
    $16 constant OTG_DAD                        \ [0x16 : 7] DAD
    $1e constant OTG_CHDIS                      \ [0x1e] CHDIS
    $1f constant OTG_CHENA                      \ [0x1f] CHENA
  [then]


  [ifdef] OTG_OTG_HCSPLT9_DEF
    \
    \ @brief OTG host channel 9 split control register
    \ Address offset: 0x624
    \ Reset value: 0x00000000
    \
    $00 constant OTG_PRTADDR                    \ [0x00 : 7] PRTADDR
    $07 constant OTG_HUBADDR                    \ [0x07 : 7] HUBADDR
    $0e constant OTG_XACTPOS                    \ [0x0e : 2] XACTPOS
    $10 constant OTG_COMPLSPLT                  \ [0x10] COMPLSPLT
    $1f constant OTG_SPLITEN                    \ [0x1f] SPLITEN
  [then]


  [ifdef] OTG_OTG_HCINT9_DEF
    \
    \ @brief This register indicates the status of a channel with respect to USB- and AHB-related events. It is shown in Figure724. The application must read this register when the host channels interrupt bit in the core interrupt register (HCINT bit in OTG_GINTSTS) is set. Before the application can read this register, it must first read the host all channels interrupt (OTG_HAINT) register to get the exact channel number for the host channel-x interrupt register. The application must clear the appropriate bit in this register to clear the corresponding bits in the OTG_HAINT and OTG_GINTSTS registers.
    \ Address offset: 0x628
    \ Reset value: 0x00000000
    \
    $00 constant OTG_XFRC                       \ [0x00] XFRC
    $01 constant OTG_CHH                        \ [0x01] CHH
    $02 constant OTG_AHBERR                     \ [0x02] AHBERR
    $03 constant OTG_STALL                      \ [0x03] STALL
    $04 constant OTG_NAK                        \ [0x04] NAK
    $05 constant OTG_ACK                        \ [0x05] ACK
    $06 constant OTG_NYET                       \ [0x06] NYET
    $07 constant OTG_TXERR                      \ [0x07] TXERR
    $08 constant OTG_BBERR                      \ [0x08] BBERR
    $09 constant OTG_FRMOR                      \ [0x09] FRMOR
    $0a constant OTG_DTERR                      \ [0x0a] DTERR
    $0b constant OTG_BNA                        \ [0x0b] BNA
    $0c constant OTG_XCSXACTERR                 \ [0x0c] XCSXACTERR
    $0d constant OTG_DESCLSTROLL                \ [0x0d] DESCLSTROLL
  [then]


  [ifdef] OTG_OTG_HCINTMSK9_DEF
    \
    \ @brief This register reflects the mask for each channel status described in the previous section.
    \ Address offset: 0x62C
    \ Reset value: 0x00000000
    \
    $00 constant OTG_XFRCM                      \ [0x00] XFRCM
    $01 constant OTG_CHHM                       \ [0x01] CHHM
    $02 constant OTG_AHBERRM                    \ [0x02] AHBERRM
    $03 constant OTG_STALLM                     \ [0x03] STALLM
    $04 constant OTG_NAKM                       \ [0x04] NAKM
    $05 constant OTG_ACKM                       \ [0x05] ACKM
    $06 constant OTG_NYET                       \ [0x06] NYET
    $07 constant OTG_TXERRM                     \ [0x07] TXERRM
    $08 constant OTG_BBERRM                     \ [0x08] BBERRM
    $09 constant OTG_FRMORM                     \ [0x09] FRMORM
    $0a constant OTG_DTERRM                     \ [0x0a] DTERRM
    $0b constant OTG_BNAMSK                     \ [0x0b] BNAMSK
    $0d constant OTG_DESCLSTROLLMSK             \ [0x0d] DESCLSTROLLMSK
  [then]


  [ifdef] OTG_OTG_HCTSIZ9_DEF
    \
    \ @brief OTG host channel 9 transfer size register
    \ Address offset: 0x630
    \ Reset value: 0x00000000
    \
    $00 constant OTG_XFRSIZ                     \ [0x00 : 19] XFRSIZ
    $13 constant OTG_PKTCNT                     \ [0x13 : 10] PKTCNT
    $1d constant OTG_DPID                       \ [0x1d : 2] DPID
  [then]


  [ifdef] OTG_OTG_HCDMA9_DEF
    \
    \ @brief OTG host channel 9 DMA address register in buffer DMA [alternate]
    \ Address offset: 0x634
    \ Reset value: 0x00000000
    \
    $00 constant OTG_DMAADDR                    \ [0x00 : 32] DMAADDR
  [then]


  [ifdef] OTG_OTG_HCDMAB9_DEF
    \
    \ @brief OTG host channel-n DMA address buffer register
    \ Address offset: 0x63C
    \ Reset value: 0x00000000
    \
    $00 constant OTG_HCDMAB                     \ [0x00 : 32] HCDMAB
  [then]


  [ifdef] OTG_OTG_HCCHAR10_DEF
    \
    \ @brief OTG host channel 10 characteristics register
    \ Address offset: 0x640
    \ Reset value: 0x00000000
    \
    $00 constant OTG_MPSIZ                      \ [0x00 : 11] MPSIZ
    $0b constant OTG_EPNUM                      \ [0x0b : 4] EPNUM
    $0f constant OTG_EPDIR                      \ [0x0f] EPDIR
    $11 constant OTG_LSDEV                      \ [0x11] LSDEV
    $12 constant OTG_EPTYP                      \ [0x12 : 2] EPTYP
    $14 constant OTG_MCNT                       \ [0x14 : 2] MCNT
    $16 constant OTG_DAD                        \ [0x16 : 7] DAD
    $1e constant OTG_CHDIS                      \ [0x1e] CHDIS
    $1f constant OTG_CHENA                      \ [0x1f] CHENA
  [then]


  [ifdef] OTG_OTG_HCSPLT10_DEF
    \
    \ @brief OTG host channel 10 split control register
    \ Address offset: 0x644
    \ Reset value: 0x00000000
    \
    $00 constant OTG_PRTADDR                    \ [0x00 : 7] PRTADDR
    $07 constant OTG_HUBADDR                    \ [0x07 : 7] HUBADDR
    $0e constant OTG_XACTPOS                    \ [0x0e : 2] XACTPOS
    $10 constant OTG_COMPLSPLT                  \ [0x10] COMPLSPLT
    $1f constant OTG_SPLITEN                    \ [0x1f] SPLITEN
  [then]


  [ifdef] OTG_OTG_HCINT10_DEF
    \
    \ @brief This register indicates the status of a channel with respect to USB- and AHB-related events. It is shown in Figure724. The application must read this register when the host channels interrupt bit in the core interrupt register (HCINT bit in OTG_GINTSTS) is set. Before the application can read this register, it must first read the host all channels interrupt (OTG_HAINT) register to get the exact channel number for the host channel-x interrupt register. The application must clear the appropriate bit in this register to clear the corresponding bits in the OTG_HAINT and OTG_GINTSTS registers.
    \ Address offset: 0x648
    \ Reset value: 0x00000000
    \
    $00 constant OTG_XFRC                       \ [0x00] XFRC
    $01 constant OTG_CHH                        \ [0x01] CHH
    $02 constant OTG_AHBERR                     \ [0x02] AHBERR
    $03 constant OTG_STALL                      \ [0x03] STALL
    $04 constant OTG_NAK                        \ [0x04] NAK
    $05 constant OTG_ACK                        \ [0x05] ACK
    $06 constant OTG_NYET                       \ [0x06] NYET
    $07 constant OTG_TXERR                      \ [0x07] TXERR
    $08 constant OTG_BBERR                      \ [0x08] BBERR
    $09 constant OTG_FRMOR                      \ [0x09] FRMOR
    $0a constant OTG_DTERR                      \ [0x0a] DTERR
    $0b constant OTG_BNA                        \ [0x0b] BNA
    $0c constant OTG_XCSXACTERR                 \ [0x0c] XCSXACTERR
    $0d constant OTG_DESCLSTROLL                \ [0x0d] DESCLSTROLL
  [then]


  [ifdef] OTG_OTG_HCINTMSK10_DEF
    \
    \ @brief This register reflects the mask for each channel status described in the previous section.
    \ Address offset: 0x64C
    \ Reset value: 0x00000000
    \
    $00 constant OTG_XFRCM                      \ [0x00] XFRCM
    $01 constant OTG_CHHM                       \ [0x01] CHHM
    $02 constant OTG_AHBERRM                    \ [0x02] AHBERRM
    $03 constant OTG_STALLM                     \ [0x03] STALLM
    $04 constant OTG_NAKM                       \ [0x04] NAKM
    $05 constant OTG_ACKM                       \ [0x05] ACKM
    $06 constant OTG_NYET                       \ [0x06] NYET
    $07 constant OTG_TXERRM                     \ [0x07] TXERRM
    $08 constant OTG_BBERRM                     \ [0x08] BBERRM
    $09 constant OTG_FRMORM                     \ [0x09] FRMORM
    $0a constant OTG_DTERRM                     \ [0x0a] DTERRM
    $0b constant OTG_BNAMSK                     \ [0x0b] BNAMSK
    $0d constant OTG_DESCLSTROLLMSK             \ [0x0d] DESCLSTROLLMSK
  [then]


  [ifdef] OTG_OTG_HCTSIZ10_DEF
    \
    \ @brief OTG host channel 10 transfer size register
    \ Address offset: 0x650
    \ Reset value: 0x00000000
    \
    $00 constant OTG_XFRSIZ                     \ [0x00 : 19] XFRSIZ
    $13 constant OTG_PKTCNT                     \ [0x13 : 10] PKTCNT
    $1d constant OTG_DPID                       \ [0x1d : 2] DPID
  [then]


  [ifdef] OTG_OTG_HCDMA10_DEF
    \
    \ @brief OTG host channel 10 DMA address register in buffer DMA [alternate]
    \ Address offset: 0x654
    \ Reset value: 0x00000000
    \
    $00 constant OTG_DMAADDR                    \ [0x00 : 32] DMAADDR
  [then]


  [ifdef] OTG_OTG_HCDMAB10_DEF
    \
    \ @brief OTG host channel-n DMA address buffer register
    \ Address offset: 0x65C
    \ Reset value: 0x00000000
    \
    $00 constant OTG_HCDMAB                     \ [0x00 : 32] HCDMAB
  [then]


  [ifdef] OTG_OTG_HCCHAR11_DEF
    \
    \ @brief OTG host channel 11 characteristics register
    \ Address offset: 0x660
    \ Reset value: 0x00000000
    \
    $00 constant OTG_MPSIZ                      \ [0x00 : 11] MPSIZ
    $0b constant OTG_EPNUM                      \ [0x0b : 4] EPNUM
    $0f constant OTG_EPDIR                      \ [0x0f] EPDIR
    $11 constant OTG_LSDEV                      \ [0x11] LSDEV
    $12 constant OTG_EPTYP                      \ [0x12 : 2] EPTYP
    $14 constant OTG_MCNT                       \ [0x14 : 2] MCNT
    $16 constant OTG_DAD                        \ [0x16 : 7] DAD
    $1e constant OTG_CHDIS                      \ [0x1e] CHDIS
    $1f constant OTG_CHENA                      \ [0x1f] CHENA
  [then]


  [ifdef] OTG_OTG_HCSPLT11_DEF
    \
    \ @brief OTG host channel 11 split control register
    \ Address offset: 0x664
    \ Reset value: 0x00000000
    \
    $00 constant OTG_PRTADDR                    \ [0x00 : 7] PRTADDR
    $07 constant OTG_HUBADDR                    \ [0x07 : 7] HUBADDR
    $0e constant OTG_XACTPOS                    \ [0x0e : 2] XACTPOS
    $10 constant OTG_COMPLSPLT                  \ [0x10] COMPLSPLT
    $1f constant OTG_SPLITEN                    \ [0x1f] SPLITEN
  [then]


  [ifdef] OTG_OTG_HCINT11_DEF
    \
    \ @brief This register indicates the status of a channel with respect to USB- and AHB-related events. It is shown in Figure724. The application must read this register when the host channels interrupt bit in the core interrupt register (HCINT bit in OTG_GINTSTS) is set. Before the application can read this register, it must first read the host all channels interrupt (OTG_HAINT) register to get the exact channel number for the host channel-x interrupt register. The application must clear the appropriate bit in this register to clear the corresponding bits in the OTG_HAINT and OTG_GINTSTS registers.
    \ Address offset: 0x668
    \ Reset value: 0x00000000
    \
    $00 constant OTG_XFRC                       \ [0x00] XFRC
    $01 constant OTG_CHH                        \ [0x01] CHH
    $02 constant OTG_AHBERR                     \ [0x02] AHBERR
    $03 constant OTG_STALL                      \ [0x03] STALL
    $04 constant OTG_NAK                        \ [0x04] NAK
    $05 constant OTG_ACK                        \ [0x05] ACK
    $06 constant OTG_NYET                       \ [0x06] NYET
    $07 constant OTG_TXERR                      \ [0x07] TXERR
    $08 constant OTG_BBERR                      \ [0x08] BBERR
    $09 constant OTG_FRMOR                      \ [0x09] FRMOR
    $0a constant OTG_DTERR                      \ [0x0a] DTERR
    $0b constant OTG_BNA                        \ [0x0b] BNA
    $0c constant OTG_XCSXACTERR                 \ [0x0c] XCSXACTERR
    $0d constant OTG_DESCLSTROLL                \ [0x0d] DESCLSTROLL
  [then]


  [ifdef] OTG_OTG_HCINTMSK11_DEF
    \
    \ @brief This register reflects the mask for each channel status described in the previous section.
    \ Address offset: 0x66C
    \ Reset value: 0x00000000
    \
    $00 constant OTG_XFRCM                      \ [0x00] XFRCM
    $01 constant OTG_CHHM                       \ [0x01] CHHM
    $02 constant OTG_AHBERRM                    \ [0x02] AHBERRM
    $03 constant OTG_STALLM                     \ [0x03] STALLM
    $04 constant OTG_NAKM                       \ [0x04] NAKM
    $05 constant OTG_ACKM                       \ [0x05] ACKM
    $06 constant OTG_NYET                       \ [0x06] NYET
    $07 constant OTG_TXERRM                     \ [0x07] TXERRM
    $08 constant OTG_BBERRM                     \ [0x08] BBERRM
    $09 constant OTG_FRMORM                     \ [0x09] FRMORM
    $0a constant OTG_DTERRM                     \ [0x0a] DTERRM
    $0b constant OTG_BNAMSK                     \ [0x0b] BNAMSK
    $0d constant OTG_DESCLSTROLLMSK             \ [0x0d] DESCLSTROLLMSK
  [then]


  [ifdef] OTG_OTG_HCTSIZ11_DEF
    \
    \ @brief OTG host channel 11 transfer size register
    \ Address offset: 0x670
    \ Reset value: 0x00000000
    \
    $00 constant OTG_XFRSIZ                     \ [0x00 : 19] XFRSIZ
    $13 constant OTG_PKTCNT                     \ [0x13 : 10] PKTCNT
    $1d constant OTG_DPID                       \ [0x1d : 2] DPID
  [then]


  [ifdef] OTG_OTG_HCDMA11_DEF
    \
    \ @brief OTG host channel 11 DMA address register in buffer DMA [alternate]
    \ Address offset: 0x674
    \ Reset value: 0x00000000
    \
    $00 constant OTG_DMAADDR                    \ [0x00 : 32] DMAADDR
  [then]


  [ifdef] OTG_OTG_HCDMAB11_DEF
    \
    \ @brief OTG host channel-n DMA address buffer register
    \ Address offset: 0x67C
    \ Reset value: 0x00000000
    \
    $00 constant OTG_HCDMAB                     \ [0x00 : 32] HCDMAB
  [then]


  [ifdef] OTG_OTG_HCCHAR12_DEF
    \
    \ @brief OTG host channel 12 characteristics register
    \ Address offset: 0x680
    \ Reset value: 0x00000000
    \
    $00 constant OTG_MPSIZ                      \ [0x00 : 11] MPSIZ
    $0b constant OTG_EPNUM                      \ [0x0b : 4] EPNUM
    $0f constant OTG_EPDIR                      \ [0x0f] EPDIR
    $11 constant OTG_LSDEV                      \ [0x11] LSDEV
    $12 constant OTG_EPTYP                      \ [0x12 : 2] EPTYP
    $14 constant OTG_MCNT                       \ [0x14 : 2] MCNT
    $16 constant OTG_DAD                        \ [0x16 : 7] DAD
    $1e constant OTG_CHDIS                      \ [0x1e] CHDIS
    $1f constant OTG_CHENA                      \ [0x1f] CHENA
  [then]


  [ifdef] OTG_OTG_HCSPLT12_DEF
    \
    \ @brief OTG host channel 12 split control register
    \ Address offset: 0x684
    \ Reset value: 0x00000000
    \
    $00 constant OTG_PRTADDR                    \ [0x00 : 7] PRTADDR
    $07 constant OTG_HUBADDR                    \ [0x07 : 7] HUBADDR
    $0e constant OTG_XACTPOS                    \ [0x0e : 2] XACTPOS
    $10 constant OTG_COMPLSPLT                  \ [0x10] COMPLSPLT
    $1f constant OTG_SPLITEN                    \ [0x1f] SPLITEN
  [then]


  [ifdef] OTG_OTG_HCINT12_DEF
    \
    \ @brief This register indicates the status of a channel with respect to USB- and AHB-related events. It is shown in Figure724. The application must read this register when the host channels interrupt bit in the core interrupt register (HCINT bit in OTG_GINTSTS) is set. Before the application can read this register, it must first read the host all channels interrupt (OTG_HAINT) register to get the exact channel number for the host channel-x interrupt register. The application must clear the appropriate bit in this register to clear the corresponding bits in the OTG_HAINT and OTG_GINTSTS registers.
    \ Address offset: 0x688
    \ Reset value: 0x00000000
    \
    $00 constant OTG_XFRC                       \ [0x00] XFRC
    $01 constant OTG_CHH                        \ [0x01] CHH
    $02 constant OTG_AHBERR                     \ [0x02] AHBERR
    $03 constant OTG_STALL                      \ [0x03] STALL
    $04 constant OTG_NAK                        \ [0x04] NAK
    $05 constant OTG_ACK                        \ [0x05] ACK
    $06 constant OTG_NYET                       \ [0x06] NYET
    $07 constant OTG_TXERR                      \ [0x07] TXERR
    $08 constant OTG_BBERR                      \ [0x08] BBERR
    $09 constant OTG_FRMOR                      \ [0x09] FRMOR
    $0a constant OTG_DTERR                      \ [0x0a] DTERR
    $0b constant OTG_BNA                        \ [0x0b] BNA
    $0c constant OTG_XCSXACTERR                 \ [0x0c] XCSXACTERR
    $0d constant OTG_DESCLSTROLL                \ [0x0d] DESCLSTROLL
  [then]


  [ifdef] OTG_OTG_HCINTMSK12_DEF
    \
    \ @brief This register reflects the mask for each channel status described in the previous section.
    \ Address offset: 0x68C
    \ Reset value: 0x00000000
    \
    $00 constant OTG_XFRCM                      \ [0x00] XFRCM
    $01 constant OTG_CHHM                       \ [0x01] CHHM
    $02 constant OTG_AHBERRM                    \ [0x02] AHBERRM
    $03 constant OTG_STALLM                     \ [0x03] STALLM
    $04 constant OTG_NAKM                       \ [0x04] NAKM
    $05 constant OTG_ACKM                       \ [0x05] ACKM
    $06 constant OTG_NYET                       \ [0x06] NYET
    $07 constant OTG_TXERRM                     \ [0x07] TXERRM
    $08 constant OTG_BBERRM                     \ [0x08] BBERRM
    $09 constant OTG_FRMORM                     \ [0x09] FRMORM
    $0a constant OTG_DTERRM                     \ [0x0a] DTERRM
    $0b constant OTG_BNAMSK                     \ [0x0b] BNAMSK
    $0d constant OTG_DESCLSTROLLMSK             \ [0x0d] DESCLSTROLLMSK
  [then]


  [ifdef] OTG_OTG_HCTSIZ12_DEF
    \
    \ @brief OTG host channel 12 transfer size register
    \ Address offset: 0x690
    \ Reset value: 0x00000000
    \
    $00 constant OTG_XFRSIZ                     \ [0x00 : 19] XFRSIZ
    $13 constant OTG_PKTCNT                     \ [0x13 : 10] PKTCNT
    $1d constant OTG_DPID                       \ [0x1d : 2] DPID
  [then]


  [ifdef] OTG_OTG_HCDMA12_DEF
    \
    \ @brief OTG host channel 12 DMA address register in buffer DMA [alternate]
    \ Address offset: 0x694
    \ Reset value: 0x00000000
    \
    $00 constant OTG_DMAADDR                    \ [0x00 : 32] DMAADDR
  [then]


  [ifdef] OTG_OTG_HCDMAB12_DEF
    \
    \ @brief OTG host channel-n DMA address buffer register
    \ Address offset: 0x69C
    \ Reset value: 0x00000000
    \
    $00 constant OTG_HCDMAB                     \ [0x00 : 32] HCDMAB
  [then]


  [ifdef] OTG_OTG_HCCHAR13_DEF
    \
    \ @brief OTG host channel 13 characteristics register
    \ Address offset: 0x6A0
    \ Reset value: 0x00000000
    \
    $00 constant OTG_MPSIZ                      \ [0x00 : 11] MPSIZ
    $0b constant OTG_EPNUM                      \ [0x0b : 4] EPNUM
    $0f constant OTG_EPDIR                      \ [0x0f] EPDIR
    $11 constant OTG_LSDEV                      \ [0x11] LSDEV
    $12 constant OTG_EPTYP                      \ [0x12 : 2] EPTYP
    $14 constant OTG_MCNT                       \ [0x14 : 2] MCNT
    $16 constant OTG_DAD                        \ [0x16 : 7] DAD
    $1e constant OTG_CHDIS                      \ [0x1e] CHDIS
    $1f constant OTG_CHENA                      \ [0x1f] CHENA
  [then]


  [ifdef] OTG_OTG_HCSPLT13_DEF
    \
    \ @brief OTG host channel 13 split control register
    \ Address offset: 0x6A4
    \ Reset value: 0x00000000
    \
    $00 constant OTG_PRTADDR                    \ [0x00 : 7] PRTADDR
    $07 constant OTG_HUBADDR                    \ [0x07 : 7] HUBADDR
    $0e constant OTG_XACTPOS                    \ [0x0e : 2] XACTPOS
    $10 constant OTG_COMPLSPLT                  \ [0x10] COMPLSPLT
    $1f constant OTG_SPLITEN                    \ [0x1f] SPLITEN
  [then]


  [ifdef] OTG_OTG_HCINT13_DEF
    \
    \ @brief This register indicates the status of a channel with respect to USB- and AHB-related events. It is shown in Figure724. The application must read this register when the host channels interrupt bit in the core interrupt register (HCINT bit in OTG_GINTSTS) is set. Before the application can read this register, it must first read the host all channels interrupt (OTG_HAINT) register to get the exact channel number for the host channel-x interrupt register. The application must clear the appropriate bit in this register to clear the corresponding bits in the OTG_HAINT and OTG_GINTSTS registers.
    \ Address offset: 0x6A8
    \ Reset value: 0x00000000
    \
    $00 constant OTG_XFRC                       \ [0x00] XFRC
    $01 constant OTG_CHH                        \ [0x01] CHH
    $02 constant OTG_AHBERR                     \ [0x02] AHBERR
    $03 constant OTG_STALL                      \ [0x03] STALL
    $04 constant OTG_NAK                        \ [0x04] NAK
    $05 constant OTG_ACK                        \ [0x05] ACK
    $06 constant OTG_NYET                       \ [0x06] NYET
    $07 constant OTG_TXERR                      \ [0x07] TXERR
    $08 constant OTG_BBERR                      \ [0x08] BBERR
    $09 constant OTG_FRMOR                      \ [0x09] FRMOR
    $0a constant OTG_DTERR                      \ [0x0a] DTERR
    $0b constant OTG_BNA                        \ [0x0b] BNA
    $0c constant OTG_XCSXACTERR                 \ [0x0c] XCSXACTERR
    $0d constant OTG_DESCLSTROLL                \ [0x0d] DESCLSTROLL
  [then]


  [ifdef] OTG_OTG_HCINTMSK13_DEF
    \
    \ @brief This register reflects the mask for each channel status described in the previous section.
    \ Address offset: 0x6AC
    \ Reset value: 0x00000000
    \
    $00 constant OTG_XFRCM                      \ [0x00] XFRCM
    $01 constant OTG_CHHM                       \ [0x01] CHHM
    $02 constant OTG_AHBERRM                    \ [0x02] AHBERRM
    $03 constant OTG_STALLM                     \ [0x03] STALLM
    $04 constant OTG_NAKM                       \ [0x04] NAKM
    $05 constant OTG_ACKM                       \ [0x05] ACKM
    $06 constant OTG_NYET                       \ [0x06] NYET
    $07 constant OTG_TXERRM                     \ [0x07] TXERRM
    $08 constant OTG_BBERRM                     \ [0x08] BBERRM
    $09 constant OTG_FRMORM                     \ [0x09] FRMORM
    $0a constant OTG_DTERRM                     \ [0x0a] DTERRM
    $0b constant OTG_BNAMSK                     \ [0x0b] BNAMSK
    $0d constant OTG_DESCLSTROLLMSK             \ [0x0d] DESCLSTROLLMSK
  [then]


  [ifdef] OTG_OTG_HCTSIZ13_DEF
    \
    \ @brief OTG host channel 13 transfer size register
    \ Address offset: 0x6B0
    \ Reset value: 0x00000000
    \
    $00 constant OTG_XFRSIZ                     \ [0x00 : 19] XFRSIZ
    $13 constant OTG_PKTCNT                     \ [0x13 : 10] PKTCNT
    $1d constant OTG_DPID                       \ [0x1d : 2] DPID
  [then]


  [ifdef] OTG_OTG_HCDMA13_DEF
    \
    \ @brief OTG host channel 13 DMA address register in buffer DMA [alternate]
    \ Address offset: 0x6B4
    \ Reset value: 0x00000000
    \
    $00 constant OTG_DMAADDR                    \ [0x00 : 32] DMAADDR
  [then]


  [ifdef] OTG_OTG_HCDMAB13_DEF
    \
    \ @brief OTG host channel-n DMA address buffer register
    \ Address offset: 0x6BC
    \ Reset value: 0x00000000
    \
    $00 constant OTG_HCDMAB                     \ [0x00 : 32] HCDMAB
  [then]


  [ifdef] OTG_OTG_HCCHAR14_DEF
    \
    \ @brief OTG host channel 14 characteristics register
    \ Address offset: 0x6C0
    \ Reset value: 0x00000000
    \
    $00 constant OTG_MPSIZ                      \ [0x00 : 11] MPSIZ
    $0b constant OTG_EPNUM                      \ [0x0b : 4] EPNUM
    $0f constant OTG_EPDIR                      \ [0x0f] EPDIR
    $11 constant OTG_LSDEV                      \ [0x11] LSDEV
    $12 constant OTG_EPTYP                      \ [0x12 : 2] EPTYP
    $14 constant OTG_MCNT                       \ [0x14 : 2] MCNT
    $16 constant OTG_DAD                        \ [0x16 : 7] DAD
    $1e constant OTG_CHDIS                      \ [0x1e] CHDIS
    $1f constant OTG_CHENA                      \ [0x1f] CHENA
  [then]


  [ifdef] OTG_OTG_HCSPLT14_DEF
    \
    \ @brief OTG host channel 14 split control register
    \ Address offset: 0x6C4
    \ Reset value: 0x00000000
    \
    $00 constant OTG_PRTADDR                    \ [0x00 : 7] PRTADDR
    $07 constant OTG_HUBADDR                    \ [0x07 : 7] HUBADDR
    $0e constant OTG_XACTPOS                    \ [0x0e : 2] XACTPOS
    $10 constant OTG_COMPLSPLT                  \ [0x10] COMPLSPLT
    $1f constant OTG_SPLITEN                    \ [0x1f] SPLITEN
  [then]


  [ifdef] OTG_OTG_HCINT14_DEF
    \
    \ @brief This register indicates the status of a channel with respect to USB- and AHB-related events. It is shown in Figure724. The application must read this register when the host channels interrupt bit in the core interrupt register (HCINT bit in OTG_GINTSTS) is set. Before the application can read this register, it must first read the host all channels interrupt (OTG_HAINT) register to get the exact channel number for the host channel-x interrupt register. The application must clear the appropriate bit in this register to clear the corresponding bits in the OTG_HAINT and OTG_GINTSTS registers.
    \ Address offset: 0x6C8
    \ Reset value: 0x00000000
    \
    $00 constant OTG_XFRC                       \ [0x00] XFRC
    $01 constant OTG_CHH                        \ [0x01] CHH
    $02 constant OTG_AHBERR                     \ [0x02] AHBERR
    $03 constant OTG_STALL                      \ [0x03] STALL
    $04 constant OTG_NAK                        \ [0x04] NAK
    $05 constant OTG_ACK                        \ [0x05] ACK
    $06 constant OTG_NYET                       \ [0x06] NYET
    $07 constant OTG_TXERR                      \ [0x07] TXERR
    $08 constant OTG_BBERR                      \ [0x08] BBERR
    $09 constant OTG_FRMOR                      \ [0x09] FRMOR
    $0a constant OTG_DTERR                      \ [0x0a] DTERR
    $0b constant OTG_BNA                        \ [0x0b] BNA
    $0c constant OTG_XCSXACTERR                 \ [0x0c] XCSXACTERR
    $0d constant OTG_DESCLSTROLL                \ [0x0d] DESCLSTROLL
  [then]


  [ifdef] OTG_OTG_HCINTMSK14_DEF
    \
    \ @brief This register reflects the mask for each channel status described in the previous section.
    \ Address offset: 0x6CC
    \ Reset value: 0x00000000
    \
    $00 constant OTG_XFRCM                      \ [0x00] XFRCM
    $01 constant OTG_CHHM                       \ [0x01] CHHM
    $02 constant OTG_AHBERRM                    \ [0x02] AHBERRM
    $03 constant OTG_STALLM                     \ [0x03] STALLM
    $04 constant OTG_NAKM                       \ [0x04] NAKM
    $05 constant OTG_ACKM                       \ [0x05] ACKM
    $06 constant OTG_NYET                       \ [0x06] NYET
    $07 constant OTG_TXERRM                     \ [0x07] TXERRM
    $08 constant OTG_BBERRM                     \ [0x08] BBERRM
    $09 constant OTG_FRMORM                     \ [0x09] FRMORM
    $0a constant OTG_DTERRM                     \ [0x0a] DTERRM
    $0b constant OTG_BNAMSK                     \ [0x0b] BNAMSK
    $0d constant OTG_DESCLSTROLLMSK             \ [0x0d] DESCLSTROLLMSK
  [then]


  [ifdef] OTG_OTG_HCTSIZ14_DEF
    \
    \ @brief OTG host channel 14 transfer size register
    \ Address offset: 0x6D0
    \ Reset value: 0x00000000
    \
    $00 constant OTG_XFRSIZ                     \ [0x00 : 19] XFRSIZ
    $13 constant OTG_PKTCNT                     \ [0x13 : 10] PKTCNT
    $1d constant OTG_DPID                       \ [0x1d : 2] DPID
  [then]


  [ifdef] OTG_OTG_HCDMA14_DEF
    \
    \ @brief OTG host channel 14 DMA address register in buffer DMA [alternate]
    \ Address offset: 0x6D4
    \ Reset value: 0x00000000
    \
    $00 constant OTG_DMAADDR                    \ [0x00 : 32] DMAADDR
  [then]


  [ifdef] OTG_OTG_HCDMAB14_DEF
    \
    \ @brief OTG host channel-n DMA address buffer register
    \ Address offset: 0x6DC
    \ Reset value: 0x00000000
    \
    $00 constant OTG_HCDMAB                     \ [0x00 : 32] HCDMAB
  [then]


  [ifdef] OTG_OTG_HCCHAR15_DEF
    \
    \ @brief OTG host channel 15 characteristics register
    \ Address offset: 0x6E0
    \ Reset value: 0x00000000
    \
    $00 constant OTG_MPSIZ                      \ [0x00 : 11] MPSIZ
    $0b constant OTG_EPNUM                      \ [0x0b : 4] EPNUM
    $0f constant OTG_EPDIR                      \ [0x0f] EPDIR
    $11 constant OTG_LSDEV                      \ [0x11] LSDEV
    $12 constant OTG_EPTYP                      \ [0x12 : 2] EPTYP
    $14 constant OTG_MCNT                       \ [0x14 : 2] MCNT
    $16 constant OTG_DAD                        \ [0x16 : 7] DAD
    $1e constant OTG_CHDIS                      \ [0x1e] CHDIS
    $1f constant OTG_CHENA                      \ [0x1f] CHENA
  [then]


  [ifdef] OTG_OTG_HCSPLT15_DEF
    \
    \ @brief OTG host channel 15 split control register
    \ Address offset: 0x6E4
    \ Reset value: 0x00000000
    \
    $00 constant OTG_PRTADDR                    \ [0x00 : 7] PRTADDR
    $07 constant OTG_HUBADDR                    \ [0x07 : 7] HUBADDR
    $0e constant OTG_XACTPOS                    \ [0x0e : 2] XACTPOS
    $10 constant OTG_COMPLSPLT                  \ [0x10] COMPLSPLT
    $1f constant OTG_SPLITEN                    \ [0x1f] SPLITEN
  [then]


  [ifdef] OTG_OTG_HCINT15_DEF
    \
    \ @brief This register indicates the status of a channel with respect to USB- and AHB-related events. It is shown in Figure724. The application must read this register when the host channels interrupt bit in the core interrupt register (HCINT bit in OTG_GINTSTS) is set. Before the application can read this register, it must first read the host all channels interrupt (OTG_HAINT) register to get the exact channel number for the host channel-x interrupt register. The application must clear the appropriate bit in this register to clear the corresponding bits in the OTG_HAINT and OTG_GINTSTS registers.
    \ Address offset: 0x6E8
    \ Reset value: 0x00000000
    \
    $00 constant OTG_XFRC                       \ [0x00] XFRC
    $01 constant OTG_CHH                        \ [0x01] CHH
    $02 constant OTG_AHBERR                     \ [0x02] AHBERR
    $03 constant OTG_STALL                      \ [0x03] STALL
    $04 constant OTG_NAK                        \ [0x04] NAK
    $05 constant OTG_ACK                        \ [0x05] ACK
    $06 constant OTG_NYET                       \ [0x06] NYET
    $07 constant OTG_TXERR                      \ [0x07] TXERR
    $08 constant OTG_BBERR                      \ [0x08] BBERR
    $09 constant OTG_FRMOR                      \ [0x09] FRMOR
    $0a constant OTG_DTERR                      \ [0x0a] DTERR
    $0b constant OTG_BNA                        \ [0x0b] BNA
    $0c constant OTG_XCSXACTERR                 \ [0x0c] XCSXACTERR
    $0d constant OTG_DESCLSTROLL                \ [0x0d] DESCLSTROLL
  [then]


  [ifdef] OTG_OTG_HCINTMSK15_DEF
    \
    \ @brief This register reflects the mask for each channel status described in the previous section.
    \ Address offset: 0x6EC
    \ Reset value: 0x00000000
    \
    $00 constant OTG_XFRCM                      \ [0x00] XFRCM
    $01 constant OTG_CHHM                       \ [0x01] CHHM
    $02 constant OTG_AHBERRM                    \ [0x02] AHBERRM
    $03 constant OTG_STALLM                     \ [0x03] STALLM
    $04 constant OTG_NAKM                       \ [0x04] NAKM
    $05 constant OTG_ACKM                       \ [0x05] ACKM
    $06 constant OTG_NYET                       \ [0x06] NYET
    $07 constant OTG_TXERRM                     \ [0x07] TXERRM
    $08 constant OTG_BBERRM                     \ [0x08] BBERRM
    $09 constant OTG_FRMORM                     \ [0x09] FRMORM
    $0a constant OTG_DTERRM                     \ [0x0a] DTERRM
    $0b constant OTG_BNAMSK                     \ [0x0b] BNAMSK
    $0d constant OTG_DESCLSTROLLMSK             \ [0x0d] DESCLSTROLLMSK
  [then]


  [ifdef] OTG_OTG_HCTSIZ15_DEF
    \
    \ @brief OTG host channel 15 transfer size register
    \ Address offset: 0x6F0
    \ Reset value: 0x00000000
    \
    $00 constant OTG_XFRSIZ                     \ [0x00 : 19] XFRSIZ
    $13 constant OTG_PKTCNT                     \ [0x13 : 10] PKTCNT
    $1d constant OTG_DPID                       \ [0x1d : 2] DPID
  [then]


  [ifdef] OTG_OTG_HCDMA15_DEF
    \
    \ @brief OTG host channel 15 DMA address register in buffer DMA [alternate]
    \ Address offset: 0x6F4
    \ Reset value: 0x00000000
    \
    $00 constant OTG_DMAADDR                    \ [0x00 : 32] DMAADDR
  [then]


  [ifdef] OTG_OTG_HCDMAB15_DEF
    \
    \ @brief OTG host channel-n DMA address buffer register
    \ Address offset: 0x6FC
    \ Reset value: 0x00000000
    \
    $00 constant OTG_HCDMAB                     \ [0x00 : 32] HCDMAB
  [then]


  [ifdef] OTG_OTG_DCFG_DEF
    \
    \ @brief This register configures the core in device mode after power-on or after certain control commands or enumeration. Do not make changes to this register after initial programming.
    \ Address offset: 0x800
    \ Reset value: 0x02200000
    \
    $00 constant OTG_DSPD                       \ [0x00 : 2] DSPD
    $02 constant OTG_NZLSOHSK                   \ [0x02] NZLSOHSK
    $04 constant OTG_DAD                        \ [0x04 : 7] DAD
    $0b constant OTG_PFIVL                      \ [0x0b : 2] PFIVL
    $0e constant OTG_XCVRDLY                    \ [0x0e] XCVRDLY
    $0f constant OTG_ERRATIM                    \ [0x0f] ERRATIM
    $18 constant OTG_PERSCHIVL                  \ [0x18 : 2] PERSCHIVL
  [then]


  [ifdef] OTG_OTG_DCTL_DEF
    \
    \ @brief OTG device control register
    \ Address offset: 0x804
    \ Reset value: 0x00000002
    \
    $00 constant OTG_RWUSIG                     \ [0x00] RWUSIG
    $01 constant OTG_SDIS                       \ [0x01] SDIS
    $02 constant OTG_GINSTS                     \ [0x02] GINSTS
    $03 constant OTG_GONSTS                     \ [0x03] GONSTS
    $04 constant OTG_TCTL                       \ [0x04 : 3] TCTL
    $07 constant OTG_SGINAK                     \ [0x07] SGINAK
    $08 constant OTG_CGINAK                     \ [0x08] CGINAK
    $09 constant OTG_SGONAK                     \ [0x09] SGONAK
    $0a constant OTG_CGONAK                     \ [0x0a] CGONAK
    $0b constant OTG_POPRGDNE                   \ [0x0b] POPRGDNE
    $12 constant OTG_DSBESLRJCT                 \ [0x12] DSBESLRJCT
  [then]


  [ifdef] OTG_OTG_DSTS_DEF
    \
    \ @brief This register indicates the status of the core with respect to USB-related events. It must be read on interrupts from the device all interrupts (OTG_DAINT) register.
    \ Address offset: 0x808
    \ Reset value: 0x00000010
    \
    $00 constant OTG_SUSPSTS                    \ [0x00] SUSPSTS
    $01 constant OTG_ENUMSPD                    \ [0x01 : 2] ENUMSPD
    $03 constant OTG_EERR                       \ [0x03] EERR
    $08 constant OTG_FNSOF                      \ [0x08 : 14] FNSOF
    $16 constant OTG_DEVLNSTS                   \ [0x16 : 2] DEVLNSTS
  [then]


  [ifdef] OTG_OTG_DIEPMSK_DEF
    \
    \ @brief This register works with each of the OTG_DIEPINTx registers for all endpoints to generate an interrupt per IN endpoint. The IN endpoint interrupt for a specific status in the OTG_DIEPINTx register can be masked by writing to the corresponding bit in this register. Status bits are masked by default.
    \ Address offset: 0x810
    \ Reset value: 0x00000000
    \
    $00 constant OTG_XFRCM                      \ [0x00] XFRCM
    $01 constant OTG_EPDM                       \ [0x01] EPDM
    $02 constant OTG_AHBERRM                    \ [0x02] AHBERRM
    $03 constant OTG_TOM                        \ [0x03] TOM
    $04 constant OTG_ITTXFEMSK                  \ [0x04] ITTXFEMSK
    $05 constant OTG_INEPNMM                    \ [0x05] INEPNMM
    $06 constant OTG_INEPNEM                    \ [0x06] INEPNEM
    $08 constant OTG_TXFURM                     \ [0x08] TXFURM
    $09 constant OTG_BNAM                       \ [0x09] BNAM
    $0d constant OTG_NAKM                       \ [0x0d] NAKM
  [then]


  [ifdef] OTG_OTG_DOEPMSK_DEF
    \
    \ @brief This register works with each of the OTG_DOEPINTx registers for all endpoints to generate an interrupt per OUT endpoint. The OUT endpoint interrupt for a specific status in the OTG_DOEPINTx register can be masked by writing into the corresponding bit in this register. Status bits are masked by default.
    \ Address offset: 0x814
    \ Reset value: 0x00000000
    \
    $00 constant OTG_XFRCM                      \ [0x00] XFRCM
    $01 constant OTG_EPDM                       \ [0x01] EPDM
    $02 constant OTG_AHBERRM                    \ [0x02] AHBERRM
    $03 constant OTG_STUPM                      \ [0x03] STUPM
    $04 constant OTG_OTEPDM                     \ [0x04] OTEPDM
    $05 constant OTG_STSPHSRXM                  \ [0x05] STSPHSRXM
    $06 constant OTG_B2BSTUPM                   \ [0x06] B2BSTUPM
    $08 constant OTG_OUTPKTERRM                 \ [0x08] OUTPKTERRM
    $09 constant OTG_BNAM                       \ [0x09] BNAM
    $0c constant OTG_BERRM                      \ [0x0c] BERRM
    $0d constant OTG_NAKMSK                     \ [0x0d] NAKMSK
    $0e constant OTG_NYETMSK                    \ [0x0e] NYETMSK
  [then]


  [ifdef] OTG_OTG_DAINT_DEF
    \
    \ @brief When a significant event occurs on an endpoint, a OTG_DAINT register interrupts the application using the device OUT endpoints interrupt bit or device IN endpoints interrupt bit of the OTG_GINTSTS register (OEPINT or IEPINT in OTG_GINTSTS, respectively). There is one interrupt bit per endpoint, up to a maximum of 16 bits for OUT endpoints and 16 bits for IN endpoints. For a bidirectional endpoint, the corresponding IN and OUT interrupt bits are used. Bits in this register are set and cleared when the application sets and clears bits in the corresponding device endpoint-x interrupt register (OTG_DIEPINTx/OTG_DOEPINTx).
    \ Address offset: 0x818
    \ Reset value: 0x00000000
    \
    $00 constant OTG_IEPINT                     \ [0x00 : 16] IEPINT
    $10 constant OTG_OEPINT                     \ [0x10 : 16] OEPINT
  [then]


  [ifdef] OTG_OTG_DAINTMSK_DEF
    \
    \ @brief The OTG_DAINTMSK register works with the device endpoint interrupt register to interrupt the application when an event occurs on a device endpoint. However, the OTG_DAINT register bit corresponding to that interrupt is still set.
    \ Address offset: 0x81C
    \ Reset value: 0x00000000
    \
    $00 constant OTG_IEPM                       \ [0x00 : 16] IEPM
    $10 constant OTG_OEPM                       \ [0x10 : 16] OEPM
  [then]


  [ifdef] OTG_OTG_DVBUSDIS_DEF
    \
    \ @brief This register specifies the VBUS discharge time after VBUS pulsing during SRP.
    \ Address offset: 0x828
    \ Reset value: 0x000017D7
    \
    $00 constant OTG_VBUSDT                     \ [0x00 : 16] VBUSDT
  [then]


  [ifdef] OTG_OTG_DVBUSPULSE_DEF
    \
    \ @brief This register specifies the VBUS pulsing time during SRP.
    \ Address offset: 0x82C
    \ Reset value: 0x000005B8
    \
    $00 constant OTG_DVBUSP                     \ [0x00 : 16] DVBUSP
  [then]


  [ifdef] OTG_OTG_DTHRCTL_DEF
    \
    \ @brief OTG device threshold control register
    \ Address offset: 0x830
    \ Reset value: 0x00000000
    \
    $00 constant OTG_NONISOTHREN                \ [0x00] NONISOTHREN
    $01 constant OTG_ISOTHREN                   \ [0x01] ISOTHREN
    $02 constant OTG_TXTHRLEN                   \ [0x02 : 9] TXTHRLEN
    $10 constant OTG_RXTHREN                    \ [0x10] RXTHREN
    $11 constant OTG_RXTHRLEN                   \ [0x11 : 9] RXTHRLEN
    $1b constant OTG_ARPEN                      \ [0x1b] ARPEN
  [then]


  [ifdef] OTG_OTG_DIEPEMPMSK_DEF
    \
    \ @brief This register is used to control the IN endpoint FIFO empty interrupt generation (TXFE_OTG_DIEPINTx).
    \ Address offset: 0x834
    \ Reset value: 0x00000000
    \
    $00 constant OTG_INEPTXFEM                  \ [0x00 : 16] INEPTXFEM
  [then]


  [ifdef] OTG_OTG_DEACHINT_DEF
    \
    \ @brief OTG device each endpoint interrupt register
    \ Address offset: 0x838
    \ Reset value: 0x00000000
    \
    $01 constant OTG_IEP1INT                    \ [0x01] IEP1INT
    $11 constant OTG_OEP1INT                    \ [0x11] OEP1INT
  [then]


  [ifdef] OTG_OTG_DEACHINTMSK_DEF
    \
    \ @brief There is one interrupt bit for endpoint 1 IN and one interrupt bit for endpoint 1 OUT.
    \ Address offset: 0x83C
    \ Reset value: 0x00000000
    \
    $01 constant OTG_IEP1INTM                   \ [0x01] IEP1INTM
    $11 constant OTG_OEP1INTM                   \ [0x11] OEP1INTM
  [then]


  [ifdef] OTG_OTG_HS_DIEPEACHMSK1_DEF
    \
    \ @brief This register works with the OTG_DIEPINT1 register to generate a dedicated interrupt OTG_HS_EP1_IN for endpoint #1. The IN endpoint interrupt for a specific status in the OTG_DOEPINT1 register can be masked by writing into the corresponding bit in this register. Status bits are masked by default.
    \ Address offset: 0x844
    \ Reset value: 0x00000000
    \
    $00 constant OTG_XFRCM                      \ [0x00] XFRCM
    $01 constant OTG_EPDM                       \ [0x01] EPDM
    $02 constant OTG_AHBERRM                    \ [0x02] AHBERRM
    $03 constant OTG_TOM                        \ [0x03] TOM
    $04 constant OTG_ITTXFEMSK                  \ [0x04] ITTXFEMSK
    $06 constant OTG_INEPNEM                    \ [0x06] INEPNEM
    $08 constant OTG_TXFURM                     \ [0x08] TXFURM
    $09 constant OTG_BNAM                       \ [0x09] BNAM
    $0d constant OTG_NAKM                       \ [0x0d] NAKM
  [then]


  [ifdef] OTG_OTG_HS_DOEPEACHMSK1_DEF
    \
    \ @brief This register works with the OTG_DOEPINT1 register to generate a dedicated interrupt OTG_HS_EP1_OUT for endpoint #1. The OUT endpoint interrupt for a specific status in the OTG_DOEPINT1 register can be masked by writing into the corresponding bit in this register. Status bits are masked by default.
    \ Address offset: 0x884
    \ Reset value: 0x00000000
    \
    $00 constant OTG_XFRCM                      \ [0x00] XFRCM
    $01 constant OTG_EPDM                       \ [0x01] EPDM
    $02 constant OTG_AHBERRM                    \ [0x02] AHBERRM
    $03 constant OTG_STUPM                      \ [0x03] STUPM
    $04 constant OTG_OTEPDM                     \ [0x04] OTEPDM
    $06 constant OTG_B2BSTUPM                   \ [0x06] B2BSTUPM
    $08 constant OTG_OUTPKTERRM                 \ [0x08] OUTPKTERRM
    $09 constant OTG_BNAM                       \ [0x09] BNAM
    $0c constant OTG_BERRM                      \ [0x0c] BERRM
    $0d constant OTG_NAKMSK                     \ [0x0d] NAKMSK
    $0e constant OTG_NYETMSK                    \ [0x0e] NYETMSK
  [then]


  [ifdef] OTG_OTG_DIEPCTL0_DEF
    \
    \ @brief The application uses this register to control the behavior of each logical endpoint other than endpoint 0.
    \ Address offset: 0x900
    \ Reset value: 0x00000000
    \
    $00 constant OTG_MPSIZ                      \ [0x00 : 11] MPSIZ
    $0f constant OTG_USBAEP                     \ [0x0f] USBAEP
    $10 constant OTG_EONUM_DPIP                 \ [0x10] EONUM_DPIP
    $11 constant OTG_NAKSTS                     \ [0x11] NAKSTS
    $12 constant OTG_EPTYP                      \ [0x12 : 2] EPTYP
    $15 constant OTG_STALL                      \ [0x15] STALL
    $16 constant OTG_TXFNUM                     \ [0x16 : 4] TXFNUM
    $1a constant OTG_CNAK                       \ [0x1a] CNAK
    $1b constant OTG_SNAK                       \ [0x1b] SNAK
    $1c constant OTG_SD0PID_SEVNFRM             \ [0x1c] SD0PID_SEVNFRM
    $1d constant OTG_SODDFRM                    \ [0x1d] SODDFRM
    $1e constant OTG_EPDIS                      \ [0x1e] EPDIS
    $1f constant OTG_EPENA                      \ [0x1f] EPENA
  [then]


  [ifdef] OTG_OTG_DIEPINT0_DEF
    \
    \ @brief This register indicates the status of an endpoint with respect to USB- and AHB-related events. It is shown in Figure724. The application must read this register when the IN endpoints interrupt bit of the core interrupt register (IEPINT in OTG_GINTSTS) is set. Before the application can read this register, it must first read the device all endpoints interrupt (OTG_DAINT) register to get the exact endpoint number for the device endpoint-x interrupt register. The application must clear the appropriate bit in this register to clear the corresponding bits in the OTG_DAINT and OTG_GINTSTS registers.
    \ Address offset: 0x908
    \ Reset value: 0x00000080
    \
    $00 constant OTG_XFRC                       \ [0x00] XFRC
    $01 constant OTG_EPDISD                     \ [0x01] EPDISD
    $02 constant OTG_AHBERR                     \ [0x02] AHBERR
    $03 constant OTG_TOC                        \ [0x03] TOC
    $04 constant OTG_ITTXFE                     \ [0x04] ITTXFE
    $05 constant OTG_INEPNM                     \ [0x05] INEPNM
    $06 constant OTG_INEPNE                     \ [0x06] INEPNE
    $07 constant OTG_TXFE                       \ [0x07] TXFE
    $08 constant OTG_TXFIFOUDRN                 \ [0x08] TXFIFOUDRN
    $09 constant OTG_BNA                        \ [0x09] BNA
    $0b constant OTG_PKTDRPSTS                  \ [0x0b] PKTDRPSTS
    $0d constant OTG_NAK                        \ [0x0d] NAK
  [then]


  [ifdef] OTG_OTG_DIEPTSIZ0_DEF
    \
    \ @brief The application must modify this register before enabling endpoint 0.
    \ Address offset: 0x910
    \ Reset value: 0x00000000
    \
    $00 constant OTG_XFRSIZ                     \ [0x00 : 7] XFRSIZ
    $13 constant OTG_PKTCNT                     \ [0x13 : 2] PKTCNT
  [then]


  [ifdef] OTG_OTG_DIEPDMA0_DEF
    \
    \ @brief OTG device IN endpoint 0 DMA address register
    \ Address offset: 0x914
    \ Reset value: 0x00000000
    \
    $00 constant OTG_DMAADDR                    \ [0x00 : 32] DMAADDR
  [then]


  [ifdef] OTG_OTG_DTXFSTS0_DEF
    \
    \ @brief This read-only register contains the free space information for the device IN endpoint Tx FIFO.
    \ Address offset: 0x918
    \ Reset value: 0x00000200
    \
    $00 constant OTG_INEPTFSAV                  \ [0x00 : 16] INEPTFSAV
  [then]


  [ifdef] OTG_OTG_DIEPCTL1_DEF
    \
    \ @brief The application uses this register to control the behavior of each logical endpoint other than endpoint 0.
    \ Address offset: 0x920
    \ Reset value: 0x00000000
    \
    $00 constant OTG_MPSIZ                      \ [0x00 : 11] MPSIZ
    $0f constant OTG_USBAEP                     \ [0x0f] USBAEP
    $10 constant OTG_EONUM_DPIP                 \ [0x10] EONUM_DPIP
    $11 constant OTG_NAKSTS                     \ [0x11] NAKSTS
    $12 constant OTG_EPTYP                      \ [0x12 : 2] EPTYP
    $15 constant OTG_STALL                      \ [0x15] STALL
    $16 constant OTG_TXFNUM                     \ [0x16 : 4] TXFNUM
    $1a constant OTG_CNAK                       \ [0x1a] CNAK
    $1b constant OTG_SNAK                       \ [0x1b] SNAK
    $1c constant OTG_SD0PID_SEVNFRM             \ [0x1c] SD0PID_SEVNFRM
    $1d constant OTG_SODDFRM                    \ [0x1d] SODDFRM
    $1e constant OTG_EPDIS                      \ [0x1e] EPDIS
    $1f constant OTG_EPENA                      \ [0x1f] EPENA
  [then]


  [ifdef] OTG_OTG_DIEPINT1_DEF
    \
    \ @brief This register indicates the status of an endpoint with respect to USB- and AHB-related events. It is shown in Figure724. The application must read this register when the IN endpoints interrupt bit of the core interrupt register (IEPINT in OTG_GINTSTS) is set. Before the application can read this register, it must first read the device all endpoints interrupt (OTG_DAINT) register to get the exact endpoint number for the device endpoint-x interrupt register. The application must clear the appropriate bit in this register to clear the corresponding bits in the OTG_DAINT and OTG_GINTSTS registers.
    \ Address offset: 0x928
    \ Reset value: 0x00000080
    \
    $00 constant OTG_XFRC                       \ [0x00] XFRC
    $01 constant OTG_EPDISD                     \ [0x01] EPDISD
    $02 constant OTG_AHBERR                     \ [0x02] AHBERR
    $03 constant OTG_TOC                        \ [0x03] TOC
    $04 constant OTG_ITTXFE                     \ [0x04] ITTXFE
    $05 constant OTG_INEPNM                     \ [0x05] INEPNM
    $06 constant OTG_INEPNE                     \ [0x06] INEPNE
    $07 constant OTG_TXFE                       \ [0x07] TXFE
    $08 constant OTG_TXFIFOUDRN                 \ [0x08] TXFIFOUDRN
    $09 constant OTG_BNA                        \ [0x09] BNA
    $0b constant OTG_PKTDRPSTS                  \ [0x0b] PKTDRPSTS
    $0d constant OTG_NAK                        \ [0x0d] NAK
  [then]


  [ifdef] OTG_OTG_DIEPTSIZ1_DEF
    \
    \ @brief The application must modify this register before enabling the endpoint. Once the endpoint is enabled using the endpoint enable bit in the OTG_DIEPCTLx registers (EPENA bit in OTG_DIEPCTLx), the core modifies this register. The application can only read this register once the core has cleared the endpoint enable bit.
    \ Address offset: 0x930
    \ Reset value: 0x00000000
    \
    $00 constant OTG_XFRSIZ                     \ [0x00 : 19] XFRSIZ
    $13 constant OTG_PKTCNT                     \ [0x13 : 10] PKTCNT
    $1d constant OTG_MCNT                       \ [0x1d : 2] MCNT
  [then]


  [ifdef] OTG_OTG_DIEPDMA1_DEF
    \
    \ @brief OTG device IN endpoint 1 DMA address register
    \ Address offset: 0x934
    \ Reset value: 0x00000000
    \
    $00 constant OTG_DMAADDR                    \ [0x00 : 32] DMAADDR
  [then]


  [ifdef] OTG_OTG_DTXFSTS1_DEF
    \
    \ @brief This read-only register contains the free space information for the device IN endpoint Tx FIFO.
    \ Address offset: 0x938
    \ Reset value: 0x00000200
    \
    $00 constant OTG_INEPTFSAV                  \ [0x00 : 16] INEPTFSAV
  [then]


  [ifdef] OTG_OTG_DIEPCTL2_DEF
    \
    \ @brief The application uses this register to control the behavior of each logical endpoint other than endpoint 0.
    \ Address offset: 0x940
    \ Reset value: 0x00000000
    \
    $00 constant OTG_MPSIZ                      \ [0x00 : 11] MPSIZ
    $0f constant OTG_USBAEP                     \ [0x0f] USBAEP
    $10 constant OTG_EONUM_DPIP                 \ [0x10] EONUM_DPIP
    $11 constant OTG_NAKSTS                     \ [0x11] NAKSTS
    $12 constant OTG_EPTYP                      \ [0x12 : 2] EPTYP
    $15 constant OTG_STALL                      \ [0x15] STALL
    $16 constant OTG_TXFNUM                     \ [0x16 : 4] TXFNUM
    $1a constant OTG_CNAK                       \ [0x1a] CNAK
    $1b constant OTG_SNAK                       \ [0x1b] SNAK
    $1c constant OTG_SD0PID_SEVNFRM             \ [0x1c] SD0PID_SEVNFRM
    $1d constant OTG_SODDFRM                    \ [0x1d] SODDFRM
    $1e constant OTG_EPDIS                      \ [0x1e] EPDIS
    $1f constant OTG_EPENA                      \ [0x1f] EPENA
  [then]


  [ifdef] OTG_OTG_DIEPINT2_DEF
    \
    \ @brief This register indicates the status of an endpoint with respect to USB- and AHB-related events. It is shown in Figure724. The application must read this register when the IN endpoints interrupt bit of the core interrupt register (IEPINT in OTG_GINTSTS) is set. Before the application can read this register, it must first read the device all endpoints interrupt (OTG_DAINT) register to get the exact endpoint number for the device endpoint-x interrupt register. The application must clear the appropriate bit in this register to clear the corresponding bits in the OTG_DAINT and OTG_GINTSTS registers.
    \ Address offset: 0x948
    \ Reset value: 0x00000080
    \
    $00 constant OTG_XFRC                       \ [0x00] XFRC
    $01 constant OTG_EPDISD                     \ [0x01] EPDISD
    $02 constant OTG_AHBERR                     \ [0x02] AHBERR
    $03 constant OTG_TOC                        \ [0x03] TOC
    $04 constant OTG_ITTXFE                     \ [0x04] ITTXFE
    $05 constant OTG_INEPNM                     \ [0x05] INEPNM
    $06 constant OTG_INEPNE                     \ [0x06] INEPNE
    $07 constant OTG_TXFE                       \ [0x07] TXFE
    $08 constant OTG_TXFIFOUDRN                 \ [0x08] TXFIFOUDRN
    $09 constant OTG_BNA                        \ [0x09] BNA
    $0b constant OTG_PKTDRPSTS                  \ [0x0b] PKTDRPSTS
    $0d constant OTG_NAK                        \ [0x0d] NAK
  [then]


  [ifdef] OTG_OTG_DIEPTSIZ2_DEF
    \
    \ @brief The application must modify this register before enabling the endpoint. Once the endpoint is enabled using the endpoint enable bit in the OTG_DIEPCTLx registers (EPENA bit in OTG_DIEPCTLx), the core modifies this register. The application can only read this register once the core has cleared the endpoint enable bit.
    \ Address offset: 0x950
    \ Reset value: 0x00000000
    \
    $00 constant OTG_XFRSIZ                     \ [0x00 : 19] XFRSIZ
    $13 constant OTG_PKTCNT                     \ [0x13 : 10] PKTCNT
    $1d constant OTG_MCNT                       \ [0x1d : 2] MCNT
  [then]


  [ifdef] OTG_OTG_DIEPDMA2_DEF
    \
    \ @brief OTG device IN endpoint 2 DMA address register
    \ Address offset: 0x954
    \ Reset value: 0x00000000
    \
    $00 constant OTG_DMAADDR                    \ [0x00 : 32] DMAADDR
  [then]


  [ifdef] OTG_OTG_DTXFSTS2_DEF
    \
    \ @brief This read-only register contains the free space information for the device IN endpoint Tx FIFO.
    \ Address offset: 0x958
    \ Reset value: 0x00000200
    \
    $00 constant OTG_INEPTFSAV                  \ [0x00 : 16] INEPTFSAV
  [then]


  [ifdef] OTG_OTG_DIEPCTL3_DEF
    \
    \ @brief The application uses this register to control the behavior of each logical endpoint other than endpoint 0.
    \ Address offset: 0x960
    \ Reset value: 0x00000000
    \
    $00 constant OTG_MPSIZ                      \ [0x00 : 11] MPSIZ
    $0f constant OTG_USBAEP                     \ [0x0f] USBAEP
    $10 constant OTG_EONUM_DPIP                 \ [0x10] EONUM_DPIP
    $11 constant OTG_NAKSTS                     \ [0x11] NAKSTS
    $12 constant OTG_EPTYP                      \ [0x12 : 2] EPTYP
    $15 constant OTG_STALL                      \ [0x15] STALL
    $16 constant OTG_TXFNUM                     \ [0x16 : 4] TXFNUM
    $1a constant OTG_CNAK                       \ [0x1a] CNAK
    $1b constant OTG_SNAK                       \ [0x1b] SNAK
    $1c constant OTG_SD0PID_SEVNFRM             \ [0x1c] SD0PID_SEVNFRM
    $1d constant OTG_SODDFRM                    \ [0x1d] SODDFRM
    $1e constant OTG_EPDIS                      \ [0x1e] EPDIS
    $1f constant OTG_EPENA                      \ [0x1f] EPENA
  [then]


  [ifdef] OTG_OTG_DIEPINT3_DEF
    \
    \ @brief This register indicates the status of an endpoint with respect to USB- and AHB-related events. It is shown in Figure724. The application must read this register when the IN endpoints interrupt bit of the core interrupt register (IEPINT in OTG_GINTSTS) is set. Before the application can read this register, it must first read the device all endpoints interrupt (OTG_DAINT) register to get the exact endpoint number for the device endpoint-x interrupt register. The application must clear the appropriate bit in this register to clear the corresponding bits in the OTG_DAINT and OTG_GINTSTS registers.
    \ Address offset: 0x968
    \ Reset value: 0x00000080
    \
    $00 constant OTG_XFRC                       \ [0x00] XFRC
    $01 constant OTG_EPDISD                     \ [0x01] EPDISD
    $02 constant OTG_AHBERR                     \ [0x02] AHBERR
    $03 constant OTG_TOC                        \ [0x03] TOC
    $04 constant OTG_ITTXFE                     \ [0x04] ITTXFE
    $05 constant OTG_INEPNM                     \ [0x05] INEPNM
    $06 constant OTG_INEPNE                     \ [0x06] INEPNE
    $07 constant OTG_TXFE                       \ [0x07] TXFE
    $08 constant OTG_TXFIFOUDRN                 \ [0x08] TXFIFOUDRN
    $09 constant OTG_BNA                        \ [0x09] BNA
    $0b constant OTG_PKTDRPSTS                  \ [0x0b] PKTDRPSTS
    $0d constant OTG_NAK                        \ [0x0d] NAK
  [then]


  [ifdef] OTG_OTG_DIEPTSIZ3_DEF
    \
    \ @brief The application must modify this register before enabling the endpoint. Once the endpoint is enabled using the endpoint enable bit in the OTG_DIEPCTLx registers (EPENA bit in OTG_DIEPCTLx), the core modifies this register. The application can only read this register once the core has cleared the endpoint enable bit.
    \ Address offset: 0x970
    \ Reset value: 0x00000000
    \
    $00 constant OTG_XFRSIZ                     \ [0x00 : 19] XFRSIZ
    $13 constant OTG_PKTCNT                     \ [0x13 : 10] PKTCNT
    $1d constant OTG_MCNT                       \ [0x1d : 2] MCNT
  [then]


  [ifdef] OTG_OTG_DIEPDMA3_DEF
    \
    \ @brief OTG device IN endpoint 3 DMA address register
    \ Address offset: 0x974
    \ Reset value: 0x00000000
    \
    $00 constant OTG_DMAADDR                    \ [0x00 : 32] DMAADDR
  [then]


  [ifdef] OTG_OTG_DTXFSTS3_DEF
    \
    \ @brief This read-only register contains the free space information for the device IN endpoint Tx FIFO.
    \ Address offset: 0x978
    \ Reset value: 0x00000200
    \
    $00 constant OTG_INEPTFSAV                  \ [0x00 : 16] INEPTFSAV
  [then]


  [ifdef] OTG_OTG_DIEPCTL4_DEF
    \
    \ @brief The application uses this register to control the behavior of each logical endpoint other than endpoint 0.
    \ Address offset: 0x980
    \ Reset value: 0x00000000
    \
    $00 constant OTG_MPSIZ                      \ [0x00 : 11] MPSIZ
    $0f constant OTG_USBAEP                     \ [0x0f] USBAEP
    $10 constant OTG_EONUM_DPIP                 \ [0x10] EONUM_DPIP
    $11 constant OTG_NAKSTS                     \ [0x11] NAKSTS
    $12 constant OTG_EPTYP                      \ [0x12 : 2] EPTYP
    $15 constant OTG_STALL                      \ [0x15] STALL
    $16 constant OTG_TXFNUM                     \ [0x16 : 4] TXFNUM
    $1a constant OTG_CNAK                       \ [0x1a] CNAK
    $1b constant OTG_SNAK                       \ [0x1b] SNAK
    $1c constant OTG_SD0PID_SEVNFRM             \ [0x1c] SD0PID_SEVNFRM
    $1d constant OTG_SODDFRM                    \ [0x1d] SODDFRM
    $1e constant OTG_EPDIS                      \ [0x1e] EPDIS
    $1f constant OTG_EPENA                      \ [0x1f] EPENA
  [then]


  [ifdef] OTG_OTG_DIEPINT4_DEF
    \
    \ @brief This register indicates the status of an endpoint with respect to USB- and AHB-related events. It is shown in Figure724. The application must read this register when the IN endpoints interrupt bit of the core interrupt register (IEPINT in OTG_GINTSTS) is set. Before the application can read this register, it must first read the device all endpoints interrupt (OTG_DAINT) register to get the exact endpoint number for the device endpoint-x interrupt register. The application must clear the appropriate bit in this register to clear the corresponding bits in the OTG_DAINT and OTG_GINTSTS registers.
    \ Address offset: 0x988
    \ Reset value: 0x00000080
    \
    $00 constant OTG_XFRC                       \ [0x00] XFRC
    $01 constant OTG_EPDISD                     \ [0x01] EPDISD
    $02 constant OTG_AHBERR                     \ [0x02] AHBERR
    $03 constant OTG_TOC                        \ [0x03] TOC
    $04 constant OTG_ITTXFE                     \ [0x04] ITTXFE
    $05 constant OTG_INEPNM                     \ [0x05] INEPNM
    $06 constant OTG_INEPNE                     \ [0x06] INEPNE
    $07 constant OTG_TXFE                       \ [0x07] TXFE
    $08 constant OTG_TXFIFOUDRN                 \ [0x08] TXFIFOUDRN
    $09 constant OTG_BNA                        \ [0x09] BNA
    $0b constant OTG_PKTDRPSTS                  \ [0x0b] PKTDRPSTS
    $0d constant OTG_NAK                        \ [0x0d] NAK
  [then]


  [ifdef] OTG_OTG_DIEPTSIZ4_DEF
    \
    \ @brief The application must modify this register before enabling the endpoint. Once the endpoint is enabled using the endpoint enable bit in the OTG_DIEPCTLx registers (EPENA bit in OTG_DIEPCTLx), the core modifies this register. The application can only read this register once the core has cleared the endpoint enable bit.
    \ Address offset: 0x990
    \ Reset value: 0x00000000
    \
    $00 constant OTG_XFRSIZ                     \ [0x00 : 19] XFRSIZ
    $13 constant OTG_PKTCNT                     \ [0x13 : 10] PKTCNT
    $1d constant OTG_MCNT                       \ [0x1d : 2] MCNT
  [then]


  [ifdef] OTG_OTG_DIEPDMA4_DEF
    \
    \ @brief OTG device IN endpoint 4 DMA address register
    \ Address offset: 0x994
    \ Reset value: 0x00000000
    \
    $00 constant OTG_DMAADDR                    \ [0x00 : 32] DMAADDR
  [then]


  [ifdef] OTG_OTG_DTXFSTS4_DEF
    \
    \ @brief This read-only register contains the free space information for the device IN endpoint Tx FIFO.
    \ Address offset: 0x998
    \ Reset value: 0x00000200
    \
    $00 constant OTG_INEPTFSAV                  \ [0x00 : 16] INEPTFSAV
  [then]


  [ifdef] OTG_OTG_DIEPCTL5_DEF
    \
    \ @brief The application uses this register to control the behavior of each logical endpoint other than endpoint 0.
    \ Address offset: 0x9A0
    \ Reset value: 0x00000000
    \
    $00 constant OTG_MPSIZ                      \ [0x00 : 11] MPSIZ
    $0f constant OTG_USBAEP                     \ [0x0f] USBAEP
    $10 constant OTG_EONUM_DPIP                 \ [0x10] EONUM_DPIP
    $11 constant OTG_NAKSTS                     \ [0x11] NAKSTS
    $12 constant OTG_EPTYP                      \ [0x12 : 2] EPTYP
    $15 constant OTG_STALL                      \ [0x15] STALL
    $16 constant OTG_TXFNUM                     \ [0x16 : 4] TXFNUM
    $1a constant OTG_CNAK                       \ [0x1a] CNAK
    $1b constant OTG_SNAK                       \ [0x1b] SNAK
    $1c constant OTG_SD0PID_SEVNFRM             \ [0x1c] SD0PID_SEVNFRM
    $1d constant OTG_SODDFRM                    \ [0x1d] SODDFRM
    $1e constant OTG_EPDIS                      \ [0x1e] EPDIS
    $1f constant OTG_EPENA                      \ [0x1f] EPENA
  [then]


  [ifdef] OTG_OTG_DIEPINT5_DEF
    \
    \ @brief This register indicates the status of an endpoint with respect to USB- and AHB-related events. It is shown in Figure724. The application must read this register when the IN endpoints interrupt bit of the core interrupt register (IEPINT in OTG_GINTSTS) is set. Before the application can read this register, it must first read the device all endpoints interrupt (OTG_DAINT) register to get the exact endpoint number for the device endpoint-x interrupt register. The application must clear the appropriate bit in this register to clear the corresponding bits in the OTG_DAINT and OTG_GINTSTS registers.
    \ Address offset: 0x9A8
    \ Reset value: 0x00000080
    \
    $00 constant OTG_XFRC                       \ [0x00] XFRC
    $01 constant OTG_EPDISD                     \ [0x01] EPDISD
    $02 constant OTG_AHBERR                     \ [0x02] AHBERR
    $03 constant OTG_TOC                        \ [0x03] TOC
    $04 constant OTG_ITTXFE                     \ [0x04] ITTXFE
    $05 constant OTG_INEPNM                     \ [0x05] INEPNM
    $06 constant OTG_INEPNE                     \ [0x06] INEPNE
    $07 constant OTG_TXFE                       \ [0x07] TXFE
    $08 constant OTG_TXFIFOUDRN                 \ [0x08] TXFIFOUDRN
    $09 constant OTG_BNA                        \ [0x09] BNA
    $0b constant OTG_PKTDRPSTS                  \ [0x0b] PKTDRPSTS
    $0d constant OTG_NAK                        \ [0x0d] NAK
  [then]


  [ifdef] OTG_OTG_DIEPTSIZ5_DEF
    \
    \ @brief The application must modify this register before enabling the endpoint. Once the endpoint is enabled using the endpoint enable bit in the OTG_DIEPCTLx registers (EPENA bit in OTG_DIEPCTLx), the core modifies this register. The application can only read this register once the core has cleared the endpoint enable bit.
    \ Address offset: 0x9B0
    \ Reset value: 0x00000000
    \
    $00 constant OTG_XFRSIZ                     \ [0x00 : 19] XFRSIZ
    $13 constant OTG_PKTCNT                     \ [0x13 : 10] PKTCNT
    $1d constant OTG_MCNT                       \ [0x1d : 2] MCNT
  [then]


  [ifdef] OTG_OTG_DIEPDMA5_DEF
    \
    \ @brief OTG device IN endpoint 5 DMA address register
    \ Address offset: 0x9B4
    \ Reset value: 0x00000000
    \
    $00 constant OTG_DMAADDR                    \ [0x00 : 32] DMAADDR
  [then]


  [ifdef] OTG_OTG_DTXFSTS5_DEF
    \
    \ @brief This read-only register contains the free space information for the device IN endpoint Tx FIFO.
    \ Address offset: 0x9B8
    \ Reset value: 0x00000200
    \
    $00 constant OTG_INEPTFSAV                  \ [0x00 : 16] INEPTFSAV
  [then]


  [ifdef] OTG_OTG_DIEPCTL6_DEF
    \
    \ @brief The application uses this register to control the behavior of each logical endpoint other than endpoint 0.
    \ Address offset: 0x9C0
    \ Reset value: 0x00000000
    \
    $00 constant OTG_MPSIZ                      \ [0x00 : 11] MPSIZ
    $0f constant OTG_USBAEP                     \ [0x0f] USBAEP
    $10 constant OTG_EONUM_DPIP                 \ [0x10] EONUM_DPIP
    $11 constant OTG_NAKSTS                     \ [0x11] NAKSTS
    $12 constant OTG_EPTYP                      \ [0x12 : 2] EPTYP
    $15 constant OTG_STALL                      \ [0x15] STALL
    $16 constant OTG_TXFNUM                     \ [0x16 : 4] TXFNUM
    $1a constant OTG_CNAK                       \ [0x1a] CNAK
    $1b constant OTG_SNAK                       \ [0x1b] SNAK
    $1c constant OTG_SD0PID_SEVNFRM             \ [0x1c] SD0PID_SEVNFRM
    $1d constant OTG_SODDFRM                    \ [0x1d] SODDFRM
    $1e constant OTG_EPDIS                      \ [0x1e] EPDIS
    $1f constant OTG_EPENA                      \ [0x1f] EPENA
  [then]


  [ifdef] OTG_OTG_DIEPINT6_DEF
    \
    \ @brief This register indicates the status of an endpoint with respect to USB- and AHB-related events. It is shown in Figure724. The application must read this register when the IN endpoints interrupt bit of the core interrupt register (IEPINT in OTG_GINTSTS) is set. Before the application can read this register, it must first read the device all endpoints interrupt (OTG_DAINT) register to get the exact endpoint number for the device endpoint-x interrupt register. The application must clear the appropriate bit in this register to clear the corresponding bits in the OTG_DAINT and OTG_GINTSTS registers.
    \ Address offset: 0x9C8
    \ Reset value: 0x00000080
    \
    $00 constant OTG_XFRC                       \ [0x00] XFRC
    $01 constant OTG_EPDISD                     \ [0x01] EPDISD
    $02 constant OTG_AHBERR                     \ [0x02] AHBERR
    $03 constant OTG_TOC                        \ [0x03] TOC
    $04 constant OTG_ITTXFE                     \ [0x04] ITTXFE
    $05 constant OTG_INEPNM                     \ [0x05] INEPNM
    $06 constant OTG_INEPNE                     \ [0x06] INEPNE
    $07 constant OTG_TXFE                       \ [0x07] TXFE
    $08 constant OTG_TXFIFOUDRN                 \ [0x08] TXFIFOUDRN
    $09 constant OTG_BNA                        \ [0x09] BNA
    $0b constant OTG_PKTDRPSTS                  \ [0x0b] PKTDRPSTS
    $0d constant OTG_NAK                        \ [0x0d] NAK
  [then]


  [ifdef] OTG_OTG_DIEPTSIZ6_DEF
    \
    \ @brief The application must modify this register before enabling the endpoint. Once the endpoint is enabled using the endpoint enable bit in the OTG_DIEPCTLx registers (EPENA bit in OTG_DIEPCTLx), the core modifies this register. The application can only read this register once the core has cleared the endpoint enable bit.
    \ Address offset: 0x9D0
    \ Reset value: 0x00000000
    \
    $00 constant OTG_XFRSIZ                     \ [0x00 : 19] XFRSIZ
    $13 constant OTG_PKTCNT                     \ [0x13 : 10] PKTCNT
    $1d constant OTG_MCNT                       \ [0x1d : 2] MCNT
  [then]


  [ifdef] OTG_OTG_DIEPDMA6_DEF
    \
    \ @brief OTG device IN endpoint 6 DMA address register
    \ Address offset: 0x9D4
    \ Reset value: 0x00000000
    \
    $00 constant OTG_DMAADDR                    \ [0x00 : 32] DMAADDR
  [then]


  [ifdef] OTG_OTG_DTXFSTS6_DEF
    \
    \ @brief This read-only register contains the free space information for the device IN endpoint Tx FIFO.
    \ Address offset: 0x9D8
    \ Reset value: 0x00000200
    \
    $00 constant OTG_INEPTFSAV                  \ [0x00 : 16] INEPTFSAV
  [then]


  [ifdef] OTG_OTG_DIEPCTL7_DEF
    \
    \ @brief The application uses this register to control the behavior of each logical endpoint other than endpoint 0.
    \ Address offset: 0x9E0
    \ Reset value: 0x00000000
    \
    $00 constant OTG_MPSIZ                      \ [0x00 : 11] MPSIZ
    $0f constant OTG_USBAEP                     \ [0x0f] USBAEP
    $10 constant OTG_EONUM_DPIP                 \ [0x10] EONUM_DPIP
    $11 constant OTG_NAKSTS                     \ [0x11] NAKSTS
    $12 constant OTG_EPTYP                      \ [0x12 : 2] EPTYP
    $15 constant OTG_STALL                      \ [0x15] STALL
    $16 constant OTG_TXFNUM                     \ [0x16 : 4] TXFNUM
    $1a constant OTG_CNAK                       \ [0x1a] CNAK
    $1b constant OTG_SNAK                       \ [0x1b] SNAK
    $1c constant OTG_SD0PID_SEVNFRM             \ [0x1c] SD0PID_SEVNFRM
    $1d constant OTG_SODDFRM                    \ [0x1d] SODDFRM
    $1e constant OTG_EPDIS                      \ [0x1e] EPDIS
    $1f constant OTG_EPENA                      \ [0x1f] EPENA
  [then]


  [ifdef] OTG_OTG_DIEPINT7_DEF
    \
    \ @brief This register indicates the status of an endpoint with respect to USB- and AHB-related events. It is shown in Figure724. The application must read this register when the IN endpoints interrupt bit of the core interrupt register (IEPINT in OTG_GINTSTS) is set. Before the application can read this register, it must first read the device all endpoints interrupt (OTG_DAINT) register to get the exact endpoint number for the device endpoint-x interrupt register. The application must clear the appropriate bit in this register to clear the corresponding bits in the OTG_DAINT and OTG_GINTSTS registers.
    \ Address offset: 0x9E8
    \ Reset value: 0x00000080
    \
    $00 constant OTG_XFRC                       \ [0x00] XFRC
    $01 constant OTG_EPDISD                     \ [0x01] EPDISD
    $02 constant OTG_AHBERR                     \ [0x02] AHBERR
    $03 constant OTG_TOC                        \ [0x03] TOC
    $04 constant OTG_ITTXFE                     \ [0x04] ITTXFE
    $05 constant OTG_INEPNM                     \ [0x05] INEPNM
    $06 constant OTG_INEPNE                     \ [0x06] INEPNE
    $07 constant OTG_TXFE                       \ [0x07] TXFE
    $08 constant OTG_TXFIFOUDRN                 \ [0x08] TXFIFOUDRN
    $09 constant OTG_BNA                        \ [0x09] BNA
    $0b constant OTG_PKTDRPSTS                  \ [0x0b] PKTDRPSTS
    $0d constant OTG_NAK                        \ [0x0d] NAK
  [then]


  [ifdef] OTG_OTG_DIEPTSIZ7_DEF
    \
    \ @brief The application must modify this register before enabling the endpoint. Once the endpoint is enabled using the endpoint enable bit in the OTG_DIEPCTLx registers (EPENA bit in OTG_DIEPCTLx), the core modifies this register. The application can only read this register once the core has cleared the endpoint enable bit.
    \ Address offset: 0x9F0
    \ Reset value: 0x00000000
    \
    $00 constant OTG_XFRSIZ                     \ [0x00 : 19] XFRSIZ
    $13 constant OTG_PKTCNT                     \ [0x13 : 10] PKTCNT
    $1d constant OTG_MCNT                       \ [0x1d : 2] MCNT
  [then]


  [ifdef] OTG_OTG_DIEPDMA7_DEF
    \
    \ @brief OTG device IN endpoint 7 DMA address register
    \ Address offset: 0x9F4
    \ Reset value: 0x00000000
    \
    $00 constant OTG_DMAADDR                    \ [0x00 : 32] DMAADDR
  [then]


  [ifdef] OTG_OTG_DTXFSTS7_DEF
    \
    \ @brief This read-only register contains the free space information for the device IN endpoint Tx FIFO.
    \ Address offset: 0x9F8
    \ Reset value: 0x00000200
    \
    $00 constant OTG_INEPTFSAV                  \ [0x00 : 16] INEPTFSAV
  [then]


  [ifdef] OTG_OTG_DIEPCTL8_DEF
    \
    \ @brief The application uses this register to control the behavior of each logical endpoint other than endpoint 0.
    \ Address offset: 0xA00
    \ Reset value: 0x00000000
    \
    $00 constant OTG_MPSIZ                      \ [0x00 : 11] MPSIZ
    $0f constant OTG_USBAEP                     \ [0x0f] USBAEP
    $10 constant OTG_EONUM_DPIP                 \ [0x10] EONUM_DPIP
    $11 constant OTG_NAKSTS                     \ [0x11] NAKSTS
    $12 constant OTG_EPTYP                      \ [0x12 : 2] EPTYP
    $15 constant OTG_STALL                      \ [0x15] STALL
    $16 constant OTG_TXFNUM                     \ [0x16 : 4] TXFNUM
    $1a constant OTG_CNAK                       \ [0x1a] CNAK
    $1b constant OTG_SNAK                       \ [0x1b] SNAK
    $1c constant OTG_SD0PID_SEVNFRM             \ [0x1c] SD0PID_SEVNFRM
    $1d constant OTG_SODDFRM                    \ [0x1d] SODDFRM
    $1e constant OTG_EPDIS                      \ [0x1e] EPDIS
    $1f constant OTG_EPENA                      \ [0x1f] EPENA
  [then]


  [ifdef] OTG_OTG_DIEPINT8_DEF
    \
    \ @brief This register indicates the status of an endpoint with respect to USB- and AHB-related events. It is shown in Figure724. The application must read this register when the IN endpoints interrupt bit of the core interrupt register (IEPINT in OTG_GINTSTS) is set. Before the application can read this register, it must first read the device all endpoints interrupt (OTG_DAINT) register to get the exact endpoint number for the device endpoint-x interrupt register. The application must clear the appropriate bit in this register to clear the corresponding bits in the OTG_DAINT and OTG_GINTSTS registers.
    \ Address offset: 0xA08
    \ Reset value: 0x00000080
    \
    $00 constant OTG_XFRC                       \ [0x00] XFRC
    $01 constant OTG_EPDISD                     \ [0x01] EPDISD
    $02 constant OTG_AHBERR                     \ [0x02] AHBERR
    $03 constant OTG_TOC                        \ [0x03] TOC
    $04 constant OTG_ITTXFE                     \ [0x04] ITTXFE
    $05 constant OTG_INEPNM                     \ [0x05] INEPNM
    $06 constant OTG_INEPNE                     \ [0x06] INEPNE
    $07 constant OTG_TXFE                       \ [0x07] TXFE
    $08 constant OTG_TXFIFOUDRN                 \ [0x08] TXFIFOUDRN
    $09 constant OTG_BNA                        \ [0x09] BNA
    $0b constant OTG_PKTDRPSTS                  \ [0x0b] PKTDRPSTS
    $0d constant OTG_NAK                        \ [0x0d] NAK
  [then]


  [ifdef] OTG_OTG_DIEPTSIZ8_DEF
    \
    \ @brief The application must modify this register before enabling the endpoint. Once the endpoint is enabled using the endpoint enable bit in the OTG_DIEPCTLx registers (EPENA bit in OTG_DIEPCTLx), the core modifies this register. The application can only read this register once the core has cleared the endpoint enable bit.
    \ Address offset: 0xA10
    \ Reset value: 0x00000000
    \
    $00 constant OTG_XFRSIZ                     \ [0x00 : 19] XFRSIZ
    $13 constant OTG_PKTCNT                     \ [0x13 : 10] PKTCNT
    $1d constant OTG_MCNT                       \ [0x1d : 2] MCNT
  [then]


  [ifdef] OTG_OTG_DIEPDMA8_DEF
    \
    \ @brief OTG device IN endpoint 8 DMA address register
    \ Address offset: 0xA14
    \ Reset value: 0x00000000
    \
    $00 constant OTG_DMAADDR                    \ [0x00 : 32] DMAADDR
  [then]


  [ifdef] OTG_OTG_DTXFSTS8_DEF
    \
    \ @brief This read-only register contains the free space information for the device IN endpoint Tx FIFO.
    \ Address offset: 0xA18
    \ Reset value: 0x00000200
    \
    $00 constant OTG_INEPTFSAV                  \ [0x00 : 16] INEPTFSAV
  [then]


  [ifdef] OTG_OTG_DOEPCTL0_DEF
    \
    \ @brief This section describes the OTG_DOEPCTL0 register.
    \ Address offset: 0xB00
    \ Reset value: 0x00008000
    \
    $00 constant OTG_MPSIZ                      \ [0x00 : 2] MPSIZ
    $0f constant OTG_USBAEP                     \ [0x0f] USBAEP
    $11 constant OTG_NAKSTS                     \ [0x11] NAKSTS
    $12 constant OTG_EPTYP                      \ [0x12 : 2] EPTYP
    $14 constant OTG_SNPM                       \ [0x14] SNPM
    $15 constant OTG_STALL                      \ [0x15] STALL
    $1a constant OTG_CNAK                       \ [0x1a] CNAK
    $1b constant OTG_SNAK                       \ [0x1b] SNAK
    $1e constant OTG_EPDIS                      \ [0x1e] EPDIS
    $1f constant OTG_EPENA                      \ [0x1f] EPENA
  [then]


  [ifdef] OTG_OTG_DOEPINT0_DEF
    \
    \ @brief This register indicates the status of an endpoint with respect to USB- and AHB-related events. It is shown in Figure724. The application must read this register when the OUT endpoints interrupt bit of the OTG_GINTSTS register (OEPINT bit in OTG_GINTSTS) is set. Before the application can read this register, it must first read the OTG_DAINT register to get the exact endpoint number for the OTG_DOEPINTx register. The application must clear the appropriate bit in this register to clear the corresponding bits in the OTG_DAINT and OTG_GINTSTS registers.
    \ Address offset: 0xB08
    \ Reset value: 0x00000080
    \
    $00 constant OTG_XFRC                       \ [0x00] XFRC
    $01 constant OTG_EPDISD                     \ [0x01] EPDISD
    $02 constant OTG_AHBERR                     \ [0x02] AHBERR
    $03 constant OTG_STUP                       \ [0x03] STUP
    $04 constant OTG_OTEPDIS                    \ [0x04] OTEPDIS
    $05 constant OTG_STSPHSRX                   \ [0x05] STSPHSRX
    $06 constant OTG_B2BSTUP                    \ [0x06] B2BSTUP
    $08 constant OTG_OUTPKTERR                  \ [0x08] OUTPKTERR
    $09 constant OTG_BNA                        \ [0x09] BNA
    $0c constant OTG_BERR                       \ [0x0c] BERR
    $0d constant OTG_NAK                        \ [0x0d] NAK
    $0e constant OTG_NYET                       \ [0x0e] NYET
    $0f constant OTG_STPKTRX                    \ [0x0f] STPKTRX
  [then]


  [ifdef] OTG_OTG_DOEPTSIZ0_DEF
    \
    \ @brief The application must modify this register before enabling endpoint 0.
    \ Address offset: 0xB10
    \ Reset value: 0x00000000
    \
    $00 constant OTG_XFRSIZ                     \ [0x00 : 7] XFRSIZ
    $13 constant OTG_PKTCNT                     \ [0x13] PKTCNT
    $1d constant OTG_STUPCNT                    \ [0x1d : 2] STUPCNT
  [then]


  [ifdef] OTG_OTG_DOEPDMA0_DEF
    \
    \ @brief OTG device OUT endpoint 0 DMA address register
    \ Address offset: 0xB14
    \ Reset value: 0x00000000
    \
    $00 constant OTG_DMAADDR                    \ [0x00 : 32] DMAADDR
  [then]


  [ifdef] OTG_OTG_DOEPCTL1_DEF
    \
    \ @brief The application uses this register to control the behavior of each logical endpoint other than endpoint 0.
    \ Address offset: 0xB20
    \ Reset value: 0x00000000
    \
    $00 constant OTG_MPSIZ                      \ [0x00 : 11] MPSIZ
    $0f constant OTG_USBAEP                     \ [0x0f] USBAEP
    $10 constant OTG_EONUM_DPIP                 \ [0x10] EONUM_DPIP
    $11 constant OTG_NAKSTS                     \ [0x11] NAKSTS
    $12 constant OTG_EPTYP                      \ [0x12 : 2] EPTYP
    $14 constant OTG_SNPM                       \ [0x14] SNPM
    $15 constant OTG_STALL                      \ [0x15] STALL
    $1a constant OTG_CNAK                       \ [0x1a] CNAK
    $1b constant OTG_SNAK                       \ [0x1b] SNAK
    $1c constant OTG_SD0PID_SEVNFRM             \ [0x1c] SD0PID_SEVNFRM
    $1d constant OTG_SD1PID_SODDFRM             \ [0x1d] SD1PID_SODDFRM
    $1e constant OTG_EPDIS                      \ [0x1e] EPDIS
    $1f constant OTG_EPENA                      \ [0x1f] EPENA
  [then]


  [ifdef] OTG_OTG_DOEPINT1_DEF
    \
    \ @brief This register indicates the status of an endpoint with respect to USB- and AHB-related events. It is shown in Figure724. The application must read this register when the OUT endpoints interrupt bit of the OTG_GINTSTS register (OEPINT bit in OTG_GINTSTS) is set. Before the application can read this register, it must first read the OTG_DAINT register to get the exact endpoint number for the OTG_DOEPINTx register. The application must clear the appropriate bit in this register to clear the corresponding bits in the OTG_DAINT and OTG_GINTSTS registers.
    \ Address offset: 0xB28
    \ Reset value: 0x00000080
    \
    $00 constant OTG_XFRC                       \ [0x00] XFRC
    $01 constant OTG_EPDISD                     \ [0x01] EPDISD
    $02 constant OTG_AHBERR                     \ [0x02] AHBERR
    $03 constant OTG_STUP                       \ [0x03] STUP
    $04 constant OTG_OTEPDIS                    \ [0x04] OTEPDIS
    $05 constant OTG_STSPHSRX                   \ [0x05] STSPHSRX
    $06 constant OTG_B2BSTUP                    \ [0x06] B2BSTUP
    $08 constant OTG_OUTPKTERR                  \ [0x08] OUTPKTERR
    $09 constant OTG_BNA                        \ [0x09] BNA
    $0c constant OTG_BERR                       \ [0x0c] BERR
    $0d constant OTG_NAK                        \ [0x0d] NAK
    $0e constant OTG_NYET                       \ [0x0e] NYET
    $0f constant OTG_STPKTRX                    \ [0x0f] STPKTRX
  [then]


  [ifdef] OTG_OTG_DOEPTSIZ1_DEF
    \
    \ @brief The application must modify this register before enabling the endpoint. Once the endpoint is enabled using endpoint enable bit of the OTG_DOEPCTLx registers (EPENA bit in OTG_DOEPCTLx), the core modifies this register. The application can only read this register once the core has cleared the endpoint enable bit.
    \ Address offset: 0xB30
    \ Reset value: 0x00000000
    \
    $00 constant OTG_XFRSIZ                     \ [0x00 : 19] XFRSIZ
    $13 constant OTG_PKTCNT                     \ [0x13 : 10] PKTCNT
    $1d constant OTG_RXDPID_STUPCNT             \ [0x1d : 2] RXDPID_STUPCNT
  [then]


  [ifdef] OTG_OTG_DOEPDMA1_DEF
    \
    \ @brief OTG device OUT endpoint 1 DMA address register
    \ Address offset: 0xB34
    \ Reset value: 0x00000000
    \
    $00 constant OTG_DMAADDR                    \ [0x00 : 32] DMAADDR
  [then]


  [ifdef] OTG_OTG_DOEPCTL2_DEF
    \
    \ @brief The application uses this register to control the behavior of each logical endpoint other than endpoint 0.
    \ Address offset: 0xB40
    \ Reset value: 0x00000000
    \
    $00 constant OTG_MPSIZ                      \ [0x00 : 11] MPSIZ
    $0f constant OTG_USBAEP                     \ [0x0f] USBAEP
    $10 constant OTG_EONUM_DPIP                 \ [0x10] EONUM_DPIP
    $11 constant OTG_NAKSTS                     \ [0x11] NAKSTS
    $12 constant OTG_EPTYP                      \ [0x12 : 2] EPTYP
    $14 constant OTG_SNPM                       \ [0x14] SNPM
    $15 constant OTG_STALL                      \ [0x15] STALL
    $1a constant OTG_CNAK                       \ [0x1a] CNAK
    $1b constant OTG_SNAK                       \ [0x1b] SNAK
    $1c constant OTG_SD0PID_SEVNFRM             \ [0x1c] SD0PID_SEVNFRM
    $1d constant OTG_SD1PID_SODDFRM             \ [0x1d] SD1PID_SODDFRM
    $1e constant OTG_EPDIS                      \ [0x1e] EPDIS
    $1f constant OTG_EPENA                      \ [0x1f] EPENA
  [then]


  [ifdef] OTG_OTG_DOEPINT2_DEF
    \
    \ @brief This register indicates the status of an endpoint with respect to USB- and AHB-related events. It is shown in Figure724. The application must read this register when the OUT endpoints interrupt bit of the OTG_GINTSTS register (OEPINT bit in OTG_GINTSTS) is set. Before the application can read this register, it must first read the OTG_DAINT register to get the exact endpoint number for the OTG_DOEPINTx register. The application must clear the appropriate bit in this register to clear the corresponding bits in the OTG_DAINT and OTG_GINTSTS registers.
    \ Address offset: 0xB48
    \ Reset value: 0x00000080
    \
    $00 constant OTG_XFRC                       \ [0x00] XFRC
    $01 constant OTG_EPDISD                     \ [0x01] EPDISD
    $02 constant OTG_AHBERR                     \ [0x02] AHBERR
    $03 constant OTG_STUP                       \ [0x03] STUP
    $04 constant OTG_OTEPDIS                    \ [0x04] OTEPDIS
    $05 constant OTG_STSPHSRX                   \ [0x05] STSPHSRX
    $06 constant OTG_B2BSTUP                    \ [0x06] B2BSTUP
    $08 constant OTG_OUTPKTERR                  \ [0x08] OUTPKTERR
    $09 constant OTG_BNA                        \ [0x09] BNA
    $0c constant OTG_BERR                       \ [0x0c] BERR
    $0d constant OTG_NAK                        \ [0x0d] NAK
    $0e constant OTG_NYET                       \ [0x0e] NYET
    $0f constant OTG_STPKTRX                    \ [0x0f] STPKTRX
  [then]


  [ifdef] OTG_OTG_DOEPTSIZ2_DEF
    \
    \ @brief The application must modify this register before enabling the endpoint. Once the endpoint is enabled using endpoint enable bit of the OTG_DOEPCTLx registers (EPENA bit in OTG_DOEPCTLx), the core modifies this register. The application can only read this register once the core has cleared the endpoint enable bit.
    \ Address offset: 0xB50
    \ Reset value: 0x00000000
    \
    $00 constant OTG_XFRSIZ                     \ [0x00 : 19] XFRSIZ
    $13 constant OTG_PKTCNT                     \ [0x13 : 10] PKTCNT
    $1d constant OTG_RXDPID_STUPCNT             \ [0x1d : 2] RXDPID_STUPCNT
  [then]


  [ifdef] OTG_OTG_DOEPDMA2_DEF
    \
    \ @brief OTG device OUT endpoint 2 DMA address register
    \ Address offset: 0xB54
    \ Reset value: 0x00000000
    \
    $00 constant OTG_DMAADDR                    \ [0x00 : 32] DMAADDR
  [then]


  [ifdef] OTG_OTG_DOEPCTL3_DEF
    \
    \ @brief The application uses this register to control the behavior of each logical endpoint other than endpoint 0.
    \ Address offset: 0xB60
    \ Reset value: 0x00000000
    \
    $00 constant OTG_MPSIZ                      \ [0x00 : 11] MPSIZ
    $0f constant OTG_USBAEP                     \ [0x0f] USBAEP
    $10 constant OTG_EONUM_DPIP                 \ [0x10] EONUM_DPIP
    $11 constant OTG_NAKSTS                     \ [0x11] NAKSTS
    $12 constant OTG_EPTYP                      \ [0x12 : 2] EPTYP
    $14 constant OTG_SNPM                       \ [0x14] SNPM
    $15 constant OTG_STALL                      \ [0x15] STALL
    $1a constant OTG_CNAK                       \ [0x1a] CNAK
    $1b constant OTG_SNAK                       \ [0x1b] SNAK
    $1c constant OTG_SD0PID_SEVNFRM             \ [0x1c] SD0PID_SEVNFRM
    $1d constant OTG_SD1PID_SODDFRM             \ [0x1d] SD1PID_SODDFRM
    $1e constant OTG_EPDIS                      \ [0x1e] EPDIS
    $1f constant OTG_EPENA                      \ [0x1f] EPENA
  [then]


  [ifdef] OTG_OTG_DOEPINT3_DEF
    \
    \ @brief This register indicates the status of an endpoint with respect to USB- and AHB-related events. It is shown in Figure724. The application must read this register when the OUT endpoints interrupt bit of the OTG_GINTSTS register (OEPINT bit in OTG_GINTSTS) is set. Before the application can read this register, it must first read the OTG_DAINT register to get the exact endpoint number for the OTG_DOEPINTx register. The application must clear the appropriate bit in this register to clear the corresponding bits in the OTG_DAINT and OTG_GINTSTS registers.
    \ Address offset: 0xB68
    \ Reset value: 0x00000080
    \
    $00 constant OTG_XFRC                       \ [0x00] XFRC
    $01 constant OTG_EPDISD                     \ [0x01] EPDISD
    $02 constant OTG_AHBERR                     \ [0x02] AHBERR
    $03 constant OTG_STUP                       \ [0x03] STUP
    $04 constant OTG_OTEPDIS                    \ [0x04] OTEPDIS
    $05 constant OTG_STSPHSRX                   \ [0x05] STSPHSRX
    $06 constant OTG_B2BSTUP                    \ [0x06] B2BSTUP
    $08 constant OTG_OUTPKTERR                  \ [0x08] OUTPKTERR
    $09 constant OTG_BNA                        \ [0x09] BNA
    $0c constant OTG_BERR                       \ [0x0c] BERR
    $0d constant OTG_NAK                        \ [0x0d] NAK
    $0e constant OTG_NYET                       \ [0x0e] NYET
    $0f constant OTG_STPKTRX                    \ [0x0f] STPKTRX
  [then]


  [ifdef] OTG_OTG_DOEPTSIZ3_DEF
    \
    \ @brief The application must modify this register before enabling the endpoint. Once the endpoint is enabled using endpoint enable bit of the OTG_DOEPCTLx registers (EPENA bit in OTG_DOEPCTLx), the core modifies this register. The application can only read this register once the core has cleared the endpoint enable bit.
    \ Address offset: 0xB70
    \ Reset value: 0x00000000
    \
    $00 constant OTG_XFRSIZ                     \ [0x00 : 19] XFRSIZ
    $13 constant OTG_PKTCNT                     \ [0x13 : 10] PKTCNT
    $1d constant OTG_RXDPID_STUPCNT             \ [0x1d : 2] RXDPID_STUPCNT
  [then]


  [ifdef] OTG_OTG_DOEPDMA3_DEF
    \
    \ @brief OTG device OUT endpoint 3 DMA address register
    \ Address offset: 0xB74
    \ Reset value: 0x00000000
    \
    $00 constant OTG_DMAADDR                    \ [0x00 : 32] DMAADDR
  [then]


  [ifdef] OTG_OTG_DOEPCTL4_DEF
    \
    \ @brief The application uses this register to control the behavior of each logical endpoint other than endpoint 0.
    \ Address offset: 0xB80
    \ Reset value: 0x00000000
    \
    $00 constant OTG_MPSIZ                      \ [0x00 : 11] MPSIZ
    $0f constant OTG_USBAEP                     \ [0x0f] USBAEP
    $10 constant OTG_EONUM_DPIP                 \ [0x10] EONUM_DPIP
    $11 constant OTG_NAKSTS                     \ [0x11] NAKSTS
    $12 constant OTG_EPTYP                      \ [0x12 : 2] EPTYP
    $14 constant OTG_SNPM                       \ [0x14] SNPM
    $15 constant OTG_STALL                      \ [0x15] STALL
    $1a constant OTG_CNAK                       \ [0x1a] CNAK
    $1b constant OTG_SNAK                       \ [0x1b] SNAK
    $1c constant OTG_SD0PID_SEVNFRM             \ [0x1c] SD0PID_SEVNFRM
    $1d constant OTG_SD1PID_SODDFRM             \ [0x1d] SD1PID_SODDFRM
    $1e constant OTG_EPDIS                      \ [0x1e] EPDIS
    $1f constant OTG_EPENA                      \ [0x1f] EPENA
  [then]


  [ifdef] OTG_OTG_DOEPINT4_DEF
    \
    \ @brief This register indicates the status of an endpoint with respect to USB- and AHB-related events. It is shown in Figure724. The application must read this register when the OUT endpoints interrupt bit of the OTG_GINTSTS register (OEPINT bit in OTG_GINTSTS) is set. Before the application can read this register, it must first read the OTG_DAINT register to get the exact endpoint number for the OTG_DOEPINTx register. The application must clear the appropriate bit in this register to clear the corresponding bits in the OTG_DAINT and OTG_GINTSTS registers.
    \ Address offset: 0xB88
    \ Reset value: 0x00000080
    \
    $00 constant OTG_XFRC                       \ [0x00] XFRC
    $01 constant OTG_EPDISD                     \ [0x01] EPDISD
    $02 constant OTG_AHBERR                     \ [0x02] AHBERR
    $03 constant OTG_STUP                       \ [0x03] STUP
    $04 constant OTG_OTEPDIS                    \ [0x04] OTEPDIS
    $05 constant OTG_STSPHSRX                   \ [0x05] STSPHSRX
    $06 constant OTG_B2BSTUP                    \ [0x06] B2BSTUP
    $08 constant OTG_OUTPKTERR                  \ [0x08] OUTPKTERR
    $09 constant OTG_BNA                        \ [0x09] BNA
    $0c constant OTG_BERR                       \ [0x0c] BERR
    $0d constant OTG_NAK                        \ [0x0d] NAK
    $0e constant OTG_NYET                       \ [0x0e] NYET
    $0f constant OTG_STPKTRX                    \ [0x0f] STPKTRX
  [then]


  [ifdef] OTG_OTG_DOEPTSIZ4_DEF
    \
    \ @brief The application must modify this register before enabling the endpoint. Once the endpoint is enabled using endpoint enable bit of the OTG_DOEPCTLx registers (EPENA bit in OTG_DOEPCTLx), the core modifies this register. The application can only read this register once the core has cleared the endpoint enable bit.
    \ Address offset: 0xB90
    \ Reset value: 0x00000000
    \
    $00 constant OTG_XFRSIZ                     \ [0x00 : 19] XFRSIZ
    $13 constant OTG_PKTCNT                     \ [0x13 : 10] PKTCNT
    $1d constant OTG_RXDPID_STUPCNT             \ [0x1d : 2] RXDPID_STUPCNT
  [then]


  [ifdef] OTG_OTG_DOEPDMA4_DEF
    \
    \ @brief OTG device OUT endpoint 4 DMA address register
    \ Address offset: 0xB94
    \ Reset value: 0x00000000
    \
    $00 constant OTG_DMAADDR                    \ [0x00 : 32] DMAADDR
  [then]


  [ifdef] OTG_OTG_DOEPCTL5_DEF
    \
    \ @brief The application uses this register to control the behavior of each logical endpoint other than endpoint 0.
    \ Address offset: 0xBA0
    \ Reset value: 0x00000000
    \
    $00 constant OTG_MPSIZ                      \ [0x00 : 11] MPSIZ
    $0f constant OTG_USBAEP                     \ [0x0f] USBAEP
    $10 constant OTG_EONUM_DPIP                 \ [0x10] EONUM_DPIP
    $11 constant OTG_NAKSTS                     \ [0x11] NAKSTS
    $12 constant OTG_EPTYP                      \ [0x12 : 2] EPTYP
    $14 constant OTG_SNPM                       \ [0x14] SNPM
    $15 constant OTG_STALL                      \ [0x15] STALL
    $1a constant OTG_CNAK                       \ [0x1a] CNAK
    $1b constant OTG_SNAK                       \ [0x1b] SNAK
    $1c constant OTG_SD0PID_SEVNFRM             \ [0x1c] SD0PID_SEVNFRM
    $1d constant OTG_SD1PID_SODDFRM             \ [0x1d] SD1PID_SODDFRM
    $1e constant OTG_EPDIS                      \ [0x1e] EPDIS
    $1f constant OTG_EPENA                      \ [0x1f] EPENA
  [then]


  [ifdef] OTG_OTG_DOEPINT5_DEF
    \
    \ @brief This register indicates the status of an endpoint with respect to USB- and AHB-related events. It is shown in Figure724. The application must read this register when the OUT endpoints interrupt bit of the OTG_GINTSTS register (OEPINT bit in OTG_GINTSTS) is set. Before the application can read this register, it must first read the OTG_DAINT register to get the exact endpoint number for the OTG_DOEPINTx register. The application must clear the appropriate bit in this register to clear the corresponding bits in the OTG_DAINT and OTG_GINTSTS registers.
    \ Address offset: 0xBA8
    \ Reset value: 0x00000080
    \
    $00 constant OTG_XFRC                       \ [0x00] XFRC
    $01 constant OTG_EPDISD                     \ [0x01] EPDISD
    $02 constant OTG_AHBERR                     \ [0x02] AHBERR
    $03 constant OTG_STUP                       \ [0x03] STUP
    $04 constant OTG_OTEPDIS                    \ [0x04] OTEPDIS
    $05 constant OTG_STSPHSRX                   \ [0x05] STSPHSRX
    $06 constant OTG_B2BSTUP                    \ [0x06] B2BSTUP
    $08 constant OTG_OUTPKTERR                  \ [0x08] OUTPKTERR
    $09 constant OTG_BNA                        \ [0x09] BNA
    $0c constant OTG_BERR                       \ [0x0c] BERR
    $0d constant OTG_NAK                        \ [0x0d] NAK
    $0e constant OTG_NYET                       \ [0x0e] NYET
    $0f constant OTG_STPKTRX                    \ [0x0f] STPKTRX
  [then]


  [ifdef] OTG_OTG_DOEPTSIZ5_DEF
    \
    \ @brief The application must modify this register before enabling the endpoint. Once the endpoint is enabled using endpoint enable bit of the OTG_DOEPCTLx registers (EPENA bit in OTG_DOEPCTLx), the core modifies this register. The application can only read this register once the core has cleared the endpoint enable bit.
    \ Address offset: 0xBB0
    \ Reset value: 0x00000000
    \
    $00 constant OTG_XFRSIZ                     \ [0x00 : 19] XFRSIZ
    $13 constant OTG_PKTCNT                     \ [0x13 : 10] PKTCNT
    $1d constant OTG_RXDPID_STUPCNT             \ [0x1d : 2] RXDPID_STUPCNT
  [then]


  [ifdef] OTG_OTG_DOEPDMA5_DEF
    \
    \ @brief OTG device OUT endpoint 5 DMA address register
    \ Address offset: 0xBB4
    \ Reset value: 0x00000000
    \
    $00 constant OTG_DMAADDR                    \ [0x00 : 32] DMAADDR
  [then]


  [ifdef] OTG_OTG_DOEPCTL6_DEF
    \
    \ @brief The application uses this register to control the behavior of each logical endpoint other than endpoint 0.
    \ Address offset: 0xBC0
    \ Reset value: 0x00000000
    \
    $00 constant OTG_MPSIZ                      \ [0x00 : 11] MPSIZ
    $0f constant OTG_USBAEP                     \ [0x0f] USBAEP
    $10 constant OTG_EONUM_DPIP                 \ [0x10] EONUM_DPIP
    $11 constant OTG_NAKSTS                     \ [0x11] NAKSTS
    $12 constant OTG_EPTYP                      \ [0x12 : 2] EPTYP
    $14 constant OTG_SNPM                       \ [0x14] SNPM
    $15 constant OTG_STALL                      \ [0x15] STALL
    $1a constant OTG_CNAK                       \ [0x1a] CNAK
    $1b constant OTG_SNAK                       \ [0x1b] SNAK
    $1c constant OTG_SD0PID_SEVNFRM             \ [0x1c] SD0PID_SEVNFRM
    $1d constant OTG_SD1PID_SODDFRM             \ [0x1d] SD1PID_SODDFRM
    $1e constant OTG_EPDIS                      \ [0x1e] EPDIS
    $1f constant OTG_EPENA                      \ [0x1f] EPENA
  [then]


  [ifdef] OTG_OTG_DOEPINT6_DEF
    \
    \ @brief This register indicates the status of an endpoint with respect to USB- and AHB-related events. It is shown in Figure724. The application must read this register when the OUT endpoints interrupt bit of the OTG_GINTSTS register (OEPINT bit in OTG_GINTSTS) is set. Before the application can read this register, it must first read the OTG_DAINT register to get the exact endpoint number for the OTG_DOEPINTx register. The application must clear the appropriate bit in this register to clear the corresponding bits in the OTG_DAINT and OTG_GINTSTS registers.
    \ Address offset: 0xBC8
    \ Reset value: 0x00000080
    \
    $00 constant OTG_XFRC                       \ [0x00] XFRC
    $01 constant OTG_EPDISD                     \ [0x01] EPDISD
    $02 constant OTG_AHBERR                     \ [0x02] AHBERR
    $03 constant OTG_STUP                       \ [0x03] STUP
    $04 constant OTG_OTEPDIS                    \ [0x04] OTEPDIS
    $05 constant OTG_STSPHSRX                   \ [0x05] STSPHSRX
    $06 constant OTG_B2BSTUP                    \ [0x06] B2BSTUP
    $08 constant OTG_OUTPKTERR                  \ [0x08] OUTPKTERR
    $09 constant OTG_BNA                        \ [0x09] BNA
    $0c constant OTG_BERR                       \ [0x0c] BERR
    $0d constant OTG_NAK                        \ [0x0d] NAK
    $0e constant OTG_NYET                       \ [0x0e] NYET
    $0f constant OTG_STPKTRX                    \ [0x0f] STPKTRX
  [then]


  [ifdef] OTG_OTG_DOEPTSIZ6_DEF
    \
    \ @brief The application must modify this register before enabling the endpoint. Once the endpoint is enabled using endpoint enable bit of the OTG_DOEPCTLx registers (EPENA bit in OTG_DOEPCTLx), the core modifies this register. The application can only read this register once the core has cleared the endpoint enable bit.
    \ Address offset: 0xBD0
    \ Reset value: 0x00000000
    \
    $00 constant OTG_XFRSIZ                     \ [0x00 : 19] XFRSIZ
    $13 constant OTG_PKTCNT                     \ [0x13 : 10] PKTCNT
    $1d constant OTG_RXDPID_STUPCNT             \ [0x1d : 2] RXDPID_STUPCNT
  [then]


  [ifdef] OTG_OTG_DOEPDMA6_DEF
    \
    \ @brief OTG device OUT endpoint 6 DMA address register
    \ Address offset: 0xBD4
    \ Reset value: 0x00000000
    \
    $00 constant OTG_DMAADDR                    \ [0x00 : 32] DMAADDR
  [then]


  [ifdef] OTG_OTG_DOEPCTL7_DEF
    \
    \ @brief The application uses this register to control the behavior of each logical endpoint other than endpoint 0.
    \ Address offset: 0xBE0
    \ Reset value: 0x00000000
    \
    $00 constant OTG_MPSIZ                      \ [0x00 : 11] MPSIZ
    $0f constant OTG_USBAEP                     \ [0x0f] USBAEP
    $10 constant OTG_EONUM_DPIP                 \ [0x10] EONUM_DPIP
    $11 constant OTG_NAKSTS                     \ [0x11] NAKSTS
    $12 constant OTG_EPTYP                      \ [0x12 : 2] EPTYP
    $14 constant OTG_SNPM                       \ [0x14] SNPM
    $15 constant OTG_STALL                      \ [0x15] STALL
    $1a constant OTG_CNAK                       \ [0x1a] CNAK
    $1b constant OTG_SNAK                       \ [0x1b] SNAK
    $1c constant OTG_SD0PID_SEVNFRM             \ [0x1c] SD0PID_SEVNFRM
    $1d constant OTG_SD1PID_SODDFRM             \ [0x1d] SD1PID_SODDFRM
    $1e constant OTG_EPDIS                      \ [0x1e] EPDIS
    $1f constant OTG_EPENA                      \ [0x1f] EPENA
  [then]


  [ifdef] OTG_OTG_DOEPINT7_DEF
    \
    \ @brief This register indicates the status of an endpoint with respect to USB- and AHB-related events. It is shown in Figure724. The application must read this register when the OUT endpoints interrupt bit of the OTG_GINTSTS register (OEPINT bit in OTG_GINTSTS) is set. Before the application can read this register, it must first read the OTG_DAINT register to get the exact endpoint number for the OTG_DOEPINTx register. The application must clear the appropriate bit in this register to clear the corresponding bits in the OTG_DAINT and OTG_GINTSTS registers.
    \ Address offset: 0xBE8
    \ Reset value: 0x00000080
    \
    $00 constant OTG_XFRC                       \ [0x00] XFRC
    $01 constant OTG_EPDISD                     \ [0x01] EPDISD
    $02 constant OTG_AHBERR                     \ [0x02] AHBERR
    $03 constant OTG_STUP                       \ [0x03] STUP
    $04 constant OTG_OTEPDIS                    \ [0x04] OTEPDIS
    $05 constant OTG_STSPHSRX                   \ [0x05] STSPHSRX
    $06 constant OTG_B2BSTUP                    \ [0x06] B2BSTUP
    $08 constant OTG_OUTPKTERR                  \ [0x08] OUTPKTERR
    $09 constant OTG_BNA                        \ [0x09] BNA
    $0c constant OTG_BERR                       \ [0x0c] BERR
    $0d constant OTG_NAK                        \ [0x0d] NAK
    $0e constant OTG_NYET                       \ [0x0e] NYET
    $0f constant OTG_STPKTRX                    \ [0x0f] STPKTRX
  [then]


  [ifdef] OTG_OTG_DOEPTSIZ7_DEF
    \
    \ @brief The application must modify this register before enabling the endpoint. Once the endpoint is enabled using endpoint enable bit of the OTG_DOEPCTLx registers (EPENA bit in OTG_DOEPCTLx), the core modifies this register. The application can only read this register once the core has cleared the endpoint enable bit.
    \ Address offset: 0xBF0
    \ Reset value: 0x00000000
    \
    $00 constant OTG_XFRSIZ                     \ [0x00 : 19] XFRSIZ
    $13 constant OTG_PKTCNT                     \ [0x13 : 10] PKTCNT
    $1d constant OTG_RXDPID_STUPCNT             \ [0x1d : 2] RXDPID_STUPCNT
  [then]


  [ifdef] OTG_OTG_DOEPDMA7_DEF
    \
    \ @brief OTG device OUT endpoint 7 DMA address register
    \ Address offset: 0xBF4
    \ Reset value: 0x00000000
    \
    $00 constant OTG_DMAADDR                    \ [0x00 : 32] DMAADDR
  [then]


  [ifdef] OTG_OTG_DOEPCTL8_DEF
    \
    \ @brief The application uses this register to control the behavior of each logical endpoint other than endpoint 0.
    \ Address offset: 0xC00
    \ Reset value: 0x00000000
    \
    $00 constant OTG_MPSIZ                      \ [0x00 : 11] MPSIZ
    $0f constant OTG_USBAEP                     \ [0x0f] USBAEP
    $10 constant OTG_EONUM_DPIP                 \ [0x10] EONUM_DPIP
    $11 constant OTG_NAKSTS                     \ [0x11] NAKSTS
    $12 constant OTG_EPTYP                      \ [0x12 : 2] EPTYP
    $14 constant OTG_SNPM                       \ [0x14] SNPM
    $15 constant OTG_STALL                      \ [0x15] STALL
    $1a constant OTG_CNAK                       \ [0x1a] CNAK
    $1b constant OTG_SNAK                       \ [0x1b] SNAK
    $1c constant OTG_SD0PID_SEVNFRM             \ [0x1c] SD0PID_SEVNFRM
    $1d constant OTG_SD1PID_SODDFRM             \ [0x1d] SD1PID_SODDFRM
    $1e constant OTG_EPDIS                      \ [0x1e] EPDIS
    $1f constant OTG_EPENA                      \ [0x1f] EPENA
  [then]


  [ifdef] OTG_OTG_DOEPINT8_DEF
    \
    \ @brief This register indicates the status of an endpoint with respect to USB- and AHB-related events. It is shown in Figure724. The application must read this register when the OUT endpoints interrupt bit of the OTG_GINTSTS register (OEPINT bit in OTG_GINTSTS) is set. Before the application can read this register, it must first read the OTG_DAINT register to get the exact endpoint number for the OTG_DOEPINTx register. The application must clear the appropriate bit in this register to clear the corresponding bits in the OTG_DAINT and OTG_GINTSTS registers.
    \ Address offset: 0xC08
    \ Reset value: 0x00000080
    \
    $00 constant OTG_XFRC                       \ [0x00] XFRC
    $01 constant OTG_EPDISD                     \ [0x01] EPDISD
    $02 constant OTG_AHBERR                     \ [0x02] AHBERR
    $03 constant OTG_STUP                       \ [0x03] STUP
    $04 constant OTG_OTEPDIS                    \ [0x04] OTEPDIS
    $05 constant OTG_STSPHSRX                   \ [0x05] STSPHSRX
    $06 constant OTG_B2BSTUP                    \ [0x06] B2BSTUP
    $08 constant OTG_OUTPKTERR                  \ [0x08] OUTPKTERR
    $09 constant OTG_BNA                        \ [0x09] BNA
    $0c constant OTG_BERR                       \ [0x0c] BERR
    $0d constant OTG_NAK                        \ [0x0d] NAK
    $0e constant OTG_NYET                       \ [0x0e] NYET
    $0f constant OTG_STPKTRX                    \ [0x0f] STPKTRX
  [then]


  [ifdef] OTG_OTG_DOEPTSIZ8_DEF
    \
    \ @brief The application must modify this register before enabling the endpoint. Once the endpoint is enabled using endpoint enable bit of the OTG_DOEPCTLx registers (EPENA bit in OTG_DOEPCTLx), the core modifies this register. The application can only read this register once the core has cleared the endpoint enable bit.
    \ Address offset: 0xC10
    \ Reset value: 0x00000000
    \
    $00 constant OTG_XFRSIZ                     \ [0x00 : 19] XFRSIZ
    $13 constant OTG_PKTCNT                     \ [0x13 : 10] PKTCNT
    $1d constant OTG_RXDPID_STUPCNT             \ [0x1d : 2] RXDPID_STUPCNT
  [then]


  [ifdef] OTG_OTG_DOEPDMA8_DEF
    \
    \ @brief OTG device OUT endpoint 8 DMA address register
    \ Address offset: 0xC14
    \ Reset value: 0x00000000
    \
    $00 constant OTG_DMAADDR                    \ [0x00 : 32] DMAADDR
  [then]


  [ifdef] OTG_OTG_PCGCCTL_DEF
    \
    \ @brief This register is available in host and device modes.
    \ Address offset: 0xE00
    \ Reset value: 0x200B8000
    \
    $00 constant OTG_STPPCLK                    \ [0x00] STPPCLK
    $01 constant OTG_GATEHCLK                   \ [0x01] GATEHCLK
    $04 constant OTG_PHYSUSP                    \ [0x04] PHYSUSP
    $05 constant OTG_ENL1GTG                    \ [0x05] ENL1GTG
    $06 constant OTG_PHYSLEEP                   \ [0x06] PHYSLEEP
    $07 constant OTG_SUSP                       \ [0x07] SUSP
  [then]

  \
  \ @brief OTG
  \
  $00 constant OTG_OTG_GOTGCTL          \ The OTG_GOTGCTL register controls the behavior and reflects the status of the OTG function of the core.
  $04 constant OTG_OTG_GOTGINT          \ The application reads this register whenever there is an OTG interrupt and clears the bits in this register to clear the OTG interrupt.
  $08 constant OTG_OTG_GAHBCFG          \ This register can be used to configure the core after power-on or a change in mode. This register mainly contains AHB system-related configuration parameters. Do not change this register after the initial programming. The application must program this register before starting any transactions on either the AHB or the USB.
  $0C constant OTG_OTG_GUSBCFG          \ This register can be used to configure the core after power-on or a changing to host mode or device mode. It contains USB and USB-PHY related configuration parameters. The application must program this register before starting any transactions on either the AHB or the USB. Do not make changes to this register after the initial programming.
  $10 constant OTG_OTG_GRSTCTL          \ The application uses this register to reset various hardware features inside the core.
  $14 constant OTG_OTG_GINTSTS          \ This register interrupts the application for system-level events in the current mode (device mode or host mode). Some of the bits in this register are valid only in host mode, while others are valid in device mode only. This register also indicates the current mode. To clear the interrupt status bits of the rc_w1 type, the application must write 1 into the bit. The FIFO status interrupts are read-only; once software reads from or writes to the FIFO while servicing these interrupts, FIFO interrupt conditions are cleared automatically. The application must clear the OTG_GINTSTS register at initialization before unmasking the interrupt bit to avoid any interrupts generated prior to initialization.
  $18 constant OTG_OTG_GINTMSK          \ This register works with the core interrupt register to interrupt the application. When an interrupt bit is masked, the interrupt associated with that bit is not generated. However, the core interrupt (OTG_GINTSTS) register bit corresponding to that interrupt is still set.
  $1C constant OTG_OTG_GRXSTSR          \ This description is for register OTG_GRXSTSR in Device mode. A read to the receive status debug read register returns the contents of the top of the receive FIFO. The core ignores the receive status read when the receive FIFO is empty and returns a value of 0x00000000.
  $20 constant OTG_OTG_GRXSTSP          \ This description is for register OTG_GRXSTSP in Device mode. Similarly to OTG_GRXSTSR (receive status debug read register) where a read returns the contents of the top of the receive FIFO, a read to OTG_GRXSTSP (receive status read and pop register) additionally pops the top data entry out of the Rx FIFO. The core ignores the receive status pop/read when the receive FIFO is empty and returns a value of 0x00000000. The application must only pop the receive status FIFO when the receive FIFO non-empty bit of the core interrupt register (RXFLVL bit in OTG_GINTSTS) is asserted.
  $24 constant OTG_OTG_GRXFSIZ          \ The application can program the RAM size that must be allocated to the Rx FIFO.
  $28 constant OTG_OTG_HNPTXFSIZ        \ Host mode
  $2C constant OTG_OTG_HNPTXSTS         \ In device mode, this register is not valid. This read-only register contains the free space information for the non-periodic Tx FIFO and the non-periodic transmit request queue.
  $38 constant OTG_OTG_GCCFG            \ OTG general core configuration register
  $3C constant OTG_OTG_CID              \ This is a register containing the Product ID as reset value.
  $54 constant OTG_OTG_GLPMCFG          \ OTG core LPM configuration register
  $100 constant OTG_OTG_HPTXFSIZ        \ OTG host periodic transmit FIFO size register
  $104 constant OTG_OTG_DIEPTXF1        \ OTG device IN endpoint transmit FIFO 1 size register
  $108 constant OTG_OTG_DIEPTXF2        \ OTG device IN endpoint transmit FIFO 2 size register
  $10C constant OTG_OTG_DIEPTXF3        \ OTG device IN endpoint transmit FIFO 3 size register
  $110 constant OTG_OTG_DIEPTXF4        \ OTG device IN endpoint transmit FIFO 4 size register
  $114 constant OTG_OTG_DIEPTXF5        \ OTG device IN endpoint transmit FIFO 5 size register
  $118 constant OTG_OTG_DIEPTXF6        \ OTG device IN endpoint transmit FIFO 6 size register
  $11C constant OTG_OTG_DIEPTXF7        \ OTG device IN endpoint transmit FIFO 7 size register
  $120 constant OTG_OTG_DIEPTXF8        \ OTG device IN endpoint transmit FIFO 8 size register
  $400 constant OTG_OTG_HCFG            \ This register configures the core after power-on. Do not make changes to this register after initializing the host.
  $404 constant OTG_OTG_HFIR            \ This register stores the frame interval information for the current speed to which the OTG controller has enumerated.
  $408 constant OTG_OTG_HFNUM           \ This register indicates the current frame number. It also indicates the time remaining (in terms of the number of PHY clocks) in the current frame.
  $410 constant OTG_OTG_HPTXSTS         \ This read-only register contains the free space information for the periodic Tx FIFO and the periodic transmit request queue.
  $414 constant OTG_OTG_HAINT           \ When a significant event occurs on a channel, the host all channels interrupt register interrupts the application using the host channels interrupt bit of the core interrupt register (HCINT bit in OTG_GINTSTS). This is shown in Figure724. There is one interrupt bit per channel, up to a maximum of 16 bits. Bits in this register are set and cleared when the application sets and clears bits in the corresponding host channel-x interrupt register.
  $418 constant OTG_OTG_HAINTMSK        \ The host all channel interrupt mask register works with the host all channel interrupt register to interrupt the application when an event occurs on a channel. There is one interrupt mask bit per channel, up to a maximum of 16 bits.
  $41C constant OTG_OTG_HFLBADDR        \ This register holds the starting address of the frame list information (scatter/gather mode).
  $440 constant OTG_OTG_HPRT            \ This register is available only in host mode. Currently, the OTG host supports only one port. A single register holds USB port-related information such as USB reset, enable, suspend, resume, connect status, and test mode for each port. It is shown in Figure724. The rc_w1 bits in this register can trigger an interrupt to the application through the host port interrupt bit of the core interrupt register (HPRTINT bit in OTG_GINTSTS). On a port interrupt, the application must read this register and clear the bit that caused the interrupt. For the rc_w1 bits, the application must write a 1 to the bit to clear the interrupt.
  $500 constant OTG_OTG_HCCHAR0         \ OTG host channel 0 characteristics register
  $504 constant OTG_OTG_HCSPLT0         \ OTG host channel 0 split control register
  $508 constant OTG_OTG_HCINT0          \ This register indicates the status of a channel with respect to USB- and AHB-related events. It is shown in Figure724. The application must read this register when the host channels interrupt bit in the core interrupt register (HCINT bit in OTG_GINTSTS) is set. Before the application can read this register, it must first read the host all channels interrupt (OTG_HAINT) register to get the exact channel number for the host channel-x interrupt register. The application must clear the appropriate bit in this register to clear the corresponding bits in the OTG_HAINT and OTG_GINTSTS registers.
  $50C constant OTG_OTG_HCINTMSK0       \ This register reflects the mask for each channel status described in the previous section.
  $510 constant OTG_OTG_HCTSIZ0         \ OTG host channel 0 transfer size register
  $514 constant OTG_OTG_HCDMA0          \ OTG host channel 0 DMA address register in buffer DMA [alternate]
  $51C constant OTG_OTG_HCDMAB0         \ OTG host channel-n DMA address buffer register
  $520 constant OTG_OTG_HCCHAR1         \ OTG host channel 1 characteristics register
  $524 constant OTG_OTG_HCSPLT1         \ OTG host channel 1 split control register
  $528 constant OTG_OTG_HCINT1          \ This register indicates the status of a channel with respect to USB- and AHB-related events. It is shown in Figure724. The application must read this register when the host channels interrupt bit in the core interrupt register (HCINT bit in OTG_GINTSTS) is set. Before the application can read this register, it must first read the host all channels interrupt (OTG_HAINT) register to get the exact channel number for the host channel-x interrupt register. The application must clear the appropriate bit in this register to clear the corresponding bits in the OTG_HAINT and OTG_GINTSTS registers.
  $52C constant OTG_OTG_HCINTMSK1       \ This register reflects the mask for each channel status described in the previous section.
  $530 constant OTG_OTG_HCTSIZ1         \ OTG host channel 1 transfer size register
  $534 constant OTG_OTG_HCDMA1          \ OTG host channel 1 DMA address register in buffer DMA [alternate]
  $53C constant OTG_OTG_HCDMAB1         \ OTG host channel-n DMA address buffer register
  $540 constant OTG_OTG_HCCHAR2         \ OTG host channel 2 characteristics register
  $544 constant OTG_OTG_HCSPLT2         \ OTG host channel 2 split control register
  $548 constant OTG_OTG_HCINT2          \ This register indicates the status of a channel with respect to USB- and AHB-related events. It is shown in Figure724. The application must read this register when the host channels interrupt bit in the core interrupt register (HCINT bit in OTG_GINTSTS) is set. Before the application can read this register, it must first read the host all channels interrupt (OTG_HAINT) register to get the exact channel number for the host channel-x interrupt register. The application must clear the appropriate bit in this register to clear the corresponding bits in the OTG_HAINT and OTG_GINTSTS registers.
  $54C constant OTG_OTG_HCINTMSK2       \ This register reflects the mask for each channel status described in the previous section.
  $550 constant OTG_OTG_HCTSIZ2         \ OTG host channel 2 transfer size register
  $554 constant OTG_OTG_HCDMA2          \ OTG host channel 2 DMA address register in buffer DMA [alternate]
  $55C constant OTG_OTG_HCDMAB2         \ OTG host channel-n DMA address buffer register
  $560 constant OTG_OTG_HCCHAR3         \ OTG host channel 3 characteristics register
  $564 constant OTG_OTG_HCSPLT3         \ OTG host channel 3 split control register
  $568 constant OTG_OTG_HCINT3          \ This register indicates the status of a channel with respect to USB- and AHB-related events. It is shown in Figure724. The application must read this register when the host channels interrupt bit in the core interrupt register (HCINT bit in OTG_GINTSTS) is set. Before the application can read this register, it must first read the host all channels interrupt (OTG_HAINT) register to get the exact channel number for the host channel-x interrupt register. The application must clear the appropriate bit in this register to clear the corresponding bits in the OTG_HAINT and OTG_GINTSTS registers.
  $56C constant OTG_OTG_HCINTMSK3       \ This register reflects the mask for each channel status described in the previous section.
  $570 constant OTG_OTG_HCTSIZ3         \ OTG host channel 3 transfer size register
  $574 constant OTG_OTG_HCDMA3          \ OTG host channel 3 DMA address register in buffer DMA [alternate]
  $57C constant OTG_OTG_HCDMAB3         \ OTG host channel-n DMA address buffer register
  $580 constant OTG_OTG_HCCHAR4         \ OTG host channel 4 characteristics register
  $584 constant OTG_OTG_HCSPLT4         \ OTG host channel 4 split control register
  $588 constant OTG_OTG_HCINT4          \ This register indicates the status of a channel with respect to USB- and AHB-related events. It is shown in Figure724. The application must read this register when the host channels interrupt bit in the core interrupt register (HCINT bit in OTG_GINTSTS) is set. Before the application can read this register, it must first read the host all channels interrupt (OTG_HAINT) register to get the exact channel number for the host channel-x interrupt register. The application must clear the appropriate bit in this register to clear the corresponding bits in the OTG_HAINT and OTG_GINTSTS registers.
  $58C constant OTG_OTG_HCINTMSK4       \ This register reflects the mask for each channel status described in the previous section.
  $590 constant OTG_OTG_HCTSIZ4         \ OTG host channel 4 transfer size register
  $594 constant OTG_OTG_HCDMA4          \ OTG host channel 4 DMA address register in buffer DMA [alternate]
  $59C constant OTG_OTG_HCDMAB4         \ OTG host channel-n DMA address buffer register
  $5A0 constant OTG_OTG_HCCHAR5         \ OTG host channel 5 characteristics register
  $5A4 constant OTG_OTG_HCSPLT5         \ OTG host channel 5 split control register
  $5A8 constant OTG_OTG_HCINT5          \ This register indicates the status of a channel with respect to USB- and AHB-related events. It is shown in Figure724. The application must read this register when the host channels interrupt bit in the core interrupt register (HCINT bit in OTG_GINTSTS) is set. Before the application can read this register, it must first read the host all channels interrupt (OTG_HAINT) register to get the exact channel number for the host channel-x interrupt register. The application must clear the appropriate bit in this register to clear the corresponding bits in the OTG_HAINT and OTG_GINTSTS registers.
  $5AC constant OTG_OTG_HCINTMSK5       \ This register reflects the mask for each channel status described in the previous section.
  $5B0 constant OTG_OTG_HCTSIZ5         \ OTG host channel 5 transfer size register
  $5B4 constant OTG_OTG_HCDMA5          \ OTG host channel 5 DMA address register in buffer DMA [alternate]
  $5BC constant OTG_OTG_HCDMAB5         \ OTG host channel-n DMA address buffer register
  $5C0 constant OTG_OTG_HCCHAR6         \ OTG host channel 6 characteristics register
  $5C4 constant OTG_OTG_HCSPLT6         \ OTG host channel 6 split control register
  $5C8 constant OTG_OTG_HCINT6          \ This register indicates the status of a channel with respect to USB- and AHB-related events. It is shown in Figure724. The application must read this register when the host channels interrupt bit in the core interrupt register (HCINT bit in OTG_GINTSTS) is set. Before the application can read this register, it must first read the host all channels interrupt (OTG_HAINT) register to get the exact channel number for the host channel-x interrupt register. The application must clear the appropriate bit in this register to clear the corresponding bits in the OTG_HAINT and OTG_GINTSTS registers.
  $5CC constant OTG_OTG_HCINTMSK6       \ This register reflects the mask for each channel status described in the previous section.
  $5D0 constant OTG_OTG_HCTSIZ6         \ OTG host channel 6 transfer size register
  $5D4 constant OTG_OTG_HCDMA6          \ OTG host channel 6 DMA address register in buffer DMA [alternate]
  $5DC constant OTG_OTG_HCDMAB6         \ OTG host channel-n DMA address buffer register
  $5E0 constant OTG_OTG_HCCHAR7         \ OTG host channel 7 characteristics register
  $5E4 constant OTG_OTG_HCSPLT7         \ OTG host channel 7 split control register
  $5E8 constant OTG_OTG_HCINT7          \ This register indicates the status of a channel with respect to USB- and AHB-related events. It is shown in Figure724. The application must read this register when the host channels interrupt bit in the core interrupt register (HCINT bit in OTG_GINTSTS) is set. Before the application can read this register, it must first read the host all channels interrupt (OTG_HAINT) register to get the exact channel number for the host channel-x interrupt register. The application must clear the appropriate bit in this register to clear the corresponding bits in the OTG_HAINT and OTG_GINTSTS registers.
  $5EC constant OTG_OTG_HCINTMSK7       \ This register reflects the mask for each channel status described in the previous section.
  $5F0 constant OTG_OTG_HCTSIZ7         \ OTG host channel 7 transfer size register
  $5F4 constant OTG_OTG_HCDMA7          \ OTG host channel 7 DMA address register in buffer DMA [alternate]
  $5FC constant OTG_OTG_HCDMAB7         \ OTG host channel-n DMA address buffer register
  $600 constant OTG_OTG_HCCHAR8         \ OTG host channel 8 characteristics register
  $604 constant OTG_OTG_HCSPLT8         \ OTG host channel 8 split control register
  $608 constant OTG_OTG_HCINT8          \ This register indicates the status of a channel with respect to USB- and AHB-related events. It is shown in Figure724. The application must read this register when the host channels interrupt bit in the core interrupt register (HCINT bit in OTG_GINTSTS) is set. Before the application can read this register, it must first read the host all channels interrupt (OTG_HAINT) register to get the exact channel number for the host channel-x interrupt register. The application must clear the appropriate bit in this register to clear the corresponding bits in the OTG_HAINT and OTG_GINTSTS registers.
  $60C constant OTG_OTG_HCINTMSK8       \ This register reflects the mask for each channel status described in the previous section.
  $610 constant OTG_OTG_HCTSIZ8         \ OTG host channel 8 transfer size register
  $614 constant OTG_OTG_HCDMA8          \ OTG host channel 8 DMA address register in buffer DMA [alternate]
  $61C constant OTG_OTG_HCDMAB8         \ OTG host channel-n DMA address buffer register
  $620 constant OTG_OTG_HCCHAR9         \ OTG host channel 9 characteristics register
  $624 constant OTG_OTG_HCSPLT9         \ OTG host channel 9 split control register
  $628 constant OTG_OTG_HCINT9          \ This register indicates the status of a channel with respect to USB- and AHB-related events. It is shown in Figure724. The application must read this register when the host channels interrupt bit in the core interrupt register (HCINT bit in OTG_GINTSTS) is set. Before the application can read this register, it must first read the host all channels interrupt (OTG_HAINT) register to get the exact channel number for the host channel-x interrupt register. The application must clear the appropriate bit in this register to clear the corresponding bits in the OTG_HAINT and OTG_GINTSTS registers.
  $62C constant OTG_OTG_HCINTMSK9       \ This register reflects the mask for each channel status described in the previous section.
  $630 constant OTG_OTG_HCTSIZ9         \ OTG host channel 9 transfer size register
  $634 constant OTG_OTG_HCDMA9          \ OTG host channel 9 DMA address register in buffer DMA [alternate]
  $63C constant OTG_OTG_HCDMAB9         \ OTG host channel-n DMA address buffer register
  $640 constant OTG_OTG_HCCHAR10        \ OTG host channel 10 characteristics register
  $644 constant OTG_OTG_HCSPLT10        \ OTG host channel 10 split control register
  $648 constant OTG_OTG_HCINT10         \ This register indicates the status of a channel with respect to USB- and AHB-related events. It is shown in Figure724. The application must read this register when the host channels interrupt bit in the core interrupt register (HCINT bit in OTG_GINTSTS) is set. Before the application can read this register, it must first read the host all channels interrupt (OTG_HAINT) register to get the exact channel number for the host channel-x interrupt register. The application must clear the appropriate bit in this register to clear the corresponding bits in the OTG_HAINT and OTG_GINTSTS registers.
  $64C constant OTG_OTG_HCINTMSK10      \ This register reflects the mask for each channel status described in the previous section.
  $650 constant OTG_OTG_HCTSIZ10        \ OTG host channel 10 transfer size register
  $654 constant OTG_OTG_HCDMA10         \ OTG host channel 10 DMA address register in buffer DMA [alternate]
  $65C constant OTG_OTG_HCDMAB10        \ OTG host channel-n DMA address buffer register
  $660 constant OTG_OTG_HCCHAR11        \ OTG host channel 11 characteristics register
  $664 constant OTG_OTG_HCSPLT11        \ OTG host channel 11 split control register
  $668 constant OTG_OTG_HCINT11         \ This register indicates the status of a channel with respect to USB- and AHB-related events. It is shown in Figure724. The application must read this register when the host channels interrupt bit in the core interrupt register (HCINT bit in OTG_GINTSTS) is set. Before the application can read this register, it must first read the host all channels interrupt (OTG_HAINT) register to get the exact channel number for the host channel-x interrupt register. The application must clear the appropriate bit in this register to clear the corresponding bits in the OTG_HAINT and OTG_GINTSTS registers.
  $66C constant OTG_OTG_HCINTMSK11      \ This register reflects the mask for each channel status described in the previous section.
  $670 constant OTG_OTG_HCTSIZ11        \ OTG host channel 11 transfer size register
  $674 constant OTG_OTG_HCDMA11         \ OTG host channel 11 DMA address register in buffer DMA [alternate]
  $67C constant OTG_OTG_HCDMAB11        \ OTG host channel-n DMA address buffer register
  $680 constant OTG_OTG_HCCHAR12        \ OTG host channel 12 characteristics register
  $684 constant OTG_OTG_HCSPLT12        \ OTG host channel 12 split control register
  $688 constant OTG_OTG_HCINT12         \ This register indicates the status of a channel with respect to USB- and AHB-related events. It is shown in Figure724. The application must read this register when the host channels interrupt bit in the core interrupt register (HCINT bit in OTG_GINTSTS) is set. Before the application can read this register, it must first read the host all channels interrupt (OTG_HAINT) register to get the exact channel number for the host channel-x interrupt register. The application must clear the appropriate bit in this register to clear the corresponding bits in the OTG_HAINT and OTG_GINTSTS registers.
  $68C constant OTG_OTG_HCINTMSK12      \ This register reflects the mask for each channel status described in the previous section.
  $690 constant OTG_OTG_HCTSIZ12        \ OTG host channel 12 transfer size register
  $694 constant OTG_OTG_HCDMA12         \ OTG host channel 12 DMA address register in buffer DMA [alternate]
  $69C constant OTG_OTG_HCDMAB12        \ OTG host channel-n DMA address buffer register
  $6A0 constant OTG_OTG_HCCHAR13        \ OTG host channel 13 characteristics register
  $6A4 constant OTG_OTG_HCSPLT13        \ OTG host channel 13 split control register
  $6A8 constant OTG_OTG_HCINT13         \ This register indicates the status of a channel with respect to USB- and AHB-related events. It is shown in Figure724. The application must read this register when the host channels interrupt bit in the core interrupt register (HCINT bit in OTG_GINTSTS) is set. Before the application can read this register, it must first read the host all channels interrupt (OTG_HAINT) register to get the exact channel number for the host channel-x interrupt register. The application must clear the appropriate bit in this register to clear the corresponding bits in the OTG_HAINT and OTG_GINTSTS registers.
  $6AC constant OTG_OTG_HCINTMSK13      \ This register reflects the mask for each channel status described in the previous section.
  $6B0 constant OTG_OTG_HCTSIZ13        \ OTG host channel 13 transfer size register
  $6B4 constant OTG_OTG_HCDMA13         \ OTG host channel 13 DMA address register in buffer DMA [alternate]
  $6BC constant OTG_OTG_HCDMAB13        \ OTG host channel-n DMA address buffer register
  $6C0 constant OTG_OTG_HCCHAR14        \ OTG host channel 14 characteristics register
  $6C4 constant OTG_OTG_HCSPLT14        \ OTG host channel 14 split control register
  $6C8 constant OTG_OTG_HCINT14         \ This register indicates the status of a channel with respect to USB- and AHB-related events. It is shown in Figure724. The application must read this register when the host channels interrupt bit in the core interrupt register (HCINT bit in OTG_GINTSTS) is set. Before the application can read this register, it must first read the host all channels interrupt (OTG_HAINT) register to get the exact channel number for the host channel-x interrupt register. The application must clear the appropriate bit in this register to clear the corresponding bits in the OTG_HAINT and OTG_GINTSTS registers.
  $6CC constant OTG_OTG_HCINTMSK14      \ This register reflects the mask for each channel status described in the previous section.
  $6D0 constant OTG_OTG_HCTSIZ14        \ OTG host channel 14 transfer size register
  $6D4 constant OTG_OTG_HCDMA14         \ OTG host channel 14 DMA address register in buffer DMA [alternate]
  $6DC constant OTG_OTG_HCDMAB14        \ OTG host channel-n DMA address buffer register
  $6E0 constant OTG_OTG_HCCHAR15        \ OTG host channel 15 characteristics register
  $6E4 constant OTG_OTG_HCSPLT15        \ OTG host channel 15 split control register
  $6E8 constant OTG_OTG_HCINT15         \ This register indicates the status of a channel with respect to USB- and AHB-related events. It is shown in Figure724. The application must read this register when the host channels interrupt bit in the core interrupt register (HCINT bit in OTG_GINTSTS) is set. Before the application can read this register, it must first read the host all channels interrupt (OTG_HAINT) register to get the exact channel number for the host channel-x interrupt register. The application must clear the appropriate bit in this register to clear the corresponding bits in the OTG_HAINT and OTG_GINTSTS registers.
  $6EC constant OTG_OTG_HCINTMSK15      \ This register reflects the mask for each channel status described in the previous section.
  $6F0 constant OTG_OTG_HCTSIZ15        \ OTG host channel 15 transfer size register
  $6F4 constant OTG_OTG_HCDMA15         \ OTG host channel 15 DMA address register in buffer DMA [alternate]
  $6FC constant OTG_OTG_HCDMAB15        \ OTG host channel-n DMA address buffer register
  $800 constant OTG_OTG_DCFG            \ This register configures the core in device mode after power-on or after certain control commands or enumeration. Do not make changes to this register after initial programming.
  $804 constant OTG_OTG_DCTL            \ OTG device control register
  $808 constant OTG_OTG_DSTS            \ This register indicates the status of the core with respect to USB-related events. It must be read on interrupts from the device all interrupts (OTG_DAINT) register.
  $810 constant OTG_OTG_DIEPMSK         \ This register works with each of the OTG_DIEPINTx registers for all endpoints to generate an interrupt per IN endpoint. The IN endpoint interrupt for a specific status in the OTG_DIEPINTx register can be masked by writing to the corresponding bit in this register. Status bits are masked by default.
  $814 constant OTG_OTG_DOEPMSK         \ This register works with each of the OTG_DOEPINTx registers for all endpoints to generate an interrupt per OUT endpoint. The OUT endpoint interrupt for a specific status in the OTG_DOEPINTx register can be masked by writing into the corresponding bit in this register. Status bits are masked by default.
  $818 constant OTG_OTG_DAINT           \ When a significant event occurs on an endpoint, a OTG_DAINT register interrupts the application using the device OUT endpoints interrupt bit or device IN endpoints interrupt bit of the OTG_GINTSTS register (OEPINT or IEPINT in OTG_GINTSTS, respectively). There is one interrupt bit per endpoint, up to a maximum of 16 bits for OUT endpoints and 16 bits for IN endpoints. For a bidirectional endpoint, the corresponding IN and OUT interrupt bits are used. Bits in this register are set and cleared when the application sets and clears bits in the corresponding device endpoint-x interrupt register (OTG_DIEPINTx/OTG_DOEPINTx).
  $81C constant OTG_OTG_DAINTMSK        \ The OTG_DAINTMSK register works with the device endpoint interrupt register to interrupt the application when an event occurs on a device endpoint. However, the OTG_DAINT register bit corresponding to that interrupt is still set.
  $828 constant OTG_OTG_DVBUSDIS        \ This register specifies the VBUS discharge time after VBUS pulsing during SRP.
  $82C constant OTG_OTG_DVBUSPULSE      \ This register specifies the VBUS pulsing time during SRP.
  $830 constant OTG_OTG_DTHRCTL         \ OTG device threshold control register
  $834 constant OTG_OTG_DIEPEMPMSK      \ This register is used to control the IN endpoint FIFO empty interrupt generation (TXFE_OTG_DIEPINTx).
  $838 constant OTG_OTG_DEACHINT        \ OTG device each endpoint interrupt register
  $83C constant OTG_OTG_DEACHINTMSK     \ There is one interrupt bit for endpoint 1 IN and one interrupt bit for endpoint 1 OUT.
  $844 constant OTG_OTG_HS_DIEPEACHMSK1 \ This register works with the OTG_DIEPINT1 register to generate a dedicated interrupt OTG_HS_EP1_IN for endpoint #1. The IN endpoint interrupt for a specific status in the OTG_DOEPINT1 register can be masked by writing into the corresponding bit in this register. Status bits are masked by default.
  $884 constant OTG_OTG_HS_DOEPEACHMSK1 \ This register works with the OTG_DOEPINT1 register to generate a dedicated interrupt OTG_HS_EP1_OUT for endpoint #1. The OUT endpoint interrupt for a specific status in the OTG_DOEPINT1 register can be masked by writing into the corresponding bit in this register. Status bits are masked by default.
  $900 constant OTG_OTG_DIEPCTL0        \ The application uses this register to control the behavior of each logical endpoint other than endpoint 0.
  $908 constant OTG_OTG_DIEPINT0        \ This register indicates the status of an endpoint with respect to USB- and AHB-related events. It is shown in Figure724. The application must read this register when the IN endpoints interrupt bit of the core interrupt register (IEPINT in OTG_GINTSTS) is set. Before the application can read this register, it must first read the device all endpoints interrupt (OTG_DAINT) register to get the exact endpoint number for the device endpoint-x interrupt register. The application must clear the appropriate bit in this register to clear the corresponding bits in the OTG_DAINT and OTG_GINTSTS registers.
  $910 constant OTG_OTG_DIEPTSIZ0       \ The application must modify this register before enabling endpoint 0.
  $914 constant OTG_OTG_DIEPDMA0        \ OTG device IN endpoint 0 DMA address register
  $918 constant OTG_OTG_DTXFSTS0        \ This read-only register contains the free space information for the device IN endpoint Tx FIFO.
  $920 constant OTG_OTG_DIEPCTL1        \ The application uses this register to control the behavior of each logical endpoint other than endpoint 0.
  $928 constant OTG_OTG_DIEPINT1        \ This register indicates the status of an endpoint with respect to USB- and AHB-related events. It is shown in Figure724. The application must read this register when the IN endpoints interrupt bit of the core interrupt register (IEPINT in OTG_GINTSTS) is set. Before the application can read this register, it must first read the device all endpoints interrupt (OTG_DAINT) register to get the exact endpoint number for the device endpoint-x interrupt register. The application must clear the appropriate bit in this register to clear the corresponding bits in the OTG_DAINT and OTG_GINTSTS registers.
  $930 constant OTG_OTG_DIEPTSIZ1       \ The application must modify this register before enabling the endpoint. Once the endpoint is enabled using the endpoint enable bit in the OTG_DIEPCTLx registers (EPENA bit in OTG_DIEPCTLx), the core modifies this register. The application can only read this register once the core has cleared the endpoint enable bit.
  $934 constant OTG_OTG_DIEPDMA1        \ OTG device IN endpoint 1 DMA address register
  $938 constant OTG_OTG_DTXFSTS1        \ This read-only register contains the free space information for the device IN endpoint Tx FIFO.
  $940 constant OTG_OTG_DIEPCTL2        \ The application uses this register to control the behavior of each logical endpoint other than endpoint 0.
  $948 constant OTG_OTG_DIEPINT2        \ This register indicates the status of an endpoint with respect to USB- and AHB-related events. It is shown in Figure724. The application must read this register when the IN endpoints interrupt bit of the core interrupt register (IEPINT in OTG_GINTSTS) is set. Before the application can read this register, it must first read the device all endpoints interrupt (OTG_DAINT) register to get the exact endpoint number for the device endpoint-x interrupt register. The application must clear the appropriate bit in this register to clear the corresponding bits in the OTG_DAINT and OTG_GINTSTS registers.
  $950 constant OTG_OTG_DIEPTSIZ2       \ The application must modify this register before enabling the endpoint. Once the endpoint is enabled using the endpoint enable bit in the OTG_DIEPCTLx registers (EPENA bit in OTG_DIEPCTLx), the core modifies this register. The application can only read this register once the core has cleared the endpoint enable bit.
  $954 constant OTG_OTG_DIEPDMA2        \ OTG device IN endpoint 2 DMA address register
  $958 constant OTG_OTG_DTXFSTS2        \ This read-only register contains the free space information for the device IN endpoint Tx FIFO.
  $960 constant OTG_OTG_DIEPCTL3        \ The application uses this register to control the behavior of each logical endpoint other than endpoint 0.
  $968 constant OTG_OTG_DIEPINT3        \ This register indicates the status of an endpoint with respect to USB- and AHB-related events. It is shown in Figure724. The application must read this register when the IN endpoints interrupt bit of the core interrupt register (IEPINT in OTG_GINTSTS) is set. Before the application can read this register, it must first read the device all endpoints interrupt (OTG_DAINT) register to get the exact endpoint number for the device endpoint-x interrupt register. The application must clear the appropriate bit in this register to clear the corresponding bits in the OTG_DAINT and OTG_GINTSTS registers.
  $970 constant OTG_OTG_DIEPTSIZ3       \ The application must modify this register before enabling the endpoint. Once the endpoint is enabled using the endpoint enable bit in the OTG_DIEPCTLx registers (EPENA bit in OTG_DIEPCTLx), the core modifies this register. The application can only read this register once the core has cleared the endpoint enable bit.
  $974 constant OTG_OTG_DIEPDMA3        \ OTG device IN endpoint 3 DMA address register
  $978 constant OTG_OTG_DTXFSTS3        \ This read-only register contains the free space information for the device IN endpoint Tx FIFO.
  $980 constant OTG_OTG_DIEPCTL4        \ The application uses this register to control the behavior of each logical endpoint other than endpoint 0.
  $988 constant OTG_OTG_DIEPINT4        \ This register indicates the status of an endpoint with respect to USB- and AHB-related events. It is shown in Figure724. The application must read this register when the IN endpoints interrupt bit of the core interrupt register (IEPINT in OTG_GINTSTS) is set. Before the application can read this register, it must first read the device all endpoints interrupt (OTG_DAINT) register to get the exact endpoint number for the device endpoint-x interrupt register. The application must clear the appropriate bit in this register to clear the corresponding bits in the OTG_DAINT and OTG_GINTSTS registers.
  $990 constant OTG_OTG_DIEPTSIZ4       \ The application must modify this register before enabling the endpoint. Once the endpoint is enabled using the endpoint enable bit in the OTG_DIEPCTLx registers (EPENA bit in OTG_DIEPCTLx), the core modifies this register. The application can only read this register once the core has cleared the endpoint enable bit.
  $994 constant OTG_OTG_DIEPDMA4        \ OTG device IN endpoint 4 DMA address register
  $998 constant OTG_OTG_DTXFSTS4        \ This read-only register contains the free space information for the device IN endpoint Tx FIFO.
  $9A0 constant OTG_OTG_DIEPCTL5        \ The application uses this register to control the behavior of each logical endpoint other than endpoint 0.
  $9A8 constant OTG_OTG_DIEPINT5        \ This register indicates the status of an endpoint with respect to USB- and AHB-related events. It is shown in Figure724. The application must read this register when the IN endpoints interrupt bit of the core interrupt register (IEPINT in OTG_GINTSTS) is set. Before the application can read this register, it must first read the device all endpoints interrupt (OTG_DAINT) register to get the exact endpoint number for the device endpoint-x interrupt register. The application must clear the appropriate bit in this register to clear the corresponding bits in the OTG_DAINT and OTG_GINTSTS registers.
  $9B0 constant OTG_OTG_DIEPTSIZ5       \ The application must modify this register before enabling the endpoint. Once the endpoint is enabled using the endpoint enable bit in the OTG_DIEPCTLx registers (EPENA bit in OTG_DIEPCTLx), the core modifies this register. The application can only read this register once the core has cleared the endpoint enable bit.
  $9B4 constant OTG_OTG_DIEPDMA5        \ OTG device IN endpoint 5 DMA address register
  $9B8 constant OTG_OTG_DTXFSTS5        \ This read-only register contains the free space information for the device IN endpoint Tx FIFO.
  $9C0 constant OTG_OTG_DIEPCTL6        \ The application uses this register to control the behavior of each logical endpoint other than endpoint 0.
  $9C8 constant OTG_OTG_DIEPINT6        \ This register indicates the status of an endpoint with respect to USB- and AHB-related events. It is shown in Figure724. The application must read this register when the IN endpoints interrupt bit of the core interrupt register (IEPINT in OTG_GINTSTS) is set. Before the application can read this register, it must first read the device all endpoints interrupt (OTG_DAINT) register to get the exact endpoint number for the device endpoint-x interrupt register. The application must clear the appropriate bit in this register to clear the corresponding bits in the OTG_DAINT and OTG_GINTSTS registers.
  $9D0 constant OTG_OTG_DIEPTSIZ6       \ The application must modify this register before enabling the endpoint. Once the endpoint is enabled using the endpoint enable bit in the OTG_DIEPCTLx registers (EPENA bit in OTG_DIEPCTLx), the core modifies this register. The application can only read this register once the core has cleared the endpoint enable bit.
  $9D4 constant OTG_OTG_DIEPDMA6        \ OTG device IN endpoint 6 DMA address register
  $9D8 constant OTG_OTG_DTXFSTS6        \ This read-only register contains the free space information for the device IN endpoint Tx FIFO.
  $9E0 constant OTG_OTG_DIEPCTL7        \ The application uses this register to control the behavior of each logical endpoint other than endpoint 0.
  $9E8 constant OTG_OTG_DIEPINT7        \ This register indicates the status of an endpoint with respect to USB- and AHB-related events. It is shown in Figure724. The application must read this register when the IN endpoints interrupt bit of the core interrupt register (IEPINT in OTG_GINTSTS) is set. Before the application can read this register, it must first read the device all endpoints interrupt (OTG_DAINT) register to get the exact endpoint number for the device endpoint-x interrupt register. The application must clear the appropriate bit in this register to clear the corresponding bits in the OTG_DAINT and OTG_GINTSTS registers.
  $9F0 constant OTG_OTG_DIEPTSIZ7       \ The application must modify this register before enabling the endpoint. Once the endpoint is enabled using the endpoint enable bit in the OTG_DIEPCTLx registers (EPENA bit in OTG_DIEPCTLx), the core modifies this register. The application can only read this register once the core has cleared the endpoint enable bit.
  $9F4 constant OTG_OTG_DIEPDMA7        \ OTG device IN endpoint 7 DMA address register
  $9F8 constant OTG_OTG_DTXFSTS7        \ This read-only register contains the free space information for the device IN endpoint Tx FIFO.
  $A00 constant OTG_OTG_DIEPCTL8        \ The application uses this register to control the behavior of each logical endpoint other than endpoint 0.
  $A08 constant OTG_OTG_DIEPINT8        \ This register indicates the status of an endpoint with respect to USB- and AHB-related events. It is shown in Figure724. The application must read this register when the IN endpoints interrupt bit of the core interrupt register (IEPINT in OTG_GINTSTS) is set. Before the application can read this register, it must first read the device all endpoints interrupt (OTG_DAINT) register to get the exact endpoint number for the device endpoint-x interrupt register. The application must clear the appropriate bit in this register to clear the corresponding bits in the OTG_DAINT and OTG_GINTSTS registers.
  $A10 constant OTG_OTG_DIEPTSIZ8       \ The application must modify this register before enabling the endpoint. Once the endpoint is enabled using the endpoint enable bit in the OTG_DIEPCTLx registers (EPENA bit in OTG_DIEPCTLx), the core modifies this register. The application can only read this register once the core has cleared the endpoint enable bit.
  $A14 constant OTG_OTG_DIEPDMA8        \ OTG device IN endpoint 8 DMA address register
  $A18 constant OTG_OTG_DTXFSTS8        \ This read-only register contains the free space information for the device IN endpoint Tx FIFO.
  $B00 constant OTG_OTG_DOEPCTL0        \ This section describes the OTG_DOEPCTL0 register.
  $B08 constant OTG_OTG_DOEPINT0        \ This register indicates the status of an endpoint with respect to USB- and AHB-related events. It is shown in Figure724. The application must read this register when the OUT endpoints interrupt bit of the OTG_GINTSTS register (OEPINT bit in OTG_GINTSTS) is set. Before the application can read this register, it must first read the OTG_DAINT register to get the exact endpoint number for the OTG_DOEPINTx register. The application must clear the appropriate bit in this register to clear the corresponding bits in the OTG_DAINT and OTG_GINTSTS registers.
  $B10 constant OTG_OTG_DOEPTSIZ0       \ The application must modify this register before enabling endpoint 0.
  $B14 constant OTG_OTG_DOEPDMA0        \ OTG device OUT endpoint 0 DMA address register
  $B20 constant OTG_OTG_DOEPCTL1        \ The application uses this register to control the behavior of each logical endpoint other than endpoint 0.
  $B28 constant OTG_OTG_DOEPINT1        \ This register indicates the status of an endpoint with respect to USB- and AHB-related events. It is shown in Figure724. The application must read this register when the OUT endpoints interrupt bit of the OTG_GINTSTS register (OEPINT bit in OTG_GINTSTS) is set. Before the application can read this register, it must first read the OTG_DAINT register to get the exact endpoint number for the OTG_DOEPINTx register. The application must clear the appropriate bit in this register to clear the corresponding bits in the OTG_DAINT and OTG_GINTSTS registers.
  $B30 constant OTG_OTG_DOEPTSIZ1       \ The application must modify this register before enabling the endpoint. Once the endpoint is enabled using endpoint enable bit of the OTG_DOEPCTLx registers (EPENA bit in OTG_DOEPCTLx), the core modifies this register. The application can only read this register once the core has cleared the endpoint enable bit.
  $B34 constant OTG_OTG_DOEPDMA1        \ OTG device OUT endpoint 1 DMA address register
  $B40 constant OTG_OTG_DOEPCTL2        \ The application uses this register to control the behavior of each logical endpoint other than endpoint 0.
  $B48 constant OTG_OTG_DOEPINT2        \ This register indicates the status of an endpoint with respect to USB- and AHB-related events. It is shown in Figure724. The application must read this register when the OUT endpoints interrupt bit of the OTG_GINTSTS register (OEPINT bit in OTG_GINTSTS) is set. Before the application can read this register, it must first read the OTG_DAINT register to get the exact endpoint number for the OTG_DOEPINTx register. The application must clear the appropriate bit in this register to clear the corresponding bits in the OTG_DAINT and OTG_GINTSTS registers.
  $B50 constant OTG_OTG_DOEPTSIZ2       \ The application must modify this register before enabling the endpoint. Once the endpoint is enabled using endpoint enable bit of the OTG_DOEPCTLx registers (EPENA bit in OTG_DOEPCTLx), the core modifies this register. The application can only read this register once the core has cleared the endpoint enable bit.
  $B54 constant OTG_OTG_DOEPDMA2        \ OTG device OUT endpoint 2 DMA address register
  $B60 constant OTG_OTG_DOEPCTL3        \ The application uses this register to control the behavior of each logical endpoint other than endpoint 0.
  $B68 constant OTG_OTG_DOEPINT3        \ This register indicates the status of an endpoint with respect to USB- and AHB-related events. It is shown in Figure724. The application must read this register when the OUT endpoints interrupt bit of the OTG_GINTSTS register (OEPINT bit in OTG_GINTSTS) is set. Before the application can read this register, it must first read the OTG_DAINT register to get the exact endpoint number for the OTG_DOEPINTx register. The application must clear the appropriate bit in this register to clear the corresponding bits in the OTG_DAINT and OTG_GINTSTS registers.
  $B70 constant OTG_OTG_DOEPTSIZ3       \ The application must modify this register before enabling the endpoint. Once the endpoint is enabled using endpoint enable bit of the OTG_DOEPCTLx registers (EPENA bit in OTG_DOEPCTLx), the core modifies this register. The application can only read this register once the core has cleared the endpoint enable bit.
  $B74 constant OTG_OTG_DOEPDMA3        \ OTG device OUT endpoint 3 DMA address register
  $B80 constant OTG_OTG_DOEPCTL4        \ The application uses this register to control the behavior of each logical endpoint other than endpoint 0.
  $B88 constant OTG_OTG_DOEPINT4        \ This register indicates the status of an endpoint with respect to USB- and AHB-related events. It is shown in Figure724. The application must read this register when the OUT endpoints interrupt bit of the OTG_GINTSTS register (OEPINT bit in OTG_GINTSTS) is set. Before the application can read this register, it must first read the OTG_DAINT register to get the exact endpoint number for the OTG_DOEPINTx register. The application must clear the appropriate bit in this register to clear the corresponding bits in the OTG_DAINT and OTG_GINTSTS registers.
  $B90 constant OTG_OTG_DOEPTSIZ4       \ The application must modify this register before enabling the endpoint. Once the endpoint is enabled using endpoint enable bit of the OTG_DOEPCTLx registers (EPENA bit in OTG_DOEPCTLx), the core modifies this register. The application can only read this register once the core has cleared the endpoint enable bit.
  $B94 constant OTG_OTG_DOEPDMA4        \ OTG device OUT endpoint 4 DMA address register
  $BA0 constant OTG_OTG_DOEPCTL5        \ The application uses this register to control the behavior of each logical endpoint other than endpoint 0.
  $BA8 constant OTG_OTG_DOEPINT5        \ This register indicates the status of an endpoint with respect to USB- and AHB-related events. It is shown in Figure724. The application must read this register when the OUT endpoints interrupt bit of the OTG_GINTSTS register (OEPINT bit in OTG_GINTSTS) is set. Before the application can read this register, it must first read the OTG_DAINT register to get the exact endpoint number for the OTG_DOEPINTx register. The application must clear the appropriate bit in this register to clear the corresponding bits in the OTG_DAINT and OTG_GINTSTS registers.
  $BB0 constant OTG_OTG_DOEPTSIZ5       \ The application must modify this register before enabling the endpoint. Once the endpoint is enabled using endpoint enable bit of the OTG_DOEPCTLx registers (EPENA bit in OTG_DOEPCTLx), the core modifies this register. The application can only read this register once the core has cleared the endpoint enable bit.
  $BB4 constant OTG_OTG_DOEPDMA5        \ OTG device OUT endpoint 5 DMA address register
  $BC0 constant OTG_OTG_DOEPCTL6        \ The application uses this register to control the behavior of each logical endpoint other than endpoint 0.
  $BC8 constant OTG_OTG_DOEPINT6        \ This register indicates the status of an endpoint with respect to USB- and AHB-related events. It is shown in Figure724. The application must read this register when the OUT endpoints interrupt bit of the OTG_GINTSTS register (OEPINT bit in OTG_GINTSTS) is set. Before the application can read this register, it must first read the OTG_DAINT register to get the exact endpoint number for the OTG_DOEPINTx register. The application must clear the appropriate bit in this register to clear the corresponding bits in the OTG_DAINT and OTG_GINTSTS registers.
  $BD0 constant OTG_OTG_DOEPTSIZ6       \ The application must modify this register before enabling the endpoint. Once the endpoint is enabled using endpoint enable bit of the OTG_DOEPCTLx registers (EPENA bit in OTG_DOEPCTLx), the core modifies this register. The application can only read this register once the core has cleared the endpoint enable bit.
  $BD4 constant OTG_OTG_DOEPDMA6        \ OTG device OUT endpoint 6 DMA address register
  $BE0 constant OTG_OTG_DOEPCTL7        \ The application uses this register to control the behavior of each logical endpoint other than endpoint 0.
  $BE8 constant OTG_OTG_DOEPINT7        \ This register indicates the status of an endpoint with respect to USB- and AHB-related events. It is shown in Figure724. The application must read this register when the OUT endpoints interrupt bit of the OTG_GINTSTS register (OEPINT bit in OTG_GINTSTS) is set. Before the application can read this register, it must first read the OTG_DAINT register to get the exact endpoint number for the OTG_DOEPINTx register. The application must clear the appropriate bit in this register to clear the corresponding bits in the OTG_DAINT and OTG_GINTSTS registers.
  $BF0 constant OTG_OTG_DOEPTSIZ7       \ The application must modify this register before enabling the endpoint. Once the endpoint is enabled using endpoint enable bit of the OTG_DOEPCTLx registers (EPENA bit in OTG_DOEPCTLx), the core modifies this register. The application can only read this register once the core has cleared the endpoint enable bit.
  $BF4 constant OTG_OTG_DOEPDMA7        \ OTG device OUT endpoint 7 DMA address register
  $C00 constant OTG_OTG_DOEPCTL8        \ The application uses this register to control the behavior of each logical endpoint other than endpoint 0.
  $C08 constant OTG_OTG_DOEPINT8        \ This register indicates the status of an endpoint with respect to USB- and AHB-related events. It is shown in Figure724. The application must read this register when the OUT endpoints interrupt bit of the OTG_GINTSTS register (OEPINT bit in OTG_GINTSTS) is set. Before the application can read this register, it must first read the OTG_DAINT register to get the exact endpoint number for the OTG_DOEPINTx register. The application must clear the appropriate bit in this register to clear the corresponding bits in the OTG_DAINT and OTG_GINTSTS registers.
  $C10 constant OTG_OTG_DOEPTSIZ8       \ The application must modify this register before enabling the endpoint. Once the endpoint is enabled using endpoint enable bit of the OTG_DOEPCTLx registers (EPENA bit in OTG_DOEPCTLx), the core modifies this register. The application can only read this register once the core has cleared the endpoint enable bit.
  $C14 constant OTG_OTG_DOEPDMA8        \ OTG device OUT endpoint 8 DMA address register
  $E00 constant OTG_OTG_PCGCCTL         \ This register is available in host and device modes.

: OTG_DEF ; [then]
