\
\ @file otg_hs.fs
\ @brief OTG_HS
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] OTG_HS_DEF

  [ifdef] OTG_HS_GOTGCTL_DEF
    \
    \ @brief The GOTGCTL register controls the behavior and reflects the status of the OTG function of the core.
    \ Address offset: 0x00
    \ Reset value: 0x00010000
    \
    $00 constant OTG_HS_SRQSCS                  \ [0x00] SRQSCS
    $01 constant OTG_HS_SRQ                     \ [0x01] SRQ
    $02 constant OTG_HS_VBVALOEN                \ [0x02] VBVALOEN
    $03 constant OTG_HS_VBVALOVAL               \ [0x03] VBVALOVAL
    $04 constant OTG_HS_AVALOEN                 \ [0x04] AVALOEN
    $05 constant OTG_HS_AVALOVAL                \ [0x05] AVALOVAL
    $06 constant OTG_HS_BVALOEN                 \ [0x06] BVALOEN
    $07 constant OTG_HS_BVALOVAL                \ [0x07] BVALOVAL
    $08 constant OTG_HS_HNGSCS                  \ [0x08] HNGSCS
    $09 constant OTG_HS_HNPRQ                   \ [0x09] HNPRQ
    $0a constant OTG_HS_HSHNPEN                 \ [0x0a] HSHNPEN
    $0b constant OTG_HS_DHNPEN                  \ [0x0b] DHNPEN
    $0c constant OTG_HS_EHEN                    \ [0x0c] EHEN
    $10 constant OTG_HS_CIDSTS                  \ [0x10] CIDSTS
    $11 constant OTG_HS_DBCT                    \ [0x11] DBCT
    $12 constant OTG_HS_ASVLD                   \ [0x12] ASVLD
    $13 constant OTG_HS_BSVLD                   \ [0x13] BSVLD
    $14 constant OTG_HS_OTGVER                  \ [0x14] OTGVER
    $15 constant OTG_HS_CURMOD                  \ [0x15] CURMOD
  [then]


  [ifdef] OTG_HS_GOTGINT_DEF
    \
    \ @brief The application reads this register whenever there is an OTG interrupt and clears the bits in this register to clear the OTG interrupt.
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $02 constant OTG_HS_SEDET                   \ [0x02] SEDET
    $08 constant OTG_HS_SRSSCHG                 \ [0x08] SRSSCHG
    $09 constant OTG_HS_HNSSCHG                 \ [0x09] HNSSCHG
    $11 constant OTG_HS_HNGDET                  \ [0x11] HNGDET
    $12 constant OTG_HS_ADTOCHG                 \ [0x12] ADTOCHG
    $13 constant OTG_HS_DBCDNE                  \ [0x13] DBCDNE
  [then]


  [ifdef] OTG_HS_GAHBCFG_DEF
    \
    \ @brief This register can be used to configure the core after power-on or a change in mode. This register mainly contains AHB system-related configuration parameters. Do not change this register after the initial programming. The application must program this register before starting any transactions on either the AHB or the USB.
    \ Address offset: 0x08
    \ Reset value: 0x00000000
    \
    $00 constant OTG_HS_GINTMSK                 \ [0x00] GINTMSK
    $07 constant OTG_HS_TXFELVL                 \ [0x07] TXFELVL
    $08 constant OTG_HS_PTXFELVL                \ [0x08] PTXFELVL
  [then]


  [ifdef] OTG_HS_GUSBCFG_DEF
    \
    \ @brief This register can be used to configure the core after power-on or a changing to host mode or device mode. It contains USB and USB-PHY related configuration parameters. The application must program this register before starting any transactions on either the AHB or the USB. Do not make changes to this register after the initial programming.
    \ Address offset: 0x0C
    \ Reset value: 0x00001400
    \
    $00 constant OTG_HS_TOCAL                   \ [0x00 : 3] TOCAL
    $06 constant OTG_HS_PHYSEL                  \ [0x06] PHYSEL
    $08 constant OTG_HS_SRPCAP                  \ [0x08] SRPCAP
    $09 constant OTG_HS_HNPCAP                  \ [0x09] HNPCAP
    $0a constant OTG_HS_TRDT                    \ [0x0a : 4] TRDT
    $0f constant OTG_HS_PHYLPC                  \ [0x0f] PHYLPC
    $16 constant OTG_HS_TSDPS                   \ [0x16] TSDPS
    $1d constant OTG_HS_FHMOD                   \ [0x1d] FHMOD
    $1e constant OTG_HS_FDMOD                   \ [0x1e] FDMOD
  [then]


  [ifdef] OTG_HS_GRSTCTL_DEF
    \
    \ @brief The application uses this register to reset various hardware features inside the core.
    \ Address offset: 0x10
    \ Reset value: 0x80000000
    \
    $00 constant OTG_HS_CSRST                   \ [0x00] CSRST
    $01 constant OTG_HS_PSRST                   \ [0x01] PSRST
    $02 constant OTG_HS_FSRST                   \ [0x02] FSRST
    $04 constant OTG_HS_RXFFLSH                 \ [0x04] RXFFLSH
    $05 constant OTG_HS_TXFFLSH                 \ [0x05] TXFFLSH
    $06 constant OTG_HS_TXFNUM                  \ [0x06 : 5] TXFNUM
    $1e constant OTG_HS_DMAREQ                  \ [0x1e] DMAREQ
    $1f constant OTG_HS_AHBIDL                  \ [0x1f] AHBIDL
  [then]


  [ifdef] OTG_HS_GINTSTS_DEF
    \
    \ @brief This register interrupts the application for system-level events in the current mode (device mode or host mode). Some of the bits in this register are valid only in host mode, while others are valid in device mode only. This register also indicates the current mode. To clear the interrupt status bits of the rc_w1 type, the application must write 1 into the bit. The FIFO status interrupts are read-only; once software reads from or writes to the FIFO while servicing these interrupts, FIFO interrupt conditions are cleared automatically. The application must clear the GINTSTS register at initialization before unmasking the interrupt bit to avoid any interrupts generated prior to initialization.
    \ Address offset: 0x14
    \ Reset value: 0x04000020
    \
    $00 constant OTG_HS_CMOD                    \ [0x00] CMOD
    $01 constant OTG_HS_MMIS                    \ [0x01] MMIS
    $02 constant OTG_HS_OTGINT                  \ [0x02] OTGINT
    $03 constant OTG_HS_SOF                     \ [0x03] SOF
    $04 constant OTG_HS_RXFLVL                  \ [0x04] RXFLVL
    $05 constant OTG_HS_NPTXFE                  \ [0x05] NPTXFE
    $06 constant OTG_HS_GINAKEFF                \ [0x06] GINAKEFF
    $07 constant OTG_HS_GONAKEFF                \ [0x07] GONAKEFF
    $0a constant OTG_HS_ESUSP                   \ [0x0a] ESUSP
    $0b constant OTG_HS_USBSUSP                 \ [0x0b] USBSUSP
    $0c constant OTG_HS_USBRST                  \ [0x0c] USBRST
    $0d constant OTG_HS_ENUMDNE                 \ [0x0d] ENUMDNE
    $0e constant OTG_HS_ISOODRP                 \ [0x0e] ISOODRP
    $0f constant OTG_HS_EOPF                    \ [0x0f] EOPF
    $12 constant OTG_HS_IEPINT                  \ [0x12] IEPINT
    $13 constant OTG_HS_OEPINT                  \ [0x13] OEPINT
    $14 constant OTG_HS_IISOIXFR                \ [0x14] IISOIXFR
    $15 constant OTG_HS_IPXFR                   \ [0x15] IPXFR
    $16 constant OTG_HS_DATAFSUSP               \ [0x16] DATAFSUSP
    $17 constant OTG_HS_RSTDET                  \ [0x17] RSTDET
    $18 constant OTG_HS_HPRTINT                 \ [0x18] HPRTINT
    $19 constant OTG_HS_HCINT                   \ [0x19] HCINT
    $1a constant OTG_HS_PTXFE                   \ [0x1a] PTXFE
    $1b constant OTG_HS_LPMINT                  \ [0x1b] LPMINT
    $1c constant OTG_HS_CIDSCHG                 \ [0x1c] CIDSCHG
    $1d constant OTG_HS_DISCINT                 \ [0x1d] DISCINT
    $1e constant OTG_HS_SRQINT                  \ [0x1e] SRQINT
    $1f constant OTG_HS_WKUPINT                 \ [0x1f] WKUPINT
  [then]


  [ifdef] OTG_HS_GINTMSK_DEF
    \
    \ @brief This register works with the core interrupt register to interrupt the application. When an interrupt bit is masked, the interrupt associated with that bit is not generated. However, the core interrupt (GINTSTS) register bit corresponding to that interrupt is still set.
    \ Address offset: 0x18
    \ Reset value: 0x00000000
    \
    $01 constant OTG_HS_MMISM                   \ [0x01] MMISM
    $02 constant OTG_HS_OTGINT                  \ [0x02] OTGINT
    $03 constant OTG_HS_SOFM                    \ [0x03] SOFM
    $04 constant OTG_HS_RXFLVLM                 \ [0x04] RXFLVLM
    $05 constant OTG_HS_NPTXFEM                 \ [0x05] NPTXFEM
    $06 constant OTG_HS_GINAKEFFM               \ [0x06] GINAKEFFM
    $07 constant OTG_HS_GONAKEFFM               \ [0x07] GONAKEFFM
    $0a constant OTG_HS_ESUSPM                  \ [0x0a] ESUSPM
    $0b constant OTG_HS_USBSUSPM                \ [0x0b] USBSUSPM
    $0c constant OTG_HS_USBRST                  \ [0x0c] USBRST
    $0d constant OTG_HS_ENUMDNEM                \ [0x0d] ENUMDNEM
    $0e constant OTG_HS_ISOODRPM                \ [0x0e] ISOODRPM
    $0f constant OTG_HS_EOPFM                   \ [0x0f] EOPFM
    $12 constant OTG_HS_IEPINT                  \ [0x12] IEPINT
    $13 constant OTG_HS_OEPINT                  \ [0x13] OEPINT
    $14 constant OTG_HS_IISOIXFRM               \ [0x14] IISOIXFRM
    $15 constant OTG_HS_IPXFRM                  \ [0x15] IPXFRM
    $16 constant OTG_HS_FSUSPM                  \ [0x16] FSUSPM
    $17 constant OTG_HS_RSTDETM                 \ [0x17] RSTDETM
    $18 constant OTG_HS_PRTIM                   \ [0x18] PRTIM
    $19 constant OTG_HS_HCIM                    \ [0x19] HCIM
    $1a constant OTG_HS_PTXFEM                  \ [0x1a] PTXFEM
    $1b constant OTG_HS_LPMINTM                 \ [0x1b] LPMINTM
    $1c constant OTG_HS_CIDSCHGM                \ [0x1c] CIDSCHGM
    $1d constant OTG_HS_DISCINT                 \ [0x1d] DISCINT
    $1e constant OTG_HS_SRQIM                   \ [0x1e] SRQIM
    $1f constant OTG_HS_WUIM                    \ [0x1f] WUIM
  [then]


  [ifdef] OTG_HS_GRXSTSR_DEVICE_DEF
    \
    \ @brief This description is for register GRXSTSR in Device mode. A read to the receive status debug read register returns the contents of the top of the receive FIFO. The core ignores the receive status read when the receive FIFO is empty and returns a value of 0x00000000.
    \ Address offset: 0x1C
    \ Reset value: 0x00000000
    \
    $00 constant OTG_HS_EPNUM                   \ [0x00 : 4] EPNUM
    $04 constant OTG_HS_BCNT                    \ [0x04 : 11] BCNT
    $0f constant OTG_HS_DPID                    \ [0x0f : 2] DPID
    $11 constant OTG_HS_PKTSTS                  \ [0x11 : 4] PKTSTS
    $15 constant OTG_HS_FRMNUM                  \ [0x15 : 4] FRMNUM
    $1b constant OTG_HS_STSPHST                 \ [0x1b] STSPHST
  [then]


  [ifdef] OTG_HS_GRXSTSR_HOST_DEF
    \
    \ @brief This description is for register GRXSTSR in Host mode
    \ Address offset: 0x1C
    \ Reset value: 0x00000000
    \
    $00 constant OTG_HS_CHNUM                   \ [0x00 : 4] CHNUM
    $04 constant OTG_HS_BCNT                    \ [0x04 : 11] BCNT
    $0f constant OTG_HS_DPID                    \ [0x0f : 2] DPID
    $11 constant OTG_HS_PKTSTS                  \ [0x11 : 4] PKTSTS
  [then]


  [ifdef] OTG_HS_GRXSTSP_DEVICE_DEF
    \
    \ @brief This description is for register GRXSTSP in Device mode. Similarly to GRXSTSR (receive status debug read register) where a read returns the contents of the top of the receive FIFO, a read to GRXSTSP (receive status read and pop register) additionally pops the top data entry out of the Rx FIFO. The core ignores the receive status pop/read when the receive FIFO is empty and returns a value of 0x00000000. The application must only pop the receive status FIFO when the receive FIFO non-empty bit of the core interrupt register (RXFLVL bit in GINTSTS) is asserted.
    \ Address offset: 0x20
    \ Reset value: 0x00000000
    \
    $00 constant OTG_HS_EPNUM                   \ [0x00 : 4] EPNUM
    $04 constant OTG_HS_BCNT                    \ [0x04 : 11] BCNT
    $0f constant OTG_HS_DPID                    \ [0x0f : 2] DPID
    $11 constant OTG_HS_PKTSTS                  \ [0x11 : 4] PKTSTS
    $15 constant OTG_HS_FRMNUM                  \ [0x15 : 4] FRMNUM
    $1b constant OTG_HS_STSPHST                 \ [0x1b] STSPHST
  [then]


  [ifdef] OTG_HS_GRXSTSP_HOST_DEF
    \
    \ @brief This description is for register GRXSTSP in HOST mode
    \ Address offset: 0x20
    \ Reset value: 0x00000000
    \
    $00 constant OTG_HS_CHNUM                   \ [0x00 : 4] CHNUM
    $04 constant OTG_HS_BCNT                    \ [0x04 : 11] BCNT
    $0f constant OTG_HS_DPID                    \ [0x0f : 2] DPID
    $11 constant OTG_HS_PKTSTS                  \ [0x11 : 4] PKTSTS
  [then]


  [ifdef] OTG_HS_GRXFSIZ_DEF
    \
    \ @brief The application can program the RAM size that must be allocated to the Rx FIFO.
    \ Address offset: 0x24
    \ Reset value: 0x00000400
    \
    $00 constant OTG_HS_RXFD                    \ [0x00 : 16] RXFD
  [then]


  [ifdef] OTG_HS_HNPTXFSIZ_DEF
    \
    \ @brief Host mode
    \ Address offset: 0x28
    \ Reset value: 0x02000200
    \
    $00 constant OTG_HS_NPTXFSA                 \ [0x00 : 16] NPTXFSA
    $10 constant OTG_HS_NPTXFD                  \ [0x10 : 16] NPTXFD
  [then]


  [ifdef] OTG_HS_HNPTXSTS_DEF
    \
    \ @brief In device mode, this register is not valid. This read-only register contains the free space information for the non-periodic Tx FIFO and the non-periodic transmit request queue.
    \ Address offset: 0x2C
    \ Reset value: 0x00080400
    \
    $00 constant OTG_HS_NPTXFSAV                \ [0x00 : 16] NPTXFSAV
    $10 constant OTG_HS_NPTQXSAV                \ [0x10 : 8] NPTQXSAV
    $18 constant OTG_HS_NPTXQTOP                \ [0x18 : 7] NPTXQTOP
  [then]


  [ifdef] OTG_HS_GCCFG_DEF
    \
    \ @brief OTG general core configuration register
    \ Address offset: 0x38
    \ Reset value: 0x00000000
    \
    $00 constant OTG_HS_DCDET                   \ [0x00] DCDET
    $01 constant OTG_HS_PDET                    \ [0x01] PDET
    $02 constant OTG_HS_SDET                    \ [0x02] SDET
    $03 constant OTG_HS_PS2DET                  \ [0x03] PS2DET
    $10 constant OTG_HS_PWRDWN                  \ [0x10] PWRDWN
    $11 constant OTG_HS_BCDEN                   \ [0x11] BCDEN
    $12 constant OTG_HS_DCDEN                   \ [0x12] DCDEN
    $13 constant OTG_HS_PDEN                    \ [0x13] PDEN
    $14 constant OTG_HS_SDEN                    \ [0x14] SDEN
    $15 constant OTG_HS_VBDEN                   \ [0x15] VBDEN
  [then]


  [ifdef] OTG_HS_CID_DEF
    \
    \ @brief This is a register containing the Product ID as reset value.
    \ Address offset: 0x3C
    \ Reset value: 0x00003100
    \
    $00 constant OTG_HS_PRODUCT_ID              \ [0x00 : 32] PRODUCT_ID
  [then]


  [ifdef] OTG_HS_GLPMCFG_DEF
    \
    \ @brief OTG core LPM configuration register
    \ Address offset: 0x54
    \ Reset value: 0x00000000
    \
    $00 constant OTG_HS_LPMEN                   \ [0x00] LPMEN
    $01 constant OTG_HS_LPMACK                  \ [0x01] LPMACK
    $02 constant OTG_HS_BESL                    \ [0x02 : 4] BESL
    $06 constant OTG_HS_REMWAKE                 \ [0x06] REMWAKE
    $07 constant OTG_HS_L1SSEN                  \ [0x07] L1SSEN
    $08 constant OTG_HS_BESLTHRS                \ [0x08 : 4] BESLTHRS
    $0c constant OTG_HS_L1DSEN                  \ [0x0c] L1DSEN
    $0d constant OTG_HS_LPMRSP                  \ [0x0d : 2] LPMRSP
    $0f constant OTG_HS_SLPSTS                  \ [0x0f] SLPSTS
    $10 constant OTG_HS_L1RSMOK                 \ [0x10] L1RSMOK
    $11 constant OTG_HS_LPMCHIDX                \ [0x11 : 4] LPMCHIDX
    $15 constant OTG_HS_LPMRCNT                 \ [0x15 : 3] LPMRCNT
    $18 constant OTG_HS_SNDLPM                  \ [0x18] SNDLPM
    $19 constant OTG_HS_LPMRCNTSTS              \ [0x19 : 3] LPMRCNTSTS
    $1c constant OTG_HS_ENBESL                  \ [0x1c] ENBESL
  [then]


  [ifdef] OTG_HS_HPTXFSIZ_DEF
    \
    \ @brief OTG host periodic transmit FIFO size register
    \ Address offset: 0x100
    \ Reset value: 0x02000800
    \
    $00 constant OTG_HS_PTXSA                   \ [0x00 : 16] PTXSA
    $10 constant OTG_HS_PTXFSIZ                 \ [0x10 : 16] PTXFSIZ
  [then]


  [ifdef] OTG_HS_DIEPTXF1_DEF
    \
    \ @brief OTG device IN endpoint transmit FIFO 1 size register
    \ Address offset: 0x104
    \ Reset value: 0x02000400
    \
    $00 constant OTG_HS_INEPTXSA                \ [0x00 : 16] INEPTXSA
    $10 constant OTG_HS_INEPTXFD                \ [0x10 : 16] INEPTXFD
  [then]


  [ifdef] OTG_HS_DIEPTXF2_DEF
    \
    \ @brief OTG device IN endpoint transmit FIFO 2 size register
    \ Address offset: 0x108
    \ Reset value: 0x02000600
    \
    $00 constant OTG_HS_INEPTXSA                \ [0x00 : 16] INEPTXSA
    $10 constant OTG_HS_INEPTXFD                \ [0x10 : 16] INEPTXFD
  [then]


  [ifdef] OTG_HS_DIEPTXF3_DEF
    \
    \ @brief OTG device IN endpoint transmit FIFO 3 size register
    \ Address offset: 0x10C
    \ Reset value: 0x02000800
    \
    $00 constant OTG_HS_INEPTXSA                \ [0x00 : 16] INEPTXSA
    $10 constant OTG_HS_INEPTXFD                \ [0x10 : 16] INEPTXFD
  [then]


  [ifdef] OTG_HS_DIEPTXF4_DEF
    \
    \ @brief OTG device IN endpoint transmit FIFO 4 size register
    \ Address offset: 0x110
    \ Reset value: 0x02000A00
    \
    $00 constant OTG_HS_INEPTXSA                \ [0x00 : 16] INEPTXSA
    $10 constant OTG_HS_INEPTXFD                \ [0x10 : 16] INEPTXFD
  [then]


  [ifdef] OTG_HS_DIEPTXF5_DEF
    \
    \ @brief OTG device IN endpoint transmit FIFO 5 size register
    \ Address offset: 0x114
    \ Reset value: 0x02000C00
    \
    $00 constant OTG_HS_INEPTXSA                \ [0x00 : 16] INEPTXSA
    $10 constant OTG_HS_INEPTXFD                \ [0x10 : 16] INEPTXFD
  [then]


  [ifdef] OTG_HS_DIEPTXF6_DEF
    \
    \ @brief OTG device IN endpoint transmit FIFO 6 size register
    \ Address offset: 0x118
    \ Reset value: 0x02000E00
    \
    $00 constant OTG_HS_INEPTXSA                \ [0x00 : 16] INEPTXSA
    $10 constant OTG_HS_INEPTXFD                \ [0x10 : 16] INEPTXFD
  [then]


  [ifdef] OTG_HS_DIEPTXF7_DEF
    \
    \ @brief OTG device IN endpoint transmit FIFO 7 size register
    \ Address offset: 0x11C
    \ Reset value: 0x02001000
    \
    $00 constant OTG_HS_INEPTXSA                \ [0x00 : 16] INEPTXSA
    $10 constant OTG_HS_INEPTXFD                \ [0x10 : 16] INEPTXFD
  [then]


  [ifdef] OTG_HS_DIEPTXF8_DEF
    \
    \ @brief OTG device IN endpoint transmit FIFO 8 size register
    \ Address offset: 0x120
    \ Reset value: 0x02001200
    \
    $00 constant OTG_HS_INEPTXSA                \ [0x00 : 16] INEPTXSA
    $10 constant OTG_HS_INEPTXFD                \ [0x10 : 16] INEPTXFD
  [then]


  [ifdef] OTG_HS_HCFG_DEF
    \
    \ @brief This register configures the core after power-on. Do not make changes to this register after initializing the host.
    \ Address offset: 0x400
    \ Reset value: 0x00000000
    \
    $00 constant OTG_HS_FSLSPCS                 \ [0x00 : 2] FSLSPCS
    $02 constant OTG_HS_FSLSS                   \ [0x02] FSLSS
  [then]


  [ifdef] OTG_HS_HFIR_DEF
    \
    \ @brief This register stores the frame interval information for the current speed to which the OTG controller has enumerated.
    \ Address offset: 0x404
    \ Reset value: 0x0000EA60
    \
    $00 constant OTG_HS_FRIVL                   \ [0x00 : 16] FRIVL
    $10 constant OTG_HS_RLDCTRL                 \ [0x10] RLDCTRL
  [then]


  [ifdef] OTG_HS_HFNUM_DEF
    \
    \ @brief This register indicates the current frame number. It also indicates the time remaining (in terms of the number of PHY clocks) in the current frame.
    \ Address offset: 0x408
    \ Reset value: 0x00003FFF
    \
    $00 constant OTG_HS_FRNUM                   \ [0x00 : 16] FRNUM
    $10 constant OTG_HS_FTREM                   \ [0x10 : 16] FTREM
  [then]


  [ifdef] OTG_HS_HPTXSTS_DEF
    \
    \ @brief This read-only register contains the free space information for the periodic Tx FIFO and the periodic transmit request queue.
    \ Address offset: 0x410
    \ Reset value: 0x00080100
    \
    $00 constant OTG_HS_PTXFSAVL                \ [0x00 : 16] PTXFSAVL
    $10 constant OTG_HS_PTXQSAV                 \ [0x10 : 8] PTXQSAV
    $18 constant OTG_HS_PTXQTOP                 \ [0x18 : 8] PTXQTOP
  [then]


  [ifdef] OTG_HS_HAINT_DEF
    \
    \ @brief When a significant event occurs on a channel, the host all channels interrupt register interrupts the application using the host channels interrupt bit of the core interrupt register (HCINT bit in GINTSTS). This is shown in Figure724. There is one interrupt bit per channel, up to a maximum of 16 bits. Bits in this register are set and cleared when the application sets and clears bits in the corresponding host channel-x interrupt register.
    \ Address offset: 0x414
    \ Reset value: 0x00000000
    \
    $00 constant OTG_HS_HAINT                   \ [0x00 : 16] HAINT
  [then]


  [ifdef] OTG_HS_HAINTMSK_DEF
    \
    \ @brief The host all channel interrupt mask register works with the host all channel interrupt register to interrupt the application when an event occurs on a channel. There is one interrupt mask bit per channel, up to a maximum of 16 bits.
    \ Address offset: 0x418
    \ Reset value: 0x00000000
    \
    $00 constant OTG_HS_HAINTM                  \ [0x00 : 16] HAINTM
  [then]


  [ifdef] OTG_HS_HPRT_DEF
    \
    \ @brief This register is available only in host mode. Currently, the OTG host supports only one port. A single register holds USB port-related information such as USB reset, enable, suspend, resume, connect status, and test mode for each port. It is shown in Figure724. The rc_w1 bits in this register can trigger an interrupt to the application through the host port interrupt bit of the core interrupt register (HPRTINT bit in GINTSTS). On a port interrupt, the application must read this register and clear the bit that caused the interrupt. For the rc_w1 bits, the application must write a 1 to the bit to clear the interrupt.
    \ Address offset: 0x440
    \ Reset value: 0x00000000
    \
    $00 constant OTG_HS_PCSTS                   \ [0x00] PCSTS
    $01 constant OTG_HS_PCDET                   \ [0x01] PCDET
    $02 constant OTG_HS_PENA                    \ [0x02] PENA
    $03 constant OTG_HS_PENCHNG                 \ [0x03] PENCHNG
    $04 constant OTG_HS_POCA                    \ [0x04] POCA
    $05 constant OTG_HS_POCCHNG                 \ [0x05] POCCHNG
    $06 constant OTG_HS_PRES                    \ [0x06] PRES
    $07 constant OTG_HS_PSUSP                   \ [0x07] PSUSP
    $08 constant OTG_HS_PRST                    \ [0x08] PRST
    $0a constant OTG_HS_PLSTS                   \ [0x0a : 2] PLSTS
    $0c constant OTG_HS_PPWR                    \ [0x0c] PPWR
    $0d constant OTG_HS_PTCTL                   \ [0x0d : 4] PTCTL
    $11 constant OTG_HS_PSPD                    \ [0x11 : 2] PSPD
  [then]


  [ifdef] OTG_HS_HCCHAR0_DEF
    \
    \ @brief OTG host channel 0 characteristics register
    \ Address offset: 0x500
    \ Reset value: 0x00000000
    \
    $00 constant OTG_HS_MPSIZ                   \ [0x00 : 11] MPSIZ
    $0b constant OTG_HS_EPNUM                   \ [0x0b : 4] EPNUM
    $0f constant OTG_HS_EPDIR                   \ [0x0f] EPDIR
    $11 constant OTG_HS_LSDEV                   \ [0x11] LSDEV
    $12 constant OTG_HS_EPTYP                   \ [0x12 : 2] EPTYP
    $14 constant OTG_HS_MCNT                    \ [0x14 : 2] MCNT
    $16 constant OTG_HS_DAD                     \ [0x16 : 7] DAD
    $1d constant OTG_HS_ODDFRM                  \ [0x1d] ODDFRM
    $1e constant OTG_HS_CHDIS                   \ [0x1e] CHDIS
    $1f constant OTG_HS_CHENA                   \ [0x1f] CHENA
  [then]


  [ifdef] OTG_HS_HCSPLT0_DEF
    \
    \ @brief OTG host channel 0 split control register
    \ Address offset: 0x504
    \ Reset value: 0x00000000
    \
    $00 constant OTG_HS_PRTADDR                 \ [0x00 : 7] Port address This field is the port number of the recipient transaction translator.
    $07 constant OTG_HS_HUBADDR                 \ [0x07 : 7] Hub address This field holds the device address of the transaction translatorâs hub.
    $0e constant OTG_HS_XACTPOS                 \ [0x0e : 2] Transaction position This field is used to determine whether to send all, first, middle, or last payloads with each OUT transaction.
    $10 constant OTG_HS_COMPLSPLT               \ [0x10] Do complete split The application sets this bit to request the OTG host to perform a complete split transaction.
    $1f constant OTG_HS_SPLITEN                 \ [0x1f] Split enable The application sets this bit to indicate that this channel is enabled to perform split transactions.
  [then]


  [ifdef] OTG_HS_HCINT0_DEF
    \
    \ @brief This register indicates the status of a channel with respect to USB- and AHB-related events. It is shown in Figure724. The application must read this register when the host channels interrupt bit in the core interrupt register (HCINT bit in GINTSTS) is set. Before the application can read this register, it must first read the host all channels interrupt (HAINT) register to get the exact channel number for the host channel-x interrupt register. The application must clear the appropriate bit in this register to clear the corresponding bits in the HAINT and GINTSTS registers.
    \ Address offset: 0x508
    \ Reset value: 0x00000000
    \
    $00 constant OTG_HS_XFRC                    \ [0x00] XFRC
    $01 constant OTG_HS_CHH                     \ [0x01] CHH
    $03 constant OTG_HS_STALL                   \ [0x03] STALL
    $04 constant OTG_HS_NAK                     \ [0x04] NAK
    $05 constant OTG_HS_ACK                     \ [0x05] ACK
    $07 constant OTG_HS_TXERR                   \ [0x07] TXERR
    $08 constant OTG_HS_BBERR                   \ [0x08] BBERR
    $09 constant OTG_HS_FRMOR                   \ [0x09] FRMOR
    $0a constant OTG_HS_DTERR                   \ [0x0a] DTERR
  [then]


  [ifdef] OTG_HS_HCINTMSK0_DEF
    \
    \ @brief This register reflects the mask for each channel status described in the previous section.
    \ Address offset: 0x50C
    \ Reset value: 0x00000000
    \
    $00 constant OTG_HS_XFRCM                   \ [0x00] XFRCM
    $01 constant OTG_HS_CHHM                    \ [0x01] CHHM
    $03 constant OTG_HS_STALLM                  \ [0x03] STALLM
    $04 constant OTG_HS_NAKM                    \ [0x04] NAKM
    $05 constant OTG_HS_ACKM                    \ [0x05] ACKM
    $07 constant OTG_HS_TXERRM                  \ [0x07] TXERRM
    $08 constant OTG_HS_BBERRM                  \ [0x08] BBERRM
    $09 constant OTG_HS_FRMORM                  \ [0x09] FRMORM
    $0a constant OTG_HS_DTERRM                  \ [0x0a] DTERRM
  [then]


  [ifdef] OTG_HS_HCTSIZ0_DEF
    \
    \ @brief OTG host channel 0 transfer size register
    \ Address offset: 0x510
    \ Reset value: 0x00000000
    \
    $00 constant OTG_HS_XFRSIZ                  \ [0x00 : 19] XFRSIZ
    $13 constant OTG_HS_PKTCNT                  \ [0x13 : 10] PKTCNT
    $1d constant OTG_HS_DPID                    \ [0x1d : 2] DPID
    $1f constant OTG_HS_DOPNG                   \ [0x1f] DOPNG
  [then]


  [ifdef] OTG_HS_HCDMA0_DEF
    \
    \ @brief OTG host channel 0 DMA address register
    \ Address offset: 0x514
    \ Reset value: 0x00000000
    \
    $00 constant OTG_HS_DMAADDR                 \ [0x00 : 32] DMA address This field holds the start address in the external memory from which the data for the endpoint must be fetched or to which it must be stored. This register is incremented on every AHB transaction.
  [then]


  [ifdef] OTG_HS_HCCHAR1_DEF
    \
    \ @brief OTG host channel 1 characteristics register
    \ Address offset: 0x520
    \ Reset value: 0x00000000
    \
    $00 constant OTG_HS_MPSIZ                   \ [0x00 : 11] MPSIZ
    $0b constant OTG_HS_EPNUM                   \ [0x0b : 4] EPNUM
    $0f constant OTG_HS_EPDIR                   \ [0x0f] EPDIR
    $11 constant OTG_HS_LSDEV                   \ [0x11] LSDEV
    $12 constant OTG_HS_EPTYP                   \ [0x12 : 2] EPTYP
    $14 constant OTG_HS_MCNT                    \ [0x14 : 2] MCNT
    $16 constant OTG_HS_DAD                     \ [0x16 : 7] DAD
    $1d constant OTG_HS_ODDFRM                  \ [0x1d] ODDFRM
    $1e constant OTG_HS_CHDIS                   \ [0x1e] CHDIS
    $1f constant OTG_HS_CHENA                   \ [0x1f] CHENA
  [then]


  [ifdef] OTG_HS_HCSPLT1_DEF
    \
    \ @brief OTG host channel 1 split control register
    \ Address offset: 0x524
    \ Reset value: 0x00000000
    \
    $00 constant OTG_HS_PRTADDR                 \ [0x00 : 7] Port address This field is the port number of the recipient transaction translator.
    $07 constant OTG_HS_HUBADDR                 \ [0x07 : 7] Hub address This field holds the device address of the transaction translatorâs hub.
    $0e constant OTG_HS_XACTPOS                 \ [0x0e : 2] Transaction position This field is used to determine whether to send all, first, middle, or last payloads with each OUT transaction.
    $10 constant OTG_HS_COMPLSPLT               \ [0x10] Do complete split The application sets this bit to request the OTG host to perform a complete split transaction.
    $1f constant OTG_HS_SPLITEN                 \ [0x1f] Split enable The application sets this bit to indicate that this channel is enabled to perform split transactions.
  [then]


  [ifdef] OTG_HS_HCINT1_DEVICE_DEF
    \
    \ @brief This register indicates the status of a channel with respect to USB- and AHB-related events. It is shown in Figure724. The application must read this register when the host channels interrupt bit in the core interrupt register (HCINT bit in GINTSTS) is set. Before the application can read this register, it must first read the host all channels interrupt (HAINT) register to get the exact channel number for the host channel-x interrupt register. The application must clear the appropriate bit in this register to clear the corresponding bits in the HAINT and GINTSTS registers.
    \ Address offset: 0x528
    \ Reset value: 0x00000000
    \
    $00 constant OTG_HS_XFRC                    \ [0x00] XFRC
    $01 constant OTG_HS_CHH                     \ [0x01] CHH
    $03 constant OTG_HS_STALL                   \ [0x03] STALL
    $04 constant OTG_HS_NAK                     \ [0x04] NAK
    $05 constant OTG_HS_ACK                     \ [0x05] ACK
    $07 constant OTG_HS_TXERR                   \ [0x07] TXERR
    $08 constant OTG_HS_BBERR                   \ [0x08] BBERR
    $09 constant OTG_HS_FRMOR                   \ [0x09] FRMOR
    $0a constant OTG_HS_DTERR                   \ [0x0a] DTERR
  [then]


  [ifdef] OTG_HS_HCINTMSK1_DEF
    \
    \ @brief This register reflects the mask for each channel status described in the previous section.
    \ Address offset: 0x52C
    \ Reset value: 0x00000000
    \
    $00 constant OTG_HS_XFRCM                   \ [0x00] XFRCM
    $01 constant OTG_HS_CHHM                    \ [0x01] CHHM
    $03 constant OTG_HS_STALLM                  \ [0x03] STALLM
    $04 constant OTG_HS_NAKM                    \ [0x04] NAKM
    $05 constant OTG_HS_ACKM                    \ [0x05] ACKM
    $07 constant OTG_HS_TXERRM                  \ [0x07] TXERRM
    $08 constant OTG_HS_BBERRM                  \ [0x08] BBERRM
    $09 constant OTG_HS_FRMORM                  \ [0x09] FRMORM
    $0a constant OTG_HS_DTERRM                  \ [0x0a] DTERRM
  [then]


  [ifdef] OTG_HS_HCTSIZ1_DEF
    \
    \ @brief OTG host channel 1 transfer size register
    \ Address offset: 0x530
    \ Reset value: 0x00000000
    \
    $00 constant OTG_HS_XFRSIZ                  \ [0x00 : 19] XFRSIZ
    $13 constant OTG_HS_PKTCNT                  \ [0x13 : 10] PKTCNT
    $1d constant OTG_HS_DPID                    \ [0x1d : 2] DPID
    $1f constant OTG_HS_DOPNG                   \ [0x1f] DOPNG
  [then]


  [ifdef] OTG_HS_HCDMA1_DEF
    \
    \ @brief OTG host channel 1 DMA address register
    \ Address offset: 0x534
    \ Reset value: 0x00000000
    \
    $00 constant OTG_HS_DMAADDR                 \ [0x00 : 32] DMA address This field holds the start address in the external memory from which the data for the endpoint must be fetched or to which it must be stored. This register is incremented on every AHB transaction.
  [then]


  [ifdef] OTG_HS_HCCHAR2_DEF
    \
    \ @brief OTG host channel 2 characteristics register
    \ Address offset: 0x540
    \ Reset value: 0x00000000
    \
    $00 constant OTG_HS_MPSIZ                   \ [0x00 : 11] MPSIZ
    $0b constant OTG_HS_EPNUM                   \ [0x0b : 4] EPNUM
    $0f constant OTG_HS_EPDIR                   \ [0x0f] EPDIR
    $11 constant OTG_HS_LSDEV                   \ [0x11] LSDEV
    $12 constant OTG_HS_EPTYP                   \ [0x12 : 2] EPTYP
    $14 constant OTG_HS_MCNT                    \ [0x14 : 2] MCNT
    $16 constant OTG_HS_DAD                     \ [0x16 : 7] DAD
    $1d constant OTG_HS_ODDFRM                  \ [0x1d] ODDFRM
    $1e constant OTG_HS_CHDIS                   \ [0x1e] CHDIS
    $1f constant OTG_HS_CHENA                   \ [0x1f] CHENA
  [then]


  [ifdef] OTG_HS_HCSPLT2_DEF
    \
    \ @brief OTG host channel 2 split control register
    \ Address offset: 0x544
    \ Reset value: 0x00000000
    \
    $00 constant OTG_HS_PRTADDR                 \ [0x00 : 7] Port address This field is the port number of the recipient transaction translator.
    $07 constant OTG_HS_HUBADDR                 \ [0x07 : 7] Hub address This field holds the device address of the transaction translatorâs hub.
    $0e constant OTG_HS_XACTPOS                 \ [0x0e : 2] Transaction position This field is used to determine whether to send all, first, middle, or last payloads with each OUT transaction.
    $10 constant OTG_HS_COMPLSPLT               \ [0x10] Do complete split The application sets this bit to request the OTG host to perform a complete split transaction.
    $1f constant OTG_HS_SPLITEN                 \ [0x1f] Split enable The application sets this bit to indicate that this channel is enabled to perform split transactions.
  [then]


  [ifdef] OTG_HS_HCINT2_DEF
    \
    \ @brief This register indicates the status of a channel with respect to USB- and AHB-related events. It is shown in Figure724. The application must read this register when the host channels interrupt bit in the core interrupt register (HCINT bit in GINTSTS) is set. Before the application can read this register, it must first read the host all channels interrupt (HAINT) register to get the exact channel number for the host channel-x interrupt register. The application must clear the appropriate bit in this register to clear the corresponding bits in the HAINT and GINTSTS registers.
    \ Address offset: 0x548
    \ Reset value: 0x00000000
    \
    $00 constant OTG_HS_XFRC                    \ [0x00] XFRC
    $01 constant OTG_HS_CHH                     \ [0x01] CHH
    $03 constant OTG_HS_STALL                   \ [0x03] STALL
    $04 constant OTG_HS_NAK                     \ [0x04] NAK
    $05 constant OTG_HS_ACK                     \ [0x05] ACK
    $07 constant OTG_HS_TXERR                   \ [0x07] TXERR
    $08 constant OTG_HS_BBERR                   \ [0x08] BBERR
    $09 constant OTG_HS_FRMOR                   \ [0x09] FRMOR
    $0a constant OTG_HS_DTERR                   \ [0x0a] DTERR
  [then]


  [ifdef] OTG_HS_HCINTMSK2_DEF
    \
    \ @brief This register reflects the mask for each channel status described in the previous section.
    \ Address offset: 0x54C
    \ Reset value: 0x00000000
    \
    $00 constant OTG_HS_XFRCM                   \ [0x00] XFRCM
    $01 constant OTG_HS_CHHM                    \ [0x01] CHHM
    $03 constant OTG_HS_STALLM                  \ [0x03] STALLM
    $04 constant OTG_HS_NAKM                    \ [0x04] NAKM
    $05 constant OTG_HS_ACKM                    \ [0x05] ACKM
    $07 constant OTG_HS_TXERRM                  \ [0x07] TXERRM
    $08 constant OTG_HS_BBERRM                  \ [0x08] BBERRM
    $09 constant OTG_HS_FRMORM                  \ [0x09] FRMORM
    $0a constant OTG_HS_DTERRM                  \ [0x0a] DTERRM
  [then]


  [ifdef] OTG_HS_HCTSIZ2_DEF
    \
    \ @brief OTG host channel 2 transfer size register
    \ Address offset: 0x550
    \ Reset value: 0x00000000
    \
    $00 constant OTG_HS_XFRSIZ                  \ [0x00 : 19] XFRSIZ
    $13 constant OTG_HS_PKTCNT                  \ [0x13 : 10] PKTCNT
    $1d constant OTG_HS_DPID                    \ [0x1d : 2] DPID
    $1f constant OTG_HS_DOPNG                   \ [0x1f] DOPNG
  [then]


  [ifdef] OTG_HS_HCDMA2_DEF
    \
    \ @brief OTG host channel 2 DMA address register
    \ Address offset: 0x554
    \ Reset value: 0x00000000
    \
    $00 constant OTG_HS_DMAADDR                 \ [0x00 : 32] DMA address This field holds the start address in the external memory from which the data for the endpoint must be fetched or to which it must be stored. This register is incremented on every AHB transaction.
  [then]


  [ifdef] OTG_HS_HCCHAR3_DEF
    \
    \ @brief OTG host channel 3 characteristics register
    \ Address offset: 0x560
    \ Reset value: 0x00000000
    \
    $00 constant OTG_HS_MPSIZ                   \ [0x00 : 11] MPSIZ
    $0b constant OTG_HS_EPNUM                   \ [0x0b : 4] EPNUM
    $0f constant OTG_HS_EPDIR                   \ [0x0f] EPDIR
    $11 constant OTG_HS_LSDEV                   \ [0x11] LSDEV
    $12 constant OTG_HS_EPTYP                   \ [0x12 : 2] EPTYP
    $14 constant OTG_HS_MCNT                    \ [0x14 : 2] MCNT
    $16 constant OTG_HS_DAD                     \ [0x16 : 7] DAD
    $1d constant OTG_HS_ODDFRM                  \ [0x1d] ODDFRM
    $1e constant OTG_HS_CHDIS                   \ [0x1e] CHDIS
    $1f constant OTG_HS_CHENA                   \ [0x1f] CHENA
  [then]


  [ifdef] OTG_HS_HCSPLT3_DEF
    \
    \ @brief OTG host channel 3 split control register
    \ Address offset: 0x564
    \ Reset value: 0x00000000
    \
    $00 constant OTG_HS_PRTADDR                 \ [0x00 : 7] Port address This field is the port number of the recipient transaction translator.
    $07 constant OTG_HS_HUBADDR                 \ [0x07 : 7] Hub address This field holds the device address of the transaction translatorâs hub.
    $0e constant OTG_HS_XACTPOS                 \ [0x0e : 2] Transaction position This field is used to determine whether to send all, first, middle, or last payloads with each OUT transaction.
    $10 constant OTG_HS_COMPLSPLT               \ [0x10] Do complete split The application sets this bit to request the OTG host to perform a complete split transaction.
    $1f constant OTG_HS_SPLITEN                 \ [0x1f] Split enable The application sets this bit to indicate that this channel is enabled to perform split transactions.
  [then]


  [ifdef] OTG_HS_HCINT3_DEF
    \
    \ @brief This register indicates the status of a channel with respect to USB- and AHB-related events. It is shown in Figure724. The application must read this register when the host channels interrupt bit in the core interrupt register (HCINT bit in GINTSTS) is set. Before the application can read this register, it must first read the host all channels interrupt (HAINT) register to get the exact channel number for the host channel-x interrupt register. The application must clear the appropriate bit in this register to clear the corresponding bits in the HAINT and GINTSTS registers.
    \ Address offset: 0x568
    \ Reset value: 0x00000000
    \
    $00 constant OTG_HS_XFRC                    \ [0x00] XFRC
    $01 constant OTG_HS_CHH                     \ [0x01] CHH
    $03 constant OTG_HS_STALL                   \ [0x03] STALL
    $04 constant OTG_HS_NAK                     \ [0x04] NAK
    $05 constant OTG_HS_ACK                     \ [0x05] ACK
    $07 constant OTG_HS_TXERR                   \ [0x07] TXERR
    $08 constant OTG_HS_BBERR                   \ [0x08] BBERR
    $09 constant OTG_HS_FRMOR                   \ [0x09] FRMOR
    $0a constant OTG_HS_DTERR                   \ [0x0a] DTERR
  [then]


  [ifdef] OTG_HS_HCINTMSK3_DEF
    \
    \ @brief This register reflects the mask for each channel status described in the previous section.
    \ Address offset: 0x56C
    \ Reset value: 0x00000000
    \
    $00 constant OTG_HS_XFRCM                   \ [0x00] XFRCM
    $01 constant OTG_HS_CHHM                    \ [0x01] CHHM
    $03 constant OTG_HS_STALLM                  \ [0x03] STALLM
    $04 constant OTG_HS_NAKM                    \ [0x04] NAKM
    $05 constant OTG_HS_ACKM                    \ [0x05] ACKM
    $07 constant OTG_HS_TXERRM                  \ [0x07] TXERRM
    $08 constant OTG_HS_BBERRM                  \ [0x08] BBERRM
    $09 constant OTG_HS_FRMORM                  \ [0x09] FRMORM
    $0a constant OTG_HS_DTERRM                  \ [0x0a] DTERRM
  [then]


  [ifdef] OTG_HS_HCTSIZ3_DEF
    \
    \ @brief OTG host channel 3 transfer size register
    \ Address offset: 0x570
    \ Reset value: 0x00000000
    \
    $00 constant OTG_HS_XFRSIZ                  \ [0x00 : 19] XFRSIZ
    $13 constant OTG_HS_PKTCNT                  \ [0x13 : 10] PKTCNT
    $1d constant OTG_HS_DPID                    \ [0x1d : 2] DPID
    $1f constant OTG_HS_DOPNG                   \ [0x1f] DOPNG
  [then]


  [ifdef] OTG_HS_HCDMA3_DEF
    \
    \ @brief OTG host channel 3 DMA address register
    \ Address offset: 0x574
    \ Reset value: 0x00000000
    \
    $00 constant OTG_HS_DMAADDR                 \ [0x00 : 32] DMA address This field holds the start address in the external memory from which the data for the endpoint must be fetched or to which it must be stored. This register is incremented on every AHB transaction.
  [then]


  [ifdef] OTG_HS_HCCHAR4_DEF
    \
    \ @brief OTG host channel 4 characteristics register
    \ Address offset: 0x580
    \ Reset value: 0x00000000
    \
    $00 constant OTG_HS_MPSIZ                   \ [0x00 : 11] MPSIZ
    $0b constant OTG_HS_EPNUM                   \ [0x0b : 4] EPNUM
    $0f constant OTG_HS_EPDIR                   \ [0x0f] EPDIR
    $11 constant OTG_HS_LSDEV                   \ [0x11] LSDEV
    $12 constant OTG_HS_EPTYP                   \ [0x12 : 2] EPTYP
    $14 constant OTG_HS_MCNT                    \ [0x14 : 2] MCNT
    $16 constant OTG_HS_DAD                     \ [0x16 : 7] DAD
    $1d constant OTG_HS_ODDFRM                  \ [0x1d] ODDFRM
    $1e constant OTG_HS_CHDIS                   \ [0x1e] CHDIS
    $1f constant OTG_HS_CHENA                   \ [0x1f] CHENA
  [then]


  [ifdef] OTG_HS_HCSPLT4_DEF
    \
    \ @brief OTG host channel 4 split control register
    \ Address offset: 0x584
    \ Reset value: 0x00000000
    \
    $00 constant OTG_HS_PRTADDR                 \ [0x00 : 7] Port address This field is the port number of the recipient transaction translator.
    $07 constant OTG_HS_HUBADDR                 \ [0x07 : 7] Hub address This field holds the device address of the transaction translatorâs hub.
    $0e constant OTG_HS_XACTPOS                 \ [0x0e : 2] Transaction position This field is used to determine whether to send all, first, middle, or last payloads with each OUT transaction.
    $10 constant OTG_HS_COMPLSPLT               \ [0x10] Do complete split The application sets this bit to request the OTG host to perform a complete split transaction.
    $1f constant OTG_HS_SPLITEN                 \ [0x1f] Split enable The application sets this bit to indicate that this channel is enabled to perform split transactions.
  [then]


  [ifdef] OTG_HS_HCINT4_DEF
    \
    \ @brief This register indicates the status of a channel with respect to USB- and AHB-related events. It is shown in Figure724. The application must read this register when the host channels interrupt bit in the core interrupt register (HCINT bit in GINTSTS) is set. Before the application can read this register, it must first read the host all channels interrupt (HAINT) register to get the exact channel number for the host channel-x interrupt register. The application must clear the appropriate bit in this register to clear the corresponding bits in the HAINT and GINTSTS registers.
    \ Address offset: 0x588
    \ Reset value: 0x00000000
    \
    $00 constant OTG_HS_XFRC                    \ [0x00] XFRC
    $01 constant OTG_HS_CHH                     \ [0x01] CHH
    $03 constant OTG_HS_STALL                   \ [0x03] STALL
    $04 constant OTG_HS_NAK                     \ [0x04] NAK
    $05 constant OTG_HS_ACK                     \ [0x05] ACK
    $07 constant OTG_HS_TXERR                   \ [0x07] TXERR
    $08 constant OTG_HS_BBERR                   \ [0x08] BBERR
    $09 constant OTG_HS_FRMOR                   \ [0x09] FRMOR
    $0a constant OTG_HS_DTERR                   \ [0x0a] DTERR
  [then]


  [ifdef] OTG_HS_HCINTMSK4_DEF
    \
    \ @brief This register reflects the mask for each channel status described in the previous section.
    \ Address offset: 0x58C
    \ Reset value: 0x00000000
    \
    $00 constant OTG_HS_XFRCM                   \ [0x00] XFRCM
    $01 constant OTG_HS_CHHM                    \ [0x01] CHHM
    $03 constant OTG_HS_STALLM                  \ [0x03] STALLM
    $04 constant OTG_HS_NAKM                    \ [0x04] NAKM
    $05 constant OTG_HS_ACKM                    \ [0x05] ACKM
    $07 constant OTG_HS_TXERRM                  \ [0x07] TXERRM
    $08 constant OTG_HS_BBERRM                  \ [0x08] BBERRM
    $09 constant OTG_HS_FRMORM                  \ [0x09] FRMORM
    $0a constant OTG_HS_DTERRM                  \ [0x0a] DTERRM
  [then]


  [ifdef] OTG_HS_HCTSIZ4_DEF
    \
    \ @brief OTG host channel 4 transfer size register
    \ Address offset: 0x590
    \ Reset value: 0x00000000
    \
    $00 constant OTG_HS_XFRSIZ                  \ [0x00 : 19] XFRSIZ
    $13 constant OTG_HS_PKTCNT                  \ [0x13 : 10] PKTCNT
    $1d constant OTG_HS_DPID                    \ [0x1d : 2] DPID
    $1f constant OTG_HS_DOPNG                   \ [0x1f] DOPNG
  [then]


  [ifdef] OTG_HS_HCDMA4_DEF
    \
    \ @brief OTG host channel 4 DMA address register
    \ Address offset: 0x594
    \ Reset value: 0x00000000
    \
    $00 constant OTG_HS_DMAADDR                 \ [0x00 : 32] DMA address This field holds the start address in the external memory from which the data for the endpoint must be fetched or to which it must be stored. This register is incremented on every AHB transaction.
  [then]


  [ifdef] OTG_HS_HCCHAR5_DEF
    \
    \ @brief OTG host channel 5 characteristics register
    \ Address offset: 0x5A0
    \ Reset value: 0x00000000
    \
    $00 constant OTG_HS_MPSIZ                   \ [0x00 : 11] MPSIZ
    $0b constant OTG_HS_EPNUM                   \ [0x0b : 4] EPNUM
    $0f constant OTG_HS_EPDIR                   \ [0x0f] EPDIR
    $11 constant OTG_HS_LSDEV                   \ [0x11] LSDEV
    $12 constant OTG_HS_EPTYP                   \ [0x12 : 2] EPTYP
    $14 constant OTG_HS_MCNT                    \ [0x14 : 2] MCNT
    $16 constant OTG_HS_DAD                     \ [0x16 : 7] DAD
    $1d constant OTG_HS_ODDFRM                  \ [0x1d] ODDFRM
    $1e constant OTG_HS_CHDIS                   \ [0x1e] CHDIS
    $1f constant OTG_HS_CHENA                   \ [0x1f] CHENA
  [then]


  [ifdef] OTG_HS_HCSPLT5_DEF
    \
    \ @brief OTG host channel 5 split control register
    \ Address offset: 0x5A4
    \ Reset value: 0x00000000
    \
    $00 constant OTG_HS_PRTADDR                 \ [0x00 : 7] Port address This field is the port number of the recipient transaction translator.
    $07 constant OTG_HS_HUBADDR                 \ [0x07 : 7] Hub address This field holds the device address of the transaction translatorâs hub.
    $0e constant OTG_HS_XACTPOS                 \ [0x0e : 2] Transaction position This field is used to determine whether to send all, first, middle, or last payloads with each OUT transaction.
    $10 constant OTG_HS_COMPLSPLT               \ [0x10] Do complete split The application sets this bit to request the OTG host to perform a complete split transaction.
    $1f constant OTG_HS_SPLITEN                 \ [0x1f] Split enable The application sets this bit to indicate that this channel is enabled to perform split transactions.
  [then]


  [ifdef] OTG_HS_HCINT5_DEF
    \
    \ @brief This register indicates the status of a channel with respect to USB- and AHB-related events. It is shown in Figure724. The application must read this register when the host channels interrupt bit in the core interrupt register (HCINT bit in GINTSTS) is set. Before the application can read this register, it must first read the host all channels interrupt (HAINT) register to get the exact channel number for the host channel-x interrupt register. The application must clear the appropriate bit in this register to clear the corresponding bits in the HAINT and GINTSTS registers.
    \ Address offset: 0x5A8
    \ Reset value: 0x00000000
    \
    $00 constant OTG_HS_XFRC                    \ [0x00] XFRC
    $01 constant OTG_HS_CHH                     \ [0x01] CHH
    $03 constant OTG_HS_STALL                   \ [0x03] STALL
    $04 constant OTG_HS_NAK                     \ [0x04] NAK
    $05 constant OTG_HS_ACK                     \ [0x05] ACK
    $07 constant OTG_HS_TXERR                   \ [0x07] TXERR
    $08 constant OTG_HS_BBERR                   \ [0x08] BBERR
    $09 constant OTG_HS_FRMOR                   \ [0x09] FRMOR
    $0a constant OTG_HS_DTERR                   \ [0x0a] DTERR
  [then]


  [ifdef] OTG_HS_HCINTMSK5_DEF
    \
    \ @brief This register reflects the mask for each channel status described in the previous section.
    \ Address offset: 0x5AC
    \ Reset value: 0x00000000
    \
    $00 constant OTG_HS_XFRCM                   \ [0x00] XFRCM
    $01 constant OTG_HS_CHHM                    \ [0x01] CHHM
    $03 constant OTG_HS_STALLM                  \ [0x03] STALLM
    $04 constant OTG_HS_NAKM                    \ [0x04] NAKM
    $05 constant OTG_HS_ACKM                    \ [0x05] ACKM
    $07 constant OTG_HS_TXERRM                  \ [0x07] TXERRM
    $08 constant OTG_HS_BBERRM                  \ [0x08] BBERRM
    $09 constant OTG_HS_FRMORM                  \ [0x09] FRMORM
    $0a constant OTG_HS_DTERRM                  \ [0x0a] DTERRM
  [then]


  [ifdef] OTG_HS_HCTSIZ5_DEF
    \
    \ @brief OTG host channel 5 transfer size register
    \ Address offset: 0x5B0
    \ Reset value: 0x00000000
    \
    $00 constant OTG_HS_XFRSIZ                  \ [0x00 : 19] XFRSIZ
    $13 constant OTG_HS_PKTCNT                  \ [0x13 : 10] PKTCNT
    $1d constant OTG_HS_DPID                    \ [0x1d : 2] DPID
    $1f constant OTG_HS_DOPNG                   \ [0x1f] DOPNG
  [then]


  [ifdef] OTG_HS_HCDMA5_DEF
    \
    \ @brief OTG host channel 5 DMA address register
    \ Address offset: 0x5B4
    \ Reset value: 0x00000000
    \
    $00 constant OTG_HS_DMAADDR                 \ [0x00 : 32] DMA address This field holds the start address in the external memory from which the data for the endpoint must be fetched or to which it must be stored. This register is incremented on every AHB transaction.
  [then]


  [ifdef] OTG_HS_HCCHAR6_DEF
    \
    \ @brief OTG host channel 6 characteristics register
    \ Address offset: 0x5C0
    \ Reset value: 0x00000000
    \
    $00 constant OTG_HS_MPSIZ                   \ [0x00 : 11] MPSIZ
    $0b constant OTG_HS_EPNUM                   \ [0x0b : 4] EPNUM
    $0f constant OTG_HS_EPDIR                   \ [0x0f] EPDIR
    $11 constant OTG_HS_LSDEV                   \ [0x11] LSDEV
    $12 constant OTG_HS_EPTYP                   \ [0x12 : 2] EPTYP
    $14 constant OTG_HS_MCNT                    \ [0x14 : 2] MCNT
    $16 constant OTG_HS_DAD                     \ [0x16 : 7] DAD
    $1d constant OTG_HS_ODDFRM                  \ [0x1d] ODDFRM
    $1e constant OTG_HS_CHDIS                   \ [0x1e] CHDIS
    $1f constant OTG_HS_CHENA                   \ [0x1f] CHENA
  [then]


  [ifdef] OTG_HS_HCSPLT6_DEF
    \
    \ @brief OTG host channel 6 split control register
    \ Address offset: 0x5C4
    \ Reset value: 0x00000000
    \
    $00 constant OTG_HS_PRTADDR                 \ [0x00 : 7] Port address This field is the port number of the recipient transaction translator.
    $07 constant OTG_HS_HUBADDR                 \ [0x07 : 7] Hub address This field holds the device address of the transaction translatorâs hub.
    $0e constant OTG_HS_XACTPOS                 \ [0x0e : 2] Transaction position This field is used to determine whether to send all, first, middle, or last payloads with each OUT transaction.
    $10 constant OTG_HS_COMPLSPLT               \ [0x10] Do complete split The application sets this bit to request the OTG host to perform a complete split transaction.
    $1f constant OTG_HS_SPLITEN                 \ [0x1f] Split enable The application sets this bit to indicate that this channel is enabled to perform split transactions.
  [then]


  [ifdef] OTG_HS_HCINT6_DEF
    \
    \ @brief This register indicates the status of a channel with respect to USB- and AHB-related events. It is shown in Figure724. The application must read this register when the host channels interrupt bit in the core interrupt register (HCINT bit in GINTSTS) is set. Before the application can read this register, it must first read the host all channels interrupt (HAINT) register to get the exact channel number for the host channel-x interrupt register. The application must clear the appropriate bit in this register to clear the corresponding bits in the HAINT and GINTSTS registers.
    \ Address offset: 0x5C8
    \ Reset value: 0x00000000
    \
    $00 constant OTG_HS_XFRC                    \ [0x00] XFRC
    $01 constant OTG_HS_CHH                     \ [0x01] CHH
    $03 constant OTG_HS_STALL                   \ [0x03] STALL
    $04 constant OTG_HS_NAK                     \ [0x04] NAK
    $05 constant OTG_HS_ACK                     \ [0x05] ACK
    $07 constant OTG_HS_TXERR                   \ [0x07] TXERR
    $08 constant OTG_HS_BBERR                   \ [0x08] BBERR
    $09 constant OTG_HS_FRMOR                   \ [0x09] FRMOR
    $0a constant OTG_HS_DTERR                   \ [0x0a] DTERR
  [then]


  [ifdef] OTG_HS_HCINTMSK6_DEF
    \
    \ @brief This register reflects the mask for each channel status described in the previous section.
    \ Address offset: 0x5CC
    \ Reset value: 0x00000000
    \
    $00 constant OTG_HS_XFRCM                   \ [0x00] XFRCM
    $01 constant OTG_HS_CHHM                    \ [0x01] CHHM
    $03 constant OTG_HS_STALLM                  \ [0x03] STALLM
    $04 constant OTG_HS_NAKM                    \ [0x04] NAKM
    $05 constant OTG_HS_ACKM                    \ [0x05] ACKM
    $07 constant OTG_HS_TXERRM                  \ [0x07] TXERRM
    $08 constant OTG_HS_BBERRM                  \ [0x08] BBERRM
    $09 constant OTG_HS_FRMORM                  \ [0x09] FRMORM
    $0a constant OTG_HS_DTERRM                  \ [0x0a] DTERRM
  [then]


  [ifdef] OTG_HS_HCTSIZ6_DEF
    \
    \ @brief OTG host channel 6 transfer size register
    \ Address offset: 0x5D0
    \ Reset value: 0x00000000
    \
    $00 constant OTG_HS_XFRSIZ                  \ [0x00 : 19] XFRSIZ
    $13 constant OTG_HS_PKTCNT                  \ [0x13 : 10] PKTCNT
    $1d constant OTG_HS_DPID                    \ [0x1d : 2] DPID
    $1f constant OTG_HS_DOPNG                   \ [0x1f] DOPNG
  [then]


  [ifdef] OTG_HS_HCDMA6_DEF
    \
    \ @brief OTG host channel 6 DMA address register
    \ Address offset: 0x5D4
    \ Reset value: 0x00000000
    \
    $00 constant OTG_HS_DMAADDR                 \ [0x00 : 32] DMA address This field holds the start address in the external memory from which the data for the endpoint must be fetched or to which it must be stored. This register is incremented on every AHB transaction.
  [then]


  [ifdef] OTG_HS_HCCHAR7_DEF
    \
    \ @brief OTG host channel 7 characteristics register
    \ Address offset: 0x5E0
    \ Reset value: 0x00000000
    \
    $00 constant OTG_HS_MPSIZ                   \ [0x00 : 11] MPSIZ
    $0b constant OTG_HS_EPNUM                   \ [0x0b : 4] EPNUM
    $0f constant OTG_HS_EPDIR                   \ [0x0f] EPDIR
    $11 constant OTG_HS_LSDEV                   \ [0x11] LSDEV
    $12 constant OTG_HS_EPTYP                   \ [0x12 : 2] EPTYP
    $14 constant OTG_HS_MCNT                    \ [0x14 : 2] MCNT
    $16 constant OTG_HS_DAD                     \ [0x16 : 7] DAD
    $1d constant OTG_HS_ODDFRM                  \ [0x1d] ODDFRM
    $1e constant OTG_HS_CHDIS                   \ [0x1e] CHDIS
    $1f constant OTG_HS_CHENA                   \ [0x1f] CHENA
  [then]


  [ifdef] OTG_HS_HCSPLT7_DEF
    \
    \ @brief OTG host channel 7 split control register
    \ Address offset: 0x5E4
    \ Reset value: 0x00000000
    \
    $00 constant OTG_HS_PRTADDR                 \ [0x00 : 7] Port address This field is the port number of the recipient transaction translator.
    $07 constant OTG_HS_HUBADDR                 \ [0x07 : 7] Hub address This field holds the device address of the transaction translatorâs hub.
    $0e constant OTG_HS_XACTPOS                 \ [0x0e : 2] Transaction position This field is used to determine whether to send all, first, middle, or last payloads with each OUT transaction.
    $10 constant OTG_HS_COMPLSPLT               \ [0x10] Do complete split The application sets this bit to request the OTG host to perform a complete split transaction.
    $1f constant OTG_HS_SPLITEN                 \ [0x1f] Split enable The application sets this bit to indicate that this channel is enabled to perform split transactions.
  [then]


  [ifdef] OTG_HS_HCINT7_DEF
    \
    \ @brief This register indicates the status of a channel with respect to USB- and AHB-related events. It is shown in Figure724. The application must read this register when the host channels interrupt bit in the core interrupt register (HCINT bit in GINTSTS) is set. Before the application can read this register, it must first read the host all channels interrupt (HAINT) register to get the exact channel number for the host channel-x interrupt register. The application must clear the appropriate bit in this register to clear the corresponding bits in the HAINT and GINTSTS registers.
    \ Address offset: 0x5E8
    \ Reset value: 0x00000000
    \
    $00 constant OTG_HS_XFRC                    \ [0x00] XFRC
    $01 constant OTG_HS_CHH                     \ [0x01] CHH
    $03 constant OTG_HS_STALL                   \ [0x03] STALL
    $04 constant OTG_HS_NAK                     \ [0x04] NAK
    $05 constant OTG_HS_ACK                     \ [0x05] ACK
    $07 constant OTG_HS_TXERR                   \ [0x07] TXERR
    $08 constant OTG_HS_BBERR                   \ [0x08] BBERR
    $09 constant OTG_HS_FRMOR                   \ [0x09] FRMOR
    $0a constant OTG_HS_DTERR                   \ [0x0a] DTERR
  [then]


  [ifdef] OTG_HS_HCINTMSK7_DEF
    \
    \ @brief This register reflects the mask for each channel status described in the previous section.
    \ Address offset: 0x5EC
    \ Reset value: 0x00000000
    \
    $00 constant OTG_HS_XFRCM                   \ [0x00] XFRCM
    $01 constant OTG_HS_CHHM                    \ [0x01] CHHM
    $03 constant OTG_HS_STALLM                  \ [0x03] STALLM
    $04 constant OTG_HS_NAKM                    \ [0x04] NAKM
    $05 constant OTG_HS_ACKM                    \ [0x05] ACKM
    $07 constant OTG_HS_TXERRM                  \ [0x07] TXERRM
    $08 constant OTG_HS_BBERRM                  \ [0x08] BBERRM
    $09 constant OTG_HS_FRMORM                  \ [0x09] FRMORM
    $0a constant OTG_HS_DTERRM                  \ [0x0a] DTERRM
  [then]


  [ifdef] OTG_HS_HCTSIZ7_DEF
    \
    \ @brief OTG host channel 7 transfer size register
    \ Address offset: 0x5F0
    \ Reset value: 0x00000000
    \
    $00 constant OTG_HS_XFRSIZ                  \ [0x00 : 19] XFRSIZ
    $13 constant OTG_HS_PKTCNT                  \ [0x13 : 10] PKTCNT
    $1d constant OTG_HS_DPID                    \ [0x1d : 2] DPID
    $1f constant OTG_HS_DOPNG                   \ [0x1f] DOPNG
  [then]


  [ifdef] OTG_HS_HCDMA7_DEF
    \
    \ @brief OTG host channel 7 DMA address register
    \ Address offset: 0x5F4
    \ Reset value: 0x00000000
    \
    $00 constant OTG_HS_DMAADDR                 \ [0x00 : 32] DMA address This field holds the start address in the external memory from which the data for the endpoint must be fetched or to which it must be stored. This register is incremented on every AHB transaction.
  [then]


  [ifdef] OTG_HS_HCCHAR8_DEF
    \
    \ @brief OTG host channel 8 characteristics register
    \ Address offset: 0x600
    \ Reset value: 0x00000000
    \
    $00 constant OTG_HS_MPSIZ                   \ [0x00 : 11] MPSIZ
    $0b constant OTG_HS_EPNUM                   \ [0x0b : 4] EPNUM
    $0f constant OTG_HS_EPDIR                   \ [0x0f] EPDIR
    $11 constant OTG_HS_LSDEV                   \ [0x11] LSDEV
    $12 constant OTG_HS_EPTYP                   \ [0x12 : 2] EPTYP
    $14 constant OTG_HS_MCNT                    \ [0x14 : 2] MCNT
    $16 constant OTG_HS_DAD                     \ [0x16 : 7] DAD
    $1d constant OTG_HS_ODDFRM                  \ [0x1d] ODDFRM
    $1e constant OTG_HS_CHDIS                   \ [0x1e] CHDIS
    $1f constant OTG_HS_CHENA                   \ [0x1f] CHENA
  [then]


  [ifdef] OTG_HS_HCSPLT8_DEF
    \
    \ @brief OTG host channel 8 split control register
    \ Address offset: 0x604
    \ Reset value: 0x00000000
    \
    $00 constant OTG_HS_PRTADDR                 \ [0x00 : 7] Port address This field is the port number of the recipient transaction translator.
    $07 constant OTG_HS_HUBADDR                 \ [0x07 : 7] Hub address This field holds the device address of the transaction translatorâs hub.
    $0e constant OTG_HS_XACTPOS                 \ [0x0e : 2] Transaction position This field is used to determine whether to send all, first, middle, or last payloads with each OUT transaction.
    $10 constant OTG_HS_COMPLSPLT               \ [0x10] Do complete split The application sets this bit to request the OTG host to perform a complete split transaction.
    $1f constant OTG_HS_SPLITEN                 \ [0x1f] Split enable The application sets this bit to indicate that this channel is enabled to perform split transactions.
  [then]


  [ifdef] OTG_HS_HCINT8_DEF
    \
    \ @brief This register indicates the status of a channel with respect to USB- and AHB-related events. It is shown in Figure724. The application must read this register when the host channels interrupt bit in the core interrupt register (HCINT bit in GINTSTS) is set. Before the application can read this register, it must first read the host all channels interrupt (HAINT) register to get the exact channel number for the host channel-x interrupt register. The application must clear the appropriate bit in this register to clear the corresponding bits in the HAINT and GINTSTS registers.
    \ Address offset: 0x608
    \ Reset value: 0x00000000
    \
    $00 constant OTG_HS_XFRC                    \ [0x00] XFRC
    $01 constant OTG_HS_CHH                     \ [0x01] CHH
    $03 constant OTG_HS_STALL                   \ [0x03] STALL
    $04 constant OTG_HS_NAK                     \ [0x04] NAK
    $05 constant OTG_HS_ACK                     \ [0x05] ACK
    $07 constant OTG_HS_TXERR                   \ [0x07] TXERR
    $08 constant OTG_HS_BBERR                   \ [0x08] BBERR
    $09 constant OTG_HS_FRMOR                   \ [0x09] FRMOR
    $0a constant OTG_HS_DTERR                   \ [0x0a] DTERR
  [then]


  [ifdef] OTG_HS_HCINTMSK8_DEF
    \
    \ @brief This register reflects the mask for each channel status described in the previous section.
    \ Address offset: 0x60C
    \ Reset value: 0x00000000
    \
    $00 constant OTG_HS_XFRCM                   \ [0x00] XFRCM
    $01 constant OTG_HS_CHHM                    \ [0x01] CHHM
    $03 constant OTG_HS_STALLM                  \ [0x03] STALLM
    $04 constant OTG_HS_NAKM                    \ [0x04] NAKM
    $05 constant OTG_HS_ACKM                    \ [0x05] ACKM
    $07 constant OTG_HS_TXERRM                  \ [0x07] TXERRM
    $08 constant OTG_HS_BBERRM                  \ [0x08] BBERRM
    $09 constant OTG_HS_FRMORM                  \ [0x09] FRMORM
    $0a constant OTG_HS_DTERRM                  \ [0x0a] DTERRM
  [then]


  [ifdef] OTG_HS_HCTSIZ8_DEF
    \
    \ @brief OTG host channel 8 transfer size register
    \ Address offset: 0x610
    \ Reset value: 0x00000000
    \
    $00 constant OTG_HS_XFRSIZ                  \ [0x00 : 19] XFRSIZ
    $13 constant OTG_HS_PKTCNT                  \ [0x13 : 10] PKTCNT
    $1d constant OTG_HS_DPID                    \ [0x1d : 2] DPID
    $1f constant OTG_HS_DOPNG                   \ [0x1f] DOPNG
  [then]


  [ifdef] OTG_HS_HCDMA8_DEF
    \
    \ @brief OTG host channel 8 DMA address register
    \ Address offset: 0x614
    \ Reset value: 0x00000000
    \
    $00 constant OTG_HS_DMAADDR                 \ [0x00 : 32] DMA address This field holds the start address in the external memory from which the data for the endpoint must be fetched or to which it must be stored. This register is incremented on every AHB transaction.
  [then]


  [ifdef] OTG_HS_HCCHAR9_DEF
    \
    \ @brief OTG host channel 9 characteristics register
    \ Address offset: 0x620
    \ Reset value: 0x00000000
    \
    $00 constant OTG_HS_MPSIZ                   \ [0x00 : 11] MPSIZ
    $0b constant OTG_HS_EPNUM                   \ [0x0b : 4] EPNUM
    $0f constant OTG_HS_EPDIR                   \ [0x0f] EPDIR
    $11 constant OTG_HS_LSDEV                   \ [0x11] LSDEV
    $12 constant OTG_HS_EPTYP                   \ [0x12 : 2] EPTYP
    $14 constant OTG_HS_MCNT                    \ [0x14 : 2] MCNT
    $16 constant OTG_HS_DAD                     \ [0x16 : 7] DAD
    $1d constant OTG_HS_ODDFRM                  \ [0x1d] ODDFRM
    $1e constant OTG_HS_CHDIS                   \ [0x1e] CHDIS
    $1f constant OTG_HS_CHENA                   \ [0x1f] CHENA
  [then]


  [ifdef] OTG_HS_HCSPLT9_DEF
    \
    \ @brief OTG host channel 9 split control register
    \ Address offset: 0x624
    \ Reset value: 0x00000000
    \
    $00 constant OTG_HS_PRTADDR                 \ [0x00 : 7] Port address This field is the port number of the recipient transaction translator.
    $07 constant OTG_HS_HUBADDR                 \ [0x07 : 7] Hub address This field holds the device address of the transaction translatorâs hub.
    $0e constant OTG_HS_XACTPOS                 \ [0x0e : 2] Transaction position This field is used to determine whether to send all, first, middle, or last payloads with each OUT transaction.
    $10 constant OTG_HS_COMPLSPLT               \ [0x10] Do complete split The application sets this bit to request the OTG host to perform a complete split transaction.
    $1f constant OTG_HS_SPLITEN                 \ [0x1f] Split enable The application sets this bit to indicate that this channel is enabled to perform split transactions.
  [then]


  [ifdef] OTG_HS_HCINT9_DEF
    \
    \ @brief This register indicates the status of a channel with respect to USB- and AHB-related events. It is shown in Figure724. The application must read this register when the host channels interrupt bit in the core interrupt register (HCINT bit in GINTSTS) is set. Before the application can read this register, it must first read the host all channels interrupt (HAINT) register to get the exact channel number for the host channel-x interrupt register. The application must clear the appropriate bit in this register to clear the corresponding bits in the HAINT and GINTSTS registers.
    \ Address offset: 0x628
    \ Reset value: 0x00000000
    \
    $00 constant OTG_HS_XFRC                    \ [0x00] XFRC
    $01 constant OTG_HS_CHH                     \ [0x01] CHH
    $03 constant OTG_HS_STALL                   \ [0x03] STALL
    $04 constant OTG_HS_NAK                     \ [0x04] NAK
    $05 constant OTG_HS_ACK                     \ [0x05] ACK
    $07 constant OTG_HS_TXERR                   \ [0x07] TXERR
    $08 constant OTG_HS_BBERR                   \ [0x08] BBERR
    $09 constant OTG_HS_FRMOR                   \ [0x09] FRMOR
    $0a constant OTG_HS_DTERR                   \ [0x0a] DTERR
  [then]


  [ifdef] OTG_HS_HCINTMSK9_DEF
    \
    \ @brief This register reflects the mask for each channel status described in the previous section.
    \ Address offset: 0x62C
    \ Reset value: 0x00000000
    \
    $00 constant OTG_HS_XFRCM                   \ [0x00] XFRCM
    $01 constant OTG_HS_CHHM                    \ [0x01] CHHM
    $03 constant OTG_HS_STALLM                  \ [0x03] STALLM
    $04 constant OTG_HS_NAKM                    \ [0x04] NAKM
    $05 constant OTG_HS_ACKM                    \ [0x05] ACKM
    $07 constant OTG_HS_TXERRM                  \ [0x07] TXERRM
    $08 constant OTG_HS_BBERRM                  \ [0x08] BBERRM
    $09 constant OTG_HS_FRMORM                  \ [0x09] FRMORM
    $0a constant OTG_HS_DTERRM                  \ [0x0a] DTERRM
  [then]


  [ifdef] OTG_HS_HCTSIZ9_DEF
    \
    \ @brief OTG host channel 9 transfer size register
    \ Address offset: 0x630
    \ Reset value: 0x00000000
    \
    $00 constant OTG_HS_XFRSIZ                  \ [0x00 : 19] XFRSIZ
    $13 constant OTG_HS_PKTCNT                  \ [0x13 : 10] PKTCNT
    $1d constant OTG_HS_DPID                    \ [0x1d : 2] DPID
    $1f constant OTG_HS_DOPNG                   \ [0x1f] DOPNG
  [then]


  [ifdef] OTG_HS_HCDMA9_DEF
    \
    \ @brief OTG host channel 9 DMA address register
    \ Address offset: 0x634
    \ Reset value: 0x00000000
    \
    $00 constant OTG_HS_DMAADDR                 \ [0x00 : 32] DMA address This field holds the start address in the external memory from which the data for the endpoint must be fetched or to which it must be stored. This register is incremented on every AHB transaction.
  [then]


  [ifdef] OTG_HS_HCCHAR10_DEF
    \
    \ @brief OTG host channel 10 characteristics register
    \ Address offset: 0x640
    \ Reset value: 0x00000000
    \
    $00 constant OTG_HS_MPSIZ                   \ [0x00 : 11] MPSIZ
    $0b constant OTG_HS_EPNUM                   \ [0x0b : 4] EPNUM
    $0f constant OTG_HS_EPDIR                   \ [0x0f] EPDIR
    $11 constant OTG_HS_LSDEV                   \ [0x11] LSDEV
    $12 constant OTG_HS_EPTYP                   \ [0x12 : 2] EPTYP
    $14 constant OTG_HS_MCNT                    \ [0x14 : 2] MCNT
    $16 constant OTG_HS_DAD                     \ [0x16 : 7] DAD
    $1d constant OTG_HS_ODDFRM                  \ [0x1d] ODDFRM
    $1e constant OTG_HS_CHDIS                   \ [0x1e] CHDIS
    $1f constant OTG_HS_CHENA                   \ [0x1f] CHENA
  [then]


  [ifdef] OTG_HS_HCSPLT10_DEF
    \
    \ @brief OTG host channel 10 split control register
    \ Address offset: 0x644
    \ Reset value: 0x00000000
    \
    $00 constant OTG_HS_PRTADDR                 \ [0x00 : 7] Port address This field is the port number of the recipient transaction translator.
    $07 constant OTG_HS_HUBADDR                 \ [0x07 : 7] Hub address This field holds the device address of the transaction translatorâs hub.
    $0e constant OTG_HS_XACTPOS                 \ [0x0e : 2] Transaction position This field is used to determine whether to send all, first, middle, or last payloads with each OUT transaction.
    $10 constant OTG_HS_COMPLSPLT               \ [0x10] Do complete split The application sets this bit to request the OTG host to perform a complete split transaction.
    $1f constant OTG_HS_SPLITEN                 \ [0x1f] Split enable The application sets this bit to indicate that this channel is enabled to perform split transactions.
  [then]


  [ifdef] OTG_HS_HCINT10_DEF
    \
    \ @brief This register indicates the status of a channel with respect to USB- and AHB-related events. It is shown in Figure724. The application must read this register when the host channels interrupt bit in the core interrupt register (HCINT bit in GINTSTS) is set. Before the application can read this register, it must first read the host all channels interrupt (HAINT) register to get the exact channel number for the host channel-x interrupt register. The application must clear the appropriate bit in this register to clear the corresponding bits in the HAINT and GINTSTS registers.
    \ Address offset: 0x648
    \ Reset value: 0x00000000
    \
    $00 constant OTG_HS_XFRC                    \ [0x00] XFRC
    $01 constant OTG_HS_CHH                     \ [0x01] CHH
    $03 constant OTG_HS_STALL                   \ [0x03] STALL
    $04 constant OTG_HS_NAK                     \ [0x04] NAK
    $05 constant OTG_HS_ACK                     \ [0x05] ACK
    $07 constant OTG_HS_TXERR                   \ [0x07] TXERR
    $08 constant OTG_HS_BBERR                   \ [0x08] BBERR
    $09 constant OTG_HS_FRMOR                   \ [0x09] FRMOR
    $0a constant OTG_HS_DTERR                   \ [0x0a] DTERR
  [then]


  [ifdef] OTG_HS_HCINTMSK10_DEF
    \
    \ @brief This register reflects the mask for each channel status described in the previous section.
    \ Address offset: 0x64C
    \ Reset value: 0x00000000
    \
    $00 constant OTG_HS_XFRCM                   \ [0x00] XFRCM
    $01 constant OTG_HS_CHHM                    \ [0x01] CHHM
    $03 constant OTG_HS_STALLM                  \ [0x03] STALLM
    $04 constant OTG_HS_NAKM                    \ [0x04] NAKM
    $05 constant OTG_HS_ACKM                    \ [0x05] ACKM
    $07 constant OTG_HS_TXERRM                  \ [0x07] TXERRM
    $08 constant OTG_HS_BBERRM                  \ [0x08] BBERRM
    $09 constant OTG_HS_FRMORM                  \ [0x09] FRMORM
    $0a constant OTG_HS_DTERRM                  \ [0x0a] DTERRM
  [then]


  [ifdef] OTG_HS_HCTSIZ10_DEF
    \
    \ @brief OTG host channel 10 transfer size register
    \ Address offset: 0x650
    \ Reset value: 0x00000000
    \
    $00 constant OTG_HS_XFRSIZ                  \ [0x00 : 19] XFRSIZ
    $13 constant OTG_HS_PKTCNT                  \ [0x13 : 10] PKTCNT
    $1d constant OTG_HS_DPID                    \ [0x1d : 2] DPID
    $1f constant OTG_HS_DOPNG                   \ [0x1f] DOPNG
  [then]


  [ifdef] OTG_HS_HCDMA10_DEF
    \
    \ @brief OTG host channel 10 DMA address register
    \ Address offset: 0x654
    \ Reset value: 0x00000000
    \
    $00 constant OTG_HS_DMAADDR                 \ [0x00 : 32] DMA address This field holds the start address in the external memory from which the data for the endpoint must be fetched or to which it must be stored. This register is incremented on every AHB transaction.
  [then]


  [ifdef] OTG_HS_HCCHAR11_DEF
    \
    \ @brief OTG host channel 11 characteristics register
    \ Address offset: 0x660
    \ Reset value: 0x00000000
    \
    $00 constant OTG_HS_MPSIZ                   \ [0x00 : 11] MPSIZ
    $0b constant OTG_HS_EPNUM                   \ [0x0b : 4] EPNUM
    $0f constant OTG_HS_EPDIR                   \ [0x0f] EPDIR
    $11 constant OTG_HS_LSDEV                   \ [0x11] LSDEV
    $12 constant OTG_HS_EPTYP                   \ [0x12 : 2] EPTYP
    $14 constant OTG_HS_MCNT                    \ [0x14 : 2] MCNT
    $16 constant OTG_HS_DAD                     \ [0x16 : 7] DAD
    $1d constant OTG_HS_ODDFRM                  \ [0x1d] ODDFRM
    $1e constant OTG_HS_CHDIS                   \ [0x1e] CHDIS
    $1f constant OTG_HS_CHENA                   \ [0x1f] CHENA
  [then]


  [ifdef] OTG_HS_HCSPLT11_DEF
    \
    \ @brief OTG host channel 11 split control register
    \ Address offset: 0x664
    \ Reset value: 0x00000000
    \
    $00 constant OTG_HS_PRTADDR                 \ [0x00 : 7] Port address This field is the port number of the recipient transaction translator.
    $07 constant OTG_HS_HUBADDR                 \ [0x07 : 7] Hub address This field holds the device address of the transaction translatorâs hub.
    $0e constant OTG_HS_XACTPOS                 \ [0x0e : 2] Transaction position This field is used to determine whether to send all, first, middle, or last payloads with each OUT transaction.
    $10 constant OTG_HS_COMPLSPLT               \ [0x10] Do complete split The application sets this bit to request the OTG host to perform a complete split transaction.
    $1f constant OTG_HS_SPLITEN                 \ [0x1f] Split enable The application sets this bit to indicate that this channel is enabled to perform split transactions.
  [then]


  [ifdef] OTG_HS_HCINT11_DEF
    \
    \ @brief This register indicates the status of a channel with respect to USB- and AHB-related events. It is shown in Figure724. The application must read this register when the host channels interrupt bit in the core interrupt register (HCINT bit in GINTSTS) is set. Before the application can read this register, it must first read the host all channels interrupt (HAINT) register to get the exact channel number for the host channel-x interrupt register. The application must clear the appropriate bit in this register to clear the corresponding bits in the HAINT and GINTSTS registers.
    \ Address offset: 0x668
    \ Reset value: 0x00000000
    \
    $00 constant OTG_HS_XFRC                    \ [0x00] XFRC
    $01 constant OTG_HS_CHH                     \ [0x01] CHH
    $03 constant OTG_HS_STALL                   \ [0x03] STALL
    $04 constant OTG_HS_NAK                     \ [0x04] NAK
    $05 constant OTG_HS_ACK                     \ [0x05] ACK
    $07 constant OTG_HS_TXERR                   \ [0x07] TXERR
    $08 constant OTG_HS_BBERR                   \ [0x08] BBERR
    $09 constant OTG_HS_FRMOR                   \ [0x09] FRMOR
    $0a constant OTG_HS_DTERR                   \ [0x0a] DTERR
  [then]


  [ifdef] OTG_HS_HCINTMSK11_DEF
    \
    \ @brief This register reflects the mask for each channel status described in the previous section.
    \ Address offset: 0x66C
    \ Reset value: 0x00000000
    \
    $00 constant OTG_HS_XFRCM                   \ [0x00] XFRCM
    $01 constant OTG_HS_CHHM                    \ [0x01] CHHM
    $03 constant OTG_HS_STALLM                  \ [0x03] STALLM
    $04 constant OTG_HS_NAKM                    \ [0x04] NAKM
    $05 constant OTG_HS_ACKM                    \ [0x05] ACKM
    $07 constant OTG_HS_TXERRM                  \ [0x07] TXERRM
    $08 constant OTG_HS_BBERRM                  \ [0x08] BBERRM
    $09 constant OTG_HS_FRMORM                  \ [0x09] FRMORM
    $0a constant OTG_HS_DTERRM                  \ [0x0a] DTERRM
  [then]


  [ifdef] OTG_HS_HCTSIZ11_DEF
    \
    \ @brief OTG host channel 11 transfer size register
    \ Address offset: 0x670
    \ Reset value: 0x00000000
    \
    $00 constant OTG_HS_XFRSIZ                  \ [0x00 : 19] XFRSIZ
    $13 constant OTG_HS_PKTCNT                  \ [0x13 : 10] PKTCNT
    $1d constant OTG_HS_DPID                    \ [0x1d : 2] DPID
    $1f constant OTG_HS_DOPNG                   \ [0x1f] DOPNG
  [then]


  [ifdef] OTG_HS_HCDMA11_DEF
    \
    \ @brief OTG host channel 11 DMA address register
    \ Address offset: 0x674
    \ Reset value: 0x00000000
    \
    $00 constant OTG_HS_DMAADDR                 \ [0x00 : 32] DMA address This field holds the start address in the external memory from which the data for the endpoint must be fetched or to which it must be stored. This register is incremented on every AHB transaction.
  [then]


  [ifdef] OTG_HS_HCCHAR12_DEF
    \
    \ @brief OTG host channel 12 characteristics register
    \ Address offset: 0x680
    \ Reset value: 0x00000000
    \
    $00 constant OTG_HS_MPSIZ                   \ [0x00 : 11] MPSIZ
    $0b constant OTG_HS_EPNUM                   \ [0x0b : 4] EPNUM
    $0f constant OTG_HS_EPDIR                   \ [0x0f] EPDIR
    $11 constant OTG_HS_LSDEV                   \ [0x11] LSDEV
    $12 constant OTG_HS_EPTYP                   \ [0x12 : 2] EPTYP
    $14 constant OTG_HS_MCNT                    \ [0x14 : 2] MCNT
    $16 constant OTG_HS_DAD                     \ [0x16 : 7] DAD
    $1d constant OTG_HS_ODDFRM                  \ [0x1d] ODDFRM
    $1e constant OTG_HS_CHDIS                   \ [0x1e] CHDIS
    $1f constant OTG_HS_CHENA                   \ [0x1f] CHENA
  [then]


  [ifdef] OTG_HS_HCSPLT12_DEF
    \
    \ @brief OTG host channel 0 split control register
    \ Address offset: 0x684
    \ Reset value: 0x00000000
    \
    $00 constant OTG_HS_PRTADDR                 \ [0x00 : 7] Port address This field is the port number of the recipient transaction translator.
    $07 constant OTG_HS_HUBADDR                 \ [0x07 : 7] Hub address This field holds the device address of the transaction translatorâs hub.
    $0e constant OTG_HS_XACTPOS                 \ [0x0e : 2] Transaction position This field is used to determine whether to send all, first, middle, or last payloads with each OUT transaction.
    $10 constant OTG_HS_COMPLSPLT               \ [0x10] Do complete split The application sets this bit to request the OTG host to perform a complete split transaction.
    $1f constant OTG_HS_SPLITEN                 \ [0x1f] Split enable The application sets this bit to indicate that this channel is enabled to perform split transactions.
  [then]


  [ifdef] OTG_HS_HCINT12_DEF
    \
    \ @brief This register indicates the status of a channel with respect to USB- and AHB-related events. It is shown in Figure724. The application must read this register when the host channels interrupt bit in the core interrupt register (HCINT bit in GINTSTS) is set. Before the application can read this register, it must first read the host all channels interrupt (HAINT) register to get the exact channel number for the host channel-x interrupt register. The application must clear the appropriate bit in this register to clear the corresponding bits in the HAINT and GINTSTS registers.
    \ Address offset: 0x688
    \ Reset value: 0x00000000
    \
    $00 constant OTG_HS_XFRC                    \ [0x00] XFRC
    $01 constant OTG_HS_CHH                     \ [0x01] CHH
    $03 constant OTG_HS_STALL                   \ [0x03] STALL
    $04 constant OTG_HS_NAK                     \ [0x04] NAK
    $05 constant OTG_HS_ACK                     \ [0x05] ACK
    $07 constant OTG_HS_TXERR                   \ [0x07] TXERR
    $08 constant OTG_HS_BBERR                   \ [0x08] BBERR
    $09 constant OTG_HS_FRMOR                   \ [0x09] FRMOR
    $0a constant OTG_HS_DTERR                   \ [0x0a] DTERR
  [then]


  [ifdef] OTG_HS_HCINTMSK12_DEF
    \
    \ @brief This register reflects the mask for each channel status described in the previous section.
    \ Address offset: 0x68C
    \ Reset value: 0x00000000
    \
    $00 constant OTG_HS_XFRCM                   \ [0x00] XFRCM
    $01 constant OTG_HS_CHHM                    \ [0x01] CHHM
    $03 constant OTG_HS_STALLM                  \ [0x03] STALLM
    $04 constant OTG_HS_NAKM                    \ [0x04] NAKM
    $05 constant OTG_HS_ACKM                    \ [0x05] ACKM
    $07 constant OTG_HS_TXERRM                  \ [0x07] TXERRM
    $08 constant OTG_HS_BBERRM                  \ [0x08] BBERRM
    $09 constant OTG_HS_FRMORM                  \ [0x09] FRMORM
    $0a constant OTG_HS_DTERRM                  \ [0x0a] DTERRM
  [then]


  [ifdef] OTG_HS_HCTSIZ12_DEF
    \
    \ @brief OTG host channel 12 transfer size register
    \ Address offset: 0x690
    \ Reset value: 0x00000000
    \
    $00 constant OTG_HS_XFRSIZ                  \ [0x00 : 19] XFRSIZ
    $13 constant OTG_HS_PKTCNT                  \ [0x13 : 10] PKTCNT
    $1d constant OTG_HS_DPID                    \ [0x1d : 2] DPID
    $1f constant OTG_HS_DOPNG                   \ [0x1f] DOPNG
  [then]


  [ifdef] OTG_HS_HCDMA12_DEF
    \
    \ @brief OTG host channel 12 DMA address register
    \ Address offset: 0x694
    \ Reset value: 0x00000000
    \
    $00 constant OTG_HS_DMAADDR                 \ [0x00 : 32] DMA address This field holds the start address in the external memory from which the data for the endpoint must be fetched or to which it must be stored. This register is incremented on every AHB transaction.
  [then]


  [ifdef] OTG_HS_HCCHAR13_DEF
    \
    \ @brief OTG host channel 13 characteristics register
    \ Address offset: 0x6A0
    \ Reset value: 0x00000000
    \
    $00 constant OTG_HS_MPSIZ                   \ [0x00 : 11] MPSIZ
    $0b constant OTG_HS_EPNUM                   \ [0x0b : 4] EPNUM
    $0f constant OTG_HS_EPDIR                   \ [0x0f] EPDIR
    $11 constant OTG_HS_LSDEV                   \ [0x11] LSDEV
    $12 constant OTG_HS_EPTYP                   \ [0x12 : 2] EPTYP
    $14 constant OTG_HS_MCNT                    \ [0x14 : 2] MCNT
    $16 constant OTG_HS_DAD                     \ [0x16 : 7] DAD
    $1d constant OTG_HS_ODDFRM                  \ [0x1d] ODDFRM
    $1e constant OTG_HS_CHDIS                   \ [0x1e] CHDIS
    $1f constant OTG_HS_CHENA                   \ [0x1f] CHENA
  [then]


  [ifdef] OTG_HS_HCSPLT13_DEF
    \
    \ @brief OTG host channel 13 split control register
    \ Address offset: 0x6A4
    \ Reset value: 0x00000000
    \
    $00 constant OTG_HS_PRTADDR                 \ [0x00 : 7] Port address This field is the port number of the recipient transaction translator.
    $07 constant OTG_HS_HUBADDR                 \ [0x07 : 7] Hub address This field holds the device address of the transaction translatorâs hub.
    $0e constant OTG_HS_XACTPOS                 \ [0x0e : 2] Transaction position This field is used to determine whether to send all, first, middle, or last payloads with each OUT transaction.
    $10 constant OTG_HS_COMPLSPLT               \ [0x10] Do complete split The application sets this bit to request the OTG host to perform a complete split transaction.
    $1f constant OTG_HS_SPLITEN                 \ [0x1f] Split enable The application sets this bit to indicate that this channel is enabled to perform split transactions.
  [then]


  [ifdef] OTG_HS_HCINT13_DEF
    \
    \ @brief This register indicates the status of a channel with respect to USB- and AHB-related events. It is shown in Figure724. The application must read this register when the host channels interrupt bit in the core interrupt register (HCINT bit in GINTSTS) is set. Before the application can read this register, it must first read the host all channels interrupt (HAINT) register to get the exact channel number for the host channel-x interrupt register. The application must clear the appropriate bit in this register to clear the corresponding bits in the HAINT and GINTSTS registers.
    \ Address offset: 0x6A8
    \ Reset value: 0x00000000
    \
    $00 constant OTG_HS_XFRC                    \ [0x00] XFRC
    $01 constant OTG_HS_CHH                     \ [0x01] CHH
    $03 constant OTG_HS_STALL                   \ [0x03] STALL
    $04 constant OTG_HS_NAK                     \ [0x04] NAK
    $05 constant OTG_HS_ACK                     \ [0x05] ACK
    $07 constant OTG_HS_TXERR                   \ [0x07] TXERR
    $08 constant OTG_HS_BBERR                   \ [0x08] BBERR
    $09 constant OTG_HS_FRMOR                   \ [0x09] FRMOR
    $0a constant OTG_HS_DTERR                   \ [0x0a] DTERR
  [then]


  [ifdef] OTG_HS_HCINTMSK13_DEF
    \
    \ @brief This register reflects the mask for each channel status described in the previous section.
    \ Address offset: 0x6AC
    \ Reset value: 0x00000000
    \
    $00 constant OTG_HS_XFRCM                   \ [0x00] XFRCM
    $01 constant OTG_HS_CHHM                    \ [0x01] CHHM
    $03 constant OTG_HS_STALLM                  \ [0x03] STALLM
    $04 constant OTG_HS_NAKM                    \ [0x04] NAKM
    $05 constant OTG_HS_ACKM                    \ [0x05] ACKM
    $07 constant OTG_HS_TXERRM                  \ [0x07] TXERRM
    $08 constant OTG_HS_BBERRM                  \ [0x08] BBERRM
    $09 constant OTG_HS_FRMORM                  \ [0x09] FRMORM
    $0a constant OTG_HS_DTERRM                  \ [0x0a] DTERRM
  [then]


  [ifdef] OTG_HS_HCTSIZ13_DEF
    \
    \ @brief OTG host channel 13 transfer size register
    \ Address offset: 0x6B0
    \ Reset value: 0x00000000
    \
    $00 constant OTG_HS_XFRSIZ                  \ [0x00 : 19] XFRSIZ
    $13 constant OTG_HS_PKTCNT                  \ [0x13 : 10] PKTCNT
    $1d constant OTG_HS_DPID                    \ [0x1d : 2] DPID
    $1f constant OTG_HS_DOPNG                   \ [0x1f] DOPNG
  [then]


  [ifdef] OTG_HS_HCDMA13_DEF
    \
    \ @brief OTG host channel 13 DMA address register
    \ Address offset: 0x6B4
    \ Reset value: 0x00000000
    \
    $00 constant OTG_HS_DMAADDR                 \ [0x00 : 32] DMA address This field holds the start address in the external memory from which the data for the endpoint must be fetched or to which it must be stored. This register is incremented on every AHB transaction.
  [then]


  [ifdef] OTG_HS_HCCHAR14_DEF
    \
    \ @brief OTG host channel 14 characteristics register
    \ Address offset: 0x6C0
    \ Reset value: 0x00000000
    \
    $00 constant OTG_HS_MPSIZ                   \ [0x00 : 11] MPSIZ
    $0b constant OTG_HS_EPNUM                   \ [0x0b : 4] EPNUM
    $0f constant OTG_HS_EPDIR                   \ [0x0f] EPDIR
    $11 constant OTG_HS_LSDEV                   \ [0x11] LSDEV
    $12 constant OTG_HS_EPTYP                   \ [0x12 : 2] EPTYP
    $14 constant OTG_HS_MCNT                    \ [0x14 : 2] MCNT
    $16 constant OTG_HS_DAD                     \ [0x16 : 7] DAD
    $1d constant OTG_HS_ODDFRM                  \ [0x1d] ODDFRM
    $1e constant OTG_HS_CHDIS                   \ [0x1e] CHDIS
    $1f constant OTG_HS_CHENA                   \ [0x1f] CHENA
  [then]


  [ifdef] OTG_HS_HCSPLT14_DEF
    \
    \ @brief OTG host channel 14 split control register
    \ Address offset: 0x6C4
    \ Reset value: 0x00000000
    \
    $00 constant OTG_HS_PRTADDR                 \ [0x00 : 7] Port address This field is the port number of the recipient transaction translator.
    $07 constant OTG_HS_HUBADDR                 \ [0x07 : 7] Hub address This field holds the device address of the transaction translatorâs hub.
    $0e constant OTG_HS_XACTPOS                 \ [0x0e : 2] Transaction position This field is used to determine whether to send all, first, middle, or last payloads with each OUT transaction.
    $10 constant OTG_HS_COMPLSPLT               \ [0x10] Do complete split The application sets this bit to request the OTG host to perform a complete split transaction.
    $1f constant OTG_HS_SPLITEN                 \ [0x1f] Split enable The application sets this bit to indicate that this channel is enabled to perform split transactions.
  [then]


  [ifdef] OTG_HS_HCINT14_DEF
    \
    \ @brief This register indicates the status of a channel with respect to USB- and AHB-related events. It is shown in Figure724. The application must read this register when the host channels interrupt bit in the core interrupt register (HCINT bit in GINTSTS) is set. Before the application can read this register, it must first read the host all channels interrupt (HAINT) register to get the exact channel number for the host channel-x interrupt register. The application must clear the appropriate bit in this register to clear the corresponding bits in the HAINT and GINTSTS registers.
    \ Address offset: 0x6C8
    \ Reset value: 0x00000000
    \
    $00 constant OTG_HS_XFRC                    \ [0x00] XFRC
    $01 constant OTG_HS_CHH                     \ [0x01] CHH
    $03 constant OTG_HS_STALL                   \ [0x03] STALL
    $04 constant OTG_HS_NAK                     \ [0x04] NAK
    $05 constant OTG_HS_ACK                     \ [0x05] ACK
    $07 constant OTG_HS_TXERR                   \ [0x07] TXERR
    $08 constant OTG_HS_BBERR                   \ [0x08] BBERR
    $09 constant OTG_HS_FRMOR                   \ [0x09] FRMOR
    $0a constant OTG_HS_DTERR                   \ [0x0a] DTERR
  [then]


  [ifdef] OTG_HS_HCINTMSK14_DEF
    \
    \ @brief This register reflects the mask for each channel status described in the previous section.
    \ Address offset: 0x6CC
    \ Reset value: 0x00000000
    \
    $00 constant OTG_HS_XFRCM                   \ [0x00] XFRCM
    $01 constant OTG_HS_CHHM                    \ [0x01] CHHM
    $03 constant OTG_HS_STALLM                  \ [0x03] STALLM
    $04 constant OTG_HS_NAKM                    \ [0x04] NAKM
    $05 constant OTG_HS_ACKM                    \ [0x05] ACKM
    $07 constant OTG_HS_TXERRM                  \ [0x07] TXERRM
    $08 constant OTG_HS_BBERRM                  \ [0x08] BBERRM
    $09 constant OTG_HS_FRMORM                  \ [0x09] FRMORM
    $0a constant OTG_HS_DTERRM                  \ [0x0a] DTERRM
  [then]


  [ifdef] OTG_HS_HCTSIZ14_DEF
    \
    \ @brief OTG host channel 14 transfer size register
    \ Address offset: 0x6D0
    \ Reset value: 0x00000000
    \
    $00 constant OTG_HS_XFRSIZ                  \ [0x00 : 19] XFRSIZ
    $13 constant OTG_HS_PKTCNT                  \ [0x13 : 10] PKTCNT
    $1d constant OTG_HS_DPID                    \ [0x1d : 2] DPID
    $1f constant OTG_HS_DOPNG                   \ [0x1f] DOPNG
  [then]


  [ifdef] OTG_HS_HCDMA14_DEF
    \
    \ @brief OTG host channel 14 DMA address register
    \ Address offset: 0x6D4
    \ Reset value: 0x00000000
    \
    $00 constant OTG_HS_DMAADDR                 \ [0x00 : 32] DMA address This field holds the start address in the external memory from which the data for the endpoint must be fetched or to which it must be stored. This register is incremented on every AHB transaction.
  [then]


  [ifdef] OTG_HS_HCCHAR15_DEF
    \
    \ @brief OTG host channel 15 characteristics register
    \ Address offset: 0x6E0
    \ Reset value: 0x00000000
    \
    $00 constant OTG_HS_MPSIZ                   \ [0x00 : 11] MPSIZ
    $0b constant OTG_HS_EPNUM                   \ [0x0b : 4] EPNUM
    $0f constant OTG_HS_EPDIR                   \ [0x0f] EPDIR
    $11 constant OTG_HS_LSDEV                   \ [0x11] LSDEV
    $12 constant OTG_HS_EPTYP                   \ [0x12 : 2] EPTYP
    $14 constant OTG_HS_MCNT                    \ [0x14 : 2] MCNT
    $16 constant OTG_HS_DAD                     \ [0x16 : 7] DAD
    $1d constant OTG_HS_ODDFRM                  \ [0x1d] ODDFRM
    $1e constant OTG_HS_CHDIS                   \ [0x1e] CHDIS
    $1f constant OTG_HS_CHENA                   \ [0x1f] CHENA
  [then]


  [ifdef] OTG_HS_HCSPLT15_DEF
    \
    \ @brief OTG host channel 15 split control register
    \ Address offset: 0x6E4
    \ Reset value: 0x00000000
    \
    $00 constant OTG_HS_PRTADDR                 \ [0x00 : 7] Port address This field is the port number of the recipient transaction translator.
    $07 constant OTG_HS_HUBADDR                 \ [0x07 : 7] Hub address This field holds the device address of the transaction translatorâs hub.
    $0e constant OTG_HS_XACTPOS                 \ [0x0e : 2] Transaction position This field is used to determine whether to send all, first, middle, or last payloads with each OUT transaction.
    $10 constant OTG_HS_COMPLSPLT               \ [0x10] Do complete split The application sets this bit to request the OTG host to perform a complete split transaction.
    $1f constant OTG_HS_SPLITEN                 \ [0x1f] Split enable The application sets this bit to indicate that this channel is enabled to perform split transactions.
  [then]


  [ifdef] OTG_HS_HCINT15_DEF
    \
    \ @brief This register indicates the status of a channel with respect to USB- and AHB-related events. It is shown in Figure724. The application must read this register when the host channels interrupt bit in the core interrupt register (HCINT bit in GINTSTS) is set. Before the application can read this register, it must first read the host all channels interrupt (HAINT) register to get the exact channel number for the host channel-x interrupt register. The application must clear the appropriate bit in this register to clear the corresponding bits in the HAINT and GINTSTS registers.
    \ Address offset: 0x6E8
    \ Reset value: 0x00000000
    \
    $00 constant OTG_HS_XFRC                    \ [0x00] XFRC
    $01 constant OTG_HS_CHH                     \ [0x01] CHH
    $03 constant OTG_HS_STALL                   \ [0x03] STALL
    $04 constant OTG_HS_NAK                     \ [0x04] NAK
    $05 constant OTG_HS_ACK                     \ [0x05] ACK
    $07 constant OTG_HS_TXERR                   \ [0x07] TXERR
    $08 constant OTG_HS_BBERR                   \ [0x08] BBERR
    $09 constant OTG_HS_FRMOR                   \ [0x09] FRMOR
    $0a constant OTG_HS_DTERR                   \ [0x0a] DTERR
  [then]


  [ifdef] OTG_HS_HCINTMSK15_DEF
    \
    \ @brief This register reflects the mask for each channel status described in the previous section.
    \ Address offset: 0x6EC
    \ Reset value: 0x00000000
    \
    $00 constant OTG_HS_XFRCM                   \ [0x00] XFRCM
    $01 constant OTG_HS_CHHM                    \ [0x01] CHHM
    $03 constant OTG_HS_STALLM                  \ [0x03] STALLM
    $04 constant OTG_HS_NAKM                    \ [0x04] NAKM
    $05 constant OTG_HS_ACKM                    \ [0x05] ACKM
    $07 constant OTG_HS_TXERRM                  \ [0x07] TXERRM
    $08 constant OTG_HS_BBERRM                  \ [0x08] BBERRM
    $09 constant OTG_HS_FRMORM                  \ [0x09] FRMORM
    $0a constant OTG_HS_DTERRM                  \ [0x0a] DTERRM
  [then]


  [ifdef] OTG_HS_HCTSIZ15_DEF
    \
    \ @brief OTG host channel 15 transfer size register
    \ Address offset: 0x6F0
    \ Reset value: 0x00000000
    \
    $00 constant OTG_HS_XFRSIZ                  \ [0x00 : 19] XFRSIZ
    $13 constant OTG_HS_PKTCNT                  \ [0x13 : 10] PKTCNT
    $1d constant OTG_HS_DPID                    \ [0x1d : 2] DPID
    $1f constant OTG_HS_DOPNG                   \ [0x1f] DOPNG
  [then]


  [ifdef] OTG_HS_HCDMA15_DEF
    \
    \ @brief OTG host channel 15 DMA address register
    \ Address offset: 0x6F4
    \ Reset value: 0x00000000
    \
    $00 constant OTG_HS_DMAADDR                 \ [0x00 : 32] DMA address This field holds the start address in the external memory from which the data for the endpoint must be fetched or to which it must be stored. This register is incremented on every AHB transaction.
  [then]


  [ifdef] OTG_HS_DCFG_DEF
    \
    \ @brief This register configures the core in device mode after power-on or after certain control commands or enumeration. Do not make changes to this register after initial programming.
    \ Address offset: 0x800
    \ Reset value: 0x02200000
    \
    $00 constant OTG_HS_DSPD                    \ [0x00 : 2] DSPD
    $02 constant OTG_HS_NZLSOHSK                \ [0x02] NZLSOHSK
    $04 constant OTG_HS_DAD                     \ [0x04 : 7] DAD
    $0b constant OTG_HS_PFIVL                   \ [0x0b : 2] PFIVL
    $0f constant OTG_HS_ERRATIM                 \ [0x0f] ERRATIM
  [then]


  [ifdef] OTG_HS_DCTL_DEF
    \
    \ @brief OTG device control register
    \ Address offset: 0x804
    \ Reset value: 0x00000002
    \
    $00 constant OTG_HS_RWUSIG                  \ [0x00] RWUSIG
    $01 constant OTG_HS_SDIS                    \ [0x01] SDIS
    $02 constant OTG_HS_GINSTS                  \ [0x02] GINSTS
    $03 constant OTG_HS_GONSTS                  \ [0x03] GONSTS
    $04 constant OTG_HS_TCTL                    \ [0x04 : 3] TCTL
    $07 constant OTG_HS_SGINAK                  \ [0x07] SGINAK
    $08 constant OTG_HS_CGINAK                  \ [0x08] CGINAK
    $09 constant OTG_HS_SGONAK                  \ [0x09] SGONAK
    $0a constant OTG_HS_CGONAK                  \ [0x0a] CGONAK
    $0b constant OTG_HS_POPRGDNE                \ [0x0b] POPRGDNE
    $12 constant OTG_HS_DSBESLRJCT              \ [0x12] DSBESLRJCT
  [then]


  [ifdef] OTG_HS_DSTS_DEF
    \
    \ @brief This register indicates the status of the core with respect to USB-related events. It must be read on interrupts from the device all interrupts (DAINT) register.
    \ Address offset: 0x808
    \ Reset value: 0x00000010
    \
    $00 constant OTG_HS_SUSPSTS                 \ [0x00] SUSPSTS
    $01 constant OTG_HS_ENUMSPD                 \ [0x01 : 2] ENUMSPD
    $03 constant OTG_HS_EERR                    \ [0x03] EERR
    $08 constant OTG_HS_FNSOF                   \ [0x08 : 14] FNSOF
    $16 constant OTG_HS_DEVLNSTS                \ [0x16 : 2] DEVLNSTS
  [then]


  [ifdef] OTG_HS_DIEPMSK_DEF
    \
    \ @brief This register works with each of the DIEPINTx registers for all endpoints to generate an interrupt per IN endpoint. The IN endpoint interrupt for a specific status in the DIEPINTx register can be masked by writing to the corresponding bit in this register. Status bits are masked by default.
    \ Address offset: 0x810
    \ Reset value: 0x00000000
    \
    $00 constant OTG_HS_XFRCM                   \ [0x00] XFRCM
    $01 constant OTG_HS_EPDM                    \ [0x01] EPDM
    $02 constant OTG_HS_AHBERRM                 \ [0x02] AHBERRM
    $03 constant OTG_HS_TOM                     \ [0x03] TOM
    $04 constant OTG_HS_ITTXFEMSK               \ [0x04] ITTXFEMSK
    $05 constant OTG_HS_INEPNMM                 \ [0x05] INEPNMM
    $06 constant OTG_HS_INEPNEM                 \ [0x06] INEPNEM
    $08 constant OTG_HS_TXFURM                  \ [0x08] TXFURM
    $0d constant OTG_HS_NAKM                    \ [0x0d] NAKM
  [then]


  [ifdef] OTG_HS_DOEPMSK_DEF
    \
    \ @brief This register works with each of the DOEPINTx registers for all endpoints to generate an interrupt per OUT endpoint. The OUT endpoint interrupt for a specific status in the DOEPINTx register can be masked by writing into the corresponding bit in this register. Status bits are masked by default.
    \ Address offset: 0x814
    \ Reset value: 0x00000000
    \
    $00 constant OTG_HS_XFRCM                   \ [0x00] XFRCM
    $01 constant OTG_HS_EPDM                    \ [0x01] EPDM
    $02 constant OTG_HS_AHBERRM                 \ [0x02] AHBERRM
    $03 constant OTG_HS_STUPM                   \ [0x03] STUPM
    $04 constant OTG_HS_OTEPDM                  \ [0x04] OTEPDM
    $05 constant OTG_HS_STSPHSRXM               \ [0x05] STSPHSRXM
    $06 constant OTG_HS_B2BSTUPM                \ [0x06] B2BSTUPM
    $08 constant OTG_HS_OUTPKTERRM              \ [0x08] OUTPKTERRM
    $0c constant OTG_HS_BERRM                   \ [0x0c] BERRM
    $0d constant OTG_HS_NAKMSK                  \ [0x0d] NAKMSK
    $0e constant OTG_HS_NYETMSK                 \ [0x0e] NYETMSK
  [then]


  [ifdef] OTG_HS_DAINT_DEF
    \
    \ @brief When a significant event occurs on an endpoint, a DAINT register interrupts the application using the device OUT endpoints interrupt bit or device IN endpoints interrupt bit of the GINTSTS register (OEPINT or IEPINT in GINTSTS, respectively). There is one interrupt bit per endpoint, up to a maximum of 16 bits for OUT endpoints and 16 bits for IN endpoints. For a bidirectional endpoint, the corresponding IN and OUT interrupt bits are used. Bits in this register are set and cleared when the application sets and clears bits in the corresponding device endpoint-x interrupt register (DIEPINTx/DOEPINTx).
    \ Address offset: 0x818
    \ Reset value: 0x00000000
    \
    $00 constant OTG_HS_IEPINT                  \ [0x00 : 16] IEPINT
    $10 constant OTG_HS_OEPINT                  \ [0x10 : 16] OEPINT
  [then]


  [ifdef] OTG_HS_DAINTMSK_DEF
    \
    \ @brief The DAINTMSK register works with the device endpoint interrupt register to interrupt the application when an event occurs on a device endpoint. However, the DAINT register bit corresponding to that interrupt is still set.
    \ Address offset: 0x81C
    \ Reset value: 0x00000000
    \
    $00 constant OTG_HS_IEPM                    \ [0x00 : 16] IEPM
    $10 constant OTG_HS_OEPM                    \ [0x10 : 16] OEPM
  [then]


  [ifdef] OTG_HS_DVBUSDIS_DEF
    \
    \ @brief This register specifies the VBUS discharge time after VBUS pulsing during SRP.
    \ Address offset: 0x828
    \ Reset value: 0x000017D7
    \
    $00 constant OTG_HS_VBUSDT                  \ [0x00 : 16] VBUSDT
  [then]


  [ifdef] OTG_HS_DVBUSPULSE_DEF
    \
    \ @brief This register specifies the VBUS pulsing time during SRP.
    \ Address offset: 0x82C
    \ Reset value: 0x000005B8
    \
    $00 constant OTG_HS_DVBUSP                  \ [0x00 : 16] DVBUSP
  [then]


  [ifdef] OTG_HS_DTHRCTL_DEF
    \
    \ @brief OTG device threshold control register
    \ Address offset: 0x830
    \ Reset value: 0x00000000
    \
    $00 constant OTG_HS_NONISOTHREN             \ [0x00] Nonisochronous IN endpoints threshold enable When this bit is set, the core enables thresholding for nonisochronous IN endpoints.
    $01 constant OTG_HS_ISOTHREN                \ [0x01] ISO IN endpoint threshold enable When this bit is set, the core enables thresholding for isochronous IN endpoints.
    $02 constant OTG_HS_TXTHRLEN                \ [0x02 : 9] Transmit threshold length This field specifies the transmit thresholding size in 32-bit words. This field specifies the amount of data in bytes to be in the corresponding endpoint transmit FIFO, before the core can start transmitting on the USB. The threshold length has to be at least eight 32-bit words. This field controls both isochronous and nonisochronous IN endpoint thresholds. The recommended value for TXTHRLEN is to be the same as the programmed AHB burst length (HBSTLEN bit in OTG_GAHBCFG).
    $10 constant OTG_HS_RXTHREN                 \ [0x10] Receive threshold enable When this bit is set, the core enables thresholding in the receive direction.
    $11 constant OTG_HS_RXTHRLEN                \ [0x11 : 9] Receive threshold length This field specifies the receive thresholding size in 32-bit words. This field also specifies the amount of data received on the USB before the core can start transmitting on the AHB. The threshold length has to be at least eight 32-bit words. The recommended value for RXTHRLEN is to be the same as the programmed AHB burst length (HBSTLEN bit in OTG_GAHBCFG).
    $1b constant OTG_HS_ARPEN                   \ [0x1b] Arbiter parking enable This bit controls internal DMA arbiter parking for IN endpoints. When thresholding is enabled and this bit is set to one, then the arbiter parks on the IN endpoint for which there is a token received on the USB. This is done to avoid getting into underrun conditions. By default parking is enabled.
  [then]


  [ifdef] OTG_HS_DIEPEMPMSK_DEF
    \
    \ @brief This register is used to control the IN endpoint FIFO empty interrupt generation (TXFE_DIEPINTx).
    \ Address offset: 0x834
    \ Reset value: 0x00000000
    \
    $00 constant OTG_HS_INEPTXFEM               \ [0x00 : 16] INEPTXFEM
  [then]


  [ifdef] OTG_HS_HS_DOEPEACHMSK1_DEF
    \
    \ @brief OTG device each OUT endpoint-1 interrupt mask register
    \ Address offset: 0x884
    \ Reset value: 0x00000000
    \
    $00 constant OTG_HS_XFRCM                   \ [0x00] XFRCM
    $01 constant OTG_HS_EPDM                    \ [0x01] EPDM
    $02 constant OTG_HS_AHBERRM                 \ [0x02] AHBERRM
    $03 constant OTG_HS_STUPM                   \ [0x03] STUPM
    $04 constant OTG_HS_OTEPDM                  \ [0x04] OTEPDM
    $06 constant OTG_HS_B2BSTUPM                \ [0x06] B2BSTUPM
    $08 constant OTG_HS_OUTPKTERRM              \ [0x08] OUTPKTERRM
    $09 constant OTG_HS_BNAM                    \ [0x09] BNAM
    $0c constant OTG_HS_BERRM                   \ [0x0c] BERRM
    $0d constant OTG_HS_NAKMSK                  \ [0x0d] NAKMSK
    $0e constant OTG_HS_NYETMSK                 \ [0x0e] NYETMSK
  [then]


  [ifdef] OTG_HS_DIEPCTL0_DEF
    \
    \ @brief The application uses this register to control the behavior of each logical endpoint other than endpoint 0.
    \ Address offset: 0x900
    \ Reset value: 0x00000000
    \
    $00 constant OTG_HS_MPSIZ                   \ [0x00 : 2] MPSIZ
    $0f constant OTG_HS_USBAEP                  \ [0x0f] USBAEP
    $11 constant OTG_HS_NAKSTS                  \ [0x11] NAKSTS
    $12 constant OTG_HS_EPTYP                   \ [0x12 : 2] EPTYP
    $15 constant OTG_HS_STALL                   \ [0x15] STALL
    $16 constant OTG_HS_TXFNUM                  \ [0x16 : 4] TXFNUM
    $1a constant OTG_HS_CNAK                    \ [0x1a] CNAK
    $1b constant OTG_HS_SNAK                    \ [0x1b] SNAK
    $1e constant OTG_HS_EPDIS                   \ [0x1e] EPDIS
    $1f constant OTG_HS_EPENA                   \ [0x1f] EPENA
  [then]


  [ifdef] OTG_HS_DIEPINT0_DEF
    \
    \ @brief This register indicates the status of an endpoint with respect to USB- and AHB-related events. It is shown in Figure724. The application must read this register when the IN endpoints interrupt bit of the core interrupt register (IEPINT in GINTSTS) is set. Before the application can read this register, it must first read the device all endpoints interrupt (DAINT) register to get the exact endpoint number for the device endpoint-x interrupt register. The application must clear the appropriate bit in this register to clear the corresponding bits in the DAINT and GINTSTS registers.
    \ Address offset: 0x908
    \ Reset value: 0x00000080
    \
    $00 constant OTG_HS_XFRC                    \ [0x00] XFRC
    $01 constant OTG_HS_EPDISD                  \ [0x01] EPDISD
    $03 constant OTG_HS_TOC                     \ [0x03] TOC
    $04 constant OTG_HS_ITTXFE                  \ [0x04] ITTXFE
    $05 constant OTG_HS_INEPNM                  \ [0x05] INEPNM
    $06 constant OTG_HS_INEPNE                  \ [0x06] INEPNE
    $07 constant OTG_HS_TXFE                    \ [0x07] TXFE
    $0b constant OTG_HS_PKTDRPSTS               \ [0x0b] PKTDRPSTS
    $0d constant OTG_HS_NAK                     \ [0x0d] NAK
  [then]


  [ifdef] OTG_HS_DIEPTSIZ0_DEF
    \
    \ @brief The application must modify this register before enabling endpoint 0.
    \ Address offset: 0x910
    \ Reset value: 0x00000000
    \
    $00 constant OTG_HS_XFRSIZ                  \ [0x00 : 7] XFRSIZ
    $13 constant OTG_HS_PKTCNT                  \ [0x13 : 2] PKTCNT
  [then]


  [ifdef] OTG_HS_DTXFSTS0_DEF
    \
    \ @brief This read-only register contains the free space information for the device IN endpoint Tx FIFO.
    \ Address offset: 0x918
    \ Reset value: 0x00000200
    \
    $00 constant OTG_HS_INEPTFSAV               \ [0x00 : 16] INEPTFSAV
  [then]


  [ifdef] OTG_HS_DIEPCTL1_DEF
    \
    \ @brief The application uses this register to control the behavior of each logical endpoint other than endpoint 0.
    \ Address offset: 0x920
    \ Reset value: 0x00000000
    \
    $00 constant OTG_HS_MPSIZ                   \ [0x00 : 11] MPSIZ
    $0f constant OTG_HS_USBAEP                  \ [0x0f] USBAEP
    $10 constant OTG_HS_EONUM_DPIP              \ [0x10] EONUM_DPIP
    $11 constant OTG_HS_NAKSTS                  \ [0x11] NAKSTS
    $12 constant OTG_HS_EPTYP                   \ [0x12 : 2] EPTYP
    $15 constant OTG_HS_STALL                   \ [0x15] STALL
    $16 constant OTG_HS_TXFNUM                  \ [0x16 : 4] TXFNUM
    $1a constant OTG_HS_CNAK                    \ [0x1a] CNAK
    $1b constant OTG_HS_SNAK                    \ [0x1b] SNAK
    $1c constant OTG_HS_SD0PID_SEVNFRM          \ [0x1c] SD0PID_SEVNFRM
    $1d constant OTG_HS_SODDFRM                 \ [0x1d] SODDFRM
    $1e constant OTG_HS_EPDIS                   \ [0x1e] EPDIS
    $1f constant OTG_HS_EPENA                   \ [0x1f] EPENA
  [then]


  [ifdef] OTG_HS_DIEPINT1_DEF
    \
    \ @brief This register indicates the status of an endpoint with respect to USB- and AHB-related events. It is shown in Figure724. The application must read this register when the IN endpoints interrupt bit of the core interrupt register (IEPINT in GINTSTS) is set. Before the application can read this register, it must first read the device all endpoints interrupt (DAINT) register to get the exact endpoint number for the device endpoint-x interrupt register. The application must clear the appropriate bit in this register to clear the corresponding bits in the DAINT and GINTSTS registers.
    \ Address offset: 0x928
    \ Reset value: 0x00000080
    \
    $00 constant OTG_HS_XFRC                    \ [0x00] XFRC
    $01 constant OTG_HS_EPDISD                  \ [0x01] EPDISD
    $03 constant OTG_HS_TOC                     \ [0x03] TOC
    $04 constant OTG_HS_ITTXFE                  \ [0x04] ITTXFE
    $05 constant OTG_HS_INEPNM                  \ [0x05] INEPNM
    $06 constant OTG_HS_INEPNE                  \ [0x06] INEPNE
    $07 constant OTG_HS_TXFE                    \ [0x07] TXFE
    $0b constant OTG_HS_PKTDRPSTS               \ [0x0b] PKTDRPSTS
    $0d constant OTG_HS_NAK                     \ [0x0d] NAK
  [then]


  [ifdef] OTG_HS_DIEPTSIZ1_DEF
    \
    \ @brief The application must modify this register before enabling the endpoint. Once the endpoint is enabled using the endpoint enable bit in the DIEPCTLx registers (EPENA bit in DIEPCTLx), the core modifies this register. The application can only read this register once the core has cleared the endpoint enable bit.
    \ Address offset: 0x930
    \ Reset value: 0x00000000
    \
    $00 constant OTG_HS_XFRSIZ                  \ [0x00 : 19] XFRSIZ
    $13 constant OTG_HS_PKTCNT                  \ [0x13 : 10] PKTCNT
    $1d constant OTG_HS_MCNT                    \ [0x1d : 2] MCNT
  [then]


  [ifdef] OTG_HS_DIEPDMA1_DEF
    \
    \ @brief OTG device IN endpoint 1 DMA address register
    \ Address offset: 0x934
    \ Reset value: 0x00000000
    \
    $00 constant OTG_HS_DMAADDR                 \ [0x00 : 32] DMAADDR
  [then]


  [ifdef] OTG_HS_DTXFSTS1_DEF
    \
    \ @brief This read-only register contains the free space information for the device IN endpoint Tx FIFO.
    \ Address offset: 0x938
    \ Reset value: 0x00000200
    \
    $00 constant OTG_HS_INEPTFSAV               \ [0x00 : 16] INEPTFSAV
  [then]


  [ifdef] OTG_HS_DIEPCTL2_DEF
    \
    \ @brief The application uses this register to control the behavior of each logical endpoint other than endpoint 0.
    \ Address offset: 0x940
    \ Reset value: 0x00000000
    \
    $00 constant OTG_HS_MPSIZ                   \ [0x00 : 11] MPSIZ
    $0f constant OTG_HS_USBAEP                  \ [0x0f] USBAEP
    $10 constant OTG_HS_EONUM_DPIP              \ [0x10] EONUM_DPIP
    $11 constant OTG_HS_NAKSTS                  \ [0x11] NAKSTS
    $12 constant OTG_HS_EPTYP                   \ [0x12 : 2] EPTYP
    $15 constant OTG_HS_STALL                   \ [0x15] STALL
    $16 constant OTG_HS_TXFNUM                  \ [0x16 : 4] TXFNUM
    $1a constant OTG_HS_CNAK                    \ [0x1a] CNAK
    $1b constant OTG_HS_SNAK                    \ [0x1b] SNAK
    $1c constant OTG_HS_SD0PID_SEVNFRM          \ [0x1c] SD0PID_SEVNFRM
    $1d constant OTG_HS_SODDFRM                 \ [0x1d] SODDFRM
    $1e constant OTG_HS_EPDIS                   \ [0x1e] EPDIS
    $1f constant OTG_HS_EPENA                   \ [0x1f] EPENA
  [then]


  [ifdef] OTG_HS_DIEPINT2_DEF
    \
    \ @brief This register indicates the status of an endpoint with respect to USB- and AHB-related events. It is shown in Figure724. The application must read this register when the IN endpoints interrupt bit of the core interrupt register (IEPINT in GINTSTS) is set. Before the application can read this register, it must first read the device all endpoints interrupt (DAINT) register to get the exact endpoint number for the device endpoint-x interrupt register. The application must clear the appropriate bit in this register to clear the corresponding bits in the DAINT and GINTSTS registers.
    \ Address offset: 0x948
    \ Reset value: 0x00000080
    \
    $00 constant OTG_HS_XFRC                    \ [0x00] XFRC
    $01 constant OTG_HS_EPDISD                  \ [0x01] EPDISD
    $03 constant OTG_HS_TOC                     \ [0x03] TOC
    $04 constant OTG_HS_ITTXFE                  \ [0x04] ITTXFE
    $05 constant OTG_HS_INEPNM                  \ [0x05] INEPNM
    $06 constant OTG_HS_INEPNE                  \ [0x06] INEPNE
    $07 constant OTG_HS_TXFE                    \ [0x07] TXFE
    $0b constant OTG_HS_PKTDRPSTS               \ [0x0b] PKTDRPSTS
    $0d constant OTG_HS_NAK                     \ [0x0d] NAK
  [then]


  [ifdef] OTG_HS_DIEPTSIZ2_DEF
    \
    \ @brief The application must modify this register before enabling the endpoint. Once the endpoint is enabled using the endpoint enable bit in the DIEPCTLx registers (EPENA bit in DIEPCTLx), the core modifies this register. The application can only read this register once the core has cleared the endpoint enable bit.
    \ Address offset: 0x950
    \ Reset value: 0x00000000
    \
    $00 constant OTG_HS_XFRSIZ                  \ [0x00 : 19] XFRSIZ
    $13 constant OTG_HS_PKTCNT                  \ [0x13 : 10] PKTCNT
    $1d constant OTG_HS_MCNT                    \ [0x1d : 2] MCNT
  [then]


  [ifdef] OTG_HS_DIEPDMA2_DEF
    \
    \ @brief OTG device IN endpoint 2 DMA address register
    \ Address offset: 0x954
    \ Reset value: 0x00000000
    \
    $00 constant OTG_HS_DMAADDR                 \ [0x00 : 32] DMAADDR
  [then]


  [ifdef] OTG_HS_DTXFSTS2_DEF
    \
    \ @brief This read-only register contains the free space information for the device IN endpoint Tx FIFO.
    \ Address offset: 0x958
    \ Reset value: 0x00000200
    \
    $00 constant OTG_HS_INEPTFSAV               \ [0x00 : 16] INEPTFSAV
  [then]


  [ifdef] OTG_HS_DIEPCTL3_DEF
    \
    \ @brief The application uses this register to control the behavior of each logical endpoint other than endpoint 0.
    \ Address offset: 0x960
    \ Reset value: 0x00000000
    \
    $00 constant OTG_HS_MPSIZ                   \ [0x00 : 11] MPSIZ
    $0f constant OTG_HS_USBAEP                  \ [0x0f] USBAEP
    $10 constant OTG_HS_EONUM_DPIP              \ [0x10] EONUM_DPIP
    $11 constant OTG_HS_NAKSTS                  \ [0x11] NAKSTS
    $12 constant OTG_HS_EPTYP                   \ [0x12 : 2] EPTYP
    $15 constant OTG_HS_STALL                   \ [0x15] STALL
    $16 constant OTG_HS_TXFNUM                  \ [0x16 : 4] TXFNUM
    $1a constant OTG_HS_CNAK                    \ [0x1a] CNAK
    $1b constant OTG_HS_SNAK                    \ [0x1b] SNAK
    $1c constant OTG_HS_SD0PID_SEVNFRM          \ [0x1c] SD0PID_SEVNFRM
    $1d constant OTG_HS_SODDFRM                 \ [0x1d] SODDFRM
    $1e constant OTG_HS_EPDIS                   \ [0x1e] EPDIS
    $1f constant OTG_HS_EPENA                   \ [0x1f] EPENA
  [then]


  [ifdef] OTG_HS_DIEPINT3_DEF
    \
    \ @brief This register indicates the status of an endpoint with respect to USB- and AHB-related events. It is shown in Figure724. The application must read this register when the IN endpoints interrupt bit of the core interrupt register (IEPINT in GINTSTS) is set. Before the application can read this register, it must first read the device all endpoints interrupt (DAINT) register to get the exact endpoint number for the device endpoint-x interrupt register. The application must clear the appropriate bit in this register to clear the corresponding bits in the DAINT and GINTSTS registers.
    \ Address offset: 0x968
    \ Reset value: 0x00000080
    \
    $00 constant OTG_HS_XFRC                    \ [0x00] XFRC
    $01 constant OTG_HS_EPDISD                  \ [0x01] EPDISD
    $03 constant OTG_HS_TOC                     \ [0x03] TOC
    $04 constant OTG_HS_ITTXFE                  \ [0x04] ITTXFE
    $05 constant OTG_HS_INEPNM                  \ [0x05] INEPNM
    $06 constant OTG_HS_INEPNE                  \ [0x06] INEPNE
    $07 constant OTG_HS_TXFE                    \ [0x07] TXFE
    $0b constant OTG_HS_PKTDRPSTS               \ [0x0b] PKTDRPSTS
    $0d constant OTG_HS_NAK                     \ [0x0d] NAK
  [then]


  [ifdef] OTG_HS_DIEPTSIZ3_DEF
    \
    \ @brief The application must modify this register before enabling the endpoint. Once the endpoint is enabled using the endpoint enable bit in the DIEPCTLx registers (EPENA bit in DIEPCTLx), the core modifies this register. The application can only read this register once the core has cleared the endpoint enable bit.
    \ Address offset: 0x970
    \ Reset value: 0x00000000
    \
    $00 constant OTG_HS_XFRSIZ                  \ [0x00 : 19] XFRSIZ
    $13 constant OTG_HS_PKTCNT                  \ [0x13 : 10] PKTCNT
    $1d constant OTG_HS_MCNT                    \ [0x1d : 2] MCNT
  [then]


  [ifdef] OTG_HS_DIEPDMA3_DEF
    \
    \ @brief OTG device IN endpoint 3 DMA address register
    \ Address offset: 0x974
    \ Reset value: 0x00000000
    \
    $00 constant OTG_HS_DMAADDR                 \ [0x00 : 32] DMAADDR
  [then]


  [ifdef] OTG_HS_DTXFSTS3_DEF
    \
    \ @brief This read-only register contains the free space information for the device IN endpoint Tx FIFO.
    \ Address offset: 0x978
    \ Reset value: 0x00000200
    \
    $00 constant OTG_HS_INEPTFSAV               \ [0x00 : 16] INEPTFSAV
  [then]


  [ifdef] OTG_HS_DIEPCTL4_DEF
    \
    \ @brief The application uses this register to control the behavior of each logical endpoint other than endpoint 0.
    \ Address offset: 0x980
    \ Reset value: 0x00000000
    \
    $00 constant OTG_HS_MPSIZ                   \ [0x00 : 11] MPSIZ
    $0f constant OTG_HS_USBAEP                  \ [0x0f] USBAEP
    $10 constant OTG_HS_EONUM_DPIP              \ [0x10] EONUM_DPIP
    $11 constant OTG_HS_NAKSTS                  \ [0x11] NAKSTS
    $12 constant OTG_HS_EPTYP                   \ [0x12 : 2] EPTYP
    $15 constant OTG_HS_STALL                   \ [0x15] STALL
    $16 constant OTG_HS_TXFNUM                  \ [0x16 : 4] TXFNUM
    $1a constant OTG_HS_CNAK                    \ [0x1a] CNAK
    $1b constant OTG_HS_SNAK                    \ [0x1b] SNAK
    $1c constant OTG_HS_SD0PID_SEVNFRM          \ [0x1c] SD0PID_SEVNFRM
    $1d constant OTG_HS_SODDFRM                 \ [0x1d] SODDFRM
    $1e constant OTG_HS_EPDIS                   \ [0x1e] EPDIS
    $1f constant OTG_HS_EPENA                   \ [0x1f] EPENA
  [then]


  [ifdef] OTG_HS_DIEPINT4_DEF
    \
    \ @brief This register indicates the status of an endpoint with respect to USB- and AHB-related events. It is shown in Figure724. The application must read this register when the IN endpoints interrupt bit of the core interrupt register (IEPINT in GINTSTS) is set. Before the application can read this register, it must first read the device all endpoints interrupt (DAINT) register to get the exact endpoint number for the device endpoint-x interrupt register. The application must clear the appropriate bit in this register to clear the corresponding bits in the DAINT and GINTSTS registers.
    \ Address offset: 0x988
    \ Reset value: 0x00000080
    \
    $00 constant OTG_HS_XFRC                    \ [0x00] XFRC
    $01 constant OTG_HS_EPDISD                  \ [0x01] EPDISD
    $03 constant OTG_HS_TOC                     \ [0x03] TOC
    $04 constant OTG_HS_ITTXFE                  \ [0x04] ITTXFE
    $05 constant OTG_HS_INEPNM                  \ [0x05] INEPNM
    $06 constant OTG_HS_INEPNE                  \ [0x06] INEPNE
    $07 constant OTG_HS_TXFE                    \ [0x07] TXFE
    $0b constant OTG_HS_PKTDRPSTS               \ [0x0b] PKTDRPSTS
    $0d constant OTG_HS_NAK                     \ [0x0d] NAK
  [then]


  [ifdef] OTG_HS_DIEPTSIZ4_DEF
    \
    \ @brief The application must modify this register before enabling the endpoint. Once the endpoint is enabled using the endpoint enable bit in the DIEPCTLx registers (EPENA bit in DIEPCTLx), the core modifies this register. The application can only read this register once the core has cleared the endpoint enable bit.
    \ Address offset: 0x990
    \ Reset value: 0x00000000
    \
    $00 constant OTG_HS_XFRSIZ                  \ [0x00 : 19] XFRSIZ
    $13 constant OTG_HS_PKTCNT                  \ [0x13 : 10] PKTCNT
    $1d constant OTG_HS_MCNT                    \ [0x1d : 2] MCNT
  [then]


  [ifdef] OTG_HS_DIEPDMA4_DEF
    \
    \ @brief OTG device IN endpoint 4 DMA address register
    \ Address offset: 0x994
    \ Reset value: 0x00000000
    \
    $00 constant OTG_HS_DMAADDR                 \ [0x00 : 32] DMAADDR
  [then]


  [ifdef] OTG_HS_DTXFSTS4_DEF
    \
    \ @brief This read-only register contains the free space information for the device IN endpoint Tx FIFO.
    \ Address offset: 0x998
    \ Reset value: 0x00000200
    \
    $00 constant OTG_HS_INEPTFSAV               \ [0x00 : 16] INEPTFSAV
  [then]


  [ifdef] OTG_HS_DIEPCTL5_DEF
    \
    \ @brief The application uses this register to control the behavior of each logical endpoint other than endpoint 0.
    \ Address offset: 0x9A0
    \ Reset value: 0x00000000
    \
    $00 constant OTG_HS_MPSIZ                   \ [0x00 : 11] MPSIZ
    $0f constant OTG_HS_USBAEP                  \ [0x0f] USBAEP
    $10 constant OTG_HS_EONUM_DPIP              \ [0x10] EONUM_DPIP
    $11 constant OTG_HS_NAKSTS                  \ [0x11] NAKSTS
    $12 constant OTG_HS_EPTYP                   \ [0x12 : 2] EPTYP
    $15 constant OTG_HS_STALL                   \ [0x15] STALL
    $16 constant OTG_HS_TXFNUM                  \ [0x16 : 4] TXFNUM
    $1a constant OTG_HS_CNAK                    \ [0x1a] CNAK
    $1b constant OTG_HS_SNAK                    \ [0x1b] SNAK
    $1c constant OTG_HS_SD0PID_SEVNFRM          \ [0x1c] SD0PID_SEVNFRM
    $1d constant OTG_HS_SODDFRM                 \ [0x1d] SODDFRM
    $1e constant OTG_HS_EPDIS                   \ [0x1e] EPDIS
    $1f constant OTG_HS_EPENA                   \ [0x1f] EPENA
  [then]


  [ifdef] OTG_HS_DIEPINT5_DEF
    \
    \ @brief This register indicates the status of an endpoint with respect to USB- and AHB-related events. It is shown in Figure724. The application must read this register when the IN endpoints interrupt bit of the core interrupt register (IEPINT in GINTSTS) is set. Before the application can read this register, it must first read the device all endpoints interrupt (DAINT) register to get the exact endpoint number for the device endpoint-x interrupt register. The application must clear the appropriate bit in this register to clear the corresponding bits in the DAINT and GINTSTS registers.
    \ Address offset: 0x9A8
    \ Reset value: 0x00000080
    \
    $00 constant OTG_HS_XFRC                    \ [0x00] XFRC
    $01 constant OTG_HS_EPDISD                  \ [0x01] EPDISD
    $03 constant OTG_HS_TOC                     \ [0x03] TOC
    $04 constant OTG_HS_ITTXFE                  \ [0x04] ITTXFE
    $05 constant OTG_HS_INEPNM                  \ [0x05] INEPNM
    $06 constant OTG_HS_INEPNE                  \ [0x06] INEPNE
    $07 constant OTG_HS_TXFE                    \ [0x07] TXFE
    $0b constant OTG_HS_PKTDRPSTS               \ [0x0b] PKTDRPSTS
    $0d constant OTG_HS_NAK                     \ [0x0d] NAK
  [then]


  [ifdef] OTG_HS_DIEPTSIZ5_DEF
    \
    \ @brief The application must modify this register before enabling the endpoint. Once the endpoint is enabled using the endpoint enable bit in the DIEPCTLx registers (EPENA bit in DIEPCTLx), the core modifies this register. The application can only read this register once the core has cleared the endpoint enable bit.
    \ Address offset: 0x9B0
    \ Reset value: 0x00000000
    \
    $00 constant OTG_HS_XFRSIZ                  \ [0x00 : 19] XFRSIZ
    $13 constant OTG_HS_PKTCNT                  \ [0x13 : 10] PKTCNT
    $1d constant OTG_HS_MCNT                    \ [0x1d : 2] MCNT
  [then]


  [ifdef] OTG_HS_DIEPDMA5_DEF
    \
    \ @brief OTG device IN endpoint 5 DMA address register
    \ Address offset: 0x9B4
    \ Reset value: 0x00000000
    \
    $00 constant OTG_HS_DMAADDR                 \ [0x00 : 32] DMAADDR
  [then]


  [ifdef] OTG_HS_DTXFSTS5_DEF
    \
    \ @brief This read-only register contains the free space information for the device IN endpoint Tx FIFO.
    \ Address offset: 0x9B8
    \ Reset value: 0x00000200
    \
    $00 constant OTG_HS_INEPTFSAV               \ [0x00 : 16] INEPTFSAV
  [then]


  [ifdef] OTG_HS_DIEPINT6_DEF
    \
    \ @brief This register indicates the status of an endpoint with respect to USB- and AHB-related events. It is shown in Figure724. The application must read this register when the IN endpoints interrupt bit of the core interrupt register (IEPINT in GINTSTS) is set. Before the application can read this register, it must first read the device all endpoints interrupt (DAINT) register to get the exact endpoint number for the device endpoint-x interrupt register. The application must clear the appropriate bit in this register to clear the corresponding bits in the DAINT and GINTSTS registers.
    \ Address offset: 0x9C8
    \ Reset value: 0x00000080
    \
    $00 constant OTG_HS_XFRC                    \ [0x00] XFRC
    $01 constant OTG_HS_EPDISD                  \ [0x01] EPDISD
    $02 constant OTG_HS_AHBERR                  \ [0x02] AHBERR
    $03 constant OTG_HS_TOC                     \ [0x03] TOC
    $04 constant OTG_HS_ITTXFE                  \ [0x04] ITTXFE
    $05 constant OTG_HS_INEPNM                  \ [0x05] INEPNM
    $06 constant OTG_HS_INEPNE                  \ [0x06] INEPNE
    $07 constant OTG_HS_TXFE                    \ [0x07] TXFE
    $08 constant OTG_HS_TXFIFOUDRN              \ [0x08] TXFIFOUDRN
    $09 constant OTG_HS_BNA                     \ [0x09] BNA
    $0b constant OTG_HS_PKTDRPSTS               \ [0x0b] PKTDRPSTS
    $0d constant OTG_HS_NAK                     \ [0x0d] NAK
  [then]


  [ifdef] OTG_HS_DIEPTSIZ6_DEF
    \
    \ @brief The application must modify this register before enabling the endpoint. Once the endpoint is enabled using the endpoint enable bit in the DIEPCTLx registers (EPENA bit in DIEPCTLx), the core modifies this register. The application can only read this register once the core has cleared the endpoint enable bit.
    \ Address offset: 0x9D0
    \ Reset value: 0x00000000
    \
    $00 constant OTG_HS_XFRSIZ                  \ [0x00 : 19] XFRSIZ
    $13 constant OTG_HS_PKTCNT                  \ [0x13 : 10] PKTCNT
    $1d constant OTG_HS_MCNT                    \ [0x1d : 2] MCNT
  [then]


  [ifdef] OTG_HS_DIEPDMA6_DEF
    \
    \ @brief OTG device IN endpoint 6 DMA address register
    \ Address offset: 0x9D4
    \ Reset value: 0x00000000
    \
    $00 constant OTG_HS_DMAADDR                 \ [0x00 : 32] DMAADDR
  [then]


  [ifdef] OTG_HS_DIEPINT7_DEF
    \
    \ @brief This register indicates the status of an endpoint with respect to USB- and AHB-related events. It is shown in Figure724. The application must read this register when the IN endpoints interrupt bit of the core interrupt register (IEPINT in GINTSTS) is set. Before the application can read this register, it must first read the device all endpoints interrupt (DAINT) register to get the exact endpoint number for the device endpoint-x interrupt register. The application must clear the appropriate bit in this register to clear the corresponding bits in the DAINT and GINTSTS registers.
    \ Address offset: 0x9E8
    \ Reset value: 0x00000080
    \
    $00 constant OTG_HS_XFRC                    \ [0x00] XFRC
    $01 constant OTG_HS_EPDISD                  \ [0x01] EPDISD
    $02 constant OTG_HS_AHBERR                  \ [0x02] AHBERR
    $03 constant OTG_HS_TOC                     \ [0x03] TOC
    $04 constant OTG_HS_ITTXFE                  \ [0x04] ITTXFE
    $05 constant OTG_HS_INEPNM                  \ [0x05] INEPNM
    $06 constant OTG_HS_INEPNE                  \ [0x06] INEPNE
    $07 constant OTG_HS_TXFE                    \ [0x07] TXFE
    $08 constant OTG_HS_TXFIFOUDRN              \ [0x08] TXFIFOUDRN
    $09 constant OTG_HS_BNA                     \ [0x09] BNA
    $0b constant OTG_HS_PKTDRPSTS               \ [0x0b] PKTDRPSTS
    $0d constant OTG_HS_NAK                     \ [0x0d] NAK
  [then]


  [ifdef] OTG_HS_DIEPTSIZ7_DEF
    \
    \ @brief The application must modify this register before enabling the endpoint. Once the endpoint is enabled using the endpoint enable bit in the DIEPCTLx registers (EPENA bit in DIEPCTLx), the core modifies this register. The application can only read this register once the core has cleared the endpoint enable bit.
    \ Address offset: 0x9F0
    \ Reset value: 0x00000000
    \
    $00 constant OTG_HS_XFRSIZ                  \ [0x00 : 19] XFRSIZ
    $13 constant OTG_HS_PKTCNT                  \ [0x13 : 10] PKTCNT
    $1d constant OTG_HS_MCNT                    \ [0x1d : 2] MCNT
  [then]


  [ifdef] OTG_HS_DIEPDMA7_DEF
    \
    \ @brief OTG device IN endpoint 7 DMA address register
    \ Address offset: 0x9F4
    \ Reset value: 0x00000000
    \
    $00 constant OTG_HS_DMAADDR                 \ [0x00 : 32] DMAADDR
  [then]


  [ifdef] OTG_HS_DIEPINT8_DEF
    \
    \ @brief This register indicates the status of an endpoint with respect to USB- and AHB-related events. It is shown in Figure724. The application must read this register when the IN endpoints interrupt bit of the core interrupt register (IEPINT in GINTSTS) is set. Before the application can read this register, it must first read the device all endpoints interrupt (DAINT) register to get the exact endpoint number for the device endpoint-x interrupt register. The application must clear the appropriate bit in this register to clear the corresponding bits in the DAINT and GINTSTS registers.
    \ Address offset: 0xA08
    \ Reset value: 0x00000080
    \
    $00 constant OTG_HS_XFRC                    \ [0x00] XFRC
    $01 constant OTG_HS_EPDISD                  \ [0x01] EPDISD
    $02 constant OTG_HS_AHBERR                  \ [0x02] AHBERR
    $03 constant OTG_HS_TOC                     \ [0x03] TOC
    $04 constant OTG_HS_ITTXFE                  \ [0x04] ITTXFE
    $05 constant OTG_HS_INEPNM                  \ [0x05] INEPNM
    $06 constant OTG_HS_INEPNE                  \ [0x06] INEPNE
    $07 constant OTG_HS_TXFE                    \ [0x07] TXFE
    $08 constant OTG_HS_TXFIFOUDRN              \ [0x08] TXFIFOUDRN
    $09 constant OTG_HS_BNA                     \ [0x09] BNA
    $0b constant OTG_HS_PKTDRPSTS               \ [0x0b] PKTDRPSTS
    $0d constant OTG_HS_NAK                     \ [0x0d] NAK
  [then]


  [ifdef] OTG_HS_DIEPTSIZ8_DEF
    \
    \ @brief The application must modify this register before enabling the endpoint. Once the endpoint is enabled using the endpoint enable bit in the DIEPCTLx registers (EPENA bit in DIEPCTLx), the core modifies this register. The application can only read this register once the core has cleared the endpoint enable bit.
    \ Address offset: 0xA10
    \ Reset value: 0x00000000
    \
    $00 constant OTG_HS_XFRSIZ                  \ [0x00 : 19] XFRSIZ
    $13 constant OTG_HS_PKTCNT                  \ [0x13 : 10] PKTCNT
    $1d constant OTG_HS_MCNT                    \ [0x1d : 2] MCNT
  [then]


  [ifdef] OTG_HS_DIEPDMA8_DEF
    \
    \ @brief OTG device IN endpoint 8 DMA address register
    \ Address offset: 0xA14
    \ Reset value: 0x00000000
    \
    $00 constant OTG_HS_DMAADDR                 \ [0x00 : 32] DMAADDR
  [then]


  [ifdef] OTG_HS_DOEPCTL0_DEF
    \
    \ @brief This section describes the DOEPCTL0 register.
    \ Address offset: 0xB00
    \ Reset value: 0x00008000
    \
    $00 constant OTG_HS_MPSIZ                   \ [0x00 : 2] MPSIZ
    $0f constant OTG_HS_USBAEP                  \ [0x0f] USBAEP
    $11 constant OTG_HS_NAKSTS                  \ [0x11] NAKSTS
    $12 constant OTG_HS_EPTYP                   \ [0x12 : 2] EPTYP
    $14 constant OTG_HS_SNPM                    \ [0x14] SNPM
    $15 constant OTG_HS_STALL                   \ [0x15] STALL
    $1a constant OTG_HS_CNAK                    \ [0x1a] CNAK
    $1b constant OTG_HS_SNAK                    \ [0x1b] SNAK
    $1e constant OTG_HS_EPDIS                   \ [0x1e] EPDIS
    $1f constant OTG_HS_EPENA                   \ [0x1f] EPENA
  [then]


  [ifdef] OTG_HS_DOEPINT0_DEF
    \
    \ @brief This register indicates the status of an endpoint with respect to USB- and AHB-related events. It is shown in Figure724. The application must read this register when the OUT endpoints interrupt bit of the GINTSTS register (OEPINT bit in GINTSTS) is set. Before the application can read this register, it must first read the DAINT register to get the exact endpoint number for the DOEPINTx register. The application must clear the appropriate bit in this register to clear the corresponding bits in the DAINT and GINTSTS registers.
    \ Address offset: 0xB08
    \ Reset value: 0x00000080
    \
    $00 constant OTG_HS_XFRC                    \ [0x00] XFRC
    $01 constant OTG_HS_EPDISD                  \ [0x01] EPDISD
    $02 constant OTG_HS_AHBERR                  \ [0x02] AHBERR
    $03 constant OTG_HS_STUP                    \ [0x03] STUP
    $04 constant OTG_HS_OTEPDIS                 \ [0x04] OTEPDIS
    $05 constant OTG_HS_STSPHSRX                \ [0x05] STSPHSRX
    $06 constant OTG_HS_B2BSTUP                 \ [0x06] B2BSTUP
    $08 constant OTG_HS_OUTPKTERR               \ [0x08] OUTPKTERR
    $09 constant OTG_HS_BNA                     \ [0x09] BNA
    $0c constant OTG_HS_BERR                    \ [0x0c] BERR
    $0d constant OTG_HS_NAK                     \ [0x0d] NAK
    $0e constant OTG_HS_NYET                    \ [0x0e] NYET
    $0f constant OTG_HS_STPKTRX                 \ [0x0f] STPKTRX
  [then]


  [ifdef] OTG_HS_DOEPTSIZ0_DEF
    \
    \ @brief The application must modify this register before enabling endpoint 0.
    \ Address offset: 0xB10
    \ Reset value: 0x00000000
    \
    $00 constant OTG_HS_XFRSIZ                  \ [0x00 : 7] XFRSIZ
    $13 constant OTG_HS_PKTCNT                  \ [0x13] PKTCNT
    $1d constant OTG_HS_STUPCNT                 \ [0x1d : 2] STUPCNT
  [then]


  [ifdef] OTG_HS_DOEPDMA0_DEF
    \
    \ @brief OTG device OUT endpoint 0 DMA address register
    \ Address offset: 0xB14
    \ Reset value: 0x00000000
    \
    $00 constant OTG_HS_DMAADDR                 \ [0x00 : 32] DMAADDR
  [then]


  [ifdef] OTG_HS_DOEPCTL1_DEF
    \
    \ @brief The application uses this register to control the behavior of each logical endpoint other than endpoint 0.
    \ Address offset: 0xB20
    \ Reset value: 0x00000000
    \
    $00 constant OTG_HS_MPSIZ                   \ [0x00 : 11] MPSIZ
    $0f constant OTG_HS_USBAEP                  \ [0x0f] USBAEP
    $10 constant OTG_HS_EONUM_DPIP              \ [0x10] EONUM_DPIP
    $11 constant OTG_HS_NAKSTS                  \ [0x11] NAKSTS
    $12 constant OTG_HS_EPTYP                   \ [0x12 : 2] EPTYP
    $14 constant OTG_HS_SNPM                    \ [0x14] SNPM
    $15 constant OTG_HS_STALL                   \ [0x15] STALL
    $1a constant OTG_HS_CNAK                    \ [0x1a] CNAK
    $1b constant OTG_HS_SNAK                    \ [0x1b] SNAK
    $1c constant OTG_HS_SD0PID_SEVNFRM          \ [0x1c] SD0PID_SEVNFRM
    $1d constant OTG_HS_SD1PID_SODDFRM          \ [0x1d] SD1PID_SODDFRM
    $1e constant OTG_HS_EPDIS                   \ [0x1e] EPDIS
    $1f constant OTG_HS_EPENA                   \ [0x1f] EPENA
  [then]


  [ifdef] OTG_HS_DOEPINT1_DEF
    \
    \ @brief This register indicates the status of an endpoint with respect to USB- and AHB-related events. It is shown in Figure724. The application must read this register when the OUT endpoints interrupt bit of the GINTSTS register (OEPINT bit in GINTSTS) is set. Before the application can read this register, it must first read the DAINT register to get the exact endpoint number for the DOEPINTx register. The application must clear the appropriate bit in this register to clear the corresponding bits in the DAINT and GINTSTS registers.
    \ Address offset: 0xB28
    \ Reset value: 0x00000080
    \
    $00 constant OTG_HS_XFRC                    \ [0x00] XFRC
    $01 constant OTG_HS_EPDISD                  \ [0x01] EPDISD
    $02 constant OTG_HS_AHBERR                  \ [0x02] AHBERR
    $03 constant OTG_HS_STUP                    \ [0x03] STUP
    $04 constant OTG_HS_OTEPDIS                 \ [0x04] OTEPDIS
    $05 constant OTG_HS_STSPHSRX                \ [0x05] STSPHSRX
    $06 constant OTG_HS_B2BSTUP                 \ [0x06] B2BSTUP
    $08 constant OTG_HS_OUTPKTERR               \ [0x08] OUTPKTERR
    $09 constant OTG_HS_BNA                     \ [0x09] BNA
    $0c constant OTG_HS_BERR                    \ [0x0c] BERR
    $0d constant OTG_HS_NAK                     \ [0x0d] NAK
    $0e constant OTG_HS_NYET                    \ [0x0e] NYET
    $0f constant OTG_HS_STPKTRX                 \ [0x0f] STPKTRX
  [then]


  [ifdef] OTG_HS_DOEPTSIZ1_DEF
    \
    \ @brief The application must modify this register before enabling the endpoint. Once the endpoint is enabled using endpoint enable bit of the DOEPCTLx registers (EPENA bit in DOEPCTLx), the core modifies this register. The application can only read this register once the core has cleared the endpoint enable bit.
    \ Address offset: 0xB30
    \ Reset value: 0x00000000
    \
    $00 constant OTG_HS_XFRSIZ                  \ [0x00 : 19] XFRSIZ
    $13 constant OTG_HS_PKTCNT                  \ [0x13 : 10] PKTCNT
    $1d constant OTG_HS_RXDPID_STUPCNT          \ [0x1d : 2] RXDPID_STUPCNT
  [then]


  [ifdef] OTG_HS_DOEPDMA1_DEF
    \
    \ @brief OTG device OUT endpoint 1 DMA address register
    \ Address offset: 0xB34
    \ Reset value: 0x00000000
    \
    $00 constant OTG_HS_DMAADDR                 \ [0x00 : 32] DMAADDR
  [then]


  [ifdef] OTG_HS_DOEPCTL2_DEF
    \
    \ @brief The application uses this register to control the behavior of each logical endpoint other than endpoint 0.
    \ Address offset: 0xB40
    \ Reset value: 0x00000000
    \
    $00 constant OTG_HS_MPSIZ                   \ [0x00 : 11] MPSIZ
    $0f constant OTG_HS_USBAEP                  \ [0x0f] USBAEP
    $10 constant OTG_HS_EONUM_DPIP              \ [0x10] EONUM_DPIP
    $11 constant OTG_HS_NAKSTS                  \ [0x11] NAKSTS
    $12 constant OTG_HS_EPTYP                   \ [0x12 : 2] EPTYP
    $14 constant OTG_HS_SNPM                    \ [0x14] SNPM
    $15 constant OTG_HS_STALL                   \ [0x15] STALL
    $1a constant OTG_HS_CNAK                    \ [0x1a] CNAK
    $1b constant OTG_HS_SNAK                    \ [0x1b] SNAK
    $1c constant OTG_HS_SD0PID_SEVNFRM          \ [0x1c] SD0PID_SEVNFRM
    $1d constant OTG_HS_SD1PID_SODDFRM          \ [0x1d] SD1PID_SODDFRM
    $1e constant OTG_HS_EPDIS                   \ [0x1e] EPDIS
    $1f constant OTG_HS_EPENA                   \ [0x1f] EPENA
  [then]


  [ifdef] OTG_HS_DOEPINT2_DEF
    \
    \ @brief This register indicates the status of an endpoint with respect to USB- and AHB-related events. It is shown in Figure724. The application must read this register when the OUT endpoints interrupt bit of the GINTSTS register (OEPINT bit in GINTSTS) is set. Before the application can read this register, it must first read the DAINT register to get the exact endpoint number for the DOEPINTx register. The application must clear the appropriate bit in this register to clear the corresponding bits in the DAINT and GINTSTS registers.
    \ Address offset: 0xB48
    \ Reset value: 0x00000080
    \
    $00 constant OTG_HS_XFRC                    \ [0x00] XFRC
    $01 constant OTG_HS_EPDISD                  \ [0x01] EPDISD
    $02 constant OTG_HS_AHBERR                  \ [0x02] AHBERR
    $03 constant OTG_HS_STUP                    \ [0x03] STUP
    $04 constant OTG_HS_OTEPDIS                 \ [0x04] OTEPDIS
    $05 constant OTG_HS_STSPHSRX                \ [0x05] STSPHSRX
    $06 constant OTG_HS_B2BSTUP                 \ [0x06] B2BSTUP
    $08 constant OTG_HS_OUTPKTERR               \ [0x08] OUTPKTERR
    $09 constant OTG_HS_BNA                     \ [0x09] BNA
    $0c constant OTG_HS_BERR                    \ [0x0c] BERR
    $0d constant OTG_HS_NAK                     \ [0x0d] NAK
    $0e constant OTG_HS_NYET                    \ [0x0e] NYET
    $0f constant OTG_HS_STPKTRX                 \ [0x0f] STPKTRX
  [then]


  [ifdef] OTG_HS_DOEPTSIZ2_DEF
    \
    \ @brief The application must modify this register before enabling the endpoint. Once the endpoint is enabled using endpoint enable bit of the DOEPCTLx registers (EPENA bit in DOEPCTLx), the core modifies this register. The application can only read this register once the core has cleared the endpoint enable bit.
    \ Address offset: 0xB50
    \ Reset value: 0x00000000
    \
    $00 constant OTG_HS_XFRSIZ                  \ [0x00 : 19] XFRSIZ
    $13 constant OTG_HS_PKTCNT                  \ [0x13 : 10] PKTCNT
    $1d constant OTG_HS_RXDPID_STUPCNT          \ [0x1d : 2] RXDPID_STUPCNT
  [then]


  [ifdef] OTG_HS_DOEPDMA2_DEF
    \
    \ @brief OTG device OUT endpoint 2 DMA address register
    \ Address offset: 0xB54
    \ Reset value: 0x00000000
    \
    $00 constant OTG_HS_DMAADDR                 \ [0x00 : 32] DMAADDR
  [then]


  [ifdef] OTG_HS_DOEPCTL3_DEF
    \
    \ @brief The application uses this register to control the behavior of each logical endpoint other than endpoint 0.
    \ Address offset: 0xB60
    \ Reset value: 0x00000000
    \
    $00 constant OTG_HS_MPSIZ                   \ [0x00 : 11] MPSIZ
    $0f constant OTG_HS_USBAEP                  \ [0x0f] USBAEP
    $10 constant OTG_HS_EONUM_DPIP              \ [0x10] EONUM_DPIP
    $11 constant OTG_HS_NAKSTS                  \ [0x11] NAKSTS
    $12 constant OTG_HS_EPTYP                   \ [0x12 : 2] EPTYP
    $14 constant OTG_HS_SNPM                    \ [0x14] SNPM
    $15 constant OTG_HS_STALL                   \ [0x15] STALL
    $1a constant OTG_HS_CNAK                    \ [0x1a] CNAK
    $1b constant OTG_HS_SNAK                    \ [0x1b] SNAK
    $1c constant OTG_HS_SD0PID_SEVNFRM          \ [0x1c] SD0PID_SEVNFRM
    $1d constant OTG_HS_SD1PID_SODDFRM          \ [0x1d] SD1PID_SODDFRM
    $1e constant OTG_HS_EPDIS                   \ [0x1e] EPDIS
    $1f constant OTG_HS_EPENA                   \ [0x1f] EPENA
  [then]


  [ifdef] OTG_HS_DOEPINT3_DEF
    \
    \ @brief This register indicates the status of an endpoint with respect to USB- and AHB-related events. It is shown in Figure724. The application must read this register when the OUT endpoints interrupt bit of the GINTSTS register (OEPINT bit in GINTSTS) is set. Before the application can read this register, it must first read the DAINT register to get the exact endpoint number for the DOEPINTx register. The application must clear the appropriate bit in this register to clear the corresponding bits in the DAINT and GINTSTS registers.
    \ Address offset: 0xB68
    \ Reset value: 0x00000080
    \
    $00 constant OTG_HS_XFRC                    \ [0x00] XFRC
    $01 constant OTG_HS_EPDISD                  \ [0x01] EPDISD
    $02 constant OTG_HS_AHBERR                  \ [0x02] AHBERR
    $03 constant OTG_HS_STUP                    \ [0x03] STUP
    $04 constant OTG_HS_OTEPDIS                 \ [0x04] OTEPDIS
    $05 constant OTG_HS_STSPHSRX                \ [0x05] STSPHSRX
    $06 constant OTG_HS_B2BSTUP                 \ [0x06] B2BSTUP
    $08 constant OTG_HS_OUTPKTERR               \ [0x08] OUTPKTERR
    $09 constant OTG_HS_BNA                     \ [0x09] BNA
    $0c constant OTG_HS_BERR                    \ [0x0c] BERR
    $0d constant OTG_HS_NAK                     \ [0x0d] NAK
    $0e constant OTG_HS_NYET                    \ [0x0e] NYET
    $0f constant OTG_HS_STPKTRX                 \ [0x0f] STPKTRX
  [then]


  [ifdef] OTG_HS_DOEPTSIZ3_DEF
    \
    \ @brief The application must modify this register before enabling the endpoint. Once the endpoint is enabled using endpoint enable bit of the DOEPCTLx registers (EPENA bit in DOEPCTLx), the core modifies this register. The application can only read this register once the core has cleared the endpoint enable bit.
    \ Address offset: 0xB70
    \ Reset value: 0x00000000
    \
    $00 constant OTG_HS_XFRSIZ                  \ [0x00 : 19] XFRSIZ
    $13 constant OTG_HS_PKTCNT                  \ [0x13 : 10] PKTCNT
    $1d constant OTG_HS_RXDPID_STUPCNT          \ [0x1d : 2] RXDPID_STUPCNT
  [then]


  [ifdef] OTG_HS_DOEPDMA3_DEF
    \
    \ @brief OTG device OUT endpoint 3 DMA address register
    \ Address offset: 0xB74
    \ Reset value: 0x00000000
    \
    $00 constant OTG_HS_DMAADDR                 \ [0x00 : 32] DMAADDR
  [then]


  [ifdef] OTG_HS_DOEPCTL4_DEF
    \
    \ @brief The application uses this register to control the behavior of each logical endpoint other than endpoint 0.
    \ Address offset: 0xB80
    \ Reset value: 0x00000000
    \
    $00 constant OTG_HS_MPSIZ                   \ [0x00 : 11] MPSIZ
    $0f constant OTG_HS_USBAEP                  \ [0x0f] USBAEP
    $10 constant OTG_HS_EONUM_DPIP              \ [0x10] EONUM_DPIP
    $11 constant OTG_HS_NAKSTS                  \ [0x11] NAKSTS
    $12 constant OTG_HS_EPTYP                   \ [0x12 : 2] EPTYP
    $14 constant OTG_HS_SNPM                    \ [0x14] SNPM
    $15 constant OTG_HS_STALL                   \ [0x15] STALL
    $1a constant OTG_HS_CNAK                    \ [0x1a] CNAK
    $1b constant OTG_HS_SNAK                    \ [0x1b] SNAK
    $1c constant OTG_HS_SD0PID_SEVNFRM          \ [0x1c] SD0PID_SEVNFRM
    $1d constant OTG_HS_SD1PID_SODDFRM          \ [0x1d] SD1PID_SODDFRM
    $1e constant OTG_HS_EPDIS                   \ [0x1e] EPDIS
    $1f constant OTG_HS_EPENA                   \ [0x1f] EPENA
  [then]


  [ifdef] OTG_HS_DOEPINT4_DEF
    \
    \ @brief This register indicates the status of an endpoint with respect to USB- and AHB-related events. It is shown in Figure724. The application must read this register when the OUT endpoints interrupt bit of the GINTSTS register (OEPINT bit in GINTSTS) is set. Before the application can read this register, it must first read the DAINT register to get the exact endpoint number for the DOEPINTx register. The application must clear the appropriate bit in this register to clear the corresponding bits in the DAINT and GINTSTS registers.
    \ Address offset: 0xB88
    \ Reset value: 0x00000080
    \
    $00 constant OTG_HS_XFRC                    \ [0x00] XFRC
    $01 constant OTG_HS_EPDISD                  \ [0x01] EPDISD
    $02 constant OTG_HS_AHBERR                  \ [0x02] AHBERR
    $03 constant OTG_HS_STUP                    \ [0x03] STUP
    $04 constant OTG_HS_OTEPDIS                 \ [0x04] OTEPDIS
    $05 constant OTG_HS_STSPHSRX                \ [0x05] STSPHSRX
    $06 constant OTG_HS_B2BSTUP                 \ [0x06] B2BSTUP
    $08 constant OTG_HS_OUTPKTERR               \ [0x08] OUTPKTERR
    $09 constant OTG_HS_BNA                     \ [0x09] BNA
    $0c constant OTG_HS_BERR                    \ [0x0c] BERR
    $0d constant OTG_HS_NAK                     \ [0x0d] NAK
    $0e constant OTG_HS_NYET                    \ [0x0e] NYET
    $0f constant OTG_HS_STPKTRX                 \ [0x0f] STPKTRX
  [then]


  [ifdef] OTG_HS_DOEPTSIZ4_DEF
    \
    \ @brief The application must modify this register before enabling the endpoint. Once the endpoint is enabled using endpoint enable bit of the DOEPCTLx registers (EPENA bit in DOEPCTLx), the core modifies this register. The application can only read this register once the core has cleared the endpoint enable bit.
    \ Address offset: 0xB90
    \ Reset value: 0x00000000
    \
    $00 constant OTG_HS_XFRSIZ                  \ [0x00 : 19] XFRSIZ
    $13 constant OTG_HS_PKTCNT                  \ [0x13 : 10] PKTCNT
    $1d constant OTG_HS_RXDPID_STUPCNT          \ [0x1d : 2] RXDPID_STUPCNT
  [then]


  [ifdef] OTG_HS_DOEPDMA4_DEF
    \
    \ @brief OTG device OUT endpoint 4 DMA address register
    \ Address offset: 0xB94
    \ Reset value: 0x00000000
    \
    $00 constant OTG_HS_DMAADDR                 \ [0x00 : 32] DMAADDR
  [then]


  [ifdef] OTG_HS_DOEPCTL5_DEF
    \
    \ @brief The application uses this register to control the behavior of each logical endpoint other than endpoint 0.
    \ Address offset: 0xBA0
    \ Reset value: 0x00000000
    \
    $00 constant OTG_HS_MPSIZ                   \ [0x00 : 11] MPSIZ
    $0f constant OTG_HS_USBAEP                  \ [0x0f] USBAEP
    $10 constant OTG_HS_EONUM_DPIP              \ [0x10] EONUM_DPIP
    $11 constant OTG_HS_NAKSTS                  \ [0x11] NAKSTS
    $12 constant OTG_HS_EPTYP                   \ [0x12 : 2] EPTYP
    $14 constant OTG_HS_SNPM                    \ [0x14] SNPM
    $15 constant OTG_HS_STALL                   \ [0x15] STALL
    $1a constant OTG_HS_CNAK                    \ [0x1a] CNAK
    $1b constant OTG_HS_SNAK                    \ [0x1b] SNAK
    $1c constant OTG_HS_SD0PID_SEVNFRM          \ [0x1c] SD0PID_SEVNFRM
    $1d constant OTG_HS_SD1PID_SODDFRM          \ [0x1d] SD1PID_SODDFRM
    $1e constant OTG_HS_EPDIS                   \ [0x1e] EPDIS
    $1f constant OTG_HS_EPENA                   \ [0x1f] EPENA
  [then]


  [ifdef] OTG_HS_DOEPINT5_DEF
    \
    \ @brief This register indicates the status of an endpoint with respect to USB- and AHB-related events. It is shown in Figure724. The application must read this register when the OUT endpoints interrupt bit of the GINTSTS register (OEPINT bit in GINTSTS) is set. Before the application can read this register, it must first read the DAINT register to get the exact endpoint number for the DOEPINTx register. The application must clear the appropriate bit in this register to clear the corresponding bits in the DAINT and GINTSTS registers.
    \ Address offset: 0xBA8
    \ Reset value: 0x00000080
    \
    $00 constant OTG_HS_XFRC                    \ [0x00] XFRC
    $01 constant OTG_HS_EPDISD                  \ [0x01] EPDISD
    $02 constant OTG_HS_AHBERR                  \ [0x02] AHBERR
    $03 constant OTG_HS_STUP                    \ [0x03] STUP
    $04 constant OTG_HS_OTEPDIS                 \ [0x04] OTEPDIS
    $05 constant OTG_HS_STSPHSRX                \ [0x05] STSPHSRX
    $06 constant OTG_HS_B2BSTUP                 \ [0x06] B2BSTUP
    $08 constant OTG_HS_OUTPKTERR               \ [0x08] OUTPKTERR
    $09 constant OTG_HS_BNA                     \ [0x09] BNA
    $0c constant OTG_HS_BERR                    \ [0x0c] BERR
    $0d constant OTG_HS_NAK                     \ [0x0d] NAK
    $0e constant OTG_HS_NYET                    \ [0x0e] NYET
    $0f constant OTG_HS_STPKTRX                 \ [0x0f] STPKTRX
  [then]


  [ifdef] OTG_HS_DOEPTSIZ5_DEF
    \
    \ @brief The application must modify this register before enabling the endpoint. Once the endpoint is enabled using endpoint enable bit of the DOEPCTLx registers (EPENA bit in DOEPCTLx), the core modifies this register. The application can only read this register once the core has cleared the endpoint enable bit.
    \ Address offset: 0xBB0
    \ Reset value: 0x00000000
    \
    $00 constant OTG_HS_XFRSIZ                  \ [0x00 : 19] XFRSIZ
    $13 constant OTG_HS_PKTCNT                  \ [0x13 : 10] PKTCNT
    $1d constant OTG_HS_RXDPID_STUPCNT          \ [0x1d : 2] RXDPID_STUPCNT
  [then]


  [ifdef] OTG_HS_DOEPDMA5_DEF
    \
    \ @brief OTG device OUT endpoint 5 DMA address register
    \ Address offset: 0xBB4
    \ Reset value: 0x00000000
    \
    $00 constant OTG_HS_DMAADDR                 \ [0x00 : 32] DMAADDR
  [then]


  [ifdef] OTG_HS_DOEPCTL6_DEF
    \
    \ @brief The application uses this register to control the behavior of each logical endpoint other than endpoint 0.
    \ Address offset: 0xBC0
    \ Reset value: 0x00000000
    \
    $00 constant OTG_HS_MPSIZ                   \ [0x00 : 11] MPSIZ
    $0f constant OTG_HS_USBAEP                  \ [0x0f] USBAEP
    $10 constant OTG_HS_EONUM_DPIP              \ [0x10] EONUM_DPIP
    $11 constant OTG_HS_NAKSTS                  \ [0x11] NAKSTS
    $12 constant OTG_HS_EPTYP                   \ [0x12 : 2] EPTYP
    $14 constant OTG_HS_SNPM                    \ [0x14] SNPM
    $15 constant OTG_HS_STALL                   \ [0x15] STALL
    $1a constant OTG_HS_CNAK                    \ [0x1a] CNAK
    $1b constant OTG_HS_SNAK                    \ [0x1b] SNAK
    $1c constant OTG_HS_SD0PID_SEVNFRM          \ [0x1c] SD0PID_SEVNFRM
    $1d constant OTG_HS_SD1PID_SODDFRM          \ [0x1d] SD1PID_SODDFRM
    $1e constant OTG_HS_EPDIS                   \ [0x1e] EPDIS
    $1f constant OTG_HS_EPENA                   \ [0x1f] EPENA
  [then]


  [ifdef] OTG_HS_DOEPINT6_DEF
    \
    \ @brief This register indicates the status of an endpoint with respect to USB- and AHB-related events. It is shown in Figure724. The application must read this register when the OUT endpoints interrupt bit of the GINTSTS register (OEPINT bit in GINTSTS) is set. Before the application can read this register, it must first read the DAINT register to get the exact endpoint number for the DOEPINTx register. The application must clear the appropriate bit in this register to clear the corresponding bits in the DAINT and GINTSTS registers.
    \ Address offset: 0xBC8
    \ Reset value: 0x00000080
    \
    $00 constant OTG_HS_XFRC                    \ [0x00] XFRC
    $01 constant OTG_HS_EPDISD                  \ [0x01] EPDISD
    $02 constant OTG_HS_AHBERR                  \ [0x02] AHBERR
    $03 constant OTG_HS_STUP                    \ [0x03] STUP
    $04 constant OTG_HS_OTEPDIS                 \ [0x04] OTEPDIS
    $05 constant OTG_HS_STSPHSRX                \ [0x05] STSPHSRX
    $06 constant OTG_HS_B2BSTUP                 \ [0x06] B2BSTUP
    $08 constant OTG_HS_OUTPKTERR               \ [0x08] OUTPKTERR
    $09 constant OTG_HS_BNA                     \ [0x09] BNA
    $0c constant OTG_HS_BERR                    \ [0x0c] BERR
    $0d constant OTG_HS_NAK                     \ [0x0d] NAK
    $0e constant OTG_HS_NYET                    \ [0x0e] NYET
    $0f constant OTG_HS_STPKTRX                 \ [0x0f] STPKTRX
  [then]


  [ifdef] OTG_HS_DOEPTSIZ6_DEF
    \
    \ @brief The application must modify this register before enabling the endpoint. Once the endpoint is enabled using endpoint enable bit of the DOEPCTLx registers (EPENA bit in DOEPCTLx), the core modifies this register. The application can only read this register once the core has cleared the endpoint enable bit.
    \ Address offset: 0xBD0
    \ Reset value: 0x00000000
    \
    $00 constant OTG_HS_XFRSIZ                  \ [0x00 : 19] XFRSIZ
    $13 constant OTG_HS_PKTCNT                  \ [0x13 : 10] PKTCNT
    $1d constant OTG_HS_RXDPID_STUPCNT          \ [0x1d : 2] RXDPID_STUPCNT
  [then]


  [ifdef] OTG_HS_DOEPDMA6_DEF
    \
    \ @brief OTG device OUT endpoint 6 DMA address register
    \ Address offset: 0xBD4
    \ Reset value: 0x00000000
    \
    $00 constant OTG_HS_DMAADDR                 \ [0x00 : 32] DMAADDR
  [then]


  [ifdef] OTG_HS_DOEPCTL7_DEF
    \
    \ @brief The application uses this register to control the behavior of each logical endpoint other than endpoint 0.
    \ Address offset: 0xBE0
    \ Reset value: 0x00000000
    \
    $00 constant OTG_HS_MPSIZ                   \ [0x00 : 11] MPSIZ
    $0f constant OTG_HS_USBAEP                  \ [0x0f] USBAEP
    $10 constant OTG_HS_EONUM_DPIP              \ [0x10] EONUM_DPIP
    $11 constant OTG_HS_NAKSTS                  \ [0x11] NAKSTS
    $12 constant OTG_HS_EPTYP                   \ [0x12 : 2] EPTYP
    $14 constant OTG_HS_SNPM                    \ [0x14] SNPM
    $15 constant OTG_HS_STALL                   \ [0x15] STALL
    $1a constant OTG_HS_CNAK                    \ [0x1a] CNAK
    $1b constant OTG_HS_SNAK                    \ [0x1b] SNAK
    $1c constant OTG_HS_SD0PID_SEVNFRM          \ [0x1c] SD0PID_SEVNFRM
    $1d constant OTG_HS_SD1PID_SODDFRM          \ [0x1d] SD1PID_SODDFRM
    $1e constant OTG_HS_EPDIS                   \ [0x1e] EPDIS
    $1f constant OTG_HS_EPENA                   \ [0x1f] EPENA
  [then]


  [ifdef] OTG_HS_DOEPINT7_DEF
    \
    \ @brief This register indicates the status of an endpoint with respect to USB- and AHB-related events. It is shown in Figure724. The application must read this register when the OUT endpoints interrupt bit of the GINTSTS register (OEPINT bit in GINTSTS) is set. Before the application can read this register, it must first read the DAINT register to get the exact endpoint number for the DOEPINTx register. The application must clear the appropriate bit in this register to clear the corresponding bits in the DAINT and GINTSTS registers.
    \ Address offset: 0xBE8
    \ Reset value: 0x00000080
    \
    $00 constant OTG_HS_XFRC                    \ [0x00] XFRC
    $01 constant OTG_HS_EPDISD                  \ [0x01] EPDISD
    $02 constant OTG_HS_AHBERR                  \ [0x02] AHBERR
    $03 constant OTG_HS_STUP                    \ [0x03] STUP
    $04 constant OTG_HS_OTEPDIS                 \ [0x04] OTEPDIS
    $05 constant OTG_HS_STSPHSRX                \ [0x05] STSPHSRX
    $06 constant OTG_HS_B2BSTUP                 \ [0x06] B2BSTUP
    $08 constant OTG_HS_OUTPKTERR               \ [0x08] OUTPKTERR
    $09 constant OTG_HS_BNA                     \ [0x09] BNA
    $0c constant OTG_HS_BERR                    \ [0x0c] BERR
    $0d constant OTG_HS_NAK                     \ [0x0d] NAK
    $0e constant OTG_HS_NYET                    \ [0x0e] NYET
    $0f constant OTG_HS_STPKTRX                 \ [0x0f] STPKTRX
  [then]


  [ifdef] OTG_HS_DOEPTSIZ7_DEF
    \
    \ @brief The application must modify this register before enabling the endpoint. Once the endpoint is enabled using endpoint enable bit of the DOEPCTLx registers (EPENA bit in DOEPCTLx), the core modifies this register. The application can only read this register once the core has cleared the endpoint enable bit.
    \ Address offset: 0xBF0
    \ Reset value: 0x00000000
    \
    $00 constant OTG_HS_XFRSIZ                  \ [0x00 : 19] XFRSIZ
    $13 constant OTG_HS_PKTCNT                  \ [0x13 : 10] PKTCNT
    $1d constant OTG_HS_RXDPID_STUPCNT          \ [0x1d : 2] RXDPID_STUPCNT
  [then]


  [ifdef] OTG_HS_DOEPDMA7_DEF
    \
    \ @brief OTG device OUT endpoint 7 DMA address register
    \ Address offset: 0xBF4
    \ Reset value: 0x00000000
    \
    $00 constant OTG_HS_DMAADDR                 \ [0x00 : 32] DMAADDR
  [then]


  [ifdef] OTG_HS_DOEPCTL8_DEF
    \
    \ @brief The application uses this register to control the behavior of each logical endpoint other than endpoint 0.
    \ Address offset: 0xC00
    \ Reset value: 0x00000000
    \
    $00 constant OTG_HS_MPSIZ                   \ [0x00 : 11] MPSIZ
    $0f constant OTG_HS_USBAEP                  \ [0x0f] USBAEP
    $10 constant OTG_HS_EONUM_DPIP              \ [0x10] EONUM_DPIP
    $11 constant OTG_HS_NAKSTS                  \ [0x11] NAKSTS
    $12 constant OTG_HS_EPTYP                   \ [0x12 : 2] EPTYP
    $14 constant OTG_HS_SNPM                    \ [0x14] SNPM
    $15 constant OTG_HS_STALL                   \ [0x15] STALL
    $1a constant OTG_HS_CNAK                    \ [0x1a] CNAK
    $1b constant OTG_HS_SNAK                    \ [0x1b] SNAK
    $1c constant OTG_HS_SD0PID_SEVNFRM          \ [0x1c] SD0PID_SEVNFRM
    $1d constant OTG_HS_SD1PID_SODDFRM          \ [0x1d] SD1PID_SODDFRM
    $1e constant OTG_HS_EPDIS                   \ [0x1e] EPDIS
    $1f constant OTG_HS_EPENA                   \ [0x1f] EPENA
  [then]


  [ifdef] OTG_HS_DOEPINT8_DEF
    \
    \ @brief This register indicates the status of an endpoint with respect to USB- and AHB-related events. It is shown in Figure724. The application must read this register when the OUT endpoints interrupt bit of the GINTSTS register (OEPINT bit in GINTSTS) is set. Before the application can read this register, it must first read the DAINT register to get the exact endpoint number for the DOEPINTx register. The application must clear the appropriate bit in this register to clear the corresponding bits in the DAINT and GINTSTS registers.
    \ Address offset: 0xC08
    \ Reset value: 0x00000080
    \
    $00 constant OTG_HS_XFRC                    \ [0x00] XFRC
    $01 constant OTG_HS_EPDISD                  \ [0x01] EPDISD
    $02 constant OTG_HS_AHBERR                  \ [0x02] AHBERR
    $03 constant OTG_HS_STUP                    \ [0x03] STUP
    $04 constant OTG_HS_OTEPDIS                 \ [0x04] OTEPDIS
    $05 constant OTG_HS_STSPHSRX                \ [0x05] STSPHSRX
    $06 constant OTG_HS_B2BSTUP                 \ [0x06] B2BSTUP
    $08 constant OTG_HS_OUTPKTERR               \ [0x08] OUTPKTERR
    $09 constant OTG_HS_BNA                     \ [0x09] BNA
    $0c constant OTG_HS_BERR                    \ [0x0c] BERR
    $0d constant OTG_HS_NAK                     \ [0x0d] NAK
    $0e constant OTG_HS_NYET                    \ [0x0e] NYET
    $0f constant OTG_HS_STPKTRX                 \ [0x0f] STPKTRX
  [then]


  [ifdef] OTG_HS_DOEPTSIZ8_DEF
    \
    \ @brief The application must modify this register before enabling the endpoint. Once the endpoint is enabled using endpoint enable bit of the DOEPCTLx registers (EPENA bit in DOEPCTLx), the core modifies this register. The application can only read this register once the core has cleared the endpoint enable bit.
    \ Address offset: 0xC10
    \ Reset value: 0x00000000
    \
    $00 constant OTG_HS_XFRSIZ                  \ [0x00 : 19] XFRSIZ
    $13 constant OTG_HS_PKTCNT                  \ [0x13 : 10] PKTCNT
    $1d constant OTG_HS_RXDPID_STUPCNT          \ [0x1d : 2] RXDPID_STUPCNT
  [then]


  [ifdef] OTG_HS_DOEPDMA8_DEF
    \
    \ @brief OTG device OUT endpoint 8 DMA address register
    \ Address offset: 0xC14
    \ Reset value: 0x00000000
    \
    $00 constant OTG_HS_DMAADDR                 \ [0x00 : 32] DMAADDR
  [then]


  [ifdef] OTG_HS_PCGCCTL_DEF
    \
    \ @brief This register is available in host and device modes.
    \ Address offset: 0xE00
    \ Reset value: 0x200B8000
    \
    $00 constant OTG_HS_STPPCLK                 \ [0x00] STPPCLK
    $01 constant OTG_HS_GATEHCLK                \ [0x01] GATEHCLK
    $04 constant OTG_HS_PHYSUSP                 \ [0x04] PHYSUSP
    $05 constant OTG_HS_ENL1GTG                 \ [0x05] ENL1GTG
    $06 constant OTG_HS_PHYSLEEP                \ [0x06] PHYSLEEP
    $07 constant OTG_HS_SUSP                    \ [0x07] SUSP
  [then]

  \
  \ @brief OTG_HS
  \
  $00 constant OTG_HS_GOTGCTL           \ The GOTGCTL register controls the behavior and reflects the status of the OTG function of the core.
  $04 constant OTG_HS_GOTGINT           \ The application reads this register whenever there is an OTG interrupt and clears the bits in this register to clear the OTG interrupt.
  $08 constant OTG_HS_GAHBCFG           \ This register can be used to configure the core after power-on or a change in mode. This register mainly contains AHB system-related configuration parameters. Do not change this register after the initial programming. The application must program this register before starting any transactions on either the AHB or the USB.
  $0C constant OTG_HS_GUSBCFG           \ This register can be used to configure the core after power-on or a changing to host mode or device mode. It contains USB and USB-PHY related configuration parameters. The application must program this register before starting any transactions on either the AHB or the USB. Do not make changes to this register after the initial programming.
  $10 constant OTG_HS_GRSTCTL           \ The application uses this register to reset various hardware features inside the core.
  $14 constant OTG_HS_GINTSTS           \ This register interrupts the application for system-level events in the current mode (device mode or host mode). Some of the bits in this register are valid only in host mode, while others are valid in device mode only. This register also indicates the current mode. To clear the interrupt status bits of the rc_w1 type, the application must write 1 into the bit. The FIFO status interrupts are read-only; once software reads from or writes to the FIFO while servicing these interrupts, FIFO interrupt conditions are cleared automatically. The application must clear the GINTSTS register at initialization before unmasking the interrupt bit to avoid any interrupts generated prior to initialization.
  $18 constant OTG_HS_GINTMSK           \ This register works with the core interrupt register to interrupt the application. When an interrupt bit is masked, the interrupt associated with that bit is not generated. However, the core interrupt (GINTSTS) register bit corresponding to that interrupt is still set.
  $1C constant OTG_HS_GRXSTSR_DEVICE    \ This description is for register GRXSTSR in Device mode. A read to the receive status debug read register returns the contents of the top of the receive FIFO. The core ignores the receive status read when the receive FIFO is empty and returns a value of 0x00000000.
  $1C constant OTG_HS_GRXSTSR_HOST      \ This description is for register GRXSTSR in Host mode
  $20 constant OTG_HS_GRXSTSP_DEVICE    \ This description is for register GRXSTSP in Device mode. Similarly to GRXSTSR (receive status debug read register) where a read returns the contents of the top of the receive FIFO, a read to GRXSTSP (receive status read and pop register) additionally pops the top data entry out of the Rx FIFO. The core ignores the receive status pop/read when the receive FIFO is empty and returns a value of 0x00000000. The application must only pop the receive status FIFO when the receive FIFO non-empty bit of the core interrupt register (RXFLVL bit in GINTSTS) is asserted.
  $20 constant OTG_HS_GRXSTSP_HOST      \ This description is for register GRXSTSP in HOST mode
  $24 constant OTG_HS_GRXFSIZ           \ The application can program the RAM size that must be allocated to the Rx FIFO.
  $28 constant OTG_HS_HNPTXFSIZ         \ Host mode
  $2C constant OTG_HS_HNPTXSTS          \ In device mode, this register is not valid. This read-only register contains the free space information for the non-periodic Tx FIFO and the non-periodic transmit request queue.
  $38 constant OTG_HS_GCCFG             \ OTG general core configuration register
  $3C constant OTG_HS_CID               \ This is a register containing the Product ID as reset value.
  $54 constant OTG_HS_GLPMCFG           \ OTG core LPM configuration register
  $100 constant OTG_HS_HPTXFSIZ         \ OTG host periodic transmit FIFO size register
  $104 constant OTG_HS_DIEPTXF1         \ OTG device IN endpoint transmit FIFO 1 size register
  $108 constant OTG_HS_DIEPTXF2         \ OTG device IN endpoint transmit FIFO 2 size register
  $10C constant OTG_HS_DIEPTXF3         \ OTG device IN endpoint transmit FIFO 3 size register
  $110 constant OTG_HS_DIEPTXF4         \ OTG device IN endpoint transmit FIFO 4 size register
  $114 constant OTG_HS_DIEPTXF5         \ OTG device IN endpoint transmit FIFO 5 size register
  $118 constant OTG_HS_DIEPTXF6         \ OTG device IN endpoint transmit FIFO 6 size register
  $11C constant OTG_HS_DIEPTXF7         \ OTG device IN endpoint transmit FIFO 7 size register
  $120 constant OTG_HS_DIEPTXF8         \ OTG device IN endpoint transmit FIFO 8 size register
  $400 constant OTG_HS_HCFG             \ This register configures the core after power-on. Do not make changes to this register after initializing the host.
  $404 constant OTG_HS_HFIR             \ This register stores the frame interval information for the current speed to which the OTG controller has enumerated.
  $408 constant OTG_HS_HFNUM            \ This register indicates the current frame number. It also indicates the time remaining (in terms of the number of PHY clocks) in the current frame.
  $410 constant OTG_HS_HPTXSTS          \ This read-only register contains the free space information for the periodic Tx FIFO and the periodic transmit request queue.
  $414 constant OTG_HS_HAINT            \ When a significant event occurs on a channel, the host all channels interrupt register interrupts the application using the host channels interrupt bit of the core interrupt register (HCINT bit in GINTSTS). This is shown in Figure724. There is one interrupt bit per channel, up to a maximum of 16 bits. Bits in this register are set and cleared when the application sets and clears bits in the corresponding host channel-x interrupt register.
  $418 constant OTG_HS_HAINTMSK         \ The host all channel interrupt mask register works with the host all channel interrupt register to interrupt the application when an event occurs on a channel. There is one interrupt mask bit per channel, up to a maximum of 16 bits.
  $440 constant OTG_HS_HPRT             \ This register is available only in host mode. Currently, the OTG host supports only one port. A single register holds USB port-related information such as USB reset, enable, suspend, resume, connect status, and test mode for each port. It is shown in Figure724. The rc_w1 bits in this register can trigger an interrupt to the application through the host port interrupt bit of the core interrupt register (HPRTINT bit in GINTSTS). On a port interrupt, the application must read this register and clear the bit that caused the interrupt. For the rc_w1 bits, the application must write a 1 to the bit to clear the interrupt.
  $500 constant OTG_HS_HCCHAR0          \ OTG host channel 0 characteristics register
  $504 constant OTG_HS_HCSPLT0          \ OTG host channel 0 split control register
  $508 constant OTG_HS_HCINT0           \ This register indicates the status of a channel with respect to USB- and AHB-related events. It is shown in Figure724. The application must read this register when the host channels interrupt bit in the core interrupt register (HCINT bit in GINTSTS) is set. Before the application can read this register, it must first read the host all channels interrupt (HAINT) register to get the exact channel number for the host channel-x interrupt register. The application must clear the appropriate bit in this register to clear the corresponding bits in the HAINT and GINTSTS registers.
  $50C constant OTG_HS_HCINTMSK0        \ This register reflects the mask for each channel status described in the previous section.
  $510 constant OTG_HS_HCTSIZ0          \ OTG host channel 0 transfer size register
  $514 constant OTG_HS_HCDMA0           \ OTG host channel 0 DMA address register
  $520 constant OTG_HS_HCCHAR1          \ OTG host channel 1 characteristics register
  $524 constant OTG_HS_HCSPLT1          \ OTG host channel 1 split control register
  $528 constant OTG_HS_HCINT1_DEVICE    \ This register indicates the status of a channel with respect to USB- and AHB-related events. It is shown in Figure724. The application must read this register when the host channels interrupt bit in the core interrupt register (HCINT bit in GINTSTS) is set. Before the application can read this register, it must first read the host all channels interrupt (HAINT) register to get the exact channel number for the host channel-x interrupt register. The application must clear the appropriate bit in this register to clear the corresponding bits in the HAINT and GINTSTS registers.
  $52C constant OTG_HS_HCINTMSK1        \ This register reflects the mask for each channel status described in the previous section.
  $530 constant OTG_HS_HCTSIZ1          \ OTG host channel 1 transfer size register
  $534 constant OTG_HS_HCDMA1           \ OTG host channel 1 DMA address register
  $540 constant OTG_HS_HCCHAR2          \ OTG host channel 2 characteristics register
  $544 constant OTG_HS_HCSPLT2          \ OTG host channel 2 split control register
  $548 constant OTG_HS_HCINT2           \ This register indicates the status of a channel with respect to USB- and AHB-related events. It is shown in Figure724. The application must read this register when the host channels interrupt bit in the core interrupt register (HCINT bit in GINTSTS) is set. Before the application can read this register, it must first read the host all channels interrupt (HAINT) register to get the exact channel number for the host channel-x interrupt register. The application must clear the appropriate bit in this register to clear the corresponding bits in the HAINT and GINTSTS registers.
  $54C constant OTG_HS_HCINTMSK2        \ This register reflects the mask for each channel status described in the previous section.
  $550 constant OTG_HS_HCTSIZ2          \ OTG host channel 2 transfer size register
  $554 constant OTG_HS_HCDMA2           \ OTG host channel 2 DMA address register
  $560 constant OTG_HS_HCCHAR3          \ OTG host channel 3 characteristics register
  $564 constant OTG_HS_HCSPLT3          \ OTG host channel 3 split control register
  $568 constant OTG_HS_HCINT3           \ This register indicates the status of a channel with respect to USB- and AHB-related events. It is shown in Figure724. The application must read this register when the host channels interrupt bit in the core interrupt register (HCINT bit in GINTSTS) is set. Before the application can read this register, it must first read the host all channels interrupt (HAINT) register to get the exact channel number for the host channel-x interrupt register. The application must clear the appropriate bit in this register to clear the corresponding bits in the HAINT and GINTSTS registers.
  $56C constant OTG_HS_HCINTMSK3        \ This register reflects the mask for each channel status described in the previous section.
  $570 constant OTG_HS_HCTSIZ3          \ OTG host channel 3 transfer size register
  $574 constant OTG_HS_HCDMA3           \ OTG host channel 3 DMA address register
  $580 constant OTG_HS_HCCHAR4          \ OTG host channel 4 characteristics register
  $584 constant OTG_HS_HCSPLT4          \ OTG host channel 4 split control register
  $588 constant OTG_HS_HCINT4           \ This register indicates the status of a channel with respect to USB- and AHB-related events. It is shown in Figure724. The application must read this register when the host channels interrupt bit in the core interrupt register (HCINT bit in GINTSTS) is set. Before the application can read this register, it must first read the host all channels interrupt (HAINT) register to get the exact channel number for the host channel-x interrupt register. The application must clear the appropriate bit in this register to clear the corresponding bits in the HAINT and GINTSTS registers.
  $58C constant OTG_HS_HCINTMSK4        \ This register reflects the mask for each channel status described in the previous section.
  $590 constant OTG_HS_HCTSIZ4          \ OTG host channel 4 transfer size register
  $594 constant OTG_HS_HCDMA4           \ OTG host channel 4 DMA address register
  $5A0 constant OTG_HS_HCCHAR5          \ OTG host channel 5 characteristics register
  $5A4 constant OTG_HS_HCSPLT5          \ OTG host channel 5 split control register
  $5A8 constant OTG_HS_HCINT5           \ This register indicates the status of a channel with respect to USB- and AHB-related events. It is shown in Figure724. The application must read this register when the host channels interrupt bit in the core interrupt register (HCINT bit in GINTSTS) is set. Before the application can read this register, it must first read the host all channels interrupt (HAINT) register to get the exact channel number for the host channel-x interrupt register. The application must clear the appropriate bit in this register to clear the corresponding bits in the HAINT and GINTSTS registers.
  $5AC constant OTG_HS_HCINTMSK5        \ This register reflects the mask for each channel status described in the previous section.
  $5B0 constant OTG_HS_HCTSIZ5          \ OTG host channel 5 transfer size register
  $5B4 constant OTG_HS_HCDMA5           \ OTG host channel 5 DMA address register
  $5C0 constant OTG_HS_HCCHAR6          \ OTG host channel 6 characteristics register
  $5C4 constant OTG_HS_HCSPLT6          \ OTG host channel 6 split control register
  $5C8 constant OTG_HS_HCINT6           \ This register indicates the status of a channel with respect to USB- and AHB-related events. It is shown in Figure724. The application must read this register when the host channels interrupt bit in the core interrupt register (HCINT bit in GINTSTS) is set. Before the application can read this register, it must first read the host all channels interrupt (HAINT) register to get the exact channel number for the host channel-x interrupt register. The application must clear the appropriate bit in this register to clear the corresponding bits in the HAINT and GINTSTS registers.
  $5CC constant OTG_HS_HCINTMSK6        \ This register reflects the mask for each channel status described in the previous section.
  $5D0 constant OTG_HS_HCTSIZ6          \ OTG host channel 6 transfer size register
  $5D4 constant OTG_HS_HCDMA6           \ OTG host channel 6 DMA address register
  $5E0 constant OTG_HS_HCCHAR7          \ OTG host channel 7 characteristics register
  $5E4 constant OTG_HS_HCSPLT7          \ OTG host channel 7 split control register
  $5E8 constant OTG_HS_HCINT7           \ This register indicates the status of a channel with respect to USB- and AHB-related events. It is shown in Figure724. The application must read this register when the host channels interrupt bit in the core interrupt register (HCINT bit in GINTSTS) is set. Before the application can read this register, it must first read the host all channels interrupt (HAINT) register to get the exact channel number for the host channel-x interrupt register. The application must clear the appropriate bit in this register to clear the corresponding bits in the HAINT and GINTSTS registers.
  $5EC constant OTG_HS_HCINTMSK7        \ This register reflects the mask for each channel status described in the previous section.
  $5F0 constant OTG_HS_HCTSIZ7          \ OTG host channel 7 transfer size register
  $5F4 constant OTG_HS_HCDMA7           \ OTG host channel 7 DMA address register
  $600 constant OTG_HS_HCCHAR8          \ OTG host channel 8 characteristics register
  $604 constant OTG_HS_HCSPLT8          \ OTG host channel 8 split control register
  $608 constant OTG_HS_HCINT8           \ This register indicates the status of a channel with respect to USB- and AHB-related events. It is shown in Figure724. The application must read this register when the host channels interrupt bit in the core interrupt register (HCINT bit in GINTSTS) is set. Before the application can read this register, it must first read the host all channels interrupt (HAINT) register to get the exact channel number for the host channel-x interrupt register. The application must clear the appropriate bit in this register to clear the corresponding bits in the HAINT and GINTSTS registers.
  $60C constant OTG_HS_HCINTMSK8        \ This register reflects the mask for each channel status described in the previous section.
  $610 constant OTG_HS_HCTSIZ8          \ OTG host channel 8 transfer size register
  $614 constant OTG_HS_HCDMA8           \ OTG host channel 8 DMA address register
  $620 constant OTG_HS_HCCHAR9          \ OTG host channel 9 characteristics register
  $624 constant OTG_HS_HCSPLT9          \ OTG host channel 9 split control register
  $628 constant OTG_HS_HCINT9           \ This register indicates the status of a channel with respect to USB- and AHB-related events. It is shown in Figure724. The application must read this register when the host channels interrupt bit in the core interrupt register (HCINT bit in GINTSTS) is set. Before the application can read this register, it must first read the host all channels interrupt (HAINT) register to get the exact channel number for the host channel-x interrupt register. The application must clear the appropriate bit in this register to clear the corresponding bits in the HAINT and GINTSTS registers.
  $62C constant OTG_HS_HCINTMSK9        \ This register reflects the mask for each channel status described in the previous section.
  $630 constant OTG_HS_HCTSIZ9          \ OTG host channel 9 transfer size register
  $634 constant OTG_HS_HCDMA9           \ OTG host channel 9 DMA address register
  $640 constant OTG_HS_HCCHAR10         \ OTG host channel 10 characteristics register
  $644 constant OTG_HS_HCSPLT10         \ OTG host channel 10 split control register
  $648 constant OTG_HS_HCINT10          \ This register indicates the status of a channel with respect to USB- and AHB-related events. It is shown in Figure724. The application must read this register when the host channels interrupt bit in the core interrupt register (HCINT bit in GINTSTS) is set. Before the application can read this register, it must first read the host all channels interrupt (HAINT) register to get the exact channel number for the host channel-x interrupt register. The application must clear the appropriate bit in this register to clear the corresponding bits in the HAINT and GINTSTS registers.
  $64C constant OTG_HS_HCINTMSK10       \ This register reflects the mask for each channel status described in the previous section.
  $650 constant OTG_HS_HCTSIZ10         \ OTG host channel 10 transfer size register
  $654 constant OTG_HS_HCDMA10          \ OTG host channel 10 DMA address register
  $660 constant OTG_HS_HCCHAR11         \ OTG host channel 11 characteristics register
  $664 constant OTG_HS_HCSPLT11         \ OTG host channel 11 split control register
  $668 constant OTG_HS_HCINT11          \ This register indicates the status of a channel with respect to USB- and AHB-related events. It is shown in Figure724. The application must read this register when the host channels interrupt bit in the core interrupt register (HCINT bit in GINTSTS) is set. Before the application can read this register, it must first read the host all channels interrupt (HAINT) register to get the exact channel number for the host channel-x interrupt register. The application must clear the appropriate bit in this register to clear the corresponding bits in the HAINT and GINTSTS registers.
  $66C constant OTG_HS_HCINTMSK11       \ This register reflects the mask for each channel status described in the previous section.
  $670 constant OTG_HS_HCTSIZ11         \ OTG host channel 11 transfer size register
  $674 constant OTG_HS_HCDMA11          \ OTG host channel 11 DMA address register
  $680 constant OTG_HS_HCCHAR12         \ OTG host channel 12 characteristics register
  $684 constant OTG_HS_HCSPLT12         \ OTG host channel 0 split control register
  $688 constant OTG_HS_HCINT12          \ This register indicates the status of a channel with respect to USB- and AHB-related events. It is shown in Figure724. The application must read this register when the host channels interrupt bit in the core interrupt register (HCINT bit in GINTSTS) is set. Before the application can read this register, it must first read the host all channels interrupt (HAINT) register to get the exact channel number for the host channel-x interrupt register. The application must clear the appropriate bit in this register to clear the corresponding bits in the HAINT and GINTSTS registers.
  $68C constant OTG_HS_HCINTMSK12       \ This register reflects the mask for each channel status described in the previous section.
  $690 constant OTG_HS_HCTSIZ12         \ OTG host channel 12 transfer size register
  $694 constant OTG_HS_HCDMA12          \ OTG host channel 12 DMA address register
  $6A0 constant OTG_HS_HCCHAR13         \ OTG host channel 13 characteristics register
  $6A4 constant OTG_HS_HCSPLT13         \ OTG host channel 13 split control register
  $6A8 constant OTG_HS_HCINT13          \ This register indicates the status of a channel with respect to USB- and AHB-related events. It is shown in Figure724. The application must read this register when the host channels interrupt bit in the core interrupt register (HCINT bit in GINTSTS) is set. Before the application can read this register, it must first read the host all channels interrupt (HAINT) register to get the exact channel number for the host channel-x interrupt register. The application must clear the appropriate bit in this register to clear the corresponding bits in the HAINT and GINTSTS registers.
  $6AC constant OTG_HS_HCINTMSK13       \ This register reflects the mask for each channel status described in the previous section.
  $6B0 constant OTG_HS_HCTSIZ13         \ OTG host channel 13 transfer size register
  $6B4 constant OTG_HS_HCDMA13          \ OTG host channel 13 DMA address register
  $6C0 constant OTG_HS_HCCHAR14         \ OTG host channel 14 characteristics register
  $6C4 constant OTG_HS_HCSPLT14         \ OTG host channel 14 split control register
  $6C8 constant OTG_HS_HCINT14          \ This register indicates the status of a channel with respect to USB- and AHB-related events. It is shown in Figure724. The application must read this register when the host channels interrupt bit in the core interrupt register (HCINT bit in GINTSTS) is set. Before the application can read this register, it must first read the host all channels interrupt (HAINT) register to get the exact channel number for the host channel-x interrupt register. The application must clear the appropriate bit in this register to clear the corresponding bits in the HAINT and GINTSTS registers.
  $6CC constant OTG_HS_HCINTMSK14       \ This register reflects the mask for each channel status described in the previous section.
  $6D0 constant OTG_HS_HCTSIZ14         \ OTG host channel 14 transfer size register
  $6D4 constant OTG_HS_HCDMA14          \ OTG host channel 14 DMA address register
  $6E0 constant OTG_HS_HCCHAR15         \ OTG host channel 15 characteristics register
  $6E4 constant OTG_HS_HCSPLT15         \ OTG host channel 15 split control register
  $6E8 constant OTG_HS_HCINT15          \ This register indicates the status of a channel with respect to USB- and AHB-related events. It is shown in Figure724. The application must read this register when the host channels interrupt bit in the core interrupt register (HCINT bit in GINTSTS) is set. Before the application can read this register, it must first read the host all channels interrupt (HAINT) register to get the exact channel number for the host channel-x interrupt register. The application must clear the appropriate bit in this register to clear the corresponding bits in the HAINT and GINTSTS registers.
  $6EC constant OTG_HS_HCINTMSK15       \ This register reflects the mask for each channel status described in the previous section.
  $6F0 constant OTG_HS_HCTSIZ15         \ OTG host channel 15 transfer size register
  $6F4 constant OTG_HS_HCDMA15          \ OTG host channel 15 DMA address register
  $800 constant OTG_HS_DCFG             \ This register configures the core in device mode after power-on or after certain control commands or enumeration. Do not make changes to this register after initial programming.
  $804 constant OTG_HS_DCTL             \ OTG device control register
  $808 constant OTG_HS_DSTS             \ This register indicates the status of the core with respect to USB-related events. It must be read on interrupts from the device all interrupts (DAINT) register.
  $810 constant OTG_HS_DIEPMSK          \ This register works with each of the DIEPINTx registers for all endpoints to generate an interrupt per IN endpoint. The IN endpoint interrupt for a specific status in the DIEPINTx register can be masked by writing to the corresponding bit in this register. Status bits are masked by default.
  $814 constant OTG_HS_DOEPMSK          \ This register works with each of the DOEPINTx registers for all endpoints to generate an interrupt per OUT endpoint. The OUT endpoint interrupt for a specific status in the DOEPINTx register can be masked by writing into the corresponding bit in this register. Status bits are masked by default.
  $818 constant OTG_HS_DAINT            \ When a significant event occurs on an endpoint, a DAINT register interrupts the application using the device OUT endpoints interrupt bit or device IN endpoints interrupt bit of the GINTSTS register (OEPINT or IEPINT in GINTSTS, respectively). There is one interrupt bit per endpoint, up to a maximum of 16 bits for OUT endpoints and 16 bits for IN endpoints. For a bidirectional endpoint, the corresponding IN and OUT interrupt bits are used. Bits in this register are set and cleared when the application sets and clears bits in the corresponding device endpoint-x interrupt register (DIEPINTx/DOEPINTx).
  $81C constant OTG_HS_DAINTMSK         \ The DAINTMSK register works with the device endpoint interrupt register to interrupt the application when an event occurs on a device endpoint. However, the DAINT register bit corresponding to that interrupt is still set.
  $828 constant OTG_HS_DVBUSDIS         \ This register specifies the VBUS discharge time after VBUS pulsing during SRP.
  $82C constant OTG_HS_DVBUSPULSE       \ This register specifies the VBUS pulsing time during SRP.
  $830 constant OTG_HS_DTHRCTL          \ OTG device threshold control register
  $834 constant OTG_HS_DIEPEMPMSK       \ This register is used to control the IN endpoint FIFO empty interrupt generation (TXFE_DIEPINTx).
  $884 constant OTG_HS_HS_DOEPEACHMSK1  \ OTG device each OUT endpoint-1 interrupt mask register
  $900 constant OTG_HS_DIEPCTL0         \ The application uses this register to control the behavior of each logical endpoint other than endpoint 0.
  $908 constant OTG_HS_DIEPINT0         \ This register indicates the status of an endpoint with respect to USB- and AHB-related events. It is shown in Figure724. The application must read this register when the IN endpoints interrupt bit of the core interrupt register (IEPINT in GINTSTS) is set. Before the application can read this register, it must first read the device all endpoints interrupt (DAINT) register to get the exact endpoint number for the device endpoint-x interrupt register. The application must clear the appropriate bit in this register to clear the corresponding bits in the DAINT and GINTSTS registers.
  $910 constant OTG_HS_DIEPTSIZ0        \ The application must modify this register before enabling endpoint 0.
  $918 constant OTG_HS_DTXFSTS0         \ This read-only register contains the free space information for the device IN endpoint Tx FIFO.
  $920 constant OTG_HS_DIEPCTL1         \ The application uses this register to control the behavior of each logical endpoint other than endpoint 0.
  $928 constant OTG_HS_DIEPINT1         \ This register indicates the status of an endpoint with respect to USB- and AHB-related events. It is shown in Figure724. The application must read this register when the IN endpoints interrupt bit of the core interrupt register (IEPINT in GINTSTS) is set. Before the application can read this register, it must first read the device all endpoints interrupt (DAINT) register to get the exact endpoint number for the device endpoint-x interrupt register. The application must clear the appropriate bit in this register to clear the corresponding bits in the DAINT and GINTSTS registers.
  $930 constant OTG_HS_DIEPTSIZ1        \ The application must modify this register before enabling the endpoint. Once the endpoint is enabled using the endpoint enable bit in the DIEPCTLx registers (EPENA bit in DIEPCTLx), the core modifies this register. The application can only read this register once the core has cleared the endpoint enable bit.
  $934 constant OTG_HS_DIEPDMA1         \ OTG device IN endpoint 1 DMA address register
  $938 constant OTG_HS_DTXFSTS1         \ This read-only register contains the free space information for the device IN endpoint Tx FIFO.
  $940 constant OTG_HS_DIEPCTL2         \ The application uses this register to control the behavior of each logical endpoint other than endpoint 0.
  $948 constant OTG_HS_DIEPINT2         \ This register indicates the status of an endpoint with respect to USB- and AHB-related events. It is shown in Figure724. The application must read this register when the IN endpoints interrupt bit of the core interrupt register (IEPINT in GINTSTS) is set. Before the application can read this register, it must first read the device all endpoints interrupt (DAINT) register to get the exact endpoint number for the device endpoint-x interrupt register. The application must clear the appropriate bit in this register to clear the corresponding bits in the DAINT and GINTSTS registers.
  $950 constant OTG_HS_DIEPTSIZ2        \ The application must modify this register before enabling the endpoint. Once the endpoint is enabled using the endpoint enable bit in the DIEPCTLx registers (EPENA bit in DIEPCTLx), the core modifies this register. The application can only read this register once the core has cleared the endpoint enable bit.
  $954 constant OTG_HS_DIEPDMA2         \ OTG device IN endpoint 2 DMA address register
  $958 constant OTG_HS_DTXFSTS2         \ This read-only register contains the free space information for the device IN endpoint Tx FIFO.
  $960 constant OTG_HS_DIEPCTL3         \ The application uses this register to control the behavior of each logical endpoint other than endpoint 0.
  $968 constant OTG_HS_DIEPINT3         \ This register indicates the status of an endpoint with respect to USB- and AHB-related events. It is shown in Figure724. The application must read this register when the IN endpoints interrupt bit of the core interrupt register (IEPINT in GINTSTS) is set. Before the application can read this register, it must first read the device all endpoints interrupt (DAINT) register to get the exact endpoint number for the device endpoint-x interrupt register. The application must clear the appropriate bit in this register to clear the corresponding bits in the DAINT and GINTSTS registers.
  $970 constant OTG_HS_DIEPTSIZ3        \ The application must modify this register before enabling the endpoint. Once the endpoint is enabled using the endpoint enable bit in the DIEPCTLx registers (EPENA bit in DIEPCTLx), the core modifies this register. The application can only read this register once the core has cleared the endpoint enable bit.
  $974 constant OTG_HS_DIEPDMA3         \ OTG device IN endpoint 3 DMA address register
  $978 constant OTG_HS_DTXFSTS3         \ This read-only register contains the free space information for the device IN endpoint Tx FIFO.
  $980 constant OTG_HS_DIEPCTL4         \ The application uses this register to control the behavior of each logical endpoint other than endpoint 0.
  $988 constant OTG_HS_DIEPINT4         \ This register indicates the status of an endpoint with respect to USB- and AHB-related events. It is shown in Figure724. The application must read this register when the IN endpoints interrupt bit of the core interrupt register (IEPINT in GINTSTS) is set. Before the application can read this register, it must first read the device all endpoints interrupt (DAINT) register to get the exact endpoint number for the device endpoint-x interrupt register. The application must clear the appropriate bit in this register to clear the corresponding bits in the DAINT and GINTSTS registers.
  $990 constant OTG_HS_DIEPTSIZ4        \ The application must modify this register before enabling the endpoint. Once the endpoint is enabled using the endpoint enable bit in the DIEPCTLx registers (EPENA bit in DIEPCTLx), the core modifies this register. The application can only read this register once the core has cleared the endpoint enable bit.
  $994 constant OTG_HS_DIEPDMA4         \ OTG device IN endpoint 4 DMA address register
  $998 constant OTG_HS_DTXFSTS4         \ This read-only register contains the free space information for the device IN endpoint Tx FIFO.
  $9A0 constant OTG_HS_DIEPCTL5         \ The application uses this register to control the behavior of each logical endpoint other than endpoint 0.
  $9A8 constant OTG_HS_DIEPINT5         \ This register indicates the status of an endpoint with respect to USB- and AHB-related events. It is shown in Figure724. The application must read this register when the IN endpoints interrupt bit of the core interrupt register (IEPINT in GINTSTS) is set. Before the application can read this register, it must first read the device all endpoints interrupt (DAINT) register to get the exact endpoint number for the device endpoint-x interrupt register. The application must clear the appropriate bit in this register to clear the corresponding bits in the DAINT and GINTSTS registers.
  $9B0 constant OTG_HS_DIEPTSIZ5        \ The application must modify this register before enabling the endpoint. Once the endpoint is enabled using the endpoint enable bit in the DIEPCTLx registers (EPENA bit in DIEPCTLx), the core modifies this register. The application can only read this register once the core has cleared the endpoint enable bit.
  $9B4 constant OTG_HS_DIEPDMA5         \ OTG device IN endpoint 5 DMA address register
  $9B8 constant OTG_HS_DTXFSTS5         \ This read-only register contains the free space information for the device IN endpoint Tx FIFO.
  $9C8 constant OTG_HS_DIEPINT6         \ This register indicates the status of an endpoint with respect to USB- and AHB-related events. It is shown in Figure724. The application must read this register when the IN endpoints interrupt bit of the core interrupt register (IEPINT in GINTSTS) is set. Before the application can read this register, it must first read the device all endpoints interrupt (DAINT) register to get the exact endpoint number for the device endpoint-x interrupt register. The application must clear the appropriate bit in this register to clear the corresponding bits in the DAINT and GINTSTS registers.
  $9D0 constant OTG_HS_DIEPTSIZ6        \ The application must modify this register before enabling the endpoint. Once the endpoint is enabled using the endpoint enable bit in the DIEPCTLx registers (EPENA bit in DIEPCTLx), the core modifies this register. The application can only read this register once the core has cleared the endpoint enable bit.
  $9D4 constant OTG_HS_DIEPDMA6         \ OTG device IN endpoint 6 DMA address register
  $9E8 constant OTG_HS_DIEPINT7         \ This register indicates the status of an endpoint with respect to USB- and AHB-related events. It is shown in Figure724. The application must read this register when the IN endpoints interrupt bit of the core interrupt register (IEPINT in GINTSTS) is set. Before the application can read this register, it must first read the device all endpoints interrupt (DAINT) register to get the exact endpoint number for the device endpoint-x interrupt register. The application must clear the appropriate bit in this register to clear the corresponding bits in the DAINT and GINTSTS registers.
  $9F0 constant OTG_HS_DIEPTSIZ7        \ The application must modify this register before enabling the endpoint. Once the endpoint is enabled using the endpoint enable bit in the DIEPCTLx registers (EPENA bit in DIEPCTLx), the core modifies this register. The application can only read this register once the core has cleared the endpoint enable bit.
  $9F4 constant OTG_HS_DIEPDMA7         \ OTG device IN endpoint 7 DMA address register
  $A08 constant OTG_HS_DIEPINT8         \ This register indicates the status of an endpoint with respect to USB- and AHB-related events. It is shown in Figure724. The application must read this register when the IN endpoints interrupt bit of the core interrupt register (IEPINT in GINTSTS) is set. Before the application can read this register, it must first read the device all endpoints interrupt (DAINT) register to get the exact endpoint number for the device endpoint-x interrupt register. The application must clear the appropriate bit in this register to clear the corresponding bits in the DAINT and GINTSTS registers.
  $A10 constant OTG_HS_DIEPTSIZ8        \ The application must modify this register before enabling the endpoint. Once the endpoint is enabled using the endpoint enable bit in the DIEPCTLx registers (EPENA bit in DIEPCTLx), the core modifies this register. The application can only read this register once the core has cleared the endpoint enable bit.
  $A14 constant OTG_HS_DIEPDMA8         \ OTG device IN endpoint 8 DMA address register
  $B00 constant OTG_HS_DOEPCTL0         \ This section describes the DOEPCTL0 register.
  $B08 constant OTG_HS_DOEPINT0         \ This register indicates the status of an endpoint with respect to USB- and AHB-related events. It is shown in Figure724. The application must read this register when the OUT endpoints interrupt bit of the GINTSTS register (OEPINT bit in GINTSTS) is set. Before the application can read this register, it must first read the DAINT register to get the exact endpoint number for the DOEPINTx register. The application must clear the appropriate bit in this register to clear the corresponding bits in the DAINT and GINTSTS registers.
  $B10 constant OTG_HS_DOEPTSIZ0        \ The application must modify this register before enabling endpoint 0.
  $B14 constant OTG_HS_DOEPDMA0         \ OTG device OUT endpoint 0 DMA address register
  $B20 constant OTG_HS_DOEPCTL1         \ The application uses this register to control the behavior of each logical endpoint other than endpoint 0.
  $B28 constant OTG_HS_DOEPINT1         \ This register indicates the status of an endpoint with respect to USB- and AHB-related events. It is shown in Figure724. The application must read this register when the OUT endpoints interrupt bit of the GINTSTS register (OEPINT bit in GINTSTS) is set. Before the application can read this register, it must first read the DAINT register to get the exact endpoint number for the DOEPINTx register. The application must clear the appropriate bit in this register to clear the corresponding bits in the DAINT and GINTSTS registers.
  $B30 constant OTG_HS_DOEPTSIZ1        \ The application must modify this register before enabling the endpoint. Once the endpoint is enabled using endpoint enable bit of the DOEPCTLx registers (EPENA bit in DOEPCTLx), the core modifies this register. The application can only read this register once the core has cleared the endpoint enable bit.
  $B34 constant OTG_HS_DOEPDMA1         \ OTG device OUT endpoint 1 DMA address register
  $B40 constant OTG_HS_DOEPCTL2         \ The application uses this register to control the behavior of each logical endpoint other than endpoint 0.
  $B48 constant OTG_HS_DOEPINT2         \ This register indicates the status of an endpoint with respect to USB- and AHB-related events. It is shown in Figure724. The application must read this register when the OUT endpoints interrupt bit of the GINTSTS register (OEPINT bit in GINTSTS) is set. Before the application can read this register, it must first read the DAINT register to get the exact endpoint number for the DOEPINTx register. The application must clear the appropriate bit in this register to clear the corresponding bits in the DAINT and GINTSTS registers.
  $B50 constant OTG_HS_DOEPTSIZ2        \ The application must modify this register before enabling the endpoint. Once the endpoint is enabled using endpoint enable bit of the DOEPCTLx registers (EPENA bit in DOEPCTLx), the core modifies this register. The application can only read this register once the core has cleared the endpoint enable bit.
  $B54 constant OTG_HS_DOEPDMA2         \ OTG device OUT endpoint 2 DMA address register
  $B60 constant OTG_HS_DOEPCTL3         \ The application uses this register to control the behavior of each logical endpoint other than endpoint 0.
  $B68 constant OTG_HS_DOEPINT3         \ This register indicates the status of an endpoint with respect to USB- and AHB-related events. It is shown in Figure724. The application must read this register when the OUT endpoints interrupt bit of the GINTSTS register (OEPINT bit in GINTSTS) is set. Before the application can read this register, it must first read the DAINT register to get the exact endpoint number for the DOEPINTx register. The application must clear the appropriate bit in this register to clear the corresponding bits in the DAINT and GINTSTS registers.
  $B70 constant OTG_HS_DOEPTSIZ3        \ The application must modify this register before enabling the endpoint. Once the endpoint is enabled using endpoint enable bit of the DOEPCTLx registers (EPENA bit in DOEPCTLx), the core modifies this register. The application can only read this register once the core has cleared the endpoint enable bit.
  $B74 constant OTG_HS_DOEPDMA3         \ OTG device OUT endpoint 3 DMA address register
  $B80 constant OTG_HS_DOEPCTL4         \ The application uses this register to control the behavior of each logical endpoint other than endpoint 0.
  $B88 constant OTG_HS_DOEPINT4         \ This register indicates the status of an endpoint with respect to USB- and AHB-related events. It is shown in Figure724. The application must read this register when the OUT endpoints interrupt bit of the GINTSTS register (OEPINT bit in GINTSTS) is set. Before the application can read this register, it must first read the DAINT register to get the exact endpoint number for the DOEPINTx register. The application must clear the appropriate bit in this register to clear the corresponding bits in the DAINT and GINTSTS registers.
  $B90 constant OTG_HS_DOEPTSIZ4        \ The application must modify this register before enabling the endpoint. Once the endpoint is enabled using endpoint enable bit of the DOEPCTLx registers (EPENA bit in DOEPCTLx), the core modifies this register. The application can only read this register once the core has cleared the endpoint enable bit.
  $B94 constant OTG_HS_DOEPDMA4         \ OTG device OUT endpoint 4 DMA address register
  $BA0 constant OTG_HS_DOEPCTL5         \ The application uses this register to control the behavior of each logical endpoint other than endpoint 0.
  $BA8 constant OTG_HS_DOEPINT5         \ This register indicates the status of an endpoint with respect to USB- and AHB-related events. It is shown in Figure724. The application must read this register when the OUT endpoints interrupt bit of the GINTSTS register (OEPINT bit in GINTSTS) is set. Before the application can read this register, it must first read the DAINT register to get the exact endpoint number for the DOEPINTx register. The application must clear the appropriate bit in this register to clear the corresponding bits in the DAINT and GINTSTS registers.
  $BB0 constant OTG_HS_DOEPTSIZ5        \ The application must modify this register before enabling the endpoint. Once the endpoint is enabled using endpoint enable bit of the DOEPCTLx registers (EPENA bit in DOEPCTLx), the core modifies this register. The application can only read this register once the core has cleared the endpoint enable bit.
  $BB4 constant OTG_HS_DOEPDMA5         \ OTG device OUT endpoint 5 DMA address register
  $BC0 constant OTG_HS_DOEPCTL6         \ The application uses this register to control the behavior of each logical endpoint other than endpoint 0.
  $BC8 constant OTG_HS_DOEPINT6         \ This register indicates the status of an endpoint with respect to USB- and AHB-related events. It is shown in Figure724. The application must read this register when the OUT endpoints interrupt bit of the GINTSTS register (OEPINT bit in GINTSTS) is set. Before the application can read this register, it must first read the DAINT register to get the exact endpoint number for the DOEPINTx register. The application must clear the appropriate bit in this register to clear the corresponding bits in the DAINT and GINTSTS registers.
  $BD0 constant OTG_HS_DOEPTSIZ6        \ The application must modify this register before enabling the endpoint. Once the endpoint is enabled using endpoint enable bit of the DOEPCTLx registers (EPENA bit in DOEPCTLx), the core modifies this register. The application can only read this register once the core has cleared the endpoint enable bit.
  $BD4 constant OTG_HS_DOEPDMA6         \ OTG device OUT endpoint 6 DMA address register
  $BE0 constant OTG_HS_DOEPCTL7         \ The application uses this register to control the behavior of each logical endpoint other than endpoint 0.
  $BE8 constant OTG_HS_DOEPINT7         \ This register indicates the status of an endpoint with respect to USB- and AHB-related events. It is shown in Figure724. The application must read this register when the OUT endpoints interrupt bit of the GINTSTS register (OEPINT bit in GINTSTS) is set. Before the application can read this register, it must first read the DAINT register to get the exact endpoint number for the DOEPINTx register. The application must clear the appropriate bit in this register to clear the corresponding bits in the DAINT and GINTSTS registers.
  $BF0 constant OTG_HS_DOEPTSIZ7        \ The application must modify this register before enabling the endpoint. Once the endpoint is enabled using endpoint enable bit of the DOEPCTLx registers (EPENA bit in DOEPCTLx), the core modifies this register. The application can only read this register once the core has cleared the endpoint enable bit.
  $BF4 constant OTG_HS_DOEPDMA7         \ OTG device OUT endpoint 7 DMA address register
  $C00 constant OTG_HS_DOEPCTL8         \ The application uses this register to control the behavior of each logical endpoint other than endpoint 0.
  $C08 constant OTG_HS_DOEPINT8         \ This register indicates the status of an endpoint with respect to USB- and AHB-related events. It is shown in Figure724. The application must read this register when the OUT endpoints interrupt bit of the GINTSTS register (OEPINT bit in GINTSTS) is set. Before the application can read this register, it must first read the DAINT register to get the exact endpoint number for the DOEPINTx register. The application must clear the appropriate bit in this register to clear the corresponding bits in the DAINT and GINTSTS registers.
  $C10 constant OTG_HS_DOEPTSIZ8        \ The application must modify this register before enabling the endpoint. Once the endpoint is enabled using endpoint enable bit of the DOEPCTLx registers (EPENA bit in DOEPCTLx), the core modifies this register. The application can only read this register once the core has cleared the endpoint enable bit.
  $C14 constant OTG_HS_DOEPDMA8         \ OTG device OUT endpoint 8 DMA address register
  $E00 constant OTG_HS_PCGCCTL          \ This register is available in host and device modes.

: OTG_HS_DEF ; [then]
