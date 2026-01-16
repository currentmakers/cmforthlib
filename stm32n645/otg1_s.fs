\
\ @file otg1_s.fs
\ @brief USB on-the-go high-speed
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief OTG control and status register
\ Address offset: 0x00
\ Reset value: 0x00010000
\

$00000004 constant OTG1_S_OTG_GOTGCTL_VBVALOEN                      \ V less than sub>BUS less than /sub> valid override enable.
$00000008 constant OTG1_S_OTG_GOTGCTL_VBVALOVAL                     \ V less than sub>BUS less than /sub> valid override value.
$00000010 constant OTG1_S_OTG_GOTGCTL_AVALOEN                       \ A-peripheral session valid override enable.
$00000020 constant OTG1_S_OTG_GOTGCTL_AVALOVAL                      \ A-peripheral session valid override value.
$00000040 constant OTG1_S_OTG_GOTGCTL_BVALOEN                       \ B-peripheral session valid override enable.
$00000080 constant OTG1_S_OTG_GOTGCTL_BVALOVAL                      \ B-peripheral session valid override value.
$00001000 constant OTG1_S_OTG_GOTGCTL_EHEN                          \ Embedded host enable
$00010000 constant OTG1_S_OTG_GOTGCTL_CIDSTS                        \ Connector ID status
$00020000 constant OTG1_S_OTG_GOTGCTL_DBCT                          \ Long/short debounce time
$00040000 constant OTG1_S_OTG_GOTGCTL_ASVLD                         \ A-session valid
$00080000 constant OTG1_S_OTG_GOTGCTL_BSVLD                         \ B-session valid
$00100000 constant OTG1_S_OTG_GOTGCTL_OTGVER                        \ OTG version
$00200000 constant OTG1_S_OTG_GOTGCTL_CURMOD                        \ Current mode of operation


\
\ @brief OTG interrupt register
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$00000004 constant OTG1_S_OTG_GOTGINT_SEDET                         \ Session end detected
$00040000 constant OTG1_S_OTG_GOTGINT_ADTOCHG                       \ A-device timeout change


\
\ @brief OTG AHB configuration register
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$00000001 constant OTG1_S_OTG_GAHBCFG_GINTMSK                       \ Global interrupt mask
$0000001e constant OTG1_S_OTG_GAHBCFG_HBSTLEN                       \ Burst length/type
$00000020 constant OTG1_S_OTG_GAHBCFG_DMAEN                         \ DMA enabled
$00000080 constant OTG1_S_OTG_GAHBCFG_TXFELVL                       \ Tx FIFO empty level
$00000100 constant OTG1_S_OTG_GAHBCFG_PTXFELVL                      \ Periodic Tx FIFO empty level


\
\ @brief OTG USB configuration register
\ Address offset: 0x0C
\ Reset value: 0x00001400
\

$00000007 constant OTG1_S_OTG_GUSBCFG_TOCAL                         \ FS timeout calibration
$00003c00 constant OTG1_S_OTG_GUSBCFG_TRDT                          \ USB turnaround time
$00008000 constant OTG1_S_OTG_GUSBCFG_PHYLPC                        \ PHY Low-power clock select
$00400000 constant OTG1_S_OTG_GUSBCFG_TSDPS                         \ TermSel DLine pulsing selection
$20000000 constant OTG1_S_OTG_GUSBCFG_FHMOD                         \ Force host mode
$40000000 constant OTG1_S_OTG_GUSBCFG_FDMOD                         \ Force device mode


\
\ @brief OTG reset register
\ Address offset: 0x10
\ Reset value: 0x80000000
\

$00000001 constant OTG1_S_OTG_GRSTCTL_CSRST                         \ Core soft reset
$00000002 constant OTG1_S_OTG_GRSTCTL_PSRST                         \ Partial soft reset
$00000004 constant OTG1_S_OTG_GRSTCTL_FCRST                         \ Host frame counter reset
$00000010 constant OTG1_S_OTG_GRSTCTL_RXFFLSH                       \ Rx FIFO flush
$00000020 constant OTG1_S_OTG_GRSTCTL_TXFFLSH                       \ Tx FIFO flush
$000007c0 constant OTG1_S_OTG_GRSTCTL_TXFNUM                        \ Tx FIFO number
$40000000 constant OTG1_S_OTG_GRSTCTL_DMAREQ                        \ DMA request signal enabled
$80000000 constant OTG1_S_OTG_GRSTCTL_AHBIDL                        \ AHB master idle


\
\ @brief OTG core interrupt register [alternate]
\ Address offset: 0x14
\ Reset value: 0x04000020
\

$00000001 constant OTG1_S_OTG_GINTSTS_CMOD                          \ Current mode of operation
$00000002 constant OTG1_S_OTG_GINTSTS_MMIS                          \ Mode mismatch interrupt
$00000004 constant OTG1_S_OTG_GINTSTS_OTGINT                        \ OTG interrupt
$00000008 constant OTG1_S_OTG_GINTSTS_SOF                           \ Start of frame
$00000010 constant OTG1_S_OTG_GINTSTS_RXFLVL                        \ Rx FIFO non-empty
$00000020 constant OTG1_S_OTG_GINTSTS_NPTXFE                        \ Non-periodic Tx FIFO empty
$00000040 constant OTG1_S_OTG_GINTSTS_GINAKEFF                      \ Global IN non-periodic NAK effective
$00000080 constant OTG1_S_OTG_GINTSTS_GONAKEFF                      \ Global OUT NAK effective
$00000400 constant OTG1_S_OTG_GINTSTS_ESUSP                         \ Early suspend
$00000800 constant OTG1_S_OTG_GINTSTS_USBSUSP                       \ USB suspend
$00001000 constant OTG1_S_OTG_GINTSTS_USBRST                        \ USB reset
$00002000 constant OTG1_S_OTG_GINTSTS_ENUMDNE                       \ Enumeration done
$00004000 constant OTG1_S_OTG_GINTSTS_ISOODRP                       \ Isochronous OUT packet dropped interrupt
$00008000 constant OTG1_S_OTG_GINTSTS_EOPF                          \ End of periodic frame interrupt
$00040000 constant OTG1_S_OTG_GINTSTS_IEPINT                        \ IN endpoint interrupt
$00080000 constant OTG1_S_OTG_GINTSTS_OEPINT                        \ OUT endpoint interrupt
$00100000 constant OTG1_S_OTG_GINTSTS_IISOIXFR                      \ Incomplete isochronous IN transfer
$00200000 constant OTG1_S_OTG_GINTSTS_IPXFR                         \ Incomplete periodic transfer
$00400000 constant OTG1_S_OTG_GINTSTS_DATAFSUSP                     \ Data fetch suspended
$00800000 constant OTG1_S_OTG_GINTSTS_RSTDET                        \ Reset detected interrupt
$01000000 constant OTG1_S_OTG_GINTSTS_HPRTINT                       \ Host port interrupt
$02000000 constant OTG1_S_OTG_GINTSTS_HCINT                         \ Host channels interrupt
$04000000 constant OTG1_S_OTG_GINTSTS_PTXFE                         \ Periodic Tx FIFO empty
$08000000 constant OTG1_S_OTG_GINTSTS_LPMINT                        \ LPM interrupt
$10000000 constant OTG1_S_OTG_GINTSTS_CIDSCHG                       \ Connector ID status change
$20000000 constant OTG1_S_OTG_GINTSTS_DISCINT                       \ Disconnect detected interrupt
$40000000 constant OTG1_S_OTG_GINTSTS_SRQINT                        \ Session request/new session detected interrupt
$80000000 constant OTG1_S_OTG_GINTSTS_WKUPINT                       \ Resume/remote wake-up detected interrupt


\
\ @brief OTG core interrupt register [alternate]
\ Address offset: 0x14
\ Reset value: 0x04000020
\

$00000001 constant OTG1_S_OTG_GINTSTS_ALTERNATE_CMOD                \ Current mode of operation
$00000002 constant OTG1_S_OTG_GINTSTS_ALTERNATE_MMIS                \ Mode mismatch interrupt
$00000004 constant OTG1_S_OTG_GINTSTS_ALTERNATE_OTGINT              \ OTG interrupt
$00000008 constant OTG1_S_OTG_GINTSTS_ALTERNATE_SOF                 \ Start of frame
$00000010 constant OTG1_S_OTG_GINTSTS_ALTERNATE_RXFLVL              \ Rx FIFO non-empty
$00000020 constant OTG1_S_OTG_GINTSTS_ALTERNATE_NPTXFE              \ Non-periodic Tx FIFO empty
$00000040 constant OTG1_S_OTG_GINTSTS_ALTERNATE_GINAKEFF            \ Global IN non-periodic NAK effective
$00000080 constant OTG1_S_OTG_GINTSTS_ALTERNATE_GONAKEFF            \ Global OUT NAK effective
$00000400 constant OTG1_S_OTG_GINTSTS_ALTERNATE_ESUSP               \ Early suspend
$00000800 constant OTG1_S_OTG_GINTSTS_ALTERNATE_USBSUSP             \ USB suspend
$00001000 constant OTG1_S_OTG_GINTSTS_ALTERNATE_USBRST              \ USB reset
$00002000 constant OTG1_S_OTG_GINTSTS_ALTERNATE_ENUMDNE             \ Enumeration done
$00004000 constant OTG1_S_OTG_GINTSTS_ALTERNATE_ISOODRP             \ Isochronous OUT packet dropped interrupt
$00008000 constant OTG1_S_OTG_GINTSTS_ALTERNATE_EOPF                \ End of periodic frame interrupt
$00040000 constant OTG1_S_OTG_GINTSTS_ALTERNATE_IEPINT              \ IN endpoint interrupt
$00080000 constant OTG1_S_OTG_GINTSTS_ALTERNATE_OEPINT              \ OUT endpoint interrupt
$00100000 constant OTG1_S_OTG_GINTSTS_ALTERNATE_IISOIXFR            \ Incomplete isochronous IN transfer
$00200000 constant OTG1_S_OTG_GINTSTS_ALTERNATE_INCOMPISOOUT        \ Incomplete isochronous OUT transfer
$00400000 constant OTG1_S_OTG_GINTSTS_ALTERNATE_DATAFSUSP           \ Data fetch suspended
$00800000 constant OTG1_S_OTG_GINTSTS_ALTERNATE_RSTDET              \ Reset detected interrupt
$01000000 constant OTG1_S_OTG_GINTSTS_ALTERNATE_HPRTINT             \ Host port interrupt
$02000000 constant OTG1_S_OTG_GINTSTS_ALTERNATE_HCINT               \ Host channels interrupt
$04000000 constant OTG1_S_OTG_GINTSTS_ALTERNATE_PTXFE               \ Periodic Tx FIFO empty
$08000000 constant OTG1_S_OTG_GINTSTS_ALTERNATE_LPMINT              \ LPM interrupt
$10000000 constant OTG1_S_OTG_GINTSTS_ALTERNATE_CIDSCHG             \ Connector ID status change
$20000000 constant OTG1_S_OTG_GINTSTS_ALTERNATE_DISCINT             \ Disconnect detected interrupt
$40000000 constant OTG1_S_OTG_GINTSTS_ALTERNATE_SRQINT              \ Session request/new session detected interrupt
$80000000 constant OTG1_S_OTG_GINTSTS_ALTERNATE_WKUPINT             \ Resume/remote wake-up detected interrupt


\
\ @brief OTG interrupt mask register [alternate]
\ Address offset: 0x18
\ Reset value: 0x00000000
\

$00000002 constant OTG1_S_OTG_GINTMSK_MMISM                         \ Mode mismatch interrupt mask
$00000004 constant OTG1_S_OTG_GINTMSK_OTGINT                        \ OTG interrupt mask
$00000008 constant OTG1_S_OTG_GINTMSK_SOFM                          \ Start of frame mask
$00000010 constant OTG1_S_OTG_GINTMSK_RXFLVLM                       \ Receive FIFO non-empty mask
$00000020 constant OTG1_S_OTG_GINTMSK_NPTXFEM                       \ Non-periodic Tx FIFO empty mask
$00200000 constant OTG1_S_OTG_GINTMSK_IPXFRM                        \ Incomplete periodic transfer mask
$01000000 constant OTG1_S_OTG_GINTMSK_PRTIM                         \ Host port interrupt mask
$02000000 constant OTG1_S_OTG_GINTMSK_HCIM                          \ Host channels interrupt mask
$04000000 constant OTG1_S_OTG_GINTMSK_PTXFEM                        \ Periodic Tx FIFO empty mask
$08000000 constant OTG1_S_OTG_GINTMSK_LPMINTM                       \ LPM interrupt mask
$10000000 constant OTG1_S_OTG_GINTMSK_CIDSCHGM                      \ Connector ID status change mask
$20000000 constant OTG1_S_OTG_GINTMSK_DISCINT                       \ Disconnect detected interrupt mask
$40000000 constant OTG1_S_OTG_GINTMSK_SRQIM                         \ Session request/new session detected interrupt mask
$80000000 constant OTG1_S_OTG_GINTMSK_WUIM                          \ Resume/remote wake-up detected interrupt mask


\
\ @brief OTG interrupt mask register [alternate]
\ Address offset: 0x18
\ Reset value: 0x00000000
\

$00000002 constant OTG1_S_OTG_GINTMSK_ALTERNATE_MMISM               \ Mode mismatch interrupt mask
$00000004 constant OTG1_S_OTG_GINTMSK_ALTERNATE_OTGINT              \ OTG interrupt mask
$00000008 constant OTG1_S_OTG_GINTMSK_ALTERNATE_SOFM                \ Start of frame mask
$00000010 constant OTG1_S_OTG_GINTMSK_ALTERNATE_RXFLVLM             \ Receive FIFO non-empty mask
$00000040 constant OTG1_S_OTG_GINTMSK_ALTERNATE_GINAKEFFM           \ Global non-periodic IN NAK effective mask
$00000080 constant OTG1_S_OTG_GINTMSK_ALTERNATE_GONAKEFFM           \ Global OUT NAK effective mask
$00000400 constant OTG1_S_OTG_GINTMSK_ALTERNATE_ESUSPM              \ Early suspend mask
$00000800 constant OTG1_S_OTG_GINTMSK_ALTERNATE_USBSUSPM            \ USB suspend mask
$00001000 constant OTG1_S_OTG_GINTMSK_ALTERNATE_USBRST              \ USB reset mask
$00002000 constant OTG1_S_OTG_GINTMSK_ALTERNATE_ENUMDNEM            \ Enumeration done mask
$00004000 constant OTG1_S_OTG_GINTMSK_ALTERNATE_ISOODRPM            \ Isochronous OUT packet dropped interrupt mask
$00008000 constant OTG1_S_OTG_GINTMSK_ALTERNATE_EOPFM               \ End of periodic frame interrupt mask
$00040000 constant OTG1_S_OTG_GINTMSK_ALTERNATE_IEPINT              \ IN endpoints interrupt mask
$00080000 constant OTG1_S_OTG_GINTMSK_ALTERNATE_OEPINT              \ OUT endpoints interrupt mask
$00100000 constant OTG1_S_OTG_GINTMSK_ALTERNATE_IISOIXFRM           \ Incomplete isochronous IN transfer mask
$00200000 constant OTG1_S_OTG_GINTMSK_ALTERNATE_IISOOXFRM           \ Incomplete isochronous OUT transfer mask
$00400000 constant OTG1_S_OTG_GINTMSK_ALTERNATE_FSUSPM              \ Data fetch suspended mask
$00800000 constant OTG1_S_OTG_GINTMSK_ALTERNATE_RSTDETM             \ Reset detected interrupt mask
$08000000 constant OTG1_S_OTG_GINTMSK_ALTERNATE_LPMINTM             \ LPM interrupt mask
$10000000 constant OTG1_S_OTG_GINTMSK_ALTERNATE_CIDSCHGM            \ Connector ID status change mask
$40000000 constant OTG1_S_OTG_GINTMSK_ALTERNATE_SRQIM               \ Session request/new session detected interrupt mask
$80000000 constant OTG1_S_OTG_GINTMSK_ALTERNATE_WUIM                \ Resume/remote wake-up detected interrupt mask


\
\ @brief OTG receive status debug read register [alternate]
\ Address offset: 0x1C
\ Reset value: 0x00000000
\

$0000000f constant OTG1_S_OTG_GRXSTSR_EPNUM                         \ Endpoint number
$00007ff0 constant OTG1_S_OTG_GRXSTSR_BCNT                          \ Byte count
$00018000 constant OTG1_S_OTG_GRXSTSR_DPID                          \ Data PID
$001e0000 constant OTG1_S_OTG_GRXSTSR_PKTSTS                        \ Packet status
$01e00000 constant OTG1_S_OTG_GRXSTSR_FRMNUM                        \ Frame number
$08000000 constant OTG1_S_OTG_GRXSTSR_STSPHST                       \ Status phase start


\
\ @brief OTG receive status debug read register [alternate]
\ Address offset: 0x1C
\ Reset value: 0x00000000
\

$0000000f constant OTG1_S_OTG_GRXSTSR_ALTERNATE_CHNUM               \ Channel number
$00007ff0 constant OTG1_S_OTG_GRXSTSR_ALTERNATE_BCNT                \ Byte count
$00018000 constant OTG1_S_OTG_GRXSTSR_ALTERNATE_DPID                \ Data PID
$001e0000 constant OTG1_S_OTG_GRXSTSR_ALTERNATE_PKTSTS              \ Packet status


\
\ @brief OTG status read and pop registers
\ Address offset: 0x20
\ Reset value: 0x00000000
\

$0000000f constant OTG1_S_OTG_GRXSTSP_EPNUM                         \ Endpoint number
$00007ff0 constant OTG1_S_OTG_GRXSTSP_BCNT                          \ Byte count
$00018000 constant OTG1_S_OTG_GRXSTSP_DPID                          \ Data PID
$001e0000 constant OTG1_S_OTG_GRXSTSP_PKTSTS                        \ Packet status
$01e00000 constant OTG1_S_OTG_GRXSTSP_FRMNUM                        \ Frame number
$08000000 constant OTG1_S_OTG_GRXSTSP_STSPHST                       \ Status phase start


\
\ @brief OTG status read and pop registers
\ Address offset: 0x20
\ Reset value: 0x00000000
\

$0000000f constant OTG1_S_OTG_GRXSTSP_ALTERNATE_CHNUM               \ Channel number
$00007ff0 constant OTG1_S_OTG_GRXSTSP_ALTERNATE_BCNT                \ Byte count
$00018000 constant OTG1_S_OTG_GRXSTSP_ALTERNATE_DPID                \ Data PID
$001e0000 constant OTG1_S_OTG_GRXSTSP_ALTERNATE_PKTSTS              \ Packet status


\
\ @brief OTG receive FIFO size register
\ Address offset: 0x24
\ Reset value: 0x00000400
\

$0000ffff constant OTG1_S_OTG_GRXFSIZ_RXFD                          \ Rx FIFO depth


\
\ @brief OTG host non-periodic transmit FIFO size register [alternate]
\ Address offset: 0x28
\ Reset value: 0x02000200
\

$0000ffff constant OTG1_S_OTG_HNPTXFSIZ_NPTXFSA                     \ Non-periodic transmit RAM start address
$ffff0000 constant OTG1_S_OTG_HNPTXFSIZ_NPTXFD                      \ Non-periodic Tx FIFO depth


\
\ @brief OTG host non-periodic transmit FIFO size register [alternate]
\ Address offset: 0x28
\ Reset value: 0x02000200
\

$0000ffff constant OTG1_S_OTG_HNPTXFSIZ_ALTERNATE_TX0FSA            \ Endpoint 0 transmit RAM start address
$ffff0000 constant OTG1_S_OTG_HNPTXFSIZ_ALTERNATE_TX0FD             \ Endpoint 0 Tx FIFO depth


\
\ @brief OTG non-periodic transmit FIFO/queue status register
\ Address offset: 0x2C
\ Reset value: 0x00080400
\

$0000ffff constant OTG1_S_OTG_HNPTXSTS_NPTXFSAV                     \ Non-periodic Tx FIFO space available
$00ff0000 constant OTG1_S_OTG_HNPTXSTS_NPTQXSAV                     \ Non-periodic transmit request queue space available
$7f000000 constant OTG1_S_OTG_HNPTXSTS_NPTXQTOP                     \ Top of the non-periodic transmit request queue


\
\ @brief OTG general core configuration register
\ Address offset: 0x38
\ Reset value: 0x00000000
\

$00000001 constant OTG1_S_OTG_GCCFG_CHGDET                          \ Charger detection, result of the current mode (primary or secondary).
$00000002 constant OTG1_S_OTG_GCCFG_FSVPLUS                         \ Single-Ended DP indicator
$00000004 constant OTG1_S_OTG_GCCFG_FSVMINUS                        \ Single-Ended DM indicator
$00000008 constant OTG1_S_OTG_GCCFG_SESSVLD                         \ VBUS session indicator
$00000010 constant OTG1_S_OTG_GCCFG_VBUSVLD                         \ VBUS valid indicator
$00010000 constant OTG1_S_OTG_GCCFG_HCDPEN                          \ Host CDP behavior enable
$00020000 constant OTG1_S_OTG_GCCFG_HCDPDETEN                       \ Host CDP port voltage detector enable on DP
$00040000 constant OTG1_S_OTG_GCCFG_HVDMSRCEN                       \ Host CDP port Voltage source enable on DM
$00080000 constant OTG1_S_OTG_GCCFG_DCDEN                           \ Data Contact Detection enable
$00100000 constant OTG1_S_OTG_GCCFG_PDEN                            \ Primary detection enable
$00400000 constant OTG1_S_OTG_GCCFG_SDEN                            \ Secondary detection enable
$00800000 constant OTG1_S_OTG_GCCFG_VBVALOVAL                       \ Software override value of the VBUS B-session detection
$02000000 constant OTG1_S_OTG_GCCFG_FORCEHOSTPD                     \ Force host mode pull-downs
$04000000 constant OTG1_S_OTG_GCCFG_BCDEN                           \ Force Battery charging (BC) mode
$10000000 constant OTG1_S_OTG_GCCFG_IDPULLUPDIS                     \ Disable ID pin pull-up


\
\ @brief OTG core ID register
\ Address offset: 0x3C
\ Reset value: 0x00005000
\

$00000000 constant OTG1_S_OTG_CID_PRODUCT_ID                        \ Product ID field


\
\ @brief OTG core LPM configuration register
\ Address offset: 0x54
\ Reset value: 0x00000000
\

$00000001 constant OTG1_S_OTG_GLPMCFG_LPMEN                         \ LPM support enable
$00000002 constant OTG1_S_OTG_GLPMCFG_LPMACK                        \ LPM token acknowledge enable
$0000003c constant OTG1_S_OTG_GLPMCFG_BESL                          \ Best effort service latency
$00000040 constant OTG1_S_OTG_GLPMCFG_REMWAKE                       \ bRemoteWake value
$00000080 constant OTG1_S_OTG_GLPMCFG_L1SSEN                        \ L1 Shallow Sleep enable
$00000f00 constant OTG1_S_OTG_GLPMCFG_BESLTHRS                      \ BESL threshold
$00001000 constant OTG1_S_OTG_GLPMCFG_L1DSEN                        \ L1 deep sleep enable
$00006000 constant OTG1_S_OTG_GLPMCFG_LPMRSP                        \ LPM response
$00008000 constant OTG1_S_OTG_GLPMCFG_SLPSTS                        \ Port sleep status
$00010000 constant OTG1_S_OTG_GLPMCFG_L1RSMOK                       \ Sleep state resume OK
$001e0000 constant OTG1_S_OTG_GLPMCFG_LPMCHIDX                      \ LPM Channel Index
$00e00000 constant OTG1_S_OTG_GLPMCFG_LPMRCNT                       \ LPM retry count
$01000000 constant OTG1_S_OTG_GLPMCFG_SNDLPM                        \ Send LPM transaction
$0e000000 constant OTG1_S_OTG_GLPMCFG_LPMRCNTSTS                    \ LPM retry count status
$10000000 constant OTG1_S_OTG_GLPMCFG_ENBESL                        \ Enable best effort service latency


\
\ @brief OTG host periodic transmit FIFO size register
\ Address offset: 0x100
\ Reset value: 0x04000800
\

$0000ffff constant OTG1_S_OTG_HPTXFSIZ_PTXSA                        \ Host periodic Tx FIFO start address
$ffff0000 constant OTG1_S_OTG_HPTXFSIZ_PTXFSIZ                      \ Host periodic Tx FIFO depth


\
\ @brief OTG device IN endpoint transmit FIFO 1 size register
\ Address offset: 0x104
\ Reset value: 0x02000400
\

$0000ffff constant OTG1_S_OTG_DIEPTXF1_INEPTXSA                     \ IN endpoint FIFOx transmit RAM start address
$ffff0000 constant OTG1_S_OTG_DIEPTXF1_INEPTXFD                     \ IN endpoint Tx FIFO depth


\
\ @brief OTG device IN endpoint transmit FIFO 2 size register
\ Address offset: 0x108
\ Reset value: 0x02000600
\

$0000ffff constant OTG1_S_OTG_DIEPTXF2_INEPTXSA                     \ IN endpoint FIFOx transmit RAM start address
$ffff0000 constant OTG1_S_OTG_DIEPTXF2_INEPTXFD                     \ IN endpoint Tx FIFO depth


\
\ @brief OTG device IN endpoint transmit FIFO 3 size register
\ Address offset: 0x10C
\ Reset value: 0x02000800
\

$0000ffff constant OTG1_S_OTG_DIEPTXF3_INEPTXSA                     \ IN endpoint FIFOx transmit RAM start address
$ffff0000 constant OTG1_S_OTG_DIEPTXF3_INEPTXFD                     \ IN endpoint Tx FIFO depth


\
\ @brief OTG device IN endpoint transmit FIFO 4 size register
\ Address offset: 0x110
\ Reset value: 0x02000A00
\

$0000ffff constant OTG1_S_OTG_DIEPTXF4_INEPTXSA                     \ IN endpoint FIFOx transmit RAM start address
$ffff0000 constant OTG1_S_OTG_DIEPTXF4_INEPTXFD                     \ IN endpoint Tx FIFO depth


\
\ @brief OTG device IN endpoint transmit FIFO 5 size register
\ Address offset: 0x114
\ Reset value: 0x02000C00
\

$0000ffff constant OTG1_S_OTG_DIEPTXF5_INEPTXSA                     \ IN endpoint FIFOx transmit RAM start address
$ffff0000 constant OTG1_S_OTG_DIEPTXF5_INEPTXFD                     \ IN endpoint Tx FIFO depth


\
\ @brief OTG device IN endpoint transmit FIFO 6 size register
\ Address offset: 0x118
\ Reset value: 0x02000E00
\

$0000ffff constant OTG1_S_OTG_DIEPTXF6_INEPTXSA                     \ IN endpoint FIFOx transmit RAM start address
$ffff0000 constant OTG1_S_OTG_DIEPTXF6_INEPTXFD                     \ IN endpoint Tx FIFO depth


\
\ @brief OTG device IN endpoint transmit FIFO 7 size register
\ Address offset: 0x11C
\ Reset value: 0x02001000
\

$0000ffff constant OTG1_S_OTG_DIEPTXF7_INEPTXSA                     \ IN endpoint FIFOx transmit RAM start address
$ffff0000 constant OTG1_S_OTG_DIEPTXF7_INEPTXFD                     \ IN endpoint Tx FIFO depth


\
\ @brief OTG device IN endpoint transmit FIFO 8 size register
\ Address offset: 0x120
\ Reset value: 0x02001200
\

$0000ffff constant OTG1_S_OTG_DIEPTXF8_INEPTXSA                     \ IN endpoint FIFOx transmit RAM start address
$ffff0000 constant OTG1_S_OTG_DIEPTXF8_INEPTXFD                     \ IN endpoint Tx FIFO depth


\
\ @brief OTG host configuration register
\ Address offset: 0x400
\ Reset value: 0x00000000
\

$00000003 constant OTG1_S_OTG_HCFG_FSLSPCS                          \ FS/LS PHY clock select
$00000004 constant OTG1_S_OTG_HCFG_FSLSS                            \ FS- and LS-only support


\
\ @brief OTG host frame interval register
\ Address offset: 0x404
\ Reset value: 0x0000EA60
\

$0000ffff constant OTG1_S_OTG_HFIR_FRIVL                            \ Frame interval
$00010000 constant OTG1_S_OTG_HFIR_RLDCTRL                          \ Reload control


\
\ @brief OTG host frame number/frame time remaining register
\ Address offset: 0x408
\ Reset value: 0x00003FFF
\

$0000ffff constant OTG1_S_OTG_HFNUM_FRNUM                           \ Frame number
$ffff0000 constant OTG1_S_OTG_HFNUM_FTREM                           \ Frame time remaining


\
\ @brief OTG_Host periodic transmit FIFO/queue status register
\ Address offset: 0x410
\ Reset value: 0x00080100
\

$0000ffff constant OTG1_S_OTG_HPTXSTS_PTXFSAVL                      \ Periodic transmit data FIFO space available
$00ff0000 constant OTG1_S_OTG_HPTXSTS_PTXQSAV                       \ Periodic transmit request queue space available
$ff000000 constant OTG1_S_OTG_HPTXSTS_PTXQTOP                       \ Top of the periodic transmit request queue


\
\ @brief OTG host all channels interrupt register
\ Address offset: 0x414
\ Reset value: 0x00000000
\

$0000ffff constant OTG1_S_OTG_HAINT_HAINT                           \ Channel interrupts


\
\ @brief OTG host all channels interrupt mask register
\ Address offset: 0x418
\ Reset value: 0x00000000
\

$0000ffff constant OTG1_S_OTG_HAINTMSK_HAINTM                       \ Channel interrupt mask


\
\ @brief OTG host port control and status register
\ Address offset: 0x440
\ Reset value: 0x00000000
\

$00000001 constant OTG1_S_OTG_HPRT_PCSTS                            \ Port connect status
$00000002 constant OTG1_S_OTG_HPRT_PCDET                            \ Port connect detected
$00000004 constant OTG1_S_OTG_HPRT_PENA                             \ Port enable
$00000008 constant OTG1_S_OTG_HPRT_PENCHNG                          \ Port enable/disable change
$00000010 constant OTG1_S_OTG_HPRT_POCA                             \ Port overcurrent active
$00000020 constant OTG1_S_OTG_HPRT_POCCHNG                          \ Port overcurrent change
$00000040 constant OTG1_S_OTG_HPRT_PRES                             \ Port resume
$00000080 constant OTG1_S_OTG_HPRT_PSUSP                            \ Port suspend
$00000100 constant OTG1_S_OTG_HPRT_PRST                             \ Port reset
$00000c00 constant OTG1_S_OTG_HPRT_PLSTS                            \ Port line status
$00001000 constant OTG1_S_OTG_HPRT_PPWR                             \ Port power
$0001e000 constant OTG1_S_OTG_HPRT_PTCTL                            \ Port test control
$00060000 constant OTG1_S_OTG_HPRT_PSPD                             \ Port speed


\
\ @brief OTG host channel 0 characteristics register
\ Address offset: 0x500
\ Reset value: 0x00000000
\

$000007ff constant OTG1_S_OTG_HCCHAR0_MPSIZ                         \ Maximum packet size
$00007800 constant OTG1_S_OTG_HCCHAR0_EPNUM                         \ Endpoint number
$00008000 constant OTG1_S_OTG_HCCHAR0_EPDIR                         \ Endpoint direction
$00020000 constant OTG1_S_OTG_HCCHAR0_LSDEV                         \ Low-speed device
$000c0000 constant OTG1_S_OTG_HCCHAR0_EPTYP                         \ Endpoint type
$00300000 constant OTG1_S_OTG_HCCHAR0_MCNT                          \ Multicount
$1fc00000 constant OTG1_S_OTG_HCCHAR0_DAD                           \ Device address
$20000000 constant OTG1_S_OTG_HCCHAR0_ODDFRM                        \ Odd frame
$40000000 constant OTG1_S_OTG_HCCHAR0_CHDIS                         \ Channel disable
$80000000 constant OTG1_S_OTG_HCCHAR0_CHENA                         \ Channel enable


\
\ @brief OTG host channel 0 split control register
\ Address offset: 0x504
\ Reset value: 0x00000000
\

$0000007f constant OTG1_S_OTG_HCSPLT0_PRTADDR                       \ Port address
$00003f80 constant OTG1_S_OTG_HCSPLT0_HUBADDR                       \ Hub address
$0000c000 constant OTG1_S_OTG_HCSPLT0_XACTPOS                       \ Transaction position
$00010000 constant OTG1_S_OTG_HCSPLT0_COMPLSPLT                     \ Do complete split
$80000000 constant OTG1_S_OTG_HCSPLT0_SPLITEN                       \ Split enable


\
\ @brief OTG host channel 0 interrupt register
\ Address offset: 0x508
\ Reset value: 0x00000000
\

$00000001 constant OTG1_S_OTG_HCINT0_XFRC                           \ Transfer completed.
$00000002 constant OTG1_S_OTG_HCINT0_CHH                            \ Channel halted.
$00000004 constant OTG1_S_OTG_HCINT0_AHBERR                         \ AHB error
$00000008 constant OTG1_S_OTG_HCINT0_STALL                          \ STALL response received interrupt.
$00000010 constant OTG1_S_OTG_HCINT0_NAK                            \ NAK response received interrupt.
$00000020 constant OTG1_S_OTG_HCINT0_ACK                            \ ACK response received/transmitted interrupt.
$00000040 constant OTG1_S_OTG_HCINT0_NYET                           \ Not yet ready response received interrupt.
$00000080 constant OTG1_S_OTG_HCINT0_TXERR                          \ Transaction error.
$00000100 constant OTG1_S_OTG_HCINT0_BBERR                          \ Babble error.
$00000200 constant OTG1_S_OTG_HCINT0_FRMOR                          \ Frame overrun.
$00000400 constant OTG1_S_OTG_HCINT0_DTERR                          \ Data toggle error.


\
\ @brief OTG host channel 0 interrupt mask register
\ Address offset: 0x50C
\ Reset value: 0x00000000
\

$00000001 constant OTG1_S_OTG_HCINTMSK0_XFRCM                       \ Transfer completed mask
$00000002 constant OTG1_S_OTG_HCINTMSK0_CHHM                        \ Channel halted mask
$00000004 constant OTG1_S_OTG_HCINTMSK0_AHBERRM                     \ AHB error.
$00000008 constant OTG1_S_OTG_HCINTMSK0_STALLM                      \ STALL response received interrupt mask.
$00000010 constant OTG1_S_OTG_HCINTMSK0_NAKM                        \ NAK response received interrupt mask.
$00000020 constant OTG1_S_OTG_HCINTMSK0_ACKM                        \ ACK response received/transmitted interrupt mask.
$00000040 constant OTG1_S_OTG_HCINTMSK0_NYET                        \ response received interrupt mask.
$00000080 constant OTG1_S_OTG_HCINTMSK0_TXERRM                      \ Transaction error mask.
$00000100 constant OTG1_S_OTG_HCINTMSK0_BBERRM                      \ Babble error mask.
$00000200 constant OTG1_S_OTG_HCINTMSK0_FRMORM                      \ Frame overrun mask.
$00000400 constant OTG1_S_OTG_HCINTMSK0_DTERRM                      \ Data toggle error mask.


\
\ @brief OTG host channel 0 transfer size register
\ Address offset: 0x510
\ Reset value: 0x00000000
\

$0007ffff constant OTG1_S_OTG_HCTSIZ0_XFRSIZ                        \ Transfer size
$1ff80000 constant OTG1_S_OTG_HCTSIZ0_PKTCNT                        \ Packet count
$60000000 constant OTG1_S_OTG_HCTSIZ0_DPID                          \ Data PID
$80000000 constant OTG1_S_OTG_HCTSIZ0_DOPNG                         \ Do Ping


\
\ @brief OTG host channel 0 DMA address register
\ Address offset: 0x514
\ Reset value: 0x00000000
\

$00000000 constant OTG1_S_OTG_HCDMA0_DMAADDR                        \ DMA address


\
\ @brief OTG host channel 1 characteristics register
\ Address offset: 0x520
\ Reset value: 0x00000000
\

$000007ff constant OTG1_S_OTG_HCCHAR1_MPSIZ                         \ Maximum packet size
$00007800 constant OTG1_S_OTG_HCCHAR1_EPNUM                         \ Endpoint number
$00008000 constant OTG1_S_OTG_HCCHAR1_EPDIR                         \ Endpoint direction
$00020000 constant OTG1_S_OTG_HCCHAR1_LSDEV                         \ Low-speed device
$000c0000 constant OTG1_S_OTG_HCCHAR1_EPTYP                         \ Endpoint type
$00300000 constant OTG1_S_OTG_HCCHAR1_MCNT                          \ Multicount
$1fc00000 constant OTG1_S_OTG_HCCHAR1_DAD                           \ Device address
$20000000 constant OTG1_S_OTG_HCCHAR1_ODDFRM                        \ Odd frame
$40000000 constant OTG1_S_OTG_HCCHAR1_CHDIS                         \ Channel disable
$80000000 constant OTG1_S_OTG_HCCHAR1_CHENA                         \ Channel enable


\
\ @brief OTG host channel 1 split control register
\ Address offset: 0x524
\ Reset value: 0x00000000
\

$0000007f constant OTG1_S_OTG_HCSPLT1_PRTADDR                       \ Port address
$00003f80 constant OTG1_S_OTG_HCSPLT1_HUBADDR                       \ Hub address
$0000c000 constant OTG1_S_OTG_HCSPLT1_XACTPOS                       \ Transaction position
$00010000 constant OTG1_S_OTG_HCSPLT1_COMPLSPLT                     \ Do complete split
$80000000 constant OTG1_S_OTG_HCSPLT1_SPLITEN                       \ Split enable


\
\ @brief OTG host channel 1 interrupt register
\ Address offset: 0x528
\ Reset value: 0x00000000
\

$00000001 constant OTG1_S_OTG_HCINT1_XFRC                           \ Transfer completed.
$00000002 constant OTG1_S_OTG_HCINT1_CHH                            \ Channel halted.
$00000004 constant OTG1_S_OTG_HCINT1_AHBERR                         \ AHB error
$00000008 constant OTG1_S_OTG_HCINT1_STALL                          \ STALL response received interrupt.
$00000010 constant OTG1_S_OTG_HCINT1_NAK                            \ NAK response received interrupt.
$00000020 constant OTG1_S_OTG_HCINT1_ACK                            \ ACK response received/transmitted interrupt.
$00000040 constant OTG1_S_OTG_HCINT1_NYET                           \ Not yet ready response received interrupt.
$00000080 constant OTG1_S_OTG_HCINT1_TXERR                          \ Transaction error.
$00000100 constant OTG1_S_OTG_HCINT1_BBERR                          \ Babble error.
$00000200 constant OTG1_S_OTG_HCINT1_FRMOR                          \ Frame overrun.
$00000400 constant OTG1_S_OTG_HCINT1_DTERR                          \ Data toggle error.


\
\ @brief OTG host channel 1 interrupt mask register
\ Address offset: 0x52C
\ Reset value: 0x00000000
\

$00000001 constant OTG1_S_OTG_HCINTMSK1_XFRCM                       \ Transfer completed mask
$00000002 constant OTG1_S_OTG_HCINTMSK1_CHHM                        \ Channel halted mask
$00000004 constant OTG1_S_OTG_HCINTMSK1_AHBERRM                     \ AHB error.
$00000008 constant OTG1_S_OTG_HCINTMSK1_STALLM                      \ STALL response received interrupt mask.
$00000010 constant OTG1_S_OTG_HCINTMSK1_NAKM                        \ NAK response received interrupt mask.
$00000020 constant OTG1_S_OTG_HCINTMSK1_ACKM                        \ ACK response received/transmitted interrupt mask.
$00000040 constant OTG1_S_OTG_HCINTMSK1_NYET                        \ response received interrupt mask.
$00000080 constant OTG1_S_OTG_HCINTMSK1_TXERRM                      \ Transaction error mask.
$00000100 constant OTG1_S_OTG_HCINTMSK1_BBERRM                      \ Babble error mask.
$00000200 constant OTG1_S_OTG_HCINTMSK1_FRMORM                      \ Frame overrun mask.
$00000400 constant OTG1_S_OTG_HCINTMSK1_DTERRM                      \ Data toggle error mask.


\
\ @brief OTG host channel 1 transfer size register
\ Address offset: 0x530
\ Reset value: 0x00000000
\

$0007ffff constant OTG1_S_OTG_HCTSIZ1_XFRSIZ                        \ Transfer size
$1ff80000 constant OTG1_S_OTG_HCTSIZ1_PKTCNT                        \ Packet count
$60000000 constant OTG1_S_OTG_HCTSIZ1_DPID                          \ Data PID
$80000000 constant OTG1_S_OTG_HCTSIZ1_DOPNG                         \ Do Ping


\
\ @brief OTG host channel 1 DMA address register
\ Address offset: 0x534
\ Reset value: 0x00000000
\

$00000000 constant OTG1_S_OTG_HCDMA1_DMAADDR                        \ DMA address


\
\ @brief OTG host channel 2 characteristics register
\ Address offset: 0x540
\ Reset value: 0x00000000
\

$000007ff constant OTG1_S_OTG_HCCHAR2_MPSIZ                         \ Maximum packet size
$00007800 constant OTG1_S_OTG_HCCHAR2_EPNUM                         \ Endpoint number
$00008000 constant OTG1_S_OTG_HCCHAR2_EPDIR                         \ Endpoint direction
$00020000 constant OTG1_S_OTG_HCCHAR2_LSDEV                         \ Low-speed device
$000c0000 constant OTG1_S_OTG_HCCHAR2_EPTYP                         \ Endpoint type
$00300000 constant OTG1_S_OTG_HCCHAR2_MCNT                          \ Multicount
$1fc00000 constant OTG1_S_OTG_HCCHAR2_DAD                           \ Device address
$20000000 constant OTG1_S_OTG_HCCHAR2_ODDFRM                        \ Odd frame
$40000000 constant OTG1_S_OTG_HCCHAR2_CHDIS                         \ Channel disable
$80000000 constant OTG1_S_OTG_HCCHAR2_CHENA                         \ Channel enable


\
\ @brief OTG host channel 2 split control register
\ Address offset: 0x544
\ Reset value: 0x00000000
\

$0000007f constant OTG1_S_OTG_HCSPLT2_PRTADDR                       \ Port address
$00003f80 constant OTG1_S_OTG_HCSPLT2_HUBADDR                       \ Hub address
$0000c000 constant OTG1_S_OTG_HCSPLT2_XACTPOS                       \ Transaction position
$00010000 constant OTG1_S_OTG_HCSPLT2_COMPLSPLT                     \ Do complete split
$80000000 constant OTG1_S_OTG_HCSPLT2_SPLITEN                       \ Split enable


\
\ @brief OTG host channel 2 interrupt register
\ Address offset: 0x548
\ Reset value: 0x00000000
\

$00000001 constant OTG1_S_OTG_HCINT2_XFRC                           \ Transfer completed.
$00000002 constant OTG1_S_OTG_HCINT2_CHH                            \ Channel halted.
$00000004 constant OTG1_S_OTG_HCINT2_AHBERR                         \ AHB error
$00000008 constant OTG1_S_OTG_HCINT2_STALL                          \ STALL response received interrupt.
$00000010 constant OTG1_S_OTG_HCINT2_NAK                            \ NAK response received interrupt.
$00000020 constant OTG1_S_OTG_HCINT2_ACK                            \ ACK response received/transmitted interrupt.
$00000040 constant OTG1_S_OTG_HCINT2_NYET                           \ Not yet ready response received interrupt.
$00000080 constant OTG1_S_OTG_HCINT2_TXERR                          \ Transaction error.
$00000100 constant OTG1_S_OTG_HCINT2_BBERR                          \ Babble error.
$00000200 constant OTG1_S_OTG_HCINT2_FRMOR                          \ Frame overrun.
$00000400 constant OTG1_S_OTG_HCINT2_DTERR                          \ Data toggle error.


\
\ @brief OTG host channel 2 interrupt mask register
\ Address offset: 0x54C
\ Reset value: 0x00000000
\

$00000001 constant OTG1_S_OTG_HCINTMSK2_XFRCM                       \ Transfer completed mask
$00000002 constant OTG1_S_OTG_HCINTMSK2_CHHM                        \ Channel halted mask
$00000004 constant OTG1_S_OTG_HCINTMSK2_AHBERRM                     \ AHB error.
$00000008 constant OTG1_S_OTG_HCINTMSK2_STALLM                      \ STALL response received interrupt mask.
$00000010 constant OTG1_S_OTG_HCINTMSK2_NAKM                        \ NAK response received interrupt mask.
$00000020 constant OTG1_S_OTG_HCINTMSK2_ACKM                        \ ACK response received/transmitted interrupt mask.
$00000040 constant OTG1_S_OTG_HCINTMSK2_NYET                        \ response received interrupt mask.
$00000080 constant OTG1_S_OTG_HCINTMSK2_TXERRM                      \ Transaction error mask.
$00000100 constant OTG1_S_OTG_HCINTMSK2_BBERRM                      \ Babble error mask.
$00000200 constant OTG1_S_OTG_HCINTMSK2_FRMORM                      \ Frame overrun mask.
$00000400 constant OTG1_S_OTG_HCINTMSK2_DTERRM                      \ Data toggle error mask.


\
\ @brief OTG host channel 2 transfer size register
\ Address offset: 0x550
\ Reset value: 0x00000000
\

$0007ffff constant OTG1_S_OTG_HCTSIZ2_XFRSIZ                        \ Transfer size
$1ff80000 constant OTG1_S_OTG_HCTSIZ2_PKTCNT                        \ Packet count
$60000000 constant OTG1_S_OTG_HCTSIZ2_DPID                          \ Data PID
$80000000 constant OTG1_S_OTG_HCTSIZ2_DOPNG                         \ Do Ping


\
\ @brief OTG host channel 2 DMA address register
\ Address offset: 0x554
\ Reset value: 0x00000000
\

$00000000 constant OTG1_S_OTG_HCDMA2_DMAADDR                        \ DMA address


\
\ @brief OTG host channel 3 characteristics register
\ Address offset: 0x560
\ Reset value: 0x00000000
\

$000007ff constant OTG1_S_OTG_HCCHAR3_MPSIZ                         \ Maximum packet size
$00007800 constant OTG1_S_OTG_HCCHAR3_EPNUM                         \ Endpoint number
$00008000 constant OTG1_S_OTG_HCCHAR3_EPDIR                         \ Endpoint direction
$00020000 constant OTG1_S_OTG_HCCHAR3_LSDEV                         \ Low-speed device
$000c0000 constant OTG1_S_OTG_HCCHAR3_EPTYP                         \ Endpoint type
$00300000 constant OTG1_S_OTG_HCCHAR3_MCNT                          \ Multicount
$1fc00000 constant OTG1_S_OTG_HCCHAR3_DAD                           \ Device address
$20000000 constant OTG1_S_OTG_HCCHAR3_ODDFRM                        \ Odd frame
$40000000 constant OTG1_S_OTG_HCCHAR3_CHDIS                         \ Channel disable
$80000000 constant OTG1_S_OTG_HCCHAR3_CHENA                         \ Channel enable


\
\ @brief OTG host channel 3 split control register
\ Address offset: 0x564
\ Reset value: 0x00000000
\

$0000007f constant OTG1_S_OTG_HCSPLT3_PRTADDR                       \ Port address
$00003f80 constant OTG1_S_OTG_HCSPLT3_HUBADDR                       \ Hub address
$0000c000 constant OTG1_S_OTG_HCSPLT3_XACTPOS                       \ Transaction position
$00010000 constant OTG1_S_OTG_HCSPLT3_COMPLSPLT                     \ Do complete split
$80000000 constant OTG1_S_OTG_HCSPLT3_SPLITEN                       \ Split enable


\
\ @brief OTG host channel 3 interrupt register
\ Address offset: 0x568
\ Reset value: 0x00000000
\

$00000001 constant OTG1_S_OTG_HCINT3_XFRC                           \ Transfer completed.
$00000002 constant OTG1_S_OTG_HCINT3_CHH                            \ Channel halted.
$00000004 constant OTG1_S_OTG_HCINT3_AHBERR                         \ AHB error
$00000008 constant OTG1_S_OTG_HCINT3_STALL                          \ STALL response received interrupt.
$00000010 constant OTG1_S_OTG_HCINT3_NAK                            \ NAK response received interrupt.
$00000020 constant OTG1_S_OTG_HCINT3_ACK                            \ ACK response received/transmitted interrupt.
$00000040 constant OTG1_S_OTG_HCINT3_NYET                           \ Not yet ready response received interrupt.
$00000080 constant OTG1_S_OTG_HCINT3_TXERR                          \ Transaction error.
$00000100 constant OTG1_S_OTG_HCINT3_BBERR                          \ Babble error.
$00000200 constant OTG1_S_OTG_HCINT3_FRMOR                          \ Frame overrun.
$00000400 constant OTG1_S_OTG_HCINT3_DTERR                          \ Data toggle error.


\
\ @brief OTG host channel 3 interrupt mask register
\ Address offset: 0x56C
\ Reset value: 0x00000000
\

$00000001 constant OTG1_S_OTG_HCINTMSK3_XFRCM                       \ Transfer completed mask
$00000002 constant OTG1_S_OTG_HCINTMSK3_CHHM                        \ Channel halted mask
$00000004 constant OTG1_S_OTG_HCINTMSK3_AHBERRM                     \ AHB error.
$00000008 constant OTG1_S_OTG_HCINTMSK3_STALLM                      \ STALL response received interrupt mask.
$00000010 constant OTG1_S_OTG_HCINTMSK3_NAKM                        \ NAK response received interrupt mask.
$00000020 constant OTG1_S_OTG_HCINTMSK3_ACKM                        \ ACK response received/transmitted interrupt mask.
$00000040 constant OTG1_S_OTG_HCINTMSK3_NYET                        \ response received interrupt mask.
$00000080 constant OTG1_S_OTG_HCINTMSK3_TXERRM                      \ Transaction error mask.
$00000100 constant OTG1_S_OTG_HCINTMSK3_BBERRM                      \ Babble error mask.
$00000200 constant OTG1_S_OTG_HCINTMSK3_FRMORM                      \ Frame overrun mask.
$00000400 constant OTG1_S_OTG_HCINTMSK3_DTERRM                      \ Data toggle error mask.


\
\ @brief OTG host channel 3 transfer size register
\ Address offset: 0x570
\ Reset value: 0x00000000
\

$0007ffff constant OTG1_S_OTG_HCTSIZ3_XFRSIZ                        \ Transfer size
$1ff80000 constant OTG1_S_OTG_HCTSIZ3_PKTCNT                        \ Packet count
$60000000 constant OTG1_S_OTG_HCTSIZ3_DPID                          \ Data PID
$80000000 constant OTG1_S_OTG_HCTSIZ3_DOPNG                         \ Do Ping


\
\ @brief OTG host channel 3 DMA address register
\ Address offset: 0x574
\ Reset value: 0x00000000
\

$00000000 constant OTG1_S_OTG_HCDMA3_DMAADDR                        \ DMA address


\
\ @brief OTG host channel 4 characteristics register
\ Address offset: 0x580
\ Reset value: 0x00000000
\

$000007ff constant OTG1_S_OTG_HCCHAR4_MPSIZ                         \ Maximum packet size
$00007800 constant OTG1_S_OTG_HCCHAR4_EPNUM                         \ Endpoint number
$00008000 constant OTG1_S_OTG_HCCHAR4_EPDIR                         \ Endpoint direction
$00020000 constant OTG1_S_OTG_HCCHAR4_LSDEV                         \ Low-speed device
$000c0000 constant OTG1_S_OTG_HCCHAR4_EPTYP                         \ Endpoint type
$00300000 constant OTG1_S_OTG_HCCHAR4_MCNT                          \ Multicount
$1fc00000 constant OTG1_S_OTG_HCCHAR4_DAD                           \ Device address
$20000000 constant OTG1_S_OTG_HCCHAR4_ODDFRM                        \ Odd frame
$40000000 constant OTG1_S_OTG_HCCHAR4_CHDIS                         \ Channel disable
$80000000 constant OTG1_S_OTG_HCCHAR4_CHENA                         \ Channel enable


\
\ @brief OTG host channel 4 split control register
\ Address offset: 0x584
\ Reset value: 0x00000000
\

$0000007f constant OTG1_S_OTG_HCSPLT4_PRTADDR                       \ Port address
$00003f80 constant OTG1_S_OTG_HCSPLT4_HUBADDR                       \ Hub address
$0000c000 constant OTG1_S_OTG_HCSPLT4_XACTPOS                       \ Transaction position
$00010000 constant OTG1_S_OTG_HCSPLT4_COMPLSPLT                     \ Do complete split
$80000000 constant OTG1_S_OTG_HCSPLT4_SPLITEN                       \ Split enable


\
\ @brief OTG host channel 4 interrupt register
\ Address offset: 0x588
\ Reset value: 0x00000000
\

$00000001 constant OTG1_S_OTG_HCINT4_XFRC                           \ Transfer completed.
$00000002 constant OTG1_S_OTG_HCINT4_CHH                            \ Channel halted.
$00000004 constant OTG1_S_OTG_HCINT4_AHBERR                         \ AHB error
$00000008 constant OTG1_S_OTG_HCINT4_STALL                          \ STALL response received interrupt.
$00000010 constant OTG1_S_OTG_HCINT4_NAK                            \ NAK response received interrupt.
$00000020 constant OTG1_S_OTG_HCINT4_ACK                            \ ACK response received/transmitted interrupt.
$00000040 constant OTG1_S_OTG_HCINT4_NYET                           \ Not yet ready response received interrupt.
$00000080 constant OTG1_S_OTG_HCINT4_TXERR                          \ Transaction error.
$00000100 constant OTG1_S_OTG_HCINT4_BBERR                          \ Babble error.
$00000200 constant OTG1_S_OTG_HCINT4_FRMOR                          \ Frame overrun.
$00000400 constant OTG1_S_OTG_HCINT4_DTERR                          \ Data toggle error.


\
\ @brief OTG host channel 4 interrupt mask register
\ Address offset: 0x58C
\ Reset value: 0x00000000
\

$00000001 constant OTG1_S_OTG_HCINTMSK4_XFRCM                       \ Transfer completed mask
$00000002 constant OTG1_S_OTG_HCINTMSK4_CHHM                        \ Channel halted mask
$00000004 constant OTG1_S_OTG_HCINTMSK4_AHBERRM                     \ AHB error.
$00000008 constant OTG1_S_OTG_HCINTMSK4_STALLM                      \ STALL response received interrupt mask.
$00000010 constant OTG1_S_OTG_HCINTMSK4_NAKM                        \ NAK response received interrupt mask.
$00000020 constant OTG1_S_OTG_HCINTMSK4_ACKM                        \ ACK response received/transmitted interrupt mask.
$00000040 constant OTG1_S_OTG_HCINTMSK4_NYET                        \ response received interrupt mask.
$00000080 constant OTG1_S_OTG_HCINTMSK4_TXERRM                      \ Transaction error mask.
$00000100 constant OTG1_S_OTG_HCINTMSK4_BBERRM                      \ Babble error mask.
$00000200 constant OTG1_S_OTG_HCINTMSK4_FRMORM                      \ Frame overrun mask.
$00000400 constant OTG1_S_OTG_HCINTMSK4_DTERRM                      \ Data toggle error mask.


\
\ @brief OTG host channel 4 transfer size register
\ Address offset: 0x590
\ Reset value: 0x00000000
\

$0007ffff constant OTG1_S_OTG_HCTSIZ4_XFRSIZ                        \ Transfer size
$1ff80000 constant OTG1_S_OTG_HCTSIZ4_PKTCNT                        \ Packet count
$60000000 constant OTG1_S_OTG_HCTSIZ4_DPID                          \ Data PID
$80000000 constant OTG1_S_OTG_HCTSIZ4_DOPNG                         \ Do Ping


\
\ @brief OTG host channel 4 DMA address register
\ Address offset: 0x594
\ Reset value: 0x00000000
\

$00000000 constant OTG1_S_OTG_HCDMA4_DMAADDR                        \ DMA address


\
\ @brief OTG host channel 5 characteristics register
\ Address offset: 0x5A0
\ Reset value: 0x00000000
\

$000007ff constant OTG1_S_OTG_HCCHAR5_MPSIZ                         \ Maximum packet size
$00007800 constant OTG1_S_OTG_HCCHAR5_EPNUM                         \ Endpoint number
$00008000 constant OTG1_S_OTG_HCCHAR5_EPDIR                         \ Endpoint direction
$00020000 constant OTG1_S_OTG_HCCHAR5_LSDEV                         \ Low-speed device
$000c0000 constant OTG1_S_OTG_HCCHAR5_EPTYP                         \ Endpoint type
$00300000 constant OTG1_S_OTG_HCCHAR5_MCNT                          \ Multicount
$1fc00000 constant OTG1_S_OTG_HCCHAR5_DAD                           \ Device address
$20000000 constant OTG1_S_OTG_HCCHAR5_ODDFRM                        \ Odd frame
$40000000 constant OTG1_S_OTG_HCCHAR5_CHDIS                         \ Channel disable
$80000000 constant OTG1_S_OTG_HCCHAR5_CHENA                         \ Channel enable


\
\ @brief OTG host channel 5 split control register
\ Address offset: 0x5A4
\ Reset value: 0x00000000
\

$0000007f constant OTG1_S_OTG_HCSPLT5_PRTADDR                       \ Port address
$00003f80 constant OTG1_S_OTG_HCSPLT5_HUBADDR                       \ Hub address
$0000c000 constant OTG1_S_OTG_HCSPLT5_XACTPOS                       \ Transaction position
$00010000 constant OTG1_S_OTG_HCSPLT5_COMPLSPLT                     \ Do complete split
$80000000 constant OTG1_S_OTG_HCSPLT5_SPLITEN                       \ Split enable


\
\ @brief OTG host channel 5 interrupt register
\ Address offset: 0x5A8
\ Reset value: 0x00000000
\

$00000001 constant OTG1_S_OTG_HCINT5_XFRC                           \ Transfer completed.
$00000002 constant OTG1_S_OTG_HCINT5_CHH                            \ Channel halted.
$00000004 constant OTG1_S_OTG_HCINT5_AHBERR                         \ AHB error
$00000008 constant OTG1_S_OTG_HCINT5_STALL                          \ STALL response received interrupt.
$00000010 constant OTG1_S_OTG_HCINT5_NAK                            \ NAK response received interrupt.
$00000020 constant OTG1_S_OTG_HCINT5_ACK                            \ ACK response received/transmitted interrupt.
$00000040 constant OTG1_S_OTG_HCINT5_NYET                           \ Not yet ready response received interrupt.
$00000080 constant OTG1_S_OTG_HCINT5_TXERR                          \ Transaction error.
$00000100 constant OTG1_S_OTG_HCINT5_BBERR                          \ Babble error.
$00000200 constant OTG1_S_OTG_HCINT5_FRMOR                          \ Frame overrun.
$00000400 constant OTG1_S_OTG_HCINT5_DTERR                          \ Data toggle error.


\
\ @brief OTG host channel 5 interrupt mask register
\ Address offset: 0x5AC
\ Reset value: 0x00000000
\

$00000001 constant OTG1_S_OTG_HCINTMSK5_XFRCM                       \ Transfer completed mask
$00000002 constant OTG1_S_OTG_HCINTMSK5_CHHM                        \ Channel halted mask
$00000004 constant OTG1_S_OTG_HCINTMSK5_AHBERRM                     \ AHB error.
$00000008 constant OTG1_S_OTG_HCINTMSK5_STALLM                      \ STALL response received interrupt mask.
$00000010 constant OTG1_S_OTG_HCINTMSK5_NAKM                        \ NAK response received interrupt mask.
$00000020 constant OTG1_S_OTG_HCINTMSK5_ACKM                        \ ACK response received/transmitted interrupt mask.
$00000040 constant OTG1_S_OTG_HCINTMSK5_NYET                        \ response received interrupt mask.
$00000080 constant OTG1_S_OTG_HCINTMSK5_TXERRM                      \ Transaction error mask.
$00000100 constant OTG1_S_OTG_HCINTMSK5_BBERRM                      \ Babble error mask.
$00000200 constant OTG1_S_OTG_HCINTMSK5_FRMORM                      \ Frame overrun mask.
$00000400 constant OTG1_S_OTG_HCINTMSK5_DTERRM                      \ Data toggle error mask.


\
\ @brief OTG host channel 5 transfer size register
\ Address offset: 0x5B0
\ Reset value: 0x00000000
\

$0007ffff constant OTG1_S_OTG_HCTSIZ5_XFRSIZ                        \ Transfer size
$1ff80000 constant OTG1_S_OTG_HCTSIZ5_PKTCNT                        \ Packet count
$60000000 constant OTG1_S_OTG_HCTSIZ5_DPID                          \ Data PID
$80000000 constant OTG1_S_OTG_HCTSIZ5_DOPNG                         \ Do Ping


\
\ @brief OTG host channel 5 DMA address register
\ Address offset: 0x5B4
\ Reset value: 0x00000000
\

$00000000 constant OTG1_S_OTG_HCDMA5_DMAADDR                        \ DMA address


\
\ @brief OTG host channel 6 characteristics register
\ Address offset: 0x5C0
\ Reset value: 0x00000000
\

$000007ff constant OTG1_S_OTG_HCCHAR6_MPSIZ                         \ Maximum packet size
$00007800 constant OTG1_S_OTG_HCCHAR6_EPNUM                         \ Endpoint number
$00008000 constant OTG1_S_OTG_HCCHAR6_EPDIR                         \ Endpoint direction
$00020000 constant OTG1_S_OTG_HCCHAR6_LSDEV                         \ Low-speed device
$000c0000 constant OTG1_S_OTG_HCCHAR6_EPTYP                         \ Endpoint type
$00300000 constant OTG1_S_OTG_HCCHAR6_MCNT                          \ Multicount
$1fc00000 constant OTG1_S_OTG_HCCHAR6_DAD                           \ Device address
$20000000 constant OTG1_S_OTG_HCCHAR6_ODDFRM                        \ Odd frame
$40000000 constant OTG1_S_OTG_HCCHAR6_CHDIS                         \ Channel disable
$80000000 constant OTG1_S_OTG_HCCHAR6_CHENA                         \ Channel enable


\
\ @brief OTG host channel 6 split control register
\ Address offset: 0x5C4
\ Reset value: 0x00000000
\

$0000007f constant OTG1_S_OTG_HCSPLT6_PRTADDR                       \ Port address
$00003f80 constant OTG1_S_OTG_HCSPLT6_HUBADDR                       \ Hub address
$0000c000 constant OTG1_S_OTG_HCSPLT6_XACTPOS                       \ Transaction position
$00010000 constant OTG1_S_OTG_HCSPLT6_COMPLSPLT                     \ Do complete split
$80000000 constant OTG1_S_OTG_HCSPLT6_SPLITEN                       \ Split enable


\
\ @brief OTG host channel 6 interrupt register
\ Address offset: 0x5C8
\ Reset value: 0x00000000
\

$00000001 constant OTG1_S_OTG_HCINT6_XFRC                           \ Transfer completed.
$00000002 constant OTG1_S_OTG_HCINT6_CHH                            \ Channel halted.
$00000004 constant OTG1_S_OTG_HCINT6_AHBERR                         \ AHB error
$00000008 constant OTG1_S_OTG_HCINT6_STALL                          \ STALL response received interrupt.
$00000010 constant OTG1_S_OTG_HCINT6_NAK                            \ NAK response received interrupt.
$00000020 constant OTG1_S_OTG_HCINT6_ACK                            \ ACK response received/transmitted interrupt.
$00000040 constant OTG1_S_OTG_HCINT6_NYET                           \ Not yet ready response received interrupt.
$00000080 constant OTG1_S_OTG_HCINT6_TXERR                          \ Transaction error.
$00000100 constant OTG1_S_OTG_HCINT6_BBERR                          \ Babble error.
$00000200 constant OTG1_S_OTG_HCINT6_FRMOR                          \ Frame overrun.
$00000400 constant OTG1_S_OTG_HCINT6_DTERR                          \ Data toggle error.


\
\ @brief OTG host channel 6 interrupt mask register
\ Address offset: 0x5CC
\ Reset value: 0x00000000
\

$00000001 constant OTG1_S_OTG_HCINTMSK6_XFRCM                       \ Transfer completed mask
$00000002 constant OTG1_S_OTG_HCINTMSK6_CHHM                        \ Channel halted mask
$00000004 constant OTG1_S_OTG_HCINTMSK6_AHBERRM                     \ AHB error.
$00000008 constant OTG1_S_OTG_HCINTMSK6_STALLM                      \ STALL response received interrupt mask.
$00000010 constant OTG1_S_OTG_HCINTMSK6_NAKM                        \ NAK response received interrupt mask.
$00000020 constant OTG1_S_OTG_HCINTMSK6_ACKM                        \ ACK response received/transmitted interrupt mask.
$00000040 constant OTG1_S_OTG_HCINTMSK6_NYET                        \ response received interrupt mask.
$00000080 constant OTG1_S_OTG_HCINTMSK6_TXERRM                      \ Transaction error mask.
$00000100 constant OTG1_S_OTG_HCINTMSK6_BBERRM                      \ Babble error mask.
$00000200 constant OTG1_S_OTG_HCINTMSK6_FRMORM                      \ Frame overrun mask.
$00000400 constant OTG1_S_OTG_HCINTMSK6_DTERRM                      \ Data toggle error mask.


\
\ @brief OTG host channel 6 transfer size register
\ Address offset: 0x5D0
\ Reset value: 0x00000000
\

$0007ffff constant OTG1_S_OTG_HCTSIZ6_XFRSIZ                        \ Transfer size
$1ff80000 constant OTG1_S_OTG_HCTSIZ6_PKTCNT                        \ Packet count
$60000000 constant OTG1_S_OTG_HCTSIZ6_DPID                          \ Data PID
$80000000 constant OTG1_S_OTG_HCTSIZ6_DOPNG                         \ Do Ping


\
\ @brief OTG host channel 6 DMA address register
\ Address offset: 0x5D4
\ Reset value: 0x00000000
\

$00000000 constant OTG1_S_OTG_HCDMA6_DMAADDR                        \ DMA address


\
\ @brief OTG host channel 7 characteristics register
\ Address offset: 0x5E0
\ Reset value: 0x00000000
\

$000007ff constant OTG1_S_OTG_HCCHAR7_MPSIZ                         \ Maximum packet size
$00007800 constant OTG1_S_OTG_HCCHAR7_EPNUM                         \ Endpoint number
$00008000 constant OTG1_S_OTG_HCCHAR7_EPDIR                         \ Endpoint direction
$00020000 constant OTG1_S_OTG_HCCHAR7_LSDEV                         \ Low-speed device
$000c0000 constant OTG1_S_OTG_HCCHAR7_EPTYP                         \ Endpoint type
$00300000 constant OTG1_S_OTG_HCCHAR7_MCNT                          \ Multicount
$1fc00000 constant OTG1_S_OTG_HCCHAR7_DAD                           \ Device address
$20000000 constant OTG1_S_OTG_HCCHAR7_ODDFRM                        \ Odd frame
$40000000 constant OTG1_S_OTG_HCCHAR7_CHDIS                         \ Channel disable
$80000000 constant OTG1_S_OTG_HCCHAR7_CHENA                         \ Channel enable


\
\ @brief OTG host channel 7 split control register
\ Address offset: 0x5E4
\ Reset value: 0x00000000
\

$0000007f constant OTG1_S_OTG_HCSPLT7_PRTADDR                       \ Port address
$00003f80 constant OTG1_S_OTG_HCSPLT7_HUBADDR                       \ Hub address
$0000c000 constant OTG1_S_OTG_HCSPLT7_XACTPOS                       \ Transaction position
$00010000 constant OTG1_S_OTG_HCSPLT7_COMPLSPLT                     \ Do complete split
$80000000 constant OTG1_S_OTG_HCSPLT7_SPLITEN                       \ Split enable


\
\ @brief OTG host channel 7 interrupt register
\ Address offset: 0x5E8
\ Reset value: 0x00000000
\

$00000001 constant OTG1_S_OTG_HCINT7_XFRC                           \ Transfer completed.
$00000002 constant OTG1_S_OTG_HCINT7_CHH                            \ Channel halted.
$00000004 constant OTG1_S_OTG_HCINT7_AHBERR                         \ AHB error
$00000008 constant OTG1_S_OTG_HCINT7_STALL                          \ STALL response received interrupt.
$00000010 constant OTG1_S_OTG_HCINT7_NAK                            \ NAK response received interrupt.
$00000020 constant OTG1_S_OTG_HCINT7_ACK                            \ ACK response received/transmitted interrupt.
$00000040 constant OTG1_S_OTG_HCINT7_NYET                           \ Not yet ready response received interrupt.
$00000080 constant OTG1_S_OTG_HCINT7_TXERR                          \ Transaction error.
$00000100 constant OTG1_S_OTG_HCINT7_BBERR                          \ Babble error.
$00000200 constant OTG1_S_OTG_HCINT7_FRMOR                          \ Frame overrun.
$00000400 constant OTG1_S_OTG_HCINT7_DTERR                          \ Data toggle error.


\
\ @brief OTG host channel 7 interrupt mask register
\ Address offset: 0x5EC
\ Reset value: 0x00000000
\

$00000001 constant OTG1_S_OTG_HCINTMSK7_XFRCM                       \ Transfer completed mask
$00000002 constant OTG1_S_OTG_HCINTMSK7_CHHM                        \ Channel halted mask
$00000004 constant OTG1_S_OTG_HCINTMSK7_AHBERRM                     \ AHB error.
$00000008 constant OTG1_S_OTG_HCINTMSK7_STALLM                      \ STALL response received interrupt mask.
$00000010 constant OTG1_S_OTG_HCINTMSK7_NAKM                        \ NAK response received interrupt mask.
$00000020 constant OTG1_S_OTG_HCINTMSK7_ACKM                        \ ACK response received/transmitted interrupt mask.
$00000040 constant OTG1_S_OTG_HCINTMSK7_NYET                        \ response received interrupt mask.
$00000080 constant OTG1_S_OTG_HCINTMSK7_TXERRM                      \ Transaction error mask.
$00000100 constant OTG1_S_OTG_HCINTMSK7_BBERRM                      \ Babble error mask.
$00000200 constant OTG1_S_OTG_HCINTMSK7_FRMORM                      \ Frame overrun mask.
$00000400 constant OTG1_S_OTG_HCINTMSK7_DTERRM                      \ Data toggle error mask.


\
\ @brief OTG host channel 7 transfer size register
\ Address offset: 0x5F0
\ Reset value: 0x00000000
\

$0007ffff constant OTG1_S_OTG_HCTSIZ7_XFRSIZ                        \ Transfer size
$1ff80000 constant OTG1_S_OTG_HCTSIZ7_PKTCNT                        \ Packet count
$60000000 constant OTG1_S_OTG_HCTSIZ7_DPID                          \ Data PID
$80000000 constant OTG1_S_OTG_HCTSIZ7_DOPNG                         \ Do Ping


\
\ @brief OTG host channel 7 DMA address register
\ Address offset: 0x5F4
\ Reset value: 0x00000000
\

$00000000 constant OTG1_S_OTG_HCDMA7_DMAADDR                        \ DMA address


\
\ @brief OTG host channel 8 characteristics register
\ Address offset: 0x600
\ Reset value: 0x00000000
\

$000007ff constant OTG1_S_OTG_HCCHAR8_MPSIZ                         \ Maximum packet size
$00007800 constant OTG1_S_OTG_HCCHAR8_EPNUM                         \ Endpoint number
$00008000 constant OTG1_S_OTG_HCCHAR8_EPDIR                         \ Endpoint direction
$00020000 constant OTG1_S_OTG_HCCHAR8_LSDEV                         \ Low-speed device
$000c0000 constant OTG1_S_OTG_HCCHAR8_EPTYP                         \ Endpoint type
$00300000 constant OTG1_S_OTG_HCCHAR8_MCNT                          \ Multicount
$1fc00000 constant OTG1_S_OTG_HCCHAR8_DAD                           \ Device address
$20000000 constant OTG1_S_OTG_HCCHAR8_ODDFRM                        \ Odd frame
$40000000 constant OTG1_S_OTG_HCCHAR8_CHDIS                         \ Channel disable
$80000000 constant OTG1_S_OTG_HCCHAR8_CHENA                         \ Channel enable


\
\ @brief OTG host channel 8 split control register
\ Address offset: 0x604
\ Reset value: 0x00000000
\

$0000007f constant OTG1_S_OTG_HCSPLT8_PRTADDR                       \ Port address
$00003f80 constant OTG1_S_OTG_HCSPLT8_HUBADDR                       \ Hub address
$0000c000 constant OTG1_S_OTG_HCSPLT8_XACTPOS                       \ Transaction position
$00010000 constant OTG1_S_OTG_HCSPLT8_COMPLSPLT                     \ Do complete split
$80000000 constant OTG1_S_OTG_HCSPLT8_SPLITEN                       \ Split enable


\
\ @brief OTG host channel 8 interrupt register
\ Address offset: 0x608
\ Reset value: 0x00000000
\

$00000001 constant OTG1_S_OTG_HCINT8_XFRC                           \ Transfer completed.
$00000002 constant OTG1_S_OTG_HCINT8_CHH                            \ Channel halted.
$00000004 constant OTG1_S_OTG_HCINT8_AHBERR                         \ AHB error
$00000008 constant OTG1_S_OTG_HCINT8_STALL                          \ STALL response received interrupt.
$00000010 constant OTG1_S_OTG_HCINT8_NAK                            \ NAK response received interrupt.
$00000020 constant OTG1_S_OTG_HCINT8_ACK                            \ ACK response received/transmitted interrupt.
$00000040 constant OTG1_S_OTG_HCINT8_NYET                           \ Not yet ready response received interrupt.
$00000080 constant OTG1_S_OTG_HCINT8_TXERR                          \ Transaction error.
$00000100 constant OTG1_S_OTG_HCINT8_BBERR                          \ Babble error.
$00000200 constant OTG1_S_OTG_HCINT8_FRMOR                          \ Frame overrun.
$00000400 constant OTG1_S_OTG_HCINT8_DTERR                          \ Data toggle error.


\
\ @brief OTG host channel 8 interrupt mask register
\ Address offset: 0x60C
\ Reset value: 0x00000000
\

$00000001 constant OTG1_S_OTG_HCINTMSK8_XFRCM                       \ Transfer completed mask
$00000002 constant OTG1_S_OTG_HCINTMSK8_CHHM                        \ Channel halted mask
$00000004 constant OTG1_S_OTG_HCINTMSK8_AHBERRM                     \ AHB error.
$00000008 constant OTG1_S_OTG_HCINTMSK8_STALLM                      \ STALL response received interrupt mask.
$00000010 constant OTG1_S_OTG_HCINTMSK8_NAKM                        \ NAK response received interrupt mask.
$00000020 constant OTG1_S_OTG_HCINTMSK8_ACKM                        \ ACK response received/transmitted interrupt mask.
$00000040 constant OTG1_S_OTG_HCINTMSK8_NYET                        \ response received interrupt mask.
$00000080 constant OTG1_S_OTG_HCINTMSK8_TXERRM                      \ Transaction error mask.
$00000100 constant OTG1_S_OTG_HCINTMSK8_BBERRM                      \ Babble error mask.
$00000200 constant OTG1_S_OTG_HCINTMSK8_FRMORM                      \ Frame overrun mask.
$00000400 constant OTG1_S_OTG_HCINTMSK8_DTERRM                      \ Data toggle error mask.


\
\ @brief OTG host channel 8 transfer size register
\ Address offset: 0x610
\ Reset value: 0x00000000
\

$0007ffff constant OTG1_S_OTG_HCTSIZ8_XFRSIZ                        \ Transfer size
$1ff80000 constant OTG1_S_OTG_HCTSIZ8_PKTCNT                        \ Packet count
$60000000 constant OTG1_S_OTG_HCTSIZ8_DPID                          \ Data PID
$80000000 constant OTG1_S_OTG_HCTSIZ8_DOPNG                         \ Do Ping


\
\ @brief OTG host channel 8 DMA address register
\ Address offset: 0x614
\ Reset value: 0x00000000
\

$00000000 constant OTG1_S_OTG_HCDMA8_DMAADDR                        \ DMA address


\
\ @brief OTG host channel 9 characteristics register
\ Address offset: 0x620
\ Reset value: 0x00000000
\

$000007ff constant OTG1_S_OTG_HCCHAR9_MPSIZ                         \ Maximum packet size
$00007800 constant OTG1_S_OTG_HCCHAR9_EPNUM                         \ Endpoint number
$00008000 constant OTG1_S_OTG_HCCHAR9_EPDIR                         \ Endpoint direction
$00020000 constant OTG1_S_OTG_HCCHAR9_LSDEV                         \ Low-speed device
$000c0000 constant OTG1_S_OTG_HCCHAR9_EPTYP                         \ Endpoint type
$00300000 constant OTG1_S_OTG_HCCHAR9_MCNT                          \ Multicount
$1fc00000 constant OTG1_S_OTG_HCCHAR9_DAD                           \ Device address
$20000000 constant OTG1_S_OTG_HCCHAR9_ODDFRM                        \ Odd frame
$40000000 constant OTG1_S_OTG_HCCHAR9_CHDIS                         \ Channel disable
$80000000 constant OTG1_S_OTG_HCCHAR9_CHENA                         \ Channel enable


\
\ @brief OTG host channel 9 split control register
\ Address offset: 0x624
\ Reset value: 0x00000000
\

$0000007f constant OTG1_S_OTG_HCSPLT9_PRTADDR                       \ Port address
$00003f80 constant OTG1_S_OTG_HCSPLT9_HUBADDR                       \ Hub address
$0000c000 constant OTG1_S_OTG_HCSPLT9_XACTPOS                       \ Transaction position
$00010000 constant OTG1_S_OTG_HCSPLT9_COMPLSPLT                     \ Do complete split
$80000000 constant OTG1_S_OTG_HCSPLT9_SPLITEN                       \ Split enable


\
\ @brief OTG host channel 9 interrupt register
\ Address offset: 0x628
\ Reset value: 0x00000000
\

$00000001 constant OTG1_S_OTG_HCINT9_XFRC                           \ Transfer completed.
$00000002 constant OTG1_S_OTG_HCINT9_CHH                            \ Channel halted.
$00000004 constant OTG1_S_OTG_HCINT9_AHBERR                         \ AHB error
$00000008 constant OTG1_S_OTG_HCINT9_STALL                          \ STALL response received interrupt.
$00000010 constant OTG1_S_OTG_HCINT9_NAK                            \ NAK response received interrupt.
$00000020 constant OTG1_S_OTG_HCINT9_ACK                            \ ACK response received/transmitted interrupt.
$00000040 constant OTG1_S_OTG_HCINT9_NYET                           \ Not yet ready response received interrupt.
$00000080 constant OTG1_S_OTG_HCINT9_TXERR                          \ Transaction error.
$00000100 constant OTG1_S_OTG_HCINT9_BBERR                          \ Babble error.
$00000200 constant OTG1_S_OTG_HCINT9_FRMOR                          \ Frame overrun.
$00000400 constant OTG1_S_OTG_HCINT9_DTERR                          \ Data toggle error.


\
\ @brief OTG host channel 9 interrupt mask register
\ Address offset: 0x62C
\ Reset value: 0x00000000
\

$00000001 constant OTG1_S_OTG_HCINTMSK9_XFRCM                       \ Transfer completed mask
$00000002 constant OTG1_S_OTG_HCINTMSK9_CHHM                        \ Channel halted mask
$00000004 constant OTG1_S_OTG_HCINTMSK9_AHBERRM                     \ AHB error.
$00000008 constant OTG1_S_OTG_HCINTMSK9_STALLM                      \ STALL response received interrupt mask.
$00000010 constant OTG1_S_OTG_HCINTMSK9_NAKM                        \ NAK response received interrupt mask.
$00000020 constant OTG1_S_OTG_HCINTMSK9_ACKM                        \ ACK response received/transmitted interrupt mask.
$00000040 constant OTG1_S_OTG_HCINTMSK9_NYET                        \ response received interrupt mask.
$00000080 constant OTG1_S_OTG_HCINTMSK9_TXERRM                      \ Transaction error mask.
$00000100 constant OTG1_S_OTG_HCINTMSK9_BBERRM                      \ Babble error mask.
$00000200 constant OTG1_S_OTG_HCINTMSK9_FRMORM                      \ Frame overrun mask.
$00000400 constant OTG1_S_OTG_HCINTMSK9_DTERRM                      \ Data toggle error mask.


\
\ @brief OTG host channel 9 transfer size register
\ Address offset: 0x630
\ Reset value: 0x00000000
\

$0007ffff constant OTG1_S_OTG_HCTSIZ9_XFRSIZ                        \ Transfer size
$1ff80000 constant OTG1_S_OTG_HCTSIZ9_PKTCNT                        \ Packet count
$60000000 constant OTG1_S_OTG_HCTSIZ9_DPID                          \ Data PID
$80000000 constant OTG1_S_OTG_HCTSIZ9_DOPNG                         \ Do Ping


\
\ @brief OTG host channel 9 DMA address register
\ Address offset: 0x634
\ Reset value: 0x00000000
\

$00000000 constant OTG1_S_OTG_HCDMA9_DMAADDR                        \ DMA address


\
\ @brief OTG host channel 10 characteristics register
\ Address offset: 0x640
\ Reset value: 0x00000000
\

$000007ff constant OTG1_S_OTG_HCCHAR10_MPSIZ                        \ Maximum packet size
$00007800 constant OTG1_S_OTG_HCCHAR10_EPNUM                        \ Endpoint number
$00008000 constant OTG1_S_OTG_HCCHAR10_EPDIR                        \ Endpoint direction
$00020000 constant OTG1_S_OTG_HCCHAR10_LSDEV                        \ Low-speed device
$000c0000 constant OTG1_S_OTG_HCCHAR10_EPTYP                        \ Endpoint type
$00300000 constant OTG1_S_OTG_HCCHAR10_MCNT                         \ Multicount
$1fc00000 constant OTG1_S_OTG_HCCHAR10_DAD                          \ Device address
$20000000 constant OTG1_S_OTG_HCCHAR10_ODDFRM                       \ Odd frame
$40000000 constant OTG1_S_OTG_HCCHAR10_CHDIS                        \ Channel disable
$80000000 constant OTG1_S_OTG_HCCHAR10_CHENA                        \ Channel enable


\
\ @brief OTG host channel 10 split control register
\ Address offset: 0x644
\ Reset value: 0x00000000
\

$0000007f constant OTG1_S_OTG_HCSPLT10_PRTADDR                      \ Port address
$00003f80 constant OTG1_S_OTG_HCSPLT10_HUBADDR                      \ Hub address
$0000c000 constant OTG1_S_OTG_HCSPLT10_XACTPOS                      \ Transaction position
$00010000 constant OTG1_S_OTG_HCSPLT10_COMPLSPLT                    \ Do complete split
$80000000 constant OTG1_S_OTG_HCSPLT10_SPLITEN                      \ Split enable


\
\ @brief OTG host channel 10 interrupt register
\ Address offset: 0x648
\ Reset value: 0x00000000
\

$00000001 constant OTG1_S_OTG_HCINT10_XFRC                          \ Transfer completed.
$00000002 constant OTG1_S_OTG_HCINT10_CHH                           \ Channel halted.
$00000004 constant OTG1_S_OTG_HCINT10_AHBERR                        \ AHB error
$00000008 constant OTG1_S_OTG_HCINT10_STALL                         \ STALL response received interrupt.
$00000010 constant OTG1_S_OTG_HCINT10_NAK                           \ NAK response received interrupt.
$00000020 constant OTG1_S_OTG_HCINT10_ACK                           \ ACK response received/transmitted interrupt.
$00000040 constant OTG1_S_OTG_HCINT10_NYET                          \ Not yet ready response received interrupt.
$00000080 constant OTG1_S_OTG_HCINT10_TXERR                         \ Transaction error.
$00000100 constant OTG1_S_OTG_HCINT10_BBERR                         \ Babble error.
$00000200 constant OTG1_S_OTG_HCINT10_FRMOR                         \ Frame overrun.
$00000400 constant OTG1_S_OTG_HCINT10_DTERR                         \ Data toggle error.


\
\ @brief OTG host channel 10 interrupt mask register
\ Address offset: 0x64C
\ Reset value: 0x00000000
\

$00000001 constant OTG1_S_OTG_HCINTMSK10_XFRCM                      \ Transfer completed mask
$00000002 constant OTG1_S_OTG_HCINTMSK10_CHHM                       \ Channel halted mask
$00000004 constant OTG1_S_OTG_HCINTMSK10_AHBERRM                    \ AHB error.
$00000008 constant OTG1_S_OTG_HCINTMSK10_STALLM                     \ STALL response received interrupt mask.
$00000010 constant OTG1_S_OTG_HCINTMSK10_NAKM                       \ NAK response received interrupt mask.
$00000020 constant OTG1_S_OTG_HCINTMSK10_ACKM                       \ ACK response received/transmitted interrupt mask.
$00000040 constant OTG1_S_OTG_HCINTMSK10_NYET                       \ response received interrupt mask.
$00000080 constant OTG1_S_OTG_HCINTMSK10_TXERRM                     \ Transaction error mask.
$00000100 constant OTG1_S_OTG_HCINTMSK10_BBERRM                     \ Babble error mask.
$00000200 constant OTG1_S_OTG_HCINTMSK10_FRMORM                     \ Frame overrun mask.
$00000400 constant OTG1_S_OTG_HCINTMSK10_DTERRM                     \ Data toggle error mask.


\
\ @brief OTG host channel 10 transfer size register
\ Address offset: 0x650
\ Reset value: 0x00000000
\

$0007ffff constant OTG1_S_OTG_HCTSIZ10_XFRSIZ                       \ Transfer size
$1ff80000 constant OTG1_S_OTG_HCTSIZ10_PKTCNT                       \ Packet count
$60000000 constant OTG1_S_OTG_HCTSIZ10_DPID                         \ Data PID
$80000000 constant OTG1_S_OTG_HCTSIZ10_DOPNG                        \ Do Ping


\
\ @brief OTG host channel 10 DMA address register
\ Address offset: 0x654
\ Reset value: 0x00000000
\

$00000000 constant OTG1_S_OTG_HCDMA10_DMAADDR                       \ DMA address


\
\ @brief OTG host channel 11 characteristics register
\ Address offset: 0x660
\ Reset value: 0x00000000
\

$000007ff constant OTG1_S_OTG_HCCHAR11_MPSIZ                        \ Maximum packet size
$00007800 constant OTG1_S_OTG_HCCHAR11_EPNUM                        \ Endpoint number
$00008000 constant OTG1_S_OTG_HCCHAR11_EPDIR                        \ Endpoint direction
$00020000 constant OTG1_S_OTG_HCCHAR11_LSDEV                        \ Low-speed device
$000c0000 constant OTG1_S_OTG_HCCHAR11_EPTYP                        \ Endpoint type
$00300000 constant OTG1_S_OTG_HCCHAR11_MCNT                         \ Multicount
$1fc00000 constant OTG1_S_OTG_HCCHAR11_DAD                          \ Device address
$20000000 constant OTG1_S_OTG_HCCHAR11_ODDFRM                       \ Odd frame
$40000000 constant OTG1_S_OTG_HCCHAR11_CHDIS                        \ Channel disable
$80000000 constant OTG1_S_OTG_HCCHAR11_CHENA                        \ Channel enable


\
\ @brief OTG host channel 11 split control register
\ Address offset: 0x664
\ Reset value: 0x00000000
\

$0000007f constant OTG1_S_OTG_HCSPLT11_PRTADDR                      \ Port address
$00003f80 constant OTG1_S_OTG_HCSPLT11_HUBADDR                      \ Hub address
$0000c000 constant OTG1_S_OTG_HCSPLT11_XACTPOS                      \ Transaction position
$00010000 constant OTG1_S_OTG_HCSPLT11_COMPLSPLT                    \ Do complete split
$80000000 constant OTG1_S_OTG_HCSPLT11_SPLITEN                      \ Split enable


\
\ @brief OTG host channel 11 interrupt register
\ Address offset: 0x668
\ Reset value: 0x00000000
\

$00000001 constant OTG1_S_OTG_HCINT11_XFRC                          \ Transfer completed.
$00000002 constant OTG1_S_OTG_HCINT11_CHH                           \ Channel halted.
$00000004 constant OTG1_S_OTG_HCINT11_AHBERR                        \ AHB error
$00000008 constant OTG1_S_OTG_HCINT11_STALL                         \ STALL response received interrupt.
$00000010 constant OTG1_S_OTG_HCINT11_NAK                           \ NAK response received interrupt.
$00000020 constant OTG1_S_OTG_HCINT11_ACK                           \ ACK response received/transmitted interrupt.
$00000040 constant OTG1_S_OTG_HCINT11_NYET                          \ Not yet ready response received interrupt.
$00000080 constant OTG1_S_OTG_HCINT11_TXERR                         \ Transaction error.
$00000100 constant OTG1_S_OTG_HCINT11_BBERR                         \ Babble error.
$00000200 constant OTG1_S_OTG_HCINT11_FRMOR                         \ Frame overrun.
$00000400 constant OTG1_S_OTG_HCINT11_DTERR                         \ Data toggle error.


\
\ @brief OTG host channel 11 interrupt mask register
\ Address offset: 0x66C
\ Reset value: 0x00000000
\

$00000001 constant OTG1_S_OTG_HCINTMSK11_XFRCM                      \ Transfer completed mask
$00000002 constant OTG1_S_OTG_HCINTMSK11_CHHM                       \ Channel halted mask
$00000004 constant OTG1_S_OTG_HCINTMSK11_AHBERRM                    \ AHB error.
$00000008 constant OTG1_S_OTG_HCINTMSK11_STALLM                     \ STALL response received interrupt mask.
$00000010 constant OTG1_S_OTG_HCINTMSK11_NAKM                       \ NAK response received interrupt mask.
$00000020 constant OTG1_S_OTG_HCINTMSK11_ACKM                       \ ACK response received/transmitted interrupt mask.
$00000040 constant OTG1_S_OTG_HCINTMSK11_NYET                       \ response received interrupt mask.
$00000080 constant OTG1_S_OTG_HCINTMSK11_TXERRM                     \ Transaction error mask.
$00000100 constant OTG1_S_OTG_HCINTMSK11_BBERRM                     \ Babble error mask.
$00000200 constant OTG1_S_OTG_HCINTMSK11_FRMORM                     \ Frame overrun mask.
$00000400 constant OTG1_S_OTG_HCINTMSK11_DTERRM                     \ Data toggle error mask.


\
\ @brief OTG host channel 11 transfer size register
\ Address offset: 0x670
\ Reset value: 0x00000000
\

$0007ffff constant OTG1_S_OTG_HCTSIZ11_XFRSIZ                       \ Transfer size
$1ff80000 constant OTG1_S_OTG_HCTSIZ11_PKTCNT                       \ Packet count
$60000000 constant OTG1_S_OTG_HCTSIZ11_DPID                         \ Data PID
$80000000 constant OTG1_S_OTG_HCTSIZ11_DOPNG                        \ Do Ping


\
\ @brief OTG host channel 11 DMA address register
\ Address offset: 0x674
\ Reset value: 0x00000000
\

$00000000 constant OTG1_S_OTG_HCDMA11_DMAADDR                       \ DMA address


\
\ @brief OTG host channel 12 characteristics register
\ Address offset: 0x680
\ Reset value: 0x00000000
\

$000007ff constant OTG1_S_OTG_HCCHAR12_MPSIZ                        \ Maximum packet size
$00007800 constant OTG1_S_OTG_HCCHAR12_EPNUM                        \ Endpoint number
$00008000 constant OTG1_S_OTG_HCCHAR12_EPDIR                        \ Endpoint direction
$00020000 constant OTG1_S_OTG_HCCHAR12_LSDEV                        \ Low-speed device
$000c0000 constant OTG1_S_OTG_HCCHAR12_EPTYP                        \ Endpoint type
$00300000 constant OTG1_S_OTG_HCCHAR12_MCNT                         \ Multicount
$1fc00000 constant OTG1_S_OTG_HCCHAR12_DAD                          \ Device address
$20000000 constant OTG1_S_OTG_HCCHAR12_ODDFRM                       \ Odd frame
$40000000 constant OTG1_S_OTG_HCCHAR12_CHDIS                        \ Channel disable
$80000000 constant OTG1_S_OTG_HCCHAR12_CHENA                        \ Channel enable


\
\ @brief OTG host channel 12 split control register
\ Address offset: 0x684
\ Reset value: 0x00000000
\

$0000007f constant OTG1_S_OTG_HCSPLT12_PRTADDR                      \ Port address
$00003f80 constant OTG1_S_OTG_HCSPLT12_HUBADDR                      \ Hub address
$0000c000 constant OTG1_S_OTG_HCSPLT12_XACTPOS                      \ Transaction position
$00010000 constant OTG1_S_OTG_HCSPLT12_COMPLSPLT                    \ Do complete split
$80000000 constant OTG1_S_OTG_HCSPLT12_SPLITEN                      \ Split enable


\
\ @brief OTG host channel 12 interrupt register
\ Address offset: 0x688
\ Reset value: 0x00000000
\

$00000001 constant OTG1_S_OTG_HCINT12_XFRC                          \ Transfer completed.
$00000002 constant OTG1_S_OTG_HCINT12_CHH                           \ Channel halted.
$00000004 constant OTG1_S_OTG_HCINT12_AHBERR                        \ AHB error
$00000008 constant OTG1_S_OTG_HCINT12_STALL                         \ STALL response received interrupt.
$00000010 constant OTG1_S_OTG_HCINT12_NAK                           \ NAK response received interrupt.
$00000020 constant OTG1_S_OTG_HCINT12_ACK                           \ ACK response received/transmitted interrupt.
$00000040 constant OTG1_S_OTG_HCINT12_NYET                          \ Not yet ready response received interrupt.
$00000080 constant OTG1_S_OTG_HCINT12_TXERR                         \ Transaction error.
$00000100 constant OTG1_S_OTG_HCINT12_BBERR                         \ Babble error.
$00000200 constant OTG1_S_OTG_HCINT12_FRMOR                         \ Frame overrun.
$00000400 constant OTG1_S_OTG_HCINT12_DTERR                         \ Data toggle error.


\
\ @brief OTG host channel 12 interrupt mask register
\ Address offset: 0x68C
\ Reset value: 0x00000000
\

$00000001 constant OTG1_S_OTG_HCINTMSK12_XFRCM                      \ Transfer completed mask
$00000002 constant OTG1_S_OTG_HCINTMSK12_CHHM                       \ Channel halted mask
$00000004 constant OTG1_S_OTG_HCINTMSK12_AHBERRM                    \ AHB error.
$00000008 constant OTG1_S_OTG_HCINTMSK12_STALLM                     \ STALL response received interrupt mask.
$00000010 constant OTG1_S_OTG_HCINTMSK12_NAKM                       \ NAK response received interrupt mask.
$00000020 constant OTG1_S_OTG_HCINTMSK12_ACKM                       \ ACK response received/transmitted interrupt mask.
$00000040 constant OTG1_S_OTG_HCINTMSK12_NYET                       \ response received interrupt mask.
$00000080 constant OTG1_S_OTG_HCINTMSK12_TXERRM                     \ Transaction error mask.
$00000100 constant OTG1_S_OTG_HCINTMSK12_BBERRM                     \ Babble error mask.
$00000200 constant OTG1_S_OTG_HCINTMSK12_FRMORM                     \ Frame overrun mask.
$00000400 constant OTG1_S_OTG_HCINTMSK12_DTERRM                     \ Data toggle error mask.


\
\ @brief OTG host channel 12 transfer size register
\ Address offset: 0x690
\ Reset value: 0x00000000
\

$0007ffff constant OTG1_S_OTG_HCTSIZ12_XFRSIZ                       \ Transfer size
$1ff80000 constant OTG1_S_OTG_HCTSIZ12_PKTCNT                       \ Packet count
$60000000 constant OTG1_S_OTG_HCTSIZ12_DPID                         \ Data PID
$80000000 constant OTG1_S_OTG_HCTSIZ12_DOPNG                        \ Do Ping


\
\ @brief OTG host channel 12 DMA address register
\ Address offset: 0x694
\ Reset value: 0x00000000
\

$00000000 constant OTG1_S_OTG_HCDMA12_DMAADDR                       \ DMA address


\
\ @brief OTG host channel 13 characteristics register
\ Address offset: 0x6A0
\ Reset value: 0x00000000
\

$000007ff constant OTG1_S_OTG_HCCHAR13_MPSIZ                        \ Maximum packet size
$00007800 constant OTG1_S_OTG_HCCHAR13_EPNUM                        \ Endpoint number
$00008000 constant OTG1_S_OTG_HCCHAR13_EPDIR                        \ Endpoint direction
$00020000 constant OTG1_S_OTG_HCCHAR13_LSDEV                        \ Low-speed device
$000c0000 constant OTG1_S_OTG_HCCHAR13_EPTYP                        \ Endpoint type
$00300000 constant OTG1_S_OTG_HCCHAR13_MCNT                         \ Multicount
$1fc00000 constant OTG1_S_OTG_HCCHAR13_DAD                          \ Device address
$20000000 constant OTG1_S_OTG_HCCHAR13_ODDFRM                       \ Odd frame
$40000000 constant OTG1_S_OTG_HCCHAR13_CHDIS                        \ Channel disable
$80000000 constant OTG1_S_OTG_HCCHAR13_CHENA                        \ Channel enable


\
\ @brief OTG host channel 13 split control register
\ Address offset: 0x6A4
\ Reset value: 0x00000000
\

$0000007f constant OTG1_S_OTG_HCSPLT13_PRTADDR                      \ Port address
$00003f80 constant OTG1_S_OTG_HCSPLT13_HUBADDR                      \ Hub address
$0000c000 constant OTG1_S_OTG_HCSPLT13_XACTPOS                      \ Transaction position
$00010000 constant OTG1_S_OTG_HCSPLT13_COMPLSPLT                    \ Do complete split
$80000000 constant OTG1_S_OTG_HCSPLT13_SPLITEN                      \ Split enable


\
\ @brief OTG host channel 13 interrupt register
\ Address offset: 0x6A8
\ Reset value: 0x00000000
\

$00000001 constant OTG1_S_OTG_HCINT13_XFRC                          \ Transfer completed.
$00000002 constant OTG1_S_OTG_HCINT13_CHH                           \ Channel halted.
$00000004 constant OTG1_S_OTG_HCINT13_AHBERR                        \ AHB error
$00000008 constant OTG1_S_OTG_HCINT13_STALL                         \ STALL response received interrupt.
$00000010 constant OTG1_S_OTG_HCINT13_NAK                           \ NAK response received interrupt.
$00000020 constant OTG1_S_OTG_HCINT13_ACK                           \ ACK response received/transmitted interrupt.
$00000040 constant OTG1_S_OTG_HCINT13_NYET                          \ Not yet ready response received interrupt.
$00000080 constant OTG1_S_OTG_HCINT13_TXERR                         \ Transaction error.
$00000100 constant OTG1_S_OTG_HCINT13_BBERR                         \ Babble error.
$00000200 constant OTG1_S_OTG_HCINT13_FRMOR                         \ Frame overrun.
$00000400 constant OTG1_S_OTG_HCINT13_DTERR                         \ Data toggle error.


\
\ @brief OTG host channel 13 interrupt mask register
\ Address offset: 0x6AC
\ Reset value: 0x00000000
\

$00000001 constant OTG1_S_OTG_HCINTMSK13_XFRCM                      \ Transfer completed mask
$00000002 constant OTG1_S_OTG_HCINTMSK13_CHHM                       \ Channel halted mask
$00000004 constant OTG1_S_OTG_HCINTMSK13_AHBERRM                    \ AHB error.
$00000008 constant OTG1_S_OTG_HCINTMSK13_STALLM                     \ STALL response received interrupt mask.
$00000010 constant OTG1_S_OTG_HCINTMSK13_NAKM                       \ NAK response received interrupt mask.
$00000020 constant OTG1_S_OTG_HCINTMSK13_ACKM                       \ ACK response received/transmitted interrupt mask.
$00000040 constant OTG1_S_OTG_HCINTMSK13_NYET                       \ response received interrupt mask.
$00000080 constant OTG1_S_OTG_HCINTMSK13_TXERRM                     \ Transaction error mask.
$00000100 constant OTG1_S_OTG_HCINTMSK13_BBERRM                     \ Babble error mask.
$00000200 constant OTG1_S_OTG_HCINTMSK13_FRMORM                     \ Frame overrun mask.
$00000400 constant OTG1_S_OTG_HCINTMSK13_DTERRM                     \ Data toggle error mask.


\
\ @brief OTG host channel 13 transfer size register
\ Address offset: 0x6B0
\ Reset value: 0x00000000
\

$0007ffff constant OTG1_S_OTG_HCTSIZ13_XFRSIZ                       \ Transfer size
$1ff80000 constant OTG1_S_OTG_HCTSIZ13_PKTCNT                       \ Packet count
$60000000 constant OTG1_S_OTG_HCTSIZ13_DPID                         \ Data PID
$80000000 constant OTG1_S_OTG_HCTSIZ13_DOPNG                        \ Do Ping


\
\ @brief OTG host channel 13 DMA address register
\ Address offset: 0x6B4
\ Reset value: 0x00000000
\

$00000000 constant OTG1_S_OTG_HCDMA13_DMAADDR                       \ DMA address


\
\ @brief OTG host channel 14 characteristics register
\ Address offset: 0x6C0
\ Reset value: 0x00000000
\

$000007ff constant OTG1_S_OTG_HCCHAR14_MPSIZ                        \ Maximum packet size
$00007800 constant OTG1_S_OTG_HCCHAR14_EPNUM                        \ Endpoint number
$00008000 constant OTG1_S_OTG_HCCHAR14_EPDIR                        \ Endpoint direction
$00020000 constant OTG1_S_OTG_HCCHAR14_LSDEV                        \ Low-speed device
$000c0000 constant OTG1_S_OTG_HCCHAR14_EPTYP                        \ Endpoint type
$00300000 constant OTG1_S_OTG_HCCHAR14_MCNT                         \ Multicount
$1fc00000 constant OTG1_S_OTG_HCCHAR14_DAD                          \ Device address
$20000000 constant OTG1_S_OTG_HCCHAR14_ODDFRM                       \ Odd frame
$40000000 constant OTG1_S_OTG_HCCHAR14_CHDIS                        \ Channel disable
$80000000 constant OTG1_S_OTG_HCCHAR14_CHENA                        \ Channel enable


\
\ @brief OTG host channel 14 split control register
\ Address offset: 0x6C4
\ Reset value: 0x00000000
\

$0000007f constant OTG1_S_OTG_HCSPLT14_PRTADDR                      \ Port address
$00003f80 constant OTG1_S_OTG_HCSPLT14_HUBADDR                      \ Hub address
$0000c000 constant OTG1_S_OTG_HCSPLT14_XACTPOS                      \ Transaction position
$00010000 constant OTG1_S_OTG_HCSPLT14_COMPLSPLT                    \ Do complete split
$80000000 constant OTG1_S_OTG_HCSPLT14_SPLITEN                      \ Split enable


\
\ @brief OTG host channel 14 interrupt register
\ Address offset: 0x6C8
\ Reset value: 0x00000000
\

$00000001 constant OTG1_S_OTG_HCINT14_XFRC                          \ Transfer completed.
$00000002 constant OTG1_S_OTG_HCINT14_CHH                           \ Channel halted.
$00000004 constant OTG1_S_OTG_HCINT14_AHBERR                        \ AHB error
$00000008 constant OTG1_S_OTG_HCINT14_STALL                         \ STALL response received interrupt.
$00000010 constant OTG1_S_OTG_HCINT14_NAK                           \ NAK response received interrupt.
$00000020 constant OTG1_S_OTG_HCINT14_ACK                           \ ACK response received/transmitted interrupt.
$00000040 constant OTG1_S_OTG_HCINT14_NYET                          \ Not yet ready response received interrupt.
$00000080 constant OTG1_S_OTG_HCINT14_TXERR                         \ Transaction error.
$00000100 constant OTG1_S_OTG_HCINT14_BBERR                         \ Babble error.
$00000200 constant OTG1_S_OTG_HCINT14_FRMOR                         \ Frame overrun.
$00000400 constant OTG1_S_OTG_HCINT14_DTERR                         \ Data toggle error.


\
\ @brief OTG host channel 14 interrupt mask register
\ Address offset: 0x6CC
\ Reset value: 0x00000000
\

$00000001 constant OTG1_S_OTG_HCINTMSK14_XFRCM                      \ Transfer completed mask
$00000002 constant OTG1_S_OTG_HCINTMSK14_CHHM                       \ Channel halted mask
$00000004 constant OTG1_S_OTG_HCINTMSK14_AHBERRM                    \ AHB error.
$00000008 constant OTG1_S_OTG_HCINTMSK14_STALLM                     \ STALL response received interrupt mask.
$00000010 constant OTG1_S_OTG_HCINTMSK14_NAKM                       \ NAK response received interrupt mask.
$00000020 constant OTG1_S_OTG_HCINTMSK14_ACKM                       \ ACK response received/transmitted interrupt mask.
$00000040 constant OTG1_S_OTG_HCINTMSK14_NYET                       \ response received interrupt mask.
$00000080 constant OTG1_S_OTG_HCINTMSK14_TXERRM                     \ Transaction error mask.
$00000100 constant OTG1_S_OTG_HCINTMSK14_BBERRM                     \ Babble error mask.
$00000200 constant OTG1_S_OTG_HCINTMSK14_FRMORM                     \ Frame overrun mask.
$00000400 constant OTG1_S_OTG_HCINTMSK14_DTERRM                     \ Data toggle error mask.


\
\ @brief OTG host channel 14 transfer size register
\ Address offset: 0x6D0
\ Reset value: 0x00000000
\

$0007ffff constant OTG1_S_OTG_HCTSIZ14_XFRSIZ                       \ Transfer size
$1ff80000 constant OTG1_S_OTG_HCTSIZ14_PKTCNT                       \ Packet count
$60000000 constant OTG1_S_OTG_HCTSIZ14_DPID                         \ Data PID
$80000000 constant OTG1_S_OTG_HCTSIZ14_DOPNG                        \ Do Ping


\
\ @brief OTG host channel 14 DMA address register
\ Address offset: 0x6D4
\ Reset value: 0x00000000
\

$00000000 constant OTG1_S_OTG_HCDMA14_DMAADDR                       \ DMA address


\
\ @brief OTG host channel 15 characteristics register
\ Address offset: 0x6E0
\ Reset value: 0x00000000
\

$000007ff constant OTG1_S_OTG_HCCHAR15_MPSIZ                        \ Maximum packet size
$00007800 constant OTG1_S_OTG_HCCHAR15_EPNUM                        \ Endpoint number
$00008000 constant OTG1_S_OTG_HCCHAR15_EPDIR                        \ Endpoint direction
$00020000 constant OTG1_S_OTG_HCCHAR15_LSDEV                        \ Low-speed device
$000c0000 constant OTG1_S_OTG_HCCHAR15_EPTYP                        \ Endpoint type
$00300000 constant OTG1_S_OTG_HCCHAR15_MCNT                         \ Multicount
$1fc00000 constant OTG1_S_OTG_HCCHAR15_DAD                          \ Device address
$20000000 constant OTG1_S_OTG_HCCHAR15_ODDFRM                       \ Odd frame
$40000000 constant OTG1_S_OTG_HCCHAR15_CHDIS                        \ Channel disable
$80000000 constant OTG1_S_OTG_HCCHAR15_CHENA                        \ Channel enable


\
\ @brief OTG host channel 15 split control register
\ Address offset: 0x6E4
\ Reset value: 0x00000000
\

$0000007f constant OTG1_S_OTG_HCSPLT15_PRTADDR                      \ Port address
$00003f80 constant OTG1_S_OTG_HCSPLT15_HUBADDR                      \ Hub address
$0000c000 constant OTG1_S_OTG_HCSPLT15_XACTPOS                      \ Transaction position
$00010000 constant OTG1_S_OTG_HCSPLT15_COMPLSPLT                    \ Do complete split
$80000000 constant OTG1_S_OTG_HCSPLT15_SPLITEN                      \ Split enable


\
\ @brief OTG host channel 15 interrupt register
\ Address offset: 0x6E8
\ Reset value: 0x00000000
\

$00000001 constant OTG1_S_OTG_HCINT15_XFRC                          \ Transfer completed.
$00000002 constant OTG1_S_OTG_HCINT15_CHH                           \ Channel halted.
$00000004 constant OTG1_S_OTG_HCINT15_AHBERR                        \ AHB error
$00000008 constant OTG1_S_OTG_HCINT15_STALL                         \ STALL response received interrupt.
$00000010 constant OTG1_S_OTG_HCINT15_NAK                           \ NAK response received interrupt.
$00000020 constant OTG1_S_OTG_HCINT15_ACK                           \ ACK response received/transmitted interrupt.
$00000040 constant OTG1_S_OTG_HCINT15_NYET                          \ Not yet ready response received interrupt.
$00000080 constant OTG1_S_OTG_HCINT15_TXERR                         \ Transaction error.
$00000100 constant OTG1_S_OTG_HCINT15_BBERR                         \ Babble error.
$00000200 constant OTG1_S_OTG_HCINT15_FRMOR                         \ Frame overrun.
$00000400 constant OTG1_S_OTG_HCINT15_DTERR                         \ Data toggle error.


\
\ @brief OTG host channel 15 interrupt mask register
\ Address offset: 0x6EC
\ Reset value: 0x00000000
\

$00000001 constant OTG1_S_OTG_HCINTMSK15_XFRCM                      \ Transfer completed mask
$00000002 constant OTG1_S_OTG_HCINTMSK15_CHHM                       \ Channel halted mask
$00000004 constant OTG1_S_OTG_HCINTMSK15_AHBERRM                    \ AHB error.
$00000008 constant OTG1_S_OTG_HCINTMSK15_STALLM                     \ STALL response received interrupt mask.
$00000010 constant OTG1_S_OTG_HCINTMSK15_NAKM                       \ NAK response received interrupt mask.
$00000020 constant OTG1_S_OTG_HCINTMSK15_ACKM                       \ ACK response received/transmitted interrupt mask.
$00000040 constant OTG1_S_OTG_HCINTMSK15_NYET                       \ response received interrupt mask.
$00000080 constant OTG1_S_OTG_HCINTMSK15_TXERRM                     \ Transaction error mask.
$00000100 constant OTG1_S_OTG_HCINTMSK15_BBERRM                     \ Babble error mask.
$00000200 constant OTG1_S_OTG_HCINTMSK15_FRMORM                     \ Frame overrun mask.
$00000400 constant OTG1_S_OTG_HCINTMSK15_DTERRM                     \ Data toggle error mask.


\
\ @brief OTG host channel 15 transfer size register
\ Address offset: 0x6F0
\ Reset value: 0x00000000
\

$0007ffff constant OTG1_S_OTG_HCTSIZ15_XFRSIZ                       \ Transfer size
$1ff80000 constant OTG1_S_OTG_HCTSIZ15_PKTCNT                       \ Packet count
$60000000 constant OTG1_S_OTG_HCTSIZ15_DPID                         \ Data PID
$80000000 constant OTG1_S_OTG_HCTSIZ15_DOPNG                        \ Do Ping


\
\ @brief OTG host channel 15 DMA address register
\ Address offset: 0x6F4
\ Reset value: 0x00000000
\

$00000000 constant OTG1_S_OTG_HCDMA15_DMAADDR                       \ DMA address


\
\ @brief OTG device configuration register
\ Address offset: 0x800
\ Reset value: 0x02200000
\

$00000003 constant OTG1_S_OTG_DCFG_DSPD                             \ Device speed
$00000004 constant OTG1_S_OTG_DCFG_NZLSOHSK                         \ Non-zero-length status OUT handshake
$000007f0 constant OTG1_S_OTG_DCFG_DAD                              \ Device address
$00001800 constant OTG1_S_OTG_DCFG_PFIVL                            \ Periodic frame interval
$00008000 constant OTG1_S_OTG_DCFG_ERRATIM                          \ Erratic error interrupt mask
$03000000 constant OTG1_S_OTG_DCFG_PERSCHIVL                        \ Periodic schedule interval


\
\ @brief OTG device control register
\ Address offset: 0x804
\ Reset value: 0x00000002
\

$00000001 constant OTG1_S_OTG_DCTL_RWUSIG                           \ Remote wake-up signaling
$00000002 constant OTG1_S_OTG_DCTL_SDIS                             \ Soft disconnect
$00000004 constant OTG1_S_OTG_DCTL_GINSTS                           \ Global IN NAK status
$00000008 constant OTG1_S_OTG_DCTL_GONSTS                           \ Global OUT NAK status
$00000070 constant OTG1_S_OTG_DCTL_TCTL                             \ Test control
$00000080 constant OTG1_S_OTG_DCTL_SGINAK                           \ Set global IN NAK
$00000100 constant OTG1_S_OTG_DCTL_CGINAK                           \ Clear global IN NAK
$00000200 constant OTG1_S_OTG_DCTL_SGONAK                           \ Set global OUT NAK
$00000400 constant OTG1_S_OTG_DCTL_CGONAK                           \ Clear global OUT NAK
$00000800 constant OTG1_S_OTG_DCTL_POPRGDNE                         \ Power-on programming done
$00040000 constant OTG1_S_OTG_DCTL_DSBESLRJCT                       \ Deep sleep BESL reject


\
\ @brief OTG device status register
\ Address offset: 0x808
\ Reset value: 0x00000010
\

$00000001 constant OTG1_S_OTG_DSTS_SUSPSTS                          \ Suspend status
$00000006 constant OTG1_S_OTG_DSTS_ENUMSPD                          \ Enumerated speed
$00000008 constant OTG1_S_OTG_DSTS_EERR                             \ Erratic error
$003fff00 constant OTG1_S_OTG_DSTS_FNSOF                            \ Frame number of the received SOF
$00c00000 constant OTG1_S_OTG_DSTS_DEVLNSTS                         \ Device line status


\
\ @brief OTG device IN endpoint common interrupt mask register
\ Address offset: 0x810
\ Reset value: 0x00000000
\

$00000001 constant OTG1_S_OTG_DIEPMSK_XFRCM                         \ Transfer completed interrupt mask
$00000002 constant OTG1_S_OTG_DIEPMSK_EPDM                          \ Endpoint disabled interrupt mask
$00000004 constant OTG1_S_OTG_DIEPMSK_AHBERRM                       \ AHB error mask
$00000008 constant OTG1_S_OTG_DIEPMSK_TOM                           \ Timeout condition mask (Non-isochronous endpoints)
$00000010 constant OTG1_S_OTG_DIEPMSK_ITTXFEMSK                     \ IN token received when Tx FIFO empty mask
$00000020 constant OTG1_S_OTG_DIEPMSK_INEPNMM                       \ IN token received with EP mismatch mask
$00000040 constant OTG1_S_OTG_DIEPMSK_INEPNEM                       \ IN endpoint NAK effective mask
$00000100 constant OTG1_S_OTG_DIEPMSK_TXFURM                        \ FIFO underrun mask
$00002000 constant OTG1_S_OTG_DIEPMSK_NAKM                          \ NAK interrupt mask


\
\ @brief OTG device OUT endpoint common interrupt mask register
\ Address offset: 0x814
\ Reset value: 0x00000000
\

$00000001 constant OTG1_S_OTG_DOEPMSK_XFRCM                         \ Transfer completed interrupt mask
$00000002 constant OTG1_S_OTG_DOEPMSK_EPDM                          \ Endpoint disabled interrupt mask
$00000004 constant OTG1_S_OTG_DOEPMSK_AHBERRM                       \ AHB error mask
$00000008 constant OTG1_S_OTG_DOEPMSK_STUPM                         \ STUPM: SETUP phase done mask. Applies to control endpoints only.
$00000010 constant OTG1_S_OTG_DOEPMSK_OTEPDM                        \ OUT token received when endpoint disabled mask. Applies to control OUT endpoints only.
$00000020 constant OTG1_S_OTG_DOEPMSK_STSPHSRXM                     \ Status phase received for control write mask
$00000040 constant OTG1_S_OTG_DOEPMSK_B2BSTUPM                      \ Back-to-back SETUP packets received mask
$00000100 constant OTG1_S_OTG_DOEPMSK_OUTPKTERRM                    \ Out packet error mask
$00001000 constant OTG1_S_OTG_DOEPMSK_BERRM                         \ Babble error interrupt mask
$00002000 constant OTG1_S_OTG_DOEPMSK_NAKMSK                        \ NAK interrupt mask
$00004000 constant OTG1_S_OTG_DOEPMSK_NYETMSK                       \ NYET interrupt mask


\
\ @brief OTG device all endpoints interrupt register
\ Address offset: 0x818
\ Reset value: 0x00000000
\

$0000ffff constant OTG1_S_OTG_DAINT_IEPINT                          \ IN endpoint interrupt bits
$ffff0000 constant OTG1_S_OTG_DAINT_OEPINT                          \ OUT endpoint interrupt bits


\
\ @brief OTG all endpoints interrupt mask register
\ Address offset: 0x81C
\ Reset value: 0x00000000
\

$0000ffff constant OTG1_S_OTG_DAINTMSK_IEPM                         \ IN EP interrupt mask bits
$ffff0000 constant OTG1_S_OTG_DAINTMSK_OEPM                         \ OUT EP interrupt mask bits


\
\ @brief OTG device threshold control register
\ Address offset: 0x830
\ Reset value: 0x00000000
\

$00000001 constant OTG1_S_OTG_DTHRCTL_NONISOTHREN                   \ Nonisochronous IN endpoints threshold enable
$00000002 constant OTG1_S_OTG_DTHRCTL_ISOTHREN                      \ ISO IN endpoint threshold enable
$000007fc constant OTG1_S_OTG_DTHRCTL_TXTHRLEN                      \ Transmit threshold length
$00010000 constant OTG1_S_OTG_DTHRCTL_RXTHREN                       \ Receive threshold enable
$03fe0000 constant OTG1_S_OTG_DTHRCTL_RXTHRLEN                      \ Receive threshold length
$08000000 constant OTG1_S_OTG_DTHRCTL_ARPEN                         \ Arbiter parking enable


\
\ @brief OTG device IN endpoint FIFO empty interrupt mask register
\ Address offset: 0x834
\ Reset value: 0x00000000
\

$0000ffff constant OTG1_S_OTG_DIEPEMPMSK_INEPTXFEM                  \ IN EP Tx FIFO empty interrupt mask bits


\
\ @brief OTG device IN endpoint 0 control register [alternate]
\ Address offset: 0x900
\ Reset value: 0x00000000
\

$000007ff constant OTG1_S_OTG_DIEPCTL0_MPSIZ                        \ Maximum packet size
$00008000 constant OTG1_S_OTG_DIEPCTL0_USBAEP                       \ USB active endpoint
$00010000 constant OTG1_S_OTG_DIEPCTL0_DPID                         \ Endpoint data PID
$00020000 constant OTG1_S_OTG_DIEPCTL0_NAKSTS                       \ NAK status
$000c0000 constant OTG1_S_OTG_DIEPCTL0_EPTYP                        \ Endpoint type
$00200000 constant OTG1_S_OTG_DIEPCTL0_STALL                        \ STALL handshake
$03c00000 constant OTG1_S_OTG_DIEPCTL0_TXFNUM                       \ Tx FIFO number
$04000000 constant OTG1_S_OTG_DIEPCTL0_CNAK                         \ Clear NAK
$08000000 constant OTG1_S_OTG_DIEPCTL0_SNAK                         \ Set NAK
$10000000 constant OTG1_S_OTG_DIEPCTL0_SD0PID                       \ Set DATA0 PID
$20000000 constant OTG1_S_OTG_DIEPCTL0_SD1PID                       \ Set DATA1 PID
$40000000 constant OTG1_S_OTG_DIEPCTL0_EPDIS                        \ Endpoint disable
$80000000 constant OTG1_S_OTG_DIEPCTL0_EPENA                        \ Endpoint enable


\
\ @brief OTG device IN endpoint 0 control register [alternate]
\ Address offset: 0x900
\ Reset value: 0x00000000
\

$000007ff constant OTG1_S_OTG_DIEPCTL0_ALTERNATE_MPSIZ              \ Maximum packet size
$00008000 constant OTG1_S_OTG_DIEPCTL0_ALTERNATE_USBAEP             \ USB active endpoint
$00010000 constant OTG1_S_OTG_DIEPCTL0_ALTERNATE_EONUM              \ Even/odd frame
$00020000 constant OTG1_S_OTG_DIEPCTL0_ALTERNATE_NAKSTS             \ NAK status
$000c0000 constant OTG1_S_OTG_DIEPCTL0_ALTERNATE_EPTYP              \ Endpoint type
$00200000 constant OTG1_S_OTG_DIEPCTL0_ALTERNATE_STALL              \ STALL handshake
$03c00000 constant OTG1_S_OTG_DIEPCTL0_ALTERNATE_TXFNUM             \ Tx FIFO number
$04000000 constant OTG1_S_OTG_DIEPCTL0_ALTERNATE_CNAK               \ Clear NAK
$08000000 constant OTG1_S_OTG_DIEPCTL0_ALTERNATE_SNAK               \ Set NAK
$10000000 constant OTG1_S_OTG_DIEPCTL0_ALTERNATE_SEVNFRM            \ Set even frame
$20000000 constant OTG1_S_OTG_DIEPCTL0_ALTERNATE_SODDFRM            \ Set odd frame
$40000000 constant OTG1_S_OTG_DIEPCTL0_ALTERNATE_EPDIS              \ Endpoint disable
$80000000 constant OTG1_S_OTG_DIEPCTL0_ALTERNATE_EPENA              \ Endpoint enable


\
\ @brief OTG device IN endpoint 0 interrupt register
\ Address offset: 0x908
\ Reset value: 0x00000080
\

$00000001 constant OTG1_S_OTG_DIEPINT0_XFRC                         \ Transfer completed interrupt
$00000002 constant OTG1_S_OTG_DIEPINT0_EPDISD                       \ Endpoint disabled interrupt
$00000004 constant OTG1_S_OTG_DIEPINT0_AHBERR                       \ AHB error
$00000008 constant OTG1_S_OTG_DIEPINT0_TOC                          \ Timeout condition
$00000010 constant OTG1_S_OTG_DIEPINT0_ITTXFE                       \ IN token received when Tx FIFO is empty
$00000020 constant OTG1_S_OTG_DIEPINT0_INEPNM                       \ IN token received with EP mismatch
$00000040 constant OTG1_S_OTG_DIEPINT0_INEPNE                       \ IN endpoint NAK effective
$00000080 constant OTG1_S_OTG_DIEPINT0_TXFE                         \ Transmit FIFO empty
$00000100 constant OTG1_S_OTG_DIEPINT0_TXFIFOUDRN                   \ Transmit Fifo Underrun (TxfifoUndrn)
$00000800 constant OTG1_S_OTG_DIEPINT0_PKTDRPSTS                    \ Packet dropped status
$00002000 constant OTG1_S_OTG_DIEPINT0_NAK                          \ NAK input


\
\ @brief OTG device IN endpoint 0 transfer size register
\ Address offset: 0x910
\ Reset value: 0x00000000
\

$0000007f constant OTG1_S_OTG_DIEPTSIZ0_XFRSIZ                      \ Transfer size
$00180000 constant OTG1_S_OTG_DIEPTSIZ0_PKTCNT                      \ Packet count


\
\ @brief OTG device IN endpoint 0 DMA address register
\ Address offset: 0x914
\ Reset value: 0x00000000
\

$00000000 constant OTG1_S_OTG_DIEPDMA0_DMAADDR                      \ DMA Address


\
\ @brief OTG device IN endpoint transmit FIFO status register
\ Address offset: 0x918
\ Reset value: 0x00000200
\

$0000ffff constant OTG1_S_OTG_DTXFSTS0_INEPTFSAV                    \ IN endpoint Tx FIFO space available


\
\ @brief OTG device IN endpoint 1 control register [alternate]
\ Address offset: 0x920
\ Reset value: 0x00000000
\

$000007ff constant OTG1_S_OTG_DIEPCTL1_MPSIZ                        \ Maximum packet size
$00008000 constant OTG1_S_OTG_DIEPCTL1_USBAEP                       \ USB active endpoint
$00010000 constant OTG1_S_OTG_DIEPCTL1_DPID                         \ Endpoint data PID
$00020000 constant OTG1_S_OTG_DIEPCTL1_NAKSTS                       \ NAK status
$000c0000 constant OTG1_S_OTG_DIEPCTL1_EPTYP                        \ Endpoint type
$00200000 constant OTG1_S_OTG_DIEPCTL1_STALL                        \ STALL handshake
$03c00000 constant OTG1_S_OTG_DIEPCTL1_TXFNUM                       \ Tx FIFO number
$04000000 constant OTG1_S_OTG_DIEPCTL1_CNAK                         \ Clear NAK
$08000000 constant OTG1_S_OTG_DIEPCTL1_SNAK                         \ Set NAK
$10000000 constant OTG1_S_OTG_DIEPCTL1_SD0PID                       \ Set DATA0 PID
$20000000 constant OTG1_S_OTG_DIEPCTL1_SD1PID                       \ Set DATA1 PID
$40000000 constant OTG1_S_OTG_DIEPCTL1_EPDIS                        \ Endpoint disable
$80000000 constant OTG1_S_OTG_DIEPCTL1_EPENA                        \ Endpoint enable


\
\ @brief OTG device IN endpoint 1 control register [alternate]
\ Address offset: 0x920
\ Reset value: 0x00000000
\

$000007ff constant OTG1_S_OTG_DIEPCTL1_ALTERNATE_MPSIZ              \ Maximum packet size
$00008000 constant OTG1_S_OTG_DIEPCTL1_ALTERNATE_USBAEP             \ USB active endpoint
$00010000 constant OTG1_S_OTG_DIEPCTL1_ALTERNATE_EONUM              \ Even/odd frame
$00020000 constant OTG1_S_OTG_DIEPCTL1_ALTERNATE_NAKSTS             \ NAK status
$000c0000 constant OTG1_S_OTG_DIEPCTL1_ALTERNATE_EPTYP              \ Endpoint type
$00200000 constant OTG1_S_OTG_DIEPCTL1_ALTERNATE_STALL              \ STALL handshake
$03c00000 constant OTG1_S_OTG_DIEPCTL1_ALTERNATE_TXFNUM             \ Tx FIFO number
$04000000 constant OTG1_S_OTG_DIEPCTL1_ALTERNATE_CNAK               \ Clear NAK
$08000000 constant OTG1_S_OTG_DIEPCTL1_ALTERNATE_SNAK               \ Set NAK
$10000000 constant OTG1_S_OTG_DIEPCTL1_ALTERNATE_SEVNFRM            \ Set even frame
$20000000 constant OTG1_S_OTG_DIEPCTL1_ALTERNATE_SODDFRM            \ Set odd frame
$40000000 constant OTG1_S_OTG_DIEPCTL1_ALTERNATE_EPDIS              \ Endpoint disable
$80000000 constant OTG1_S_OTG_DIEPCTL1_ALTERNATE_EPENA              \ Endpoint enable


\
\ @brief OTG device IN endpoint 1 interrupt register
\ Address offset: 0x928
\ Reset value: 0x00000080
\

$00000001 constant OTG1_S_OTG_DIEPINT1_XFRC                         \ Transfer completed interrupt
$00000002 constant OTG1_S_OTG_DIEPINT1_EPDISD                       \ Endpoint disabled interrupt
$00000004 constant OTG1_S_OTG_DIEPINT1_AHBERR                       \ AHB error
$00000008 constant OTG1_S_OTG_DIEPINT1_TOC                          \ Timeout condition
$00000010 constant OTG1_S_OTG_DIEPINT1_ITTXFE                       \ IN token received when Tx FIFO is empty
$00000020 constant OTG1_S_OTG_DIEPINT1_INEPNM                       \ IN token received with EP mismatch
$00000040 constant OTG1_S_OTG_DIEPINT1_INEPNE                       \ IN endpoint NAK effective
$00000080 constant OTG1_S_OTG_DIEPINT1_TXFE                         \ Transmit FIFO empty
$00000100 constant OTG1_S_OTG_DIEPINT1_TXFIFOUDRN                   \ Transmit Fifo Underrun (TxfifoUndrn)
$00000800 constant OTG1_S_OTG_DIEPINT1_PKTDRPSTS                    \ Packet dropped status
$00002000 constant OTG1_S_OTG_DIEPINT1_NAK                          \ NAK input


\
\ @brief OTG device IN endpoint 1 transfer size register
\ Address offset: 0x930
\ Reset value: 0x00000000
\

$0007ffff constant OTG1_S_OTG_DIEPTSIZ1_XFRSIZ                      \ Transfer size
$1ff80000 constant OTG1_S_OTG_DIEPTSIZ1_PKTCNT                      \ Packet count
$60000000 constant OTG1_S_OTG_DIEPTSIZ1_MCNT                        \ Multi count


\
\ @brief OTG device IN endpoint 1 DMA address register
\ Address offset: 0x934
\ Reset value: 0x00000000
\

$00000000 constant OTG1_S_OTG_DIEPDMA1_DMAADDR                      \ DMA Address


\
\ @brief OTG device IN endpoint transmit FIFO status register
\ Address offset: 0x938
\ Reset value: 0x00000200
\

$0000ffff constant OTG1_S_OTG_DTXFSTS1_INEPTFSAV                    \ IN endpoint Tx FIFO space available


\
\ @brief OTG device IN endpoint 2 control register [alternate]
\ Address offset: 0x940
\ Reset value: 0x00000000
\

$000007ff constant OTG1_S_OTG_DIEPCTL2_MPSIZ                        \ Maximum packet size
$00008000 constant OTG1_S_OTG_DIEPCTL2_USBAEP                       \ USB active endpoint
$00010000 constant OTG1_S_OTG_DIEPCTL2_DPID                         \ Endpoint data PID
$00020000 constant OTG1_S_OTG_DIEPCTL2_NAKSTS                       \ NAK status
$000c0000 constant OTG1_S_OTG_DIEPCTL2_EPTYP                        \ Endpoint type
$00200000 constant OTG1_S_OTG_DIEPCTL2_STALL                        \ STALL handshake
$03c00000 constant OTG1_S_OTG_DIEPCTL2_TXFNUM                       \ Tx FIFO number
$04000000 constant OTG1_S_OTG_DIEPCTL2_CNAK                         \ Clear NAK
$08000000 constant OTG1_S_OTG_DIEPCTL2_SNAK                         \ Set NAK
$10000000 constant OTG1_S_OTG_DIEPCTL2_SD0PID                       \ Set DATA0 PID
$20000000 constant OTG1_S_OTG_DIEPCTL2_SD1PID                       \ Set DATA1 PID
$40000000 constant OTG1_S_OTG_DIEPCTL2_EPDIS                        \ Endpoint disable
$80000000 constant OTG1_S_OTG_DIEPCTL2_EPENA                        \ Endpoint enable


\
\ @brief OTG device IN endpoint 2 control register [alternate]
\ Address offset: 0x940
\ Reset value: 0x00000000
\

$000007ff constant OTG1_S_OTG_DIEPCTL2_ALTERNATE_MPSIZ              \ Maximum packet size
$00008000 constant OTG1_S_OTG_DIEPCTL2_ALTERNATE_USBAEP             \ USB active endpoint
$00010000 constant OTG1_S_OTG_DIEPCTL2_ALTERNATE_EONUM              \ Even/odd frame
$00020000 constant OTG1_S_OTG_DIEPCTL2_ALTERNATE_NAKSTS             \ NAK status
$000c0000 constant OTG1_S_OTG_DIEPCTL2_ALTERNATE_EPTYP              \ Endpoint type
$00200000 constant OTG1_S_OTG_DIEPCTL2_ALTERNATE_STALL              \ STALL handshake
$03c00000 constant OTG1_S_OTG_DIEPCTL2_ALTERNATE_TXFNUM             \ Tx FIFO number
$04000000 constant OTG1_S_OTG_DIEPCTL2_ALTERNATE_CNAK               \ Clear NAK
$08000000 constant OTG1_S_OTG_DIEPCTL2_ALTERNATE_SNAK               \ Set NAK
$10000000 constant OTG1_S_OTG_DIEPCTL2_ALTERNATE_SEVNFRM            \ Set even frame
$20000000 constant OTG1_S_OTG_DIEPCTL2_ALTERNATE_SODDFRM            \ Set odd frame
$40000000 constant OTG1_S_OTG_DIEPCTL2_ALTERNATE_EPDIS              \ Endpoint disable
$80000000 constant OTG1_S_OTG_DIEPCTL2_ALTERNATE_EPENA              \ Endpoint enable


\
\ @brief OTG device IN endpoint 2 interrupt register
\ Address offset: 0x948
\ Reset value: 0x00000080
\

$00000001 constant OTG1_S_OTG_DIEPINT2_XFRC                         \ Transfer completed interrupt
$00000002 constant OTG1_S_OTG_DIEPINT2_EPDISD                       \ Endpoint disabled interrupt
$00000004 constant OTG1_S_OTG_DIEPINT2_AHBERR                       \ AHB error
$00000008 constant OTG1_S_OTG_DIEPINT2_TOC                          \ Timeout condition
$00000010 constant OTG1_S_OTG_DIEPINT2_ITTXFE                       \ IN token received when Tx FIFO is empty
$00000020 constant OTG1_S_OTG_DIEPINT2_INEPNM                       \ IN token received with EP mismatch
$00000040 constant OTG1_S_OTG_DIEPINT2_INEPNE                       \ IN endpoint NAK effective
$00000080 constant OTG1_S_OTG_DIEPINT2_TXFE                         \ Transmit FIFO empty
$00000100 constant OTG1_S_OTG_DIEPINT2_TXFIFOUDRN                   \ Transmit Fifo Underrun (TxfifoUndrn)
$00000800 constant OTG1_S_OTG_DIEPINT2_PKTDRPSTS                    \ Packet dropped status
$00002000 constant OTG1_S_OTG_DIEPINT2_NAK                          \ NAK input


\
\ @brief OTG device IN endpoint 2 transfer size register
\ Address offset: 0x950
\ Reset value: 0x00000000
\

$0007ffff constant OTG1_S_OTG_DIEPTSIZ2_XFRSIZ                      \ Transfer size
$1ff80000 constant OTG1_S_OTG_DIEPTSIZ2_PKTCNT                      \ Packet count
$60000000 constant OTG1_S_OTG_DIEPTSIZ2_MCNT                        \ Multi count


\
\ @brief OTG device IN endpoint 2 DMA address register
\ Address offset: 0x954
\ Reset value: 0x00000000
\

$00000000 constant OTG1_S_OTG_DIEPDMA2_DMAADDR                      \ DMA Address


\
\ @brief OTG device IN endpoint transmit FIFO status register
\ Address offset: 0x958
\ Reset value: 0x00000200
\

$0000ffff constant OTG1_S_OTG_DTXFSTS2_INEPTFSAV                    \ IN endpoint Tx FIFO space available


\
\ @brief OTG device IN endpoint 3 control register [alternate]
\ Address offset: 0x960
\ Reset value: 0x00000000
\

$000007ff constant OTG1_S_OTG_DIEPCTL3_MPSIZ                        \ Maximum packet size
$00008000 constant OTG1_S_OTG_DIEPCTL3_USBAEP                       \ USB active endpoint
$00010000 constant OTG1_S_OTG_DIEPCTL3_DPID                         \ Endpoint data PID
$00020000 constant OTG1_S_OTG_DIEPCTL3_NAKSTS                       \ NAK status
$000c0000 constant OTG1_S_OTG_DIEPCTL3_EPTYP                        \ Endpoint type
$00200000 constant OTG1_S_OTG_DIEPCTL3_STALL                        \ STALL handshake
$03c00000 constant OTG1_S_OTG_DIEPCTL3_TXFNUM                       \ Tx FIFO number
$04000000 constant OTG1_S_OTG_DIEPCTL3_CNAK                         \ Clear NAK
$08000000 constant OTG1_S_OTG_DIEPCTL3_SNAK                         \ Set NAK
$10000000 constant OTG1_S_OTG_DIEPCTL3_SD0PID                       \ Set DATA0 PID
$20000000 constant OTG1_S_OTG_DIEPCTL3_SD1PID                       \ Set DATA1 PID
$40000000 constant OTG1_S_OTG_DIEPCTL3_EPDIS                        \ Endpoint disable
$80000000 constant OTG1_S_OTG_DIEPCTL3_EPENA                        \ Endpoint enable


\
\ @brief OTG device IN endpoint 3 control register [alternate]
\ Address offset: 0x960
\ Reset value: 0x00000000
\

$000007ff constant OTG1_S_OTG_DIEPCTL3_ALTERNATE_MPSIZ              \ Maximum packet size
$00008000 constant OTG1_S_OTG_DIEPCTL3_ALTERNATE_USBAEP             \ USB active endpoint
$00010000 constant OTG1_S_OTG_DIEPCTL3_ALTERNATE_EONUM              \ Even/odd frame
$00020000 constant OTG1_S_OTG_DIEPCTL3_ALTERNATE_NAKSTS             \ NAK status
$000c0000 constant OTG1_S_OTG_DIEPCTL3_ALTERNATE_EPTYP              \ Endpoint type
$00200000 constant OTG1_S_OTG_DIEPCTL3_ALTERNATE_STALL              \ STALL handshake
$03c00000 constant OTG1_S_OTG_DIEPCTL3_ALTERNATE_TXFNUM             \ Tx FIFO number
$04000000 constant OTG1_S_OTG_DIEPCTL3_ALTERNATE_CNAK               \ Clear NAK
$08000000 constant OTG1_S_OTG_DIEPCTL3_ALTERNATE_SNAK               \ Set NAK
$10000000 constant OTG1_S_OTG_DIEPCTL3_ALTERNATE_SEVNFRM            \ Set even frame
$20000000 constant OTG1_S_OTG_DIEPCTL3_ALTERNATE_SODDFRM            \ Set odd frame
$40000000 constant OTG1_S_OTG_DIEPCTL3_ALTERNATE_EPDIS              \ Endpoint disable
$80000000 constant OTG1_S_OTG_DIEPCTL3_ALTERNATE_EPENA              \ Endpoint enable


\
\ @brief OTG device IN endpoint 3 interrupt register
\ Address offset: 0x968
\ Reset value: 0x00000080
\

$00000001 constant OTG1_S_OTG_DIEPINT3_XFRC                         \ Transfer completed interrupt
$00000002 constant OTG1_S_OTG_DIEPINT3_EPDISD                       \ Endpoint disabled interrupt
$00000004 constant OTG1_S_OTG_DIEPINT3_AHBERR                       \ AHB error
$00000008 constant OTG1_S_OTG_DIEPINT3_TOC                          \ Timeout condition
$00000010 constant OTG1_S_OTG_DIEPINT3_ITTXFE                       \ IN token received when Tx FIFO is empty
$00000020 constant OTG1_S_OTG_DIEPINT3_INEPNM                       \ IN token received with EP mismatch
$00000040 constant OTG1_S_OTG_DIEPINT3_INEPNE                       \ IN endpoint NAK effective
$00000080 constant OTG1_S_OTG_DIEPINT3_TXFE                         \ Transmit FIFO empty
$00000100 constant OTG1_S_OTG_DIEPINT3_TXFIFOUDRN                   \ Transmit Fifo Underrun (TxfifoUndrn)
$00000800 constant OTG1_S_OTG_DIEPINT3_PKTDRPSTS                    \ Packet dropped status
$00002000 constant OTG1_S_OTG_DIEPINT3_NAK                          \ NAK input


\
\ @brief OTG device IN endpoint 3 transfer size register
\ Address offset: 0x970
\ Reset value: 0x00000000
\

$0007ffff constant OTG1_S_OTG_DIEPTSIZ3_XFRSIZ                      \ Transfer size
$1ff80000 constant OTG1_S_OTG_DIEPTSIZ3_PKTCNT                      \ Packet count
$60000000 constant OTG1_S_OTG_DIEPTSIZ3_MCNT                        \ Multi count


\
\ @brief OTG device IN endpoint 3 DMA address register
\ Address offset: 0x974
\ Reset value: 0x00000000
\

$00000000 constant OTG1_S_OTG_DIEPDMA3_DMAADDR                      \ DMA Address


\
\ @brief OTG device IN endpoint transmit FIFO status register
\ Address offset: 0x978
\ Reset value: 0x00000200
\

$0000ffff constant OTG1_S_OTG_DTXFSTS3_INEPTFSAV                    \ IN endpoint Tx FIFO space available


\
\ @brief OTG device IN endpoint 4 control register [alternate]
\ Address offset: 0x980
\ Reset value: 0x00000000
\

$000007ff constant OTG1_S_OTG_DIEPCTL4_MPSIZ                        \ Maximum packet size
$00008000 constant OTG1_S_OTG_DIEPCTL4_USBAEP                       \ USB active endpoint
$00010000 constant OTG1_S_OTG_DIEPCTL4_DPID                         \ Endpoint data PID
$00020000 constant OTG1_S_OTG_DIEPCTL4_NAKSTS                       \ NAK status
$000c0000 constant OTG1_S_OTG_DIEPCTL4_EPTYP                        \ Endpoint type
$00200000 constant OTG1_S_OTG_DIEPCTL4_STALL                        \ STALL handshake
$03c00000 constant OTG1_S_OTG_DIEPCTL4_TXFNUM                       \ Tx FIFO number
$04000000 constant OTG1_S_OTG_DIEPCTL4_CNAK                         \ Clear NAK
$08000000 constant OTG1_S_OTG_DIEPCTL4_SNAK                         \ Set NAK
$10000000 constant OTG1_S_OTG_DIEPCTL4_SD0PID                       \ Set DATA0 PID
$20000000 constant OTG1_S_OTG_DIEPCTL4_SD1PID                       \ Set DATA1 PID
$40000000 constant OTG1_S_OTG_DIEPCTL4_EPDIS                        \ Endpoint disable
$80000000 constant OTG1_S_OTG_DIEPCTL4_EPENA                        \ Endpoint enable


\
\ @brief OTG device IN endpoint 4 control register [alternate]
\ Address offset: 0x980
\ Reset value: 0x00000000
\

$000007ff constant OTG1_S_OTG_DIEPCTL4_ALTERNATE_MPSIZ              \ Maximum packet size
$00008000 constant OTG1_S_OTG_DIEPCTL4_ALTERNATE_USBAEP             \ USB active endpoint
$00010000 constant OTG1_S_OTG_DIEPCTL4_ALTERNATE_EONUM              \ Even/odd frame
$00020000 constant OTG1_S_OTG_DIEPCTL4_ALTERNATE_NAKSTS             \ NAK status
$000c0000 constant OTG1_S_OTG_DIEPCTL4_ALTERNATE_EPTYP              \ Endpoint type
$00200000 constant OTG1_S_OTG_DIEPCTL4_ALTERNATE_STALL              \ STALL handshake
$03c00000 constant OTG1_S_OTG_DIEPCTL4_ALTERNATE_TXFNUM             \ Tx FIFO number
$04000000 constant OTG1_S_OTG_DIEPCTL4_ALTERNATE_CNAK               \ Clear NAK
$08000000 constant OTG1_S_OTG_DIEPCTL4_ALTERNATE_SNAK               \ Set NAK
$10000000 constant OTG1_S_OTG_DIEPCTL4_ALTERNATE_SEVNFRM            \ Set even frame
$20000000 constant OTG1_S_OTG_DIEPCTL4_ALTERNATE_SODDFRM            \ Set odd frame
$40000000 constant OTG1_S_OTG_DIEPCTL4_ALTERNATE_EPDIS              \ Endpoint disable
$80000000 constant OTG1_S_OTG_DIEPCTL4_ALTERNATE_EPENA              \ Endpoint enable


\
\ @brief OTG device IN endpoint 4 interrupt register
\ Address offset: 0x988
\ Reset value: 0x00000080
\

$00000001 constant OTG1_S_OTG_DIEPINT4_XFRC                         \ Transfer completed interrupt
$00000002 constant OTG1_S_OTG_DIEPINT4_EPDISD                       \ Endpoint disabled interrupt
$00000004 constant OTG1_S_OTG_DIEPINT4_AHBERR                       \ AHB error
$00000008 constant OTG1_S_OTG_DIEPINT4_TOC                          \ Timeout condition
$00000010 constant OTG1_S_OTG_DIEPINT4_ITTXFE                       \ IN token received when Tx FIFO is empty
$00000020 constant OTG1_S_OTG_DIEPINT4_INEPNM                       \ IN token received with EP mismatch
$00000040 constant OTG1_S_OTG_DIEPINT4_INEPNE                       \ IN endpoint NAK effective
$00000080 constant OTG1_S_OTG_DIEPINT4_TXFE                         \ Transmit FIFO empty
$00000100 constant OTG1_S_OTG_DIEPINT4_TXFIFOUDRN                   \ Transmit Fifo Underrun (TxfifoUndrn)
$00000800 constant OTG1_S_OTG_DIEPINT4_PKTDRPSTS                    \ Packet dropped status
$00002000 constant OTG1_S_OTG_DIEPINT4_NAK                          \ NAK input


\
\ @brief OTG device IN endpoint 4 transfer size register
\ Address offset: 0x990
\ Reset value: 0x00000000
\

$0007ffff constant OTG1_S_OTG_DIEPTSIZ4_XFRSIZ                      \ Transfer size
$1ff80000 constant OTG1_S_OTG_DIEPTSIZ4_PKTCNT                      \ Packet count
$60000000 constant OTG1_S_OTG_DIEPTSIZ4_MCNT                        \ Multi count


\
\ @brief OTG device IN endpoint 4 DMA address register
\ Address offset: 0x994
\ Reset value: 0x00000000
\

$00000000 constant OTG1_S_OTG_DIEPDMA4_DMAADDR                      \ DMA Address


\
\ @brief OTG device IN endpoint transmit FIFO status register
\ Address offset: 0x998
\ Reset value: 0x00000200
\

$0000ffff constant OTG1_S_OTG_DTXFSTS4_INEPTFSAV                    \ IN endpoint Tx FIFO space available


\
\ @brief OTG device IN endpoint 5 control register [alternate]
\ Address offset: 0x9A0
\ Reset value: 0x00000000
\

$000007ff constant OTG1_S_OTG_DIEPCTL5_MPSIZ                        \ Maximum packet size
$00008000 constant OTG1_S_OTG_DIEPCTL5_USBAEP                       \ USB active endpoint
$00010000 constant OTG1_S_OTG_DIEPCTL5_DPID                         \ Endpoint data PID
$00020000 constant OTG1_S_OTG_DIEPCTL5_NAKSTS                       \ NAK status
$000c0000 constant OTG1_S_OTG_DIEPCTL5_EPTYP                        \ Endpoint type
$00200000 constant OTG1_S_OTG_DIEPCTL5_STALL                        \ STALL handshake
$03c00000 constant OTG1_S_OTG_DIEPCTL5_TXFNUM                       \ Tx FIFO number
$04000000 constant OTG1_S_OTG_DIEPCTL5_CNAK                         \ Clear NAK
$08000000 constant OTG1_S_OTG_DIEPCTL5_SNAK                         \ Set NAK
$10000000 constant OTG1_S_OTG_DIEPCTL5_SD0PID                       \ Set DATA0 PID
$20000000 constant OTG1_S_OTG_DIEPCTL5_SD1PID                       \ Set DATA1 PID
$40000000 constant OTG1_S_OTG_DIEPCTL5_EPDIS                        \ Endpoint disable
$80000000 constant OTG1_S_OTG_DIEPCTL5_EPENA                        \ Endpoint enable


\
\ @brief OTG device IN endpoint 5 control register [alternate]
\ Address offset: 0x9A0
\ Reset value: 0x00000000
\

$000007ff constant OTG1_S_OTG_DIEPCTL5_ALTERNATE_MPSIZ              \ Maximum packet size
$00008000 constant OTG1_S_OTG_DIEPCTL5_ALTERNATE_USBAEP             \ USB active endpoint
$00010000 constant OTG1_S_OTG_DIEPCTL5_ALTERNATE_EONUM              \ Even/odd frame
$00020000 constant OTG1_S_OTG_DIEPCTL5_ALTERNATE_NAKSTS             \ NAK status
$000c0000 constant OTG1_S_OTG_DIEPCTL5_ALTERNATE_EPTYP              \ Endpoint type
$00200000 constant OTG1_S_OTG_DIEPCTL5_ALTERNATE_STALL              \ STALL handshake
$03c00000 constant OTG1_S_OTG_DIEPCTL5_ALTERNATE_TXFNUM             \ Tx FIFO number
$04000000 constant OTG1_S_OTG_DIEPCTL5_ALTERNATE_CNAK               \ Clear NAK
$08000000 constant OTG1_S_OTG_DIEPCTL5_ALTERNATE_SNAK               \ Set NAK
$10000000 constant OTG1_S_OTG_DIEPCTL5_ALTERNATE_SEVNFRM            \ Set even frame
$20000000 constant OTG1_S_OTG_DIEPCTL5_ALTERNATE_SODDFRM            \ Set odd frame
$40000000 constant OTG1_S_OTG_DIEPCTL5_ALTERNATE_EPDIS              \ Endpoint disable
$80000000 constant OTG1_S_OTG_DIEPCTL5_ALTERNATE_EPENA              \ Endpoint enable


\
\ @brief OTG device IN endpoint 5 interrupt register
\ Address offset: 0x9A8
\ Reset value: 0x00000080
\

$00000001 constant OTG1_S_OTG_DIEPINT5_XFRC                         \ Transfer completed interrupt
$00000002 constant OTG1_S_OTG_DIEPINT5_EPDISD                       \ Endpoint disabled interrupt
$00000004 constant OTG1_S_OTG_DIEPINT5_AHBERR                       \ AHB error
$00000008 constant OTG1_S_OTG_DIEPINT5_TOC                          \ Timeout condition
$00000010 constant OTG1_S_OTG_DIEPINT5_ITTXFE                       \ IN token received when Tx FIFO is empty
$00000020 constant OTG1_S_OTG_DIEPINT5_INEPNM                       \ IN token received with EP mismatch
$00000040 constant OTG1_S_OTG_DIEPINT5_INEPNE                       \ IN endpoint NAK effective
$00000080 constant OTG1_S_OTG_DIEPINT5_TXFE                         \ Transmit FIFO empty
$00000100 constant OTG1_S_OTG_DIEPINT5_TXFIFOUDRN                   \ Transmit Fifo Underrun (TxfifoUndrn)
$00000800 constant OTG1_S_OTG_DIEPINT5_PKTDRPSTS                    \ Packet dropped status
$00002000 constant OTG1_S_OTG_DIEPINT5_NAK                          \ NAK input


\
\ @brief OTG device IN endpoint 5 transfer size register
\ Address offset: 0x9B0
\ Reset value: 0x00000000
\

$0007ffff constant OTG1_S_OTG_DIEPTSIZ5_XFRSIZ                      \ Transfer size
$1ff80000 constant OTG1_S_OTG_DIEPTSIZ5_PKTCNT                      \ Packet count
$60000000 constant OTG1_S_OTG_DIEPTSIZ5_MCNT                        \ Multi count


\
\ @brief OTG device IN endpoint 5 DMA address register
\ Address offset: 0x9B4
\ Reset value: 0x00000000
\

$00000000 constant OTG1_S_OTG_DIEPDMA5_DMAADDR                      \ DMA Address


\
\ @brief OTG device IN endpoint transmit FIFO status register
\ Address offset: 0x9B8
\ Reset value: 0x00000200
\

$0000ffff constant OTG1_S_OTG_DTXFSTS5_INEPTFSAV                    \ IN endpoint Tx FIFO space available


\
\ @brief OTG device IN endpoint 6 control register [alternate]
\ Address offset: 0x9C0
\ Reset value: 0x00000000
\

$000007ff constant OTG1_S_OTG_DIEPCTL6_MPSIZ                        \ Maximum packet size
$00008000 constant OTG1_S_OTG_DIEPCTL6_USBAEP                       \ USB active endpoint
$00010000 constant OTG1_S_OTG_DIEPCTL6_DPID                         \ Endpoint data PID
$00020000 constant OTG1_S_OTG_DIEPCTL6_NAKSTS                       \ NAK status
$000c0000 constant OTG1_S_OTG_DIEPCTL6_EPTYP                        \ Endpoint type
$00200000 constant OTG1_S_OTG_DIEPCTL6_STALL                        \ STALL handshake
$03c00000 constant OTG1_S_OTG_DIEPCTL6_TXFNUM                       \ Tx FIFO number
$04000000 constant OTG1_S_OTG_DIEPCTL6_CNAK                         \ Clear NAK
$08000000 constant OTG1_S_OTG_DIEPCTL6_SNAK                         \ Set NAK
$10000000 constant OTG1_S_OTG_DIEPCTL6_SD0PID                       \ Set DATA0 PID
$20000000 constant OTG1_S_OTG_DIEPCTL6_SD1PID                       \ Set DATA1 PID
$40000000 constant OTG1_S_OTG_DIEPCTL6_EPDIS                        \ Endpoint disable
$80000000 constant OTG1_S_OTG_DIEPCTL6_EPENA                        \ Endpoint enable


\
\ @brief OTG device IN endpoint 6 control register [alternate]
\ Address offset: 0x9C0
\ Reset value: 0x00000000
\

$000007ff constant OTG1_S_OTG_DIEPCTL6_ALTERNATE_MPSIZ              \ Maximum packet size
$00008000 constant OTG1_S_OTG_DIEPCTL6_ALTERNATE_USBAEP             \ USB active endpoint
$00010000 constant OTG1_S_OTG_DIEPCTL6_ALTERNATE_EONUM              \ Even/odd frame
$00020000 constant OTG1_S_OTG_DIEPCTL6_ALTERNATE_NAKSTS             \ NAK status
$000c0000 constant OTG1_S_OTG_DIEPCTL6_ALTERNATE_EPTYP              \ Endpoint type
$00200000 constant OTG1_S_OTG_DIEPCTL6_ALTERNATE_STALL              \ STALL handshake
$03c00000 constant OTG1_S_OTG_DIEPCTL6_ALTERNATE_TXFNUM             \ Tx FIFO number
$04000000 constant OTG1_S_OTG_DIEPCTL6_ALTERNATE_CNAK               \ Clear NAK
$08000000 constant OTG1_S_OTG_DIEPCTL6_ALTERNATE_SNAK               \ Set NAK
$10000000 constant OTG1_S_OTG_DIEPCTL6_ALTERNATE_SEVNFRM            \ Set even frame
$20000000 constant OTG1_S_OTG_DIEPCTL6_ALTERNATE_SODDFRM            \ Set odd frame
$40000000 constant OTG1_S_OTG_DIEPCTL6_ALTERNATE_EPDIS              \ Endpoint disable
$80000000 constant OTG1_S_OTG_DIEPCTL6_ALTERNATE_EPENA              \ Endpoint enable


\
\ @brief OTG device IN endpoint 6 interrupt register
\ Address offset: 0x9C8
\ Reset value: 0x00000080
\

$00000001 constant OTG1_S_OTG_DIEPINT6_XFRC                         \ Transfer completed interrupt
$00000002 constant OTG1_S_OTG_DIEPINT6_EPDISD                       \ Endpoint disabled interrupt
$00000004 constant OTG1_S_OTG_DIEPINT6_AHBERR                       \ AHB error
$00000008 constant OTG1_S_OTG_DIEPINT6_TOC                          \ Timeout condition
$00000010 constant OTG1_S_OTG_DIEPINT6_ITTXFE                       \ IN token received when Tx FIFO is empty
$00000020 constant OTG1_S_OTG_DIEPINT6_INEPNM                       \ IN token received with EP mismatch
$00000040 constant OTG1_S_OTG_DIEPINT6_INEPNE                       \ IN endpoint NAK effective
$00000080 constant OTG1_S_OTG_DIEPINT6_TXFE                         \ Transmit FIFO empty
$00000100 constant OTG1_S_OTG_DIEPINT6_TXFIFOUDRN                   \ Transmit Fifo Underrun (TxfifoUndrn)
$00000800 constant OTG1_S_OTG_DIEPINT6_PKTDRPSTS                    \ Packet dropped status
$00002000 constant OTG1_S_OTG_DIEPINT6_NAK                          \ NAK input


\
\ @brief OTG device IN endpoint 6 transfer size register
\ Address offset: 0x9D0
\ Reset value: 0x00000000
\

$0007ffff constant OTG1_S_OTG_DIEPTSIZ6_XFRSIZ                      \ Transfer size
$1ff80000 constant OTG1_S_OTG_DIEPTSIZ6_PKTCNT                      \ Packet count
$60000000 constant OTG1_S_OTG_DIEPTSIZ6_MCNT                        \ Multi count


\
\ @brief OTG device IN endpoint 6 DMA address register
\ Address offset: 0x9D4
\ Reset value: 0x00000000
\

$00000000 constant OTG1_S_OTG_DIEPDMA6_DMAADDR                      \ DMA Address


\
\ @brief OTG device IN endpoint transmit FIFO status register
\ Address offset: 0x9D8
\ Reset value: 0x00000200
\

$0000ffff constant OTG1_S_OTG_DTXFSTS6_INEPTFSAV                    \ IN endpoint Tx FIFO space available


\
\ @brief OTG device IN endpoint 7 control register [alternate]
\ Address offset: 0x9E0
\ Reset value: 0x00000000
\

$000007ff constant OTG1_S_OTG_DIEPCTL7_MPSIZ                        \ Maximum packet size
$00008000 constant OTG1_S_OTG_DIEPCTL7_USBAEP                       \ USB active endpoint
$00010000 constant OTG1_S_OTG_DIEPCTL7_DPID                         \ Endpoint data PID
$00020000 constant OTG1_S_OTG_DIEPCTL7_NAKSTS                       \ NAK status
$000c0000 constant OTG1_S_OTG_DIEPCTL7_EPTYP                        \ Endpoint type
$00200000 constant OTG1_S_OTG_DIEPCTL7_STALL                        \ STALL handshake
$03c00000 constant OTG1_S_OTG_DIEPCTL7_TXFNUM                       \ Tx FIFO number
$04000000 constant OTG1_S_OTG_DIEPCTL7_CNAK                         \ Clear NAK
$08000000 constant OTG1_S_OTG_DIEPCTL7_SNAK                         \ Set NAK
$10000000 constant OTG1_S_OTG_DIEPCTL7_SD0PID                       \ Set DATA0 PID
$20000000 constant OTG1_S_OTG_DIEPCTL7_SD1PID                       \ Set DATA1 PID
$40000000 constant OTG1_S_OTG_DIEPCTL7_EPDIS                        \ Endpoint disable
$80000000 constant OTG1_S_OTG_DIEPCTL7_EPENA                        \ Endpoint enable


\
\ @brief OTG device IN endpoint 7 control register [alternate]
\ Address offset: 0x9E0
\ Reset value: 0x00000000
\

$000007ff constant OTG1_S_OTG_DIEPCTL7_ALTERNATE_MPSIZ              \ Maximum packet size
$00008000 constant OTG1_S_OTG_DIEPCTL7_ALTERNATE_USBAEP             \ USB active endpoint
$00010000 constant OTG1_S_OTG_DIEPCTL7_ALTERNATE_EONUM              \ Even/odd frame
$00020000 constant OTG1_S_OTG_DIEPCTL7_ALTERNATE_NAKSTS             \ NAK status
$000c0000 constant OTG1_S_OTG_DIEPCTL7_ALTERNATE_EPTYP              \ Endpoint type
$00200000 constant OTG1_S_OTG_DIEPCTL7_ALTERNATE_STALL              \ STALL handshake
$03c00000 constant OTG1_S_OTG_DIEPCTL7_ALTERNATE_TXFNUM             \ Tx FIFO number
$04000000 constant OTG1_S_OTG_DIEPCTL7_ALTERNATE_CNAK               \ Clear NAK
$08000000 constant OTG1_S_OTG_DIEPCTL7_ALTERNATE_SNAK               \ Set NAK
$10000000 constant OTG1_S_OTG_DIEPCTL7_ALTERNATE_SEVNFRM            \ Set even frame
$20000000 constant OTG1_S_OTG_DIEPCTL7_ALTERNATE_SODDFRM            \ Set odd frame
$40000000 constant OTG1_S_OTG_DIEPCTL7_ALTERNATE_EPDIS              \ Endpoint disable
$80000000 constant OTG1_S_OTG_DIEPCTL7_ALTERNATE_EPENA              \ Endpoint enable


\
\ @brief OTG device IN endpoint 7 interrupt register
\ Address offset: 0x9E8
\ Reset value: 0x00000080
\

$00000001 constant OTG1_S_OTG_DIEPINT7_XFRC                         \ Transfer completed interrupt
$00000002 constant OTG1_S_OTG_DIEPINT7_EPDISD                       \ Endpoint disabled interrupt
$00000004 constant OTG1_S_OTG_DIEPINT7_AHBERR                       \ AHB error
$00000008 constant OTG1_S_OTG_DIEPINT7_TOC                          \ Timeout condition
$00000010 constant OTG1_S_OTG_DIEPINT7_ITTXFE                       \ IN token received when Tx FIFO is empty
$00000020 constant OTG1_S_OTG_DIEPINT7_INEPNM                       \ IN token received with EP mismatch
$00000040 constant OTG1_S_OTG_DIEPINT7_INEPNE                       \ IN endpoint NAK effective
$00000080 constant OTG1_S_OTG_DIEPINT7_TXFE                         \ Transmit FIFO empty
$00000100 constant OTG1_S_OTG_DIEPINT7_TXFIFOUDRN                   \ Transmit Fifo Underrun (TxfifoUndrn)
$00000800 constant OTG1_S_OTG_DIEPINT7_PKTDRPSTS                    \ Packet dropped status
$00002000 constant OTG1_S_OTG_DIEPINT7_NAK                          \ NAK input


\
\ @brief OTG device IN endpoint 7 transfer size register
\ Address offset: 0x9F0
\ Reset value: 0x00000000
\

$0007ffff constant OTG1_S_OTG_DIEPTSIZ7_XFRSIZ                      \ Transfer size
$1ff80000 constant OTG1_S_OTG_DIEPTSIZ7_PKTCNT                      \ Packet count
$60000000 constant OTG1_S_OTG_DIEPTSIZ7_MCNT                        \ Multi count


\
\ @brief OTG device IN endpoint 7 DMA address register
\ Address offset: 0x9F4
\ Reset value: 0x00000000
\

$00000000 constant OTG1_S_OTG_DIEPDMA7_DMAADDR                      \ DMA Address


\
\ @brief OTG device IN endpoint transmit FIFO status register
\ Address offset: 0x9F8
\ Reset value: 0x00000200
\

$0000ffff constant OTG1_S_OTG_DTXFSTS7_INEPTFSAV                    \ IN endpoint Tx FIFO space available


\
\ @brief OTG device IN endpoint 8 control register [alternate]
\ Address offset: 0xA00
\ Reset value: 0x00000000
\

$000007ff constant OTG1_S_OTG_DIEPCTL8_MPSIZ                        \ Maximum packet size
$00008000 constant OTG1_S_OTG_DIEPCTL8_USBAEP                       \ USB active endpoint
$00010000 constant OTG1_S_OTG_DIEPCTL8_DPID                         \ Endpoint data PID
$00020000 constant OTG1_S_OTG_DIEPCTL8_NAKSTS                       \ NAK status
$000c0000 constant OTG1_S_OTG_DIEPCTL8_EPTYP                        \ Endpoint type
$00200000 constant OTG1_S_OTG_DIEPCTL8_STALL                        \ STALL handshake
$03c00000 constant OTG1_S_OTG_DIEPCTL8_TXFNUM                       \ Tx FIFO number
$04000000 constant OTG1_S_OTG_DIEPCTL8_CNAK                         \ Clear NAK
$08000000 constant OTG1_S_OTG_DIEPCTL8_SNAK                         \ Set NAK
$10000000 constant OTG1_S_OTG_DIEPCTL8_SD0PID                       \ Set DATA0 PID
$20000000 constant OTG1_S_OTG_DIEPCTL8_SD1PID                       \ Set DATA1 PID
$40000000 constant OTG1_S_OTG_DIEPCTL8_EPDIS                        \ Endpoint disable
$80000000 constant OTG1_S_OTG_DIEPCTL8_EPENA                        \ Endpoint enable


\
\ @brief OTG device IN endpoint 8 control register [alternate]
\ Address offset: 0xA00
\ Reset value: 0x00000000
\

$000007ff constant OTG1_S_OTG_DIEPCTL8_ALTERNATE_MPSIZ              \ Maximum packet size
$00008000 constant OTG1_S_OTG_DIEPCTL8_ALTERNATE_USBAEP             \ USB active endpoint
$00010000 constant OTG1_S_OTG_DIEPCTL8_ALTERNATE_EONUM              \ Even/odd frame
$00020000 constant OTG1_S_OTG_DIEPCTL8_ALTERNATE_NAKSTS             \ NAK status
$000c0000 constant OTG1_S_OTG_DIEPCTL8_ALTERNATE_EPTYP              \ Endpoint type
$00200000 constant OTG1_S_OTG_DIEPCTL8_ALTERNATE_STALL              \ STALL handshake
$03c00000 constant OTG1_S_OTG_DIEPCTL8_ALTERNATE_TXFNUM             \ Tx FIFO number
$04000000 constant OTG1_S_OTG_DIEPCTL8_ALTERNATE_CNAK               \ Clear NAK
$08000000 constant OTG1_S_OTG_DIEPCTL8_ALTERNATE_SNAK               \ Set NAK
$10000000 constant OTG1_S_OTG_DIEPCTL8_ALTERNATE_SEVNFRM            \ Set even frame
$20000000 constant OTG1_S_OTG_DIEPCTL8_ALTERNATE_SODDFRM            \ Set odd frame
$40000000 constant OTG1_S_OTG_DIEPCTL8_ALTERNATE_EPDIS              \ Endpoint disable
$80000000 constant OTG1_S_OTG_DIEPCTL8_ALTERNATE_EPENA              \ Endpoint enable


\
\ @brief OTG device IN endpoint 8 interrupt register
\ Address offset: 0xA08
\ Reset value: 0x00000080
\

$00000001 constant OTG1_S_OTG_DIEPINT8_XFRC                         \ Transfer completed interrupt
$00000002 constant OTG1_S_OTG_DIEPINT8_EPDISD                       \ Endpoint disabled interrupt
$00000004 constant OTG1_S_OTG_DIEPINT8_AHBERR                       \ AHB error
$00000008 constant OTG1_S_OTG_DIEPINT8_TOC                          \ Timeout condition
$00000010 constant OTG1_S_OTG_DIEPINT8_ITTXFE                       \ IN token received when Tx FIFO is empty
$00000020 constant OTG1_S_OTG_DIEPINT8_INEPNM                       \ IN token received with EP mismatch
$00000040 constant OTG1_S_OTG_DIEPINT8_INEPNE                       \ IN endpoint NAK effective
$00000080 constant OTG1_S_OTG_DIEPINT8_TXFE                         \ Transmit FIFO empty
$00000100 constant OTG1_S_OTG_DIEPINT8_TXFIFOUDRN                   \ Transmit Fifo Underrun (TxfifoUndrn)
$00000800 constant OTG1_S_OTG_DIEPINT8_PKTDRPSTS                    \ Packet dropped status
$00002000 constant OTG1_S_OTG_DIEPINT8_NAK                          \ NAK input


\
\ @brief OTG device IN endpoint 8 transfer size register
\ Address offset: 0xA10
\ Reset value: 0x00000000
\

$0007ffff constant OTG1_S_OTG_DIEPTSIZ8_XFRSIZ                      \ Transfer size
$1ff80000 constant OTG1_S_OTG_DIEPTSIZ8_PKTCNT                      \ Packet count
$60000000 constant OTG1_S_OTG_DIEPTSIZ8_MCNT                        \ Multi count


\
\ @brief OTG device IN endpoint 8 DMA address register
\ Address offset: 0xA14
\ Reset value: 0x00000000
\

$00000000 constant OTG1_S_OTG_DIEPDMA8_DMAADDR                      \ DMA Address


\
\ @brief OTG device IN endpoint transmit FIFO status register
\ Address offset: 0xA18
\ Reset value: 0x00000200
\

$0000ffff constant OTG1_S_OTG_DTXFSTS8_INEPTFSAV                    \ IN endpoint Tx FIFO space available


\
\ @brief OTG device control OUT endpoint 0 control register
\ Address offset: 0xB00
\ Reset value: 0x00008000
\

$00000003 constant OTG1_S_OTG_DOEPCTL0_MPSIZ                        \ Maximum packet size
$00008000 constant OTG1_S_OTG_DOEPCTL0_USBAEP                       \ USB active endpoint
$00020000 constant OTG1_S_OTG_DOEPCTL0_NAKSTS                       \ NAK status
$000c0000 constant OTG1_S_OTG_DOEPCTL0_EPTYP                        \ Endpoint type
$00100000 constant OTG1_S_OTG_DOEPCTL0_SNPM                         \ Snoop mode
$00200000 constant OTG1_S_OTG_DOEPCTL0_STALL                        \ STALL handshake
$04000000 constant OTG1_S_OTG_DOEPCTL0_CNAK                         \ Clear NAK
$08000000 constant OTG1_S_OTG_DOEPCTL0_SNAK                         \ Set NAK
$40000000 constant OTG1_S_OTG_DOEPCTL0_EPDIS                        \ Endpoint disable
$80000000 constant OTG1_S_OTG_DOEPCTL0_EPENA                        \ Endpoint enable


\
\ @brief OTG device OUT endpoint 0 interrupt register
\ Address offset: 0xB08
\ Reset value: 0x00000080
\

$00000001 constant OTG1_S_OTG_DOEPINT0_XFRC                         \ Transfer completed interrupt
$00000002 constant OTG1_S_OTG_DOEPINT0_EPDISD                       \ Endpoint disabled interrupt
$00000004 constant OTG1_S_OTG_DOEPINT0_AHBERR                       \ AHB error
$00000008 constant OTG1_S_OTG_DOEPINT0_STUP                         \ SETUP phase done
$00000010 constant OTG1_S_OTG_DOEPINT0_OTEPDIS                      \ OUT token received when endpoint disabled
$00000020 constant OTG1_S_OTG_DOEPINT0_STSPHSRX                     \ Status phase received for control write
$00000040 constant OTG1_S_OTG_DOEPINT0_B2BSTUP                      \ Back-to-back SETUP packets received
$00000100 constant OTG1_S_OTG_DOEPINT0_OUTPKTERR                    \ OUT packet error
$00001000 constant OTG1_S_OTG_DOEPINT0_BERR                         \ Babble error interrupt
$00002000 constant OTG1_S_OTG_DOEPINT0_NAK                          \ NAK input
$00004000 constant OTG1_S_OTG_DOEPINT0_NYET                         \ NYET interrupt
$00008000 constant OTG1_S_OTG_DOEPINT0_STPKTRX                      \ Setup packet received


\
\ @brief OTG device OUT endpoint 0 transfer size register
\ Address offset: 0xB10
\ Reset value: 0x00000000
\

$0000007f constant OTG1_S_OTG_DOEPTSIZ0_XFRSIZ                      \ Transfer size
$00080000 constant OTG1_S_OTG_DOEPTSIZ0_PKTCNT                      \ Packet count
$60000000 constant OTG1_S_OTG_DOEPTSIZ0_STUPCNT                     \ SETUP packet count


\
\ @brief OTG device OUT endpoint 0 DMA address register
\ Address offset: 0xB14
\ Reset value: 0x00000000
\

$00000000 constant OTG1_S_OTG_DOEPDMA0_DMAADDR                      \ DMA Address


\
\ @brief OTG device OUT endpoint 1 control register [alternate]
\ Address offset: 0xB20
\ Reset value: 0x00000000
\

$000007ff constant OTG1_S_OTG_DOEPCTL1_MPSIZ                        \ Maximum packet size
$00008000 constant OTG1_S_OTG_DOEPCTL1_USBAEP                       \ USB active endpoint
$00010000 constant OTG1_S_OTG_DOEPCTL1_DPID                         \ Endpoint data PID
$00020000 constant OTG1_S_OTG_DOEPCTL1_NAKSTS                       \ NAK status
$000c0000 constant OTG1_S_OTG_DOEPCTL1_EPTYP                        \ Endpoint type
$00100000 constant OTG1_S_OTG_DOEPCTL1_SNPM                         \ Snoop mode
$00200000 constant OTG1_S_OTG_DOEPCTL1_STALL                        \ STALL handshake
$04000000 constant OTG1_S_OTG_DOEPCTL1_CNAK                         \ Clear NAK
$08000000 constant OTG1_S_OTG_DOEPCTL1_SNAK                         \ Set NAK
$10000000 constant OTG1_S_OTG_DOEPCTL1_SD0PID                       \ Set DATA0 PID
$20000000 constant OTG1_S_OTG_DOEPCTL1_SD1PID                       \ Set DATA1 PID
$40000000 constant OTG1_S_OTG_DOEPCTL1_EPDIS                        \ Endpoint disable
$80000000 constant OTG1_S_OTG_DOEPCTL1_EPENA                        \ Endpoint enable


\
\ @brief OTG device OUT endpoint 1 control register [alternate]
\ Address offset: 0xB20
\ Reset value: 0x00000000
\

$000007ff constant OTG1_S_OTG_DOEPCTL1_ALTERNATE_MPSIZ              \ Maximum packet size
$00008000 constant OTG1_S_OTG_DOEPCTL1_ALTERNATE_USBAEP             \ USB active endpoint
$00010000 constant OTG1_S_OTG_DOEPCTL1_ALTERNATE_EONUM              \ Even/odd frame
$00020000 constant OTG1_S_OTG_DOEPCTL1_ALTERNATE_NAKSTS             \ NAK status
$000c0000 constant OTG1_S_OTG_DOEPCTL1_ALTERNATE_EPTYP              \ Endpoint type
$00100000 constant OTG1_S_OTG_DOEPCTL1_ALTERNATE_SNPM               \ Snoop mode
$00200000 constant OTG1_S_OTG_DOEPCTL1_ALTERNATE_STALL              \ STALL handshake
$04000000 constant OTG1_S_OTG_DOEPCTL1_ALTERNATE_CNAK               \ Clear NAK
$08000000 constant OTG1_S_OTG_DOEPCTL1_ALTERNATE_SNAK               \ Set NAK
$10000000 constant OTG1_S_OTG_DOEPCTL1_ALTERNATE_SEVNFRM            \ Set even frame
$20000000 constant OTG1_S_OTG_DOEPCTL1_ALTERNATE_SODDFRM            \ Set odd frame
$40000000 constant OTG1_S_OTG_DOEPCTL1_ALTERNATE_EPDIS              \ Endpoint disable
$80000000 constant OTG1_S_OTG_DOEPCTL1_ALTERNATE_EPENA              \ Endpoint enable


\
\ @brief OTG device OUT endpoint 1 interrupt register
\ Address offset: 0xB28
\ Reset value: 0x00000080
\

$00000001 constant OTG1_S_OTG_DOEPINT1_XFRC                         \ Transfer completed interrupt
$00000002 constant OTG1_S_OTG_DOEPINT1_EPDISD                       \ Endpoint disabled interrupt
$00000004 constant OTG1_S_OTG_DOEPINT1_AHBERR                       \ AHB error
$00000008 constant OTG1_S_OTG_DOEPINT1_STUP                         \ SETUP phase done
$00000010 constant OTG1_S_OTG_DOEPINT1_OTEPDIS                      \ OUT token received when endpoint disabled
$00000020 constant OTG1_S_OTG_DOEPINT1_STSPHSRX                     \ Status phase received for control write
$00000040 constant OTG1_S_OTG_DOEPINT1_B2BSTUP                      \ Back-to-back SETUP packets received
$00000100 constant OTG1_S_OTG_DOEPINT1_OUTPKTERR                    \ OUT packet error
$00001000 constant OTG1_S_OTG_DOEPINT1_BERR                         \ Babble error interrupt
$00002000 constant OTG1_S_OTG_DOEPINT1_NAK                          \ NAK input
$00004000 constant OTG1_S_OTG_DOEPINT1_NYET                         \ NYET interrupt
$00008000 constant OTG1_S_OTG_DOEPINT1_STPKTRX                      \ Setup packet received


\
\ @brief OTG device OUT endpoint 1 transfer size register
\ Address offset: 0xB30
\ Reset value: 0x00000000
\

$0007ffff constant OTG1_S_OTG_DOEPTSIZ1_XFRSIZ                      \ Transfer size
$1ff80000 constant OTG1_S_OTG_DOEPTSIZ1_PKTCNT                      \ Packet count
$60000000 constant OTG1_S_OTG_DOEPTSIZ1_RXDPID                      \ Received data PID


\
\ @brief OTG device OUT endpoint 1 DMA address register
\ Address offset: 0xB34
\ Reset value: 0x00000000
\

$00000000 constant OTG1_S_OTG_DOEPDMA1_DMAADDR                      \ DMA Address


\
\ @brief OTG device OUT endpoint 2 control register [alternate]
\ Address offset: 0xB40
\ Reset value: 0x00000000
\

$000007ff constant OTG1_S_OTG_DOEPCTL2_MPSIZ                        \ Maximum packet size
$00008000 constant OTG1_S_OTG_DOEPCTL2_USBAEP                       \ USB active endpoint
$00010000 constant OTG1_S_OTG_DOEPCTL2_DPID                         \ Endpoint data PID
$00020000 constant OTG1_S_OTG_DOEPCTL2_NAKSTS                       \ NAK status
$000c0000 constant OTG1_S_OTG_DOEPCTL2_EPTYP                        \ Endpoint type
$00100000 constant OTG1_S_OTG_DOEPCTL2_SNPM                         \ Snoop mode
$00200000 constant OTG1_S_OTG_DOEPCTL2_STALL                        \ STALL handshake
$04000000 constant OTG1_S_OTG_DOEPCTL2_CNAK                         \ Clear NAK
$08000000 constant OTG1_S_OTG_DOEPCTL2_SNAK                         \ Set NAK
$10000000 constant OTG1_S_OTG_DOEPCTL2_SD0PID                       \ Set DATA0 PID
$20000000 constant OTG1_S_OTG_DOEPCTL2_SD1PID                       \ Set DATA1 PID
$40000000 constant OTG1_S_OTG_DOEPCTL2_EPDIS                        \ Endpoint disable
$80000000 constant OTG1_S_OTG_DOEPCTL2_EPENA                        \ Endpoint enable


\
\ @brief OTG device OUT endpoint 2 control register [alternate]
\ Address offset: 0xB40
\ Reset value: 0x00000000
\

$000007ff constant OTG1_S_OTG_DOEPCTL2_ALTERNATE_MPSIZ              \ Maximum packet size
$00008000 constant OTG1_S_OTG_DOEPCTL2_ALTERNATE_USBAEP             \ USB active endpoint
$00010000 constant OTG1_S_OTG_DOEPCTL2_ALTERNATE_EONUM              \ Even/odd frame
$00020000 constant OTG1_S_OTG_DOEPCTL2_ALTERNATE_NAKSTS             \ NAK status
$000c0000 constant OTG1_S_OTG_DOEPCTL2_ALTERNATE_EPTYP              \ Endpoint type
$00100000 constant OTG1_S_OTG_DOEPCTL2_ALTERNATE_SNPM               \ Snoop mode
$00200000 constant OTG1_S_OTG_DOEPCTL2_ALTERNATE_STALL              \ STALL handshake
$04000000 constant OTG1_S_OTG_DOEPCTL2_ALTERNATE_CNAK               \ Clear NAK
$08000000 constant OTG1_S_OTG_DOEPCTL2_ALTERNATE_SNAK               \ Set NAK
$10000000 constant OTG1_S_OTG_DOEPCTL2_ALTERNATE_SEVNFRM            \ Set even frame
$20000000 constant OTG1_S_OTG_DOEPCTL2_ALTERNATE_SODDFRM            \ Set odd frame
$40000000 constant OTG1_S_OTG_DOEPCTL2_ALTERNATE_EPDIS              \ Endpoint disable
$80000000 constant OTG1_S_OTG_DOEPCTL2_ALTERNATE_EPENA              \ Endpoint enable


\
\ @brief OTG device OUT endpoint 2 interrupt register
\ Address offset: 0xB48
\ Reset value: 0x00000080
\

$00000001 constant OTG1_S_OTG_DOEPINT2_XFRC                         \ Transfer completed interrupt
$00000002 constant OTG1_S_OTG_DOEPINT2_EPDISD                       \ Endpoint disabled interrupt
$00000004 constant OTG1_S_OTG_DOEPINT2_AHBERR                       \ AHB error
$00000008 constant OTG1_S_OTG_DOEPINT2_STUP                         \ SETUP phase done
$00000010 constant OTG1_S_OTG_DOEPINT2_OTEPDIS                      \ OUT token received when endpoint disabled
$00000020 constant OTG1_S_OTG_DOEPINT2_STSPHSRX                     \ Status phase received for control write
$00000040 constant OTG1_S_OTG_DOEPINT2_B2BSTUP                      \ Back-to-back SETUP packets received
$00000100 constant OTG1_S_OTG_DOEPINT2_OUTPKTERR                    \ OUT packet error
$00001000 constant OTG1_S_OTG_DOEPINT2_BERR                         \ Babble error interrupt
$00002000 constant OTG1_S_OTG_DOEPINT2_NAK                          \ NAK input
$00004000 constant OTG1_S_OTG_DOEPINT2_NYET                         \ NYET interrupt
$00008000 constant OTG1_S_OTG_DOEPINT2_STPKTRX                      \ Setup packet received


\
\ @brief OTG device OUT endpoint 2 transfer size register
\ Address offset: 0xB50
\ Reset value: 0x00000000
\

$0007ffff constant OTG1_S_OTG_DOEPTSIZ2_XFRSIZ                      \ Transfer size
$1ff80000 constant OTG1_S_OTG_DOEPTSIZ2_PKTCNT                      \ Packet count
$60000000 constant OTG1_S_OTG_DOEPTSIZ2_RXDPID                      \ Received data PID


\
\ @brief OTG device OUT endpoint 2 DMA address register
\ Address offset: 0xB54
\ Reset value: 0x00000000
\

$00000000 constant OTG1_S_OTG_DOEPDMA2_DMAADDR                      \ DMA Address


\
\ @brief OTG device OUT endpoint 3 control register [alternate]
\ Address offset: 0xB60
\ Reset value: 0x00000000
\

$000007ff constant OTG1_S_OTG_DOEPCTL3_MPSIZ                        \ Maximum packet size
$00008000 constant OTG1_S_OTG_DOEPCTL3_USBAEP                       \ USB active endpoint
$00010000 constant OTG1_S_OTG_DOEPCTL3_DPID                         \ Endpoint data PID
$00020000 constant OTG1_S_OTG_DOEPCTL3_NAKSTS                       \ NAK status
$000c0000 constant OTG1_S_OTG_DOEPCTL3_EPTYP                        \ Endpoint type
$00100000 constant OTG1_S_OTG_DOEPCTL3_SNPM                         \ Snoop mode
$00200000 constant OTG1_S_OTG_DOEPCTL3_STALL                        \ STALL handshake
$04000000 constant OTG1_S_OTG_DOEPCTL3_CNAK                         \ Clear NAK
$08000000 constant OTG1_S_OTG_DOEPCTL3_SNAK                         \ Set NAK
$10000000 constant OTG1_S_OTG_DOEPCTL3_SD0PID                       \ Set DATA0 PID
$20000000 constant OTG1_S_OTG_DOEPCTL3_SD1PID                       \ Set DATA1 PID
$40000000 constant OTG1_S_OTG_DOEPCTL3_EPDIS                        \ Endpoint disable
$80000000 constant OTG1_S_OTG_DOEPCTL3_EPENA                        \ Endpoint enable


\
\ @brief OTG device OUT endpoint 3 control register [alternate]
\ Address offset: 0xB60
\ Reset value: 0x00000000
\

$000007ff constant OTG1_S_OTG_DOEPCTL3_ALTERNATE_MPSIZ              \ Maximum packet size
$00008000 constant OTG1_S_OTG_DOEPCTL3_ALTERNATE_USBAEP             \ USB active endpoint
$00010000 constant OTG1_S_OTG_DOEPCTL3_ALTERNATE_EONUM              \ Even/odd frame
$00020000 constant OTG1_S_OTG_DOEPCTL3_ALTERNATE_NAKSTS             \ NAK status
$000c0000 constant OTG1_S_OTG_DOEPCTL3_ALTERNATE_EPTYP              \ Endpoint type
$00100000 constant OTG1_S_OTG_DOEPCTL3_ALTERNATE_SNPM               \ Snoop mode
$00200000 constant OTG1_S_OTG_DOEPCTL3_ALTERNATE_STALL              \ STALL handshake
$04000000 constant OTG1_S_OTG_DOEPCTL3_ALTERNATE_CNAK               \ Clear NAK
$08000000 constant OTG1_S_OTG_DOEPCTL3_ALTERNATE_SNAK               \ Set NAK
$10000000 constant OTG1_S_OTG_DOEPCTL3_ALTERNATE_SEVNFRM            \ Set even frame
$20000000 constant OTG1_S_OTG_DOEPCTL3_ALTERNATE_SODDFRM            \ Set odd frame
$40000000 constant OTG1_S_OTG_DOEPCTL3_ALTERNATE_EPDIS              \ Endpoint disable
$80000000 constant OTG1_S_OTG_DOEPCTL3_ALTERNATE_EPENA              \ Endpoint enable


\
\ @brief OTG device OUT endpoint 3 interrupt register
\ Address offset: 0xB68
\ Reset value: 0x00000080
\

$00000001 constant OTG1_S_OTG_DOEPINT3_XFRC                         \ Transfer completed interrupt
$00000002 constant OTG1_S_OTG_DOEPINT3_EPDISD                       \ Endpoint disabled interrupt
$00000004 constant OTG1_S_OTG_DOEPINT3_AHBERR                       \ AHB error
$00000008 constant OTG1_S_OTG_DOEPINT3_STUP                         \ SETUP phase done
$00000010 constant OTG1_S_OTG_DOEPINT3_OTEPDIS                      \ OUT token received when endpoint disabled
$00000020 constant OTG1_S_OTG_DOEPINT3_STSPHSRX                     \ Status phase received for control write
$00000040 constant OTG1_S_OTG_DOEPINT3_B2BSTUP                      \ Back-to-back SETUP packets received
$00000100 constant OTG1_S_OTG_DOEPINT3_OUTPKTERR                    \ OUT packet error
$00001000 constant OTG1_S_OTG_DOEPINT3_BERR                         \ Babble error interrupt
$00002000 constant OTG1_S_OTG_DOEPINT3_NAK                          \ NAK input
$00004000 constant OTG1_S_OTG_DOEPINT3_NYET                         \ NYET interrupt
$00008000 constant OTG1_S_OTG_DOEPINT3_STPKTRX                      \ Setup packet received


\
\ @brief OTG device OUT endpoint 3 transfer size register
\ Address offset: 0xB70
\ Reset value: 0x00000000
\

$0007ffff constant OTG1_S_OTG_DOEPTSIZ3_XFRSIZ                      \ Transfer size
$1ff80000 constant OTG1_S_OTG_DOEPTSIZ3_PKTCNT                      \ Packet count
$60000000 constant OTG1_S_OTG_DOEPTSIZ3_RXDPID                      \ Received data PID


\
\ @brief OTG device OUT endpoint 3 DMA address register
\ Address offset: 0xB74
\ Reset value: 0x00000000
\

$00000000 constant OTG1_S_OTG_DOEPDMA3_DMAADDR                      \ DMA Address


\
\ @brief OTG device OUT endpoint 4 control register [alternate]
\ Address offset: 0xB80
\ Reset value: 0x00000000
\

$000007ff constant OTG1_S_OTG_DOEPCTL4_MPSIZ                        \ Maximum packet size
$00008000 constant OTG1_S_OTG_DOEPCTL4_USBAEP                       \ USB active endpoint
$00010000 constant OTG1_S_OTG_DOEPCTL4_DPID                         \ Endpoint data PID
$00020000 constant OTG1_S_OTG_DOEPCTL4_NAKSTS                       \ NAK status
$000c0000 constant OTG1_S_OTG_DOEPCTL4_EPTYP                        \ Endpoint type
$00100000 constant OTG1_S_OTG_DOEPCTL4_SNPM                         \ Snoop mode
$00200000 constant OTG1_S_OTG_DOEPCTL4_STALL                        \ STALL handshake
$04000000 constant OTG1_S_OTG_DOEPCTL4_CNAK                         \ Clear NAK
$08000000 constant OTG1_S_OTG_DOEPCTL4_SNAK                         \ Set NAK
$10000000 constant OTG1_S_OTG_DOEPCTL4_SD0PID                       \ Set DATA0 PID
$20000000 constant OTG1_S_OTG_DOEPCTL4_SD1PID                       \ Set DATA1 PID
$40000000 constant OTG1_S_OTG_DOEPCTL4_EPDIS                        \ Endpoint disable
$80000000 constant OTG1_S_OTG_DOEPCTL4_EPENA                        \ Endpoint enable


\
\ @brief OTG device OUT endpoint 4 control register [alternate]
\ Address offset: 0xB80
\ Reset value: 0x00000000
\

$000007ff constant OTG1_S_OTG_DOEPCTL4_ALTERNATE_MPSIZ              \ Maximum packet size
$00008000 constant OTG1_S_OTG_DOEPCTL4_ALTERNATE_USBAEP             \ USB active endpoint
$00010000 constant OTG1_S_OTG_DOEPCTL4_ALTERNATE_EONUM              \ Even/odd frame
$00020000 constant OTG1_S_OTG_DOEPCTL4_ALTERNATE_NAKSTS             \ NAK status
$000c0000 constant OTG1_S_OTG_DOEPCTL4_ALTERNATE_EPTYP              \ Endpoint type
$00100000 constant OTG1_S_OTG_DOEPCTL4_ALTERNATE_SNPM               \ Snoop mode
$00200000 constant OTG1_S_OTG_DOEPCTL4_ALTERNATE_STALL              \ STALL handshake
$04000000 constant OTG1_S_OTG_DOEPCTL4_ALTERNATE_CNAK               \ Clear NAK
$08000000 constant OTG1_S_OTG_DOEPCTL4_ALTERNATE_SNAK               \ Set NAK
$10000000 constant OTG1_S_OTG_DOEPCTL4_ALTERNATE_SEVNFRM            \ Set even frame
$20000000 constant OTG1_S_OTG_DOEPCTL4_ALTERNATE_SODDFRM            \ Set odd frame
$40000000 constant OTG1_S_OTG_DOEPCTL4_ALTERNATE_EPDIS              \ Endpoint disable
$80000000 constant OTG1_S_OTG_DOEPCTL4_ALTERNATE_EPENA              \ Endpoint enable


\
\ @brief OTG device OUT endpoint 4 interrupt register
\ Address offset: 0xB88
\ Reset value: 0x00000080
\

$00000001 constant OTG1_S_OTG_DOEPINT4_XFRC                         \ Transfer completed interrupt
$00000002 constant OTG1_S_OTG_DOEPINT4_EPDISD                       \ Endpoint disabled interrupt
$00000004 constant OTG1_S_OTG_DOEPINT4_AHBERR                       \ AHB error
$00000008 constant OTG1_S_OTG_DOEPINT4_STUP                         \ SETUP phase done
$00000010 constant OTG1_S_OTG_DOEPINT4_OTEPDIS                      \ OUT token received when endpoint disabled
$00000020 constant OTG1_S_OTG_DOEPINT4_STSPHSRX                     \ Status phase received for control write
$00000040 constant OTG1_S_OTG_DOEPINT4_B2BSTUP                      \ Back-to-back SETUP packets received
$00000100 constant OTG1_S_OTG_DOEPINT4_OUTPKTERR                    \ OUT packet error
$00001000 constant OTG1_S_OTG_DOEPINT4_BERR                         \ Babble error interrupt
$00002000 constant OTG1_S_OTG_DOEPINT4_NAK                          \ NAK input
$00004000 constant OTG1_S_OTG_DOEPINT4_NYET                         \ NYET interrupt
$00008000 constant OTG1_S_OTG_DOEPINT4_STPKTRX                      \ Setup packet received


\
\ @brief OTG device OUT endpoint 4 transfer size register
\ Address offset: 0xB90
\ Reset value: 0x00000000
\

$0007ffff constant OTG1_S_OTG_DOEPTSIZ4_XFRSIZ                      \ Transfer size
$1ff80000 constant OTG1_S_OTG_DOEPTSIZ4_PKTCNT                      \ Packet count
$60000000 constant OTG1_S_OTG_DOEPTSIZ4_RXDPID                      \ Received data PID


\
\ @brief OTG device OUT endpoint 4 DMA address register
\ Address offset: 0xB94
\ Reset value: 0x00000000
\

$00000000 constant OTG1_S_OTG_DOEPDMA4_DMAADDR                      \ DMA Address


\
\ @brief OTG device OUT endpoint 5 control register [alternate]
\ Address offset: 0xBA0
\ Reset value: 0x00000000
\

$000007ff constant OTG1_S_OTG_DOEPCTL5_MPSIZ                        \ Maximum packet size
$00008000 constant OTG1_S_OTG_DOEPCTL5_USBAEP                       \ USB active endpoint
$00010000 constant OTG1_S_OTG_DOEPCTL5_DPID                         \ Endpoint data PID
$00020000 constant OTG1_S_OTG_DOEPCTL5_NAKSTS                       \ NAK status
$000c0000 constant OTG1_S_OTG_DOEPCTL5_EPTYP                        \ Endpoint type
$00100000 constant OTG1_S_OTG_DOEPCTL5_SNPM                         \ Snoop mode
$00200000 constant OTG1_S_OTG_DOEPCTL5_STALL                        \ STALL handshake
$04000000 constant OTG1_S_OTG_DOEPCTL5_CNAK                         \ Clear NAK
$08000000 constant OTG1_S_OTG_DOEPCTL5_SNAK                         \ Set NAK
$10000000 constant OTG1_S_OTG_DOEPCTL5_SD0PID                       \ Set DATA0 PID
$20000000 constant OTG1_S_OTG_DOEPCTL5_SD1PID                       \ Set DATA1 PID
$40000000 constant OTG1_S_OTG_DOEPCTL5_EPDIS                        \ Endpoint disable
$80000000 constant OTG1_S_OTG_DOEPCTL5_EPENA                        \ Endpoint enable


\
\ @brief OTG device OUT endpoint 5 control register [alternate]
\ Address offset: 0xBA0
\ Reset value: 0x00000000
\

$000007ff constant OTG1_S_OTG_DOEPCTL5_ALTERNATE_MPSIZ              \ Maximum packet size
$00008000 constant OTG1_S_OTG_DOEPCTL5_ALTERNATE_USBAEP             \ USB active endpoint
$00010000 constant OTG1_S_OTG_DOEPCTL5_ALTERNATE_EONUM              \ Even/odd frame
$00020000 constant OTG1_S_OTG_DOEPCTL5_ALTERNATE_NAKSTS             \ NAK status
$000c0000 constant OTG1_S_OTG_DOEPCTL5_ALTERNATE_EPTYP              \ Endpoint type
$00100000 constant OTG1_S_OTG_DOEPCTL5_ALTERNATE_SNPM               \ Snoop mode
$00200000 constant OTG1_S_OTG_DOEPCTL5_ALTERNATE_STALL              \ STALL handshake
$04000000 constant OTG1_S_OTG_DOEPCTL5_ALTERNATE_CNAK               \ Clear NAK
$08000000 constant OTG1_S_OTG_DOEPCTL5_ALTERNATE_SNAK               \ Set NAK
$10000000 constant OTG1_S_OTG_DOEPCTL5_ALTERNATE_SEVNFRM            \ Set even frame
$20000000 constant OTG1_S_OTG_DOEPCTL5_ALTERNATE_SODDFRM            \ Set odd frame
$40000000 constant OTG1_S_OTG_DOEPCTL5_ALTERNATE_EPDIS              \ Endpoint disable
$80000000 constant OTG1_S_OTG_DOEPCTL5_ALTERNATE_EPENA              \ Endpoint enable


\
\ @brief OTG device OUT endpoint 5 interrupt register
\ Address offset: 0xBA8
\ Reset value: 0x00000080
\

$00000001 constant OTG1_S_OTG_DOEPINT5_XFRC                         \ Transfer completed interrupt
$00000002 constant OTG1_S_OTG_DOEPINT5_EPDISD                       \ Endpoint disabled interrupt
$00000004 constant OTG1_S_OTG_DOEPINT5_AHBERR                       \ AHB error
$00000008 constant OTG1_S_OTG_DOEPINT5_STUP                         \ SETUP phase done
$00000010 constant OTG1_S_OTG_DOEPINT5_OTEPDIS                      \ OUT token received when endpoint disabled
$00000020 constant OTG1_S_OTG_DOEPINT5_STSPHSRX                     \ Status phase received for control write
$00000040 constant OTG1_S_OTG_DOEPINT5_B2BSTUP                      \ Back-to-back SETUP packets received
$00000100 constant OTG1_S_OTG_DOEPINT5_OUTPKTERR                    \ OUT packet error
$00001000 constant OTG1_S_OTG_DOEPINT5_BERR                         \ Babble error interrupt
$00002000 constant OTG1_S_OTG_DOEPINT5_NAK                          \ NAK input
$00004000 constant OTG1_S_OTG_DOEPINT5_NYET                         \ NYET interrupt
$00008000 constant OTG1_S_OTG_DOEPINT5_STPKTRX                      \ Setup packet received


\
\ @brief OTG device OUT endpoint 5 transfer size register
\ Address offset: 0xBB0
\ Reset value: 0x00000000
\

$0007ffff constant OTG1_S_OTG_DOEPTSIZ5_XFRSIZ                      \ Transfer size
$1ff80000 constant OTG1_S_OTG_DOEPTSIZ5_PKTCNT                      \ Packet count
$60000000 constant OTG1_S_OTG_DOEPTSIZ5_RXDPID                      \ Received data PID


\
\ @brief OTG device OUT endpoint 5 DMA address register
\ Address offset: 0xBB4
\ Reset value: 0x00000000
\

$00000000 constant OTG1_S_OTG_DOEPDMA5_DMAADDR                      \ DMA Address


\
\ @brief OTG device OUT endpoint 6 control register [alternate]
\ Address offset: 0xBC0
\ Reset value: 0x00000000
\

$000007ff constant OTG1_S_OTG_DOEPCTL6_MPSIZ                        \ Maximum packet size
$00008000 constant OTG1_S_OTG_DOEPCTL6_USBAEP                       \ USB active endpoint
$00010000 constant OTG1_S_OTG_DOEPCTL6_DPID                         \ Endpoint data PID
$00020000 constant OTG1_S_OTG_DOEPCTL6_NAKSTS                       \ NAK status
$000c0000 constant OTG1_S_OTG_DOEPCTL6_EPTYP                        \ Endpoint type
$00100000 constant OTG1_S_OTG_DOEPCTL6_SNPM                         \ Snoop mode
$00200000 constant OTG1_S_OTG_DOEPCTL6_STALL                        \ STALL handshake
$04000000 constant OTG1_S_OTG_DOEPCTL6_CNAK                         \ Clear NAK
$08000000 constant OTG1_S_OTG_DOEPCTL6_SNAK                         \ Set NAK
$10000000 constant OTG1_S_OTG_DOEPCTL6_SD0PID                       \ Set DATA0 PID
$20000000 constant OTG1_S_OTG_DOEPCTL6_SD1PID                       \ Set DATA1 PID
$40000000 constant OTG1_S_OTG_DOEPCTL6_EPDIS                        \ Endpoint disable
$80000000 constant OTG1_S_OTG_DOEPCTL6_EPENA                        \ Endpoint enable


\
\ @brief OTG device OUT endpoint 6 control register [alternate]
\ Address offset: 0xBC0
\ Reset value: 0x00000000
\

$000007ff constant OTG1_S_OTG_DOEPCTL6_ALTERNATE_MPSIZ              \ Maximum packet size
$00008000 constant OTG1_S_OTG_DOEPCTL6_ALTERNATE_USBAEP             \ USB active endpoint
$00010000 constant OTG1_S_OTG_DOEPCTL6_ALTERNATE_EONUM              \ Even/odd frame
$00020000 constant OTG1_S_OTG_DOEPCTL6_ALTERNATE_NAKSTS             \ NAK status
$000c0000 constant OTG1_S_OTG_DOEPCTL6_ALTERNATE_EPTYP              \ Endpoint type
$00100000 constant OTG1_S_OTG_DOEPCTL6_ALTERNATE_SNPM               \ Snoop mode
$00200000 constant OTG1_S_OTG_DOEPCTL6_ALTERNATE_STALL              \ STALL handshake
$04000000 constant OTG1_S_OTG_DOEPCTL6_ALTERNATE_CNAK               \ Clear NAK
$08000000 constant OTG1_S_OTG_DOEPCTL6_ALTERNATE_SNAK               \ Set NAK
$10000000 constant OTG1_S_OTG_DOEPCTL6_ALTERNATE_SEVNFRM            \ Set even frame
$20000000 constant OTG1_S_OTG_DOEPCTL6_ALTERNATE_SODDFRM            \ Set odd frame
$40000000 constant OTG1_S_OTG_DOEPCTL6_ALTERNATE_EPDIS              \ Endpoint disable
$80000000 constant OTG1_S_OTG_DOEPCTL6_ALTERNATE_EPENA              \ Endpoint enable


\
\ @brief OTG device OUT endpoint 6 interrupt register
\ Address offset: 0xBC8
\ Reset value: 0x00000080
\

$00000001 constant OTG1_S_OTG_DOEPINT6_XFRC                         \ Transfer completed interrupt
$00000002 constant OTG1_S_OTG_DOEPINT6_EPDISD                       \ Endpoint disabled interrupt
$00000004 constant OTG1_S_OTG_DOEPINT6_AHBERR                       \ AHB error
$00000008 constant OTG1_S_OTG_DOEPINT6_STUP                         \ SETUP phase done
$00000010 constant OTG1_S_OTG_DOEPINT6_OTEPDIS                      \ OUT token received when endpoint disabled
$00000020 constant OTG1_S_OTG_DOEPINT6_STSPHSRX                     \ Status phase received for control write
$00000040 constant OTG1_S_OTG_DOEPINT6_B2BSTUP                      \ Back-to-back SETUP packets received
$00000100 constant OTG1_S_OTG_DOEPINT6_OUTPKTERR                    \ OUT packet error
$00001000 constant OTG1_S_OTG_DOEPINT6_BERR                         \ Babble error interrupt
$00002000 constant OTG1_S_OTG_DOEPINT6_NAK                          \ NAK input
$00004000 constant OTG1_S_OTG_DOEPINT6_NYET                         \ NYET interrupt
$00008000 constant OTG1_S_OTG_DOEPINT6_STPKTRX                      \ Setup packet received


\
\ @brief OTG device OUT endpoint 6 transfer size register
\ Address offset: 0xBD0
\ Reset value: 0x00000000
\

$0007ffff constant OTG1_S_OTG_DOEPTSIZ6_XFRSIZ                      \ Transfer size
$1ff80000 constant OTG1_S_OTG_DOEPTSIZ6_PKTCNT                      \ Packet count
$60000000 constant OTG1_S_OTG_DOEPTSIZ6_RXDPID                      \ Received data PID


\
\ @brief OTG device OUT endpoint 6 DMA address register
\ Address offset: 0xBD4
\ Reset value: 0x00000000
\

$00000000 constant OTG1_S_OTG_DOEPDMA6_DMAADDR                      \ DMA Address


\
\ @brief OTG device OUT endpoint 7 control register [alternate]
\ Address offset: 0xBE0
\ Reset value: 0x00000000
\

$000007ff constant OTG1_S_OTG_DOEPCTL7_MPSIZ                        \ Maximum packet size
$00008000 constant OTG1_S_OTG_DOEPCTL7_USBAEP                       \ USB active endpoint
$00010000 constant OTG1_S_OTG_DOEPCTL7_DPID                         \ Endpoint data PID
$00020000 constant OTG1_S_OTG_DOEPCTL7_NAKSTS                       \ NAK status
$000c0000 constant OTG1_S_OTG_DOEPCTL7_EPTYP                        \ Endpoint type
$00100000 constant OTG1_S_OTG_DOEPCTL7_SNPM                         \ Snoop mode
$00200000 constant OTG1_S_OTG_DOEPCTL7_STALL                        \ STALL handshake
$04000000 constant OTG1_S_OTG_DOEPCTL7_CNAK                         \ Clear NAK
$08000000 constant OTG1_S_OTG_DOEPCTL7_SNAK                         \ Set NAK
$10000000 constant OTG1_S_OTG_DOEPCTL7_SD0PID                       \ Set DATA0 PID
$20000000 constant OTG1_S_OTG_DOEPCTL7_SD1PID                       \ Set DATA1 PID
$40000000 constant OTG1_S_OTG_DOEPCTL7_EPDIS                        \ Endpoint disable
$80000000 constant OTG1_S_OTG_DOEPCTL7_EPENA                        \ Endpoint enable


\
\ @brief OTG device OUT endpoint 7 control register [alternate]
\ Address offset: 0xBE0
\ Reset value: 0x00000000
\

$000007ff constant OTG1_S_OTG_DOEPCTL7_ALTERNATE_MPSIZ              \ Maximum packet size
$00008000 constant OTG1_S_OTG_DOEPCTL7_ALTERNATE_USBAEP             \ USB active endpoint
$00010000 constant OTG1_S_OTG_DOEPCTL7_ALTERNATE_EONUM              \ Even/odd frame
$00020000 constant OTG1_S_OTG_DOEPCTL7_ALTERNATE_NAKSTS             \ NAK status
$000c0000 constant OTG1_S_OTG_DOEPCTL7_ALTERNATE_EPTYP              \ Endpoint type
$00100000 constant OTG1_S_OTG_DOEPCTL7_ALTERNATE_SNPM               \ Snoop mode
$00200000 constant OTG1_S_OTG_DOEPCTL7_ALTERNATE_STALL              \ STALL handshake
$04000000 constant OTG1_S_OTG_DOEPCTL7_ALTERNATE_CNAK               \ Clear NAK
$08000000 constant OTG1_S_OTG_DOEPCTL7_ALTERNATE_SNAK               \ Set NAK
$10000000 constant OTG1_S_OTG_DOEPCTL7_ALTERNATE_SEVNFRM            \ Set even frame
$20000000 constant OTG1_S_OTG_DOEPCTL7_ALTERNATE_SODDFRM            \ Set odd frame
$40000000 constant OTG1_S_OTG_DOEPCTL7_ALTERNATE_EPDIS              \ Endpoint disable
$80000000 constant OTG1_S_OTG_DOEPCTL7_ALTERNATE_EPENA              \ Endpoint enable


\
\ @brief OTG device OUT endpoint 7 interrupt register
\ Address offset: 0xBE8
\ Reset value: 0x00000080
\

$00000001 constant OTG1_S_OTG_DOEPINT7_XFRC                         \ Transfer completed interrupt
$00000002 constant OTG1_S_OTG_DOEPINT7_EPDISD                       \ Endpoint disabled interrupt
$00000004 constant OTG1_S_OTG_DOEPINT7_AHBERR                       \ AHB error
$00000008 constant OTG1_S_OTG_DOEPINT7_STUP                         \ SETUP phase done
$00000010 constant OTG1_S_OTG_DOEPINT7_OTEPDIS                      \ OUT token received when endpoint disabled
$00000020 constant OTG1_S_OTG_DOEPINT7_STSPHSRX                     \ Status phase received for control write
$00000040 constant OTG1_S_OTG_DOEPINT7_B2BSTUP                      \ Back-to-back SETUP packets received
$00000100 constant OTG1_S_OTG_DOEPINT7_OUTPKTERR                    \ OUT packet error
$00001000 constant OTG1_S_OTG_DOEPINT7_BERR                         \ Babble error interrupt
$00002000 constant OTG1_S_OTG_DOEPINT7_NAK                          \ NAK input
$00004000 constant OTG1_S_OTG_DOEPINT7_NYET                         \ NYET interrupt
$00008000 constant OTG1_S_OTG_DOEPINT7_STPKTRX                      \ Setup packet received


\
\ @brief OTG device OUT endpoint 7 transfer size register
\ Address offset: 0xBF0
\ Reset value: 0x00000000
\

$0007ffff constant OTG1_S_OTG_DOEPTSIZ7_XFRSIZ                      \ Transfer size
$1ff80000 constant OTG1_S_OTG_DOEPTSIZ7_PKTCNT                      \ Packet count
$60000000 constant OTG1_S_OTG_DOEPTSIZ7_RXDPID                      \ Received data PID


\
\ @brief OTG device OUT endpoint 7 DMA address register
\ Address offset: 0xBF4
\ Reset value: 0x00000000
\

$00000000 constant OTG1_S_OTG_DOEPDMA7_DMAADDR                      \ DMA Address


\
\ @brief OTG device OUT endpoint 8 control register [alternate]
\ Address offset: 0xC00
\ Reset value: 0x00000000
\

$000007ff constant OTG1_S_OTG_DOEPCTL8_MPSIZ                        \ Maximum packet size
$00008000 constant OTG1_S_OTG_DOEPCTL8_USBAEP                       \ USB active endpoint
$00010000 constant OTG1_S_OTG_DOEPCTL8_DPID                         \ Endpoint data PID
$00020000 constant OTG1_S_OTG_DOEPCTL8_NAKSTS                       \ NAK status
$000c0000 constant OTG1_S_OTG_DOEPCTL8_EPTYP                        \ Endpoint type
$00100000 constant OTG1_S_OTG_DOEPCTL8_SNPM                         \ Snoop mode
$00200000 constant OTG1_S_OTG_DOEPCTL8_STALL                        \ STALL handshake
$04000000 constant OTG1_S_OTG_DOEPCTL8_CNAK                         \ Clear NAK
$08000000 constant OTG1_S_OTG_DOEPCTL8_SNAK                         \ Set NAK
$10000000 constant OTG1_S_OTG_DOEPCTL8_SD0PID                       \ Set DATA0 PID
$20000000 constant OTG1_S_OTG_DOEPCTL8_SD1PID                       \ Set DATA1 PID
$40000000 constant OTG1_S_OTG_DOEPCTL8_EPDIS                        \ Endpoint disable
$80000000 constant OTG1_S_OTG_DOEPCTL8_EPENA                        \ Endpoint enable


\
\ @brief OTG device OUT endpoint 8 control register [alternate]
\ Address offset: 0xC00
\ Reset value: 0x00000000
\

$000007ff constant OTG1_S_OTG_DOEPCTL8_ALTERNATE_MPSIZ              \ Maximum packet size
$00008000 constant OTG1_S_OTG_DOEPCTL8_ALTERNATE_USBAEP             \ USB active endpoint
$00010000 constant OTG1_S_OTG_DOEPCTL8_ALTERNATE_EONUM              \ Even/odd frame
$00020000 constant OTG1_S_OTG_DOEPCTL8_ALTERNATE_NAKSTS             \ NAK status
$000c0000 constant OTG1_S_OTG_DOEPCTL8_ALTERNATE_EPTYP              \ Endpoint type
$00100000 constant OTG1_S_OTG_DOEPCTL8_ALTERNATE_SNPM               \ Snoop mode
$00200000 constant OTG1_S_OTG_DOEPCTL8_ALTERNATE_STALL              \ STALL handshake
$04000000 constant OTG1_S_OTG_DOEPCTL8_ALTERNATE_CNAK               \ Clear NAK
$08000000 constant OTG1_S_OTG_DOEPCTL8_ALTERNATE_SNAK               \ Set NAK
$10000000 constant OTG1_S_OTG_DOEPCTL8_ALTERNATE_SEVNFRM            \ Set even frame
$20000000 constant OTG1_S_OTG_DOEPCTL8_ALTERNATE_SODDFRM            \ Set odd frame
$40000000 constant OTG1_S_OTG_DOEPCTL8_ALTERNATE_EPDIS              \ Endpoint disable
$80000000 constant OTG1_S_OTG_DOEPCTL8_ALTERNATE_EPENA              \ Endpoint enable


\
\ @brief OTG device OUT endpoint 8 interrupt register
\ Address offset: 0xC08
\ Reset value: 0x00000080
\

$00000001 constant OTG1_S_OTG_DOEPINT8_XFRC                         \ Transfer completed interrupt
$00000002 constant OTG1_S_OTG_DOEPINT8_EPDISD                       \ Endpoint disabled interrupt
$00000004 constant OTG1_S_OTG_DOEPINT8_AHBERR                       \ AHB error
$00000008 constant OTG1_S_OTG_DOEPINT8_STUP                         \ SETUP phase done
$00000010 constant OTG1_S_OTG_DOEPINT8_OTEPDIS                      \ OUT token received when endpoint disabled
$00000020 constant OTG1_S_OTG_DOEPINT8_STSPHSRX                     \ Status phase received for control write
$00000040 constant OTG1_S_OTG_DOEPINT8_B2BSTUP                      \ Back-to-back SETUP packets received
$00000100 constant OTG1_S_OTG_DOEPINT8_OUTPKTERR                    \ OUT packet error
$00001000 constant OTG1_S_OTG_DOEPINT8_BERR                         \ Babble error interrupt
$00002000 constant OTG1_S_OTG_DOEPINT8_NAK                          \ NAK input
$00004000 constant OTG1_S_OTG_DOEPINT8_NYET                         \ NYET interrupt
$00008000 constant OTG1_S_OTG_DOEPINT8_STPKTRX                      \ Setup packet received


\
\ @brief OTG device OUT endpoint 8 transfer size register
\ Address offset: 0xC10
\ Reset value: 0x00000000
\

$0007ffff constant OTG1_S_OTG_DOEPTSIZ8_XFRSIZ                      \ Transfer size
$1ff80000 constant OTG1_S_OTG_DOEPTSIZ8_PKTCNT                      \ Packet count
$60000000 constant OTG1_S_OTG_DOEPTSIZ8_RXDPID                      \ Received data PID


\
\ @brief OTG device OUT endpoint 8 DMA address register
\ Address offset: 0xC14
\ Reset value: 0x00000000
\

$00000000 constant OTG1_S_OTG_DOEPDMA8_DMAADDR                      \ DMA Address


\
\ @brief OTG power and clock gating control register
\ Address offset: 0xE00
\ Reset value: 0x200B8000
\

$00000001 constant OTG1_S_OTG_PCGCCTL_STPPCLK                       \ Stop PHY clock
$00000002 constant OTG1_S_OTG_PCGCCTL_GATEHCLK                      \ Gate HCLK
$00000010 constant OTG1_S_OTG_PCGCCTL_PHYSUSP                       \ PHY suspended
$00000020 constant OTG1_S_OTG_PCGCCTL_ENL1GTG                       \ Enable sleep clock gating
$00000040 constant OTG1_S_OTG_PCGCCTL_PHYSLEEP                      \ PHY in Sleep
$00000080 constant OTG1_S_OTG_PCGCCTL_SUSP                          \ Deep Sleep


\
\ @brief OTG power and clock gating control register 1
\ Address offset: 0xE04
\ Reset value: 0x00000000
\

$00000001 constant OTG1_S_OTG_PCGCCTL1_GATEEN                       \ Enable active clock gating
$00000006 constant OTG1_S_OTG_PCGCCTL1_CNTGATECLK                   \ Counter for clock gating
$00000008 constant OTG1_S_OTG_PCGCCTL1_RAMGATEEN                    \ Enable RAM clock gating


\
\ @brief USB on-the-go high-speed
\
$58040000 constant OTG1_S_OTG_GOTGCTL  \ offset: 0x00 : OTG control and status register
$58040004 constant OTG1_S_OTG_GOTGINT  \ offset: 0x04 : OTG interrupt register
$58040008 constant OTG1_S_OTG_GAHBCFG  \ offset: 0x08 : OTG AHB configuration register
$5804000c constant OTG1_S_OTG_GUSBCFG  \ offset: 0x0C : OTG USB configuration register
$58040010 constant OTG1_S_OTG_GRSTCTL  \ offset: 0x10 : OTG reset register
$58040014 constant OTG1_S_OTG_GINTSTS  \ offset: 0x14 : OTG core interrupt register [alternate]
$58040014 constant OTG1_S_OTG_GINTSTS_ALTERNATE  \ offset: 0x14 : OTG core interrupt register [alternate]
$58040018 constant OTG1_S_OTG_GINTMSK  \ offset: 0x18 : OTG interrupt mask register [alternate]
$58040018 constant OTG1_S_OTG_GINTMSK_ALTERNATE  \ offset: 0x18 : OTG interrupt mask register [alternate]
$5804001c constant OTG1_S_OTG_GRXSTSR  \ offset: 0x1C : OTG receive status debug read register [alternate]
$5804001c constant OTG1_S_OTG_GRXSTSR_ALTERNATE  \ offset: 0x1C : OTG receive status debug read register [alternate]
$58040020 constant OTG1_S_OTG_GRXSTSP  \ offset: 0x20 : OTG status read and pop registers
$58040020 constant OTG1_S_OTG_GRXSTSP_ALTERNATE  \ offset: 0x20 : OTG status read and pop registers
$58040024 constant OTG1_S_OTG_GRXFSIZ  \ offset: 0x24 : OTG receive FIFO size register
$58040028 constant OTG1_S_OTG_HNPTXFSIZ  \ offset: 0x28 : OTG host non-periodic transmit FIFO size register [alternate]
$58040028 constant OTG1_S_OTG_HNPTXFSIZ_ALTERNATE  \ offset: 0x28 : OTG host non-periodic transmit FIFO size register [alternate]
$5804002c constant OTG1_S_OTG_HNPTXSTS  \ offset: 0x2C : OTG non-periodic transmit FIFO/queue status register
$58040038 constant OTG1_S_OTG_GCCFG  \ offset: 0x38 : OTG general core configuration register
$5804003c constant OTG1_S_OTG_CID  \ offset: 0x3C : OTG core ID register
$58040054 constant OTG1_S_OTG_GLPMCFG  \ offset: 0x54 : OTG core LPM configuration register
$58040100 constant OTG1_S_OTG_HPTXFSIZ  \ offset: 0x100 : OTG host periodic transmit FIFO size register
$58040104 constant OTG1_S_OTG_DIEPTXF1  \ offset: 0x104 : OTG device IN endpoint transmit FIFO 1 size register
$58040108 constant OTG1_S_OTG_DIEPTXF2  \ offset: 0x108 : OTG device IN endpoint transmit FIFO 2 size register
$5804010c constant OTG1_S_OTG_DIEPTXF3  \ offset: 0x10C : OTG device IN endpoint transmit FIFO 3 size register
$58040110 constant OTG1_S_OTG_DIEPTXF4  \ offset: 0x110 : OTG device IN endpoint transmit FIFO 4 size register
$58040114 constant OTG1_S_OTG_DIEPTXF5  \ offset: 0x114 : OTG device IN endpoint transmit FIFO 5 size register
$58040118 constant OTG1_S_OTG_DIEPTXF6  \ offset: 0x118 : OTG device IN endpoint transmit FIFO 6 size register
$5804011c constant OTG1_S_OTG_DIEPTXF7  \ offset: 0x11C : OTG device IN endpoint transmit FIFO 7 size register
$58040120 constant OTG1_S_OTG_DIEPTXF8  \ offset: 0x120 : OTG device IN endpoint transmit FIFO 8 size register
$58040400 constant OTG1_S_OTG_HCFG  \ offset: 0x400 : OTG host configuration register
$58040404 constant OTG1_S_OTG_HFIR  \ offset: 0x404 : OTG host frame interval register
$58040408 constant OTG1_S_OTG_HFNUM  \ offset: 0x408 : OTG host frame number/frame time remaining register
$58040410 constant OTG1_S_OTG_HPTXSTS  \ offset: 0x410 : OTG_Host periodic transmit FIFO/queue status register
$58040414 constant OTG1_S_OTG_HAINT  \ offset: 0x414 : OTG host all channels interrupt register
$58040418 constant OTG1_S_OTG_HAINTMSK  \ offset: 0x418 : OTG host all channels interrupt mask register
$58040440 constant OTG1_S_OTG_HPRT  \ offset: 0x440 : OTG host port control and status register
$58040500 constant OTG1_S_OTG_HCCHAR0  \ offset: 0x500 : OTG host channel 0 characteristics register
$58040504 constant OTG1_S_OTG_HCSPLT0  \ offset: 0x504 : OTG host channel 0 split control register
$58040508 constant OTG1_S_OTG_HCINT0  \ offset: 0x508 : OTG host channel 0 interrupt register
$5804050c constant OTG1_S_OTG_HCINTMSK0  \ offset: 0x50C : OTG host channel 0 interrupt mask register
$58040510 constant OTG1_S_OTG_HCTSIZ0  \ offset: 0x510 : OTG host channel 0 transfer size register
$58040514 constant OTG1_S_OTG_HCDMA0  \ offset: 0x514 : OTG host channel 0 DMA address register
$58040520 constant OTG1_S_OTG_HCCHAR1  \ offset: 0x520 : OTG host channel 1 characteristics register
$58040524 constant OTG1_S_OTG_HCSPLT1  \ offset: 0x524 : OTG host channel 1 split control register
$58040528 constant OTG1_S_OTG_HCINT1  \ offset: 0x528 : OTG host channel 1 interrupt register
$5804052c constant OTG1_S_OTG_HCINTMSK1  \ offset: 0x52C : OTG host channel 1 interrupt mask register
$58040530 constant OTG1_S_OTG_HCTSIZ1  \ offset: 0x530 : OTG host channel 1 transfer size register
$58040534 constant OTG1_S_OTG_HCDMA1  \ offset: 0x534 : OTG host channel 1 DMA address register
$58040540 constant OTG1_S_OTG_HCCHAR2  \ offset: 0x540 : OTG host channel 2 characteristics register
$58040544 constant OTG1_S_OTG_HCSPLT2  \ offset: 0x544 : OTG host channel 2 split control register
$58040548 constant OTG1_S_OTG_HCINT2  \ offset: 0x548 : OTG host channel 2 interrupt register
$5804054c constant OTG1_S_OTG_HCINTMSK2  \ offset: 0x54C : OTG host channel 2 interrupt mask register
$58040550 constant OTG1_S_OTG_HCTSIZ2  \ offset: 0x550 : OTG host channel 2 transfer size register
$58040554 constant OTG1_S_OTG_HCDMA2  \ offset: 0x554 : OTG host channel 2 DMA address register
$58040560 constant OTG1_S_OTG_HCCHAR3  \ offset: 0x560 : OTG host channel 3 characteristics register
$58040564 constant OTG1_S_OTG_HCSPLT3  \ offset: 0x564 : OTG host channel 3 split control register
$58040568 constant OTG1_S_OTG_HCINT3  \ offset: 0x568 : OTG host channel 3 interrupt register
$5804056c constant OTG1_S_OTG_HCINTMSK3  \ offset: 0x56C : OTG host channel 3 interrupt mask register
$58040570 constant OTG1_S_OTG_HCTSIZ3  \ offset: 0x570 : OTG host channel 3 transfer size register
$58040574 constant OTG1_S_OTG_HCDMA3  \ offset: 0x574 : OTG host channel 3 DMA address register
$58040580 constant OTG1_S_OTG_HCCHAR4  \ offset: 0x580 : OTG host channel 4 characteristics register
$58040584 constant OTG1_S_OTG_HCSPLT4  \ offset: 0x584 : OTG host channel 4 split control register
$58040588 constant OTG1_S_OTG_HCINT4  \ offset: 0x588 : OTG host channel 4 interrupt register
$5804058c constant OTG1_S_OTG_HCINTMSK4  \ offset: 0x58C : OTG host channel 4 interrupt mask register
$58040590 constant OTG1_S_OTG_HCTSIZ4  \ offset: 0x590 : OTG host channel 4 transfer size register
$58040594 constant OTG1_S_OTG_HCDMA4  \ offset: 0x594 : OTG host channel 4 DMA address register
$580405a0 constant OTG1_S_OTG_HCCHAR5  \ offset: 0x5A0 : OTG host channel 5 characteristics register
$580405a4 constant OTG1_S_OTG_HCSPLT5  \ offset: 0x5A4 : OTG host channel 5 split control register
$580405a8 constant OTG1_S_OTG_HCINT5  \ offset: 0x5A8 : OTG host channel 5 interrupt register
$580405ac constant OTG1_S_OTG_HCINTMSK5  \ offset: 0x5AC : OTG host channel 5 interrupt mask register
$580405b0 constant OTG1_S_OTG_HCTSIZ5  \ offset: 0x5B0 : OTG host channel 5 transfer size register
$580405b4 constant OTG1_S_OTG_HCDMA5  \ offset: 0x5B4 : OTG host channel 5 DMA address register
$580405c0 constant OTG1_S_OTG_HCCHAR6  \ offset: 0x5C0 : OTG host channel 6 characteristics register
$580405c4 constant OTG1_S_OTG_HCSPLT6  \ offset: 0x5C4 : OTG host channel 6 split control register
$580405c8 constant OTG1_S_OTG_HCINT6  \ offset: 0x5C8 : OTG host channel 6 interrupt register
$580405cc constant OTG1_S_OTG_HCINTMSK6  \ offset: 0x5CC : OTG host channel 6 interrupt mask register
$580405d0 constant OTG1_S_OTG_HCTSIZ6  \ offset: 0x5D0 : OTG host channel 6 transfer size register
$580405d4 constant OTG1_S_OTG_HCDMA6  \ offset: 0x5D4 : OTG host channel 6 DMA address register
$580405e0 constant OTG1_S_OTG_HCCHAR7  \ offset: 0x5E0 : OTG host channel 7 characteristics register
$580405e4 constant OTG1_S_OTG_HCSPLT7  \ offset: 0x5E4 : OTG host channel 7 split control register
$580405e8 constant OTG1_S_OTG_HCINT7  \ offset: 0x5E8 : OTG host channel 7 interrupt register
$580405ec constant OTG1_S_OTG_HCINTMSK7  \ offset: 0x5EC : OTG host channel 7 interrupt mask register
$580405f0 constant OTG1_S_OTG_HCTSIZ7  \ offset: 0x5F0 : OTG host channel 7 transfer size register
$580405f4 constant OTG1_S_OTG_HCDMA7  \ offset: 0x5F4 : OTG host channel 7 DMA address register
$58040600 constant OTG1_S_OTG_HCCHAR8  \ offset: 0x600 : OTG host channel 8 characteristics register
$58040604 constant OTG1_S_OTG_HCSPLT8  \ offset: 0x604 : OTG host channel 8 split control register
$58040608 constant OTG1_S_OTG_HCINT8  \ offset: 0x608 : OTG host channel 8 interrupt register
$5804060c constant OTG1_S_OTG_HCINTMSK8  \ offset: 0x60C : OTG host channel 8 interrupt mask register
$58040610 constant OTG1_S_OTG_HCTSIZ8  \ offset: 0x610 : OTG host channel 8 transfer size register
$58040614 constant OTG1_S_OTG_HCDMA8  \ offset: 0x614 : OTG host channel 8 DMA address register
$58040620 constant OTG1_S_OTG_HCCHAR9  \ offset: 0x620 : OTG host channel 9 characteristics register
$58040624 constant OTG1_S_OTG_HCSPLT9  \ offset: 0x624 : OTG host channel 9 split control register
$58040628 constant OTG1_S_OTG_HCINT9  \ offset: 0x628 : OTG host channel 9 interrupt register
$5804062c constant OTG1_S_OTG_HCINTMSK9  \ offset: 0x62C : OTG host channel 9 interrupt mask register
$58040630 constant OTG1_S_OTG_HCTSIZ9  \ offset: 0x630 : OTG host channel 9 transfer size register
$58040634 constant OTG1_S_OTG_HCDMA9  \ offset: 0x634 : OTG host channel 9 DMA address register
$58040640 constant OTG1_S_OTG_HCCHAR10  \ offset: 0x640 : OTG host channel 10 characteristics register
$58040644 constant OTG1_S_OTG_HCSPLT10  \ offset: 0x644 : OTG host channel 10 split control register
$58040648 constant OTG1_S_OTG_HCINT10  \ offset: 0x648 : OTG host channel 10 interrupt register
$5804064c constant OTG1_S_OTG_HCINTMSK10  \ offset: 0x64C : OTG host channel 10 interrupt mask register
$58040650 constant OTG1_S_OTG_HCTSIZ10  \ offset: 0x650 : OTG host channel 10 transfer size register
$58040654 constant OTG1_S_OTG_HCDMA10  \ offset: 0x654 : OTG host channel 10 DMA address register
$58040660 constant OTG1_S_OTG_HCCHAR11  \ offset: 0x660 : OTG host channel 11 characteristics register
$58040664 constant OTG1_S_OTG_HCSPLT11  \ offset: 0x664 : OTG host channel 11 split control register
$58040668 constant OTG1_S_OTG_HCINT11  \ offset: 0x668 : OTG host channel 11 interrupt register
$5804066c constant OTG1_S_OTG_HCINTMSK11  \ offset: 0x66C : OTG host channel 11 interrupt mask register
$58040670 constant OTG1_S_OTG_HCTSIZ11  \ offset: 0x670 : OTG host channel 11 transfer size register
$58040674 constant OTG1_S_OTG_HCDMA11  \ offset: 0x674 : OTG host channel 11 DMA address register
$58040680 constant OTG1_S_OTG_HCCHAR12  \ offset: 0x680 : OTG host channel 12 characteristics register
$58040684 constant OTG1_S_OTG_HCSPLT12  \ offset: 0x684 : OTG host channel 12 split control register
$58040688 constant OTG1_S_OTG_HCINT12  \ offset: 0x688 : OTG host channel 12 interrupt register
$5804068c constant OTG1_S_OTG_HCINTMSK12  \ offset: 0x68C : OTG host channel 12 interrupt mask register
$58040690 constant OTG1_S_OTG_HCTSIZ12  \ offset: 0x690 : OTG host channel 12 transfer size register
$58040694 constant OTG1_S_OTG_HCDMA12  \ offset: 0x694 : OTG host channel 12 DMA address register
$580406a0 constant OTG1_S_OTG_HCCHAR13  \ offset: 0x6A0 : OTG host channel 13 characteristics register
$580406a4 constant OTG1_S_OTG_HCSPLT13  \ offset: 0x6A4 : OTG host channel 13 split control register
$580406a8 constant OTG1_S_OTG_HCINT13  \ offset: 0x6A8 : OTG host channel 13 interrupt register
$580406ac constant OTG1_S_OTG_HCINTMSK13  \ offset: 0x6AC : OTG host channel 13 interrupt mask register
$580406b0 constant OTG1_S_OTG_HCTSIZ13  \ offset: 0x6B0 : OTG host channel 13 transfer size register
$580406b4 constant OTG1_S_OTG_HCDMA13  \ offset: 0x6B4 : OTG host channel 13 DMA address register
$580406c0 constant OTG1_S_OTG_HCCHAR14  \ offset: 0x6C0 : OTG host channel 14 characteristics register
$580406c4 constant OTG1_S_OTG_HCSPLT14  \ offset: 0x6C4 : OTG host channel 14 split control register
$580406c8 constant OTG1_S_OTG_HCINT14  \ offset: 0x6C8 : OTG host channel 14 interrupt register
$580406cc constant OTG1_S_OTG_HCINTMSK14  \ offset: 0x6CC : OTG host channel 14 interrupt mask register
$580406d0 constant OTG1_S_OTG_HCTSIZ14  \ offset: 0x6D0 : OTG host channel 14 transfer size register
$580406d4 constant OTG1_S_OTG_HCDMA14  \ offset: 0x6D4 : OTG host channel 14 DMA address register
$580406e0 constant OTG1_S_OTG_HCCHAR15  \ offset: 0x6E0 : OTG host channel 15 characteristics register
$580406e4 constant OTG1_S_OTG_HCSPLT15  \ offset: 0x6E4 : OTG host channel 15 split control register
$580406e8 constant OTG1_S_OTG_HCINT15  \ offset: 0x6E8 : OTG host channel 15 interrupt register
$580406ec constant OTG1_S_OTG_HCINTMSK15  \ offset: 0x6EC : OTG host channel 15 interrupt mask register
$580406f0 constant OTG1_S_OTG_HCTSIZ15  \ offset: 0x6F0 : OTG host channel 15 transfer size register
$580406f4 constant OTG1_S_OTG_HCDMA15  \ offset: 0x6F4 : OTG host channel 15 DMA address register
$58040800 constant OTG1_S_OTG_DCFG  \ offset: 0x800 : OTG device configuration register
$58040804 constant OTG1_S_OTG_DCTL  \ offset: 0x804 : OTG device control register
$58040808 constant OTG1_S_OTG_DSTS  \ offset: 0x808 : OTG device status register
$58040810 constant OTG1_S_OTG_DIEPMSK  \ offset: 0x810 : OTG device IN endpoint common interrupt mask register
$58040814 constant OTG1_S_OTG_DOEPMSK  \ offset: 0x814 : OTG device OUT endpoint common interrupt mask register
$58040818 constant OTG1_S_OTG_DAINT  \ offset: 0x818 : OTG device all endpoints interrupt register
$5804081c constant OTG1_S_OTG_DAINTMSK  \ offset: 0x81C : OTG all endpoints interrupt mask register
$58040830 constant OTG1_S_OTG_DTHRCTL  \ offset: 0x830 : OTG device threshold control register
$58040834 constant OTG1_S_OTG_DIEPEMPMSK  \ offset: 0x834 : OTG device IN endpoint FIFO empty interrupt mask register
$58040900 constant OTG1_S_OTG_DIEPCTL0  \ offset: 0x900 : OTG device IN endpoint 0 control register [alternate]
$58040900 constant OTG1_S_OTG_DIEPCTL0_ALTERNATE  \ offset: 0x900 : OTG device IN endpoint 0 control register [alternate]
$58040908 constant OTG1_S_OTG_DIEPINT0  \ offset: 0x908 : OTG device IN endpoint 0 interrupt register
$58040910 constant OTG1_S_OTG_DIEPTSIZ0  \ offset: 0x910 : OTG device IN endpoint 0 transfer size register
$58040914 constant OTG1_S_OTG_DIEPDMA0  \ offset: 0x914 : OTG device IN endpoint 0 DMA address register
$58040918 constant OTG1_S_OTG_DTXFSTS0  \ offset: 0x918 : OTG device IN endpoint transmit FIFO status register
$58040920 constant OTG1_S_OTG_DIEPCTL1  \ offset: 0x920 : OTG device IN endpoint 1 control register [alternate]
$58040920 constant OTG1_S_OTG_DIEPCTL1_ALTERNATE  \ offset: 0x920 : OTG device IN endpoint 1 control register [alternate]
$58040928 constant OTG1_S_OTG_DIEPINT1  \ offset: 0x928 : OTG device IN endpoint 1 interrupt register
$58040930 constant OTG1_S_OTG_DIEPTSIZ1  \ offset: 0x930 : OTG device IN endpoint 1 transfer size register
$58040934 constant OTG1_S_OTG_DIEPDMA1  \ offset: 0x934 : OTG device IN endpoint 1 DMA address register
$58040938 constant OTG1_S_OTG_DTXFSTS1  \ offset: 0x938 : OTG device IN endpoint transmit FIFO status register
$58040940 constant OTG1_S_OTG_DIEPCTL2  \ offset: 0x940 : OTG device IN endpoint 2 control register [alternate]
$58040940 constant OTG1_S_OTG_DIEPCTL2_ALTERNATE  \ offset: 0x940 : OTG device IN endpoint 2 control register [alternate]
$58040948 constant OTG1_S_OTG_DIEPINT2  \ offset: 0x948 : OTG device IN endpoint 2 interrupt register
$58040950 constant OTG1_S_OTG_DIEPTSIZ2  \ offset: 0x950 : OTG device IN endpoint 2 transfer size register
$58040954 constant OTG1_S_OTG_DIEPDMA2  \ offset: 0x954 : OTG device IN endpoint 2 DMA address register
$58040958 constant OTG1_S_OTG_DTXFSTS2  \ offset: 0x958 : OTG device IN endpoint transmit FIFO status register
$58040960 constant OTG1_S_OTG_DIEPCTL3  \ offset: 0x960 : OTG device IN endpoint 3 control register [alternate]
$58040960 constant OTG1_S_OTG_DIEPCTL3_ALTERNATE  \ offset: 0x960 : OTG device IN endpoint 3 control register [alternate]
$58040968 constant OTG1_S_OTG_DIEPINT3  \ offset: 0x968 : OTG device IN endpoint 3 interrupt register
$58040970 constant OTG1_S_OTG_DIEPTSIZ3  \ offset: 0x970 : OTG device IN endpoint 3 transfer size register
$58040974 constant OTG1_S_OTG_DIEPDMA3  \ offset: 0x974 : OTG device IN endpoint 3 DMA address register
$58040978 constant OTG1_S_OTG_DTXFSTS3  \ offset: 0x978 : OTG device IN endpoint transmit FIFO status register
$58040980 constant OTG1_S_OTG_DIEPCTL4  \ offset: 0x980 : OTG device IN endpoint 4 control register [alternate]
$58040980 constant OTG1_S_OTG_DIEPCTL4_ALTERNATE  \ offset: 0x980 : OTG device IN endpoint 4 control register [alternate]
$58040988 constant OTG1_S_OTG_DIEPINT4  \ offset: 0x988 : OTG device IN endpoint 4 interrupt register
$58040990 constant OTG1_S_OTG_DIEPTSIZ4  \ offset: 0x990 : OTG device IN endpoint 4 transfer size register
$58040994 constant OTG1_S_OTG_DIEPDMA4  \ offset: 0x994 : OTG device IN endpoint 4 DMA address register
$58040998 constant OTG1_S_OTG_DTXFSTS4  \ offset: 0x998 : OTG device IN endpoint transmit FIFO status register
$580409a0 constant OTG1_S_OTG_DIEPCTL5  \ offset: 0x9A0 : OTG device IN endpoint 5 control register [alternate]
$580409a0 constant OTG1_S_OTG_DIEPCTL5_ALTERNATE  \ offset: 0x9A0 : OTG device IN endpoint 5 control register [alternate]
$580409a8 constant OTG1_S_OTG_DIEPINT5  \ offset: 0x9A8 : OTG device IN endpoint 5 interrupt register
$580409b0 constant OTG1_S_OTG_DIEPTSIZ5  \ offset: 0x9B0 : OTG device IN endpoint 5 transfer size register
$580409b4 constant OTG1_S_OTG_DIEPDMA5  \ offset: 0x9B4 : OTG device IN endpoint 5 DMA address register
$580409b8 constant OTG1_S_OTG_DTXFSTS5  \ offset: 0x9B8 : OTG device IN endpoint transmit FIFO status register
$580409c0 constant OTG1_S_OTG_DIEPCTL6  \ offset: 0x9C0 : OTG device IN endpoint 6 control register [alternate]
$580409c0 constant OTG1_S_OTG_DIEPCTL6_ALTERNATE  \ offset: 0x9C0 : OTG device IN endpoint 6 control register [alternate]
$580409c8 constant OTG1_S_OTG_DIEPINT6  \ offset: 0x9C8 : OTG device IN endpoint 6 interrupt register
$580409d0 constant OTG1_S_OTG_DIEPTSIZ6  \ offset: 0x9D0 : OTG device IN endpoint 6 transfer size register
$580409d4 constant OTG1_S_OTG_DIEPDMA6  \ offset: 0x9D4 : OTG device IN endpoint 6 DMA address register
$580409d8 constant OTG1_S_OTG_DTXFSTS6  \ offset: 0x9D8 : OTG device IN endpoint transmit FIFO status register
$580409e0 constant OTG1_S_OTG_DIEPCTL7  \ offset: 0x9E0 : OTG device IN endpoint 7 control register [alternate]
$580409e0 constant OTG1_S_OTG_DIEPCTL7_ALTERNATE  \ offset: 0x9E0 : OTG device IN endpoint 7 control register [alternate]
$580409e8 constant OTG1_S_OTG_DIEPINT7  \ offset: 0x9E8 : OTG device IN endpoint 7 interrupt register
$580409f0 constant OTG1_S_OTG_DIEPTSIZ7  \ offset: 0x9F0 : OTG device IN endpoint 7 transfer size register
$580409f4 constant OTG1_S_OTG_DIEPDMA7  \ offset: 0x9F4 : OTG device IN endpoint 7 DMA address register
$580409f8 constant OTG1_S_OTG_DTXFSTS7  \ offset: 0x9F8 : OTG device IN endpoint transmit FIFO status register
$58040a00 constant OTG1_S_OTG_DIEPCTL8  \ offset: 0xA00 : OTG device IN endpoint 8 control register [alternate]
$58040a00 constant OTG1_S_OTG_DIEPCTL8_ALTERNATE  \ offset: 0xA00 : OTG device IN endpoint 8 control register [alternate]
$58040a08 constant OTG1_S_OTG_DIEPINT8  \ offset: 0xA08 : OTG device IN endpoint 8 interrupt register
$58040a10 constant OTG1_S_OTG_DIEPTSIZ8  \ offset: 0xA10 : OTG device IN endpoint 8 transfer size register
$58040a14 constant OTG1_S_OTG_DIEPDMA8  \ offset: 0xA14 : OTG device IN endpoint 8 DMA address register
$58040a18 constant OTG1_S_OTG_DTXFSTS8  \ offset: 0xA18 : OTG device IN endpoint transmit FIFO status register
$58040b00 constant OTG1_S_OTG_DOEPCTL0  \ offset: 0xB00 : OTG device control OUT endpoint 0 control register
$58040b08 constant OTG1_S_OTG_DOEPINT0  \ offset: 0xB08 : OTG device OUT endpoint 0 interrupt register
$58040b10 constant OTG1_S_OTG_DOEPTSIZ0  \ offset: 0xB10 : OTG device OUT endpoint 0 transfer size register
$58040b14 constant OTG1_S_OTG_DOEPDMA0  \ offset: 0xB14 : OTG device OUT endpoint 0 DMA address register
$58040b20 constant OTG1_S_OTG_DOEPCTL1  \ offset: 0xB20 : OTG device OUT endpoint 1 control register [alternate]
$58040b20 constant OTG1_S_OTG_DOEPCTL1_ALTERNATE  \ offset: 0xB20 : OTG device OUT endpoint 1 control register [alternate]
$58040b28 constant OTG1_S_OTG_DOEPINT1  \ offset: 0xB28 : OTG device OUT endpoint 1 interrupt register
$58040b30 constant OTG1_S_OTG_DOEPTSIZ1  \ offset: 0xB30 : OTG device OUT endpoint 1 transfer size register
$58040b34 constant OTG1_S_OTG_DOEPDMA1  \ offset: 0xB34 : OTG device OUT endpoint 1 DMA address register
$58040b40 constant OTG1_S_OTG_DOEPCTL2  \ offset: 0xB40 : OTG device OUT endpoint 2 control register [alternate]
$58040b40 constant OTG1_S_OTG_DOEPCTL2_ALTERNATE  \ offset: 0xB40 : OTG device OUT endpoint 2 control register [alternate]
$58040b48 constant OTG1_S_OTG_DOEPINT2  \ offset: 0xB48 : OTG device OUT endpoint 2 interrupt register
$58040b50 constant OTG1_S_OTG_DOEPTSIZ2  \ offset: 0xB50 : OTG device OUT endpoint 2 transfer size register
$58040b54 constant OTG1_S_OTG_DOEPDMA2  \ offset: 0xB54 : OTG device OUT endpoint 2 DMA address register
$58040b60 constant OTG1_S_OTG_DOEPCTL3  \ offset: 0xB60 : OTG device OUT endpoint 3 control register [alternate]
$58040b60 constant OTG1_S_OTG_DOEPCTL3_ALTERNATE  \ offset: 0xB60 : OTG device OUT endpoint 3 control register [alternate]
$58040b68 constant OTG1_S_OTG_DOEPINT3  \ offset: 0xB68 : OTG device OUT endpoint 3 interrupt register
$58040b70 constant OTG1_S_OTG_DOEPTSIZ3  \ offset: 0xB70 : OTG device OUT endpoint 3 transfer size register
$58040b74 constant OTG1_S_OTG_DOEPDMA3  \ offset: 0xB74 : OTG device OUT endpoint 3 DMA address register
$58040b80 constant OTG1_S_OTG_DOEPCTL4  \ offset: 0xB80 : OTG device OUT endpoint 4 control register [alternate]
$58040b80 constant OTG1_S_OTG_DOEPCTL4_ALTERNATE  \ offset: 0xB80 : OTG device OUT endpoint 4 control register [alternate]
$58040b88 constant OTG1_S_OTG_DOEPINT4  \ offset: 0xB88 : OTG device OUT endpoint 4 interrupt register
$58040b90 constant OTG1_S_OTG_DOEPTSIZ4  \ offset: 0xB90 : OTG device OUT endpoint 4 transfer size register
$58040b94 constant OTG1_S_OTG_DOEPDMA4  \ offset: 0xB94 : OTG device OUT endpoint 4 DMA address register
$58040ba0 constant OTG1_S_OTG_DOEPCTL5  \ offset: 0xBA0 : OTG device OUT endpoint 5 control register [alternate]
$58040ba0 constant OTG1_S_OTG_DOEPCTL5_ALTERNATE  \ offset: 0xBA0 : OTG device OUT endpoint 5 control register [alternate]
$58040ba8 constant OTG1_S_OTG_DOEPINT5  \ offset: 0xBA8 : OTG device OUT endpoint 5 interrupt register
$58040bb0 constant OTG1_S_OTG_DOEPTSIZ5  \ offset: 0xBB0 : OTG device OUT endpoint 5 transfer size register
$58040bb4 constant OTG1_S_OTG_DOEPDMA5  \ offset: 0xBB4 : OTG device OUT endpoint 5 DMA address register
$58040bc0 constant OTG1_S_OTG_DOEPCTL6  \ offset: 0xBC0 : OTG device OUT endpoint 6 control register [alternate]
$58040bc0 constant OTG1_S_OTG_DOEPCTL6_ALTERNATE  \ offset: 0xBC0 : OTG device OUT endpoint 6 control register [alternate]
$58040bc8 constant OTG1_S_OTG_DOEPINT6  \ offset: 0xBC8 : OTG device OUT endpoint 6 interrupt register
$58040bd0 constant OTG1_S_OTG_DOEPTSIZ6  \ offset: 0xBD0 : OTG device OUT endpoint 6 transfer size register
$58040bd4 constant OTG1_S_OTG_DOEPDMA6  \ offset: 0xBD4 : OTG device OUT endpoint 6 DMA address register
$58040be0 constant OTG1_S_OTG_DOEPCTL7  \ offset: 0xBE0 : OTG device OUT endpoint 7 control register [alternate]
$58040be0 constant OTG1_S_OTG_DOEPCTL7_ALTERNATE  \ offset: 0xBE0 : OTG device OUT endpoint 7 control register [alternate]
$58040be8 constant OTG1_S_OTG_DOEPINT7  \ offset: 0xBE8 : OTG device OUT endpoint 7 interrupt register
$58040bf0 constant OTG1_S_OTG_DOEPTSIZ7  \ offset: 0xBF0 : OTG device OUT endpoint 7 transfer size register
$58040bf4 constant OTG1_S_OTG_DOEPDMA7  \ offset: 0xBF4 : OTG device OUT endpoint 7 DMA address register
$58040c00 constant OTG1_S_OTG_DOEPCTL8  \ offset: 0xC00 : OTG device OUT endpoint 8 control register [alternate]
$58040c00 constant OTG1_S_OTG_DOEPCTL8_ALTERNATE  \ offset: 0xC00 : OTG device OUT endpoint 8 control register [alternate]
$58040c08 constant OTG1_S_OTG_DOEPINT8  \ offset: 0xC08 : OTG device OUT endpoint 8 interrupt register
$58040c10 constant OTG1_S_OTG_DOEPTSIZ8  \ offset: 0xC10 : OTG device OUT endpoint 8 transfer size register
$58040c14 constant OTG1_S_OTG_DOEPDMA8  \ offset: 0xC14 : OTG device OUT endpoint 8 DMA address register
$58040e00 constant OTG1_S_OTG_PCGCCTL  \ offset: 0xE00 : OTG power and clock gating control register
$58040e04 constant OTG1_S_OTG_PCGCCTL1  \ offset: 0xE04 : OTG power and clock gating control register 1

