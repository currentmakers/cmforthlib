\
\ @file otg_fs.fs
\ @brief USB OTG FS global interrupt
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

$00000004 constant OTG_FS_OTG_GOTGCTL_VBVALOEN                      \ V<sub>BUS</sub> valid override enable. This bit is used to enable/disable the software to override the vbusvalid signal using the VBVALOVAL bit. Note: Only accessible in host mode.
$00000008 constant OTG_FS_OTG_GOTGCTL_VBVALOVAL                     \ V<sub>BUS</sub> valid override value. This bit is used to set override value for vbusvalid signal when VBVALOEN bit is set. Note: Only accessible in host mode.
$00000010 constant OTG_FS_OTG_GOTGCTL_AVALOEN                       \ A-peripheral session valid override enable. This bit is used to enable/disable the software to override the Avalid signal using the AVALOVAL bit. Note: Only accessible in host mode.
$00000020 constant OTG_FS_OTG_GOTGCTL_AVALOVAL                      \ A-peripheral session valid override value. This bit is used to set override value for Avalid signal when AVALOEN bit is set. Note: Only accessible in host mode.
$00000040 constant OTG_FS_OTG_GOTGCTL_BVALOEN                       \ B-peripheral session valid override enable. This bit is used to enable/disable the software to override the Bvalid signal using the BVALOVAL bit. 1 Internally Bvalid received from the PHY is overridden with BVALOVAL bit value Note: Only accessible in device mode.
$00000080 constant OTG_FS_OTG_GOTGCTL_BVALOVAL                      \ B-peripheral session valid override value. This bit is used to set override value for Bvalid signal when BVALOEN bit is set. Note: Only accessible in device mode.
$00001000 constant OTG_FS_OTG_GOTGCTL_EHEN                          \ Embedded host enable It is used to select between OTG A device state machine and embedded host state machine.
$00010000 constant OTG_FS_OTG_GOTGCTL_CIDSTS                        \ Connector ID status Indicates the connector ID status on a connect event. Note: Accessible in both device and host modes.
$00020000 constant OTG_FS_OTG_GOTGCTL_DBCT                          \ Long/short debounce time Indicates the debounce time of a detected connection. Note: Only accessible in host mode.
$00040000 constant OTG_FS_OTG_GOTGCTL_ASVLD                         \ A-session valid Indicates the host mode transceiver status. Note: Only accessible in host mode.
$00080000 constant OTG_FS_OTG_GOTGCTL_BSVLD                         \ B-session valid Indicates the device mode transceiver status. In OTG mode, the user can use this bit to determine if the device is connected or disconnected. Note: Only accessible in device mode.
$00100000 constant OTG_FS_OTG_GOTGCTL_OTGVER                        \ OTG version Selects the OTG revision.
$00200000 constant OTG_FS_OTG_GOTGCTL_CURMOD                        \ Current mode of operation Indicates the current mode (host or device).


\
\ @brief OTG interrupt register
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$00000004 constant OTG_FS_OTG_GOTGINT_SEDET                         \ Session end detected The core sets this bit to indicate that the level of the voltage on V<sub>BUS</sub> is no longer valid for a B-Peripheral session when V<sub>BUS</sub> < 0.8 V. Note: Accessible in both device and host modes.
$00040000 constant OTG_FS_OTG_GOTGINT_ADTOCHG                       \ A-device timeout change The core sets this bit to indicate that the A-device has timed out while waiting for the B-device to connect. Note: Accessible in both device and host modes.


\
\ @brief OTG AHB configuration register
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$00000001 constant OTG_FS_OTG_GAHBCFG_GINTMSK                       \ Global interrupt mask The application uses this bit to mask or unmask the interrupt line assertion to itself. Irrespective of this bits setting, the interrupt status registers are updated by the core. Note: Accessible in both device and host modes.
$0000001e constant OTG_FS_OTG_GAHBCFG_HBSTLEN                       \ Burst length/type 0000 Single: Bus transactions use single 32 bit accesses (not recommended) 0001 INCR: Bus transactions use unspecified length accesses (not recommended, uses the INCR AHB bus command) 0011 INCR4: Bus transactions target 4x 32 bit accesses 0101 INCR8: Bus transactions target 8x 32 bit accesses 0111 INCR16: Bus transactions based on 16x 32 bit accesses Others: Reserved
$00000020 constant OTG_FS_OTG_GAHBCFG_DMAEN                         \ DMA enabled
$00000080 constant OTG_FS_OTG_GAHBCFG_TXFELVL                       \ Tx FIFO empty level This bit indicates when IN endpoint Transmit FIFO empty interrupt (TXFE in OTG_DIEPINTx) is triggered: This bit indicates when the nonperiodic Tx FIFO empty interrupt (NPTXFE bit in OTG_GINTSTS) is triggered:
$00000100 constant OTG_FS_OTG_GAHBCFG_PTXFELVL                      \ Periodic Tx FIFO empty level Indicates when the periodic Tx FIFO empty interrupt bit in the OTG_GINTSTS register (PTXFE bit in OTG_GINTSTS) is triggered. Note: Only accessible in host mode.


\
\ @brief OTG USB configuration register
\ Address offset: 0x0C
\ Reset value: 0x00001400
\

$00000007 constant OTG_FS_OTG_GUSBCFG_TOCAL                         \ FS timeout calibration The number of PHY clocks that the application programs in this field is added to the full-speed interpacket timeout duration in the core to account for any additional delays introduced by the PHY. This can be required, because the delay introduced by the PHY in generating the line state condition can vary from one PHY to another. The USB standard timeout value for full-speed operation is 16 to 18 (inclusive) bit times. The application must program this field based on the speed of enumeration. The number of bit times added per PHY clock is 0.25 bit times.
$00003c00 constant OTG_FS_OTG_GUSBCFG_TRDT                          \ USB turnaround time These bits allows to set the turnaround time in PHY clocks. They must be configured according to Table 683: TRDT values, depending on the application AHB frequency. Higher TRDT values allow stretching the USB response time to IN tokens in order to compensate for longer AHB read access latency to the data FIFO. Note: Only accessible in device mode.
$00008000 constant OTG_FS_OTG_GUSBCFG_PHYLPC                        \ PHY Low-power clock select This bit selects either 480 MHz or 48 MHz (low-power) PHY mode. In FS and LS modes, the PHY can usually operate on a 48 MHz clock to save power. In 480 MHz mode, the UTMI interface operates at either 60 or 30 MHz, depending on whether the 8- or 16-bit data width is selected. In 48 MHz mode, the UTMI interface operates at 48 MHz in FS and LS modes.
$00400000 constant OTG_FS_OTG_GUSBCFG_TSDPS                         \ TermSel DLine pulsing selection This bit selects utmi_termselect to drive the data line pulse during SRP (session request protocol).
$20000000 constant OTG_FS_OTG_GUSBCFG_FHMOD                         \ Force host mode Writing a 1 to this bit, forces the core to host mode irrespective of the OTG_ID input pin. After setting the force bit, the application must wait at least 25 ms before the change takes effect. Note: Accessible in both device and host modes.
$40000000 constant OTG_FS_OTG_GUSBCFG_FDMOD                         \ Force device mode Writing a 1 to this bit, forces the core to device mode irrespective of the OTG_ID input pin. After setting the force bit, the application must wait at least 25 ms before the change takes effect. Note: Accessible in both device and host modes.


\
\ @brief OTG reset register
\ Address offset: 0x10
\ Reset value: 0x80000000
\

$00000001 constant OTG_FS_OTG_GRSTCTL_CSRST                         \ Core soft reset Resets the HCLK and PHY clock domains as follows: Clears the interrupts and all the CSR register bits except for the following bits: GATEHCLK bit in OTG_PCGCCTL STPPCLK bit in OTG_PCGCCTL FSLSPCS bits in OTG_HCFG DSPD bit in OTG_DCFG SDIS bit in OTG_DCTL OTG_GCCFG register All module state machines (except for the AHB slave unit) are reset to the Idle state, and all the transmit FIFOs and the receive FIFO are flushed. Any transactions on the AHB Master are terminated as soon as possible, after completing the last data phase of an AHB transfer. Any transactions on the USB are terminated immediately. The application can write to this bit any time it wants to reset the core. This is a self-clearing bit and the core clears this bit after all the necessary logic is reset in the core, which can take several clocks, depending on the current state of the core. Once this bit has been cleared, the software must wait at least 3 PHY clocks before accessing the PHY domain (synchronization delay). The software must also check that bit 31 in this register is set to 1 (AHB Master is Idle) before starting any operation. Typically, the software reset is used during software development and also when the user dynamically changes the PHY selection bits in the above listed USB configuration registers. When the user changes the PHY, the corresponding clock for the PHY is selected and used in the PHY domain. Once a new clock is selected, the PHY domain has to be reset for proper operation. Note: Accessible in both device and host modes.
$00000002 constant OTG_FS_OTG_GRSTCTL_PSRST                         \ Partial soft reset Resets the internal state machines but keeps the enumeration info. Could be used to recover some specific PHY errors. Note: Accessible in both device and host modes.
$00000004 constant OTG_FS_OTG_GRSTCTL_FCRST                         \ Host frame counter reset The application writes this bit to reset the (micro-)frame number counter inside the core. When the (micro-)frame counter is reset, the subsequent SOF sent out by the core has a frame number of 0. When application writes '1' to the bit, it might not be able to read back the value as it gets cleared by the core in a few clock cycles. Note: Only accessible in host mode.
$00000010 constant OTG_FS_OTG_GRSTCTL_RXFFLSH                       \ Rx FIFO flush The application can flush the entire Rx FIFO using this bit, but must first ensure that the core is not in the middle of a transaction. The application must only write to this bit after checking that the core is neither reading from the Rx FIFO nor writing to the Rx FIFO. The application must wait until the bit is cleared before performing any other operations. This bit requires 8 clocks (slowest of PHY or AHB clock) to clear. Note: Accessible in both device and host modes.
$00000020 constant OTG_FS_OTG_GRSTCTL_TXFFLSH                       \ Tx FIFO flush
$000007c0 constant OTG_FS_OTG_GRSTCTL_TXFNUM                        \ Tx FIFO number This is the FIFO number that must be flushed using the Tx FIFO Flush bit. This field must not be changed until the core clears the Tx FIFO Flush bit. ... Note: Accessible in both device and host modes.
$40000000 constant OTG_FS_OTG_GRSTCTL_DMAREQ                        \ DMA request signal enabled This bit indicates that the DMA request is in progress. Used for debug.
$80000000 constant OTG_FS_OTG_GRSTCTL_AHBIDL                        \ AHB master idle Indicates that the AHB master state machine is in the Idle condition. Note: Accessible in both device and host modes.


\
\ @brief OTG core interrupt register
\ Address offset: 0x14
\ Reset value: 0x04000020
\

$00000001 constant OTG_FS_OTG_GINTSTS_HOST_CMOD                     \ Current mode of operation Indicates the current mode. Note: Accessible in both host and device modes.
$00000002 constant OTG_FS_OTG_GINTSTS_HOST_MMIS                     \ Mode mismatch interrupt The core sets this bit when the application is trying to access: A host mode register, when the core is operating in device mode A device mode register, when the core is operating in host mode The register access is completed on the AHB with an OKAY response, but is ignored by the core internally and does not affect the operation of the core. Note: Accessible in both host and device modes.
$00000004 constant OTG_FS_OTG_GINTSTS_HOST_OTGINT                   \ OTG interrupt The core sets this bit to indicate an OTG protocol event. The application must read the OTG interrupt status (OTG_GOTGINT) register to determine the exact event that caused this interrupt. The application must clear the appropriate status bit in the OTG_GOTGINT register to clear this bit. Note: Accessible in both host and device modes.
$00000008 constant OTG_FS_OTG_GINTSTS_HOST_SOF                      \ Start of frame In host mode, the core sets this bit to indicate that an SOF (FS), or Keep-Alive (LS) is transmitted on the USB. The application must write a 1 to this bit to clear the interrupt. In device mode, in the core sets this bit to indicate that an SOF token has been received on the USB. The application can read the OTG_DSTS register to get the current frame number. This interrupt is seen only when the core is operating in FS. Note: This register may return '1' if read immediately after power on reset. If the register bit reads '1' immediately after power on reset it does not indicate that an SOF has been sent (in case of host mode) or SOF has been received (in case of device mode). The read value of this interrupt is valid only after a valid connection between host and device is established. If the bit is set after power on reset the application can clear the bit. Note: Accessible in both host and device modes.
$00000010 constant OTG_FS_OTG_GINTSTS_HOST_RXFLVL                   \ Rx FIFO non-empty Indicates that there is at least one packet pending to be read from the Rx FIFO. Note: Accessible in both host and device modes.
$00000020 constant OTG_FS_OTG_GINTSTS_HOST_NPTXFE                   \ Non-periodic Tx FIFO empty This interrupt is asserted when the non-periodic Tx FIFO is either half or completely empty, and there is space for at least one entry to be written to the non-periodic transmit request queue. The half or completely empty status is determined by the non-periodic Tx FIFO empty level bit in the OTG_GAHBCFG register (TXFELVL bit in OTG_GAHBCFG). Note: Accessible in host mode only.
$00000040 constant OTG_FS_OTG_GINTSTS_HOST_GINAKEFF                 \ Global IN non-periodic NAK effective Indicates that the Set global non-periodic IN NAK bit in the OTG_DCTL register (SGINAK bit in OTG_DCTL), set by the application, has taken effect in the core. That is, the core has sampled the Global IN NAK bit set by the application. This bit can be cleared by clearing the Clear global non-periodic IN NAK bit in the OTG_DCTL register (CGINAK bit in OTG_DCTL). This interrupt does not necessarily mean that a NAK handshake is sent out on the USB. The STALL bit takes precedence over the NAK bit. Note: Only accessible in device mode.
$00000080 constant OTG_FS_OTG_GINTSTS_HOST_GONAKEFF                 \ Global OUT NAK effective Indicates that the Set global OUT NAK bit in the OTG_DCTL register (SGONAK bit in OTG_DCTL), set by the application, has taken effect in the core. This bit can be cleared by writing the Clear global OUT NAK bit in the OTG_DCTL register (CGONAK bit in OTG_DCTL). Note: Only accessible in device mode.
$00000400 constant OTG_FS_OTG_GINTSTS_HOST_ESUSP                    \ Early suspend The core sets this bit to indicate that an Idle state has been detected on the USB for 3 ms. Note: Only accessible in device mode.
$00000800 constant OTG_FS_OTG_GINTSTS_HOST_USBSUSP                  \ USB suspend The core sets this bit to indicate that a suspend was detected on the USB. The core enters the suspended state when there is no activity on the data lines for an extended period of time. Note: Only accessible in device mode.
$00001000 constant OTG_FS_OTG_GINTSTS_HOST_USBRST                   \ USB reset The core sets this bit to indicate that a reset is detected on the USB. Note: Only accessible in device mode.
$00002000 constant OTG_FS_OTG_GINTSTS_HOST_ENUMDNE                  \ Enumeration done The core sets this bit to indicate that speed enumeration is complete. The application must read the OTG_DSTS register to obtain the enumerated speed. Note: Only accessible in device mode.
$00004000 constant OTG_FS_OTG_GINTSTS_HOST_ISOODRP                  \ Isochronous OUT packet dropped interrupt The core sets this bit when it fails to write an isochronous OUT packet into the Rx FIFO because the Rx FIFO does not have enough space to accommodate a maximum size packet for the isochronous OUT endpoint. Note: Only accessible in device mode.
$00008000 constant OTG_FS_OTG_GINTSTS_HOST_EOPF                     \ End of periodic frame interrupt Indicates that the period specified in the periodic frame interval field of the OTG_DCFG register (PFIVL bit in OTG_DCFG) has been reached in the current frame. Note: Only accessible in device mode.
$00040000 constant OTG_FS_OTG_GINTSTS_HOST_IEPINT                   \ IN endpoint interrupt The core sets this bit to indicate that an interrupt is pending on one of the IN endpoints of the core (in device mode). The application must read the OTG_DAINT register to determine the exact number of the IN endpoint on which the interrupt occurred, and then read the corresponding OTG_DIEPINTx register to determine the exact cause of the interrupt. The application must clear the appropriate status bit in the corresponding OTG_DIEPINTx register to clear this bit. Note: Only accessible in device mode.
$00080000 constant OTG_FS_OTG_GINTSTS_HOST_OEPINT                   \ OUT endpoint interrupt The core sets this bit to indicate that an interrupt is pending on one of the OUT endpoints of the core (in device mode). The application must read the OTG_DAINT register to determine the exact number of the OUT endpoint on which the interrupt occurred, and then read the corresponding OTG_DOEPINTx register to determine the exact cause of the interrupt. The application must clear the appropriate status bit in the corresponding OTG_DOEPINTx register to clear this bit. Note: Only accessible in device mode.
$00100000 constant OTG_FS_OTG_GINTSTS_HOST_IISOIXFR                 \ Incomplete isochronous IN transfer The core sets this interrupt to indicate that there is at least one isochronous IN endpoint on which the transfer is not completed in the current frame. This interrupt is asserted along with the End of periodic frame interrupt (EOPF) bit in this register. Note: Only accessible in device mode.
$00200000 constant OTG_FS_OTG_GINTSTS_HOST_IPXFR                    \ Incomplete periodic transfer In host mode, the core sets this interrupt bit when there are incomplete periodic transactions still pending, which are scheduled for the current frame.
$00400000 constant OTG_FS_OTG_GINTSTS_HOST_DATAFSUSP                \ Data fetch suspended This interrupt is valid only in DMA mode. This interrupt indicates that the core has stopped fetching data for IN endpoints due to the unavailability of TxFIFO space or request queue space. This interrupt is used by the application for an endpoint mismatch algorithm. For example, after detecting an endpoint mismatch, the application: Sets a global nonperiodic IN NAK handshake Disables IN endpoints Flushes the FIFO Determines the token sequence from the IN token sequence learning queue Re-enables the endpoints Clears the global nonperiodic IN NAK handshake If the global nonperiodic IN NAK is cleared, the core has not yet fetched data for the IN endpoint, and the IN token is received: the core generates an IN token received when FIFO empty interrupt. The OTG then sends a NAK response to the host. To avoid this scenario, the application can check the FetSusp interrupt in OTG_GINTSTS, which ensures that the FIFO is full before clearing a global NAK handshake. Alternatively, the application can mask the IN token received when FIFO empty interrupt when clearing a global IN NAK handshake.
$00800000 constant OTG_FS_OTG_GINTSTS_HOST_RSTDET                   \ Reset detected interrupt In device mode, this interrupt is asserted when a reset is detected on the USB in partial power-down mode when the device is in suspend. Note: Only accessible in device mode.
$01000000 constant OTG_FS_OTG_GINTSTS_HOST_HPRTINT                  \ Host port interrupt The core sets this bit to indicate a change in port status of one of the OTG_HS controller ports in host mode. The application must read the OTG_HPRT register to determine the exact event that caused this interrupt. The application must clear the appropriate status bit in the OTG_HPRT register to clear this bit. Note: Only accessible in host mode.
$02000000 constant OTG_FS_OTG_GINTSTS_HOST_HCINT                    \ Host channels interrupt The core sets this bit to indicate that an interrupt is pending on one of the channels of the core (in host mode). The application must read the OTG_HAINT register to determine the exact number of the channel on which the interrupt occurred, and then read the corresponding OTG_HCINTx register to determine the exact cause of the interrupt. The application must clear the appropriate status bit in the OTG_HCINTx register to clear this bit. Note: Only accessible in host mode.
$04000000 constant OTG_FS_OTG_GINTSTS_HOST_PTXFE                    \ Periodic Tx FIFO empty Asserted when the periodic transmit FIFO is either half or completely empty and there is space for at least one entry to be written in the periodic request queue. The half or completely empty status is determined by the periodic Tx FIFO empty level bit in the OTG_GAHBCFG register (PTXFELVL bit in OTG_GAHBCFG). Note: Only accessible in host mode.
$08000000 constant OTG_FS_OTG_GINTSTS_HOST_LPMINT                   \ LPM interrupt In device mode, this interrupt is asserted when the device receives an LPM transaction and responds with a non-ERRORed response. In host mode, this interrupt is asserted when the device responds to an LPM transaction with a non-ERRORed response or when the host core has completed LPM transactions for the programmed number of times (RETRYCNT bit in OTG_GLPMCFG). This field is valid only if the LPMEN bit in OTG_GLPMCFG is set to 1.
$10000000 constant OTG_FS_OTG_GINTSTS_HOST_CIDSCHG                  \ Connector ID status change The core sets this bit when there is a change in connector ID status. Note: Accessible in both device and host modes.
$20000000 constant OTG_FS_OTG_GINTSTS_HOST_DISCINT                  \ Disconnect detected interrupt Asserted when a device disconnect is detected. Note: Only accessible in host mode.
$40000000 constant OTG_FS_OTG_GINTSTS_HOST_SRQINT                   \ Session request/new session detected interrupt In host mode, this interrupt is asserted when a session request is detected from the device. In device mode, this interrupt is asserted when V<sub>BUS</sub> is in the valid range for a B-peripheral device. Accessible in both device and host modes.
$80000000 constant OTG_FS_OTG_GINTSTS_HOST_WKUPINT                  \ Resume/remote wakeup detected interrupt Wakeup interrupt during suspend(L2) or LPM(L1) state. During suspend(L2): In device mode, this interrupt is asserted when a resume is detected on the USB. In host mode, this interrupt is asserted when a remote wakeup is detected on the USB. During LPM(L1): This interrupt is asserted for either host initiated resume or device initiated remote wakeup on USB. Note: Accessible in both device and host modes.


\
\ @brief OTG core interrupt register
\ Address offset: 0x14
\ Reset value: 0x04000020
\

$00000001 constant OTG_FS_OTG_GINTSTS_DEVICE_CMOD                   \ Current mode of operation Indicates the current mode. Note: Accessible in both host and device modes.
$00000002 constant OTG_FS_OTG_GINTSTS_DEVICE_MMIS                   \ Mode mismatch interrupt The core sets this bit when the application is trying to access: A host mode register, when the core is operating in device mode A device mode register, when the core is operating in host mode The register access is completed on the AHB with an OKAY response, but is ignored by the core internally and does not affect the operation of the core. Note: Accessible in both host and device modes.
$00000004 constant OTG_FS_OTG_GINTSTS_DEVICE_OTGINT                 \ OTG interrupt The core sets this bit to indicate an OTG protocol event. The application must read the OTG interrupt status (OTG_GOTGINT) register to determine the exact event that caused this interrupt. The application must clear the appropriate status bit in the OTG_GOTGINT register to clear this bit. Note: Accessible in both host and device modes.
$00000008 constant OTG_FS_OTG_GINTSTS_DEVICE_SOF                    \ Start of frame In host mode, the core sets this bit to indicate that an SOF (FS), or Keep-Alive (LS) is transmitted on the USB. The application must write a 1 to this bit to clear the interrupt. In device mode, in the core sets this bit to indicate that an SOF token has been received on the USB. The application can read the OTG_DSTS register to get the current frame number. This interrupt is seen only when the core is operating in FS. Note: This register may return '1' if read immediately after power on reset. If the register bit reads '1' immediately after power on reset it does not indicate that an SOF has been sent (in case of host mode) or SOF has been received (in case of device mode). The read value of this interrupt is valid only after a valid connection between host and device is established. If the bit is set after power on reset the application can clear the bit. Note: Accessible in both host and device modes.
$00000010 constant OTG_FS_OTG_GINTSTS_DEVICE_RXFLVL                 \ Rx FIFO non-empty Indicates that there is at least one packet pending to be read from the Rx FIFO. Note: Accessible in both host and device modes.
$00000020 constant OTG_FS_OTG_GINTSTS_DEVICE_NPTXFE                 \ Non-periodic Tx FIFO empty This interrupt is asserted when the non-periodic Tx FIFO is either half or completely empty, and there is space for at least one entry to be written to the non-periodic transmit request queue. The half or completely empty status is determined by the non-periodic Tx FIFO empty level bit in the OTG_GAHBCFG register (TXFELVL bit in OTG_GAHBCFG). Note: Accessible in host mode only.
$00000040 constant OTG_FS_OTG_GINTSTS_DEVICE_GINAKEFF               \ Global IN non-periodic NAK effective Indicates that the Set global non-periodic IN NAK bit in the OTG_DCTL register (SGINAK bit in OTG_DCTL), set by the application, has taken effect in the core. That is, the core has sampled the Global IN NAK bit set by the application. This bit can be cleared by clearing the Clear global non-periodic IN NAK bit in the OTG_DCTL register (CGINAK bit in OTG_DCTL). This interrupt does not necessarily mean that a NAK handshake is sent out on the USB. The STALL bit takes precedence over the NAK bit. Note: Only accessible in device mode.
$00000080 constant OTG_FS_OTG_GINTSTS_DEVICE_GONAKEFF               \ Global OUT NAK effective Indicates that the Set global OUT NAK bit in the OTG_DCTL register (SGONAK bit in OTG_DCTL), set by the application, has taken effect in the core. This bit can be cleared by writing the Clear global OUT NAK bit in the OTG_DCTL register (CGONAK bit in OTG_DCTL). Note: Only accessible in device mode.
$00000400 constant OTG_FS_OTG_GINTSTS_DEVICE_ESUSP                  \ Early suspend The core sets this bit to indicate that an Idle state has been detected on the USB for 3 ms. Note: Only accessible in device mode.
$00000800 constant OTG_FS_OTG_GINTSTS_DEVICE_USBSUSP                \ USB suspend The core sets this bit to indicate that a suspend was detected on the USB. The core enters the suspended state when there is no activity on the data lines for an extended period of time. Note: Only accessible in device mode.
$00001000 constant OTG_FS_OTG_GINTSTS_DEVICE_USBRST                 \ USB reset The core sets this bit to indicate that a reset is detected on the USB. Note: Only accessible in device mode.
$00002000 constant OTG_FS_OTG_GINTSTS_DEVICE_ENUMDNE                \ Enumeration done The core sets this bit to indicate that speed enumeration is complete. The application must read the OTG_DSTS register to obtain the enumerated speed. Note: Only accessible in device mode.
$00004000 constant OTG_FS_OTG_GINTSTS_DEVICE_ISOODRP                \ Isochronous OUT packet dropped interrupt The core sets this bit when it fails to write an isochronous OUT packet into the Rx FIFO because the Rx FIFO does not have enough space to accommodate a maximum size packet for the isochronous OUT endpoint. Note: Only accessible in device mode.
$00008000 constant OTG_FS_OTG_GINTSTS_DEVICE_EOPF                   \ End of periodic frame interrupt Indicates that the period specified in the periodic frame interval field of the OTG_DCFG register (PFIVL bit in OTG_DCFG) has been reached in the current frame. Note: Only accessible in device mode.
$00040000 constant OTG_FS_OTG_GINTSTS_DEVICE_IEPINT                 \ IN endpoint interrupt The core sets this bit to indicate that an interrupt is pending on one of the IN endpoints of the core (in device mode). The application must read the OTG_DAINT register to determine the exact number of the IN endpoint on which the interrupt occurred, and then read the corresponding OTG_DIEPINTx register to determine the exact cause of the interrupt. The application must clear the appropriate status bit in the corresponding OTG_DIEPINTx register to clear this bit. Note: Only accessible in device mode.
$00080000 constant OTG_FS_OTG_GINTSTS_DEVICE_OEPINT                 \ OUT endpoint interrupt The core sets this bit to indicate that an interrupt is pending on one of the OUT endpoints of the core (in device mode). The application must read the OTG_DAINT register to determine the exact number of the OUT endpoint on which the interrupt occurred, and then read the corresponding OTG_DOEPINTx register to determine the exact cause of the interrupt. The application must clear the appropriate status bit in the corresponding OTG_DOEPINTx register to clear this bit. Note: Only accessible in device mode.
$00100000 constant OTG_FS_OTG_GINTSTS_DEVICE_IISOIXFR               \ Incomplete isochronous IN transfer The core sets this interrupt to indicate that there is at least one isochronous IN endpoint on which the transfer is not completed in the current frame. This interrupt is asserted along with the End of periodic frame interrupt (EOPF) bit in this register. Note: Only accessible in device mode.
$00200000 constant OTG_FS_OTG_GINTSTS_DEVICE_INCOMPISOOUT           \ Incomplete isochronous OUT transfer In device mode, the core sets this interrupt to indicate that there is at least one isochronous OUT endpoint on which the transfer is not completed in the current frame. This interrupt is asserted along with the End of periodic frame interrupt (EOPF) bit in this register.
$00400000 constant OTG_FS_OTG_GINTSTS_DEVICE_DATAFSUSP              \ Data fetch suspended This interrupt is valid only in DMA mode. This interrupt indicates that the core has stopped fetching data for IN endpoints due to the unavailability of TxFIFO space or request queue space. This interrupt is used by the application for an endpoint mismatch algorithm. For example, after detecting an endpoint mismatch, the application: Sets a global nonperiodic IN NAK handshake Disables IN endpoints Flushes the FIFO Determines the token sequence from the IN token sequence learning queue Re-enables the endpoints Clears the global nonperiodic IN NAK handshake If the global nonperiodic IN NAK is cleared, the core has not yet fetched data for the IN endpoint, and the IN token is received: the core generates an IN token received when FIFO empty interrupt. The OTG then sends a NAK response to the host. To avoid this scenario, the application can check the FetSusp interrupt in OTG_GINTSTS, which ensures that the FIFO is full before clearing a global NAK handshake. Alternatively, the application can mask the IN token received when FIFO empty interrupt when clearing a global IN NAK handshake.
$00800000 constant OTG_FS_OTG_GINTSTS_DEVICE_RSTDET                 \ Reset detected interrupt In device mode, this interrupt is asserted when a reset is detected on the USB in partial power-down mode when the device is in suspend. Note: Only accessible in device mode.
$01000000 constant OTG_FS_OTG_GINTSTS_DEVICE_HPRTINT                \ Host port interrupt The core sets this bit to indicate a change in port status of one of the OTG_HS controller ports in host mode. The application must read the OTG_HPRT register to determine the exact event that caused this interrupt. The application must clear the appropriate status bit in the OTG_HPRT register to clear this bit. Note: Only accessible in host mode.
$02000000 constant OTG_FS_OTG_GINTSTS_DEVICE_HCINT                  \ Host channels interrupt The core sets this bit to indicate that an interrupt is pending on one of the channels of the core (in host mode). The application must read the OTG_HAINT register to determine the exact number of the channel on which the interrupt occurred, and then read the corresponding OTG_HCINTx register to determine the exact cause of the interrupt. The application must clear the appropriate status bit in the OTG_HCINTx register to clear this bit. Note: Only accessible in host mode.
$04000000 constant OTG_FS_OTG_GINTSTS_DEVICE_PTXFE                  \ Periodic Tx FIFO empty Asserted when the periodic transmit FIFO is either half or completely empty and there is space for at least one entry to be written in the periodic request queue. The half or completely empty status is determined by the periodic Tx FIFO empty level bit in the OTG_GAHBCFG register (PTXFELVL bit in OTG_GAHBCFG). Note: Only accessible in host mode.
$08000000 constant OTG_FS_OTG_GINTSTS_DEVICE_LPMINT                 \ LPM interrupt In device mode, this interrupt is asserted when the device receives an LPM transaction and responds with a non-ERRORed response. In host mode, this interrupt is asserted when the device responds to an LPM transaction with a non-ERRORed response or when the host core has completed LPM transactions for the programmed number of times (RETRYCNT bit in OTG_GLPMCFG). This field is valid only if the LPMEN bit in OTG_GLPMCFG is set to 1.
$10000000 constant OTG_FS_OTG_GINTSTS_DEVICE_CIDSCHG                \ Connector ID status change The core sets this bit when there is a change in connector ID status. Note: Accessible in both device and host modes.
$20000000 constant OTG_FS_OTG_GINTSTS_DEVICE_DISCINT                \ Disconnect detected interrupt Asserted when a device disconnect is detected. Note: Only accessible in host mode.
$40000000 constant OTG_FS_OTG_GINTSTS_DEVICE_SRQINT                 \ Session request/new session detected interrupt In host mode, this interrupt is asserted when a session request is detected from the device. In device mode, this interrupt is asserted when V<sub>BUS</sub> is in the valid range for a B-peripheral device. Accessible in both device and host modes.
$80000000 constant OTG_FS_OTG_GINTSTS_DEVICE_WKUPINT                \ Resume/remote wakeup detected interrupt Wakeup interrupt during suspend(L2) or LPM(L1) state. During suspend(L2): In device mode, this interrupt is asserted when a resume is detected on the USB. In host mode, this interrupt is asserted when a remote wakeup is detected on the USB. During LPM(L1): This interrupt is asserted for either host initiated resume or device initiated remote wakeup on USB. Note: Accessible in both device and host modes.


\
\ @brief OTG interrupt mask register
\ Address offset: 0x18
\ Reset value: 0x00000000
\

$00000002 constant OTG_FS_OTG_GINTMSK_HOST_MMISM                    \ Mode mismatch interrupt mask
$00000004 constant OTG_FS_OTG_GINTMSK_HOST_OTGINT                   \ OTG interrupt mask
$00000008 constant OTG_FS_OTG_GINTMSK_HOST_SOFM                     \ Start of frame mask
$00000010 constant OTG_FS_OTG_GINTMSK_HOST_RXFLVLM                  \ Receive FIFO non-empty mask
$00000020 constant OTG_FS_OTG_GINTMSK_HOST_NPTXFEM                  \ Non-periodic Tx FIFO empty mask
$00200000 constant OTG_FS_OTG_GINTMSK_HOST_IPXFRM                   \ Incomplete periodic transfer mask
$01000000 constant OTG_FS_OTG_GINTMSK_HOST_PRTIM                    \ Host port interrupt mask
$02000000 constant OTG_FS_OTG_GINTMSK_HOST_HCIM                     \ Host channels interrupt mask
$04000000 constant OTG_FS_OTG_GINTMSK_HOST_PTXFEM                   \ Periodic Tx FIFO empty mask
$08000000 constant OTG_FS_OTG_GINTMSK_HOST_LPMINTM                  \ LPM interrupt mask
$10000000 constant OTG_FS_OTG_GINTMSK_HOST_CIDSCHGM                 \ Connector ID status change mask
$20000000 constant OTG_FS_OTG_GINTMSK_HOST_DISCINT                  \ Disconnect detected interrupt mask
$40000000 constant OTG_FS_OTG_GINTMSK_HOST_SRQIM                    \ Session request/new session detected interrupt mask
$80000000 constant OTG_FS_OTG_GINTMSK_HOST_WUIM                     \ Resume/remote wakeup detected interrupt mask


\
\ @brief OTG interrupt mask register
\ Address offset: 0x18
\ Reset value: 0x00000000
\

$00000002 constant OTG_FS_OTG_GINTMSK_DEVICE_MMISM                  \ Mode mismatch interrupt mask
$00000004 constant OTG_FS_OTG_GINTMSK_DEVICE_OTGINT                 \ OTG interrupt mask
$00000008 constant OTG_FS_OTG_GINTMSK_DEVICE_SOFM                   \ Start of frame mask
$00000010 constant OTG_FS_OTG_GINTMSK_DEVICE_RXFLVLM                \ Receive FIFO non-empty mask
$00000040 constant OTG_FS_OTG_GINTMSK_DEVICE_GINAKEFFM              \ Global non-periodic IN NAK effective mask
$00000080 constant OTG_FS_OTG_GINTMSK_DEVICE_GONAKEFFM              \ Global OUT NAK effective mask
$00000400 constant OTG_FS_OTG_GINTMSK_DEVICE_ESUSPM                 \ Early suspend mask
$00000800 constant OTG_FS_OTG_GINTMSK_DEVICE_USBSUSPM               \ USB suspend mask
$00001000 constant OTG_FS_OTG_GINTMSK_DEVICE_USBRST                 \ USB reset mask
$00002000 constant OTG_FS_OTG_GINTMSK_DEVICE_ENUMDNEM               \ Enumeration done mask
$00004000 constant OTG_FS_OTG_GINTMSK_DEVICE_ISOODRPM               \ Isochronous OUT packet dropped interrupt mask
$00008000 constant OTG_FS_OTG_GINTMSK_DEVICE_EOPFM                  \ End of periodic frame interrupt mask
$00040000 constant OTG_FS_OTG_GINTMSK_DEVICE_IEPINT                 \ IN endpoints interrupt mask
$00080000 constant OTG_FS_OTG_GINTMSK_DEVICE_OEPINT                 \ OUT endpoints interrupt mask
$00100000 constant OTG_FS_OTG_GINTMSK_DEVICE_IISOIXFRM              \ Incomplete isochronous IN transfer mask
$00200000 constant OTG_FS_OTG_GINTMSK_DEVICE_IISOOXFRM              \ Incomplete isochronous OUT transfer mask
$00400000 constant OTG_FS_OTG_GINTMSK_DEVICE_FSUSPM                 \ Data fetch suspended mask
$00800000 constant OTG_FS_OTG_GINTMSK_DEVICE_RSTDETM                \ Reset detected interrupt mask
$08000000 constant OTG_FS_OTG_GINTMSK_DEVICE_LPMINTM                \ LPM interrupt mask
$10000000 constant OTG_FS_OTG_GINTMSK_DEVICE_CIDSCHGM               \ Connector ID status change mask
$40000000 constant OTG_FS_OTG_GINTMSK_DEVICE_SRQIM                  \ Session request/new session detected interrupt mask
$80000000 constant OTG_FS_OTG_GINTMSK_DEVICE_WUIM                   \ Resume/remote wakeup detected interrupt mask


\
\ @brief OTG receive status debug read register
\ Address offset: 0x1C
\ Reset value: 0x00000000
\

$0000000f constant OTG_FS_OTG_GRXSTSR_DEVICE_EPNUM                  \ Endpoint number Indicates the endpoint number to which the current received packet belongs.
$00007ff0 constant OTG_FS_OTG_GRXSTSR_DEVICE_BCNT                   \ Byte count Indicates the byte count of the received data packet.
$00018000 constant OTG_FS_OTG_GRXSTSR_DEVICE_DPID                   \ Data PID Indicates the data PID of the received OUT data packet
$001e0000 constant OTG_FS_OTG_GRXSTSR_DEVICE_PKTSTS                 \ Packet status Indicates the status of the received packet Others: Reserved
$01e00000 constant OTG_FS_OTG_GRXSTSR_DEVICE_FRMNUM                 \ Frame number This is the least significant 4 bits of the frame number in which the packet is received on the USB. This field is supported only when isochronous OUT endpoints are supported.
$08000000 constant OTG_FS_OTG_GRXSTSR_DEVICE_STSPHST                \ Status phase start Indicates the start of the status phase for a control write transfer. This bit is set along with the OUT transfer completed PKTSTS pattern.


\
\ @brief OTG receive status debug read register
\ Address offset: 0x1C
\ Reset value: 0x00000000
\

$0000000f constant OTG_FS_OTG_GRXSTSR_HOST_CHNUM                    \ Channel number Indicates the channel number to which the current received packet belongs.
$00007ff0 constant OTG_FS_OTG_GRXSTSR_HOST_BCNT                     \ Byte count Indicates the byte count of the received IN data packet.
$00018000 constant OTG_FS_OTG_GRXSTSR_HOST_DPID                     \ Data PID Indicates the data PID of the received packet
$001e0000 constant OTG_FS_OTG_GRXSTSR_HOST_PKTSTS                   \ Packet status Indicates the status of the received packet Others: Reserved


\
\ @brief OTG status read and pop registers
\ Address offset: 0x20
\ Reset value: 0x00000000
\

$0000000f constant OTG_FS_OTG_GRXSTSP_DEVICE_EPNUM                  \ Endpoint number Indicates the endpoint number to which the current received packet belongs.
$00007ff0 constant OTG_FS_OTG_GRXSTSP_DEVICE_BCNT                   \ Byte count Indicates the byte count of the received data packet.
$00018000 constant OTG_FS_OTG_GRXSTSP_DEVICE_DPID                   \ Data PID Indicates the data PID of the received OUT data packet
$001e0000 constant OTG_FS_OTG_GRXSTSP_DEVICE_PKTSTS                 \ Packet status Indicates the status of the received packet Others: Reserved
$01e00000 constant OTG_FS_OTG_GRXSTSP_DEVICE_FRMNUM                 \ Frame number This is the least significant 4 bits of the frame number in which the packet is received on the USB. This field is supported only when isochronous OUT endpoints are supported.
$08000000 constant OTG_FS_OTG_GRXSTSP_DEVICE_STSPHST                \ Status phase start Indicates the start of the status phase for a control write transfer. This bit is set along with the OUT transfer completed PKTSTS pattern.


\
\ @brief OTG status read and pop registers
\ Address offset: 0x20
\ Reset value: 0x00000000
\

$0000000f constant OTG_FS_OTG_GRXSTSP_HOST_CHNUM                    \ Channel number Indicates the channel number to which the current received packet belongs.
$00007ff0 constant OTG_FS_OTG_GRXSTSP_HOST_BCNT                     \ Byte count Indicates the byte count of the received IN data packet.
$00018000 constant OTG_FS_OTG_GRXSTSP_HOST_DPID                     \ Data PID Indicates the data PID of the received packet
$001e0000 constant OTG_FS_OTG_GRXSTSP_HOST_PKTSTS                   \ Packet status Indicates the status of the received packet Others: Reserved


\
\ @brief OTG receive FIFO size register
\ Address offset: 0x24
\ Reset value: 0x00000400
\

$0000ffff constant OTG_FS_OTG_GRXFSIZ_RXFD                          \ Rx FIFO depth This value is in terms of 32-bit words. Maximum value is 1024 Programmed values must respect the available FIFO memory allocation and must not exceed the power-on value.


\
\ @brief OTG host non-periodic transmit FIFO size register [alternate]
\ Address offset: 0x28
\ Reset value: 0x02000200
\

$0000ffff constant OTG_FS_OTG_HNPTXFSIZ_HOST_NPTXFSA                \ Non-periodic transmit RAM start address This field configures the memory start address for non-periodic transmit FIFO RAM.
$ffff0000 constant OTG_FS_OTG_HNPTXFSIZ_HOST_NPTXFD                 \ Non-periodic Tx FIFO depth This value is in terms of 32-bit words. Minimum value is 16 Programmed values must respect the available FIFO memory allocation and must not exceed the power-on value.


\
\ @brief OTG host non-periodic transmit FIFO size register [alternate]
\ Address offset: 0x28
\ Reset value: 0x02000200
\

$0000ffff constant OTG_FS_OTG_HNPTXFSIZ_DEVICE_TX0FSA               \ Endpoint 0 transmit RAM start address This field configures the memory start address for the endpoint 0 transmit FIFO RAM.
$ffff0000 constant OTG_FS_OTG_HNPTXFSIZ_DEVICE_TX0FD                \ Endpoint 0 Tx FIFO depth This value is in terms of 32-bit words. Minimum value is 16 Programmed values must respect the available FIFO memory allocation and must not exceed the power-on value.


\
\ @brief OTG non-periodic transmit FIFO/queue status register
\ Address offset: 0x2C
\ Reset value: 0x00080400
\

$0000ffff constant OTG_FS_OTG_HNPTXSTS_NPTXFSAV                     \ Non-periodic Tx FIFO space available Indicates the amount of free space available in the non-periodic Tx FIFO. Values are in terms of 32-bit words. n: n words available (where 0 UNDER OR EQUAL n UNDER OR EQUAL 512) Others: Reserved
$00ff0000 constant OTG_FS_OTG_HNPTXSTS_NPTQXSAV                     \ Non-periodic transmit request queue space available Indicates the amount of free space available in the non-periodic transmit request queue. This queue holds both IN and OUT requests. n: n locations available (0 UNDER OR EQUAL n UNDER OR EQUAL 8) Others: Reserved
$7f000000 constant OTG_FS_OTG_HNPTXSTS_NPTXQTOP                     \ Top of the non-periodic transmit request queue Entry in the non-periodic Tx request queue that is currently being processed by the MAC. Bits 30:27: Channel/endpoint number Bits 26:25: XXXX00X: IN/OUT token XXXX01X: Zero-length transmit packet (device IN/host OUT) XXXX11X: Channel halt command Bit 24: Terminate (last entry for selected channel/endpoint)


\
\ @brief OTG general core configuration register
\ Address offset: 0x38
\ Reset value: 0x00000000
\

$00000001 constant OTG_FS_OTG_GCCFG_CHGDET                          \ Charger detection, result of the current mode (primary or secondary).
$00000002 constant OTG_FS_OTG_GCCFG_FSVPLUS                         \ Single-Ended DP indicator This bit gives the voltage level on DP (also result of the comparison with V<sub>LGC</sub> threshold as defined in BC v1.2 standard).
$00000004 constant OTG_FS_OTG_GCCFG_FSVMINUS                        \ Single-Ended DM indicator This bit gives the voltage level on DM (also result of the comparison with V<sub>LGC</sub> threshold as defined in BC v1.2 standard).
$00000008 constant OTG_FS_OTG_GCCFG_SESSVLD                         \ VBUS session indicator Indicates if VBUS is above VBUS session threshold.
$00010000 constant OTG_FS_OTG_GCCFG_HCDPEN                          \ Host CDP behavior enable
$00020000 constant OTG_FS_OTG_GCCFG_HCDPDETEN                       \ Host CDP port voltage detector enable on DP
$00040000 constant OTG_FS_OTG_GCCFG_HVDMSRCEN                       \ Host CDP port Voltage source enable on DM
$00080000 constant OTG_FS_OTG_GCCFG_DCDEN                           \ Data Contact Detection enable
$00100000 constant OTG_FS_OTG_GCCFG_PDEN                            \ Primary detection enable
$00200000 constant OTG_FS_OTG_GCCFG_VBDEN                           \ VBUS detection enable Enables VBUS Sensing Comparators in order to detect VBUS presence and/or perform OTG operation.
$00400000 constant OTG_FS_OTG_GCCFG_SDEN                            \ Secondary detection enable
$00800000 constant OTG_FS_OTG_GCCFG_VBVALOVAL                       \ Software override value of the VBUS B-session detection
$01000000 constant OTG_FS_OTG_GCCFG_VBVALOVEN                       \ Enables a software override of the VBUS B-session detection.
$02000000 constant OTG_FS_OTG_GCCFG_FORCEHOSTPD                     \ Force host mode pull-downs If the ID pin functions are enabled, the host mode pull-downs on DP and DM activate automatically. However, whenever that is not the case, yet host mode is required, this bit must be used to force the pull-downs active.


\
\ @brief OTG core ID register
\ Address offset: 0x3C
\ Reset value: 0x00005000
\

$00000000 constant OTG_FS_OTG_CID_PRODUCT_ID                        \ Product ID field Application-programmable ID field.


\
\ @brief OTG core LPM configuration register
\ Address offset: 0x54
\ Reset value: 0x00000000
\

$00000001 constant OTG_FS_OTG_GLPMCFG_LPMEN                         \ LPM support enable The application uses this bit to control the OTG_HS core LPM capabilities. If the core operates as a non-LPM-capable host, it cannot request the connected device or hub to activate LPM mode. If the core operates as a non-LPM-capable device, it cannot respond to any LPM transactions.
$00000002 constant OTG_FS_OTG_GLPMCFG_LPMACK                        \ LPM token acknowledge enable Handshake response to LPM token preprogrammed by device application software. Even though ACK is preprogrammed, the core device responds with ACK only on successful LPM transaction. The LPM transaction is successful if: No PID/CRC5 errors in either EXT token or LPM token (else ERROR) Valid bLinkState = 0001B (L1) received in LPM transaction (else STALL) No data pending in transmit queue (else NYET). The preprogrammed software bit is over-ridden for response to LPM token when: The received bLinkState is not L1 (STALL response), or An error is detected in either of the LPM token packets because of corruption (ERROR response). Note: Accessible only in device mode.
$0000003c constant OTG_FS_OTG_GLPMCFG_BESL                          \ Best effort service latency Host mode
$00000040 constant OTG_FS_OTG_GLPMCFG_REMWAKE                       \ bRemoteWake value Host mode: The value of remote wake up to be sent in the wIndex field of LPM transaction. Device mode (read-only): This field is updated with the received LPM token bRemoteWake bmAttribute when an ACK, NYET, or STALL response is sent to an LPM transaction.
$00000080 constant OTG_FS_OTG_GLPMCFG_L1SSEN                        \ L1 Shallow Sleep enable Enables suspending the PHY in L1 Sleep mode. For maximum power saving during L1 Sleep mode, this bit should be set to '1' by application SW in all the cases.
$00000f00 constant OTG_FS_OTG_GLPMCFG_BESLTHRS                      \ BESL threshold
$00001000 constant OTG_FS_OTG_GLPMCFG_L1DSEN                        \ L1 deep sleep enable Enables suspending the PHY in L1 Sleep mode. For maximum power saving during L1 Sleep mode, this bit should be set to '1' by application SW in all the cases.
$00006000 constant OTG_FS_OTG_GLPMCFG_LPMRSP                        \ LPM response Device mode: The response of the core to LPM transaction received is reflected in these two bits. Host mode: Handshake response received from local device for LPM transaction
$00008000 constant OTG_FS_OTG_GLPMCFG_SLPSTS                        \ Port sleep status Device mode: This bit is set as long as a Sleep condition is present on the USB bus. The core enters the Sleep state when an ACK response is sent to an LPM transaction and the T<sub>L1TokenRetry</sub> timer has expired. To stop the PHY clock, the application must set the STPPCLK bit in OTG_PCGCCTL, which asserts the PHY suspend input signal. The application must rely on SLPSTS and not ACK in LPMRSP to confirm transition into sleep. The core comes out of sleep: When there is any activity on the USB linestate When the application writes to the RWUSIG bit in OTG_DCTL or when the application resets or soft-disconnects the device. Host mode: The host transitions to Sleep (L1) state as a side-effect of a successful LPM transaction by the core to the local port with ACK response from the device. The read value of this bit reflects the current Sleep status of the port. The core clears this bit after: The core detects a remote L1 wakeup signal, The application sets the PRST bit or the PRES bit in the OTG_HPRT register, or The application sets the L1Resume/ remote wakeup detected interrupt bit or disconnect detected interrupt bit in the core interrupt register (WKUPINT or DISCINT bit in OTG_GINTSTS, respectively).
$00010000 constant OTG_FS_OTG_GLPMCFG_L1RSMOK                       \ Sleep state resume OK
$001e0000 constant OTG_FS_OTG_GLPMCFG_LPMCHIDX                      \ LPM Channel Index The channel number on which the LPM transaction has to be applied while sending an LPM transaction to the local device. Based on the LPM channel index, the core automatically inserts the device address and endpoint number programmed in the corresponding channel into the LPM transaction. Note: Accessible only in host mode.
$00e00000 constant OTG_FS_OTG_GLPMCFG_LPMRCNT                       \ LPM retry count When the device gives an ERROR response, this is the number of additional LPM retries that the host performs until a valid device response (STALL, NYET, or ACK) is received. Note: Accessible only in host mode.
$01000000 constant OTG_FS_OTG_GLPMCFG_SNDLPM                        \ Send LPM transaction When the application software sets this bit, an LPM transaction containing two tokens, EXT and LPM is sent. The hardware clears this bit once a valid response (STALL, NYET, or ACK) is received from the device or the core has finished transmitting the programmed number of LPM retries. Note: This bit must be set only when the host is connected to a local port. Note: Accessible only in host mode.
$0e000000 constant OTG_FS_OTG_GLPMCFG_LPMRCNTSTS                    \ LPM retry count status Number of LPM host retries still remaining to be transmitted for the current LPM sequence. Note: Accessible only in host mode.
$10000000 constant OTG_FS_OTG_GLPMCFG_ENBESL                        \ Enable best effort service latency This bit enables the BESL feature as defined in the LPM errata: USB 2.0 Link Power Management Addendum Engineering Change Notice to the USB 2.0 specification, July 16, 2007 Errata for USB 2.0 ECN: Link Power Management (LPM) - 7/2007 Note: Only the updated behavior (described in LPM Errata) is considered in this document and so the ENBESL bit should be set to '1' by application SW.


\
\ @brief OTG host periodic transmit FIFO size register
\ Address offset: 0x100
\ Reset value: 0x04000800
\

$0000ffff constant OTG_FS_OTG_HPTXFSIZ_PTXSA                        \ Host periodic Tx FIFO start address This field configures the memory start address for periodic transmit FIFO RAM.
$ffff0000 constant OTG_FS_OTG_HPTXFSIZ_PTXFSIZ                      \ Host periodic Tx FIFO depth This value is in terms of 32-bit words. Minimum value is 16


\
\ @brief OTG device IN endpoint transmit FIFO 1 size register
\ Address offset: 0x104
\ Reset value: 0x02000400
\

$0000ffff constant OTG_FS_OTG_DIEPTXF1_INEPTXSA                     \ IN endpoint FIFOx transmit RAM start address This field contains the memory start address for IN endpoint transmit FIFOx. The address must be aligned with a 32-bit memory location.
$ffff0000 constant OTG_FS_OTG_DIEPTXF1_INEPTXFD                     \ IN endpoint Tx FIFO depth This value is in terms of 32-bit words. Minimum value is 16


\
\ @brief OTG device IN endpoint transmit FIFO 2 size register
\ Address offset: 0x108
\ Reset value: 0x02000600
\

$0000ffff constant OTG_FS_OTG_DIEPTXF2_INEPTXSA                     \ IN endpoint FIFOx transmit RAM start address This field contains the memory start address for IN endpoint transmit FIFOx. The address must be aligned with a 32-bit memory location.
$ffff0000 constant OTG_FS_OTG_DIEPTXF2_INEPTXFD                     \ IN endpoint Tx FIFO depth This value is in terms of 32-bit words. Minimum value is 16


\
\ @brief OTG device IN endpoint transmit FIFO 3 size register
\ Address offset: 0x10C
\ Reset value: 0x02000800
\

$0000ffff constant OTG_FS_OTG_DIEPTXF3_INEPTXSA                     \ IN endpoint FIFOx transmit RAM start address This field contains the memory start address for IN endpoint transmit FIFOx. The address must be aligned with a 32-bit memory location.
$ffff0000 constant OTG_FS_OTG_DIEPTXF3_INEPTXFD                     \ IN endpoint Tx FIFO depth This value is in terms of 32-bit words. Minimum value is 16


\
\ @brief OTG device IN endpoint transmit FIFO 4 size register
\ Address offset: 0x110
\ Reset value: 0x02000A00
\

$0000ffff constant OTG_FS_OTG_DIEPTXF4_INEPTXSA                     \ IN endpoint FIFOx transmit RAM start address This field contains the memory start address for IN endpoint transmit FIFOx. The address must be aligned with a 32-bit memory location.
$ffff0000 constant OTG_FS_OTG_DIEPTXF4_INEPTXFD                     \ IN endpoint Tx FIFO depth This value is in terms of 32-bit words. Minimum value is 16


\
\ @brief OTG device IN endpoint transmit FIFO 5 size register
\ Address offset: 0x114
\ Reset value: 0x02000C00
\

$0000ffff constant OTG_FS_OTG_DIEPTXF5_INEPTXSA                     \ IN endpoint FIFOx transmit RAM start address This field contains the memory start address for IN endpoint transmit FIFOx. The address must be aligned with a 32-bit memory location.
$ffff0000 constant OTG_FS_OTG_DIEPTXF5_INEPTXFD                     \ IN endpoint Tx FIFO depth This value is in terms of 32-bit words. Minimum value is 16


\
\ @brief OTG device IN endpoint transmit FIFO 6 size register
\ Address offset: 0x118
\ Reset value: 0x02000E00
\

$0000ffff constant OTG_FS_OTG_DIEPTXF6_INEPTXSA                     \ IN endpoint FIFOx transmit RAM start address This field contains the memory start address for IN endpoint transmit FIFOx. The address must be aligned with a 32-bit memory location.
$ffff0000 constant OTG_FS_OTG_DIEPTXF6_INEPTXFD                     \ IN endpoint Tx FIFO depth This value is in terms of 32-bit words. Minimum value is 16


\
\ @brief OTG device IN endpoint transmit FIFO 7 size register
\ Address offset: 0x11C
\ Reset value: 0x02001000
\

$0000ffff constant OTG_FS_OTG_DIEPTXF7_INEPTXSA                     \ IN endpoint FIFOx transmit RAM start address This field contains the memory start address for IN endpoint transmit FIFOx. The address must be aligned with a 32-bit memory location.
$ffff0000 constant OTG_FS_OTG_DIEPTXF7_INEPTXFD                     \ IN endpoint Tx FIFO depth This value is in terms of 32-bit words. Minimum value is 16


\
\ @brief OTG device IN endpoint transmit FIFO 8 size register
\ Address offset: 0x120
\ Reset value: 0x02001200
\

$0000ffff constant OTG_FS_OTG_DIEPTXF8_INEPTXSA                     \ IN endpoint FIFOx transmit RAM start address This field contains the memory start address for IN endpoint transmit FIFOx. The address must be aligned with a 32-bit memory location.
$ffff0000 constant OTG_FS_OTG_DIEPTXF8_INEPTXFD                     \ IN endpoint Tx FIFO depth This value is in terms of 32-bit words. Minimum value is 16


\
\ @brief OTG host configuration register
\ Address offset: 0x400
\ Reset value: 0x00000000
\

$00000003 constant OTG_FS_OTG_HCFG_FSLSPCS                          \ FS/LS PHY clock select Others: Reserved Note: The FSLSPCS must be set on a connection event according to the speed of the connected device (after changing this bit, a software reset must be performed).
$00000004 constant OTG_FS_OTG_HCFG_FSLSS                            \ FS- and LS-only support The application uses this bit to control the cores enumeration speed. Using this bit, the application can make the core enumerate as an FS host, even if the connected device supports HS traffic. Do not make changes to this field after initial programming.


\
\ @brief OTG host frame interval register
\ Address offset: 0x404
\ Reset value: 0x0000EA60
\

$0000ffff constant OTG_FS_OTG_HFIR_FRIVL                            \ Frame interval
$00010000 constant OTG_FS_OTG_HFIR_RLDCTRL                          \ Reload control This bit allows dynamic reloading of the HFIR register during run time. This bit needs to be programmed during initial configuration and its value must not be changed during run time. RLDCTRL = 0 is not recommended.


\
\ @brief OTG host frame number/frame time remaining register
\ Address offset: 0x408
\ Reset value: 0x00003FFF
\

$0000ffff constant OTG_FS_OTG_HFNUM_FRNUM                           \ Frame number This field increments when a new SOF is transmitted on the USB, and is cleared to 0 when it reaches 0x3FFF.
$ffff0000 constant OTG_FS_OTG_HFNUM_FTREM                           \ Frame time remaining Indicates the amount of time remaining in the current frame, in terms of PHY clocks. This field decrements on each PHY clock. When it reaches zero, this field is reloaded with the value in the Frame interval register and a new SOF is transmitted on the USB.


\
\ @brief OTG_Host periodic transmit FIFO/queue status register
\ Address offset: 0x410
\ Reset value: 0x00080100
\

$0000ffff constant OTG_FS_OTG_HPTXSTS_PTXFSAVL                      \ Periodic transmit data FIFO space available Indicates the number of free locations available to be written to in the periodic Tx FIFO. Values are in terms of 32-bit words n: n words available (where 0 UNDER OR EQUAL n UNDER OR EQUAL PTXFD) Others: Reserved
$00ff0000 constant OTG_FS_OTG_HPTXSTS_PTXQSAV                       \ Periodic transmit request queue space available Indicates the number of free locations available to be written in the periodic transmit request queue. This queue holds both IN and OUT requests. n: n locations available (0 UNDER OR EQUAL n UNDER OR EQUAL 8) Others: Reserved
$ff000000 constant OTG_FS_OTG_HPTXSTS_PTXQTOP                       \ Top of the periodic transmit request queue This indicates the entry in the periodic Tx request queue that is currently being processed by the MAC. This register is used for debugging. Bit 31: Odd/Even frame 0XXXXXXX: send in even frame 1XXXXXXX: send in odd frame Bits 30:27: Channel/endpoint number Bits 26:25: Type XXXXX00X: IN/OUT XXXXX01X: Zero-length packet XXXXX11X: Disable channel command Bit 24: Terminate (last entry for the selected channel/endpoint)


\
\ @brief OTG host all channels interrupt register
\ Address offset: 0x414
\ Reset value: 0x00000000
\

$0000ffff constant OTG_FS_OTG_HAINT_HAINT                           \ Channel interrupts One bit per channel: Bit 0 for Channel 0, bit 15 for Channel 15


\
\ @brief OTG host all channels interrupt mask register
\ Address offset: 0x418
\ Reset value: 0x00000000
\

$0000ffff constant OTG_FS_OTG_HAINTMSK_HAINTM                       \ Channel interrupt mask One bit per channel: Bit 0 for channel 0, bit 15 for channel 15


\
\ @brief OTG host port control and status register
\ Address offset: 0x440
\ Reset value: 0x00000000
\

$00000001 constant OTG_FS_OTG_HPRT_PCSTS                            \ Port connect status
$00000002 constant OTG_FS_OTG_HPRT_PCDET                            \ Port connect detected The core sets this bit when a device connection is detected to trigger an interrupt to the application using the host port interrupt bit in the core interrupt register (HPRTINT bit in OTG_GINTSTS). The application must write a 1 to this bit to clear the interrupt.
$00000004 constant OTG_FS_OTG_HPRT_PENA                             \ Port enable A port is enabled only by the core after a reset sequence, and is disabled by an overcurrent condition, a disconnect condition, or by the application clearing this bit. The application cannot set this bit by a register write. It can only clear it to disable the port. This bit does not trigger any interrupt to the application.
$00000008 constant OTG_FS_OTG_HPRT_PENCHNG                          \ Port enable/disable change The core sets this bit when the status of the port enable bit 2 in this register changes.
$00000010 constant OTG_FS_OTG_HPRT_POCA                             \ Port overcurrent active Indicates the overcurrent condition of the port.
$00000020 constant OTG_FS_OTG_HPRT_POCCHNG                          \ Port overcurrent change The core sets this bit when the status of the port overcurrent active bit (bit 4) in this register changes.
$00000040 constant OTG_FS_OTG_HPRT_PRES                             \ Port resume The application sets this bit to drive resume signaling on the port. The core continues to drive the resume signal until the application clears this bit. If the core detects a USB remote wakeup sequence, as indicated by the port resume/remote wakeup detected interrupt bit of the core interrupt register (WKUPINT bit in OTG_GINTSTS), the core starts driving resume signaling without application intervention and clears this bit when it detects a disconnect condition. The read value of this bit indicates whether the core is currently driving resume signaling. When LPM is enabled and the core is in L1 state, the behavior of this bit is as follow: 1. The application sets this bit to drive resume signaling on the port. 2. The core continues to drive the resume signal until a predetermined time specified in BESLTHRS[3:0] field of OTG_GLPMCFG register. 3. If the core detects a USB remote wakeup sequence, as indicated by the port L1Resume/Remote L1Wakeup detected interrupt bit of the core interrupt register (WKUPINT in OTG_GINTSTS), the core starts driving resume signaling without application intervention and clears this bit at the end of resume.This bit can be set or cleared by both the core and the application. This bit is cleared by the core even if there is no device connected to the host.
$00000080 constant OTG_FS_OTG_HPRT_PSUSP                            \ Port suspend The application sets this bit to put this port in suspend mode. The core only stops sending SOFs when this is set. To stop the PHY clock, the application must set the port clock stop bit, which asserts the suspend input pin of the PHY. The read value of this bit reflects the current suspend status of the port. This bit is cleared by the core after a remote wakeup signal is detected or the application sets the port reset bit or port resume bit in this register or the resume/remote wakeup detected interrupt bit or disconnect detected interrupt bit in the core interrupt register (WKUPINT or DISCINT in OTG_GINTSTS, respectively).
$00000100 constant OTG_FS_OTG_HPRT_PRST                             \ Port reset When the application sets this bit, a reset sequence is started on this port. The application must time the reset period and clear this bit after the reset sequence is complete. The application must leave this bit set for a minimum duration of at least 10 ms to start a reset on the port. The application can leave it set for another 10 ms in addition to the required minimum duration, before clearing the bit, even though there is no maximum limit set by the USB standard. High speed: 50 ms Full speed/Low speed: 10 ms
$00000c00 constant OTG_FS_OTG_HPRT_PLSTS                            \ Port line status Indicates the current logic level USB data lines Bit 10: Logic level of OTG_DP Bit 11: Logic level of OTG_DM
$00001000 constant OTG_FS_OTG_HPRT_PPWR                             \ Port power The application uses this field to control power to this port, and the core clears this bit on an overcurrent condition.
$0001e000 constant OTG_FS_OTG_HPRT_PTCTL                            \ Port test control The application writes a nonzero value to this field to put the port into a Test mode, and the corresponding pattern is signaled on the port. Others: Reserved
$00060000 constant OTG_FS_OTG_HPRT_PSPD                             \ Port speed Indicates the speed of the device attached to this port.


\
\ @brief OTG host channel 0 characteristics register
\ Address offset: 0x500
\ Reset value: 0x00000000
\

$000007ff constant OTG_FS_OTG_HCCHAR0_MPSIZ                         \ Maximum packet size Indicates the maximum packet size of the associated endpoint.
$00007800 constant OTG_FS_OTG_HCCHAR0_EPNUM                         \ Endpoint number Indicates the endpoint number on the device serving as the data source or sink.
$00008000 constant OTG_FS_OTG_HCCHAR0_EPDIR                         \ Endpoint direction Indicates whether the transaction is IN or OUT.
$00020000 constant OTG_FS_OTG_HCCHAR0_LSDEV                         \ Low-speed device This field is set by the application to indicate that this channel is communicating to a low-speed device.
$000c0000 constant OTG_FS_OTG_HCCHAR0_EPTYP                         \ Endpoint type Indicates the transfer type selected.
$00300000 constant OTG_FS_OTG_HCCHAR0_MCNT                          \ Multicount This field indicates to the host the number of transactions that must be executed per frame for this periodic endpoint. For non-periodic transfers, this field is not used Note: This field must be set to at least 01.
$1fc00000 constant OTG_FS_OTG_HCCHAR0_DAD                           \ Device address This field selects the specific device serving as the data source or sink.
$20000000 constant OTG_FS_OTG_HCCHAR0_ODDFRM                        \ Odd frame This field is set (reset) by the application to indicate that the OTG host must perform a transfer in an odd frame. This field is applicable for only periodic (isochronous and interrupt) transactions.
$40000000 constant OTG_FS_OTG_HCCHAR0_CHDIS                         \ Channel disable The application sets this bit to stop transmitting/receiving data on a channel, even before the transfer for that channel is complete. The application must wait for the Channel disabled interrupt before treating the channel as disabled.
$80000000 constant OTG_FS_OTG_HCCHAR0_CHENA                         \ Channel enable This field is set by the application and cleared by the OTG host.


\
\ @brief OTG host channel 0 split control register
\ Address offset: 0x504
\ Reset value: 0x00000000
\

$0000007f constant OTG_FS_OTG_HCSPLT0_PRTADDR                       \ Port address This field is the port number of the recipient transaction translator.
$00003f80 constant OTG_FS_OTG_HCSPLT0_HUBADDR                       \ Hub address This field holds the device address of the transaction translators hub.
$0000c000 constant OTG_FS_OTG_HCSPLT0_XACTPOS                       \ Transaction position This field is used to determine whether to send all, first, middle, or last payloads with each OUT transaction.
$00010000 constant OTG_FS_OTG_HCSPLT0_COMPLSPLT                     \ Do complete split The application sets this bit to request the OTG host to perform a complete split transaction.
$80000000 constant OTG_FS_OTG_HCSPLT0_SPLITEN                       \ Split enable The application sets this bit to indicate that this channel is enabled to perform split transactions.


\
\ @brief OTG host channel 0 interrupt register
\ Address offset: 0x508
\ Reset value: 0x00000000
\

$00000001 constant OTG_FS_OTG_HCINT0_XFRC                           \ Transfer completed. Transfer completed normally without any errors.
$00000002 constant OTG_FS_OTG_HCINT0_CHH                            \ Channel halted. Indicates the transfer completed abnormally either because of any USB transaction error or in response to disable request by the application.
$00000004 constant OTG_FS_OTG_HCINT0_AHBERR                         \ AHB error This error is generated only in Internal DMA mode when an AHB error occurs during an AHB read/write operation. The application can read the corresponding DMA channel address register to get the error address.
$00000008 constant OTG_FS_OTG_HCINT0_STALL                          \ STALL response received interrupt.
$00000010 constant OTG_FS_OTG_HCINT0_NAK                            \ NAK response received interrupt.
$00000020 constant OTG_FS_OTG_HCINT0_ACK                            \ ACK response received/transmitted interrupt.
$00000040 constant OTG_FS_OTG_HCINT0_NYET                           \ Not yet ready response received interrupt.
$00000080 constant OTG_FS_OTG_HCINT0_TXERR                          \ Transaction error. Indicates one of the following errors occurred on the USB. CRC check failure Timeout Bit stuff error False EOP
$00000100 constant OTG_FS_OTG_HCINT0_BBERR                          \ Babble error.
$00000200 constant OTG_FS_OTG_HCINT0_FRMOR                          \ Frame overrun.
$00000400 constant OTG_FS_OTG_HCINT0_DTERR                          \ Data toggle error.


\
\ @brief OTG host channel 0 interrupt mask register
\ Address offset: 0x50C
\ Reset value: 0x00000000
\

$00000001 constant OTG_FS_OTG_HCINTMSK0_XFRCM                       \ Transfer completed mask
$00000002 constant OTG_FS_OTG_HCINTMSK0_CHHM                        \ Channel halted mask
$00000004 constant OTG_FS_OTG_HCINTMSK0_AHBERRM                     \ AHB error.
$00000008 constant OTG_FS_OTG_HCINTMSK0_STALLM                      \ STALL response received interrupt mask.
$00000010 constant OTG_FS_OTG_HCINTMSK0_NAKM                        \ NAK response received interrupt mask.
$00000020 constant OTG_FS_OTG_HCINTMSK0_ACKM                        \ ACK response received/transmitted interrupt mask.
$00000040 constant OTG_FS_OTG_HCINTMSK0_NYET                        \ response received interrupt mask.
$00000080 constant OTG_FS_OTG_HCINTMSK0_TXERRM                      \ Transaction error mask.
$00000100 constant OTG_FS_OTG_HCINTMSK0_BBERRM                      \ Babble error mask.
$00000200 constant OTG_FS_OTG_HCINTMSK0_FRMORM                      \ Frame overrun mask.
$00000400 constant OTG_FS_OTG_HCINTMSK0_DTERRM                      \ Data toggle error mask.


\
\ @brief OTG host channel 0 transfer size register
\ Address offset: 0x510
\ Reset value: 0x00000000
\

$0007ffff constant OTG_FS_OTG_HCTSIZ0_XFRSIZ                        \ Transfer size For an OUT, this field is the number of data bytes the host sends during the transfer. For an IN, this field is the buffer size that the application has reserved for the transfer. The application is expected to program this field as an integer multiple of the maximum packet size for IN transactions (periodic and non-periodic).
$1ff80000 constant OTG_FS_OTG_HCTSIZ0_PKTCNT                        \ Packet count This field is programmed by the application with the expected number of packets to be transmitted (OUT) or received (IN). The host decrements this count on every successful transmission or reception of an OUT/IN packet. Once this count reaches zero, the application is interrupted to indicate normal completion.
$60000000 constant OTG_FS_OTG_HCTSIZ0_DPID                          \ Data PID The application programs this field with the type of PID to use for the initial transaction. The host maintains this field for the rest of the transfer.
$80000000 constant OTG_FS_OTG_HCTSIZ0_DOPNG                         \ Do Ping This bit is used only for OUT transfers. Setting this field to 1 directs the host to do PING protocol. Note: Do not set this bit for IN transfers. If this bit is set for IN transfers, it disables the channel.


\
\ @brief OTG host channel 0 DMA address register
\ Address offset: 0x514
\ Reset value: 0x00000000
\

$00000000 constant OTG_FS_OTG_HCDMA0_DMAADDR                        \ DMA address This field holds the start address in the external memory from which the data for the endpoint must be fetched or to which it must be stored. This register is incremented on every AHB transaction.


\
\ @brief OTG host channel 1 characteristics register
\ Address offset: 0x520
\ Reset value: 0x00000000
\

$000007ff constant OTG_FS_OTG_HCCHAR1_MPSIZ                         \ Maximum packet size Indicates the maximum packet size of the associated endpoint.
$00007800 constant OTG_FS_OTG_HCCHAR1_EPNUM                         \ Endpoint number Indicates the endpoint number on the device serving as the data source or sink.
$00008000 constant OTG_FS_OTG_HCCHAR1_EPDIR                         \ Endpoint direction Indicates whether the transaction is IN or OUT.
$00020000 constant OTG_FS_OTG_HCCHAR1_LSDEV                         \ Low-speed device This field is set by the application to indicate that this channel is communicating to a low-speed device.
$000c0000 constant OTG_FS_OTG_HCCHAR1_EPTYP                         \ Endpoint type Indicates the transfer type selected.
$00300000 constant OTG_FS_OTG_HCCHAR1_MCNT                          \ Multicount This field indicates to the host the number of transactions that must be executed per frame for this periodic endpoint. For non-periodic transfers, this field is not used Note: This field must be set to at least 01.
$1fc00000 constant OTG_FS_OTG_HCCHAR1_DAD                           \ Device address This field selects the specific device serving as the data source or sink.
$20000000 constant OTG_FS_OTG_HCCHAR1_ODDFRM                        \ Odd frame This field is set (reset) by the application to indicate that the OTG host must perform a transfer in an odd frame. This field is applicable for only periodic (isochronous and interrupt) transactions.
$40000000 constant OTG_FS_OTG_HCCHAR1_CHDIS                         \ Channel disable The application sets this bit to stop transmitting/receiving data on a channel, even before the transfer for that channel is complete. The application must wait for the Channel disabled interrupt before treating the channel as disabled.
$80000000 constant OTG_FS_OTG_HCCHAR1_CHENA                         \ Channel enable This field is set by the application and cleared by the OTG host.


\
\ @brief OTG host channel 1 split control register
\ Address offset: 0x524
\ Reset value: 0x00000000
\

$0000007f constant OTG_FS_OTG_HCSPLT1_PRTADDR                       \ Port address This field is the port number of the recipient transaction translator.
$00003f80 constant OTG_FS_OTG_HCSPLT1_HUBADDR                       \ Hub address This field holds the device address of the transaction translators hub.
$0000c000 constant OTG_FS_OTG_HCSPLT1_XACTPOS                       \ Transaction position This field is used to determine whether to send all, first, middle, or last payloads with each OUT transaction.
$00010000 constant OTG_FS_OTG_HCSPLT1_COMPLSPLT                     \ Do complete split The application sets this bit to request the OTG host to perform a complete split transaction.
$80000000 constant OTG_FS_OTG_HCSPLT1_SPLITEN                       \ Split enable The application sets this bit to indicate that this channel is enabled to perform split transactions.


\
\ @brief OTG host channel 1 interrupt register
\ Address offset: 0x528
\ Reset value: 0x00000000
\

$00000001 constant OTG_FS_OTG_HCINT1_XFRC                           \ Transfer completed. Transfer completed normally without any errors.
$00000002 constant OTG_FS_OTG_HCINT1_CHH                            \ Channel halted. Indicates the transfer completed abnormally either because of any USB transaction error or in response to disable request by the application.
$00000004 constant OTG_FS_OTG_HCINT1_AHBERR                         \ AHB error This error is generated only in Internal DMA mode when an AHB error occurs during an AHB read/write operation. The application can read the corresponding DMA channel address register to get the error address.
$00000008 constant OTG_FS_OTG_HCINT1_STALL                          \ STALL response received interrupt.
$00000010 constant OTG_FS_OTG_HCINT1_NAK                            \ NAK response received interrupt.
$00000020 constant OTG_FS_OTG_HCINT1_ACK                            \ ACK response received/transmitted interrupt.
$00000040 constant OTG_FS_OTG_HCINT1_NYET                           \ Not yet ready response received interrupt.
$00000080 constant OTG_FS_OTG_HCINT1_TXERR                          \ Transaction error. Indicates one of the following errors occurred on the USB. CRC check failure Timeout Bit stuff error False EOP
$00000100 constant OTG_FS_OTG_HCINT1_BBERR                          \ Babble error.
$00000200 constant OTG_FS_OTG_HCINT1_FRMOR                          \ Frame overrun.
$00000400 constant OTG_FS_OTG_HCINT1_DTERR                          \ Data toggle error.


\
\ @brief OTG host channel 1 interrupt mask register
\ Address offset: 0x52C
\ Reset value: 0x00000000
\

$00000001 constant OTG_FS_OTG_HCINTMSK1_XFRCM                       \ Transfer completed mask
$00000002 constant OTG_FS_OTG_HCINTMSK1_CHHM                        \ Channel halted mask
$00000004 constant OTG_FS_OTG_HCINTMSK1_AHBERRM                     \ AHB error.
$00000008 constant OTG_FS_OTG_HCINTMSK1_STALLM                      \ STALL response received interrupt mask.
$00000010 constant OTG_FS_OTG_HCINTMSK1_NAKM                        \ NAK response received interrupt mask.
$00000020 constant OTG_FS_OTG_HCINTMSK1_ACKM                        \ ACK response received/transmitted interrupt mask.
$00000040 constant OTG_FS_OTG_HCINTMSK1_NYET                        \ response received interrupt mask.
$00000080 constant OTG_FS_OTG_HCINTMSK1_TXERRM                      \ Transaction error mask.
$00000100 constant OTG_FS_OTG_HCINTMSK1_BBERRM                      \ Babble error mask.
$00000200 constant OTG_FS_OTG_HCINTMSK1_FRMORM                      \ Frame overrun mask.
$00000400 constant OTG_FS_OTG_HCINTMSK1_DTERRM                      \ Data toggle error mask.


\
\ @brief OTG host channel 1 transfer size register
\ Address offset: 0x530
\ Reset value: 0x00000000
\

$0007ffff constant OTG_FS_OTG_HCTSIZ1_XFRSIZ                        \ Transfer size For an OUT, this field is the number of data bytes the host sends during the transfer. For an IN, this field is the buffer size that the application has reserved for the transfer. The application is expected to program this field as an integer multiple of the maximum packet size for IN transactions (periodic and non-periodic).
$1ff80000 constant OTG_FS_OTG_HCTSIZ1_PKTCNT                        \ Packet count This field is programmed by the application with the expected number of packets to be transmitted (OUT) or received (IN). The host decrements this count on every successful transmission or reception of an OUT/IN packet. Once this count reaches zero, the application is interrupted to indicate normal completion.
$60000000 constant OTG_FS_OTG_HCTSIZ1_DPID                          \ Data PID The application programs this field with the type of PID to use for the initial transaction. The host maintains this field for the rest of the transfer.
$80000000 constant OTG_FS_OTG_HCTSIZ1_DOPNG                         \ Do Ping This bit is used only for OUT transfers. Setting this field to 1 directs the host to do PING protocol. Note: Do not set this bit for IN transfers. If this bit is set for IN transfers, it disables the channel.


\
\ @brief OTG host channel 1 DMA address register
\ Address offset: 0x534
\ Reset value: 0x00000000
\

$00000000 constant OTG_FS_OTG_HCDMA1_DMAADDR                        \ DMA address This field holds the start address in the external memory from which the data for the endpoint must be fetched or to which it must be stored. This register is incremented on every AHB transaction.


\
\ @brief OTG host channel 2 characteristics register
\ Address offset: 0x540
\ Reset value: 0x00000000
\

$000007ff constant OTG_FS_OTG_HCCHAR2_MPSIZ                         \ Maximum packet size Indicates the maximum packet size of the associated endpoint.
$00007800 constant OTG_FS_OTG_HCCHAR2_EPNUM                         \ Endpoint number Indicates the endpoint number on the device serving as the data source or sink.
$00008000 constant OTG_FS_OTG_HCCHAR2_EPDIR                         \ Endpoint direction Indicates whether the transaction is IN or OUT.
$00020000 constant OTG_FS_OTG_HCCHAR2_LSDEV                         \ Low-speed device This field is set by the application to indicate that this channel is communicating to a low-speed device.
$000c0000 constant OTG_FS_OTG_HCCHAR2_EPTYP                         \ Endpoint type Indicates the transfer type selected.
$00300000 constant OTG_FS_OTG_HCCHAR2_MCNT                          \ Multicount This field indicates to the host the number of transactions that must be executed per frame for this periodic endpoint. For non-periodic transfers, this field is not used Note: This field must be set to at least 01.
$1fc00000 constant OTG_FS_OTG_HCCHAR2_DAD                           \ Device address This field selects the specific device serving as the data source or sink.
$20000000 constant OTG_FS_OTG_HCCHAR2_ODDFRM                        \ Odd frame This field is set (reset) by the application to indicate that the OTG host must perform a transfer in an odd frame. This field is applicable for only periodic (isochronous and interrupt) transactions.
$40000000 constant OTG_FS_OTG_HCCHAR2_CHDIS                         \ Channel disable The application sets this bit to stop transmitting/receiving data on a channel, even before the transfer for that channel is complete. The application must wait for the Channel disabled interrupt before treating the channel as disabled.
$80000000 constant OTG_FS_OTG_HCCHAR2_CHENA                         \ Channel enable This field is set by the application and cleared by the OTG host.


\
\ @brief OTG host channel 2 split control register
\ Address offset: 0x544
\ Reset value: 0x00000000
\

$0000007f constant OTG_FS_OTG_HCSPLT2_PRTADDR                       \ Port address This field is the port number of the recipient transaction translator.
$00003f80 constant OTG_FS_OTG_HCSPLT2_HUBADDR                       \ Hub address This field holds the device address of the transaction translators hub.
$0000c000 constant OTG_FS_OTG_HCSPLT2_XACTPOS                       \ Transaction position This field is used to determine whether to send all, first, middle, or last payloads with each OUT transaction.
$00010000 constant OTG_FS_OTG_HCSPLT2_COMPLSPLT                     \ Do complete split The application sets this bit to request the OTG host to perform a complete split transaction.
$80000000 constant OTG_FS_OTG_HCSPLT2_SPLITEN                       \ Split enable The application sets this bit to indicate that this channel is enabled to perform split transactions.


\
\ @brief OTG host channel 2 interrupt register
\ Address offset: 0x548
\ Reset value: 0x00000000
\

$00000001 constant OTG_FS_OTG_HCINT2_XFRC                           \ Transfer completed. Transfer completed normally without any errors.
$00000002 constant OTG_FS_OTG_HCINT2_CHH                            \ Channel halted. Indicates the transfer completed abnormally either because of any USB transaction error or in response to disable request by the application.
$00000004 constant OTG_FS_OTG_HCINT2_AHBERR                         \ AHB error This error is generated only in Internal DMA mode when an AHB error occurs during an AHB read/write operation. The application can read the corresponding DMA channel address register to get the error address.
$00000008 constant OTG_FS_OTG_HCINT2_STALL                          \ STALL response received interrupt.
$00000010 constant OTG_FS_OTG_HCINT2_NAK                            \ NAK response received interrupt.
$00000020 constant OTG_FS_OTG_HCINT2_ACK                            \ ACK response received/transmitted interrupt.
$00000040 constant OTG_FS_OTG_HCINT2_NYET                           \ Not yet ready response received interrupt.
$00000080 constant OTG_FS_OTG_HCINT2_TXERR                          \ Transaction error. Indicates one of the following errors occurred on the USB. CRC check failure Timeout Bit stuff error False EOP
$00000100 constant OTG_FS_OTG_HCINT2_BBERR                          \ Babble error.
$00000200 constant OTG_FS_OTG_HCINT2_FRMOR                          \ Frame overrun.
$00000400 constant OTG_FS_OTG_HCINT2_DTERR                          \ Data toggle error.


\
\ @brief OTG host channel 2 interrupt mask register
\ Address offset: 0x54C
\ Reset value: 0x00000000
\

$00000001 constant OTG_FS_OTG_HCINTMSK2_XFRCM                       \ Transfer completed mask
$00000002 constant OTG_FS_OTG_HCINTMSK2_CHHM                        \ Channel halted mask
$00000004 constant OTG_FS_OTG_HCINTMSK2_AHBERRM                     \ AHB error.
$00000008 constant OTG_FS_OTG_HCINTMSK2_STALLM                      \ STALL response received interrupt mask.
$00000010 constant OTG_FS_OTG_HCINTMSK2_NAKM                        \ NAK response received interrupt mask.
$00000020 constant OTG_FS_OTG_HCINTMSK2_ACKM                        \ ACK response received/transmitted interrupt mask.
$00000040 constant OTG_FS_OTG_HCINTMSK2_NYET                        \ response received interrupt mask.
$00000080 constant OTG_FS_OTG_HCINTMSK2_TXERRM                      \ Transaction error mask.
$00000100 constant OTG_FS_OTG_HCINTMSK2_BBERRM                      \ Babble error mask.
$00000200 constant OTG_FS_OTG_HCINTMSK2_FRMORM                      \ Frame overrun mask.
$00000400 constant OTG_FS_OTG_HCINTMSK2_DTERRM                      \ Data toggle error mask.


\
\ @brief OTG host channel 2 transfer size register
\ Address offset: 0x550
\ Reset value: 0x00000000
\

$0007ffff constant OTG_FS_OTG_HCTSIZ2_XFRSIZ                        \ Transfer size For an OUT, this field is the number of data bytes the host sends during the transfer. For an IN, this field is the buffer size that the application has reserved for the transfer. The application is expected to program this field as an integer multiple of the maximum packet size for IN transactions (periodic and non-periodic).
$1ff80000 constant OTG_FS_OTG_HCTSIZ2_PKTCNT                        \ Packet count This field is programmed by the application with the expected number of packets to be transmitted (OUT) or received (IN). The host decrements this count on every successful transmission or reception of an OUT/IN packet. Once this count reaches zero, the application is interrupted to indicate normal completion.
$60000000 constant OTG_FS_OTG_HCTSIZ2_DPID                          \ Data PID The application programs this field with the type of PID to use for the initial transaction. The host maintains this field for the rest of the transfer.
$80000000 constant OTG_FS_OTG_HCTSIZ2_DOPNG                         \ Do Ping This bit is used only for OUT transfers. Setting this field to 1 directs the host to do PING protocol. Note: Do not set this bit for IN transfers. If this bit is set for IN transfers, it disables the channel.


\
\ @brief OTG host channel 2 DMA address register
\ Address offset: 0x554
\ Reset value: 0x00000000
\

$00000000 constant OTG_FS_OTG_HCDMA2_DMAADDR                        \ DMA address This field holds the start address in the external memory from which the data for the endpoint must be fetched or to which it must be stored. This register is incremented on every AHB transaction.


\
\ @brief OTG host channel 3 characteristics register
\ Address offset: 0x560
\ Reset value: 0x00000000
\

$000007ff constant OTG_FS_OTG_HCCHAR3_MPSIZ                         \ Maximum packet size Indicates the maximum packet size of the associated endpoint.
$00007800 constant OTG_FS_OTG_HCCHAR3_EPNUM                         \ Endpoint number Indicates the endpoint number on the device serving as the data source or sink.
$00008000 constant OTG_FS_OTG_HCCHAR3_EPDIR                         \ Endpoint direction Indicates whether the transaction is IN or OUT.
$00020000 constant OTG_FS_OTG_HCCHAR3_LSDEV                         \ Low-speed device This field is set by the application to indicate that this channel is communicating to a low-speed device.
$000c0000 constant OTG_FS_OTG_HCCHAR3_EPTYP                         \ Endpoint type Indicates the transfer type selected.
$00300000 constant OTG_FS_OTG_HCCHAR3_MCNT                          \ Multicount This field indicates to the host the number of transactions that must be executed per frame for this periodic endpoint. For non-periodic transfers, this field is not used Note: This field must be set to at least 01.
$1fc00000 constant OTG_FS_OTG_HCCHAR3_DAD                           \ Device address This field selects the specific device serving as the data source or sink.
$20000000 constant OTG_FS_OTG_HCCHAR3_ODDFRM                        \ Odd frame This field is set (reset) by the application to indicate that the OTG host must perform a transfer in an odd frame. This field is applicable for only periodic (isochronous and interrupt) transactions.
$40000000 constant OTG_FS_OTG_HCCHAR3_CHDIS                         \ Channel disable The application sets this bit to stop transmitting/receiving data on a channel, even before the transfer for that channel is complete. The application must wait for the Channel disabled interrupt before treating the channel as disabled.
$80000000 constant OTG_FS_OTG_HCCHAR3_CHENA                         \ Channel enable This field is set by the application and cleared by the OTG host.


\
\ @brief OTG host channel 3 split control register
\ Address offset: 0x564
\ Reset value: 0x00000000
\

$0000007f constant OTG_FS_OTG_HCSPLT3_PRTADDR                       \ Port address This field is the port number of the recipient transaction translator.
$00003f80 constant OTG_FS_OTG_HCSPLT3_HUBADDR                       \ Hub address This field holds the device address of the transaction translators hub.
$0000c000 constant OTG_FS_OTG_HCSPLT3_XACTPOS                       \ Transaction position This field is used to determine whether to send all, first, middle, or last payloads with each OUT transaction.
$00010000 constant OTG_FS_OTG_HCSPLT3_COMPLSPLT                     \ Do complete split The application sets this bit to request the OTG host to perform a complete split transaction.
$80000000 constant OTG_FS_OTG_HCSPLT3_SPLITEN                       \ Split enable The application sets this bit to indicate that this channel is enabled to perform split transactions.


\
\ @brief OTG host channel 3 interrupt register
\ Address offset: 0x568
\ Reset value: 0x00000000
\

$00000001 constant OTG_FS_OTG_HCINT3_XFRC                           \ Transfer completed. Transfer completed normally without any errors.
$00000002 constant OTG_FS_OTG_HCINT3_CHH                            \ Channel halted. Indicates the transfer completed abnormally either because of any USB transaction error or in response to disable request by the application.
$00000004 constant OTG_FS_OTG_HCINT3_AHBERR                         \ AHB error This error is generated only in Internal DMA mode when an AHB error occurs during an AHB read/write operation. The application can read the corresponding DMA channel address register to get the error address.
$00000008 constant OTG_FS_OTG_HCINT3_STALL                          \ STALL response received interrupt.
$00000010 constant OTG_FS_OTG_HCINT3_NAK                            \ NAK response received interrupt.
$00000020 constant OTG_FS_OTG_HCINT3_ACK                            \ ACK response received/transmitted interrupt.
$00000040 constant OTG_FS_OTG_HCINT3_NYET                           \ Not yet ready response received interrupt.
$00000080 constant OTG_FS_OTG_HCINT3_TXERR                          \ Transaction error. Indicates one of the following errors occurred on the USB. CRC check failure Timeout Bit stuff error False EOP
$00000100 constant OTG_FS_OTG_HCINT3_BBERR                          \ Babble error.
$00000200 constant OTG_FS_OTG_HCINT3_FRMOR                          \ Frame overrun.
$00000400 constant OTG_FS_OTG_HCINT3_DTERR                          \ Data toggle error.


\
\ @brief OTG host channel 3 interrupt mask register
\ Address offset: 0x56C
\ Reset value: 0x00000000
\

$00000001 constant OTG_FS_OTG_HCINTMSK3_XFRCM                       \ Transfer completed mask
$00000002 constant OTG_FS_OTG_HCINTMSK3_CHHM                        \ Channel halted mask
$00000004 constant OTG_FS_OTG_HCINTMSK3_AHBERRM                     \ AHB error.
$00000008 constant OTG_FS_OTG_HCINTMSK3_STALLM                      \ STALL response received interrupt mask.
$00000010 constant OTG_FS_OTG_HCINTMSK3_NAKM                        \ NAK response received interrupt mask.
$00000020 constant OTG_FS_OTG_HCINTMSK3_ACKM                        \ ACK response received/transmitted interrupt mask.
$00000040 constant OTG_FS_OTG_HCINTMSK3_NYET                        \ response received interrupt mask.
$00000080 constant OTG_FS_OTG_HCINTMSK3_TXERRM                      \ Transaction error mask.
$00000100 constant OTG_FS_OTG_HCINTMSK3_BBERRM                      \ Babble error mask.
$00000200 constant OTG_FS_OTG_HCINTMSK3_FRMORM                      \ Frame overrun mask.
$00000400 constant OTG_FS_OTG_HCINTMSK3_DTERRM                      \ Data toggle error mask.


\
\ @brief OTG host channel 3 transfer size register
\ Address offset: 0x570
\ Reset value: 0x00000000
\

$0007ffff constant OTG_FS_OTG_HCTSIZ3_XFRSIZ                        \ Transfer size For an OUT, this field is the number of data bytes the host sends during the transfer. For an IN, this field is the buffer size that the application has reserved for the transfer. The application is expected to program this field as an integer multiple of the maximum packet size for IN transactions (periodic and non-periodic).
$1ff80000 constant OTG_FS_OTG_HCTSIZ3_PKTCNT                        \ Packet count This field is programmed by the application with the expected number of packets to be transmitted (OUT) or received (IN). The host decrements this count on every successful transmission or reception of an OUT/IN packet. Once this count reaches zero, the application is interrupted to indicate normal completion.
$60000000 constant OTG_FS_OTG_HCTSIZ3_DPID                          \ Data PID The application programs this field with the type of PID to use for the initial transaction. The host maintains this field for the rest of the transfer.
$80000000 constant OTG_FS_OTG_HCTSIZ3_DOPNG                         \ Do Ping This bit is used only for OUT transfers. Setting this field to 1 directs the host to do PING protocol. Note: Do not set this bit for IN transfers. If this bit is set for IN transfers, it disables the channel.


\
\ @brief OTG host channel 3 DMA address register
\ Address offset: 0x574
\ Reset value: 0x00000000
\

$00000000 constant OTG_FS_OTG_HCDMA3_DMAADDR                        \ DMA address This field holds the start address in the external memory from which the data for the endpoint must be fetched or to which it must be stored. This register is incremented on every AHB transaction.


\
\ @brief OTG host channel 4 characteristics register
\ Address offset: 0x580
\ Reset value: 0x00000000
\

$000007ff constant OTG_FS_OTG_HCCHAR4_MPSIZ                         \ Maximum packet size Indicates the maximum packet size of the associated endpoint.
$00007800 constant OTG_FS_OTG_HCCHAR4_EPNUM                         \ Endpoint number Indicates the endpoint number on the device serving as the data source or sink.
$00008000 constant OTG_FS_OTG_HCCHAR4_EPDIR                         \ Endpoint direction Indicates whether the transaction is IN or OUT.
$00020000 constant OTG_FS_OTG_HCCHAR4_LSDEV                         \ Low-speed device This field is set by the application to indicate that this channel is communicating to a low-speed device.
$000c0000 constant OTG_FS_OTG_HCCHAR4_EPTYP                         \ Endpoint type Indicates the transfer type selected.
$00300000 constant OTG_FS_OTG_HCCHAR4_MCNT                          \ Multicount This field indicates to the host the number of transactions that must be executed per frame for this periodic endpoint. For non-periodic transfers, this field is not used Note: This field must be set to at least 01.
$1fc00000 constant OTG_FS_OTG_HCCHAR4_DAD                           \ Device address This field selects the specific device serving as the data source or sink.
$20000000 constant OTG_FS_OTG_HCCHAR4_ODDFRM                        \ Odd frame This field is set (reset) by the application to indicate that the OTG host must perform a transfer in an odd frame. This field is applicable for only periodic (isochronous and interrupt) transactions.
$40000000 constant OTG_FS_OTG_HCCHAR4_CHDIS                         \ Channel disable The application sets this bit to stop transmitting/receiving data on a channel, even before the transfer for that channel is complete. The application must wait for the Channel disabled interrupt before treating the channel as disabled.
$80000000 constant OTG_FS_OTG_HCCHAR4_CHENA                         \ Channel enable This field is set by the application and cleared by the OTG host.


\
\ @brief OTG host channel 4 split control register
\ Address offset: 0x584
\ Reset value: 0x00000000
\

$0000007f constant OTG_FS_OTG_HCSPLT4_PRTADDR                       \ Port address This field is the port number of the recipient transaction translator.
$00003f80 constant OTG_FS_OTG_HCSPLT4_HUBADDR                       \ Hub address This field holds the device address of the transaction translators hub.
$0000c000 constant OTG_FS_OTG_HCSPLT4_XACTPOS                       \ Transaction position This field is used to determine whether to send all, first, middle, or last payloads with each OUT transaction.
$00010000 constant OTG_FS_OTG_HCSPLT4_COMPLSPLT                     \ Do complete split The application sets this bit to request the OTG host to perform a complete split transaction.
$80000000 constant OTG_FS_OTG_HCSPLT4_SPLITEN                       \ Split enable The application sets this bit to indicate that this channel is enabled to perform split transactions.


\
\ @brief OTG host channel 4 interrupt register
\ Address offset: 0x588
\ Reset value: 0x00000000
\

$00000001 constant OTG_FS_OTG_HCINT4_XFRC                           \ Transfer completed. Transfer completed normally without any errors.
$00000002 constant OTG_FS_OTG_HCINT4_CHH                            \ Channel halted. Indicates the transfer completed abnormally either because of any USB transaction error or in response to disable request by the application.
$00000004 constant OTG_FS_OTG_HCINT4_AHBERR                         \ AHB error This error is generated only in Internal DMA mode when an AHB error occurs during an AHB read/write operation. The application can read the corresponding DMA channel address register to get the error address.
$00000008 constant OTG_FS_OTG_HCINT4_STALL                          \ STALL response received interrupt.
$00000010 constant OTG_FS_OTG_HCINT4_NAK                            \ NAK response received interrupt.
$00000020 constant OTG_FS_OTG_HCINT4_ACK                            \ ACK response received/transmitted interrupt.
$00000040 constant OTG_FS_OTG_HCINT4_NYET                           \ Not yet ready response received interrupt.
$00000080 constant OTG_FS_OTG_HCINT4_TXERR                          \ Transaction error. Indicates one of the following errors occurred on the USB. CRC check failure Timeout Bit stuff error False EOP
$00000100 constant OTG_FS_OTG_HCINT4_BBERR                          \ Babble error.
$00000200 constant OTG_FS_OTG_HCINT4_FRMOR                          \ Frame overrun.
$00000400 constant OTG_FS_OTG_HCINT4_DTERR                          \ Data toggle error.


\
\ @brief OTG host channel 4 interrupt mask register
\ Address offset: 0x58C
\ Reset value: 0x00000000
\

$00000001 constant OTG_FS_OTG_HCINTMSK4_XFRCM                       \ Transfer completed mask
$00000002 constant OTG_FS_OTG_HCINTMSK4_CHHM                        \ Channel halted mask
$00000004 constant OTG_FS_OTG_HCINTMSK4_AHBERRM                     \ AHB error.
$00000008 constant OTG_FS_OTG_HCINTMSK4_STALLM                      \ STALL response received interrupt mask.
$00000010 constant OTG_FS_OTG_HCINTMSK4_NAKM                        \ NAK response received interrupt mask.
$00000020 constant OTG_FS_OTG_HCINTMSK4_ACKM                        \ ACK response received/transmitted interrupt mask.
$00000040 constant OTG_FS_OTG_HCINTMSK4_NYET                        \ response received interrupt mask.
$00000080 constant OTG_FS_OTG_HCINTMSK4_TXERRM                      \ Transaction error mask.
$00000100 constant OTG_FS_OTG_HCINTMSK4_BBERRM                      \ Babble error mask.
$00000200 constant OTG_FS_OTG_HCINTMSK4_FRMORM                      \ Frame overrun mask.
$00000400 constant OTG_FS_OTG_HCINTMSK4_DTERRM                      \ Data toggle error mask.


\
\ @brief OTG host channel 4 transfer size register
\ Address offset: 0x590
\ Reset value: 0x00000000
\

$0007ffff constant OTG_FS_OTG_HCTSIZ4_XFRSIZ                        \ Transfer size For an OUT, this field is the number of data bytes the host sends during the transfer. For an IN, this field is the buffer size that the application has reserved for the transfer. The application is expected to program this field as an integer multiple of the maximum packet size for IN transactions (periodic and non-periodic).
$1ff80000 constant OTG_FS_OTG_HCTSIZ4_PKTCNT                        \ Packet count This field is programmed by the application with the expected number of packets to be transmitted (OUT) or received (IN). The host decrements this count on every successful transmission or reception of an OUT/IN packet. Once this count reaches zero, the application is interrupted to indicate normal completion.
$60000000 constant OTG_FS_OTG_HCTSIZ4_DPID                          \ Data PID The application programs this field with the type of PID to use for the initial transaction. The host maintains this field for the rest of the transfer.
$80000000 constant OTG_FS_OTG_HCTSIZ4_DOPNG                         \ Do Ping This bit is used only for OUT transfers. Setting this field to 1 directs the host to do PING protocol. Note: Do not set this bit for IN transfers. If this bit is set for IN transfers, it disables the channel.


\
\ @brief OTG host channel 4 DMA address register
\ Address offset: 0x594
\ Reset value: 0x00000000
\

$00000000 constant OTG_FS_OTG_HCDMA4_DMAADDR                        \ DMA address This field holds the start address in the external memory from which the data for the endpoint must be fetched or to which it must be stored. This register is incremented on every AHB transaction.


\
\ @brief OTG host channel 5 characteristics register
\ Address offset: 0x5A0
\ Reset value: 0x00000000
\

$000007ff constant OTG_FS_OTG_HCCHAR5_MPSIZ                         \ Maximum packet size Indicates the maximum packet size of the associated endpoint.
$00007800 constant OTG_FS_OTG_HCCHAR5_EPNUM                         \ Endpoint number Indicates the endpoint number on the device serving as the data source or sink.
$00008000 constant OTG_FS_OTG_HCCHAR5_EPDIR                         \ Endpoint direction Indicates whether the transaction is IN or OUT.
$00020000 constant OTG_FS_OTG_HCCHAR5_LSDEV                         \ Low-speed device This field is set by the application to indicate that this channel is communicating to a low-speed device.
$000c0000 constant OTG_FS_OTG_HCCHAR5_EPTYP                         \ Endpoint type Indicates the transfer type selected.
$00300000 constant OTG_FS_OTG_HCCHAR5_MCNT                          \ Multicount This field indicates to the host the number of transactions that must be executed per frame for this periodic endpoint. For non-periodic transfers, this field is not used Note: This field must be set to at least 01.
$1fc00000 constant OTG_FS_OTG_HCCHAR5_DAD                           \ Device address This field selects the specific device serving as the data source or sink.
$20000000 constant OTG_FS_OTG_HCCHAR5_ODDFRM                        \ Odd frame This field is set (reset) by the application to indicate that the OTG host must perform a transfer in an odd frame. This field is applicable for only periodic (isochronous and interrupt) transactions.
$40000000 constant OTG_FS_OTG_HCCHAR5_CHDIS                         \ Channel disable The application sets this bit to stop transmitting/receiving data on a channel, even before the transfer for that channel is complete. The application must wait for the Channel disabled interrupt before treating the channel as disabled.
$80000000 constant OTG_FS_OTG_HCCHAR5_CHENA                         \ Channel enable This field is set by the application and cleared by the OTG host.


\
\ @brief OTG host channel 5 split control register
\ Address offset: 0x5A4
\ Reset value: 0x00000000
\

$0000007f constant OTG_FS_OTG_HCSPLT5_PRTADDR                       \ Port address This field is the port number of the recipient transaction translator.
$00003f80 constant OTG_FS_OTG_HCSPLT5_HUBADDR                       \ Hub address This field holds the device address of the transaction translators hub.
$0000c000 constant OTG_FS_OTG_HCSPLT5_XACTPOS                       \ Transaction position This field is used to determine whether to send all, first, middle, or last payloads with each OUT transaction.
$00010000 constant OTG_FS_OTG_HCSPLT5_COMPLSPLT                     \ Do complete split The application sets this bit to request the OTG host to perform a complete split transaction.
$80000000 constant OTG_FS_OTG_HCSPLT5_SPLITEN                       \ Split enable The application sets this bit to indicate that this channel is enabled to perform split transactions.


\
\ @brief OTG host channel 5 interrupt register
\ Address offset: 0x5A8
\ Reset value: 0x00000000
\

$00000001 constant OTG_FS_OTG_HCINT5_XFRC                           \ Transfer completed. Transfer completed normally without any errors.
$00000002 constant OTG_FS_OTG_HCINT5_CHH                            \ Channel halted. Indicates the transfer completed abnormally either because of any USB transaction error or in response to disable request by the application.
$00000004 constant OTG_FS_OTG_HCINT5_AHBERR                         \ AHB error This error is generated only in Internal DMA mode when an AHB error occurs during an AHB read/write operation. The application can read the corresponding DMA channel address register to get the error address.
$00000008 constant OTG_FS_OTG_HCINT5_STALL                          \ STALL response received interrupt.
$00000010 constant OTG_FS_OTG_HCINT5_NAK                            \ NAK response received interrupt.
$00000020 constant OTG_FS_OTG_HCINT5_ACK                            \ ACK response received/transmitted interrupt.
$00000040 constant OTG_FS_OTG_HCINT5_NYET                           \ Not yet ready response received interrupt.
$00000080 constant OTG_FS_OTG_HCINT5_TXERR                          \ Transaction error. Indicates one of the following errors occurred on the USB. CRC check failure Timeout Bit stuff error False EOP
$00000100 constant OTG_FS_OTG_HCINT5_BBERR                          \ Babble error.
$00000200 constant OTG_FS_OTG_HCINT5_FRMOR                          \ Frame overrun.
$00000400 constant OTG_FS_OTG_HCINT5_DTERR                          \ Data toggle error.


\
\ @brief OTG host channel 5 interrupt mask register
\ Address offset: 0x5AC
\ Reset value: 0x00000000
\

$00000001 constant OTG_FS_OTG_HCINTMSK5_XFRCM                       \ Transfer completed mask
$00000002 constant OTG_FS_OTG_HCINTMSK5_CHHM                        \ Channel halted mask
$00000004 constant OTG_FS_OTG_HCINTMSK5_AHBERRM                     \ AHB error.
$00000008 constant OTG_FS_OTG_HCINTMSK5_STALLM                      \ STALL response received interrupt mask.
$00000010 constant OTG_FS_OTG_HCINTMSK5_NAKM                        \ NAK response received interrupt mask.
$00000020 constant OTG_FS_OTG_HCINTMSK5_ACKM                        \ ACK response received/transmitted interrupt mask.
$00000040 constant OTG_FS_OTG_HCINTMSK5_NYET                        \ response received interrupt mask.
$00000080 constant OTG_FS_OTG_HCINTMSK5_TXERRM                      \ Transaction error mask.
$00000100 constant OTG_FS_OTG_HCINTMSK5_BBERRM                      \ Babble error mask.
$00000200 constant OTG_FS_OTG_HCINTMSK5_FRMORM                      \ Frame overrun mask.
$00000400 constant OTG_FS_OTG_HCINTMSK5_DTERRM                      \ Data toggle error mask.


\
\ @brief OTG host channel 5 transfer size register
\ Address offset: 0x5B0
\ Reset value: 0x00000000
\

$0007ffff constant OTG_FS_OTG_HCTSIZ5_XFRSIZ                        \ Transfer size For an OUT, this field is the number of data bytes the host sends during the transfer. For an IN, this field is the buffer size that the application has reserved for the transfer. The application is expected to program this field as an integer multiple of the maximum packet size for IN transactions (periodic and non-periodic).
$1ff80000 constant OTG_FS_OTG_HCTSIZ5_PKTCNT                        \ Packet count This field is programmed by the application with the expected number of packets to be transmitted (OUT) or received (IN). The host decrements this count on every successful transmission or reception of an OUT/IN packet. Once this count reaches zero, the application is interrupted to indicate normal completion.
$60000000 constant OTG_FS_OTG_HCTSIZ5_DPID                          \ Data PID The application programs this field with the type of PID to use for the initial transaction. The host maintains this field for the rest of the transfer.
$80000000 constant OTG_FS_OTG_HCTSIZ5_DOPNG                         \ Do Ping This bit is used only for OUT transfers. Setting this field to 1 directs the host to do PING protocol. Note: Do not set this bit for IN transfers. If this bit is set for IN transfers, it disables the channel.


\
\ @brief OTG host channel 5 DMA address register
\ Address offset: 0x5B4
\ Reset value: 0x00000000
\

$00000000 constant OTG_FS_OTG_HCDMA5_DMAADDR                        \ DMA address This field holds the start address in the external memory from which the data for the endpoint must be fetched or to which it must be stored. This register is incremented on every AHB transaction.


\
\ @brief OTG host channel 6 characteristics register
\ Address offset: 0x5C0
\ Reset value: 0x00000000
\

$000007ff constant OTG_FS_OTG_HCCHAR6_MPSIZ                         \ Maximum packet size Indicates the maximum packet size of the associated endpoint.
$00007800 constant OTG_FS_OTG_HCCHAR6_EPNUM                         \ Endpoint number Indicates the endpoint number on the device serving as the data source or sink.
$00008000 constant OTG_FS_OTG_HCCHAR6_EPDIR                         \ Endpoint direction Indicates whether the transaction is IN or OUT.
$00020000 constant OTG_FS_OTG_HCCHAR6_LSDEV                         \ Low-speed device This field is set by the application to indicate that this channel is communicating to a low-speed device.
$000c0000 constant OTG_FS_OTG_HCCHAR6_EPTYP                         \ Endpoint type Indicates the transfer type selected.
$00300000 constant OTG_FS_OTG_HCCHAR6_MCNT                          \ Multicount This field indicates to the host the number of transactions that must be executed per frame for this periodic endpoint. For non-periodic transfers, this field is not used Note: This field must be set to at least 01.
$1fc00000 constant OTG_FS_OTG_HCCHAR6_DAD                           \ Device address This field selects the specific device serving as the data source or sink.
$20000000 constant OTG_FS_OTG_HCCHAR6_ODDFRM                        \ Odd frame This field is set (reset) by the application to indicate that the OTG host must perform a transfer in an odd frame. This field is applicable for only periodic (isochronous and interrupt) transactions.
$40000000 constant OTG_FS_OTG_HCCHAR6_CHDIS                         \ Channel disable The application sets this bit to stop transmitting/receiving data on a channel, even before the transfer for that channel is complete. The application must wait for the Channel disabled interrupt before treating the channel as disabled.
$80000000 constant OTG_FS_OTG_HCCHAR6_CHENA                         \ Channel enable This field is set by the application and cleared by the OTG host.


\
\ @brief OTG host channel 6 split control register
\ Address offset: 0x5C4
\ Reset value: 0x00000000
\

$0000007f constant OTG_FS_OTG_HCSPLT6_PRTADDR                       \ Port address This field is the port number of the recipient transaction translator.
$00003f80 constant OTG_FS_OTG_HCSPLT6_HUBADDR                       \ Hub address This field holds the device address of the transaction translators hub.
$0000c000 constant OTG_FS_OTG_HCSPLT6_XACTPOS                       \ Transaction position This field is used to determine whether to send all, first, middle, or last payloads with each OUT transaction.
$00010000 constant OTG_FS_OTG_HCSPLT6_COMPLSPLT                     \ Do complete split The application sets this bit to request the OTG host to perform a complete split transaction.
$80000000 constant OTG_FS_OTG_HCSPLT6_SPLITEN                       \ Split enable The application sets this bit to indicate that this channel is enabled to perform split transactions.


\
\ @brief OTG host channel 6 interrupt register
\ Address offset: 0x5C8
\ Reset value: 0x00000000
\

$00000001 constant OTG_FS_OTG_HCINT6_XFRC                           \ Transfer completed. Transfer completed normally without any errors.
$00000002 constant OTG_FS_OTG_HCINT6_CHH                            \ Channel halted. Indicates the transfer completed abnormally either because of any USB transaction error or in response to disable request by the application.
$00000004 constant OTG_FS_OTG_HCINT6_AHBERR                         \ AHB error This error is generated only in Internal DMA mode when an AHB error occurs during an AHB read/write operation. The application can read the corresponding DMA channel address register to get the error address.
$00000008 constant OTG_FS_OTG_HCINT6_STALL                          \ STALL response received interrupt.
$00000010 constant OTG_FS_OTG_HCINT6_NAK                            \ NAK response received interrupt.
$00000020 constant OTG_FS_OTG_HCINT6_ACK                            \ ACK response received/transmitted interrupt.
$00000040 constant OTG_FS_OTG_HCINT6_NYET                           \ Not yet ready response received interrupt.
$00000080 constant OTG_FS_OTG_HCINT6_TXERR                          \ Transaction error. Indicates one of the following errors occurred on the USB. CRC check failure Timeout Bit stuff error False EOP
$00000100 constant OTG_FS_OTG_HCINT6_BBERR                          \ Babble error.
$00000200 constant OTG_FS_OTG_HCINT6_FRMOR                          \ Frame overrun.
$00000400 constant OTG_FS_OTG_HCINT6_DTERR                          \ Data toggle error.


\
\ @brief OTG host channel 6 interrupt mask register
\ Address offset: 0x5CC
\ Reset value: 0x00000000
\

$00000001 constant OTG_FS_OTG_HCINTMSK6_XFRCM                       \ Transfer completed mask
$00000002 constant OTG_FS_OTG_HCINTMSK6_CHHM                        \ Channel halted mask
$00000004 constant OTG_FS_OTG_HCINTMSK6_AHBERRM                     \ AHB error.
$00000008 constant OTG_FS_OTG_HCINTMSK6_STALLM                      \ STALL response received interrupt mask.
$00000010 constant OTG_FS_OTG_HCINTMSK6_NAKM                        \ NAK response received interrupt mask.
$00000020 constant OTG_FS_OTG_HCINTMSK6_ACKM                        \ ACK response received/transmitted interrupt mask.
$00000040 constant OTG_FS_OTG_HCINTMSK6_NYET                        \ response received interrupt mask.
$00000080 constant OTG_FS_OTG_HCINTMSK6_TXERRM                      \ Transaction error mask.
$00000100 constant OTG_FS_OTG_HCINTMSK6_BBERRM                      \ Babble error mask.
$00000200 constant OTG_FS_OTG_HCINTMSK6_FRMORM                      \ Frame overrun mask.
$00000400 constant OTG_FS_OTG_HCINTMSK6_DTERRM                      \ Data toggle error mask.


\
\ @brief OTG host channel 6 transfer size register
\ Address offset: 0x5D0
\ Reset value: 0x00000000
\

$0007ffff constant OTG_FS_OTG_HCTSIZ6_XFRSIZ                        \ Transfer size For an OUT, this field is the number of data bytes the host sends during the transfer. For an IN, this field is the buffer size that the application has reserved for the transfer. The application is expected to program this field as an integer multiple of the maximum packet size for IN transactions (periodic and non-periodic).
$1ff80000 constant OTG_FS_OTG_HCTSIZ6_PKTCNT                        \ Packet count This field is programmed by the application with the expected number of packets to be transmitted (OUT) or received (IN). The host decrements this count on every successful transmission or reception of an OUT/IN packet. Once this count reaches zero, the application is interrupted to indicate normal completion.
$60000000 constant OTG_FS_OTG_HCTSIZ6_DPID                          \ Data PID The application programs this field with the type of PID to use for the initial transaction. The host maintains this field for the rest of the transfer.
$80000000 constant OTG_FS_OTG_HCTSIZ6_DOPNG                         \ Do Ping This bit is used only for OUT transfers. Setting this field to 1 directs the host to do PING protocol. Note: Do not set this bit for IN transfers. If this bit is set for IN transfers, it disables the channel.


\
\ @brief OTG host channel 6 DMA address register
\ Address offset: 0x5D4
\ Reset value: 0x00000000
\

$00000000 constant OTG_FS_OTG_HCDMA6_DMAADDR                        \ DMA address This field holds the start address in the external memory from which the data for the endpoint must be fetched or to which it must be stored. This register is incremented on every AHB transaction.


\
\ @brief OTG host channel 7 characteristics register
\ Address offset: 0x5E0
\ Reset value: 0x00000000
\

$000007ff constant OTG_FS_OTG_HCCHAR7_MPSIZ                         \ Maximum packet size Indicates the maximum packet size of the associated endpoint.
$00007800 constant OTG_FS_OTG_HCCHAR7_EPNUM                         \ Endpoint number Indicates the endpoint number on the device serving as the data source or sink.
$00008000 constant OTG_FS_OTG_HCCHAR7_EPDIR                         \ Endpoint direction Indicates whether the transaction is IN or OUT.
$00020000 constant OTG_FS_OTG_HCCHAR7_LSDEV                         \ Low-speed device This field is set by the application to indicate that this channel is communicating to a low-speed device.
$000c0000 constant OTG_FS_OTG_HCCHAR7_EPTYP                         \ Endpoint type Indicates the transfer type selected.
$00300000 constant OTG_FS_OTG_HCCHAR7_MCNT                          \ Multicount This field indicates to the host the number of transactions that must be executed per frame for this periodic endpoint. For non-periodic transfers, this field is not used Note: This field must be set to at least 01.
$1fc00000 constant OTG_FS_OTG_HCCHAR7_DAD                           \ Device address This field selects the specific device serving as the data source or sink.
$20000000 constant OTG_FS_OTG_HCCHAR7_ODDFRM                        \ Odd frame This field is set (reset) by the application to indicate that the OTG host must perform a transfer in an odd frame. This field is applicable for only periodic (isochronous and interrupt) transactions.
$40000000 constant OTG_FS_OTG_HCCHAR7_CHDIS                         \ Channel disable The application sets this bit to stop transmitting/receiving data on a channel, even before the transfer for that channel is complete. The application must wait for the Channel disabled interrupt before treating the channel as disabled.
$80000000 constant OTG_FS_OTG_HCCHAR7_CHENA                         \ Channel enable This field is set by the application and cleared by the OTG host.


\
\ @brief OTG host channel 7 split control register
\ Address offset: 0x5E4
\ Reset value: 0x00000000
\

$0000007f constant OTG_FS_OTG_HCSPLT7_PRTADDR                       \ Port address This field is the port number of the recipient transaction translator.
$00003f80 constant OTG_FS_OTG_HCSPLT7_HUBADDR                       \ Hub address This field holds the device address of the transaction translators hub.
$0000c000 constant OTG_FS_OTG_HCSPLT7_XACTPOS                       \ Transaction position This field is used to determine whether to send all, first, middle, or last payloads with each OUT transaction.
$00010000 constant OTG_FS_OTG_HCSPLT7_COMPLSPLT                     \ Do complete split The application sets this bit to request the OTG host to perform a complete split transaction.
$80000000 constant OTG_FS_OTG_HCSPLT7_SPLITEN                       \ Split enable The application sets this bit to indicate that this channel is enabled to perform split transactions.


\
\ @brief OTG host channel 7 interrupt register
\ Address offset: 0x5E8
\ Reset value: 0x00000000
\

$00000001 constant OTG_FS_OTG_HCINT7_XFRC                           \ Transfer completed. Transfer completed normally without any errors.
$00000002 constant OTG_FS_OTG_HCINT7_CHH                            \ Channel halted. Indicates the transfer completed abnormally either because of any USB transaction error or in response to disable request by the application.
$00000004 constant OTG_FS_OTG_HCINT7_AHBERR                         \ AHB error This error is generated only in Internal DMA mode when an AHB error occurs during an AHB read/write operation. The application can read the corresponding DMA channel address register to get the error address.
$00000008 constant OTG_FS_OTG_HCINT7_STALL                          \ STALL response received interrupt.
$00000010 constant OTG_FS_OTG_HCINT7_NAK                            \ NAK response received interrupt.
$00000020 constant OTG_FS_OTG_HCINT7_ACK                            \ ACK response received/transmitted interrupt.
$00000040 constant OTG_FS_OTG_HCINT7_NYET                           \ Not yet ready response received interrupt.
$00000080 constant OTG_FS_OTG_HCINT7_TXERR                          \ Transaction error. Indicates one of the following errors occurred on the USB. CRC check failure Timeout Bit stuff error False EOP
$00000100 constant OTG_FS_OTG_HCINT7_BBERR                          \ Babble error.
$00000200 constant OTG_FS_OTG_HCINT7_FRMOR                          \ Frame overrun.
$00000400 constant OTG_FS_OTG_HCINT7_DTERR                          \ Data toggle error.


\
\ @brief OTG host channel 7 interrupt mask register
\ Address offset: 0x5EC
\ Reset value: 0x00000000
\

$00000001 constant OTG_FS_OTG_HCINTMSK7_XFRCM                       \ Transfer completed mask
$00000002 constant OTG_FS_OTG_HCINTMSK7_CHHM                        \ Channel halted mask
$00000004 constant OTG_FS_OTG_HCINTMSK7_AHBERRM                     \ AHB error.
$00000008 constant OTG_FS_OTG_HCINTMSK7_STALLM                      \ STALL response received interrupt mask.
$00000010 constant OTG_FS_OTG_HCINTMSK7_NAKM                        \ NAK response received interrupt mask.
$00000020 constant OTG_FS_OTG_HCINTMSK7_ACKM                        \ ACK response received/transmitted interrupt mask.
$00000040 constant OTG_FS_OTG_HCINTMSK7_NYET                        \ response received interrupt mask.
$00000080 constant OTG_FS_OTG_HCINTMSK7_TXERRM                      \ Transaction error mask.
$00000100 constant OTG_FS_OTG_HCINTMSK7_BBERRM                      \ Babble error mask.
$00000200 constant OTG_FS_OTG_HCINTMSK7_FRMORM                      \ Frame overrun mask.
$00000400 constant OTG_FS_OTG_HCINTMSK7_DTERRM                      \ Data toggle error mask.


\
\ @brief OTG host channel 7 transfer size register
\ Address offset: 0x5F0
\ Reset value: 0x00000000
\

$0007ffff constant OTG_FS_OTG_HCTSIZ7_XFRSIZ                        \ Transfer size For an OUT, this field is the number of data bytes the host sends during the transfer. For an IN, this field is the buffer size that the application has reserved for the transfer. The application is expected to program this field as an integer multiple of the maximum packet size for IN transactions (periodic and non-periodic).
$1ff80000 constant OTG_FS_OTG_HCTSIZ7_PKTCNT                        \ Packet count This field is programmed by the application with the expected number of packets to be transmitted (OUT) or received (IN). The host decrements this count on every successful transmission or reception of an OUT/IN packet. Once this count reaches zero, the application is interrupted to indicate normal completion.
$60000000 constant OTG_FS_OTG_HCTSIZ7_DPID                          \ Data PID The application programs this field with the type of PID to use for the initial transaction. The host maintains this field for the rest of the transfer.
$80000000 constant OTG_FS_OTG_HCTSIZ7_DOPNG                         \ Do Ping This bit is used only for OUT transfers. Setting this field to 1 directs the host to do PING protocol. Note: Do not set this bit for IN transfers. If this bit is set for IN transfers, it disables the channel.


\
\ @brief OTG host channel 7 DMA address register
\ Address offset: 0x5F4
\ Reset value: 0x00000000
\

$00000000 constant OTG_FS_OTG_HCDMA7_DMAADDR                        \ DMA address This field holds the start address in the external memory from which the data for the endpoint must be fetched or to which it must be stored. This register is incremented on every AHB transaction.


\
\ @brief OTG host channel 8 characteristics register
\ Address offset: 0x600
\ Reset value: 0x00000000
\

$000007ff constant OTG_FS_OTG_HCCHAR8_MPSIZ                         \ Maximum packet size Indicates the maximum packet size of the associated endpoint.
$00007800 constant OTG_FS_OTG_HCCHAR8_EPNUM                         \ Endpoint number Indicates the endpoint number on the device serving as the data source or sink.
$00008000 constant OTG_FS_OTG_HCCHAR8_EPDIR                         \ Endpoint direction Indicates whether the transaction is IN or OUT.
$00020000 constant OTG_FS_OTG_HCCHAR8_LSDEV                         \ Low-speed device This field is set by the application to indicate that this channel is communicating to a low-speed device.
$000c0000 constant OTG_FS_OTG_HCCHAR8_EPTYP                         \ Endpoint type Indicates the transfer type selected.
$00300000 constant OTG_FS_OTG_HCCHAR8_MCNT                          \ Multicount This field indicates to the host the number of transactions that must be executed per frame for this periodic endpoint. For non-periodic transfers, this field is not used Note: This field must be set to at least 01.
$1fc00000 constant OTG_FS_OTG_HCCHAR8_DAD                           \ Device address This field selects the specific device serving as the data source or sink.
$20000000 constant OTG_FS_OTG_HCCHAR8_ODDFRM                        \ Odd frame This field is set (reset) by the application to indicate that the OTG host must perform a transfer in an odd frame. This field is applicable for only periodic (isochronous and interrupt) transactions.
$40000000 constant OTG_FS_OTG_HCCHAR8_CHDIS                         \ Channel disable The application sets this bit to stop transmitting/receiving data on a channel, even before the transfer for that channel is complete. The application must wait for the Channel disabled interrupt before treating the channel as disabled.
$80000000 constant OTG_FS_OTG_HCCHAR8_CHENA                         \ Channel enable This field is set by the application and cleared by the OTG host.


\
\ @brief OTG host channel 8 split control register
\ Address offset: 0x604
\ Reset value: 0x00000000
\

$0000007f constant OTG_FS_OTG_HCSPLT8_PRTADDR                       \ Port address This field is the port number of the recipient transaction translator.
$00003f80 constant OTG_FS_OTG_HCSPLT8_HUBADDR                       \ Hub address This field holds the device address of the transaction translators hub.
$0000c000 constant OTG_FS_OTG_HCSPLT8_XACTPOS                       \ Transaction position This field is used to determine whether to send all, first, middle, or last payloads with each OUT transaction.
$00010000 constant OTG_FS_OTG_HCSPLT8_COMPLSPLT                     \ Do complete split The application sets this bit to request the OTG host to perform a complete split transaction.
$80000000 constant OTG_FS_OTG_HCSPLT8_SPLITEN                       \ Split enable The application sets this bit to indicate that this channel is enabled to perform split transactions.


\
\ @brief OTG host channel 8 interrupt register
\ Address offset: 0x608
\ Reset value: 0x00000000
\

$00000001 constant OTG_FS_OTG_HCINT8_XFRC                           \ Transfer completed. Transfer completed normally without any errors.
$00000002 constant OTG_FS_OTG_HCINT8_CHH                            \ Channel halted. Indicates the transfer completed abnormally either because of any USB transaction error or in response to disable request by the application.
$00000004 constant OTG_FS_OTG_HCINT8_AHBERR                         \ AHB error This error is generated only in Internal DMA mode when an AHB error occurs during an AHB read/write operation. The application can read the corresponding DMA channel address register to get the error address.
$00000008 constant OTG_FS_OTG_HCINT8_STALL                          \ STALL response received interrupt.
$00000010 constant OTG_FS_OTG_HCINT8_NAK                            \ NAK response received interrupt.
$00000020 constant OTG_FS_OTG_HCINT8_ACK                            \ ACK response received/transmitted interrupt.
$00000040 constant OTG_FS_OTG_HCINT8_NYET                           \ Not yet ready response received interrupt.
$00000080 constant OTG_FS_OTG_HCINT8_TXERR                          \ Transaction error. Indicates one of the following errors occurred on the USB. CRC check failure Timeout Bit stuff error False EOP
$00000100 constant OTG_FS_OTG_HCINT8_BBERR                          \ Babble error.
$00000200 constant OTG_FS_OTG_HCINT8_FRMOR                          \ Frame overrun.
$00000400 constant OTG_FS_OTG_HCINT8_DTERR                          \ Data toggle error.


\
\ @brief OTG host channel 8 interrupt mask register
\ Address offset: 0x60C
\ Reset value: 0x00000000
\

$00000001 constant OTG_FS_OTG_HCINTMSK8_XFRCM                       \ Transfer completed mask
$00000002 constant OTG_FS_OTG_HCINTMSK8_CHHM                        \ Channel halted mask
$00000004 constant OTG_FS_OTG_HCINTMSK8_AHBERRM                     \ AHB error.
$00000008 constant OTG_FS_OTG_HCINTMSK8_STALLM                      \ STALL response received interrupt mask.
$00000010 constant OTG_FS_OTG_HCINTMSK8_NAKM                        \ NAK response received interrupt mask.
$00000020 constant OTG_FS_OTG_HCINTMSK8_ACKM                        \ ACK response received/transmitted interrupt mask.
$00000040 constant OTG_FS_OTG_HCINTMSK8_NYET                        \ response received interrupt mask.
$00000080 constant OTG_FS_OTG_HCINTMSK8_TXERRM                      \ Transaction error mask.
$00000100 constant OTG_FS_OTG_HCINTMSK8_BBERRM                      \ Babble error mask.
$00000200 constant OTG_FS_OTG_HCINTMSK8_FRMORM                      \ Frame overrun mask.
$00000400 constant OTG_FS_OTG_HCINTMSK8_DTERRM                      \ Data toggle error mask.


\
\ @brief OTG host channel 8 transfer size register
\ Address offset: 0x610
\ Reset value: 0x00000000
\

$0007ffff constant OTG_FS_OTG_HCTSIZ8_XFRSIZ                        \ Transfer size For an OUT, this field is the number of data bytes the host sends during the transfer. For an IN, this field is the buffer size that the application has reserved for the transfer. The application is expected to program this field as an integer multiple of the maximum packet size for IN transactions (periodic and non-periodic).
$1ff80000 constant OTG_FS_OTG_HCTSIZ8_PKTCNT                        \ Packet count This field is programmed by the application with the expected number of packets to be transmitted (OUT) or received (IN). The host decrements this count on every successful transmission or reception of an OUT/IN packet. Once this count reaches zero, the application is interrupted to indicate normal completion.
$60000000 constant OTG_FS_OTG_HCTSIZ8_DPID                          \ Data PID The application programs this field with the type of PID to use for the initial transaction. The host maintains this field for the rest of the transfer.
$80000000 constant OTG_FS_OTG_HCTSIZ8_DOPNG                         \ Do Ping This bit is used only for OUT transfers. Setting this field to 1 directs the host to do PING protocol. Note: Do not set this bit for IN transfers. If this bit is set for IN transfers, it disables the channel.


\
\ @brief OTG host channel 8 DMA address register
\ Address offset: 0x614
\ Reset value: 0x00000000
\

$00000000 constant OTG_FS_OTG_HCDMA8_DMAADDR                        \ DMA address This field holds the start address in the external memory from which the data for the endpoint must be fetched or to which it must be stored. This register is incremented on every AHB transaction.


\
\ @brief OTG host channel 9 characteristics register
\ Address offset: 0x620
\ Reset value: 0x00000000
\

$000007ff constant OTG_FS_OTG_HCCHAR9_MPSIZ                         \ Maximum packet size Indicates the maximum packet size of the associated endpoint.
$00007800 constant OTG_FS_OTG_HCCHAR9_EPNUM                         \ Endpoint number Indicates the endpoint number on the device serving as the data source or sink.
$00008000 constant OTG_FS_OTG_HCCHAR9_EPDIR                         \ Endpoint direction Indicates whether the transaction is IN or OUT.
$00020000 constant OTG_FS_OTG_HCCHAR9_LSDEV                         \ Low-speed device This field is set by the application to indicate that this channel is communicating to a low-speed device.
$000c0000 constant OTG_FS_OTG_HCCHAR9_EPTYP                         \ Endpoint type Indicates the transfer type selected.
$00300000 constant OTG_FS_OTG_HCCHAR9_MCNT                          \ Multicount This field indicates to the host the number of transactions that must be executed per frame for this periodic endpoint. For non-periodic transfers, this field is not used Note: This field must be set to at least 01.
$1fc00000 constant OTG_FS_OTG_HCCHAR9_DAD                           \ Device address This field selects the specific device serving as the data source or sink.
$20000000 constant OTG_FS_OTG_HCCHAR9_ODDFRM                        \ Odd frame This field is set (reset) by the application to indicate that the OTG host must perform a transfer in an odd frame. This field is applicable for only periodic (isochronous and interrupt) transactions.
$40000000 constant OTG_FS_OTG_HCCHAR9_CHDIS                         \ Channel disable The application sets this bit to stop transmitting/receiving data on a channel, even before the transfer for that channel is complete. The application must wait for the Channel disabled interrupt before treating the channel as disabled.
$80000000 constant OTG_FS_OTG_HCCHAR9_CHENA                         \ Channel enable This field is set by the application and cleared by the OTG host.


\
\ @brief OTG host channel 9 split control register
\ Address offset: 0x624
\ Reset value: 0x00000000
\

$0000007f constant OTG_FS_OTG_HCSPLT9_PRTADDR                       \ Port address This field is the port number of the recipient transaction translator.
$00003f80 constant OTG_FS_OTG_HCSPLT9_HUBADDR                       \ Hub address This field holds the device address of the transaction translators hub.
$0000c000 constant OTG_FS_OTG_HCSPLT9_XACTPOS                       \ Transaction position This field is used to determine whether to send all, first, middle, or last payloads with each OUT transaction.
$00010000 constant OTG_FS_OTG_HCSPLT9_COMPLSPLT                     \ Do complete split The application sets this bit to request the OTG host to perform a complete split transaction.
$80000000 constant OTG_FS_OTG_HCSPLT9_SPLITEN                       \ Split enable The application sets this bit to indicate that this channel is enabled to perform split transactions.


\
\ @brief OTG host channel 9 interrupt register
\ Address offset: 0x628
\ Reset value: 0x00000000
\

$00000001 constant OTG_FS_OTG_HCINT9_XFRC                           \ Transfer completed. Transfer completed normally without any errors.
$00000002 constant OTG_FS_OTG_HCINT9_CHH                            \ Channel halted. Indicates the transfer completed abnormally either because of any USB transaction error or in response to disable request by the application.
$00000004 constant OTG_FS_OTG_HCINT9_AHBERR                         \ AHB error This error is generated only in Internal DMA mode when an AHB error occurs during an AHB read/write operation. The application can read the corresponding DMA channel address register to get the error address.
$00000008 constant OTG_FS_OTG_HCINT9_STALL                          \ STALL response received interrupt.
$00000010 constant OTG_FS_OTG_HCINT9_NAK                            \ NAK response received interrupt.
$00000020 constant OTG_FS_OTG_HCINT9_ACK                            \ ACK response received/transmitted interrupt.
$00000040 constant OTG_FS_OTG_HCINT9_NYET                           \ Not yet ready response received interrupt.
$00000080 constant OTG_FS_OTG_HCINT9_TXERR                          \ Transaction error. Indicates one of the following errors occurred on the USB. CRC check failure Timeout Bit stuff error False EOP
$00000100 constant OTG_FS_OTG_HCINT9_BBERR                          \ Babble error.
$00000200 constant OTG_FS_OTG_HCINT9_FRMOR                          \ Frame overrun.
$00000400 constant OTG_FS_OTG_HCINT9_DTERR                          \ Data toggle error.


\
\ @brief OTG host channel 9 interrupt mask register
\ Address offset: 0x62C
\ Reset value: 0x00000000
\

$00000001 constant OTG_FS_OTG_HCINTMSK9_XFRCM                       \ Transfer completed mask
$00000002 constant OTG_FS_OTG_HCINTMSK9_CHHM                        \ Channel halted mask
$00000004 constant OTG_FS_OTG_HCINTMSK9_AHBERRM                     \ AHB error.
$00000008 constant OTG_FS_OTG_HCINTMSK9_STALLM                      \ STALL response received interrupt mask.
$00000010 constant OTG_FS_OTG_HCINTMSK9_NAKM                        \ NAK response received interrupt mask.
$00000020 constant OTG_FS_OTG_HCINTMSK9_ACKM                        \ ACK response received/transmitted interrupt mask.
$00000040 constant OTG_FS_OTG_HCINTMSK9_NYET                        \ response received interrupt mask.
$00000080 constant OTG_FS_OTG_HCINTMSK9_TXERRM                      \ Transaction error mask.
$00000100 constant OTG_FS_OTG_HCINTMSK9_BBERRM                      \ Babble error mask.
$00000200 constant OTG_FS_OTG_HCINTMSK9_FRMORM                      \ Frame overrun mask.
$00000400 constant OTG_FS_OTG_HCINTMSK9_DTERRM                      \ Data toggle error mask.


\
\ @brief OTG host channel 9 transfer size register
\ Address offset: 0x630
\ Reset value: 0x00000000
\

$0007ffff constant OTG_FS_OTG_HCTSIZ9_XFRSIZ                        \ Transfer size For an OUT, this field is the number of data bytes the host sends during the transfer. For an IN, this field is the buffer size that the application has reserved for the transfer. The application is expected to program this field as an integer multiple of the maximum packet size for IN transactions (periodic and non-periodic).
$1ff80000 constant OTG_FS_OTG_HCTSIZ9_PKTCNT                        \ Packet count This field is programmed by the application with the expected number of packets to be transmitted (OUT) or received (IN). The host decrements this count on every successful transmission or reception of an OUT/IN packet. Once this count reaches zero, the application is interrupted to indicate normal completion.
$60000000 constant OTG_FS_OTG_HCTSIZ9_DPID                          \ Data PID The application programs this field with the type of PID to use for the initial transaction. The host maintains this field for the rest of the transfer.
$80000000 constant OTG_FS_OTG_HCTSIZ9_DOPNG                         \ Do Ping This bit is used only for OUT transfers. Setting this field to 1 directs the host to do PING protocol. Note: Do not set this bit for IN transfers. If this bit is set for IN transfers, it disables the channel.


\
\ @brief OTG host channel 9 DMA address register
\ Address offset: 0x634
\ Reset value: 0x00000000
\

$00000000 constant OTG_FS_OTG_HCDMA9_DMAADDR                        \ DMA address This field holds the start address in the external memory from which the data for the endpoint must be fetched or to which it must be stored. This register is incremented on every AHB transaction.


\
\ @brief OTG host channel 10 characteristics register
\ Address offset: 0x640
\ Reset value: 0x00000000
\

$000007ff constant OTG_FS_OTG_HCCHAR10_MPSIZ                        \ Maximum packet size Indicates the maximum packet size of the associated endpoint.
$00007800 constant OTG_FS_OTG_HCCHAR10_EPNUM                        \ Endpoint number Indicates the endpoint number on the device serving as the data source or sink.
$00008000 constant OTG_FS_OTG_HCCHAR10_EPDIR                        \ Endpoint direction Indicates whether the transaction is IN or OUT.
$00020000 constant OTG_FS_OTG_HCCHAR10_LSDEV                        \ Low-speed device This field is set by the application to indicate that this channel is communicating to a low-speed device.
$000c0000 constant OTG_FS_OTG_HCCHAR10_EPTYP                        \ Endpoint type Indicates the transfer type selected.
$00300000 constant OTG_FS_OTG_HCCHAR10_MCNT                         \ Multicount This field indicates to the host the number of transactions that must be executed per frame for this periodic endpoint. For non-periodic transfers, this field is not used Note: This field must be set to at least 01.
$1fc00000 constant OTG_FS_OTG_HCCHAR10_DAD                          \ Device address This field selects the specific device serving as the data source or sink.
$20000000 constant OTG_FS_OTG_HCCHAR10_ODDFRM                       \ Odd frame This field is set (reset) by the application to indicate that the OTG host must perform a transfer in an odd frame. This field is applicable for only periodic (isochronous and interrupt) transactions.
$40000000 constant OTG_FS_OTG_HCCHAR10_CHDIS                        \ Channel disable The application sets this bit to stop transmitting/receiving data on a channel, even before the transfer for that channel is complete. The application must wait for the Channel disabled interrupt before treating the channel as disabled.
$80000000 constant OTG_FS_OTG_HCCHAR10_CHENA                        \ Channel enable This field is set by the application and cleared by the OTG host.


\
\ @brief OTG host channel 10 split control register
\ Address offset: 0x644
\ Reset value: 0x00000000
\

$0000007f constant OTG_FS_OTG_HCSPLT10_PRTADDR                      \ Port address This field is the port number of the recipient transaction translator.
$00003f80 constant OTG_FS_OTG_HCSPLT10_HUBADDR                      \ Hub address This field holds the device address of the transaction translators hub.
$0000c000 constant OTG_FS_OTG_HCSPLT10_XACTPOS                      \ Transaction position This field is used to determine whether to send all, first, middle, or last payloads with each OUT transaction.
$00010000 constant OTG_FS_OTG_HCSPLT10_COMPLSPLT                    \ Do complete split The application sets this bit to request the OTG host to perform a complete split transaction.
$80000000 constant OTG_FS_OTG_HCSPLT10_SPLITEN                      \ Split enable The application sets this bit to indicate that this channel is enabled to perform split transactions.


\
\ @brief OTG host channel 10 interrupt register
\ Address offset: 0x648
\ Reset value: 0x00000000
\

$00000001 constant OTG_FS_OTG_HCINT10_XFRC                          \ Transfer completed. Transfer completed normally without any errors.
$00000002 constant OTG_FS_OTG_HCINT10_CHH                           \ Channel halted. Indicates the transfer completed abnormally either because of any USB transaction error or in response to disable request by the application.
$00000004 constant OTG_FS_OTG_HCINT10_AHBERR                        \ AHB error This error is generated only in Internal DMA mode when an AHB error occurs during an AHB read/write operation. The application can read the corresponding DMA channel address register to get the error address.
$00000008 constant OTG_FS_OTG_HCINT10_STALL                         \ STALL response received interrupt.
$00000010 constant OTG_FS_OTG_HCINT10_NAK                           \ NAK response received interrupt.
$00000020 constant OTG_FS_OTG_HCINT10_ACK                           \ ACK response received/transmitted interrupt.
$00000040 constant OTG_FS_OTG_HCINT10_NYET                          \ Not yet ready response received interrupt.
$00000080 constant OTG_FS_OTG_HCINT10_TXERR                         \ Transaction error. Indicates one of the following errors occurred on the USB. CRC check failure Timeout Bit stuff error False EOP
$00000100 constant OTG_FS_OTG_HCINT10_BBERR                         \ Babble error.
$00000200 constant OTG_FS_OTG_HCINT10_FRMOR                         \ Frame overrun.
$00000400 constant OTG_FS_OTG_HCINT10_DTERR                         \ Data toggle error.


\
\ @brief OTG host channel 10 interrupt mask register
\ Address offset: 0x64C
\ Reset value: 0x00000000
\

$00000001 constant OTG_FS_OTG_HCINTMSK10_XFRCM                      \ Transfer completed mask
$00000002 constant OTG_FS_OTG_HCINTMSK10_CHHM                       \ Channel halted mask
$00000004 constant OTG_FS_OTG_HCINTMSK10_AHBERRM                    \ AHB error.
$00000008 constant OTG_FS_OTG_HCINTMSK10_STALLM                     \ STALL response received interrupt mask.
$00000010 constant OTG_FS_OTG_HCINTMSK10_NAKM                       \ NAK response received interrupt mask.
$00000020 constant OTG_FS_OTG_HCINTMSK10_ACKM                       \ ACK response received/transmitted interrupt mask.
$00000040 constant OTG_FS_OTG_HCINTMSK10_NYET                       \ response received interrupt mask.
$00000080 constant OTG_FS_OTG_HCINTMSK10_TXERRM                     \ Transaction error mask.
$00000100 constant OTG_FS_OTG_HCINTMSK10_BBERRM                     \ Babble error mask.
$00000200 constant OTG_FS_OTG_HCINTMSK10_FRMORM                     \ Frame overrun mask.
$00000400 constant OTG_FS_OTG_HCINTMSK10_DTERRM                     \ Data toggle error mask.


\
\ @brief OTG host channel 10 transfer size register
\ Address offset: 0x650
\ Reset value: 0x00000000
\

$0007ffff constant OTG_FS_OTG_HCTSIZ10_XFRSIZ                       \ Transfer size For an OUT, this field is the number of data bytes the host sends during the transfer. For an IN, this field is the buffer size that the application has reserved for the transfer. The application is expected to program this field as an integer multiple of the maximum packet size for IN transactions (periodic and non-periodic).
$1ff80000 constant OTG_FS_OTG_HCTSIZ10_PKTCNT                       \ Packet count This field is programmed by the application with the expected number of packets to be transmitted (OUT) or received (IN). The host decrements this count on every successful transmission or reception of an OUT/IN packet. Once this count reaches zero, the application is interrupted to indicate normal completion.
$60000000 constant OTG_FS_OTG_HCTSIZ10_DPID                         \ Data PID The application programs this field with the type of PID to use for the initial transaction. The host maintains this field for the rest of the transfer.
$80000000 constant OTG_FS_OTG_HCTSIZ10_DOPNG                        \ Do Ping This bit is used only for OUT transfers. Setting this field to 1 directs the host to do PING protocol. Note: Do not set this bit for IN transfers. If this bit is set for IN transfers, it disables the channel.


\
\ @brief OTG host channel 10 DMA address register
\ Address offset: 0x654
\ Reset value: 0x00000000
\

$00000000 constant OTG_FS_OTG_HCDMA10_DMAADDR                       \ DMA address This field holds the start address in the external memory from which the data for the endpoint must be fetched or to which it must be stored. This register is incremented on every AHB transaction.


\
\ @brief OTG host channel 11 characteristics register
\ Address offset: 0x660
\ Reset value: 0x00000000
\

$000007ff constant OTG_FS_OTG_HCCHAR11_MPSIZ                        \ Maximum packet size Indicates the maximum packet size of the associated endpoint.
$00007800 constant OTG_FS_OTG_HCCHAR11_EPNUM                        \ Endpoint number Indicates the endpoint number on the device serving as the data source or sink.
$00008000 constant OTG_FS_OTG_HCCHAR11_EPDIR                        \ Endpoint direction Indicates whether the transaction is IN or OUT.
$00020000 constant OTG_FS_OTG_HCCHAR11_LSDEV                        \ Low-speed device This field is set by the application to indicate that this channel is communicating to a low-speed device.
$000c0000 constant OTG_FS_OTG_HCCHAR11_EPTYP                        \ Endpoint type Indicates the transfer type selected.
$00300000 constant OTG_FS_OTG_HCCHAR11_MCNT                         \ Multicount This field indicates to the host the number of transactions that must be executed per frame for this periodic endpoint. For non-periodic transfers, this field is not used Note: This field must be set to at least 01.
$1fc00000 constant OTG_FS_OTG_HCCHAR11_DAD                          \ Device address This field selects the specific device serving as the data source or sink.
$20000000 constant OTG_FS_OTG_HCCHAR11_ODDFRM                       \ Odd frame This field is set (reset) by the application to indicate that the OTG host must perform a transfer in an odd frame. This field is applicable for only periodic (isochronous and interrupt) transactions.
$40000000 constant OTG_FS_OTG_HCCHAR11_CHDIS                        \ Channel disable The application sets this bit to stop transmitting/receiving data on a channel, even before the transfer for that channel is complete. The application must wait for the Channel disabled interrupt before treating the channel as disabled.
$80000000 constant OTG_FS_OTG_HCCHAR11_CHENA                        \ Channel enable This field is set by the application and cleared by the OTG host.


\
\ @brief OTG host channel 11 split control register
\ Address offset: 0x664
\ Reset value: 0x00000000
\

$0000007f constant OTG_FS_OTG_HCSPLT11_PRTADDR                      \ Port address This field is the port number of the recipient transaction translator.
$00003f80 constant OTG_FS_OTG_HCSPLT11_HUBADDR                      \ Hub address This field holds the device address of the transaction translators hub.
$0000c000 constant OTG_FS_OTG_HCSPLT11_XACTPOS                      \ Transaction position This field is used to determine whether to send all, first, middle, or last payloads with each OUT transaction.
$00010000 constant OTG_FS_OTG_HCSPLT11_COMPLSPLT                    \ Do complete split The application sets this bit to request the OTG host to perform a complete split transaction.
$80000000 constant OTG_FS_OTG_HCSPLT11_SPLITEN                      \ Split enable The application sets this bit to indicate that this channel is enabled to perform split transactions.


\
\ @brief OTG host channel 11 interrupt register
\ Address offset: 0x668
\ Reset value: 0x00000000
\

$00000001 constant OTG_FS_OTG_HCINT11_XFRC                          \ Transfer completed. Transfer completed normally without any errors.
$00000002 constant OTG_FS_OTG_HCINT11_CHH                           \ Channel halted. Indicates the transfer completed abnormally either because of any USB transaction error or in response to disable request by the application.
$00000004 constant OTG_FS_OTG_HCINT11_AHBERR                        \ AHB error This error is generated only in Internal DMA mode when an AHB error occurs during an AHB read/write operation. The application can read the corresponding DMA channel address register to get the error address.
$00000008 constant OTG_FS_OTG_HCINT11_STALL                         \ STALL response received interrupt.
$00000010 constant OTG_FS_OTG_HCINT11_NAK                           \ NAK response received interrupt.
$00000020 constant OTG_FS_OTG_HCINT11_ACK                           \ ACK response received/transmitted interrupt.
$00000040 constant OTG_FS_OTG_HCINT11_NYET                          \ Not yet ready response received interrupt.
$00000080 constant OTG_FS_OTG_HCINT11_TXERR                         \ Transaction error. Indicates one of the following errors occurred on the USB. CRC check failure Timeout Bit stuff error False EOP
$00000100 constant OTG_FS_OTG_HCINT11_BBERR                         \ Babble error.
$00000200 constant OTG_FS_OTG_HCINT11_FRMOR                         \ Frame overrun.
$00000400 constant OTG_FS_OTG_HCINT11_DTERR                         \ Data toggle error.


\
\ @brief OTG host channel 11 interrupt mask register
\ Address offset: 0x66C
\ Reset value: 0x00000000
\

$00000001 constant OTG_FS_OTG_HCINTMSK11_XFRCM                      \ Transfer completed mask
$00000002 constant OTG_FS_OTG_HCINTMSK11_CHHM                       \ Channel halted mask
$00000004 constant OTG_FS_OTG_HCINTMSK11_AHBERRM                    \ AHB error.
$00000008 constant OTG_FS_OTG_HCINTMSK11_STALLM                     \ STALL response received interrupt mask.
$00000010 constant OTG_FS_OTG_HCINTMSK11_NAKM                       \ NAK response received interrupt mask.
$00000020 constant OTG_FS_OTG_HCINTMSK11_ACKM                       \ ACK response received/transmitted interrupt mask.
$00000040 constant OTG_FS_OTG_HCINTMSK11_NYET                       \ response received interrupt mask.
$00000080 constant OTG_FS_OTG_HCINTMSK11_TXERRM                     \ Transaction error mask.
$00000100 constant OTG_FS_OTG_HCINTMSK11_BBERRM                     \ Babble error mask.
$00000200 constant OTG_FS_OTG_HCINTMSK11_FRMORM                     \ Frame overrun mask.
$00000400 constant OTG_FS_OTG_HCINTMSK11_DTERRM                     \ Data toggle error mask.


\
\ @brief OTG host channel 11 transfer size register
\ Address offset: 0x670
\ Reset value: 0x00000000
\

$0007ffff constant OTG_FS_OTG_HCTSIZ11_XFRSIZ                       \ Transfer size For an OUT, this field is the number of data bytes the host sends during the transfer. For an IN, this field is the buffer size that the application has reserved for the transfer. The application is expected to program this field as an integer multiple of the maximum packet size for IN transactions (periodic and non-periodic).
$1ff80000 constant OTG_FS_OTG_HCTSIZ11_PKTCNT                       \ Packet count This field is programmed by the application with the expected number of packets to be transmitted (OUT) or received (IN). The host decrements this count on every successful transmission or reception of an OUT/IN packet. Once this count reaches zero, the application is interrupted to indicate normal completion.
$60000000 constant OTG_FS_OTG_HCTSIZ11_DPID                         \ Data PID The application programs this field with the type of PID to use for the initial transaction. The host maintains this field for the rest of the transfer.
$80000000 constant OTG_FS_OTG_HCTSIZ11_DOPNG                        \ Do Ping This bit is used only for OUT transfers. Setting this field to 1 directs the host to do PING protocol. Note: Do not set this bit for IN transfers. If this bit is set for IN transfers, it disables the channel.


\
\ @brief OTG host channel 11 DMA address register
\ Address offset: 0x674
\ Reset value: 0x00000000
\

$00000000 constant OTG_FS_OTG_HCDMA11_DMAADDR                       \ DMA address This field holds the start address in the external memory from which the data for the endpoint must be fetched or to which it must be stored. This register is incremented on every AHB transaction.


\
\ @brief OTG host channel 12 characteristics register
\ Address offset: 0x680
\ Reset value: 0x00000000
\

$000007ff constant OTG_FS_OTG_HCCHAR12_MPSIZ                        \ Maximum packet size Indicates the maximum packet size of the associated endpoint.
$00007800 constant OTG_FS_OTG_HCCHAR12_EPNUM                        \ Endpoint number Indicates the endpoint number on the device serving as the data source or sink.
$00008000 constant OTG_FS_OTG_HCCHAR12_EPDIR                        \ Endpoint direction Indicates whether the transaction is IN or OUT.
$00020000 constant OTG_FS_OTG_HCCHAR12_LSDEV                        \ Low-speed device This field is set by the application to indicate that this channel is communicating to a low-speed device.
$000c0000 constant OTG_FS_OTG_HCCHAR12_EPTYP                        \ Endpoint type Indicates the transfer type selected.
$00300000 constant OTG_FS_OTG_HCCHAR12_MCNT                         \ Multicount This field indicates to the host the number of transactions that must be executed per frame for this periodic endpoint. For non-periodic transfers, this field is not used Note: This field must be set to at least 01.
$1fc00000 constant OTG_FS_OTG_HCCHAR12_DAD                          \ Device address This field selects the specific device serving as the data source or sink.
$20000000 constant OTG_FS_OTG_HCCHAR12_ODDFRM                       \ Odd frame This field is set (reset) by the application to indicate that the OTG host must perform a transfer in an odd frame. This field is applicable for only periodic (isochronous and interrupt) transactions.
$40000000 constant OTG_FS_OTG_HCCHAR12_CHDIS                        \ Channel disable The application sets this bit to stop transmitting/receiving data on a channel, even before the transfer for that channel is complete. The application must wait for the Channel disabled interrupt before treating the channel as disabled.
$80000000 constant OTG_FS_OTG_HCCHAR12_CHENA                        \ Channel enable This field is set by the application and cleared by the OTG host.


\
\ @brief OTG host channel 12 split control register
\ Address offset: 0x684
\ Reset value: 0x00000000
\

$0000007f constant OTG_FS_OTG_HCSPLT12_PRTADDR                      \ Port address This field is the port number of the recipient transaction translator.
$00003f80 constant OTG_FS_OTG_HCSPLT12_HUBADDR                      \ Hub address This field holds the device address of the transaction translators hub.
$0000c000 constant OTG_FS_OTG_HCSPLT12_XACTPOS                      \ Transaction position This field is used to determine whether to send all, first, middle, or last payloads with each OUT transaction.
$00010000 constant OTG_FS_OTG_HCSPLT12_COMPLSPLT                    \ Do complete split The application sets this bit to request the OTG host to perform a complete split transaction.
$80000000 constant OTG_FS_OTG_HCSPLT12_SPLITEN                      \ Split enable The application sets this bit to indicate that this channel is enabled to perform split transactions.


\
\ @brief OTG host channel 12 interrupt register
\ Address offset: 0x688
\ Reset value: 0x00000000
\

$00000001 constant OTG_FS_OTG_HCINT12_XFRC                          \ Transfer completed. Transfer completed normally without any errors.
$00000002 constant OTG_FS_OTG_HCINT12_CHH                           \ Channel halted. Indicates the transfer completed abnormally either because of any USB transaction error or in response to disable request by the application.
$00000004 constant OTG_FS_OTG_HCINT12_AHBERR                        \ AHB error This error is generated only in Internal DMA mode when an AHB error occurs during an AHB read/write operation. The application can read the corresponding DMA channel address register to get the error address.
$00000008 constant OTG_FS_OTG_HCINT12_STALL                         \ STALL response received interrupt.
$00000010 constant OTG_FS_OTG_HCINT12_NAK                           \ NAK response received interrupt.
$00000020 constant OTG_FS_OTG_HCINT12_ACK                           \ ACK response received/transmitted interrupt.
$00000040 constant OTG_FS_OTG_HCINT12_NYET                          \ Not yet ready response received interrupt.
$00000080 constant OTG_FS_OTG_HCINT12_TXERR                         \ Transaction error. Indicates one of the following errors occurred on the USB. CRC check failure Timeout Bit stuff error False EOP
$00000100 constant OTG_FS_OTG_HCINT12_BBERR                         \ Babble error.
$00000200 constant OTG_FS_OTG_HCINT12_FRMOR                         \ Frame overrun.
$00000400 constant OTG_FS_OTG_HCINT12_DTERR                         \ Data toggle error.


\
\ @brief OTG host channel 12 interrupt mask register
\ Address offset: 0x68C
\ Reset value: 0x00000000
\

$00000001 constant OTG_FS_OTG_HCINTMSK12_XFRCM                      \ Transfer completed mask
$00000002 constant OTG_FS_OTG_HCINTMSK12_CHHM                       \ Channel halted mask
$00000004 constant OTG_FS_OTG_HCINTMSK12_AHBERRM                    \ AHB error.
$00000008 constant OTG_FS_OTG_HCINTMSK12_STALLM                     \ STALL response received interrupt mask.
$00000010 constant OTG_FS_OTG_HCINTMSK12_NAKM                       \ NAK response received interrupt mask.
$00000020 constant OTG_FS_OTG_HCINTMSK12_ACKM                       \ ACK response received/transmitted interrupt mask.
$00000040 constant OTG_FS_OTG_HCINTMSK12_NYET                       \ response received interrupt mask.
$00000080 constant OTG_FS_OTG_HCINTMSK12_TXERRM                     \ Transaction error mask.
$00000100 constant OTG_FS_OTG_HCINTMSK12_BBERRM                     \ Babble error mask.
$00000200 constant OTG_FS_OTG_HCINTMSK12_FRMORM                     \ Frame overrun mask.
$00000400 constant OTG_FS_OTG_HCINTMSK12_DTERRM                     \ Data toggle error mask.


\
\ @brief OTG host channel 12 transfer size register
\ Address offset: 0x690
\ Reset value: 0x00000000
\

$0007ffff constant OTG_FS_OTG_HCTSIZ12_XFRSIZ                       \ Transfer size For an OUT, this field is the number of data bytes the host sends during the transfer. For an IN, this field is the buffer size that the application has reserved for the transfer. The application is expected to program this field as an integer multiple of the maximum packet size for IN transactions (periodic and non-periodic).
$1ff80000 constant OTG_FS_OTG_HCTSIZ12_PKTCNT                       \ Packet count This field is programmed by the application with the expected number of packets to be transmitted (OUT) or received (IN). The host decrements this count on every successful transmission or reception of an OUT/IN packet. Once this count reaches zero, the application is interrupted to indicate normal completion.
$60000000 constant OTG_FS_OTG_HCTSIZ12_DPID                         \ Data PID The application programs this field with the type of PID to use for the initial transaction. The host maintains this field for the rest of the transfer.
$80000000 constant OTG_FS_OTG_HCTSIZ12_DOPNG                        \ Do Ping This bit is used only for OUT transfers. Setting this field to 1 directs the host to do PING protocol. Note: Do not set this bit for IN transfers. If this bit is set for IN transfers, it disables the channel.


\
\ @brief OTG host channel 12 DMA address register
\ Address offset: 0x694
\ Reset value: 0x00000000
\

$00000000 constant OTG_FS_OTG_HCDMA12_DMAADDR                       \ DMA address This field holds the start address in the external memory from which the data for the endpoint must be fetched or to which it must be stored. This register is incremented on every AHB transaction.


\
\ @brief OTG host channel 13 characteristics register
\ Address offset: 0x6A0
\ Reset value: 0x00000000
\

$000007ff constant OTG_FS_OTG_HCCHAR13_MPSIZ                        \ Maximum packet size Indicates the maximum packet size of the associated endpoint.
$00007800 constant OTG_FS_OTG_HCCHAR13_EPNUM                        \ Endpoint number Indicates the endpoint number on the device serving as the data source or sink.
$00008000 constant OTG_FS_OTG_HCCHAR13_EPDIR                        \ Endpoint direction Indicates whether the transaction is IN or OUT.
$00020000 constant OTG_FS_OTG_HCCHAR13_LSDEV                        \ Low-speed device This field is set by the application to indicate that this channel is communicating to a low-speed device.
$000c0000 constant OTG_FS_OTG_HCCHAR13_EPTYP                        \ Endpoint type Indicates the transfer type selected.
$00300000 constant OTG_FS_OTG_HCCHAR13_MCNT                         \ Multicount This field indicates to the host the number of transactions that must be executed per frame for this periodic endpoint. For non-periodic transfers, this field is not used Note: This field must be set to at least 01.
$1fc00000 constant OTG_FS_OTG_HCCHAR13_DAD                          \ Device address This field selects the specific device serving as the data source or sink.
$20000000 constant OTG_FS_OTG_HCCHAR13_ODDFRM                       \ Odd frame This field is set (reset) by the application to indicate that the OTG host must perform a transfer in an odd frame. This field is applicable for only periodic (isochronous and interrupt) transactions.
$40000000 constant OTG_FS_OTG_HCCHAR13_CHDIS                        \ Channel disable The application sets this bit to stop transmitting/receiving data on a channel, even before the transfer for that channel is complete. The application must wait for the Channel disabled interrupt before treating the channel as disabled.
$80000000 constant OTG_FS_OTG_HCCHAR13_CHENA                        \ Channel enable This field is set by the application and cleared by the OTG host.


\
\ @brief OTG host channel 13 split control register
\ Address offset: 0x6A4
\ Reset value: 0x00000000
\

$0000007f constant OTG_FS_OTG_HCSPLT13_PRTADDR                      \ Port address This field is the port number of the recipient transaction translator.
$00003f80 constant OTG_FS_OTG_HCSPLT13_HUBADDR                      \ Hub address This field holds the device address of the transaction translators hub.
$0000c000 constant OTG_FS_OTG_HCSPLT13_XACTPOS                      \ Transaction position This field is used to determine whether to send all, first, middle, or last payloads with each OUT transaction.
$00010000 constant OTG_FS_OTG_HCSPLT13_COMPLSPLT                    \ Do complete split The application sets this bit to request the OTG host to perform a complete split transaction.
$80000000 constant OTG_FS_OTG_HCSPLT13_SPLITEN                      \ Split enable The application sets this bit to indicate that this channel is enabled to perform split transactions.


\
\ @brief OTG host channel 13 interrupt register
\ Address offset: 0x6A8
\ Reset value: 0x00000000
\

$00000001 constant OTG_FS_OTG_HCINT13_XFRC                          \ Transfer completed. Transfer completed normally without any errors.
$00000002 constant OTG_FS_OTG_HCINT13_CHH                           \ Channel halted. Indicates the transfer completed abnormally either because of any USB transaction error or in response to disable request by the application.
$00000004 constant OTG_FS_OTG_HCINT13_AHBERR                        \ AHB error This error is generated only in Internal DMA mode when an AHB error occurs during an AHB read/write operation. The application can read the corresponding DMA channel address register to get the error address.
$00000008 constant OTG_FS_OTG_HCINT13_STALL                         \ STALL response received interrupt.
$00000010 constant OTG_FS_OTG_HCINT13_NAK                           \ NAK response received interrupt.
$00000020 constant OTG_FS_OTG_HCINT13_ACK                           \ ACK response received/transmitted interrupt.
$00000040 constant OTG_FS_OTG_HCINT13_NYET                          \ Not yet ready response received interrupt.
$00000080 constant OTG_FS_OTG_HCINT13_TXERR                         \ Transaction error. Indicates one of the following errors occurred on the USB. CRC check failure Timeout Bit stuff error False EOP
$00000100 constant OTG_FS_OTG_HCINT13_BBERR                         \ Babble error.
$00000200 constant OTG_FS_OTG_HCINT13_FRMOR                         \ Frame overrun.
$00000400 constant OTG_FS_OTG_HCINT13_DTERR                         \ Data toggle error.


\
\ @brief OTG host channel 13 interrupt mask register
\ Address offset: 0x6AC
\ Reset value: 0x00000000
\

$00000001 constant OTG_FS_OTG_HCINTMSK13_XFRCM                      \ Transfer completed mask
$00000002 constant OTG_FS_OTG_HCINTMSK13_CHHM                       \ Channel halted mask
$00000004 constant OTG_FS_OTG_HCINTMSK13_AHBERRM                    \ AHB error.
$00000008 constant OTG_FS_OTG_HCINTMSK13_STALLM                     \ STALL response received interrupt mask.
$00000010 constant OTG_FS_OTG_HCINTMSK13_NAKM                       \ NAK response received interrupt mask.
$00000020 constant OTG_FS_OTG_HCINTMSK13_ACKM                       \ ACK response received/transmitted interrupt mask.
$00000040 constant OTG_FS_OTG_HCINTMSK13_NYET                       \ response received interrupt mask.
$00000080 constant OTG_FS_OTG_HCINTMSK13_TXERRM                     \ Transaction error mask.
$00000100 constant OTG_FS_OTG_HCINTMSK13_BBERRM                     \ Babble error mask.
$00000200 constant OTG_FS_OTG_HCINTMSK13_FRMORM                     \ Frame overrun mask.
$00000400 constant OTG_FS_OTG_HCINTMSK13_DTERRM                     \ Data toggle error mask.


\
\ @brief OTG host channel 13 transfer size register
\ Address offset: 0x6B0
\ Reset value: 0x00000000
\

$0007ffff constant OTG_FS_OTG_HCTSIZ13_XFRSIZ                       \ Transfer size For an OUT, this field is the number of data bytes the host sends during the transfer. For an IN, this field is the buffer size that the application has reserved for the transfer. The application is expected to program this field as an integer multiple of the maximum packet size for IN transactions (periodic and non-periodic).
$1ff80000 constant OTG_FS_OTG_HCTSIZ13_PKTCNT                       \ Packet count This field is programmed by the application with the expected number of packets to be transmitted (OUT) or received (IN). The host decrements this count on every successful transmission or reception of an OUT/IN packet. Once this count reaches zero, the application is interrupted to indicate normal completion.
$60000000 constant OTG_FS_OTG_HCTSIZ13_DPID                         \ Data PID The application programs this field with the type of PID to use for the initial transaction. The host maintains this field for the rest of the transfer.
$80000000 constant OTG_FS_OTG_HCTSIZ13_DOPNG                        \ Do Ping This bit is used only for OUT transfers. Setting this field to 1 directs the host to do PING protocol. Note: Do not set this bit for IN transfers. If this bit is set for IN transfers, it disables the channel.


\
\ @brief OTG host channel 13 DMA address register
\ Address offset: 0x6B4
\ Reset value: 0x00000000
\

$00000000 constant OTG_FS_OTG_HCDMA13_DMAADDR                       \ DMA address This field holds the start address in the external memory from which the data for the endpoint must be fetched or to which it must be stored. This register is incremented on every AHB transaction.


\
\ @brief OTG host channel 14 characteristics register
\ Address offset: 0x6C0
\ Reset value: 0x00000000
\

$000007ff constant OTG_FS_OTG_HCCHAR14_MPSIZ                        \ Maximum packet size Indicates the maximum packet size of the associated endpoint.
$00007800 constant OTG_FS_OTG_HCCHAR14_EPNUM                        \ Endpoint number Indicates the endpoint number on the device serving as the data source or sink.
$00008000 constant OTG_FS_OTG_HCCHAR14_EPDIR                        \ Endpoint direction Indicates whether the transaction is IN or OUT.
$00020000 constant OTG_FS_OTG_HCCHAR14_LSDEV                        \ Low-speed device This field is set by the application to indicate that this channel is communicating to a low-speed device.
$000c0000 constant OTG_FS_OTG_HCCHAR14_EPTYP                        \ Endpoint type Indicates the transfer type selected.
$00300000 constant OTG_FS_OTG_HCCHAR14_MCNT                         \ Multicount This field indicates to the host the number of transactions that must be executed per frame for this periodic endpoint. For non-periodic transfers, this field is not used Note: This field must be set to at least 01.
$1fc00000 constant OTG_FS_OTG_HCCHAR14_DAD                          \ Device address This field selects the specific device serving as the data source or sink.
$20000000 constant OTG_FS_OTG_HCCHAR14_ODDFRM                       \ Odd frame This field is set (reset) by the application to indicate that the OTG host must perform a transfer in an odd frame. This field is applicable for only periodic (isochronous and interrupt) transactions.
$40000000 constant OTG_FS_OTG_HCCHAR14_CHDIS                        \ Channel disable The application sets this bit to stop transmitting/receiving data on a channel, even before the transfer for that channel is complete. The application must wait for the Channel disabled interrupt before treating the channel as disabled.
$80000000 constant OTG_FS_OTG_HCCHAR14_CHENA                        \ Channel enable This field is set by the application and cleared by the OTG host.


\
\ @brief OTG host channel 14 split control register
\ Address offset: 0x6C4
\ Reset value: 0x00000000
\

$0000007f constant OTG_FS_OTG_HCSPLT14_PRTADDR                      \ Port address This field is the port number of the recipient transaction translator.
$00003f80 constant OTG_FS_OTG_HCSPLT14_HUBADDR                      \ Hub address This field holds the device address of the transaction translators hub.
$0000c000 constant OTG_FS_OTG_HCSPLT14_XACTPOS                      \ Transaction position This field is used to determine whether to send all, first, middle, or last payloads with each OUT transaction.
$00010000 constant OTG_FS_OTG_HCSPLT14_COMPLSPLT                    \ Do complete split The application sets this bit to request the OTG host to perform a complete split transaction.
$80000000 constant OTG_FS_OTG_HCSPLT14_SPLITEN                      \ Split enable The application sets this bit to indicate that this channel is enabled to perform split transactions.


\
\ @brief OTG host channel 14 interrupt register
\ Address offset: 0x6C8
\ Reset value: 0x00000000
\

$00000001 constant OTG_FS_OTG_HCINT14_XFRC                          \ Transfer completed. Transfer completed normally without any errors.
$00000002 constant OTG_FS_OTG_HCINT14_CHH                           \ Channel halted. Indicates the transfer completed abnormally either because of any USB transaction error or in response to disable request by the application.
$00000004 constant OTG_FS_OTG_HCINT14_AHBERR                        \ AHB error This error is generated only in Internal DMA mode when an AHB error occurs during an AHB read/write operation. The application can read the corresponding DMA channel address register to get the error address.
$00000008 constant OTG_FS_OTG_HCINT14_STALL                         \ STALL response received interrupt.
$00000010 constant OTG_FS_OTG_HCINT14_NAK                           \ NAK response received interrupt.
$00000020 constant OTG_FS_OTG_HCINT14_ACK                           \ ACK response received/transmitted interrupt.
$00000040 constant OTG_FS_OTG_HCINT14_NYET                          \ Not yet ready response received interrupt.
$00000080 constant OTG_FS_OTG_HCINT14_TXERR                         \ Transaction error. Indicates one of the following errors occurred on the USB. CRC check failure Timeout Bit stuff error False EOP
$00000100 constant OTG_FS_OTG_HCINT14_BBERR                         \ Babble error.
$00000200 constant OTG_FS_OTG_HCINT14_FRMOR                         \ Frame overrun.
$00000400 constant OTG_FS_OTG_HCINT14_DTERR                         \ Data toggle error.


\
\ @brief OTG host channel 14 interrupt mask register
\ Address offset: 0x6CC
\ Reset value: 0x00000000
\

$00000001 constant OTG_FS_OTG_HCINTMSK14_XFRCM                      \ Transfer completed mask
$00000002 constant OTG_FS_OTG_HCINTMSK14_CHHM                       \ Channel halted mask
$00000004 constant OTG_FS_OTG_HCINTMSK14_AHBERRM                    \ AHB error.
$00000008 constant OTG_FS_OTG_HCINTMSK14_STALLM                     \ STALL response received interrupt mask.
$00000010 constant OTG_FS_OTG_HCINTMSK14_NAKM                       \ NAK response received interrupt mask.
$00000020 constant OTG_FS_OTG_HCINTMSK14_ACKM                       \ ACK response received/transmitted interrupt mask.
$00000040 constant OTG_FS_OTG_HCINTMSK14_NYET                       \ response received interrupt mask.
$00000080 constant OTG_FS_OTG_HCINTMSK14_TXERRM                     \ Transaction error mask.
$00000100 constant OTG_FS_OTG_HCINTMSK14_BBERRM                     \ Babble error mask.
$00000200 constant OTG_FS_OTG_HCINTMSK14_FRMORM                     \ Frame overrun mask.
$00000400 constant OTG_FS_OTG_HCINTMSK14_DTERRM                     \ Data toggle error mask.


\
\ @brief OTG host channel 14 transfer size register
\ Address offset: 0x6D0
\ Reset value: 0x00000000
\

$0007ffff constant OTG_FS_OTG_HCTSIZ14_XFRSIZ                       \ Transfer size For an OUT, this field is the number of data bytes the host sends during the transfer. For an IN, this field is the buffer size that the application has reserved for the transfer. The application is expected to program this field as an integer multiple of the maximum packet size for IN transactions (periodic and non-periodic).
$1ff80000 constant OTG_FS_OTG_HCTSIZ14_PKTCNT                       \ Packet count This field is programmed by the application with the expected number of packets to be transmitted (OUT) or received (IN). The host decrements this count on every successful transmission or reception of an OUT/IN packet. Once this count reaches zero, the application is interrupted to indicate normal completion.
$60000000 constant OTG_FS_OTG_HCTSIZ14_DPID                         \ Data PID The application programs this field with the type of PID to use for the initial transaction. The host maintains this field for the rest of the transfer.
$80000000 constant OTG_FS_OTG_HCTSIZ14_DOPNG                        \ Do Ping This bit is used only for OUT transfers. Setting this field to 1 directs the host to do PING protocol. Note: Do not set this bit for IN transfers. If this bit is set for IN transfers, it disables the channel.


\
\ @brief OTG host channel 14 DMA address register
\ Address offset: 0x6D4
\ Reset value: 0x00000000
\

$00000000 constant OTG_FS_OTG_HCDMA14_DMAADDR                       \ DMA address This field holds the start address in the external memory from which the data for the endpoint must be fetched or to which it must be stored. This register is incremented on every AHB transaction.


\
\ @brief OTG host channel 15 characteristics register
\ Address offset: 0x6E0
\ Reset value: 0x00000000
\

$000007ff constant OTG_FS_OTG_HCCHAR15_MPSIZ                        \ Maximum packet size Indicates the maximum packet size of the associated endpoint.
$00007800 constant OTG_FS_OTG_HCCHAR15_EPNUM                        \ Endpoint number Indicates the endpoint number on the device serving as the data source or sink.
$00008000 constant OTG_FS_OTG_HCCHAR15_EPDIR                        \ Endpoint direction Indicates whether the transaction is IN or OUT.
$00020000 constant OTG_FS_OTG_HCCHAR15_LSDEV                        \ Low-speed device This field is set by the application to indicate that this channel is communicating to a low-speed device.
$000c0000 constant OTG_FS_OTG_HCCHAR15_EPTYP                        \ Endpoint type Indicates the transfer type selected.
$00300000 constant OTG_FS_OTG_HCCHAR15_MCNT                         \ Multicount This field indicates to the host the number of transactions that must be executed per frame for this periodic endpoint. For non-periodic transfers, this field is not used Note: This field must be set to at least 01.
$1fc00000 constant OTG_FS_OTG_HCCHAR15_DAD                          \ Device address This field selects the specific device serving as the data source or sink.
$20000000 constant OTG_FS_OTG_HCCHAR15_ODDFRM                       \ Odd frame This field is set (reset) by the application to indicate that the OTG host must perform a transfer in an odd frame. This field is applicable for only periodic (isochronous and interrupt) transactions.
$40000000 constant OTG_FS_OTG_HCCHAR15_CHDIS                        \ Channel disable The application sets this bit to stop transmitting/receiving data on a channel, even before the transfer for that channel is complete. The application must wait for the Channel disabled interrupt before treating the channel as disabled.
$80000000 constant OTG_FS_OTG_HCCHAR15_CHENA                        \ Channel enable This field is set by the application and cleared by the OTG host.


\
\ @brief OTG host channel 15 split control register
\ Address offset: 0x6E4
\ Reset value: 0x00000000
\

$0000007f constant OTG_FS_OTG_HCSPLT15_PRTADDR                      \ Port address This field is the port number of the recipient transaction translator.
$00003f80 constant OTG_FS_OTG_HCSPLT15_HUBADDR                      \ Hub address This field holds the device address of the transaction translators hub.
$0000c000 constant OTG_FS_OTG_HCSPLT15_XACTPOS                      \ Transaction position This field is used to determine whether to send all, first, middle, or last payloads with each OUT transaction.
$00010000 constant OTG_FS_OTG_HCSPLT15_COMPLSPLT                    \ Do complete split The application sets this bit to request the OTG host to perform a complete split transaction.
$80000000 constant OTG_FS_OTG_HCSPLT15_SPLITEN                      \ Split enable The application sets this bit to indicate that this channel is enabled to perform split transactions.


\
\ @brief OTG host channel 15 interrupt register
\ Address offset: 0x6E8
\ Reset value: 0x00000000
\

$00000001 constant OTG_FS_OTG_HCINT15_XFRC                          \ Transfer completed. Transfer completed normally without any errors.
$00000002 constant OTG_FS_OTG_HCINT15_CHH                           \ Channel halted. Indicates the transfer completed abnormally either because of any USB transaction error or in response to disable request by the application.
$00000004 constant OTG_FS_OTG_HCINT15_AHBERR                        \ AHB error This error is generated only in Internal DMA mode when an AHB error occurs during an AHB read/write operation. The application can read the corresponding DMA channel address register to get the error address.
$00000008 constant OTG_FS_OTG_HCINT15_STALL                         \ STALL response received interrupt.
$00000010 constant OTG_FS_OTG_HCINT15_NAK                           \ NAK response received interrupt.
$00000020 constant OTG_FS_OTG_HCINT15_ACK                           \ ACK response received/transmitted interrupt.
$00000040 constant OTG_FS_OTG_HCINT15_NYET                          \ Not yet ready response received interrupt.
$00000080 constant OTG_FS_OTG_HCINT15_TXERR                         \ Transaction error. Indicates one of the following errors occurred on the USB. CRC check failure Timeout Bit stuff error False EOP
$00000100 constant OTG_FS_OTG_HCINT15_BBERR                         \ Babble error.
$00000200 constant OTG_FS_OTG_HCINT15_FRMOR                         \ Frame overrun.
$00000400 constant OTG_FS_OTG_HCINT15_DTERR                         \ Data toggle error.


\
\ @brief OTG host channel 15 interrupt mask register
\ Address offset: 0x6EC
\ Reset value: 0x00000000
\

$00000001 constant OTG_FS_OTG_HCINTMSK15_XFRCM                      \ Transfer completed mask
$00000002 constant OTG_FS_OTG_HCINTMSK15_CHHM                       \ Channel halted mask
$00000004 constant OTG_FS_OTG_HCINTMSK15_AHBERRM                    \ AHB error.
$00000008 constant OTG_FS_OTG_HCINTMSK15_STALLM                     \ STALL response received interrupt mask.
$00000010 constant OTG_FS_OTG_HCINTMSK15_NAKM                       \ NAK response received interrupt mask.
$00000020 constant OTG_FS_OTG_HCINTMSK15_ACKM                       \ ACK response received/transmitted interrupt mask.
$00000040 constant OTG_FS_OTG_HCINTMSK15_NYET                       \ response received interrupt mask.
$00000080 constant OTG_FS_OTG_HCINTMSK15_TXERRM                     \ Transaction error mask.
$00000100 constant OTG_FS_OTG_HCINTMSK15_BBERRM                     \ Babble error mask.
$00000200 constant OTG_FS_OTG_HCINTMSK15_FRMORM                     \ Frame overrun mask.
$00000400 constant OTG_FS_OTG_HCINTMSK15_DTERRM                     \ Data toggle error mask.


\
\ @brief OTG host channel 15 transfer size register
\ Address offset: 0x6F0
\ Reset value: 0x00000000
\

$0007ffff constant OTG_FS_OTG_HCTSIZ15_XFRSIZ                       \ Transfer size For an OUT, this field is the number of data bytes the host sends during the transfer. For an IN, this field is the buffer size that the application has reserved for the transfer. The application is expected to program this field as an integer multiple of the maximum packet size for IN transactions (periodic and non-periodic).
$1ff80000 constant OTG_FS_OTG_HCTSIZ15_PKTCNT                       \ Packet count This field is programmed by the application with the expected number of packets to be transmitted (OUT) or received (IN). The host decrements this count on every successful transmission or reception of an OUT/IN packet. Once this count reaches zero, the application is interrupted to indicate normal completion.
$60000000 constant OTG_FS_OTG_HCTSIZ15_DPID                         \ Data PID The application programs this field with the type of PID to use for the initial transaction. The host maintains this field for the rest of the transfer.
$80000000 constant OTG_FS_OTG_HCTSIZ15_DOPNG                        \ Do Ping This bit is used only for OUT transfers. Setting this field to 1 directs the host to do PING protocol. Note: Do not set this bit for IN transfers. If this bit is set for IN transfers, it disables the channel.


\
\ @brief OTG host channel 15 DMA address register
\ Address offset: 0x6F4
\ Reset value: 0x00000000
\

$00000000 constant OTG_FS_OTG_HCDMA15_DMAADDR                       \ DMA address This field holds the start address in the external memory from which the data for the endpoint must be fetched or to which it must be stored. This register is incremented on every AHB transaction.


\
\ @brief OTG device configuration register
\ Address offset: 0x800
\ Reset value: 0x02200000
\

$00000003 constant OTG_FS_OTG_DCFG_DSPD                             \ Device speed Indicates the speed at which the application requires the core to enumerate, or the maximum speed the application can support. However, the actual bus speed is determined only after the chirp sequence is completed, and is based on the speed of the USB host to which the core is connected.
$00000004 constant OTG_FS_OTG_DCFG_NZLSOHSK                         \ Non-zero-length status OUT handshake The application can use this field to select the handshake the core sends on receiving a nonzero-length data packet during the OUT transaction of a control transfers status stage.
$000007f0 constant OTG_FS_OTG_DCFG_DAD                              \ Device address The application must program this field after every SetAddress control command.
$00001800 constant OTG_FS_OTG_DCFG_PFIVL                            \ Periodic frame interval Indicates the time within a frame at which the application must be notified using the end of periodic frame interrupt. This can be used to determine if all the isochronous traffic for that frame is complete.
$00008000 constant OTG_FS_OTG_DCFG_ERRATIM                          \ Erratic error interrupt mask
$03000000 constant OTG_FS_OTG_DCFG_PERSCHIVL                        \ Periodic schedule interval This field specifies the amount of time the Internal DMA engine must allocate for fetching periodic IN endpoint data. Based on the number of periodic endpoints, this value must be specified as 25, 50 or 75% of the (micro) frame. When any periodic endpoints are active, the internal DMA engine allocates the specified amount of time in fetching periodic IN endpoint data When no periodic endpoint is active, then the internal DMA engine services nonperiodic endpoints, ignoring this field After the specified time within a (micro) frame, the DMA switches to fetching nonperiodic endpoints


\
\ @brief OTG device control register
\ Address offset: 0x804
\ Reset value: 0x00000002
\

$00000001 constant OTG_FS_OTG_DCTL_RWUSIG                           \ Remote wakeup signaling When the application sets this bit, the core initiates remote signaling to wake up the USB host. The application must set this bit to instruct the core to exit the suspend state. As specified in the USB 2.0 specification, the application must clear this bit 1 ms to 15 ms after setting it. If LPM is enabled and the core is in the L1 (sleep) state, when the application sets this bit, the core initiates L1 remote signaling to wake up the USB host. The application must set this bit to instruct the core to exit the sleep state. As specified in the LPM specification, the hardware automatically clears this bit 50 s (T<sub>L1DevDrvResume</sub>) after being set by the application. The application must not set this bit when bRemoteWake from the previous LPM transaction is zero (refer to REMWAKE bit in GLPMCFG register).
$00000002 constant OTG_FS_OTG_DCTL_SDIS                             \ Soft disconnect The application uses this bit to signal the USB OTG core to perform a soft disconnect. As long as this bit is set, the host does not see that the device is connected, and the device does not receive signals on the USB. The core stays in the disconnected state until the application clears this bit.
$00000004 constant OTG_FS_OTG_DCTL_GINSTS                           \ Global IN NAK status
$00000008 constant OTG_FS_OTG_DCTL_GONSTS                           \ Global OUT NAK status
$00000070 constant OTG_FS_OTG_DCTL_TCTL                             \ Test control Others: Reserved
$00000080 constant OTG_FS_OTG_DCTL_SGINAK                           \ Set global IN NAK Writing 1 to this field sets the Global non-periodic IN NAK.The application uses this bit to send a NAK handshake on all non-periodic IN endpoints. The application must set this bit only after making sure that the Global IN NAK effective bit in the core interrupt register (GINAKEFF bit in OTG_GINTSTS) is cleared.
$00000100 constant OTG_FS_OTG_DCTL_CGINAK                           \ Clear global IN NAK Writing 1 to this field clears the Global IN NAK.
$00000200 constant OTG_FS_OTG_DCTL_SGONAK                           \ Set global OUT NAK Writing 1 to this field sets the Global OUT NAK. The application uses this bit to send a NAK handshake on all OUT endpoints. The application must set the this bit only after making sure that the Global OUT NAK effective bit in the core interrupt register (GONAKEFF bit in OTG_GINTSTS) is cleared.
$00000400 constant OTG_FS_OTG_DCTL_CGONAK                           \ Clear global OUT NAK Writing 1 to this field clears the Global OUT NAK.
$00000800 constant OTG_FS_OTG_DCTL_POPRGDNE                         \ Power-on programming done The application uses this bit to indicate that register programming is completed after a wakeup from power down mode.
$00040000 constant OTG_FS_OTG_DCTL_DSBESLRJCT                       \ Deep sleep BESL reject Core rejects LPM request with BESL value greater than BESL threshold programmed. NYET response is sent for LPM tokens with BESL value greater than BESL threshold. By default, the deep sleep BESL reject feature is disabled.


\
\ @brief OTG device status register
\ Address offset: 0x808
\ Reset value: 0x00000010
\

$00000001 constant OTG_FS_OTG_DSTS_SUSPSTS                          \ Suspend status In device mode, this bit is set as long as a suspend condition is detected on the USB. The core enters the suspended state when there is no activity on the USB data lines for a period of 3 ms. The core comes out of the suspend: When there is an activity on the USB data lines When the application writes to the remote wakeup signaling bit in the OTG_DCTL register (RWUSIG bit in OTG_DCTL).
$00000006 constant OTG_FS_OTG_DSTS_ENUMSPD                          \ Enumerated speed Indicates the speed at which the OTG_HS controller has come up after speed detection through a chirp sequence. Others: reserved
$00000008 constant OTG_FS_OTG_DSTS_EERR                             \ Erratic error The core sets this bit to report any erratic errors. Due to erratic errors, the OTG_HS controller goes into suspended state and an interrupt is generated to the application with Early suspend bit of the OTG_GINTSTS register (ESUSP bit in OTG_GINTSTS). If the early suspend is asserted due to an erratic error, the application can only perform a soft disconnect recover.
$003fff00 constant OTG_FS_OTG_DSTS_FNSOF                            \ Frame number of the received SOF
$00c00000 constant OTG_FS_OTG_DSTS_DEVLNSTS                         \ Device line status Indicates the current logic level USB data lines. Bit [23]: Logic level of D+ Bit [22]: Logic level of D-


\
\ @brief OTG device IN endpoint common interrupt mask register
\ Address offset: 0x810
\ Reset value: 0x00000000
\

$00000001 constant OTG_FS_OTG_DIEPMSK_XFRCM                         \ Transfer completed interrupt mask
$00000002 constant OTG_FS_OTG_DIEPMSK_EPDM                          \ Endpoint disabled interrupt mask
$00000004 constant OTG_FS_OTG_DIEPMSK_AHBERRM                       \ AHB error mask
$00000008 constant OTG_FS_OTG_DIEPMSK_TOM                           \ Timeout condition mask (Non-isochronous endpoints)
$00000010 constant OTG_FS_OTG_DIEPMSK_ITTXFEMSK                     \ IN token received when Tx FIFO empty mask
$00000020 constant OTG_FS_OTG_DIEPMSK_INEPNMM                       \ IN token received with EP mismatch mask
$00000040 constant OTG_FS_OTG_DIEPMSK_INEPNEM                       \ IN endpoint NAK effective mask
$00000100 constant OTG_FS_OTG_DIEPMSK_TXFURM                        \ FIFO underrun mask
$00002000 constant OTG_FS_OTG_DIEPMSK_NAKM                          \ NAK interrupt mask


\
\ @brief OTG device OUT endpoint common interrupt mask register
\ Address offset: 0x814
\ Reset value: 0x00000000
\

$00000001 constant OTG_FS_OTG_DOEPMSK_XFRCM                         \ Transfer completed interrupt mask
$00000002 constant OTG_FS_OTG_DOEPMSK_EPDM                          \ Endpoint disabled interrupt mask
$00000004 constant OTG_FS_OTG_DOEPMSK_AHBERRM                       \ AHB error mask
$00000008 constant OTG_FS_OTG_DOEPMSK_STUPM                         \ STUPM: SETUP phase done mask. Applies to control endpoints only.
$00000010 constant OTG_FS_OTG_DOEPMSK_OTEPDM                        \ OUT token received when endpoint disabled mask. Applies to control OUT endpoints only.
$00000020 constant OTG_FS_OTG_DOEPMSK_STSPHSRXM                     \ Status phase received for control write mask
$00000040 constant OTG_FS_OTG_DOEPMSK_B2BSTUPM                      \ Back-to-back SETUP packets received mask Applies to control OUT endpoints only.
$00000100 constant OTG_FS_OTG_DOEPMSK_OUTPKTERRM                    \ Out packet error mask
$00001000 constant OTG_FS_OTG_DOEPMSK_BERRM                         \ Babble error interrupt mask
$00002000 constant OTG_FS_OTG_DOEPMSK_NAKMSK                        \ NAK interrupt mask
$00004000 constant OTG_FS_OTG_DOEPMSK_NYETMSK                       \ NYET interrupt mask


\
\ @brief OTG device all endpoints interrupt register
\ Address offset: 0x818
\ Reset value: 0x00000000
\

$0000ffff constant OTG_FS_OTG_DAINT_IEPINT                          \ IN endpoint interrupt bits One bit per IN endpoint: Bit 0 for IN endpoint 0, bit 3 for endpoint 3.
$ffff0000 constant OTG_FS_OTG_DAINT_OEPINT                          \ OUT endpoint interrupt bits One bit per OUT endpoint: Bit 16 for OUT endpoint 0, bit 19 for OUT endpoint 3.


\
\ @brief OTG all endpoints interrupt mask register
\ Address offset: 0x81C
\ Reset value: 0x00000000
\

$0000ffff constant OTG_FS_OTG_DAINTMSK_IEPM                         \ IN EP interrupt mask bits One bit per IN endpoint: Bit 0 for IN EP 0, bit 3 for IN EP 3
$ffff0000 constant OTG_FS_OTG_DAINTMSK_OEPM                         \ OUT EP interrupt mask bits One per OUT endpoint: Bit 16 for OUT EP 0, bit 19 for OUT EP 3


\
\ @brief OTG device threshold control register
\ Address offset: 0x830
\ Reset value: 0x00000000
\

$00000001 constant OTG_FS_OTG_DTHRCTL_NONISOTHREN                   \ Nonisochronous IN endpoints threshold enable When this bit is set, the core enables thresholding for nonisochronous IN endpoints.
$00000002 constant OTG_FS_OTG_DTHRCTL_ISOTHREN                      \ ISO IN endpoint threshold enable When this bit is set, the core enables thresholding for isochronous IN endpoints.
$000007fc constant OTG_FS_OTG_DTHRCTL_TXTHRLEN                      \ Transmit threshold length This field specifies the transmit thresholding size in 32-bit words. This field specifies the amount of data in bytes to be in the corresponding endpoint transmit FIFO, before the core can start transmitting on the USB. The threshold length has to be at least eight 32-bit words. This field controls both isochronous and nonisochronous IN endpoint thresholds. The recommended value for TXTHRLEN is to be the same as the programmed AHB burst length (HBSTLEN bit in OTG_GAHBCFG).
$00010000 constant OTG_FS_OTG_DTHRCTL_RXTHREN                       \ Receive threshold enable When this bit is set, the core enables thresholding in the receive direction.
$03fe0000 constant OTG_FS_OTG_DTHRCTL_RXTHRLEN                      \ Receive threshold length This field specifies the receive thresholding size in 32-bit words. This field also specifies the amount of data received on the USB before the core can start transmitting on the AHB. The threshold length has to be at least eight 32-bit words. The recommended value for RXTHRLEN is to be the same as the programmed AHB burst length (HBSTLEN bit in OTG_GAHBCFG).
$08000000 constant OTG_FS_OTG_DTHRCTL_ARPEN                         \ Arbiter parking enable This bit controls internal DMA arbiter parking for IN endpoints. When thresholding is enabled and this bit is set to one, then the arbiter parks on the IN endpoint for which there is a token received on the USB. This is done to avoid getting into underrun conditions. By default parking is enabled.


\
\ @brief OTG device IN endpoint FIFO empty interrupt mask register
\ Address offset: 0x834
\ Reset value: 0x00000000
\

$0000ffff constant OTG_FS_OTG_DIEPEMPMSK_INEPTXFEM                  \ IN EP Tx FIFO empty interrupt mask bits These bits act as mask bits for OTG_DIEPINTx. TXFE interrupt one bit per IN endpoint: Bit 0 for IN endpoint 0, bit 3 for IN endpoint 3


\
\ @brief OTG device IN endpoint 0 control register
\ Address offset: 0x900
\ Reset value: 0x00000000
\

$000007ff constant OTG_FS_OTG_DIEPCTL0_INT_BULK_MPSIZ               \ Maximum packet size The application must program this field with the maximum packet size for the current logical endpoint. This value is in bytes.
$00008000 constant OTG_FS_OTG_DIEPCTL0_INT_BULK_USBAEP              \ USB active endpoint Indicates whether this endpoint is active in the current configuration and interface. The core clears this bit for all endpoints (other than EP 0) after detecting a USB reset. After receiving the SetConfiguration and SetInterface commands, the application must program endpoint registers accordingly and set this bit.
$00010000 constant OTG_FS_OTG_DIEPCTL0_INT_BULK_DPID                \ Endpoint data PID Applies to interrupt/bulk IN endpoints only. Contains the PID of the packet to be received or transmitted on this endpoint. The application must program the PID of the first packet to be received or transmitted on this endpoint, after the endpoint is activated. The application uses the SD0PID and SD1PID register fields to program either DATA0 or DATA1 PID.
$00020000 constant OTG_FS_OTG_DIEPCTL0_INT_BULK_NAKSTS              \ NAK status It indicates the following: When either the application or the core sets this bit: For non-isochronous IN endpoints: The core stops transmitting any data on an IN endpoint, even if there are data available in the Tx FIFO. For isochronous IN endpoints: The core sends out a zero-length data packet, even if there are data available in the Tx FIFO. Irrespective of this bits setting, the core always responds to SETUP data packets with an ACK handshake.
$000c0000 constant OTG_FS_OTG_DIEPCTL0_INT_BULK_EPTYP               \ Endpoint type This is the transfer type supported by this logical endpoint.
$00200000 constant OTG_FS_OTG_DIEPCTL0_INT_BULK_STALL               \ STALL handshake Applies to non-control, non-isochronous IN endpoints only (access type is rw). The application sets this bit to stall all tokens from the USB host to this endpoint. If a NAK bit, Global IN NAK, or Global OUT NAK is set along with this bit, the STALL bit takes priority. Only the application can clear this bit, never the core.
$03c00000 constant OTG_FS_OTG_DIEPCTL0_INT_BULK_TXFNUM              \ Tx FIFO number These bits specify the FIFO number associated with this endpoint. Each active IN endpoint must be programmed to a separate FIFO number. This field is valid only for IN endpoints.
$04000000 constant OTG_FS_OTG_DIEPCTL0_INT_BULK_CNAK                \ Clear NAK A write to this bit clears the NAK bit for the endpoint.
$08000000 constant OTG_FS_OTG_DIEPCTL0_INT_BULK_SNAK                \ Set NAK A write to this bit sets the NAK bit for the endpoint. Using this bit, the application can control the transmission of NAK handshakes on an endpoint. The core can also set this bit for OUT endpoints on a transfer completed interrupt, or after a SETUP is received on the endpoint.
$10000000 constant OTG_FS_OTG_DIEPCTL0_INT_BULK_SD0PID              \ Set DATA0 PID Applies to interrupt/bulk IN endpoints only. Writing to this field sets the endpoint data PID (DPID) field in this register to DATA0.
$20000000 constant OTG_FS_OTG_DIEPCTL0_INT_BULK_SD1PID              \ Set DATA1 PID Writing to this field sets the endpoint data PID (DPID) field in this register to DATA1.
$40000000 constant OTG_FS_OTG_DIEPCTL0_INT_BULK_EPDIS               \ Endpoint disable The application sets this bit to stop transmitting/receiving data on an endpoint, even before the transfer for that endpoint is complete. The application must wait for the endpoint disabled interrupt before treating the endpoint as disabled. The core clears this bit before setting the endpoint disabled interrupt. The application must set this bit only if endpoint enable is already set for this endpoint.
$80000000 constant OTG_FS_OTG_DIEPCTL0_INT_BULK_EPENA               \ Endpoint enable The application sets this bit to start transmitting data on an endpoint. The core clears this bit before setting any of the following interrupts on this endpoint: SETUP phase done Endpoint disabled Transfer completed


\
\ @brief OTG device IN endpoint 0 control register
\ Address offset: 0x900
\ Reset value: 0x00000000
\

$000007ff constant OTG_FS_OTG_DIEPCTL0_ISO_MPSIZ                    \ Maximum packet size The application must program this field with the maximum packet size for the current logical endpoint. This value is in bytes.
$00008000 constant OTG_FS_OTG_DIEPCTL0_ISO_USBAEP                   \ USB active endpoint Indicates whether this endpoint is active in the current configuration and interface. The core clears this bit for all endpoints (other than EP 0) after detecting a USB reset. After receiving the SetConfiguration and SetInterface commands, the application must program endpoint registers accordingly and set this bit.
$00010000 constant OTG_FS_OTG_DIEPCTL0_ISO_EONUM                    \ Even/odd frame Applies to isochronous IN endpoints only. Indicates the frame number in which the core transmits/receives isochronous data for this endpoint. The application must program the even/odd frame number in which it intends to transmit/receive isochronous data for this endpoint using the SEVNFRM and SODDFRM fields in this register.
$00020000 constant OTG_FS_OTG_DIEPCTL0_ISO_NAKSTS                   \ NAK status It indicates the following: When either the application or the core sets this bit: For non-isochronous IN endpoints: The core stops transmitting any data on an IN endpoint, even if there are data available in the Tx FIFO. For isochronous IN endpoints: The core sends out a zero-length data packet, even if there are data available in the Tx FIFO. Irrespective of this bits setting, the core always responds to SETUP data packets with an ACK handshake.
$000c0000 constant OTG_FS_OTG_DIEPCTL0_ISO_EPTYP                    \ Endpoint type This is the transfer type supported by this logical endpoint.
$00200000 constant OTG_FS_OTG_DIEPCTL0_ISO_STALL                    \ STALL handshake Applies to non-control, non-isochronous IN endpoints only (access type is rw). The application sets this bit to stall all tokens from the USB host to this endpoint. If a NAK bit, Global IN NAK, or Global OUT NAK is set along with this bit, the STALL bit takes priority. Only the application can clear this bit, never the core.
$03c00000 constant OTG_FS_OTG_DIEPCTL0_ISO_TXFNUM                   \ Tx FIFO number These bits specify the FIFO number associated with this endpoint. Each active IN endpoint must be programmed to a separate FIFO number. This field is valid only for IN endpoints.
$04000000 constant OTG_FS_OTG_DIEPCTL0_ISO_CNAK                     \ Clear NAK A write to this bit clears the NAK bit for the endpoint.
$08000000 constant OTG_FS_OTG_DIEPCTL0_ISO_SNAK                     \ Set NAK A write to this bit sets the NAK bit for the endpoint. Using this bit, the application can control the transmission of NAK handshakes on an endpoint. The core can also set this bit for OUT endpoints on a transfer completed interrupt, or after a SETUP is received on the endpoint.
$10000000 constant OTG_FS_OTG_DIEPCTL0_ISO_SEVNFRM                  \ Set even frame Applies to isochronous IN endpoints only. Writing to this field sets the Even/Odd frame (EONUM) field to even frame.
$20000000 constant OTG_FS_OTG_DIEPCTL0_ISO_SODDFRM                  \ Set odd frame Applies to isochronous IN and OUT endpoints only. Writing to this field sets the Even/Odd frame (EONUM) field to odd frame.
$40000000 constant OTG_FS_OTG_DIEPCTL0_ISO_EPDIS                    \ Endpoint disable The application sets this bit to stop transmitting/receiving data on an endpoint, even before the transfer for that endpoint is complete. The application must wait for the endpoint disabled interrupt before treating the endpoint as disabled. The core clears this bit before setting the endpoint disabled interrupt. The application must set this bit only if endpoint enable is already set for this endpoint.
$80000000 constant OTG_FS_OTG_DIEPCTL0_ISO_EPENA                    \ Endpoint enable The application sets this bit to start transmitting data on an endpoint. The core clears this bit before setting any of the following interrupts on this endpoint: SETUP phase done Endpoint disabled Transfer completed


\
\ @brief OTG device IN endpoint 0 interrupt register
\ Address offset: 0x908
\ Reset value: 0x00000080
\

$00000001 constant OTG_FS_OTG_DIEPINT0_XFRC                         \ Transfer completed interrupt This field indicates that the programmed transfer is complete on the AHB as well as on the USB, for this endpoint.
$00000002 constant OTG_FS_OTG_DIEPINT0_EPDISD                       \ Endpoint disabled interrupt This bit indicates that the endpoint is disabled per the applications request.
$00000004 constant OTG_FS_OTG_DIEPINT0_AHBERR                       \ AHB error This is generated only in internal DMA mode when there is an AHB error during an AHB read/write. The application can read the corresponding endpoint DMA address register to get the error address.
$00000008 constant OTG_FS_OTG_DIEPINT0_TOC                          \ Timeout condition Indicates that the core has detected a timeout condition on the USB for the last IN token on this endpoint.
$00000010 constant OTG_FS_OTG_DIEPINT0_ITTXFE                       \ IN token received when Tx FIFO is empty Indicates that an IN token was received when the associated Tx FIFO (periodic/non-periodic) was empty. This interrupt is asserted on the endpoint for which the IN token was received.
$00000020 constant OTG_FS_OTG_DIEPINT0_INEPNM                       \ IN token received with EP mismatch Indicates that the data in the top of the non-periodic TxFIFO belongs to an endpoint other than the one for which the IN token was received. This interrupt is asserted on the endpoint for which the IN token was received.
$00000040 constant OTG_FS_OTG_DIEPINT0_INEPNE                       \ IN endpoint NAK effective This bit can be cleared when the application clears the IN endpoint NAK by writing to the CNAK bit in OTG_DIEPCTLx. This interrupt indicates that the core has sampled the NAK bit set (either by the application or by the core). The interrupt indicates that the IN endpoint NAK bit set by the application has taken effect in the core. This interrupt does not guarantee that a NAK handshake is sent on the USB. A STALL bit takes priority over a NAK bit.
$00000080 constant OTG_FS_OTG_DIEPINT0_TXFE                         \ Transmit FIFO empty This interrupt is asserted when the Tx FIFO for this endpoint is either half or completely empty. The half or completely empty status is determined by the Tx FIFO Empty Level bit in the OTG_GAHBCFG register (TXFELVL bit in OTG_GAHBCFG).
$00000100 constant OTG_FS_OTG_DIEPINT0_TXFIFOUDRN                   \ Transmit Fifo Underrun (TxfifoUndrn) The core generates this interrupt when it detects a transmit FIFO underrun condition for this endpoint. Dependency: This interrupt is valid only when Thresholding is enabled
$00000800 constant OTG_FS_OTG_DIEPINT0_PKTDRPSTS                    \ Packet dropped status This bit indicates to the application that an ISOC OUT packet has been dropped. This bit does not have an associated mask bit and does not generate an interrupt.
$00002000 constant OTG_FS_OTG_DIEPINT0_NAK                          \ NAK input The core generates this interrupt when a NAK is transmitted or received by the device. In case of isochronous IN endpoints the interrupt gets generated when a zero length packet is transmitted due to unavailability of data in the Tx FIFO.


\
\ @brief OTG device IN endpoint 0 transfer size register
\ Address offset: 0x910
\ Reset value: 0x00000000
\

$0000007f constant OTG_FS_OTG_DIEPTSIZ0_XFRSIZ                      \ Transfer size Indicates the transfer size in bytes for endpoint 0. The core interrupts the application only after it has exhausted the transfer size amount of data. The transfer size can be set to the maximum packet size of the endpoint, to be interrupted at the end of each packet. The core decrements this field every time a packet from the external memory is written to the Tx FIFO.
$00180000 constant OTG_FS_OTG_DIEPTSIZ0_PKTCNT                      \ Packet count Indicates the total number of USB packets that constitute the transfer size amount of data for endpoint 0. This field is decremented every time a packet (maximum size or short packet) is read from the Tx FIFO.


\
\ @brief OTG device IN endpoint 0 DMA address register
\ Address offset: 0x914
\ Reset value: 0x00000000
\

$00000000 constant OTG_FS_OTG_DIEPDMA0_DMAADDR                      \ DMA Address This field holds the start address in the external memory from which the data for the endpoint must be fetched. This register is incremented on every AHB transaction.


\
\ @brief OTG device IN endpoint transmit FIFO status register
\ Address offset: 0x918
\ Reset value: 0x00000200
\

$0000ffff constant OTG_FS_OTG_DTXFSTS0_INEPTFSAV                    \ IN endpoint Tx FIFO space available Indicates the amount of free space available in the endpoint Tx FIFO. Values are in terms of 32-bit words: 0xn: n words available Others: Reserved


\
\ @brief OTG device IN endpoint 1 control register
\ Address offset: 0x920
\ Reset value: 0x00000000
\

$000007ff constant OTG_FS_OTG_DIEPCTL1_INT_BULK_MPSIZ               \ Maximum packet size The application must program this field with the maximum packet size for the current logical endpoint. This value is in bytes.
$00008000 constant OTG_FS_OTG_DIEPCTL1_INT_BULK_USBAEP              \ USB active endpoint Indicates whether this endpoint is active in the current configuration and interface. The core clears this bit for all endpoints (other than EP 0) after detecting a USB reset. After receiving the SetConfiguration and SetInterface commands, the application must program endpoint registers accordingly and set this bit.
$00010000 constant OTG_FS_OTG_DIEPCTL1_INT_BULK_DPID                \ Endpoint data PID Applies to interrupt/bulk IN endpoints only. Contains the PID of the packet to be received or transmitted on this endpoint. The application must program the PID of the first packet to be received or transmitted on this endpoint, after the endpoint is activated. The application uses the SD0PID and SD1PID register fields to program either DATA0 or DATA1 PID.
$00020000 constant OTG_FS_OTG_DIEPCTL1_INT_BULK_NAKSTS              \ NAK status It indicates the following: When either the application or the core sets this bit: For non-isochronous IN endpoints: The core stops transmitting any data on an IN endpoint, even if there are data available in the Tx FIFO. For isochronous IN endpoints: The core sends out a zero-length data packet, even if there are data available in the Tx FIFO. Irrespective of this bits setting, the core always responds to SETUP data packets with an ACK handshake.
$000c0000 constant OTG_FS_OTG_DIEPCTL1_INT_BULK_EPTYP               \ Endpoint type This is the transfer type supported by this logical endpoint.
$00200000 constant OTG_FS_OTG_DIEPCTL1_INT_BULK_STALL               \ STALL handshake Applies to non-control, non-isochronous IN endpoints only (access type is rw). The application sets this bit to stall all tokens from the USB host to this endpoint. If a NAK bit, Global IN NAK, or Global OUT NAK is set along with this bit, the STALL bit takes priority. Only the application can clear this bit, never the core.
$03c00000 constant OTG_FS_OTG_DIEPCTL1_INT_BULK_TXFNUM              \ Tx FIFO number These bits specify the FIFO number associated with this endpoint. Each active IN endpoint must be programmed to a separate FIFO number. This field is valid only for IN endpoints.
$04000000 constant OTG_FS_OTG_DIEPCTL1_INT_BULK_CNAK                \ Clear NAK A write to this bit clears the NAK bit for the endpoint.
$08000000 constant OTG_FS_OTG_DIEPCTL1_INT_BULK_SNAK                \ Set NAK A write to this bit sets the NAK bit for the endpoint. Using this bit, the application can control the transmission of NAK handshakes on an endpoint. The core can also set this bit for OUT endpoints on a transfer completed interrupt, or after a SETUP is received on the endpoint.
$10000000 constant OTG_FS_OTG_DIEPCTL1_INT_BULK_SD0PID              \ Set DATA0 PID Applies to interrupt/bulk IN endpoints only. Writing to this field sets the endpoint data PID (DPID) field in this register to DATA0.
$20000000 constant OTG_FS_OTG_DIEPCTL1_INT_BULK_SD1PID              \ Set DATA1 PID Writing to this field sets the endpoint data PID (DPID) field in this register to DATA1.
$40000000 constant OTG_FS_OTG_DIEPCTL1_INT_BULK_EPDIS               \ Endpoint disable The application sets this bit to stop transmitting/receiving data on an endpoint, even before the transfer for that endpoint is complete. The application must wait for the endpoint disabled interrupt before treating the endpoint as disabled. The core clears this bit before setting the endpoint disabled interrupt. The application must set this bit only if endpoint enable is already set for this endpoint.
$80000000 constant OTG_FS_OTG_DIEPCTL1_INT_BULK_EPENA               \ Endpoint enable The application sets this bit to start transmitting data on an endpoint. The core clears this bit before setting any of the following interrupts on this endpoint: SETUP phase done Endpoint disabled Transfer completed


\
\ @brief OTG device IN endpoint 1 control register
\ Address offset: 0x920
\ Reset value: 0x00000000
\

$000007ff constant OTG_FS_OTG_DIEPCTL1_ISO_MPSIZ                    \ Maximum packet size The application must program this field with the maximum packet size for the current logical endpoint. This value is in bytes.
$00008000 constant OTG_FS_OTG_DIEPCTL1_ISO_USBAEP                   \ USB active endpoint Indicates whether this endpoint is active in the current configuration and interface. The core clears this bit for all endpoints (other than EP 0) after detecting a USB reset. After receiving the SetConfiguration and SetInterface commands, the application must program endpoint registers accordingly and set this bit.
$00010000 constant OTG_FS_OTG_DIEPCTL1_ISO_EONUM                    \ Even/odd frame Applies to isochronous IN endpoints only. Indicates the frame number in which the core transmits/receives isochronous data for this endpoint. The application must program the even/odd frame number in which it intends to transmit/receive isochronous data for this endpoint using the SEVNFRM and SODDFRM fields in this register.
$00020000 constant OTG_FS_OTG_DIEPCTL1_ISO_NAKSTS                   \ NAK status It indicates the following: When either the application or the core sets this bit: For non-isochronous IN endpoints: The core stops transmitting any data on an IN endpoint, even if there are data available in the Tx FIFO. For isochronous IN endpoints: The core sends out a zero-length data packet, even if there are data available in the Tx FIFO. Irrespective of this bits setting, the core always responds to SETUP data packets with an ACK handshake.
$000c0000 constant OTG_FS_OTG_DIEPCTL1_ISO_EPTYP                    \ Endpoint type This is the transfer type supported by this logical endpoint.
$00200000 constant OTG_FS_OTG_DIEPCTL1_ISO_STALL                    \ STALL handshake Applies to non-control, non-isochronous IN endpoints only (access type is rw). The application sets this bit to stall all tokens from the USB host to this endpoint. If a NAK bit, Global IN NAK, or Global OUT NAK is set along with this bit, the STALL bit takes priority. Only the application can clear this bit, never the core.
$03c00000 constant OTG_FS_OTG_DIEPCTL1_ISO_TXFNUM                   \ Tx FIFO number These bits specify the FIFO number associated with this endpoint. Each active IN endpoint must be programmed to a separate FIFO number. This field is valid only for IN endpoints.
$04000000 constant OTG_FS_OTG_DIEPCTL1_ISO_CNAK                     \ Clear NAK A write to this bit clears the NAK bit for the endpoint.
$08000000 constant OTG_FS_OTG_DIEPCTL1_ISO_SNAK                     \ Set NAK A write to this bit sets the NAK bit for the endpoint. Using this bit, the application can control the transmission of NAK handshakes on an endpoint. The core can also set this bit for OUT endpoints on a transfer completed interrupt, or after a SETUP is received on the endpoint.
$10000000 constant OTG_FS_OTG_DIEPCTL1_ISO_SEVNFRM                  \ Set even frame Applies to isochronous IN endpoints only. Writing to this field sets the Even/Odd frame (EONUM) field to even frame.
$20000000 constant OTG_FS_OTG_DIEPCTL1_ISO_SODDFRM                  \ Set odd frame Applies to isochronous IN and OUT endpoints only. Writing to this field sets the Even/Odd frame (EONUM) field to odd frame.
$40000000 constant OTG_FS_OTG_DIEPCTL1_ISO_EPDIS                    \ Endpoint disable The application sets this bit to stop transmitting/receiving data on an endpoint, even before the transfer for that endpoint is complete. The application must wait for the endpoint disabled interrupt before treating the endpoint as disabled. The core clears this bit before setting the endpoint disabled interrupt. The application must set this bit only if endpoint enable is already set for this endpoint.
$80000000 constant OTG_FS_OTG_DIEPCTL1_ISO_EPENA                    \ Endpoint enable The application sets this bit to start transmitting data on an endpoint. The core clears this bit before setting any of the following interrupts on this endpoint: SETUP phase done Endpoint disabled Transfer completed


\
\ @brief OTG device IN endpoint 1 interrupt register
\ Address offset: 0x928
\ Reset value: 0x00000080
\

$00000001 constant OTG_FS_OTG_DIEPINT1_XFRC                         \ Transfer completed interrupt This field indicates that the programmed transfer is complete on the AHB as well as on the USB, for this endpoint.
$00000002 constant OTG_FS_OTG_DIEPINT1_EPDISD                       \ Endpoint disabled interrupt This bit indicates that the endpoint is disabled per the applications request.
$00000004 constant OTG_FS_OTG_DIEPINT1_AHBERR                       \ AHB error This is generated only in internal DMA mode when there is an AHB error during an AHB read/write. The application can read the corresponding endpoint DMA address register to get the error address.
$00000008 constant OTG_FS_OTG_DIEPINT1_TOC                          \ Timeout condition Indicates that the core has detected a timeout condition on the USB for the last IN token on this endpoint.
$00000010 constant OTG_FS_OTG_DIEPINT1_ITTXFE                       \ IN token received when Tx FIFO is empty Indicates that an IN token was received when the associated Tx FIFO (periodic/non-periodic) was empty. This interrupt is asserted on the endpoint for which the IN token was received.
$00000020 constant OTG_FS_OTG_DIEPINT1_INEPNM                       \ IN token received with EP mismatch Indicates that the data in the top of the non-periodic TxFIFO belongs to an endpoint other than the one for which the IN token was received. This interrupt is asserted on the endpoint for which the IN token was received.
$00000040 constant OTG_FS_OTG_DIEPINT1_INEPNE                       \ IN endpoint NAK effective This bit can be cleared when the application clears the IN endpoint NAK by writing to the CNAK bit in OTG_DIEPCTLx. This interrupt indicates that the core has sampled the NAK bit set (either by the application or by the core). The interrupt indicates that the IN endpoint NAK bit set by the application has taken effect in the core. This interrupt does not guarantee that a NAK handshake is sent on the USB. A STALL bit takes priority over a NAK bit.
$00000080 constant OTG_FS_OTG_DIEPINT1_TXFE                         \ Transmit FIFO empty This interrupt is asserted when the Tx FIFO for this endpoint is either half or completely empty. The half or completely empty status is determined by the Tx FIFO Empty Level bit in the OTG_GAHBCFG register (TXFELVL bit in OTG_GAHBCFG).
$00000100 constant OTG_FS_OTG_DIEPINT1_TXFIFOUDRN                   \ Transmit Fifo Underrun (TxfifoUndrn) The core generates this interrupt when it detects a transmit FIFO underrun condition for this endpoint. Dependency: This interrupt is valid only when Thresholding is enabled
$00000800 constant OTG_FS_OTG_DIEPINT1_PKTDRPSTS                    \ Packet dropped status This bit indicates to the application that an ISOC OUT packet has been dropped. This bit does not have an associated mask bit and does not generate an interrupt.
$00002000 constant OTG_FS_OTG_DIEPINT1_NAK                          \ NAK input The core generates this interrupt when a NAK is transmitted or received by the device. In case of isochronous IN endpoints the interrupt gets generated when a zero length packet is transmitted due to unavailability of data in the Tx FIFO.


\
\ @brief OTG device IN endpoint 1 transfer size register
\ Address offset: 0x930
\ Reset value: 0x00000000
\

$0007ffff constant OTG_FS_OTG_DIEPTSIZ1_XFRSIZ                      \ Transfer size This field contains the transfer size in bytes for the current endpoint. The core only interrupts the application after it has exhausted the transfer size amount of data. The transfer size can be set to the maximum packet size of the endpoint, to be interrupted at the end of each packet. The core decrements this field every time a packet from the external memory is written to the Tx FIFO.
$1ff80000 constant OTG_FS_OTG_DIEPTSIZ1_PKTCNT                      \ Packet count Indicates the total number of USB packets that constitute the transfer size amount of data for this endpoint. This field is decremented every time a packet (maximum size or short packet) is read from the Tx FIFO.
$60000000 constant OTG_FS_OTG_DIEPTSIZ1_MCNT                        \ Multi count For periodic IN endpoints, this field indicates the number of packets that must be transmitted per frame on the USB. The core uses this field to calculate the data PID for isochronous IN endpoints.


\
\ @brief OTG device IN endpoint 1 DMA address register
\ Address offset: 0x934
\ Reset value: 0x00000000
\

$00000000 constant OTG_FS_OTG_DIEPDMA1_DMAADDR                      \ DMA Address This field holds the start address in the external memory from which the data for the endpoint must be fetched. This register is incremented on every AHB transaction.


\
\ @brief OTG device IN endpoint transmit FIFO status register
\ Address offset: 0x938
\ Reset value: 0x00000200
\

$0000ffff constant OTG_FS_OTG_DTXFSTS1_INEPTFSAV                    \ IN endpoint Tx FIFO space available Indicates the amount of free space available in the endpoint Tx FIFO. Values are in terms of 32-bit words: 0xn: n words available Others: Reserved


\
\ @brief OTG device IN endpoint 2 control register
\ Address offset: 0x940
\ Reset value: 0x00000000
\

$000007ff constant OTG_FS_OTG_DIEPCTL2_INT_BULK_MPSIZ               \ Maximum packet size The application must program this field with the maximum packet size for the current logical endpoint. This value is in bytes.
$00008000 constant OTG_FS_OTG_DIEPCTL2_INT_BULK_USBAEP              \ USB active endpoint Indicates whether this endpoint is active in the current configuration and interface. The core clears this bit for all endpoints (other than EP 0) after detecting a USB reset. After receiving the SetConfiguration and SetInterface commands, the application must program endpoint registers accordingly and set this bit.
$00010000 constant OTG_FS_OTG_DIEPCTL2_INT_BULK_DPID                \ Endpoint data PID Applies to interrupt/bulk IN endpoints only. Contains the PID of the packet to be received or transmitted on this endpoint. The application must program the PID of the first packet to be received or transmitted on this endpoint, after the endpoint is activated. The application uses the SD0PID and SD1PID register fields to program either DATA0 or DATA1 PID.
$00020000 constant OTG_FS_OTG_DIEPCTL2_INT_BULK_NAKSTS              \ NAK status It indicates the following: When either the application or the core sets this bit: For non-isochronous IN endpoints: The core stops transmitting any data on an IN endpoint, even if there are data available in the Tx FIFO. For isochronous IN endpoints: The core sends out a zero-length data packet, even if there are data available in the Tx FIFO. Irrespective of this bits setting, the core always responds to SETUP data packets with an ACK handshake.
$000c0000 constant OTG_FS_OTG_DIEPCTL2_INT_BULK_EPTYP               \ Endpoint type This is the transfer type supported by this logical endpoint.
$00200000 constant OTG_FS_OTG_DIEPCTL2_INT_BULK_STALL               \ STALL handshake Applies to non-control, non-isochronous IN endpoints only (access type is rw). The application sets this bit to stall all tokens from the USB host to this endpoint. If a NAK bit, Global IN NAK, or Global OUT NAK is set along with this bit, the STALL bit takes priority. Only the application can clear this bit, never the core.
$03c00000 constant OTG_FS_OTG_DIEPCTL2_INT_BULK_TXFNUM              \ Tx FIFO number These bits specify the FIFO number associated with this endpoint. Each active IN endpoint must be programmed to a separate FIFO number. This field is valid only for IN endpoints.
$04000000 constant OTG_FS_OTG_DIEPCTL2_INT_BULK_CNAK                \ Clear NAK A write to this bit clears the NAK bit for the endpoint.
$08000000 constant OTG_FS_OTG_DIEPCTL2_INT_BULK_SNAK                \ Set NAK A write to this bit sets the NAK bit for the endpoint. Using this bit, the application can control the transmission of NAK handshakes on an endpoint. The core can also set this bit for OUT endpoints on a transfer completed interrupt, or after a SETUP is received on the endpoint.
$10000000 constant OTG_FS_OTG_DIEPCTL2_INT_BULK_SD0PID              \ Set DATA0 PID Applies to interrupt/bulk IN endpoints only. Writing to this field sets the endpoint data PID (DPID) field in this register to DATA0.
$20000000 constant OTG_FS_OTG_DIEPCTL2_INT_BULK_SD1PID              \ Set DATA1 PID Writing to this field sets the endpoint data PID (DPID) field in this register to DATA1.
$40000000 constant OTG_FS_OTG_DIEPCTL2_INT_BULK_EPDIS               \ Endpoint disable The application sets this bit to stop transmitting/receiving data on an endpoint, even before the transfer for that endpoint is complete. The application must wait for the endpoint disabled interrupt before treating the endpoint as disabled. The core clears this bit before setting the endpoint disabled interrupt. The application must set this bit only if endpoint enable is already set for this endpoint.
$80000000 constant OTG_FS_OTG_DIEPCTL2_INT_BULK_EPENA               \ Endpoint enable The application sets this bit to start transmitting data on an endpoint. The core clears this bit before setting any of the following interrupts on this endpoint: SETUP phase done Endpoint disabled Transfer completed


\
\ @brief OTG device IN endpoint 2 control register
\ Address offset: 0x940
\ Reset value: 0x00000000
\

$000007ff constant OTG_FS_OTG_DIEPCTL2_ISO_MPSIZ                    \ Maximum packet size The application must program this field with the maximum packet size for the current logical endpoint. This value is in bytes.
$00008000 constant OTG_FS_OTG_DIEPCTL2_ISO_USBAEP                   \ USB active endpoint Indicates whether this endpoint is active in the current configuration and interface. The core clears this bit for all endpoints (other than EP 0) after detecting a USB reset. After receiving the SetConfiguration and SetInterface commands, the application must program endpoint registers accordingly and set this bit.
$00010000 constant OTG_FS_OTG_DIEPCTL2_ISO_EONUM                    \ Even/odd frame Applies to isochronous IN endpoints only. Indicates the frame number in which the core transmits/receives isochronous data for this endpoint. The application must program the even/odd frame number in which it intends to transmit/receive isochronous data for this endpoint using the SEVNFRM and SODDFRM fields in this register.
$00020000 constant OTG_FS_OTG_DIEPCTL2_ISO_NAKSTS                   \ NAK status It indicates the following: When either the application or the core sets this bit: For non-isochronous IN endpoints: The core stops transmitting any data on an IN endpoint, even if there are data available in the Tx FIFO. For isochronous IN endpoints: The core sends out a zero-length data packet, even if there are data available in the Tx FIFO. Irrespective of this bits setting, the core always responds to SETUP data packets with an ACK handshake.
$000c0000 constant OTG_FS_OTG_DIEPCTL2_ISO_EPTYP                    \ Endpoint type This is the transfer type supported by this logical endpoint.
$00200000 constant OTG_FS_OTG_DIEPCTL2_ISO_STALL                    \ STALL handshake Applies to non-control, non-isochronous IN endpoints only (access type is rw). The application sets this bit to stall all tokens from the USB host to this endpoint. If a NAK bit, Global IN NAK, or Global OUT NAK is set along with this bit, the STALL bit takes priority. Only the application can clear this bit, never the core.
$03c00000 constant OTG_FS_OTG_DIEPCTL2_ISO_TXFNUM                   \ Tx FIFO number These bits specify the FIFO number associated with this endpoint. Each active IN endpoint must be programmed to a separate FIFO number. This field is valid only for IN endpoints.
$04000000 constant OTG_FS_OTG_DIEPCTL2_ISO_CNAK                     \ Clear NAK A write to this bit clears the NAK bit for the endpoint.
$08000000 constant OTG_FS_OTG_DIEPCTL2_ISO_SNAK                     \ Set NAK A write to this bit sets the NAK bit for the endpoint. Using this bit, the application can control the transmission of NAK handshakes on an endpoint. The core can also set this bit for OUT endpoints on a transfer completed interrupt, or after a SETUP is received on the endpoint.
$10000000 constant OTG_FS_OTG_DIEPCTL2_ISO_SEVNFRM                  \ Set even frame Applies to isochronous IN endpoints only. Writing to this field sets the Even/Odd frame (EONUM) field to even frame.
$20000000 constant OTG_FS_OTG_DIEPCTL2_ISO_SODDFRM                  \ Set odd frame Applies to isochronous IN and OUT endpoints only. Writing to this field sets the Even/Odd frame (EONUM) field to odd frame.
$40000000 constant OTG_FS_OTG_DIEPCTL2_ISO_EPDIS                    \ Endpoint disable The application sets this bit to stop transmitting/receiving data on an endpoint, even before the transfer for that endpoint is complete. The application must wait for the endpoint disabled interrupt before treating the endpoint as disabled. The core clears this bit before setting the endpoint disabled interrupt. The application must set this bit only if endpoint enable is already set for this endpoint.
$80000000 constant OTG_FS_OTG_DIEPCTL2_ISO_EPENA                    \ Endpoint enable The application sets this bit to start transmitting data on an endpoint. The core clears this bit before setting any of the following interrupts on this endpoint: SETUP phase done Endpoint disabled Transfer completed


\
\ @brief OTG device IN endpoint 2 interrupt register
\ Address offset: 0x948
\ Reset value: 0x00000080
\

$00000001 constant OTG_FS_OTG_DIEPINT2_XFRC                         \ Transfer completed interrupt This field indicates that the programmed transfer is complete on the AHB as well as on the USB, for this endpoint.
$00000002 constant OTG_FS_OTG_DIEPINT2_EPDISD                       \ Endpoint disabled interrupt This bit indicates that the endpoint is disabled per the applications request.
$00000004 constant OTG_FS_OTG_DIEPINT2_AHBERR                       \ AHB error This is generated only in internal DMA mode when there is an AHB error during an AHB read/write. The application can read the corresponding endpoint DMA address register to get the error address.
$00000008 constant OTG_FS_OTG_DIEPINT2_TOC                          \ Timeout condition Indicates that the core has detected a timeout condition on the USB for the last IN token on this endpoint.
$00000010 constant OTG_FS_OTG_DIEPINT2_ITTXFE                       \ IN token received when Tx FIFO is empty Indicates that an IN token was received when the associated Tx FIFO (periodic/non-periodic) was empty. This interrupt is asserted on the endpoint for which the IN token was received.
$00000020 constant OTG_FS_OTG_DIEPINT2_INEPNM                       \ IN token received with EP mismatch Indicates that the data in the top of the non-periodic TxFIFO belongs to an endpoint other than the one for which the IN token was received. This interrupt is asserted on the endpoint for which the IN token was received.
$00000040 constant OTG_FS_OTG_DIEPINT2_INEPNE                       \ IN endpoint NAK effective This bit can be cleared when the application clears the IN endpoint NAK by writing to the CNAK bit in OTG_DIEPCTLx. This interrupt indicates that the core has sampled the NAK bit set (either by the application or by the core). The interrupt indicates that the IN endpoint NAK bit set by the application has taken effect in the core. This interrupt does not guarantee that a NAK handshake is sent on the USB. A STALL bit takes priority over a NAK bit.
$00000080 constant OTG_FS_OTG_DIEPINT2_TXFE                         \ Transmit FIFO empty This interrupt is asserted when the Tx FIFO for this endpoint is either half or completely empty. The half or completely empty status is determined by the Tx FIFO Empty Level bit in the OTG_GAHBCFG register (TXFELVL bit in OTG_GAHBCFG).
$00000100 constant OTG_FS_OTG_DIEPINT2_TXFIFOUDRN                   \ Transmit Fifo Underrun (TxfifoUndrn) The core generates this interrupt when it detects a transmit FIFO underrun condition for this endpoint. Dependency: This interrupt is valid only when Thresholding is enabled
$00000800 constant OTG_FS_OTG_DIEPINT2_PKTDRPSTS                    \ Packet dropped status This bit indicates to the application that an ISOC OUT packet has been dropped. This bit does not have an associated mask bit and does not generate an interrupt.
$00002000 constant OTG_FS_OTG_DIEPINT2_NAK                          \ NAK input The core generates this interrupt when a NAK is transmitted or received by the device. In case of isochronous IN endpoints the interrupt gets generated when a zero length packet is transmitted due to unavailability of data in the Tx FIFO.


\
\ @brief OTG device IN endpoint 2 transfer size register
\ Address offset: 0x950
\ Reset value: 0x00000000
\

$0007ffff constant OTG_FS_OTG_DIEPTSIZ2_XFRSIZ                      \ Transfer size This field contains the transfer size in bytes for the current endpoint. The core only interrupts the application after it has exhausted the transfer size amount of data. The transfer size can be set to the maximum packet size of the endpoint, to be interrupted at the end of each packet. The core decrements this field every time a packet from the external memory is written to the Tx FIFO.
$1ff80000 constant OTG_FS_OTG_DIEPTSIZ2_PKTCNT                      \ Packet count Indicates the total number of USB packets that constitute the transfer size amount of data for this endpoint. This field is decremented every time a packet (maximum size or short packet) is read from the Tx FIFO.
$60000000 constant OTG_FS_OTG_DIEPTSIZ2_MCNT                        \ Multi count For periodic IN endpoints, this field indicates the number of packets that must be transmitted per frame on the USB. The core uses this field to calculate the data PID for isochronous IN endpoints.


\
\ @brief OTG device IN endpoint 2 DMA address register
\ Address offset: 0x954
\ Reset value: 0x00000000
\

$00000000 constant OTG_FS_OTG_DIEPDMA2_DMAADDR                      \ DMA Address This field holds the start address in the external memory from which the data for the endpoint must be fetched. This register is incremented on every AHB transaction.


\
\ @brief OTG device IN endpoint transmit FIFO status register
\ Address offset: 0x958
\ Reset value: 0x00000200
\

$0000ffff constant OTG_FS_OTG_DTXFSTS2_INEPTFSAV                    \ IN endpoint Tx FIFO space available Indicates the amount of free space available in the endpoint Tx FIFO. Values are in terms of 32-bit words: 0xn: n words available Others: Reserved


\
\ @brief OTG device IN endpoint 3 control register
\ Address offset: 0x960
\ Reset value: 0x00000000
\

$000007ff constant OTG_FS_OTG_DIEPCTL3_INT_BULK_MPSIZ               \ Maximum packet size The application must program this field with the maximum packet size for the current logical endpoint. This value is in bytes.
$00008000 constant OTG_FS_OTG_DIEPCTL3_INT_BULK_USBAEP              \ USB active endpoint Indicates whether this endpoint is active in the current configuration and interface. The core clears this bit for all endpoints (other than EP 0) after detecting a USB reset. After receiving the SetConfiguration and SetInterface commands, the application must program endpoint registers accordingly and set this bit.
$00010000 constant OTG_FS_OTG_DIEPCTL3_INT_BULK_DPID                \ Endpoint data PID Applies to interrupt/bulk IN endpoints only. Contains the PID of the packet to be received or transmitted on this endpoint. The application must program the PID of the first packet to be received or transmitted on this endpoint, after the endpoint is activated. The application uses the SD0PID and SD1PID register fields to program either DATA0 or DATA1 PID.
$00020000 constant OTG_FS_OTG_DIEPCTL3_INT_BULK_NAKSTS              \ NAK status It indicates the following: When either the application or the core sets this bit: For non-isochronous IN endpoints: The core stops transmitting any data on an IN endpoint, even if there are data available in the Tx FIFO. For isochronous IN endpoints: The core sends out a zero-length data packet, even if there are data available in the Tx FIFO. Irrespective of this bits setting, the core always responds to SETUP data packets with an ACK handshake.
$000c0000 constant OTG_FS_OTG_DIEPCTL3_INT_BULK_EPTYP               \ Endpoint type This is the transfer type supported by this logical endpoint.
$00200000 constant OTG_FS_OTG_DIEPCTL3_INT_BULK_STALL               \ STALL handshake Applies to non-control, non-isochronous IN endpoints only (access type is rw). The application sets this bit to stall all tokens from the USB host to this endpoint. If a NAK bit, Global IN NAK, or Global OUT NAK is set along with this bit, the STALL bit takes priority. Only the application can clear this bit, never the core.
$03c00000 constant OTG_FS_OTG_DIEPCTL3_INT_BULK_TXFNUM              \ Tx FIFO number These bits specify the FIFO number associated with this endpoint. Each active IN endpoint must be programmed to a separate FIFO number. This field is valid only for IN endpoints.
$04000000 constant OTG_FS_OTG_DIEPCTL3_INT_BULK_CNAK                \ Clear NAK A write to this bit clears the NAK bit for the endpoint.
$08000000 constant OTG_FS_OTG_DIEPCTL3_INT_BULK_SNAK                \ Set NAK A write to this bit sets the NAK bit for the endpoint. Using this bit, the application can control the transmission of NAK handshakes on an endpoint. The core can also set this bit for OUT endpoints on a transfer completed interrupt, or after a SETUP is received on the endpoint.
$10000000 constant OTG_FS_OTG_DIEPCTL3_INT_BULK_SD0PID              \ Set DATA0 PID Applies to interrupt/bulk IN endpoints only. Writing to this field sets the endpoint data PID (DPID) field in this register to DATA0.
$20000000 constant OTG_FS_OTG_DIEPCTL3_INT_BULK_SD1PID              \ Set DATA1 PID Writing to this field sets the endpoint data PID (DPID) field in this register to DATA1.
$40000000 constant OTG_FS_OTG_DIEPCTL3_INT_BULK_EPDIS               \ Endpoint disable The application sets this bit to stop transmitting/receiving data on an endpoint, even before the transfer for that endpoint is complete. The application must wait for the endpoint disabled interrupt before treating the endpoint as disabled. The core clears this bit before setting the endpoint disabled interrupt. The application must set this bit only if endpoint enable is already set for this endpoint.
$80000000 constant OTG_FS_OTG_DIEPCTL3_INT_BULK_EPENA               \ Endpoint enable The application sets this bit to start transmitting data on an endpoint. The core clears this bit before setting any of the following interrupts on this endpoint: SETUP phase done Endpoint disabled Transfer completed


\
\ @brief OTG device IN endpoint 3 control register
\ Address offset: 0x960
\ Reset value: 0x00000000
\

$000007ff constant OTG_FS_OTG_DIEPCTL3_ISO_MPSIZ                    \ Maximum packet size The application must program this field with the maximum packet size for the current logical endpoint. This value is in bytes.
$00008000 constant OTG_FS_OTG_DIEPCTL3_ISO_USBAEP                   \ USB active endpoint Indicates whether this endpoint is active in the current configuration and interface. The core clears this bit for all endpoints (other than EP 0) after detecting a USB reset. After receiving the SetConfiguration and SetInterface commands, the application must program endpoint registers accordingly and set this bit.
$00010000 constant OTG_FS_OTG_DIEPCTL3_ISO_EONUM                    \ Even/odd frame Applies to isochronous IN endpoints only. Indicates the frame number in which the core transmits/receives isochronous data for this endpoint. The application must program the even/odd frame number in which it intends to transmit/receive isochronous data for this endpoint using the SEVNFRM and SODDFRM fields in this register.
$00020000 constant OTG_FS_OTG_DIEPCTL3_ISO_NAKSTS                   \ NAK status It indicates the following: When either the application or the core sets this bit: For non-isochronous IN endpoints: The core stops transmitting any data on an IN endpoint, even if there are data available in the Tx FIFO. For isochronous IN endpoints: The core sends out a zero-length data packet, even if there are data available in the Tx FIFO. Irrespective of this bits setting, the core always responds to SETUP data packets with an ACK handshake.
$000c0000 constant OTG_FS_OTG_DIEPCTL3_ISO_EPTYP                    \ Endpoint type This is the transfer type supported by this logical endpoint.
$00200000 constant OTG_FS_OTG_DIEPCTL3_ISO_STALL                    \ STALL handshake Applies to non-control, non-isochronous IN endpoints only (access type is rw). The application sets this bit to stall all tokens from the USB host to this endpoint. If a NAK bit, Global IN NAK, or Global OUT NAK is set along with this bit, the STALL bit takes priority. Only the application can clear this bit, never the core.
$03c00000 constant OTG_FS_OTG_DIEPCTL3_ISO_TXFNUM                   \ Tx FIFO number These bits specify the FIFO number associated with this endpoint. Each active IN endpoint must be programmed to a separate FIFO number. This field is valid only for IN endpoints.
$04000000 constant OTG_FS_OTG_DIEPCTL3_ISO_CNAK                     \ Clear NAK A write to this bit clears the NAK bit for the endpoint.
$08000000 constant OTG_FS_OTG_DIEPCTL3_ISO_SNAK                     \ Set NAK A write to this bit sets the NAK bit for the endpoint. Using this bit, the application can control the transmission of NAK handshakes on an endpoint. The core can also set this bit for OUT endpoints on a transfer completed interrupt, or after a SETUP is received on the endpoint.
$10000000 constant OTG_FS_OTG_DIEPCTL3_ISO_SEVNFRM                  \ Set even frame Applies to isochronous IN endpoints only. Writing to this field sets the Even/Odd frame (EONUM) field to even frame.
$20000000 constant OTG_FS_OTG_DIEPCTL3_ISO_SODDFRM                  \ Set odd frame Applies to isochronous IN and OUT endpoints only. Writing to this field sets the Even/Odd frame (EONUM) field to odd frame.
$40000000 constant OTG_FS_OTG_DIEPCTL3_ISO_EPDIS                    \ Endpoint disable The application sets this bit to stop transmitting/receiving data on an endpoint, even before the transfer for that endpoint is complete. The application must wait for the endpoint disabled interrupt before treating the endpoint as disabled. The core clears this bit before setting the endpoint disabled interrupt. The application must set this bit only if endpoint enable is already set for this endpoint.
$80000000 constant OTG_FS_OTG_DIEPCTL3_ISO_EPENA                    \ Endpoint enable The application sets this bit to start transmitting data on an endpoint. The core clears this bit before setting any of the following interrupts on this endpoint: SETUP phase done Endpoint disabled Transfer completed


\
\ @brief OTG device IN endpoint 3 interrupt register
\ Address offset: 0x968
\ Reset value: 0x00000080
\

$00000001 constant OTG_FS_OTG_DIEPINT3_XFRC                         \ Transfer completed interrupt This field indicates that the programmed transfer is complete on the AHB as well as on the USB, for this endpoint.
$00000002 constant OTG_FS_OTG_DIEPINT3_EPDISD                       \ Endpoint disabled interrupt This bit indicates that the endpoint is disabled per the applications request.
$00000004 constant OTG_FS_OTG_DIEPINT3_AHBERR                       \ AHB error This is generated only in internal DMA mode when there is an AHB error during an AHB read/write. The application can read the corresponding endpoint DMA address register to get the error address.
$00000008 constant OTG_FS_OTG_DIEPINT3_TOC                          \ Timeout condition Indicates that the core has detected a timeout condition on the USB for the last IN token on this endpoint.
$00000010 constant OTG_FS_OTG_DIEPINT3_ITTXFE                       \ IN token received when Tx FIFO is empty Indicates that an IN token was received when the associated Tx FIFO (periodic/non-periodic) was empty. This interrupt is asserted on the endpoint for which the IN token was received.
$00000020 constant OTG_FS_OTG_DIEPINT3_INEPNM                       \ IN token received with EP mismatch Indicates that the data in the top of the non-periodic TxFIFO belongs to an endpoint other than the one for which the IN token was received. This interrupt is asserted on the endpoint for which the IN token was received.
$00000040 constant OTG_FS_OTG_DIEPINT3_INEPNE                       \ IN endpoint NAK effective This bit can be cleared when the application clears the IN endpoint NAK by writing to the CNAK bit in OTG_DIEPCTLx. This interrupt indicates that the core has sampled the NAK bit set (either by the application or by the core). The interrupt indicates that the IN endpoint NAK bit set by the application has taken effect in the core. This interrupt does not guarantee that a NAK handshake is sent on the USB. A STALL bit takes priority over a NAK bit.
$00000080 constant OTG_FS_OTG_DIEPINT3_TXFE                         \ Transmit FIFO empty This interrupt is asserted when the Tx FIFO for this endpoint is either half or completely empty. The half or completely empty status is determined by the Tx FIFO Empty Level bit in the OTG_GAHBCFG register (TXFELVL bit in OTG_GAHBCFG).
$00000100 constant OTG_FS_OTG_DIEPINT3_TXFIFOUDRN                   \ Transmit Fifo Underrun (TxfifoUndrn) The core generates this interrupt when it detects a transmit FIFO underrun condition for this endpoint. Dependency: This interrupt is valid only when Thresholding is enabled
$00000800 constant OTG_FS_OTG_DIEPINT3_PKTDRPSTS                    \ Packet dropped status This bit indicates to the application that an ISOC OUT packet has been dropped. This bit does not have an associated mask bit and does not generate an interrupt.
$00002000 constant OTG_FS_OTG_DIEPINT3_NAK                          \ NAK input The core generates this interrupt when a NAK is transmitted or received by the device. In case of isochronous IN endpoints the interrupt gets generated when a zero length packet is transmitted due to unavailability of data in the Tx FIFO.


\
\ @brief OTG device IN endpoint 3 transfer size register
\ Address offset: 0x970
\ Reset value: 0x00000000
\

$0007ffff constant OTG_FS_OTG_DIEPTSIZ3_XFRSIZ                      \ Transfer size This field contains the transfer size in bytes for the current endpoint. The core only interrupts the application after it has exhausted the transfer size amount of data. The transfer size can be set to the maximum packet size of the endpoint, to be interrupted at the end of each packet. The core decrements this field every time a packet from the external memory is written to the Tx FIFO.
$1ff80000 constant OTG_FS_OTG_DIEPTSIZ3_PKTCNT                      \ Packet count Indicates the total number of USB packets that constitute the transfer size amount of data for this endpoint. This field is decremented every time a packet (maximum size or short packet) is read from the Tx FIFO.
$60000000 constant OTG_FS_OTG_DIEPTSIZ3_MCNT                        \ Multi count For periodic IN endpoints, this field indicates the number of packets that must be transmitted per frame on the USB. The core uses this field to calculate the data PID for isochronous IN endpoints.


\
\ @brief OTG device IN endpoint 3 DMA address register
\ Address offset: 0x974
\ Reset value: 0x00000000
\

$00000000 constant OTG_FS_OTG_DIEPDMA3_DMAADDR                      \ DMA Address This field holds the start address in the external memory from which the data for the endpoint must be fetched. This register is incremented on every AHB transaction.


\
\ @brief OTG device IN endpoint transmit FIFO status register
\ Address offset: 0x978
\ Reset value: 0x00000200
\

$0000ffff constant OTG_FS_OTG_DTXFSTS3_INEPTFSAV                    \ IN endpoint Tx FIFO space available Indicates the amount of free space available in the endpoint Tx FIFO. Values are in terms of 32-bit words: 0xn: n words available Others: Reserved


\
\ @brief OTG device IN endpoint 4 control register
\ Address offset: 0x980
\ Reset value: 0x00000000
\

$000007ff constant OTG_FS_OTG_DIEPCTL4_INT_BULK_MPSIZ               \ Maximum packet size The application must program this field with the maximum packet size for the current logical endpoint. This value is in bytes.
$00008000 constant OTG_FS_OTG_DIEPCTL4_INT_BULK_USBAEP              \ USB active endpoint Indicates whether this endpoint is active in the current configuration and interface. The core clears this bit for all endpoints (other than EP 0) after detecting a USB reset. After receiving the SetConfiguration and SetInterface commands, the application must program endpoint registers accordingly and set this bit.
$00010000 constant OTG_FS_OTG_DIEPCTL4_INT_BULK_DPID                \ Endpoint data PID Applies to interrupt/bulk IN endpoints only. Contains the PID of the packet to be received or transmitted on this endpoint. The application must program the PID of the first packet to be received or transmitted on this endpoint, after the endpoint is activated. The application uses the SD0PID and SD1PID register fields to program either DATA0 or DATA1 PID.
$00020000 constant OTG_FS_OTG_DIEPCTL4_INT_BULK_NAKSTS              \ NAK status It indicates the following: When either the application or the core sets this bit: For non-isochronous IN endpoints: The core stops transmitting any data on an IN endpoint, even if there are data available in the Tx FIFO. For isochronous IN endpoints: The core sends out a zero-length data packet, even if there are data available in the Tx FIFO. Irrespective of this bits setting, the core always responds to SETUP data packets with an ACK handshake.
$000c0000 constant OTG_FS_OTG_DIEPCTL4_INT_BULK_EPTYP               \ Endpoint type This is the transfer type supported by this logical endpoint.
$00200000 constant OTG_FS_OTG_DIEPCTL4_INT_BULK_STALL               \ STALL handshake Applies to non-control, non-isochronous IN endpoints only (access type is rw). The application sets this bit to stall all tokens from the USB host to this endpoint. If a NAK bit, Global IN NAK, or Global OUT NAK is set along with this bit, the STALL bit takes priority. Only the application can clear this bit, never the core.
$03c00000 constant OTG_FS_OTG_DIEPCTL4_INT_BULK_TXFNUM              \ Tx FIFO number These bits specify the FIFO number associated with this endpoint. Each active IN endpoint must be programmed to a separate FIFO number. This field is valid only for IN endpoints.
$04000000 constant OTG_FS_OTG_DIEPCTL4_INT_BULK_CNAK                \ Clear NAK A write to this bit clears the NAK bit for the endpoint.
$08000000 constant OTG_FS_OTG_DIEPCTL4_INT_BULK_SNAK                \ Set NAK A write to this bit sets the NAK bit for the endpoint. Using this bit, the application can control the transmission of NAK handshakes on an endpoint. The core can also set this bit for OUT endpoints on a transfer completed interrupt, or after a SETUP is received on the endpoint.
$10000000 constant OTG_FS_OTG_DIEPCTL4_INT_BULK_SD0PID              \ Set DATA0 PID Applies to interrupt/bulk IN endpoints only. Writing to this field sets the endpoint data PID (DPID) field in this register to DATA0.
$20000000 constant OTG_FS_OTG_DIEPCTL4_INT_BULK_SD1PID              \ Set DATA1 PID Writing to this field sets the endpoint data PID (DPID) field in this register to DATA1.
$40000000 constant OTG_FS_OTG_DIEPCTL4_INT_BULK_EPDIS               \ Endpoint disable The application sets this bit to stop transmitting/receiving data on an endpoint, even before the transfer for that endpoint is complete. The application must wait for the endpoint disabled interrupt before treating the endpoint as disabled. The core clears this bit before setting the endpoint disabled interrupt. The application must set this bit only if endpoint enable is already set for this endpoint.
$80000000 constant OTG_FS_OTG_DIEPCTL4_INT_BULK_EPENA               \ Endpoint enable The application sets this bit to start transmitting data on an endpoint. The core clears this bit before setting any of the following interrupts on this endpoint: SETUP phase done Endpoint disabled Transfer completed


\
\ @brief OTG device IN endpoint 4 control register
\ Address offset: 0x980
\ Reset value: 0x00000000
\

$000007ff constant OTG_FS_OTG_DIEPCTL4_ISO_MPSIZ                    \ Maximum packet size The application must program this field with the maximum packet size for the current logical endpoint. This value is in bytes.
$00008000 constant OTG_FS_OTG_DIEPCTL4_ISO_USBAEP                   \ USB active endpoint Indicates whether this endpoint is active in the current configuration and interface. The core clears this bit for all endpoints (other than EP 0) after detecting a USB reset. After receiving the SetConfiguration and SetInterface commands, the application must program endpoint registers accordingly and set this bit.
$00010000 constant OTG_FS_OTG_DIEPCTL4_ISO_EONUM                    \ Even/odd frame Applies to isochronous IN endpoints only. Indicates the frame number in which the core transmits/receives isochronous data for this endpoint. The application must program the even/odd frame number in which it intends to transmit/receive isochronous data for this endpoint using the SEVNFRM and SODDFRM fields in this register.
$00020000 constant OTG_FS_OTG_DIEPCTL4_ISO_NAKSTS                   \ NAK status It indicates the following: When either the application or the core sets this bit: For non-isochronous IN endpoints: The core stops transmitting any data on an IN endpoint, even if there are data available in the Tx FIFO. For isochronous IN endpoints: The core sends out a zero-length data packet, even if there are data available in the Tx FIFO. Irrespective of this bits setting, the core always responds to SETUP data packets with an ACK handshake.
$000c0000 constant OTG_FS_OTG_DIEPCTL4_ISO_EPTYP                    \ Endpoint type This is the transfer type supported by this logical endpoint.
$00200000 constant OTG_FS_OTG_DIEPCTL4_ISO_STALL                    \ STALL handshake Applies to non-control, non-isochronous IN endpoints only (access type is rw). The application sets this bit to stall all tokens from the USB host to this endpoint. If a NAK bit, Global IN NAK, or Global OUT NAK is set along with this bit, the STALL bit takes priority. Only the application can clear this bit, never the core.
$03c00000 constant OTG_FS_OTG_DIEPCTL4_ISO_TXFNUM                   \ Tx FIFO number These bits specify the FIFO number associated with this endpoint. Each active IN endpoint must be programmed to a separate FIFO number. This field is valid only for IN endpoints.
$04000000 constant OTG_FS_OTG_DIEPCTL4_ISO_CNAK                     \ Clear NAK A write to this bit clears the NAK bit for the endpoint.
$08000000 constant OTG_FS_OTG_DIEPCTL4_ISO_SNAK                     \ Set NAK A write to this bit sets the NAK bit for the endpoint. Using this bit, the application can control the transmission of NAK handshakes on an endpoint. The core can also set this bit for OUT endpoints on a transfer completed interrupt, or after a SETUP is received on the endpoint.
$10000000 constant OTG_FS_OTG_DIEPCTL4_ISO_SEVNFRM                  \ Set even frame Applies to isochronous IN endpoints only. Writing to this field sets the Even/Odd frame (EONUM) field to even frame.
$20000000 constant OTG_FS_OTG_DIEPCTL4_ISO_SODDFRM                  \ Set odd frame Applies to isochronous IN and OUT endpoints only. Writing to this field sets the Even/Odd frame (EONUM) field to odd frame.
$40000000 constant OTG_FS_OTG_DIEPCTL4_ISO_EPDIS                    \ Endpoint disable The application sets this bit to stop transmitting/receiving data on an endpoint, even before the transfer for that endpoint is complete. The application must wait for the endpoint disabled interrupt before treating the endpoint as disabled. The core clears this bit before setting the endpoint disabled interrupt. The application must set this bit only if endpoint enable is already set for this endpoint.
$80000000 constant OTG_FS_OTG_DIEPCTL4_ISO_EPENA                    \ Endpoint enable The application sets this bit to start transmitting data on an endpoint. The core clears this bit before setting any of the following interrupts on this endpoint: SETUP phase done Endpoint disabled Transfer completed


\
\ @brief OTG device IN endpoint 4 interrupt register
\ Address offset: 0x988
\ Reset value: 0x00000080
\

$00000001 constant OTG_FS_OTG_DIEPINT4_XFRC                         \ Transfer completed interrupt This field indicates that the programmed transfer is complete on the AHB as well as on the USB, for this endpoint.
$00000002 constant OTG_FS_OTG_DIEPINT4_EPDISD                       \ Endpoint disabled interrupt This bit indicates that the endpoint is disabled per the applications request.
$00000004 constant OTG_FS_OTG_DIEPINT4_AHBERR                       \ AHB error This is generated only in internal DMA mode when there is an AHB error during an AHB read/write. The application can read the corresponding endpoint DMA address register to get the error address.
$00000008 constant OTG_FS_OTG_DIEPINT4_TOC                          \ Timeout condition Indicates that the core has detected a timeout condition on the USB for the last IN token on this endpoint.
$00000010 constant OTG_FS_OTG_DIEPINT4_ITTXFE                       \ IN token received when Tx FIFO is empty Indicates that an IN token was received when the associated Tx FIFO (periodic/non-periodic) was empty. This interrupt is asserted on the endpoint for which the IN token was received.
$00000020 constant OTG_FS_OTG_DIEPINT4_INEPNM                       \ IN token received with EP mismatch Indicates that the data in the top of the non-periodic TxFIFO belongs to an endpoint other than the one for which the IN token was received. This interrupt is asserted on the endpoint for which the IN token was received.
$00000040 constant OTG_FS_OTG_DIEPINT4_INEPNE                       \ IN endpoint NAK effective This bit can be cleared when the application clears the IN endpoint NAK by writing to the CNAK bit in OTG_DIEPCTLx. This interrupt indicates that the core has sampled the NAK bit set (either by the application or by the core). The interrupt indicates that the IN endpoint NAK bit set by the application has taken effect in the core. This interrupt does not guarantee that a NAK handshake is sent on the USB. A STALL bit takes priority over a NAK bit.
$00000080 constant OTG_FS_OTG_DIEPINT4_TXFE                         \ Transmit FIFO empty This interrupt is asserted when the Tx FIFO for this endpoint is either half or completely empty. The half or completely empty status is determined by the Tx FIFO Empty Level bit in the OTG_GAHBCFG register (TXFELVL bit in OTG_GAHBCFG).
$00000100 constant OTG_FS_OTG_DIEPINT4_TXFIFOUDRN                   \ Transmit Fifo Underrun (TxfifoUndrn) The core generates this interrupt when it detects a transmit FIFO underrun condition for this endpoint. Dependency: This interrupt is valid only when Thresholding is enabled
$00000800 constant OTG_FS_OTG_DIEPINT4_PKTDRPSTS                    \ Packet dropped status This bit indicates to the application that an ISOC OUT packet has been dropped. This bit does not have an associated mask bit and does not generate an interrupt.
$00002000 constant OTG_FS_OTG_DIEPINT4_NAK                          \ NAK input The core generates this interrupt when a NAK is transmitted or received by the device. In case of isochronous IN endpoints the interrupt gets generated when a zero length packet is transmitted due to unavailability of data in the Tx FIFO.


\
\ @brief OTG device IN endpoint 4 transfer size register
\ Address offset: 0x990
\ Reset value: 0x00000000
\

$0007ffff constant OTG_FS_OTG_DIEPTSIZ4_XFRSIZ                      \ Transfer size This field contains the transfer size in bytes for the current endpoint. The core only interrupts the application after it has exhausted the transfer size amount of data. The transfer size can be set to the maximum packet size of the endpoint, to be interrupted at the end of each packet. The core decrements this field every time a packet from the external memory is written to the Tx FIFO.
$1ff80000 constant OTG_FS_OTG_DIEPTSIZ4_PKTCNT                      \ Packet count Indicates the total number of USB packets that constitute the transfer size amount of data for this endpoint. This field is decremented every time a packet (maximum size or short packet) is read from the Tx FIFO.
$60000000 constant OTG_FS_OTG_DIEPTSIZ4_MCNT                        \ Multi count For periodic IN endpoints, this field indicates the number of packets that must be transmitted per frame on the USB. The core uses this field to calculate the data PID for isochronous IN endpoints.


\
\ @brief OTG device IN endpoint 4 DMA address register
\ Address offset: 0x994
\ Reset value: 0x00000000
\

$00000000 constant OTG_FS_OTG_DIEPDMA4_DMAADDR                      \ DMA Address This field holds the start address in the external memory from which the data for the endpoint must be fetched. This register is incremented on every AHB transaction.


\
\ @brief OTG device IN endpoint transmit FIFO status register
\ Address offset: 0x998
\ Reset value: 0x00000200
\

$0000ffff constant OTG_FS_OTG_DTXFSTS4_INEPTFSAV                    \ IN endpoint Tx FIFO space available Indicates the amount of free space available in the endpoint Tx FIFO. Values are in terms of 32-bit words: 0xn: n words available Others: Reserved


\
\ @brief OTG device IN endpoint 5 control register
\ Address offset: 0x9A0
\ Reset value: 0x00000000
\

$000007ff constant OTG_FS_OTG_DIEPCTL5_INT_BULK_MPSIZ               \ Maximum packet size The application must program this field with the maximum packet size for the current logical endpoint. This value is in bytes.
$00008000 constant OTG_FS_OTG_DIEPCTL5_INT_BULK_USBAEP              \ USB active endpoint Indicates whether this endpoint is active in the current configuration and interface. The core clears this bit for all endpoints (other than EP 0) after detecting a USB reset. After receiving the SetConfiguration and SetInterface commands, the application must program endpoint registers accordingly and set this bit.
$00010000 constant OTG_FS_OTG_DIEPCTL5_INT_BULK_DPID                \ Endpoint data PID Applies to interrupt/bulk IN endpoints only. Contains the PID of the packet to be received or transmitted on this endpoint. The application must program the PID of the first packet to be received or transmitted on this endpoint, after the endpoint is activated. The application uses the SD0PID and SD1PID register fields to program either DATA0 or DATA1 PID.
$00020000 constant OTG_FS_OTG_DIEPCTL5_INT_BULK_NAKSTS              \ NAK status It indicates the following: When either the application or the core sets this bit: For non-isochronous IN endpoints: The core stops transmitting any data on an IN endpoint, even if there are data available in the Tx FIFO. For isochronous IN endpoints: The core sends out a zero-length data packet, even if there are data available in the Tx FIFO. Irrespective of this bits setting, the core always responds to SETUP data packets with an ACK handshake.
$000c0000 constant OTG_FS_OTG_DIEPCTL5_INT_BULK_EPTYP               \ Endpoint type This is the transfer type supported by this logical endpoint.
$00200000 constant OTG_FS_OTG_DIEPCTL5_INT_BULK_STALL               \ STALL handshake Applies to non-control, non-isochronous IN endpoints only (access type is rw). The application sets this bit to stall all tokens from the USB host to this endpoint. If a NAK bit, Global IN NAK, or Global OUT NAK is set along with this bit, the STALL bit takes priority. Only the application can clear this bit, never the core.
$03c00000 constant OTG_FS_OTG_DIEPCTL5_INT_BULK_TXFNUM              \ Tx FIFO number These bits specify the FIFO number associated with this endpoint. Each active IN endpoint must be programmed to a separate FIFO number. This field is valid only for IN endpoints.
$04000000 constant OTG_FS_OTG_DIEPCTL5_INT_BULK_CNAK                \ Clear NAK A write to this bit clears the NAK bit for the endpoint.
$08000000 constant OTG_FS_OTG_DIEPCTL5_INT_BULK_SNAK                \ Set NAK A write to this bit sets the NAK bit for the endpoint. Using this bit, the application can control the transmission of NAK handshakes on an endpoint. The core can also set this bit for OUT endpoints on a transfer completed interrupt, or after a SETUP is received on the endpoint.
$10000000 constant OTG_FS_OTG_DIEPCTL5_INT_BULK_SD0PID              \ Set DATA0 PID Applies to interrupt/bulk IN endpoints only. Writing to this field sets the endpoint data PID (DPID) field in this register to DATA0.
$20000000 constant OTG_FS_OTG_DIEPCTL5_INT_BULK_SD1PID              \ Set DATA1 PID Writing to this field sets the endpoint data PID (DPID) field in this register to DATA1.
$40000000 constant OTG_FS_OTG_DIEPCTL5_INT_BULK_EPDIS               \ Endpoint disable The application sets this bit to stop transmitting/receiving data on an endpoint, even before the transfer for that endpoint is complete. The application must wait for the endpoint disabled interrupt before treating the endpoint as disabled. The core clears this bit before setting the endpoint disabled interrupt. The application must set this bit only if endpoint enable is already set for this endpoint.
$80000000 constant OTG_FS_OTG_DIEPCTL5_INT_BULK_EPENA               \ Endpoint enable The application sets this bit to start transmitting data on an endpoint. The core clears this bit before setting any of the following interrupts on this endpoint: SETUP phase done Endpoint disabled Transfer completed


\
\ @brief OTG device IN endpoint 5 control register
\ Address offset: 0x9A0
\ Reset value: 0x00000000
\

$000007ff constant OTG_FS_OTG_DIEPCTL5_ISO_MPSIZ                    \ Maximum packet size The application must program this field with the maximum packet size for the current logical endpoint. This value is in bytes.
$00008000 constant OTG_FS_OTG_DIEPCTL5_ISO_USBAEP                   \ USB active endpoint Indicates whether this endpoint is active in the current configuration and interface. The core clears this bit for all endpoints (other than EP 0) after detecting a USB reset. After receiving the SetConfiguration and SetInterface commands, the application must program endpoint registers accordingly and set this bit.
$00010000 constant OTG_FS_OTG_DIEPCTL5_ISO_EONUM                    \ Even/odd frame Applies to isochronous IN endpoints only. Indicates the frame number in which the core transmits/receives isochronous data for this endpoint. The application must program the even/odd frame number in which it intends to transmit/receive isochronous data for this endpoint using the SEVNFRM and SODDFRM fields in this register.
$00020000 constant OTG_FS_OTG_DIEPCTL5_ISO_NAKSTS                   \ NAK status It indicates the following: When either the application or the core sets this bit: For non-isochronous IN endpoints: The core stops transmitting any data on an IN endpoint, even if there are data available in the Tx FIFO. For isochronous IN endpoints: The core sends out a zero-length data packet, even if there are data available in the Tx FIFO. Irrespective of this bits setting, the core always responds to SETUP data packets with an ACK handshake.
$000c0000 constant OTG_FS_OTG_DIEPCTL5_ISO_EPTYP                    \ Endpoint type This is the transfer type supported by this logical endpoint.
$00200000 constant OTG_FS_OTG_DIEPCTL5_ISO_STALL                    \ STALL handshake Applies to non-control, non-isochronous IN endpoints only (access type is rw). The application sets this bit to stall all tokens from the USB host to this endpoint. If a NAK bit, Global IN NAK, or Global OUT NAK is set along with this bit, the STALL bit takes priority. Only the application can clear this bit, never the core.
$03c00000 constant OTG_FS_OTG_DIEPCTL5_ISO_TXFNUM                   \ Tx FIFO number These bits specify the FIFO number associated with this endpoint. Each active IN endpoint must be programmed to a separate FIFO number. This field is valid only for IN endpoints.
$04000000 constant OTG_FS_OTG_DIEPCTL5_ISO_CNAK                     \ Clear NAK A write to this bit clears the NAK bit for the endpoint.
$08000000 constant OTG_FS_OTG_DIEPCTL5_ISO_SNAK                     \ Set NAK A write to this bit sets the NAK bit for the endpoint. Using this bit, the application can control the transmission of NAK handshakes on an endpoint. The core can also set this bit for OUT endpoints on a transfer completed interrupt, or after a SETUP is received on the endpoint.
$10000000 constant OTG_FS_OTG_DIEPCTL5_ISO_SEVNFRM                  \ Set even frame Applies to isochronous IN endpoints only. Writing to this field sets the Even/Odd frame (EONUM) field to even frame.
$20000000 constant OTG_FS_OTG_DIEPCTL5_ISO_SODDFRM                  \ Set odd frame Applies to isochronous IN and OUT endpoints only. Writing to this field sets the Even/Odd frame (EONUM) field to odd frame.
$40000000 constant OTG_FS_OTG_DIEPCTL5_ISO_EPDIS                    \ Endpoint disable The application sets this bit to stop transmitting/receiving data on an endpoint, even before the transfer for that endpoint is complete. The application must wait for the endpoint disabled interrupt before treating the endpoint as disabled. The core clears this bit before setting the endpoint disabled interrupt. The application must set this bit only if endpoint enable is already set for this endpoint.
$80000000 constant OTG_FS_OTG_DIEPCTL5_ISO_EPENA                    \ Endpoint enable The application sets this bit to start transmitting data on an endpoint. The core clears this bit before setting any of the following interrupts on this endpoint: SETUP phase done Endpoint disabled Transfer completed


\
\ @brief OTG device IN endpoint 5 interrupt register
\ Address offset: 0x9A8
\ Reset value: 0x00000080
\

$00000001 constant OTG_FS_OTG_DIEPINT5_XFRC                         \ Transfer completed interrupt This field indicates that the programmed transfer is complete on the AHB as well as on the USB, for this endpoint.
$00000002 constant OTG_FS_OTG_DIEPINT5_EPDISD                       \ Endpoint disabled interrupt This bit indicates that the endpoint is disabled per the applications request.
$00000004 constant OTG_FS_OTG_DIEPINT5_AHBERR                       \ AHB error This is generated only in internal DMA mode when there is an AHB error during an AHB read/write. The application can read the corresponding endpoint DMA address register to get the error address.
$00000008 constant OTG_FS_OTG_DIEPINT5_TOC                          \ Timeout condition Indicates that the core has detected a timeout condition on the USB for the last IN token on this endpoint.
$00000010 constant OTG_FS_OTG_DIEPINT5_ITTXFE                       \ IN token received when Tx FIFO is empty Indicates that an IN token was received when the associated Tx FIFO (periodic/non-periodic) was empty. This interrupt is asserted on the endpoint for which the IN token was received.
$00000020 constant OTG_FS_OTG_DIEPINT5_INEPNM                       \ IN token received with EP mismatch Indicates that the data in the top of the non-periodic TxFIFO belongs to an endpoint other than the one for which the IN token was received. This interrupt is asserted on the endpoint for which the IN token was received.
$00000040 constant OTG_FS_OTG_DIEPINT5_INEPNE                       \ IN endpoint NAK effective This bit can be cleared when the application clears the IN endpoint NAK by writing to the CNAK bit in OTG_DIEPCTLx. This interrupt indicates that the core has sampled the NAK bit set (either by the application or by the core). The interrupt indicates that the IN endpoint NAK bit set by the application has taken effect in the core. This interrupt does not guarantee that a NAK handshake is sent on the USB. A STALL bit takes priority over a NAK bit.
$00000080 constant OTG_FS_OTG_DIEPINT5_TXFE                         \ Transmit FIFO empty This interrupt is asserted when the Tx FIFO for this endpoint is either half or completely empty. The half or completely empty status is determined by the Tx FIFO Empty Level bit in the OTG_GAHBCFG register (TXFELVL bit in OTG_GAHBCFG).
$00000100 constant OTG_FS_OTG_DIEPINT5_TXFIFOUDRN                   \ Transmit Fifo Underrun (TxfifoUndrn) The core generates this interrupt when it detects a transmit FIFO underrun condition for this endpoint. Dependency: This interrupt is valid only when Thresholding is enabled
$00000800 constant OTG_FS_OTG_DIEPINT5_PKTDRPSTS                    \ Packet dropped status This bit indicates to the application that an ISOC OUT packet has been dropped. This bit does not have an associated mask bit and does not generate an interrupt.
$00002000 constant OTG_FS_OTG_DIEPINT5_NAK                          \ NAK input The core generates this interrupt when a NAK is transmitted or received by the device. In case of isochronous IN endpoints the interrupt gets generated when a zero length packet is transmitted due to unavailability of data in the Tx FIFO.


\
\ @brief OTG device IN endpoint 5 transfer size register
\ Address offset: 0x9B0
\ Reset value: 0x00000000
\

$0007ffff constant OTG_FS_OTG_DIEPTSIZ5_XFRSIZ                      \ Transfer size This field contains the transfer size in bytes for the current endpoint. The core only interrupts the application after it has exhausted the transfer size amount of data. The transfer size can be set to the maximum packet size of the endpoint, to be interrupted at the end of each packet. The core decrements this field every time a packet from the external memory is written to the Tx FIFO.
$1ff80000 constant OTG_FS_OTG_DIEPTSIZ5_PKTCNT                      \ Packet count Indicates the total number of USB packets that constitute the transfer size amount of data for this endpoint. This field is decremented every time a packet (maximum size or short packet) is read from the Tx FIFO.
$60000000 constant OTG_FS_OTG_DIEPTSIZ5_MCNT                        \ Multi count For periodic IN endpoints, this field indicates the number of packets that must be transmitted per frame on the USB. The core uses this field to calculate the data PID for isochronous IN endpoints.


\
\ @brief OTG device IN endpoint 5 DMA address register
\ Address offset: 0x9B4
\ Reset value: 0x00000000
\

$00000000 constant OTG_FS_OTG_DIEPDMA5_DMAADDR                      \ DMA Address This field holds the start address in the external memory from which the data for the endpoint must be fetched. This register is incremented on every AHB transaction.


\
\ @brief OTG device IN endpoint transmit FIFO status register
\ Address offset: 0x9B8
\ Reset value: 0x00000200
\

$0000ffff constant OTG_FS_OTG_DTXFSTS5_INEPTFSAV                    \ IN endpoint Tx FIFO space available Indicates the amount of free space available in the endpoint Tx FIFO. Values are in terms of 32-bit words: 0xn: n words available Others: Reserved


\
\ @brief OTG device IN endpoint 6 control register
\ Address offset: 0x9C0
\ Reset value: 0x00000000
\

$000007ff constant OTG_FS_OTG_DIEPCTL6_INT_BULK_MPSIZ               \ Maximum packet size The application must program this field with the maximum packet size for the current logical endpoint. This value is in bytes.
$00008000 constant OTG_FS_OTG_DIEPCTL6_INT_BULK_USBAEP              \ USB active endpoint Indicates whether this endpoint is active in the current configuration and interface. The core clears this bit for all endpoints (other than EP 0) after detecting a USB reset. After receiving the SetConfiguration and SetInterface commands, the application must program endpoint registers accordingly and set this bit.
$00010000 constant OTG_FS_OTG_DIEPCTL6_INT_BULK_DPID                \ Endpoint data PID Applies to interrupt/bulk IN endpoints only. Contains the PID of the packet to be received or transmitted on this endpoint. The application must program the PID of the first packet to be received or transmitted on this endpoint, after the endpoint is activated. The application uses the SD0PID and SD1PID register fields to program either DATA0 or DATA1 PID.
$00020000 constant OTG_FS_OTG_DIEPCTL6_INT_BULK_NAKSTS              \ NAK status It indicates the following: When either the application or the core sets this bit: For non-isochronous IN endpoints: The core stops transmitting any data on an IN endpoint, even if there are data available in the Tx FIFO. For isochronous IN endpoints: The core sends out a zero-length data packet, even if there are data available in the Tx FIFO. Irrespective of this bits setting, the core always responds to SETUP data packets with an ACK handshake.
$000c0000 constant OTG_FS_OTG_DIEPCTL6_INT_BULK_EPTYP               \ Endpoint type This is the transfer type supported by this logical endpoint.
$00200000 constant OTG_FS_OTG_DIEPCTL6_INT_BULK_STALL               \ STALL handshake Applies to non-control, non-isochronous IN endpoints only (access type is rw). The application sets this bit to stall all tokens from the USB host to this endpoint. If a NAK bit, Global IN NAK, or Global OUT NAK is set along with this bit, the STALL bit takes priority. Only the application can clear this bit, never the core.
$03c00000 constant OTG_FS_OTG_DIEPCTL6_INT_BULK_TXFNUM              \ Tx FIFO number These bits specify the FIFO number associated with this endpoint. Each active IN endpoint must be programmed to a separate FIFO number. This field is valid only for IN endpoints.
$04000000 constant OTG_FS_OTG_DIEPCTL6_INT_BULK_CNAK                \ Clear NAK A write to this bit clears the NAK bit for the endpoint.
$08000000 constant OTG_FS_OTG_DIEPCTL6_INT_BULK_SNAK                \ Set NAK A write to this bit sets the NAK bit for the endpoint. Using this bit, the application can control the transmission of NAK handshakes on an endpoint. The core can also set this bit for OUT endpoints on a transfer completed interrupt, or after a SETUP is received on the endpoint.
$10000000 constant OTG_FS_OTG_DIEPCTL6_INT_BULK_SD0PID              \ Set DATA0 PID Applies to interrupt/bulk IN endpoints only. Writing to this field sets the endpoint data PID (DPID) field in this register to DATA0.
$20000000 constant OTG_FS_OTG_DIEPCTL6_INT_BULK_SD1PID              \ Set DATA1 PID Writing to this field sets the endpoint data PID (DPID) field in this register to DATA1.
$40000000 constant OTG_FS_OTG_DIEPCTL6_INT_BULK_EPDIS               \ Endpoint disable The application sets this bit to stop transmitting/receiving data on an endpoint, even before the transfer for that endpoint is complete. The application must wait for the endpoint disabled interrupt before treating the endpoint as disabled. The core clears this bit before setting the endpoint disabled interrupt. The application must set this bit only if endpoint enable is already set for this endpoint.
$80000000 constant OTG_FS_OTG_DIEPCTL6_INT_BULK_EPENA               \ Endpoint enable The application sets this bit to start transmitting data on an endpoint. The core clears this bit before setting any of the following interrupts on this endpoint: SETUP phase done Endpoint disabled Transfer completed


\
\ @brief OTG device IN endpoint 6 control register
\ Address offset: 0x9C0
\ Reset value: 0x00000000
\

$000007ff constant OTG_FS_OTG_DIEPCTL6_ISO_MPSIZ                    \ Maximum packet size The application must program this field with the maximum packet size for the current logical endpoint. This value is in bytes.
$00008000 constant OTG_FS_OTG_DIEPCTL6_ISO_USBAEP                   \ USB active endpoint Indicates whether this endpoint is active in the current configuration and interface. The core clears this bit for all endpoints (other than EP 0) after detecting a USB reset. After receiving the SetConfiguration and SetInterface commands, the application must program endpoint registers accordingly and set this bit.
$00010000 constant OTG_FS_OTG_DIEPCTL6_ISO_EONUM                    \ Even/odd frame Applies to isochronous IN endpoints only. Indicates the frame number in which the core transmits/receives isochronous data for this endpoint. The application must program the even/odd frame number in which it intends to transmit/receive isochronous data for this endpoint using the SEVNFRM and SODDFRM fields in this register.
$00020000 constant OTG_FS_OTG_DIEPCTL6_ISO_NAKSTS                   \ NAK status It indicates the following: When either the application or the core sets this bit: For non-isochronous IN endpoints: The core stops transmitting any data on an IN endpoint, even if there are data available in the Tx FIFO. For isochronous IN endpoints: The core sends out a zero-length data packet, even if there are data available in the Tx FIFO. Irrespective of this bits setting, the core always responds to SETUP data packets with an ACK handshake.
$000c0000 constant OTG_FS_OTG_DIEPCTL6_ISO_EPTYP                    \ Endpoint type This is the transfer type supported by this logical endpoint.
$00200000 constant OTG_FS_OTG_DIEPCTL6_ISO_STALL                    \ STALL handshake Applies to non-control, non-isochronous IN endpoints only (access type is rw). The application sets this bit to stall all tokens from the USB host to this endpoint. If a NAK bit, Global IN NAK, or Global OUT NAK is set along with this bit, the STALL bit takes priority. Only the application can clear this bit, never the core.
$03c00000 constant OTG_FS_OTG_DIEPCTL6_ISO_TXFNUM                   \ Tx FIFO number These bits specify the FIFO number associated with this endpoint. Each active IN endpoint must be programmed to a separate FIFO number. This field is valid only for IN endpoints.
$04000000 constant OTG_FS_OTG_DIEPCTL6_ISO_CNAK                     \ Clear NAK A write to this bit clears the NAK bit for the endpoint.
$08000000 constant OTG_FS_OTG_DIEPCTL6_ISO_SNAK                     \ Set NAK A write to this bit sets the NAK bit for the endpoint. Using this bit, the application can control the transmission of NAK handshakes on an endpoint. The core can also set this bit for OUT endpoints on a transfer completed interrupt, or after a SETUP is received on the endpoint.
$10000000 constant OTG_FS_OTG_DIEPCTL6_ISO_SEVNFRM                  \ Set even frame Applies to isochronous IN endpoints only. Writing to this field sets the Even/Odd frame (EONUM) field to even frame.
$20000000 constant OTG_FS_OTG_DIEPCTL6_ISO_SODDFRM                  \ Set odd frame Applies to isochronous IN and OUT endpoints only. Writing to this field sets the Even/Odd frame (EONUM) field to odd frame.
$40000000 constant OTG_FS_OTG_DIEPCTL6_ISO_EPDIS                    \ Endpoint disable The application sets this bit to stop transmitting/receiving data on an endpoint, even before the transfer for that endpoint is complete. The application must wait for the endpoint disabled interrupt before treating the endpoint as disabled. The core clears this bit before setting the endpoint disabled interrupt. The application must set this bit only if endpoint enable is already set for this endpoint.
$80000000 constant OTG_FS_OTG_DIEPCTL6_ISO_EPENA                    \ Endpoint enable The application sets this bit to start transmitting data on an endpoint. The core clears this bit before setting any of the following interrupts on this endpoint: SETUP phase done Endpoint disabled Transfer completed


\
\ @brief OTG device IN endpoint 6 interrupt register
\ Address offset: 0x9C8
\ Reset value: 0x00000080
\

$00000001 constant OTG_FS_OTG_DIEPINT6_XFRC                         \ Transfer completed interrupt This field indicates that the programmed transfer is complete on the AHB as well as on the USB, for this endpoint.
$00000002 constant OTG_FS_OTG_DIEPINT6_EPDISD                       \ Endpoint disabled interrupt This bit indicates that the endpoint is disabled per the applications request.
$00000004 constant OTG_FS_OTG_DIEPINT6_AHBERR                       \ AHB error This is generated only in internal DMA mode when there is an AHB error during an AHB read/write. The application can read the corresponding endpoint DMA address register to get the error address.
$00000008 constant OTG_FS_OTG_DIEPINT6_TOC                          \ Timeout condition Indicates that the core has detected a timeout condition on the USB for the last IN token on this endpoint.
$00000010 constant OTG_FS_OTG_DIEPINT6_ITTXFE                       \ IN token received when Tx FIFO is empty Indicates that an IN token was received when the associated Tx FIFO (periodic/non-periodic) was empty. This interrupt is asserted on the endpoint for which the IN token was received.
$00000020 constant OTG_FS_OTG_DIEPINT6_INEPNM                       \ IN token received with EP mismatch Indicates that the data in the top of the non-periodic TxFIFO belongs to an endpoint other than the one for which the IN token was received. This interrupt is asserted on the endpoint for which the IN token was received.
$00000040 constant OTG_FS_OTG_DIEPINT6_INEPNE                       \ IN endpoint NAK effective This bit can be cleared when the application clears the IN endpoint NAK by writing to the CNAK bit in OTG_DIEPCTLx. This interrupt indicates that the core has sampled the NAK bit set (either by the application or by the core). The interrupt indicates that the IN endpoint NAK bit set by the application has taken effect in the core. This interrupt does not guarantee that a NAK handshake is sent on the USB. A STALL bit takes priority over a NAK bit.
$00000080 constant OTG_FS_OTG_DIEPINT6_TXFE                         \ Transmit FIFO empty This interrupt is asserted when the Tx FIFO for this endpoint is either half or completely empty. The half or completely empty status is determined by the Tx FIFO Empty Level bit in the OTG_GAHBCFG register (TXFELVL bit in OTG_GAHBCFG).
$00000100 constant OTG_FS_OTG_DIEPINT6_TXFIFOUDRN                   \ Transmit Fifo Underrun (TxfifoUndrn) The core generates this interrupt when it detects a transmit FIFO underrun condition for this endpoint. Dependency: This interrupt is valid only when Thresholding is enabled
$00000800 constant OTG_FS_OTG_DIEPINT6_PKTDRPSTS                    \ Packet dropped status This bit indicates to the application that an ISOC OUT packet has been dropped. This bit does not have an associated mask bit and does not generate an interrupt.
$00002000 constant OTG_FS_OTG_DIEPINT6_NAK                          \ NAK input The core generates this interrupt when a NAK is transmitted or received by the device. In case of isochronous IN endpoints the interrupt gets generated when a zero length packet is transmitted due to unavailability of data in the Tx FIFO.


\
\ @brief OTG device IN endpoint 6 transfer size register
\ Address offset: 0x9D0
\ Reset value: 0x00000000
\

$0007ffff constant OTG_FS_OTG_DIEPTSIZ6_XFRSIZ                      \ Transfer size This field contains the transfer size in bytes for the current endpoint. The core only interrupts the application after it has exhausted the transfer size amount of data. The transfer size can be set to the maximum packet size of the endpoint, to be interrupted at the end of each packet. The core decrements this field every time a packet from the external memory is written to the Tx FIFO.
$1ff80000 constant OTG_FS_OTG_DIEPTSIZ6_PKTCNT                      \ Packet count Indicates the total number of USB packets that constitute the transfer size amount of data for this endpoint. This field is decremented every time a packet (maximum size or short packet) is read from the Tx FIFO.
$60000000 constant OTG_FS_OTG_DIEPTSIZ6_MCNT                        \ Multi count For periodic IN endpoints, this field indicates the number of packets that must be transmitted per frame on the USB. The core uses this field to calculate the data PID for isochronous IN endpoints.


\
\ @brief OTG device IN endpoint 6 DMA address register
\ Address offset: 0x9D4
\ Reset value: 0x00000000
\

$00000000 constant OTG_FS_OTG_DIEPDMA6_DMAADDR                      \ DMA Address This field holds the start address in the external memory from which the data for the endpoint must be fetched. This register is incremented on every AHB transaction.


\
\ @brief OTG device IN endpoint transmit FIFO status register
\ Address offset: 0x9D8
\ Reset value: 0x00000200
\

$0000ffff constant OTG_FS_OTG_DTXFSTS6_INEPTFSAV                    \ IN endpoint Tx FIFO space available Indicates the amount of free space available in the endpoint Tx FIFO. Values are in terms of 32-bit words: 0xn: n words available Others: Reserved


\
\ @brief OTG device IN endpoint 7 control register
\ Address offset: 0x9E0
\ Reset value: 0x00000000
\

$000007ff constant OTG_FS_OTG_DIEPCTL7_INT_BULK_MPSIZ               \ Maximum packet size The application must program this field with the maximum packet size for the current logical endpoint. This value is in bytes.
$00008000 constant OTG_FS_OTG_DIEPCTL7_INT_BULK_USBAEP              \ USB active endpoint Indicates whether this endpoint is active in the current configuration and interface. The core clears this bit for all endpoints (other than EP 0) after detecting a USB reset. After receiving the SetConfiguration and SetInterface commands, the application must program endpoint registers accordingly and set this bit.
$00010000 constant OTG_FS_OTG_DIEPCTL7_INT_BULK_DPID                \ Endpoint data PID Applies to interrupt/bulk IN endpoints only. Contains the PID of the packet to be received or transmitted on this endpoint. The application must program the PID of the first packet to be received or transmitted on this endpoint, after the endpoint is activated. The application uses the SD0PID and SD1PID register fields to program either DATA0 or DATA1 PID.
$00020000 constant OTG_FS_OTG_DIEPCTL7_INT_BULK_NAKSTS              \ NAK status It indicates the following: When either the application or the core sets this bit: For non-isochronous IN endpoints: The core stops transmitting any data on an IN endpoint, even if there are data available in the Tx FIFO. For isochronous IN endpoints: The core sends out a zero-length data packet, even if there are data available in the Tx FIFO. Irrespective of this bits setting, the core always responds to SETUP data packets with an ACK handshake.
$000c0000 constant OTG_FS_OTG_DIEPCTL7_INT_BULK_EPTYP               \ Endpoint type This is the transfer type supported by this logical endpoint.
$00200000 constant OTG_FS_OTG_DIEPCTL7_INT_BULK_STALL               \ STALL handshake Applies to non-control, non-isochronous IN endpoints only (access type is rw). The application sets this bit to stall all tokens from the USB host to this endpoint. If a NAK bit, Global IN NAK, or Global OUT NAK is set along with this bit, the STALL bit takes priority. Only the application can clear this bit, never the core.
$03c00000 constant OTG_FS_OTG_DIEPCTL7_INT_BULK_TXFNUM              \ Tx FIFO number These bits specify the FIFO number associated with this endpoint. Each active IN endpoint must be programmed to a separate FIFO number. This field is valid only for IN endpoints.
$04000000 constant OTG_FS_OTG_DIEPCTL7_INT_BULK_CNAK                \ Clear NAK A write to this bit clears the NAK bit for the endpoint.
$08000000 constant OTG_FS_OTG_DIEPCTL7_INT_BULK_SNAK                \ Set NAK A write to this bit sets the NAK bit for the endpoint. Using this bit, the application can control the transmission of NAK handshakes on an endpoint. The core can also set this bit for OUT endpoints on a transfer completed interrupt, or after a SETUP is received on the endpoint.
$10000000 constant OTG_FS_OTG_DIEPCTL7_INT_BULK_SD0PID              \ Set DATA0 PID Applies to interrupt/bulk IN endpoints only. Writing to this field sets the endpoint data PID (DPID) field in this register to DATA0.
$20000000 constant OTG_FS_OTG_DIEPCTL7_INT_BULK_SD1PID              \ Set DATA1 PID Writing to this field sets the endpoint data PID (DPID) field in this register to DATA1.
$40000000 constant OTG_FS_OTG_DIEPCTL7_INT_BULK_EPDIS               \ Endpoint disable The application sets this bit to stop transmitting/receiving data on an endpoint, even before the transfer for that endpoint is complete. The application must wait for the endpoint disabled interrupt before treating the endpoint as disabled. The core clears this bit before setting the endpoint disabled interrupt. The application must set this bit only if endpoint enable is already set for this endpoint.
$80000000 constant OTG_FS_OTG_DIEPCTL7_INT_BULK_EPENA               \ Endpoint enable The application sets this bit to start transmitting data on an endpoint. The core clears this bit before setting any of the following interrupts on this endpoint: SETUP phase done Endpoint disabled Transfer completed


\
\ @brief OTG device IN endpoint 7 control register
\ Address offset: 0x9E0
\ Reset value: 0x00000000
\

$000007ff constant OTG_FS_OTG_DIEPCTL7_ISO_MPSIZ                    \ Maximum packet size The application must program this field with the maximum packet size for the current logical endpoint. This value is in bytes.
$00008000 constant OTG_FS_OTG_DIEPCTL7_ISO_USBAEP                   \ USB active endpoint Indicates whether this endpoint is active in the current configuration and interface. The core clears this bit for all endpoints (other than EP 0) after detecting a USB reset. After receiving the SetConfiguration and SetInterface commands, the application must program endpoint registers accordingly and set this bit.
$00010000 constant OTG_FS_OTG_DIEPCTL7_ISO_EONUM                    \ Even/odd frame Applies to isochronous IN endpoints only. Indicates the frame number in which the core transmits/receives isochronous data for this endpoint. The application must program the even/odd frame number in which it intends to transmit/receive isochronous data for this endpoint using the SEVNFRM and SODDFRM fields in this register.
$00020000 constant OTG_FS_OTG_DIEPCTL7_ISO_NAKSTS                   \ NAK status It indicates the following: When either the application or the core sets this bit: For non-isochronous IN endpoints: The core stops transmitting any data on an IN endpoint, even if there are data available in the Tx FIFO. For isochronous IN endpoints: The core sends out a zero-length data packet, even if there are data available in the Tx FIFO. Irrespective of this bits setting, the core always responds to SETUP data packets with an ACK handshake.
$000c0000 constant OTG_FS_OTG_DIEPCTL7_ISO_EPTYP                    \ Endpoint type This is the transfer type supported by this logical endpoint.
$00200000 constant OTG_FS_OTG_DIEPCTL7_ISO_STALL                    \ STALL handshake Applies to non-control, non-isochronous IN endpoints only (access type is rw). The application sets this bit to stall all tokens from the USB host to this endpoint. If a NAK bit, Global IN NAK, or Global OUT NAK is set along with this bit, the STALL bit takes priority. Only the application can clear this bit, never the core.
$03c00000 constant OTG_FS_OTG_DIEPCTL7_ISO_TXFNUM                   \ Tx FIFO number These bits specify the FIFO number associated with this endpoint. Each active IN endpoint must be programmed to a separate FIFO number. This field is valid only for IN endpoints.
$04000000 constant OTG_FS_OTG_DIEPCTL7_ISO_CNAK                     \ Clear NAK A write to this bit clears the NAK bit for the endpoint.
$08000000 constant OTG_FS_OTG_DIEPCTL7_ISO_SNAK                     \ Set NAK A write to this bit sets the NAK bit for the endpoint. Using this bit, the application can control the transmission of NAK handshakes on an endpoint. The core can also set this bit for OUT endpoints on a transfer completed interrupt, or after a SETUP is received on the endpoint.
$10000000 constant OTG_FS_OTG_DIEPCTL7_ISO_SEVNFRM                  \ Set even frame Applies to isochronous IN endpoints only. Writing to this field sets the Even/Odd frame (EONUM) field to even frame.
$20000000 constant OTG_FS_OTG_DIEPCTL7_ISO_SODDFRM                  \ Set odd frame Applies to isochronous IN and OUT endpoints only. Writing to this field sets the Even/Odd frame (EONUM) field to odd frame.
$40000000 constant OTG_FS_OTG_DIEPCTL7_ISO_EPDIS                    \ Endpoint disable The application sets this bit to stop transmitting/receiving data on an endpoint, even before the transfer for that endpoint is complete. The application must wait for the endpoint disabled interrupt before treating the endpoint as disabled. The core clears this bit before setting the endpoint disabled interrupt. The application must set this bit only if endpoint enable is already set for this endpoint.
$80000000 constant OTG_FS_OTG_DIEPCTL7_ISO_EPENA                    \ Endpoint enable The application sets this bit to start transmitting data on an endpoint. The core clears this bit before setting any of the following interrupts on this endpoint: SETUP phase done Endpoint disabled Transfer completed


\
\ @brief OTG device IN endpoint 7 interrupt register
\ Address offset: 0x9E8
\ Reset value: 0x00000080
\

$00000001 constant OTG_FS_OTG_DIEPINT7_XFRC                         \ Transfer completed interrupt This field indicates that the programmed transfer is complete on the AHB as well as on the USB, for this endpoint.
$00000002 constant OTG_FS_OTG_DIEPINT7_EPDISD                       \ Endpoint disabled interrupt This bit indicates that the endpoint is disabled per the applications request.
$00000004 constant OTG_FS_OTG_DIEPINT7_AHBERR                       \ AHB error This is generated only in internal DMA mode when there is an AHB error during an AHB read/write. The application can read the corresponding endpoint DMA address register to get the error address.
$00000008 constant OTG_FS_OTG_DIEPINT7_TOC                          \ Timeout condition Indicates that the core has detected a timeout condition on the USB for the last IN token on this endpoint.
$00000010 constant OTG_FS_OTG_DIEPINT7_ITTXFE                       \ IN token received when Tx FIFO is empty Indicates that an IN token was received when the associated Tx FIFO (periodic/non-periodic) was empty. This interrupt is asserted on the endpoint for which the IN token was received.
$00000020 constant OTG_FS_OTG_DIEPINT7_INEPNM                       \ IN token received with EP mismatch Indicates that the data in the top of the non-periodic TxFIFO belongs to an endpoint other than the one for which the IN token was received. This interrupt is asserted on the endpoint for which the IN token was received.
$00000040 constant OTG_FS_OTG_DIEPINT7_INEPNE                       \ IN endpoint NAK effective This bit can be cleared when the application clears the IN endpoint NAK by writing to the CNAK bit in OTG_DIEPCTLx. This interrupt indicates that the core has sampled the NAK bit set (either by the application or by the core). The interrupt indicates that the IN endpoint NAK bit set by the application has taken effect in the core. This interrupt does not guarantee that a NAK handshake is sent on the USB. A STALL bit takes priority over a NAK bit.
$00000080 constant OTG_FS_OTG_DIEPINT7_TXFE                         \ Transmit FIFO empty This interrupt is asserted when the Tx FIFO for this endpoint is either half or completely empty. The half or completely empty status is determined by the Tx FIFO Empty Level bit in the OTG_GAHBCFG register (TXFELVL bit in OTG_GAHBCFG).
$00000100 constant OTG_FS_OTG_DIEPINT7_TXFIFOUDRN                   \ Transmit Fifo Underrun (TxfifoUndrn) The core generates this interrupt when it detects a transmit FIFO underrun condition for this endpoint. Dependency: This interrupt is valid only when Thresholding is enabled
$00000800 constant OTG_FS_OTG_DIEPINT7_PKTDRPSTS                    \ Packet dropped status This bit indicates to the application that an ISOC OUT packet has been dropped. This bit does not have an associated mask bit and does not generate an interrupt.
$00002000 constant OTG_FS_OTG_DIEPINT7_NAK                          \ NAK input The core generates this interrupt when a NAK is transmitted or received by the device. In case of isochronous IN endpoints the interrupt gets generated when a zero length packet is transmitted due to unavailability of data in the Tx FIFO.


\
\ @brief OTG device IN endpoint 7 transfer size register
\ Address offset: 0x9F0
\ Reset value: 0x00000000
\

$0007ffff constant OTG_FS_OTG_DIEPTSIZ7_XFRSIZ                      \ Transfer size This field contains the transfer size in bytes for the current endpoint. The core only interrupts the application after it has exhausted the transfer size amount of data. The transfer size can be set to the maximum packet size of the endpoint, to be interrupted at the end of each packet. The core decrements this field every time a packet from the external memory is written to the Tx FIFO.
$1ff80000 constant OTG_FS_OTG_DIEPTSIZ7_PKTCNT                      \ Packet count Indicates the total number of USB packets that constitute the transfer size amount of data for this endpoint. This field is decremented every time a packet (maximum size or short packet) is read from the Tx FIFO.
$60000000 constant OTG_FS_OTG_DIEPTSIZ7_MCNT                        \ Multi count For periodic IN endpoints, this field indicates the number of packets that must be transmitted per frame on the USB. The core uses this field to calculate the data PID for isochronous IN endpoints.


\
\ @brief OTG device IN endpoint 7 DMA address register
\ Address offset: 0x9F4
\ Reset value: 0x00000000
\

$00000000 constant OTG_FS_OTG_DIEPDMA7_DMAADDR                      \ DMA Address This field holds the start address in the external memory from which the data for the endpoint must be fetched. This register is incremented on every AHB transaction.


\
\ @brief OTG device IN endpoint transmit FIFO status register
\ Address offset: 0x9F8
\ Reset value: 0x00000200
\

$0000ffff constant OTG_FS_OTG_DTXFSTS7_INEPTFSAV                    \ IN endpoint Tx FIFO space available Indicates the amount of free space available in the endpoint Tx FIFO. Values are in terms of 32-bit words: 0xn: n words available Others: Reserved


\
\ @brief OTG device IN endpoint 8 control register
\ Address offset: 0xA00
\ Reset value: 0x00000000
\

$000007ff constant OTG_FS_OTG_DIEPCTL8_INT_BULK_MPSIZ               \ Maximum packet size The application must program this field with the maximum packet size for the current logical endpoint. This value is in bytes.
$00008000 constant OTG_FS_OTG_DIEPCTL8_INT_BULK_USBAEP              \ USB active endpoint Indicates whether this endpoint is active in the current configuration and interface. The core clears this bit for all endpoints (other than EP 0) after detecting a USB reset. After receiving the SetConfiguration and SetInterface commands, the application must program endpoint registers accordingly and set this bit.
$00010000 constant OTG_FS_OTG_DIEPCTL8_INT_BULK_DPID                \ Endpoint data PID Applies to interrupt/bulk IN endpoints only. Contains the PID of the packet to be received or transmitted on this endpoint. The application must program the PID of the first packet to be received or transmitted on this endpoint, after the endpoint is activated. The application uses the SD0PID and SD1PID register fields to program either DATA0 or DATA1 PID.
$00020000 constant OTG_FS_OTG_DIEPCTL8_INT_BULK_NAKSTS              \ NAK status It indicates the following: When either the application or the core sets this bit: For non-isochronous IN endpoints: The core stops transmitting any data on an IN endpoint, even if there are data available in the Tx FIFO. For isochronous IN endpoints: The core sends out a zero-length data packet, even if there are data available in the Tx FIFO. Irrespective of this bits setting, the core always responds to SETUP data packets with an ACK handshake.
$000c0000 constant OTG_FS_OTG_DIEPCTL8_INT_BULK_EPTYP               \ Endpoint type This is the transfer type supported by this logical endpoint.
$00200000 constant OTG_FS_OTG_DIEPCTL8_INT_BULK_STALL               \ STALL handshake Applies to non-control, non-isochronous IN endpoints only (access type is rw). The application sets this bit to stall all tokens from the USB host to this endpoint. If a NAK bit, Global IN NAK, or Global OUT NAK is set along with this bit, the STALL bit takes priority. Only the application can clear this bit, never the core.
$03c00000 constant OTG_FS_OTG_DIEPCTL8_INT_BULK_TXFNUM              \ Tx FIFO number These bits specify the FIFO number associated with this endpoint. Each active IN endpoint must be programmed to a separate FIFO number. This field is valid only for IN endpoints.
$04000000 constant OTG_FS_OTG_DIEPCTL8_INT_BULK_CNAK                \ Clear NAK A write to this bit clears the NAK bit for the endpoint.
$08000000 constant OTG_FS_OTG_DIEPCTL8_INT_BULK_SNAK                \ Set NAK A write to this bit sets the NAK bit for the endpoint. Using this bit, the application can control the transmission of NAK handshakes on an endpoint. The core can also set this bit for OUT endpoints on a transfer completed interrupt, or after a SETUP is received on the endpoint.
$10000000 constant OTG_FS_OTG_DIEPCTL8_INT_BULK_SD0PID              \ Set DATA0 PID Applies to interrupt/bulk IN endpoints only. Writing to this field sets the endpoint data PID (DPID) field in this register to DATA0.
$20000000 constant OTG_FS_OTG_DIEPCTL8_INT_BULK_SD1PID              \ Set DATA1 PID Writing to this field sets the endpoint data PID (DPID) field in this register to DATA1.
$40000000 constant OTG_FS_OTG_DIEPCTL8_INT_BULK_EPDIS               \ Endpoint disable The application sets this bit to stop transmitting/receiving data on an endpoint, even before the transfer for that endpoint is complete. The application must wait for the endpoint disabled interrupt before treating the endpoint as disabled. The core clears this bit before setting the endpoint disabled interrupt. The application must set this bit only if endpoint enable is already set for this endpoint.
$80000000 constant OTG_FS_OTG_DIEPCTL8_INT_BULK_EPENA               \ Endpoint enable The application sets this bit to start transmitting data on an endpoint. The core clears this bit before setting any of the following interrupts on this endpoint: SETUP phase done Endpoint disabled Transfer completed


\
\ @brief OTG device IN endpoint 8 control register
\ Address offset: 0xA00
\ Reset value: 0x00000000
\

$000007ff constant OTG_FS_OTG_DIEPCTL8_ISO_MPSIZ                    \ Maximum packet size The application must program this field with the maximum packet size for the current logical endpoint. This value is in bytes.
$00008000 constant OTG_FS_OTG_DIEPCTL8_ISO_USBAEP                   \ USB active endpoint Indicates whether this endpoint is active in the current configuration and interface. The core clears this bit for all endpoints (other than EP 0) after detecting a USB reset. After receiving the SetConfiguration and SetInterface commands, the application must program endpoint registers accordingly and set this bit.
$00010000 constant OTG_FS_OTG_DIEPCTL8_ISO_EONUM                    \ Even/odd frame Applies to isochronous IN endpoints only. Indicates the frame number in which the core transmits/receives isochronous data for this endpoint. The application must program the even/odd frame number in which it intends to transmit/receive isochronous data for this endpoint using the SEVNFRM and SODDFRM fields in this register.
$00020000 constant OTG_FS_OTG_DIEPCTL8_ISO_NAKSTS                   \ NAK status It indicates the following: When either the application or the core sets this bit: For non-isochronous IN endpoints: The core stops transmitting any data on an IN endpoint, even if there are data available in the Tx FIFO. For isochronous IN endpoints: The core sends out a zero-length data packet, even if there are data available in the Tx FIFO. Irrespective of this bits setting, the core always responds to SETUP data packets with an ACK handshake.
$000c0000 constant OTG_FS_OTG_DIEPCTL8_ISO_EPTYP                    \ Endpoint type This is the transfer type supported by this logical endpoint.
$00200000 constant OTG_FS_OTG_DIEPCTL8_ISO_STALL                    \ STALL handshake Applies to non-control, non-isochronous IN endpoints only (access type is rw). The application sets this bit to stall all tokens from the USB host to this endpoint. If a NAK bit, Global IN NAK, or Global OUT NAK is set along with this bit, the STALL bit takes priority. Only the application can clear this bit, never the core.
$03c00000 constant OTG_FS_OTG_DIEPCTL8_ISO_TXFNUM                   \ Tx FIFO number These bits specify the FIFO number associated with this endpoint. Each active IN endpoint must be programmed to a separate FIFO number. This field is valid only for IN endpoints.
$04000000 constant OTG_FS_OTG_DIEPCTL8_ISO_CNAK                     \ Clear NAK A write to this bit clears the NAK bit for the endpoint.
$08000000 constant OTG_FS_OTG_DIEPCTL8_ISO_SNAK                     \ Set NAK A write to this bit sets the NAK bit for the endpoint. Using this bit, the application can control the transmission of NAK handshakes on an endpoint. The core can also set this bit for OUT endpoints on a transfer completed interrupt, or after a SETUP is received on the endpoint.
$10000000 constant OTG_FS_OTG_DIEPCTL8_ISO_SEVNFRM                  \ Set even frame Applies to isochronous IN endpoints only. Writing to this field sets the Even/Odd frame (EONUM) field to even frame.
$20000000 constant OTG_FS_OTG_DIEPCTL8_ISO_SODDFRM                  \ Set odd frame Applies to isochronous IN and OUT endpoints only. Writing to this field sets the Even/Odd frame (EONUM) field to odd frame.
$40000000 constant OTG_FS_OTG_DIEPCTL8_ISO_EPDIS                    \ Endpoint disable The application sets this bit to stop transmitting/receiving data on an endpoint, even before the transfer for that endpoint is complete. The application must wait for the endpoint disabled interrupt before treating the endpoint as disabled. The core clears this bit before setting the endpoint disabled interrupt. The application must set this bit only if endpoint enable is already set for this endpoint.
$80000000 constant OTG_FS_OTG_DIEPCTL8_ISO_EPENA                    \ Endpoint enable The application sets this bit to start transmitting data on an endpoint. The core clears this bit before setting any of the following interrupts on this endpoint: SETUP phase done Endpoint disabled Transfer completed


\
\ @brief OTG device IN endpoint 8 interrupt register
\ Address offset: 0xA08
\ Reset value: 0x00000080
\

$00000001 constant OTG_FS_OTG_DIEPINT8_XFRC                         \ Transfer completed interrupt This field indicates that the programmed transfer is complete on the AHB as well as on the USB, for this endpoint.
$00000002 constant OTG_FS_OTG_DIEPINT8_EPDISD                       \ Endpoint disabled interrupt This bit indicates that the endpoint is disabled per the applications request.
$00000004 constant OTG_FS_OTG_DIEPINT8_AHBERR                       \ AHB error This is generated only in internal DMA mode when there is an AHB error during an AHB read/write. The application can read the corresponding endpoint DMA address register to get the error address.
$00000008 constant OTG_FS_OTG_DIEPINT8_TOC                          \ Timeout condition Indicates that the core has detected a timeout condition on the USB for the last IN token on this endpoint.
$00000010 constant OTG_FS_OTG_DIEPINT8_ITTXFE                       \ IN token received when Tx FIFO is empty Indicates that an IN token was received when the associated Tx FIFO (periodic/non-periodic) was empty. This interrupt is asserted on the endpoint for which the IN token was received.
$00000020 constant OTG_FS_OTG_DIEPINT8_INEPNM                       \ IN token received with EP mismatch Indicates that the data in the top of the non-periodic TxFIFO belongs to an endpoint other than the one for which the IN token was received. This interrupt is asserted on the endpoint for which the IN token was received.
$00000040 constant OTG_FS_OTG_DIEPINT8_INEPNE                       \ IN endpoint NAK effective This bit can be cleared when the application clears the IN endpoint NAK by writing to the CNAK bit in OTG_DIEPCTLx. This interrupt indicates that the core has sampled the NAK bit set (either by the application or by the core). The interrupt indicates that the IN endpoint NAK bit set by the application has taken effect in the core. This interrupt does not guarantee that a NAK handshake is sent on the USB. A STALL bit takes priority over a NAK bit.
$00000080 constant OTG_FS_OTG_DIEPINT8_TXFE                         \ Transmit FIFO empty This interrupt is asserted when the Tx FIFO for this endpoint is either half or completely empty. The half or completely empty status is determined by the Tx FIFO Empty Level bit in the OTG_GAHBCFG register (TXFELVL bit in OTG_GAHBCFG).
$00000100 constant OTG_FS_OTG_DIEPINT8_TXFIFOUDRN                   \ Transmit Fifo Underrun (TxfifoUndrn) The core generates this interrupt when it detects a transmit FIFO underrun condition for this endpoint. Dependency: This interrupt is valid only when Thresholding is enabled
$00000800 constant OTG_FS_OTG_DIEPINT8_PKTDRPSTS                    \ Packet dropped status This bit indicates to the application that an ISOC OUT packet has been dropped. This bit does not have an associated mask bit and does not generate an interrupt.
$00002000 constant OTG_FS_OTG_DIEPINT8_NAK                          \ NAK input The core generates this interrupt when a NAK is transmitted or received by the device. In case of isochronous IN endpoints the interrupt gets generated when a zero length packet is transmitted due to unavailability of data in the Tx FIFO.


\
\ @brief OTG device IN endpoint 8 transfer size register
\ Address offset: 0xA10
\ Reset value: 0x00000000
\

$0007ffff constant OTG_FS_OTG_DIEPTSIZ8_XFRSIZ                      \ Transfer size This field contains the transfer size in bytes for the current endpoint. The core only interrupts the application after it has exhausted the transfer size amount of data. The transfer size can be set to the maximum packet size of the endpoint, to be interrupted at the end of each packet. The core decrements this field every time a packet from the external memory is written to the Tx FIFO.
$1ff80000 constant OTG_FS_OTG_DIEPTSIZ8_PKTCNT                      \ Packet count Indicates the total number of USB packets that constitute the transfer size amount of data for this endpoint. This field is decremented every time a packet (maximum size or short packet) is read from the Tx FIFO.
$60000000 constant OTG_FS_OTG_DIEPTSIZ8_MCNT                        \ Multi count For periodic IN endpoints, this field indicates the number of packets that must be transmitted per frame on the USB. The core uses this field to calculate the data PID for isochronous IN endpoints.


\
\ @brief OTG device IN endpoint 8 DMA address register
\ Address offset: 0xA14
\ Reset value: 0x00000000
\

$00000000 constant OTG_FS_OTG_DIEPDMA8_DMAADDR                      \ DMA Address This field holds the start address in the external memory from which the data for the endpoint must be fetched. This register is incremented on every AHB transaction.


\
\ @brief OTG device IN endpoint transmit FIFO status register
\ Address offset: 0xA18
\ Reset value: 0x00000200
\

$0000ffff constant OTG_FS_OTG_DTXFSTS8_INEPTFSAV                    \ IN endpoint Tx FIFO space available Indicates the amount of free space available in the endpoint Tx FIFO. Values are in terms of 32-bit words: 0xn: n words available Others: Reserved


\
\ @brief OTG device control OUT endpoint 0 control register
\ Address offset: 0xB00
\ Reset value: 0x00008000
\

$00000003 constant OTG_FS_OTG_DOEPCTL0_MPSIZ                        \ Maximum packet size The maximum packet size for control OUT endpoint 0 is the same as what is programmed in control IN endpoint 0.
$00008000 constant OTG_FS_OTG_DOEPCTL0_USBAEP                       \ USB active endpoint This bit is always set to 1, indicating that a control endpoint 0 is always active in all configurations and interfaces.
$00020000 constant OTG_FS_OTG_DOEPCTL0_NAKSTS                       \ NAK status Indicates the following: When either the application or the core sets this bit, the core stops receiving data, even if there is space in the Rx FIFO to accommodate the incoming packet. Irrespective of this bits setting, the core always responds to SETUP data packets with an ACK handshake.
$000c0000 constant OTG_FS_OTG_DOEPCTL0_EPTYP                        \ Endpoint type Hardcoded to 00 for control.
$00100000 constant OTG_FS_OTG_DOEPCTL0_SNPM                         \ Snoop mode This bit configures the endpoint to Snoop mode. In Snoop mode, the core does not check the correctness of OUT packets before transferring them to application memory.
$00200000 constant OTG_FS_OTG_DOEPCTL0_STALL                        \ STALL handshake The application can only set this bit, and the core clears it, when a SETUP token is received for this endpoint. If a NAK bit or Global OUT NAK is set along with this bit, the STALL bit takes priority. Irrespective of this bits setting, the core always responds to SETUP data packets with an ACK handshake.
$04000000 constant OTG_FS_OTG_DOEPCTL0_CNAK                         \ Clear NAK A write to this bit clears the NAK bit for the endpoint.
$08000000 constant OTG_FS_OTG_DOEPCTL0_SNAK                         \ Set NAK A write to this bit sets the NAK bit for the endpoint. Using this bit, the application can control the transmission of NAK handshakes on an endpoint. The core can also set this bit on a transfer completed interrupt, or after a SETUP is received on the endpoint.
$40000000 constant OTG_FS_OTG_DOEPCTL0_EPDIS                        \ Endpoint disable The application cannot disable control OUT endpoint 0.
$80000000 constant OTG_FS_OTG_DOEPCTL0_EPENA                        \ Endpoint enable The application sets this bit to start transmitting data on endpoint 0. The core clears this bit before setting any of the following interrupts on this endpoint: SETUP phase done Endpoint disabled Transfer completed


\
\ @brief OTG device OUT endpoint 0 interrupt register
\ Address offset: 0xB08
\ Reset value: 0x00000080
\

$00000001 constant OTG_FS_OTG_DOEPINT0_XFRC                         \ Transfer completed interrupt This field indicates that the programmed transfer is complete on the AHB as well as on the USB, for this endpoint.
$00000002 constant OTG_FS_OTG_DOEPINT0_EPDISD                       \ Endpoint disabled interrupt This bit indicates that the endpoint is disabled per the applications request.
$00000004 constant OTG_FS_OTG_DOEPINT0_AHBERR                       \ AHB error This is generated only in internal DMA mode when there is an AHB error during an AHB read/write. The application can read the corresponding endpoint DMA address register to get the error address.
$00000008 constant OTG_FS_OTG_DOEPINT0_STUP                         \ SETUP phase done Applies to control OUT endpoint only.Indicates that the SETUP phase for the control endpoint is complete and no more back-to-back SETUP packets were received for the current control transfer. On this interrupt, the application can decode the received SETUP data packet.
$00000010 constant OTG_FS_OTG_DOEPINT0_OTEPDIS                      \ OUT token received when endpoint disabled Applies only to control OUT endpoints. Indicates that an OUT token was received when the endpoint was not yet enabled. This interrupt is asserted on the endpoint for which the OUT token was received.
$00000020 constant OTG_FS_OTG_DOEPINT0_STSPHSRX                     \ Status phase received for control write This interrupt is valid only for control OUT endpoints. This interrupt is generated only after OTG_HS has transferred all the data that the host has sent during the data phase of a control write transfer, to the system memory buffer. The interrupt indicates to the application that the host has switched from data phase to the status phase of a control write transfer. The application can use this interrupt to ACK or STALL the status phase, after it has decoded the data phase.
$00000040 constant OTG_FS_OTG_DOEPINT0_B2BSTUP                      \ Back-to-back SETUP packets received Applies to control OUT endpoint only. This bit indicates that the core has received more than three back-to-back SETUP packets for this particular endpoint.
$00000100 constant OTG_FS_OTG_DOEPINT0_OUTPKTERR                    \ OUT packet error This interrupt is asserted when the core detects an overflow or a CRC error for an OUT packet. This interrupt is valid only when thresholding is enabled.
$00001000 constant OTG_FS_OTG_DOEPINT0_BERR                         \ Babble error interrupt The core generates this interrupt when babble is received for the endpoint.
$00002000 constant OTG_FS_OTG_DOEPINT0_NAK                          \ NAK input The core generates this interrupt when a NAK is transmitted or received by the device. In case of isochronous IN endpoints the interrupt gets generated when a zero length packet is transmitted due to unavailability of data in the Tx FIFO.
$00004000 constant OTG_FS_OTG_DOEPINT0_NYET                         \ NYET interrupt This interrupt is generated when a NYET response is transmitted for a non isochronous OUT endpoint.
$00008000 constant OTG_FS_OTG_DOEPINT0_STPKTRX                      \ Setup packet received Applicable for control OUT endpoints in only in the Buffer DMA Mode. Set by the OTG_HS, this bit indicates that this buffer holds 8 bytes of setup data. There is only one setup packet per buffer. On receiving a setup packet, the OTG_HS closes the buffer and disables the corresponding endpoint after SETUP_COMPLETE status is seen in the Rx FIFO. OTG_HS puts a SETUP_COMPLETE status into the Rx FIFO when it sees the first IN or OUT token after the SETUP packet for that particular endpoint. The application must then re-enable the endpoint to receive any OUT data for the control transfer and reprogram the buffer start address. Because of the above behavior, OTG_HS can receive any number of back to back setup packets and one buffer for every setup packet is used.


\
\ @brief OTG device OUT endpoint 0 transfer size register
\ Address offset: 0xB10
\ Reset value: 0x00000000
\

$0000007f constant OTG_FS_OTG_DOEPTSIZ0_XFRSIZ                      \ Transfer size Indicates the transfer size in bytes for endpoint 0. The core interrupts the application only after it has exhausted the transfer size amount of data. The transfer size can be set to the maximum packet size of the endpoint, to be interrupted at the end of each packet. The core decrements this field every time a packet is read from the Rx FIFO and written to the external memory.
$00080000 constant OTG_FS_OTG_DOEPTSIZ0_PKTCNT                      \ Packet count This field is decremented to zero after a packet is written into the Rx FIFO.
$60000000 constant OTG_FS_OTG_DOEPTSIZ0_STUPCNT                     \ SETUP packet count This field specifies the number of back-to-back SETUP data packets the endpoint can receive.


\
\ @brief OTG device OUT endpoint 0 DMA address register
\ Address offset: 0xB14
\ Reset value: 0x00000000
\

$00000000 constant OTG_FS_OTG_DOEPDMA0_DMAADDR                      \ DMA Address This field holds the start address in the external memory from which the data for the endpoint must be fetched. This register is incremented on every AHB transaction.


\
\ @brief OTG device OUT endpoint 1 control register
\ Address offset: 0xB20
\ Reset value: 0x00000000
\

$000007ff constant OTG_FS_OTG_DOEPCTL1_INT_BULK_MPSIZ               \ Maximum packet size The application must program this field with the maximum packet size for the current logical endpoint. This value is in bytes.
$00008000 constant OTG_FS_OTG_DOEPCTL1_INT_BULK_USBAEP              \ USB active endpoint Indicates whether this endpoint is active in the current configuration and interface. The core clears this bit for all endpoints (other than EP 0) after detecting a USB reset. After receiving the SetConfiguration and SetInterface commands, the application must program endpoint registers accordingly and set this bit.
$00010000 constant OTG_FS_OTG_DOEPCTL1_INT_BULK_DPID                \ Endpoint data PID Applies to interrupt/bulk OUT endpoints only. Contains the PID of the packet to be received or transmitted on this endpoint. The application must program the PID of the first packet to be received or transmitted on this endpoint, after the endpoint is activated. The application uses the SD0PID and SD1PID register fields to program either DATA0 or DATA1 PID.
$00020000 constant OTG_FS_OTG_DOEPCTL1_INT_BULK_NAKSTS              \ NAK status Indicates the following: When either the application or the core sets this bit: The core stops receiving any data on an OUT endpoint, even if there is space in the Rx FIFO to accommodate the incoming packet. Irrespective of this bits setting, the core always responds to SETUP data packets with an ACK handshake.
$000c0000 constant OTG_FS_OTG_DOEPCTL1_INT_BULK_EPTYP               \ Endpoint type This is the transfer type supported by this logical endpoint.
$00100000 constant OTG_FS_OTG_DOEPCTL1_INT_BULK_SNPM                \ Snoop mode This bit configures the endpoint to Snoop mode. In Snoop mode, the core does not check the correctness of OUT packets before transferring them to application memory.
$00200000 constant OTG_FS_OTG_DOEPCTL1_INT_BULK_STALL               \ STALL handshake Applies to non-control, non-isochronous OUT endpoints only (access type is rw). The application sets this bit to stall all tokens from the USB host to this endpoint. If a NAK bit, Global IN NAK, or Global OUT NAK is set along with this bit, the STALL bit takes priority. Only the application can clear this bit, never the core. Applies to control endpoints only (access type is rs). The application can only set this bit, and the core clears it, when a SETUP token is received for this endpoint. If a NAK bit, Global IN NAK, or Global OUT NAK is set along with this bit, the STALL bit takes priority. Irrespective of this bits setting, the core always responds to SETUP data packets with an ACK handshake.
$04000000 constant OTG_FS_OTG_DOEPCTL1_INT_BULK_CNAK                \ Clear NAK A write to this bit clears the NAK bit for the endpoint.
$08000000 constant OTG_FS_OTG_DOEPCTL1_INT_BULK_SNAK                \ Set NAK A write to this bit sets the NAK bit for the endpoint. Using this bit, the application can control the transmission of NAK handshakes on an endpoint. The core can also set this bit for OUT endpoints on a transfer completed interrupt, or after a SETUP is received on the endpoint.
$10000000 constant OTG_FS_OTG_DOEPCTL1_INT_BULK_SD0PID              \ Set DATA0 PID Applies to interrupt/bulk OUT endpoints only. Writing to this field sets the endpoint data PID (DPID) field in this register to DATA0.
$20000000 constant OTG_FS_OTG_DOEPCTL1_INT_BULK_SD1PID              \ Set DATA1 PID Writing to this field sets the endpoint data PID (DPID) field in this register to DATA1.
$40000000 constant OTG_FS_OTG_DOEPCTL1_INT_BULK_EPDIS               \ Endpoint disable The application sets this bit to stop transmitting/receiving data on an endpoint, even before the transfer for that endpoint is complete. The application must wait for the endpoint disabled interrupt before treating the endpoint as disabled. The core clears this bit before setting the endpoint disabled interrupt. The application must set this bit only if endpoint enable is already set for this endpoint.
$80000000 constant OTG_FS_OTG_DOEPCTL1_INT_BULK_EPENA               \ Endpoint enable Applies to IN and OUT endpoints. The application sets this bit to start transmitting data on an endpoint. The core clears this bit before setting any of the following interrupts on this endpoint: SETUP phase done Endpoint disabled Transfer completed


\
\ @brief OTG device OUT endpoint 1 control register
\ Address offset: 0xB20
\ Reset value: 0x00000000
\

$000007ff constant OTG_FS_OTG_DOEPCTL1_ISO_MPSIZ                    \ Maximum packet size The application must program this field with the maximum packet size for the current logical endpoint. This value is in bytes.
$00008000 constant OTG_FS_OTG_DOEPCTL1_ISO_USBAEP                   \ USB active endpoint Indicates whether this endpoint is active in the current configuration and interface. The core clears this bit for all endpoints (other than EP 0) after detecting a USB reset. After receiving the SetConfiguration and SetInterface commands, the application must program endpoint registers accordingly and set this bit.
$00010000 constant OTG_FS_OTG_DOEPCTL1_ISO_EONUM                    \ Even/odd frame Applies to isochronous OUT endpoints only. Indicates the frame number in which the core transmits/receives isochronous data for this endpoint. The application must program the even/odd frame number in which it intends to transmit/receive isochronous data for this endpoint using the SEVNFRM and SODDFRM fields in this register.
$00020000 constant OTG_FS_OTG_DOEPCTL1_ISO_NAKSTS                   \ NAK status Indicates the following: When either the application or the core sets this bit: The core stops receiving any data on an OUT endpoint, even if there is space in the Rx FIFO to accommodate the incoming packet. Irrespective of this bits setting, the core always responds to SETUP data packets with an ACK handshake.
$000c0000 constant OTG_FS_OTG_DOEPCTL1_ISO_EPTYP                    \ Endpoint type This is the transfer type supported by this logical endpoint.
$00100000 constant OTG_FS_OTG_DOEPCTL1_ISO_SNPM                     \ Snoop mode This bit configures the endpoint to Snoop mode. In Snoop mode, the core does not check the correctness of OUT packets before transferring them to application memory.
$00200000 constant OTG_FS_OTG_DOEPCTL1_ISO_STALL                    \ STALL handshake Applies to non-control, non-isochronous OUT endpoints only (access type is rw). The application sets this bit to stall all tokens from the USB host to this endpoint. If a NAK bit, Global IN NAK, or Global OUT NAK is set along with this bit, the STALL bit takes priority. Only the application can clear this bit, never the core. Applies to control endpoints only (access type is rs). The application can only set this bit, and the core clears it, when a SETUP token is received for this endpoint. If a NAK bit, Global IN NAK, or Global OUT NAK is set along with this bit, the STALL bit takes priority. Irrespective of this bits setting, the core always responds to SETUP data packets with an ACK handshake.
$04000000 constant OTG_FS_OTG_DOEPCTL1_ISO_CNAK                     \ Clear NAK A write to this bit clears the NAK bit for the endpoint.
$08000000 constant OTG_FS_OTG_DOEPCTL1_ISO_SNAK                     \ Set NAK A write to this bit sets the NAK bit for the endpoint. Using this bit, the application can control the transmission of NAK handshakes on an endpoint. The core can also set this bit for OUT endpoints on a transfer completed interrupt, or after a SETUP is received on the endpoint.
$10000000 constant OTG_FS_OTG_DOEPCTL1_ISO_SEVNFRM                  \ Set even frame Applies to isochronous OUT endpoints only. Writing to this field sets the Even/Odd frame (EONUM) field to even frame.
$20000000 constant OTG_FS_OTG_DOEPCTL1_ISO_SODDFRM                  \ Set odd frame Applies to isochronous IN and OUT endpoints only. Writing to this field sets the Even/Odd frame (EONUM) field to odd frame.
$40000000 constant OTG_FS_OTG_DOEPCTL1_ISO_EPDIS                    \ Endpoint disable The application sets this bit to stop transmitting/receiving data on an endpoint, even before the transfer for that endpoint is complete. The application must wait for the endpoint disabled interrupt before treating the endpoint as disabled. The core clears this bit before setting the endpoint disabled interrupt. The application must set this bit only if endpoint enable is already set for this endpoint.
$80000000 constant OTG_FS_OTG_DOEPCTL1_ISO_EPENA                    \ Endpoint enable Applies to IN and OUT endpoints. The application sets this bit to start transmitting data on an endpoint. The core clears this bit before setting any of the following interrupts on this endpoint: SETUP phase done Endpoint disabled Transfer completed


\
\ @brief OTG device OUT endpoint 1 interrupt register
\ Address offset: 0xB28
\ Reset value: 0x00000080
\

$00000001 constant OTG_FS_OTG_DOEPINT1_XFRC                         \ Transfer completed interrupt This field indicates that the programmed transfer is complete on the AHB as well as on the USB, for this endpoint.
$00000002 constant OTG_FS_OTG_DOEPINT1_EPDISD                       \ Endpoint disabled interrupt This bit indicates that the endpoint is disabled per the applications request.
$00000004 constant OTG_FS_OTG_DOEPINT1_AHBERR                       \ AHB error This is generated only in internal DMA mode when there is an AHB error during an AHB read/write. The application can read the corresponding endpoint DMA address register to get the error address.
$00000008 constant OTG_FS_OTG_DOEPINT1_STUP                         \ SETUP phase done Applies to control OUT endpoint only.Indicates that the SETUP phase for the control endpoint is complete and no more back-to-back SETUP packets were received for the current control transfer. On this interrupt, the application can decode the received SETUP data packet.
$00000010 constant OTG_FS_OTG_DOEPINT1_OTEPDIS                      \ OUT token received when endpoint disabled Applies only to control OUT endpoints. Indicates that an OUT token was received when the endpoint was not yet enabled. This interrupt is asserted on the endpoint for which the OUT token was received.
$00000020 constant OTG_FS_OTG_DOEPINT1_STSPHSRX                     \ Status phase received for control write This interrupt is valid only for control OUT endpoints. This interrupt is generated only after OTG_HS has transferred all the data that the host has sent during the data phase of a control write transfer, to the system memory buffer. The interrupt indicates to the application that the host has switched from data phase to the status phase of a control write transfer. The application can use this interrupt to ACK or STALL the status phase, after it has decoded the data phase.
$00000040 constant OTG_FS_OTG_DOEPINT1_B2BSTUP                      \ Back-to-back SETUP packets received Applies to control OUT endpoint only. This bit indicates that the core has received more than three back-to-back SETUP packets for this particular endpoint.
$00000100 constant OTG_FS_OTG_DOEPINT1_OUTPKTERR                    \ OUT packet error This interrupt is asserted when the core detects an overflow or a CRC error for an OUT packet. This interrupt is valid only when thresholding is enabled.
$00001000 constant OTG_FS_OTG_DOEPINT1_BERR                         \ Babble error interrupt The core generates this interrupt when babble is received for the endpoint.
$00002000 constant OTG_FS_OTG_DOEPINT1_NAK                          \ NAK input The core generates this interrupt when a NAK is transmitted or received by the device. In case of isochronous IN endpoints the interrupt gets generated when a zero length packet is transmitted due to unavailability of data in the Tx FIFO.
$00004000 constant OTG_FS_OTG_DOEPINT1_NYET                         \ NYET interrupt This interrupt is generated when a NYET response is transmitted for a non isochronous OUT endpoint.
$00008000 constant OTG_FS_OTG_DOEPINT1_STPKTRX                      \ Setup packet received Applicable for control OUT endpoints in only in the Buffer DMA Mode. Set by the OTG_HS, this bit indicates that this buffer holds 8 bytes of setup data. There is only one setup packet per buffer. On receiving a setup packet, the OTG_HS closes the buffer and disables the corresponding endpoint after SETUP_COMPLETE status is seen in the Rx FIFO. OTG_HS puts a SETUP_COMPLETE status into the Rx FIFO when it sees the first IN or OUT token after the SETUP packet for that particular endpoint. The application must then re-enable the endpoint to receive any OUT data for the control transfer and reprogram the buffer start address. Because of the above behavior, OTG_HS can receive any number of back to back setup packets and one buffer for every setup packet is used.


\
\ @brief OTG device OUT endpoint 1 transfer size register
\ Address offset: 0xB30
\ Reset value: 0x00000000
\

$0007ffff constant OTG_FS_OTG_DOEPTSIZ1_XFRSIZ                      \ Transfer size This field contains the transfer size in bytes for the current endpoint. The core only interrupts the application after it has exhausted the transfer size amount of data. The transfer size can be set to the maximum packet size of the endpoint, to be interrupted at the end of each packet. The core decrements this field every time a packet is read from the Rx FIFO and written to the external memory.
$1ff80000 constant OTG_FS_OTG_DOEPTSIZ1_PKTCNT                      \ Packet count Indicates the total number of USB packets that constitute the transfer size amount of data for this endpoint. This field is decremented every time a packet (maximum size or short packet) is written to the Rx FIFO.
$60000000 constant OTG_FS_OTG_DOEPTSIZ1_RXDPID                      \ Received data PID This is the data PID received in the last packet for this endpoint. STUPCNT[1:0]: SETUP packet count This field specifies the number of back-to-back SETUP data packets the endpoint can receive.


\
\ @brief OTG device OUT endpoint 1 DMA address register
\ Address offset: 0xB34
\ Reset value: 0x00000000
\

$00000000 constant OTG_FS_OTG_DOEPDMA1_DMAADDR                      \ DMA Address This field holds the start address in the external memory from which the data for the endpoint must be fetched. This register is incremented on every AHB transaction.


\
\ @brief OTG device OUT endpoint 2 control register
\ Address offset: 0xB40
\ Reset value: 0x00000000
\

$000007ff constant OTG_FS_OTG_DOEPCTL2_INT_BULK_MPSIZ               \ Maximum packet size The application must program this field with the maximum packet size for the current logical endpoint. This value is in bytes.
$00008000 constant OTG_FS_OTG_DOEPCTL2_INT_BULK_USBAEP              \ USB active endpoint Indicates whether this endpoint is active in the current configuration and interface. The core clears this bit for all endpoints (other than EP 0) after detecting a USB reset. After receiving the SetConfiguration and SetInterface commands, the application must program endpoint registers accordingly and set this bit.
$00010000 constant OTG_FS_OTG_DOEPCTL2_INT_BULK_DPID                \ Endpoint data PID Applies to interrupt/bulk OUT endpoints only. Contains the PID of the packet to be received or transmitted on this endpoint. The application must program the PID of the first packet to be received or transmitted on this endpoint, after the endpoint is activated. The application uses the SD0PID and SD1PID register fields to program either DATA0 or DATA1 PID.
$00020000 constant OTG_FS_OTG_DOEPCTL2_INT_BULK_NAKSTS              \ NAK status Indicates the following: When either the application or the core sets this bit: The core stops receiving any data on an OUT endpoint, even if there is space in the Rx FIFO to accommodate the incoming packet. Irrespective of this bits setting, the core always responds to SETUP data packets with an ACK handshake.
$000c0000 constant OTG_FS_OTG_DOEPCTL2_INT_BULK_EPTYP               \ Endpoint type This is the transfer type supported by this logical endpoint.
$00100000 constant OTG_FS_OTG_DOEPCTL2_INT_BULK_SNPM                \ Snoop mode This bit configures the endpoint to Snoop mode. In Snoop mode, the core does not check the correctness of OUT packets before transferring them to application memory.
$00200000 constant OTG_FS_OTG_DOEPCTL2_INT_BULK_STALL               \ STALL handshake Applies to non-control, non-isochronous OUT endpoints only (access type is rw). The application sets this bit to stall all tokens from the USB host to this endpoint. If a NAK bit, Global IN NAK, or Global OUT NAK is set along with this bit, the STALL bit takes priority. Only the application can clear this bit, never the core. Applies to control endpoints only (access type is rs). The application can only set this bit, and the core clears it, when a SETUP token is received for this endpoint. If a NAK bit, Global IN NAK, or Global OUT NAK is set along with this bit, the STALL bit takes priority. Irrespective of this bits setting, the core always responds to SETUP data packets with an ACK handshake.
$04000000 constant OTG_FS_OTG_DOEPCTL2_INT_BULK_CNAK                \ Clear NAK A write to this bit clears the NAK bit for the endpoint.
$08000000 constant OTG_FS_OTG_DOEPCTL2_INT_BULK_SNAK                \ Set NAK A write to this bit sets the NAK bit for the endpoint. Using this bit, the application can control the transmission of NAK handshakes on an endpoint. The core can also set this bit for OUT endpoints on a transfer completed interrupt, or after a SETUP is received on the endpoint.
$10000000 constant OTG_FS_OTG_DOEPCTL2_INT_BULK_SD0PID              \ Set DATA0 PID Applies to interrupt/bulk OUT endpoints only. Writing to this field sets the endpoint data PID (DPID) field in this register to DATA0.
$20000000 constant OTG_FS_OTG_DOEPCTL2_INT_BULK_SD1PID              \ Set DATA1 PID Writing to this field sets the endpoint data PID (DPID) field in this register to DATA1.
$40000000 constant OTG_FS_OTG_DOEPCTL2_INT_BULK_EPDIS               \ Endpoint disable The application sets this bit to stop transmitting/receiving data on an endpoint, even before the transfer for that endpoint is complete. The application must wait for the endpoint disabled interrupt before treating the endpoint as disabled. The core clears this bit before setting the endpoint disabled interrupt. The application must set this bit only if endpoint enable is already set for this endpoint.
$80000000 constant OTG_FS_OTG_DOEPCTL2_INT_BULK_EPENA               \ Endpoint enable Applies to IN and OUT endpoints. The application sets this bit to start transmitting data on an endpoint. The core clears this bit before setting any of the following interrupts on this endpoint: SETUP phase done Endpoint disabled Transfer completed


\
\ @brief OTG device OUT endpoint 2 control register
\ Address offset: 0xB40
\ Reset value: 0x00000000
\

$000007ff constant OTG_FS_OTG_DOEPCTL2_ISO_MPSIZ                    \ Maximum packet size The application must program this field with the maximum packet size for the current logical endpoint. This value is in bytes.
$00008000 constant OTG_FS_OTG_DOEPCTL2_ISO_USBAEP                   \ USB active endpoint Indicates whether this endpoint is active in the current configuration and interface. The core clears this bit for all endpoints (other than EP 0) after detecting a USB reset. After receiving the SetConfiguration and SetInterface commands, the application must program endpoint registers accordingly and set this bit.
$00010000 constant OTG_FS_OTG_DOEPCTL2_ISO_EONUM                    \ Even/odd frame Applies to isochronous OUT endpoints only. Indicates the frame number in which the core transmits/receives isochronous data for this endpoint. The application must program the even/odd frame number in which it intends to transmit/receive isochronous data for this endpoint using the SEVNFRM and SODDFRM fields in this register.
$00020000 constant OTG_FS_OTG_DOEPCTL2_ISO_NAKSTS                   \ NAK status Indicates the following: When either the application or the core sets this bit: The core stops receiving any data on an OUT endpoint, even if there is space in the Rx FIFO to accommodate the incoming packet. Irrespective of this bits setting, the core always responds to SETUP data packets with an ACK handshake.
$000c0000 constant OTG_FS_OTG_DOEPCTL2_ISO_EPTYP                    \ Endpoint type This is the transfer type supported by this logical endpoint.
$00100000 constant OTG_FS_OTG_DOEPCTL2_ISO_SNPM                     \ Snoop mode This bit configures the endpoint to Snoop mode. In Snoop mode, the core does not check the correctness of OUT packets before transferring them to application memory.
$00200000 constant OTG_FS_OTG_DOEPCTL2_ISO_STALL                    \ STALL handshake Applies to non-control, non-isochronous OUT endpoints only (access type is rw). The application sets this bit to stall all tokens from the USB host to this endpoint. If a NAK bit, Global IN NAK, or Global OUT NAK is set along with this bit, the STALL bit takes priority. Only the application can clear this bit, never the core. Applies to control endpoints only (access type is rs). The application can only set this bit, and the core clears it, when a SETUP token is received for this endpoint. If a NAK bit, Global IN NAK, or Global OUT NAK is set along with this bit, the STALL bit takes priority. Irrespective of this bits setting, the core always responds to SETUP data packets with an ACK handshake.
$04000000 constant OTG_FS_OTG_DOEPCTL2_ISO_CNAK                     \ Clear NAK A write to this bit clears the NAK bit for the endpoint.
$08000000 constant OTG_FS_OTG_DOEPCTL2_ISO_SNAK                     \ Set NAK A write to this bit sets the NAK bit for the endpoint. Using this bit, the application can control the transmission of NAK handshakes on an endpoint. The core can also set this bit for OUT endpoints on a transfer completed interrupt, or after a SETUP is received on the endpoint.
$10000000 constant OTG_FS_OTG_DOEPCTL2_ISO_SEVNFRM                  \ Set even frame Applies to isochronous OUT endpoints only. Writing to this field sets the Even/Odd frame (EONUM) field to even frame.
$20000000 constant OTG_FS_OTG_DOEPCTL2_ISO_SODDFRM                  \ Set odd frame Applies to isochronous IN and OUT endpoints only. Writing to this field sets the Even/Odd frame (EONUM) field to odd frame.
$40000000 constant OTG_FS_OTG_DOEPCTL2_ISO_EPDIS                    \ Endpoint disable The application sets this bit to stop transmitting/receiving data on an endpoint, even before the transfer for that endpoint is complete. The application must wait for the endpoint disabled interrupt before treating the endpoint as disabled. The core clears this bit before setting the endpoint disabled interrupt. The application must set this bit only if endpoint enable is already set for this endpoint.
$80000000 constant OTG_FS_OTG_DOEPCTL2_ISO_EPENA                    \ Endpoint enable Applies to IN and OUT endpoints. The application sets this bit to start transmitting data on an endpoint. The core clears this bit before setting any of the following interrupts on this endpoint: SETUP phase done Endpoint disabled Transfer completed


\
\ @brief OTG device OUT endpoint 2 interrupt register
\ Address offset: 0xB48
\ Reset value: 0x00000080
\

$00000001 constant OTG_FS_OTG_DOEPINT2_XFRC                         \ Transfer completed interrupt This field indicates that the programmed transfer is complete on the AHB as well as on the USB, for this endpoint.
$00000002 constant OTG_FS_OTG_DOEPINT2_EPDISD                       \ Endpoint disabled interrupt This bit indicates that the endpoint is disabled per the applications request.
$00000004 constant OTG_FS_OTG_DOEPINT2_AHBERR                       \ AHB error This is generated only in internal DMA mode when there is an AHB error during an AHB read/write. The application can read the corresponding endpoint DMA address register to get the error address.
$00000008 constant OTG_FS_OTG_DOEPINT2_STUP                         \ SETUP phase done Applies to control OUT endpoint only.Indicates that the SETUP phase for the control endpoint is complete and no more back-to-back SETUP packets were received for the current control transfer. On this interrupt, the application can decode the received SETUP data packet.
$00000010 constant OTG_FS_OTG_DOEPINT2_OTEPDIS                      \ OUT token received when endpoint disabled Applies only to control OUT endpoints. Indicates that an OUT token was received when the endpoint was not yet enabled. This interrupt is asserted on the endpoint for which the OUT token was received.
$00000020 constant OTG_FS_OTG_DOEPINT2_STSPHSRX                     \ Status phase received for control write This interrupt is valid only for control OUT endpoints. This interrupt is generated only after OTG_HS has transferred all the data that the host has sent during the data phase of a control write transfer, to the system memory buffer. The interrupt indicates to the application that the host has switched from data phase to the status phase of a control write transfer. The application can use this interrupt to ACK or STALL the status phase, after it has decoded the data phase.
$00000040 constant OTG_FS_OTG_DOEPINT2_B2BSTUP                      \ Back-to-back SETUP packets received Applies to control OUT endpoint only. This bit indicates that the core has received more than three back-to-back SETUP packets for this particular endpoint.
$00000100 constant OTG_FS_OTG_DOEPINT2_OUTPKTERR                    \ OUT packet error This interrupt is asserted when the core detects an overflow or a CRC error for an OUT packet. This interrupt is valid only when thresholding is enabled.
$00001000 constant OTG_FS_OTG_DOEPINT2_BERR                         \ Babble error interrupt The core generates this interrupt when babble is received for the endpoint.
$00002000 constant OTG_FS_OTG_DOEPINT2_NAK                          \ NAK input The core generates this interrupt when a NAK is transmitted or received by the device. In case of isochronous IN endpoints the interrupt gets generated when a zero length packet is transmitted due to unavailability of data in the Tx FIFO.
$00004000 constant OTG_FS_OTG_DOEPINT2_NYET                         \ NYET interrupt This interrupt is generated when a NYET response is transmitted for a non isochronous OUT endpoint.
$00008000 constant OTG_FS_OTG_DOEPINT2_STPKTRX                      \ Setup packet received Applicable for control OUT endpoints in only in the Buffer DMA Mode. Set by the OTG_HS, this bit indicates that this buffer holds 8 bytes of setup data. There is only one setup packet per buffer. On receiving a setup packet, the OTG_HS closes the buffer and disables the corresponding endpoint after SETUP_COMPLETE status is seen in the Rx FIFO. OTG_HS puts a SETUP_COMPLETE status into the Rx FIFO when it sees the first IN or OUT token after the SETUP packet for that particular endpoint. The application must then re-enable the endpoint to receive any OUT data for the control transfer and reprogram the buffer start address. Because of the above behavior, OTG_HS can receive any number of back to back setup packets and one buffer for every setup packet is used.


\
\ @brief OTG device OUT endpoint 2 transfer size register
\ Address offset: 0xB50
\ Reset value: 0x00000000
\

$0007ffff constant OTG_FS_OTG_DOEPTSIZ2_XFRSIZ                      \ Transfer size This field contains the transfer size in bytes for the current endpoint. The core only interrupts the application after it has exhausted the transfer size amount of data. The transfer size can be set to the maximum packet size of the endpoint, to be interrupted at the end of each packet. The core decrements this field every time a packet is read from the Rx FIFO and written to the external memory.
$1ff80000 constant OTG_FS_OTG_DOEPTSIZ2_PKTCNT                      \ Packet count Indicates the total number of USB packets that constitute the transfer size amount of data for this endpoint. This field is decremented every time a packet (maximum size or short packet) is written to the Rx FIFO.
$60000000 constant OTG_FS_OTG_DOEPTSIZ2_RXDPID                      \ Received data PID This is the data PID received in the last packet for this endpoint. STUPCNT[1:0]: SETUP packet count This field specifies the number of back-to-back SETUP data packets the endpoint can receive.


\
\ @brief OTG device OUT endpoint 2 DMA address register
\ Address offset: 0xB54
\ Reset value: 0x00000000
\

$00000000 constant OTG_FS_OTG_DOEPDMA2_DMAADDR                      \ DMA Address This field holds the start address in the external memory from which the data for the endpoint must be fetched. This register is incremented on every AHB transaction.


\
\ @brief OTG device OUT endpoint 3 control register
\ Address offset: 0xB60
\ Reset value: 0x00000000
\

$000007ff constant OTG_FS_OTG_DOEPCTL3_INT_BULK_MPSIZ               \ Maximum packet size The application must program this field with the maximum packet size for the current logical endpoint. This value is in bytes.
$00008000 constant OTG_FS_OTG_DOEPCTL3_INT_BULK_USBAEP              \ USB active endpoint Indicates whether this endpoint is active in the current configuration and interface. The core clears this bit for all endpoints (other than EP 0) after detecting a USB reset. After receiving the SetConfiguration and SetInterface commands, the application must program endpoint registers accordingly and set this bit.
$00010000 constant OTG_FS_OTG_DOEPCTL3_INT_BULK_DPID                \ Endpoint data PID Applies to interrupt/bulk OUT endpoints only. Contains the PID of the packet to be received or transmitted on this endpoint. The application must program the PID of the first packet to be received or transmitted on this endpoint, after the endpoint is activated. The application uses the SD0PID and SD1PID register fields to program either DATA0 or DATA1 PID.
$00020000 constant OTG_FS_OTG_DOEPCTL3_INT_BULK_NAKSTS              \ NAK status Indicates the following: When either the application or the core sets this bit: The core stops receiving any data on an OUT endpoint, even if there is space in the Rx FIFO to accommodate the incoming packet. Irrespective of this bits setting, the core always responds to SETUP data packets with an ACK handshake.
$000c0000 constant OTG_FS_OTG_DOEPCTL3_INT_BULK_EPTYP               \ Endpoint type This is the transfer type supported by this logical endpoint.
$00100000 constant OTG_FS_OTG_DOEPCTL3_INT_BULK_SNPM                \ Snoop mode This bit configures the endpoint to Snoop mode. In Snoop mode, the core does not check the correctness of OUT packets before transferring them to application memory.
$00200000 constant OTG_FS_OTG_DOEPCTL3_INT_BULK_STALL               \ STALL handshake Applies to non-control, non-isochronous OUT endpoints only (access type is rw). The application sets this bit to stall all tokens from the USB host to this endpoint. If a NAK bit, Global IN NAK, or Global OUT NAK is set along with this bit, the STALL bit takes priority. Only the application can clear this bit, never the core. Applies to control endpoints only (access type is rs). The application can only set this bit, and the core clears it, when a SETUP token is received for this endpoint. If a NAK bit, Global IN NAK, or Global OUT NAK is set along with this bit, the STALL bit takes priority. Irrespective of this bits setting, the core always responds to SETUP data packets with an ACK handshake.
$04000000 constant OTG_FS_OTG_DOEPCTL3_INT_BULK_CNAK                \ Clear NAK A write to this bit clears the NAK bit for the endpoint.
$08000000 constant OTG_FS_OTG_DOEPCTL3_INT_BULK_SNAK                \ Set NAK A write to this bit sets the NAK bit for the endpoint. Using this bit, the application can control the transmission of NAK handshakes on an endpoint. The core can also set this bit for OUT endpoints on a transfer completed interrupt, or after a SETUP is received on the endpoint.
$10000000 constant OTG_FS_OTG_DOEPCTL3_INT_BULK_SD0PID              \ Set DATA0 PID Applies to interrupt/bulk OUT endpoints only. Writing to this field sets the endpoint data PID (DPID) field in this register to DATA0.
$20000000 constant OTG_FS_OTG_DOEPCTL3_INT_BULK_SD1PID              \ Set DATA1 PID Writing to this field sets the endpoint data PID (DPID) field in this register to DATA1.
$40000000 constant OTG_FS_OTG_DOEPCTL3_INT_BULK_EPDIS               \ Endpoint disable The application sets this bit to stop transmitting/receiving data on an endpoint, even before the transfer for that endpoint is complete. The application must wait for the endpoint disabled interrupt before treating the endpoint as disabled. The core clears this bit before setting the endpoint disabled interrupt. The application must set this bit only if endpoint enable is already set for this endpoint.
$80000000 constant OTG_FS_OTG_DOEPCTL3_INT_BULK_EPENA               \ Endpoint enable Applies to IN and OUT endpoints. The application sets this bit to start transmitting data on an endpoint. The core clears this bit before setting any of the following interrupts on this endpoint: SETUP phase done Endpoint disabled Transfer completed


\
\ @brief OTG device OUT endpoint 3 control register
\ Address offset: 0xB60
\ Reset value: 0x00000000
\

$000007ff constant OTG_FS_OTG_DOEPCTL3_ISO_MPSIZ                    \ Maximum packet size The application must program this field with the maximum packet size for the current logical endpoint. This value is in bytes.
$00008000 constant OTG_FS_OTG_DOEPCTL3_ISO_USBAEP                   \ USB active endpoint Indicates whether this endpoint is active in the current configuration and interface. The core clears this bit for all endpoints (other than EP 0) after detecting a USB reset. After receiving the SetConfiguration and SetInterface commands, the application must program endpoint registers accordingly and set this bit.
$00010000 constant OTG_FS_OTG_DOEPCTL3_ISO_EONUM                    \ Even/odd frame Applies to isochronous OUT endpoints only. Indicates the frame number in which the core transmits/receives isochronous data for this endpoint. The application must program the even/odd frame number in which it intends to transmit/receive isochronous data for this endpoint using the SEVNFRM and SODDFRM fields in this register.
$00020000 constant OTG_FS_OTG_DOEPCTL3_ISO_NAKSTS                   \ NAK status Indicates the following: When either the application or the core sets this bit: The core stops receiving any data on an OUT endpoint, even if there is space in the Rx FIFO to accommodate the incoming packet. Irrespective of this bits setting, the core always responds to SETUP data packets with an ACK handshake.
$000c0000 constant OTG_FS_OTG_DOEPCTL3_ISO_EPTYP                    \ Endpoint type This is the transfer type supported by this logical endpoint.
$00100000 constant OTG_FS_OTG_DOEPCTL3_ISO_SNPM                     \ Snoop mode This bit configures the endpoint to Snoop mode. In Snoop mode, the core does not check the correctness of OUT packets before transferring them to application memory.
$00200000 constant OTG_FS_OTG_DOEPCTL3_ISO_STALL                    \ STALL handshake Applies to non-control, non-isochronous OUT endpoints only (access type is rw). The application sets this bit to stall all tokens from the USB host to this endpoint. If a NAK bit, Global IN NAK, or Global OUT NAK is set along with this bit, the STALL bit takes priority. Only the application can clear this bit, never the core. Applies to control endpoints only (access type is rs). The application can only set this bit, and the core clears it, when a SETUP token is received for this endpoint. If a NAK bit, Global IN NAK, or Global OUT NAK is set along with this bit, the STALL bit takes priority. Irrespective of this bits setting, the core always responds to SETUP data packets with an ACK handshake.
$04000000 constant OTG_FS_OTG_DOEPCTL3_ISO_CNAK                     \ Clear NAK A write to this bit clears the NAK bit for the endpoint.
$08000000 constant OTG_FS_OTG_DOEPCTL3_ISO_SNAK                     \ Set NAK A write to this bit sets the NAK bit for the endpoint. Using this bit, the application can control the transmission of NAK handshakes on an endpoint. The core can also set this bit for OUT endpoints on a transfer completed interrupt, or after a SETUP is received on the endpoint.
$10000000 constant OTG_FS_OTG_DOEPCTL3_ISO_SEVNFRM                  \ Set even frame Applies to isochronous OUT endpoints only. Writing to this field sets the Even/Odd frame (EONUM) field to even frame.
$20000000 constant OTG_FS_OTG_DOEPCTL3_ISO_SODDFRM                  \ Set odd frame Applies to isochronous IN and OUT endpoints only. Writing to this field sets the Even/Odd frame (EONUM) field to odd frame.
$40000000 constant OTG_FS_OTG_DOEPCTL3_ISO_EPDIS                    \ Endpoint disable The application sets this bit to stop transmitting/receiving data on an endpoint, even before the transfer for that endpoint is complete. The application must wait for the endpoint disabled interrupt before treating the endpoint as disabled. The core clears this bit before setting the endpoint disabled interrupt. The application must set this bit only if endpoint enable is already set for this endpoint.
$80000000 constant OTG_FS_OTG_DOEPCTL3_ISO_EPENA                    \ Endpoint enable Applies to IN and OUT endpoints. The application sets this bit to start transmitting data on an endpoint. The core clears this bit before setting any of the following interrupts on this endpoint: SETUP phase done Endpoint disabled Transfer completed


\
\ @brief OTG device OUT endpoint 3 interrupt register
\ Address offset: 0xB68
\ Reset value: 0x00000080
\

$00000001 constant OTG_FS_OTG_DOEPINT3_XFRC                         \ Transfer completed interrupt This field indicates that the programmed transfer is complete on the AHB as well as on the USB, for this endpoint.
$00000002 constant OTG_FS_OTG_DOEPINT3_EPDISD                       \ Endpoint disabled interrupt This bit indicates that the endpoint is disabled per the applications request.
$00000004 constant OTG_FS_OTG_DOEPINT3_AHBERR                       \ AHB error This is generated only in internal DMA mode when there is an AHB error during an AHB read/write. The application can read the corresponding endpoint DMA address register to get the error address.
$00000008 constant OTG_FS_OTG_DOEPINT3_STUP                         \ SETUP phase done Applies to control OUT endpoint only.Indicates that the SETUP phase for the control endpoint is complete and no more back-to-back SETUP packets were received for the current control transfer. On this interrupt, the application can decode the received SETUP data packet.
$00000010 constant OTG_FS_OTG_DOEPINT3_OTEPDIS                      \ OUT token received when endpoint disabled Applies only to control OUT endpoints. Indicates that an OUT token was received when the endpoint was not yet enabled. This interrupt is asserted on the endpoint for which the OUT token was received.
$00000020 constant OTG_FS_OTG_DOEPINT3_STSPHSRX                     \ Status phase received for control write This interrupt is valid only for control OUT endpoints. This interrupt is generated only after OTG_HS has transferred all the data that the host has sent during the data phase of a control write transfer, to the system memory buffer. The interrupt indicates to the application that the host has switched from data phase to the status phase of a control write transfer. The application can use this interrupt to ACK or STALL the status phase, after it has decoded the data phase.
$00000040 constant OTG_FS_OTG_DOEPINT3_B2BSTUP                      \ Back-to-back SETUP packets received Applies to control OUT endpoint only. This bit indicates that the core has received more than three back-to-back SETUP packets for this particular endpoint.
$00000100 constant OTG_FS_OTG_DOEPINT3_OUTPKTERR                    \ OUT packet error This interrupt is asserted when the core detects an overflow or a CRC error for an OUT packet. This interrupt is valid only when thresholding is enabled.
$00001000 constant OTG_FS_OTG_DOEPINT3_BERR                         \ Babble error interrupt The core generates this interrupt when babble is received for the endpoint.
$00002000 constant OTG_FS_OTG_DOEPINT3_NAK                          \ NAK input The core generates this interrupt when a NAK is transmitted or received by the device. In case of isochronous IN endpoints the interrupt gets generated when a zero length packet is transmitted due to unavailability of data in the Tx FIFO.
$00004000 constant OTG_FS_OTG_DOEPINT3_NYET                         \ NYET interrupt This interrupt is generated when a NYET response is transmitted for a non isochronous OUT endpoint.
$00008000 constant OTG_FS_OTG_DOEPINT3_STPKTRX                      \ Setup packet received Applicable for control OUT endpoints in only in the Buffer DMA Mode. Set by the OTG_HS, this bit indicates that this buffer holds 8 bytes of setup data. There is only one setup packet per buffer. On receiving a setup packet, the OTG_HS closes the buffer and disables the corresponding endpoint after SETUP_COMPLETE status is seen in the Rx FIFO. OTG_HS puts a SETUP_COMPLETE status into the Rx FIFO when it sees the first IN or OUT token after the SETUP packet for that particular endpoint. The application must then re-enable the endpoint to receive any OUT data for the control transfer and reprogram the buffer start address. Because of the above behavior, OTG_HS can receive any number of back to back setup packets and one buffer for every setup packet is used.


\
\ @brief OTG device OUT endpoint 3 transfer size register
\ Address offset: 0xB70
\ Reset value: 0x00000000
\

$0007ffff constant OTG_FS_OTG_DOEPTSIZ3_XFRSIZ                      \ Transfer size This field contains the transfer size in bytes for the current endpoint. The core only interrupts the application after it has exhausted the transfer size amount of data. The transfer size can be set to the maximum packet size of the endpoint, to be interrupted at the end of each packet. The core decrements this field every time a packet is read from the Rx FIFO and written to the external memory.
$1ff80000 constant OTG_FS_OTG_DOEPTSIZ3_PKTCNT                      \ Packet count Indicates the total number of USB packets that constitute the transfer size amount of data for this endpoint. This field is decremented every time a packet (maximum size or short packet) is written to the Rx FIFO.
$60000000 constant OTG_FS_OTG_DOEPTSIZ3_RXDPID                      \ Received data PID This is the data PID received in the last packet for this endpoint. STUPCNT[1:0]: SETUP packet count This field specifies the number of back-to-back SETUP data packets the endpoint can receive.


\
\ @brief OTG device OUT endpoint 3 DMA address register
\ Address offset: 0xB74
\ Reset value: 0x00000000
\

$00000000 constant OTG_FS_OTG_DOEPDMA3_DMAADDR                      \ DMA Address This field holds the start address in the external memory from which the data for the endpoint must be fetched. This register is incremented on every AHB transaction.


\
\ @brief OTG device OUT endpoint 4 control register
\ Address offset: 0xB80
\ Reset value: 0x00000000
\

$000007ff constant OTG_FS_OTG_DOEPCTL4_INT_BULK_MPSIZ               \ Maximum packet size The application must program this field with the maximum packet size for the current logical endpoint. This value is in bytes.
$00008000 constant OTG_FS_OTG_DOEPCTL4_INT_BULK_USBAEP              \ USB active endpoint Indicates whether this endpoint is active in the current configuration and interface. The core clears this bit for all endpoints (other than EP 0) after detecting a USB reset. After receiving the SetConfiguration and SetInterface commands, the application must program endpoint registers accordingly and set this bit.
$00010000 constant OTG_FS_OTG_DOEPCTL4_INT_BULK_DPID                \ Endpoint data PID Applies to interrupt/bulk OUT endpoints only. Contains the PID of the packet to be received or transmitted on this endpoint. The application must program the PID of the first packet to be received or transmitted on this endpoint, after the endpoint is activated. The application uses the SD0PID and SD1PID register fields to program either DATA0 or DATA1 PID.
$00020000 constant OTG_FS_OTG_DOEPCTL4_INT_BULK_NAKSTS              \ NAK status Indicates the following: When either the application or the core sets this bit: The core stops receiving any data on an OUT endpoint, even if there is space in the Rx FIFO to accommodate the incoming packet. Irrespective of this bits setting, the core always responds to SETUP data packets with an ACK handshake.
$000c0000 constant OTG_FS_OTG_DOEPCTL4_INT_BULK_EPTYP               \ Endpoint type This is the transfer type supported by this logical endpoint.
$00100000 constant OTG_FS_OTG_DOEPCTL4_INT_BULK_SNPM                \ Snoop mode This bit configures the endpoint to Snoop mode. In Snoop mode, the core does not check the correctness of OUT packets before transferring them to application memory.
$00200000 constant OTG_FS_OTG_DOEPCTL4_INT_BULK_STALL               \ STALL handshake Applies to non-control, non-isochronous OUT endpoints only (access type is rw). The application sets this bit to stall all tokens from the USB host to this endpoint. If a NAK bit, Global IN NAK, or Global OUT NAK is set along with this bit, the STALL bit takes priority. Only the application can clear this bit, never the core. Applies to control endpoints only (access type is rs). The application can only set this bit, and the core clears it, when a SETUP token is received for this endpoint. If a NAK bit, Global IN NAK, or Global OUT NAK is set along with this bit, the STALL bit takes priority. Irrespective of this bits setting, the core always responds to SETUP data packets with an ACK handshake.
$04000000 constant OTG_FS_OTG_DOEPCTL4_INT_BULK_CNAK                \ Clear NAK A write to this bit clears the NAK bit for the endpoint.
$08000000 constant OTG_FS_OTG_DOEPCTL4_INT_BULK_SNAK                \ Set NAK A write to this bit sets the NAK bit for the endpoint. Using this bit, the application can control the transmission of NAK handshakes on an endpoint. The core can also set this bit for OUT endpoints on a transfer completed interrupt, or after a SETUP is received on the endpoint.
$10000000 constant OTG_FS_OTG_DOEPCTL4_INT_BULK_SD0PID              \ Set DATA0 PID Applies to interrupt/bulk OUT endpoints only. Writing to this field sets the endpoint data PID (DPID) field in this register to DATA0.
$20000000 constant OTG_FS_OTG_DOEPCTL4_INT_BULK_SD1PID              \ Set DATA1 PID Writing to this field sets the endpoint data PID (DPID) field in this register to DATA1.
$40000000 constant OTG_FS_OTG_DOEPCTL4_INT_BULK_EPDIS               \ Endpoint disable The application sets this bit to stop transmitting/receiving data on an endpoint, even before the transfer for that endpoint is complete. The application must wait for the endpoint disabled interrupt before treating the endpoint as disabled. The core clears this bit before setting the endpoint disabled interrupt. The application must set this bit only if endpoint enable is already set for this endpoint.
$80000000 constant OTG_FS_OTG_DOEPCTL4_INT_BULK_EPENA               \ Endpoint enable Applies to IN and OUT endpoints. The application sets this bit to start transmitting data on an endpoint. The core clears this bit before setting any of the following interrupts on this endpoint: SETUP phase done Endpoint disabled Transfer completed


\
\ @brief OTG device OUT endpoint 4 control register
\ Address offset: 0xB80
\ Reset value: 0x00000000
\

$000007ff constant OTG_FS_OTG_DOEPCTL4_ISO_MPSIZ                    \ Maximum packet size The application must program this field with the maximum packet size for the current logical endpoint. This value is in bytes.
$00008000 constant OTG_FS_OTG_DOEPCTL4_ISO_USBAEP                   \ USB active endpoint Indicates whether this endpoint is active in the current configuration and interface. The core clears this bit for all endpoints (other than EP 0) after detecting a USB reset. After receiving the SetConfiguration and SetInterface commands, the application must program endpoint registers accordingly and set this bit.
$00010000 constant OTG_FS_OTG_DOEPCTL4_ISO_EONUM                    \ Even/odd frame Applies to isochronous OUT endpoints only. Indicates the frame number in which the core transmits/receives isochronous data for this endpoint. The application must program the even/odd frame number in which it intends to transmit/receive isochronous data for this endpoint using the SEVNFRM and SODDFRM fields in this register.
$00020000 constant OTG_FS_OTG_DOEPCTL4_ISO_NAKSTS                   \ NAK status Indicates the following: When either the application or the core sets this bit: The core stops receiving any data on an OUT endpoint, even if there is space in the Rx FIFO to accommodate the incoming packet. Irrespective of this bits setting, the core always responds to SETUP data packets with an ACK handshake.
$000c0000 constant OTG_FS_OTG_DOEPCTL4_ISO_EPTYP                    \ Endpoint type This is the transfer type supported by this logical endpoint.
$00100000 constant OTG_FS_OTG_DOEPCTL4_ISO_SNPM                     \ Snoop mode This bit configures the endpoint to Snoop mode. In Snoop mode, the core does not check the correctness of OUT packets before transferring them to application memory.
$00200000 constant OTG_FS_OTG_DOEPCTL4_ISO_STALL                    \ STALL handshake Applies to non-control, non-isochronous OUT endpoints only (access type is rw). The application sets this bit to stall all tokens from the USB host to this endpoint. If a NAK bit, Global IN NAK, or Global OUT NAK is set along with this bit, the STALL bit takes priority. Only the application can clear this bit, never the core. Applies to control endpoints only (access type is rs). The application can only set this bit, and the core clears it, when a SETUP token is received for this endpoint. If a NAK bit, Global IN NAK, or Global OUT NAK is set along with this bit, the STALL bit takes priority. Irrespective of this bits setting, the core always responds to SETUP data packets with an ACK handshake.
$04000000 constant OTG_FS_OTG_DOEPCTL4_ISO_CNAK                     \ Clear NAK A write to this bit clears the NAK bit for the endpoint.
$08000000 constant OTG_FS_OTG_DOEPCTL4_ISO_SNAK                     \ Set NAK A write to this bit sets the NAK bit for the endpoint. Using this bit, the application can control the transmission of NAK handshakes on an endpoint. The core can also set this bit for OUT endpoints on a transfer completed interrupt, or after a SETUP is received on the endpoint.
$10000000 constant OTG_FS_OTG_DOEPCTL4_ISO_SEVNFRM                  \ Set even frame Applies to isochronous OUT endpoints only. Writing to this field sets the Even/Odd frame (EONUM) field to even frame.
$20000000 constant OTG_FS_OTG_DOEPCTL4_ISO_SODDFRM                  \ Set odd frame Applies to isochronous IN and OUT endpoints only. Writing to this field sets the Even/Odd frame (EONUM) field to odd frame.
$40000000 constant OTG_FS_OTG_DOEPCTL4_ISO_EPDIS                    \ Endpoint disable The application sets this bit to stop transmitting/receiving data on an endpoint, even before the transfer for that endpoint is complete. The application must wait for the endpoint disabled interrupt before treating the endpoint as disabled. The core clears this bit before setting the endpoint disabled interrupt. The application must set this bit only if endpoint enable is already set for this endpoint.
$80000000 constant OTG_FS_OTG_DOEPCTL4_ISO_EPENA                    \ Endpoint enable Applies to IN and OUT endpoints. The application sets this bit to start transmitting data on an endpoint. The core clears this bit before setting any of the following interrupts on this endpoint: SETUP phase done Endpoint disabled Transfer completed


\
\ @brief OTG device OUT endpoint 4 interrupt register
\ Address offset: 0xB88
\ Reset value: 0x00000080
\

$00000001 constant OTG_FS_OTG_DOEPINT4_XFRC                         \ Transfer completed interrupt This field indicates that the programmed transfer is complete on the AHB as well as on the USB, for this endpoint.
$00000002 constant OTG_FS_OTG_DOEPINT4_EPDISD                       \ Endpoint disabled interrupt This bit indicates that the endpoint is disabled per the applications request.
$00000004 constant OTG_FS_OTG_DOEPINT4_AHBERR                       \ AHB error This is generated only in internal DMA mode when there is an AHB error during an AHB read/write. The application can read the corresponding endpoint DMA address register to get the error address.
$00000008 constant OTG_FS_OTG_DOEPINT4_STUP                         \ SETUP phase done Applies to control OUT endpoint only.Indicates that the SETUP phase for the control endpoint is complete and no more back-to-back SETUP packets were received for the current control transfer. On this interrupt, the application can decode the received SETUP data packet.
$00000010 constant OTG_FS_OTG_DOEPINT4_OTEPDIS                      \ OUT token received when endpoint disabled Applies only to control OUT endpoints. Indicates that an OUT token was received when the endpoint was not yet enabled. This interrupt is asserted on the endpoint for which the OUT token was received.
$00000020 constant OTG_FS_OTG_DOEPINT4_STSPHSRX                     \ Status phase received for control write This interrupt is valid only for control OUT endpoints. This interrupt is generated only after OTG_HS has transferred all the data that the host has sent during the data phase of a control write transfer, to the system memory buffer. The interrupt indicates to the application that the host has switched from data phase to the status phase of a control write transfer. The application can use this interrupt to ACK or STALL the status phase, after it has decoded the data phase.
$00000040 constant OTG_FS_OTG_DOEPINT4_B2BSTUP                      \ Back-to-back SETUP packets received Applies to control OUT endpoint only. This bit indicates that the core has received more than three back-to-back SETUP packets for this particular endpoint.
$00000100 constant OTG_FS_OTG_DOEPINT4_OUTPKTERR                    \ OUT packet error This interrupt is asserted when the core detects an overflow or a CRC error for an OUT packet. This interrupt is valid only when thresholding is enabled.
$00001000 constant OTG_FS_OTG_DOEPINT4_BERR                         \ Babble error interrupt The core generates this interrupt when babble is received for the endpoint.
$00002000 constant OTG_FS_OTG_DOEPINT4_NAK                          \ NAK input The core generates this interrupt when a NAK is transmitted or received by the device. In case of isochronous IN endpoints the interrupt gets generated when a zero length packet is transmitted due to unavailability of data in the Tx FIFO.
$00004000 constant OTG_FS_OTG_DOEPINT4_NYET                         \ NYET interrupt This interrupt is generated when a NYET response is transmitted for a non isochronous OUT endpoint.
$00008000 constant OTG_FS_OTG_DOEPINT4_STPKTRX                      \ Setup packet received Applicable for control OUT endpoints in only in the Buffer DMA Mode. Set by the OTG_HS, this bit indicates that this buffer holds 8 bytes of setup data. There is only one setup packet per buffer. On receiving a setup packet, the OTG_HS closes the buffer and disables the corresponding endpoint after SETUP_COMPLETE status is seen in the Rx FIFO. OTG_HS puts a SETUP_COMPLETE status into the Rx FIFO when it sees the first IN or OUT token after the SETUP packet for that particular endpoint. The application must then re-enable the endpoint to receive any OUT data for the control transfer and reprogram the buffer start address. Because of the above behavior, OTG_HS can receive any number of back to back setup packets and one buffer for every setup packet is used.


\
\ @brief OTG device OUT endpoint 4 transfer size register
\ Address offset: 0xB90
\ Reset value: 0x00000000
\

$0007ffff constant OTG_FS_OTG_DOEPTSIZ4_XFRSIZ                      \ Transfer size This field contains the transfer size in bytes for the current endpoint. The core only interrupts the application after it has exhausted the transfer size amount of data. The transfer size can be set to the maximum packet size of the endpoint, to be interrupted at the end of each packet. The core decrements this field every time a packet is read from the Rx FIFO and written to the external memory.
$1ff80000 constant OTG_FS_OTG_DOEPTSIZ4_PKTCNT                      \ Packet count Indicates the total number of USB packets that constitute the transfer size amount of data for this endpoint. This field is decremented every time a packet (maximum size or short packet) is written to the Rx FIFO.
$60000000 constant OTG_FS_OTG_DOEPTSIZ4_RXDPID                      \ Received data PID This is the data PID received in the last packet for this endpoint. STUPCNT[1:0]: SETUP packet count This field specifies the number of back-to-back SETUP data packets the endpoint can receive.


\
\ @brief OTG device OUT endpoint 4 DMA address register
\ Address offset: 0xB94
\ Reset value: 0x00000000
\

$00000000 constant OTG_FS_OTG_DOEPDMA4_DMAADDR                      \ DMA Address This field holds the start address in the external memory from which the data for the endpoint must be fetched. This register is incremented on every AHB transaction.


\
\ @brief OTG device OUT endpoint 5 control register
\ Address offset: 0xBA0
\ Reset value: 0x00000000
\

$000007ff constant OTG_FS_OTG_DOEPCTL5_INT_BULK_MPSIZ               \ Maximum packet size The application must program this field with the maximum packet size for the current logical endpoint. This value is in bytes.
$00008000 constant OTG_FS_OTG_DOEPCTL5_INT_BULK_USBAEP              \ USB active endpoint Indicates whether this endpoint is active in the current configuration and interface. The core clears this bit for all endpoints (other than EP 0) after detecting a USB reset. After receiving the SetConfiguration and SetInterface commands, the application must program endpoint registers accordingly and set this bit.
$00010000 constant OTG_FS_OTG_DOEPCTL5_INT_BULK_DPID                \ Endpoint data PID Applies to interrupt/bulk OUT endpoints only. Contains the PID of the packet to be received or transmitted on this endpoint. The application must program the PID of the first packet to be received or transmitted on this endpoint, after the endpoint is activated. The application uses the SD0PID and SD1PID register fields to program either DATA0 or DATA1 PID.
$00020000 constant OTG_FS_OTG_DOEPCTL5_INT_BULK_NAKSTS              \ NAK status Indicates the following: When either the application or the core sets this bit: The core stops receiving any data on an OUT endpoint, even if there is space in the Rx FIFO to accommodate the incoming packet. Irrespective of this bits setting, the core always responds to SETUP data packets with an ACK handshake.
$000c0000 constant OTG_FS_OTG_DOEPCTL5_INT_BULK_EPTYP               \ Endpoint type This is the transfer type supported by this logical endpoint.
$00100000 constant OTG_FS_OTG_DOEPCTL5_INT_BULK_SNPM                \ Snoop mode This bit configures the endpoint to Snoop mode. In Snoop mode, the core does not check the correctness of OUT packets before transferring them to application memory.
$00200000 constant OTG_FS_OTG_DOEPCTL5_INT_BULK_STALL               \ STALL handshake Applies to non-control, non-isochronous OUT endpoints only (access type is rw). The application sets this bit to stall all tokens from the USB host to this endpoint. If a NAK bit, Global IN NAK, or Global OUT NAK is set along with this bit, the STALL bit takes priority. Only the application can clear this bit, never the core. Applies to control endpoints only (access type is rs). The application can only set this bit, and the core clears it, when a SETUP token is received for this endpoint. If a NAK bit, Global IN NAK, or Global OUT NAK is set along with this bit, the STALL bit takes priority. Irrespective of this bits setting, the core always responds to SETUP data packets with an ACK handshake.
$04000000 constant OTG_FS_OTG_DOEPCTL5_INT_BULK_CNAK                \ Clear NAK A write to this bit clears the NAK bit for the endpoint.
$08000000 constant OTG_FS_OTG_DOEPCTL5_INT_BULK_SNAK                \ Set NAK A write to this bit sets the NAK bit for the endpoint. Using this bit, the application can control the transmission of NAK handshakes on an endpoint. The core can also set this bit for OUT endpoints on a transfer completed interrupt, or after a SETUP is received on the endpoint.
$10000000 constant OTG_FS_OTG_DOEPCTL5_INT_BULK_SD0PID              \ Set DATA0 PID Applies to interrupt/bulk OUT endpoints only. Writing to this field sets the endpoint data PID (DPID) field in this register to DATA0.
$20000000 constant OTG_FS_OTG_DOEPCTL5_INT_BULK_SD1PID              \ Set DATA1 PID Writing to this field sets the endpoint data PID (DPID) field in this register to DATA1.
$40000000 constant OTG_FS_OTG_DOEPCTL5_INT_BULK_EPDIS               \ Endpoint disable The application sets this bit to stop transmitting/receiving data on an endpoint, even before the transfer for that endpoint is complete. The application must wait for the endpoint disabled interrupt before treating the endpoint as disabled. The core clears this bit before setting the endpoint disabled interrupt. The application must set this bit only if endpoint enable is already set for this endpoint.
$80000000 constant OTG_FS_OTG_DOEPCTL5_INT_BULK_EPENA               \ Endpoint enable Applies to IN and OUT endpoints. The application sets this bit to start transmitting data on an endpoint. The core clears this bit before setting any of the following interrupts on this endpoint: SETUP phase done Endpoint disabled Transfer completed


\
\ @brief OTG device OUT endpoint 5 control register
\ Address offset: 0xBA0
\ Reset value: 0x00000000
\

$000007ff constant OTG_FS_OTG_DOEPCTL5_ISO_MPSIZ                    \ Maximum packet size The application must program this field with the maximum packet size for the current logical endpoint. This value is in bytes.
$00008000 constant OTG_FS_OTG_DOEPCTL5_ISO_USBAEP                   \ USB active endpoint Indicates whether this endpoint is active in the current configuration and interface. The core clears this bit for all endpoints (other than EP 0) after detecting a USB reset. After receiving the SetConfiguration and SetInterface commands, the application must program endpoint registers accordingly and set this bit.
$00010000 constant OTG_FS_OTG_DOEPCTL5_ISO_EONUM                    \ Even/odd frame Applies to isochronous OUT endpoints only. Indicates the frame number in which the core transmits/receives isochronous data for this endpoint. The application must program the even/odd frame number in which it intends to transmit/receive isochronous data for this endpoint using the SEVNFRM and SODDFRM fields in this register.
$00020000 constant OTG_FS_OTG_DOEPCTL5_ISO_NAKSTS                   \ NAK status Indicates the following: When either the application or the core sets this bit: The core stops receiving any data on an OUT endpoint, even if there is space in the Rx FIFO to accommodate the incoming packet. Irrespective of this bits setting, the core always responds to SETUP data packets with an ACK handshake.
$000c0000 constant OTG_FS_OTG_DOEPCTL5_ISO_EPTYP                    \ Endpoint type This is the transfer type supported by this logical endpoint.
$00100000 constant OTG_FS_OTG_DOEPCTL5_ISO_SNPM                     \ Snoop mode This bit configures the endpoint to Snoop mode. In Snoop mode, the core does not check the correctness of OUT packets before transferring them to application memory.
$00200000 constant OTG_FS_OTG_DOEPCTL5_ISO_STALL                    \ STALL handshake Applies to non-control, non-isochronous OUT endpoints only (access type is rw). The application sets this bit to stall all tokens from the USB host to this endpoint. If a NAK bit, Global IN NAK, or Global OUT NAK is set along with this bit, the STALL bit takes priority. Only the application can clear this bit, never the core. Applies to control endpoints only (access type is rs). The application can only set this bit, and the core clears it, when a SETUP token is received for this endpoint. If a NAK bit, Global IN NAK, or Global OUT NAK is set along with this bit, the STALL bit takes priority. Irrespective of this bits setting, the core always responds to SETUP data packets with an ACK handshake.
$04000000 constant OTG_FS_OTG_DOEPCTL5_ISO_CNAK                     \ Clear NAK A write to this bit clears the NAK bit for the endpoint.
$08000000 constant OTG_FS_OTG_DOEPCTL5_ISO_SNAK                     \ Set NAK A write to this bit sets the NAK bit for the endpoint. Using this bit, the application can control the transmission of NAK handshakes on an endpoint. The core can also set this bit for OUT endpoints on a transfer completed interrupt, or after a SETUP is received on the endpoint.
$10000000 constant OTG_FS_OTG_DOEPCTL5_ISO_SEVNFRM                  \ Set even frame Applies to isochronous OUT endpoints only. Writing to this field sets the Even/Odd frame (EONUM) field to even frame.
$20000000 constant OTG_FS_OTG_DOEPCTL5_ISO_SODDFRM                  \ Set odd frame Applies to isochronous IN and OUT endpoints only. Writing to this field sets the Even/Odd frame (EONUM) field to odd frame.
$40000000 constant OTG_FS_OTG_DOEPCTL5_ISO_EPDIS                    \ Endpoint disable The application sets this bit to stop transmitting/receiving data on an endpoint, even before the transfer for that endpoint is complete. The application must wait for the endpoint disabled interrupt before treating the endpoint as disabled. The core clears this bit before setting the endpoint disabled interrupt. The application must set this bit only if endpoint enable is already set for this endpoint.
$80000000 constant OTG_FS_OTG_DOEPCTL5_ISO_EPENA                    \ Endpoint enable Applies to IN and OUT endpoints. The application sets this bit to start transmitting data on an endpoint. The core clears this bit before setting any of the following interrupts on this endpoint: SETUP phase done Endpoint disabled Transfer completed


\
\ @brief OTG device OUT endpoint 5 interrupt register
\ Address offset: 0xBA8
\ Reset value: 0x00000080
\

$00000001 constant OTG_FS_OTG_DOEPINT5_XFRC                         \ Transfer completed interrupt This field indicates that the programmed transfer is complete on the AHB as well as on the USB, for this endpoint.
$00000002 constant OTG_FS_OTG_DOEPINT5_EPDISD                       \ Endpoint disabled interrupt This bit indicates that the endpoint is disabled per the applications request.
$00000004 constant OTG_FS_OTG_DOEPINT5_AHBERR                       \ AHB error This is generated only in internal DMA mode when there is an AHB error during an AHB read/write. The application can read the corresponding endpoint DMA address register to get the error address.
$00000008 constant OTG_FS_OTG_DOEPINT5_STUP                         \ SETUP phase done Applies to control OUT endpoint only.Indicates that the SETUP phase for the control endpoint is complete and no more back-to-back SETUP packets were received for the current control transfer. On this interrupt, the application can decode the received SETUP data packet.
$00000010 constant OTG_FS_OTG_DOEPINT5_OTEPDIS                      \ OUT token received when endpoint disabled Applies only to control OUT endpoints. Indicates that an OUT token was received when the endpoint was not yet enabled. This interrupt is asserted on the endpoint for which the OUT token was received.
$00000020 constant OTG_FS_OTG_DOEPINT5_STSPHSRX                     \ Status phase received for control write This interrupt is valid only for control OUT endpoints. This interrupt is generated only after OTG_HS has transferred all the data that the host has sent during the data phase of a control write transfer, to the system memory buffer. The interrupt indicates to the application that the host has switched from data phase to the status phase of a control write transfer. The application can use this interrupt to ACK or STALL the status phase, after it has decoded the data phase.
$00000040 constant OTG_FS_OTG_DOEPINT5_B2BSTUP                      \ Back-to-back SETUP packets received Applies to control OUT endpoint only. This bit indicates that the core has received more than three back-to-back SETUP packets for this particular endpoint.
$00000100 constant OTG_FS_OTG_DOEPINT5_OUTPKTERR                    \ OUT packet error This interrupt is asserted when the core detects an overflow or a CRC error for an OUT packet. This interrupt is valid only when thresholding is enabled.
$00001000 constant OTG_FS_OTG_DOEPINT5_BERR                         \ Babble error interrupt The core generates this interrupt when babble is received for the endpoint.
$00002000 constant OTG_FS_OTG_DOEPINT5_NAK                          \ NAK input The core generates this interrupt when a NAK is transmitted or received by the device. In case of isochronous IN endpoints the interrupt gets generated when a zero length packet is transmitted due to unavailability of data in the Tx FIFO.
$00004000 constant OTG_FS_OTG_DOEPINT5_NYET                         \ NYET interrupt This interrupt is generated when a NYET response is transmitted for a non isochronous OUT endpoint.
$00008000 constant OTG_FS_OTG_DOEPINT5_STPKTRX                      \ Setup packet received Applicable for control OUT endpoints in only in the Buffer DMA Mode. Set by the OTG_HS, this bit indicates that this buffer holds 8 bytes of setup data. There is only one setup packet per buffer. On receiving a setup packet, the OTG_HS closes the buffer and disables the corresponding endpoint after SETUP_COMPLETE status is seen in the Rx FIFO. OTG_HS puts a SETUP_COMPLETE status into the Rx FIFO when it sees the first IN or OUT token after the SETUP packet for that particular endpoint. The application must then re-enable the endpoint to receive any OUT data for the control transfer and reprogram the buffer start address. Because of the above behavior, OTG_HS can receive any number of back to back setup packets and one buffer for every setup packet is used.


\
\ @brief OTG device OUT endpoint 5 transfer size register
\ Address offset: 0xBB0
\ Reset value: 0x00000000
\

$0007ffff constant OTG_FS_OTG_DOEPTSIZ5_XFRSIZ                      \ Transfer size This field contains the transfer size in bytes for the current endpoint. The core only interrupts the application after it has exhausted the transfer size amount of data. The transfer size can be set to the maximum packet size of the endpoint, to be interrupted at the end of each packet. The core decrements this field every time a packet is read from the Rx FIFO and written to the external memory.
$1ff80000 constant OTG_FS_OTG_DOEPTSIZ5_PKTCNT                      \ Packet count Indicates the total number of USB packets that constitute the transfer size amount of data for this endpoint. This field is decremented every time a packet (maximum size or short packet) is written to the Rx FIFO.
$60000000 constant OTG_FS_OTG_DOEPTSIZ5_RXDPID                      \ Received data PID This is the data PID received in the last packet for this endpoint. STUPCNT[1:0]: SETUP packet count This field specifies the number of back-to-back SETUP data packets the endpoint can receive.


\
\ @brief OTG device OUT endpoint 5 DMA address register
\ Address offset: 0xBB4
\ Reset value: 0x00000000
\

$00000000 constant OTG_FS_OTG_DOEPDMA5_DMAADDR                      \ DMA Address This field holds the start address in the external memory from which the data for the endpoint must be fetched. This register is incremented on every AHB transaction.


\
\ @brief OTG device OUT endpoint 6 control register
\ Address offset: 0xBC0
\ Reset value: 0x00000000
\

$000007ff constant OTG_FS_OTG_DOEPCTL6_INT_BULK_MPSIZ               \ Maximum packet size The application must program this field with the maximum packet size for the current logical endpoint. This value is in bytes.
$00008000 constant OTG_FS_OTG_DOEPCTL6_INT_BULK_USBAEP              \ USB active endpoint Indicates whether this endpoint is active in the current configuration and interface. The core clears this bit for all endpoints (other than EP 0) after detecting a USB reset. After receiving the SetConfiguration and SetInterface commands, the application must program endpoint registers accordingly and set this bit.
$00010000 constant OTG_FS_OTG_DOEPCTL6_INT_BULK_DPID                \ Endpoint data PID Applies to interrupt/bulk OUT endpoints only. Contains the PID of the packet to be received or transmitted on this endpoint. The application must program the PID of the first packet to be received or transmitted on this endpoint, after the endpoint is activated. The application uses the SD0PID and SD1PID register fields to program either DATA0 or DATA1 PID.
$00020000 constant OTG_FS_OTG_DOEPCTL6_INT_BULK_NAKSTS              \ NAK status Indicates the following: When either the application or the core sets this bit: The core stops receiving any data on an OUT endpoint, even if there is space in the Rx FIFO to accommodate the incoming packet. Irrespective of this bits setting, the core always responds to SETUP data packets with an ACK handshake.
$000c0000 constant OTG_FS_OTG_DOEPCTL6_INT_BULK_EPTYP               \ Endpoint type This is the transfer type supported by this logical endpoint.
$00100000 constant OTG_FS_OTG_DOEPCTL6_INT_BULK_SNPM                \ Snoop mode This bit configures the endpoint to Snoop mode. In Snoop mode, the core does not check the correctness of OUT packets before transferring them to application memory.
$00200000 constant OTG_FS_OTG_DOEPCTL6_INT_BULK_STALL               \ STALL handshake Applies to non-control, non-isochronous OUT endpoints only (access type is rw). The application sets this bit to stall all tokens from the USB host to this endpoint. If a NAK bit, Global IN NAK, or Global OUT NAK is set along with this bit, the STALL bit takes priority. Only the application can clear this bit, never the core. Applies to control endpoints only (access type is rs). The application can only set this bit, and the core clears it, when a SETUP token is received for this endpoint. If a NAK bit, Global IN NAK, or Global OUT NAK is set along with this bit, the STALL bit takes priority. Irrespective of this bits setting, the core always responds to SETUP data packets with an ACK handshake.
$04000000 constant OTG_FS_OTG_DOEPCTL6_INT_BULK_CNAK                \ Clear NAK A write to this bit clears the NAK bit for the endpoint.
$08000000 constant OTG_FS_OTG_DOEPCTL6_INT_BULK_SNAK                \ Set NAK A write to this bit sets the NAK bit for the endpoint. Using this bit, the application can control the transmission of NAK handshakes on an endpoint. The core can also set this bit for OUT endpoints on a transfer completed interrupt, or after a SETUP is received on the endpoint.
$10000000 constant OTG_FS_OTG_DOEPCTL6_INT_BULK_SD0PID              \ Set DATA0 PID Applies to interrupt/bulk OUT endpoints only. Writing to this field sets the endpoint data PID (DPID) field in this register to DATA0.
$20000000 constant OTG_FS_OTG_DOEPCTL6_INT_BULK_SD1PID              \ Set DATA1 PID Writing to this field sets the endpoint data PID (DPID) field in this register to DATA1.
$40000000 constant OTG_FS_OTG_DOEPCTL6_INT_BULK_EPDIS               \ Endpoint disable The application sets this bit to stop transmitting/receiving data on an endpoint, even before the transfer for that endpoint is complete. The application must wait for the endpoint disabled interrupt before treating the endpoint as disabled. The core clears this bit before setting the endpoint disabled interrupt. The application must set this bit only if endpoint enable is already set for this endpoint.
$80000000 constant OTG_FS_OTG_DOEPCTL6_INT_BULK_EPENA               \ Endpoint enable Applies to IN and OUT endpoints. The application sets this bit to start transmitting data on an endpoint. The core clears this bit before setting any of the following interrupts on this endpoint: SETUP phase done Endpoint disabled Transfer completed


\
\ @brief OTG device OUT endpoint 6 control register
\ Address offset: 0xBC0
\ Reset value: 0x00000000
\

$000007ff constant OTG_FS_OTG_DOEPCTL6_ISO_MPSIZ                    \ Maximum packet size The application must program this field with the maximum packet size for the current logical endpoint. This value is in bytes.
$00008000 constant OTG_FS_OTG_DOEPCTL6_ISO_USBAEP                   \ USB active endpoint Indicates whether this endpoint is active in the current configuration and interface. The core clears this bit for all endpoints (other than EP 0) after detecting a USB reset. After receiving the SetConfiguration and SetInterface commands, the application must program endpoint registers accordingly and set this bit.
$00010000 constant OTG_FS_OTG_DOEPCTL6_ISO_EONUM                    \ Even/odd frame Applies to isochronous OUT endpoints only. Indicates the frame number in which the core transmits/receives isochronous data for this endpoint. The application must program the even/odd frame number in which it intends to transmit/receive isochronous data for this endpoint using the SEVNFRM and SODDFRM fields in this register.
$00020000 constant OTG_FS_OTG_DOEPCTL6_ISO_NAKSTS                   \ NAK status Indicates the following: When either the application or the core sets this bit: The core stops receiving any data on an OUT endpoint, even if there is space in the Rx FIFO to accommodate the incoming packet. Irrespective of this bits setting, the core always responds to SETUP data packets with an ACK handshake.
$000c0000 constant OTG_FS_OTG_DOEPCTL6_ISO_EPTYP                    \ Endpoint type This is the transfer type supported by this logical endpoint.
$00100000 constant OTG_FS_OTG_DOEPCTL6_ISO_SNPM                     \ Snoop mode This bit configures the endpoint to Snoop mode. In Snoop mode, the core does not check the correctness of OUT packets before transferring them to application memory.
$00200000 constant OTG_FS_OTG_DOEPCTL6_ISO_STALL                    \ STALL handshake Applies to non-control, non-isochronous OUT endpoints only (access type is rw). The application sets this bit to stall all tokens from the USB host to this endpoint. If a NAK bit, Global IN NAK, or Global OUT NAK is set along with this bit, the STALL bit takes priority. Only the application can clear this bit, never the core. Applies to control endpoints only (access type is rs). The application can only set this bit, and the core clears it, when a SETUP token is received for this endpoint. If a NAK bit, Global IN NAK, or Global OUT NAK is set along with this bit, the STALL bit takes priority. Irrespective of this bits setting, the core always responds to SETUP data packets with an ACK handshake.
$04000000 constant OTG_FS_OTG_DOEPCTL6_ISO_CNAK                     \ Clear NAK A write to this bit clears the NAK bit for the endpoint.
$08000000 constant OTG_FS_OTG_DOEPCTL6_ISO_SNAK                     \ Set NAK A write to this bit sets the NAK bit for the endpoint. Using this bit, the application can control the transmission of NAK handshakes on an endpoint. The core can also set this bit for OUT endpoints on a transfer completed interrupt, or after a SETUP is received on the endpoint.
$10000000 constant OTG_FS_OTG_DOEPCTL6_ISO_SEVNFRM                  \ Set even frame Applies to isochronous OUT endpoints only. Writing to this field sets the Even/Odd frame (EONUM) field to even frame.
$20000000 constant OTG_FS_OTG_DOEPCTL6_ISO_SODDFRM                  \ Set odd frame Applies to isochronous IN and OUT endpoints only. Writing to this field sets the Even/Odd frame (EONUM) field to odd frame.
$40000000 constant OTG_FS_OTG_DOEPCTL6_ISO_EPDIS                    \ Endpoint disable The application sets this bit to stop transmitting/receiving data on an endpoint, even before the transfer for that endpoint is complete. The application must wait for the endpoint disabled interrupt before treating the endpoint as disabled. The core clears this bit before setting the endpoint disabled interrupt. The application must set this bit only if endpoint enable is already set for this endpoint.
$80000000 constant OTG_FS_OTG_DOEPCTL6_ISO_EPENA                    \ Endpoint enable Applies to IN and OUT endpoints. The application sets this bit to start transmitting data on an endpoint. The core clears this bit before setting any of the following interrupts on this endpoint: SETUP phase done Endpoint disabled Transfer completed


\
\ @brief OTG device OUT endpoint 6 interrupt register
\ Address offset: 0xBC8
\ Reset value: 0x00000080
\

$00000001 constant OTG_FS_OTG_DOEPINT6_XFRC                         \ Transfer completed interrupt This field indicates that the programmed transfer is complete on the AHB as well as on the USB, for this endpoint.
$00000002 constant OTG_FS_OTG_DOEPINT6_EPDISD                       \ Endpoint disabled interrupt This bit indicates that the endpoint is disabled per the applications request.
$00000004 constant OTG_FS_OTG_DOEPINT6_AHBERR                       \ AHB error This is generated only in internal DMA mode when there is an AHB error during an AHB read/write. The application can read the corresponding endpoint DMA address register to get the error address.
$00000008 constant OTG_FS_OTG_DOEPINT6_STUP                         \ SETUP phase done Applies to control OUT endpoint only.Indicates that the SETUP phase for the control endpoint is complete and no more back-to-back SETUP packets were received for the current control transfer. On this interrupt, the application can decode the received SETUP data packet.
$00000010 constant OTG_FS_OTG_DOEPINT6_OTEPDIS                      \ OUT token received when endpoint disabled Applies only to control OUT endpoints. Indicates that an OUT token was received when the endpoint was not yet enabled. This interrupt is asserted on the endpoint for which the OUT token was received.
$00000020 constant OTG_FS_OTG_DOEPINT6_STSPHSRX                     \ Status phase received for control write This interrupt is valid only for control OUT endpoints. This interrupt is generated only after OTG_HS has transferred all the data that the host has sent during the data phase of a control write transfer, to the system memory buffer. The interrupt indicates to the application that the host has switched from data phase to the status phase of a control write transfer. The application can use this interrupt to ACK or STALL the status phase, after it has decoded the data phase.
$00000040 constant OTG_FS_OTG_DOEPINT6_B2BSTUP                      \ Back-to-back SETUP packets received Applies to control OUT endpoint only. This bit indicates that the core has received more than three back-to-back SETUP packets for this particular endpoint.
$00000100 constant OTG_FS_OTG_DOEPINT6_OUTPKTERR                    \ OUT packet error This interrupt is asserted when the core detects an overflow or a CRC error for an OUT packet. This interrupt is valid only when thresholding is enabled.
$00001000 constant OTG_FS_OTG_DOEPINT6_BERR                         \ Babble error interrupt The core generates this interrupt when babble is received for the endpoint.
$00002000 constant OTG_FS_OTG_DOEPINT6_NAK                          \ NAK input The core generates this interrupt when a NAK is transmitted or received by the device. In case of isochronous IN endpoints the interrupt gets generated when a zero length packet is transmitted due to unavailability of data in the Tx FIFO.
$00004000 constant OTG_FS_OTG_DOEPINT6_NYET                         \ NYET interrupt This interrupt is generated when a NYET response is transmitted for a non isochronous OUT endpoint.
$00008000 constant OTG_FS_OTG_DOEPINT6_STPKTRX                      \ Setup packet received Applicable for control OUT endpoints in only in the Buffer DMA Mode. Set by the OTG_HS, this bit indicates that this buffer holds 8 bytes of setup data. There is only one setup packet per buffer. On receiving a setup packet, the OTG_HS closes the buffer and disables the corresponding endpoint after SETUP_COMPLETE status is seen in the Rx FIFO. OTG_HS puts a SETUP_COMPLETE status into the Rx FIFO when it sees the first IN or OUT token after the SETUP packet for that particular endpoint. The application must then re-enable the endpoint to receive any OUT data for the control transfer and reprogram the buffer start address. Because of the above behavior, OTG_HS can receive any number of back to back setup packets and one buffer for every setup packet is used.


\
\ @brief OTG device OUT endpoint 6 transfer size register
\ Address offset: 0xBD0
\ Reset value: 0x00000000
\

$0007ffff constant OTG_FS_OTG_DOEPTSIZ6_XFRSIZ                      \ Transfer size This field contains the transfer size in bytes for the current endpoint. The core only interrupts the application after it has exhausted the transfer size amount of data. The transfer size can be set to the maximum packet size of the endpoint, to be interrupted at the end of each packet. The core decrements this field every time a packet is read from the Rx FIFO and written to the external memory.
$1ff80000 constant OTG_FS_OTG_DOEPTSIZ6_PKTCNT                      \ Packet count Indicates the total number of USB packets that constitute the transfer size amount of data for this endpoint. This field is decremented every time a packet (maximum size or short packet) is written to the Rx FIFO.
$60000000 constant OTG_FS_OTG_DOEPTSIZ6_RXDPID                      \ Received data PID This is the data PID received in the last packet for this endpoint. STUPCNT[1:0]: SETUP packet count This field specifies the number of back-to-back SETUP data packets the endpoint can receive.


\
\ @brief OTG device OUT endpoint 6 DMA address register
\ Address offset: 0xBD4
\ Reset value: 0x00000000
\

$00000000 constant OTG_FS_OTG_DOEPDMA6_DMAADDR                      \ DMA Address This field holds the start address in the external memory from which the data for the endpoint must be fetched. This register is incremented on every AHB transaction.


\
\ @brief OTG device OUT endpoint 7 control register
\ Address offset: 0xBE0
\ Reset value: 0x00000000
\

$000007ff constant OTG_FS_OTG_DOEPCTL7_INT_BULK_MPSIZ               \ Maximum packet size The application must program this field with the maximum packet size for the current logical endpoint. This value is in bytes.
$00008000 constant OTG_FS_OTG_DOEPCTL7_INT_BULK_USBAEP              \ USB active endpoint Indicates whether this endpoint is active in the current configuration and interface. The core clears this bit for all endpoints (other than EP 0) after detecting a USB reset. After receiving the SetConfiguration and SetInterface commands, the application must program endpoint registers accordingly and set this bit.
$00010000 constant OTG_FS_OTG_DOEPCTL7_INT_BULK_DPID                \ Endpoint data PID Applies to interrupt/bulk OUT endpoints only. Contains the PID of the packet to be received or transmitted on this endpoint. The application must program the PID of the first packet to be received or transmitted on this endpoint, after the endpoint is activated. The application uses the SD0PID and SD1PID register fields to program either DATA0 or DATA1 PID.
$00020000 constant OTG_FS_OTG_DOEPCTL7_INT_BULK_NAKSTS              \ NAK status Indicates the following: When either the application or the core sets this bit: The core stops receiving any data on an OUT endpoint, even if there is space in the Rx FIFO to accommodate the incoming packet. Irrespective of this bits setting, the core always responds to SETUP data packets with an ACK handshake.
$000c0000 constant OTG_FS_OTG_DOEPCTL7_INT_BULK_EPTYP               \ Endpoint type This is the transfer type supported by this logical endpoint.
$00100000 constant OTG_FS_OTG_DOEPCTL7_INT_BULK_SNPM                \ Snoop mode This bit configures the endpoint to Snoop mode. In Snoop mode, the core does not check the correctness of OUT packets before transferring them to application memory.
$00200000 constant OTG_FS_OTG_DOEPCTL7_INT_BULK_STALL               \ STALL handshake Applies to non-control, non-isochronous OUT endpoints only (access type is rw). The application sets this bit to stall all tokens from the USB host to this endpoint. If a NAK bit, Global IN NAK, or Global OUT NAK is set along with this bit, the STALL bit takes priority. Only the application can clear this bit, never the core. Applies to control endpoints only (access type is rs). The application can only set this bit, and the core clears it, when a SETUP token is received for this endpoint. If a NAK bit, Global IN NAK, or Global OUT NAK is set along with this bit, the STALL bit takes priority. Irrespective of this bits setting, the core always responds to SETUP data packets with an ACK handshake.
$04000000 constant OTG_FS_OTG_DOEPCTL7_INT_BULK_CNAK                \ Clear NAK A write to this bit clears the NAK bit for the endpoint.
$08000000 constant OTG_FS_OTG_DOEPCTL7_INT_BULK_SNAK                \ Set NAK A write to this bit sets the NAK bit for the endpoint. Using this bit, the application can control the transmission of NAK handshakes on an endpoint. The core can also set this bit for OUT endpoints on a transfer completed interrupt, or after a SETUP is received on the endpoint.
$10000000 constant OTG_FS_OTG_DOEPCTL7_INT_BULK_SD0PID              \ Set DATA0 PID Applies to interrupt/bulk OUT endpoints only. Writing to this field sets the endpoint data PID (DPID) field in this register to DATA0.
$20000000 constant OTG_FS_OTG_DOEPCTL7_INT_BULK_SD1PID              \ Set DATA1 PID Writing to this field sets the endpoint data PID (DPID) field in this register to DATA1.
$40000000 constant OTG_FS_OTG_DOEPCTL7_INT_BULK_EPDIS               \ Endpoint disable The application sets this bit to stop transmitting/receiving data on an endpoint, even before the transfer for that endpoint is complete. The application must wait for the endpoint disabled interrupt before treating the endpoint as disabled. The core clears this bit before setting the endpoint disabled interrupt. The application must set this bit only if endpoint enable is already set for this endpoint.
$80000000 constant OTG_FS_OTG_DOEPCTL7_INT_BULK_EPENA               \ Endpoint enable Applies to IN and OUT endpoints. The application sets this bit to start transmitting data on an endpoint. The core clears this bit before setting any of the following interrupts on this endpoint: SETUP phase done Endpoint disabled Transfer completed


\
\ @brief OTG device OUT endpoint 7 control register
\ Address offset: 0xBE0
\ Reset value: 0x00000000
\

$000007ff constant OTG_FS_OTG_DOEPCTL7_ISO_MPSIZ                    \ Maximum packet size The application must program this field with the maximum packet size for the current logical endpoint. This value is in bytes.
$00008000 constant OTG_FS_OTG_DOEPCTL7_ISO_USBAEP                   \ USB active endpoint Indicates whether this endpoint is active in the current configuration and interface. The core clears this bit for all endpoints (other than EP 0) after detecting a USB reset. After receiving the SetConfiguration and SetInterface commands, the application must program endpoint registers accordingly and set this bit.
$00010000 constant OTG_FS_OTG_DOEPCTL7_ISO_EONUM                    \ Even/odd frame Applies to isochronous OUT endpoints only. Indicates the frame number in which the core transmits/receives isochronous data for this endpoint. The application must program the even/odd frame number in which it intends to transmit/receive isochronous data for this endpoint using the SEVNFRM and SODDFRM fields in this register.
$00020000 constant OTG_FS_OTG_DOEPCTL7_ISO_NAKSTS                   \ NAK status Indicates the following: When either the application or the core sets this bit: The core stops receiving any data on an OUT endpoint, even if there is space in the Rx FIFO to accommodate the incoming packet. Irrespective of this bits setting, the core always responds to SETUP data packets with an ACK handshake.
$000c0000 constant OTG_FS_OTG_DOEPCTL7_ISO_EPTYP                    \ Endpoint type This is the transfer type supported by this logical endpoint.
$00100000 constant OTG_FS_OTG_DOEPCTL7_ISO_SNPM                     \ Snoop mode This bit configures the endpoint to Snoop mode. In Snoop mode, the core does not check the correctness of OUT packets before transferring them to application memory.
$00200000 constant OTG_FS_OTG_DOEPCTL7_ISO_STALL                    \ STALL handshake Applies to non-control, non-isochronous OUT endpoints only (access type is rw). The application sets this bit to stall all tokens from the USB host to this endpoint. If a NAK bit, Global IN NAK, or Global OUT NAK is set along with this bit, the STALL bit takes priority. Only the application can clear this bit, never the core. Applies to control endpoints only (access type is rs). The application can only set this bit, and the core clears it, when a SETUP token is received for this endpoint. If a NAK bit, Global IN NAK, or Global OUT NAK is set along with this bit, the STALL bit takes priority. Irrespective of this bits setting, the core always responds to SETUP data packets with an ACK handshake.
$04000000 constant OTG_FS_OTG_DOEPCTL7_ISO_CNAK                     \ Clear NAK A write to this bit clears the NAK bit for the endpoint.
$08000000 constant OTG_FS_OTG_DOEPCTL7_ISO_SNAK                     \ Set NAK A write to this bit sets the NAK bit for the endpoint. Using this bit, the application can control the transmission of NAK handshakes on an endpoint. The core can also set this bit for OUT endpoints on a transfer completed interrupt, or after a SETUP is received on the endpoint.
$10000000 constant OTG_FS_OTG_DOEPCTL7_ISO_SEVNFRM                  \ Set even frame Applies to isochronous OUT endpoints only. Writing to this field sets the Even/Odd frame (EONUM) field to even frame.
$20000000 constant OTG_FS_OTG_DOEPCTL7_ISO_SODDFRM                  \ Set odd frame Applies to isochronous IN and OUT endpoints only. Writing to this field sets the Even/Odd frame (EONUM) field to odd frame.
$40000000 constant OTG_FS_OTG_DOEPCTL7_ISO_EPDIS                    \ Endpoint disable The application sets this bit to stop transmitting/receiving data on an endpoint, even before the transfer for that endpoint is complete. The application must wait for the endpoint disabled interrupt before treating the endpoint as disabled. The core clears this bit before setting the endpoint disabled interrupt. The application must set this bit only if endpoint enable is already set for this endpoint.
$80000000 constant OTG_FS_OTG_DOEPCTL7_ISO_EPENA                    \ Endpoint enable Applies to IN and OUT endpoints. The application sets this bit to start transmitting data on an endpoint. The core clears this bit before setting any of the following interrupts on this endpoint: SETUP phase done Endpoint disabled Transfer completed


\
\ @brief OTG device OUT endpoint 7 interrupt register
\ Address offset: 0xBE8
\ Reset value: 0x00000080
\

$00000001 constant OTG_FS_OTG_DOEPINT7_XFRC                         \ Transfer completed interrupt This field indicates that the programmed transfer is complete on the AHB as well as on the USB, for this endpoint.
$00000002 constant OTG_FS_OTG_DOEPINT7_EPDISD                       \ Endpoint disabled interrupt This bit indicates that the endpoint is disabled per the applications request.
$00000004 constant OTG_FS_OTG_DOEPINT7_AHBERR                       \ AHB error This is generated only in internal DMA mode when there is an AHB error during an AHB read/write. The application can read the corresponding endpoint DMA address register to get the error address.
$00000008 constant OTG_FS_OTG_DOEPINT7_STUP                         \ SETUP phase done Applies to control OUT endpoint only.Indicates that the SETUP phase for the control endpoint is complete and no more back-to-back SETUP packets were received for the current control transfer. On this interrupt, the application can decode the received SETUP data packet.
$00000010 constant OTG_FS_OTG_DOEPINT7_OTEPDIS                      \ OUT token received when endpoint disabled Applies only to control OUT endpoints. Indicates that an OUT token was received when the endpoint was not yet enabled. This interrupt is asserted on the endpoint for which the OUT token was received.
$00000020 constant OTG_FS_OTG_DOEPINT7_STSPHSRX                     \ Status phase received for control write This interrupt is valid only for control OUT endpoints. This interrupt is generated only after OTG_HS has transferred all the data that the host has sent during the data phase of a control write transfer, to the system memory buffer. The interrupt indicates to the application that the host has switched from data phase to the status phase of a control write transfer. The application can use this interrupt to ACK or STALL the status phase, after it has decoded the data phase.
$00000040 constant OTG_FS_OTG_DOEPINT7_B2BSTUP                      \ Back-to-back SETUP packets received Applies to control OUT endpoint only. This bit indicates that the core has received more than three back-to-back SETUP packets for this particular endpoint.
$00000100 constant OTG_FS_OTG_DOEPINT7_OUTPKTERR                    \ OUT packet error This interrupt is asserted when the core detects an overflow or a CRC error for an OUT packet. This interrupt is valid only when thresholding is enabled.
$00001000 constant OTG_FS_OTG_DOEPINT7_BERR                         \ Babble error interrupt The core generates this interrupt when babble is received for the endpoint.
$00002000 constant OTG_FS_OTG_DOEPINT7_NAK                          \ NAK input The core generates this interrupt when a NAK is transmitted or received by the device. In case of isochronous IN endpoints the interrupt gets generated when a zero length packet is transmitted due to unavailability of data in the Tx FIFO.
$00004000 constant OTG_FS_OTG_DOEPINT7_NYET                         \ NYET interrupt This interrupt is generated when a NYET response is transmitted for a non isochronous OUT endpoint.
$00008000 constant OTG_FS_OTG_DOEPINT7_STPKTRX                      \ Setup packet received Applicable for control OUT endpoints in only in the Buffer DMA Mode. Set by the OTG_HS, this bit indicates that this buffer holds 8 bytes of setup data. There is only one setup packet per buffer. On receiving a setup packet, the OTG_HS closes the buffer and disables the corresponding endpoint after SETUP_COMPLETE status is seen in the Rx FIFO. OTG_HS puts a SETUP_COMPLETE status into the Rx FIFO when it sees the first IN or OUT token after the SETUP packet for that particular endpoint. The application must then re-enable the endpoint to receive any OUT data for the control transfer and reprogram the buffer start address. Because of the above behavior, OTG_HS can receive any number of back to back setup packets and one buffer for every setup packet is used.


\
\ @brief OTG device OUT endpoint 7 transfer size register
\ Address offset: 0xBF0
\ Reset value: 0x00000000
\

$0007ffff constant OTG_FS_OTG_DOEPTSIZ7_XFRSIZ                      \ Transfer size This field contains the transfer size in bytes for the current endpoint. The core only interrupts the application after it has exhausted the transfer size amount of data. The transfer size can be set to the maximum packet size of the endpoint, to be interrupted at the end of each packet. The core decrements this field every time a packet is read from the Rx FIFO and written to the external memory.
$1ff80000 constant OTG_FS_OTG_DOEPTSIZ7_PKTCNT                      \ Packet count Indicates the total number of USB packets that constitute the transfer size amount of data for this endpoint. This field is decremented every time a packet (maximum size or short packet) is written to the Rx FIFO.
$60000000 constant OTG_FS_OTG_DOEPTSIZ7_RXDPID                      \ Received data PID This is the data PID received in the last packet for this endpoint. STUPCNT[1:0]: SETUP packet count This field specifies the number of back-to-back SETUP data packets the endpoint can receive.


\
\ @brief OTG device OUT endpoint 7 DMA address register
\ Address offset: 0xBF4
\ Reset value: 0x00000000
\

$00000000 constant OTG_FS_OTG_DOEPDMA7_DMAADDR                      \ DMA Address This field holds the start address in the external memory from which the data for the endpoint must be fetched. This register is incremented on every AHB transaction.


\
\ @brief OTG device OUT endpoint 8 control register
\ Address offset: 0xC00
\ Reset value: 0x00000000
\

$000007ff constant OTG_FS_OTG_DOEPCTL8_INT_BULK_MPSIZ               \ Maximum packet size The application must program this field with the maximum packet size for the current logical endpoint. This value is in bytes.
$00008000 constant OTG_FS_OTG_DOEPCTL8_INT_BULK_USBAEP              \ USB active endpoint Indicates whether this endpoint is active in the current configuration and interface. The core clears this bit for all endpoints (other than EP 0) after detecting a USB reset. After receiving the SetConfiguration and SetInterface commands, the application must program endpoint registers accordingly and set this bit.
$00010000 constant OTG_FS_OTG_DOEPCTL8_INT_BULK_DPID                \ Endpoint data PID Applies to interrupt/bulk OUT endpoints only. Contains the PID of the packet to be received or transmitted on this endpoint. The application must program the PID of the first packet to be received or transmitted on this endpoint, after the endpoint is activated. The application uses the SD0PID and SD1PID register fields to program either DATA0 or DATA1 PID.
$00020000 constant OTG_FS_OTG_DOEPCTL8_INT_BULK_NAKSTS              \ NAK status Indicates the following: When either the application or the core sets this bit: The core stops receiving any data on an OUT endpoint, even if there is space in the Rx FIFO to accommodate the incoming packet. Irrespective of this bits setting, the core always responds to SETUP data packets with an ACK handshake.
$000c0000 constant OTG_FS_OTG_DOEPCTL8_INT_BULK_EPTYP               \ Endpoint type This is the transfer type supported by this logical endpoint.
$00100000 constant OTG_FS_OTG_DOEPCTL8_INT_BULK_SNPM                \ Snoop mode This bit configures the endpoint to Snoop mode. In Snoop mode, the core does not check the correctness of OUT packets before transferring them to application memory.
$00200000 constant OTG_FS_OTG_DOEPCTL8_INT_BULK_STALL               \ STALL handshake Applies to non-control, non-isochronous OUT endpoints only (access type is rw). The application sets this bit to stall all tokens from the USB host to this endpoint. If a NAK bit, Global IN NAK, or Global OUT NAK is set along with this bit, the STALL bit takes priority. Only the application can clear this bit, never the core. Applies to control endpoints only (access type is rs). The application can only set this bit, and the core clears it, when a SETUP token is received for this endpoint. If a NAK bit, Global IN NAK, or Global OUT NAK is set along with this bit, the STALL bit takes priority. Irrespective of this bits setting, the core always responds to SETUP data packets with an ACK handshake.
$04000000 constant OTG_FS_OTG_DOEPCTL8_INT_BULK_CNAK                \ Clear NAK A write to this bit clears the NAK bit for the endpoint.
$08000000 constant OTG_FS_OTG_DOEPCTL8_INT_BULK_SNAK                \ Set NAK A write to this bit sets the NAK bit for the endpoint. Using this bit, the application can control the transmission of NAK handshakes on an endpoint. The core can also set this bit for OUT endpoints on a transfer completed interrupt, or after a SETUP is received on the endpoint.
$10000000 constant OTG_FS_OTG_DOEPCTL8_INT_BULK_SD0PID              \ Set DATA0 PID Applies to interrupt/bulk OUT endpoints only. Writing to this field sets the endpoint data PID (DPID) field in this register to DATA0.
$20000000 constant OTG_FS_OTG_DOEPCTL8_INT_BULK_SD1PID              \ Set DATA1 PID Writing to this field sets the endpoint data PID (DPID) field in this register to DATA1.
$40000000 constant OTG_FS_OTG_DOEPCTL8_INT_BULK_EPDIS               \ Endpoint disable The application sets this bit to stop transmitting/receiving data on an endpoint, even before the transfer for that endpoint is complete. The application must wait for the endpoint disabled interrupt before treating the endpoint as disabled. The core clears this bit before setting the endpoint disabled interrupt. The application must set this bit only if endpoint enable is already set for this endpoint.
$80000000 constant OTG_FS_OTG_DOEPCTL8_INT_BULK_EPENA               \ Endpoint enable Applies to IN and OUT endpoints. The application sets this bit to start transmitting data on an endpoint. The core clears this bit before setting any of the following interrupts on this endpoint: SETUP phase done Endpoint disabled Transfer completed


\
\ @brief OTG device OUT endpoint 8 control register
\ Address offset: 0xC00
\ Reset value: 0x00000000
\

$000007ff constant OTG_FS_OTG_DOEPCTL8_ISO_MPSIZ                    \ Maximum packet size The application must program this field with the maximum packet size for the current logical endpoint. This value is in bytes.
$00008000 constant OTG_FS_OTG_DOEPCTL8_ISO_USBAEP                   \ USB active endpoint Indicates whether this endpoint is active in the current configuration and interface. The core clears this bit for all endpoints (other than EP 0) after detecting a USB reset. After receiving the SetConfiguration and SetInterface commands, the application must program endpoint registers accordingly and set this bit.
$00010000 constant OTG_FS_OTG_DOEPCTL8_ISO_EONUM                    \ Even/odd frame Applies to isochronous OUT endpoints only. Indicates the frame number in which the core transmits/receives isochronous data for this endpoint. The application must program the even/odd frame number in which it intends to transmit/receive isochronous data for this endpoint using the SEVNFRM and SODDFRM fields in this register.
$00020000 constant OTG_FS_OTG_DOEPCTL8_ISO_NAKSTS                   \ NAK status Indicates the following: When either the application or the core sets this bit: The core stops receiving any data on an OUT endpoint, even if there is space in the Rx FIFO to accommodate the incoming packet. Irrespective of this bits setting, the core always responds to SETUP data packets with an ACK handshake.
$000c0000 constant OTG_FS_OTG_DOEPCTL8_ISO_EPTYP                    \ Endpoint type This is the transfer type supported by this logical endpoint.
$00100000 constant OTG_FS_OTG_DOEPCTL8_ISO_SNPM                     \ Snoop mode This bit configures the endpoint to Snoop mode. In Snoop mode, the core does not check the correctness of OUT packets before transferring them to application memory.
$00200000 constant OTG_FS_OTG_DOEPCTL8_ISO_STALL                    \ STALL handshake Applies to non-control, non-isochronous OUT endpoints only (access type is rw). The application sets this bit to stall all tokens from the USB host to this endpoint. If a NAK bit, Global IN NAK, or Global OUT NAK is set along with this bit, the STALL bit takes priority. Only the application can clear this bit, never the core. Applies to control endpoints only (access type is rs). The application can only set this bit, and the core clears it, when a SETUP token is received for this endpoint. If a NAK bit, Global IN NAK, or Global OUT NAK is set along with this bit, the STALL bit takes priority. Irrespective of this bits setting, the core always responds to SETUP data packets with an ACK handshake.
$04000000 constant OTG_FS_OTG_DOEPCTL8_ISO_CNAK                     \ Clear NAK A write to this bit clears the NAK bit for the endpoint.
$08000000 constant OTG_FS_OTG_DOEPCTL8_ISO_SNAK                     \ Set NAK A write to this bit sets the NAK bit for the endpoint. Using this bit, the application can control the transmission of NAK handshakes on an endpoint. The core can also set this bit for OUT endpoints on a transfer completed interrupt, or after a SETUP is received on the endpoint.
$10000000 constant OTG_FS_OTG_DOEPCTL8_ISO_SEVNFRM                  \ Set even frame Applies to isochronous OUT endpoints only. Writing to this field sets the Even/Odd frame (EONUM) field to even frame.
$20000000 constant OTG_FS_OTG_DOEPCTL8_ISO_SODDFRM                  \ Set odd frame Applies to isochronous IN and OUT endpoints only. Writing to this field sets the Even/Odd frame (EONUM) field to odd frame.
$40000000 constant OTG_FS_OTG_DOEPCTL8_ISO_EPDIS                    \ Endpoint disable The application sets this bit to stop transmitting/receiving data on an endpoint, even before the transfer for that endpoint is complete. The application must wait for the endpoint disabled interrupt before treating the endpoint as disabled. The core clears this bit before setting the endpoint disabled interrupt. The application must set this bit only if endpoint enable is already set for this endpoint.
$80000000 constant OTG_FS_OTG_DOEPCTL8_ISO_EPENA                    \ Endpoint enable Applies to IN and OUT endpoints. The application sets this bit to start transmitting data on an endpoint. The core clears this bit before setting any of the following interrupts on this endpoint: SETUP phase done Endpoint disabled Transfer completed


\
\ @brief OTG device OUT endpoint 8 interrupt register
\ Address offset: 0xC08
\ Reset value: 0x00000080
\

$00000001 constant OTG_FS_OTG_DOEPINT8_XFRC                         \ Transfer completed interrupt This field indicates that the programmed transfer is complete on the AHB as well as on the USB, for this endpoint.
$00000002 constant OTG_FS_OTG_DOEPINT8_EPDISD                       \ Endpoint disabled interrupt This bit indicates that the endpoint is disabled per the applications request.
$00000004 constant OTG_FS_OTG_DOEPINT8_AHBERR                       \ AHB error This is generated only in internal DMA mode when there is an AHB error during an AHB read/write. The application can read the corresponding endpoint DMA address register to get the error address.
$00000008 constant OTG_FS_OTG_DOEPINT8_STUP                         \ SETUP phase done Applies to control OUT endpoint only.Indicates that the SETUP phase for the control endpoint is complete and no more back-to-back SETUP packets were received for the current control transfer. On this interrupt, the application can decode the received SETUP data packet.
$00000010 constant OTG_FS_OTG_DOEPINT8_OTEPDIS                      \ OUT token received when endpoint disabled Applies only to control OUT endpoints. Indicates that an OUT token was received when the endpoint was not yet enabled. This interrupt is asserted on the endpoint for which the OUT token was received.
$00000020 constant OTG_FS_OTG_DOEPINT8_STSPHSRX                     \ Status phase received for control write This interrupt is valid only for control OUT endpoints. This interrupt is generated only after OTG_HS has transferred all the data that the host has sent during the data phase of a control write transfer, to the system memory buffer. The interrupt indicates to the application that the host has switched from data phase to the status phase of a control write transfer. The application can use this interrupt to ACK or STALL the status phase, after it has decoded the data phase.
$00000040 constant OTG_FS_OTG_DOEPINT8_B2BSTUP                      \ Back-to-back SETUP packets received Applies to control OUT endpoint only. This bit indicates that the core has received more than three back-to-back SETUP packets for this particular endpoint.
$00000100 constant OTG_FS_OTG_DOEPINT8_OUTPKTERR                    \ OUT packet error This interrupt is asserted when the core detects an overflow or a CRC error for an OUT packet. This interrupt is valid only when thresholding is enabled.
$00001000 constant OTG_FS_OTG_DOEPINT8_BERR                         \ Babble error interrupt The core generates this interrupt when babble is received for the endpoint.
$00002000 constant OTG_FS_OTG_DOEPINT8_NAK                          \ NAK input The core generates this interrupt when a NAK is transmitted or received by the device. In case of isochronous IN endpoints the interrupt gets generated when a zero length packet is transmitted due to unavailability of data in the Tx FIFO.
$00004000 constant OTG_FS_OTG_DOEPINT8_NYET                         \ NYET interrupt This interrupt is generated when a NYET response is transmitted for a non isochronous OUT endpoint.
$00008000 constant OTG_FS_OTG_DOEPINT8_STPKTRX                      \ Setup packet received Applicable for control OUT endpoints in only in the Buffer DMA Mode. Set by the OTG_HS, this bit indicates that this buffer holds 8 bytes of setup data. There is only one setup packet per buffer. On receiving a setup packet, the OTG_HS closes the buffer and disables the corresponding endpoint after SETUP_COMPLETE status is seen in the Rx FIFO. OTG_HS puts a SETUP_COMPLETE status into the Rx FIFO when it sees the first IN or OUT token after the SETUP packet for that particular endpoint. The application must then re-enable the endpoint to receive any OUT data for the control transfer and reprogram the buffer start address. Because of the above behavior, OTG_HS can receive any number of back to back setup packets and one buffer for every setup packet is used.


\
\ @brief OTG device OUT endpoint 8 transfer size register
\ Address offset: 0xC10
\ Reset value: 0x00000000
\

$0007ffff constant OTG_FS_OTG_DOEPTSIZ8_XFRSIZ                      \ Transfer size This field contains the transfer size in bytes for the current endpoint. The core only interrupts the application after it has exhausted the transfer size amount of data. The transfer size can be set to the maximum packet size of the endpoint, to be interrupted at the end of each packet. The core decrements this field every time a packet is read from the Rx FIFO and written to the external memory.
$1ff80000 constant OTG_FS_OTG_DOEPTSIZ8_PKTCNT                      \ Packet count Indicates the total number of USB packets that constitute the transfer size amount of data for this endpoint. This field is decremented every time a packet (maximum size or short packet) is written to the Rx FIFO.
$60000000 constant OTG_FS_OTG_DOEPTSIZ8_RXDPID                      \ Received data PID This is the data PID received in the last packet for this endpoint. STUPCNT[1:0]: SETUP packet count This field specifies the number of back-to-back SETUP data packets the endpoint can receive.


\
\ @brief OTG device OUT endpoint 8 DMA address register
\ Address offset: 0xC14
\ Reset value: 0x00000000
\

$00000000 constant OTG_FS_OTG_DOEPDMA8_DMAADDR                      \ DMA Address This field holds the start address in the external memory from which the data for the endpoint must be fetched. This register is incremented on every AHB transaction.


\
\ @brief OTG power and clock gating control register
\ Address offset: 0xE00
\ Reset value: 0x200B8000
\

$00000001 constant OTG_FS_OTG_PCGCCTL_STPPCLK                       \ Stop PHY clock The application sets this bit to stop the PHY clock when the USB is suspended, the session is not valid, or the device is disconnected. The application clears this bit when the USB is resumed or a new session starts.
$00000002 constant OTG_FS_OTG_PCGCCTL_GATEHCLK                      \ Gate HCLK The application sets this bit to gate HCLK to modules other than the AHB Slave and Master and wakeup logic when the USB is suspended or the session is not valid. The application clears this bit when the USB is resumed or a new session starts.
$00000010 constant OTG_FS_OTG_PCGCCTL_PHYSUSP                       \ PHY suspended Indicates that the PHY has been suspended. This bit is updated once the PHY is suspended after the application has set the STPPCLK bit.
$00000020 constant OTG_FS_OTG_PCGCCTL_ENL1GTG                       \ Enable sleep clock gating When this bit is set, core internal clock gating is enabled in Sleep state if the core cannot assert utmi_l1_suspend_n. When this bit is not set, the PHY clock is not gated in Sleep state.
$00000040 constant OTG_FS_OTG_PCGCCTL_PHYSLEEP                      \ PHY in Sleep This bit indicates that the PHY is in the Sleep state.
$00000080 constant OTG_FS_OTG_PCGCCTL_SUSP                          \ Deep Sleep This bit indicates that the PHY is in Deep Sleep when in L1 state.


\
\ @brief OTG power and clock gating control register 1
\ Address offset: 0xE04
\ Reset value: 0x00000000
\

$00000001 constant OTG_FS_OTG_PCGCCTL1_GATEEN                       \ Enable active clock gating The application programs GATEEN to enable Active Clock Gating feature for the PHY and AHB clocks.
$00000006 constant OTG_FS_OTG_PCGCCTL1_CNTGATECLK                   \ Counter for clock gating Indicates to the controller how many PHY Clock cycles and AHB Clock cycles of 'IDLE' (no activity) the controller waits for before Gating the respective PHY and AHB clocks internal to the controller.
$00000008 constant OTG_FS_OTG_PCGCCTL1_RAMGATEEN                    \ Enable RAM clock gating Enable gating of the FIFO RAM.


\
\ @brief USB OTG FS global interrupt
\
$40080000 constant OTG_FS_OTG_GOTGCTL  \ offset: 0x00 : OTG control and status register
$40080004 constant OTG_FS_OTG_GOTGINT  \ offset: 0x04 : OTG interrupt register
$40080008 constant OTG_FS_OTG_GAHBCFG  \ offset: 0x08 : OTG AHB configuration register
$4008000c constant OTG_FS_OTG_GUSBCFG  \ offset: 0x0C : OTG USB configuration register
$40080010 constant OTG_FS_OTG_GRSTCTL  \ offset: 0x10 : OTG reset register
$40080014 constant OTG_FS_OTG_GINTSTS_HOST  \ offset: 0x14 : OTG core interrupt register
$40080014 constant OTG_FS_OTG_GINTSTS_DEVICE  \ offset: 0x14 : OTG core interrupt register
$40080018 constant OTG_FS_OTG_GINTMSK_HOST  \ offset: 0x18 : OTG interrupt mask register
$40080018 constant OTG_FS_OTG_GINTMSK_DEVICE  \ offset: 0x18 : OTG interrupt mask register
$4008001c constant OTG_FS_OTG_GRXSTSR_DEVICE  \ offset: 0x1C : OTG receive status debug read register
$4008001c constant OTG_FS_OTG_GRXSTSR_HOST  \ offset: 0x1C : OTG receive status debug read register
$40080020 constant OTG_FS_OTG_GRXSTSP_DEVICE  \ offset: 0x20 : OTG status read and pop registers
$40080020 constant OTG_FS_OTG_GRXSTSP_HOST  \ offset: 0x20 : OTG status read and pop registers
$40080024 constant OTG_FS_OTG_GRXFSIZ  \ offset: 0x24 : OTG receive FIFO size register
$40080028 constant OTG_FS_OTG_HNPTXFSIZ_HOST  \ offset: 0x28 : OTG host non-periodic transmit FIFO size register [alternate]
$40080028 constant OTG_FS_OTG_HNPTXFSIZ_DEVICE  \ offset: 0x28 : OTG host non-periodic transmit FIFO size register [alternate]
$4008002c constant OTG_FS_OTG_HNPTXSTS  \ offset: 0x2C : OTG non-periodic transmit FIFO/queue status register
$40080038 constant OTG_FS_OTG_GCCFG  \ offset: 0x38 : OTG general core configuration register
$4008003c constant OTG_FS_OTG_CID  \ offset: 0x3C : OTG core ID register
$40080054 constant OTG_FS_OTG_GLPMCFG  \ offset: 0x54 : OTG core LPM configuration register
$40080100 constant OTG_FS_OTG_HPTXFSIZ  \ offset: 0x100 : OTG host periodic transmit FIFO size register
$40080104 constant OTG_FS_OTG_DIEPTXF1  \ offset: 0x104 : OTG device IN endpoint transmit FIFO 1 size register
$40080108 constant OTG_FS_OTG_DIEPTXF2  \ offset: 0x108 : OTG device IN endpoint transmit FIFO 2 size register
$4008010c constant OTG_FS_OTG_DIEPTXF3  \ offset: 0x10C : OTG device IN endpoint transmit FIFO 3 size register
$40080110 constant OTG_FS_OTG_DIEPTXF4  \ offset: 0x110 : OTG device IN endpoint transmit FIFO 4 size register
$40080114 constant OTG_FS_OTG_DIEPTXF5  \ offset: 0x114 : OTG device IN endpoint transmit FIFO 5 size register
$40080118 constant OTG_FS_OTG_DIEPTXF6  \ offset: 0x118 : OTG device IN endpoint transmit FIFO 6 size register
$4008011c constant OTG_FS_OTG_DIEPTXF7  \ offset: 0x11C : OTG device IN endpoint transmit FIFO 7 size register
$40080120 constant OTG_FS_OTG_DIEPTXF8  \ offset: 0x120 : OTG device IN endpoint transmit FIFO 8 size register
$40080400 constant OTG_FS_OTG_HCFG  \ offset: 0x400 : OTG host configuration register
$40080404 constant OTG_FS_OTG_HFIR  \ offset: 0x404 : OTG host frame interval register
$40080408 constant OTG_FS_OTG_HFNUM  \ offset: 0x408 : OTG host frame number/frame time remaining register
$40080410 constant OTG_FS_OTG_HPTXSTS  \ offset: 0x410 : OTG_Host periodic transmit FIFO/queue status register
$40080414 constant OTG_FS_OTG_HAINT  \ offset: 0x414 : OTG host all channels interrupt register
$40080418 constant OTG_FS_OTG_HAINTMSK  \ offset: 0x418 : OTG host all channels interrupt mask register
$40080440 constant OTG_FS_OTG_HPRT  \ offset: 0x440 : OTG host port control and status register
$40080500 constant OTG_FS_OTG_HCCHAR0  \ offset: 0x500 : OTG host channel 0 characteristics register
$40080504 constant OTG_FS_OTG_HCSPLT0  \ offset: 0x504 : OTG host channel 0 split control register
$40080508 constant OTG_FS_OTG_HCINT0  \ offset: 0x508 : OTG host channel 0 interrupt register
$4008050c constant OTG_FS_OTG_HCINTMSK0  \ offset: 0x50C : OTG host channel 0 interrupt mask register
$40080510 constant OTG_FS_OTG_HCTSIZ0  \ offset: 0x510 : OTG host channel 0 transfer size register
$40080514 constant OTG_FS_OTG_HCDMA0  \ offset: 0x514 : OTG host channel 0 DMA address register
$40080520 constant OTG_FS_OTG_HCCHAR1  \ offset: 0x520 : OTG host channel 1 characteristics register
$40080524 constant OTG_FS_OTG_HCSPLT1  \ offset: 0x524 : OTG host channel 1 split control register
$40080528 constant OTG_FS_OTG_HCINT1  \ offset: 0x528 : OTG host channel 1 interrupt register
$4008052c constant OTG_FS_OTG_HCINTMSK1  \ offset: 0x52C : OTG host channel 1 interrupt mask register
$40080530 constant OTG_FS_OTG_HCTSIZ1  \ offset: 0x530 : OTG host channel 1 transfer size register
$40080534 constant OTG_FS_OTG_HCDMA1  \ offset: 0x534 : OTG host channel 1 DMA address register
$40080540 constant OTG_FS_OTG_HCCHAR2  \ offset: 0x540 : OTG host channel 2 characteristics register
$40080544 constant OTG_FS_OTG_HCSPLT2  \ offset: 0x544 : OTG host channel 2 split control register
$40080548 constant OTG_FS_OTG_HCINT2  \ offset: 0x548 : OTG host channel 2 interrupt register
$4008054c constant OTG_FS_OTG_HCINTMSK2  \ offset: 0x54C : OTG host channel 2 interrupt mask register
$40080550 constant OTG_FS_OTG_HCTSIZ2  \ offset: 0x550 : OTG host channel 2 transfer size register
$40080554 constant OTG_FS_OTG_HCDMA2  \ offset: 0x554 : OTG host channel 2 DMA address register
$40080560 constant OTG_FS_OTG_HCCHAR3  \ offset: 0x560 : OTG host channel 3 characteristics register
$40080564 constant OTG_FS_OTG_HCSPLT3  \ offset: 0x564 : OTG host channel 3 split control register
$40080568 constant OTG_FS_OTG_HCINT3  \ offset: 0x568 : OTG host channel 3 interrupt register
$4008056c constant OTG_FS_OTG_HCINTMSK3  \ offset: 0x56C : OTG host channel 3 interrupt mask register
$40080570 constant OTG_FS_OTG_HCTSIZ3  \ offset: 0x570 : OTG host channel 3 transfer size register
$40080574 constant OTG_FS_OTG_HCDMA3  \ offset: 0x574 : OTG host channel 3 DMA address register
$40080580 constant OTG_FS_OTG_HCCHAR4  \ offset: 0x580 : OTG host channel 4 characteristics register
$40080584 constant OTG_FS_OTG_HCSPLT4  \ offset: 0x584 : OTG host channel 4 split control register
$40080588 constant OTG_FS_OTG_HCINT4  \ offset: 0x588 : OTG host channel 4 interrupt register
$4008058c constant OTG_FS_OTG_HCINTMSK4  \ offset: 0x58C : OTG host channel 4 interrupt mask register
$40080590 constant OTG_FS_OTG_HCTSIZ4  \ offset: 0x590 : OTG host channel 4 transfer size register
$40080594 constant OTG_FS_OTG_HCDMA4  \ offset: 0x594 : OTG host channel 4 DMA address register
$400805a0 constant OTG_FS_OTG_HCCHAR5  \ offset: 0x5A0 : OTG host channel 5 characteristics register
$400805a4 constant OTG_FS_OTG_HCSPLT5  \ offset: 0x5A4 : OTG host channel 5 split control register
$400805a8 constant OTG_FS_OTG_HCINT5  \ offset: 0x5A8 : OTG host channel 5 interrupt register
$400805ac constant OTG_FS_OTG_HCINTMSK5  \ offset: 0x5AC : OTG host channel 5 interrupt mask register
$400805b0 constant OTG_FS_OTG_HCTSIZ5  \ offset: 0x5B0 : OTG host channel 5 transfer size register
$400805b4 constant OTG_FS_OTG_HCDMA5  \ offset: 0x5B4 : OTG host channel 5 DMA address register
$400805c0 constant OTG_FS_OTG_HCCHAR6  \ offset: 0x5C0 : OTG host channel 6 characteristics register
$400805c4 constant OTG_FS_OTG_HCSPLT6  \ offset: 0x5C4 : OTG host channel 6 split control register
$400805c8 constant OTG_FS_OTG_HCINT6  \ offset: 0x5C8 : OTG host channel 6 interrupt register
$400805cc constant OTG_FS_OTG_HCINTMSK6  \ offset: 0x5CC : OTG host channel 6 interrupt mask register
$400805d0 constant OTG_FS_OTG_HCTSIZ6  \ offset: 0x5D0 : OTG host channel 6 transfer size register
$400805d4 constant OTG_FS_OTG_HCDMA6  \ offset: 0x5D4 : OTG host channel 6 DMA address register
$400805e0 constant OTG_FS_OTG_HCCHAR7  \ offset: 0x5E0 : OTG host channel 7 characteristics register
$400805e4 constant OTG_FS_OTG_HCSPLT7  \ offset: 0x5E4 : OTG host channel 7 split control register
$400805e8 constant OTG_FS_OTG_HCINT7  \ offset: 0x5E8 : OTG host channel 7 interrupt register
$400805ec constant OTG_FS_OTG_HCINTMSK7  \ offset: 0x5EC : OTG host channel 7 interrupt mask register
$400805f0 constant OTG_FS_OTG_HCTSIZ7  \ offset: 0x5F0 : OTG host channel 7 transfer size register
$400805f4 constant OTG_FS_OTG_HCDMA7  \ offset: 0x5F4 : OTG host channel 7 DMA address register
$40080600 constant OTG_FS_OTG_HCCHAR8  \ offset: 0x600 : OTG host channel 8 characteristics register
$40080604 constant OTG_FS_OTG_HCSPLT8  \ offset: 0x604 : OTG host channel 8 split control register
$40080608 constant OTG_FS_OTG_HCINT8  \ offset: 0x608 : OTG host channel 8 interrupt register
$4008060c constant OTG_FS_OTG_HCINTMSK8  \ offset: 0x60C : OTG host channel 8 interrupt mask register
$40080610 constant OTG_FS_OTG_HCTSIZ8  \ offset: 0x610 : OTG host channel 8 transfer size register
$40080614 constant OTG_FS_OTG_HCDMA8  \ offset: 0x614 : OTG host channel 8 DMA address register
$40080620 constant OTG_FS_OTG_HCCHAR9  \ offset: 0x620 : OTG host channel 9 characteristics register
$40080624 constant OTG_FS_OTG_HCSPLT9  \ offset: 0x624 : OTG host channel 9 split control register
$40080628 constant OTG_FS_OTG_HCINT9  \ offset: 0x628 : OTG host channel 9 interrupt register
$4008062c constant OTG_FS_OTG_HCINTMSK9  \ offset: 0x62C : OTG host channel 9 interrupt mask register
$40080630 constant OTG_FS_OTG_HCTSIZ9  \ offset: 0x630 : OTG host channel 9 transfer size register
$40080634 constant OTG_FS_OTG_HCDMA9  \ offset: 0x634 : OTG host channel 9 DMA address register
$40080640 constant OTG_FS_OTG_HCCHAR10  \ offset: 0x640 : OTG host channel 10 characteristics register
$40080644 constant OTG_FS_OTG_HCSPLT10  \ offset: 0x644 : OTG host channel 10 split control register
$40080648 constant OTG_FS_OTG_HCINT10  \ offset: 0x648 : OTG host channel 10 interrupt register
$4008064c constant OTG_FS_OTG_HCINTMSK10  \ offset: 0x64C : OTG host channel 10 interrupt mask register
$40080650 constant OTG_FS_OTG_HCTSIZ10  \ offset: 0x650 : OTG host channel 10 transfer size register
$40080654 constant OTG_FS_OTG_HCDMA10  \ offset: 0x654 : OTG host channel 10 DMA address register
$40080660 constant OTG_FS_OTG_HCCHAR11  \ offset: 0x660 : OTG host channel 11 characteristics register
$40080664 constant OTG_FS_OTG_HCSPLT11  \ offset: 0x664 : OTG host channel 11 split control register
$40080668 constant OTG_FS_OTG_HCINT11  \ offset: 0x668 : OTG host channel 11 interrupt register
$4008066c constant OTG_FS_OTG_HCINTMSK11  \ offset: 0x66C : OTG host channel 11 interrupt mask register
$40080670 constant OTG_FS_OTG_HCTSIZ11  \ offset: 0x670 : OTG host channel 11 transfer size register
$40080674 constant OTG_FS_OTG_HCDMA11  \ offset: 0x674 : OTG host channel 11 DMA address register
$40080680 constant OTG_FS_OTG_HCCHAR12  \ offset: 0x680 : OTG host channel 12 characteristics register
$40080684 constant OTG_FS_OTG_HCSPLT12  \ offset: 0x684 : OTG host channel 12 split control register
$40080688 constant OTG_FS_OTG_HCINT12  \ offset: 0x688 : OTG host channel 12 interrupt register
$4008068c constant OTG_FS_OTG_HCINTMSK12  \ offset: 0x68C : OTG host channel 12 interrupt mask register
$40080690 constant OTG_FS_OTG_HCTSIZ12  \ offset: 0x690 : OTG host channel 12 transfer size register
$40080694 constant OTG_FS_OTG_HCDMA12  \ offset: 0x694 : OTG host channel 12 DMA address register
$400806a0 constant OTG_FS_OTG_HCCHAR13  \ offset: 0x6A0 : OTG host channel 13 characteristics register
$400806a4 constant OTG_FS_OTG_HCSPLT13  \ offset: 0x6A4 : OTG host channel 13 split control register
$400806a8 constant OTG_FS_OTG_HCINT13  \ offset: 0x6A8 : OTG host channel 13 interrupt register
$400806ac constant OTG_FS_OTG_HCINTMSK13  \ offset: 0x6AC : OTG host channel 13 interrupt mask register
$400806b0 constant OTG_FS_OTG_HCTSIZ13  \ offset: 0x6B0 : OTG host channel 13 transfer size register
$400806b4 constant OTG_FS_OTG_HCDMA13  \ offset: 0x6B4 : OTG host channel 13 DMA address register
$400806c0 constant OTG_FS_OTG_HCCHAR14  \ offset: 0x6C0 : OTG host channel 14 characteristics register
$400806c4 constant OTG_FS_OTG_HCSPLT14  \ offset: 0x6C4 : OTG host channel 14 split control register
$400806c8 constant OTG_FS_OTG_HCINT14  \ offset: 0x6C8 : OTG host channel 14 interrupt register
$400806cc constant OTG_FS_OTG_HCINTMSK14  \ offset: 0x6CC : OTG host channel 14 interrupt mask register
$400806d0 constant OTG_FS_OTG_HCTSIZ14  \ offset: 0x6D0 : OTG host channel 14 transfer size register
$400806d4 constant OTG_FS_OTG_HCDMA14  \ offset: 0x6D4 : OTG host channel 14 DMA address register
$400806e0 constant OTG_FS_OTG_HCCHAR15  \ offset: 0x6E0 : OTG host channel 15 characteristics register
$400806e4 constant OTG_FS_OTG_HCSPLT15  \ offset: 0x6E4 : OTG host channel 15 split control register
$400806e8 constant OTG_FS_OTG_HCINT15  \ offset: 0x6E8 : OTG host channel 15 interrupt register
$400806ec constant OTG_FS_OTG_HCINTMSK15  \ offset: 0x6EC : OTG host channel 15 interrupt mask register
$400806f0 constant OTG_FS_OTG_HCTSIZ15  \ offset: 0x6F0 : OTG host channel 15 transfer size register
$400806f4 constant OTG_FS_OTG_HCDMA15  \ offset: 0x6F4 : OTG host channel 15 DMA address register
$40080800 constant OTG_FS_OTG_DCFG  \ offset: 0x800 : OTG device configuration register
$40080804 constant OTG_FS_OTG_DCTL  \ offset: 0x804 : OTG device control register
$40080808 constant OTG_FS_OTG_DSTS  \ offset: 0x808 : OTG device status register
$40080810 constant OTG_FS_OTG_DIEPMSK  \ offset: 0x810 : OTG device IN endpoint common interrupt mask register
$40080814 constant OTG_FS_OTG_DOEPMSK  \ offset: 0x814 : OTG device OUT endpoint common interrupt mask register
$40080818 constant OTG_FS_OTG_DAINT  \ offset: 0x818 : OTG device all endpoints interrupt register
$4008081c constant OTG_FS_OTG_DAINTMSK  \ offset: 0x81C : OTG all endpoints interrupt mask register
$40080830 constant OTG_FS_OTG_DTHRCTL  \ offset: 0x830 : OTG device threshold control register
$40080834 constant OTG_FS_OTG_DIEPEMPMSK  \ offset: 0x834 : OTG device IN endpoint FIFO empty interrupt mask register
$40080900 constant OTG_FS_OTG_DIEPCTL0_INT_BULK  \ offset: 0x900 : OTG device IN endpoint 0 control register
$40080900 constant OTG_FS_OTG_DIEPCTL0_ISO  \ offset: 0x900 : OTG device IN endpoint 0 control register
$40080908 constant OTG_FS_OTG_DIEPINT0  \ offset: 0x908 : OTG device IN endpoint 0 interrupt register
$40080910 constant OTG_FS_OTG_DIEPTSIZ0  \ offset: 0x910 : OTG device IN endpoint 0 transfer size register
$40080914 constant OTG_FS_OTG_DIEPDMA0  \ offset: 0x914 : OTG device IN endpoint 0 DMA address register
$40080918 constant OTG_FS_OTG_DTXFSTS0  \ offset: 0x918 : OTG device IN endpoint transmit FIFO status register
$40080920 constant OTG_FS_OTG_DIEPCTL1_INT_BULK  \ offset: 0x920 : OTG device IN endpoint 1 control register
$40080920 constant OTG_FS_OTG_DIEPCTL1_ISO  \ offset: 0x920 : OTG device IN endpoint 1 control register
$40080928 constant OTG_FS_OTG_DIEPINT1  \ offset: 0x928 : OTG device IN endpoint 1 interrupt register
$40080930 constant OTG_FS_OTG_DIEPTSIZ1  \ offset: 0x930 : OTG device IN endpoint 1 transfer size register
$40080934 constant OTG_FS_OTG_DIEPDMA1  \ offset: 0x934 : OTG device IN endpoint 1 DMA address register
$40080938 constant OTG_FS_OTG_DTXFSTS1  \ offset: 0x938 : OTG device IN endpoint transmit FIFO status register
$40080940 constant OTG_FS_OTG_DIEPCTL2_INT_BULK  \ offset: 0x940 : OTG device IN endpoint 2 control register
$40080940 constant OTG_FS_OTG_DIEPCTL2_ISO  \ offset: 0x940 : OTG device IN endpoint 2 control register
$40080948 constant OTG_FS_OTG_DIEPINT2  \ offset: 0x948 : OTG device IN endpoint 2 interrupt register
$40080950 constant OTG_FS_OTG_DIEPTSIZ2  \ offset: 0x950 : OTG device IN endpoint 2 transfer size register
$40080954 constant OTG_FS_OTG_DIEPDMA2  \ offset: 0x954 : OTG device IN endpoint 2 DMA address register
$40080958 constant OTG_FS_OTG_DTXFSTS2  \ offset: 0x958 : OTG device IN endpoint transmit FIFO status register
$40080960 constant OTG_FS_OTG_DIEPCTL3_INT_BULK  \ offset: 0x960 : OTG device IN endpoint 3 control register
$40080960 constant OTG_FS_OTG_DIEPCTL3_ISO  \ offset: 0x960 : OTG device IN endpoint 3 control register
$40080968 constant OTG_FS_OTG_DIEPINT3  \ offset: 0x968 : OTG device IN endpoint 3 interrupt register
$40080970 constant OTG_FS_OTG_DIEPTSIZ3  \ offset: 0x970 : OTG device IN endpoint 3 transfer size register
$40080974 constant OTG_FS_OTG_DIEPDMA3  \ offset: 0x974 : OTG device IN endpoint 3 DMA address register
$40080978 constant OTG_FS_OTG_DTXFSTS3  \ offset: 0x978 : OTG device IN endpoint transmit FIFO status register
$40080980 constant OTG_FS_OTG_DIEPCTL4_INT_BULK  \ offset: 0x980 : OTG device IN endpoint 4 control register
$40080980 constant OTG_FS_OTG_DIEPCTL4_ISO  \ offset: 0x980 : OTG device IN endpoint 4 control register
$40080988 constant OTG_FS_OTG_DIEPINT4  \ offset: 0x988 : OTG device IN endpoint 4 interrupt register
$40080990 constant OTG_FS_OTG_DIEPTSIZ4  \ offset: 0x990 : OTG device IN endpoint 4 transfer size register
$40080994 constant OTG_FS_OTG_DIEPDMA4  \ offset: 0x994 : OTG device IN endpoint 4 DMA address register
$40080998 constant OTG_FS_OTG_DTXFSTS4  \ offset: 0x998 : OTG device IN endpoint transmit FIFO status register
$400809a0 constant OTG_FS_OTG_DIEPCTL5_INT_BULK  \ offset: 0x9A0 : OTG device IN endpoint 5 control register
$400809a0 constant OTG_FS_OTG_DIEPCTL5_ISO  \ offset: 0x9A0 : OTG device IN endpoint 5 control register
$400809a8 constant OTG_FS_OTG_DIEPINT5  \ offset: 0x9A8 : OTG device IN endpoint 5 interrupt register
$400809b0 constant OTG_FS_OTG_DIEPTSIZ5  \ offset: 0x9B0 : OTG device IN endpoint 5 transfer size register
$400809b4 constant OTG_FS_OTG_DIEPDMA5  \ offset: 0x9B4 : OTG device IN endpoint 5 DMA address register
$400809b8 constant OTG_FS_OTG_DTXFSTS5  \ offset: 0x9B8 : OTG device IN endpoint transmit FIFO status register
$400809c0 constant OTG_FS_OTG_DIEPCTL6_INT_BULK  \ offset: 0x9C0 : OTG device IN endpoint 6 control register
$400809c0 constant OTG_FS_OTG_DIEPCTL6_ISO  \ offset: 0x9C0 : OTG device IN endpoint 6 control register
$400809c8 constant OTG_FS_OTG_DIEPINT6  \ offset: 0x9C8 : OTG device IN endpoint 6 interrupt register
$400809d0 constant OTG_FS_OTG_DIEPTSIZ6  \ offset: 0x9D0 : OTG device IN endpoint 6 transfer size register
$400809d4 constant OTG_FS_OTG_DIEPDMA6  \ offset: 0x9D4 : OTG device IN endpoint 6 DMA address register
$400809d8 constant OTG_FS_OTG_DTXFSTS6  \ offset: 0x9D8 : OTG device IN endpoint transmit FIFO status register
$400809e0 constant OTG_FS_OTG_DIEPCTL7_INT_BULK  \ offset: 0x9E0 : OTG device IN endpoint 7 control register
$400809e0 constant OTG_FS_OTG_DIEPCTL7_ISO  \ offset: 0x9E0 : OTG device IN endpoint 7 control register
$400809e8 constant OTG_FS_OTG_DIEPINT7  \ offset: 0x9E8 : OTG device IN endpoint 7 interrupt register
$400809f0 constant OTG_FS_OTG_DIEPTSIZ7  \ offset: 0x9F0 : OTG device IN endpoint 7 transfer size register
$400809f4 constant OTG_FS_OTG_DIEPDMA7  \ offset: 0x9F4 : OTG device IN endpoint 7 DMA address register
$400809f8 constant OTG_FS_OTG_DTXFSTS7  \ offset: 0x9F8 : OTG device IN endpoint transmit FIFO status register
$40080a00 constant OTG_FS_OTG_DIEPCTL8_INT_BULK  \ offset: 0xA00 : OTG device IN endpoint 8 control register
$40080a00 constant OTG_FS_OTG_DIEPCTL8_ISO  \ offset: 0xA00 : OTG device IN endpoint 8 control register
$40080a08 constant OTG_FS_OTG_DIEPINT8  \ offset: 0xA08 : OTG device IN endpoint 8 interrupt register
$40080a10 constant OTG_FS_OTG_DIEPTSIZ8  \ offset: 0xA10 : OTG device IN endpoint 8 transfer size register
$40080a14 constant OTG_FS_OTG_DIEPDMA8  \ offset: 0xA14 : OTG device IN endpoint 8 DMA address register
$40080a18 constant OTG_FS_OTG_DTXFSTS8  \ offset: 0xA18 : OTG device IN endpoint transmit FIFO status register
$40080b00 constant OTG_FS_OTG_DOEPCTL0  \ offset: 0xB00 : OTG device control OUT endpoint 0 control register
$40080b08 constant OTG_FS_OTG_DOEPINT0  \ offset: 0xB08 : OTG device OUT endpoint 0 interrupt register
$40080b10 constant OTG_FS_OTG_DOEPTSIZ0  \ offset: 0xB10 : OTG device OUT endpoint 0 transfer size register
$40080b14 constant OTG_FS_OTG_DOEPDMA0  \ offset: 0xB14 : OTG device OUT endpoint 0 DMA address register
$40080b20 constant OTG_FS_OTG_DOEPCTL1_INT_BULK  \ offset: 0xB20 : OTG device OUT endpoint 1 control register
$40080b20 constant OTG_FS_OTG_DOEPCTL1_ISO  \ offset: 0xB20 : OTG device OUT endpoint 1 control register
$40080b28 constant OTG_FS_OTG_DOEPINT1  \ offset: 0xB28 : OTG device OUT endpoint 1 interrupt register
$40080b30 constant OTG_FS_OTG_DOEPTSIZ1  \ offset: 0xB30 : OTG device OUT endpoint 1 transfer size register
$40080b34 constant OTG_FS_OTG_DOEPDMA1  \ offset: 0xB34 : OTG device OUT endpoint 1 DMA address register
$40080b40 constant OTG_FS_OTG_DOEPCTL2_INT_BULK  \ offset: 0xB40 : OTG device OUT endpoint 2 control register
$40080b40 constant OTG_FS_OTG_DOEPCTL2_ISO  \ offset: 0xB40 : OTG device OUT endpoint 2 control register
$40080b48 constant OTG_FS_OTG_DOEPINT2  \ offset: 0xB48 : OTG device OUT endpoint 2 interrupt register
$40080b50 constant OTG_FS_OTG_DOEPTSIZ2  \ offset: 0xB50 : OTG device OUT endpoint 2 transfer size register
$40080b54 constant OTG_FS_OTG_DOEPDMA2  \ offset: 0xB54 : OTG device OUT endpoint 2 DMA address register
$40080b60 constant OTG_FS_OTG_DOEPCTL3_INT_BULK  \ offset: 0xB60 : OTG device OUT endpoint 3 control register
$40080b60 constant OTG_FS_OTG_DOEPCTL3_ISO  \ offset: 0xB60 : OTG device OUT endpoint 3 control register
$40080b68 constant OTG_FS_OTG_DOEPINT3  \ offset: 0xB68 : OTG device OUT endpoint 3 interrupt register
$40080b70 constant OTG_FS_OTG_DOEPTSIZ3  \ offset: 0xB70 : OTG device OUT endpoint 3 transfer size register
$40080b74 constant OTG_FS_OTG_DOEPDMA3  \ offset: 0xB74 : OTG device OUT endpoint 3 DMA address register
$40080b80 constant OTG_FS_OTG_DOEPCTL4_INT_BULK  \ offset: 0xB80 : OTG device OUT endpoint 4 control register
$40080b80 constant OTG_FS_OTG_DOEPCTL4_ISO  \ offset: 0xB80 : OTG device OUT endpoint 4 control register
$40080b88 constant OTG_FS_OTG_DOEPINT4  \ offset: 0xB88 : OTG device OUT endpoint 4 interrupt register
$40080b90 constant OTG_FS_OTG_DOEPTSIZ4  \ offset: 0xB90 : OTG device OUT endpoint 4 transfer size register
$40080b94 constant OTG_FS_OTG_DOEPDMA4  \ offset: 0xB94 : OTG device OUT endpoint 4 DMA address register
$40080ba0 constant OTG_FS_OTG_DOEPCTL5_INT_BULK  \ offset: 0xBA0 : OTG device OUT endpoint 5 control register
$40080ba0 constant OTG_FS_OTG_DOEPCTL5_ISO  \ offset: 0xBA0 : OTG device OUT endpoint 5 control register
$40080ba8 constant OTG_FS_OTG_DOEPINT5  \ offset: 0xBA8 : OTG device OUT endpoint 5 interrupt register
$40080bb0 constant OTG_FS_OTG_DOEPTSIZ5  \ offset: 0xBB0 : OTG device OUT endpoint 5 transfer size register
$40080bb4 constant OTG_FS_OTG_DOEPDMA5  \ offset: 0xBB4 : OTG device OUT endpoint 5 DMA address register
$40080bc0 constant OTG_FS_OTG_DOEPCTL6_INT_BULK  \ offset: 0xBC0 : OTG device OUT endpoint 6 control register
$40080bc0 constant OTG_FS_OTG_DOEPCTL6_ISO  \ offset: 0xBC0 : OTG device OUT endpoint 6 control register
$40080bc8 constant OTG_FS_OTG_DOEPINT6  \ offset: 0xBC8 : OTG device OUT endpoint 6 interrupt register
$40080bd0 constant OTG_FS_OTG_DOEPTSIZ6  \ offset: 0xBD0 : OTG device OUT endpoint 6 transfer size register
$40080bd4 constant OTG_FS_OTG_DOEPDMA6  \ offset: 0xBD4 : OTG device OUT endpoint 6 DMA address register
$40080be0 constant OTG_FS_OTG_DOEPCTL7_INT_BULK  \ offset: 0xBE0 : OTG device OUT endpoint 7 control register
$40080be0 constant OTG_FS_OTG_DOEPCTL7_ISO  \ offset: 0xBE0 : OTG device OUT endpoint 7 control register
$40080be8 constant OTG_FS_OTG_DOEPINT7  \ offset: 0xBE8 : OTG device OUT endpoint 7 interrupt register
$40080bf0 constant OTG_FS_OTG_DOEPTSIZ7  \ offset: 0xBF0 : OTG device OUT endpoint 7 transfer size register
$40080bf4 constant OTG_FS_OTG_DOEPDMA7  \ offset: 0xBF4 : OTG device OUT endpoint 7 DMA address register
$40080c00 constant OTG_FS_OTG_DOEPCTL8_INT_BULK  \ offset: 0xC00 : OTG device OUT endpoint 8 control register
$40080c00 constant OTG_FS_OTG_DOEPCTL8_ISO  \ offset: 0xC00 : OTG device OUT endpoint 8 control register
$40080c08 constant OTG_FS_OTG_DOEPINT8  \ offset: 0xC08 : OTG device OUT endpoint 8 interrupt register
$40080c10 constant OTG_FS_OTG_DOEPTSIZ8  \ offset: 0xC10 : OTG device OUT endpoint 8 transfer size register
$40080c14 constant OTG_FS_OTG_DOEPDMA8  \ offset: 0xC14 : OTG device OUT endpoint 8 DMA address register
$40080e00 constant OTG_FS_OTG_PCGCCTL  \ offset: 0xE00 : OTG power and clock gating control register
$40080e04 constant OTG_FS_OTG_PCGCCTL1  \ offset: 0xE04 : OTG power and clock gating control register 1

