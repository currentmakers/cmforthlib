\
\ @file ucpd1.fs
\ @brief USB Power Delivery interface
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] UCPD1_DEF

  [ifdef] UCPD1_UCPD_CFGR1_DEF
    \
    \ @brief UCPD configuration register 1
    \ Address offset: 0x00
    \ Reset value: 0x00000000
    \
    $00 constant UCPD1_HBITCLKDIV               \ [0x00 : 6] Division ratio for producing half-bit clock The bitfield determines the division ratio (the bitfield value plus one) of a ucpd_clk divider producing half-bit clock (hbit_clk).
    $06 constant UCPD1_IFRGAP                   \ [0x06 : 5] Division ratio for producing inter-frame gap timer clock The bitfield determines the division ratio (the bitfield value minus one) of a ucpd_clk divider producing inter-frame gap timer clock (tInterFrameGap). The division ratio 15 is to apply for Tx clock at the USB PD 2.0 specification nominal value. The division ratios below 15 are to apply for Tx clock below nominal, and the division ratios above 15 for Tx clock above nominal.
    $0b constant UCPD1_TRANSWIN                 \ [0x0b : 5] Transition window duration The bitfield determines the division ratio (the bitfield value minus one) of a hbit_clk divider producing tTransitionWindow interval. Set a value that produces an interval of 12 to 20 us, taking into account the ucpd_clk frequency and the HBITCLKDIV[5:0] bitfield setting.
    $11 constant UCPD1_PSC_USBPDCLK             \ [0x11 : 3] Pre-scaler division ratio for generating ucpd_clk The bitfield determines the division ratio of a kernel clock pre-scaler producing UCPD peripheral clock (ucpd_clk). It is recommended to use the pre-scaler so as to set the ucpd_clk frequency in the range from 6 to 9 MHz.
    $14 constant UCPD1_RXORDSETEN               \ [0x14 : 9] Receiver ordered set enable The bitfield determines the types of ordered sets that the receiver must detect. When set/cleared, each bit enables/disables a specific function: 0bxxxxxxxx1: SOP detect enabled 0bxxxxxxx1x: SOP' detect enabled 0bxxxxxx1xx: SOP'' detect enabled 0bxxxxx1xxx: Hard Reset detect enabled 0bxxxx1xxxx: Cable Detect reset enabled 0bxxx1xxxxx: SOP'_Debug enabled 0bxx1xxxxxx: SOP''_Debug enabled 0bx1xxxxxxx: SOP extension#1 enabled 0b1xxxxxxxx: SOP extension#2 enabled
    $1d constant UCPD1_TXDMAEN                  \ [0x1d] Transmission DMA mode enable When set, the bit enables DMA mode for transmission.
    $1e constant UCPD1_RXDMAEN                  \ [0x1e] Reception DMA mode enable When set, the bit enables DMA mode for reception.
    $1f constant UCPD1_UCPDEN                   \ [0x1f] UCPD peripheral enable General enable of the UCPD peripheral. Upon disabling, the peripheral instantly quits any ongoing activity and all control bits and bitfields default to their reset values. They must be set to their desired values each time the peripheral transits from disabled to enabled state.
  [then]


  [ifdef] UCPD1_UCPD_CFGR2_DEF
    \
    \ @brief UCPD configuration register 2
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $00 constant UCPD1_RXFILTDIS                \ [0x00] BMC decoder Rx pre-filter enable The sampling clock is that of the receiver (that is, after pre-scaler).
    $01 constant UCPD1_RXFILT2N3                \ [0x01] BMC decoder Rx pre-filter sampling method Number of consistent consecutive samples before confirming a new value.
    $02 constant UCPD1_FORCECLK                 \ [0x02] Force ClkReq clock request
    $03 constant UCPD1_WUPEN                    \ [0x03] Wakeup from Stop mode enable Setting the bit enables the UCPD_ASYNC_INT signal.
    $08 constant UCPD1_RXAFILTEN                \ [0x08] Rx analog filter enable Setting the bit enables the Rx analog filter required for optimum Power Delivery reception.
  [then]


  [ifdef] UCPD1_UCPD_CR_DEF
    \
    \ @brief UCPD control register
    \ Address offset: 0x0C
    \ Reset value: 0x00000000
    \
    $00 constant UCPD1_TXMODE                   \ [0x00 : 2] Type of Tx packet Writing the bitfield triggers the action as follows, depending on the value: Others: invalid From V1.1 of the USB PD specification, there is a counter defined for the duration of the BIST Carrier Mode 2. To quit this mode correctly (after the 'tBISTContMode' delay), disable the peripheral (UCPDEN = 0).
    $02 constant UCPD1_TXSEND                   \ [0x02] Command to send a Tx packet The bit is cleared by hardware as soon as the packet transmission begins or is discarded.
    $03 constant UCPD1_TXHRST                   \ [0x03] Command to send a Tx Hard Reset The bit is cleared by hardware as soon as the message transmission begins or is discarded.
    $04 constant UCPD1_RXMODE                   \ [0x04] Receiver mode Determines the mode of the receiver. When the bit is set, RXORDSET behaves normally, RXDR no longer receives bytes yet the CRC checking still proceeds as for a normal message. As this mode prevents reception of the header (containing MessageID), software has to auto-increment a received MessageID counter for inclusion in the GoodCRC acknowledge that must still be transmitted during this test.
    $05 constant UCPD1_PHYRXEN                  \ [0x05] USB Power Delivery receiver enable Both CC1 and CC2 receivers are disabled when the bit is cleared. Only the CC receiver selected via the PHYCCSEL bit is enabled when the bit is set.
    $06 constant UCPD1_PHYCCSEL                 \ [0x06] CC1/CC2 line selector for USB Power Delivery signaling The selection depends on the cable orientation as discovered at attach.
    $07 constant UCPD1_ANASUBMODE               \ [0x07 : 2] Analog PHY sub-mode Refer to TYPEC_VSTATE_CCx for the effect of this bitfield.
    $09 constant UCPD1_ANAMODE                  \ [0x09] Analog PHY operating mode The use of CC1 and CC2 depends on CCENABLE. Refer to ANAMODE, ANASUBMODE and link with TYPEC_VSTATE_CCx for the effect of this bitfield in conjunction with ANASUBMODE[1:0].
    $0a constant UCPD1_CCENABLE                 \ [0x0a : 2] CC line enable This bitfield enables CC1 and CC2 line analog PHYs (pull-ups and pull-downs) according to ANAMODE and ANASUBMODE[1:0] setting. A single line PHY can be enabled when, for example, the other line is driven by VCONN via an external VCONN switch. Enabling both PHYs is the normal usage for sink/source.
    $10 constant UCPD1_FRSRXEN                  \ [0x10] FRS event detection enable Setting the bit enables FRS Rx event (FRSEVT) detection on the CC line selected through the PHYCCSEL bit. 0: Disable Clear the bit when the device is attached to an FRS-incapable source/sink.
    $11 constant UCPD1_FRSTX                    \ [0x11] FRS Tx signaling enable. Setting the bit enables FRS Tx signaling. The bit is cleared by hardware after a delay respecting the USB Power Delivery specification Revision 3.0.
    $12 constant UCPD1_RDCH                     \ [0x12] Rdch condition drive The bit drives Rdch condition on the CC line selected through the PHYCCSEL bit (thus associated with VCONN), by remaining set during the source-only UnattachedWait.SRC state, to respect the Type-C state. Refer to 'USB Type-C ECN for Source VCONN Discharge'. The CCENABLE[1:0] bitfield must be set accordingly, too.
    $14 constant UCPD1_CC1TCDIS                 \ [0x14] CC1 Type-C detector disable The bit disables the Type-C detector on the CC1 line. When enabled, the Type-C detector for CC1 is configured through ANAMODE and ANASUBMODE[1:0].
    $15 constant UCPD1_CC2TCDIS                 \ [0x15] CC2 Type-C detector disable The bit disables the Type-C detector on the CC2 line. When enabled, the Type-C detector for CC2 is configured through ANAMODE and ANASUBMODE[1:0].
  [then]


  [ifdef] UCPD1_UCPD_IMR_DEF
    \
    \ @brief UCPD interrupt mask register
    \ Address offset: 0x10
    \ Reset value: 0x00000000
    \
    $00 constant UCPD1_TXISIE                   \ [0x00] TXIS interrupt enable
    $01 constant UCPD1_TXMSGDISCIE              \ [0x01] TXMSGDISC interrupt enable
    $02 constant UCPD1_TXMSGSENTIE              \ [0x02] TXMSGSENT interrupt enable
    $03 constant UCPD1_TXMSGABTIE               \ [0x03] TXMSGABT interrupt enable
    $04 constant UCPD1_HRSTDISCIE               \ [0x04] HRSTDISC interrupt enable
    $05 constant UCPD1_HRSTSENTIE               \ [0x05] HRSTSENT interrupt enable
    $06 constant UCPD1_TXUNDIE                  \ [0x06] TXUND interrupt enable
    $08 constant UCPD1_RXNEIE                   \ [0x08] RXNE interrupt enable
    $09 constant UCPD1_RXORDDETIE               \ [0x09] RXORDDET interrupt enable
    $0a constant UCPD1_RXHRSTDETIE              \ [0x0a] RXHRSTDET interrupt enable
    $0b constant UCPD1_RXOVRIE                  \ [0x0b] RXOVR interrupt enable
    $0c constant UCPD1_RXMSGENDIE               \ [0x0c] RXMSGEND interrupt enable
    $0e constant UCPD1_TYPECEVT1IE              \ [0x0e] TYPECEVT1 interrupt enable
    $0f constant UCPD1_TYPECEVT2IE              \ [0x0f] TYPECEVT2 interrupt enable
    $14 constant UCPD1_FRSEVTIE                 \ [0x14] FRSEVT interrupt enable
  [then]


  [ifdef] UCPD1_UCPD_SR_DEF
    \
    \ @brief UCPD status register
    \ Address offset: 0x14
    \ Reset value: 0x00000000
    \
    $00 constant UCPD1_TXIS                     \ [0x00] Transmit interrupt status The flag indicates that the UCPD_TXDR register is empty and new data write is required (as the amount of data sent has not reached the payload size defined in the TXPAYSZ bitfield). The flag is cleared with the data write into the UCPD_TXDR register.
    $01 constant UCPD1_TXMSGDISC                \ [0x01] Message transmission discarded The flag indicates that a message transmission was dropped. The flag is cleared by setting the TXMSGDISCCF bit. Transmission of a message can be dropped if there is a concurrent receive in progress or at excessive noise on the line. After a Tx message is discarded, the flag is only raised when the CC line becomes idle.
    $02 constant UCPD1_TXMSGSENT                \ [0x02] Message transmission completed The flag indicates the completion of packet transmission. It is cleared by setting the TXMSGSENTCF bit. In the event of a message transmission interrupted by a Hard Reset, the flag is not raised.
    $03 constant UCPD1_TXMSGABT                 \ [0x03] Transmit message abort The flag indicates that a Tx message is aborted due to a subsequent Hard Reset message send request taking priority during transmit. It is cleared by setting the TXMSGABTCF bit.
    $04 constant UCPD1_HRSTDISC                 \ [0x04] Hard Reset discarded The flag indicates that the Hard Reset message is discarded. The flag is cleared by setting the HRSTDISCCF bit.
    $05 constant UCPD1_HRSTSENT                 \ [0x05] Hard Reset message sent The flag indicates that the Hard Reset message is sent. The flag is cleared by setting the HRSTSENTCF bit.
    $06 constant UCPD1_TXUND                    \ [0x06] Tx data underrun detection The flag indicates that the Tx data register (UCPD_TXDR) was not written in time for a transmit message to execute normally. It is cleared by setting the TXUNDCF bit.
    $08 constant UCPD1_RXNE                     \ [0x08] Receive data register not empty detection The flag indicates that the UCPD_RXDR register is not empty. It is automatically cleared upon reading UCPD_RXDR.
    $09 constant UCPD1_RXORDDET                 \ [0x09] Rx ordered set (4 K-codes) detection The flag indicates the detection of an ordered set. The relevant information is stored in the RXORDSET[2:0] bitfield of the UCPD_RX_ORDSET register. It is cleared by setting the RXORDDETCF bit.
    $0a constant UCPD1_RXHRSTDET                \ [0x0a] Rx Hard Reset receipt detection The flag indicates the receipt of valid Hard Reset message. It is cleared by setting the RXHRSTDETCF bit.
    $0b constant UCPD1_RXOVR                    \ [0x0b] Rx data overflow detection The flag indicates Rx data buffer overflow. It is cleared by setting the RXOVRCF bit. The buffer overflow can occur if the received data are not read fast enough.
    $0c constant UCPD1_RXMSGEND                 \ [0x0c] Rx message received The flag indicates whether a message (except Hard Reset message) has been received, regardless the CRC value. The flag is cleared by setting the RXMSGENDCF bit. The RXERR flag set when the RXMSGEND flag goes high indicates errors in the last-received message.
    $0d constant UCPD1_RXERR                    \ [0x0d] Receive message error The flag indicates errors of the last Rx message declared (via RXMSGEND), such as incorrect CRC or truncated message (a line becoming static before EOP is met). It is asserted whenever the RXMSGEND flag is set.
    $0e constant UCPD1_TYPECEVT1                \ [0x0e] Type-C voltage level event on CC1 line The flag indicates a change of the TYPEC_VSTATE_CC1[1:0] bitfield value, which corresponds to a new Type-C event. It is cleared by setting the TYPECEVT2CF bit.
    $0f constant UCPD1_TYPECEVT2                \ [0x0f] Type-C voltage level event on CC2 line The flag indicates a change of the TYPEC_VSTATE_CC2[1:0] bitfield value, which corresponds to a new Type-C event. It is cleared by setting the TYPECEVT2CF bit.
    $10 constant UCPD1_TYPEC_VSTATE_CC1         \ [0x10 : 2] The status bitfield indicates the voltage level on the CC1 line in its steady state. The voltage variation on the CC1 line during USB PD messages due to the BMC PHY modulation does not impact the bitfield value.
    $12 constant UCPD1_TYPEC_VSTATE_CC2         \ [0x12 : 2] CC2 line voltage level The status bitfield indicates the voltage level on the CC2 line in its steady state. The voltage variation on the CC2 line during USB PD messages due to the BMC PHY modulation does not impact the bitfield value.
    $14 constant UCPD1_FRSEVT                   \ [0x14] FRS detection event The flag is cleared by setting the FRSEVTCF bit.
  [then]


  [ifdef] UCPD1_UCPD_ICR_DEF
    \
    \ @brief UCPD interrupt clear register
    \ Address offset: 0x18
    \ Reset value: 0x00000000
    \
    $01 constant UCPD1_TXMSGDISCCF              \ [0x01] Tx message discard flag (TXMSGDISC) clear Setting the bit clears the TXMSGDISC flag in the UCPD_SR register.
    $02 constant UCPD1_TXMSGSENTCF              \ [0x02] Tx message send flag (TXMSGSENT) clear Setting the bit clears the TXMSGSENT flag in the UCPD_SR register.
    $03 constant UCPD1_TXMSGABTCF               \ [0x03] Tx message abort flag (TXMSGABT) clear Setting the bit clears the TXMSGABT flag in the UCPD_SR register.
    $04 constant UCPD1_HRSTDISCCF               \ [0x04] Hard reset discard flag (HRSTDISC) clear Setting the bit clears the HRSTDISC flag in the UCPD_SR register.
    $05 constant UCPD1_HRSTSENTCF               \ [0x05] Hard reset send flag (HRSTSENT) clear Setting the bit clears the HRSTSENT flag in the UCPD_SR register.
    $06 constant UCPD1_TXUNDCF                  \ [0x06] Tx underflow flag (TXUND) clear Setting the bit clears the TXUND flag in the UCPD_SR register.
    $09 constant UCPD1_RXORDDETCF               \ [0x09] Rx ordered set detect flag (RXORDDET) clear Setting the bit clears the RXORDDET flag in the UCPD_SR register.
    $0a constant UCPD1_RXHRSTDETCF              \ [0x0a] Rx Hard Reset detect flag (RXHRSTDET) clear Setting the bit clears the RXHRSTDET flag in the UCPD_SR register.
    $0b constant UCPD1_RXOVRCF                  \ [0x0b] Rx overflow flag (RXOVR) clear Setting the bit clears the RXOVR flag in the UCPD_SR register.
    $0c constant UCPD1_RXMSGENDCF               \ [0x0c] Rx message received flag (RXMSGEND) clear Setting the bit clears the RXMSGEND flag in the UCPD_SR register.
    $0e constant UCPD1_TYPECEVT1CF              \ [0x0e] Type-C CC1 event flag (TYPECEVT1) clear Setting the bit clears the TYPECEVT1 flag in the UCPD_SR register
    $0f constant UCPD1_TYPECEVT2CF              \ [0x0f] Type-C CC2 line event flag (TYPECEVT2) clear Setting the bit clears the TYPECEVT2 flag in the UCPD_SR register
    $14 constant UCPD1_FRSEVTCF                 \ [0x14] FRS event flag (FRSEVT) clear Setting the bit clears the FRSEVT flag in the UCPD_SR register.
  [then]


  [ifdef] UCPD1_UCPD_TX_ORDSETR_DEF
    \
    \ @brief UCPD Tx ordered set type register
    \ Address offset: 0x1C
    \ Reset value: 0x00000000
    \
    $00 constant UCPD1_TXORDSET                 \ [0x00 : 20] Ordered set to transmit The bitfield determines a full 20-bit sequence to transmit, consisting of four K-codes, each of five bits, defining the packet to transmit. The bit 0 (bit 0 of K-code1) is the first, the bit 19 (bit 4 of K code4) the last.
  [then]


  [ifdef] UCPD1_UCPD_TX_PAYSZR_DEF
    \
    \ @brief UCPD Tx payload size register
    \ Address offset: 0x20
    \ Reset value: 0x00000000
    \
    $00 constant UCPD1_TXPAYSZ                  \ [0x00 : 10] Payload size yet to transmit The bitfield is modified by software and by hardware. It contains the number of bytes of a payload (including header but excluding CRC) yet to transmit: each time a data byte is written into the UCPD_TXDR register, the bitfield value decrements and the TXIS bit is set, except when the bitfield value reaches zero. The enumerated values are standard payload sizes before the start of transmission.
  [then]


  [ifdef] UCPD1_UCPD_TXDR_DEF
    \
    \ @brief UCPD Tx data register
    \ Address offset: 0x24
    \ Reset value: 0x00000000
    \
    $00 constant UCPD1_TXDATA                   \ [0x00 : 8] Data byte to transmit
  [then]


  [ifdef] UCPD1_UCPD_RX_ORDSETR_DEF
    \
    \ @brief UCPD Rx ordered set register
    \ Address offset: 0x28
    \ Reset value: 0x00000000
    \
    $00 constant UCPD1_RXORDSET                 \ [0x00 : 3] Rx ordered set code detected
    $03 constant UCPD1_RXSOP3OF4                \ [0x03] The bit indicates the number of correct K codes. For debug purposes only.
    $04 constant UCPD1_RXSOPKINVALID            \ [0x04 : 3] The bitfield is for debug purposes only. Others: Invalid
  [then]


  [ifdef] UCPD1_UCPD_RX_PAYSZR_DEF
    \
    \ @brief UCPD Rx payload size register
    \ Address offset: 0x2C
    \ Reset value: 0x00000000
    \
    $00 constant UCPD1_RXPAYSZ                  \ [0x00 : 10] Rx payload size received This bitfield contains the number of bytes of a payload (including header but excluding CRC) received: each time a new data byte is received in the UCPD_RXDR register, the bitfield value increments and the RXMSGEND flag is set (and an interrupt generated if enabled). The bitfield may return a spurious value when a byte reception is ongoing (the RXMSGEND flag is low).
  [then]


  [ifdef] UCPD1_UCPD_RXDR_DEF
    \
    \ @brief UCPD receive data register
    \ Address offset: 0x30
    \ Reset value: 0x00000000
    \
    $00 constant UCPD1_RXDATA                   \ [0x00 : 8] Data byte received
  [then]


  [ifdef] UCPD1_UCPD_RX_ORDEXTR1_DEF
    \
    \ @brief UCPD Rx ordered set extension register 1
    \ Address offset: 0x34
    \ Reset value: 0x00000000
    \
    $00 constant UCPD1_RXSOPX1                  \ [0x00 : 20] Ordered set 1 received The bitfield contains a full 20-bit sequence received, consisting of four K codes, each of five bits. The bit 0 (bit 0 of K code1) is receive first, the bit 19 (bit 4 of K code4) last.
  [then]


  [ifdef] UCPD1_UCPD_RX_ORDEXTR2_DEF
    \
    \ @brief UCPD Rx ordered set extension register 2
    \ Address offset: 0x38
    \ Reset value: 0x00000000
    \
    $00 constant UCPD1_RXSOPX2                  \ [0x00 : 20] Ordered set 2 received The bitfield contains a full 20-bit sequence received, consisting of four K codes, each of five bits. The bit 0 (bit 0 of K code1) is receive first, the bit 19 (bit 4 of K code4) last.
  [then]

  \
  \ @brief USB Power Delivery interface
  \
  $00 constant UCPD1_UCPD_CFGR1         \ UCPD configuration register 1
  $04 constant UCPD1_UCPD_CFGR2         \ UCPD configuration register 2
  $0C constant UCPD1_UCPD_CR            \ UCPD control register
  $10 constant UCPD1_UCPD_IMR           \ UCPD interrupt mask register
  $14 constant UCPD1_UCPD_SR            \ UCPD status register
  $18 constant UCPD1_UCPD_ICR           \ UCPD interrupt clear register
  $1C constant UCPD1_UCPD_TX_ORDSETR    \ UCPD Tx ordered set type register
  $20 constant UCPD1_UCPD_TX_PAYSZR     \ UCPD Tx payload size register
  $24 constant UCPD1_UCPD_TXDR          \ UCPD Tx data register
  $28 constant UCPD1_UCPD_RX_ORDSETR    \ UCPD Rx ordered set register
  $2C constant UCPD1_UCPD_RX_PAYSZR     \ UCPD Rx payload size register
  $30 constant UCPD1_UCPD_RXDR          \ UCPD receive data register
  $34 constant UCPD1_UCPD_RX_ORDEXTR1   \ UCPD Rx ordered set extension register 1
  $38 constant UCPD1_UCPD_RX_ORDEXTR2   \ UCPD Rx ordered set extension register 2

: UCPD1_DEF ; [then]
