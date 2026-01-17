\
\ @file otg_fs.fs
\ @brief OTG_FS
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] OTG_FS_DEF

  [ifdef] OTG_FS_GOTGCTL_DEF
    \
    \ @brief The GOTGCTL register controls the behavior and reflects the status of the OTG function of the core.
    \ Address offset: 0x00
    \ Reset value: 0x00010000
    \
    $00 constant OTG_FS_SRQSCS                  \ [0x00] SRQSCS
    $01 constant OTG_FS_SRQ                     \ [0x01] SRQ
    $02 constant OTG_FS_VBVALOEN                \ [0x02] VBVALOEN
    $03 constant OTG_FS_VBVALOVAL               \ [0x03] VBVALOVAL
    $04 constant OTG_FS_AVALOEN                 \ [0x04] AVALOEN
    $05 constant OTG_FS_AVALOVAL                \ [0x05] AVALOVAL
    $06 constant OTG_FS_BVALOEN                 \ [0x06] BVALOEN
    $07 constant OTG_FS_BVALOVAL                \ [0x07] BVALOVAL
    $08 constant OTG_FS_HNGSCS                  \ [0x08] HNGSCS
    $09 constant OTG_FS_HNPRQ                   \ [0x09] HNPRQ
    $0a constant OTG_FS_HSHNPEN                 \ [0x0a] HSHNPEN
    $0b constant OTG_FS_DHNPEN                  \ [0x0b] DHNPEN
    $0c constant OTG_FS_EHEN                    \ [0x0c] EHEN
    $10 constant OTG_FS_CIDSTS                  \ [0x10] CIDSTS
    $11 constant OTG_FS_DBCT                    \ [0x11] DBCT
    $12 constant OTG_FS_ASVLD                   \ [0x12] ASVLD
    $13 constant OTG_FS_BSVLD                   \ [0x13] BSVLD
    $14 constant OTG_FS_OTGVER                  \ [0x14] OTGVER
    $15 constant OTG_FS_CURMOD                  \ [0x15] CURMOD
  [then]


  [ifdef] OTG_FS_GOTGINT_DEF
    \
    \ @brief The application reads this register whenever there is an OTG interrupt and clears the bits in this register to clear the OTG interrupt.
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $02 constant OTG_FS_SEDET                   \ [0x02] SEDET
    $08 constant OTG_FS_SRSSCHG                 \ [0x08] SRSSCHG
    $09 constant OTG_FS_HNSSCHG                 \ [0x09] HNSSCHG
    $11 constant OTG_FS_HNGDET                  \ [0x11] HNGDET
    $12 constant OTG_FS_ADTOCHG                 \ [0x12] ADTOCHG
    $13 constant OTG_FS_DBCDNE                  \ [0x13] DBCDNE
  [then]


  [ifdef] OTG_FS_GAHBCFG_DEF
    \
    \ @brief This register can be used to configure the core after power-on or a change in mode. This register mainly contains AHB system-related configuration parameters. Do not change this register after the initial programming. The application must program this register before starting any transactions on either the AHB or the USB.
    \ Address offset: 0x08
    \ Reset value: 0x00000000
    \
    $00 constant OTG_FS_GINTMSK                 \ [0x00] GINTMSK
    $07 constant OTG_FS_TXFELVL                 \ [0x07] TXFELVL
    $08 constant OTG_FS_PTXFELVL                \ [0x08] PTXFELVL
  [then]


  [ifdef] OTG_FS_GUSBCFG_DEF
    \
    \ @brief This register can be used to configure the core after power-on or a changing to host mode or device mode. It contains USB and USB-PHY related configuration parameters. The application must program this register before starting any transactions on either the AHB or the USB. Do not make changes to this register after the initial programming.
    \ Address offset: 0x0C
    \ Reset value: 0x00001440
    \
    $00 constant OTG_FS_TOCAL                   \ [0x00 : 3] TOCAL
    $06 constant OTG_FS_PHYSEL                  \ [0x06] PHYSEL
    $08 constant OTG_FS_SRPCAP                  \ [0x08] SRPCAP
    $09 constant OTG_FS_HNPCAP                  \ [0x09] HNPCAP
    $0a constant OTG_FS_TRDT                    \ [0x0a : 4] TRDT
    $1d constant OTG_FS_FHMOD                   \ [0x1d] FHMOD
    $1e constant OTG_FS_FDMOD                   \ [0x1e] FDMOD
  [then]


  [ifdef] OTG_FS_GRSTCTL_DEF
    \
    \ @brief The application uses this register to reset various hardware features inside the core.
    \ Address offset: 0x10
    \ Reset value: 0x80000000
    \
    $00 constant OTG_FS_CSRST                   \ [0x00] CSRST
    $01 constant OTG_FS_PSRST                   \ [0x01] PSRST
    $02 constant OTG_FS_FSRST                   \ [0x02] FSRST
    $04 constant OTG_FS_RXFFLSH                 \ [0x04] RXFFLSH
    $05 constant OTG_FS_TXFFLSH                 \ [0x05] TXFFLSH
    $06 constant OTG_FS_TXFNUM                  \ [0x06 : 5] TXFNUM
    $1f constant OTG_FS_AHBIDL                  \ [0x1f] AHBIDL
  [then]


  [ifdef] OTG_FS_GINTSTS_DEF
    \
    \ @brief This register interrupts the application for system-level events in the current mode (device mode or host mode). Some of the bits in this register are valid only in host mode, while others are valid in device mode only. This register also indicates the current mode. To clear the interrupt status bits of the rc_w1 type, the application must write 1 into the bit. The FIFO status interrupts are read-only; once software reads from or writes to the FIFO while servicing these interrupts, FIFO interrupt conditions are cleared automatically. The application must clear the GINTSTS register at initialization before unmasking the interrupt bit to avoid any interrupts generated prior to initialization.
    \ Address offset: 0x14
    \ Reset value: 0x04000020
    \
    $00 constant OTG_FS_CMOD                    \ [0x00] CMOD
    $01 constant OTG_FS_MMIS                    \ [0x01] MMIS
    $02 constant OTG_FS_OTGINT                  \ [0x02] OTGINT
    $03 constant OTG_FS_SOF                     \ [0x03] SOF
    $04 constant OTG_FS_RXFLVL                  \ [0x04] RXFLVL
    $05 constant OTG_FS_NPTXFE                  \ [0x05] NPTXFE
    $06 constant OTG_FS_GINAKEFF                \ [0x06] GINAKEFF
    $07 constant OTG_FS_GONAKEFF                \ [0x07] GONAKEFF
    $0a constant OTG_FS_ESUSP                   \ [0x0a] ESUSP
    $0b constant OTG_FS_USBSUSP                 \ [0x0b] USBSUSP
    $0c constant OTG_FS_USBRST                  \ [0x0c] USBRST
    $0d constant OTG_FS_ENUMDNE                 \ [0x0d] ENUMDNE
    $0e constant OTG_FS_ISOODRP                 \ [0x0e] ISOODRP
    $0f constant OTG_FS_EOPF                    \ [0x0f] EOPF
    $12 constant OTG_FS_IEPINT                  \ [0x12] IEPINT
    $13 constant OTG_FS_OEPINT                  \ [0x13] OEPINT
    $14 constant OTG_FS_IISOIXFR                \ [0x14] IISOIXFR
    $15 constant OTG_FS_IPXFR                   \ [0x15] IPXFR
    $17 constant OTG_FS_RSTDET                  \ [0x17] RSTDET
    $18 constant OTG_FS_HPRTINT                 \ [0x18] HPRTINT
    $19 constant OTG_FS_HCINT                   \ [0x19] HCINT
    $1a constant OTG_FS_PTXFE                   \ [0x1a] PTXFE
    $1b constant OTG_FS_LPMINT                  \ [0x1b] LPMINT
    $1c constant OTG_FS_CIDSCHG                 \ [0x1c] CIDSCHG
    $1d constant OTG_FS_DISCINT                 \ [0x1d] DISCINT
    $1e constant OTG_FS_SRQINT                  \ [0x1e] SRQINT
    $1f constant OTG_FS_WKUPINT                 \ [0x1f] WKUPINT
  [then]


  [ifdef] OTG_FS_GINTMSK_DEF
    \
    \ @brief This register works with the core interrupt register to interrupt the application. When an interrupt bit is masked, the interrupt associated with that bit is not generated. However, the core interrupt (GINTSTS) register bit corresponding to that interrupt is still set.
    \ Address offset: 0x18
    \ Reset value: 0x00000000
    \
    $01 constant OTG_FS_MMISM                   \ [0x01] MMISM
    $02 constant OTG_FS_OTGINT                  \ [0x02] OTGINT
    $03 constant OTG_FS_SOFM                    \ [0x03] SOFM
    $04 constant OTG_FS_RXFLVLM                 \ [0x04] RXFLVLM
    $05 constant OTG_FS_NPTXFEM                 \ [0x05] NPTXFEM
    $06 constant OTG_FS_GINAKEFFM               \ [0x06] GINAKEFFM
    $07 constant OTG_FS_GONAKEFFM               \ [0x07] GONAKEFFM
    $0a constant OTG_FS_ESUSPM                  \ [0x0a] ESUSPM
    $0b constant OTG_FS_USBSUSPM                \ [0x0b] USBSUSPM
    $0c constant OTG_FS_USBRST                  \ [0x0c] USBRST
    $0d constant OTG_FS_ENUMDNEM                \ [0x0d] ENUMDNEM
    $0e constant OTG_FS_ISOODRPM                \ [0x0e] ISOODRPM
    $0f constant OTG_FS_EOPFM                   \ [0x0f] EOPFM
    $12 constant OTG_FS_IEPINT                  \ [0x12] IEPINT
    $13 constant OTG_FS_OEPINT                  \ [0x13] OEPINT
    $14 constant OTG_FS_IISOIXFRM               \ [0x14] IISOIXFRM
    $15 constant OTG_FS_IPXFRM                  \ [0x15] IPXFRM
    $17 constant OTG_FS_RSTDETM                 \ [0x17] RSTDETM
    $18 constant OTG_FS_PRTIM                   \ [0x18] PRTIM
    $19 constant OTG_FS_HCIM                    \ [0x19] HCIM
    $1a constant OTG_FS_PTXFEM                  \ [0x1a] PTXFEM
    $1b constant OTG_FS_LPMINTM                 \ [0x1b] LPMINTM
    $1c constant OTG_FS_CIDSCHGM                \ [0x1c] CIDSCHGM
    $1d constant OTG_FS_DISCINT                 \ [0x1d] DISCINT
    $1e constant OTG_FS_SRQIM                   \ [0x1e] SRQIM
    $1f constant OTG_FS_WUIM                    \ [0x1f] WUIM
  [then]


  [ifdef] OTG_FS_GRXSTSR_DEVICE_DEF
    \
    \ @brief This description is for register GRXSTSR in Device mode. A read to the receive status debug read register returns the contents of the top of the receive FIFO. The core ignores the receive status read when the receive FIFO is empty and returns a value of 0x00000000.
    \ Address offset: 0x1C
    \ Reset value: 0x00000000
    \
    $00 constant OTG_FS_EPNUM                   \ [0x00 : 4] EPNUM
    $04 constant OTG_FS_BCNT                    \ [0x04 : 11] BCNT
    $0f constant OTG_FS_DPID                    \ [0x0f : 2] DPID
    $11 constant OTG_FS_PKTSTS                  \ [0x11 : 4] PKTSTS
    $15 constant OTG_FS_FRMNUM                  \ [0x15 : 4] FRMNUM
    $1b constant OTG_FS_STSPHST                 \ [0x1b] STSPHST
  [then]


  [ifdef] OTG_FS_GRXSTSR_HOST_DEF
    \
    \ @brief This description is for register GRXSTSR in Host mode
    \ Address offset: 0x1C
    \ Reset value: 0x00000000
    \
    $00 constant OTG_FS_CHNUM                   \ [0x00 : 4] CHNUM
    $04 constant OTG_FS_BCNT                    \ [0x04 : 11] BCNT
    $0f constant OTG_FS_DPID                    \ [0x0f : 2] DPID
    $11 constant OTG_FS_PKTSTS                  \ [0x11 : 4] PKTSTS
  [then]


  [ifdef] OTG_FS_GRXSTSP_DEVICE_DEF
    \
    \ @brief This description is for register GRXSTSP in Device mode. Similarly to GRXSTSR (receive status debug read register) where a read returns the contents of the top of the receive FIFO, a read to GRXSTSP (receive status read and pop register) additionally pops the top data entry out of the Rx FIFO. The core ignores the receive status pop/read when the receive FIFO is empty and returns a value of 0x00000000. The application must only pop the receive status FIFO when the receive FIFO non-empty bit of the core interrupt register (RXFLVL bit in GINTSTS) is asserted.
    \ Address offset: 0x20
    \ Reset value: 0x00000000
    \
    $00 constant OTG_FS_EPNUM                   \ [0x00 : 4] EPNUM
    $04 constant OTG_FS_BCNT                    \ [0x04 : 11] BCNT
    $0f constant OTG_FS_DPID                    \ [0x0f : 2] DPID
    $11 constant OTG_FS_PKTSTS                  \ [0x11 : 4] PKTSTS
    $15 constant OTG_FS_FRMNUM                  \ [0x15 : 4] FRMNUM
    $1b constant OTG_FS_STSPHST                 \ [0x1b] STSPHST
  [then]


  [ifdef] OTG_FS_GRXSTSP_HOST_DEF
    \
    \ @brief This description is for register GRXSTSP in HOST mode
    \ Address offset: 0x20
    \ Reset value: 0x00000000
    \
    $00 constant OTG_FS_CHNUM                   \ [0x00 : 4] CHNUM
    $04 constant OTG_FS_BCNT                    \ [0x04 : 11] BCNT
    $0f constant OTG_FS_DPID                    \ [0x0f : 2] DPID
    $11 constant OTG_FS_PKTSTS                  \ [0x11 : 4] PKTSTS
  [then]


  [ifdef] OTG_FS_GRXFSIZ_DEF
    \
    \ @brief The application can program the RAM size that must be allocated to the Rx FIFO.
    \ Address offset: 0x24
    \ Reset value: 0x00000200
    \
    $00 constant OTG_FS_RXFD                    \ [0x00 : 16] RXFD
  [then]


  [ifdef] OTG_FS_HNPTXFSIZ_DEF
    \
    \ @brief Host mode
    \ Address offset: 0x28
    \ Reset value: 0x02000200
    \
    $00 constant OTG_FS_NPTXFSA                 \ [0x00 : 16] NPTXFSA
    $10 constant OTG_FS_NPTXFD                  \ [0x10 : 16] NPTXFD
  [then]


  [ifdef] OTG_FS_HNPTXSTS_DEF
    \
    \ @brief In device mode, this register is not valid. This read-only register contains the free space information for the non-periodic Tx FIFO and the non-periodic transmit request queue.
    \ Address offset: 0x2C
    \ Reset value: 0x00080200
    \
    $00 constant OTG_FS_NPTXFSAV                \ [0x00 : 16] NPTXFSAV
    $10 constant OTG_FS_NPTQXSAV                \ [0x10 : 8] NPTQXSAV
    $18 constant OTG_FS_NPTXQTOP                \ [0x18 : 7] NPTXQTOP
  [then]


  [ifdef] OTG_FS_GCCFG_DEF
    \
    \ @brief OTG general core configuration register
    \ Address offset: 0x38
    \ Reset value: 0x00000000
    \
    $00 constant OTG_FS_DCDET                   \ [0x00] DCDET
    $01 constant OTG_FS_PDET                    \ [0x01] PDET
    $02 constant OTG_FS_SDET                    \ [0x02] SDET
    $03 constant OTG_FS_PS2DET                  \ [0x03] PS2DET
    $10 constant OTG_FS_PWRDWN                  \ [0x10] PWRDWN
    $11 constant OTG_FS_BCDEN                   \ [0x11] BCDEN
    $12 constant OTG_FS_DCDEN                   \ [0x12] DCDEN
    $13 constant OTG_FS_PDEN                    \ [0x13] PDEN
    $14 constant OTG_FS_SDEN                    \ [0x14] SDEN
    $15 constant OTG_FS_VBDEN                   \ [0x15] VBDEN
  [then]


  [ifdef] OTG_FS_CID_DEF
    \
    \ @brief This is a register containing the Product ID as reset value.
    \ Address offset: 0x3C
    \ Reset value: 0x00003000
    \
    $00 constant OTG_FS_PRODUCT_ID              \ [0x00 : 32] PRODUCT_ID
  [then]


  [ifdef] OTG_FS_GLPMCFG_DEF
    \
    \ @brief OTG core LPM configuration register
    \ Address offset: 0x54
    \ Reset value: 0x00000000
    \
    $00 constant OTG_FS_LPMEN                   \ [0x00] LPMEN
    $01 constant OTG_FS_LPMACK                  \ [0x01] LPMACK
    $02 constant OTG_FS_BESL                    \ [0x02 : 4] BESL
    $06 constant OTG_FS_REMWAKE                 \ [0x06] REMWAKE
    $07 constant OTG_FS_L1SSEN                  \ [0x07] L1SSEN
    $08 constant OTG_FS_BESLTHRS                \ [0x08 : 4] BESLTHRS
    $0c constant OTG_FS_L1DSEN                  \ [0x0c] L1DSEN
    $0d constant OTG_FS_LPMRSP                  \ [0x0d : 2] LPMRSP
    $0f constant OTG_FS_SLPSTS                  \ [0x0f] SLPSTS
    $10 constant OTG_FS_L1RSMOK                 \ [0x10] L1RSMOK
    $11 constant OTG_FS_LPMCHIDX                \ [0x11 : 4] LPMCHIDX
    $15 constant OTG_FS_LPMRCNT                 \ [0x15 : 3] LPMRCNT
    $18 constant OTG_FS_SNDLPM                  \ [0x18] SNDLPM
    $19 constant OTG_FS_LPMRCNTSTS              \ [0x19 : 3] LPMRCNTSTS
    $1c constant OTG_FS_ENBESL                  \ [0x1c] ENBESL
  [then]


  [ifdef] OTG_FS_HPTXFSIZ_DEF
    \
    \ @brief OTG host periodic transmit FIFO size register
    \ Address offset: 0x100
    \ Reset value: 0x02000400
    \
    $00 constant OTG_FS_PTXSA                   \ [0x00 : 16] PTXSA
    $10 constant OTG_FS_PTXFSIZ                 \ [0x10 : 16] PTXFSIZ
  [then]


  [ifdef] OTG_FS_DIEPTXF1_DEF
    \
    \ @brief OTG device IN endpoint transmit FIFO 1 size register
    \ Address offset: 0x104
    \ Reset value: 0x02000400
    \
    $00 constant OTG_FS_INEPTXSA                \ [0x00 : 16] INEPTXSA
    $10 constant OTG_FS_INEPTXFD                \ [0x10 : 16] INEPTXFD
  [then]


  [ifdef] OTG_FS_DIEPTXF2_DEF
    \
    \ @brief OTG device IN endpoint transmit FIFO 2 size register
    \ Address offset: 0x108
    \ Reset value: 0x02000600
    \
    $00 constant OTG_FS_INEPTXSA                \ [0x00 : 16] INEPTXSA
    $10 constant OTG_FS_INEPTXFD                \ [0x10 : 16] INEPTXFD
  [then]


  [ifdef] OTG_FS_DIEPTXF3_DEF
    \
    \ @brief OTG device IN endpoint transmit FIFO 3 size register
    \ Address offset: 0x10C
    \ Reset value: 0x02000800
    \
    $00 constant OTG_FS_INEPTXSA                \ [0x00 : 16] INEPTXSA
    $10 constant OTG_FS_INEPTXFD                \ [0x10 : 16] INEPTXFD
  [then]


  [ifdef] OTG_FS_DIEPTXF4_DEF
    \
    \ @brief OTG device IN endpoint transmit FIFO 4 size register
    \ Address offset: 0x110
    \ Reset value: 0x02000A00
    \
    $00 constant OTG_FS_INEPTXSA                \ [0x00 : 16] INEPTXSA
    $10 constant OTG_FS_INEPTXFD                \ [0x10 : 16] INEPTXFD
  [then]


  [ifdef] OTG_FS_DIEPTXF5_DEF
    \
    \ @brief OTG device IN endpoint transmit FIFO 5 size register
    \ Address offset: 0x114
    \ Reset value: 0x02000C00
    \
    $00 constant OTG_FS_INEPTXSA                \ [0x00 : 16] INEPTXSA
    $10 constant OTG_FS_INEPTXFD                \ [0x10 : 16] INEPTXFD
  [then]


  [ifdef] OTG_FS_HCFG_DEF
    \
    \ @brief This register configures the core after power-on. Do not make changes to this register after initializing the host.
    \ Address offset: 0x400
    \ Reset value: 0x00000000
    \
    $00 constant OTG_FS_FSLSPCS                 \ [0x00 : 2] FSLSPCS
    $02 constant OTG_FS_FSLSS                   \ [0x02] FSLSS
  [then]


  [ifdef] OTG_FS_HFIR_DEF
    \
    \ @brief This register stores the frame interval information for the current speed to which the OTG controller has enumerated.
    \ Address offset: 0x404
    \ Reset value: 0x0000EA60
    \
    $00 constant OTG_FS_FRIVL                   \ [0x00 : 16] FRIVL
    $10 constant OTG_FS_RLDCTRL                 \ [0x10] RLDCTRL
  [then]


  [ifdef] OTG_FS_HFNUM_DEF
    \
    \ @brief This register indicates the current frame number. It also indicates the time remaining (in terms of the number of PHY clocks) in the current frame.
    \ Address offset: 0x408
    \ Reset value: 0x00003FFF
    \
    $00 constant OTG_FS_FRNUM                   \ [0x00 : 16] FRNUM
    $10 constant OTG_FS_FTREM                   \ [0x10 : 16] FTREM
  [then]


  [ifdef] OTG_FS_HPTXSTS_DEF
    \
    \ @brief This read-only register contains the free space information for the periodic Tx FIFO and the periodic transmit request queue.
    \ Address offset: 0x410
    \ Reset value: 0x00080100
    \
    $00 constant OTG_FS_PTXFSAVL                \ [0x00 : 16] PTXFSAVL
    $10 constant OTG_FS_PTXQSAV                 \ [0x10 : 8] PTXQSAV
    $18 constant OTG_FS_PTXQTOP                 \ [0x18 : 8] PTXQTOP
  [then]


  [ifdef] OTG_FS_HAINT_DEF
    \
    \ @brief When a significant event occurs on a channel, the host all channels interrupt register interrupts the application using the host channels interrupt bit of the core interrupt register (HCINT bit in GINTSTS). This is shown in Figure724. There is one interrupt bit per channel, up to a maximum of 16 bits. Bits in this register are set and cleared when the application sets and clears bits in the corresponding host channel-x interrupt register.
    \ Address offset: 0x414
    \ Reset value: 0x00000000
    \
    $00 constant OTG_FS_HAINT                   \ [0x00 : 16] HAINT
  [then]


  [ifdef] OTG_FS_HAINTMSK_DEF
    \
    \ @brief The host all channel interrupt mask register works with the host all channel interrupt register to interrupt the application when an event occurs on a channel. There is one interrupt mask bit per channel, up to a maximum of 16 bits.
    \ Address offset: 0x418
    \ Reset value: 0x00000000
    \
    $00 constant OTG_FS_HAINTM                  \ [0x00 : 16] HAINTM
  [then]


  [ifdef] OTG_FS_HPRT_DEF
    \
    \ @brief This register is available only in host mode. Currently, the OTG host supports only one port. A single register holds USB port-related information such as USB reset, enable, suspend, resume, connect status, and test mode for each port. It is shown in Figure724. The rc_w1 bits in this register can trigger an interrupt to the application through the host port interrupt bit of the core interrupt register (HPRTINT bit in GINTSTS). On a port interrupt, the application must read this register and clear the bit that caused the interrupt. For the rc_w1 bits, the application must write a 1 to the bit to clear the interrupt.
    \ Address offset: 0x440
    \ Reset value: 0x00000000
    \
    $00 constant OTG_FS_PCSTS                   \ [0x00] PCSTS
    $01 constant OTG_FS_PCDET                   \ [0x01] PCDET
    $02 constant OTG_FS_PENA                    \ [0x02] PENA
    $03 constant OTG_FS_PENCHNG                 \ [0x03] PENCHNG
    $04 constant OTG_FS_POCA                    \ [0x04] POCA
    $05 constant OTG_FS_POCCHNG                 \ [0x05] POCCHNG
    $06 constant OTG_FS_PRES                    \ [0x06] PRES
    $07 constant OTG_FS_PSUSP                   \ [0x07] PSUSP
    $08 constant OTG_FS_PRST                    \ [0x08] PRST
    $0a constant OTG_FS_PLSTS                   \ [0x0a : 2] PLSTS
    $0c constant OTG_FS_PPWR                    \ [0x0c] PPWR
    $0d constant OTG_FS_PTCTL                   \ [0x0d : 4] PTCTL
    $11 constant OTG_FS_PSPD                    \ [0x11 : 2] PSPD
  [then]


  [ifdef] OTG_FS_HCCHAR0_DEF
    \
    \ @brief OTG host channel 0 characteristics register
    \ Address offset: 0x500
    \ Reset value: 0x00000000
    \
    $00 constant OTG_FS_MPSIZ                   \ [0x00 : 11] MPSIZ
    $0b constant OTG_FS_EPNUM                   \ [0x0b : 4] EPNUM
    $0f constant OTG_FS_EPDIR                   \ [0x0f] EPDIR
    $11 constant OTG_FS_LSDEV                   \ [0x11] LSDEV
    $12 constant OTG_FS_EPTYP                   \ [0x12 : 2] EPTYP
    $14 constant OTG_FS_MCNT                    \ [0x14 : 2] MCNT
    $16 constant OTG_FS_DAD                     \ [0x16 : 7] DAD
    $1d constant OTG_FS_ODDFRM                  \ [0x1d] ODDFRM
    $1e constant OTG_FS_CHDIS                   \ [0x1e] CHDIS
    $1f constant OTG_FS_CHENA                   \ [0x1f] CHENA
  [then]


  [ifdef] OTG_FS_HCINT0_DEF
    \
    \ @brief This register indicates the status of a channel with respect to USB- and AHB-related events. It is shown in Figure724. The application must read this register when the host channels interrupt bit in the core interrupt register (HCINT bit in GINTSTS) is set. Before the application can read this register, it must first read the host all channels interrupt (HAINT) register to get the exact channel number for the host channel-x interrupt register. The application must clear the appropriate bit in this register to clear the corresponding bits in the HAINT and GINTSTS registers.
    \ Address offset: 0x508
    \ Reset value: 0x00000000
    \
    $00 constant OTG_FS_XFRC                    \ [0x00] XFRC
    $01 constant OTG_FS_CHH                     \ [0x01] CHH
    $03 constant OTG_FS_STALL                   \ [0x03] STALL
    $04 constant OTG_FS_NAK                     \ [0x04] NAK
    $05 constant OTG_FS_ACK                     \ [0x05] ACK
    $07 constant OTG_FS_TXERR                   \ [0x07] TXERR
    $08 constant OTG_FS_BBERR                   \ [0x08] BBERR
    $09 constant OTG_FS_FRMOR                   \ [0x09] FRMOR
    $0a constant OTG_FS_DTERR                   \ [0x0a] DTERR
  [then]


  [ifdef] OTG_FS_HCINTMSK0_DEF
    \
    \ @brief This register reflects the mask for each channel status described in the previous section.
    \ Address offset: 0x50C
    \ Reset value: 0x00000000
    \
    $00 constant OTG_FS_XFRCM                   \ [0x00] XFRCM
    $01 constant OTG_FS_CHHM                    \ [0x01] CHHM
    $03 constant OTG_FS_STALLM                  \ [0x03] STALLM
    $04 constant OTG_FS_NAKM                    \ [0x04] NAKM
    $05 constant OTG_FS_ACKM                    \ [0x05] ACKM
    $07 constant OTG_FS_TXERRM                  \ [0x07] TXERRM
    $08 constant OTG_FS_BBERRM                  \ [0x08] BBERRM
    $09 constant OTG_FS_FRMORM                  \ [0x09] FRMORM
    $0a constant OTG_FS_DTERRM                  \ [0x0a] DTERRM
  [then]


  [ifdef] OTG_FS_HCTSIZ0_DEF
    \
    \ @brief OTG host channel 0 transfer size register
    \ Address offset: 0x510
    \ Reset value: 0x00000000
    \
    $00 constant OTG_FS_XFRSIZ                  \ [0x00 : 19] XFRSIZ
    $13 constant OTG_FS_PKTCNT                  \ [0x13 : 10] PKTCNT
    $1d constant OTG_FS_DPID                    \ [0x1d : 2] DPID
    $1f constant OTG_FS_DOPNG                   \ [0x1f] DOPNG
  [then]


  [ifdef] OTG_FS_HCCHAR1_DEF
    \
    \ @brief OTG host channel 1 characteristics register
    \ Address offset: 0x520
    \ Reset value: 0x00000000
    \
    $00 constant OTG_FS_MPSIZ                   \ [0x00 : 11] MPSIZ
    $0b constant OTG_FS_EPNUM                   \ [0x0b : 4] EPNUM
    $0f constant OTG_FS_EPDIR                   \ [0x0f] EPDIR
    $11 constant OTG_FS_LSDEV                   \ [0x11] LSDEV
    $12 constant OTG_FS_EPTYP                   \ [0x12 : 2] EPTYP
    $14 constant OTG_FS_MCNT                    \ [0x14 : 2] MCNT
    $16 constant OTG_FS_DAD                     \ [0x16 : 7] DAD
    $1d constant OTG_FS_ODDFRM                  \ [0x1d] ODDFRM
    $1e constant OTG_FS_CHDIS                   \ [0x1e] CHDIS
    $1f constant OTG_FS_CHENA                   \ [0x1f] CHENA
  [then]


  [ifdef] OTG_FS_HCINT1_DEF
    \
    \ @brief This register indicates the status of a channel with respect to USB- and AHB-related events. It is shown in Figure724. The application must read this register when the host channels interrupt bit in the core interrupt register (HCINT bit in GINTSTS) is set. Before the application can read this register, it must first read the host all channels interrupt (HAINT) register to get the exact channel number for the host channel-x interrupt register. The application must clear the appropriate bit in this register to clear the corresponding bits in the HAINT and GINTSTS registers.
    \ Address offset: 0x528
    \ Reset value: 0x00000000
    \
    $00 constant OTG_FS_XFRC                    \ [0x00] XFRC
    $01 constant OTG_FS_CHH                     \ [0x01] CHH
    $03 constant OTG_FS_STALL                   \ [0x03] STALL
    $04 constant OTG_FS_NAK                     \ [0x04] NAK
    $05 constant OTG_FS_ACK                     \ [0x05] ACK
    $07 constant OTG_FS_TXERR                   \ [0x07] TXERR
    $08 constant OTG_FS_BBERR                   \ [0x08] BBERR
    $09 constant OTG_FS_FRMOR                   \ [0x09] FRMOR
    $0a constant OTG_FS_DTERR                   \ [0x0a] DTERR
  [then]


  [ifdef] OTG_FS_HCINTMSK1_DEF
    \
    \ @brief This register reflects the mask for each channel status described in the previous section.
    \ Address offset: 0x52C
    \ Reset value: 0x00000000
    \
    $00 constant OTG_FS_XFRCM                   \ [0x00] XFRCM
    $01 constant OTG_FS_CHHM                    \ [0x01] CHHM
    $03 constant OTG_FS_STALLM                  \ [0x03] STALLM
    $04 constant OTG_FS_NAKM                    \ [0x04] NAKM
    $05 constant OTG_FS_ACKM                    \ [0x05] ACKM
    $07 constant OTG_FS_TXERRM                  \ [0x07] TXERRM
    $08 constant OTG_FS_BBERRM                  \ [0x08] BBERRM
    $09 constant OTG_FS_FRMORM                  \ [0x09] FRMORM
    $0a constant OTG_FS_DTERRM                  \ [0x0a] DTERRM
  [then]


  [ifdef] OTG_FS_HCTSIZ1_DEF
    \
    \ @brief OTG host channel 1 transfer size register
    \ Address offset: 0x530
    \ Reset value: 0x00000000
    \
    $00 constant OTG_FS_XFRSIZ                  \ [0x00 : 19] XFRSIZ
    $13 constant OTG_FS_PKTCNT                  \ [0x13 : 10] PKTCNT
    $1d constant OTG_FS_DPID                    \ [0x1d : 2] DPID
    $1f constant OTG_FS_DOPNG                   \ [0x1f] DOPNG
  [then]


  [ifdef] OTG_FS_HCCHAR2_DEF
    \
    \ @brief OTG host channel 2 characteristics register
    \ Address offset: 0x540
    \ Reset value: 0x00000000
    \
    $00 constant OTG_FS_MPSIZ                   \ [0x00 : 11] MPSIZ
    $0b constant OTG_FS_EPNUM                   \ [0x0b : 4] EPNUM
    $0f constant OTG_FS_EPDIR                   \ [0x0f] EPDIR
    $11 constant OTG_FS_LSDEV                   \ [0x11] LSDEV
    $12 constant OTG_FS_EPTYP                   \ [0x12 : 2] EPTYP
    $14 constant OTG_FS_MCNT                    \ [0x14 : 2] MCNT
    $16 constant OTG_FS_DAD                     \ [0x16 : 7] DAD
    $1d constant OTG_FS_ODDFRM                  \ [0x1d] ODDFRM
    $1e constant OTG_FS_CHDIS                   \ [0x1e] CHDIS
    $1f constant OTG_FS_CHENA                   \ [0x1f] CHENA
  [then]


  [ifdef] OTG_FS_HCINT2_DEF
    \
    \ @brief This register indicates the status of a channel with respect to USB- and AHB-related events. It is shown in Figure724. The application must read this register when the host channels interrupt bit in the core interrupt register (HCINT bit in GINTSTS) is set. Before the application can read this register, it must first read the host all channels interrupt (HAINT) register to get the exact channel number for the host channel-x interrupt register. The application must clear the appropriate bit in this register to clear the corresponding bits in the HAINT and GINTSTS registers.
    \ Address offset: 0x548
    \ Reset value: 0x00000000
    \
    $00 constant OTG_FS_XFRC                    \ [0x00] XFRC
    $01 constant OTG_FS_CHH                     \ [0x01] CHH
    $03 constant OTG_FS_STALL                   \ [0x03] STALL
    $04 constant OTG_FS_NAK                     \ [0x04] NAK
    $05 constant OTG_FS_ACK                     \ [0x05] ACK
    $07 constant OTG_FS_TXERR                   \ [0x07] TXERR
    $08 constant OTG_FS_BBERR                   \ [0x08] BBERR
    $09 constant OTG_FS_FRMOR                   \ [0x09] FRMOR
    $0a constant OTG_FS_DTERR                   \ [0x0a] DTERR
  [then]


  [ifdef] OTG_FS_HCINTMSK2_DEF
    \
    \ @brief This register reflects the mask for each channel status described in the previous section.
    \ Address offset: 0x54C
    \ Reset value: 0x00000000
    \
    $00 constant OTG_FS_XFRCM                   \ [0x00] XFRCM
    $01 constant OTG_FS_CHHM                    \ [0x01] CHHM
    $03 constant OTG_FS_STALLM                  \ [0x03] STALLM
    $04 constant OTG_FS_NAKM                    \ [0x04] NAKM
    $05 constant OTG_FS_ACKM                    \ [0x05] ACKM
    $07 constant OTG_FS_TXERRM                  \ [0x07] TXERRM
    $08 constant OTG_FS_BBERRM                  \ [0x08] BBERRM
    $09 constant OTG_FS_FRMORM                  \ [0x09] FRMORM
    $0a constant OTG_FS_DTERRM                  \ [0x0a] DTERRM
  [then]


  [ifdef] OTG_FS_HCTSIZ2_DEF
    \
    \ @brief OTG host channel 2 transfer size register
    \ Address offset: 0x550
    \ Reset value: 0x00000000
    \
    $00 constant OTG_FS_XFRSIZ                  \ [0x00 : 19] XFRSIZ
    $13 constant OTG_FS_PKTCNT                  \ [0x13 : 10] PKTCNT
    $1d constant OTG_FS_DPID                    \ [0x1d : 2] DPID
    $1f constant OTG_FS_DOPNG                   \ [0x1f] DOPNG
  [then]


  [ifdef] OTG_FS_HCCHAR3_DEF
    \
    \ @brief OTG host channel 3 characteristics register
    \ Address offset: 0x560
    \ Reset value: 0x00000000
    \
    $00 constant OTG_FS_MPSIZ                   \ [0x00 : 11] MPSIZ
    $0b constant OTG_FS_EPNUM                   \ [0x0b : 4] EPNUM
    $0f constant OTG_FS_EPDIR                   \ [0x0f] EPDIR
    $11 constant OTG_FS_LSDEV                   \ [0x11] LSDEV
    $12 constant OTG_FS_EPTYP                   \ [0x12 : 2] EPTYP
    $14 constant OTG_FS_MCNT                    \ [0x14 : 2] MCNT
    $16 constant OTG_FS_DAD                     \ [0x16 : 7] DAD
    $1d constant OTG_FS_ODDFRM                  \ [0x1d] ODDFRM
    $1e constant OTG_FS_CHDIS                   \ [0x1e] CHDIS
    $1f constant OTG_FS_CHENA                   \ [0x1f] CHENA
  [then]


  [ifdef] OTG_FS_HCINT3_DEF
    \
    \ @brief This register indicates the status of a channel with respect to USB- and AHB-related events. It is shown in Figure724. The application must read this register when the host channels interrupt bit in the core interrupt register (HCINT bit in GINTSTS) is set. Before the application can read this register, it must first read the host all channels interrupt (HAINT) register to get the exact channel number for the host channel-x interrupt register. The application must clear the appropriate bit in this register to clear the corresponding bits in the HAINT and GINTSTS registers.
    \ Address offset: 0x568
    \ Reset value: 0x00000000
    \
    $00 constant OTG_FS_XFRC                    \ [0x00] XFRC
    $01 constant OTG_FS_CHH                     \ [0x01] CHH
    $03 constant OTG_FS_STALL                   \ [0x03] STALL
    $04 constant OTG_FS_NAK                     \ [0x04] NAK
    $05 constant OTG_FS_ACK                     \ [0x05] ACK
    $07 constant OTG_FS_TXERR                   \ [0x07] TXERR
    $08 constant OTG_FS_BBERR                   \ [0x08] BBERR
    $09 constant OTG_FS_FRMOR                   \ [0x09] FRMOR
    $0a constant OTG_FS_DTERR                   \ [0x0a] DTERR
  [then]


  [ifdef] OTG_FS_HCINTMSK3_DEF
    \
    \ @brief This register reflects the mask for each channel status described in the previous section.
    \ Address offset: 0x56C
    \ Reset value: 0x00000000
    \
    $00 constant OTG_FS_XFRCM                   \ [0x00] XFRCM
    $01 constant OTG_FS_CHHM                    \ [0x01] CHHM
    $03 constant OTG_FS_STALLM                  \ [0x03] STALLM
    $04 constant OTG_FS_NAKM                    \ [0x04] NAKM
    $05 constant OTG_FS_ACKM                    \ [0x05] ACKM
    $07 constant OTG_FS_TXERRM                  \ [0x07] TXERRM
    $08 constant OTG_FS_BBERRM                  \ [0x08] BBERRM
    $09 constant OTG_FS_FRMORM                  \ [0x09] FRMORM
    $0a constant OTG_FS_DTERRM                  \ [0x0a] DTERRM
  [then]


  [ifdef] OTG_FS_HCTSIZ3_DEF
    \
    \ @brief OTG host channel 3 transfer size register
    \ Address offset: 0x570
    \ Reset value: 0x00000000
    \
    $00 constant OTG_FS_XFRSIZ                  \ [0x00 : 19] XFRSIZ
    $13 constant OTG_FS_PKTCNT                  \ [0x13 : 10] PKTCNT
    $1d constant OTG_FS_DPID                    \ [0x1d : 2] DPID
    $1f constant OTG_FS_DOPNG                   \ [0x1f] DOPNG
  [then]


  [ifdef] OTG_FS_HCCHAR4_DEF
    \
    \ @brief OTG host channel 4 characteristics register
    \ Address offset: 0x580
    \ Reset value: 0x00000000
    \
    $00 constant OTG_FS_MPSIZ                   \ [0x00 : 11] MPSIZ
    $0b constant OTG_FS_EPNUM                   \ [0x0b : 4] EPNUM
    $0f constant OTG_FS_EPDIR                   \ [0x0f] EPDIR
    $11 constant OTG_FS_LSDEV                   \ [0x11] LSDEV
    $12 constant OTG_FS_EPTYP                   \ [0x12 : 2] EPTYP
    $14 constant OTG_FS_MCNT                    \ [0x14 : 2] MCNT
    $16 constant OTG_FS_DAD                     \ [0x16 : 7] DAD
    $1d constant OTG_FS_ODDFRM                  \ [0x1d] ODDFRM
    $1e constant OTG_FS_CHDIS                   \ [0x1e] CHDIS
    $1f constant OTG_FS_CHENA                   \ [0x1f] CHENA
  [then]


  [ifdef] OTG_FS_HCINT4_DEF
    \
    \ @brief This register indicates the status of a channel with respect to USB- and AHB-related events. It is shown in Figure724. The application must read this register when the host channels interrupt bit in the core interrupt register (HCINT bit in GINTSTS) is set. Before the application can read this register, it must first read the host all channels interrupt (HAINT) register to get the exact channel number for the host channel-x interrupt register. The application must clear the appropriate bit in this register to clear the corresponding bits in the HAINT and GINTSTS registers.
    \ Address offset: 0x588
    \ Reset value: 0x00000000
    \
    $00 constant OTG_FS_XFRC                    \ [0x00] XFRC
    $01 constant OTG_FS_CHH                     \ [0x01] CHH
    $03 constant OTG_FS_STALL                   \ [0x03] STALL
    $04 constant OTG_FS_NAK                     \ [0x04] NAK
    $05 constant OTG_FS_ACK                     \ [0x05] ACK
    $07 constant OTG_FS_TXERR                   \ [0x07] TXERR
    $08 constant OTG_FS_BBERR                   \ [0x08] BBERR
    $09 constant OTG_FS_FRMOR                   \ [0x09] FRMOR
    $0a constant OTG_FS_DTERR                   \ [0x0a] DTERR
  [then]


  [ifdef] OTG_FS_HCINTMSK4_DEF
    \
    \ @brief This register reflects the mask for each channel status described in the previous section.
    \ Address offset: 0x58C
    \ Reset value: 0x00000000
    \
    $00 constant OTG_FS_XFRCM                   \ [0x00] XFRCM
    $01 constant OTG_FS_CHHM                    \ [0x01] CHHM
    $03 constant OTG_FS_STALLM                  \ [0x03] STALLM
    $04 constant OTG_FS_NAKM                    \ [0x04] NAKM
    $05 constant OTG_FS_ACKM                    \ [0x05] ACKM
    $07 constant OTG_FS_TXERRM                  \ [0x07] TXERRM
    $08 constant OTG_FS_BBERRM                  \ [0x08] BBERRM
    $09 constant OTG_FS_FRMORM                  \ [0x09] FRMORM
    $0a constant OTG_FS_DTERRM                  \ [0x0a] DTERRM
  [then]


  [ifdef] OTG_FS_HCTSIZ4_DEF
    \
    \ @brief OTG host channel 4 transfer size register
    \ Address offset: 0x590
    \ Reset value: 0x00000000
    \
    $00 constant OTG_FS_XFRSIZ                  \ [0x00 : 19] XFRSIZ
    $13 constant OTG_FS_PKTCNT                  \ [0x13 : 10] PKTCNT
    $1d constant OTG_FS_DPID                    \ [0x1d : 2] DPID
    $1f constant OTG_FS_DOPNG                   \ [0x1f] DOPNG
  [then]


  [ifdef] OTG_FS_HCCHAR5_DEF
    \
    \ @brief OTG host channel 5 characteristics register
    \ Address offset: 0x5A0
    \ Reset value: 0x00000000
    \
    $00 constant OTG_FS_MPSIZ                   \ [0x00 : 11] MPSIZ
    $0b constant OTG_FS_EPNUM                   \ [0x0b : 4] EPNUM
    $0f constant OTG_FS_EPDIR                   \ [0x0f] EPDIR
    $11 constant OTG_FS_LSDEV                   \ [0x11] LSDEV
    $12 constant OTG_FS_EPTYP                   \ [0x12 : 2] EPTYP
    $14 constant OTG_FS_MCNT                    \ [0x14 : 2] MCNT
    $16 constant OTG_FS_DAD                     \ [0x16 : 7] DAD
    $1d constant OTG_FS_ODDFRM                  \ [0x1d] ODDFRM
    $1e constant OTG_FS_CHDIS                   \ [0x1e] CHDIS
    $1f constant OTG_FS_CHENA                   \ [0x1f] CHENA
  [then]


  [ifdef] OTG_FS_HCINT5_DEF
    \
    \ @brief This register indicates the status of a channel with respect to USB- and AHB-related events. It is shown in Figure724. The application must read this register when the host channels interrupt bit in the core interrupt register (HCINT bit in GINTSTS) is set. Before the application can read this register, it must first read the host all channels interrupt (HAINT) register to get the exact channel number for the host channel-x interrupt register. The application must clear the appropriate bit in this register to clear the corresponding bits in the HAINT and GINTSTS registers.
    \ Address offset: 0x5A8
    \ Reset value: 0x00000000
    \
    $00 constant OTG_FS_XFRC                    \ [0x00] XFRC
    $01 constant OTG_FS_CHH                     \ [0x01] CHH
    $03 constant OTG_FS_STALL                   \ [0x03] STALL
    $04 constant OTG_FS_NAK                     \ [0x04] NAK
    $05 constant OTG_FS_ACK                     \ [0x05] ACK
    $07 constant OTG_FS_TXERR                   \ [0x07] TXERR
    $08 constant OTG_FS_BBERR                   \ [0x08] BBERR
    $09 constant OTG_FS_FRMOR                   \ [0x09] FRMOR
    $0a constant OTG_FS_DTERR                   \ [0x0a] DTERR
  [then]


  [ifdef] OTG_FS_HCINTMSK5_DEF
    \
    \ @brief This register reflects the mask for each channel status described in the previous section.
    \ Address offset: 0x5AC
    \ Reset value: 0x00000000
    \
    $00 constant OTG_FS_XFRCM                   \ [0x00] XFRCM
    $01 constant OTG_FS_CHHM                    \ [0x01] CHHM
    $03 constant OTG_FS_STALLM                  \ [0x03] STALLM
    $04 constant OTG_FS_NAKM                    \ [0x04] NAKM
    $05 constant OTG_FS_ACKM                    \ [0x05] ACKM
    $07 constant OTG_FS_TXERRM                  \ [0x07] TXERRM
    $08 constant OTG_FS_BBERRM                  \ [0x08] BBERRM
    $09 constant OTG_FS_FRMORM                  \ [0x09] FRMORM
    $0a constant OTG_FS_DTERRM                  \ [0x0a] DTERRM
  [then]


  [ifdef] OTG_FS_HCTSIZ5_DEF
    \
    \ @brief OTG host channel 5 transfer size register
    \ Address offset: 0x5B0
    \ Reset value: 0x00000000
    \
    $00 constant OTG_FS_XFRSIZ                  \ [0x00 : 19] XFRSIZ
    $13 constant OTG_FS_PKTCNT                  \ [0x13 : 10] PKTCNT
    $1d constant OTG_FS_DPID                    \ [0x1d : 2] DPID
    $1f constant OTG_FS_DOPNG                   \ [0x1f] DOPNG
  [then]


  [ifdef] OTG_FS_HCCHAR6_DEF
    \
    \ @brief OTG host channel 6 characteristics register
    \ Address offset: 0x5C0
    \ Reset value: 0x00000000
    \
    $00 constant OTG_FS_MPSIZ                   \ [0x00 : 11] MPSIZ
    $0b constant OTG_FS_EPNUM                   \ [0x0b : 4] EPNUM
    $0f constant OTG_FS_EPDIR                   \ [0x0f] EPDIR
    $11 constant OTG_FS_LSDEV                   \ [0x11] LSDEV
    $12 constant OTG_FS_EPTYP                   \ [0x12 : 2] EPTYP
    $14 constant OTG_FS_MCNT                    \ [0x14 : 2] MCNT
    $16 constant OTG_FS_DAD                     \ [0x16 : 7] DAD
    $1d constant OTG_FS_ODDFRM                  \ [0x1d] ODDFRM
    $1e constant OTG_FS_CHDIS                   \ [0x1e] CHDIS
    $1f constant OTG_FS_CHENA                   \ [0x1f] CHENA
  [then]


  [ifdef] OTG_FS_HCINT6_DEF
    \
    \ @brief This register indicates the status of a channel with respect to USB- and AHB-related events. It is shown in Figure724. The application must read this register when the host channels interrupt bit in the core interrupt register (HCINT bit in GINTSTS) is set. Before the application can read this register, it must first read the host all channels interrupt (HAINT) register to get the exact channel number for the host channel-x interrupt register. The application must clear the appropriate bit in this register to clear the corresponding bits in the HAINT and GINTSTS registers.
    \ Address offset: 0x5C8
    \ Reset value: 0x00000000
    \
    $00 constant OTG_FS_XFRC                    \ [0x00] XFRC
    $01 constant OTG_FS_CHH                     \ [0x01] CHH
    $03 constant OTG_FS_STALL                   \ [0x03] STALL
    $04 constant OTG_FS_NAK                     \ [0x04] NAK
    $05 constant OTG_FS_ACK                     \ [0x05] ACK
    $07 constant OTG_FS_TXERR                   \ [0x07] TXERR
    $08 constant OTG_FS_BBERR                   \ [0x08] BBERR
    $09 constant OTG_FS_FRMOR                   \ [0x09] FRMOR
    $0a constant OTG_FS_DTERR                   \ [0x0a] DTERR
  [then]


  [ifdef] OTG_FS_HCINTMSK6_DEF
    \
    \ @brief This register reflects the mask for each channel status described in the previous section.
    \ Address offset: 0x5CC
    \ Reset value: 0x00000000
    \
    $00 constant OTG_FS_XFRCM                   \ [0x00] XFRCM
    $01 constant OTG_FS_CHHM                    \ [0x01] CHHM
    $03 constant OTG_FS_STALLM                  \ [0x03] STALLM
    $04 constant OTG_FS_NAKM                    \ [0x04] NAKM
    $05 constant OTG_FS_ACKM                    \ [0x05] ACKM
    $07 constant OTG_FS_TXERRM                  \ [0x07] TXERRM
    $08 constant OTG_FS_BBERRM                  \ [0x08] BBERRM
    $09 constant OTG_FS_FRMORM                  \ [0x09] FRMORM
    $0a constant OTG_FS_DTERRM                  \ [0x0a] DTERRM
  [then]


  [ifdef] OTG_FS_HCTSIZ6_DEF
    \
    \ @brief OTG host channel 6 transfer size register
    \ Address offset: 0x5D0
    \ Reset value: 0x00000000
    \
    $00 constant OTG_FS_XFRSIZ                  \ [0x00 : 19] XFRSIZ
    $13 constant OTG_FS_PKTCNT                  \ [0x13 : 10] PKTCNT
    $1d constant OTG_FS_DPID                    \ [0x1d : 2] DPID
    $1f constant OTG_FS_DOPNG                   \ [0x1f] DOPNG
  [then]


  [ifdef] OTG_FS_HCCHAR7_DEF
    \
    \ @brief OTG host channel 7 characteristics register
    \ Address offset: 0x5E0
    \ Reset value: 0x00000000
    \
    $00 constant OTG_FS_MPSIZ                   \ [0x00 : 11] MPSIZ
    $0b constant OTG_FS_EPNUM                   \ [0x0b : 4] EPNUM
    $0f constant OTG_FS_EPDIR                   \ [0x0f] EPDIR
    $11 constant OTG_FS_LSDEV                   \ [0x11] LSDEV
    $12 constant OTG_FS_EPTYP                   \ [0x12 : 2] EPTYP
    $14 constant OTG_FS_MCNT                    \ [0x14 : 2] MCNT
    $16 constant OTG_FS_DAD                     \ [0x16 : 7] DAD
    $1d constant OTG_FS_ODDFRM                  \ [0x1d] ODDFRM
    $1e constant OTG_FS_CHDIS                   \ [0x1e] CHDIS
    $1f constant OTG_FS_CHENA                   \ [0x1f] CHENA
  [then]


  [ifdef] OTG_FS_HCINT7_DEF
    \
    \ @brief This register indicates the status of a channel with respect to USB- and AHB-related events. It is shown in Figure724. The application must read this register when the host channels interrupt bit in the core interrupt register (HCINT bit in GINTSTS) is set. Before the application can read this register, it must first read the host all channels interrupt (HAINT) register to get the exact channel number for the host channel-x interrupt register. The application must clear the appropriate bit in this register to clear the corresponding bits in the HAINT and GINTSTS registers.
    \ Address offset: 0x5E8
    \ Reset value: 0x00000000
    \
    $00 constant OTG_FS_XFRC                    \ [0x00] XFRC
    $01 constant OTG_FS_CHH                     \ [0x01] CHH
    $03 constant OTG_FS_STALL                   \ [0x03] STALL
    $04 constant OTG_FS_NAK                     \ [0x04] NAK
    $05 constant OTG_FS_ACK                     \ [0x05] ACK
    $07 constant OTG_FS_TXERR                   \ [0x07] TXERR
    $08 constant OTG_FS_BBERR                   \ [0x08] BBERR
    $09 constant OTG_FS_FRMOR                   \ [0x09] FRMOR
    $0a constant OTG_FS_DTERR                   \ [0x0a] DTERR
  [then]


  [ifdef] OTG_FS_HCINTMSK7_DEF
    \
    \ @brief This register reflects the mask for each channel status described in the previous section.
    \ Address offset: 0x5EC
    \ Reset value: 0x00000000
    \
    $00 constant OTG_FS_XFRCM                   \ [0x00] XFRCM
    $01 constant OTG_FS_CHHM                    \ [0x01] CHHM
    $03 constant OTG_FS_STALLM                  \ [0x03] STALLM
    $04 constant OTG_FS_NAKM                    \ [0x04] NAKM
    $05 constant OTG_FS_ACKM                    \ [0x05] ACKM
    $07 constant OTG_FS_TXERRM                  \ [0x07] TXERRM
    $08 constant OTG_FS_BBERRM                  \ [0x08] BBERRM
    $09 constant OTG_FS_FRMORM                  \ [0x09] FRMORM
    $0a constant OTG_FS_DTERRM                  \ [0x0a] DTERRM
  [then]


  [ifdef] OTG_FS_HCTSIZ7_DEF
    \
    \ @brief OTG host channel 7 transfer size register
    \ Address offset: 0x5F0
    \ Reset value: 0x00000000
    \
    $00 constant OTG_FS_XFRSIZ                  \ [0x00 : 19] XFRSIZ
    $13 constant OTG_FS_PKTCNT                  \ [0x13 : 10] PKTCNT
    $1d constant OTG_FS_DPID                    \ [0x1d : 2] DPID
    $1f constant OTG_FS_DOPNG                   \ [0x1f] DOPNG
  [then]


  [ifdef] OTG_FS_HCCHAR8_DEF
    \
    \ @brief OTG host channel 8 characteristics register
    \ Address offset: 0x600
    \ Reset value: 0x00000000
    \
    $00 constant OTG_FS_MPSIZ                   \ [0x00 : 11] MPSIZ
    $0b constant OTG_FS_EPNUM                   \ [0x0b : 4] EPNUM
    $0f constant OTG_FS_EPDIR                   \ [0x0f] EPDIR
    $11 constant OTG_FS_LSDEV                   \ [0x11] LSDEV
    $12 constant OTG_FS_EPTYP                   \ [0x12 : 2] EPTYP
    $14 constant OTG_FS_MCNT                    \ [0x14 : 2] MCNT
    $16 constant OTG_FS_DAD                     \ [0x16 : 7] DAD
    $1d constant OTG_FS_ODDFRM                  \ [0x1d] ODDFRM
    $1e constant OTG_FS_CHDIS                   \ [0x1e] CHDIS
    $1f constant OTG_FS_CHENA                   \ [0x1f] CHENA
  [then]


  [ifdef] OTG_FS_HCINT8_DEF
    \
    \ @brief This register indicates the status of a channel with respect to USB- and AHB-related events. It is shown in Figure724. The application must read this register when the host channels interrupt bit in the core interrupt register (HCINT bit in GINTSTS) is set. Before the application can read this register, it must first read the host all channels interrupt (HAINT) register to get the exact channel number for the host channel-x interrupt register. The application must clear the appropriate bit in this register to clear the corresponding bits in the HAINT and GINTSTS registers.
    \ Address offset: 0x608
    \ Reset value: 0x00000000
    \
    $00 constant OTG_FS_XFRC                    \ [0x00] XFRC
    $01 constant OTG_FS_CHH                     \ [0x01] CHH
    $03 constant OTG_FS_STALL                   \ [0x03] STALL
    $04 constant OTG_FS_NAK                     \ [0x04] NAK
    $05 constant OTG_FS_ACK                     \ [0x05] ACK
    $07 constant OTG_FS_TXERR                   \ [0x07] TXERR
    $08 constant OTG_FS_BBERR                   \ [0x08] BBERR
    $09 constant OTG_FS_FRMOR                   \ [0x09] FRMOR
    $0a constant OTG_FS_DTERR                   \ [0x0a] DTERR
  [then]


  [ifdef] OTG_FS_HCINTMSK8_DEF
    \
    \ @brief This register reflects the mask for each channel status described in the previous section.
    \ Address offset: 0x60C
    \ Reset value: 0x00000000
    \
    $00 constant OTG_FS_XFRCM                   \ [0x00] XFRCM
    $01 constant OTG_FS_CHHM                    \ [0x01] CHHM
    $03 constant OTG_FS_STALLM                  \ [0x03] STALLM
    $04 constant OTG_FS_NAKM                    \ [0x04] NAKM
    $05 constant OTG_FS_ACKM                    \ [0x05] ACKM
    $07 constant OTG_FS_TXERRM                  \ [0x07] TXERRM
    $08 constant OTG_FS_BBERRM                  \ [0x08] BBERRM
    $09 constant OTG_FS_FRMORM                  \ [0x09] FRMORM
    $0a constant OTG_FS_DTERRM                  \ [0x0a] DTERRM
  [then]


  [ifdef] OTG_FS_HCTSIZ8_DEF
    \
    \ @brief OTG host channel 8 transfer size register
    \ Address offset: 0x610
    \ Reset value: 0x00000000
    \
    $00 constant OTG_FS_XFRSIZ                  \ [0x00 : 19] XFRSIZ
    $13 constant OTG_FS_PKTCNT                  \ [0x13 : 10] PKTCNT
    $1d constant OTG_FS_DPID                    \ [0x1d : 2] DPID
    $1f constant OTG_FS_DOPNG                   \ [0x1f] DOPNG
  [then]


  [ifdef] OTG_FS_HCCHAR9_DEF
    \
    \ @brief OTG host channel 9 characteristics register
    \ Address offset: 0x620
    \ Reset value: 0x00000000
    \
    $00 constant OTG_FS_MPSIZ                   \ [0x00 : 11] MPSIZ
    $0b constant OTG_FS_EPNUM                   \ [0x0b : 4] EPNUM
    $0f constant OTG_FS_EPDIR                   \ [0x0f] EPDIR
    $11 constant OTG_FS_LSDEV                   \ [0x11] LSDEV
    $12 constant OTG_FS_EPTYP                   \ [0x12 : 2] EPTYP
    $14 constant OTG_FS_MCNT                    \ [0x14 : 2] MCNT
    $16 constant OTG_FS_DAD                     \ [0x16 : 7] DAD
    $1d constant OTG_FS_ODDFRM                  \ [0x1d] ODDFRM
    $1e constant OTG_FS_CHDIS                   \ [0x1e] CHDIS
    $1f constant OTG_FS_CHENA                   \ [0x1f] CHENA
  [then]


  [ifdef] OTG_FS_HCINT9_DEF
    \
    \ @brief This register indicates the status of a channel with respect to USB- and AHB-related events. It is shown in Figure724. The application must read this register when the host channels interrupt bit in the core interrupt register (HCINT bit in GINTSTS) is set. Before the application can read this register, it must first read the host all channels interrupt (HAINT) register to get the exact channel number for the host channel-x interrupt register. The application must clear the appropriate bit in this register to clear the corresponding bits in the HAINT and GINTSTS registers.
    \ Address offset: 0x628
    \ Reset value: 0x00000000
    \
    $00 constant OTG_FS_XFRC                    \ [0x00] XFRC
    $01 constant OTG_FS_CHH                     \ [0x01] CHH
    $03 constant OTG_FS_STALL                   \ [0x03] STALL
    $04 constant OTG_FS_NAK                     \ [0x04] NAK
    $05 constant OTG_FS_ACK                     \ [0x05] ACK
    $07 constant OTG_FS_TXERR                   \ [0x07] TXERR
    $08 constant OTG_FS_BBERR                   \ [0x08] BBERR
    $09 constant OTG_FS_FRMOR                   \ [0x09] FRMOR
    $0a constant OTG_FS_DTERR                   \ [0x0a] DTERR
  [then]


  [ifdef] OTG_FS_HCINTMSK9_DEF
    \
    \ @brief This register reflects the mask for each channel status described in the previous section.
    \ Address offset: 0x62C
    \ Reset value: 0x00000000
    \
    $00 constant OTG_FS_XFRCM                   \ [0x00] XFRCM
    $01 constant OTG_FS_CHHM                    \ [0x01] CHHM
    $03 constant OTG_FS_STALLM                  \ [0x03] STALLM
    $04 constant OTG_FS_NAKM                    \ [0x04] NAKM
    $05 constant OTG_FS_ACKM                    \ [0x05] ACKM
    $07 constant OTG_FS_TXERRM                  \ [0x07] TXERRM
    $08 constant OTG_FS_BBERRM                  \ [0x08] BBERRM
    $09 constant OTG_FS_FRMORM                  \ [0x09] FRMORM
    $0a constant OTG_FS_DTERRM                  \ [0x0a] DTERRM
  [then]


  [ifdef] OTG_FS_HCTSIZ9_DEF
    \
    \ @brief OTG host channel 9 transfer size register
    \ Address offset: 0x630
    \ Reset value: 0x00000000
    \
    $00 constant OTG_FS_XFRSIZ                  \ [0x00 : 19] XFRSIZ
    $13 constant OTG_FS_PKTCNT                  \ [0x13 : 10] PKTCNT
    $1d constant OTG_FS_DPID                    \ [0x1d : 2] DPID
    $1f constant OTG_FS_DOPNG                   \ [0x1f] DOPNG
  [then]


  [ifdef] OTG_FS_HCCHAR10_DEF
    \
    \ @brief OTG host channel 10 characteristics register
    \ Address offset: 0x640
    \ Reset value: 0x00000000
    \
    $00 constant OTG_FS_MPSIZ                   \ [0x00 : 11] MPSIZ
    $0b constant OTG_FS_EPNUM                   \ [0x0b : 4] EPNUM
    $0f constant OTG_FS_EPDIR                   \ [0x0f] EPDIR
    $11 constant OTG_FS_LSDEV                   \ [0x11] LSDEV
    $12 constant OTG_FS_EPTYP                   \ [0x12 : 2] EPTYP
    $14 constant OTG_FS_MCNT                    \ [0x14 : 2] MCNT
    $16 constant OTG_FS_DAD                     \ [0x16 : 7] DAD
    $1d constant OTG_FS_ODDFRM                  \ [0x1d] ODDFRM
    $1e constant OTG_FS_CHDIS                   \ [0x1e] CHDIS
    $1f constant OTG_FS_CHENA                   \ [0x1f] CHENA
  [then]


  [ifdef] OTG_FS_HCINT10_DEF
    \
    \ @brief This register indicates the status of a channel with respect to USB- and AHB-related events. It is shown in Figure724. The application must read this register when the host channels interrupt bit in the core interrupt register (HCINT bit in GINTSTS) is set. Before the application can read this register, it must first read the host all channels interrupt (HAINT) register to get the exact channel number for the host channel-x interrupt register. The application must clear the appropriate bit in this register to clear the corresponding bits in the HAINT and GINTSTS registers.
    \ Address offset: 0x648
    \ Reset value: 0x00000000
    \
    $00 constant OTG_FS_XFRC                    \ [0x00] XFRC
    $01 constant OTG_FS_CHH                     \ [0x01] CHH
    $03 constant OTG_FS_STALL                   \ [0x03] STALL
    $04 constant OTG_FS_NAK                     \ [0x04] NAK
    $05 constant OTG_FS_ACK                     \ [0x05] ACK
    $07 constant OTG_FS_TXERR                   \ [0x07] TXERR
    $08 constant OTG_FS_BBERR                   \ [0x08] BBERR
    $09 constant OTG_FS_FRMOR                   \ [0x09] FRMOR
    $0a constant OTG_FS_DTERR                   \ [0x0a] DTERR
  [then]


  [ifdef] OTG_FS_HCINTMSK10_DEF
    \
    \ @brief This register reflects the mask for each channel status described in the previous section.
    \ Address offset: 0x64C
    \ Reset value: 0x00000000
    \
    $00 constant OTG_FS_XFRCM                   \ [0x00] XFRCM
    $01 constant OTG_FS_CHHM                    \ [0x01] CHHM
    $03 constant OTG_FS_STALLM                  \ [0x03] STALLM
    $04 constant OTG_FS_NAKM                    \ [0x04] NAKM
    $05 constant OTG_FS_ACKM                    \ [0x05] ACKM
    $07 constant OTG_FS_TXERRM                  \ [0x07] TXERRM
    $08 constant OTG_FS_BBERRM                  \ [0x08] BBERRM
    $09 constant OTG_FS_FRMORM                  \ [0x09] FRMORM
    $0a constant OTG_FS_DTERRM                  \ [0x0a] DTERRM
  [then]


  [ifdef] OTG_FS_HCTSIZ10_DEF
    \
    \ @brief OTG host channel 10 transfer size register
    \ Address offset: 0x650
    \ Reset value: 0x00000000
    \
    $00 constant OTG_FS_XFRSIZ                  \ [0x00 : 19] XFRSIZ
    $13 constant OTG_FS_PKTCNT                  \ [0x13 : 10] PKTCNT
    $1d constant OTG_FS_DPID                    \ [0x1d : 2] DPID
    $1f constant OTG_FS_DOPNG                   \ [0x1f] DOPNG
  [then]


  [ifdef] OTG_FS_HCCHAR11_DEF
    \
    \ @brief OTG host channel 11 characteristics register
    \ Address offset: 0x660
    \ Reset value: 0x00000000
    \
    $00 constant OTG_FS_MPSIZ                   \ [0x00 : 11] MPSIZ
    $0b constant OTG_FS_EPNUM                   \ [0x0b : 4] EPNUM
    $0f constant OTG_FS_EPDIR                   \ [0x0f] EPDIR
    $11 constant OTG_FS_LSDEV                   \ [0x11] LSDEV
    $12 constant OTG_FS_EPTYP                   \ [0x12 : 2] EPTYP
    $14 constant OTG_FS_MCNT                    \ [0x14 : 2] MCNT
    $16 constant OTG_FS_DAD                     \ [0x16 : 7] DAD
    $1d constant OTG_FS_ODDFRM                  \ [0x1d] ODDFRM
    $1e constant OTG_FS_CHDIS                   \ [0x1e] CHDIS
    $1f constant OTG_FS_CHENA                   \ [0x1f] CHENA
  [then]


  [ifdef] OTG_FS_HCINT11_DEF
    \
    \ @brief This register indicates the status of a channel with respect to USB- and AHB-related events. It is shown in Figure724. The application must read this register when the host channels interrupt bit in the core interrupt register (HCINT bit in GINTSTS) is set. Before the application can read this register, it must first read the host all channels interrupt (HAINT) register to get the exact channel number for the host channel-x interrupt register. The application must clear the appropriate bit in this register to clear the corresponding bits in the HAINT and GINTSTS registers.
    \ Address offset: 0x668
    \ Reset value: 0x00000000
    \
    $00 constant OTG_FS_XFRC                    \ [0x00] XFRC
    $01 constant OTG_FS_CHH                     \ [0x01] CHH
    $03 constant OTG_FS_STALL                   \ [0x03] STALL
    $04 constant OTG_FS_NAK                     \ [0x04] NAK
    $05 constant OTG_FS_ACK                     \ [0x05] ACK
    $07 constant OTG_FS_TXERR                   \ [0x07] TXERR
    $08 constant OTG_FS_BBERR                   \ [0x08] BBERR
    $09 constant OTG_FS_FRMOR                   \ [0x09] FRMOR
    $0a constant OTG_FS_DTERR                   \ [0x0a] DTERR
  [then]


  [ifdef] OTG_FS_HCINTMSK11_DEF
    \
    \ @brief This register reflects the mask for each channel status described in the previous section.
    \ Address offset: 0x66C
    \ Reset value: 0x00000000
    \
    $00 constant OTG_FS_XFRCM                   \ [0x00] XFRCM
    $01 constant OTG_FS_CHHM                    \ [0x01] CHHM
    $03 constant OTG_FS_STALLM                  \ [0x03] STALLM
    $04 constant OTG_FS_NAKM                    \ [0x04] NAKM
    $05 constant OTG_FS_ACKM                    \ [0x05] ACKM
    $07 constant OTG_FS_TXERRM                  \ [0x07] TXERRM
    $08 constant OTG_FS_BBERRM                  \ [0x08] BBERRM
    $09 constant OTG_FS_FRMORM                  \ [0x09] FRMORM
    $0a constant OTG_FS_DTERRM                  \ [0x0a] DTERRM
  [then]


  [ifdef] OTG_FS_HCTSIZ11_DEF
    \
    \ @brief OTG host channel 11 transfer size register
    \ Address offset: 0x670
    \ Reset value: 0x00000000
    \
    $00 constant OTG_FS_XFRSIZ                  \ [0x00 : 19] XFRSIZ
    $13 constant OTG_FS_PKTCNT                  \ [0x13 : 10] PKTCNT
    $1d constant OTG_FS_DPID                    \ [0x1d : 2] DPID
    $1f constant OTG_FS_DOPNG                   \ [0x1f] DOPNG
  [then]


  [ifdef] OTG_FS_DCFG_DEF
    \
    \ @brief This register configures the core in device mode after power-on or after certain control commands or enumeration. Do not make changes to this register after initial programming.
    \ Address offset: 0x800
    \ Reset value: 0x02200000
    \
    $00 constant OTG_FS_DSPD                    \ [0x00 : 2] DSPD
    $02 constant OTG_FS_NZLSOHSK                \ [0x02] NZLSOHSK
    $04 constant OTG_FS_DAD                     \ [0x04 : 7] DAD
    $0b constant OTG_FS_PFIVL                   \ [0x0b : 2] PFIVL
    $0f constant OTG_FS_ERRATIM                 \ [0x0f] ERRATIM
  [then]


  [ifdef] OTG_FS_DCTL_DEF
    \
    \ @brief OTG device control register
    \ Address offset: 0x804
    \ Reset value: 0x00000002
    \
    $00 constant OTG_FS_RWUSIG                  \ [0x00] RWUSIG
    $01 constant OTG_FS_SDIS                    \ [0x01] SDIS
    $02 constant OTG_FS_GINSTS                  \ [0x02] GINSTS
    $03 constant OTG_FS_GONSTS                  \ [0x03] GONSTS
    $04 constant OTG_FS_TCTL                    \ [0x04 : 3] TCTL
    $07 constant OTG_FS_SGINAK                  \ [0x07] SGINAK
    $08 constant OTG_FS_CGINAK                  \ [0x08] CGINAK
    $09 constant OTG_FS_SGONAK                  \ [0x09] SGONAK
    $0a constant OTG_FS_CGONAK                  \ [0x0a] CGONAK
    $0b constant OTG_FS_POPRGDNE                \ [0x0b] POPRGDNE
    $12 constant OTG_FS_DSBESLRJCT              \ [0x12] DSBESLRJCT
  [then]


  [ifdef] OTG_FS_DSTS_DEF
    \
    \ @brief This register indicates the status of the core with respect to USB-related events. It must be read on interrupts from the device all interrupts (DAINT) register.
    \ Address offset: 0x808
    \ Reset value: 0x00000010
    \
    $00 constant OTG_FS_SUSPSTS                 \ [0x00] SUSPSTS
    $01 constant OTG_FS_ENUMSPD                 \ [0x01 : 2] ENUMSPD
    $03 constant OTG_FS_EERR                    \ [0x03] EERR
    $08 constant OTG_FS_FNSOF                   \ [0x08 : 14] FNSOF
    $16 constant OTG_FS_DEVLNSTS                \ [0x16 : 2] DEVLNSTS
  [then]


  [ifdef] OTG_FS_DIEPMSK_DEF
    \
    \ @brief This register works with each of the DIEPINTx registers for all endpoints to generate an interrupt per IN endpoint. The IN endpoint interrupt for a specific status in the DIEPINTx register can be masked by writing to the corresponding bit in this register. Status bits are masked by default.
    \ Address offset: 0x810
    \ Reset value: 0x00000000
    \
    $00 constant OTG_FS_XFRCM                   \ [0x00] XFRCM
    $01 constant OTG_FS_EPDM                    \ [0x01] EPDM
    $03 constant OTG_FS_TOM                     \ [0x03] TOM
    $04 constant OTG_FS_ITTXFEMSK               \ [0x04] ITTXFEMSK
    $05 constant OTG_FS_INEPNMM                 \ [0x05] INEPNMM
    $06 constant OTG_FS_INEPNEM                 \ [0x06] INEPNEM
    $0d constant OTG_FS_NAKM                    \ [0x0d] NAKM
  [then]


  [ifdef] OTG_FS_DOEPMSK_DEF
    \
    \ @brief This register works with each of the DOEPINTx registers for all endpoints to generate an interrupt per OUT endpoint. The OUT endpoint interrupt for a specific status in the DOEPINTx register can be masked by writing into the corresponding bit in this register. Status bits are masked by default.
    \ Address offset: 0x814
    \ Reset value: 0x00000000
    \
    $00 constant OTG_FS_XFRCM                   \ [0x00] XFRCM
    $01 constant OTG_FS_EPDM                    \ [0x01] EPDM
    $03 constant OTG_FS_STUPM                   \ [0x03] STUPM
    $04 constant OTG_FS_OTEPDM                  \ [0x04] OTEPDM
    $05 constant OTG_FS_STSPHSRXM               \ [0x05] STSPHSRXM
    $08 constant OTG_FS_OUTPKTERRM              \ [0x08] OUTPKTERRM
    $0c constant OTG_FS_BERRM                   \ [0x0c] BERRM
    $0d constant OTG_FS_NAKMSK                  \ [0x0d] NAKMSK
  [then]


  [ifdef] OTG_FS_DAINT_DEF
    \
    \ @brief When a significant event occurs on an endpoint, a DAINT register interrupts the application using the device OUT endpoints interrupt bit or device IN endpoints interrupt bit of the GINTSTS register (OEPINT or IEPINT in GINTSTS, respectively). There is one interrupt bit per endpoint, up to a maximum of 16 bits for OUT endpoints and 16 bits for IN endpoints. For a bidirectional endpoint, the corresponding IN and OUT interrupt bits are used. Bits in this register are set and cleared when the application sets and clears bits in the corresponding device endpoint-x interrupt register (DIEPINTx/DOEPINTx).
    \ Address offset: 0x818
    \ Reset value: 0x00000000
    \
    $00 constant OTG_FS_IEPINT                  \ [0x00 : 16] IEPINT
    $10 constant OTG_FS_OEPINT                  \ [0x10 : 16] OEPINT
  [then]


  [ifdef] OTG_FS_DAINTMSK_DEF
    \
    \ @brief The DAINTMSK register works with the device endpoint interrupt register to interrupt the application when an event occurs on a device endpoint. However, the DAINT register bit corresponding to that interrupt is still set.
    \ Address offset: 0x81C
    \ Reset value: 0x00000000
    \
    $00 constant OTG_FS_IEPM                    \ [0x00 : 16] IEPM
    $10 constant OTG_FS_OEPM                    \ [0x10 : 16] OEPM
  [then]


  [ifdef] OTG_FS_DVBUSDIS_DEF
    \
    \ @brief This register specifies the VBUS discharge time after VBUS pulsing during SRP.
    \ Address offset: 0x828
    \ Reset value: 0x000017D7
    \
    $00 constant OTG_FS_VBUSDT                  \ [0x00 : 16] VBUSDT
  [then]


  [ifdef] OTG_FS_DVBUSPULSE_DEF
    \
    \ @brief This register specifies the VBUS pulsing time during SRP.
    \ Address offset: 0x82C
    \ Reset value: 0x000005B8
    \
    $00 constant OTG_FS_DVBUSP                  \ [0x00 : 16] DVBUSP
  [then]


  [ifdef] OTG_FS_DIEPEMPMSK_DEF
    \
    \ @brief This register is used to control the IN endpoint FIFO empty interrupt generation (TXFE_DIEPINTx).
    \ Address offset: 0x834
    \ Reset value: 0x00000000
    \
    $00 constant OTG_FS_INEPTXFEM               \ [0x00 : 16] INEPTXFEM
  [then]


  [ifdef] OTG_FS_DIEPCTL0_DEF
    \
    \ @brief The application uses this register to control the behavior of each logical endpoint other than endpoint 0.
    \ Address offset: 0x900
    \ Reset value: 0x00000000
    \
    $00 constant OTG_FS_MPSIZ                   \ [0x00 : 2] MPSIZ
    $0f constant OTG_FS_USBAEP                  \ [0x0f] USBAEP
    $11 constant OTG_FS_NAKSTS                  \ [0x11] NAKSTS
    $12 constant OTG_FS_EPTYP                   \ [0x12 : 2] EPTYP
    $15 constant OTG_FS_STALL                   \ [0x15] STALL
    $16 constant OTG_FS_TXFNUM                  \ [0x16 : 4] TXFNUM
    $1a constant OTG_FS_CNAK                    \ [0x1a] CNAK
    $1b constant OTG_FS_SNAK                    \ [0x1b] SNAK
    $1e constant OTG_FS_EPDIS                   \ [0x1e] EPDIS
    $1f constant OTG_FS_EPENA                   \ [0x1f] EPENA
  [then]


  [ifdef] OTG_FS_DIEPINT0_DEF
    \
    \ @brief This register indicates the status of an endpoint with respect to USB- and AHB-related events. It is shown in Figure724. The application must read this register when the IN endpoints interrupt bit of the core interrupt register (IEPINT in GINTSTS) is set. Before the application can read this register, it must first read the device all endpoints interrupt (DAINT) register to get the exact endpoint number for the device endpoint-x interrupt register. The application must clear the appropriate bit in this register to clear the corresponding bits in the DAINT and GINTSTS registers.
    \ Address offset: 0x908
    \ Reset value: 0x00000080
    \
    $00 constant OTG_FS_XFRC                    \ [0x00] XFRC
    $01 constant OTG_FS_EPDISD                  \ [0x01] EPDISD
    $03 constant OTG_FS_TOC                     \ [0x03] TOC
    $04 constant OTG_FS_ITTXFE                  \ [0x04] ITTXFE
    $05 constant OTG_FS_INEPNM                  \ [0x05] INEPNM
    $06 constant OTG_FS_INEPNE                  \ [0x06] INEPNE
    $07 constant OTG_FS_TXFE                    \ [0x07] TXFE
    $0b constant OTG_FS_PKTDRPSTS               \ [0x0b] PKTDRPSTS
    $0d constant OTG_FS_NAK                     \ [0x0d] NAK
  [then]


  [ifdef] OTG_FS_DIEPTSIZ0_DEF
    \
    \ @brief The application must modify this register before enabling endpoint 0.
    \ Address offset: 0x910
    \ Reset value: 0x00000000
    \
    $00 constant OTG_FS_XFRSIZ                  \ [0x00 : 7] XFRSIZ
    $13 constant OTG_FS_PKTCNT                  \ [0x13 : 2] PKTCNT
  [then]


  [ifdef] OTG_FS_DTXFSTS0_DEF
    \
    \ @brief This read-only register contains the free space information for the device IN endpoint Tx FIFO.
    \ Address offset: 0x918
    \ Reset value: 0x00000200
    \
    $00 constant OTG_FS_INEPTFSAV               \ [0x00 : 16] INEPTFSAV
  [then]


  [ifdef] OTG_FS_DIEPCTL1_DEF
    \
    \ @brief The application uses this register to control the behavior of each logical endpoint other than endpoint 0.
    \ Address offset: 0x920
    \ Reset value: 0x00000000
    \
    $00 constant OTG_FS_MPSIZ                   \ [0x00 : 11] MPSIZ
    $0f constant OTG_FS_USBAEP                  \ [0x0f] USBAEP
    $10 constant OTG_FS_EONUM_DPIP              \ [0x10] EONUM_DPIP
    $11 constant OTG_FS_NAKSTS                  \ [0x11] NAKSTS
    $12 constant OTG_FS_EPTYP                   \ [0x12 : 2] EPTYP
    $15 constant OTG_FS_STALL                   \ [0x15] STALL
    $16 constant OTG_FS_TXFNUM                  \ [0x16 : 4] TXFNUM
    $1a constant OTG_FS_CNAK                    \ [0x1a] CNAK
    $1b constant OTG_FS_SNAK                    \ [0x1b] SNAK
    $1c constant OTG_FS_SD0PID_SEVNFRM          \ [0x1c] SD0PID_SEVNFRM
    $1d constant OTG_FS_SODDFRM                 \ [0x1d] SODDFRM
    $1e constant OTG_FS_EPDIS                   \ [0x1e] EPDIS
    $1f constant OTG_FS_EPENA                   \ [0x1f] EPENA
  [then]


  [ifdef] OTG_FS_DIEPINT1_DEF
    \
    \ @brief This register indicates the status of an endpoint with respect to USB- and AHB-related events. It is shown in Figure724. The application must read this register when the IN endpoints interrupt bit of the core interrupt register (IEPINT in GINTSTS) is set. Before the application can read this register, it must first read the device all endpoints interrupt (DAINT) register to get the exact endpoint number for the device endpoint-x interrupt register. The application must clear the appropriate bit in this register to clear the corresponding bits in the DAINT and GINTSTS registers.
    \ Address offset: 0x928
    \ Reset value: 0x00000080
    \
    $00 constant OTG_FS_XFRC                    \ [0x00] XFRC
    $01 constant OTG_FS_EPDISD                  \ [0x01] EPDISD
    $03 constant OTG_FS_TOC                     \ [0x03] TOC
    $04 constant OTG_FS_ITTXFE                  \ [0x04] ITTXFE
    $05 constant OTG_FS_INEPNM                  \ [0x05] INEPNM
    $06 constant OTG_FS_INEPNE                  \ [0x06] INEPNE
    $07 constant OTG_FS_TXFE                    \ [0x07] TXFE
    $0b constant OTG_FS_PKTDRPSTS               \ [0x0b] PKTDRPSTS
    $0d constant OTG_FS_NAK                     \ [0x0d] NAK
  [then]


  [ifdef] OTG_FS_DIEPTSIZ1_DEF
    \
    \ @brief The application must modify this register before enabling the endpoint. Once the endpoint is enabled using the endpoint enable bit in the DIEPCTLx registers (EPENA bit in DIEPCTLx), the core modifies this register. The application can only read this register once the core has cleared the endpoint enable bit.
    \ Address offset: 0x930
    \ Reset value: 0x00000000
    \
    $00 constant OTG_FS_XFRSIZ                  \ [0x00 : 19] XFRSIZ
    $13 constant OTG_FS_PKTCNT                  \ [0x13 : 10] PKTCNT
    $1d constant OTG_FS_MCNT                    \ [0x1d : 2] MCNT
  [then]


  [ifdef] OTG_FS_DTXFSTS1_DEF
    \
    \ @brief This read-only register contains the free space information for the device IN endpoint Tx FIFO.
    \ Address offset: 0x938
    \ Reset value: 0x00000200
    \
    $00 constant OTG_FS_INEPTFSAV               \ [0x00 : 16] INEPTFSAV
  [then]


  [ifdef] OTG_FS_DIEPCTL2_DEF
    \
    \ @brief The application uses this register to control the behavior of each logical endpoint other than endpoint 0.
    \ Address offset: 0x940
    \ Reset value: 0x00000000
    \
    $00 constant OTG_FS_MPSIZ                   \ [0x00 : 11] MPSIZ
    $0f constant OTG_FS_USBAEP                  \ [0x0f] USBAEP
    $10 constant OTG_FS_EONUM_DPIP              \ [0x10] EONUM_DPIP
    $11 constant OTG_FS_NAKSTS                  \ [0x11] NAKSTS
    $12 constant OTG_FS_EPTYP                   \ [0x12 : 2] EPTYP
    $15 constant OTG_FS_STALL                   \ [0x15] STALL
    $16 constant OTG_FS_TXFNUM                  \ [0x16 : 4] TXFNUM
    $1a constant OTG_FS_CNAK                    \ [0x1a] CNAK
    $1b constant OTG_FS_SNAK                    \ [0x1b] SNAK
    $1c constant OTG_FS_SD0PID_SEVNFRM          \ [0x1c] SD0PID_SEVNFRM
    $1d constant OTG_FS_SODDFRM                 \ [0x1d] SODDFRM
    $1e constant OTG_FS_EPDIS                   \ [0x1e] EPDIS
    $1f constant OTG_FS_EPENA                   \ [0x1f] EPENA
  [then]


  [ifdef] OTG_FS_DIEPINT2_DEF
    \
    \ @brief This register indicates the status of an endpoint with respect to USB- and AHB-related events. It is shown in Figure724. The application must read this register when the IN endpoints interrupt bit of the core interrupt register (IEPINT in GINTSTS) is set. Before the application can read this register, it must first read the device all endpoints interrupt (DAINT) register to get the exact endpoint number for the device endpoint-x interrupt register. The application must clear the appropriate bit in this register to clear the corresponding bits in the DAINT and GINTSTS registers.
    \ Address offset: 0x948
    \ Reset value: 0x00000080
    \
    $00 constant OTG_FS_XFRC                    \ [0x00] XFRC
    $01 constant OTG_FS_EPDISD                  \ [0x01] EPDISD
    $03 constant OTG_FS_TOC                     \ [0x03] TOC
    $04 constant OTG_FS_ITTXFE                  \ [0x04] ITTXFE
    $05 constant OTG_FS_INEPNM                  \ [0x05] INEPNM
    $06 constant OTG_FS_INEPNE                  \ [0x06] INEPNE
    $07 constant OTG_FS_TXFE                    \ [0x07] TXFE
    $0b constant OTG_FS_PKTDRPSTS               \ [0x0b] PKTDRPSTS
    $0d constant OTG_FS_NAK                     \ [0x0d] NAK
  [then]


  [ifdef] OTG_FS_DIEPTSIZ2_DEF
    \
    \ @brief The application must modify this register before enabling the endpoint. Once the endpoint is enabled using the endpoint enable bit in the DIEPCTLx registers (EPENA bit in DIEPCTLx), the core modifies this register. The application can only read this register once the core has cleared the endpoint enable bit.
    \ Address offset: 0x950
    \ Reset value: 0x00000000
    \
    $00 constant OTG_FS_XFRSIZ                  \ [0x00 : 19] XFRSIZ
    $13 constant OTG_FS_PKTCNT                  \ [0x13 : 10] PKTCNT
    $1d constant OTG_FS_MCNT                    \ [0x1d : 2] MCNT
  [then]


  [ifdef] OTG_FS_DTXFSTS2_DEF
    \
    \ @brief This read-only register contains the free space information for the device IN endpoint Tx FIFO.
    \ Address offset: 0x958
    \ Reset value: 0x00000200
    \
    $00 constant OTG_FS_INEPTFSAV               \ [0x00 : 16] INEPTFSAV
  [then]


  [ifdef] OTG_FS_DIEPCTL3_DEF
    \
    \ @brief The application uses this register to control the behavior of each logical endpoint other than endpoint 0.
    \ Address offset: 0x960
    \ Reset value: 0x00000000
    \
    $00 constant OTG_FS_MPSIZ                   \ [0x00 : 11] MPSIZ
    $0f constant OTG_FS_USBAEP                  \ [0x0f] USBAEP
    $10 constant OTG_FS_EONUM_DPIP              \ [0x10] EONUM_DPIP
    $11 constant OTG_FS_NAKSTS                  \ [0x11] NAKSTS
    $12 constant OTG_FS_EPTYP                   \ [0x12 : 2] EPTYP
    $15 constant OTG_FS_STALL                   \ [0x15] STALL
    $16 constant OTG_FS_TXFNUM                  \ [0x16 : 4] TXFNUM
    $1a constant OTG_FS_CNAK                    \ [0x1a] CNAK
    $1b constant OTG_FS_SNAK                    \ [0x1b] SNAK
    $1c constant OTG_FS_SD0PID_SEVNFRM          \ [0x1c] SD0PID_SEVNFRM
    $1d constant OTG_FS_SODDFRM                 \ [0x1d] SODDFRM
    $1e constant OTG_FS_EPDIS                   \ [0x1e] EPDIS
    $1f constant OTG_FS_EPENA                   \ [0x1f] EPENA
  [then]


  [ifdef] OTG_FS_DIEPINT3_DEF
    \
    \ @brief This register indicates the status of an endpoint with respect to USB- and AHB-related events. It is shown in Figure724. The application must read this register when the IN endpoints interrupt bit of the core interrupt register (IEPINT in GINTSTS) is set. Before the application can read this register, it must first read the device all endpoints interrupt (DAINT) register to get the exact endpoint number for the device endpoint-x interrupt register. The application must clear the appropriate bit in this register to clear the corresponding bits in the DAINT and GINTSTS registers.
    \ Address offset: 0x968
    \ Reset value: 0x00000080
    \
    $00 constant OTG_FS_XFRC                    \ [0x00] XFRC
    $01 constant OTG_FS_EPDISD                  \ [0x01] EPDISD
    $03 constant OTG_FS_TOC                     \ [0x03] TOC
    $04 constant OTG_FS_ITTXFE                  \ [0x04] ITTXFE
    $05 constant OTG_FS_INEPNM                  \ [0x05] INEPNM
    $06 constant OTG_FS_INEPNE                  \ [0x06] INEPNE
    $07 constant OTG_FS_TXFE                    \ [0x07] TXFE
    $0b constant OTG_FS_PKTDRPSTS               \ [0x0b] PKTDRPSTS
    $0d constant OTG_FS_NAK                     \ [0x0d] NAK
  [then]


  [ifdef] OTG_FS_DIEPTSIZ3_DEF
    \
    \ @brief The application must modify this register before enabling the endpoint. Once the endpoint is enabled using the endpoint enable bit in the DIEPCTLx registers (EPENA bit in DIEPCTLx), the core modifies this register. The application can only read this register once the core has cleared the endpoint enable bit.
    \ Address offset: 0x970
    \ Reset value: 0x00000000
    \
    $00 constant OTG_FS_XFRSIZ                  \ [0x00 : 19] XFRSIZ
    $13 constant OTG_FS_PKTCNT                  \ [0x13 : 10] PKTCNT
    $1d constant OTG_FS_MCNT                    \ [0x1d : 2] MCNT
  [then]


  [ifdef] OTG_FS_DTXFSTS3_DEF
    \
    \ @brief This read-only register contains the free space information for the device IN endpoint Tx FIFO.
    \ Address offset: 0x978
    \ Reset value: 0x00000200
    \
    $00 constant OTG_FS_INEPTFSAV               \ [0x00 : 16] INEPTFSAV
  [then]


  [ifdef] OTG_FS_DIEPCTL4_DEF
    \
    \ @brief The application uses this register to control the behavior of each logical endpoint other than endpoint 0.
    \ Address offset: 0x980
    \ Reset value: 0x00000000
    \
    $00 constant OTG_FS_MPSIZ                   \ [0x00 : 11] MPSIZ
    $0f constant OTG_FS_USBAEP                  \ [0x0f] USBAEP
    $10 constant OTG_FS_EONUM_DPIP              \ [0x10] EONUM_DPIP
    $11 constant OTG_FS_NAKSTS                  \ [0x11] NAKSTS
    $12 constant OTG_FS_EPTYP                   \ [0x12 : 2] EPTYP
    $15 constant OTG_FS_STALL                   \ [0x15] STALL
    $16 constant OTG_FS_TXFNUM                  \ [0x16 : 4] TXFNUM
    $1a constant OTG_FS_CNAK                    \ [0x1a] CNAK
    $1b constant OTG_FS_SNAK                    \ [0x1b] SNAK
    $1c constant OTG_FS_SD0PID_SEVNFRM          \ [0x1c] SD0PID_SEVNFRM
    $1d constant OTG_FS_SODDFRM                 \ [0x1d] SODDFRM
    $1e constant OTG_FS_EPDIS                   \ [0x1e] EPDIS
    $1f constant OTG_FS_EPENA                   \ [0x1f] EPENA
  [then]


  [ifdef] OTG_FS_DIEPINT4_DEF
    \
    \ @brief This register indicates the status of an endpoint with respect to USB- and AHB-related events. It is shown in Figure724. The application must read this register when the IN endpoints interrupt bit of the core interrupt register (IEPINT in GINTSTS) is set. Before the application can read this register, it must first read the device all endpoints interrupt (DAINT) register to get the exact endpoint number for the device endpoint-x interrupt register. The application must clear the appropriate bit in this register to clear the corresponding bits in the DAINT and GINTSTS registers.
    \ Address offset: 0x988
    \ Reset value: 0x00000080
    \
    $00 constant OTG_FS_XFRC                    \ [0x00] XFRC
    $01 constant OTG_FS_EPDISD                  \ [0x01] EPDISD
    $03 constant OTG_FS_TOC                     \ [0x03] TOC
    $04 constant OTG_FS_ITTXFE                  \ [0x04] ITTXFE
    $05 constant OTG_FS_INEPNM                  \ [0x05] INEPNM
    $06 constant OTG_FS_INEPNE                  \ [0x06] INEPNE
    $07 constant OTG_FS_TXFE                    \ [0x07] TXFE
    $0b constant OTG_FS_PKTDRPSTS               \ [0x0b] PKTDRPSTS
    $0d constant OTG_FS_NAK                     \ [0x0d] NAK
  [then]


  [ifdef] OTG_FS_DIEPTSIZ4_DEF
    \
    \ @brief The application must modify this register before enabling the endpoint. Once the endpoint is enabled using the endpoint enable bit in the DIEPCTLx registers (EPENA bit in DIEPCTLx), the core modifies this register. The application can only read this register once the core has cleared the endpoint enable bit.
    \ Address offset: 0x990
    \ Reset value: 0x00000000
    \
    $00 constant OTG_FS_XFRSIZ                  \ [0x00 : 19] XFRSIZ
    $13 constant OTG_FS_PKTCNT                  \ [0x13 : 10] PKTCNT
    $1d constant OTG_FS_MCNT                    \ [0x1d : 2] MCNT
  [then]


  [ifdef] OTG_FS_DTXFSTS4_DEF
    \
    \ @brief This read-only register contains the free space information for the device IN endpoint Tx FIFO.
    \ Address offset: 0x998
    \ Reset value: 0x00000200
    \
    $00 constant OTG_FS_INEPTFSAV               \ [0x00 : 16] INEPTFSAV
  [then]


  [ifdef] OTG_FS_DIEPCTL5_DEF
    \
    \ @brief The application uses this register to control the behavior of each logical endpoint other than endpoint 0.
    \ Address offset: 0x9A0
    \ Reset value: 0x00000000
    \
    $00 constant OTG_FS_MPSIZ                   \ [0x00 : 11] MPSIZ
    $0f constant OTG_FS_USBAEP                  \ [0x0f] USBAEP
    $10 constant OTG_FS_EONUM_DPIP              \ [0x10] EONUM_DPIP
    $11 constant OTG_FS_NAKSTS                  \ [0x11] NAKSTS
    $12 constant OTG_FS_EPTYP                   \ [0x12 : 2] EPTYP
    $15 constant OTG_FS_STALL                   \ [0x15] STALL
    $16 constant OTG_FS_TXFNUM                  \ [0x16 : 4] TXFNUM
    $1a constant OTG_FS_CNAK                    \ [0x1a] CNAK
    $1b constant OTG_FS_SNAK                    \ [0x1b] SNAK
    $1c constant OTG_FS_SD0PID_SEVNFRM          \ [0x1c] SD0PID_SEVNFRM
    $1d constant OTG_FS_SODDFRM                 \ [0x1d] SODDFRM
    $1e constant OTG_FS_EPDIS                   \ [0x1e] EPDIS
    $1f constant OTG_FS_EPENA                   \ [0x1f] EPENA
  [then]


  [ifdef] OTG_FS_DIEPINT5_DEF
    \
    \ @brief This register indicates the status of an endpoint with respect to USB- and AHB-related events. It is shown in Figure724. The application must read this register when the IN endpoints interrupt bit of the core interrupt register (IEPINT in GINTSTS) is set. Before the application can read this register, it must first read the device all endpoints interrupt (DAINT) register to get the exact endpoint number for the device endpoint-x interrupt register. The application must clear the appropriate bit in this register to clear the corresponding bits in the DAINT and GINTSTS registers.
    \ Address offset: 0x9A8
    \ Reset value: 0x00000080
    \
    $00 constant OTG_FS_XFRC                    \ [0x00] XFRC
    $01 constant OTG_FS_EPDISD                  \ [0x01] EPDISD
    $03 constant OTG_FS_TOC                     \ [0x03] TOC
    $04 constant OTG_FS_ITTXFE                  \ [0x04] ITTXFE
    $05 constant OTG_FS_INEPNM                  \ [0x05] INEPNM
    $06 constant OTG_FS_INEPNE                  \ [0x06] INEPNE
    $07 constant OTG_FS_TXFE                    \ [0x07] TXFE
    $0b constant OTG_FS_PKTDRPSTS               \ [0x0b] PKTDRPSTS
    $0d constant OTG_FS_NAK                     \ [0x0d] NAK
  [then]


  [ifdef] OTG_FS_DIEPTSIZ5_DEF
    \
    \ @brief The application must modify this register before enabling the endpoint. Once the endpoint is enabled using the endpoint enable bit in the DIEPCTLx registers (EPENA bit in DIEPCTLx), the core modifies this register. The application can only read this register once the core has cleared the endpoint enable bit.
    \ Address offset: 0x9B0
    \ Reset value: 0x00000000
    \
    $00 constant OTG_FS_XFRSIZ                  \ [0x00 : 19] XFRSIZ
    $13 constant OTG_FS_PKTCNT                  \ [0x13 : 10] PKTCNT
    $1d constant OTG_FS_MCNT                    \ [0x1d : 2] MCNT
  [then]


  [ifdef] OTG_FS_DTXFSTS5_DEF
    \
    \ @brief This read-only register contains the free space information for the device IN endpoint Tx FIFO.
    \ Address offset: 0x9B8
    \ Reset value: 0x00000200
    \
    $00 constant OTG_FS_INEPTFSAV               \ [0x00 : 16] INEPTFSAV
  [then]


  [ifdef] OTG_FS_DOEPCTL0_DEF
    \
    \ @brief This section describes the DOEPCTL0 register.
    \ Address offset: 0xB00
    \ Reset value: 0x00008000
    \
    $00 constant OTG_FS_MPSIZ                   \ [0x00 : 2] MPSIZ
    $0f constant OTG_FS_USBAEP                  \ [0x0f] USBAEP
    $11 constant OTG_FS_NAKSTS                  \ [0x11] NAKSTS
    $12 constant OTG_FS_EPTYP                   \ [0x12 : 2] EPTYP
    $14 constant OTG_FS_SNPM                    \ [0x14] SNPM
    $15 constant OTG_FS_STALL                   \ [0x15] STALL
    $1a constant OTG_FS_CNAK                    \ [0x1a] CNAK
    $1b constant OTG_FS_SNAK                    \ [0x1b] SNAK
    $1e constant OTG_FS_EPDIS                   \ [0x1e] EPDIS
    $1f constant OTG_FS_EPENA                   \ [0x1f] EPENA
  [then]


  [ifdef] OTG_FS_DOEPINT0_DEF
    \
    \ @brief This register indicates the status of an endpoint with respect to USB- and AHB-related events. It is shown in Figure724. The application must read this register when the OUT endpoints interrupt bit of the GINTSTS register (OEPINT bit in GINTSTS) is set. Before the application can read this register, it must first read the DAINT register to get the exact endpoint number for the DOEPINTx register. The application must clear the appropriate bit in this register to clear the corresponding bits in the DAINT and GINTSTS registers.
    \ Address offset: 0xB08
    \ Reset value: 0x00000080
    \
    $00 constant OTG_FS_XFRC                    \ [0x00] XFRC
    $01 constant OTG_FS_EPDISD                  \ [0x01] EPDISD
    $02 constant OTG_FS_AHBERR                  \ [0x02] AHBERR
    $03 constant OTG_FS_STUP                    \ [0x03] STUP
    $04 constant OTG_FS_OTEPDIS                 \ [0x04] OTEPDIS
    $05 constant OTG_FS_STSPHSRX                \ [0x05] STSPHSRX
    $06 constant OTG_FS_B2BSTUP                 \ [0x06] B2BSTUP
    $08 constant OTG_FS_OUTPKTERR               \ [0x08] OUTPKTERR
    $09 constant OTG_FS_BNA                     \ [0x09] BNA
    $0c constant OTG_FS_BERR                    \ [0x0c] BERR
    $0d constant OTG_FS_NAK                     \ [0x0d] NAK
    $0e constant OTG_FS_NYET                    \ [0x0e] NYET
    $0f constant OTG_FS_STPKTRX                 \ [0x0f] STPKTRX
  [then]


  [ifdef] OTG_FS_DOEPTSIZ0_DEF
    \
    \ @brief The application must modify this register before enabling endpoint 0.
    \ Address offset: 0xB10
    \ Reset value: 0x00000000
    \
    $00 constant OTG_FS_XFRSIZ                  \ [0x00 : 7] XFRSIZ
    $13 constant OTG_FS_PKTCNT                  \ [0x13] PKTCNT
    $1d constant OTG_FS_STUPCNT                 \ [0x1d : 2] STUPCNT
  [then]


  [ifdef] OTG_FS_DOEPCTL1_DEF
    \
    \ @brief The application uses this register to control the behavior of each logical endpoint other than endpoint 0.
    \ Address offset: 0xB20
    \ Reset value: 0x00000000
    \
    $00 constant OTG_FS_MPSIZ                   \ [0x00 : 11] MPSIZ
    $0f constant OTG_FS_USBAEP                  \ [0x0f] USBAEP
    $10 constant OTG_FS_EONUM_DPIP              \ [0x10] EONUM_DPIP
    $11 constant OTG_FS_NAKSTS                  \ [0x11] NAKSTS
    $12 constant OTG_FS_EPTYP                   \ [0x12 : 2] EPTYP
    $14 constant OTG_FS_SNPM                    \ [0x14] SNPM
    $15 constant OTG_FS_STALL                   \ [0x15] STALL
    $1a constant OTG_FS_CNAK                    \ [0x1a] CNAK
    $1b constant OTG_FS_SNAK                    \ [0x1b] SNAK
    $1c constant OTG_FS_SD0PID_SEVNFRM          \ [0x1c] SD0PID_SEVNFRM
    $1d constant OTG_FS_SD1PID_SODDFRM          \ [0x1d] SD1PID_SODDFRM
    $1e constant OTG_FS_EPDIS                   \ [0x1e] EPDIS
    $1f constant OTG_FS_EPENA                   \ [0x1f] EPENA
  [then]


  [ifdef] OTG_FS_DOEPINT1_DEF
    \
    \ @brief This register indicates the status of an endpoint with respect to USB- and AHB-related events. It is shown in Figure724. The application must read this register when the OUT endpoints interrupt bit of the GINTSTS register (OEPINT bit in GINTSTS) is set. Before the application can read this register, it must first read the DAINT register to get the exact endpoint number for the DOEPINTx register. The application must clear the appropriate bit in this register to clear the corresponding bits in the DAINT and GINTSTS registers.
    \ Address offset: 0xB28
    \ Reset value: 0x00000080
    \
    $00 constant OTG_FS_XFRC                    \ [0x00] XFRC
    $01 constant OTG_FS_EPDISD                  \ [0x01] EPDISD
    $02 constant OTG_FS_AHBERR                  \ [0x02] AHBERR
    $03 constant OTG_FS_STUP                    \ [0x03] STUP
    $04 constant OTG_FS_OTEPDIS                 \ [0x04] OTEPDIS
    $05 constant OTG_FS_STSPHSRX                \ [0x05] STSPHSRX
    $06 constant OTG_FS_B2BSTUP                 \ [0x06] B2BSTUP
    $08 constant OTG_FS_OUTPKTERR               \ [0x08] OUTPKTERR
    $09 constant OTG_FS_BNA                     \ [0x09] BNA
    $0c constant OTG_FS_BERR                    \ [0x0c] BERR
    $0d constant OTG_FS_NAK                     \ [0x0d] NAK
    $0e constant OTG_FS_NYET                    \ [0x0e] NYET
    $0f constant OTG_FS_STPKTRX                 \ [0x0f] STPKTRX
  [then]


  [ifdef] OTG_FS_DOEPTSIZ1_DEF
    \
    \ @brief The application must modify this register before enabling the endpoint. Once the endpoint is enabled using endpoint enable bit of the DOEPCTLx registers (EPENA bit in DOEPCTLx), the core modifies this register. The application can only read this register once the core has cleared the endpoint enable bit.
    \ Address offset: 0xB30
    \ Reset value: 0x00000000
    \
    $00 constant OTG_FS_XFRSIZ                  \ [0x00 : 19] XFRSIZ
    $13 constant OTG_FS_PKTCNT                  \ [0x13 : 10] PKTCNT
    $1d constant OTG_FS_RXDPID_STUPCNT          \ [0x1d : 2] RXDPID_STUPCNT
  [then]


  [ifdef] OTG_FS_DOEPCTL2_DEF
    \
    \ @brief The application uses this register to control the behavior of each logical endpoint other than endpoint 0.
    \ Address offset: 0xB40
    \ Reset value: 0x00000000
    \
    $00 constant OTG_FS_MPSIZ                   \ [0x00 : 11] MPSIZ
    $0f constant OTG_FS_USBAEP                  \ [0x0f] USBAEP
    $10 constant OTG_FS_EONUM_DPIP              \ [0x10] EONUM_DPIP
    $11 constant OTG_FS_NAKSTS                  \ [0x11] NAKSTS
    $12 constant OTG_FS_EPTYP                   \ [0x12 : 2] EPTYP
    $14 constant OTG_FS_SNPM                    \ [0x14] SNPM
    $15 constant OTG_FS_STALL                   \ [0x15] STALL
    $1a constant OTG_FS_CNAK                    \ [0x1a] CNAK
    $1b constant OTG_FS_SNAK                    \ [0x1b] SNAK
    $1c constant OTG_FS_SD0PID_SEVNFRM          \ [0x1c] SD0PID_SEVNFRM
    $1d constant OTG_FS_SD1PID_SODDFRM          \ [0x1d] SD1PID_SODDFRM
    $1e constant OTG_FS_EPDIS                   \ [0x1e] EPDIS
    $1f constant OTG_FS_EPENA                   \ [0x1f] EPENA
  [then]


  [ifdef] OTG_FS_DOEPINT2_DEF
    \
    \ @brief This register indicates the status of an endpoint with respect to USB- and AHB-related events. It is shown in Figure724. The application must read this register when the OUT endpoints interrupt bit of the GINTSTS register (OEPINT bit in GINTSTS) is set. Before the application can read this register, it must first read the DAINT register to get the exact endpoint number for the DOEPINTx register. The application must clear the appropriate bit in this register to clear the corresponding bits in the DAINT and GINTSTS registers.
    \ Address offset: 0xB48
    \ Reset value: 0x00000080
    \
    $00 constant OTG_FS_XFRC                    \ [0x00] XFRC
    $01 constant OTG_FS_EPDISD                  \ [0x01] EPDISD
    $02 constant OTG_FS_AHBERR                  \ [0x02] AHBERR
    $03 constant OTG_FS_STUP                    \ [0x03] STUP
    $04 constant OTG_FS_OTEPDIS                 \ [0x04] OTEPDIS
    $05 constant OTG_FS_STSPHSRX                \ [0x05] STSPHSRX
    $06 constant OTG_FS_B2BSTUP                 \ [0x06] B2BSTUP
    $08 constant OTG_FS_OUTPKTERR               \ [0x08] OUTPKTERR
    $09 constant OTG_FS_BNA                     \ [0x09] BNA
    $0c constant OTG_FS_BERR                    \ [0x0c] BERR
    $0d constant OTG_FS_NAK                     \ [0x0d] NAK
    $0e constant OTG_FS_NYET                    \ [0x0e] NYET
    $0f constant OTG_FS_STPKTRX                 \ [0x0f] STPKTRX
  [then]


  [ifdef] OTG_FS_DOEPTSIZ2_DEF
    \
    \ @brief The application must modify this register before enabling the endpoint. Once the endpoint is enabled using endpoint enable bit of the DOEPCTLx registers (EPENA bit in DOEPCTLx), the core modifies this register. The application can only read this register once the core has cleared the endpoint enable bit.
    \ Address offset: 0xB50
    \ Reset value: 0x00000000
    \
    $00 constant OTG_FS_XFRSIZ                  \ [0x00 : 19] XFRSIZ
    $13 constant OTG_FS_PKTCNT                  \ [0x13 : 10] PKTCNT
    $1d constant OTG_FS_RXDPID_STUPCNT          \ [0x1d : 2] RXDPID_STUPCNT
  [then]


  [ifdef] OTG_FS_DOEPCTL3_DEF
    \
    \ @brief The application uses this register to control the behavior of each logical endpoint other than endpoint 0.
    \ Address offset: 0xB60
    \ Reset value: 0x00000000
    \
    $00 constant OTG_FS_MPSIZ                   \ [0x00 : 11] MPSIZ
    $0f constant OTG_FS_USBAEP                  \ [0x0f] USBAEP
    $10 constant OTG_FS_EONUM_DPIP              \ [0x10] EONUM_DPIP
    $11 constant OTG_FS_NAKSTS                  \ [0x11] NAKSTS
    $12 constant OTG_FS_EPTYP                   \ [0x12 : 2] EPTYP
    $14 constant OTG_FS_SNPM                    \ [0x14] SNPM
    $15 constant OTG_FS_STALL                   \ [0x15] STALL
    $1a constant OTG_FS_CNAK                    \ [0x1a] CNAK
    $1b constant OTG_FS_SNAK                    \ [0x1b] SNAK
    $1c constant OTG_FS_SD0PID_SEVNFRM          \ [0x1c] SD0PID_SEVNFRM
    $1d constant OTG_FS_SD1PID_SODDFRM          \ [0x1d] SD1PID_SODDFRM
    $1e constant OTG_FS_EPDIS                   \ [0x1e] EPDIS
    $1f constant OTG_FS_EPENA                   \ [0x1f] EPENA
  [then]


  [ifdef] OTG_FS_DOEPINT3_DEF
    \
    \ @brief This register indicates the status of an endpoint with respect to USB- and AHB-related events. It is shown in Figure724. The application must read this register when the OUT endpoints interrupt bit of the GINTSTS register (OEPINT bit in GINTSTS) is set. Before the application can read this register, it must first read the DAINT register to get the exact endpoint number for the DOEPINTx register. The application must clear the appropriate bit in this register to clear the corresponding bits in the DAINT and GINTSTS registers.
    \ Address offset: 0xB68
    \ Reset value: 0x00000080
    \
    $00 constant OTG_FS_XFRC                    \ [0x00] XFRC
    $01 constant OTG_FS_EPDISD                  \ [0x01] EPDISD
    $02 constant OTG_FS_AHBERR                  \ [0x02] AHBERR
    $03 constant OTG_FS_STUP                    \ [0x03] STUP
    $04 constant OTG_FS_OTEPDIS                 \ [0x04] OTEPDIS
    $05 constant OTG_FS_STSPHSRX                \ [0x05] STSPHSRX
    $06 constant OTG_FS_B2BSTUP                 \ [0x06] B2BSTUP
    $08 constant OTG_FS_OUTPKTERR               \ [0x08] OUTPKTERR
    $09 constant OTG_FS_BNA                     \ [0x09] BNA
    $0c constant OTG_FS_BERR                    \ [0x0c] BERR
    $0d constant OTG_FS_NAK                     \ [0x0d] NAK
    $0e constant OTG_FS_NYET                    \ [0x0e] NYET
    $0f constant OTG_FS_STPKTRX                 \ [0x0f] STPKTRX
  [then]


  [ifdef] OTG_FS_DOEPTSIZ3_DEF
    \
    \ @brief The application must modify this register before enabling the endpoint. Once the endpoint is enabled using endpoint enable bit of the DOEPCTLx registers (EPENA bit in DOEPCTLx), the core modifies this register. The application can only read this register once the core has cleared the endpoint enable bit.
    \ Address offset: 0xB70
    \ Reset value: 0x00000000
    \
    $00 constant OTG_FS_XFRSIZ                  \ [0x00 : 19] XFRSIZ
    $13 constant OTG_FS_PKTCNT                  \ [0x13 : 10] PKTCNT
    $1d constant OTG_FS_RXDPID_STUPCNT          \ [0x1d : 2] RXDPID_STUPCNT
  [then]


  [ifdef] OTG_FS_DOEPCTL4_DEF
    \
    \ @brief The application uses this register to control the behavior of each logical endpoint other than endpoint 0.
    \ Address offset: 0xB80
    \ Reset value: 0x00000000
    \
    $00 constant OTG_FS_MPSIZ                   \ [0x00 : 11] MPSIZ
    $0f constant OTG_FS_USBAEP                  \ [0x0f] USBAEP
    $10 constant OTG_FS_EONUM_DPIP              \ [0x10] EONUM_DPIP
    $11 constant OTG_FS_NAKSTS                  \ [0x11] NAKSTS
    $12 constant OTG_FS_EPTYP                   \ [0x12 : 2] EPTYP
    $14 constant OTG_FS_SNPM                    \ [0x14] SNPM
    $15 constant OTG_FS_STALL                   \ [0x15] STALL
    $1a constant OTG_FS_CNAK                    \ [0x1a] CNAK
    $1b constant OTG_FS_SNAK                    \ [0x1b] SNAK
    $1c constant OTG_FS_SD0PID_SEVNFRM          \ [0x1c] SD0PID_SEVNFRM
    $1d constant OTG_FS_SD1PID_SODDFRM          \ [0x1d] SD1PID_SODDFRM
    $1e constant OTG_FS_EPDIS                   \ [0x1e] EPDIS
    $1f constant OTG_FS_EPENA                   \ [0x1f] EPENA
  [then]


  [ifdef] OTG_FS_DOEPINT4_DEF
    \
    \ @brief This register indicates the status of an endpoint with respect to USB- and AHB-related events. It is shown in Figure724. The application must read this register when the OUT endpoints interrupt bit of the GINTSTS register (OEPINT bit in GINTSTS) is set. Before the application can read this register, it must first read the DAINT register to get the exact endpoint number for the DOEPINTx register. The application must clear the appropriate bit in this register to clear the corresponding bits in the DAINT and GINTSTS registers.
    \ Address offset: 0xB88
    \ Reset value: 0x00000080
    \
    $00 constant OTG_FS_XFRC                    \ [0x00] XFRC
    $01 constant OTG_FS_EPDISD                  \ [0x01] EPDISD
    $02 constant OTG_FS_AHBERR                  \ [0x02] AHBERR
    $03 constant OTG_FS_STUP                    \ [0x03] STUP
    $04 constant OTG_FS_OTEPDIS                 \ [0x04] OTEPDIS
    $05 constant OTG_FS_STSPHSRX                \ [0x05] STSPHSRX
    $06 constant OTG_FS_B2BSTUP                 \ [0x06] B2BSTUP
    $08 constant OTG_FS_OUTPKTERR               \ [0x08] OUTPKTERR
    $09 constant OTG_FS_BNA                     \ [0x09] BNA
    $0c constant OTG_FS_BERR                    \ [0x0c] BERR
    $0d constant OTG_FS_NAK                     \ [0x0d] NAK
    $0e constant OTG_FS_NYET                    \ [0x0e] NYET
    $0f constant OTG_FS_STPKTRX                 \ [0x0f] STPKTRX
  [then]


  [ifdef] OTG_FS_DOEPTSIZ4_DEF
    \
    \ @brief The application must modify this register before enabling the endpoint. Once the endpoint is enabled using endpoint enable bit of the DOEPCTLx registers (EPENA bit in DOEPCTLx), the core modifies this register. The application can only read this register once the core has cleared the endpoint enable bit.
    \ Address offset: 0xB90
    \ Reset value: 0x00000000
    \
    $00 constant OTG_FS_XFRSIZ                  \ [0x00 : 19] XFRSIZ
    $13 constant OTG_FS_PKTCNT                  \ [0x13 : 10] PKTCNT
    $1d constant OTG_FS_RXDPID_STUPCNT          \ [0x1d : 2] RXDPID_STUPCNT
  [then]


  [ifdef] OTG_FS_DOEPCTL5_DEF
    \
    \ @brief The application uses this register to control the behavior of each logical endpoint other than endpoint 0.
    \ Address offset: 0xBA0
    \ Reset value: 0x00000000
    \
    $00 constant OTG_FS_MPSIZ                   \ [0x00 : 11] MPSIZ
    $0f constant OTG_FS_USBAEP                  \ [0x0f] USBAEP
    $10 constant OTG_FS_EONUM_DPIP              \ [0x10] EONUM_DPIP
    $11 constant OTG_FS_NAKSTS                  \ [0x11] NAKSTS
    $12 constant OTG_FS_EPTYP                   \ [0x12 : 2] EPTYP
    $14 constant OTG_FS_SNPM                    \ [0x14] SNPM
    $15 constant OTG_FS_STALL                   \ [0x15] STALL
    $1a constant OTG_FS_CNAK                    \ [0x1a] CNAK
    $1b constant OTG_FS_SNAK                    \ [0x1b] SNAK
    $1c constant OTG_FS_SD0PID_SEVNFRM          \ [0x1c] SD0PID_SEVNFRM
    $1d constant OTG_FS_SD1PID_SODDFRM          \ [0x1d] SD1PID_SODDFRM
    $1e constant OTG_FS_EPDIS                   \ [0x1e] EPDIS
    $1f constant OTG_FS_EPENA                   \ [0x1f] EPENA
  [then]


  [ifdef] OTG_FS_DOEPINT5_DEF
    \
    \ @brief This register indicates the status of an endpoint with respect to USB- and AHB-related events. It is shown in Figure724. The application must read this register when the OUT endpoints interrupt bit of the GINTSTS register (OEPINT bit in GINTSTS) is set. Before the application can read this register, it must first read the DAINT register to get the exact endpoint number for the DOEPINTx register. The application must clear the appropriate bit in this register to clear the corresponding bits in the DAINT and GINTSTS registers.
    \ Address offset: 0xBA8
    \ Reset value: 0x00000080
    \
    $00 constant OTG_FS_XFRC                    \ [0x00] XFRC
    $01 constant OTG_FS_EPDISD                  \ [0x01] EPDISD
    $02 constant OTG_FS_AHBERR                  \ [0x02] AHBERR
    $03 constant OTG_FS_STUP                    \ [0x03] STUP
    $04 constant OTG_FS_OTEPDIS                 \ [0x04] OTEPDIS
    $05 constant OTG_FS_STSPHSRX                \ [0x05] STSPHSRX
    $06 constant OTG_FS_B2BSTUP                 \ [0x06] B2BSTUP
    $08 constant OTG_FS_OUTPKTERR               \ [0x08] OUTPKTERR
    $09 constant OTG_FS_BNA                     \ [0x09] BNA
    $0c constant OTG_FS_BERR                    \ [0x0c] BERR
    $0d constant OTG_FS_NAK                     \ [0x0d] NAK
    $0e constant OTG_FS_NYET                    \ [0x0e] NYET
    $0f constant OTG_FS_STPKTRX                 \ [0x0f] STPKTRX
  [then]


  [ifdef] OTG_FS_DOEPTSIZ5_DEF
    \
    \ @brief The application must modify this register before enabling the endpoint. Once the endpoint is enabled using endpoint enable bit of the DOEPCTLx registers (EPENA bit in DOEPCTLx), the core modifies this register. The application can only read this register once the core has cleared the endpoint enable bit.
    \ Address offset: 0xBB0
    \ Reset value: 0x00000000
    \
    $00 constant OTG_FS_XFRSIZ                  \ [0x00 : 19] XFRSIZ
    $13 constant OTG_FS_PKTCNT                  \ [0x13 : 10] PKTCNT
    $1d constant OTG_FS_RXDPID_STUPCNT          \ [0x1d : 2] RXDPID_STUPCNT
  [then]


  [ifdef] OTG_FS_PCGCCTL_DEF
    \
    \ @brief This register is available in host and device modes.
    \ Address offset: 0xE00
    \ Reset value: 0x200B8000
    \
    $00 constant OTG_FS_STPPCLK                 \ [0x00] STPPCLK
    $01 constant OTG_FS_GATEHCLK                \ [0x01] GATEHCLK
    $04 constant OTG_FS_PHYSUSP                 \ [0x04] PHYSUSP
    $05 constant OTG_FS_ENL1GTG                 \ [0x05] ENL1GTG
    $06 constant OTG_FS_PHYSLEEP                \ [0x06] PHYSLEEP
    $07 constant OTG_FS_SUSP                    \ [0x07] SUSP
  [then]

  \
  \ @brief OTG_FS
  \
  $00 constant OTG_FS_GOTGCTL           \ The GOTGCTL register controls the behavior and reflects the status of the OTG function of the core.
  $04 constant OTG_FS_GOTGINT           \ The application reads this register whenever there is an OTG interrupt and clears the bits in this register to clear the OTG interrupt.
  $08 constant OTG_FS_GAHBCFG           \ This register can be used to configure the core after power-on or a change in mode. This register mainly contains AHB system-related configuration parameters. Do not change this register after the initial programming. The application must program this register before starting any transactions on either the AHB or the USB.
  $0C constant OTG_FS_GUSBCFG           \ This register can be used to configure the core after power-on or a changing to host mode or device mode. It contains USB and USB-PHY related configuration parameters. The application must program this register before starting any transactions on either the AHB or the USB. Do not make changes to this register after the initial programming.
  $10 constant OTG_FS_GRSTCTL           \ The application uses this register to reset various hardware features inside the core.
  $14 constant OTG_FS_GINTSTS           \ This register interrupts the application for system-level events in the current mode (device mode or host mode). Some of the bits in this register are valid only in host mode, while others are valid in device mode only. This register also indicates the current mode. To clear the interrupt status bits of the rc_w1 type, the application must write 1 into the bit. The FIFO status interrupts are read-only; once software reads from or writes to the FIFO while servicing these interrupts, FIFO interrupt conditions are cleared automatically. The application must clear the GINTSTS register at initialization before unmasking the interrupt bit to avoid any interrupts generated prior to initialization.
  $18 constant OTG_FS_GINTMSK           \ This register works with the core interrupt register to interrupt the application. When an interrupt bit is masked, the interrupt associated with that bit is not generated. However, the core interrupt (GINTSTS) register bit corresponding to that interrupt is still set.
  $1C constant OTG_FS_GRXSTSR_DEVICE    \ This description is for register GRXSTSR in Device mode. A read to the receive status debug read register returns the contents of the top of the receive FIFO. The core ignores the receive status read when the receive FIFO is empty and returns a value of 0x00000000.
  $1C constant OTG_FS_GRXSTSR_HOST      \ This description is for register GRXSTSR in Host mode
  $20 constant OTG_FS_GRXSTSP_DEVICE    \ This description is for register GRXSTSP in Device mode. Similarly to GRXSTSR (receive status debug read register) where a read returns the contents of the top of the receive FIFO, a read to GRXSTSP (receive status read and pop register) additionally pops the top data entry out of the Rx FIFO. The core ignores the receive status pop/read when the receive FIFO is empty and returns a value of 0x00000000. The application must only pop the receive status FIFO when the receive FIFO non-empty bit of the core interrupt register (RXFLVL bit in GINTSTS) is asserted.
  $20 constant OTG_FS_GRXSTSP_HOST      \ This description is for register GRXSTSP in HOST mode
  $24 constant OTG_FS_GRXFSIZ           \ The application can program the RAM size that must be allocated to the Rx FIFO.
  $28 constant OTG_FS_HNPTXFSIZ         \ Host mode
  $2C constant OTG_FS_HNPTXSTS          \ In device mode, this register is not valid. This read-only register contains the free space information for the non-periodic Tx FIFO and the non-periodic transmit request queue.
  $38 constant OTG_FS_GCCFG             \ OTG general core configuration register
  $3C constant OTG_FS_CID               \ This is a register containing the Product ID as reset value.
  $54 constant OTG_FS_GLPMCFG           \ OTG core LPM configuration register
  $100 constant OTG_FS_HPTXFSIZ         \ OTG host periodic transmit FIFO size register
  $104 constant OTG_FS_DIEPTXF1         \ OTG device IN endpoint transmit FIFO 1 size register
  $108 constant OTG_FS_DIEPTXF2         \ OTG device IN endpoint transmit FIFO 2 size register
  $10C constant OTG_FS_DIEPTXF3         \ OTG device IN endpoint transmit FIFO 3 size register
  $110 constant OTG_FS_DIEPTXF4         \ OTG device IN endpoint transmit FIFO 4 size register
  $114 constant OTG_FS_DIEPTXF5         \ OTG device IN endpoint transmit FIFO 5 size register
  $400 constant OTG_FS_HCFG             \ This register configures the core after power-on. Do not make changes to this register after initializing the host.
  $404 constant OTG_FS_HFIR             \ This register stores the frame interval information for the current speed to which the OTG controller has enumerated.
  $408 constant OTG_FS_HFNUM            \ This register indicates the current frame number. It also indicates the time remaining (in terms of the number of PHY clocks) in the current frame.
  $410 constant OTG_FS_HPTXSTS          \ This read-only register contains the free space information for the periodic Tx FIFO and the periodic transmit request queue.
  $414 constant OTG_FS_HAINT            \ When a significant event occurs on a channel, the host all channels interrupt register interrupts the application using the host channels interrupt bit of the core interrupt register (HCINT bit in GINTSTS). This is shown in Figure724. There is one interrupt bit per channel, up to a maximum of 16 bits. Bits in this register are set and cleared when the application sets and clears bits in the corresponding host channel-x interrupt register.
  $418 constant OTG_FS_HAINTMSK         \ The host all channel interrupt mask register works with the host all channel interrupt register to interrupt the application when an event occurs on a channel. There is one interrupt mask bit per channel, up to a maximum of 16 bits.
  $440 constant OTG_FS_HPRT             \ This register is available only in host mode. Currently, the OTG host supports only one port. A single register holds USB port-related information such as USB reset, enable, suspend, resume, connect status, and test mode for each port. It is shown in Figure724. The rc_w1 bits in this register can trigger an interrupt to the application through the host port interrupt bit of the core interrupt register (HPRTINT bit in GINTSTS). On a port interrupt, the application must read this register and clear the bit that caused the interrupt. For the rc_w1 bits, the application must write a 1 to the bit to clear the interrupt.
  $500 constant OTG_FS_HCCHAR0          \ OTG host channel 0 characteristics register
  $508 constant OTG_FS_HCINT0           \ This register indicates the status of a channel with respect to USB- and AHB-related events. It is shown in Figure724. The application must read this register when the host channels interrupt bit in the core interrupt register (HCINT bit in GINTSTS) is set. Before the application can read this register, it must first read the host all channels interrupt (HAINT) register to get the exact channel number for the host channel-x interrupt register. The application must clear the appropriate bit in this register to clear the corresponding bits in the HAINT and GINTSTS registers.
  $50C constant OTG_FS_HCINTMSK0        \ This register reflects the mask for each channel status described in the previous section.
  $510 constant OTG_FS_HCTSIZ0          \ OTG host channel 0 transfer size register
  $520 constant OTG_FS_HCCHAR1          \ OTG host channel 1 characteristics register
  $528 constant OTG_FS_HCINT1           \ This register indicates the status of a channel with respect to USB- and AHB-related events. It is shown in Figure724. The application must read this register when the host channels interrupt bit in the core interrupt register (HCINT bit in GINTSTS) is set. Before the application can read this register, it must first read the host all channels interrupt (HAINT) register to get the exact channel number for the host channel-x interrupt register. The application must clear the appropriate bit in this register to clear the corresponding bits in the HAINT and GINTSTS registers.
  $52C constant OTG_FS_HCINTMSK1        \ This register reflects the mask for each channel status described in the previous section.
  $530 constant OTG_FS_HCTSIZ1          \ OTG host channel 1 transfer size register
  $540 constant OTG_FS_HCCHAR2          \ OTG host channel 2 characteristics register
  $548 constant OTG_FS_HCINT2           \ This register indicates the status of a channel with respect to USB- and AHB-related events. It is shown in Figure724. The application must read this register when the host channels interrupt bit in the core interrupt register (HCINT bit in GINTSTS) is set. Before the application can read this register, it must first read the host all channels interrupt (HAINT) register to get the exact channel number for the host channel-x interrupt register. The application must clear the appropriate bit in this register to clear the corresponding bits in the HAINT and GINTSTS registers.
  $54C constant OTG_FS_HCINTMSK2        \ This register reflects the mask for each channel status described in the previous section.
  $550 constant OTG_FS_HCTSIZ2          \ OTG host channel 2 transfer size register
  $560 constant OTG_FS_HCCHAR3          \ OTG host channel 3 characteristics register
  $568 constant OTG_FS_HCINT3           \ This register indicates the status of a channel with respect to USB- and AHB-related events. It is shown in Figure724. The application must read this register when the host channels interrupt bit in the core interrupt register (HCINT bit in GINTSTS) is set. Before the application can read this register, it must first read the host all channels interrupt (HAINT) register to get the exact channel number for the host channel-x interrupt register. The application must clear the appropriate bit in this register to clear the corresponding bits in the HAINT and GINTSTS registers.
  $56C constant OTG_FS_HCINTMSK3        \ This register reflects the mask for each channel status described in the previous section.
  $570 constant OTG_FS_HCTSIZ3          \ OTG host channel 3 transfer size register
  $580 constant OTG_FS_HCCHAR4          \ OTG host channel 4 characteristics register
  $588 constant OTG_FS_HCINT4           \ This register indicates the status of a channel with respect to USB- and AHB-related events. It is shown in Figure724. The application must read this register when the host channels interrupt bit in the core interrupt register (HCINT bit in GINTSTS) is set. Before the application can read this register, it must first read the host all channels interrupt (HAINT) register to get the exact channel number for the host channel-x interrupt register. The application must clear the appropriate bit in this register to clear the corresponding bits in the HAINT and GINTSTS registers.
  $58C constant OTG_FS_HCINTMSK4        \ This register reflects the mask for each channel status described in the previous section.
  $590 constant OTG_FS_HCTSIZ4          \ OTG host channel 4 transfer size register
  $5A0 constant OTG_FS_HCCHAR5          \ OTG host channel 5 characteristics register
  $5A8 constant OTG_FS_HCINT5           \ This register indicates the status of a channel with respect to USB- and AHB-related events. It is shown in Figure724. The application must read this register when the host channels interrupt bit in the core interrupt register (HCINT bit in GINTSTS) is set. Before the application can read this register, it must first read the host all channels interrupt (HAINT) register to get the exact channel number for the host channel-x interrupt register. The application must clear the appropriate bit in this register to clear the corresponding bits in the HAINT and GINTSTS registers.
  $5AC constant OTG_FS_HCINTMSK5        \ This register reflects the mask for each channel status described in the previous section.
  $5B0 constant OTG_FS_HCTSIZ5          \ OTG host channel 5 transfer size register
  $5C0 constant OTG_FS_HCCHAR6          \ OTG host channel 6 characteristics register
  $5C8 constant OTG_FS_HCINT6           \ This register indicates the status of a channel with respect to USB- and AHB-related events. It is shown in Figure724. The application must read this register when the host channels interrupt bit in the core interrupt register (HCINT bit in GINTSTS) is set. Before the application can read this register, it must first read the host all channels interrupt (HAINT) register to get the exact channel number for the host channel-x interrupt register. The application must clear the appropriate bit in this register to clear the corresponding bits in the HAINT and GINTSTS registers.
  $5CC constant OTG_FS_HCINTMSK6        \ This register reflects the mask for each channel status described in the previous section.
  $5D0 constant OTG_FS_HCTSIZ6          \ OTG host channel 6 transfer size register
  $5E0 constant OTG_FS_HCCHAR7          \ OTG host channel 7 characteristics register
  $5E8 constant OTG_FS_HCINT7           \ This register indicates the status of a channel with respect to USB- and AHB-related events. It is shown in Figure724. The application must read this register when the host channels interrupt bit in the core interrupt register (HCINT bit in GINTSTS) is set. Before the application can read this register, it must first read the host all channels interrupt (HAINT) register to get the exact channel number for the host channel-x interrupt register. The application must clear the appropriate bit in this register to clear the corresponding bits in the HAINT and GINTSTS registers.
  $5EC constant OTG_FS_HCINTMSK7        \ This register reflects the mask for each channel status described in the previous section.
  $5F0 constant OTG_FS_HCTSIZ7          \ OTG host channel 7 transfer size register
  $600 constant OTG_FS_HCCHAR8          \ OTG host channel 8 characteristics register
  $608 constant OTG_FS_HCINT8           \ This register indicates the status of a channel with respect to USB- and AHB-related events. It is shown in Figure724. The application must read this register when the host channels interrupt bit in the core interrupt register (HCINT bit in GINTSTS) is set. Before the application can read this register, it must first read the host all channels interrupt (HAINT) register to get the exact channel number for the host channel-x interrupt register. The application must clear the appropriate bit in this register to clear the corresponding bits in the HAINT and GINTSTS registers.
  $60C constant OTG_FS_HCINTMSK8        \ This register reflects the mask for each channel status described in the previous section.
  $610 constant OTG_FS_HCTSIZ8          \ OTG host channel 8 transfer size register
  $620 constant OTG_FS_HCCHAR9          \ OTG host channel 9 characteristics register
  $628 constant OTG_FS_HCINT9           \ This register indicates the status of a channel with respect to USB- and AHB-related events. It is shown in Figure724. The application must read this register when the host channels interrupt bit in the core interrupt register (HCINT bit in GINTSTS) is set. Before the application can read this register, it must first read the host all channels interrupt (HAINT) register to get the exact channel number for the host channel-x interrupt register. The application must clear the appropriate bit in this register to clear the corresponding bits in the HAINT and GINTSTS registers.
  $62C constant OTG_FS_HCINTMSK9        \ This register reflects the mask for each channel status described in the previous section.
  $630 constant OTG_FS_HCTSIZ9          \ OTG host channel 9 transfer size register
  $640 constant OTG_FS_HCCHAR10         \ OTG host channel 10 characteristics register
  $648 constant OTG_FS_HCINT10          \ This register indicates the status of a channel with respect to USB- and AHB-related events. It is shown in Figure724. The application must read this register when the host channels interrupt bit in the core interrupt register (HCINT bit in GINTSTS) is set. Before the application can read this register, it must first read the host all channels interrupt (HAINT) register to get the exact channel number for the host channel-x interrupt register. The application must clear the appropriate bit in this register to clear the corresponding bits in the HAINT and GINTSTS registers.
  $64C constant OTG_FS_HCINTMSK10       \ This register reflects the mask for each channel status described in the previous section.
  $650 constant OTG_FS_HCTSIZ10         \ OTG host channel 10 transfer size register
  $660 constant OTG_FS_HCCHAR11         \ OTG host channel 11 characteristics register
  $668 constant OTG_FS_HCINT11          \ This register indicates the status of a channel with respect to USB- and AHB-related events. It is shown in Figure724. The application must read this register when the host channels interrupt bit in the core interrupt register (HCINT bit in GINTSTS) is set. Before the application can read this register, it must first read the host all channels interrupt (HAINT) register to get the exact channel number for the host channel-x interrupt register. The application must clear the appropriate bit in this register to clear the corresponding bits in the HAINT and GINTSTS registers.
  $66C constant OTG_FS_HCINTMSK11       \ This register reflects the mask for each channel status described in the previous section.
  $670 constant OTG_FS_HCTSIZ11         \ OTG host channel 11 transfer size register
  $800 constant OTG_FS_DCFG             \ This register configures the core in device mode after power-on or after certain control commands or enumeration. Do not make changes to this register after initial programming.
  $804 constant OTG_FS_DCTL             \ OTG device control register
  $808 constant OTG_FS_DSTS             \ This register indicates the status of the core with respect to USB-related events. It must be read on interrupts from the device all interrupts (DAINT) register.
  $810 constant OTG_FS_DIEPMSK          \ This register works with each of the DIEPINTx registers for all endpoints to generate an interrupt per IN endpoint. The IN endpoint interrupt for a specific status in the DIEPINTx register can be masked by writing to the corresponding bit in this register. Status bits are masked by default.
  $814 constant OTG_FS_DOEPMSK          \ This register works with each of the DOEPINTx registers for all endpoints to generate an interrupt per OUT endpoint. The OUT endpoint interrupt for a specific status in the DOEPINTx register can be masked by writing into the corresponding bit in this register. Status bits are masked by default.
  $818 constant OTG_FS_DAINT            \ When a significant event occurs on an endpoint, a DAINT register interrupts the application using the device OUT endpoints interrupt bit or device IN endpoints interrupt bit of the GINTSTS register (OEPINT or IEPINT in GINTSTS, respectively). There is one interrupt bit per endpoint, up to a maximum of 16 bits for OUT endpoints and 16 bits for IN endpoints. For a bidirectional endpoint, the corresponding IN and OUT interrupt bits are used. Bits in this register are set and cleared when the application sets and clears bits in the corresponding device endpoint-x interrupt register (DIEPINTx/DOEPINTx).
  $81C constant OTG_FS_DAINTMSK         \ The DAINTMSK register works with the device endpoint interrupt register to interrupt the application when an event occurs on a device endpoint. However, the DAINT register bit corresponding to that interrupt is still set.
  $828 constant OTG_FS_DVBUSDIS         \ This register specifies the VBUS discharge time after VBUS pulsing during SRP.
  $82C constant OTG_FS_DVBUSPULSE       \ This register specifies the VBUS pulsing time during SRP.
  $834 constant OTG_FS_DIEPEMPMSK       \ This register is used to control the IN endpoint FIFO empty interrupt generation (TXFE_DIEPINTx).
  $900 constant OTG_FS_DIEPCTL0         \ The application uses this register to control the behavior of each logical endpoint other than endpoint 0.
  $908 constant OTG_FS_DIEPINT0         \ This register indicates the status of an endpoint with respect to USB- and AHB-related events. It is shown in Figure724. The application must read this register when the IN endpoints interrupt bit of the core interrupt register (IEPINT in GINTSTS) is set. Before the application can read this register, it must first read the device all endpoints interrupt (DAINT) register to get the exact endpoint number for the device endpoint-x interrupt register. The application must clear the appropriate bit in this register to clear the corresponding bits in the DAINT and GINTSTS registers.
  $910 constant OTG_FS_DIEPTSIZ0        \ The application must modify this register before enabling endpoint 0.
  $918 constant OTG_FS_DTXFSTS0         \ This read-only register contains the free space information for the device IN endpoint Tx FIFO.
  $920 constant OTG_FS_DIEPCTL1         \ The application uses this register to control the behavior of each logical endpoint other than endpoint 0.
  $928 constant OTG_FS_DIEPINT1         \ This register indicates the status of an endpoint with respect to USB- and AHB-related events. It is shown in Figure724. The application must read this register when the IN endpoints interrupt bit of the core interrupt register (IEPINT in GINTSTS) is set. Before the application can read this register, it must first read the device all endpoints interrupt (DAINT) register to get the exact endpoint number for the device endpoint-x interrupt register. The application must clear the appropriate bit in this register to clear the corresponding bits in the DAINT and GINTSTS registers.
  $930 constant OTG_FS_DIEPTSIZ1        \ The application must modify this register before enabling the endpoint. Once the endpoint is enabled using the endpoint enable bit in the DIEPCTLx registers (EPENA bit in DIEPCTLx), the core modifies this register. The application can only read this register once the core has cleared the endpoint enable bit.
  $938 constant OTG_FS_DTXFSTS1         \ This read-only register contains the free space information for the device IN endpoint Tx FIFO.
  $940 constant OTG_FS_DIEPCTL2         \ The application uses this register to control the behavior of each logical endpoint other than endpoint 0.
  $948 constant OTG_FS_DIEPINT2         \ This register indicates the status of an endpoint with respect to USB- and AHB-related events. It is shown in Figure724. The application must read this register when the IN endpoints interrupt bit of the core interrupt register (IEPINT in GINTSTS) is set. Before the application can read this register, it must first read the device all endpoints interrupt (DAINT) register to get the exact endpoint number for the device endpoint-x interrupt register. The application must clear the appropriate bit in this register to clear the corresponding bits in the DAINT and GINTSTS registers.
  $950 constant OTG_FS_DIEPTSIZ2        \ The application must modify this register before enabling the endpoint. Once the endpoint is enabled using the endpoint enable bit in the DIEPCTLx registers (EPENA bit in DIEPCTLx), the core modifies this register. The application can only read this register once the core has cleared the endpoint enable bit.
  $958 constant OTG_FS_DTXFSTS2         \ This read-only register contains the free space information for the device IN endpoint Tx FIFO.
  $960 constant OTG_FS_DIEPCTL3         \ The application uses this register to control the behavior of each logical endpoint other than endpoint 0.
  $968 constant OTG_FS_DIEPINT3         \ This register indicates the status of an endpoint with respect to USB- and AHB-related events. It is shown in Figure724. The application must read this register when the IN endpoints interrupt bit of the core interrupt register (IEPINT in GINTSTS) is set. Before the application can read this register, it must first read the device all endpoints interrupt (DAINT) register to get the exact endpoint number for the device endpoint-x interrupt register. The application must clear the appropriate bit in this register to clear the corresponding bits in the DAINT and GINTSTS registers.
  $970 constant OTG_FS_DIEPTSIZ3        \ The application must modify this register before enabling the endpoint. Once the endpoint is enabled using the endpoint enable bit in the DIEPCTLx registers (EPENA bit in DIEPCTLx), the core modifies this register. The application can only read this register once the core has cleared the endpoint enable bit.
  $978 constant OTG_FS_DTXFSTS3         \ This read-only register contains the free space information for the device IN endpoint Tx FIFO.
  $980 constant OTG_FS_DIEPCTL4         \ The application uses this register to control the behavior of each logical endpoint other than endpoint 0.
  $988 constant OTG_FS_DIEPINT4         \ This register indicates the status of an endpoint with respect to USB- and AHB-related events. It is shown in Figure724. The application must read this register when the IN endpoints interrupt bit of the core interrupt register (IEPINT in GINTSTS) is set. Before the application can read this register, it must first read the device all endpoints interrupt (DAINT) register to get the exact endpoint number for the device endpoint-x interrupt register. The application must clear the appropriate bit in this register to clear the corresponding bits in the DAINT and GINTSTS registers.
  $990 constant OTG_FS_DIEPTSIZ4        \ The application must modify this register before enabling the endpoint. Once the endpoint is enabled using the endpoint enable bit in the DIEPCTLx registers (EPENA bit in DIEPCTLx), the core modifies this register. The application can only read this register once the core has cleared the endpoint enable bit.
  $998 constant OTG_FS_DTXFSTS4         \ This read-only register contains the free space information for the device IN endpoint Tx FIFO.
  $9A0 constant OTG_FS_DIEPCTL5         \ The application uses this register to control the behavior of each logical endpoint other than endpoint 0.
  $9A8 constant OTG_FS_DIEPINT5         \ This register indicates the status of an endpoint with respect to USB- and AHB-related events. It is shown in Figure724. The application must read this register when the IN endpoints interrupt bit of the core interrupt register (IEPINT in GINTSTS) is set. Before the application can read this register, it must first read the device all endpoints interrupt (DAINT) register to get the exact endpoint number for the device endpoint-x interrupt register. The application must clear the appropriate bit in this register to clear the corresponding bits in the DAINT and GINTSTS registers.
  $9B0 constant OTG_FS_DIEPTSIZ5        \ The application must modify this register before enabling the endpoint. Once the endpoint is enabled using the endpoint enable bit in the DIEPCTLx registers (EPENA bit in DIEPCTLx), the core modifies this register. The application can only read this register once the core has cleared the endpoint enable bit.
  $9B8 constant OTG_FS_DTXFSTS5         \ This read-only register contains the free space information for the device IN endpoint Tx FIFO.
  $B00 constant OTG_FS_DOEPCTL0         \ This section describes the DOEPCTL0 register.
  $B08 constant OTG_FS_DOEPINT0         \ This register indicates the status of an endpoint with respect to USB- and AHB-related events. It is shown in Figure724. The application must read this register when the OUT endpoints interrupt bit of the GINTSTS register (OEPINT bit in GINTSTS) is set. Before the application can read this register, it must first read the DAINT register to get the exact endpoint number for the DOEPINTx register. The application must clear the appropriate bit in this register to clear the corresponding bits in the DAINT and GINTSTS registers.
  $B10 constant OTG_FS_DOEPTSIZ0        \ The application must modify this register before enabling endpoint 0.
  $B20 constant OTG_FS_DOEPCTL1         \ The application uses this register to control the behavior of each logical endpoint other than endpoint 0.
  $B28 constant OTG_FS_DOEPINT1         \ This register indicates the status of an endpoint with respect to USB- and AHB-related events. It is shown in Figure724. The application must read this register when the OUT endpoints interrupt bit of the GINTSTS register (OEPINT bit in GINTSTS) is set. Before the application can read this register, it must first read the DAINT register to get the exact endpoint number for the DOEPINTx register. The application must clear the appropriate bit in this register to clear the corresponding bits in the DAINT and GINTSTS registers.
  $B30 constant OTG_FS_DOEPTSIZ1        \ The application must modify this register before enabling the endpoint. Once the endpoint is enabled using endpoint enable bit of the DOEPCTLx registers (EPENA bit in DOEPCTLx), the core modifies this register. The application can only read this register once the core has cleared the endpoint enable bit.
  $B40 constant OTG_FS_DOEPCTL2         \ The application uses this register to control the behavior of each logical endpoint other than endpoint 0.
  $B48 constant OTG_FS_DOEPINT2         \ This register indicates the status of an endpoint with respect to USB- and AHB-related events. It is shown in Figure724. The application must read this register when the OUT endpoints interrupt bit of the GINTSTS register (OEPINT bit in GINTSTS) is set. Before the application can read this register, it must first read the DAINT register to get the exact endpoint number for the DOEPINTx register. The application must clear the appropriate bit in this register to clear the corresponding bits in the DAINT and GINTSTS registers.
  $B50 constant OTG_FS_DOEPTSIZ2        \ The application must modify this register before enabling the endpoint. Once the endpoint is enabled using endpoint enable bit of the DOEPCTLx registers (EPENA bit in DOEPCTLx), the core modifies this register. The application can only read this register once the core has cleared the endpoint enable bit.
  $B60 constant OTG_FS_DOEPCTL3         \ The application uses this register to control the behavior of each logical endpoint other than endpoint 0.
  $B68 constant OTG_FS_DOEPINT3         \ This register indicates the status of an endpoint with respect to USB- and AHB-related events. It is shown in Figure724. The application must read this register when the OUT endpoints interrupt bit of the GINTSTS register (OEPINT bit in GINTSTS) is set. Before the application can read this register, it must first read the DAINT register to get the exact endpoint number for the DOEPINTx register. The application must clear the appropriate bit in this register to clear the corresponding bits in the DAINT and GINTSTS registers.
  $B70 constant OTG_FS_DOEPTSIZ3        \ The application must modify this register before enabling the endpoint. Once the endpoint is enabled using endpoint enable bit of the DOEPCTLx registers (EPENA bit in DOEPCTLx), the core modifies this register. The application can only read this register once the core has cleared the endpoint enable bit.
  $B80 constant OTG_FS_DOEPCTL4         \ The application uses this register to control the behavior of each logical endpoint other than endpoint 0.
  $B88 constant OTG_FS_DOEPINT4         \ This register indicates the status of an endpoint with respect to USB- and AHB-related events. It is shown in Figure724. The application must read this register when the OUT endpoints interrupt bit of the GINTSTS register (OEPINT bit in GINTSTS) is set. Before the application can read this register, it must first read the DAINT register to get the exact endpoint number for the DOEPINTx register. The application must clear the appropriate bit in this register to clear the corresponding bits in the DAINT and GINTSTS registers.
  $B90 constant OTG_FS_DOEPTSIZ4        \ The application must modify this register before enabling the endpoint. Once the endpoint is enabled using endpoint enable bit of the DOEPCTLx registers (EPENA bit in DOEPCTLx), the core modifies this register. The application can only read this register once the core has cleared the endpoint enable bit.
  $BA0 constant OTG_FS_DOEPCTL5         \ The application uses this register to control the behavior of each logical endpoint other than endpoint 0.
  $BA8 constant OTG_FS_DOEPINT5         \ This register indicates the status of an endpoint with respect to USB- and AHB-related events. It is shown in Figure724. The application must read this register when the OUT endpoints interrupt bit of the GINTSTS register (OEPINT bit in GINTSTS) is set. Before the application can read this register, it must first read the DAINT register to get the exact endpoint number for the DOEPINTx register. The application must clear the appropriate bit in this register to clear the corresponding bits in the DAINT and GINTSTS registers.
  $BB0 constant OTG_FS_DOEPTSIZ5        \ The application must modify this register before enabling the endpoint. Once the endpoint is enabled using endpoint enable bit of the DOEPCTLx registers (EPENA bit in DOEPCTLx), the core modifies this register. The application can only read this register once the core has cleared the endpoint enable bit.
  $E00 constant OTG_FS_PCGCCTL          \ This register is available in host and device modes.

: OTG_FS_DEF ; [then]
