\
\ @file sec_i3c.fs
\ @brief Improved inter-integrated circuit
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief I3C message control register
\ Address offset: 0x00
\ Reset value: 0x00000000
\

$0000ffff constant SEC_I3C_I3C_CR_DCNT                              \ count of data to transfer during a read or write message, in bytes (whatever I3C is acting as controller/target) Linear encoding up to 64 Kbytes -1 ...
$00010000 constant SEC_I3C_I3C_CR_RNW                               \ read / non-write message (when I3C is acting as controller) When I3C is acting as controller, this field is used if MTYPE[3:0]=0010 (private message) or MTYPE[3:0]=0011 (direct message) or MTYPE[3:0]=0100 (legacy I2C message), in order to emit the RnW bit on the I3C bus.
$00fe0000 constant SEC_I3C_I3C_CR_ADD                               \ 7-bit I3C dynamic / I2C static target address (when I3C is acting as controller) When I3C is acting as controller, this field is used if MTYPE[3:0]=0010 (private message) or MTYPE[3:0]=0011 (direct message) or MTYPE[3:0]=0100 (legacy I2C message)
$78000000 constant SEC_I3C_I3C_CR_MTYPE                             \ message type (whatever I3C is acting as controller/target) Bits[26:0] are ignored. After M2 error detection on an I3C SDR message, this is needed for SCL 'stuck at' recovery. Bits[26:0] are ignored. If I3C_CFGR.EXITPTRN=1, an HDR exit pattern is emitted on the bus to generate an escalation fault. Bits[23:17] (ADD[6:0]) is the emitted 7-bit dynamic address. Bit[16] (RNW) is the emitted RnW bit. The transferred private message is: {S / S+7'h7E+RnW=0+Sr / Sr+*} + 7-bit DynAddr + RnW + (8-bit Data + T)* + Sr/P. After a S (START), depending on I3C_CFGR.NOARBH, the arbitrable header (7'h7E+RnW=0) is inserted or not. Sr+*: after a Sr (Repeated Start), the hardware automatically inserts (7'h7E+RnW=0) if needed, i.e. if it follows an I3C direct message without ending by a P (Stop). Bits[23:17] (ADD[6:0]) is the emitted 7-bit dynamic address. Bit[16] (RNW) is the emitted RnW bit. The transferred direct message is: Sr + 7-bit DynAddr + RnW + (8-bit Data + T)* + Sr/P Bits[23:17] (ADD[6:0]) is the emitted 7-bit static address. Bit[16] (RNW) is the emitted RnW bit. The transferred legacy I2C message is: {S / S+ 7'h7E+RnW=0 + Sr / Sr+*} + 7-bit StaAddr + RnW + (8-bit Data + T)* + Sr/P. After a S (START), depending on I3C_CFGR.NOARBH, the arbitrable header (7'h7E+RnW=0) is inserted or not. Sr+*: after a Sr (Repeated Start), the hardware automatically inserts (7'h7E+RnW=0) if needed, i.e. if it follows an I3C direct message without ending by a P (Stop). 1xxx: reserved (when I3C is acting as I3C controller, used when target) 0xxx: reserved {S +} 7'h02 addr + RnW=0 {S +} 7-bit I3C_DEVR0.DA[6:0] + RnW=0 after a bus available condition (the target first emits a START request), or once the controller drives a START. {S +} 7-bit I3C_DEVR0.DA[6:0] + RnW=1 (+Ack/Nack from controller) When acknowledged from controller, the next (optional, depending on I3C_BCR.BCR2) transmitted IBI payload data is defined by I3C_CR.DCNT[15:0] and must be consistently programmed vs the maximum IBI payload data size which is defined by I3C_IBIDR.IBIP[2:0]. Others: reserved
$80000000 constant SEC_I3C_I3C_CR_MEND                              \ message end type (when the I3C is acting as controller)


\
\ @brief I3C message control register alternate
\ Address offset: 0x00
\ Reset value: 0x00000000
\

$0000ffff constant SEC_I3C_I3C_CR_ALTERNATE_DCNT                    \ count of data to transfer during a read or write message, in bytes (when I3C is acting as controller) Linear encoding up to 64 Kbytes -1. ...
$00ff0000 constant SEC_I3C_I3C_CR_ALTERNATE_CCC                     \ 8-bit CCC code (when I3C is acting as controller) If Bit[23]=CCC[7]=1, this is the 1st part of an I3C SDR direct CCC command. If Bit[23]=CCC[7]=0, this is an I3C SDR broadcast CCC command (including ENTDAA and ENTHDR0).
$78000000 constant SEC_I3C_I3C_CR_ALTERNATE_MTYPE                   \ message type (when I3C is acting as controller) Bits[23:16] (CCC[7:0]) is the emitted 8-bit CCC code If Bit[23]=CCC[7]=1: this is the 1st part of an I3C SDR direct CCC command The transferred direct CCC command message is: {S / S+7'h7E +RnW=0 / Sr+*} + (direct CCC + T) + (8-bit Data + T)* + Sr After a S (START), depending on I3C_CFGR.NOARBH, the arbitrable header (7'h7E+RnW=0) is inserted or not. Sr+*: after a Sr (Repeated Start), the hardware automatically inserts (7'h7E+R/W). If Bit[23]=CCC[7]=0: this is an I3C SDR broadcast CCC command (including ENTDAA and ENTHDR0) The transferred broadcast CCC command message is: {S / S+7'h7E +RnW=0 / Sr+*} + (broadcast CCC + T) + (8-bit Data + T)* + Sr/P After a S (START), depending on I3C_CFGR.NOARBH, the arbitrable header (7'h7E+RnW=0) is inserted or not. Sr+*: after a Sr (Repeated Start), the hardware automatically inserts (7'h7E+R/W). others: reserved
$80000000 constant SEC_I3C_I3C_CR_ALTERNATE_MEND                    \ message end type (when I3C is acting as controller)


\
\ @brief I3C configuration register
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$00000001 constant SEC_I3C_I3C_CFGR_EN                              \ I3C enable (whatever I3C is acting as controller/target) - Except registers, the peripheral is under reset (a.k.a. partial reset). - Before clearing EN, when I3C is acting as a controller, all the possible target requests must be disabled using DISEC CCC. - When I3C is acting as a target, software should not disable the I3C, unless a partial reset is needed. In this state, some register fields can not be modified (like CRINIT, HKSDAEN for the I3C_CFGR)
$00000002 constant SEC_I3C_I3C_CFGR_CRINIT                          \ initial controller/target role This bit can be modified only when I3C_CFGR.EN = 0. Once enabled by setting I3C_CFGR.EN = 1, I3C peripheral initially acts as an I3C target. I3C does not drive SCL line and does not enable SDA pull-up, until it eventually acquires the controller role. Once enabled by setting I3C_CFGR.EN = 1, I3C peripheral initially acts as a controller. It has the I3C controller role, so drives SCL line and enables SDA pull-up, until it eventually offers the controller role to an I3C secondary controller.
$00000004 constant SEC_I3C_I3C_CFGR_NOARBH                          \ no arbitrable header after a START (when I3C is acting as a controller) This bit can be modified only when there is no on-going frame. - The target address is emitted directly after a START in case of a legacy I2C message or an I3C SDR private read/write message. - This is a more performing option (when is useless the emission of the 0x7E arbitrable header), but this is to be used only when the controller is sure that the addressed target device can not emit concurrently an IBI or a controller-role request (to insure no misinterpretation and no potential conflict between the address emitted by the controller in open-drain mode and the same address a target device can emit after a START, for IBI or MR).
$00000008 constant SEC_I3C_I3C_CFGR_RSTPTRN                         \ HDR reset pattern enable (when I3C is acting as a controller) This bit can be modified only when there is no on-going frame.
$00000010 constant SEC_I3C_I3C_CFGR_EXITPTRN                        \ HDR Exit Pattern enable (when I3C is acting as a controller) This bit can be modified only when there is no on-going frame. This is used to send only the header to test ownership of the bus when there is a suspicion of problem after controller-role hand-off (new controller didn't assert its controller-role by accessing the previous one in less than Activity State time). The HDR Exit Pattern is sent even if the message header {S/Sr + 0x7E addr + W } is ACKed.
$00000020 constant SEC_I3C_I3C_CFGR_HKSDAEN                         \ High-keeper enable on SDA line (when I3C is acting as a controller) This bit can be modified only when I3C_CFGR.EN=0.
$00000080 constant SEC_I3C_I3C_CFGR_HJACK                           \ Hot Join request acknowledge (when I3C is acting as a controller) After the NACK, the message continues as initially programmed (the hot-joining target is aware of the NACK and surely emits another hot-join request later on). After the ACK, the message continues as initially programmed. The software is aware by the HJ interrupt (flag I3C_EVR.HJF is set) and initiates the ENTDAA sequence later on, potentially preventing others Hot Join requests with a Disable target events command (DISEC, with DISHJ=1). Independently of the HJACK configuration, further Hot Join request(s) are NACKed until the Hot Join flag, HJF, is cleared. However, a NACKed target can be assigned a dynamic address by the ENTDAA sequence initiated later on by the first HJ request, preventing this target to emit an HJ request again.
$00000100 constant SEC_I3C_I3C_CFGR_RXDMAEN                         \ RX-FIFO DMA request enable (whatever I3C is acting as controller/target) - Software reads and pops a data byte/word from RX-FIFO i.e. reads I3C_RDR or I3C_RDWR register. - A next data byte/word is to be read by the software either via polling on the flag I3C_EVR.RXFNEF=1 or via interrupt notification (enabled by I3C_IER.RXFNEIE=1). - DMA reads and pops data byte(s)/word(s) from RX-FIFO i.e. reads I3C_RDR or I3C_RDWR register. - A next data byte/word is automatically read by the programmed hardware (i.e. via the asserted RX-FIFO DMA request from the I3C and the programmed DMA channel).
$00000200 constant SEC_I3C_I3C_CFGR_RXFLUSH                         \ RX-FIFO flush (whatever I3C is acting as controller/target) This bit can only be written.
$00000400 constant SEC_I3C_I3C_CFGR_RXTHRES                         \ RX-FIFO threshold (whatever I3C is acting as controller/target) This threshold defines, compared to the RX-FIFO level, when the I3C_EVR.RXFNEF flag is set (and consequently if RXDMAEN=1 when is asserted a DMA RX request). RXFNEF is set when 1 byte is to be read in RX-FIFO (i.e. in I3C_RDR). RXFNEF is set when 4 bytes are to be read in RX-FIFO (i.e. in I3C_RDWR).
$00001000 constant SEC_I3C_I3C_CFGR_TXDMAEN                         \ TX-FIFO DMA request enable (whatever I3C is acting as controller/target) - Software writes and pushes a data byte/word into TX-FIFO i.e. writes I3C_TDR or I3C_TDWR register, to be transmitted over the I3C bus. - A next data byte/word is to be written by the software either via polling on the flag I3C_EVR.TXFNFF=1 or via interrupt notification (enabled by I3C_IER.TXFNFIE=1). - DMA writes and pushes data byte(s)/word(s) into TX-FIFO i.e. writes I3C_TDR or I3C_TDWR register. - A next data byte/word transfer is automatically pushed by the programmed hardware (i.e. via the asserted TX-FIFO DMA request from the I3C and the programmed DMA channel).
$00002000 constant SEC_I3C_I3C_CFGR_TXFLUSH                         \ TX-FIFO flush (whatever I3C is acting as controller/target) This bit can only be written. When the I3C is acting as target, this bit can be used to flush the TX-FIFO on a private read if the controller has early ended the read data (i.e. driven low the T bit) and there is/are remaining data in the TX-FIFO (i.e. I3C_SR.ABT=1 and I3C_SR.XDCNT[15:0] I3C_TGTTDR.TGTTDCNT[15:0]).
$00004000 constant SEC_I3C_I3C_CFGR_TXTHRES                         \ TX-FIFO threshold (whatever I3C is acting as controller/target) This threshold defines, compared to the TX-FIFO level, when the I3C_EVR.TXFNFF flag is set (and consequently if TXDMAEN=1 when is asserted a DMA TX request). TXFNFF is set when 1 byte is to be written in TX-FIFO (i.e. in I3C_TDR). TXFNFF is set when 4 bytes are to be written in TX-FIFO (i.e. in I3C_TDWR).
$00010000 constant SEC_I3C_I3C_CFGR_SDMAEN                          \ S-FIFO DMA request enable (when I3C is acting as controller) Condition: When RMODE=1 (FIFO is enabled for the status): - Software reads and pops a status word from S-FIFO i.e. reads I3C_SR register after a completed frame (I3C_EVR.FCF=1) or an error (I3C_EVR.ERRF=1). - A status word can be read by the software either via polling on these register flags or via interrupt notification (enabled by I3C_IER.FCIE=1 and I3C_IER.ERRIE=1). - DMA reads and pops status word(s) from S-FIFO i.e. reads I3C_SR register. - Status word(s) are automatically read by the programmed hardware (i.e. via the asserted S-FIFO DMA request from the I3C and the programmed DMA channel).
$00020000 constant SEC_I3C_I3C_CFGR_SFLUSH                          \ S-FIFO flush (when I3C is acting as controller) When I3C is acting as I3C controller, this bit can only be written (and is only used when I3C is acting as controller).
$00040000 constant SEC_I3C_I3C_CFGR_RMODE                           \ S-FIFO enable / status receive mode (when I3C is acting as controller) When I3C is acting as I3C controller, this bit is used for the enabling the FIFO for the status (S-FIFO) vs the received status from the target on the I3C bus. When I3C is acting as target, this bit must be cleared. - Status register (i.e. I3C_SR) is used without FIFO mechanism. - There is no SCL stretch if a new status register content is not read. - Status register must be read before being lost/overwritten. All message status must be read. There is SCL stretch when there is no more space in the S-FIFO.
$00080000 constant SEC_I3C_I3C_CFGR_TMODE                           \ transmit mode (when I3C is acting as controller) When I3C is acting as I3C controller, this bit is used for the C-FIFO and TX-FIFO management vs the emitted frame on the I3C bus. A frame transfer starts as soon as first control word is present in C-FIFO.
$00100000 constant SEC_I3C_I3C_CFGR_CDMAEN                          \ C-FIFO DMA request enable (when I3C is acting as controller) When I3C is acting as controller: - Software writes and pushes control word(s) into C-FIFO i.e. writes I3C_CR register, as needed for a given frame. - A next control word transfer can be written by software either via polling on the flag I3C_EVR.CFNFF=1 or via interrupt notification (enabled by I3C_IER.CFNFIE=1). - DMA writes and pushes control word(s) into C-FIFO i.e. writes I3C_CR register, as needed for a given frame. - A next control word transfer is automatically written by the programmed hardware (i.e. via the asserted C-FIFO DMA request from the I3C and the programmed DMA channel).
$00200000 constant SEC_I3C_I3C_CFGR_CFLUSH                          \ C-FIFO flush (when I3C is acting as controller) This bit can only be written.
$40000000 constant SEC_I3C_I3C_CFGR_TSFSET                          \ frame transfer set (a.k.a. software trigger) (when I3C is acting as controller) This bit can only be written. When I3C is acting as I3C controller: Note: If this bit is not set, the other alternative for the software to initiate a frame transfer is to directly write the first control word register (i.e. I3C_CR) while C-FIFO is empty (i.e. I3C_EVR.CFEF=1). Then, if the first written control word is not tagged as a message end (i.e I3C_CR.MEND=0), it causes the hardware to assert the flag I3C_EVR.CFNFF (C-FIFO not full and a next control word is needed).


\
\ @brief I3C receive data byte register
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$000000ff constant SEC_I3C_I3C_RDR_RDB0                             \ 8-bit received data on I3C bus.


\
\ @brief I3C receive data word register
\ Address offset: 0x14
\ Reset value: 0x00000000
\

$000000ff constant SEC_I3C_I3C_RDWR_RDB0                            \ 8-bit received data (earliest byte on I3C bus).
$0000ff00 constant SEC_I3C_I3C_RDWR_RDB1                            \ 8-bit received data (next byte after RDB0 on I3C bus).
$00ff0000 constant SEC_I3C_I3C_RDWR_RDB2                            \ 8-bit received data (next byte after RDB1 on I3C bus).
$ff000000 constant SEC_I3C_I3C_RDWR_RDB3                            \ 8-bit received data (latest byte on I3C bus).


\
\ @brief I3C transmit data byte register
\ Address offset: 0x18
\ Reset value: 0x00000000
\

$000000ff constant SEC_I3C_I3C_TDR_TDB0                             \ 8-bit data to transmit on I3C bus.


\
\ @brief I3C transmit data word register
\ Address offset: 0x1C
\ Reset value: 0x00000000
\

$000000ff constant SEC_I3C_I3C_TDWR_TDB0                            \ 8-bit transmit data (earliest byte on I3C bus)
$0000ff00 constant SEC_I3C_I3C_TDWR_TDB1                            \ 8-bit transmit data (next byte after TDB0[7:0] on I3C bus).
$00ff0000 constant SEC_I3C_I3C_TDWR_TDB2                            \ 8-bit transmit data (next byte after TDB1[7:0] on I3C bus).
$ff000000 constant SEC_I3C_I3C_TDWR_TDB3                            \ 8-bit transmit data (latest byte on I3C bus).


\
\ @brief I3C IBI payload data register
\ Address offset: 0x20
\ Reset value: 0x00000000
\

$000000ff constant SEC_I3C_I3C_IBIDR_IBIDB0                         \ 8-bit IBI payload data (earliest byte on I3C bus, i.e. MDB[7:0] mandatory data byte).
$0000ff00 constant SEC_I3C_I3C_IBIDR_IBIDB1                         \ 8-bit IBI payload data (next byte on I3C bus after IBIDB0[7:0]).
$00ff0000 constant SEC_I3C_I3C_IBIDR_IBIDB2                         \ 8-bit IBI payload data (next byte on I3C bus after IBIDB1[7:0]).
$ff000000 constant SEC_I3C_I3C_IBIDR_IBIDB3                         \ 8-bit IBI payload data (latest byte on I3C bus).


\
\ @brief I3C target transmit configuration register
\ Address offset: 0x24
\ Reset value: 0x00000000
\

$0000ffff constant SEC_I3C_I3C_TGTTDR_TGTTDCNT                      \ transmit data counter, in bytes (when I3C is configured as target) This field must be written by software in the same access when is asserted PRELOAD, in order to define the number of bytes to preload and to transmit. This field is updated by hardware and reports, when read, the remaining number of bytes to be loaded into the TX-FIFO.
$00010000 constant SEC_I3C_I3C_TGTTDR_PRELOAD                       \ preload of the TX-FIFO (when I3C is configured as target) This bit must be written and asserted by software in the same access when is written and defined the number of bytes to preload into the TX-FIFO and to transmit. This bit is cleared by hardware when all the data bytes to transmit are loaded into the TX-FIFO.


\
\ @brief I3C status register
\ Address offset: 0x30
\ Reset value: 0x00000000
\

$0000ffff constant SEC_I3C_I3C_SR_XDCNT                             \ data counter - When the I3C is acting as controller: number of targets detected on the bus - When the I3C is acting as target: number of transmitted bytes - Whatever the I3C is acting as controller or target: number of data bytes read from or transmitted on the I3C bus during the MID[7:0] message
$00020000 constant SEC_I3C_I3C_SR_ABT                               \ a private read message is completed/aborted prematurely by the target (when the I3C is acting as controller) When the I3C is acting as controller, this bit indicates if the private read data which is transmitted by the target early terminates (i.e. the target drives T bit low earlier vs what does expect the controller in terms of programmed number of read data bytes i.e. I3C_CR.DCNT[15:0]).
$00040000 constant SEC_I3C_I3C_SR_DIR                               \ message direction Whatever the I3C is acting as controller or target, this bit indicates the direction of the related message on the I3C bus Note: ENTDAA CCC is considered as a write command.
$ff000000 constant SEC_I3C_I3C_SR_MID                               \ message identifier/counter of a given frame (when the I3C is acting as controller) When the I3C is acting as controller, this field identifies the control word message (i.e. I3C_CR) to which the I3C_SR status register refers. First message of a frame is identified with MID[7:0]=0. This field is incremented (by hardware) on the completion of a new message control word (i.e. I3C_CR) over I3C bus. This field is reset for every new frame start.


\
\ @brief I3C status error register
\ Address offset: 0x34
\ Reset value: 0x00000000
\

$0000000f constant SEC_I3C_I3C_SER_CODERR                           \ protocol error code/type controller detected an illegally formatted CCC controller detected that transmitted data on the bus is different from expected controller detected a not acknowledged broadcast address (7'hE) controller detected the new controller did not drive bus after controller-role hand-off target detected an invalid broadcast address 7'hE+W target detected a parity error on a CCC code via a parity check (vs T bit) target detected a parity error on a write data via a parity check (vs T bit) target detected a parity error on the assigned address during dynamic address arbitration via a parity check (vs PAR bit) target detected a 7'hE+R missing after Sr during dynamic address arbitration target detected an illegally formatted CCC target detected that transmitted data on the bus is different from expected others: reserved
$00000010 constant SEC_I3C_I3C_SER_PERR                             \ protocol error
$00000020 constant SEC_I3C_I3C_SER_STALL                            \ SCL stall error (when the I3C is acting as target)
$00000040 constant SEC_I3C_I3C_SER_DOVR                             \ RX-FIFO overrun or TX-FIFO underrun i) a TX-FIFO underrun: TX-FIFO is empty and a write data byte has to be transmitted ii) a RX-FIFO overrun: RX-FIFO is full and a new data byte is received
$00000080 constant SEC_I3C_I3C_SER_COVR                             \ C-FIFO underrun or S-FIFO overrun (when the I3C is acting as controller) i) a C-FIFO underrun: control FIFO is empty and a restart has to be emitted ii) a S-FIFO overrun: S-FIFO is full and a new message ends
$00000100 constant SEC_I3C_I3C_SER_ANACK                            \ address not acknowledged (when the I3C is configured as controller) i) a legacy I2C read/write transfer ii) a direct CCC write transfer iii) the second trial of a direct CCC read transfer iv) a private read/write transfer
$00000200 constant SEC_I3C_I3C_SER_DNACK                            \ data not acknowledged (when the I3C is acting as controller) i) a legacy I2C write transfer ii) the second trial when sending dynamic address during ENTDAA procedure
$00000400 constant SEC_I3C_I3C_SER_DERR                             \ data error (when the I3C is acting as controller)


\
\ @brief I3C received message register
\ Address offset: 0x40
\ Reset value: 0x00000000
\

$00000007 constant SEC_I3C_I3C_RMR_IBIRDCNT                         \ IBI received payload data count (when the I3C is configured as controller) When the I3C is configured as controller, this field logs the number of data bytes effectively received in the I3C_IBIDR register.
$0000ff00 constant SEC_I3C_I3C_RMR_RCODE                            \ received CCC code (when the I3C is configured as target) When the I3C is configured as target, this field logs the received CCC code.
$00fe0000 constant SEC_I3C_I3C_RMR_RADD                             \ received target address (when the I3C is configured as controller) When the I3C is configured as controller, this field logs the received dynamic address from the target during acknowledged IBI or controller-role request.


\
\ @brief I3C event register
\ Address offset: 0x50
\ Reset value: 0x00000003
\

$00000001 constant SEC_I3C_I3C_EVR_CFEF                             \ C-FIFO empty flag (whatever the I3C is acting as controller/target) This flag is asserted by hardware to indicate that the C-FIFO is empty when controller, and that the I3C_CR register contains no control word (i.e. none IBI/CR/HJ request) when target. This flag is de-asserted by hardware to indicate that the C-FIFO is not empty when controller, and that the I3C_CR register contains one control word (i.e. a pending IBI/CR/HJ request) when target. Note: When the I3C is acting as controller, if the C-FIFO and TX-FIFO preload is configured (i.e. I3C_CFGR.TMODE=1), the software must wait for TXFEF=1 and CFEF=1 before starting a new frame transfer.
$00000002 constant SEC_I3C_I3C_EVR_TXFEF                            \ TX-FIFO empty flag (whatever the I3C is acting as controller/target) This flag is asserted by hardware to indicate that the TX-FIFO is empty. This flag is de-asserted by hardware to indicate that the TX-FIFO is not empty. Note: When the I3C is acting as controller, if the C-FIFO and TX-FIFO preload is configured (i.e. I3C_CFGR.TMODE=1), the software must wait for TXFEF=1 and CFEF=1 before starting a new frame transfer.
$00000004 constant SEC_I3C_I3C_EVR_CFNFF                            \ C-FIFO not full flag (when the I3C is acting as controller) When the I3C is acting as controller, this flag is asserted by hardware to indicate that a control word is to be written to the C-FIFO. This flag is de-asserted by hardware to indicate that a control word is not to be written to the C-FIFO. Note: The software must wait for CFNFF=1 (by polling or via the enabled interrupt) before writing to C-FIFO (i.e. writing to I3C_CR).
$00000008 constant SEC_I3C_I3C_EVR_SFNEF                            \ S-FIFO not empty flag (when the I3C is acting as controller) When the I3C is acting as controller, if the S-FIFO is enabled (i.e. I3C_CFGR.RMODE=1), this flag is asserted by hardware to indicate that a status word is to be read from the S-FIFO. This flag is de-asserted by hardware to indicate that a status word is not to be read from the S-FIFO.
$00000010 constant SEC_I3C_I3C_EVR_TXFNFF                           \ TX-FIFO not full flag (whatever the I3C is acting as controller/target) This flag is asserted by hardware to indicate that a data byte/word is to be written to the TX-FIFO. This flag is de-asserted by hardware to indicate that a data byte/word is not to be written to the TX-FIFO. Note: The software must wait for TXFNFF=1 (by polling or via the enabled interrupt) before writing to TX-FIFO (i.e. writing to I3C_TDR or I3C_TDWR depending on I3C_CFGR.TXTHRES). Note: When the I3C is acting as target, if the software intends to use the TXFNFF flag for writing into I3C_TDR/I3C_TDWR, it must have configured and set the TX-FIFO preload (i.e. write I3C_TGTTDR.PRELOAD).
$00000020 constant SEC_I3C_I3C_EVR_RXFNEF                           \ RX-FIFO not empty flag (whatever the I3C is acting as controller/target) This flag is asserted by hardware to indicate that a data byte is to be read from the RX-FIFO. This flag is de-asserted by hardware to indicate that a data byte is not to be read from the RX-FIFO. Note: The software must wait for RXFNEF=1 (by polling or via the enabled interrupt) before reading from RX-FIFO (i.e. writing to I3C_RDR or I3C_RDWR depending on I3C_CFGR.RXTHRES).
$00000040 constant SEC_I3C_I3C_EVR_TXLASTF                          \ last written data byte/word flag (whatever the I3C is acting as controller/target) This flag is asserted by hardware to indicate that the last data byte/word (depending on I3C_CFGR.TXTHRES) of a message is to be written to the TX-FIFO. This flag is de-asserted by hardware when the last data byte/word of a message is written.
$00000080 constant SEC_I3C_I3C_EVR_RXLASTF                          \ last read data byte/word flag (whatever the I3C is acting as controller/target) This flag is asserted by hardware to indicate that the last data byte/word (depending on I3C_CFGR.RXTHRES) of a message is to be read from the RX-FIFO. This flag is de-asserted by hardware when the last data byte/word of a message is read.
$00000200 constant SEC_I3C_I3C_EVR_FCF                              \ frame complete flag (whatever the I3C is acting as controller/target) When the I3C is acting as controller, this flag is asserted by hardware to indicate that a frame has been (normally) completed on the I3C bus, i.e when a stop is issued. When the I3C is acting as target, this flag is asserted by hardware to indicate that a message addressed to/by this target has been (normally) completed on the I3C bus, i.e when a next stop or repeated start is then issued by the controller. This flag is cleared when software writes 1 into corresponding I3C_CEVR.CFCF bit.
$00000400 constant SEC_I3C_I3C_EVR_RXTGTENDF                        \ target-initiated read end flag (when the I3C is acting as controller) When the I3C is acting as controller, this flag is asserted by hardware to indicate that the target has prematurely ended a read transfer. Then, software should read I3C_SR to get more information on the prematurely read transfer. This flag is cleared when software writes 1 into corresponding I3C_CEVR.CRXTGTENDF bit.
$00000800 constant SEC_I3C_I3C_EVR_ERRF                             \ flag (whatever the I3C is acting as controller/target) This flag is asserted by hardware to indicate that an error occurred.Then, software should read I3C_SER to get the error type. This flag is cleared when software writes 1 into corresponding I3C_CEVR.CERRF bit.
$00008000 constant SEC_I3C_I3C_EVR_IBIF                             \ IBI flag (when the I3C is acting as controller) When the I3C is acting as controller, this flag is asserted by hardware to indicate that an IBI request has been received. This flag is cleared when software writes 1 into corresponding I3C_CEVR.CIBIF bit.
$00010000 constant SEC_I3C_I3C_EVR_IBIENDF                          \ IBI end flag (when the I3C is acting as target) When the I3C is acting as target, this flag is asserted by hardware to indicate that a IBI transfer has been received and completed (IBI acknowledged and IBI data bytes read by controller if any). This flag is cleared when software writes 1 into corresponding I3C_CEVR.CIBIENDF bit.
$00020000 constant SEC_I3C_I3C_EVR_CRF                              \ controller-role request flag (when the I3C is acting as controller) When the I3C is acting as controller, this flag is asserted by hardware to indicate that a controller-role request has been acknowledged and completed (by hardware). The software should then issue a GETACCCR CCC (get accept controller role) for the controller-role hand-off procedure. This flag is cleared when software writes 1 into corresponding I3C_CEVR.CCRF bit.
$00040000 constant SEC_I3C_I3C_EVR_CRUPDF                           \ controller-role update flag (when the I3C is acting as target) When the I3C is acting as target, this flag is asserted by hardware to indicate that it has now gained the controller role after the completed controller-role hand-off procedure. This flag is cleared when software writes 1 into corresponding I3C_CEVR.CCRUPDF bit.
$00080000 constant SEC_I3C_I3C_EVR_HJF                              \ hot-join flag (when the I3C is acting as controller) When the I3C is acting as controller, this flag is asserted by hardware to indicate that an hot join request has been received. This flag is cleared when software writes 1 into corresponding I3C_CEVR.CHJF bit.
$00200000 constant SEC_I3C_I3C_EVR_WKPF                             \ wakeup/missed start flag (when the I3C is acting as target) When the I3C is acting as target, this flag is asserted by hardware to indicate that a start has been detected (i.e. a SDA falling edge followed by a SCL falling edge) but on the next SCL falling edge, the I3C kernel clock is (still) gated. Thus an I3C bus transaction may have been lost by the target. The corresponding interrupt may be used to wakeup the device from a low power mode (Sleep or Stop mode). This flag is cleared when software writes 1 into corresponding I3C_CEVR.CWKPF bit.
$00400000 constant SEC_I3C_I3C_EVR_GETF                             \ get flag (when the I3C is acting as target) When the I3C is acting as target, this flag is asserted by hardware to indicate that any direct CCC of get type (GET*** CCC) has been received. This flag is cleared when software writes 1 into corresponding I3C_CEVR.CGETF bit.
$00800000 constant SEC_I3C_I3C_EVR_STAF                             \ get status flag (when the I3C is acting as target) When the I3C is acting as target, this flag is asserted by hardware to indicate that a direct GETSTATUS CCC (get status) has been received. This flag is cleared when software writes 1 into corresponding I3C_CEVR.CSTAF bit.
$01000000 constant SEC_I3C_I3C_EVR_DAUPDF                           \ dynamic address update flag (when the I3C is acting as target) When the I3C is acting as target, this flag is asserted by hardware to indicate that a dynamic address update has been received via any of the broadcast ENTDAA, RSTDAA and direct SETNEWDA CCC. Then, software should read I3C_DEVR0.DA[6:0] to get the maximum write length value. This flag is cleared when software writes 1 into corresponding I3C_CEVR.CDAUPDF bit.
$02000000 constant SEC_I3C_I3C_EVR_MWLUPDF                          \ maximum write length update flag (when the I3C is acting as target) When the I3C is acting as target, this flag is asserted by hardware to indicate that a direct SETMWL CCC (set max write length) has been received. Then, software should read I3C_MAXWLR.MWL[15:0] to get the maximum write length value. This flag is cleared when software writes 1 into corresponding I3C_CEVR.CMWLUPDF bit.
$04000000 constant SEC_I3C_I3C_EVR_MRLUPDF                          \ maximum read length update flag (when the I3C is acting as target) When the I3C is acting as target, this flag is asserted by hardware to indicate that a direct SETMRL CCC (set max read length) has been received. Then, software should read I3C_MAXRLR.MRL[15:0] to get the maximum read length value. This flag is cleared when software writes 1 into corresponding I3C_CEVR.CMRLUPDF bit.
$08000000 constant SEC_I3C_I3C_EVR_RSTF                             \ reset pattern flag (when the I3C is acting as target) When the I3C is acting as target, this flag is asserted by hardware to indicate that a reset pattern has been detected (i.e. 14 SDA transitions while SCL is low, followed by repeated start, then stop). Then, software should read I3C_DEVR0.RSTACT[1:0] and I3C_DEVR0.RSTVAL, to know what reset level is required. If RSTVAL=1: when the RSTF is asserted (and/or the corresponding interrupt if enabled), I3C_DEVR0.RSTACT[1:0] dictates the reset action to be performed by the software if any. If RSTVAL=0: when the RSTF is asserted (and/or the corresponding interrupt if enabled), the software should issue an I3C reset after a first detected reset pattern, and a system reset on the second one. The corresponding interrupt may be used to wakeup the device from a low power mode (Sleep or Stop mode). This flag is cleared when software writes 1 into corresponding I3C_CEVR.CRSTF bit.
$10000000 constant SEC_I3C_I3C_EVR_ASUPDF                           \ activity state update flag (when the I3C is acting as target) When the I3C is acting as target, this flag is asserted by hardware to indicate that the direct or broadcast ENTASx CCC (with x=0...3) has been received. Then, software should read I3C_DEVR0.AS[1:0]. This flag is cleared when software writes 1 into corresponding I3C_CEVR.CASUPDF bit.
$20000000 constant SEC_I3C_I3C_EVR_INTUPDF                          \ interrupt/controller-role/hot-join update flag (when the I3C is acting as target) When the I3C is acting as target, this flag is asserted by hardware to indicate that the direct or broadcast ENEC/DISEC CCC (enable/disable target events) has been received, where a target event is either an interrupt/IBI request, a controller-role request, or an hot-join request. Then, software should read respectively I3C_DEVR0.IBIEN, I3C_DEVR0.CREN or I3C_DEVR0.HJEN. This flag is cleared when software writes 1 into corresponding I3C_CEVR.CINTUPDF bit.
$40000000 constant SEC_I3C_I3C_EVR_DEFF                             \ DEFTGTS flag (when the I3C is acting as target) When the I3C is acting as target (and is typically controller capable), this flag is asserted by hardware to indicate that the broadcast DEFTGTS CCC (define list of targets) has been received. Then, software may store the received data for when getting the controller role. This flag is cleared when software writes 1 into corresponding I3C_CEVR.CDEFF bit.
$80000000 constant SEC_I3C_I3C_EVR_GRPF                             \ group addressing flag (when the I3C is acting as target) When the I3C is acting as target (and is typically controller capable), this flag is asserted by hardware to indicate that the broadcast DEFGRPA CCC (define list of group addresses) has been received. Then, software may store the received data for when getting the controller role. This flag is cleared when software writes 1 into corresponding I3C_CEVR.CGRPF bit.


\
\ @brief I3C interrupt enable register
\ Address offset: 0x54
\ Reset value: 0x00000000
\

$00000004 constant SEC_I3C_I3C_IER_CFNFIE                           \ C-FIFO not full interrupt enable (whatever the I3C is acting as controller/target)
$00000008 constant SEC_I3C_I3C_IER_SFNEIE                           \ S-FIFO not empty interrupt enable (whatever the I3C is acting as controller/target)
$00000010 constant SEC_I3C_I3C_IER_TXFNFIE                          \ TX-FIFO not full interrupt enable (whatever the I3C is acting as controller/target)
$00000020 constant SEC_I3C_I3C_IER_RXFNEIE                          \ RX-FIFO not empty interrupt enable (whatever the I3C is acting as controller/target)
$00000200 constant SEC_I3C_I3C_IER_FCIE                             \ frame complete interrupt enable (whatever the I3C is acting as controller/target)
$00000400 constant SEC_I3C_I3C_IER_RXTGTENDIE                       \ target-initiated read end interrupt enable (when the I3C is acting as controller)
$00000800 constant SEC_I3C_I3C_IER_ERRIE                            \ error interrupt enable (whatever the I3C is acting as controller/target)
$00008000 constant SEC_I3C_I3C_IER_IBIIE                            \ IBI request interrupt enable (when the I3C is acting as controller)
$00010000 constant SEC_I3C_I3C_IER_IBIENDIE                         \ IBI end interrupt enable (when the I3C is acting as target)
$00020000 constant SEC_I3C_I3C_IER_CRIE                             \ controller-role request interrupt enable (when the I3C is acting as controller)
$00040000 constant SEC_I3C_I3C_IER_CRUPDIE                          \ controller-role update interrupt enable (when the I3C is acting as target)
$00080000 constant SEC_I3C_I3C_IER_HJIE                             \ hot-join interrupt enable (when the I3C is acting as controller)
$00200000 constant SEC_I3C_I3C_IER_WKPIE                            \ wakeup interrupt enable (when the I3C is acting as target)
$00400000 constant SEC_I3C_I3C_IER_GETIE                            \ GETxxx CCC interrupt enable (when the I3C is acting as target)
$00800000 constant SEC_I3C_I3C_IER_STAIE                            \ GETSTATUS CCC interrupt enable (when the I3C is acting as target)
$01000000 constant SEC_I3C_I3C_IER_DAUPDIE                          \ ENTDAA/RSTDAA/SETNEWDA CCC interrupt enable (when the I3C is acting as target)
$02000000 constant SEC_I3C_I3C_IER_MWLUPDIE                         \ SETMWL CCC interrupt enable (when the I3C is acting as target)
$04000000 constant SEC_I3C_I3C_IER_MRLUPDIE                         \ SETMRL CCC interrupt enable (when the I3C is acting as target)
$08000000 constant SEC_I3C_I3C_IER_RSTIE                            \ reset pattern interrupt enable (when the I3C is acting as target)
$10000000 constant SEC_I3C_I3C_IER_ASUPDIE                          \ ENTASx CCC interrupt enable (when the I3C is acting as target)
$20000000 constant SEC_I3C_I3C_IER_INTUPDIE                         \ ENEC/DISEC CCC interrupt enable (when the I3C is acting as target)
$40000000 constant SEC_I3C_I3C_IER_DEFIE                            \ DEFTGTS CCC interrupt enable (when the I3C is acting as target)
$80000000 constant SEC_I3C_I3C_IER_GRPIE                            \ DEFGRPA CCC interrupt enable (when the I3C is acting as target)


\
\ @brief I3C clear event register
\ Address offset: 0x58
\ Reset value: 0x00000000
\

$00000200 constant SEC_I3C_I3C_CEVR_CFCF                            \ clear frame complete flag (whatever the I3C is acting as controller/target)
$00000400 constant SEC_I3C_I3C_CEVR_CRXTGTENDF                      \ clear target-initiated read end flag (when the I3C is acting as controller)
$00000800 constant SEC_I3C_I3C_CEVR_CERRF                           \ clear error flag (whatever the I3C is acting as controller/target)
$00008000 constant SEC_I3C_I3C_CEVR_CIBIF                           \ clear IBI request flag (when the I3C is acting as controller)
$00010000 constant SEC_I3C_I3C_CEVR_CIBIENDF                        \ clear IBI end flag (when the I3C is acting as target)
$00020000 constant SEC_I3C_I3C_CEVR_CCRF                            \ clear controller-role request flag (when the I3C is acting as controller)
$00040000 constant SEC_I3C_I3C_CEVR_CCRUPDF                         \ clear controller-role update flag (when the I3C is acting as target)
$00080000 constant SEC_I3C_I3C_CEVR_CHJF                            \ clear hot-join flag (when the I3C is acting as controller)
$00200000 constant SEC_I3C_I3C_CEVR_CWKPF                           \ clear wakeup flag (when the I3C is acting as target)
$00400000 constant SEC_I3C_I3C_CEVR_CGETF                           \ clear GETxxx CCC flag (when the I3C is acting as target)
$00800000 constant SEC_I3C_I3C_CEVR_CSTAF                           \ clear GETSTATUS CCC flag (when the I3C is acting as target)
$01000000 constant SEC_I3C_I3C_CEVR_CDAUPDF                         \ clear ENTDAA/RSTDAA/SETNEWDA CCC flag (when the I3C is acting as target)
$02000000 constant SEC_I3C_I3C_CEVR_CMWLUPDF                        \ clear SETMWL CCC flag (when the I3C is acting as target)
$04000000 constant SEC_I3C_I3C_CEVR_CMRLUPDF                        \ clear SETMRL CCC flag (when the I3C is acting as target)
$08000000 constant SEC_I3C_I3C_CEVR_CRSTF                           \ clear reset pattern flag (when the I3C is acting as target)
$10000000 constant SEC_I3C_I3C_CEVR_CASUPDF                         \ clear ENTASx CCC flag (when the I3C is acting as target)
$20000000 constant SEC_I3C_I3C_CEVR_CINTUPDF                        \ clear ENEC/DISEC CCC flag (when the I3C is acting as target)
$40000000 constant SEC_I3C_I3C_CEVR_CDEFF                           \ clear DEFTGTS CCC flag (when the I3C is acting as target)
$80000000 constant SEC_I3C_I3C_CEVR_CGRPF                           \ clear DEFGRPA CCC flag (when the I3C is acting as target)


\
\ @brief I3C own device characteristics register
\ Address offset: 0x60
\ Reset value: 0x00000000
\

$00000001 constant SEC_I3C_I3C_DEVR0_DAVAL                          \ dynamic address is valid (when the I3C is acting as target) When the I3C is acting as controller, this field can be written by software, for validating its own dynamic address, for example before a controller-role hand-off. When the I3C is acting as target, this field is asserted by hardware on the acknowledge of the broadcast ENTDAA CCC or the direct SETNEWDA CCC, and this field is cleared by hardware on the acknowledge of the broadcast RSTDAA CCC.
$000000fe constant SEC_I3C_I3C_DEVR0_DA                             \ 7-bit dynamic address When the I3C is acting as controller, this field can be written by software, for defining its own dynamic address. When the I3C is acting as target, this field is updated by hardware on the reception of either the broadcast ENTDAA CCC or the direct SETNEWDA CCC.
$00010000 constant SEC_I3C_I3C_DEVR0_IBIEN                          \ IBI request enable (when the I3C is acting as target) This field is initially written by software when I3C_CFGR.EN=0, and is updated by hardware on the reception of DISEC CCC with DISINT=1 (i.e. cleared) and the reception of ENEC CCC with ENINT=1 (i.e. set).
$00020000 constant SEC_I3C_I3C_DEVR0_CREN                           \ controller-role request enable (when the I3C is acting as target) This field is initially written by software when I3C_CFGR.EN=0, and is updated by hardware on the reception of DISEC CCC with DISCR=1 (i.e. cleared) and the reception of ENEC CCC with ENCR=1 (i.e. set).
$00080000 constant SEC_I3C_I3C_DEVR0_HJEN                           \ hot-join request enable (when the I3C is acting as target) This field is initially written by software when I3C_CFGR.EN=0, and is updated by hardware on the reception of DISEC CCC with DISHJ=1 (i.e. cleared) and the reception of ENEC CCC with ENHJ=1 (i.e. set).
$00300000 constant SEC_I3C_I3C_DEVR0_AS                             \ activity state (when the I3C is acting as target) This read field is updated by hardware on the reception of a ENTASx CCC (enter activity state, with x=0-3):
$00c00000 constant SEC_I3C_I3C_DEVR0_RSTACT                         \ reset action/level on received reset pattern (when the I3C is acting as target) This read field is used by hardware on the reception of a direct read RSTACT CCC in order to return the corresponding data byte on the I3C bus.
$01000000 constant SEC_I3C_I3C_DEVR0_RSTVAL                         \ reset action is valid (when the I3C is acting as target) This read bit is asserted by hardware to indicate that the RTSACT[1:0] field has been updated on the reception of a broadcast or direct write RSTACT CCC (target reset action) and is valid. This field is cleared by hardware when the target receives a frame start. If RSTVAL=1: when the RSTF is asserted (and/or the corresponding interrupt if enabled), I3C_DEVR0.RSTACT[1:0] dictates the reset action to be performed by the software if any. If RSTVAL=0: when the RSTF is asserted (and/or the corresponding interrupt if enabled), the software should issue an I3C reset after a first detected reset pattern, and a system reset on the second one.


\
\ @brief I3C device 1 characteristics register
\ Address offset: 0x64
\ Reset value: 0x00000000
\

$000000fe constant SEC_I3C_I3C_DEVR1_DA                             \ assigned I3C dynamic address to target x (when the I3C is acting as controller) When the I3C is acting as controller, this field should be written by software to store the 7-bit dynamic address that the controller sends via a broadcast ENTDAA or a direct SETNEWDA CCC which has been acknowledged by the target x. Writing to this field has no impact when the read field I3C_DEVRx.DIS=1.
$00010000 constant SEC_I3C_I3C_DEVR1_IBIACK                         \ IBI request acknowledge (when the I3C is acting as controller) When the I3C is acting as controller, this bit is written by software to define the acknowledge policy to be applied on the I3C bus on the reception of a IBI request from target x: - After the NACK, the message continues as initially programmed (the target is aware of the NACK and can emit another IBI request later on) - The field DIS is asserted by hardware to protect DA[6:0] from being modified by software meanwhile the hardware can store internally the current DA[6:0] into the kernel clock domain. - After the ACK, the controller logs the IBI payload data, if any, depending on I3C_DEVRx.IBIDEN. - The software is notified by the IBI flag (i.e. I3C_EVR.IBIF=1) and/or the corresponding interrupt if enabled; - Independently from IBIACK configuration for this or other devices, further IBI request(s) are NACKed until IBI request flag (i.e. I3C_EVR.IBIF) and controller-role request flag (i.e. I3C_EVR.CRF) are both cleared.
$00020000 constant SEC_I3C_I3C_DEVR1_CRACK                          \ controller-role request acknowledge (when the I3C is acting as controller) When the I3C is acting as controller, this bit is written by software to define the acknowledge policy to be applied on the I3C bus on the reception of a controller-role request from target x: After the NACK, the message continues as initially programmed (the target is aware of the NACK and can emit another controller-role request later on) - The field DIS is asserted by hardware to protect DA[6:0] from being modified by software meanwhile the hardware can store internally the current DA[6:0] into the kernel clock domain. - After the ACK, the message continues as initially programmed. The software is notified by the controller-role request flag (i.e. I3C_EVR.CRF=1) and/or the corresponding interrupt if enabled; For effectively granting the controller-role to the requesting secondary controller, software should issue a GETACCCR (formerly known as GETACCMST), followed by a STOP. - Independently of CRACK configuration for this or other devices, further controller-role request(s) are NACKed until controller-role request flag (i.e. I3C_EVR.CRF) and IBI flag (i.e. I3C_EVR.IBIF) are both cleared.
$00040000 constant SEC_I3C_I3C_DEVR1_IBIDEN                         \ IBI data enable (when the I3C is acting as controller) When the I3C is acting as controller, this bit should be written by software to store the BCR[2] bit as received from the target x during broadcast ENTDAA or direct GETBCR CCC via the received I3C_RDR. Writing to this field has no impact when the read field I3C_DEVRx.DIS=1.
$00080000 constant SEC_I3C_I3C_DEVR1_SUSP                           \ suspend/stop I3C transfer on received IBI (when the I3C is acting as controller) When the I3C is acting as controller, this bit is used to receive an IBI from target x with pending read notification feature (i.e. with received MDB[7:5]=3'b101). If this bit is set, when an IBI is received (i.e. I3C_EVR.IBIF=1), a Stop is emitted on the I3C bus and the C-FIFO is automatically flushed by hardware; to avoid a next private read communication issue if a previous private read message to the target x was stored in the C-FIFO.
$80000000 constant SEC_I3C_I3C_DEVR1_DIS                            \ DA[6:0] write disabled (when the I3C is acting as controller) When the I3C is acting as controller, once that software set IBIACK=1 or CRACK=1, this read bit is set by hardware (i.e. DIS=1) to lock the configured DA[6:0] and IBIDEN values. Then, to be able to next modify DA[6:0] or IBIDEN, the software must wait for this field DIS to be de-asserted by hardware (i.e. polling on DIS=0) before modifying these two assigned values to the target x. Indeed, the target may be requesting an IBI or a controller-role meanwhile the controller intends to modify DA[6:0] or IBIDEN.


\
\ @brief I3C device 2 characteristics register
\ Address offset: 0x68
\ Reset value: 0x00000000
\

$000000fe constant SEC_I3C_I3C_DEVR2_DA                             \ assigned I3C dynamic address to target x (when the I3C is acting as controller) When the I3C is acting as controller, this field should be written by software to store the 7-bit dynamic address that the controller sends via a broadcast ENTDAA or a direct SETNEWDA CCC which has been acknowledged by the target x. Writing to this field has no impact when the read field I3C_DEVRx.DIS=1.
$00010000 constant SEC_I3C_I3C_DEVR2_IBIACK                         \ IBI request acknowledge (when the I3C is acting as controller) When the I3C is acting as controller, this bit is written by software to define the acknowledge policy to be applied on the I3C bus on the reception of a IBI request from target x: - After the NACK, the message continues as initially programmed (the target is aware of the NACK and can emit another IBI request later on) - The field DIS is asserted by hardware to protect DA[6:0] from being modified by software meanwhile the hardware can store internally the current DA[6:0] into the kernel clock domain. - After the ACK, the controller logs the IBI payload data, if any, depending on I3C_DEVRx.IBIDEN. - The software is notified by the IBI flag (i.e. I3C_EVR.IBIF=1) and/or the corresponding interrupt if enabled; - Independently from IBIACK configuration for this or other devices, further IBI request(s) are NACKed until IBI request flag (i.e. I3C_EVR.IBIF) and controller-role request flag (i.e. I3C_EVR.CRF) are both cleared.
$00020000 constant SEC_I3C_I3C_DEVR2_CRACK                          \ controller-role request acknowledge (when the I3C is acting as controller) When the I3C is acting as controller, this bit is written by software to define the acknowledge policy to be applied on the I3C bus on the reception of a controller-role request from target x: After the NACK, the message continues as initially programmed (the target is aware of the NACK and can emit another controller-role request later on) - The field DIS is asserted by hardware to protect DA[6:0] from being modified by software meanwhile the hardware can store internally the current DA[6:0] into the kernel clock domain. - After the ACK, the message continues as initially programmed. The software is notified by the controller-role request flag (i.e. I3C_EVR.CRF=1) and/or the corresponding interrupt if enabled; For effectively granting the controller-role to the requesting secondary controller, software should issue a GETACCCR (formerly known as GETACCMST), followed by a STOP. - Independently of CRACK configuration for this or other devices, further controller-role request(s) are NACKed until controller-role request flag (i.e. I3C_EVR.CRF) and IBI flag (i.e. I3C_EVR.IBIF) are both cleared.
$00040000 constant SEC_I3C_I3C_DEVR2_IBIDEN                         \ IBI data enable (when the I3C is acting as controller) When the I3C is acting as controller, this bit should be written by software to store the BCR[2] bit as received from the target x during broadcast ENTDAA or direct GETBCR CCC via the received I3C_RDR. Writing to this field has no impact when the read field I3C_DEVRx.DIS=1.
$00080000 constant SEC_I3C_I3C_DEVR2_SUSP                           \ suspend/stop I3C transfer on received IBI (when the I3C is acting as controller) When the I3C is acting as controller, this bit is used to receive an IBI from target x with pending read notification feature (i.e. with received MDB[7:5]=3'b101). If this bit is set, when an IBI is received (i.e. I3C_EVR.IBIF=1), a Stop is emitted on the I3C bus and the C-FIFO is automatically flushed by hardware; to avoid a next private read communication issue if a previous private read message to the target x was stored in the C-FIFO.
$80000000 constant SEC_I3C_I3C_DEVR2_DIS                            \ DA[6:0] write disabled (when the I3C is acting as controller) When the I3C is acting as controller, once that software set IBIACK=1 or CRACK=1, this read bit is set by hardware (i.e. DIS=1) to lock the configured DA[6:0] and IBIDEN values. Then, to be able to next modify DA[6:0] or IBIDEN, the software must wait for this field DIS to be de-asserted by hardware (i.e. polling on DIS=0) before modifying these two assigned values to the target x. Indeed, the target may be requesting an IBI or a controller-role meanwhile the controller intends to modify DA[6:0] or IBIDEN.


\
\ @brief I3C device 3 characteristics register
\ Address offset: 0x6C
\ Reset value: 0x00000000
\

$000000fe constant SEC_I3C_I3C_DEVR3_DA                             \ assigned I3C dynamic address to target x (when the I3C is acting as controller) When the I3C is acting as controller, this field should be written by software to store the 7-bit dynamic address that the controller sends via a broadcast ENTDAA or a direct SETNEWDA CCC which has been acknowledged by the target x. Writing to this field has no impact when the read field I3C_DEVRx.DIS=1.
$00010000 constant SEC_I3C_I3C_DEVR3_IBIACK                         \ IBI request acknowledge (when the I3C is acting as controller) When the I3C is acting as controller, this bit is written by software to define the acknowledge policy to be applied on the I3C bus on the reception of a IBI request from target x: - After the NACK, the message continues as initially programmed (the target is aware of the NACK and can emit another IBI request later on) - The field DIS is asserted by hardware to protect DA[6:0] from being modified by software meanwhile the hardware can store internally the current DA[6:0] into the kernel clock domain. - After the ACK, the controller logs the IBI payload data, if any, depending on I3C_DEVRx.IBIDEN. - The software is notified by the IBI flag (i.e. I3C_EVR.IBIF=1) and/or the corresponding interrupt if enabled; - Independently from IBIACK configuration for this or other devices, further IBI request(s) are NACKed until IBI request flag (i.e. I3C_EVR.IBIF) and controller-role request flag (i.e. I3C_EVR.CRF) are both cleared.
$00020000 constant SEC_I3C_I3C_DEVR3_CRACK                          \ controller-role request acknowledge (when the I3C is acting as controller) When the I3C is acting as controller, this bit is written by software to define the acknowledge policy to be applied on the I3C bus on the reception of a controller-role request from target x: After the NACK, the message continues as initially programmed (the target is aware of the NACK and can emit another controller-role request later on) - The field DIS is asserted by hardware to protect DA[6:0] from being modified by software meanwhile the hardware can store internally the current DA[6:0] into the kernel clock domain. - After the ACK, the message continues as initially programmed. The software is notified by the controller-role request flag (i.e. I3C_EVR.CRF=1) and/or the corresponding interrupt if enabled; For effectively granting the controller-role to the requesting secondary controller, software should issue a GETACCCR (formerly known as GETACCMST), followed by a STOP. - Independently of CRACK configuration for this or other devices, further controller-role request(s) are NACKed until controller-role request flag (i.e. I3C_EVR.CRF) and IBI flag (i.e. I3C_EVR.IBIF) are both cleared.
$00040000 constant SEC_I3C_I3C_DEVR3_IBIDEN                         \ IBI data enable (when the I3C is acting as controller) When the I3C is acting as controller, this bit should be written by software to store the BCR[2] bit as received from the target x during broadcast ENTDAA or direct GETBCR CCC via the received I3C_RDR. Writing to this field has no impact when the read field I3C_DEVRx.DIS=1.
$00080000 constant SEC_I3C_I3C_DEVR3_SUSP                           \ suspend/stop I3C transfer on received IBI (when the I3C is acting as controller) When the I3C is acting as controller, this bit is used to receive an IBI from target x with pending read notification feature (i.e. with received MDB[7:5]=3'b101). If this bit is set, when an IBI is received (i.e. I3C_EVR.IBIF=1), a Stop is emitted on the I3C bus and the C-FIFO is automatically flushed by hardware; to avoid a next private read communication issue if a previous private read message to the target x was stored in the C-FIFO.
$80000000 constant SEC_I3C_I3C_DEVR3_DIS                            \ DA[6:0] write disabled (when the I3C is acting as controller) When the I3C is acting as controller, once that software set IBIACK=1 or CRACK=1, this read bit is set by hardware (i.e. DIS=1) to lock the configured DA[6:0] and IBIDEN values. Then, to be able to next modify DA[6:0] or IBIDEN, the software must wait for this field DIS to be de-asserted by hardware (i.e. polling on DIS=0) before modifying these two assigned values to the target x. Indeed, the target may be requesting an IBI or a controller-role meanwhile the controller intends to modify DA[6:0] or IBIDEN.


\
\ @brief I3C device 4 characteristics register
\ Address offset: 0x70
\ Reset value: 0x00000000
\

$000000fe constant SEC_I3C_I3C_DEVR4_DA                             \ assigned I3C dynamic address to target x (when the I3C is acting as controller) When the I3C is acting as controller, this field should be written by software to store the 7-bit dynamic address that the controller sends via a broadcast ENTDAA or a direct SETNEWDA CCC which has been acknowledged by the target x. Writing to this field has no impact when the read field I3C_DEVRx.DIS=1.
$00010000 constant SEC_I3C_I3C_DEVR4_IBIACK                         \ IBI request acknowledge (when the I3C is acting as controller) When the I3C is acting as controller, this bit is written by software to define the acknowledge policy to be applied on the I3C bus on the reception of a IBI request from target x: - After the NACK, the message continues as initially programmed (the target is aware of the NACK and can emit another IBI request later on) - The field DIS is asserted by hardware to protect DA[6:0] from being modified by software meanwhile the hardware can store internally the current DA[6:0] into the kernel clock domain. - After the ACK, the controller logs the IBI payload data, if any, depending on I3C_DEVRx.IBIDEN. - The software is notified by the IBI flag (i.e. I3C_EVR.IBIF=1) and/or the corresponding interrupt if enabled; - Independently from IBIACK configuration for this or other devices, further IBI request(s) are NACKed until IBI request flag (i.e. I3C_EVR.IBIF) and controller-role request flag (i.e. I3C_EVR.CRF) are both cleared.
$00020000 constant SEC_I3C_I3C_DEVR4_CRACK                          \ controller-role request acknowledge (when the I3C is acting as controller) When the I3C is acting as controller, this bit is written by software to define the acknowledge policy to be applied on the I3C bus on the reception of a controller-role request from target x: After the NACK, the message continues as initially programmed (the target is aware of the NACK and can emit another controller-role request later on) - The field DIS is asserted by hardware to protect DA[6:0] from being modified by software meanwhile the hardware can store internally the current DA[6:0] into the kernel clock domain. - After the ACK, the message continues as initially programmed. The software is notified by the controller-role request flag (i.e. I3C_EVR.CRF=1) and/or the corresponding interrupt if enabled; For effectively granting the controller-role to the requesting secondary controller, software should issue a GETACCCR (formerly known as GETACCMST), followed by a STOP. - Independently of CRACK configuration for this or other devices, further controller-role request(s) are NACKed until controller-role request flag (i.e. I3C_EVR.CRF) and IBI flag (i.e. I3C_EVR.IBIF) are both cleared.
$00040000 constant SEC_I3C_I3C_DEVR4_IBIDEN                         \ IBI data enable (when the I3C is acting as controller) When the I3C is acting as controller, this bit should be written by software to store the BCR[2] bit as received from the target x during broadcast ENTDAA or direct GETBCR CCC via the received I3C_RDR. Writing to this field has no impact when the read field I3C_DEVRx.DIS=1.
$00080000 constant SEC_I3C_I3C_DEVR4_SUSP                           \ suspend/stop I3C transfer on received IBI (when the I3C is acting as controller) When the I3C is acting as controller, this bit is used to receive an IBI from target x with pending read notification feature (i.e. with received MDB[7:5]=3'b101). If this bit is set, when an IBI is received (i.e. I3C_EVR.IBIF=1), a Stop is emitted on the I3C bus and the C-FIFO is automatically flushed by hardware; to avoid a next private read communication issue if a previous private read message to the target x was stored in the C-FIFO.
$80000000 constant SEC_I3C_I3C_DEVR4_DIS                            \ DA[6:0] write disabled (when the I3C is acting as controller) When the I3C is acting as controller, once that software set IBIACK=1 or CRACK=1, this read bit is set by hardware (i.e. DIS=1) to lock the configured DA[6:0] and IBIDEN values. Then, to be able to next modify DA[6:0] or IBIDEN, the software must wait for this field DIS to be de-asserted by hardware (i.e. polling on DIS=0) before modifying these two assigned values to the target x. Indeed, the target may be requesting an IBI or a controller-role meanwhile the controller intends to modify DA[6:0] or IBIDEN.


\
\ @brief I3C maximum read length register
\ Address offset: 0x90
\ Reset value: 0x00000000
\

$0000ffff constant SEC_I3C_I3C_MAXRLR_MRL                           \ maximum data read length (when I3C is acting as target) This field is initially written by software when I3C_CFGR.EN=0 and updated by hardware on the reception of SETMRL command (with potentially also updated IBIP[2:0]). Software is notified of a MRL update by the I3C_EVR.MRLUPF and the corresponding interrupt if enabled. This field is used by hardware to return the value on the I3C bus when the target receives a GETMRL CCC.
$00070000 constant SEC_I3C_I3C_MAXRLR_IBIP                          \ IBI payload data size, in bytes (when I3C is acting as target) This field is initially written by software when I3C_CFGR.EN=0 to set the number of data bytes to be sent to the controller after an IBI request has been acknowledged.This field may be updated by hardware on the reception of SETMRL command (which potentially also updated IBIP[2:0]). Software is notified of a MRL update by the I3C_EVR.MRLUPF and the corresponding interrupt if enabled. others: same as 100


\
\ @brief I3C maximum write length register
\ Address offset: 0x94
\ Reset value: 0x00000000
\

$0000ffff constant SEC_I3C_I3C_MAXWLR_MWL                           \ maximum data write length (when I3C is acting as target) This field is initially written by software when I3C_CFGR.EN=0 and updated by hardware on the reception of SETMWL command. Software is notified of a MWL update by the I3C_EVR.MWLUPF and the corresponding interrupt if enabled. This field is used by hardware to return the value on the I3C bus when the target receives a GETMWL CCC.


\
\ @brief I3C timing register 0
\ Address offset: 0xA0
\ Reset value: 0x00000000
\

$000000ff constant SEC_I3C_I3C_TIMINGR0_SCLL_PP                     \ SCL low duration in I3C push-pull phases, in number of kernel clocks cycles: tSCLL_PP = (SCLL_PP + 1) x tI3CCLK SCLL_PP is used to generate tLOW (I3C) timing.
$0000ff00 constant SEC_I3C_I3C_TIMINGR0_SCLH_I3C                    \ SCL high duration, used for I3C messages (both in push-pull and open-drain phases), in number of kernel clocks cycles: tSCLH_I3C = (SCLH_I3C + 1) x tI3CCLK SCLH_I3C is used to generate both tHIGH (I3C) and tHIGH_MIXED timings.
$00ff0000 constant SEC_I3C_I3C_TIMINGR0_SCLL_OD                     \ SCL low duration in open-drain phases, used for legacy I2C commands and for I3C open-drain phases (address header phase following a START, not a Repeated START), in number of kernel clocks cycles: tSCLL_OD = (SCLL_OD + 1) x tI3CCLK SCLL_OD is used to generate both tLOW (I2C) and tLOW_OD timings (max. of the two).
$ff000000 constant SEC_I3C_I3C_TIMINGR0_SCLH_I2C                    \ SCL high duration, used for legacy I2C commands, in number of kernel clocks cycles: tSCLH_I2C = (SCLH_I2C + 1) x tI3CCLK SCLH_I2C is used to generate tHIGH (I2C) timing.


\
\ @brief I3C timing register 1
\ Address offset: 0xA4
\ Reset value: 0x00000000
\

$000000ff constant SEC_I3C_I3C_TIMINGR1_AVAL                        \ number of kernel clock cycles, that is used whatever I3C is acting as controller or target, to set the following MIPI I3C timings, like bus available condition time: When the I3C is acting as target: for bus available condition time: it must wait for (bus available condition) time to be elapsed after a stop and before issuing a start request for an IBI or a controller-role request (i.e. bus free condition is sustained for at least tAVAL). refer to MIPI timing tAVAL = 1 s. This timing is defined by: tAVAL = (AVAL[7:0] + 2) x tI3CCLK for bus idle condition time: it must wait for (bus idle condition) time to be elapsed after that both SDA and SCL are continuously high and stable before issuing a hot-join event. Refer to MIPI v1.1 timing tIDLE = 200 s . This timing is defined by: tIDLE = (AVAL[7:0] + 2) x 200 x tI3CCLK When the I3C is acting as controller, it can not stall the clock beyond a maximum stall time (i.e. stall the SCL clock low), as follows: on first bit of assigned address during dynamic address assignment: it can not stall the clock beyond the MIPI timing tSTALLDAA = 15 ms. This timing is defined by: tSTALLDAA = (AVAL[7:0] + 1) x 15000 x tI3CCLK on ACK/NACK phase of I3C/I2C transfer, on parity bit of write data transfer, on transition bit of I3C read transfer: it can not stall the clock beyond the MIPI timing tSTALL = 100 s. This timing is defined by: tSTALL = (AVAL[7:0] + 1) x 100 x tI3CCLK Whatever the I3C is acting as controller or as (controller-capable) target, during a controller-role hand-off procedure: The new controller must wait for a time (refer to MIPI timing tNEWCRLock) before pulling SDA low (i.e. issuing a start). And the active controller must wait for the same time while monitoring new controller and before testing the new controller by pulling SDA low. This time to wait is dependent on the defined I3C_TIMINGR1.ANSCR[1:0], as follows: If ASNCR[1:0]=00: tNEWCRLock = (AVAL[7:0] + 1) x tI3CCLK If ASNCR[1:0]=01: tNEWCRLock = (AVAL[7:0] + 1) x 100 x tI3CCLK If ASNCR[1:0]=10: tNEWCRLock = (AVAL[7:0] + 1) x 2000 x tI3CCLK If ASNCR[1:0]=11: tNEWCRLock = (AVAL[7:0] + 1) x 50000 x tI3CCLK
$00000300 constant SEC_I3C_I3C_TIMINGR1_ASNCR                       \ activity state of the new controller (when I3C is acting asactive- controller) This field indicates the time to wait before being accessed as new target, refer to the other field AVAL[7:0]. This field can be modified only when the I3C is acting as controller.
$007f0000 constant SEC_I3C_I3C_TIMINGR1_FREE                        \ number of kernel clocks cycles that is used to set some MIPI timings like bus free condition time (when the I3C is acting as controller) When the I3C is acting as controller: for I3C start timing: it must wait for (bus free condition) time to be elapsed after a stop and before a start, refer to MIPI timings (I3C) tCAS and (I2C) tBUF. These timings are defined by: tBUF= tCAS = [ (FREE[6:0] + 1) x 2(0,5 + SDA_HD)] x tI3CCLK Note: for pure I3C bus: tCASmin= 38,4 ns. Note: for pure I3C bus: tCASmax=1s, 100s, 2ms, 50ms for respectively ENTAS0,1,2, and 3. Note: for mixed bus with I2C fm+ device: tBUFmin = 0,5 s. Note: for mixed bus with I2C fm device: tBUFmin = 1,3 s. for I3C repeated start timing: it must wait for time to be elapsed after a repeated start (i.e. SDA is de-asserted) and before driving SCL low, refer to. MIPI timing tCASr. This timing is defined by: tCASr = [ (FREE[6:0] + 1) x 2(0,5 + SDA_HD)] x tI3CCLK for I3C stop timing: it must wait for time to be elapsed after that the SCL clock is driven high and before the stop condition (i.e. SDA is asserted). This timing is defined by: tCBP = (FREE[6:0] + 1) x tI3CCLK for I3C repeated start timing (T-bit when controller ends read with repeated start followed by stop): it must wait for time to be elapsed after that the SCL clock is driven high and before the repeated start condition (i.e. SDA is de-asserted). This timing is defined by: tCBSr = (FREE[6:0] + 1) x tI3CCLK
$10000000 constant SEC_I3C_I3C_TIMINGR1_SDA_HD                      \ SDA hold time (when the I3C is acting as controller), in number of kernel clocks cycles (refer to MIPI timing SDA hold time in push-pull tHD_PP):


\
\ @brief I3C timing register 2
\ Address offset: 0xA8
\ Reset value: 0x00000000
\

$00000001 constant SEC_I3C_I3C_TIMINGR2_STALLT                      \ Controller clock stall on T-bit phase of Data enable The SCL is stalled during STALL x tSCLL_PP in the T-bit phase (before 9th bit). This allows the target to prepare data to be sent.
$00000002 constant SEC_I3C_I3C_TIMINGR2_STALLD                      \ controller clock stall on PAR phase of Data enable The SCL is stalled during STALL x tSCLL_PP in the T-bit phase (before 9th bit). This allows the target to read received data.
$00000004 constant SEC_I3C_I3C_TIMINGR2_STALLC                      \ controller clock stall on PAR phase of CCC enable The SCL is stalled during STALL x tSCLL_PP in the T-bit phase of common command code (before 9th bit). This allows the target to decode the command.
$00000008 constant SEC_I3C_I3C_TIMINGR2_STALLA                      \ controller clock stall enable on ACK phase The SCL is stalled (during tSCLL_STALLas defined by STALL) in the address ACK/NACK phase (before 9th bit). This allows the target to prepare data or the controller to respond to target interrupt.
$0000ff00 constant SEC_I3C_I3C_TIMINGR2_STALL                       \ controller clock stall time, in number of kernel clock cycles tSCLL_STALL = STALL x tI3CCLK


\
\ @brief I3C bus characteristics register
\ Address offset: 0xC0
\ Reset value: 0x00000000
\

$00000001 constant SEC_I3C_I3C_BCR_BCR0                             \ max data speed limitation
$00000004 constant SEC_I3C_I3C_BCR_BCR2                             \ in-band interrupt (IBI) payload
$00000040 constant SEC_I3C_I3C_BCR_BCR6                             \ controller capable


\
\ @brief I3C device characteristics register
\ Address offset: 0xC4
\ Reset value: 0x00000000
\

$000000ff constant SEC_I3C_I3C_DCR_DCR                              \ device characteristics ID others: ID to describe the type of the I3C sensor/device Note: The latest MIPI DCR ID assignments are available at: https://www.mipi.org/MIPI_I3C_device_characteristics_register


\
\ @brief I3C get capability register
\ Address offset: 0xC8
\ Reset value: 0x00000000
\

$00004000 constant SEC_I3C_I3C_GETCAPR_CAPPEND                      \ IBI MDB support for pending read notification This bit is written by software during bus initialization (i.e. I3C_CFGR.EN=0) and indicates the support (or not) of the pending read notification via the IBI MDB[7:0] value. This bit is used to return the GETCAP3 byte in response to the GETCAPS CCC format 1.


\
\ @brief I3C controller-role capability register
\ Address offset: 0xCC
\ Reset value: 0x00000000
\

$00000008 constant SEC_I3C_I3C_CRCAPR_CAPDHOFF                      \ delayed controller-role hand-off This bit is written by software during bus initialization (i.e. I3C_CFGR.EN=0) and indicates if this target I3C may need additional time to process a controller-role hand-off requested by the current controller. This bit is used to return the CRCAP2 byte in response to the GETCAPS CCC format 2.
$00000200 constant SEC_I3C_I3C_CRCAPR_CAPGRP                        \ group management support (when acting as controller) This bit is written by software during bus initialization (i.e. I3C_CFGR.EN=0) and indicates if the I3C is able to support group management when it acts as a controller (after controller-role hand-off) via emitted DEFGRPA, RSTGRPA, and SETGRPA CCC. This bit is used to return the CRCAP1 byte in response to the GETCAPS CCC format 2.


\
\ @brief I3C get capability register
\ Address offset: 0xD0
\ Reset value: 0x00000000
\

$00000003 constant SEC_I3C_I3C_GETMXDSR_HOFFAS                      \ controller hand-off activity state This bit is written by software during bus initialization (i.e. I3C_CFGR.EN=0) and indicates in which initial activity state the (other) current controller should expect the I3C bus after a controller-role hand-off to this controller-capable I3C, when returning the defining byte CRHDLY (0x91) to a GETMXDS CCC. This 2-bit field is used to return the CRHDLY1 byte in response to the GETCAPS CCC format 3, in order to state which is the activity state of this I3C when becoming controller after a controller-role hand-off, and consequently the time the former controller should wait before testing this I3C to be confirmed its ownership.
$00000300 constant SEC_I3C_I3C_GETMXDSR_FMT                         \ GETMXDS CCC format
$00ff0000 constant SEC_I3C_I3C_GETMXDSR_RDTURN                      \ programmed byte of the 3-byte MaxRdTurn (maximum read turnaround byte) This bit is written by software during bus initialization (i.e. I3C_CFGR.EN=0) and writes the value of the selected byte (via the FMT[1:0] field) of the 3-byte MaxRdTurn which is returned in response to the GETMXDS CCC format 2 to encode the maximum read turnaround time.
$01000000 constant SEC_I3C_I3C_GETMXDSR_TSCO                        \ clock-to-data turnaround time (tSCO) This bit is written by software during bus initialization (i.e. I3C_CFGR.EN=0) and is used to specify the clock-to-data turnaround time tSCO (vs the value of 12 ns). This bit is used by the hardware in response to the GETMXDS CCC to return the encoded clock-to-data turnaround time via the returned MaxRd[5:3] bits.


\
\ @brief I3C extended provisioned ID register
\ Address offset: 0xD4
\ Reset value: 0x02080000
\

$0000f000 constant SEC_I3C_I3C_EPIDR_MIPIID                         \ 4-bit MIPI Instance ID This field is written by software to set and identify individually each instance of this I3C IP with a specific number on a single I3C bus. This field represents the bits[15:12] of the 48-bit provisioned ID. Note: The bits[11:0] of the provisioned ID may be 0.
$00010000 constant SEC_I3C_I3C_EPIDR_IDTSEL                         \ provisioned ID type selector This field is set as 0 i.e. vendor fixed value. This field represents the bit[32] of the 48-bit provisioned ID. Note: The bits[31:16] of the provisioned ID may be 0.
$fffe0000 constant SEC_I3C_I3C_EPIDR_MIPIMID                        \ 15-bit MIPI manufacturer ID This read field is the 15-bit STMicroelectronics MIPI ID i.e. 0x0104. This field represents the bits[47:33] of the 48-bit provisioned ID.


\
\ @brief Improved inter-integrated circuit
\
$50005c00 constant SEC_I3C_I3C_CR  \ offset: 0x00 : I3C message control register
$50005c00 constant SEC_I3C_I3C_CR_ALTERNATE  \ offset: 0x00 : I3C message control register alternate
$50005c04 constant SEC_I3C_I3C_CFGR  \ offset: 0x04 : I3C configuration register
$50005c10 constant SEC_I3C_I3C_RDR  \ offset: 0x10 : I3C receive data byte register
$50005c14 constant SEC_I3C_I3C_RDWR  \ offset: 0x14 : I3C receive data word register
$50005c18 constant SEC_I3C_I3C_TDR  \ offset: 0x18 : I3C transmit data byte register
$50005c1c constant SEC_I3C_I3C_TDWR  \ offset: 0x1C : I3C transmit data word register
$50005c20 constant SEC_I3C_I3C_IBIDR  \ offset: 0x20 : I3C IBI payload data register
$50005c24 constant SEC_I3C_I3C_TGTTDR  \ offset: 0x24 : I3C target transmit configuration register
$50005c30 constant SEC_I3C_I3C_SR  \ offset: 0x30 : I3C status register
$50005c34 constant SEC_I3C_I3C_SER  \ offset: 0x34 : I3C status error register
$50005c40 constant SEC_I3C_I3C_RMR  \ offset: 0x40 : I3C received message register
$50005c50 constant SEC_I3C_I3C_EVR  \ offset: 0x50 : I3C event register
$50005c54 constant SEC_I3C_I3C_IER  \ offset: 0x54 : I3C interrupt enable register
$50005c58 constant SEC_I3C_I3C_CEVR  \ offset: 0x58 : I3C clear event register
$50005c60 constant SEC_I3C_I3C_DEVR0  \ offset: 0x60 : I3C own device characteristics register
$50005c64 constant SEC_I3C_I3C_DEVR1  \ offset: 0x64 : I3C device 1 characteristics register
$50005c68 constant SEC_I3C_I3C_DEVR2  \ offset: 0x68 : I3C device 2 characteristics register
$50005c6c constant SEC_I3C_I3C_DEVR3  \ offset: 0x6C : I3C device 3 characteristics register
$50005c70 constant SEC_I3C_I3C_DEVR4  \ offset: 0x70 : I3C device 4 characteristics register
$50005c90 constant SEC_I3C_I3C_MAXRLR  \ offset: 0x90 : I3C maximum read length register
$50005c94 constant SEC_I3C_I3C_MAXWLR  \ offset: 0x94 : I3C maximum write length register
$50005ca0 constant SEC_I3C_I3C_TIMINGR0  \ offset: 0xA0 : I3C timing register 0
$50005ca4 constant SEC_I3C_I3C_TIMINGR1  \ offset: 0xA4 : I3C timing register 1
$50005ca8 constant SEC_I3C_I3C_TIMINGR2  \ offset: 0xA8 : I3C timing register 2
$50005cc0 constant SEC_I3C_I3C_BCR  \ offset: 0xC0 : I3C bus characteristics register
$50005cc4 constant SEC_I3C_I3C_DCR  \ offset: 0xC4 : I3C device characteristics register
$50005cc8 constant SEC_I3C_I3C_GETCAPR  \ offset: 0xC8 : I3C get capability register
$50005ccc constant SEC_I3C_I3C_CRCAPR  \ offset: 0xCC : I3C controller-role capability register
$50005cd0 constant SEC_I3C_I3C_GETMXDSR  \ offset: 0xD0 : I3C get capability register
$50005cd4 constant SEC_I3C_I3C_EPIDR  \ offset: 0xD4 : I3C extended provisioned ID register

