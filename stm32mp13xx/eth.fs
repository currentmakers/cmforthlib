\
\ @file eth.fs
\ @brief ETH
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] ETH_DEF

  [ifdef] ETH_ETH_MACCR_DEF
    \
    \ @brief Operating mode configuration register
    \ Address offset: 0x00
    \ Reset value: 0x00008000
    \
    $00 constant ETH_RE                         \ [0x00] Receiver Enable When this bit is set, the Rx state machine of the MAC is enabled for receiving packets from the GMII or MII interface. When this bit is reset, the MAC Rx state machine is disabled after it completes the reception of the current packet. The Rx state machine does not receive any more packets from the GMII or MII interface.
    $01 constant ETH_TE                         \ [0x01] Transmitter Enable When this bit is set, the Tx state machine of the MAC is enabled for transmission on the GMII or MII interface. When this bit is reset, the MAC Tx state machine is disabled after it completes the transmission of the current packet. The Tx state machine does not transmit any more packets.
    $02 constant ETH_PRELEN                     \ [0x02 : 2] Preamble Length for Transmit packets These bits control the number of preamble bytes that are added to the beginning of every Tx packet. The preamble reduction occurs only when the MAC is operating in the full-duplex mode.
    $04 constant ETH_DC                         \ [0x04] Deferral Check When this bit is set, the deferral check function is enabled in the MAC. The MAC issues a Packet Abort status, along with the excessive deferral error bit set in the Tx packet status, when the Tx state machine is deferred for more than 24,288 bit times in 10 or 100 Mbps mode. If the MAC is configured for 1000 Mbps operation, the threshold for deferral is 155,680 bits times. Deferral begins when the transmitter is ready to transmit, but it is prevented because of an active carrier sense signal (CRS) on GMII or MII. The defer time is not cumulative. For example, if the transmitter defers for 10,000 bit times because the CRS signal is active and the CRS signal becomes inactive, the transmitter transmits and collision happens. Because of collision, the transmitter needs to back off and then defer again after back off completion. In such a scenario, the deferral timer is reset to 0, and it is restarted. When this bit is reset, the deferral check function is disabled and the MAC defers until the CRS signal goes inactive. This bit is applicable only in the half-duplex mode. This bit is reserved and read-only (RO) in the full-duplex-only configurations.
    $05 constant ETH_BL                         \ [0x05 : 2] Back-Off Limit The back-off limit determines the random integer number (r) of slot time delays (4,096 bit times for 1000 Mbps; 512 bit times for 10/100 Mbps) for which the MAC waits before rescheduling a transmission attempt during retries after a collision. where - = retransmission attempt The random integer r takes the value in the range 0 <= r < 2^k This bit is applicable only in the half-duplex mode. This bit is reserved and read-only (RO) in the full-duplex-only configurations.
    $08 constant ETH_DR                         \ [0x08] Disable Retry When this bit is set, the MAC attempts only one transmission. When a collision occurs on the GMII or MII interface, the MAC ignores the current packet transmission and reports a Packet Abort with excessive collision error in the Tx packet status. When this bit is reset, the MAC retries based on the settings of the BL field. This bit is applicable only in the half-duplex mode. This bit is reserved and read-only (RO) in the full-duplex-only configurations.
    $09 constant ETH_DCRS                       \ [0x09] Disable Carrier Sense During Transmission When this bit is set, the MAC transmitter ignores the (G)MII CRS signal during packet transmission in the half-duplex mode. As a result, no errors are generated because of Loss of Carrier or No Carrier during transmission. When this bit is reset, the MAC transmitter generates errors because of Carrier Sense. The MAC can even abort the transmission. This bit is reserved and read-only (RO) in the full-duplex-only configurations.
    $0a constant ETH_DO                         \ [0x0a] Disable Receive Own When this bit is set, the MAC disables the reception of packets when the ETH_TX_EN is asserted in the half-duplex mode. When this bit is reset, the MAC receives all packets given by the PHY. This bit is not applicable in the full-duplex mode. This bit is reserved and read-only (RO) with default value in the full-duplex-only configurations.
    $0b constant ETH_ECRSFD                     \ [0x0b] Enable Carrier Sense Before Transmission in Full-Duplex Mode When this bit is set, the MAC transmitter checks the CRS signal before packet transmission in the full-duplex mode. The MAC starts the transmission only when the CRS signal is low. When this bit is reset, the MAC transmitter ignores the status of the CRS signal.
    $0c constant ETH_LM                         \ [0x0c] Loopback Mode When this bit is set, the MAC operates in the loopback mode at GMII or MII. The GMII Rx clock input (eth_mii_rx_clk) is required for the loopback to work properly. This is because the Tx clock is not internally looped back.
    $0d constant ETH_DM                         \ [0x0d] Duplex Mode When this bit is set, the MAC operates in the full-duplex mode in which it can transmit and receive simultaneously. This bit is RO with default value of 1'b1 in the full-duplex-only configurations.
    $0e constant ETH_FES                        \ [0x0e] MAC Speed This bit selects the speed in the 10/100 Mbps mode: In the 1000 Mbps-only configurations, this bit is read-only with the reset value. In the 10 or 100 Mbps-only or default 10/100/1000 Mbps configurations, this bit is read-write. The mac_speed_o[0] signal reflects the value of this bit.
    $0f constant ETH_PS                         \ [0x0f] Port Select This bit selects the Ethernet line speed. In 10 or 100 Mbps operations, this bit, along with Bit 14, selects the exact line speed. In the 10/100 Mbps-only (always 1) or 1000 Mbps-only (always 0) configurations, this bit is read-only (RO) with appropriate value. In default 10/100/1000 Mbps configurations, this bit is read-write (rw). The mac_speed_o[1] signal reflects the value of this bit.
    $10 constant ETH_JE                         \ [0x10] Jumbo Packet Enable When this bit is set, the MAC allows jumbo packets of 9,018 bytes (9,022 bytes for VLAN tagged packets) without reporting a giant packet error in the Rx packet status.
    $11 constant ETH_JD                         \ [0x11] Jabber Disable When this bit is set, the MAC disables the jabber timer on the transmitter. The MAC can transfer packets of up to 16,383 bytes. When this bit is reset, if the application sends more than 2,048 bytes of data (10,240 if JE is set high) during transmission, the MAC does not send rest of the bytes in that packet.
    $12 constant ETH_BE                         \ [0x12] Packet Burst Enable When this bit is set, the MAC allows packet bursting during transmission in the GMII half-duplex mode. This bit is reserved and read-only (RO) in the 10/100 Mbps-only or full-duplex-only configurations.
    $13 constant ETH_WD                         \ [0x13] Watchdog Disable When this bit is set, the MAC disables the watchdog timer on the receiver. The MAC can receive packets of up to 16,383 bytes. When this bit is reset, the MAC does not allow more than 2,048 bytes (10,240 if JE is set high) of the packet being received. The MAC cuts off any bytes received after 2,048 bytes.
    $14 constant ETH_ACS                        \ [0x14] Automatic Pad or CRC Stripping When this bit is set, the MAC strips the Pad or FCS field on the incoming packets only if the value of the length field is less than 1,536 bytes. All received packets with length field greater than or equal to 1,536 bytes are passed to the application without stripping the Pad or FCS field. When this bit is reset, the MAC passes all incoming packets to the application, without any modification. Note: For information about how the settings of CST bit and this bit impact the packet length, see the Table, Packet Length based on the CST and ACS Bit.
    $15 constant ETH_CST                        \ [0x15] CRC stripping for Type packets When this bit is set, the last four bytes (FCS) of all packets of Ether type (type field greater than 1,536) are stripped and dropped before forwarding the packet to the application. This function is not valid when the IP Checksum Engine (Type 1) is enabled in the MAC receiver. This function is valid when Type 2 Checksum Offload Engine is enabled. Note: For information about how the settings of the ACS bit and this bit impact the packet length, see Packet Length based on the CST and ACS Bits.
    $16 constant ETH_S2KP                       \ [0x16] IEEE 802.3as Support for 2K Packets When this bit is set, the MAC considers all packets with up to 2,000 bytes length as normal packets. When the JE bit is not set, the MAC considers all received packets of size more than 2K bytes as Giant packets. When this bit is reset and the JE bit is not set, the MAC considers all received packets of size more than 1,518 bytes (1,522 bytes for tagged) as giant packets. For more information about how the setting of this bit and the JE bit impact the Giant packet status, see Gaint Packet Status based on S2KP and JE Bits. Note: When the JE bit is set, setting this bit has no effect on the giant packet status.
    $17 constant ETH_GPSLCE                     \ [0x17] Giant Packet Size Limit Control Enable When this bit is set, the MAC considers the value in GPSL field in ETH_MACECR register to declare a received packet as Giant packet. This field must be programmed to more than 1,518 bytes. Otherwise, the MAC considers 1,518 bytes as giant packet limit. When this bit is reset, the MAC considers a received packet as Giant packet when its size is greater than 1,518 bytes (1522 bytes for tagged packet). The watchdog timeout limit, Jumbo Packet Enable and 2K Packet Enable have higher precedence over this bit, that is the MAC considers a received packet as Giant packet when its size is greater than 9,018 bytes (9,022 bytes for tagged packet) with Jumbo Packet Enabled and greater than 2,000 bytes with 2K Packet Enabled. The watchdog timeout, if enabled, terminates the received packet when watchdog limit is reached. Therefore, the programmed giant packet limit should be less than the watchdog limit to get the giant packet status.
    $18 constant ETH_IPG                        \ [0x18 : 3] Inter-Packet Gap These bits control the minimum IPG between packets during transmission. ... This range of minimum IPG is valid in full-duplex mode. In the half-duplex mode, the minimum IPG can be configured only for 64-bit times (IPG = 100). Lower values are not considered. When a JAM pattern is being transmitted because of backpressure activation, the MAC does not consider the minimum IPG. The above function (IPG less than 96 bit times) is valid only when EIPGEN bit in ETH_MACECR register is reset. When EIPGEN is set, then the minimum IPG (greater than 96 bit times) is controlled as per the description given in EIPG field in ETH_MACECR register.
    $1b constant ETH_IPC                        \ [0x1b] Checksum Offload When set, this bit enables the IPv4 header checksum checking and IPv4 or IPv6 TCP, UDP, or ICMP payload checksum checking. When this bit is reset, the COE function in the receiver is disabled. The Layer 3 and Layer 4 Packet Filter and Enable Split Header features automatically selects the IPC Full Checksum Offload Engine on the Receive side. When any of these features are enabled, you must set the IPC bit.
    $1c constant ETH_SARC                       \ [0x1c : 3] Source Address Insertion or Replacement Control This field controls the source address insertion or replacement for all transmitted packets. Bit 30 specifies which MAC Address register (0 or 1) is used for source address insertion or replacement based on the values of Bits[29:28] Note: Changes to this field take effect only on the start of a packet. If you write to this register field when a packet is being transmitted, only the subsequent packet can use the updated value, that is, the current packet does not use the updated value.
    $1f constant ETH_ARPEN                      \ [0x1f] ARP Offload Enable When this bit is set, the MAC can recognize an incoming ARP request packet and schedules the ARP packet for transmission. It will forward the ARP packet to the application and also indicate the events in the RxStatus. When this bit is reset, the MAC receiver does not recognize any ARP packet and indicates them as Type frame in the RxStatus.
  [then]


  [ifdef] ETH_ETH_MACECR_DEF
    \
    \ @brief Extended operating mode configuration register
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $00 constant ETH_GPSL                       \ [0x00 : 14] Giant Packet Size Limit If the received packet size is greater than the value programmed in this field in units of bytes, the MAC declares the received packet as Giant packet. The value programmed in this field must be greater than or equal to 1,518 bytes. Any other programmed value is considered as 1,518 bytes. For VLAN tagged packets, the MAC adds 4 bytes to the programmed value. For double VLAN tagged packets, the MAC adds 8 bytes to the programmed value. The value in this field is applicable when the GPSLCE bit is set in ETH_MACCR register.
    $10 constant ETH_DCRCC                      \ [0x10] Disable CRC Checking for Received Packets When this bit is set, the MAC receiver does not check the CRC field in the received packets. When this bit is reset, the MAC receiver always checks the CRC field in the received packets.
    $11 constant ETH_SPEN                       \ [0x11] Slow Protocol Detection Enable When this bit is set, MAC processes the Slow Protocol packets (Ether Type 0x8809) and provides the Rx status. The MAC discards the Slow Protocol packets with invalid sub-types. When this bit is reset, the MAC forwards all error-free Slow Protocol packets to the application. The MAC considers such packets as normal Type packets.
    $12 constant ETH_USP                        \ [0x12] Unicast Slow Protocol Packet Detect When this bit is set, the MAC detects the Slow Protocol packets with unicast address of the station specified in the ETH_MACA0HR and ETH_MACA0LR registers. The MAC also detects the Slow Protocol packets with the Slow Protocols multicast address (01-80-C2-00-00-02). When this bit is reset, the MAC detects only Slow Protocol packets with the Slow Protocol multicast address specified in the IEEE 802.3-2008, Section 5.
    $18 constant ETH_EIPGEN                     \ [0x18] Extended Inter-Packet Gap Enable When this bit is set, the MAC interprets EIPG field and IPG field in ETH_MACCR together as minimum IPG greater than 96 bit times in steps of 8 bit times. When this bit is reset, the MAC ignores EIPG field and interprets IPG field in ETH_MACCR as minimum IPG less than or equal to 96 bit times in steps of 8 bit times. Note: The extended Inter-Packet Gap feature must be enabled when operating in Full-Duplex mode only. There may be undesirable effects on back-pressure function and frame transmission if it is enabled in Half-Duplex mode.
    $19 constant ETH_EIPG                       \ [0x19 : 5] Extended Inter-Packet Gap The value in this field is applicable when the EIPGEN bit is set. This field (as Most Significant bits) along with IPG field in ETH_MACCR, gives the minimum IPG greater than 96 bit times in steps of 8 bit times. /* FIXME : enum values removed for the moment */
  [then]


  [ifdef] ETH_ETH_MACPFR_DEF
    \
    \ @brief Packet filtering control register
    \ Address offset: 0x08
    \ Reset value: 0x00000000
    \
    $00 constant ETH_PR                         \ [0x00] Promiscuous Mode When this bit is set, the Address Filtering module passes all incoming packets irrespective of the destination or source address. The SA or DA Filter Fails status bits of the Rx Status Word are always cleared when PR is set.
    $01 constant ETH_HUC                        \ [0x01] Hash Unicast When this bit is set, the MAC performs the destination address filtering of unicast packets according to the Hash table. When this bit is reset, the MAC performs a perfect destination address filtering for unicast packets, that is, it compares the DA field with the values programmed in DA registers.
    $02 constant ETH_HMC                        \ [0x02] Hash Multicast When this bit is set, the MAC performs the destination address filtering of received multicast packets according to the Hash table. When this bit is reset, the MAC performs the perfect destination address filtering for multicast packets, that is, it compares the DA field with the values programmed in DA registers.
    $03 constant ETH_DAIF                       \ [0x03] DA Inverse Filtering When this bit is set, the Address Check block operates in inverse filtering mode for the DA address comparison for both unicast and multicast packets. When this bit is reset, normal filtering of packets is performed.
    $04 constant ETH_PM                         \ [0x04] Pass All Multicast When this bit is set, it indicates that all received packets with a multicast destination address (first bit in the destination address field is '1') are passed. When this bit is reset, filtering of multicast packet depends on HMC bit.
    $05 constant ETH_DBF                        \ [0x05] Disable Broadcast Packets When this bit is set, the AFM module blocks all incoming broadcast packets. In addition, it overrides all other filter settings. When this bit is reset, the AFM module passes all received broadcast packets.
    $06 constant ETH_PCF                        \ [0x06 : 2] Pass Control Packets These bits control the forwarding of all control packets (including unicast and multicast Pause packets).
    $08 constant ETH_SAIF                       \ [0x08] SA Inverse Filtering When this bit is set, the Address Check block operates in the inverse filtering mode for SA address comparison. If the SA of a packet matches the values programmed in the SA registers, it is marked as failing the SA Address filter. When this bit is reset, if the SA of a packet does not match the values programmed in the SA registers, it is marked as failing the SA Address filter.
    $09 constant ETH_SAF                        \ [0x09] Source Address Filter Enable When this bit is set, the MAC compares the SA field of the received packets with the values programmed in the enabled SA registers. If the comparison fails, the MAC drops the packet. When this bit is reset, the MAC forwards the received packet to the application with updated SAF bit of the Rx Status depending on the SA address comparison. Note: According to the IEEE specification, Bit 47 of the SA is reserved. However, the MAC compares all 48 bits. The software driver should take this into consideration while programming the MAC address registers for SA.
    $0a constant ETH_HPF                        \ [0x0a] Hash or Perfect Filter When this bit is set, the address filter passes a packet if it matches either the perfect filtering or Hash filtering as set by the HMC or HUC bit. When this bit is reset and the HUC or HMC bit is set, the packet is passed only if it matches the Hash filter.
    $10 constant ETH_VTFE                       \ [0x10] VLAN Tag Filter Enable When this bit is set, the MAC drops the VLAN tagged packets that do not match the VLAN Tag. When this bit is reset, the MAC forwards all packets irrespective of the match status of the VLAN Tag.
    $14 constant ETH_IPFE                       \ [0x14] Layer 3 and Layer 4 Filter Enable When this bit is set, the MAC drops packets that do not match the enabled Layer 3 and Layer 4 filters. If Layer 3 or Layer 4 filters are not enabled for matching, this bit does not have any effect. When this bit is reset, the MAC forwards all packets irrespective of the match status of the Layer 3 and Layer 4 fields.
    $15 constant ETH_DNTU                       \ [0x15] Drop Non-TCP/UDP over IP Packets When this bit is set, the MAC drops the non-TCP or UDP over IP packets. The MAC forward only those packets that are processed by the Layer 4 filter. When this bit is reset, the MAC forwards all non-TCP or UDP over IP packets.
    $1f constant ETH_RA                         \ [0x1f] Receive All When this bit is set, the MAC Receiver module passes all received packets to the application, irrespective of whether they pass the address filter or not. The result of the SA or DA filtering is updated (pass or fail) in the corresponding bit in the Rx Status Word. When this bit is reset, the Receiver module passes only those packets to the application that pass the SA or DA address filter.
  [then]


  [ifdef] ETH_ETH_MACWTR_DEF
    \
    \ @brief Watchdog timeout register
    \ Address offset: 0x0C
    \ Reset value: 0x00000000
    \
    $00 constant ETH_WTO                        \ [0x00 : 4] Watchdog Timeout When the PWE bit is set and the WD bit of the ETH_MACCR register is reset, this field is used as watchdog timeout for a received packet. If the length of a received packet exceeds the value of this field, such packet is terminated and declared as an error packet. Encoding is as follows: .. Note: When the PWE bit is set, the value in this field should be more than 1,522 (0x05F2). Otherwise, the IEEE 802.3-specified valid tagged packets are declared as error packets and then dropped.
    $08 constant ETH_PWE                        \ [0x08] Programmable Watchdog Enable When this bit is set and the WD bit of the ETH_MACCR register is reset, the WTO field is used as watchdog timeout for a received packet. When this bit is cleared, the watchdog timeout for a received packet is controlled by setting of WD and JE bits in ETH_MACCR register.
  [then]


  [ifdef] ETH_ETH_MACHT0R_DEF
    \
    \ @brief Hash Table 0 register
    \ Address offset: 0x10
    \ Reset value: 0x00000000
    \
    $00 constant ETH_HT31T0                     \ [0x00 : 32] MAC Hash Table First 32 Bits This field contains the first 32 Bits [31:0] of the Hash table.
  [then]


  [ifdef] ETH_ETH_MACHT1R_DEF
    \
    \ @brief Hash Table 1 register
    \ Address offset: 0x14
    \ Reset value: 0x00000000
    \
    $00 constant ETH_HT63T32                    \ [0x00 : 32] MAC Hash Table Second 32 Bits This field contains the second 32 Bits [63:32] of the Hash table.
  [then]


  [ifdef] ETH_ETH_MACVTR_DEF
    \
    \ @brief VLAN tag register
    \ Address offset: 0x50
    \ Reset value: 0x00000000
    \
    $00 constant ETH_VL                         \ [0x00 : 16] VLAN Tag Identifier for Receive Packets This field contains the 802.1Q VLAN tag to identify the VLAN packets. This VLAN tag identifier is compared to the 15th and 16th bytes of the packets being received for VLAN packets. The following list describes the bits of this field: Bits[15:13]: User Priority Bit 12: Canonical Format Indicator (CFI) or Drop Eligible Indicator (DEI) Bits[11:0]: VLAN Identifier (VID) field of VLAN tag When the ETV bit is set, only the VID is used for comparison. If this field ([11:0] if ETV is set) is all zeros, the MAC does not check the 15th and 16th bytes for VLAN tag comparison and declares all packets with Type field value of 0x8100 or 0x88a8 as VLAN packets.
    $10 constant ETH_ETV                        \ [0x10] Enable 12-Bit VLAN Tag Comparison When this bit is set, a 12-bit VLAN identifier is used for comparing and filtering instead of the complete 16-bit VLAN tag. Bits[11:0] of VLAN tag are compared with the corresponding field in the received VLAN-tagged packet. Similarly, when enabled, only 12 bits of the VLAN tag in the received packet are used for Hash-based VLAN filtering. When this bit is reset, all 16 bits of the 15th and 16th bytes of the received VLAN packet are used for comparison and VLAN Hash filtering.
    $11 constant ETH_VTIM                       \ [0x11] VLAN Tag Inverse Match Enable When this bit is set, this bit enables the VLAN Tag inverse matching. The packets without matching VLAN Tag are marked as matched. When reset, this bit enables the VLAN Tag perfect matching. The packets with matched VLAN Tag are marked as matched.
    $12 constant ETH_ESVL                       \ [0x12] Enable S-VLAN When this bit is set, the MAC transmitter and receiver consider the S-VLAN packets (Type = 0x88A8) as valid VLAN tagged packets.
    $13 constant ETH_ERSVLM                     \ [0x13] Enable Receive S-VLAN Match When this bit is set, the MAC receiver enables filtering or matching for S-VLAN (Type = 0x88A8) packets. When this bit is reset, the MAC receiver enables filtering or matching for C-VLAN (Type = 0x8100) packets. The ERIVLT bit determines the VLAN tag position considered for filtering or matching.
    $14 constant ETH_DOVLTC                     \ [0x14] Disable VLAN Type Check When this bit is set, the MAC does not check whether the VLAN Tag specified by the ERIVLT bit is of type S-VLAN or C-VLAN. When this bit is reset, the MAC filters or matches the VLAN Tag specified by the ERIVLT bit only when VLAN Tag type is similar to the one specified by the ERSVLM bit.
    $15 constant ETH_EVLS                       \ [0x15 : 2] Enable VLAN Tag Stripping on Receive This field indicates the stripping operation on the outer VLAN Tag in received packet:
    $18 constant ETH_EVLRXS                     \ [0x18] Enable VLAN Tag in Rx status When this bit is set, MAC provides the outer VLAN Tag in the Rx status. When this bit is reset, the MAC does not provide the outer VLAN Tag in Rx status.
    $19 constant ETH_VTHM                       \ [0x19] VLAN Tag Hash Table Match Enable When this bit is set, the most significant four bits of CRC of VLAN Tag are used to index the content of the ETH_MACVLANHTR register. A value of 1 in the VLAN Hash Table register, corresponding to the index, indicates that the packet matched the VLAN Hash table. When the ETV bit is set, the CRC of the 12-bit VLAN Identifier (VID) is used for comparison. When the ETV bit is reset, the CRC of the 16-bit VLAN tag is used for comparison. When this bit is reset, the VLAN Hash Match operation is not performed. If the VLAN Hash feature is not enabled, this bit is reserved (RO with default value).
    $1a constant ETH_EDVLP                      \ [0x1a] Enable Double VLAN Processing When this bit is set, the MAC enables processing of up to two VLAN Tags on Tx and Rx (if present). When this bit is reset, the MAC enables processing of up to one VLAN Tag on Tx and Rx (if present).
    $1b constant ETH_ERIVLT                     \ [0x1b] Enable Inner VLAN Tag When this bit and the EDVLP field are set, the MAC receiver enables operation on the inner VLAN Tag (if present). When this bit is reset, the MAC receiver enables operation on the outer VLAN Tag (if present). The ERSVLM bit determines which VLAN type is enabled for filtering or matching.
    $1c constant ETH_EIVLS                      \ [0x1c : 2] Enable Inner VLAN Tag Stripping on Receive This field indicates the stripping operation on inner VLAN Tag in received packet:
    $1f constant ETH_EIVLRXS                    \ [0x1f] Enable Inner VLAN Tag in Rx Status When this bit is set, the MAC provides the inner VLAN Tag in the Rx status. When this bit is reset, the MAC does not provide the inner VLAN Tag in Rx status.
  [then]


  [ifdef] ETH_ETH_MACVHTR_DEF
    \
    \ @brief VLAN Hash table register
    \ Address offset: 0x58
    \ Reset value: 0x00000000
    \
    $00 constant ETH_VLHT                       \ [0x00 : 16] VLAN Hash Table This field contains the 16-bit VLAN Hash Table.
  [then]


  [ifdef] ETH_ETH_MACVIR_DEF
    \
    \ @brief VLAN inclusion register
    \ Address offset: 0x60
    \ Reset value: 0x00000000
    \
    $00 constant ETH_VLT                        \ [0x00 : 16] VLAN Tag for Transmit Packets This field contains the value of the VLAN tag to be inserted or replaced. The value must only be changed when the transmit lines are inactive or during the initialization phase. Bits[15:13] are the User Priority field, Bit 12 is the CFI/DEI field, and Bits[11:0] are the VID field in the VLAN tag. The following list describes the bits of this field: Bits[15:13]: User Priority Bit 12: Canonical Format Indicator (CFI) or Drop Eligible Indicator (DEI) Bits[11:0]: VLAN Identifier (VID) field of VLAN tag
    $10 constant ETH_VLC                        \ [0x10 : 2] VLAN Tag Control in Transmit Packets Note: Changes to this field take effect only on the start of a packet. If you write this register field when a packet is being transmitted, only the subsequent packet can use the updated value, that is, the current packet does not use the updated value.
    $12 constant ETH_VLP                        \ [0x12] VLAN Priority Control When this bit is set, the control bits[17:16] are used for VLAN deletion, insertion, or replacement. When this bit is reset, bits[17:16] are ignored.
    $13 constant ETH_CSVL                       \ [0x13] C-VLAN or S-VLAN When this bit is set, S-VLAN type (0x88A8) is inserted or replaced in the 13th and 14th bytes of transmitted packets. When this bit is reset, C-VLAN type (0x8100) is inserted or replaced in the 13th and 14th bytes of transmitted packets.
    $14 constant ETH_VLTI                       \ [0x14] VLAN Tag Input When this bit is set, it indicates that the VLAN tag to be inserted or replaced in Tx packet should be taken from the Tx descriptor.
  [then]


  [ifdef] ETH_ETH_MACIVIR_DEF
    \
    \ @brief Inner VLAN inclusion register
    \ Address offset: 0x64
    \ Reset value: 0x00000000
    \
    $00 constant ETH_VLT                        \ [0x00 : 16] VLAN Tag for Transmit Packets This field contains the value of the VLAN tag to be inserted or replaced. The value must only be changed when the transmit lines are inactive or during the initialization phase. Bits[15:13] are the User Priority field, Bit 12 is the CFI/DEI field, and Bits[11:0] are the VID field in the VLAN tag. The following list describes the bits of this field: Bits[15:13]: User Priority Bit 12: Canonical Format Indicator (CFI) or Drop Eligible Indicator (DEI) Bits[11:0]: VLAN Identifier (VID) field of VLAN tag
    $10 constant ETH_VLC                        \ [0x10 : 2] VLAN Tag Control in Transmit Packets The MAC removes the VLAN type (bytes 17 and 18) and VLAN tag (bytes 19 and 20) of all transmitted packets with VLAN tags. The MAC inserts VLT in bytes 19 and 20 of the packet after inserting the Type value (0x8100 or 0x88a8) in bytes 17 and 18. This operation is performed on all transmitted packets, irrespective of whether they already have a VLAN tag. The MAC replaces VLT in bytes 19 and 20 of all VLAN-type transmitted packets (Bytes 17 and 18 are 0x8100 or 0x88a8). Note: Changes to this field take effect only on the start of a packet. If you write this register field when a packet is being transmitted, only the subsequent packet can use the updated value, that is, the current packet does not use the updated value.
    $12 constant ETH_VLP                        \ [0x12] VLAN Priority Control When this bit is set, the VLC field is used for VLAN deletion, insertion, or replacement. When this bit is reset, the VLC field is ignored.
    $13 constant ETH_CSVL                       \ [0x13] C-VLAN or S-VLAN When this bit is set, S-VLAN type (0x88A8) is inserted or replaced in the 13th and 14th bytes of transmitted packets. When this bit is reset, C-VLAN type (0x8100) is inserted or replaced in the 13th and 14th bytes of transmitted packets.
    $14 constant ETH_VLTI                       \ [0x14] VLAN Tag Input When this bit is set, it indicates that the VLAN tag to be inserted or replaced in Tx packet should be taken from the Tx descriptor
  [then]


  [ifdef] ETH_ETH_MACQ0TXFCR_DEF
    \
    \ @brief Tx Queue 0 flow control register
    \ Address offset: 0x70
    \ Reset value: 0x00000000
    \
    $00 constant ETH_FCB_BPA                    \ [0x00] Flow Control Busy or Backpressure Activate This bit initiates a Pause packet in the full-duplex mode and activates the backpressure function in the half-duplex mode if the TFE bit is set. Full-Duplex Mode: this bit should be read as 0 before writing to this register. To initiate a Pause packet, the application must set this bit to 1. During Control packet transfer, this bit continues to be set to indicate that a packet transmission is in progress. When Pause packet transmission is complete, the MAC resets this bit to 0. You should not write to this register until this bit is cleared. Half-Duplex Mode: When this bit is set (and TFE bit is set) in the half-duplex mode, the MAC asserts the backpressure. During backpressure, when the MAC receives a new packet, the transmitter starts sending a JAM pattern resulting in a collision. When the MAC is configured for the full-duplex mode, the BPA is automatically disabled.
    $01 constant ETH_TFE                        \ [0x01] Transmit Flow Control Enable Full-Duplex Mode: when this bit is set, the MAC enables the flow control operation to Tx Pause packets. When this bit is reset, the flow control operation in the MAC is disabled, and the MAC does not transmit any Pause packets. Half-Duplex Mode: when this bit is set, the MAC enables the backpressure operation. When this bit is reset, the backpressure feature is disabled.
    $04 constant ETH_PLT                        \ [0x04 : 3] Pause Low Threshold This field configures the threshold of the Pause timer at which the input flow is checked for automatic retransmission of the Pause packet. The threshold values should be always less than the Pause Time configured in Bits[31:16]. For example, if PT = 100H (256 slot times), and PLT = 001, a second Pause packet is automatically transmitted at 228 (256-28) slot times after the first Pause packet is transmitted. The following list provides the threshold values for different values: The slot time is defined as the time taken to transmit 512 bits (64 bytes) on the GMII or MII interface. This (approximate) computation is based on the packet size (64, 1518, 2000, 9018, 16384, or 32768) + 2 Pause Packet Size + IPG in Slot Times.
    $07 constant ETH_DZPQ                       \ [0x07] Disable Zero-Quanta Pause When this bit is set, it disables the automatic generation of the zero-quanta Pause packets. When this bit is reset, normal operation with automatic zero-quanta Pause packet generation is enabled.
    $10 constant ETH_PT                         \ [0x10 : 16] Pause Time This field holds the value to be used in the Pause Time field in the Tx control packet. If the Pause Time bits are configured to be double-synchronized to the (G)MII clock domain, consecutive writes to this register should be performed only after at least four clock cycles in the destination clock domain.
  [then]


  [ifdef] ETH_ETH_MACRXFCR_DEF
    \
    \ @brief Rx flow control register
    \ Address offset: 0x90
    \ Reset value: 0x00000000
    \
    $00 constant ETH_RFE                        \ [0x00] Receive Flow Control Enable When this bit is set and the MAC is operating in full-duplex mode, the MAC decodes the received Pause packet and disables its transmitter for a specified (Pause) time. When this bit is reset or the MAC is operating in half-duplex mode, the decode function of the Pause packet is disabled. When PFC is enabled, flow control is enabled for PFC packets. The MAC decodes the received PFC packet and disables the Transmit queue, with matching priorities, for a duration of received Pause time.
    $01 constant ETH_UP                         \ [0x01] Unicast Pause Packet Detect A pause packet is processed when it has the unique multicast address specified in the IEEE 802.3. When this bit is set, the MAC can also detect Pause packets with unicast address of the station. This unicast address should be as specified in ETH_MACA0HR and ETH_MACA0LR. When this bit is reset, the MAC only detects Pause packets with unique multicast address. Note: The MAC does not process a Pause packet if the multicast address is different from the unique multicast address. This is also applicable to the received PFC packet when the Priority Flow Control (PFC) is enabled. The unique multicast address (0x01_80_C2_00_00_01) is as specified in IEEE 802.1 Qbb-2011.
  [then]


  [ifdef] ETH_ETH_MACTXQPMR_DEF
    \
    \ @brief Tx queue priority mapping 0 register
    \ Address offset: 0x98
    \ Reset value: 0x00000000
    \
    $00 constant ETH_PSTQ0                      \ [0x00 : 8] Priorities Selected in Transmit Queue 0 This bit is similar to the PSTQ1 bit.
    $08 constant ETH_PSTQ1                      \ [0x08 : 8] Priorities Selected in Transmit Queue 1 This field holds the priorities assigned to Tx queue 1 by software. It determines if Tx queue 1 is blocked from transmitting during a specific pause time when a PFC packet is received with a priority that matches the priority programmed in this field. If the content of this field is the same as Queue 0, the MAC blocks the two queues for a specific period of time.
  [then]


  [ifdef] ETH_ETH_MACRXQC2R_DEF
    \
    \ @brief Rx queue control 2 register
    \ Address offset: 0xA8
    \ Reset value: 0x00000000
    \
    $00 constant ETH_PSRQ0                      \ [0x00 : 8] Priorities Selected in the Receive Queue 0 This field defines the priorities assigned to Rx queue 0. All packets with priorities that match the values set in this field are routed to Rx queue 0. For example, if PSRQ0[5] is set, packets with USP field equal to 5 are routed to Rx queue 0. The software must ensure that the content of this field is mutually exclusive to the PSRQ fields for other queues, that is, the same priority is not mapped to multiple Rx queues.
    $08 constant ETH_PSRQ1                      \ [0x08 : 8] Priorities Selected in the Receive Queue 1 This field defines the priorities assigned to Rx queue 1. All packets with priorities that match the values set in this field are routed to Rx queue 1. For example, if PSRQ1[4] is set, packets with USP field equal to 4 are routed to Rx queue 1. The software must ensure that the content of this field is mutually exclusive to the PSRQ fields for other queues, that is, the same priority is not mapped to multiple Rx queues.
  [then]


  [ifdef] ETH_ETH_MACISR_DEF
    \
    \ @brief Interrupt status register
    \ Address offset: 0xB0
    \ Reset value: 0x00000000
    \
    $00 constant ETH_RGSMIIIS                   \ [0x00] RGMII or SMII Interrupt Status This bit is set by any change in value of the Link Status of RGMII or SMII interface (LNKSTS bit in ETH_MACPHYCSR register). This bit is cleared when the ETH_MACPHYCSR register is read.
    $03 constant ETH_PHYIS                      \ [0x03] PHY Interrupt This bit is set when rising edge is detected on the phy_intr_i input. This bit is cleared when this register is read.
    $04 constant ETH_PMTIS                      \ [0x04] PMT Interrupt Status This bit is set when a Magic packet or Wake-on-LAN packet is received in the power-down mode (RWKPRCVD and MGKPRCVD bits in ETH_MACPCSR register). This bit is cleared when Bits[6:5] are cleared because of a Read operation to the ETH_MACPCSR register. This bit is valid only when you select the Enable power management option.
    $05 constant ETH_LPIIS                      \ [0x05] LPI Interrupt Status When the Energy Efficient Ethernet feature is enabled, this bit is set for any LPI state entry or exit in the MAC Transmitter or Receiver. This bit is cleared when the TLPIEN bit of ETH_MACLCSR register is read. In all other modes, this bit is reserved.
    $08 constant ETH_MMCIS                      \ [0x08] MMC Interrupt Status This bit is set high when Bit 11, Bit 10, or Bit 9 is set high. This bit is cleared only when all these bits are low. This bit is valid only when you select the Enable MAC management counters (MMC) option.
    $09 constant ETH_MMCRXIS                    \ [0x09] MMC Receive Interrupt Status This bit is set high when an interrupt is generated in the MMC Receive Interrupt Register. This bit is cleared when all bits in this interrupt register are cleared. This bit is valid only when you select the Enable MAC Management Counters (MMC) option.
    $0a constant ETH_MMCTXIS                    \ [0x0a] MMC Transmit Interrupt Status This bit is set high when an interrupt is generated in the MMC Transmit Interrupt Register. This bit is cleared when all bits in this interrupt register are cleared. This bit is valid only when you select the Enable MAC management counters (MMC) option.
    $0c constant ETH_TSIS                       \ [0x0c] Timestamp Interrupt Status If the Timestamp feature is enabled, this bit is set when any of the following conditions is true: The system time value is equal to or exceeds the value specified in the Target Time High and Low registers. There is an overflow in the Seconds register. The Target Time Error occurred, that is, programmed target time already elapsed. If the Auxiliary Snapshot feature is enabled, this bit is set when the auxiliary snapshot trigger is asserted. When drop transmit status is enabled in MTL, this bit is set when the captured transmit timestamp is updated in the ETH_MACTXTSSNR and ETH_MACTXTSSSR registers. When PTP offload feature is enabled, this bit is set when the captured transmit timestamp is updated in the ETH_MACTXTSSNR and ETH_MACTXTSSSR registers, for PTO generated Delay Request and Pdelay request packets. This bit is cleared when the corresponding interrupt source bit is read in the ETH_MACTSSR register.
    $0d constant ETH_TXSTSIS                    \ [0x0d] Transmit Status Interrupt This bit indicates the status of transmitted packets. This bit is set when any of the following bits is set in the ETH_MACISR register: Excessive Collision (EXCOL) Late Collision (LCOL) Excessive Deferral (EXDEF) Loss of Carrier (LCARR) No Carrier (NCARR) Jabber Timeout (TJT) This bit is cleared when the corresponding interrupt source bit is read in the ETH_MACISR register.
    $0e constant ETH_RXSTSIS                    \ [0x0e] Receive Status Interrupt This bit indicates the status of received packets. This bit is set when the RWT bit is set in the ETH_MACISR register. This bit is cleared when the corresponding interrupt source bit is read in the ETH_MACISR register.
  [then]


  [ifdef] ETH_ETH_MACIER_DEF
    \
    \ @brief Interrupt enable register
    \ Address offset: 0xB4
    \ Reset value: 0x00000000
    \
    $00 constant ETH_RGSMIIIE                   \ [0x00] RGMII or SMII Interrupt Enable When this bit is set, it enables the assertion of the interrupt signal because of the setting of RGSMIIIS bit in ETH_MACISR register.
    $03 constant ETH_PHYIE                      \ [0x03] PHY Interrupt Enable When this bit is set, it enables the assertion of the interrupt signal because of the setting of PHYIS bit in ETH_MACISR register.
    $04 constant ETH_PMTIE                      \ [0x04] PMT Interrupt Enable When this bit is set, it enables the assertion of the interrupt signal because of the setting of PMTIS bit in ETH_MACISR register.
    $05 constant ETH_LPIIE                      \ [0x05] LPI Interrupt Enable When this bit is set, it enables the assertion of the interrupt signal because of the setting of LPIIS bit in ETH_MACISR register.
    $0c constant ETH_TSIE                       \ [0x0c] Timestamp Interrupt Enable When this bit is set, it enables the assertion of the interrupt signal because of the setting of TSIS bit in ETH_MACISR register.
    $0d constant ETH_TXSTSIE                    \ [0x0d] Transmit Status Interrupt Enable When this bit is set, it enables the assertion of the interrupt signal because of the setting of TXSTSIS bit in the ETH_MACISR register.
    $0e constant ETH_RXSTSIE                    \ [0x0e] Receive Status Interrupt Enable When this bit is set, it enables the assertion of the interrupt signal because of the setting of RXSTSIS bit in the ETH_MACISR register.
  [then]


  [ifdef] ETH_ETH_MACRXTXSR_DEF
    \
    \ @brief Rx Tx status register
    \ Address offset: 0xB8
    \ Reset value: 0x00000000
    \
    $00 constant ETH_TJT                        \ [0x00] Transmit Jabber Timeout This bit indicates that the Transmit Jabber Timer expired which happens when the packet size exceeds 2,048 bytes (10,240 bytes when the Jumbo packet is enabled) and JD bit is reset in the ETH_MACCR register. This bit is set when the packet size exceeds 16,383 bytes and the JD bit is set in the ETH_MACCR register.
    $01 constant ETH_NCARR                      \ [0x01] No Carrier When the DTXSTS bit is set in the MTL_Operation_Mode register, this bit indicates that the carrier signal from the PHY is not present at the end of preamble transmission.
    $02 constant ETH_LCARR                      \ [0x02] Loss of Carrier When the DTXSTS bit is set in the MTL_Operation_Mode register, this bit indicates that the loss of carrier occurred during packet transmission, that is, the phy_crs_i signal was inactive for one or more transmission clock periods during packet transmission. This bit is valid only for packets transmitted without collision.
    $03 constant ETH_EXDEF                      \ [0x03] Excessive Deferral When the DTXSTS bit is set in the MTL_Operation_Mode register and the DC bit is set in the ETH_MACCR register, this bit indicates that the transmission ended because of excessive deferral of over 24,288 bit times (155,680 in 1000 Mbps mode or when Jumbo packet is enabled).
    $04 constant ETH_LCOL                       \ [0x04] Late Collision When the DTXSTS bit is set in the MTL_Operation_Mode register, this bit indicates that the packet transmission aborted because a collision occurred after the collision window (64 bytes including Preamble in MII mode; 512 bytes including Preamble and Carrier Extension in GMII mode). This bit is not valid if the Underflow error occurs.
    $05 constant ETH_EXCOL                      \ [0x05] Excessive Collisions When the DTXSTS bit is set in the MTL_Operation_Mode register, this bit indicates that the transmission aborted after 16 successive collisions while attempting to transmit the current packet. If the DR bit is set in the ETH_MACCR register, this bit is set after the first collision and the packet transmission is aborted.
    $08 constant ETH_RWT                        \ [0x08] Receive Watchdog Timeout This bit is set when a packet with length greater than 2,048 bytes is received (10, 240 bytes when Jumbo Packet mode is enabled) and the WD bit is reset in the ETH_MACCR register. This bit is set when a packet with length greater than 16,383 bytes is received and the WD bit is set in the ETH_MACCR register.
  [then]


  [ifdef] ETH_ETH_MACPCSR_DEF
    \
    \ @brief Power Down When this bit is set, the MAC receiver drops all received packets until it receives the expected magic packet or remote wakeup packet. This bit is then self-cleared and the power-down mode is disabled. The software can clear this bit before the expected magic packet or remote wakeup packet is received. The packets received by the MAC after this bit is cleared are forwarded to the application. This bit must only be set when the Magic Packet Enable, Global Unicast, or Remote wakeup Packet Enable bit is set high. Note: You can gate-off the CSR clock during the power-down mode. However, when the CSR clock is gated-off, you cannot perform any read or write operations on this register. Therefore, the Software cannot clear this bit.
    \ Address offset: 0xC0
    \ Reset value: 0x00000000
    \
    $00 constant ETH_PWRDWN                     \ [0x00] Power Down When this bit is set, the MAC receiver drops all received packets until it receives the expected magic packet or remote wakeup packet. This bit is then self-cleared and the power-down mode is disabled. The software can clear this bit before the expected magic packet or remote wakeup packet is received. The packets received by the MAC after this bit is cleared are forwarded to the application. This bit must only be set when the Magic Packet Enable, Global Unicast, or Remote wakeup Packet Enable bit is set high. Note: You can gate-off the CSR clock during the power-down mode. However, when the CSR clock is gated-off, you cannot perform any read or write operations on this register. Therefore, the Software cannot clear this bit.
    $01 constant ETH_MGKPKTEN                   \ [0x01] Magic Packet Enable When this bit is set, a power management event is generated when the MAC receives a magic packet.
    $02 constant ETH_RWKPKTEN                   \ [0x02] Remote wakeup Packet Enable When this bit is set, a power management event is generated when the MAC receives a remote wakeup packet.
    $05 constant ETH_MGKPRCVD                   \ [0x05] Magic Packet Received When this bit is set, it indicates that the power management event is generated because of the reception of a magic packet. This bit is cleared when this register is read.
    $06 constant ETH_RWKPRCVD                   \ [0x06] Remote wakeup Packet Received When this bit is set, it indicates that the power management event is generated because of the reception of a remote wakeup packet. This bit is cleared when this register is read.
    $09 constant ETH_GLBLUCAST                  \ [0x09] Global Unicast When this bit set, any unicast packet filtered by the MAC (DAF) address recognition is detected as a remote wakeup packet.
    $0a constant ETH_RWKPFE                     \ [0x0a] Remote wakeup Packet Forwarding Enable When this bit is set along with RWKPKTEN, the MAC receiver drops all received frames until it receives the expected wakeup frame. All frames after that event including the received wakeup frame are forwarded to application. This bit is then self-cleared on receiving the wakeup packet. The application can also clear this bit before the expected wakeup frame is received. In such cases, the MAC reverts to the default behavior where packets received are forwarded to the application. This bit must only be set when RWKPKTEN is set high and PWRDWN is set low. The setting of this bit has no effect when PWRDWN is set high. Note: If Magic Packet Enable and wakeup Frame Enable are both set along with setting of this bit and Magic Packet is received prior to wakeup frame, this bit is self-cleared on receiving Magic Packet, the received Magic packet is dropped, and all frames after received Magic Packet are forwarded to application.
    $18 constant ETH_RWKPTR                     \ [0x18 : 5] Remote wakeup FIFO Pointer This field gives the current value (0 to 7) of the Remote wakeup Packet Filter register pointer. When the value of this pointer is equal to 7, the contents of the Remote wakeup Packet Filter Register are transferred to the eth_mii_rx_clk domain when a Write occurs to that register.
    $1f constant ETH_RWKFILTRST                 \ [0x1f] Remote wakeup Packet Filter Register Pointer Reset When this bit is set, the remote wakeup packet filter register pointer is reset to 3'b000. It is automatically cleared after 1 clock cycle.
  [then]


  [ifdef] ETH_ETH_MACRWKPFR_DEF
    \
    \ @brief Remote wakeup packet filter Refer to and for details on register content and programming sequence.
    \ Address offset: 0xC4
    \ Reset value: 0x00000000
    \
    $00 constant ETH_MACRWKPFR                  \ [0x00 : 32] Remote wakeup packet filter Refer to and for details on register content and programming sequence.
  [then]


  [ifdef] ETH_ETH_MACLCSR_DEF
    \
    \ @brief LPI control status register
    \ Address offset: 0xD0
    \ Reset value: 0x00000000
    \
    $00 constant ETH_TLPIEN                     \ [0x00] Transmit LPI Entry When this bit is set, it indicates that the MAC Transmitter has entered the LPI state because of the setting of the LPIEN bit. This bit is cleared by a read into this register.
    $01 constant ETH_TLPIEX                     \ [0x01] Transmit LPI Exit When this bit is set, it indicates that the MAC transmitter exited the LPI state after the application cleared the LPIEN bit and the LPI TW Timer has expired. This bit is cleared by a read into this register.
    $02 constant ETH_RLPIEN                     \ [0x02] Receive LPI Entry When this bit is set, it indicates that the MAC Receiver has received an LPI pattern and entered the LPI state. This bit is cleared by a read into this register. Note: This bit may not be set if the MAC stops receiving the LPI pattern for a very short duration, such as, less than three clock cycles of CSR clock.
    $03 constant ETH_RLPIEX                     \ [0x03] Receive LPI Exit When this bit is set, it indicates that the MAC Receiver has stopped receiving the LPI pattern on the GMII or MII interface, exited the LPI state, and resumed the normal reception. This bit is cleared by a read into this register. Note: This bit may not be set if the MAC stops receiving the LPI pattern for a very short duration, such as, less than three clock cycles of CSR clock.
    $08 constant ETH_TLPIST                     \ [0x08] Transmit LPI State When this bit is set, it indicates that the MAC is transmitting the LPI pattern on the GMII or MII interface.
    $09 constant ETH_RLPIST                     \ [0x09] Receive LPI State When this bit is set, it indicates that the MAC is receiving the LPI pattern on the GMII or MII interface.
    $10 constant ETH_LPIEN                      \ [0x10] LPI Enable When this bit is set, it instructs the MAC Transmitter to enter the LPI state. When this bit is reset, it instructs the MAC to exit the LPI state and resume normal transmission. This bit is cleared when the LPITXA bit is set and the MAC exits the LPI state because of the arrival of a new packet for transmission.
    $11 constant ETH_PLS                        \ [0x11] PHY Link Status This bit indicates the link status of the PHY. The MAC Transmitter asserts the LPI pattern only when the link status is up (OKAY) at least for the time indicated by the LPI LS TIMER. When this bit is set, the link is considered to be okay (UP) and when this bit is reset, the link is considered to be down.
    $12 constant ETH_PLSEN                      \ [0x12] PHY Link Status Enable This bit enables the link status received on the RGMII Receive paths to be used for activating the LPI LS TIMER. When this bit is set, the MAC uses the link-status bits of the ETH_MACPHYCSR register and the PLS bit for the LPI LS Timer trigger. When this bit is reset, the MAC ignores the link-status bits of the ETH_MACPHYCSR register and takes only the PLS bit. This bit is RO and reserved if you have not selected the RGMII PHY interface.
    $13 constant ETH_LPITXA                     \ [0x13] LPI Tx Automate This bit controls the behavior of the MAC when it is entering or coming out of the LPI mode on the Transmit side. If the LPITXA and LPIEN bits are set to 1, the MAC enters the LPI mode only after all outstanding packets (in the core) and pending packets (in the application interface) have been transmitted. The MAC comes out of the LPI mode when the application sends any packet for transmission or the application issues a Tx FIFO Flush command. In addition, the MAC automatically clears the LPIEN bit when it exits the LPI state. If Tx FIFO Flush is set in the FTQ bit of ETH_MTLTxQiOMR, when the MAC is in the LPI mode, it exits the LPI mode. When this bit is 0, the LPIEN bit directly controls behavior of the MAC when it is entering or coming out of the LPI mode.
    $14 constant ETH_LPITE                      \ [0x14] LPI Timer Enable This bit controls the automatic entry of the MAC Transmitter into and exit out of the LPI state. When LPITE, LPITXA and LPITXEN bits are set, the MAC Transmitter enters LPI state only when the complete MAC TX data path is IDLE for a period indicated by the ETH_MACLETR register. After entering LPI state, if the data path becomes non-IDLE (due to a new packet being accepted for transmission), the Transmitter exits LPI state but does not clear LPITXEN bit. This enables the re-entry into LPI state when it is IDLE again. When LPITE is 0, the LPI Auto timer is disabled and MAC Transmitter enters LPI state based on the settings of LPITXA and LPITXEN bit descriptions.
  [then]


  [ifdef] ETH_ETH_MACLTCR_DEF
    \
    \ @brief LPI timers control register
    \ Address offset: 0xD4
    \ Reset value: 0x03E80000
    \
    $00 constant ETH_TWT                        \ [0x00 : 16] LPI TW Timer This field specifies the minimum time (in microseconds) for which the MAC waits after it stops transmitting the LPI pattern to the PHY and before it resumes the normal transmission. The TLPIEX status bit is set after the expiry of this timer.
    $10 constant ETH_LST                        \ [0x10 : 10] LPI LS Timer This field specifies the minimum time (in milliseconds) for which the link status from the PHY should be up (OKAY) before the LPI pattern can be transmitted to the PHY. The MAC does not transmit the LPI pattern even when the LPIEN bit is set unless the LPI LS Timer reaches the programmed terminal count. The default value of the LPI LS Timer is 1000 (1 sec) as defined in the IEEE standard.
  [then]


  [ifdef] ETH_ETH_MACLETR_DEF
    \
    \ @brief LPI entry timer register
    \ Address offset: 0xD8
    \ Reset value: 0x00000000
    \
    $03 constant ETH_LPIET                      \ [0x03 : 17] LPI Entry Timer This field specifies the time in microseconds the MAC will wait to enter LPI mode, after it has transmitted all the frames. This field is valid and used only when LPITE and LPITXA are set to 1. Bits [2:0] are read-only so that the granularity of this timer is in steps of 8 micro-seconds.
  [then]


  [ifdef] ETH_ETH_MAC1USTCR_DEF
    \
    \ @brief FIXME 1-microsecond-tick counter register
    \ Address offset: 0xDC
    \ Reset value: 0x00000000
    \
    $00 constant ETH_TIC_1US_CNTR               \ [0x00 : 12] 1 µs tick Counter The application must program this counter so that the number of clock cycles of CSR clock is 1 µs. (Subtract 1 from the value before programming). For example if the CSR clock is 100 MHz then this field needs to be programmed to 100 - 1 = 99 (which is 0x63). This is required to generate the 1 µs events that are used to update some of the EEE related counters.
  [then]


  [ifdef] ETH_ETH_MACPHYCSR_DEF
    \
    \ @brief PHYIF control status register
    \ Address offset: 0xF8
    \ Reset value: 0x00000000
    \
    $00 constant ETH_TC                         \ [0x00] Transmit Configuration in RGMII When set, this bit enables the transmission of duplex mode, link speed, and link up or down information to the PHY in the RGMII port. When this bit is reset, no such information is driven to the PHY (see ).
    $01 constant ETH_LUD                        \ [0x01] Link Up or Down This bit indicates whether the link is up or down during transmission of configuration in the RGMII interface.
    $10 constant ETH_LNKMOD                     \ [0x10] Link Mode This bit indicates the current operating mode of the link:
    $11 constant ETH_LNKSPEED                   \ [0x11 : 2] Link Speed This bit indicates the current speed of the link:
    $13 constant ETH_LNKSTS                     \ [0x13] Link Status This bit indicates whether the link is up (1'b1) or down (1'b0).
    $14 constant ETH_JABTO                      \ [0x14] Jabber Timeout This bit indicates the jabber timeout error (1'b1) in the received packet. This bit is reserved when the MAC is configured for the RGMII PHY interface.
  [then]


  [ifdef] ETH_ETH_MACVR_DEF
    \
    \ @brief Version register
    \ Address offset: 0x110
    \ Reset value: 0x00001242
    \
    $00 constant ETH_SNPSVER                    \ [0x00 : 8] IP version
    $08 constant ETH_USERVER                    \ [0x08 : 8] ST-defined version
  [then]


  [ifdef] ETH_ETH_MACDR_DEF
    \
    \ @brief Debug register
    \ Address offset: 0x114
    \ Reset value: 0x00000000
    \
    $00 constant ETH_RPESTS                     \ [0x00] MAC GMII or MII Receive Protocol Engine Status When this bit is set, it indicates that the MAC GMII or MII receive protocol engine is actively receiving data, and it is not in the Idle state.
    $01 constant ETH_RFCFCSTS                   \ [0x01 : 2] MAC Receive Packet Controller FIFO Status When this bit is set, this field indicates the active state of the small FIFO Read and Write controllers of the MAC Receive Packet Controller module.
    $10 constant ETH_TPESTS                     \ [0x10] MAC GMII or MII Transmit Protocol Engine Status When this bit is set, it indicates that the MAC GMII or MII transmit protocol engine is actively transmitting data, and it is not in the Idle state.
    $11 constant ETH_TFCSTS                     \ [0x11 : 2] MAC Transmit Packet Controller Status This field indicates the state of the MAC Transmit Packet Controller module: Status of the previous packet OR IPG or backoff period to be over
  [then]


  [ifdef] ETH_ETH_MACHWF0R_DEF
    \
    \ @brief HW feature 0 register
    \ Address offset: 0x11C
    \ Reset value: 0x0A0D73F7
    \
    $00 constant ETH_MIISEL                     \ [0x00] 10 or 100 Mbps Support This bit is set to 1 when 10/100 Mbps is selected as operating mode.
    $01 constant ETH_GMIISEL                    \ [0x01] 1000 Mbps Support This bit is set to 1 when 1000 Mbps is selected as operating mode.
    $02 constant ETH_HDSEL                      \ [0x02] Half-duplex Support This bit is set to 1 when the half-duplex mode is selected
    $03 constant ETH_PCSSEL                     \ [0x03] PCS Registers (TBI, SGMII, or RTBI PHY interface) This bit is set to 1 when the TBI, SGMII, or RTBI PHY interface option is selected
    $04 constant ETH_VLHASH                     \ [0x04] VLAN Hash Filter Selected This bit is set to 1 when the Enable VLAN Hash Table Based Filtering option is selected
    $05 constant ETH_SMASEL                     \ [0x05] SMA (MDIO) Interface This bit is set to 1 when the Enable Station Management (MDIO Interface) option is selected
    $06 constant ETH_RWKSEL                     \ [0x06] PMT Remote Wakeup Packet Enable This bit is set to 1 when the Enable Remote wakeup Packet Detection option is selected
    $07 constant ETH_MGKSEL                     \ [0x07] PMT Magic Packet Enable This bit is set to 1 when the Enable Magic Packet Detection option is selected
    $08 constant ETH_MMCSEL                     \ [0x08] RMON Module Enable This bit is set to 1 when the Enable MAC management counters (MMC) option is selected
    $09 constant ETH_ARPOFFSEL                  \ [0x09] ARP Offload Enabled This bit is set to 1 when the Enable IPv4 ARP Offload option is selected
    $0c constant ETH_TSSEL                      \ [0x0c] IEEE 1588-2008 Timestamp Enabled This bit is set to 1 when the Enable IEEE 1588 Timestamp Support option is selected
    $0d constant ETH_EEESEL                     \ [0x0d] Energy Efficient Ethernet Enabled This bit is set to 1 when the Enable Energy Efficient Ethernet (EEE) option is selected
    $0e constant ETH_TXCOESEL                   \ [0x0e] Transmit Checksum Offload Enabled This bit is set to 1 when the Enable Transmit TCP/IP Checksum Insertion option is selected
    $10 constant ETH_RXCOESEL                   \ [0x10] Receive Checksum Offload Enabled This bit is set to 1 when the Enable Receive TCP/IP Checksum Check option is selected
    $12 constant ETH_ADDMACADRSEL               \ [0x12 : 5] MAC Addresses 1-31 Selected This bit is set to 1 when the Enable Additional 1-31 MAC Address Registers option is selected
    $17 constant ETH_MACADR32SEL                \ [0x17] MAC Addresses 32-63 Selected This bit is set to 1 when the Enable Additional 32 MAC Address Registers (32-63) option is selected
    $18 constant ETH_MACADR64SEL                \ [0x18] MAC Addresses 64-127 Selected This bit is set to 1 when the Enable Additional 64 MAC Address Registers (64-127) option is selected
    $19 constant ETH_TSSTSSEL                   \ [0x19 : 2] Timestamp System Time Source This bit indicates the source of the Timestamp system time: This bit is set to 1 when the Enable IEEE 1588 Timestamp Support option is selected
    $1b constant ETH_SAVLANINS                  \ [0x1b] Source Address or VLAN Insertion Enable This bit is set to 1 when the Enable SA and VLAN Insertion on Tx option is selected
    $1c constant ETH_ACTPHYSEL                  \ [0x1c : 3] Active PHY Selected When you have multiple PHY interfaces in your configuration, this field indicates the sampled value of phy_intf_sel_i during reset de-assertion: Others: Reserved, must not be used
  [then]


  [ifdef] ETH_ETH_MACHWF1R_DEF
    \
    \ @brief HW feature 1 register
    \ Address offset: 0x120
    \ Reset value: 0x11041904
    \
    $00 constant ETH_RXFIFOSIZE                 \ [0x00 : 5] MTL Receive FIFO Size This field contains the configured value of MTL Rx FIFO in bytes expressed as Log to base 2 minus 7, that is, Log2(RXFIFO_SIZE) -7:
    $06 constant ETH_TXFIFOSIZE                 \ [0x06 : 5] MTL Transmit FIFO Size This field contains the configured value of MTL Tx FIFO in bytes expressed as Log to base 2 minus 7, that is, Log2(TXFIFO_SIZE) -7:
    $0b constant ETH_OSTEN                      \ [0x0b] One-Step Timestamping Enable This bit is set to 1 when the Enable One-Step Timestamp Feature is selected.
    $0c constant ETH_PTOEN                      \ [0x0c] PTP Offload Enable This bit is set to 1 when the Enable PTP Timestamp Offload Feature is selected.
    $0d constant ETH_ADVTHWORD                  \ [0x0d] IEEE 1588 High Word Register Enable This bit is set to 1 when the Add IEEE 1588 Higher Word Register option is selected
    $0e constant ETH_ADDR64                     \ [0x0e : 2] Address width This field indicates the configured address width. Others: Reserved, must not be used
    $10 constant ETH_DCBEN                      \ [0x10] DCB Feature Enable This bit is set to 1 when the Enable Data Center Bridging option is selected
    $11 constant ETH_SPHEN                      \ [0x11] Split Header Feature Enable This bit is set to 1 when the Enable Split Header Structure option is selected
    $12 constant ETH_TSOEN                      \ [0x12] TCP Segmentation Offload Enable This bit is set to 1 when the Enable TCP Segmentation Offloading for TCP/IP Packets option is selected
    $13 constant ETH_DBGMEMA                    \ [0x13] DMA Debug Registers Enable This bit is set to 1 when the Debug Mode Enable option is selected
    $14 constant ETH_AVSEL                      \ [0x14] AV Feature Enable This bit is set to 1 when the Enable Audio Video Bridging option is selected.
    $18 constant ETH_HASHTBLSZ                  \ [0x18 : 2] Hash Table Size This field indicates the size of the Hash table:
    $1b constant ETH_L3L4FNUM                   \ [0x1b : 4] Total number of L3 or L4 Filters This field indicates the total number of L3 or L4 filters: ..
  [then]


  [ifdef] ETH_ETH_MACHWF2R_DEF
    \
    \ @brief HW feature 2 register
    \ Address offset: 0x124
    \ Reset value: 0x41040041
    \
    $00 constant ETH_RXQCNT                     \ [0x00 : 4] Number of MTL Receive Queues This field indicates the number of MTL Receive queues: ..
    $06 constant ETH_TXQCNT                     \ [0x06 : 4] Number of MTL Transmit Queues This field indicates the number of MTL Transmit queues: ..
    $0c constant ETH_RXCHCNT                    \ [0x0c : 4] Number of DMA Receive Channels This field indicates the number of DMA Receive channels: ..
    $12 constant ETH_TXCHCNT                    \ [0x12 : 4] Number of DMA Transmit Channels This field indicates the number of DMA Transmit channels: ..
    $18 constant ETH_PPSOUTNUM                  \ [0x18 : 3] Number of PPS Outputs This field indicates the number of PPS outputs:
    $1c constant ETH_AUXSNAPNUM                 \ [0x1c : 3] Number of Auxiliary Snapshot Inputs This field indicates the number of auxiliary snapshot inputs:
  [then]


  [ifdef] ETH_ETH_MACHWF3R_DEF
    \
    \ @brief HW feature 3 register
    \ Address offset: 0x128
    \ Reset value: 0x00000020
    \
    $00 constant ETH_NRVF                       \ [0x00 : 3] Number of Extended VLAN Tag Filters Enabled This field indicates the Number of Extended VLAN Tag Filters selected:
    $04 constant ETH_CBTISEL                    \ [0x04] Queue/Channel based VLAN tag insertion on Tx enable This bit is set to 1 when the Enable Queue/Channel based VLAN tag insertion on Tx feature is selected.
    $05 constant ETH_DVLAN                      \ [0x05] Number of auxiliary snapshot inputs This field indicates the number of auxiliary snapshot inputs /*FIXME enum values removed for the moment */
  [then]


  [ifdef] ETH_ETH_MACMDIOAR_DEF
    \
    \ @brief MDIO address register
    \ Address offset: 0x200
    \ Reset value: 0x00000000
    \
    $00 constant ETH_GB                         \ [0x00] GMII Busy The application sets this bit to instruct the SMA to initiate a Read or Write access to the MDIOS. The MAC clears this bit after the MDIO frame transfer is completed. Hence the software must not write or change any of the fields in ETH_MACMDIOAR and ETH_MACMDIODR registers as long as this bit is set. For write transfers, the application must first write 16-bit data in the GD field (and also RA field when C45E is set) in ETH_MACMDIODR register before setting this bit. When C45E is set, it should also write into the RA field of ETH_MACMDIODR register before initiating a read transfer. When a read transfer is completed (GMII busy=0), the data read from the PHY register is valid in the GD field of the ETH_MACMDIODR register. Note: Even if the addressed PHY is not present, there is no change in the functionality of this bit.
    $01 constant ETH_C45E                       \ [0x01] Clause 45 PHY Enable When this bit is set, Clause 45 capable PHY is connected to MDIO. When this bit is reset, Clause 22 capable PHY is connected to MDIO.
    $02 constant ETH_GOC                        \ [0x02 : 2] GMII Operation Command This bit indicates the operation command to the PHY. When Clause 22 PHY is enabled, only Write and Read commands are valid.
    $04 constant ETH_SKAP                       \ [0x04] Skip Address Packet When this bit is set, the SMA does not send the address packets before read, write, or post-read increment address packets. This bit is valid only when C45E is set.
    $08 constant ETH_CR                         \ [0x08 : 4] CSR Clock Range The CSR Clock Range selection determines the frequency of the MDC clock according to the CSR clock frequency used in your design: The suggested range of CSR clock frequency applicable for each value (when Bit 11 = 0) ensures that the MDC clock is approximately between 1.0 MHz to 2.5 MHz frequency range. When Bit 11 is set, you can achieve a higher frequency of the MDC clock than the frequency limit of 2.5 MHz (specified in the IEEE 802.3) and program a clock divider of lower value. For example, when CSR clock is of 100 MHz frequency and you program these bits as 1010, the resultant MDC clock is of 12.5 MHz which is above the range specified in IEEE 802.3. Program the following values only if the interfacing chips support faster MDC clocks:
    $0c constant ETH_NTC                        \ [0x0c : 3] Number of Training Clocks This field controls the number of trailing clock cycles generated on ETH_MDC after the end of transmission of MDIO frame. The valid values can be from 0 to 7. Programming the value to 3'h3 indicates that there are additional three clock cycles on the MDC line after the end of MDIO frame transfer.
    $10 constant ETH_RDA                        \ [0x10 : 5] Register/Device Address These bits select the PHY register in selected Clause 22 PHY device. These bits select the Device (MMD) in selected Clause 45 capable PHY.
    $15 constant ETH_PA                         \ [0x15 : 5] Physical Layer Address This field indicates which Clause 22 PHY devices (out of 32 devices) the MAC is accessing. This field indicates which Clause 45 capable PHYs (out of 32 PHYs) the MAC is accessing.
    $1a constant ETH_BTB                        \ [0x1a] Back to Back transactions When this bit is set and the NTC has value greater than 0, then the MAC will inform the completion of a read or write command at the end of frame transfer (before the trailing clocks are transmitted). The software can thus initiate the next command which will be executed immediately irrespective of the number trailing clocks generated for the previous frame. When this bit is reset, then the read/write command completion (GMII busy is cleared) only after the trailing clocks are generated. In this mode, it is ensured that the NTC is always generated after each frame. This bit must not be set when NTC=0.
    $1b constant ETH_PSE                        \ [0x1b] Preamble Suppression Enable When this bit is set, the SMA will suppress the 32-bit preamble and transmit MDIO frames with only 1 preamble bit. When this bit is 0, the MDIO frame always has 32 bits of preamble as defined in the IEEE specifications.
  [then]


  [ifdef] ETH_ETH_MACMDIODR_DEF
    \
    \ @brief MDIO data register
    \ Address offset: 0x204
    \ Reset value: 0x00000000
    \
    $00 constant ETH_GD                         \ [0x00 : 16] GMII Data This field contains the 16-bit data value read from the PHY after a Management Read operation or the 16-bit data value to be written to the PHY before a Management Write operation.
    $10 constant ETH_RA                         \ [0x10 : 16] Register Address This field is valid only when C45E is set. It contains the Register Address in the PHY to which the MDIO frame is intended for.
  [then]


  [ifdef] ETH_ETH_MACARPAR_DEF
    \
    \ @brief ARP address register
    \ Address offset: 0x210
    \ Reset value: 0x00000000
    \
    $00 constant ETH_ARPPA                      \ [0x00 : 32] ARP Protocol Address This field contains the IPv4 Destination Address of the MAC. This address is used for perfect match with the Protocol Address of Target field in the received ARP packet.
  [then]


  [ifdef] ETH_ETH_MACCSRSWCR_DEF
    \
    \ @brief CSR software control register
    \ Address offset: 0x230
    \ Reset value: 0x00000000
    \
    $00 constant ETH_RCWE                       \ [0x00] Register Clear on Write 1 Enable When this bit is set, the access mode to some register fields changes to rc_w1 (clear on write) meaning that the application needs to set that respective bit to 1 to clear it. When this bit is reset, the access mode to these register fields remains rc_r (clear on read).
    $08 constant ETH_SEEN                       \ [0x08] Slave Error Response Enable When this bit is set, the MAC responds with a Slave Error for accesses to reserved registers in CSR space. When this bit is reset, the MAC responds with an Okay response to any register accessed from CSR space.
  [then]


  [ifdef] ETH_ETH_MACA0HR_DEF
    \
    \ @brief Address 0 high register
    \ Address offset: 0x300
    \ Reset value: 0x8000FFFF
    \
    $00 constant ETH_ADDRHI                     \ [0x00 : 16] MAC Address0[47:32] This field contains the upper 16 bits [47:32] of the first 6-byte MAC address. The MAC uses this field for filtering the received packets and inserting the MAC address in the Transmit Flow Control (Pause) Packets.
    $1f constant ETH_AE                         \ [0x1f] Address Enable This bit is always set to 1.
  [then]


  [ifdef] ETH_ETH_MACA0LR_DEF
    \
    \ @brief Address 0 low register
    \ Address offset: 0x304
    \ Reset value: 0xFFFFFFFF
    \
    $00 constant ETH_ADDRLO                     \ [0x00 : 32] MAC Address x [31:0] (x = 0 to 3) This field contains the lower 32 bits of the first 6-byte MAC address. The MAC uses this field for filtering the received packets and inserting the MAC address in the Transmit Flow Control (Pause) Packets.
  [then]


  [ifdef] ETH_ETH_MACA1HR_DEF
    \
    \ @brief Address 1 high register
    \ Address offset: 0x308
    \ Reset value: 0x0000FFFF
    \
    $00 constant ETH_ADDRHI                     \ [0x00 : 16] MAC Address1 [47:32] This field contains the upper 16 bits[47:32] of the second 6-byte MAC address.
    $18 constant ETH_MBC                        \ [0x18 : 6] Mask Byte Control These bits are mask control bits for comparing each of the MAC Address bytes. When set high, the MAC does not compare the corresponding byte of received DA or SA with the contents of MAC Address1 registers. Each bit controls the masking of the bytes as follows: Bit 29: Register 194[15:8] Bit 28: Register 194[7:0] Bit 27: Register 195[31:24] .. Bit 24: Register 195[7:0] You can filter a group of addresses (known as group address filtering) by masking one or more bytes of the address.
    $1e constant ETH_SA                         \ [0x1e] Source Address When this bit is set, the MAC Address1[47:0] is used to compare with the SA fields of the received packet. When this bit is reset, the MAC Address x[47:0] is used to compare with the DA fields of the received packet.
    $1f constant ETH_AE                         \ [0x1f] Address Enable When this bit is set, the address filter module uses the second MAC address for perfect filtering. When this bit is reset, the address filter module ignores the address for filtering.
  [then]


  [ifdef] ETH_ETH_MACA1LR_DEF
    \
    \ @brief Address 1 low register
    \ Address offset: 0x30C
    \ Reset value: 0xFFFFFFFF
    \
    $00 constant ETH_ADDRLO                     \ [0x00 : 32] MAC Address x [31:0] (x = 0 to 3) This field contains the lower 32 bits of the first 6-byte MAC address. The MAC uses this field for filtering the received packets and inserting the MAC address in the Transmit Flow Control (Pause) Packets.
  [then]


  [ifdef] ETH_ETH_MACA2HR_DEF
    \
    \ @brief Address 2 high register
    \ Address offset: 0x310
    \ Reset value: 0x0000FFFF
    \
    $00 constant ETH_ADDRHI                     \ [0x00 : 16] MAC Address1 [47:32] This field contains the upper 16 bits[47:32] of the second 6-byte MAC address.
    $18 constant ETH_MBC                        \ [0x18 : 6] Mask Byte Control These bits are mask control bits for comparing each of the MAC Address bytes. When set high, the MAC does not compare the corresponding byte of received DA or SA with the contents of MAC Address1 registers. Each bit controls the masking of the bytes as follows: Bit 29: Register 194[15:8] Bit 28: Register 194[7:0] Bit 27: Register 195[31:24] .. Bit 24: Register 195[7:0] You can filter a group of addresses (known as group address filtering) by masking one or more bytes of the address.
    $1e constant ETH_SA                         \ [0x1e] Source Address When this bit is set, the MAC Address1[47:0] is used to compare with the SA fields of the received packet. When this bit is reset, the MAC Address x[47:0] is used to compare with the DA fields of the received packet.
    $1f constant ETH_AE                         \ [0x1f] Address Enable When this bit is set, the address filter module uses the second MAC address for perfect filtering. When this bit is reset, the address filter module ignores the address for filtering.
  [then]


  [ifdef] ETH_ETH_MACA2LR_DEF
    \
    \ @brief Address 2 low register
    \ Address offset: 0x314
    \ Reset value: 0xFFFFFFFF
    \
    $00 constant ETH_ADDRLO                     \ [0x00 : 32] MAC Address x [31:0] (x = 0 to 3) This field contains the lower 32 bits of the first 6-byte MAC address. The MAC uses this field for filtering the received packets and inserting the MAC address in the Transmit Flow Control (Pause) Packets.
  [then]


  [ifdef] ETH_ETH_MACA3HR_DEF
    \
    \ @brief Address 3 high register
    \ Address offset: 0x318
    \ Reset value: 0x0000FFFF
    \
    $00 constant ETH_ADDRHI                     \ [0x00 : 16] MAC Address1 [47:32] This field contains the upper 16 bits[47:32] of the second 6-byte MAC address.
    $18 constant ETH_MBC                        \ [0x18 : 6] Mask Byte Control These bits are mask control bits for comparing each of the MAC Address bytes. When set high, the MAC does not compare the corresponding byte of received DA or SA with the contents of MAC Address1 registers. Each bit controls the masking of the bytes as follows: Bit 29: Register 194[15:8] Bit 28: Register 194[7:0] Bit 27: Register 195[31:24] .. Bit 24: Register 195[7:0] You can filter a group of addresses (known as group address filtering) by masking one or more bytes of the address.
    $1e constant ETH_SA                         \ [0x1e] Source Address When this bit is set, the MAC Address1[47:0] is used to compare with the SA fields of the received packet. When this bit is reset, the MAC Address x[47:0] is used to compare with the DA fields of the received packet.
    $1f constant ETH_AE                         \ [0x1f] Address Enable When this bit is set, the address filter module uses the second MAC address for perfect filtering. When this bit is reset, the address filter module ignores the address for filtering.
  [then]


  [ifdef] ETH_ETH_MACA3LR_DEF
    \
    \ @brief Address 3 low register
    \ Address offset: 0x31C
    \ Reset value: 0xFFFFFFFF
    \
    $00 constant ETH_ADDRLO                     \ [0x00 : 32] MAC Address x [31:0] (x = 0 to 3) This field contains the lower 32 bits of the first 6-byte MAC address. The MAC uses this field for filtering the received packets and inserting the MAC address in the Transmit Flow Control (Pause) Packets.
  [then]


  [ifdef] ETH_ETH_MMC_CONTROL_DEF
    \
    \ @brief MMC control register
    \ Address offset: 0x700
    \ Reset value: 0x00000000
    \
    $00 constant ETH_CNTRST                     \ [0x00] Counters Reset When this bit is set, all counters are reset. This bit is cleared automatically after 1 clock cycle.
    $01 constant ETH_CNTSTOPRO                  \ [0x01] Counter Stop Rollover When this bit is set, the counter does not roll over to zero after reaching the maximum value.
    $02 constant ETH_RSTONRD                    \ [0x02] Reset on Read When this bit is set, the MMC counters are reset to zero after Read (self-clearing after reset). The counters are cleared when the least significant byte lane (Bits[7:0]) is read.
    $03 constant ETH_CNTFREEZ                   \ [0x03] MMC Counter Freeze When this bit is set, it freezes all MMC counters to their current value. Until this bit is reset to 0, no MMC counter is updated because of any transmitted or received packet. If any MMC counter is read with the Reset on Read bit set, then that counter is also cleared in this mode.
    $04 constant ETH_CNTPRST                    \ [0x04] Counters Preset When this bit is set, all counters are initialized or preset to almost full or almost half according to the CNTPRSTLVL bit. This bit is cleared automatically after 1 clock cycle. This bit, along with the CNTPRSTLVL bit, is useful for debugging and testing the assertion of interrupts because of MMC counter becoming half-full or full.
    $05 constant ETH_CNTPRSTLVL                 \ [0x05] Full-Half Preset When this bit is low and the CNTPRST bit is set, all MMC counters get preset to almost-half value. All octet counters get preset to 0x7FFF_F800 (Half 2Kbytes) and all packet-counters get preset to 0x7FFF_FFF0 (Half 16). When this bit is high and the CNTPRST bit is set, all MMC counters get preset to almost-full value. All octet counters get preset to 0xFFFF_F800 (Full 2Kbytes) and all packet-counters get preset to 0xFFFF_FFF0 (Full 16). For 16-bit counters, the almost-half preset values are 0x7800 and 0x7FF0 for the respective octet and packet counters. Similarly, the almost-full preset values for the 16-bit counters are 0xF800 and 0xFFF0.
    $08 constant ETH_UCDBC                      \ [0x08] Update MMC Counters for Dropped Broadcast Packets The CNTRST bit has a higher priority than the CNTPRST bit. Therefore, when the software tries to set both bits in the same write cycle, all counters are cleared and the CNTPRST bit is not set. When set, the MAC updates all related MMC Counters for Broadcast packets that are dropped because of the setting of the DBF bit of ETH_MACPFR register. When reset, the MMC Counters are not updated for dropped Broadcast packets.
  [then]


  [ifdef] ETH_ETH_MMC_RX_INTERRUPT_DEF
    \
    \ @brief MMC Rx interrupt register
    \ Address offset: 0x704
    \ Reset value: 0x00000000
    \
    $05 constant ETH_RXCRCERPIS                 \ [0x05] MMC Receive CRC Error Packet Counter Interrupt Status This bit is set when the rxcrcerror counter reaches half of the maximum value or the maximum value.
    $06 constant ETH_RXALGNERPIS                \ [0x06] MMC Receive Alignment Error Packet Counter Interrupt Status This bit is set when the rxalignmenterror counter reaches half of the maximum value or the maximum value.
    $11 constant ETH_RXUCGPIS                   \ [0x11] MMC Receive Unicast Good Packet Counter Interrupt Status This bit is set when the rxunicastpackets_g counter reaches half of the maximum value or the maximum value.
    $1a constant ETH_RXLPIUSCIS                 \ [0x1a] MMC Receive LPI microsecond counter interrupt status This bit is set when the Rx_LPI_USEC_Cntr counter reaches half of the maximum value or the maximum value.
    $1b constant ETH_RXLPITRCIS                 \ [0x1b] MMC Receive LPI transition counter interrupt status This bit is set when the Rx_LPI_Tran_Cntr counter reaches half of the maximum value or the maximum value.
  [then]


  [ifdef] ETH_ETH_MMC_TX_INTERRUPT_DEF
    \
    \ @brief MMC Tx interrupt register
    \ Address offset: 0x708
    \ Reset value: 0x00000000
    \
    $0e constant ETH_TXSCOLGPIS                 \ [0x0e] MMC Transmit Single Collision Good Packet Counter Interrupt Status This bit is set when the txsinglecol_g counter reaches half of the maximum value or the maximum value.
    $0f constant ETH_TXMCOLGPIS                 \ [0x0f] MMC Transmit Multiple Collision Good Packet Counter Interrupt Status This bit is set when the txmulticol_g counter reaches half of the maximum value or the maximum value.
    $15 constant ETH_TXGPKTIS                   \ [0x15] MMC Transmit Good Packet Counter Interrupt Status This bit is set when the txpacketcount_g counter reaches half of the maximum value or the maximum value.
    $1a constant ETH_TXLPIUSCIS                 \ [0x1a] MMC Transmit LPI microsecond counter interrupt status This bit is set when the Tx_LPI_USEC_Cntr counter reaches half of the maximum value or the maximum value.
    $1b constant ETH_TXLPITRCIS                 \ [0x1b] MMC Transmit LPI transition counter interrupt status This bit is set when the Tx_LPI_Tran_Cntr counter reaches half of the maximum value or the maximum value.
  [then]


  [ifdef] ETH_ETH_MMC_RX_INTERRUPT_MASK_DEF
    \
    \ @brief MMC Rx interrupt mask register
    \ Address offset: 0x70C
    \ Reset value: 0x00000000
    \
    $05 constant ETH_RXCRCERPIM                 \ [0x05] MMC Receive CRC Error Packet Counter Interrupt Mask Setting this bit masks the interrupt when the rxcrcerror counter reaches half of the maximum value or the maximum value.
    $06 constant ETH_RXALGNERPIM                \ [0x06] MMC Receive Alignment Error Packet Counter Interrupt Mask Setting this bit masks the interrupt when the rxalignmenterror counter reaches half of the maximum value or the maximum value.
    $11 constant ETH_RXUCGPIM                   \ [0x11] MMC Receive Unicast Good Packet Counter Interrupt Mask Setting this bit masks the interrupt when the rxunicastpackets_g counter reaches half of the maximum value or the maximum value.
    $1a constant ETH_RXLPIUSCIM                 \ [0x1a] MMC Receive LPI microsecond counter interrupt Mask Setting this bit masks the interrupt when the Rx_LPI_USEC_Cntr counter reaches half of the maximum value or the maximum value.
    $1b constant ETH_RXLPITRCIM                 \ [0x1b] MMC Receive LPI transition counter interrupt Mask Setting this bit masks the interrupt when the Rx_LPI_Tran_Cntr counter reaches half of the maximum value or the maximum value.
  [then]


  [ifdef] ETH_ETH_MMC_TX_INTERRUPT_MASK_DEF
    \
    \ @brief MMC Tx interrupt mask register
    \ Address offset: 0x710
    \ Reset value: 0x00000000
    \
    $0e constant ETH_TXSCOLGPIM                 \ [0x0e] MMC Transmit Single Collision Good Packet Counter Interrupt Mask Setting this bit masks the interrupt when the txsinglecol_g counter reaches half of the maximum value or the maximum value.
    $0f constant ETH_TXMCOLGPIM                 \ [0x0f] MMC Transmit Multiple Collision Good Packet Counter Interrupt Mask Setting this bit masks the interrupt when the txmulticol_g counter reaches half of the maximum value or the maximum value.
    $15 constant ETH_TXGPKTIM                   \ [0x15] MMC Transmit Good Packet Counter Interrupt Mask Setting this bit masks the interrupt when the txpacketcount_g counter reaches half of the maximum value or the maximum value.
    $1a constant ETH_TXLPIUSCIM                 \ [0x1a] MMC Transmit LPI microsecond counter interrupt Mask Setting this bit masks the interrupt when the Tx_LPI_USEC_Cntr counter reaches half of the maximum value or the maximum value.
    $1b constant ETH_TXLPITRCIM                 \ [0x1b] MMC Transmit LPI transition counter interrupt Mask Setting this bit masks the interrupt when the Tx_LPI_Tran_Cntr counter reaches half of the maximum value or the maximum value.
  [then]


  [ifdef] ETH_ETH_TX_SINGLE_COLLISION_GOOD_PACKETS_DEF
    \
    \ @brief Tx single collision good packets register
    \ Address offset: 0x74C
    \ Reset value: 0x00000000
    \
    $00 constant ETH_TXSNGLCOLG                 \ [0x00 : 32] Tx Single Collision Good Packets This field indicates the number of successfully transmitted packets after a single collision in the half-duplex mode.
  [then]


  [ifdef] ETH_ETH_TX_MULTIPLE_COLLISION_GOOD_PACKETS_DEF
    \
    \ @brief Tx multiple collision good packets register
    \ Address offset: 0x750
    \ Reset value: 0x00000000
    \
    $00 constant ETH_TXMULTCOLG                 \ [0x00 : 32] Tx Multiple Collision Good Packets This field indicates the number of successfully transmitted packets after multiple collisions in the half-duplex mode.
  [then]


  [ifdef] ETH_ETH_TX_PACKET_COUNT_GOOD_DEF
    \
    \ @brief Tx packet count good register
    \ Address offset: 0x768
    \ Reset value: 0x00000000
    \
    $00 constant ETH_TXPKTG                     \ [0x00 : 32] Tx Packet Count Good This field indicates the number of good packets transmitted.
  [then]


  [ifdef] ETH_ETH_RX_CRC_ERROR_PACKETS_DEF
    \
    \ @brief Rx CRC error packets register
    \ Address offset: 0x794
    \ Reset value: 0x00000000
    \
    $00 constant ETH_RXCRCERR                   \ [0x00 : 32] Rx CRC Error Packets This field indicates the number of packets received with CRC error.
  [then]


  [ifdef] ETH_ETH_RX_ALIGNMENT_ERROR_PACKETS_DEF
    \
    \ @brief Rx alignment error packets register
    \ Address offset: 0x798
    \ Reset value: 0x00000000
    \
    $00 constant ETH_RXALGNERR                  \ [0x00 : 32] Rx Alignment Error Packets This field indicates the number of packets received with alignment (dribble) error. It is valid only in 10/100 mode.
  [then]


  [ifdef] ETH_ETH_RX_UNICAST_PACKETS_GOOD_DEF
    \
    \ @brief Rx unicast packets good register
    \ Address offset: 0x7C4
    \ Reset value: 0x00000000
    \
    $00 constant ETH_RXUCASTG                   \ [0x00 : 32] Rx Unicast Packets Good This field indicates the number of good unicast packets received.
  [then]


  [ifdef] ETH_ETH_TX_LPI_USEC_CNTR_DEF
    \
    \ @brief Tx LPI microsecond timer register
    \ Address offset: 0x7EC
    \ Reset value: 0x00000000
    \
    $00 constant ETH_TXLPIUSC                   \ [0x00 : 32] Tx LPI Microseconds Counter This field indicates the number of microseconds Tx LPI is asserted. For every Tx LPI Entry and Exit, the Timer value can have an error of +/- 1 microsecond.
  [then]


  [ifdef] ETH_ETH_TX_LPI_TRAN_CNTR_DEF
    \
    \ @brief Tx LPI transition counter register
    \ Address offset: 0x7F0
    \ Reset value: 0x00000000
    \
    $00 constant ETH_TXLPITRC                   \ [0x00 : 32] Tx LPI Transition counter This field indicates the number of times Tx LPI Entry has occurred. Even if Tx LPI Entry occurs in Automate Mode (because of LPITXA bit set in the LPI Control and Status register), the counter will increment.
  [then]


  [ifdef] ETH_ETH_RX_LPI_USEC_CNTR_DEF
    \
    \ @brief Rx LPI microsecond counter register
    \ Address offset: 0x7F4
    \ Reset value: 0x00000000
    \
    $00 constant ETH_RXLPIUSC                   \ [0x00 : 32] Rx LPI Microseconds Counter This field indicates the number of microseconds Rx LPI is asserted. For every Rx LPI Entry and Exit, the Timer value can have an error of +/- 1 microsecond.
  [then]


  [ifdef] ETH_ETH_RX_LPI_TRAN_CNTR_DEF
    \
    \ @brief Rx LPI transition counter register
    \ Address offset: 0x7F8
    \ Reset value: 0x00000000
    \
    $00 constant ETH_RXLPITRC                   \ [0x00 : 32] Rx LPI Transition counter This field indicates the number of times Rx LPI Entry has occurred.
  [then]


  [ifdef] ETH_ETH_MACL3L4C0R_DEF
    \
    \ @brief L3 and L4 control 0 register
    \ Address offset: 0x900
    \ Reset value: 0x00000000
    \
    $00 constant ETH_L3PEN0                     \ [0x00] Layer 3 Protocol Enable When this bit is set, the Layer 3 IP Source or Destination Address matching is enabled for IPv6 packets. When this bit is reset, the Layer 3 IP Source or Destination Address matching is enabled for IPv4 packets. The Layer 3 matching is done only when the L3SAM0 or L3DAM0 bit is set.
    $02 constant ETH_L3SAM0                     \ [0x02] Layer 3 IP SA Match Enable When this bit is set, the Layer 3 IP Source Address field is enabled for matching. When this bit is reset, the MAC ignores the Layer 3 IP Source Address field for matching. Note: When the L3PEN0 bit is set, you should set either this bit or the L3DAM0 bit because either IPv6 SA or DA can be checked for filtering.
    $03 constant ETH_L3SAIM0                    \ [0x03] Layer 3 IP SA Inverse Match Enable When this bit is set, the Layer 3 IP Source Address field is enabled for inverse matching. When this bit reset, the Layer 3 IP Source Address field is enabled for perfect matching. This bit is valid and applicable only when the L3SAM0 bit is set.
    $04 constant ETH_L3DAM0                     \ [0x04] Layer 3 IP DA Match Enable When this bit is set, the Layer 3 IP Destination Address field is enabled for matching. When this bit is reset, the MAC ignores the Layer 3 IP Destination Address field for matching. Note: When the L3PEN0 bit is set, you should set either this bit or the L3SAM0 bit because either IPv6 DA or SA can be checked for filtering.
    $05 constant ETH_L3DAIM0                    \ [0x05] Layer 3 IP DA Inverse Match Enable When this bit is set, the Layer 3 IP Destination Address field is enabled for inverse matching. When this bit is reset, the Layer 3 IP Destination Address field is enabled for perfect matching. This bit is valid and applicable only when the L3DAM0 bit is set high.
    $06 constant ETH_L3HSBM0                    \ [0x06 : 5] Layer 3 IP SA higher bits match This field contains the number of lower bits of IP source address that are masked for matching in the IPv4 packets. The following list describes the values of this field: 2: Two LSbs [1:0] are masked .. 31: All bits except MSb are masked. IPv6 Packets: This field contains Bits[4:0] of L3HSBM0. These bits indicate the number of higher bits of IP source or destination address matched in the IPv6 packets. This field is valid and applicable only when the L3DAM0 or L3SAM0 bit is set high.
    $0b constant ETH_L3HDBM0                    \ [0x0b : 5] Layer 3 IP DA higher bits match IPv4 Packets: For IPv4 packets, this field contains the number of higher bits of IP Destination Address that are masked in the IPv4 packets. Number of bits masked for matching goes from 0 (No bit is masked) to 31 (All bits except MSb are masked) For IPv6 packets, bits[12:11] of this field correspond to Bits[6:5] of L3HSBM0 which indicate the number of lower bits of IP Source or Destination Address that are masked in the IPv6 packets. Number of bits masked is given by concatenated values of the L3HDBM0[1:0] and L3HSBM0 bits from 0 (No bit is masked) to 127 (All bits except MSb are masked) This field is valid and applicable only when the L3DAM0 or L3SAM0 bit is set.
    $10 constant ETH_L4PEN0                     \ [0x10] Layer 4 Protocol Enable When this bit is set, the Source and Destination Port number fields of UDP packets are used for matching. When this bit is reset, the Source and Destination Port number fields of TCP packets are used for matching. The Layer 4 matching is done only when the L4SPM0 or L4DPM0 bit is set.
    $12 constant ETH_L4SPM0                     \ [0x12] Layer 4 Source Port Match Enable When this bit is set, the Layer 4 Source Port number field is enabled for matching. When this bit is reset, the MAC ignores the Layer 4 Source Port number field for matching.
    $13 constant ETH_L4SPIM0                    \ [0x13] Layer 4 Source Port Inverse Match Enable When this bit is set, the Layer 4 Source Port number field is enabled for inverse matching. When this bit is reset, the Layer 4 Source Port number field is enabled for perfect matching. This bit is valid and applicable only when the L4SPM0 bit is set high.
    $14 constant ETH_L4DPM0                     \ [0x14] Layer 4 Destination Port Match Enable When this bit is set, the Layer 4 Destination Port number field is enabled for matching. When this bit is reset, the MAC ignores the Layer 4 Destination Port number field for matching.
    $15 constant ETH_L4DPIM0                    \ [0x15] Layer 4 Destination Port Inverse Match Enable When this bit is set, the Layer 4 Destination Port number field is enabled for inverse matching. When this bit is reset, the Layer 4 Destination Port number field is enabled for perfect matching. This bit is valid and applicable only when the L4DPM0 bit is set high.
  [then]


  [ifdef] ETH_ETH_MACL4A0R_DEF
    \
    \ @brief Layer 4 Source Port Number Field When the L4PEN0 bit is reset and the L4DPM0 bit is set in the ETH_MACL3L4C0R register, this field contains the value to be matched with the TCP Source Port Number field in the IPv4 or IPv6 packets. When the L4PEN0 and L4DPM0 bits are set in ETH_MACL3L4C0R register, this field contains the value to be matched with the UDP Source Port Number field in the IPv4 or IPv6 packets.
    \ Address offset: 0x904
    \ Reset value: 0x00000000
    \
    $00 constant ETH_L4SP0                      \ [0x00 : 16] Layer 4 Source Port Number Field When the L4PEN0 bit is reset and the L4DPM0 bit is set in the ETH_MACL3L4C0R register, this field contains the value to be matched with the TCP Source Port Number field in the IPv4 or IPv6 packets. When the L4PEN0 and L4DPM0 bits are set in ETH_MACL3L4C0R register, this field contains the value to be matched with the UDP Source Port Number field in the IPv4 or IPv6 packets.
    $10 constant ETH_L4DP0                      \ [0x10 : 16] Layer 4 Destination Port Number Field When the L4PEN0 bit is reset and the L4DPM0 bit is set in the ETH_MACL3L4C0R register, this field contains the value to be matched with the TCP Destination Port Number field in the IPv4 or IPv6 packets. When the L4PEN0 and L4DPM0 bits are set in ETH_MACL3L4C0R register, this field contains the value to be matched with the UDP Destination Port Number field in the IPv4 or IPv6 packets.
  [then]


  [ifdef] ETH_ETH_MACL3A00R_DEF
    \
    \ @brief Layer 3 Address 0 filter 0 register
    \ Address offset: 0x910
    \ Reset value: 0x00000000
    \
    $00 constant ETH_L3A00                      \ [0x00 : 32] Layer 3 Address 0 Field When the L3PEN0 and L3SAM0 bits are set in the ETH_MACL3L4C0R register, this field contains the value to be matched with Bits[31:0] of the IP Source Address field in the IPv6 packets. When the L3PEN0 and L3DAM0 bits are set in the ETH_MACL3L4C0R register, this field contains the value to be matched with Bits[31:0] of the IP Destination Address field in the IPv6 packets. When the L3PEN0 bit is reset and the L3SAM0 bit is set in the ETH_MACL3L4C0R register, this field contains the value to be matched with the IP Source Address field in the IPv4 packets.
  [then]


  [ifdef] ETH_ETH_MACL3A10R_DEF
    \
    \ @brief Layer3 address 1 filter 0 register
    \ Address offset: 0x914
    \ Reset value: 0x00000000
    \
    $00 constant ETH_L3A10                      \ [0x00 : 32] Layer 3 Address 1 Field When the L3PEN0 and L3SAM0 bits are set in the ETH_MACL3L4C0R register, this field contains the value to be matched with Bits[63:32] of the IP Source Address field in the IPv6 packets. When the L3PEN0 and L3DAM0 bits are set in the ETH_MACL3L4C0R register, this field contains the value to be matched with Bits[63:32] of the IP Destination Address field in the IPv6 packets. When the L3PEN0 bit is reset and the L3SAM0 bit is set in the ETH_MACL3L4C0R register, this field contains the value to be matched with the IP Destination Address field in the IPv4 packets.
  [then]


  [ifdef] ETH_ETH_MACL3A20R_DEF
    \
    \ @brief Layer3 Address 2 filter 0 register
    \ Address offset: 0x918
    \ Reset value: 0x00000000
    \
    $00 constant ETH_L3A20                      \ [0x00 : 32] Layer 3 Address 2 Field When the L3PEN0 and L3SAM0 bits are set in the ETH_MACL3L4C0R register, this field contains the value to be matched with Bits[95:64] of the IP Source Address field in the IPv6 packets. When the L3PEN0 and L3DAM0 bits are set in the ETH_MACL3L4C0R register, this field contains the value to be matched with Bits[95:64] of the IP Destination Address field in the IPv6 packets. When the L3PEN0 bit is reset in the ETH_MACL3L4C0R register, this field is not used.
  [then]


  [ifdef] ETH_ETH_MACL3A30R_DEF
    \
    \ @brief Layer3 Address 3 filter 0 register
    \ Address offset: 0x91C
    \ Reset value: 0x00000000
    \
    $00 constant ETH_L3A30                      \ [0x00 : 32] Layer 3 Address 3 Field When the L3PEN0 and L3SAM0 bits are set in the ETH_MACL3L4C0R register, this field contains the value to be matched with Bits[127:96] of the IP Source Address field in the IPv6 packets. When the L3PEN0 and L3DAM0 bits are set in the ETH_MACL3L4C0R register, this field contains the value to be matched with Bits[127:96] of the IP Destination Address field in the IPv6 packets. When the L3PEN0 bit is reset in the ETH_MACL3L4C0R register, this field is not used.
  [then]


  [ifdef] ETH_ETH_MACL3L4C1R_DEF
    \
    \ @brief L3 and L4 control 1 register
    \ Address offset: 0x930
    \ Reset value: 0x00000000
    \
    $00 constant ETH_L3PEN1                     \ [0x00] Layer 3 Protocol Enable When this bit is set, the Layer 3 IP Source or Destination Address matching is enabled for IPv6 packets. When this bit is reset, the Layer 3 IP Source or Destination Address matching is enabled for IPv4 packets. The Layer 3 matching is done only when the L3SAM0 or L3DAM0 bit is set.
    $02 constant ETH_L3SAM1                     \ [0x02] Layer 3 IP SA Match Enable When this bit is set, the Layer 3 IP Source Address field is enabled for matching. When this bit is reset, the MAC ignores the Layer 3 IP Source Address field for matching. Note: When the L3PEN0 bit is set, you should set either this bit or the L3DAM0 bit because either IPv6 SA or DA can be checked for filtering.
    $03 constant ETH_L3SAIM1                    \ [0x03] Layer 3 IP SA Inverse Match Enable When this bit is set, the Layer 3 IP Source Address field is enabled for inverse matching. When this bit reset, the Layer 3 IP Source Address field is enabled for perfect matching. This bit is valid and applicable only when the L3SAM0 bit is set.
    $04 constant ETH_L3DAM1                     \ [0x04] Layer 3 IP DA Match Enable When this bit is set, the Layer 3 IP Destination Address field is enabled for matching. When this bit is reset, the MAC ignores the Layer 3 IP Destination Address field for matching. Note: When the L3PEN0 bit is set, you should set either this bit or the L3SAM0 bit because either IPv6 DA or SA can be checked for filtering.
    $05 constant ETH_L3DAIM1                    \ [0x05] Layer 3 IP DA Inverse Match Enable When this bit is set, the Layer 3 IP Destination Address field is enabled for inverse matching. When this bit is reset, the Layer 3 IP Destination Address field is enabled for perfect matching. This bit is valid and applicable only when the L3DAM0 bit is set high.
    $06 constant ETH_L3HSBM1                    \ [0x06 : 5] Layer 3 IP SA Higher Bits Match IPv4 Packets: This field contains the number of lower bits of IP Source Address that are masked for matching in the IPv4 packets. The following list describes the values of this field: 2: Two LSbs [1:0] are masked .. 31: All bits except MSb are masked. IPv6 Packets: This field contains Bits[4:0] of L3HSBM0. These bits indicate the number of higher bits of IP Source or Destination Address matched in the IPv6 packets. This field is valid and applicable only when the L3DAM0 or L3SAM0 bit is set high.
    $0b constant ETH_L3HDBM1                    \ [0x0b : 5] Layer 3 IP DA higher bits match This field contains the number of lower bits of IP destination address that are masked for matching in the IPv4 packets. The following list describes the values of this field: 2: Two LSbs [1:0] are masked .. 31: All bits except MSb are masked. IPv6 Packets: This field contains Bits[4:0] of L3HSBM0. These bits indicate the number of higher bits of IP source or destination address matched in the IPv6 packets. This field is valid and applicable only when the L3DAM0 or L3SAM0 bit is set high.IPv4 Packets:
    $10 constant ETH_L4PEN1                     \ [0x10] Layer 4 Protocol Enable When this bit is set, the Source and Destination Port number fields of UDP packets are used for matching. When this bit is reset, the Source and Destination Port number fields of TCP packets are used for matching. The Layer 4 matching is done only when the L4SPM0 or L4DPM0 bit is set.
    $12 constant ETH_L4SPM1                     \ [0x12] Layer 4 Source Port Match Enable When this bit is set, the Layer 4 Source Port number field is enabled for matching. When this bit is reset, the MAC ignores the Layer 4 Source Port number field for matching.
    $13 constant ETH_L4SPIM1                    \ [0x13] Layer 4 Source Port Inverse Match Enable When this bit is set, the Layer 4 Source Port number field is enabled for inverse matching. When this bit is reset, the Layer 4 Source Port number field is enabled for perfect matching. This bit is valid and applicable only when the L4SPM0 bit is set high.
    $14 constant ETH_L4DPM1                     \ [0x14] Layer 4 Destination Port Match Enable When this bit is set, the Layer 4 Destination Port number field is enabled for matching. When this bit is reset, the MAC ignores the Layer 4 Destination Port number field for matching.
    $15 constant ETH_L4DPIM1                    \ [0x15] Layer 4 Destination Port Inverse Match Enable When this bit is set, the Layer 4 Destination Port number field is enabled for inverse matching. When this bit is reset, the Layer 4 Destination Port number field is enabled for perfect matching. This bit is valid and applicable only when the L4DPM0 bit is set high.
  [then]


  [ifdef] ETH_ETH_MACL4A1R_DEF
    \
    \ @brief Layer 4 Source Port Number Field When the L4PEN0 bit is reset and the L4DPM0 bit is set in the ETH_MACL3L4C0R register, this field contains the value to be matched with the TCP Source Port Number field in the IPv4 or IPv6 packets. When the L4PEN0 and L4DPM0 bits are set in ETH_MACL3L4C0R register, this field contains the value to be matched with the UDP Source Port Number field in the IPv4 or IPv6 packets.
    \ Address offset: 0x934
    \ Reset value: 0x00000000
    \
    $00 constant ETH_L4SP1                      \ [0x00 : 16] Layer 4 Source Port Number Field When the L4PEN0 bit is reset and the L4DPM0 bit is set in the ETH_MACL3L4C0R register, this field contains the value to be matched with the TCP Source Port Number field in the IPv4 or IPv6 packets. When the L4PEN0 and L4DPM0 bits are set in ETH_MACL3L4C0R register, this field contains the value to be matched with the UDP Source Port Number field in the IPv4 or IPv6 packets.
    $10 constant ETH_L4DP1                      \ [0x10 : 16] Layer 4 Destination Port Number Field When the L4PEN0 bit is reset and the L4DPM0 bit is set in the ETH_MACL3L4C0R register, this field contains the value to be matched with the TCP Destination Port Number field in the IPv4 or IPv6 packets. When the L4PEN0 and L4DPM0 bits are set in ETH_MACL3L4C0R register, this field contains the value to be matched with the UDP Destination Port Number field in the IPv4 or IPv6 packets.
  [then]


  [ifdef] ETH_ETH_MACL3A01R_DEF
    \
    \ @brief Layer3 address 0 filter 1 Register
    \ Address offset: 0x940
    \ Reset value: 0x00000000
    \
    $00 constant ETH_L3A01                      \ [0x00 : 32] Layer 3 Address 0 Field When the L3PEN0 and L3SAM0 bits are set in the ETH_MACL3L4C0R register, this field contains the value to be matched with Bits[31:0] of the IP Source Address field in the IPv6 packets. When the L3PEN0 and L3DAM0 bits are set in the ETH_MACL3L4C0R register, this field contains the value to be matched with Bits[31:0] of the IP Destination Address field in the IPv6 packets. When the L3PEN0 bit is reset and the L3SAM0 bit is set in the ETH_MACL3L4C0R register, this field contains the value to be matched with the IP Source Address field in the IPv4 packets.
  [then]


  [ifdef] ETH_ETH_MACL3A11R_DEF
    \
    \ @brief Layer3 address 1 filter 1 register
    \ Address offset: 0x944
    \ Reset value: 0x00000000
    \
    $00 constant ETH_L3A11                      \ [0x00 : 32] Layer 3 Address 1 Field When the L3PEN0 and L3SAM0 bits are set in the ETH_MACL3L4C0R register, this field contains the value to be matched with Bits[63:32] of the IP Source Address field in the IPv6 packets. When the L3PEN0 and L3DAM0 bits are set in the ETH_MACL3L4C0R register, this field contains the value to be matched with Bits[63:32] of the IP Destination Address field in the IPv6 packets. When the L3PEN0 bit is reset and the L3SAM0 bit is set in the ETH_MACL3L4C0R register, this field contains the value to be matched with the IP Destination Address field in the IPv4 packets.
  [then]


  [ifdef] ETH_ETH_MACL3A21R_DEF
    \
    \ @brief Layer3 address 2 filter 1 Register
    \ Address offset: 0x948
    \ Reset value: 0x00000000
    \
    $00 constant ETH_L3A21                      \ [0x00 : 32] Layer 3 Address 2 Field When the L3PEN0 and L3SAM0 bits are set in the ETH_MACL3L4C0R register, this field contains the value to be matched with Bits[95:64] of the IP Source Address field in the IPv6 packets. When the L3PEN0 and L3DAM0 bits are set in the ETH_MACL3L4C0R register, this field contains the value to be matched with Bits[95:64] of the IP Destination Address field in the IPv6 packets. When the L3PEN0 bit is reset in the ETH_MACL3L4C0R register, this field is not used.
  [then]


  [ifdef] ETH_ETH_MACL3A31R_DEF
    \
    \ @brief Layer3 address 3 filter 1 register
    \ Address offset: 0x94C
    \ Reset value: 0x00000000
    \
    $00 constant ETH_L3A31                      \ [0x00 : 32] Layer 3 Address 3 Field When the L3PEN0 and L3SAM0 bits are set in the ETH_MACL3L4C0R register, this field contains the value to be matched with Bits[127:96] of the IP Source Address field in the IPv6 packets. When the L3PEN0 and L3DAM0 bits are set in the ETH_MACL3L4C0R register, this field contains the value to be matched with Bits[127:96] of the IP Destination Address field in the IPv6 packets. When the L3PEN0 bit is reset in the ETH_MACL3L4C0R register, this field is not used.
  [then]


  [ifdef] ETH_ETH_MACTSCR_DEF
    \
    \ @brief Timestamp control Register
    \ Address offset: 0xB00
    \ Reset value: 0x00002000
    \
    $00 constant ETH_TSENA                      \ [0x00] Enable Timestamp When this bit is set, the timestamp is added for Transmit and Receive packets. When disabled, timestamp is not added for transmit and receive packets and the Timestamp Generator is also suspended. You need to initialize the Timestamp (system time) after enabling this mode. On the Receive side, the MAC processes the 1588 packets only if this bit is set.
    $01 constant ETH_TSCFUPDT                   \ [0x01] Fine or Coarse Timestamp Update When this bit is set, the Fine method is used to update system timestamp. When this bit is reset, Coarse method is used to update the system timestamp.
    $02 constant ETH_TSINIT                     \ [0x02] Initialize Timestamp When this bit is set, the system time is initialized (overwritten) with the value specified in the MAC Register 80 (System Time Seconds Update Register) and MAC Register 81 (System Time Nanoseconds Update Register). This bit should be zero before it is updated. This bit is reset when the initialization is complete.
    $03 constant ETH_TSUPDT                     \ [0x03] Update Timestamp When this bit is set, the system time is updated (added or subtracted) with the value specified in ETH_MACSTSUR and ETH_MACSTNUR. This bit should be zero before updating it. This bit is reset when the update is complete in hardware.
    $05 constant ETH_TSADDREG                   \ [0x05] Update Addend Register When this bit is set, the content of the Timestamp Addend register is updated in the PTP block for fine correction. This bit is cleared when the update is complete. This bit should be zero before it is set.
    $08 constant ETH_TSENALL                    \ [0x08] Enable Timestamp for All Packets When this bit is set, the timestamp snapshot is enabled for all packets received by the MAC.
    $09 constant ETH_TSCTRLSSR                  \ [0x09] Timestamp Digital or Binary Rollover Control When this bit is set, the Timestamp Low register rolls over after 0x3B9A_C9FF value (that is, 1 nanosecond accuracy) and increments the timestamp (High) seconds. When this bit is reset, the rollover value of sub-second register is 0x7FFF_FFFF. The sub-second increment must be programmed correctly depending on the PTP reference clock frequency and the value of this bit.
    $0a constant ETH_TSVER2ENA                  \ [0x0a] Enable PTP Packet Processing for Version 2 Format When this bit is set, the IEEE 1588 version 2 format is used to process the PTP packets. When this bit is reset, the IEEE 1588 version 1 format is used to process the PTP packets. The IEEE 1588 formats are described in 'PTP Processing and Control'.
    $0b constant ETH_TSIPENA                    \ [0x0b] Enable Processing of PTP over Ethernet Packets When this bit is set, the MAC receiver processes the PTP packets encapsulated directly in the Ethernet packets. When this bit is reset, the MAC ignores the PTP over Ethernet packets.
    $0c constant ETH_TSIPV6ENA                  \ [0x0c] Enable Processing of PTP Packets Sent over IPv6-UDP When this bit is set, the MAC receiver processes the PTP packets encapsulated in IPv6-UDP packets. When this bit is clear, the MAC ignores the PTP transported over IPv6-UDP packets.
    $0d constant ETH_TSIPV4ENA                  \ [0x0d] Enable Processing of PTP Packets Sent over IPv4-UDP When this bit is set, the MAC receiver processes the PTP packets encapsulated in IPv4-UDP packets. When this bit is reset, the MAC ignores the PTP transported over IPv4-UDP packets. This bit is set by default.
    $0e constant ETH_TSEVNTENA                  \ [0x0e] Enable Timestamp Snapshot for Event Messages When this bit is set, the timestamp snapshot is taken only for event messages (SYNC, Delay_Req, Pdelay_Req, or Pdelay_Resp). When this bit is reset, the snapshot is taken for all messages except Announce, Management, and Signaling. For more information about the timestamp snapshots, see Timestamp Snapshot Dependency on Register Bits Table.
    $0f constant ETH_TSMSTRENA                  \ [0x0f] Enable Snapshot for Messages Relevant to Master When this bit is set, the snapshot is taken only for the messages that are relevant to the master node. Otherwise, the snapshot is taken for the messages relevant to the slave node.
    $10 constant ETH_SNAPTYPSEL                 \ [0x10 : 2] Select PTP packets for Taking Snapshots These bits, along with Bits 15 and 14, decide the set of PTP packet types for which snapshot needs to be taken. The encoding is given in Timestamp Snapshot Dependency on Register Bits Table.
    $12 constant ETH_TSENMACADDR                \ [0x12] Enable MAC Address for PTP Packet Filtering When this bit is set, the DA MAC address (that matches any MAC Address register) is used to filter the PTP packets when PTP is directly sent over Ethernet. When this bit is set, received PTP packets with DA containing a special multicast or unicast address that matches the one programmed in MAC address registers are considered for processing as indicated below, when PTP is directly sent over Ethernet. For normal time stamping operation, MAC address registers 0 to 31 is considered for unicast destination address matching. For PTP offload, only MAC address register 0 is considered for unicast destination address matching.
    $13 constant ETH_CSC                        \ [0x13] Enable checksum correction during OST for PTP over UDP/IPv4 packets When this bit is set, the last two bytes of PTP message sent over UDP/IPv4 is updated to keep the UDP checksum correct, for changes made to origin timestamp and/or correction field as part of one step timestamp operation. The application shall form the packet with these two dummy bytes. When reset, no updates are done to keep the UDP checksum correct. The application shall form the packet with UDP checksum set to 0.
    $18 constant ETH_TXTSSTSM                   \ [0x18] Transmit Timestamp Status Mode When this bit is set, the MAC overwrites the earlier transmit timestamp status even if it is not read by the software. The MAC indicates this by setting the TXTSSTSMIS bit of the ETH_MACTXTSSNR register. When this bit is reset, the MAC ignores the timestamp status of current packet if the timestamp status of previous packet is not read by the software. The MAC indicates this by setting the TXTSSTSHI bit of the ETH_MACTXTSSSR register.
  [then]


  [ifdef] ETH_ETH_MACSSIR_DEF
    \
    \ @brief Sub-second increment register
    \ Address offset: 0xB04
    \ Reset value: 0x00000000
    \
    $10 constant ETH_SSINC                      \ [0x10 : 8] Sub-second Increment Value The value programmed in this field is accumulated every clock cycle (of clk_ptp_i) with the contents of the sub-second register. For example, when the PTP clock is 50 MHz (period is 20 ns), you should program 20 (0x14) when the System Time Nanoseconds register has an accuracy of 1 ns [Bit 9 (TSCTRLSSR) is set in ETH_MACTSCR]. When TSCTRLSSR is clear, the Nanoseconds register has a resolution of ~0.465 ns. In this case, you should program a value of 43 (0x2B) which is derived by 20 ns/0.465.
  [then]


  [ifdef] ETH_ETH_MACSTSR_DEF
    \
    \ @brief System time seconds register
    \ Address offset: 0xB08
    \ Reset value: 0x00000000
    \
    $00 constant ETH_TSS                        \ [0x00 : 32] Timestamp Second The value in this field indicates the current value in seconds of the System Time maintained by the MAC.
  [then]


  [ifdef] ETH_ETH_MACSTNR_DEF
    \
    \ @brief System time nanoseconds register
    \ Address offset: 0xB0C
    \ Reset value: 0x00000000
    \
    $00 constant ETH_TSSS                       \ [0x00 : 31] Timestamp Sub-seconds The value in this field has the sub-second representation of time, with an accuracy of 0.46 ns. When Bit 9 is set in ETH_MACTSCR, each bit represents 1 ns. The maximum value is 0x3B9A_C9FF after which it rolls-over to zero.
  [then]


  [ifdef] ETH_ETH_MACSTSUR_DEF
    \
    \ @brief System time seconds update register
    \ Address offset: 0xB10
    \ Reset value: 0x00000000
    \
    $00 constant ETH_TSS                        \ [0x00 : 32] Timestamp Seconds The value in this field is the sub-second part of the update. When ADDSUB is reset, this field must be programmed with the sub-second part of the update value, with an accuracy based on the TSCTRLSSR bit of the ETH_MACTSCR register. When ADDSUB is set, then this field must be programmed with the complement of the sub-second part of the update value as described below. When TSCTRLSSR is set, then the programmed value must be 10^9 - <sub-second value>. When TSCTRLSSR is reset, then the programmed value must be 2^31 - <sub-second_value> For example, when TSCTRLSSR bit is set and if 2.000000001 seconds need to be subtracted from the system time, then the TSS field in the MAC_Timestamp Seconds update register must be 0xFFFF_FFFE (that is, 2^32 - 2), ADDSUB bit in this register should be set, and the TSSS field must be 0x3B9A_C9FF (that is, 10^9 - 1).
  [then]


  [ifdef] ETH_ETH_MACSTNUR_DEF
    \
    \ @brief Timestamp Sub-seconds The value in this field has the sub-second representation of time, with an accuracy of 0.46 ns. When the TSCTRLSSR bit is set in the ETH_MACTSCR register, each bit represents 1 ns and the programmed value should not exceed 0x3B9A_C9FF.
    \ Address offset: 0xB14
    \ Reset value: 0x00000000
    \
    $00 constant ETH_TSSS                       \ [0x00 : 31] Timestamp Sub-seconds The value in this field has the sub-second representation of time, with an accuracy of 0.46 ns. When the TSCTRLSSR bit is set in the ETH_MACTSCR register, each bit represents 1 ns and the programmed value should not exceed 0x3B9A_C9FF.
    $1f constant ETH_ADDSUB                     \ [0x1f] Add or Subtract Time When this bit is set, the time value is subtracted with the contents of the update register. When this bit is reset, the time value is added with the contents of the update register.
  [then]


  [ifdef] ETH_ETH_MACTSAR_DEF
    \
    \ @brief Timestamp addend register
    \ Address offset: 0xB18
    \ Reset value: 0x00000000
    \
    $00 constant ETH_TSAR                       \ [0x00 : 32] Timestamp Addend Register This field indicates the 32-bit time value to be added to the Accumulator register to achieve time synchronization.
  [then]


  [ifdef] ETH_ETH_MACTSSR_DEF
    \
    \ @brief Timestamp status register
    \ Address offset: 0xB20
    \ Reset value: 0x00000000
    \
    $00 constant ETH_TSSOVF                     \ [0x00] Timestamp Seconds Overflow When this bit is set, it indicates that the seconds value of the timestamp (when supporting version 2 format) has overflowed beyond 32'hFFFF_FFFF.
    $01 constant ETH_TSTARGT0                   \ [0x01] Timestamp Target Time Reached When set, this bit indicates that the value of system time is greater than or equal to the value specified in the ETH_MACPPS_Target_Time_seconds and ETH_MACPPS_Target_Time_Nanoseconds registers.
    $02 constant ETH_AUXTSTRIG                  \ [0x02] Auxiliary Timestamp Trigger Snapshot This bit is set high when the auxiliary snapshot is written to the FIFO.
    $03 constant ETH_TSTRGTERR0                 \ [0x03] Timestamp Target Time Error This bit is set when the latest target time programmed in the ETH_MACPPS_Target_Time_seconds and ETH_MACPPS_Target_Time_Nanoseconds registers elapses. This bit is cleared when the application reads this bit.
    $0f constant ETH_TXTSSIS                    \ [0x0f] Tx Timestamp Status Interrupt Status When drop transmit status is enabled in MTL, this bit is set when the captured transmit timestamp is updated in the ETH_MACTXTSSNR and ETH_MACTXTSSSR registers. When PTP offload feature is enabled, this bit is set when the captured transmit timestamp is updated in the ETH_MACTXTSSNR and ETH_MACTXTSSSR registers, for PTO generated Delay Request and Pdelay request packets. This bit is cleared when the ETH_MACTXTSSSR register is read. This bit is reserved in all other configurations.
    $10 constant ETH_ATSSTN                     \ [0x10 : 4] Auxiliary Timestamp Snapshot Trigger Identifier These bits identify the Auxiliary trigger inputs for which the timestamp available in the Auxiliary Snapshot Register is applicable. When more than one bit is set at the same time, it means that corresponding auxiliary triggers were sampled at the same clock. These bits are applicable only if the number of Auxiliary snapshots is more than one. One bit is assigned for each trigger as shown in the following list: Bit 16: Auxiliary trigger 0 Bit 17: Auxiliary trigger 1 Bit 18: Auxiliary trigger 2 Bit 19: Auxiliary trigger 3 The software can read this register to find the triggers that are set when the timestamp is taken.
    $18 constant ETH_ATSSTM                     \ [0x18] Auxiliary Timestamp Snapshot Trigger Missed This bit is set when the Auxiliary timestamp snapshot FIFO is full and external trigger was set. This indicates that the latest snapshot is not stored in the FIFO.
    $19 constant ETH_ATSNS                      \ [0x19 : 5] Number of Auxiliary Timestamp Snapshots This field indicates the number of Snapshots available in the FIFO. A value equal to the selected depth of FIFO (4, 8, or 16) indicates that the Auxiliary Snapshot FIFO is full. These bits are cleared (to 00000) when the Auxiliary snapshot FIFO clear bit is set.
  [then]


  [ifdef] ETH_ETH_MACTXTSSNR_DEF
    \
    \ @brief Tx timestamp status nanoseconds register
    \ Address offset: 0xB30
    \ Reset value: 0x00000000
    \
    $00 constant ETH_TXTSSLO                    \ [0x00 : 31] Transmit Timestamp Status Low This field contains the 31 bits of the Nanoseconds field of the Transmit packet's captured timestamp.
    $1f constant ETH_TXTSSMIS                   \ [0x1f] Transmit Timestamp Status Missed When this bit is set, it indicates one of the following: The timestamp of the current packet is ignored if TXTSSTSM bit of the ETH_MACTSCR register is reset The timestamp of the previous packet is overwritten with timestamp of the current packet if TXTSSTSM bit of the ETH_MACTSCR register is set.
  [then]


  [ifdef] ETH_ETH_MACTXTSSSR_DEF
    \
    \ @brief Tx timestamp status seconds register
    \ Address offset: 0xB34
    \ Reset value: 0x00000000
    \
    $00 constant ETH_TXTSSHI                    \ [0x00 : 32] Transmit Timestamp Status High This field contains the lower 32 bits of the Seconds field of Transmit packet's captured timestamp.
  [then]


  [ifdef] ETH_ETH_MACACR_DEF
    \
    \ @brief Auxiliary control register
    \ Address offset: 0xB40
    \ Reset value: 0x00000000
    \
    $00 constant ETH_ATSFC                      \ [0x00] Auxiliary Snapshot FIFO Clear When set, this bit resets the pointers of the Auxiliary Snapshot FIFO. This bit is cleared when the pointers are reset and the FIFO is empty. When this bit is high, the auxiliary snapshots are stored in the FIFO.
    $04 constant ETH_ATSEN0                     \ [0x04] Auxiliary Snapshot 0 Enable This bit controls the capturing of Auxiliary Snapshot Trigger 0. When this bit is set, the auxiliary snapshot of the event on eth_ptp_trg0 input is enabled. When this bit is reset, the events on this input are ignored.
    $05 constant ETH_ATSEN1                     \ [0x05] Auxiliary Snapshot 1 Enable This bit controls the capturing of Auxiliary Snapshot Trigger 1. When this bit is set, the auxiliary snapshot of the event on eth_ptp_trg1 input is enabled. When this bit is reset, the events on this input are ignored.
    $06 constant ETH_ATSEN2                     \ [0x06] Auxiliary Snapshot 2 Enable This bit controls the capturing of Auxiliary Snapshot Trigger 2. When this bit is set, the auxiliary snapshot of the event on eth_ptp_trg2 input is enabled. When this bit is reset, the events on this input are ignored.
    $07 constant ETH_ATSEN3                     \ [0x07] Auxiliary Snapshot 3 Enable This bit controls the capturing of Auxiliary Snapshot Trigger 3. When this bit is set, the auxiliary snapshot of the event on eth_ptp_trg3 input is enabled. When this bit is reset, the events on this input are ignored.
  [then]


  [ifdef] ETH_ETH_MACATSNR_DEF
    \
    \ @brief Auxiliary timestamp nanoseconds register
    \ Address offset: 0xB48
    \ Reset value: 0x00000000
    \
    $00 constant ETH_AUXTSLO                    \ [0x00 : 31] Auxiliary Timestamp Contains the lower 31 bits (nanoseconds field) of the auxiliary timestamp.
  [then]


  [ifdef] ETH_ETH_MACATSSR_DEF
    \
    \ @brief Auxiliary timestamp seconds register
    \ Address offset: 0xB4C
    \ Reset value: 0x00000000
    \
    $00 constant ETH_AUXTSHI                    \ [0x00 : 32] Auxiliary Timestamp Contains the lower 32 bits of the Seconds field of the auxiliary timestamp.
  [then]


  [ifdef] ETH_ETH_MACTSIACR_DEF
    \
    \ @brief Timestamp Ingress asymmetric correction register
    \ Address offset: 0xB50
    \ Reset value: 0x00000000
    \
    $00 constant ETH_OSTIAC                     \ [0x00 : 32] One-Step Timestamp Ingress Asymmetry Correction This field contains the ingress path asymmetry value to be added to correctionField of Pdelay_Resp PTP packet. The programmed value should be in units of nanoseconds and multiplied by 2^16. For example, 2.5 ns is represented as 0x00028000. The value can also be negative, which is represented in 2's complement form with bit 31 representing the sign bit.
  [then]


  [ifdef] ETH_ETH_MACTSEACR_DEF
    \
    \ @brief Timestamp Egress asymmetric correction register
    \ Address offset: 0xB54
    \ Reset value: 0x00000000
    \
    $00 constant ETH_OSTEAC                     \ [0x00 : 32] One-Step Timestamp Egress Asymmetry Correction This field contains the egress path asymmetry value to be subtracted from correctionField of Pdelay_Resp PTP packet. The programmed value must be the negated value in units of nanoseconds multiplied by 2^16. For example, if the required correction is +2.5 ns, the programmed value must be 0xFFFD_8000, which is the 2's complement of 0x0002_8000(2.5 * 216). Similarly, if the required correction is -3.3 ns, the programmed value is 0x0003_4CCC (3.3 * 216).
  [then]


  [ifdef] ETH_ETH_MACTSICNR_DEF
    \
    \ @brief Timestamp Ingress correction nanosecond register
    \ Address offset: 0xB58
    \ Reset value: 0x00000000
    \
    $00 constant ETH_TSIC                       \ [0x00 : 32] Timestamp Ingress Correction This field contains the ingress path correction value as defined by the Ingress Correction expression.
  [then]


  [ifdef] ETH_ETH_MACTSECNR_DEF
    \
    \ @brief Timestamp Egress correction nanosecond register
    \ Address offset: 0xB5C
    \ Reset value: 0x00000000
    \
    $00 constant ETH_TSEC                       \ [0x00 : 32] Timestamp Egress Correction This field contains the nanoseconds part of the egress path correction value as defined by the Egress Correction expression.
  [then]


  [ifdef] ETH_ETH_MACPPSCR_DEF
    \
    \ @brief PPS control register
    \ Address offset: 0xB70
    \ Reset value: 0x00000000
    \
    $00 constant ETH_PPSCTRL                    \ [0x00 : 4] PPS Output Frequency Control This field controls the frequency of the PPS output (eth_ptp_pps_out) signal. The default value of PPSCTRL is 0000, and the PPS output is 1 pulse (of width clk_ptp_i) every second. For other values of PPSCTRL, the PPS output becomes a generated clock of following frequencies: .. Note: In the binary rollover mode, the PPS output (eth_ptp_pps_out) has a duty cycle of 50 percent with these frequencies. In the digital rollover mode, the PPS output frequency is an average number. The actual clock is of different frequency that gets synchronized every second. For example: When PPSCTRL = 0001, the PPS (1 Hz) has a low period of 537 ms and a high period of 463 ms When PPSCTRL = 0010, the PPS (2 Hz) is a sequence of One clock of 50 percent duty cycle and 537 ms period Second clock of 463 ms period (268 ms low and 195 ms high) When PPSCTRL = 0011, the PPS (4 Hz) is a sequence of Three clocks of 50 percent duty cycle and 268 ms period Fourth clock of 195 ms period (134 ms low and 61 ms high) This behavior is because of the non-linear toggling of bits in the digital rollover mode in the ETH_MACSTNR register.
    $04 constant ETH_PPSEN0                     \ [0x04] Flexible PPS Output Mode Enable When this bit is set, Bits[3:0] function as PPSCMD. When this bit is reset, Bits[3:0] function as PPSCTRL (Fixed PPS mode).
    $05 constant ETH_TRGTMODSEL0                \ [0x05 : 2] Target Time Register Mode for PPS Output This field indicates the Target Time registers (MAC registers 96 and 97) mode for PPS output signal:
  [then]


  [ifdef] ETH_ETH_MACPPSCR_alternate_DEF
    \
    \ @brief PPS control register
    \ Address offset: 0xB70
    \ Reset value: 0x00000000
    \
    $00 constant ETH_PPSCMD                     \ [0x00 : 4] Flexible PPS Output (eth_ptp_pps_out[0]) Control Programming these bits with a non-zero value instructs the MAC to initiate an event. When the command is transferred or synchronized to the PTP clock domain, these bits get cleared automatically. The software should ensure that these bits are programmed only when they are 'all-zero'. The following list describes the values of PPSCMD0: This command generates single pulse rising at the start point defined in Target Time Registers (register 455 and 456) and of a duration defined in the PPS Width Register. This command generates the train of pulses rising at the start point defined in the Target Time Registers and of a duration defined in the PPS Width Register and repeated at interval defined in the PPS Interval Register. By default, the PPS pulse train is free-running unless stopped by the 'Stop Pulse train at time' or 'Stop Pulse Train immediately' commands. This command cancels the START Single Pulse and START Pulse Train commands if the system time has not crossed the programmed start time. This command stops the train of pulses initiated by the START Pulse Train command (PPSCMD = 0010) after the time programmed in the Target Time registers elapses. This command immediately stops the train of pulses initiated by the START Pulse Train command (PPSCMD = 0010). This command cancels the STOP pulse train at time command if the programmed stop time has not elapsed. The PPS pulse train becomes free-running on the successful execution of this command.
    $04 constant ETH_PPSEN0                     \ [0x04] Flexible PPS Output Mode Enable When this bit is set, Bits[3:0] function as PPSCMD. When this bit is reset, Bits[3:0] function as PPSCTRL (Fixed PPS mode).
    $05 constant ETH_TRGTMODSEL0                \ [0x05 : 2] Target Time Register Mode for PPS Output This field indicates the Target Time registers (MAC registers 96 and 97) mode for PPS output signal:
  [then]


  [ifdef] ETH_ETH_MACPPSTTSR_DEF
    \
    \ @brief PPS target time seconds register
    \ Address offset: 0xB80
    \ Reset value: 0x00000000
    \
    $00 constant ETH_TSTRH0                     \ [0x00 : 32] PPS Target Time Seconds Register This field stores the time in seconds. When the timestamp value matches or exceeds both Target Timestamp registers, the MAC starts or stops the PPS signal output and generates an interrupt (if enabled) based on Target Time mode selected for the corresponding PPS output in the ETH_MACPPSCR register.
  [then]


  [ifdef] ETH_ETH_MACPPSTTNR_DEF
    \
    \ @brief PPS target time nanoseconds register
    \ Address offset: 0xB84
    \ Reset value: 0x00000000
    \
    $00 constant ETH_TTSL0                      \ [0x00 : 31] Target Time Low for PPS Register This register stores the time in (signed) nanoseconds. When the value of the timestamp matches the value in both Target Timestamp registers, the MAC starts or stops the PPS signal output and generates an interrupt (if enabled) based on the TRGTMODSEL0 field (Bits [6:5]) in ETH_MACPPSCR. When the TSCTRLSSR bit is set in the ETH_MACTSCR register, this value should not exceed 0x3B9A_C9FF. The actual start or stop time of the PPS signal output may have an error margin up to one unit of sub-second increment value.
    $1f constant ETH_TRGTBUSY0                  \ [0x1f] PPS Target Time Register Busy The MAC sets this bit when the PPSCMD0 field in the ETH_MACPPSCR register is programmed to 010 or 011. Programming the PPSCMD0 field to 010 or 011 instructs the MAC to synchronize the Target Time Registers to the PTP clock domain. The MAC clears this bit after synchronizing the Target Time Registers to the PTP clock domain The application must not update the Target Time Registers when this bit is read as 1. Otherwise, the synchronization of the previous programmed time gets corrupted.
  [then]


  [ifdef] ETH_ETH_MACPPSIR_DEF
    \
    \ @brief PPS interval register
    \ Address offset: 0xB88
    \ Reset value: 0x00000000
    \
    $00 constant ETH_PPSINT0                    \ [0x00 : 32] PPS Output Signal Interval These bits store the interval between the rising edges of PPS signal output. The interval is stored in terms of number of units of sub-second increment value. You need to program one value less than the required interval. For example, if the PTP reference clock is 50 MHz (period of 20 ns), and desired interval between the rising edges of PPS signal output is 100 ns (that is, 5 units of sub-second increment value), you should program value 4 (5-1) in this register.
  [then]


  [ifdef] ETH_ETH_MACPPSWR_DEF
    \
    \ @brief PPS width register
    \ Address offset: 0xB8C
    \ Reset value: 0x00000000
    \
    $00 constant ETH_PPSWIDTH0                  \ [0x00 : 32] PPS Output Signal Width These bits store the width between the rising edge and corresponding falling edge of PPS signal output. The width is stored in terms of number of units of sub-second increment value. You need to program one value less than the required interval. For example, if PTP reference clock is 50 MHz (period of 20 ns), and width between the rising and corresponding falling edges of PPS signal output is 80 ns (that is, four units of sub-second increment value), you should program value 3 (4-1) in this register. Note: The value programmed in this register must be lesser than the value programmed in ETH_MACPP0IR register.
  [then]


  [ifdef] ETH_ETH_MACPOCR_DEF
    \
    \ @brief PTP Offload control register
    \ Address offset: 0xBC0
    \ Reset value: 0x00000000
    \
    $00 constant ETH_PTOEN                      \ [0x00] PTP Offload Enable When this bit is set, the PTP Offload feature is enabled.
    $01 constant ETH_ASYNCEN                    \ [0x01] Automatic PTP SYNC message Enable When this bit is set, PTP SYNC message is generated periodically based on interval programmed or trigger from application, when the MAC is programmed to be in Clock Master mode.
    $02 constant ETH_APDREQEN                   \ [0x02] Automatic PTP Pdelay_Req message Enable When this bit is set, PTP Pdelay_Req message is generated periodically based on interval programmed or trigger from application, when the MAC is programmed to be in Peer-to-Peer Transparent mode.
    $04 constant ETH_ASYNCTRIG                  \ [0x04] Automatic PTP SYNC message Trigger When this bit is set, one PTP SYNC message is transmitted. This bit is automatically cleared after the PTP SYNC message is transmitted. The application should set the ASYNCEN bit for this operation.
    $05 constant ETH_APDREQTRIG                 \ [0x05] Automatic PTP Pdelay_Req message Trigger When this bit is set, one PTP Pdelay_Req message is transmitted. This bit is automatically cleared after the PTP Pdelay_Req message is transmitted. The application should set the APDREQEN bit for this operation.
    $06 constant ETH_DRRDIS                     \ [0x06] Disable PTO Delay Request/Response response generation When this bit is set, the Delay Request and Delay response will not be generated for received SYNC and Delay request packet respectively, as required by the programmed mode.
    $08 constant ETH_DN                         \ [0x08 : 8] Domain Number This field indicates the domain Number in which the PTP node is operating.
  [then]


  [ifdef] ETH_ETH_MACSPI0R_DEF
    \
    \ @brief PTP Source Port Identity 0 Register
    \ Address offset: 0xBC4
    \ Reset value: 0x00000000
    \
    $00 constant ETH_SPI0                       \ [0x00 : 32] Source Port Identity 0 This field indicates bits [31:0] of sourcePortIdentity of PTP node.
  [then]


  [ifdef] ETH_ETH_MACSPI1R_DEF
    \
    \ @brief PTP Source port identity 1 register
    \ Address offset: 0xBC8
    \ Reset value: 0x00000000
    \
    $00 constant ETH_SPI1                       \ [0x00 : 32] Source Port Identity 1 This field indicates bits [63:32] of sourcePortIdentity of PTP node.
  [then]


  [ifdef] ETH_ETH_MACSPI2R_DEF
    \
    \ @brief PTP Source port identity 2 register
    \ Address offset: 0xBCC
    \ Reset value: 0x00000000
    \
    $00 constant ETH_SPI2                       \ [0x00 : 16] Source Port Identity 2 This field indicates bits [79:64] of sourcePortIdentity of PTP node.
  [then]


  [ifdef] ETH_ETH_MACLMIR_DEF
    \
    \ @brief Log message interval register
    \ Address offset: 0xBD0
    \ Reset value: 0x00000000
    \
    $00 constant ETH_LSI                        \ [0x00 : 8] Log Sync Interval This field indicates the periodicity of the automatically generated SYNC message when the PTP node is Master. Allowed values are -15 to 15. Negative value must be represented in 2's-complement form. For example, if the required value is -1, the value programmed must be 0xFF.
    $08 constant ETH_DRSYNCR                    \ [0x08 : 3] Delay_Req to SYNC Ratio In Slave mode, it is used for controlling frequency of Delay_Req messages transmitted. 2: for every 4 SYNC messages 3: for every 8 SYNC messages 4: for every 16 SYNC messages 5: for every 32 SYNC messages Others: Reserved, must not be used The master sends this information (logMinDelayReqInterval) in the DelayResp PTP messages to the slave. The reception processes this value from the received DelayResp messages and updates this field accordingly. In the Slave mode, the host must not write/update this register unless it has to override the received value. In Master mode, the sum of this field and logSyncInterval (LSI) field is provided in the logMinDelayReqInterval field of the generated multicast Delay_Resp PTP message.
    $18 constant ETH_LMPDRI                     \ [0x18 : 8] Log Min Pdelay_Req Interval This field indicates logMinPdelayReqInterval of PTP node. This is used to schedule the periodic Pdelay request packet transmission. Allowed values are -15 to 15.Negative value must be represented in 2's-complement form. For example, if the required value is -1, the value programmed must be 0xFF.
  [then]


  [ifdef] ETH_ETH_MTLOMR_DEF
    \
    \ @brief Operating mode Register
    \ Address offset: 0xC00
    \ Reset value: 0x00000000
    \
    $01 constant ETH_DTXSTS                     \ [0x01] Drop Transmit Status When this bit is set, the Tx packet status received from the MAC is dropped in the MTL. When this bit is reset, the Tx packet status received from the MAC is forwarded to the application.
    $02 constant ETH_RAA                        \ [0x02] Receive Arbitration Algorithm This field is used to select the arbitration algorithm for the Rx side. Queue 0 has the lowest priority and the last queue has the highest priority.
    $05 constant ETH_SCHALG                     \ [0x05 : 2] Tx Scheduling Algorithm This field indicates the algorithm for Tx scheduling:
    $08 constant ETH_CNTPRST                    \ [0x08] Counters Preset When this bit is set: ETH_MTLTXQiUR register is initialized/preset to 0x7F0. Missed Packet and Overflow Packet counters in ETH_MTLRXQiMPOCR register is initialized/preset to 0x7F0
    $09 constant ETH_CNTCLR                     \ [0x09] Counters Reset When this bit is set, all counters are reset. This bit is cleared automatically after 1 clock cycle. If this bit is set along with CNT_PRESET bit, CNT_PRESET has precedence.
  [then]


  [ifdef] ETH_ETH_MTLISR_DEF
    \
    \ @brief Interrupt status Register
    \ Address offset: 0xC20
    \ Reset value: 0x00000000
    \
    $00 constant ETH_Q0IS                       \ [0x00] Queue 0 interrupt status This bit indicates that an interrupt has been generated by Queue 0. To reset this bit, read ETH_MTLQ0ICSR register to identify the interrupt cause and clear the source.
    $01 constant ETH_Q1IS                       \ [0x01] Queue 1 interrupt status This bit indicates that an interrupt has been generated by Queue 1. To reset this bit, read ETH_MTLQ1ICSR register to identify the interrupt cause and clear the source.
  [then]


  [ifdef] ETH_ETH_MTLTXQ0OMR_DEF
    \
    \ @brief Tx queue 0 operating mode Register
    \ Address offset: 0xD00
    \ Reset value: 0x00000000
    \
    $00 constant ETH_FTQ                        \ [0x00] Flush Transmit Queue When this bit is set, the Tx queue controller logic is reset to its default values. Therefore, all the data in the Tx queue is lost or flushed. This bit is internally reset when the flushing operation is complete. Until this bit is reset, you should not write to the ETH_MTLTXQ1OMR register. The data which is already accepted by the MAC transmitter is not flushed. It is scheduled for transmission and results in underflow and runt packet transmission. Note: The flush operation is complete only when the Tx queue is empty and the application has accepted the pending Tx Status of all transmitted packets. To complete this flush operation, the PHY Tx clock (eth_mii_tx_clk) should be active.
    $01 constant ETH_TSF                        \ [0x01] Transmit Store and Forward When this bit is set, the transmission starts when a full packet resides in the MTL Tx queue. When this bit is set, the TTC values specified in Bits[6:4] of this register are ignored. This bit should be changed only when the transmission is stopped.
    $02 constant ETH_TXQEN                      \ [0x02 : 2] Transmit Queue Enable This field is used to enable/disable the transmit queue 0. Others: Reserved, must not be used. Note: In multiple Tx queues configuration, all the queues are disabled by default. Enable the Tx queue by programming this field.
    $04 constant ETH_TTC                        \ [0x04 : 3] Transmit Threshold Control These bits control the threshold level of the MTL Tx queue. The transmission starts when the packet size within the MTL Tx queue is larger than the threshold. In addition, full packets with length less than the threshold are also transmitted. These bits are used only when the TSF bit is reset.
    $10 constant ETH_TQS                        \ [0x10 : 4] Transmit queue size This field indicates the size of the allocated transmit queues in blocks of 256 bytes. Queue size range from 256 bytes (TQS=0b000) to 2048 bytes (TQS=0b111).
  [then]


  [ifdef] ETH_ETH_MTLTXQ0UR_DEF
    \
    \ @brief Tx queue 0 underflow register
    \ Address offset: 0xD04
    \ Reset value: 0x00000000
    \
    $00 constant ETH_UFFRMCNT                   \ [0x00 : 11] Underflow Packet Counter This field indicates the number of packets aborted by the controller because of Tx queue Underflow. This counter is incremented each time the MAC aborts outgoing packet because of underflow. The counter is cleared when this register is read.
    $0b constant ETH_UFCNTOVF                   \ [0x0b] Overflow Bit for Underflow Packet Counter This bit is set every time the Tx queue Underflow Packet Counter field overflows, that is, it has crossed the maximum count. In such a scenario, the overflow packet counter is reset to all-zeros and this bit indicates that the rollover happened.
  [then]


  [ifdef] ETH_ETH_MTLTXQ0DR_DEF
    \
    \ @brief Tx queue 0 debug Register
    \ Address offset: 0xD08
    \ Reset value: 0x00000000
    \
    $00 constant ETH_TXQPAUSED                  \ [0x00] Transmit Queue in Pause When this bit is high and the Rx flow control is enabled, it indicates that the Tx queue is in the Pause condition (in the full-duplex only mode) because of the following: Reception of the PFC packet for the priorities assigned to the Tx queue when PFC is enabled Reception of 802.3x Pause packet when PFC is disabled
    $01 constant ETH_TRCSTS                     \ [0x01 : 2] MTL Tx Queue Read Controller Status This field indicates the state of the Tx Queue Read Controller:
    $03 constant ETH_TWCSTS                     \ [0x03] MTL Tx Queue Write Controller Status When high, this bit indicates that the MTL Tx queue Write Controller is active, and it is transferring the data to the Tx queue.
    $04 constant ETH_TXQSTS                     \ [0x04] MTL Tx Queue Not Empty Status When this bit is high, it indicates that the MTL Tx queue is not empty and some data is left for transmission.
    $05 constant ETH_TXSTSFSTS                  \ [0x05] MTL Tx Status FIFO Full Status When high, this bit indicates that the MTL Tx Status FIFO is full. Therefore, the MTL cannot accept any more packets for transmission.
    $10 constant ETH_PTXQ                       \ [0x10 : 3] Number of Packets in the Transmit Queue This field indicates the current number of packets in the Tx queue. When the DTXSTS bit of ETH_MTLOMR register is set to 1, this field does not reflect the number of packets in the Transmit queue.
    $14 constant ETH_STXSTSF                    \ [0x14 : 3] Number of Status Words in Tx Status FIFO of Queue This field indicates the current number of status in the Tx Status FIFO of this queue. When the DTXSTS bit of ETH_MTLOMR register is set to 1, this field does not reflect the number of status words in Tx Status FIFO.
  [then]


  [ifdef] ETH_ETH_MTLTXQ0ESR_DEF
    \
    \ @brief Tx queue x ETS status Register
    \ Address offset: 0xD14
    \ Reset value: 0x00000000
    \
    $00 constant ETH_ABS                        \ [0x00 : 24] Average Bits per Slot This field contains the average transmitted bits per slot. When the DCB operation is enabled for Queue x, this field is computed over every 10 million bit times slot (10 ms in 1000 Mbps; 100 ms in 100 Mbps). The maximum value is 0x989680. This bit is reserved in configurations with only one transmit queue.
  [then]


  [ifdef] ETH_ETH_MTLTXQ0QWR_DEF
    \
    \ @brief Tx queue 0 quantum weight register
    \ Address offset: 0xD18
    \ Reset value: 0x00000000
    \
    $00 constant ETH_ISCQW                      \ [0x00 : 7] Quantum weight If WRR algorithm is enabled for queue 0 generic traffic, this field contains the weight for this queue. The maximum value is 0x64.
  [then]


  [ifdef] ETH_ETH_MTLQ0ICSR_DEF
    \
    \ @brief Queue 0 interrupt control status Register
    \ Address offset: 0xD2C
    \ Reset value: 0x00000000
    \
    $00 constant ETH_TXUNFIS                    \ [0x00] Transmit Queue Underflow Interrupt Status This bit indicates that the Transmit Queue had an underflow while transmitting the packet. Transmission is suspended and an Underflow Error TDES3[2] is set. This bit is cleared when the application writes 1 to this bit.
    $08 constant ETH_TXUIE                      \ [0x08] Transmit Queue Underflow Interrupt Enable When this bit is set, the Transmit Queue Underflow interrupt is enabled. When this bit is reset, the Transmit Queue Underflow interrupt is disabled.
    $10 constant ETH_RXOVFIS                    \ [0x10] Receive Queue Overflow Interrupt Status This bit indicates that the Receive Queue had an overflow while receiving the packet. If a partial packet is transferred to the application, the overflow status is set in RDES3[21]. This bit is cleared when the application writes 1 to this bit.
    $18 constant ETH_RXOIE                      \ [0x18] Receive Queue Overflow Interrupt Enable When this bit is set, the Receive Queue Overflow interrupt is enabled. When this bit is reset, the Receive Queue Overflow interrupt is disabled.
  [then]


  [ifdef] ETH_ETH_MTLRXQ0OMR_DEF
    \
    \ @brief Rx queue 0 operating mode register
    \ Address offset: 0xD30
    \ Reset value: 0x00700000
    \
    $00 constant ETH_RTC                        \ [0x00 : 2] Receive Queue Threshold Control These bits control the threshold level of the MTL Rx queue (in bytes): The received packet is transferred to the application or DMA when the packet size within the MTL Rx queue is larger than the threshold. In addition, full packets with length less than the threshold are automatically transferred. This field is valid only when the RSF bit is zero. This field is ignored when the RSF bit is set to 1.
    $03 constant ETH_FUP                        \ [0x03] Forward Undersized Good Packets When this bit is set, the Rx queue forwards the undersized good packets (packets with no error and length less than 64 bytes), including pad-bytes and CRC. When this bit is reset, the Rx queue drops all packets of less than 64 bytes, unless a packet is already transferred because of the lower value of Rx Threshold, for example, RTC = 01.
    $04 constant ETH_FEP                        \ [0x04] Forward Error Packets When this bit is reset, the Rx queue drops packets with error status (CRC error, receive error, watchdog timeout, or overflow). However, if the start byte (write) pointer of a packet is already transferred to the read controller side (in Threshold mode), the packet is not dropped. When this bit is set, all packets except the runt error packets are forwarded to the application or DMA. If the RSF bit is set and the Rx queue overflows when a partial packet is written, the packet is dropped irrespective of the setting of this bit. However, if the RSF bit is reset and the Rx queue overflows when a partial packet is written, a partial packet may be forwarded to the application or DMA.
    $05 constant ETH_RSF                        \ [0x05] Receive Queue Store and Forward When this bit is set, the Ethernet peripheral reads a packet from the Rx queue only after the complete packet has been written to it, ignoring the RTC field of this register. When this bit is reset, the Rx queue operates in the Threshold (cut-through) mode, subject to the threshold specified by the RTC field of this register.
    $06 constant ETH_DIS_TCP_EF                 \ [0x06] Disable Dropping of TCP/IP Checksum Error Packets When this bit is set, the MAC does not drop the packets which only have the errors detected by the Receive Checksum Offload engine. Such packets have errors only in the encapsulated payload. There are no errors (including FCS error) in the Ethernet packet received by the MAC. When this bit is reset, all error packets are dropped if the FEP bit is reset. This bit is reserved and RO when Enable Receive TCP/IP Checksum Check is not selected.
    $07 constant ETH_EHFC                       \ [0x07] Enable Hardware Flow Control When this bit is set, the flow control signal operation, based on the fill-level of Rx queue, is enabled. When reset, the flow control operation is disabled. This bit is not used (reserved and always reset) when the Rx queue is less than 4 Kbytes.
    $08 constant ETH_RFA                        \ [0x08 : 3] Threshold for Activating Flow Control (in half-duplex and full-duplex These bits control the threshold (fill-level of Rx queue) at which the flow control is activated: For more information on encoding for this field, see RFD.
    $0e constant ETH_RFD                        \ [0x0e : 3] Threshold for Deactivating Flow Control (in half-duplex and full-duplex modes) These bits control the threshold (fill-level of Rx queue) at which the flow control is deasserted after activation: 2: Full minus 2 Kbytes, that is, FULL 2 Kbytes 3: Full minus 2.5 Kbytes, that is, FULL 2.5 Kbytes 4: Full minus 2.5 Kbytes, that is, FULL 3 Kbytes 5: Full minus 2.5 Kbytes, that is, FULL 3.5 Kbytes ... 6: Full minus 4 Kbytes, that is, FULL 4 Kbytes 7: Full minus 4.5 Kbytes, that is, FULL 4.5 Kbytes The deassertion is effective only after flow control is asserted. Note: The value must be programmed in such a way to make sure that the threshold is a positive number. When the EHFC is set high, these values are applicable only when the Rx queue size determined by the RQS field of this register, is equal to or greater than 4 Kbytes. For a given queue size, the values ranges between 0 and the encoding for FULL minus (QSIZE - 0.5 Kbyte) and all other values are illegal. Here the term FULL and QSIZE refers to the queue size determined by the RQS field of this register. The width of this field depends on RX FIFO size selected during the configuration. Remaining bits are reserved and read only. This field is reserved and read only when the RX FIFO size selected during configuration is less than 4Kbytes.
    $14 constant ETH_RQS                        \ [0x14 : 3] Receive Queue Size This field indicates the size of the allocated Receive queues in blocks of 256 bytes. The RQS field is read-write only if the number of Rx queues more than one and the reset value is 0x0.
  [then]


  [ifdef] ETH_ETH_MTLRXQ0MPOCR_DEF
    \
    \ @brief Rx queue 0 missed packet and overflow counter register
    \ Address offset: 0xD34
    \ Reset value: 0x00000000
    \
    $00 constant ETH_OVFPKTCNT                  \ [0x00 : 11] Overflow Packet Counter This field indicates the number of packets discarded by the Ethernet peripheral because of Receive queue overflow. This counter is incremented each time the Ethernet peripheral discards an incoming packet because of overflow. This counter is reset when this register is read.
    $0b constant ETH_OVFCNTOVF                  \ [0x0b] Overflow Counter Overflow Bit When set, this bit indicates that the Rx Queue Overflow Packet Counter field crossed the maximum limit.
    $10 constant ETH_MISPKTCNT                  \ [0x10 : 11] Missed Packet Counter This field indicates the number of packets missed by the Ethernet peripheral because the application asserted ari_pkt_flush_i[] for this queue. This counter is reset when this register is read. This counter is incremented by 1 when the DMA discards the packet because of buffer unavailability.
    $1b constant ETH_MISCNTOVF                  \ [0x1b] Missed Packet Counter Overflow Bit When set, this bit indicates that the Rx Queue Missed Packet Counter crossed the maximum limit.
  [then]


  [ifdef] ETH_ETH_MTLRXQ0DR_DEF
    \
    \ @brief Rx queue 0 debug register
    \ Address offset: 0xD38
    \ Reset value: 0x00000000
    \
    $00 constant ETH_RWCSTS                     \ [0x00] MTL Rx Queue Write Controller Active Status When high, this bit indicates that the MTL Rx queue Write controller is active, and it is transferring a received packet to the Rx queue.
    $01 constant ETH_RRCSTS                     \ [0x01 : 2] MTL Rx Queue Read Controller State This field gives the state of the Rx queue Read controller:
    $04 constant ETH_RXQSTS                     \ [0x04 : 2] MTL Rx Queue Fill-Level Status This field gives the status of the fill-level of the Rx queue:
    $10 constant ETH_PRXQ                       \ [0x10 : 14] Number of Packets in Receive Queue This field indicates the current number of packets in the Rx queue. The theoretical maximum value for this field is 256Kbyte/16bytes = 16K Packets, that is, Max_Queue_Size/Min_Packet_Size.
  [then]


  [ifdef] ETH_ETH_MTLRXQ0CR_DEF
    \
    \ @brief Rx queue 0 control register
    \ Address offset: 0xD3C
    \ Reset value: 0x00000000
    \
    $00 constant ETH_RXQ_WEGT                   \ [0x00 : 3] Receive Queue Weight This field indicates the weight assigned to the Rx queue 0. The weight is used as the number of continuous PBL requests or contiguous packets (depending on the RXQ_PKT_ARBIT) allocated to the queue in one arbitration cycle.
    $03 constant ETH_RXQ_FRM_ARBIT              \ [0x03] Receive Queue Packet Arbitration When this bit is set, the Ethernet peripheral drives the packet data to the ARI interface such that the entire packet data of currently-selected queue is transmitted before switching to other queue. When this bit is reset, the Ethernet peripheral drives the packet data to the ARI interface such that the following amount of data of currently-selected queue is transmitted before switching to other queue: PBL amount of data (indicated by ari_qN_pbl_i[]) or complete data of a packet The status and the timestamp are not a part of the PBL data. Therefore, the Ethernet peripheral drives the complete status (including timestamp status) during first PBL request for the packet (in store-and-forward mode) or the last PBL request for the packet (in Threshold mode).
  [then]


  [ifdef] ETH_ETH_MTLTXQ1OMR_DEF
    \
    \ @brief Tx queue 1 operating mode Register
    \ Address offset: 0xD40
    \ Reset value: 0x00000000
    \
    $00 constant ETH_FTQ                        \ [0x00] Flush Transmit Queue When this bit is set, the Tx queue controller logic is reset to its default values. Therefore, all the data in the Tx queue is lost or flushed. This bit is internally reset when the flushing operation is complete. Until this bit is reset, you should not write to the ETH_MTLTXQ1OMR register. The data which is already accepted by the MAC transmitter is not flushed. It is scheduled for transmission and results in underflow and runt packet transmission. Note: The flush operation is complete only when the Tx queue is empty and the application has accepted the pending Tx Status of all transmitted packets. To complete this flush operation, the PHY Tx clock (eth_mii_tx_clk) should be active.
    $01 constant ETH_TSF                        \ [0x01] Transmit Store and Forward When this bit is set, the transmission starts when a full packet resides in the MTL Tx queue. When this bit is set, the TTC values specified in Bits[6:4] of this register are ignored. This bit should be changed only when the transmission is stopped.
    $02 constant ETH_TXQEN                      \ [0x02 : 2] Transmit Queue Enable This field is used to enable/disable the transmit queue 0. Others: Reserved, must not be used. Note: In multiple Tx queues configuration, all the queues are disabled by default. Enable the Tx queue by programming this field.
    $04 constant ETH_TTC                        \ [0x04 : 3] Transmit Threshold Control These bits control the threshold level of the MTL Tx queue. The transmission starts when the packet size within the MTL Tx queue is larger than the threshold. In addition, full packets with length less than the threshold are also transmitted. These bits are used only when the TSF bit is reset.
    $10 constant ETH_TQS                        \ [0x10 : 4] Transmit queue size This field indicates the size of the allocated transmit queues in blocks of 256 bytes. Queue size range from 256 bytes (TQS=0b000) to 2048 bytes (TQS=0b111).
  [then]


  [ifdef] ETH_ETH_MTLTXQ1UR_DEF
    \
    \ @brief Tx queue 1 underflow register
    \ Address offset: 0xD44
    \ Reset value: 0x00000000
    \
    $00 constant ETH_UFFRMCNT                   \ [0x00 : 11] Underflow Packet Counter This field indicates the number of packets aborted by the controller because of Tx queue Underflow. This counter is incremented each time the MAC aborts outgoing packet because of underflow. The counter is cleared when this register is read.
    $0b constant ETH_UFCNTOVF                   \ [0x0b] Overflow Bit for Underflow Packet Counter This bit is set every time the Tx queue Underflow Packet Counter field overflows, that is, it has crossed the maximum count. In such a scenario, the overflow packet counter is reset to all-zeros and this bit indicates that the rollover happened.
  [then]


  [ifdef] ETH_ETH_MTLTXQ1DR_DEF
    \
    \ @brief Tx queue 1 debug Register
    \ Address offset: 0xD48
    \ Reset value: 0x00000000
    \
    $00 constant ETH_TXQPAUSED                  \ [0x00] Transmit Queue in Pause When this bit is high and the Rx flow control is enabled, it indicates that the Tx queue is in the Pause condition (in the full-duplex only mode) because of the following: Reception of the PFC packet for the priorities assigned to the Tx queue when PFC is enabled Reception of 802.3x Pause packet when PFC is disabled
    $01 constant ETH_TRCSTS                     \ [0x01 : 2] MTL Tx Queue Read Controller Status This field indicates the state of the Tx Queue Read Controller:
    $03 constant ETH_TWCSTS                     \ [0x03] MTL Tx Queue Write Controller Status When high, this bit indicates that the MTL Tx queue Write Controller is active, and it is transferring the data to the Tx queue.
    $04 constant ETH_TXQSTS                     \ [0x04] MTL Tx Queue Not Empty Status When this bit is high, it indicates that the MTL Tx queue is not empty and some data is left for transmission.
    $05 constant ETH_TXSTSFSTS                  \ [0x05] MTL Tx Status FIFO Full Status When high, this bit indicates that the MTL Tx Status FIFO is full. Therefore, the MTL cannot accept any more packets for transmission.
    $10 constant ETH_PTXQ                       \ [0x10 : 3] Number of Packets in the Transmit Queue This field indicates the current number of packets in the Tx queue. When the DTXSTS bit of ETH_MTLOMR register is set to 1, this field does not reflect the number of packets in the Transmit queue.
    $14 constant ETH_STXSTSF                    \ [0x14 : 3] Number of Status Words in Tx Status FIFO of Queue This field indicates the current number of status in the Tx Status FIFO of this queue. When the DTXSTS bit of ETH_MTLOMR register is set to 1, this field does not reflect the number of status words in Tx Status FIFO.
  [then]


  [ifdef] ETH_ETH_MTLTXQ1ECR_DEF
    \
    \ @brief Tx queue 1 ETS control Register
    \ Address offset: 0xD50
    \ Reset value: 0x00000000
    \
    $03 constant ETH_CC                         \ [0x03] Credit Control When this bit is set, the accumulated credit parameter in the credit-based shaper algorithm logic is not reset to zero when there is positive credit and no packet to transmit in Channel 1. The credit accumulates even when there is no packet waiting in Channel 1 and another channel is transmitting. When this bit is reset, the accumulated credit parameter in the credit-based shaper algorithm logic is set to zero when there is positive credit and no packet to transmit in Channel 1. When there is no packet waiting in Channel 1 and other channel is transmitting, no credit is accumulated.
  [then]


  [ifdef] ETH_ETH_MTLTXQ1ESR_DEF
    \
    \ @brief Tx queue x ETS status Register
    \ Address offset: 0xD54
    \ Reset value: 0x00000000
    \
    $00 constant ETH_ABS                        \ [0x00 : 24] Average Bits per Slot This field contains the average transmitted bits per slot. When the DCB operation is enabled for Queue x, this field is computed over every 10 million bit times slot (10 ms in 1000 Mbps; 100 ms in 100 Mbps). The maximum value is 0x989680. This bit is reserved in configurations with only one transmit queue.
  [then]


  [ifdef] ETH_ETH_MTLTXQ1QWR_DEF
    \
    \ @brief Tx queue 1 quantum weight register
    \ Address offset: 0xD58
    \ Reset value: 0x00000000
    \
    $00 constant ETH_ISCQW                      \ [0x00 : 7] quantum weight If WRR algorithm is enabled for queue 1 generic traffic, this field contains the weight for this queue. The maximum value is 0x64.
  [then]


  [ifdef] ETH_ETH_MTLTXQ1HCR_DEF
    \
    \ @brief Tx Queue 1 hiCredit register
    \ Address offset: 0xD60
    \ Reset value: 0x00000000
    \
    $00 constant ETH_HC                         \ [0x00 : 29] hiCredit Value This field contains the hiCredit value required for the credit-based shaper algorithm. This is the maximum value that can be accumulated in the credit parameter. This is specified in bits scaled by 1 024. The maximum value is maxInterferenceSize, that is, best-effort maximum packet size (16 384 bytes or 131 072 bits). The value to be specified is 131 072 * 1 024 = 134 217 728 or 0x0800 0000.
  [then]


  [ifdef] ETH_ETH_MTLQ1ICSR_DEF
    \
    \ @brief Queue 1 interrupt control status Register
    \ Address offset: 0xD6C
    \ Reset value: 0x00000000
    \
    $00 constant ETH_TXUNFIS                    \ [0x00] Transmit Queue Underflow Interrupt Status This bit indicates that the Transmit Queue had an underflow while transmitting the packet. Transmission is suspended and an Underflow Error TDES3[2] is set. This bit is cleared when the application writes 1 to this bit.
    $08 constant ETH_TXUIE                      \ [0x08] Transmit Queue Underflow Interrupt Enable When this bit is set, the Transmit Queue Underflow interrupt is enabled. When this bit is reset, the Transmit Queue Underflow interrupt is disabled.
    $10 constant ETH_RXOVFIS                    \ [0x10] Receive Queue Overflow Interrupt Status This bit indicates that the Receive Queue had an overflow while receiving the packet. If a partial packet is transferred to the application, the overflow status is set in RDES3[21]. This bit is cleared when the application writes 1 to this bit.
    $18 constant ETH_RXOIE                      \ [0x18] Receive Queue Overflow Interrupt Enable When this bit is set, the Receive Queue Overflow interrupt is enabled. When this bit is reset, the Receive Queue Overflow interrupt is disabled.
  [then]


  [ifdef] ETH_ETH_MTLRXQ1OMR_DEF
    \
    \ @brief Rx queue 1 operating mode register
    \ Address offset: 0xD70
    \ Reset value: 0x00700000
    \
    $00 constant ETH_RTC                        \ [0x00 : 2] Receive Queue Threshold Control These bits control the threshold level of the MTL Rx queue (in bytes): The received packet is transferred to the application or DMA when the packet size within the MTL Rx queue is larger than the threshold. In addition, full packets with length less than the threshold are automatically transferred. This field is valid only when the RSF bit is zero. This field is ignored when the RSF bit is set to 1.
    $03 constant ETH_FUP                        \ [0x03] Forward Undersized Good Packets When this bit is set, the Rx queue forwards the undersized good packets (packets with no error and length less than 64 bytes), including pad-bytes and CRC. When this bit is reset, the Rx queue drops all packets of less than 64 bytes, unless a packet is already transferred because of the lower value of Rx Threshold, for example, RTC = 01.
    $04 constant ETH_FEP                        \ [0x04] Forward Error Packets When this bit is reset, the Rx queue drops packets with error status (CRC error, receive error, watchdog timeout, or overflow). However, if the start byte (write) pointer of a packet is already transferred to the read controller side (in Threshold mode), the packet is not dropped. When this bit is set, all packets except the runt error packets are forwarded to the application or DMA. If the RSF bit is set and the Rx queue overflows when a partial packet is written, the packet is dropped irrespective of the setting of this bit. However, if the RSF bit is reset and the Rx queue overflows when a partial packet is written, a partial packet may be forwarded to the application or DMA.
    $05 constant ETH_RSF                        \ [0x05] Receive Queue Store and Forward When this bit is set, the Ethernet peripheral reads a packet from the Rx queue only after the complete packet has been written to it, ignoring the RTC field of this register. When this bit is reset, the Rx queue operates in the Threshold (cut-through) mode, subject to the threshold specified by the RTC field of this register.
    $06 constant ETH_DIS_TCP_EF                 \ [0x06] Disable Dropping of TCP/IP Checksum Error Packets When this bit is set, the MAC does not drop the packets which only have the errors detected by the Receive Checksum Offload engine. Such packets have errors only in the encapsulated payload. There are no errors (including FCS error) in the Ethernet packet received by the MAC. When this bit is reset, all error packets are dropped if the FEP bit is reset. This bit is reserved and RO when Enable Receive TCP/IP Checksum Check is not selected.
    $07 constant ETH_EHFC                       \ [0x07] Enable Hardware Flow Control When this bit is set, the flow control signal operation, based on the fill-level of Rx queue, is enabled. When reset, the flow control operation is disabled. This bit is not used (reserved and always reset) when the Rx queue is less than 4 Kbytes.
    $08 constant ETH_RFA                        \ [0x08 : 3] Threshold for Activating Flow Control (in half-duplex and full-duplex These bits control the threshold (fill-level of Rx queue) at which the flow control is activated: For more information on encoding for this field, see RFD.
    $0e constant ETH_RFD                        \ [0x0e : 3] Threshold for Deactivating Flow Control (in half-duplex and full-duplex modes) These bits control the threshold (fill-level of Rx queue) at which the flow control is deasserted after activation: 2: Full minus 2 Kbytes, that is, FULL 2 Kbytes 3: Full minus 2.5 Kbytes, that is, FULL 2.5 Kbytes 4: Full minus 2.5 Kbytes, that is, FULL 3 Kbytes 5: Full minus 2.5 Kbytes, that is, FULL 3.5 Kbytes ... 6: Full minus 4 Kbytes, that is, FULL 4 Kbytes 7: Full minus 4.5 Kbytes, that is, FULL 4.5 Kbytes The deassertion is effective only after flow control is asserted. Note: The value must be programmed in such a way to make sure that the threshold is a positive number. When the EHFC is set high, these values are applicable only when the Rx queue size determined by the RQS field of this register, is equal to or greater than 4 Kbytes. For a given queue size, the values ranges between 0 and the encoding for FULL minus (QSIZE - 0.5 Kbyte) and all other values are illegal. Here the term FULL and QSIZE refers to the queue size determined by the RQS field of this register. The width of this field depends on RX FIFO size selected during the configuration. Remaining bits are reserved and read only. This field is reserved and read only when the RX FIFO size selected during configuration is less than 4Kbytes.
    $14 constant ETH_RQS                        \ [0x14 : 3] Receive Queue Size This field indicates the size of the allocated Receive queues in blocks of 256 bytes. The RQS field is read-write only if the number of Rx queues more than one and the reset value is 0x0.
  [then]


  [ifdef] ETH_ETH_MTLRXQ1MPOCR_DEF
    \
    \ @brief Rx queue 1 missed packet and overflow counter register
    \ Address offset: 0xD74
    \ Reset value: 0x00000000
    \
    $00 constant ETH_OVFPKTCNT                  \ [0x00 : 11] Overflow Packet Counter This field indicates the number of packets discarded by the Ethernet peripheral because of Receive queue overflow. This counter is incremented each time the Ethernet peripheral discards an incoming packet because of overflow. This counter is reset when this register is read.
    $0b constant ETH_OVFCNTOVF                  \ [0x0b] Overflow Counter Overflow Bit When set, this bit indicates that the Rx Queue Overflow Packet Counter field crossed the maximum limit.
    $10 constant ETH_MISPKTCNT                  \ [0x10 : 11] Missed Packet Counter This field indicates the number of packets missed by the Ethernet peripheral because the application asserted ari_pkt_flush_i[] for this queue. This counter is reset when this register is read. This counter is incremented by 1 when the DMA discards the packet because of buffer unavailability.
    $1b constant ETH_MISCNTOVF                  \ [0x1b] Missed Packet Counter Overflow Bit When set, this bit indicates that the Rx Queue Missed Packet Counter crossed the maximum limit.
  [then]


  [ifdef] ETH_ETH_MTLRXQ1DR_DEF
    \
    \ @brief Rx queue 1 debug register
    \ Address offset: 0xD78
    \ Reset value: 0x00000000
    \
    $00 constant ETH_RWCSTS                     \ [0x00] MTL Rx Queue Write Controller Active Status When high, this bit indicates that the MTL Rx queue Write controller is active, and it is transferring a received packet to the Rx queue.
    $01 constant ETH_RRCSTS                     \ [0x01 : 2] MTL Rx Queue Read Controller State This field gives the state of the Rx queue Read controller:
    $04 constant ETH_RXQSTS                     \ [0x04 : 2] MTL Rx Queue Fill-Level Status This field gives the status of the fill-level of the Rx queue:
    $10 constant ETH_PRXQ                       \ [0x10 : 14] Number of Packets in Receive Queue This field indicates the current number of packets in the Rx queue. The theoretical maximum value for this field is 256Kbyte/16bytes = 16K Packets, that is, Max_Queue_Size/Min_Packet_Size.
  [then]


  [ifdef] ETH_ETH_MTLRXQ1CR_DEF
    \
    \ @brief Rx queue 1 control register
    \ Address offset: 0xD7C
    \ Reset value: 0x00000000
    \
    $00 constant ETH_RXQ_WEGT                   \ [0x00 : 3] Receive Queue Weight This field indicates the weight assigned to the Rx queue 0. The weight is used as the number of continuous PBL requests or contiguous packets (depending on the RXQ_PKT_ARBIT) allocated to the queue in one arbitration cycle.
    $03 constant ETH_RXQ_FRM_ARBIT              \ [0x03] Receive Queue Packet Arbitration When this bit is set, the Ethernet peripheral drives the packet data to the ARI interface such that the entire packet data of currently-selected queue is transmitted before switching to other queue. When this bit is reset, the Ethernet peripheral drives the packet data to the ARI interface such that the following amount of data of currently-selected queue is transmitted before switching to other queue: PBL amount of data (indicated by ari_qN_pbl_i[]) or complete data of a packet The status and the timestamp are not a part of the PBL data. Therefore, the Ethernet peripheral drives the complete status (including timestamp status) during first PBL request for the packet (in store-and-forward mode) or the last PBL request for the packet (in Threshold mode).
  [then]


  [ifdef] ETH_ETH_DMAMR_DEF
    \
    \ @brief DMA mode register
    \ Address offset: 0x1000
    \ Reset value: 0x00000000
    \
    $00 constant ETH_SWR                        \ [0x00] Software Reset When this bit is set, the MAC and the DMA controller reset the logic and all internal registers of the DMA, MTL, and MAC. This bit is automatically cleared after the reset operation is complete in all clock domains. Before reprogramming any register, a value of zero should be read in this bit. Note: The reset operation is complete only when all resets in all active clock domains are deasserted. Therefore, it is essential that all PHY inputs clocks (applicable for the selected PHY interface) are present for software reset completion. The time to complete the software reset operation depends on the frequency of the slowest active clock.
    $02 constant ETH_TAA                        \ [0x02 : 3] Transmit Arbitration Algorithm This field is used to select the arbitration algorithm for the Transmit side when multiple Tx DMAs are selected.
    $0b constant ETH_TXPR                       \ [0x0b] Transmit priority When set, this bit indicates that the Tx DMA has higher priority than the Rx DMA during arbitration for the system-side bus.
    $0c constant ETH_PR                         \ [0x0c : 3] Priority ratio These bits control the priority ratio in weighted round-robin arbitration between the Rx DMA and Tx DMA. These bits are valid only when the DA bit is reset. The priority ratio is Rx:Tx or Tx:Rx depending on whether the TXPR bit is reset or set.
    $10 constant ETH_INTM                       \ [0x10 : 2] Interrupt Mode This field defines the interrupt mode of the Ethernet peripheral. The behavior of the interrupt signal and of the RI/TI bits in the ETH_DMACSR register changes depending on the INTM value (refer to behavior).
  [then]


  [ifdef] ETH_ETH_DMASBMR_DEF
    \
    \ @brief System bus mode register
    \ Address offset: 0x1004
    \ Reset value: 0x01010000
    \
    $00 constant ETH_FB                         \ [0x00] Fixed Burst Length When this bit is set to 1, the AXI master will initiate burst transfers of specified lengths as given below. Burst transfers of fixed burst lengths as indicated by the BLEN256, BLEN128, BLEN64, BLEN32, BLEN16, BLEN8, or BLEN4 field Burst transfers of length 1: when this bit is set to 0, the AXI master initiates burst transfers that are equal to or less than the maximum allowed burst length programmed in Bits[7:1].
    $01 constant ETH_BLEN4                      \ [0x01] AXI Burst Length 4 When this bit is set to 1 or the FB bit is set to 0, the AXI master can select a burst length of 4 on the AXI interface. When the FB bit is set to 0, setting this bit has no effect.
    $02 constant ETH_BLEN8                      \ [0x02] AXI Burst Length 8 When this bit is set to 1 or the FB bit is set to 0, the AXI master can select a burst length of 8 on the AXI interface. When the FB bit is set to 0, setting this bit has no effect.
    $03 constant ETH_BLEN16                     \ [0x03] AXI Burst Length 16 When this bit is set to 1 or the FB bit is set to 0, the AXI master can select a burst length of 16 on the AXI interface. When the FB bit is set to 0, setting this bit has no effect.
    $04 constant ETH_BLEN32                     \ [0x04] AXI Burst Length 32 When this bit is set to 1, the AXI master can select a burst length of 32 on the AXI interface.
    $05 constant ETH_BLEN64                     \ [0x05] AXI Burst Length 64 When this bit is set to 1, the AXI master can select a burst length of 64 on the AXI interface.
    $06 constant ETH_BLEN128                    \ [0x06] AXI Burst Length 128 When this bit is set to 1, the AXI master can select a burst length of 128 on the AXI interface.
    $07 constant ETH_BLEN256                    \ [0x07] AXI Burst Length 256 When this bit is set to 1, the AXI master can select a burst length of 256 on the AXI interface.
    $0c constant ETH_AAL                        \ [0x0c] Address-Aligned Beats When this bit is set to 1, the master performs address-aligned burst transfers on Read and Write channels.
    $0d constant ETH_ONEKBBE                    \ [0x0d] 1 Kbyte Boundary Crossing Enable for the AXI Master When set, the burst transfers performed by the AXI master do not cross 1 Kbyte boundary. When reset, the burst transfers performed by the AXI master do not cross 4 Kbyte boundary.
    $10 constant ETH_RD_OSR_LMT                 \ [0x10 : 2] AXI Maximum Read Outstanding Request Limit This value limits the maximum outstanding request on the AXI read interface. Maximum outstanding requests = RD_OSR_LMT + 1
    $18 constant ETH_WR_OSR_LMT                 \ [0x18 : 2] AXI Maximum Write Outstanding Request Limit This value limits the maximum outstanding request on the AXI write interface. Maximum outstanding requests = WR_OSR_LMT + 1 Bit 27 is reserved Bit 26 is reserved
    $1e constant ETH_LPI_XIT_PKT                \ [0x1e] Unlock on Magic Packet or Remote wakeup Packet When set to 1, this bit enables the AXI master to come out of the LPI mode only when the magic packet or remote wakeup packet is received. When set to 0, this bit enables the AXI master to come out of the LPI mode when any packet is received.
    $1f constant ETH_EN_LPI                     \ [0x1f] Enable Low Power Interface (LPI) When set to 1, this bit enables the LPI mode and accepts the LPI request from the AXI System Clock controller. When set to 0, this bit disables the LPI mode and always denies the LPI request from the AXI System Clock controller.
  [then]


  [ifdef] ETH_ETH_DMAISR_DEF
    \
    \ @brief Interrupt status register
    \ Address offset: 0x1008
    \ Reset value: 0x00000000
    \
    $00 constant ETH_DC0IS                      \ [0x00] DMA Channel 0 Interrupt Status This bit indicates an interrupt event in DMA Channel 0. To reset this bit to 0, the software must read the corresponding register in DMA Channel 0 to get the exact cause of the interrupt and clear its source.
    $01 constant ETH_DC1IS                      \ [0x01] DMA Channel 1 Interrupt Status This bit indicates an interrupt event in DMA Channel 1. To reset this bit to 0, the software must read the corresponding register in DMA Channel 1 to get the exact cause of the interrupt and clear its source.
    $10 constant ETH_MTLIS                      \ [0x10] MTL Interrupt Status This bit indicates an interrupt event in the MTL. To reset this bit to 1'b0, the software must read the corresponding register in the MTL to get the exact cause of the interrupt and clear its source.
    $11 constant ETH_MACIS                      \ [0x11] MAC Interrupt Status This bit indicates an interrupt event in the MAC. To reset this bit to 1'b0, the software must read the corresponding register in the MAC to get the exact cause of the interrupt and clear its source.
  [then]


  [ifdef] ETH_ETH_DMADSR_DEF
    \
    \ @brief Debug status register
    \ Address offset: 0x100C
    \ Reset value: 0x00000000
    \
    $00 constant ETH_AXWHSTS                    \ [0x00] AXI Master Write Channel When high, this bit indicates that the write channel of the AXI master is active, and it is transferring data.
    $01 constant ETH_AXRHSTS                    \ [0x01] AXI Master Read Channel Status When high, this bit indicates that the read channel of the AXI master is active, and it is transferring the data.
    $08 constant ETH_RPS0                       \ [0x08 : 4] DMA Channel 0 Receive Process State This field indicates the Rx DMA FSM state for Channel 0: The MSB of this field always returns 0. This field does not generate an interrupt.
    $0c constant ETH_TPS0                       \ [0x0c : 4] DMA Channel 0 Transmit Process State This field indicates the Tx DMA FSM state for Channel 0: The MSB of this field always returns 0. This field does not generate an interrupt.
    $10 constant ETH_RPS1                       \ [0x10 : 4] DMA Channel 1 Receive Process State This field indicates the Rx DMA FSM state for Channel 1. This field is similar to the RPS0 field.
    $14 constant ETH_TPS1                       \ [0x14 : 4] DMA Channel 1 Transmit Process State This field indicates the Tx DMA FSM state for Channel 1. This field is similar to the TPS0 field.
  [then]


  [ifdef] ETH_ETH_DMAA4TXACR_DEF
    \
    \ @brief AXI4 transmit channel ACE control register
    \ Address offset: 0x1020
    \ Reset value: 0x00000000
    \
    $00 constant ETH_TDRC                       \ [0x00 : 4] Transmit DMA Read Descriptor Cache Control This field is used to drive arcache_o[3:0] signal when Transmit DMA engines access the Descriptor.
    $08 constant ETH_TEC                        \ [0x08 : 4] Transmit DMA Extended Packet Buffer or TSO Payload Cache Control When TSO is NOT enabled, This field is used to drive arcache o[3:0] signal when Transmit DMA is accessing the extended buffers (when packet is distributed across multiple buffers). When TSO is enabled, This field is used to drive arcache_o[3:0] signal when the Transmit DMA is accessing the TSO payload data.
    $10 constant ETH_THC                        \ [0x10 : 4] Transmit DMA First Packet Buffer or TSO Header Cache Control When TSO is NOT enabled, This field is used to drive arcache_o[3:0] signal when Transmit DMA is accessing First Buffer of the Packet (First valid buffer with FD being set in the TDES3 of the Descriptor). When TSO is enabled, This field is used to drive arcache_o[3:0] signal when the Transmit DMA is accessing the TSO Header data.
  [then]


  [ifdef] ETH_ETH_DMAA4RXACR_DEF
    \
    \ @brief AXI4 receive channel ACE control register
    \ Address offset: 0x1024
    \ Reset value: 0x00000000
    \
    $00 constant ETH_RDWC                       \ [0x00 : 4] Receive DMA Write Descriptor Cache Control This field is used to drive awcache_o[3:0] signal when Receive DMA accesses the Descriptor.
    $08 constant ETH_RPC                        \ [0x08 : 4] Receive DMA Payload Cache Control This field is used to drive awcache_o[3:0] signal when Receive DMA is accessing the Payload Buffer when Header and payload are separated.
    $10 constant ETH_RHC                        \ [0x10 : 4] Receive DMA Header Cache Control This field is used to drive awcache_o[3:0] and signal when Receive DMA is accessing the header Buffer when Header and payload are separated.
    $18 constant ETH_RDC                        \ [0x18 : 4] Receive DMA Buffer Cache Control This field is used to drive awcache_o[3:0] signal when Receive DMA is accessing the Buffer when Header and payload are NOT separated.
  [then]


  [ifdef] ETH_ETH_DMAA4DACR_DEF
    \
    \ @brief AXI4 descriptor ACE control register
    \ Address offset: 0x1028
    \ Reset value: 0x00000000
    \
    $00 constant ETH_TDWC                       \ [0x00 : 4] Transmit DMA Write Descriptor Cache control This field is used to drive awcache_o[3:0] signal when Transmit DMA writes to the Descriptor.
    $04 constant ETH_TDWD                       \ [0x04 : 2] Transmit DMA Write Descriptor Domain control This field is used to drive awdomain_o[1:0] signal when Transmit DMA write to the Descriptor.
    $08 constant ETH_RDRC                       \ [0x08 : 4] Receive DMA Read Descriptor Cache control This field is used to drive arcache_o[3:0] signal when Receive DMA engines read the Descriptor.
  [then]


  [ifdef] ETH_ETH_DMAC0CR_DEF
    \
    \ @brief Channel 0 control register
    \ Address offset: 0x1100
    \ Reset value: 0x00000000
    \
    $00 constant ETH_MSS                        \ [0x00 : 14] Maximum Segment Size This field specifies the maximum segment size that should be used while segmenting the packet. This field is valid only if the TSE bit of ETH_DMACiTXCR register is set. The value programmed in this field must be more than the configured Data width in bytes. It is recommended to use a MSS value of 64 bytes or more.
    $10 constant ETH_PBLX8                      \ [0x10] 8xPBL mode When this bit is set, the PBL value programmed in Bits[21:16] in ETH_DMACiTXCR is multiplied eight times. Therefore, the DMA transfers the data in 8, 16, 32, 64, 128, and 256 beats depending on the PBL value.
    $12 constant ETH_DSL                        \ [0x12 : 3] Descriptor Skip Length This bit specifies the 32-bit word number to skip between two unchained descriptors. The address skipping starts from the end of the current descriptor to the start of the next descriptor. When the DSL value is equal to zero, the DMA takes the descriptor table as contiguous.
  [then]


  [ifdef] ETH_ETH_DMAC0TXCR_DEF
    \
    \ @brief Channel 0 transmit control register
    \ Address offset: 0x1104
    \ Reset value: 0x00000000
    \
    $00 constant ETH_ST                         \ [0x00] Start or Stop Transmission Command When this bit is set, transmission is placed in the Running state. The DMA checks the Transmit list at the current position for a packet to be transmitted. The DMA tries to acquire descriptor from either of the following positions: The current position in the list: this is the base address of the Transmit list set by the ETH_DMACiTXDLAR register. The position at which the transmission was previously stopped If the DMA does not own the current descriptor, the transmission enters the Suspended state and the TBU bit of the ETH_DMACiSR is set. The Start Transmission command is effective only when the transmission is stopped. If the command is issued before setting the ETH_DMACiTXDLAR register, the DMA behavior is unpredictable. When this bit is reset, the transmission process is placed in the Stopped state after completing the transmission of the current packet. The Next Descriptor position in the Transmit list is saved, and it becomes the current position when the transmission is restarted. To change the list address, you need to program ETH_DMACiTXDLAR register with a new value when this bit is reset. The new value is considered when this bit is set again. The stop transmission command is effective only when the transmission of the current packet is complete or the transmission is in the Suspended state.
    $01 constant ETH_TCW                        \ [0x01 : 3] Transmit Channel Weight This field indicates the weight assigned to the corresponding Transmit channel. When reset is complete, this field is set to 0 for all channels by default, resulting in equal weights to all channels.
    $04 constant ETH_OSF                        \ [0x04] Operate on Second Packet When this bit is set, it instructs the DMA to process the second packet of the Transmit data even before the status for the first packet is obtained.
    $0c constant ETH_TSE                        \ [0x0c] TCP Segmentation Enabled When this bit is set, the DMA performs the TCP segmentation for packets in Channel i. The TCP segmentation is done only for those packets for which the TSE bit (TDES0[19]) is set in the Tx Normal descriptor. When this bit is set, the TxPBL value must be greater than or equal to 4.
    $10 constant ETH_TXPBL                      \ [0x10 : 6] Transmit Programmable Burst Length These bits indicate the maximum number of beats to be transferred in one DMA data transfer. This is the maximum value that is used in a single block Read or Write. The DMA always attempts to burst as specified in PBL each time it starts a burst transfer on the application bus. You can program PBL with any of the following values: 1, 2, 4, 8, 16, or 32. Any other value results in undefined behavior. To transfer more than 32 beats, perform the following steps: 1. Set the PBLx8 mode in ETH_DMACiCR. 2. Set the PBL.
    $18 constant ETH_TQOS                       \ [0x18 : 4] Transmit QOS. This field is used to drive arqos_m_o[3:0] or awqos_m_o[3:0] output signals for all transactions of DMA Tx Channel i.
  [then]


  [ifdef] ETH_ETH_DMAC0RXCR_DEF
    \
    \ @brief Channel 0 receive control register
    \ Address offset: 0x1108
    \ Reset value: 0x00000000
    \
    $00 constant ETH_SR                         \ [0x00] Start or Stop Receive When this bit is set, the DMA tries to acquire the descriptor from the Receive list and processes the incoming packets. The DMA tries to acquire descriptor from either of the following positions: The current position in the list: this is the address set by the ETH_DMAC0RXDLAR register. The position at which the Rx process was previously stopped If the DMA does not own the current descriptor, the reception is suspended and the RBU bit of the ETH_DMAC0SR is set. The Start Receive command is effective only when the reception is stopped. If the command is issued before setting the ETH_DMAC0RXDLAR register, the DMA behavior is unpredictable. When this bit is reset, the Rx DMA operation is stopped after the transfer of the current packet. The next descriptor position in the Receive list is saved, and it becomes the current position after the Rx process is restarted. The Stop Receive command is effective only when the Rx process is in the Running (waiting for Rx packet) or Suspended state.
    $01 constant ETH_RBSZ                       \ [0x01 : 14] Receive Buffer size This field indicates the size of the Rx buffers specified in bytes. The maximum buffer size is limited to 16 Kbytes. The buffer size is applicable to payload buffers when split headers are enabled. Note: The buffer size must be a multiple of 4, 8, or 16 depending on the bus widths (32, 64, or 128 respectively). This is required even if the value of buffer address pointer is not aligned to bus width. If the buffer size is not a multiple of 4, 8, or 16, it may result into undefined behavior. The LSB bits (1:0, 2:0, or 3:0) for 32-bit, 64-bit, or 128-bit bus width are ignored and the DMA internally takes the LSB bits as all-zero. Therefore, these LSB bits are read-only (RO).
    $10 constant ETH_RXPBL                      \ [0x10 : 6] Receive Programmable Burst Length These bits indicate the maximum number of beats to be transferred in one DMA data transfer. This is the maximum value that is used in a single block Read or Write. The DMA always attempts to burst as specified in PBL each time it starts a burst transfer on the application bus. You can program PBL with any of the following values: 1, 2, 4, 8, 16, or 32. Any other value results in undefined behavior. To transfer more than 32 beats, perform the following steps: 1. Set the PBLx8 mode in the ETH_DMAC0CR. 2. Set the PBL.
    $18 constant ETH_RQOS                       \ [0x18 : 4] Rx AXI4 QOS. This field is used to drive arqos_m_o[3:0] or awqos_m_o[3:0] output signals for all transactions of DMA Rx Channel0.
    $1f constant ETH_RPF                        \ [0x1f] DMA Rx Channel0 Packet Flush When this bit is set to 1, the DMA will automatically flush the packet from the Rx queues destined to DMA Rx Channel 0 when the DMA Rx Channel 0 is stopped after a system bus error has occurred. The flushing happens on the Read side of the Rx queue. When this bit is set to 0 the EQOS will not flush the packet in the Rx queue destined to DMA Rx Channel 0 after the DMA is stopped due to a system bus error.
  [then]


  [ifdef] ETH_ETH_DMAC0TXDLAR_DEF
    \
    \ @brief Channel 0 Tx descriptor list address register
    \ Address offset: 0x1114
    \ Reset value: 0x00000000
    \
    $02 constant ETH_TDESLA                     \ [0x02 : 30] Start of Transmit List This field contains the base address of the first descriptor in the Transmit descriptor list. The DMA ignores the LSB bits (1:0, 2:0, or 3:0) for 32-bit bus width and internally takes these bits as all-zero. Therefore, these LSB bits are read-only (RO). The width of this field depends on the configuration: 31:2 for 32-bit configuration
  [then]


  [ifdef] ETH_ETH_DMAC0RXDLAR_DEF
    \
    \ @brief Channel 0 Rx descriptor list address register
    \ Address offset: 0x111C
    \ Reset value: 0x00000000
    \
    $02 constant ETH_RDESLA                     \ [0x02 : 30] Start of Receive List This field contains the base address of the first descriptor in the Rx Descriptor list. The DMA ignores the LSB bits (1:0, 2:0, or 3:0) for 32-bit bus width and internally takes these bits as all-zero. Therefore, these LSB bits are read-only (RO). The width of this field depends on the configuration: 31:2 for 32-bit configuration
  [then]


  [ifdef] ETH_ETH_DMAC0TXDTPR_DEF
    \
    \ @brief Channel 0 Tx descriptor tail pointer register
    \ Address offset: 0x1120
    \ Reset value: 0x00000000
    \
    $02 constant ETH_TDT                        \ [0x02 : 30] Transmit Descriptor Tail Pointer This field contains the tail pointer for the Tx descriptor ring. The software writes the tail pointer to add more descriptors to the Tx channel. The hardware tries to transmit all packets referenced by the descriptors between the head and the tail pointer registers. The width of this field depends on the configuration: 31:2 for 32-bit configuration
  [then]


  [ifdef] ETH_ETH_DMAC0RXDTPR_DEF
    \
    \ @brief Channel 0 Rx descriptor tail pointer register
    \ Address offset: 0x1128
    \ Reset value: 0x00000000
    \
    $02 constant ETH_RDT                        \ [0x02 : 30] Receive Descriptor Tail Pointer This field contains the tail pointer for the Rx descriptor ring. The software writes the tail pointer to add more descriptors to the Rx channel. The hardware tries to write all received packets to the descriptors referenced between the head and the tail pointer registers. The width of this field depends on the configuration: 31:2 for 32-bit configuration
  [then]


  [ifdef] ETH_ETH_DMAC0TXRLR_DEF
    \
    \ @brief Channel 0 Tx descriptor ring length register
    \ Address offset: 0x112C
    \ Reset value: 0x00000000
    \
    $00 constant ETH_TDRL                       \ [0x00 : 10] Transmit Descriptor Ring Length This field sets the maximum number of Tx descriptors in the circular descriptor ring. The maximum number of descriptors is limited to 1K descriptors. It is recommended to put a minimum ring descriptor length of 4.
  [then]


  [ifdef] ETH_ETH_DMAC0RXRLR_DEF
    \
    \ @brief Channel 0 Rx descriptor ring length register
    \ Address offset: 0x1130
    \ Reset value: 0x00000000
    \
    $00 constant ETH_RDRL                       \ [0x00 : 10] Receive Descriptor Ring Length This register sets the maximum number of Rx descriptors in the circular descriptor ring. The maximum number of descriptors is limited to 1K descriptors.
  [then]


  [ifdef] ETH_ETH_DMAC0IER_DEF
    \
    \ @brief Channel 0 interrupt enable register
    \ Address offset: 0x1134
    \ Reset value: 0x00000000
    \
    $00 constant ETH_TIE                        \ [0x00] Transmit Interrupt Enable When this bit is set along with the NIE bit, the Transmit Interrupt is enabled. When this bit is reset, the Transmit Interrupt is disabled.
    $01 constant ETH_TXSE                       \ [0x01] Transmit Stopped Enable When this bit is set along with the AIE bit, the Transmission Stopped interrupt is enabled. When this bit is reset, the Transmission Stopped interrupt is disabled.
    $02 constant ETH_TBUE                       \ [0x02] Transmit Buffer Unavailable Enable When this bit is set along with the NIE bit, the Transmit Buffer Unavailable interrupt is enabled. When this bit is reset, the Transmit Buffer Unavailable interrupt is disabled.
    $06 constant ETH_RIE                        \ [0x06] Receive Interrupt Enable When this bit is set along with the NIE bit, the Receive Interrupt is enabled. When this bit is reset, the Receive Interrupt is disabled.
    $07 constant ETH_RBUE                       \ [0x07] Receive Buffer Unavailable Enable When this bit is set along with the AIE bit, the Receive Buffer Unavailable interrupt is enabled. When this bit is reset, the Receive Buffer Unavailable interrupt is disabled.
    $08 constant ETH_RSE                        \ [0x08] Receive Stopped Enable When this bit is set along with the AIE bit, the Receive Stopped Interrupt is enabled. When this bit is reset, the Receive Stopped interrupt is disabled.
    $09 constant ETH_RWTE                       \ [0x09] Receive Watchdog Timeout Enable When this bit is set along with the AIE bit, the Receive Watchdog Timeout interrupt is enabled. When this bit is reset, the Receive Watchdog Timeout interrupt is disabled.
    $0a constant ETH_ETIE                       \ [0x0a] Early Transmit Interrupt Enable When this bit is set along with the AIE bit, the Early Transmit interrupt is enabled. When this bit is reset, the Early Transmit interrupt is disabled.
    $0b constant ETH_ERIE                       \ [0x0b] Early Receive Interrupt Enable When this bit is set along with the NIE bit, the Early Receive interrupt is enabled. When this bit is reset, the Early Receive interrupt is disabled.
    $0c constant ETH_FBEE                       \ [0x0c] Fatal Bus Error Enable When this bit is set along with the AIE bit, the Fatal Bus error interrupt is enabled. When this bit is reset, the Fatal Bus Error error interrupt is disabled.
    $0d constant ETH_CDEE                       \ [0x0d] Context Descriptor Error Enable When this bit is set along with the AIE bit, the Context Descriptor error interrupt is enabled. When this bit is reset, the Context Descriptor error interrupt is disabled.
    $0e constant ETH_AIE                        \ [0x0e] Abnormal Interrupt Summary Enable When this bit is set, the abnormal interrupt summary is enabled. This bit enables the following interrupts in the ETH_DMAC0SR: Bit 1: Transmit Process Stopped Bit 7: Rx Buffer Unavailable Bit 8: Receive Process Stopped Bit 9: Receive Watchdog Timeout Bit 10: Early Transmit Interrupt Bit 12: Fatal Bus Error When this bit is reset, the abnormal interrupt summary is disabled.
    $0f constant ETH_NIE                        \ [0x0f] Normal Interrupt Summary Enable When this bit is set, the normal interrupt summary is enabled. This bit enables the following interrupts in the ETH_DMAC0SR: Bit 0: Transmit Interrupt Bit 2: Transmit Buffer Unavailable Bit 6: Receive Interrupt Bit 11: Early Receive Interrupt When this bit is reset, the normal interrupt summary is disabled.
  [then]


  [ifdef] ETH_ETH_DMAC0RXIWTR_DEF
    \
    \ @brief Channel 0 Rx interrupt watchdog timer register
    \ Address offset: 0x1138
    \ Reset value: 0x00000000
    \
    $00 constant ETH_RWT                        \ [0x00 : 8] Receive Interrupt Watchdog Timer Count This field indicates the number of system clock cycles, multiplied by factor indicated in RWTU field, for which the watchdog timer is set. The watchdog timer is triggered with the programmed value after the Rx DMA completes the transfer of a packet for which the RI bit is not set in the ETH_DMAC0SR, because of the setting of Interrupt Enable bit in the corresponding descriptor RDES3[30]. When the watchdog timer runs out, the RI bit is set and the timer is stopped. The watchdog timer is reset when the RI bit is set high because of automatic setting of RI as per the Interrupt Enable bit RDES3[30] of any received packet.
    $10 constant ETH_RWTU                       \ [0x10 : 2] Receive Interrupt Watchdog Timer Count Units This field indicates the number of system clock cycles corresponding to one unit in RWT[7:0] field. For example, when RWT[7:0] = 2 and RWTU[1:0] = 1, the watchdog timer is set for 2 * 512 = 1024 system clock cycles.
  [then]


  [ifdef] ETH_ETH_DMAC0CATXDR_DEF
    \
    \ @brief Channel 0 current application transmit descriptor register
    \ Address offset: 0x1144
    \ Reset value: 0x00000000
    \
    $00 constant ETH_CURTDESAPTR                \ [0x00 : 32] Application Transmit Descriptor Address Pointer The DMA updates this pointer during Tx operation. This pointer is cleared on reset.
  [then]


  [ifdef] ETH_ETH_DMAC0CARXDR_DEF
    \
    \ @brief Channel 0 current application receive descriptor register
    \ Address offset: 0x114C
    \ Reset value: 0x00000000
    \
    $00 constant ETH_CURRDESAPTR                \ [0x00 : 32] Application Receive Descriptor Address Pointer The DMA updates this pointer during Rx operation. This pointer is cleared on reset.
  [then]


  [ifdef] ETH_ETH_DMAC0CATXBR_DEF
    \
    \ @brief Channel 0 current application transmit buffer register
    \ Address offset: 0x1154
    \ Reset value: 0x00000000
    \
    $00 constant ETH_CURTBUFAPTR                \ [0x00 : 32] Application Transmit Buffer Address Pointer The DMA updates this pointer during Tx operation. This pointer is cleared on reset.
  [then]


  [ifdef] ETH_ETH_DMAC0CARXBR_DEF
    \
    \ @brief Channel 0 current application receive buffer register
    \ Address offset: 0x115C
    \ Reset value: 0x00000000
    \
    $00 constant ETH_CURRBUFAPTR                \ [0x00 : 32] Application Receive Buffer Address Pointer The DMA updates this pointer during Rx operation. This pointer is cleared on reset.
  [then]


  [ifdef] ETH_ETH_DMAC0SR_DEF
    \
    \ @brief Channel 0 status register
    \ Address offset: 0x1160
    \ Reset value: 0x00000000
    \
    $00 constant ETH_TI                         \ [0x00] Transmit Interrupt This bit indicates that the packet transmission is complete. When transmission is complete, Bit 31 of TDES3 is reset in the last descriptor, and the specific packet status information is updated in the descriptor.
    $01 constant ETH_TPS                        \ [0x01] Transmit Process Stopped This bit is set when the transmission is stopped.
    $02 constant ETH_TBU                        \ [0x02] Transmit Buffer Unavailable This bit indicates that the application owns the next descriptor in the Transmit list, and the DMA cannot acquire it. Transmission is suspended. The TPS0 field of the DMA_Debug_Status0 register explains the Transmit Process state transitions. To resume processing the Transmit descriptors, the application should do the following: 1. Change the ownership of the descriptor by setting Bit 31 of TDES3. 2. Issue a Transmit Poll Demand command. For ring mode, the application should advance the Transmit Descriptor Tail Pointer register of a channel.
    $06 constant ETH_RI                         \ [0x06] Receive Interrupt This bit indicates that the packet reception is complete. When packet reception is complete, Bit 31 of RDES1 is reset in the last descriptor, and the specific packet status information is updated in the descriptor. The reception remains in the Running state.
    $07 constant ETH_RBU                        \ [0x07] Receive Buffer Unavailable This bit indicates that the application owns the next descriptor in the Receive list, and the DMA cannot acquire it. The Rx process is suspended. To resume processing Rx descriptors, the application should change the ownership of the descriptor and issue a Receive Poll Demand command. If this command is not issued, the Rx process resumes when the next recognized incoming packet is received. In ring mode, the application should advance the Receive Descriptor Tail Pointer register of a channel. This bit is set only when the DMA owns the previous Rx descriptor.
    $08 constant ETH_RPS                        \ [0x08] Receive Process Stopped This bit is asserted when the Rx process enters the Stopped state.
    $09 constant ETH_RWT                        \ [0x09] Receive Watchdog Timeout This bit is asserted when a packet with length greater than 2,048 bytes (10,240 bytes when Jumbo Packet mode is enabled) is received.
    $0a constant ETH_ETI                        \ [0x0a] Early Transmit Interrupt This bit indicates that the packet to be transmitted is fully transferred to the MTL Tx FIFO.
    $0b constant ETH_ERI                        \ [0x0b] Early Receive Interrupt This bit indicates that the DMA filled the first data buffer of the packet. The RI bit of this register automatically clears this bit.
    $0c constant ETH_FBE                        \ [0x0c] Fatal Bus Error This bit indicates that a bus error occurred (as described in the EB field). When this bit is set, the corresponding DMA channel engine disables all bus accesses.
    $0d constant ETH_CDE                        \ [0x0d] Context Descriptor Error This bit indicates that the DMA Tx engine received a context descriptor in the middle of a packet (in an intermediate descriptor), and the DMA Tx engine ignored it.
    $0e constant ETH_AIS                        \ [0x0e] Abnormal Interrupt Summary Abnormal Interrupt Summary bit value is the logical OR of the following when the corresponding interrupt bits are enabled in the ETH_DMACiIER register: Bit 1: Transmit Process Stopped Bit 7: Receive Buffer Unavailable Bit 8: Receive Process Stopped Bit 10: Early Transmit Interrupt Bit 12: Fatal Bus Error Bit 13: Context Descriptor Error Only unmasked bits affect the Abnormal Interrupt Summary bit. This is a sticky bit. You must clear this bit (by writing 1 to this bit) each time a corresponding bit, which causes AIS to be set, is cleared.
    $0f constant ETH_NIS                        \ [0x0f] Normal Interrupt Summary Normal Interrupt Summary bit value is the logical OR of the following bits when the corresponding interrupt bits are enabled in the ETH_DMACiIER register: Bit 0: Transmit Interrupt Bit 2: Transmit Buffer Unavailable Bit 6: Receive Interrupt Bit 11: Early Receive Interrupt Only unmasked bits (interrupts for which interrupt enable is set in ETH_DMACiIER register) affect the Normal Interrupt Summary bit. This is a sticky bit. You must clear this bit (by writing 1 to this bit) each time a corresponding bit which causes NIS to be set is cleared.
    $10 constant ETH_TEB                        \ [0x10 : 3] Tx DMA Error Bits This field indicates the type of error that caused a Bus Error. For example, error response on the AXI interface. Bit[2]: Error during data transfer by Tx DMA when '1', no when '0' Bit[1]: Error during descriptor access when '1', Error during data buffer access when '0' Bit[0]: Error during read transfer when '1', Error during write transfer when '0' This field is valid only when the FBE bit is set. This field does not generate an interrupt.
    $13 constant ETH_REB                        \ [0x13 : 3] Rx DMA Error Bits This field indicates the type of error that caused a Bus Error. For example, error response on the AXI interface. Bit [2]: Error during data transfer by Rx DMA when '1', no when '0' Bit[1]: Error during descriptor access when '1', Error during data buffer access when '0' Bit[0]: Error during read transfer when '1', Error during write transfer when '0' This field is valid only when the FBE bit is set. This field does not generate an interrupt.
  [then]


  [ifdef] ETH_ETH_DMAC0MFCR_DEF
    \
    \ @brief Channel 0 missed frame count register
    \ Address offset: 0x116C
    \ Reset value: 0x00000000
    \
    $00 constant ETH_MFC                        \ [0x00 : 11] Dropped Packet Counters This counter indicates the number of packet counters that are dropped by the DMA either because of bus error or because of programing RPF field in ETH_DMAC0RXCR register. The counter gets cleared when this register is read.
    $0f constant ETH_MFCO                       \ [0x0f] Overflow status of the MFC Counter When this bit is set then the MFC counter does not get incremented further. The bit gets cleared when this register is read.
  [then]


  [ifdef] ETH_ETH_DMAC1CR_DEF
    \
    \ @brief Channel 1 control register
    \ Address offset: 0x1180
    \ Reset value: 0x00000000
    \
    $00 constant ETH_MSS                        \ [0x00 : 14] Maximum Segment Size This field specifies the maximum segment size that should be used while segmenting the packet. This field is valid only if the TSE bit of ETH_DMACiTXCR register is set. The value programmed in this field must be more than the configured Data width in bytes. It is recommended to use a MSS value of 64 bytes or more.
    $10 constant ETH_PBLX8                      \ [0x10] 8xPBL mode When this bit is set, the PBL value programmed in Bits[21:16] in ETH_DMACiTXCR is multiplied eight times. Therefore, the DMA transfers the data in 8, 16, 32, 64, 128, and 256 beats depending on the PBL value.
    $12 constant ETH_DSL                        \ [0x12 : 3] Descriptor Skip Length This bit specifies the 32-bit word number to skip between two unchained descriptors. The address skipping starts from the end of the current descriptor to the start of the next descriptor. When the DSL value is equal to zero, the DMA takes the descriptor table as contiguous.
  [then]


  [ifdef] ETH_ETH_DMAC1TXCR_DEF
    \
    \ @brief Channel 1 transmit control register
    \ Address offset: 0x1184
    \ Reset value: 0x00000000
    \
    $00 constant ETH_ST                         \ [0x00] Start or Stop Transmission Command When this bit is set, transmission is placed in the Running state. The DMA checks the Transmit list at the current position for a packet to be transmitted. The DMA tries to acquire descriptor from either of the following positions: The current position in the list: this is the base address of the Transmit list set by the ETH_DMACiTXDLAR register. The position at which the transmission was previously stopped If the DMA does not own the current descriptor, the transmission enters the Suspended state and the TBU bit of the ETH_DMACiSR is set. The Start Transmission command is effective only when the transmission is stopped. If the command is issued before setting the ETH_DMACiTXDLAR register, the DMA behavior is unpredictable. When this bit is reset, the transmission process is placed in the Stopped state after completing the transmission of the current packet. The Next Descriptor position in the Transmit list is saved, and it becomes the current position when the transmission is restarted. To change the list address, you need to program ETH_DMACiTXDLAR register with a new value when this bit is reset. The new value is considered when this bit is set again. The stop transmission command is effective only when the transmission of the current packet is complete or the transmission is in the Suspended state.
    $01 constant ETH_TCW                        \ [0x01 : 3] Transmit Channel Weight This field indicates the weight assigned to the corresponding Transmit channel. When reset is complete, this field is set to 0 for all channels by default, resulting in equal weights to all channels.
    $04 constant ETH_OSF                        \ [0x04] Operate on Second Packet When this bit is set, it instructs the DMA to process the second packet of the Transmit data even before the status for the first packet is obtained.
    $0c constant ETH_TSE                        \ [0x0c] TCP Segmentation Enabled When this bit is set, the DMA performs the TCP segmentation for packets in Channel i. The TCP segmentation is done only for those packets for which the TSE bit (TDES0[19]) is set in the Tx Normal descriptor. When this bit is set, the TxPBL value must be greater than or equal to 4.
    $10 constant ETH_TXPBL                      \ [0x10 : 6] Transmit Programmable Burst Length These bits indicate the maximum number of beats to be transferred in one DMA data transfer. This is the maximum value that is used in a single block Read or Write. The DMA always attempts to burst as specified in PBL each time it starts a burst transfer on the application bus. You can program PBL with any of the following values: 1, 2, 4, 8, 16, or 32. Any other value results in undefined behavior. To transfer more than 32 beats, perform the following steps: 1. Set the PBLx8 mode in ETH_DMACiCR. 2. Set the PBL.
    $18 constant ETH_TQOS                       \ [0x18 : 4] Transmit QOS. This field is used to drive arqos_m_o[3:0] or awqos_m_o[3:0] output signals for all transactions of DMA Tx Channel i.
  [then]


  [ifdef] ETH_ETH_DMAC1TXDLAR_DEF
    \
    \ @brief Channel 1 Tx descriptor list address register
    \ Address offset: 0x1194
    \ Reset value: 0x00000000
    \
    $02 constant ETH_TDESLA                     \ [0x02 : 30] Start of Transmit List This field contains the base address of the first descriptor in the Transmit descriptor list. The DMA ignores the LSB bits (1:0, 2:0, or 3:0) for 32-bit bus width and internally takes these bits as all-zero. Therefore, these LSB bits are read-only (RO). The width of this field depends on the configuration: 31:2 for 32-bit configuration
  [then]


  [ifdef] ETH_ETH_DMAC1TXDTPR_DEF
    \
    \ @brief Channel 1 Tx descriptor tail pointer register
    \ Address offset: 0x11A0
    \ Reset value: 0x00000000
    \
    $02 constant ETH_TDT                        \ [0x02 : 30] Transmit Descriptor Tail Pointer This field contains the tail pointer for the Tx descriptor ring. The software writes the tail pointer to add more descriptors to the Tx channel. The hardware tries to transmit all packets referenced by the descriptors between the head and the tail pointer registers. The width of this field depends on the configuration: 31:2 for 32-bit configuration
  [then]


  [ifdef] ETH_ETH_DMAC1TXRLR_DEF
    \
    \ @brief Channel 1 Tx descriptor ring length register
    \ Address offset: 0x11AC
    \ Reset value: 0x00000000
    \
    $00 constant ETH_TDRL                       \ [0x00 : 10] Transmit Descriptor Ring Length This field sets the maximum number of Tx descriptors in the circular descriptor ring. The maximum number of descriptors is limited to 1K descriptors. It is recommended to put a minimum ring descriptor length of 4.
  [then]


  [ifdef] ETH_ETH_DMAC1IER_DEF
    \
    \ @brief Channel 1 interrupt enable register
    \ Address offset: 0x11B4
    \ Reset value: 0x00000000
    \
    $00 constant ETH_TIE                        \ [0x00] Transmit Interrupt Enable When this bit is set along with the NIE bit, the Transmit Interrupt is enabled. When this bit is reset, the Transmit Interrupt is disabled.
    $01 constant ETH_TXSE                       \ [0x01] Transmit Stopped Enable When this bit is set along with the AIE bit, the Transmission Stopped interrupt is enabled. When this bit is reset, the Transmission Stopped interrupt is disabled.
    $02 constant ETH_TBUE                       \ [0x02] Transmit Buffer Unavailable Enable When this bit is set along with the NIE bit, the Transmit Buffer Unavailable interrupt is enabled. When this bit is reset, the Transmit Buffer Unavailable interrupt is disabled.
    $06 constant ETH_RIE                        \ [0x06] Receive Interrupt Enable When this bit is set along with the NIE bit, the Receive Interrupt is enabled. When this bit is reset, the Receive Interrupt is disabled.
    $07 constant ETH_RBUE                       \ [0x07] Receive Buffer Unavailable Enable When this bit is set along with the AIE bit, the Receive Buffer Unavailable interrupt is enabled. When this bit is reset, the Receive Buffer Unavailable interrupt is disabled.
    $08 constant ETH_RSE                        \ [0x08] Receive Stopped Enable When this bit is set along with the AIE bit, the Receive Stopped Interrupt is enabled. When this bit is reset, the Receive Stopped interrupt is disabled.
    $09 constant ETH_RWTE                       \ [0x09] Receive Watchdog Timeout Enable When this bit is set along with the AIE bit, the Receive Watchdog Timeout interrupt is enabled. When this bit is reset, the Receive Watchdog Timeout interrupt is disabled.
    $0a constant ETH_ETIE                       \ [0x0a] Early Transmit Interrupt Enable When this bit is set along with the AIE bit, the Early Transmit interrupt is enabled. When this bit is reset, the Early Transmit interrupt is disabled.
    $0b constant ETH_ERIE                       \ [0x0b] Early Receive Interrupt Enable When this bit is set along with the NIE bit, the Early Receive interrupt is enabled. When this bit is reset, the Early Receive interrupt is disabled.
    $0c constant ETH_FBEE                       \ [0x0c] Fatal Bus Error Enable When this bit is set along with the AIE bit, the Fatal Bus error interrupt is enabled. When this bit is reset, the Fatal Bus Error error interrupt is disabled.
    $0d constant ETH_CDEE                       \ [0x0d] Context Descriptor Error Enable When this bit is set along with the AIE bit, the Context Descriptor error interrupt is enabled. When this bit is reset, the Context Descriptor error interrupt is disabled.
    $0e constant ETH_AIE                        \ [0x0e] Abnormal Interrupt Summary Enable When this bit is set, the abnormal interrupt summary is enabled. This bit enables the following interrupts in the ETH_DMAC0SR: Bit 1: Transmit Process Stopped Bit 7: Rx Buffer Unavailable Bit 8: Receive Process Stopped Bit 9: Receive Watchdog Timeout Bit 10: Early Transmit Interrupt Bit 12: Fatal Bus Error When this bit is reset, the abnormal interrupt summary is disabled.
    $0f constant ETH_NIE                        \ [0x0f] Normal Interrupt Summary Enable When this bit is set, the normal interrupt summary is enabled. This bit enables the following interrupts in the ETH_DMAC0SR: Bit 0: Transmit Interrupt Bit 2: Transmit Buffer Unavailable Bit 6: Receive Interrupt Bit 11: Early Receive Interrupt When this bit is reset, the normal interrupt summary is disabled.
  [then]


  [ifdef] ETH_ETH_DMAC1CATXDR_DEF
    \
    \ @brief Channel 1 current application transmit descriptor register
    \ Address offset: 0x11C4
    \ Reset value: 0x00000000
    \
    $00 constant ETH_CURTDESAPTR                \ [0x00 : 32] Application Transmit Descriptor Address Pointer The DMA updates this pointer during Tx operation. This pointer is cleared on reset.
  [then]


  [ifdef] ETH_ETH_DMAC1CATXBR_DEF
    \
    \ @brief Channel 1 current application transmit buffer register
    \ Address offset: 0x11D4
    \ Reset value: 0x00000000
    \
    $00 constant ETH_CURTBUFAPTR                \ [0x00 : 32] Application Transmit Buffer Address Pointer The DMA updates this pointer during Tx operation. This pointer is cleared on reset.
  [then]


  [ifdef] ETH_ETH_DMAC1SR_DEF
    \
    \ @brief Channel 1 status register
    \ Address offset: 0x11E0
    \ Reset value: 0x00000000
    \
    $00 constant ETH_TI                         \ [0x00] Transmit Interrupt This bit indicates that the packet transmission is complete. When transmission is complete, Bit 31 of TDES3 is reset in the last descriptor, and the specific packet status information is updated in the descriptor.
    $01 constant ETH_TPS                        \ [0x01] Transmit Process Stopped This bit is set when the transmission is stopped.
    $02 constant ETH_TBU                        \ [0x02] Transmit Buffer Unavailable This bit indicates that the application owns the next descriptor in the Transmit list, and the DMA cannot acquire it. Transmission is suspended. The TPS0 field of the DMA_Debug_Status0 register explains the Transmit Process state transitions. To resume processing the Transmit descriptors, the application should do the following: 1. Change the ownership of the descriptor by setting Bit 31 of TDES3. 2. Issue a Transmit Poll Demand command. For ring mode, the application should advance the Transmit Descriptor Tail Pointer register of a channel.
    $06 constant ETH_RI                         \ [0x06] Receive Interrupt This bit indicates that the packet reception is complete. When packet reception is complete, Bit 31 of RDES1 is reset in the last descriptor, and the specific packet status information is updated in the descriptor. The reception remains in the Running state.
    $07 constant ETH_RBU                        \ [0x07] Receive Buffer Unavailable This bit indicates that the application owns the next descriptor in the Receive list, and the DMA cannot acquire it. The Rx process is suspended. To resume processing Rx descriptors, the application should change the ownership of the descriptor and issue a Receive Poll Demand command. If this command is not issued, the Rx process resumes when the next recognized incoming packet is received. In ring mode, the application should advance the Receive Descriptor Tail Pointer register of a channel. This bit is set only when the DMA owns the previous Rx descriptor.
    $08 constant ETH_RPS                        \ [0x08] Receive Process Stopped This bit is asserted when the Rx process enters the Stopped state.
    $09 constant ETH_RWT                        \ [0x09] Receive Watchdog Timeout This bit is asserted when a packet with length greater than 2,048 bytes (10,240 bytes when Jumbo Packet mode is enabled) is received.
    $0a constant ETH_ETI                        \ [0x0a] Early Transmit Interrupt This bit indicates that the packet to be transmitted is fully transferred to the MTL Tx FIFO.
    $0b constant ETH_ERI                        \ [0x0b] Early Receive Interrupt This bit indicates that the DMA filled the first data buffer of the packet. The RI bit of this register automatically clears this bit.
    $0c constant ETH_FBE                        \ [0x0c] Fatal Bus Error This bit indicates that a bus error occurred (as described in the EB field). When this bit is set, the corresponding DMA channel engine disables all bus accesses.
    $0d constant ETH_CDE                        \ [0x0d] Context Descriptor Error This bit indicates that the DMA Tx engine received a context descriptor in the middle of a packet (in an intermediate descriptor), and the DMA Tx engine ignored it.
    $0e constant ETH_AIS                        \ [0x0e] Abnormal Interrupt Summary Abnormal Interrupt Summary bit value is the logical OR of the following when the corresponding interrupt bits are enabled in the ETH_DMACiIER register: Bit 1: Transmit Process Stopped Bit 7: Receive Buffer Unavailable Bit 8: Receive Process Stopped Bit 10: Early Transmit Interrupt Bit 12: Fatal Bus Error Bit 13: Context Descriptor Error Only unmasked bits affect the Abnormal Interrupt Summary bit. This is a sticky bit. You must clear this bit (by writing 1 to this bit) each time a corresponding bit, which causes AIS to be set, is cleared.
    $0f constant ETH_NIS                        \ [0x0f] Normal Interrupt Summary Normal Interrupt Summary bit value is the logical OR of the following bits when the corresponding interrupt bits are enabled in the ETH_DMACiIER register: Bit 0: Transmit Interrupt Bit 2: Transmit Buffer Unavailable Bit 6: Receive Interrupt Bit 11: Early Receive Interrupt Only unmasked bits (interrupts for which interrupt enable is set in ETH_DMACiIER register) affect the Normal Interrupt Summary bit. This is a sticky bit. You must clear this bit (by writing 1 to this bit) each time a corresponding bit which causes NIS to be set is cleared.
    $10 constant ETH_TEB                        \ [0x10 : 3] Tx DMA Error Bits This field indicates the type of error that caused a Bus Error. For example, error response on the AXI interface. Bit[2]: Error during data transfer by Tx DMA when '1', no when '0' Bit[1]: Error during descriptor access when '1', Error during data buffer access when '0' Bit[0]: Error during read transfer when '1', Error during write transfer when '0' This field is valid only when the FBE bit is set. This field does not generate an interrupt.
    $13 constant ETH_REB                        \ [0x13 : 3] Rx DMA Error Bits This field indicates the type of error that caused a Bus Error. For example, error response on the AXI interface. Bit [2]: Error during data transfer by Rx DMA when '1', no when '0' Bit[1]: Error during descriptor access when '1', Error during data buffer access when '0' Bit[0]: Error during read transfer when '1', Error during write transfer when '0' This field is valid only when the FBE bit is set. This field does not generate an interrupt.
  [then]


  [ifdef] ETH_ETH_DMAC1MFCR_DEF
    \
    \ @brief Channel 1 missed frame count register
    \ Address offset: 0x11EC
    \ Reset value: 0x00000000
    \
    $00 constant ETH_MFC                        \ [0x00 : 11] Dropped Packet Counters This counter indicates the number of packet counters that are dropped by the DMA either because of bus error or because of programing RPF field in ETH_DMAC0RXCR register. The counter gets cleared when this register is read.
    $0f constant ETH_MFCO                       \ [0x0f] Overflow status of the MFC Counter When this bit is set then the MFC counter does not get incremented further. The bit gets cleared when this register is read.
  [then]

  \
  \ @brief ETH
  \
  $00 constant ETH_ETH_MACCR            \ Operating mode configuration register
  $04 constant ETH_ETH_MACECR           \ Extended operating mode configuration register
  $08 constant ETH_ETH_MACPFR           \ Packet filtering control register
  $0C constant ETH_ETH_MACWTR           \ Watchdog timeout register
  $10 constant ETH_ETH_MACHT0R          \ Hash Table 0 register
  $14 constant ETH_ETH_MACHT1R          \ Hash Table 1 register
  $50 constant ETH_ETH_MACVTR           \ VLAN tag register
  $58 constant ETH_ETH_MACVHTR          \ VLAN Hash table register
  $60 constant ETH_ETH_MACVIR           \ VLAN inclusion register
  $64 constant ETH_ETH_MACIVIR          \ Inner VLAN inclusion register
  $70 constant ETH_ETH_MACQ0TXFCR       \ Tx Queue 0 flow control register
  $90 constant ETH_ETH_MACRXFCR         \ Rx flow control register
  $98 constant ETH_ETH_MACTXQPMR        \ Tx queue priority mapping 0 register
  $A8 constant ETH_ETH_MACRXQC2R        \ Rx queue control 2 register
  $B0 constant ETH_ETH_MACISR           \ Interrupt status register
  $B4 constant ETH_ETH_MACIER           \ Interrupt enable register
  $B8 constant ETH_ETH_MACRXTXSR        \ Rx Tx status register
  $C0 constant ETH_ETH_MACPCSR          \ Power Down When this bit is set, the MAC receiver drops all received packets until it receives the expected magic packet or remote wakeup packet. This bit is then self-cleared and the power-down mode is disabled. The software can clear this bit before the expected magic packet or remote wakeup packet is received. The packets received by the MAC after this bit is cleared are forwarded to the application. This bit must only be set when the Magic Packet Enable, Global Unicast, or Remote wakeup Packet Enable bit is set high. Note: You can gate-off the CSR clock during the power-down mode. However, when the CSR clock is gated-off, you cannot perform any read or write operations on this register. Therefore, the Software cannot clear this bit.
  $C4 constant ETH_ETH_MACRWKPFR        \ Remote wakeup packet filter Refer to and for details on register content and programming sequence.
  $D0 constant ETH_ETH_MACLCSR          \ LPI control status register
  $D4 constant ETH_ETH_MACLTCR          \ LPI timers control register
  $D8 constant ETH_ETH_MACLETR          \ LPI entry timer register
  $DC constant ETH_ETH_MAC1USTCR        \ FIXME 1-microsecond-tick counter register
  $F8 constant ETH_ETH_MACPHYCSR        \ PHYIF control status register
  $110 constant ETH_ETH_MACVR           \ Version register
  $114 constant ETH_ETH_MACDR           \ Debug register
  $11C constant ETH_ETH_MACHWF0R        \ HW feature 0 register
  $120 constant ETH_ETH_MACHWF1R        \ HW feature 1 register
  $124 constant ETH_ETH_MACHWF2R        \ HW feature 2 register
  $128 constant ETH_ETH_MACHWF3R        \ HW feature 3 register
  $200 constant ETH_ETH_MACMDIOAR       \ MDIO address register
  $204 constant ETH_ETH_MACMDIODR       \ MDIO data register
  $210 constant ETH_ETH_MACARPAR        \ ARP address register
  $230 constant ETH_ETH_MACCSRSWCR      \ CSR software control register
  $300 constant ETH_ETH_MACA0HR         \ Address 0 high register
  $304 constant ETH_ETH_MACA0LR         \ Address 0 low register
  $308 constant ETH_ETH_MACA1HR         \ Address 1 high register
  $30C constant ETH_ETH_MACA1LR         \ Address 1 low register
  $310 constant ETH_ETH_MACA2HR         \ Address 2 high register
  $314 constant ETH_ETH_MACA2LR         \ Address 2 low register
  $318 constant ETH_ETH_MACA3HR         \ Address 3 high register
  $31C constant ETH_ETH_MACA3LR         \ Address 3 low register
  $700 constant ETH_ETH_MMC_CONTROL     \ MMC control register
  $704 constant ETH_ETH_MMC_RX_INTERRUPT    \ MMC Rx interrupt register
  $708 constant ETH_ETH_MMC_TX_INTERRUPT    \ MMC Tx interrupt register
  $70C constant ETH_ETH_MMC_RX_INTERRUPT_MASK    \ MMC Rx interrupt mask register
  $710 constant ETH_ETH_MMC_TX_INTERRUPT_MASK    \ MMC Tx interrupt mask register
  $74C constant ETH_ETH_TX_SINGLE_COLLISION_GOOD_PACKETS    \ Tx single collision good packets register
  $750 constant ETH_ETH_TX_MULTIPLE_COLLISION_GOOD_PACKETS    \ Tx multiple collision good packets register
  $768 constant ETH_ETH_TX_PACKET_COUNT_GOOD    \ Tx packet count good register
  $794 constant ETH_ETH_RX_CRC_ERROR_PACKETS    \ Rx CRC error packets register
  $798 constant ETH_ETH_RX_ALIGNMENT_ERROR_PACKETS    \ Rx alignment error packets register
  $7C4 constant ETH_ETH_RX_UNICAST_PACKETS_GOOD    \ Rx unicast packets good register
  $7EC constant ETH_ETH_TX_LPI_USEC_CNTR    \ Tx LPI microsecond timer register
  $7F0 constant ETH_ETH_TX_LPI_TRAN_CNTR    \ Tx LPI transition counter register
  $7F4 constant ETH_ETH_RX_LPI_USEC_CNTR    \ Rx LPI microsecond counter register
  $7F8 constant ETH_ETH_RX_LPI_TRAN_CNTR    \ Rx LPI transition counter register
  $900 constant ETH_ETH_MACL3L4C0R      \ L3 and L4 control 0 register
  $904 constant ETH_ETH_MACL4A0R        \ Layer 4 Source Port Number Field When the L4PEN0 bit is reset and the L4DPM0 bit is set in the ETH_MACL3L4C0R register, this field contains the value to be matched with the TCP Source Port Number field in the IPv4 or IPv6 packets. When the L4PEN0 and L4DPM0 bits are set in ETH_MACL3L4C0R register, this field contains the value to be matched with the UDP Source Port Number field in the IPv4 or IPv6 packets.
  $910 constant ETH_ETH_MACL3A00R       \ Layer 3 Address 0 filter 0 register
  $914 constant ETH_ETH_MACL3A10R       \ Layer3 address 1 filter 0 register
  $918 constant ETH_ETH_MACL3A20R       \ Layer3 Address 2 filter 0 register
  $91C constant ETH_ETH_MACL3A30R       \ Layer3 Address 3 filter 0 register
  $930 constant ETH_ETH_MACL3L4C1R      \ L3 and L4 control 1 register
  $934 constant ETH_ETH_MACL4A1R        \ Layer 4 Source Port Number Field When the L4PEN0 bit is reset and the L4DPM0 bit is set in the ETH_MACL3L4C0R register, this field contains the value to be matched with the TCP Source Port Number field in the IPv4 or IPv6 packets. When the L4PEN0 and L4DPM0 bits are set in ETH_MACL3L4C0R register, this field contains the value to be matched with the UDP Source Port Number field in the IPv4 or IPv6 packets.
  $940 constant ETH_ETH_MACL3A01R       \ Layer3 address 0 filter 1 Register
  $944 constant ETH_ETH_MACL3A11R       \ Layer3 address 1 filter 1 register
  $948 constant ETH_ETH_MACL3A21R       \ Layer3 address 2 filter 1 Register
  $94C constant ETH_ETH_MACL3A31R       \ Layer3 address 3 filter 1 register
  $B00 constant ETH_ETH_MACTSCR         \ Timestamp control Register
  $B04 constant ETH_ETH_MACSSIR         \ Sub-second increment register
  $B08 constant ETH_ETH_MACSTSR         \ System time seconds register
  $B0C constant ETH_ETH_MACSTNR         \ System time nanoseconds register
  $B10 constant ETH_ETH_MACSTSUR        \ System time seconds update register
  $B14 constant ETH_ETH_MACSTNUR        \ Timestamp Sub-seconds The value in this field has the sub-second representation of time, with an accuracy of 0.46 ns. When the TSCTRLSSR bit is set in the ETH_MACTSCR register, each bit represents 1 ns and the programmed value should not exceed 0x3B9A_C9FF.
  $B18 constant ETH_ETH_MACTSAR         \ Timestamp addend register
  $B20 constant ETH_ETH_MACTSSR         \ Timestamp status register
  $B30 constant ETH_ETH_MACTXTSSNR      \ Tx timestamp status nanoseconds register
  $B34 constant ETH_ETH_MACTXTSSSR      \ Tx timestamp status seconds register
  $B40 constant ETH_ETH_MACACR          \ Auxiliary control register
  $B48 constant ETH_ETH_MACATSNR        \ Auxiliary timestamp nanoseconds register
  $B4C constant ETH_ETH_MACATSSR        \ Auxiliary timestamp seconds register
  $B50 constant ETH_ETH_MACTSIACR       \ Timestamp Ingress asymmetric correction register
  $B54 constant ETH_ETH_MACTSEACR       \ Timestamp Egress asymmetric correction register
  $B58 constant ETH_ETH_MACTSICNR       \ Timestamp Ingress correction nanosecond register
  $B5C constant ETH_ETH_MACTSECNR       \ Timestamp Egress correction nanosecond register
  $B70 constant ETH_ETH_MACPPSCR        \ PPS control register
  $B70 constant ETH_ETH_MACPPSCR_ALTERNATE    \ PPS control register
  $B80 constant ETH_ETH_MACPPSTTSR      \ PPS target time seconds register
  $B84 constant ETH_ETH_MACPPSTTNR      \ PPS target time nanoseconds register
  $B88 constant ETH_ETH_MACPPSIR        \ PPS interval register
  $B8C constant ETH_ETH_MACPPSWR        \ PPS width register
  $BC0 constant ETH_ETH_MACPOCR         \ PTP Offload control register
  $BC4 constant ETH_ETH_MACSPI0R        \ PTP Source Port Identity 0 Register
  $BC8 constant ETH_ETH_MACSPI1R        \ PTP Source port identity 1 register
  $BCC constant ETH_ETH_MACSPI2R        \ PTP Source port identity 2 register
  $BD0 constant ETH_ETH_MACLMIR         \ Log message interval register
  $C00 constant ETH_ETH_MTLOMR          \ Operating mode Register
  $C20 constant ETH_ETH_MTLISR          \ Interrupt status Register
  $D00 constant ETH_ETH_MTLTXQ0OMR      \ Tx queue 0 operating mode Register
  $D04 constant ETH_ETH_MTLTXQ0UR       \ Tx queue 0 underflow register
  $D08 constant ETH_ETH_MTLTXQ0DR       \ Tx queue 0 debug Register
  $D14 constant ETH_ETH_MTLTXQ0ESR      \ Tx queue x ETS status Register
  $D18 constant ETH_ETH_MTLTXQ0QWR      \ Tx queue 0 quantum weight register
  $D2C constant ETH_ETH_MTLQ0ICSR       \ Queue 0 interrupt control status Register
  $D30 constant ETH_ETH_MTLRXQ0OMR      \ Rx queue 0 operating mode register
  $D34 constant ETH_ETH_MTLRXQ0MPOCR    \ Rx queue 0 missed packet and overflow counter register
  $D38 constant ETH_ETH_MTLRXQ0DR       \ Rx queue 0 debug register
  $D3C constant ETH_ETH_MTLRXQ0CR       \ Rx queue 0 control register
  $D40 constant ETH_ETH_MTLTXQ1OMR      \ Tx queue 1 operating mode Register
  $D44 constant ETH_ETH_MTLTXQ1UR       \ Tx queue 1 underflow register
  $D48 constant ETH_ETH_MTLTXQ1DR       \ Tx queue 1 debug Register
  $D50 constant ETH_ETH_MTLTXQ1ECR      \ Tx queue 1 ETS control Register
  $D54 constant ETH_ETH_MTLTXQ1ESR      \ Tx queue x ETS status Register
  $D58 constant ETH_ETH_MTLTXQ1QWR      \ Tx queue 1 quantum weight register
  $D60 constant ETH_ETH_MTLTXQ1HCR      \ Tx Queue 1 hiCredit register
  $D6C constant ETH_ETH_MTLQ1ICSR       \ Queue 1 interrupt control status Register
  $D70 constant ETH_ETH_MTLRXQ1OMR      \ Rx queue 1 operating mode register
  $D74 constant ETH_ETH_MTLRXQ1MPOCR    \ Rx queue 1 missed packet and overflow counter register
  $D78 constant ETH_ETH_MTLRXQ1DR       \ Rx queue 1 debug register
  $D7C constant ETH_ETH_MTLRXQ1CR       \ Rx queue 1 control register
  $1000 constant ETH_ETH_DMAMR          \ DMA mode register
  $1004 constant ETH_ETH_DMASBMR        \ System bus mode register
  $1008 constant ETH_ETH_DMAISR         \ Interrupt status register
  $100C constant ETH_ETH_DMADSR         \ Debug status register
  $1020 constant ETH_ETH_DMAA4TXACR     \ AXI4 transmit channel ACE control register
  $1024 constant ETH_ETH_DMAA4RXACR     \ AXI4 receive channel ACE control register
  $1028 constant ETH_ETH_DMAA4DACR      \ AXI4 descriptor ACE control register
  $1100 constant ETH_ETH_DMAC0CR        \ Channel 0 control register
  $1104 constant ETH_ETH_DMAC0TXCR      \ Channel 0 transmit control register
  $1108 constant ETH_ETH_DMAC0RXCR      \ Channel 0 receive control register
  $1114 constant ETH_ETH_DMAC0TXDLAR    \ Channel 0 Tx descriptor list address register
  $111C constant ETH_ETH_DMAC0RXDLAR    \ Channel 0 Rx descriptor list address register
  $1120 constant ETH_ETH_DMAC0TXDTPR    \ Channel 0 Tx descriptor tail pointer register
  $1128 constant ETH_ETH_DMAC0RXDTPR    \ Channel 0 Rx descriptor tail pointer register
  $112C constant ETH_ETH_DMAC0TXRLR     \ Channel 0 Tx descriptor ring length register
  $1130 constant ETH_ETH_DMAC0RXRLR     \ Channel 0 Rx descriptor ring length register
  $1134 constant ETH_ETH_DMAC0IER       \ Channel 0 interrupt enable register
  $1138 constant ETH_ETH_DMAC0RXIWTR    \ Channel 0 Rx interrupt watchdog timer register
  $1144 constant ETH_ETH_DMAC0CATXDR    \ Channel 0 current application transmit descriptor register
  $114C constant ETH_ETH_DMAC0CARXDR    \ Channel 0 current application receive descriptor register
  $1154 constant ETH_ETH_DMAC0CATXBR    \ Channel 0 current application transmit buffer register
  $115C constant ETH_ETH_DMAC0CARXBR    \ Channel 0 current application receive buffer register
  $1160 constant ETH_ETH_DMAC0SR        \ Channel 0 status register
  $116C constant ETH_ETH_DMAC0MFCR      \ Channel 0 missed frame count register
  $1180 constant ETH_ETH_DMAC1CR        \ Channel 1 control register
  $1184 constant ETH_ETH_DMAC1TXCR      \ Channel 1 transmit control register
  $1194 constant ETH_ETH_DMAC1TXDLAR    \ Channel 1 Tx descriptor list address register
  $11A0 constant ETH_ETH_DMAC1TXDTPR    \ Channel 1 Tx descriptor tail pointer register
  $11AC constant ETH_ETH_DMAC1TXRLR     \ Channel 1 Tx descriptor ring length register
  $11B4 constant ETH_ETH_DMAC1IER       \ Channel 1 interrupt enable register
  $11C4 constant ETH_ETH_DMAC1CATXDR    \ Channel 1 current application transmit descriptor register
  $11D4 constant ETH_ETH_DMAC1CATXBR    \ Channel 1 current application transmit buffer register
  $11E0 constant ETH_ETH_DMAC1SR        \ Channel 1 status register
  $11EC constant ETH_ETH_DMAC1MFCR      \ Channel 1 missed frame count register

: ETH_DEF ; [then]
