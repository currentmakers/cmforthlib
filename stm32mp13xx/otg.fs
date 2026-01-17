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
    \ @brief OTG control and status register
    \ Address offset: 0x00
    \ Reset value: 0x00010000
    \
    $00 constant OTG_SRQSCS                     \ [0x00] Session request success The core sets this bit when a session request initiation is successful. Note: Only accessible in device mode.
    $01 constant OTG_SRQ                        \ [0x01] Session request The application sets this bit to initiate a session request on the USB. The application can clear this bit by writing a 0 when the host negotiation success status change bit in the OTG_GOTGINT register (HNSSCHG bit in OTG_GOTGINT) is set. The core clears this bit when the HNSSCHG bit is cleared. Note: Only accessible in device mode.
    $02 constant OTG_VBVALOEN                   \ [0x02] VBUS valid override enable. This bit is used to enable/disable the software to override the vbusvalid signal using the VBVALOVAL bit. Note: Only accessible in host mode.
    $03 constant OTG_VBVALOVAL                  \ [0x03] VBUS valid override value. This bit is used to set override value for vbusvalid signal when VBVALOEN bit is set. Note: Only accessible in host mode.
    $04 constant OTG_AVALOEN                    \ [0x04] A-peripheral session valid override enable. This bit is used to enable/disable the software to override the Avalid signal using the AVALOVAL bit. Note: Only accessible in host mode.
    $05 constant OTG_AVALOVAL                   \ [0x05] A-peripheral session valid override value. This bit is used to set override value for Avalid signal when AVALOEN bit is set. Note: Only accessible in host mode.
    $06 constant OTG_BVALOEN                    \ [0x06] B-peripheral session valid override enable. This bit is used to enable/disable the software to override the Bvalid signal using the BVALOVAL bit. Note: Only accessible in device mode.
    $07 constant OTG_BVALOVAL                   \ [0x07] B-peripheral session valid override value. This bit is used to set override value for Bvalid signal when BVALOEN bit is set. Note: Only accessible in device mode.
    $08 constant OTG_HNGSCS                     \ [0x08] Host negotiation success The core sets this bit when host negotiation is successful. The core clears this bit when the HNP request (HNPRQ) bit in this register is set. Note: Only accessible in device mode.
    $09 constant OTG_HNPRQ                      \ [0x09] HNP request The application sets this bit to initiate an HNP request to the connected USB host. The application can clear this bit by writing a 0 when the host negotiation success status change bit in the OTG_GOTGINT register (HNSSCHG bit in OTG_GOTGINT) is set. The core clears this bit when the HNSSCHG bit is cleared. Note: Only accessible in device mode.
    $0a constant OTG_HSHNPEN                    \ [0x0a] host set HNP enable The application sets this bit when it has successfully enabled HNP (using the SetFeature.SetHNPEnable command) on the connected device. Note: Only accessible in host mode.
    $0b constant OTG_DHNPEN                     \ [0x0b] Device HNP enabled The application sets this bit when it successfully receives a SetFeature.SetHNPEnable command from the connected USB host. Note: Only accessible in device mode.
    $0c constant OTG_EHEN                       \ [0x0c] Embedded host enable It is used to select between OTG A device state machine and embedded host state machine.
    $10 constant OTG_CIDSTS                     \ [0x10] Connector ID status Indicates the connector ID status on a connect event. Note: Accessible in both device and host modes.
    $11 constant OTG_DBCT                       \ [0x11] Long/short debounce time Indicates the debounce time of a detected connection. Note: Only accessible in host mode.
    $12 constant OTG_ASVLD                      \ [0x12] A-session valid Indicates the host mode transceiver status. Note: Only accessible in host mode.
    $13 constant OTG_BSVLD                      \ [0x13] B-session valid Indicates the device mode transceiver status. In OTG mode, the user can use this bit to determine if the device is connected or disconnected. Note: Only accessible in device mode.
    $14 constant OTG_OTGVER                     \ [0x14] OTG version Selects the OTG revision.
    $15 constant OTG_CURMOD                     \ [0x15] Current mode of operation Indicates the current mode (host or device).
  [then]


  [ifdef] OTG_OTG_GOTGINT_DEF
    \
    \ @brief OTG interrupt register
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $02 constant OTG_SEDET                      \ [0x02] Session end detected The core sets this bit to indicate that the level of the voltage on VBUS is no longer valid for a B-Peripheral session when VBUS < 0.8 V. Note: Accessible in both device and host modes.
    $08 constant OTG_SRSSCHG                    \ [0x08] Session request success status change The core sets this bit on the success or failure of a session request. The application must read the session request success bit in the OTG_GOTGCTL register (SRQSCS bit in OTG_GOTGCTL) to check for success or failure. Note: Accessible in both device and host modes.
    $09 constant OTG_HNSSCHG                    \ [0x09] Host negotiation success status change The core sets this bit on the success or failure of a USB host negotiation request. The application must read the host negotiation success bit of the OTG_GOTGCTL register (HNGSCS bit in OTG_GOTGCTL) to check for success or failure. Note: Accessible in both device and host modes.
    $11 constant OTG_HNGDET                     \ [0x11] Host negotiation detected The core sets this bit when it detects a host negotiation request on the USB. Note: Accessible in both device and host modes.
    $12 constant OTG_ADTOCHG                    \ [0x12] A-device timeout change The core sets this bit to indicate that the A-device has timed out while waiting for the B-device to connect. Note: Accessible in both device and host modes.
    $13 constant OTG_DBCDNE                     \ [0x13] Debounce done The core sets this bit when the debounce is completed after the device connect. The application can start driving USB reset after seeing this interrupt. This bit is only valid when the HNP Capable or SRP Capable bit is set in the OTG_GUSBCFG register (HNPCAP bit or SRPCAP bit in OTG_GUSBCFG, respectively). Note: Only accessible in host mode.
  [then]


  [ifdef] OTG_OTG_GAHBCFG_DEF
    \
    \ @brief OTG AHB configuration register
    \ Address offset: 0x08
    \ Reset value: 0x00000000
    \
    $00 constant OTG_GINTMSK                    \ [0x00] Global interrupt mask The application uses this bit to mask or unmask the interrupt line assertion to itself. Irrespective of this bit's setting, the interrupt status registers are updated by the core. Note: Accessible in both device and host modes.
    $01 constant OTG_HBSTLEN                    \ [0x01 : 4] Burst length/type 0000 Single: Bus transactions use single 32 bit accesses (not recommended) 0001 INCR: Bus transactions use unspecified length accesses (not recommended, uses the INCR AHB bus command) 0011 INCR4: Bus transactions target 4x 32 bit accesses 0101 INCR8: Bus transactions target 8x 32 bit accesses 0111 INCR16: Bus transactions based on 16x 32 bit accesses Others: Reserved
    $05 constant OTG_DMAEN                      \ [0x05] DMA enabled
    $07 constant OTG_TXFELVL                    \ [0x07] Tx FIFO empty level In device mode, this bit indicates when IN endpoint Transmit FIFO empty interrupt (TXFE in OTG_DIEPINTx) is triggered In host mode, this bit indicates when the nonperiodic Tx FIFO empty interrupt (NPTXFE bit in OTG_GINTSTS) is triggered
    $08 constant OTG_PTXFELVL                   \ [0x08] Periodic Tx FIFO empty level Indicates when the periodic Tx FIFO empty interrupt bit in the OTG_GINTSTS register (PTXFE bit in OTG_GINTSTS) is triggered. Note: Only accessible in host mode.
  [then]


  [ifdef] OTG_OTG_GUSBCFG_DEF
    \
    \ @brief OTG USB configuration register
    \ Address offset: 0x0C
    \ Reset value: 0x00001400
    \
    $00 constant OTG_TOCAL                      \ [0x00 : 3] FS timeout calibration The number of PHY clocks that the application programs in this field is added to the full-speed interpacket timeout duration in the core to account for any additional delays introduced by the PHY. This can be required, because the delay introduced by the PHY in generating the line state condition can vary from one PHY to another. The USB standard timeout value for full-speed operation is 16 to 18 (inclusive) bit times. The application must program this field based on the speed of enumeration. The number of bit times added per PHY clock is 0.25 bit times.
    $08 constant OTG_SRPCAP                     \ [0x08] SRP-capable The application uses this bit to control the OTG controller's SRP capabilities. If the core operates as a non-SRP-capable B-device, it cannot request the connected A-device (host) to activate VBUS and start a session. Note: Accessible in both device and host modes.
    $09 constant OTG_HNPCAP                     \ [0x09] HNP-capable The application uses this bit to control the OTG controller's HNP capabilities. Note: Accessible in both device and host modes.
    $0a constant OTG_TRDT                       \ [0x0a : 4] USB turnaround time These bits allows to set the turnaround time in PHY clocks. They must be configured according to or , depending on the application AHB frequency. Higher TRDT values allow stretching the USB response time to IN tokens in order to compensate for longer AHB read access latency to the data FIFO. Note: Only accessible in device mode.
    $0f constant OTG_PHYLPC                     \ [0x0f] PHY Low-power clock select This bit selects either 480Â MHz or 48Â MHz (low-power) PHY mode. In FS and LS modes, the PHY can usually operate on a 48Â MHz clock to save power. In 480 MHz mode, the UTMI interface operates at either 60 or 30Â MHz, depending on whether the 8- or 16-bit data width is selected. In 48Â MHz mode, the UTMI interface operates at 48Â MHz in FS and LS modes.
    $16 constant OTG_TSDPS                      \ [0x16] TermSel DLine pulsing selection This bit selects utmi_termselect to drive the data line pulse during SRP (session request protocol).
    $1d constant OTG_FHMOD                      \ [0x1d] Force host mode Writing a 1 to this bit, forces the core to host mode irrespective of the OTG_ID input pin. After setting the force bit, the application must wait at least 25Â ms before the change takes effect. Note: Accessible in both device and host modes.
    $1e constant OTG_FDMOD                      \ [0x1e] Force device mode Writing a 1 to this bit, forces the core to device mode irrespective of the OTG_ID input pin. After setting the force bit, the application must wait at least 25Â ms before the change takes effect. Note: Accessible in both device and host modes.
  [then]


  [ifdef] OTG_OTG_GRSTCTL_DEF
    \
    \ @brief OTG reset register
    \ Address offset: 0x10
    \ Reset value: 0x80000000
    \
    $00 constant OTG_CSRST                      \ [0x00] Core soft reset Resets the HCLK and PHY clock domains as follows: Clears the interrupts and all the CSR register bits except for the following bits: GATEHCLK bit in OTG_PCGCCTL STPPCLK bit in OTG_PCGCCTL FSLSPCS bits in OTG_HCFG DSPD bit in OTG_DCFG SDIS bit in OTG_DCTL OTG_GCCFG register All module state machines (except for the AHB slave unit) are reset to the Idle state, and all the transmit FIFOs and the receive FIFO are flushed. Any transactions on the AHB Master are terminated as soon as possible, after completing the last data phase of an AHB transfer. Any transactions on the USB are terminated immediately. The application can write to this bit any time it wants to reset the core. This is a self-clearing bit and the core clears this bit after all the necessary logic is reset in the core, which can take several clocks, depending on the current state of the core. Once this bit has been cleared, the software must wait at least 3 PHY clocks before accessing the PHY domain (synchronization delay). The software must also check that bit 31 in this register is set to 1 (AHB Master is Idle) before starting any operation. Typically, the software reset is used during software development and also when the user dynamically changes the PHY selection bits in the above listed USB configuration registers. When you change the PHY, the corresponding clock for the PHY is selected and used in the PHY domain. Once a new clock is selected, the PHY domain has to be reset for proper operation. Note: Accessible in both device and host modes.
    $01 constant OTG_PSRST                      \ [0x01] Partial soft reset Resets the internal state machines but keeps the enumeration info. Could be used to recover some specific PHY errors. Note: Accessible in both device and host modes.
    $02 constant OTG_FCRST                      \ [0x02] Host frame counter reset The application writes this bit to reset the (micro-)frame number counter inside the core. When the (micro-)frame counter is reset, the subsequent SOF sent out by the core has a frame number of 0. When application writes '1' to the bit, it might not be able to read back the value as it gets cleared by the core in a few clock cycles. Note: Only accessible in host mode.
    $04 constant OTG_RXFFLSH                    \ [0x04] Rx FIFO flush The application can flush the entire Rx FIFO using this bit, but must first ensure that the core is not in the middle of a transaction. The application must only write to this bit after checking that the core is neither reading from the Rx FIFO nor writing to the Rx FIFO. The application must wait until the bit is cleared before performing any other operations. This bit requires 8 clocks (slowest of PHY or AHB clock) to clear. Note: Accessible in both device and host modes.
    $05 constant OTG_TXFFLSH                    \ [0x05] Tx FIFO flush This bit selectively flushes a single or all transmit FIFOs, but cannot do so if the core is in the midst of a transaction. The application must write this bit only after checking that the core is neither writing to the Tx FIFO nor reading from the Tx FIFO. Verify using these registers: ReadâNAK Effective interrupt ensures the core is not reading from the FIFO WriteâAHBIDL bit in OTG_GRSTCTL ensures the core is not writing anything to the FIFO. Flushing is normally recommended when FIFOs are reconfigured. FIFO flushing is also recommended during device endpoint disable. The application must wait until the core clears this bit before performing any operations. This bit takes eight clocks to clear, using the slower clock of phy_clk or hclk. Note: Accessible in both device and host modes.
    $06 constant OTG_TXFNUM                     \ [0x06 : 5] Tx FIFO number This is the FIFO number that must be flushed using the Tx FIFO Flush bit. This field must not be changed until the core clears the Tx FIFO Flush bit. Others: Reserved, must not be used ... Note: Accessible in both device and host modes.
    $1e constant OTG_DMAREQ                     \ [0x1e] DMA request signal enabled This bit indicates that the DMA request is in progress. Used for debug.
    $1f constant OTG_AHBIDL                     \ [0x1f] AHB master idle Indicates that the AHB master state machine is in the Idle condition. Note: Accessible in both device and host modes.
  [then]


  [ifdef] OTG_OTG_GINTSTS_DEF
    \
    \ @brief OTG core interrupt register
    \ Address offset: 0x14
    \ Reset value: 0x04000020
    \
    $00 constant OTG_CMOD                       \ [0x00] Current mode of operation Indicates the current mode. Note: Accessible in both host and device modes.
    $01 constant OTG_MMIS                       \ [0x01] Mode mismatch interrupt The core sets this bit when the application is trying to access: A host mode register, when the core is operating in device mode A device mode register, when the core is operating in host mode The register access is completed on the AHB with an OKAY response, but is ignored by the core internally and does not affect the operation of the core. Note: Accessible in both host and device modes.
    $02 constant OTG_OTGINT                     \ [0x02] OTG interrupt The core sets this bit to indicate an OTG protocol event. The application must read the OTG interrupt status (OTG_GOTGINT) register to determine the exact event that caused this interrupt. The application must clear the appropriate status bit in the OTG_GOTGINT register to clear this bit. Note: Accessible in both host and device modes.
    $03 constant OTG_SOF                        \ [0x03] Start of frame In host mode, the core sets this bit to indicate that an SOF (FS), or Keep-Alive (LS) is transmitted on the USB. The application must write a 1 to this bit to clear the interrupt. In device mode, in the core sets this bit to indicate that an SOF token has been received on the USB. The application can read the OTG_DSTS register to get the current frame number. This interrupt is seen only when the core is operating in FS. Note: This register may return '1' if read immediately after power on reset. If the register bit reads '1' immediately after power on reset it does not indicate that an SOF has been sent (in case of host mode) or SOF has been received (in case of device mode). The read value of this interrupt is valid only after a valid connection between host and device is established. If the bit is set after power on reset the application can clear the bit. Note: Accessible in both host and device modes.
    $04 constant OTG_RXFLVL                     \ [0x04] Rx FIFO non-empty Indicates that there is at least one packet pending to be read from the Rx FIFO. Note: Accessible in both host and device modes.
    $05 constant OTG_NPTXFE                     \ [0x05] Non-periodic Tx FIFO empty This interrupt is asserted when the non-periodic Tx FIFO is either half or completely empty, and there is space for at least one entry to be written to the non-periodic transmit request queue. The half or completely empty status is determined by the non-periodic Tx FIFO empty level bit in the OTG_GAHBCFG register (TXFELVL bit in OTG_GAHBCFG). Note: Accessible in host mode only.
    $06 constant OTG_GINAKEFF                   \ [0x06] Global IN non-periodic NAK effective Indicates that the Set global non-periodic IN NAK bit in the OTG_DCTL register (SGINAK bit in OTG_DCTL), set by the application, has taken effect in the core. That is, the core has sampled the Global IN NAK bit set by the application. This bit can be cleared by clearing the Clear global non-periodic IN NAK bit in the OTG_DCTL register (CGINAK bit in OTG_DCTL). This interrupt does not necessarily mean that a NAK handshake is sent out on the USB. The STALL bit takes precedence over the NAK bit. Note: Only accessible in device mode.
    $07 constant OTG_GONAKEFF                   \ [0x07] Global OUT NAK effective Indicates that the Set global OUT NAK bit in the OTG_DCTL register (SGONAK bit in OTG_DCTL), set by the application, has taken effect in the core. This bit can be cleared by writing the Clear global OUT NAK bit in the OTG_DCTL register (CGONAK bit in OTG_DCTL). Note: Only accessible in device mode.
    $0a constant OTG_ESUSP                      \ [0x0a] Early suspend The core sets this bit to indicate that an Idle state has been detected on the USB for 3 ms. Note: Only accessible in device mode.
    $0b constant OTG_USBSUSP                    \ [0x0b] USB suspend The core sets this bit to indicate that a suspend was detected on the USB. The core enters the suspended state when there is no activity on the data lines for an extended period of time. Note: Only accessible in device mode.
    $0c constant OTG_USBRST                     \ [0x0c] USB reset The core sets this bit to indicate that a reset is detected on the USB. Note: Only accessible in device mode.
    $0d constant OTG_ENUMDNE                    \ [0x0d] Enumeration done The core sets this bit to indicate that speed enumeration is complete. The application must read the OTG_DSTS register to obtain the enumerated speed. Note: Only accessible in device mode.
    $0e constant OTG_ISOODRP                    \ [0x0e] Isochronous OUT packet dropped interrupt The core sets this bit when it fails to write an isochronous OUT packet into the Rx FIFO because the Rx FIFO does not have enough space to accommodate a maximum size packet for the isochronous OUT endpoint. Note: Only accessible in device mode.
    $0f constant OTG_EOPF                       \ [0x0f] End of periodic frame interrupt Indicates that the period specified in the periodic frame interval field of the OTG_DCFG register (PFIVL bit in OTG_DCFG) has been reached in the current frame. Note: Only accessible in device mode.
    $12 constant OTG_IEPINT                     \ [0x12] IN endpoint interrupt The core sets this bit to indicate that an interrupt is pending on one of the IN endpoints of the core (in device mode). The application must read the OTG_DAINT register to determine the exact number of the IN endpoint on which the interrupt occurred, and then read the corresponding OTG_DIEPINTx register to determine the exact cause of the interrupt. The application must clear the appropriate status bit in the corresponding OTG_DIEPINTx register to clear this bit. Note: Only accessible in device mode.
    $13 constant OTG_OEPINT                     \ [0x13] OUT endpoint interrupt The core sets this bit to indicate that an interrupt is pending on one of the OUT endpoints of the core (in device mode). The application must read the OTG_DAINT register to determine the exact number of the OUT endpoint on which the interrupt occurred, and then read the corresponding OTG_DOEPINTx register to determine the exact cause of the interrupt. The application must clear the appropriate status bit in the corresponding OTG_DOEPINTx register to clear this bit. Note: Only accessible in device mode.
    $14 constant OTG_IISOIXFR                   \ [0x14] Incomplete isochronous IN transfer The core sets this interrupt to indicate that there is at least one isochronous IN endpoint on which the transfer is not completed in the current frame. This interrupt is asserted along with the End of periodic frame interrupt (EOPF) bit in this register. Note: Only accessible in device mode.
    $15 constant OTG_IPXFR                      \ [0x15] Incomplete periodic transfer In host mode, the core sets this interrupt bit when there are incomplete periodic transactions still pending, which are scheduled for the current frame. The alternate description for device mode is in next paragraph
    $16 constant OTG_DATAFSUSP                  \ [0x16] Data fetch suspended This interrupt is valid only in DMA mode. This interrupt indicates that the core has stopped fetching data for IN endpoints due to the unavailability of TxFIFO space or request queue space. This interrupt is used by the application for an endpoint mismatch algorithm. For example, after detecting an endpoint mismatch, the application: Sets a global nonperiodic IN NAK handshake Disables IN endpoints Flushes the FIFO Determines the token sequence from the IN token sequence learning queue Re-enables the endpoints Clears the global nonperiodic IN NAK handshake If the global nonperiodic IN NAK is cleared, the core has not yet fetched data for the IN endpoint, and the IN token is received: the core generates an âIN token received when FIFO emptyâ interrupt. The OTG then sends a NAK response to the host. To avoid this scenario, the application can check the FetSusp interrupt in OTG_GINTSTS, which ensures that the FIFO is full before clearing a global NAK handshake. Alternatively, the application can mask the âIN token received when FIFO emptyâ interrupt when clearing a global IN NAK handshake.
    $17 constant OTG_RSTDET                     \ [0x17] Reset detected interrupt In device mode, this interrupt is asserted when a reset is detected on the USB in partial power-down mode when the device is in suspend. Note: Only accessible in device mode.
    $18 constant OTG_HPRTINT                    \ [0x18] Host port interrupt The core sets this bit to indicate a change in port status of one of the OTG controller ports in host mode. The application must read the OTG_HPRT register to determine the exact event that caused this interrupt. The application must clear the appropriate status bit in the OTG_HPRT register to clear this bit. Note: Only accessible in host mode.
    $19 constant OTG_HCINT                      \ [0x19] Host channels interrupt The core sets this bit to indicate that an interrupt is pending on one of the channels of the core (in host mode). The application must read the OTG_HAINT register to determine the exact number of the channel on which the interrupt occurred, and then read the corresponding OTG_HCINTx register to determine the exact cause of the interrupt. The application must clear the appropriate status bit in the OTG_HCINTx register to clear this bit. Note: Only accessible in host mode.
    $1a constant OTG_PTXFE                      \ [0x1a] Periodic Tx FIFO empty Asserted when the periodic transmit FIFO is either half or completely empty and there is space for at least one entry to be written in the periodic request queue. The half or completely empty status is determined by the periodic Tx FIFO empty level bit in the OTG_GAHBCFG register (PTXFELVL bit in OTG_GAHBCFG). Note: Only accessible in host mode.
    $1b constant OTG_LPMINT                     \ [0x1b] LPM interrupt In device mode, this interrupt is asserted when the device receives an LPM transaction and responds with a non-ERRORed response. In host mode, this interrupt is asserted when the device responds to an LPM transaction with a non-ERRORed response or when the host core has completed LPM transactions for the programmed number of times (RETRYCNT bit in OTG_GLPMCFG). This field is valid only if the LPMEN bit in OTG_GLPMCFG is set to 1.
    $1c constant OTG_CIDSCHG                    \ [0x1c] Connector ID status change The core sets this bit when there is a change in connector ID status. Note: Accessible in both device and host modes.
    $1d constant OTG_DISCINT                    \ [0x1d] Disconnect detected interrupt Asserted when a device disconnect is detected. Note: Only accessible in host mode.
    $1e constant OTG_SRQINT                     \ [0x1e] Session request/new session detected interrupt In host mode, this interrupt is asserted when a session request is detected from the device. In device mode, this interrupt is asserted when VBUS is in the valid range for a B-peripheral device. Accessible in both device and host modes.
    $1f constant OTG_WKUPINT                    \ [0x1f] Resume/remote wakeup detected interrupt Wakeup interrupt during suspend(L2) or LPM(L1) state. During suspend(L2): In device mode, this interrupt is asserted when a resume is detected on the USB. In host mode, this interrupt is asserted when a remote wakeup is detected on the USB. During LPM(L1): This interrupt is asserted for either host initiated resume or device initiated remote wakeup on USB. Note: Accessible in both device and host modes.
  [then]


  [ifdef] OTG_OTG_GINTMSK_DEF
    \
    \ @brief OTG interrupt mask register
    \ Address offset: 0x18
    \ Reset value: 0x00000000
    \
    $01 constant OTG_MMISM                      \ [0x01] Mode mismatch interrupt mask Note: Accessible in both device and host modes.
    $02 constant OTG_OTGINT                     \ [0x02] OTG interrupt mask Note: Accessible in both device and host modes.
    $03 constant OTG_SOFM                       \ [0x03] Start of frame mask Note: Accessible in both device and host modes.
    $04 constant OTG_RXFLVLM                    \ [0x04] Receive FIFO non-empty mask Note: Accessible in both device and host modes.
    $05 constant OTG_NPTXFEM                    \ [0x05] Non-periodic Tx FIFO empty mask Note: Only accessible in host mode.
    $06 constant OTG_GINAKEFFM                  \ [0x06] Global non-periodic IN NAK effective mask Note: Only accessible in device mode.
    $07 constant OTG_GONAKEFFM                  \ [0x07] Global OUT NAK effective mask Note: Only accessible in device mode.
    $0a constant OTG_ESUSPM                     \ [0x0a] Early suspend mask Note: Only accessible in device mode.
    $0b constant OTG_USBSUSPM                   \ [0x0b] USB suspend mask Note: Only accessible in device mode.
    $0c constant OTG_USBRST                     \ [0x0c] USB reset mask Note: Only accessible in device mode.
    $0d constant OTG_ENUMDNEM                   \ [0x0d] Enumeration done mask Note: Only accessible in device mode.
    $0e constant OTG_ISOODRPM                   \ [0x0e] Isochronous OUT packet dropped interrupt mask Note: Only accessible in device mode.
    $0f constant OTG_EOPFM                      \ [0x0f] End of periodic frame interrupt mask Note: Only accessible in device mode.
    $12 constant OTG_IEPINT                     \ [0x12] IN endpoints interrupt mask Note: Only accessible in device mode.
    $13 constant OTG_OEPINT                     \ [0x13] OUT endpoints interrupt mask Note: Only accessible in device mode.
    $14 constant OTG_IISOIXFRM                  \ [0x14] Incomplete isochronous IN transfer mask Note: Only accessible in device mode.
    $15 constant OTG_IPXFRM                     \ [0x15] Incomplete periodic transfer mask Note: Only accessible in host mode. The alternate descripton for device mode is defined in next paragraph
    $16 constant OTG_FSUSPM                     \ [0x16] Data fetch suspended mask Only accessible in peripheral mode.
    $17 constant OTG_RSTDETM                    \ [0x17] Reset detected interrupt mask Note: Only accessible in device mode.
    $18 constant OTG_PRTIM                      \ [0x18] Host port interrupt mask Note: Only accessible in host mode.
    $19 constant OTG_HCIM                       \ [0x19] Host channels interrupt mask Note: Only accessible in host mode.
    $1a constant OTG_PTXFEM                     \ [0x1a] Periodic Tx FIFO empty mask Note: Only accessible in host mode.
    $1b constant OTG_LPMINTM                    \ [0x1b] LPM interrupt mask Note: Accessible in both host and device modes.
    $1c constant OTG_CIDSCHGM                   \ [0x1c] Connector ID status change mask Note: Accessible in both host and device modes.
    $1d constant OTG_DISCINT                    \ [0x1d] Disconnect detected interrupt mask Note: Only accessible in host mode.
    $1e constant OTG_SRQIM                      \ [0x1e] Session request/new session detected interrupt mask Note: Accessible in both host and device modes.
    $1f constant OTG_WUIM                       \ [0x1f] Resume/remote wakeup detected interrupt mask Note: Accessible in both host and device modes.
  [then]


  [ifdef] OTG_OTG_GRXSTSR_DEF
    \
    \ @brief OTG receive status debug read register
    \ Address offset: 0x1C
    \ Reset value: 0x00000000
    \
    $00 constant OTG_EPNUM                      \ [0x00 : 4] Endpoint number Indicates the endpoint number to which the current received packet belongs.
    $04 constant OTG_BCNT                       \ [0x04 : 11] Byte count Indicates the byte count of the received data packet.
    $0f constant OTG_DPID                       \ [0x0f : 2] Data PID Indicates the data PID of the received OUT data packet
    $11 constant OTG_PKTSTS                     \ [0x11 : 4] Packet status Indicates the status of the received packet Others: Reserved
    $15 constant OTG_FRMNUM                     \ [0x15 : 4] Frame number This is the least significant 4 bits of the frame number in which the packet is received on the USB. This field is supported only when isochronous OUT endpoints are supported.
    $1b constant OTG_STSPHST                    \ [0x1b] Status phase start Indicates the start of the status phase for a control write transfer. This bit is set along with the OUT transfer completed PKTSTS pattern.
  [then]


  [ifdef] OTG_OTG_GRXSTSP_DEF
    \
    \ @brief OTG status read and pop register
    \ Address offset: 0x20
    \ Reset value: 0x00000000
    \
    $00 constant OTG_EPNUM                      \ [0x00 : 4] Endpoint number Indicates the endpoint number to which the current received packet belongs.
    $04 constant OTG_BCNT                       \ [0x04 : 11] Byte count Indicates the byte count of the received data packet.
    $0f constant OTG_DPID                       \ [0x0f : 2] Data PID Indicates the data PID of the received OUT data packet
    $11 constant OTG_PKTSTS                     \ [0x11 : 4] Packet status Indicates the status of the received packet Others: Reserved
    $15 constant OTG_FRMNUM                     \ [0x15 : 4] Frame number This is the least significant 4 bits of the frame number in which the packet is received on the USB. This field is supported only when isochronous OUT endpoints are supported.
    $1b constant OTG_STSPHST                    \ [0x1b] Status phase start Indicates the start of the status phase for a control write transfer. This bit is set along with the OUT transfer completed PKTSTS pattern.
  [then]


  [ifdef] OTG_OTG_GRXFSIZ_DEF
    \
    \ @brief OTG receive FIFO size register
    \ Address offset: 0x24
    \ Reset value: 0x00000400
    \
    $00 constant OTG_RXFD                       \ [0x00 : 16] Rx FIFO depth This value is in terms of 32-bit words. Maximum value is 1024 Programmed values must respect the available FIFO memory allocation and must not exceed the power-on value.
  [then]


  [ifdef] OTG_OTG_HNPTXFSIZ_DEF
    \
    \ @brief OTG host non-periodic transmit FIFO size register
    \ Address offset: 0x28
    \ Reset value: 0x02000200
    \
    $00 constant OTG_NPTXFSA                    \ [0x00 : 16] Non-periodic transmit RAM start address This field configures the memory start address for non-periodic transmit FIFO RAM.
    $10 constant OTG_NPTXFD                     \ [0x10 : 16] Non-periodic Tx FIFO depth This value is in terms of 32-bit words. Minimum value is 16 Programmed values must respect the available FIFO memory allocation and must not exceed the power-on value.
  [then]


  [ifdef] OTG_OTG_HNPTXSTS_DEF
    \
    \ @brief OTG non-periodic transmit FIFO/queue status register
    \ Address offset: 0x2C
    \ Reset value: 0x00080400
    \
    $00 constant OTG_NPTXFSAV                   \ [0x00 : 16] Non-periodic Tx FIFO space available Indicates the amount of free space available in the non-periodic Tx FIFO. Values are in terms of 32-bit words. 2: 2 words available n: n words available (where 0 â¤ n â¤ 512) Others: Reserved
    $10 constant OTG_NPTQXSAV                   \ [0x10 : 8] Non-periodic transmit request queue space available Indicates the amount of free space available in the non-periodic transmit request queue. This queue holds both IN and OUT requests. 2: locations available n: n locations available (0 â¤ n â¤ 8) Others: Reserved
    $18 constant OTG_NPTXQTOP                   \ [0x18 : 7] Top of the non-periodic transmit request queue Entry in the non-periodic Tx request queue that is currently being processed by the MAC. Bits 30:27: Channel/endpoint number Bits 26:25: Bit 24: Terminate (last entry for selected channel/endpoint)
  [then]


  [ifdef] OTG_OTG_GCCFG_DEF
    \
    \ @brief USB VBUS detection enable Enables VBUS sensing comparators to detect VBUS valid levels on the VBUS PAD for USB host and device operation. If HNP and/or SRP support is enabled, VBUS comparators are automatically enabled independently of VBDEN value. 0 = VBUS detection disabled 1 = VBUS detection enabled
    \ Address offset: 0x38
    \ Reset value: 0x00000000
    \
    $15 constant OTG_VBDEN                      \ [0x15] USB VBUS detection enable Enables VBUS sensing comparators to detect VBUS valid levels on the VBUS PAD for USB host and device operation. If HNP and/or SRP support is enabled, VBUS comparators are automatically enabled independently of VBDEN value. 0 = VBUS detection disabled 1 = VBUS detection enabled
    $16 constant OTG_IDEN                       \ [0x16] USB ID detection enable Enables detection of the ID pin state.
  [then]


  [ifdef] OTG_OTG_CID_DEF
    \
    \ @brief OTG core ID register
    \ Address offset: 0x3C
    \ Reset value: 0x00004000
    \
    $00 constant OTG_PRODUCT_ID                 \ [0x00 : 32] Product ID field Application-programmable ID field.
  [then]


  [ifdef] OTG_OTG_GLPMCFG_DEF
    \
    \ @brief LPM support enable The application uses this bit to control the OTG core LPM capabilities. If the core operates as a non-LPM-capable host, it cannot request the connected device or hub to activate LPM mode. If the core operates as a non-LPM-capable device, it cannot respond to any LPM transactions.
    \ Address offset: 0x54
    \ Reset value: 0x00000000
    \
    $00 constant OTG_LPMEN                      \ [0x00] LPM support enable The application uses this bit to control the OTG core LPM capabilities. If the core operates as a non-LPM-capable host, it cannot request the connected device or hub to activate LPM mode. If the core operates as a non-LPM-capable device, it cannot respond to any LPM transactions.
    $01 constant OTG_LPMACK                     \ [0x01] LPM token acknowledge enable Handshake response to LPM token preprogrammed by device application software. Even though ACK is preprogrammed, the core device responds with ACK only on successful LPM transaction. The LPM transaction is successful if: No PID/CRC5 errors in either EXT token or LPM token (else ERROR) Valid bLinkState = 0001B (L1) received in LPM transaction (else STALL) No data pending in transmit queue (else NYET). The preprogrammed software bit is over-ridden for response to LPM token when: The received bLinkState is not L1 (STALL response), or An error is detected in either of the LPM token packets because of corruption (ERROR response). Note: Accessible only in device mode.
    $02 constant OTG_BESL                       \ [0x02 : 4] Best effort service latency Host mode: The value of BESL to be sent in an LPM transaction. This value is also used to initiate resume for a duration TL1HubDrvResume1 for host initiated resume. Device mode (read-only): This field is updated with the received LPM token BESL bmAttribute when an ACK, NYET, or STALL response is sent to an LPM transaction. BESL[3:0] TBESL (Î¼s)
    $06 constant OTG_REMWAKE                    \ [0x06] bRemoteWake value Host mode: The value of remote wake up to be sent in the wIndex field of LPM transaction. Device mode (read-only): This field is updated with the received LPM token bRemoteWake bmAttribute when an ACK, NYET, or STALL response is sent to an LPM transaction.
    $07 constant OTG_L1SSEN                     \ [0x07] L1 Shallow Sleep enable Enables suspending the PHY in L1 Sleep mode. For maximum power saving during L1 Sleep mode, this bit should be set to '1' by application SW in all the cases.
    $08 constant OTG_BESLTHRS                   \ [0x08 : 4] BESL threshold Device mode: The core puts the PHY into deep low power mode in L1 when BESL value is greater than or equal to the value defined in this field BESL_Thres[3:0]. Host mode: The core puts the PHY into deep low power mode in L1. BESLTHRS[3:0] specifies the time for which resume signaling is to be reflected by host (TL1HubDrvResume2) on the USB bus when it detects device initiated resume. BESLTHRS must not be programmed with a value greater than 1100b in host mode, because this exceeds maximum TL1HubDrvResume2. Thres[3:0] host mode resume signaling time (Î¼s): All other values: reserved
    $0c constant OTG_L1DSEN                     \ [0x0c] L1 deep sleep enable Enables suspending the PHY in L1 Sleep mode. For maximum power saving during L1 Sleep mode, this bit should be set to '1' by application SW in all the cases.
    $0d constant OTG_LPMRSP                     \ [0x0d : 2] LPM response Device mode: The response of the core to LPM transaction received is reflected in these two bits. Host mode: Handshake response received from local device for LPM transaction
    $0f constant OTG_SLPSTS                     \ [0x0f] Port sleep status Device mode: This bit is set as long as a Sleep condition is present on the USB bus. The core enters the Sleep state when an ACK response is sent to an LPM transaction and the TL1TokenRetry timer has expired. To stop the PHY clock, the application must set the STPPCLK bit in OTG_PCGCCTL, which asserts the PHY suspend input signal. The application must rely on SLPSTS and not ACK in LPMRSP to confirm transition into sleep. The core comes out of sleep: When there is any activity on the USB linestate When the application writes to the RWUSIG bit in OTG_DCTL or when the application resets or soft-disconnects the device. Host mode: The host transitions to Sleep (L1) state as a side-effect of a successful LPM transaction by the core to the local port with ACK response from the device. The read value of this bit reflects the current Sleep status of the port. The core clears this bit after: The core detects a remote L1 wakeup signal, The application sets the PRST bit or the PRES bit in the OTG_HPRT register, or The application sets the L1Resume/ remote wakeup detected interrupt bit or disconnect detected interrupt bit in the core interrupt register (WKUPINT or DISCINT bit in OTG_GINTSTS, respectively).
    $10 constant OTG_L1RSMOK                    \ [0x10] Sleep state resume OK Indicates that the device or host can start resume from Sleep state. This bit is valid in LPM sleep (L1) state. It is set in sleep mode after a delay of 50 Î¼s (TL1Residency). This bit is reset when SLPSTS is 0.
    $11 constant OTG_LPMCHIDX                   \ [0x11 : 4] LPM Channel Index The channel number on which the LPM transaction has to be applied while sending an LPM transaction to the local device. Based on the LPM channel index, the core automatically inserts the device address and endpoint number programmed in the corresponding channel into the LPM transaction. Note: Accessible only in host mode.
    $15 constant OTG_LPMRCNT                    \ [0x15 : 3] LPM retry count When the device gives an ERROR response, this is the number of additional LPM retries that the host performs until a valid device response (STALL, NYET, or ACK) is received. Note: Accessible only in host mode.
    $18 constant OTG_SNDLPM                     \ [0x18] Send LPM transaction When the application software sets this bit, an LPM transaction containing two tokens, EXT and LPM is sent. The hardware clears this bit once a valid response (STALL, NYET, or ACK) is received from the device or the core has finished transmitting the programmed number of LPM retries. Note: This bit must be set only when the host is connected to a local port. Note: Accessible only in host mode.
    $19 constant OTG_LPMRCNTSTS                 \ [0x19 : 3] LPM retry count status Number of LPM host retries still remaining to be transmitted for the current LPM sequence. Note: Accessible only in host mode.
    $1c constant OTG_ENBESL                     \ [0x1c] Enable best effort service latency This bit enables the BESL feature as defined in the LPM errata: USB 2.0 Link Power Management Addendum Engineering Change Notice to the USB 2.0 specification, July 16, 2007 Errata for USB 2.0 ECN: Link Power Management (LPM) - 7/2007 Note: Only the updated behavior (described in LPM Errata) is considered in this document and so the ENBESL bit should be set to '1' by application SW.
  [then]


  [ifdef] OTG_OTG_HPTXFSIZ_DEF
    \
    \ @brief Host periodic Tx FIFO start address This field configures the memory start address for periodic transmit FIFO RAM.
    \ Address offset: 0x100
    \ Reset value: 0x04000800
    \
    $00 constant OTG_PTXSA                      \ [0x00 : 16] Host periodic Tx FIFO start address This field configures the memory start address for periodic transmit FIFO RAM.
    $10 constant OTG_PTXFSIZ                    \ [0x10 : 16] Host periodic Tx FIFO depth This value is in terms of 32-bit words. Minimum value is 16
  [then]


  [ifdef] OTG_OTG_DIEPTXF1_DEF
    \
    \ @brief IN endpoint FIFOx transmit RAM start address This field contains the memory start address for IN endpoint transmit FIFOx. The address must be aligned with a 32-bit memory location.
    \ Address offset: 0x104
    \ Reset value: 0x02000400
    \
    $00 constant OTG_INEPTXSA                   \ [0x00 : 16] IN endpoint FIFOx transmit RAM start address This field contains the memory start address for IN endpoint transmit FIFOx. The address must be aligned with a 32-bit memory location.
    $10 constant OTG_INEPTXFD                   \ [0x10 : 16] IN endpoint Tx FIFO depth This value is in terms of 32-bit words. Minimum value is 16
  [then]


  [ifdef] OTG_OTG_DIEPTXF2_DEF
    \
    \ @brief IN endpoint FIFOx transmit RAM start address This field contains the memory start address for IN endpoint transmit FIFOx. The address must be aligned with a 32-bit memory location.
    \ Address offset: 0x108
    \ Reset value: 0x02000400
    \
    $00 constant OTG_INEPTXSA                   \ [0x00 : 16] IN endpoint FIFOx transmit RAM start address This field contains the memory start address for IN endpoint transmit FIFOx. The address must be aligned with a 32-bit memory location.
    $10 constant OTG_INEPTXFD                   \ [0x10 : 16] IN endpoint Tx FIFO depth This value is in terms of 32-bit words. Minimum value is 16
  [then]


  [ifdef] OTG_OTG_DIEPTXF3_DEF
    \
    \ @brief IN endpoint FIFOx transmit RAM start address This field contains the memory start address for IN endpoint transmit FIFOx. The address must be aligned with a 32-bit memory location.
    \ Address offset: 0x10C
    \ Reset value: 0x02000400
    \
    $00 constant OTG_INEPTXSA                   \ [0x00 : 16] IN endpoint FIFOx transmit RAM start address This field contains the memory start address for IN endpoint transmit FIFOx. The address must be aligned with a 32-bit memory location.
    $10 constant OTG_INEPTXFD                   \ [0x10 : 16] IN endpoint Tx FIFO depth This value is in terms of 32-bit words. Minimum value is 16
  [then]


  [ifdef] OTG_OTG_DIEPTXF4_DEF
    \
    \ @brief IN endpoint FIFOx transmit RAM start address This field contains the memory start address for IN endpoint transmit FIFOx. The address must be aligned with a 32-bit memory location.
    \ Address offset: 0x110
    \ Reset value: 0x02000400
    \
    $00 constant OTG_INEPTXSA                   \ [0x00 : 16] IN endpoint FIFOx transmit RAM start address This field contains the memory start address for IN endpoint transmit FIFOx. The address must be aligned with a 32-bit memory location.
    $10 constant OTG_INEPTXFD                   \ [0x10 : 16] IN endpoint Tx FIFO depth This value is in terms of 32-bit words. Minimum value is 16
  [then]


  [ifdef] OTG_OTG_DIEPTXF5_DEF
    \
    \ @brief IN endpoint FIFOx transmit RAM start address This field contains the memory start address for IN endpoint transmit FIFOx. The address must be aligned with a 32-bit memory location.
    \ Address offset: 0x114
    \ Reset value: 0x02000400
    \
    $00 constant OTG_INEPTXSA                   \ [0x00 : 16] IN endpoint FIFOx transmit RAM start address This field contains the memory start address for IN endpoint transmit FIFOx. The address must be aligned with a 32-bit memory location.
    $10 constant OTG_INEPTXFD                   \ [0x10 : 16] IN endpoint Tx FIFO depth This value is in terms of 32-bit words. Minimum value is 16
  [then]


  [ifdef] OTG_OTG_DIEPTXF6_DEF
    \
    \ @brief IN endpoint FIFOx transmit RAM start address This field contains the memory start address for IN endpoint transmit FIFOx. The address must be aligned with a 32-bit memory location.
    \ Address offset: 0x118
    \ Reset value: 0x02000400
    \
    $00 constant OTG_INEPTXSA                   \ [0x00 : 16] IN endpoint FIFOx transmit RAM start address This field contains the memory start address for IN endpoint transmit FIFOx. The address must be aligned with a 32-bit memory location.
    $10 constant OTG_INEPTXFD                   \ [0x10 : 16] IN endpoint Tx FIFO depth This value is in terms of 32-bit words. Minimum value is 16
  [then]


  [ifdef] OTG_OTG_DIEPTXF7_DEF
    \
    \ @brief IN endpoint FIFOx transmit RAM start address This field contains the memory start address for IN endpoint transmit FIFOx. The address must be aligned with a 32-bit memory location.
    \ Address offset: 0x11C
    \ Reset value: 0x02000400
    \
    $00 constant OTG_INEPTXSA                   \ [0x00 : 16] IN endpoint FIFOx transmit RAM start address This field contains the memory start address for IN endpoint transmit FIFOx. The address must be aligned with a 32-bit memory location.
    $10 constant OTG_INEPTXFD                   \ [0x10 : 16] IN endpoint Tx FIFO depth This value is in terms of 32-bit words. Minimum value is 16
  [then]


  [ifdef] OTG_OTG_DIEPTXF8_DEF
    \
    \ @brief IN endpoint FIFOx transmit RAM start address This field contains the memory start address for IN endpoint transmit FIFOx. The address must be aligned with a 32-bit memory location.
    \ Address offset: 0x120
    \ Reset value: 0x02000400
    \
    $00 constant OTG_INEPTXSA                   \ [0x00 : 16] IN endpoint FIFOx transmit RAM start address This field contains the memory start address for IN endpoint transmit FIFOx. The address must be aligned with a 32-bit memory location.
    $10 constant OTG_INEPTXFD                   \ [0x10 : 16] IN endpoint Tx FIFO depth This value is in terms of 32-bit words. Minimum value is 16
  [then]


  [ifdef] OTG_OTG_HCFG_DEF
    \
    \ @brief OTG host configuration register
    \ Address offset: 0x400
    \ Reset value: 0x00000000
    \
    $00 constant OTG_FSLSPCS                    \ [0x00 : 2] FS/LS PHY clock select Others: Reserved Note: The FSLSPCS must be set on a connection event according to the speed of the connected device (after changing this bit, a software reset must be performed).
    $02 constant OTG_FSLSS                      \ [0x02] FS- and LS-only support The application uses this bit to control the core's enumeration speed. Using this bit, the application can make the core enumerate as an FS host, even if the connected device supports HS traffic. Do not make changes to this field after initial programming.
    $17 constant OTG_DESCDMA                    \ [0x17] Enable scatter/gather DMA in host mode The application can set this bit during initialization to enable the Scatter/Gather DMA operation. This bit must be modified only once after a reset. The following combinations are available for programming: OTG_GAHBCFG.DMAEN=0,OTG_HCFG.DESCDMA=0 => Slave mode OTG_GAHBCFG.DMAEN=0,OTG_HCFG.DESCDMA=1 => Invalid OTG_GAHBCFG.DMAEN=1,OTG_HCFG.DESCDMA=0 => Buffered DMA mode OTG_GAHBCFG.DMAEN=1,OTG_HCFG.DESCDMA=1 => Scatter/Gather DMA mode
    $18 constant OTG_FRLSTEN                    \ [0x18 : 2] Frame list entries The value in the register specifies the number of entries in the Frame list. This field is valid only in Scatter/Gather DMA mode. 2'b00: Reserved 2'b01: 8 Entries 2'b10: 16 Entries 2'b11: 32 Entries In non-Scatter/Gather
    $1a constant OTG_PERSSCHEDENA               \ [0x1a] Enable periodic scheduling Applicable in host scatter/gather DMA mode only. Enables periodic scheduling within the core. Initially, the bit is res and the core does not process any periodic channels. As soon as this bit is set, the core gets ready to start scheduling periodic channels and sets OTG_HCFG.PERSCHEDSTAT. The setting of PERSCHEDSTAT indicates the core has enabled periodic scheduling. Once PERSSCHEDENA is set, the application is not supposed to reset the bit unless PERSCHEDSTAT is set. As soon as this bit is reset, the core gets ready to stop scheduling periodic channels and resets HCFG. PerSchedStat. In non-Scatter/Gather DMA mode, this bit is reserved.
  [then]


  [ifdef] OTG_OTG_HFIR_DEF
    \
    \ @brief OTG host frame interval register
    \ Address offset: 0x404
    \ Reset value: 0x0000EA60
    \
    $00 constant OTG_FRIVL                      \ [0x00 : 16] Frame interval The value that the application programs to this field, specifies the interval between two consecutive micro-SOFs (HS) or Keep-Alive tokens (LS). This field contains the number of PHY clocks that constitute the required frame interval. The application can write a value to this register only after the port enable bit of the host port control and status register (PENA bit in OTG_HPRT) has been set. If no value is programmed, the core calculates the value based on the PHY clock specified in the FS/LS PHY clock select field of the host configuration register (FSLSPCS in OTG_HCFG). Do not change the value of this field after the initial configuration, unless the RLDCTRL bit is set. In such case, the FRIVL is reloaded with each SOF event. Frame interval = 125Â Î¼s Ã (FRIVL - 1) in high speed operation Frame interval = 1Â ms Ã (FRIVL - 1) in low/full speed operation
    $10 constant OTG_RLDCTRL                    \ [0x10] Reload control This bit allows dynamic reloading of the HFIR register during run time. This bit needs to be programmed during initial configuration and its value must not be changed during run time. RLDCTRL = 0 is not recommended.
  [then]


  [ifdef] OTG_OTG_HFNUM_DEF
    \
    \ @brief OTG host frame number/frame time remaining register
    \ Address offset: 0x408
    \ Reset value: 0x00003FFF
    \
    $00 constant OTG_FRNUM                      \ [0x00 : 16] Frame number This field increments when a new SOF is transmitted on the USB, and is cleared to 0 when it reaches 0x3FFF.
    $10 constant OTG_FTREM                      \ [0x10 : 16] Frame time remaining Indicates the amount of time remaining in the current frame, in terms of PHY clocks. This field decrements on each PHY clock. When it reaches zero, this field is reloaded with the value in the Frame interval register and a new SOF is transmitted on the USB.
  [then]


  [ifdef] OTG_OTG_HPTXSTS_DEF
    \
    \ @brief OTG_Host periodic transmit FIFO/queue status register
    \ Address offset: 0x410
    \ Reset value: 0x00080100
    \
    $00 constant OTG_PTXFSAVL                   \ [0x00 : 16] Periodic transmit data FIFO space available Indicates the number of free locations available to be written to in the periodic Tx FIFO. Values are in terms of 32-bit words bxn: n words available (where 0 â¤ n â¤ PTXFD) Others: Reserved
    $10 constant OTG_PTXQSAV                    \ [0x10 : 8] Periodic transmit request queue space available Indicates the number of free locations available to be written in the periodic transmit request queue. This queue holds both IN and OUT requests. Others: Reserved
    $18 constant OTG_PTXQTOP                    \ [0x18 : 8] Top of the periodic transmit request queue This indicates the entry in the periodic Tx request queue that is currently being processed by the MAC. This register is used for debugging. Bit 31 = 0 send in even frame Bit 31 = 1 send in odd frame Bits 30:27: Channel/endpoint number Bits 26:25 = 00: Type IN/OUT Bits 26:25 = 01: Type Zero-length packet Bits 26:25 = 11: disable channel command Bit 24: Terminate (last entry for the selected channel/endpoint)
  [then]


  [ifdef] OTG_OTG_HAINT_DEF
    \
    \ @brief OTG host all channels interrupt register
    \ Address offset: 0x414
    \ Reset value: 0x00000000
    \
    $00 constant OTG_HAINT                      \ [0x00 : 16] Channel interrupts One bit per channel: Bit 0 for Channel 0, bit 15 for Channel 15
  [then]


  [ifdef] OTG_OTG_HAINTMSK_DEF
    \
    \ @brief OTG host all channels interrupt mask register
    \ Address offset: 0x418
    \ Reset value: 0x00000000
    \
    $00 constant OTG_HAINTM                     \ [0x00 : 16] Channel interrupt mask One bit per channel: Bit 0 for channel 0, bit 15 for channel 15
  [then]


  [ifdef] OTG_OTG_HFLBADDR_DEF
    \
    \ @brief OTG host frame list base address register
    \ Address offset: 0x41C
    \ Reset value: 0x00000000
    \
    $00 constant OTG_HFLBADDR                   \ [0x00 : 32] The starting address of the frame list (scatter/gather mode). This register is used only for isochronous and interrupt channels.
  [then]


  [ifdef] OTG_OTG_HPRT_DEF
    \
    \ @brief OTG host port control and status register
    \ Address offset: 0x440
    \ Reset value: 0x00000000
    \
    $00 constant OTG_PCSTS                      \ [0x00] Port connect status
    $01 constant OTG_PCDET                      \ [0x01] Port connect detected The core sets this bit when a device connection is detected to trigger an interrupt to the application using the host port interrupt bit in the core interrupt register (HPRTINT bit in OTG_GINTSTS). The application must write a 1 to this bit to clear the interrupt.
    $02 constant OTG_PENA                       \ [0x02] Port enable A port is enabled only by the core after a reset sequence, and is disabled by an overcurrent condition, a disconnect condition, or by the application clearing this bit. The application cannot set this bit by a register write. It can only clear it to disable the port. This bit does not trigger any interrupt to the application.
    $03 constant OTG_PENCHNG                    \ [0x03] Port enable/disable change The core sets this bit when the status of the port enable bit 2 in this register changes.
    $04 constant OTG_POCA                       \ [0x04] Port overcurrent active Indicates the overcurrent condition of the port.
    $05 constant OTG_POCCHNG                    \ [0x05] Port overcurrent change The core sets this bit when the status of the port overcurrent active bit (bit 4) in this register changes.
    $06 constant OTG_PRES                       \ [0x06] Port resume The application sets this bit to drive resume signaling on the port. The core continues to drive the resume signal until the application clears this bit. If the core detects a USB remote wakeup sequence, as indicated by the port resume/remote wakeup detected interrupt bit of the core interrupt register (WKUPINT bit in OTG_GINTSTS), the core starts driving resume signaling without application intervention and clears this bit when it detects a disconnect condition. The read value of this bit indicates whether the core is currently driving resume signaling. When LPM is enabled and the core is in L1 state, the behavior of this bit is as follow: 1. The application sets this bit to drive resume signaling on the port. 2. The core continues to drive the resume signal until a predetermined time specified in BESLTHRS[3:0] field of OTG_GLPMCFG register. 3. If the core detects a USB remote wakeup sequence, as indicated by the port L1Resume/Remote L1Wakeup detected interrupt bit of the core interrupt register (WKUPINT in OTG_GINTSTS), the core starts driving resume signaling without application intervention and clears this bit at the end of resume.This bit can be set or cleared by both the core and the application. This bit is cleared by the core even if there is no device connected to the host.
    $07 constant OTG_PSUSP                      \ [0x07] Port suspend The application sets this bit to put this port in suspend mode. The core only stops sending SOFs when this is set. To stop the PHY clock, the application must set the port clock stop bit, which asserts the suspend input pin of the PHY. The read value of this bit reflects the current suspend status of the port. This bit is cleared by the core after a remote wakeup signal is detected or the application sets the port reset bit or port resume bit in this register or the resume/remote wakeup detected interrupt bit or disconnect detected interrupt bit in the core interrupt register (WKUPINT or DISCINT in OTG_GINTSTS, respectively).
    $08 constant OTG_PRST                       \ [0x08] Port reset When the application sets this bit, a reset sequence is started on this port. The application must time the reset period and clear this bit after the reset sequence is complete. The application must leave this bit set for a minimum duration of at least 10Â ms to start a reset on the port. The application can leave it set for another 10 ms in addition to the required minimum duration, before clearing the bit, even though there is no maximum limit set by the USB standard. High speed: 50Â ms Full speed/Low speed: 10Â ms
    $0a constant OTG_PLSTS                      \ [0x0a : 2] Port line status Indicates the current logic level USB data lines Bit 10: Logic level of OTG_DP Bit 11: Logic level of OTG_DM
    $0c constant OTG_PPWR                       \ [0x0c] Port power The application uses this field to control power to this port, and the core clears this bit on an overcurrent condition.
    $0d constant OTG_PTCTL                      \ [0x0d : 4] Port test control The application writes a nonzero value to this field to put the port into a Test mode, and the corresponding pattern is signaled on the port. Others: Reserved
    $11 constant OTG_PSPD                       \ [0x11 : 2] Port speed Indicates the speed of the device attached to this port.
  [then]


  [ifdef] OTG_OTG_HCCHAR0_DEF
    \
    \ @brief Maximum packet size Indicates the maximum packet size of the associated endpoint.
    \ Address offset: 0x500
    \ Reset value: 0x00000000
    \
    $00 constant OTG_MPSIZ                      \ [0x00 : 11] Maximum packet size Indicates the maximum packet size of the associated endpoint.
    $0b constant OTG_EPNUM                      \ [0x0b : 4] Endpoint number Indicates the endpoint number on the device serving as the data source or sink.
    $0f constant OTG_EPDIR                      \ [0x0f] Endpoint direction Indicates whether the transaction is IN or OUT.
    $11 constant OTG_LSDEV                      \ [0x11] Low-speed device This field is set by the application to indicate that this channel is communicating to a low-speed device.
    $12 constant OTG_EPTYP                      \ [0x12 : 2] Endpoint type Indicates the transfer type selected.
    $14 constant OTG_MCNT                       \ [0x14 : 2] Multicount This field indicates to the host the number of transactions that must be executed per frame for this periodic endpoint. For non-periodic transfers, this field is not used Note: This field must be set to at least 01.
    $16 constant OTG_DAD                        \ [0x16 : 7] Device address This field selects the specific device serving as the data source or sink.
    $1d constant OTG_ODDFRM                     \ [0x1d] Odd frame This field is set (reset) by the application to indicate that the OTG host must perform a transfer in an odd frame. This field is applicable for only periodic (isochronous and interrupt) transactions.
    $1e constant OTG_CHDIS                      \ [0x1e] Channel disable The application sets this bit to stop transmitting/receiving data on a channel, even before the transfer for that channel is complete. The application must wait for the Channel disabled interrupt before treating the channel as disabled.
    $1f constant OTG_CHENA                      \ [0x1f] Channel enable When Scatter/Gather mode is enabled: 1'b0: Indicates that the descriptor structure is not yet ready 1'b1: Indicates that the descriptor structure and data buffer with data is setup and this channel can access the descriptor When Scatter/Gather mode is disabled: This field is set by the application and cleared by the OTG host.
  [then]


  [ifdef] OTG_OTG_HCSPLT0_DEF
    \
    \ @brief Port address This field is the port number of the recipient transaction translator.
    \ Address offset: 0x504
    \ Reset value: 0x00000000
    \
    $00 constant OTG_PRTADDR                    \ [0x00 : 7] Port address This field is the port number of the recipient transaction translator.
    $07 constant OTG_HUBADDR                    \ [0x07 : 7] Hub address This field holds the device address of the transaction translator's hub.
    $0e constant OTG_XACTPOS                    \ [0x0e : 2] Transaction position This field is used to determine whether to send all, first, middle, or last payloads with each OUT transaction.
    $10 constant OTG_COMPLSPLT                  \ [0x10] Do complete split The application sets this bit to request the OTG host to perform a complete split transaction.
    $1f constant OTG_SPLITEN                    \ [0x1f] Split enable The application sets this bit to indicate that this channel is enabled to perform split transactions.
  [then]


  [ifdef] OTG_OTG_HCINT0_DEF
    \
    \ @brief OTG host channel 0 interrupt register
    \ Address offset: 0x508
    \ Reset value: 0x00000000
    \
    $00 constant OTG_XFRC                       \ [0x00] Transfer completed. Transfer completed normally without any errors.
    $01 constant OTG_CHH                        \ [0x01] Channel halted. In non scatter/gather DMA mode indicates the transfer completed abnormally either because of any USB transaction error or in response to disable request by the application. In scatter/gather DMA mode, this indicates that transfer completed due to any of the following: EOL being set in descriptor AHB error Excessive transaction errors In response to disable request by the application Babble Stall
    $02 constant OTG_AHBERR                     \ [0x02] AHB error This error is generated only in Internal DMA mode when an AHB error occurs during an AHB read/write operation. The application can read the corresponding DMA channel address register to get the error address.
    $03 constant OTG_STALL                      \ [0x03] STALL response received interrupt. In Scatter/Gather DMA mode, the interrupt due to this bit is masked.
    $04 constant OTG_NAK                        \ [0x04] NAK response received interrupt. In Scatter/Gather DMA mode, the interrupt due to this bit is masked.
    $05 constant OTG_ACK                        \ [0x05] ACK response received/transmitted interrupt. In Scatter/Gather DMA mode, the interrupt due to this bit is masked.
    $06 constant OTG_NYET                       \ [0x06] Not yet ready response received interrupt. In Scatter/Gather DMA mode, the interrupt due to this bit is masked.
    $07 constant OTG_TXERR                      \ [0x07] Transaction error. In Scatter/Gather DMA mode, the interrupt due to this bit is masked. Indicates one of the following errors occurred on the USB. CRC check failure Timeout Bit stuff error False EOP
    $08 constant OTG_BBERR                      \ [0x08] Babble error. In Scatter/Gather DMA mode, the interrupt due to this bit is masked.
    $09 constant OTG_FRMOR                      \ [0x09] Frame overrun. In Scatter/Gather DMA mode, the interrupt due to this bit is masked.
    $0a constant OTG_DTERR                      \ [0x0a] Data toggle error. In Scatter/Gather DMA mode, the interrupt due to this bit is masked.
    $0b constant OTG_BNA                        \ [0x0b] Buffer not available interrupt. This bit is valid only when Scatter/Gather DMA mode is enabled. The core generates this interrupt when the descriptor accessed is not ready for the core to process. BNA interrupt is not generated for isochronous channels. For non Scatter/Gather DMA mode, this bit is reserved.
    $0c constant OTG_XCSXACTERR                 \ [0x0c] Excessive transaction error. This bit is valid only when Scatter/Gather DMA mode is enabled. The core sets this bit when 3 consecutive transaction errors occurred on the USB bus. XCS_XACT_ERR is not generated for isochronous channels. For non Scatter/Gather DMA mode, this bit is reserved.
    $0d constant OTG_DESCLSTROLL                \ [0x0d] Descriptor rollover interrupt. This bit is valid only when Scatter/Gather DMA mode is enabled. The core sets this bit when the corresponding channel descriptor list rolls over. For non Scatter/Gather DMA mode, this bit is reserved.
  [then]


  [ifdef] OTG_OTG_HCINTMSK0_DEF
    \
    \ @brief OTG host channel 0 interrupt mask register
    \ Address offset: 0x50C
    \ Reset value: 0x00000000
    \
    $00 constant OTG_XFRCM                      \ [0x00] Transfer completed mask
    $01 constant OTG_CHHM                       \ [0x01] Channel halted mask
    $02 constant OTG_AHBERRM                    \ [0x02] AHB error. In scatter/gather DMA mode for host, interrupts will not be generated due to the corresponding bits set in OTG_HCINTx.
    $03 constant OTG_STALLM                     \ [0x03] STALL response received interrupt mask. In Scatter/Gather DMA mode, the interrupt due to this bit is masked.
    $04 constant OTG_NAKM                       \ [0x04] NAK response received interrupt mask. In Scatter/Gather DMA mode, the interrupt due to this bit is masked.
    $05 constant OTG_ACKM                       \ [0x05] ACK response received/transmitted interrupt mask. In Scatter/Gather DMA mode, the interrupt due to this bit is masked.
    $06 constant OTG_NYET                       \ [0x06] response received interrupt mask. In Scatter/Gather DMA mode, the interrupt due to this bit is masked.
    $07 constant OTG_TXERRM                     \ [0x07] Transaction error mask. In Scatter/Gather DMA mode, the interrupt due to this bit is masked.
    $08 constant OTG_BBERRM                     \ [0x08] Babble error mask. In Scatter/Gather DMA mode, the interrupt due to this bit is masked.
    $09 constant OTG_FRMORM                     \ [0x09] Frame overrun mask. In Scatter/Gather DMA mode, the interrupt due to this bit is masked.
    $0a constant OTG_DTERRM                     \ [0x0a] Data toggle error mask. In Scatter/Gather DMA mode, the interrupt due to this bit is masked.
    $0b constant OTG_BNAMSK                     \ [0x0b] Buffer not available interrupt mask register. This bit is valid only when Scatter/Gather DMA mode is enabled. In non Scatter/Gather DMA mode, this bit is reserved
    $0d constant OTG_DESCLSTROLLMSK             \ [0x0d] Descriptor rollover interrupt mask register. This bit is valid only when Scatter/Gather DMA mode is enabled. In non Scatter/Gather DMA mode, this bit is reserved.
  [then]


  [ifdef] OTG_OTG_HCTSIZ0_DEF
    \
    \ @brief Transfer size For an OUT, this field is the number of data bytes the host sends during the transfer. For an IN, this field is the buffer size that the application has reserved for the transfer. The application is expected to program this field as an integer multiple of the maximum packet size for IN transactions (periodic and non-periodic).
    \ Address offset: 0x510
    \ Reset value: 0x00000000
    \
    $00 constant OTG_XFRSIZ                     \ [0x00 : 19] Transfer size For an OUT, this field is the number of data bytes the host sends during the transfer. For an IN, this field is the buffer size that the application has reserved for the transfer. The application is expected to program this field as an integer multiple of the maximum packet size for IN transactions (periodic and non-periodic).
    $13 constant OTG_PKTCNT                     \ [0x13 : 10] Packet count This field is programmed by the application with the expected number of packets to be transmitted (OUT) or received (IN). The host decrements this count on every successful transmission or reception of an OUT/IN packet. Once this count reaches zero, the application is interrupted to indicate normal completion.
    $1d constant OTG_DPID                       \ [0x1d : 2] Data PID The application programs this field with the type of PID to use for the initial transaction. The host maintains this field for the rest of the transfer.
    $1f constant OTG_DOPNG                      \ [0x1f] Do Ping This bit is used only for OUT transfers. Setting this field to 1 directs the host to do PING protocol. Note: Do not set this bit for IN transfers. If this bit is set for IN transfers, it disables the channel.
  [then]


  [ifdef] OTG_OTG_HCDMA0_DEF
    \
    \ @brief DMA address This field holds the start address in the external memory from which the data for the endpoint must be fetched or to which it must be stored. This register is incremented on every AHB transaction.
    \ Address offset: 0x514
    \ Reset value: 0x00000000
    \
    $00 constant OTG_DMAADDR                    \ [0x00 : 32] DMA address This field holds the start address in the external memory from which the data for the endpoint must be fetched or to which it must be stored. This register is incremented on every AHB transaction.
  [then]


  [ifdef] OTG_OTG_HCDMAB0_DEF
    \
    \ @brief DMA address This register holds the current buffer address (scatter/gather mode).
    \ Address offset: 0x51C
    \ Reset value: 0x00000000
    \
    $00 constant OTG_HCDMAB                     \ [0x00 : 32] DMA address This register holds the current buffer address (scatter/gather mode).
  [then]


  [ifdef] OTG_OTG_HCCHAR1_DEF
    \
    \ @brief Maximum packet size Indicates the maximum packet size of the associated endpoint.
    \ Address offset: 0x520
    \ Reset value: 0x00000000
    \
    $00 constant OTG_MPSIZ                      \ [0x00 : 11] Maximum packet size Indicates the maximum packet size of the associated endpoint.
    $0b constant OTG_EPNUM                      \ [0x0b : 4] Endpoint number Indicates the endpoint number on the device serving as the data source or sink.
    $0f constant OTG_EPDIR                      \ [0x0f] Endpoint direction Indicates whether the transaction is IN or OUT.
    $11 constant OTG_LSDEV                      \ [0x11] Low-speed device This field is set by the application to indicate that this channel is communicating to a low-speed device.
    $12 constant OTG_EPTYP                      \ [0x12 : 2] Endpoint type Indicates the transfer type selected.
    $14 constant OTG_MCNT                       \ [0x14 : 2] Multicount This field indicates to the host the number of transactions that must be executed per frame for this periodic endpoint. For non-periodic transfers, this field is not used Note: This field must be set to at least 01.
    $16 constant OTG_DAD                        \ [0x16 : 7] Device address This field selects the specific device serving as the data source or sink.
    $1d constant OTG_ODDFRM                     \ [0x1d] Odd frame This field is set (reset) by the application to indicate that the OTG host must perform a transfer in an odd frame. This field is applicable for only periodic (isochronous and interrupt) transactions.
    $1e constant OTG_CHDIS                      \ [0x1e] Channel disable The application sets this bit to stop transmitting/receiving data on a channel, even before the transfer for that channel is complete. The application must wait for the Channel disabled interrupt before treating the channel as disabled.
    $1f constant OTG_CHENA                      \ [0x1f] Channel enable When Scatter/Gather mode is enabled: 1'b0: Indicates that the descriptor structure is not yet ready 1'b1: Indicates that the descriptor structure and data buffer with data is setup and this channel can access the descriptor When Scatter/Gather mode is disabled: This field is set by the application and cleared by the OTG host.
  [then]


  [ifdef] OTG_OTG_HCSPLT1_DEF
    \
    \ @brief Port address This field is the port number of the recipient transaction translator.
    \ Address offset: 0x524
    \ Reset value: 0x00000000
    \
    $00 constant OTG_PRTADDR                    \ [0x00 : 7] Port address This field is the port number of the recipient transaction translator.
    $07 constant OTG_HUBADDR                    \ [0x07 : 7] Hub address This field holds the device address of the transaction translator's hub.
    $0e constant OTG_XACTPOS                    \ [0x0e : 2] Transaction position This field is used to determine whether to send all, first, middle, or last payloads with each OUT transaction.
    $10 constant OTG_COMPLSPLT                  \ [0x10] Do complete split The application sets this bit to request the OTG host to perform a complete split transaction.
    $1f constant OTG_SPLITEN                    \ [0x1f] Split enable The application sets this bit to indicate that this channel is enabled to perform split transactions.
  [then]


  [ifdef] OTG_OTG_HCINT1_DEF
    \
    \ @brief OTG host channel 1 interrupt register
    \ Address offset: 0x528
    \ Reset value: 0x00000000
    \
    $00 constant OTG_XFRC                       \ [0x00] Transfer completed. Transfer completed normally without any errors.
    $01 constant OTG_CHH                        \ [0x01] Channel halted. In non scatter/gather DMA mode indicates the transfer completed abnormally either because of any USB transaction error or in response to disable request by the application. In scatter/gather DMA mode, this indicates that transfer completed due to any of the following: EOL being set in descriptor AHB error Excessive transaction errors In response to disable request by the application Babble Stall
    $02 constant OTG_AHBERR                     \ [0x02] AHB error This error is generated only in Internal DMA mode when an AHB error occurs during an AHB read/write operation. The application can read the corresponding DMA channel address register to get the error address.
    $03 constant OTG_STALL                      \ [0x03] STALL response received interrupt. In Scatter/Gather DMA mode, the interrupt due to this bit is masked.
    $04 constant OTG_NAK                        \ [0x04] NAK response received interrupt. In Scatter/Gather DMA mode, the interrupt due to this bit is masked.
    $05 constant OTG_ACK                        \ [0x05] ACK response received/transmitted interrupt. In Scatter/Gather DMA mode, the interrupt due to this bit is masked.
    $06 constant OTG_NYET                       \ [0x06] Not yet ready response received interrupt. In Scatter/Gather DMA mode, the interrupt due to this bit is masked.
    $07 constant OTG_TXERR                      \ [0x07] Transaction error. In Scatter/Gather DMA mode, the interrupt due to this bit is masked. Indicates one of the following errors occurred on the USB. CRC check failure Timeout Bit stuff error False EOP
    $08 constant OTG_BBERR                      \ [0x08] Babble error. In Scatter/Gather DMA mode, the interrupt due to this bit is masked.
    $09 constant OTG_FRMOR                      \ [0x09] Frame overrun. In Scatter/Gather DMA mode, the interrupt due to this bit is masked.
    $0a constant OTG_DTERR                      \ [0x0a] Data toggle error. In Scatter/Gather DMA mode, the interrupt due to this bit is masked.
    $0b constant OTG_BNA                        \ [0x0b] Buffer not available interrupt. This bit is valid only when Scatter/Gather DMA mode is enabled. The core generates this interrupt when the descriptor accessed is not ready for the core to process. BNA interrupt is not generated for isochronous channels. For non Scatter/Gather DMA mode, this bit is reserved.
    $0c constant OTG_XCSXACTERR                 \ [0x0c] Excessive transaction error. This bit is valid only when Scatter/Gather DMA mode is enabled. The core sets this bit when 3 consecutive transaction errors occurred on the USB bus. XCS_XACT_ERR is not generated for isochronous channels. For non Scatter/Gather DMA mode, this bit is reserved.
    $0d constant OTG_DESCLSTROLL                \ [0x0d] Descriptor rollover interrupt. This bit is valid only when Scatter/Gather DMA mode is enabled. The core sets this bit when the corresponding channel descriptor list rolls over. For non Scatter/Gather DMA mode, this bit is reserved.
  [then]


  [ifdef] OTG_OTG_HCINTMSK1_DEF
    \
    \ @brief OTG host channel 1 interrupt mask register
    \ Address offset: 0x52C
    \ Reset value: 0x00000000
    \
    $00 constant OTG_XFRCM                      \ [0x00] Transfer completed mask
    $01 constant OTG_CHHM                       \ [0x01] Channel halted mask
    $02 constant OTG_AHBERRM                    \ [0x02] AHB error. In scatter/gather DMA mode for host, interrupts will not be generated due to the corresponding bits set in OTG_HCINTx.
    $03 constant OTG_STALLM                     \ [0x03] STALL response received interrupt mask. In Scatter/Gather DMA mode, the interrupt due to this bit is masked.
    $04 constant OTG_NAKM                       \ [0x04] NAK response received interrupt mask. In Scatter/Gather DMA mode, the interrupt due to this bit is masked.
    $05 constant OTG_ACKM                       \ [0x05] ACK response received/transmitted interrupt mask. In Scatter/Gather DMA mode, the interrupt due to this bit is masked.
    $06 constant OTG_NYET                       \ [0x06] response received interrupt mask. In Scatter/Gather DMA mode, the interrupt due to this bit is masked.
    $07 constant OTG_TXERRM                     \ [0x07] Transaction error mask. In Scatter/Gather DMA mode, the interrupt due to this bit is masked.
    $08 constant OTG_BBERRM                     \ [0x08] Babble error mask. In Scatter/Gather DMA mode, the interrupt due to this bit is masked.
    $09 constant OTG_FRMORM                     \ [0x09] Frame overrun mask. In Scatter/Gather DMA mode, the interrupt due to this bit is masked.
    $0a constant OTG_DTERRM                     \ [0x0a] Data toggle error mask. In Scatter/Gather DMA mode, the interrupt due to this bit is masked.
    $0b constant OTG_BNAMSK                     \ [0x0b] Buffer not available interrupt mask register. This bit is valid only when Scatter/Gather DMA mode is enabled. In non Scatter/Gather DMA mode, this bit is reserved
    $0d constant OTG_DESCLSTROLLMSK             \ [0x0d] Descriptor rollover interrupt mask register. This bit is valid only when Scatter/Gather DMA mode is enabled. In non Scatter/Gather DMA mode, this bit is reserved.
  [then]


  [ifdef] OTG_OTG_HCTSIZ1_DEF
    \
    \ @brief Transfer size For an OUT, this field is the number of data bytes the host sends during the transfer. For an IN, this field is the buffer size that the application has reserved for the transfer. The application is expected to program this field as an integer multiple of the maximum packet size for IN transactions (periodic and non-periodic).
    \ Address offset: 0x530
    \ Reset value: 0x00000000
    \
    $00 constant OTG_XFRSIZ                     \ [0x00 : 19] Transfer size For an OUT, this field is the number of data bytes the host sends during the transfer. For an IN, this field is the buffer size that the application has reserved for the transfer. The application is expected to program this field as an integer multiple of the maximum packet size for IN transactions (periodic and non-periodic).
    $13 constant OTG_PKTCNT                     \ [0x13 : 10] Packet count This field is programmed by the application with the expected number of packets to be transmitted (OUT) or received (IN). The host decrements this count on every successful transmission or reception of an OUT/IN packet. Once this count reaches zero, the application is interrupted to indicate normal completion.
    $1d constant OTG_DPID                       \ [0x1d : 2] Data PID The application programs this field with the type of PID to use for the initial transaction. The host maintains this field for the rest of the transfer.
    $1f constant OTG_DOPNG                      \ [0x1f] Do Ping This bit is used only for OUT transfers. Setting this field to 1 directs the host to do PING protocol. Note: Do not set this bit for IN transfers. If this bit is set for IN transfers, it disables the channel.
  [then]


  [ifdef] OTG_OTG_HCDMA1_DEF
    \
    \ @brief DMA address This field holds the start address in the external memory from which the data for the endpoint must be fetched or to which it must be stored. This register is incremented on every AHB transaction.
    \ Address offset: 0x534
    \ Reset value: 0x00000000
    \
    $00 constant OTG_DMAADDR                    \ [0x00 : 32] DMA address This field holds the start address in the external memory from which the data for the endpoint must be fetched or to which it must be stored. This register is incremented on every AHB transaction.
  [then]


  [ifdef] OTG_OTG_HCDMAB1_DEF
    \
    \ @brief DMA address This register holds the current buffer address (scatter/gather mode).
    \ Address offset: 0x53C
    \ Reset value: 0x00000000
    \
    $00 constant OTG_HCDMAB                     \ [0x00 : 32] DMA address This register holds the current buffer address (scatter/gather mode).
  [then]


  [ifdef] OTG_OTG_HCCHAR2_DEF
    \
    \ @brief Maximum packet size Indicates the maximum packet size of the associated endpoint.
    \ Address offset: 0x540
    \ Reset value: 0x00000000
    \
    $00 constant OTG_MPSIZ                      \ [0x00 : 11] Maximum packet size Indicates the maximum packet size of the associated endpoint.
    $0b constant OTG_EPNUM                      \ [0x0b : 4] Endpoint number Indicates the endpoint number on the device serving as the data source or sink.
    $0f constant OTG_EPDIR                      \ [0x0f] Endpoint direction Indicates whether the transaction is IN or OUT.
    $11 constant OTG_LSDEV                      \ [0x11] Low-speed device This field is set by the application to indicate that this channel is communicating to a low-speed device.
    $12 constant OTG_EPTYP                      \ [0x12 : 2] Endpoint type Indicates the transfer type selected.
    $14 constant OTG_MCNT                       \ [0x14 : 2] Multicount This field indicates to the host the number of transactions that must be executed per frame for this periodic endpoint. For non-periodic transfers, this field is not used Note: This field must be set to at least 01.
    $16 constant OTG_DAD                        \ [0x16 : 7] Device address This field selects the specific device serving as the data source or sink.
    $1d constant OTG_ODDFRM                     \ [0x1d] Odd frame This field is set (reset) by the application to indicate that the OTG host must perform a transfer in an odd frame. This field is applicable for only periodic (isochronous and interrupt) transactions.
    $1e constant OTG_CHDIS                      \ [0x1e] Channel disable The application sets this bit to stop transmitting/receiving data on a channel, even before the transfer for that channel is complete. The application must wait for the Channel disabled interrupt before treating the channel as disabled.
    $1f constant OTG_CHENA                      \ [0x1f] Channel enable When Scatter/Gather mode is enabled: 1'b0: Indicates that the descriptor structure is not yet ready 1'b1: Indicates that the descriptor structure and data buffer with data is setup and this channel can access the descriptor When Scatter/Gather mode is disabled: This field is set by the application and cleared by the OTG host.
  [then]


  [ifdef] OTG_OTG_HCSPLT2_DEF
    \
    \ @brief Port address This field is the port number of the recipient transaction translator.
    \ Address offset: 0x544
    \ Reset value: 0x00000000
    \
    $00 constant OTG_PRTADDR                    \ [0x00 : 7] Port address This field is the port number of the recipient transaction translator.
    $07 constant OTG_HUBADDR                    \ [0x07 : 7] Hub address This field holds the device address of the transaction translator's hub.
    $0e constant OTG_XACTPOS                    \ [0x0e : 2] Transaction position This field is used to determine whether to send all, first, middle, or last payloads with each OUT transaction.
    $10 constant OTG_COMPLSPLT                  \ [0x10] Do complete split The application sets this bit to request the OTG host to perform a complete split transaction.
    $1f constant OTG_SPLITEN                    \ [0x1f] Split enable The application sets this bit to indicate that this channel is enabled to perform split transactions.
  [then]


  [ifdef] OTG_OTG_HCINT2_DEF
    \
    \ @brief OTG host channel 2 interrupt register
    \ Address offset: 0x548
    \ Reset value: 0x00000000
    \
    $00 constant OTG_XFRC                       \ [0x00] Transfer completed. Transfer completed normally without any errors.
    $01 constant OTG_CHH                        \ [0x01] Channel halted. In non scatter/gather DMA mode indicates the transfer completed abnormally either because of any USB transaction error or in response to disable request by the application. In scatter/gather DMA mode, this indicates that transfer completed due to any of the following: EOL being set in descriptor AHB error Excessive transaction errors In response to disable request by the application Babble Stall
    $02 constant OTG_AHBERR                     \ [0x02] AHB error This error is generated only in Internal DMA mode when an AHB error occurs during an AHB read/write operation. The application can read the corresponding DMA channel address register to get the error address.
    $03 constant OTG_STALL                      \ [0x03] STALL response received interrupt. In Scatter/Gather DMA mode, the interrupt due to this bit is masked.
    $04 constant OTG_NAK                        \ [0x04] NAK response received interrupt. In Scatter/Gather DMA mode, the interrupt due to this bit is masked.
    $05 constant OTG_ACK                        \ [0x05] ACK response received/transmitted interrupt. In Scatter/Gather DMA mode, the interrupt due to this bit is masked.
    $06 constant OTG_NYET                       \ [0x06] Not yet ready response received interrupt. In Scatter/Gather DMA mode, the interrupt due to this bit is masked.
    $07 constant OTG_TXERR                      \ [0x07] Transaction error. In Scatter/Gather DMA mode, the interrupt due to this bit is masked. Indicates one of the following errors occurred on the USB. CRC check failure Timeout Bit stuff error False EOP
    $08 constant OTG_BBERR                      \ [0x08] Babble error. In Scatter/Gather DMA mode, the interrupt due to this bit is masked.
    $09 constant OTG_FRMOR                      \ [0x09] Frame overrun. In Scatter/Gather DMA mode, the interrupt due to this bit is masked.
    $0a constant OTG_DTERR                      \ [0x0a] Data toggle error. In Scatter/Gather DMA mode, the interrupt due to this bit is masked.
    $0b constant OTG_BNA                        \ [0x0b] Buffer not available interrupt. This bit is valid only when Scatter/Gather DMA mode is enabled. The core generates this interrupt when the descriptor accessed is not ready for the core to process. BNA interrupt is not generated for isochronous channels. For non Scatter/Gather DMA mode, this bit is reserved.
    $0c constant OTG_XCSXACTERR                 \ [0x0c] Excessive transaction error. This bit is valid only when Scatter/Gather DMA mode is enabled. The core sets this bit when 3 consecutive transaction errors occurred on the USB bus. XCS_XACT_ERR is not generated for isochronous channels. For non Scatter/Gather DMA mode, this bit is reserved.
    $0d constant OTG_DESCLSTROLL                \ [0x0d] Descriptor rollover interrupt. This bit is valid only when Scatter/Gather DMA mode is enabled. The core sets this bit when the corresponding channel descriptor list rolls over. For non Scatter/Gather DMA mode, this bit is reserved.
  [then]


  [ifdef] OTG_OTG_HCINTMSK2_DEF
    \
    \ @brief OTG host channel 2 interrupt mask register
    \ Address offset: 0x54C
    \ Reset value: 0x00000000
    \
    $00 constant OTG_XFRCM                      \ [0x00] Transfer completed mask
    $01 constant OTG_CHHM                       \ [0x01] Channel halted mask
    $02 constant OTG_AHBERRM                    \ [0x02] AHB error. In scatter/gather DMA mode for host, interrupts will not be generated due to the corresponding bits set in OTG_HCINTx.
    $03 constant OTG_STALLM                     \ [0x03] STALL response received interrupt mask. In Scatter/Gather DMA mode, the interrupt due to this bit is masked.
    $04 constant OTG_NAKM                       \ [0x04] NAK response received interrupt mask. In Scatter/Gather DMA mode, the interrupt due to this bit is masked.
    $05 constant OTG_ACKM                       \ [0x05] ACK response received/transmitted interrupt mask. In Scatter/Gather DMA mode, the interrupt due to this bit is masked.
    $06 constant OTG_NYET                       \ [0x06] response received interrupt mask. In Scatter/Gather DMA mode, the interrupt due to this bit is masked.
    $07 constant OTG_TXERRM                     \ [0x07] Transaction error mask. In Scatter/Gather DMA mode, the interrupt due to this bit is masked.
    $08 constant OTG_BBERRM                     \ [0x08] Babble error mask. In Scatter/Gather DMA mode, the interrupt due to this bit is masked.
    $09 constant OTG_FRMORM                     \ [0x09] Frame overrun mask. In Scatter/Gather DMA mode, the interrupt due to this bit is masked.
    $0a constant OTG_DTERRM                     \ [0x0a] Data toggle error mask. In Scatter/Gather DMA mode, the interrupt due to this bit is masked.
    $0b constant OTG_BNAMSK                     \ [0x0b] Buffer not available interrupt mask register. This bit is valid only when Scatter/Gather DMA mode is enabled. In non Scatter/Gather DMA mode, this bit is reserved
    $0d constant OTG_DESCLSTROLLMSK             \ [0x0d] Descriptor rollover interrupt mask register. This bit is valid only when Scatter/Gather DMA mode is enabled. In non Scatter/Gather DMA mode, this bit is reserved.
  [then]


  [ifdef] OTG_OTG_HCTSIZ2_DEF
    \
    \ @brief Transfer size For an OUT, this field is the number of data bytes the host sends during the transfer. For an IN, this field is the buffer size that the application has reserved for the transfer. The application is expected to program this field as an integer multiple of the maximum packet size for IN transactions (periodic and non-periodic).
    \ Address offset: 0x550
    \ Reset value: 0x00000000
    \
    $00 constant OTG_XFRSIZ                     \ [0x00 : 19] Transfer size For an OUT, this field is the number of data bytes the host sends during the transfer. For an IN, this field is the buffer size that the application has reserved for the transfer. The application is expected to program this field as an integer multiple of the maximum packet size for IN transactions (periodic and non-periodic).
    $13 constant OTG_PKTCNT                     \ [0x13 : 10] Packet count This field is programmed by the application with the expected number of packets to be transmitted (OUT) or received (IN). The host decrements this count on every successful transmission or reception of an OUT/IN packet. Once this count reaches zero, the application is interrupted to indicate normal completion.
    $1d constant OTG_DPID                       \ [0x1d : 2] Data PID The application programs this field with the type of PID to use for the initial transaction. The host maintains this field for the rest of the transfer.
    $1f constant OTG_DOPNG                      \ [0x1f] Do Ping This bit is used only for OUT transfers. Setting this field to 1 directs the host to do PING protocol. Note: Do not set this bit for IN transfers. If this bit is set for IN transfers, it disables the channel.
  [then]


  [ifdef] OTG_OTG_HCDMA2_DEF
    \
    \ @brief DMA address This field holds the start address in the external memory from which the data for the endpoint must be fetched or to which it must be stored. This register is incremented on every AHB transaction.
    \ Address offset: 0x554
    \ Reset value: 0x00000000
    \
    $00 constant OTG_DMAADDR                    \ [0x00 : 32] DMA address This field holds the start address in the external memory from which the data for the endpoint must be fetched or to which it must be stored. This register is incremented on every AHB transaction.
  [then]


  [ifdef] OTG_OTG_HCDMAB2_DEF
    \
    \ @brief DMA address This register holds the current buffer address (scatter/gather mode).
    \ Address offset: 0x55C
    \ Reset value: 0x00000000
    \
    $00 constant OTG_HCDMAB                     \ [0x00 : 32] DMA address This register holds the current buffer address (scatter/gather mode).
  [then]


  [ifdef] OTG_OTG_HCCHAR3_DEF
    \
    \ @brief Maximum packet size Indicates the maximum packet size of the associated endpoint.
    \ Address offset: 0x560
    \ Reset value: 0x00000000
    \
    $00 constant OTG_MPSIZ                      \ [0x00 : 11] Maximum packet size Indicates the maximum packet size of the associated endpoint.
    $0b constant OTG_EPNUM                      \ [0x0b : 4] Endpoint number Indicates the endpoint number on the device serving as the data source or sink.
    $0f constant OTG_EPDIR                      \ [0x0f] Endpoint direction Indicates whether the transaction is IN or OUT.
    $11 constant OTG_LSDEV                      \ [0x11] Low-speed device This field is set by the application to indicate that this channel is communicating to a low-speed device.
    $12 constant OTG_EPTYP                      \ [0x12 : 2] Endpoint type Indicates the transfer type selected.
    $14 constant OTG_MCNT                       \ [0x14 : 2] Multicount This field indicates to the host the number of transactions that must be executed per frame for this periodic endpoint. For non-periodic transfers, this field is not used Note: This field must be set to at least 01.
    $16 constant OTG_DAD                        \ [0x16 : 7] Device address This field selects the specific device serving as the data source or sink.
    $1d constant OTG_ODDFRM                     \ [0x1d] Odd frame This field is set (reset) by the application to indicate that the OTG host must perform a transfer in an odd frame. This field is applicable for only periodic (isochronous and interrupt) transactions.
    $1e constant OTG_CHDIS                      \ [0x1e] Channel disable The application sets this bit to stop transmitting/receiving data on a channel, even before the transfer for that channel is complete. The application must wait for the Channel disabled interrupt before treating the channel as disabled.
    $1f constant OTG_CHENA                      \ [0x1f] Channel enable When Scatter/Gather mode is enabled: 1'b0: Indicates that the descriptor structure is not yet ready 1'b1: Indicates that the descriptor structure and data buffer with data is setup and this channel can access the descriptor When Scatter/Gather mode is disabled: This field is set by the application and cleared by the OTG host.
  [then]


  [ifdef] OTG_OTG_HCSPLT3_DEF
    \
    \ @brief Port address This field is the port number of the recipient transaction translator.
    \ Address offset: 0x564
    \ Reset value: 0x00000000
    \
    $00 constant OTG_PRTADDR                    \ [0x00 : 7] Port address This field is the port number of the recipient transaction translator.
    $07 constant OTG_HUBADDR                    \ [0x07 : 7] Hub address This field holds the device address of the transaction translator's hub.
    $0e constant OTG_XACTPOS                    \ [0x0e : 2] Transaction position This field is used to determine whether to send all, first, middle, or last payloads with each OUT transaction.
    $10 constant OTG_COMPLSPLT                  \ [0x10] Do complete split The application sets this bit to request the OTG host to perform a complete split transaction.
    $1f constant OTG_SPLITEN                    \ [0x1f] Split enable The application sets this bit to indicate that this channel is enabled to perform split transactions.
  [then]


  [ifdef] OTG_OTG_HCINT3_DEF
    \
    \ @brief OTG host channel 3 interrupt register
    \ Address offset: 0x568
    \ Reset value: 0x00000000
    \
    $00 constant OTG_XFRC                       \ [0x00] Transfer completed. Transfer completed normally without any errors.
    $01 constant OTG_CHH                        \ [0x01] Channel halted. In non scatter/gather DMA mode indicates the transfer completed abnormally either because of any USB transaction error or in response to disable request by the application. In scatter/gather DMA mode, this indicates that transfer completed due to any of the following: EOL being set in descriptor AHB error Excessive transaction errors In response to disable request by the application Babble Stall
    $02 constant OTG_AHBERR                     \ [0x02] AHB error This error is generated only in Internal DMA mode when an AHB error occurs during an AHB read/write operation. The application can read the corresponding DMA channel address register to get the error address.
    $03 constant OTG_STALL                      \ [0x03] STALL response received interrupt. In Scatter/Gather DMA mode, the interrupt due to this bit is masked.
    $04 constant OTG_NAK                        \ [0x04] NAK response received interrupt. In Scatter/Gather DMA mode, the interrupt due to this bit is masked.
    $05 constant OTG_ACK                        \ [0x05] ACK response received/transmitted interrupt. In Scatter/Gather DMA mode, the interrupt due to this bit is masked.
    $06 constant OTG_NYET                       \ [0x06] Not yet ready response received interrupt. In Scatter/Gather DMA mode, the interrupt due to this bit is masked.
    $07 constant OTG_TXERR                      \ [0x07] Transaction error. In Scatter/Gather DMA mode, the interrupt due to this bit is masked. Indicates one of the following errors occurred on the USB. CRC check failure Timeout Bit stuff error False EOP
    $08 constant OTG_BBERR                      \ [0x08] Babble error. In Scatter/Gather DMA mode, the interrupt due to this bit is masked.
    $09 constant OTG_FRMOR                      \ [0x09] Frame overrun. In Scatter/Gather DMA mode, the interrupt due to this bit is masked.
    $0a constant OTG_DTERR                      \ [0x0a] Data toggle error. In Scatter/Gather DMA mode, the interrupt due to this bit is masked.
    $0b constant OTG_BNA                        \ [0x0b] Buffer not available interrupt. This bit is valid only when Scatter/Gather DMA mode is enabled. The core generates this interrupt when the descriptor accessed is not ready for the core to process. BNA interrupt is not generated for isochronous channels. For non Scatter/Gather DMA mode, this bit is reserved.
    $0c constant OTG_XCSXACTERR                 \ [0x0c] Excessive transaction error. This bit is valid only when Scatter/Gather DMA mode is enabled. The core sets this bit when 3 consecutive transaction errors occurred on the USB bus. XCS_XACT_ERR is not generated for isochronous channels. For non Scatter/Gather DMA mode, this bit is reserved.
    $0d constant OTG_DESCLSTROLL                \ [0x0d] Descriptor rollover interrupt. This bit is valid only when Scatter/Gather DMA mode is enabled. The core sets this bit when the corresponding channel descriptor list rolls over. For non Scatter/Gather DMA mode, this bit is reserved.
  [then]


  [ifdef] OTG_OTG_HCINTMSK3_DEF
    \
    \ @brief OTG host channel 3 interrupt mask register
    \ Address offset: 0x56C
    \ Reset value: 0x00000000
    \
    $00 constant OTG_XFRCM                      \ [0x00] Transfer completed mask
    $01 constant OTG_CHHM                       \ [0x01] Channel halted mask
    $02 constant OTG_AHBERRM                    \ [0x02] AHB error. In scatter/gather DMA mode for host, interrupts will not be generated due to the corresponding bits set in OTG_HCINTx.
    $03 constant OTG_STALLM                     \ [0x03] STALL response received interrupt mask. In Scatter/Gather DMA mode, the interrupt due to this bit is masked.
    $04 constant OTG_NAKM                       \ [0x04] NAK response received interrupt mask. In Scatter/Gather DMA mode, the interrupt due to this bit is masked.
    $05 constant OTG_ACKM                       \ [0x05] ACK response received/transmitted interrupt mask. In Scatter/Gather DMA mode, the interrupt due to this bit is masked.
    $06 constant OTG_NYET                       \ [0x06] response received interrupt mask. In Scatter/Gather DMA mode, the interrupt due to this bit is masked.
    $07 constant OTG_TXERRM                     \ [0x07] Transaction error mask. In Scatter/Gather DMA mode, the interrupt due to this bit is masked.
    $08 constant OTG_BBERRM                     \ [0x08] Babble error mask. In Scatter/Gather DMA mode, the interrupt due to this bit is masked.
    $09 constant OTG_FRMORM                     \ [0x09] Frame overrun mask. In Scatter/Gather DMA mode, the interrupt due to this bit is masked.
    $0a constant OTG_DTERRM                     \ [0x0a] Data toggle error mask. In Scatter/Gather DMA mode, the interrupt due to this bit is masked.
    $0b constant OTG_BNAMSK                     \ [0x0b] Buffer not available interrupt mask register. This bit is valid only when Scatter/Gather DMA mode is enabled. In non Scatter/Gather DMA mode, this bit is reserved
    $0d constant OTG_DESCLSTROLLMSK             \ [0x0d] Descriptor rollover interrupt mask register. This bit is valid only when Scatter/Gather DMA mode is enabled. In non Scatter/Gather DMA mode, this bit is reserved.
  [then]


  [ifdef] OTG_OTG_HCTSIZ3_DEF
    \
    \ @brief Transfer size For an OUT, this field is the number of data bytes the host sends during the transfer. For an IN, this field is the buffer size that the application has reserved for the transfer. The application is expected to program this field as an integer multiple of the maximum packet size for IN transactions (periodic and non-periodic).
    \ Address offset: 0x570
    \ Reset value: 0x00000000
    \
    $00 constant OTG_XFRSIZ                     \ [0x00 : 19] Transfer size For an OUT, this field is the number of data bytes the host sends during the transfer. For an IN, this field is the buffer size that the application has reserved for the transfer. The application is expected to program this field as an integer multiple of the maximum packet size for IN transactions (periodic and non-periodic).
    $13 constant OTG_PKTCNT                     \ [0x13 : 10] Packet count This field is programmed by the application with the expected number of packets to be transmitted (OUT) or received (IN). The host decrements this count on every successful transmission or reception of an OUT/IN packet. Once this count reaches zero, the application is interrupted to indicate normal completion.
    $1d constant OTG_DPID                       \ [0x1d : 2] Data PID The application programs this field with the type of PID to use for the initial transaction. The host maintains this field for the rest of the transfer.
    $1f constant OTG_DOPNG                      \ [0x1f] Do Ping This bit is used only for OUT transfers. Setting this field to 1 directs the host to do PING protocol. Note: Do not set this bit for IN transfers. If this bit is set for IN transfers, it disables the channel.
  [then]


  [ifdef] OTG_OTG_HCDMA3_DEF
    \
    \ @brief DMA address This field holds the start address in the external memory from which the data for the endpoint must be fetched or to which it must be stored. This register is incremented on every AHB transaction.
    \ Address offset: 0x574
    \ Reset value: 0x00000000
    \
    $00 constant OTG_DMAADDR                    \ [0x00 : 32] DMA address This field holds the start address in the external memory from which the data for the endpoint must be fetched or to which it must be stored. This register is incremented on every AHB transaction.
  [then]


  [ifdef] OTG_OTG_HCDMAB3_DEF
    \
    \ @brief DMA address This register holds the current buffer address (scatter/gather mode).
    \ Address offset: 0x57C
    \ Reset value: 0x00000000
    \
    $00 constant OTG_HCDMAB                     \ [0x00 : 32] DMA address This register holds the current buffer address (scatter/gather mode).
  [then]


  [ifdef] OTG_OTG_HCCHAR4_DEF
    \
    \ @brief Maximum packet size Indicates the maximum packet size of the associated endpoint.
    \ Address offset: 0x580
    \ Reset value: 0x00000000
    \
    $00 constant OTG_MPSIZ                      \ [0x00 : 11] Maximum packet size Indicates the maximum packet size of the associated endpoint.
    $0b constant OTG_EPNUM                      \ [0x0b : 4] Endpoint number Indicates the endpoint number on the device serving as the data source or sink.
    $0f constant OTG_EPDIR                      \ [0x0f] Endpoint direction Indicates whether the transaction is IN or OUT.
    $11 constant OTG_LSDEV                      \ [0x11] Low-speed device This field is set by the application to indicate that this channel is communicating to a low-speed device.
    $12 constant OTG_EPTYP                      \ [0x12 : 2] Endpoint type Indicates the transfer type selected.
    $14 constant OTG_MCNT                       \ [0x14 : 2] Multicount This field indicates to the host the number of transactions that must be executed per frame for this periodic endpoint. For non-periodic transfers, this field is not used Note: This field must be set to at least 01.
    $16 constant OTG_DAD                        \ [0x16 : 7] Device address This field selects the specific device serving as the data source or sink.
    $1d constant OTG_ODDFRM                     \ [0x1d] Odd frame This field is set (reset) by the application to indicate that the OTG host must perform a transfer in an odd frame. This field is applicable for only periodic (isochronous and interrupt) transactions.
    $1e constant OTG_CHDIS                      \ [0x1e] Channel disable The application sets this bit to stop transmitting/receiving data on a channel, even before the transfer for that channel is complete. The application must wait for the Channel disabled interrupt before treating the channel as disabled.
    $1f constant OTG_CHENA                      \ [0x1f] Channel enable When Scatter/Gather mode is enabled: 1'b0: Indicates that the descriptor structure is not yet ready 1'b1: Indicates that the descriptor structure and data buffer with data is setup and this channel can access the descriptor When Scatter/Gather mode is disabled: This field is set by the application and cleared by the OTG host.
  [then]


  [ifdef] OTG_OTG_HCSPLT4_DEF
    \
    \ @brief Port address This field is the port number of the recipient transaction translator.
    \ Address offset: 0x584
    \ Reset value: 0x00000000
    \
    $00 constant OTG_PRTADDR                    \ [0x00 : 7] Port address This field is the port number of the recipient transaction translator.
    $07 constant OTG_HUBADDR                    \ [0x07 : 7] Hub address This field holds the device address of the transaction translator's hub.
    $0e constant OTG_XACTPOS                    \ [0x0e : 2] Transaction position This field is used to determine whether to send all, first, middle, or last payloads with each OUT transaction.
    $10 constant OTG_COMPLSPLT                  \ [0x10] Do complete split The application sets this bit to request the OTG host to perform a complete split transaction.
    $1f constant OTG_SPLITEN                    \ [0x1f] Split enable The application sets this bit to indicate that this channel is enabled to perform split transactions.
  [then]


  [ifdef] OTG_OTG_HCINT4_DEF
    \
    \ @brief OTG host channel 4 interrupt register
    \ Address offset: 0x588
    \ Reset value: 0x00000000
    \
    $00 constant OTG_XFRC                       \ [0x00] Transfer completed. Transfer completed normally without any errors.
    $01 constant OTG_CHH                        \ [0x01] Channel halted. In non scatter/gather DMA mode indicates the transfer completed abnormally either because of any USB transaction error or in response to disable request by the application. In scatter/gather DMA mode, this indicates that transfer completed due to any of the following: EOL being set in descriptor AHB error Excessive transaction errors In response to disable request by the application Babble Stall
    $02 constant OTG_AHBERR                     \ [0x02] AHB error This error is generated only in Internal DMA mode when an AHB error occurs during an AHB read/write operation. The application can read the corresponding DMA channel address register to get the error address.
    $03 constant OTG_STALL                      \ [0x03] STALL response received interrupt. In Scatter/Gather DMA mode, the interrupt due to this bit is masked.
    $04 constant OTG_NAK                        \ [0x04] NAK response received interrupt. In Scatter/Gather DMA mode, the interrupt due to this bit is masked.
    $05 constant OTG_ACK                        \ [0x05] ACK response received/transmitted interrupt. In Scatter/Gather DMA mode, the interrupt due to this bit is masked.
    $06 constant OTG_NYET                       \ [0x06] Not yet ready response received interrupt. In Scatter/Gather DMA mode, the interrupt due to this bit is masked.
    $07 constant OTG_TXERR                      \ [0x07] Transaction error. In Scatter/Gather DMA mode, the interrupt due to this bit is masked. Indicates one of the following errors occurred on the USB. CRC check failure Timeout Bit stuff error False EOP
    $08 constant OTG_BBERR                      \ [0x08] Babble error. In Scatter/Gather DMA mode, the interrupt due to this bit is masked.
    $09 constant OTG_FRMOR                      \ [0x09] Frame overrun. In Scatter/Gather DMA mode, the interrupt due to this bit is masked.
    $0a constant OTG_DTERR                      \ [0x0a] Data toggle error. In Scatter/Gather DMA mode, the interrupt due to this bit is masked.
    $0b constant OTG_BNA                        \ [0x0b] Buffer not available interrupt. This bit is valid only when Scatter/Gather DMA mode is enabled. The core generates this interrupt when the descriptor accessed is not ready for the core to process. BNA interrupt is not generated for isochronous channels. For non Scatter/Gather DMA mode, this bit is reserved.
    $0c constant OTG_XCSXACTERR                 \ [0x0c] Excessive transaction error. This bit is valid only when Scatter/Gather DMA mode is enabled. The core sets this bit when 3 consecutive transaction errors occurred on the USB bus. XCS_XACT_ERR is not generated for isochronous channels. For non Scatter/Gather DMA mode, this bit is reserved.
    $0d constant OTG_DESCLSTROLL                \ [0x0d] Descriptor rollover interrupt. This bit is valid only when Scatter/Gather DMA mode is enabled. The core sets this bit when the corresponding channel descriptor list rolls over. For non Scatter/Gather DMA mode, this bit is reserved.
  [then]


  [ifdef] OTG_OTG_HCINTMSK4_DEF
    \
    \ @brief OTG host channel 4 interrupt mask register
    \ Address offset: 0x58C
    \ Reset value: 0x00000000
    \
    $00 constant OTG_XFRCM                      \ [0x00] Transfer completed mask
    $01 constant OTG_CHHM                       \ [0x01] Channel halted mask
    $02 constant OTG_AHBERRM                    \ [0x02] AHB error. In scatter/gather DMA mode for host, interrupts will not be generated due to the corresponding bits set in OTG_HCINTx.
    $03 constant OTG_STALLM                     \ [0x03] STALL response received interrupt mask. In Scatter/Gather DMA mode, the interrupt due to this bit is masked.
    $04 constant OTG_NAKM                       \ [0x04] NAK response received interrupt mask. In Scatter/Gather DMA mode, the interrupt due to this bit is masked.
    $05 constant OTG_ACKM                       \ [0x05] ACK response received/transmitted interrupt mask. In Scatter/Gather DMA mode, the interrupt due to this bit is masked.
    $06 constant OTG_NYET                       \ [0x06] response received interrupt mask. In Scatter/Gather DMA mode, the interrupt due to this bit is masked.
    $07 constant OTG_TXERRM                     \ [0x07] Transaction error mask. In Scatter/Gather DMA mode, the interrupt due to this bit is masked.
    $08 constant OTG_BBERRM                     \ [0x08] Babble error mask. In Scatter/Gather DMA mode, the interrupt due to this bit is masked.
    $09 constant OTG_FRMORM                     \ [0x09] Frame overrun mask. In Scatter/Gather DMA mode, the interrupt due to this bit is masked.
    $0a constant OTG_DTERRM                     \ [0x0a] Data toggle error mask. In Scatter/Gather DMA mode, the interrupt due to this bit is masked.
    $0b constant OTG_BNAMSK                     \ [0x0b] Buffer not available interrupt mask register. This bit is valid only when Scatter/Gather DMA mode is enabled. In non Scatter/Gather DMA mode, this bit is reserved
    $0d constant OTG_DESCLSTROLLMSK             \ [0x0d] Descriptor rollover interrupt mask register. This bit is valid only when Scatter/Gather DMA mode is enabled. In non Scatter/Gather DMA mode, this bit is reserved.
  [then]


  [ifdef] OTG_OTG_HCTSIZ4_DEF
    \
    \ @brief Transfer size For an OUT, this field is the number of data bytes the host sends during the transfer. For an IN, this field is the buffer size that the application has reserved for the transfer. The application is expected to program this field as an integer multiple of the maximum packet size for IN transactions (periodic and non-periodic).
    \ Address offset: 0x590
    \ Reset value: 0x00000000
    \
    $00 constant OTG_XFRSIZ                     \ [0x00 : 19] Transfer size For an OUT, this field is the number of data bytes the host sends during the transfer. For an IN, this field is the buffer size that the application has reserved for the transfer. The application is expected to program this field as an integer multiple of the maximum packet size for IN transactions (periodic and non-periodic).
    $13 constant OTG_PKTCNT                     \ [0x13 : 10] Packet count This field is programmed by the application with the expected number of packets to be transmitted (OUT) or received (IN). The host decrements this count on every successful transmission or reception of an OUT/IN packet. Once this count reaches zero, the application is interrupted to indicate normal completion.
    $1d constant OTG_DPID                       \ [0x1d : 2] Data PID The application programs this field with the type of PID to use for the initial transaction. The host maintains this field for the rest of the transfer.
    $1f constant OTG_DOPNG                      \ [0x1f] Do Ping This bit is used only for OUT transfers. Setting this field to 1 directs the host to do PING protocol. Note: Do not set this bit for IN transfers. If this bit is set for IN transfers, it disables the channel.
  [then]


  [ifdef] OTG_OTG_HCDMA4_DEF
    \
    \ @brief DMA address This field holds the start address in the external memory from which the data for the endpoint must be fetched or to which it must be stored. This register is incremented on every AHB transaction.
    \ Address offset: 0x594
    \ Reset value: 0x00000000
    \
    $00 constant OTG_DMAADDR                    \ [0x00 : 32] DMA address This field holds the start address in the external memory from which the data for the endpoint must be fetched or to which it must be stored. This register is incremented on every AHB transaction.
  [then]


  [ifdef] OTG_OTG_HCDMAB4_DEF
    \
    \ @brief DMA address This register holds the current buffer address (scatter/gather mode).
    \ Address offset: 0x59C
    \ Reset value: 0x00000000
    \
    $00 constant OTG_HCDMAB                     \ [0x00 : 32] DMA address This register holds the current buffer address (scatter/gather mode).
  [then]


  [ifdef] OTG_OTG_HCCHAR5_DEF
    \
    \ @brief Maximum packet size Indicates the maximum packet size of the associated endpoint.
    \ Address offset: 0x5A0
    \ Reset value: 0x00000000
    \
    $00 constant OTG_MPSIZ                      \ [0x00 : 11] Maximum packet size Indicates the maximum packet size of the associated endpoint.
    $0b constant OTG_EPNUM                      \ [0x0b : 4] Endpoint number Indicates the endpoint number on the device serving as the data source or sink.
    $0f constant OTG_EPDIR                      \ [0x0f] Endpoint direction Indicates whether the transaction is IN or OUT.
    $11 constant OTG_LSDEV                      \ [0x11] Low-speed device This field is set by the application to indicate that this channel is communicating to a low-speed device.
    $12 constant OTG_EPTYP                      \ [0x12 : 2] Endpoint type Indicates the transfer type selected.
    $14 constant OTG_MCNT                       \ [0x14 : 2] Multicount This field indicates to the host the number of transactions that must be executed per frame for this periodic endpoint. For non-periodic transfers, this field is not used Note: This field must be set to at least 01.
    $16 constant OTG_DAD                        \ [0x16 : 7] Device address This field selects the specific device serving as the data source or sink.
    $1d constant OTG_ODDFRM                     \ [0x1d] Odd frame This field is set (reset) by the application to indicate that the OTG host must perform a transfer in an odd frame. This field is applicable for only periodic (isochronous and interrupt) transactions.
    $1e constant OTG_CHDIS                      \ [0x1e] Channel disable The application sets this bit to stop transmitting/receiving data on a channel, even before the transfer for that channel is complete. The application must wait for the Channel disabled interrupt before treating the channel as disabled.
    $1f constant OTG_CHENA                      \ [0x1f] Channel enable When Scatter/Gather mode is enabled: 1'b0: Indicates that the descriptor structure is not yet ready 1'b1: Indicates that the descriptor structure and data buffer with data is setup and this channel can access the descriptor When Scatter/Gather mode is disabled: This field is set by the application and cleared by the OTG host.
  [then]


  [ifdef] OTG_OTG_HCSPLT5_DEF
    \
    \ @brief Port address This field is the port number of the recipient transaction translator.
    \ Address offset: 0x5A4
    \ Reset value: 0x00000000
    \
    $00 constant OTG_PRTADDR                    \ [0x00 : 7] Port address This field is the port number of the recipient transaction translator.
    $07 constant OTG_HUBADDR                    \ [0x07 : 7] Hub address This field holds the device address of the transaction translator's hub.
    $0e constant OTG_XACTPOS                    \ [0x0e : 2] Transaction position This field is used to determine whether to send all, first, middle, or last payloads with each OUT transaction.
    $10 constant OTG_COMPLSPLT                  \ [0x10] Do complete split The application sets this bit to request the OTG host to perform a complete split transaction.
    $1f constant OTG_SPLITEN                    \ [0x1f] Split enable The application sets this bit to indicate that this channel is enabled to perform split transactions.
  [then]


  [ifdef] OTG_OTG_HCINT5_DEF
    \
    \ @brief OTG host channel 5 interrupt register
    \ Address offset: 0x5A8
    \ Reset value: 0x00000000
    \
    $00 constant OTG_XFRC                       \ [0x00] Transfer completed. Transfer completed normally without any errors.
    $01 constant OTG_CHH                        \ [0x01] Channel halted. In non scatter/gather DMA mode indicates the transfer completed abnormally either because of any USB transaction error or in response to disable request by the application. In scatter/gather DMA mode, this indicates that transfer completed due to any of the following: EOL being set in descriptor AHB error Excessive transaction errors In response to disable request by the application Babble Stall
    $02 constant OTG_AHBERR                     \ [0x02] AHB error This error is generated only in Internal DMA mode when an AHB error occurs during an AHB read/write operation. The application can read the corresponding DMA channel address register to get the error address.
    $03 constant OTG_STALL                      \ [0x03] STALL response received interrupt. In Scatter/Gather DMA mode, the interrupt due to this bit is masked.
    $04 constant OTG_NAK                        \ [0x04] NAK response received interrupt. In Scatter/Gather DMA mode, the interrupt due to this bit is masked.
    $05 constant OTG_ACK                        \ [0x05] ACK response received/transmitted interrupt. In Scatter/Gather DMA mode, the interrupt due to this bit is masked.
    $06 constant OTG_NYET                       \ [0x06] Not yet ready response received interrupt. In Scatter/Gather DMA mode, the interrupt due to this bit is masked.
    $07 constant OTG_TXERR                      \ [0x07] Transaction error. In Scatter/Gather DMA mode, the interrupt due to this bit is masked. Indicates one of the following errors occurred on the USB. CRC check failure Timeout Bit stuff error False EOP
    $08 constant OTG_BBERR                      \ [0x08] Babble error. In Scatter/Gather DMA mode, the interrupt due to this bit is masked.
    $09 constant OTG_FRMOR                      \ [0x09] Frame overrun. In Scatter/Gather DMA mode, the interrupt due to this bit is masked.
    $0a constant OTG_DTERR                      \ [0x0a] Data toggle error. In Scatter/Gather DMA mode, the interrupt due to this bit is masked.
    $0b constant OTG_BNA                        \ [0x0b] Buffer not available interrupt. This bit is valid only when Scatter/Gather DMA mode is enabled. The core generates this interrupt when the descriptor accessed is not ready for the core to process. BNA interrupt is not generated for isochronous channels. For non Scatter/Gather DMA mode, this bit is reserved.
    $0c constant OTG_XCSXACTERR                 \ [0x0c] Excessive transaction error. This bit is valid only when Scatter/Gather DMA mode is enabled. The core sets this bit when 3 consecutive transaction errors occurred on the USB bus. XCS_XACT_ERR is not generated for isochronous channels. For non Scatter/Gather DMA mode, this bit is reserved.
    $0d constant OTG_DESCLSTROLL                \ [0x0d] Descriptor rollover interrupt. This bit is valid only when Scatter/Gather DMA mode is enabled. The core sets this bit when the corresponding channel descriptor list rolls over. For non Scatter/Gather DMA mode, this bit is reserved.
  [then]


  [ifdef] OTG_OTG_HCINTMSK5_DEF
    \
    \ @brief OTG host channel 5 interrupt mask register
    \ Address offset: 0x5AC
    \ Reset value: 0x00000000
    \
    $00 constant OTG_XFRCM                      \ [0x00] Transfer completed mask
    $01 constant OTG_CHHM                       \ [0x01] Channel halted mask
    $02 constant OTG_AHBERRM                    \ [0x02] AHB error. In scatter/gather DMA mode for host, interrupts will not be generated due to the corresponding bits set in OTG_HCINTx.
    $03 constant OTG_STALLM                     \ [0x03] STALL response received interrupt mask. In Scatter/Gather DMA mode, the interrupt due to this bit is masked.
    $04 constant OTG_NAKM                       \ [0x04] NAK response received interrupt mask. In Scatter/Gather DMA mode, the interrupt due to this bit is masked.
    $05 constant OTG_ACKM                       \ [0x05] ACK response received/transmitted interrupt mask. In Scatter/Gather DMA mode, the interrupt due to this bit is masked.
    $06 constant OTG_NYET                       \ [0x06] response received interrupt mask. In Scatter/Gather DMA mode, the interrupt due to this bit is masked.
    $07 constant OTG_TXERRM                     \ [0x07] Transaction error mask. In Scatter/Gather DMA mode, the interrupt due to this bit is masked.
    $08 constant OTG_BBERRM                     \ [0x08] Babble error mask. In Scatter/Gather DMA mode, the interrupt due to this bit is masked.
    $09 constant OTG_FRMORM                     \ [0x09] Frame overrun mask. In Scatter/Gather DMA mode, the interrupt due to this bit is masked.
    $0a constant OTG_DTERRM                     \ [0x0a] Data toggle error mask. In Scatter/Gather DMA mode, the interrupt due to this bit is masked.
    $0b constant OTG_BNAMSK                     \ [0x0b] Buffer not available interrupt mask register. This bit is valid only when Scatter/Gather DMA mode is enabled. In non Scatter/Gather DMA mode, this bit is reserved
    $0d constant OTG_DESCLSTROLLMSK             \ [0x0d] Descriptor rollover interrupt mask register. This bit is valid only when Scatter/Gather DMA mode is enabled. In non Scatter/Gather DMA mode, this bit is reserved.
  [then]


  [ifdef] OTG_OTG_HCTSIZ5_DEF
    \
    \ @brief Transfer size For an OUT, this field is the number of data bytes the host sends during the transfer. For an IN, this field is the buffer size that the application has reserved for the transfer. The application is expected to program this field as an integer multiple of the maximum packet size for IN transactions (periodic and non-periodic).
    \ Address offset: 0x5B0
    \ Reset value: 0x00000000
    \
    $00 constant OTG_XFRSIZ                     \ [0x00 : 19] Transfer size For an OUT, this field is the number of data bytes the host sends during the transfer. For an IN, this field is the buffer size that the application has reserved for the transfer. The application is expected to program this field as an integer multiple of the maximum packet size for IN transactions (periodic and non-periodic).
    $13 constant OTG_PKTCNT                     \ [0x13 : 10] Packet count This field is programmed by the application with the expected number of packets to be transmitted (OUT) or received (IN). The host decrements this count on every successful transmission or reception of an OUT/IN packet. Once this count reaches zero, the application is interrupted to indicate normal completion.
    $1d constant OTG_DPID                       \ [0x1d : 2] Data PID The application programs this field with the type of PID to use for the initial transaction. The host maintains this field for the rest of the transfer.
    $1f constant OTG_DOPNG                      \ [0x1f] Do Ping This bit is used only for OUT transfers. Setting this field to 1 directs the host to do PING protocol. Note: Do not set this bit for IN transfers. If this bit is set for IN transfers, it disables the channel.
  [then]


  [ifdef] OTG_OTG_HCDMA5_DEF
    \
    \ @brief DMA address This field holds the start address in the external memory from which the data for the endpoint must be fetched or to which it must be stored. This register is incremented on every AHB transaction.
    \ Address offset: 0x5B4
    \ Reset value: 0x00000000
    \
    $00 constant OTG_DMAADDR                    \ [0x00 : 32] DMA address This field holds the start address in the external memory from which the data for the endpoint must be fetched or to which it must be stored. This register is incremented on every AHB transaction.
  [then]


  [ifdef] OTG_OTG_HCDMAB5_DEF
    \
    \ @brief DMA address This register holds the current buffer address (scatter/gather mode).
    \ Address offset: 0x5BC
    \ Reset value: 0x00000000
    \
    $00 constant OTG_HCDMAB                     \ [0x00 : 32] DMA address This register holds the current buffer address (scatter/gather mode).
  [then]


  [ifdef] OTG_OTG_HCCHAR6_DEF
    \
    \ @brief Maximum packet size Indicates the maximum packet size of the associated endpoint.
    \ Address offset: 0x5C0
    \ Reset value: 0x00000000
    \
    $00 constant OTG_MPSIZ                      \ [0x00 : 11] Maximum packet size Indicates the maximum packet size of the associated endpoint.
    $0b constant OTG_EPNUM                      \ [0x0b : 4] Endpoint number Indicates the endpoint number on the device serving as the data source or sink.
    $0f constant OTG_EPDIR                      \ [0x0f] Endpoint direction Indicates whether the transaction is IN or OUT.
    $11 constant OTG_LSDEV                      \ [0x11] Low-speed device This field is set by the application to indicate that this channel is communicating to a low-speed device.
    $12 constant OTG_EPTYP                      \ [0x12 : 2] Endpoint type Indicates the transfer type selected.
    $14 constant OTG_MCNT                       \ [0x14 : 2] Multicount This field indicates to the host the number of transactions that must be executed per frame for this periodic endpoint. For non-periodic transfers, this field is not used Note: This field must be set to at least 01.
    $16 constant OTG_DAD                        \ [0x16 : 7] Device address This field selects the specific device serving as the data source or sink.
    $1d constant OTG_ODDFRM                     \ [0x1d] Odd frame This field is set (reset) by the application to indicate that the OTG host must perform a transfer in an odd frame. This field is applicable for only periodic (isochronous and interrupt) transactions.
    $1e constant OTG_CHDIS                      \ [0x1e] Channel disable The application sets this bit to stop transmitting/receiving data on a channel, even before the transfer for that channel is complete. The application must wait for the Channel disabled interrupt before treating the channel as disabled.
    $1f constant OTG_CHENA                      \ [0x1f] Channel enable When Scatter/Gather mode is enabled: 1'b0: Indicates that the descriptor structure is not yet ready 1'b1: Indicates that the descriptor structure and data buffer with data is setup and this channel can access the descriptor When Scatter/Gather mode is disabled: This field is set by the application and cleared by the OTG host.
  [then]


  [ifdef] OTG_OTG_HCSPLT6_DEF
    \
    \ @brief Port address This field is the port number of the recipient transaction translator.
    \ Address offset: 0x5C4
    \ Reset value: 0x00000000
    \
    $00 constant OTG_PRTADDR                    \ [0x00 : 7] Port address This field is the port number of the recipient transaction translator.
    $07 constant OTG_HUBADDR                    \ [0x07 : 7] Hub address This field holds the device address of the transaction translator's hub.
    $0e constant OTG_XACTPOS                    \ [0x0e : 2] Transaction position This field is used to determine whether to send all, first, middle, or last payloads with each OUT transaction.
    $10 constant OTG_COMPLSPLT                  \ [0x10] Do complete split The application sets this bit to request the OTG host to perform a complete split transaction.
    $1f constant OTG_SPLITEN                    \ [0x1f] Split enable The application sets this bit to indicate that this channel is enabled to perform split transactions.
  [then]


  [ifdef] OTG_OTG_HCINT6_DEF
    \
    \ @brief OTG host channel 6 interrupt register
    \ Address offset: 0x5C8
    \ Reset value: 0x00000000
    \
    $00 constant OTG_XFRC                       \ [0x00] Transfer completed. Transfer completed normally without any errors.
    $01 constant OTG_CHH                        \ [0x01] Channel halted. In non scatter/gather DMA mode indicates the transfer completed abnormally either because of any USB transaction error or in response to disable request by the application. In scatter/gather DMA mode, this indicates that transfer completed due to any of the following: EOL being set in descriptor AHB error Excessive transaction errors In response to disable request by the application Babble Stall
    $02 constant OTG_AHBERR                     \ [0x02] AHB error This error is generated only in Internal DMA mode when an AHB error occurs during an AHB read/write operation. The application can read the corresponding DMA channel address register to get the error address.
    $03 constant OTG_STALL                      \ [0x03] STALL response received interrupt. In Scatter/Gather DMA mode, the interrupt due to this bit is masked.
    $04 constant OTG_NAK                        \ [0x04] NAK response received interrupt. In Scatter/Gather DMA mode, the interrupt due to this bit is masked.
    $05 constant OTG_ACK                        \ [0x05] ACK response received/transmitted interrupt. In Scatter/Gather DMA mode, the interrupt due to this bit is masked.
    $06 constant OTG_NYET                       \ [0x06] Not yet ready response received interrupt. In Scatter/Gather DMA mode, the interrupt due to this bit is masked.
    $07 constant OTG_TXERR                      \ [0x07] Transaction error. In Scatter/Gather DMA mode, the interrupt due to this bit is masked. Indicates one of the following errors occurred on the USB. CRC check failure Timeout Bit stuff error False EOP
    $08 constant OTG_BBERR                      \ [0x08] Babble error. In Scatter/Gather DMA mode, the interrupt due to this bit is masked.
    $09 constant OTG_FRMOR                      \ [0x09] Frame overrun. In Scatter/Gather DMA mode, the interrupt due to this bit is masked.
    $0a constant OTG_DTERR                      \ [0x0a] Data toggle error. In Scatter/Gather DMA mode, the interrupt due to this bit is masked.
    $0b constant OTG_BNA                        \ [0x0b] Buffer not available interrupt. This bit is valid only when Scatter/Gather DMA mode is enabled. The core generates this interrupt when the descriptor accessed is not ready for the core to process. BNA interrupt is not generated for isochronous channels. For non Scatter/Gather DMA mode, this bit is reserved.
    $0c constant OTG_XCSXACTERR                 \ [0x0c] Excessive transaction error. This bit is valid only when Scatter/Gather DMA mode is enabled. The core sets this bit when 3 consecutive transaction errors occurred on the USB bus. XCS_XACT_ERR is not generated for isochronous channels. For non Scatter/Gather DMA mode, this bit is reserved.
    $0d constant OTG_DESCLSTROLL                \ [0x0d] Descriptor rollover interrupt. This bit is valid only when Scatter/Gather DMA mode is enabled. The core sets this bit when the corresponding channel descriptor list rolls over. For non Scatter/Gather DMA mode, this bit is reserved.
  [then]


  [ifdef] OTG_OTG_HCINTMSK6_DEF
    \
    \ @brief OTG host channel 6 interrupt mask register
    \ Address offset: 0x5CC
    \ Reset value: 0x00000000
    \
    $00 constant OTG_XFRCM                      \ [0x00] Transfer completed mask
    $01 constant OTG_CHHM                       \ [0x01] Channel halted mask
    $02 constant OTG_AHBERRM                    \ [0x02] AHB error. In scatter/gather DMA mode for host, interrupts will not be generated due to the corresponding bits set in OTG_HCINTx.
    $03 constant OTG_STALLM                     \ [0x03] STALL response received interrupt mask. In Scatter/Gather DMA mode, the interrupt due to this bit is masked.
    $04 constant OTG_NAKM                       \ [0x04] NAK response received interrupt mask. In Scatter/Gather DMA mode, the interrupt due to this bit is masked.
    $05 constant OTG_ACKM                       \ [0x05] ACK response received/transmitted interrupt mask. In Scatter/Gather DMA mode, the interrupt due to this bit is masked.
    $06 constant OTG_NYET                       \ [0x06] response received interrupt mask. In Scatter/Gather DMA mode, the interrupt due to this bit is masked.
    $07 constant OTG_TXERRM                     \ [0x07] Transaction error mask. In Scatter/Gather DMA mode, the interrupt due to this bit is masked.
    $08 constant OTG_BBERRM                     \ [0x08] Babble error mask. In Scatter/Gather DMA mode, the interrupt due to this bit is masked.
    $09 constant OTG_FRMORM                     \ [0x09] Frame overrun mask. In Scatter/Gather DMA mode, the interrupt due to this bit is masked.
    $0a constant OTG_DTERRM                     \ [0x0a] Data toggle error mask. In Scatter/Gather DMA mode, the interrupt due to this bit is masked.
    $0b constant OTG_BNAMSK                     \ [0x0b] Buffer not available interrupt mask register. This bit is valid only when Scatter/Gather DMA mode is enabled. In non Scatter/Gather DMA mode, this bit is reserved
    $0d constant OTG_DESCLSTROLLMSK             \ [0x0d] Descriptor rollover interrupt mask register. This bit is valid only when Scatter/Gather DMA mode is enabled. In non Scatter/Gather DMA mode, this bit is reserved.
  [then]


  [ifdef] OTG_OTG_HCTSIZ6_DEF
    \
    \ @brief Transfer size For an OUT, this field is the number of data bytes the host sends during the transfer. For an IN, this field is the buffer size that the application has reserved for the transfer. The application is expected to program this field as an integer multiple of the maximum packet size for IN transactions (periodic and non-periodic).
    \ Address offset: 0x5D0
    \ Reset value: 0x00000000
    \
    $00 constant OTG_XFRSIZ                     \ [0x00 : 19] Transfer size For an OUT, this field is the number of data bytes the host sends during the transfer. For an IN, this field is the buffer size that the application has reserved for the transfer. The application is expected to program this field as an integer multiple of the maximum packet size for IN transactions (periodic and non-periodic).
    $13 constant OTG_PKTCNT                     \ [0x13 : 10] Packet count This field is programmed by the application with the expected number of packets to be transmitted (OUT) or received (IN). The host decrements this count on every successful transmission or reception of an OUT/IN packet. Once this count reaches zero, the application is interrupted to indicate normal completion.
    $1d constant OTG_DPID                       \ [0x1d : 2] Data PID The application programs this field with the type of PID to use for the initial transaction. The host maintains this field for the rest of the transfer.
    $1f constant OTG_DOPNG                      \ [0x1f] Do Ping This bit is used only for OUT transfers. Setting this field to 1 directs the host to do PING protocol. Note: Do not set this bit for IN transfers. If this bit is set for IN transfers, it disables the channel.
  [then]


  [ifdef] OTG_OTG_HCDMA6_DEF
    \
    \ @brief DMA address This field holds the start address in the external memory from which the data for the endpoint must be fetched or to which it must be stored. This register is incremented on every AHB transaction.
    \ Address offset: 0x5D4
    \ Reset value: 0x00000000
    \
    $00 constant OTG_DMAADDR                    \ [0x00 : 32] DMA address This field holds the start address in the external memory from which the data for the endpoint must be fetched or to which it must be stored. This register is incremented on every AHB transaction.
  [then]


  [ifdef] OTG_OTG_HCDMAB6_DEF
    \
    \ @brief DMA address This register holds the current buffer address (scatter/gather mode).
    \ Address offset: 0x5DC
    \ Reset value: 0x00000000
    \
    $00 constant OTG_HCDMAB                     \ [0x00 : 32] DMA address This register holds the current buffer address (scatter/gather mode).
  [then]


  [ifdef] OTG_OTG_HCCHAR7_DEF
    \
    \ @brief Maximum packet size Indicates the maximum packet size of the associated endpoint.
    \ Address offset: 0x5E0
    \ Reset value: 0x00000000
    \
    $00 constant OTG_MPSIZ                      \ [0x00 : 11] Maximum packet size Indicates the maximum packet size of the associated endpoint.
    $0b constant OTG_EPNUM                      \ [0x0b : 4] Endpoint number Indicates the endpoint number on the device serving as the data source or sink.
    $0f constant OTG_EPDIR                      \ [0x0f] Endpoint direction Indicates whether the transaction is IN or OUT.
    $11 constant OTG_LSDEV                      \ [0x11] Low-speed device This field is set by the application to indicate that this channel is communicating to a low-speed device.
    $12 constant OTG_EPTYP                      \ [0x12 : 2] Endpoint type Indicates the transfer type selected.
    $14 constant OTG_MCNT                       \ [0x14 : 2] Multicount This field indicates to the host the number of transactions that must be executed per frame for this periodic endpoint. For non-periodic transfers, this field is not used Note: This field must be set to at least 01.
    $16 constant OTG_DAD                        \ [0x16 : 7] Device address This field selects the specific device serving as the data source or sink.
    $1d constant OTG_ODDFRM                     \ [0x1d] Odd frame This field is set (reset) by the application to indicate that the OTG host must perform a transfer in an odd frame. This field is applicable for only periodic (isochronous and interrupt) transactions.
    $1e constant OTG_CHDIS                      \ [0x1e] Channel disable The application sets this bit to stop transmitting/receiving data on a channel, even before the transfer for that channel is complete. The application must wait for the Channel disabled interrupt before treating the channel as disabled.
    $1f constant OTG_CHENA                      \ [0x1f] Channel enable When Scatter/Gather mode is enabled: 1'b0: Indicates that the descriptor structure is not yet ready 1'b1: Indicates that the descriptor structure and data buffer with data is setup and this channel can access the descriptor When Scatter/Gather mode is disabled: This field is set by the application and cleared by the OTG host.
  [then]


  [ifdef] OTG_OTG_HCSPLT7_DEF
    \
    \ @brief Port address This field is the port number of the recipient transaction translator.
    \ Address offset: 0x5E4
    \ Reset value: 0x00000000
    \
    $00 constant OTG_PRTADDR                    \ [0x00 : 7] Port address This field is the port number of the recipient transaction translator.
    $07 constant OTG_HUBADDR                    \ [0x07 : 7] Hub address This field holds the device address of the transaction translator's hub.
    $0e constant OTG_XACTPOS                    \ [0x0e : 2] Transaction position This field is used to determine whether to send all, first, middle, or last payloads with each OUT transaction.
    $10 constant OTG_COMPLSPLT                  \ [0x10] Do complete split The application sets this bit to request the OTG host to perform a complete split transaction.
    $1f constant OTG_SPLITEN                    \ [0x1f] Split enable The application sets this bit to indicate that this channel is enabled to perform split transactions.
  [then]


  [ifdef] OTG_OTG_HCINT7_DEF
    \
    \ @brief OTG host channel 7 interrupt register
    \ Address offset: 0x5E8
    \ Reset value: 0x00000000
    \
    $00 constant OTG_XFRC                       \ [0x00] Transfer completed. Transfer completed normally without any errors.
    $01 constant OTG_CHH                        \ [0x01] Channel halted. In non scatter/gather DMA mode indicates the transfer completed abnormally either because of any USB transaction error or in response to disable request by the application. In scatter/gather DMA mode, this indicates that transfer completed due to any of the following: EOL being set in descriptor AHB error Excessive transaction errors In response to disable request by the application Babble Stall
    $02 constant OTG_AHBERR                     \ [0x02] AHB error This error is generated only in Internal DMA mode when an AHB error occurs during an AHB read/write operation. The application can read the corresponding DMA channel address register to get the error address.
    $03 constant OTG_STALL                      \ [0x03] STALL response received interrupt. In Scatter/Gather DMA mode, the interrupt due to this bit is masked.
    $04 constant OTG_NAK                        \ [0x04] NAK response received interrupt. In Scatter/Gather DMA mode, the interrupt due to this bit is masked.
    $05 constant OTG_ACK                        \ [0x05] ACK response received/transmitted interrupt. In Scatter/Gather DMA mode, the interrupt due to this bit is masked.
    $06 constant OTG_NYET                       \ [0x06] Not yet ready response received interrupt. In Scatter/Gather DMA mode, the interrupt due to this bit is masked.
    $07 constant OTG_TXERR                      \ [0x07] Transaction error. In Scatter/Gather DMA mode, the interrupt due to this bit is masked. Indicates one of the following errors occurred on the USB. CRC check failure Timeout Bit stuff error False EOP
    $08 constant OTG_BBERR                      \ [0x08] Babble error. In Scatter/Gather DMA mode, the interrupt due to this bit is masked.
    $09 constant OTG_FRMOR                      \ [0x09] Frame overrun. In Scatter/Gather DMA mode, the interrupt due to this bit is masked.
    $0a constant OTG_DTERR                      \ [0x0a] Data toggle error. In Scatter/Gather DMA mode, the interrupt due to this bit is masked.
    $0b constant OTG_BNA                        \ [0x0b] Buffer not available interrupt. This bit is valid only when Scatter/Gather DMA mode is enabled. The core generates this interrupt when the descriptor accessed is not ready for the core to process. BNA interrupt is not generated for isochronous channels. For non Scatter/Gather DMA mode, this bit is reserved.
    $0c constant OTG_XCSXACTERR                 \ [0x0c] Excessive transaction error. This bit is valid only when Scatter/Gather DMA mode is enabled. The core sets this bit when 3 consecutive transaction errors occurred on the USB bus. XCS_XACT_ERR is not generated for isochronous channels. For non Scatter/Gather DMA mode, this bit is reserved.
    $0d constant OTG_DESCLSTROLL                \ [0x0d] Descriptor rollover interrupt. This bit is valid only when Scatter/Gather DMA mode is enabled. The core sets this bit when the corresponding channel descriptor list rolls over. For non Scatter/Gather DMA mode, this bit is reserved.
  [then]


  [ifdef] OTG_OTG_HCINTMSK7_DEF
    \
    \ @brief OTG host channel 7 interrupt mask register
    \ Address offset: 0x5EC
    \ Reset value: 0x00000000
    \
    $00 constant OTG_XFRCM                      \ [0x00] Transfer completed mask
    $01 constant OTG_CHHM                       \ [0x01] Channel halted mask
    $02 constant OTG_AHBERRM                    \ [0x02] AHB error. In scatter/gather DMA mode for host, interrupts will not be generated due to the corresponding bits set in OTG_HCINTx.
    $03 constant OTG_STALLM                     \ [0x03] STALL response received interrupt mask. In Scatter/Gather DMA mode, the interrupt due to this bit is masked.
    $04 constant OTG_NAKM                       \ [0x04] NAK response received interrupt mask. In Scatter/Gather DMA mode, the interrupt due to this bit is masked.
    $05 constant OTG_ACKM                       \ [0x05] ACK response received/transmitted interrupt mask. In Scatter/Gather DMA mode, the interrupt due to this bit is masked.
    $06 constant OTG_NYET                       \ [0x06] response received interrupt mask. In Scatter/Gather DMA mode, the interrupt due to this bit is masked.
    $07 constant OTG_TXERRM                     \ [0x07] Transaction error mask. In Scatter/Gather DMA mode, the interrupt due to this bit is masked.
    $08 constant OTG_BBERRM                     \ [0x08] Babble error mask. In Scatter/Gather DMA mode, the interrupt due to this bit is masked.
    $09 constant OTG_FRMORM                     \ [0x09] Frame overrun mask. In Scatter/Gather DMA mode, the interrupt due to this bit is masked.
    $0a constant OTG_DTERRM                     \ [0x0a] Data toggle error mask. In Scatter/Gather DMA mode, the interrupt due to this bit is masked.
    $0b constant OTG_BNAMSK                     \ [0x0b] Buffer not available interrupt mask register. This bit is valid only when Scatter/Gather DMA mode is enabled. In non Scatter/Gather DMA mode, this bit is reserved
    $0d constant OTG_DESCLSTROLLMSK             \ [0x0d] Descriptor rollover interrupt mask register. This bit is valid only when Scatter/Gather DMA mode is enabled. In non Scatter/Gather DMA mode, this bit is reserved.
  [then]


  [ifdef] OTG_OTG_HCTSIZ7_DEF
    \
    \ @brief Transfer size For an OUT, this field is the number of data bytes the host sends during the transfer. For an IN, this field is the buffer size that the application has reserved for the transfer. The application is expected to program this field as an integer multiple of the maximum packet size for IN transactions (periodic and non-periodic).
    \ Address offset: 0x5F0
    \ Reset value: 0x00000000
    \
    $00 constant OTG_XFRSIZ                     \ [0x00 : 19] Transfer size For an OUT, this field is the number of data bytes the host sends during the transfer. For an IN, this field is the buffer size that the application has reserved for the transfer. The application is expected to program this field as an integer multiple of the maximum packet size for IN transactions (periodic and non-periodic).
    $13 constant OTG_PKTCNT                     \ [0x13 : 10] Packet count This field is programmed by the application with the expected number of packets to be transmitted (OUT) or received (IN). The host decrements this count on every successful transmission or reception of an OUT/IN packet. Once this count reaches zero, the application is interrupted to indicate normal completion.
    $1d constant OTG_DPID                       \ [0x1d : 2] Data PID The application programs this field with the type of PID to use for the initial transaction. The host maintains this field for the rest of the transfer.
    $1f constant OTG_DOPNG                      \ [0x1f] Do Ping This bit is used only for OUT transfers. Setting this field to 1 directs the host to do PING protocol. Note: Do not set this bit for IN transfers. If this bit is set for IN transfers, it disables the channel.
  [then]


  [ifdef] OTG_OTG_HCDMA7_DEF
    \
    \ @brief DMA address This field holds the start address in the external memory from which the data for the endpoint must be fetched or to which it must be stored. This register is incremented on every AHB transaction.
    \ Address offset: 0x5F4
    \ Reset value: 0x00000000
    \
    $00 constant OTG_DMAADDR                    \ [0x00 : 32] DMA address This field holds the start address in the external memory from which the data for the endpoint must be fetched or to which it must be stored. This register is incremented on every AHB transaction.
  [then]


  [ifdef] OTG_OTG_HCDMAB7_DEF
    \
    \ @brief DMA address This register holds the current buffer address (scatter/gather mode).
    \ Address offset: 0x5FC
    \ Reset value: 0x00000000
    \
    $00 constant OTG_HCDMAB                     \ [0x00 : 32] DMA address This register holds the current buffer address (scatter/gather mode).
  [then]


  [ifdef] OTG_OTG_HCCHAR8_DEF
    \
    \ @brief Maximum packet size Indicates the maximum packet size of the associated endpoint.
    \ Address offset: 0x600
    \ Reset value: 0x00000000
    \
    $00 constant OTG_MPSIZ                      \ [0x00 : 11] Maximum packet size Indicates the maximum packet size of the associated endpoint.
    $0b constant OTG_EPNUM                      \ [0x0b : 4] Endpoint number Indicates the endpoint number on the device serving as the data source or sink.
    $0f constant OTG_EPDIR                      \ [0x0f] Endpoint direction Indicates whether the transaction is IN or OUT.
    $11 constant OTG_LSDEV                      \ [0x11] Low-speed device This field is set by the application to indicate that this channel is communicating to a low-speed device.
    $12 constant OTG_EPTYP                      \ [0x12 : 2] Endpoint type Indicates the transfer type selected.
    $14 constant OTG_MCNT                       \ [0x14 : 2] Multicount This field indicates to the host the number of transactions that must be executed per frame for this periodic endpoint. For non-periodic transfers, this field is not used Note: This field must be set to at least 01.
    $16 constant OTG_DAD                        \ [0x16 : 7] Device address This field selects the specific device serving as the data source or sink.
    $1d constant OTG_ODDFRM                     \ [0x1d] Odd frame This field is set (reset) by the application to indicate that the OTG host must perform a transfer in an odd frame. This field is applicable for only periodic (isochronous and interrupt) transactions.
    $1e constant OTG_CHDIS                      \ [0x1e] Channel disable The application sets this bit to stop transmitting/receiving data on a channel, even before the transfer for that channel is complete. The application must wait for the Channel disabled interrupt before treating the channel as disabled.
    $1f constant OTG_CHENA                      \ [0x1f] Channel enable When Scatter/Gather mode is enabled: 1'b0: Indicates that the descriptor structure is not yet ready 1'b1: Indicates that the descriptor structure and data buffer with data is setup and this channel can access the descriptor When Scatter/Gather mode is disabled: This field is set by the application and cleared by the OTG host.
  [then]


  [ifdef] OTG_OTG_HCSPLT8_DEF
    \
    \ @brief Port address This field is the port number of the recipient transaction translator.
    \ Address offset: 0x604
    \ Reset value: 0x00000000
    \
    $00 constant OTG_PRTADDR                    \ [0x00 : 7] Port address This field is the port number of the recipient transaction translator.
    $07 constant OTG_HUBADDR                    \ [0x07 : 7] Hub address This field holds the device address of the transaction translator's hub.
    $0e constant OTG_XACTPOS                    \ [0x0e : 2] Transaction position This field is used to determine whether to send all, first, middle, or last payloads with each OUT transaction.
    $10 constant OTG_COMPLSPLT                  \ [0x10] Do complete split The application sets this bit to request the OTG host to perform a complete split transaction.
    $1f constant OTG_SPLITEN                    \ [0x1f] Split enable The application sets this bit to indicate that this channel is enabled to perform split transactions.
  [then]


  [ifdef] OTG_OTG_HCINT8_DEF
    \
    \ @brief OTG host channel 8 interrupt register
    \ Address offset: 0x608
    \ Reset value: 0x00000000
    \
    $00 constant OTG_XFRC                       \ [0x00] Transfer completed. Transfer completed normally without any errors.
    $01 constant OTG_CHH                        \ [0x01] Channel halted. In non scatter/gather DMA mode indicates the transfer completed abnormally either because of any USB transaction error or in response to disable request by the application. In scatter/gather DMA mode, this indicates that transfer completed due to any of the following: EOL being set in descriptor AHB error Excessive transaction errors In response to disable request by the application Babble Stall
    $02 constant OTG_AHBERR                     \ [0x02] AHB error This error is generated only in Internal DMA mode when an AHB error occurs during an AHB read/write operation. The application can read the corresponding DMA channel address register to get the error address.
    $03 constant OTG_STALL                      \ [0x03] STALL response received interrupt. In Scatter/Gather DMA mode, the interrupt due to this bit is masked.
    $04 constant OTG_NAK                        \ [0x04] NAK response received interrupt. In Scatter/Gather DMA mode, the interrupt due to this bit is masked.
    $05 constant OTG_ACK                        \ [0x05] ACK response received/transmitted interrupt. In Scatter/Gather DMA mode, the interrupt due to this bit is masked.
    $06 constant OTG_NYET                       \ [0x06] Not yet ready response received interrupt. In Scatter/Gather DMA mode, the interrupt due to this bit is masked.
    $07 constant OTG_TXERR                      \ [0x07] Transaction error. In Scatter/Gather DMA mode, the interrupt due to this bit is masked. Indicates one of the following errors occurred on the USB. CRC check failure Timeout Bit stuff error False EOP
    $08 constant OTG_BBERR                      \ [0x08] Babble error. In Scatter/Gather DMA mode, the interrupt due to this bit is masked.
    $09 constant OTG_FRMOR                      \ [0x09] Frame overrun. In Scatter/Gather DMA mode, the interrupt due to this bit is masked.
    $0a constant OTG_DTERR                      \ [0x0a] Data toggle error. In Scatter/Gather DMA mode, the interrupt due to this bit is masked.
    $0b constant OTG_BNA                        \ [0x0b] Buffer not available interrupt. This bit is valid only when Scatter/Gather DMA mode is enabled. The core generates this interrupt when the descriptor accessed is not ready for the core to process. BNA interrupt is not generated for isochronous channels. For non Scatter/Gather DMA mode, this bit is reserved.
    $0c constant OTG_XCSXACTERR                 \ [0x0c] Excessive transaction error. This bit is valid only when Scatter/Gather DMA mode is enabled. The core sets this bit when 3 consecutive transaction errors occurred on the USB bus. XCS_XACT_ERR is not generated for isochronous channels. For non Scatter/Gather DMA mode, this bit is reserved.
    $0d constant OTG_DESCLSTROLL                \ [0x0d] Descriptor rollover interrupt. This bit is valid only when Scatter/Gather DMA mode is enabled. The core sets this bit when the corresponding channel descriptor list rolls over. For non Scatter/Gather DMA mode, this bit is reserved.
  [then]


  [ifdef] OTG_OTG_HCINTMSK8_DEF
    \
    \ @brief OTG host channel 8 interrupt mask register
    \ Address offset: 0x60C
    \ Reset value: 0x00000000
    \
    $00 constant OTG_XFRCM                      \ [0x00] Transfer completed mask
    $01 constant OTG_CHHM                       \ [0x01] Channel halted mask
    $02 constant OTG_AHBERRM                    \ [0x02] AHB error. In scatter/gather DMA mode for host, interrupts will not be generated due to the corresponding bits set in OTG_HCINTx.
    $03 constant OTG_STALLM                     \ [0x03] STALL response received interrupt mask. In Scatter/Gather DMA mode, the interrupt due to this bit is masked.
    $04 constant OTG_NAKM                       \ [0x04] NAK response received interrupt mask. In Scatter/Gather DMA mode, the interrupt due to this bit is masked.
    $05 constant OTG_ACKM                       \ [0x05] ACK response received/transmitted interrupt mask. In Scatter/Gather DMA mode, the interrupt due to this bit is masked.
    $06 constant OTG_NYET                       \ [0x06] response received interrupt mask. In Scatter/Gather DMA mode, the interrupt due to this bit is masked.
    $07 constant OTG_TXERRM                     \ [0x07] Transaction error mask. In Scatter/Gather DMA mode, the interrupt due to this bit is masked.
    $08 constant OTG_BBERRM                     \ [0x08] Babble error mask. In Scatter/Gather DMA mode, the interrupt due to this bit is masked.
    $09 constant OTG_FRMORM                     \ [0x09] Frame overrun mask. In Scatter/Gather DMA mode, the interrupt due to this bit is masked.
    $0a constant OTG_DTERRM                     \ [0x0a] Data toggle error mask. In Scatter/Gather DMA mode, the interrupt due to this bit is masked.
    $0b constant OTG_BNAMSK                     \ [0x0b] Buffer not available interrupt mask register. This bit is valid only when Scatter/Gather DMA mode is enabled. In non Scatter/Gather DMA mode, this bit is reserved
    $0d constant OTG_DESCLSTROLLMSK             \ [0x0d] Descriptor rollover interrupt mask register. This bit is valid only when Scatter/Gather DMA mode is enabled. In non Scatter/Gather DMA mode, this bit is reserved.
  [then]


  [ifdef] OTG_OTG_HCTSIZ8_DEF
    \
    \ @brief Transfer size For an OUT, this field is the number of data bytes the host sends during the transfer. For an IN, this field is the buffer size that the application has reserved for the transfer. The application is expected to program this field as an integer multiple of the maximum packet size for IN transactions (periodic and non-periodic).
    \ Address offset: 0x610
    \ Reset value: 0x00000000
    \
    $00 constant OTG_XFRSIZ                     \ [0x00 : 19] Transfer size For an OUT, this field is the number of data bytes the host sends during the transfer. For an IN, this field is the buffer size that the application has reserved for the transfer. The application is expected to program this field as an integer multiple of the maximum packet size for IN transactions (periodic and non-periodic).
    $13 constant OTG_PKTCNT                     \ [0x13 : 10] Packet count This field is programmed by the application with the expected number of packets to be transmitted (OUT) or received (IN). The host decrements this count on every successful transmission or reception of an OUT/IN packet. Once this count reaches zero, the application is interrupted to indicate normal completion.
    $1d constant OTG_DPID                       \ [0x1d : 2] Data PID The application programs this field with the type of PID to use for the initial transaction. The host maintains this field for the rest of the transfer.
    $1f constant OTG_DOPNG                      \ [0x1f] Do Ping This bit is used only for OUT transfers. Setting this field to 1 directs the host to do PING protocol. Note: Do not set this bit for IN transfers. If this bit is set for IN transfers, it disables the channel.
  [then]


  [ifdef] OTG_OTG_HCDMA8_DEF
    \
    \ @brief DMA address This field holds the start address in the external memory from which the data for the endpoint must be fetched or to which it must be stored. This register is incremented on every AHB transaction.
    \ Address offset: 0x614
    \ Reset value: 0x00000000
    \
    $00 constant OTG_DMAADDR                    \ [0x00 : 32] DMA address This field holds the start address in the external memory from which the data for the endpoint must be fetched or to which it must be stored. This register is incremented on every AHB transaction.
  [then]


  [ifdef] OTG_OTG_HCDMAB8_DEF
    \
    \ @brief DMA address This register holds the current buffer address (scatter/gather mode).
    \ Address offset: 0x61C
    \ Reset value: 0x00000000
    \
    $00 constant OTG_HCDMAB                     \ [0x00 : 32] DMA address This register holds the current buffer address (scatter/gather mode).
  [then]


  [ifdef] OTG_OTG_HCCHAR9_DEF
    \
    \ @brief Maximum packet size Indicates the maximum packet size of the associated endpoint.
    \ Address offset: 0x620
    \ Reset value: 0x00000000
    \
    $00 constant OTG_MPSIZ                      \ [0x00 : 11] Maximum packet size Indicates the maximum packet size of the associated endpoint.
    $0b constant OTG_EPNUM                      \ [0x0b : 4] Endpoint number Indicates the endpoint number on the device serving as the data source or sink.
    $0f constant OTG_EPDIR                      \ [0x0f] Endpoint direction Indicates whether the transaction is IN or OUT.
    $11 constant OTG_LSDEV                      \ [0x11] Low-speed device This field is set by the application to indicate that this channel is communicating to a low-speed device.
    $12 constant OTG_EPTYP                      \ [0x12 : 2] Endpoint type Indicates the transfer type selected.
    $14 constant OTG_MCNT                       \ [0x14 : 2] Multicount This field indicates to the host the number of transactions that must be executed per frame for this periodic endpoint. For non-periodic transfers, this field is not used Note: This field must be set to at least 01.
    $16 constant OTG_DAD                        \ [0x16 : 7] Device address This field selects the specific device serving as the data source or sink.
    $1d constant OTG_ODDFRM                     \ [0x1d] Odd frame This field is set (reset) by the application to indicate that the OTG host must perform a transfer in an odd frame. This field is applicable for only periodic (isochronous and interrupt) transactions.
    $1e constant OTG_CHDIS                      \ [0x1e] Channel disable The application sets this bit to stop transmitting/receiving data on a channel, even before the transfer for that channel is complete. The application must wait for the Channel disabled interrupt before treating the channel as disabled.
    $1f constant OTG_CHENA                      \ [0x1f] Channel enable When Scatter/Gather mode is enabled: 1'b0: Indicates that the descriptor structure is not yet ready 1'b1: Indicates that the descriptor structure and data buffer with data is setup and this channel can access the descriptor When Scatter/Gather mode is disabled: This field is set by the application and cleared by the OTG host.
  [then]


  [ifdef] OTG_OTG_HCSPLT9_DEF
    \
    \ @brief Port address This field is the port number of the recipient transaction translator.
    \ Address offset: 0x624
    \ Reset value: 0x00000000
    \
    $00 constant OTG_PRTADDR                    \ [0x00 : 7] Port address This field is the port number of the recipient transaction translator.
    $07 constant OTG_HUBADDR                    \ [0x07 : 7] Hub address This field holds the device address of the transaction translator's hub.
    $0e constant OTG_XACTPOS                    \ [0x0e : 2] Transaction position This field is used to determine whether to send all, first, middle, or last payloads with each OUT transaction.
    $10 constant OTG_COMPLSPLT                  \ [0x10] Do complete split The application sets this bit to request the OTG host to perform a complete split transaction.
    $1f constant OTG_SPLITEN                    \ [0x1f] Split enable The application sets this bit to indicate that this channel is enabled to perform split transactions.
  [then]


  [ifdef] OTG_OTG_HCINT9_DEF
    \
    \ @brief OTG host channel 9 interrupt register
    \ Address offset: 0x628
    \ Reset value: 0x00000000
    \
    $00 constant OTG_XFRC                       \ [0x00] Transfer completed. Transfer completed normally without any errors.
    $01 constant OTG_CHH                        \ [0x01] Channel halted. In non scatter/gather DMA mode indicates the transfer completed abnormally either because of any USB transaction error or in response to disable request by the application. In scatter/gather DMA mode, this indicates that transfer completed due to any of the following: EOL being set in descriptor AHB error Excessive transaction errors In response to disable request by the application Babble Stall
    $02 constant OTG_AHBERR                     \ [0x02] AHB error This error is generated only in Internal DMA mode when an AHB error occurs during an AHB read/write operation. The application can read the corresponding DMA channel address register to get the error address.
    $03 constant OTG_STALL                      \ [0x03] STALL response received interrupt. In Scatter/Gather DMA mode, the interrupt due to this bit is masked.
    $04 constant OTG_NAK                        \ [0x04] NAK response received interrupt. In Scatter/Gather DMA mode, the interrupt due to this bit is masked.
    $05 constant OTG_ACK                        \ [0x05] ACK response received/transmitted interrupt. In Scatter/Gather DMA mode, the interrupt due to this bit is masked.
    $06 constant OTG_NYET                       \ [0x06] Not yet ready response received interrupt. In Scatter/Gather DMA mode, the interrupt due to this bit is masked.
    $07 constant OTG_TXERR                      \ [0x07] Transaction error. In Scatter/Gather DMA mode, the interrupt due to this bit is masked. Indicates one of the following errors occurred on the USB. CRC check failure Timeout Bit stuff error False EOP
    $08 constant OTG_BBERR                      \ [0x08] Babble error. In Scatter/Gather DMA mode, the interrupt due to this bit is masked.
    $09 constant OTG_FRMOR                      \ [0x09] Frame overrun. In Scatter/Gather DMA mode, the interrupt due to this bit is masked.
    $0a constant OTG_DTERR                      \ [0x0a] Data toggle error. In Scatter/Gather DMA mode, the interrupt due to this bit is masked.
    $0b constant OTG_BNA                        \ [0x0b] Buffer not available interrupt. This bit is valid only when Scatter/Gather DMA mode is enabled. The core generates this interrupt when the descriptor accessed is not ready for the core to process. BNA interrupt is not generated for isochronous channels. For non Scatter/Gather DMA mode, this bit is reserved.
    $0c constant OTG_XCSXACTERR                 \ [0x0c] Excessive transaction error. This bit is valid only when Scatter/Gather DMA mode is enabled. The core sets this bit when 3 consecutive transaction errors occurred on the USB bus. XCS_XACT_ERR is not generated for isochronous channels. For non Scatter/Gather DMA mode, this bit is reserved.
    $0d constant OTG_DESCLSTROLL                \ [0x0d] Descriptor rollover interrupt. This bit is valid only when Scatter/Gather DMA mode is enabled. The core sets this bit when the corresponding channel descriptor list rolls over. For non Scatter/Gather DMA mode, this bit is reserved.
  [then]


  [ifdef] OTG_OTG_HCINTMSK9_DEF
    \
    \ @brief OTG host channel 9 interrupt mask register
    \ Address offset: 0x62C
    \ Reset value: 0x00000000
    \
    $00 constant OTG_XFRCM                      \ [0x00] Transfer completed mask
    $01 constant OTG_CHHM                       \ [0x01] Channel halted mask
    $02 constant OTG_AHBERRM                    \ [0x02] AHB error. In scatter/gather DMA mode for host, interrupts will not be generated due to the corresponding bits set in OTG_HCINTx.
    $03 constant OTG_STALLM                     \ [0x03] STALL response received interrupt mask. In Scatter/Gather DMA mode, the interrupt due to this bit is masked.
    $04 constant OTG_NAKM                       \ [0x04] NAK response received interrupt mask. In Scatter/Gather DMA mode, the interrupt due to this bit is masked.
    $05 constant OTG_ACKM                       \ [0x05] ACK response received/transmitted interrupt mask. In Scatter/Gather DMA mode, the interrupt due to this bit is masked.
    $06 constant OTG_NYET                       \ [0x06] response received interrupt mask. In Scatter/Gather DMA mode, the interrupt due to this bit is masked.
    $07 constant OTG_TXERRM                     \ [0x07] Transaction error mask. In Scatter/Gather DMA mode, the interrupt due to this bit is masked.
    $08 constant OTG_BBERRM                     \ [0x08] Babble error mask. In Scatter/Gather DMA mode, the interrupt due to this bit is masked.
    $09 constant OTG_FRMORM                     \ [0x09] Frame overrun mask. In Scatter/Gather DMA mode, the interrupt due to this bit is masked.
    $0a constant OTG_DTERRM                     \ [0x0a] Data toggle error mask. In Scatter/Gather DMA mode, the interrupt due to this bit is masked.
    $0b constant OTG_BNAMSK                     \ [0x0b] Buffer not available interrupt mask register. This bit is valid only when Scatter/Gather DMA mode is enabled. In non Scatter/Gather DMA mode, this bit is reserved
    $0d constant OTG_DESCLSTROLLMSK             \ [0x0d] Descriptor rollover interrupt mask register. This bit is valid only when Scatter/Gather DMA mode is enabled. In non Scatter/Gather DMA mode, this bit is reserved.
  [then]


  [ifdef] OTG_OTG_HCTSIZ9_DEF
    \
    \ @brief Transfer size For an OUT, this field is the number of data bytes the host sends during the transfer. For an IN, this field is the buffer size that the application has reserved for the transfer. The application is expected to program this field as an integer multiple of the maximum packet size for IN transactions (periodic and non-periodic).
    \ Address offset: 0x630
    \ Reset value: 0x00000000
    \
    $00 constant OTG_XFRSIZ                     \ [0x00 : 19] Transfer size For an OUT, this field is the number of data bytes the host sends during the transfer. For an IN, this field is the buffer size that the application has reserved for the transfer. The application is expected to program this field as an integer multiple of the maximum packet size for IN transactions (periodic and non-periodic).
    $13 constant OTG_PKTCNT                     \ [0x13 : 10] Packet count This field is programmed by the application with the expected number of packets to be transmitted (OUT) or received (IN). The host decrements this count on every successful transmission or reception of an OUT/IN packet. Once this count reaches zero, the application is interrupted to indicate normal completion.
    $1d constant OTG_DPID                       \ [0x1d : 2] Data PID The application programs this field with the type of PID to use for the initial transaction. The host maintains this field for the rest of the transfer.
    $1f constant OTG_DOPNG                      \ [0x1f] Do Ping This bit is used only for OUT transfers. Setting this field to 1 directs the host to do PING protocol. Note: Do not set this bit for IN transfers. If this bit is set for IN transfers, it disables the channel.
  [then]


  [ifdef] OTG_OTG_HCDMA9_DEF
    \
    \ @brief DMA address This field holds the start address in the external memory from which the data for the endpoint must be fetched or to which it must be stored. This register is incremented on every AHB transaction.
    \ Address offset: 0x634
    \ Reset value: 0x00000000
    \
    $00 constant OTG_DMAADDR                    \ [0x00 : 32] DMA address This field holds the start address in the external memory from which the data for the endpoint must be fetched or to which it must be stored. This register is incremented on every AHB transaction.
  [then]


  [ifdef] OTG_OTG_HCDMAB9_DEF
    \
    \ @brief DMA address This register holds the current buffer address (scatter/gather mode).
    \ Address offset: 0x63C
    \ Reset value: 0x00000000
    \
    $00 constant OTG_HCDMAB                     \ [0x00 : 32] DMA address This register holds the current buffer address (scatter/gather mode).
  [then]


  [ifdef] OTG_OTG_HCCHAR10_DEF
    \
    \ @brief Maximum packet size Indicates the maximum packet size of the associated endpoint.
    \ Address offset: 0x640
    \ Reset value: 0x00000000
    \
    $00 constant OTG_MPSIZ                      \ [0x00 : 11] Maximum packet size Indicates the maximum packet size of the associated endpoint.
    $0b constant OTG_EPNUM                      \ [0x0b : 4] Endpoint number Indicates the endpoint number on the device serving as the data source or sink.
    $0f constant OTG_EPDIR                      \ [0x0f] Endpoint direction Indicates whether the transaction is IN or OUT.
    $11 constant OTG_LSDEV                      \ [0x11] Low-speed device This field is set by the application to indicate that this channel is communicating to a low-speed device.
    $12 constant OTG_EPTYP                      \ [0x12 : 2] Endpoint type Indicates the transfer type selected.
    $14 constant OTG_MCNT                       \ [0x14 : 2] Multicount This field indicates to the host the number of transactions that must be executed per frame for this periodic endpoint. For non-periodic transfers, this field is not used Note: This field must be set to at least 01.
    $16 constant OTG_DAD                        \ [0x16 : 7] Device address This field selects the specific device serving as the data source or sink.
    $1d constant OTG_ODDFRM                     \ [0x1d] Odd frame This field is set (reset) by the application to indicate that the OTG host must perform a transfer in an odd frame. This field is applicable for only periodic (isochronous and interrupt) transactions.
    $1e constant OTG_CHDIS                      \ [0x1e] Channel disable The application sets this bit to stop transmitting/receiving data on a channel, even before the transfer for that channel is complete. The application must wait for the Channel disabled interrupt before treating the channel as disabled.
    $1f constant OTG_CHENA                      \ [0x1f] Channel enable When Scatter/Gather mode is enabled: 1'b0: Indicates that the descriptor structure is not yet ready 1'b1: Indicates that the descriptor structure and data buffer with data is setup and this channel can access the descriptor When Scatter/Gather mode is disabled: This field is set by the application and cleared by the OTG host.
  [then]


  [ifdef] OTG_OTG_HCSPLT10_DEF
    \
    \ @brief Port address This field is the port number of the recipient transaction translator.
    \ Address offset: 0x644
    \ Reset value: 0x00000000
    \
    $00 constant OTG_PRTADDR                    \ [0x00 : 7] Port address This field is the port number of the recipient transaction translator.
    $07 constant OTG_HUBADDR                    \ [0x07 : 7] Hub address This field holds the device address of the transaction translator's hub.
    $0e constant OTG_XACTPOS                    \ [0x0e : 2] Transaction position This field is used to determine whether to send all, first, middle, or last payloads with each OUT transaction.
    $10 constant OTG_COMPLSPLT                  \ [0x10] Do complete split The application sets this bit to request the OTG host to perform a complete split transaction.
    $1f constant OTG_SPLITEN                    \ [0x1f] Split enable The application sets this bit to indicate that this channel is enabled to perform split transactions.
  [then]


  [ifdef] OTG_OTG_HCINT10_DEF
    \
    \ @brief OTG host channel 10 interrupt register
    \ Address offset: 0x648
    \ Reset value: 0x00000000
    \
    $00 constant OTG_XFRC                       \ [0x00] Transfer completed. Transfer completed normally without any errors.
    $01 constant OTG_CHH                        \ [0x01] Channel halted. In non scatter/gather DMA mode indicates the transfer completed abnormally either because of any USB transaction error or in response to disable request by the application. In scatter/gather DMA mode, this indicates that transfer completed due to any of the following: EOL being set in descriptor AHB error Excessive transaction errors In response to disable request by the application Babble Stall
    $02 constant OTG_AHBERR                     \ [0x02] AHB error This error is generated only in Internal DMA mode when an AHB error occurs during an AHB read/write operation. The application can read the corresponding DMA channel address register to get the error address.
    $03 constant OTG_STALL                      \ [0x03] STALL response received interrupt. In Scatter/Gather DMA mode, the interrupt due to this bit is masked.
    $04 constant OTG_NAK                        \ [0x04] NAK response received interrupt. In Scatter/Gather DMA mode, the interrupt due to this bit is masked.
    $05 constant OTG_ACK                        \ [0x05] ACK response received/transmitted interrupt. In Scatter/Gather DMA mode, the interrupt due to this bit is masked.
    $06 constant OTG_NYET                       \ [0x06] Not yet ready response received interrupt. In Scatter/Gather DMA mode, the interrupt due to this bit is masked.
    $07 constant OTG_TXERR                      \ [0x07] Transaction error. In Scatter/Gather DMA mode, the interrupt due to this bit is masked. Indicates one of the following errors occurred on the USB. CRC check failure Timeout Bit stuff error False EOP
    $08 constant OTG_BBERR                      \ [0x08] Babble error. In Scatter/Gather DMA mode, the interrupt due to this bit is masked.
    $09 constant OTG_FRMOR                      \ [0x09] Frame overrun. In Scatter/Gather DMA mode, the interrupt due to this bit is masked.
    $0a constant OTG_DTERR                      \ [0x0a] Data toggle error. In Scatter/Gather DMA mode, the interrupt due to this bit is masked.
    $0b constant OTG_BNA                        \ [0x0b] Buffer not available interrupt. This bit is valid only when Scatter/Gather DMA mode is enabled. The core generates this interrupt when the descriptor accessed is not ready for the core to process. BNA interrupt is not generated for isochronous channels. For non Scatter/Gather DMA mode, this bit is reserved.
    $0c constant OTG_XCSXACTERR                 \ [0x0c] Excessive transaction error. This bit is valid only when Scatter/Gather DMA mode is enabled. The core sets this bit when 3 consecutive transaction errors occurred on the USB bus. XCS_XACT_ERR is not generated for isochronous channels. For non Scatter/Gather DMA mode, this bit is reserved.
    $0d constant OTG_DESCLSTROLL                \ [0x0d] Descriptor rollover interrupt. This bit is valid only when Scatter/Gather DMA mode is enabled. The core sets this bit when the corresponding channel descriptor list rolls over. For non Scatter/Gather DMA mode, this bit is reserved.
  [then]


  [ifdef] OTG_OTG_HCINTMSK10_DEF
    \
    \ @brief OTG host channel 10 interrupt mask register
    \ Address offset: 0x64C
    \ Reset value: 0x00000000
    \
    $00 constant OTG_XFRCM                      \ [0x00] Transfer completed mask
    $01 constant OTG_CHHM                       \ [0x01] Channel halted mask
    $02 constant OTG_AHBERRM                    \ [0x02] AHB error. In scatter/gather DMA mode for host, interrupts will not be generated due to the corresponding bits set in OTG_HCINTx.
    $03 constant OTG_STALLM                     \ [0x03] STALL response received interrupt mask. In Scatter/Gather DMA mode, the interrupt due to this bit is masked.
    $04 constant OTG_NAKM                       \ [0x04] NAK response received interrupt mask. In Scatter/Gather DMA mode, the interrupt due to this bit is masked.
    $05 constant OTG_ACKM                       \ [0x05] ACK response received/transmitted interrupt mask. In Scatter/Gather DMA mode, the interrupt due to this bit is masked.
    $06 constant OTG_NYET                       \ [0x06] response received interrupt mask. In Scatter/Gather DMA mode, the interrupt due to this bit is masked.
    $07 constant OTG_TXERRM                     \ [0x07] Transaction error mask. In Scatter/Gather DMA mode, the interrupt due to this bit is masked.
    $08 constant OTG_BBERRM                     \ [0x08] Babble error mask. In Scatter/Gather DMA mode, the interrupt due to this bit is masked.
    $09 constant OTG_FRMORM                     \ [0x09] Frame overrun mask. In Scatter/Gather DMA mode, the interrupt due to this bit is masked.
    $0a constant OTG_DTERRM                     \ [0x0a] Data toggle error mask. In Scatter/Gather DMA mode, the interrupt due to this bit is masked.
    $0b constant OTG_BNAMSK                     \ [0x0b] Buffer not available interrupt mask register. This bit is valid only when Scatter/Gather DMA mode is enabled. In non Scatter/Gather DMA mode, this bit is reserved
    $0d constant OTG_DESCLSTROLLMSK             \ [0x0d] Descriptor rollover interrupt mask register. This bit is valid only when Scatter/Gather DMA mode is enabled. In non Scatter/Gather DMA mode, this bit is reserved.
  [then]


  [ifdef] OTG_OTG_HCTSIZ10_DEF
    \
    \ @brief Transfer size For an OUT, this field is the number of data bytes the host sends during the transfer. For an IN, this field is the buffer size that the application has reserved for the transfer. The application is expected to program this field as an integer multiple of the maximum packet size for IN transactions (periodic and non-periodic).
    \ Address offset: 0x650
    \ Reset value: 0x00000000
    \
    $00 constant OTG_XFRSIZ                     \ [0x00 : 19] Transfer size For an OUT, this field is the number of data bytes the host sends during the transfer. For an IN, this field is the buffer size that the application has reserved for the transfer. The application is expected to program this field as an integer multiple of the maximum packet size for IN transactions (periodic and non-periodic).
    $13 constant OTG_PKTCNT                     \ [0x13 : 10] Packet count This field is programmed by the application with the expected number of packets to be transmitted (OUT) or received (IN). The host decrements this count on every successful transmission or reception of an OUT/IN packet. Once this count reaches zero, the application is interrupted to indicate normal completion.
    $1d constant OTG_DPID                       \ [0x1d : 2] Data PID The application programs this field with the type of PID to use for the initial transaction. The host maintains this field for the rest of the transfer.
    $1f constant OTG_DOPNG                      \ [0x1f] Do Ping This bit is used only for OUT transfers. Setting this field to 1 directs the host to do PING protocol. Note: Do not set this bit for IN transfers. If this bit is set for IN transfers, it disables the channel.
  [then]


  [ifdef] OTG_OTG_HCDMA10_DEF
    \
    \ @brief DMA address This field holds the start address in the external memory from which the data for the endpoint must be fetched or to which it must be stored. This register is incremented on every AHB transaction.
    \ Address offset: 0x654
    \ Reset value: 0x00000000
    \
    $00 constant OTG_DMAADDR                    \ [0x00 : 32] DMA address This field holds the start address in the external memory from which the data for the endpoint must be fetched or to which it must be stored. This register is incremented on every AHB transaction.
  [then]


  [ifdef] OTG_OTG_HCDMAB10_DEF
    \
    \ @brief DMA address This register holds the current buffer address (scatter/gather mode).
    \ Address offset: 0x65C
    \ Reset value: 0x00000000
    \
    $00 constant OTG_HCDMAB                     \ [0x00 : 32] DMA address This register holds the current buffer address (scatter/gather mode).
  [then]


  [ifdef] OTG_OTG_HCCHAR11_DEF
    \
    \ @brief Maximum packet size Indicates the maximum packet size of the associated endpoint.
    \ Address offset: 0x660
    \ Reset value: 0x00000000
    \
    $00 constant OTG_MPSIZ                      \ [0x00 : 11] Maximum packet size Indicates the maximum packet size of the associated endpoint.
    $0b constant OTG_EPNUM                      \ [0x0b : 4] Endpoint number Indicates the endpoint number on the device serving as the data source or sink.
    $0f constant OTG_EPDIR                      \ [0x0f] Endpoint direction Indicates whether the transaction is IN or OUT.
    $11 constant OTG_LSDEV                      \ [0x11] Low-speed device This field is set by the application to indicate that this channel is communicating to a low-speed device.
    $12 constant OTG_EPTYP                      \ [0x12 : 2] Endpoint type Indicates the transfer type selected.
    $14 constant OTG_MCNT                       \ [0x14 : 2] Multicount This field indicates to the host the number of transactions that must be executed per frame for this periodic endpoint. For non-periodic transfers, this field is not used Note: This field must be set to at least 01.
    $16 constant OTG_DAD                        \ [0x16 : 7] Device address This field selects the specific device serving as the data source or sink.
    $1d constant OTG_ODDFRM                     \ [0x1d] Odd frame This field is set (reset) by the application to indicate that the OTG host must perform a transfer in an odd frame. This field is applicable for only periodic (isochronous and interrupt) transactions.
    $1e constant OTG_CHDIS                      \ [0x1e] Channel disable The application sets this bit to stop transmitting/receiving data on a channel, even before the transfer for that channel is complete. The application must wait for the Channel disabled interrupt before treating the channel as disabled.
    $1f constant OTG_CHENA                      \ [0x1f] Channel enable When Scatter/Gather mode is enabled: 1'b0: Indicates that the descriptor structure is not yet ready 1'b1: Indicates that the descriptor structure and data buffer with data is setup and this channel can access the descriptor When Scatter/Gather mode is disabled: This field is set by the application and cleared by the OTG host.
  [then]


  [ifdef] OTG_OTG_HCSPLT11_DEF
    \
    \ @brief Port address This field is the port number of the recipient transaction translator.
    \ Address offset: 0x664
    \ Reset value: 0x00000000
    \
    $00 constant OTG_PRTADDR                    \ [0x00 : 7] Port address This field is the port number of the recipient transaction translator.
    $07 constant OTG_HUBADDR                    \ [0x07 : 7] Hub address This field holds the device address of the transaction translator's hub.
    $0e constant OTG_XACTPOS                    \ [0x0e : 2] Transaction position This field is used to determine whether to send all, first, middle, or last payloads with each OUT transaction.
    $10 constant OTG_COMPLSPLT                  \ [0x10] Do complete split The application sets this bit to request the OTG host to perform a complete split transaction.
    $1f constant OTG_SPLITEN                    \ [0x1f] Split enable The application sets this bit to indicate that this channel is enabled to perform split transactions.
  [then]


  [ifdef] OTG_OTG_HCINT11_DEF
    \
    \ @brief OTG host channel 11 interrupt register
    \ Address offset: 0x668
    \ Reset value: 0x00000000
    \
    $00 constant OTG_XFRC                       \ [0x00] Transfer completed. Transfer completed normally without any errors.
    $01 constant OTG_CHH                        \ [0x01] Channel halted. In non scatter/gather DMA mode indicates the transfer completed abnormally either because of any USB transaction error or in response to disable request by the application. In scatter/gather DMA mode, this indicates that transfer completed due to any of the following: EOL being set in descriptor AHB error Excessive transaction errors In response to disable request by the application Babble Stall
    $02 constant OTG_AHBERR                     \ [0x02] AHB error This error is generated only in Internal DMA mode when an AHB error occurs during an AHB read/write operation. The application can read the corresponding DMA channel address register to get the error address.
    $03 constant OTG_STALL                      \ [0x03] STALL response received interrupt. In Scatter/Gather DMA mode, the interrupt due to this bit is masked.
    $04 constant OTG_NAK                        \ [0x04] NAK response received interrupt. In Scatter/Gather DMA mode, the interrupt due to this bit is masked.
    $05 constant OTG_ACK                        \ [0x05] ACK response received/transmitted interrupt. In Scatter/Gather DMA mode, the interrupt due to this bit is masked.
    $06 constant OTG_NYET                       \ [0x06] Not yet ready response received interrupt. In Scatter/Gather DMA mode, the interrupt due to this bit is masked.
    $07 constant OTG_TXERR                      \ [0x07] Transaction error. In Scatter/Gather DMA mode, the interrupt due to this bit is masked. Indicates one of the following errors occurred on the USB. CRC check failure Timeout Bit stuff error False EOP
    $08 constant OTG_BBERR                      \ [0x08] Babble error. In Scatter/Gather DMA mode, the interrupt due to this bit is masked.
    $09 constant OTG_FRMOR                      \ [0x09] Frame overrun. In Scatter/Gather DMA mode, the interrupt due to this bit is masked.
    $0a constant OTG_DTERR                      \ [0x0a] Data toggle error. In Scatter/Gather DMA mode, the interrupt due to this bit is masked.
    $0b constant OTG_BNA                        \ [0x0b] Buffer not available interrupt. This bit is valid only when Scatter/Gather DMA mode is enabled. The core generates this interrupt when the descriptor accessed is not ready for the core to process. BNA interrupt is not generated for isochronous channels. For non Scatter/Gather DMA mode, this bit is reserved.
    $0c constant OTG_XCSXACTERR                 \ [0x0c] Excessive transaction error. This bit is valid only when Scatter/Gather DMA mode is enabled. The core sets this bit when 3 consecutive transaction errors occurred on the USB bus. XCS_XACT_ERR is not generated for isochronous channels. For non Scatter/Gather DMA mode, this bit is reserved.
    $0d constant OTG_DESCLSTROLL                \ [0x0d] Descriptor rollover interrupt. This bit is valid only when Scatter/Gather DMA mode is enabled. The core sets this bit when the corresponding channel descriptor list rolls over. For non Scatter/Gather DMA mode, this bit is reserved.
  [then]


  [ifdef] OTG_OTG_HCINTMSK11_DEF
    \
    \ @brief OTG host channel 11 interrupt mask register
    \ Address offset: 0x66C
    \ Reset value: 0x00000000
    \
    $00 constant OTG_XFRCM                      \ [0x00] Transfer completed mask
    $01 constant OTG_CHHM                       \ [0x01] Channel halted mask
    $02 constant OTG_AHBERRM                    \ [0x02] AHB error. In scatter/gather DMA mode for host, interrupts will not be generated due to the corresponding bits set in OTG_HCINTx.
    $03 constant OTG_STALLM                     \ [0x03] STALL response received interrupt mask. In Scatter/Gather DMA mode, the interrupt due to this bit is masked.
    $04 constant OTG_NAKM                       \ [0x04] NAK response received interrupt mask. In Scatter/Gather DMA mode, the interrupt due to this bit is masked.
    $05 constant OTG_ACKM                       \ [0x05] ACK response received/transmitted interrupt mask. In Scatter/Gather DMA mode, the interrupt due to this bit is masked.
    $06 constant OTG_NYET                       \ [0x06] response received interrupt mask. In Scatter/Gather DMA mode, the interrupt due to this bit is masked.
    $07 constant OTG_TXERRM                     \ [0x07] Transaction error mask. In Scatter/Gather DMA mode, the interrupt due to this bit is masked.
    $08 constant OTG_BBERRM                     \ [0x08] Babble error mask. In Scatter/Gather DMA mode, the interrupt due to this bit is masked.
    $09 constant OTG_FRMORM                     \ [0x09] Frame overrun mask. In Scatter/Gather DMA mode, the interrupt due to this bit is masked.
    $0a constant OTG_DTERRM                     \ [0x0a] Data toggle error mask. In Scatter/Gather DMA mode, the interrupt due to this bit is masked.
    $0b constant OTG_BNAMSK                     \ [0x0b] Buffer not available interrupt mask register. This bit is valid only when Scatter/Gather DMA mode is enabled. In non Scatter/Gather DMA mode, this bit is reserved
    $0d constant OTG_DESCLSTROLLMSK             \ [0x0d] Descriptor rollover interrupt mask register. This bit is valid only when Scatter/Gather DMA mode is enabled. In non Scatter/Gather DMA mode, this bit is reserved.
  [then]


  [ifdef] OTG_OTG_HCTSIZ11_DEF
    \
    \ @brief Transfer size For an OUT, this field is the number of data bytes the host sends during the transfer. For an IN, this field is the buffer size that the application has reserved for the transfer. The application is expected to program this field as an integer multiple of the maximum packet size for IN transactions (periodic and non-periodic).
    \ Address offset: 0x670
    \ Reset value: 0x00000000
    \
    $00 constant OTG_XFRSIZ                     \ [0x00 : 19] Transfer size For an OUT, this field is the number of data bytes the host sends during the transfer. For an IN, this field is the buffer size that the application has reserved for the transfer. The application is expected to program this field as an integer multiple of the maximum packet size for IN transactions (periodic and non-periodic).
    $13 constant OTG_PKTCNT                     \ [0x13 : 10] Packet count This field is programmed by the application with the expected number of packets to be transmitted (OUT) or received (IN). The host decrements this count on every successful transmission or reception of an OUT/IN packet. Once this count reaches zero, the application is interrupted to indicate normal completion.
    $1d constant OTG_DPID                       \ [0x1d : 2] Data PID The application programs this field with the type of PID to use for the initial transaction. The host maintains this field for the rest of the transfer.
    $1f constant OTG_DOPNG                      \ [0x1f] Do Ping This bit is used only for OUT transfers. Setting this field to 1 directs the host to do PING protocol. Note: Do not set this bit for IN transfers. If this bit is set for IN transfers, it disables the channel.
  [then]


  [ifdef] OTG_OTG_HCDMA11_DEF
    \
    \ @brief DMA address This field holds the start address in the external memory from which the data for the endpoint must be fetched or to which it must be stored. This register is incremented on every AHB transaction.
    \ Address offset: 0x674
    \ Reset value: 0x00000000
    \
    $00 constant OTG_DMAADDR                    \ [0x00 : 32] DMA address This field holds the start address in the external memory from which the data for the endpoint must be fetched or to which it must be stored. This register is incremented on every AHB transaction.
  [then]


  [ifdef] OTG_OTG_HCDMAB11_DEF
    \
    \ @brief DMA address This register holds the current buffer address (scatter/gather mode).
    \ Address offset: 0x67C
    \ Reset value: 0x00000000
    \
    $00 constant OTG_HCDMAB                     \ [0x00 : 32] DMA address This register holds the current buffer address (scatter/gather mode).
  [then]


  [ifdef] OTG_OTG_HCCHAR12_DEF
    \
    \ @brief Maximum packet size Indicates the maximum packet size of the associated endpoint.
    \ Address offset: 0x680
    \ Reset value: 0x00000000
    \
    $00 constant OTG_MPSIZ                      \ [0x00 : 11] Maximum packet size Indicates the maximum packet size of the associated endpoint.
    $0b constant OTG_EPNUM                      \ [0x0b : 4] Endpoint number Indicates the endpoint number on the device serving as the data source or sink.
    $0f constant OTG_EPDIR                      \ [0x0f] Endpoint direction Indicates whether the transaction is IN or OUT.
    $11 constant OTG_LSDEV                      \ [0x11] Low-speed device This field is set by the application to indicate that this channel is communicating to a low-speed device.
    $12 constant OTG_EPTYP                      \ [0x12 : 2] Endpoint type Indicates the transfer type selected.
    $14 constant OTG_MCNT                       \ [0x14 : 2] Multicount This field indicates to the host the number of transactions that must be executed per frame for this periodic endpoint. For non-periodic transfers, this field is not used Note: This field must be set to at least 01.
    $16 constant OTG_DAD                        \ [0x16 : 7] Device address This field selects the specific device serving as the data source or sink.
    $1d constant OTG_ODDFRM                     \ [0x1d] Odd frame This field is set (reset) by the application to indicate that the OTG host must perform a transfer in an odd frame. This field is applicable for only periodic (isochronous and interrupt) transactions.
    $1e constant OTG_CHDIS                      \ [0x1e] Channel disable The application sets this bit to stop transmitting/receiving data on a channel, even before the transfer for that channel is complete. The application must wait for the Channel disabled interrupt before treating the channel as disabled.
    $1f constant OTG_CHENA                      \ [0x1f] Channel enable When Scatter/Gather mode is enabled: 1'b0: Indicates that the descriptor structure is not yet ready 1'b1: Indicates that the descriptor structure and data buffer with data is setup and this channel can access the descriptor When Scatter/Gather mode is disabled: This field is set by the application and cleared by the OTG host.
  [then]


  [ifdef] OTG_OTG_HCSPLT12_DEF
    \
    \ @brief Port address This field is the port number of the recipient transaction translator.
    \ Address offset: 0x684
    \ Reset value: 0x00000000
    \
    $00 constant OTG_PRTADDR                    \ [0x00 : 7] Port address This field is the port number of the recipient transaction translator.
    $07 constant OTG_HUBADDR                    \ [0x07 : 7] Hub address This field holds the device address of the transaction translator's hub.
    $0e constant OTG_XACTPOS                    \ [0x0e : 2] Transaction position This field is used to determine whether to send all, first, middle, or last payloads with each OUT transaction.
    $10 constant OTG_COMPLSPLT                  \ [0x10] Do complete split The application sets this bit to request the OTG host to perform a complete split transaction.
    $1f constant OTG_SPLITEN                    \ [0x1f] Split enable The application sets this bit to indicate that this channel is enabled to perform split transactions.
  [then]


  [ifdef] OTG_OTG_HCINT12_DEF
    \
    \ @brief OTG host channel 12 interrupt register
    \ Address offset: 0x688
    \ Reset value: 0x00000000
    \
    $00 constant OTG_XFRC                       \ [0x00] Transfer completed. Transfer completed normally without any errors.
    $01 constant OTG_CHH                        \ [0x01] Channel halted. In non scatter/gather DMA mode indicates the transfer completed abnormally either because of any USB transaction error or in response to disable request by the application. In scatter/gather DMA mode, this indicates that transfer completed due to any of the following: EOL being set in descriptor AHB error Excessive transaction errors In response to disable request by the application Babble Stall
    $02 constant OTG_AHBERR                     \ [0x02] AHB error This error is generated only in Internal DMA mode when an AHB error occurs during an AHB read/write operation. The application can read the corresponding DMA channel address register to get the error address.
    $03 constant OTG_STALL                      \ [0x03] STALL response received interrupt. In Scatter/Gather DMA mode, the interrupt due to this bit is masked.
    $04 constant OTG_NAK                        \ [0x04] NAK response received interrupt. In Scatter/Gather DMA mode, the interrupt due to this bit is masked.
    $05 constant OTG_ACK                        \ [0x05] ACK response received/transmitted interrupt. In Scatter/Gather DMA mode, the interrupt due to this bit is masked.
    $06 constant OTG_NYET                       \ [0x06] Not yet ready response received interrupt. In Scatter/Gather DMA mode, the interrupt due to this bit is masked.
    $07 constant OTG_TXERR                      \ [0x07] Transaction error. In Scatter/Gather DMA mode, the interrupt due to this bit is masked. Indicates one of the following errors occurred on the USB. CRC check failure Timeout Bit stuff error False EOP
    $08 constant OTG_BBERR                      \ [0x08] Babble error. In Scatter/Gather DMA mode, the interrupt due to this bit is masked.
    $09 constant OTG_FRMOR                      \ [0x09] Frame overrun. In Scatter/Gather DMA mode, the interrupt due to this bit is masked.
    $0a constant OTG_DTERR                      \ [0x0a] Data toggle error. In Scatter/Gather DMA mode, the interrupt due to this bit is masked.
    $0b constant OTG_BNA                        \ [0x0b] Buffer not available interrupt. This bit is valid only when Scatter/Gather DMA mode is enabled. The core generates this interrupt when the descriptor accessed is not ready for the core to process. BNA interrupt is not generated for isochronous channels. For non Scatter/Gather DMA mode, this bit is reserved.
    $0c constant OTG_XCSXACTERR                 \ [0x0c] Excessive transaction error. This bit is valid only when Scatter/Gather DMA mode is enabled. The core sets this bit when 3 consecutive transaction errors occurred on the USB bus. XCS_XACT_ERR is not generated for isochronous channels. For non Scatter/Gather DMA mode, this bit is reserved.
    $0d constant OTG_DESCLSTROLL                \ [0x0d] Descriptor rollover interrupt. This bit is valid only when Scatter/Gather DMA mode is enabled. The core sets this bit when the corresponding channel descriptor list rolls over. For non Scatter/Gather DMA mode, this bit is reserved.
  [then]


  [ifdef] OTG_OTG_HCINTMSK12_DEF
    \
    \ @brief OTG host channel 12 interrupt mask register
    \ Address offset: 0x68C
    \ Reset value: 0x00000000
    \
    $00 constant OTG_XFRCM                      \ [0x00] Transfer completed mask
    $01 constant OTG_CHHM                       \ [0x01] Channel halted mask
    $02 constant OTG_AHBERRM                    \ [0x02] AHB error. In scatter/gather DMA mode for host, interrupts will not be generated due to the corresponding bits set in OTG_HCINTx.
    $03 constant OTG_STALLM                     \ [0x03] STALL response received interrupt mask. In Scatter/Gather DMA mode, the interrupt due to this bit is masked.
    $04 constant OTG_NAKM                       \ [0x04] NAK response received interrupt mask. In Scatter/Gather DMA mode, the interrupt due to this bit is masked.
    $05 constant OTG_ACKM                       \ [0x05] ACK response received/transmitted interrupt mask. In Scatter/Gather DMA mode, the interrupt due to this bit is masked.
    $06 constant OTG_NYET                       \ [0x06] response received interrupt mask. In Scatter/Gather DMA mode, the interrupt due to this bit is masked.
    $07 constant OTG_TXERRM                     \ [0x07] Transaction error mask. In Scatter/Gather DMA mode, the interrupt due to this bit is masked.
    $08 constant OTG_BBERRM                     \ [0x08] Babble error mask. In Scatter/Gather DMA mode, the interrupt due to this bit is masked.
    $09 constant OTG_FRMORM                     \ [0x09] Frame overrun mask. In Scatter/Gather DMA mode, the interrupt due to this bit is masked.
    $0a constant OTG_DTERRM                     \ [0x0a] Data toggle error mask. In Scatter/Gather DMA mode, the interrupt due to this bit is masked.
    $0b constant OTG_BNAMSK                     \ [0x0b] Buffer not available interrupt mask register. This bit is valid only when Scatter/Gather DMA mode is enabled. In non Scatter/Gather DMA mode, this bit is reserved
    $0d constant OTG_DESCLSTROLLMSK             \ [0x0d] Descriptor rollover interrupt mask register. This bit is valid only when Scatter/Gather DMA mode is enabled. In non Scatter/Gather DMA mode, this bit is reserved.
  [then]


  [ifdef] OTG_OTG_HCTSIZ12_DEF
    \
    \ @brief Transfer size For an OUT, this field is the number of data bytes the host sends during the transfer. For an IN, this field is the buffer size that the application has reserved for the transfer. The application is expected to program this field as an integer multiple of the maximum packet size for IN transactions (periodic and non-periodic).
    \ Address offset: 0x690
    \ Reset value: 0x00000000
    \
    $00 constant OTG_XFRSIZ                     \ [0x00 : 19] Transfer size For an OUT, this field is the number of data bytes the host sends during the transfer. For an IN, this field is the buffer size that the application has reserved for the transfer. The application is expected to program this field as an integer multiple of the maximum packet size for IN transactions (periodic and non-periodic).
    $13 constant OTG_PKTCNT                     \ [0x13 : 10] Packet count This field is programmed by the application with the expected number of packets to be transmitted (OUT) or received (IN). The host decrements this count on every successful transmission or reception of an OUT/IN packet. Once this count reaches zero, the application is interrupted to indicate normal completion.
    $1d constant OTG_DPID                       \ [0x1d : 2] Data PID The application programs this field with the type of PID to use for the initial transaction. The host maintains this field for the rest of the transfer.
    $1f constant OTG_DOPNG                      \ [0x1f] Do Ping This bit is used only for OUT transfers. Setting this field to 1 directs the host to do PING protocol. Note: Do not set this bit for IN transfers. If this bit is set for IN transfers, it disables the channel.
  [then]


  [ifdef] OTG_OTG_HCDMA12_DEF
    \
    \ @brief DMA address This field holds the start address in the external memory from which the data for the endpoint must be fetched or to which it must be stored. This register is incremented on every AHB transaction.
    \ Address offset: 0x694
    \ Reset value: 0x00000000
    \
    $00 constant OTG_DMAADDR                    \ [0x00 : 32] DMA address This field holds the start address in the external memory from which the data for the endpoint must be fetched or to which it must be stored. This register is incremented on every AHB transaction.
  [then]


  [ifdef] OTG_OTG_HCDMAB12_DEF
    \
    \ @brief DMA address This register holds the current buffer address (scatter/gather mode).
    \ Address offset: 0x69C
    \ Reset value: 0x00000000
    \
    $00 constant OTG_HCDMAB                     \ [0x00 : 32] DMA address This register holds the current buffer address (scatter/gather mode).
  [then]


  [ifdef] OTG_OTG_HCCHAR13_DEF
    \
    \ @brief Maximum packet size Indicates the maximum packet size of the associated endpoint.
    \ Address offset: 0x6A0
    \ Reset value: 0x00000000
    \
    $00 constant OTG_MPSIZ                      \ [0x00 : 11] Maximum packet size Indicates the maximum packet size of the associated endpoint.
    $0b constant OTG_EPNUM                      \ [0x0b : 4] Endpoint number Indicates the endpoint number on the device serving as the data source or sink.
    $0f constant OTG_EPDIR                      \ [0x0f] Endpoint direction Indicates whether the transaction is IN or OUT.
    $11 constant OTG_LSDEV                      \ [0x11] Low-speed device This field is set by the application to indicate that this channel is communicating to a low-speed device.
    $12 constant OTG_EPTYP                      \ [0x12 : 2] Endpoint type Indicates the transfer type selected.
    $14 constant OTG_MCNT                       \ [0x14 : 2] Multicount This field indicates to the host the number of transactions that must be executed per frame for this periodic endpoint. For non-periodic transfers, this field is not used Note: This field must be set to at least 01.
    $16 constant OTG_DAD                        \ [0x16 : 7] Device address This field selects the specific device serving as the data source or sink.
    $1d constant OTG_ODDFRM                     \ [0x1d] Odd frame This field is set (reset) by the application to indicate that the OTG host must perform a transfer in an odd frame. This field is applicable for only periodic (isochronous and interrupt) transactions.
    $1e constant OTG_CHDIS                      \ [0x1e] Channel disable The application sets this bit to stop transmitting/receiving data on a channel, even before the transfer for that channel is complete. The application must wait for the Channel disabled interrupt before treating the channel as disabled.
    $1f constant OTG_CHENA                      \ [0x1f] Channel enable When Scatter/Gather mode is enabled: 1'b0: Indicates that the descriptor structure is not yet ready 1'b1: Indicates that the descriptor structure and data buffer with data is setup and this channel can access the descriptor When Scatter/Gather mode is disabled: This field is set by the application and cleared by the OTG host.
  [then]


  [ifdef] OTG_OTG_HCSPLT13_DEF
    \
    \ @brief Port address This field is the port number of the recipient transaction translator.
    \ Address offset: 0x6A4
    \ Reset value: 0x00000000
    \
    $00 constant OTG_PRTADDR                    \ [0x00 : 7] Port address This field is the port number of the recipient transaction translator.
    $07 constant OTG_HUBADDR                    \ [0x07 : 7] Hub address This field holds the device address of the transaction translator's hub.
    $0e constant OTG_XACTPOS                    \ [0x0e : 2] Transaction position This field is used to determine whether to send all, first, middle, or last payloads with each OUT transaction.
    $10 constant OTG_COMPLSPLT                  \ [0x10] Do complete split The application sets this bit to request the OTG host to perform a complete split transaction.
    $1f constant OTG_SPLITEN                    \ [0x1f] Split enable The application sets this bit to indicate that this channel is enabled to perform split transactions.
  [then]


  [ifdef] OTG_OTG_HCINT13_DEF
    \
    \ @brief OTG host channel 13 interrupt register
    \ Address offset: 0x6A8
    \ Reset value: 0x00000000
    \
    $00 constant OTG_XFRC                       \ [0x00] Transfer completed. Transfer completed normally without any errors.
    $01 constant OTG_CHH                        \ [0x01] Channel halted. In non scatter/gather DMA mode indicates the transfer completed abnormally either because of any USB transaction error or in response to disable request by the application. In scatter/gather DMA mode, this indicates that transfer completed due to any of the following: EOL being set in descriptor AHB error Excessive transaction errors In response to disable request by the application Babble Stall
    $02 constant OTG_AHBERR                     \ [0x02] AHB error This error is generated only in Internal DMA mode when an AHB error occurs during an AHB read/write operation. The application can read the corresponding DMA channel address register to get the error address.
    $03 constant OTG_STALL                      \ [0x03] STALL response received interrupt. In Scatter/Gather DMA mode, the interrupt due to this bit is masked.
    $04 constant OTG_NAK                        \ [0x04] NAK response received interrupt. In Scatter/Gather DMA mode, the interrupt due to this bit is masked.
    $05 constant OTG_ACK                        \ [0x05] ACK response received/transmitted interrupt. In Scatter/Gather DMA mode, the interrupt due to this bit is masked.
    $06 constant OTG_NYET                       \ [0x06] Not yet ready response received interrupt. In Scatter/Gather DMA mode, the interrupt due to this bit is masked.
    $07 constant OTG_TXERR                      \ [0x07] Transaction error. In Scatter/Gather DMA mode, the interrupt due to this bit is masked. Indicates one of the following errors occurred on the USB. CRC check failure Timeout Bit stuff error False EOP
    $08 constant OTG_BBERR                      \ [0x08] Babble error. In Scatter/Gather DMA mode, the interrupt due to this bit is masked.
    $09 constant OTG_FRMOR                      \ [0x09] Frame overrun. In Scatter/Gather DMA mode, the interrupt due to this bit is masked.
    $0a constant OTG_DTERR                      \ [0x0a] Data toggle error. In Scatter/Gather DMA mode, the interrupt due to this bit is masked.
    $0b constant OTG_BNA                        \ [0x0b] Buffer not available interrupt. This bit is valid only when Scatter/Gather DMA mode is enabled. The core generates this interrupt when the descriptor accessed is not ready for the core to process. BNA interrupt is not generated for isochronous channels. For non Scatter/Gather DMA mode, this bit is reserved.
    $0c constant OTG_XCSXACTERR                 \ [0x0c] Excessive transaction error. This bit is valid only when Scatter/Gather DMA mode is enabled. The core sets this bit when 3 consecutive transaction errors occurred on the USB bus. XCS_XACT_ERR is not generated for isochronous channels. For non Scatter/Gather DMA mode, this bit is reserved.
    $0d constant OTG_DESCLSTROLL                \ [0x0d] Descriptor rollover interrupt. This bit is valid only when Scatter/Gather DMA mode is enabled. The core sets this bit when the corresponding channel descriptor list rolls over. For non Scatter/Gather DMA mode, this bit is reserved.
  [then]


  [ifdef] OTG_OTG_HCINTMSK13_DEF
    \
    \ @brief OTG host channel 13 interrupt mask register
    \ Address offset: 0x6AC
    \ Reset value: 0x00000000
    \
    $00 constant OTG_XFRCM                      \ [0x00] Transfer completed mask
    $01 constant OTG_CHHM                       \ [0x01] Channel halted mask
    $02 constant OTG_AHBERRM                    \ [0x02] AHB error. In scatter/gather DMA mode for host, interrupts will not be generated due to the corresponding bits set in OTG_HCINTx.
    $03 constant OTG_STALLM                     \ [0x03] STALL response received interrupt mask. In Scatter/Gather DMA mode, the interrupt due to this bit is masked.
    $04 constant OTG_NAKM                       \ [0x04] NAK response received interrupt mask. In Scatter/Gather DMA mode, the interrupt due to this bit is masked.
    $05 constant OTG_ACKM                       \ [0x05] ACK response received/transmitted interrupt mask. In Scatter/Gather DMA mode, the interrupt due to this bit is masked.
    $06 constant OTG_NYET                       \ [0x06] response received interrupt mask. In Scatter/Gather DMA mode, the interrupt due to this bit is masked.
    $07 constant OTG_TXERRM                     \ [0x07] Transaction error mask. In Scatter/Gather DMA mode, the interrupt due to this bit is masked.
    $08 constant OTG_BBERRM                     \ [0x08] Babble error mask. In Scatter/Gather DMA mode, the interrupt due to this bit is masked.
    $09 constant OTG_FRMORM                     \ [0x09] Frame overrun mask. In Scatter/Gather DMA mode, the interrupt due to this bit is masked.
    $0a constant OTG_DTERRM                     \ [0x0a] Data toggle error mask. In Scatter/Gather DMA mode, the interrupt due to this bit is masked.
    $0b constant OTG_BNAMSK                     \ [0x0b] Buffer not available interrupt mask register. This bit is valid only when Scatter/Gather DMA mode is enabled. In non Scatter/Gather DMA mode, this bit is reserved
    $0d constant OTG_DESCLSTROLLMSK             \ [0x0d] Descriptor rollover interrupt mask register. This bit is valid only when Scatter/Gather DMA mode is enabled. In non Scatter/Gather DMA mode, this bit is reserved.
  [then]


  [ifdef] OTG_OTG_HCTSIZ13_DEF
    \
    \ @brief Transfer size For an OUT, this field is the number of data bytes the host sends during the transfer. For an IN, this field is the buffer size that the application has reserved for the transfer. The application is expected to program this field as an integer multiple of the maximum packet size for IN transactions (periodic and non-periodic).
    \ Address offset: 0x6B0
    \ Reset value: 0x00000000
    \
    $00 constant OTG_XFRSIZ                     \ [0x00 : 19] Transfer size For an OUT, this field is the number of data bytes the host sends during the transfer. For an IN, this field is the buffer size that the application has reserved for the transfer. The application is expected to program this field as an integer multiple of the maximum packet size for IN transactions (periodic and non-periodic).
    $13 constant OTG_PKTCNT                     \ [0x13 : 10] Packet count This field is programmed by the application with the expected number of packets to be transmitted (OUT) or received (IN). The host decrements this count on every successful transmission or reception of an OUT/IN packet. Once this count reaches zero, the application is interrupted to indicate normal completion.
    $1d constant OTG_DPID                       \ [0x1d : 2] Data PID The application programs this field with the type of PID to use for the initial transaction. The host maintains this field for the rest of the transfer.
    $1f constant OTG_DOPNG                      \ [0x1f] Do Ping This bit is used only for OUT transfers. Setting this field to 1 directs the host to do PING protocol. Note: Do not set this bit for IN transfers. If this bit is set for IN transfers, it disables the channel.
  [then]


  [ifdef] OTG_OTG_HCDMA13_DEF
    \
    \ @brief DMA address This field holds the start address in the external memory from which the data for the endpoint must be fetched or to which it must be stored. This register is incremented on every AHB transaction.
    \ Address offset: 0x6B4
    \ Reset value: 0x00000000
    \
    $00 constant OTG_DMAADDR                    \ [0x00 : 32] DMA address This field holds the start address in the external memory from which the data for the endpoint must be fetched or to which it must be stored. This register is incremented on every AHB transaction.
  [then]


  [ifdef] OTG_OTG_HCDMAB13_DEF
    \
    \ @brief DMA address This register holds the current buffer address (scatter/gather mode).
    \ Address offset: 0x6BC
    \ Reset value: 0x00000000
    \
    $00 constant OTG_HCDMAB                     \ [0x00 : 32] DMA address This register holds the current buffer address (scatter/gather mode).
  [then]


  [ifdef] OTG_OTG_HCCHAR14_DEF
    \
    \ @brief Maximum packet size Indicates the maximum packet size of the associated endpoint.
    \ Address offset: 0x6C0
    \ Reset value: 0x00000000
    \
    $00 constant OTG_MPSIZ                      \ [0x00 : 11] Maximum packet size Indicates the maximum packet size of the associated endpoint.
    $0b constant OTG_EPNUM                      \ [0x0b : 4] Endpoint number Indicates the endpoint number on the device serving as the data source or sink.
    $0f constant OTG_EPDIR                      \ [0x0f] Endpoint direction Indicates whether the transaction is IN or OUT.
    $11 constant OTG_LSDEV                      \ [0x11] Low-speed device This field is set by the application to indicate that this channel is communicating to a low-speed device.
    $12 constant OTG_EPTYP                      \ [0x12 : 2] Endpoint type Indicates the transfer type selected.
    $14 constant OTG_MCNT                       \ [0x14 : 2] Multicount This field indicates to the host the number of transactions that must be executed per frame for this periodic endpoint. For non-periodic transfers, this field is not used Note: This field must be set to at least 01.
    $16 constant OTG_DAD                        \ [0x16 : 7] Device address This field selects the specific device serving as the data source or sink.
    $1d constant OTG_ODDFRM                     \ [0x1d] Odd frame This field is set (reset) by the application to indicate that the OTG host must perform a transfer in an odd frame. This field is applicable for only periodic (isochronous and interrupt) transactions.
    $1e constant OTG_CHDIS                      \ [0x1e] Channel disable The application sets this bit to stop transmitting/receiving data on a channel, even before the transfer for that channel is complete. The application must wait for the Channel disabled interrupt before treating the channel as disabled.
    $1f constant OTG_CHENA                      \ [0x1f] Channel enable When Scatter/Gather mode is enabled: 1'b0: Indicates that the descriptor structure is not yet ready 1'b1: Indicates that the descriptor structure and data buffer with data is setup and this channel can access the descriptor When Scatter/Gather mode is disabled: This field is set by the application and cleared by the OTG host.
  [then]


  [ifdef] OTG_OTG_HCSPLT14_DEF
    \
    \ @brief Port address This field is the port number of the recipient transaction translator.
    \ Address offset: 0x6C4
    \ Reset value: 0x00000000
    \
    $00 constant OTG_PRTADDR                    \ [0x00 : 7] Port address This field is the port number of the recipient transaction translator.
    $07 constant OTG_HUBADDR                    \ [0x07 : 7] Hub address This field holds the device address of the transaction translator's hub.
    $0e constant OTG_XACTPOS                    \ [0x0e : 2] Transaction position This field is used to determine whether to send all, first, middle, or last payloads with each OUT transaction.
    $10 constant OTG_COMPLSPLT                  \ [0x10] Do complete split The application sets this bit to request the OTG host to perform a complete split transaction.
    $1f constant OTG_SPLITEN                    \ [0x1f] Split enable The application sets this bit to indicate that this channel is enabled to perform split transactions.
  [then]


  [ifdef] OTG_OTG_HCINT14_DEF
    \
    \ @brief OTG host channel 14 interrupt register
    \ Address offset: 0x6C8
    \ Reset value: 0x00000000
    \
    $00 constant OTG_XFRC                       \ [0x00] Transfer completed. Transfer completed normally without any errors.
    $01 constant OTG_CHH                        \ [0x01] Channel halted. In non scatter/gather DMA mode indicates the transfer completed abnormally either because of any USB transaction error or in response to disable request by the application. In scatter/gather DMA mode, this indicates that transfer completed due to any of the following: EOL being set in descriptor AHB error Excessive transaction errors In response to disable request by the application Babble Stall
    $02 constant OTG_AHBERR                     \ [0x02] AHB error This error is generated only in Internal DMA mode when an AHB error occurs during an AHB read/write operation. The application can read the corresponding DMA channel address register to get the error address.
    $03 constant OTG_STALL                      \ [0x03] STALL response received interrupt. In Scatter/Gather DMA mode, the interrupt due to this bit is masked.
    $04 constant OTG_NAK                        \ [0x04] NAK response received interrupt. In Scatter/Gather DMA mode, the interrupt due to this bit is masked.
    $05 constant OTG_ACK                        \ [0x05] ACK response received/transmitted interrupt. In Scatter/Gather DMA mode, the interrupt due to this bit is masked.
    $06 constant OTG_NYET                       \ [0x06] Not yet ready response received interrupt. In Scatter/Gather DMA mode, the interrupt due to this bit is masked.
    $07 constant OTG_TXERR                      \ [0x07] Transaction error. In Scatter/Gather DMA mode, the interrupt due to this bit is masked. Indicates one of the following errors occurred on the USB. CRC check failure Timeout Bit stuff error False EOP
    $08 constant OTG_BBERR                      \ [0x08] Babble error. In Scatter/Gather DMA mode, the interrupt due to this bit is masked.
    $09 constant OTG_FRMOR                      \ [0x09] Frame overrun. In Scatter/Gather DMA mode, the interrupt due to this bit is masked.
    $0a constant OTG_DTERR                      \ [0x0a] Data toggle error. In Scatter/Gather DMA mode, the interrupt due to this bit is masked.
    $0b constant OTG_BNA                        \ [0x0b] Buffer not available interrupt. This bit is valid only when Scatter/Gather DMA mode is enabled. The core generates this interrupt when the descriptor accessed is not ready for the core to process. BNA interrupt is not generated for isochronous channels. For non Scatter/Gather DMA mode, this bit is reserved.
    $0c constant OTG_XCSXACTERR                 \ [0x0c] Excessive transaction error. This bit is valid only when Scatter/Gather DMA mode is enabled. The core sets this bit when 3 consecutive transaction errors occurred on the USB bus. XCS_XACT_ERR is not generated for isochronous channels. For non Scatter/Gather DMA mode, this bit is reserved.
    $0d constant OTG_DESCLSTROLL                \ [0x0d] Descriptor rollover interrupt. This bit is valid only when Scatter/Gather DMA mode is enabled. The core sets this bit when the corresponding channel descriptor list rolls over. For non Scatter/Gather DMA mode, this bit is reserved.
  [then]


  [ifdef] OTG_OTG_HCINTMSK14_DEF
    \
    \ @brief OTG host channel 14 interrupt mask register
    \ Address offset: 0x6CC
    \ Reset value: 0x00000000
    \
    $00 constant OTG_XFRCM                      \ [0x00] Transfer completed mask
    $01 constant OTG_CHHM                       \ [0x01] Channel halted mask
    $02 constant OTG_AHBERRM                    \ [0x02] AHB error. In scatter/gather DMA mode for host, interrupts will not be generated due to the corresponding bits set in OTG_HCINTx.
    $03 constant OTG_STALLM                     \ [0x03] STALL response received interrupt mask. In Scatter/Gather DMA mode, the interrupt due to this bit is masked.
    $04 constant OTG_NAKM                       \ [0x04] NAK response received interrupt mask. In Scatter/Gather DMA mode, the interrupt due to this bit is masked.
    $05 constant OTG_ACKM                       \ [0x05] ACK response received/transmitted interrupt mask. In Scatter/Gather DMA mode, the interrupt due to this bit is masked.
    $06 constant OTG_NYET                       \ [0x06] response received interrupt mask. In Scatter/Gather DMA mode, the interrupt due to this bit is masked.
    $07 constant OTG_TXERRM                     \ [0x07] Transaction error mask. In Scatter/Gather DMA mode, the interrupt due to this bit is masked.
    $08 constant OTG_BBERRM                     \ [0x08] Babble error mask. In Scatter/Gather DMA mode, the interrupt due to this bit is masked.
    $09 constant OTG_FRMORM                     \ [0x09] Frame overrun mask. In Scatter/Gather DMA mode, the interrupt due to this bit is masked.
    $0a constant OTG_DTERRM                     \ [0x0a] Data toggle error mask. In Scatter/Gather DMA mode, the interrupt due to this bit is masked.
    $0b constant OTG_BNAMSK                     \ [0x0b] Buffer not available interrupt mask register. This bit is valid only when Scatter/Gather DMA mode is enabled. In non Scatter/Gather DMA mode, this bit is reserved
    $0d constant OTG_DESCLSTROLLMSK             \ [0x0d] Descriptor rollover interrupt mask register. This bit is valid only when Scatter/Gather DMA mode is enabled. In non Scatter/Gather DMA mode, this bit is reserved.
  [then]


  [ifdef] OTG_OTG_HCTSIZ14_DEF
    \
    \ @brief Transfer size For an OUT, this field is the number of data bytes the host sends during the transfer. For an IN, this field is the buffer size that the application has reserved for the transfer. The application is expected to program this field as an integer multiple of the maximum packet size for IN transactions (periodic and non-periodic).
    \ Address offset: 0x6D0
    \ Reset value: 0x00000000
    \
    $00 constant OTG_XFRSIZ                     \ [0x00 : 19] Transfer size For an OUT, this field is the number of data bytes the host sends during the transfer. For an IN, this field is the buffer size that the application has reserved for the transfer. The application is expected to program this field as an integer multiple of the maximum packet size for IN transactions (periodic and non-periodic).
    $13 constant OTG_PKTCNT                     \ [0x13 : 10] Packet count This field is programmed by the application with the expected number of packets to be transmitted (OUT) or received (IN). The host decrements this count on every successful transmission or reception of an OUT/IN packet. Once this count reaches zero, the application is interrupted to indicate normal completion.
    $1d constant OTG_DPID                       \ [0x1d : 2] Data PID The application programs this field with the type of PID to use for the initial transaction. The host maintains this field for the rest of the transfer.
    $1f constant OTG_DOPNG                      \ [0x1f] Do Ping This bit is used only for OUT transfers. Setting this field to 1 directs the host to do PING protocol. Note: Do not set this bit for IN transfers. If this bit is set for IN transfers, it disables the channel.
  [then]


  [ifdef] OTG_OTG_HCDMA14_DEF
    \
    \ @brief DMA address This field holds the start address in the external memory from which the data for the endpoint must be fetched or to which it must be stored. This register is incremented on every AHB transaction.
    \ Address offset: 0x6D4
    \ Reset value: 0x00000000
    \
    $00 constant OTG_DMAADDR                    \ [0x00 : 32] DMA address This field holds the start address in the external memory from which the data for the endpoint must be fetched or to which it must be stored. This register is incremented on every AHB transaction.
  [then]


  [ifdef] OTG_OTG_HCDMAB14_DEF
    \
    \ @brief DMA address This register holds the current buffer address (scatter/gather mode).
    \ Address offset: 0x6DC
    \ Reset value: 0x00000000
    \
    $00 constant OTG_HCDMAB                     \ [0x00 : 32] DMA address This register holds the current buffer address (scatter/gather mode).
  [then]


  [ifdef] OTG_OTG_HCCHAR15_DEF
    \
    \ @brief Maximum packet size Indicates the maximum packet size of the associated endpoint.
    \ Address offset: 0x6E0
    \ Reset value: 0x00000000
    \
    $00 constant OTG_MPSIZ                      \ [0x00 : 11] Maximum packet size Indicates the maximum packet size of the associated endpoint.
    $0b constant OTG_EPNUM                      \ [0x0b : 4] Endpoint number Indicates the endpoint number on the device serving as the data source or sink.
    $0f constant OTG_EPDIR                      \ [0x0f] Endpoint direction Indicates whether the transaction is IN or OUT.
    $11 constant OTG_LSDEV                      \ [0x11] Low-speed device This field is set by the application to indicate that this channel is communicating to a low-speed device.
    $12 constant OTG_EPTYP                      \ [0x12 : 2] Endpoint type Indicates the transfer type selected.
    $14 constant OTG_MCNT                       \ [0x14 : 2] Multicount This field indicates to the host the number of transactions that must be executed per frame for this periodic endpoint. For non-periodic transfers, this field is not used Note: This field must be set to at least 01.
    $16 constant OTG_DAD                        \ [0x16 : 7] Device address This field selects the specific device serving as the data source or sink.
    $1d constant OTG_ODDFRM                     \ [0x1d] Odd frame This field is set (reset) by the application to indicate that the OTG host must perform a transfer in an odd frame. This field is applicable for only periodic (isochronous and interrupt) transactions.
    $1e constant OTG_CHDIS                      \ [0x1e] Channel disable The application sets this bit to stop transmitting/receiving data on a channel, even before the transfer for that channel is complete. The application must wait for the Channel disabled interrupt before treating the channel as disabled.
    $1f constant OTG_CHENA                      \ [0x1f] Channel enable When Scatter/Gather mode is enabled: 1'b0: Indicates that the descriptor structure is not yet ready 1'b1: Indicates that the descriptor structure and data buffer with data is setup and this channel can access the descriptor When Scatter/Gather mode is disabled: This field is set by the application and cleared by the OTG host.
  [then]


  [ifdef] OTG_OTG_HCSPLT15_DEF
    \
    \ @brief Port address This field is the port number of the recipient transaction translator.
    \ Address offset: 0x6E4
    \ Reset value: 0x00000000
    \
    $00 constant OTG_PRTADDR                    \ [0x00 : 7] Port address This field is the port number of the recipient transaction translator.
    $07 constant OTG_HUBADDR                    \ [0x07 : 7] Hub address This field holds the device address of the transaction translator's hub.
    $0e constant OTG_XACTPOS                    \ [0x0e : 2] Transaction position This field is used to determine whether to send all, first, middle, or last payloads with each OUT transaction.
    $10 constant OTG_COMPLSPLT                  \ [0x10] Do complete split The application sets this bit to request the OTG host to perform a complete split transaction.
    $1f constant OTG_SPLITEN                    \ [0x1f] Split enable The application sets this bit to indicate that this channel is enabled to perform split transactions.
  [then]


  [ifdef] OTG_OTG_HCINT15_DEF
    \
    \ @brief OTG host channel 15 interrupt register
    \ Address offset: 0x6E8
    \ Reset value: 0x00000000
    \
    $00 constant OTG_XFRC                       \ [0x00] Transfer completed. Transfer completed normally without any errors.
    $01 constant OTG_CHH                        \ [0x01] Channel halted. In non scatter/gather DMA mode indicates the transfer completed abnormally either because of any USB transaction error or in response to disable request by the application. In scatter/gather DMA mode, this indicates that transfer completed due to any of the following: EOL being set in descriptor AHB error Excessive transaction errors In response to disable request by the application Babble Stall
    $02 constant OTG_AHBERR                     \ [0x02] AHB error This error is generated only in Internal DMA mode when an AHB error occurs during an AHB read/write operation. The application can read the corresponding DMA channel address register to get the error address.
    $03 constant OTG_STALL                      \ [0x03] STALL response received interrupt. In Scatter/Gather DMA mode, the interrupt due to this bit is masked.
    $04 constant OTG_NAK                        \ [0x04] NAK response received interrupt. In Scatter/Gather DMA mode, the interrupt due to this bit is masked.
    $05 constant OTG_ACK                        \ [0x05] ACK response received/transmitted interrupt. In Scatter/Gather DMA mode, the interrupt due to this bit is masked.
    $06 constant OTG_NYET                       \ [0x06] Not yet ready response received interrupt. In Scatter/Gather DMA mode, the interrupt due to this bit is masked.
    $07 constant OTG_TXERR                      \ [0x07] Transaction error. In Scatter/Gather DMA mode, the interrupt due to this bit is masked. Indicates one of the following errors occurred on the USB. CRC check failure Timeout Bit stuff error False EOP
    $08 constant OTG_BBERR                      \ [0x08] Babble error. In Scatter/Gather DMA mode, the interrupt due to this bit is masked.
    $09 constant OTG_FRMOR                      \ [0x09] Frame overrun. In Scatter/Gather DMA mode, the interrupt due to this bit is masked.
    $0a constant OTG_DTERR                      \ [0x0a] Data toggle error. In Scatter/Gather DMA mode, the interrupt due to this bit is masked.
    $0b constant OTG_BNA                        \ [0x0b] Buffer not available interrupt. This bit is valid only when Scatter/Gather DMA mode is enabled. The core generates this interrupt when the descriptor accessed is not ready for the core to process. BNA interrupt is not generated for isochronous channels. For non Scatter/Gather DMA mode, this bit is reserved.
    $0c constant OTG_XCSXACTERR                 \ [0x0c] Excessive transaction error. This bit is valid only when Scatter/Gather DMA mode is enabled. The core sets this bit when 3 consecutive transaction errors occurred on the USB bus. XCS_XACT_ERR is not generated for isochronous channels. For non Scatter/Gather DMA mode, this bit is reserved.
    $0d constant OTG_DESCLSTROLL                \ [0x0d] Descriptor rollover interrupt. This bit is valid only when Scatter/Gather DMA mode is enabled. The core sets this bit when the corresponding channel descriptor list rolls over. For non Scatter/Gather DMA mode, this bit is reserved.
  [then]


  [ifdef] OTG_OTG_HCINTMSK15_DEF
    \
    \ @brief OTG host channel 15 interrupt mask register
    \ Address offset: 0x6EC
    \ Reset value: 0x00000000
    \
    $00 constant OTG_XFRCM                      \ [0x00] Transfer completed mask
    $01 constant OTG_CHHM                       \ [0x01] Channel halted mask
    $02 constant OTG_AHBERRM                    \ [0x02] AHB error. In scatter/gather DMA mode for host, interrupts will not be generated due to the corresponding bits set in OTG_HCINTx.
    $03 constant OTG_STALLM                     \ [0x03] STALL response received interrupt mask. In Scatter/Gather DMA mode, the interrupt due to this bit is masked.
    $04 constant OTG_NAKM                       \ [0x04] NAK response received interrupt mask. In Scatter/Gather DMA mode, the interrupt due to this bit is masked.
    $05 constant OTG_ACKM                       \ [0x05] ACK response received/transmitted interrupt mask. In Scatter/Gather DMA mode, the interrupt due to this bit is masked.
    $06 constant OTG_NYET                       \ [0x06] response received interrupt mask. In Scatter/Gather DMA mode, the interrupt due to this bit is masked.
    $07 constant OTG_TXERRM                     \ [0x07] Transaction error mask. In Scatter/Gather DMA mode, the interrupt due to this bit is masked.
    $08 constant OTG_BBERRM                     \ [0x08] Babble error mask. In Scatter/Gather DMA mode, the interrupt due to this bit is masked.
    $09 constant OTG_FRMORM                     \ [0x09] Frame overrun mask. In Scatter/Gather DMA mode, the interrupt due to this bit is masked.
    $0a constant OTG_DTERRM                     \ [0x0a] Data toggle error mask. In Scatter/Gather DMA mode, the interrupt due to this bit is masked.
    $0b constant OTG_BNAMSK                     \ [0x0b] Buffer not available interrupt mask register. This bit is valid only when Scatter/Gather DMA mode is enabled. In non Scatter/Gather DMA mode, this bit is reserved
    $0d constant OTG_DESCLSTROLLMSK             \ [0x0d] Descriptor rollover interrupt mask register. This bit is valid only when Scatter/Gather DMA mode is enabled. In non Scatter/Gather DMA mode, this bit is reserved.
  [then]


  [ifdef] OTG_OTG_HCTSIZ15_DEF
    \
    \ @brief Transfer size For an OUT, this field is the number of data bytes the host sends during the transfer. For an IN, this field is the buffer size that the application has reserved for the transfer. The application is expected to program this field as an integer multiple of the maximum packet size for IN transactions (periodic and non-periodic).
    \ Address offset: 0x6F0
    \ Reset value: 0x00000000
    \
    $00 constant OTG_XFRSIZ                     \ [0x00 : 19] Transfer size For an OUT, this field is the number of data bytes the host sends during the transfer. For an IN, this field is the buffer size that the application has reserved for the transfer. The application is expected to program this field as an integer multiple of the maximum packet size for IN transactions (periodic and non-periodic).
    $13 constant OTG_PKTCNT                     \ [0x13 : 10] Packet count This field is programmed by the application with the expected number of packets to be transmitted (OUT) or received (IN). The host decrements this count on every successful transmission or reception of an OUT/IN packet. Once this count reaches zero, the application is interrupted to indicate normal completion.
    $1d constant OTG_DPID                       \ [0x1d : 2] Data PID The application programs this field with the type of PID to use for the initial transaction. The host maintains this field for the rest of the transfer.
    $1f constant OTG_DOPNG                      \ [0x1f] Do Ping This bit is used only for OUT transfers. Setting this field to 1 directs the host to do PING protocol. Note: Do not set this bit for IN transfers. If this bit is set for IN transfers, it disables the channel.
  [then]


  [ifdef] OTG_OTG_HCDMA15_DEF
    \
    \ @brief DMA address This field holds the start address in the external memory from which the data for the endpoint must be fetched or to which it must be stored. This register is incremented on every AHB transaction.
    \ Address offset: 0x6F4
    \ Reset value: 0x00000000
    \
    $00 constant OTG_DMAADDR                    \ [0x00 : 32] DMA address This field holds the start address in the external memory from which the data for the endpoint must be fetched or to which it must be stored. This register is incremented on every AHB transaction.
  [then]


  [ifdef] OTG_OTG_HCDMAB15_DEF
    \
    \ @brief DMA address This register holds the current buffer address (scatter/gather mode).
    \ Address offset: 0x6FC
    \ Reset value: 0x00000000
    \
    $00 constant OTG_HCDMAB                     \ [0x00 : 32] DMA address This register holds the current buffer address (scatter/gather mode).
  [then]


  [ifdef] OTG_OTG_DCFG_DEF
    \
    \ @brief OTG device configuration register
    \ Address offset: 0x800
    \ Reset value: 0x02200000
    \
    $00 constant OTG_DSPD                       \ [0x00 : 2] Device speed Indicates the speed at which the application requires the core to enumerate, or the maximum speed the application can support. However, the actual bus speed is determined only after the chirp sequence is completed, and is based on the speed of the USB host to which the core is connected.
    $02 constant OTG_NZLSOHSK                   \ [0x02] Non-zero-length status OUT handshake The application can use this field to select the handshake the core sends on receiving a nonzero-length data packet during the OUT transaction of a control transfer's status stage.
    $04 constant OTG_DAD                        \ [0x04 : 7] Device address The application must program this field after every SetAddress control command.
    $0b constant OTG_PFIVL                      \ [0x0b : 2] Periodic frame interval Indicates the time within a frame at which the application must be notified using the end of periodic frame interrupt. This can be used to determine if all the isochronous traffic for that frame is complete.
    $0f constant OTG_ERRATIM                    \ [0x0f] Erratic error interrupt mask
    $17 constant OTG_DESCDMA                    \ [0x17] Enable scatter/gather DMA in device mode The application can set this bit during initialization to enable the Scatter/Gather DMA operation. This bit must be modified only once after a reset. The following combinations are available for programming: OTG_GAHBCFG.DMAEN=0,OTG_DCFG.DESCDMA=0 => Slave mode OTG_GAHBCFG.DMAEN=0,OTG_DCFG.DESCDMA=1 => Invalid OTG_GAHBCFG.DMAEN=1,OTG_DCFG.DESCDMA=0 => Buffer DMA mode OTG_GAHBCFG.DMAEN=1,OTG_DCFG.DESCDMA=1 => Scatter/Gather DMA mode
    $18 constant OTG_PERSCHIVL                  \ [0x18 : 2] Periodic schedule interval This field specifies the amount of time the Internal DMA engine must allocate for fetching periodic IN endpoint data. Based on the number of periodic endpoints, this value must be specified as 25, 50 or 75% of the (micro) frame. When any periodic endpoints are active, the internal DMA engine allocates the specified amount of time in fetching periodic IN endpoint data When no periodic endpoint is active, then the internal DMA engine services nonperiodic endpoints, ignoring this field After the specified time within a (micro) frame, the DMA switches to fetching nonperiodic endpoints Note: Periodic Scheduling Interval (PERSCHIVL) must be programmed for Scatter/Gather DMA mode.
  [then]


  [ifdef] OTG_OTG_DCTL_DEF
    \
    \ @brief Remote wakeup signaling When the application sets this bit, the core initiates remote signaling to wake up the USB host. The application must set this bit to instruct the core to exit the suspend state. As specified in the USB 2.0 specification, the application must clear this bit 1 ms to 15 ms after setting it. If LPM is enabled and the core is in the L1 (sleep) state, when the application sets this bit, the core initiates L1 remote signaling to wake up the USB host. The application must set this bit to instruct the core to exit the sleep state. As specified in the LPM specification, the hardware automatically clears this bit 50Â Âµs (TL1DevDrvResume) after being set by the application. The application must not set this bit when bRemoteWake from the previous LPM transaction is zero (refer to REMWAKE bit in GLPMCFG register).
    \ Address offset: 0x804
    \ Reset value: 0x00000002
    \
    $00 constant OTG_RWUSIG                     \ [0x00] Remote wakeup signaling When the application sets this bit, the core initiates remote signaling to wake up the USB host. The application must set this bit to instruct the core to exit the suspend state. As specified in the USB 2.0 specification, the application must clear this bit 1 ms to 15 ms after setting it. If LPM is enabled and the core is in the L1 (sleep) state, when the application sets this bit, the core initiates L1 remote signaling to wake up the USB host. The application must set this bit to instruct the core to exit the sleep state. As specified in the LPM specification, the hardware automatically clears this bit 50Â Âµs (TL1DevDrvResume) after being set by the application. The application must not set this bit when bRemoteWake from the previous LPM transaction is zero (refer to REMWAKE bit in GLPMCFG register).
    $01 constant OTG_SDIS                       \ [0x01] Soft disconnect The application uses this bit to signal the USB OTG core to perform a soft disconnect. As long as this bit is set, the host does not see that the device is connected, and the device does not receive signals on the USB. The core stays in the disconnected state until the application clears this bit.
    $02 constant OTG_GINSTS                     \ [0x02] Global IN NAK status
    $03 constant OTG_GONSTS                     \ [0x03] Global OUT NAK status
    $04 constant OTG_TCTL                       \ [0x04 : 3] Test control Others: Reserved
    $07 constant OTG_SGINAK                     \ [0x07] Set global IN NAK Writing 1 to this field sets the Global non-periodic IN NAK.The application uses this bit to send a NAK handshake on all non-periodic IN endpoints. The application must set this bit only after making sure that the Global IN NAK effective bit in the core interrupt register (GINAKEFF bit in OTG_GINTSTS) is cleared.
    $08 constant OTG_CGINAK                     \ [0x08] Clear global IN NAK Writing 1 to this field clears the Global IN NAK.
    $09 constant OTG_SGONAK                     \ [0x09] Set global OUT NAK Writing 1 to this field sets the Global OUT NAK. The application uses this bit to send a NAK handshake on all OUT endpoints. The application must set the this bit only after making sure that the Global OUT NAK effective bit in the core interrupt register (GONAKEFF bit in OTG_GINTSTS) is cleared.
    $0a constant OTG_CGONAK                     \ [0x0a] Clear global OUT NAK Writing 1 to this field clears the Global OUT NAK.
    $0b constant OTG_POPRGDNE                   \ [0x0b] Power-on programming done The application uses this bit to indicate that register programming is completed after a wakeup from power down mode.
    $11 constant OTG_ENCONTONBNA                \ [0x11] Enable continue on BNA This bit enables the core to continue on BNA for Bulk OUT and INTR OUT endpoints. With this feature enabled, when a Bulk OUT or INTR OUT endpoint receives a BNA interrupt the core starts processing the descriptor that caused the BNA interrupt after the endpoint re-enables the endpoint.
    $12 constant OTG_DSBESLRJCT                 \ [0x12] Deep sleep BESL reject Core rejects LPM request with BESL value greater than BESL threshold programmed. NYET response is sent for LPM tokens with BESL value greater than BESL threshold. By default, the deep sleep BESL reject feature is disabled.
  [then]


  [ifdef] OTG_OTG_DSTS_DEF
    \
    \ @brief OTG device status register
    \ Address offset: 0x808
    \ Reset value: 0x00000010
    \
    $00 constant OTG_SUSPSTS                    \ [0x00] Suspend status In device mode, this bit is set as long as a suspend condition is detected on the USB. The core enters the suspended state when there is no activity on the USB data lines for a period of 3Â ms. The core comes out of the suspend: When there is an activity on the USB data lines When the application writes to the remote wakeup signaling bit in the OTG_DCTL register (RWUSIG bit in OTG_DCTL).
    $01 constant OTG_ENUMSPD                    \ [0x01 : 2] Enumerated speed Indicates the speed at which the OTG controller has come up after speed detection through a chirp sequence. Others: reserved
    $03 constant OTG_EERR                       \ [0x03] Erratic error The core sets this bit to report any erratic errors. Due to erratic errors, the OTG controller goes into suspended state and an interrupt is generated to the application with Early suspend bit of the OTG_GINTSTS register (ESUSP bit in OTG_GINTSTS). If the early suspend is asserted due to an erratic error, the application can only perform a soft disconnect recover.
    $08 constant OTG_FNSOF                      \ [0x08 : 14] Frame number of the received SOF
    $16 constant OTG_DEVLNSTS                   \ [0x16 : 2] Device line status Indicates the current logic level USB data lines. Bit [23]: Logic level of D+ Bit [22]: Logic level of D-
  [then]


  [ifdef] OTG_OTG_DIEPMSK_DEF
    \
    \ @brief OTG device IN endpoint common interrupt mask register
    \ Address offset: 0x810
    \ Reset value: 0x00000000
    \
    $00 constant OTG_XFRCM                      \ [0x00] Transfer completed interrupt mask
    $01 constant OTG_EPDM                       \ [0x01] Endpoint disabled interrupt mask
    $02 constant OTG_AHBERRM                    \ [0x02] AHB error mask
    $03 constant OTG_TOM                        \ [0x03] Timeout condition mask (Non-isochronous endpoints)
    $04 constant OTG_ITTXFEMSK                  \ [0x04] IN token received when Tx FIFO empty mask
    $05 constant OTG_INEPNMM                    \ [0x05] IN token received with EP mismatch mask
    $06 constant OTG_INEPNEM                    \ [0x06] IN endpoint NAK effective mask
    $08 constant OTG_TXFURM                     \ [0x08] FIFO underrun mask
    $09 constant OTG_BNAM                       \ [0x09] BNA interrupt mask
    $0d constant OTG_NAKM                       \ [0x0d] NAK interrupt mask
  [then]


  [ifdef] OTG_OTG_DOEPMSK_DEF
    \
    \ @brief OTG device OUT endpoint common interrupt mask register
    \ Address offset: 0x814
    \ Reset value: 0x00000000
    \
    $00 constant OTG_XFRCM                      \ [0x00] Transfer completed interrupt mask
    $01 constant OTG_EPDM                       \ [0x01] Endpoint disabled interrupt mask
    $02 constant OTG_AHBERRM                    \ [0x02] AHB error mask
    $03 constant OTG_STUPM                      \ [0x03] STUPM: SETUP phase done mask. Applies to control endpoints only.
    $04 constant OTG_OTEPDM                     \ [0x04] OUT token received when endpoint disabled mask. Applies to control OUT endpoints only.
    $05 constant OTG_STSPHSRXM                  \ [0x05] Status phase received for control write mask
    $06 constant OTG_B2BSTUPM                   \ [0x06] Back-to-back SETUP packets received mask Applies to control OUT endpoints only.
    $08 constant OTG_OUTPKTERRM                 \ [0x08] Out packet error mask
    $09 constant OTG_BNAM                       \ [0x09] BNA interrupt mask
    $0c constant OTG_BERRM                      \ [0x0c] Babble error interrupt mask
    $0d constant OTG_NAKMSK                     \ [0x0d] NAK interrupt mask
    $0e constant OTG_NYETMSK                    \ [0x0e] NYET interrupt mask
  [then]


  [ifdef] OTG_OTG_DAINT_DEF
    \
    \ @brief OTG device all endpoints interrupt register
    \ Address offset: 0x818
    \ Reset value: 0x00000000
    \
    $00 constant OTG_IEPINT                     \ [0x00 : 16] IN endpoint interrupt bits One bit per IN endpoint: Bit 0 for IN endpoint 0, bit 3 for endpoint 3.
    $10 constant OTG_OEPINT                     \ [0x10 : 16] OUT endpoint interrupt bits One bit per OUT endpoint: Bit 16 for OUT endpoint 0, bit 19 for OUT endpoint 3.
  [then]


  [ifdef] OTG_OTG_DAINTMSK_DEF
    \
    \ @brief OTG all endpoints interrupt mask register
    \ Address offset: 0x81C
    \ Reset value: 0x00000000
    \
    $00 constant OTG_IEPM                       \ [0x00 : 16] IN EP interrupt mask bits One bit per IN endpoint: Bit 0 for IN EP 0, bit 3 for IN EP 3
    $10 constant OTG_OEPM                       \ [0x10 : 16] OUT EP interrupt mask bits One per OUT endpoint: Bit 16 for OUT EP 0, bit 19 for OUT EP 3
  [then]


  [ifdef] OTG_OTG_DVBUSDIS_DEF
    \
    \ @brief OTG device VBUS discharge time register
    \ Address offset: 0x828
    \ Reset value: 0x000017D7
    \
    $00 constant OTG_VBUSDT                     \ [0x00 : 16] Device VBUS discharge time Specifies the VBUS discharge time after VBUS pulsing during SRP. This value equals: VBUS discharge time in PHY clocks / 1 024 Depending on your VBUS load, this value may need adjusting.
  [then]


  [ifdef] OTG_OTG_DVBUSPULSE_DEF
    \
    \ @brief OTG device VBUS pulsing time register
    \ Address offset: 0x82C
    \ Reset value: 0x000005B8
    \
    $00 constant OTG_DVBUSP                     \ [0x00 : 16] Device VBUS pulsing time. This feature is only relevant to OTG1.3. Specifies the VBUS pulsing time during SRP. This value equals: VBUS pulsing time in PHY clocks / 1 024
  [then]


  [ifdef] OTG_OTG_DTHRCTL_DEF
    \
    \ @brief Nonisochronous IN endpoints threshold enable When this bit is set, the core enables thresholding for nonisochronous IN endpoints.
    \ Address offset: 0x830
    \ Reset value: 0x00000000
    \
    $00 constant OTG_NONISOTHREN                \ [0x00] Nonisochronous IN endpoints threshold enable When this bit is set, the core enables thresholding for nonisochronous IN endpoints.
    $01 constant OTG_ISOTHREN                   \ [0x01] ISO IN endpoint threshold enable When this bit is set, the core enables thresholding for isochronous IN endpoints.
    $02 constant OTG_TXTHRLEN                   \ [0x02 : 9] Transmit threshold length This field specifies the transmit thresholding size in 32-bit words. This field specifies the amount of data in bytes to be in the corresponding endpoint transmit FIFO, before the core can start transmitting on the USB. The threshold length has to be at least eight 32-bit words. This field controls both isochronous and nonisochronous IN endpoint thresholds. The recommended value for TXTHRLEN is to be the same as the programmed AHB burst length (HBSTLEN bit in OTG_GAHBCFG).
    $10 constant OTG_RXTHREN                    \ [0x10] Receive threshold enable When this bit is set, the core enables thresholding in the receive direction.
    $11 constant OTG_RXTHRLEN                   \ [0x11 : 9] Receive threshold length This field specifies the receive thresholding size in 32-bit words. This field also specifies the amount of data received on the USB before the core can start transmitting on the AHB. The threshold length has to be at least eight 32-bit words. The recommended value for RXTHRLEN is to be the same as the programmed AHB burst length (HBSTLEN bit in OTG_GAHBCFG).
    $1b constant OTG_ARPEN                      \ [0x1b] Arbiter parking enable This bit controls internal DMA arbiter parking for IN endpoints. When thresholding is enabled and this bit is set to one, then the arbiter parks on the IN endpoint for which there is a token received on the USB. This is done to avoid getting into underrun conditions. By default parking is enabled.
  [then]


  [ifdef] OTG_OTG_DIEPEMPMSK_DEF
    \
    \ @brief OTG device IN endpoint FIFO empty interrupt mask register
    \ Address offset: 0x834
    \ Reset value: 0x00000000
    \
    $00 constant OTG_INEPTXFEM                  \ [0x00 : 16] IN EP Tx FIFO empty interrupt mask bits These bits act as mask bits for OTG_DIEPINTx. TXFE interrupt one bit per IN endpoint: Bit 0 for IN endpoint 0, bit 3 for IN endpoint 3
  [then]


  [ifdef] OTG_OTG_DIEPCTL0_DEF
    \
    \ @brief OTG device IN endpoint 0 control register
    \ Address offset: 0x900
    \ Reset value: 0x00000000
    \
    $00 constant OTG_MPSIZ                      \ [0x00 : 11] Maximum packet size The application must program this field with the maximum packet size for the current logical endpoint. This value is in bytes.
    $0f constant OTG_USBAEP                     \ [0x0f] USB active endpoint Indicates whether this endpoint is active in the current configuration and interface. The core clears this bit for all endpoints (other than EP 0) after detecting a USB reset. After receiving the SetConfiguration and SetInterface commands, the application must program endpoint registers accordingly and set this bit.
    $10 constant OTG_EONUM                      \ [0x10] Even/odd frame Applies to isochronous IN endpoints only. The alternate description that applies for interrupt/bulk IN endpoint only is defined in next paragraph Indicates the frame number in which the core transmits/receives isochronous data for this endpoint. The application must program the even/odd frame number in which it intends to transmit/receive isochronous data for this endpoint using the SEVNFRM and SODDFRM fields in this register.
    $11 constant OTG_NAKSTS                     \ [0x11] NAK status It indicates the following: When either the application or the core sets this bit: For non-isochronous IN endpoints: The core stops transmitting any data on an IN endpoint, even if there are data available in the Tx FIFO. For isochronous IN endpoints: The core sends out a zero-length data packet, even if there are data available in the Tx FIFO. Irrespective of this bit's setting, the core always responds to SETUP data packets with an ACK handshake.
    $12 constant OTG_EPTYP                      \ [0x12 : 2] Endpoint type This is the transfer type supported by this logical endpoint.
    $15 constant OTG_STALL                      \ [0x15] STALL handshake Applies to non-control, non-isochronous IN endpoints only (access type is rw). The application sets this bit to stall all tokens from the USB host to this endpoint. If a NAK bit, Global IN NAK, or Global OUT NAK is set along with this bit, the STALL bit takes priority. Only the application can clear this bit, never the core.
    $16 constant OTG_TXFNUM                     \ [0x16 : 4] Tx FIFO number These bits specify the FIFO number associated with this endpoint. Each active IN endpoint must be programmed to a separate FIFO number. This field is valid only for IN endpoints.
    $1a constant OTG_CNAK                       \ [0x1a] Clear NAK A write to this bit clears the NAK bit for the endpoint.
    $1b constant OTG_SNAK                       \ [0x1b] Set NAK A write to this bit sets the NAK bit for the endpoint. Using this bit, the application can control the transmission of NAK handshakes on an endpoint. The core can also set this bit for OUT endpoints on a transfer completed interrupt, or after a SETUP is received on the endpoint.
    $1c constant OTG_SEVNFRM                    \ [0x1c] Set even frame Applies to isochronous IN endpoints only. The alternate description for interrupt/bluk IN endpoint is defined in the next paragraph Writing to this field sets the Even/Odd frame (EONUM) field to even frame.
    $1d constant OTG_SODDFRM                    \ [0x1d] Set odd frame Applies to isochronous IN and OUT endpoints only. Writing to this field sets the Even/Odd frame (EONUM) field to odd frame.
    $1e constant OTG_EPDIS                      \ [0x1e] Endpoint disable The application sets this bit to stop transmitting/receiving data on an endpoint, even before the transfer for that endpoint is complete. The application must wait for the endpoint disabled interrupt before treating the endpoint as disabled. The core clears this bit before setting the endpoint disabled interrupt. The application must set this bit only if endpoint enable is already set for this endpoint.
    $1f constant OTG_EPENA                      \ [0x1f] Endpoint enable The application sets this bit to start transmitting data on an endpoint. The core clears this bit before setting any of the following interrupts on this endpoint: SETUP phase done Endpoint disabled Transfer completed
  [then]


  [ifdef] OTG_OTG_DIEPINT0_DEF
    \
    \ @brief OTG device IN endpoint 0 interrupt register
    \ Address offset: 0x908
    \ Reset value: 0x00000080
    \
    $00 constant OTG_XFRC                       \ [0x00] Transfer completed interrupt This field indicates that the programmed transfer is complete on the AHB as well as on the USB, for this endpoint.
    $01 constant OTG_EPDISD                     \ [0x01] Endpoint disabled interrupt This bit indicates that the endpoint is disabled per the application's request.
    $02 constant OTG_AHBERR                     \ [0x02] AHB error This is generated only in internal DMA mode when there is an AHB error during an AHB read/write. The application can read the corresponding endpoint DMA address register to get the error address.
    $03 constant OTG_TOC                        \ [0x03] Timeout condition Indicates that the core has detected a timeout condition on the USB for the last IN token on this endpoint.
    $04 constant OTG_ITTXFE                     \ [0x04] IN token received when Tx FIFO is empty Indicates that an IN token was received when the associated Tx FIFO (periodic/non-periodic) was empty. This interrupt is asserted on the endpoint for which the IN token was received.
    $05 constant OTG_INEPNM                     \ [0x05] IN token received with EP mismatch Indicates that the data in the top of the non-periodic TxFIFO belongs to an endpoint other than the one for which the IN token was received. This interrupt is asserted on the endpoint for which the IN token was received.
    $06 constant OTG_INEPNE                     \ [0x06] IN endpoint NAK effective This bit can be cleared when the application clears the IN endpoint NAK by writing to the CNAK bit in OTG_DIEPCTLx. This interrupt indicates that the core has sampled the NAK bit set (either by the application or by the core). The interrupt indicates that the IN endpoint NAK bit set by the application has taken effect in the core. This interrupt does not guarantee that a NAK handshake is sent on the USB. A STALL bit takes priority over a NAK bit.
    $07 constant OTG_TXFE                       \ [0x07] Transmit FIFO empty This interrupt is asserted when the Tx FIFO for this endpoint is either half or completely empty. The half or completely empty status is determined by the Tx FIFO Empty Level bit in the OTG_GAHBCFG register (TXFELVL bit in OTG_GAHBCFG).
    $08 constant OTG_TXFIFOUDRN                 \ [0x08] Transmit Fifo Underrun (TxfifoUndrn) The core generates this interrupt when it detects a transmit FIFO underrun condition for this endpoint. Dependency: This interrupt is valid only when Thresholding is enabled
    $09 constant OTG_BNA                        \ [0x09] Buffer not available interrupt The core generates this interrupt when the descriptor accessed is not ready for the core to process, such as host busy or DMA done. This bit is only valid when Scatter/Gather DMA mode is enabled.
    $0b constant OTG_PKTDRPSTS                  \ [0x0b] Packet dropped status This bit indicates to the application that an ISOC OUT packet has been dropped. This bit does not have an associated mask bit and does not generate an interrupt.
    $0d constant OTG_NAK                        \ [0x0d] NAK input The core generates this interrupt when a NAK is transmitted or received by the device. In case of isochronous IN endpoints the interrupt gets generated when a zero length packet is transmitted due to unavailability of data in the Tx FIFO.
  [then]


  [ifdef] OTG_OTG_DIEPTSIZ0_DEF
    \
    \ @brief OTG device IN endpoint 0 transfer size register
    \ Address offset: 0x910
    \ Reset value: 0x00000000
    \
    $00 constant OTG_XFRSIZ                     \ [0x00 : 7] Transfer size Indicates the transfer size in bytes for endpoint 0. The core interrupts the application only after it has exhausted the transfer size amount of data. The transfer size can be set to the maximum packet size of the endpoint, to be interrupted at the end of each packet. The core decrements this field every time a packet from the external memory is written to the Tx FIFO.
    $13 constant OTG_PKTCNT                     \ [0x13 : 2] Packet count Indicates the total number of USB packets that constitute the transfer size amount of data for endpoint 0. This field is decremented every time a packet (maximum size or short packet) is read from the Tx FIFO.
  [then]


  [ifdef] OTG_OTG_DIEPDMA0_DEF
    \
    \ @brief DMA Address This field holds the start address in the external memory from which the data for the endpoint must be fetched. This register is incremented on every AHB transaction.
    \ Address offset: 0x914
    \ Reset value: 0x00000000
    \
    $00 constant OTG_DMAADDR                    \ [0x00 : 32] DMA Address This field holds the start address in the external memory from which the data for the endpoint must be fetched. This register is incremented on every AHB transaction.
  [then]


  [ifdef] OTG_OTG_DTXFSTS0_DEF
    \
    \ @brief OTG device IN endpoint transmit FIFO status register
    \ Address offset: 0x918
    \ Reset value: 0x00000200
    \
    $00 constant OTG_INEPTFSAV                  \ [0x00 : 16] IN endpoint Tx FIFO space available Indicates the amount of free space available in the endpoint Tx FIFO. Values are in terms of 32-bit words: 0xn: n words available Others: Reserved
  [then]


  [ifdef] OTG_OTG_DIEPCTL1_DEF
    \
    \ @brief OTG device IN endpoint 1 control register
    \ Address offset: 0x920
    \ Reset value: 0x00000000
    \
    $00 constant OTG_MPSIZ                      \ [0x00 : 11] Maximum packet size The application must program this field with the maximum packet size for the current logical endpoint. This value is in bytes.
    $0f constant OTG_USBAEP                     \ [0x0f] USB active endpoint Indicates whether this endpoint is active in the current configuration and interface. The core clears this bit for all endpoints (other than EP 0) after detecting a USB reset. After receiving the SetConfiguration and SetInterface commands, the application must program endpoint registers accordingly and set this bit.
    $10 constant OTG_EONUM                      \ [0x10] Even/odd frame Applies to isochronous IN endpoints only. The alternate description that applies for interrupt/bulk IN endpoint only is defined in next paragraph Indicates the frame number in which the core transmits/receives isochronous data for this endpoint. The application must program the even/odd frame number in which it intends to transmit/receive isochronous data for this endpoint using the SEVNFRM and SODDFRM fields in this register.
    $11 constant OTG_NAKSTS                     \ [0x11] NAK status It indicates the following: When either the application or the core sets this bit: For non-isochronous IN endpoints: The core stops transmitting any data on an IN endpoint, even if there are data available in the Tx FIFO. For isochronous IN endpoints: The core sends out a zero-length data packet, even if there are data available in the Tx FIFO. Irrespective of this bit's setting, the core always responds to SETUP data packets with an ACK handshake.
    $12 constant OTG_EPTYP                      \ [0x12 : 2] Endpoint type This is the transfer type supported by this logical endpoint.
    $15 constant OTG_STALL                      \ [0x15] STALL handshake Applies to non-control, non-isochronous IN endpoints only (access type is rw). The application sets this bit to stall all tokens from the USB host to this endpoint. If a NAK bit, Global IN NAK, or Global OUT NAK is set along with this bit, the STALL bit takes priority. Only the application can clear this bit, never the core.
    $16 constant OTG_TXFNUM                     \ [0x16 : 4] Tx FIFO number These bits specify the FIFO number associated with this endpoint. Each active IN endpoint must be programmed to a separate FIFO number. This field is valid only for IN endpoints.
    $1a constant OTG_CNAK                       \ [0x1a] Clear NAK A write to this bit clears the NAK bit for the endpoint.
    $1b constant OTG_SNAK                       \ [0x1b] Set NAK A write to this bit sets the NAK bit for the endpoint. Using this bit, the application can control the transmission of NAK handshakes on an endpoint. The core can also set this bit for OUT endpoints on a transfer completed interrupt, or after a SETUP is received on the endpoint.
    $1c constant OTG_SEVNFRM                    \ [0x1c] Set even frame Applies to isochronous IN endpoints only. The alternate description for interrupt/bluk IN endpoint is defined in the next paragraph Writing to this field sets the Even/Odd frame (EONUM) field to even frame.
    $1d constant OTG_SODDFRM                    \ [0x1d] Set odd frame Applies to isochronous IN and OUT endpoints only. Writing to this field sets the Even/Odd frame (EONUM) field to odd frame.
    $1e constant OTG_EPDIS                      \ [0x1e] Endpoint disable The application sets this bit to stop transmitting/receiving data on an endpoint, even before the transfer for that endpoint is complete. The application must wait for the endpoint disabled interrupt before treating the endpoint as disabled. The core clears this bit before setting the endpoint disabled interrupt. The application must set this bit only if endpoint enable is already set for this endpoint.
    $1f constant OTG_EPENA                      \ [0x1f] Endpoint enable The application sets this bit to start transmitting data on an endpoint. The core clears this bit before setting any of the following interrupts on this endpoint: SETUP phase done Endpoint disabled Transfer completed
  [then]


  [ifdef] OTG_OTG_DIEPINT1_DEF
    \
    \ @brief OTG device IN endpoint 1 interrupt register
    \ Address offset: 0x928
    \ Reset value: 0x00000080
    \
    $00 constant OTG_XFRC                       \ [0x00] Transfer completed interrupt This field indicates that the programmed transfer is complete on the AHB as well as on the USB, for this endpoint.
    $01 constant OTG_EPDISD                     \ [0x01] Endpoint disabled interrupt This bit indicates that the endpoint is disabled per the application's request.
    $02 constant OTG_AHBERR                     \ [0x02] AHB error This is generated only in internal DMA mode when there is an AHB error during an AHB read/write. The application can read the corresponding endpoint DMA address register to get the error address.
    $03 constant OTG_TOC                        \ [0x03] Timeout condition Indicates that the core has detected a timeout condition on the USB for the last IN token on this endpoint.
    $04 constant OTG_ITTXFE                     \ [0x04] IN token received when Tx FIFO is empty Indicates that an IN token was received when the associated Tx FIFO (periodic/non-periodic) was empty. This interrupt is asserted on the endpoint for which the IN token was received.
    $05 constant OTG_INEPNM                     \ [0x05] IN token received with EP mismatch Indicates that the data in the top of the non-periodic TxFIFO belongs to an endpoint other than the one for which the IN token was received. This interrupt is asserted on the endpoint for which the IN token was received.
    $06 constant OTG_INEPNE                     \ [0x06] IN endpoint NAK effective This bit can be cleared when the application clears the IN endpoint NAK by writing to the CNAK bit in OTG_DIEPCTLx. This interrupt indicates that the core has sampled the NAK bit set (either by the application or by the core). The interrupt indicates that the IN endpoint NAK bit set by the application has taken effect in the core. This interrupt does not guarantee that a NAK handshake is sent on the USB. A STALL bit takes priority over a NAK bit.
    $07 constant OTG_TXFE                       \ [0x07] Transmit FIFO empty This interrupt is asserted when the Tx FIFO for this endpoint is either half or completely empty. The half or completely empty status is determined by the Tx FIFO Empty Level bit in the OTG_GAHBCFG register (TXFELVL bit in OTG_GAHBCFG).
    $08 constant OTG_TXFIFOUDRN                 \ [0x08] Transmit Fifo Underrun (TxfifoUndrn) The core generates this interrupt when it detects a transmit FIFO underrun condition for this endpoint. Dependency: This interrupt is valid only when Thresholding is enabled
    $09 constant OTG_BNA                        \ [0x09] Buffer not available interrupt The core generates this interrupt when the descriptor accessed is not ready for the core to process, such as host busy or DMA done. This bit is only valid when Scatter/Gather DMA mode is enabled.
    $0b constant OTG_PKTDRPSTS                  \ [0x0b] Packet dropped status This bit indicates to the application that an ISOC OUT packet has been dropped. This bit does not have an associated mask bit and does not generate an interrupt.
    $0d constant OTG_NAK                        \ [0x0d] NAK input The core generates this interrupt when a NAK is transmitted or received by the device. In case of isochronous IN endpoints the interrupt gets generated when a zero length packet is transmitted due to unavailability of data in the Tx FIFO.
  [then]


  [ifdef] OTG_OTG_DIEPTSIZ1_DEF
    \
    \ @brief OTG device IN endpoint 1 transfer size register
    \ Address offset: 0x930
    \ Reset value: 0x00000000
    \
    $00 constant OTG_XFRSIZ                     \ [0x00 : 19] Transfer size This field contains the transfer size in bytes for the current endpoint. The core only interrupts the application after it has exhausted the transfer size amount of data. The transfer size can be set to the maximum packet size of the endpoint, to be interrupted at the end of each packet. The core decrements this field every time a packet from the external memory is written to the Tx FIFO.
    $13 constant OTG_PKTCNT                     \ [0x13 : 10] Packet count Indicates the total number of USB packets that constitute the transfer size amount of data for this endpoint. This field is decremented every time a packet (maximum size or short packet) is read from the Tx FIFO.
    $1d constant OTG_MCNT                       \ [0x1d : 2] Multi count For periodic IN endpoints, this field indicates the number of packets that must be transmitted per frame on the USB. The core uses this field to calculate the data PID for isochronous IN endpoints.
  [then]


  [ifdef] OTG_OTG_DIEPDMA1_DEF
    \
    \ @brief DMA Address This field holds the start address in the external memory from which the data for the endpoint must be fetched. This register is incremented on every AHB transaction.
    \ Address offset: 0x934
    \ Reset value: 0x00000000
    \
    $00 constant OTG_DMAADDR                    \ [0x00 : 32] DMA Address This field holds the start address in the external memory from which the data for the endpoint must be fetched. This register is incremented on every AHB transaction.
  [then]


  [ifdef] OTG_OTG_DTXFSTS1_DEF
    \
    \ @brief OTG device IN endpoint transmit FIFO status register
    \ Address offset: 0x938
    \ Reset value: 0x00000200
    \
    $00 constant OTG_INEPTFSAV                  \ [0x00 : 16] IN endpoint Tx FIFO space available Indicates the amount of free space available in the endpoint Tx FIFO. Values are in terms of 32-bit words: 0xn: n words available Others: Reserved
  [then]


  [ifdef] OTG_OTG_DIEPCTL2_DEF
    \
    \ @brief OTG device IN endpoint 2 control register
    \ Address offset: 0x940
    \ Reset value: 0x00000000
    \
    $00 constant OTG_MPSIZ                      \ [0x00 : 11] Maximum packet size The application must program this field with the maximum packet size for the current logical endpoint. This value is in bytes.
    $0f constant OTG_USBAEP                     \ [0x0f] USB active endpoint Indicates whether this endpoint is active in the current configuration and interface. The core clears this bit for all endpoints (other than EP 0) after detecting a USB reset. After receiving the SetConfiguration and SetInterface commands, the application must program endpoint registers accordingly and set this bit.
    $10 constant OTG_EONUM                      \ [0x10] Even/odd frame Applies to isochronous IN endpoints only. The alternate description that applies for interrupt/bulk IN endpoint only is defined in next paragraph Indicates the frame number in which the core transmits/receives isochronous data for this endpoint. The application must program the even/odd frame number in which it intends to transmit/receive isochronous data for this endpoint using the SEVNFRM and SODDFRM fields in this register.
    $11 constant OTG_NAKSTS                     \ [0x11] NAK status It indicates the following: When either the application or the core sets this bit: For non-isochronous IN endpoints: The core stops transmitting any data on an IN endpoint, even if there are data available in the Tx FIFO. For isochronous IN endpoints: The core sends out a zero-length data packet, even if there are data available in the Tx FIFO. Irrespective of this bit's setting, the core always responds to SETUP data packets with an ACK handshake.
    $12 constant OTG_EPTYP                      \ [0x12 : 2] Endpoint type This is the transfer type supported by this logical endpoint.
    $15 constant OTG_STALL                      \ [0x15] STALL handshake Applies to non-control, non-isochronous IN endpoints only (access type is rw). The application sets this bit to stall all tokens from the USB host to this endpoint. If a NAK bit, Global IN NAK, or Global OUT NAK is set along with this bit, the STALL bit takes priority. Only the application can clear this bit, never the core.
    $16 constant OTG_TXFNUM                     \ [0x16 : 4] Tx FIFO number These bits specify the FIFO number associated with this endpoint. Each active IN endpoint must be programmed to a separate FIFO number. This field is valid only for IN endpoints.
    $1a constant OTG_CNAK                       \ [0x1a] Clear NAK A write to this bit clears the NAK bit for the endpoint.
    $1b constant OTG_SNAK                       \ [0x1b] Set NAK A write to this bit sets the NAK bit for the endpoint. Using this bit, the application can control the transmission of NAK handshakes on an endpoint. The core can also set this bit for OUT endpoints on a transfer completed interrupt, or after a SETUP is received on the endpoint.
    $1c constant OTG_SEVNFRM                    \ [0x1c] Set even frame Applies to isochronous IN endpoints only. The alternate description for interrupt/bluk IN endpoint is defined in the next paragraph Writing to this field sets the Even/Odd frame (EONUM) field to even frame.
    $1d constant OTG_SODDFRM                    \ [0x1d] Set odd frame Applies to isochronous IN and OUT endpoints only. Writing to this field sets the Even/Odd frame (EONUM) field to odd frame.
    $1e constant OTG_EPDIS                      \ [0x1e] Endpoint disable The application sets this bit to stop transmitting/receiving data on an endpoint, even before the transfer for that endpoint is complete. The application must wait for the endpoint disabled interrupt before treating the endpoint as disabled. The core clears this bit before setting the endpoint disabled interrupt. The application must set this bit only if endpoint enable is already set for this endpoint.
    $1f constant OTG_EPENA                      \ [0x1f] Endpoint enable The application sets this bit to start transmitting data on an endpoint. The core clears this bit before setting any of the following interrupts on this endpoint: SETUP phase done Endpoint disabled Transfer completed
  [then]


  [ifdef] OTG_OTG_DIEPINT2_DEF
    \
    \ @brief OTG device IN endpoint 2 interrupt register
    \ Address offset: 0x948
    \ Reset value: 0x00000080
    \
    $00 constant OTG_XFRC                       \ [0x00] Transfer completed interrupt This field indicates that the programmed transfer is complete on the AHB as well as on the USB, for this endpoint.
    $01 constant OTG_EPDISD                     \ [0x01] Endpoint disabled interrupt This bit indicates that the endpoint is disabled per the application's request.
    $02 constant OTG_AHBERR                     \ [0x02] AHB error This is generated only in internal DMA mode when there is an AHB error during an AHB read/write. The application can read the corresponding endpoint DMA address register to get the error address.
    $03 constant OTG_TOC                        \ [0x03] Timeout condition Indicates that the core has detected a timeout condition on the USB for the last IN token on this endpoint.
    $04 constant OTG_ITTXFE                     \ [0x04] IN token received when Tx FIFO is empty Indicates that an IN token was received when the associated Tx FIFO (periodic/non-periodic) was empty. This interrupt is asserted on the endpoint for which the IN token was received.
    $05 constant OTG_INEPNM                     \ [0x05] IN token received with EP mismatch Indicates that the data in the top of the non-periodic TxFIFO belongs to an endpoint other than the one for which the IN token was received. This interrupt is asserted on the endpoint for which the IN token was received.
    $06 constant OTG_INEPNE                     \ [0x06] IN endpoint NAK effective This bit can be cleared when the application clears the IN endpoint NAK by writing to the CNAK bit in OTG_DIEPCTLx. This interrupt indicates that the core has sampled the NAK bit set (either by the application or by the core). The interrupt indicates that the IN endpoint NAK bit set by the application has taken effect in the core. This interrupt does not guarantee that a NAK handshake is sent on the USB. A STALL bit takes priority over a NAK bit.
    $07 constant OTG_TXFE                       \ [0x07] Transmit FIFO empty This interrupt is asserted when the Tx FIFO for this endpoint is either half or completely empty. The half or completely empty status is determined by the Tx FIFO Empty Level bit in the OTG_GAHBCFG register (TXFELVL bit in OTG_GAHBCFG).
    $08 constant OTG_TXFIFOUDRN                 \ [0x08] Transmit Fifo Underrun (TxfifoUndrn) The core generates this interrupt when it detects a transmit FIFO underrun condition for this endpoint. Dependency: This interrupt is valid only when Thresholding is enabled
    $09 constant OTG_BNA                        \ [0x09] Buffer not available interrupt The core generates this interrupt when the descriptor accessed is not ready for the core to process, such as host busy or DMA done. This bit is only valid when Scatter/Gather DMA mode is enabled.
    $0b constant OTG_PKTDRPSTS                  \ [0x0b] Packet dropped status This bit indicates to the application that an ISOC OUT packet has been dropped. This bit does not have an associated mask bit and does not generate an interrupt.
    $0d constant OTG_NAK                        \ [0x0d] NAK input The core generates this interrupt when a NAK is transmitted or received by the device. In case of isochronous IN endpoints the interrupt gets generated when a zero length packet is transmitted due to unavailability of data in the Tx FIFO.
  [then]


  [ifdef] OTG_OTG_DIEPTSIZ2_DEF
    \
    \ @brief OTG device IN endpoint 2 transfer size register
    \ Address offset: 0x950
    \ Reset value: 0x00000000
    \
    $00 constant OTG_XFRSIZ                     \ [0x00 : 19] Transfer size This field contains the transfer size in bytes for the current endpoint. The core only interrupts the application after it has exhausted the transfer size amount of data. The transfer size can be set to the maximum packet size of the endpoint, to be interrupted at the end of each packet. The core decrements this field every time a packet from the external memory is written to the Tx FIFO.
    $13 constant OTG_PKTCNT                     \ [0x13 : 10] Packet count Indicates the total number of USB packets that constitute the transfer size amount of data for this endpoint. This field is decremented every time a packet (maximum size or short packet) is read from the Tx FIFO.
    $1d constant OTG_MCNT                       \ [0x1d : 2] Multi count For periodic IN endpoints, this field indicates the number of packets that must be transmitted per frame on the USB. The core uses this field to calculate the data PID for isochronous IN endpoints.
  [then]


  [ifdef] OTG_OTG_DIEPDMA2_DEF
    \
    \ @brief DMA Address This field holds the start address in the external memory from which the data for the endpoint must be fetched. This register is incremented on every AHB transaction.
    \ Address offset: 0x954
    \ Reset value: 0x00000000
    \
    $00 constant OTG_DMAADDR                    \ [0x00 : 32] DMA Address This field holds the start address in the external memory from which the data for the endpoint must be fetched. This register is incremented on every AHB transaction.
  [then]


  [ifdef] OTG_OTG_DTXFSTS2_DEF
    \
    \ @brief OTG device IN endpoint transmit FIFO status register
    \ Address offset: 0x958
    \ Reset value: 0x00000200
    \
    $00 constant OTG_INEPTFSAV                  \ [0x00 : 16] IN endpoint Tx FIFO space available Indicates the amount of free space available in the endpoint Tx FIFO. Values are in terms of 32-bit words: 0xn: n words available Others: Reserved
  [then]


  [ifdef] OTG_OTG_DIEPCTL3_DEF
    \
    \ @brief OTG device IN endpoint 3 control register
    \ Address offset: 0x960
    \ Reset value: 0x00000000
    \
    $00 constant OTG_MPSIZ                      \ [0x00 : 11] Maximum packet size The application must program this field with the maximum packet size for the current logical endpoint. This value is in bytes.
    $0f constant OTG_USBAEP                     \ [0x0f] USB active endpoint Indicates whether this endpoint is active in the current configuration and interface. The core clears this bit for all endpoints (other than EP 0) after detecting a USB reset. After receiving the SetConfiguration and SetInterface commands, the application must program endpoint registers accordingly and set this bit.
    $10 constant OTG_EONUM                      \ [0x10] Even/odd frame Applies to isochronous IN endpoints only. The alternate description that applies for interrupt/bulk IN endpoint only is defined in next paragraph Indicates the frame number in which the core transmits/receives isochronous data for this endpoint. The application must program the even/odd frame number in which it intends to transmit/receive isochronous data for this endpoint using the SEVNFRM and SODDFRM fields in this register.
    $11 constant OTG_NAKSTS                     \ [0x11] NAK status It indicates the following: When either the application or the core sets this bit: For non-isochronous IN endpoints: The core stops transmitting any data on an IN endpoint, even if there are data available in the Tx FIFO. For isochronous IN endpoints: The core sends out a zero-length data packet, even if there are data available in the Tx FIFO. Irrespective of this bit's setting, the core always responds to SETUP data packets with an ACK handshake.
    $12 constant OTG_EPTYP                      \ [0x12 : 2] Endpoint type This is the transfer type supported by this logical endpoint.
    $15 constant OTG_STALL                      \ [0x15] STALL handshake Applies to non-control, non-isochronous IN endpoints only (access type is rw). The application sets this bit to stall all tokens from the USB host to this endpoint. If a NAK bit, Global IN NAK, or Global OUT NAK is set along with this bit, the STALL bit takes priority. Only the application can clear this bit, never the core.
    $16 constant OTG_TXFNUM                     \ [0x16 : 4] Tx FIFO number These bits specify the FIFO number associated with this endpoint. Each active IN endpoint must be programmed to a separate FIFO number. This field is valid only for IN endpoints.
    $1a constant OTG_CNAK                       \ [0x1a] Clear NAK A write to this bit clears the NAK bit for the endpoint.
    $1b constant OTG_SNAK                       \ [0x1b] Set NAK A write to this bit sets the NAK bit for the endpoint. Using this bit, the application can control the transmission of NAK handshakes on an endpoint. The core can also set this bit for OUT endpoints on a transfer completed interrupt, or after a SETUP is received on the endpoint.
    $1c constant OTG_SEVNFRM                    \ [0x1c] Set even frame Applies to isochronous IN endpoints only. The alternate description for interrupt/bluk IN endpoint is defined in the next paragraph Writing to this field sets the Even/Odd frame (EONUM) field to even frame.
    $1d constant OTG_SODDFRM                    \ [0x1d] Set odd frame Applies to isochronous IN and OUT endpoints only. Writing to this field sets the Even/Odd frame (EONUM) field to odd frame.
    $1e constant OTG_EPDIS                      \ [0x1e] Endpoint disable The application sets this bit to stop transmitting/receiving data on an endpoint, even before the transfer for that endpoint is complete. The application must wait for the endpoint disabled interrupt before treating the endpoint as disabled. The core clears this bit before setting the endpoint disabled interrupt. The application must set this bit only if endpoint enable is already set for this endpoint.
    $1f constant OTG_EPENA                      \ [0x1f] Endpoint enable The application sets this bit to start transmitting data on an endpoint. The core clears this bit before setting any of the following interrupts on this endpoint: SETUP phase done Endpoint disabled Transfer completed
  [then]


  [ifdef] OTG_OTG_DIEPINT3_DEF
    \
    \ @brief OTG device IN endpoint 3 interrupt register
    \ Address offset: 0x968
    \ Reset value: 0x00000080
    \
    $00 constant OTG_XFRC                       \ [0x00] Transfer completed interrupt This field indicates that the programmed transfer is complete on the AHB as well as on the USB, for this endpoint.
    $01 constant OTG_EPDISD                     \ [0x01] Endpoint disabled interrupt This bit indicates that the endpoint is disabled per the application's request.
    $02 constant OTG_AHBERR                     \ [0x02] AHB error This is generated only in internal DMA mode when there is an AHB error during an AHB read/write. The application can read the corresponding endpoint DMA address register to get the error address.
    $03 constant OTG_TOC                        \ [0x03] Timeout condition Indicates that the core has detected a timeout condition on the USB for the last IN token on this endpoint.
    $04 constant OTG_ITTXFE                     \ [0x04] IN token received when Tx FIFO is empty Indicates that an IN token was received when the associated Tx FIFO (periodic/non-periodic) was empty. This interrupt is asserted on the endpoint for which the IN token was received.
    $05 constant OTG_INEPNM                     \ [0x05] IN token received with EP mismatch Indicates that the data in the top of the non-periodic TxFIFO belongs to an endpoint other than the one for which the IN token was received. This interrupt is asserted on the endpoint for which the IN token was received.
    $06 constant OTG_INEPNE                     \ [0x06] IN endpoint NAK effective This bit can be cleared when the application clears the IN endpoint NAK by writing to the CNAK bit in OTG_DIEPCTLx. This interrupt indicates that the core has sampled the NAK bit set (either by the application or by the core). The interrupt indicates that the IN endpoint NAK bit set by the application has taken effect in the core. This interrupt does not guarantee that a NAK handshake is sent on the USB. A STALL bit takes priority over a NAK bit.
    $07 constant OTG_TXFE                       \ [0x07] Transmit FIFO empty This interrupt is asserted when the Tx FIFO for this endpoint is either half or completely empty. The half or completely empty status is determined by the Tx FIFO Empty Level bit in the OTG_GAHBCFG register (TXFELVL bit in OTG_GAHBCFG).
    $08 constant OTG_TXFIFOUDRN                 \ [0x08] Transmit Fifo Underrun (TxfifoUndrn) The core generates this interrupt when it detects a transmit FIFO underrun condition for this endpoint. Dependency: This interrupt is valid only when Thresholding is enabled
    $09 constant OTG_BNA                        \ [0x09] Buffer not available interrupt The core generates this interrupt when the descriptor accessed is not ready for the core to process, such as host busy or DMA done. This bit is only valid when Scatter/Gather DMA mode is enabled.
    $0b constant OTG_PKTDRPSTS                  \ [0x0b] Packet dropped status This bit indicates to the application that an ISOC OUT packet has been dropped. This bit does not have an associated mask bit and does not generate an interrupt.
    $0d constant OTG_NAK                        \ [0x0d] NAK input The core generates this interrupt when a NAK is transmitted or received by the device. In case of isochronous IN endpoints the interrupt gets generated when a zero length packet is transmitted due to unavailability of data in the Tx FIFO.
  [then]


  [ifdef] OTG_OTG_DIEPTSIZ3_DEF
    \
    \ @brief OTG device IN endpoint 3 transfer size register
    \ Address offset: 0x970
    \ Reset value: 0x00000000
    \
    $00 constant OTG_XFRSIZ                     \ [0x00 : 19] Transfer size This field contains the transfer size in bytes for the current endpoint. The core only interrupts the application after it has exhausted the transfer size amount of data. The transfer size can be set to the maximum packet size of the endpoint, to be interrupted at the end of each packet. The core decrements this field every time a packet from the external memory is written to the Tx FIFO.
    $13 constant OTG_PKTCNT                     \ [0x13 : 10] Packet count Indicates the total number of USB packets that constitute the transfer size amount of data for this endpoint. This field is decremented every time a packet (maximum size or short packet) is read from the Tx FIFO.
    $1d constant OTG_MCNT                       \ [0x1d : 2] Multi count For periodic IN endpoints, this field indicates the number of packets that must be transmitted per frame on the USB. The core uses this field to calculate the data PID for isochronous IN endpoints.
  [then]


  [ifdef] OTG_OTG_DIEPDMA3_DEF
    \
    \ @brief DMA Address This field holds the start address in the external memory from which the data for the endpoint must be fetched. This register is incremented on every AHB transaction.
    \ Address offset: 0x974
    \ Reset value: 0x00000000
    \
    $00 constant OTG_DMAADDR                    \ [0x00 : 32] DMA Address This field holds the start address in the external memory from which the data for the endpoint must be fetched. This register is incremented on every AHB transaction.
  [then]


  [ifdef] OTG_OTG_DTXFSTS3_DEF
    \
    \ @brief OTG device IN endpoint transmit FIFO status register
    \ Address offset: 0x978
    \ Reset value: 0x00000200
    \
    $00 constant OTG_INEPTFSAV                  \ [0x00 : 16] IN endpoint Tx FIFO space available Indicates the amount of free space available in the endpoint Tx FIFO. Values are in terms of 32-bit words: 0xn: n words available Others: Reserved
  [then]


  [ifdef] OTG_OTG_DIEPCTL4_DEF
    \
    \ @brief OTG device IN endpoint 4 control register
    \ Address offset: 0x980
    \ Reset value: 0x00000000
    \
    $00 constant OTG_MPSIZ                      \ [0x00 : 11] Maximum packet size The application must program this field with the maximum packet size for the current logical endpoint. This value is in bytes.
    $0f constant OTG_USBAEP                     \ [0x0f] USB active endpoint Indicates whether this endpoint is active in the current configuration and interface. The core clears this bit for all endpoints (other than EP 0) after detecting a USB reset. After receiving the SetConfiguration and SetInterface commands, the application must program endpoint registers accordingly and set this bit.
    $10 constant OTG_EONUM                      \ [0x10] Even/odd frame Applies to isochronous IN endpoints only. The alternate description that applies for interrupt/bulk IN endpoint only is defined in next paragraph Indicates the frame number in which the core transmits/receives isochronous data for this endpoint. The application must program the even/odd frame number in which it intends to transmit/receive isochronous data for this endpoint using the SEVNFRM and SODDFRM fields in this register.
    $11 constant OTG_NAKSTS                     \ [0x11] NAK status It indicates the following: When either the application or the core sets this bit: For non-isochronous IN endpoints: The core stops transmitting any data on an IN endpoint, even if there are data available in the Tx FIFO. For isochronous IN endpoints: The core sends out a zero-length data packet, even if there are data available in the Tx FIFO. Irrespective of this bit's setting, the core always responds to SETUP data packets with an ACK handshake.
    $12 constant OTG_EPTYP                      \ [0x12 : 2] Endpoint type This is the transfer type supported by this logical endpoint.
    $15 constant OTG_STALL                      \ [0x15] STALL handshake Applies to non-control, non-isochronous IN endpoints only (access type is rw). The application sets this bit to stall all tokens from the USB host to this endpoint. If a NAK bit, Global IN NAK, or Global OUT NAK is set along with this bit, the STALL bit takes priority. Only the application can clear this bit, never the core.
    $16 constant OTG_TXFNUM                     \ [0x16 : 4] Tx FIFO number These bits specify the FIFO number associated with this endpoint. Each active IN endpoint must be programmed to a separate FIFO number. This field is valid only for IN endpoints.
    $1a constant OTG_CNAK                       \ [0x1a] Clear NAK A write to this bit clears the NAK bit for the endpoint.
    $1b constant OTG_SNAK                       \ [0x1b] Set NAK A write to this bit sets the NAK bit for the endpoint. Using this bit, the application can control the transmission of NAK handshakes on an endpoint. The core can also set this bit for OUT endpoints on a transfer completed interrupt, or after a SETUP is received on the endpoint.
    $1c constant OTG_SEVNFRM                    \ [0x1c] Set even frame Applies to isochronous IN endpoints only. The alternate description for interrupt/bluk IN endpoint is defined in the next paragraph Writing to this field sets the Even/Odd frame (EONUM) field to even frame.
    $1d constant OTG_SODDFRM                    \ [0x1d] Set odd frame Applies to isochronous IN and OUT endpoints only. Writing to this field sets the Even/Odd frame (EONUM) field to odd frame.
    $1e constant OTG_EPDIS                      \ [0x1e] Endpoint disable The application sets this bit to stop transmitting/receiving data on an endpoint, even before the transfer for that endpoint is complete. The application must wait for the endpoint disabled interrupt before treating the endpoint as disabled. The core clears this bit before setting the endpoint disabled interrupt. The application must set this bit only if endpoint enable is already set for this endpoint.
    $1f constant OTG_EPENA                      \ [0x1f] Endpoint enable The application sets this bit to start transmitting data on an endpoint. The core clears this bit before setting any of the following interrupts on this endpoint: SETUP phase done Endpoint disabled Transfer completed
  [then]


  [ifdef] OTG_OTG_DIEPINT4_DEF
    \
    \ @brief OTG device IN endpoint 4 interrupt register
    \ Address offset: 0x988
    \ Reset value: 0x00000080
    \
    $00 constant OTG_XFRC                       \ [0x00] Transfer completed interrupt This field indicates that the programmed transfer is complete on the AHB as well as on the USB, for this endpoint.
    $01 constant OTG_EPDISD                     \ [0x01] Endpoint disabled interrupt This bit indicates that the endpoint is disabled per the application's request.
    $02 constant OTG_AHBERR                     \ [0x02] AHB error This is generated only in internal DMA mode when there is an AHB error during an AHB read/write. The application can read the corresponding endpoint DMA address register to get the error address.
    $03 constant OTG_TOC                        \ [0x03] Timeout condition Indicates that the core has detected a timeout condition on the USB for the last IN token on this endpoint.
    $04 constant OTG_ITTXFE                     \ [0x04] IN token received when Tx FIFO is empty Indicates that an IN token was received when the associated Tx FIFO (periodic/non-periodic) was empty. This interrupt is asserted on the endpoint for which the IN token was received.
    $05 constant OTG_INEPNM                     \ [0x05] IN token received with EP mismatch Indicates that the data in the top of the non-periodic TxFIFO belongs to an endpoint other than the one for which the IN token was received. This interrupt is asserted on the endpoint for which the IN token was received.
    $06 constant OTG_INEPNE                     \ [0x06] IN endpoint NAK effective This bit can be cleared when the application clears the IN endpoint NAK by writing to the CNAK bit in OTG_DIEPCTLx. This interrupt indicates that the core has sampled the NAK bit set (either by the application or by the core). The interrupt indicates that the IN endpoint NAK bit set by the application has taken effect in the core. This interrupt does not guarantee that a NAK handshake is sent on the USB. A STALL bit takes priority over a NAK bit.
    $07 constant OTG_TXFE                       \ [0x07] Transmit FIFO empty This interrupt is asserted when the Tx FIFO for this endpoint is either half or completely empty. The half or completely empty status is determined by the Tx FIFO Empty Level bit in the OTG_GAHBCFG register (TXFELVL bit in OTG_GAHBCFG).
    $08 constant OTG_TXFIFOUDRN                 \ [0x08] Transmit Fifo Underrun (TxfifoUndrn) The core generates this interrupt when it detects a transmit FIFO underrun condition for this endpoint. Dependency: This interrupt is valid only when Thresholding is enabled
    $09 constant OTG_BNA                        \ [0x09] Buffer not available interrupt The core generates this interrupt when the descriptor accessed is not ready for the core to process, such as host busy or DMA done. This bit is only valid when Scatter/Gather DMA mode is enabled.
    $0b constant OTG_PKTDRPSTS                  \ [0x0b] Packet dropped status This bit indicates to the application that an ISOC OUT packet has been dropped. This bit does not have an associated mask bit and does not generate an interrupt.
    $0d constant OTG_NAK                        \ [0x0d] NAK input The core generates this interrupt when a NAK is transmitted or received by the device. In case of isochronous IN endpoints the interrupt gets generated when a zero length packet is transmitted due to unavailability of data in the Tx FIFO.
  [then]


  [ifdef] OTG_OTG_DIEPTSIZ4_DEF
    \
    \ @brief OTG device IN endpoint 4 transfer size register
    \ Address offset: 0x990
    \ Reset value: 0x00000000
    \
    $00 constant OTG_XFRSIZ                     \ [0x00 : 19] Transfer size This field contains the transfer size in bytes for the current endpoint. The core only interrupts the application after it has exhausted the transfer size amount of data. The transfer size can be set to the maximum packet size of the endpoint, to be interrupted at the end of each packet. The core decrements this field every time a packet from the external memory is written to the Tx FIFO.
    $13 constant OTG_PKTCNT                     \ [0x13 : 10] Packet count Indicates the total number of USB packets that constitute the transfer size amount of data for this endpoint. This field is decremented every time a packet (maximum size or short packet) is read from the Tx FIFO.
    $1d constant OTG_MCNT                       \ [0x1d : 2] Multi count For periodic IN endpoints, this field indicates the number of packets that must be transmitted per frame on the USB. The core uses this field to calculate the data PID for isochronous IN endpoints.
  [then]


  [ifdef] OTG_OTG_DIEPDMA4_DEF
    \
    \ @brief DMA Address This field holds the start address in the external memory from which the data for the endpoint must be fetched. This register is incremented on every AHB transaction.
    \ Address offset: 0x994
    \ Reset value: 0x00000000
    \
    $00 constant OTG_DMAADDR                    \ [0x00 : 32] DMA Address This field holds the start address in the external memory from which the data for the endpoint must be fetched. This register is incremented on every AHB transaction.
  [then]


  [ifdef] OTG_OTG_DTXFSTS4_DEF
    \
    \ @brief OTG device IN endpoint transmit FIFO status register
    \ Address offset: 0x998
    \ Reset value: 0x00000200
    \
    $00 constant OTG_INEPTFSAV                  \ [0x00 : 16] IN endpoint Tx FIFO space available Indicates the amount of free space available in the endpoint Tx FIFO. Values are in terms of 32-bit words: 0xn: n words available Others: Reserved
  [then]


  [ifdef] OTG_OTG_DIEPCTL5_DEF
    \
    \ @brief OTG device IN endpoint 5 control register
    \ Address offset: 0x9A0
    \ Reset value: 0x00000000
    \
    $00 constant OTG_MPSIZ                      \ [0x00 : 11] Maximum packet size The application must program this field with the maximum packet size for the current logical endpoint. This value is in bytes.
    $0f constant OTG_USBAEP                     \ [0x0f] USB active endpoint Indicates whether this endpoint is active in the current configuration and interface. The core clears this bit for all endpoints (other than EP 0) after detecting a USB reset. After receiving the SetConfiguration and SetInterface commands, the application must program endpoint registers accordingly and set this bit.
    $10 constant OTG_EONUM                      \ [0x10] Even/odd frame Applies to isochronous IN endpoints only. The alternate description that applies for interrupt/bulk IN endpoint only is defined in next paragraph Indicates the frame number in which the core transmits/receives isochronous data for this endpoint. The application must program the even/odd frame number in which it intends to transmit/receive isochronous data for this endpoint using the SEVNFRM and SODDFRM fields in this register.
    $11 constant OTG_NAKSTS                     \ [0x11] NAK status It indicates the following: When either the application or the core sets this bit: For non-isochronous IN endpoints: The core stops transmitting any data on an IN endpoint, even if there are data available in the Tx FIFO. For isochronous IN endpoints: The core sends out a zero-length data packet, even if there are data available in the Tx FIFO. Irrespective of this bit's setting, the core always responds to SETUP data packets with an ACK handshake.
    $12 constant OTG_EPTYP                      \ [0x12 : 2] Endpoint type This is the transfer type supported by this logical endpoint.
    $15 constant OTG_STALL                      \ [0x15] STALL handshake Applies to non-control, non-isochronous IN endpoints only (access type is rw). The application sets this bit to stall all tokens from the USB host to this endpoint. If a NAK bit, Global IN NAK, or Global OUT NAK is set along with this bit, the STALL bit takes priority. Only the application can clear this bit, never the core.
    $16 constant OTG_TXFNUM                     \ [0x16 : 4] Tx FIFO number These bits specify the FIFO number associated with this endpoint. Each active IN endpoint must be programmed to a separate FIFO number. This field is valid only for IN endpoints.
    $1a constant OTG_CNAK                       \ [0x1a] Clear NAK A write to this bit clears the NAK bit for the endpoint.
    $1b constant OTG_SNAK                       \ [0x1b] Set NAK A write to this bit sets the NAK bit for the endpoint. Using this bit, the application can control the transmission of NAK handshakes on an endpoint. The core can also set this bit for OUT endpoints on a transfer completed interrupt, or after a SETUP is received on the endpoint.
    $1c constant OTG_SEVNFRM                    \ [0x1c] Set even frame Applies to isochronous IN endpoints only. The alternate description for interrupt/bluk IN endpoint is defined in the next paragraph Writing to this field sets the Even/Odd frame (EONUM) field to even frame.
    $1d constant OTG_SODDFRM                    \ [0x1d] Set odd frame Applies to isochronous IN and OUT endpoints only. Writing to this field sets the Even/Odd frame (EONUM) field to odd frame.
    $1e constant OTG_EPDIS                      \ [0x1e] Endpoint disable The application sets this bit to stop transmitting/receiving data on an endpoint, even before the transfer for that endpoint is complete. The application must wait for the endpoint disabled interrupt before treating the endpoint as disabled. The core clears this bit before setting the endpoint disabled interrupt. The application must set this bit only if endpoint enable is already set for this endpoint.
    $1f constant OTG_EPENA                      \ [0x1f] Endpoint enable The application sets this bit to start transmitting data on an endpoint. The core clears this bit before setting any of the following interrupts on this endpoint: SETUP phase done Endpoint disabled Transfer completed
  [then]


  [ifdef] OTG_OTG_DIEPINT5_DEF
    \
    \ @brief OTG device IN endpoint 5 interrupt register
    \ Address offset: 0x9A8
    \ Reset value: 0x00000080
    \
    $00 constant OTG_XFRC                       \ [0x00] Transfer completed interrupt This field indicates that the programmed transfer is complete on the AHB as well as on the USB, for this endpoint.
    $01 constant OTG_EPDISD                     \ [0x01] Endpoint disabled interrupt This bit indicates that the endpoint is disabled per the application's request.
    $02 constant OTG_AHBERR                     \ [0x02] AHB error This is generated only in internal DMA mode when there is an AHB error during an AHB read/write. The application can read the corresponding endpoint DMA address register to get the error address.
    $03 constant OTG_TOC                        \ [0x03] Timeout condition Indicates that the core has detected a timeout condition on the USB for the last IN token on this endpoint.
    $04 constant OTG_ITTXFE                     \ [0x04] IN token received when Tx FIFO is empty Indicates that an IN token was received when the associated Tx FIFO (periodic/non-periodic) was empty. This interrupt is asserted on the endpoint for which the IN token was received.
    $05 constant OTG_INEPNM                     \ [0x05] IN token received with EP mismatch Indicates that the data in the top of the non-periodic TxFIFO belongs to an endpoint other than the one for which the IN token was received. This interrupt is asserted on the endpoint for which the IN token was received.
    $06 constant OTG_INEPNE                     \ [0x06] IN endpoint NAK effective This bit can be cleared when the application clears the IN endpoint NAK by writing to the CNAK bit in OTG_DIEPCTLx. This interrupt indicates that the core has sampled the NAK bit set (either by the application or by the core). The interrupt indicates that the IN endpoint NAK bit set by the application has taken effect in the core. This interrupt does not guarantee that a NAK handshake is sent on the USB. A STALL bit takes priority over a NAK bit.
    $07 constant OTG_TXFE                       \ [0x07] Transmit FIFO empty This interrupt is asserted when the Tx FIFO for this endpoint is either half or completely empty. The half or completely empty status is determined by the Tx FIFO Empty Level bit in the OTG_GAHBCFG register (TXFELVL bit in OTG_GAHBCFG).
    $08 constant OTG_TXFIFOUDRN                 \ [0x08] Transmit Fifo Underrun (TxfifoUndrn) The core generates this interrupt when it detects a transmit FIFO underrun condition for this endpoint. Dependency: This interrupt is valid only when Thresholding is enabled
    $09 constant OTG_BNA                        \ [0x09] Buffer not available interrupt The core generates this interrupt when the descriptor accessed is not ready for the core to process, such as host busy or DMA done. This bit is only valid when Scatter/Gather DMA mode is enabled.
    $0b constant OTG_PKTDRPSTS                  \ [0x0b] Packet dropped status This bit indicates to the application that an ISOC OUT packet has been dropped. This bit does not have an associated mask bit and does not generate an interrupt.
    $0d constant OTG_NAK                        \ [0x0d] NAK input The core generates this interrupt when a NAK is transmitted or received by the device. In case of isochronous IN endpoints the interrupt gets generated when a zero length packet is transmitted due to unavailability of data in the Tx FIFO.
  [then]


  [ifdef] OTG_OTG_DIEPTSIZ5_DEF
    \
    \ @brief OTG device IN endpoint 5 transfer size register
    \ Address offset: 0x9B0
    \ Reset value: 0x00000000
    \
    $00 constant OTG_XFRSIZ                     \ [0x00 : 19] Transfer size This field contains the transfer size in bytes for the current endpoint. The core only interrupts the application after it has exhausted the transfer size amount of data. The transfer size can be set to the maximum packet size of the endpoint, to be interrupted at the end of each packet. The core decrements this field every time a packet from the external memory is written to the Tx FIFO.
    $13 constant OTG_PKTCNT                     \ [0x13 : 10] Packet count Indicates the total number of USB packets that constitute the transfer size amount of data for this endpoint. This field is decremented every time a packet (maximum size or short packet) is read from the Tx FIFO.
    $1d constant OTG_MCNT                       \ [0x1d : 2] Multi count For periodic IN endpoints, this field indicates the number of packets that must be transmitted per frame on the USB. The core uses this field to calculate the data PID for isochronous IN endpoints.
  [then]


  [ifdef] OTG_OTG_DIEPDMA5_DEF
    \
    \ @brief DMA Address This field holds the start address in the external memory from which the data for the endpoint must be fetched. This register is incremented on every AHB transaction.
    \ Address offset: 0x9B4
    \ Reset value: 0x00000000
    \
    $00 constant OTG_DMAADDR                    \ [0x00 : 32] DMA Address This field holds the start address in the external memory from which the data for the endpoint must be fetched. This register is incremented on every AHB transaction.
  [then]


  [ifdef] OTG_OTG_DTXFSTS5_DEF
    \
    \ @brief OTG device IN endpoint transmit FIFO status register
    \ Address offset: 0x9B8
    \ Reset value: 0x00000200
    \
    $00 constant OTG_INEPTFSAV                  \ [0x00 : 16] IN endpoint Tx FIFO space available Indicates the amount of free space available in the endpoint Tx FIFO. Values are in terms of 32-bit words: 0xn: n words available Others: Reserved
  [then]


  [ifdef] OTG_OTG_DIEPCTL6_DEF
    \
    \ @brief OTG device IN endpoint 6 control register
    \ Address offset: 0x9C0
    \ Reset value: 0x00000000
    \
    $00 constant OTG_MPSIZ                      \ [0x00 : 11] Maximum packet size The application must program this field with the maximum packet size for the current logical endpoint. This value is in bytes.
    $0f constant OTG_USBAEP                     \ [0x0f] USB active endpoint Indicates whether this endpoint is active in the current configuration and interface. The core clears this bit for all endpoints (other than EP 0) after detecting a USB reset. After receiving the SetConfiguration and SetInterface commands, the application must program endpoint registers accordingly and set this bit.
    $10 constant OTG_EONUM                      \ [0x10] Even/odd frame Applies to isochronous IN endpoints only. The alternate description that applies for interrupt/bulk IN endpoint only is defined in next paragraph Indicates the frame number in which the core transmits/receives isochronous data for this endpoint. The application must program the even/odd frame number in which it intends to transmit/receive isochronous data for this endpoint using the SEVNFRM and SODDFRM fields in this register.
    $11 constant OTG_NAKSTS                     \ [0x11] NAK status It indicates the following: When either the application or the core sets this bit: For non-isochronous IN endpoints: The core stops transmitting any data on an IN endpoint, even if there are data available in the Tx FIFO. For isochronous IN endpoints: The core sends out a zero-length data packet, even if there are data available in the Tx FIFO. Irrespective of this bit's setting, the core always responds to SETUP data packets with an ACK handshake.
    $12 constant OTG_EPTYP                      \ [0x12 : 2] Endpoint type This is the transfer type supported by this logical endpoint.
    $15 constant OTG_STALL                      \ [0x15] STALL handshake Applies to non-control, non-isochronous IN endpoints only (access type is rw). The application sets this bit to stall all tokens from the USB host to this endpoint. If a NAK bit, Global IN NAK, or Global OUT NAK is set along with this bit, the STALL bit takes priority. Only the application can clear this bit, never the core.
    $16 constant OTG_TXFNUM                     \ [0x16 : 4] Tx FIFO number These bits specify the FIFO number associated with this endpoint. Each active IN endpoint must be programmed to a separate FIFO number. This field is valid only for IN endpoints.
    $1a constant OTG_CNAK                       \ [0x1a] Clear NAK A write to this bit clears the NAK bit for the endpoint.
    $1b constant OTG_SNAK                       \ [0x1b] Set NAK A write to this bit sets the NAK bit for the endpoint. Using this bit, the application can control the transmission of NAK handshakes on an endpoint. The core can also set this bit for OUT endpoints on a transfer completed interrupt, or after a SETUP is received on the endpoint.
    $1c constant OTG_SEVNFRM                    \ [0x1c] Set even frame Applies to isochronous IN endpoints only. The alternate description for interrupt/bluk IN endpoint is defined in the next paragraph Writing to this field sets the Even/Odd frame (EONUM) field to even frame.
    $1d constant OTG_SODDFRM                    \ [0x1d] Set odd frame Applies to isochronous IN and OUT endpoints only. Writing to this field sets the Even/Odd frame (EONUM) field to odd frame.
    $1e constant OTG_EPDIS                      \ [0x1e] Endpoint disable The application sets this bit to stop transmitting/receiving data on an endpoint, even before the transfer for that endpoint is complete. The application must wait for the endpoint disabled interrupt before treating the endpoint as disabled. The core clears this bit before setting the endpoint disabled interrupt. The application must set this bit only if endpoint enable is already set for this endpoint.
    $1f constant OTG_EPENA                      \ [0x1f] Endpoint enable The application sets this bit to start transmitting data on an endpoint. The core clears this bit before setting any of the following interrupts on this endpoint: SETUP phase done Endpoint disabled Transfer completed
  [then]


  [ifdef] OTG_OTG_DIEPINT6_DEF
    \
    \ @brief OTG device IN endpoint 6 interrupt register
    \ Address offset: 0x9C8
    \ Reset value: 0x00000080
    \
    $00 constant OTG_XFRC                       \ [0x00] Transfer completed interrupt This field indicates that the programmed transfer is complete on the AHB as well as on the USB, for this endpoint.
    $01 constant OTG_EPDISD                     \ [0x01] Endpoint disabled interrupt This bit indicates that the endpoint is disabled per the application's request.
    $02 constant OTG_AHBERR                     \ [0x02] AHB error This is generated only in internal DMA mode when there is an AHB error during an AHB read/write. The application can read the corresponding endpoint DMA address register to get the error address.
    $03 constant OTG_TOC                        \ [0x03] Timeout condition Indicates that the core has detected a timeout condition on the USB for the last IN token on this endpoint.
    $04 constant OTG_ITTXFE                     \ [0x04] IN token received when Tx FIFO is empty Indicates that an IN token was received when the associated Tx FIFO (periodic/non-periodic) was empty. This interrupt is asserted on the endpoint for which the IN token was received.
    $05 constant OTG_INEPNM                     \ [0x05] IN token received with EP mismatch Indicates that the data in the top of the non-periodic TxFIFO belongs to an endpoint other than the one for which the IN token was received. This interrupt is asserted on the endpoint for which the IN token was received.
    $06 constant OTG_INEPNE                     \ [0x06] IN endpoint NAK effective This bit can be cleared when the application clears the IN endpoint NAK by writing to the CNAK bit in OTG_DIEPCTLx. This interrupt indicates that the core has sampled the NAK bit set (either by the application or by the core). The interrupt indicates that the IN endpoint NAK bit set by the application has taken effect in the core. This interrupt does not guarantee that a NAK handshake is sent on the USB. A STALL bit takes priority over a NAK bit.
    $07 constant OTG_TXFE                       \ [0x07] Transmit FIFO empty This interrupt is asserted when the Tx FIFO for this endpoint is either half or completely empty. The half or completely empty status is determined by the Tx FIFO Empty Level bit in the OTG_GAHBCFG register (TXFELVL bit in OTG_GAHBCFG).
    $08 constant OTG_TXFIFOUDRN                 \ [0x08] Transmit Fifo Underrun (TxfifoUndrn) The core generates this interrupt when it detects a transmit FIFO underrun condition for this endpoint. Dependency: This interrupt is valid only when Thresholding is enabled
    $09 constant OTG_BNA                        \ [0x09] Buffer not available interrupt The core generates this interrupt when the descriptor accessed is not ready for the core to process, such as host busy or DMA done. This bit is only valid when Scatter/Gather DMA mode is enabled.
    $0b constant OTG_PKTDRPSTS                  \ [0x0b] Packet dropped status This bit indicates to the application that an ISOC OUT packet has been dropped. This bit does not have an associated mask bit and does not generate an interrupt.
    $0d constant OTG_NAK                        \ [0x0d] NAK input The core generates this interrupt when a NAK is transmitted or received by the device. In case of isochronous IN endpoints the interrupt gets generated when a zero length packet is transmitted due to unavailability of data in the Tx FIFO.
  [then]


  [ifdef] OTG_OTG_DIEPTSIZ6_DEF
    \
    \ @brief OTG device IN endpoint 6 transfer size register
    \ Address offset: 0x9D0
    \ Reset value: 0x00000000
    \
    $00 constant OTG_XFRSIZ                     \ [0x00 : 19] Transfer size This field contains the transfer size in bytes for the current endpoint. The core only interrupts the application after it has exhausted the transfer size amount of data. The transfer size can be set to the maximum packet size of the endpoint, to be interrupted at the end of each packet. The core decrements this field every time a packet from the external memory is written to the Tx FIFO.
    $13 constant OTG_PKTCNT                     \ [0x13 : 10] Packet count Indicates the total number of USB packets that constitute the transfer size amount of data for this endpoint. This field is decremented every time a packet (maximum size or short packet) is read from the Tx FIFO.
    $1d constant OTG_MCNT                       \ [0x1d : 2] Multi count For periodic IN endpoints, this field indicates the number of packets that must be transmitted per frame on the USB. The core uses this field to calculate the data PID for isochronous IN endpoints.
  [then]


  [ifdef] OTG_OTG_DIEPDMA6_DEF
    \
    \ @brief DMA Address This field holds the start address in the external memory from which the data for the endpoint must be fetched. This register is incremented on every AHB transaction.
    \ Address offset: 0x9D4
    \ Reset value: 0x00000000
    \
    $00 constant OTG_DMAADDR                    \ [0x00 : 32] DMA Address This field holds the start address in the external memory from which the data for the endpoint must be fetched. This register is incremented on every AHB transaction.
  [then]


  [ifdef] OTG_OTG_DTXFSTS6_DEF
    \
    \ @brief OTG device IN endpoint transmit FIFO status register
    \ Address offset: 0x9D8
    \ Reset value: 0x00000200
    \
    $00 constant OTG_INEPTFSAV                  \ [0x00 : 16] IN endpoint Tx FIFO space available Indicates the amount of free space available in the endpoint Tx FIFO. Values are in terms of 32-bit words: 0xn: n words available Others: Reserved
  [then]


  [ifdef] OTG_OTG_DIEPCTL7_DEF
    \
    \ @brief OTG device IN endpoint 7 control register
    \ Address offset: 0x9E0
    \ Reset value: 0x00000000
    \
    $00 constant OTG_MPSIZ                      \ [0x00 : 11] Maximum packet size The application must program this field with the maximum packet size for the current logical endpoint. This value is in bytes.
    $0f constant OTG_USBAEP                     \ [0x0f] USB active endpoint Indicates whether this endpoint is active in the current configuration and interface. The core clears this bit for all endpoints (other than EP 0) after detecting a USB reset. After receiving the SetConfiguration and SetInterface commands, the application must program endpoint registers accordingly and set this bit.
    $10 constant OTG_EONUM                      \ [0x10] Even/odd frame Applies to isochronous IN endpoints only. The alternate description that applies for interrupt/bulk IN endpoint only is defined in next paragraph Indicates the frame number in which the core transmits/receives isochronous data for this endpoint. The application must program the even/odd frame number in which it intends to transmit/receive isochronous data for this endpoint using the SEVNFRM and SODDFRM fields in this register.
    $11 constant OTG_NAKSTS                     \ [0x11] NAK status It indicates the following: When either the application or the core sets this bit: For non-isochronous IN endpoints: The core stops transmitting any data on an IN endpoint, even if there are data available in the Tx FIFO. For isochronous IN endpoints: The core sends out a zero-length data packet, even if there are data available in the Tx FIFO. Irrespective of this bit's setting, the core always responds to SETUP data packets with an ACK handshake.
    $12 constant OTG_EPTYP                      \ [0x12 : 2] Endpoint type This is the transfer type supported by this logical endpoint.
    $15 constant OTG_STALL                      \ [0x15] STALL handshake Applies to non-control, non-isochronous IN endpoints only (access type is rw). The application sets this bit to stall all tokens from the USB host to this endpoint. If a NAK bit, Global IN NAK, or Global OUT NAK is set along with this bit, the STALL bit takes priority. Only the application can clear this bit, never the core.
    $16 constant OTG_TXFNUM                     \ [0x16 : 4] Tx FIFO number These bits specify the FIFO number associated with this endpoint. Each active IN endpoint must be programmed to a separate FIFO number. This field is valid only for IN endpoints.
    $1a constant OTG_CNAK                       \ [0x1a] Clear NAK A write to this bit clears the NAK bit for the endpoint.
    $1b constant OTG_SNAK                       \ [0x1b] Set NAK A write to this bit sets the NAK bit for the endpoint. Using this bit, the application can control the transmission of NAK handshakes on an endpoint. The core can also set this bit for OUT endpoints on a transfer completed interrupt, or after a SETUP is received on the endpoint.
    $1c constant OTG_SEVNFRM                    \ [0x1c] Set even frame Applies to isochronous IN endpoints only. The alternate description for interrupt/bluk IN endpoint is defined in the next paragraph Writing to this field sets the Even/Odd frame (EONUM) field to even frame.
    $1d constant OTG_SODDFRM                    \ [0x1d] Set odd frame Applies to isochronous IN and OUT endpoints only. Writing to this field sets the Even/Odd frame (EONUM) field to odd frame.
    $1e constant OTG_EPDIS                      \ [0x1e] Endpoint disable The application sets this bit to stop transmitting/receiving data on an endpoint, even before the transfer for that endpoint is complete. The application must wait for the endpoint disabled interrupt before treating the endpoint as disabled. The core clears this bit before setting the endpoint disabled interrupt. The application must set this bit only if endpoint enable is already set for this endpoint.
    $1f constant OTG_EPENA                      \ [0x1f] Endpoint enable The application sets this bit to start transmitting data on an endpoint. The core clears this bit before setting any of the following interrupts on this endpoint: SETUP phase done Endpoint disabled Transfer completed
  [then]


  [ifdef] OTG_OTG_DIEPINT7_DEF
    \
    \ @brief OTG device IN endpoint 7 interrupt register
    \ Address offset: 0x9E8
    \ Reset value: 0x00000080
    \
    $00 constant OTG_XFRC                       \ [0x00] Transfer completed interrupt This field indicates that the programmed transfer is complete on the AHB as well as on the USB, for this endpoint.
    $01 constant OTG_EPDISD                     \ [0x01] Endpoint disabled interrupt This bit indicates that the endpoint is disabled per the application's request.
    $02 constant OTG_AHBERR                     \ [0x02] AHB error This is generated only in internal DMA mode when there is an AHB error during an AHB read/write. The application can read the corresponding endpoint DMA address register to get the error address.
    $03 constant OTG_TOC                        \ [0x03] Timeout condition Indicates that the core has detected a timeout condition on the USB for the last IN token on this endpoint.
    $04 constant OTG_ITTXFE                     \ [0x04] IN token received when Tx FIFO is empty Indicates that an IN token was received when the associated Tx FIFO (periodic/non-periodic) was empty. This interrupt is asserted on the endpoint for which the IN token was received.
    $05 constant OTG_INEPNM                     \ [0x05] IN token received with EP mismatch Indicates that the data in the top of the non-periodic TxFIFO belongs to an endpoint other than the one for which the IN token was received. This interrupt is asserted on the endpoint for which the IN token was received.
    $06 constant OTG_INEPNE                     \ [0x06] IN endpoint NAK effective This bit can be cleared when the application clears the IN endpoint NAK by writing to the CNAK bit in OTG_DIEPCTLx. This interrupt indicates that the core has sampled the NAK bit set (either by the application or by the core). The interrupt indicates that the IN endpoint NAK bit set by the application has taken effect in the core. This interrupt does not guarantee that a NAK handshake is sent on the USB. A STALL bit takes priority over a NAK bit.
    $07 constant OTG_TXFE                       \ [0x07] Transmit FIFO empty This interrupt is asserted when the Tx FIFO for this endpoint is either half or completely empty. The half or completely empty status is determined by the Tx FIFO Empty Level bit in the OTG_GAHBCFG register (TXFELVL bit in OTG_GAHBCFG).
    $08 constant OTG_TXFIFOUDRN                 \ [0x08] Transmit Fifo Underrun (TxfifoUndrn) The core generates this interrupt when it detects a transmit FIFO underrun condition for this endpoint. Dependency: This interrupt is valid only when Thresholding is enabled
    $09 constant OTG_BNA                        \ [0x09] Buffer not available interrupt The core generates this interrupt when the descriptor accessed is not ready for the core to process, such as host busy or DMA done. This bit is only valid when Scatter/Gather DMA mode is enabled.
    $0b constant OTG_PKTDRPSTS                  \ [0x0b] Packet dropped status This bit indicates to the application that an ISOC OUT packet has been dropped. This bit does not have an associated mask bit and does not generate an interrupt.
    $0d constant OTG_NAK                        \ [0x0d] NAK input The core generates this interrupt when a NAK is transmitted or received by the device. In case of isochronous IN endpoints the interrupt gets generated when a zero length packet is transmitted due to unavailability of data in the Tx FIFO.
  [then]


  [ifdef] OTG_OTG_DIEPTSIZ7_DEF
    \
    \ @brief OTG device IN endpoint 7 transfer size register
    \ Address offset: 0x9F0
    \ Reset value: 0x00000000
    \
    $00 constant OTG_XFRSIZ                     \ [0x00 : 19] Transfer size This field contains the transfer size in bytes for the current endpoint. The core only interrupts the application after it has exhausted the transfer size amount of data. The transfer size can be set to the maximum packet size of the endpoint, to be interrupted at the end of each packet. The core decrements this field every time a packet from the external memory is written to the Tx FIFO.
    $13 constant OTG_PKTCNT                     \ [0x13 : 10] Packet count Indicates the total number of USB packets that constitute the transfer size amount of data for this endpoint. This field is decremented every time a packet (maximum size or short packet) is read from the Tx FIFO.
    $1d constant OTG_MCNT                       \ [0x1d : 2] Multi count For periodic IN endpoints, this field indicates the number of packets that must be transmitted per frame on the USB. The core uses this field to calculate the data PID for isochronous IN endpoints.
  [then]


  [ifdef] OTG_OTG_DIEPDMA7_DEF
    \
    \ @brief DMA Address This field holds the start address in the external memory from which the data for the endpoint must be fetched. This register is incremented on every AHB transaction.
    \ Address offset: 0x9F4
    \ Reset value: 0x00000000
    \
    $00 constant OTG_DMAADDR                    \ [0x00 : 32] DMA Address This field holds the start address in the external memory from which the data for the endpoint must be fetched. This register is incremented on every AHB transaction.
  [then]


  [ifdef] OTG_OTG_DTXFSTS7_DEF
    \
    \ @brief OTG device IN endpoint transmit FIFO status register
    \ Address offset: 0x9F8
    \ Reset value: 0x00000200
    \
    $00 constant OTG_INEPTFSAV                  \ [0x00 : 16] IN endpoint Tx FIFO space available Indicates the amount of free space available in the endpoint Tx FIFO. Values are in terms of 32-bit words: 0xn: n words available Others: Reserved
  [then]


  [ifdef] OTG_OTG_DIEPCTL8_DEF
    \
    \ @brief OTG device IN endpoint 8 control register
    \ Address offset: 0xA00
    \ Reset value: 0x00000000
    \
    $00 constant OTG_MPSIZ                      \ [0x00 : 11] Maximum packet size The application must program this field with the maximum packet size for the current logical endpoint. This value is in bytes.
    $0f constant OTG_USBAEP                     \ [0x0f] USB active endpoint Indicates whether this endpoint is active in the current configuration and interface. The core clears this bit for all endpoints (other than EP 0) after detecting a USB reset. After receiving the SetConfiguration and SetInterface commands, the application must program endpoint registers accordingly and set this bit.
    $10 constant OTG_EONUM                      \ [0x10] Even/odd frame Applies to isochronous IN endpoints only. The alternate description that applies for interrupt/bulk IN endpoint only is defined in next paragraph Indicates the frame number in which the core transmits/receives isochronous data for this endpoint. The application must program the even/odd frame number in which it intends to transmit/receive isochronous data for this endpoint using the SEVNFRM and SODDFRM fields in this register.
    $11 constant OTG_NAKSTS                     \ [0x11] NAK status It indicates the following: When either the application or the core sets this bit: For non-isochronous IN endpoints: The core stops transmitting any data on an IN endpoint, even if there are data available in the Tx FIFO. For isochronous IN endpoints: The core sends out a zero-length data packet, even if there are data available in the Tx FIFO. Irrespective of this bit's setting, the core always responds to SETUP data packets with an ACK handshake.
    $12 constant OTG_EPTYP                      \ [0x12 : 2] Endpoint type This is the transfer type supported by this logical endpoint.
    $15 constant OTG_STALL                      \ [0x15] STALL handshake Applies to non-control, non-isochronous IN endpoints only (access type is rw). The application sets this bit to stall all tokens from the USB host to this endpoint. If a NAK bit, Global IN NAK, or Global OUT NAK is set along with this bit, the STALL bit takes priority. Only the application can clear this bit, never the core.
    $16 constant OTG_TXFNUM                     \ [0x16 : 4] Tx FIFO number These bits specify the FIFO number associated with this endpoint. Each active IN endpoint must be programmed to a separate FIFO number. This field is valid only for IN endpoints.
    $1a constant OTG_CNAK                       \ [0x1a] Clear NAK A write to this bit clears the NAK bit for the endpoint.
    $1b constant OTG_SNAK                       \ [0x1b] Set NAK A write to this bit sets the NAK bit for the endpoint. Using this bit, the application can control the transmission of NAK handshakes on an endpoint. The core can also set this bit for OUT endpoints on a transfer completed interrupt, or after a SETUP is received on the endpoint.
    $1c constant OTG_SEVNFRM                    \ [0x1c] Set even frame Applies to isochronous IN endpoints only. The alternate description for interrupt/bluk IN endpoint is defined in the next paragraph Writing to this field sets the Even/Odd frame (EONUM) field to even frame.
    $1d constant OTG_SODDFRM                    \ [0x1d] Set odd frame Applies to isochronous IN and OUT endpoints only. Writing to this field sets the Even/Odd frame (EONUM) field to odd frame.
    $1e constant OTG_EPDIS                      \ [0x1e] Endpoint disable The application sets this bit to stop transmitting/receiving data on an endpoint, even before the transfer for that endpoint is complete. The application must wait for the endpoint disabled interrupt before treating the endpoint as disabled. The core clears this bit before setting the endpoint disabled interrupt. The application must set this bit only if endpoint enable is already set for this endpoint.
    $1f constant OTG_EPENA                      \ [0x1f] Endpoint enable The application sets this bit to start transmitting data on an endpoint. The core clears this bit before setting any of the following interrupts on this endpoint: SETUP phase done Endpoint disabled Transfer completed
  [then]


  [ifdef] OTG_OTG_DIEPINT8_DEF
    \
    \ @brief OTG device IN endpoint 8 interrupt register
    \ Address offset: 0xA08
    \ Reset value: 0x00000080
    \
    $00 constant OTG_XFRC                       \ [0x00] Transfer completed interrupt This field indicates that the programmed transfer is complete on the AHB as well as on the USB, for this endpoint.
    $01 constant OTG_EPDISD                     \ [0x01] Endpoint disabled interrupt This bit indicates that the endpoint is disabled per the application's request.
    $02 constant OTG_AHBERR                     \ [0x02] AHB error This is generated only in internal DMA mode when there is an AHB error during an AHB read/write. The application can read the corresponding endpoint DMA address register to get the error address.
    $03 constant OTG_TOC                        \ [0x03] Timeout condition Indicates that the core has detected a timeout condition on the USB for the last IN token on this endpoint.
    $04 constant OTG_ITTXFE                     \ [0x04] IN token received when Tx FIFO is empty Indicates that an IN token was received when the associated Tx FIFO (periodic/non-periodic) was empty. This interrupt is asserted on the endpoint for which the IN token was received.
    $05 constant OTG_INEPNM                     \ [0x05] IN token received with EP mismatch Indicates that the data in the top of the non-periodic TxFIFO belongs to an endpoint other than the one for which the IN token was received. This interrupt is asserted on the endpoint for which the IN token was received.
    $06 constant OTG_INEPNE                     \ [0x06] IN endpoint NAK effective This bit can be cleared when the application clears the IN endpoint NAK by writing to the CNAK bit in OTG_DIEPCTLx. This interrupt indicates that the core has sampled the NAK bit set (either by the application or by the core). The interrupt indicates that the IN endpoint NAK bit set by the application has taken effect in the core. This interrupt does not guarantee that a NAK handshake is sent on the USB. A STALL bit takes priority over a NAK bit.
    $07 constant OTG_TXFE                       \ [0x07] Transmit FIFO empty This interrupt is asserted when the Tx FIFO for this endpoint is either half or completely empty. The half or completely empty status is determined by the Tx FIFO Empty Level bit in the OTG_GAHBCFG register (TXFELVL bit in OTG_GAHBCFG).
    $08 constant OTG_TXFIFOUDRN                 \ [0x08] Transmit Fifo Underrun (TxfifoUndrn) The core generates this interrupt when it detects a transmit FIFO underrun condition for this endpoint. Dependency: This interrupt is valid only when Thresholding is enabled
    $09 constant OTG_BNA                        \ [0x09] Buffer not available interrupt The core generates this interrupt when the descriptor accessed is not ready for the core to process, such as host busy or DMA done. This bit is only valid when Scatter/Gather DMA mode is enabled.
    $0b constant OTG_PKTDRPSTS                  \ [0x0b] Packet dropped status This bit indicates to the application that an ISOC OUT packet has been dropped. This bit does not have an associated mask bit and does not generate an interrupt.
    $0d constant OTG_NAK                        \ [0x0d] NAK input The core generates this interrupt when a NAK is transmitted or received by the device. In case of isochronous IN endpoints the interrupt gets generated when a zero length packet is transmitted due to unavailability of data in the Tx FIFO.
  [then]


  [ifdef] OTG_OTG_DIEPTSIZ8_DEF
    \
    \ @brief OTG device IN endpoint 8 transfer size register
    \ Address offset: 0xA10
    \ Reset value: 0x00000000
    \
    $00 constant OTG_XFRSIZ                     \ [0x00 : 19] Transfer size This field contains the transfer size in bytes for the current endpoint. The core only interrupts the application after it has exhausted the transfer size amount of data. The transfer size can be set to the maximum packet size of the endpoint, to be interrupted at the end of each packet. The core decrements this field every time a packet from the external memory is written to the Tx FIFO.
    $13 constant OTG_PKTCNT                     \ [0x13 : 10] Packet count Indicates the total number of USB packets that constitute the transfer size amount of data for this endpoint. This field is decremented every time a packet (maximum size or short packet) is read from the Tx FIFO.
    $1d constant OTG_MCNT                       \ [0x1d : 2] Multi count For periodic IN endpoints, this field indicates the number of packets that must be transmitted per frame on the USB. The core uses this field to calculate the data PID for isochronous IN endpoints.
  [then]


  [ifdef] OTG_OTG_DIEPDMA8_DEF
    \
    \ @brief DMA Address This field holds the start address in the external memory from which the data for the endpoint must be fetched. This register is incremented on every AHB transaction.
    \ Address offset: 0xA14
    \ Reset value: 0x00000000
    \
    $00 constant OTG_DMAADDR                    \ [0x00 : 32] DMA Address This field holds the start address in the external memory from which the data for the endpoint must be fetched. This register is incremented on every AHB transaction.
  [then]


  [ifdef] OTG_OTG_DTXFSTS8_DEF
    \
    \ @brief OTG device IN endpoint transmit FIFO status register
    \ Address offset: 0xA18
    \ Reset value: 0x00000200
    \
    $00 constant OTG_INEPTFSAV                  \ [0x00 : 16] IN endpoint Tx FIFO space available Indicates the amount of free space available in the endpoint Tx FIFO. Values are in terms of 32-bit words: 0xn: n words available Others: Reserved
  [then]


  [ifdef] OTG_OTG_DOEPCTL0_DEF
    \
    \ @brief OTG device control OUT endpoint 0 control register
    \ Address offset: 0xB00
    \ Reset value: 0x00008000
    \
    $00 constant OTG_MPSIZ                      \ [0x00 : 2] Maximum packet size The maximum packet size for control OUT endpoint 0 is the same as what is programmed in control IN endpoint 0.
    $0f constant OTG_USBAEP                     \ [0x0f] USB active endpoint This bit is always set to 1, indicating that a control endpoint 0 is always active in all configurations and interfaces.
    $11 constant OTG_NAKSTS                     \ [0x11] NAK status Indicates the following: When either the application or the core sets this bit, the core stops receiving data, even if there is space in the Rx FIFO to accommodate the incoming packet. Irrespective of this bit's setting, the core always responds to SETUP data packets with an ACK handshake.
    $12 constant OTG_EPTYP                      \ [0x12 : 2] Endpoint type Hardcoded to 2'b00 for control.
    $14 constant OTG_SNPM                       \ [0x14] Snoop mode This bit configures the endpoint to Snoop mode. In Snoop mode, the core does not check the correctness of OUT packets before transferring them to application memory.
    $15 constant OTG_STALL                      \ [0x15] STALL handshake The application can only set this bit, and the core clears it, when a SETUP token is received for this endpoint. If a NAK bit or Global OUT NAK is set along with this bit, the STALL bit takes priority. Irrespective of this bit's setting, the core always responds to SETUP data packets with an ACK handshake.
    $1a constant OTG_CNAK                       \ [0x1a] Clear NAK A write to this bit clears the NAK bit for the endpoint.
    $1b constant OTG_SNAK                       \ [0x1b] Set NAK A write to this bit sets the NAK bit for the endpoint. Using this bit, the application can control the transmission of NAK handshakes on an endpoint. The core can also set this bit on a transfer completed interrupt, or after a SETUP is received on the endpoint.
    $1e constant OTG_EPDIS                      \ [0x1e] Endpoint disable The application cannot disable control OUT endpoint 0.
    $1f constant OTG_EPENA                      \ [0x1f] Endpoint enable The application sets this bit to start transmitting data on endpoint 0. The core clears this bit before setting any of the following interrupts on this endpoint: SETUP phase done Endpoint disabled Transfer completed
  [then]


  [ifdef] OTG_OTG_DOEPINT0_DEF
    \
    \ @brief OTG device OUT endpoint 0 interrupt register
    \ Address offset: 0xB08
    \ Reset value: 0x00000080
    \
    $00 constant OTG_XFRC                       \ [0x00] Transfer completed interrupt This field indicates that the programmed transfer is complete on the AHB as well as on the USB, for this endpoint.
    $01 constant OTG_EPDISD                     \ [0x01] Endpoint disabled interrupt This bit indicates that the endpoint is disabled per the application's request.
    $02 constant OTG_AHBERR                     \ [0x02] AHB error This is generated only in internal DMA mode when there is an AHB error during an AHB read/write. The application can read the corresponding endpoint DMA address register to get the error address.
    $03 constant OTG_STUP                       \ [0x03] SETUP phase done Applies to control OUT endpoint only.Indicates that the SETUP phase for the control endpoint is complete and no more back-to-back SETUP packets were received for the current control transfer. On this interrupt, the application can decode the received SETUP data packet.
    $04 constant OTG_OTEPDIS                    \ [0x04] OUT token received when endpoint disabled Applies only to control OUT endpoints. Indicates that an OUT token was received when the endpoint was not yet enabled. This interrupt is asserted on the endpoint for which the OUT token was received.
    $05 constant OTG_STSPHSRX                   \ [0x05] Status phase received for control write This interrupt is valid only for control OUT endpoints. This interrupt is generated only after OTG has transferred all the data that the host has sent during the data phase of a control write transfer, to the system memory buffer. The interrupt indicates to the application that the host has switched from data phase to the status phase of a control write transfer. The application can use this interrupt to ACK or STALL the status phase, after it has decoded the data phase.
    $06 constant OTG_B2BSTUP                    \ [0x06] Back-to-back SETUP packets received Applies to control OUT endpoint only. This bit indicates that the core has received more than three back-to-back SETUP packets for this particular endpoint.
    $08 constant OTG_OUTPKTERR                  \ [0x08] OUT packet error This interrupt is asserted when the core detects an overflow or a CRC error for an OUT packet. This interrupt is valid only when thresholding is enabled.
    $09 constant OTG_BNA                        \ [0x09] Buffer not available interrupt The core generates this interrupt when the descriptor accessed is not ready for the core to process, such as host busy or DMA done. This bit is only valid when Scatter/Gather DMA mode is enabled.
    $0c constant OTG_BERR                       \ [0x0c] Babble error interrupt The core generates this interrupt when babble is received for the endpoint.
    $0d constant OTG_NAK                        \ [0x0d] NAK input The core generates this interrupt when a NAK is transmitted or received by the device. In case of isochronous IN endpoints the interrupt gets generated when a zero length packet is transmitted due to unavailability of data in the Tx FIFO.
    $0e constant OTG_NYET                       \ [0x0e] NYET interrupt This interrupt is generated when a NYET response is transmitted for a non isochronous OUT endpoint.
    $0f constant OTG_STPKTRX                    \ [0x0f] Setup packet received Applicable for control OUT endpoints in only in the Buffer DMA Mode. Set by the OTG, this bit indicates that this buffer holds 8 bytes of setup data. There is only one setup packet per buffer. On receiving a setup packet, the OTG closes the buffer and disables the corresponding endpoint after SETUP_COMPLETE status is seen in the Rx FIFO. OTG puts a SETUP_COMPLETE status into the Rx FIFO when it sees the first IN or OUT token after the SETUP packet for that particular endpoint. The application must then re-enable the endpoint to receive any OUT data for the control transfer and reprogram the buffer start address. Because of the above behavior, OTG can receive any number of back to back setup packets and one buffer for every setup packet is used.
  [then]


  [ifdef] OTG_OTG_DOEPTSIZ0_DEF
    \
    \ @brief OTG device OUT endpoint 0 transfer size register
    \ Address offset: 0xB10
    \ Reset value: 0x00000000
    \
    $00 constant OTG_XFRSIZ                     \ [0x00 : 7] Transfer size Indicates the transfer size in bytes for endpoint 0. The core interrupts the application only after it has exhausted the transfer size amount of data. The transfer size can be set to the maximum packet size of the endpoint, to be interrupted at the end of each packet. The core decrements this field every time a packet is read from the Rx FIFO and written to the external memory.
    $13 constant OTG_PKTCNT                     \ [0x13] Packet count This field is decremented to zero after a packet is written into the Rx FIFO.
    $1d constant OTG_STUPCNT                    \ [0x1d : 2] SETUP packet count This field specifies the number of back-to-back SETUP data packets the endpoint can receive.
  [then]


  [ifdef] OTG_OTG_DOEPDMA0_DEF
    \
    \ @brief DMA Address This field holds the start address in the external memory from which the data for the endpoint must be fetched. This register is incremented on every AHB transaction.
    \ Address offset: 0xB14
    \ Reset value: 0x00000000
    \
    $00 constant OTG_DMAADDR                    \ [0x00 : 32] DMA Address This field holds the start address in the external memory from which the data for the endpoint must be fetched. This register is incremented on every AHB transaction.
  [then]


  [ifdef] OTG_OTG_DOEPCTL1_DEF
    \
    \ @brief OTG device OUT endpoint 1 control register
    \ Address offset: 0xB20
    \ Reset value: 0x00000000
    \
    $00 constant OTG_MPSIZ                      \ [0x00 : 11] Maximum packet size The application must program this field with the maximum packet size for the current logical endpoint. This value is in bytes.
    $0f constant OTG_USBAEP                     \ [0x0f] USB active endpoint Indicates whether this endpoint is active in the current configuration and interface. The core clears this bit for all endpoints (other than EP 0) after detecting a USB reset. After receiving the SetConfiguration and SetInterface commands, the application must program endpoint registers accordingly and set this bit.
    $10 constant OTG_DPID                       \ [0x10] Endpoint data PID Applies to interrupt/bulk OUT endpoints only. Contains the PID of the packet to be received or transmitted on this endpoint. The application must program the PID of the first packet to be received or transmitted on this endpoint, after the endpoint is activated. The application uses the SD0PID register field to program either DATA0 or DATA1 PID.
    $11 constant OTG_NAKSTS                     \ [0x11] NAK status Indicates the following: When either the application or the core sets this bit: The core stops receiving any data on an OUT endpoint, even if there is space in the Rx FIFO to accommodate the incoming packet. Irrespective of this bit's setting, the core always responds to SETUP data packets with an ACK handshake.
    $12 constant OTG_EPTYP                      \ [0x12 : 2] Endpoint type This is the transfer type supported by this logical endpoint.
    $14 constant OTG_SNPM                       \ [0x14] Snoop mode This bit configures the endpoint to Snoop mode. In Snoop mode, the core does not check the correctness of OUT packets before transferring them to application memory.
    $15 constant OTG_STALL                      \ [0x15] STALL handshake Applies to non-control, non-isochronous OUT endpoints only (access type is rw). The application sets this bit to stall all tokens from the USB host to this endpoint. If a NAK bit, Global IN NAK, or Global OUT NAK is set along with this bit, the STALL bit takes priority. Only the application can clear this bit, never the core. Applies to control endpoints only (access type is rs). The application can only set this bit, and the core clears it, when a SETUP token is received for this endpoint. If a NAK bit, Global IN NAK, or Global OUT NAK is set along with this bit, the STALL bit takes priority. Irrespective of this bit's setting, the core always responds to SETUP data packets with an ACK handshake.
    $1a constant OTG_CNAK                       \ [0x1a] Clear NAK A write to this bit clears the NAK bit for the endpoint.
    $1b constant OTG_SNAK                       \ [0x1b] Set NAK A write to this bit sets the NAK bit for the endpoint. Using this bit, the application can control the transmission of NAK handshakes on an endpoint. The core can also set this bit for OUT endpoints on a transfer completed interrupt, or after a SETUP is received on the endpoint.
    $1c constant OTG_SD0PID                     \ [0x1c] Set DATA0 PID Applies to interrupt/bulk OUT endpoints only. Writing to this field sets the endpoint data PID (DPID) field in this register to DATA0.
    $1d constant OTG_SD1PID                     \ [0x1d] Set DATA1 PID Applies to interrupt/bulk IN and OUT endpoints only. Writing to this field sets the endpoint data PID (DPID) field in this register to DATA1.
    $1e constant OTG_EPDIS                      \ [0x1e] Endpoint disable The application sets this bit to stop transmitting/receiving data on an endpoint, even before the transfer for that endpoint is complete. The application must wait for the endpoint disabled interrupt before treating the endpoint as disabled. The core clears this bit before setting the endpoint disabled interrupt. The application must set this bit only if endpoint enable is already set for this endpoint.
    $1f constant OTG_EPENA                      \ [0x1f] Endpoint enable Applies to IN and OUT endpoints. The application sets this bit to start transmitting data on an endpoint. The core clears this bit before setting any of the following interrupts on this endpoint: SETUP phase done Endpoint disabled Transfer completed
  [then]


  [ifdef] OTG_OTG_DOEPINT1_DEF
    \
    \ @brief OTG device OUT endpoint 1 interrupt register
    \ Address offset: 0xB28
    \ Reset value: 0x00000080
    \
    $00 constant OTG_XFRC                       \ [0x00] Transfer completed interrupt This field indicates that the programmed transfer is complete on the AHB as well as on the USB, for this endpoint.
    $01 constant OTG_EPDISD                     \ [0x01] Endpoint disabled interrupt This bit indicates that the endpoint is disabled per the application's request.
    $02 constant OTG_AHBERR                     \ [0x02] AHB error This is generated only in internal DMA mode when there is an AHB error during an AHB read/write. The application can read the corresponding endpoint DMA address register to get the error address.
    $03 constant OTG_STUP                       \ [0x03] SETUP phase done Applies to control OUT endpoint only.Indicates that the SETUP phase for the control endpoint is complete and no more back-to-back SETUP packets were received for the current control transfer. On this interrupt, the application can decode the received SETUP data packet.
    $04 constant OTG_OTEPDIS                    \ [0x04] OUT token received when endpoint disabled Applies only to control OUT endpoints. Indicates that an OUT token was received when the endpoint was not yet enabled. This interrupt is asserted on the endpoint for which the OUT token was received.
    $05 constant OTG_STSPHSRX                   \ [0x05] Status phase received for control write This interrupt is valid only for control OUT endpoints. This interrupt is generated only after OTG has transferred all the data that the host has sent during the data phase of a control write transfer, to the system memory buffer. The interrupt indicates to the application that the host has switched from data phase to the status phase of a control write transfer. The application can use this interrupt to ACK or STALL the status phase, after it has decoded the data phase.
    $06 constant OTG_B2BSTUP                    \ [0x06] Back-to-back SETUP packets received Applies to control OUT endpoint only. This bit indicates that the core has received more than three back-to-back SETUP packets for this particular endpoint.
    $08 constant OTG_OUTPKTERR                  \ [0x08] OUT packet error This interrupt is asserted when the core detects an overflow or a CRC error for an OUT packet. This interrupt is valid only when thresholding is enabled.
    $09 constant OTG_BNA                        \ [0x09] Buffer not available interrupt The core generates this interrupt when the descriptor accessed is not ready for the core to process, such as host busy or DMA done. This bit is only valid when Scatter/Gather DMA mode is enabled.
    $0c constant OTG_BERR                       \ [0x0c] Babble error interrupt The core generates this interrupt when babble is received for the endpoint.
    $0d constant OTG_NAK                        \ [0x0d] NAK input The core generates this interrupt when a NAK is transmitted or received by the device. In case of isochronous IN endpoints the interrupt gets generated when a zero length packet is transmitted due to unavailability of data in the Tx FIFO.
    $0e constant OTG_NYET                       \ [0x0e] NYET interrupt This interrupt is generated when a NYET response is transmitted for a non isochronous OUT endpoint.
    $0f constant OTG_STPKTRX                    \ [0x0f] Setup packet received Applicable for control OUT endpoints in only in the Buffer DMA Mode. Set by the OTG, this bit indicates that this buffer holds 8 bytes of setup data. There is only one setup packet per buffer. On receiving a setup packet, the OTG closes the buffer and disables the corresponding endpoint after SETUP_COMPLETE status is seen in the Rx FIFO. OTG puts a SETUP_COMPLETE status into the Rx FIFO when it sees the first IN or OUT token after the SETUP packet for that particular endpoint. The application must then re-enable the endpoint to receive any OUT data for the control transfer and reprogram the buffer start address. Because of the above behavior, OTG can receive any number of back to back setup packets and one buffer for every setup packet is used.
  [then]


  [ifdef] OTG_OTG_DOEPTSIZ1_DEF
    \
    \ @brief OTG device OUT endpoint 1 transfer size register
    \ Address offset: 0xB30
    \ Reset value: 0x00000000
    \
    $00 constant OTG_XFRSIZ                     \ [0x00 : 19] Transfer size This field contains the transfer size in bytes for the current endpoint. The core only interrupts the application after it has exhausted the transfer size amount of data. The transfer size can be set to the maximum packet size of the endpoint, to be interrupted at the end of each packet. The core decrements this field every time a packet is read from the Rx FIFO and written to the external memory.
    $13 constant OTG_PKTCNT                     \ [0x13 : 10] Packet count Indicates the total number of USB packets that constitute the transfer size amount of data for this endpoint. This field is decremented every time a packet (maximum size or short packet) is written to the Rx FIFO.
    $1d constant OTG_RXDPID                     \ [0x1d : 2] Received data PID Applies to isochronous OUT endpoints only. Control OUT endpoints only description is defined at the next paragraph. This is the data PID received in the last packet for this endpoint.
  [then]


  [ifdef] OTG_OTG_DOEPDMA1_DEF
    \
    \ @brief DMA Address This field holds the start address in the external memory from which the data for the endpoint must be fetched. This register is incremented on every AHB transaction.
    \ Address offset: 0xB34
    \ Reset value: 0x00000000
    \
    $00 constant OTG_DMAADDR                    \ [0x00 : 32] DMA Address This field holds the start address in the external memory from which the data for the endpoint must be fetched. This register is incremented on every AHB transaction.
  [then]


  [ifdef] OTG_OTG_DOEPCTL2_DEF
    \
    \ @brief OTG device OUT endpoint 2 control register
    \ Address offset: 0xB40
    \ Reset value: 0x00000000
    \
    $00 constant OTG_MPSIZ                      \ [0x00 : 11] Maximum packet size The application must program this field with the maximum packet size for the current logical endpoint. This value is in bytes.
    $0f constant OTG_USBAEP                     \ [0x0f] USB active endpoint Indicates whether this endpoint is active in the current configuration and interface. The core clears this bit for all endpoints (other than EP 0) after detecting a USB reset. After receiving the SetConfiguration and SetInterface commands, the application must program endpoint registers accordingly and set this bit.
    $10 constant OTG_DPID                       \ [0x10] Endpoint data PID Applies to interrupt/bulk OUT endpoints only. Contains the PID of the packet to be received or transmitted on this endpoint. The application must program the PID of the first packet to be received or transmitted on this endpoint, after the endpoint is activated. The application uses the SD0PID register field to program either DATA0 or DATA1 PID.
    $11 constant OTG_NAKSTS                     \ [0x11] NAK status Indicates the following: When either the application or the core sets this bit: The core stops receiving any data on an OUT endpoint, even if there is space in the Rx FIFO to accommodate the incoming packet. Irrespective of this bit's setting, the core always responds to SETUP data packets with an ACK handshake.
    $12 constant OTG_EPTYP                      \ [0x12 : 2] Endpoint type This is the transfer type supported by this logical endpoint.
    $14 constant OTG_SNPM                       \ [0x14] Snoop mode This bit configures the endpoint to Snoop mode. In Snoop mode, the core does not check the correctness of OUT packets before transferring them to application memory.
    $15 constant OTG_STALL                      \ [0x15] STALL handshake Applies to non-control, non-isochronous OUT endpoints only (access type is rw). The application sets this bit to stall all tokens from the USB host to this endpoint. If a NAK bit, Global IN NAK, or Global OUT NAK is set along with this bit, the STALL bit takes priority. Only the application can clear this bit, never the core. Applies to control endpoints only (access type is rs). The application can only set this bit, and the core clears it, when a SETUP token is received for this endpoint. If a NAK bit, Global IN NAK, or Global OUT NAK is set along with this bit, the STALL bit takes priority. Irrespective of this bit's setting, the core always responds to SETUP data packets with an ACK handshake.
    $1a constant OTG_CNAK                       \ [0x1a] Clear NAK A write to this bit clears the NAK bit for the endpoint.
    $1b constant OTG_SNAK                       \ [0x1b] Set NAK A write to this bit sets the NAK bit for the endpoint. Using this bit, the application can control the transmission of NAK handshakes on an endpoint. The core can also set this bit for OUT endpoints on a transfer completed interrupt, or after a SETUP is received on the endpoint.
    $1c constant OTG_SD0PID                     \ [0x1c] Set DATA0 PID Applies to interrupt/bulk OUT endpoints only. Writing to this field sets the endpoint data PID (DPID) field in this register to DATA0.
    $1d constant OTG_SD1PID                     \ [0x1d] Set DATA1 PID Applies to interrupt/bulk IN and OUT endpoints only. Writing to this field sets the endpoint data PID (DPID) field in this register to DATA1.
    $1e constant OTG_EPDIS                      \ [0x1e] Endpoint disable The application sets this bit to stop transmitting/receiving data on an endpoint, even before the transfer for that endpoint is complete. The application must wait for the endpoint disabled interrupt before treating the endpoint as disabled. The core clears this bit before setting the endpoint disabled interrupt. The application must set this bit only if endpoint enable is already set for this endpoint.
    $1f constant OTG_EPENA                      \ [0x1f] Endpoint enable Applies to IN and OUT endpoints. The application sets this bit to start transmitting data on an endpoint. The core clears this bit before setting any of the following interrupts on this endpoint: SETUP phase done Endpoint disabled Transfer completed
  [then]


  [ifdef] OTG_OTG_DOEPINT2_DEF
    \
    \ @brief OTG device OUT endpoint 2 interrupt register
    \ Address offset: 0xB48
    \ Reset value: 0x00000080
    \
    $00 constant OTG_XFRC                       \ [0x00] Transfer completed interrupt This field indicates that the programmed transfer is complete on the AHB as well as on the USB, for this endpoint.
    $01 constant OTG_EPDISD                     \ [0x01] Endpoint disabled interrupt This bit indicates that the endpoint is disabled per the application's request.
    $02 constant OTG_AHBERR                     \ [0x02] AHB error This is generated only in internal DMA mode when there is an AHB error during an AHB read/write. The application can read the corresponding endpoint DMA address register to get the error address.
    $03 constant OTG_STUP                       \ [0x03] SETUP phase done Applies to control OUT endpoint only.Indicates that the SETUP phase for the control endpoint is complete and no more back-to-back SETUP packets were received for the current control transfer. On this interrupt, the application can decode the received SETUP data packet.
    $04 constant OTG_OTEPDIS                    \ [0x04] OUT token received when endpoint disabled Applies only to control OUT endpoints. Indicates that an OUT token was received when the endpoint was not yet enabled. This interrupt is asserted on the endpoint for which the OUT token was received.
    $05 constant OTG_STSPHSRX                   \ [0x05] Status phase received for control write This interrupt is valid only for control OUT endpoints. This interrupt is generated only after OTG has transferred all the data that the host has sent during the data phase of a control write transfer, to the system memory buffer. The interrupt indicates to the application that the host has switched from data phase to the status phase of a control write transfer. The application can use this interrupt to ACK or STALL the status phase, after it has decoded the data phase.
    $06 constant OTG_B2BSTUP                    \ [0x06] Back-to-back SETUP packets received Applies to control OUT endpoint only. This bit indicates that the core has received more than three back-to-back SETUP packets for this particular endpoint.
    $08 constant OTG_OUTPKTERR                  \ [0x08] OUT packet error This interrupt is asserted when the core detects an overflow or a CRC error for an OUT packet. This interrupt is valid only when thresholding is enabled.
    $09 constant OTG_BNA                        \ [0x09] Buffer not available interrupt The core generates this interrupt when the descriptor accessed is not ready for the core to process, such as host busy or DMA done. This bit is only valid when Scatter/Gather DMA mode is enabled.
    $0c constant OTG_BERR                       \ [0x0c] Babble error interrupt The core generates this interrupt when babble is received for the endpoint.
    $0d constant OTG_NAK                        \ [0x0d] NAK input The core generates this interrupt when a NAK is transmitted or received by the device. In case of isochronous IN endpoints the interrupt gets generated when a zero length packet is transmitted due to unavailability of data in the Tx FIFO.
    $0e constant OTG_NYET                       \ [0x0e] NYET interrupt This interrupt is generated when a NYET response is transmitted for a non isochronous OUT endpoint.
    $0f constant OTG_STPKTRX                    \ [0x0f] Setup packet received Applicable for control OUT endpoints in only in the Buffer DMA Mode. Set by the OTG, this bit indicates that this buffer holds 8 bytes of setup data. There is only one setup packet per buffer. On receiving a setup packet, the OTG closes the buffer and disables the corresponding endpoint after SETUP_COMPLETE status is seen in the Rx FIFO. OTG puts a SETUP_COMPLETE status into the Rx FIFO when it sees the first IN or OUT token after the SETUP packet for that particular endpoint. The application must then re-enable the endpoint to receive any OUT data for the control transfer and reprogram the buffer start address. Because of the above behavior, OTG can receive any number of back to back setup packets and one buffer for every setup packet is used.
  [then]


  [ifdef] OTG_OTG_DOEPTSIZ2_DEF
    \
    \ @brief OTG device OUT endpoint 2 transfer size register
    \ Address offset: 0xB50
    \ Reset value: 0x00000000
    \
    $00 constant OTG_XFRSIZ                     \ [0x00 : 19] Transfer size This field contains the transfer size in bytes for the current endpoint. The core only interrupts the application after it has exhausted the transfer size amount of data. The transfer size can be set to the maximum packet size of the endpoint, to be interrupted at the end of each packet. The core decrements this field every time a packet is read from the Rx FIFO and written to the external memory.
    $13 constant OTG_PKTCNT                     \ [0x13 : 10] Packet count Indicates the total number of USB packets that constitute the transfer size amount of data for this endpoint. This field is decremented every time a packet (maximum size or short packet) is written to the Rx FIFO.
    $1d constant OTG_RXDPID                     \ [0x1d : 2] Received data PID Applies to isochronous OUT endpoints only. Control OUT endpoints only description is defined at the next paragraph. This is the data PID received in the last packet for this endpoint.
  [then]


  [ifdef] OTG_OTG_DOEPDMA2_DEF
    \
    \ @brief DMA Address This field holds the start address in the external memory from which the data for the endpoint must be fetched. This register is incremented on every AHB transaction.
    \ Address offset: 0xB54
    \ Reset value: 0x00000000
    \
    $00 constant OTG_DMAADDR                    \ [0x00 : 32] DMA Address This field holds the start address in the external memory from which the data for the endpoint must be fetched. This register is incremented on every AHB transaction.
  [then]


  [ifdef] OTG_OTG_DOEPCTL3_DEF
    \
    \ @brief OTG device OUT endpoint 3 control register
    \ Address offset: 0xB60
    \ Reset value: 0x00000000
    \
    $00 constant OTG_MPSIZ                      \ [0x00 : 11] Maximum packet size The application must program this field with the maximum packet size for the current logical endpoint. This value is in bytes.
    $0f constant OTG_USBAEP                     \ [0x0f] USB active endpoint Indicates whether this endpoint is active in the current configuration and interface. The core clears this bit for all endpoints (other than EP 0) after detecting a USB reset. After receiving the SetConfiguration and SetInterface commands, the application must program endpoint registers accordingly and set this bit.
    $10 constant OTG_DPID                       \ [0x10] Endpoint data PID Applies to interrupt/bulk OUT endpoints only. Contains the PID of the packet to be received or transmitted on this endpoint. The application must program the PID of the first packet to be received or transmitted on this endpoint, after the endpoint is activated. The application uses the SD0PID register field to program either DATA0 or DATA1 PID.
    $11 constant OTG_NAKSTS                     \ [0x11] NAK status Indicates the following: When either the application or the core sets this bit: The core stops receiving any data on an OUT endpoint, even if there is space in the Rx FIFO to accommodate the incoming packet. Irrespective of this bit's setting, the core always responds to SETUP data packets with an ACK handshake.
    $12 constant OTG_EPTYP                      \ [0x12 : 2] Endpoint type This is the transfer type supported by this logical endpoint.
    $14 constant OTG_SNPM                       \ [0x14] Snoop mode This bit configures the endpoint to Snoop mode. In Snoop mode, the core does not check the correctness of OUT packets before transferring them to application memory.
    $15 constant OTG_STALL                      \ [0x15] STALL handshake Applies to non-control, non-isochronous OUT endpoints only (access type is rw). The application sets this bit to stall all tokens from the USB host to this endpoint. If a NAK bit, Global IN NAK, or Global OUT NAK is set along with this bit, the STALL bit takes priority. Only the application can clear this bit, never the core. Applies to control endpoints only (access type is rs). The application can only set this bit, and the core clears it, when a SETUP token is received for this endpoint. If a NAK bit, Global IN NAK, or Global OUT NAK is set along with this bit, the STALL bit takes priority. Irrespective of this bit's setting, the core always responds to SETUP data packets with an ACK handshake.
    $1a constant OTG_CNAK                       \ [0x1a] Clear NAK A write to this bit clears the NAK bit for the endpoint.
    $1b constant OTG_SNAK                       \ [0x1b] Set NAK A write to this bit sets the NAK bit for the endpoint. Using this bit, the application can control the transmission of NAK handshakes on an endpoint. The core can also set this bit for OUT endpoints on a transfer completed interrupt, or after a SETUP is received on the endpoint.
    $1c constant OTG_SD0PID                     \ [0x1c] Set DATA0 PID Applies to interrupt/bulk OUT endpoints only. Writing to this field sets the endpoint data PID (DPID) field in this register to DATA0.
    $1d constant OTG_SD1PID                     \ [0x1d] Set DATA1 PID Applies to interrupt/bulk IN and OUT endpoints only. Writing to this field sets the endpoint data PID (DPID) field in this register to DATA1.
    $1e constant OTG_EPDIS                      \ [0x1e] Endpoint disable The application sets this bit to stop transmitting/receiving data on an endpoint, even before the transfer for that endpoint is complete. The application must wait for the endpoint disabled interrupt before treating the endpoint as disabled. The core clears this bit before setting the endpoint disabled interrupt. The application must set this bit only if endpoint enable is already set for this endpoint.
    $1f constant OTG_EPENA                      \ [0x1f] Endpoint enable Applies to IN and OUT endpoints. The application sets this bit to start transmitting data on an endpoint. The core clears this bit before setting any of the following interrupts on this endpoint: SETUP phase done Endpoint disabled Transfer completed
  [then]


  [ifdef] OTG_OTG_DOEPINT3_DEF
    \
    \ @brief OTG device OUT endpoint 3 interrupt register
    \ Address offset: 0xB68
    \ Reset value: 0x00000080
    \
    $00 constant OTG_XFRC                       \ [0x00] Transfer completed interrupt This field indicates that the programmed transfer is complete on the AHB as well as on the USB, for this endpoint.
    $01 constant OTG_EPDISD                     \ [0x01] Endpoint disabled interrupt This bit indicates that the endpoint is disabled per the application's request.
    $02 constant OTG_AHBERR                     \ [0x02] AHB error This is generated only in internal DMA mode when there is an AHB error during an AHB read/write. The application can read the corresponding endpoint DMA address register to get the error address.
    $03 constant OTG_STUP                       \ [0x03] SETUP phase done Applies to control OUT endpoint only.Indicates that the SETUP phase for the control endpoint is complete and no more back-to-back SETUP packets were received for the current control transfer. On this interrupt, the application can decode the received SETUP data packet.
    $04 constant OTG_OTEPDIS                    \ [0x04] OUT token received when endpoint disabled Applies only to control OUT endpoints. Indicates that an OUT token was received when the endpoint was not yet enabled. This interrupt is asserted on the endpoint for which the OUT token was received.
    $05 constant OTG_STSPHSRX                   \ [0x05] Status phase received for control write This interrupt is valid only for control OUT endpoints. This interrupt is generated only after OTG has transferred all the data that the host has sent during the data phase of a control write transfer, to the system memory buffer. The interrupt indicates to the application that the host has switched from data phase to the status phase of a control write transfer. The application can use this interrupt to ACK or STALL the status phase, after it has decoded the data phase.
    $06 constant OTG_B2BSTUP                    \ [0x06] Back-to-back SETUP packets received Applies to control OUT endpoint only. This bit indicates that the core has received more than three back-to-back SETUP packets for this particular endpoint.
    $08 constant OTG_OUTPKTERR                  \ [0x08] OUT packet error This interrupt is asserted when the core detects an overflow or a CRC error for an OUT packet. This interrupt is valid only when thresholding is enabled.
    $09 constant OTG_BNA                        \ [0x09] Buffer not available interrupt The core generates this interrupt when the descriptor accessed is not ready for the core to process, such as host busy or DMA done. This bit is only valid when Scatter/Gather DMA mode is enabled.
    $0c constant OTG_BERR                       \ [0x0c] Babble error interrupt The core generates this interrupt when babble is received for the endpoint.
    $0d constant OTG_NAK                        \ [0x0d] NAK input The core generates this interrupt when a NAK is transmitted or received by the device. In case of isochronous IN endpoints the interrupt gets generated when a zero length packet is transmitted due to unavailability of data in the Tx FIFO.
    $0e constant OTG_NYET                       \ [0x0e] NYET interrupt This interrupt is generated when a NYET response is transmitted for a non isochronous OUT endpoint.
    $0f constant OTG_STPKTRX                    \ [0x0f] Setup packet received Applicable for control OUT endpoints in only in the Buffer DMA Mode. Set by the OTG, this bit indicates that this buffer holds 8 bytes of setup data. There is only one setup packet per buffer. On receiving a setup packet, the OTG closes the buffer and disables the corresponding endpoint after SETUP_COMPLETE status is seen in the Rx FIFO. OTG puts a SETUP_COMPLETE status into the Rx FIFO when it sees the first IN or OUT token after the SETUP packet for that particular endpoint. The application must then re-enable the endpoint to receive any OUT data for the control transfer and reprogram the buffer start address. Because of the above behavior, OTG can receive any number of back to back setup packets and one buffer for every setup packet is used.
  [then]


  [ifdef] OTG_OTG_DOEPTSIZ3_DEF
    \
    \ @brief OTG device OUT endpoint 3 transfer size register
    \ Address offset: 0xB70
    \ Reset value: 0x00000000
    \
    $00 constant OTG_XFRSIZ                     \ [0x00 : 19] Transfer size This field contains the transfer size in bytes for the current endpoint. The core only interrupts the application after it has exhausted the transfer size amount of data. The transfer size can be set to the maximum packet size of the endpoint, to be interrupted at the end of each packet. The core decrements this field every time a packet is read from the Rx FIFO and written to the external memory.
    $13 constant OTG_PKTCNT                     \ [0x13 : 10] Packet count Indicates the total number of USB packets that constitute the transfer size amount of data for this endpoint. This field is decremented every time a packet (maximum size or short packet) is written to the Rx FIFO.
    $1d constant OTG_RXDPID                     \ [0x1d : 2] Received data PID Applies to isochronous OUT endpoints only. Control OUT endpoints only description is defined at the next paragraph. This is the data PID received in the last packet for this endpoint.
  [then]


  [ifdef] OTG_OTG_DOEPDMA3_DEF
    \
    \ @brief DMA Address This field holds the start address in the external memory from which the data for the endpoint must be fetched. This register is incremented on every AHB transaction.
    \ Address offset: 0xB74
    \ Reset value: 0x00000000
    \
    $00 constant OTG_DMAADDR                    \ [0x00 : 32] DMA Address This field holds the start address in the external memory from which the data for the endpoint must be fetched. This register is incremented on every AHB transaction.
  [then]


  [ifdef] OTG_OTG_DOEPCTL4_DEF
    \
    \ @brief OTG device OUT endpoint 4 control register
    \ Address offset: 0xB80
    \ Reset value: 0x00000000
    \
    $00 constant OTG_MPSIZ                      \ [0x00 : 11] Maximum packet size The application must program this field with the maximum packet size for the current logical endpoint. This value is in bytes.
    $0f constant OTG_USBAEP                     \ [0x0f] USB active endpoint Indicates whether this endpoint is active in the current configuration and interface. The core clears this bit for all endpoints (other than EP 0) after detecting a USB reset. After receiving the SetConfiguration and SetInterface commands, the application must program endpoint registers accordingly and set this bit.
    $10 constant OTG_DPID                       \ [0x10] Endpoint data PID Applies to interrupt/bulk OUT endpoints only. Contains the PID of the packet to be received or transmitted on this endpoint. The application must program the PID of the first packet to be received or transmitted on this endpoint, after the endpoint is activated. The application uses the SD0PID register field to program either DATA0 or DATA1 PID.
    $11 constant OTG_NAKSTS                     \ [0x11] NAK status Indicates the following: When either the application or the core sets this bit: The core stops receiving any data on an OUT endpoint, even if there is space in the Rx FIFO to accommodate the incoming packet. Irrespective of this bit's setting, the core always responds to SETUP data packets with an ACK handshake.
    $12 constant OTG_EPTYP                      \ [0x12 : 2] Endpoint type This is the transfer type supported by this logical endpoint.
    $14 constant OTG_SNPM                       \ [0x14] Snoop mode This bit configures the endpoint to Snoop mode. In Snoop mode, the core does not check the correctness of OUT packets before transferring them to application memory.
    $15 constant OTG_STALL                      \ [0x15] STALL handshake Applies to non-control, non-isochronous OUT endpoints only (access type is rw). The application sets this bit to stall all tokens from the USB host to this endpoint. If a NAK bit, Global IN NAK, or Global OUT NAK is set along with this bit, the STALL bit takes priority. Only the application can clear this bit, never the core. Applies to control endpoints only (access type is rs). The application can only set this bit, and the core clears it, when a SETUP token is received for this endpoint. If a NAK bit, Global IN NAK, or Global OUT NAK is set along with this bit, the STALL bit takes priority. Irrespective of this bit's setting, the core always responds to SETUP data packets with an ACK handshake.
    $1a constant OTG_CNAK                       \ [0x1a] Clear NAK A write to this bit clears the NAK bit for the endpoint.
    $1b constant OTG_SNAK                       \ [0x1b] Set NAK A write to this bit sets the NAK bit for the endpoint. Using this bit, the application can control the transmission of NAK handshakes on an endpoint. The core can also set this bit for OUT endpoints on a transfer completed interrupt, or after a SETUP is received on the endpoint.
    $1c constant OTG_SD0PID                     \ [0x1c] Set DATA0 PID Applies to interrupt/bulk OUT endpoints only. Writing to this field sets the endpoint data PID (DPID) field in this register to DATA0.
    $1d constant OTG_SD1PID                     \ [0x1d] Set DATA1 PID Applies to interrupt/bulk IN and OUT endpoints only. Writing to this field sets the endpoint data PID (DPID) field in this register to DATA1.
    $1e constant OTG_EPDIS                      \ [0x1e] Endpoint disable The application sets this bit to stop transmitting/receiving data on an endpoint, even before the transfer for that endpoint is complete. The application must wait for the endpoint disabled interrupt before treating the endpoint as disabled. The core clears this bit before setting the endpoint disabled interrupt. The application must set this bit only if endpoint enable is already set for this endpoint.
    $1f constant OTG_EPENA                      \ [0x1f] Endpoint enable Applies to IN and OUT endpoints. The application sets this bit to start transmitting data on an endpoint. The core clears this bit before setting any of the following interrupts on this endpoint: SETUP phase done Endpoint disabled Transfer completed
  [then]


  [ifdef] OTG_OTG_DOEPINT4_DEF
    \
    \ @brief OTG device OUT endpoint 4 interrupt register
    \ Address offset: 0xB88
    \ Reset value: 0x00000080
    \
    $00 constant OTG_XFRC                       \ [0x00] Transfer completed interrupt This field indicates that the programmed transfer is complete on the AHB as well as on the USB, for this endpoint.
    $01 constant OTG_EPDISD                     \ [0x01] Endpoint disabled interrupt This bit indicates that the endpoint is disabled per the application's request.
    $02 constant OTG_AHBERR                     \ [0x02] AHB error This is generated only in internal DMA mode when there is an AHB error during an AHB read/write. The application can read the corresponding endpoint DMA address register to get the error address.
    $03 constant OTG_STUP                       \ [0x03] SETUP phase done Applies to control OUT endpoint only.Indicates that the SETUP phase for the control endpoint is complete and no more back-to-back SETUP packets were received for the current control transfer. On this interrupt, the application can decode the received SETUP data packet.
    $04 constant OTG_OTEPDIS                    \ [0x04] OUT token received when endpoint disabled Applies only to control OUT endpoints. Indicates that an OUT token was received when the endpoint was not yet enabled. This interrupt is asserted on the endpoint for which the OUT token was received.
    $05 constant OTG_STSPHSRX                   \ [0x05] Status phase received for control write This interrupt is valid only for control OUT endpoints. This interrupt is generated only after OTG has transferred all the data that the host has sent during the data phase of a control write transfer, to the system memory buffer. The interrupt indicates to the application that the host has switched from data phase to the status phase of a control write transfer. The application can use this interrupt to ACK or STALL the status phase, after it has decoded the data phase.
    $06 constant OTG_B2BSTUP                    \ [0x06] Back-to-back SETUP packets received Applies to control OUT endpoint only. This bit indicates that the core has received more than three back-to-back SETUP packets for this particular endpoint.
    $08 constant OTG_OUTPKTERR                  \ [0x08] OUT packet error This interrupt is asserted when the core detects an overflow or a CRC error for an OUT packet. This interrupt is valid only when thresholding is enabled.
    $09 constant OTG_BNA                        \ [0x09] Buffer not available interrupt The core generates this interrupt when the descriptor accessed is not ready for the core to process, such as host busy or DMA done. This bit is only valid when Scatter/Gather DMA mode is enabled.
    $0c constant OTG_BERR                       \ [0x0c] Babble error interrupt The core generates this interrupt when babble is received for the endpoint.
    $0d constant OTG_NAK                        \ [0x0d] NAK input The core generates this interrupt when a NAK is transmitted or received by the device. In case of isochronous IN endpoints the interrupt gets generated when a zero length packet is transmitted due to unavailability of data in the Tx FIFO.
    $0e constant OTG_NYET                       \ [0x0e] NYET interrupt This interrupt is generated when a NYET response is transmitted for a non isochronous OUT endpoint.
    $0f constant OTG_STPKTRX                    \ [0x0f] Setup packet received Applicable for control OUT endpoints in only in the Buffer DMA Mode. Set by the OTG, this bit indicates that this buffer holds 8 bytes of setup data. There is only one setup packet per buffer. On receiving a setup packet, the OTG closes the buffer and disables the corresponding endpoint after SETUP_COMPLETE status is seen in the Rx FIFO. OTG puts a SETUP_COMPLETE status into the Rx FIFO when it sees the first IN or OUT token after the SETUP packet for that particular endpoint. The application must then re-enable the endpoint to receive any OUT data for the control transfer and reprogram the buffer start address. Because of the above behavior, OTG can receive any number of back to back setup packets and one buffer for every setup packet is used.
  [then]


  [ifdef] OTG_OTG_DOEPTSIZ4_DEF
    \
    \ @brief OTG device OUT endpoint 4 transfer size register
    \ Address offset: 0xB90
    \ Reset value: 0x00000000
    \
    $00 constant OTG_XFRSIZ                     \ [0x00 : 19] Transfer size This field contains the transfer size in bytes for the current endpoint. The core only interrupts the application after it has exhausted the transfer size amount of data. The transfer size can be set to the maximum packet size of the endpoint, to be interrupted at the end of each packet. The core decrements this field every time a packet is read from the Rx FIFO and written to the external memory.
    $13 constant OTG_PKTCNT                     \ [0x13 : 10] Packet count Indicates the total number of USB packets that constitute the transfer size amount of data for this endpoint. This field is decremented every time a packet (maximum size or short packet) is written to the Rx FIFO.
    $1d constant OTG_RXDPID                     \ [0x1d : 2] Received data PID Applies to isochronous OUT endpoints only. Control OUT endpoints only description is defined at the next paragraph. This is the data PID received in the last packet for this endpoint.
  [then]


  [ifdef] OTG_OTG_DOEPDMA4_DEF
    \
    \ @brief DMA Address This field holds the start address in the external memory from which the data for the endpoint must be fetched. This register is incremented on every AHB transaction.
    \ Address offset: 0xB94
    \ Reset value: 0x00000000
    \
    $00 constant OTG_DMAADDR                    \ [0x00 : 32] DMA Address This field holds the start address in the external memory from which the data for the endpoint must be fetched. This register is incremented on every AHB transaction.
  [then]


  [ifdef] OTG_OTG_DOEPCTL5_DEF
    \
    \ @brief OTG device OUT endpoint 5 control register
    \ Address offset: 0xBA0
    \ Reset value: 0x00000000
    \
    $00 constant OTG_MPSIZ                      \ [0x00 : 11] Maximum packet size The application must program this field with the maximum packet size for the current logical endpoint. This value is in bytes.
    $0f constant OTG_USBAEP                     \ [0x0f] USB active endpoint Indicates whether this endpoint is active in the current configuration and interface. The core clears this bit for all endpoints (other than EP 0) after detecting a USB reset. After receiving the SetConfiguration and SetInterface commands, the application must program endpoint registers accordingly and set this bit.
    $10 constant OTG_DPID                       \ [0x10] Endpoint data PID Applies to interrupt/bulk OUT endpoints only. Contains the PID of the packet to be received or transmitted on this endpoint. The application must program the PID of the first packet to be received or transmitted on this endpoint, after the endpoint is activated. The application uses the SD0PID register field to program either DATA0 or DATA1 PID.
    $11 constant OTG_NAKSTS                     \ [0x11] NAK status Indicates the following: When either the application or the core sets this bit: The core stops receiving any data on an OUT endpoint, even if there is space in the Rx FIFO to accommodate the incoming packet. Irrespective of this bit's setting, the core always responds to SETUP data packets with an ACK handshake.
    $12 constant OTG_EPTYP                      \ [0x12 : 2] Endpoint type This is the transfer type supported by this logical endpoint.
    $14 constant OTG_SNPM                       \ [0x14] Snoop mode This bit configures the endpoint to Snoop mode. In Snoop mode, the core does not check the correctness of OUT packets before transferring them to application memory.
    $15 constant OTG_STALL                      \ [0x15] STALL handshake Applies to non-control, non-isochronous OUT endpoints only (access type is rw). The application sets this bit to stall all tokens from the USB host to this endpoint. If a NAK bit, Global IN NAK, or Global OUT NAK is set along with this bit, the STALL bit takes priority. Only the application can clear this bit, never the core. Applies to control endpoints only (access type is rs). The application can only set this bit, and the core clears it, when a SETUP token is received for this endpoint. If a NAK bit, Global IN NAK, or Global OUT NAK is set along with this bit, the STALL bit takes priority. Irrespective of this bit's setting, the core always responds to SETUP data packets with an ACK handshake.
    $1a constant OTG_CNAK                       \ [0x1a] Clear NAK A write to this bit clears the NAK bit for the endpoint.
    $1b constant OTG_SNAK                       \ [0x1b] Set NAK A write to this bit sets the NAK bit for the endpoint. Using this bit, the application can control the transmission of NAK handshakes on an endpoint. The core can also set this bit for OUT endpoints on a transfer completed interrupt, or after a SETUP is received on the endpoint.
    $1c constant OTG_SD0PID                     \ [0x1c] Set DATA0 PID Applies to interrupt/bulk OUT endpoints only. Writing to this field sets the endpoint data PID (DPID) field in this register to DATA0.
    $1d constant OTG_SD1PID                     \ [0x1d] Set DATA1 PID Applies to interrupt/bulk IN and OUT endpoints only. Writing to this field sets the endpoint data PID (DPID) field in this register to DATA1.
    $1e constant OTG_EPDIS                      \ [0x1e] Endpoint disable The application sets this bit to stop transmitting/receiving data on an endpoint, even before the transfer for that endpoint is complete. The application must wait for the endpoint disabled interrupt before treating the endpoint as disabled. The core clears this bit before setting the endpoint disabled interrupt. The application must set this bit only if endpoint enable is already set for this endpoint.
    $1f constant OTG_EPENA                      \ [0x1f] Endpoint enable Applies to IN and OUT endpoints. The application sets this bit to start transmitting data on an endpoint. The core clears this bit before setting any of the following interrupts on this endpoint: SETUP phase done Endpoint disabled Transfer completed
  [then]


  [ifdef] OTG_OTG_DOEPINT5_DEF
    \
    \ @brief OTG device OUT endpoint 5 interrupt register
    \ Address offset: 0xBA8
    \ Reset value: 0x00000080
    \
    $00 constant OTG_XFRC                       \ [0x00] Transfer completed interrupt This field indicates that the programmed transfer is complete on the AHB as well as on the USB, for this endpoint.
    $01 constant OTG_EPDISD                     \ [0x01] Endpoint disabled interrupt This bit indicates that the endpoint is disabled per the application's request.
    $02 constant OTG_AHBERR                     \ [0x02] AHB error This is generated only in internal DMA mode when there is an AHB error during an AHB read/write. The application can read the corresponding endpoint DMA address register to get the error address.
    $03 constant OTG_STUP                       \ [0x03] SETUP phase done Applies to control OUT endpoint only.Indicates that the SETUP phase for the control endpoint is complete and no more back-to-back SETUP packets were received for the current control transfer. On this interrupt, the application can decode the received SETUP data packet.
    $04 constant OTG_OTEPDIS                    \ [0x04] OUT token received when endpoint disabled Applies only to control OUT endpoints. Indicates that an OUT token was received when the endpoint was not yet enabled. This interrupt is asserted on the endpoint for which the OUT token was received.
    $05 constant OTG_STSPHSRX                   \ [0x05] Status phase received for control write This interrupt is valid only for control OUT endpoints. This interrupt is generated only after OTG has transferred all the data that the host has sent during the data phase of a control write transfer, to the system memory buffer. The interrupt indicates to the application that the host has switched from data phase to the status phase of a control write transfer. The application can use this interrupt to ACK or STALL the status phase, after it has decoded the data phase.
    $06 constant OTG_B2BSTUP                    \ [0x06] Back-to-back SETUP packets received Applies to control OUT endpoint only. This bit indicates that the core has received more than three back-to-back SETUP packets for this particular endpoint.
    $08 constant OTG_OUTPKTERR                  \ [0x08] OUT packet error This interrupt is asserted when the core detects an overflow or a CRC error for an OUT packet. This interrupt is valid only when thresholding is enabled.
    $09 constant OTG_BNA                        \ [0x09] Buffer not available interrupt The core generates this interrupt when the descriptor accessed is not ready for the core to process, such as host busy or DMA done. This bit is only valid when Scatter/Gather DMA mode is enabled.
    $0c constant OTG_BERR                       \ [0x0c] Babble error interrupt The core generates this interrupt when babble is received for the endpoint.
    $0d constant OTG_NAK                        \ [0x0d] NAK input The core generates this interrupt when a NAK is transmitted or received by the device. In case of isochronous IN endpoints the interrupt gets generated when a zero length packet is transmitted due to unavailability of data in the Tx FIFO.
    $0e constant OTG_NYET                       \ [0x0e] NYET interrupt This interrupt is generated when a NYET response is transmitted for a non isochronous OUT endpoint.
    $0f constant OTG_STPKTRX                    \ [0x0f] Setup packet received Applicable for control OUT endpoints in only in the Buffer DMA Mode. Set by the OTG, this bit indicates that this buffer holds 8 bytes of setup data. There is only one setup packet per buffer. On receiving a setup packet, the OTG closes the buffer and disables the corresponding endpoint after SETUP_COMPLETE status is seen in the Rx FIFO. OTG puts a SETUP_COMPLETE status into the Rx FIFO when it sees the first IN or OUT token after the SETUP packet for that particular endpoint. The application must then re-enable the endpoint to receive any OUT data for the control transfer and reprogram the buffer start address. Because of the above behavior, OTG can receive any number of back to back setup packets and one buffer for every setup packet is used.
  [then]


  [ifdef] OTG_OTG_DOEPTSIZ5_DEF
    \
    \ @brief OTG device OUT endpoint 5 transfer size register
    \ Address offset: 0xBB0
    \ Reset value: 0x00000000
    \
    $00 constant OTG_XFRSIZ                     \ [0x00 : 19] Transfer size This field contains the transfer size in bytes for the current endpoint. The core only interrupts the application after it has exhausted the transfer size amount of data. The transfer size can be set to the maximum packet size of the endpoint, to be interrupted at the end of each packet. The core decrements this field every time a packet is read from the Rx FIFO and written to the external memory.
    $13 constant OTG_PKTCNT                     \ [0x13 : 10] Packet count Indicates the total number of USB packets that constitute the transfer size amount of data for this endpoint. This field is decremented every time a packet (maximum size or short packet) is written to the Rx FIFO.
    $1d constant OTG_RXDPID                     \ [0x1d : 2] Received data PID Applies to isochronous OUT endpoints only. Control OUT endpoints only description is defined at the next paragraph. This is the data PID received in the last packet for this endpoint.
  [then]


  [ifdef] OTG_OTG_DOEPDMA5_DEF
    \
    \ @brief DMA Address This field holds the start address in the external memory from which the data for the endpoint must be fetched. This register is incremented on every AHB transaction.
    \ Address offset: 0xBB4
    \ Reset value: 0x00000000
    \
    $00 constant OTG_DMAADDR                    \ [0x00 : 32] DMA Address This field holds the start address in the external memory from which the data for the endpoint must be fetched. This register is incremented on every AHB transaction.
  [then]


  [ifdef] OTG_OTG_DOEPCTL6_DEF
    \
    \ @brief OTG device OUT endpoint 6 control register
    \ Address offset: 0xBC0
    \ Reset value: 0x00000000
    \
    $00 constant OTG_MPSIZ                      \ [0x00 : 11] Maximum packet size The application must program this field with the maximum packet size for the current logical endpoint. This value is in bytes.
    $0f constant OTG_USBAEP                     \ [0x0f] USB active endpoint Indicates whether this endpoint is active in the current configuration and interface. The core clears this bit for all endpoints (other than EP 0) after detecting a USB reset. After receiving the SetConfiguration and SetInterface commands, the application must program endpoint registers accordingly and set this bit.
    $10 constant OTG_DPID                       \ [0x10] Endpoint data PID Applies to interrupt/bulk OUT endpoints only. Contains the PID of the packet to be received or transmitted on this endpoint. The application must program the PID of the first packet to be received or transmitted on this endpoint, after the endpoint is activated. The application uses the SD0PID register field to program either DATA0 or DATA1 PID.
    $11 constant OTG_NAKSTS                     \ [0x11] NAK status Indicates the following: When either the application or the core sets this bit: The core stops receiving any data on an OUT endpoint, even if there is space in the Rx FIFO to accommodate the incoming packet. Irrespective of this bit's setting, the core always responds to SETUP data packets with an ACK handshake.
    $12 constant OTG_EPTYP                      \ [0x12 : 2] Endpoint type This is the transfer type supported by this logical endpoint.
    $14 constant OTG_SNPM                       \ [0x14] Snoop mode This bit configures the endpoint to Snoop mode. In Snoop mode, the core does not check the correctness of OUT packets before transferring them to application memory.
    $15 constant OTG_STALL                      \ [0x15] STALL handshake Applies to non-control, non-isochronous OUT endpoints only (access type is rw). The application sets this bit to stall all tokens from the USB host to this endpoint. If a NAK bit, Global IN NAK, or Global OUT NAK is set along with this bit, the STALL bit takes priority. Only the application can clear this bit, never the core. Applies to control endpoints only (access type is rs). The application can only set this bit, and the core clears it, when a SETUP token is received for this endpoint. If a NAK bit, Global IN NAK, or Global OUT NAK is set along with this bit, the STALL bit takes priority. Irrespective of this bit's setting, the core always responds to SETUP data packets with an ACK handshake.
    $1a constant OTG_CNAK                       \ [0x1a] Clear NAK A write to this bit clears the NAK bit for the endpoint.
    $1b constant OTG_SNAK                       \ [0x1b] Set NAK A write to this bit sets the NAK bit for the endpoint. Using this bit, the application can control the transmission of NAK handshakes on an endpoint. The core can also set this bit for OUT endpoints on a transfer completed interrupt, or after a SETUP is received on the endpoint.
    $1c constant OTG_SD0PID                     \ [0x1c] Set DATA0 PID Applies to interrupt/bulk OUT endpoints only. Writing to this field sets the endpoint data PID (DPID) field in this register to DATA0.
    $1d constant OTG_SD1PID                     \ [0x1d] Set DATA1 PID Applies to interrupt/bulk IN and OUT endpoints only. Writing to this field sets the endpoint data PID (DPID) field in this register to DATA1.
    $1e constant OTG_EPDIS                      \ [0x1e] Endpoint disable The application sets this bit to stop transmitting/receiving data on an endpoint, even before the transfer for that endpoint is complete. The application must wait for the endpoint disabled interrupt before treating the endpoint as disabled. The core clears this bit before setting the endpoint disabled interrupt. The application must set this bit only if endpoint enable is already set for this endpoint.
    $1f constant OTG_EPENA                      \ [0x1f] Endpoint enable Applies to IN and OUT endpoints. The application sets this bit to start transmitting data on an endpoint. The core clears this bit before setting any of the following interrupts on this endpoint: SETUP phase done Endpoint disabled Transfer completed
  [then]


  [ifdef] OTG_OTG_DOEPINT6_DEF
    \
    \ @brief OTG device OUT endpoint 6 interrupt register
    \ Address offset: 0xBC8
    \ Reset value: 0x00000080
    \
    $00 constant OTG_XFRC                       \ [0x00] Transfer completed interrupt This field indicates that the programmed transfer is complete on the AHB as well as on the USB, for this endpoint.
    $01 constant OTG_EPDISD                     \ [0x01] Endpoint disabled interrupt This bit indicates that the endpoint is disabled per the application's request.
    $02 constant OTG_AHBERR                     \ [0x02] AHB error This is generated only in internal DMA mode when there is an AHB error during an AHB read/write. The application can read the corresponding endpoint DMA address register to get the error address.
    $03 constant OTG_STUP                       \ [0x03] SETUP phase done Applies to control OUT endpoint only.Indicates that the SETUP phase for the control endpoint is complete and no more back-to-back SETUP packets were received for the current control transfer. On this interrupt, the application can decode the received SETUP data packet.
    $04 constant OTG_OTEPDIS                    \ [0x04] OUT token received when endpoint disabled Applies only to control OUT endpoints. Indicates that an OUT token was received when the endpoint was not yet enabled. This interrupt is asserted on the endpoint for which the OUT token was received.
    $05 constant OTG_STSPHSRX                   \ [0x05] Status phase received for control write This interrupt is valid only for control OUT endpoints. This interrupt is generated only after OTG has transferred all the data that the host has sent during the data phase of a control write transfer, to the system memory buffer. The interrupt indicates to the application that the host has switched from data phase to the status phase of a control write transfer. The application can use this interrupt to ACK or STALL the status phase, after it has decoded the data phase.
    $06 constant OTG_B2BSTUP                    \ [0x06] Back-to-back SETUP packets received Applies to control OUT endpoint only. This bit indicates that the core has received more than three back-to-back SETUP packets for this particular endpoint.
    $08 constant OTG_OUTPKTERR                  \ [0x08] OUT packet error This interrupt is asserted when the core detects an overflow or a CRC error for an OUT packet. This interrupt is valid only when thresholding is enabled.
    $09 constant OTG_BNA                        \ [0x09] Buffer not available interrupt The core generates this interrupt when the descriptor accessed is not ready for the core to process, such as host busy or DMA done. This bit is only valid when Scatter/Gather DMA mode is enabled.
    $0c constant OTG_BERR                       \ [0x0c] Babble error interrupt The core generates this interrupt when babble is received for the endpoint.
    $0d constant OTG_NAK                        \ [0x0d] NAK input The core generates this interrupt when a NAK is transmitted or received by the device. In case of isochronous IN endpoints the interrupt gets generated when a zero length packet is transmitted due to unavailability of data in the Tx FIFO.
    $0e constant OTG_NYET                       \ [0x0e] NYET interrupt This interrupt is generated when a NYET response is transmitted for a non isochronous OUT endpoint.
    $0f constant OTG_STPKTRX                    \ [0x0f] Setup packet received Applicable for control OUT endpoints in only in the Buffer DMA Mode. Set by the OTG, this bit indicates that this buffer holds 8 bytes of setup data. There is only one setup packet per buffer. On receiving a setup packet, the OTG closes the buffer and disables the corresponding endpoint after SETUP_COMPLETE status is seen in the Rx FIFO. OTG puts a SETUP_COMPLETE status into the Rx FIFO when it sees the first IN or OUT token after the SETUP packet for that particular endpoint. The application must then re-enable the endpoint to receive any OUT data for the control transfer and reprogram the buffer start address. Because of the above behavior, OTG can receive any number of back to back setup packets and one buffer for every setup packet is used.
  [then]


  [ifdef] OTG_OTG_DOEPTSIZ6_DEF
    \
    \ @brief OTG device OUT endpoint 6 transfer size register
    \ Address offset: 0xBD0
    \ Reset value: 0x00000000
    \
    $00 constant OTG_XFRSIZ                     \ [0x00 : 19] Transfer size This field contains the transfer size in bytes for the current endpoint. The core only interrupts the application after it has exhausted the transfer size amount of data. The transfer size can be set to the maximum packet size of the endpoint, to be interrupted at the end of each packet. The core decrements this field every time a packet is read from the Rx FIFO and written to the external memory.
    $13 constant OTG_PKTCNT                     \ [0x13 : 10] Packet count Indicates the total number of USB packets that constitute the transfer size amount of data for this endpoint. This field is decremented every time a packet (maximum size or short packet) is written to the Rx FIFO.
    $1d constant OTG_RXDPID                     \ [0x1d : 2] Received data PID Applies to isochronous OUT endpoints only. Control OUT endpoints only description is defined at the next paragraph. This is the data PID received in the last packet for this endpoint.
  [then]


  [ifdef] OTG_OTG_DOEPDMA6_DEF
    \
    \ @brief DMA Address This field holds the start address in the external memory from which the data for the endpoint must be fetched. This register is incremented on every AHB transaction.
    \ Address offset: 0xBD4
    \ Reset value: 0x00000000
    \
    $00 constant OTG_DMAADDR                    \ [0x00 : 32] DMA Address This field holds the start address in the external memory from which the data for the endpoint must be fetched. This register is incremented on every AHB transaction.
  [then]


  [ifdef] OTG_OTG_DOEPCTL7_DEF
    \
    \ @brief OTG device OUT endpoint 7 control register
    \ Address offset: 0xBE0
    \ Reset value: 0x00000000
    \
    $00 constant OTG_MPSIZ                      \ [0x00 : 11] Maximum packet size The application must program this field with the maximum packet size for the current logical endpoint. This value is in bytes.
    $0f constant OTG_USBAEP                     \ [0x0f] USB active endpoint Indicates whether this endpoint is active in the current configuration and interface. The core clears this bit for all endpoints (other than EP 0) after detecting a USB reset. After receiving the SetConfiguration and SetInterface commands, the application must program endpoint registers accordingly and set this bit.
    $10 constant OTG_DPID                       \ [0x10] Endpoint data PID Applies to interrupt/bulk OUT endpoints only. Contains the PID of the packet to be received or transmitted on this endpoint. The application must program the PID of the first packet to be received or transmitted on this endpoint, after the endpoint is activated. The application uses the SD0PID register field to program either DATA0 or DATA1 PID.
    $11 constant OTG_NAKSTS                     \ [0x11] NAK status Indicates the following: When either the application or the core sets this bit: The core stops receiving any data on an OUT endpoint, even if there is space in the Rx FIFO to accommodate the incoming packet. Irrespective of this bit's setting, the core always responds to SETUP data packets with an ACK handshake.
    $12 constant OTG_EPTYP                      \ [0x12 : 2] Endpoint type This is the transfer type supported by this logical endpoint.
    $14 constant OTG_SNPM                       \ [0x14] Snoop mode This bit configures the endpoint to Snoop mode. In Snoop mode, the core does not check the correctness of OUT packets before transferring them to application memory.
    $15 constant OTG_STALL                      \ [0x15] STALL handshake Applies to non-control, non-isochronous OUT endpoints only (access type is rw). The application sets this bit to stall all tokens from the USB host to this endpoint. If a NAK bit, Global IN NAK, or Global OUT NAK is set along with this bit, the STALL bit takes priority. Only the application can clear this bit, never the core. Applies to control endpoints only (access type is rs). The application can only set this bit, and the core clears it, when a SETUP token is received for this endpoint. If a NAK bit, Global IN NAK, or Global OUT NAK is set along with this bit, the STALL bit takes priority. Irrespective of this bit's setting, the core always responds to SETUP data packets with an ACK handshake.
    $1a constant OTG_CNAK                       \ [0x1a] Clear NAK A write to this bit clears the NAK bit for the endpoint.
    $1b constant OTG_SNAK                       \ [0x1b] Set NAK A write to this bit sets the NAK bit for the endpoint. Using this bit, the application can control the transmission of NAK handshakes on an endpoint. The core can also set this bit for OUT endpoints on a transfer completed interrupt, or after a SETUP is received on the endpoint.
    $1c constant OTG_SD0PID                     \ [0x1c] Set DATA0 PID Applies to interrupt/bulk OUT endpoints only. Writing to this field sets the endpoint data PID (DPID) field in this register to DATA0.
    $1d constant OTG_SD1PID                     \ [0x1d] Set DATA1 PID Applies to interrupt/bulk IN and OUT endpoints only. Writing to this field sets the endpoint data PID (DPID) field in this register to DATA1.
    $1e constant OTG_EPDIS                      \ [0x1e] Endpoint disable The application sets this bit to stop transmitting/receiving data on an endpoint, even before the transfer for that endpoint is complete. The application must wait for the endpoint disabled interrupt before treating the endpoint as disabled. The core clears this bit before setting the endpoint disabled interrupt. The application must set this bit only if endpoint enable is already set for this endpoint.
    $1f constant OTG_EPENA                      \ [0x1f] Endpoint enable Applies to IN and OUT endpoints. The application sets this bit to start transmitting data on an endpoint. The core clears this bit before setting any of the following interrupts on this endpoint: SETUP phase done Endpoint disabled Transfer completed
  [then]


  [ifdef] OTG_OTG_DOEPINT7_DEF
    \
    \ @brief OTG device OUT endpoint 7 interrupt register
    \ Address offset: 0xBE8
    \ Reset value: 0x00000080
    \
    $00 constant OTG_XFRC                       \ [0x00] Transfer completed interrupt This field indicates that the programmed transfer is complete on the AHB as well as on the USB, for this endpoint.
    $01 constant OTG_EPDISD                     \ [0x01] Endpoint disabled interrupt This bit indicates that the endpoint is disabled per the application's request.
    $02 constant OTG_AHBERR                     \ [0x02] AHB error This is generated only in internal DMA mode when there is an AHB error during an AHB read/write. The application can read the corresponding endpoint DMA address register to get the error address.
    $03 constant OTG_STUP                       \ [0x03] SETUP phase done Applies to control OUT endpoint only.Indicates that the SETUP phase for the control endpoint is complete and no more back-to-back SETUP packets were received for the current control transfer. On this interrupt, the application can decode the received SETUP data packet.
    $04 constant OTG_OTEPDIS                    \ [0x04] OUT token received when endpoint disabled Applies only to control OUT endpoints. Indicates that an OUT token was received when the endpoint was not yet enabled. This interrupt is asserted on the endpoint for which the OUT token was received.
    $05 constant OTG_STSPHSRX                   \ [0x05] Status phase received for control write This interrupt is valid only for control OUT endpoints. This interrupt is generated only after OTG has transferred all the data that the host has sent during the data phase of a control write transfer, to the system memory buffer. The interrupt indicates to the application that the host has switched from data phase to the status phase of a control write transfer. The application can use this interrupt to ACK or STALL the status phase, after it has decoded the data phase.
    $06 constant OTG_B2BSTUP                    \ [0x06] Back-to-back SETUP packets received Applies to control OUT endpoint only. This bit indicates that the core has received more than three back-to-back SETUP packets for this particular endpoint.
    $08 constant OTG_OUTPKTERR                  \ [0x08] OUT packet error This interrupt is asserted when the core detects an overflow or a CRC error for an OUT packet. This interrupt is valid only when thresholding is enabled.
    $09 constant OTG_BNA                        \ [0x09] Buffer not available interrupt The core generates this interrupt when the descriptor accessed is not ready for the core to process, such as host busy or DMA done. This bit is only valid when Scatter/Gather DMA mode is enabled.
    $0c constant OTG_BERR                       \ [0x0c] Babble error interrupt The core generates this interrupt when babble is received for the endpoint.
    $0d constant OTG_NAK                        \ [0x0d] NAK input The core generates this interrupt when a NAK is transmitted or received by the device. In case of isochronous IN endpoints the interrupt gets generated when a zero length packet is transmitted due to unavailability of data in the Tx FIFO.
    $0e constant OTG_NYET                       \ [0x0e] NYET interrupt This interrupt is generated when a NYET response is transmitted for a non isochronous OUT endpoint.
    $0f constant OTG_STPKTRX                    \ [0x0f] Setup packet received Applicable for control OUT endpoints in only in the Buffer DMA Mode. Set by the OTG, this bit indicates that this buffer holds 8 bytes of setup data. There is only one setup packet per buffer. On receiving a setup packet, the OTG closes the buffer and disables the corresponding endpoint after SETUP_COMPLETE status is seen in the Rx FIFO. OTG puts a SETUP_COMPLETE status into the Rx FIFO when it sees the first IN or OUT token after the SETUP packet for that particular endpoint. The application must then re-enable the endpoint to receive any OUT data for the control transfer and reprogram the buffer start address. Because of the above behavior, OTG can receive any number of back to back setup packets and one buffer for every setup packet is used.
  [then]


  [ifdef] OTG_OTG_DOEPTSIZ7_DEF
    \
    \ @brief OTG device OUT endpoint 7 transfer size register
    \ Address offset: 0xBF0
    \ Reset value: 0x00000000
    \
    $00 constant OTG_XFRSIZ                     \ [0x00 : 19] Transfer size This field contains the transfer size in bytes for the current endpoint. The core only interrupts the application after it has exhausted the transfer size amount of data. The transfer size can be set to the maximum packet size of the endpoint, to be interrupted at the end of each packet. The core decrements this field every time a packet is read from the Rx FIFO and written to the external memory.
    $13 constant OTG_PKTCNT                     \ [0x13 : 10] Packet count Indicates the total number of USB packets that constitute the transfer size amount of data for this endpoint. This field is decremented every time a packet (maximum size or short packet) is written to the Rx FIFO.
    $1d constant OTG_RXDPID                     \ [0x1d : 2] Received data PID Applies to isochronous OUT endpoints only. Control OUT endpoints only description is defined at the next paragraph. This is the data PID received in the last packet for this endpoint.
  [then]


  [ifdef] OTG_OTG_DOEPDMA7_DEF
    \
    \ @brief DMA Address This field holds the start address in the external memory from which the data for the endpoint must be fetched. This register is incremented on every AHB transaction.
    \ Address offset: 0xBF4
    \ Reset value: 0x00000000
    \
    $00 constant OTG_DMAADDR                    \ [0x00 : 32] DMA Address This field holds the start address in the external memory from which the data for the endpoint must be fetched. This register is incremented on every AHB transaction.
  [then]


  [ifdef] OTG_OTG_DOEPCTL8_DEF
    \
    \ @brief OTG device OUT endpoint 8 control register
    \ Address offset: 0xC00
    \ Reset value: 0x00000000
    \
    $00 constant OTG_MPSIZ                      \ [0x00 : 11] Maximum packet size The application must program this field with the maximum packet size for the current logical endpoint. This value is in bytes.
    $0f constant OTG_USBAEP                     \ [0x0f] USB active endpoint Indicates whether this endpoint is active in the current configuration and interface. The core clears this bit for all endpoints (other than EP 0) after detecting a USB reset. After receiving the SetConfiguration and SetInterface commands, the application must program endpoint registers accordingly and set this bit.
    $10 constant OTG_DPID                       \ [0x10] Endpoint data PID Applies to interrupt/bulk OUT endpoints only. Contains the PID of the packet to be received or transmitted on this endpoint. The application must program the PID of the first packet to be received or transmitted on this endpoint, after the endpoint is activated. The application uses the SD0PID register field to program either DATA0 or DATA1 PID.
    $11 constant OTG_NAKSTS                     \ [0x11] NAK status Indicates the following: When either the application or the core sets this bit: The core stops receiving any data on an OUT endpoint, even if there is space in the Rx FIFO to accommodate the incoming packet. Irrespective of this bit's setting, the core always responds to SETUP data packets with an ACK handshake.
    $12 constant OTG_EPTYP                      \ [0x12 : 2] Endpoint type This is the transfer type supported by this logical endpoint.
    $14 constant OTG_SNPM                       \ [0x14] Snoop mode This bit configures the endpoint to Snoop mode. In Snoop mode, the core does not check the correctness of OUT packets before transferring them to application memory.
    $15 constant OTG_STALL                      \ [0x15] STALL handshake Applies to non-control, non-isochronous OUT endpoints only (access type is rw). The application sets this bit to stall all tokens from the USB host to this endpoint. If a NAK bit, Global IN NAK, or Global OUT NAK is set along with this bit, the STALL bit takes priority. Only the application can clear this bit, never the core. Applies to control endpoints only (access type is rs). The application can only set this bit, and the core clears it, when a SETUP token is received for this endpoint. If a NAK bit, Global IN NAK, or Global OUT NAK is set along with this bit, the STALL bit takes priority. Irrespective of this bit's setting, the core always responds to SETUP data packets with an ACK handshake.
    $1a constant OTG_CNAK                       \ [0x1a] Clear NAK A write to this bit clears the NAK bit for the endpoint.
    $1b constant OTG_SNAK                       \ [0x1b] Set NAK A write to this bit sets the NAK bit for the endpoint. Using this bit, the application can control the transmission of NAK handshakes on an endpoint. The core can also set this bit for OUT endpoints on a transfer completed interrupt, or after a SETUP is received on the endpoint.
    $1c constant OTG_SD0PID                     \ [0x1c] Set DATA0 PID Applies to interrupt/bulk OUT endpoints only. Writing to this field sets the endpoint data PID (DPID) field in this register to DATA0.
    $1d constant OTG_SD1PID                     \ [0x1d] Set DATA1 PID Applies to interrupt/bulk IN and OUT endpoints only. Writing to this field sets the endpoint data PID (DPID) field in this register to DATA1.
    $1e constant OTG_EPDIS                      \ [0x1e] Endpoint disable The application sets this bit to stop transmitting/receiving data on an endpoint, even before the transfer for that endpoint is complete. The application must wait for the endpoint disabled interrupt before treating the endpoint as disabled. The core clears this bit before setting the endpoint disabled interrupt. The application must set this bit only if endpoint enable is already set for this endpoint.
    $1f constant OTG_EPENA                      \ [0x1f] Endpoint enable Applies to IN and OUT endpoints. The application sets this bit to start transmitting data on an endpoint. The core clears this bit before setting any of the following interrupts on this endpoint: SETUP phase done Endpoint disabled Transfer completed
  [then]


  [ifdef] OTG_OTG_DOEPINT8_DEF
    \
    \ @brief OTG device OUT endpoint 8 interrupt register
    \ Address offset: 0xC08
    \ Reset value: 0x00000080
    \
    $00 constant OTG_XFRC                       \ [0x00] Transfer completed interrupt This field indicates that the programmed transfer is complete on the AHB as well as on the USB, for this endpoint.
    $01 constant OTG_EPDISD                     \ [0x01] Endpoint disabled interrupt This bit indicates that the endpoint is disabled per the application's request.
    $02 constant OTG_AHBERR                     \ [0x02] AHB error This is generated only in internal DMA mode when there is an AHB error during an AHB read/write. The application can read the corresponding endpoint DMA address register to get the error address.
    $03 constant OTG_STUP                       \ [0x03] SETUP phase done Applies to control OUT endpoint only.Indicates that the SETUP phase for the control endpoint is complete and no more back-to-back SETUP packets were received for the current control transfer. On this interrupt, the application can decode the received SETUP data packet.
    $04 constant OTG_OTEPDIS                    \ [0x04] OUT token received when endpoint disabled Applies only to control OUT endpoints. Indicates that an OUT token was received when the endpoint was not yet enabled. This interrupt is asserted on the endpoint for which the OUT token was received.
    $05 constant OTG_STSPHSRX                   \ [0x05] Status phase received for control write This interrupt is valid only for control OUT endpoints. This interrupt is generated only after OTG has transferred all the data that the host has sent during the data phase of a control write transfer, to the system memory buffer. The interrupt indicates to the application that the host has switched from data phase to the status phase of a control write transfer. The application can use this interrupt to ACK or STALL the status phase, after it has decoded the data phase.
    $06 constant OTG_B2BSTUP                    \ [0x06] Back-to-back SETUP packets received Applies to control OUT endpoint only. This bit indicates that the core has received more than three back-to-back SETUP packets for this particular endpoint.
    $08 constant OTG_OUTPKTERR                  \ [0x08] OUT packet error This interrupt is asserted when the core detects an overflow or a CRC error for an OUT packet. This interrupt is valid only when thresholding is enabled.
    $09 constant OTG_BNA                        \ [0x09] Buffer not available interrupt The core generates this interrupt when the descriptor accessed is not ready for the core to process, such as host busy or DMA done. This bit is only valid when Scatter/Gather DMA mode is enabled.
    $0c constant OTG_BERR                       \ [0x0c] Babble error interrupt The core generates this interrupt when babble is received for the endpoint.
    $0d constant OTG_NAK                        \ [0x0d] NAK input The core generates this interrupt when a NAK is transmitted or received by the device. In case of isochronous IN endpoints the interrupt gets generated when a zero length packet is transmitted due to unavailability of data in the Tx FIFO.
    $0e constant OTG_NYET                       \ [0x0e] NYET interrupt This interrupt is generated when a NYET response is transmitted for a non isochronous OUT endpoint.
    $0f constant OTG_STPKTRX                    \ [0x0f] Setup packet received Applicable for control OUT endpoints in only in the Buffer DMA Mode. Set by the OTG, this bit indicates that this buffer holds 8 bytes of setup data. There is only one setup packet per buffer. On receiving a setup packet, the OTG closes the buffer and disables the corresponding endpoint after SETUP_COMPLETE status is seen in the Rx FIFO. OTG puts a SETUP_COMPLETE status into the Rx FIFO when it sees the first IN or OUT token after the SETUP packet for that particular endpoint. The application must then re-enable the endpoint to receive any OUT data for the control transfer and reprogram the buffer start address. Because of the above behavior, OTG can receive any number of back to back setup packets and one buffer for every setup packet is used.
  [then]


  [ifdef] OTG_OTG_DOEPTSIZ8_DEF
    \
    \ @brief OTG device OUT endpoint 8 transfer size register
    \ Address offset: 0xC10
    \ Reset value: 0x00000000
    \
    $00 constant OTG_XFRSIZ                     \ [0x00 : 19] Transfer size This field contains the transfer size in bytes for the current endpoint. The core only interrupts the application after it has exhausted the transfer size amount of data. The transfer size can be set to the maximum packet size of the endpoint, to be interrupted at the end of each packet. The core decrements this field every time a packet is read from the Rx FIFO and written to the external memory.
    $13 constant OTG_PKTCNT                     \ [0x13 : 10] Packet count Indicates the total number of USB packets that constitute the transfer size amount of data for this endpoint. This field is decremented every time a packet (maximum size or short packet) is written to the Rx FIFO.
    $1d constant OTG_RXDPID                     \ [0x1d : 2] Received data PID Applies to isochronous OUT endpoints only. Control OUT endpoints only description is defined at the next paragraph. This is the data PID received in the last packet for this endpoint.
  [then]


  [ifdef] OTG_OTG_DOEPDMA8_DEF
    \
    \ @brief DMA Address This field holds the start address in the external memory from which the data for the endpoint must be fetched. This register is incremented on every AHB transaction.
    \ Address offset: 0xC14
    \ Reset value: 0x00000000
    \
    $00 constant OTG_DMAADDR                    \ [0x00 : 32] DMA Address This field holds the start address in the external memory from which the data for the endpoint must be fetched. This register is incremented on every AHB transaction.
  [then]


  [ifdef] OTG_OTG_PCGCCTL_DEF
    \
    \ @brief OTG power and clock gating control register
    \ Address offset: 0xE00
    \ Reset value: 0x200B8000
    \
    $00 constant OTG_STPPCLK                    \ [0x00] Stop PHY clock The application sets this bit to stop the PHY clock when the USB is suspended, the session is not valid, or the device is disconnected. The application clears this bit when the USB is resumed or a new session starts.
    $01 constant OTG_GATEHCLK                   \ [0x01] Gate HCLK The application sets this bit to gate HCLK to modules other than the AHB Slave and Master and wakeup logic when the USB is suspended or the session is not valid. The application clears this bit when the USB is resumed or a new session starts.
    $04 constant OTG_PHYSUSP                    \ [0x04] PHY suspended Indicates that the PHY has been suspended. This bit is updated once the PHY is suspended after the application has set the STPPCLK bit.
    $05 constant OTG_ENL1GTG                    \ [0x05] Enable sleep clock gating When this bit is set, core internal clock gating is enabled in Sleep state if the core cannot assert utmi_l1_suspend_n. When this bit is not set, the PHY clock is not gated in Sleep state.
    $06 constant OTG_PHYSLEEP                   \ [0x06] PHY in Sleep This bit indicates that the PHY is in the Sleep state.
    $07 constant OTG_SUSP                       \ [0x07] Deep Sleep This bit indicates that the PHY is in Deep Sleep when in L1 state.
  [then]

  \
  \ @brief OTG
  \
  $00 constant OTG_OTG_GOTGCTL          \ OTG control and status register
  $04 constant OTG_OTG_GOTGINT          \ OTG interrupt register
  $08 constant OTG_OTG_GAHBCFG          \ OTG AHB configuration register
  $0C constant OTG_OTG_GUSBCFG          \ OTG USB configuration register
  $10 constant OTG_OTG_GRSTCTL          \ OTG reset register
  $14 constant OTG_OTG_GINTSTS          \ OTG core interrupt register
  $18 constant OTG_OTG_GINTMSK          \ OTG interrupt mask register
  $1C constant OTG_OTG_GRXSTSR          \ OTG receive status debug read register
  $20 constant OTG_OTG_GRXSTSP          \ OTG status read and pop register
  $24 constant OTG_OTG_GRXFSIZ          \ OTG receive FIFO size register
  $28 constant OTG_OTG_HNPTXFSIZ        \ OTG host non-periodic transmit FIFO size register
  $2C constant OTG_OTG_HNPTXSTS         \ OTG non-periodic transmit FIFO/queue status register
  $38 constant OTG_OTG_GCCFG            \ USB VBUS detection enable Enables VBUS sensing comparators to detect VBUS valid levels on the VBUS PAD for USB host and device operation. If HNP and/or SRP support is enabled, VBUS comparators are automatically enabled independently of VBDEN value. 0 = VBUS detection disabled 1 = VBUS detection enabled
  $3C constant OTG_OTG_CID              \ OTG core ID register
  $54 constant OTG_OTG_GLPMCFG          \ LPM support enable The application uses this bit to control the OTG core LPM capabilities. If the core operates as a non-LPM-capable host, it cannot request the connected device or hub to activate LPM mode. If the core operates as a non-LPM-capable device, it cannot respond to any LPM transactions.
  $100 constant OTG_OTG_HPTXFSIZ        \ Host periodic Tx FIFO start address This field configures the memory start address for periodic transmit FIFO RAM.
  $104 constant OTG_OTG_DIEPTXF1        \ IN endpoint FIFOx transmit RAM start address This field contains the memory start address for IN endpoint transmit FIFOx. The address must be aligned with a 32-bit memory location.
  $108 constant OTG_OTG_DIEPTXF2        \ IN endpoint FIFOx transmit RAM start address This field contains the memory start address for IN endpoint transmit FIFOx. The address must be aligned with a 32-bit memory location.
  $10C constant OTG_OTG_DIEPTXF3        \ IN endpoint FIFOx transmit RAM start address This field contains the memory start address for IN endpoint transmit FIFOx. The address must be aligned with a 32-bit memory location.
  $110 constant OTG_OTG_DIEPTXF4        \ IN endpoint FIFOx transmit RAM start address This field contains the memory start address for IN endpoint transmit FIFOx. The address must be aligned with a 32-bit memory location.
  $114 constant OTG_OTG_DIEPTXF5        \ IN endpoint FIFOx transmit RAM start address This field contains the memory start address for IN endpoint transmit FIFOx. The address must be aligned with a 32-bit memory location.
  $118 constant OTG_OTG_DIEPTXF6        \ IN endpoint FIFOx transmit RAM start address This field contains the memory start address for IN endpoint transmit FIFOx. The address must be aligned with a 32-bit memory location.
  $11C constant OTG_OTG_DIEPTXF7        \ IN endpoint FIFOx transmit RAM start address This field contains the memory start address for IN endpoint transmit FIFOx. The address must be aligned with a 32-bit memory location.
  $120 constant OTG_OTG_DIEPTXF8        \ IN endpoint FIFOx transmit RAM start address This field contains the memory start address for IN endpoint transmit FIFOx. The address must be aligned with a 32-bit memory location.
  $400 constant OTG_OTG_HCFG            \ OTG host configuration register
  $404 constant OTG_OTG_HFIR            \ OTG host frame interval register
  $408 constant OTG_OTG_HFNUM           \ OTG host frame number/frame time remaining register
  $410 constant OTG_OTG_HPTXSTS         \ OTG_Host periodic transmit FIFO/queue status register
  $414 constant OTG_OTG_HAINT           \ OTG host all channels interrupt register
  $418 constant OTG_OTG_HAINTMSK        \ OTG host all channels interrupt mask register
  $41C constant OTG_OTG_HFLBADDR        \ OTG host frame list base address register
  $440 constant OTG_OTG_HPRT            \ OTG host port control and status register
  $500 constant OTG_OTG_HCCHAR0         \ Maximum packet size Indicates the maximum packet size of the associated endpoint.
  $504 constant OTG_OTG_HCSPLT0         \ Port address This field is the port number of the recipient transaction translator.
  $508 constant OTG_OTG_HCINT0          \ OTG host channel 0 interrupt register
  $50C constant OTG_OTG_HCINTMSK0       \ OTG host channel 0 interrupt mask register
  $510 constant OTG_OTG_HCTSIZ0         \ Transfer size For an OUT, this field is the number of data bytes the host sends during the transfer. For an IN, this field is the buffer size that the application has reserved for the transfer. The application is expected to program this field as an integer multiple of the maximum packet size for IN transactions (periodic and non-periodic).
  $514 constant OTG_OTG_HCDMA0          \ DMA address This field holds the start address in the external memory from which the data for the endpoint must be fetched or to which it must be stored. This register is incremented on every AHB transaction.
  $51C constant OTG_OTG_HCDMAB0         \ DMA address This register holds the current buffer address (scatter/gather mode).
  $520 constant OTG_OTG_HCCHAR1         \ Maximum packet size Indicates the maximum packet size of the associated endpoint.
  $524 constant OTG_OTG_HCSPLT1         \ Port address This field is the port number of the recipient transaction translator.
  $528 constant OTG_OTG_HCINT1          \ OTG host channel 1 interrupt register
  $52C constant OTG_OTG_HCINTMSK1       \ OTG host channel 1 interrupt mask register
  $530 constant OTG_OTG_HCTSIZ1         \ Transfer size For an OUT, this field is the number of data bytes the host sends during the transfer. For an IN, this field is the buffer size that the application has reserved for the transfer. The application is expected to program this field as an integer multiple of the maximum packet size for IN transactions (periodic and non-periodic).
  $534 constant OTG_OTG_HCDMA1          \ DMA address This field holds the start address in the external memory from which the data for the endpoint must be fetched or to which it must be stored. This register is incremented on every AHB transaction.
  $53C constant OTG_OTG_HCDMAB1         \ DMA address This register holds the current buffer address (scatter/gather mode).
  $540 constant OTG_OTG_HCCHAR2         \ Maximum packet size Indicates the maximum packet size of the associated endpoint.
  $544 constant OTG_OTG_HCSPLT2         \ Port address This field is the port number of the recipient transaction translator.
  $548 constant OTG_OTG_HCINT2          \ OTG host channel 2 interrupt register
  $54C constant OTG_OTG_HCINTMSK2       \ OTG host channel 2 interrupt mask register
  $550 constant OTG_OTG_HCTSIZ2         \ Transfer size For an OUT, this field is the number of data bytes the host sends during the transfer. For an IN, this field is the buffer size that the application has reserved for the transfer. The application is expected to program this field as an integer multiple of the maximum packet size for IN transactions (periodic and non-periodic).
  $554 constant OTG_OTG_HCDMA2          \ DMA address This field holds the start address in the external memory from which the data for the endpoint must be fetched or to which it must be stored. This register is incremented on every AHB transaction.
  $55C constant OTG_OTG_HCDMAB2         \ DMA address This register holds the current buffer address (scatter/gather mode).
  $560 constant OTG_OTG_HCCHAR3         \ Maximum packet size Indicates the maximum packet size of the associated endpoint.
  $564 constant OTG_OTG_HCSPLT3         \ Port address This field is the port number of the recipient transaction translator.
  $568 constant OTG_OTG_HCINT3          \ OTG host channel 3 interrupt register
  $56C constant OTG_OTG_HCINTMSK3       \ OTG host channel 3 interrupt mask register
  $570 constant OTG_OTG_HCTSIZ3         \ Transfer size For an OUT, this field is the number of data bytes the host sends during the transfer. For an IN, this field is the buffer size that the application has reserved for the transfer. The application is expected to program this field as an integer multiple of the maximum packet size for IN transactions (periodic and non-periodic).
  $574 constant OTG_OTG_HCDMA3          \ DMA address This field holds the start address in the external memory from which the data for the endpoint must be fetched or to which it must be stored. This register is incremented on every AHB transaction.
  $57C constant OTG_OTG_HCDMAB3         \ DMA address This register holds the current buffer address (scatter/gather mode).
  $580 constant OTG_OTG_HCCHAR4         \ Maximum packet size Indicates the maximum packet size of the associated endpoint.
  $584 constant OTG_OTG_HCSPLT4         \ Port address This field is the port number of the recipient transaction translator.
  $588 constant OTG_OTG_HCINT4          \ OTG host channel 4 interrupt register
  $58C constant OTG_OTG_HCINTMSK4       \ OTG host channel 4 interrupt mask register
  $590 constant OTG_OTG_HCTSIZ4         \ Transfer size For an OUT, this field is the number of data bytes the host sends during the transfer. For an IN, this field is the buffer size that the application has reserved for the transfer. The application is expected to program this field as an integer multiple of the maximum packet size for IN transactions (periodic and non-periodic).
  $594 constant OTG_OTG_HCDMA4          \ DMA address This field holds the start address in the external memory from which the data for the endpoint must be fetched or to which it must be stored. This register is incremented on every AHB transaction.
  $59C constant OTG_OTG_HCDMAB4         \ DMA address This register holds the current buffer address (scatter/gather mode).
  $5A0 constant OTG_OTG_HCCHAR5         \ Maximum packet size Indicates the maximum packet size of the associated endpoint.
  $5A4 constant OTG_OTG_HCSPLT5         \ Port address This field is the port number of the recipient transaction translator.
  $5A8 constant OTG_OTG_HCINT5          \ OTG host channel 5 interrupt register
  $5AC constant OTG_OTG_HCINTMSK5       \ OTG host channel 5 interrupt mask register
  $5B0 constant OTG_OTG_HCTSIZ5         \ Transfer size For an OUT, this field is the number of data bytes the host sends during the transfer. For an IN, this field is the buffer size that the application has reserved for the transfer. The application is expected to program this field as an integer multiple of the maximum packet size for IN transactions (periodic and non-periodic).
  $5B4 constant OTG_OTG_HCDMA5          \ DMA address This field holds the start address in the external memory from which the data for the endpoint must be fetched or to which it must be stored. This register is incremented on every AHB transaction.
  $5BC constant OTG_OTG_HCDMAB5         \ DMA address This register holds the current buffer address (scatter/gather mode).
  $5C0 constant OTG_OTG_HCCHAR6         \ Maximum packet size Indicates the maximum packet size of the associated endpoint.
  $5C4 constant OTG_OTG_HCSPLT6         \ Port address This field is the port number of the recipient transaction translator.
  $5C8 constant OTG_OTG_HCINT6          \ OTG host channel 6 interrupt register
  $5CC constant OTG_OTG_HCINTMSK6       \ OTG host channel 6 interrupt mask register
  $5D0 constant OTG_OTG_HCTSIZ6         \ Transfer size For an OUT, this field is the number of data bytes the host sends during the transfer. For an IN, this field is the buffer size that the application has reserved for the transfer. The application is expected to program this field as an integer multiple of the maximum packet size for IN transactions (periodic and non-periodic).
  $5D4 constant OTG_OTG_HCDMA6          \ DMA address This field holds the start address in the external memory from which the data for the endpoint must be fetched or to which it must be stored. This register is incremented on every AHB transaction.
  $5DC constant OTG_OTG_HCDMAB6         \ DMA address This register holds the current buffer address (scatter/gather mode).
  $5E0 constant OTG_OTG_HCCHAR7         \ Maximum packet size Indicates the maximum packet size of the associated endpoint.
  $5E4 constant OTG_OTG_HCSPLT7         \ Port address This field is the port number of the recipient transaction translator.
  $5E8 constant OTG_OTG_HCINT7          \ OTG host channel 7 interrupt register
  $5EC constant OTG_OTG_HCINTMSK7       \ OTG host channel 7 interrupt mask register
  $5F0 constant OTG_OTG_HCTSIZ7         \ Transfer size For an OUT, this field is the number of data bytes the host sends during the transfer. For an IN, this field is the buffer size that the application has reserved for the transfer. The application is expected to program this field as an integer multiple of the maximum packet size for IN transactions (periodic and non-periodic).
  $5F4 constant OTG_OTG_HCDMA7          \ DMA address This field holds the start address in the external memory from which the data for the endpoint must be fetched or to which it must be stored. This register is incremented on every AHB transaction.
  $5FC constant OTG_OTG_HCDMAB7         \ DMA address This register holds the current buffer address (scatter/gather mode).
  $600 constant OTG_OTG_HCCHAR8         \ Maximum packet size Indicates the maximum packet size of the associated endpoint.
  $604 constant OTG_OTG_HCSPLT8         \ Port address This field is the port number of the recipient transaction translator.
  $608 constant OTG_OTG_HCINT8          \ OTG host channel 8 interrupt register
  $60C constant OTG_OTG_HCINTMSK8       \ OTG host channel 8 interrupt mask register
  $610 constant OTG_OTG_HCTSIZ8         \ Transfer size For an OUT, this field is the number of data bytes the host sends during the transfer. For an IN, this field is the buffer size that the application has reserved for the transfer. The application is expected to program this field as an integer multiple of the maximum packet size for IN transactions (periodic and non-periodic).
  $614 constant OTG_OTG_HCDMA8          \ DMA address This field holds the start address in the external memory from which the data for the endpoint must be fetched or to which it must be stored. This register is incremented on every AHB transaction.
  $61C constant OTG_OTG_HCDMAB8         \ DMA address This register holds the current buffer address (scatter/gather mode).
  $620 constant OTG_OTG_HCCHAR9         \ Maximum packet size Indicates the maximum packet size of the associated endpoint.
  $624 constant OTG_OTG_HCSPLT9         \ Port address This field is the port number of the recipient transaction translator.
  $628 constant OTG_OTG_HCINT9          \ OTG host channel 9 interrupt register
  $62C constant OTG_OTG_HCINTMSK9       \ OTG host channel 9 interrupt mask register
  $630 constant OTG_OTG_HCTSIZ9         \ Transfer size For an OUT, this field is the number of data bytes the host sends during the transfer. For an IN, this field is the buffer size that the application has reserved for the transfer. The application is expected to program this field as an integer multiple of the maximum packet size for IN transactions (periodic and non-periodic).
  $634 constant OTG_OTG_HCDMA9          \ DMA address This field holds the start address in the external memory from which the data for the endpoint must be fetched or to which it must be stored. This register is incremented on every AHB transaction.
  $63C constant OTG_OTG_HCDMAB9         \ DMA address This register holds the current buffer address (scatter/gather mode).
  $640 constant OTG_OTG_HCCHAR10        \ Maximum packet size Indicates the maximum packet size of the associated endpoint.
  $644 constant OTG_OTG_HCSPLT10        \ Port address This field is the port number of the recipient transaction translator.
  $648 constant OTG_OTG_HCINT10         \ OTG host channel 10 interrupt register
  $64C constant OTG_OTG_HCINTMSK10      \ OTG host channel 10 interrupt mask register
  $650 constant OTG_OTG_HCTSIZ10        \ Transfer size For an OUT, this field is the number of data bytes the host sends during the transfer. For an IN, this field is the buffer size that the application has reserved for the transfer. The application is expected to program this field as an integer multiple of the maximum packet size for IN transactions (periodic and non-periodic).
  $654 constant OTG_OTG_HCDMA10         \ DMA address This field holds the start address in the external memory from which the data for the endpoint must be fetched or to which it must be stored. This register is incremented on every AHB transaction.
  $65C constant OTG_OTG_HCDMAB10        \ DMA address This register holds the current buffer address (scatter/gather mode).
  $660 constant OTG_OTG_HCCHAR11        \ Maximum packet size Indicates the maximum packet size of the associated endpoint.
  $664 constant OTG_OTG_HCSPLT11        \ Port address This field is the port number of the recipient transaction translator.
  $668 constant OTG_OTG_HCINT11         \ OTG host channel 11 interrupt register
  $66C constant OTG_OTG_HCINTMSK11      \ OTG host channel 11 interrupt mask register
  $670 constant OTG_OTG_HCTSIZ11        \ Transfer size For an OUT, this field is the number of data bytes the host sends during the transfer. For an IN, this field is the buffer size that the application has reserved for the transfer. The application is expected to program this field as an integer multiple of the maximum packet size for IN transactions (periodic and non-periodic).
  $674 constant OTG_OTG_HCDMA11         \ DMA address This field holds the start address in the external memory from which the data for the endpoint must be fetched or to which it must be stored. This register is incremented on every AHB transaction.
  $67C constant OTG_OTG_HCDMAB11        \ DMA address This register holds the current buffer address (scatter/gather mode).
  $680 constant OTG_OTG_HCCHAR12        \ Maximum packet size Indicates the maximum packet size of the associated endpoint.
  $684 constant OTG_OTG_HCSPLT12        \ Port address This field is the port number of the recipient transaction translator.
  $688 constant OTG_OTG_HCINT12         \ OTG host channel 12 interrupt register
  $68C constant OTG_OTG_HCINTMSK12      \ OTG host channel 12 interrupt mask register
  $690 constant OTG_OTG_HCTSIZ12        \ Transfer size For an OUT, this field is the number of data bytes the host sends during the transfer. For an IN, this field is the buffer size that the application has reserved for the transfer. The application is expected to program this field as an integer multiple of the maximum packet size for IN transactions (periodic and non-periodic).
  $694 constant OTG_OTG_HCDMA12         \ DMA address This field holds the start address in the external memory from which the data for the endpoint must be fetched or to which it must be stored. This register is incremented on every AHB transaction.
  $69C constant OTG_OTG_HCDMAB12        \ DMA address This register holds the current buffer address (scatter/gather mode).
  $6A0 constant OTG_OTG_HCCHAR13        \ Maximum packet size Indicates the maximum packet size of the associated endpoint.
  $6A4 constant OTG_OTG_HCSPLT13        \ Port address This field is the port number of the recipient transaction translator.
  $6A8 constant OTG_OTG_HCINT13         \ OTG host channel 13 interrupt register
  $6AC constant OTG_OTG_HCINTMSK13      \ OTG host channel 13 interrupt mask register
  $6B0 constant OTG_OTG_HCTSIZ13        \ Transfer size For an OUT, this field is the number of data bytes the host sends during the transfer. For an IN, this field is the buffer size that the application has reserved for the transfer. The application is expected to program this field as an integer multiple of the maximum packet size for IN transactions (periodic and non-periodic).
  $6B4 constant OTG_OTG_HCDMA13         \ DMA address This field holds the start address in the external memory from which the data for the endpoint must be fetched or to which it must be stored. This register is incremented on every AHB transaction.
  $6BC constant OTG_OTG_HCDMAB13        \ DMA address This register holds the current buffer address (scatter/gather mode).
  $6C0 constant OTG_OTG_HCCHAR14        \ Maximum packet size Indicates the maximum packet size of the associated endpoint.
  $6C4 constant OTG_OTG_HCSPLT14        \ Port address This field is the port number of the recipient transaction translator.
  $6C8 constant OTG_OTG_HCINT14         \ OTG host channel 14 interrupt register
  $6CC constant OTG_OTG_HCINTMSK14      \ OTG host channel 14 interrupt mask register
  $6D0 constant OTG_OTG_HCTSIZ14        \ Transfer size For an OUT, this field is the number of data bytes the host sends during the transfer. For an IN, this field is the buffer size that the application has reserved for the transfer. The application is expected to program this field as an integer multiple of the maximum packet size for IN transactions (periodic and non-periodic).
  $6D4 constant OTG_OTG_HCDMA14         \ DMA address This field holds the start address in the external memory from which the data for the endpoint must be fetched or to which it must be stored. This register is incremented on every AHB transaction.
  $6DC constant OTG_OTG_HCDMAB14        \ DMA address This register holds the current buffer address (scatter/gather mode).
  $6E0 constant OTG_OTG_HCCHAR15        \ Maximum packet size Indicates the maximum packet size of the associated endpoint.
  $6E4 constant OTG_OTG_HCSPLT15        \ Port address This field is the port number of the recipient transaction translator.
  $6E8 constant OTG_OTG_HCINT15         \ OTG host channel 15 interrupt register
  $6EC constant OTG_OTG_HCINTMSK15      \ OTG host channel 15 interrupt mask register
  $6F0 constant OTG_OTG_HCTSIZ15        \ Transfer size For an OUT, this field is the number of data bytes the host sends during the transfer. For an IN, this field is the buffer size that the application has reserved for the transfer. The application is expected to program this field as an integer multiple of the maximum packet size for IN transactions (periodic and non-periodic).
  $6F4 constant OTG_OTG_HCDMA15         \ DMA address This field holds the start address in the external memory from which the data for the endpoint must be fetched or to which it must be stored. This register is incremented on every AHB transaction.
  $6FC constant OTG_OTG_HCDMAB15        \ DMA address This register holds the current buffer address (scatter/gather mode).
  $800 constant OTG_OTG_DCFG            \ OTG device configuration register
  $804 constant OTG_OTG_DCTL            \ Remote wakeup signaling When the application sets this bit, the core initiates remote signaling to wake up the USB host. The application must set this bit to instruct the core to exit the suspend state. As specified in the USB 2.0 specification, the application must clear this bit 1 ms to 15 ms after setting it. If LPM is enabled and the core is in the L1 (sleep) state, when the application sets this bit, the core initiates L1 remote signaling to wake up the USB host. The application must set this bit to instruct the core to exit the sleep state. As specified in the LPM specification, the hardware automatically clears this bit 50Â Âµs (TL1DevDrvResume) after being set by the application. The application must not set this bit when bRemoteWake from the previous LPM transaction is zero (refer to REMWAKE bit in GLPMCFG register).
  $808 constant OTG_OTG_DSTS            \ OTG device status register
  $810 constant OTG_OTG_DIEPMSK         \ OTG device IN endpoint common interrupt mask register
  $814 constant OTG_OTG_DOEPMSK         \ OTG device OUT endpoint common interrupt mask register
  $818 constant OTG_OTG_DAINT           \ OTG device all endpoints interrupt register
  $81C constant OTG_OTG_DAINTMSK        \ OTG all endpoints interrupt mask register
  $828 constant OTG_OTG_DVBUSDIS        \ OTG device VBUS discharge time register
  $82C constant OTG_OTG_DVBUSPULSE      \ OTG device VBUS pulsing time register
  $830 constant OTG_OTG_DTHRCTL         \ Nonisochronous IN endpoints threshold enable When this bit is set, the core enables thresholding for nonisochronous IN endpoints.
  $834 constant OTG_OTG_DIEPEMPMSK      \ OTG device IN endpoint FIFO empty interrupt mask register
  $900 constant OTG_OTG_DIEPCTL0        \ OTG device IN endpoint 0 control register
  $908 constant OTG_OTG_DIEPINT0        \ OTG device IN endpoint 0 interrupt register
  $910 constant OTG_OTG_DIEPTSIZ0       \ OTG device IN endpoint 0 transfer size register
  $914 constant OTG_OTG_DIEPDMA0        \ DMA Address This field holds the start address in the external memory from which the data for the endpoint must be fetched. This register is incremented on every AHB transaction.
  $918 constant OTG_OTG_DTXFSTS0        \ OTG device IN endpoint transmit FIFO status register
  $920 constant OTG_OTG_DIEPCTL1        \ OTG device IN endpoint 1 control register
  $928 constant OTG_OTG_DIEPINT1        \ OTG device IN endpoint 1 interrupt register
  $930 constant OTG_OTG_DIEPTSIZ1       \ OTG device IN endpoint 1 transfer size register
  $934 constant OTG_OTG_DIEPDMA1        \ DMA Address This field holds the start address in the external memory from which the data for the endpoint must be fetched. This register is incremented on every AHB transaction.
  $938 constant OTG_OTG_DTXFSTS1        \ OTG device IN endpoint transmit FIFO status register
  $940 constant OTG_OTG_DIEPCTL2        \ OTG device IN endpoint 2 control register
  $948 constant OTG_OTG_DIEPINT2        \ OTG device IN endpoint 2 interrupt register
  $950 constant OTG_OTG_DIEPTSIZ2       \ OTG device IN endpoint 2 transfer size register
  $954 constant OTG_OTG_DIEPDMA2        \ DMA Address This field holds the start address in the external memory from which the data for the endpoint must be fetched. This register is incremented on every AHB transaction.
  $958 constant OTG_OTG_DTXFSTS2        \ OTG device IN endpoint transmit FIFO status register
  $960 constant OTG_OTG_DIEPCTL3        \ OTG device IN endpoint 3 control register
  $968 constant OTG_OTG_DIEPINT3        \ OTG device IN endpoint 3 interrupt register
  $970 constant OTG_OTG_DIEPTSIZ3       \ OTG device IN endpoint 3 transfer size register
  $974 constant OTG_OTG_DIEPDMA3        \ DMA Address This field holds the start address in the external memory from which the data for the endpoint must be fetched. This register is incremented on every AHB transaction.
  $978 constant OTG_OTG_DTXFSTS3        \ OTG device IN endpoint transmit FIFO status register
  $980 constant OTG_OTG_DIEPCTL4        \ OTG device IN endpoint 4 control register
  $988 constant OTG_OTG_DIEPINT4        \ OTG device IN endpoint 4 interrupt register
  $990 constant OTG_OTG_DIEPTSIZ4       \ OTG device IN endpoint 4 transfer size register
  $994 constant OTG_OTG_DIEPDMA4        \ DMA Address This field holds the start address in the external memory from which the data for the endpoint must be fetched. This register is incremented on every AHB transaction.
  $998 constant OTG_OTG_DTXFSTS4        \ OTG device IN endpoint transmit FIFO status register
  $9A0 constant OTG_OTG_DIEPCTL5        \ OTG device IN endpoint 5 control register
  $9A8 constant OTG_OTG_DIEPINT5        \ OTG device IN endpoint 5 interrupt register
  $9B0 constant OTG_OTG_DIEPTSIZ5       \ OTG device IN endpoint 5 transfer size register
  $9B4 constant OTG_OTG_DIEPDMA5        \ DMA Address This field holds the start address in the external memory from which the data for the endpoint must be fetched. This register is incremented on every AHB transaction.
  $9B8 constant OTG_OTG_DTXFSTS5        \ OTG device IN endpoint transmit FIFO status register
  $9C0 constant OTG_OTG_DIEPCTL6        \ OTG device IN endpoint 6 control register
  $9C8 constant OTG_OTG_DIEPINT6        \ OTG device IN endpoint 6 interrupt register
  $9D0 constant OTG_OTG_DIEPTSIZ6       \ OTG device IN endpoint 6 transfer size register
  $9D4 constant OTG_OTG_DIEPDMA6        \ DMA Address This field holds the start address in the external memory from which the data for the endpoint must be fetched. This register is incremented on every AHB transaction.
  $9D8 constant OTG_OTG_DTXFSTS6        \ OTG device IN endpoint transmit FIFO status register
  $9E0 constant OTG_OTG_DIEPCTL7        \ OTG device IN endpoint 7 control register
  $9E8 constant OTG_OTG_DIEPINT7        \ OTG device IN endpoint 7 interrupt register
  $9F0 constant OTG_OTG_DIEPTSIZ7       \ OTG device IN endpoint 7 transfer size register
  $9F4 constant OTG_OTG_DIEPDMA7        \ DMA Address This field holds the start address in the external memory from which the data for the endpoint must be fetched. This register is incremented on every AHB transaction.
  $9F8 constant OTG_OTG_DTXFSTS7        \ OTG device IN endpoint transmit FIFO status register
  $A00 constant OTG_OTG_DIEPCTL8        \ OTG device IN endpoint 8 control register
  $A08 constant OTG_OTG_DIEPINT8        \ OTG device IN endpoint 8 interrupt register
  $A10 constant OTG_OTG_DIEPTSIZ8       \ OTG device IN endpoint 8 transfer size register
  $A14 constant OTG_OTG_DIEPDMA8        \ DMA Address This field holds the start address in the external memory from which the data for the endpoint must be fetched. This register is incremented on every AHB transaction.
  $A18 constant OTG_OTG_DTXFSTS8        \ OTG device IN endpoint transmit FIFO status register
  $B00 constant OTG_OTG_DOEPCTL0        \ OTG device control OUT endpoint 0 control register
  $B08 constant OTG_OTG_DOEPINT0        \ OTG device OUT endpoint 0 interrupt register
  $B10 constant OTG_OTG_DOEPTSIZ0       \ OTG device OUT endpoint 0 transfer size register
  $B14 constant OTG_OTG_DOEPDMA0        \ DMA Address This field holds the start address in the external memory from which the data for the endpoint must be fetched. This register is incremented on every AHB transaction.
  $B20 constant OTG_OTG_DOEPCTL1        \ OTG device OUT endpoint 1 control register
  $B28 constant OTG_OTG_DOEPINT1        \ OTG device OUT endpoint 1 interrupt register
  $B30 constant OTG_OTG_DOEPTSIZ1       \ OTG device OUT endpoint 1 transfer size register
  $B34 constant OTG_OTG_DOEPDMA1        \ DMA Address This field holds the start address in the external memory from which the data for the endpoint must be fetched. This register is incremented on every AHB transaction.
  $B40 constant OTG_OTG_DOEPCTL2        \ OTG device OUT endpoint 2 control register
  $B48 constant OTG_OTG_DOEPINT2        \ OTG device OUT endpoint 2 interrupt register
  $B50 constant OTG_OTG_DOEPTSIZ2       \ OTG device OUT endpoint 2 transfer size register
  $B54 constant OTG_OTG_DOEPDMA2        \ DMA Address This field holds the start address in the external memory from which the data for the endpoint must be fetched. This register is incremented on every AHB transaction.
  $B60 constant OTG_OTG_DOEPCTL3        \ OTG device OUT endpoint 3 control register
  $B68 constant OTG_OTG_DOEPINT3        \ OTG device OUT endpoint 3 interrupt register
  $B70 constant OTG_OTG_DOEPTSIZ3       \ OTG device OUT endpoint 3 transfer size register
  $B74 constant OTG_OTG_DOEPDMA3        \ DMA Address This field holds the start address in the external memory from which the data for the endpoint must be fetched. This register is incremented on every AHB transaction.
  $B80 constant OTG_OTG_DOEPCTL4        \ OTG device OUT endpoint 4 control register
  $B88 constant OTG_OTG_DOEPINT4        \ OTG device OUT endpoint 4 interrupt register
  $B90 constant OTG_OTG_DOEPTSIZ4       \ OTG device OUT endpoint 4 transfer size register
  $B94 constant OTG_OTG_DOEPDMA4        \ DMA Address This field holds the start address in the external memory from which the data for the endpoint must be fetched. This register is incremented on every AHB transaction.
  $BA0 constant OTG_OTG_DOEPCTL5        \ OTG device OUT endpoint 5 control register
  $BA8 constant OTG_OTG_DOEPINT5        \ OTG device OUT endpoint 5 interrupt register
  $BB0 constant OTG_OTG_DOEPTSIZ5       \ OTG device OUT endpoint 5 transfer size register
  $BB4 constant OTG_OTG_DOEPDMA5        \ DMA Address This field holds the start address in the external memory from which the data for the endpoint must be fetched. This register is incremented on every AHB transaction.
  $BC0 constant OTG_OTG_DOEPCTL6        \ OTG device OUT endpoint 6 control register
  $BC8 constant OTG_OTG_DOEPINT6        \ OTG device OUT endpoint 6 interrupt register
  $BD0 constant OTG_OTG_DOEPTSIZ6       \ OTG device OUT endpoint 6 transfer size register
  $BD4 constant OTG_OTG_DOEPDMA6        \ DMA Address This field holds the start address in the external memory from which the data for the endpoint must be fetched. This register is incremented on every AHB transaction.
  $BE0 constant OTG_OTG_DOEPCTL7        \ OTG device OUT endpoint 7 control register
  $BE8 constant OTG_OTG_DOEPINT7        \ OTG device OUT endpoint 7 interrupt register
  $BF0 constant OTG_OTG_DOEPTSIZ7       \ OTG device OUT endpoint 7 transfer size register
  $BF4 constant OTG_OTG_DOEPDMA7        \ DMA Address This field holds the start address in the external memory from which the data for the endpoint must be fetched. This register is incremented on every AHB transaction.
  $C00 constant OTG_OTG_DOEPCTL8        \ OTG device OUT endpoint 8 control register
  $C08 constant OTG_OTG_DOEPINT8        \ OTG device OUT endpoint 8 interrupt register
  $C10 constant OTG_OTG_DOEPTSIZ8       \ OTG device OUT endpoint 8 transfer size register
  $C14 constant OTG_OTG_DOEPDMA8        \ DMA Address This field holds the start address in the external memory from which the data for the endpoint must be fetched. This register is incremented on every AHB transaction.
  $E00 constant OTG_OTG_PCGCCTL         \ OTG power and clock gating control register

: OTG_DEF ; [then]
