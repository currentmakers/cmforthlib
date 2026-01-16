\
\ @file cec.fs
\ @brief HDMI-CEC controller
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief CEC control register
\ Address offset: 0x00
\ Reset value: 0x00000000
\

$00000001 constant CEC_CEC_CR_CECEN                                 \ CEC enable The CECEN bit is set and cleared by software. CECEN = 1 starts message reception and enables the TXSOM control. CECEN = 0 disables the CEC peripheral, clears all bits of CEC_CR register and aborts any on-going reception or transmission.
$00000002 constant CEC_CEC_CR_TXSOM                                 \ Tx start of message TXSOM is set by software to command transmission of the first byte of a CEC message. If the CEC message consists of only one byte, TXEOM must be set before of TXSOM. Start-bit is effectively started on the CEC line after SFT is counted. If TXSOM is set while a message reception is ongoing, transmission starts after the end of reception. TXSOM is cleared by hardware after the last byte of the message is sent with a positive acknowledge (TXEND = 1), in case of transmission underrun (TXUDR = 1), negative acknowledge (TXACKE = 1), and transmission error (TXERR = 1). It is also cleared by CECEN = 0. It is not cleared and transmission is automatically retried in case of arbitration lost (ARBLST = 1). TXSOM can be also used as a status bit informing application whether any transmission request is pending or under execution. The application can abort a transmission request at any time by clearing the CECEN bit. Note: TXSOM must be set when CECEN = 1. Note: TXSOM must be set when transmission data is available into TXDR. Note: HEADER first four bits containing own peripheral address are taken from TXDR[7:4], not from CEC_CFGR.OAR that is used only for reception.
$00000004 constant CEC_CEC_CR_TXEOM                                 \ Tx end of message The TXEOM bit is set by software to command transmission of the last byte of a CEC message. TXEOM is cleared by hardware at the same time and under the same conditions as for TXSOM. Note: TXEOM must be set when CECEN = 1. Note: TXEOM must be set before writing transmission data to TXDR. Note: If TXEOM is set when TXSOM = 0, transmitted message consists of 1 byte (HEADER) only (PING message).


\
\ @brief CEC configuration register
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$00000007 constant CEC_CEC_CFGR_SFT                                 \ Signal free time SFT bits are set by software. In the SFT = 0x0 configuration, the number of nominal data bit periods waited before transmission is ruled by hardware according to the transmission history. In all the other configurations the SFT number is determined by software. 0x0 2.5 data-bit periods if CEC is the last bus initiator with unsuccessful transmission (ARBLST = 1, TXERR = 1, TXUDR = 1 or TXACKE = 1) 4 data-bit periods if CEC is the new bus initiator 6 data-bit periods if CEC is the last bus initiator with successful transmission (TXEOM = 1)
$00000008 constant CEC_CEC_CFGR_RXTOL                               \ Rx-tolerance The RXTOL bit is set and cleared by software. Start-bit, +/- 200 s rise, +/- 200 s fall Data-bit: +/- 200 s rise. +/- 350 s fall Start-bit: +/- 400 s rise, +/- 400 s fall Data-bit: +/-300 s rise, +/- 500 s fall
$00000010 constant CEC_CEC_CFGR_BRESTP                              \ Rx-stop on bit rising error The BRESTP bit is set and cleared by software.
$00000020 constant CEC_CEC_CFGR_BREGEN                              \ Generate error-bit on bit rising error The BREGEN bit is set and cleared by software. Note: If BRDNOGEN = 0, an error-bit is generated upon BRE detection with BRESTP = 1 in broadcast even if BREGEN = 0.
$00000040 constant CEC_CEC_CFGR_LBPEGEN                             \ Generate error-bit on long bit period error The LBPEGEN bit is set and cleared by software. Note: If BRDNOGEN = 0, an error-bit is generated upon LBPE detection in broadcast even if LBPEGEN = 0.
$00000080 constant CEC_CEC_CFGR_BRDNOGEN                            \ Avoid error-bit generation in broadcast The BRDNOGEN bit is set and cleared by software. error-bit on the CEC line. LBPE detection with LBPEGEN = 0 on a broadcast message generates an error-bit on the CEC line.
$00000100 constant CEC_CEC_CFGR_SFTOP                               \ SFT option bit The SFTOPT bit is set and cleared by software.
$7fff0000 constant CEC_CEC_CFGR_OAR                                 \ Own addresses configuration The OAR bits are set by software to select which destination logical addresses has to be considered in receive mode. Each bit, when set, enables the CEC logical address identified by the given bit position. At the end of HEADER reception, the received destination address is compared with the enabled addresses. In case of matching address, the incoming message is acknowledged and received. In case of non-matching address, the incoming message is received only in listen mode (LSTN = 1), but without acknowledge sent. Broadcast messages are always received. Example: OAR = 0b000 0000 0010 0001 means that CEC acknowledges addresses 0x0 and 0x5. Consequently, each message directed to one of these addresses is received.
$80000000 constant CEC_CEC_CFGR_LSTN                                \ Listen mode LSTN bit is set and cleared by software.


\
\ @brief CEC Tx data register
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$000000ff constant CEC_CEC_TXDR_TXD                                 \ Tx data TXD is a write-only register containing the data byte to be transmitted.


\
\ @brief CEC Rx data register
\ Address offset: 0x0C
\ Reset value: 0x00000000
\

$000000ff constant CEC_CEC_RXDR_RXD                                 \ Rx data RXD is read-only and contains the last data byte that has been received from the CEC line.


\
\ @brief CEC interrupt and status register
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$00000001 constant CEC_CEC_ISR_RXBR                                 \ Rx-byte received The RXBR bit is set by hardware to inform application that a new byte has been received from the CEC line and stored into the RXD buffer. RXBR is cleared by software write at 1.
$00000002 constant CEC_CEC_ISR_RXEND                                \ End of reception RXEND is set by hardware to inform application that the last byte of a CEC message is received from the CEC line and stored into the RXD buffer. RXEND is set at the same time of RXBR. RXEND is cleared by software write at 1.
$00000004 constant CEC_CEC_ISR_RXOVR                                \ Rx-overrun RXOVR is set by hardware if RXBR is not yet cleared at the time a new byte is received on the CEC line and stored into RXD. RXOVR assertion stops message reception so that no acknowledge is sent. In case of broadcast, a negative acknowledge is sent. RXOVR is cleared by software write at 1.
$00000008 constant CEC_CEC_ISR_BRE                                  \ Rx-bit rising error BRE is set by hardware in case a data-bit waveform is detected with bit rising error. BRE is set either at the time the misplaced rising edge occurs, or at the end of the maximum BRE tolerance allowed by RXTOL, in case rising edge is still longing. BRE stops message reception if BRESTP = 1. BRE generates an error-bit on the CEC line if BREGEN = 1. BRE is cleared by software write at 1.
$00000010 constant CEC_CEC_ISR_SBPE                                 \ Rx-short bit period error SBPE is set by hardware in case a data-bit waveform is detected with short bit period error. SBPE is set at the time the anticipated falling edge occurs. SBPE generates an error-bit on the CEC line. SBPE is cleared by software write at 1.
$00000020 constant CEC_CEC_ISR_LBPE                                 \ Rx-long bit period error LBPE is set by hardware in case a data-bit waveform is detected with long bit period error. LBPE is set at the end of the maximum bit-extension tolerance allowed by RXTOL, in case falling edge is still longing. LBPE always stops reception of the CEC message. LBPE generates an error-bit on the CEC line if LBPEGEN = 1. In case of broadcast, error-bit is generated even in case of LBPEGEN = 0. LBPE is cleared by software write at 1.
$00000040 constant CEC_CEC_ISR_RXACKE                               \ Rx-missing acknowledge In receive mode, RXACKE is set by hardware to inform application that no acknowledge was seen on the CEC line. RXACKE applies only for broadcast messages and in listen mode also for not directly addressed messages (destination address not enabled in OAR). RXACKE aborts message reception. RXACKE is cleared by software write at 1.
$00000080 constant CEC_CEC_ISR_ARBLST                               \ Arbitration lost ARBLST is set by hardware to inform application that CEC device is switching to reception due to arbitration lost event following the TXSOM command. ARBLST can be due either to a contending CEC device starting earlier or starting at the same time but with higher HEADER priority. After ARBLST assertion TXSOM bit keeps pending for next transmission attempt. ARBLST is cleared by software write at 1.
$00000100 constant CEC_CEC_ISR_TXBR                                 \ Tx-byte request TXBR is set by hardware to inform application that the next transmission data has to be written to TXDR. TXBR is set when the 4th bit of currently transmitted byte is sent. Application must write the next byte to TXDR within six nominal data-bit periods before transmission underrun error occurs (TXUDR). TXBR is cleared by software write at 1.
$00000200 constant CEC_CEC_ISR_TXEND                                \ End of transmission TXEND is set by hardware to inform application that the last byte of the CEC message has been successfully transmitted. TXEND clears the TXSOM and TXEOM control bits. TXEND is cleared by software write at 1.
$00000400 constant CEC_CEC_ISR_TXUDR                                \ Tx-buffer underrun In transmission mode, TXUDR is set by hardware if application was not in time to load TXDR before of next byte transmission. TXUDR aborts message transmission and clears TXSOM and TXEOM control bits. TXUDR is cleared by software write at 1
$00000800 constant CEC_CEC_ISR_TXERR                                \ Tx-error In transmission mode, TXERR is set by hardware if the CEC initiator detects low impedance on the CEC line while it is released. TXERR aborts message transmission and clears TXSOM and TXEOM controls. TXERR is cleared by software write at 1.
$00001000 constant CEC_CEC_ISR_TXACKE                               \ Tx-missing acknowledge error In transmission mode, TXACKE is set by hardware to inform application that no acknowledge was received. In case of broadcast transmission, TXACKE informs application that a negative acknowledge was received. TXACKE aborts message transmission and clears TXSOM and TXEOM controls. TXACKE is cleared by software write at 1.


\
\ @brief CEC interrupt enable register
\ Address offset: 0x14
\ Reset value: 0x00000000
\

$00000001 constant CEC_CEC_IER_RXBRIE                               \ Rx-byte received interrupt enable The RXBRIE bit is set and cleared by software.
$00000002 constant CEC_CEC_IER_RXENDIE                              \ End of reception interrupt enable The RXENDIE bit is set and cleared by software.
$00000004 constant CEC_CEC_IER_RXOVRIE                              \ Rx-buffer overrun interrupt enable The RXOVRIE bit is set and cleared by software.
$00000008 constant CEC_CEC_IER_BREIE                                \ Bit rising error interrupt enable The BREIE bit is set and cleared by software.
$00000010 constant CEC_CEC_IER_SBPEIE                               \ Short bit period error interrupt enable The SBPEIE bit is set and cleared by software.
$00000020 constant CEC_CEC_IER_LBPEIE                               \ Long bit period error interrupt enable The LBPEIE bit is set and cleared by software.
$00000040 constant CEC_CEC_IER_RXACKIE                              \ Rx-missing acknowledge error interrupt enable The RXACKIE bit is set and cleared by software.
$00000080 constant CEC_CEC_IER_ARBLSTIE                             \ Arbitration lost interrupt enable The ARBLSTIE bit is set and cleared by software.
$00000100 constant CEC_CEC_IER_TXBRIE                               \ Tx-byte request interrupt enable The TXBRIE bit is set and cleared by software.
$00000200 constant CEC_CEC_IER_TXENDIE                              \ Tx-end of message interrupt enable The TXENDIE bit is set and cleared by software.
$00000400 constant CEC_CEC_IER_TXUDRIE                              \ Tx-underrun interrupt enable The TXUDRIE bit is set and cleared by software.
$00000800 constant CEC_CEC_IER_TXERRIE                              \ Tx-error interrupt enable The TXERRIE bit is set and cleared by software.
$00001000 constant CEC_CEC_IER_TXACKIE                              \ Tx-missing acknowledge error interrupt enable The TXACKEIE bit is set and cleared by software.


\
\ @brief HDMI-CEC controller
\
$40006c00 constant CEC_CEC_CR     \ offset: 0x00 : CEC control register
$40006c04 constant CEC_CEC_CFGR   \ offset: 0x04 : CEC configuration register
$40006c08 constant CEC_CEC_TXDR   \ offset: 0x08 : CEC Tx data register
$40006c0c constant CEC_CEC_RXDR   \ offset: 0x0C : CEC Rx data register
$40006c10 constant CEC_CEC_ISR    \ offset: 0x10 : CEC interrupt and status register
$40006c14 constant CEC_CEC_IER    \ offset: 0x14 : CEC interrupt enable register

