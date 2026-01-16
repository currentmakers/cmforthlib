\
\ @file otg1_hs_global.fs
\ @brief USB 1 on the go high speed
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief OTG_HS control and status register
\ Address offset: 0x00
\ Reset value: 0x00000800
\

$00000001 constant OTG1_HS_GLOBAL_OTG_HS_GOTGCTL_SRQSCS             \ Session request success The core sets this bit when a session request initiation is successful. Note: Only accessible in device mode.
$00000002 constant OTG1_HS_GLOBAL_OTG_HS_GOTGCTL_SRQ                \ Session request The application sets this bit to initiate a session request on the USB. The application can clear this bit by writing a 0 when the host negotiation success status change bit in the OTG_GOTGINT register (HNSSCHG bit in OTG_GOTGINT) is set. The core clears this bit when the HNSSCHG bit is cleared. If the user uses the USB 1.1 full-speed serial transceiver interface to initiate the session request, the application must wait until VBUS discharges to 0.2 V, after the B-session valid bit in this register (BSVLD bit in OTG_GOTGCTL) is cleared. Note: Only accessible in device mode.
$00000004 constant OTG1_HS_GLOBAL_OTG_HS_GOTGCTL_VBVALOEN           \ VBUS valid override enable. This bit is used to enable/disable the software to override the vbusvalid signal using the VBVALOVAL bit. Note: Only accessible in host mode.
$00000008 constant OTG1_HS_GLOBAL_OTG_HS_GOTGCTL_VBVALOVAL          \ VBUS valid override value. This bit is used to set override value for vbusvalid signal when VBVALOEN bit is set. Note: Only accessible in host mode.
$00000010 constant OTG1_HS_GLOBAL_OTG_HS_GOTGCTL_AVALOEN            \ A-peripheral session valid override enable. This bit is used to enable/disable the software to override the Avalid signal using the AVALOVAL bit. Note: Only accessible in host mode.
$00000020 constant OTG1_HS_GLOBAL_OTG_HS_GOTGCTL_AVALOVAL           \ A-peripheral session valid override value. This bit is used to set override value for Avalid signal when AVALOEN bit is set. Note: Only accessible in host mode.
$00000040 constant OTG1_HS_GLOBAL_OTG_HS_GOTGCTL_BVALOEN            \ B-peripheral session valid override enable. This bit is used to enable/disable the software to override the Bvalid signal using the BVALOVAL bit. Note: Only accessible in device mode.
$00000080 constant OTG1_HS_GLOBAL_OTG_HS_GOTGCTL_BVALOVAL           \ B-peripheral session valid override value. This bit is used to set override value for Bvalid signal when BVALOEN bit is set. Note: Only accessible in device mode.
$00000100 constant OTG1_HS_GLOBAL_OTG_HS_GOTGCTL_HNGSCS             \ Host negotiation success The core sets this bit when host negotiation is successful. The core clears this bit when the HNP request (HNPRQ) bit in this register is set. Note: Only accessible in device mode.
$00000200 constant OTG1_HS_GLOBAL_OTG_HS_GOTGCTL_HNPRQ              \ HNP request The application sets this bit to initiate an HNP request to the connected USB host. The application can clear this bit by writing a 0 when the host negotiation success status change bit in the OTG_GOTGINT register (HNSSCHG bit in OTG_GOTGINT) is set. The core clears this bit when the HNSSCHG bit is cleared. Note: Only accessible in device mode.
$00000400 constant OTG1_HS_GLOBAL_OTG_HS_GOTGCTL_HSHNPEN            \ host set HNP enable The application sets this bit when it has successfully enabled HNP (using the SetFeature.SetHNPEnable command) on the connected device. Note: Only accessible in host mode.
$00000800 constant OTG1_HS_GLOBAL_OTG_HS_GOTGCTL_DHNPEN             \ Device HNP enabled The application sets this bit when it successfully receives a SetFeature.SetHNPEnable command from the connected USB host. Note: Only accessible in device mode.
$00001000 constant OTG1_HS_GLOBAL_OTG_HS_GOTGCTL_EHEN               \ Embedded host enable It is used to select between OTG A device state machine and embedded host state machine.
$00010000 constant OTG1_HS_GLOBAL_OTG_HS_GOTGCTL_CIDSTS             \ Connector ID status Indicates the connector ID status on a connect event. Note: Accessible in both device and host modes.
$00020000 constant OTG1_HS_GLOBAL_OTG_HS_GOTGCTL_DBCT               \ Long/short debounce time Indicates the debounce time of a detected connection. Note: Only accessible in host mode.
$00040000 constant OTG1_HS_GLOBAL_OTG_HS_GOTGCTL_ASVLD              \ A-session valid Indicates the host mode transceiver status. Note: Only accessible in host mode.
$00080000 constant OTG1_HS_GLOBAL_OTG_HS_GOTGCTL_BSVLD              \ B-session valid Indicates the device mode transceiver status. In OTG mode, the user can use this bit to determine if the device is connected or disconnected. Note: Only accessible in device mode.
$00100000 constant OTG1_HS_GLOBAL_OTG_HS_GOTGCTL_OTGVER             \ OTG version Selects the OTG revision.
$00200000 constant OTG1_HS_GLOBAL_OTG_HS_GOTGCTL_CURMOD             \ Current mode of operation Indicates the current mode (host or device).


\
\ @brief OTG_HS interrupt register
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$00000004 constant OTG1_HS_GLOBAL_OTG_HS_GOTGINT_SEDET              \ Session end detected
$00000100 constant OTG1_HS_GLOBAL_OTG_HS_GOTGINT_SRSSCHG            \ Session request success status change
$00000200 constant OTG1_HS_GLOBAL_OTG_HS_GOTGINT_HNSSCHG            \ Host negotiation success status change
$00020000 constant OTG1_HS_GLOBAL_OTG_HS_GOTGINT_HNGDET             \ Host negotiation detected
$00040000 constant OTG1_HS_GLOBAL_OTG_HS_GOTGINT_ADTOCHG            \ A-device timeout change
$00080000 constant OTG1_HS_GLOBAL_OTG_HS_GOTGINT_DBCDNE             \ Debounce done


\
\ @brief OTG_HS AHB configuration register
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$00000001 constant OTG1_HS_GLOBAL_OTG_HS_GAHBCFG_GINTMSK            \ Global interrupt mask
$0000001e constant OTG1_HS_GLOBAL_OTG_HS_GAHBCFG_HBSTLEN            \ Burst length/type
$00000020 constant OTG1_HS_GLOBAL_OTG_HS_GAHBCFG_DMAEN              \ DMA enable
$00000080 constant OTG1_HS_GLOBAL_OTG_HS_GAHBCFG_TXFELVL            \ TxFIFO empty level
$00000100 constant OTG1_HS_GLOBAL_OTG_HS_GAHBCFG_PTXFELVL           \ Periodic TxFIFO empty level


\
\ @brief OTG_HS USB configuration register
\ Address offset: 0x0C
\ Reset value: 0x00000A00
\

$00000007 constant OTG1_HS_GLOBAL_OTG_HS_GUSBCFG_TOCAL              \ FS timeout calibration
$00000040 constant OTG1_HS_GLOBAL_OTG_HS_GUSBCFG_PHYSEL             \ USB 2.0 high-speed ULPI PHY or USB 1.1 full-speed serial transceiver select
$00000100 constant OTG1_HS_GLOBAL_OTG_HS_GUSBCFG_SRPCAP             \ SRP-capable
$00000200 constant OTG1_HS_GLOBAL_OTG_HS_GUSBCFG_HNPCAP             \ HNP-capable
$00003c00 constant OTG1_HS_GLOBAL_OTG_HS_GUSBCFG_TRDT               \ USB turnaround time
$00008000 constant OTG1_HS_GLOBAL_OTG_HS_GUSBCFG_PHYLPCS            \ PHY Low-power clock select
$00020000 constant OTG1_HS_GLOBAL_OTG_HS_GUSBCFG_ULPIFSLS           \ ULPI FS/LS select
$00040000 constant OTG1_HS_GLOBAL_OTG_HS_GUSBCFG_ULPIAR             \ ULPI Auto-resume
$00080000 constant OTG1_HS_GLOBAL_OTG_HS_GUSBCFG_ULPICSM            \ ULPI Clock SuspendM
$00100000 constant OTG1_HS_GLOBAL_OTG_HS_GUSBCFG_ULPIEVBUSD         \ ULPI External VBUS Drive
$00200000 constant OTG1_HS_GLOBAL_OTG_HS_GUSBCFG_ULPIEVBUSI         \ ULPI external VBUS indicator
$00400000 constant OTG1_HS_GLOBAL_OTG_HS_GUSBCFG_TSDPS              \ TermSel DLine pulsing selection
$00800000 constant OTG1_HS_GLOBAL_OTG_HS_GUSBCFG_PCCI               \ Indicator complement
$01000000 constant OTG1_HS_GLOBAL_OTG_HS_GUSBCFG_PTCI               \ Indicator pass through
$02000000 constant OTG1_HS_GLOBAL_OTG_HS_GUSBCFG_ULPIIPD            \ ULPI interface protect disable
$20000000 constant OTG1_HS_GLOBAL_OTG_HS_GUSBCFG_FHMOD              \ Forced host mode
$40000000 constant OTG1_HS_GLOBAL_OTG_HS_GUSBCFG_FDMOD              \ Forced peripheral mode


\
\ @brief OTG_HS reset register
\ Address offset: 0x10
\ Reset value: 0x20000000
\

$00000001 constant OTG1_HS_GLOBAL_OTG_HS_GRSTCTL_CSRST              \ Core soft reset
$00000002 constant OTG1_HS_GLOBAL_OTG_HS_GRSTCTL_HSRST              \ HCLK soft reset
$00000004 constant OTG1_HS_GLOBAL_OTG_HS_GRSTCTL_FCRST              \ Host frame counter reset
$00000010 constant OTG1_HS_GLOBAL_OTG_HS_GRSTCTL_RXFFLSH            \ RxFIFO flush
$00000020 constant OTG1_HS_GLOBAL_OTG_HS_GRSTCTL_TXFFLSH            \ TxFIFO flush
$000007c0 constant OTG1_HS_GLOBAL_OTG_HS_GRSTCTL_TXFNUM             \ TxFIFO number
$40000000 constant OTG1_HS_GLOBAL_OTG_HS_GRSTCTL_DMAREQ             \ DMA request signal enabled for USB OTG HS
$80000000 constant OTG1_HS_GLOBAL_OTG_HS_GRSTCTL_AHBIDL             \ AHB master idle


\
\ @brief OTG_HS core interrupt register
\ Address offset: 0x14
\ Reset value: 0x04000020
\

$00000001 constant OTG1_HS_GLOBAL_OTG_HS_GINTSTS_CMOD               \ Current mode of operation Indicates the current mode. Note: Accessible in both host and device modes.
$00000002 constant OTG1_HS_GLOBAL_OTG_HS_GINTSTS_MMIS               \ Mode mismatch interrupt The core sets this bit when the application is trying to access: A host mode register, when the core is operating in device mode A device mode register, when the core is operating in host mode The register access is completed on the AHB with an OKAY response, but is ignored by the core internally and does not affect the operation of the core. Note: Accessible in both host and device modes.
$00000004 constant OTG1_HS_GLOBAL_OTG_HS_GINTSTS_OTGINT             \ OTG interrupt The core sets this bit to indicate an OTG protocol event. The application must read the OTG interrupt status (OTG_GOTGINT) register to determine the exact event that caused this interrupt. The application must clear the appropriate status bit in the OTG_GOTGINT register to clear this bit. Note: Accessible in both host and device modes.
$00000008 constant OTG1_HS_GLOBAL_OTG_HS_GINTSTS_SOF                \ Start of frame In host mode, the core sets this bit to indicate that an SOF (FS), or Keep-Alive (LS) is transmitted on the USB. The application must write a 1 to this bit to clear the interrupt. In device mode, in the core sets this bit to indicate that an SOF token has been received on the USB. The application can read the OTG_DSTS register to get the current frame number. This interrupt is seen only when the core is operating in FS. Note: This register may return '1' if read immediately after power on reset. If the register bit reads '1' immediately after power on reset it does not indicate that an SOF has been sent (in case of host mode) or SOF has been received (in case of device mode). The read value of this interrupt is valid only after a valid connection between host and device is established. If the bit is set after power on reset the application can clear the bit. Note: Accessible in both host and device modes.
$00000010 constant OTG1_HS_GLOBAL_OTG_HS_GINTSTS_RXFLVL             \ Rx FIFO non-empty Indicates that there is at least one packet pending to be read from the Rx FIFO. Note: Accessible in both host and device modes.
$00000020 constant OTG1_HS_GLOBAL_OTG_HS_GINTSTS_NPTXFE             \ Non-periodic Tx FIFO empty This interrupt is asserted when the non-periodic Tx FIFO is either half or completely empty, and there is space for at least one entry to be written to the non-periodic transmit request queue. The half or completely empty status is determined by the non-periodic Tx FIFO empty level bit in the OTG_GAHBCFG register (TXFELVL bit in OTG_GAHBCFG). Note: Accessible in host mode only.
$00000040 constant OTG1_HS_GLOBAL_OTG_HS_GINTSTS_GINAKEFF           \ Global IN non-periodic NAK effective Indicates that the Set global non-periodic IN NAK bit in the OTG_DCTL register (SGINAK bit in OTG_DCTL), set by the application, has taken effect in the core. That is, the core has sampled the Global IN NAK bit set by the application. This bit can be cleared by clearing the Clear global non-periodic IN NAK bit in the OTG_DCTL register (CGINAK bit in OTG_DCTL). This interrupt does not necessarily mean that a NAK handshake is sent out on the USB. The STALL bit takes precedence over the NAK bit. Note: Only accessible in device mode.
$00000080 constant OTG1_HS_GLOBAL_OTG_HS_GINTSTS_GONAKEFF           \ Global OUT NAK effective Indicates that the Set global OUT NAK bit in the OTG_DCTL register (SGONAK bit in OTG_DCTL), set by the application, has taken effect in the core. This bit can be cleared by writing the Clear global OUT NAK bit in the OTG_DCTL register (CGONAK bit in OTG_DCTL). Note: Only accessible in device mode.
$00000400 constant OTG1_HS_GLOBAL_OTG_HS_GINTSTS_ESUSP              \ Early suspend The core sets this bit to indicate that an Idle state has been detected on the USB for 3 ms. Note: Only accessible in device mode.
$00000800 constant OTG1_HS_GLOBAL_OTG_HS_GINTSTS_USBSUSP            \ USB suspend The core sets this bit to indicate that a suspend was detected on the USB. The core enters the suspended state when there is no activity on the data lines for an extended period of time. Note: Only accessible in device mode.
$00001000 constant OTG1_HS_GLOBAL_OTG_HS_GINTSTS_USBRST             \ USB reset The core sets this bit to indicate that a reset is detected on the USB. Note: Only accessible in device mode.
$00002000 constant OTG1_HS_GLOBAL_OTG_HS_GINTSTS_ENUMDNE            \ Enumeration done The core sets this bit to indicate that speed enumeration is complete. The application must read the OTG_DSTS register to obtain the enumerated speed. Note: Only accessible in device mode.
$00004000 constant OTG1_HS_GLOBAL_OTG_HS_GINTSTS_ISOODRP            \ Isochronous OUT packet dropped interrupt The core sets this bit when it fails to write an isochronous OUT packet into the Rx FIFO because the Rx FIFO does not have enough space to accommodate a maximum size packet for the isochronous OUT endpoint. Note: Only accessible in device mode.
$00008000 constant OTG1_HS_GLOBAL_OTG_HS_GINTSTS_EOPF               \ End of periodic frame interrupt Indicates that the period specified in the periodic frame interval field of the OTG_DCFG register (PFIVL bit in OTG_DCFG) has been reached in the current frame. Note: Only accessible in device mode.
$00040000 constant OTG1_HS_GLOBAL_OTG_HS_GINTSTS_IEPINT             \ IN endpoint interrupt The core sets this bit to indicate that an interrupt is pending on one of the IN endpoints of the core (in device mode). The application must read the OTG_DAINT register to determine the exact number of the IN endpoint on which the interrupt occurred, and then read the corresponding OTG_DIEPINTx register to determine the exact cause of the interrupt. The application must clear the appropriate status bit in the corresponding OTG_DIEPINTx register to clear this bit. Note: Only accessible in device mode.
$00080000 constant OTG1_HS_GLOBAL_OTG_HS_GINTSTS_OEPINT             \ OUT endpoint interrupt The core sets this bit to indicate that an interrupt is pending on one of the OUT endpoints of the core (in device mode). The application must read the OTG_DAINT register to determine the exact number of the OUT endpoint on which the interrupt occurred, and then read the corresponding OTG_DOEPINTx register to determine the exact cause of the interrupt. The application must clear the appropriate status bit in the corresponding OTG_DOEPINTx register to clear this bit. Note: Only accessible in device mode.
$00100000 constant OTG1_HS_GLOBAL_OTG_HS_GINTSTS_IISOIXFR           \ Incomplete isochronous IN transfer The core sets this interrupt to indicate that there is at least one isochronous IN endpoint on which the transfer is not completed in the current frame. This interrupt is asserted along with the End of periodic frame interrupt (EOPF) bit in this register. Note: Only accessible in device mode.
$00200000 constant OTG1_HS_GLOBAL_OTG_HS_GINTSTS_IPXFR_INCOMPISOOUT
$00400000 constant OTG1_HS_GLOBAL_OTG_HS_GINTSTS_DATAFSUSP          \ Data fetch suspended This interrupt is valid only in DMA mode. This interrupt indicates that the core has stopped fetching data for IN endpoints due to the unavailability of TxFIFO space or request queue space. This interrupt is used by the application for an endpoint mismatch algorithm. For example, after detecting an endpoint mismatch, the application: Sets a global nonperiodic IN NAK handshake Disables IN endpoints Flushes the FIFO Determines the token sequence from the IN token sequence learning queue Re-enables the endpoints Clears the global nonperiodic IN NAK handshake If the global nonperiodic IN NAK is cleared, the core has not yet fetched data for the IN endpoint, and the IN token is received: the core generates an âIN token received when FIFO emptyâ interrupt. The OTG then sends a NAK response to the host. To avoid this scenario, the application can check the FetSusp interrupt in OTG_GINTSTS, which ensures that the FIFO is full before clearing a global NAK handshake. Alternatively, the application can mask the âIN token received when FIFO emptyâ interrupt when clearing a global IN NAK handshake.
$00800000 constant OTG1_HS_GLOBAL_OTG_HS_GINTSTS_RSTDET             \ Reset detected interrupt In device mode, this interrupt is asserted when a reset is detected on the USB in partial power-down mode when the device is in suspend. Note: Only accessible in device mode.
$01000000 constant OTG1_HS_GLOBAL_OTG_HS_GINTSTS_HPRTINT            \ Host port interrupt The core sets this bit to indicate a change in port status of one of the OTG_HS controller ports in host mode. The application must read the OTG_HPRT register to determine the exact event that caused this interrupt. The application must clear the appropriate status bit in the OTG_HPRT register to clear this bit. Note: Only accessible in host mode.
$02000000 constant OTG1_HS_GLOBAL_OTG_HS_GINTSTS_HCINT              \ Host channels interrupt The core sets this bit to indicate that an interrupt is pending on one of the channels of the core (in host mode). The application must read the OTG_HAINT register to determine the exact number of the channel on which the interrupt occurred, and then read the corresponding OTG_HCINTx register to determine the exact cause of the interrupt. The application must clear the appropriate status bit in the OTG_HCINTx register to clear this bit. Note: Only accessible in host mode.
$04000000 constant OTG1_HS_GLOBAL_OTG_HS_GINTSTS_PTXFE              \ Periodic Tx FIFO empty Asserted when the periodic transmit FIFO is either half or completely empty and there is space for at least one entry to be written in the periodic request queue. The half or completely empty status is determined by the periodic Tx FIFO empty level bit in the OTG_GAHBCFG register (PTXFELVL bit in OTG_GAHBCFG). Note: Only accessible in host mode.
$08000000 constant OTG1_HS_GLOBAL_OTG_HS_GINTSTS_LPMINT             \ LPM interrupt In device mode, this interrupt is asserted when the device receives an LPM transaction and responds with a non-ERRORed response. In host mode, this interrupt is asserted when the device responds to an LPM transaction with a non-ERRORed response or when the host core has completed LPM transactions for the programmed number of times (RETRYCNT bit in OTG_GLPMCFG). This field is valid only if the LPMEN bit in OTG_GLPMCFG is set to 1.
$10000000 constant OTG1_HS_GLOBAL_OTG_HS_GINTSTS_CIDSCHG            \ Connector ID status change The core sets this bit when there is a change in connector ID status. Note: Accessible in both device and host modes.
$20000000 constant OTG1_HS_GLOBAL_OTG_HS_GINTSTS_DISCINT            \ Disconnect detected interrupt Asserted when a device disconnect is detected. Note: Only accessible in host mode.
$40000000 constant OTG1_HS_GLOBAL_OTG_HS_GINTSTS_SRQINT             \ Session request/new session detected interrupt In host mode, this interrupt is asserted when a session request is detected from the device. In device mode, this interrupt is asserted when VBUS is in the valid range for a B-peripheral device. Accessible in both device and host modes.
$80000000 constant OTG1_HS_GLOBAL_OTG_HS_GINTSTS_WKUPINT            \ Resume/remote wakeup detected interrupt Wakeup interrupt during suspend(L2) or LPM(L1) state. During suspend(L2): In device mode, this interrupt is asserted when a resume is detected on the USB. In host mode, this interrupt is asserted when a remote wakeup is detected on the USB. During LPM(L1): This interrupt is asserted for either host initiated resume or device initiated remote wakeup on USB. Note: Accessible in both device and host modes.


\
\ @brief OTG_HS interrupt mask register
\ Address offset: 0x18
\ Reset value: 0x00000000
\

$00000002 constant OTG1_HS_GLOBAL_OTG_HS_GINTMSK_MMISM              \ Mode mismatch interrupt mask Note: Accessible in both device and host modes.
$00000004 constant OTG1_HS_GLOBAL_OTG_HS_GINTMSK_OTGINT             \ OTG interrupt mask Note: Accessible in both device and host modes.
$00000008 constant OTG1_HS_GLOBAL_OTG_HS_GINTMSK_SOFM               \ Start of frame mask Note: Accessible in both device and host modes.
$00000010 constant OTG1_HS_GLOBAL_OTG_HS_GINTMSK_RXFLVLM            \ Receive FIFO non-empty mask Note: Accessible in both device and host modes.
$00000020 constant OTG1_HS_GLOBAL_OTG_HS_GINTMSK_NPTXFEM            \ Non-periodic Tx FIFO empty mask Note: Only accessible in host mode.
$00000040 constant OTG1_HS_GLOBAL_OTG_HS_GINTMSK_GINAKEFFM          \ Global non-periodic IN NAK effective mask Note: Only accessible in device mode.
$00000080 constant OTG1_HS_GLOBAL_OTG_HS_GINTMSK_GONAKEFFM          \ Global OUT NAK effective mask Note: Only accessible in device mode.
$00000400 constant OTG1_HS_GLOBAL_OTG_HS_GINTMSK_ESUSPM             \ Early suspend mask Note: Only accessible in device mode.
$00000800 constant OTG1_HS_GLOBAL_OTG_HS_GINTMSK_USBSUSPM           \ USB suspend mask Note: Only accessible in device mode.
$00001000 constant OTG1_HS_GLOBAL_OTG_HS_GINTMSK_USBRST             \ USB reset mask Note: Only accessible in device mode.
$00002000 constant OTG1_HS_GLOBAL_OTG_HS_GINTMSK_ENUMDNEM           \ Enumeration done mask Note: Only accessible in device mode.
$00004000 constant OTG1_HS_GLOBAL_OTG_HS_GINTMSK_ISOODRPM           \ Isochronous OUT packet dropped interrupt mask Note: Only accessible in device mode.
$00008000 constant OTG1_HS_GLOBAL_OTG_HS_GINTMSK_EOPFM              \ End of periodic frame interrupt mask Note: Only accessible in device mode.
$00040000 constant OTG1_HS_GLOBAL_OTG_HS_GINTMSK_IEPINT             \ IN endpoints interrupt mask Note: Only accessible in device mode.
$00080000 constant OTG1_HS_GLOBAL_OTG_HS_GINTMSK_OEPINT             \ OUT endpoints interrupt mask Note: Only accessible in device mode.
$00100000 constant OTG1_HS_GLOBAL_OTG_HS_GINTMSK_IISOIXFRM          \ Incomplete isochronous IN transfer mask Note: Only accessible in device mode.
$00200000 constant OTG1_HS_GLOBAL_OTG_HS_GINTMSK_IPXFRM_IISOOXFRM
$00400000 constant OTG1_HS_GLOBAL_OTG_HS_GINTMSK_FSUSPM             \ Data fetch suspended mask Only accessible in peripheral mode.
$00800000 constant OTG1_HS_GLOBAL_OTG_HS_GINTMSK_RSTDETM            \ Reset detected interrupt mask Note: Only accessible in device mode.
$01000000 constant OTG1_HS_GLOBAL_OTG_HS_GINTMSK_PRTIM              \ Host port interrupt mask Note: Only accessible in host mode.
$02000000 constant OTG1_HS_GLOBAL_OTG_HS_GINTMSK_HCIM               \ Host channels interrupt mask Note: Only accessible in host mode.
$04000000 constant OTG1_HS_GLOBAL_OTG_HS_GINTMSK_PTXFEM             \ Periodic Tx FIFO empty mask Note: Only accessible in host mode.
$08000000 constant OTG1_HS_GLOBAL_OTG_HS_GINTMSK_LPMINTM            \ LPM interrupt mask Note: Accessible in both host and device modes.
$10000000 constant OTG1_HS_GLOBAL_OTG_HS_GINTMSK_CIDSCHGM           \ Connector ID status change mask Note: Accessible in both host and device modes.
$20000000 constant OTG1_HS_GLOBAL_OTG_HS_GINTMSK_DISCINT            \ Disconnect detected interrupt mask Note: Only accessible in host mode.
$40000000 constant OTG1_HS_GLOBAL_OTG_HS_GINTMSK_SRQIM              \ Session request/new session detected interrupt mask Note: Accessible in both host and device modes.
$80000000 constant OTG1_HS_GLOBAL_OTG_HS_GINTMSK_WUIM               \ Resume/remote wakeup detected interrupt mask Note: Accessible in both host and device modes.


\
\ @brief OTG_HS Receive status debug read register (host mode)
\ Address offset: 0x1C
\ Reset value: 0x00000000
\

$0000000f constant OTG1_HS_GLOBAL_OTG_HS_GRXSTSR_HOST_CHNUM         \ Channel number
$00007ff0 constant OTG1_HS_GLOBAL_OTG_HS_GRXSTSR_HOST_BCNT          \ Byte count
$00018000 constant OTG1_HS_GLOBAL_OTG_HS_GRXSTSR_HOST_DPID          \ Data PID
$001e0000 constant OTG1_HS_GLOBAL_OTG_HS_GRXSTSR_HOST_PKTSTS        \ Packet status


\
\ @brief OTG_HS Receive status debug read register (peripheral mode mode)
\ Address offset: 0x1C
\ Reset value: 0x00000000
\

$0000000f constant OTG1_HS_GLOBAL_OTG_HS_GRXSTSR_DEVICE_EPNUM       \ Endpoint number
$00007ff0 constant OTG1_HS_GLOBAL_OTG_HS_GRXSTSR_DEVICE_BCNT        \ Byte count
$00018000 constant OTG1_HS_GLOBAL_OTG_HS_GRXSTSR_DEVICE_DPID        \ Data PID
$001e0000 constant OTG1_HS_GLOBAL_OTG_HS_GRXSTSR_DEVICE_PKTSTS      \ Packet status
$01e00000 constant OTG1_HS_GLOBAL_OTG_HS_GRXSTSR_DEVICE_FRMNUM      \ Frame number
$78000000 constant OTG1_HS_GLOBAL_OTG_HS_GRXSTSR_DEVICE_STSPHST     \ Frame number


\
\ @brief OTG_HS status read and pop register (host mode)
\ Address offset: 0x20
\ Reset value: 0x00000000
\

$0000000f constant OTG1_HS_GLOBAL_OTG_HS_GRXSTSP_HOST_CHNUM         \ Channel number
$00007ff0 constant OTG1_HS_GLOBAL_OTG_HS_GRXSTSP_HOST_BCNT          \ Byte count
$00018000 constant OTG1_HS_GLOBAL_OTG_HS_GRXSTSP_HOST_DPID          \ Data PID
$001e0000 constant OTG1_HS_GLOBAL_OTG_HS_GRXSTSP_HOST_PKTSTS        \ Packet status


\
\ @brief OTG_HS status read and pop register (peripheral mode)
\ Address offset: 0x20
\ Reset value: 0x00000000
\

$0000000f constant OTG1_HS_GLOBAL_OTG_HS_GRXSTSP_DEVICE_EPNUM       \ Endpoint number
$00007ff0 constant OTG1_HS_GLOBAL_OTG_HS_GRXSTSP_DEVICE_BCNT        \ Byte count
$00018000 constant OTG1_HS_GLOBAL_OTG_HS_GRXSTSP_DEVICE_DPID        \ Data PID
$001e0000 constant OTG1_HS_GLOBAL_OTG_HS_GRXSTSP_DEVICE_PKTSTS      \ Packet status
$01e00000 constant OTG1_HS_GLOBAL_OTG_HS_GRXSTSP_DEVICE_FRMNUM      \ Frame number
$78000000 constant OTG1_HS_GLOBAL_OTG_HS_GRXSTSP_DEVICE_STSPHST     \ Frame number


\
\ @brief OTG_HS Receive FIFO size register
\ Address offset: 0x24
\ Reset value: 0x00000200
\

$0000ffff constant OTG1_HS_GLOBAL_OTG_HS_GRXFSIZ_RXFD               \ RxFIFO depth


\
\ @brief OTG_HS nonperiodic transmit FIFO size register (host mode)
\ Address offset: 0x28
\ Reset value: 0x00000200
\

$0000ffff constant OTG1_HS_GLOBAL_OTG_HS_HNPTXFSIZ_HOST_NPTXFSA     \ Nonperiodic transmit RAM start address
$ffff0000 constant OTG1_HS_GLOBAL_OTG_HS_HNPTXFSIZ_HOST_NPTXFD      \ Nonperiodic TxFIFO depth


\
\ @brief Endpoint 0 transmit FIFO size (peripheral mode)
\ Address offset: 0x28
\ Reset value: 0x00000200
\

$0000ffff constant OTG1_HS_GLOBAL_OTG_HS_DIEPTXF0_DEVICE_TX0FSA     \ Endpoint 0 transmit RAM start address
$ffff0000 constant OTG1_HS_GLOBAL_OTG_HS_DIEPTXF0_DEVICE_TX0FD      \ Endpoint 0 TxFIFO depth


\
\ @brief OTG_HS nonperiodic transmit FIFO/queue status register
\ Address offset: 0x2C
\ Reset value: 0x00080200
\

$0000ffff constant OTG1_HS_GLOBAL_OTG_HS_GNPTXSTS_NPTXFSAV          \ Nonperiodic TxFIFO space available
$00ff0000 constant OTG1_HS_GLOBAL_OTG_HS_GNPTXSTS_NPTQXSAV          \ Nonperiodic transmit request queue space available
$7f000000 constant OTG1_HS_GLOBAL_OTG_HS_GNPTXSTS_NPTXQTOP          \ Top of the nonperiodic transmit request queue


\
\ @brief OTG_HS general core configuration register
\ Address offset: 0x38
\ Reset value: 0x00000000
\

$00000001 constant OTG1_HS_GLOBAL_OTG_HS_GCCFG_DCDET                \ Data contact detection (DCD) status
$00000002 constant OTG1_HS_GLOBAL_OTG_HS_GCCFG_PDET                 \ Primary detection (PD) status
$00000004 constant OTG1_HS_GLOBAL_OTG_HS_GCCFG_SDET                 \ Secondary detection (SD) status
$00000008 constant OTG1_HS_GLOBAL_OTG_HS_GCCFG_PS2DET               \ DM pull-up detection status
$00010000 constant OTG1_HS_GLOBAL_OTG_HS_GCCFG_PWRDWN               \ Power down
$00020000 constant OTG1_HS_GLOBAL_OTG_HS_GCCFG_BCDEN                \ Battery charging detector (BCD) enable
$00040000 constant OTG1_HS_GLOBAL_OTG_HS_GCCFG_DCDEN                \ Data contact detection (DCD) mode enable
$00080000 constant OTG1_HS_GLOBAL_OTG_HS_GCCFG_PDEN                 \ Primary detection (PD) mode enable
$00100000 constant OTG1_HS_GLOBAL_OTG_HS_GCCFG_SDEN                 \ Secondary detection (SD) mode enable
$00200000 constant OTG1_HS_GLOBAL_OTG_HS_GCCFG_VBDEN                \ USB VBUS detection enable


\
\ @brief OTG_HS core ID register
\ Address offset: 0x3C
\ Reset value: 0x00001200
\

$00000000 constant OTG1_HS_GLOBAL_OTG_HS_CID_PRODUCT_ID             \ Product ID field


\
\ @brief OTG core LPM configuration register
\ Address offset: 0x54
\ Reset value: 0x00000000
\

$00000001 constant OTG1_HS_GLOBAL_OTG_HS_GLPMCFG_LPMEN              \ LPM support enable
$00000002 constant OTG1_HS_GLOBAL_OTG_HS_GLPMCFG_LPMACK             \ LPM token acknowledge enable
$0000003c constant OTG1_HS_GLOBAL_OTG_HS_GLPMCFG_BESL               \ Best effort service latency
$00000040 constant OTG1_HS_GLOBAL_OTG_HS_GLPMCFG_REMWAKE            \ bRemoteWake value
$00000080 constant OTG1_HS_GLOBAL_OTG_HS_GLPMCFG_L1SSEN             \ L1 Shallow Sleep enable
$00000f00 constant OTG1_HS_GLOBAL_OTG_HS_GLPMCFG_BESLTHRS           \ BESL threshold
$00001000 constant OTG1_HS_GLOBAL_OTG_HS_GLPMCFG_L1DSEN             \ L1 deep sleep enable
$00006000 constant OTG1_HS_GLOBAL_OTG_HS_GLPMCFG_LPMRST             \ LPM response
$00008000 constant OTG1_HS_GLOBAL_OTG_HS_GLPMCFG_SLPSTS             \ Port sleep status
$00010000 constant OTG1_HS_GLOBAL_OTG_HS_GLPMCFG_L1RSMOK            \ Sleep State Resume OK
$001e0000 constant OTG1_HS_GLOBAL_OTG_HS_GLPMCFG_LPMCHIDX           \ LPM Channel Index
$00e00000 constant OTG1_HS_GLOBAL_OTG_HS_GLPMCFG_LPMRCNT            \ LPM retry count
$01000000 constant OTG1_HS_GLOBAL_OTG_HS_GLPMCFG_SNDLPM             \ Send LPM transaction
$0e000000 constant OTG1_HS_GLOBAL_OTG_HS_GLPMCFG_LPMRCNTSTS         \ LPM retry count status
$10000000 constant OTG1_HS_GLOBAL_OTG_HS_GLPMCFG_ENBESL             \ Enable best effort service latency


\
\ @brief OTG_HS Host periodic transmit FIFO size register
\ Address offset: 0x100
\ Reset value: 0x02000600
\

$0000ffff constant OTG1_HS_GLOBAL_OTG_HS_HPTXFSIZ_PTXSA             \ Host periodic TxFIFO start address
$ffff0000 constant OTG1_HS_GLOBAL_OTG_HS_HPTXFSIZ_PTXFD             \ Host periodic TxFIFO depth


\
\ @brief OTG_HS device IN endpoint transmit FIFO size register
\ Address offset: 0x104
\ Reset value: 0x02000400
\

$0000ffff constant OTG1_HS_GLOBAL_OTG_HS_DIEPTXF1_INEPTXSA          \ IN endpoint FIFOx transmit RAM start address
$ffff0000 constant OTG1_HS_GLOBAL_OTG_HS_DIEPTXF1_INEPTXFD          \ IN endpoint TxFIFO depth


\
\ @brief OTG_HS device IN endpoint transmit FIFO size register
\ Address offset: 0x108
\ Reset value: 0x02000600
\

$0000ffff constant OTG1_HS_GLOBAL_OTG_HS_DIEPTXF2_INEPTXSA          \ IN endpoint FIFOx transmit RAM start address
$ffff0000 constant OTG1_HS_GLOBAL_OTG_HS_DIEPTXF2_INEPTXFD          \ IN endpoint TxFIFO depth


\
\ @brief OTG_HS device IN endpoint transmit FIFO size register
\ Address offset: 0x10C
\ Reset value: 0x02000800
\

$0000ffff constant OTG1_HS_GLOBAL_OTG_HS_DIEPTXF3_INEPTXSA          \ IN endpoint FIFOx transmit RAM start address
$ffff0000 constant OTG1_HS_GLOBAL_OTG_HS_DIEPTXF3_INEPTXFD          \ IN endpoint TxFIFO depth


\
\ @brief OTG_HS device IN endpoint transmit FIFO size register
\ Address offset: 0x110
\ Reset value: 0x02000A00
\

$0000ffff constant OTG1_HS_GLOBAL_OTG_HS_DIEPTXF4_INEPTXSA          \ IN endpoint FIFOx transmit RAM start address
$ffff0000 constant OTG1_HS_GLOBAL_OTG_HS_DIEPTXF4_INEPTXFD          \ IN endpoint TxFIFO depth


\
\ @brief OTG_HS device IN endpoint transmit FIFO size register
\ Address offset: 0x114
\ Reset value: 0x02000C00
\

$0000ffff constant OTG1_HS_GLOBAL_OTG_HS_DIEPTXF5_INEPTXSA          \ IN endpoint FIFOx transmit RAM start address
$ffff0000 constant OTG1_HS_GLOBAL_OTG_HS_DIEPTXF5_INEPTXFD          \ IN endpoint TxFIFO depth


\
\ @brief OTG_HS device IN endpoint transmit FIFO size register
\ Address offset: 0x118
\ Reset value: 0x02000E00
\

$0000ffff constant OTG1_HS_GLOBAL_OTG_HS_DIEPTXF6_INEPTXSA          \ IN endpoint FIFOx transmit RAM start address
$ffff0000 constant OTG1_HS_GLOBAL_OTG_HS_DIEPTXF6_INEPTXFD          \ IN endpoint TxFIFO depth


\
\ @brief IN endpoint FIFOx transmit RAM start address This field contains the memory start address for IN endpoint transmit FIFOx. The address must be aligned with a 32-bit memory location.
\ Address offset: 0x120
\ Reset value: 0x02001200
\

$0000ffff constant OTG1_HS_GLOBAL_OTG_DIEPTXF8_INEPTXSA             \ IN endpoint FIFOx transmit RAM start address This field contains the memory start address for IN endpoint transmit FIFOx. The address must be aligned with a 32-bit memory location.
$ffff0000 constant OTG1_HS_GLOBAL_OTG_DIEPTXF8_INEPTXFD             \ IN endpoint Tx FIFO depth This value is in terms of 32-bit words. Minimum value is 16


\
\ @brief OTG_HS device IN endpoint transmit FIFO size register
\ Address offset: 0x12C
\ Reset value: 0x02001000
\

$0000ffff constant OTG1_HS_GLOBAL_OTG_HS_DIEPTXF7_INEPTXSA          \ IN endpoint FIFOx transmit RAM start address
$ffff0000 constant OTG1_HS_GLOBAL_OTG_HS_DIEPTXF7_INEPTXFD          \ IN endpoint TxFIFO depth


\
\ @brief USB 1 on the go high speed
\
$40040000 constant OTG1_HS_GLOBAL_OTG_HS_GOTGCTL  \ offset: 0x00 : OTG_HS control and status register
$40040004 constant OTG1_HS_GLOBAL_OTG_HS_GOTGINT  \ offset: 0x04 : OTG_HS interrupt register
$40040008 constant OTG1_HS_GLOBAL_OTG_HS_GAHBCFG  \ offset: 0x08 : OTG_HS AHB configuration register
$4004000c constant OTG1_HS_GLOBAL_OTG_HS_GUSBCFG  \ offset: 0x0C : OTG_HS USB configuration register
$40040010 constant OTG1_HS_GLOBAL_OTG_HS_GRSTCTL  \ offset: 0x10 : OTG_HS reset register
$40040014 constant OTG1_HS_GLOBAL_OTG_HS_GINTSTS  \ offset: 0x14 : OTG_HS core interrupt register
$40040018 constant OTG1_HS_GLOBAL_OTG_HS_GINTMSK  \ offset: 0x18 : OTG_HS interrupt mask register
$4004001c constant OTG1_HS_GLOBAL_OTG_HS_GRXSTSR_HOST  \ offset: 0x1C : OTG_HS Receive status debug read register (host mode)
$4004001c constant OTG1_HS_GLOBAL_OTG_HS_GRXSTSR_DEVICE  \ offset: 0x1C : OTG_HS Receive status debug read register (peripheral mode mode)
$40040020 constant OTG1_HS_GLOBAL_OTG_HS_GRXSTSP_HOST  \ offset: 0x20 : OTG_HS status read and pop register (host mode)
$40040020 constant OTG1_HS_GLOBAL_OTG_HS_GRXSTSP_DEVICE  \ offset: 0x20 : OTG_HS status read and pop register (peripheral mode)
$40040024 constant OTG1_HS_GLOBAL_OTG_HS_GRXFSIZ  \ offset: 0x24 : OTG_HS Receive FIFO size register
$40040028 constant OTG1_HS_GLOBAL_OTG_HS_HNPTXFSIZ_HOST  \ offset: 0x28 : OTG_HS nonperiodic transmit FIFO size register (host mode)
$40040028 constant OTG1_HS_GLOBAL_OTG_HS_DIEPTXF0_DEVICE  \ offset: 0x28 : Endpoint 0 transmit FIFO size (peripheral mode)
$4004002c constant OTG1_HS_GLOBAL_OTG_HS_GNPTXSTS  \ offset: 0x2C : OTG_HS nonperiodic transmit FIFO/queue status register
$40040038 constant OTG1_HS_GLOBAL_OTG_HS_GCCFG  \ offset: 0x38 : OTG_HS general core configuration register
$4004003c constant OTG1_HS_GLOBAL_OTG_HS_CID  \ offset: 0x3C : OTG_HS core ID register
$40040054 constant OTG1_HS_GLOBAL_OTG_HS_GLPMCFG  \ offset: 0x54 : OTG core LPM configuration register
$40040100 constant OTG1_HS_GLOBAL_OTG_HS_HPTXFSIZ  \ offset: 0x100 : OTG_HS Host periodic transmit FIFO size register
$40040104 constant OTG1_HS_GLOBAL_OTG_HS_DIEPTXF1  \ offset: 0x104 : OTG_HS device IN endpoint transmit FIFO size register
$40040108 constant OTG1_HS_GLOBAL_OTG_HS_DIEPTXF2  \ offset: 0x108 : OTG_HS device IN endpoint transmit FIFO size register
$4004010c constant OTG1_HS_GLOBAL_OTG_HS_DIEPTXF3  \ offset: 0x10C : OTG_HS device IN endpoint transmit FIFO size register
$40040110 constant OTG1_HS_GLOBAL_OTG_HS_DIEPTXF4  \ offset: 0x110 : OTG_HS device IN endpoint transmit FIFO size register
$40040114 constant OTG1_HS_GLOBAL_OTG_HS_DIEPTXF5  \ offset: 0x114 : OTG_HS device IN endpoint transmit FIFO size register
$40040118 constant OTG1_HS_GLOBAL_OTG_HS_DIEPTXF6  \ offset: 0x118 : OTG_HS device IN endpoint transmit FIFO size register
$40040120 constant OTG1_HS_GLOBAL_OTG_DIEPTXF8  \ offset: 0x120 : IN endpoint FIFOx transmit RAM start address This field contains the memory start address for IN endpoint transmit FIFOx. The address must be aligned with a 32-bit memory location.
$4004012c constant OTG1_HS_GLOBAL_OTG_HS_DIEPTXF7  \ offset: 0x12C : OTG_HS device IN endpoint transmit FIFO size register

