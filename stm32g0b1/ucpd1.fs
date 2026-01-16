\
\ @file ucpd1.fs
\ @brief USB Power Delivery interface
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief UCPD configuration register 1
\ Address offset: 0x00
\ Reset value: 0x00000000
\

$0000003f constant UCPD1_UCPD_CFGR1_HBITCLKDIV                      \ Division ratio for producing half-bit clock The bitfield determines the division ratio (the bitfield value plus one) of a ucpd_clk divider producing half-bit clock (hbit_clk).
$000007c0 constant UCPD1_UCPD_CFGR1_IFRGAP                          \ Division ratio for producing inter-frame gap timer clock The bitfield determines the division ratio (the bitfield value minus one) of a ucpd_clk divider producing inter-frame gap timer clock (tInterFrameGap). The division ratio 15 is to apply for Tx clock at the USB PD 2.0 specification nominal value. The division ratios below 15 are to apply for Tx clock below nominal, and the division ratios above 15 for Tx clock above nominal.
$0000f800 constant UCPD1_UCPD_CFGR1_TRANSWIN                        \ Transition window duration The bitfield determines the division ratio (the bitfield value minus one) of a hbit_clk divider producing tTransitionWindow interval. Set a value that produces an interval of 12 to 20 us, taking into account the ucpd_clk frequency and the HBITCLKDIV[5:0] bitfield setting.
$000e0000 constant UCPD1_UCPD_CFGR1_PSC_USBPDCLK                    \ Pre-scaler division ratio for generating ucpd_clk The bitfield determines the division ratio of a kernel clock pre-scaler producing UCPD peripheral clock (ucpd_clk). It is recommended to use the pre-scaler so as to set the ucpd_clk frequency in the range from 6 to 9 MHz.
$1ff00000 constant UCPD1_UCPD_CFGR1_RXORDSETEN                      \ Receiver ordered set enable The bitfield determines the types of ordered sets that the receiver must detect. When set/cleared, each bit enables/disables a specific function: 0bxxxxxxxx1: SOP detect enabled 0bxxxxxxx1x: SOP' detect enabled 0bxxxxxx1xx: SOP'' detect enabled 0bxxxxx1xxx: Hard Reset detect enabled 0bxxxx1xxxx: Cable Detect reset enabled 0bxxx1xxxxx: SOP'_Debug enabled 0bxx1xxxxxx: SOP''_Debug enabled 0bx1xxxxxxx: SOP extension#1 enabled 0b1xxxxxxxx: SOP extension#2 enabled
$20000000 constant UCPD1_UCPD_CFGR1_TXDMAEN                         \ Transmission DMA mode enable When set, the bit enables DMA mode for transmission.
$40000000 constant UCPD1_UCPD_CFGR1_RXDMAEN                         \ Reception DMA mode enable When set, the bit enables DMA mode for reception.
$80000000 constant UCPD1_UCPD_CFGR1_UCPDEN                          \ UCPD peripheral enable General enable of the UCPD peripheral. Upon disabling, the peripheral instantly quits any ongoing activity and all control bits and bitfields default to their reset values. They must be set to their desired values each time the peripheral transits from disabled to enabled state.


\
\ @brief UCPD configuration register 2
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$00000001 constant UCPD1_UCPD_CFGR2_RXFILTDIS                       \ BMC decoder Rx pre-filter enable The sampling clock is that of the receiver (that is, after pre-scaler).
$00000002 constant UCPD1_UCPD_CFGR2_RXFILT2N3                       \ BMC decoder Rx pre-filter sampling method Number of consistent consecutive samples before confirming a new value.
$00000004 constant UCPD1_UCPD_CFGR2_FORCECLK                        \ Force ClkReq clock request
$00000008 constant UCPD1_UCPD_CFGR2_WUPEN                           \ Wakeup from Stop mode enable Setting the bit enables the UCPD_ASYNC_INT signal.


\
\ @brief UCPD configuration register 3
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$0000000f constant UCPD1_UCPD_CFGR3_TRIM1_NG_CCRPD                  \ SW trim value for RPD resistors on the CC1 line
$000001f0 constant UCPD1_UCPD_CFGR3_TRIM1_NG_CC1A5                  \ SW trim value for RP1A5 resistors on the CC1 line
$00001e00 constant UCPD1_UCPD_CFGR3_TRIM1_NG_CC3A0                  \ SW trim value for RP3A0 resistors on the CC1 line
$000f0000 constant UCPD1_UCPD_CFGR3_TRIM2_NG_CCRPD                  \ SW trim value for RPD resistors on the CC2 line
$01f00000 constant UCPD1_UCPD_CFGR3_TRIM2_NG_CC1A5                  \ SW trim value for RP1A5 resistors on the CC2 line
$1e000000 constant UCPD1_UCPD_CFGR3_TRIM2_NG_CC3A0                  \ SW trim value for RP3A0 resistors on the CC2 line


\
\ @brief UCPD control register
\ Address offset: 0x0C
\ Reset value: 0x00000000
\

$00000003 constant UCPD1_UCPD_CR_TXMODE                             \ Type of Tx packet
$00000004 constant UCPD1_UCPD_CR_TXSEND                             \ Command to send a Tx packet The bit is cleared by hardware as soon as the packet transmission begins or is discarded.
$00000008 constant UCPD1_UCPD_CR_TXHRST                             \ Command to send a Tx Hard Reset The bit is cleared by hardware as soon as the message transmission begins or is discarded.
$00000010 constant UCPD1_UCPD_CR_RXMODE                             \ Receiver mode Determines the mode of the receiver. When the bit is set, RXORDSET behaves normally, RXDR no longer receives bytes yet the CRC checking still proceeds as for a normal message.
$00000020 constant UCPD1_UCPD_CR_PHYRXEN                            \ USB Power Delivery receiver enable Both CC1 and CC2 receivers are disabled when the bit is cleared. Only the CC receiver selected via the PHYCCSEL bit is enabled when the bit is set.
$00000040 constant UCPD1_UCPD_CR_PHYCCSEL                           \ CC1/CC2 line selector for USB Power Delivery signaling The selection depends on the cable orientation as discovered at attach.
$00000180 constant UCPD1_UCPD_CR_ANASUBMODE                         \ Analog PHY sub-mode Refer to TYPEC_VSTATE_CCx for the effect of this bitfield.
$00000200 constant UCPD1_UCPD_CR_ANAMODE                            \ Analog PHY operating mode The bit takes effect upon setting the UCPDx_STROBE bit of the SYS_CONFIG register. The use of CC1 and CC2 depends on CCENABLE. Refer to ANAMODE, ANASUBMODE and link with TYPEC_VSTATE_CCx for the effect of this bitfield in conjunction with ANASUBMODE[1:0].
$00000c00 constant UCPD1_UCPD_CR_CCENABLE                           \ CC line enable This bitfield enables CC1 and CC2 line analog PHYs (pull-ups and pull-downs) according to ANAMODE and ANASUBMODE[1:0] setting. A single line PHY can be enabled when, for example, the other line is driven by VCONN via an external VCONN switch. Enabling both PHYs is the normal usage for sink/source.
$00002000 constant UCPD1_UCPD_CR_CC1VCONNEN                         \ VCONN switch enable for CC1
$00004000 constant UCPD1_UCPD_CR_CC2VCONNEN                         \ VCONN switch enable for CC2
$00008000 constant UCPD1_UCPD_CR_DBATTEN                            \ Dead battery function enable The bit takes effect upon setting the USBPDstrobe bit of the SYS_CONFIG register. Dead battery function only operates if the external circuit is appropriately configured.
$00010000 constant UCPD1_UCPD_CR_FRSRXEN                            \ FRS event detection enable Setting the bit enables FRS Rx event (FRSEVT) detection on the CC line selected through the PHYCCSEL bit. 0: Disable Clear the bit when the device is attached to an FRS-incapable source/sink.
$00020000 constant UCPD1_UCPD_CR_FRSTX                              \ FRS Tx signaling enable. Setting the bit enables FRS Tx signaling. The bit is cleared by hardware after a delay respecting the USB Power Delivery specification Revision 3.0.
$00040000 constant UCPD1_UCPD_CR_RDCH                               \ Rdch condition drive
$00100000 constant UCPD1_UCPD_CR_CC1TCDIS                           \ CC1 Type-C detector disable The bit disables the Type-C detector on the CC1 line. When enabled, the Type-C detector for CC1 is configured through ANAMODE and ANASUBMODE[1:0].
$00200000 constant UCPD1_UCPD_CR_CC2TCDIS                           \ CC2 Type-C detector disable The bit disables the Type-C detector on the CC2 line. When enabled, the Type-C detector for CC2 is configured through ANAMODE and ANASUBMODE[1:0].


\
\ @brief UCPD interrupt mask register
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$00000001 constant UCPD1_UCPD_IMR_TXISIE                            \ TXIS interrupt enable
$00000002 constant UCPD1_UCPD_IMR_TXMSGDISCIE                       \ TXMSGDISC interrupt enable
$00000004 constant UCPD1_UCPD_IMR_TXMSGSENTIE                       \ TXMSGSENT interrupt enable
$00000008 constant UCPD1_UCPD_IMR_TXMSGABTIE                        \ TXMSGABT interrupt enable
$00000010 constant UCPD1_UCPD_IMR_HRSTDISCIE                        \ HRSTDISC interrupt enable
$00000020 constant UCPD1_UCPD_IMR_HRSTSENTIE                        \ HRSTSENT interrupt enable
$00000040 constant UCPD1_UCPD_IMR_TXUNDIE                           \ TXUND interrupt enable
$00000100 constant UCPD1_UCPD_IMR_RXNEIE                            \ RXNE interrupt enable
$00000200 constant UCPD1_UCPD_IMR_RXORDDETIE                        \ RXORDDET interrupt enable
$00000400 constant UCPD1_UCPD_IMR_RXHRSTDETIE                       \ RXHRSTDET interrupt enable
$00000800 constant UCPD1_UCPD_IMR_RXOVRIE                           \ RXOVR interrupt enable
$00001000 constant UCPD1_UCPD_IMR_RXMSGENDIE                        \ RXMSGEND interrupt enable
$00004000 constant UCPD1_UCPD_IMR_TYPECEVT1IE                       \ TYPECEVT1 interrupt enable
$00008000 constant UCPD1_UCPD_IMR_TYPECEVT2IE                       \ TYPECEVT2 interrupt enable
$00100000 constant UCPD1_UCPD_IMR_FRSEVTIE                          \ FRSEVT interrupt enable


\
\ @brief UCPD status register
\ Address offset: 0x14
\ Reset value: 0x00000000
\

$00000001 constant UCPD1_UCPD_SR_TXIS                               \ Transmit interrupt status The flag indicates that the UCPD_TXDR register is empty and new data write is required (as the amount of data sent has not reached the payload size defined in the TXPAYSZ bitfield). The flag is cleared with the data write into the UCPD_TXDR register.
$00000002 constant UCPD1_UCPD_SR_TXMSGDISC                          \ Message transmission discarded The flag indicates that a message transmission was dropped. The flag is cleared by setting the TXMSGDISCCF bit. Transmission of a message can be dropped if there is a concurrent receive in progress or at excessive noise on the line. After a Tx message is discarded, the flag is only raised when the CC line becomes idle.
$00000004 constant UCPD1_UCPD_SR_TXMSGSENT                          \ Message transmission completed The flag indicates the completion of packet transmission. It is cleared by setting the TXMSGSENTCF bit. In the event of a message transmission interrupted by a Hard Reset, the flag is not raised.
$00000008 constant UCPD1_UCPD_SR_TXMSGABT                           \ Transmit message abort The flag indicates that a Tx message is aborted due to a subsequent Hard Reset message send request taking priority during transmit. It is cleared by setting the TXMSGABTCF bit.
$00000010 constant UCPD1_UCPD_SR_HRSTDISC                           \ Hard Reset discarded The flag indicates that the Hard Reset message is discarded. The flag is cleared by setting the HRSTDISCCF bit.
$00000020 constant UCPD1_UCPD_SR_HRSTSENT                           \ Hard Reset message sent The flag indicates that the Hard Reset message is sent. The flag is cleared by setting the HRSTSENTCF bit.
$00000040 constant UCPD1_UCPD_SR_TXUND                              \ Tx data underrun detection The flag indicates that the Tx data register (UCPD_TXDR) was not written in time for a transmit message to execute normally. It is cleared by setting the TXUNDCF bit.
$00000100 constant UCPD1_UCPD_SR_RXNE                               \ Receive data register not empty detection The flag indicates that the UCPD_RXDR register is not empty. It is automatically cleared upon reading UCPD_RXDR.
$00000200 constant UCPD1_UCPD_SR_RXORDDET                           \ Rx ordered set (4 K-codes) detection The flag indicates the detection of an ordered set. The relevant information is stored in the RXORDSET[2:0] bitfield of the UCPD_RX_ORDSET register. It is cleared by setting the RXORDDETCF bit.
$00000400 constant UCPD1_UCPD_SR_RXHRSTDET                          \ Rx Hard Reset receipt detection The flag indicates the receipt of valid Hard Reset message. It is cleared by setting the RXHRSTDETCF bit.
$00000800 constant UCPD1_UCPD_SR_RXOVR                              \ Rx data overflow detection The flag indicates Rx data buffer overflow. It is cleared by setting the RXOVRCF bit. The buffer overflow can occur if the received data are not read fast enough.
$00001000 constant UCPD1_UCPD_SR_RXMSGEND                           \ Rx message received The flag indicates whether a message (except Hard Reset message) has been received, regardless the CRC value. The flag is cleared by setting the RXMSGENDCF bit. The RXERR flag set when the RXMSGEND flag goes high indicates errors in the last-received message.
$00002000 constant UCPD1_UCPD_SR_RXERR                              \ Receive message error The flag indicates errors of the last Rx message declared (via RXMSGEND), such as incorrect CRC or truncated message (a line becoming static before EOP is met). It is asserted whenever the RXMSGEND flag is set.
$00004000 constant UCPD1_UCPD_SR_TYPECEVT1                          \ Type-C voltage level event on CC1 line The flag indicates a change of the TYPEC_VSTATE_CC1[1:0] bitfield value, which corresponds to a new Type-C event. It is cleared by setting the TYPECEVT2CF bit.
$00008000 constant UCPD1_UCPD_SR_TYPECEVT2                          \ Type-C voltage level event on CC2 line The flag indicates a change of the TYPEC_VSTATE_CC2[1:0] bitfield value, which corresponds to a new Type-C event. It is cleared by setting the TYPECEVT2CF bit.
$00030000 constant UCPD1_UCPD_SR_TYPEC_VSTATE_CC1                   \ The status bitfield indicates the voltage level on the CC1 line in its steady state. The voltage variation on the CC1 line during USB PD messages due to the BMC PHY modulation does not impact the bitfield value.
$000c0000 constant UCPD1_UCPD_SR_TYPEC_VSTATE_CC2                   \ CC2 line voltage level The status bitfield indicates the voltage level on the CC2 line in its steady state. The voltage variation on the CC2 line during USB PD messages due to the BMC PHY modulation does not impact the bitfield value.
$00100000 constant UCPD1_UCPD_SR_FRSEVT                             \ FRS detection event The flag is cleared by setting the FRSEVTCF bit.


\
\ @brief UCPD interrupt clear register
\ Address offset: 0x18
\ Reset value: 0x00000000
\

$00000002 constant UCPD1_UCPD_ICR_TXMSGDISCCF                       \ Tx message discard flag (TXMSGDISC) clear Setting the bit clears the TXMSGDISC flag in the UCPD_SR register.
$00000004 constant UCPD1_UCPD_ICR_TXMSGSENTCF                       \ Tx message send flag (TXMSGSENT) clear Setting the bit clears the TXMSGSENT flag in the UCPD_SR register.
$00000008 constant UCPD1_UCPD_ICR_TXMSGABTCF                        \ Tx message abort flag (TXMSGABT) clear Setting the bit clears the TXMSGABT flag in the UCPD_SR register.
$00000010 constant UCPD1_UCPD_ICR_HRSTDISCCF                        \ Hard reset discard flag (HRSTDISC) clear Setting the bit clears the HRSTDISC flag in the UCPD_SR register.
$00000020 constant UCPD1_UCPD_ICR_HRSTSENTCF                        \ Hard reset send flag (HRSTSENT) clear Setting the bit clears the HRSTSENT flag in the UCPD_SR register.
$00000040 constant UCPD1_UCPD_ICR_TXUNDCF                           \ Tx underflow flag (TXUND) clear Setting the bit clears the TXUND flag in the UCPD_SR register.
$00000200 constant UCPD1_UCPD_ICR_RXORDDETCF                        \ Rx ordered set detect flag (RXORDDET) clear Setting the bit clears the RXORDDET flag in the UCPD_SR register.
$00000400 constant UCPD1_UCPD_ICR_RXHRSTDETCF                       \ Rx Hard Reset detect flag (RXHRSTDET) clear Setting the bit clears the RXHRSTDET flag in the UCPD_SR register.
$00000800 constant UCPD1_UCPD_ICR_RXOVRCF                           \ Rx overflow flag (RXOVR) clear Setting the bit clears the RXOVR flag in the UCPD_SR register.
$00001000 constant UCPD1_UCPD_ICR_RXMSGENDCF                        \ Rx message received flag (RXMSGEND) clear Setting the bit clears the RXMSGEND flag in the UCPD_SR register.
$00004000 constant UCPD1_UCPD_ICR_TYPECEVT1CF                       \ Type-C CC1 event flag (TYPECEVT1) clear Setting the bit clears the TYPECEVT1 flag in the UCPD_SR register
$00008000 constant UCPD1_UCPD_ICR_TYPECEVT2CF                       \ Type-C CC2 line event flag (TYPECEVT2) clear Setting the bit clears the TYPECEVT2 flag in the UCPD_SR register
$00100000 constant UCPD1_UCPD_ICR_FRSEVTCF                          \ FRS event flag (FRSEVT) clear Setting the bit clears the FRSEVT flag in the UCPD_SR register.


\
\ @brief UCPD Tx ordered set type register
\ Address offset: 0x1C
\ Reset value: 0x00000000
\

$000fffff constant UCPD1_UCPD_TX_ORDSETR_TXORDSET                   \ Ordered set to transmit The bitfield determines a full 20-bit sequence to transmit, consisting of four K-codes, each of five bits, defining the packet to transmit. The bit 0 (bit 0 of K-code1) is the first, the bit 19 (bit 4 of code4) the last.


\
\ @brief UCPD Tx payload size register
\ Address offset: 0x20
\ Reset value: 0x00000000
\

$000003ff constant UCPD1_UCPD_TX_PAYSZR_TXPAYSZ                     \ Payload size yet to transmit The bitfield is modified by software and by hardware. It contains the number of bytes of a payload (including header but excluding CRC) yet to transmit: each time a data byte is written into the UCPD_TXDR register, the bitfield value decrements and the TXIS bit is set, except when the bitfield value reaches zero. The enumerated values are standard payload sizes before the start of transmission.


\
\ @brief UCPD Tx data register
\ Address offset: 0x24
\ Reset value: 0x00000000
\

$000000ff constant UCPD1_UCPD_TXDR_TXDATA                           \ Data byte to transmit


\
\ @brief UCPD Rx ordered set register
\ Address offset: 0x28
\ Reset value: 0x00000000
\

$00000007 constant UCPD1_UCPD_RX_ORDSETR_RXORDSET                   \ Rx ordered set code detected
$00000008 constant UCPD1_UCPD_RX_ORDSETR_RXSOP3OF4                  \ The bit indicates the number of correct. For debug purposes only.
$00000070 constant UCPD1_UCPD_RX_ORDSETR_RXSOPKINVALID              \ The bitfield is for debug purposes only. Others: Invalid


\
\ @brief UCPD Rx payload size register
\ Address offset: 0x2C
\ Reset value: 0x00000000
\

$000003ff constant UCPD1_UCPD_RX_PAYSZR_RXPAYSZ                     \ Rx payload size received This bitfield contains the number of bytes of a payload (including header but excluding CRC) received: each time a new data byte is received in the UCPD_RXDR register, the bitfield value increments and the RXMSGEND flag is set (and an interrupt generated if enabled). The bitfield may return a spurious value when a byte reception is ongoing (the RXMSGEND flag is low).


\
\ @brief UCPD receive data register
\ Address offset: 0x30
\ Reset value: 0x00000000
\

$000000ff constant UCPD1_UCPD_RXDR_RXDATA                           \ Data byte received


\
\ @brief UCPD Rx ordered set extension register 1
\ Address offset: 0x34
\ Reset value: 0x00000000
\

$000fffff constant UCPD1_UCPD_RX_ORDEXTR1_RXSOPX1                   \ Ordered set 1 received


\
\ @brief UCPD Rx ordered set extension register 2
\ Address offset: 0x38
\ Reset value: 0x00000000
\

$000fffff constant UCPD1_UCPD_RX_ORDEXTR2_RXSOPX2                   \ Ordered set 2 received


\
\ @brief USB Power Delivery interface
\
$4000a000 constant UCPD1_UCPD_CFGR1  \ offset: 0x00 : UCPD configuration register 1
$4000a004 constant UCPD1_UCPD_CFGR2  \ offset: 0x04 : UCPD configuration register 2
$4000a008 constant UCPD1_UCPD_CFGR3  \ offset: 0x08 : UCPD configuration register 3
$4000a00c constant UCPD1_UCPD_CR  \ offset: 0x0C : UCPD control register
$4000a010 constant UCPD1_UCPD_IMR  \ offset: 0x10 : UCPD interrupt mask register
$4000a014 constant UCPD1_UCPD_SR  \ offset: 0x14 : UCPD status register
$4000a018 constant UCPD1_UCPD_ICR  \ offset: 0x18 : UCPD interrupt clear register
$4000a01c constant UCPD1_UCPD_TX_ORDSETR  \ offset: 0x1C : UCPD Tx ordered set type register
$4000a020 constant UCPD1_UCPD_TX_PAYSZR  \ offset: 0x20 : UCPD Tx payload size register
$4000a024 constant UCPD1_UCPD_TXDR  \ offset: 0x24 : UCPD Tx data register
$4000a028 constant UCPD1_UCPD_RX_ORDSETR  \ offset: 0x28 : UCPD Rx ordered set register
$4000a02c constant UCPD1_UCPD_RX_PAYSZR  \ offset: 0x2C : UCPD Rx payload size register
$4000a030 constant UCPD1_UCPD_RXDR  \ offset: 0x30 : UCPD receive data register
$4000a034 constant UCPD1_UCPD_RX_ORDEXTR1  \ offset: 0x34 : UCPD Rx ordered set extension register 1
$4000a038 constant UCPD1_UCPD_RX_ORDEXTR2  \ offset: 0x38 : UCPD Rx ordered set extension register 2

