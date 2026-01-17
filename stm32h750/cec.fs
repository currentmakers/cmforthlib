\
\ @file cec.fs
\ @brief CEC
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] CEC_DEF

  [ifdef] CEC_CEC_CR_DEF
    \
    \ @brief CEC control register
    \ Address offset: 0x00
    \ Reset value: 0x00000000
    \
    $00 constant CEC_CECEN                      \ [0x00] CEC Enable The CECEN bit is set and cleared by software. CECEN=1 starts message reception and enables the TXSOM control. CECEN=0 disables the CEC peripheral, clears all bits of CEC_CR register and aborts any on-going reception or transmission.
    $01 constant CEC_TXSOM                      \ [0x01] Tx Start Of Message TXSOM is set by software to command transmission of the first byte of a CEC message. If the CEC message consists of only one byte, TXEOM must be set before of TXSOM. Start-Bit is effectively started on the CEC line after SFT is counted. If TXSOM is set while a message reception is ongoing, transmission will start after the end of reception. TXSOM is cleared by hardware after the last byte of the message is sent with a positive acknowledge (TXEND=1), in case of transmission underrun (TXUDR=1), negative acknowledge (TXACKE=1), and transmission error (TXERR=1). It is also cleared by CECEN=0. It is not cleared and transmission is automatically retried in case of arbitration lost (ARBLST=1). TXSOM can be also used as a status bit informing application whether any transmission request is pending or under execution. The application can abort a transmission request at any time by clearing the CECEN bit. Note: TXSOM must be set when CECEN=1 TXSOM must be set when transmission data is available into TXDR HEADERs first four bits containing own peripheral address are taken from TXDR[7:4], not from CEC_CFGR.OAR which is used only for reception
    $02 constant CEC_TXEOM                      \ [0x02] Tx End Of Message The TXEOM bit is set by software to command transmission of the last byte of a CEC message. TXEOM is cleared by hardware at the same time and under the same conditions as for TXSOM. Note: TXEOM must be set when CECEN=1 TXEOM must be set before writing transmission data to TXDR If TXEOM is set when TXSOM=0, transmitted message will consist of 1 byte (HEADER) only (PING message)
  [then]


  [ifdef] CEC_CEC_CFGR_DEF
    \
    \ @brief This register is used to configure the HDMI-CEC controller. It is mandatory to write CEC_CFGR only when CECEN=0.
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $00 constant CEC_SFT                        \ [0x00 : 3] Signal Free Time SFT bits are set by software. In the SFT=0x0 configuration the number of nominal data bit periods waited before transmission is ruled by hardware according to the transmission history. In all the other configurations the SFT number is determined by software. * 0x0 ** 2.5 Data-Bit periods if CEC is the last bus initiator with unsuccessful transmission (ARBLST=1, TXERR=1, TXUDR=1 or TXACKE= 1) ** 4 Data-Bit periods if CEC is the new bus initiator ** 6 Data-Bit periods if CEC is the last bus initiator with successful transmission (TXEOM=1) * 0x1: 0.5 nominal data bit periods * 0x2: 1.5 nominal data bit periods * 0x3: 2.5 nominal data bit periods * 0x4: 3.5 nominal data bit periods * 0x5: 4.5 nominal data bit periods * 0x6: 5.5 nominal data bit periods * 0x7: 6.5 nominal data bit periods
    $03 constant CEC_RXTOL                      \ [0x03] Rx-Tolerance The RXTOL bit is set and cleared by software. ** Start-Bit, +/- 200 s rise, +/- 200 s fall. ** Data-Bit: +/- 200 s rise. +/- 350 s fall. ** Start-Bit: +/- 400 s rise, +/- 400 s fall ** Data-Bit: +/-300 s rise, +/- 500 s fall
    $04 constant CEC_BRESTP                     \ [0x04] Rx-Stop on Bit Rising Error The BRESTP bit is set and cleared by software.
    $05 constant CEC_BREGEN                     \ [0x05] Generate Error-Bit on Bit Rising Error The BREGEN bit is set and cleared by software. Note: If BRDNOGEN=0, an Error-bit is generated upon BRE detection with BRESTP=1 in broadcast even if BREGEN=0
    $06 constant CEC_LBPEGEN                    \ [0x06] Generate Error-Bit on Long Bit Period Error The LBPEGEN bit is set and cleared by software. Note: If BRDNOGEN=0, an Error-bit is generated upon LBPE detection in broadcast even if LBPEGEN=0
    $07 constant CEC_BRDNOGEN                   \ [0x07] Avoid Error-Bit Generation in Broadcast The BRDNOGEN bit is set and cleared by software.
    $08 constant CEC_SFTOPT                     \ [0x08] SFT Option Bit The SFTOPT bit is set and cleared by software.
    $10 constant CEC_OAR                        \ [0x10 : 15] Own addresses configuration The OAR bits are set by software to select which destination logical addresses has to be considered in receive mode. Each bit, when set, enables the CEC logical address identified by the given bit position. At the end of HEADER reception, the received destination address is compared with the enabled addresses. In case of matching address, the incoming message is acknowledged and received. In case of non-matching address, the incoming message is received only in listen mode (LSTN=1), but without acknowledge sent. Broadcast messages are always received. Example: OAR = 0b000 0000 0010 0001 means that CEC acknowledges addresses 0x0 and 0x5. Consequently, each message directed to one of these addresses is received.
    $1f constant CEC_LSTN                       \ [0x1f] Listen mode LSTN bit is set and cleared by software.
  [then]


  [ifdef] CEC_CEC_TXDR_DEF
    \
    \ @brief CEC Tx data register
    \ Address offset: 0x08
    \ Reset value: 0x00000000
    \
    $00 constant CEC_TXD                        \ [0x00 : 8] Tx Data register. TXD is a write-only register containing the data byte to be transmitted. Note: TXD must be written when TXSTART=1
  [then]


  [ifdef] CEC_CEC_RXDR_DEF
    \
    \ @brief CEC Rx Data Register
    \ Address offset: 0x0C
    \ Reset value: 0x00000000
    \
    $00 constant CEC_RXD                        \ [0x00 : 8] Rx Data register. RXD is read-only and contains the last data byte which has been received from the CEC line.
  [then]


  [ifdef] CEC_CEC_ISR_DEF
    \
    \ @brief CEC Interrupt and Status Register
    \ Address offset: 0x10
    \ Reset value: 0x00000000
    \
    $00 constant CEC_RXBR                       \ [0x00] Rx-Byte Received The RXBR bit is set by hardware to inform application that a new byte has been received from the CEC line and stored into the RXD buffer. RXBR is cleared by software write at 1.
    $01 constant CEC_RXEND                      \ [0x01] End Of Reception RXEND is set by hardware to inform application that the last byte of a CEC message is received from the CEC line and stored into the RXD buffer. RXEND is set at the same time of RXBR. RXEND is cleared by software write at 1.
    $02 constant CEC_RXOVR                      \ [0x02] Rx-Overrun RXOVR is set by hardware if RXBR is not yet cleared at the time a new byte is received on the CEC line and stored into RXD. RXOVR assertion stops message reception so that no acknowledge is sent. In case of broadcast, a negative acknowledge is sent. RXOVR is cleared by software write at 1.
    $03 constant CEC_BRE                        \ [0x03] Rx-Bit Rising Error BRE is set by hardware in case a Data-Bit waveform is detected with Bit Rising Error. BRE is set either at the time the misplaced rising edge occurs, or at the end of the maximum BRE tolerance allowed by RXTOL, in case rising edge is still longing. BRE stops message reception if BRESTP=1. BRE generates an Error-Bit on the CEC line if BREGEN=1. BRE is cleared by software write at 1.
    $04 constant CEC_SBPE                       \ [0x04] Rx-Short Bit Period Error SBPE is set by hardware in case a Data-Bit waveform is detected with Short Bit Period Error. SBPE is set at the time the anticipated falling edge occurs. SBPE generates an Error-Bit on the CEC line. SBPE is cleared by software write at 1.
    $05 constant CEC_LBPE                       \ [0x05] Rx-Long Bit Period Error LBPE is set by hardware in case a Data-Bit waveform is detected with Long Bit Period Error. LBPE is set at the end of the maximum bit-extension tolerance allowed by RXTOL, in case falling edge is still longing. LBPE always stops reception of the CEC message. LBPE generates an Error-Bit on the CEC line if LBPEGEN=1. In case of broadcast, Error-Bit is generated even in case of LBPEGEN=0. LBPE is cleared by software write at 1.
    $06 constant CEC_RXACKE                     \ [0x06] Rx-Missing Acknowledge In receive mode, RXACKE is set by hardware to inform application that no acknowledge was seen on the CEC line. RXACKE applies only for broadcast messages and in listen mode also for not directly addressed messages (destination address not enabled in OAR). RXACKE aborts message reception. RXACKE is cleared by software write at 1.
    $07 constant CEC_ARBLST                     \ [0x07] Arbitration Lost ARBLST is set by hardware to inform application that CEC device is switching to reception due to arbitration lost event following the TXSOM command. ARBLST can be due either to a contending CEC device starting earlier or starting at the same time but with higher HEADER priority. After ARBLST assertion TXSOM bit keeps pending for next transmission attempt. ARBLST is cleared by software write at 1.
    $08 constant CEC_TXBR                       \ [0x08] Tx-Byte Request TXBR is set by hardware to inform application that the next transmission data has to be written to TXDR. TXBR is set when the 4th bit of currently transmitted byte is sent. Application must write the next byte to TXDR within 6 nominal data-bit periods before transmission underrun error occurs (TXUDR). TXBR is cleared by software write at 1.
    $09 constant CEC_TXEND                      \ [0x09] End of Transmission TXEND is set by hardware to inform application that the last byte of the CEC message has been successfully transmitted. TXEND clears the TXSOM and TXEOM control bits. TXEND is cleared by software write at 1.
    $0a constant CEC_TXUDR                      \ [0x0a] Tx-Buffer Underrun In transmission mode, TXUDR is set by hardware if application was not in time to load TXDR before of next byte transmission. TXUDR aborts message transmission and clears TXSOM and TXEOM control bits. TXUDR is cleared by software write at 1
    $0b constant CEC_TXERR                      \ [0x0b] Tx-Error In transmission mode, TXERR is set by hardware if the CEC initiator detects low impedance on the CEC line while it is released. TXERR aborts message transmission and clears TXSOM and TXEOM controls. TXERR is cleared by software write at 1.
    $0c constant CEC_TXACKE                     \ [0x0c] Tx-Missing Acknowledge Error In transmission mode, TXACKE is set by hardware to inform application that no acknowledge was received. In case of broadcast transmission, TXACKE informs application that a negative acknowledge was received. TXACKE aborts message transmission and clears TXSOM and TXEOM controls. TXACKE is cleared by software write at 1.
  [then]


  [ifdef] CEC_CEC_IER_DEF
    \
    \ @brief CEC interrupt enable register
    \ Address offset: 0x14
    \ Reset value: 0x00000000
    \
    $00 constant CEC_RXBRIE                     \ [0x00] Rx-Byte Received Interrupt Enable The RXBRIE bit is set and cleared by software.
    $01 constant CEC_RXENDIE                    \ [0x01] End Of Reception Interrupt Enable The RXENDIE bit is set and cleared by software.
    $02 constant CEC_RXOVRIE                    \ [0x02] Rx-Buffer Overrun Interrupt Enable The RXOVRIE bit is set and cleared by software.
    $03 constant CEC_BREIE                      \ [0x03] Bit Rising Error Interrupt Enable The BREIE bit is set and cleared by software.
    $04 constant CEC_SBPEIE                     \ [0x04] Short Bit Period Error Interrupt Enable The SBPEIE bit is set and cleared by software.
    $05 constant CEC_LBPEIE                     \ [0x05] Long Bit Period Error Interrupt Enable The LBPEIE bit is set and cleared by software.
    $06 constant CEC_RXACKIE                    \ [0x06] Rx-Missing Acknowledge Error Interrupt Enable The RXACKIE bit is set and cleared by software.
    $07 constant CEC_ARBLSTIE                   \ [0x07] Arbitration Lost Interrupt Enable The ARBLSTIE bit is set and cleared by software.
    $08 constant CEC_TXBRIE                     \ [0x08] Tx-Byte Request Interrupt Enable The TXBRIE bit is set and cleared by software.
    $09 constant CEC_TXENDIE                    \ [0x09] Tx-End Of Message Interrupt Enable The TXENDIE bit is set and cleared by software.
    $0a constant CEC_TXUDRIE                    \ [0x0a] Tx-Underrun Interrupt Enable The TXUDRIE bit is set and cleared by software.
    $0b constant CEC_TXERRIE                    \ [0x0b] Tx-Error Interrupt Enable The TXERRIE bit is set and cleared by software.
    $0c constant CEC_TXACKIE                    \ [0x0c] Tx-Missing Acknowledge Error Interrupt Enable The TXACKEIE bit is set and cleared by software.
  [then]

  \
  \ @brief CEC
  \
  $00 constant CEC_CEC_CR               \ CEC control register
  $04 constant CEC_CEC_CFGR             \ This register is used to configure the HDMI-CEC controller. It is mandatory to write CEC_CFGR only when CECEN=0.
  $08 constant CEC_CEC_TXDR             \ CEC Tx data register
  $0C constant CEC_CEC_RXDR             \ CEC Rx Data Register
  $10 constant CEC_CEC_ISR              \ CEC Interrupt and Status Register
  $14 constant CEC_CEC_IER              \ CEC interrupt enable register

: CEC_DEF ; [then]
