\
\ @file i3c.fs
\ @brief Improved inter-integrated circuit
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] I3C_DEF

  [ifdef] I3C_I3C_CR_DEF
    \
    \ @brief I3C message control register
    \ Address offset: 0x00
    \ Reset value: 0x00000000
    \
    $00 constant I3C_DCNT                       \ [0x00 : 16] count of data to transfer during a read or write message, in bytes (whatever I3C is acting as controller/target) Linear encoding up to 64 Kbytes -1 ...
    $10 constant I3C_RNW                        \ [0x10] read / non-write message (when I3C is acting as controller) When I3C is acting as controller, this field is used if MTYPE[3:0]=0010 (private message) or MTYPE[3:0]=0011 (direct message) or MTYPE[3:0]=0100 (legacy I2C message), in order to emit the RnW bit on the I3C bus.
    $11 constant I3C_ADD                        \ [0x11 : 7] 7-bit I3C dynamic / I2C static target address (when I3C is acting as controller) When I3C is acting as controller, this field is used if MTYPE[3:0]=0010 (private message) or MTYPE[3:0]=0011 (direct message) or MTYPE[3:0]=0100 (legacy I2C message)
    $1b constant I3C_MTYPE                      \ [0x1b : 4] message type (whatever I3C is acting as controller/target) Bits[26:0] are ignored. After M2 error detection on an I3C SDR message, this is needed for SCL 'stuck at' recovery. Bits[26:0] are ignored. If I3C_CFGR.EXITPTRN=1, an HDR exit pattern is emitted on the bus to generate an escalation fault. Bits[23:17] (ADD[6:0]) is the emitted 7-bit dynamic address. Bit[16] (RNW) is the emitted RnW bit. The transferred private message is: {S / S+7'h7E+RnW=0+Sr / Sr+*} + 7-bit DynAddr + RnW + (8-bit Data + T)* + Sr/P. After a S (START), depending on I3C_CFGR.NOARBH, the arbitrable header (7'h7E+RnW=0) is inserted or not. Sr+*: after a Sr (Repeated Start), the hardware automatically inserts (7'h7E+RnW=0) if needed, i.e. if it follows an I3C direct message without ending by a P (Stop). Bits[23:17] (ADD[6:0]) is the emitted 7-bit dynamic address. Bit[16] (RNW) is the emitted RnW bit. The transferred direct message is: Sr + 7-bit DynAddr + RnW + (8-bit Data + T)* + Sr/P Bits[23:17] (ADD[6:0]) is the emitted 7-bit static address. Bit[16] (RNW) is the emitted RnW bit. The transferred legacy I2C message is: {S / S+ 7'h7E+RnW=0 + Sr / Sr+*} + 7-bit StaAddr + RnW + (8-bit Data + T)* + Sr/P. After a S (START), depending on I3C_CFGR.NOARBH, the arbitrable header (7'h7E+RnW=0) is inserted or not. Sr+*: after a Sr (Repeated Start), the hardware automatically inserts (7'h7E+RnW=0) if needed, i.e. if it follows an I3C direct message without ending by a P (Stop). 1xxx: reserved (when I3C is acting as I3C controller, used when target) 0xxx: reserved {S +} 7'h02 addr + RnW=0 {S +} 7-bit I3C_DEVR0.DA[6:0] + RnW=0 after a bus available condition (the target first emits a START request), or once the controller drives a START. {S +} 7-bit I3C_DEVR0.DA[6:0] + RnW=1 (+Ack/Nack from controller) When acknowledged from controller, the next (optional, depending on I3C_BCR.BCR2) transmitted IBI payload data is defined by I3C_CR.DCNT[15:0] and must be consistently programmed vs the maximum IBI payload data size which is defined by I3C_IBIDR.IBIP[2:0]. Others: reserved
    $1f constant I3C_MEND                       \ [0x1f] message end type (when the I3C is acting as controller)
  [then]


  [ifdef] I3C_I3C_CR_ALTERNATE_DEF
    \
    \ @brief I3C message control register alternate
    \ Address offset: 0x00
    \ Reset value: 0x00000000
    \
    $00 constant I3C_DCNT                       \ [0x00 : 16] count of data to transfer during a read or write message, in bytes (when I3C is acting as controller) Linear encoding up to 64 Kbytes -1. ...
    $10 constant I3C_CCC                        \ [0x10 : 8] 8-bit CCC code (when I3C is acting as controller) If Bit[23]=CCC[7]=1, this is the 1st part of an I3C SDR direct CCC command. If Bit[23]=CCC[7]=0, this is an I3C SDR broadcast CCC command (including ENTDAA and ENTHDR0).
    $1b constant I3C_MTYPE                      \ [0x1b : 4] message type (when I3C is acting as controller) Bits[23:16] (CCC[7:0]) is the emitted 8-bit CCC code If Bit[23]=CCC[7]=1: this is the 1st part of an I3C SDR direct CCC command The transferred direct CCC command message is: {S / S+7'h7E +RnW=0 / Sr+*} + (direct CCC + T) + (8-bit Data + T)* + Sr After a S (START), depending on I3C_CFGR.NOARBH, the arbitrable header (7'h7E+RnW=0) is inserted or not. Sr+*: after a Sr (Repeated Start), the hardware automatically inserts (7'h7E+R/W). If Bit[23]=CCC[7]=0: this is an I3C SDR broadcast CCC command (including ENTDAA and ENTHDR0) The transferred broadcast CCC command message is: {S / S+7'h7E +RnW=0 / Sr+*} + (broadcast CCC + T) + (8-bit Data + T)* + Sr/P After a S (START), depending on I3C_CFGR.NOARBH, the arbitrable header (7'h7E+RnW=0) is inserted or not. Sr+*: after a Sr (Repeated Start), the hardware automatically inserts (7'h7E+R/W). others: reserved
    $1f constant I3C_MEND                       \ [0x1f] message end type (when I3C is acting as controller)
  [then]


  [ifdef] I3C_I3C_CFGR_DEF
    \
    \ @brief I3C configuration register
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $00 constant I3C_EN                         \ [0x00] I3C enable (whatever I3C is acting as controller/target) - Except registers, the peripheral is under reset (a.k.a. partial reset). - Before clearing EN, when I3C is acting as a controller, all the possible target requests must be disabled using DISEC CCC. - When I3C is acting as a target, software should not disable the I3C, unless a partial reset is needed. In this state, some register fields can not be modified (like CRINIT, HKSDAEN for the I3C_CFGR)
    $01 constant I3C_CRINIT                     \ [0x01] initial controller/target role This bit can be modified only when I3C_CFGR.EN = 0. Once enabled by setting I3C_CFGR.EN = 1, I3C peripheral initially acts as an I3C target. I3C does not drive SCL line and does not enable SDA pull-up, until it eventually acquires the controller role. Once enabled by setting I3C_CFGR.EN = 1, I3C peripheral initially acts as a controller. It has the I3C controller role, so drives SCL line and enables SDA pull-up, until it eventually offers the controller role to an I3C secondary controller.
    $02 constant I3C_NOARBH                     \ [0x02] no arbitrable header after a START (when I3C is acting as a controller) This bit can be modified only when there is no on-going frame. - The target address is emitted directly after a START in case of a legacy I2C message or an I3C SDR private read/write message. - This is a more performing option (when is useless the emission of the 0x7E arbitrable header), but this is to be used only when the controller is sure that the addressed target device can not emit concurrently an IBI or a controller-role request (to insure no misinterpretation and no potential conflict between the address emitted by the controller in open-drain mode and the same address a target device can emit after a START, for IBI or MR).
    $03 constant I3C_RSTPTRN                    \ [0x03] HDR reset pattern enable (when I3C is acting as a controller) This bit can be modified only when there is no on-going frame.
    $04 constant I3C_EXITPTRN                   \ [0x04] HDR Exit Pattern enable (when I3C is acting as a controller) This bit can be modified only when there is no on-going frame. This is used to send only the header to test ownership of the bus when there is a suspicion of problem after controller-role hand-off (new controller didn't assert its controller-role by accessing the previous one in less than Activity State time). The HDR Exit Pattern is sent even if the message header {S/Sr + 0x7E addr + W } is ACKed.
    $05 constant I3C_HKSDAEN                    \ [0x05] High-keeper enable on SDA line (when I3C is acting as a controller) This bit can be modified only when I3C_CFGR.EN=0.
    $07 constant I3C_HJACK                      \ [0x07] Hot Join request acknowledge (when I3C is acting as a controller) After the NACK, the message continues as initially programmed (the hot-joining target is aware of the NACK and surely emits another hot-join request later on). After the ACK, the message continues as initially programmed. The software is aware by the HJ interrupt (flag I3C_EVR.HJF is set) and initiates the ENTDAA sequence later on, potentially preventing others Hot Join requests with a Disable target events command (DISEC, with DISHJ=1). Independently of the HJACK configuration, further Hot Join request(s) are NACKed until the Hot Join flag, HJF, is cleared. However, a NACKed target can be assigned a dynamic address by the ENTDAA sequence initiated later on by the first HJ request, preventing this target to emit an HJ request again.
    $08 constant I3C_RXDMAEN                    \ [0x08] RX-FIFO DMA request enable (whatever I3C is acting as controller/target) - Software reads and pops a data byte/word from RX-FIFO i.e. reads I3C_RDR or I3C_RDWR register. - A next data byte/word is to be read by the software either via polling on the flag I3C_EVR.RXFNEF=1 or via interrupt notification (enabled by I3C_IER.RXFNEIE=1). - DMA reads and pops data byte(s)/word(s) from RX-FIFO i.e. reads I3C_RDR or I3C_RDWR register. - A next data byte/word is automatically read by the programmed hardware (i.e. via the asserted RX-FIFO DMA request from the I3C and the programmed DMA channel).
    $09 constant I3C_RXFLUSH                    \ [0x09] RX-FIFO flush (whatever I3C is acting as controller/target) This bit can only be written.
    $0a constant I3C_RXTHRES                    \ [0x0a] RX-FIFO threshold (whatever I3C is acting as controller/target) This threshold defines, compared to the RX-FIFO level, when the I3C_EVR.RXFNEF flag is set (and consequently if RXDMAEN=1 when is asserted a DMA RX request). RXFNEF is set when 1 byte is to be read in RX-FIFO (i.e. in I3C_RDR). RXFNEF is set when 4 bytes are to be read in RX-FIFO (i.e. in I3C_RDWR).
    $0c constant I3C_TXDMAEN                    \ [0x0c] TX-FIFO DMA request enable (whatever I3C is acting as controller/target) - Software writes and pushes a data byte/word into TX-FIFO i.e. writes I3C_TDR or I3C_TDWR register, to be transmitted over the I3C bus. - A next data byte/word is to be written by the software either via polling on the flag I3C_EVR.TXFNFF=1 or via interrupt notification (enabled by I3C_IER.TXFNFIE=1). - DMA writes and pushes data byte(s)/word(s) into TX-FIFO i.e. writes I3C_TDR or I3C_TDWR register. - A next data byte/word transfer is automatically pushed by the programmed hardware (i.e. via the asserted TX-FIFO DMA request from the I3C and the programmed DMA channel).
    $0d constant I3C_TXFLUSH                    \ [0x0d] TX-FIFO flush (whatever I3C is acting as controller/target) This bit can only be written. When the I3C is acting as target, this bit can be used to flush the TX-FIFO on a private read if the controller has early ended the read data (i.e. driven low the T bit) and there is/are remaining data in the TX-FIFO (i.e. I3C_SR.ABT=1 and I3C_SR.XDCNT[15:0] I3C_TGTTDR.TGTTDCNT[15:0]).
    $0e constant I3C_TXTHRES                    \ [0x0e] TX-FIFO threshold (whatever I3C is acting as controller/target) This threshold defines, compared to the TX-FIFO level, when the I3C_EVR.TXFNFF flag is set (and consequently if TXDMAEN=1 when is asserted a DMA TX request). TXFNFF is set when 1 byte is to be written in TX-FIFO (i.e. in I3C_TDR). TXFNFF is set when 4 bytes are to be written in TX-FIFO (i.e. in I3C_TDWR).
    $10 constant I3C_SDMAEN                     \ [0x10] S-FIFO DMA request enable (when I3C is acting as controller) Condition: When RMODE=1 (FIFO is enabled for the status): - Software reads and pops a status word from S-FIFO i.e. reads I3C_SR register after a completed frame (I3C_EVR.FCF=1) or an error (I3C_EVR.ERRF=1). - A status word can be read by the software either via polling on these register flags or via interrupt notification (enabled by I3C_IER.FCIE=1 and I3C_IER.ERRIE=1). - DMA reads and pops status word(s) from S-FIFO i.e. reads I3C_SR register. - Status word(s) are automatically read by the programmed hardware (i.e. via the asserted S-FIFO DMA request from the I3C and the programmed DMA channel).
    $11 constant I3C_SFLUSH                     \ [0x11] S-FIFO flush (when I3C is acting as controller) When I3C is acting as I3C controller, this bit can only be written (and is only used when I3C is acting as controller).
    $12 constant I3C_RMODE                      \ [0x12] S-FIFO enable / status receive mode (when I3C is acting as controller) When I3C is acting as I3C controller, this bit is used for the enabling the FIFO for the status (S-FIFO) vs the received status from the target on the I3C bus. When I3C is acting as target, this bit must be cleared. - Status register (i.e. I3C_SR) is used without FIFO mechanism. - There is no SCL stretch if a new status register content is not read. - Status register must be read before being lost/overwritten. All message status must be read. There is SCL stretch when there is no more space in the S-FIFO.
    $13 constant I3C_TMODE                      \ [0x13] transmit mode (when I3C is acting as controller) When I3C is acting as I3C controller, this bit is used for the C-FIFO and TX-FIFO management vs the emitted frame on the I3C bus. A frame transfer starts as soon as first control word is present in C-FIFO.
    $14 constant I3C_CDMAEN                     \ [0x14] C-FIFO DMA request enable (when I3C is acting as controller) When I3C is acting as controller: - Software writes and pushes control word(s) into C-FIFO i.e. writes I3C_CR register, as needed for a given frame. - A next control word transfer can be written by software either via polling on the flag I3C_EVR.CFNFF=1 or via interrupt notification (enabled by I3C_IER.CFNFIE=1). - DMA writes and pushes control word(s) into C-FIFO i.e. writes I3C_CR register, as needed for a given frame. - A next control word transfer is automatically written by the programmed hardware (i.e. via the asserted C-FIFO DMA request from the I3C and the programmed DMA channel).
    $15 constant I3C_CFLUSH                     \ [0x15] C-FIFO flush (when I3C is acting as controller) This bit can only be written.
    $1e constant I3C_TSFSET                     \ [0x1e] frame transfer set (a.k.a. software trigger) (when I3C is acting as controller) This bit can only be written. When I3C is acting as I3C controller: Note: If this bit is not set, the other alternative for the software to initiate a frame transfer is to directly write the first control word register (i.e. I3C_CR) while C-FIFO is empty (i.e. I3C_EVR.CFEF=1). Then, if the first written control word is not tagged as a message end (i.e I3C_CR.MEND=0), it causes the hardware to assert the flag I3C_EVR.CFNFF (C-FIFO not full and a next control word is needed).
  [then]


  [ifdef] I3C_I3C_RDR_DEF
    \
    \ @brief I3C receive data byte register
    \ Address offset: 0x10
    \ Reset value: 0x00000000
    \
    $00 constant I3C_RDB0                       \ [0x00 : 8] 8-bit received data on I3C bus.
  [then]


  [ifdef] I3C_I3C_RDWR_DEF
    \
    \ @brief I3C receive data word register
    \ Address offset: 0x14
    \ Reset value: 0x00000000
    \
    $00 constant I3C_RDB0                       \ [0x00 : 8] 8-bit received data (earliest byte on I3C bus).
    $08 constant I3C_RDB1                       \ [0x08 : 8] 8-bit received data (next byte after RDB0 on I3C bus).
    $10 constant I3C_RDB2                       \ [0x10 : 8] 8-bit received data (next byte after RDB1 on I3C bus).
    $18 constant I3C_RDB3                       \ [0x18 : 8] 8-bit received data (latest byte on I3C bus).
  [then]


  [ifdef] I3C_I3C_TDR_DEF
    \
    \ @brief I3C transmit data byte register
    \ Address offset: 0x18
    \ Reset value: 0x00000000
    \
    $00 constant I3C_TDB0                       \ [0x00 : 8] 8-bit data to transmit on I3C bus.
  [then]


  [ifdef] I3C_I3C_TDWR_DEF
    \
    \ @brief I3C transmit data word register
    \ Address offset: 0x1C
    \ Reset value: 0x00000000
    \
    $00 constant I3C_TDB0                       \ [0x00 : 8] 8-bit transmit data (earliest byte on I3C bus)
    $08 constant I3C_TDB1                       \ [0x08 : 8] 8-bit transmit data (next byte after TDB0[7:0] on I3C bus).
    $10 constant I3C_TDB2                       \ [0x10 : 8] 8-bit transmit data (next byte after TDB1[7:0] on I3C bus).
    $18 constant I3C_TDB3                       \ [0x18 : 8] 8-bit transmit data (latest byte on I3C bus).
  [then]


  [ifdef] I3C_I3C_IBIDR_DEF
    \
    \ @brief I3C IBI payload data register
    \ Address offset: 0x20
    \ Reset value: 0x00000000
    \
    $00 constant I3C_IBIDB0                     \ [0x00 : 8] 8-bit IBI payload data (earliest byte on I3C bus, i.e. MDB[7:0] mandatory data byte).
    $08 constant I3C_IBIDB1                     \ [0x08 : 8] 8-bit IBI payload data (next byte on I3C bus after IBIDB0[7:0]).
    $10 constant I3C_IBIDB2                     \ [0x10 : 8] 8-bit IBI payload data (next byte on I3C bus after IBIDB1[7:0]).
    $18 constant I3C_IBIDB3                     \ [0x18 : 8] 8-bit IBI payload data (latest byte on I3C bus).
  [then]


  [ifdef] I3C_I3C_TGTTDR_DEF
    \
    \ @brief I3C target transmit configuration register
    \ Address offset: 0x24
    \ Reset value: 0x00000000
    \
    $00 constant I3C_TGTTDCNT                   \ [0x00 : 16] transmit data counter, in bytes (when I3C is configured as target) This field must be written by software in the same access when is asserted PRELOAD, in order to define the number of bytes to preload and to transmit. This field is updated by hardware and reports, when read, the remaining number of bytes to be loaded into the TX-FIFO.
    $10 constant I3C_PRELOAD                    \ [0x10] preload of the TX-FIFO (when I3C is configured as target) This bit must be written and asserted by software in the same access when is written and defined the number of bytes to preload into the TX-FIFO and to transmit. This bit is cleared by hardware when all the data bytes to transmit are loaded into the TX-FIFO.
  [then]


  [ifdef] I3C_I3C_SR_DEF
    \
    \ @brief I3C status register
    \ Address offset: 0x30
    \ Reset value: 0x00000000
    \
    $00 constant I3C_XDCNT                      \ [0x00 : 16] data counter - When the I3C is acting as controller: number of targets detected on the bus - When the I3C is acting as target: number of transmitted bytes - Whatever the I3C is acting as controller or target: number of data bytes read from or transmitted on the I3C bus during the MID[7:0] message
    $11 constant I3C_ABT                        \ [0x11] a private read message is completed/aborted prematurely by the target (when the I3C is acting as controller) When the I3C is acting as controller, this bit indicates if the private read data which is transmitted by the target early terminates (i.e. the target drives T bit low earlier vs what does expect the controller in terms of programmed number of read data bytes i.e. I3C_CR.DCNT[15:0]).
    $12 constant I3C_DIR                        \ [0x12] message direction Whatever the I3C is acting as controller or target, this bit indicates the direction of the related message on the I3C bus Note: ENTDAA CCC is considered as a write command.
    $18 constant I3C_MID                        \ [0x18 : 8] message identifier/counter of a given frame (when the I3C is acting as controller) When the I3C is acting as controller, this field identifies the control word message (i.e. I3C_CR) to which the I3C_SR status register refers. First message of a frame is identified with MID[7:0]=0. This field is incremented (by hardware) on the completion of a new message control word (i.e. I3C_CR) over I3C bus. This field is reset for every new frame start.
  [then]


  [ifdef] I3C_I3C_SER_DEF
    \
    \ @brief I3C status error register
    \ Address offset: 0x34
    \ Reset value: 0x00000000
    \
    $00 constant I3C_CODERR                     \ [0x00 : 4] protocol error code/type controller detected an illegally formatted CCC controller detected that transmitted data on the bus is different from expected controller detected a not acknowledged broadcast address (7'hE) controller detected the new controller did not drive bus after controller-role hand-off target detected an invalid broadcast address 7'hE+W target detected a parity error on a CCC code via a parity check (vs T bit) target detected a parity error on a write data via a parity check (vs T bit) target detected a parity error on the assigned address during dynamic address arbitration via a parity check (vs PAR bit) target detected a 7'hE+R missing after Sr during dynamic address arbitration target detected an illegally formatted CCC target detected that transmitted data on the bus is different from expected others: reserved
    $04 constant I3C_PERR                       \ [0x04] protocol error
    $05 constant I3C_STALL                      \ [0x05] SCL stall error (when the I3C is acting as target)
    $06 constant I3C_DOVR                       \ [0x06] RX-FIFO overrun or TX-FIFO underrun i) a TX-FIFO underrun: TX-FIFO is empty and a write data byte has to be transmitted ii) a RX-FIFO overrun: RX-FIFO is full and a new data byte is received
    $07 constant I3C_COVR                       \ [0x07] C-FIFO underrun or S-FIFO overrun (when the I3C is acting as controller) i) a C-FIFO underrun: control FIFO is empty and a restart has to be emitted ii) a S-FIFO overrun: S-FIFO is full and a new message ends
    $08 constant I3C_ANACK                      \ [0x08] address not acknowledged (when the I3C is configured as controller) i) a legacy I2C read/write transfer ii) a direct CCC write transfer iii) the second trial of a direct CCC read transfer iv) a private read/write transfer
    $09 constant I3C_DNACK                      \ [0x09] data not acknowledged (when the I3C is acting as controller) i) a legacy I2C write transfer ii) the second trial when sending dynamic address during ENTDAA procedure
    $0a constant I3C_DERR                       \ [0x0a] data error (when the I3C is acting as controller)
  [then]


  [ifdef] I3C_I3C_RMR_DEF
    \
    \ @brief I3C received message register
    \ Address offset: 0x40
    \ Reset value: 0x00000000
    \
    $00 constant I3C_IBIRDCNT                   \ [0x00 : 3] IBI received payload data count (when the I3C is configured as controller) When the I3C is configured as controller, this field logs the number of data bytes effectively received in the I3C_IBIDR register.
    $08 constant I3C_RCODE                      \ [0x08 : 8] received CCC code (when the I3C is configured as target) When the I3C is configured as target, this field logs the received CCC code.
    $11 constant I3C_RADD                       \ [0x11 : 7] received target address (when the I3C is configured as controller) When the I3C is configured as controller, this field logs the received dynamic address from the target during acknowledged IBI or controller-role request.
  [then]


  [ifdef] I3C_I3C_EVR_DEF
    \
    \ @brief I3C event register
    \ Address offset: 0x50
    \ Reset value: 0x00000003
    \
    $00 constant I3C_CFEF                       \ [0x00] C-FIFO empty flag (whatever the I3C is acting as controller/target) This flag is asserted by hardware to indicate that the C-FIFO is empty when controller, and that the I3C_CR register contains no control word (i.e. none IBI/CR/HJ request) when target. This flag is de-asserted by hardware to indicate that the C-FIFO is not empty when controller, and that the I3C_CR register contains one control word (i.e. a pending IBI/CR/HJ request) when target. Note: When the I3C is acting as controller, if the C-FIFO and TX-FIFO preload is configured (i.e. I3C_CFGR.TMODE=1), the software must wait for TXFEF=1 and CFEF=1 before starting a new frame transfer.
    $01 constant I3C_TXFEF                      \ [0x01] TX-FIFO empty flag (whatever the I3C is acting as controller/target) This flag is asserted by hardware to indicate that the TX-FIFO is empty. This flag is de-asserted by hardware to indicate that the TX-FIFO is not empty. Note: When the I3C is acting as controller, if the C-FIFO and TX-FIFO preload is configured (i.e. I3C_CFGR.TMODE=1), the software must wait for TXFEF=1 and CFEF=1 before starting a new frame transfer.
    $02 constant I3C_CFNFF                      \ [0x02] C-FIFO not full flag (when the I3C is acting as controller) When the I3C is acting as controller, this flag is asserted by hardware to indicate that a control word is to be written to the C-FIFO. This flag is de-asserted by hardware to indicate that a control word is not to be written to the C-FIFO. Note: The software must wait for CFNFF=1 (by polling or via the enabled interrupt) before writing to C-FIFO (i.e. writing to I3C_CR).
    $03 constant I3C_SFNEF                      \ [0x03] S-FIFO not empty flag (when the I3C is acting as controller) When the I3C is acting as controller, if the S-FIFO is enabled (i.e. I3C_CFGR.RMODE=1), this flag is asserted by hardware to indicate that a status word is to be read from the S-FIFO. This flag is de-asserted by hardware to indicate that a status word is not to be read from the S-FIFO.
    $04 constant I3C_TXFNFF                     \ [0x04] TX-FIFO not full flag (whatever the I3C is acting as controller/target) This flag is asserted by hardware to indicate that a data byte/word is to be written to the TX-FIFO. This flag is de-asserted by hardware to indicate that a data byte/word is not to be written to the TX-FIFO. Note: The software must wait for TXFNFF=1 (by polling or via the enabled interrupt) before writing to TX-FIFO (i.e. writing to I3C_TDR or I3C_TDWR depending on I3C_CFGR.TXTHRES). Note: When the I3C is acting as target, if the software intends to use the TXFNFF flag for writing into I3C_TDR/I3C_TDWR, it must have configured and set the TX-FIFO preload (i.e. write I3C_TGTTDR.PRELOAD).
    $05 constant I3C_RXFNEF                     \ [0x05] RX-FIFO not empty flag (whatever the I3C is acting as controller/target) This flag is asserted by hardware to indicate that a data byte is to be read from the RX-FIFO. This flag is de-asserted by hardware to indicate that a data byte is not to be read from the RX-FIFO. Note: The software must wait for RXFNEF=1 (by polling or via the enabled interrupt) before reading from RX-FIFO (i.e. writing to I3C_RDR or I3C_RDWR depending on I3C_CFGR.RXTHRES).
    $06 constant I3C_TXLASTF                    \ [0x06] last written data byte/word flag (whatever the I3C is acting as controller/target) This flag is asserted by hardware to indicate that the last data byte/word (depending on I3C_CFGR.TXTHRES) of a message is to be written to the TX-FIFO. This flag is de-asserted by hardware when the last data byte/word of a message is written.
    $07 constant I3C_RXLASTF                    \ [0x07] last read data byte/word flag (whatever the I3C is acting as controller/target) This flag is asserted by hardware to indicate that the last data byte/word (depending on I3C_CFGR.RXTHRES) of a message is to be read from the RX-FIFO. This flag is de-asserted by hardware when the last data byte/word of a message is read.
    $09 constant I3C_FCF                        \ [0x09] frame complete flag (whatever the I3C is acting as controller/target) When the I3C is acting as controller, this flag is asserted by hardware to indicate that a frame has been (normally) completed on the I3C bus, i.e when a stop is issued. When the I3C is acting as target, this flag is asserted by hardware to indicate that a message addressed to/by this target has been (normally) completed on the I3C bus, i.e when a next stop or repeated start is then issued by the controller. This flag is cleared when software writes 1 into corresponding I3C_CEVR.CFCF bit.
    $0a constant I3C_RXTGTENDF                  \ [0x0a] target-initiated read end flag (when the I3C is acting as controller) When the I3C is acting as controller, this flag is asserted by hardware to indicate that the target has prematurely ended a read transfer. Then, software should read I3C_SR to get more information on the prematurely read transfer. This flag is cleared when software writes 1 into corresponding I3C_CEVR.CRXTGTENDF bit.
    $0b constant I3C_ERRF                       \ [0x0b] flag (whatever the I3C is acting as controller/target) This flag is asserted by hardware to indicate that an error occurred.Then, software should read I3C_SER to get the error type. This flag is cleared when software writes 1 into corresponding I3C_CEVR.CERRF bit.
    $0f constant I3C_IBIF                       \ [0x0f] IBI flag (when the I3C is acting as controller) When the I3C is acting as controller, this flag is asserted by hardware to indicate that an IBI request has been received. This flag is cleared when software writes 1 into corresponding I3C_CEVR.CIBIF bit.
    $10 constant I3C_IBIENDF                    \ [0x10] IBI end flag (when the I3C is acting as target) When the I3C is acting as target, this flag is asserted by hardware to indicate that a IBI transfer has been received and completed (IBI acknowledged and IBI data bytes read by controller if any). This flag is cleared when software writes 1 into corresponding I3C_CEVR.CIBIENDF bit.
    $11 constant I3C_CRF                        \ [0x11] controller-role request flag (when the I3C is acting as controller) When the I3C is acting as controller, this flag is asserted by hardware to indicate that a controller-role request has been acknowledged and completed (by hardware). The software should then issue a GETACCCR CCC (get accept controller role) for the controller-role hand-off procedure. This flag is cleared when software writes 1 into corresponding I3C_CEVR.CCRF bit.
    $12 constant I3C_CRUPDF                     \ [0x12] controller-role update flag (when the I3C is acting as target) When the I3C is acting as target, this flag is asserted by hardware to indicate that it has now gained the controller role after the completed controller-role hand-off procedure. This flag is cleared when software writes 1 into corresponding I3C_CEVR.CCRUPDF bit.
    $13 constant I3C_HJF                        \ [0x13] hot-join flag (when the I3C is acting as controller) When the I3C is acting as controller, this flag is asserted by hardware to indicate that an hot join request has been received. This flag is cleared when software writes 1 into corresponding I3C_CEVR.CHJF bit.
    $15 constant I3C_WKPF                       \ [0x15] wakeup/missed start flag (when the I3C is acting as target) When the I3C is acting as target, this flag is asserted by hardware to indicate that a start has been detected (i.e. a SDA falling edge followed by a SCL falling edge) but on the next SCL falling edge, the I3C kernel clock is (still) gated. Thus an I3C bus transaction may have been lost by the target. The corresponding interrupt may be used to wakeup the device from a low power mode (Sleep or Stop mode). This flag is cleared when software writes 1 into corresponding I3C_CEVR.CWKPF bit.
    $16 constant I3C_GETF                       \ [0x16] get flag (when the I3C is acting as target) When the I3C is acting as target, this flag is asserted by hardware to indicate that any direct CCC of get type (GET*** CCC) has been received. This flag is cleared when software writes 1 into corresponding I3C_CEVR.CGETF bit.
    $17 constant I3C_STAF                       \ [0x17] get status flag (when the I3C is acting as target) When the I3C is acting as target, this flag is asserted by hardware to indicate that a direct GETSTATUS CCC (get status) has been received. This flag is cleared when software writes 1 into corresponding I3C_CEVR.CSTAF bit.
    $18 constant I3C_DAUPDF                     \ [0x18] dynamic address update flag (when the I3C is acting as target) When the I3C is acting as target, this flag is asserted by hardware to indicate that a dynamic address update has been received via any of the broadcast ENTDAA, RSTDAA and direct SETNEWDA CCC. Then, software should read I3C_DEVR0.DA[6:0] to get the maximum write length value. This flag is cleared when software writes 1 into corresponding I3C_CEVR.CDAUPDF bit.
    $19 constant I3C_MWLUPDF                    \ [0x19] maximum write length update flag (when the I3C is acting as target) When the I3C is acting as target, this flag is asserted by hardware to indicate that a direct SETMWL CCC (set max write length) has been received. Then, software should read I3C_MAXWLR.MWL[15:0] to get the maximum write length value. This flag is cleared when software writes 1 into corresponding I3C_CEVR.CMWLUPDF bit.
    $1a constant I3C_MRLUPDF                    \ [0x1a] maximum read length update flag (when the I3C is acting as target) When the I3C is acting as target, this flag is asserted by hardware to indicate that a direct SETMRL CCC (set max read length) has been received. Then, software should read I3C_MAXRLR.MRL[15:0] to get the maximum read length value. This flag is cleared when software writes 1 into corresponding I3C_CEVR.CMRLUPDF bit.
    $1b constant I3C_RSTF                       \ [0x1b] reset pattern flag (when the I3C is acting as target) When the I3C is acting as target, this flag is asserted by hardware to indicate that a reset pattern has been detected (i.e. 14 SDA transitions while SCL is low, followed by repeated start, then stop). Then, software should read I3C_DEVR0.RSTACT[1:0] and I3C_DEVR0.RSTVAL, to know what reset level is required. If RSTVAL=1: when the RSTF is asserted (and/or the corresponding interrupt if enabled), I3C_DEVR0.RSTACT[1:0] dictates the reset action to be performed by the software if any. If RSTVAL=0: when the RSTF is asserted (and/or the corresponding interrupt if enabled), the software should issue an I3C reset after a first detected reset pattern, and a system reset on the second one. The corresponding interrupt may be used to wakeup the device from a low power mode (Sleep or Stop mode). This flag is cleared when software writes 1 into corresponding I3C_CEVR.CRSTF bit.
    $1c constant I3C_ASUPDF                     \ [0x1c] activity state update flag (when the I3C is acting as target) When the I3C is acting as target, this flag is asserted by hardware to indicate that the direct or broadcast ENTASx CCC (with x=0...3) has been received. Then, software should read I3C_DEVR0.AS[1:0]. This flag is cleared when software writes 1 into corresponding I3C_CEVR.CASUPDF bit.
    $1d constant I3C_INTUPDF                    \ [0x1d] interrupt/controller-role/hot-join update flag (when the I3C is acting as target) When the I3C is acting as target, this flag is asserted by hardware to indicate that the direct or broadcast ENEC/DISEC CCC (enable/disable target events) has been received, where a target event is either an interrupt/IBI request, a controller-role request, or an hot-join request. Then, software should read respectively I3C_DEVR0.IBIEN, I3C_DEVR0.CREN or I3C_DEVR0.HJEN. This flag is cleared when software writes 1 into corresponding I3C_CEVR.CINTUPDF bit.
    $1e constant I3C_DEFF                       \ [0x1e] DEFTGTS flag (when the I3C is acting as target) When the I3C is acting as target (and is typically controller capable), this flag is asserted by hardware to indicate that the broadcast DEFTGTS CCC (define list of targets) has been received. Then, software may store the received data for when getting the controller role. This flag is cleared when software writes 1 into corresponding I3C_CEVR.CDEFF bit.
    $1f constant I3C_GRPF                       \ [0x1f] group addressing flag (when the I3C is acting as target) When the I3C is acting as target (and is typically controller capable), this flag is asserted by hardware to indicate that the broadcast DEFGRPA CCC (define list of group addresses) has been received. Then, software may store the received data for when getting the controller role. This flag is cleared when software writes 1 into corresponding I3C_CEVR.CGRPF bit.
  [then]


  [ifdef] I3C_I3C_IER_DEF
    \
    \ @brief I3C interrupt enable register
    \ Address offset: 0x54
    \ Reset value: 0x00000000
    \
    $02 constant I3C_CFNFIE                     \ [0x02] C-FIFO not full interrupt enable (whatever the I3C is acting as controller/target)
    $03 constant I3C_SFNEIE                     \ [0x03] S-FIFO not empty interrupt enable (whatever the I3C is acting as controller/target)
    $04 constant I3C_TXFNFIE                    \ [0x04] TX-FIFO not full interrupt enable (whatever the I3C is acting as controller/target)
    $05 constant I3C_RXFNEIE                    \ [0x05] RX-FIFO not empty interrupt enable (whatever the I3C is acting as controller/target)
    $09 constant I3C_FCIE                       \ [0x09] frame complete interrupt enable (whatever the I3C is acting as controller/target)
    $0a constant I3C_RXTGTENDIE                 \ [0x0a] target-initiated read end interrupt enable (when the I3C is acting as controller)
    $0b constant I3C_ERRIE                      \ [0x0b] error interrupt enable (whatever the I3C is acting as controller/target)
    $0f constant I3C_IBIIE                      \ [0x0f] IBI request interrupt enable (when the I3C is acting as controller)
    $10 constant I3C_IBIENDIE                   \ [0x10] IBI end interrupt enable (when the I3C is acting as target)
    $11 constant I3C_CRIE                       \ [0x11] controller-role request interrupt enable (when the I3C is acting as controller)
    $12 constant I3C_CRUPDIE                    \ [0x12] controller-role update interrupt enable (when the I3C is acting as target)
    $13 constant I3C_HJIE                       \ [0x13] hot-join interrupt enable (when the I3C is acting as controller)
    $15 constant I3C_WKPIE                      \ [0x15] wakeup interrupt enable (when the I3C is acting as target)
    $16 constant I3C_GETIE                      \ [0x16] GETxxx CCC interrupt enable (when the I3C is acting as target)
    $17 constant I3C_STAIE                      \ [0x17] GETSTATUS CCC interrupt enable (when the I3C is acting as target)
    $18 constant I3C_DAUPDIE                    \ [0x18] ENTDAA/RSTDAA/SETNEWDA CCC interrupt enable (when the I3C is acting as target)
    $19 constant I3C_MWLUPDIE                   \ [0x19] SETMWL CCC interrupt enable (when the I3C is acting as target)
    $1a constant I3C_MRLUPDIE                   \ [0x1a] SETMRL CCC interrupt enable (when the I3C is acting as target)
    $1b constant I3C_RSTIE                      \ [0x1b] reset pattern interrupt enable (when the I3C is acting as target)
    $1c constant I3C_ASUPDIE                    \ [0x1c] ENTASx CCC interrupt enable (when the I3C is acting as target)
    $1d constant I3C_INTUPDIE                   \ [0x1d] ENEC/DISEC CCC interrupt enable (when the I3C is acting as target)
    $1e constant I3C_DEFIE                      \ [0x1e] DEFTGTS CCC interrupt enable (when the I3C is acting as target)
    $1f constant I3C_GRPIE                      \ [0x1f] DEFGRPA CCC interrupt enable (when the I3C is acting as target)
  [then]


  [ifdef] I3C_I3C_CEVR_DEF
    \
    \ @brief I3C clear event register
    \ Address offset: 0x58
    \ Reset value: 0x00000000
    \
    $09 constant I3C_CFCF                       \ [0x09] clear frame complete flag (whatever the I3C is acting as controller/target)
    $0a constant I3C_CRXTGTENDF                 \ [0x0a] clear target-initiated read end flag (when the I3C is acting as controller)
    $0b constant I3C_CERRF                      \ [0x0b] clear error flag (whatever the I3C is acting as controller/target)
    $0f constant I3C_CIBIF                      \ [0x0f] clear IBI request flag (when the I3C is acting as controller)
    $10 constant I3C_CIBIENDF                   \ [0x10] clear IBI end flag (when the I3C is acting as target)
    $11 constant I3C_CCRF                       \ [0x11] clear controller-role request flag (when the I3C is acting as controller)
    $12 constant I3C_CCRUPDF                    \ [0x12] clear controller-role update flag (when the I3C is acting as target)
    $13 constant I3C_CHJF                       \ [0x13] clear hot-join flag (when the I3C is acting as controller)
    $15 constant I3C_CWKPF                      \ [0x15] clear wakeup flag (when the I3C is acting as target)
    $16 constant I3C_CGETF                      \ [0x16] clear GETxxx CCC flag (when the I3C is acting as target)
    $17 constant I3C_CSTAF                      \ [0x17] clear GETSTATUS CCC flag (when the I3C is acting as target)
    $18 constant I3C_CDAUPDF                    \ [0x18] clear ENTDAA/RSTDAA/SETNEWDA CCC flag (when the I3C is acting as target)
    $19 constant I3C_CMWLUPDF                   \ [0x19] clear SETMWL CCC flag (when the I3C is acting as target)
    $1a constant I3C_CMRLUPDF                   \ [0x1a] clear SETMRL CCC flag (when the I3C is acting as target)
    $1b constant I3C_CRSTF                      \ [0x1b] clear reset pattern flag (when the I3C is acting as target)
    $1c constant I3C_CASUPDF                    \ [0x1c] clear ENTASx CCC flag (when the I3C is acting as target)
    $1d constant I3C_CINTUPDF                   \ [0x1d] clear ENEC/DISEC CCC flag (when the I3C is acting as target)
    $1e constant I3C_CDEFF                      \ [0x1e] clear DEFTGTS CCC flag (when the I3C is acting as target)
    $1f constant I3C_CGRPF                      \ [0x1f] clear DEFGRPA CCC flag (when the I3C is acting as target)
  [then]


  [ifdef] I3C_I3C_DEVR0_DEF
    \
    \ @brief I3C own device characteristics register
    \ Address offset: 0x60
    \ Reset value: 0x00000000
    \
    $00 constant I3C_DAVAL                      \ [0x00] dynamic address is valid (when the I3C is acting as target) When the I3C is acting as controller, this field can be written by software, for validating its own dynamic address, for example before a controller-role hand-off. When the I3C is acting as target, this field is asserted by hardware on the acknowledge of the broadcast ENTDAA CCC or the direct SETNEWDA CCC, and this field is cleared by hardware on the acknowledge of the broadcast RSTDAA CCC.
    $01 constant I3C_DA                         \ [0x01 : 7] 7-bit dynamic address When the I3C is acting as controller, this field can be written by software, for defining its own dynamic address. When the I3C is acting as target, this field is updated by hardware on the reception of either the broadcast ENTDAA CCC or the direct SETNEWDA CCC.
    $10 constant I3C_IBIEN                      \ [0x10] IBI request enable (when the I3C is acting as target) This field is initially written by software when I3C_CFGR.EN=0, and is updated by hardware on the reception of DISEC CCC with DISINT=1 (i.e. cleared) and the reception of ENEC CCC with ENINT=1 (i.e. set).
    $11 constant I3C_CREN                       \ [0x11] controller-role request enable (when the I3C is acting as target) This field is initially written by software when I3C_CFGR.EN=0, and is updated by hardware on the reception of DISEC CCC with DISCR=1 (i.e. cleared) and the reception of ENEC CCC with ENCR=1 (i.e. set).
    $13 constant I3C_HJEN                       \ [0x13] hot-join request enable (when the I3C is acting as target) This field is initially written by software when I3C_CFGR.EN=0, and is updated by hardware on the reception of DISEC CCC with DISHJ=1 (i.e. cleared) and the reception of ENEC CCC with ENHJ=1 (i.e. set).
    $14 constant I3C_AS                         \ [0x14 : 2] activity state (when the I3C is acting as target) This read field is updated by hardware on the reception of a ENTASx CCC (enter activity state, with x=0-3):
    $16 constant I3C_RSTACT                     \ [0x16 : 2] reset action/level on received reset pattern (when the I3C is acting as target) This read field is used by hardware on the reception of a direct read RSTACT CCC in order to return the corresponding data byte on the I3C bus. This read field is updated by hardware on the reception of a broadcast or direct write RSTACT CCC (target reset action).
    $18 constant I3C_RSTVAL                     \ [0x18] reset action is valid (when the I3C is acting as target) This read bit is asserted by hardware to indicate that the RTSACT[1:0] field has been updated on the reception of a broadcast or direct write RSTACT CCC (target reset action) and is valid. This field is cleared by hardware when the target receives a frame start. If RSTVAL=1: when the RSTF is asserted (and/or the corresponding interrupt if enabled), I3C_DEVR0.RSTACT[1:0] dictates the reset action to be performed by the software if any. If RSTVAL=0: when the RSTF is asserted (and/or the corresponding interrupt if enabled), the software should issue an I3C reset after a first detected reset pattern, and a system reset on the second one.
  [then]


  [ifdef] I3C_I3C_DEVR1_DEF
    \
    \ @brief I3C device 1 characteristics register
    \ Address offset: 0x64
    \ Reset value: 0x00000000
    \
    $01 constant I3C_DA                         \ [0x01 : 7] assigned I3C dynamic address to target x (when the I3C is acting as controller) When the I3C is acting as controller, this field should be written by software to store the 7-bit dynamic address that the controller sends via a broadcast ENTDAA or a direct SETNEWDA CCC which has been acknowledged by the target x. Writing to this field has no impact when the read field I3C_DEVRx.DIS=1.
    $10 constant I3C_IBIACK                     \ [0x10] IBI request acknowledge (when the I3C is acting as controller) When the I3C is acting as controller, this bit is written by software to define the acknowledge policy to be applied on the I3C bus on the reception of a IBI request from target x: - After the NACK, the message continues as initially programmed (the target is aware of the NACK and can emit another IBI request later on) - The field DIS is asserted by hardware to protect DA[6:0] from being modified by software meanwhile the hardware can store internally the current DA[6:0] into the kernel clock domain. - After the ACK, the controller logs the IBI payload data, if any, depending on I3C_DEVRx.IBIDEN. - The software is notified by the IBI flag (i.e. I3C_EVR.IBIF=1) and/or the corresponding interrupt if enabled; - Independently from IBIACK configuration for this or other devices, further IBI request(s) are NACKed until IBI request flag (i.e. I3C_EVR.IBIF) and controller-role request flag (i.e. I3C_EVR.CRF) are both cleared.
    $11 constant I3C_CRACK                      \ [0x11] controller-role request acknowledge (when the I3C is acting as controller) When the I3C is acting as controller, this bit is written by software to define the acknowledge policy to be applied on the I3C bus on the reception of a controller-role request from target x: After the NACK, the message continues as initially programmed (the target is aware of the NACK and can emit another controller-role request later on) - The field DIS is asserted by hardware to protect DA[6:0] from being modified by software meanwhile the hardware can store internally the current DA[6:0] into the kernel clock domain. - After the ACK, the message continues as initially programmed. The software is notified by the controller-role request flag (i.e. I3C_EVR.CRF=1) and/or the corresponding interrupt if enabled; For effectively granting the controller-role to the requesting secondary controller, software should issue a GETACCCR (formerly known as GETACCMST), followed by a STOP. - Independently of CRACK configuration for this or other devices, further controller-role request(s) are NACKed until controller-role request flag (i.e. I3C_EVR.CRF) and IBI flag (i.e. I3C_EVR.IBIF) are both cleared.
    $12 constant I3C_IBIDEN                     \ [0x12] IBI data enable (when the I3C is acting as controller) When the I3C is acting as controller, this bit should be written by software to store the BCR[2] bit as received from the target x during broadcast ENTDAA or direct GETBCR CCC via the received I3C_RDR. Writing to this field has no impact when the read field I3C_DEVRx.DIS=1.
    $13 constant I3C_SUSP                       \ [0x13] suspend/stop I3C transfer on received IBI (when the I3C is acting as controller) When the I3C is acting as controller, this bit is used to receive an IBI from target x with pending read notification feature (i.e. with received MDB[7:5]=3'b101). If this bit is set, when an IBI is received (i.e. I3C_EVR.IBIF=1), a Stop is emitted on the I3C bus and the C-FIFO is automatically flushed by hardware; to avoid a next private read communication issue if a previous private read message to the target x was stored in the C-FIFO.
    $1f constant I3C_DIS                        \ [0x1f] DA[6:0] write disabled (when the I3C is acting as controller) When the I3C is acting as controller, once that software set IBIACK=1 or CRACK=1, this read bit is set by hardware (i.e. DIS=1) to lock the configured DA[6:0] and IBIDEN values. Then, to be able to next modify DA[6:0] or IBIDEN, the software must wait for this field DIS to be de-asserted by hardware (i.e. polling on DIS=0) before modifying these two assigned values to the target x. Indeed, the target may be requesting an IBI or a controller-role meanwhile the controller intends to modify DA[6:0] or IBIDEN.
  [then]


  [ifdef] I3C_I3C_DEVR2_DEF
    \
    \ @brief I3C device 2 characteristics register
    \ Address offset: 0x68
    \ Reset value: 0x00000000
    \
    $01 constant I3C_DA                         \ [0x01 : 7] assigned I3C dynamic address to target x (when the I3C is acting as controller) When the I3C is acting as controller, this field should be written by software to store the 7-bit dynamic address that the controller sends via a broadcast ENTDAA or a direct SETNEWDA CCC which has been acknowledged by the target x. Writing to this field has no impact when the read field I3C_DEVRx.DIS=1.
    $10 constant I3C_IBIACK                     \ [0x10] IBI request acknowledge (when the I3C is acting as controller) When the I3C is acting as controller, this bit is written by software to define the acknowledge policy to be applied on the I3C bus on the reception of a IBI request from target x: - After the NACK, the message continues as initially programmed (the target is aware of the NACK and can emit another IBI request later on) - The field DIS is asserted by hardware to protect DA[6:0] from being modified by software meanwhile the hardware can store internally the current DA[6:0] into the kernel clock domain. - After the ACK, the controller logs the IBI payload data, if any, depending on I3C_DEVRx.IBIDEN. - The software is notified by the IBI flag (i.e. I3C_EVR.IBIF=1) and/or the corresponding interrupt if enabled; - Independently from IBIACK configuration for this or other devices, further IBI request(s) are NACKed until IBI request flag (i.e. I3C_EVR.IBIF) and controller-role request flag (i.e. I3C_EVR.CRF) are both cleared.
    $11 constant I3C_CRACK                      \ [0x11] controller-role request acknowledge (when the I3C is acting as controller) When the I3C is acting as controller, this bit is written by software to define the acknowledge policy to be applied on the I3C bus on the reception of a controller-role request from target x: After the NACK, the message continues as initially programmed (the target is aware of the NACK and can emit another controller-role request later on) - The field DIS is asserted by hardware to protect DA[6:0] from being modified by software meanwhile the hardware can store internally the current DA[6:0] into the kernel clock domain. - After the ACK, the message continues as initially programmed. The software is notified by the controller-role request flag (i.e. I3C_EVR.CRF=1) and/or the corresponding interrupt if enabled; For effectively granting the controller-role to the requesting secondary controller, software should issue a GETACCCR (formerly known as GETACCMST), followed by a STOP. - Independently of CRACK configuration for this or other devices, further controller-role request(s) are NACKed until controller-role request flag (i.e. I3C_EVR.CRF) and IBI flag (i.e. I3C_EVR.IBIF) are both cleared.
    $12 constant I3C_IBIDEN                     \ [0x12] IBI data enable (when the I3C is acting as controller) When the I3C is acting as controller, this bit should be written by software to store the BCR[2] bit as received from the target x during broadcast ENTDAA or direct GETBCR CCC via the received I3C_RDR. Writing to this field has no impact when the read field I3C_DEVRx.DIS=1.
    $13 constant I3C_SUSP                       \ [0x13] suspend/stop I3C transfer on received IBI (when the I3C is acting as controller) When the I3C is acting as controller, this bit is used to receive an IBI from target x with pending read notification feature (i.e. with received MDB[7:5]=3'b101). If this bit is set, when an IBI is received (i.e. I3C_EVR.IBIF=1), a Stop is emitted on the I3C bus and the C-FIFO is automatically flushed by hardware; to avoid a next private read communication issue if a previous private read message to the target x was stored in the C-FIFO.
    $1f constant I3C_DIS                        \ [0x1f] DA[6:0] write disabled (when the I3C is acting as controller) When the I3C is acting as controller, once that software set IBIACK=1 or CRACK=1, this read bit is set by hardware (i.e. DIS=1) to lock the configured DA[6:0] and IBIDEN values. Then, to be able to next modify DA[6:0] or IBIDEN, the software must wait for this field DIS to be de-asserted by hardware (i.e. polling on DIS=0) before modifying these two assigned values to the target x. Indeed, the target may be requesting an IBI or a controller-role meanwhile the controller intends to modify DA[6:0] or IBIDEN.
  [then]


  [ifdef] I3C_I3C_DEVR3_DEF
    \
    \ @brief I3C device 3 characteristics register
    \ Address offset: 0x6C
    \ Reset value: 0x00000000
    \
    $01 constant I3C_DA                         \ [0x01 : 7] assigned I3C dynamic address to target x (when the I3C is acting as controller) When the I3C is acting as controller, this field should be written by software to store the 7-bit dynamic address that the controller sends via a broadcast ENTDAA or a direct SETNEWDA CCC which has been acknowledged by the target x. Writing to this field has no impact when the read field I3C_DEVRx.DIS=1.
    $10 constant I3C_IBIACK                     \ [0x10] IBI request acknowledge (when the I3C is acting as controller) When the I3C is acting as controller, this bit is written by software to define the acknowledge policy to be applied on the I3C bus on the reception of a IBI request from target x: - After the NACK, the message continues as initially programmed (the target is aware of the NACK and can emit another IBI request later on) - The field DIS is asserted by hardware to protect DA[6:0] from being modified by software meanwhile the hardware can store internally the current DA[6:0] into the kernel clock domain. - After the ACK, the controller logs the IBI payload data, if any, depending on I3C_DEVRx.IBIDEN. - The software is notified by the IBI flag (i.e. I3C_EVR.IBIF=1) and/or the corresponding interrupt if enabled; - Independently from IBIACK configuration for this or other devices, further IBI request(s) are NACKed until IBI request flag (i.e. I3C_EVR.IBIF) and controller-role request flag (i.e. I3C_EVR.CRF) are both cleared.
    $11 constant I3C_CRACK                      \ [0x11] controller-role request acknowledge (when the I3C is acting as controller) When the I3C is acting as controller, this bit is written by software to define the acknowledge policy to be applied on the I3C bus on the reception of a controller-role request from target x: After the NACK, the message continues as initially programmed (the target is aware of the NACK and can emit another controller-role request later on) - The field DIS is asserted by hardware to protect DA[6:0] from being modified by software meanwhile the hardware can store internally the current DA[6:0] into the kernel clock domain. - After the ACK, the message continues as initially programmed. The software is notified by the controller-role request flag (i.e. I3C_EVR.CRF=1) and/or the corresponding interrupt if enabled; For effectively granting the controller-role to the requesting secondary controller, software should issue a GETACCCR (formerly known as GETACCMST), followed by a STOP. - Independently of CRACK configuration for this or other devices, further controller-role request(s) are NACKed until controller-role request flag (i.e. I3C_EVR.CRF) and IBI flag (i.e. I3C_EVR.IBIF) are both cleared.
    $12 constant I3C_IBIDEN                     \ [0x12] IBI data enable (when the I3C is acting as controller) When the I3C is acting as controller, this bit should be written by software to store the BCR[2] bit as received from the target x during broadcast ENTDAA or direct GETBCR CCC via the received I3C_RDR. Writing to this field has no impact when the read field I3C_DEVRx.DIS=1.
    $13 constant I3C_SUSP                       \ [0x13] suspend/stop I3C transfer on received IBI (when the I3C is acting as controller) When the I3C is acting as controller, this bit is used to receive an IBI from target x with pending read notification feature (i.e. with received MDB[7:5]=3'b101). If this bit is set, when an IBI is received (i.e. I3C_EVR.IBIF=1), a Stop is emitted on the I3C bus and the C-FIFO is automatically flushed by hardware; to avoid a next private read communication issue if a previous private read message to the target x was stored in the C-FIFO.
    $1f constant I3C_DIS                        \ [0x1f] DA[6:0] write disabled (when the I3C is acting as controller) When the I3C is acting as controller, once that software set IBIACK=1 or CRACK=1, this read bit is set by hardware (i.e. DIS=1) to lock the configured DA[6:0] and IBIDEN values. Then, to be able to next modify DA[6:0] or IBIDEN, the software must wait for this field DIS to be de-asserted by hardware (i.e. polling on DIS=0) before modifying these two assigned values to the target x. Indeed, the target may be requesting an IBI or a controller-role meanwhile the controller intends to modify DA[6:0] or IBIDEN.
  [then]


  [ifdef] I3C_I3C_DEVR4_DEF
    \
    \ @brief I3C device 4 characteristics register
    \ Address offset: 0x70
    \ Reset value: 0x00000000
    \
    $01 constant I3C_DA                         \ [0x01 : 7] assigned I3C dynamic address to target x (when the I3C is acting as controller) When the I3C is acting as controller, this field should be written by software to store the 7-bit dynamic address that the controller sends via a broadcast ENTDAA or a direct SETNEWDA CCC which has been acknowledged by the target x. Writing to this field has no impact when the read field I3C_DEVRx.DIS=1.
    $10 constant I3C_IBIACK                     \ [0x10] IBI request acknowledge (when the I3C is acting as controller) When the I3C is acting as controller, this bit is written by software to define the acknowledge policy to be applied on the I3C bus on the reception of a IBI request from target x: - After the NACK, the message continues as initially programmed (the target is aware of the NACK and can emit another IBI request later on) - The field DIS is asserted by hardware to protect DA[6:0] from being modified by software meanwhile the hardware can store internally the current DA[6:0] into the kernel clock domain. - After the ACK, the controller logs the IBI payload data, if any, depending on I3C_DEVRx.IBIDEN. - The software is notified by the IBI flag (i.e. I3C_EVR.IBIF=1) and/or the corresponding interrupt if enabled; - Independently from IBIACK configuration for this or other devices, further IBI request(s) are NACKed until IBI request flag (i.e. I3C_EVR.IBIF) and controller-role request flag (i.e. I3C_EVR.CRF) are both cleared.
    $11 constant I3C_CRACK                      \ [0x11] controller-role request acknowledge (when the I3C is acting as controller) When the I3C is acting as controller, this bit is written by software to define the acknowledge policy to be applied on the I3C bus on the reception of a controller-role request from target x: After the NACK, the message continues as initially programmed (the target is aware of the NACK and can emit another controller-role request later on) - The field DIS is asserted by hardware to protect DA[6:0] from being modified by software meanwhile the hardware can store internally the current DA[6:0] into the kernel clock domain. - After the ACK, the message continues as initially programmed. The software is notified by the controller-role request flag (i.e. I3C_EVR.CRF=1) and/or the corresponding interrupt if enabled; For effectively granting the controller-role to the requesting secondary controller, software should issue a GETACCCR (formerly known as GETACCMST), followed by a STOP. - Independently of CRACK configuration for this or other devices, further controller-role request(s) are NACKed until controller-role request flag (i.e. I3C_EVR.CRF) and IBI flag (i.e. I3C_EVR.IBIF) are both cleared.
    $12 constant I3C_IBIDEN                     \ [0x12] IBI data enable (when the I3C is acting as controller) When the I3C is acting as controller, this bit should be written by software to store the BCR[2] bit as received from the target x during broadcast ENTDAA or direct GETBCR CCC via the received I3C_RDR. Writing to this field has no impact when the read field I3C_DEVRx.DIS=1.
    $13 constant I3C_SUSP                       \ [0x13] suspend/stop I3C transfer on received IBI (when the I3C is acting as controller) When the I3C is acting as controller, this bit is used to receive an IBI from target x with pending read notification feature (i.e. with received MDB[7:5]=3'b101). If this bit is set, when an IBI is received (i.e. I3C_EVR.IBIF=1), a Stop is emitted on the I3C bus and the C-FIFO is automatically flushed by hardware; to avoid a next private read communication issue if a previous private read message to the target x was stored in the C-FIFO.
    $1f constant I3C_DIS                        \ [0x1f] DA[6:0] write disabled (when the I3C is acting as controller) When the I3C is acting as controller, once that software set IBIACK=1 or CRACK=1, this read bit is set by hardware (i.e. DIS=1) to lock the configured DA[6:0] and IBIDEN values. Then, to be able to next modify DA[6:0] or IBIDEN, the software must wait for this field DIS to be de-asserted by hardware (i.e. polling on DIS=0) before modifying these two assigned values to the target x. Indeed, the target may be requesting an IBI or a controller-role meanwhile the controller intends to modify DA[6:0] or IBIDEN.
  [then]


  [ifdef] I3C_I3C_MAXRLR_DEF
    \
    \ @brief I3C maximum read length register
    \ Address offset: 0x90
    \ Reset value: 0x00000000
    \
    $00 constant I3C_MRL                        \ [0x00 : 16] maximum data read length (when I3C is acting as target) This field is initially written by software when I3C_CFGR.EN=0 and updated by hardware on the reception of SETMRL command (with potentially also updated IBIP[2:0]). Software is notified of a MRL update by the I3C_EVR.MRLUPF and the corresponding interrupt if enabled. This field is used by hardware to return the value on the I3C bus when the target receives a GETMRL CCC.
    $10 constant I3C_IBIP                       \ [0x10 : 3] IBI payload data size, in bytes (when I3C is acting as target) This field is initially written by software when I3C_CFGR.EN=0 to set the number of data bytes to be sent to the controller after an IBI request has been acknowledged.This field may be updated by hardware on the reception of SETMRL command (which potentially also updated IBIP[2:0]). Software is notified of a MRL update by the I3C_EVR.MRLUPF and the corresponding interrupt if enabled. others: same as 100
  [then]


  [ifdef] I3C_I3C_MAXWLR_DEF
    \
    \ @brief I3C maximum write length register
    \ Address offset: 0x94
    \ Reset value: 0x00000000
    \
    $00 constant I3C_MWL                        \ [0x00 : 16] maximum data write length (when I3C is acting as target) This field is initially written by software when I3C_CFGR.EN=0 and updated by hardware on the reception of SETMWL command. Software is notified of a MWL update by the I3C_EVR.MWLUPF and the corresponding interrupt if enabled. This field is used by hardware to return the value on the I3C bus when the target receives a GETMWL CCC.
  [then]


  [ifdef] I3C_I3C_TIMINGR0_DEF
    \
    \ @brief I3C timing register 0
    \ Address offset: 0xA0
    \ Reset value: 0x00000000
    \
    $00 constant I3C_SCLL_PP                    \ [0x00 : 8] SCL low duration in I3C push-pull phases, in number of kernel clocks cycles: tSCLL_PP = (SCLL_PP + 1) x tI3CCLK SCLL_PP is used to generate tLOW (I3C) timing.
    $08 constant I3C_SCLH_I3C                   \ [0x08 : 8] SCL high duration, used for I3C messages (both in push-pull and open-drain phases), in number of kernel clocks cycles: tSCLH_I3C = (SCLH_I3C + 1) x tI3CCLK SCLH_I3C is used to generate both tHIGH (I3C) and tHIGH_MIXED timings.
    $10 constant I3C_SCLL_OD                    \ [0x10 : 8] SCL low duration in open-drain phases, used for legacy I2C commands and for I3C open-drain phases (address header phase following a START, not a Repeated START), in number of kernel clocks cycles: tSCLL_OD = (SCLL_OD + 1) x tI3CCLK SCLL_OD is used to generate both tLOW (I2C) and tLOW_OD timings (max. of the two).
    $18 constant I3C_SCLH_I2C                   \ [0x18 : 8] SCL high duration, used for legacy I2C commands, in number of kernel clocks cycles: tSCLH_I2C = (SCLH_I2C + 1) x tI3CCLK SCLH_I2C is used to generate tHIGH (I2C) timing.
  [then]


  [ifdef] I3C_I3C_TIMINGR1_DEF
    \
    \ @brief I3C timing register 1
    \ Address offset: 0xA4
    \ Reset value: 0x00000000
    \
    $00 constant I3C_AVAL                       \ [0x00 : 8] number of kernel clock cycles, that is used whatever I3C is acting as controller or target, to set the following MIPI I3C timings, like bus available condition time: When the I3C is acting as target: for bus available condition time: it must wait for (bus available condition) time to be elapsed after a stop and before issuing a start request for an IBI or a controller-role request (i.e. bus free condition is sustained for at least tAVAL). refer to MIPI timing tAVAL = 1 s. This timing is defined by: tAVAL = (AVAL[7:0] + 2) x tI3CCLK for bus idle condition time: it must wait for (bus idle condition) time to be elapsed after that both SDA and SCL are continuously high and stable before issuing a hot-join event. Refer to MIPI v1.1 timing tIDLE = 200 s . This timing is defined by: tIDLE = (AVAL[7:0] + 2) x 200 x tI3CCLK When the I3C is acting as controller, it can not stall the clock beyond a maximum stall time (i.e. stall the SCL clock low), as follows: on first bit of assigned address during dynamic address assignment: it can not stall the clock beyond the MIPI timing tSTALLDAA = 15 ms. This timing is defined by: tSTALLDAA = (AVAL[7:0] + 1) x 15000 x tI3CCLK on ACK/NACK phase of I3C/I2C transfer, on parity bit of write data transfer, on transition bit of I3C read transfer: it can not stall the clock beyond the MIPI timing tSTALL = 100 s. This timing is defined by: tSTALL = (AVAL[7:0] + 1) x 100 x tI3CCLK Whatever the I3C is acting as controller or as (controller-capable) target, during a controller-role hand-off procedure: The new controller must wait for a time (refer to MIPI timing tNEWCRLock) before pulling SDA low (i.e. issuing a start). And the active controller must wait for the same time while monitoring new controller and before testing the new controller by pulling SDA low. This time to wait is dependent on the defined I3C_TIMINGR1.ANSCR[1:0], as follows: If ASNCR[1:0]=00: tNEWCRLock = (AVAL[7:0] + 1) x tI3CCLK If ASNCR[1:0]=01: tNEWCRLock = (AVAL[7:0] + 1) x 100 x tI3CCLK If ASNCR[1:0]=10: tNEWCRLock = (AVAL[7:0] + 1) x 2000 x tI3CCLK If ASNCR[1:0]=11: tNEWCRLock = (AVAL[7:0] + 1) x 50000 x tI3CCLK
    $08 constant I3C_ASNCR                      \ [0x08 : 2] activity state of the new controller (when I3C is acting as active- controller) This field indicates the time to wait before being accessed as new target, refer to the other field AVAL[7:0]. This field can be modified only when the I3C is acting as controller.
    $10 constant I3C_FREE                       \ [0x10 : 7] number of kernel clocks cycles that is used to set some MIPI timings like bus free condition time (when the I3C is acting as controller)
    $1c constant I3C_SDA_HD                     \ [0x1c] SDA hold time (when the I3C is acting as controller), in number of kernel clocks cycles (refer to MIPI timing SDA hold time in push-pull tHD_PP):
  [then]


  [ifdef] I3C_I3C_TIMINGR2_DEF
    \
    \ @brief I3C timing register 2
    \ Address offset: 0xA8
    \ Reset value: 0x00000000
    \
    $00 constant I3C_STALLT                     \ [0x00] Controller clock stall on T-bit phase of Data enable The SCL is stalled during STALL x tSCLL_PP in the T-bit phase (before 9th bit). This allows the target to prepare data to be sent.
    $01 constant I3C_STALLD                     \ [0x01] controller clock stall on PAR phase of Data enable The SCL is stalled during STALL x tSCLL_PP in the T-bit phase (before 9th bit). This allows the target to read received data.
    $02 constant I3C_STALLC                     \ [0x02] controller clock stall on PAR phase of CCC enable The SCL is stalled during STALL x tSCLL_PP in the T-bit phase of common command code (before 9th bit). This allows the target to decode the command.
    $03 constant I3C_STALLA                     \ [0x03] controller clock stall enable on ACK phase The SCL is stalled (during tSCLL_STALLas defined by STALL) in the address ACK/NACK phase (before 9th bit). This allows the target to prepare data or the controller to respond to target interrupt.
    $08 constant I3C_STALL                      \ [0x08 : 8] controller clock stall time, in number of kernel clock cycles tSCLL_STALL = STALL x tI3CCLK
  [then]


  [ifdef] I3C_I3C_BCR_DEF
    \
    \ @brief I3C bus characteristics register
    \ Address offset: 0xC0
    \ Reset value: 0x00000000
    \
    $00 constant I3C_BCR0                       \ [0x00] max data speed limitation
    $02 constant I3C_BCR2                       \ [0x02] in-band interrupt (IBI) payload
    $06 constant I3C_BCR6                       \ [0x06] controller capable
  [then]


  [ifdef] I3C_I3C_DCR_DEF
    \
    \ @brief I3C device characteristics register
    \ Address offset: 0xC4
    \ Reset value: 0x00000000
    \
    $00 constant I3C_DCR                        \ [0x00 : 8] device characteristics ID others: ID to describe the type of the I3C sensor/device Note: The latest MIPI DCR ID assignments are available at: https://www.mipi.org/MIPI_I3C_device_characteristics_register
  [then]


  [ifdef] I3C_I3C_GETCAPR_DEF
    \
    \ @brief I3C get capability register
    \ Address offset: 0xC8
    \ Reset value: 0x00000000
    \
    $0e constant I3C_CAPPEND                    \ [0x0e] IBI MDB support for pending read notification This bit is written by software during bus initialization (i.e. I3C_CFGR.EN=0) and indicates the support (or not) of the pending read notification via the IBI MDB[7:0] value. This bit is used to return the GETCAP3 byte in response to the GETCAPS CCC format 1.
  [then]


  [ifdef] I3C_I3C_CRCAPR_DEF
    \
    \ @brief I3C controller-role capability register
    \ Address offset: 0xCC
    \ Reset value: 0x00000000
    \
    $03 constant I3C_CAPDHOFF                   \ [0x03] delayed controller-role hand-off This bit is written by software during bus initialization (i.e. I3C_CFGR.EN=0) and indicates if this target I3C may need additional time to process a controller-role hand-off requested by the current controller. This bit is used to return the CRCAP2 byte in response to the GETCAPS CCC format 2.
    $09 constant I3C_CAPGRP                     \ [0x09] group management support (when acting as controller) This bit is written by software during bus initialization (i.e. I3C_CFGR.EN=0) and indicates if the I3C is able to support group management when it acts as a controller (after controller-role hand-off) via emitted DEFGRPA, RSTGRPA, and SETGRPA CCC. This bit is used to return the CRCAP1 byte in response to the GETCAPS CCC format 2.
  [then]


  [ifdef] I3C_I3C_GETMXDSR_DEF
    \
    \ @brief I3C get capability register
    \ Address offset: 0xD0
    \ Reset value: 0x00000000
    \
    $00 constant I3C_HOFFAS                     \ [0x00 : 2] controller hand-off activity state This bit is written by software during bus initialization (i.e. I3C_CFGR.EN=0) and indicates in which initial activity state the (other) current controller should expect the I3C bus after a controller-role hand-off to this controller-capable I3C, when returning the defining byte CRHDLY (0x91) to a GETMXDS CCC. This 2-bit field is used to return the CRHDLY1 byte in response to the GETCAPS CCC format 3, in order to state which is the activity state of this I3C when becoming controller after a controller-role hand-off, and consequently the time the former controller should wait before testing this I3C to be confirmed its ownership.
    $08 constant I3C_FMT                        \ [0x08 : 2] GETMXDS CCC format This field is written by software during bus initialization (i.e. I3C_CFGR.EN=0) and indicates how is returned the GETMXDS format 1 (without MaxRdTurn) and format 2 (with MaxRdTurn). This bit is used to return the 2-byte format 1 (MaxWr, MaxRd) or 5-byte format 2 (MaxWr, MaxRd, 3-byte MaxRdTurn) byte in response to the GETCAPS CCC. - 3-byte MaxRdTurn is returned with MSB=0, middle byte=0 and LSB=RDTURN[7:0]. - Max read turnaround time is less than 256 s. - 3-byte MaxRdTurn is returned with MSB=0, middle byte=RDTURN[7:0] and LSB=0. - Max read turnaround time is between 256 s and 65535 s - 3-byte MaxRdTurn is returned with MSB=RDTURN[7:0], middle byte=0 and LSB=0. - Max read turnaround time is between 65535 s and 16 s.
    $10 constant I3C_RDTURN                     \ [0x10 : 8] programmed byte of the 3-byte MaxRdTurn (maximum read turnaround byte) This bit is written by software during bus initialization (i.e. I3C_CFGR.EN=0) and writes the value of the selected byte (via the FMT[1:0] field) of the 3-byte MaxRdTurn which is returned in response to the GETMXDS CCC format 2 to encode the maximum read turnaround time.
    $18 constant I3C_TSCO                       \ [0x18] clock-to-data turnaround time (tSCO) This bit is written by software during bus initialization (i.e. I3C_CFGR.EN=0) and is used to specify the clock-to-data turnaround time tSCO (vs the value of 12 ns). This bit is used by the hardware in response to the GETMXDS CCC to return the encoded clock-to-data turnaround time via the returned MaxRd[5:3] bits.
  [then]


  [ifdef] I3C_I3C_EPIDR_DEF
    \
    \ @brief I3C extended provisioned ID register
    \ Address offset: 0xD4
    \ Reset value: 0x02080000
    \
    $0c constant I3C_MIPIID                     \ [0x0c : 4] 4-bit MIPI Instance ID This field is written by software to set and identify individually each instance of this I3C IP with a specific number on a single I3C bus. This field represents the bits[15:12] of the 48-bit provisioned ID. Note: The bits[11:0] of the provisioned ID may be 0.
    $10 constant I3C_IDTSEL                     \ [0x10] provisioned ID type selector This field is set as 0 i.e. vendor fixed value. This field represents the bit[32] of the 48-bit provisioned ID. Note: The bits[31:16] of the provisioned ID may be 0.
    $11 constant I3C_MIPIMID                    \ [0x11 : 15] 15-bit MIPI manufacturer ID This read field is the 15-bit STMicroelectronics MIPI ID i.e. 0x0104. This field represents the bits[47:33] of the 48-bit provisioned ID.
  [then]

  \
  \ @brief Improved inter-integrated circuit
  \
  $00 constant I3C_I3C_CR               \ I3C message control register
  $00 constant I3C_I3C_CR_ALTERNATE     \ I3C message control register alternate
  $04 constant I3C_I3C_CFGR             \ I3C configuration register
  $10 constant I3C_I3C_RDR              \ I3C receive data byte register
  $14 constant I3C_I3C_RDWR             \ I3C receive data word register
  $18 constant I3C_I3C_TDR              \ I3C transmit data byte register
  $1C constant I3C_I3C_TDWR             \ I3C transmit data word register
  $20 constant I3C_I3C_IBIDR            \ I3C IBI payload data register
  $24 constant I3C_I3C_TGTTDR           \ I3C target transmit configuration register
  $30 constant I3C_I3C_SR               \ I3C status register
  $34 constant I3C_I3C_SER              \ I3C status error register
  $40 constant I3C_I3C_RMR              \ I3C received message register
  $50 constant I3C_I3C_EVR              \ I3C event register
  $54 constant I3C_I3C_IER              \ I3C interrupt enable register
  $58 constant I3C_I3C_CEVR             \ I3C clear event register
  $60 constant I3C_I3C_DEVR0            \ I3C own device characteristics register
  $64 constant I3C_I3C_DEVR1            \ I3C device 1 characteristics register
  $68 constant I3C_I3C_DEVR2            \ I3C device 2 characteristics register
  $6C constant I3C_I3C_DEVR3            \ I3C device 3 characteristics register
  $70 constant I3C_I3C_DEVR4            \ I3C device 4 characteristics register
  $90 constant I3C_I3C_MAXRLR           \ I3C maximum read length register
  $94 constant I3C_I3C_MAXWLR           \ I3C maximum write length register
  $A0 constant I3C_I3C_TIMINGR0         \ I3C timing register 0
  $A4 constant I3C_I3C_TIMINGR1         \ I3C timing register 1
  $A8 constant I3C_I3C_TIMINGR2         \ I3C timing register 2
  $C0 constant I3C_I3C_BCR              \ I3C bus characteristics register
  $C4 constant I3C_I3C_DCR              \ I3C device characteristics register
  $C8 constant I3C_I3C_GETCAPR          \ I3C get capability register
  $CC constant I3C_I3C_CRCAPR           \ I3C controller-role capability register
  $D0 constant I3C_I3C_GETMXDSR         \ I3C get capability register
  $D4 constant I3C_I3C_EPIDR            \ I3C extended provisioned ID register

: I3C_DEF ; [then]
